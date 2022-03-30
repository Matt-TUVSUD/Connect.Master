
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe

Public Class ServeIt
    Inherits System.Web.UI.Page

    Public ServerSide_AuthURL As String = ""

    Private Sub ServeIt_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        ' THIS PAGE IS A DATA HANDLER FOR FILE FETCH AND SERVE ON LOCATION DETAILS PAGE "Click Here" LINKS
        ' USES A FORM POST (BUILT AND DESTROYED IN JAVASCRIPT TO AVOID NESTED FORM TAGS) ON THE CLIENT SIDE POSTING VALUES FOR "FileName" AND "GSafeGUID"
        ' THIS METHOD ELIMINATES THE WHITE FLASH (POSTBACK) AND KEEPS THE USER ON THE SAME PAGE AND WINDOW.

        ' START SERVE IT RESPONSE LOGGING
        Dim zMsgLog As New UtilLog
        'zMsgLog.LogIt("(ServeIt) Page loaded successfully, start process for " & GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail))


        Dim zActualFileName As String = ""
        Dim zExtension As String = ""
        Dim zIsHeadersSent As Boolean = False
        Dim dict As New Dictionary(Of String, Object)

        Try
            ' ADDED A TEST COMMENT TO COMMIT AND REBUILD.

            ' GET THE PARMS FROM THE POST
            Dim zFolder As String = UtilSystemParms.ReadExternalFilePath
            Dim zFileName As String = Replace(Request.Form("FileName").ToString(), "#", "")
            Dim zPathType As String = ""
            Dim zUserFileName As String = ""
            If Not Request.Form("UserFileName") Is Nothing Then
                zUserFileName = Replace(Request.Form("UserFileName").ToString(), "#", "")
            End If
            If Not Request.Form("PathType") Is Nothing Then
                zPathType = Request.Form("PathType").ToLower()
            End If

            ' CORRECT ANY INCORRECT CHARS IN FILENAME
            zFileName = Replace(zFileName, "&amp;", "&")
            zFileName = Replace(zFileName, "amp;", "")
            zFileName = Server.UrlDecode(zFileName)

            ' SET THE NAME OF THE DOWNLOADED FILE
            If Not zUserFileName Is Nothing Then
                If zUserFileName <> "" And zUserFileName <> "undefined" Then
                    zActualFileName = zUserFileName
                Else
                    zActualFileName = Right(zFileName, zFileName.Length() - InStrRev(zFileName, "\"))
                End If
            Else
                zActualFileName = Right(zFileName, zFileName.Length() - InStrRev(zFileName, "\"))
            End If
            zExtension = Replace(Right(zFileName, 4), ".", "").ToLower()

            ' GET THE CLIENT CODE / CLDB NAME
            Dim zGSafeGuid As String = Request.Form("GSafeGUID").ToString()
            Dim zClientCode As String = ""
            If zGSafeGuid.Contains("|none|") Then
                zClientCode = Right(zGSafeGuid, zGSafeGuid.Length - 6) & "\"
            Else
                zClientCode = GetValue(zGSafeGuid, KeyName.cldbName)
            End If


            ' ASSEMPLE THE FILE PATH STRING
            Dim zFullFilePath As String = ""
            Select Case zPathType
                Case "1"
                    ' CLIENT INFORMATION
                    zFileName = Replace(zFileName, "/", "\")
                    zFileName = Replace(zFileName, "FileShare\", zFolder)
                    zFullFilePath = zFileName
                    'Case "2"
                    '    ' USER MANUALS '\\extra-data\ClientsWEB_D\data\Documentation
                    '    zFileName = Replace(zFileName, "/", "\")
                    '    zFileName = Replace(zFileName, "FileShare\", Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath)
                    '    zFullFilePath = zFileName
                    'Case "3"
                    '    ' FULL USER MANUALS '\\extra-data\ClientsWEB_D\data\Documentation
                    '    zFileName = Replace(zFileName, "/", "\")
                    '    zFileName = Replace(zFileName, "FileShare\", Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath)
                    '    zFullFilePath = zFileName
                Case "4"
                    ' WHATS NEW '\\extra-data\ClientsWEB_D\data\WhatsNew
                    zFileName = Replace(zFileName, "/", "\")
                    zFileName = Replace(zFileName, "FileShare\", UtilSystemParms.ReadExternalFilePath)
                    zFullFilePath = zFileName
                Case "5"
                    ' FULL PATH PASSED IN FILE NAME, NO REPLACEMENT NEEDED
                    ' REPORTS SINGLE REPORTS
                    zFullFilePath = zFileName
                Case "6"
                    ' ONLY FILE NAME PROVIDED FOR PDFVAULT
                    'zFullFilePath = "\\extra-data\ClientsWEB_D\data\PDFVault\" & zFileName 'THIS IS FOR DEV
                    'zFullFilePath = "C:\PDFVault\" & zFileName 'THIS IS FOR DEV
                    zFullFilePath = UtilSystemParms.ReadPDFVaultPath() & zFileName
                    Dim zEL As New UtilLog

                    'PDFs now stored in DB
                    'zEL.LogIt("myBatchReports (ServeIt): File Path Attempted: " & zFullFilePath, Libraries.CoreLib.UtilLog.EventLevel.Debug, Libraries.CoreLib.UtilLog.EventType.PumpServer, 0, 0, 0, False)
                Case "7"
                    ' SPECIFIC FOR PROGRAM STATUS REPORTS
                    ' ONLY FILE NAME PROVIDED FOR PDFVAULT
                    'zFullFilePath = "\\extra-data\ClientsWEB_D\data\PDFVault\" & zFileName 'THIS IS FOR DEV
                    'zFullFilePath = "C:\PDFVault\" & zFileName 'THIS IS FOR DEV
                    zFullFilePath = UtilSystemParms.ReadPDFVaultPath() & zFileName
                    Dim zEL As New UtilLog
                    'PDFs now stored in DB
                    ' zEL.LogIt("(ServeIt) Program Status PDF Report: File Path Attempted: " & zFullFilePath, Libraries.CoreLib.UtilLog.EventLevel.Debug, Libraries.CoreLib.UtilLog.EventType.PumpServer, 0, 0, 0, False)
                Case Else
                    zFullFilePath = zFolder & "cldb" & zClientCode & "\" & zFileName
            End Select

            ' SEND CONTENT
            Dim zFI As System.IO.FileInfo
            zFI = New System.IO.FileInfo(zFullFilePath)

            ''debug
            dict.Add("zActualFileName", zActualFileName)
            dict.Add("zClientCode", zClientCode)
            dict.Add("zExtension", zExtension)
            dict.Add("zFullFilePath", zFullFilePath)
            dict.Add("zFileName", zFileName)
            dict.Add("zFolder", zFolder)
            dict.Add("zGSafeGuid", zGSafeGuid)
            dict.Add("zPathType", zPathType)
            dict.Add("zUserFileName", zUserFileName)

            Dim zFS As System.IO.FileStream = zFI.OpenRead()
            Dim zLength As Long = zFS.Length

            If (zLength > 0) Then
                Dim zByte(zLength - 1) As Byte

                ' Read the file into a byte array
                zFS.Read(zByte, 0, zLength)
                zFS.Close()

                ' START SERVE IT RESPONSE LOGGING
                'zMsgLog = New UtilLog
                'zMsgLog.LogIt("(ServeIt) Response Start for " & GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail))

                Response.Clear()
                Response.ClearHeaders()
                Response.ClearContent()
                Response.AddHeader("Content-Disposition", "attachment;filename=" & zActualFileName) '& "." & zExtension)
                zIsHeadersSent = True
                Response.ContentType = "application/" & zExtension
                Response.OutputStream.Write(zByte, 0, zByte.Length)
                Response.Flush()
                Response.End()
                Response.Close()

            End If

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

            ' START SERVE IT RESPONSE LOGGING
            'zMsgLog = New UtilLog
            'zMsgLog.LogIt("(ServeIt) Response End for " & GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail))

        Catch ex As Exception
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "ServeIt Error"
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString, KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = ex.Message
            Dim zInnerException As String = Nothing
            If Not ex.InnerException Is Nothing Then zInnerException = ex.InnerException.Message
            zErrLogError.MessageInner = Newtonsoft.Json.JsonConvert.SerializeObject(dict)
            zErrLogError.ReferringURL = HttpContext.Current.Request.Url.AbsoluteUri
            zErrLogError.ApplicationPage = "ServeIt.aspx"
            zErrLogError.StackTraceInner = ex.StackTrace
            zErrLogError.CreateErrorLogRecord()


            If Not zIsHeadersSent Then
                Response.Redirect("../Error/Default.aspx", False)
            End If

        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SET THE URL OF THE AUTH PAGE FOR REDIRECTION
        Dim zP1 As String = Request.QueryString("p1") & ""
        If zP1.Length > 0 Then
            ServerSide_AuthURL = UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}/Auth/?p1=" & zP1
        Else
            ServerSide_AuthURL = UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}/Auth/"
        End If

    End Sub

End Class