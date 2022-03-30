Public Class UtilBatchProcessResult
    Public BatchSet As BatchSet
    Public File As Byte()
    Public FileNameNoExtension As String
    Public FileName As String
    Public Mime As String
    Public Extension As String

    Public Sub Open()
        Dim zTempPath As String = IO.Path.GetTempFileName
        zTempPath = Replace(zTempPath, ".tmp", Extension)
        IO.File.WriteAllBytes(zTempPath, File)
        Process.Start(zTempPath)
    End Sub

End Class

