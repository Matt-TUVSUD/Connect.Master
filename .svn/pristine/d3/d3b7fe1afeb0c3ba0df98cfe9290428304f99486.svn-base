'/===============================================================\
'| razor data (experimental) - rev 4.2.881   EXPERIMENTAL        |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'|  Data Types not supported due to type mapping issues: money,  |
'| date, varchar(1), nvarchar(1)                                 |
'\===============================================================/
Imports System.Data.SqlClient

Namespace razor
    Partial Public Class VwFireLossEstimatesLatestFacilityRatingExtractSelect

        Public Shared Function LoadData() As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand)
            Return LoadData(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object)
            Return LoadData(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction)
            Return LoadData(pCommand,pTransaction,Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zReturn As New List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zSQL As String = "SELECT * FROM [gv].[vwFireLossEstimatesLatestFacilityRatingExtractSelect]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)

			Try
	            Dim zReturn As New List(Of rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwFireLossEstimatesLatestFacilityRatingExtractSelect

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwFireLossEstimatesLatestFacilityRatingExtractSelect		
	                            ReadDataRow(zReader,zObj)											
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn

			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next
				Throw
			End Try

        End function

        Public Shared Function ReadData(Of T)(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of T)

			Try
	            Dim zReturn As New List(Of T)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As Object = Activator.CreateInstance(Of T)()

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj  = Activator.CreateInstance(Of T)()	
	                            ReadDataRow(zReader,zObj)					
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While			
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn
			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next				
				Throw
			End Try

        End function

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwFireLossEstimatesLatestFacilityRatingExtractSelect)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Client")) Then pObject.colClient = UtilSQLServer.SafeReader.SafeReadString(pReader, "Client")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address")) Then pObject.colAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Latitude")) Then pObject.colLatitude = UtilSQLServer.SafeReader.SafeReadString(pReader, "Latitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Longitude")) Then pObject.colLongitude = UtilSQLServer.SafeReader.SafeReadString(pReader, "Longitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BIReporting")) Then pObject.colBIReporting = UtilSQLServer.SafeReader.SafeReadString(pReader, "BIReporting")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APL")) Then pObject.colApl = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLPD")) Then pObject.colAplpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLBI")) Then pObject.colAplbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLPercent")) Then pObject.colAPLPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLPDPercent")) Then pObject.colAPLPDPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLPDPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLBIPercent")) Then pObject.colAPLBIPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLBIPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PML")) Then pObject.colPml = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PML")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPD")) Then pObject.colPmlpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLBI")) Then pObject.colPmlbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPercent")) Then pObject.colPMLPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPDPercent")) Then pObject.colPMLPDPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPDPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLBIPercent")) Then pObject.colPMLBIPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLBIPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFL")) Then pObject.colMfl = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPD")) Then pObject.colMflpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLBI")) Then pObject.colMflbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPercent")) Then pObject.colMFLPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPDPercent")) Then pObject.colMFLPDPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPDPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLBIPercent")) Then pObject.colMFLBIPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLBIPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIV")) Then pObject.colTiv = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIV")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVPD")) Then pObject.colTivpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVBI")) Then pObject.colTivbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Interdependencies")) Then pObject.colInterdependencies = UtilSQLServer.SafeReader.SafeReadString(pReader, "Interdependencies")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LEandInterdependecyComments")) Then pObject.colLEandInterdependecyComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "LEandInterdependecyComments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Losses_Last_3_Years")) Then pObject.colLossesLast3Years = UtilSQLServer.SafeReader.SafeReadString(pReader, "Losses_Last_3_Years")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Loss_History_Description")) Then pObject.colLossHistoryDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "Loss_History_Description")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspectionDate")) Then pObject.colInspectionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "InspectionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveScore")) Then pObject.colActiveScore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "ActiveScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PassiveScore")) Then pObject.colPassiveScore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "PassiveScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TotalScore")) Then pObject.colTotalScore = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TotalScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OverallRating")) Then pObject.colOverallRating = UtilSQLServer.SafeReader.SafeReadString(pReader, "OverallRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("totalscoreColor")) Then pObject.colTotalscoreColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "totalscoreColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Occupancy")) Then pObject.colOccupancy = UtilSQLServer.SafeReader.SafeReadString(pReader, "Occupancy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IndustryGroup")) Then pObject.colIndustryGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "IndustryGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MajorGroup")) Then pObject.colMajorGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "MajorGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SpecificGroup")) Then pObject.colSpecificGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "SpecificGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Active_Score_With_Recs_Complete")) Then pObject.colActiveScoreWithRecsComplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Active_Score_With_Recs_Complete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OverallScoreWithRecsComplete")) Then pObject.colOverallScoreWithRecsComplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "OverallScoreWithRecsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MaxPossibleScore")) Then pObject.colMaxPossibleScore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "MaxPossibleScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Construction_Rating")) Then pObject.colConstructionRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Construction_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Occupancy_Rating")) Then pObject.colOccupancyRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Occupancy_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Flood_Rating")) Then pObject.colFloodRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Flood_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Earthquake_Rating")) Then pObject.colEarthquakeRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Earthquake_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Windstorm_Rating")) Then pObject.colWindstormRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Windstorm_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Other_Rating")) Then pObject.colOtherRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Other_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Physical_Protection_Rating")) Then pObject.colPhysicalProtectionRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Physical_Protection_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Human_Element_Rating")) Then pObject.colHumanElementRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Human_Element_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Natural_Hazards_Protection_Rating")) Then pObject.colNaturalHazardsProtectionRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Natural_Hazards_Protection_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Business_Continuity_Rating")) Then pObject.colBusinessContinuityRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Business_Continuity_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APL_Factor")) Then pObject.colAplFactor = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "APL_Factor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLFactorWithAllRecsComplete")) Then pObject.colAPLFactorWithAllRecsComplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "APLFactorWithAllRecsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Other_Weight")) Then pObject.colOtherWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Other_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Construction_Weight")) Then pObject.colConstructionWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Construction_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Occupancy_Weight")) Then pObject.colOccupancyWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Occupancy_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Physical_Protection_Weight")) Then pObject.colPhysicalProtectionWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Physical_Protection_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Human_Element_Weight")) Then pObject.colHumanElementWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Human_Element_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Natural_Hazards_Protection_Weight")) Then pObject.colNaturalHazardsProtectionWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Natural_Hazards_Protection_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Business_Continuity_Weight")) Then pObject.colBusinessContinuityWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Business_Continuity_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Fire_Protection_All_Recs_Complete_Rating")) Then pObject.colFireProtectionAllRecsCompleteRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Fire_Protection_All_Recs_Complete_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Human_Element_All_Recs_Complete_Rating")) Then pObject.colHumanElementAllRecsCompleteRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Human_Element_All_Recs_Complete_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Nat_Haz_Prot_All_Recs_Complete_Rating")) Then pObject.colNatHazProtAllRecsCompleteRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Nat_Haz_Prot_All_Recs_Complete_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BCP_All_Recs_Complet_Rating")) Then pObject.colBcpAllRecsCompletRating = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "BCP_All_Recs_Complet_Rating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Flood_Weight")) Then pObject.colFloodWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Flood_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Earthquake_Weight")) Then pObject.colEarthquakeWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Earthquake_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Windstorm_Weight")) Then pObject.colWindstormWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "Windstorm_Weight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspProgramYearFROM")) Then pObject.colInspProgramYearFROM = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "InspProgramYearFROM")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspProgramYear")) Then pObject.colInspProgramYear = UtilSQLServer.SafeReader.SafeReadString(pReader, "InspProgramYear")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievableScorePercent")) Then pObject.colAchievableScorePercent = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "AchievableScorePercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievableScorePercentString")) Then pObject.colAchievableScorePercentString = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievableScorePercentString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsLatestRating")) Then pObject.colIsLatestRating = UtilSQLServer.SafeReader.SafeReadString(pReader, "IsLatestRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IBI")) Then pObject.colIbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "IBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HighestLossExpectancy")) Then pObject.colHighestLossExpectancy = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "HighestLossExpectancy")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"


        Public Shared Function LoadData(Of T)(pSQL As String) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)() As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadData(Of T)(pCommand, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [gv].[vwFireLossEstimatesLatestFacilityRatingExtractSelect]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwFireLossEstimatesLatestFacilityRatingExtractSelect
        Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect

        Public Event Loaded(pUserState As Object) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFilePrefix() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colFilePrefix
            Get
                Return m_colFilePrefix
            End Get
            Set
                If Not Same(m_colFilePrefix, Value) Then
                    m_colFilePrefix = Value
                    m_IsDirty(FieldIndex.colFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFilePrefix As String

        Public Property colFileNo() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colFileNo
            Get
                Return m_colFileNo
            End Get
            Set
                If Not Same(m_colFileNo, Value) Then
                    m_colFileNo = Value
                    m_IsDirty(FieldIndex.colFileNo) = True
                End If
            End Set
        End Property
        Private m_colFileNo As String

        Public Property colClient() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colClient
            Get
                Return m_colClient
            End Get
            Set
                If Not Same(m_colClient, Value) Then
                    m_colClient = Value
                    m_IsDirty(FieldIndex.colClient) = True
                End If
            End Set
        End Property
        Private m_colClient As String

        Public Property colClientLocNo() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colClientLocNo
            Get
                Return m_colClientLocNo
            End Get
            Set
                If Not Same(m_colClientLocNo, Value) Then
                    m_colClientLocNo = Value
                    m_IsDirty(FieldIndex.colClientLocNo) = True
                End If
            End Set
        End Property
        Private m_colClientLocNo As String

        Public Property colDivision() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colDivision
            Get
                Return m_colDivision
            End Get
            Set
                If Not Same(m_colDivision, Value) Then
                    m_colDivision = Value
                    m_IsDirty(FieldIndex.colDivision) = True
                End If
            End Set
        End Property
        Private m_colDivision As String

        Public Property colFacility() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colFacility
            Get
                Return m_colFacility
            End Get
            Set
                If Not Same(m_colFacility, Value) Then
                    m_colFacility = Value
                    m_IsDirty(FieldIndex.colFacility) = True
                End If
            End Set
        End Property
        Private m_colFacility As String

        Public Property colAddress() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAddress
            Get
                Return m_colAddress
            End Get
            Set
                If Not Same(m_colAddress, Value) Then
                    m_colAddress = Value
                    m_IsDirty(FieldIndex.colAddress) = True
                End If
            End Set
        End Property
        Private m_colAddress As String

        Public Property colCity() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colCity
            Get
                Return m_colCity
            End Get
            Set
                If Not Same(m_colCity, Value) Then
                    m_colCity = Value
                    m_IsDirty(FieldIndex.colCity) = True
                End If
            End Set
        End Property
        Private m_colCity As String

        Public Property colStProv() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colStProv
            Get
                Return m_colStProv
            End Get
            Set
                If Not Same(m_colStProv, Value) Then
                    m_colStProv = Value
                    m_IsDirty(FieldIndex.colStProv) = True
                End If
            End Set
        End Property
        Private m_colStProv As String

        Public Property colCountry() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colCountry
            Get
                Return m_colCountry
            End Get
            Set
                If Not Same(m_colCountry, Value) Then
                    m_colCountry = Value
                    m_IsDirty(FieldIndex.colCountry) = True
                End If
            End Set
        End Property
        Private m_colCountry As String

        Public Property colLatitude() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colLatitude
            Get
                Return m_colLatitude
            End Get
            Set
                If Not Same(m_colLatitude, Value) Then
                    m_colLatitude = Value
                    m_IsDirty(FieldIndex.colLatitude) = True
                End If
            End Set
        End Property
        Private m_colLatitude As String

        Public Property colLongitude() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colLongitude
            Get
                Return m_colLongitude
            End Get
            Set
                If Not Same(m_colLongitude, Value) Then
                    m_colLongitude = Value
                    m_IsDirty(FieldIndex.colLongitude) = True
                End If
            End Set
        End Property
        Private m_colLongitude As String

        Public Property colBIReporting() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colBIReporting
            Get
                Return m_colBIReporting
            End Get
            Set
                If Not Same(m_colBIReporting, Value) Then
                    m_colBIReporting = Value
                    m_IsDirty(FieldIndex.colBIReporting) = True
                End If
            End Set
        End Property
        Private m_colBIReporting As String

        Public Property colApl() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colApl
            Get
                Return m_colApl
            End Get
            Set
                If Not Same(m_colApl, Value) Then
                    m_colApl = Value
                    m_IsDirty(FieldIndex.colApl) = True
                End If
            End Set
        End Property
        Private m_colApl As Nullable(Of Double)

        Public Property colAplpd() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAplpd
            Get
                Return m_colAplpd
            End Get
            Set
                If Not Same(m_colAplpd, Value) Then
                    m_colAplpd = Value
                    m_IsDirty(FieldIndex.colAplpd) = True
                End If
            End Set
        End Property
        Private m_colAplpd As Nullable(Of Double)

        Public Property colAplbi() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAplbi
            Get
                Return m_colAplbi
            End Get
            Set
                If Not Same(m_colAplbi, Value) Then
                    m_colAplbi = Value
                    m_IsDirty(FieldIndex.colAplbi) = True
                End If
            End Set
        End Property
        Private m_colAplbi As Nullable(Of Double)

        Public Property colAPLPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAPLPercent
            Get
                Return m_colAPLPercent
            End Get
            Set
                If Not Same(m_colAPLPercent, Value) Then
                    m_colAPLPercent = Value
                    m_IsDirty(FieldIndex.colAPLPercent) = True
                End If
            End Set
        End Property
        Private m_colAPLPercent As Nullable(Of Double)

        Public Property colAPLPDPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAPLPDPercent
            Get
                Return m_colAPLPDPercent
            End Get
            Set
                If Not Same(m_colAPLPDPercent, Value) Then
                    m_colAPLPDPercent = Value
                    m_IsDirty(FieldIndex.colAPLPDPercent) = True
                End If
            End Set
        End Property
        Private m_colAPLPDPercent As Nullable(Of Double)

        Public Property colAPLBIPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAPLBIPercent
            Get
                Return m_colAPLBIPercent
            End Get
            Set
                If Not Same(m_colAPLBIPercent, Value) Then
                    m_colAPLBIPercent = Value
                    m_IsDirty(FieldIndex.colAPLBIPercent) = True
                End If
            End Set
        End Property
        Private m_colAPLBIPercent As Nullable(Of Double)

        Public Property colPml() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPml
            Get
                Return m_colPml
            End Get
            Set
                If Not Same(m_colPml, Value) Then
                    m_colPml = Value
                    m_IsDirty(FieldIndex.colPml) = True
                End If
            End Set
        End Property
        Private m_colPml As Nullable(Of Double)

        Public Property colPmlpd() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPmlpd
            Get
                Return m_colPmlpd
            End Get
            Set
                If Not Same(m_colPmlpd, Value) Then
                    m_colPmlpd = Value
                    m_IsDirty(FieldIndex.colPmlpd) = True
                End If
            End Set
        End Property
        Private m_colPmlpd As Nullable(Of Double)

        Public Property colPmlbi() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPmlbi
            Get
                Return m_colPmlbi
            End Get
            Set
                If Not Same(m_colPmlbi, Value) Then
                    m_colPmlbi = Value
                    m_IsDirty(FieldIndex.colPmlbi) = True
                End If
            End Set
        End Property
        Private m_colPmlbi As Nullable(Of Double)

        Public Property colPMLPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPMLPercent
            Get
                Return m_colPMLPercent
            End Get
            Set
                If Not Same(m_colPMLPercent, Value) Then
                    m_colPMLPercent = Value
                    m_IsDirty(FieldIndex.colPMLPercent) = True
                End If
            End Set
        End Property
        Private m_colPMLPercent As Nullable(Of Double)

        Public Property colPMLPDPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPMLPDPercent
            Get
                Return m_colPMLPDPercent
            End Get
            Set
                If Not Same(m_colPMLPDPercent, Value) Then
                    m_colPMLPDPercent = Value
                    m_IsDirty(FieldIndex.colPMLPDPercent) = True
                End If
            End Set
        End Property
        Private m_colPMLPDPercent As Nullable(Of Double)

        Public Property colPMLBIPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPMLBIPercent
            Get
                Return m_colPMLBIPercent
            End Get
            Set
                If Not Same(m_colPMLBIPercent, Value) Then
                    m_colPMLBIPercent = Value
                    m_IsDirty(FieldIndex.colPMLBIPercent) = True
                End If
            End Set
        End Property
        Private m_colPMLBIPercent As Nullable(Of Double)

        Public Property colMfl() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMfl
            Get
                Return m_colMfl
            End Get
            Set
                If Not Same(m_colMfl, Value) Then
                    m_colMfl = Value
                    m_IsDirty(FieldIndex.colMfl) = True
                End If
            End Set
        End Property
        Private m_colMfl As Nullable(Of Double)

        Public Property colMflpd() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMflpd
            Get
                Return m_colMflpd
            End Get
            Set
                If Not Same(m_colMflpd, Value) Then
                    m_colMflpd = Value
                    m_IsDirty(FieldIndex.colMflpd) = True
                End If
            End Set
        End Property
        Private m_colMflpd As Nullable(Of Double)

        Public Property colMflbi() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMflbi
            Get
                Return m_colMflbi
            End Get
            Set
                If Not Same(m_colMflbi, Value) Then
                    m_colMflbi = Value
                    m_IsDirty(FieldIndex.colMflbi) = True
                End If
            End Set
        End Property
        Private m_colMflbi As Nullable(Of Double)

        Public Property colMFLPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMFLPercent
            Get
                Return m_colMFLPercent
            End Get
            Set
                If Not Same(m_colMFLPercent, Value) Then
                    m_colMFLPercent = Value
                    m_IsDirty(FieldIndex.colMFLPercent) = True
                End If
            End Set
        End Property
        Private m_colMFLPercent As Nullable(Of Double)

        Public Property colMFLPDPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMFLPDPercent
            Get
                Return m_colMFLPDPercent
            End Get
            Set
                If Not Same(m_colMFLPDPercent, Value) Then
                    m_colMFLPDPercent = Value
                    m_IsDirty(FieldIndex.colMFLPDPercent) = True
                End If
            End Set
        End Property
        Private m_colMFLPDPercent As Nullable(Of Double)

        Public Property colMFLBIPercent() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMFLBIPercent
            Get
                Return m_colMFLBIPercent
            End Get
            Set
                If Not Same(m_colMFLBIPercent, Value) Then
                    m_colMFLBIPercent = Value
                    m_IsDirty(FieldIndex.colMFLBIPercent) = True
                End If
            End Set
        End Property
        Private m_colMFLBIPercent As Nullable(Of Double)

        Public Property colTiv() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colTiv
            Get
                Return m_colTiv
            End Get
            Set
                If Not Same(m_colTiv, Value) Then
                    m_colTiv = Value
                    m_IsDirty(FieldIndex.colTiv) = True
                End If
            End Set
        End Property
        Private m_colTiv As Nullable(Of Double)

        Public Property colTivpd() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colTivpd
            Get
                Return m_colTivpd
            End Get
            Set
                If Not Same(m_colTivpd, Value) Then
                    m_colTivpd = Value
                    m_IsDirty(FieldIndex.colTivpd) = True
                End If
            End Set
        End Property
        Private m_colTivpd As Nullable(Of Double)

        Public Property colTivbi() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colTivbi
            Get
                Return m_colTivbi
            End Get
            Set
                If Not Same(m_colTivbi, Value) Then
                    m_colTivbi = Value
                    m_IsDirty(FieldIndex.colTivbi) = True
                End If
            End Set
        End Property
        Private m_colTivbi As Nullable(Of Double)

        Public Property colInterdependencies() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colInterdependencies
            Get
                Return m_colInterdependencies
            End Get
            Set
                If Not Same(m_colInterdependencies, Value) Then
                    m_colInterdependencies = Value
                    m_IsDirty(FieldIndex.colInterdependencies) = True
                End If
            End Set
        End Property
        Private m_colInterdependencies As String

        Public Property colLEandInterdependecyComments() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colLEandInterdependecyComments
            Get
                Return m_colLEandInterdependecyComments
            End Get
            Set
                If Not Same(m_colLEandInterdependecyComments, Value) Then
                    m_colLEandInterdependecyComments = Value
                    m_IsDirty(FieldIndex.colLEandInterdependecyComments) = True
                End If
            End Set
        End Property
        Private m_colLEandInterdependecyComments As String

        Public Property colLossesLast3Years() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colLossesLast3Years
            Get
                Return m_colLossesLast3Years
            End Get
            Set
                If Not Same(m_colLossesLast3Years, Value) Then
                    m_colLossesLast3Years = Value
                    m_IsDirty(FieldIndex.colLossesLast3Years) = True
                End If
            End Set
        End Property
        Private m_colLossesLast3Years As String

        Public Property colLossHistoryDescription() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colLossHistoryDescription
            Get
                Return m_colLossHistoryDescription
            End Get
            Set
                If Not Same(m_colLossHistoryDescription, Value) Then
                    m_colLossHistoryDescription = Value
                    m_IsDirty(FieldIndex.colLossHistoryDescription) = True
                End If
            End Set
        End Property
        Private m_colLossHistoryDescription As String

        Public Property colInspectionDate() As Nullable(Of DateTime) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colInspectionDate
            Get
                Return m_colInspectionDate
            End Get
            Set
                If Not Same(m_colInspectionDate, Value) Then
                    m_colInspectionDate = Value
                    m_IsDirty(FieldIndex.colInspectionDate) = True
                End If
            End Set
        End Property
        Private m_colInspectionDate As Nullable(Of DateTime)

        Public Property colActiveScore() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colActiveScore
            Get
                Return m_colActiveScore
            End Get
            Set
                If Not Same(m_colActiveScore, Value) Then
                    m_colActiveScore = Value
                    m_IsDirty(FieldIndex.colActiveScore) = True
                End If
            End Set
        End Property
        Private m_colActiveScore As Nullable(Of Decimal)

        Public Property colPassiveScore() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPassiveScore
            Get
                Return m_colPassiveScore
            End Get
            Set
                If Not Same(m_colPassiveScore, Value) Then
                    m_colPassiveScore = Value
                    m_IsDirty(FieldIndex.colPassiveScore) = True
                End If
            End Set
        End Property
        Private m_colPassiveScore As Nullable(Of Decimal)

        Public Property colTotalScore() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colTotalScore
            Get
                Return m_colTotalScore
            End Get
            Set
                If Not Same(m_colTotalScore, Value) Then
                    m_colTotalScore = Value
                    m_IsDirty(FieldIndex.colTotalScore) = True
                End If
            End Set
        End Property
        Private m_colTotalScore As Nullable(Of Double)

        Public Property colOverallRating() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOverallRating
            Get
                Return m_colOverallRating
            End Get
            Set
                If Not Same(m_colOverallRating, Value) Then
                    m_colOverallRating = Value
                    m_IsDirty(FieldIndex.colOverallRating) = True
                End If
            End Set
        End Property
        Private m_colOverallRating As String

        Public Property colTotalscoreColor() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colTotalscoreColor
            Get
                Return m_colTotalscoreColor
            End Get
            Set
                If Not Same(m_colTotalscoreColor, Value) Then
                    m_colTotalscoreColor = Value
                    m_IsDirty(FieldIndex.colTotalscoreColor) = True
                End If
            End Set
        End Property
        Private m_colTotalscoreColor As String

        Public Property colOccupancy() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOccupancy
            Get
                Return m_colOccupancy
            End Get
            Set
                If Not Same(m_colOccupancy, Value) Then
                    m_colOccupancy = Value
                    m_IsDirty(FieldIndex.colOccupancy) = True
                End If
            End Set
        End Property
        Private m_colOccupancy As String

        Public Property colIndustryGroup() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colIndustryGroup
            Get
                Return m_colIndustryGroup
            End Get
            Set
                If Not Same(m_colIndustryGroup, Value) Then
                    m_colIndustryGroup = Value
                    m_IsDirty(FieldIndex.colIndustryGroup) = True
                End If
            End Set
        End Property
        Private m_colIndustryGroup As String

        Public Property colMajorGroup() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMajorGroup
            Get
                Return m_colMajorGroup
            End Get
            Set
                If Not Same(m_colMajorGroup, Value) Then
                    m_colMajorGroup = Value
                    m_IsDirty(FieldIndex.colMajorGroup) = True
                End If
            End Set
        End Property
        Private m_colMajorGroup As String

        Public Property colSpecificGroup() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colSpecificGroup
            Get
                Return m_colSpecificGroup
            End Get
            Set
                If Not Same(m_colSpecificGroup, Value) Then
                    m_colSpecificGroup = Value
                    m_IsDirty(FieldIndex.colSpecificGroup) = True
                End If
            End Set
        End Property
        Private m_colSpecificGroup As String

        Public Property colActiveScoreWithRecsComplete() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colActiveScoreWithRecsComplete
            Get
                Return m_colActiveScoreWithRecsComplete
            End Get
            Set
                If Not Same(m_colActiveScoreWithRecsComplete, Value) Then
                    m_colActiveScoreWithRecsComplete = Value
                    m_IsDirty(FieldIndex.colActiveScoreWithRecsComplete) = True
                End If
            End Set
        End Property
        Private m_colActiveScoreWithRecsComplete As Nullable(Of Decimal)

        Public Property colOverallScoreWithRecsComplete() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOverallScoreWithRecsComplete
            Get
                Return m_colOverallScoreWithRecsComplete
            End Get
            Set
                If Not Same(m_colOverallScoreWithRecsComplete, Value) Then
                    m_colOverallScoreWithRecsComplete = Value
                    m_IsDirty(FieldIndex.colOverallScoreWithRecsComplete) = True
                End If
            End Set
        End Property
        Private m_colOverallScoreWithRecsComplete As Nullable(Of Decimal)

        Public Property colMaxPossibleScore() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colMaxPossibleScore
            Get
                Return m_colMaxPossibleScore
            End Get
            Set
                If Not Same(m_colMaxPossibleScore, Value) Then
                    m_colMaxPossibleScore = Value
                    m_IsDirty(FieldIndex.colMaxPossibleScore) = True
                End If
            End Set
        End Property
        Private m_colMaxPossibleScore As Nullable(Of Decimal)

        Public Property colConstructionRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colConstructionRating
            Get
                Return m_colConstructionRating
            End Get
            Set
                If Not Same(m_colConstructionRating, Value) Then
                    m_colConstructionRating = Value
                    m_IsDirty(FieldIndex.colConstructionRating) = True
                End If
            End Set
        End Property
        Private m_colConstructionRating As Nullable(Of Long)

        Public Property colOccupancyRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOccupancyRating
            Get
                Return m_colOccupancyRating
            End Get
            Set
                If Not Same(m_colOccupancyRating, Value) Then
                    m_colOccupancyRating = Value
                    m_IsDirty(FieldIndex.colOccupancyRating) = True
                End If
            End Set
        End Property
        Private m_colOccupancyRating As Nullable(Of Long)

        Public Property colFloodRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colFloodRating
            Get
                Return m_colFloodRating
            End Get
            Set
                If Not Same(m_colFloodRating, Value) Then
                    m_colFloodRating = Value
                    m_IsDirty(FieldIndex.colFloodRating) = True
                End If
            End Set
        End Property
        Private m_colFloodRating As Nullable(Of Long)

        Public Property colEarthquakeRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colEarthquakeRating
            Get
                Return m_colEarthquakeRating
            End Get
            Set
                If Not Same(m_colEarthquakeRating, Value) Then
                    m_colEarthquakeRating = Value
                    m_IsDirty(FieldIndex.colEarthquakeRating) = True
                End If
            End Set
        End Property
        Private m_colEarthquakeRating As Nullable(Of Long)

        Public Property colWindstormRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colWindstormRating
            Get
                Return m_colWindstormRating
            End Get
            Set
                If Not Same(m_colWindstormRating, Value) Then
                    m_colWindstormRating = Value
                    m_IsDirty(FieldIndex.colWindstormRating) = True
                End If
            End Set
        End Property
        Private m_colWindstormRating As Nullable(Of Long)

        Public Property colOtherRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOtherRating
            Get
                Return m_colOtherRating
            End Get
            Set
                If Not Same(m_colOtherRating, Value) Then
                    m_colOtherRating = Value
                    m_IsDirty(FieldIndex.colOtherRating) = True
                End If
            End Set
        End Property
        Private m_colOtherRating As Nullable(Of Long)

        Public Property colPhysicalProtectionRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPhysicalProtectionRating
            Get
                Return m_colPhysicalProtectionRating
            End Get
            Set
                If Not Same(m_colPhysicalProtectionRating, Value) Then
                    m_colPhysicalProtectionRating = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionRating) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionRating As Nullable(Of Long)

        Public Property colHumanElementRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colHumanElementRating
            Get
                Return m_colHumanElementRating
            End Get
            Set
                If Not Same(m_colHumanElementRating, Value) Then
                    m_colHumanElementRating = Value
                    m_IsDirty(FieldIndex.colHumanElementRating) = True
                End If
            End Set
        End Property
        Private m_colHumanElementRating As Nullable(Of Long)

        Public Property colNaturalHazardsProtectionRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colNaturalHazardsProtectionRating
            Get
                Return m_colNaturalHazardsProtectionRating
            End Get
            Set
                If Not Same(m_colNaturalHazardsProtectionRating, Value) Then
                    m_colNaturalHazardsProtectionRating = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsProtectionRating) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsProtectionRating As Nullable(Of Long)

        Public Property colBusinessContinuityRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colBusinessContinuityRating
            Get
                Return m_colBusinessContinuityRating
            End Get
            Set
                If Not Same(m_colBusinessContinuityRating, Value) Then
                    m_colBusinessContinuityRating = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityRating) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityRating As Nullable(Of Long)

        Public Property colAplFactor() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAplFactor
            Get
                Return m_colAplFactor
            End Get
            Set
                If Not Same(m_colAplFactor, Value) Then
                    m_colAplFactor = Value
                    m_IsDirty(FieldIndex.colAplFactor) = True
                End If
            End Set
        End Property
        Private m_colAplFactor As Nullable(Of Decimal)

        Public Property colAPLFactorWithAllRecsComplete() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAPLFactorWithAllRecsComplete
            Get
                Return m_colAPLFactorWithAllRecsComplete
            End Get
            Set
                If Not Same(m_colAPLFactorWithAllRecsComplete, Value) Then
                    m_colAPLFactorWithAllRecsComplete = Value
                    m_IsDirty(FieldIndex.colAPLFactorWithAllRecsComplete) = True
                End If
            End Set
        End Property
        Private m_colAPLFactorWithAllRecsComplete As Nullable(Of Decimal)

        Public Property colOtherWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOtherWeight
            Get
                Return m_colOtherWeight
            End Get
            Set
                If Not Same(m_colOtherWeight, Value) Then
                    m_colOtherWeight = Value
                    m_IsDirty(FieldIndex.colOtherWeight) = True
                End If
            End Set
        End Property
        Private m_colOtherWeight As Nullable(Of Long)

        Public Property colConstructionWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colConstructionWeight
            Get
                Return m_colConstructionWeight
            End Get
            Set
                If Not Same(m_colConstructionWeight, Value) Then
                    m_colConstructionWeight = Value
                    m_IsDirty(FieldIndex.colConstructionWeight) = True
                End If
            End Set
        End Property
        Private m_colConstructionWeight As Nullable(Of Long)

        Public Property colOccupancyWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colOccupancyWeight
            Get
                Return m_colOccupancyWeight
            End Get
            Set
                If Not Same(m_colOccupancyWeight, Value) Then
                    m_colOccupancyWeight = Value
                    m_IsDirty(FieldIndex.colOccupancyWeight) = True
                End If
            End Set
        End Property
        Private m_colOccupancyWeight As Nullable(Of Long)

        Public Property colPhysicalProtectionWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colPhysicalProtectionWeight
            Get
                Return m_colPhysicalProtectionWeight
            End Get
            Set
                If Not Same(m_colPhysicalProtectionWeight, Value) Then
                    m_colPhysicalProtectionWeight = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionWeight) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionWeight As Nullable(Of Long)

        Public Property colHumanElementWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colHumanElementWeight
            Get
                Return m_colHumanElementWeight
            End Get
            Set
                If Not Same(m_colHumanElementWeight, Value) Then
                    m_colHumanElementWeight = Value
                    m_IsDirty(FieldIndex.colHumanElementWeight) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWeight As Nullable(Of Long)

        Public Property colNaturalHazardsProtectionWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colNaturalHazardsProtectionWeight
            Get
                Return m_colNaturalHazardsProtectionWeight
            End Get
            Set
                If Not Same(m_colNaturalHazardsProtectionWeight, Value) Then
                    m_colNaturalHazardsProtectionWeight = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsProtectionWeight) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsProtectionWeight As Nullable(Of Long)

        Public Property colBusinessContinuityWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colBusinessContinuityWeight
            Get
                Return m_colBusinessContinuityWeight
            End Get
            Set
                If Not Same(m_colBusinessContinuityWeight, Value) Then
                    m_colBusinessContinuityWeight = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityWeight) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityWeight As Nullable(Of Long)

        Public Property colFireProtectionAllRecsCompleteRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colFireProtectionAllRecsCompleteRating
            Get
                Return m_colFireProtectionAllRecsCompleteRating
            End Get
            Set
                If Not Same(m_colFireProtectionAllRecsCompleteRating, Value) Then
                    m_colFireProtectionAllRecsCompleteRating = Value
                    m_IsDirty(FieldIndex.colFireProtectionAllRecsCompleteRating) = True
                End If
            End Set
        End Property
        Private m_colFireProtectionAllRecsCompleteRating As Nullable(Of Long)

        Public Property colHumanElementAllRecsCompleteRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colHumanElementAllRecsCompleteRating
            Get
                Return m_colHumanElementAllRecsCompleteRating
            End Get
            Set
                If Not Same(m_colHumanElementAllRecsCompleteRating, Value) Then
                    m_colHumanElementAllRecsCompleteRating = Value
                    m_IsDirty(FieldIndex.colHumanElementAllRecsCompleteRating) = True
                End If
            End Set
        End Property
        Private m_colHumanElementAllRecsCompleteRating As Nullable(Of Long)

        Public Property colNatHazProtAllRecsCompleteRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colNatHazProtAllRecsCompleteRating
            Get
                Return m_colNatHazProtAllRecsCompleteRating
            End Get
            Set
                If Not Same(m_colNatHazProtAllRecsCompleteRating, Value) Then
                    m_colNatHazProtAllRecsCompleteRating = Value
                    m_IsDirty(FieldIndex.colNatHazProtAllRecsCompleteRating) = True
                End If
            End Set
        End Property
        Private m_colNatHazProtAllRecsCompleteRating As Nullable(Of Long)

        Public Property colBcpAllRecsCompletRating() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colBcpAllRecsCompletRating
            Get
                Return m_colBcpAllRecsCompletRating
            End Get
            Set
                If Not Same(m_colBcpAllRecsCompletRating, Value) Then
                    m_colBcpAllRecsCompletRating = Value
                    m_IsDirty(FieldIndex.colBcpAllRecsCompletRating) = True
                End If
            End Set
        End Property
        Private m_colBcpAllRecsCompletRating As Nullable(Of Long)

        Public Property colFloodWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colFloodWeight
            Get
                Return m_colFloodWeight
            End Get
            Set
                If Not Same(m_colFloodWeight, Value) Then
                    m_colFloodWeight = Value
                    m_IsDirty(FieldIndex.colFloodWeight) = True
                End If
            End Set
        End Property
        Private m_colFloodWeight As Nullable(Of Long)

        Public Property colEarthquakeWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colEarthquakeWeight
            Get
                Return m_colEarthquakeWeight
            End Get
            Set
                If Not Same(m_colEarthquakeWeight, Value) Then
                    m_colEarthquakeWeight = Value
                    m_IsDirty(FieldIndex.colEarthquakeWeight) = True
                End If
            End Set
        End Property
        Private m_colEarthquakeWeight As Nullable(Of Long)

        Public Property colWindstormWeight() As Nullable(Of Long) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colWindstormWeight
            Get
                Return m_colWindstormWeight
            End Get
            Set
                If Not Same(m_colWindstormWeight, Value) Then
                    m_colWindstormWeight = Value
                    m_IsDirty(FieldIndex.colWindstormWeight) = True
                End If
            End Set
        End Property
        Private m_colWindstormWeight As Nullable(Of Long)

        Public Property colCustomAccess() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colCustomAccess
            Get
                Return m_colCustomAccess
            End Get
            Set
                If Not Same(m_colCustomAccess, Value) Then
                    m_colCustomAccess = Value
                    m_IsDirty(FieldIndex.colCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colCustomAccess As String

        Public Property colInspProgramYearFROM() As Nullable(Of DateTime) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colInspProgramYearFROM
            Get
                Return m_colInspProgramYearFROM
            End Get
            Set
                If Not Same(m_colInspProgramYearFROM, Value) Then
                    m_colInspProgramYearFROM = Value
                    m_IsDirty(FieldIndex.colInspProgramYearFROM) = True
                End If
            End Set
        End Property
        Private m_colInspProgramYearFROM As Nullable(Of DateTime)

        Public Property colInspProgramYear() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colInspProgramYear
            Get
                Return m_colInspProgramYear
            End Get
            Set
                If Not Same(m_colInspProgramYear, Value) Then
                    m_colInspProgramYear = Value
                    m_IsDirty(FieldIndex.colInspProgramYear) = True
                End If
            End Set
        End Property
        Private m_colInspProgramYear As String

        Public Property colAchievableScorePercent() As Nullable(Of Decimal) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAchievableScorePercent
            Get
                Return m_colAchievableScorePercent
            End Get
            Set
                If Not Same(m_colAchievableScorePercent, Value) Then
                    m_colAchievableScorePercent = Value
                    m_IsDirty(FieldIndex.colAchievableScorePercent) = True
                End If
            End Set
        End Property
        Private m_colAchievableScorePercent As Nullable(Of Decimal)

        Public Property colAchievableScorePercentString() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colAchievableScorePercentString
            Get
                Return m_colAchievableScorePercentString
            End Get
            Set
                If Not Same(m_colAchievableScorePercentString, Value) Then
                    m_colAchievableScorePercentString = Value
                    m_IsDirty(FieldIndex.colAchievableScorePercentString) = True
                End If
            End Set
        End Property
        Private m_colAchievableScorePercentString As String

        Public Property colIsLatestRating() As String Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colIsLatestRating
            Get
                Return m_colIsLatestRating
            End Get
            Set
                If Not Same(m_colIsLatestRating, Value) Then
                    m_colIsLatestRating = Value
                    m_IsDirty(FieldIndex.colIsLatestRating) = True
                End If
            End Set
        End Property
        Private m_colIsLatestRating As String

        Public Property colIbi() As Nullable(Of Double) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colIbi
            Get
                Return m_colIbi
            End Get
            Set
                If Not Same(m_colIbi, Value) Then
                    m_colIbi = Value
                    m_IsDirty(FieldIndex.colIbi) = True
                End If
            End Set
        End Property
        Private m_colIbi As Nullable(Of Double)

        Public Property colHighestLossExpectancy() As Nullable(Of Integer) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.colHighestLossExpectancy
            Get
                Return m_colHighestLossExpectancy
            End Get
            Set
                If Not Same(m_colHighestLossExpectancy, Value) Then
                    m_colHighestLossExpectancy = Value
                    m_IsDirty(FieldIndex.colHighestLossExpectancy) = True
                End If
            End Set
        End Property
        Private m_colHighestLossExpectancy As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwFireLossEstimatesLatestFacilityRatingExtractSelect.FieldIndex) As Boolean Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect.SetIsDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colClient) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colAddress) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colLatitude) = pDirty
            m_IsDirty(FieldIndex.colLongitude) = pDirty
            m_IsDirty(FieldIndex.colBIReporting) = pDirty
            m_IsDirty(FieldIndex.colApl) = pDirty
            m_IsDirty(FieldIndex.colAplpd) = pDirty
            m_IsDirty(FieldIndex.colAplbi) = pDirty
            m_IsDirty(FieldIndex.colAPLPercent) = pDirty
            m_IsDirty(FieldIndex.colAPLPDPercent) = pDirty
            m_IsDirty(FieldIndex.colAPLBIPercent) = pDirty
            m_IsDirty(FieldIndex.colPml) = pDirty
            m_IsDirty(FieldIndex.colPmlpd) = pDirty
            m_IsDirty(FieldIndex.colPmlbi) = pDirty
            m_IsDirty(FieldIndex.colPMLPercent) = pDirty
            m_IsDirty(FieldIndex.colPMLPDPercent) = pDirty
            m_IsDirty(FieldIndex.colPMLBIPercent) = pDirty
            m_IsDirty(FieldIndex.colMfl) = pDirty
            m_IsDirty(FieldIndex.colMflpd) = pDirty
            m_IsDirty(FieldIndex.colMflbi) = pDirty
            m_IsDirty(FieldIndex.colMFLPercent) = pDirty
            m_IsDirty(FieldIndex.colMFLPDPercent) = pDirty
            m_IsDirty(FieldIndex.colMFLBIPercent) = pDirty
            m_IsDirty(FieldIndex.colTiv) = pDirty
            m_IsDirty(FieldIndex.colTivpd) = pDirty
            m_IsDirty(FieldIndex.colTivbi) = pDirty
            m_IsDirty(FieldIndex.colInterdependencies) = pDirty
            m_IsDirty(FieldIndex.colLEandInterdependecyComments) = pDirty
            m_IsDirty(FieldIndex.colLossesLast3Years) = pDirty
            m_IsDirty(FieldIndex.colLossHistoryDescription) = pDirty
            m_IsDirty(FieldIndex.colInspectionDate) = pDirty
            m_IsDirty(FieldIndex.colActiveScore) = pDirty
            m_IsDirty(FieldIndex.colPassiveScore) = pDirty
            m_IsDirty(FieldIndex.colTotalScore) = pDirty
            m_IsDirty(FieldIndex.colOverallRating) = pDirty
            m_IsDirty(FieldIndex.colTotalscoreColor) = pDirty
            m_IsDirty(FieldIndex.colOccupancy) = pDirty
            m_IsDirty(FieldIndex.colIndustryGroup) = pDirty
            m_IsDirty(FieldIndex.colMajorGroup) = pDirty
            m_IsDirty(FieldIndex.colSpecificGroup) = pDirty
            m_IsDirty(FieldIndex.colActiveScoreWithRecsComplete) = pDirty
            m_IsDirty(FieldIndex.colOverallScoreWithRecsComplete) = pDirty
            m_IsDirty(FieldIndex.colMaxPossibleScore) = pDirty
            m_IsDirty(FieldIndex.colConstructionRating) = pDirty
            m_IsDirty(FieldIndex.colOccupancyRating) = pDirty
            m_IsDirty(FieldIndex.colFloodRating) = pDirty
            m_IsDirty(FieldIndex.colEarthquakeRating) = pDirty
            m_IsDirty(FieldIndex.colWindstormRating) = pDirty
            m_IsDirty(FieldIndex.colOtherRating) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionRating) = pDirty
            m_IsDirty(FieldIndex.colHumanElementRating) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsProtectionRating) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityRating) = pDirty
            m_IsDirty(FieldIndex.colAplFactor) = pDirty
            m_IsDirty(FieldIndex.colAPLFactorWithAllRecsComplete) = pDirty
            m_IsDirty(FieldIndex.colOtherWeight) = pDirty
            m_IsDirty(FieldIndex.colConstructionWeight) = pDirty
            m_IsDirty(FieldIndex.colOccupancyWeight) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionWeight) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWeight) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsProtectionWeight) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityWeight) = pDirty
            m_IsDirty(FieldIndex.colFireProtectionAllRecsCompleteRating) = pDirty
            m_IsDirty(FieldIndex.colHumanElementAllRecsCompleteRating) = pDirty
            m_IsDirty(FieldIndex.colNatHazProtAllRecsCompleteRating) = pDirty
            m_IsDirty(FieldIndex.colBcpAllRecsCompletRating) = pDirty
            m_IsDirty(FieldIndex.colFloodWeight) = pDirty
            m_IsDirty(FieldIndex.colEarthquakeWeight) = pDirty
            m_IsDirty(FieldIndex.colWindstormWeight) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colInspProgramYearFROM) = pDirty
            m_IsDirty(FieldIndex.colInspProgramYear) = pDirty
            m_IsDirty(FieldIndex.colAchievableScorePercent) = pDirty
            m_IsDirty(FieldIndex.colAchievableScorePercentString) = pDirty
            m_IsDirty(FieldIndex.colIsLatestRating) = pDirty
            m_IsDirty(FieldIndex.colIbi) = pDirty
            m_IsDirty(FieldIndex.colHighestLossExpectancy) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwFireLossEstimatesLatestFacilityRatingExtractSelect) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwFireLossEstimatesLatestFacilityRatingExtractSelect
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFilePrefix  = 1
            colFileNo 
            colClient 
            colClientLocNo 
            colDivision 
            colFacility 
            colAddress 
            colCity 
            colStProv 
            colCountry 
            colLatitude 
            colLongitude 
            colBIReporting 
            colApl 
            colAplpd 
            colAplbi 
            colAPLPercent 
            colAPLPDPercent 
            colAPLBIPercent 
            colPml 
            colPmlpd 
            colPmlbi 
            colPMLPercent 
            colPMLPDPercent 
            colPMLBIPercent 
            colMfl 
            colMflpd 
            colMflbi 
            colMFLPercent 
            colMFLPDPercent 
            colMFLBIPercent 
            colTiv 
            colTivpd 
            colTivbi 
            colInterdependencies 
            colLEandInterdependecyComments 
            colLossesLast3Years 
            colLossHistoryDescription 
            colInspectionDate 
            colActiveScore 
            colPassiveScore 
            colTotalScore 
            colOverallRating 
            colTotalscoreColor 
            colOccupancy 
            colIndustryGroup 
            colMajorGroup 
            colSpecificGroup 
            colActiveScoreWithRecsComplete 
            colOverallScoreWithRecsComplete 
            colMaxPossibleScore 
            colConstructionRating 
            colOccupancyRating 
            colFloodRating 
            colEarthquakeRating 
            colWindstormRating 
            colOtherRating 
            colPhysicalProtectionRating 
            colHumanElementRating 
            colNaturalHazardsProtectionRating 
            colBusinessContinuityRating 
            colAplFactor 
            colAPLFactorWithAllRecsComplete 
            colOtherWeight 
            colConstructionWeight 
            colOccupancyWeight 
            colPhysicalProtectionWeight 
            colHumanElementWeight 
            colNaturalHazardsProtectionWeight 
            colBusinessContinuityWeight 
            colFireProtectionAllRecsCompleteRating 
            colHumanElementAllRecsCompleteRating 
            colNatHazProtAllRecsCompleteRating 
            colBcpAllRecsCompletRating 
            colFloodWeight 
            colEarthquakeWeight 
            colWindstormWeight 
            colCustomAccess 
            colInspProgramYearFROM 
            colInspProgramYear 
            colAchievableScorePercent 
            colAchievableScorePercentString 
            colIsLatestRating 
            colIbi 
            colHighestLossExpectancy 
        End Enum

        Private m_IsDirty(85) As Boolean

        Private Function [Same](pValue1 As Object, pValue2 As Object) As Boolean
            If pValue1 Is Nothing And (Not pValue2 Is Nothing) Then
                Return False
            End If

            If (Not pValue1 Is Nothing) And pValue2 Is Nothing Then
                Return False
            End If

            If pValue1 <> pValue2 Then
                Return False
            End If

            Return True
        End Function

    End Class

    Public Interface IrowVwFireLossEstimatesLatestFacilityRatingExtractSelect
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFilePrefix() As String
        Property colFileNo() As String
        Property colClient() As String
        Property colClientLocNo() As String
        Property colDivision() As String
        Property colFacility() As String
        Property colAddress() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colLatitude() As String
        Property colLongitude() As String
        Property colBIReporting() As String
        Property colApl() As Nullable(Of Double)
        Property colAplpd() As Nullable(Of Double)
        Property colAplbi() As Nullable(Of Double)
        Property colAPLPercent() As Nullable(Of Double)
        Property colAPLPDPercent() As Nullable(Of Double)
        Property colAPLBIPercent() As Nullable(Of Double)
        Property colPml() As Nullable(Of Double)
        Property colPmlpd() As Nullable(Of Double)
        Property colPmlbi() As Nullable(Of Double)
        Property colPMLPercent() As Nullable(Of Double)
        Property colPMLPDPercent() As Nullable(Of Double)
        Property colPMLBIPercent() As Nullable(Of Double)
        Property colMfl() As Nullable(Of Double)
        Property colMflpd() As Nullable(Of Double)
        Property colMflbi() As Nullable(Of Double)
        Property colMFLPercent() As Nullable(Of Double)
        Property colMFLPDPercent() As Nullable(Of Double)
        Property colMFLBIPercent() As Nullable(Of Double)
        Property colTiv() As Nullable(Of Double)
        Property colTivpd() As Nullable(Of Double)
        Property colTivbi() As Nullable(Of Double)
        Property colInterdependencies() As String
        Property colLEandInterdependecyComments() As String
        Property colLossesLast3Years() As String
        Property colLossHistoryDescription() As String
        Property colInspectionDate() As Nullable(Of DateTime)
        Property colActiveScore() As Nullable(Of Decimal)
        Property colPassiveScore() As Nullable(Of Decimal)
        Property colTotalScore() As Nullable(Of Double)
        Property colOverallRating() As String
        Property colTotalscoreColor() As String
        Property colOccupancy() As String
        Property colIndustryGroup() As String
        Property colMajorGroup() As String
        Property colSpecificGroup() As String
        Property colActiveScoreWithRecsComplete() As Nullable(Of Decimal)
        Property colOverallScoreWithRecsComplete() As Nullable(Of Decimal)
        Property colMaxPossibleScore() As Nullable(Of Decimal)
        Property colConstructionRating() As Nullable(Of Long)
        Property colOccupancyRating() As Nullable(Of Long)
        Property colFloodRating() As Nullable(Of Long)
        Property colEarthquakeRating() As Nullable(Of Long)
        Property colWindstormRating() As Nullable(Of Long)
        Property colOtherRating() As Nullable(Of Long)
        Property colPhysicalProtectionRating() As Nullable(Of Long)
        Property colHumanElementRating() As Nullable(Of Long)
        Property colNaturalHazardsProtectionRating() As Nullable(Of Long)
        Property colBusinessContinuityRating() As Nullable(Of Long)
        Property colAplFactor() As Nullable(Of Decimal)
        Property colAPLFactorWithAllRecsComplete() As Nullable(Of Decimal)
        Property colOtherWeight() As Nullable(Of Long)
        Property colConstructionWeight() As Nullable(Of Long)
        Property colOccupancyWeight() As Nullable(Of Long)
        Property colPhysicalProtectionWeight() As Nullable(Of Long)
        Property colHumanElementWeight() As Nullable(Of Long)
        Property colNaturalHazardsProtectionWeight() As Nullable(Of Long)
        Property colBusinessContinuityWeight() As Nullable(Of Long)
        Property colFireProtectionAllRecsCompleteRating() As Nullable(Of Long)
        Property colHumanElementAllRecsCompleteRating() As Nullable(Of Long)
        Property colNatHazProtAllRecsCompleteRating() As Nullable(Of Long)
        Property colBcpAllRecsCompletRating() As Nullable(Of Long)
        Property colFloodWeight() As Nullable(Of Long)
        Property colEarthquakeWeight() As Nullable(Of Long)
        Property colWindstormWeight() As Nullable(Of Long)
        Property colCustomAccess() As String
        Property colInspProgramYearFROM() As Nullable(Of DateTime)
        Property colInspProgramYear() As String
        Property colAchievableScorePercent() As Nullable(Of Decimal)
        Property colAchievableScorePercentString() As String
        Property colIsLatestRating() As String
        Property colIbi() As Nullable(Of Double)
        Property colHighestLossExpectancy() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwFireLossEstimatesLatestFacilityRatingExtractSelect.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

