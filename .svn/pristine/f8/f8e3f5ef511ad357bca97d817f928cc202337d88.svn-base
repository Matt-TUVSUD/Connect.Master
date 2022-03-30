Public Class UtilJobException
    Inherits ApplicationException

    Public Job As rowTblJob

    Public Sub New(pException As Exception, pJob As rowTblJob)
        MyBase.New(pException.GetBaseException.Message, pException)
        Job = pJob
    End Sub

End Class
