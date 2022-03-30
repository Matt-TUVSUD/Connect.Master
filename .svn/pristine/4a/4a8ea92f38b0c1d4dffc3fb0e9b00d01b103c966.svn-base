Public Class BaseStoredProcedure

    Public Shared Function FireRecommendationExposure(ByVal pFilePrefix As String, ByVal pDivision As String, ByVal pCountry As String, ByVal pCustomAccess As String) As DataTable
        Dim zCmd As New SqlClient.SqlCommand("spFireRecommendationExposure @FilePrefix = " & pFilePrefix & ", @Division = " & IIf(pDivision = "", "'%'", "'" & pDivision & "'") & ", @Country=" & IIf(pCountry = "", "'%'", "'" & pCountry & "'") & ",@CustomAccess=" & IIf(pCustomAccess = "", "'%'", "'" & pCustomAccess & "'"))
        Return Core.UtilDB.ExecuteProcedure(zCmd)
    End Function

    Public Shared Function BMRecommendationExposure(ByVal pFilePrefix As String, ByVal pDivision As String, ByVal pCountry As String, ByVal pCustomAccess As String) As DataTable
        Dim zCmd As New SqlClient.SqlCommand("spBMRecommendationExposure @FilePrefix = " & pFilePrefix & ", @Division = " & IIf(pDivision = "", "'%'", "'" & pDivision & "'") & ", @Country=" & IIf(pCountry = "", "'%'", "'" & pCountry & "'") & ",@CustomAccess=" & IIf(pCustomAccess = "", "'%'", "'" & pCustomAccess & "'"))
        Return Core.UtilDB.ExecuteProcedure(zCmd)
    End Function

    Public Shared Function FireRecommendationCountByRecStatus(ByVal pFilePrefix As String, ByVal pDivision As String, ByVal pCountry As String, ByVal pCustomAccess As String) As DataTable
        Dim zCmd As New SqlClient.SqlCommand("spFireRecommendationCountByRecStatus @FilePrefix = " & pFilePrefix & ", @Division = " & IIf(pDivision = "", "'%'", "'" & pDivision & "'") & ", @Country=" & IIf(pCountry = "", "'%'", "'" & pCountry & "'") & ",@CustomAccess=" & IIf(pCustomAccess = "", "'%'", "'" & pCustomAccess & "'"))
        Return Core.UtilDB.ExecuteProcedure(zCmd)
    End Function

    Public Shared Function BMRecommendationCountByRecStatus(ByVal pFilePrefix As String, ByVal pDivision As String, ByVal pCountry As String, ByVal pCustomAccess As String) As DataTable
        Dim zCmd As New SqlClient.SqlCommand("spBMRecommendationCountByRecStatus @FilePrefix = " & pFilePrefix & ", @Division = " & IIf(pDivision = "", "'%'", "'" & pDivision & "'") & ", @Country=" & IIf(pCountry = "", "'%'", "'" & pCountry & "'") & ",@CustomAccess=" & IIf(pCustomAccess = "", "'%'", "'" & pCustomAccess & "'"))
        Return Core.UtilDB.ExecuteProcedure(zCmd)
    End Function


End Class
