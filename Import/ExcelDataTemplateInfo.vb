
Public Class ExcelDataTemplateInfo
    Public DataDictionary As New Dictionary(Of ImportTableInfo, DataTable)
    Public FileNo As String
    Public SurveyDate As Date
    Public TemplateVersion As Double
    Public FileName As String
    Private Package As GRC.Excel.Package = Nothing

    Public Sub New(pPackage As GRC.Excel.Package, pMeta As Meta)
        Package = pPackage
        Me.FileNo = pPackage.GetCellText(pMeta.FileNoCellAddress.ToString())
        Me.SurveyDate = pPackage.GetCellText(pMeta.SurveyDateCellAddress.ToString())
        Me.TemplateVersion = IIf(pPackage.GetCellText(pMeta.TemplateVersionAddress.ToString()) = "", 0, pPackage.GetCellText(pMeta.TemplateVersionAddress.ToString()))
        Me.FileName = pPackage.GetFileName()
    End Sub

    Public Sub LoadData(pImportTableList As ImportTableInfoList, pImportSheet As ImportEnum.ImportSheet)

        If pImportSheet = ImportEnum.ImportSheet.RecTracking Then

            LoadRecData(pImportTableList, pImportSheet)

        Else

            DataDictionary.Clear()

            For Each pImportTable As ImportTableInfo In pImportTableList

                If Package.IsWorksheetAvailable(pImportTable.SheetName) Then

                    Dim ParsedAdddress As GRC.Excel.Package.AddressParseResult = Package.Parse(pImportTable.FullRangeAddress)

                    Dim zDT As DataTable = Package.GetData(ParsedAdddress, True)

                    'add a key column
                    zDT.Columns.Add(Me.PrimaryKeyColumnName)
                    zDT.Select().ToList.ForEach(Sub(x) x.Item(Me.PrimaryKeyColumnName) = Guid.NewGuid.ToString())
                    zDT.Constraints.Add("KeyColPK", zDT.Columns(Me.PrimaryKeyColumnName), True)

                    'RECOMMENDATIONS MODIFICATIONS PRE 6.0 VERSION
                    If pImportTable.ImportTableEnum.ToString().ToLower.Contains("recommendation") Then
                        zDT.Columns.Add(Me.RecLinkColumnName)

                        'REMOVE EMPTY ROWS WHERE YEAR AND MONTH ARE NOT POPULATED
                        For i = (zDT.Rows.Count - 1) To 0 Step -1
                            If Not IsNumeric(zDT.Rows(i)("Year")) And Not IsNumeric(zDT.Rows(i)("Month")) Then
                                zDT.Rows.RemoveAt(i)
                            End If
                        Next

                        zDT.Select.ToList.ForEach(Sub(x) x.Item(Me.RecLinkColumnName) = ImportUtility.CreateRecLink(x.Item("FileNo"), x.Item("Year"), x.Item("Month"), x.Item("No"), x.Item("Letter")))

                    End If

                    'NatHaz Modeling Modifications
                    If pImportTable.ImportTableEnum = ImportEnum.ImportTable.FireNatHazModeling Then
                        zDT.Rows(0).Delete()
                    End If


                    Me.DataDictionary.Add(pImportTable, zDT)
                Else
                    Dim importN As ImportNote = New ImportNote(ImportNote.ImportNoteType.WorksheetDoesntExist, New Dictionary(Of String, Object) From {{"Sheet", pImportTable.SheetName}})

                    Throw New ImportException(importN.Message)

                End If

            Next

        End If

    End Sub

    Public Sub LoadRecData(pImportTableList As ImportTableInfoList, pImportSheet As ImportEnum.ImportSheet)

        Dim zDS As New DataSet

        DataDictionary.Clear()

        For Each pImportTable As ImportTableInfo In pImportTableList

            zDS.Tables.Clear()

            For Each pRange As String In pImportTable.Range

                'THIS INNER LOOP ON RANGE IS FOR IMPORTS THAT HAVE MULTIPLE RANGES FOR THE SAME TABLE.  CURRENTLY ONLY RECS HAVE THIS.
                Dim ParsedAdddress As GRC.Excel.Package.AddressParseResult = Package.Parse(pImportTable.SheetName & "!" & pRange)
                Dim zD As DataTable = Package.GetData(ParsedAdddress, True)
                zD.Columns.Add("GUID", GetType(System.String))
                zDS.Tables.Add(zD)

            Next

            'CHECK TO MAKE SURE EACH DATATABLE HAS SAME ROW COUNT.  WE CAN NOT PROCEED IF ROW COUNTS ARE DIFFERENT, AS THE ROW INDEX WILL DETERMINE WHICH DATA BELONGS TOGETHER.
            Dim zRowCount As Integer = 0
            Dim zRowCountIsValid As Boolean = True
            For Each zT As DataTable In zDS.Tables
                If zRowCount = 0 Then
                    zRowCount = zT.Rows.Count
                Else
                    If zRowCount <> zT.Rows.Count Then
                        Throw New Exception(pImportSheet.ToString & " returns rows are not equal for each range. Ensure that each range returns the same amount of rows.")
                    End If
                End If
            Next


            'CREATE A UNIQUE KEY THAT WILL CROSS ALL DATATABLES
            For Each zDT As DataTable In zDS.Tables

                If zDS.Tables.IndexOf(zDT) = 0 Then
                    'CREATE UNIQUE GUID FOR EACH ROW
                    zDT.Select.ToList.ForEach(Sub(x) x("GUID") = Guid.NewGuid.ToString)
                Else
                    'COPY GUID FROM FIRST TABLE AND APPLY TO SUBSEQUENT TABLE
                    zDT.Select.ToList.ForEach(Sub(x) x("GUID") = zDS.Tables(0).Rows(zDT.Rows.IndexOf(x))("GUID"))
                End If

                If Not zDT.Constraints.Contains("PKGUID") Then
                    zDT.Constraints.Add("PKGUID", zDT.Columns("GUID"), True)
                End If

            Next

            'Recommendation Modifications
            'WE NEED TO REMOVE BLANK EXCEL ROWS THAT CONTAIN NO DATA
            If pImportSheet = ImportEnum.ImportSheet.RecTracking Then

                'ADD A RECLINK COLUMN
                zDS.Tables(0).Columns.Add(Me.RecLinkColumnName)

                Dim zGUIDsToRemove As New List(Of String)
                For Each zT As DataTable In zDS.Tables
                    If zT.Columns.Contains("Year") And zT.Columns.Contains("Month") Then

                        'GET ROWS WHERE YEAR AND MONTH ARE NOT POPULATED
                        zGUIDsToRemove = zT.Select().ToList.Where(Function(x) IsNumeric(x("Year")) = False And IsNumeric(x("Month")) = False).ToList.Select(Of String)(Function(x) x("GUID")).ToList()

                        'ASSIGN A RECLINK VALUE
                        zT.Select.ToList.Where(Function(x) Not zGUIDsToRemove.Contains(x("GUID"))).ToList.ForEach(Sub(x) x.Item(Me.RecLinkColumnName) = ImportUtility.CreateRecLink(x.Item("FileNo"), x.Item("Year"), x.Item("Month"), x.Item("No"), x.Item("Letter")))

                        Exit For
                    End If
                Next

                'ADD A 

                'REMOVE ROWS FROM ALL TABLES
                For Each zT As DataTable In zDS.Tables
                    For Each zGUID As String In zGUIDsToRemove
                        zT.Rows.Find(zGUID).Delete()
                    Next
                Next

            End If


            'NatHaz Modeling Modifications
            If pImportSheet = ImportEnum.ImportSheet.NatHazModelingData Then
                zDT.Rows(0).Delete()
            End If


            'COMBINE ALL COLUMNS INTO A NEW TABLE
            Dim zCDT As New DataTable(Guid.NewGuid.ToString())
            For Each zT As DataTable In zDS.Tables
                For Each zC As DataColumn In zT.Columns
                    If zC.ColumnName <> "GUID" OrElse Not zCDT.Columns.Contains("GUID") Then
                        zCDT.Columns.Add(zC.ColumnName, zC.DataType)
                    End If
                Next
            Next

            'SET GUID COLUMN AS PRIMARY KEY
            zCDT.Constraints.Add("KeyColPK", zCDT.Columns("GUID"), True)

            'COPY ROWS
            For Each zT As DataTable In zDS.Tables

                For Each zRow As DataRow In zT.Rows

                    Dim zIsNewRow As Boolean = False

                    'GET ROW GUID TO COPY
                    Dim zRowGUID As String = zRow("GUID")

                    'GET THE ROW IN THE COMBINED TABLE
                    Dim zCDTRow As DataRow = zCDT.Rows.Find(zRowGUID)

                    'IF DOES NOT EXIST, THEN CREATE THE ROW
                    If IsNothing(zCDTRow) Then
                        zCDTRow = zCDT.NewRow
                        zIsNewRow = True
                    End If

                    For Each zCol As DataColumn In zT.Columns

                        'SET THE VALUES
                        zCDTRow(zCol.ColumnName) = zRow(zCol.ColumnName)

                    Next

                    If zIsNewRow Then zCDT.Rows.Add(zCDTRow)

                Next


            Next

            Me.DataDictionary.Add(pImportTable, zCDT)

        Next



    End Sub




    Public Function IsExcelFormulaError(pImportTableInfo As ImportTableInfo, pColumn As DataColumn, pKeyGUID As String) As Boolean
        Dim zDT As DataTable = DataDictionary(pImportTableInfo)
        Dim zRow As DataRow = zDT.Rows.Find(pKeyGUID)
        If zRow.GetColumnsInError.Contains(pColumn) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public ReadOnly Property PrimaryKeyColumnName As String
        Get
            Return "KeyCol"
        End Get
    End Property

    Public ReadOnly Property RecLinkColumnName As String
        Get
            Return "RecLink"
        End Get
    End Property

    Private Function zDT() As Object
        Throw New NotImplementedException
    End Function

End Class
