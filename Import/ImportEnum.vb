''' <summary>
''' This utility encapsulates all classes for running imports by practice.
''' </summary>
''' <remarks>
''' </remarks>

Public Class ImportEnum

    Public Enum ImportTable
		FireCopeMain
		FireCopeConstruction
		FireCopeOccupancy
		FireCopeProtection
		FireCopeExposure
		FireRecommendation
		FireRating
		FireNatHazModeling
		FireRetail
		FireNatHazFloodBldgStructure
		FireNatHazFloodExposure
		FireNatHazFloodGeneral
		FireNatHazFloodOther
		FireNatHazSeismicGeneral
		FireNatHazSeismicNonStructural
		FireNatHazSeismicStructural
		FireNatHazSeismicStructuralData
		FireNatHazWindBuildingEnvelope
		FireNatHazWindGeneral
		FireNatHazWindOther
		FireNatHazWindUtility
		BmFacilityMain
		BmOccupancy
		BmMechanical
		BmElectrical
		BmElectricalTransformers
		BmElectricalRotatingEquipment
		BmBpv
		BmBpvA
		BmCpv
		BmPrimeMovers
		BmPpe
		BmPpeA
		BmComputerSystems
		BmMppm
		BmEppms
		BmEppmsA
		BmHebcp
		BmRating
        BmRecommendation
        PSRecommendation
    End Enum

    Public Enum ImportSheet
        CopeData
        RecTracking
        RatingForm
        RetailData
        NatHazData
        NatHazModelingData
        FacilityData
    End Enum

    Public Enum ImportType
        FDS
        BDS
        PSDS
    End Enum

    Public Enum ImportStatus
        Successful
        Failed
    End Enum

    Public Enum Mode
        Import
        Validation
    End Enum

    Public Shared Function GetImportTableEnumText(ByVal pValue As Integer) As String
        Return [Enum].GetName(GetType(ImportTable), pValue)
    End Function

End Class


