
Public Class BmMeta
    Inherits Meta

    Private _Util As ImportUtility

    Public Sub New(pImportUtil As ImportUtility)
        _Util = pImportUtil
    End Sub

    Friend Overrides ReadOnly Property FileNoCellAddress As CellAddress
        Get
            Return New CellAddress("Facility Data", "M1")
        End Get
    End Property

    Friend Overrides ReadOnly Property Practice As Libraries.CoreLib.UtilPractice.PracticeEnum
        Get
            Return UtilPractice.PracticeEnum.BM
        End Get
    End Property

    Friend Overrides ReadOnly Property SurveyDateCellAddress As CellAddress
        Get
            Return New CellAddress("Facility Data", "L3")
        End Get
    End Property

    Friend Overrides ReadOnly Property TemplateVersionAddress As CellAddress
        Get
            Return New CellAddress("Facility Data", "O7")
        End Get
    End Property

    Overridable ReadOnly Property BmFacilityMainImportInfoImportInfo As BmImportInfo
        Get
            If _Util._XLInfo.TemplateVersion >= 5.5 Then
                Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmFacilityMain, {"T3:BB4"}, Me, BmFacilityMainMapCollection)
            Else
                Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmFacilityMain, {"T3:AY4"}, Me, BmFacilityMainMapCollection)
            End If
        End Get
    End Property

    Overridable ReadOnly Property BmOccupancyImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmOccupancy, {"T10:AL11"}, Me, BmOccupancyMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmMechanicalImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmMechanical, {"T17:BW18"}, Me, BmMechanicalMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmElectricalImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmElectrical, {"T24:AM25"}, Me, BmElectricalMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmElectricalTransformerImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmElectricalTransformers, {"T31:AA37"}, Me, BmElectricalTransformersMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmElectricalRotatingEquipmentImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmElectricalRotatingEquipment, {"T41:AB47"}, Me, BmElectricalRotatingEquipmentMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmBpvImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmBpv, {"T52:AD53"}, Me, BmBpvMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmBpvAImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmBpvA, {"T58:AC64"}, Me, BmBpvAMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmCpvImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmCpv, {"T74:V80"}, Me, BmCpvMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmPpeImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmPpe, {"T69:AA70"}, Me, BmPpeMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmPpeAImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmPpeA, {"T83:V89"}, Me, BmPpeAMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmComputerSystemsImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmComputerSystems, {"T95:AC96"}, Me, BmComputerSystemsMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmMppmImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmMppm, {"T103:AI104"}, Me, BmMppmMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmEppmsImportInfo As BmImportInfo
        Get
            If _Util._XLInfo.TemplateVersion >= 5.5 Then
                Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmEppms, {"T111:AU112"}, Me, BmEppmsMapCollection)
            Else
                Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmEppms, {"T111:AR112"}, Me, BmEppmsMapCollection)
            End If
        End Get
    End Property

    Overridable ReadOnly Property BmEppmsAImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmEppmsA, {"T117:V123"}, Me, BmEppmsAMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmHebcpImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmHebcp, {"T130:AO131"}, Me, BmHebcpMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmPrimeMoverImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmPrimeMovers, {"T137:AE143"}, Me, BmPrimeMoversMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmRecTrackingImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.BmRecommendation, {"O8:AG37"}, Me, BmRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmRecTracking2ImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.RecTracking, "Rec Tracking (2)", ImportEnum.ImportTable.BmRecommendation, {"O8:AG37"}, Me, BmRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmRecTracking3ImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.RecTracking, "Rec Tracking (3)", ImportEnum.ImportTable.BmRecommendation, {"O8:AG37"}, Me, BmRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmRecTracking4ImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.RecTracking, "Rec Tracking (4)", ImportEnum.ImportTable.BmRecommendation, {"O8:AG37"}, Me, BmRecommendationMapCollection)
        End Get
    End Property

    Overridable ReadOnly Property BmRatingImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.RatingForm, ImportEnum.ImportTable.BmRating, {"P3:CF4"}, Me, BmRatingMapCollection)
        End Get

    End Property


