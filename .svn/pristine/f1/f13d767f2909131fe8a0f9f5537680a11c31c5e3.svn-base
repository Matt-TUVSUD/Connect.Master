Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Public Class BatchSetItem
    Inherits rowTblBatchProcessingSetItem

    Public ExtendedProperty As New ExtendedProperties
    Public Parent As BatchSet
    Public MetaObject As Object

    Public Sub New()
        Me.colExtendedPropJSON = ""
    End Sub

    Public Property Status As BatchSet.BatchStatus
        Get
            Return CType(Me.colFldStatusId, BatchSet.BatchStatus)
        End Get
        Set(value As BatchSet.BatchStatus)
            Me.colFldStatusId = value
            LogStatusChange(value)
        End Set
    End Property

    Private Sub LogStatusChange(pNewStatus As BatchSet.BatchStatus)
        TblBatchProcessingSetItem.Save(Me)
        If TypeOf Me.MetaObject Is rowTblMetaReport Then
            UtilBatchProcess.WriteLog(Me.colFldSetId, "Change Status [" & DirectCast(Me.MetaObject, rowTblMetaReport).colFldName & "] to " & pNewStatus.ToString)
        Else
            UtilBatchProcess.WriteLog(Me.colFldSetId, "Change Status [" & DirectCast(Me.MetaObject, rowTblMetaGrid).colFldGridName & "] to " & pNewStatus.ToString)
        End If
    End Sub

    Public Shared Sub Delete(pSetId As Integer)
        Dim zSQL As String = ""
        Dim zMode As String = ""

        'Delete
        zMode = "DELETE"
        zSQL = "DELETE FROM [dbo].[tblBatchProcessingSetItem] " & _
                "WHERE [fldSetId] = @colSetId"

        Dim zCmd As New SqlCommand
        zCmd.CommandText = zSQL
        zCmd.Parameters.Add(New SqlParameter("@colSetId", pSetId))

        UtilSQLServer.ExecuteNonQuery(zCmd)

    End Sub

    Private Sub BatchSetItem_Loaded() Handles Me.Loaded
        Me.ExtendedProperty = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ExtendedProperties)(Me.colExtendedPropJSON)
    End Sub

End Class
