Imports System.Data.SqlClient
Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilSafe
    <Obsolete("This method is deprecated, use SaveLargeObjectData_ByDataGroup instead.")>
    Public Shared Sub SaveLargeObjectData(pSafeId As Integer, pObjectName As String, pLargeObject As String, pDataGroup As String)
        Dim zGSafeLO As New rowGSafeLO
        zGSafeLO = tblGSafeLO.LoadByPrimaryKey(pSafeId, pObjectName, pDataGroup)

        zGSafeLO.colGSafeId = pSafeId
        zGSafeLO.colDataName = pObjectName
        zGSafeLO.colDataValue = pLargeObject
        zGSafeLO.colDataGroup = pDataGroup

        tblGSafeLO.Save(zGSafeLO)
    End Sub

    Public Shared Sub SaveLargeObjectData_ByDataGroup(pSafeId As Integer, pObjectName As String, pLargeObject As String, pDataGroup As String)
        Dim zGSafeLOList As New List(Of rowGSafeLO)
        Dim zGSafeLO As New rowGSafeLO
        'zGSafeLO = tblGSafeLO.LoadByPrimaryKey(pSafeId, pObjectName)
        Dim zCmd As New SqlClient.SqlCommand
        zCmd.CommandText = "SELECT * FROM GSafeLO WHERE GSafeId = @GSafeId AND DataName = @DataName AND DataGroup = @DataGroup"
        zCmd.Parameters.AddWithValue("@GSafeId", pSafeId)
        zCmd.Parameters.AddWithValue("@DataName", pObjectName)
        zCmd.Parameters.AddWithValue("@DataGroup", pDataGroup)
        zGSafeLOList = tblGSafeLO.LoadData(zCmd)
        If zGSafeLOList.Count > 0 Then
            zGSafeLO.colGSafeId = zGSafeLOList(0).colGSafeId
            zGSafeLO.colDataName = zGSafeLOList(0).colDataName
            zGSafeLO.colDataValue = zGSafeLOList(0).colDataValue
            zGSafeLO.colDataGroup = zGSafeLOList(0).colDataGroup
        End If

        If pLargeObject Is Nothing Then
            pLargeObject = ""
        End If

        zGSafeLO.colGSafeId = pSafeId
        zGSafeLO.colDataName = pObjectName
        zGSafeLO.colDataValue = pLargeObject
        zGSafeLO.colDataGroup = pDataGroup

        tblGSafeLO.Save(zGSafeLO)
    End Sub

    <Obsolete("This method is deprecated, use LoadLargeObjectData_ByDataGroup instead.")>
    Public Shared Function LoadLargeObjectData(pSafeId As Integer, pObjectName As String, pDataGroup As String) As String
        Dim zGSafeLO As New rowGSafeLO
        zGSafeLO = tblGSafeLO.LoadByPrimaryKey(pSafeId, pObjectName, pDataGroup)

        Return zGSafeLO.colDataValue & ""
    End Function

    Public Shared Function LoadLargeObjectData_ByDataGroup(pSafeId As Integer, pObjectName As String, pDataGroup As String) As String
        Dim zReturn As String = ""

        Dim zGSafeLO As New List(Of rowGSafeLO)
        Dim zCmd As New SqlClient.SqlCommand
        zCmd.CommandText = "SELECT * FROM GSafeLO WHERE GSafeId = @GSafeId AND DataName = @DataName AND DataGroup = @DataGroup"
        zCmd.Parameters.AddWithValue("@GSafeId", pSafeId)
        zCmd.Parameters.AddWithValue("@DataName", pObjectName)
        zCmd.Parameters.AddWithValue("@DataGroup", pDataGroup)
        zGSafeLO = tblGSafeLO.LoadData(zCmd)

        If zGSafeLO.Count = 1 Then
            zReturn = zGSafeLO(0).colDataValue & ""
        End If
        Return zReturn
    End Function

    Public Shared Function ResetLargeObjectData_ByObjectName(pSafeId As Integer, pObjectName As String) As Integer
        Dim zGSafeLO As New List(Of rowGSafeLO)
        Dim zCmd As New SqlClient.SqlCommand
        zCmd.CommandText = "DELETE FROM GSafeLO WHERE GSafeId = @GSafeId AND DataName = @DataName"
        zCmd.Parameters.AddWithValue("@GSafeId", pSafeId)
        zCmd.Parameters.AddWithValue("@DataName", pObjectName)
        Return UtilSQLServer.ExecuteNonQuery(zCmd)
    End Function

    Public Shared Function ResetLargeObjectData(pSafeId As Integer) As Integer
        Dim zGSafeLO As New List(Of rowGSafeLO)
        Dim zCmd As New SqlClient.SqlCommand
        zCmd.CommandText = "DELETE FROM GSafeLO WHERE GSafeId = @GSafeId"
        zCmd.Parameters.AddWithValue("@GSafeId", pSafeId)
        Return UtilSQLServer.ExecuteNonQuery(zCmd)
    End Function

    Public Class LargeObjectName
        Public Shared Property chartHTML As String = "chartHTML"
        Public Shared Property columnOrder As String = "columnOrder"
        Public Shared Property columnOrderChart As String = "columnOrderChart"
        Public Shared Property criteria As String = "criteria"
        Public Shared Property criteriaChart As String = "criteriaChart"
        Public Shared Property criteriaMap As String = "criteriaMap"
        Public Shared Property criteriaPrimary As String = "criteriaPrimary"
        Public Shared Property filter As String = "filter"
        Public Shared Property filterChart As String = "filterChart"
        Public Shared Property filterMap As String = "filterMap"
        Public Shared Property meta As String = "meta"
        Public Shared Property setting As String = "setting"
        Public Shared Property settingChart As String = "settingChart"
        Public Shared Property sort As String = "sort"
        Public Shared Property virtualFilter As String = "virtualFilter"
        Public Shared Property virtualFilterChart As String = "virtualFilterChart"

    End Class

End Class

