Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilCarousel

    'Public Shared Function GetAllCarouselStats(pFilePrefix As String, pGSafeGuid As String) As Dictionary(Of String, Object)
    '    Dim zReturn As New List(Of Object)
    '    Dim zDict As New Dictionary(Of String, Object)
    '    Dim zQ As New razor.queryViewCCGaugeStats
    '    zQ.SelectAll()
    '    zQ.Where.Add(zQ.colFilePrefix.Equals(pFilePrefix))
    '    zQ.Where.Add(zQ.colGSafeGUID.Equals(pGSafeGuid))

    '    Dim zList As New List(Of razor.rowViewCCGaugeStats)
    '    zList = razor.ViewCCGaugeStats.LoadData(zQ.QueryText)

    '    If zList.Count > 0 Then
    '        'Build Fire Dictionary
    '        Dim zDictFire As New Dictionary(Of String, Object)
    '        zDictFire.Add("FireInspectionsDue", zList(0).colFireInspectionsDue)
    '        zDictFire.Add("FireInspectionsComplete", zList(0).colFireInspectionsComplete)
    '        zDictFire.Add("FireInspectionsPending", zList(0).colFireInspectionsPending)
    '        zDictFire.Add("FireInspectionsCancelled", zList(0).colFireInspectionsCancelled)

    '        'Build BM Dictionary
    '        Dim zDictBM As New Dictionary(Of String, Object)
    '        zDictBM.Add("BMInspectionsDue", zList(0).colBMInspectionsDue)
    '        zDictBM.Add("BMInspectionsComplete", zList(0).colBMInspectionsComplete)
    '        zDictBM.Add("BMInspectionsPending", zList(0).colBMInspectionsPending)
    '        zDictBM.Add("BMInspectionsCancelled", zList(0).colBMInspectionsCancelled)

    '        'Build IR Dictionary
    '        Dim zDictIR As New Dictionary(Of String, Object)
    '        zDictIR.Add("IRInspectionsDue", zList(0).colIRInspectionsDue)
    '        zDictIR.Add("IRInspectionsComplete", zList(0).colIRInspectionsComplete)
    '        zDictIR.Add("IRInspectionsPending", zList(0).colIRInspectionsPending)
    '        zDictIR.Add("IRInspectionsCancelled", zList(0).colIRInspectionsCancelled)

    '        'Build Wind Dictionary
    '        Dim zDictWind As New Dictionary(Of String, Object)
    '        zDictWind.Add("WindInspectionsDue", zList(0).colWindInspectionsDue)
    '        zDictWind.Add("WindInspectionsComplete", zList(0).colWindInspectionsComplete)
    '        zDictWind.Add("WindInspectionsPending", zList(0).colWindInspectionsPending)
    '        zDictWind.Add("WindInspectionsCancelled", zList(0).colWindInspectionsCancelled)

    '        'Build Seismic Dictionary
    '        Dim zDictSeismic As New Dictionary(Of String, Object)
    '        zDictSeismic.Add("SeismicInspectionsDue", zList(0).colSeismicInspectionsDue)
    '        zDictSeismic.Add("SeismicInspectionsComplete", zList(0).colSeismicInspectionsComplete)
    '        zDictSeismic.Add("SeismicInspectionsPending", zList(0).colSeismicInspectionsPending)
    '        zDictSeismic.Add("SeismicInspectionsCancelled", zList(0).colSeismicInspectionsCancelled)

    '        'Build Flood Dictionary
    '        Dim zDictFlood As New Dictionary(Of String, Object)
    '        zDictFlood.Add("FloodInspectionsDue", zList(0).colFloodInspectionsDue)
    '        zDictFlood.Add("FloodInspectionsComplete", zList(0).colFloodInspectionsComplete)
    '        zDictFlood.Add("FloodInspectionsPending", zList(0).colFloodInspectionsPending)
    '        zDictFlood.Add("FloodInspectionsCancelled", zList(0).colFloodInspectionsCancelled)

    '        'Build Flood Dictionary
    '        Dim zDictJuris As New Dictionary(Of String, Object)
    '        zDictFlood.Add("JurisNoObjections", zList(0).colJurisNoObjections)
    '        zDictFlood.Add("JurisOpenViolations", zList(0).colJurisOpenViolations)
    '        zDictFlood.Add("JurisNoActiveObjections", zList(0).colJurisNoActiveObjections)




    '        'Build the top containers of the JSON
    '        zDict.Add("Fire", zDictFire)
    '        zDict.Add("Boiler & Machinery", zDictBM)
    '        zDict.Add("Infared", zDictIR)
    '        zDict.Add("Jurisdictional", zDictJuris)
    '        zDict.Add("NatHaz - Seismic", zDictSeismic)
    '        zDict.Add("NatHaz - Wind", zDictWind)
    '        zDict.Add("NatHaz - Flood", zDictFlood)
    '        'zDict.Add("Diversified Services", "No Data Yet")
    '    Else
    '        'zero rows returned from query
    '    End If

    '    Return zDict
    'End Function

    'Public Shared Function GetAllCarouselStats2(pGSafeGuid As String) As List(Of Object)
    '    Dim zReturn As New List(Of Object)
    '    Dim zGSafeId As Integer = CoreLib.UtilGSafe.GetId(pGSafeGuid)
    '    Dim zFilePrefix As String = CoreLib.UtilGSafe.GetValue(zGSafeId, CoreLib.UtilGSafe.KeyName.FilePreFix)

    '    Dim zQ As New razor.queryViewCCGaugeStats
    '    zQ.SelectAll()
    '    zQ.Where.Add(zQ.colFilePrefix.Equals(zFilePrefix))
    '    zQ.Where.Add(zQ.colGSafeGUID.Equals(pGSafeGuid))

    '    Dim zList As New List(Of razor.rowViewCCGaugeStats)
    '    zList = razor.ViewCCGaugeStats.LoadData(zQ.QueryText)

    '    If zList.Count > 0 Then
    '        'Query NavLink for the NavLinkUrl's for the practices
    '        Dim zQNav As New razor.queryTblNavLink
    '        zQNav.SelectAll()
    '        zQNav.Where.Add(zQNav.colNavConstant.BeginsWith("PageId_LocationListing"))

    '        Dim zListNav As New List(Of razor.rowTblNavLink)
    '        zListNav = razor.TblNavLink.LoadData(zQNav.QueryText)

    '        'Query MetaPractice for the practiceNameString, iconName, and practiceCode for the practices
    '        Dim zQMetaPractice As New razor.queryTblMetaPractice
    '        zQMetaPractice.SelectAll()

    '        Dim zListMetaPractice As New List(Of razor.rowTblMetaPractice)
    '        zListMetaPractice = razor.TblMetaPractice.LoadData(zQMetaPractice.QueryText)


    '        'Build Fire Dictionary
    '        Dim zDictFire As New Dictionary(Of String, Object)
    '        Dim zDictStatFire As New Dictionary(Of String, Object)
    '        Dim zListStatFire As New List(Of Object)

    '        zDictStatFire.Add("label", zList(0).colFireInpectionsDueLabel)
    '        zDictStatFire.Add("count", zList(0).colFireInspectionsDue)
    '        zDictStatFire.Add("filterId", zList(0).colFireInspectionsDueFilter)
    '        zDictStatFire.Add("practiceId", zList(0).colFireInpectionsDueStatisticId)
    '        zListStatFire.Add(zDictStatFire)
    '        zDictStatFire = New Dictionary(Of String, Object)

    '        zDictStatFire.Add("label", zList(0).colFireInpectionsCompletedLabel)
    '        zDictStatFire.Add("count", zList(0).colFireInspectionsComplete)
    '        zDictStatFire.Add("filterId", zList(0).colFireInspectionsCompleteFilter)
    '        zDictStatFire.Add("practiceId", zList(0).colFireInpectionsCompletedStatisticId)
    '        zListStatFire.Add(zDictStatFire)
    '        zDictStatFire = New Dictionary(Of String, Object)

    '        zDictStatFire.Add("label", zList(0).colFireInpectionsPendingLabel)
    '        zDictStatFire.Add("count", zList(0).colFireInspectionsPending)
    '        zDictStatFire.Add("filterId", zList(0).colFireInspectionsPendingFilter)
    '        zDictStatFire.Add("practiceId", zList(0).colFireInpectionsPendingStatisticId)
    '        zListStatFire.Add(zDictStatFire)
    '        zDictStatFire = New Dictionary(Of String, Object)

    '        zDictStatFire.Add("label", zList(0).colFireInpectionsCancelledLabel)
    '        zDictStatFire.Add("count", zList(0).colFireInspectionsCancelled)
    '        zDictStatFire.Add("filterId", zList(0).colFireInspectionsCancelledFilter)
    '        zDictStatFire.Add("practiceId", zList(0).colFireInpectionsCancelledStatisticId)
    '        zListStatFire.Add(zDictStatFire)

    '        zDictFire.Add("statistics", zListStatFire)
    '        zDictFire.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselFireLearnMoreURL))


    '        'Build BM Dictionary
    '        Dim zDictBM As New Dictionary(Of String, Object)
    '        Dim zDictStatBM As New Dictionary(Of String, Object)
    '        Dim zListStatBM As New List(Of Object)

    '        zDictStatBM.Add("label", zList(0).colBMInpectionsDueLabel)
    '        zDictStatBM.Add("count", zList(0).colBMInspectionsDue)
    '        zDictStatBM.Add("filterId", zList(0).colBMInspectionsDueFilter)
    '        zDictStatBM.Add("practiceId", zList(0).colBMInpectionsDueStatisticId)
    '        zListStatBM.Add(zDictStatBM)
    '        zDictStatBM = New Dictionary(Of String, Object)

    '        zDictStatBM.Add("label", zList(0).colBMInpectionsCompletedLabel)
    '        zDictStatBM.Add("count", zList(0).colBMInspectionsComplete)
    '        zDictStatBM.Add("filterId", zList(0).colBMInspectionsCompleteFilter)
    '        zDictStatBM.Add("practiceId", zList(0).colBMInpectionsCompletedStatisticId)
    '        zListStatBM.Add(zDictStatBM)
    '        zDictStatBM = New Dictionary(Of String, Object)

    '        zDictStatBM.Add("label", zList(0).colBMInpectionsPendingLabel)
    '        zDictStatBM.Add("count", zList(0).colBMInspectionsPending)
    '        zDictStatBM.Add("filterId", zList(0).colBMInspectionsPendingFilter)
    '        zDictStatBM.Add("practiceId", zList(0).colBMInpectionsPendingStatisticId)
    '        zListStatBM.Add(zDictStatBM)
    '        zDictStatBM = New Dictionary(Of String, Object)

    '        zDictStatBM.Add("label", zList(0).colBMInpectionsCancelledLabel)
    '        zDictStatBM.Add("count", zList(0).colBMInspectionsCancelled)
    '        zDictStatBM.Add("filterId", zList(0).colBMInspectionsCancelledFilter)
    '        zDictStatBM.Add("practiceId", zList(0).colBMInpectionsCancelledStatisticId)
    '        zListStatBM.Add(zDictStatBM)

    '        zDictBM.Add("statistics", zListStatBM)
    '        zDictBM.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselBMLearnMoreURL))


    '        'Build IR Dictionary
    '        Dim zDictIR As New Dictionary(Of String, Object)
    '        Dim zDictStatIR As New Dictionary(Of String, Object)
    '        Dim zListStatIR As New List(Of Object)

    '        zDictStatIR.Add("label", zList(0).colIRInpectionsDueLabel)
    '        zDictStatIR.Add("count", zList(0).colIRInspectionsDue)
    '        zDictStatIR.Add("filterId", zList(0).colIRInspectionsDueFilter)
    '        zDictStatIR.Add("practiceId", zList(0).colIRInpectionsDueStatisticId)
    '        zListStatIR.Add(zDictStatIR)
    '        zDictStatIR = New Dictionary(Of String, Object)

    '        zDictStatIR.Add("label", zList(0).colIRInpectionsCompletedLabel)
    '        zDictStatIR.Add("count", zList(0).colIRInspectionsComplete)
    '        zDictStatIR.Add("filterId", zList(0).colIRInspectionsCompleteFilter)
    '        zDictStatIR.Add("practiceId", zList(0).colIRInpectionsCompletedStatisticId)
    '        zListStatIR.Add(zDictStatIR)
    '        zDictStatIR = New Dictionary(Of String, Object)

    '        zDictStatIR.Add("label", zList(0).colIRInpectionsPendingLabel)
    '        zDictStatIR.Add("count", zList(0).colIRInspectionsPending)
    '        zDictStatIR.Add("filterId", zList(0).colIRInspectionsPendingFilter)
    '        zDictStatIR.Add("practiceId", zList(0).colIRInpectionsPendingStatisticId)
    '        zListStatIR.Add(zDictStatIR)
    '        zDictStatIR = New Dictionary(Of String, Object)

    '        zDictStatIR.Add("label", zList(0).colIRInpectionsCancelledLabel)
    '        zDictStatIR.Add("count", zList(0).colIRInspectionsCancelled)
    '        zDictStatIR.Add("filterId", zList(0).colIRInspectionsCancelledFilter)
    '        zDictStatIR.Add("practiceId", zList(0).colIRInpectionsCancelledStatisticId)
    '        zListStatIR.Add(zDictStatIR)

    '        zDictIR.Add("statistics", zListStatIR)
    '        zDictIR.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselIRLearnMoreURL))


    '        'Build NatHaz Dictionary
    '        Dim zDictNatHaz As New Dictionary(Of String, Object)
    '        Dim zDictStatNatHaz As New Dictionary(Of String, Object)
    '        Dim zListStatNatHaz As New List(Of Object)

    '        zDictStatNatHaz.Add("label", zList(0).colNatHazInpectionsDueLabel)
    '        zDictStatNatHaz.Add("count", zList(0).colNatHazInspectionsDue)
    '        zDictStatNatHaz.Add("filterId", zList(0).colNatHazInspectionsDueFilter)
    '        zDictStatNatHaz.Add("practiceId", zList(0).colNatHazInpectionsDueStatisticId)
    '        zListStatNatHaz.Add(zDictStatNatHaz)
    '        zDictStatNatHaz = New Dictionary(Of String, Object)

    '        zDictStatNatHaz.Add("label", zList(0).colNatHazInpectionsCompletedLabel)
    '        zDictStatNatHaz.Add("count", zList(0).colNatHazInspectionsComplete)
    '        zDictStatNatHaz.Add("filterId", zList(0).colNatHazInspectionsCompleteFilter)
    '        zDictStatNatHaz.Add("practiceId", zList(0).colNatHazInpectionsCompletedStatisticId)
    '        zListStatNatHaz.Add(zDictStatNatHaz)
    '        zDictStatNatHaz = New Dictionary(Of String, Object)

    '        zDictStatNatHaz.Add("label", zList(0).colNatHazInpectionsPendingLabel)
    '        zDictStatNatHaz.Add("count", zList(0).colNatHazInspectionsPending)
    '        zDictStatNatHaz.Add("filterId", zList(0).colNatHazInspectionsPendingFilter)
    '        zDictStatNatHaz.Add("practiceId", zList(0).colNatHazInpectionsPendingStatisticId)
    '        zListStatNatHaz.Add(zDictStatNatHaz)
    '        zDictStatNatHaz = New Dictionary(Of String, Object)

    '        zDictStatNatHaz.Add("label", zList(0).colNatHazInpectionsCancelledLabel)
    '        zDictStatNatHaz.Add("count", zList(0).colNatHazInspectionsCancelled)
    '        zDictStatNatHaz.Add("filterId", zList(0).colNatHazInspectionsCancelledFilter)
    '        zDictStatNatHaz.Add("practiceId", zList(0).colNatHazInpectionsCancelledStatisticId)
    '        zListStatNatHaz.Add(zDictStatNatHaz)

    '        zDictNatHaz.Add("statistics", zListStatNatHaz)
    '        zDictNatHaz.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselNatHazLearnMoreURL))

    '        'Build Juris Dictionary
    '        Dim zDictJuris As New Dictionary(Of String, Object)
    '        Dim zDictStatJuris As New Dictionary(Of String, Object)
    '        Dim zListStatJuris As New List(Of Object)

    '        zDictStatJuris.Add("label", zList(0).colJurisObjectsLabel)
    '        zDictStatJuris.Add("count", zList(0).colJurisNoObjections)
    '        zDictStatJuris.Add("practiceId", zList(0).colJurisObjectsStatisticId)
    '        zDictStatJuris.Add("filterId", zList(0).colJurisObjectsFilter)
    '        zListStatJuris.Add(zDictStatJuris)
    '        zDictStatJuris = New Dictionary(Of String, Object)

    '        zDictStatJuris.Add("label", zList(0).colJurisActiveObjectsLabel)
    '        zDictStatJuris.Add("count", zList(0).colJurisNoActiveObjections)
    '        zDictStatJuris.Add("practiceId", zList(0).colJurisActiveObjectsStatisticId)
    '        zDictStatJuris.Add("filterId", zList(0).colJurisActiveObjectsFilter)
    '        zListStatJuris.Add(zDictStatJuris)
    '        zDictStatJuris = New Dictionary(Of String, Object)

    '        zDictStatJuris.Add("label", zList(0).colJurisOpenRecommendationsLabel)
    '        zDictStatJuris.Add("count", zList(0).colJurisOpenViolations)
    '        zDictStatJuris.Add("practiceId", zList(0).colJurisOpenRecommendationsStatisticId)
    '        zDictStatJuris.Add("filterId", zList(0).colJurisOpenRecommendationsFilter)
    '        zListStatJuris.Add(zDictStatJuris)

    '        zDictJuris.Add("statistics", zListStatJuris)
    '        zDictJuris.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselJurisLearnMoreURL))


    '        'Build DivServ Dictionary
    '        Dim zDictDivServ As New Dictionary(Of String, Object)
    '        Dim zDictStatDivServ As New Dictionary(Of String, Object)
    '        Dim zListStatDivServ As New List(Of Object)

    '        zDictStatDivServ.Add("label", zList(0).colDivServInpectionsDueLabel)
    '        zDictStatDivServ.Add("count", zList(0).colDivServInspectionsDue)
    '        zDictStatDivServ.Add("filterId", zList(0).colDivServInspectionsDueFilter)
    '        zDictStatDivServ.Add("practiceId", zList(0).colDivServInpectionsDueStatisticId)
    '        zListStatDivServ.Add(zDictStatDivServ)
    '        zDictStatDivServ = New Dictionary(Of String, Object)

    '        zDictStatDivServ.Add("label", zList(0).colDivServInpectionsCompletedLabel)
    '        zDictStatDivServ.Add("count", zList(0).colDivServInspectionsComplete)
    '        zDictStatDivServ.Add("filterId", zList(0).colDivServInspectionsCompleteFilter)
    '        zDictStatDivServ.Add("practiceId", zList(0).colDivServInpectionsCompletedStatisticId)
    '        zListStatDivServ.Add(zDictStatDivServ)
    '        zDictStatDivServ = New Dictionary(Of String, Object)

    '        zDictStatDivServ.Add("label", zList(0).colDivServInpectionsPendingLabel)
    '        zDictStatDivServ.Add("count", zList(0).colDivServInspectionsPending)
    '        zDictStatDivServ.Add("filterId", zList(0).colDivServInspectionsPendingFilter)
    '        zDictStatDivServ.Add("practiceId", zList(0).colDivServInpectionsPendingStatisticId)
    '        zListStatDivServ.Add(zDictStatDivServ)
    '        zDictStatDivServ = New Dictionary(Of String, Object)

    '        zDictStatDivServ.Add("label", zList(0).colDivServInpectionsCancelledLabel)
    '        zDictStatDivServ.Add("count", zList(0).colDivServInspectionsCancelled)
    '        zDictStatDivServ.Add("filterId", zList(0).colDivServInspectionsCancelledFilter)
    '        zDictStatDivServ.Add("practiceId", zList(0).colDivServInpectionsCancelledStatisticId)
    '        zListStatDivServ.Add(zDictStatDivServ)

    '        zDictDivServ.Add("statistics", zListStatDivServ)
    '        zDictDivServ.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselDSLearnMoreURL))




    '        'Build PS Dictionary
    '        Dim zDictPS As New Dictionary(Of String, Object)
    '        Dim zDictStatPS As New Dictionary(Of String, Object)
    '        Dim zListStatPS As New List(Of Object)

    '        zDictStatPS.Add("label", zList(0).colPSInpectionsDueLabel)
    '        zDictStatPS.Add("count", zList(0).colPSInspectionsDue)
    '        zDictStatPS.Add("filterId", zList(0).colPSInspectionsDueFilter)
    '        zDictStatPS.Add("practiceId", zList(0).colPSInpectionsDueStatisticId)
    '        zListStatPS.Add(zDictStatPS)
    '        zDictStatPS = New Dictionary(Of String, Object)

    '        zDictStatPS.Add("label", zList(0).colPsInpectionsCompletedLabel)
    '        zDictStatPS.Add("count", zList(0).colPSInspectionsComplete)
    '        zDictStatPS.Add("filterId", zList(0).colPSInspectionsCompleteFilter)
    '        zDictStatPS.Add("practiceId", zList(0).colPSInpectionsCompletedStatisticId)
    '        zListStatPS.Add(zDictStatPS)
    '        zDictStatPS = New Dictionary(Of String, Object)

    '        zDictStatPS.Add("label", zList(0).colPSInpectionsPendingLabel)
    '        zDictStatPS.Add("count", zList(0).colPSInspectionsPending)
    '        zDictStatPS.Add("filterId", zList(0).colPSInspectionsPendingFilter)
    '        zDictStatPS.Add("practiceId", zList(0).colPSInpectionsPendingStatisticId)
    '        zListStatPS.Add(zDictStatPS)
    '        zDictStatPS = New Dictionary(Of String, Object)

    '        zDictStatPS.Add("label", zList(0).colPSInpectionsCancelledLabel)
    '        zDictStatPS.Add("count", zList(0).colPSInspectionsCancelled)
    '        zDictStatPS.Add("filterId", zList(0).colPSInspectionsCancelledFilter)
    '        zDictStatPS.Add("practiceId", zList(0).colPSInpectionsCancelledStatisticId)
    '        zListStatPS.Add(zDictStatPS)

    '        zDictPS.Add("statistics", zListStatPS)
    '        zDictPS.Add("pdfFullPath", UtilSetting.GetValue(UtilSetting.Keys.CarouselPSLearnMoreURL))




    '        'Add NavLinkUrl's from NavLink data pull to their appropriate dictionaries
    '        For Each zItem As razor.rowTblNavLink In zListNav
    '            Select Case zItem.colNavLinkId
    '                Case CoreLib.UtilConstants.PageId_LocationListing_Fire
    '                    zDictFire.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case CoreLib.UtilConstants.PageId_LocationListing_Boiler
    '                    zDictBM.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case CoreLib.UtilConstants.PageId_LocationListing_Infrared
    '                    zDictIR.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case CoreLib.UtilConstants.PageId_LocationListing_Juris
    '                    zDictJuris.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case CoreLib.UtilConstants.PageId_LocationListing_NatHaz
    '                    zDictNatHaz.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case CoreLib.UtilConstants.PageId_LocationListing_DivServ
    '                    zDictDivServ.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case CoreLib.UtilConstants.PageId_LocationListing_PS
    '                    zDictPS.Add("navLinkUrl", CoreLib.UtilURL.BuildLeftNavURL(zItem.colNavLinkId, zItem.colNavUrl, pGSafeGuid))
    '                Case Else
    '                    'zItem.colNavLinkId was not matched
    '            End Select
    '        Next

    '        'Add practiceNameString, iconName, and practiceCode from tblMetaPractice data pull to their appropriate dictionaries
    '        Dim zNatHazAlreadyLoaded As Boolean = False
    '        For Each zItem As razor.rowTblMetaPractice In zListMetaPractice
    '            Select Case zItem.colFldPracticeCode
    '                Case "520"  'Fire
    '                    zDictFire.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictFire.Add("iconName", zItem.colFldIconName)
    '                    zDictFire.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case "510"  'Boiler & Machinery
    '                    zDictBM.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictBM.Add("iconName", zItem.colFldIconName)
    '                    zDictBM.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case "530"  'Infrared
    '                    zDictIR.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictIR.Add("iconName", zItem.colFldIconName)
    '                    zDictIR.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case "560"  'Jurisdictional
    '                    zDictJuris.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictJuris.Add("iconName", zItem.colFldIconName)
    '                    zDictJuris.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case "540"  'Diversified Services
    '                    zDictDivServ.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictDivServ.Add("iconName", zItem.colFldIconName)
    '                    zDictDivServ.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case "550"
    '                    zDictNatHaz.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictNatHaz.Add("iconName", zItem.colFldIconName)
    '                    zDictNatHaz.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case "570"
    '                    zDictPS.Add("practiceCode", zItem.colFldPracticeCode)
    '                    zDictPS.Add("iconName", zItem.colFldIconName)
    '                    zDictPS.Add("practiceNameString", zItem.colFldPracticeNameHTML)

    '                Case Else
    '                    'zItem.colFldPracticeCode was not matched
    '            End Select
    '        Next

    '        'Build the top containers of the JSON
    '        zReturn.Add(zDictFire)
    '        zReturn.Add(zDictBM)
    '        zReturn.Add(zDictIR)
    '        zReturn.Add(zDictJuris)
    '        zReturn.Add(zDictNatHaz)
    '        zReturn.Add(zDictDivServ)
    '        zReturn.Add(zDictPS)
    '    Else
    '        'zero rows returned from query
    '    End If

    '    Return zReturn
    'End Function

End Class
