Imports System.Web
Imports System.Web.Services

Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor

Public Class ServeReport
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
            zGUID = UtilGSafe.GetGUIDFromQueryString
            zGSafeId = UtilGSafe.GetId(zGUID)
            zClient = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)

            ' GET USER CURRENCY OVERRIDE
            Dim zUserCurrencyIdParm As String = ""
            If Not context.Request.QueryString("userCurrencyId") Is Nothing Then
                zUserCurrencyIdParm = context.Request.QueryString("userCurrencyId")
            End If

            ' GET THE REPORT TO EXECUTE
            Dim zFileName As String = ""
            Dim zReportID As Integer = 0
            Dim zMetaGrid As rowTblMetaGrid = Nothing
            Dim zMetaChart As rowTblMetaChart = Nothing
            Dim zMetaReport As rowTblMetaReport = Nothing
            Dim zDataGroupId As Integer = 0

            Dim zFilter As String = ""
            Dim zCriteria As String = ""
            Dim zSetting As String = ""
            Dim zVirtualFilter As New VirtualFilter
            Dim zSource As String = context.Request.QueryString("action")
            Dim zIsPrintingFormReport As Boolean = False

            Select Case zSource.ToLower
                Case "PrintLocationReport".ToLower
                    zReportID = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentReportCode)
                    zMetaReport = TblMetaReport.LoadByPrimaryKey(CInt(zReportID))
                    zDataGroupId = zMetaReport.colFldId
                    zFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zDataGroupId)
                    zCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zDataGroupId)
                    zSetting = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zDataGroupId)

                Case "PrintFormReport".ToLower
                    zReportID = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FormReportId)
                    zMetaReport = TblMetaReport.LoadByPrimaryKey(CInt(zReportID))
                    zDataGroupId = zMetaReport.colFldId
                    zIsPrintingFormReport = True
                    zFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zDataGroupId)
                    zCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zDataGroupId)
                    zSetting = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zDataGroupId)

                Case "PrintGridReport".ToLower
                    Dim zGridId As String = Nothing
                    zGridId = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentGridId)
                    zMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
                    zMetaReport = TblMetaReport.LoadByPrimaryKey(IIf(context.Request.QueryString.ToString.ToLower.Contains("useReport2".ToLower), zMetaGrid.colFldReport2Id, zMetaGrid.colFldReportId))
                    zDataGroupId = zMetaGrid.colFldId
                    zFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zDataGroupId)
                    zCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zDataGroupId)
                    zSetting = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zDataGroupId)

                Case "PrintChartReport".ToLower
                    Dim zChartId As String = Nothing
                    zChartId = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentChartId)
                    zMetaChart = TblMetaChart.LoadByPrimaryKey(zChartId)
                    zMetaReport = TblMetaReport.LoadByPrimaryKey(zMetaChart.colFldReportId)
                    zDataGroupId = zMetaChart.colFldId
                    zFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, zDataGroupId)
                    zCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteriaChart, zDataGroupId)
                    zSetting = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, zDataGroupId)
                    zVirtualFilter = Newtonsoft.Json.JsonConvert.DeserializeObject(Of VirtualFilter)(UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilterChart, zDataGroupId))

                Case Else
                    Throw New ApplicationException("ServeReport.ashx has invalid arguments. Missing [action] querystring parameter.")
            End Select

            zUserEmail = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.UserEmail)
            zFileName = zMetaReport.colFldFileName
            zReportID = zMetaReport.colFldId

            ' GET THE FILTER, SORT, AND CRITERIA
            'zFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zDataGroupId)
            'zCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zDataGroupId)
            'zSetting = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.setting, zDataGroupId)
            Dim zSort As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.sort, zDataGroupId)
            Dim zMeta As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.meta, zDataGroupId)
            Dim zFilePrefix As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FilePreFix)

            'THIS SETS THE FILTER CRITERIA TO THE FILENO IF THE USER IS RUNNING THE REPORT AT THE LOCATION LEVEL.
            Dim zFileNo As String = "" 'UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FileNo)
            Dim zIsOnDetailsPage As Boolean = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.IsOnDetailPage)
            Dim zNavLinkId As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.NavLinkId)

            If zIsOnDetailsPage OrElse zIsPrintingFormReport Then
                If zIsOnDetailsPage Then
                    Dim zNavSlideType As String = UtilNavLink.GetSlideMenuType(Int(zNavLinkId))
                    If zNavSlideType = GRC.Connect.Libraries.CoreLib.BusinessObjects.NavLink.SlideMenuTypes.Practice Then
                        zFileNo = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FileNo)
                    End If
                Else  '<<Is Printing Form Report
                    zFileNo = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FormFileNo)  'Get the FileNo from gsafe
                End If
            End If

                Dim zJSONFilter As New JSONFilter
                If zFileNo <> "" Then
                    zJSONFilter.Logic = JSONFilterLogic.Operators.And
                    zJSONFilter.Filters.Add(New JSONFilterItem("FileNo", JSONFilterOperator.Operators.Equal, zFileNo))
                    zCriteria = zJSONFilter.ToJSON
                End If

                'GET CURRENCY PREFERENCE OR OVERRIDE
                Dim zCurrencyID As String = UtilGSafe.GetValue(zGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference)
                Dim zCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar
                If IsNumeric(zCurrencyID) Then zCurrency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), zCurrencyID)
                If zUserCurrencyIdParm.Length > 0 Then
                    If IsNumeric(zUserCurrencyIdParm) Then zCurrency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), zUserCurrencyIdParm)
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
                    .SetParameters.Currency = zCurrency

                    If IsNumeric(zVirtualFilter.InspectionProgramYear) Then .SetParameters.InspectionProgramYear = CInt(zVirtualFilter.InspectionProgramYear)
                    If IsNumeric(zVirtualFilter.TIVValue) Then .SetParameters.TIVValue = CInt(zVirtualFilter.TIVValue)



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
                context.Response.ContentType = "application/pdf"

            context.Response.AddHeader("Content-Disposition", "attachment;filename=""" & zFileName & "_" & UtilText.RemoveSpecialCharacters(zClient) & "_" & zTimeStamp & ".pdf""")
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

    Private Class VirtualFilter
        Public Property TIVValue As String = ""
        Public Property InspectionProgramYear As String = ""
    End Class

End Class