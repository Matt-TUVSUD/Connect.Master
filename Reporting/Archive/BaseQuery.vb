
Imports EntitySpaces.Interfaces


Public Class BaseQuery

    Public Function InspectionStatusQuery(Optional pAlias As String = "") As ViewCCReportInspectionStatusBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportInspectionStatusBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function InspectionFrequencyQuery(Optional pAlias As String = "") As esViewCCReportInspectionFrequencyBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportInspectionFrequencyBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function FireImpairmentsQuery(Optional pAlias As String = "") As ViewCCReportFireImpairmentBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportFireImpairmentBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function FireImpairmentChartQuery(Optional pAlias As String = "") As ViewCCReportFireImpairmentChartBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportFireImpairmentChartBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.Select(zQry.SameDay.Sum, zQry.OneToFiveDays.Sum, zQry.SixToTenDays.Sum, zQry.OverTenDays.Sum, zQry.PendingAdvisory.Sum, zQry.Counter.Sum)
        Return zQry
    End Function

    Public Function JurisdictionalViolationsQuery(Optional pAlias As String = "") As ViewCCReportJurisdictionalViolationBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportJurisdictionalViolationBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function JurisdictionalObjectsQuery(Optional pAlias As String = "") As ViewCCReportJurisdictionalObjectBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportJurisdictionalObjectBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function BMRecommendationResponseQuery(Optional pAlias As String = "") As ViewCCReportBoilerRecommendationBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportBoilerRecommendationBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        zQry.Where(zQry.RecStatus.ToLower.NotIn("advisory", "removed", "conf completed"))
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.BM, True)))
        Return zQry
    End Function

    Public Function FireRecommendationResponseQuery(Optional pAlias As String = "") As ViewCCReportFireRecommendationBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportFireRecommendationBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        zQry.Where(zQry.RecStatus.ToLower.NotIn("advisory", "removed", "conf completed"))
        zQry.Where(zQry.PracticeCode.In(UtilPractice.GetPracticeCodes(UtilPractice.PracticeEnum.Fire, True)))
        ' zQry.OrderBy(zQry.RecYear.Ascending, zQry.RecMonth.Ascending, zQry.RecNumber.Ascending, zQry.RecSubletter.Ascending)
        Return zQry
    End Function

    Public Function InfraredRecommendationResponseQuery(Optional pAlias As String = "") As ViewCCReportInfraredRecommendationBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportInfraredRecommendationBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        zQry.Where(zQry.Recstatus.ToLower.NotIn("advisory", "removed", "conf completed"))
        Return zQry
    End Function

    Public Function InfraredEquipmentListingQuery(Optional pAlias As String = "") As ViewCCReportInfraredEquipmentBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportInfraredEquipmentBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function PlanReviewQuery(Optional pAlias As String = "") As ViewCCReportPlanReviewBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportPlanReviewBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.Select(zQry.Fileno, zQry.Division, zQry.Address, zQry.Address2, zQry.Facility, zQry.City, zQry.StProv, zQry.Country, zQry.Zip).es.Distinct = True
        Return zQry
    End Function

    Public Function QorQuery(Optional pAlias As String = "") As ViewCCReportQorBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportQorBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function QorChartQuery(Optional pAlias As String = "") As ViewCCReportQorChartBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportQorChartBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.Select(zQry.Header, zQry.FacilityScore, zQry.PrimaryBusiness, zQry.NaturalHazards, zQry.Equipment, zQry.TotalClaims, zQry.EntWeightedAvg, zQry.TotalScore).es.Top = 20
        Return zQry

    End Function

    Public Function BMFacilityDataQuery(Optional pAlias As String = "") As ViewCCReportBoilerCopeBaseQuery

        Dim zQry As New Core.BusinessObjects.ViewCCReportBoilerCopeBaseQuery(IIf(pAlias = "", "Base", pAlias))
        Dim zQry1 As New Core.BusinessObjects.ViewCCReportBoilerRatingCurrentQuery("r")
        zQry.SelectAllExcept(zQry.LEexchangerate)
        zQry.Select(zQry1.SelectAll)
        zQry.InnerJoin(zQry1).On(zQry.FileNo = zQry1.FileNo)
        Return zQry

    End Function

    Public Function FireCopeDataQuery(Optional pAlias As String = "") As ViewCCReportFireCopeBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportFireCopeBaseQuery(IIf(pAlias = "", "Base", pAlias))
        Dim zQry1 As New Core.BusinessObjects.ViewCCReportFireRatingCurrentQuery("r")
        zQry.SelectAll()
        zQry.Select(zQry1.SelectAll())
        zQry.InnerJoin(zQry1).On(zQry.FileNo = zQry1.FileNo)
        Return zQry

    End Function

    Public Function FireFacilityRatingQuery(Optional pAlias As String = "") As ViewCCReportFireRatingBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportFireRatingBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        zQry.OrderBy(zQry.FileNo.Ascending)
        Return zQry
    End Function

    Public Function BMFacilityRatingQuery(Optional pAlias As String = "") As ViewCCReportBoilerRatingBaseQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportBoilerRatingBaseQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        zQry.OrderBy(zQry.FileNo.Ascending)
        Return zQry
    End Function

    Public Function RatingKeyQuery(Optional pAlias As String = "") As ViewCCReportRatingKeyQuery
        Dim zQry As New Core.BusinessObjects.ViewCCReportRatingKeyQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Function ProgramStatusQuery(Optional pAlias As String = "") As SysProgramStatusDataQuery
        Dim zQry As New Core.BusinessObjects.SysProgramStatusDataQuery(IIf(pAlias = "", "Base", pAlias))
        zQry.SelectAll()
        Return zQry
    End Function

    Public Class SubQueries

        Public Shared Function BoilerFacilityData_LargestTransformer(ByVal pFilePrefix As String) As DataTable
            Dim zQry As New Core.BusinessObjects.ViewCCReportBoilerLargestTransformerQuery
            zQry.Select(zQry.FileNo, zQry.Manufacturer, zQry.Year, zQry.Type, zQry.PrimSecVoltage, zQry.Kva)
            zQry.Where(zQry.FileNo.Like(pFilePrefix & "%"))
            zQry.OrderBy(zQry.Kva.Descending)
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_PrimaryTransformers() As DataTable
            Dim zQry As New BusinessObjects.ViewCCReportBoilerElectricalTransformerQuery
            zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_RotatingElectricalEquipment() As DataTable
            Dim zQry As New BusinessObjects.BmElectricalRotatingEquipmentQuery
            zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_Bpv() As DataTable
            Dim zQry As New BusinessObjects.BmBpvAQuery
            'zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_Cpv() As DataTable
            Dim zQry As New BusinessObjects.BmCpvQuery
            zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_PrimeMovers() As DataTable
            Dim zQry As New BusinessObjects.BmPrimeMoverQuery
            zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_ProductionProcessEquipment() As DataTable
            Dim zQry As New BusinessObjects.BmPpeAQuery
            zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityData_CriticalSpares() As DataTable
            Dim zQry As New BusinessObjects.BmEppmsAQuery
            zQry.SelectAll()
            Return zQry.LoadDataTable
        End Function

        Public Shared Function PlanReview_SchedulingSummary() As DataTable
            Dim zQry As New BusinessObjects.GRIPSSWorkloadQuery
            zQry.SelectAll()
            zQry.OrderBy(zQry.DateCompleted.Descending)
            Return zQry.LoadDataTable
        End Function

        Public Shared Function PlanReview_ReviewActivity() As DataTable
            Dim zQry As New BusinessObjects.ViewCCReportPlanReviewBaseQuery
            zQry.SelectAll()
            zQry.OrderBy(zQry.Received.Descending)
            Return zQry.LoadDataTable
        End Function

        Public Shared Function BoilerBaseQry() As Core.BusinessObjects.BMRecommendationsQuery
            Dim zRecQry As New BusinessObjects.BMRecommendationsQuery
            With zRecQry
                .Select(.FileNo, .RecStatus)
                .Select((.RecYear.Cast(EntitySpaces.DynamicQuery.esCastType.String).Coalesce("''") + "-" + .RecMonth.Coalesce("''").Cast(EntitySpaces.DynamicQuery.esCastType.String) + "-" + .RecNumber.Coalesce("''").Cast(EntitySpaces.DynamicQuery.esCastType.String) + .RecSubletter.Coalesce("''") + " (" + .PrimaryRecType + "\" + .SecondaryRecType + ") " + .RecKeyWords).As("Rec"))
                .Select(.LossExpectancyBefore, .PrimaryRecType, .SecondaryRecType, .RecKeyWords)
                .Where(.FileNo.Like("2061%"))
            End With

            Return zRecQry
        End Function

        Public Shared Function FireBaseQry() As Core.BusinessObjects.FireRecommendationsQuery
            Dim zRecQry As New BusinessObjects.FireRecommendationsQuery
            With zRecQry
                .Select(.FileNo, .RecStatus)
                .Select((.RecYear.Cast(EntitySpaces.DynamicQuery.esCastType.String).Coalesce("''") + "-" + .RecMonth.Coalesce("''").Cast(EntitySpaces.DynamicQuery.esCastType.String) + "-" + .RecNumber.Coalesce("''").Cast(EntitySpaces.DynamicQuery.esCastType.String) + .RecSubletter.Coalesce("''") + " (" + .PrimaryRecType + "\" + .SecondaryRecType + ") " + .RecKeyWords).As("Rec"))
                .Select(.LossExpectancyBefore, .PrimaryRecType, .SecondaryRecType, .RecKeyWords)
                .Where(.FileNo.Like("2061%"))
            End With

            Return zRecQry
        End Function

        Public Shared Function Qor_BM_Bvpm() As DataTable

            'Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            'Dim zRecQry1 As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            'With zRecQry
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
            '    .Where(.PrimaryRecType = "Boilers Pres.Vess Tanks")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2) = "14")

            'End With

            'With zRecQry1
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
            '    .Where(.PrimaryRecType = "Production/Process Equipment")
            '    .Where(.SecondaryRecType = "Furnaces" Or .SecondaryRecType = "Kilns/Dryers" Or .SecondaryRecType = "Proc. Piping (Not Steam)")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2) = "14")
            'End With

            'zRecQry.UnionAll(zRecQry1)

            'Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_Eem() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            Dim zRecQry1 As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()

            'With zRecQry
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
            '    .Where(.PrimaryRecType = "Electrical Prev./Pred. Maint.")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))

            'End With

            'With zRecQry1
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
            '    .Where(.PrimaryRecType = "Electrical Systems")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2) = "14")
            'End With

            zRecQry.UnionAll(zRecQry1)

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_Mem() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            Dim zRecQry1 As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            'With zRecQry
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
            '    .Where(.PrimaryRecType = "Mechanical Prev./Pred. Maint." Or .PrimaryRecType = "Mechanical Systems")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2) = "14")

            'End With

            'With zRecQry1
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
            '    .Where(.PrimaryRecType = "Production/Process Equipment")
            '    .Where(.SecondaryRecType <> "Furnaces" Or .SecondaryRecType <> "Kilns/Dryers" Or .SecondaryRecType <> "Proc. Piping (Not Steam)")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2) = "14")
            'End With

            zRecQry.UnionAll(zRecQry1)

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_NSR0() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            Dim zRecQry1 As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            'With zRecQry
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress" Or .RecStatus = "Rptd Completed")
            '    .Where(.PrimaryRecType = "BCP" Or .PrimaryRecType = "Critical Spares")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            'End With

            'With zRecQry1
            '    .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress" Or .RecStatus = "Rptd Completed")
            '    .Where(.PrimaryRecType.In("Boilers Pres.Vess Tanks", "Computer Systems", "Electrical Systems", "Mechanical Prev./Pred. Maint.", "Mechanical Systems", "Production/Process Equipment"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05"))
            'End With

            zRecQry.UnionAll(zRecQry1)

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_NSR10() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            Dim zRecQry1 As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            With zRecQry
                '.Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress" Or .RecStatus = "Rptd Completed")
                '.Where(.PrimaryRecType.In("Boilers Pres.Vess Tanks", "Computer Systems", "Electrical Systems", "Mechanical Prev./Pred. Maint.", "Mechanical Systems", "Production/Process Equipment"))
                '.Where(.RecKeyWords.NotLike("%RSBP%"))
                '.Where(.LossExpectancyBefore.Substring(2).In("07", "08", "09", "10", "11", "12", "13"))
            End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_NSR5() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            Dim zRecQry1 As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            With zRecQry
                '.Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress" Or .RecStatus = "Rptd Completed")
                '.Where(.PrimaryRecType.In("Boilers Pres.Vess Tanks", "Computer Systems", "Electrical Systems", "Mechanical Prev./Pred. Maint.", "Mechanical Systems", "Production/Process Equipment"))
                '.Where(.RecKeyWords.NotLike("%RSBP%"))
                '.Where(.LossExpectancyBefore.Substring(2).In("06"))
            End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_OTO() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            With zRecQry
                '.Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
                '.Where(.PrimaryRecType.In("Human Element"))
                '.Where(.RecKeyWords.NotLike("%RSBP%"))
            End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_BM_RSBP() As DataTable

            Dim zRecQry As BusinessObjects.BMRecommendationsQuery = BoilerBaseQry()
            With zRecQry
                '.Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
                '.Where(.RecKeyWords.Like("%RSBP%"))
            End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_Cim() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()
            With zRecQry
                '.Where(.RecStatus.In("Outstanding", "In Progress"))
                '.Where(.PrimaryRecType = "Human Element")
                '.Where(.SecondaryRecType.In("Impairments", "Mgmt. of Change"))
                '.Where(.RecKeyWords.NotLike("%RSBP%"))
                '.Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_Ecro() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()
            Dim zRecQry1 As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress"))
            '    .Where(.PrimaryRecType = "BCP")
            '    .Where(.SecondaryRecType.In("BCP/DRP"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With


            'With zRecQry1
            '    .Where(.RecStatus.In("Outstanding", "In Progress"))
            '    .Where(.PrimaryRecType = "Human Element")
            '    .Where(.SecondaryRecType.In("Emerg. Response"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With

            zRecQry.UnionAll(zRecQry1)

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_Isc() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress"))
            '    .Where(.PrimaryRecType = "Human Element")
            '    .Where(.SecondaryRecType.In("Hot Work", "IR Testing", "Smoking Controls"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_Itp() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress"))
            '    .Where(.PrimaryRecType = "Human Element")
            '    .Where(.SecondaryRecType.In("Comb. Safety Testing", "Other HE", "Other Maint/Testing", "Self-Inspections", "Sprink/Supply Testing"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_NPR0() As DataTable
            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()
            Dim zRecQry1 As BusinessObjects.FireRecommendationsQuery = FireBaseQry()
            Dim zRecQry2 As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress", "Rptd Completed"))
            '    .Where(.PrimaryRecType = "Human Element")
            '    .Where(.SecondaryRecType.In("Watch Service"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With


            'With zRecQry1
            '    .Where(.RecStatus.In("Outstanding", "In Progress", "Rptd Completed"))
            '    .Where(.PrimaryRecType = "Surveillance")
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With

            'With zRecQry2
            '    .Where(.RecStatus.In("Outstanding", "In Progress", "Rptd Completed"))
            '    .Where(.PrimaryRecType.In("Water Supply", "Manual Prot.", "Nat. Haz/Exp.", "Spec. Hazards", "Sprinklers"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With

            zRecQry1.UnionAll(zRecQry2)
            zRecQry.UnionAll(zRecQry1)

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_NPR10() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress", "Rptd Completed"))
            '    .Where(.PrimaryRecType.In("Manual Prot.", "Nat. Haz/Exp.", "Spec. Hazards", "Sprinklers", "Water Supply", "Human Element"))
            '    ''  .Where(.SecondaryRecType.In("Comb. Safety Testing", "Other HE", "Other Maint/Testing", "Self-Inspections", "Sprink/Supply Testing"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("07", "08", "09", "10", "11", "12", "13"))
            'End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_NPR5() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress", "Rptd Completed"))
            '    .Where(.PrimaryRecType.In("Manual Prot.", "Nat. Haz/Exp.", "Spec. Hazards", "Sprinklers", "Water Supply", "Human Element", "Surveillance"))
            '    ''  .Where(.SecondaryRecType.In("Comb. Safety Testing", "Other HE", "Other Maint/Testing", "Self-Inspections", "Sprink/Supply Testing"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("06"))
            'End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_OOA() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()

            'With zRecQry
            '    .Where(.RecStatus.In("Outstanding", "In Progress"))
            '    .Where(.PrimaryRecType.In("Human Element"))
            '    .Where(.SecondaryRecType.In("Housekeeping", "Storage Configuration"))
            '    .Where(.RecKeyWords.NotLike("%RSBP%"))
            '    .Where(.LossExpectancyBefore.Substring(2).In("01", "02", "03", "04", "05", "14"))
            'End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Qor_Fire_RSBP() As DataTable

            Dim zRecQry As BusinessObjects.FireRecommendationsQuery = FireBaseQry()
            With zRecQry
                .Where(.RecStatus = "Outstanding" Or .RecStatus = "In Progress")
                .Where(.RecKeyWords.Like("%RSBP%"))
            End With

            Return zRecQry.LoadDataTable

        End Function

        Public Shared Function Fire_Recommendations(ByVal pFilePrefix As String) As DataTable

            Dim zObj As New FireRecommendationsQuery
            Dim zCol As New FireRecommendationsCollection

            Dim zTable As DataTable = Nothing
            zObj.SelectAllExcept(zObj.RecYear, zObj.RecNumber, zObj.RecMonth, zObj.RecSubletter)
            zObj.Select(zObj.RecYear.Coalesce("''"), zObj.RecNumber.Coalesce("''"), zObj.RecMonth.Coalesce("''"), zObj.RecSubletter.Coalesce("''"))
            zObj.Where(zObj.RecStatus.ToLower.NotIn("removed", "conf completed"))
            zObj.Where(zObj.FileNo.Like(Int(pFilePrefix) & "%"))
            zObj.OrderBy(zObj.RecYear.Ascending, zObj.RecMonth.Ascending, zObj.RecNumber.Ascending, zObj.RecSubletter.Ascending)
            zCol.Load(zObj)
            zTable = zObj.LoadDataTable

            Return zTable

        End Function

        Public Shared Function Boiler_Recommendations(ByVal pFilePrefix As String) As DataTable

            Dim zObj As New BMRecommendationsQuery
            Dim zCol As New BMRecommendationsCollection

            Dim zTable As DataTable = Nothing
            zObj.SelectAll()
            zObj.Where(zObj.FileNo.Like(Int(pFilePrefix) & "%"))
            zObj.Where(zObj.RecStatus.ToLower.NotIn("removed", "conf completed"))

            zCol.Load(zObj)
            zTable = zObj.LoadDataTable

            Return zTable

        End Function

        Public Shared Function FireFacilityRatingKey(ByVal pFilePrefix As String) As DataTable
            Dim zRatingKeyId As Integer = UtilRating.GetRatingID(pFilePrefix, UtilPractice.PracticeEnum.Fire)
            Dim zRatingKeyQry As New Core.BusinessObjects.ViewCCReportRatingKeyQuery
            zRatingKeyQry.SelectAll()
            zRatingKeyQry.Where(zRatingKeyQry.RatingKeyID = zRatingKeyId)
            Return zRatingKeyQry.LoadDataTable
        End Function

        Public Shared Function BoilerFacilityRatingKey(ByVal pFilePrefix As String) As DataTable
            Dim zRatingKeyId As Integer = UtilRating.GetRatingID(pFilePrefix, UtilPractice.PracticeEnum.BM)
            Dim zRatingKeyQry As New Core.BusinessObjects.ViewCCReportRatingKeyQuery
            zRatingKeyQry.SelectAll()
            zRatingKeyQry.Where(zRatingKeyQry.RatingKeyID = zRatingKeyId)
            Return zRatingKeyQry.LoadDataTable
        End Function



    End Class


End Class

