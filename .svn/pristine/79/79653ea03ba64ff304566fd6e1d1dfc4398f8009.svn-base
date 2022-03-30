Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Public Class UserAccountForm

    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(UtilGSafe.GetGUIDFromQueryString(), PageId_UserAccount, "")

    End Sub

    Private Sub loadData()

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