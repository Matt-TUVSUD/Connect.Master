Imports System.Web
Imports System.Web.Services

Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ServeChart
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim zGUID As String = Nothing
        Dim zGSafeId As Integer = Nothing
        Dim zUserEmail As String = ""
        Dim zMsgLog As New UtilLog
        Dim zClient As String = ""

        Try
            ' BUILD TIME STAMP
            Dim zNow As Date = Now()
            Dim zDay As String = zNow.Day.ToString()
            Dim zMonth As String = zNow.Month.ToString()
            Dim zYear As String = zNow.Year.ToString()
            If zNow.Day < 10 Then zDay = "0" & zDay
            If zNow.Month < 10 Then zMonth = "0" & zMonth
            Dim zTimeStamp = zYear & zMonth & zDay & ""

            ' GET PARMS
            If Not context.Request.QueryString("gSafeGuid") Is Nothing Then
                zGUID = context.Request.QueryString("gSafeGuid")
                zGSafeId = UtilGSafe.GetId(zGUID)
                zClient = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
            End If

            ' GET THE REPORT TO EXECUTE
            Dim zFileName As String = ""
            Dim zReportID As Integer = 0
            Dim zMetaGrid As rowTblMetaGrid = Nothing
            Dim zMetaReport As rowTblMetaReport = Nothing
            Dim zDataGroupId As Integer = 0

            If Not context.Request.QueryString("rptCode") Is Nothing Then
                ' DIRECT REPORTS FROM PASSED ID
                zMetaReport = TblMetaReport.LoadByPrimaryKey(CInt(context.Request.QueryString("rptCode")))
                zFileName = zMetaReport.colFldFileName
                zReportID = zMetaReport.colFldId
                zDataGroupId = zMetaReport.colFldId
            Else
                ' REPORTS CALLED FROM GRIDS
                Dim zGridId As String = Nothing
                zGridId = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentGridId)
                zUserEmail = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserEmail)
                zMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
                zMetaReport = TblMetaReport.LoadByPrimaryKey(zMetaGrid.colFldReport2Id)
                zFileName = zMetaReport.colFldFileName
                zReportID = zMetaReport.colFldId
                zDataGroupId = zMetaGrid.colFldId
            End If

            ' GET THE FILTER, SORT, AND CRITERIA
            Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zDataGroupId)
            Dim zCriteria As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zDataGroupId)
            Dim zSort As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.sort, zDataGroupId)
            Dim zMeta As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.meta, zDataGroupId)
            Dim zSetting As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zDataGroupId)
            Dim zFilePrefix As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FilePreFix)

            'THIS SETS THE FILTER CRITERIA TO THE FILENO IF THE USER IS RUNNING THE REPORT AT THE LOCATION LEVEL.
            Dim zFileNo As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FileNo)
            Dim zJSONFilter As New JSONFilter
            If zFileNo <> "" Then
                zJSONFilter.Logic = JSONFilterLogic.Operators.And
                zJSONFilter.Filters.Add(New JSONFilterItem("FileNo", JSONFilterOperator.Operators.Equal, zFileNo))
                zCriteria = zJSONFilter.ToJSON
            End If

            'MAKE BATCHSET
            Dim zBatchSet As New BatchLib.BatchSet()
            With zBatchSet
                .colFldIsMyBatchReport = False
                .AddFileNo(TblGSafeFileNo.GetFileNos(zGSafeId))
                .AddSetItem(zReportID)
                .colFldIsInteractive = True
                .colFldFileName = zMetaReport.colFldFileName
                .Type = BatchSet.BatchType.Report
                .colFldCreateDate = Now
                .colFldLOCriteriaJSON = zCriteria
                .colFldCreatedByGsafeId = zGSafeId
                .colFldCreatedByGsafeUserEmail = zUserEmail
                .colFldLOSortJSON = zSort
                .colFldLOSettingJSON = zSetting
                .colFldCreatedByGsafeId = zGSafeId
                .colFldLOFilterJSON = zFilter

                .SetParameters.FilePrefix = zFilePrefix

            End With
            'Diagnostics.Trace.WriteLine("ReportSet Created [" & zRptSet.ID & "]")

            ' BUILD THE REPORT
            Dim zResult As BatchLib.UtilBatchProcessResult = zBatchSet.Execute()

            ' CLEAR THE STORED IDs FOR THE NEXT DOWNLOAD
            'UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentGridId, "", UtilGSafe.KeyNameGroup.Navigation)
            'UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentReportCode, "", UtilGSafe.KeyNameGroup.Navigation)

            ' DELIVER FILE
            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zFileName & "_" & UtilText.RemoveSpecialCharacters(zClient) & "_" & zTimeStamp & ".pdf")
            context.Response.ContentType = "application/pdf"
            context.Response.OutputStream.Write(zResult.File, 0, zResult.File.Length)
            context.Response.Flush()
            context.Response.End()
            context.Response.Close()

            'context.Response.Clear()
            'context.Response.ClearHeaders()
            'context.Response.ClearContent()
            'context.Response.Redirect("~/Home_{{VER}}/Reports/ReportComplete.aspx?sid=" & zGUID, False)

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE
            'context.Response.Clear()
            'context.Response.ClearHeaders()
            'context.Response.ClearContent()
            'context.Response.Redirect("~/Home_{{VER}}/Reports/ReportComplete.aspx?sid=" & zGUID, False)

        Catch ex As Exception
            ' OTHER ERROR
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "Serve Report Error"
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "ServeReport.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zErrLogError.CreateErrorLogRecord()

            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.Redirect("~/Home_{{VER}}/Error/?sid=" & zGUID & "&p1=" & zErrorId, False)

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class