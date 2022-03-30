Public Class _RecResponse_Auth
    Inherits System.Web.UI.Page

    Public ServerSide_LanguagePreference As String = ""

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim zObjLog As New GRC.Connect.Libraries.CoreLib.BusinessObjects.RRLog
        Dim zQryLog As New GRC.Connect.Libraries.CoreLib.BusinessObjects.RRLogQuery
        Dim zRRGuid As String = ""

        ' TURN OFF ALL ERROR MESSAGES
        divError_InactiveLink.Visible = False
        divError_InvalidLink.Visible = False
        divError_InvalidNameEmail.Visible = False

        ' DISPLAY TEXT
        lblMessageMaintenance.Text = ""
        lblMessageMaintenance.Text = GRC.Connect.Libraries.CoreLib.UtilSystemParms.LoginDisplayText

        ' GET THE RRLOG GUID
        If Not Request.QueryString("p1") = Nothing Then
            zRRGuid = Request.QueryString("p1")
        End If

        ' CHECK IF RRLOG GUID EXISTS
        If zRRGuid.Length < 1 Then
            'lblError.Text = zErrorInvalidLink
            divError_InvalidLink.Visible = True
            btnAuthenticate.Enabled = False

        Else
            ' PRESET ENGLISH LANGUAGE TO PREVENT ERRORS
            ServerSide_LanguagePreference = "english"
            Session("RecResponse_LanguagePreference") = "english"

            ' GET RR RECORD
            zQryLog.Select()
            zQryLog.Where(zQryLog.RRLogGuid = zRRGuid)
            If zObjLog.Load(zQryLog) Then
                ' CHECK IF LINK IS STILL ACTIVE
                If zObjLog.LinkActive = False Then
                    'lblError.Text = zErrorInactiveLink
                    divError_InactiveLink.Visible = False
                    btnAuthenticate.Enabled = False
                Else
                    txtFullName.Text = zObjLog.RecipientName
                    txtEmailAddress.Text = zObjLog.RecipientEmail
                End If
                If Not zObjLog.LanguagePreference Is Nothing Then
                    If zObjLog.LanguagePreference.Length > 0 Then
                        Session("RecResponse_LanguagePreference") = "english" '= zObjLog.LanguagePreference
                        ServerSide_LanguagePreference = "english" '= zObjLog.LanguagePreference
                    Else
                        Session("RecResponse_LanguagePreference") = "english" '= zObjLog.LanguagePreference
                        ServerSide_LanguagePreference = "english" '= zObjLog.LanguagePreference
                    End If
                End If
            Else
                divError_InvalidLink.Visible = True
                btnAuthenticate.Enabled = False
            End If

        End If

    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call RedirectHTTPS()
            Call GuidRedirector()
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub

    Protected Sub btnAuthenticate_Click(sender As Object, e As EventArgs) Handles btnAuthenticate.Click
        Dim zGuid As String = ""
        Dim zId As String = Request.QueryString("p1")
        Dim zFullName As String = txtFullName.Text
        Dim zEmailAddress As String = txtEmailAddress.Text
        Dim zOKToLogIn As Boolean = True

        ' TURN OFF ALL ERROR MESSAGES
        divError_InactiveLink.Visible = False
        divError_InvalidLink.Visible = False
        divError_InvalidNameEmail.Visible = False

        ' CHECK IF WE ARE IN MAINTENANCE MODE AND IF IN ALLOWED EMAIL LIST
        If GRC.Connect.Libraries.CoreLib.UtilSystemParms.InMaintenanceMode Then
            zOKToLogIn = False
            If GRC.Connect.Libraries.CoreLib.BusinessObjects.EzyUsers.AllowMaintenanceLogin(zEmailAddress) Then
                zOKToLogIn = True
            End If
        End If

        Try
            If zOKToLogIn Then
                Dim zEmailValidate = New System.Net.Mail.MailAddress(zEmailAddress)
                If zFullName.Length < 1 Or zEmailValidate.Address.Length < 1 Then
                    divError_InvalidNameEmail.Visible = True
                Else

                    Dim q As New BusinessObjects.RRLogQuery
                    q.SelectAll()
                    q.Where(q.RRLogGuid = zId)

                    Dim l As New BusinessObjects.RRLogCollection
                  
                    If l.Load(q) Then
                        Dim zEntry As razor.rowTblSystemAppEntry = UtilAppEntry.Save(zId, zFullName, zEmailAddress, UtilAppEntry.EntrySource.AutoRec, l.ToList.First.Id)
                        UtilCookieUser.SetCookieUser(Page, "", "", zEntry.colFldID)

                        Session("RecResponse_FullName") = zFullName
                        Session("RecResponse_EmailAddress") = zEmailAddress
                        Response.Redirect("~/RecResponse_{{VER}}/Auth/Redirect.aspx?p1=" & zId, True)
                    End If

                End If
            Else
                lblMessageMaintenance.Text = GRC.Connect.Libraries.CoreLib.UtilSystemParms.InMaintenanceModeLoginDeniedText
            End If
        Catch
            divError_InvalidNameEmail.Visible = True
        End Try

    End Sub
    Public Sub GuidRedirector()
        Dim zGuidFile As String = IO.Path.GetDirectoryName(Server.MapPath(Request.FilePath)) & "\GuidList.txt"
        Dim zURLGuid As String = Request.QueryString("p1")
        If IO.File.Exists(zGuidFile) Then
            Dim zGuids() As String = IO.File.ReadAllLines(zGuidFile)
            For Each zGuid As String In zGuids
                If zURLGuid = zGuid Then
                    Response.Redirect("~/Home_{{VER}}/Auth/", False)
                End If
            Next
        End If


    End Sub

    Public Sub RedirectHTTPS()
        If Request.Url.ToString.Contains("localhost") = False Then
            If Libraries.CoreLib.UtilSystemParms.InLiveMode = True Or Libraries.CoreLib.UtilSystemParms.InTestMode = True Then
                If Not Request.IsSecureConnection Then
                    Dim zSecureUrl As String = Replace(Request.Url.ToString, "http", "https")
                    Response.Redirect(zSecureUrl)
                End If
            End If
        End If
    End Sub

End Class