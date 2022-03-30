Public Class WhatIfAnalysisTool
    Inherits System.Web.UI.Page

    Public ServerSide_CurrencyIdFromPrefilter As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeId As String = UtilGSafe.GetId(zSafeGUID) & ""
        If zSafeId = "" Then
            Response.Write("<h1> Invalid SID </h1>")
        End If
        lblLoginUser.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.userFullName)
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        Dim zUserid As Integer = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "WhatIfAnalysisTool")
    End Sub

End Class