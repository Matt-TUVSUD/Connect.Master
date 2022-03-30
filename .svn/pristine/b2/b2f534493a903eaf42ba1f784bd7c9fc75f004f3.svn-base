Public Class UtilRating
    
     Public Shared Function GetRatingID(ByVal FilePrefix As String, ByVal Practice As UtilPractice.PracticeEnum) As Integer
          Dim zFilePrefix As String = Int(FilePrefix)
          Dim zClient As New BusinessObjects.ClientsQuery
          Dim zResult As String

          Select Case Practice
               Case UtilPractice.PracticeEnum.Fire
                    zClient.Select(zClient.FireRatingKeyID)
               Case UtilPractice.PracticeEnum.BM
                    zClient.Select(zClient.BMRatingKeyID)
               Case Else
                    Return 0
          End Select

          zClient.Where(zClient.Fileprefix = zFilePrefix)
          zResult = zClient.ExecuteScalar.ToString
          Return CInt(zResult)

     End Function


    Public Shared Function GetFireFacilityRatingAverages(pFileNo As String) As List(Of RatingAchievableAverage)

        Dim zCmd As New SqlClient.SqlCommand("spGetFireFacilityRatingAverages", razor.UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@FileNo", pFileNo))

        Dim zDT As DataTable = razor.UtilSQLServer.ExecuteDataTable(zCmd)
        Dim zList As New List(Of RatingAchievableAverage)
        For Each zRow As DataRow In zDT.Rows
            Dim zA As New RatingAchievableAverage(zRow("fldLabel"), zRow("fldValue1"), zRow("fldValue2"), zRow("fldValue3"), zRow("fldValue4"), zRow("fldVisible"))
            zList.Add(zA)
        Next

        Return zList
    End Function

    Public Shared Function GetFireFacilityRatingInfo(pFileNo As String) As List(Of FireFacilityRatingItem)

        Dim zCmd As New SqlClient.SqlCommand("spGetFireFacilityRatingInfo", razor.UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@FileNo", pFileNo))

        Dim zDT As DataTable = razor.UtilSQLServer.ExecuteDataTable(zCmd)
        Dim zList As New List(Of FireFacilityRatingItem)
        For Each zRow As DataRow In zDT.Rows
            Dim zA As New FireFacilityRatingItem(zRow("FileNo"), zRow("DisplayText"), zRow("DisplayValue"), zRow("BackColor"), zRow("ForeColor"), zRow("SortOrder"))
            zList.Add(zA)
        Next

        Return zList

    End Function

    Public Shared Function GetTotaFirelFacilityScoreAverages(pFileNo As String) As DataTable

        Dim zCmd As New SqlClient.SqlCommand("spGetFireFacilityRatingAverages", razor.UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@FileNo", pFileNo))

        Dim zDT As DataTable = razor.UtilSQLServer.ExecuteDataTable(zCmd)
        Return zDT
    End Function

    Public Shared Function GetTotalClientFireScoreAverages(pId As String, pLocListKeyType As LocListKeyId) As DataTable

        Dim zCmd As New SqlClient.SqlCommand("spGetFireClientRatingAverages", razor.UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@Id", pId))
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@Type", pLocListKeyType))
        Dim zDT As DataTable = razor.UtilSQLServer.ExecuteDataTable(zCmd)
        Return zDT
    End Function

    Public Shared Function GetFireSummaryRatingAveragesByTivAndLoc(pSafeGuid As String, pBatchSetId As Integer, pFilePrefix As String) As List(Of FireRatingAveragesByTivAndLocItem)

        Dim zCmd As New SqlClient.SqlCommand("spLegendFireFacilityRatingSummarySelect", razor.UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@GSafeGUID", pSafeGuid))
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@BatchSetID", pBatchSetId))
        zCmd.Parameters.Add(New SqlClient.SqlParameter("@FilePrefix", pFilePrefix))
        Dim zDT As DataTable = Nothing

        Using zCmd.Connection
            Using zCmd
                zDT = razor.UtilSQLServer.ExecuteDataTable(zCmd)
            End Using
        End Using

        Dim zList As New List(Of FireRatingAveragesByTivAndLocItem)
        For Each zRow As DataRow In zDT.Rows
            Dim zA As New FireRatingAveragesByTivAndLocItem(zRow("RatingText"), zRow("RatingId"), zRow("RatingDesc"), zRow("RatingHexColor"), zRow("RatingHexForeColor"), zRow("PercentByTIV"), zRow("PercentByLocations"))
            zList.Add(zA)
        Next

        Return zList
    End Function

    Public Shared Function GetFireDetailRatingWeights(pFilePrefix As String) As List(Of FireRatingWeightItem)

        Dim zList As New List(Of FireRatingWeightItem)
        Dim zCmd As New SqlClient.SqlCommand("spLegendFireFacilityRatingDetailSelect", razor.UtilSQLServer.GetConnectionObject)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.Parameters.AddWithValue("@FilePrefix", pFilePrefix)
        Dim zDT As New DataTable

        Using zCmd.Connection
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using

        For Each zRow As DataRow In zDT.Rows
            Dim zItem As New FireRatingWeightItem
            With zItem
                .SortOrder = zRow("SortOrder")
                .BCP = zRow("fldBusinessContinuityWeightGRC")
                .Construction = zRow("fldConstructionWeightGRC")
                .Earthquake = zRow("fldEarthquakeWeightGRC")
                .FilePrefix = zRow("FilePrefix")
                .Flood = zRow("fldFloodWeightGRC")
                .HumanElement = zRow("fldHumanElementWeightGRC")
                .NatHaz = zRow("fldNaturalHazardsProtectionWeightGRC")
                .Occupancy = zRow("fldOccupancyWeightGRC")
                .Other = zRow("fldOtherWeightGRC")
                .PhysicalProt = zRow("fldPhysicalProtectionWeightGRC")
                .Type = zRow("Type")
                .Windstorm = zRow("fldWindstormWeightGRC")
            End With
            zList.Add(zItem)
        Next

        Return zList.OrderBy(Function(x) x.SortOrder).ToList

    End Function

    Public Enum LocListKeyId
        GSafeId = 1
        BatchSetId = 2
    End Enum

End Class


Public Class RatingAchievableAverage
    Public Property Label As String = ""
    Public Property Value1 As String = ""
    Public Property Value2 As String = ""
    Public Property Value3 As String = ""
    Public Property Value4 As String = ""
    Public Property IsVisible As Boolean = True

    Public Sub New(pLabel As String, pValue1 As String, pValue2 As String, pValue3 As String, pValue4 As String, pIsVisible As Boolean)
        Me.Label = pLabel
        Me.Value1 = pValue1
        Me.Value2 = pValue2
        Me.Value3 = pValue3
        Me.Value4 = pValue4
        Me.IsVisible = pIsVisible
    End Sub
End Class

Public Class FireFacilityRatingItem
    Public Property FileNo As String = ""
    Public Property DisplayText As String = ""
    Public Property DisplayValue As String = ""
    Public Property BackColorHex As String = ""
    Public Property ForeColorHex As String = ""
    Public Property SortOrder As Integer = 0

    Public Sub New(pFileNo As String, pDisplayText As String, pDisplayValue As String, pBackColorHex As String, pForeColorHex As String, pSortOrder As Integer)
        Me.FileNo = pFileNo
        Me.DisplayText = pDisplayText
        Me.DisplayValue = pDisplayValue
        Me.BackColorHex = pBackColorHex
        Me.ForeColorHex = pForeColorHex
        Me.SortOrder = pSortOrder
    End Sub

End Class

Public Class FireRatingAveragesByTivAndLocItem
    Public Property RatingText As String
    Public Property RatingId As String
    Public Property RatingDesc As String
    Public Property RatingHexColor As String
    Public Property RatingHexForeColor As String
    Public Property PercentByTIV As String
    Public Property PercentByLocations As String

    Public Sub New(pRatingText As String, pRatingId As String, pRatingDesc As String, pRatingHexColor As String, pRatingHexForeColor As String, pPercentByTIV As String, pPercentByLocation As String)
        With Me
            .RatingText = pRatingText
            .RatingId = pRatingId
            .RatingDesc = pRatingDesc
            .RatingHexColor = pRatingHexColor
            .RatingHexForeColor = pRatingHexForeColor
            .PercentByTIV = pPercentByTIV
            .PercentByLocations = pPercentByLocation
        End With
    End Sub

End Class

Public Class FireRatingWeightItem
    Public Property Type As String
    Public Property FilePrefix As String
    Public Property SortOrder As Int16
    Public Property PhysicalProt As String
    Public Property HumanElement As String
    Public Property NatHaz As String
    Public Property BCP As String
    Public Property Flood As String
    Public Property Earthquake As String
    Public Property Windstorm As String
    Public Property Construction As String
    Public Property Occupancy As String
    Public Property Other As String
End Class




