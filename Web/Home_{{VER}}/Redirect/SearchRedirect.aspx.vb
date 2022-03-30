Public Class SearchRedirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pGuid As String = ""
        Dim pMode As String = ""
        If Not Context.Request.QueryString("mo") Is Nothing Then
            pMode = Context.Request.QueryString("mo")
        End If
        If Not Context.Request.QueryString("sid") Is Nothing Then
            pGuid = Context.Request.QueryString("sid")
        End If
        Try
            If pMode <> "" And pGuid <> "" Then
                Dim zFilePrefix As String = UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.FilePreFix)

                'Query IndexManager for record where Guid = sid
                Dim zQ As New razor.queryTblIndexManager
                zQ.SelectAll()
                zQ.Where.Add(zQ.colFldFilePrefix.Equals(zFilePrefix))

                Dim zList As New List(Of razor.rowTblIndexManager)
                zList = razor.TblIndexManager.LoadData(zQ.QueryText)

                For Each zRow In zList
                    Dim zURL As String = ""
                    If pMode = "t" Then zURL = "https://grcconnecttest.globalriskconsultants.com/idx/" & zRow.colFldIndexGUID & "/default.asp"
                    If pMode = "l" Then zURL = "https://grcconnect.globalriskconsultants.com/idx/" & zRow.colFldIndexGUID & "/default.asp"
                    zURL += "?sid=" & pGuid & "&mo=" & pMode

                    Response.Redirect(zURL)
                Next
            Else
                Throw New Exception("The mode or S.A.F.E. identification passed in were missing.")
            End If

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        Catch ex As Exception
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "Search Redirect Error"
            If pGuid <> "" Then
                zErrLogError.UserEmail = UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.LoggedInUserEmail)
            Else
                zErrLogError.UserEmail = "Unknown"
            End If
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = zInnerException
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "SearchRedirect.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            Dim zErrorId As Integer = zErrLogError.CreateErrorLogRecord()

            Response.Redirect("~/Home_{{VER}}/Error/?sid=" & pGuid & "&p1=" & zErrorId, False)
        End Try
    End Sub

End Class