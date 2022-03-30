

Public Class CheckChartBatchPDF
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnDownloadPDF_Click(sender As Object, e As EventArgs) Handles btnDownloadPDF.Click
        Try
            lblMessage.Text = "Loading..."
            Dim zHTML As String
            Dim zURL As String = txtURL.Text & "?sid=" & txtGSafe.Text
            Dim zBrowser As New UtilWebBrowser
            zHTML = zBrowser.GetWebHTMLString(zURL)
            DeliverPDF(zHTML)
            '     zBrowser.WebBrowserDispose()
        Catch ex As Exception
            lblMessage.Text = ex.Message

        End Try

    End Sub

    Public Sub DeliverPDF(ByRef pDocument As String)
        Try

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

            ' DELIVER TO BROWSER
            Context.Response.Clear()
            Context.Response.ClearContent()
            Context.Response.ClearHeaders()
            Context.Response.AddHeader("Content-Disposition", "attachment;filename=" & "TempFileName.pdf")
            Context.Response.ContentType = "application/pdf"
            Context.Response.BinaryWrite(zResults)
            Context.Response.Flush()

            lblMessage.Text = "Your PDF is ready for download."

        Catch ex As Exception
            ' DELIVER ERROR TO BROWSER
            Dim zMessage = ex.Message
            lblMessage.Text = zMessage

        End Try
    End Sub
End Class