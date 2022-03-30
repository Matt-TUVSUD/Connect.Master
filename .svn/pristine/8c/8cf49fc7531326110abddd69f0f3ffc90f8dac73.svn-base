
Imports System.Data.SqlClient

Namespace razor
    Partial Public Class TblBatchProcessingFileNo
        Public Shared Sub DeleteBySetId(pSetId As Integer)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [dbo].[tblBatchProcessingFileNo] " & _
                    "WHERE [fldSetId] = @colSetId"

            Dim zCmd As New SqlCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colSetId", pSetId))

            razor.UtilSQLServer.ExecuteNonQuery(zCmd)

        End Sub
    End Class

    Partial Public Class TblBatchProcessingEmail

        Public Shared Function LoadUnsent() As List(Of rowTblBatchProcessingEmail)
            Dim zReturn As New List(Of rowTblBatchProcessingEmail)
            Dim zSQL As New Text.StringBuilder
            With zSQL
                .Append("SELECT DISTINCT E.* FROM [dbo].[tblBatchProcessingEmail] E ")
                .Append("INNER JOIN dbo.tblBatchProcessingEmailSet ES ON E.FLDID=ES.FLDEMAILID ")
                .Append("INNER JOIN dbo.tblBatchProcessingSet B ON B.FLDID=ES.FLDSETID ")
                .Append("WHERE E.fldSentDate IS NULL AND E.fldHasException='False' AND B.fldStatusId=5")
            End With
            '  Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingEmail] WHERE fldSentDate IS NULL AND fldHasException='False'"
            Dim zCmd As New SqlCommand
            zCmd.CommandText = zSQL.ToString
            Return LoadData(zCmd)
        End Function
    End Class

    Partial Class TblBatchProcessingSetItem

        Public Shared Sub DeleteBySetId(pSetId As Integer)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            'Delete
            zMode = "DELETE"
            zSQL = "DELETE FROM [dbo].[tblBatchProcessingSetItem] " & _
                    "WHERE [fldSetId] = @colSetId"

            Dim zCmd As New SqlCommand
            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colSetId", pSetId))

            razor.UtilSQLServer.ExecuteNonQuery(zCmd)

        End Sub

        'Public Shared Function LoadItems(pSet As rowTblBatchProcessingSet) As List(Of rowTblBatchProcessingSetItem)
        '    Dim zList As List(Of rowTblBatchProcessingSetItem) = TblBatchProcessingSetItem.LoadByIDX_IX_fldSetId(pSet.colFldId)
        '    For Each zItem As rowTblBatchProcessingSetItem In zList
        '        zItem.Parent = pSet

        '        Select Case zItem.Parent.SetType
        '            Case TblBatchProcessingSet.SetType.XLSXExtract, TblBatchProcessingSet.SetType.CSVExtract, TblBatchProcessingSet.SetType.TXTExtract
        '                zItem.MetaObject = TblMetaGrid.LoadByPrimaryKey(zItem.colFldMetaObjectId)
        '            Case TblBatchProcessingSet.SetType.Report
        '                zItem.MetaObject = TblMetaReport.LoadByPrimaryKey(zItem.colFldMetaObjectId)
        '            Case Else
        '                Throw New ArgumentException("Application unable to set the MetaObject property due to batch processing unable to get object for set type [" & zItem.Parent.SetType.ToString & "].", "pItem.Parent.SetType")
        '        End Select
        '    Next
        '    Return zList
        'End Function

    End Class
End Namespace

