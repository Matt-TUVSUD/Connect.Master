Imports Telerik.Reporting

Partial Class UtilReport
    Partial Class TelerikReport

        Public Shared Sub SetTitle(header As Processing.HtmlTextBox)
            Dim zIReport As IUtilReport = DirectCast(header.Report.ItemDefinition, IUtilReport)
            Dim zITelerik As ITelerikReport = DirectCast(header.Report.ItemDefinition, ITelerikReport)
            Dim zObject As Object = header.DataObject("FileNo")

            Dim zSb As New System.Text.StringBuilder
            With zSb
                Dim zPractice As String = System.Web.HttpUtility.HtmlEncode(zIReport.rptProperties.Practice.colFldReportDisplayTitle)
                If zITelerik.AppendPracticeToTitle = False Then zPractice = ""

                If zITelerik.IsStandardHeader And header.Name = "txtStandardHeader" Then .AppendLine("<span style='color:#C6D1DE; font-weight:bold; font-style:italic; font-size:14pt;'>" & System.Web.HttpUtility.HtmlEncode(zIReport.rptProperties.ClientName) & "</span>")

                .AppendLine("<span style='color:black; font-weight:bold; font-size:12pt;'>" & zPractice & " " & System.Web.HttpUtility.HtmlEncode(zITelerik.ReportTitle) & "</span>")
                If UtilReport.IsHTML(zITelerik.ReportSubTitle) Then
                    If zITelerik.ReportSubTitle <> "" Then .AppendLine(zITelerik.ReportSubTitle)
                Else
                    If zITelerik.ReportSubTitle <> "" Then .AppendLine("<span style='color:black; font-weight:bold; font-size:10pt;'>" & zITelerik.ReportSubTitle & "</span>")
                End If

                If UtilReport.IsHTML(zITelerik.ReportSubSubTitle) Then
                    If zITelerik.ReportSubSubTitle <> "" Then .AppendLine(zITelerik.ReportSubSubTitle)
                Else
                    If zITelerik.ReportSubSubTitle <> "" Then .AppendLine("<span style='color:black; font-size:9pt;'>" & zITelerik.ReportSubSubTitle & "</span>")
                End If

                Dim zHTML As String = Replace(zSb.ToString, vbNewLine, "<br>")
                'header.Value = System.Net.WebUtility.HtmlDecode(zHTML)
                header.Value = zHTML

            End With

            'HIDE UNUSED HEADER
            If header.Name = "txtAlternateHeader" And zITelerik.IsStandardHeader = True Then
                Dim zObj As Object = header.ParentElement
                zObj.Visible = False
            ElseIf header.Name = "txtStandardHeader" And zITelerik.IsStandardHeader = False Then
                header.Visible = False
            End If
        End Sub



        Public Shared Sub SetFilterText(rpt As Processing.Report, rptProps As IBatchSetReportProperties)
            Dim zBaseReport As ITelerikBaseReport = rpt.ItemDefinition
            '            zBaseReport.FilterHTMLTextBox.Value = "<strong>myPreferenceFilter:</strong>&nbsp;" & rptProps.MyFilterString & "<br><strong>Filter:</strong>&nbsp;" & rptProps.FilterString
            zBaseReport.FilterHTMLTextBox.Value = "<strong>Filter:</strong>&nbsp;" & System.Web.HttpUtility.HtmlEncode(rptProps.FilterString)
            Dim zFilterSection As GroupSection = zBaseReport.FilterHTMLTextBox.Parent
            '            If rptProps.MyFilterString <> "" Or rptProps.FilterString <> "" Then zFilterSection.Visible = True Else zFilterSection.Visible = False
            If rptProps.FilterString <> "" Then zFilterSection.Visible = True Else zFilterSection.Visible = False

        End Sub

        Public Shared Sub SetFooterTexts(rpt As Processing.Report, rptProps As IBatchSetReportProperties)
            SetSortText(rpt, rptProps)
            SetDisclaimerText(rpt, rptProps)
            SetPageText(rpt, rptProps)
        End Sub

        Public Shared Sub SetPageText(rpt As Processing.Report, rptProps As IBatchSetReportProperties)
            Dim zBaseReport As ITelerikBaseReport = rpt.ItemDefinition
            Dim zPageString As String = "Page"
            Dim zOfString As String = " of "
            zBaseReport.PageCounterTextBox.Value = zPageString & "{PageNumber}" & zOfString & "{PageCount}"
        End Sub

        Public Shared Sub SetSortText(rpt As Processing.Report, rptProps As IBatchSetReportProperties)
            Dim zBaseReport As ITelerikBaseReport = rpt.ItemDefinition
            zBaseReport.SortHTMLTextBox.Value = "<strong>Sort:</strong>&nbsp;" & rptProps.SortString & ""

            If rptProps.SortString <> "" Then zBaseReport.SortHTMLTextBox.Visible = True Else zBaseReport.SortHTMLTextBox.Visible = False
        End Sub

        Public Shared Sub SetDisclaimerText(rpt As Processing.Report, rptProps As IBatchSetReportProperties)
            Dim zBaseReport As ITelerikBaseReport = rpt.ItemDefinition

            If zBaseReport.DisclaimerHTMLTextBox.Value <> "" Then
                zBaseReport.DisclaimerHTMLTextBox.Value = zBaseReport.DisclaimerHTMLTextBox.Value & "&nbsp;&nbsp;" & rptProps.Disclaimer
            Else
                zBaseReport.DisclaimerHTMLTextBox.Value = rptProps.Disclaimer
            End If

            If rptProps.Disclaimer <> "" Then zBaseReport.DisclaimerHTMLTextBox.Visible = True Else zBaseReport.DisclaimerHTMLTextBox.Visible = False

        End Sub

        Public Shared Sub SetCurrencyFormat(ByRef controls() As TextBox, rptProps As IBatchSetReportProperties)
            Dim symbol As String = rptProps.Currency.colFldSymbol
            Dim zFormat As String = "{0:" & symbol & "##,##0}"
            For Each zTextBox As TextBox In controls
                zTextBox.Format = zFormat
            Next
        End Sub

        Public Shared Sub SetCurrencyFormat(ByRef controls() As TextBox, rptProps As IBatchSetReportProperties, format As String)
            Dim symbol As String = rptProps.Currency.colFldSymbol
            Dim zFormat As String = "{0:" & symbol & format & "}"
            For Each zTextBox As TextBox In controls
                zTextBox.Format = zFormat
            Next
        End Sub

        Public Shared Sub SetReportCurrencyParameter(ByRef rpt As Report, currencyId As Integer)
            If rpt.ReportParameters("ReportCurrency") IsNot Nothing Then
                rpt.ReportParameters("ReportCurrency").Value = currencyId
            End If
        End Sub

        Public Shared Sub FixBaseGroups(ByRef rpt As Report)
            Dim zList As New List(Of Group)
            rpt.Groups.ToList.ForEach(Sub(x) zList.Add(IIf(zList.Contains(x), Nothing, x)))
            rpt.Groups.Clear()
            rpt.Groups.AddRange(zList.FindAll(Function(x) x IsNot Nothing).ToArray)
        End Sub

        Public Shared Sub SetItemBackColorByExposure(rpt As Processing.Report, controls() As TextBox, rptProps As IBatchSetReportProperties)
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            zProcessingTextBox.Style.BackgroundColor = UtilReport.Color.GetColorByExposure(rptProps, zProcessingTextBox.Value)
                            If zProcessingTextBox.Style.BackgroundColor.ToKnownColor = System.Drawing.KnownColor.Red Then
                                zProcessingTextBox.Style.Color = System.Drawing.Color.White
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub SetItemBackColorByRating(rpt As Processing.Report, controls() As GrcTelerikRatingCategoryTexBox, rptProps As IBatchSetReportProperties)
            For Each zItem As GrcTelerikRatingCategoryTexBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            If IsNumeric(zValue) Then
                                zProcessingTextBox.Style.BackgroundColor = UtilReport.Color.GetColorByRating(rptProps, zItem.RatingCategory, zProcessingTextBox.Value)
                                If zProcessingTextBox.Style.BackgroundColor.ToKnownColor = System.Drawing.KnownColor.Red Then
                                    zProcessingTextBox.Style.Color = System.Drawing.Color.White
                                End If
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub SetItemBackColorByCurrency(rpt As Processing.Report, controls() As TextBox, rptProps As IBatchSetReportProperties)
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            If IsNumeric(zValue) Then
                                zProcessingTextBox.Style.BackgroundColor = UtilReport.Color.GetColorByCurrency(rptProps, zProcessingTextBox.Value)
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub SetItemBackColorByRiskRating(rpt As Processing.Report, controls() As TextBox, rptProps As IBatchSetReportProperties)
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            zProcessingTextBox.Style.BackgroundColor = UtilReport.Color.GetColorByRiskRating(rptProps, zValue)
                            If zProcessingTextBox.Style.BackgroundColor.ToKnownColor = System.Drawing.KnownColor.Red Then

                                zProcessingTextBox.Style.Color = System.Drawing.Color.White
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub SetItemBackColorByRiskScore(rpt As Processing.Report, controls() As TextBox, rptProps As IBatchSetReportProperties)
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            zProcessingTextBox.Style.BackgroundColor = UtilReport.Color.GetColorByRiskScore(rptProps, zValue)
                            If zProcessingTextBox.Style.BackgroundColor.ToKnownColor = System.Drawing.KnownColor.Red Then
                                zProcessingTextBox.Style.Color = System.Drawing.Color.White
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub SetItemBackColorByText(rpt As Processing.Report, controls() As TextBox, rptProps As IBatchSetReportProperties)
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            zProcessingTextBox.Style.BackgroundColor = UtilReport.Color.GetColorByText(rptProps, zProcessingTextBox.Value)
                            If zProcessingTextBox.Style.BackgroundColor.ToKnownColor = System.Drawing.KnownColor.Red Then
                                zProcessingTextBox.Style.Color = System.Drawing.Color.White
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub TranslateValue(rpt As Processing.Report, controls() As TextBox, translationDict As Dictionary(Of String, String))
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Value
                        If zValue IsNot Nothing Then
                            Dim zTranslatedValue As String = UtilReport.Translation.Translate(zValue, translationDict)
                            If Not IsNothing(zTranslatedValue) Then
                                zProcessingTextBox.Value = zTranslatedValue
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Sub TranslateLabel(rpt As Processing.Report, controls() As TextBox, translationDict As Dictionary(Of String, String))
            For Each zItem As TextBox In controls
                Dim zElements() As Processing.LayoutElement = FindLayoutItems(rpt, zItem.Name)
                For Each zElement As Processing.LayoutElement In zElements
                    If TypeOf zElement Is Processing.TextBox Then
                        Dim zProcessingTextBox As Processing.TextBox = zElement
                        Dim zValue As Object = zProcessingTextBox.Name
                        If zValue IsNot Nothing Then
                            Dim zTranslatedValue As String = UtilReport.Translation.Translate(zValue, translationDict)
                            If Not IsNothing(zTranslatedValue) Then
                                zProcessingTextBox.Value = zTranslatedValue
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Public Shared Function FindLayoutItems(rpt As Processing.Report, itemName As String) As Processing.LayoutElement()
            Dim zLayoutElement() As Processing.LayoutElement = Processing.ElementTreeHelper.FindChildByName(rpt, itemName, True)
            Return zLayoutElement
        End Function

        Public Shared Function GetReportItems(itemCollection As Telerik.Reporting.ReportItemBase.ItemCollection, Optional ByRef pList As List(Of ReportItemBase) = Nothing) As List(Of ReportItemBase)
            Dim zList As List(Of ReportItemBase) = pList
            If zList Is Nothing Then zList = New List(Of ReportItemBase)

            For Each zItem As ReportItemBase In itemCollection
                zList.Add(zItem)
                If zItem.Items.Count > 0 Then
                    GetReportItems(zItem.Items, zList)
                End If
            Next

            Return zList

        End Function


    End Class

End Class

