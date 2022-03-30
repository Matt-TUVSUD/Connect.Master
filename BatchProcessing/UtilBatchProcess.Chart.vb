Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilBatchProcess
    Partial Class Report

        Const FireBenchmarkTotalFacilityScoreChartReportID = 227
        Const BMBenchmarkTotalFacilityScoreChartReportID = 228

        Public Function GenerateChart(pSetItem As BatchSetItem) As Byte()

            'TOTAL FACILITY SCORE CHART HAS SPECIAL FUNCTIONS TO  HANDLE PAGING
            If IsTotalFacilityScoreChartReport(pSetItem) Then Return GenerateTotalFacilityChart(pSetItem)

            Dim zURLs As New List(Of String)
            Dim zChartURL As String = ""
            Dim zList As New List(Of Byte())

            UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Generating Chart: " & pSetItem.MetaObject.colfldName)
            zURLs.Add(AssembleParentURL(pSetItem))
            zURLs.AddRange(AssembleChildURLs(pSetItem))
            zURLs.ForEach(Sub(x) UtilBatchProcess.WriteLog(pSetItem.colFldSetId, x))

            Try
                For Each zChartURL In zURLs
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Processing Chart (" & zURLs.IndexOf(zChartURL) + 1 & "/" & zURLs.Count & ") " & zChartURL)
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Start GeneratedChartHtml")
                    Dim zChartHTML As String = GenerateChartHtml(zChartURL)
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Finish GeneratedChartHtml")
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Start GenerateChartByte")
                    Dim zChartByte As Byte() = GenerateChartByte(zChartHTML)
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Finish GenerateChartByte")
                    zList.Add(zChartByte)
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Processed Chart [" & zChartByte.Length & " bytes]")
                Next
                UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Chart Generated Successfully")
                Return CreatePDF(zList)

            Catch ex As Exception
                UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Exception: " & ex.Message)
                ex.Data.Add("URL ", zChartURL)
                Throw ex
            End Try

        End Function

        Private Function AssembleParentURL(pSetItem As BatchSetItem) As String
            Dim zNavLinkChartURL As String = pSetItem.ExtendedProperty.ChartInfo.ChartNavLink.colNavUrl
            Dim zChartURL As String = Replace(zNavLinkChartURL, UtilNav.NavLinkPlaceholder, UtilSetting.GetAppHomeURL, 1, -1, CompareMethod.Text)
            zChartURL = zChartURL & "&chartId=" & pSetItem.ExtendedProperty.ChartInfo.ChartNavLink.colNavChartId & "&batchSetId=" & pSetItem.colFldSetId
            Return zChartURL
        End Function

        Private Function AssembleChildURLs(pSetItem As BatchSetItem) As String()
            Dim zList As New List(Of String)
            If Not IsNothing(pSetItem.ExtendedProperty.ChartInfo.ChartChildInfo) Then
                For Each zChildChart As rowVwNavLinkChartDrillDownInfo In pSetItem.ExtendedProperty.ChartInfo.ChartChildInfo
                    Dim zChartURL As String = UtilSetting.GetAppHomeURL() & zChildChart.colFldUrlBase & "?batchSetId=" & pSetItem.colFldSetId & zChildChart.colFldUrlParms
                    zList.Add(zChartURL)
                Next
            End If
            Return zList.ToArray
        End Function

        Public Function GenerateChartHtml(pUrl As String) As String
            Dim zHTML As String
            Dim zBrowser As New UtilWebBrowser
            zHTML = zBrowser.GetWebHTMLString(pUrl)
            Return zHTML
        End Function

        Public Function GenerateChartByte(pHtml As String) As Byte()
            Dim zByte() As Byte = Nothing
            zByte = CreateChartPDF(pHtml)
            Return zByte
        End Function

