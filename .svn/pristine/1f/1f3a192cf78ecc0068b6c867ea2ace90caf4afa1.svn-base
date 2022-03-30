Public Class CheckJSONFilters
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zFilter As String = "{""AutoRequest"":""%"",""Country"":""%"",""Currency"":1,""CustomAccess"":""%"",""Division"":""%"",""FileNo"":""%"",""FilePrefix"":""1001"",""Hazard"":""%"",""ImpairmentEndDate"":""12/31/9999 11:59:59 PM"",""ImpairmentStartDate"":""12:00:00 AM"",""InspectionProgramYear"":""%"",""Language"":1,""RecStatus"":""%"",""TIV"":""%"",""TIVValue"":2,""Unit"":1,""RequiredFlag"":0}"
        Dim zFilterObject = New JSONFilter
        If zFilter.Length > 0 Then
            zFilterObject = Newtonsoft.Json.JsonConvert.DeserializeObject(Of JSONFilter)(zFilter)
        End If
        zFilterObject.Filters.Add(New JSONFilterItem("RecStatus", JSONFilterOperator.Operators.NotEqual, "Conf Completed"))
        zFilterObject.Filters.Add(New JSONFilterItem("RecStatus", JSONFilterOperator.Operators.NotEqual, "Removed"))
        zFilter = zFilterObject.ToJSON

    End Sub

End Class