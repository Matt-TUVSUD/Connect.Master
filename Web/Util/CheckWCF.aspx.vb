Public Class CheckWCF
    Inherits System.Web.UI.Page

    Protected Sub cmdWCFHTTPTest_Click(sender As Object, e As System.EventArgs) Handles cmdWCFHTTPTest.Click
        Dim zTester As New WCFTester

        zTester.WCFBaseURL = Replace(Request.Url.ToString.ToLower, "/Util/CheckWCF.aspx".ToLower, "")
        zTester.WCFPort = ""
        zTester.WCFServiceEndpoint = txtServiceEndPoint.Text & "/"
        zTester.WCFServiceAction = txtServiceAction.Text
        zTester.WCFDataParms = Chr(34) & txtParm.Text & Chr(34)
        zTester.TestHarness1()

        txtLog.Text = zTester.WCFTextLog
        txtJSONRaw.Text = zTester.WCFResponse

        Try
            'Attempt to convert the response for formatted JSON
            txtJSONFormatted.Text = zTester.WCFResponseFormatted
        Catch ex As Exception
            'Must not be JSON code
        End Try
    End Sub

    Protected Sub cmdWCFDirectTest_Click(sender As Object, e As System.EventArgs) Handles cmdWCFDirectTest.Click

        Dim zTester As New WCFTester

        zTester.TestHarness2()

        txtLog.Text = zTester.WCFTextLog

        txtJSONFormatted.Text = ""

        txtJSONRaw.Text = "Response.Collection.Count: " & zTester.WCFResponse

    End Sub
End Class