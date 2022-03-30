Imports EntitySpaces.Interfaces

Public Class ReportQuery
    Inherits BaseQuery

    Public Sub New()

    End Sub

#Region "Inspection Status"

    Public Function FireInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Fire, True)))
        Return zQry
    End Function

    Public Function BMInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.BM, True)))
        Return zQry
    End Function

    Public Function IRInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Infrared, True)))
        Return zQry
    End Function

    Public Function JurisInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Jurisdictional, True)))
        Return zQry
    End Function

    Public Function SeismicInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.NatHazSeismic, True)))
        zQry.Where(zQry.Report1.Like("Seismic%"))
        Return zQry
    End Function

    Public Function FloodInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.NatHazFlood, True)))
        zQry.Where(zQry.Report1.Like("Flood%"))
        Return zQry
    End Function

    Public Function WindInspectionStatusQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionStatusBaseQuery = Me.InspectionStatusQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.NatHazWind, True)))
        zQry.Where(zQry.Report1.Like("Wind%"))
        Return zQry
    End Function



#End Region

#Region "Inspection Frequency"

    Public Function FireInspectionFrequencyQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionFrequencyBaseQuery = Me.InspectionFrequencyQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Fire, True)))
        Return zQry
    End Function

    Public Function BMInspectionFrequencyQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionFrequencyBaseQuery = Me.InspectionFrequencyQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.BM, True)))
        Return zQry
    End Function

    Public Function JurisInspectionFrequencyQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionFrequencyBaseQuery = Me.InspectionFrequencyQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Jurisdictional, True)))
        Return zQry
    End Function

    Public Function IRInspectionFrequencyQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionFrequencyBaseQuery = Me.InspectionFrequencyQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Infrared, True)))
        Return zQry
    End Function

    Public Function NatHazInspectionFrequencyQuery() As esDynamicQuery
        Dim zQry As BusinessObjects.ViewCCReportInspectionFrequencyBaseQuery = Me.InspectionFrequencyQuery
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.NatHazSeismic, True)))
        Return zQry
    End Function

