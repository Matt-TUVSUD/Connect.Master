Public Class ViewIt
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim zSrcFileName As String = "\\extra-data\ClientsWEB_D\data\PDFVault\59ab1f4e0687483e9e617387279b8451.pdf"
        'Dim zDestFileName As String = "~/Home_{{VER}}/FD/"
        'Dim zPageNumber As Integer = 1
        'Dim zDPI As Integer = 72
        'Call GetPageFromPDF(zSrcFileName, zDestFileName, zPageNumber, zDPI)

    End Sub

    'Modified for ASP usage
    'Public Shared Function GetPageFromPDF(ByVal filename As String, ByVal destPath As String, ByRef PageNumber As Integer, Optional ByVal DPI As Integer = RENDER_DPI, Optional ByVal Password As String = "", Optional ByVal searchText As String = "", Optional ByVal searchDir As SearchDirection = 0) As String
    Public Shared Sub GetPageFromPDF(ByVal filename As String, ByVal destPath As String, ByRef PageNumber As Integer, DPI As Integer)
        'GetPageFromPDF = ""
        'Dim pdfDoc As New PDFLibNet.PDFWrapper
        'pdfDoc.RenderDPI = 72
        'pdfDoc.LoadPDF(filename)
        'If Not Nothing Is pdfDoc Then
        '    pdfDoc.CurrentPage = PageNumber
        '    Dim outGuid As Guid = Guid.NewGuid()
        '    Dim output As String = destPath & "\" & outGuid.ToString & ".png"
        '    Dim pdfPage As PDFLibNet.PDFPage = pdfDoc.Pages(PageNumber)
        '    Dim bmp As System.Drawing.Bitmap = pdfPage.GetBitmap(DPI, True)
        '    bmp.Save(output, System.Drawing.Imaging.ImageFormat.Png)
        '    bmp.Dispose()
        '    GetPageFromPDF = output
        '    pdfDoc.Dispose()
        'End If
    End Sub

End Class