#Region "Map Collections"  '(Generated On: 9/7/2012)


    '--AutoGenerated (SQL Table: Cope-Boiler01/13-Main)
    Overridable ReadOnly Property BmFacilityMainMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                '.Add("","Client")
                '.Add("","Facility")
                '.Add("","City")
                '.Add("","St/Prov")
                '.Add("","Country")
                '.Add("","Latitude")
                '.Add("","Longitude")
                .Add("SurveyDate", "SurveyDate")
                .Add("Engineer", "Engineer")
                .Add("Currency", "Currency")
                .Add("BIReporting", "BI Reporting")
                .Add("ExchangeRate", "CurrencyConversionFactor")
                .Add("ReptPD", "ReptPD")
                .Add("ReptBI", "ReptBI")
                .Add("ReptTIV", "ReptTIV")
                .Add("Pmlpd", "PMLPD")
                .Add("PMLPDPercentage", "PMLPDPercentage")
                .Add("Pmlbi", "PMLBI")
                .Add("PMLBIPercentage", "PMLBIPercentage")
                .Add("PMLTotal", "PMLTotal")
                .Add("PMLTotalPercentage", "PMLPercentage")
                .Add("Mflpd", "MFLPD")
                .Add("MFLPDPercentage", "MFLPDPercentage")
                .Add("Mflbi", "MFLBI")
                .Add("MFLBIPercentage", "MFLBIPercentage")
                .Add("MFLTotal", "MFLTotal")
                .Add("MFLTotalPercentage", "MFLPercentage")
                .Add("Interdependencies", "Interdependencies")
                .Add("LEandInterdependecyComments", "InterdepComments")
                .Add("SignificantBMDamageLossesInPast3Years", "Losses")
                .Add("SignificantBMDescription", "LossesComments")

                If _Util._XLInfo.TemplateVersion >= 5.5 Then
                    .Add("MajorProjectsPlanned", "ProjectsPlanned")
                    .Add("MajorProjectsValueRange", "ProjectValue")
                    .Add("PropertyValuesReasonable", "PropValuesReasonable")
                End If

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler02-Occupancy)
    Overridable ReadOnly Property BmOccupancyMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("IndustryGroup", "Industry Group")
                .Add("MajorGroup", "Major Group")
                .Add("SpecificGroup", "Specific Group")
                .Add("SICCode", "SIC Code")
                .Add("HoursDay", "Hours/Day")
                .Add("DaysWeek", "Days/Week")
                .Add("NumberOfEmployees", "No.ofemployees")
                '.Add("PercentManufacturing", "%Manf")
                '.Add("PercentUtilities", "%Utility")
                '.Add("PercentWholesaleDistStge", "%Dist/Stge")
                '.Add("PercentOffice", "%Office")
                '.Add("PercentRetail", "%Retail")
                '.Add("PercentOther", "%Other")
                .Add("OpsDetails", "OpsDetails")
                .Add("OccupancyUser1", "OccupancyUser1")
                .Add("OccupancyUser2", "OccupancyUser2")
                .Add("OccupancyUser3", "OccupancyUser3")
                .Add("OccupancyUser4", "OccupancyUser4")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler03-Mechanical)
    Overridable ReadOnly Property BmMechanicalMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("CompMajorExp", "CompMajorExp")
                '.Add("CompAdeqCap", "CompAdeqCap")
                '.Add("CompNo", "CompNo")
                '.Add("CompRental", "CompRental")
                '.Add("CompSpares", "CompSpares")
                '.Add("CompProcess", "CompProcess")
                '.Add("CompInstruments", "CompInstruments")
                '.Add("CompGeneral", "CompGeneral")
                '.Add("CompOther", "CompOther")
                .Add("CompComments", "CompComments")
                .Add("RefrigMajorExp", "RefrigMajorExp")
                '.Add("RefrigAdeqCap", "RefrigAdeqCap")
                '.Add("RefrigProcess", "RefrigProcess")
                '.Add("RefrigComfort", "RefrigComfort")
                '.Add("RefrigSpares", "RefrigSpares")
                '.Add("RefrigRental", "RefrigRental")
                .Add("RefrigProcessType", "RefrigProcessType")
                .Add("RefrigComfortType", "RefrigComfortType")
                '.Add("RefrigProcessNo", "RefrigProcessNo")
                '.Add("RefrigComfortNo", "RefrigComfortNo")
                .Add("RefrigComments", "RefrigComments")
                .Add("WaterMajorExp", "WaterMajorExp")
                '.Add("WaterAdeqCap", "WaterAdeqCap")
                .Add("WaterPrimary", "WaterPrimary")
                .Add("WaterSecondary", "WaterSecondary")
                '.Add("WaterProcess", "WaterProcess")
                '.Add("WaterCooling", "WaterCooling")
                '.Add("WaterBoilers", "WaterBoilers")
                '.Add("WaterGeneral", "WaterGeneral")
                '.Add("WaterReserveCap", "WaterReserveCap")
                .Add("WaterComments", "WaterComments")
                .Add("CoolingMajorExp", "CoolMajorEx")
                '.Add("CoolingAdeqCap", "CoolAdeqCap")
                '.Add("CoolingProcess", "CoolProcess")
                '.Add("CoolingEquipment", "CoolEquip")
                .Add("CoolingNo", "CoolNo")
                .Add("CoolingPumps", "CoolPumps")
                .Add("CoolingReserve", "CoolReserve")
                .Add("CoolingComments", "CoolComments")
                .Add("FuelMajorExp", "FuelMajorExp")
                '.Add("FuelAdeqCap", "FuelAdeqCap")
                .Add("FuelPrimarySource", "FuelPrimarySource")
                .Add("FuelSecondarySource", "FuelSecSource")
                '.Add("FuelSupplierNo", "FuelSupplierNo")
                .Add("FuelInventory", "FuelInventory")
                '.Add("FuelProcess", "FuelProcess")
                '.Add("FuelBoilers", "FuelBoilers")
                '.Add("FuelOther", "FuelOther")
                .Add("FuelComments", "FuelComments")
                .Add("OtherMechanicalComments", "OtherComments")
                .Add("MechanicalUser1", "MechanicalUser1")
                .Add("MechanicalUser2", "MechanicalUser2")
                .Add("MechanicalUser3", "MechanicalUser3")
                .Add("MechanicalUser4", "MechanicalUser4")
                .Add("OtherMechanicalMajorExp", "OtherMechanicalMajorExp")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler04-Electrical)
    Overridable ReadOnly Property BmElectricalMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("NoUtilityLines", "NoUtilityLines")
                '.Add("SupplyVoltage", "SupplyVoltage")
                '.Add("PowerDemand", "PowerDemand")
                .Add("XformRegulating", "XformRegulating")
                .Add("XformArcFurnace", "XformArcFurnace")
                .Add("XformRectifying", "XformRectifying")
                .Add("XformPhaseShifting", "XformPhaseShifting")
                .Add("XformOther", "XformOther")
                .Add("XformSparePrimary", "XformSparePrimary")
                .Add("XformSpareDist", "XformSpareDist")
                .Add("XformRental", "XformRental")
                .Add("XformBreaker", "XformBreaker")
                .Add("XformPCB", "XformPCB")
                .Add("ElectComments", "ElectComments")
                .Add("ElectricalUser1", "ElectricalUser1")
                .Add("ElectricalUser2", "ElectricalUser2")
                .Add("ElectricalUser3", "ElectricalUser3")
                .Add("ElectricalUser4", "ElectricalUser4")
                .Add("ElectricalMajorExp", "ElectricalMajorExp")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler04a-ElectricalTransformers)
    Overridable ReadOnly Property BmElectricalTransformersMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("Manufacturer", "Manufacturer")
                .Add("Year", "Year")
                .Add("PrimSecVoltage", "Prim/Sec V")
                .Add("Kva", "KVA")
                .Add("Type", "Type")
                .Add("Comments", "Comments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler04b-ElectricalRotatingEquipment)
    Overridable ReadOnly Property BmElectricalRotatingEquipmentMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("Item", "Item")
                .Add("Type", "Type")
                .Add("GenDriver", "GenDriver")
                .Add("Manfacturer", "Manufacturer")
                .Add("Kvahp", "KVAHP")
                .Add("Voltage", "Voltage")
                .Add("Comments", "Comments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler05-BPV)
    Overridable ReadOnly Property BmBpvMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("BoilerNo", "BoilerNo")
                '.Add("BoilerNoBLRB", "BoilerNoBLRB")
                '.Add("BoilerNoUtility", "BoilerNoUtility")
                .Add("BoilerOther", "BoilerOther")
                .Add("BoilerComments", "BoilerComments")
                .Add("BoilersUser1", "BoilersUser1")
                .Add("BoilersUser2", "BoilersUser2")
                .Add("BoilersUser3", "BoilersUser3")
                .Add("BoilersUser4", "BoilersUser4")
                .Add("BoilerMajorExp", "BoilerMajorExp")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler05a-BPV)
    Overridable ReadOnly Property BmBpvAMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("Manufacturer", "Manufacturer")
                .Add("Type", "Type")
                .Add("Service", "Service")
                .Add("Capacity", "Capacity")
                .Add("Pressure", "Pressure")
                .Add("Fuel", "Fuel")
                .Add("RentalAvailable", "RentalAvail")
                .Add("Comments", "Comments")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler05b-CPV)
    Overridable ReadOnly Property BmCpvMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("PVDescription", "Description")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler06-PPE)
    Overridable ReadOnly Property BmPpeMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("CPVExposure", "PVCritical")
                .Add("PPEExposure", "ProcEquipExp")
                .Add("PressureVesselsUser1", "PressureVesselsUser1")
                .Add("PressureVesselsUser2", "PressureVesselsUser2")
                .Add("PressureVesselsUser3", "PressureVesselsUser3")
                .Add("PressureVesselsUser4", "PressureVesselsUser4")
                .Add("PrimeMoverExp", "PrimeMoverExp")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler06a-PPE)
    Overridable ReadOnly Property BmPpeAMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("PPEDescription", "Description")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler07-ComputerSystems)
    Overridable ReadOnly Property BmComputerSystemsMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                '.Add("ComputersInstalled", "ProcessComp")
                '.Add("CanPlantOperate", "Operatew/oComp")
                '.Add("UPSInstalled", "UPS")
                .Add("ComputerSystemsComments", "ComputerComments")
                .Add("ProcessEquipUser1", "ProcessEquipUser1")
                .Add("ProcessEquipUser2", "ProcessEquipUser2")
                .Add("ProcessEquipUser3", "ProcessEquipUser3")
                .Add("ProcessEquipUser4", "ProcessEquipUser4")
                .Add("CompSysMajorExp", "CompSysMajorExp")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler08-MPPM)
    Overridable ReadOnly Property BmMppmMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("MechPreMaintAdequacy", "MechPreMaintAdequate")
                '.Add("MechPreMaintCMMS", "MechPreMaintCMMS")
                .Add("MechPreMaintVibe", "MechPreMaintVibe")
                .Add("MechPreMaintLubeOil", "MechPreMaintLubeOil")
                .Add("MechPreMaintNDE", "MechPreMaintNDE")
                .Add("MechPreMaintOverspeed", "MechPreMaintOverspeed")
                .Add("MechPreMaintVisual", "MechPreMaintVisual")
                .Add("MechPreMaintAlign", "MechPreMaintAlign")
                .Add("MechPreMaintOther", "MechPreMaintOther")
                .Add("MechPreMaintOtherComments", "MechPreMaintOtherComments")
                .Add("MechPreMaintSpecComments", "MechPreMaintSpecComments")
                .Add("MechanicalMainUser1", "MechanicalMainUser1")
                .Add("MechanicalMainUser2", "MechanicalMainUser2")
                .Add("MechanicalMainUser3", "MechanicalMainUser3")
                .Add("MechanicalMainUser4", "MechanicalMainUser4")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler09/10-EPPMS)
    Overridable ReadOnly Property BmEppmsMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ElecPreMaintAdequate", "ElecPreMaintAdequate")
                '.Add("ElecPreMaintCMMS", "ElecPreMaintCMMS")
                .Add("ElectIR", "ElecIR")
                .Add("ElecUltrasound", "ElecUltraSound")
                '.Add("ElecNETA", "ElecNETA")
                .Add("ElecTranOil", "ElecTranOil")
                .Add("ElecMotor", "ElecMotor")
                '.Add("ElecIEEE", "ElecIEEE")
                .Add("ElecSwitch", "ElecSwitch")
                .Add("ElecOther", "ElecOther")
                '.Add("ElecGRC", "ElecGRC")
                .Add("ElecRelay", "ElecRelay")
                '.Add("ElecBestPractices", "ElecBestPractices")
                .Add("ElecBattery", "ElecBattery")
                .Add("ElecGrounding", "ElecGrounding")
                '.Add("ElecPerOther", "ElecPerOther")
                .Add("ElectMaintOtherComments", "ElecMaintOtherComments")
                .Add("ElectMaintSpecialComments", "ElecMaintSpecialComments")
                .Add("SparesMaintained", "Spares")
                .Add("SparesComments", "SparesComments")
                .Add("ElectricalSpareUser1", "Electrical&Sparesuser1")
                .Add("ElectricalSpareUser2", "Electrical&Sparesuser2")
                .Add("ElectricalSpareUser3", "Electrical&Sparesuser3")
                .Add("ElectricalSpareUser4", "Electrical&Sparesuser4")

                If _Util._XLInfo.TemplateVersion >= 5.5 Then
                    .Add("LastArcFlashInspDate", "LastAFInspDate")
                    .Add("LastArcFlashInspOrg", "AFInspOrg")
                    .Add("LastArcFlashComments", "AFInspComments")
                End If

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler10a-EPPMS-A)
    Overridable ReadOnly Property BmEppmsAMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("EPPMSDescription", "Description")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler11/12-HEBCP)
    Overridable ReadOnly Property BmHebcpMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("HEAdequate", "HEAdequate")
                '.Add("HEMechMaintTrain", "HEMechMaintTrain")
                '.Add("HEElecSafetyTrain", "HEElecSafetyTrain")
                '.Add("HEGenOpsTrain", "HEGenOpsTrain")
                '.Add("HEConfinedSpace", "HEConfinedSpace")
                .Add("HERecordKeeping", "HERecordKeeping")
                .Add("HEElecMaintTrain", "HEElecMaintTrain")
                .Add("HEBoilerOpTrain", "HEBoilerOpTrain")
                '.Add("HELockout", "HELockOut")
                .Add("HEMgmtofChng", "HEMgmtofChng")
                .Add("HEHousekeeping", "HEHousekeeping")
                .Add("HEGenMaint", "HEGenMaint")
                .Add("HEComments", "HEComments")
                .Add("Bcp", "BCP")
                .Add("BCPUpdateFreq", "BCPUpdateFreq")
                .Add("BCPComments", "BCPComments")
                .Add("HEBCPUser1", "HE&BCPUser1")
                .Add("HEBCPUser2", "HE&BCPUser2")
                .Add("HEBCPUser3", "HE&BCPUser3")
                .Add("HEBCPUser4", "HE&BCPUser4")
                .Add("OperProc", "OperProc")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: Cope-Boiler05c-PrimeMovers)
    Overridable ReadOnly Property BmPrimeMoversMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("ItemNo", "ItemNo")
                .Add("Type", "Type")
                .Add("Model", "Model")
                .Add("SerialNumber", "Serial Number")
                .Add("Manufacturer", "Manufacturer")
                .Add("Kwhpcp", "KW/HP/CP")
                .Add("Year", "Year")
                .Add("OverhaulDate", "Overhaul Date")
                .Add("AssessmentDate", "Assessment Date")
                .Add("NextMajorDate", "Next Major Date")
                .Add("Comments", "Comment")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: BM-Recommendations)
    Overridable ReadOnly Property BmRecommendationMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("StatusDate", "Date")
                .Add("FileNo", "FileNo")
                .Add("RecYear", "Year")
                .Add("RecMonth", "Month")
                .Add("RecNumber", "No")
                .Add("RecSubletter", "Letter")
                .Add("RecCategory", "Category")
                .Add("PrimaryRecType", "Primary")
                .Add("SecondaryRecType", "Secondary")
                .Add("RecAction", "Action")
                .Add("RecKeyWords", "Recommendation Key Words")
                .Add("LossExpectancyBefore", "Current Loss Estimate ($US)")
                .Add("LossExpectancyAfter", "Completed Loss Estimated ($US)")
                .Add("CostToComplete", "Est. Cost to Complete ($US)")
                .Add("SavingsRatio", "Savings Ratio")
                .Add("IntendedAction", "Intended Action")
                .Add("ExpectedCompletionDate", "Expected Completion Date")
                .Add("RecStatus", "Recommendation Tracking Status")
                .Add("ActualCostToComplete", "Actual Cost to Complete")

            End With
            Return zMap
        End Get
    End Property


    '--AutoGenerated (SQL Table: BM-Rating)
    Overridable ReadOnly Property BmRatingMapCollection As MapCollection
        Get
            Dim zMap As New MapCollection
            With zMap
                .Add("FileNo", "FileNo")
                .Add("InspectionDate", "Date")
                .Add("MechEquipC", "MechEquipC")
                .Add("ElecEquipC", "ElecEquipC")
                .Add("BoilersC", "BoilersC")
                .Add("ProcEquipC", "ProcEquipC")
                .Add("OccupancyC", "OccupancyC")
                .Add("CompSysC", "OtherC")
                .Add("MechMaintC", "MechMaintC")
                .Add("ElecMaintC", "ElecMaintC")
                .Add("SparesC", "SparesC")
                .Add("HumanElementC", "HumanElementC")
                .Add("Bcpc", "BCPC")
                .Add("MechEquipWR", "MechEquipWR")
                .Add("ElecEquipWR", "ElecEquipWR")
                .Add("BoilersWR", "BoilersWR")
                .Add("ProcEquipWR", "ProcEquipWR")
                .Add("OccupancyWR", "OccupancyWR")
                .Add("CompSysWR", "OtherWR")
                .Add("MechMaintWR", "MechMaintWR")
                .Add("ElecMaintWR", "ElecMaintWR")
                .Add("SparesWR", "SparesWR")
                .Add("HumanElementWR", "HumanElementWR")
                .Add("Bcpwr", "BCPWR")
                .Add("MechEquipWeight", "MechEquipWeight")
                .Add("ElecEquipWeight", "ElecEquipWeight")
                .Add("BoilersWeight", "BoilersWeight")
                .Add("ProcEquipWeight", "ProcEquipWeight")
                .Add("OccupancyWeight", "OccupancyWeight")
                .Add("CompSysWeight", "OtherWeight")
                .Add("MechMaintWeight", "MechMaintWeight")
                .Add("ElecMaintWeight", "ElecMaintWeight")
                .Add("SparesWeight", "SparesWeight")
                .Add("HumanElementWeight", "HumanElementWeight")
                .Add("BCPWeight", "BCPWeight")
                '.Add("","UpperBreak")
                '.Add("","LowerBreak")
                '.Add("","UpperName")
                '.Add("","Middle Name")
                '.Add("","Lower Name")
                .Add("PassiveC", "PassiveC")
                .Add("PassiveWC", "PassiveWR")
                .Add("ActiveC", "ActiveC")
                .Add("ActiveWC", "ActiveWR")
                .Add("TotalScoreCurrent", "TotalScoreCurrent")
                .Add("TotalRating", "TotalRating")
                .Add("TotalWRComplete", "TotalWRComplete")
                .Add("MechEquipDesc", "MechEquipCDesc")
                .Add("ElecEquipDesc", "ElecEquipCDesc")
                .Add("BoilersDesc", "BoilersCDesc")
                .Add("ProcEquipDesc", "ProcEquipCDesc")
                .Add("OccupancyDesc", "OccupancyCDesc")
                .Add("CompSysDesc", "OtherCDesc")
                .Add("MechMaintDesc", "MechMaintCDesc")
                .Add("ElecMaintDesc", "ElecMaintCDesc")
                .Add("SparesDesc", "SparesCDesc")
                .Add("HumanElementDesc", "HumanElementCDesc")
                .Add("BCPDesc", "BCPCDesc")
                .Add("MechEquipWRDesc", "MechEquipWRDesc")
                .Add("ElecEquipWRDesc", "ElecEquipWRDesc")
                .Add("BoilersWRDesc", "BoilersWRDesc")
                .Add("ProcEquipWRDesc", "ProcEquipWRDesc")
                .Add("OccupancyWRDesc", "OccupancyWRDesc")
                .Add("CompSysWRDesc", "OtherWRDesc")
                .Add("MechMaintWRDesc", "MechMaintWRDesc")
                .Add("ElecMaintWRDesc", "ElecMaintWRDesc")
                .Add("SparesWrDesc", "SparesWRDesc")
                .Add("HumanElementWRDesc", "HumanElementWRDesc")
                .Add("BCPWRDesc", "BCPWRDesc")

            End With
            Return zMap
        End Get
    End Property


#End Region


End Class


