Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class _default9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zReclassGUID As String = Request.QueryString("p1")
        Dim zSafeGUID As String = GetGUIDFromQueryString()
    
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentPage, PageId_UserReclassification, UtilGSafe.KeyNameGroup.Navigation)

        If UtilUserReclassification.IsLinkValid(zReclassGUID) Then
            If UtilUserReclassification.IsAuthorizedUser(zReclassGUID, UtilGSafe.GetLoginId(zSafeGUID)) Then
                Dim zClient As New List(Of GRC.Connect.Libraries.DataLib.razor.rowTblClients)
                Dim zQry As New GRC.Connect.Libraries.DataLib.razor.queryTblClients
                zQry.SelectAll()
                zQry.Where.Add(zQry.colReclassificationLinkGUID.Equals(zReclassGUID))
                zQry.Where.Add(zQry.colReclassificationLinkGUID.NotEqual(""))
                zClient = GRC.Connect.Libraries.DataLib.razor.TblClients.LoadData(zQry.QueryText)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix, zClient(0).colFileprefix, UtilGSafe.KeyNameGroup.Switch)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ClientName, zClient(0).colClientname, UtilGSafe.KeyNameGroup.PageHeader)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.cldbName, zClient(0).colCldbname, UtilGSafe.KeyNameGroup.PageHeader)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentGridId, UtilMeta.GetMetaKey("GRCConnectUsersReclass", 193), UtilGSafe.KeyNameGroup.Navigation)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.NavReturnURL, Request.Url.LocalPath, UtilGSafe.KeyNameGroup.Session)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.UserEmail, UtilGSafe.GetEmailAddress(zSafeGUID), UtilGSafe.KeyNameGroup.Authentication)
                UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.Reclass_ClientReclassificationLinkGUID, zReclassGUID, UtilGSafe.KeyNameGroup.Reclassification)
                Response.Redirect("UserReclassification.aspx?sid=" & zSafeGUID & "&p1=" & zReclassGUID)
            Else
                Response.Redirect("Notification.aspx?sid=" & zSafeGUID & "&p2=3")
            End If
        Else
            Response.Redirect("Notification.aspx?sid=" & zSafeGUID & "&p2=1")
        End If

    End Sub

End Class