Imports System
Imports System.Data
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor


Partial Class Grids_GridMasterPage
    Inherits System.Web.UI.MasterPage

#Region "Local Variables"
    Private changeCurrency As Boolean = False
    Private changeUnit As Boolean = False
    Private changeRowsRange As Boolean = False
    Public changeCustom As Boolean = False
    Public customConversionValue As String
    Public ServerSide_CurrencyIdFromPrefilter As String = ""
    Public ServerSide_SearchURL As String = ""
    Public ServerSide_BingMapKey As String = ""
    Public ServerSide_GridId As String = ""
#End Region


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'SAID Checker
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.SafeGUID), zSafeGUID, Me.Page) Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If

        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ExecutedProcedures, Nothing, UtilGSafe.KeyNameGroup.Session) 'For clearing the stored procedure results from previous load.

        With Page.ClientScript
            .RegisterClientScriptInclude("util", "../../../Lib_{{VER}}/pages/util_{{VER}}.js") ' USED FOR BUILDNAVFILELINK
        End With
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Call LoadDefaults()
        Call LoadData()

    End Sub


    Private Sub LoadDefaults()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zGridId = CInt(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentGridId) & ".0")
        ServerSide_GridId = zGridId
        ' LOAD INSPECTION PROGRAM YEAR INFORMATION
        If zGridId = UtilMeta.GetMetaKey("BMFacilityRatingExtract", 136) Or _
            zGridId = UtilMeta.GetMetaKey("FireFacilityRatingExtract", 138) Then
            spnInspectionProgramYear.Visible = True
            cboInspectionProgramYear.Items.Clear()
            Dim zColl As List(Of rowTblMetaInspectionProgramYear)
            zColl = TblMetaInspectionProgramYear.LoadData
            For Each zRow As rowTblMetaInspectionProgramYear In zColl
                cboInspectionProgramYear.Items.Add(New System.Web.UI.WebControls.ListItem(zRow.colFldFilterText, zRow.colFldId))
            Next
        Else
            spnInspectionProgramYear.Visible = False
        End If

        ' LOOK FOR FILTERS APPLIED
        If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
            'lblPreferencesApplied.Visible = True
        Else
            'lblPreferencesApplied.Visible = False
        End If

        ' SET ANY CURRENCY OVERRIDES IF EXIST
        Dim zUserCurrencyIdParm As String = ""
        If Not Context.Request.QueryString("userCurrencyId") Is Nothing Then
            ServerSide_CurrencyIdFromPrefilter = Context.Request.QueryString("userCurrencyId")
        End If

    End Sub


    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        ' LOAD THE BING MAP KEY - NOTE: REPLACE THIS WITH A DATABASE LOAD FROM APP SETTINGS
        ServerSide_BingMapKey = "dcLcFIaVh7HHr3kYxMqq~z3IOleVdt0Pv_JDxdK0X7Q~AgX3x6H0kBmnonP50fMwBHcpzgeQnf3y27XpwSahxCwjJQii-TcLAqgDAv10pa0s"

        ' THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        'lblCompany.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
        'lblLoginName.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
        'lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)

        ' GET THE TITLE AND SUBTITLE
        Dim zGridId = CInt(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentGridId) & ".0")
        Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
        Dim zFullTitle As String = "TUV SUD GRC Connect |"
        ' GET TITLE
        'litTitle.Visible = False

        litSubTitle.Text = ""
        If Not zMetaGrid.colFldGridPageTitle Is Nothing Then
            If zMetaGrid.colFldGridPageTitle.Length > 0 Then
                '        litTitle.Text = zMetaGrid.colFldGridPageTitle
                '       litTitle.Visible = True
                litSubTitle.Text = zMetaGrid.colFldGridPageTitle
                litSubTitle.Visible = True
                zFullTitle = zFullTitle & " " & zMetaGrid.colFldGridPageTitle
            End If
        End If
        ' GET SUBTITLE
        'litSubTitle.Visible = False
        If Not zMetaGrid.colFldGridPageSubTitle Is Nothing Then
            If zMetaGrid.colFldGridPageSubTitle.Length > 0 Then
                litSubTitle.Text = litSubTitle.Text + " " + zMetaGrid.colFldGridPageSubTitle
                litSubTitle.Visible = True
                zFullTitle = zFullTitle & " " & zMetaGrid.colFldGridPageSubTitle
            End If
        End If
        Page.Title = zFullTitle
        ' GET INSTRUCTIONS
        divTopInstructions.Visible = False
        If Not zMetaGrid.colFldInstructions Is Nothing Then
            divTopInstructions.Visible = True
            lblTopMessage.Text = zMetaGrid.colFldInstructions
        End If
        ' HIDE OR SHOW ICONS
        divExtractDownloadChart.Visible = False
        If Not zMetaGrid.colFldReport2Id Is Nothing Then
            If zMetaGrid.colFldReport2Id > 0 Then
                divExtractDownloadChart.Visible = True
            End If
        End If
        If Not zMetaGrid.colFldGridPageTitle Is Nothing Then
            ' NEVER SHOW CHART ICON IF RECENT UPDATE OR DOC LIBRARY
            If zMetaGrid.colFldGridPageTitle.ToLower().Contains("recent update") Or zMetaGrid.colFldGridPageTitle.ToLower().Contains("document library") Then
                divExtractDownloadChart.Visible = False
            End If
        End If
        divExtractDownloadReport.Visible = False
        If Not zMetaGrid.colFldReportId Is Nothing Then
            If zMetaGrid.colFldReportId > 0 Then
                divExtractDownloadReport.Visible = True
            End If
        End If
        divContainerSearch.Visible = False
        If zGridId = UtilMeta.GetMetaKey("LibrariesDocumentLibrary", 60) Then
            Dim zMode As String = "&mo=l"
            If GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Then
                zMode = "&mo=t"
            End If
            '"/Home_{{VER}}/Redirect/SearchRedirect.aspx?sid=d49aaf739d0c4cd684832e2e7a4e5149&navLinkId=781&mo=t"
            ServerSide_SearchURL = UtilNav.GetNavUrl(UtilConstants.PageId_Search) & "?sid=" & zGUID & "&navLinkId=" & UtilConstants.PageId_Search & zMode
            Dim zGSafeId As Integer = UtilGSafe.GetId(zGUID)
            Dim zIsDocumentAccess As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.DocumentAccess))
            Dim zIsRiskManager As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.RiskManager))
            Dim zIsInternal As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.Internal))
            If zIsDocumentAccess Or zIsRiskManager Or zIsInternal Then divContainerSearch.Visible = True
        End If
    End Sub



    'Protected Sub hidMasterClientID_Init(ByVal sender As Object, ByVal e As EventArgs) Handles hidMasterClientID.Init
    '    hidMasterClientID.Value = Page.Master.ClientID
    'End Sub


End Class