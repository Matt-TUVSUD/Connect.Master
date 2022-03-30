Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilBatchProcessSetException
    Inherits ApplicationException

    Public BatchSet As BatchSet

    Public Sub New(pMessage As String, pBatchSet As rowTblBatchProcessingSet, pInnerException As Exception)
        MyBase.New(pMessage, pInnerException)
        BatchSet = pBatchSet
    End Sub
End Class
