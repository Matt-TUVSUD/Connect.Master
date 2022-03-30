Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilBatchProcessSetItemException
    Inherits ApplicationException

    Public SetItem As BatchSetItem
    Public BatchSet As BatchSet

    Public Sub New(pMessage As String, pSetItem As rowTblBatchProcessingSetItem, pBatchSet As rowTblBatchProcessingSet, pInnerException As Exception)
        MyBase.New(pMessage, pInnerException)
        SetItem = pSetItem
        BatchSet = pBatchSet
    End Sub
End Class
