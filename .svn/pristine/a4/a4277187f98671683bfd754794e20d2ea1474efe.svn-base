Imports GRC.Connect.Libraries.DataLib.razor

''' <summary>
''' This class is responsible for getting the counts for items listed in the Updates box on the Carousel page
''' </summary>
''' <remarks></remarks>
Public Class UtilUpdates

    Public Shared Function GetCounts(pGSafeGuid As String) As UpdateResult
        Dim zCon As SqlClient.SqlConnection = DataLib.razor.UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand("spGetUpdateCounts", zCon)
        Dim zDT As New DataTable
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@SafeGuid", pGSafeGuid)

        Using zCon
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using

        zDT.PrimaryKey = {zDT.Columns(0)}
        Dim zResult As New UpdateResult
        With zResult
            .SafeGuid = zDT.Rows.Find("SafeGuid")(1)
            .SafeId = zDT.Rows.Find("SafeId")(1)
            .BatchReportNewCount = zDT.Rows.Find("BatchReportNewCount")(1)
            .EzyUserId = zDT.Rows.Find("EzyUserId")(1)
            .EzyLoginId = zDT.Rows.Find("EzyLoginId")(1)
            .FilePrefix = zDT.Rows.Find("FilePrefix")(1)
            .DocLibLastReviewedDate = zDT.Rows.Find("DocLibLastReviewedDate")(1)
            .DocLibNewCount = zDT.Rows.Find("DocLibNewCount")(1)
            .WhatsNewLastReviewedDate = zDT.Rows.Find("WhatsNewLastReviewedDate")(1)
            .WhatsNewCount = zDT.Rows.Find("WhatsNewCount")(1)
        End With

        Return zResult
    End Function

    Public Shared Sub SetDocLibLastReviewedDate(pGSafeGuid As String)
        Dim zEzyUserId As Integer = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.EzyUserId)
        Dim zFilePrefix As Integer = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
        Dim zList As List(Of razor.rowTblEzyUserstracking) = TblEzyUserstracking.LoadByIDX_idx_Ezyuserid_FilePrefix(zEzyUserId, zFilePrefix)
        Dim zRow As New rowTblEzyUserstracking
        If zList.Count > 0 Then
            zRow = zList(0)
            zRow.colDocLibLastReviewedDate = Now
        Else
            zRow.colEzyUserID = zEzyUserId
            zRow.colFilePrefix = zFilePrefix
            zRow.colDocLibLastReviewedDate = Now
        End If

        TblEzyUserstracking.Save(zRow)

    End Sub

    Public Shared Sub SetWhatsNewLastReviewedDate(pGSafeGuid As String)
        Dim zLoginId As Integer = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.EzyLoginId)
        Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(zLoginId)
        zLogin.colWhatsNewLastReviewedDate = Now
        TblEzyLogin.Save(zLogin)
    End Sub

    Public Class UpdateResult
        Public SafeGuid As String
        Public SafeId As Integer
        Public BatchReportNewCount As Integer
        Public EzyUserId As Integer
        Public EzyLoginId As Integer
        Public FilePrefix As Integer
        Public DocLibLastReviewedDate As DateTime
        Public DocLibNewCount As Integer
        Public WhatsNewLastReviewedDate As DateTime
        Public WhatsNewCount As Integer
    End Class

    Public Enum UpdateCounterType
        MyBatchReportNewCount
        WhatsNewCount
        RecentUpdateNewCount
    End Enum
End Class
