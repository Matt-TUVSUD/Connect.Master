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
    Partial Public Class VwWhatIfFireFacilityRating

        Public Shared Function LoadData() As List(Of rowVwWhatIfFireFacilityRating)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwWhatIfFireFacilityRating)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwWhatIfFireFacilityRating)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwWhatIfFireFacilityRating)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwWhatIfFireFacilityRating)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwWhatIfFireFacilityRating)
            Dim zReturn As New List(Of rowVwWhatIfFireFacilityRating)
            Dim zSQL As String = "SELECT * FROM [rv].[vwWhatIfFireFacilityRating]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwWhatIfFireFacilityRating)

			Try
	            Dim zReturn As New List(Of rowVwWhatIfFireFacilityRating)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwWhatIfFireFacilityRating

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwWhatIfFireFacilityRating		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwWhatIfFireFacilityRating)
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AddressStamp")) Then pObject.colAddressStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "AddressStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("address1")) Then pObject.colAddress1 = UtilSQLServer.SafeReader.SafeReadString(pReader, "address1")
			If Not pReader.IsDBNull(pReader.GetOrdinal("city")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "city")
			If Not pReader.IsDBNull(pReader.GetOrdinal("stprov")) Then pObject.colStprov = UtilSQLServer.SafeReader.SafeReadString(pReader, "stprov")
			If Not pReader.IsDBNull(pReader.GetOrdinal("country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("zip")) Then pObject.colZip = UtilSQLServer.SafeReader.SafeReadString(pReader, "zip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIV")) Then pObject.colTiv = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIV")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVBI")) Then pObject.colTivbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVPD")) Then pObject.colTivpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PML")) Then pObject.colPml = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PML")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPD")) Then pObject.colPmlpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLBI")) Then pObject.colPmlbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPD")) Then pObject.colMflpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLBI")) Then pObject.colMflbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFL")) Then pObject.colMfl = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLPD")) Then pObject.colAplpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APLBI")) Then pObject.colAplbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("APL")) Then pObject.colApl = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "APL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("inspectiondate")) Then pObject.colInspectiondate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "inspectiondate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("grade")) Then pObject.colGrade = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "grade")
			If Not pReader.IsDBNull(pReader.GetOrdinal("constructionrating")) Then pObject.colConstructionrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "constructionrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("occupancyrating")) Then pObject.colOccupancyrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "occupancyrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("floodrating")) Then pObject.colFloodrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "floodrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("earthquakerating")) Then pObject.colEarthquakerating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "earthquakerating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("windstormrating")) Then pObject.colWindstormrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "windstormrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("otherrating")) Then pObject.colOtherrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "otherrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FloorRatingBackColorHex")) Then pObject.colFloorRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "FloorRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EarthquakeRatingBackColorHex")) Then pObject.colEarthquakeRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "EarthquakeRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WindstormRatingBackColorHex")) Then pObject.colWindstormRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "WindstormRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ConstructionRatingBackColorHex")) Then pObject.colConstructionRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "ConstructionRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OccupancyRatingBackColorHex")) Then pObject.colOccupancyRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "OccupancyRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OtherRatingBackColorHex")) Then pObject.colOtherRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "OtherRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("physicalprotectionrating")) Then pObject.colPhysicalprotectionrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "physicalprotectionrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("humanelementrating")) Then pObject.colHumanelementrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "humanelementrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("naturalhazardsprotectionrating")) Then pObject.colNaturalhazardsprotectionrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "naturalhazardsprotectionrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("businesscontinuityrating")) Then pObject.colBusinesscontinuityrating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "businesscontinuityrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PhysicalProtectionRatingBackColorHex")) Then pObject.colPhysicalProtectionRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "PhysicalProtectionRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementRatingBackColorHex")) Then pObject.colHumanElementRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NaturalHazardsProtectionRatingBackColorHex")) Then pObject.colNaturalHazardsProtectionRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "NaturalHazardsProtectionRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BusinessContinuityRatingBackColorHex")) Then pObject.colBusinessContinuityRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "BusinessContinuityRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("aplfactor")) Then pObject.colAplfactor = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "aplfactor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("overallplantratingrating")) Then pObject.colOverallplantratingrating = UtilSQLServer.SafeReader.SafeReadString(pReader, "overallplantratingrating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("passivescore")) Then pObject.colPassivescore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "passivescore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("activescore")) Then pObject.colActivescore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "activescore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WhatIfActiveScore")) Then pObject.colWhatIfActiveScore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "WhatIfActiveScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("totalscore")) Then pObject.colTotalscore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "totalscore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TotalScoreHexBackColor")) Then pObject.colTotalScoreHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "TotalScoreHexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TotalScoreHexForeColor")) Then pObject.colTotalScoreHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "TotalScoreHexForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("totalscorerating")) Then pObject.colTotalscorerating = UtilSQLServer.SafeReader.SafeReadString(pReader, "totalscorerating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WhatIfScore")) Then pObject.colWhatIfScore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "WhatIfScore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WhatIfScoreHexBackColor")) Then pObject.colWhatIfScoreHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "WhatIfScoreHexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("totalfacilityscore")) Then pObject.colTotalfacilityscore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "totalfacilityscore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("otherweight")) Then pObject.colOtherweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "otherweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("constructionweight")) Then pObject.colConstructionweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "constructionweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("occupancyweight")) Then pObject.colOccupancyweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "occupancyweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("physicalprotectionweight")) Then pObject.colPhysicalprotectionweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "physicalprotectionweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("humanelementweight")) Then pObject.colHumanelementweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "humanelementweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("naturalhazardsprotectionweight")) Then pObject.colNaturalhazardsprotectionweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "naturalhazardsprotectionweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("businesscontinuityweight")) Then pObject.colBusinesscontinuityweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "businesscontinuityweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fireprotectionallrecscompleterating")) Then pObject.colFireprotectionallrecscompleterating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "fireprotectionallrecscompleterating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("humanelementallrecscompleterating")) Then pObject.colHumanelementallrecscompleterating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "humanelementallrecscompleterating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("nathazprotallrecscompleterating")) Then pObject.colNathazprotallrecscompleterating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "nathazprotallrecscompleterating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BcpAllRecsCompleteRating")) Then pObject.colBcpAllRecsCompleteRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "BcpAllRecsCompleteRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireProtectionAllRecsCompleteRatingBackColorHex")) Then pObject.colFireProtectionAllRecsCompleteRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireProtectionAllRecsCompleteRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementAllRecsCompleteRatingBackColorHex")) Then pObject.colHumanElementAllRecsCompleteRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementAllRecsCompleteRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazProtAllRecsCompleteRatingBackColorHex")) Then pObject.colNatHazProtAllRecsCompleteRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazProtAllRecsCompleteRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BcpAllRecsCompleteRatingBackColorHex")) Then pObject.colBcpAllRecsCompleteRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "BcpAllRecsCompleteRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PhysicalProtectionWhatIfRatingBackColorHex")) Then pObject.colPhysicalProtectionWhatIfRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "PhysicalProtectionWhatIfRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementWhatIfRatingBackColorHex")) Then pObject.colHumanElementWhatIfRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementWhatIfRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NaturalHazardsProtectionWhatIfRatingBackColorHex")) Then pObject.colNaturalHazardsProtectionWhatIfRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "NaturalHazardsProtectionWhatIfRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BusinessContinuityWhatIfRatingBackColorHex")) Then pObject.colBusinessContinuityWhatIfRatingBackColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "BusinessContinuityWhatIfRatingBackColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PhysicalProtectionWhatIfRating")) Then pObject.colPhysicalProtectionWhatIfRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "PhysicalProtectionWhatIfRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementWhatIfRating")) Then pObject.colHumanElementWhatIfRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "HumanElementWhatIfRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NaturalHazardsWhatIfRating")) Then pObject.colNaturalHazardsWhatIfRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "NaturalHazardsWhatIfRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BusinessContinuityWhatIfRating")) Then pObject.colBusinessContinuityWhatIfRating = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "BusinessContinuityWhatIfRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PhysicalProtectionWhatIfRatingDesc")) Then pObject.colPhysicalProtectionWhatIfRatingDesc = UtilSQLServer.SafeReader.SafeReadString(pReader, "PhysicalProtectionWhatIfRatingDesc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementWhatIfRatingDesc")) Then pObject.colHumanElementWhatIfRatingDesc = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementWhatIfRatingDesc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NaturalHazardsWhatIfRatingDesc")) Then pObject.colNaturalHazardsWhatIfRatingDesc = UtilSQLServer.SafeReader.SafeReadString(pReader, "NaturalHazardsWhatIfRatingDesc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BusinessContinuityWhatIfRatingDesc")) Then pObject.colBusinessContinuityWhatIfRatingDesc = UtilSQLServer.SafeReader.SafeReadString(pReader, "BusinessContinuityWhatIfRatingDesc")
			If Not pReader.IsDBNull(pReader.GetOrdinal("activescorewithrecscomplete")) Then pObject.colActivescorewithrecscomplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "activescorewithrecscomplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("aplwithallrecscomplete")) Then pObject.colAplwithallrecscomplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "aplwithallrecscomplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("floodweight")) Then pObject.colFloodweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "floodweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("earthquakeweight")) Then pObject.colEarthquakeweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "earthquakeweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("windstormweight")) Then pObject.colWindstormweight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "windstormweight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("overallscorewithrecscomplete")) Then pObject.colOverallscorewithrecscomplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "overallscorewithrecscomplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("maxpossiblescore")) Then pObject.colMaxpossiblescore = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "maxpossiblescore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("aplfactorwithallrecscomplete")) Then pObject.colAplfactorwithallrecscomplete = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "aplfactorwithallrecscomplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("flooddescription")) Then pObject.colFlooddescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "flooddescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("earthquakedescription")) Then pObject.colEarthquakedescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "earthquakedescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("windstormdescription")) Then pObject.colWindstormdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "windstormdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("constructiondescription")) Then pObject.colConstructiondescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "constructiondescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("occupancydescription")) Then pObject.colOccupancydescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "occupancydescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("otherdescription")) Then pObject.colOtherdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "otherdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("firedescription")) Then pObject.colFiredescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "firedescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("humandescription")) Then pObject.colHumandescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "humandescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("naturaldescription")) Then pObject.colNaturaldescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "naturaldescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("businessdescription")) Then pObject.colBusinessdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "businessdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("firerecdescription")) Then pObject.colFirerecdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "firerecdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("humanrecdescription")) Then pObject.colHumanrecdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "humanrecdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("naturalrecdescription")) Then pObject.colNaturalrecdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "naturalrecdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("businessrecdescription")) Then pObject.colBusinessrecdescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "businessrecdescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("exchangerate")) Then pObject.colExchangerate = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "exchangerate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("adminmemo")) Then pObject.colAdminmemo = UtilSQLServer.SafeReader.SafeReadString(pReader, "adminmemo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("overallscorewithrecscompleterating")) Then pObject.colOverallscorewithrecscompleterating = UtilSQLServer.SafeReader.SafeReadString(pReader, "overallscorewithrecscompleterating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("maxpossiblerating")) Then pObject.colMaxpossiblerating = UtilSQLServer.SafeReader.SafeReadString(pReader, "maxpossiblerating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OverallScoreWithRecsCompleteHexForeColor")) Then pObject.colOverallScoreWithRecsCompleteHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "OverallScoreWithRecsCompleteHexForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OverallScoreWithRecsCompleteHexBackColor")) Then pObject.colOverallScoreWithRecsCompleteHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "OverallScoreWithRecsCompleteHexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievableScorePercent")) Then pObject.colAchievableScorePercent = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "AchievableScorePercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievableScorePercentString")) Then pObject.colAchievableScorePercentString = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievableScorePercentString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievableScorePercentHexForeColor")) Then pObject.colAchievableScorePercentHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievableScorePercentHexForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievableScorePercentHexBackColor")) Then pObject.colAchievableScorePercentHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievableScorePercentHexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IsLatestRating")) Then pObject.colIsLatestRating = UtilSQLServer.SafeReader.SafeReadString(pReader, "IsLatestRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievablePercentWhatIfString")) Then pObject.colAchievablePercentWhatIfString = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievablePercentWhatIfString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievablePercentWhatIfHexBackColor")) Then pObject.colAchievablePercentWhatIfHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievablePercentWhatIfHexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievablePercentWhatIfHexForeColor")) Then pObject.colAchievablePercentWhatIfHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievablePercentWhatIfHexForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievablePercentAllRecsCompHexBackColor")) Then pObject.colAchievablePercentAllRecsCompHexBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievablePercentAllRecsCompHexBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievablePercentAllRecsCompHexForeColor")) Then pObject.colAchievablePercentAllRecsCompHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievablePercentAllRecsCompHexForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("AchievablePercentAllRecsCompString")) Then pObject.colAchievablePercentAllRecsCompString = UtilSQLServer.SafeReader.SafeReadString(pReader, "AchievablePercentAllRecsCompString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RatingID")) Then pObject.colRatingID = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "RatingID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FloorRatingForeColorHex")) Then pObject.colFloorRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "FloorRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("EarthquakeRatingForeColorHex")) Then pObject.colEarthquakeRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "EarthquakeRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WindstormRatingForeColorHex")) Then pObject.colWindstormRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "WindstormRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ConstructionRatingForeColorHex")) Then pObject.colConstructionRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "ConstructionRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OccupancyRatingForeColorHex")) Then pObject.colOccupancyRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "OccupancyRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OtherRatingForeColorHex")) Then pObject.colOtherRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "OtherRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PhysicalProtectionRatingForeColorHex")) Then pObject.colPhysicalProtectionRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "PhysicalProtectionRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementRatingForeColorHex")) Then pObject.colHumanElementRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NaturalHazardsProtectionRatingForeColorHex")) Then pObject.colNaturalHazardsProtectionRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "NaturalHazardsProtectionRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BusinessContinuityRatingForeColorHex")) Then pObject.colBusinessContinuityRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "BusinessContinuityRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireProtectionAllRecsCompleteRatingForeColorHex")) Then pObject.colFireProtectionAllRecsCompleteRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireProtectionAllRecsCompleteRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementAllRecsCompleteRatingForeColorHex")) Then pObject.colHumanElementAllRecsCompleteRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementAllRecsCompleteRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazProtAllRecsCompleteRatingForeColorHex")) Then pObject.colNatHazProtAllRecsCompleteRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazProtAllRecsCompleteRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BcpAllRecsCompleteRatingForeColorHex")) Then pObject.colBcpAllRecsCompleteRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "BcpAllRecsCompleteRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WhatIfScoreHexForeColor")) Then pObject.colWhatIfScoreHexForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "WhatIfScoreHexForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PhysicalProtectionWhatIfRatingForeColorHex")) Then pObject.colPhysicalProtectionWhatIfRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "PhysicalProtectionWhatIfRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementWhatIfRatingForeColorHex")) Then pObject.colHumanElementWhatIfRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "HumanElementWhatIfRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NaturalHazardsProtectionWhatIfRatingForeColorHex")) Then pObject.colNaturalHazardsProtectionWhatIfRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "NaturalHazardsProtectionWhatIfRatingForeColorHex")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BusinessContinuityWhatIfRatingForeColorHex")) Then pObject.colBusinessContinuityWhatIfRatingForeColorHex = UtilSQLServer.SafeReader.SafeReadString(pReader, "BusinessContinuityWhatIfRatingForeColorHex")
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
            Dim zSQL As String = "SELECT * FROM [rv].[vwWhatIfFireFacilityRating]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwWhatIfFireFacilityRating
        Implements IrowVwWhatIfFireFacilityRating

        Public Event Loaded(pUserState As Object) Implements IrowVwWhatIfFireFacilityRating.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwWhatIfFireFacilityRating.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwWhatIfFireFacilityRating.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwWhatIfFireFacilityRating.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwWhatIfFireFacilityRating.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwWhatIfFireFacilityRating.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowVwWhatIfFireFacilityRating.colGSafeId
            Get
                Return m_colGSafeId
            End Get
            Set
                If Not Same(m_colGSafeId, Value) Then
                    m_colGSafeId = Value
                    m_IsDirty(FieldIndex.colGSafeId) = True
                End If
            End Set
        End Property
        Private m_colGSafeId As Nullable(Of Integer)

        Public Property colFileNo() As String Implements IrowVwWhatIfFireFacilityRating.colFileNo
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

        Public Property colAddressStamp() As String Implements IrowVwWhatIfFireFacilityRating.colAddressStamp
            Get
                Return m_colAddressStamp
            End Get
            Set
                If Not Same(m_colAddressStamp, Value) Then
                    m_colAddressStamp = Value
                    m_IsDirty(FieldIndex.colAddressStamp) = True
                End If
            End Set
        End Property
        Private m_colAddressStamp As String

        Public Property colAddress1() As String Implements IrowVwWhatIfFireFacilityRating.colAddress1
            Get
                Return m_colAddress1
            End Get
            Set
                If Not Same(m_colAddress1, Value) Then
                    m_colAddress1 = Value
                    m_IsDirty(FieldIndex.colAddress1) = True
                End If
            End Set
        End Property
        Private m_colAddress1 As String

        Public Property colCity() As String Implements IrowVwWhatIfFireFacilityRating.colCity
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

        Public Property colStprov() As String Implements IrowVwWhatIfFireFacilityRating.colStprov
            Get
                Return m_colStprov
            End Get
            Set
                If Not Same(m_colStprov, Value) Then
                    m_colStprov = Value
                    m_IsDirty(FieldIndex.colStprov) = True
                End If
            End Set
        End Property
        Private m_colStprov As String

        Public Property colCountry() As String Implements IrowVwWhatIfFireFacilityRating.colCountry
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

        Public Property colDivision() As String Implements IrowVwWhatIfFireFacilityRating.colDivision
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

        Public Property colZip() As String Implements IrowVwWhatIfFireFacilityRating.colZip
            Get
                Return m_colZip
            End Get
            Set
                If Not Same(m_colZip, Value) Then
                    m_colZip = Value
                    m_IsDirty(FieldIndex.colZip) = True
                End If
            End Set
        End Property
        Private m_colZip As String

        Public Property colTiv() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colTiv
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

        Public Property colTivbi() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colTivbi
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

        Public Property colTivpd() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colTivpd
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

        Public Property colPml() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colPml
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

        Public Property colPmlpd() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colPmlpd
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

        Public Property colPmlbi() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colPmlbi
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

        Public Property colMflpd() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colMflpd
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

        Public Property colMflbi() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colMflbi
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

        Public Property colMfl() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colMfl
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

        Public Property colAplpd() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colAplpd
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

        Public Property colAplbi() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colAplbi
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

        Public Property colApl() As Nullable(Of Double) Implements IrowVwWhatIfFireFacilityRating.colApl
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

        Public Property colInspectiondate() As Nullable(Of DateTime) Implements IrowVwWhatIfFireFacilityRating.colInspectiondate
            Get
                Return m_colInspectiondate
            End Get
            Set
                If Not Same(m_colInspectiondate, Value) Then
                    m_colInspectiondate = Value
                    m_IsDirty(FieldIndex.colInspectiondate) = True
                End If
            End Set
        End Property
        Private m_colInspectiondate As Nullable(Of DateTime)

        Public Property colGrade() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colGrade
            Get
                Return m_colGrade
            End Get
            Set
                If Not Same(m_colGrade, Value) Then
                    m_colGrade = Value
                    m_IsDirty(FieldIndex.colGrade) = True
                End If
            End Set
        End Property
        Private m_colGrade As Nullable(Of Decimal)

        Public Property colConstructionrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colConstructionrating
            Get
                Return m_colConstructionrating
            End Get
            Set
                If Not Same(m_colConstructionrating, Value) Then
                    m_colConstructionrating = Value
                    m_IsDirty(FieldIndex.colConstructionrating) = True
                End If
            End Set
        End Property
        Private m_colConstructionrating As Nullable(Of Decimal)

        Public Property colOccupancyrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colOccupancyrating
            Get
                Return m_colOccupancyrating
            End Get
            Set
                If Not Same(m_colOccupancyrating, Value) Then
                    m_colOccupancyrating = Value
                    m_IsDirty(FieldIndex.colOccupancyrating) = True
                End If
            End Set
        End Property
        Private m_colOccupancyrating As Nullable(Of Decimal)

        Public Property colFloodrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colFloodrating
            Get
                Return m_colFloodrating
            End Get
            Set
                If Not Same(m_colFloodrating, Value) Then
                    m_colFloodrating = Value
                    m_IsDirty(FieldIndex.colFloodrating) = True
                End If
            End Set
        End Property
        Private m_colFloodrating As Nullable(Of Decimal)

        Public Property colEarthquakerating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colEarthquakerating
            Get
                Return m_colEarthquakerating
            End Get
            Set
                If Not Same(m_colEarthquakerating, Value) Then
                    m_colEarthquakerating = Value
                    m_IsDirty(FieldIndex.colEarthquakerating) = True
                End If
            End Set
        End Property
        Private m_colEarthquakerating As Nullable(Of Decimal)

        Public Property colWindstormrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colWindstormrating
            Get
                Return m_colWindstormrating
            End Get
            Set
                If Not Same(m_colWindstormrating, Value) Then
                    m_colWindstormrating = Value
                    m_IsDirty(FieldIndex.colWindstormrating) = True
                End If
            End Set
        End Property
        Private m_colWindstormrating As Nullable(Of Decimal)

        Public Property colOtherrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colOtherrating
            Get
                Return m_colOtherrating
            End Get
            Set
                If Not Same(m_colOtherrating, Value) Then
                    m_colOtherrating = Value
                    m_IsDirty(FieldIndex.colOtherrating) = True
                End If
            End Set
        End Property
        Private m_colOtherrating As Nullable(Of Decimal)

        Public Property colFloorRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colFloorRatingBackColorHex
            Get
                Return m_colFloorRatingBackColorHex
            End Get
            Set
                If Not Same(m_colFloorRatingBackColorHex, Value) Then
                    m_colFloorRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colFloorRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colFloorRatingBackColorHex As String

        Public Property colEarthquakeRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colEarthquakeRatingBackColorHex
            Get
                Return m_colEarthquakeRatingBackColorHex
            End Get
            Set
                If Not Same(m_colEarthquakeRatingBackColorHex, Value) Then
                    m_colEarthquakeRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colEarthquakeRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colEarthquakeRatingBackColorHex As String

        Public Property colWindstormRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colWindstormRatingBackColorHex
            Get
                Return m_colWindstormRatingBackColorHex
            End Get
            Set
                If Not Same(m_colWindstormRatingBackColorHex, Value) Then
                    m_colWindstormRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colWindstormRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colWindstormRatingBackColorHex As String

        Public Property colConstructionRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colConstructionRatingBackColorHex
            Get
                Return m_colConstructionRatingBackColorHex
            End Get
            Set
                If Not Same(m_colConstructionRatingBackColorHex, Value) Then
                    m_colConstructionRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colConstructionRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colConstructionRatingBackColorHex As String

        Public Property colOccupancyRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colOccupancyRatingBackColorHex
            Get
                Return m_colOccupancyRatingBackColorHex
            End Get
            Set
                If Not Same(m_colOccupancyRatingBackColorHex, Value) Then
                    m_colOccupancyRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colOccupancyRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colOccupancyRatingBackColorHex As String

        Public Property colOtherRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colOtherRatingBackColorHex
            Get
                Return m_colOtherRatingBackColorHex
            End Get
            Set
                If Not Same(m_colOtherRatingBackColorHex, Value) Then
                    m_colOtherRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colOtherRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colOtherRatingBackColorHex As String

        Public Property colPhysicalprotectionrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colPhysicalprotectionrating
            Get
                Return m_colPhysicalprotectionrating
            End Get
            Set
                If Not Same(m_colPhysicalprotectionrating, Value) Then
                    m_colPhysicalprotectionrating = Value
                    m_IsDirty(FieldIndex.colPhysicalprotectionrating) = True
                End If
            End Set
        End Property
        Private m_colPhysicalprotectionrating As Nullable(Of Decimal)

        Public Property colHumanelementrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colHumanelementrating
            Get
                Return m_colHumanelementrating
            End Get
            Set
                If Not Same(m_colHumanelementrating, Value) Then
                    m_colHumanelementrating = Value
                    m_IsDirty(FieldIndex.colHumanelementrating) = True
                End If
            End Set
        End Property
        Private m_colHumanelementrating As Nullable(Of Decimal)

        Public Property colNaturalhazardsprotectionrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colNaturalhazardsprotectionrating
            Get
                Return m_colNaturalhazardsprotectionrating
            End Get
            Set
                If Not Same(m_colNaturalhazardsprotectionrating, Value) Then
                    m_colNaturalhazardsprotectionrating = Value
                    m_IsDirty(FieldIndex.colNaturalhazardsprotectionrating) = True
                End If
            End Set
        End Property
        Private m_colNaturalhazardsprotectionrating As Nullable(Of Decimal)

        Public Property colBusinesscontinuityrating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colBusinesscontinuityrating
            Get
                Return m_colBusinesscontinuityrating
            End Get
            Set
                If Not Same(m_colBusinesscontinuityrating, Value) Then
                    m_colBusinesscontinuityrating = Value
                    m_IsDirty(FieldIndex.colBusinesscontinuityrating) = True
                End If
            End Set
        End Property
        Private m_colBusinesscontinuityrating As Nullable(Of Decimal)

        Public Property colPhysicalProtectionRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colPhysicalProtectionRatingBackColorHex
            Get
                Return m_colPhysicalProtectionRatingBackColorHex
            End Get
            Set
                If Not Same(m_colPhysicalProtectionRatingBackColorHex, Value) Then
                    m_colPhysicalProtectionRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionRatingBackColorHex As String

        Public Property colHumanElementRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementRatingBackColorHex
            Get
                Return m_colHumanElementRatingBackColorHex
            End Get
            Set
                If Not Same(m_colHumanElementRatingBackColorHex, Value) Then
                    m_colHumanElementRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colHumanElementRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colHumanElementRatingBackColorHex As String

        Public Property colNaturalHazardsProtectionRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colNaturalHazardsProtectionRatingBackColorHex
            Get
                Return m_colNaturalHazardsProtectionRatingBackColorHex
            End Get
            Set
                If Not Same(m_colNaturalHazardsProtectionRatingBackColorHex, Value) Then
                    m_colNaturalHazardsProtectionRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsProtectionRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsProtectionRatingBackColorHex As String

        Public Property colBusinessContinuityRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessContinuityRatingBackColorHex
            Get
                Return m_colBusinessContinuityRatingBackColorHex
            End Get
            Set
                If Not Same(m_colBusinessContinuityRatingBackColorHex, Value) Then
                    m_colBusinessContinuityRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityRatingBackColorHex As String

        Public Property colAplfactor() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colAplfactor
            Get
                Return m_colAplfactor
            End Get
            Set
                If Not Same(m_colAplfactor, Value) Then
                    m_colAplfactor = Value
                    m_IsDirty(FieldIndex.colAplfactor) = True
                End If
            End Set
        End Property
        Private m_colAplfactor As Nullable(Of Decimal)

        Public Property colOverallplantratingrating() As String Implements IrowVwWhatIfFireFacilityRating.colOverallplantratingrating
            Get
                Return m_colOverallplantratingrating
            End Get
            Set
                If Not Same(m_colOverallplantratingrating, Value) Then
                    m_colOverallplantratingrating = Value
                    m_IsDirty(FieldIndex.colOverallplantratingrating) = True
                End If
            End Set
        End Property
        Private m_colOverallplantratingrating As String

        Public Property colPassivescore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colPassivescore
            Get
                Return m_colPassivescore
            End Get
            Set
                If Not Same(m_colPassivescore, Value) Then
                    m_colPassivescore = Value
                    m_IsDirty(FieldIndex.colPassivescore) = True
                End If
            End Set
        End Property
        Private m_colPassivescore As Nullable(Of Decimal)

        Public Property colActivescore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colActivescore
            Get
                Return m_colActivescore
            End Get
            Set
                If Not Same(m_colActivescore, Value) Then
                    m_colActivescore = Value
                    m_IsDirty(FieldIndex.colActivescore) = True
                End If
            End Set
        End Property
        Private m_colActivescore As Nullable(Of Decimal)

        Public Property colWhatIfActiveScore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colWhatIfActiveScore
            Get
                Return m_colWhatIfActiveScore
            End Get
            Set
                If Not Same(m_colWhatIfActiveScore, Value) Then
                    m_colWhatIfActiveScore = Value
                    m_IsDirty(FieldIndex.colWhatIfActiveScore) = True
                End If
            End Set
        End Property
        Private m_colWhatIfActiveScore As Nullable(Of Decimal)

        Public Property colTotalscore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colTotalscore
            Get
                Return m_colTotalscore
            End Get
            Set
                If Not Same(m_colTotalscore, Value) Then
                    m_colTotalscore = Value
                    m_IsDirty(FieldIndex.colTotalscore) = True
                End If
            End Set
        End Property
        Private m_colTotalscore As Nullable(Of Decimal)

        Public Property colTotalScoreHexBackColor() As String Implements IrowVwWhatIfFireFacilityRating.colTotalScoreHexBackColor
            Get
                Return m_colTotalScoreHexBackColor
            End Get
            Set
                If Not Same(m_colTotalScoreHexBackColor, Value) Then
                    m_colTotalScoreHexBackColor = Value
                    m_IsDirty(FieldIndex.colTotalScoreHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colTotalScoreHexBackColor As String

        Public Property colTotalScoreHexForeColor() As String Implements IrowVwWhatIfFireFacilityRating.colTotalScoreHexForeColor
            Get
                Return m_colTotalScoreHexForeColor
            End Get
            Set
                If Not Same(m_colTotalScoreHexForeColor, Value) Then
                    m_colTotalScoreHexForeColor = Value
                    m_IsDirty(FieldIndex.colTotalScoreHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colTotalScoreHexForeColor As String

        Public Property colTotalscorerating() As String Implements IrowVwWhatIfFireFacilityRating.colTotalscorerating
            Get
                Return m_colTotalscorerating
            End Get
            Set
                If Not Same(m_colTotalscorerating, Value) Then
                    m_colTotalscorerating = Value
                    m_IsDirty(FieldIndex.colTotalscorerating) = True
                End If
            End Set
        End Property
        Private m_colTotalscorerating As String

        Public Property colWhatIfScore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colWhatIfScore
            Get
                Return m_colWhatIfScore
            End Get
            Set
                If Not Same(m_colWhatIfScore, Value) Then
                    m_colWhatIfScore = Value
                    m_IsDirty(FieldIndex.colWhatIfScore) = True
                End If
            End Set
        End Property
        Private m_colWhatIfScore As Nullable(Of Decimal)

        Public Property colWhatIfScoreHexBackColor() As String Implements IrowVwWhatIfFireFacilityRating.colWhatIfScoreHexBackColor
            Get
                Return m_colWhatIfScoreHexBackColor
            End Get
            Set
                If Not Same(m_colWhatIfScoreHexBackColor, Value) Then
                    m_colWhatIfScoreHexBackColor = Value
                    m_IsDirty(FieldIndex.colWhatIfScoreHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colWhatIfScoreHexBackColor As String

        Public Property colTotalfacilityscore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colTotalfacilityscore
            Get
                Return m_colTotalfacilityscore
            End Get
            Set
                If Not Same(m_colTotalfacilityscore, Value) Then
                    m_colTotalfacilityscore = Value
                    m_IsDirty(FieldIndex.colTotalfacilityscore) = True
                End If
            End Set
        End Property
        Private m_colTotalfacilityscore As Nullable(Of Decimal)

        Public Property colOtherweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colOtherweight
            Get
                Return m_colOtherweight
            End Get
            Set
                If Not Same(m_colOtherweight, Value) Then
                    m_colOtherweight = Value
                    m_IsDirty(FieldIndex.colOtherweight) = True
                End If
            End Set
        End Property
        Private m_colOtherweight As Nullable(Of Decimal)

        Public Property colConstructionweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colConstructionweight
            Get
                Return m_colConstructionweight
            End Get
            Set
                If Not Same(m_colConstructionweight, Value) Then
                    m_colConstructionweight = Value
                    m_IsDirty(FieldIndex.colConstructionweight) = True
                End If
            End Set
        End Property
        Private m_colConstructionweight As Nullable(Of Decimal)

        Public Property colOccupancyweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colOccupancyweight
            Get
                Return m_colOccupancyweight
            End Get
            Set
                If Not Same(m_colOccupancyweight, Value) Then
                    m_colOccupancyweight = Value
                    m_IsDirty(FieldIndex.colOccupancyweight) = True
                End If
            End Set
        End Property
        Private m_colOccupancyweight As Nullable(Of Decimal)

        Public Property colPhysicalprotectionweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colPhysicalprotectionweight
            Get
                Return m_colPhysicalprotectionweight
            End Get
            Set
                If Not Same(m_colPhysicalprotectionweight, Value) Then
                    m_colPhysicalprotectionweight = Value
                    m_IsDirty(FieldIndex.colPhysicalprotectionweight) = True
                End If
            End Set
        End Property
        Private m_colPhysicalprotectionweight As Nullable(Of Decimal)

        Public Property colHumanelementweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colHumanelementweight
            Get
                Return m_colHumanelementweight
            End Get
            Set
                If Not Same(m_colHumanelementweight, Value) Then
                    m_colHumanelementweight = Value
                    m_IsDirty(FieldIndex.colHumanelementweight) = True
                End If
            End Set
        End Property
        Private m_colHumanelementweight As Nullable(Of Decimal)

        Public Property colNaturalhazardsprotectionweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colNaturalhazardsprotectionweight
            Get
                Return m_colNaturalhazardsprotectionweight
            End Get
            Set
                If Not Same(m_colNaturalhazardsprotectionweight, Value) Then
                    m_colNaturalhazardsprotectionweight = Value
                    m_IsDirty(FieldIndex.colNaturalhazardsprotectionweight) = True
                End If
            End Set
        End Property
        Private m_colNaturalhazardsprotectionweight As Nullable(Of Decimal)

        Public Property colBusinesscontinuityweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colBusinesscontinuityweight
            Get
                Return m_colBusinesscontinuityweight
            End Get
            Set
                If Not Same(m_colBusinesscontinuityweight, Value) Then
                    m_colBusinesscontinuityweight = Value
                    m_IsDirty(FieldIndex.colBusinesscontinuityweight) = True
                End If
            End Set
        End Property
        Private m_colBusinesscontinuityweight As Nullable(Of Decimal)

        Public Property colFireprotectionallrecscompleterating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colFireprotectionallrecscompleterating
            Get
                Return m_colFireprotectionallrecscompleterating
            End Get
            Set
                If Not Same(m_colFireprotectionallrecscompleterating, Value) Then
                    m_colFireprotectionallrecscompleterating = Value
                    m_IsDirty(FieldIndex.colFireprotectionallrecscompleterating) = True
                End If
            End Set
        End Property
        Private m_colFireprotectionallrecscompleterating As Nullable(Of Decimal)

        Public Property colHumanelementallrecscompleterating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colHumanelementallrecscompleterating
            Get
                Return m_colHumanelementallrecscompleterating
            End Get
            Set
                If Not Same(m_colHumanelementallrecscompleterating, Value) Then
                    m_colHumanelementallrecscompleterating = Value
                    m_IsDirty(FieldIndex.colHumanelementallrecscompleterating) = True
                End If
            End Set
        End Property
        Private m_colHumanelementallrecscompleterating As Nullable(Of Decimal)

        Public Property colNathazprotallrecscompleterating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colNathazprotallrecscompleterating
            Get
                Return m_colNathazprotallrecscompleterating
            End Get
            Set
                If Not Same(m_colNathazprotallrecscompleterating, Value) Then
                    m_colNathazprotallrecscompleterating = Value
                    m_IsDirty(FieldIndex.colNathazprotallrecscompleterating) = True
                End If
            End Set
        End Property
        Private m_colNathazprotallrecscompleterating As Nullable(Of Decimal)

        Public Property colBcpAllRecsCompleteRating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colBcpAllRecsCompleteRating
            Get
                Return m_colBcpAllRecsCompleteRating
            End Get
            Set
                If Not Same(m_colBcpAllRecsCompleteRating, Value) Then
                    m_colBcpAllRecsCompleteRating = Value
                    m_IsDirty(FieldIndex.colBcpAllRecsCompleteRating) = True
                End If
            End Set
        End Property
        Private m_colBcpAllRecsCompleteRating As Nullable(Of Decimal)

        Public Property colFireProtectionAllRecsCompleteRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colFireProtectionAllRecsCompleteRatingBackColorHex
            Get
                Return m_colFireProtectionAllRecsCompleteRatingBackColorHex
            End Get
            Set
                If Not Same(m_colFireProtectionAllRecsCompleteRatingBackColorHex, Value) Then
                    m_colFireProtectionAllRecsCompleteRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colFireProtectionAllRecsCompleteRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colFireProtectionAllRecsCompleteRatingBackColorHex As String

        Public Property colHumanElementAllRecsCompleteRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementAllRecsCompleteRatingBackColorHex
            Get
                Return m_colHumanElementAllRecsCompleteRatingBackColorHex
            End Get
            Set
                If Not Same(m_colHumanElementAllRecsCompleteRatingBackColorHex, Value) Then
                    m_colHumanElementAllRecsCompleteRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colHumanElementAllRecsCompleteRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colHumanElementAllRecsCompleteRatingBackColorHex As String

        Public Property colNatHazProtAllRecsCompleteRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colNatHazProtAllRecsCompleteRatingBackColorHex
            Get
                Return m_colNatHazProtAllRecsCompleteRatingBackColorHex
            End Get
            Set
                If Not Same(m_colNatHazProtAllRecsCompleteRatingBackColorHex, Value) Then
                    m_colNatHazProtAllRecsCompleteRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colNatHazProtAllRecsCompleteRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colNatHazProtAllRecsCompleteRatingBackColorHex As String

        Public Property colBcpAllRecsCompleteRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colBcpAllRecsCompleteRatingBackColorHex
            Get
                Return m_colBcpAllRecsCompleteRatingBackColorHex
            End Get
            Set
                If Not Same(m_colBcpAllRecsCompleteRatingBackColorHex, Value) Then
                    m_colBcpAllRecsCompleteRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colBcpAllRecsCompleteRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colBcpAllRecsCompleteRatingBackColorHex As String

        Public Property colPhysicalProtectionWhatIfRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colPhysicalProtectionWhatIfRatingBackColorHex
            Get
                Return m_colPhysicalProtectionWhatIfRatingBackColorHex
            End Get
            Set
                If Not Same(m_colPhysicalProtectionWhatIfRatingBackColorHex, Value) Then
                    m_colPhysicalProtectionWhatIfRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionWhatIfRatingBackColorHex As String

        Public Property colHumanElementWhatIfRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementWhatIfRatingBackColorHex
            Get
                Return m_colHumanElementWhatIfRatingBackColorHex
            End Get
            Set
                If Not Same(m_colHumanElementWhatIfRatingBackColorHex, Value) Then
                    m_colHumanElementWhatIfRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colHumanElementWhatIfRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWhatIfRatingBackColorHex As String

        Public Property colNaturalHazardsProtectionWhatIfRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colNaturalHazardsProtectionWhatIfRatingBackColorHex
            Get
                Return m_colNaturalHazardsProtectionWhatIfRatingBackColorHex
            End Get
            Set
                If Not Same(m_colNaturalHazardsProtectionWhatIfRatingBackColorHex, Value) Then
                    m_colNaturalHazardsProtectionWhatIfRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsProtectionWhatIfRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsProtectionWhatIfRatingBackColorHex As String

        Public Property colBusinessContinuityWhatIfRatingBackColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessContinuityWhatIfRatingBackColorHex
            Get
                Return m_colBusinessContinuityWhatIfRatingBackColorHex
            End Get
            Set
                If Not Same(m_colBusinessContinuityWhatIfRatingBackColorHex, Value) Then
                    m_colBusinessContinuityWhatIfRatingBackColorHex = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRatingBackColorHex) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityWhatIfRatingBackColorHex As String

        Public Property colPhysicalProtectionWhatIfRating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colPhysicalProtectionWhatIfRating
            Get
                Return m_colPhysicalProtectionWhatIfRating
            End Get
            Set
                If Not Same(m_colPhysicalProtectionWhatIfRating, Value) Then
                    m_colPhysicalProtectionWhatIfRating = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRating) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionWhatIfRating As Nullable(Of Decimal)

        Public Property colHumanElementWhatIfRating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colHumanElementWhatIfRating
            Get
                Return m_colHumanElementWhatIfRating
            End Get
            Set
                If Not Same(m_colHumanElementWhatIfRating, Value) Then
                    m_colHumanElementWhatIfRating = Value
                    m_IsDirty(FieldIndex.colHumanElementWhatIfRating) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWhatIfRating As Nullable(Of Decimal)

        Public Property colNaturalHazardsWhatIfRating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colNaturalHazardsWhatIfRating
            Get
                Return m_colNaturalHazardsWhatIfRating
            End Get
            Set
                If Not Same(m_colNaturalHazardsWhatIfRating, Value) Then
                    m_colNaturalHazardsWhatIfRating = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsWhatIfRating) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsWhatIfRating As Nullable(Of Decimal)

        Public Property colBusinessContinuityWhatIfRating() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colBusinessContinuityWhatIfRating
            Get
                Return m_colBusinessContinuityWhatIfRating
            End Get
            Set
                If Not Same(m_colBusinessContinuityWhatIfRating, Value) Then
                    m_colBusinessContinuityWhatIfRating = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRating) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityWhatIfRating As Nullable(Of Decimal)

        Public Property colPhysicalProtectionWhatIfRatingDesc() As String Implements IrowVwWhatIfFireFacilityRating.colPhysicalProtectionWhatIfRatingDesc
            Get
                Return m_colPhysicalProtectionWhatIfRatingDesc
            End Get
            Set
                If Not Same(m_colPhysicalProtectionWhatIfRatingDesc, Value) Then
                    m_colPhysicalProtectionWhatIfRatingDesc = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRatingDesc) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionWhatIfRatingDesc As String

        Public Property colHumanElementWhatIfRatingDesc() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementWhatIfRatingDesc
            Get
                Return m_colHumanElementWhatIfRatingDesc
            End Get
            Set
                If Not Same(m_colHumanElementWhatIfRatingDesc, Value) Then
                    m_colHumanElementWhatIfRatingDesc = Value
                    m_IsDirty(FieldIndex.colHumanElementWhatIfRatingDesc) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWhatIfRatingDesc As String

        Public Property colNaturalHazardsWhatIfRatingDesc() As String Implements IrowVwWhatIfFireFacilityRating.colNaturalHazardsWhatIfRatingDesc
            Get
                Return m_colNaturalHazardsWhatIfRatingDesc
            End Get
            Set
                If Not Same(m_colNaturalHazardsWhatIfRatingDesc, Value) Then
                    m_colNaturalHazardsWhatIfRatingDesc = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsWhatIfRatingDesc) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsWhatIfRatingDesc As String

        Public Property colBusinessContinuityWhatIfRatingDesc() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessContinuityWhatIfRatingDesc
            Get
                Return m_colBusinessContinuityWhatIfRatingDesc
            End Get
            Set
                If Not Same(m_colBusinessContinuityWhatIfRatingDesc, Value) Then
                    m_colBusinessContinuityWhatIfRatingDesc = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRatingDesc) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityWhatIfRatingDesc As String

        Public Property colActivescorewithrecscomplete() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colActivescorewithrecscomplete
            Get
                Return m_colActivescorewithrecscomplete
            End Get
            Set
                If Not Same(m_colActivescorewithrecscomplete, Value) Then
                    m_colActivescorewithrecscomplete = Value
                    m_IsDirty(FieldIndex.colActivescorewithrecscomplete) = True
                End If
            End Set
        End Property
        Private m_colActivescorewithrecscomplete As Nullable(Of Decimal)

        Public Property colAplwithallrecscomplete() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colAplwithallrecscomplete
            Get
                Return m_colAplwithallrecscomplete
            End Get
            Set
                If Not Same(m_colAplwithallrecscomplete, Value) Then
                    m_colAplwithallrecscomplete = Value
                    m_IsDirty(FieldIndex.colAplwithallrecscomplete) = True
                End If
            End Set
        End Property
        Private m_colAplwithallrecscomplete As Nullable(Of Decimal)

        Public Property colFloodweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colFloodweight
            Get
                Return m_colFloodweight
            End Get
            Set
                If Not Same(m_colFloodweight, Value) Then
                    m_colFloodweight = Value
                    m_IsDirty(FieldIndex.colFloodweight) = True
                End If
            End Set
        End Property
        Private m_colFloodweight As Nullable(Of Decimal)

        Public Property colEarthquakeweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colEarthquakeweight
            Get
                Return m_colEarthquakeweight
            End Get
            Set
                If Not Same(m_colEarthquakeweight, Value) Then
                    m_colEarthquakeweight = Value
                    m_IsDirty(FieldIndex.colEarthquakeweight) = True
                End If
            End Set
        End Property
        Private m_colEarthquakeweight As Nullable(Of Decimal)

        Public Property colWindstormweight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colWindstormweight
            Get
                Return m_colWindstormweight
            End Get
            Set
                If Not Same(m_colWindstormweight, Value) Then
                    m_colWindstormweight = Value
                    m_IsDirty(FieldIndex.colWindstormweight) = True
                End If
            End Set
        End Property
        Private m_colWindstormweight As Nullable(Of Decimal)

        Public Property colOverallscorewithrecscomplete() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colOverallscorewithrecscomplete
            Get
                Return m_colOverallscorewithrecscomplete
            End Get
            Set
                If Not Same(m_colOverallscorewithrecscomplete, Value) Then
                    m_colOverallscorewithrecscomplete = Value
                    m_IsDirty(FieldIndex.colOverallscorewithrecscomplete) = True
                End If
            End Set
        End Property
        Private m_colOverallscorewithrecscomplete As Nullable(Of Decimal)

        Public Property colMaxpossiblescore() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colMaxpossiblescore
            Get
                Return m_colMaxpossiblescore
            End Get
            Set
                If Not Same(m_colMaxpossiblescore, Value) Then
                    m_colMaxpossiblescore = Value
                    m_IsDirty(FieldIndex.colMaxpossiblescore) = True
                End If
            End Set
        End Property
        Private m_colMaxpossiblescore As Nullable(Of Decimal)

        Public Property colAplfactorwithallrecscomplete() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colAplfactorwithallrecscomplete
            Get
                Return m_colAplfactorwithallrecscomplete
            End Get
            Set
                If Not Same(m_colAplfactorwithallrecscomplete, Value) Then
                    m_colAplfactorwithallrecscomplete = Value
                    m_IsDirty(FieldIndex.colAplfactorwithallrecscomplete) = True
                End If
            End Set
        End Property
        Private m_colAplfactorwithallrecscomplete As Nullable(Of Decimal)

        Public Property colFlooddescription() As String Implements IrowVwWhatIfFireFacilityRating.colFlooddescription
            Get
                Return m_colFlooddescription
            End Get
            Set
                If Not Same(m_colFlooddescription, Value) Then
                    m_colFlooddescription = Value
                    m_IsDirty(FieldIndex.colFlooddescription) = True
                End If
            End Set
        End Property
        Private m_colFlooddescription As String

        Public Property colEarthquakedescription() As String Implements IrowVwWhatIfFireFacilityRating.colEarthquakedescription
            Get
                Return m_colEarthquakedescription
            End Get
            Set
                If Not Same(m_colEarthquakedescription, Value) Then
                    m_colEarthquakedescription = Value
                    m_IsDirty(FieldIndex.colEarthquakedescription) = True
                End If
            End Set
        End Property
        Private m_colEarthquakedescription As String

        Public Property colWindstormdescription() As String Implements IrowVwWhatIfFireFacilityRating.colWindstormdescription
            Get
                Return m_colWindstormdescription
            End Get
            Set
                If Not Same(m_colWindstormdescription, Value) Then
                    m_colWindstormdescription = Value
                    m_IsDirty(FieldIndex.colWindstormdescription) = True
                End If
            End Set
        End Property
        Private m_colWindstormdescription As String

        Public Property colConstructiondescription() As String Implements IrowVwWhatIfFireFacilityRating.colConstructiondescription
            Get
                Return m_colConstructiondescription
            End Get
            Set
                If Not Same(m_colConstructiondescription, Value) Then
                    m_colConstructiondescription = Value
                    m_IsDirty(FieldIndex.colConstructiondescription) = True
                End If
            End Set
        End Property
        Private m_colConstructiondescription As String

        Public Property colOccupancydescription() As String Implements IrowVwWhatIfFireFacilityRating.colOccupancydescription
            Get
                Return m_colOccupancydescription
            End Get
            Set
                If Not Same(m_colOccupancydescription, Value) Then
                    m_colOccupancydescription = Value
                    m_IsDirty(FieldIndex.colOccupancydescription) = True
                End If
            End Set
        End Property
        Private m_colOccupancydescription As String

        Public Property colOtherdescription() As String Implements IrowVwWhatIfFireFacilityRating.colOtherdescription
            Get
                Return m_colOtherdescription
            End Get
            Set
                If Not Same(m_colOtherdescription, Value) Then
                    m_colOtherdescription = Value
                    m_IsDirty(FieldIndex.colOtherdescription) = True
                End If
            End Set
        End Property
        Private m_colOtherdescription As String

        Public Property colFiredescription() As String Implements IrowVwWhatIfFireFacilityRating.colFiredescription
            Get
                Return m_colFiredescription
            End Get
            Set
                If Not Same(m_colFiredescription, Value) Then
                    m_colFiredescription = Value
                    m_IsDirty(FieldIndex.colFiredescription) = True
                End If
            End Set
        End Property
        Private m_colFiredescription As String

        Public Property colHumandescription() As String Implements IrowVwWhatIfFireFacilityRating.colHumandescription
            Get
                Return m_colHumandescription
            End Get
            Set
                If Not Same(m_colHumandescription, Value) Then
                    m_colHumandescription = Value
                    m_IsDirty(FieldIndex.colHumandescription) = True
                End If
            End Set
        End Property
        Private m_colHumandescription As String

        Public Property colNaturaldescription() As String Implements IrowVwWhatIfFireFacilityRating.colNaturaldescription
            Get
                Return m_colNaturaldescription
            End Get
            Set
                If Not Same(m_colNaturaldescription, Value) Then
                    m_colNaturaldescription = Value
                    m_IsDirty(FieldIndex.colNaturaldescription) = True
                End If
            End Set
        End Property
        Private m_colNaturaldescription As String

        Public Property colBusinessdescription() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessdescription
            Get
                Return m_colBusinessdescription
            End Get
            Set
                If Not Same(m_colBusinessdescription, Value) Then
                    m_colBusinessdescription = Value
                    m_IsDirty(FieldIndex.colBusinessdescription) = True
                End If
            End Set
        End Property
        Private m_colBusinessdescription As String

        Public Property colFirerecdescription() As String Implements IrowVwWhatIfFireFacilityRating.colFirerecdescription
            Get
                Return m_colFirerecdescription
            End Get
            Set
                If Not Same(m_colFirerecdescription, Value) Then
                    m_colFirerecdescription = Value
                    m_IsDirty(FieldIndex.colFirerecdescription) = True
                End If
            End Set
        End Property
        Private m_colFirerecdescription As String

        Public Property colHumanrecdescription() As String Implements IrowVwWhatIfFireFacilityRating.colHumanrecdescription
            Get
                Return m_colHumanrecdescription
            End Get
            Set
                If Not Same(m_colHumanrecdescription, Value) Then
                    m_colHumanrecdescription = Value
                    m_IsDirty(FieldIndex.colHumanrecdescription) = True
                End If
            End Set
        End Property
        Private m_colHumanrecdescription As String

        Public Property colNaturalrecdescription() As String Implements IrowVwWhatIfFireFacilityRating.colNaturalrecdescription
            Get
                Return m_colNaturalrecdescription
            End Get
            Set
                If Not Same(m_colNaturalrecdescription, Value) Then
                    m_colNaturalrecdescription = Value
                    m_IsDirty(FieldIndex.colNaturalrecdescription) = True
                End If
            End Set
        End Property
        Private m_colNaturalrecdescription As String

        Public Property colBusinessrecdescription() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessrecdescription
            Get
                Return m_colBusinessrecdescription
            End Get
            Set
                If Not Same(m_colBusinessrecdescription, Value) Then
                    m_colBusinessrecdescription = Value
                    m_IsDirty(FieldIndex.colBusinessrecdescription) = True
                End If
            End Set
        End Property
        Private m_colBusinessrecdescription As String

        Public Property colExchangerate() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colExchangerate
            Get
                Return m_colExchangerate
            End Get
            Set
                If Not Same(m_colExchangerate, Value) Then
                    m_colExchangerate = Value
                    m_IsDirty(FieldIndex.colExchangerate) = True
                End If
            End Set
        End Property
        Private m_colExchangerate As Nullable(Of Decimal)

        Public Property colAdminmemo() As String Implements IrowVwWhatIfFireFacilityRating.colAdminmemo
            Get
                Return m_colAdminmemo
            End Get
            Set
                If Not Same(m_colAdminmemo, Value) Then
                    m_colAdminmemo = Value
                    m_IsDirty(FieldIndex.colAdminmemo) = True
                End If
            End Set
        End Property
        Private m_colAdminmemo As String

        Public Property colOverallscorewithrecscompleterating() As String Implements IrowVwWhatIfFireFacilityRating.colOverallscorewithrecscompleterating
            Get
                Return m_colOverallscorewithrecscompleterating
            End Get
            Set
                If Not Same(m_colOverallscorewithrecscompleterating, Value) Then
                    m_colOverallscorewithrecscompleterating = Value
                    m_IsDirty(FieldIndex.colOverallscorewithrecscompleterating) = True
                End If
            End Set
        End Property
        Private m_colOverallscorewithrecscompleterating As String

        Public Property colMaxpossiblerating() As String Implements IrowVwWhatIfFireFacilityRating.colMaxpossiblerating
            Get
                Return m_colMaxpossiblerating
            End Get
            Set
                If Not Same(m_colMaxpossiblerating, Value) Then
                    m_colMaxpossiblerating = Value
                    m_IsDirty(FieldIndex.colMaxpossiblerating) = True
                End If
            End Set
        End Property
        Private m_colMaxpossiblerating As String

        Public Property colOverallScoreWithRecsCompleteHexForeColor() As String Implements IrowVwWhatIfFireFacilityRating.colOverallScoreWithRecsCompleteHexForeColor
            Get
                Return m_colOverallScoreWithRecsCompleteHexForeColor
            End Get
            Set
                If Not Same(m_colOverallScoreWithRecsCompleteHexForeColor, Value) Then
                    m_colOverallScoreWithRecsCompleteHexForeColor = Value
                    m_IsDirty(FieldIndex.colOverallScoreWithRecsCompleteHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colOverallScoreWithRecsCompleteHexForeColor As String

        Public Property colOverallScoreWithRecsCompleteHexBackColor() As String Implements IrowVwWhatIfFireFacilityRating.colOverallScoreWithRecsCompleteHexBackColor
            Get
                Return m_colOverallScoreWithRecsCompleteHexBackColor
            End Get
            Set
                If Not Same(m_colOverallScoreWithRecsCompleteHexBackColor, Value) Then
                    m_colOverallScoreWithRecsCompleteHexBackColor = Value
                    m_IsDirty(FieldIndex.colOverallScoreWithRecsCompleteHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colOverallScoreWithRecsCompleteHexBackColor As String

        Public Property colAchievableScorePercent() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colAchievableScorePercent
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

        Public Property colAchievableScorePercentString() As String Implements IrowVwWhatIfFireFacilityRating.colAchievableScorePercentString
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

        Public Property colAchievableScorePercentHexForeColor() As String Implements IrowVwWhatIfFireFacilityRating.colAchievableScorePercentHexForeColor
            Get
                Return m_colAchievableScorePercentHexForeColor
            End Get
            Set
                If Not Same(m_colAchievableScorePercentHexForeColor, Value) Then
                    m_colAchievableScorePercentHexForeColor = Value
                    m_IsDirty(FieldIndex.colAchievableScorePercentHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colAchievableScorePercentHexForeColor As String

        Public Property colAchievableScorePercentHexBackColor() As String Implements IrowVwWhatIfFireFacilityRating.colAchievableScorePercentHexBackColor
            Get
                Return m_colAchievableScorePercentHexBackColor
            End Get
            Set
                If Not Same(m_colAchievableScorePercentHexBackColor, Value) Then
                    m_colAchievableScorePercentHexBackColor = Value
                    m_IsDirty(FieldIndex.colAchievableScorePercentHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colAchievableScorePercentHexBackColor As String

        Public Property colIsLatestRating() As String Implements IrowVwWhatIfFireFacilityRating.colIsLatestRating
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

        Public Property colAchievablePercentWhatIfString() As String Implements IrowVwWhatIfFireFacilityRating.colAchievablePercentWhatIfString
            Get
                Return m_colAchievablePercentWhatIfString
            End Get
            Set
                If Not Same(m_colAchievablePercentWhatIfString, Value) Then
                    m_colAchievablePercentWhatIfString = Value
                    m_IsDirty(FieldIndex.colAchievablePercentWhatIfString) = True
                End If
            End Set
        End Property
        Private m_colAchievablePercentWhatIfString As String

        Public Property colAchievablePercentWhatIfHexBackColor() As String Implements IrowVwWhatIfFireFacilityRating.colAchievablePercentWhatIfHexBackColor
            Get
                Return m_colAchievablePercentWhatIfHexBackColor
            End Get
            Set
                If Not Same(m_colAchievablePercentWhatIfHexBackColor, Value) Then
                    m_colAchievablePercentWhatIfHexBackColor = Value
                    m_IsDirty(FieldIndex.colAchievablePercentWhatIfHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colAchievablePercentWhatIfHexBackColor As String

        Public Property colAchievablePercentWhatIfHexForeColor() As String Implements IrowVwWhatIfFireFacilityRating.colAchievablePercentWhatIfHexForeColor
            Get
                Return m_colAchievablePercentWhatIfHexForeColor
            End Get
            Set
                If Not Same(m_colAchievablePercentWhatIfHexForeColor, Value) Then
                    m_colAchievablePercentWhatIfHexForeColor = Value
                    m_IsDirty(FieldIndex.colAchievablePercentWhatIfHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colAchievablePercentWhatIfHexForeColor As String

        Public Property colAchievablePercentAllRecsCompHexBackColor() As String Implements IrowVwWhatIfFireFacilityRating.colAchievablePercentAllRecsCompHexBackColor
            Get
                Return m_colAchievablePercentAllRecsCompHexBackColor
            End Get
            Set
                If Not Same(m_colAchievablePercentAllRecsCompHexBackColor, Value) Then
                    m_colAchievablePercentAllRecsCompHexBackColor = Value
                    m_IsDirty(FieldIndex.colAchievablePercentAllRecsCompHexBackColor) = True
                End If
            End Set
        End Property
        Private m_colAchievablePercentAllRecsCompHexBackColor As String

        Public Property colAchievablePercentAllRecsCompHexForeColor() As String Implements IrowVwWhatIfFireFacilityRating.colAchievablePercentAllRecsCompHexForeColor
            Get
                Return m_colAchievablePercentAllRecsCompHexForeColor
            End Get
            Set
                If Not Same(m_colAchievablePercentAllRecsCompHexForeColor, Value) Then
                    m_colAchievablePercentAllRecsCompHexForeColor = Value
                    m_IsDirty(FieldIndex.colAchievablePercentAllRecsCompHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colAchievablePercentAllRecsCompHexForeColor As String

        Public Property colAchievablePercentAllRecsCompString() As String Implements IrowVwWhatIfFireFacilityRating.colAchievablePercentAllRecsCompString
            Get
                Return m_colAchievablePercentAllRecsCompString
            End Get
            Set
                If Not Same(m_colAchievablePercentAllRecsCompString, Value) Then
                    m_colAchievablePercentAllRecsCompString = Value
                    m_IsDirty(FieldIndex.colAchievablePercentAllRecsCompString) = True
                End If
            End Set
        End Property
        Private m_colAchievablePercentAllRecsCompString As String

        Public Property colRatingID() As Nullable(Of Decimal) Implements IrowVwWhatIfFireFacilityRating.colRatingID
            Get
                Return m_colRatingID
            End Get
            Set
                If Not Same(m_colRatingID, Value) Then
                    m_colRatingID = Value
                    m_IsDirty(FieldIndex.colRatingID) = True
                End If
            End Set
        End Property
        Private m_colRatingID As Nullable(Of Decimal)

        Public Property colFloorRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colFloorRatingForeColorHex
            Get
                Return m_colFloorRatingForeColorHex
            End Get
            Set
                If Not Same(m_colFloorRatingForeColorHex, Value) Then
                    m_colFloorRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colFloorRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colFloorRatingForeColorHex As String

        Public Property colEarthquakeRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colEarthquakeRatingForeColorHex
            Get
                Return m_colEarthquakeRatingForeColorHex
            End Get
            Set
                If Not Same(m_colEarthquakeRatingForeColorHex, Value) Then
                    m_colEarthquakeRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colEarthquakeRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colEarthquakeRatingForeColorHex As String

        Public Property colWindstormRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colWindstormRatingForeColorHex
            Get
                Return m_colWindstormRatingForeColorHex
            End Get
            Set
                If Not Same(m_colWindstormRatingForeColorHex, Value) Then
                    m_colWindstormRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colWindstormRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colWindstormRatingForeColorHex As String

        Public Property colConstructionRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colConstructionRatingForeColorHex
            Get
                Return m_colConstructionRatingForeColorHex
            End Get
            Set
                If Not Same(m_colConstructionRatingForeColorHex, Value) Then
                    m_colConstructionRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colConstructionRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colConstructionRatingForeColorHex As String

        Public Property colOccupancyRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colOccupancyRatingForeColorHex
            Get
                Return m_colOccupancyRatingForeColorHex
            End Get
            Set
                If Not Same(m_colOccupancyRatingForeColorHex, Value) Then
                    m_colOccupancyRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colOccupancyRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colOccupancyRatingForeColorHex As String

        Public Property colOtherRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colOtherRatingForeColorHex
            Get
                Return m_colOtherRatingForeColorHex
            End Get
            Set
                If Not Same(m_colOtherRatingForeColorHex, Value) Then
                    m_colOtherRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colOtherRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colOtherRatingForeColorHex As String

        Public Property colPhysicalProtectionRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colPhysicalProtectionRatingForeColorHex
            Get
                Return m_colPhysicalProtectionRatingForeColorHex
            End Get
            Set
                If Not Same(m_colPhysicalProtectionRatingForeColorHex, Value) Then
                    m_colPhysicalProtectionRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionRatingForeColorHex As String

        Public Property colHumanElementRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementRatingForeColorHex
            Get
                Return m_colHumanElementRatingForeColorHex
            End Get
            Set
                If Not Same(m_colHumanElementRatingForeColorHex, Value) Then
                    m_colHumanElementRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colHumanElementRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colHumanElementRatingForeColorHex As String

        Public Property colNaturalHazardsProtectionRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colNaturalHazardsProtectionRatingForeColorHex
            Get
                Return m_colNaturalHazardsProtectionRatingForeColorHex
            End Get
            Set
                If Not Same(m_colNaturalHazardsProtectionRatingForeColorHex, Value) Then
                    m_colNaturalHazardsProtectionRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsProtectionRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsProtectionRatingForeColorHex As String

        Public Property colBusinessContinuityRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessContinuityRatingForeColorHex
            Get
                Return m_colBusinessContinuityRatingForeColorHex
            End Get
            Set
                If Not Same(m_colBusinessContinuityRatingForeColorHex, Value) Then
                    m_colBusinessContinuityRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityRatingForeColorHex As String

        Public Property colFireProtectionAllRecsCompleteRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colFireProtectionAllRecsCompleteRatingForeColorHex
            Get
                Return m_colFireProtectionAllRecsCompleteRatingForeColorHex
            End Get
            Set
                If Not Same(m_colFireProtectionAllRecsCompleteRatingForeColorHex, Value) Then
                    m_colFireProtectionAllRecsCompleteRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colFireProtectionAllRecsCompleteRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colFireProtectionAllRecsCompleteRatingForeColorHex As String

        Public Property colHumanElementAllRecsCompleteRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementAllRecsCompleteRatingForeColorHex
            Get
                Return m_colHumanElementAllRecsCompleteRatingForeColorHex
            End Get
            Set
                If Not Same(m_colHumanElementAllRecsCompleteRatingForeColorHex, Value) Then
                    m_colHumanElementAllRecsCompleteRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colHumanElementAllRecsCompleteRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colHumanElementAllRecsCompleteRatingForeColorHex As String

        Public Property colNatHazProtAllRecsCompleteRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colNatHazProtAllRecsCompleteRatingForeColorHex
            Get
                Return m_colNatHazProtAllRecsCompleteRatingForeColorHex
            End Get
            Set
                If Not Same(m_colNatHazProtAllRecsCompleteRatingForeColorHex, Value) Then
                    m_colNatHazProtAllRecsCompleteRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colNatHazProtAllRecsCompleteRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colNatHazProtAllRecsCompleteRatingForeColorHex As String

        Public Property colBcpAllRecsCompleteRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colBcpAllRecsCompleteRatingForeColorHex
            Get
                Return m_colBcpAllRecsCompleteRatingForeColorHex
            End Get
            Set
                If Not Same(m_colBcpAllRecsCompleteRatingForeColorHex, Value) Then
                    m_colBcpAllRecsCompleteRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colBcpAllRecsCompleteRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colBcpAllRecsCompleteRatingForeColorHex As String

        Public Property colWhatIfScoreHexForeColor() As String Implements IrowVwWhatIfFireFacilityRating.colWhatIfScoreHexForeColor
            Get
                Return m_colWhatIfScoreHexForeColor
            End Get
            Set
                If Not Same(m_colWhatIfScoreHexForeColor, Value) Then
                    m_colWhatIfScoreHexForeColor = Value
                    m_IsDirty(FieldIndex.colWhatIfScoreHexForeColor) = True
                End If
            End Set
        End Property
        Private m_colWhatIfScoreHexForeColor As String

        Public Property colPhysicalProtectionWhatIfRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colPhysicalProtectionWhatIfRatingForeColorHex
            Get
                Return m_colPhysicalProtectionWhatIfRatingForeColorHex
            End Get
            Set
                If Not Same(m_colPhysicalProtectionWhatIfRatingForeColorHex, Value) Then
                    m_colPhysicalProtectionWhatIfRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colPhysicalProtectionWhatIfRatingForeColorHex As String

        Public Property colHumanElementWhatIfRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colHumanElementWhatIfRatingForeColorHex
            Get
                Return m_colHumanElementWhatIfRatingForeColorHex
            End Get
            Set
                If Not Same(m_colHumanElementWhatIfRatingForeColorHex, Value) Then
                    m_colHumanElementWhatIfRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colHumanElementWhatIfRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWhatIfRatingForeColorHex As String

        Public Property colNaturalHazardsProtectionWhatIfRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colNaturalHazardsProtectionWhatIfRatingForeColorHex
            Get
                Return m_colNaturalHazardsProtectionWhatIfRatingForeColorHex
            End Get
            Set
                If Not Same(m_colNaturalHazardsProtectionWhatIfRatingForeColorHex, Value) Then
                    m_colNaturalHazardsProtectionWhatIfRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colNaturalHazardsProtectionWhatIfRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colNaturalHazardsProtectionWhatIfRatingForeColorHex As String

        Public Property colBusinessContinuityWhatIfRatingForeColorHex() As String Implements IrowVwWhatIfFireFacilityRating.colBusinessContinuityWhatIfRatingForeColorHex
            Get
                Return m_colBusinessContinuityWhatIfRatingForeColorHex
            End Get
            Set
                If Not Same(m_colBusinessContinuityWhatIfRatingForeColorHex, Value) Then
                    m_colBusinessContinuityWhatIfRatingForeColorHex = Value
                    m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRatingForeColorHex) = True
                End If
            End Set
        End Property
        Private m_colBusinessContinuityWhatIfRatingForeColorHex As String


        Public Function IsDirty(pIndex As rowVwWhatIfFireFacilityRating.FieldIndex) As Boolean Implements IrowVwWhatIfFireFacilityRating.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwWhatIfFireFacilityRating.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwWhatIfFireFacilityRating.SetIsDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colAddressStamp) = pDirty
            m_IsDirty(FieldIndex.colAddress1) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStprov) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colZip) = pDirty
            m_IsDirty(FieldIndex.colTiv) = pDirty
            m_IsDirty(FieldIndex.colTivbi) = pDirty
            m_IsDirty(FieldIndex.colTivpd) = pDirty
            m_IsDirty(FieldIndex.colPml) = pDirty
            m_IsDirty(FieldIndex.colPmlpd) = pDirty
            m_IsDirty(FieldIndex.colPmlbi) = pDirty
            m_IsDirty(FieldIndex.colMflpd) = pDirty
            m_IsDirty(FieldIndex.colMflbi) = pDirty
            m_IsDirty(FieldIndex.colMfl) = pDirty
            m_IsDirty(FieldIndex.colAplpd) = pDirty
            m_IsDirty(FieldIndex.colAplbi) = pDirty
            m_IsDirty(FieldIndex.colApl) = pDirty
            m_IsDirty(FieldIndex.colInspectiondate) = pDirty
            m_IsDirty(FieldIndex.colGrade) = pDirty
            m_IsDirty(FieldIndex.colConstructionrating) = pDirty
            m_IsDirty(FieldIndex.colOccupancyrating) = pDirty
            m_IsDirty(FieldIndex.colFloodrating) = pDirty
            m_IsDirty(FieldIndex.colEarthquakerating) = pDirty
            m_IsDirty(FieldIndex.colWindstormrating) = pDirty
            m_IsDirty(FieldIndex.colOtherrating) = pDirty
            m_IsDirty(FieldIndex.colFloorRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colEarthquakeRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colWindstormRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colConstructionRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colOccupancyRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colOtherRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colPhysicalprotectionrating) = pDirty
            m_IsDirty(FieldIndex.colHumanelementrating) = pDirty
            m_IsDirty(FieldIndex.colNaturalhazardsprotectionrating) = pDirty
            m_IsDirty(FieldIndex.colBusinesscontinuityrating) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colHumanElementRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsProtectionRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colAplfactor) = pDirty
            m_IsDirty(FieldIndex.colOverallplantratingrating) = pDirty
            m_IsDirty(FieldIndex.colPassivescore) = pDirty
            m_IsDirty(FieldIndex.colActivescore) = pDirty
            m_IsDirty(FieldIndex.colWhatIfActiveScore) = pDirty
            m_IsDirty(FieldIndex.colTotalscore) = pDirty
            m_IsDirty(FieldIndex.colTotalScoreHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colTotalScoreHexForeColor) = pDirty
            m_IsDirty(FieldIndex.colTotalscorerating) = pDirty
            m_IsDirty(FieldIndex.colWhatIfScore) = pDirty
            m_IsDirty(FieldIndex.colWhatIfScoreHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colTotalfacilityscore) = pDirty
            m_IsDirty(FieldIndex.colOtherweight) = pDirty
            m_IsDirty(FieldIndex.colConstructionweight) = pDirty
            m_IsDirty(FieldIndex.colOccupancyweight) = pDirty
            m_IsDirty(FieldIndex.colPhysicalprotectionweight) = pDirty
            m_IsDirty(FieldIndex.colHumanelementweight) = pDirty
            m_IsDirty(FieldIndex.colNaturalhazardsprotectionweight) = pDirty
            m_IsDirty(FieldIndex.colBusinesscontinuityweight) = pDirty
            m_IsDirty(FieldIndex.colFireprotectionallrecscompleterating) = pDirty
            m_IsDirty(FieldIndex.colHumanelementallrecscompleterating) = pDirty
            m_IsDirty(FieldIndex.colNathazprotallrecscompleterating) = pDirty
            m_IsDirty(FieldIndex.colBcpAllRecsCompleteRating) = pDirty
            m_IsDirty(FieldIndex.colFireProtectionAllRecsCompleteRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colHumanElementAllRecsCompleteRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colNatHazProtAllRecsCompleteRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colBcpAllRecsCompleteRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWhatIfRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsProtectionWhatIfRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRatingBackColorHex) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRating) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWhatIfRating) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsWhatIfRating) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRating) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRatingDesc) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWhatIfRatingDesc) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsWhatIfRatingDesc) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRatingDesc) = pDirty
            m_IsDirty(FieldIndex.colActivescorewithrecscomplete) = pDirty
            m_IsDirty(FieldIndex.colAplwithallrecscomplete) = pDirty
            m_IsDirty(FieldIndex.colFloodweight) = pDirty
            m_IsDirty(FieldIndex.colEarthquakeweight) = pDirty
            m_IsDirty(FieldIndex.colWindstormweight) = pDirty
            m_IsDirty(FieldIndex.colOverallscorewithrecscomplete) = pDirty
            m_IsDirty(FieldIndex.colMaxpossiblescore) = pDirty
            m_IsDirty(FieldIndex.colAplfactorwithallrecscomplete) = pDirty
            m_IsDirty(FieldIndex.colFlooddescription) = pDirty
            m_IsDirty(FieldIndex.colEarthquakedescription) = pDirty
            m_IsDirty(FieldIndex.colWindstormdescription) = pDirty
            m_IsDirty(FieldIndex.colConstructiondescription) = pDirty
            m_IsDirty(FieldIndex.colOccupancydescription) = pDirty
            m_IsDirty(FieldIndex.colOtherdescription) = pDirty
            m_IsDirty(FieldIndex.colFiredescription) = pDirty
            m_IsDirty(FieldIndex.colHumandescription) = pDirty
            m_IsDirty(FieldIndex.colNaturaldescription) = pDirty
            m_IsDirty(FieldIndex.colBusinessdescription) = pDirty
            m_IsDirty(FieldIndex.colFirerecdescription) = pDirty
            m_IsDirty(FieldIndex.colHumanrecdescription) = pDirty
            m_IsDirty(FieldIndex.colNaturalrecdescription) = pDirty
            m_IsDirty(FieldIndex.colBusinessrecdescription) = pDirty
            m_IsDirty(FieldIndex.colExchangerate) = pDirty
            m_IsDirty(FieldIndex.colAdminmemo) = pDirty
            m_IsDirty(FieldIndex.colOverallscorewithrecscompleterating) = pDirty
            m_IsDirty(FieldIndex.colMaxpossiblerating) = pDirty
            m_IsDirty(FieldIndex.colOverallScoreWithRecsCompleteHexForeColor) = pDirty
            m_IsDirty(FieldIndex.colOverallScoreWithRecsCompleteHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colAchievableScorePercent) = pDirty
            m_IsDirty(FieldIndex.colAchievableScorePercentString) = pDirty
            m_IsDirty(FieldIndex.colAchievableScorePercentHexForeColor) = pDirty
            m_IsDirty(FieldIndex.colAchievableScorePercentHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colIsLatestRating) = pDirty
            m_IsDirty(FieldIndex.colAchievablePercentWhatIfString) = pDirty
            m_IsDirty(FieldIndex.colAchievablePercentWhatIfHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colAchievablePercentWhatIfHexForeColor) = pDirty
            m_IsDirty(FieldIndex.colAchievablePercentAllRecsCompHexBackColor) = pDirty
            m_IsDirty(FieldIndex.colAchievablePercentAllRecsCompHexForeColor) = pDirty
            m_IsDirty(FieldIndex.colAchievablePercentAllRecsCompString) = pDirty
            m_IsDirty(FieldIndex.colRatingID) = pDirty
            m_IsDirty(FieldIndex.colFloorRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colEarthquakeRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colWindstormRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colConstructionRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colOccupancyRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colOtherRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colHumanElementRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsProtectionRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colFireProtectionAllRecsCompleteRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colHumanElementAllRecsCompleteRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colNatHazProtAllRecsCompleteRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colBcpAllRecsCompleteRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colWhatIfScoreHexForeColor) = pDirty
            m_IsDirty(FieldIndex.colPhysicalProtectionWhatIfRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWhatIfRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colNaturalHazardsProtectionWhatIfRatingForeColorHex) = pDirty
            m_IsDirty(FieldIndex.colBusinessContinuityWhatIfRatingForeColorHex) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwWhatIfFireFacilityRating) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwWhatIfFireFacilityRating
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colGSafeId  = 1
            colFileNo 
            colAddressStamp 
            colAddress1 
            colCity 
            colStprov 
            colCountry 
            colDivision 
            colZip 
            colTiv 
            colTivbi 
            colTivpd 
            colPml 
            colPmlpd 
            colPmlbi 
            colMflpd 
            colMflbi 
            colMfl 
            colAplpd 
            colAplbi 
            colApl 
            colInspectiondate 
            colGrade 
            colConstructionrating 
            colOccupancyrating 
            colFloodrating 
            colEarthquakerating 
            colWindstormrating 
            colOtherrating 
            colFloorRatingBackColorHex 
            colEarthquakeRatingBackColorHex 
            colWindstormRatingBackColorHex 
            colConstructionRatingBackColorHex 
            colOccupancyRatingBackColorHex 
            colOtherRatingBackColorHex 
            colPhysicalprotectionrating 
            colHumanelementrating 
            colNaturalhazardsprotectionrating 
            colBusinesscontinuityrating 
            colPhysicalProtectionRatingBackColorHex 
            colHumanElementRatingBackColorHex 
            colNaturalHazardsProtectionRatingBackColorHex 
            colBusinessContinuityRatingBackColorHex 
            colAplfactor 
            colOverallplantratingrating 
            colPassivescore 
            colActivescore 
            colWhatIfActiveScore 
            colTotalscore 
            colTotalScoreHexBackColor 
            colTotalScoreHexForeColor 
            colTotalscorerating 
            colWhatIfScore 
            colWhatIfScoreHexBackColor 
            colTotalfacilityscore 
            colOtherweight 
            colConstructionweight 
            colOccupancyweight 
            colPhysicalprotectionweight 
            colHumanelementweight 
            colNaturalhazardsprotectionweight 
            colBusinesscontinuityweight 
            colFireprotectionallrecscompleterating 
            colHumanelementallrecscompleterating 
            colNathazprotallrecscompleterating 
            colBcpAllRecsCompleteRating 
            colFireProtectionAllRecsCompleteRatingBackColorHex 
            colHumanElementAllRecsCompleteRatingBackColorHex 
            colNatHazProtAllRecsCompleteRatingBackColorHex 
            colBcpAllRecsCompleteRatingBackColorHex 
            colPhysicalProtectionWhatIfRatingBackColorHex 
            colHumanElementWhatIfRatingBackColorHex 
            colNaturalHazardsProtectionWhatIfRatingBackColorHex 
            colBusinessContinuityWhatIfRatingBackColorHex 
            colPhysicalProtectionWhatIfRating 
            colHumanElementWhatIfRating 
            colNaturalHazardsWhatIfRating 
            colBusinessContinuityWhatIfRating 
            colPhysicalProtectionWhatIfRatingDesc 
            colHumanElementWhatIfRatingDesc 
            colNaturalHazardsWhatIfRatingDesc 
            colBusinessContinuityWhatIfRatingDesc 
            colActivescorewithrecscomplete 
            colAplwithallrecscomplete 
            colFloodweight 
            colEarthquakeweight 
            colWindstormweight 
            colOverallscorewithrecscomplete 
            colMaxpossiblescore 
            colAplfactorwithallrecscomplete 
            colFlooddescription 
            colEarthquakedescription 
            colWindstormdescription 
            colConstructiondescription 
            colOccupancydescription 
            colOtherdescription 
            colFiredescription 
            colHumandescription 
            colNaturaldescription 
            colBusinessdescription 
            colFirerecdescription 
            colHumanrecdescription 
            colNaturalrecdescription 
            colBusinessrecdescription 
            colExchangerate 
            colAdminmemo 
            colOverallscorewithrecscompleterating 
            colMaxpossiblerating 
            colOverallScoreWithRecsCompleteHexForeColor 
            colOverallScoreWithRecsCompleteHexBackColor 
            colAchievableScorePercent 
            colAchievableScorePercentString 
            colAchievableScorePercentHexForeColor 
            colAchievableScorePercentHexBackColor 
            colIsLatestRating 
            colAchievablePercentWhatIfString 
            colAchievablePercentWhatIfHexBackColor 
            colAchievablePercentWhatIfHexForeColor 
            colAchievablePercentAllRecsCompHexBackColor 
            colAchievablePercentAllRecsCompHexForeColor 
            colAchievablePercentAllRecsCompString 
            colRatingID 
            colFloorRatingForeColorHex 
            colEarthquakeRatingForeColorHex 
            colWindstormRatingForeColorHex 
            colConstructionRatingForeColorHex 
            colOccupancyRatingForeColorHex 
            colOtherRatingForeColorHex 
            colPhysicalProtectionRatingForeColorHex 
            colHumanElementRatingForeColorHex 
            colNaturalHazardsProtectionRatingForeColorHex 
            colBusinessContinuityRatingForeColorHex 
            colFireProtectionAllRecsCompleteRatingForeColorHex 
            colHumanElementAllRecsCompleteRatingForeColorHex 
            colNatHazProtAllRecsCompleteRatingForeColorHex 
            colBcpAllRecsCompleteRatingForeColorHex 
            colWhatIfScoreHexForeColor 
            colPhysicalProtectionWhatIfRatingForeColorHex 
            colHumanElementWhatIfRatingForeColorHex 
            colNaturalHazardsProtectionWhatIfRatingForeColorHex 
            colBusinessContinuityWhatIfRatingForeColorHex 
        End Enum

        Private m_IsDirty(141) As Boolean

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

    Public Interface IrowVwWhatIfFireFacilityRating
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colGSafeId() As Nullable(Of Integer)
        Property colFileNo() As String
        Property colAddressStamp() As String
        Property colAddress1() As String
        Property colCity() As String
        Property colStprov() As String
        Property colCountry() As String
        Property colDivision() As String
        Property colZip() As String
        Property colTiv() As Nullable(Of Double)
        Property colTivbi() As Nullable(Of Double)
        Property colTivpd() As Nullable(Of Double)
        Property colPml() As Nullable(Of Double)
        Property colPmlpd() As Nullable(Of Double)
        Property colPmlbi() As Nullable(Of Double)
        Property colMflpd() As Nullable(Of Double)
        Property colMflbi() As Nullable(Of Double)
        Property colMfl() As Nullable(Of Double)
        Property colAplpd() As Nullable(Of Double)
        Property colAplbi() As Nullable(Of Double)
        Property colApl() As Nullable(Of Double)
        Property colInspectiondate() As Nullable(Of DateTime)
        Property colGrade() As Nullable(Of Decimal)
        Property colConstructionrating() As Nullable(Of Decimal)
        Property colOccupancyrating() As Nullable(Of Decimal)
        Property colFloodrating() As Nullable(Of Decimal)
        Property colEarthquakerating() As Nullable(Of Decimal)
        Property colWindstormrating() As Nullable(Of Decimal)
        Property colOtherrating() As Nullable(Of Decimal)
        Property colFloorRatingBackColorHex() As String
        Property colEarthquakeRatingBackColorHex() As String
        Property colWindstormRatingBackColorHex() As String
        Property colConstructionRatingBackColorHex() As String
        Property colOccupancyRatingBackColorHex() As String
        Property colOtherRatingBackColorHex() As String
        Property colPhysicalprotectionrating() As Nullable(Of Decimal)
        Property colHumanelementrating() As Nullable(Of Decimal)
        Property colNaturalhazardsprotectionrating() As Nullable(Of Decimal)
        Property colBusinesscontinuityrating() As Nullable(Of Decimal)
        Property colPhysicalProtectionRatingBackColorHex() As String
        Property colHumanElementRatingBackColorHex() As String
        Property colNaturalHazardsProtectionRatingBackColorHex() As String
        Property colBusinessContinuityRatingBackColorHex() As String
        Property colAplfactor() As Nullable(Of Decimal)
        Property colOverallplantratingrating() As String
        Property colPassivescore() As Nullable(Of Decimal)
        Property colActivescore() As Nullable(Of Decimal)
        Property colWhatIfActiveScore() As Nullable(Of Decimal)
        Property colTotalscore() As Nullable(Of Decimal)
        Property colTotalScoreHexBackColor() As String
        Property colTotalScoreHexForeColor() As String
        Property colTotalscorerating() As String
        Property colWhatIfScore() As Nullable(Of Decimal)
        Property colWhatIfScoreHexBackColor() As String
        Property colTotalfacilityscore() As Nullable(Of Decimal)
        Property colOtherweight() As Nullable(Of Decimal)
        Property colConstructionweight() As Nullable(Of Decimal)
        Property colOccupancyweight() As Nullable(Of Decimal)
        Property colPhysicalprotectionweight() As Nullable(Of Decimal)
        Property colHumanelementweight() As Nullable(Of Decimal)
        Property colNaturalhazardsprotectionweight() As Nullable(Of Decimal)
        Property colBusinesscontinuityweight() As Nullable(Of Decimal)
        Property colFireprotectionallrecscompleterating() As Nullable(Of Decimal)
        Property colHumanelementallrecscompleterating() As Nullable(Of Decimal)
        Property colNathazprotallrecscompleterating() As Nullable(Of Decimal)
        Property colBcpAllRecsCompleteRating() As Nullable(Of Decimal)
        Property colFireProtectionAllRecsCompleteRatingBackColorHex() As String
        Property colHumanElementAllRecsCompleteRatingBackColorHex() As String
        Property colNatHazProtAllRecsCompleteRatingBackColorHex() As String
        Property colBcpAllRecsCompleteRatingBackColorHex() As String
        Property colPhysicalProtectionWhatIfRatingBackColorHex() As String
        Property colHumanElementWhatIfRatingBackColorHex() As String
        Property colNaturalHazardsProtectionWhatIfRatingBackColorHex() As String
        Property colBusinessContinuityWhatIfRatingBackColorHex() As String
        Property colPhysicalProtectionWhatIfRating() As Nullable(Of Decimal)
        Property colHumanElementWhatIfRating() As Nullable(Of Decimal)
        Property colNaturalHazardsWhatIfRating() As Nullable(Of Decimal)
        Property colBusinessContinuityWhatIfRating() As Nullable(Of Decimal)
        Property colPhysicalProtectionWhatIfRatingDesc() As String
        Property colHumanElementWhatIfRatingDesc() As String
        Property colNaturalHazardsWhatIfRatingDesc() As String
        Property colBusinessContinuityWhatIfRatingDesc() As String
        Property colActivescorewithrecscomplete() As Nullable(Of Decimal)
        Property colAplwithallrecscomplete() As Nullable(Of Decimal)
        Property colFloodweight() As Nullable(Of Decimal)
        Property colEarthquakeweight() As Nullable(Of Decimal)
        Property colWindstormweight() As Nullable(Of Decimal)
        Property colOverallscorewithrecscomplete() As Nullable(Of Decimal)
        Property colMaxpossiblescore() As Nullable(Of Decimal)
        Property colAplfactorwithallrecscomplete() As Nullable(Of Decimal)
        Property colFlooddescription() As String
        Property colEarthquakedescription() As String
        Property colWindstormdescription() As String
        Property colConstructiondescription() As String
        Property colOccupancydescription() As String
        Property colOtherdescription() As String
        Property colFiredescription() As String
        Property colHumandescription() As String
        Property colNaturaldescription() As String
        Property colBusinessdescription() As String
        Property colFirerecdescription() As String
        Property colHumanrecdescription() As String
        Property colNaturalrecdescription() As String
        Property colBusinessrecdescription() As String
        Property colExchangerate() As Nullable(Of Decimal)
        Property colAdminmemo() As String
        Property colOverallscorewithrecscompleterating() As String
        Property colMaxpossiblerating() As String
        Property colOverallScoreWithRecsCompleteHexForeColor() As String
        Property colOverallScoreWithRecsCompleteHexBackColor() As String
        Property colAchievableScorePercent() As Nullable(Of Decimal)
        Property colAchievableScorePercentString() As String
        Property colAchievableScorePercentHexForeColor() As String
        Property colAchievableScorePercentHexBackColor() As String
        Property colIsLatestRating() As String
        Property colAchievablePercentWhatIfString() As String
        Property colAchievablePercentWhatIfHexBackColor() As String
        Property colAchievablePercentWhatIfHexForeColor() As String
        Property colAchievablePercentAllRecsCompHexBackColor() As String
        Property colAchievablePercentAllRecsCompHexForeColor() As String
        Property colAchievablePercentAllRecsCompString() As String
        Property colRatingID() As Nullable(Of Decimal)
        Property colFloorRatingForeColorHex() As String
        Property colEarthquakeRatingForeColorHex() As String
        Property colWindstormRatingForeColorHex() As String
        Property colConstructionRatingForeColorHex() As String
        Property colOccupancyRatingForeColorHex() As String
        Property colOtherRatingForeColorHex() As String
        Property colPhysicalProtectionRatingForeColorHex() As String
        Property colHumanElementRatingForeColorHex() As String
        Property colNaturalHazardsProtectionRatingForeColorHex() As String
        Property colBusinessContinuityRatingForeColorHex() As String
        Property colFireProtectionAllRecsCompleteRatingForeColorHex() As String
        Property colHumanElementAllRecsCompleteRatingForeColorHex() As String
        Property colNatHazProtAllRecsCompleteRatingForeColorHex() As String
        Property colBcpAllRecsCompleteRatingForeColorHex() As String
        Property colWhatIfScoreHexForeColor() As String
        Property colPhysicalProtectionWhatIfRatingForeColorHex() As String
        Property colHumanElementWhatIfRatingForeColorHex() As String
        Property colNaturalHazardsProtectionWhatIfRatingForeColorHex() As String
        Property colBusinessContinuityWhatIfRatingForeColorHex() As String
        Function IsDirty(pIndex As rowVwWhatIfFireFacilityRating.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

