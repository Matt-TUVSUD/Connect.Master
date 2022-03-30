Public Class FileNotInWorkloadException
    Inherits ApplicationException

    Public Property FileNo

    Public Sub New(pFileNo As String)
        MyBase.New("FileNo [" & pFileNo & "] not in GRIPSS Workload.")
        Me.FileNo = pFileNo
        Me.Data.Add("FileNo", pFileNo)
    End Sub

End Class
