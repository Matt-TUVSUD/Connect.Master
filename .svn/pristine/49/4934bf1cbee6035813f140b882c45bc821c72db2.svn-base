'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwFireLossEstimatesLatestFacilityRatingExtractSelect
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colClient As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colAddress As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colLatitude As New razor.UtilSQLServer.StringDataColumn
        Public colLongitude As New razor.UtilSQLServer.StringDataColumn
        Public colBIReporting As New razor.UtilSQLServer.StringDataColumn
        Public colApl As New razor.UtilSQLServer.DoubleDataColumn
        Public colAplpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colAplbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colAPLPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colAPLPDPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colAPLBIPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colPml As New razor.UtilSQLServer.DoubleDataColumn
        Public colPmlpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colPmlbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colPMLPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colPMLPDPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colPMLBIPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colMfl As New razor.UtilSQLServer.DoubleDataColumn
        Public colMflpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colMflbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colMFLPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colMFLPDPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colMFLBIPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colTiv As New razor.UtilSQLServer.DoubleDataColumn
        Public colTivpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colTivbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colInterdependencies As New razor.UtilSQLServer.StringDataColumn
        Public colLEandInterdependecyComments As New razor.UtilSQLServer.StringDataColumn
        Public colLossesLast3Years As New razor.UtilSQLServer.StringDataColumn
        Public colLossHistoryDescription As New razor.UtilSQLServer.StringDataColumn
        Public colInspectionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colActiveScore As New razor.UtilSQLServer.DecimalDataColumn
        Public colPassiveScore As New razor.UtilSQLServer.DecimalDataColumn
        Public colTotalScore As New razor.UtilSQLServer.DoubleDataColumn
        Public colOverallRating As New razor.UtilSQLServer.StringDataColumn
        Public colTotalscoreColor As New razor.UtilSQLServer.StringDataColumn
        Public colOccupancy As New razor.UtilSQLServer.StringDataColumn
        Public colIndustryGroup As New razor.UtilSQLServer.StringDataColumn
        Public colMajorGroup As New razor.UtilSQLServer.StringDataColumn
        Public colSpecificGroup As New razor.UtilSQLServer.StringDataColumn
        Public colActiveScoreWithRecsComplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colOverallScoreWithRecsComplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colMaxPossibleScore As New razor.UtilSQLServer.DecimalDataColumn
        Public colConstructionRating As New razor.UtilSQLServer.LongDataColumn
        Public colOccupancyRating As New razor.UtilSQLServer.LongDataColumn
        Public colFloodRating As New razor.UtilSQLServer.LongDataColumn
        Public colEarthquakeRating As New razor.UtilSQLServer.LongDataColumn
        Public colWindstormRating As New razor.UtilSQLServer.LongDataColumn
        Public colOtherRating As New razor.UtilSQLServer.LongDataColumn
        Public colPhysicalProtectionRating As New razor.UtilSQLServer.LongDataColumn
        Public colHumanElementRating As New razor.UtilSQLServer.LongDataColumn
        Public colNaturalHazardsProtectionRating As New razor.UtilSQLServer.LongDataColumn
        Public colBusinessContinuityRating As New razor.UtilSQLServer.LongDataColumn
        Public colAplFactor As New razor.UtilSQLServer.DecimalDataColumn
        Public colAPLFactorWithAllRecsComplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colOtherWeight As New razor.UtilSQLServer.LongDataColumn
        Public colConstructionWeight As New razor.UtilSQLServer.LongDataColumn
        Public colOccupancyWeight As New razor.UtilSQLServer.LongDataColumn
        Public colPhysicalProtectionWeight As New razor.UtilSQLServer.LongDataColumn
        Public colHumanElementWeight As New razor.UtilSQLServer.LongDataColumn
        Public colNaturalHazardsProtectionWeight As New razor.UtilSQLServer.LongDataColumn
        Public colBusinessContinuityWeight As New razor.UtilSQLServer.LongDataColumn
        Public colFireProtectionAllRecsCompleteRating As New razor.UtilSQLServer.LongDataColumn
        Public colHumanElementAllRecsCompleteRating As New razor.UtilSQLServer.LongDataColumn
        Public colNatHazProtAllRecsCompleteRating As New razor.UtilSQLServer.LongDataColumn
        Public colBcpAllRecsCompletRating As New razor.UtilSQLServer.LongDataColumn
        Public colFloodWeight As New razor.UtilSQLServer.LongDataColumn
        Public colEarthquakeWeight As New razor.UtilSQLServer.LongDataColumn
        Public colWindstormWeight As New razor.UtilSQLServer.LongDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colInspProgramYearFROM As New razor.UtilSQLServer.DateTimeDataColumn
        Public colInspProgramYear As New razor.UtilSQLServer.StringDataColumn
        Public colAchievableScorePercent As New razor.UtilSQLServer.DecimalDataColumn
        Public colAchievableScorePercentString As New razor.UtilSQLServer.StringDataColumn
        Public colIsLatestRating As New razor.UtilSQLServer.StringDataColumn
        Public colIbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colHighestLossExpectancy As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFilePrefix.ColumnName = "[FilePrefix]"
            colFileNo.ColumnName = "[FileNo]"
            colClient.ColumnName = "[Client]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colDivision.ColumnName = "[Division]"
            colFacility.ColumnName = "[Facility]"
            colAddress.ColumnName = "[Address]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colLatitude.ColumnName = "[Latitude]"
            colLongitude.ColumnName = "[Longitude]"
            colBIReporting.ColumnName = "[BIReporting]"
            colApl.ColumnName = "[APL]"
            colAplpd.ColumnName = "[APLPD]"
            colAplbi.ColumnName = "[APLBI]"
            colAPLPercent.ColumnName = "[APLPercent]"
            colAPLPDPercent.ColumnName = "[APLPDPercent]"
            colAPLBIPercent.ColumnName = "[APLBIPercent]"
            colPml.ColumnName = "[PML]"
            colPmlpd.ColumnName = "[PMLPD]"
            colPmlbi.ColumnName = "[PMLBI]"
            colPMLPercent.ColumnName = "[PMLPercent]"
            colPMLPDPercent.ColumnName = "[PMLPDPercent]"
            colPMLBIPercent.ColumnName = "[PMLBIPercent]"
            colMfl.ColumnName = "[MFL]"
            colMflpd.ColumnName = "[MFLPD]"
            colMflbi.ColumnName = "[MFLBI]"
            colMFLPercent.ColumnName = "[MFLPercent]"
            colMFLPDPercent.ColumnName = "[MFLPDPercent]"
            colMFLBIPercent.ColumnName = "[MFLBIPercent]"
            colTiv.ColumnName = "[TIV]"
            colTivpd.ColumnName = "[TIVPD]"
            colTivbi.ColumnName = "[TIVBI]"
            colInterdependencies.ColumnName = "[Interdependencies]"
            colLEandInterdependecyComments.ColumnName = "[LEandInterdependecyComments]"
            colLossesLast3Years.ColumnName = "[Losses_Last_3_Years]"
            colLossHistoryDescription.ColumnName = "[Loss_History_Description]"
            colInspectionDate.ColumnName = "[InspectionDate]"
            colActiveScore.ColumnName = "[ActiveScore]"
            colPassiveScore.ColumnName = "[PassiveScore]"
            colTotalScore.ColumnName = "[TotalScore]"
            colOverallRating.ColumnName = "[OverallRating]"
            colTotalscoreColor.ColumnName = "[totalscoreColor]"
            colOccupancy.ColumnName = "[Occupancy]"
            colIndustryGroup.ColumnName = "[IndustryGroup]"
            colMajorGroup.ColumnName = "[MajorGroup]"
            colSpecificGroup.ColumnName = "[SpecificGroup]"
            colActiveScoreWithRecsComplete.ColumnName = "[Active_Score_With_Recs_Complete]"
            colOverallScoreWithRecsComplete.ColumnName = "[OverallScoreWithRecsComplete]"
            colMaxPossibleScore.ColumnName = "[MaxPossibleScore]"
            colConstructionRating.ColumnName = "[Construction_Rating]"
            colOccupancyRating.ColumnName = "[Occupancy_Rating]"
            colFloodRating.ColumnName = "[Flood_Rating]"
            colEarthquakeRating.ColumnName = "[Earthquake_Rating]"
            colWindstormRating.ColumnName = "[Windstorm_Rating]"
            colOtherRating.ColumnName = "[Other_Rating]"
            colPhysicalProtectionRating.ColumnName = "[Physical_Protection_Rating]"
            colHumanElementRating.ColumnName = "[Human_Element_Rating]"
            colNaturalHazardsProtectionRating.ColumnName = "[Natural_Hazards_Protection_Rating]"
            colBusinessContinuityRating.ColumnName = "[Business_Continuity_Rating]"
            colAplFactor.ColumnName = "[APL_Factor]"
            colAPLFactorWithAllRecsComplete.ColumnName = "[APLFactorWithAllRecsComplete]"
            colOtherWeight.ColumnName = "[Other_Weight]"
            colConstructionWeight.ColumnName = "[Construction_Weight]"
            colOccupancyWeight.ColumnName = "[Occupancy_Weight]"
            colPhysicalProtectionWeight.ColumnName = "[Physical_Protection_Weight]"
            colHumanElementWeight.ColumnName = "[Human_Element_Weight]"
            colNaturalHazardsProtectionWeight.ColumnName = "[Natural_Hazards_Protection_Weight]"
            colBusinessContinuityWeight.ColumnName = "[Business_Continuity_Weight]"
            colFireProtectionAllRecsCompleteRating.ColumnName = "[Fire_Protection_All_Recs_Complete_Rating]"
            colHumanElementAllRecsCompleteRating.ColumnName = "[Human_Element_All_Recs_Complete_Rating]"
            colNatHazProtAllRecsCompleteRating.ColumnName = "[Nat_Haz_Prot_All_Recs_Complete_Rating]"
            colBcpAllRecsCompletRating.ColumnName = "[BCP_All_Recs_Complet_Rating]"
            colFloodWeight.ColumnName = "[Flood_Weight]"
            colEarthquakeWeight.ColumnName = "[Earthquake_Weight]"
            colWindstormWeight.ColumnName = "[Windstorm_Weight]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colInspProgramYearFROM.ColumnName = "[InspProgramYearFROM]"
            colInspProgramYear.ColumnName = "[InspProgramYear]"
            colAchievableScorePercent.ColumnName = "[AchievableScorePercent]"
            colAchievableScorePercentString.ColumnName = "[AchievableScorePercentString]"
            colIsLatestRating.ColumnName = "[IsLatestRating]"
            colIbi.ColumnName = "[IBI]"
            colHighestLossExpectancy.ColumnName = "[HighestLossExpectancy]"

            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colClient", colClient)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colAddress", colAddress)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colLatitude", colLatitude)
            _Members.Add("colLongitude", colLongitude)
            _Members.Add("colBIReporting", colBIReporting)
            _Members.Add("colApl", colApl)
            _Members.Add("colAplpd", colAplpd)
            _Members.Add("colAplbi", colAplbi)
            _Members.Add("colAPLPercent", colAPLPercent)
            _Members.Add("colAPLPDPercent", colAPLPDPercent)
            _Members.Add("colAPLBIPercent", colAPLBIPercent)
            _Members.Add("colPml", colPml)
            _Members.Add("colPmlpd", colPmlpd)
            _Members.Add("colPmlbi", colPmlbi)
            _Members.Add("colPMLPercent", colPMLPercent)
            _Members.Add("colPMLPDPercent", colPMLPDPercent)
            _Members.Add("colPMLBIPercent", colPMLBIPercent)
            _Members.Add("colMfl", colMfl)
            _Members.Add("colMflpd", colMflpd)
            _Members.Add("colMflbi", colMflbi)
            _Members.Add("colMFLPercent", colMFLPercent)
            _Members.Add("colMFLPDPercent", colMFLPDPercent)
            _Members.Add("colMFLBIPercent", colMFLBIPercent)
            _Members.Add("colTiv", colTiv)
            _Members.Add("colTivpd", colTivpd)
            _Members.Add("colTivbi", colTivbi)
            _Members.Add("colInterdependencies", colInterdependencies)
            _Members.Add("colLEandInterdependecyComments", colLEandInterdependecyComments)
            _Members.Add("colLossesLast3Years", colLossesLast3Years)
            _Members.Add("colLossHistoryDescription", colLossHistoryDescription)
            _Members.Add("colInspectionDate", colInspectionDate)
            _Members.Add("colActiveScore", colActiveScore)
            _Members.Add("colPassiveScore", colPassiveScore)
            _Members.Add("colTotalScore", colTotalScore)
            _Members.Add("colOverallRating", colOverallRating)
            _Members.Add("colTotalscoreColor", colTotalscoreColor)
            _Members.Add("colOccupancy", colOccupancy)
            _Members.Add("colIndustryGroup", colIndustryGroup)
            _Members.Add("colMajorGroup", colMajorGroup)
            _Members.Add("colSpecificGroup", colSpecificGroup)
            _Members.Add("colActiveScoreWithRecsComplete", colActiveScoreWithRecsComplete)
            _Members.Add("colOverallScoreWithRecsComplete", colOverallScoreWithRecsComplete)
            _Members.Add("colMaxPossibleScore", colMaxPossibleScore)
            _Members.Add("colConstructionRating", colConstructionRating)
            _Members.Add("colOccupancyRating", colOccupancyRating)
            _Members.Add("colFloodRating", colFloodRating)
            _Members.Add("colEarthquakeRating", colEarthquakeRating)
            _Members.Add("colWindstormRating", colWindstormRating)
            _Members.Add("colOtherRating", colOtherRating)
            _Members.Add("colPhysicalProtectionRating", colPhysicalProtectionRating)
            _Members.Add("colHumanElementRating", colHumanElementRating)
            _Members.Add("colNaturalHazardsProtectionRating", colNaturalHazardsProtectionRating)
            _Members.Add("colBusinessContinuityRating", colBusinessContinuityRating)
            _Members.Add("colAplFactor", colAplFactor)
            _Members.Add("colAPLFactorWithAllRecsComplete", colAPLFactorWithAllRecsComplete)
            _Members.Add("colOtherWeight", colOtherWeight)
            _Members.Add("colConstructionWeight", colConstructionWeight)
            _Members.Add("colOccupancyWeight", colOccupancyWeight)
            _Members.Add("colPhysicalProtectionWeight", colPhysicalProtectionWeight)
            _Members.Add("colHumanElementWeight", colHumanElementWeight)
            _Members.Add("colNaturalHazardsProtectionWeight", colNaturalHazardsProtectionWeight)
            _Members.Add("colBusinessContinuityWeight", colBusinessContinuityWeight)
            _Members.Add("colFireProtectionAllRecsCompleteRating", colFireProtectionAllRecsCompleteRating)
            _Members.Add("colHumanElementAllRecsCompleteRating", colHumanElementAllRecsCompleteRating)
            _Members.Add("colNatHazProtAllRecsCompleteRating", colNatHazProtAllRecsCompleteRating)
            _Members.Add("colBcpAllRecsCompletRating", colBcpAllRecsCompletRating)
            _Members.Add("colFloodWeight", colFloodWeight)
            _Members.Add("colEarthquakeWeight", colEarthquakeWeight)
            _Members.Add("colWindstormWeight", colWindstormWeight)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colInspProgramYearFROM", colInspProgramYearFROM)
            _Members.Add("colInspProgramYear", colInspProgramYear)
            _Members.Add("colAchievableScorePercent", colAchievableScorePercent)
            _Members.Add("colAchievableScorePercentString", colAchievableScorePercentString)
            _Members.Add("colIsLatestRating", colIsLatestRating)
            _Members.Add("colIbi", colIbi)
            _Members.Add("colHighestLossExpectancy", colHighestLossExpectancy)
        End Sub

        Public Function Member(pObjectName As String) As Object
            Dim zReturn As Object = Nothing
            If _Members.ContainsKey(pObjectName) Then
                zReturn = _Members.Item(pObjectName)
            Else
                Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in member dictionary.")
            End If
            Return zReturn
        End Function

        Public Function MemberColumn(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colClient"
                    Return "[Client]"
                Case "colClientLocNo"
                    Return "[ClientLocNo]"
                Case "colDivision"
                    Return "[Division]"
                Case "colFacility"
                    Return "[Facility]"
                Case "colAddress"
                    Return "[Address]"
                Case "colCity"
                    Return "[City]"
                Case "colStProv"
                    Return "[StProv]"
                Case "colCountry"
                    Return "[Country]"
                Case "colLatitude"
                    Return "[Latitude]"
                Case "colLongitude"
                    Return "[Longitude]"
                Case "colBIReporting"
                    Return "[BIReporting]"
                Case "colApl"
                    Return "[APL]"
                Case "colAplpd"
                    Return "[APLPD]"
                Case "colAplbi"
                    Return "[APLBI]"
                Case "colAPLPercent"
                    Return "[APLPercent]"
                Case "colAPLPDPercent"
                    Return "[APLPDPercent]"
                Case "colAPLBIPercent"
                    Return "[APLBIPercent]"
                Case "colPml"
                    Return "[PML]"
                Case "colPmlpd"
                    Return "[PMLPD]"
                Case "colPmlbi"
                    Return "[PMLBI]"
                Case "colPMLPercent"
                    Return "[PMLPercent]"
                Case "colPMLPDPercent"
                    Return "[PMLPDPercent]"
                Case "colPMLBIPercent"
                    Return "[PMLBIPercent]"
                Case "colMfl"
                    Return "[MFL]"
                Case "colMflpd"
                    Return "[MFLPD]"
                Case "colMflbi"
                    Return "[MFLBI]"
                Case "colMFLPercent"
                    Return "[MFLPercent]"
                Case "colMFLPDPercent"
                    Return "[MFLPDPercent]"
                Case "colMFLBIPercent"
                    Return "[MFLBIPercent]"
                Case "colTiv"
                    Return "[TIV]"
                Case "colTivpd"
                    Return "[TIVPD]"
                Case "colTivbi"
                    Return "[TIVBI]"
                Case "colInterdependencies"
                    Return "[Interdependencies]"
                Case "colLEandInterdependecyComments"
                    Return "[LEandInterdependecyComments]"
                Case "colLossesLast3Years"
                    Return "[Losses_Last_3_Years]"
                Case "colLossHistoryDescription"
                    Return "[Loss_History_Description]"
                Case "colInspectionDate"
                    Return "[InspectionDate]"
                Case "colActiveScore"
                    Return "[ActiveScore]"
                Case "colPassiveScore"
                    Return "[PassiveScore]"
                Case "colTotalScore"
                    Return "[TotalScore]"
                Case "colOverallRating"
                    Return "[OverallRating]"
                Case "colTotalscoreColor"
                    Return "[totalscoreColor]"
                Case "colOccupancy"
                    Return "[Occupancy]"
                Case "colIndustryGroup"
                    Return "[IndustryGroup]"
                Case "colMajorGroup"
                    Return "[MajorGroup]"
                Case "colSpecificGroup"
                    Return "[SpecificGroup]"
                Case "colActiveScoreWithRecsComplete"
                    Return "[Active_Score_With_Recs_Complete]"
                Case "colOverallScoreWithRecsComplete"
                    Return "[OverallScoreWithRecsComplete]"
                Case "colMaxPossibleScore"
                    Return "[MaxPossibleScore]"
                Case "colConstructionRating"
                    Return "[Construction_Rating]"
                Case "colOccupancyRating"
                    Return "[Occupancy_Rating]"
                Case "colFloodRating"
                    Return "[Flood_Rating]"
                Case "colEarthquakeRating"
                    Return "[Earthquake_Rating]"
                Case "colWindstormRating"
                    Return "[Windstorm_Rating]"
                Case "colOtherRating"
                    Return "[Other_Rating]"
                Case "colPhysicalProtectionRating"
                    Return "[Physical_Protection_Rating]"
                Case "colHumanElementRating"
                    Return "[Human_Element_Rating]"
                Case "colNaturalHazardsProtectionRating"
                    Return "[Natural_Hazards_Protection_Rating]"
                Case "colBusinessContinuityRating"
                    Return "[Business_Continuity_Rating]"
                Case "colAplFactor"
                    Return "[APL_Factor]"
                Case "colAPLFactorWithAllRecsComplete"
                    Return "[APLFactorWithAllRecsComplete]"
                Case "colOtherWeight"
                    Return "[Other_Weight]"
                Case "colConstructionWeight"
                    Return "[Construction_Weight]"
                Case "colOccupancyWeight"
                    Return "[Occupancy_Weight]"
                Case "colPhysicalProtectionWeight"
                    Return "[Physical_Protection_Weight]"
                Case "colHumanElementWeight"
                    Return "[Human_Element_Weight]"
                Case "colNaturalHazardsProtectionWeight"
                    Return "[Natural_Hazards_Protection_Weight]"
                Case "colBusinessContinuityWeight"
                    Return "[Business_Continuity_Weight]"
                Case "colFireProtectionAllRecsCompleteRating"
                    Return "[Fire_Protection_All_Recs_Complete_Rating]"
                Case "colHumanElementAllRecsCompleteRating"
                    Return "[Human_Element_All_Recs_Complete_Rating]"
                Case "colNatHazProtAllRecsCompleteRating"
                    Return "[Nat_Haz_Prot_All_Recs_Complete_Rating]"
                Case "colBcpAllRecsCompletRating"
                    Return "[BCP_All_Recs_Complet_Rating]"
                Case "colFloodWeight"
                    Return "[Flood_Weight]"
                Case "colEarthquakeWeight"
                    Return "[Earthquake_Weight]"
                Case "colWindstormWeight"
                    Return "[Windstorm_Weight]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colInspProgramYearFROM"
                    Return "[InspProgramYearFROM]"
                Case "colInspProgramYear"
                    Return "[InspProgramYear]"
                Case "colAchievableScorePercent"
                    Return "[AchievableScorePercent]"
                Case "colAchievableScorePercentString"
                    Return "[AchievableScorePercentString]"
                Case "colIsLatestRating"
                    Return "[IsLatestRating]"
                Case "colIbi"
                    Return "[IBI]"
                Case "colHighestLossExpectancy"
                    Return "[HighestLossExpectancy]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[Client]", "Client", "Client", "colClient"  
                    Return "colClient"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "colClientLocNo"  
                    Return "colClientLocNo"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[Facility]", "Facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case "[Address]", "Address", "Address", "colAddress"  
                    Return "colAddress"
                Case "[City]", "City", "City", "colCity"  
                    Return "colCity"
                Case "[StProv]", "StProv", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[Country]", "Country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[Latitude]", "Latitude", "Latitude", "colLatitude"  
                    Return "colLatitude"
                Case "[Longitude]", "Longitude", "Longitude", "colLongitude"  
                    Return "colLongitude"
                Case "[BIReporting]", "BIReporting", "BIReporting", "colBIReporting"  
                    Return "colBIReporting"
                Case "[APL]", "APL", "Apl", "colApl"  
                    Return "colApl"
                Case "[APLPD]", "APLPD", "Aplpd", "colAplpd"  
                    Return "colAplpd"
                Case "[APLBI]", "APLBI", "Aplbi", "colAplbi"  
                    Return "colAplbi"
                Case "[APLPercent]", "APLPercent", "APLPercent", "colAPLPercent"  
                    Return "colAPLPercent"
                Case "[APLPDPercent]", "APLPDPercent", "APLPDPercent", "colAPLPDPercent"  
                    Return "colAPLPDPercent"
                Case "[APLBIPercent]", "APLBIPercent", "APLBIPercent", "colAPLBIPercent"  
                    Return "colAPLBIPercent"
                Case "[PML]", "PML", "Pml", "colPml"  
                    Return "colPml"
                Case "[PMLPD]", "PMLPD", "Pmlpd", "colPmlpd"  
                    Return "colPmlpd"
                Case "[PMLBI]", "PMLBI", "Pmlbi", "colPmlbi"  
                    Return "colPmlbi"
                Case "[PMLPercent]", "PMLPercent", "PMLPercent", "colPMLPercent"  
                    Return "colPMLPercent"
                Case "[PMLPDPercent]", "PMLPDPercent", "PMLPDPercent", "colPMLPDPercent"  
                    Return "colPMLPDPercent"
                Case "[PMLBIPercent]", "PMLBIPercent", "PMLBIPercent", "colPMLBIPercent"  
                    Return "colPMLBIPercent"
                Case "[MFL]", "MFL", "Mfl", "colMfl"  
                    Return "colMfl"
                Case "[MFLPD]", "MFLPD", "Mflpd", "colMflpd"  
                    Return "colMflpd"
                Case "[MFLBI]", "MFLBI", "Mflbi", "colMflbi"  
                    Return "colMflbi"
                Case "[MFLPercent]", "MFLPercent", "MFLPercent", "colMFLPercent"  
                    Return "colMFLPercent"
                Case "[MFLPDPercent]", "MFLPDPercent", "MFLPDPercent", "colMFLPDPercent"  
                    Return "colMFLPDPercent"
                Case "[MFLBIPercent]", "MFLBIPercent", "MFLBIPercent", "colMFLBIPercent"  
                    Return "colMFLBIPercent"
                Case "[TIV]", "TIV", "Tiv", "colTiv"  
                    Return "colTiv"
                Case "[TIVPD]", "TIVPD", "Tivpd", "colTivpd"  
                    Return "colTivpd"
                Case "[TIVBI]", "TIVBI", "Tivbi", "colTivbi"  
                    Return "colTivbi"
                Case "[Interdependencies]", "Interdependencies", "Interdependencies", "colInterdependencies"  
                    Return "colInterdependencies"
                Case "[LEandInterdependecyComments]", "LEandInterdependecyComments", "LEandInterdependecyComments", "colLEandInterdependecyComments"  
                    Return "colLEandInterdependecyComments"
                Case "[Losses_Last_3_Years]", "Losses_Last_3_Years", "LossesLast3Years", "colLossesLast3Years"  
                    Return "colLossesLast3Years"
                Case "[Loss_History_Description]", "Loss_History_Description", "LossHistoryDescription", "colLossHistoryDescription"  
                    Return "colLossHistoryDescription"
                Case "[InspectionDate]", "InspectionDate", "InspectionDate", "colInspectionDate"  
                    Return "colInspectionDate"
                Case "[ActiveScore]", "ActiveScore", "ActiveScore", "colActiveScore"  
                    Return "colActiveScore"
                Case "[PassiveScore]", "PassiveScore", "PassiveScore", "colPassiveScore"  
                    Return "colPassiveScore"
                Case "[TotalScore]", "TotalScore", "TotalScore", "colTotalScore"  
                    Return "colTotalScore"
                Case "[OverallRating]", "OverallRating", "OverallRating", "colOverallRating"  
                    Return "colOverallRating"
                Case "[totalscoreColor]", "totalscoreColor", "TotalscoreColor", "colTotalscoreColor"  
                    Return "colTotalscoreColor"
                Case "[Occupancy]", "Occupancy", "Occupancy", "colOccupancy"  
                    Return "colOccupancy"
                Case "[IndustryGroup]", "IndustryGroup", "IndustryGroup", "colIndustryGroup"  
                    Return "colIndustryGroup"
                Case "[MajorGroup]", "MajorGroup", "MajorGroup", "colMajorGroup"  
                    Return "colMajorGroup"
                Case "[SpecificGroup]", "SpecificGroup", "SpecificGroup", "colSpecificGroup"  
                    Return "colSpecificGroup"
                Case "[Active_Score_With_Recs_Complete]", "Active_Score_With_Recs_Complete", "ActiveScoreWithRecsComplete", "colActiveScoreWithRecsComplete"  
                    Return "colActiveScoreWithRecsComplete"
                Case "[OverallScoreWithRecsComplete]", "OverallScoreWithRecsComplete", "OverallScoreWithRecsComplete", "colOverallScoreWithRecsComplete"  
                    Return "colOverallScoreWithRecsComplete"
                Case "[MaxPossibleScore]", "MaxPossibleScore", "MaxPossibleScore", "colMaxPossibleScore"  
                    Return "colMaxPossibleScore"
                Case "[Construction_Rating]", "Construction_Rating", "ConstructionRating", "colConstructionRating"  
                    Return "colConstructionRating"
                Case "[Occupancy_Rating]", "Occupancy_Rating", "OccupancyRating", "colOccupancyRating"  
                    Return "colOccupancyRating"
                Case "[Flood_Rating]", "Flood_Rating", "FloodRating", "colFloodRating"  
                    Return "colFloodRating"
                Case "[Earthquake_Rating]", "Earthquake_Rating", "EarthquakeRating", "colEarthquakeRating"  
                    Return "colEarthquakeRating"
                Case "[Windstorm_Rating]", "Windstorm_Rating", "WindstormRating", "colWindstormRating"  
                    Return "colWindstormRating"
                Case "[Other_Rating]", "Other_Rating", "OtherRating", "colOtherRating"  
                    Return "colOtherRating"
                Case "[Physical_Protection_Rating]", "Physical_Protection_Rating", "PhysicalProtectionRating", "colPhysicalProtectionRating"  
                    Return "colPhysicalProtectionRating"
                Case "[Human_Element_Rating]", "Human_Element_Rating", "HumanElementRating", "colHumanElementRating"  
                    Return "colHumanElementRating"
                Case "[Natural_Hazards_Protection_Rating]", "Natural_Hazards_Protection_Rating", "NaturalHazardsProtectionRating", "colNaturalHazardsProtectionRating"  
                    Return "colNaturalHazardsProtectionRating"
                Case "[Business_Continuity_Rating]", "Business_Continuity_Rating", "BusinessContinuityRating", "colBusinessContinuityRating"  
                    Return "colBusinessContinuityRating"
                Case "[APL_Factor]", "APL_Factor", "AplFactor", "colAplFactor"  
                    Return "colAplFactor"
                Case "[APLFactorWithAllRecsComplete]", "APLFactorWithAllRecsComplete", "APLFactorWithAllRecsComplete", "colAPLFactorWithAllRecsComplete"  
                    Return "colAPLFactorWithAllRecsComplete"
                Case "[Other_Weight]", "Other_Weight", "OtherWeight", "colOtherWeight"  
                    Return "colOtherWeight"
                Case "[Construction_Weight]", "Construction_Weight", "ConstructionWeight", "colConstructionWeight"  
                    Return "colConstructionWeight"
                Case "[Occupancy_Weight]", "Occupancy_Weight", "OccupancyWeight", "colOccupancyWeight"  
                    Return "colOccupancyWeight"
                Case "[Physical_Protection_Weight]", "Physical_Protection_Weight", "PhysicalProtectionWeight", "colPhysicalProtectionWeight"  
                    Return "colPhysicalProtectionWeight"
                Case "[Human_Element_Weight]", "Human_Element_Weight", "HumanElementWeight", "colHumanElementWeight"  
                    Return "colHumanElementWeight"
                Case "[Natural_Hazards_Protection_Weight]", "Natural_Hazards_Protection_Weight", "NaturalHazardsProtectionWeight", "colNaturalHazardsProtectionWeight"  
                    Return "colNaturalHazardsProtectionWeight"
                Case "[Business_Continuity_Weight]", "Business_Continuity_Weight", "BusinessContinuityWeight", "colBusinessContinuityWeight"  
                    Return "colBusinessContinuityWeight"
                Case "[Fire_Protection_All_Recs_Complete_Rating]", "Fire_Protection_All_Recs_Complete_Rating", "FireProtectionAllRecsCompleteRating", "colFireProtectionAllRecsCompleteRating"  
                    Return "colFireProtectionAllRecsCompleteRating"
                Case "[Human_Element_All_Recs_Complete_Rating]", "Human_Element_All_Recs_Complete_Rating", "HumanElementAllRecsCompleteRating", "colHumanElementAllRecsCompleteRating"  
                    Return "colHumanElementAllRecsCompleteRating"
                Case "[Nat_Haz_Prot_All_Recs_Complete_Rating]", "Nat_Haz_Prot_All_Recs_Complete_Rating", "NatHazProtAllRecsCompleteRating", "colNatHazProtAllRecsCompleteRating"  
                    Return "colNatHazProtAllRecsCompleteRating"
                Case "[BCP_All_Recs_Complet_Rating]", "BCP_All_Recs_Complet_Rating", "BcpAllRecsCompletRating", "colBcpAllRecsCompletRating"  
                    Return "colBcpAllRecsCompletRating"
                Case "[Flood_Weight]", "Flood_Weight", "FloodWeight", "colFloodWeight"  
                    Return "colFloodWeight"
                Case "[Earthquake_Weight]", "Earthquake_Weight", "EarthquakeWeight", "colEarthquakeWeight"  
                    Return "colEarthquakeWeight"
                Case "[Windstorm_Weight]", "Windstorm_Weight", "WindstormWeight", "colWindstormWeight"  
                    Return "colWindstormWeight"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[InspProgramYearFROM]", "InspProgramYearFROM", "InspProgramYearFROM", "colInspProgramYearFROM"  
                    Return "colInspProgramYearFROM"
                Case "[InspProgramYear]", "InspProgramYear", "InspProgramYear", "colInspProgramYear"  
                    Return "colInspProgramYear"
                Case "[AchievableScorePercent]", "AchievableScorePercent", "AchievableScorePercent", "colAchievableScorePercent"  
                    Return "colAchievableScorePercent"
                Case "[AchievableScorePercentString]", "AchievableScorePercentString", "AchievableScorePercentString", "colAchievableScorePercentString"  
                    Return "colAchievableScorePercentString"
                Case "[IsLatestRating]", "IsLatestRating", "IsLatestRating", "colIsLatestRating"  
                    Return "colIsLatestRating"
                Case "[IBI]", "IBI", "Ibi", "colIbi"  
                    Return "colIbi"
                Case "[HighestLossExpectancy]", "HighestLossExpectancy", "HighestLossExpectancy", "colHighestLossExpectancy"  
                    Return "colHighestLossExpectancy"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "String"
                Case "colFileNo"
                    Return "String"
                Case "colClient"
                    Return "String"
                Case "colClientLocNo"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case "colAddress"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colLatitude"
                    Return "String"
                Case "colLongitude"
                    Return "String"
                Case "colBIReporting"
                    Return "String"
                Case "colApl"
                    Return "Double"
                Case "colAplpd"
                    Return "Double"
                Case "colAplbi"
                    Return "Double"
                Case "colAPLPercent"
                    Return "Double"
                Case "colAPLPDPercent"
                    Return "Double"
                Case "colAPLBIPercent"
                    Return "Double"
                Case "colPml"
                    Return "Double"
                Case "colPmlpd"
                    Return "Double"
                Case "colPmlbi"
                    Return "Double"
                Case "colPMLPercent"
                    Return "Double"
                Case "colPMLPDPercent"
                    Return "Double"
                Case "colPMLBIPercent"
                    Return "Double"
                Case "colMfl"
                    Return "Double"
                Case "colMflpd"
                    Return "Double"
                Case "colMflbi"
                    Return "Double"
                Case "colMFLPercent"
                    Return "Double"
                Case "colMFLPDPercent"
                    Return "Double"
                Case "colMFLBIPercent"
                    Return "Double"
                Case "colTiv"
                    Return "Double"
                Case "colTivpd"
                    Return "Double"
                Case "colTivbi"
                    Return "Double"
                Case "colInterdependencies"
                    Return "String"
                Case "colLEandInterdependecyComments"
                    Return "String"
                Case "colLossesLast3Years"
                    Return "String"
                Case "colLossHistoryDescription"
                    Return "String"
                Case "colInspectionDate"
                    Return "DateTime"
                Case "colActiveScore"
                    Return "Decimal"
                Case "colPassiveScore"
                    Return "Decimal"
                Case "colTotalScore"
                    Return "Double"
                Case "colOverallRating"
                    Return "String"
                Case "colTotalscoreColor"
                    Return "String"
                Case "colOccupancy"
                    Return "String"
                Case "colIndustryGroup"
                    Return "String"
                Case "colMajorGroup"
                    Return "String"
                Case "colSpecificGroup"
                    Return "String"
                Case "colActiveScoreWithRecsComplete"
                    Return "Decimal"
                Case "colOverallScoreWithRecsComplete"
                    Return "Decimal"
                Case "colMaxPossibleScore"
                    Return "Decimal"
                Case "colConstructionRating"
                    Return "Long"
                Case "colOccupancyRating"
                    Return "Long"
                Case "colFloodRating"
                    Return "Long"
                Case "colEarthquakeRating"
                    Return "Long"
                Case "colWindstormRating"
                    Return "Long"
                Case "colOtherRating"
                    Return "Long"
                Case "colPhysicalProtectionRating"
                    Return "Long"
                Case "colHumanElementRating"
                    Return "Long"
                Case "colNaturalHazardsProtectionRating"
                    Return "Long"
                Case "colBusinessContinuityRating"
                    Return "Long"
                Case "colAplFactor"
                    Return "Decimal"
                Case "colAPLFactorWithAllRecsComplete"
                    Return "Decimal"
                Case "colOtherWeight"
                    Return "Long"
                Case "colConstructionWeight"
                    Return "Long"
                Case "colOccupancyWeight"
                    Return "Long"
                Case "colPhysicalProtectionWeight"
                    Return "Long"
                Case "colHumanElementWeight"
                    Return "Long"
                Case "colNaturalHazardsProtectionWeight"
                    Return "Long"
                Case "colBusinessContinuityWeight"
                    Return "Long"
                Case "colFireProtectionAllRecsCompleteRating"
                    Return "Long"
                Case "colHumanElementAllRecsCompleteRating"
                    Return "Long"
                Case "colNatHazProtAllRecsCompleteRating"
                    Return "Long"
                Case "colBcpAllRecsCompletRating"
                    Return "Long"
                Case "colFloodWeight"
                    Return "Long"
                Case "colEarthquakeWeight"
                    Return "Long"
                Case "colWindstormWeight"
                    Return "Long"
                Case "colCustomAccess"
                    Return "String"
                Case "colInspProgramYearFROM"
                    Return "DateTime"
                Case "colInspProgramYear"
                    Return "String"
                Case "colAchievableScorePercent"
                    Return "Decimal"
                Case "colAchievableScorePercentString"
                    Return "String"
                Case "colIsLatestRating"
                    Return "String"
                Case "colIbi"
                    Return "Double"
                Case "colHighestLossExpectancy"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[gv].[vwFireLossEstimatesLatestFacilityRatingExtractSelect]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

