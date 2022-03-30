Imports System.Reflection
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class ExcelUtility

	Public Shared Function GetCustomPropertyValue(ByVal pExcelWorkbook As Object, ByVal pCustomProperty As String) As String

		Dim zReturnValue As String = ""

		Try
			Dim zExcelDocCustomPropType As Type = pExcelWorkbook.CustomDocumentProperties.GetType
			Dim zProp As Object = zExcelDocCustomPropType.InvokeMember("Item", BindingFlags.GetProperty, Nothing, pExcelWorkbook.CustomDocumentProperties, New Object() {pCustomProperty})
			Dim zPropType As Type = zProp.GetType
			Dim zValue As String = zPropType.InvokeMember("Value", BindingFlags.GetProperty, Nothing, zProp, New Object() {}).ToString

			zReturnValue = Trim(zValue)

		Catch ex As Exception

			zReturnValue = ""

		End Try

		Return zReturnValue


	End Function

    'Public Shared Function WorkSheetExists(ByVal pWorkBook As Excel.Workbook, pSheetName As String) As Boolean
    '    Try
    '        Dim pObj As Object = pWorkBook.Worksheets(pSheetName)
    '        Return True
    '    Catch ex As COMException
    '        Return False
    '    End Try
    'End Function

    'Public Shared Function WorksheetHidden(ByVal pWorkBook As Excel.Workbook, pSheetName As String) As Boolean
    '	If WorkSheetExists(pWorkBook, pSheetName) Then
    '		Dim zWksht As Excel.Worksheet = pWorkBook.Worksheets(pSheetName)
    '		If zWksht.Visible <> Excel.XlSheetVisibility.xlSheetVisible Then
    '			Return True
    '		Else
    '			Return False
    '		End If
    '	Else
    '		Return True
    '	End If
    'End Function



    'Public Shared Function GetCellValue(ByVal pWorkBook As Excel.Workbook, ByVal pAddress As CellAddress) As Object

    '    If WorkSheetExists(pWorkBook, pAddress.Sheet) Then

    '        Dim zWksht As Excel.Worksheet = pWorkBook.Worksheets(pAddress.Sheet)
    '        Return zWksht.Range(pAddress.Cell).Value

    '    Else
    '        Return Nothing
    '    End If

    'End Function


    '   ''' <summary>
    '   ''' Checks to see if the row is empty
    '   ''' </summary>
    ' ''' <param name="pRowRange">The range of cells to check in a single import row</param>
    '   ''' <returns></returns>
    '   ''' <remarks></remarks>
    '   Public Shared Function IsRowEmpty(ByVal pRowRange As Excel.Range, ByVal pWorkSheet As Excel.Worksheet, ByVal pImportTable As ImportEnum.ImportTable) As Boolean

    '       Dim zCell As Excel.Range = Nothing
    '       Dim zEmptyCellCounter As Integer = 0
    '       Dim zExceptionDetail As Dictionary(Of String, Object) = Nothing
    '       Dim zMissing As Double = Nothing


    '       Select Case pImportTable

    '           Case ImportEnum.ImportTable.FireNatHazModeling
    '               For i As Integer = 1 To 3
    '                   If IsNumeric(pRowRange.Cells(i).value) Then
    '                       If pRowRange.Cells(i).value Is Nothing Then zEmptyCellCounter += 1
    '                   Else
    '                       If pRowRange.Cells(i).value Is Nothing Or pRowRange.Cells(i).value = "" Then zEmptyCellCounter += 1
    '                   End If
    '               Next

    '               If zEmptyCellCounter = 3 Then
    '                   Return True
    '               Else
    '                   Return False
    '               End If

    '           Case Else

    '               Try
    '                   For Each zCell In pRowRange.Cells
    '                       If Not CellHasError(zCell, pWorkSheet.Application) Then
    '                           If zCell.Value IsNot Nothing Then
    '                               If IgnoreValueList.Contains(zCell.Value.ToString.ToLower) Then
    '                                   zEmptyCellCounter += 1
    '                               End If
    '                           Else
    '                               zEmptyCellCounter += 1
    '                           End If
    '                       Else
    '                           Throw New ApplicationException("Exception Occurred")
    '                       End If
    '                   Next

    '               Catch ex As Exception
    '                   Throw New Exception("Could not read cell value located at '" & Replace(zCell.Address, "$", "") & "' on sheet [" & zCell.Worksheet.Name & "] due to an error in cell.")
    '               End Try

    '               zMissing = zEmptyCellCounter / pRowRange.Cells.Count

    '               'If 75% of the cells are missing values then return true
    '               If zMissing > 0.75 Then
    '                   Return True
    '               Else
    '                   Return False
    '               End If

    '       End Select


    '   End Function

	Public Shared ReadOnly Property IgnoreValueList() As List(Of String)
		Get
			Dim zList As New List(Of String)
			zList.Add("")
			zList.Add(" ")
			zList.Add("n/a")
			Return zList
		End Get
	End Property

    Public Shared Function CellHasError() As Boolean
        'Dim zError As String = ""
        'If Not IsNothing(zCell.Value) Then
        '    If ExcelErrorDictionary.TryGetValue(zCell.Value, zError) Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End If
        Return False
    End Function

    Public Shared ReadOnly Property ExcelErrorDictionary As Dictionary(Of String, String)
        Get
            Dim zDict As New Dictionary(Of String, String)
            With zDict
                .Add(-2146826281, "#Div/0!")
                .Add(-2146826246, "#N/A")
                .Add(-2146826259, "#Name?")
                .Add(-2146826288, "#NULL!")
                .Add(-2146826252, "#Num!")
                .Add(-2146826265, "#Ref!")
                .Add(-2146826273, "#Value!")
            End With
            Return zDict
        End Get
    End Property




	Public Class WorkBookCustomProperties
		Public Property ImportType
		Public Property Version
		Public Property VersionNumber
	End Class

End Class
