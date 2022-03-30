
Public Class ServeIt_Home
    Inherits System.Web.UI.Page

    Private Sub ServeIt_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        ' THIS PAGE IS A DATA HANDLER FOR FILE FETCH AND SERVE ON LOCATION DETAILS PAGE "Click Here" LINKS
        ' USES A FORM POST (BUILT AND DESTROYED IN JAVASCRIPT TO AVOID NESTED FORM TAGS) ON THE CLIENT SIDE POSTING VALUES FOR "FileName" AND "GSafeGUID"
        ' THIS METHOD ELIMINATES THE WHITE FLASH (POSTBACK) AND KEEPS THE USER ON THE SAME PAGE AND WINDOW.

        ' GET THE PARMS FROM THE POST
        Dim zFolder As String = UtilSystemParms.ReadExternalFilePath
        Dim zFileName As String = Replace(Request.Form("FileName").ToString(), "#", "")
        Dim zActualFileName As String = ""
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
        Dim zExtension As String = Replace(Right(zFileName, 4), ".", "").ToLower()

        ' GET THE CLIENT CODE / CLDB NAME
        Dim zGSafeGuid As String = Request.Form("GSafeGUID").ToString()
        Dim zClientCode As String = ""
        If zGSafeGuid.Contains("|none|") Then
            zClientCode = Right(zGSafeGuid, zGSafeGuid.Length - 6) & "\"
        Else
            zClientCode = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.cldbName)
        End If


        ' ASSEMPLE THE FILE PATH STRING
        Dim zFullFilePath As String = ""
        Select Case zPathType
            Case "1"
                ' CLIENT INFORMATION
                zFileName = Replace(zFileName, "\", "/")
                zFileName = Replace(zFileName, "FileShare/data/cldb", zFolder)
                zFullFilePath = zFileName
            Case "2"
                ' USER MANUALS '\\extra-data\ClientsWEB_D\data\Documentation
                zFileName = Replace(zFileName, "/", "\")
                zFileName = Replace(zFileName, "FileShare\data\", Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath)
                zFullFilePath = zFileName
            Case "3"
                ' FULL USER MANUALS '\\extra-data\ClientsWEB_D\data\Documentation
                zFileName = Replace(zFileName, "/", "\")
                zFileName = Replace(zFileName, "FileShare\data\", Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath)
                zFullFilePath = zFileName
            Case "4"
                ' WHATS NEW '\\extra-data\ClientsWEB_D\data\WhatsNew
                zFileName = Replace(zFileName, "/", "\")
                zFileName = Replace(zFileName, "FileShare\data\", Libraries.CoreLib.UtilSystemParms.ReadExternalFilePath)
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
                '    Dim zEL As New UtilLog
                '    zEL.LogIt("myBatchReports (ServeIt): File Path Attempted: " & zFullFilePath, Libraries.CoreLib.UtilLog.EventLevel.Debug, Libraries.CoreLib.UtilLog.EventType.PumpServer, 0, 0, 0, False)
                'Case "7"
                ' SPECIFIC FOR PROGRAM STATUS REPORTS
                ' ONLY FILE NAME PROVIDED FOR PDFVAULT
                'zFullFilePath = "\\extra-data\ClientsWEB_D\data\PDFVault\" & zFileName 'THIS IS FOR DEV
                'zFullFilePath = "C:\PDFVault\" & zFileName 'THIS IS FOR DEV
                zFullFilePath = UtilSystemParms.ReadPDFVaultPath() & zFileName
                '    Dim zEL As New UtilLog
                '    zEL.LogIt("(ServeIt) Program Status PDF Report: File Path Attempted: " & zFullFilePath, Libraries.CoreLib.UtilLog.EventLevel.Debug, Libraries.CoreLib.UtilLog.EventType.PumpServer, 0, 0, 0, False)
                'Case Else
                zFullFilePath = zFolder & zClientCode & "\" & zFileName
        End Select

        ' SEND CONTENT
        Dim zFI As System.IO.FileInfo
        zFI = New System.IO.FileInfo(zFullFilePath)

        Dim zFS As System.IO.FileStream = zFI.OpenRead()
        Dim zLength As Long = zFS.Length

        If (zLength > 0) Then
            Dim zByte(zLength - 1) As Byte

            ' Read the file into a byte array
            zFS.Read(zByte, 0, zLength)
            zFS.Close()

            Response.Clear()
            Response.ClearHeaders()
            Response.ClearContent()
            Response.AddHeader("Content-Disposition", "attachment;filename=" & zActualFileName) '& "." & zExtension)
            Response.ContentType = "application/" & zExtension
            Response.OutputStream.Write(zByte, 0, zByte.Length)
            Response.Flush()
            Response.End()
            Response.Close()
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class