Imports System.Runtime.CompilerServices

Namespace CustomExtensions
    Public Module RatingKeyItemCollectionExtensions

        '<Extension()>
        'Function ToDataTable(ByVal pData As BusinessObjects.RatingKey.RatingKeyItemCollection) As DataTable
        '    Dim zDT As New DataTable
        '    zDT.Columns.Add("Rating", GetType(String))
        '    zDT.Columns.Add("RatingDescription", GetType(String))
        '    zDT.Columns.Add("RatingColorHex", GetType(String))
        '    zDT.Columns.Add("HighValue", GetType(Single))
        '    zDT.Columns.Add("LowValue", GetType(Single))

        '    For Each zItm As BusinessObjects.RatingKey.RatingKeyItem In pData
        '        Dim zRow As DataRow = zDT.NewRow
        '        zRow("Rating") = zItm.Rating
        '        zRow("RatingDescription") = zItm.RatingDescription
        '        zRow("RatingColorHex") = zItm.RatingColorHex
        '        zRow("HighValue") = zItm.HighValue
        '        zRow("LowValue") = zItm.LowValue
        '        zDT.Rows.Add(zRow)
        '    Next

        '    Return zDT

        'End Function

    End Module
End Namespace


