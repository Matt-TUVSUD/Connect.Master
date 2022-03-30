Imports GRC.Connect.Libraries.DataLib.razor

Public Class TestChart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim zRptSrce As New Telerik.Reporting.InstanceReportSource
        'zRptSrce.ReportDocument = New TelerikSample01

        'Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        'Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zRptSrce, Nothing)

        'Dim zTempPath As String = Replace(IO.Path.GetTempFileName, "tmp", "pdf")
        'IO.File.WriteAllBytes(zTempPath, zResult.DocumentBytes)

        'Process.Start(zTempPath)


        Dim zBatchSet As New BatchLib.BatchSet
        zBatchSet.AddFileNo({"2174.0002",
"2174.0003",
"2174.0004",
"2174.0005",
"2174.0006",
"2174.0007",
"2174.0012",
"2174.0014",
"2174.0015",
"2174.0017",
"2174.0020",
"2174.0023",
"2174.0024",
"2174.0027",
"2174.0044",
"2174.0045",
"2174.0046",
"2174.0047"})

        zBatchSet.AddSetItem(232)
        zBatchSet.colFldFileName = "test"
        zBatchSet.colFldCreatedByGsafeUserEmail = 14
        zBatchSet.colFldIsInteractive = True
        zBatchSet.colFldIsMyBatchReport = False
        zBatchSet.Type = BatchSet.BatchType.Report
        zBatchSet.colFldFilePrefix = "2174"
        zBatchSet.SetParameters.FilePrefix = "2174"
        zBatchSet.SetParameters.Currency = TblMetaCurrency.Currencies.JapaneseYen
        zBatchSet.SetParameters.TIVValue = TblMetaTIV.TIVRanges.Greater250Million
        zBatchSet.colFldLOFilterJSON = "{'logic':'and','filters':[{'logic':'or','filters':[{'field':'clientlocno','operator':'eq','value':'Andres'}]}]}"
        zBatchSet.colFldLOSortJSON = "[{'clientlocno':'fileno','dir':'desc'}]"

        Dim zResult As BatchLib.UtilBatchProcessResult = zBatchSet.Execute()

        Dim zTempPath As String = Replace(IO.Path.GetTempFileName, "tmp", "pdf")
        IO.File.WriteAllBytes(zTempPath, zResult.File)

        Process.Start(zTempPath)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
End Class