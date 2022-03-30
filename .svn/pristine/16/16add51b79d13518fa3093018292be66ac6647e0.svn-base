Imports System.Web
Imports System.Web.Services

Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.DataLib.razor


Public Class ServeExtract
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

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
            Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString
            Dim zGSafeId As Integer = UtilGSafe.GetId(zGUID)
            Dim zGridId As Integer = UtilGSafe.GetValue(zGUID, "currentGridId")
            zClient = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)

            ' GET USER CURRENCY OVERRIDE
            Dim zUserCurrencyIdParm As String = ""
            If Not context.Request.QueryString("userCurrencyId") Is Nothing Then
                zUserCurrencyIdParm = context.Request.QueryString("userCurrencyId")
            End If

            ' GET THE GRID NAME
            Dim zFileName As String = ""
            Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
            zFileName = zMetaGrid.colFldFileName

            ' GET THE FILTER, SORT, AND CRITERIA
            Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zGridId)
            Dim zCriteria As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zGridId)
            Dim zSort As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.sort, zGridId)
            Dim zMeta As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.meta, zGridId)

            ' BUILD THE EXTRACT FILE DATA
            Dim zByte() As Byte
            Select Case zGridId
                Case UtilMeta.GetMetaKey("ProjectManagement", 314)
                    'call Dan's new Project Management extract
                    zByte = UtilExport.ProjectManagementExport.Export(zGUID, zGridId, zFilter, zSort)
                Case Else
                    zByte = UtilExport.ExportGrid(zGUID, zGridId, zFilter, zCriteria, zSort, zUserCurrencyIdParm)
            End Select

            ' DELIVER FILE
            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zFileName & "Extract_" & UtilText.RemoveSpecialCharacters(zClient) & "_" & zTimeStamp & ".xlsx")
            context.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" '"application/vnd.ms-excel"
            context.Response.OutputStream.Write(zByte, 0, zByte.Length)
            context.Response.Flush()
            context.Response.End()
            context.Response.Close()

            'Catch ex As System.Threading.ThreadAbortException
            '    ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE
            '    Dim zErrLogError As New UtilErrorLog
            '    zErrLogError.DateOccured = Now
            '    zErrLogError.ErrorType = "ServeExtract Error"
            '    zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            '    zErrLogError.MessageOuter = ex.Message
            '    Dim zInnerException As String = Nothing
            '    If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            '    zErrLogError.MessageInner = zInnerException
            '    zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            '    zErrLogError.ApplicationPage = "ServeExtract.aspx"
            '    zErrLogError.StackTraceInner = ex.StackTrace
            '    zErrLogError.CreateErrorLogRecord()

        Catch ex As Exception
            ' OTHER ERROR
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "ServeExtract Error"
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "ServeExtract.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            zErrLogError.CreateErrorLogRecord()

        End Try


    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class