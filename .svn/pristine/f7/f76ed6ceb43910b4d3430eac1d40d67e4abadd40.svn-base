Imports GRC.Connect.Libraries.DataLib.razor

Public Class GRCMSOfficeExcel

    Private MetaColumnOrder As New List(Of String)
    Private MetaSchema As New Dictionary(Of String, Object)
    Private MetaFields As New Dictionary(Of String, Object)
    Private MetaFieldAttr As Dictionary(Of String, Object)
    Private MetaColAttr As Dictionary(Of String, Object)
    Private MetaColList As New List(Of Object)
    Private MetaIndices As New Dictionary(Of String, Integer)
    Private MetaSources As New Dictionary(Of String, Object)
    Private MetaSourceAttr As Dictionary(Of String, Object)
    Private MetaDetailTemplate As String = Nothing

    Private Function ContainsColumn(pColumnName As String) As Boolean
        If MetaIndices.ContainsKey(pColumnName) Then
            Dim zIndex As Integer = MetaIndices.Item(pColumnName) - 1
            If Not FindMetaColumnInfo(pColumnName) Is Nothing Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Function FindMetaColumnInfo(pColumnName As String) As Dictionary(Of String, Object)
        For Each zItem As Dictionary(Of String, Object) In MetaColList
            If zItem("field") = pColumnName Then
                Return zItem
            End If
        Next
        Return Nothing
    End Function

    Private Function ReadMetaString(pColumnName As String, pMetaKeyName As String) As String
        Dim zItem As New Dictionary(Of String, Object)
        zItem = FindMetaColumnInfo(pColumnName)
        Return zItem(pMetaKeyName)
    End Function

    Private Function ReadMetaObject(pColumnName As String, pMetaKeyName As String) As Object
        Dim zItem As New Dictionary(Of String, Object)
        zItem = FindMetaColumnInfo(pColumnName)
        Return zItem(pMetaKeyName)
    End Function

    Private Function ReadMetaBoolean(pColumnName As String, pMetaKeyName As String) As Boolean
        Dim zItem As New Dictionary(Of String, Object)
        zItem = FindMetaColumnInfo(pColumnName)
        Return zItem(pMetaKeyName)
    End Function

    Private Sub SetMetaData(pMetaGridId As Integer, pSafeGUID As String, Optional pCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar, Optional pFilePrefix As String = "")
        'Load Meta data
        Dim zMData As New Dictionary(Of String, Object)
        Dim zMObj As New UtilMeta
        zMObj.PropGridId = pMetaGridId
        zMObj.PropSafeGUID = pSafeGUID
        zMObj.PropCurrency = pCurrency
        zMObj.PropFilePrefix = pFilePrefix
        zMData = zMObj.GetGridMeta()
        zMObj = Nothing

        MetaSchema = zMData.Item("schema")
        MetaIndices = zMData.Item("indices")
        MetaColList = zMData.Item("columns")
        MetaSources = zMData.Item("sources")
        MetaDetailTemplate = zMData.Item("detailTemplate")
        If pSafeGUID.Length > 0 Then
            MetaColumnOrder = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(UtilSafe.LoadLargeObjectData_ByDataGroup(UtilGSafe.GetId(pSafeGUID), UtilSafe.LargeObjectName.columnOrder, pMetaGridId))
        Else
            MetaColumnOrder = New List(Of String)
            For Each zItem In MetaIndices
                MetaColumnOrder.Add(zItem.Key)
            Next
        End If

        'IF THE METACOLUMNORDER IS NOTHING, THEN USE THE ORDER OF THE META COLUMNS.  DO NOT INCLUDE COLUMNS IF HIDDEN.
        If MetaColumnOrder Is Nothing Then
            MetaColumnOrder = New List(Of String)
            For Each zItem As Dictionary(Of String, Object) In MetaColList
                Dim zIsExcluded As Boolean = zItem("fldExcludeFromExtract")
                Dim zColumn As String = zItem("field")
                If Not zIsExcluded Then
                    MetaColumnOrder.Add(zColumn)
                End If
            Next
        End If

    End Sub

    Private Function RemoveBadCharacters(pSource As String) As String
        pSource = Replace(pSource, "*", "")
        pSource = Replace(pSource, "[", "")
        pSource = Replace(pSource, "]", "")
        pSource = Replace(pSource, "/", "")
        pSource = Replace(pSource, "\", "")
        pSource = Replace(pSource, ":", "")
        pSource = Replace(pSource, "?", "")
        Return pSource
    End Function

    Private Function GetSheetName(pMetaGridId As Integer) As String
        Dim zReturn As String = "Sheet1"

        Dim zMG As New rowTblMetaGrid
        zMG = TblMetaGrid.LoadByPrimaryKey(pMetaGridId)

        If Not zMG Is Nothing Then
            If Len(zMG.colFldGridPageTitle & "") > 0 Then
                zReturn = zMG.colFldGridPageTitle
            ElseIf Len(zMG.colFldGridName & "") > 0 Then
                zReturn = zMG.colFldGridName
            End If
        End If

        'Remove special characters from the sheet name
        zReturn = RemoveBadCharacters(zReturn)

        'Sheet names must be 30 characters or less
        Return Left(zReturn, 30)
    End Function

    Public Function ExportToExcel(pSQL As String, pMetaGridId As Integer, pSafeGUID As String, Optional pCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar, Optional pFilePrefix As String = "") As Byte()

        Dim zEX As New GRC.MSOffice.Excel
        Dim zSW As New Stopwatch
        Dim zSheetRow As Integer = 1
        Dim zSheetCol As Integer = 1
        Dim zDBColumnName As String = ""
        Dim zDBBackColorColumnName As String = ""
        Dim zDBWrapText As Boolean = False
        Dim zCellDataFormat As String = ""
        Dim zReaderCol As Integer = 0
        Dim zCaption As String = ""
        Dim pMyGrid As Object = Nothing
        Dim pDV As DataView = Nothing
        Dim zNdxCol As Integer = 0
        Dim zMaxDataWidth() As Integer
        Dim zMaxSheetCol As Integer = 0

        zSW.Start()

        Diagnostics.Debug.Print(pSQL)
        Call SetMetaData(pMetaGridId, pSafeGUID, pCurrency, pFilePrefix)

        Dim zReader As SqlClient.SqlDataReader
        Dim zCmd As New SqlClient.SqlCommand
        zCmd.CommandText = pSQL

        zReader = UtilSQLServer.ExecuteReader(zCmd)

        Dim zDictReaderCol As New Dictionary(Of String, Integer)

        'Load dictionary of reader column names and positions
        For zNdxCol = 0 To zReader.FieldCount - 1
            zDictReaderCol.Add(zReader.GetName(zNdxCol), zNdxCol)
        Next

        'Build sheet header
        zSheetCol = 1
        For Each zItem As String In MetaColumnOrder
            'Verify the column (from Meta) is present in the data
            If zDictReaderCol.ContainsKey(zItem) Then
                'Set the NdxCol to the column matching name from the Meta or passed up grid data
                zNdxCol = zDictReaderCol.Item(zItem)
                zDBColumnName = zReader.GetName(zNdxCol)

                'Process hidden column meta information
                If Not ReadMetaBoolean(zDBColumnName, "fldExcludeFromExtract") Then
                    zReaderCol = zNdxCol
                    zCaption = ReadMetaString(zDBColumnName, "title")
                    zEX.AddData(zSheetRow, zSheetCol, zCaption) 'Grid column names
                    Dim zHeaderStyle As Object = ReadMetaObject(zDBColumnName, "headerAttributes")

                    'Set the header row back color to GRC power-blue
                    zEX.SetSolidBackColor(zEX.StartRow, zSheetCol, System.Drawing.ColorTranslator.FromHtml("#C6D1DE"))

                    If Not zHeaderStyle Is Nothing Then
                        Dim zDictTemp As Dictionary(Of String, Object)
                        zDictTemp = zHeaderStyle
                        If zDictTemp.ContainsKey("class") Then
                            Select Case zDictTemp.Item("class")
                                Case "gridHeaderRed"
                                    Dim zColorHex As String = "#FF0000"
                                    zEX.SetSolidBackColor(zSheetRow, zSheetCol, System.Drawing.ColorTranslator.FromHtml(zColorHex))
                            End Select
                        End If
                    End If

                    zSheetCol = zSheetCol + 1
                End If
            End If
        Next
        ReDim zMaxDataWidth(zSheetCol - 1)

        zSheetRow = 2
        If Not zReader.HasRows Then
            'No Rows - return headers and no rows message
            zEX.AddData(zSheetRow, 1, "No data row(s) to extract")
        Else
            'Loop the data rows
            While zReader.Read
                zSheetCol = 1

                'Loop the columns using the order from the meta or passed up grid data
                For Each zItem As String In MetaColumnOrder

                    'Verify the column (from Meta) is present in the data
                    If zDictReaderCol.ContainsKey(zItem) Then
                        'Set the NdxCol to the column matching name from the Meta or passed up grid data
                        zNdxCol = zDictReaderCol.Item(zItem)
                        zDBColumnName = zReader.GetName(zNdxCol)
                        zDBBackColorColumnName = ReadMetaString(zDBColumnName, "fieldnamebackcolor")
                        zDBWrapText = ReadMetaBoolean(zDBColumnName, "fldExtractWrapText")
                        zCellDataFormat = ReadMetaString(zDBColumnName, "format")

                        'Process hidden column meta information
                        If Not ReadMetaBoolean(zDBColumnName, "fldExcludeFromExtract") Then
                            zReaderCol = zNdxCol
                            'Handle the data cases for type and format
                            If zReader.IsDBNull(zReaderCol) Then
                                zEX.AddData(zSheetRow, zSheetCol, "")
                            Else
                                zEX.AddData(zSheetRow, zSheetCol, zReader.Item(zReaderCol))

                                Select Case zCellDataFormat
                                    Case "{0:dd-MMM-yyyy}"
                                        zEX.SetCellFormat(zSheetRow, zSheetCol, "dd-MMM-yyyy")
                                    Case "{0:n0}"
                                        zEX.SetCellFormat(zSheetRow, zSheetCol, "#,##0")
                                    Case "{0:d4}"
                                        zEX.SetCellHorizontalAlignment(zSheetRow, zSheetCol, "Right")
                                    Case "{0:dd-MMM-yyyy hh:mm:ss}"
                                        zEX.SetCellFormat(zSheetRow, zSheetCol, "dd-MMM-yyyy hh:mm:ss")

                                End Select

                                If Not zDBBackColorColumnName Is Nothing Then
                                    If HasColumn(zReader, zDBBackColorColumnName) Then
                                        If Not zReader.Item(zDBBackColorColumnName) Is Nothing Then
                                            If zReader.Item(zDBBackColorColumnName).ToString.Length > 0 Then
                                                zEX.SetSolidBackColor(zSheetRow, zSheetCol, System.Drawing.ColorTranslator.FromHtml(zReader.Item(zDBBackColorColumnName)))
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            'Set the max width for column based on data content length
                            If zDBWrapText Then
                                zEX.SetWrapText(zSheetRow, zSheetCol, True)
                                zMaxDataWidth(zSheetCol - 1) = 20
                            Else
                                If zReader.Item(zReaderCol).ToString.Length > zMaxDataWidth(zSheetCol - 1) Then
                                    zMaxDataWidth(zSheetCol - 1) = zReader.Item(zReaderCol).ToString.Length
                                End If
                            End If

                            zSheetCol = zSheetCol + 1
                        Else
                            'Hidden
                        End If
                    Else
                        ' Reader does not contain a matching column name 
                    End If
                Next
                zSheetRow = zSheetRow + 1
            End While
            zMaxSheetCol = zSheetCol
        End If
        zReader = Nothing
        zCmd.Connection.Close()
        zCmd.Connection = Nothing

        'Set the column widths based on the max data information collected above.
        For zSheetCol = 1 To zMaxSheetCol
            Dim zDataWidth As Double = zMaxDataWidth(zSheetCol - 1) * 1.2
            If zDataWidth < 20 Then zDataWidth = 20
            zEX.SetColAutoWidth(zSheetCol, 15, zDataWidth)
        Next zSheetCol

        'Set the header row to double high
        Dim zModelDict As Dictionary(Of String, Object) = MetaSchema("model")
        zEX.SetRowHeight(1, zModelDict("extractheaderheight"))


        'Set the header row to bold
        zEX.SetBold(zEX.StartRow, 1, zEX.StartCol, zEX.EndCol, True)

        'Set the header row to wrap
        zEX.SetWrapText(zEX.StartRow, 1, zEX.StartCol, zEX.EndCol, True)

        'Set boarder line for data rows to thin black line
        zEX.SetBorderThin(zEX.StartRow, zEX.EndRow, zEX.StartCol, zEX.EndCol, Drawing.Color.Black)

        'Set the sheet name based on the passed in parameter
        zEX.SheetName(GetSheetName(pMetaGridId))
        'zEX.SheetName("Latitude & Longitude Facility")

        zSW.Stop()
        Debug.Print("Lapse Time (secs): " & zSW.ElapsedMilliseconds / 1000)

        'Return the bytes contianing the binary Excel file information
        Return zEX.SaveAsByteArray()
    End Function

    Private Function HasColumn(ByRef pReader As SqlClient.SqlDataReader, pColumnName As String) As Boolean
        Dim zNdx As Integer = 0
        For zNdx = 0 To pReader.FieldCount - 1
            If pReader.GetName(zNdx).ToLower = pColumnName.ToLower Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function
End Class
