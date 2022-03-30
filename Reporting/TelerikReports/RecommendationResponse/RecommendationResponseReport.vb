Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class RecommendationResponseReport
    Inherits BaseReportLandscape
    Implements IUtilReport
    Implements ITelerikReport

    Public translationDictonary As Dictionary(Of String, String)

    Dim IsAutoRec As Boolean = 0

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Public Sub AdjustReport()

        Dim reportID As Integer
        reportID = rptProperties.MetaReport.colFldId
        If reportID >= 305 And reportID <= 312 Then
            IsAutoRec = 1
        End If

        If rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then
            Me.txtHazard.Value = ""
            Me.lblHazard.Value = ""
            Me.lblHazard.Visible = False
            Me.txtHazard.Visible = False
        End If

        Me.LeActualPanel.Visible = True
        Me.txtSavingsRatio.Visible = False
        Me.txtActualCostToComplete.Visible = False
        Me.txtCurrencyCode5.Visible = False

        If ShowMgmtPanel() Then
            Me.MgmtPanel.Visible = True
        Else
            Me.MgmtPanel.Visible = False
            'Me.pnlDetail.Height = Me.pnlDetail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
            'Me.detail.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
        End If

        Me.ThirdLevelPanel.Visible = ShowThirdLevelPanel()

        If Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U) Then
            RatingPanel.Visible = False
        End If

    End Sub

    Public Sub SetStatusString(ByVal zReport As Processing.Report)
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

            Dim zAllCompletedKey As String = "lblallrespscompleted" '"All Responses have been completed."
            Dim zResponsesCompletedKey As String = "lblResponsesCompleted" '"Responses Completed"
            Dim zResponsesNeededKey As String = "lblResponsesNeeded" '"Responses Needed"

            translationDictonary.TryGetValue(zAllCompletedKey, zAllCompletedKey)
            translationDictonary.TryGetValue(zResponsesCompletedKey, zResponsesCompletedKey)
            translationDictonary.TryGetValue(zResponsesNeededKey, zResponsesNeededKey)

            If zRespNeedCounter > 0 Then
                Me.txtStatus.Value = zResponsesCompletedKey & ": " & zTotalRecs - zRespNeedCounter & "   " & zResponsesNeededKey & ": " & zRespNeedCounter
            Else
                Me.txtStatus.Value = zAllCompletedKey
            End If
        Next

    End Sub

    Private Function ShowMgmtPanel() As Boolean
        If Not IsAutoRec And UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.Q) Then
            Return True
        ElseIf IsAutoRec And UtilCustomFeature.Contains(rptProperties, CChar("+")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ShowThirdLevelPanel() As Boolean
        If Not IsAutoRec And UtilCustomFeature.Contains(rptProperties, CChar("@")) Then
            Return True
        ElseIf IsAutoRec And UtilCustomFeature.Contains(rptProperties, CChar("!")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub RecommendationResponseReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        AdjustReport()
        translationDictonary = UtilReport.Translation.GetTranslationDictionary(rptProperties.Language.colFldId)

        txtTIV.Value = "TIV " & rptProperties.Currency.colFldCode & vbNewLine & "(" & UtilReport.Translation.Translate("lblmillions", translationDictonary) & ")"
        txtCurrencyCode.Value = rptProperties.Currency.colFldCode
        txtCurrencyCode2.Value = rptProperties.Currency.colFldCode
        txtCurrencyCode3.Value = rptProperties.Currency.colFldCode
        txtCurrencyCode4.Value = rptProperties.Currency.colFldCode
        txtCurrencyCode5.Value = rptProperties.Currency.colFldCode

        Dim zRangeLabel As String = UtilReport.Translation.Translate("lblRange", translationDictonary) & " " & rptProperties.Currency.colFldCode
        txtCurrencyCodeRange.Value = zRangeLabel
        txtCurrencyCodeRange2.Value = zRangeLabel
        txtCurrencyCodeRange3.Value = zRangeLabel



        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)

    End Sub

    Private Sub RecommendationResponseReport_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        UtilReport.TelerikReport.SetItemBackColorByText(sender, {txtImpact}, rptProperties)
        txtImpact_ItemDataBound(sender, e)

        SetStatusString(sender)
        BeginReportTranslation(sender)

    End Sub

    Private Sub BeginReportTranslation(sender As Processing.Report)

        'TRANSLATE INTENDED ACTION, RECSTATUS
        Dim zRptDef As RecommendationResponseReport = sender.ItemDefinition
        Dim zItems As List(Of ReportItemBase) = UtilReport.TelerikReport.GetReportItems(zRptDef.Items, Nothing)
        Dim zTextBoxItems As List(Of TextBox) = zItems.OfType(Of TextBox)().ToList

        'REMOVE ANY TEXTBOXES WHERE WE ALREADY SET THE LABEL IN THE ITEMDATABINDING EVENT
        Dim zDoNotTranslateControls() As TextBox = {txtTIV, txtCurrencyCode, txtCurrencyCode2, txtCurrencyCode3, txtCurrencyCode4, txtCurrencyCode5, txtCurrencyCodeRange, txtCurrencyCodeRange2, txtCurrencyCodeRange3}
        For Each zTextBox As TextBox In zDoNotTranslateControls
            zTextBoxItems.Remove(zTextBox)
        Next

        'TRANSLATE THE ITEM VALUES
        UtilReport.TelerikReport.TranslateLabel(sender, zTextBoxItems.ToArray, translationDictonary)
        UtilReport.TelerikReport.TranslateValue(sender, zTextBoxItems.ToArray, translationDictonary)

    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return True
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Dim zKey As String = ""
        Select Case rptProperties.Practice.Practice
            Case TblMetaPractice.Practices.Fire
                zKey = "lblFireRecRespReport"
            Case TblMetaPractice.Practices.BM
                zKey = "lblBMRecRespReport"
            Case TblMetaPractice.Practices.NatHazFlood
                zKey = "lblFloodRecRespReport"
            Case TblMetaPractice.Practices.NatHazSeismic
                zKey = "lblSeismicRecRespReport"
            Case TblMetaPractice.Practices.NatHazWind
                zKey = "lblWindRecRespReport"
            Case TblMetaPractice.Practices.NaturalHazards
                zKey = "lblNHRecRespReport"
            Case TblMetaPractice.Practices.ProcessSafety
                zKey = "lblPSRecRespReport"
        End Select
        Return translationDictonary(zKey)
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return False
    End Function

    Private Sub txtRespDate_ItemDataBound(sender As Object, e As EventArgs) Handles txtRespDate.ItemDataBound
        Dim zTextBox As Processing.TextBox = sender
        Dim zDataObject As DataRow = DirectCast(zTextBox.DataObject.RawData, DataRowView).Row
        Dim zResponseDate As Date = IIf(IsDBNull(zDataObject("ResponseDate")), Date.MinValue, zDataObject("ResponseDate"))
        Dim zStatusDate As Date = IIf(IsDBNull(zDataObject("StatusDate")), Date.MinValue, zDataObject("StatusDate"))

        If zResponseDate < zStatusDate Then
            zTextBox.Style.BackgroundColor = Color.Red
            zTextBox.Style.Color = Color.White
        End If

    End Sub

    Private Sub txtImpact_ItemDataBound(sender As Object, e As EventArgs)

        Dim zElements() As Processing.LayoutElement = Telerik.Reporting.Processing.ElementTreeHelper.FindChildByName(sender, "txtImpact", True)
        For Each zElement As Processing.LayoutElement In zElements
            Dim zProcessingTextBox As Processing.TextBox = zElement
            Dim zBackColor As System.Drawing.Color = zProcessingTextBox.Style.BackgroundColor
            If zBackColor.A = 255 And zBackColor.R = 255 And zBackColor.G = 0 And zBackColor.B = 0 Then
                zProcessingTextBox.Style.Color = Color.White
            End If
        Next

    End Sub

    Private Sub TextBox58_ItemDataBound(sender As Object, e As EventArgs) Handles TextBox58.ItemDataBound
        Dim zTextBox As Processing.TextBox = sender
        Dim zBackColor As System.Drawing.Color = zTextBox.Style.BackgroundColor
        If zBackColor = Color.Red Then
            zTextBox.Style.Color = Color.White
        End If
    End Sub
End Class






