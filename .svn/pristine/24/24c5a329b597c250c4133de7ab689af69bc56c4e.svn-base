Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor

Public Class EmailIt_RecResponse01_RecResponse
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Trace.WriteLine("Starting Process Request")

        Try

            'Dim zRR As New GRC.Connect.Libraries.CoreLib.UtilRecResponse

            Trace.WriteLine(context.Request("pGSafeGUID").ToString(), "Variable Guid")
            Trace.WriteLine(context.Request("pRRLogGuid").ToString(), "Variable RRLogID")
            Trace.WriteLine(context.Request("pCurrentLink").ToString(), "Variable Current Link")
            Trace.WriteLine(context.Request("pRecipientEmail").ToString(), "Variable Email")

            'zRR.GSafeGuid = context.Request("pGSafeGUID").ToString()
            'zRR.RRLogGuid = context.Request("pRRLogGuid").ToString()
            'zRR.CurrentLink = context.Request("pCurrentLink").ToString()
            'zRR._To.Add(context.Request("pRecipientEmail").ToString(), context.Request("pRecipientFullName").ToString())

            '' CORRECT THE CURRENT LINK IN THE RRLOG TABLE
            'Dim zObj As New RRLog
            'Dim zQry As New RRLogQuery
            'zQry.es.Top = 1
            'zQry.SelectAll()
            'zQry.Where(zQry.RRLogGuid = zRR.RRLogGuid)
            'If zObj.Load(zQry) Then
            '    Trace.WriteLine("RR Record Loaded")
            '    zObj.CurrentLink = GRC.Connect.Libraries.CoreLib.UtilURL.CreateURL(zRR.CurrentLink, Libraries.CoreLib.UtilURL.ApplicationURL.AutoRecUrl)
            '    zObj.Save()
            'Else
            '    Trace.WriteLine("RR Record Not Loaded")
            'End If

            'Dim zRRLogId As Integer = zObj.Id
            '' Dim zRRInspectionDate As Date = Date.Parse(context.Request("pInspectionDate").ToString())

            'Trace.WriteLine("Processing Inital Email")
            'zRR.ProcessInitialEmail(zRRLogId, zRRInspectionDate)
            'Trace.WriteLine("Processed Inital Email")
            'Trace.WriteLine("Returning " & Chr(34) & " success " & Chr(34))
            SendInitialLink(context.Request("pRecipientEmail").ToString(), context.Request("pRecipientFullName").ToString(), context.Request("pRRLogGuid").ToString(), context.Request("pCreateNewLink").ToString())
            context.Response.Write("success")

            Return
        Catch ex As Exception
            Trace.WriteLine("Exception: " & ex.Message)
            System.Diagnostics.EventLog.WriteEntry("GRC.Connect.Web", ex.Message & vbNewLine & ex.StackTrace, EventLogEntryType.Error)
            context.Response.Write(ex.Message & "")
        End Try

    End Sub

    Public Sub SendInitialLink(pRecipientEmail As String, pRecipientName As String, pRRLogGuid As String, pCreateNewLink As Boolean)
        Dim zRRLog As rowTblRRLog = TblRRLog.LoadByIDX_IX_RRGuid(pRRLogGuid)(0)
        zRRLog.colCurrentLink = AutoRecLib.UtilURL.BuildAutoRecURL(HttpContext.Current.Request, zRRLog, pCreateNewLink)
        zRRLog.colRecipientEmail = pRecipientEmail
        zRRLog.colRecipientName = pRecipientName
        TblRRLog.Save(zRRLog)

        Dim zAutoRec As New AutoRecLib.UtilAutoRec
        zAutoRec.ProcessInitialEmail(zRRLog.colId)

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class