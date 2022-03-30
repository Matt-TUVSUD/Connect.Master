Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Public Class rectrackingfeaturesX_fire_recresponse
    Inherits System.Web.UI.Page

    'PUBLIC VARS
    Public ServerSide_FullName As String = ""
    Public ServerSide_ClientFeatures As String = ""
    Public ServerSide_FileNo As String = ""
    Public ServerSide_EmailAddress As String = ""
    Public ServerSide_ToFireReport As String = ""
    Public ServerSide_ToFireDiagram As String = ""
    Public ServerSide_cldbName As String = ""
    Public ServerSide_PracticeName As String = ""
    Public ServerSide_RRLogId As String = ""
    Public ServerSide_RRLogGuid As String = ""
    Public ServerSide_LanguagePreference As String = ""
    Public ServerSide_CurrencyName As String = ""

    Private Sub ValidatePage()

    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()

    End Sub

    Private Sub loadData()
        'GET USER AND CLIENT INFORMATION
        ServerSide_FullName = Session("RecResponse_FullName")
        ServerSide_ClientFeatures = Session("RecResponse_ClientFeatures")
        ServerSide_FileNo = Session("RecResponse_FileNo")
        ServerSide_EmailAddress = Session("RecResponse_EmailAddress")
        ServerSide_PracticeName = Session("RecResponse_PracticeName")
        ServerSide_RRLogId = Session("RecResponse_RRLogId")
        ServerSide_RRLogGuid = Session("RecResponse_RRLogGuid")
        ServerSide_LanguagePreference = Session("RecResponse_LanguagePreference")

        ' PRESET ENGLISH LANGUAGE TO PREVENT ERRORS
        ServerSide_LanguagePreference = "english"
        Session("RecResponse_LanguagePreference") = "english"

        'REFRESH THE LANGUAGE PREFERENCE
        Dim zObjLog As New RRLog
        Dim zQryLog As New RRLogQuery
        zQryLog.Select(zQryLog.Id, zQryLog.LanguagePreference)
        zQryLog.Where(zQryLog.Id = ServerSide_RRLogId)
        If zObjLog.Load(zQryLog) Then
            If Not zObjLog.LanguagePreference Is Nothing Then
                If zObjLog.LanguagePreference.Length > 0 Then
                    ServerSide_LanguagePreference = zObjLog.LanguagePreference
                    Session("RecResponse_LanguagePreference") = zObjLog.LanguagePreference
                Else
                    Session("RecResponse_LanguagePreference") = "english" '= zObjLog.LanguagePreference
                    ServerSide_LanguagePreference = "english" '= zObjLog.LanguagePreference
                End If
            End If
        End If

        'GET FIRE REPORTS AND DIAGRAM
        Dim zFileNo As String = ServerSide_FileNo
        Dim zObjListing As New ViewCCLocationListingFire
        Dim zQryListing As New ViewCCLocationListingFireQuery
        zQryListing.Select()
        zQryListing.es.Top = 1
        zQryListing.Where(zQryListing.FileNo = zFileNo)
        If zObjListing.Load(zQryListing) Then
            ServerSide_ToFireReport = Replace(zObjListing.ToFireReport, "\", "\\")
            ServerSide_ToFireDiagram = Replace(zObjListing.ToFireDiagram, "\", "\\")
        End If

        'GET THE CLDB NAME FOR FILES AND REPORTS
        Dim zFilePrefix = Session("RecResponse_FilePrefix")
        Dim zObjClients As New ViewCCAllClients
        Dim zQryClients As New ViewCCAllClientsQuery
        zQryClients.Select()
        zQryClients.es.Top = 1
        zQryClients.Where(zQryClients.Fileprefix = Val(zFilePrefix & ""))
        If zObjClients.Load(zQryClients) Then
            ServerSide_cldbName = zObjClients.Cldbname
        End If

    End Sub

    Private Sub loadCurrencyLabels()
        Dim zUSD As String = "USD"
        Dim zEuro As String = "EUR"
        Dim zObj As New Clients
        Dim zQry As New ClientsQuery

        ' SETUP DEFAULT CURRENCY TEXT
        ServerSide_CurrencyName = zUSD

        ' FIND WHICH CURRENCY TEXT
        zQry.Select(zQry.ExchangeRateGroupID)
        zQry.Where(zQry.Cldbname = ServerSide_cldbName)
        If zObj.Load(zQry) Then
            If zObj.ExchangeRateGroupID = 4 Then
                ServerSide_CurrencyName = zEuro
            End If
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
        Call loadCurrencyLabels()

    End Sub

End Class