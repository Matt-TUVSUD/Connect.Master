
Imports GRC.Connect.Core.UtilReporting
Imports EDA.Impairments.ReportLibrary

Public Class ReportProccessor

     Private _ReturnType As ReturnType
     Public _CustomAccess As String = ""
     Public _Division As String = ""
     Public _Currency As String = ""
     Public _Unit As String = ""
     Public _DateFrom As String = ""
     Public _DateTo As String = ""
     Public _Hazard As String = ""
     Public _Country As String = ""
     Public _Tiv As String = ""
    Public _Status As String = ""
    Private _ReportConnection As EDA.Impairments.ReportLibrary.ReportConnection
    Private _User As String = "AppUserCldbWeb"
    Private _Pwd As String = "$Cl13nt$"

     Public Sub New(ByVal pReturnType As ReturnType)
        _ReturnType = pReturnType
        If Core.UtilSystemParms.InDevMode Then _ReportConnection = New ReportConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ImpairmentDev").ConnectionString)
        If Core.UtilSystemParms.InTestMode Then _ReportConnection = New ReportConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ImpairmentTest").ConnectionString)
        If Core.UtilSystemParms.InLiveMode Then _ReportConnection = New ReportConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ImpairmentLive").ConnectionString)

    End Sub

    Public Function RunFromEngine(ByVal pJobId As Integer, ByVal pIsBatchReport As Boolean) As Object

        Dim zRe As New Core.UtilReportEngine
        Dim zFilter As Filter
        Dim zMeta As New ReportMeta

        Try
            'Instantiate the Report Engine Object
            zRe.LoadJob(pJobId)


            'Get Filter Values
            zFilter = New Filter(zRe.FilePrefix)
            With zFilter
                .Tiv = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.TIV)
                .CustomAccess = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.CustomAccess)
                .DateFrom = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.DateFrom)
                .DateTo = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.DateTo)
                .Division = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.Division)
                .Hazard = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.Hazard)
                .Country = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.Country)
                .Status = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.Status)
                .BatchFilter = zRe.FilterValue(zRe.RptSetId, ReportFilter.BatchFilter)
            End With

            'Set Properties
            Dim zProp As New ReportProccessor.ProcessingProperties
            With zProp
                .Currency = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.ConvertCurrency)
                .Unit = zRe.FilterValue(zRe.RptSetId, Core.UtilReporting.ReportFilter.ConvertUnits)
            End With


            'Get the Meta for this report
            zMeta = ReportMeta.FindMetaByReport(zRe.RptCode)

            If Not IsNothing(zMeta) Then
                'Get the Query for the report
                Dim zQry As New ReportQuery
                Dim zTable As New DataTable
                Dim zEsQry As EntitySpaces.Interfaces.esDynamicQuery = zMeta.Query

                If zEsQry IsNot Nothing Then
                    ReportQuery.JoinReportFileNo(zEsQry, zRe)
                    ReportQuery.ApplyFilter(zEsQry, zFilter, zRe)
                    ReportQuery.ApplyDefaultSort(zEsQry, zRe.RptCode)

                    'Get DataTable
                    zTable = zEsQry.LoadDataTable
                    If Core.UtilReporting.GetReportStyle(zRe.RptCode) = ReportStyle.Report Then
                        ReportQuery.ApplySetting(zTable, zProp, zRe.FilePrefix)
                    End If
                End If

                'Build Filter
                zTable.ExtendedProperties("Filter") = zFilter.BuildString
                zTable.ExtendedProperties("EsQuery") = zEsQry

                'Instantiate the report
                Dim zRpt As BaseReport = Activator.CreateInstance(zMeta.ReportType, {pJobId})

                'Apply DataSource to Report
                zRpt.DataSource = zTable
                zRpt.IsBatchReport = pIsBatchReport

                Return MyReport(zRpt)
            Else
                Dim zRpt As Object = RunFromLibraryViaEngine(zRe, zFilter.BuildString, zRe.RptCode)
                If IsNothing(zRpt) Then
                    Throw New Exception("System could not process the selected report via report engine.")
                Else
                    Return MyReport(zRpt)
                End If
            End If

        Catch ex As Exception
            ex.Data.Add("Report", zRe.RptCode.ToString)
            ex.Data.Add("FilePrefix", zRe.FilePrefix)
            ex.Data.Add("IsBatch", pIsBatchReport.ToString)
            ex.Data.Add("UserId", zRe.UserId)
            ex.Data.Add("RptStyle", zRe.RptStyle.ToString)
            Throw
        End Try

    End Function

     Public Function RunFromGrid(ByVal pGuid As String, ByVal pReport As Core.UtilReporting.Reports, ByVal pProperties As ReportProccessor.ProcessingProperties) As Object

        Dim zMeta As New ReportMeta

        Try

            'Get the Meta for this report
            zMeta = ReportMeta.FindMetaByReport(pReport)

  
                'Get the Query for the report
                Dim zQry As New ReportQuery
                Dim zEsQry As EntitySpaces.Interfaces.esDynamicQuery = zMeta.Query
                ReportQuery.JoinSafeFileNo(zEsQry, pGuid)

                'Apply filter
                If pProperties.FilterSqlString <> "" Then
                    ReportQuery.ApplyAlias(pProperties.FilterSqlString, pReport)
                    zEsQry.Where("<" + pProperties.FilterSqlString.ToString.Replace("#", "'").Replace("[", "Base.[") + ">")
                End If

                'Apply Sort
                Dim zUseMetaSortString As Boolean = False
                If pProperties.SortSqlString <> "" Then
                    ReportQuery.ApplyAlias(pProperties.SortSqlString, pReport)
                    ReportQuery.ApplySort(zEsQry, pProperties.SortSqlString)
                Else
                    ReportQuery.ApplyDefaultSort(zEsQry, pReport)
                    zUseMetaSortString = True
                End If

                'Get DataTable
                Dim zTable As DataTable = zEsQry.LoadDataTable
            ReportQuery.ApplySetting(zTable, pProperties, Core.UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.FilePreFix))

                'Instantiate the report
                Dim zRpt As BaseReport = Activator.CreateInstance(zMeta.ReportType, {pGuid, pReport})

                'Set DataTable Extended Properties
                zTable.ExtendedProperties("Filter") = pProperties.FilterString
                zTable.ExtendedProperties("EsQuery") = zEsQry
                If zUseMetaSortString Then zTable.ExtendedProperties("Sort") = zMeta.DefaultSort Else zTable.ExtendedProperties("Sort") = "(Sort Order: " & pProperties.SortString & ")"

                zRpt.DataSource = zTable
                zRpt.IsBatchReport = False

                Return MyReport(zRpt)
  

        Catch ex As Exception
            ex.Data.Add("Report", pReport.ToString)
            ex.Data.Add("FilePrefix", Core.UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.FilePreFix))
            ex.Data.Add("IsBatch", "N/A")
            ex.Data.Add("UserId", Core.UtilGSafe.GetId(pGuid))
            Throw
        End Try



     End Function

    Public Function RunFromLibrary(ByVal pDataSource As DataTable, ByVal pGuid As String, ByVal pRptCode As Core.UtilReporting.Reports, ByVal pProcessingProperties As ReportProccessor.ProcessingProperties) As Object
        Select Case pRptCode

            'EDA Impairment Reporting Library
            Case Reports.FireImpairmentOverviewReport, Reports.FireImpairmentSummaryReport
                Dim zRptProperties As New EDA.Impairments.ReportLibrary.ReportProperties(_ReportConnection, pDataSource, Core.UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.FilePreFix))

                With zRptProperties
                    .Filter = pProcessingProperties.FilterString
                    If Not IsNothing(pProcessingProperties.FilterSqlString) Then
                        .FilterSQL = pProcessingProperties.FilterSqlString
                    End If
                    .ClientName = Core.UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.ClientName)
                    .LanguageID = EDA.Impairments.ReportLibrary.ReportProperties.Language.English
                    .TimezoneID = EDA.Impairments.ReportLibrary.ReportProperties.Timezone.UTC
                End With

                Dim zRptProcessor As EDA.Impairments.ReportLibrary.ReportProcessor = DirectCast(CreateReportingLibraryObject(ReportingLibrary.Impairments), EDA.Impairments.ReportLibrary.ReportProcessor)
                If pRptCode = Reports.FireImpairmentOverviewReport Then
                    Return zRptProcessor.RunOverviewReport(zRptProperties)
                ElseIf pRptCode = Reports.FireImpairmentSummaryReport Then
                    Return zRptProcessor.RunSummaryReport(zRptProperties)
                End If

            Case Else
                Throw New Exception("System could not find " & pRptCode.ToString & " to run from the library.")

        End Select

        Return Nothing

    End Function


    Private Function RunFromLibraryViaEngine(ByVal pRE As Core.UtilReportEngine, ByVal pFilterString As String, ByVal pRptCode As Core.UtilReporting.Reports) As Object

        Select Case pRptCode

            'EDA Impairment Reporting Library
            Case Reports.FireImpairmentOverviewReport, Reports.FireImpairmentSummaryReport
                Dim zRptProperties As New EDA.Impairments.ReportLibrary.ReportProperties(_ReportConnection, Nothing, pRE.FilePrefix)

                With zRptProperties
                    .FileNos = Core.BusinessObjects.ReportFileNo.LoadByRptSetID(pRE.RptSetId)
                    .FileNosColumnIdx = 0
                    .Filter = pFilterString
                    .ClientName = pRE.ClientName
                    .LanguageID = EDA.Impairments.ReportLibrary.ReportProperties.Language.English
                    .TimezoneID = EDA.Impairments.ReportLibrary.ReportProperties.Timezone.UTC
                End With

                Dim zRptProcessor As EDA.Impairments.ReportLibrary.ReportProcessor = CreateReportingLibraryObject(ReportingLibrary.Impairments)
                If pRptCode = Reports.FireImpairmentOverviewReport Then
                    Return zRptProcessor.RunOverviewReport(zRptProperties)
                ElseIf pRptCode = Reports.FireImpairmentSummaryReport Then
                    Return zRptProcessor.RunSummaryReport(zRptProperties)
                End If
        End Select

        Return Nothing

    End Function

    Private Function CreateReportingLibraryObject(ByVal pLibrary As ReportingLibrary) As Object
        Select Case pLibrary
            Case ReportingLibrary.Impairments
                If Core.UtilSystemParms.InDevMode Then Return New EDA.Impairments.ReportLibrary.ReportProcessor()
                If Core.UtilSystemParms.InTestMode Then Return New EDA.Impairments.ReportLibrary.ReportProcessor()
                If Core.UtilSystemParms.InLiveMode Then Return New EDA.Impairments.ReportLibrary.ReportProcessor()

        End Select

        Return Nothing

    End Function


    'Public Function CreateFileNoFilterInfo(ByVal pGuid As String, ByVal pProperties As ReportProccessor.ProcessingProperties) As EDA.Impairments.ReportLibrary.ReportProperties

    '    Dim zSafeFileNo As New Core.BusinessObjects.GSafeFileNoQuery("sf")
    '    Dim zSafeHeader As New Core.BusinessObjects.GSafeHeaderQuery("sh")
    '    zSafeFileNo.Select(zSafeFileNo.FileNo)
    '    zSafeFileNo.InnerJoin(zSafeHeader).On(zSafeFileNo.GSafeId = zSafeHeader.GSafeId)
    '    zSafeFileNo.Where(zSafeHeader.GSafeGUID = pGuid)

    '    Dim zFileNoTable As DataTable = zSafeFileNo.LoadDataTable

    '    If IsNothing(zFileNoTable) Then
    '        Return Nothing
    '    Else
    '        Dim zFileNoInfo As New EDA.Impairments.ReportLibrary.ReportProperties(Nothing, zFileNoTable, 0, pProperties.FilterString, pProperties.FilterSqlString, "", "")
    '        Return zFileNoInfo
    '    End If

    'End Function

    'Public Function CreateFileNoFilterInfo(ByVal pRE As Core.UtilReportEngine) As EDA.Impairments.ReportLibrary.ReportProperties
    '    Dim zRptFileNo As New Core.BusinessObjects.ReportFileNoQuery("rpt")
    '    zRptFileNo.Select(zRptFileNo.FileNo)
    '    zRptFileNo.Where(zRptFileNo.RptSetId = pRE.RptSetId)

    '    Dim zFileNoTable As DataTable = zRptFileNo.LoadDataTable

    '    If IsNothing(zFileNoTable) Then
    '        Return Nothing
    '    Else
    '        Dim zFileNoInfo As New EDA.Impairments.ReportLibrary.ReportProperties(Nothing, zFileNoTable, 0, "", "", "", "")
    '        Return zFileNoInfo
    '    End If

    'End Function

    Public Function MyReport(ByVal pReport As Object) As Object
        If TypeOf pReport Is Telerik.Reporting.Report Then
            If _ReturnType <> ReturnType.ByteArray Then
                Return pReport
            Else
                Return ConvertToByte(pReport)
            End If
        End If

        If TypeOf pReport Is Byte() Then
            Return pReport
        End If


        Return Nothing
    End Function

    Public Shared Function ConvertToByte(ByVal pReport As Telerik.Reporting.Report) As Byte()

        Dim zProcessor As New Telerik.Reporting.Processing.ReportProcessor
        Dim zInstanceRpt As New Telerik.Reporting.InstanceReportSource
        zInstanceRpt.ReportDocument = pReport
        Dim zResult As Telerik.Reporting.Processing.RenderingResult = zProcessor.RenderReport("pdf", zInstanceRpt, Nothing)
        Return zResult.DocumentBytes

    End Function

    Public ReadOnly Property ReturnType As ReturnType
        Get
            Return _ReturnType
        End Get
    End Property

    Public Enum ReportingLibrary
        Impairments
    End Enum

End Class

