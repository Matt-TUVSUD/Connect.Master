Public Class ImportDataRow
    Inherits System.Data.DataRow

    Private _ExcelFormulaErrorColumn As New List(Of DataColumn)

    Sub New(builder As DataRowBuilder)
        MyBase.New(builder)
    End Sub

    Public Sub ColumnHasError(pDataColumn As DataColumn)
        _ExcelFormulaErrorColumn.Add(pDataColumn)
    End Sub

End Class
