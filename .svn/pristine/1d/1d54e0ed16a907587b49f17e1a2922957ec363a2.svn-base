Imports System.Web
Imports System.Web.Services
Imports System.IO

Public Class SearchDownload
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            'PARMS
            Dim pGuid As String = ""
            Dim pPathB As String = ""
            If Not context.Request.QueryString("fn") Is Nothing Then
                pPathB = context.Request.QueryString("fn")
                'Replace '/' with '\'
                pPathB = pPathB.Replace("/", "\")
                'Replace special char using custom replacers
                pPathB = pPathB.Replace("_ampersandgoeshere_", "&")
            End If
            If Not context.Request.QueryString("sid") Is Nothing Then
                pGuid = context.Request.QueryString("sid")
            End If

            If pPathB <> "" And pGuid <> "" Then
                'Both requirements must be true for download
                '   SELECT * FROM GSafeHeader WHERE GSafeGuid = sid
                '   LastAccessed date  older than 24hr
                Dim zQ As New razor.queryTblGSafeHeader
                zQ.SelectAll()
                zQ.Where.Add(zQ.colGSafeGUID.Equals(pGuid))

                Dim zList As New List(Of razor.rowTblGSafeHeader)
                zList = razor.TblGSafeHeader.LoadData(zQ.QueryText)

                For Each zRow In zList
                    If zRow.colLastAccessed > Now.AddHours(-24) Then
                        'Success

                        'Determine the cldbName folder based on zFilePrefix
                        Dim zFilePrefix As String = UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.FilePreFix)

                        Dim zQIndex As New razor.queryTblIndexManager
                        zQIndex.SelectAll()
                        zQIndex.Where.Add(zQIndex.colFldFilePrefix.Equals(zFilePrefix))

                        Dim zListIndex As New List(Of razor.rowTblIndexManager)
                        zListIndex = razor.TblIndexManager.LoadData(zQIndex.QueryText)

                        For Each zRowIndex In zListIndex
                            Dim zCldbName As String = "cldb" & zRowIndex.colFldCldbName & "\"
                            Dim zFile As String = "\\exnjcu01002.exus01.net\AppData\ClientData\" + zCldbName + pPathB
                            Dim zFileByte As Byte() = System.IO.File.ReadAllBytes(zFile)
                            Dim zFileName As String = Path.GetFileNameWithoutExtension(zFile)

                            ' DELIVER FILE AS PDF
                            context.Response.Clear()
                            context.Response.ClearHeaders()
                            context.Response.ClearContent()
                            context.Response.ContentType = "application/pdf"
                            context.Response.AddHeader("Content-Disposition", "attachment;filename=" & zFileName & ".pdf")
                            context.Response.OutputStream.Write(zFileByte, 0, zFileByte.Length)
                            context.Response.Flush()
                            context.Response.End()
                            context.Response.Close()

                        Next
                    Else
                        'Too old
                        Throw New System.Exception("Guid is too old. User needs to re-login .... [Wordsmith]")
                    End If
                Next
            Else
                Throw New System.Exception("Guid could not be found .... [Wordsmith]")
            End If

        Catch ex As System.Threading.ThreadAbortException
            ' THIS IS AN EXPECTED ERROR, THIS CATCH IS DESIGNED TO CONSUME THE ERROR AND CONTINUE

        Catch ex As Exception
            ' OTHER ERROR DELIVERED AS JSON
            Dim errorMessage As String = Regex.Replace(ex.Message, "[^\w\.@-]", " ")
            context.Response.Clear()
            context.Response.ClearHeaders()
            context.Response.ClearContent()
            context.Response.Write("<script>window.parent.gSearchDownloadError(""" & errorMessage & """);</script>")

        End Try
    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class