Imports System.Text.RegularExpressions
Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilReport
    ''' <summary>
    ''' Returns a SQL String with the report join 
    ''' </summary>
    ''' <param name="sqlSelect">Base select statement without WHERE (ex: "Select * FROM table)</param>
    ''' <param name="sqlWhere">The WHERE clause.  Include the WHERE statement</param>
    ''' <param name="joinOnField">The table.fieldname to join on.</param>
    ''' <param name="rptProps">Report Properties</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function BuildSQLString(sqlSelect As String, sqlWhere As String, joinOnField As String, rptProps As IBatchSetReportProperties) As String
        Return " " & Replace(rptProps.ReportSourceJoin.colFldJoinText, "?", joinOnField)
    End Function

    Public Shared Function GetMeasurementAbbreviation(ByVal measurement As TblMetaUnitMeasurement.Measurements, ByVal rptProps As IBatchSetReportProperties) As String
        For Each zRow As rowTblMetaUnitMeasurement In rptProps.Unit.Measurements
            If zRow.colFldId = measurement Then
                If rptProps.Unit.System.System = TblMetaUnitSystem.Systems.English Then
                    Return zRow.colFldAbbreviation
                Else
                    For Each zLookupRow As rowTblMetaUnitMeasurementLookup In rptProps.Unit.Lookups
                        If zLookupRow.colFldEnglish = zRow.colFldAbbreviation Then
                            Return zLookupRow.colFldMetric
                        End If
                    Next
                End If
            End If
        Next
        Return ""
    End Function

    Public Shared Function IsHTML(value As String) As Boolean
        Dim zPattern As String = "<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>"
        Dim zRegex As New Regex(zPattern, RegexOptions.IgnoreCase)
        Return zRegex.IsMatch(value)
    End Function

    Public Shared Function GenerateEmptyPMReport() As Byte()

        Dim rpt As New GRC.Connect.Libraries.ReportLib.PMEmptyReport
        Return UtilReport.GenerateTelerikReport(rpt)

    End Function

    Public Shared Function GeneratePMReport(dataPull As Object) As Byte()

        Dim zRpt As New PMReport
        zRpt.ReportDataSource = dataPull
        zRpt.IsNewProjectReport = False
        zRpt.IsClientReport = False
        Dim zPMReportByte As Byte() = UtilReport.GenerateTelerikReport(zRpt)
        Return zPMReportByte

    End Function

    Public Shared Function GetTopoRecommendationReport(FileNo As String) As Byte()

        Dim rpt As New GRC.Connect.Libraries.ReportLib.TopoRecReport
        rpt.FileNo = FileNo
        Return UtilReport.GenerateTelerikReport(rpt)

    End Function

    Public Shared Function GetTopoRecommendationReport(ImportSurveyId As Integer) As Byte()

        Dim rpt As New GRC.Connect.Libraries.ReportLib.TopoRecReport
        rpt.RefSourceID = ImportSurveyId
        Return UtilReport.GenerateTelerikReport(rpt)

    End Function

    Public Shared Function GenerateTelerikReport(rpt As Telerik.Reporting.Report) As Byte()

        Dim zReport As Telerik.Reporting.Report = rpt
        Dim zReportSource As New Telerik.Reporting.InstanceReportSource()
        zReportSource.ReportDocument = zReport
        Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zReportSource, Nothing)

        Return zResult.DocumentBytes

    End Function


    Public Function GenerateTelerikReport(rpt As IUtilReport) As Byte()

        Dim zReport As Telerik.Reporting.Report = rpt
        Dim zDataReader As SqlClient.SqlDataReader = GetSQLReader(rpt.rptProperties.SQL)

        Dim zDS As New DataSet
        zDS.Load(zDataReader, LoadOption.OverwriteChanges, {"Table1", "Table2", "Table3", "Table4", "Table5", "Table6"})  'Dummy tables are adding for stored procs
        zDataReader.Close()

        If Not TypeOf zReport Is RiskImprovementChart2 Then  'THE RISK IMPROVEMENT CHART USES A STORED PROCEDURE WITH MULTIPLE TABLES
            zReport.DataSource = zDS.Tables(0)
        Else
            DirectCast(zReport, RiskImprovementChart2).data = zDS.Tables(0)
        End If

        Dim zReportSource As New Telerik.Reporting.InstanceReportSource()
        zReportSource.ReportDocument = zReport

        UtilReport.TelerikReport.SetReportCurrencyParameter(zReportSource.ReportDocument, rpt.rptProperties.Currency.colFldId)

        Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zReportSource, Nothing)

        Return zResult.DocumentBytes

    End Function

    Public Function GenerateActiveReport(rpt As IUtilReport) As Byte()

        Dim zReport As GrapeCity.ActiveReports.SectionReport = rpt
        Dim zDataReader As SqlClient.SqlDataReader = GetSQLReader(rpt.rptProperties.SQL)

        Dim zDT As New DataTable
        zDT.Load(zDataReader)
        zDataReader.Close()

        zReport.DataSource = zDT
        zReport.Run()
        zDataReader.Close()

        Dim zPDFExporter As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport()
        Dim zMemStream As New IO.MemoryStream()
        zPDFExporter.Export(zReport.Document, zMemStream)

        Return zMemStream.ToArray

    End Function

    Public Function CreateReportObject(rptType As Type) As IUtilReport
        Try
            Dim zRptObject As Object = Activator.CreateInstance(rptType)
            Return zRptObject
        Catch ex As Exception
            Dim zStackList() As String = Split(ex.GetBaseException.StackTrace, vbNewLine)
            Diagnostics.EventLog.WriteEntry("Application", GRC.Resources.ExceptionUtility.ExtractMessages(ex))
            Throw New ArgumentException("Exception occurred while creating report from type [" & rptType.Name & "]. " & ex.GetBaseException.Message & vbNewLine & vbNewLine & zStackList(0).ToString)
        End Try
    End Function

    Private Function GetSQLReader(sql As String) As SqlClient.SqlDataReader
        Dim zCon As New SqlClient.SqlConnection(UtilSQLServer.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand(sql, zCon)
        zCmd.CommandTimeout = 0
        zCon.Open()
        Return zCmd.ExecuteReader()
    End Function

    Public Shared Function GetReportType(Name As String) As Type
        Dim zUtil As New UtilReport
        Dim zAssembly As Reflection.Assembly = Reflection.Assembly.GetAssembly(zUtil.GetType)
        Dim zType As Type = zAssembly.GetType(Name)
        If Not IsNothing(zType) Then
            Return zType
        Else
            Return Nothing
        End If
    End Function

End Class
