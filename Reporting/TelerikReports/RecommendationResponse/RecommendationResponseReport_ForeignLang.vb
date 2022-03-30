Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class RecommendationResponseReport_ForeignLang
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Private _LabelDict As Dictionary(Of String, String)
    Private _ValueDict As Dictionary(Of String, String)

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
        AdjustReport()
        Dim zTranslate As New Core.UtilTranslation(Core.UtilTranslation.Language.English, rptProperties.Language.colFldId)
        _LabelDict = zTranslate.GetLabelTranslationDictionary(Core.UtilTranslation.TranslateKey.ByLabelName)
        _ValueDict = zTranslate.GetLabelTranslationDictionary(Core.UtilTranslation.TranslateKey.ByValue)
    End Sub


    Public Sub AdjustReport()

        If rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then
            Me.txtHazard.Value = ""
            Me.lblHazard.Value = ""
            Me.lblHazard.Visible = False
            Me.txtHazard.Visible = False
        End If

        If IsLeClient() Then
            Me.LeActualPanel.Visible = True
            Me.txtSavingsRatio.Visible = False
            Me.txtActualCostToComplete.Visible = False
            Me.txtActualCostToCompleteLabel.Visible = False
        Else
            Me.LeActualPanel.Visible = False
            Me.pnlDetail.Height = Me.pnlDetail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.22, UnitType.Inch))
            Me.detail.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.22, UnitType.Inch))
        End If


        If ShowMgmtPanel() Then
            Me.MgmtPanel.Visible = True
        Else
            Me.MgmtPanel.Visible = False
            Me.pnlDetail.Height = Me.pnlDetail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
            Me.detail.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
        End If

    End Sub

    Public Sub SetStatusString(ByVal zReport As Processing.Report, ByVal pLanguage As Core.TblMetaLanguage.Languages)
        Dim zPanelElements() As Processing.LayoutElement = Processing.ElementTreeHelper.FindChildByName(zReport, "pnlDetail", True)
        Dim zTotalRecs As Integer = zPanelElements.Count
        Dim zResponse As Processing.TextBox = Nothing
        Dim zStatus As Processing.TextBox = Nothing
        Dim zRespNeedCounter As Integer = 0


        For Each zPanel As Processing.Panel In zPanelElements
            zResponse = Processing.ElementTreeHelper.GetChildByName(zPanel, "txtRespDate")
            zStatus = Processing.ElementTreeHelper.GetChildByName(zPanel, "txtStatusDate")

            If IsNothing(zResponse.Value) Then
                zRespNeedCounter = zRespNeedCounter + 1
            ElseIf zStatus.Value > zResponse.Value Then
                zRespNeedCounter = zRespNeedCounter + 1
            End If

        Next

        Dim zZeroRecs As String = "All Responses have been completed."
        Dim zResponseCompleted As String = "Responses Completed"
        Dim zResponseNeeded As String = "Responses Needed"

        If _ValueDict.TryGetValue(zResponseCompleted, Nothing) Then _ValueDict.TryGetValue(zResponseCompleted, zResponseCompleted)
        If _ValueDict.TryGetValue(zResponseNeeded, Nothing) Then _ValueDict.TryGetValue(zResponseNeeded, zResponseNeeded)
        If _ValueDict.TryGetValue(zZeroRecs, Nothing) Then _ValueDict.TryGetValue(zZeroRecs, zZeroRecs)

        If zRespNeedCounter > 0 Then
            Me.txtStatus.Value = zResponseCompleted & ": " & zTotalRecs - zRespNeedCounter & "   " & zResponseNeeded & ": " & zRespNeedCounter
        Else
            Me.txtStatus.Value = zZeroRecs
        End If

    End Sub

    Private Sub ColorImpactBackGroundColor(sender As Object, e As System.EventArgs) Handles txtImpact.ItemDataBound

        Dim zTextBox As Telerik.Reporting.Processing.TextBox = DirectCast(sender, Telerik.Reporting.Processing.TextBox)
        zTextBox.Style.BackgroundColor = Core.UtilColor.GetColorByText(zTextBox.Text)

    End Sub

    Private Function IsLeClient() As Boolean
        If rptProperties.ClientSpecialFeatures.ToLower.Contains("x") Or rptProperties.ClientSpecialFeatures.ToLower.Contains("l") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ShowMgmtPanel() As Boolean

        If rptProperties.ClientSpecialFeatures.ToLower.Contains("q") Then
            'If Me._RptEngine.FilterValue(Core.UtilReporting.ReportFilter.CustomSetting).ToLower = "autorec" Then
            '    Dim zClient As New Core.BusinessObjects.Clients
            '    zClient.LoadByFilePrefix(Me.FilePrefix)
            '    Return zClient.MgmtARR
            'End If
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub RecommendationResponseReport_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound

        SetStatusString(sender, rptProperties.Language.colFldId) '_RptEngine.FilterValue(Core.UtilReporting.ReportFilter.Language))
        SetLanguage(rptProperties.Language.colFldId, sender)

    End Sub

    Private Sub SetLanguage(ByVal pLanguage As Core.TblMetaLanguage.Languages, ByVal pElement As Telerik.Reporting.Processing.LayoutElement)

        Dim zTranslation As New Core.UtilTranslation(Core.UtilTranslation.Language.English, pLanguage)
        Dim zImpactElements As List(Of Processing.LayoutElement) = Processing.ElementTreeHelper.FindChildByName(pElement, "txtImpact", True).ToList
        Dim zPrimaryElements As List(Of Processing.LayoutElement) = Processing.ElementTreeHelper.FindChildByName(pElement, "txtPrimary", True).ToList
        Dim zSecondaryElements As List(Of Processing.LayoutElement) = Processing.ElementTreeHelper.FindChildByName(pElement, "txtSecondary", True).ToList
        Dim zRecStatusElements As List(Of Processing.LayoutElement) = Processing.ElementTreeHelper.FindChildByName(pElement, "txtRecStatus", True).ToList
        Dim zRecIntendedActionElements As List(Of Processing.LayoutElement) = Processing.ElementTreeHelper.FindChildByName(pElement, "txtIntendedAction", True).ToList
        Dim zMgmtRecActionElements As List(Of Processing.LayoutElement) = Processing.ElementTreeHelper.FindChildByName(pElement, "txtMgmtRespAction", True).ToList

        Dim zDict As Dictionary(Of String, String) = Nothing

        'LOOK UP FROM THE DDTABLES THE DIRECT TRANSLATION FOR THE SELECTED VALUE
        zDict = zTranslation.GetImpactTranslationDictionary()
        For Each zLayOutElement As Processing.LayoutElement In zImpactElements
            Dim zTextBox As Processing.TextBox = DirectCast(zLayOutElement, Processing.TextBox)
            If zTextBox.Value IsNot Nothing Then
                If zDict.TryGetValue(zTextBox.Value, Nothing) Then
                    zDict.TryGetValue(zTextBox.Value, zTextBox.Value)
                End If
            End If
        Next

        zDict = zTranslation.GetPrimaryRecTranslationDictionary
        For Each zLayOutElement As Processing.LayoutElement In zPrimaryElements
            Dim zTextBox As Processing.TextBox = DirectCast(zLayOutElement, Processing.TextBox)
            If zTextBox.Value IsNot Nothing Then
                If zDict.TryGetValue(zTextBox.Value, Nothing) Then
                    zDict.TryGetValue(zTextBox.Value, zTextBox.Value)
                End If
            End If
        Next

        zDict = zTranslation.GetSecondaryRecTranslationDictionary
        For Each zLayOutElement As Processing.LayoutElement In zSecondaryElements
            Dim zTextBox As Processing.TextBox = DirectCast(zLayOutElement, Processing.TextBox)
            If zTextBox.Value IsNot Nothing Then
                If zDict.TryGetValue(zTextBox.Value, Nothing) Then
                    zDict.TryGetValue(zTextBox.Value, zTextBox.Value)
                End If
            End If
        Next

        zDict = zTranslation.GetIntendedActionTranslationDictionary
        For Each zLayOutElement As Processing.LayoutElement In zRecIntendedActionElements
            Dim zTextBox As Processing.TextBox = DirectCast(zLayOutElement, Processing.TextBox)
            If zTextBox.Value IsNot Nothing Then
                If zDict.TryGetValue(zTextBox.Value, Nothing) Then
                    zDict.TryGetValue(zTextBox.Value, zTextBox.Value)
                End If
            End If
        Next

        zDict = zTranslation.GetRecStatusTranslationDictionary
        For Each zLayOutElement As Processing.LayoutElement In zRecStatusElements
            Dim zTextBox As Processing.TextBox = DirectCast(zLayOutElement, Processing.TextBox)
            If zTextBox.Value IsNot Nothing Then
                If zDict.TryGetValue(zTextBox.Value, Nothing) Then
                    zDict.TryGetValue(zTextBox.Value, zTextBox.Value)
                End If
            End If
        Next


        zDict = zTranslation.GetMgmtIntendedActionTranslationDictionary
        For Each zLayOutElement As Processing.LayoutElement In zMgmtRecActionElements
            Dim zTextBox As Processing.TextBox = DirectCast(zLayOutElement, Processing.TextBox)
            If zTextBox.Value IsNot Nothing Then
                If zDict.TryGetValue(zTextBox.Value, Nothing) Then
                    zDict.TryGetValue(zTextBox.Value, zTextBox.Value)
                End If
            End If
        Next




        'GET ALL ELEMENTS ON THE FORM
        Dim zChildElements As IEnumerable(Of Processing.LayoutElement) = Telerik.Reporting.Processing.ElementTreeHelper.GetChildElements(pElement)

        'GET DICTIONARY
        For Each zLayoutElement As Processing.LayoutElement In zChildElements

            'IF  CURRENT LAYOUT ELEMENT HAS CHILD ELEMENTS THEN GET THOSE; FOR PANELS
            If Telerik.Reporting.Processing.ElementTreeHelper.GetChildElements(zLayoutElement).Count <> 0 Then
                SetLanguage(pLanguage, zLayoutElement)
            End If

            'IF THE CURRENT LAYOUT ELEMENT IS TEXTBOX AND NOT IN THE LISTS ABOVE THEN TRY TO TRANSLATE LABEL VALUE
            If TypeOf zLayoutElement Is Telerik.Reporting.Processing.TextBox Or TypeOf zLayoutElement Is Telerik.Reporting.Processing.HtmlTextBox Then
                If Not zImpactElements.Contains(zLayoutElement) _
                    And Not zPrimaryElements.Contains(zLayoutElement) _
                    And Not zSecondaryElements.Contains(zLayoutElement) _
                    And Not zRecStatusElements.Contains(zLayoutElement) _
                    And Not zRecIntendedActionElements.Contains(zLayoutElement) Then

                    Dim zObject As Object
                    If TypeOf zLayoutElement Is Processing.TextBox Then
                        zObject = DirectCast(zLayoutElement, Telerik.Reporting.Processing.TextBox)
                    Else
                        zObject = DirectCast(zLayoutElement, Telerik.Reporting.Processing.HtmlTextBox)
                    End If

                    If zObject.Value IsNot Nothing Then
                        If _LabelDict.TryGetValue(zObject.Name, Nothing) Then
                            _LabelDict.TryGetValue(zObject.Name, zObject.value)
                            Debug.Print(zObject.value)
                        Else
                            Debug.Print(zObject.value)
                        End If
                    End If
                End If
            End If
        Next



        'ADJUST "RANGE" WORD
        Dim zRangeTranslated As String = ""
        _LabelDict.TryGetValue("lblRange", zRangeTranslated)

        Dim zElement1 As Processing.LayoutElement = Processing.ElementTreeHelper.GetChildByName(pElement, "txtLeCurrentRangeLabel")
        Dim zElement2 As Processing.LayoutElement = Processing.ElementTreeHelper.GetChildByName(pElement, "txtLeCompletedRangeLabel")
        Dim zElement3 As Processing.LayoutElement = Processing.ElementTreeHelper.GetChildByName(pElement, "txtLeEstCompleteRangeLabel")
        Dim zElement4 As Processing.LayoutElement = Processing.ElementTreeHelper.GetChildByName(pElement, "txtActualCostToCompleteLabel")

        If zElement1 IsNot Nothing And zElement2 IsNot Nothing And zElement3 IsNot Nothing And zElement4 IsNot Nothing Then
            Dim zTextBox1 As Processing.TextBox = DirectCast(zElement1, Processing.TextBox)
            Dim zTextBox2 As Processing.TextBox = DirectCast(zElement2, Processing.TextBox)
            Dim zTextBox3 As Processing.TextBox = DirectCast(zElement3, Processing.TextBox)
            Dim zTextBox4 As Processing.TextBox = DirectCast(zElement4, Processing.TextBox)

            zTextBox1.Value = zTextBox1.Value.ToString.Replace("Range", zRangeTranslated & " ")
            zTextBox2.Value = zTextBox2.Value.ToString.Replace("Range", zRangeTranslated & " ")
            zTextBox3.Value = zTextBox3.Value.ToString.Replace("Range", zRangeTranslated & " ")
            zTextBox4.Value = zTextBox4.Value.ToString.Replace("Range", zRangeTranslated & " ")
        End If


        'ADJUST "MILLIONS" WORD
        Dim zMilTranslated As String = ""
        _LabelDict.TryGetValue("lblmillions", zMilTranslated)

        Dim zElement5 As Processing.LayoutElement = Processing.ElementTreeHelper.GetChildByName(pElement, "txtTiv")
        If zElement5 IsNot Nothing Then
            Dim zTextBox1 As Processing.TextBox = DirectCast(zElement5, Processing.TextBox)
            If zTextBox1.Value IsNot Nothing Then
                zTextBox1.Value = zTextBox1.Value.ToString.Replace("millions", zMilTranslated & " ")
            End If
        End If

    End Sub

    Private Sub RecommendationResponseReport_ForeignLang(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound

        'ADJUST THE REPORT TITLE STRING TO THE APPROPRIATE LANG
        Dim zTitleHTMLTb As Processing.HtmlTextBox = DirectCast(sender, Processing.HtmlTextBox)
        Dim zNewReportTitle As String = ""
        Dim zLabelNameToLookUp As String = ""
        Dim zOldReportTitle As String = ""
        If zTitleHTMLTb IsNot Nothing Then
            Select Case rptProperties.Practice.Practice
                Case TblMetaPractice.Practices.Fire
                    zLabelNameToLookUp = "lblFireRecRespReport"
                    zOldReportTitle = "Fire Recommendation Response Report"
                Case TblMetaPractice.Practices.BM
                    zLabelNameToLookUp = "lblBMRecRespReport"
                    zOldReportTitle = "B&M Recommendation Response Report"
                Case TblMetaPractice.Practices.NatHazFlood
                    zLabelNameToLookUp = "lblFloodRecRespReport"
                    zOldReportTitle = "Natural Hazards/Flood Recommendation Response Report"
                Case TblMetaPractice.Practices.NatHazSeismic
                    zLabelNameToLookUp = "lblSeismicRecRespReport"
                    zOldReportTitle = "Natural Hazards/Seismic Recommendation Response Report"
                Case TblMetaPractice.Practices.NatHazWind
                    zLabelNameToLookUp = "lblWindRecRespReport"
                    zOldReportTitle = "Natural Hazards/Wind Recommendation Response Report"
            End Select

            _LabelDict.TryGetValue(zLabelNameToLookUp, zNewReportTitle)

            If zNewReportTitle IsNot Nothing Then
                Dim zHTMLVal As String = zTitleHTMLTb.Value.ToString.Replace(zOldReportTitle, zNewReportTitle)
                zTitleHTMLTb.Value = zHTMLVal
            End If
        End If


        'ADJUST THE REPORT TITLE STRING TO THE APPROPRIATE LANG
        Dim zTitleHTMLTb As Processing.HtmlTextBox = DirectCast(sender, Processing.HtmlTextBox)
        Dim zNewSort As String = ""
        Dim zLabelNameToLookUp As String = ""
        Dim zOldSort As String = ""
        If zTitleHTMLTb IsNot Nothing Then

            _LabelDict.TryGetValue("lblSortOrder", zNewSort)

            If zNewSort IsNot Nothing Then
                zTitleHTMLTb.Value = zNewSort
            End If
        End If


    End Sub

    Public Property rptProperties As UtilReport.ReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader

    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle

    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle

    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle

    End Function
End Class