#End Region

    Public Function FireCopeDataSummaryQuery() As esDynamicQuery
        Return MyBase.FireCopeDataQuery
    End Function

    Public Function FireCopeDataSummaryRatingQuery() As esDynamicQuery
        Return MyBase.FireCopeDataQuery
    End Function

    Public Function BMDataSummaryQuery() As esDynamicQuery
        Return MyBase.BMFacilityDataQuery
    End Function

    Public Function BMDataSummaryRatingQuery() As esDynamicQuery
        Return MyBase.BMFacilityDataQuery
    End Function

    Public Function BMLossEstimateQuery() As esDynamicQuery
        Return MyBase.BMFacilityDataQuery
    End Function

    Public Function NatHazRecommendationResponseQuery() As esDynamicQuery
        Return MyBase.FireRecommendationResponseQuery
    End Function

    Public Shared Sub JoinSafeFileNo(ByRef pQuery As Object, ByVal pGuid As String)

        Dim zSafeFileNo As New BusinessObjects.GSafeFileNoQuery("sf")
        Dim zSafeHeader As New BusinessObjects.GSafeHeaderQuery("sh")
        zSafeFileNo.Select(zSafeFileNo.FileNo)
        zSafeFileNo.Where(zSafeHeader.GSafeGUID = pGuid)
        zSafeFileNo.InnerJoin(zSafeHeader).On(zSafeFileNo.GSafeId = zSafeHeader.GSafeId)
        pQuery.Where(pQuery.FileNo.In(zSafeFileNo))

    End Sub

    Public Shared Sub JoinReportFileNo(ByRef pQuery As Object, ByVal pEngine As UtilReportEngine)
        Select Case pEngine.RptCode

            Case UtilReporting.Reports.ProgramStatusReport
                'Do not inner join for Program Status report because its already generated
            Case Else
                Dim zRptFileNo As New BusinessObjects.ReportFileNoQuery("rpt")
                zRptFileNo.Select(zRptFileNo.FileNo.As("FileNoWhere"))
                zRptFileNo.Where(zRptFileNo.RptSetId = pEngine.RptSetId)
                ' pQuery.InnerJoin(zRptFileNo).On(pQuery.FileNo = zRptFileNo.FileNo)
                pQuery.Where(pQuery.FileNo.In(zRptFileNo))
        End Select

    End Sub

    'Public Shared Sub JoinReportFileNo(ByRef pQuery As Object, ByVal pSetId As String)
    '     Dim zReRptFileNo As New BusinessObjects.RERptSetFileNoQuery("rptFile")
    '     zReRptFileNo.Select(zReRptFileNo.FileNo)
    '     zReRptFileNo.Where(zReRptFileNo.RptSetId = pSetId)
    '     pQuery.Where(pQuery.FileNo.In(zReRptFileNo))
    'End Sub

    Public Shared Sub ApplyFilter(ByRef pQry As Object, ByVal pFilter As Filter, ByVal pEngine As UtilReportEngine)

        Select Case pEngine.RptCode

            Case UtilReporting.Reports.FireImpairmentReport, UtilReporting.Reports.FireImpairmentChart
                Dim zQry As BusinessObjects.ViewCCReportFireImpairmentBaseQuery = DirectCast(pQry, BusinessObjects.ViewCCReportFireImpairmentBaseQuery)
                If pFilter.Status <> "" Then zQry.Where(zQry.Status.ToLower = pFilter.Status.ToLower)
                If pFilter.DateFrom <> Nothing And pFilter.DateTo <> Nothing Then zQry.Where(zQry.DateReceived.Between(pFilter.DateFrom, pFilter.DateTo))

            Case UtilReporting.Reports.ProgramStatusReport
                Dim zQry As BusinessObjects.SysProgramStatusDataQuery = DirectCast(pQry, BusinessObjects.SysProgramStatusDataQuery)
                zQry.Where(zQry.DataKey = pEngine.JobDefId)

            Case UtilReporting.Reports.FireAllCopeDataReport, UtilReporting.Reports.FireCopeDataReport,
                UtilReporting.Reports.BMFacilityDataReport, UtilReporting.Reports.BMAllFacilityDataReport

                'Dim zQry As BusinessObjects.ViewCCReportBoilerCopeBase = DirectCast(pQry, BusinessObjects.ViewCCReportBoilerCopeBase)
                If pFilter.Division <> "" Then pQry.Where(pQry.MainDivision.ToLower = pFilter.Division.ToLower)
                If pFilter.CustomAccess <> "" Then pQry.Where(pQry.MainCustomAccess.ToLower = pFilter.CustomAccess.ToLower)

            Case UtilReporting.Reports.FireInspectionFrequencyReport,
                UtilReporting.Reports.BMInspectionFrequencyReport,
                UtilReporting.Reports.IRInspectionFrequencyReport,
                UtilReporting.Reports.JurisInspectionFrequencyReport,
                UtilReporting.Reports.WindInspectionFrequencyReport,
                UtilReporting.Reports.SeismicInspectionFrequencyReport,
                UtilReporting.Reports.FloodInspectionFrequencyReport,
                UtilReporting.Reports.FireInspectionStatusReport,
                UtilReporting.Reports.BMInspectionStatusReport,
                UtilReporting.Reports.IRInspectionStatusReport,
                UtilReporting.Reports.JurisInspectionStatusReport,
                UtilReporting.Reports.WindInspectionStatusReport,
                UtilReporting.Reports.SeismicInspectionStatusReport,
                UtilReporting.Reports.FloodInspectionStatusReport

                If pFilter.Division <> "" Then pQry.Where(pQry.Division.ToLower = pFilter.Division.ToLower)
                If pFilter.CustomAccess <> "" Then pQry.Where(pQry.CustomAccess.ToLower = pFilter.CustomAccess.ToLower)

                Select Case pEngine.RptCode

                    Case UtilReporting.Reports.SeismicInspectionStatusReport
                        pQry.Where(pQry.Report1.Like("Seismic%"))

                    Case UtilReporting.Reports.WindInspectionStatusReport
                        pQry.Where(pQry.Report1.Like("Wind%"))

                    Case UtilReporting.Reports.FloodInspectionStatusReport
                        pQry.Where(pQry.Report1.Like("Flood%"))

                End Select





        End Select
    End Sub

    'Public Shared Sub ApplySetting(ByRef pTable As DataTable, ByVal pProperty As ReportProccessor.ProcessingProperties, ByVal pFilePrefix As String)

    '    AddExtraColumn(pTable, "CurrencySymbol", GetType(String), UtilCurrency.GetCurrencySymbol(pProperty.Currency))
    '    AddExtraColumn(pTable, "LeExchangeRate", GetType(Double), UtilCurrency.GetExchangeRate(pFilePrefix, pProperty.Currency))
    '    AddExtraColumn(pTable, "SelectedCurrency", GetType(String), UtilCurrency.GetCurrencyName(pProperty.Currency))
    '    AddExtraColumn(pTable, "SelectedCurrencyValue", GetType(Integer), pProperty.Currency)
    '    AddExtraColumn(pTable, "SelectedCurrencyCode", GetType(String), UtilCurrency.GetCurrencyCode(pProperty.Currency))
    '    AddExtraColumn(pTable, "SelectedUnit", GetType(String), UtilUnit.GetUnitName(pProperty.Unit))
    '    AddExtraColumn(pTable, "SelectedUnitValue", GetType(Integer), pProperty.Unit)

    'End Sub

    Public Shared Sub ApplyAlias(ByRef pValue As String, ByVal pReport As Core.UtilReporting.Reports)

        Select Case pReport

            'Case UtilReporting.Reports.FireInspectionStatusReport,
            '     UtilReporting.Reports.BMInspectionStatusReport,
            '     UtilReporting.Reports.IRInspectionStatusReport,
            '     UtilReporting.Reports.JurisInspectionStatusReport,
            '     UtilReporting.Reports.WindInspectionStatusReport,
            '     UtilReporting.Reports.FloodInspectionStatusReport,
            '     UtilReporting.Reports.SeismicInspectionStatusReport

            '     pValue = Replace(pValue.ToLower, "inspection_type", "InspectionType")
            '     pValue = Replace(pValue.ToLower, "engineer_target", "EngineerTargetDate")
            '     pValue = Replace(pValue.ToLower, "address", "Address1")
            '     pValue = Replace(pValue.ToLower, "schd_date", "ScheduledDate")
            '     pValue = Replace(pValue.ToLower, "insp_date", "InspectionDate")
            '     pValue = Replace(pValue.ToLower, "mailed_date", "Rpt1Client")
            '     pValue = Replace(pValue.ToLower, "inspfreq", "Frequency")
            '     pValue = Replace(pValue.ToLower, "inspection_status", "InspectionStatus")

            'Case UtilReporting.Reports.BMLossEstimatesReport

            '     pValue = Replace(pValue.ToLower, "fileno", "fileno")
            '     pValue = Replace(pValue.ToLower, "clientlocno", "MainClientLocNo")
            '     pValue = Replace(pValue.ToLower, "client", "MainClient")
            '     pValue = Replace(pValue.ToLower, "division", "MainDivision")
            '     pValue = Replace(pValue.ToLower, "facility", "MainFacility")
            '     pValue = Replace(pValue.ToLower, "address", "MainAddress")
            '     pValue = Replace(pValue.ToLower, "city", "MainCity")
            '     pValue = Replace(pValue.ToLower, "stprov", "MainStProv")
            '     pValue = Replace(pValue.ToLower, "zip", "MainPostalCode")
            '     pValue = Replace(pValue.ToLower, "country", "MainCountry")
            '     pValue = Replace(pValue.ToLower, "surveydate", "MainSurveyDate")
            '     pValue = Replace(pValue.ToLower, "engineer", "MainConsultant")
            '     pValue = Replace(pValue.ToLower, "currency", "lecurrency")
            '     pValue = Replace(pValue.ToLower, "bireporting", "Lebireporting")
            '     pValue = Replace(pValue.ToLower, "exchangerate", "leexchangerate")
            '     pValue = Replace(pValue.ToLower, "reptpd", "LEreptpd")
            '     pValue = Replace(pValue.ToLower, "reptbi", "LEreptbi")
            '     pValue = Replace(pValue.ToLower, "repttiv", "LErepttiv")

            '     pValue = Replace(pValue.ToLower, "pmlpdpercentage", "lepmlpdpercentage")
            '     pValue = Replace(pValue.ToLower, "pmlbipercentage", "lepmlbipercentage")
            '     pValue = Replace(pValue.ToLower, "pmltotalpercentage", "lepmltotalpercentage")
            '     pValue = Replace(pValue.ToLower, "mflpdpercentage", "lemflpdpercentage")
            '     pValue = Replace(pValue.ToLower, "mflbipercentage", "lemflbipercentage")
            '     pValue = Replace(pValue.ToLower, "mfltotalpercentage", "lemfltotalpercentage")


            '     pValue = Replace(pValue.ToUpper, "PML_PD_AUD", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_GBP", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_CAD", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_EUR", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_JPY", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_MXP", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_NZD", "LEPMLPD")
            '     pValue = Replace(pValue.ToUpper, "PML_PD_USD", "LEPMLPD")

            '     pValue = Replace(pValue.ToUpper, "PML_BI_AUD", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_GBP", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_CAD", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_EUR", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_JPY", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_MXP", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_NZD", "LEPMLBI")
            '     pValue = Replace(pValue.ToUpper, "PML_BI_USD", "LEPMLBI")

            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_AUD", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_GBP", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_CAD", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_EUR", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_JPY", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_MXP", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_NZD", "LEPMLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "PML_TOTAL_USD", "LEPMLTOTAL")

            '     pValue = Replace(pValue.ToUpper, "MFL_PD_AUD", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_GBP", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_CAD", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_EUR", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_JPY", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_MXP", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_NZD", "LEMFLPD")
            '     pValue = Replace(pValue.ToUpper, "MFL_PD_USD", "LEMFLPD")

            '     pValue = Replace(pValue.ToUpper, "MFL_BI_AUD", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_GBP", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_CAD", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_EUR", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_JPY", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_MXP", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_NZD", "LEMFLBI")
            '     pValue = Replace(pValue.ToUpper, "MFL_BI_USD", "LEMFLBI")

            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_AUD", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_GBP", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_CAD", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_EUR", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_JPY", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_MXP", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_NZD", "LEMFLTOTAL")
            '     pValue = Replace(pValue.ToUpper, "MFL_TOTAL_USD", "LEMFLTOTAL")

            '     pValue = Replace(pValue.ToLower, "interdependencies", "LeInterdependencies")
            '     pValue = Replace(pValue.ToLower, "leandinterdependecycomments", "leinterdependenciescomments")
            '     pValue = Replace(pValue.ToLower, "significantdamagelossesinpast3years", "lesignificantlosses")
            '     pValue = Replace(pValue.ToLower, "significantdamagelossesdescription", "lesignificantlossesdescription")
            '     pValue = Replace(pValue.ToLower, "customAccess", "maincustomaccess")

            'Case UtilReporting.Reports.JurisObjectsReport, UtilReporting.Reports.JurisViolationReport

            '     pValue = Replace(pValue.ToLower, "juris_no", "strjurisnumber")
            '     pValue = Replace(pValue.ToLower, "vessel_type", "strvesseltype")
            '     pValue = Replace(pValue.ToLower, "nat_bd_no", "strnbnumber")
            '     pValue = Replace(pValue.ToLower, "manufacturer", "strmanufacturername")
            '     pValue = Replace(pValue.ToLower, "year_built", "intyearbuilt")
            '     pValue = Replace(pValue.ToLower, "object_location", "strplantlocation")
            '     pValue = Replace(pValue.ToLower, "status", "strstatus")
            '     pValue = Replace(pValue.ToLower, "cert_exp_date", "dtcertexpire")
            '     pValue = Replace(pValue.ToLower, "last_inspected_date", "dtlastinspected")
            '     pValue = Replace(pValue.ToLower, "next_inspection_due_date", "dtnextinspectionduedate")
            '     pValue = Replace(pValue.ToLower, "id", "intviolationid")
            '     pValue = Replace(pValue.ToLower, "violation_date", "dtviolation")
            '     pValue = Replace(pValue.ToLower, "violation_type", "strviolationtype")
            '     pValue = Replace(pValue.ToLower, "violation_category", "strviolationcategory")
            '     pValue = Replace(pValue.ToLower, "violation_status", "strviolationstatus")
            '     pValue = Replace(pValue.ToLower, "date_resolution_required", "dtresolutionrequried")
            '     pValue = Replace(pValue.ToLower, "comment", "strcomment")
            '     pValue = Replace(pValue.ToLower, "requirement", "strrequirement")
            '     pValue = Replace(pValue.ToLower, "condition", "strcondition")
            '     pValue = Replace(pValue.ToLower, "closed", "dtclosed")

        End Select


        'Grid Columns

    End Sub

    Public Shared Sub ApplyDefaultSort(ByRef pQry As Object, ByVal pReport As Core.UtilReporting.Reports)
        Select Case pReport
            Case UtilReporting.Reports.FireInspectionStatusReport,
                UtilReporting.Reports.BMInspectionStatusReport,
                UtilReporting.Reports.IRInspectionStatusReport,
                UtilReporting.Reports.JurisInspectionStatusReport,
                UtilReporting.Reports.WindInspectionStatusReport,
                UtilReporting.Reports.FloodInspectionStatusReport,
                UtilReporting.Reports.SeismicInspectionStatusReport

                pQry.OrderBy(pQry.FileNo.Ascending)

            Case UtilReporting.Reports.BMRecommendationResponseReport,
                UtilReporting.Reports.FireRecommendationResponseReport,
                UtilReporting.Reports.IRRecommendationResponseReport

                pQry.OrderBy(pQry.RecYear.Ascending, pQry.RecMonth.Ascending, pQry.RecNumber.Ascending, pQry.RecSubletter.Ascending)

            Case UtilReporting.Reports.IREquipmentListingReport

                pQry.OrderBy(pQry.Country.Ascending, pQry.StProv.Ascending, pQry.City.Ascending)

            Case UtilReporting.Reports.BMLossEstimatesReport

                pQry.OrderBy(pQry.LEMFLTotal.Descending)

            Case UtilReporting.Reports.BMFacilityDataReport,
                UtilReporting.Reports.FireCopeDataReport,
                UtilReporting.Reports.FireAllCopeDataReport

                pQry.OrderBy(pQry.FileNo.Ascending)

            Case UtilReporting.Reports.FireFacilityRatingReport,
                UtilReporting.Reports.BMFacilityRatingReport

                pQry.OrderBy(pQry.InspectionDate.Descending)

            Case UtilReporting.Reports.JurisObjectsReport, UtilReporting.Reports.JurisViolationReport

                pQry.OrderBy(pQry.FileNo.Ascending)


        End Select
    End Sub

    Public Shared Sub ApplySort(ByRef pQry As Object, ByVal pSqlSort As String)

        Dim zSortColumns() As String = Split(pSqlSort, ",")
        Dim zSortDef() As String
        For Each zColumn As String In zSortColumns
            zSortDef = Split(zColumn, " ")
            pQry.OrderBy("<" + pQry.es.JoinAlias + "." + zSortDef(0) + " " + zSortDef(1) + ">")
        Next
    End Sub

    Private Shared Sub AddExtraColumn(ByRef pTable As DataTable, ByVal pColumnName As String, ByVal pDataType As Type, ByVal pValue As String)
        If IsNothing(pTable.Columns(pColumnName)) Then pTable.Columns.Add(pColumnName, pDataType)
        For Each zRow As DataRow In pTable.Rows
            zRow(pColumnName) = pValue
        Next
    End Sub


End Class
