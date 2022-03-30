Imports System.Runtime.CompilerServices

Namespace CustomExtensions
    Public Module DataRowExtensions

        <Extension>
        Function ToJson(row As DataRow) As String

            Dim dict As New Dictionary(Of String, Object)
            For Each col As DataColumn In row.Table.Columns
                dict.Add(col.ColumnName, row(col))
            Next

            Return Newtonsoft.Json.JsonConvert.SerializeObject(dict, Newtonsoft.Json.Formatting.Indented)

        End Function

    End Module
End Namespace

