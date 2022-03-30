Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ReportHandler
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zHasPrefilters As Boolean = False
        Dim zRedirectURL As String = "../FD/ServeReport.ashx?" & context.Request.QueryString.ToString

        Dim zUserid As Integer = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.EzyLoginId)

        If IsLocationReport(context) Then

            Dim zReportId As Integer = GetReportIdFromQueryString(context)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentReportCode, zReportId, UtilGSafe.KeyNameGroup.Navigation)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.NavLinkId, GetNavLinkIdFromQueryString(context), UtilGSafe.KeyNameGroup.Navigation)

            zHasPrefilters = UtilReporting.ReportHasParameters(zReportId)
            If zHasPrefilters Then
                zRedirectURL = "PreFilter.aspx?" & context.Request.QueryString.ToString
            Else
                zRedirectURL = "ReportFetch.aspx?" & context.Request.QueryString.ToString
            End If

            UtilDB.LogReportActivity(zUserid, zReportId)

        ElseIf IsEngineerReport(context) Or IsDiagramReport(context) Then

            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FormFileNo)
            Dim zGridId As Integer = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.currentGridId)
            Dim zGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
            Dim zServiceId As Integer = Nothing

            If IsDiagramReport(context) Then
                Dim zDiagramDocLibRecord As rowVwLibrariesDocumentLibrarySelect = UtilDocLib.FindLatestDiagramRecord(zFileNo)
                Dim zGuid As String = zDiagramDocLibRecord.colReportGuid
                If IsDiagramReport(context) Then zRedirectURL = "../FD/ServeDocLibReport.ashx?reportGuid=" & zGuid & "&t=d"
                UtilDB.LogOtherActivity(zUserid, "DiagramReport")
            Else
                If context.Request.QueryString.ToString.ToLower.Contains("service") OrElse zGrid.colFldMetaPracticeId Then
                    If IsNumeric(zGrid.colFldMetaPracticeId) Then
                        zServiceId = zGrid.colFldMetaPracticeId
                    Else
                        zServiceId = context.Request.QueryString("service")
                    End If

                    Dim zGuid As String = UtilDocLib.GetReportGuid(zFileNo, zServiceId)
                    If IsEngineerReport(context) Then zRedirectURL = "../FD/ServeDocLibReport.ashx?reportGuid=" & zGuid & "&t=e"
                    UtilDB.LogOtherActivity(zUserid, "EngineerReport")
                Else
                    Dim zReportType As String = "Engineer"
                    Dim zEx As New ApplicationException(zReportType & " report cannot be located. Missing service or practice Id.")
                    zEx.Data.Add("Grid Id", zGridId)
                    zEx.Data.Add("File No.", zFileNo)
                    Throw zEx
                End If
            End If

        ElseIf IsFormReport(context) Then

            Dim zReportId As Integer
            Try
                zReportId = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FormReportId)
            Catch ex As Exception
                Throw New ApplicationException("Missing or invalid [FormViewReportId] in meta grid.")
            End Try

            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentReportCode, zReportId, UtilGSafe.KeyNameGroup.Navigation)
            zHasPrefilters = UtilReporting.ReportHasParameters(zReportId)

            Dim zJSON As New JSONFilter
            zJSON.Filters.Add(New JSONFilterItem("FileNo", JSONFilterOperator.Operators.Equal, UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FormFileNo)))
            UtilSafe.SaveLargeObjectData_ByDataGroup(UtilGSafe.GetId(zSafeGUID), UtilSafe.LargeObjectName.filter, zJSON.ToJSON, zReportId)

            If zHasPrefilters Then
                zRedirectURL = "PreFilter.aspx?" & context.Request.QueryString.ToString
            Else
                zRedirectURL = "ReportFetch.aspx?" & context.Request.QueryString.ToString
            End If

            UtilDB.LogUserActivity(zUserid, "R", zReportId, "From Grid Form")

        End If

        context.Response.Redirect(zRedirectURL)

    End Sub


    Public Function IsGridReport(ByVal context As HttpContext) As Boolean
        Return context.Request.QueryString.ToString.ToLower.Contains("PrintGridReport".ToLower)
    End Function

    Public Function IsChartReport(ByVal context As HttpContext) As Boolean
        Return context.Request.QueryString.ToString.ToLower.Contains("PrintChartReport".ToLower)
    End Function

    Public Function IsLocationReport(ByVal context As HttpContext) As Boolean
        Return context.Request.QueryString.ToString.ToLower.Contains("PrintLocationReport".ToLower)
    End Function

    Public Function IsFormReport(ByVal context As HttpContext) As Boolean
        Return context.Request.QueryString.ToString.ToLower.Contains("PrintFormReport".ToLower)
    End Function

    Public Function IsEngineerReport(ByVal context As HttpContext) As Boolean
        Return context.Request.QueryString.ToString.ToLower.Contains("PrintEngineerReport".ToLower)
    End Function

    Public Function IsDiagramReport(ByVal context As HttpContext) As Boolean
        Return context.Request.QueryString.ToString.ToLower.Contains("PrintDiagramReport".ToLower)
    End Function

    Public Function GetNavLinkIdFromQueryString(ByVal context As HttpContext) As Integer
        Return Val(context.Request.QueryString("navLinkId") & "")
    End Function

    Public Function GetReportIdFromQueryString(ByVal context As HttpContext) As Integer
        Return TblNavLink.LoadByPrimaryKey(GetNavLinkIdFromQueryString(context)).colNavReportId
    End Function


    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class