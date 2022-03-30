Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilUserActivity

    Public Shared Sub SetLogOut(pGsafeId As Integer, pIsSessionTimeout As Boolean)

        Dim zActivityLogId As Object = UtilGSafe.GetValue(pGsafeId, UtilGSafe.KeyName.EzyLoginActivityLogId)

        If IsNumeric(zActivityLogId) Then
            Dim zRow As rowTblEzyLoginactivitylog = TblEzyLoginactivitylog.LoadByPrimaryKey(zActivityLogId)
            zRow.colLastActivityDateTime = Now
            zRow.colUserLogout = Not pIsSessionTimeout
            TblEzyLoginactivitylog.Save(zRow)
        End If

    End Sub

    Public Shared Sub Update(pGsafeId As Integer)
        'Dim zLoginId As Integer = UtilGSafe.GetLoginId(pGSafeId)
        'Dim zSQL As String = "SELECT MAX(ID) FROM ezy_loginActivityLog WHERE (LoginID=@LoginID)"
        'Dim zCmd As New SqlClient.SqlCommand(zSQL, UtilSQLServer.GetConnectionObject)
        'zCmd.Parameters.AddWithValue("@LoginID", zLoginId)
        'Dim zID As Object = zCmd.ExecuteScalar

        Dim zActivityLogId As Object = UtilGSafe.GetValue(pGsafeId, UtilGSafe.KeyName.EzyLoginActivityLogId)
  
        If IsNumeric(zActivityLogId) Then
            Dim zRow As rowTblEzyLoginactivitylog = TblEzyLoginactivitylog.LoadByPrimaryKey(zActivityLogId)
            zRow.colLastActivityDateTime = Now
            TblEzyLoginactivitylog.Save(zRow)
        End If

    End Sub

    Public Shared Function Create(pGSafeId As Integer, pFilePrefix As String) As Integer
        Dim zRow As New rowTblEzyLoginactivitylog
        zRow.colFilePrefix = pFilePrefix
        zRow.colLastLoginDateTime = Now
        zRow.colLastActivityDateTime = zRow.colLastLoginDateTime
        zRow.colUserLogout = False
        zRow.colLoginID = UtilGSafe.GetLoginId(pGSafeId)
        TblEzyLoginactivitylog.Save(zRow)

        Return zRow.colId

    End Function

End Class
