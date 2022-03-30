Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilPractice
Imports GRC.Connect.Libraries.CoreLib.UtilValidate

Public Class LibrariesDocumentLibrary_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = GetGUIDFromQueryString()
        'Dim zIsRecentUpdate As Boolean = CBool(IIf(IsNothing(Request.QueryString("isrecent")), False, Request.QueryString("isrecent")))

        ' GET THE GRID INFOMRATION
        Dim zGridId As String = "0"
        'Dim zFilePrefix As String = GetValue(zGUID, KeyName.FilePreFix)
        If Not Request.QueryString("gridId") Is Nothing Then
            zGridId = Request.QueryString("gridId")
        End If

        Dim zURL As String = "~/Home_{{VER}}/Grids/LibrariesDocumentLibrary/LibrariesDocumentLibrary.aspx"
        UtilFunction.AppendQueryString(zURL)

        ' zURL = zURL & "&gridId=" & zGridId

        '' SET THE NAVLINK INFOMRATION
        'Dim zNavlinkId As String = "0"
        'If Not Request.QueryString("navLinkId") Is Nothing Then
        '    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.NavLinkId, Request.QueryString("navLinkId"), UtilGSafe.KeyNameGroup.Navigation)
        'End If

        'Dim zUpdates As UtilUpdates.UpdateResult = UtilUpdates.GetCounts(zGUID)
        'If zIsRecentUpdate Then
        '    Dim zLastRecentDate As Date = zUpdates.DocLibLastReviewedDate
        '    Dim zDocDateParm As String = "&documentdate=" & CDate(zLastRecentDate.Month & "-" & zLastRecentDate.Day & "-" & zLastRecentDate.Year)
        '    zURL = zURL & zDocDateParm
        '    UtilUpdates.SetDocLibLastReviewedDate(zGUID)
        'End If

        '' STORE THE CORRECT INFORMATION TO THE GSAFE
        'SetValue(zGUID, KeyName.currentGridId, zGridId, KeyNameGroup.Navigation)

        'Dim zUserid As Integer = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.EzyLoginId)
        'UtilDB.LogGridActivity(zUserid, zGridId)

        'REDIRECT
        Response.Redirect(zURL, False)

    End Sub

End Class