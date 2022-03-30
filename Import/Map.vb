
''' <summary>
''' This class is responsible for field to column mapping.
''' </summary>
''' <remarks></remarks>

Public Class Map

    Friend Property EntityColumnName As String
    Friend Property ExcelColumnName As String
    Friend Property ExcelColumnAddress As String

    Friend Sub New(ByVal pEntityColumnName As String, ByVal pExcelColumnName As String)
        Me.EntityColumnName = pEntityColumnName
        Me.ExcelColumnName = pExcelColumnName
    End Sub

    Friend Sub New()

    End Sub

End Class


