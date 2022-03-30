Imports GRC.Connect.Libraries.CoreLib.UtilKendo

Public Class UtilTest

    Public Shared Function TestGetGridData(pPage As Integer, pPageSize As Integer)
        Dim zReturn As New DataPackGrid
        Dim zDataTable As New DataTable
        zDataTable.Columns.Add("Link_to_Location")
        zDataTable.Columns.Add("FileNo")
        zDataTable.Columns.Add("Client")
        zDataTable.Columns.Add("ClientLocNo")
        zDataTable.Columns.Add("Division")
        zDataTable.Columns.Add("CustomAccess")
        zDataTable.Columns.Add("Facility")
        zDataTable.Columns.Add("Address1")
        zDataTable.Columns.Add("City")
        zDataTable.Columns.Add("StProv")
        zDataTable.Columns.Add("Country")
        zDataTable.Columns.Add("Latitude")
        zDataTable.Columns.Add("Longitude")

        Dim zCount As Integer = (pPage * pPageSize) - pPageSize
        Dim zStop As Integer = zCount + pPageSize
        While zCount < zStop
            Dim zDataRow As DataRow = zDataTable.NewRow
            zDataRow("Link_to_Location") = "No. " & zCount.ToString()
            zDataRow("FileNo") = "File No."
            zDataRow("Client") = "Client"
            zDataRow("ClientLocNo") = "Loc. No."
            zDataRow("Division") = "Division"
            zDataRow("CustomAccess") = "Custom Access"
            zDataRow("Facility") = "Facility"
            zDataRow("Address1") = "Address"
            zDataRow("City") = "City"
            zDataRow("StProv") = "State"
            zDataRow("Country") = "Country"
            zDataRow("Latitude") = 1.0
            zDataRow("Longitude") = 1.0
            zDataTable.Rows.Add(zDataRow)
            zCount = zCount + 1
        End While
        zReturn.data = zDataTable
        zReturn.total = 500
        Return zReturn
    End Function

End Class


Public Class DataTestGrid
    Public Link_to_Location As String
    Public FileNo As String
    Public Client As String
    Public ClientLocNo As String
    Public Division As String
    Public CustomAccess As String
    Public Facility As String
    Public Address1 As String
    Public City As String
    Public StProv As String
    Public Country As String
    Public Latitude As Double
    Public Longitude As Double
End Class