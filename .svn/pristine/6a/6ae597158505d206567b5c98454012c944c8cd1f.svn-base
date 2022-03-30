Imports System.Web
Imports System.Web.Services
Imports System.IO

Public Class ImportHandler
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim zReturn As String = ""
        Dim zContinue As Boolean = True
        Dim zClose As Boolean = False
        Dim zFileName As String
        Dim zFolder As String = System.Web.HttpContext.Current.Server.MapPath("~/Home_{{VER}}/Imports/ImportFiles/")
        Dim zFileList As New List(Of String)
        Dim zSheetList As New List(Of ImportLib.ImportEnum.ImportSheet)
        Dim zFileResultMessage As String = ""
        Dim zImportFileResultList As ImportLib.ImportFileResultList

        Try
            ' GET PASSED DATA
            Dim ImportSheets As String = context.Request.Form("ImportSheet")
            Dim ImportFileList As String = context.Request.Form("ImportFileList")
            Dim ImportStrings As String = context.Request.Form("ImportStrings")
            Dim zGSafeGuid As String = context.Request.Form("ImportGSafeGuid")

            ' REMOVE EXISTING FILES IF EXPIRED
            Dim zFile As String = ""
            Dim zFI As System.IO.FileInfo
            For Each zFile In My.Computer.FileSystem.GetFiles(zFolder)
                zFI = My.Computer.FileSystem.GetFileInfo(zFile)
                ' DO WE NEED TO CATCH ANY OTHER FILES?  ALLOWED FILE TYPES ALSO SPECIFIED IN JS FILE LIB\PAGES\ADMINWINDOW.JS. BOTH AREAS NEED TO BE CHANGED
                If zFI.Extension.ToUpper = ".csv".ToUpper Or zFI.Extension.ToUpper = ".xls".ToUpper Or zFI.Extension.ToUpper = ".xlsx".ToUpper Or zFI.Extension.ToUpper = ".xlsm".ToUpper Then
                    If DateDiff(DateInterval.Hour, zFI.CreationTime, Now) > GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadFileExpireHours Then
                        My.Computer.FileSystem.DeleteFile(zFile)
                    End If
                End If
            Next

            ' SAVE NEW FILES
            Dim x As Integer
            For x = 0 To context.Request.Files.Count - 1
                zFileName = System.IO.Path.GetFileName(context.Request.Files(x).FileName)
                context.Request.Files(x).SaveAs(zFolder & zFileName)
                zFileList.Add(zFolder & zFileName)
            Next

            'CREATE SHEET ENUM LIST
            For Each zSheet As Integer In Split(ImportSheets, ":")
                zSheetList.Add(zSheet)
            Next

            'IMPORT - GET IMPORTFILERESULTLIST
            zImportFileResultList = ImportLib.Public.ImportTemplate(zGSafeGuid, zFileList, zSheetList)

            'APPEND MESSAGES TO RETURN VARIABLE
            For Each zImportFileResult As ImportLib.ImportFileResult In zImportFileResultList
                zReturn = zReturn & zImportFileResult.Text
            Next

        Catch ex As ImportLib.ImportException
            zReturn = ex.Message
            zContinue = False
            zClose = False

        Catch ex As Exception
            zReturn = ex.ToString
            zContinue = False
            zClose = False
        End Try

        ' RETURN MESSAGE IN JSON FORMAT
        ' REPLACE ANY CHARS THAT CAN CAUSE JSON ERRORS
        ' THIS IS A NEW LINE IN THE RESULTS \n\r
        zReturn = Replace(zReturn, """", "`")
        zReturn = Replace(zReturn, "'", "`")
        zReturn = Replace(zReturn, "{", "[")
        zReturn = Replace(zReturn, "}", "]")
        zReturn = Replace(zReturn, "\", "\\")


        Dim tempMsg As String = "{""result"":""" & zReturn & """, ""continueImport"":""" & zContinue.ToString() & """, ""closeImport"":""" & zClose.ToString() & """}"
        context.Response.ClearHeaders()
        context.Response.ClearContent()
        context.Response.Clear()
        context.Response.ContentType = "text/plain"
        context.Response.Write(tempMsg)
        context.Response.Flush()
        context.Response.End()

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class