Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilBatchProcess
    Public Class ExternalReports
        Public Class ProjectManagementReport
            Implements BatchLib.UtilBatchProcess.IExternalReport

            Public Function RunReport(pSetItem As rowTblBatchProcessingSetItem) As Byte() Implements IExternalReport.RunReport
                Dim zSet As rowTblBatchProcessingSet = TblBatchProcessingSet.LoadByPrimaryKey(pSetItem.colFldSetId)
                Dim zFileNo As List(Of rowTblBatchProcessingFileNo) = TblBatchProcessingFileNo.LoadByIDX_IX_tblBatchProcessingFileNo_fldSetID(pSetItem.colFldSetId)
                Dim zByte(0) As Byte

                If zFileNo.Count > 0 Then                  
                    zByte = GRC.Connect.Libraries.PMLib.UtilPM.RunReport(zFileNo(0).colFldFileNo)
                End If
                Return zByte
            End Function
        End Class
    End Class

End Class
