Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Public Class ClientConnectRecResponse
    Inherits System.Web.UI.MasterPage

    Public ServerSideMaster_FileNo
    Public ServerSideMaster_RRLogGuid
    Public ServerSideMaster_PracticeName
    Public ServerSideMaster_MgmtFields

    Private Sub LoadDefaults()
        'GET THE INSTRUCTIONS IN SPECIFIC LANGUAGES
        ServerSideMaster_FileNo = Session("RecResponse_FileNo")
        ServerSideMaster_RRLogGuid = Session("RecResponse_RRLogGuid")
        ServerSideMaster_PracticeName = Session("RecResponse_PracticeName").ToString().ToLower()

        ServerSideMaster_MgmtFields = "false"
        Dim zObj As New Clients
        Dim zQry As New ClientsQuery
        zQry.Select()
        zQry.es.Top = 1
        zQry.Where(zQry.Fileprefix = Val(Session("RecResponse_FilePrefix") & ""))
        If zObj.Load(zQry) Then
            If Not IsNothing(zObj.Features) Then
                If zObj.Features.ToUpper().Contains("Q") Then
                    If zObj.MgmtARR = True Then
                        ServerSideMaster_MgmtFields = "true"
                    End If
                End If
            End If
        End If

        'lblInst_Language_Title.Text = "Language"
        'lblInst_Language_Text.Text = "This page can be converted with a choice of six languages. Use the drop-down menu above  on the upper toolbar."
        'lblInst_Edit_Title.Text = "Edit"
        'lblInst_Edit_Text.Text = "Click the Edit button to enter your response."
        'lblInst_Responses_Title.Text = "Responses"
        'lblInst_Responses_Text.Text = "Once you have entered each of your responses, please end your session using the Logout button on the right of the upper top right toolbar."
        'lblInst_Email_Title.Text = "Email"
        'lblInst_Email_Text.Text = "After your session ends, an auto-generated email will be sent to your email containing the Rec Response Report with your changes."
    End Sub

    Private Sub LoadData()
        'THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        Dim zObj As New Clients
        Dim zQry As New ClientsQuery
        zQry.Select()
        zQry.es.Top = 1
        zQry.Where(zQry.Fileprefix = Val(Session("RecResponse_FilePrefix") & ""))
        If zObj.Load(zQry) Then
            lblCompany.Text = zObj.Clientname
        End If

        lblLoginName.Text = Session("RecResponse_FullName")
        lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        lblPageTitle.Text = Session("RecResponse_PageName")

    End Sub

    Private Sub Page_Init(sender As Object, e As System.EventArgs) Handles Me.Init

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Header.DataBind()
        If Not Page.IsPostBack Then
            Call LoadDefaults()
        End If
        Call LoadData()
    End Sub

End Class