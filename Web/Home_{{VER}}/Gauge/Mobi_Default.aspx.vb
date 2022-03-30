Imports GRC.Connect.Libraries.CoreLib.UtilConstants


Public Class Mobi_DefaultGauge
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(UtilGSafe.GetGUIDFromQueryString(), PageId_Gauge, "")
    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()
        Dim zGUID = UtilGSafe.GetGUIDFromQueryString()
        Call BuildSafeFileNo(zGUID)

        'SET LINKS IN GAUGE STATS
        hypFire.NavigateUrl = "~/Home_{{VER}}/Fire/Default.aspx?sid=" & zGUID
        hypBoiler.NavigateUrl = "~/Home_{{VER}}/Boiler/Default.aspx?sid=" & zGUID
        hypInfrared.NavigateUrl = "~/Home_{{VER}}/Infrared/Default.aspx?sid=" & zGUID
        hypJuris.NavigateUrl = "~/Home_{{VER}}/Jurisdictional/Default.aspx?sid=" & zGUID
        'hypWind.NavigateUrl = "~/Home_{{VER}}/Wind/Default.aspx?sid=" & zGUID
        'hypFlood.NavigateUrl = "~/Home_{{VER}}/Flood/Default.aspx?sid=" & zGUID
        'hypSeismic.NavigateUrl = "~/Home_{{VER}}/Seismic/Default.aspx?sid=" & zGUID

        lblGaugeCompanyName.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)

    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub

    Private Sub BuildSafeFileNo(pSafeGUID As String)
        Dim zFilePrefix As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

        'Change this routine to use the viewCCUserSecureLocations view after generated
        Dim zColl As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureLocationsCollection
        Dim zQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureLocationsQuery("t1")

        zQry.Select(zQry.FileNo)
        zQry.Where(zQry.FilePrefix = zFilePrefix)
        zQry.Where(zQry.GSafeGUID = pSafeGUID)

        'Check GSafe for Division Access
        If GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.DivisionManager) = "True" Then
            zQry.Where(zQry.Division = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.Division))
        End If

        'Check GSafe for Custom Access
        If GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccess) = "True" Then
            zQry.Where(zQry.CustomAccess = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.CustomAccessText))
        End If

        'Check GSafe for Location restriction
        If GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText) <> "(All)" Then
            zQry.Where(zQry.FileNo = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LocationDefaultText))
        End If

        'Check GSafe for TIV restriction
        If GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText) <> "(All)" Then
            zQry.Where(zQry.FileNo = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.TIVDefaultText))
        End If

        'Check for Plant restriction
        If GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.PlantManager) = "True" Then
            zQry.Where(zQry.FileNo = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.Plant))
        End If

        zQry.es.Distinct = True

        Dim zInsObj As New GRC.Connect.Libraries.CoreLib.BusinessObjects.GSafeFileNo
        Dim zInsColl As New GRC.Connect.Libraries.CoreLib.BusinessObjects.GSafeFileNoCollection
        Dim zInsQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.GSafeFileNoQuery
        Dim zSafeId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetId(pSafeGUID)

        zInsQry.SelectAll()
        zInsQry.Where(zInsQry.GSafeId = zSafeId)
        If zInsColl.Load(zInsQry) Then
            zInsColl.MarkAllAsDeleted()
            zInsColl.Save()
        End If

        If zColl.Load(zQry) Then
            For Each zObj As GRC.Connect.Libraries.CoreLib.BusinessObjects.ViewCCUserSecureLocations In zColl
                zInsObj = zInsColl.AddNew()
                zInsObj.GSafeId = zSafeId
                zInsObj.FileNo = zObj.FileNo

                zInsObj.Save()
            Next
        End If
    End Sub

End Class