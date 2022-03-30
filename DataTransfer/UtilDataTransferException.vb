Public Class UtilDataTransferException
    Inherits Exception

    Public Property Client As String

    Public Property FilePrefix As String

    Public Property OutputOptions As String

    Public Sub New(message As String, innerException As Exception, client As String, filePrefix As String, output As String)
        MyBase.New(message, innerException)
        Me.Client = client
        Me.FilePrefix = filePrefix
        Me.OutputOptions = output

        Me.Data.Add("Client", client)
        Me.Data.Add("FilePrefix", filePrefix)
        Me.Data.Add("Output", output)

    End Sub


End Class
