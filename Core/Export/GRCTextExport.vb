Imports GRC.Connect.Libraries.DataLib.razor
Public Class GRCTextExport

    Private MetaSchema As New Dictionary(Of String, Object)
    Private MetaFields As New Dictionary(Of String, Object)
    Private MetaFieldAttr As Dictionary(Of String, Object)
    Private MetaColAttr As Dictionary(Of String, Object)
    Private MetaColList As New List(Of Object)
    Private MetaIndices As New Dictionary(Of String, Integer)
    Private MetaSources As New Dictionary(Of String, Object)
    Private MetaSourceAttr As Dictionary(Of String, Object)
    Private MetaDetailTemplate As String = Nothing

    Public TextFormat As UtilExport.ExportFormat = UtilExport.ExportFormat.CSV

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
        Dim zMObj As New GRC.Connect.Libraries.CoreLib.UtilMeta
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
    End Sub

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

        'Sheet names must be 30 characters or less
        Return Left(zReturn, 30)
    End Function

    Private Function WrapString(pIn As String) As String
        If TextFormat = UtilExport.ExportFormat.CSV Then

            Dim zSurroundValueInQuotes As Boolean = False

            If pIn.Contains(Chr(34)) Or pIn.Contains(",") Then
                zSurroundValueInQuotes = True
                pIn = Replace(pIn, Chr(34), Chr(34) & Chr(34))
            End If

            If zSurroundValueInQuotes Then
                pIn = Chr(34) & pIn & Chr(34)
            End If

        End If

        Return pIn

    End Function

    Public Function ExportToText(pSQL As String, pMetaGridId As Integer, pSafeGUID As String, Optional pCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar, Optional pFilePrefix As String = "") As Byte()

        Dim zSB As New StringBuilder

        Dim zSW As New Stopwatch
        Dim zDataCol As Integer = 1
        Dim zMaxDataCol As Integer = 0
        Dim zDBColumnName As String = ""
        Dim zCellDataFormat As String = ""
        Dim zReaderCol As Integer = 0
        Dim zCaption As String = ""
        Dim zNdxCol As Integer = 0
        Dim zDelimiter As String = ","

        If TextFormat = UtilExport.ExportFormat.TXT Then zDelimiter = Chr(9) 'Tab

        zSW.Start()

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
        zDataCol = 1
        Dim zDataRow() As String
        ReDim zDataRow(zDataCol)
        For Each zItem In MetaIndices
            'Verify the column (from Meta) is present in the data
            If zDictReaderCol.ContainsKey(zItem.Key) Then
                'Set the NdxCol to the column matching name from the Meta or passed up grid data
                zNdxCol = zDictReaderCol.Item(zItem.Key)
                zDBColumnName = zReader.GetName(zNdxCol)

                'Process hidden column meta information
                If Not ReadMetaBoolean(zDBColumnName, "fldExcludeFromExtract") Then
                    zReaderCol = zNdxCol
                    zCaption = ReadMetaString(zDBColumnName, "title")

                    ReDim Preserve zDataRow(zDataCol)
                    zDataRow(zDataCol - 1) = WrapString(zCaption).Trim()

                    zDataCol = zDataCol + 1
                End If
            End If
        Next
        zMaxDataCol = zDataCol
        zSB.AppendLine(Join(zDataRow, zDelimiter))

        If Not zReader.HasRows Then
            'No Rows - return headers and no rows message
            'zEX.AddData(zSheetRow, 1, "No data row(s) to extract")
        Else
            'Loop the data rows
            While zReader.Read
                zDataCol = 1
                ReDim zDataRow(zMaxDataCol)

                'Loop the columns using the order from the meta or passed up grid data
                For Each zItem In MetaIndices

                    'Verify the column (from Meta) is present in the data
                    If zDictReaderCol.ContainsKey(zItem.Key) Then
                        'Set the NdxCol to the column matching name from the Meta or passed up grid data
                        zNdxCol = zDictReaderCol.Item(zItem.Key)
                        zDBColumnName = zReader.GetName(zNdxCol)
                        zCellDataFormat = ReadMetaString(zDBColumnName, "format")

                        'Process hidden column meta information
                        If Not ReadMetaBoolean(zDBColumnName, "fldExcludeFromExtract") Then
                            zReaderCol = zNdxCol
                            'Handle the data cases for type and format
                            If zReader.IsDBNull(zReaderCol) Then
                                zDataRow(zDataCol - 1) = WrapString("").Trim()
                            Else
                                Select Case zCellDataFormat
                                    Case "{0:dd-MMM-yyyy}"
                                        zDataRow(zDataCol - 1) = WrapString(Format(zReader.Item(zReaderCol), "dd-MMM-yyy"))
                                    Case "{0:n0}"
                                        zDataRow(zDataCol - 1) = zReader.Item(zReaderCol)
                                    Case "{0:d4}"
                                        zDataRow(zDataCol - 1) = zReader.Item(zReaderCol)
                                    Case Else
                                        zDataRow(zDataCol - 1) = WrapString(zReader.Item(zReaderCol))
                                End Select
                            End If

                            zDataCol = zDataCol + 1
                        Else
                            'Hidden
                        End If
                    Else
                        ' Reader does not contain a matching column name 
                    End If
                Next
                zSB.AppendLine(Join(zDataRow, zDelimiter))
            End While
        End If
        zReader = Nothing
        zCmd.Connection.Close()
        zCmd.Connection = Nothing

        zSW.Stop()
        Debug.Print("Lapse Time (secs): " & zSW.ElapsedMilliseconds / 1000)

        'Return the bytes contianing the file information
        Dim zEncoding As System.Text.Encoding = System.Text.Encoding.UTF8
        Return zEncoding.GetBytes(zSB.ToString)
    End Function

End Class
