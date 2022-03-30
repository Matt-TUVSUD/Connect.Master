Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Public Class UtilPractice

    ' SET THE PRACTICE LOCATION LISTINGS
    Public Shared Sub SetFirePractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.Fire, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetBoilerPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, BoilerProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Boiler, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Boiler, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.BM, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetIRPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, InfraredProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Infrared, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Infrared, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.Infrared, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetJurisPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, JurisdictionalProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Juris, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Juris, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.Jurisdictional, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetSeismicPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazSeismicProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Seismic, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Seismic, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.NatHazSeismic, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetWindPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazWindProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Wind, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Wind, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.NatHazWind, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetFloodPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazFloodProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_Flood, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Flood, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.NatHazFlood, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetDiversifiedPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, DiversifiedProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_DivServ, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_DivServ, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.DiversifiedServices, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetNatHazPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NaturalHazardsProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_NatHaz, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_NatHaz, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.NaturalHazards, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetPSPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, ProcessSafetyProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationListing_PS, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_PS, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.ProcessSafety, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    ' SET THE LOCATION DETAILS PAGES
    Public Shared Sub SetPSDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, ProcessSafetyProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_PS, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_PS, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetFireDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.Fire, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetBoilerDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, BoilerProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Boiler, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Boiler, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.BM, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetIRDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, InfraredProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Infrared, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Infrared, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.Infrared, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetJurisDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, JurisdictionalProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Juris, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Juris, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.Jurisdictional, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetSeismicDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazSeismicProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Seismic, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Seismic, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetWindDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazWindProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Wind, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Wind, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetFloodDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazFloodProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_Flood, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Flood, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetDiversifiedDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, DiversifiedProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_DivServ, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_DivServ, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.DiversifiedServices, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    Public Shared Sub SetNaturalHazardsDetailsPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NaturalHazardsProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_LocationDetails_NatHaz, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_NatHaz, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.MetaPracticeId, razor.TblMetaPractice.Practices.NaturalHazards, UtilGSafe.KeyNameGroup.Navigation)

    End Sub

    ' SET THE FACILITY RATINGS PAGES
    Public Shared Sub SetFireFacilityRatingPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_FacilityRating_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetBoilerFacilityRatingPractice(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, BoilerProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_FacilityRating_Boiler, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Boiler, UtilGSafe.KeyNameGroup.Navigation)
    End Sub


    ' SET THE RECOMMENDATION TRACKING PAGES
    Public Shared Sub SetPSRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, ProcessSafetyProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_PS, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_PS, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetFireRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetFireRecommendationTracking_FeatureX(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Fire_Feature_X, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetBoilerRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, BoilerProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Boiler, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Boiler, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetIRRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, InfraredProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Infrared, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Infrared, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetSeismicRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazSeismicProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Seismic, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Seismic, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetWindRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazWindProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Wind, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Wind, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetFloodRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NatHazFloodProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_Flood, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Flood, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    Public Shared Sub SetNaturalHazardsRecommendationTracking(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, NaturalhazardsProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_RecommendationTracking_NatHaz, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_NatHaz, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    ' SET THE C.O.P.E. PAGES
    Public Shared Sub SetFireCOPE(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_COPE_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    ' SET THE IMPAIRMENTS PAGES
    Public Shared Sub SetFireImpairments(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, FireProgramName, UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_Impairments_Fire, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Fire, UtilGSafe.KeyNameGroup.Navigation)
    End Sub

    ' SET THE SITEMAP PAGES
    Public Shared Sub SetSiteMapTitle(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PageTitle, "Interactive Site Map Navigation", UtilGSafe.KeyNameGroup.PageHeader)
    End Sub

    Public Shared Sub SetAllDataTitle(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PageTitle, "All Data Extracts", UtilGSafe.KeyNameGroup.PageHeader)
    End Sub

    Public Shared Sub SetAllReportsTitle(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PageTitle, "Batch Reports Tool", UtilGSafe.KeyNameGroup.PageHeader)
    End Sub

    ' SET THE PROGRAM STATUS PAGE
    Public Shared Sub SetProgramStatus(ByVal pSafeGUID As String)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.practiceName, "", UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.PageTitle, "Interactive Program Status", UtilGSafe.KeyNameGroup.PageHeader)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentPage, PageId_ProgramStatusForm, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGUID, UtilGSafe.KeyName.currentTab, PageId_Gauge, UtilGSafe.KeyNameGroup.Navigation)
    End Sub




    ' FOLDER NAME OF PRACTICE
    Public Shared Function GetPracticeFolderName(ByVal pCurrentPractice As String) As String
        Dim zReturn As String = ""

        Select Case pCurrentPractice
            Case PageId_Fire
                zReturn = "Fire"
            Case PageId_Boiler
                zReturn = "Boiler"
            Case PageId_Juris
                zReturn = "Jurisdictional"
            Case PageId_Infrared
                zReturn = "Infrared"
            Case PageId_Seismic
                zReturn = "Seismic"
            Case PageId_Flood
                zReturn = "Flood"
            Case PageId_Wind
                zReturn = "Wind"
            Case PageId_DivServ
                zReturn = "Diversified"
            Case PageId_NatHaz
                zReturn = "NaturalHazards"
            Case PageId_PS
                zReturn = "ProcessSafety"
            Case Else
                zReturn = "Gauge"
        End Select

        Return zReturn

    End Function

    ' BACKGROUND IMAGE TO SIDE NAV
    Public Shared Function GetNavPracticeImage(ByVal pCurrentPractice As String) As String
        Dim zStyle As String = ""

        Select Case pCurrentPractice
            Case PageId_Fire
                zStyle = "url('../../Home_{{VER}}/images/fire/navbackground.png')"
            Case PageId_Boiler
                zStyle = "url('../../Home_{{VER}}/images/boiler/navbackground.png')"
            Case PageId_Juris
                zStyle = "url('../../Home_{{VER}}/images/juris/navbackground.png')"
            Case PageId_Infrared
                zStyle = "url('../../Home_{{VER}}/images/infrared/navbackground.png')"
            Case PageId_Seismic
                zStyle = "url('../../Home_{{VER}}/images/natural/navbackground.png')"
            Case PageId_Flood
                zStyle = "url('../../Home_{{VER}}/images/natural/navbackground.png')"
            Case PageId_Wind
                zStyle = "url('../../Home_{{VER}}/images/natural/navbackground.png')"
            Case PageId_DivServ
                zStyle = "url('../../Home_{{VER}}/images/diversified/navbackground.png')"
            Case PageId_NatHaz
                zStyle = "url('../../Home_{{VER}}/images/natural/navbackground.png')"
            Case PageId_PS
                zStyle = "url('../../Home_{{VER}}/images/processsafety/navbackground.png')"
            Case Else
                zStyle = "url('../../Home_{{VER}}/images/fire/navbackground.png')"
        End Select

        Return zStyle

    End Function

    Public Shared Function GetPracticeCodes(ByVal pPracticeEnum As PracticeEnum, IncludeSpecialEvaluationCode As Boolean) As List(Of Integer)

        Dim zCode As New List(Of Integer)

        Select Case pPracticeEnum

            Case PracticeEnum.Fire
                zCode.Add(520)
                If IncludeSpecialEvaluationCode Then zCode.Add(525)

            Case PracticeEnum.BM
                zCode.Add(510)
                If IncludeSpecialEvaluationCode Then zCode.Add(515)

            Case PracticeEnum.Infrared
                zCode.Add(530)
                If IncludeSpecialEvaluationCode Then zCode.Add(535)

            Case PracticeEnum.Jurisdictional
                zCode.Add(560)
                If IncludeSpecialEvaluationCode Then zCode.Add(565)

            Case PracticeEnum.NatHazFlood
                zCode.Add(526)

            Case PracticeEnum.NatHazSeismic
                zCode.Add(526)

            Case PracticeEnum.NatHazWind
                zCode.Add(526)

            Case PracticeEnum.DivServ
                zCode.Add(540)

            Case PracticeEnum.NaturalHazards
                zCode.Add(550)

            Case PracticeEnum.ProcessSafety
                zCode.Add(570)

            Case Else
                zCode.Add(9999)

        End Select

        Return zCode

    End Function

    ' Enum Practices -DB
    Public Enum PracticeEnum
        Fire = 1
        BM = 2
        Jurisdictional = 3
        Infrared = 4
        NatHazFlood = 5
        NatHazSeismic = 6
        NatHazWind = 7
        NonSpecific = 9
        DivServ = 10
        NaturalHazards = 11
        ProcessSafety = 12
    End Enum

    Public Shared Function ConvertLong2ShortPracticeName(pPracticeLongName As String) As String
        Dim zReturn As String = ""
        'Note: used to decode/fix the values in the RptDef.Practice table column

        Select Case pPracticeLongName
            Case "Infrared"
                zReturn = UtilPractice.IR
            Case "Jurisdictional"
                zReturn = UtilPractice.Juris
            Case "NatHazFlood"
                zReturn = UtilPractice.Flood
            Case "NatHazSeismic"
                zReturn = UtilPractice.Seismic
            Case "NatHazWind"
                zReturn = UtilPractice.Wind
            Case Else
                zReturn = pPracticeLongName
        End Select
        Return zReturn
    End Function

    Public Shared ReadOnly Property FireProgramName As String
        Get
            Return "Fire Program"
        End Get
    End Property

    Public Shared ReadOnly Property BoilerProgramName As String
        Get
            Return "Boiler & Machinery Program"
        End Get
    End Property

    Public Shared ReadOnly Property JurisdictionalProgramName As String
        Get
            Return "Jurisdictional Program"
        End Get
    End Property

    Public Shared ReadOnly Property InfraredProgramName As String
        Get
            Return "Infrared Program"
        End Get
    End Property

    Public Shared ReadOnly Property NatHazFloodProgramName As String
        Get
            Return "Flood Program"
        End Get
    End Property

    Public Shared ReadOnly Property NatHazWindProgramName As String
        Get
            Return "Wind Program"
        End Get
    End Property

    Public Shared ReadOnly Property NatHazSeismicProgramName As String
        Get
            Return "Seismic Program"
        End Get
    End Property

    Public Shared ReadOnly Property DiversifiedProgramName As String
        Get
            Return "Diversified Services Program"
        End Get
    End Property

    Public Shared ReadOnly Property NaturalHazardsProgramName As String
        Get
            Return "Natural Hazards Program"
        End Get
    End Property

    Public Shared ReadOnly Property ProcessSafetyProgramName As String
        Get
            Return "Process Safety Program"
        End Get
    End Property

    Public Shared Sub SetPractice(ByVal pGuid As String, ByVal pPractice As PracticeEnum)
        Select Case pPractice

            Case PracticeEnum.Fire
                SetFirePractice(pGuid)

            Case PracticeEnum.BM
                SetBoilerPractice(pGuid)

            Case PracticeEnum.Infrared
                SetIRPractice(pGuid)

            Case PracticeEnum.Jurisdictional
                SetJurisPractice(pGuid)

            Case PracticeEnum.NatHazSeismic
                SetSeismicPractice(pGuid)

            Case PracticeEnum.NatHazFlood
                SetFloodPractice(pGuid)

            Case PracticeEnum.NatHazWind
                SetWindPractice(pGuid)

            Case PracticeEnum.DivServ
                SetDiversifiedPractice(pGuid)

            Case PracticeEnum.NaturalHazards
                SetNatHazPractice(pGuid)
        End Select

    End Sub

    Public Shared Function HasPractice(ByVal pPractice As PracticeEnum, ByVal pFilePrefix As String) As Boolean

        If pPractice <> PracticeEnum.Jurisdictional Then
            Dim zCodes As List(Of Integer) = GetPracticeCodes(pPractice, True)
            Dim zQry As New BusinessObjects.GRIPSSWorkloadQuery
            Dim zCol As New BusinessObjects.GRIPSSWorkloadCollection

            zQry.SelectAll()
            zQry.Where(zQry.PracticeCode.In(zCodes))
            zQry.Where(zQry.FilePrefix = pFilePrefix)

            If zCol.Load(zQry) Then
                Return True
            Else
                Return False
            End If

        Else

            Dim zQry As New BusinessObjects.TblARISELocationsQuery
            Dim zCol As New BusinessObjects.TblARISELocationsCollection

            zQry.SelectAll()
            zQry.Where(zQry.FileNo.Like(pFilePrefix & "%"))

            If zCol.Load(zQry) Then
                Return True
            Else
                Return False
            End If

        End If

        Return False

    End Function

    Public Shared Function GetClientPractices(ByVal pFilePrefix As String) As List(Of PracticeEnum)
        Dim zPractEnum As System.Array = [Enum].GetValues(GetType(UtilPractice.PracticeEnum))
        Dim zPractices As New List(Of PracticeEnum)

        For Each zPractice As Integer In zPractEnum
            If HasPractice(zPractice, pFilePrefix) Then
                zPractices.Add(zPractice)
            End If
        Next

        Return zPractices

    End Function

    Public Shared Function BM() As String
        Return "BM"
    End Function

    Public Shared Function Fire() As String
        Return "Fire"
    End Function

    Public Shared Function Flood() As String
        Return "Flood"
    End Function

    Public Shared Function IR() As String
        Return "IR"
    End Function

    Public Shared Function Juris() As String
        Return "Juris"
    End Function

    Public Shared Function NatHaz() As String
        Return "NatHaz"
    End Function

    Public Shared Function Seismic() As String
        Return "Seismic"
    End Function

    Public Shared Function Wind() As String
        Return "Wind"
    End Function

    Public Shared Function DivServ() As String
        Return "DivServ"
    End Function

    Public Shared Function ProcSafety() As String
        Return "ProcSafety"
    End Function
    Public Shared Function GetPracticeName(ByVal pPractice As PracticeEnum) As String
        Select Case pPractice
            Case PracticeEnum.BM
                Return BM()

            Case PracticeEnum.Fire
                Return Fire()

            Case PracticeEnum.Infrared
                Return IR()

            Case PracticeEnum.Jurisdictional
                Return Juris()

            Case PracticeEnum.NatHazFlood
                Return Flood()

            Case PracticeEnum.NatHazSeismic
                Return Seismic()

            Case PracticeEnum.NatHazWind
                Return Wind()

            Case PracticeEnum.DivServ
                Return DivServ()

            Case PracticeEnum.NaturalHazards
                Return NatHaz()

            Case PracticeEnum.ProcessSafety
                Return ProcSafety()

            Case Else
                Return String.Empty

        End Select
    End Function


End Class
