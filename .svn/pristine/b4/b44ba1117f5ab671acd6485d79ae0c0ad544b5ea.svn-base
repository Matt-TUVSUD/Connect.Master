Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class RecommendationResponseReportIR
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

    Private Sub AdjustReport()

        Dim reportID As Integer
        reportID = rptProperties.MetaReport.colFldId
        If reportID >= 305 And reportID <= 312 Then
            IsAutoRec = 1
        End If

        If ShowMgmtPanel() Then
            Me.MgmtPanel.Visible = True
        Else
            Me.MgmtPanel.Visible = False
            Me.pnlDetail.Height = Me.pnlDetail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
            Me.detail.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
            Me.Panel1.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.35, UnitType.Inch))
        End If

        If ShowThirdLevelPanel() Then
            Me.ThirdLevelPanel.Visible = True
        Else
            Me.ThirdLevelPanel.Visible = False
            Me.pnlDetail.Height = Me.pnlDetail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.38, UnitType.Inch))
            Me.detail.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.38, UnitType.Inch))
            Me.Panel1.Height = Me.detail.Height.Subtract(New Telerik.Reporting.Drawing.Unit(0.38, UnitType.Inch))
        End If

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

    Private Sub RecommendationResponseReportIR_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        AdjustReport()
        translationDictonary = UtilReport.Translation.GetTranslationDictionary(rptProperties.Language.colFldId)
        txtTIV.Value = "TIV " & rptProperties.Currency.colFldCode & vbNewLine & "(" & UtilReport.Translation.Translate("lblmillions", translationDictonary) & ")"

        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)


    End Sub

    Private Sub Me_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound

        Dim zControls() As TextBox = {txtProbDamCost}
        UtilReport.TelerikReport.SetItemBackColorByCurrency(sender, zControls, rptProperties)

        zControls = {Me.txtSeverity, txtLengthBI}
        UtilReport.TelerikReport.SetItemBackColorByText(sender, zControls, rptProperties)

        SetWhiteFontIfBackColorIsRed(sender, e)

        SetStatusString(sender)
        BeginReportTranslation(sender)


    End Sub

    Private Sub BeginReportTranslation(sender As Processing.Report)

        'TRANSLATE INTENDED ACTION, RECSTATUS
        Dim zRptDef As RecommendationResponseReportIR = sender.ItemDefinition
        Dim zItems As List(Of ReportItemBase) = UtilReport.TelerikReport.GetReportItems(zRptDef.Items, Nothing)
        Dim zTextBoxItems As List(Of TextBox) = zItems.OfType(Of TextBox)().ToList

        'REMOVE ANY TEXTBOXES WHERE WE ALREADY SET THE LABEL IN THE ITEMDATABINDING EVENT
        Dim zDoNotTranslateControls() As TextBox = {txtTIV}
        For Each zTextBox As TextBox In zDoNotTranslateControls
            zTextBoxItems.Remove(zTextBox)
        Next

        'TRANSLATE THE ITEM VALUES
        UtilReport.TelerikReport.TranslateLabel(sender, zTextBoxItems.ToArray, translationDictonary)
        UtilReport.TelerikReport.TranslateValue(sender, zTextBoxItems.ToArray, translationDictonary)

    End Sub

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return False
    End Function

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
        Dim zKey As String = "lblInfaredRecRespReport"
        Return translationDictonary(zKey)
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

    Private Sub SetWhiteFontIfBackColorIsRed(sender As Object, e As EventArgs)
        Dim zControlNames As New List(Of String)({"txtProbDamCost", "txtSeverity", "txtLengthBI", "uxExpectedCompDate"})
        For Each zControlName As String In zControlNames
            Dim zElements() As Processing.LayoutElement = Telerik.Reporting.Processing.ElementTreeHelper.FindChildByName(sender, zControlName, True)
            For Each zElement As Processing.LayoutElement In zElements
                Dim zProcessingTextBox As Processing.TextBox = zElement
                Dim zBackColor As System.Drawing.Color = zProcessingTextBox.Style.BackgroundColor
                If zBackColor.A = 255 And zBackColor.R = 255 And zBackColor.G = 0 And zBackColor.B = 0 Then
                    zProcessingTextBox.Style.Color = Color.White
                End If
            Next
        Next
    End Sub


End Class