#Region "TOTAL FACILITY SCORE CHART FUNCTIONS"

        Public Function GenerateTotalFacilityChart(pSetItem As BatchSetItem) As Byte()

            Dim zParentURL As String = AssembleParentURL(pSetItem)
            Dim zInitialHTML As String = GenerateChartHtml(zParentURL)
            Dim zRecordCount As Integer = ParseTotalFacilityRecordCount(zInitialHTML)
            Dim zChartURLs As List(Of String) = AssembleTotalFacilityPageURLs(zParentURL, zRecordCount)
            Dim zByteList As New List(Of Byte())
            Dim zChartURL As String = ""

            UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Generating Chart: " & pSetItem.MetaObject.colfldName)
            zChartURLs.ForEach(Sub(x) UtilBatchProcess.WriteLog(pSetItem.colFldSetId, x))

            Try
                For Each zChartURL In zChartURLs
                    Dim zChartHTML As String = GenerateChartHtml(zChartURL)
                    Dim zChartByte As Byte() = GenerateChartByte(zChartHTML)
                    zByteList.Add(zChartByte)
                    UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Chart (" & zChartURLs.IndexOf(zChartURL) + 1 & "/" & zChartURLs.Count & ") [" & zChartByte.Length & " bytes]")
                Next
                UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Chart Generated Successfully")
                Return CreatePDF(zByteList)

            Catch ex As Exception
                ex.Data.Add("URL ", zChartURL)
                Throw ex
            End Try

        End Function

        Public Function ParseTotalFacilityRecordCount(pHtml As String) As Integer

            Dim zRegex As String = "(<section id=" & Chr(34) & "TotalCount" & Chr(34) & ").+<\/section>"
            Dim zMatch As Text.RegularExpressions.Match = Text.RegularExpressions.Regex.Match(pHtml, zRegex, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim zSB As New Text.StringBuilder
            Dim zChars() As Char = zMatch.Value.ToCharArray
            For Each zChar As Char In zChars
                If IsNumeric(zChar.ToString) Then zSB.Append(zChar.ToString)
            Next
            If zSB.Length = 0 Then Return 0 Else Return CInt(zSB.ToString)

        End Function

        Public Function AssembleTotalFacilityPageURLs(pParentURL As String, pTotalCount As Integer) As List(Of String)
            Dim zURLList As New List(Of String)
            zURLList.Add(pParentURL & "&pageId=1")

            If pTotalCount > 10 Then
                Dim zCurrentPage As Integer = 2
                Dim zTotalPageQuotient As Single = pTotalCount / 10
                Dim zTotalPages As Integer = CInt(zTotalPageQuotient)
                If zTotalPageQuotient > zTotalPages Then zTotalPages += 1

                Do
                    zURLList.Add(pParentURL & "&pageId=" & zCurrentPage)
                    zCurrentPage += 1
                Loop Until zCurrentPage > zTotalPages

            End If

            Return zURLList
        End Function

        Public ReadOnly Property IsTotalFacilityScoreChartReport(pSetItem As BatchSetItem) As Boolean
            Get
                If pSetItem.colFldMetaObjectId.Value = FireBenchmarkTotalFacilityScoreChartReportID Or pSetItem.colFldMetaObjectId.Value = BMBenchmarkTotalFacilityScoreChartReportID Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

#End Region

        Private Function CreateChartPDF(ByRef pDocument As String) As Byte()

            Dim zResults As Byte() = OpenHtmlToPdf.Pdf.
                    From(pDocument).
                    WithGlobalSetting("web.enableIntelligentShrinking", False).
                    WithGlobalSetting("orientation", "landscape").
                    WithGlobalSetting("size.paperSize", "letter").
                    WithGlobalSetting("margin.top", "0.15in").
                    WithGlobalSetting("margin.bottom", "0.15in").
                    WithGlobalSetting("margin.right", "0.15in").
                    WithGlobalSetting("margin.left", "0.15in").
                    WithGlobalSetting("dpi", "100").
                    WithGlobalSetting("useCompression", "false").
                    WithGlobalSetting("imageQuality", "99").
                    WithObjectSetting("web.defaultEncoding", "utf-8").
                    WithObjectSetting("header.fontName", "Arial").
                    WithObjectSetting("load.zoomFactor", "1.0").
            Content()

            Return zResults

        End Function

        Private Function CreatePDF(pFiles As List(Of Byte())) As Byte()
            Dim zReturnDoc As New WebSupergoo.ABCpdf10.Doc
            Dim zTempDoc As WebSupergoo.ABCpdf10.Doc
            For Each zByte As Byte() In pFiles
                zTempDoc = New WebSupergoo.ABCpdf10.Doc()
                zTempDoc.Read(zByte)
                zReturnDoc.Append(zTempDoc)
            Next

            Return zReturnDoc.GetData()
        End Function

    End Class
End Class
