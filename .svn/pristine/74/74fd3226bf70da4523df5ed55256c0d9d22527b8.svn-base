Imports GRC.Connect.Core.UtilPractice

Public Class ReportMeta
    Public Property ReportTitle As String = ""
    Public Property ReportSubTitle As String = ""
    Public Property ReportSub1Title As String = ""
    Public Property ReportName As String = ""
    Public Property HideClientName As Boolean
    Public Property MultiPractice As Boolean
    Public Property DisplayFilter As Boolean
    Public Property DisplayDisclaimer As Boolean
    Public Property HeaderType As ReportHeaderType
    Public Property UserFilters As UtilReporting.ReportFilter()
    Public Property BatchFilters As UtilReporting.ReportFilter()
    Public Property ReportType As System.Type
    Public Property Reports As Core.UtilReporting.Reports()
    Public Property DefaultSort As String = ""
    Public Property ReportClass As Core.UtilReporting.TelerikReportClass
    Public Property Practices As Core.UtilPractice.PracticeEnum()
    Public Property Settings()
    Public Property Query As EntitySpaces.Interfaces.esDynamicQuery

    Dim zRptQuery As New ReportQuery

    Public ReadOnly Property BMFacilityDataMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Facility Data Report"
                .ReportTitle = "B&M Facility Data Form"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {UtilReporting.ReportSetting.Currency}
                .ReportType = GetType(BoilerFacilityDataReport)
                .Reports = {Core.UtilReporting.Reports.BMFacilityDataReport, Core.UtilReporting.Reports.BMAllFacilityDataReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.BoilerCopeData
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMFacilityDataQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMFacilityDataRatingSummaryMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Facility Data &amp; Rating Summary"
                .ReportTitle = EncodeHtml("BOILER & MACHINERY LOSS PREVENTION")
                .ReportSubTitle = EncodeHtml("Location Facility Data & Rating Summary")
                .ReportSub1Title = "{FileNo}"
                .DefaultSort = ""
                .HideClientName = True
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {UtilReporting.ReportSetting.Currency}
                .ReportType = GetType(BoilerFacilityDataSummaryRating)
                .Reports = {Core.UtilReporting.Reports.BMFacilityDataSummaryRatingLocationReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.BoilerFacilityDataRatingSummary
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMDataSummaryRatingQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMFacilityDataSummaryMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Facility Data Summary"
                .ReportTitle = EncodeHtml("BOILER & MACHINERY LOSS PREVENTION")
                .ReportSubTitle = "Location Facility Data Summary"
                .ReportSub1Title = "{FileNo}"
                .DefaultSort = ""
                .HideClientName = True
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {Core.UtilReporting.ReportSetting.Currency}
                .ReportType = GetType(BoilerFacilityDataSummary)
                .Reports = {Core.UtilReporting.Reports.BMFacilityDataSummaryLocationReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.BoilerFacilityDataSummary
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMDataSummaryQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMLossEstimatesMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Loss Estimates"
                .ReportTitle = "B&M Loss Estimates by Location Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Highest MFL Total)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {Core.UtilReporting.ReportSetting.Currency}
                .ReportType = GetType(BoilerLossEstimatesReport)
                .Reports = {Core.UtilReporting.Reports.BMLossEstimatesReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.BoilerLossEstimates
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMLossEstimateQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FireCopeDataMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Facility Data Report"
                .ReportTitle = "C.O.P.E Submission Form"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {UtilReporting.ReportSetting.Currency, UtilReporting.ReportSetting.Unit}
                .ReportType = GetType(FireCopeDataReport)
                .Reports = {Core.UtilReporting.Reports.FireCopeDataReport, UtilReporting.Reports.FireAllCopeDataReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.FireCopeData
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireCopeDataQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FireImpairmentMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Impairment Report"
                .ReportTitle = "Impairment Summary Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {UtilReporting.ReportFilter.Status, UtilReporting.ReportFilter.DateFrom, UtilReporting.ReportFilter.DateTo}
                .Settings = {}
                .ReportType = GetType(FireImpairmentReport)
                .Reports = {Core.UtilReporting.Reports.FireImpairmentReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.FireImpairment
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireImpairmentsQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FireImpairmentChartMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Impairment Chart"
                .ReportTitle = "<br/><br/><br/><font style='font-weight:bold; font-size:16pt;'>Impairment Notification Summary</font>"
                .ReportSubTitle = "<br/><font style='color:#C6D1DE; font-weight:bold; font-size:14pt;'>{Client}</font>"
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = True
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {UtilReporting.ReportFilter.Status, UtilReporting.ReportFilter.DateFrom, UtilReporting.ReportFilter.DateTo}
                .Settings = {}
                .ReportType = GetType(FireImpairmentChart)
                .Reports = {Core.UtilReporting.Reports.FireImpairmentChart}
                .ReportClass = Core.UtilReporting.TelerikReportClass.FireImpairmentChart
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireImpairmentsQuery
            End With
            Return zMeta
        End Get
    End Property


    Public ReadOnly Property FireInspectionFrequencyMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Inspection Frequency Report"
                .ReportTitle = "Fire Inspection Frequency"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: Insp. Type, Division, Country, State, City)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionFrequencyReport1)
                .Reports = {Core.UtilReporting.Reports.FireInspectionFrequencyReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionFrequency
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireInspectionFrequencyQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BoilerInspectionFrequencyMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Inspection Frequency Report"
                .ReportTitle = "B&M Inspection Frequency"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: Insp. Type, Division, Country, State, City)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionFrequencyReport1)
                .Reports = {Core.UtilReporting.Reports.BMInspectionFrequencyReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionFrequency
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMInspectionFrequencyQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property IRInspectionFrequencyMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Infrared Inspection Frequency Report"
                .ReportTitle = "Infrared Inspection Frequency"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: Insp. Type, Division, Country, State, City)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionFrequencyReport1)
                .Reports = {Core.UtilReporting.Reports.IRInspectionFrequencyReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionFrequency
                .Practices = {PracticeEnum.Infrared}
                .Query = zRptQuery.IRInspectionFrequencyQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property JurisInspectionFrequencyMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Jurisdictional Inspection Frequency Report"
                .ReportTitle = "Jurisdictional Inspection Frequency"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: Insp. Type, Division, Country, State, City)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionFrequencyReport1)
                .Reports = {Core.UtilReporting.Reports.JurisInspectionFrequencyReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionFrequency
                .Practices = {PracticeEnum.Jurisdictional}
                .Query = zRptQuery.JurisInspectionFrequencyQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property NatHazInspectionFrequencyMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Inspection Frequency Report"
                .ReportTitle = "Inspection Frequency"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: Insp. Type, Division, Country, State, City)"
                .HideClientName = False
                .MultiPractice = True
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionFrequencyReport1)
                .Reports = {Core.UtilReporting.Reports.WindInspectionFrequencyReport, Core.UtilReporting.Reports.SeismicInspectionFrequencyReport, Core.UtilReporting.Reports.FloodInspectionFrequencyReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionFrequency
                .Practices = {PracticeEnum.NatHazFlood, PracticeEnum.NatHazSeismic, PracticeEnum.NatHazSeismic}
                .Query = zRptQuery.NatHazInspectionFrequencyQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FireInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Inspection Status Report"
                .ReportTitle = "Fire Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: FileNo Ascending)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.FireInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Inspection Status Report"
                .ReportTitle = "B&M Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: FileNo Ascending)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.BMInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property IRInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Infrared Inspection Status Report"
                .ReportTitle = "Infrared Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: FileNo Ascending)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.IRInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.Infrared}
                .Query = zRptQuery.IRInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property JurisInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Jurisdictional Inspection Status Report"
                .ReportTitle = "Jurisdictional Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: Division, City, St/Prov, Country)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.JurisInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.Jurisdictional}
                .Query = zRptQuery.JurisInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property NatHazSeismicInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Inspection Status Report"
                .ReportTitle = "Natural Hazards/Seismic Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: FileNo Ascending)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.SeismicInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.NatHazSeismic}
                .Query = zRptQuery.SeismicInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property


    Public ReadOnly Property NatHazFloodInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Inspection Status Report"
                .ReportTitle = "Natural Hazards/Flood Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: FileNo Ascending)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.FloodInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.NatHazFlood}
                .Query = zRptQuery.FloodInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property NatHazWindInspectionStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Inspection Status Report"
                .ReportTitle = "Natural Hazards/Wind Inspection Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = "<b>for Current Inspection Period</b>"
                .DefaultSort = "(Sort Order: FileNo Ascending)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(InspectionStatusReport)
                .Reports = {UtilReporting.Reports.WindInspectionStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InspectionStatus
                .Practices = {PracticeEnum.NatHazWind}
                .Query = zRptQuery.WindInspectionStatusQuery
            End With
            Return zMeta
        End Get
    End Property




    Public ReadOnly Property IREquipmentListingMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Infrared Equipment Listing Report"
                .ReportTitle = "Infrared Equipment Listing"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Country, State, City)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(EquipmentListingReport)
                .Reports = {UtilReporting.Reports.IREquipmentListingReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.InfraredEquipmentListing
                .Practices = {PracticeEnum.Infrared}
                .Query = zRptQuery.InfraredEquipmentListingQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property JurisdictionalObjectListingMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Jurisdictional Object Listing Report"
                .ReportTitle = "Jurisdictional Object Inventory Listing"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {UtilReporting.ReportFilter.Status, UtilReporting.ReportFilter.DateFrom, UtilReporting.ReportFilter.DateTo}
                .Settings = {}
                .ReportType = GetType(JurisObjectReport)
                .Reports = {UtilReporting.Reports.JurisObjectsReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.JurisdictionalObject
                .Practices = {PracticeEnum.Jurisdictional}
                .Query = zRptQuery.JurisdictionalObjectsQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property JurisdictionalViolationDetailMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Jurisdictional Violation Detail Report"
                .ReportTitle = "Jurisdictional Violation Detail"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {UtilReporting.ReportFilter.DateFrom, UtilReporting.ReportFilter.DateTo}
                .Settings = {}
                .ReportType = GetType(JurisViolationDetailReport)
                .Reports = {UtilReporting.Reports.JurisViolationReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.JurisdictionalViolation
                .Practices = {PracticeEnum.Jurisdictional}
                .Query = zRptQuery.JurisdictionalViolationsQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FirePlanProjectReviewMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Plan/Project Review Report"
                .ReportTitle = "Fire Plan/Project Review Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = True
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(PlanReviewReport)
                .Reports = {UtilReporting.Reports.FirePlanReviewReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.PlanReview
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.PlanReviewQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMPlanProjectReviewMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Plan/Project Review Report"
                .ReportTitle = "B&M Plan/Project Review Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = True
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(PlanReviewReport)
                .Reports = {UtilReporting.Reports.BMPlanReviewReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.PlanReview
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.PlanReviewQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property QualityOfRiskScorecardMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Qor Scorecard Report"
                .ReportTitle = "Quality of Risk Scorecard"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(QorReport)
                .Reports = {UtilReporting.Reports.QualityOfRiskScoreCardReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.Qor
                .Practices = {PracticeEnum.NonSpecific}
                .Query = zRptQuery.QorQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FireRecommendationResponseReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Recommendation Response Report"
                .ReportTitle = "Fire Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number, Subletter)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReport)
                .Reports = {UtilReporting.Reports.FireRecommendationResponseReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property

    Public ReadOnly Property FireRecommendationResponseForeignReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Recommendation Response Report"
                .ReportTitle = "Fire Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number, Subletter)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReport_ForeignLang)
                .Reports = {UtilReporting.Reports.FireRecommendationResponseForeignReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property



    Public ReadOnly Property BMRecommendationResponseReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Recommendation Response Report"
                .ReportTitle = "B&M Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number, Subletter)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReport)
                .Reports = {UtilReporting.Reports.BMRecommendationResponseReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property

    Public ReadOnly Property BMRecommendationResponseForeignReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "B&M Recommendation Response Report"
                .ReportTitle = "B&M Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number, Subletter)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReport_ForeignLang)
                .Reports = {UtilReporting.Reports.BMRecommendationResponseForeignReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property


    Public ReadOnly Property NatHazRecommendationResponseReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Recommendation Response Report"
                .ReportTitle = "Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number, Subletter)"
                .HideClientName = False
                .MultiPractice = True
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReport)
                .Reports = {UtilReporting.Reports.SeismicRecommendationResponseReport, UtilReporting.Reports.FloodRecommendationResponseReport, UtilReporting.Reports.WindRecommendationResponseReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.NatHazFlood, PracticeEnum.NatHazWind, PracticeEnum.NatHazSeismic}
                .Query = zRptQuery.NatHazRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property

    Public ReadOnly Property NatHazRecommendationResponseForeignReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Recommendation Response Report"
                .ReportTitle = "Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number, Subletter)"
                .HideClientName = False
                .MultiPractice = True
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReport_ForeignLang)
                .Reports = {UtilReporting.Reports.SeismicRecommendationResponseForeignReport, UtilReporting.Reports.FloodRecommendationResponseForeignReport, UtilReporting.Reports.WindRecommendationResponseForeignReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.NatHazFlood, PracticeEnum.NatHazWind, PracticeEnum.NatHazSeismic}
                .Query = zRptQuery.NatHazRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property


    Public ReadOnly Property IRRecommendationResponseReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Infrared Recommendation Response Report"
                .ReportTitle = "Infrared Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReportIR)
                .Reports = {UtilReporting.Reports.IRRecommendationResponseReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.Infrared}
                .Query = zRptQuery.InfraredRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property

    Public ReadOnly Property IRRecommendationResponseForeignReportMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Infrared Recommendation Response Report"
                .ReportTitle = "Infrared Recommendation Response Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = "(Sort Order by Rec Year, Month, Number)"
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RecommendationResponseReportIR_ForeignLang)
                .Reports = {UtilReporting.Reports.IRRecommendationResponseForeignReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RecommendationResponse
                .Practices = {PracticeEnum.Infrared}
                .Query = zRptQuery.InfraredRecommendationResponseQuery
            End With
            Return zMeta

        End Get
    End Property

    Public ReadOnly Property FireFacilityRatingMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Facility Rating Report"
                .ReportTitle = "Fire Facility Rating"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {Core.UtilReporting.ReportSetting.Currency}
                .ReportType = GetType(FireFacilityRatingReport)
                .Reports = {UtilReporting.Reports.FireFacilityRatingReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.FireFacilityRating
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireFacilityRatingQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMFacilityRatingMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Boiler Facility Rating Report"
                .ReportTitle = "Boiler & Machinery Facility Rating"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(BoilerFacilityRatingReport)
                .Reports = {UtilReporting.Reports.BMFacilityRatingReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.BoilerFacilityRating
                .Practices = {PracticeEnum.BM}
                .Query = zRptQuery.BMFacilityRatingQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property QualityOfRiskScorecardChartMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Qor Chart"
                .ReportTitle = "<font style='font-weight:bold; font-size:16pt;'>Kimberly-Clark Quality of Risk Chart</font>"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = True
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = True
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(QorChart)
                .Reports = {UtilReporting.Reports.QualityOfRiskChart}
                .ReportClass = Core.UtilReporting.TelerikReportClass.QorChart
                .Practices = {PracticeEnum.NonSpecific}
                .Query = zRptQuery.QorQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property BMRiskImprovementChartMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Risk Improvement Chart"
                .ReportTitle = "<font style='font-weight:bold; font-size:16pt;'>{ClientName}</font>"
                .ReportSubTitle = "<font style='font-weight:bold; font-size:16pt;'>{Practice} Risk Improvement</font>"
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = True
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RiskImprovementChart)
                .Reports = {UtilReporting.Reports.BMRiskImprovementChart}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RiskImprovementChart
                .Practices = {PracticeEnum.BM}
                .Query = Nothing
            End With
            Return zMeta
        End Get
    End Property


    Public ReadOnly Property FireRiskImprovementChartMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Risk Improvement Chart"
                .ReportTitle = "<font style='font-weight:bold; font-size:16pt;'>{ClientName}</font>"
                .ReportSubTitle = "<font style='font-weight:bold; font-size:16pt;'>{Practice} Risk Improvement</font>"
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = True
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {}
                .ReportType = GetType(RiskImprovementChart)
                .Reports = {UtilReporting.Reports.FireRiskImprovementChart}
                .ReportClass = Core.UtilReporting.TelerikReportClass.RiskImprovementChart
                .Practices = {PracticeEnum.Fire}
                .Query = Nothing
            End With
            Return zMeta
        End Get
    End Property


    Public ReadOnly Property FireCopeDataSummaryMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Cope Data Summary"
                .ReportTitle = "FIRE LOSS PREVENTION"
                .ReportSubTitle = "Location C.O.P.E Summary"
                .ReportSub1Title = EncodeHtml("Fire & Associated Perils") & "<br/> {FileNo}"
                .DefaultSort = ""
                .HideClientName = True
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {UtilReporting.ReportSetting.Currency, UtilReporting.ReportSetting.Unit}
                .ReportType = GetType(FireCopeSummary1)
                .Reports = {UtilReporting.Reports.FireCopeDataSummaryReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.FireCopeDataSummary
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireCopeDataSummaryQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property FireCopeDataRatingSummaryMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Fire Cope Data Rating Summary"
                .ReportTitle = "FIRE LOSS PREVENTION"
                .ReportSubTitle = "Location C.O.P.E &amp; Rating Summary"
                .ReportSub1Title = EncodeHtml("Fire & Associated Perils") & " <br/> {FileNo}"
                .DefaultSort = ""
                .HideClientName = True
                .MultiPractice = False
                .DisplayFilter = False
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Alternate
                .BatchFilters = {}
                .Settings = {UtilReporting.ReportSetting.Currency, UtilReporting.ReportSetting.Unit}
                .ReportType = GetType(FireCopeSummaryRating)
                .Reports = {UtilReporting.Reports.FireCopeDataSummaryRatingReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.FireCopeDataRatingSummary
                .Practices = {PracticeEnum.Fire}
                .Query = zRptQuery.FireCopeDataSummaryRatingQuery
            End With
            Return zMeta
        End Get
    End Property

    Public ReadOnly Property ProgramStatusMeta As ReportMeta
        Get
            Dim zMeta As New ReportMeta
            With zMeta
                .ReportName = "Program Status Report"
                .ReportTitle = "Program Status Report"
                .ReportSubTitle = ""
                .ReportSub1Title = ""
                .DefaultSort = ""
                .HideClientName = False
                .MultiPractice = False
                .DisplayFilter = True
                .DisplayDisclaimer = False
                .HeaderType = ReportHeaderType.Standard
                .BatchFilters = {}
                .Settings = {UtilReporting.ReportSetting.Currency}
                .ReportType = GetType(ProgramStatusReport)
                .Reports = {UtilReporting.Reports.ProgramStatusReport}
                .ReportClass = Core.UtilReporting.TelerikReportClass.ProgramStatus
                .Practices = {PracticeEnum.NonSpecific}
                .Query = zRptQuery.ProgramStatusQuery
            End With
            Return zMeta
        End Get
    End Property


    Public Shared Function FindMetaByType(ByVal pType As System.Type) As ReportMeta
        Dim zMetaPropInfo() As Reflection.PropertyInfo = GetType(ReportMeta).GetProperties()
        For Each zProp As Reflection.PropertyInfo In zMetaPropInfo
            If zProp.PropertyType Is GetType(ReportMeta) Then
                Dim zMeta As New ReportMeta
                Dim zReportMeta As ReportMeta = zProp.GetValue(zMeta, Nothing)
                If zReportMeta.ReportType Is pType Then
                    Return zReportMeta
                End If
            End If
        Next

        Return Nothing

    End Function

    Public Shared Function FindMetaByReport(ByVal pReport As UtilReporting.Reports) As ReportMeta
        Dim zMetaPropInfo() As Reflection.PropertyInfo = GetType(ReportMeta).GetProperties()
        For Each zProp As Reflection.PropertyInfo In zMetaPropInfo
            If zProp.PropertyType Is GetType(ReportMeta) Then
                Dim zMeta As New ReportMeta
                Dim zReportMeta As ReportMeta = zProp.GetValue(zMeta, Nothing)
                If zReportMeta.Reports.Contains(pReport) Then
                    Return zReportMeta
                End If
            End If
        Next

        Return Nothing

    End Function

    Public Shared Function FindMetaByClass(ByVal pReportClass As Core.UtilReporting.TelerikReportClass) As ReportMeta
        Dim zReturn As New List(Of ReportMeta)
        Dim zPropInfo() As Reflection.PropertyInfo = GetType(ReportMeta).GetProperties()
        For Each zProp As Reflection.PropertyInfo In zPropInfo
            If zProp.GetType = GetType(Object) Then
                Dim zMeta As New ReportMeta
                Dim zReportMeta As ReportMeta = zProp.GetValue(zMeta, Nothing)
                If zReportMeta.ReportClass = pReportClass Then
                    Return zReportMeta
                End If
            End If
        Next

        Return Nothing

    End Function

    Public Shared Function FindMetaByPractice(ByVal pPractice As PracticeEnum) As List(Of ReportMeta)
        Dim zReturn As New List(Of ReportMeta)
        Dim zMetaPropInfo() As Reflection.PropertyInfo = GetType(ReportMeta).GetProperties()
        For Each zProp As Reflection.PropertyInfo In zMetaPropInfo
            If zProp.PropertyType = GetType(Object) Then
                Dim zMeta As New ReportMeta
                Dim zReportMeta As ReportMeta = zProp.GetValue(zMeta, Nothing)
                If zReportMeta.Practices.Contains(pPractice) Then
                    zReturn.Add(zReportMeta)
                End If
            End If
        Next

        Return zReturn

    End Function


    Public Shared Function EncodeHtml(ByVal pValue As String) As String
        Return System.Web.HttpUtility.HtmlEncode(pValue)
    End Function

End Class

Public Enum ReportHeaderType
    Standard
    Alternate
End Enum

