Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class UserReclassification

    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(UtilGSafe.GetGUIDFromQueryString(), PageId_UserReclassification, "")

    End Sub

    Private Sub loadData()
        Dim zReclassGUID As String = Request.QueryString("p1")
        Dim zSafeGUID As String = GetGUIDFromQueryString()
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentPage, PageId_UserReclassification, UtilGSafe.KeyNameGroup.Navigation)
        If Not zReclassGUID Is Nothing Then
            If UtilUserReclassification.IsLinkValid(zReclassGUID) Then
                ' DO NOTHING - ALLOW PAGE TO LOAD
            Else
                Response.Redirect("Notification.aspx?sid=" & zSafeGUID & "&p2=1", False)
            End If
        Else
            Response.Redirect("Notification.aspx?sid=" & zSafeGUID & "&p2=1", False)
        End If

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()

    End Sub

End Class