'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwBMLossEstimatesLatestFacilityRatingExtractSelect
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFileprefix As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colClient As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colAddress As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colInspectionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colEngineer As New razor.UtilSQLServer.StringDataColumn
        Public colCurrency As New razor.UtilSQLServer.StringDataColumn
        Public colBIReporting As New razor.UtilSQLServer.StringDataColumn
        Public colExchangeRate As New razor.UtilSQLServer.DoubleDataColumn
        Public colTivpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colTivbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colTiv As New razor.UtilSQLServer.DoubleDataColumn
        Public colPmlpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colPmlbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colPml As New razor.UtilSQLServer.DoubleDataColumn
        Public colPMLPDPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colPMLBIPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colPMLPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colMflpd As New razor.UtilSQLServer.DoubleDataColumn
        Public colMflbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colMfl As New razor.UtilSQLServer.DoubleDataColumn
        Public colMFLPDPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colMFLBIPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colMFLPercent As New razor.UtilSQLServer.DoubleDataColumn
        Public colInterdependencies As New razor.UtilSQLServer.StringDataColumn
        Public colLEandInterdependecyComments As New razor.UtilSQLServer.StringDataColumn
        Public colLossesLast3Years As New razor.UtilSQLServer.StringDataColumn
        Public colLossHistoryDescription As New razor.UtilSQLServer.StringDataColumn
        Public colActiveC As New razor.UtilSQLServer.DoubleDataColumn
        Public colPassiveC As New razor.UtilSQLServer.DoubleDataColumn
        Public colTotalScoreCurrent As New razor.UtilSQLServer.DoubleDataColumn
        Public colOverallRating As New razor.UtilSQLServer.StringDataColumn
        Public colTotalscorecurrentColor As New razor.UtilSQLServer.StringDataColumn
        Public colOccupancy As New razor.UtilSQLServer.StringDataColumn
        Public colIndustryGroup As New razor.UtilSQLServer.StringDataColumn
        Public colMajorGroup As New razor.UtilSQLServer.StringDataColumn
        Public colSpecificGroup As New razor.UtilSQLServer.StringDataColumn
        Public colActiveWC As New razor.UtilSQLServer.DoubleDataColumn
        Public colPassiveWC As New razor.UtilSQLServer.DoubleDataColumn
        Public colTotalWRComplete As New razor.UtilSQLServer.DoubleDataColumn
        Public colMechEquipC As New razor.UtilSQLServer.IntegerDataColumn
        Public colElecEquipC As New razor.UtilSQLServer.IntegerDataColumn
        Public colBoilersC As New razor.UtilSQLServer.IntegerDataColumn
        Public colProcEquipC As New razor.UtilSQLServer.IntegerDataColumn
        Public colOccupancyC As New razor.UtilSQLServer.IntegerDataColumn
        Public colCompSysC As New razor.UtilSQLServer.IntegerDataColumn
        Public colMechMaintC As New razor.UtilSQLServer.IntegerDataColumn
        Public colElecMaintC As New razor.UtilSQLServer.IntegerDataColumn
        Public colSparesC As New razor.UtilSQLServer.IntegerDataColumn
        Public colHumanElementC As New razor.UtilSQLServer.IntegerDataColumn
        Public colBcpc As New razor.UtilSQLServer.IntegerDataColumn
        Public colMechEquipWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colElecEquipWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colBoilersWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colProcEquipWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colOccupancyWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colCompSysWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colMechMaintWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colElecMaintWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colSparesWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colHumanElementWR As New razor.UtilSQLServer.IntegerDataColumn
        Public colBcpwr As New razor.UtilSQLServer.IntegerDataColumn
        Public colMechEquipWeight As New razor.UtilSQLServer.LongDataColumn
        Public colElecEquipWeight As New razor.UtilSQLServer.LongDataColumn
        Public colBoilersWeight As New razor.UtilSQLServer.LongDataColumn
        Public colProcEquipWeight As New razor.UtilSQLServer.LongDataColumn
        Public colOccupancyWeight As New razor.UtilSQLServer.LongDataColumn
        Public colCompSysWeight As New razor.UtilSQLServer.LongDataColumn
        Public colMechMaintWeight As New razor.UtilSQLServer.LongDataColumn
        Public colElecMaintWeight As New razor.UtilSQLServer.LongDataColumn
        Public colSparesWeight As New razor.UtilSQLServer.LongDataColumn
        Public colHumanElementWeight As New razor.UtilSQLServer.LongDataColumn
        Public colBCPWeight As New razor.UtilSQLServer.LongDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colInspProgramYearFROM As New razor.UtilSQLServer.DateTimeDataColumn
        Public colInspProgramYear As New razor.UtilSQLServer.StringDataColumn
        Public colIbi As New razor.UtilSQLServer.DoubleDataColumn
        Public colHighestLossExpectancy As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFileprefix.ColumnName = "[fileprefix]"
            colFileNo.ColumnName = "[FileNo]"
            colClient.ColumnName = "[Client]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colDivision.ColumnName = "[Division]"
            colFacility.ColumnName = "[Facility]"
            colAddress.ColumnName = "[Address]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colInspectionDate.ColumnName = "[InspectionDate]"
            colEngineer.ColumnName = "[Engineer]"
            colCurrency.ColumnName = "[Currency]"
            colBIReporting.ColumnName = "[BIReporting]"
            colExchangeRate.ColumnName = "[ExchangeRate]"
            colTivpd.ColumnName = "[TIVPD]"
            colTivbi.ColumnName = "[TIVBI]"
            colTiv.ColumnName = "[TIV]"
            colPmlpd.ColumnName = "[PMLPD]"
            colPmlbi.ColumnName = "[PMLBI]"
            colPml.ColumnName = "[PML]"
            colPMLPDPercent.ColumnName = "[PMLPDPercent]"
            colPMLBIPercent.ColumnName = "[PMLBIPercent]"
            colPMLPercent.ColumnName = "[PMLPercent]"
            colMflpd.ColumnName = "[MFLPD]"
            colMflbi.ColumnName = "[MFLBI]"
            colMfl.ColumnName = "[MFL]"
            colMFLPDPercent.ColumnName = "[MFLPDPercent]"
            colMFLBIPercent.ColumnName = "[MFLBIPercent]"
            colMFLPercent.ColumnName = "[MFLPercent]"
            colInterdependencies.ColumnName = "[Interdependencies]"
            colLEandInterdependecyComments.ColumnName = "[LEandInterdependecyComments]"
            colLossesLast3Years.ColumnName = "[Losses_Last_3_Years]"
            colLossHistoryDescription.ColumnName = "[Loss_History_Description]"
            colActiveC.ColumnName = "[ActiveC]"
            colPassiveC.ColumnName = "[PassiveC]"
            colTotalScoreCurrent.ColumnName = "[TotalScoreCurrent]"
            colOverallRating.ColumnName = "[OverallRating]"
            colTotalscorecurrentColor.ColumnName = "[totalscorecurrentColor]"
            colOccupancy.ColumnName = "[Occupancy]"
            colIndustryGroup.ColumnName = "[IndustryGroup]"
            colMajorGroup.ColumnName = "[MajorGroup]"
            colSpecificGroup.ColumnName = "[SpecificGroup]"
            colActiveWC.ColumnName = "[ActiveWC]"
            colPassiveWC.ColumnName = "[PassiveWC]"
            colTotalWRComplete.ColumnName = "[TotalWRComplete]"
            colMechEquipC.ColumnName = "[MechEquipC]"
            colElecEquipC.ColumnName = "[ElecEquipC]"
            colBoilersC.ColumnName = "[BoilersC]"
            colProcEquipC.ColumnName = "[ProcEquipC]"
            colOccupancyC.ColumnName = "[OccupancyC]"
            colCompSysC.ColumnName = "[CompSysC]"
            colMechMaintC.ColumnName = "[MechMaintC]"
            colElecMaintC.ColumnName = "[ElecMaintC]"
            colSparesC.ColumnName = "[SparesC]"
            colHumanElementC.ColumnName = "[HumanElementC]"
            colBcpc.ColumnName = "[BCPC]"
            colMechEquipWR.ColumnName = "[MechEquipWR]"
            colElecEquipWR.ColumnName = "[ElecEquipWR]"
            colBoilersWR.ColumnName = "[BoilersWR]"
            colProcEquipWR.ColumnName = "[ProcEquipWR]"
            colOccupancyWR.ColumnName = "[OccupancyWR]"
            colCompSysWR.ColumnName = "[CompSysWR]"
            colMechMaintWR.ColumnName = "[MechMaintWR]"
            colElecMaintWR.ColumnName = "[ElecMaintWR]"
            colSparesWR.ColumnName = "[SparesWR]"
            colHumanElementWR.ColumnName = "[HumanElementWR]"
            colBcpwr.ColumnName = "[BCPWR]"
            colMechEquipWeight.ColumnName = "[MechEquipWeight]"
            colElecEquipWeight.ColumnName = "[ElecEquipWeight]"
            colBoilersWeight.ColumnName = "[BoilersWeight]"
            colProcEquipWeight.ColumnName = "[ProcEquipWeight]"
            colOccupancyWeight.ColumnName = "[OccupancyWeight]"
            colCompSysWeight.ColumnName = "[CompSysWeight]"
            colMechMaintWeight.ColumnName = "[MechMaintWeight]"
            colElecMaintWeight.ColumnName = "[ElecMaintWeight]"
            colSparesWeight.ColumnName = "[SparesWeight]"
            colHumanElementWeight.ColumnName = "[HumanElementWeight]"
            colBCPWeight.ColumnName = "[BCPWeight]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colInspProgramYearFROM.ColumnName = "[InspProgramYearFROM]"
            colInspProgramYear.ColumnName = "[InspProgramYear]"
            colIbi.ColumnName = "[IBI]"
            colHighestLossExpectancy.ColumnName = "[HighestLossExpectancy]"

            _Members.Add("colFileprefix", colFileprefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colClient", colClient)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colAddress", colAddress)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colInspectionDate", colInspectionDate)
            _Members.Add("colEngineer", colEngineer)
            _Members.Add("colCurrency", colCurrency)
            _Members.Add("colBIReporting", colBIReporting)
            _Members.Add("colExchangeRate", colExchangeRate)
            _Members.Add("colTivpd", colTivpd)
            _Members.Add("colTivbi", colTivbi)
            _Members.Add("colTiv", colTiv)
            _Members.Add("colPmlpd", colPmlpd)
            _Members.Add("colPmlbi", colPmlbi)
            _Members.Add("colPml", colPml)
            _Members.Add("colPMLPDPercent", colPMLPDPercent)
            _Members.Add("colPMLBIPercent", colPMLBIPercent)
            _Members.Add("colPMLPercent", colPMLPercent)
            _Members.Add("colMflpd", colMflpd)
            _Members.Add("colMflbi", colMflbi)
            _Members.Add("colMfl", colMfl)
            _Members.Add("colMFLPDPercent", colMFLPDPercent)
            _Members.Add("colMFLBIPercent", colMFLBIPercent)
            _Members.Add("colMFLPercent", colMFLPercent)
            _Members.Add("colInterdependencies", colInterdependencies)
            _Members.Add("colLEandInterdependecyComments", colLEandInterdependecyComments)
            _Members.Add("colLossesLast3Years", colLossesLast3Years)
            _Members.Add("colLossHistoryDescription", colLossHistoryDescription)
            _Members.Add("colActiveC", colActiveC)
            _Members.Add("colPassiveC", colPassiveC)
            _Members.Add("colTotalScoreCurrent", colTotalScoreCurrent)
            _Members.Add("colOverallRating", colOverallRating)
            _Members.Add("colTotalscorecurrentColor", colTotalscorecurrentColor)
            _Members.Add("colOccupancy", colOccupancy)
            _Members.Add("colIndustryGroup", colIndustryGroup)
            _Members.Add("colMajorGroup", colMajorGroup)
            _Members.Add("colSpecificGroup", colSpecificGroup)
            _Members.Add("colActiveWC", colActiveWC)
            _Members.Add("colPassiveWC", colPassiveWC)
            _Members.Add("colTotalWRComplete", colTotalWRComplete)
            _Members.Add("colMechEquipC", colMechEquipC)
            _Members.Add("colElecEquipC", colElecEquipC)
            _Members.Add("colBoilersC", colBoilersC)
            _Members.Add("colProcEquipC", colProcEquipC)
            _Members.Add("colOccupancyC", colOccupancyC)
            _Members.Add("colCompSysC", colCompSysC)
            _Members.Add("colMechMaintC", colMechMaintC)
            _Members.Add("colElecMaintC", colElecMaintC)
            _Members.Add("colSparesC", colSparesC)
            _Members.Add("colHumanElementC", colHumanElementC)
            _Members.Add("colBcpc", colBcpc)
            _Members.Add("colMechEquipWR", colMechEquipWR)
            _Members.Add("colElecEquipWR", colElecEquipWR)
            _Members.Add("colBoilersWR", colBoilersWR)
            _Members.Add("colProcEquipWR", colProcEquipWR)
            _Members.Add("colOccupancyWR", colOccupancyWR)
            _Members.Add("colCompSysWR", colCompSysWR)
            _Members.Add("colMechMaintWR", colMechMaintWR)
            _Members.Add("colElecMaintWR", colElecMaintWR)
            _Members.Add("colSparesWR", colSparesWR)
            _Members.Add("colHumanElementWR", colHumanElementWR)
            _Members.Add("colBcpwr", colBcpwr)
            _Members.Add("colMechEquipWeight", colMechEquipWeight)
            _Members.Add("colElecEquipWeight", colElecEquipWeight)
            _Members.Add("colBoilersWeight", colBoilersWeight)
            _Members.Add("colProcEquipWeight", colProcEquipWeight)
            _Members.Add("colOccupancyWeight", colOccupancyWeight)
            _Members.Add("colCompSysWeight", colCompSysWeight)
            _Members.Add("colMechMaintWeight", colMechMaintWeight)
            _Members.Add("colElecMaintWeight", colElecMaintWeight)
            _Members.Add("colSparesWeight", colSparesWeight)
            _Members.Add("colHumanElementWeight", colHumanElementWeight)
            _Members.Add("colBCPWeight", colBCPWeight)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colInspProgramYearFROM", colInspProgramYearFROM)
            _Members.Add("colInspProgramYear", colInspProgramYear)
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
                Case "colFileprefix"
                    Return "[fileprefix]"
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
                Case "colInspectionDate"
                    Return "[InspectionDate]"
                Case "colEngineer"
                    Return "[Engineer]"
                Case "colCurrency"
                    Return "[Currency]"
                Case "colBIReporting"
                    Return "[BIReporting]"
                Case "colExchangeRate"
                    Return "[ExchangeRate]"
                Case "colTivpd"
                    Return "[TIVPD]"
                Case "colTivbi"
                    Return "[TIVBI]"
                Case "colTiv"
                    Return "[TIV]"
                Case "colPmlpd"
                    Return "[PMLPD]"
                Case "colPmlbi"
                    Return "[PMLBI]"
                Case "colPml"
                    Return "[PML]"
                Case "colPMLPDPercent"
                    Return "[PMLPDPercent]"
                Case "colPMLBIPercent"
                    Return "[PMLBIPercent]"
                Case "colPMLPercent"
                    Return "[PMLPercent]"
                Case "colMflpd"
                    Return "[MFLPD]"
                Case "colMflbi"
                    Return "[MFLBI]"
                Case "colMfl"
                    Return "[MFL]"
                Case "colMFLPDPercent"
                    Return "[MFLPDPercent]"
                Case "colMFLBIPercent"
                    Return "[MFLBIPercent]"
                Case "colMFLPercent"
                    Return "[MFLPercent]"
                Case "colInterdependencies"
                    Return "[Interdependencies]"
                Case "colLEandInterdependecyComments"
                    Return "[LEandInterdependecyComments]"
                Case "colLossesLast3Years"
                    Return "[Losses_Last_3_Years]"
                Case "colLossHistoryDescription"
                    Return "[Loss_History_Description]"
                Case "colActiveC"
                    Return "[ActiveC]"
                Case "colPassiveC"
                    Return "[PassiveC]"
                Case "colTotalScoreCurrent"
                    Return "[TotalScoreCurrent]"
                Case "colOverallRating"
                    Return "[OverallRating]"
                Case "colTotalscorecurrentColor"
                    Return "[totalscorecurrentColor]"
                Case "colOccupancy"
                    Return "[Occupancy]"
                Case "colIndustryGroup"
                    Return "[IndustryGroup]"
                Case "colMajorGroup"
                    Return "[MajorGroup]"
                Case "colSpecificGroup"
                    Return "[SpecificGroup]"
                Case "colActiveWC"
                    Return "[ActiveWC]"
                Case "colPassiveWC"
                    Return "[PassiveWC]"
                Case "colTotalWRComplete"
                    Return "[TotalWRComplete]"
                Case "colMechEquipC"
                    Return "[MechEquipC]"
                Case "colElecEquipC"
                    Return "[ElecEquipC]"
                Case "colBoilersC"
                    Return "[BoilersC]"
                Case "colProcEquipC"
                    Return "[ProcEquipC]"
                Case "colOccupancyC"
                    Return "[OccupancyC]"
                Case "colCompSysC"
                    Return "[CompSysC]"
                Case "colMechMaintC"
                    Return "[MechMaintC]"
                Case "colElecMaintC"
                    Return "[ElecMaintC]"
                Case "colSparesC"
                    Return "[SparesC]"
                Case "colHumanElementC"
                    Return "[HumanElementC]"
                Case "colBcpc"
                    Return "[BCPC]"
                Case "colMechEquipWR"
                    Return "[MechEquipWR]"
                Case "colElecEquipWR"
                    Return "[ElecEquipWR]"
                Case "colBoilersWR"
                    Return "[BoilersWR]"
                Case "colProcEquipWR"
                    Return "[ProcEquipWR]"
                Case "colOccupancyWR"
                    Return "[OccupancyWR]"
                Case "colCompSysWR"
                    Return "[CompSysWR]"
                Case "colMechMaintWR"
                    Return "[MechMaintWR]"
                Case "colElecMaintWR"
                    Return "[ElecMaintWR]"
                Case "colSparesWR"
                    Return "[SparesWR]"
                Case "colHumanElementWR"
                    Return "[HumanElementWR]"
                Case "colBcpwr"
                    Return "[BCPWR]"
                Case "colMechEquipWeight"
                    Return "[MechEquipWeight]"
                Case "colElecEquipWeight"
                    Return "[ElecEquipWeight]"
                Case "colBoilersWeight"
                    Return "[BoilersWeight]"
                Case "colProcEquipWeight"
                    Return "[ProcEquipWeight]"
                Case "colOccupancyWeight"
                    Return "[OccupancyWeight]"
                Case "colCompSysWeight"
                    Return "[CompSysWeight]"
                Case "colMechMaintWeight"
                    Return "[MechMaintWeight]"
                Case "colElecMaintWeight"
                    Return "[ElecMaintWeight]"
                Case "colSparesWeight"
                    Return "[SparesWeight]"
                Case "colHumanElementWeight"
                    Return "[HumanElementWeight]"
                Case "colBCPWeight"
                    Return "[BCPWeight]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colInspProgramYearFROM"
                    Return "[InspProgramYearFROM]"
                Case "colInspProgramYear"
                    Return "[InspProgramYear]"
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
                Case "[fileprefix]", "fileprefix", "Fileprefix", "colFileprefix"  
                    Return "colFileprefix"
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
                Case "[InspectionDate]", "InspectionDate", "InspectionDate", "colInspectionDate"  
                    Return "colInspectionDate"
                Case "[Engineer]", "Engineer", "Engineer", "colEngineer"  
                    Return "colEngineer"
                Case "[Currency]", "Currency", "Currency", "colCurrency"  
                    Return "colCurrency"
                Case "[BIReporting]", "BIReporting", "BIReporting", "colBIReporting"  
                    Return "colBIReporting"
                Case "[ExchangeRate]", "ExchangeRate", "ExchangeRate", "colExchangeRate"  
                    Return "colExchangeRate"
                Case "[TIVPD]", "TIVPD", "Tivpd", "colTivpd"  
                    Return "colTivpd"
                Case "[TIVBI]", "TIVBI", "Tivbi", "colTivbi"  
                    Return "colTivbi"
                Case "[TIV]", "TIV", "Tiv", "colTiv"  
                    Return "colTiv"
                Case "[PMLPD]", "PMLPD", "Pmlpd", "colPmlpd"  
                    Return "colPmlpd"
                Case "[PMLBI]", "PMLBI", "Pmlbi", "colPmlbi"  
                    Return "colPmlbi"
                Case "[PML]", "PML", "Pml", "colPml"  
                    Return "colPml"
                Case "[PMLPDPercent]", "PMLPDPercent", "PMLPDPercent", "colPMLPDPercent"  
                    Return "colPMLPDPercent"
                Case "[PMLBIPercent]", "PMLBIPercent", "PMLBIPercent", "colPMLBIPercent"  
                    Return "colPMLBIPercent"
                Case "[PMLPercent]", "PMLPercent", "PMLPercent", "colPMLPercent"  
                    Return "colPMLPercent"
                Case "[MFLPD]", "MFLPD", "Mflpd", "colMflpd"  
                    Return "colMflpd"
                Case "[MFLBI]", "MFLBI", "Mflbi", "colMflbi"  
                    Return "colMflbi"
                Case "[MFL]", "MFL", "Mfl", "colMfl"  
                    Return "colMfl"
                Case "[MFLPDPercent]", "MFLPDPercent", "MFLPDPercent", "colMFLPDPercent"  
                    Return "colMFLPDPercent"
                Case "[MFLBIPercent]", "MFLBIPercent", "MFLBIPercent", "colMFLBIPercent"  
                    Return "colMFLBIPercent"
                Case "[MFLPercent]", "MFLPercent", "MFLPercent", "colMFLPercent"  
                    Return "colMFLPercent"
                Case "[Interdependencies]", "Interdependencies", "Interdependencies", "colInterdependencies"  
                    Return "colInterdependencies"
                Case "[LEandInterdependecyComments]", "LEandInterdependecyComments", "LEandInterdependecyComments", "colLEandInterdependecyComments"  
                    Return "colLEandInterdependecyComments"
                Case "[Losses_Last_3_Years]", "Losses_Last_3_Years", "LossesLast3Years", "colLossesLast3Years"  
                    Return "colLossesLast3Years"
                Case "[Loss_History_Description]", "Loss_History_Description", "LossHistoryDescription", "colLossHistoryDescription"  
                    Return "colLossHistoryDescription"
                Case "[ActiveC]", "ActiveC", "ActiveC", "colActiveC"  
                    Return "colActiveC"
                Case "[PassiveC]", "PassiveC", "PassiveC", "colPassiveC"  
                    Return "colPassiveC"
                Case "[TotalScoreCurrent]", "TotalScoreCurrent", "TotalScoreCurrent", "colTotalScoreCurrent"  
                    Return "colTotalScoreCurrent"
                Case "[OverallRating]", "OverallRating", "OverallRating", "colOverallRating"  
                    Return "colOverallRating"
                Case "[totalscorecurrentColor]", "totalscorecurrentColor", "TotalscorecurrentColor", "colTotalscorecurrentColor"  
                    Return "colTotalscorecurrentColor"
                Case "[Occupancy]", "Occupancy", "Occupancy", "colOccupancy"  
                    Return "colOccupancy"
                Case "[IndustryGroup]", "IndustryGroup", "IndustryGroup", "colIndustryGroup"  
                    Return "colIndustryGroup"
                Case "[MajorGroup]", "MajorGroup", "MajorGroup", "colMajorGroup"  
                    Return "colMajorGroup"
                Case "[SpecificGroup]", "SpecificGroup", "SpecificGroup", "colSpecificGroup"  
                    Return "colSpecificGroup"
                Case "[ActiveWC]", "ActiveWC", "ActiveWC", "colActiveWC"  
                    Return "colActiveWC"
                Case "[PassiveWC]", "PassiveWC", "PassiveWC", "colPassiveWC"  
                    Return "colPassiveWC"
                Case "[TotalWRComplete]", "TotalWRComplete", "TotalWRComplete", "colTotalWRComplete"  
                    Return "colTotalWRComplete"
                Case "[MechEquipC]", "MechEquipC", "MechEquipC", "colMechEquipC"  
                    Return "colMechEquipC"
                Case "[ElecEquipC]", "ElecEquipC", "ElecEquipC", "colElecEquipC"  
                    Return "colElecEquipC"
                Case "[BoilersC]", "BoilersC", "BoilersC", "colBoilersC"  
                    Return "colBoilersC"
                Case "[ProcEquipC]", "ProcEquipC", "ProcEquipC", "colProcEquipC"  
                    Return "colProcEquipC"
                Case "[OccupancyC]", "OccupancyC", "OccupancyC", "colOccupancyC"  
                    Return "colOccupancyC"
                Case "[CompSysC]", "CompSysC", "CompSysC", "colCompSysC"  
                    Return "colCompSysC"
                Case "[MechMaintC]", "MechMaintC", "MechMaintC", "colMechMaintC"  
                    Return "colMechMaintC"
                Case "[ElecMaintC]", "ElecMaintC", "ElecMaintC", "colElecMaintC"  
                    Return "colElecMaintC"
                Case "[SparesC]", "SparesC", "SparesC", "colSparesC"  
                    Return "colSparesC"
                Case "[HumanElementC]", "HumanElementC", "HumanElementC", "colHumanElementC"  
                    Return "colHumanElementC"
                Case "[BCPC]", "BCPC", "Bcpc", "colBcpc"  
                    Return "colBcpc"
                Case "[MechEquipWR]", "MechEquipWR", "MechEquipWR", "colMechEquipWR"  
                    Return "colMechEquipWR"
                Case "[ElecEquipWR]", "ElecEquipWR", "ElecEquipWR", "colElecEquipWR"  
                    Return "colElecEquipWR"
                Case "[BoilersWR]", "BoilersWR", "BoilersWR", "colBoilersWR"  
                    Return "colBoilersWR"
                Case "[ProcEquipWR]", "ProcEquipWR", "ProcEquipWR", "colProcEquipWR"  
                    Return "colProcEquipWR"
                Case "[OccupancyWR]", "OccupancyWR", "OccupancyWR", "colOccupancyWR"  
                    Return "colOccupancyWR"
                Case "[CompSysWR]", "CompSysWR", "CompSysWR", "colCompSysWR"  
                    Return "colCompSysWR"
                Case "[MechMaintWR]", "MechMaintWR", "MechMaintWR", "colMechMaintWR"  
                    Return "colMechMaintWR"
                Case "[ElecMaintWR]", "ElecMaintWR", "ElecMaintWR", "colElecMaintWR"  
                    Return "colElecMaintWR"
                Case "[SparesWR]", "SparesWR", "SparesWR", "colSparesWR"  
                    Return "colSparesWR"
                Case "[HumanElementWR]", "HumanElementWR", "HumanElementWR", "colHumanElementWR"  
                    Return "colHumanElementWR"
                Case "[BCPWR]", "BCPWR", "Bcpwr", "colBcpwr"  
                    Return "colBcpwr"
                Case "[MechEquipWeight]", "MechEquipWeight", "MechEquipWeight", "colMechEquipWeight"  
                    Return "colMechEquipWeight"
                Case "[ElecEquipWeight]", "ElecEquipWeight", "ElecEquipWeight", "colElecEquipWeight"  
                    Return "colElecEquipWeight"
                Case "[BoilersWeight]", "BoilersWeight", "BoilersWeight", "colBoilersWeight"  
                    Return "colBoilersWeight"
                Case "[ProcEquipWeight]", "ProcEquipWeight", "ProcEquipWeight", "colProcEquipWeight"  
                    Return "colProcEquipWeight"
                Case "[OccupancyWeight]", "OccupancyWeight", "OccupancyWeight", "colOccupancyWeight"  
                    Return "colOccupancyWeight"
                Case "[CompSysWeight]", "CompSysWeight", "CompSysWeight", "colCompSysWeight"  
                    Return "colCompSysWeight"
                Case "[MechMaintWeight]", "MechMaintWeight", "MechMaintWeight", "colMechMaintWeight"  
                    Return "colMechMaintWeight"
                Case "[ElecMaintWeight]", "ElecMaintWeight", "ElecMaintWeight", "colElecMaintWeight"  
                    Return "colElecMaintWeight"
                Case "[SparesWeight]", "SparesWeight", "SparesWeight", "colSparesWeight"  
                    Return "colSparesWeight"
                Case "[HumanElementWeight]", "HumanElementWeight", "HumanElementWeight", "colHumanElementWeight"  
                    Return "colHumanElementWeight"
                Case "[BCPWeight]", "BCPWeight", "BCPWeight", "colBCPWeight"  
                    Return "colBCPWeight"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[InspProgramYearFROM]", "InspProgramYearFROM", "InspProgramYearFROM", "colInspProgramYearFROM"  
                    Return "colInspProgramYearFROM"
                Case "[InspProgramYear]", "InspProgramYear", "InspProgramYear", "colInspProgramYear"  
                    Return "colInspProgramYear"
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
                Case "colFileprefix"
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
                Case "colInspectionDate"
                    Return "DateTime"
                Case "colEngineer"
                    Return "String"
                Case "colCurrency"
                    Return "String"
                Case "colBIReporting"
                    Return "String"
                Case "colExchangeRate"
                    Return "Double"
                Case "colTivpd"
                    Return "Double"
                Case "colTivbi"
                    Return "Double"
                Case "colTiv"
                    Return "Double"
                Case "colPmlpd"
                    Return "Double"
                Case "colPmlbi"
                    Return "Double"
                Case "colPml"
                    Return "Double"
                Case "colPMLPDPercent"
                    Return "Double"
                Case "colPMLBIPercent"
                    Return "Double"
                Case "colPMLPercent"
                    Return "Double"
                Case "colMflpd"
                    Return "Double"
                Case "colMflbi"
                    Return "Double"
                Case "colMfl"
                    Return "Double"
                Case "colMFLPDPercent"
                    Return "Double"
                Case "colMFLBIPercent"
                    Return "Double"
                Case "colMFLPercent"
                    Return "Double"
                Case "colInterdependencies"
                    Return "String"
                Case "colLEandInterdependecyComments"
                    Return "String"
                Case "colLossesLast3Years"
                    Return "String"
                Case "colLossHistoryDescription"
                    Return "String"
                Case "colActiveC"
                    Return "Double"
                Case "colPassiveC"
                    Return "Double"
                Case "colTotalScoreCurrent"
                    Return "Double"
                Case "colOverallRating"
                    Return "String"
                Case "colTotalscorecurrentColor"
                    Return "String"
                Case "colOccupancy"
                    Return "String"
                Case "colIndustryGroup"
                    Return "String"
                Case "colMajorGroup"
                    Return "String"
                Case "colSpecificGroup"
                    Return "String"
                Case "colActiveWC"
                    Return "Double"
                Case "colPassiveWC"
                    Return "Double"
                Case "colTotalWRComplete"
                    Return "Double"
                Case "colMechEquipC"
                    Return "Integer"
                Case "colElecEquipC"
                    Return "Integer"
                Case "colBoilersC"
                    Return "Integer"
                Case "colProcEquipC"
                    Return "Integer"
                Case "colOccupancyC"
                    Return "Integer"
                Case "colCompSysC"
                    Return "Integer"
                Case "colMechMaintC"
                    Return "Integer"
                Case "colElecMaintC"
                    Return "Integer"
                Case "colSparesC"
                    Return "Integer"
                Case "colHumanElementC"
                    Return "Integer"
                Case "colBcpc"
                    Return "Integer"
                Case "colMechEquipWR"
                    Return "Integer"
                Case "colElecEquipWR"
                    Return "Integer"
                Case "colBoilersWR"
                    Return "Integer"
                Case "colProcEquipWR"
                    Return "Integer"
                Case "colOccupancyWR"
                    Return "Integer"
                Case "colCompSysWR"
                    Return "Integer"
                Case "colMechMaintWR"
                    Return "Integer"
                Case "colElecMaintWR"
                    Return "Integer"
                Case "colSparesWR"
                    Return "Integer"
                Case "colHumanElementWR"
                    Return "Integer"
                Case "colBcpwr"
                    Return "Integer"
                Case "colMechEquipWeight"
                    Return "Long"
                Case "colElecEquipWeight"
                    Return "Long"
                Case "colBoilersWeight"
                    Return "Long"
                Case "colProcEquipWeight"
                    Return "Long"
                Case "colOccupancyWeight"
                    Return "Long"
                Case "colCompSysWeight"
                    Return "Long"
                Case "colMechMaintWeight"
                    Return "Long"
                Case "colElecMaintWeight"
                    Return "Long"
                Case "colSparesWeight"
                    Return "Long"
                Case "colHumanElementWeight"
                    Return "Long"
                Case "colBCPWeight"
                    Return "Long"
                Case "colCustomAccess"
                    Return "String"
                Case "colInspProgramYearFROM"
                    Return "DateTime"
                Case "colInspProgramYear"
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
            Return "[gv].[vwBMLossEstimatesLatestFacilityRatingExtractSelect]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fileprefix]"
        End Function

    End Class
End namespace

