Partial Class UtilBatchProcess
    Public Interface IExternalReport
        Function RunReport(pSetItem As GRC.Connect.Libraries.DataLib.razor.rowTblBatchProcessingSetItem) As Byte()
    End Interface
End Class
