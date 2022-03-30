Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports EntitySpaces.js


Namespace Contracts

    <ServiceContract> _
    Public Interface IRESTServer

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function JetStream(pJetProc As String, pJetData As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetGridData(skip As Integer, take As Integer, page As Integer, pageSize As Integer, sort As String, filter As String, criteria As String, gSafeGuid As String, pUserCurrencyId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetFormData(gSafeGuid As String, pUserCurrencyId As String, pFormFileNo As String, pUniqueId As String) As System.IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function SetFormReportData(gSafeGuid As String, pUserCurrencyId As String, pFormFileNo As String, pUniqueId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function FormReportHasParameters(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function IsEngineerReportAvailable(gSafeGuid As String, pFileNo As String, pPracticeId As Integer) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function IsDiagramReportAvailable(gSafeGuid As String, pFileNo As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetMapData(sort As String, filter As String, criteria As String, gSafeGuid As String, pDepictedByColumnName As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetMapShapeData(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetChartData(gSafeGuid As String, pIsDrillDown As Boolean) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetChartPagedData(gSafeGuid As String, pPage As Integer, pPageSize As String, pSort As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetChartTrendingPagedData(gSafeGuid As String, pPage As Integer, pPageSize As String, pSort As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SetChartFacilityPageData(gSafeGuid As String, pIsResetRequired As Boolean, pHTML As String, pCSS As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetGridMeta(gSafeGuid As String, pIsRebuildRequired As Boolean, pUserCurrencyId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetPickListData(gSafeGuid As String, columnName As String, filter As String, criteria As String, pUserCurrencyId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function ClearLocationNavigationInformation(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetGridFavoriteListByGrid(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function RenameGridFavorite(gSafeGuid As String, pId As Integer, pName As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function DeleteGridFavorite(gSafeGuid As String, pId As Integer) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SaveGridFavorite(gSafeGuid As String, pTitle As String, pColumnOrderSetting As String, pSort As String, pFilter As String, pCriteria As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SaveLargeObjectData(gSafeGuid As String, gridId As Integer, sort As String, filter As String, criteria As String, meta As String, columnOrder As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function ApplyMyPreference(gSafeGuid As String, pFileNoList As List(Of String), pFilterString As String, pCurrencyPreference As String, pUnitPreference As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SetBatchReportNavLink(gSafeGuid As String, pNavLinkList As List(Of String)) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SetBatchReportSettings(gSafeGuid As String, pFileName As String, pCurrencyPreference As String, pUnitPreference As String, pFilterString As String, pSortString As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetLargeObjectDataGrid(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetLargeObjectDataChart(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetRatingLegendChart(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetProgramStatusData(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetAutoRecStatusData(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetAdminUserGridData(gSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetAdminUserFormData(pEzyUserId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function RemoveEzyUser(pEzyUserId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function RemoveEzyLogin(pLoginId As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SaveUser(pJSON As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetUserByEmail(pEmail As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetUserReclassPractices(pGSafeGuid As String) As System.IO.Stream


        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetUserForm(pGSafeGuid As String, pNavigateAction As String, pEzyGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetUserReclassForm(pGSafeGuid As String, pNavigateAction As String, pEzyGuid As String, Optional pIsPendingOnly As String = "false", Optional pCurrentIndex As Integer = 1) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SaveUserAccountForm(pGSafeGuid As String, pJSON As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function SaveUserReclassForm(pGSafeGuid As String, pJSON As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function MarkClientAsCompleted(pGSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function ValidateAdminUserForm(pEmail As String, pFilePrefix As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function ResetPassword(pEmail As String, pPassword As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetLatLongGrid(pLatitude As String, pLongitude As String, pUnit As String, pRadius As String, pNameYourSearch As String, pSid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function AuthenticateLogin(pEmail As String, pPassword As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetAllMenuItems(pGSafeGuid As String, pPageType As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetPageMenuItems(pGSafeGuid As String) As System.IO.Stream

        '<OperationContract> _
        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        'Function GetPracticeMenuItems(pGSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetAllCarouselStats(pGSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetBatchNavLinks(pGSafeGuid As String) As System.IO.Stream

        <OperationContract> _
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Function GetTestForm(pGSafeGuid As String) As System.IO.Stream

        '<OperationContract> _
        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        'Function CreateLogin(pEmail As String, pPassword As String, pInternal As Boolean, pPasswordReminderSentFlag As Boolean) As System.IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Function SaveLocationLevelFireRecommendation(entity As VwFireRecommendationsBaseView) As jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView)

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Function GetLocationLevelFireRecommendations(parms As String) As jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView)

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetLocationLevelFireRatingAverages(pGSafeGuid As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Function GetLocationLevelFireRecByFileNo(pParms As String) As jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView)

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetMetaMenu(pGSafeGuid As String, pNode As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetRatingByRecLeData(pGSafeGuid As String, pGridFilterGuid As String, pMetaPracticeID As Integer) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetClientRatingRanges(pGSafeGuid As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function SaveGridFilter(pGSafeGuid As String, pFilter As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetCustomAccessLabel(pGSafeGuid As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetActiveAccountServices(pGSafeGuid As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetActiveAccountServiceContacts(pGSafeGuid As String) As IO.Stream

        <OperationContract>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Function GetTrainingVideos(pGSafeGuid As String) As IO.Stream

    End Interface

    Public Class DataPack
        Public Data As String
    End Class

End Namespace