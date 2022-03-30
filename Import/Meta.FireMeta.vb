
Public Class FireMeta
    Inherits Meta

    Private _Util As ImportUtility

    Public Sub New(pImportUtil As ImportUtility)
        _Util = pImportUtil
    End Sub

    Friend Overrides ReadOnly Property Practice As Libraries.CoreLib.UtilPractice.PracticeEnum
        Get
            Return UtilPractice.PracticeEnum.Fire
        End Get
    End Property

    Friend Overrides ReadOnly Property SurveyDateCellAddress As CellAddress
        Get
            Return New CellAddress("Cope Data", "AD2")
        End Get
    End Property

    Friend Overrides ReadOnly Property FileNoCellAddress As CellAddress
        Get
            Return New CellAddress("Cope Data", "U2")
        End Get

    End Property

    Friend ReadOnly Property FireCopeErrorAddresses As List(Of CellAddress)
        Get
            Dim zList As New List(Of CellAddress)
            zList.Add(New CellAddress("Cope Data", "CA2"))
            Return zList
        End Get
    End Property

    Friend ReadOnly Property FireRecommendationErrorAddresses As List(Of CellAddress)
        Get
            Dim zList As New List(Of CellAddress)
            zList.Add(New CellAddress("Rec Tracking", "BM2"))
            Return zList
        End Get
    End Property

    Friend ReadOnly Property FireRatingErrorAddresses As List(Of CellAddress)
        Get
            Dim zList As New List(Of CellAddress)
            zList.Add(New CellAddress("Rating Form", "CM2"))
            Return zList
        End Get
    End Property

    Friend Overrides ReadOnly Property TemplateVersionAddress As CellAddress
        Get
            Return New CellAddress("Cope Data", "O7")
        End Get
    End Property
 
    Friend ReadOnly Property FireNatHazDataErrorAddresses As List(Of CellAddress)
        Get
            Dim zList As New List(Of CellAddress)
            zList.Add(New CellAddress("Nat Haz Data", "BA2"))
            zList.Add(New CellAddress("Nat Haz Data", "BA4"))
            zList.Add(New CellAddress("Nat Haz Data", "BA6"))
            zList.Add(New CellAddress("Nat Haz Data", "BA8"))
            Return zList
        End Get
    End Property

    Friend ReadOnly Property FireRetailErrorAddresses As List(Of CellAddress)
        Get
            Dim zList As New List(Of CellAddress)
            zList.Add(New CellAddress("Retail Data", "N2"))
            Return zList
        End Get
    End Property


#Region "Standard Import Ranges"

    Overridable ReadOnly Property FireCopeMainImportInfo As FireImportInfo
        Get
            If _Util._XLInfo.TemplateVersion >= 5.8174 Then
                'IMPORTS NEW MAINUSER1, MAINUSER2, MAINUSER3, MAINUSER4 FIELDS
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeMain, {"U1:BL2"}, Me, FireCopeMainMapCollection)
            ElseIf _Util._XLInfo.TemplateVersion >= 5.5 Then
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeMain, {"U1:BH2"}, Me, FireCopeMainMapCollection)
            Else
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeMain, {"U1:BH2"}, Me, FireCopeMainMapCollection)
            End If
        End Get

    End Property

    Overridable ReadOnly Property FireCopeConstructionImportInfo As FireImportInfo
        Get
            If _Util._XLInfo.TemplateVersion >= 5.5 Then
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeConstruction, {"U7:AN8"}, Me, FireCopeConstructionMapCollection)
            Else
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeConstruction, {"U7:AL8"}, Me, FireCopeConstructionMapCollection)
            End If
        End Get
    End Property

    Overridable ReadOnly Property FireCopeOccupancyImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeOccupancy, {"U14:AR15"}, Me, FireCopeOccupancyMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireCopeProtectionImportInfo As FireImportInfo
        Get
            If _Util._XLInfo.TemplateVersion >= 5.8174 Then
                'IMPORTS NEW ISO RELATED FIELDS
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeProtection, {"U19:CN20"}, Me, FireCopeProtectionMapCollection)
            ElseIf _Util._XLInfo.TemplateVersion >= 5.8 Then
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeProtection, {"U19:CK20"}, Me, FireCopeProtectionMapCollection)
            ElseIf _Util._XLInfo.TemplateVersion >= 5.7 Then
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeProtection, {"U19:CE20"}, Me, FireCopeProtectionMapCollection)
            ElseIf _Util._XLInfo.TemplateVersion >= 5.5 Then
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeProtection, {"U19:CB20"}, Me, FireCopeProtectionMapCollection)
            Else
                Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeProtection, {"U19:BY20"}, Me, FireCopeProtectionMapCollection)
            End If
        End Get
    End Property

    Overridable ReadOnly Property FireCopeExposureImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.CopeData, ImportEnum.ImportTable.FireCopeExposure, {"U25:AR26"}, Me, FireCopeExposureMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireRecTrackingImportInfo As FireImportInfo
        Get
            If _Util._XLInfo.TemplateVersion >= 6.0 Then
                'Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.FireRecommendation, {"O308:CL424"}, Me, FireRecommendationMapCollection)
                Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.FireRecommendation, {"O308:AG424", "BN308:BQ424", "CG308:CL424", "BM308:BM424"}, Me, FireRecommendationMapCollection)
            ElseIf _Util._XLInfo.TemplateVersion >= 5.8174 Then
                'IMPORTS NEW RECDETAIL FIELD
                Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.FireRecommendation, {"O8:AG37", "BN8:BN37"}, Me, FireRecommendationMapCollection)
            Else
                Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.FireRecommendation, {"O8:AG37"}, Me, FireRecommendationMapCollection)
            End If
        End Get
    End Property

    Overridable ReadOnly Property FireRecTracking2ImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, "Rec Tracking (2)", ImportEnum.ImportTable.FireRecommendation, {"O8:AG37"}, Me, FireRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireRecTracking3ImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, "Rec Tracking (3)", ImportEnum.ImportTable.FireRecommendation, {"O8:AG37"}, Me, FireRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireRecTracking4ImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, "Rec Tracking (4)", ImportEnum.ImportTable.FireRecommendation, {"O8:AG37"}, Me, FireRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireRatingImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.RatingForm, ImportEnum.ImportTable.FireRating, {"P3:CB4"}, Me, FireRatingMapCollection)
        End Get
    End Property


    Overridable ReadOnly Property FireRetailImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.RetailData, ImportEnum.ImportTable.FireRetail, {"Q4:ER5"}, Me, FireRetailMapCollection)
        End Get
    End Property


    Overridable ReadOnly Property FireNatHazDataWindGeneralImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazWindGeneral, {"O7:AI8"}, Me, FireNatHazWindGeneralMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataWindEnvelopeImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazWindBuildingEnvelope, {"O17:AJ18"}, Me, FireNatHazWindBuildingEnvelopeMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataWindUtilityImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazWindUtility, {"O25:AD26"}, Me, FireNatHazWindUtilityMapCollection)
        End Get
    End Property


    Overridable ReadOnly Property FireNatHazDataWindMiscImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazWindOther, {"O35:AH36"}, Me, FireNatHazWindOtherMapCollection)
        End Get
    End Property


    Overridable ReadOnly Property FireNatHazDataSeismicGeneralImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazSeismicGeneral, {"O107:X108"}, Me, FireNatHazSeismicGeneralMapCollection)
        End Get
    End Property


    Overridable ReadOnly Property FireNatHazDataSeismicStructuralImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazSeismicStructural, {"O117:AK118"}, Me, FireNatHazSeismicStructuralMapCollection)
        End Get
    End Property


    Overridable ReadOnly Property FireNatHazDataSeismicStructuralDataImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazSeismicStructuralData, {"O123:V124"}, Me, FireNatHazSeismicStructuralDataMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataSeismicNonStructuralImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazSeismicNonStructural, {"O136:AR137"}, Me, FireNatHazSeismicNonStructuralMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataFloodGeneralImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazFloodGeneral, {"O192:AF193"}, Me, FireNatHazFloodGeneralMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataFloodExposureImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazFloodExposure, {"O209:Z210"}, Me, FireNatHazFloodExposureMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataFloodBldgStructureImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazFloodBldgStructure, {"O222:V223"}, Me, FireNatHazFloodBldgStructureMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazDataFloodOtherImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazData, ImportEnum.ImportTable.FireNatHazFloodOther, {"O231:Z232"}, Me, FireNatHazFloodOtherMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property FireNatHazModelingDataImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.NatHazModelingData, ImportEnum.ImportTable.FireNatHazModeling, {"DA7:GB58"}, Me, FireNatHazModelingMapCollection)
        End Get
    End Property

