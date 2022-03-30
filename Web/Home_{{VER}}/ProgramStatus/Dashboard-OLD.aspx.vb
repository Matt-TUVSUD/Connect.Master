Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilSafe
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.Reporting.Charting
Imports GRC.Connect.Libraries.DataLib.razor

Public Class Dashboard
    Inherits System.Web.UI.Page

    Public lblFacilityRatingsLevel1 As String = "No. of Locations Rated Better Risk"
    Public lblFacilityRatingsLevel2 As String = "No. of Locations Rated Typical Risk"
    Public lblFacilityRatingsLevel3 As String = "No. of Locations Rated Poorer Risk"
    Public lblFacilityRatingsLevel4 As String = "No. of Locations Rated Other Risk 1"
    Public lblFacilityRatingsLevel5 As String = "No. of Locations Rated Other Risk 2"

    Public FacilityRatingsColor1 As String = "#5ff300"
    Public FacilityRatingsColor2 As String = "#FFFF00"
    Public FacilityRatingsColor3 As String = "#de3c39"
    Public FacilityRatingsColor4 As String = "#FFFFFF"
    Public FacilityRatingsColor5 As String = "#FFFFFF"

    Public FacilityRatingsColorObject1 As Color = Color.Green
    Public FacilityRatingsColorObject2 As Color = Color.Yellow
    Public FacilityRatingsColorObject3 As Color = Color.Red
    Public FacilityRatingsColorObject4 As Color = Color.Blue
    Public FacilityRatingsColorObject5 As Color = Color.Purple

    Public RecLE1BilLabel As String = "No. of Recs. with LE's > 1bil"
    Public RecLE500milLabel As String = "No. of Recs. with LE's > 500mil - 1bil"
    Public RecLE250milLabel As String = "No. of Recs. with LE's > 250mil - 500mil"
    Public RecLE100milLabel As String = "No. of Recs. with LE's > 100mil - 250mil"
    Public RecLE50milLabel As String = "No. of Recs. with LE's > 50mil - 100mil"
    Public RecLE25milLabel As String = "No. of Recs. with LE's > 25mil - 50mil"
    Public RecLE10milLabel As String = "No. of Recs. with LE's > 10mil - 25mil"

    'Public URL1 As String = "#"
    'Public URL2 As String = "#"
    'Public URL3 As String = "#"
    'Public URL4 As String = "#"
    'Public URL5 As String = "#"

    Public lblCustomAccess As String = ""

    Public ReportFileName As String = ""
    Public RatingIndustryGroupText As String = "N/A"


    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(GetGUIDFromQueryString(), PageId_ProgramStatusForm, PageId_ProgramStatusForm)

    End Sub


    Private Sub loadLists()

    End Sub


    Private Sub loadDefaults()
        Dim zGSafeGuid As String = GetGUIDFromQueryString()

        Dim zUserid As Integer = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "Program Status")

        ' GET PAGE COMPONENTS, TITLE, CLIENT NAME
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetProgramStatus(zGSafeGuid)
        'lblPageTitle.Text = GetValue(zGSafeGuid, KeyName.PageTitle)
        'lblCompanyNameForm.Text = GetValue(zGSafeGuid, KeyName.ClientName)

        ' SHOW OR HIDE DIVS DEPENDING ON SPECIAL FEATURES
        Call ShowStandardDivs()
        Dim zFeatures As String = GetValue(zGSafeGuid, KeyName.clientFeatures).ToLower()
        If zFeatures.Contains("1") Or zFeatures.Contains("2") Or zFeatures.Contains("4") Or zFeatures.Contains("5") Or zFeatures.Contains("a") Then
            divAverageGRCFacilityScore.Visible = False
            divAverageIndustryGroupFacilityScore.Visible = False
            divCustomFeaturePlaceholder1.Visible = True
            divCustomFeaturePlaceholder2.Visible = True
            divChartFireRating.Attributes.Remove("class")
            divChartBMRating.Attributes.Remove("class")
            divChartFireRating.Attributes.Add("class", "programstat_ChartContainer_ClientFeatures")
            divChartBMRating.Attributes.Add("class", "programstat_ChartContainer_ClientFeatures")
        End If
        If zFeatures.Contains("j") Then
            divJurisObjectsOverdue.Visible = True
        End If

        Dim zFileNo As String = ""
        If Not Request.QueryString("p1") Is Nothing Then
            If Request.QueryString("p1").Length > 0 Then
                zFileNo = Request.QueryString("p1").ToString
                If IsValidLocation(zGSafeGuid, zFileNo) Then
                    UtilGSafe.SetLocationNavigationInformation(zGSafeGuid, zFileNo)
                Else
                    Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(GetValue(zGSafeGuid, KeyName.LoggedInUserEmail), "IsNotSecure hit in file: " & HttpContext.Current.Request.Url.AbsolutePath, HttpContext.Current.Request.Url.AbsolutePath, "SAID IsNotSecure", Request.ServerVariables("REMOTE_ADDR"))
                    Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", True)
                End If
            End If
        End If

    End Sub


    Private Sub loadData()
        Dim zGSafeGuid As String = GetGUIDFromQueryString()
        Dim zFilePrefix As String = GetValue(zGSafeGuid, KeyName.FilePreFix)

        Dim zCustomAccess As String = GetValue(zGSafeGuid, KeyName.ReportPreFilter_CustomAccess)
        '        Dim zDivision As String = GetValue(zGSafeGuid, KeyName.ReportPreFilter_Division)
        UtilGSafe.SetValue(zGSafeGuid, KeyName.ReportPreFilter_Division, "GRC-Dashboard", KeyName.ReportPreFilter_Division)
        Dim zCurrencyDefault As String = GetValue(zGSafeGuid, zFilePrefix, PreferenceKeyName.CurrencyDefaultText)

        ' FIND THE CURRENT CURRENCY OF THE USER, ALWAYS DISPLAY
        Dim zCurrencyDefaultText As String = "US Dollar"
        Dim zColl As New List(Of rowTblMetaCurrency)
        Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaCurrency] WHERE [fldCode] = @CurrencyCode")
        zCmd.Parameters.AddWithValue("@CurrencyCode", zCurrencyDefault)
        zColl = TblMetaCurrency.LoadData(zCmd)
        If zColl.Count > 0 Then
            zCurrencyDefaultText = zColl(0).colFldName
        End If
        lblCurrencySetting.Text = zCurrencyDefaultText

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub


    Private Sub ShowStandardDivs()
        divAverageGRCFacilityScore.Visible = True
        divAverageIndustryGroupFacilityScore.Visible = True
        divJurisObjectsOverdue.Visible = False
        divCustomFeaturePlaceholder1.Visible = False
        divCustomFeaturePlaceholder2.Visible = False
        divCustomFeaturePlaceholder3.Visible = False

    End Sub


    Private Sub LoadTotals()

    End Sub


    Private Sub LoadFormats()
        ' PERCENT FORMATS ARE DONE WHEN THE FIELD IS POPULATED

    End Sub


    Private Sub LoadFacilityRatings(ByRef pFacilityRatings As Connect.Libraries.CoreLib.RatingTables)
        ' GET THE CORRECT LABELS, COLORS, DATA, AND LINKS FOR FIRE
        Dim zCount As Integer = 1
        For Each zRow As DataRow In pFacilityRatings.Fire.Rows
            Select Case zCount
                Case 1
                    lblFacilityRatingsLevel1 = zRow("Label")
                    FacilityRatingsColor1 = zRow("ColorHex")
                    FacilityRatingsColorObject1 = System.Drawing.ColorTranslator.FromHtml(zRow("ColorHex"))
                    'RatingRiskFire1.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskFire1.Text = zRow("Value").ToString() & ""
                Case 2
                    lblFacilityRatingsLevel2 = zRow("Label")
                    FacilityRatingsColor2 = zRow("ColorHex")
                    FacilityRatingsColorObject2 = System.Drawing.ColorTranslator.FromHtml(zRow("ColorHex"))
                    'RatingRiskFire2.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskFire2.Text = zRow("Value").ToString() & ""
                Case 3
                    lblFacilityRatingsLevel3 = zRow("Label")
                    FacilityRatingsColor3 = zRow("ColorHex")
                    FacilityRatingsColorObject3 = System.Drawing.ColorTranslator.FromHtml(zRow("ColorHex"))
                    'RatingRiskFire3.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskFire3.Text = zRow("Value").ToString() & ""
                Case 4
                    lblFacilityRatingsLevel4 = zRow("Label")
                    FacilityRatingsColor4 = zRow("ColorHex")
                    FacilityRatingsColorObject4 = System.Drawing.ColorTranslator.FromHtml(zRow("ColorHex"))
                    'RatingRiskFire4.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskFire4.Text = zRow("Value").ToString() & ""
                Case 5
                    lblFacilityRatingsLevel5 = zRow("Label")
                    FacilityRatingsColor5 = zRow("ColorHex")
                    FacilityRatingsColorObject5 = System.Drawing.ColorTranslator.FromHtml(zRow("ColorHex"))
                    'RatingRiskFire5.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskFire5.Text = zRow("Value").ToString() & ""
            End Select
            zCount = zCount + 1
        Next

        ' GET THE CORRECT LABELS, COLORS, DATA, AND LINKS FOR BM
        zCount = 1
        For Each zRow As DataRow In pFacilityRatings.BM.Rows
            Select Case zCount
                Case 1
                    'RatingRiskBM1.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskBM1.Text = zRow("Value").ToString() & ""
                Case 2
                    'RatingRiskBM2.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskBM2.Text = zRow("Value").ToString() & ""
                Case 3
                    'RatingRiskBM3.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskBM3.Text = zRow("Value").ToString() & ""
                Case 4
                    'RatingRiskBM4.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskBM4.Text = zRow("Value").ToString() & ""
                Case 5
                    'RatingRiskBM5.OnClientClick = "onBuildPopupLink('" & zRow("URL") & "'); return false;"
                    'RatingRiskBM5.Text = zRow("Value").ToString() & ""
            End Select
            zCount = zCount + 1
        Next

    End Sub


    Private Sub LoadFireRatingsChartSettings()

    End Sub


    Private Sub LoadBMRatingsChartSettings()

    End Sub


    Private Sub LoadFireRatingsChartData(ByRef pFacilityRatings As Connect.Libraries.CoreLib.RatingTables)
        'Get the Data for the chart
        'Dim zBetterRisk As Double = LoadChartFields(pTable, modProgramStatus.ProgramStatusField.RatingRiskPcntBetterFire)
        'Dim zTypicalRisk As Double = LoadChartFields(pTable, modProgramStatus.ProgramStatusField.RatingRiskPcntTypicalFire)
        'Dim zPoorRisk As Double = LoadChartFields(pTable, modProgramStatus.ProgramStatusField.RatingRiskPcntPoorerFire)

        ' GET THE CORRECT LABELS, COLORS, DATA, AND LINKS FOR FIRE
        Dim zRisk1 As Double = 0.0
        Dim zRiskLabel1 As String = ""
        Dim zURL1 As String = "#"
        Dim zRisk2 As Double = 0.0
        Dim zRiskLabel2 As String = ""
        Dim zURL2 As String = "#"
        Dim zRisk3 As Double = 0.0
        Dim zRiskLabel3 As String = ""
        Dim zURL3 As String = "#"
        Dim zRisk4 As Double = 0.0
        Dim zRiskLabel4 As String = ""
        Dim zURL4 As String = "#"
        Dim zRisk5 As Double = 0.0
        Dim zRiskLabel5 As String = ""
        Dim zURL5 As String = "#"
        Dim zCount As Integer = 1
        For Each zRow As DataRow In pFacilityRatings.Fire.Rows
            Select Case zCount
                Case 1
                    zRisk1 = zRow("Percent")
                    zRiskLabel1 = zRow("Label")
                    zURL1 = zRow("URL")
                Case 2
                    zRisk2 = zRow("Percent")
                    zRiskLabel2 = zRow("Label")
                    zURL2 = zRow("URL")
                Case 3
                    zRisk3 = zRow("Percent")
                    zRiskLabel3 = zRow("Label")
                    zURL3 = zRow("URL")
                Case 4
                    zRisk4 = zRow("Percent")
                    zRiskLabel4 = zRow("Label")
                    zURL4 = zRow("URL")
                Case 5
                    zRisk5 = zRow("Percent")
                    zRiskLabel5 = zRow("Label")
                    zURL5 = zRow("URL")
            End Select
            zCount = zCount + 1
        Next

    End Sub


    Private Sub LoadBMRatingsChartData(ByRef pFacilityRatings As Connect.Libraries.CoreLib.RatingTables)
        'Get the Data for the chart
        'Dim zBetterRisk As Double = LoadChartFields(pTable, modProgramStatus.ProgramStatusField.RatingRiskPcntBetterBM)
        'Dim zTypicalRisk As Double = LoadChartFields(pTable, modProgramStatus.ProgramStatusField.RatingRiskPcntTypicalBM)
        'Dim zPoorRisk As Double = LoadChartFields(pTable, modProgramStatus.ProgramStatusField.RatingRiskPcntPoorerBM)

        ' GET THE CORRECT LABELS, COLORS, DATA, AND LINKS FOR BM
        Dim zRisk1 As Double = 0.0
        Dim zRiskLabel1 As String = ""
        Dim zURL1 As String = "#"
        Dim zRisk2 As Double = 0.0
        Dim zRiskLabel2 As String = ""
        Dim zURL2 As String = "#"
        Dim zRisk3 As Double = 0.0
        Dim zRiskLabel3 As String = ""
        Dim zURL3 As String = "#"
        Dim zRisk4 As Double = 0.0
        Dim zRiskLabel4 As String = ""
        Dim zURL4 As String = "#"
        Dim zRisk5 As Double = 0.0
        Dim zRiskLabel5 As String = ""
        Dim zURL5 As String = "#"
        Dim zCount As Integer = 1
        For Each zRow As DataRow In pFacilityRatings.BM.Rows
            Select Case zCount
                Case 1
                    zRisk1 = zRow("Percent")
                    zRiskLabel1 = zRow("Label")
                    zURL1 = zRow("URL")
                Case 2
                    zRisk2 = zRow("Percent")
                    zRiskLabel2 = zRow("Label")
                    zURL2 = zRow("URL")
                Case 3
                    zRisk3 = zRow("Percent")
                    zRiskLabel3 = zRow("Label")
                    zURL3 = zRow("URL")
                Case 4
                    zRisk4 = zRow("Percent")
                    zRiskLabel4 = zRow("Label")
                    zURL4 = zRow("URL")
                Case 5
                    zRisk5 = zRow("Percent")
                    zRiskLabel5 = zRow("Label")
                    zURL5 = zRow("URL")
            End Select
            zCount = zCount + 1
        Next

        'Set Chart Values
        'If zRisk1 + zRisk2 + zRisk3 + zRisk4 + zRisk5 <= 0 Then
        '    radChartBMRating.Visible = False
        '    spnBMNoRatingsChart.Visible = True
        'Else
        '    radChartBMRating.Visible = True
        '    spnBMNoRatingsChart.Visible = False
        '    PlotRatings(zRisk1, zRiskLabel1, zRisk2, zRiskLabel2, zRisk3, zRiskLabel3, zRisk4, zRiskLabel4, zRisk5, zRiskLabel5, 2, zURL1, zURL2, zURL3, zURL4, zURL5)
        'End If


    End Sub


    Private Sub PlotRatings(ByVal pRisk1 As Double, ByVal pRiskLabel1 As String, ByVal pRisk2 As Double, ByVal pRiskLabel2 As String, ByVal pRisk3 As Double, ByVal pRiskLabel3 As String, ByVal pRisk4 As Double, ByVal pRiskLabel4 As String, ByVal pRisk5 As Double, ByVal pRiskLabel5 As String, ByVal pPractice As Integer, ByVal pURL1 As String, ByVal pURL2 As String, ByVal pURL3 As String, ByVal pURL4 As String, ByVal pURL5 As String)
        Dim zTotal As Double
        Dim zItem1 As Telerik.Charting.ChartSeriesItem = Nothing
        Dim zItem2 As Telerik.Charting.ChartSeriesItem = Nothing
        Dim zItem3 As Telerik.Charting.ChartSeriesItem = Nothing
        Dim zItem4 As Telerik.Charting.ChartSeriesItem = Nothing
        Dim zItem5 As Telerik.Charting.ChartSeriesItem = Nothing

        If pRiskLabel5.Length > 0 Then
            zTotal = pRisk1 + pRisk2 + pRisk3 + pRisk4 + pRisk5
        ElseIf pRiskLabel4.Length > 0 Then
            zTotal = pRisk1 + pRisk2 + pRisk3 + pRisk4
        Else
            zTotal = pRisk1 + pRisk2 + pRisk3
        End If

        zItem1 = New Telerik.Charting.ChartSeriesItem(CalculatePercentage(pRisk1, zTotal))
        zItem1.Name = pRiskLabel1
        zItem1.Label.TextBlock.Text = zItem1.YValue & "%"
        zItem1.Label.TextBlock.Appearance.Dimensions.Paddings = New Telerik.Charting.Styles.ChartPaddings(New Telerik.Charting.Styles.Unit(3, Telerik.Charting.Styles.UnitType.Pixel))
        FormatItem(zItem1, 1, pURL1, "")

        zItem2 = New Telerik.Charting.ChartSeriesItem(CalculatePercentage(pRisk2, zTotal))
        zItem2.Name = pRiskLabel2
        zItem2.Label.TextBlock.Text = zItem2.YValue & "%"
        FormatItem(zItem2, 2, pURL2, "")

        zItem3 = New Telerik.Charting.ChartSeriesItem(CalculatePercentage(pRisk3, zTotal))
        zItem3.Name = pRiskLabel3
        zItem3.Label.TextBlock.Text = zItem3.YValue & "%"
        FormatItem(zItem3, 3, pURL3, "")

        If pRiskLabel4.Length > 0 Then
            zItem4 = New Telerik.Charting.ChartSeriesItem(CalculatePercentage(pRisk4, zTotal))
            zItem4.Name = pRiskLabel4
            zItem4.Label.TextBlock.Text = zItem4.YValue & "%"
            FormatItem(zItem4, 4, pURL4, "")
        End If

        If pRiskLabel5.Length > 0 Then
            zItem5 = New Telerik.Charting.ChartSeriesItem(CalculatePercentage(pRisk5, zTotal))
            zItem5.Name = pRiskLabel5
            zItem5.Label.TextBlock.Text = zItem5.YValue & "%"
            FormatItem(zItem5, 5, pURL5, "")
        End If

    End Sub


    Private Function CalculatePercentage(ByVal pNumber As Double, ByVal pTotal As Double) As Double
        If pTotal <> 0 Then
            'Dim zPercent As Single = (pNumber / pTotal) * 100
            'Return Int(Math.Round(zPercent, 1))
            'Return Int(Math.Round(pNumber * 100))
            'Return Math.Round(pNumber * 100, 1)
            Return Math.Round(pNumber, 3) * 100
        Else
            Return 0
        End If
    End Function


    Private Sub FormatItem(ByRef pItem As Telerik.Charting.ChartSeriesItem, ByVal pType As Integer, ByVal pURL As String, ByVal pToolTip As String)
        pItem.Label.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 9, FontStyle.Regular)
        'pItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Outside
        pItem.Label.Appearance.LabelLocation = Charting.Styles.StyleSeriesItemLabel.ItemLabelLocation.Auto
        pItem.Label.Appearance.Distance = 5
        pItem.Appearance.Exploded = False
        pItem.Appearance.Border.Visible = True
        pItem.Appearance.Border.Color = Color.Black
        pItem.Appearance.Border.Width = 1
        pItem.Appearance.FillStyle.FillType = Charting.Styles.FillType.Gradient
        pItem.Appearance.FillStyle.FillSettings.GradientMode = Charting.Styles.GradientFillStyle.BackwardDiagonal
        pItem.ActiveRegion.Url = pURL
        If pToolTip.Length > 0 Then pItem.ActiveRegion.Tooltip = ""
        pItem.ActiveRegion.Attributes = "target=_blank"
        Select Case pType
            Case 1
                'pItem.Appearance.FillStyle.MainColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetFirstColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Green)
                'pItem.Appearance.FillStyle.SecondColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetLastColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Green)
                pItem.Appearance.FillStyle.MainColor = FacilityRatingsColorObject1
                pItem.Appearance.FillStyle.SecondColor = ControlPaint.Dark(FacilityRatingsColorObject1, 0.3)
            Case 2
                'pItem.Appearance.FillStyle.MainColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetFirstColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Yellow)
                'pItem.Appearance.FillStyle.SecondColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetLastColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Yellow)
                pItem.Appearance.FillStyle.MainColor = FacilityRatingsColorObject2
                pItem.Appearance.FillStyle.SecondColor = ControlPaint.Dark(FacilityRatingsColorObject2, 0.3)
            Case 3
                'pItem.Appearance.FillStyle.MainColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetFirstColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Red)
                'pItem.Appearance.FillStyle.SecondColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetLastColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Red)
                pItem.Appearance.FillStyle.MainColor = FacilityRatingsColorObject3
                pItem.Appearance.FillStyle.SecondColor = ControlPaint.Dark(FacilityRatingsColorObject3, 0.3)
            Case 4
                'pItem.Appearance.FillStyle.MainColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetFirstColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Red)
                'pItem.Appearance.FillStyle.SecondColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetLastColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Red)
                pItem.Appearance.FillStyle.MainColor = FacilityRatingsColorObject4
                pItem.Appearance.FillStyle.SecondColor = ControlPaint.Dark(FacilityRatingsColorObject4, 0.3)
            Case 5
                'pItem.Appearance.FillStyle.MainColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetFirstColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Red)
                'pItem.Appearance.FillStyle.SecondColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetLastColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Red)
                pItem.Appearance.FillStyle.MainColor = FacilityRatingsColorObject5
                pItem.Appearance.FillStyle.SecondColor = ControlPaint.Dark(FacilityRatingsColorObject5, 0.3)
            Case Else
                pItem.Appearance.FillStyle.MainColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetFirstColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Blue)
                pItem.Appearance.FillStyle.SecondColor = GRC.Connect.Libraries.CoreLib.UtilReporting.Chart.GetLastColor(Libraries.CoreLib.UtilReporting.Chart.ChartColor.Blue)
        End Select

    End Sub

End Class