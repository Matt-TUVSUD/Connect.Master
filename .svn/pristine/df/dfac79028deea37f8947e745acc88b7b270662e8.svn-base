

Public Class EditPreferences
    Inherits System.Web.UI.Page
    Implements IPostBackEventHandler

    Private Sub LoadDefaults()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString() ' *** GRC.Connect.Scott Update 7/30/2015
        Dim zUserEmail As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserEmail)
        Dim zUserPassword As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserPassword)
        Dim zClientName As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
        txtClientSelection.Text = zClientName

    End Sub

    Private Sub LoadLists()

    End Sub

    Private Sub LoadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Call LoadLists()
            Call LoadDefaults()
        End If

        Call LoadData()

        ' SET THE ICON TEXT LINKS
        hypExit.NavigateUrl = "~/Home_{{VER}}/Gauge/Default.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString() ' *** GRC.Connect.Scott Update 7/30/2015

        ' CREATE EVENTS FOR ICON CLICKS
        icoExit.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoExit_Click")

    End Sub


    ' RAISE AN EVENT FOR THE ICON CLICKS
    Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        If eventArgument = "icoExit_Click" Then
            Dim zSafeGUID As String = ""
            Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & UtilGSafe.GetGUIDFromQueryString(), False) ' *** GRC.Connect.Scott Update 7/30/2015
        End If

    End Sub


End Class