#End Region


#Region "Map Collections"  '(Generated On: 8/27/2012)


    '--AutoGenerated (SQL Table: Cope-FireMain)
    Overridable ReadOnly Property FireCopeMainMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                '.Add("","Client")
                '.Add("","Facility")
                '.Add("","City")
                '.Add("","St/Prov")
                '.Add("","Country")
                .Add("Latitude", "Latitude")
                .Add("Longitude", "Longitude")
                .Add("Consultant", "Engineer")
                .Add("SurveyDate", "SurveyDate")
                .Add("Units", "Units")
                .Add("Currency", "Currency")
                .Add("BIReporting", "BIReporting")
                .Add("ExchangeRate", "CurrencyConversionFactor")
                .Add("Tivpd", "TIV-PD($)")
                .Add("Tivbi", "TIV-BI($)")
                .Add("TIVTotal", "TIV-Total($)")
                .Add("Aplpd", "APL-PD($)")
                .Add("Aplbi", "APL-BI($)")
                .Add("APLTotal", "APL-Total($)")
                .Add("APLPDPercentage", "APL-PD(%)")
                .Add("APLBIPercentage", "APL-BI(%)")
                .Add("APLTotalPercentage", "APL-Total(%)")
                .Add("Pmlpd", "PML-PD($)")
                .Add("Pmlbi", "PML-BI($)")
                .Add("PMLTotal", "PML-Total($)")
                .Add("PMLPDPercentage", "PML-PD(%)")
                .Add("PMLBIPercentage", "PML-BI(%)")
                .Add("PMLTotalPercentage", "PML-Total(%)")
                .Add("Mflpd", "MFL-PD($)")
                .Add("Mflbi", "MFL BI($)")
                .Add("MFLTotal", "MFL-Total($)")
                .Add("MFLPDPercentage", "MFL-PD(%)")
                .Add("MFLBIPercentage", "MFL-BI(%)")
                .Add("MFLTotalPercentage", "MFL-Total(%)")
                .Add("Interdependencies", "Interdependencies")
                .Add("LEandInterdependecyComments", "InterdependencyComments")
                .Add("SignificantPropertyDamageLossesInPast3Years", "SignificantPropertyDamageLosses:")
                .Add("SignificantPropertyDescriptionField", "SignificantLossDescription")

                If _Util._XLInfo.TemplateVersion >= 5.5 Then
                    .Add("PropertyValuesReasonable", "PropValuesReasonable")
                End If

                If _Util._XLInfo.TemplateVersion >= 5.8174 Then
                    .Add("MainUser1", "MainUser1")
                    .Add("MainUser2", "MainUser2")
                    .Add("MainUser3", "MainUser3")
                    .Add("MainUser4", "MainUser4")
                End If

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-FireConstruction)
    Overridable ReadOnly Property FireCopeConstructionMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("NoofStories", "No.ofstories")
                .Add("TotalFloorArea", "TotalFloorArea")
                .Add("InititalMajorConstructionYear", "ConstructionStart")
                .Add("LastAdditionYear", "Dateoflastremodel/addn")
                .Add("BuildingHeight", "Bldg.Height")
                .Add("RoofConstructionFireResistive", "RoofConstruction:%FireResistive")
                .Add("RoofConstructionNoncombustible", "RoofConstruction:%Noncombustible")
                .Add("RoofConstructionCombustible", "RoofConstruction:%Combustible")
                .Add("RoofConstructionClass", "RoofConstruction:%ClassII/UnkStDeck")
                .Add("RoofConstructionDescription", "Construction:Description")
                .Add("NoofFireAreas", "NoofFireAreas")
                .Add("SeparationDescription", "SeparationDescription")
                .Add("NoBasementLevels", "NoBasementLevels")
                .Add("ConstructionUser1", "ConstructionUser1")
                .Add("ConstructionUser2", "ConstructionUser2")
                .Add("ConstructionUser3", "ConstructionUser3")
                .Add("ConstructionUser4", "ConstructionUser4")

                If _Util._XLInfo.TemplateVersion >= 5.5 Then
                    .Add("MajorProjectsPlanned", "ProjectsPlanned")
                    .Add("MajorProjectsValueRange", "ProjectValue")
                End If

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-FireOccupancy)
    Overridable ReadOnly Property FireCopeOccupancyMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("IndustryGroup", "IndustryGroup")
                .Add("MajorGroup", "MajorGroup")
                .Add("SpecificGroup", "SpecificGroup")
                .Add("SICCode", "SICCode")
                .Add("HoursDay", "Hours/Day")
                .Add("DaysWeek", "Days/Week")
                .Add("NumberOfEmployees", "No.ofemployees")
                .Add("PercentManufacturing", "%Manufacturing")
                .Add("PercentWholesaleDistStge", "%Dist./Stge.:")
                .Add("PercentOffice", "%Office:")
                .Add("PercentRetail", "%Retail:")
                .Add("PercentOther", "%Other:")
                .Add("BriefDescriptionOfOperationsAndProductsManufactured", "BriefDescriptionofOperationsProductsManufactured")
                .Add("OccupancyHazardClassification", "OccupancyHazardClassification")
                .Add("PredominantIndoorStorageType", "StorageType")
                .Add("CommodityType", "Commoditytype")
                .Add("MaxStgeHeight", "MaxStgeHeight.:")
                .Add("CommodityDescription", "Commoditydescription")
                .Add("SpecialHazardsDesription", "DescriptionSpecialHazards")
                .Add("OccupancyUser1", "OccupancyUser1")
                .Add("OccupancyUser2", "OccupancyUser2")
                .Add("OccupancyUser3", "OccupancyUser3")
                .Add("OccupancyUser4", "OccupancyUser4")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-FireProtection)
    Overridable ReadOnly Property FireCopeProtectionMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("AreaWithAdequateSprinklers", "AreasAdequateorTolerableAS")
                .Add("AreaWithInadequateSprinkler", "AreaswithinadequateAS")
                .Add("AreaWithoutSprinklersNeedingSprinklers", "Areasw/oASneedingAS")
                .Add("AreaWithoutSprinklersNotNeedingSprinklers", "Areasadequatew/oAS")
                .Add("SprinklerProtectionCapability", "SprinklerProtectionCapability:")
                .Add("SprinklerProtectionCapabilityDescriptionField", "SprinklerProtectionCapability-DescriptionField")
                .Add("PublicWaterSupplyType", "PublicSupplyType")
                .Add("PrivateWaterSupplyType", "PrivateSupplyType")
                .Add("WaterSupplyDuration", "WaterSupplyDuration:")
                .Add("WaterSupplyRating", "WaterSupplyRating")
                .Add("WaterSupplyComments", "WaterSupplyComments")
                .Add("SpecialHazardsRating", "SpecialHazardsRating")
                .Add("SpecialHazardsComments", "SpecialHazardsComments")
                .Add("FireHydrantCoverage", "FireHydrantCoverage:")
                .Add("SpecialProtectionSystems", "SpecialProtectionSystems:")
                .Add("SpecialProtectionSystemDescription", "SpeciaProtectionSystemsDescription")
                .Add("FireExtinguishers", "FireExtinguishers:")
                .Add("SmallHoseStations", "SmallHoseStations:")
                .Add("SprinklerValvesLocked", "SprinklerValvesLocked")
                .Add("SprinklerValveTamperSwitches", "TamperSwitches")
                .Add("SprinklerWaterFlow", "SprinklerWaterFlow")
                .Add("FirePumpCondition", "FirePumpCondition")
                .Add("SmokeHeatDetection", "Smoke/HeatDetection")
                .Add("IntrusionDetection", "IntrusionDetection")
                .Add("Other", "Other")
                .Add("AlarmsDescription", "OtherAlarmDescription")
                .Add("AlarmMonitoring", "AlarmMonitoring:")
                .Add("WatchService", "WatchService:")
                .Add("PropertySurveillance", "SurveillanceRating")
                .Add("SprinklerValves", "SprinklerValves")
                .Add("FirePumps", "FirePumps")
                .Add("InfraredScans", "InfraredScans")
                .Add("SmokingControls", "SmokingControls")
                .Add("Alarms", "Alarms")
                .Add("FireDoors", "FireDoors")
                .Add("Extinguishers", "Extinguishers")
                .Add("HotWorkMonitoring", "HotWorkMonitoring")
                .Add("ImpairmentHandling", "ImpairmentHandling")
                .Add("CombustionSafetyControls", "CombustionSafetyControls")
                .Add("GeneralMaintenance", "GeneralMaintenance")
                .Add("ContractorSupv", "ControlContractors")
                .Add("ManagementOfChange", "ManagementofChange")
                .Add("EOType", "PEOType")
                .Add("EOTraining", "PEOTraining")
                .Add("EmergResponseBCP", "Emerg/RecoveryPlanning")
                .Add("PublicFireDepartmentType", "PublicFireDepartmentType:")
                .Add("ISOCommunityRating", "ISOCommunityRating")
                .Add("DistanceToNearestStation", "Distancetofirestation")
                .Add("Housekeeping", "Housekeeping")
                .Add("ProtectionUser1", "ProtectionUser1")
                .Add("ProtectionUser2", "ProtectionUser2")
                .Add("ProtectionUser3", "ProtectionUser3")
                .Add("ProtectionUser4", "ProtectionUser4")
                .Add("LastIRInspDate", "LastIRInspDate")
                .Add("IRInspOrg", "IRInspOrg")
                .Add("IRInspComments", "IRInspComments")

                If _Util._XLInfo.TemplateVersion >= 5.5 Then
                    .Add("LastArcFlashInspDate", "LastAFInspDate")
                    .Add("LastArcFlashInspOrg", "AFInspOrg")
                    .Add("LastArcFlashComments", "AFInspComments")
                End If

                If _Util._XLInfo.TemplateVersion >= 5.7 Then
                    .Add("LastPSMStudyDate", "LastPSMDate")
                    .Add("LastPSMStudyOrg", "PSMOrg")
                    .Add("LastPSMStudyComments", "PSMComments")
                End If

                If _Util._XLInfo.TemplateVersion >= 5.8 Then
                    .Add("LastDustHazInspDate", "LastDustDate")
                    .Add("LastDustHazInspOrg", "DHAOrg")
                    .Add("LastDustHazInspComments", "DHAComments")
                    .Add("LastProcHazInspDate", "LastPHADate")
                    .Add("LastProcHazInspOrg", "PHAOrg")
                    .Add("LastProcHazInspComments", "PHAComments")
                End If

                If _Util._XLInfo.TemplateVersion >= 5.8174 Then
                    .Add("LastIsoDate", "LastISODate")
                    .Add("LastIsoOrg", "ISOOrg")
                    .Add("LastIsoComments", "ISOComments")
                End If

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-FireExposure)
    Overridable ReadOnly Property FireCopeExposureMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ExternalFire", "ExternalFire")
                .Add("ExternalFireProtectionField", "ExternalFire-ProtectionField")
                .Add("ExternalFireDescriptionField", "ExternalFire-DescriptionField")
                .Add("Flood", "Flood")
                .Add("FloodProtectionField", "Flood-ProtectionField")
                .Add("Zone", "FloodZone")
                .Add("InundationDepth", "InundationDepth")
                .Add("Seismic", "Seismic")
                .Add("SeismicProtectionField", "Seismic-ProtectionField")
                .Add("FMSeismicZone", "FMZone")
                .Add("PeakGroundAcceleration2PercentIn50Years", "PeakGroundAcceleration(2%in50years):")
                .Add("Windstorm", "Windstorm")
                .Add("WindstormProtectionField", "Windstorm-ProtectionField")
                .Add("MaxSustainedWindSpeed", "MaxSustainedWindSpeed:")
                .Add("OtherExternal", "Other")
                .Add("OtherProtectionField", "Other-ProtectionField")
                .Add("OtherProtectionDescriptionField", "OtherProtection-DescriptionField")
                .Add("ModifiedMercalliIndex", "MMI")
                .Add("ExposureComments", "Exposurecomments")
                .Add("ExposureUser1", "ExposureUser1")
                .Add("ExposureUser2", "ExposureUser2")
                .Add("ExposureUser3", "ExposureUser3")
                .Add("ExposureUser4", "ExposureUser4")
            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Fire-Recommendations)
    Overridable ReadOnly Property FireRecommendationMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("StatusDate", "Date")
                .Add("FileNo", "FileNo")
                .Add("RecYear", "Year")
                .Add("RecMonth", "Month")
                .Add("RecNumber", "No")
                .Add("RecSubletter", "Letter")
                .Add("RecCategory", "Impact")
                .Add("Hazard", "Hazard")
                .Add("PrimaryRecType", "Primary")
                .Add("SecondaryRecType", "Secondary")
                .Add("RecKeyWords", "Recommendation Key Words")
                .Add("LossExpectancyBefore", "Current Loss Estimate ($US)")
                .Add("LossExpectancyAfter", "Completed Loss Estimated ($US)")
                .Add("CostToComplete", "Est. Cost to Complete ($US)")
                .Add("SavingsRatio", "Savings Ratio")
                .Add("IntendedAction", "Intended Action")
                .Add("ExpectedCompletionDate", "Expected Completion Date")
                .Add("RecStatus", "Recommendation Tracking Status")
                .Add("CostToCompleteActual", "Actual Cost to Complete")
                .Add("RecDetail", "Recommendation Details")

                If _Util._XLInfo.TemplateVersion >= 6.0 Then
                    .Add("RecPriority", "Rec Priority")
                    .Add("RatingCat", "Category")
                    .Add("RatingCatWeight", "Category Weight")
                    .Add("RatingCatPts", "Category Points")
                    .Add("RatingScoreChange", "Score Change")
                    .Add("RatingPPPts", "PP Category Points")
                    .Add("RatingHEPts", "HE Category Points")
                    .Add("RatingNHPts", "Nat Haz Category Points")
                    .Add("RatingBCPPts", "BCP Category Points")
                End If

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Rating)
    Overridable ReadOnly Property FireRatingMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("FloodRating", "Flood")
                .Add("EarthquakeRating", "Earthquake")
                .Add("WindstormRating", "Windstorm")
                .Add("ConstructionRating", "Construction")
                .Add("OccupancyRating", "Occupancy")
                .Add("OtherRating", "Other")
                .Add("PassiveScore", "Passive")
                .Add("PhysicalProtectionRating", "FireProtection")
                .Add("HumanElementRating", "HE")
                .Add("NaturalHazardsProtectionRating", "NatHaz")
                .Add("BusinessContinuityRating", "BCP")
                .Add("ActiveScore", "Active")
                .Add("FireProtectionAllRecsCompleteRating", "FireProtection/wRec")
                .Add("HumanElementAllRecsCompleteRating", "He/wRec")
                .Add("NatHazProtAllRecsCompleteRating", "NatHaz/wRec")
                .Add("BCPAllRecsCompletRating", "BCP/wRec")
                .Add("ActiveScoreWithRecsComplete", "Active/wRec")
                .Add("APLWithAllRecsComplete", "APL")
                .Add("FloodWeight", "Flood Weights")
                .Add("EarthquakeWeight", "Earthquake Weights")
                .Add("WindstormWeight", "Windstorm Weights")
                .Add("ConstructionWeight", "Construction Weights")
                .Add("OccupancyWeight", "Occupancy Weights")
                .Add("OtherWeight", "Other Weights")
                .Add("PhysicalProtectionWeight", "FireProtection Weights")
                .Add("HumanElementWeight", "HE Weights")
                .Add("NaturalHazardsProtectionWeight", "NatHaz Weights")
                .Add("BusinessContinuityWeight", "BCP Weights")
                '.Add("Desc#1", "Desc.1")
                '.Add("Desc#2", "Desc.2")
                '.Add("Desc#3", "Desc.3")
                '.Add("TopBreak", "TopBreak")
                '.Add("BottomBreak", "BottomBreak")
                '.Add("Value1", "Value1")
                '.Add("Value2", "Value2")
                '.Add("Value3", "Value3")
                '.Add("Weight1", "Weight1")
                '.Add("Weight2", "Weight2")
                '.Add("Weight3", "Weight3")
                '.Add("Weight4", "Weight4")
                .Add("TotalScore", "TotalScore")
                .Add("OverallPlantRatingRating", "OverallRating")
                .Add("OverallScoreWithRecsComplete", "RecsCompleteScore")
                .Add("MaxPossibleScore", "MaxPossible")
                .Add("APL", "APL1")
                .Add("APLFactor", "APLFactor")
                .Add("APLFactorWithAllRecsComplete", "APLFactorw/RecsComplete")
                .Add("FileNo", "FileNo.")
                .Add("InspectionDate", "Date")
                .Add("FloodDescription", "FloodDes")
                .Add("EarthquakeDescription", "EarthquakeDes")
                .Add("WindstormDescription", "WindstormDes")
                .Add("ConstructionDescription", "ConstructionDes")
                .Add("OccupancyDescription", "OccupancyDec")
                .Add("OtherDescription", "OtherDes")
                .Add("FireDescription", "FireDes")
                .Add("HumanDescription", "HEDesc")
                .Add("NaturalDescription", "NatHazDes")
                .Add("BusinessDescription", "BusConDes")
                .Add("FireRecDescription", "FireRecsCompDes")
                .Add("HumanRecDescription", "HERecsCompDesc")
                .Add("NaturalRecDescription", "NatHazRecsCompDes")
                .Add("BusinessRecDescription", "BusConRecsCompDes")
                .Add("ExchangeRate", "ExchangeRate")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-NatHazModeling)
    Overridable ReadOnly Property FireNatHazModelingMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("Locnum", "LOCNUM")
                .Add("Locname", "LOCNAME")
                .Add("Primarybldg", "PRIMARYBLDG")
                .Add("Sitename", "SITENAME")
                .Add("Usergeo1", "USERGEO1")
                .Add("Addressnum", "ADDRESSNUM")
                .Add("Streetname", "STREETNAME")
                .Add("City", "CITY")
                .Add("County", "COUNTY")
                .Add("State", "STATE")
                .Add("Statecode", "STATECODE")
                .Add("Postalcode", "POSTALCODE")
                .Add("Cntrycode", "CNTRYCODE")
                .Add("Cntryscheme", "CNTRYSCHEME")
                .Add("Longitude", "LONGITUDE")
                .Add("Latitude", "LATITUDE")
                .Add("Userid1", "USERID1")
                .Add("Userid2", "USERID2")
                .Add("EqwsCv1val", "EQ/WS CV1VAL")
                .Add("EqwsCv2val", "EQ/WSCV2VAL")
                .Add("EqwsCv2cvm", "EQ/WSCV2CVM")
                .Add("EqwsCv9val", "EQ/WSCV9VAL")
                .Add("EqwsCv9cvm", "EQ/WSCV9CVM")
                .Add("EqwsCv3val", "EQ/WS CV3VAL")
                .Add("Bipreparedness", "BIPREPAREDNESS")
                .Add("Biredundancy", "BIREDUNDANCY")
                .Add("Numbldgs", "NUMBLDGS")
                .Add("Numstories", "NUMSTORIES")
                .Add("Bldgheight", "BLDGHEIGHT")
                .Add("Heightunit", "HEIGHTUNIT")
                .Add("Flooroccupancy", "FLOOROCCUPANCY")
                .Add("Bldgclass", "BLDGCLASS")
                .Add("Bldgscheme", "BSDGSCHEME")
                .Add("Occtype", "OCCTYPE")
                .Add("Occscheme", "OCCSCHEME")
                .Add("Yearbuilt", "YEARBUILT")
                .Add("Yearupgrad", "YEARUPGRAD")
                .Add("Pcntcomplt", "PCNTCOMPLT")
                .Add("Conqual", "CONQUAL")
                .Add("Shapeconf", "SHAPECONF")
                .Add("Storyprof", "STORYPROF")
                .Add("Overprof", "OVERPROF")
                .Add("Cladding", "CLADDING")
                .Add("Shortcol", "SHORTCOL")
                .Add("Ornament", "ORNAMENT")
                .Add("Mechelec", "MECHELEC")
                .Add("Duress", "DURESS")
                .Add("Pounding", "POUNDING")
                .Add("Engfound", "ENGFOUND")
                .Add("Baseisol", "BASEISOL")
                .Add("Framebolt", "FRAMEBOLT")
                .Add("Tiltupret", "TILTUPRET")
                .Add("Urmprov", "URMPROV")
                .Add("Structup", "STRUCTUP")
                .Add("Masintpart", "MASINTPART")
                .Add("Eqslins", "EQSLINS")
                .Add("Eqslsusceptibility", "EQSLSUSCEPTIBILITY")
                .Add("Spklrtype", "SPKLRTYPE")
                .Add("Eqcv2pctsp", "EQCV2PCTSP")
                .Add("Eqcv9pctsp", "EQCV9PCTSP")
                .Add("Constquali", "CONSTQUALI")
                .Add("Roofsys", "ROOFSYS")
                .Add("Roofgeom", "ROOFGEOM")
                .Add("Roofanch", "ROOFANCH")
                .Add("Roofage", "ROOFAGE")
                .Add("Roofequip", "ROOFEQUIP")
                .Add("Extorn", "EXTORN")
                .Add("Cladsys", "CLADSYS")
                .Add("Cladrate", "CLADRATE")
                .Add("Foundsys", "FOUNDSYS")
                .Add("Mechground", "MECHGROUND")
                .Add("Resistopen", "RESISTOPEN")
                .Add("Architect", "ARCHITECT")
                .Add("Flashing", "FLASHING")
                .Add("Basement", "BASEMENT")
                .Add("Buildingelevation", "BUILDINGELEVATION")
                .Add("Buildingelevationmatch", "BUILDINGELEVATIONMATCH")
                .Add("Flooddefenseelevation", "FLOODDEFENSEELEVATION")
                .Add("Flooddefenseelevationunit", "FLOODDEFENSEELEVATIONUNIT")
                .Add("Numstoriesbg", "NUMSTORIESBG")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Fire-Retail)
    Overridable ReadOnly Property FireRetailMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Summary", "Summary")
                .Add("TypeStore", "TypeStore")
                .Add("MilesToCoast", "MilesToCoast")
                .Add("RespTime", "RespTime")
                .Add("HydrantDistance", "HydrantDistance")
                .Add("FootprintBldg", "FootprintBldg")
                .Add("RackStorArea", "RackStorArea")
                .Add("BackroomStorArea", "BackroomStorArea")
                .Add("BackroomStorHgt", "BackroomStorHgt")
                .Add("SalesFlStorArea", "SalesFlStorArea")
                .Add("SalesFlStorHgt", "SalesFlStorHgt")
                .Add("AverSlAreaProdHgt", "AverSlAreaProdHgt")
                .Add("MaxSlAreaProdHgt", "MaxSlAreaProdHgt")
                .Add("CeilASSP", "%CeilASSP")
                .Add("CeilASSN", "%CeilASSN")
                .Add("RackAASP", "%RackAASP")
                .Add("RackAASN", "%RackAASN")
                .Add("FireDetProv", "FireDetProv")
                .Add("FireDetNeed", "FireDetNeed")
                .Add("LevelsRAS", "LevelsRAS")
                .Add("WaterFlowMonYesNo", "WaterFlowMonYesNo")
                .Add("WaterFlowMonByWhom", "WaterFlowMonByWhom")
                .Add("ValveTamMonYesNo", "ValveTamMonYesNo")
                .Add("ValveTamMonByWhom", "ValveTamMonByWhom")
                .Add("NoOfValves", "NoOfValves")
                .Add("NoOfValvesC", "NoOfValvesC")
                .Add("AllValvesOpen", "AllValvesOpen")
                .Add("AllValvesOpenC", "AllValvesOpenC")
                .Add("ValvesLocked", "ValvesLocked")
                .Add("ValvesLockedC", "ValvesLockedC")
                .Add("ValvesLabeled", "ValvesLabeled")
                .Add("ValvesLabeledC", "ValvesLabeledC")
                .Add("ValvesInspMonthly", "ValvesInspMonthly")
                .Add("ValvesInspMonthlyC", "ValvesInspMonthlyC")
                .Add("SSHeadBoxMonthly", "SSHeadBoxMonthly")
                .Add("SSHeadBoxMonthlyC", "SSHeadBoxMonthlyC")
                .Add("SSHeadsAvail", "SSHeadsAvail")
                .Add("SSHeadsAvailC", "SSHeadsAvailC")
                .Add("SSHeadWrenchInBox", "SSHeadWrenchInBox")
                .Add("SSHeadWrenchInBoxC", "SSHeadWrenchInBoxC")
                .Add("CorrectHeadsProvided", "CorrectHeadsProvided")
                .Add("CorrectHeadsProvidedC", "CorrectHeadsProvidedC")
                .Add("ImpProcObserved", "ImpProcObserved")
                .Add("ImpProcObservedC", "ImpProcObservedC")
                .Add("ATV2inDrain", "ATV2inDrain")
                .Add("ATV2inDrainC", "ATV2inDrainC")
                .Add("ATVDryPipeValve", "ATVDryPipeValve")
                .Add("ATVDryPipeValveC", "ATVDryPipeValveC")
                .Add("ATVFirePump", "ATVFirePump")
                .Add("ATVFirePumpC", "ATVFirePumpC")
                .Add("ATVAntifreeze", "ATVAntifreeze")
                .Add("ATVAntifreezeC", "ATVAntifreezeC")
                .Add("NoMissingCapsFDC", "NoMissingCapsFDC")
                .Add("NoMissingCapsFDCC", "NoMissingCapsFDCC")
                .Add("ATVValveTamper", "ATVValveTamper")
                .Add("ATVValveTamperC", "ATVValveTamperC")
                .Add("ATVWaterFlow", "ATVWaterFlow")
                .Add("ATVWaterFlowC", "ATVWaterFlowC")
                .Add("ATVDrySysLowAir", "ATVDrySysLowAir")
                .Add("ATVDrySysLowAirC", "ATVDrySysLowAirC")
                .Add("FireSupSysOver", "FireSupSysOver")
                .Add("FireSupSysOverC", "FireSupSysOverC")
                .Add("BlowOffCaps", "BlowOffCaps")
                .Add("BlowOffCapsC", "BlowOffCapsC")
                .Add("ManualRelease", "ManualRelease")
                .Add("ManualReleaseC", "ManualReleaseC")
                .Add("Min18Clearance", "Min18Clearance")
                .Add("Min18ClearanceC", "Min18ClearanceC")
                .Add("FireAlarmZonePosted", "FireAlarmZonePosted")
                .Add("FireAlarmZonePostedC", "FireAlarmZonePostedC")
                .Add("PFEInspMonthly", "PFEInspMonthly")
                .Add("PFEInspMonthlyC", "PFEInspMonthlyC")
                .Add("PFEServAnn", "PFEServAnn")
                .Add("PFEServAnnC", "PFEServAnnC")
                .Add("PFEAppTypeSize", "PFEAppTypeSize")
                .Add("PFEAppTypeSizeC", "PFEAppTypeSizeC")
                .Add("PFEMounted", "PFEMounted")
                .Add("PFEMountedC", "PFEMountedC")
                .Add("FireHosesInsp", "FireHosesInsp")
                .Add("FireHosesInspC", "FireHosesInspC")
                .Add("ExhaustHoodsDuct", "ExhaustHoodsDuct")
                .Add("ExhaustHoodsDuctC", "ExhaustHoodsDuctC")
                .Add("FiltersForCooking", "FiltersForCooking")
                .Add("FiltersForCookingC", "FiltersForCookingC")
                .Add("ELProvided", "ELProvided")
                .Add("ELProvidedC", "ELProvidedC")
                .Add("BatOpEmerExit", "BatOpEmerExit")
                .Add("BatOpEmerExitC", "BatOpEmerExitC")
                .Add("EmergGenOptMonthly", "EmergGenOptMonthly")
                .Add("EmergGenOptMonthlyC", "EmergGenOptMonthlyC")
                .Add("GenSecPreUnauth", "GenSecPreUnauth")
                .Add("GenSecPreUnauthC", "GenSecPreUnauthC")
                .Add("ExitSignsProvIll", "ExitSignsProvIll")
                .Add("ExitSignsProvIllC", "ExitSignsProvIllC")
                .Add("ExitDoorsUnobstr", "ExitDoorsUnobstr")
                .Add("ExitDoorsUnobstrC", "ExitDoorsUnobstrC")
                .Add("NatGasFryer", "NatGasFryer")
                .Add("NatGasFryerC", "NatGasFryerC")
                .Add("SeismicGasShutoff", "SeismicGasShutoff")
                .Add("SeismicGasShutoffC", "SeismicGasShutoffC")
                .Add("StorRacksBolted", "StorRacksBolted")
                .Add("StorRacksBoltedC", "StorRacksBoltedC")
                .Add("HotWorkPermit", "HotWorkPermit")
                .Add("HotWorkPermitC", "HotWorkPermitC")
                .Add("FlamLiqStored", "FlamLiqStored")
                .Add("FlamLiqStoredC", "FlamLiqStoredC")
                .Add("_16Separation", "16Separation")
                .Add("_16SeparationC", "16SeparationC")
                .Add("PropCylinders", "PropCylinders")
                .Add("PropCylindersC", "NoPropCylindersC")
                .Add("PropStorage", "PropStorage")
                .Add("PropStorageC", "PropStorageC")
                .Add("NoSmoking", "NoSmoking")
                .Add("NoSmokingC", "NoSmokingC")
                .Add("FireDoorsNotObstr", "FireDoorsNotObstr")
                .Add("FireDoorsNotObstrC", "FireDoorsNotObstrC")
                .Add("NoMissCealTiles", "NoMissCealTiles")
                .Add("NoMissCealTilesC", "NoMissCealTilesC")
                .Add("BarricadeProvided", "BarricadeProvided")
                .Add("BarricadeProvidedC", "BarricadeProvidedC")
                .Add("NoStorageInElecRm", "NoStorageInElecRm")
                .Add("NoStorageInElecRmC", "NoStorageInElecRmC")
                .Add("PlasSkids", "PlasSkids")
                .Add("PlasSkidsC", "PlasSkidsC")
                .Add("ElectExtCords", "ElectExtCords")
                .Add("ElectExtCordsC", "ElectExtCordsC")
                .Add("ElectEquipFreeDam", "ElectEquipFreeDam")
                .Add("ElectEquipFreeDamC", "ElectEquipFreeDamC")
                .Add("_36Clearance", "36Clearance")
                .Add("_36ClearanceC", "36ClearanceC")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Wind-General)
    Overridable ReadOnly Property FireNatHazWindGeneralMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Units", "Units")
                .Add("Area", "Area")
                .Add("Stories", "Stories")
                .Add("NoBasementLevels", "NoBasementLevels")
                .Add("BldgHgt", "BldgHgt")
                .Add("Windspeed", "Windspeed")
                .Add("FloodZone", "FloodZone")
                .Add("SurfaceRoughnessCo", "SurfaceRoughnessCo")
                .Add("SurfRoughDesc", "SurfRoughDesc")
                .Add("Latitude", "Latitude")
                .Add("Longitude", "Longitude")
                .Add("DistanceToCoast", "DistancetoCoast")
                .Add("SiteGradeElevation", "SiteGradeElevation")
                .Add("StormSurge", "StormSurge")
                .Add("Summary", "Summary")
                .Add("PriorLossHistory", "PriorLossHistory")
                .Add("PLHComments", "PLHComments")
                .Add("WindStructRiskEval", "WindStructRiskEval")
                .Add("WindStructRiskEvalComments", "WindStructRiskEvalComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Wind-BuildingEnvelope)
    Overridable ReadOnly Property FireNatHazWindBuildingEnvelopeMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("DrainageRating", "DrainageRating")
                .Add("DrainageComments", "DrainageComments")
                .Add("FasteningRating", "FasteningRating")
                .Add("FasteningComments", "FasteningComments")
                .Add("FlashingRating", "FlashingRating")
                .Add("FlashingComments", "FlashingComments")
                .Add("CoveringRating", "CoveringRating")
                .Add("CoveringComments", "CoveringComments")
                .Add("GlassRating", "GlassRating")
                .Add("GlassComments", "GlassComments")
                .Add("WallSurfaceRating", "WallSurfaceRating")
                .Add("WallSurfaceComments", "WallSurfaceComments")
                .Add("DoorResistanceRating", "DoorResistanceRating")
                .Add("DoorResistanceComments", "DoorResistanceComments")
                .Add("OtherOpeningsLouversRating", "OtherOpeningsLouversRating")
                .Add("OtherOpeningsLouversComments", "OtherOpeningsLouversComments")
                .Add("ParapetOtherRoofRating", "ParapetOtherRoofRating")
                .Add("ParapetOtherRoofComments", "ParapetOtherRoofComments")
                .Add("SkylightAtriaRating", "SkylightAtriaRating")
                .Add("SkylightAtriaComments", "SkylightAtriaComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Wind-Utilities)
    Overridable ReadOnly Property FireNatHazWindUtilityMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("WaterRating", "WaterRating")
                .Add("WaterComments", "WaterComments")
                .Add("ElectricRating", "ElectricRating")
                .Add("ElectricComments", "ElectricComments")
                .Add("FuelsRating", "FuelsRating")
                .Add("FuelsComments", "FuelsComments")
                .Add("BoilersRating", "BoilersRating")
                .Add("BoilersComments", "BoilersComments")
                .Add("TelephoneDataRating", "TelephoneDataRating")
                .Add("TelephoneDataComments", "TelephoneDataComments")
                .Add("HVACCoolingTowersRating", "HVACCoolingTowersRating")
                .Add("HVACCoolingTowersComments", "HVACCoolingTowersComments")
                .Add("OtherRating", "OtherRating")
                .Add("OtherComments", "OtherComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Wind-MiscellaneousOther)
    Overridable ReadOnly Property FireNatHazWindOtherMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("ProjProtRating", "ProjProtRating")
                .Add("ProjProtComments", "ProjProtComments")
                .Add("OESRGRating", "OES-RGRating")
                .Add("OESRGComments", "OES-RGComments")
                .Add("SARating", "SARating")
                .Add("SAComments", "SAComments")
                .Add("TreesRating", "TreesRating")
                .Add("TreesComments", "TreesComments")
                .Add("CLCRating", "CLCRating")
                .Add("CLCComments", "CLCComments")
                .Add("PBRating", "PBRating")
                .Add("PBComments", "PBComments")
                .Add("EmergRespSuppliesRating", "EmergRespSuppliesRating")
                .Add("EmergRespSuppliesComments", "EmergRespSuppliesComments")
                .Add("OtherMiscExpRating", "OtherMiscExpRating")
                .Add("OtherMiscExpComments", "OtherMiscExpComments")
                .Add("CVBEGRating", "CVBEGRating")
                .Add("CVBEGComments", "CVBEGComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Seismic-General)
    Overridable ReadOnly Property FireNatHazSeismicGeneralMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Ssummary", "Ssummary")
                .Add("Slosses", "Slosses")
                .Add("SLossDesc", "SLossDesc")
                .Add("Pga", "PGA")
                .Add("FMSeismic", "FMSeismic")
                .Add("Mmi", "MMI")
                .Add("Liquefaction", "Liquefaction")
                .Add("SteepSlopes", "SteepSlopes")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Seismic-Structural)
    Overridable ReadOnly Property FireNatHazSeismicStructuralMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("WoodFrame", "WoodFrame")
                .Add("Urm", "URM")
                .Add("ReinfMas", "ReinfMas")
                .Add("RMwRC", "RMwRC")
                .Add("Rc", "RC")
                .Add("RCSheer", "RCSheer")
                .Add("PreCast", "PreCast")
                .Add("Tiltup", "Tiltup")
                .Add("LtMetal", "LtMetal")
                .Add("StFr", "StFr")
                .Add("BrStFr", "BrStFr")
                .Add("Unk", "Unk")
                .Add("UnkDesc", "UnkDesc")
                .Add("ConstComments", "ConstComments")
                .Add("Irreg", "Irreg")
                .Add("Pounding", "Pounding")
                .Add("SoftStory", "SoftStory")
                .Add("SeismicStructRiskEval", "SeismicStructRiskEval")
                .Add("SeismicStructRiskEvalComments", "SeismicStructRiskEvalComments")
                .Add("BldgCondition", "BldgCondition")
                .Add("BldgConditionComments", "BldgConditionComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Seismic-StructuralData)
    Overridable ReadOnly Property FireNatHazSeismicStructuralDataMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Code", "Code")
                .Add("Year", "Year")
                .Add("Benchmark", "Benchmark")
                .Add("PercentofFloorArea", "PercentofFloorArea")
                .Add("Reoccupancy", "Reoccupancy")
                .Add("OtherCodeDescription", "OtherCodeDescription")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Seismic-Nonstructural)
    Overridable ReadOnly Property FireNatHazSeismicNonStructuralMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Ssov", "SSOV")
                .Add("SSOVComments", "SSOVComments")
                .Add("FPGen", "FPGen")
                .Add("FPGenComments", "FPGenComments")
                .Add("HazMat", "HazMat")
                .Add("HazMatComments", "HazMatComments")
                .Add("UGUtil", "UGUtil")
                .Add("UGUtilComments", "UGUtilComments")
                .Add("Xform", "Xform")
                .Add("XformComments", "XformComments")
                .Add("Switchgear", "Switchgear")
                .Add("SwitchgearComments", "SwitchgearComments")
                .Add("ITTele", "ITTele")
                .Add("ITTeleComments", "ITTeleComments")
                .Add("SSBrace", "SSBrace")
                .Add("SSBraceComments", "SSBraceComments")
                .Add("PipeCable", "PipeCable")
                .Add("PipeCableComments", "PipeCableComments")
                .Add("Hvacct", "HVACCT")
                .Add("HVACCTComments", "HVACCTComments")
                .Add("Storage", "Storage")
                .Add("StorageComments", "StorageComments")
                .Add("Process", "Process")
                .Add("ProcessComments", "ProcessComments")
                .Add("EmerRespRecoveryRating", "EmerRespRecoveryRating")
                .Add("EmerRespRecoveryComments", "EmerRespRecoveryComments")
                .Add("SNSOther", "SNSOther")
                .Add("SNSOtherComments", "SNSOtherComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Flood-General)
    Overridable ReadOnly Property FireNatHazFloodGeneralMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Fsummary", "Fsummary")
                .Add("Flosses", "Flosses")
                .Add("FLossDesc", "FLossDesc")
                .Add("FloodZone", "FloodZone")
                .Add("FZoneDesc", "FZoneDesc")
                .Add("SiteGradeElevation", "SiteGradeElevation")
                .Add("_1stFloorWaterEntryElev", "1stFloorWaterEntryElev")
                .Add("BelowGradeDepth", "BelowGradeDepth")
                .Add("_100YrFloodElev", "100YrFloodElev")
                .Add("_500YrFloodElev", "500YrFloodElev")
                .Add("_100YrDepth", "100YrDepth")
                .Add("_500YrDepth", "500YrDepth")
                .Add("DistancetoCoast", "DistancetoCoast")
                .Add("StormSurge", "StormSurge")
                .Add("StructRec", "StructRec")
                .Add("StructRecComments", "StructRecComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Flood-ExposureDetails)
    Overridable ReadOnly Property FireNatHazFloodExposureMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("_100YrFlood", "100YrFlood")
                .Add("_100YrComments", "100YrComments")
                .Add("_500YrFlood", "500YrFlood")
                .Add("_500YrComments", "500YrComments")
                .Add("StormSurge", "StormSurge")
                .Add("StormSurgeComments", "StormSurgeComments")
                .Add("SurfWater", "SurfWater")
                .Add("SurfWaterComments", "SurfWaterComments")
                .Add("FixedProtection", "FixedProtection")
                .Add("FixedProtComments", "FixedProtComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Flood-BldgStructureDetails)
    Overridable ReadOnly Property FireNatHazFloodBldgStructureMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("Aebg", "AEBG")
                .Add("AEBGComments", "AEBGComments")
                .Add("ContConst", "ContConst")
                .Add("ContContComments", "ContContComments")
                .Add("OtherBldgStruc", "OtherBldgStruc")
                .Add("OtherBSComments", "OtherBSComments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: NatHaz-Flood-OtherDetails)
    Overridable ReadOnly Property FireNatHazFloodOtherMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("SurveyDate", "SurveyDate")
                .Add("PrepRespPlan", "PrepRespPlan")
                .Add("PrepRespPlanComments", "PrepRespPlanComments")
                .Add("SiteAccess", "SiteAccess")
                .Add("SAccessComments", "SAccessComments")
                .Add("Utilities", "Utilities")
                .Add("UtilitiesComments", "UtilitiesComments")
                .Add("YardStge", "YardStge")
                .Add("YardStgeComments", "YardStgeComments")
                .Add("OtherFloodExp", "OtherFloodExp")
                .Add("OtherFloodExpComments", "OtherFloodExpComments")

            End With
            Return zMap
        End Get
    End Property




#End Region


End Class

