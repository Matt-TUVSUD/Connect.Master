'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwWhatIfFireFacilityRating
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colAddressStamp As New razor.UtilSQLServer.StringDataColumn
        Public colAddress1 As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStprov As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colZip As New razor.UtilSQLServer.StringDataColumn
        Public colTiv As New razor.UtilSQLServer.DoubleDataColumn
        Public colTivbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colTivpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colPml As New razor.UtilSQLServer.DoubleDataColumn
        Public colPmlpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colPmlbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colMflpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colMflbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colMfl As New razor.UtilSQLServer.DoubleDataColumn
        Public colAplpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colAplbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colApl As New razor.UtilSQLServer.DoubleDataColumn
        Public colInspectiondate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colGrade As New razor.UtilSQLServer.DecimalDataColumn
        Public colConstructionrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colOccupancyrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFloodrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colEarthquakerating As New razor.UtilSQLServer.DecimalDataColumn
        Public colWindstormrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colOtherrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFloorRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colEarthquakeRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colWindstormRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colConstructionRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colOccupancyRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colOtherRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colPhysicalprotectionrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colHumanelementrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colNaturalhazardsprotectionrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colBusinesscontinuityrating As New razor.UtilSQLServer.DecimalDataColumn
        Public colPhysicalProtectionRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colNaturalHazardsProtectionRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessContinuityRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colAplfactor As New razor.UtilSQLServer.DecimalDataColumn
        Public colOverallplantratingrating As New razor.UtilSQLServer.StringDataColumn
        Public colPassivescore As New razor.UtilSQLServer.DecimalDataColumn
        Public colActivescore As New razor.UtilSQLServer.DecimalDataColumn
        Public colWhatIfActiveScore As New razor.UtilSQLServer.DecimalDataColumn
        Public colTotalscore As New razor.UtilSQLServer.DecimalDataColumn
        Public colTotalScoreHexBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colTotalScoreHexForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colTotalscorerating As New razor.UtilSQLServer.StringDataColumn
        Public colWhatIfScore As New razor.UtilSQLServer.DecimalDataColumn
        Public colWhatIfScoreHexBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colTotalfacilityscore As New razor.UtilSQLServer.DecimalDataColumn
        Public colOtherweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colConstructionweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colOccupancyweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colPhysicalprotectionweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colHumanelementweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colNaturalhazardsprotectionweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colBusinesscontinuityweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colFireprotectionallrecscompleterating As New razor.UtilSQLServer.DecimalDataColumn
        Public colHumanelementallrecscompleterating As New razor.UtilSQLServer.DecimalDataColumn
        Public colNathazprotallrecscompleterating As New razor.UtilSQLServer.DecimalDataColumn
        Public colBcpAllRecsCompleteRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFireProtectionAllRecsCompleteRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementAllRecsCompleteRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazProtAllRecsCompleteRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colBcpAllRecsCompleteRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colPhysicalProtectionWhatIfRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementWhatIfRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colNaturalHazardsProtectionWhatIfRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessContinuityWhatIfRatingBackColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colPhysicalProtectionWhatIfRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colHumanElementWhatIfRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colNaturalHazardsWhatIfRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colBusinessContinuityWhatIfRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colPhysicalProtectionWhatIfRatingDesc As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementWhatIfRatingDesc As New razor.UtilSQLServer.StringDataColumn
        Public colNaturalHazardsWhatIfRatingDesc As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessContinuityWhatIfRatingDesc As New razor.UtilSQLServer.StringDataColumn
        Public colActivescorewithrecscomplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colAplwithallrecscomplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colFloodweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colEarthquakeweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colWindstormweight As New razor.UtilSQLServer.DecimalDataColumn
        Public colOverallscorewithrecscomplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colMaxpossiblescore As New razor.UtilSQLServer.DecimalDataColumn
        Public colAplfactorwithallrecscomplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colFlooddescription As New razor.UtilSQLServer.StringDataColumn
        Public colEarthquakedescription As New razor.UtilSQLServer.StringDataColumn
        Public colWindstormdescription As New razor.UtilSQLServer.StringDataColumn
        Public colConstructiondescription As New razor.UtilSQLServer.StringDataColumn
        Public colOccupancydescription As New razor.UtilSQLServer.StringDataColumn
        Public colOtherdescription As New razor.UtilSQLServer.StringDataColumn
        Public colFiredescription As New razor.UtilSQLServer.StringDataColumn
        Public colHumandescription As New razor.UtilSQLServer.StringDataColumn
        Public colNaturaldescription As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessdescription As New razor.UtilSQLServer.StringDataColumn
        Public colFirerecdescription As New razor.UtilSQLServer.StringDataColumn
        Public colHumanrecdescription As New razor.UtilSQLServer.StringDataColumn
        Public colNaturalrecdescription As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessrecdescription As New razor.UtilSQLServer.StringDataColumn
        Public colExchangerate As New razor.UtilSQLServer.DecimalDataColumn
        Public colAdminmemo As New razor.UtilSQLServer.StringDataColumn
        Public colOverallscorewithrecscompleterating As New razor.UtilSQLServer.StringDataColumn
        Public colMaxpossiblerating As New razor.UtilSQLServer.StringDataColumn
        Public colOverallScoreWithRecsCompleteHexForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colOverallScoreWithRecsCompleteHexBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colAchievableScorePercent As New razor.UtilSQLServer.DecimalDataColumn
        Public colAchievableScorePercentString As New razor.UtilSQLServer.StringDataColumn
        Public colAchievableScorePercentHexForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colAchievableScorePercentHexBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colIsLatestRating As New razor.UtilSQLServer.StringDataColumn
        Public colAchievablePercentWhatIfString As New razor.UtilSQLServer.StringDataColumn
        Public colAchievablePercentWhatIfHexBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colAchievablePercentWhatIfHexForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colAchievablePercentAllRecsCompHexBackColor As New razor.UtilSQLServer.StringDataColumn
        Public colAchievablePercentAllRecsCompHexForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colAchievablePercentAllRecsCompString As New razor.UtilSQLServer.StringDataColumn
        Public colRatingID As New razor.UtilSQLServer.DecimalDataColumn
        Public colFloorRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colEarthquakeRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colWindstormRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colConstructionRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colOccupancyRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colOtherRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colPhysicalProtectionRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colNaturalHazardsProtectionRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessContinuityRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colFireProtectionAllRecsCompleteRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementAllRecsCompleteRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazProtAllRecsCompleteRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colBcpAllRecsCompleteRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colWhatIfScoreHexForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colPhysicalProtectionWhatIfRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colHumanElementWhatIfRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colNaturalHazardsProtectionWhatIfRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn
        Public colBusinessContinuityWhatIfRatingForeColorHex As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colGSafeId.ColumnName = "[GSafeId]"
            colFileNo.ColumnName = "[FileNo]"
            colAddressStamp.ColumnName = "[AddressStamp]"
            colAddress1.ColumnName = "[address1]"
            colCity.ColumnName = "[city]"
            colStprov.ColumnName = "[stprov]"
            colCountry.ColumnName = "[country]"
            colDivision.ColumnName = "[division]"
            colZip.ColumnName = "[zip]"
            colTiv.ColumnName = "[TIV]"
            colTivbi.ColumnName = "[TIVBI]"
            colTivpd.ColumnName = "[TIVPD]"
            colPml.ColumnName = "[PML]"
            colPmlpd.ColumnName = "[PMLPD]"
            colPmlbi.ColumnName = "[PMLBI]"
            colMflpd.ColumnName = "[MFLPD]"
            colMflbi.ColumnName = "[MFLBI]"
            colMfl.ColumnName = "[MFL]"
            colAplpd.ColumnName = "[APLPD]"
            colAplbi.ColumnName = "[APLBI]"
            colApl.ColumnName = "[APL]"
            colInspectiondate.ColumnName = "[inspectiondate]"
            colGrade.ColumnName = "[grade]"
            colConstructionrating.ColumnName = "[constructionrating]"
            colOccupancyrating.ColumnName = "[occupancyrating]"
            colFloodrating.ColumnName = "[floodrating]"
            colEarthquakerating.ColumnName = "[earthquakerating]"
            colWindstormrating.ColumnName = "[windstormrating]"
            colOtherrating.ColumnName = "[otherrating]"
            colFloorRatingBackColorHex.ColumnName = "[FloorRatingBackColorHex]"
            colEarthquakeRatingBackColorHex.ColumnName = "[EarthquakeRatingBackColorHex]"
            colWindstormRatingBackColorHex.ColumnName = "[WindstormRatingBackColorHex]"
            colConstructionRatingBackColorHex.ColumnName = "[ConstructionRatingBackColorHex]"
            colOccupancyRatingBackColorHex.ColumnName = "[OccupancyRatingBackColorHex]"
            colOtherRatingBackColorHex.ColumnName = "[OtherRatingBackColorHex]"
            colPhysicalprotectionrating.ColumnName = "[physicalprotectionrating]"
            colHumanelementrating.ColumnName = "[humanelementrating]"
            colNaturalhazardsprotectionrating.ColumnName = "[naturalhazardsprotectionrating]"
            colBusinesscontinuityrating.ColumnName = "[businesscontinuityrating]"
            colPhysicalProtectionRatingBackColorHex.ColumnName = "[PhysicalProtectionRatingBackColorHex]"
            colHumanElementRatingBackColorHex.ColumnName = "[HumanElementRatingBackColorHex]"
            colNaturalHazardsProtectionRatingBackColorHex.ColumnName = "[NaturalHazardsProtectionRatingBackColorHex]"
            colBusinessContinuityRatingBackColorHex.ColumnName = "[BusinessContinuityRatingBackColorHex]"
            colAplfactor.ColumnName = "[aplfactor]"
            colOverallplantratingrating.ColumnName = "[overallplantratingrating]"
            colPassivescore.ColumnName = "[passivescore]"
            colActivescore.ColumnName = "[activescore]"
            colWhatIfActiveScore.ColumnName = "[WhatIfActiveScore]"
            colTotalscore.ColumnName = "[totalscore]"
            colTotalScoreHexBackColor.ColumnName = "[TotalScoreHexBackColor]"
            colTotalScoreHexForeColor.ColumnName = "[TotalScoreHexForeColor]"
            colTotalscorerating.ColumnName = "[totalscorerating]"
            colWhatIfScore.ColumnName = "[WhatIfScore]"
            colWhatIfScoreHexBackColor.ColumnName = "[WhatIfScoreHexBackColor]"
            colTotalfacilityscore.ColumnName = "[totalfacilityscore]"
            colOtherweight.ColumnName = "[otherweight]"
            colConstructionweight.ColumnName = "[constructionweight]"
            colOccupancyweight.ColumnName = "[occupancyweight]"
            colPhysicalprotectionweight.ColumnName = "[physicalprotectionweight]"
            colHumanelementweight.ColumnName = "[humanelementweight]"
            colNaturalhazardsprotectionweight.ColumnName = "[naturalhazardsprotectionweight]"
            colBusinesscontinuityweight.ColumnName = "[businesscontinuityweight]"
            colFireprotectionallrecscompleterating.ColumnName = "[fireprotectionallrecscompleterating]"
            colHumanelementallrecscompleterating.ColumnName = "[humanelementallrecscompleterating]"
            colNathazprotallrecscompleterating.ColumnName = "[nathazprotallrecscompleterating]"
            colBcpAllRecsCompleteRating.ColumnName = "[BcpAllRecsCompleteRating]"
            colFireProtectionAllRecsCompleteRatingBackColorHex.ColumnName = "[FireProtectionAllRecsCompleteRatingBackColorHex]"
            colHumanElementAllRecsCompleteRatingBackColorHex.ColumnName = "[HumanElementAllRecsCompleteRatingBackColorHex]"
            colNatHazProtAllRecsCompleteRatingBackColorHex.ColumnName = "[NatHazProtAllRecsCompleteRatingBackColorHex]"
            colBcpAllRecsCompleteRatingBackColorHex.ColumnName = "[BcpAllRecsCompleteRatingBackColorHex]"
            colPhysicalProtectionWhatIfRatingBackColorHex.ColumnName = "[PhysicalProtectionWhatIfRatingBackColorHex]"
            colHumanElementWhatIfRatingBackColorHex.ColumnName = "[HumanElementWhatIfRatingBackColorHex]"
            colNaturalHazardsProtectionWhatIfRatingBackColorHex.ColumnName = "[NaturalHazardsProtectionWhatIfRatingBackColorHex]"
            colBusinessContinuityWhatIfRatingBackColorHex.ColumnName = "[BusinessContinuityWhatIfRatingBackColorHex]"
            colPhysicalProtectionWhatIfRating.ColumnName = "[PhysicalProtectionWhatIfRating]"
            colHumanElementWhatIfRating.ColumnName = "[HumanElementWhatIfRating]"
            colNaturalHazardsWhatIfRating.ColumnName = "[NaturalHazardsWhatIfRating]"
            colBusinessContinuityWhatIfRating.ColumnName = "[BusinessContinuityWhatIfRating]"
            colPhysicalProtectionWhatIfRatingDesc.ColumnName = "[PhysicalProtectionWhatIfRatingDesc]"
            colHumanElementWhatIfRatingDesc.ColumnName = "[HumanElementWhatIfRatingDesc]"
            colNaturalHazardsWhatIfRatingDesc.ColumnName = "[NaturalHazardsWhatIfRatingDesc]"
            colBusinessContinuityWhatIfRatingDesc.ColumnName = "[BusinessContinuityWhatIfRatingDesc]"
            colActivescorewithrecscomplete.ColumnName = "[activescorewithrecscomplete]"
            colAplwithallrecscomplete.ColumnName = "[aplwithallrecscomplete]"
            colFloodweight.ColumnName = "[floodweight]"
            colEarthquakeweight.ColumnName = "[earthquakeweight]"
            colWindstormweight.ColumnName = "[windstormweight]"
            colOverallscorewithrecscomplete.ColumnName = "[overallscorewithrecscomplete]"
            colMaxpossiblescore.ColumnName = "[maxpossiblescore]"
            colAplfactorwithallrecscomplete.ColumnName = "[aplfactorwithallrecscomplete]"
            colFlooddescription.ColumnName = "[flooddescription]"
            colEarthquakedescription.ColumnName = "[earthquakedescription]"
            colWindstormdescription.ColumnName = "[windstormdescription]"
            colConstructiondescription.ColumnName = "[constructiondescription]"
            colOccupancydescription.ColumnName = "[occupancydescription]"
            colOtherdescription.ColumnName = "[otherdescription]"
            colFiredescription.ColumnName = "[firedescription]"
            colHumandescription.ColumnName = "[humandescription]"
            colNaturaldescription.ColumnName = "[naturaldescription]"
            colBusinessdescription.ColumnName = "[businessdescription]"
            colFirerecdescription.ColumnName = "[firerecdescription]"
            colHumanrecdescription.ColumnName = "[humanrecdescription]"
            colNaturalrecdescription.ColumnName = "[naturalrecdescription]"
            colBusinessrecdescription.ColumnName = "[businessrecdescription]"
            colExchangerate.ColumnName = "[exchangerate]"
            colAdminmemo.ColumnName = "[adminmemo]"
            colOverallscorewithrecscompleterating.ColumnName = "[overallscorewithrecscompleterating]"
            colMaxpossiblerating.ColumnName = "[maxpossiblerating]"
            colOverallScoreWithRecsCompleteHexForeColor.ColumnName = "[OverallScoreWithRecsCompleteHexForeColor]"
            colOverallScoreWithRecsCompleteHexBackColor.ColumnName = "[OverallScoreWithRecsCompleteHexBackColor]"
            colAchievableScorePercent.ColumnName = "[AchievableScorePercent]"
            colAchievableScorePercentString.ColumnName = "[AchievableScorePercentString]"
            colAchievableScorePercentHexForeColor.ColumnName = "[AchievableScorePercentHexForeColor]"
            colAchievableScorePercentHexBackColor.ColumnName = "[AchievableScorePercentHexBackColor]"
            colIsLatestRating.ColumnName = "[IsLatestRating]"
            colAchievablePercentWhatIfString.ColumnName = "[AchievablePercentWhatIfString]"
            colAchievablePercentWhatIfHexBackColor.ColumnName = "[AchievablePercentWhatIfHexBackColor]"
            colAchievablePercentWhatIfHexForeColor.ColumnName = "[AchievablePercentWhatIfHexForeColor]"
            colAchievablePercentAllRecsCompHexBackColor.ColumnName = "[AchievablePercentAllRecsCompHexBackColor]"
            colAchievablePercentAllRecsCompHexForeColor.ColumnName = "[AchievablePercentAllRecsCompHexForeColor]"
            colAchievablePercentAllRecsCompString.ColumnName = "[AchievablePercentAllRecsCompString]"
            colRatingID.ColumnName = "[RatingID]"
            colFloorRatingForeColorHex.ColumnName = "[FloorRatingForeColorHex]"
            colEarthquakeRatingForeColorHex.ColumnName = "[EarthquakeRatingForeColorHex]"
            colWindstormRatingForeColorHex.ColumnName = "[WindstormRatingForeColorHex]"
            colConstructionRatingForeColorHex.ColumnName = "[ConstructionRatingForeColorHex]"
            colOccupancyRatingForeColorHex.ColumnName = "[OccupancyRatingForeColorHex]"
            colOtherRatingForeColorHex.ColumnName = "[OtherRatingForeColorHex]"
            colPhysicalProtectionRatingForeColorHex.ColumnName = "[PhysicalProtectionRatingForeColorHex]"
            colHumanElementRatingForeColorHex.ColumnName = "[HumanElementRatingForeColorHex]"
            colNaturalHazardsProtectionRatingForeColorHex.ColumnName = "[NaturalHazardsProtectionRatingForeColorHex]"
            colBusinessContinuityRatingForeColorHex.ColumnName = "[BusinessContinuityRatingForeColorHex]"
            colFireProtectionAllRecsCompleteRatingForeColorHex.ColumnName = "[FireProtectionAllRecsCompleteRatingForeColorHex]"
            colHumanElementAllRecsCompleteRatingForeColorHex.ColumnName = "[HumanElementAllRecsCompleteRatingForeColorHex]"
            colNatHazProtAllRecsCompleteRatingForeColorHex.ColumnName = "[NatHazProtAllRecsCompleteRatingForeColorHex]"
            colBcpAllRecsCompleteRatingForeColorHex.ColumnName = "[BcpAllRecsCompleteRatingForeColorHex]"
            colWhatIfScoreHexForeColor.ColumnName = "[WhatIfScoreHexForeColor]"
            colPhysicalProtectionWhatIfRatingForeColorHex.ColumnName = "[PhysicalProtectionWhatIfRatingForeColorHex]"
            colHumanElementWhatIfRatingForeColorHex.ColumnName = "[HumanElementWhatIfRatingForeColorHex]"
            colNaturalHazardsProtectionWhatIfRatingForeColorHex.ColumnName = "[NaturalHazardsProtectionWhatIfRatingForeColorHex]"
            colBusinessContinuityWhatIfRatingForeColorHex.ColumnName = "[BusinessContinuityWhatIfRatingForeColorHex]"

            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colAddressStamp", colAddressStamp)
            _Members.Add("colAddress1", colAddress1)
            _Members.Add("colCity", colCity)
            _Members.Add("colStprov", colStprov)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colZip", colZip)
            _Members.Add("colTiv", colTiv)
            _Members.Add("colTivbi", colTivbi)
            _Members.Add("colTivpd", colTivpd)
            _Members.Add("colPml", colPml)
            _Members.Add("colPmlpd", colPmlpd)
            _Members.Add("colPmlbi", colPmlbi)
            _Members.Add("colMflpd", colMflpd)
            _Members.Add("colMflbi", colMflbi)
            _Members.Add("colMfl", colMfl)
            _Members.Add("colAplpd", colAplpd)
            _Members.Add("colAplbi", colAplbi)
            _Members.Add("colApl", colApl)
            _Members.Add("colInspectiondate", colInspectiondate)
            _Members.Add("colGrade", colGrade)
            _Members.Add("colConstructionrating", colConstructionrating)
            _Members.Add("colOccupancyrating", colOccupancyrating)
            _Members.Add("colFloodrating", colFloodrating)
            _Members.Add("colEarthquakerating", colEarthquakerating)
            _Members.Add("colWindstormrating", colWindstormrating)
            _Members.Add("colOtherrating", colOtherrating)
            _Members.Add("colFloorRatingBackColorHex", colFloorRatingBackColorHex)
            _Members.Add("colEarthquakeRatingBackColorHex", colEarthquakeRatingBackColorHex)
            _Members.Add("colWindstormRatingBackColorHex", colWindstormRatingBackColorHex)
            _Members.Add("colConstructionRatingBackColorHex", colConstructionRatingBackColorHex)
            _Members.Add("colOccupancyRatingBackColorHex", colOccupancyRatingBackColorHex)
            _Members.Add("colOtherRatingBackColorHex", colOtherRatingBackColorHex)
            _Members.Add("colPhysicalprotectionrating", colPhysicalprotectionrating)
            _Members.Add("colHumanelementrating", colHumanelementrating)
            _Members.Add("colNaturalhazardsprotectionrating", colNaturalhazardsprotectionrating)
            _Members.Add("colBusinesscontinuityrating", colBusinesscontinuityrating)
            _Members.Add("colPhysicalProtectionRatingBackColorHex", colPhysicalProtectionRatingBackColorHex)
            _Members.Add("colHumanElementRatingBackColorHex", colHumanElementRatingBackColorHex)
            _Members.Add("colNaturalHazardsProtectionRatingBackColorHex", colNaturalHazardsProtectionRatingBackColorHex)
            _Members.Add("colBusinessContinuityRatingBackColorHex", colBusinessContinuityRatingBackColorHex)
            _Members.Add("colAplfactor", colAplfactor)
            _Members.Add("colOverallplantratingrating", colOverallplantratingrating)
            _Members.Add("colPassivescore", colPassivescore)
            _Members.Add("colActivescore", colActivescore)
            _Members.Add("colWhatIfActiveScore", colWhatIfActiveScore)
            _Members.Add("colTotalscore", colTotalscore)
            _Members.Add("colTotalScoreHexBackColor", colTotalScoreHexBackColor)
            _Members.Add("colTotalScoreHexForeColor", colTotalScoreHexForeColor)
            _Members.Add("colTotalscorerating", colTotalscorerating)
            _Members.Add("colWhatIfScore", colWhatIfScore)
            _Members.Add("colWhatIfScoreHexBackColor", colWhatIfScoreHexBackColor)
            _Members.Add("colTotalfacilityscore", colTotalfacilityscore)
            _Members.Add("colOtherweight", colOtherweight)
            _Members.Add("colConstructionweight", colConstructionweight)
            _Members.Add("colOccupancyweight", colOccupancyweight)
            _Members.Add("colPhysicalprotectionweight", colPhysicalprotectionweight)
            _Members.Add("colHumanelementweight", colHumanelementweight)
            _Members.Add("colNaturalhazardsprotectionweight", colNaturalhazardsprotectionweight)
            _Members.Add("colBusinesscontinuityweight", colBusinesscontinuityweight)
            _Members.Add("colFireprotectionallrecscompleterating", colFireprotectionallrecscompleterating)
            _Members.Add("colHumanelementallrecscompleterating", colHumanelementallrecscompleterating)
            _Members.Add("colNathazprotallrecscompleterating", colNathazprotallrecscompleterating)
            _Members.Add("colBcpAllRecsCompleteRating", colBcpAllRecsCompleteRating)
            _Members.Add("colFireProtectionAllRecsCompleteRatingBackColorHex", colFireProtectionAllRecsCompleteRatingBackColorHex)
            _Members.Add("colHumanElementAllRecsCompleteRatingBackColorHex", colHumanElementAllRecsCompleteRatingBackColorHex)
            _Members.Add("colNatHazProtAllRecsCompleteRatingBackColorHex", colNatHazProtAllRecsCompleteRatingBackColorHex)
            _Members.Add("colBcpAllRecsCompleteRatingBackColorHex", colBcpAllRecsCompleteRatingBackColorHex)
            _Members.Add("colPhysicalProtectionWhatIfRatingBackColorHex", colPhysicalProtectionWhatIfRatingBackColorHex)
            _Members.Add("colHumanElementWhatIfRatingBackColorHex", colHumanElementWhatIfRatingBackColorHex)
            _Members.Add("colNaturalHazardsProtectionWhatIfRatingBackColorHex", colNaturalHazardsProtectionWhatIfRatingBackColorHex)
            _Members.Add("colBusinessContinuityWhatIfRatingBackColorHex", colBusinessContinuityWhatIfRatingBackColorHex)
            _Members.Add("colPhysicalProtectionWhatIfRating", colPhysicalProtectionWhatIfRating)
            _Members.Add("colHumanElementWhatIfRating", colHumanElementWhatIfRating)
            _Members.Add("colNaturalHazardsWhatIfRating", colNaturalHazardsWhatIfRating)
            _Members.Add("colBusinessContinuityWhatIfRating", colBusinessContinuityWhatIfRating)
            _Members.Add("colPhysicalProtectionWhatIfRatingDesc", colPhysicalProtectionWhatIfRatingDesc)
            _Members.Add("colHumanElementWhatIfRatingDesc", colHumanElementWhatIfRatingDesc)
            _Members.Add("colNaturalHazardsWhatIfRatingDesc", colNaturalHazardsWhatIfRatingDesc)
            _Members.Add("colBusinessContinuityWhatIfRatingDesc", colBusinessContinuityWhatIfRatingDesc)
            _Members.Add("colActivescorewithrecscomplete", colActivescorewithrecscomplete)
            _Members.Add("colAplwithallrecscomplete", colAplwithallrecscomplete)
            _Members.Add("colFloodweight", colFloodweight)
            _Members.Add("colEarthquakeweight", colEarthquakeweight)
            _Members.Add("colWindstormweight", colWindstormweight)
            _Members.Add("colOverallscorewithrecscomplete", colOverallscorewithrecscomplete)
            _Members.Add("colMaxpossiblescore", colMaxpossiblescore)
            _Members.Add("colAplfactorwithallrecscomplete", colAplfactorwithallrecscomplete)
            _Members.Add("colFlooddescription", colFlooddescription)
            _Members.Add("colEarthquakedescription", colEarthquakedescription)
            _Members.Add("colWindstormdescription", colWindstormdescription)
            _Members.Add("colConstructiondescription", colConstructiondescription)
            _Members.Add("colOccupancydescription", colOccupancydescription)
            _Members.Add("colOtherdescription", colOtherdescription)
            _Members.Add("colFiredescription", colFiredescription)
            _Members.Add("colHumandescription", colHumandescription)
            _Members.Add("colNaturaldescription", colNaturaldescription)
            _Members.Add("colBusinessdescription", colBusinessdescription)
            _Members.Add("colFirerecdescription", colFirerecdescription)
            _Members.Add("colHumanrecdescription", colHumanrecdescription)
            _Members.Add("colNaturalrecdescription", colNaturalrecdescription)
            _Members.Add("colBusinessrecdescription", colBusinessrecdescription)
            _Members.Add("colExchangerate", colExchangerate)
            _Members.Add("colAdminmemo", colAdminmemo)
            _Members.Add("colOverallscorewithrecscompleterating", colOverallscorewithrecscompleterating)
            _Members.Add("colMaxpossiblerating", colMaxpossiblerating)
            _Members.Add("colOverallScoreWithRecsCompleteHexForeColor", colOverallScoreWithRecsCompleteHexForeColor)
            _Members.Add("colOverallScoreWithRecsCompleteHexBackColor", colOverallScoreWithRecsCompleteHexBackColor)
            _Members.Add("colAchievableScorePercent", colAchievableScorePercent)
            _Members.Add("colAchievableScorePercentString", colAchievableScorePercentString)
            _Members.Add("colAchievableScorePercentHexForeColor", colAchievableScorePercentHexForeColor)
            _Members.Add("colAchievableScorePercentHexBackColor", colAchievableScorePercentHexBackColor)
            _Members.Add("colIsLatestRating", colIsLatestRating)
            _Members.Add("colAchievablePercentWhatIfString", colAchievablePercentWhatIfString)
            _Members.Add("colAchievablePercentWhatIfHexBackColor", colAchievablePercentWhatIfHexBackColor)
            _Members.Add("colAchievablePercentWhatIfHexForeColor", colAchievablePercentWhatIfHexForeColor)
            _Members.Add("colAchievablePercentAllRecsCompHexBackColor", colAchievablePercentAllRecsCompHexBackColor)
            _Members.Add("colAchievablePercentAllRecsCompHexForeColor", colAchievablePercentAllRecsCompHexForeColor)
            _Members.Add("colAchievablePercentAllRecsCompString", colAchievablePercentAllRecsCompString)
            _Members.Add("colRatingID", colRatingID)
            _Members.Add("colFloorRatingForeColorHex", colFloorRatingForeColorHex)
            _Members.Add("colEarthquakeRatingForeColorHex", colEarthquakeRatingForeColorHex)
            _Members.Add("colWindstormRatingForeColorHex", colWindstormRatingForeColorHex)
            _Members.Add("colConstructionRatingForeColorHex", colConstructionRatingForeColorHex)
            _Members.Add("colOccupancyRatingForeColorHex", colOccupancyRatingForeColorHex)
            _Members.Add("colOtherRatingForeColorHex", colOtherRatingForeColorHex)
            _Members.Add("colPhysicalProtectionRatingForeColorHex", colPhysicalProtectionRatingForeColorHex)
            _Members.Add("colHumanElementRatingForeColorHex", colHumanElementRatingForeColorHex)
            _Members.Add("colNaturalHazardsProtectionRatingForeColorHex", colNaturalHazardsProtectionRatingForeColorHex)
            _Members.Add("colBusinessContinuityRatingForeColorHex", colBusinessContinuityRatingForeColorHex)
            _Members.Add("colFireProtectionAllRecsCompleteRatingForeColorHex", colFireProtectionAllRecsCompleteRatingForeColorHex)
            _Members.Add("colHumanElementAllRecsCompleteRatingForeColorHex", colHumanElementAllRecsCompleteRatingForeColorHex)
            _Members.Add("colNatHazProtAllRecsCompleteRatingForeColorHex", colNatHazProtAllRecsCompleteRatingForeColorHex)
            _Members.Add("colBcpAllRecsCompleteRatingForeColorHex", colBcpAllRecsCompleteRatingForeColorHex)
            _Members.Add("colWhatIfScoreHexForeColor", colWhatIfScoreHexForeColor)
            _Members.Add("colPhysicalProtectionWhatIfRatingForeColorHex", colPhysicalProtectionWhatIfRatingForeColorHex)
            _Members.Add("colHumanElementWhatIfRatingForeColorHex", colHumanElementWhatIfRatingForeColorHex)
            _Members.Add("colNaturalHazardsProtectionWhatIfRatingForeColorHex", colNaturalHazardsProtectionWhatIfRatingForeColorHex)
            _Members.Add("colBusinessContinuityWhatIfRatingForeColorHex", colBusinessContinuityWhatIfRatingForeColorHex)
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
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colAddressStamp"
                    Return "[AddressStamp]"
                Case "colAddress1"
                    Return "[address1]"
                Case "colCity"
                    Return "[city]"
                Case "colStprov"
                    Return "[stprov]"
                Case "colCountry"
                    Return "[country]"
                Case "colDivision"
                    Return "[division]"
                Case "colZip"
                    Return "[zip]"
                Case "colTiv"
                    Return "[TIV]"
                Case "colTivbi"
                    Return "[TIVBI]"
                Case "colTivpd"
                    Return "[TIVPD]"
                Case "colPml"
                    Return "[PML]"
                Case "colPmlpd"
                    Return "[PMLPD]"
                Case "colPmlbi"
                    Return "[PMLBI]"
                Case "colMflpd"
                    Return "[MFLPD]"
                Case "colMflbi"
                    Return "[MFLBI]"
                Case "colMfl"
                    Return "[MFL]"
                Case "colAplpd"
                    Return "[APLPD]"
                Case "colAplbi"
                    Return "[APLBI]"
                Case "colApl"
                    Return "[APL]"
                Case "colInspectiondate"
                    Return "[inspectiondate]"
                Case "colGrade"
                    Return "[grade]"
                Case "colConstructionrating"
                    Return "[constructionrating]"
                Case "colOccupancyrating"
                    Return "[occupancyrating]"
                Case "colFloodrating"
                    Return "[floodrating]"
                Case "colEarthquakerating"
                    Return "[earthquakerating]"
                Case "colWindstormrating"
                    Return "[windstormrating]"
                Case "colOtherrating"
                    Return "[otherrating]"
                Case "colFloorRatingBackColorHex"
                    Return "[FloorRatingBackColorHex]"
                Case "colEarthquakeRatingBackColorHex"
                    Return "[EarthquakeRatingBackColorHex]"
                Case "colWindstormRatingBackColorHex"
                    Return "[WindstormRatingBackColorHex]"
                Case "colConstructionRatingBackColorHex"
                    Return "[ConstructionRatingBackColorHex]"
                Case "colOccupancyRatingBackColorHex"
                    Return "[OccupancyRatingBackColorHex]"
                Case "colOtherRatingBackColorHex"
                    Return "[OtherRatingBackColorHex]"
                Case "colPhysicalprotectionrating"
                    Return "[physicalprotectionrating]"
                Case "colHumanelementrating"
                    Return "[humanelementrating]"
                Case "colNaturalhazardsprotectionrating"
                    Return "[naturalhazardsprotectionrating]"
                Case "colBusinesscontinuityrating"
                    Return "[businesscontinuityrating]"
                Case "colPhysicalProtectionRatingBackColorHex"
                    Return "[PhysicalProtectionRatingBackColorHex]"
                Case "colHumanElementRatingBackColorHex"
                    Return "[HumanElementRatingBackColorHex]"
                Case "colNaturalHazardsProtectionRatingBackColorHex"
                    Return "[NaturalHazardsProtectionRatingBackColorHex]"
                Case "colBusinessContinuityRatingBackColorHex"
                    Return "[BusinessContinuityRatingBackColorHex]"
                Case "colAplfactor"
                    Return "[aplfactor]"
                Case "colOverallplantratingrating"
                    Return "[overallplantratingrating]"
                Case "colPassivescore"
                    Return "[passivescore]"
                Case "colActivescore"
                    Return "[activescore]"
                Case "colWhatIfActiveScore"
                    Return "[WhatIfActiveScore]"
                Case "colTotalscore"
                    Return "[totalscore]"
                Case "colTotalScoreHexBackColor"
                    Return "[TotalScoreHexBackColor]"
                Case "colTotalScoreHexForeColor"
                    Return "[TotalScoreHexForeColor]"
                Case "colTotalscorerating"
                    Return "[totalscorerating]"
                Case "colWhatIfScore"
                    Return "[WhatIfScore]"
                Case "colWhatIfScoreHexBackColor"
                    Return "[WhatIfScoreHexBackColor]"
                Case "colTotalfacilityscore"
                    Return "[totalfacilityscore]"
                Case "colOtherweight"
                    Return "[otherweight]"
                Case "colConstructionweight"
                    Return "[constructionweight]"
                Case "colOccupancyweight"
                    Return "[occupancyweight]"
                Case "colPhysicalprotectionweight"
                    Return "[physicalprotectionweight]"
                Case "colHumanelementweight"
                    Return "[humanelementweight]"
                Case "colNaturalhazardsprotectionweight"
                    Return "[naturalhazardsprotectionweight]"
                Case "colBusinesscontinuityweight"
                    Return "[businesscontinuityweight]"
                Case "colFireprotectionallrecscompleterating"
                    Return "[fireprotectionallrecscompleterating]"
                Case "colHumanelementallrecscompleterating"
                    Return "[humanelementallrecscompleterating]"
                Case "colNathazprotallrecscompleterating"
                    Return "[nathazprotallrecscompleterating]"
                Case "colBcpAllRecsCompleteRating"
                    Return "[BcpAllRecsCompleteRating]"
                Case "colFireProtectionAllRecsCompleteRatingBackColorHex"
                    Return "[FireProtectionAllRecsCompleteRatingBackColorHex]"
                Case "colHumanElementAllRecsCompleteRatingBackColorHex"
                    Return "[HumanElementAllRecsCompleteRatingBackColorHex]"
                Case "colNatHazProtAllRecsCompleteRatingBackColorHex"
                    Return "[NatHazProtAllRecsCompleteRatingBackColorHex]"
                Case "colBcpAllRecsCompleteRatingBackColorHex"
                    Return "[BcpAllRecsCompleteRatingBackColorHex]"
                Case "colPhysicalProtectionWhatIfRatingBackColorHex"
                    Return "[PhysicalProtectionWhatIfRatingBackColorHex]"
                Case "colHumanElementWhatIfRatingBackColorHex"
                    Return "[HumanElementWhatIfRatingBackColorHex]"
                Case "colNaturalHazardsProtectionWhatIfRatingBackColorHex"
                    Return "[NaturalHazardsProtectionWhatIfRatingBackColorHex]"
                Case "colBusinessContinuityWhatIfRatingBackColorHex"
                    Return "[BusinessContinuityWhatIfRatingBackColorHex]"
                Case "colPhysicalProtectionWhatIfRating"
                    Return "[PhysicalProtectionWhatIfRating]"
                Case "colHumanElementWhatIfRating"
                    Return "[HumanElementWhatIfRating]"
                Case "colNaturalHazardsWhatIfRating"
                    Return "[NaturalHazardsWhatIfRating]"
                Case "colBusinessContinuityWhatIfRating"
                    Return "[BusinessContinuityWhatIfRating]"
                Case "colPhysicalProtectionWhatIfRatingDesc"
                    Return "[PhysicalProtectionWhatIfRatingDesc]"
                Case "colHumanElementWhatIfRatingDesc"
                    Return "[HumanElementWhatIfRatingDesc]"
                Case "colNaturalHazardsWhatIfRatingDesc"
                    Return "[NaturalHazardsWhatIfRatingDesc]"
                Case "colBusinessContinuityWhatIfRatingDesc"
                    Return "[BusinessContinuityWhatIfRatingDesc]"
                Case "colActivescorewithrecscomplete"
                    Return "[activescorewithrecscomplete]"
                Case "colAplwithallrecscomplete"
                    Return "[aplwithallrecscomplete]"
                Case "colFloodweight"
                    Return "[floodweight]"
                Case "colEarthquakeweight"
                    Return "[earthquakeweight]"
                Case "colWindstormweight"
                    Return "[windstormweight]"
                Case "colOverallscorewithrecscomplete"
                    Return "[overallscorewithrecscomplete]"
                Case "colMaxpossiblescore"
                    Return "[maxpossiblescore]"
                Case "colAplfactorwithallrecscomplete"
                    Return "[aplfactorwithallrecscomplete]"
                Case "colFlooddescription"
                    Return "[flooddescription]"
                Case "colEarthquakedescription"
                    Return "[earthquakedescription]"
                Case "colWindstormdescription"
                    Return "[windstormdescription]"
                Case "colConstructiondescription"
                    Return "[constructiondescription]"
                Case "colOccupancydescription"
                    Return "[occupancydescription]"
                Case "colOtherdescription"
                    Return "[otherdescription]"
                Case "colFiredescription"
                    Return "[firedescription]"
                Case "colHumandescription"
                    Return "[humandescription]"
                Case "colNaturaldescription"
                    Return "[naturaldescription]"
                Case "colBusinessdescription"
                    Return "[businessdescription]"
                Case "colFirerecdescription"
                    Return "[firerecdescription]"
                Case "colHumanrecdescription"
                    Return "[humanrecdescription]"
                Case "colNaturalrecdescription"
                    Return "[naturalrecdescription]"
                Case "colBusinessrecdescription"
                    Return "[businessrecdescription]"
                Case "colExchangerate"
                    Return "[exchangerate]"
                Case "colAdminmemo"
                    Return "[adminmemo]"
                Case "colOverallscorewithrecscompleterating"
                    Return "[overallscorewithrecscompleterating]"
                Case "colMaxpossiblerating"
                    Return "[maxpossiblerating]"
                Case "colOverallScoreWithRecsCompleteHexForeColor"
                    Return "[OverallScoreWithRecsCompleteHexForeColor]"
                Case "colOverallScoreWithRecsCompleteHexBackColor"
                    Return "[OverallScoreWithRecsCompleteHexBackColor]"
                Case "colAchievableScorePercent"
                    Return "[AchievableScorePercent]"
                Case "colAchievableScorePercentString"
                    Return "[AchievableScorePercentString]"
                Case "colAchievableScorePercentHexForeColor"
                    Return "[AchievableScorePercentHexForeColor]"
                Case "colAchievableScorePercentHexBackColor"
                    Return "[AchievableScorePercentHexBackColor]"
                Case "colIsLatestRating"
                    Return "[IsLatestRating]"
                Case "colAchievablePercentWhatIfString"
                    Return "[AchievablePercentWhatIfString]"
                Case "colAchievablePercentWhatIfHexBackColor"
                    Return "[AchievablePercentWhatIfHexBackColor]"
                Case "colAchievablePercentWhatIfHexForeColor"
                    Return "[AchievablePercentWhatIfHexForeColor]"
                Case "colAchievablePercentAllRecsCompHexBackColor"
                    Return "[AchievablePercentAllRecsCompHexBackColor]"
                Case "colAchievablePercentAllRecsCompHexForeColor"
                    Return "[AchievablePercentAllRecsCompHexForeColor]"
                Case "colAchievablePercentAllRecsCompString"
                    Return "[AchievablePercentAllRecsCompString]"
                Case "colRatingID"
                    Return "[RatingID]"
                Case "colFloorRatingForeColorHex"
                    Return "[FloorRatingForeColorHex]"
                Case "colEarthquakeRatingForeColorHex"
                    Return "[EarthquakeRatingForeColorHex]"
                Case "colWindstormRatingForeColorHex"
                    Return "[WindstormRatingForeColorHex]"
                Case "colConstructionRatingForeColorHex"
                    Return "[ConstructionRatingForeColorHex]"
                Case "colOccupancyRatingForeColorHex"
                    Return "[OccupancyRatingForeColorHex]"
                Case "colOtherRatingForeColorHex"
                    Return "[OtherRatingForeColorHex]"
                Case "colPhysicalProtectionRatingForeColorHex"
                    Return "[PhysicalProtectionRatingForeColorHex]"
                Case "colHumanElementRatingForeColorHex"
                    Return "[HumanElementRatingForeColorHex]"
                Case "colNaturalHazardsProtectionRatingForeColorHex"
                    Return "[NaturalHazardsProtectionRatingForeColorHex]"
                Case "colBusinessContinuityRatingForeColorHex"
                    Return "[BusinessContinuityRatingForeColorHex]"
                Case "colFireProtectionAllRecsCompleteRatingForeColorHex"
                    Return "[FireProtectionAllRecsCompleteRatingForeColorHex]"
                Case "colHumanElementAllRecsCompleteRatingForeColorHex"
                    Return "[HumanElementAllRecsCompleteRatingForeColorHex]"
                Case "colNatHazProtAllRecsCompleteRatingForeColorHex"
                    Return "[NatHazProtAllRecsCompleteRatingForeColorHex]"
                Case "colBcpAllRecsCompleteRatingForeColorHex"
                    Return "[BcpAllRecsCompleteRatingForeColorHex]"
                Case "colWhatIfScoreHexForeColor"
                    Return "[WhatIfScoreHexForeColor]"
                Case "colPhysicalProtectionWhatIfRatingForeColorHex"
                    Return "[PhysicalProtectionWhatIfRatingForeColorHex]"
                Case "colHumanElementWhatIfRatingForeColorHex"
                    Return "[HumanElementWhatIfRatingForeColorHex]"
                Case "colNaturalHazardsProtectionWhatIfRatingForeColorHex"
                    Return "[NaturalHazardsProtectionWhatIfRatingForeColorHex]"
                Case "colBusinessContinuityWhatIfRatingForeColorHex"
                    Return "[BusinessContinuityWhatIfRatingForeColorHex]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[AddressStamp]", "AddressStamp", "AddressStamp", "colAddressStamp"  
                    Return "colAddressStamp"
                Case "[address1]", "address1", "Address1", "colAddress1"  
                    Return "colAddress1"
                Case "[city]", "city", "City", "colCity"  
                    Return "colCity"
                Case "[stprov]", "stprov", "Stprov", "colStprov"  
                    Return "colStprov"
                Case "[country]", "country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[division]", "division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[zip]", "zip", "Zip", "colZip"  
                    Return "colZip"
                Case "[TIV]", "TIV", "Tiv", "colTiv"  
                    Return "colTiv"
                Case "[TIVBI]", "TIVBI", "Tivbi", "colTivbi"  
                    Return "colTivbi"
                Case "[TIVPD]", "TIVPD", "Tivpd", "colTivpd"  
                    Return "colTivpd"
                Case "[PML]", "PML", "Pml", "colPml"  
                    Return "colPml"
                Case "[PMLPD]", "PMLPD", "Pmlpd", "colPmlpd"  
                    Return "colPmlpd"
                Case "[PMLBI]", "PMLBI", "Pmlbi", "colPmlbi"  
                    Return "colPmlbi"
                Case "[MFLPD]", "MFLPD", "Mflpd", "colMflpd"  
                    Return "colMflpd"
                Case "[MFLBI]", "MFLBI", "Mflbi", "colMflbi"  
                    Return "colMflbi"
                Case "[MFL]", "MFL", "Mfl", "colMfl"  
                    Return "colMfl"
                Case "[APLPD]", "APLPD", "Aplpd", "colAplpd"  
                    Return "colAplpd"
                Case "[APLBI]", "APLBI", "Aplbi", "colAplbi"  
                    Return "colAplbi"
                Case "[APL]", "APL", "Apl", "colApl"  
                    Return "colApl"
                Case "[inspectiondate]", "inspectiondate", "Inspectiondate", "colInspectiondate"  
                    Return "colInspectiondate"
                Case "[grade]", "grade", "Grade", "colGrade"  
                    Return "colGrade"
                Case "[constructionrating]", "constructionrating", "Constructionrating", "colConstructionrating"  
                    Return "colConstructionrating"
                Case "[occupancyrating]", "occupancyrating", "Occupancyrating", "colOccupancyrating"  
                    Return "colOccupancyrating"
                Case "[floodrating]", "floodrating", "Floodrating", "colFloodrating"  
                    Return "colFloodrating"
                Case "[earthquakerating]", "earthquakerating", "Earthquakerating", "colEarthquakerating"  
                    Return "colEarthquakerating"
                Case "[windstormrating]", "windstormrating", "Windstormrating", "colWindstormrating"  
                    Return "colWindstormrating"
                Case "[otherrating]", "otherrating", "Otherrating", "colOtherrating"  
                    Return "colOtherrating"
                Case "[FloorRatingBackColorHex]", "FloorRatingBackColorHex", "FloorRatingBackColorHex", "colFloorRatingBackColorHex"  
                    Return "colFloorRatingBackColorHex"
                Case "[EarthquakeRatingBackColorHex]", "EarthquakeRatingBackColorHex", "EarthquakeRatingBackColorHex", "colEarthquakeRatingBackColorHex"  
                    Return "colEarthquakeRatingBackColorHex"
                Case "[WindstormRatingBackColorHex]", "WindstormRatingBackColorHex", "WindstormRatingBackColorHex", "colWindstormRatingBackColorHex"  
                    Return "colWindstormRatingBackColorHex"
                Case "[ConstructionRatingBackColorHex]", "ConstructionRatingBackColorHex", "ConstructionRatingBackColorHex", "colConstructionRatingBackColorHex"  
                    Return "colConstructionRatingBackColorHex"
                Case "[OccupancyRatingBackColorHex]", "OccupancyRatingBackColorHex", "OccupancyRatingBackColorHex", "colOccupancyRatingBackColorHex"  
                    Return "colOccupancyRatingBackColorHex"
                Case "[OtherRatingBackColorHex]", "OtherRatingBackColorHex", "OtherRatingBackColorHex", "colOtherRatingBackColorHex"  
                    Return "colOtherRatingBackColorHex"
                Case "[physicalprotectionrating]", "physicalprotectionrating", "Physicalprotectionrating", "colPhysicalprotectionrating"  
                    Return "colPhysicalprotectionrating"
                Case "[humanelementrating]", "humanelementrating", "Humanelementrating", "colHumanelementrating"  
                    Return "colHumanelementrating"
                Case "[naturalhazardsprotectionrating]", "naturalhazardsprotectionrating", "Naturalhazardsprotectionrating", "colNaturalhazardsprotectionrating"  
                    Return "colNaturalhazardsprotectionrating"
                Case "[businesscontinuityrating]", "businesscontinuityrating", "Businesscontinuityrating", "colBusinesscontinuityrating"  
                    Return "colBusinesscontinuityrating"
                Case "[PhysicalProtectionRatingBackColorHex]", "PhysicalProtectionRatingBackColorHex", "PhysicalProtectionRatingBackColorHex", "colPhysicalProtectionRatingBackColorHex"  
                    Return "colPhysicalProtectionRatingBackColorHex"
                Case "[HumanElementRatingBackColorHex]", "HumanElementRatingBackColorHex", "HumanElementRatingBackColorHex", "colHumanElementRatingBackColorHex"  
                    Return "colHumanElementRatingBackColorHex"
                Case "[NaturalHazardsProtectionRatingBackColorHex]", "NaturalHazardsProtectionRatingBackColorHex", "NaturalHazardsProtectionRatingBackColorHex", "colNaturalHazardsProtectionRatingBackColorHex"  
                    Return "colNaturalHazardsProtectionRatingBackColorHex"
                Case "[BusinessContinuityRatingBackColorHex]", "BusinessContinuityRatingBackColorHex", "BusinessContinuityRatingBackColorHex", "colBusinessContinuityRatingBackColorHex"  
                    Return "colBusinessContinuityRatingBackColorHex"
                Case "[aplfactor]", "aplfactor", "Aplfactor", "colAplfactor"  
                    Return "colAplfactor"
                Case "[overallplantratingrating]", "overallplantratingrating", "Overallplantratingrating", "colOverallplantratingrating"  
                    Return "colOverallplantratingrating"
                Case "[passivescore]", "passivescore", "Passivescore", "colPassivescore"  
                    Return "colPassivescore"
                Case "[activescore]", "activescore", "Activescore", "colActivescore"  
                    Return "colActivescore"
                Case "[WhatIfActiveScore]", "WhatIfActiveScore", "WhatIfActiveScore", "colWhatIfActiveScore"  
                    Return "colWhatIfActiveScore"
                Case "[totalscore]", "totalscore", "Totalscore", "colTotalscore"  
                    Return "colTotalscore"
                Case "[TotalScoreHexBackColor]", "TotalScoreHexBackColor", "TotalScoreHexBackColor", "colTotalScoreHexBackColor"  
                    Return "colTotalScoreHexBackColor"
                Case "[TotalScoreHexForeColor]", "TotalScoreHexForeColor", "TotalScoreHexForeColor", "colTotalScoreHexForeColor"  
                    Return "colTotalScoreHexForeColor"
                Case "[totalscorerating]", "totalscorerating", "Totalscorerating", "colTotalscorerating"  
                    Return "colTotalscorerating"
                Case "[WhatIfScore]", "WhatIfScore", "WhatIfScore", "colWhatIfScore"  
                    Return "colWhatIfScore"
                Case "[WhatIfScoreHexBackColor]", "WhatIfScoreHexBackColor", "WhatIfScoreHexBackColor", "colWhatIfScoreHexBackColor"  
                    Return "colWhatIfScoreHexBackColor"
                Case "[totalfacilityscore]", "totalfacilityscore", "Totalfacilityscore", "colTotalfacilityscore"  
                    Return "colTotalfacilityscore"
                Case "[otherweight]", "otherweight", "Otherweight", "colOtherweight"  
                    Return "colOtherweight"
                Case "[constructionweight]", "constructionweight", "Constructionweight", "colConstructionweight"  
                    Return "colConstructionweight"
                Case "[occupancyweight]", "occupancyweight", "Occupancyweight", "colOccupancyweight"  
                    Return "colOccupancyweight"
                Case "[physicalprotectionweight]", "physicalprotectionweight", "Physicalprotectionweight", "colPhysicalprotectionweight"  
                    Return "colPhysicalprotectionweight"
                Case "[humanelementweight]", "humanelementweight", "Humanelementweight", "colHumanelementweight"  
                    Return "colHumanelementweight"
                Case "[naturalhazardsprotectionweight]", "naturalhazardsprotectionweight", "Naturalhazardsprotectionweight", "colNaturalhazardsprotectionweight"  
                    Return "colNaturalhazardsprotectionweight"
                Case "[businesscontinuityweight]", "businesscontinuityweight", "Businesscontinuityweight", "colBusinesscontinuityweight"  
                    Return "colBusinesscontinuityweight"
                Case "[fireprotectionallrecscompleterating]", "fireprotectionallrecscompleterating", "Fireprotectionallrecscompleterating", "colFireprotectionallrecscompleterating"  
                    Return "colFireprotectionallrecscompleterating"
                Case "[humanelementallrecscompleterating]", "humanelementallrecscompleterating", "Humanelementallrecscompleterating", "colHumanelementallrecscompleterating"  
                    Return "colHumanelementallrecscompleterating"
                Case "[nathazprotallrecscompleterating]", "nathazprotallrecscompleterating", "Nathazprotallrecscompleterating", "colNathazprotallrecscompleterating"  
                    Return "colNathazprotallrecscompleterating"
                Case "[BcpAllRecsCompleteRating]", "BcpAllRecsCompleteRating", "BcpAllRecsCompleteRating", "colBcpAllRecsCompleteRating"  
                    Return "colBcpAllRecsCompleteRating"
                Case "[FireProtectionAllRecsCompleteRatingBackColorHex]", "FireProtectionAllRecsCompleteRatingBackColorHex", "FireProtectionAllRecsCompleteRatingBackColorHex", "colFireProtectionAllRecsCompleteRatingBackColorHex"  
                    Return "colFireProtectionAllRecsCompleteRatingBackColorHex"
                Case "[HumanElementAllRecsCompleteRatingBackColorHex]", "HumanElementAllRecsCompleteRatingBackColorHex", "HumanElementAllRecsCompleteRatingBackColorHex", "colHumanElementAllRecsCompleteRatingBackColorHex"  
                    Return "colHumanElementAllRecsCompleteRatingBackColorHex"
                Case "[NatHazProtAllRecsCompleteRatingBackColorHex]", "NatHazProtAllRecsCompleteRatingBackColorHex", "NatHazProtAllRecsCompleteRatingBackColorHex", "colNatHazProtAllRecsCompleteRatingBackColorHex"  
                    Return "colNatHazProtAllRecsCompleteRatingBackColorHex"
                Case "[BcpAllRecsCompleteRatingBackColorHex]", "BcpAllRecsCompleteRatingBackColorHex", "BcpAllRecsCompleteRatingBackColorHex", "colBcpAllRecsCompleteRatingBackColorHex"  
                    Return "colBcpAllRecsCompleteRatingBackColorHex"
                Case "[PhysicalProtectionWhatIfRatingBackColorHex]", "PhysicalProtectionWhatIfRatingBackColorHex", "PhysicalProtectionWhatIfRatingBackColorHex", "colPhysicalProtectionWhatIfRatingBackColorHex"  
                    Return "colPhysicalProtectionWhatIfRatingBackColorHex"
                Case "[HumanElementWhatIfRatingBackColorHex]", "HumanElementWhatIfRatingBackColorHex", "HumanElementWhatIfRatingBackColorHex", "colHumanElementWhatIfRatingBackColorHex"  
                    Return "colHumanElementWhatIfRatingBackColorHex"
                Case "[NaturalHazardsProtectionWhatIfRatingBackColorHex]", "NaturalHazardsProtectionWhatIfRatingBackColorHex", "NaturalHazardsProtectionWhatIfRatingBackColorHex", "colNaturalHazardsProtectionWhatIfRatingBackColorHex"  
                    Return "colNaturalHazardsProtectionWhatIfRatingBackColorHex"
                Case "[BusinessContinuityWhatIfRatingBackColorHex]", "BusinessContinuityWhatIfRatingBackColorHex", "BusinessContinuityWhatIfRatingBackColorHex", "colBusinessContinuityWhatIfRatingBackColorHex"  
                    Return "colBusinessContinuityWhatIfRatingBackColorHex"
                Case "[PhysicalProtectionWhatIfRating]", "PhysicalProtectionWhatIfRating", "PhysicalProtectionWhatIfRating", "colPhysicalProtectionWhatIfRating"  
                    Return "colPhysicalProtectionWhatIfRating"
                Case "[HumanElementWhatIfRating]", "HumanElementWhatIfRating", "HumanElementWhatIfRating", "colHumanElementWhatIfRating"  
                    Return "colHumanElementWhatIfRating"
                Case "[NaturalHazardsWhatIfRating]", "NaturalHazardsWhatIfRating", "NaturalHazardsWhatIfRating", "colNaturalHazardsWhatIfRating"  
                    Return "colNaturalHazardsWhatIfRating"
                Case "[BusinessContinuityWhatIfRating]", "BusinessContinuityWhatIfRating", "BusinessContinuityWhatIfRating", "colBusinessContinuityWhatIfRating"  
                    Return "colBusinessContinuityWhatIfRating"
                Case "[PhysicalProtectionWhatIfRatingDesc]", "PhysicalProtectionWhatIfRatingDesc", "PhysicalProtectionWhatIfRatingDesc", "colPhysicalProtectionWhatIfRatingDesc"  
                    Return "colPhysicalProtectionWhatIfRatingDesc"
                Case "[HumanElementWhatIfRatingDesc]", "HumanElementWhatIfRatingDesc", "HumanElementWhatIfRatingDesc", "colHumanElementWhatIfRatingDesc"  
                    Return "colHumanElementWhatIfRatingDesc"
                Case "[NaturalHazardsWhatIfRatingDesc]", "NaturalHazardsWhatIfRatingDesc", "NaturalHazardsWhatIfRatingDesc", "colNaturalHazardsWhatIfRatingDesc"  
                    Return "colNaturalHazardsWhatIfRatingDesc"
                Case "[BusinessContinuityWhatIfRatingDesc]", "BusinessContinuityWhatIfRatingDesc", "BusinessContinuityWhatIfRatingDesc", "colBusinessContinuityWhatIfRatingDesc"  
                    Return "colBusinessContinuityWhatIfRatingDesc"
                Case "[activescorewithrecscomplete]", "activescorewithrecscomplete", "Activescorewithrecscomplete", "colActivescorewithrecscomplete"  
                    Return "colActivescorewithrecscomplete"
                Case "[aplwithallrecscomplete]", "aplwithallrecscomplete", "Aplwithallrecscomplete", "colAplwithallrecscomplete"  
                    Return "colAplwithallrecscomplete"
                Case "[floodweight]", "floodweight", "Floodweight", "colFloodweight"  
                    Return "colFloodweight"
                Case "[earthquakeweight]", "earthquakeweight", "Earthquakeweight", "colEarthquakeweight"  
                    Return "colEarthquakeweight"
                Case "[windstormweight]", "windstormweight", "Windstormweight", "colWindstormweight"  
                    Return "colWindstormweight"
                Case "[overallscorewithrecscomplete]", "overallscorewithrecscomplete", "Overallscorewithrecscomplete", "colOverallscorewithrecscomplete"  
                    Return "colOverallscorewithrecscomplete"
                Case "[maxpossiblescore]", "maxpossiblescore", "Maxpossiblescore", "colMaxpossiblescore"  
                    Return "colMaxpossiblescore"
                Case "[aplfactorwithallrecscomplete]", "aplfactorwithallrecscomplete", "Aplfactorwithallrecscomplete", "colAplfactorwithallrecscomplete"  
                    Return "colAplfactorwithallrecscomplete"
                Case "[flooddescription]", "flooddescription", "Flooddescription", "colFlooddescription"  
                    Return "colFlooddescription"
                Case "[earthquakedescription]", "earthquakedescription", "Earthquakedescription", "colEarthquakedescription"  
                    Return "colEarthquakedescription"
                Case "[windstormdescription]", "windstormdescription", "Windstormdescription", "colWindstormdescription"  
                    Return "colWindstormdescription"
                Case "[constructiondescription]", "constructiondescription", "Constructiondescription", "colConstructiondescription"  
                    Return "colConstructiondescription"
                Case "[occupancydescription]", "occupancydescription", "Occupancydescription", "colOccupancydescription"  
                    Return "colOccupancydescription"
                Case "[otherdescription]", "otherdescription", "Otherdescription", "colOtherdescription"  
                    Return "colOtherdescription"
                Case "[firedescription]", "firedescription", "Firedescription", "colFiredescription"  
                    Return "colFiredescription"
                Case "[humandescription]", "humandescription", "Humandescription", "colHumandescription"  
                    Return "colHumandescription"
                Case "[naturaldescription]", "naturaldescription", "Naturaldescription", "colNaturaldescription"  
                    Return "colNaturaldescription"
                Case "[businessdescription]", "businessdescription", "Businessdescription", "colBusinessdescription"  
                    Return "colBusinessdescription"
                Case "[firerecdescription]", "firerecdescription", "Firerecdescription", "colFirerecdescription"  
                    Return "colFirerecdescription"
                Case "[humanrecdescription]", "humanrecdescription", "Humanrecdescription", "colHumanrecdescription"  
                    Return "colHumanrecdescription"
                Case "[naturalrecdescription]", "naturalrecdescription", "Naturalrecdescription", "colNaturalrecdescription"  
                    Return "colNaturalrecdescription"
                Case "[businessrecdescription]", "businessrecdescription", "Businessrecdescription", "colBusinessrecdescription"  
                    Return "colBusinessrecdescription"
                Case "[exchangerate]", "exchangerate", "Exchangerate", "colExchangerate"  
                    Return "colExchangerate"
                Case "[adminmemo]", "adminmemo", "Adminmemo", "colAdminmemo"  
                    Return "colAdminmemo"
                Case "[overallscorewithrecscompleterating]", "overallscorewithrecscompleterating", "Overallscorewithrecscompleterating", "colOverallscorewithrecscompleterating"  
                    Return "colOverallscorewithrecscompleterating"
                Case "[maxpossiblerating]", "maxpossiblerating", "Maxpossiblerating", "colMaxpossiblerating"  
                    Return "colMaxpossiblerating"
                Case "[OverallScoreWithRecsCompleteHexForeColor]", "OverallScoreWithRecsCompleteHexForeColor", "OverallScoreWithRecsCompleteHexForeColor", "colOverallScoreWithRecsCompleteHexForeColor"  
                    Return "colOverallScoreWithRecsCompleteHexForeColor"
                Case "[OverallScoreWithRecsCompleteHexBackColor]", "OverallScoreWithRecsCompleteHexBackColor", "OverallScoreWithRecsCompleteHexBackColor", "colOverallScoreWithRecsCompleteHexBackColor"  
                    Return "colOverallScoreWithRecsCompleteHexBackColor"
                Case "[AchievableScorePercent]", "AchievableScorePercent", "AchievableScorePercent", "colAchievableScorePercent"  
                    Return "colAchievableScorePercent"
                Case "[AchievableScorePercentString]", "AchievableScorePercentString", "AchievableScorePercentString", "colAchievableScorePercentString"  
                    Return "colAchievableScorePercentString"
                Case "[AchievableScorePercentHexForeColor]", "AchievableScorePercentHexForeColor", "AchievableScorePercentHexForeColor", "colAchievableScorePercentHexForeColor"  
                    Return "colAchievableScorePercentHexForeColor"
                Case "[AchievableScorePercentHexBackColor]", "AchievableScorePercentHexBackColor", "AchievableScorePercentHexBackColor", "colAchievableScorePercentHexBackColor"  
                    Return "colAchievableScorePercentHexBackColor"
                Case "[IsLatestRating]", "IsLatestRating", "IsLatestRating", "colIsLatestRating"  
                    Return "colIsLatestRating"
                Case "[AchievablePercentWhatIfString]", "AchievablePercentWhatIfString", "AchievablePercentWhatIfString", "colAchievablePercentWhatIfString"  
                    Return "colAchievablePercentWhatIfString"
                Case "[AchievablePercentWhatIfHexBackColor]", "AchievablePercentWhatIfHexBackColor", "AchievablePercentWhatIfHexBackColor", "colAchievablePercentWhatIfHexBackColor"  
                    Return "colAchievablePercentWhatIfHexBackColor"
                Case "[AchievablePercentWhatIfHexForeColor]", "AchievablePercentWhatIfHexForeColor", "AchievablePercentWhatIfHexForeColor", "colAchievablePercentWhatIfHexForeColor"  
                    Return "colAchievablePercentWhatIfHexForeColor"
                Case "[AchievablePercentAllRecsCompHexBackColor]", "AchievablePercentAllRecsCompHexBackColor", "AchievablePercentAllRecsCompHexBackColor", "colAchievablePercentAllRecsCompHexBackColor"  
                    Return "colAchievablePercentAllRecsCompHexBackColor"
                Case "[AchievablePercentAllRecsCompHexForeColor]", "AchievablePercentAllRecsCompHexForeColor", "AchievablePercentAllRecsCompHexForeColor", "colAchievablePercentAllRecsCompHexForeColor"  
                    Return "colAchievablePercentAllRecsCompHexForeColor"
                Case "[AchievablePercentAllRecsCompString]", "AchievablePercentAllRecsCompString", "AchievablePercentAllRecsCompString", "colAchievablePercentAllRecsCompString"  
                    Return "colAchievablePercentAllRecsCompString"
                Case "[RatingID]", "RatingID", "RatingID", "colRatingID"  
                    Return "colRatingID"
                Case "[FloorRatingForeColorHex]", "FloorRatingForeColorHex", "FloorRatingForeColorHex", "colFloorRatingForeColorHex"  
                    Return "colFloorRatingForeColorHex"
                Case "[EarthquakeRatingForeColorHex]", "EarthquakeRatingForeColorHex", "EarthquakeRatingForeColorHex", "colEarthquakeRatingForeColorHex"  
                    Return "colEarthquakeRatingForeColorHex"
                Case "[WindstormRatingForeColorHex]", "WindstormRatingForeColorHex", "WindstormRatingForeColorHex", "colWindstormRatingForeColorHex"  
                    Return "colWindstormRatingForeColorHex"
                Case "[ConstructionRatingForeColorHex]", "ConstructionRatingForeColorHex", "ConstructionRatingForeColorHex", "colConstructionRatingForeColorHex"  
                    Return "colConstructionRatingForeColorHex"
                Case "[OccupancyRatingForeColorHex]", "OccupancyRatingForeColorHex", "OccupancyRatingForeColorHex", "colOccupancyRatingForeColorHex"  
                    Return "colOccupancyRatingForeColorHex"
                Case "[OtherRatingForeColorHex]", "OtherRatingForeColorHex", "OtherRatingForeColorHex", "colOtherRatingForeColorHex"  
                    Return "colOtherRatingForeColorHex"
                Case "[PhysicalProtectionRatingForeColorHex]", "PhysicalProtectionRatingForeColorHex", "PhysicalProtectionRatingForeColorHex", "colPhysicalProtectionRatingForeColorHex"  
                    Return "colPhysicalProtectionRatingForeColorHex"
                Case "[HumanElementRatingForeColorHex]", "HumanElementRatingForeColorHex", "HumanElementRatingForeColorHex", "colHumanElementRatingForeColorHex"  
                    Return "colHumanElementRatingForeColorHex"
                Case "[NaturalHazardsProtectionRatingForeColorHex]", "NaturalHazardsProtectionRatingForeColorHex", "NaturalHazardsProtectionRatingForeColorHex", "colNaturalHazardsProtectionRatingForeColorHex"  
                    Return "colNaturalHazardsProtectionRatingForeColorHex"
                Case "[BusinessContinuityRatingForeColorHex]", "BusinessContinuityRatingForeColorHex", "BusinessContinuityRatingForeColorHex", "colBusinessContinuityRatingForeColorHex"  
                    Return "colBusinessContinuityRatingForeColorHex"
                Case "[FireProtectionAllRecsCompleteRatingForeColorHex]", "FireProtectionAllRecsCompleteRatingForeColorHex", "FireProtectionAllRecsCompleteRatingForeColorHex", "colFireProtectionAllRecsCompleteRatingForeColorHex"  
                    Return "colFireProtectionAllRecsCompleteRatingForeColorHex"
                Case "[HumanElementAllRecsCompleteRatingForeColorHex]", "HumanElementAllRecsCompleteRatingForeColorHex", "HumanElementAllRecsCompleteRatingForeColorHex", "colHumanElementAllRecsCompleteRatingForeColorHex"  
                    Return "colHumanElementAllRecsCompleteRatingForeColorHex"
                Case "[NatHazProtAllRecsCompleteRatingForeColorHex]", "NatHazProtAllRecsCompleteRatingForeColorHex", "NatHazProtAllRecsCompleteRatingForeColorHex", "colNatHazProtAllRecsCompleteRatingForeColorHex"  
                    Return "colNatHazProtAllRecsCompleteRatingForeColorHex"
                Case "[BcpAllRecsCompleteRatingForeColorHex]", "BcpAllRecsCompleteRatingForeColorHex", "BcpAllRecsCompleteRatingForeColorHex", "colBcpAllRecsCompleteRatingForeColorHex"  
                    Return "colBcpAllRecsCompleteRatingForeColorHex"
                Case "[WhatIfScoreHexForeColor]", "WhatIfScoreHexForeColor", "WhatIfScoreHexForeColor", "colWhatIfScoreHexForeColor"  
                    Return "colWhatIfScoreHexForeColor"
                Case "[PhysicalProtectionWhatIfRatingForeColorHex]", "PhysicalProtectionWhatIfRatingForeColorHex", "PhysicalProtectionWhatIfRatingForeColorHex", "colPhysicalProtectionWhatIfRatingForeColorHex"  
                    Return "colPhysicalProtectionWhatIfRatingForeColorHex"
                Case "[HumanElementWhatIfRatingForeColorHex]", "HumanElementWhatIfRatingForeColorHex", "HumanElementWhatIfRatingForeColorHex", "colHumanElementWhatIfRatingForeColorHex"  
                    Return "colHumanElementWhatIfRatingForeColorHex"
                Case "[NaturalHazardsProtectionWhatIfRatingForeColorHex]", "NaturalHazardsProtectionWhatIfRatingForeColorHex", "NaturalHazardsProtectionWhatIfRatingForeColorHex", "colNaturalHazardsProtectionWhatIfRatingForeColorHex"  
                    Return "colNaturalHazardsProtectionWhatIfRatingForeColorHex"
                Case "[BusinessContinuityWhatIfRatingForeColorHex]", "BusinessContinuityWhatIfRatingForeColorHex", "BusinessContinuityWhatIfRatingForeColorHex", "colBusinessContinuityWhatIfRatingForeColorHex"  
                    Return "colBusinessContinuityWhatIfRatingForeColorHex"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colGSafeId"
                    Return "Integer"
                Case "colFileNo"
                    Return "String"
                Case "colAddressStamp"
                    Return "String"
                Case "colAddress1"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStprov"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colZip"
                    Return "String"
                Case "colTiv"
                    Return "Double"
                Case "colTivbi"
                    Return "Double"
                Case "colTivpd"
                    Return "Double"
                Case "colPml"
                    Return "Double"
                Case "colPmlpd"
                    Return "Double"
                Case "colPmlbi"
                    Return "Double"
                Case "colMflpd"
                    Return "Double"
                Case "colMflbi"
                    Return "Double"
                Case "colMfl"
                    Return "Double"
                Case "colAplpd"
                    Return "Double"
                Case "colAplbi"
                    Return "Double"
                Case "colApl"
                    Return "Double"
                Case "colInspectiondate"
                    Return "DateTime"
                Case "colGrade"
                    Return "Decimal"
                Case "colConstructionrating"
                    Return "Decimal"
                Case "colOccupancyrating"
                    Return "Decimal"
                Case "colFloodrating"
                    Return "Decimal"
                Case "colEarthquakerating"
                    Return "Decimal"
                Case "colWindstormrating"
                    Return "Decimal"
                Case "colOtherrating"
                    Return "Decimal"
                Case "colFloorRatingBackColorHex"
                    Return "String"
                Case "colEarthquakeRatingBackColorHex"
                    Return "String"
                Case "colWindstormRatingBackColorHex"
                    Return "String"
                Case "colConstructionRatingBackColorHex"
                    Return "String"
                Case "colOccupancyRatingBackColorHex"
                    Return "String"
                Case "colOtherRatingBackColorHex"
                    Return "String"
                Case "colPhysicalprotectionrating"
                    Return "Decimal"
                Case "colHumanelementrating"
                    Return "Decimal"
                Case "colNaturalhazardsprotectionrating"
                    Return "Decimal"
                Case "colBusinesscontinuityrating"
                    Return "Decimal"
                Case "colPhysicalProtectionRatingBackColorHex"
                    Return "String"
                Case "colHumanElementRatingBackColorHex"
                    Return "String"
                Case "colNaturalHazardsProtectionRatingBackColorHex"
                    Return "String"
                Case "colBusinessContinuityRatingBackColorHex"
                    Return "String"
                Case "colAplfactor"
                    Return "Decimal"
                Case "colOverallplantratingrating"
                    Return "String"
                Case "colPassivescore"
                    Return "Decimal"
                Case "colActivescore"
                    Return "Decimal"
                Case "colWhatIfActiveScore"
                    Return "Decimal"
                Case "colTotalscore"
                    Return "Decimal"
                Case "colTotalScoreHexBackColor"
                    Return "String"
                Case "colTotalScoreHexForeColor"
                    Return "String"
                Case "colTotalscorerating"
                    Return "String"
                Case "colWhatIfScore"
                    Return "Decimal"
                Case "colWhatIfScoreHexBackColor"
                    Return "String"
                Case "colTotalfacilityscore"
                    Return "Decimal"
                Case "colOtherweight"
                    Return "Decimal"
                Case "colConstructionweight"
                    Return "Decimal"
                Case "colOccupancyweight"
                    Return "Decimal"
                Case "colPhysicalprotectionweight"
                    Return "Decimal"
                Case "colHumanelementweight"
                    Return "Decimal"
                Case "colNaturalhazardsprotectionweight"
                    Return "Decimal"
                Case "colBusinesscontinuityweight"
                    Return "Decimal"
                Case "colFireprotectionallrecscompleterating"
                    Return "Decimal"
                Case "colHumanelementallrecscompleterating"
                    Return "Decimal"
                Case "colNathazprotallrecscompleterating"
                    Return "Decimal"
                Case "colBcpAllRecsCompleteRating"
                    Return "Decimal"
                Case "colFireProtectionAllRecsCompleteRatingBackColorHex"
                    Return "String"
                Case "colHumanElementAllRecsCompleteRatingBackColorHex"
                    Return "String"
                Case "colNatHazProtAllRecsCompleteRatingBackColorHex"
                    Return "String"
                Case "colBcpAllRecsCompleteRatingBackColorHex"
                    Return "String"
                Case "colPhysicalProtectionWhatIfRatingBackColorHex"
                    Return "String"
                Case "colHumanElementWhatIfRatingBackColorHex"
                    Return "String"
                Case "colNaturalHazardsProtectionWhatIfRatingBackColorHex"
                    Return "String"
                Case "colBusinessContinuityWhatIfRatingBackColorHex"
                    Return "String"
                Case "colPhysicalProtectionWhatIfRating"
                    Return "Decimal"
                Case "colHumanElementWhatIfRating"
                    Return "Decimal"
                Case "colNaturalHazardsWhatIfRating"
                    Return "Decimal"
                Case "colBusinessContinuityWhatIfRating"
                    Return "Decimal"
                Case "colPhysicalProtectionWhatIfRatingDesc"
                    Return "String"
                Case "colHumanElementWhatIfRatingDesc"
                    Return "String"
                Case "colNaturalHazardsWhatIfRatingDesc"
                    Return "String"
                Case "colBusinessContinuityWhatIfRatingDesc"
                    Return "String"
                Case "colActivescorewithrecscomplete"
                    Return "Decimal"
                Case "colAplwithallrecscomplete"
                    Return "Decimal"
                Case "colFloodweight"
                    Return "Decimal"
                Case "colEarthquakeweight"
                    Return "Decimal"
                Case "colWindstormweight"
                    Return "Decimal"
                Case "colOverallscorewithrecscomplete"
                    Return "Decimal"
                Case "colMaxpossiblescore"
                    Return "Decimal"
                Case "colAplfactorwithallrecscomplete"
                    Return "Decimal"
                Case "colFlooddescription"
                    Return "String"
                Case "colEarthquakedescription"
                    Return "String"
                Case "colWindstormdescription"
                    Return "String"
                Case "colConstructiondescription"
                    Return "String"
                Case "colOccupancydescription"
                    Return "String"
                Case "colOtherdescription"
                    Return "String"
                Case "colFiredescription"
                    Return "String"
                Case "colHumandescription"
                    Return "String"
                Case "colNaturaldescription"
                    Return "String"
                Case "colBusinessdescription"
                    Return "String"
                Case "colFirerecdescription"
                    Return "String"
                Case "colHumanrecdescription"
                    Return "String"
                Case "colNaturalrecdescription"
                    Return "String"
                Case "colBusinessrecdescription"
                    Return "String"
                Case "colExchangerate"
                    Return "Decimal"
                Case "colAdminmemo"
                    Return "String"
                Case "colOverallscorewithrecscompleterating"
                    Return "String"
                Case "colMaxpossiblerating"
                    Return "String"
                Case "colOverallScoreWithRecsCompleteHexForeColor"
                    Return "String"
                Case "colOverallScoreWithRecsCompleteHexBackColor"
                    Return "String"
                Case "colAchievableScorePercent"
                    Return "Decimal"
                Case "colAchievableScorePercentString"
                    Return "String"
                Case "colAchievableScorePercentHexForeColor"
                    Return "String"
                Case "colAchievableScorePercentHexBackColor"
                    Return "String"
                Case "colIsLatestRating"
                    Return "String"
                Case "colAchievablePercentWhatIfString"
                    Return "String"
                Case "colAchievablePercentWhatIfHexBackColor"
                    Return "String"
                Case "colAchievablePercentWhatIfHexForeColor"
                    Return "String"
                Case "colAchievablePercentAllRecsCompHexBackColor"
                    Return "String"
                Case "colAchievablePercentAllRecsCompHexForeColor"
                    Return "String"
                Case "colAchievablePercentAllRecsCompString"
                    Return "String"
                Case "colRatingID"
                    Return "Decimal"
                Case "colFloorRatingForeColorHex"
                    Return "String"
                Case "colEarthquakeRatingForeColorHex"
                    Return "String"
                Case "colWindstormRatingForeColorHex"
                    Return "String"
                Case "colConstructionRatingForeColorHex"
                    Return "String"
                Case "colOccupancyRatingForeColorHex"
                    Return "String"
                Case "colOtherRatingForeColorHex"
                    Return "String"
                Case "colPhysicalProtectionRatingForeColorHex"
                    Return "String"
                Case "colHumanElementRatingForeColorHex"
                    Return "String"
                Case "colNaturalHazardsProtectionRatingForeColorHex"
                    Return "String"
                Case "colBusinessContinuityRatingForeColorHex"
                    Return "String"
                Case "colFireProtectionAllRecsCompleteRatingForeColorHex"
                    Return "String"
                Case "colHumanElementAllRecsCompleteRatingForeColorHex"
                    Return "String"
                Case "colNatHazProtAllRecsCompleteRatingForeColorHex"
                    Return "String"
                Case "colBcpAllRecsCompleteRatingForeColorHex"
                    Return "String"
                Case "colWhatIfScoreHexForeColor"
                    Return "String"
                Case "colPhysicalProtectionWhatIfRatingForeColorHex"
                    Return "String"
                Case "colHumanElementWhatIfRatingForeColorHex"
                    Return "String"
                Case "colNaturalHazardsProtectionWhatIfRatingForeColorHex"
                    Return "String"
                Case "colBusinessContinuityWhatIfRatingForeColorHex"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[rv].[vwWhatIfFireFacilityRating]"
        End Function

        Private Function _FirstColumn() As String
            Return "[GSafeId]"
        End Function

    End Class
End namespace

