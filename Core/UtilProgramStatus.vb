Imports GRC.Connect.Libraries.CoreLib.CustomExtensions


Public Class UtilProgramStatus


    ''This Function creates two datatables for dynamically loading the Facility Rating Risk tables at the bottom of the report.  It also calculates
    ''the percentage for the pie on the report
    'Public Shared Function GetRatingTables(ByVal pData As DataTable, ByVal pFilePrefix As String) As RatingTables

    '    Dim zDR As DataRow = pData.Rows(0) '--The row that has the counts
    '    Dim zLinkDR As DataRow = pData.Rows(1)   '--The row that has the links

    '    Dim zClient As New Libraries.CoreLib.BusinessObjects.Clients
    '    zClient.LoadByFilePrefix(pFilePrefix)

    '    Dim zFireRatingItems As DataTable = zClient.GetFireRatingItems.ToDataTable
    '    Dim zBMRatingItems As DataTable = zClient.GetBMRatingItems.ToDataTable


    '    Dim zDTFireRating As New DataTable
    '    Dim zDTBMRating As New DataTable
    '    zDTFireRating.TableName = "FireRating"

    '    zDTFireRating.Columns.Add("Label")
    '    zDTFireRating.Columns.Add("ColorHex")
    '    zDTFireRating.Columns.Add("Value")
    '    zDTFireRating.Columns.Add("Percent")
    '    zDTFireRating.Columns.Add("URL")

    '    Dim zTotalLocations As Integer = Int(zDR("Rating1Fire")) +
    '        Int(zDR("Rating2Fire")) + _
    '        Int(zDR("Rating3Fire")) + _
    '        Int(zDR("Rating4Fire")) + _
    '        Int(zDR("Rating5Fire"))


    '    For Each zRow As DataRow In zFireRatingItems.Rows
    '        Dim zRw As DataRow = zDTFireRating.NewRow

    '        zRw("Label") = "No. of Locations Rated " & zRow("Rating")
    '        zRw("ColorHex") = zRow("RatingColorHex")

    '        Select Case zFireRatingItems.Rows.IndexOf(zRow)
    '            Case 0
    '                zRw("Value") = zDR("Rating1Fire")
    '                zRw("URL") = zLinkDR("Rating1Fire")

    '            Case 1
    '                zRw("Value") = zDR("Rating2Fire")
    '                zRw("URL") = zLinkDR("Rating2Fire")

    '            Case 2
    '                zRw("Value") = zDR("Rating3Fire")
    '                zRw("URL") = zLinkDR("Rating3Fire")

    '            Case 3
    '                zRw("Value") = zDR("Rating4Fire")
    '                zRw("URL") = zLinkDR("Rating4Fire")

    '            Case 4
    '                zRw("Value") = zDR("Rating5Fire")
    '                zRw("URL") = zLinkDR("Rating5Fire")

    '        End Select

    '        zRw("Percent") = CalculatePercent(zTotalLocations, zRw("Value"))
    '        zDTFireRating.Rows.Add(zRw)

    '    Next

    '    'BM Rating Table
    '    zDTBMRating.TableName = "BMRating"
    '    zDTBMRating.Columns.Add("Label")
    '    zDTBMRating.Columns.Add("ColorHex")
    '    zDTBMRating.Columns.Add("Value")
    '    zDTBMRating.Columns.Add("Percent")
    '    zDTBMRating.Columns.Add("URL")

    '    zTotalLocations = Int(zDR("Rating1BM")) +
    '        Int(zDR("Rating2BM")) + _
    '        Int(zDR("Rating3BM")) + _
    '        Int(zDR("Rating4BM")) + _
    '        Int(zDR("Rating5BM"))


    '    For Each zRow As DataRow In zBMRatingItems.Rows
    '        Dim zRw As DataRow = zDTBMRating.NewRow
    '        zRw("Label") = "No. of Locations Rated " & zRow("Rating")
    '        zRw("ColorHex") = zRow("RatingColorHex")

    '        Select Case zBMRatingItems.Rows.IndexOf(zRow)
    '            Case 0
    '                zRw("Value") = zDR("Rating1BM")
    '                zRw("URL") = zLinkDR("Rating1BM")

    '            Case 1
    '                zRw("Value") = zDR("Rating2BM")
    '                zRw("URL") = zLinkDR("Rating2BM")

    '            Case 2
    '                zRw("Value") = zDR("Rating3BM")
    '                zRw("URL") = zLinkDR("Rating3BM")

    '            Case 3
    '                zRw("Value") = zDR("Rating4BM")
    '                zRw("URL") = zLinkDR("Rating4BM")

    '            Case 4
    '                zRw("Value") = zDR("Rating5BM")
    '                zRw("URL") = zLinkDR("Rating5BM")

    '        End Select

    '        zRw("Percent") = CalculatePercent(zTotalLocations, zRw("Value"))
    '        zDTBMRating.Rows.Add(zRw)

    '    Next

    '    Dim zTbls As New RatingTables
    '    zTbls.Fire = zDTFireRating
    '    zTbls.BM = zDTBMRating

    '    Return zTbls

    'End Function

    'Private Shared Function CalculatePercent(ByVal pTotal As Integer, ByVal pAmount As Integer) As Single
    '    If pTotal <> 0 Then
    '        Return pAmount / pTotal
    '    Else
    '        Return 0
    '    End If
    'End Function

End Class

''' <summary>
''' This class has two datatable properties which provide the data for populating the rating risk table in the facility rating section of the report.
''' </summary>
''' <remarks></remarks>
Public Class RatingTables
    Public Property Fire As DataTable
    Public Property BM As DataTable

    ''' <summary>
    ''' These are the fields inside each Fire and BM datatable
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum RatingTableField
        Label
        ColorHex
        Value
        Percent
        URL
    End Enum
End Class
