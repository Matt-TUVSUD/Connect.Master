'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/1/2018 10:51:54 AM
'===============================================================================

Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader

Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Namespace Service
    <AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)> _
    <ServiceContract()> _
    Partial Public Class ViewServer

        Public Sub New()
            esProviderFactory.Factory = New esDataProviderFactory()
            WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Json
        End Sub



#Region "IViewCCTranslationHazard Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationHazardCollection_LoadAll() As jsResponse(Of ViewCCTranslationHazardCollection, ViewCCTranslationHazard)
            Dim response As New jsResponse(Of ViewCCTranslationHazardCollection, ViewCCTranslationHazard)()

            Try
                Dim collection As New ViewCCTranslationHazardCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAllPlanReview Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAllPlanReviewCollection_LoadAll() As jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)
            Dim response As New jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)()

            Try
                Dim collection As New ViewCCAllPlanReviewCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

#End Region

#Region "IViewCCBMFacilityRating Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCBMFacilityRatingCollection_LoadAll() As jsResponse(Of ViewCCBMFacilityRatingCollection, ViewCCBMFacilityRating)
            Dim response As New jsResponse(Of ViewCCBMFacilityRatingCollection, ViewCCBMFacilityRating)()

            Try
                Dim collection As New ViewCCBMFacilityRatingCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCBMRecommendationGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCBMRecommendationGridCollection_LoadAll() As jsResponse(Of ViewCCBMRecommendationGridCollection, ViewCCBMRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCBMRecommendationGridCollection, ViewCCBMRecommendationGrid)()

            Try
                Dim collection As New ViewCCBMRecommendationGridCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCDocumentLibraryForm Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCDocumentLibraryFormCollection_LoadAll() As jsResponse(Of ViewCCDocumentLibraryFormCollection, ViewCCDocumentLibraryForm)
            Dim response As New jsResponse(Of ViewCCDocumentLibraryFormCollection, ViewCCDocumentLibraryForm)()

            Try
                Dim collection As New ViewCCDocumentLibraryFormCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCFireFacilityRating Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCFireFacilityRatingCollection_LoadAll() As jsResponse(Of ViewCCFireFacilityRatingCollection, ViewCCFireFacilityRating)
            Dim response As New jsResponse(Of ViewCCFireFacilityRatingCollection, ViewCCFireFacilityRating)()

            Try
                Dim collection As New ViewCCFireFacilityRatingCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCFireRecommendationGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCFireRecommendationGridCollection_LoadAll() As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCGaugeStats Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCGaugeStatsCollection_LoadAll() As jsResponse(Of ViewCCGaugeStatsCollection, ViewCCGaugeStats)
            Dim response As New jsResponse(Of ViewCCGaugeStatsCollection, ViewCCGaugeStats)()

            Try
                Dim collection As New ViewCCGaugeStatsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCImpairmentsFormFire Members"

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        'Public Function ViewCCImpairmentsFormFireCollection_LoadAll() As jsResponse(Of ViewCCImpairmentsFormFireCollection, ViewCCImpairmentsFormFire)
        '    Dim response As New jsResponse(Of ViewCCImpairmentsFormFireCollection, ViewCCImpairmentsFormFire)()

        '    Try
        '        Dim collection As New ViewCCImpairmentsFormFireCollection()
        '        collection.LoadAll()
        '        response.collection = collection
        '    Catch ex As Exception
        '        response.exception = ex.Message
        '    End Try

        '    Return response
        'End Function


#End Region

#Region "IViewCCIRRecommendationGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCIRRecommendationGridCollection_LoadAll() As jsResponse(Of ViewCCIRRecommendationGridCollection, ViewCCIRRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCIRRecommendationGridCollection, ViewCCIRRecommendationGrid)()

            Try
                Dim collection As New ViewCCIRRecommendationGridCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationAllViolationsJuris Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationAllViolationsJurisCollection_LoadAll() As jsResponse(Of ViewCCLocationAllViolationsJurisCollection, ViewCCLocationAllViolationsJuris)
            Dim response As New jsResponse(Of ViewCCLocationAllViolationsJurisCollection, ViewCCLocationAllViolationsJuris)()

            Try
                Dim collection As New ViewCCLocationAllViolationsJurisCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

        '#Region "IViewCCLocationContactsBM Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCLocationContactsBMCollection_LoadAll() As jsResponse(Of ViewCCLocationContactsBMCollection, ViewCCLocationContactsBM)
        '            Dim response As New jsResponse(Of ViewCCLocationContactsBMCollection, ViewCCLocationContactsBM)()

        '            Try
        '                Dim collection As New ViewCCLocationContactsBMCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

        '#Region "IViewCCLocationContactsFire Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCLocationContactsFireCollection_LoadAll() As jsResponse(Of ViewCCLocationContactsFireCollection, ViewCCLocationContactsFire)
        '            Dim response As New jsResponse(Of ViewCCLocationContactsFireCollection, ViewCCLocationContactsFire)()

        '            Try
        '                Dim collection As New ViewCCLocationContactsFireCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

        '#Region "IViewCCLocationContactsIR Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCLocationContactsIRCollection_LoadAll() As jsResponse(Of ViewCCLocationContactsIRCollection, ViewCCLocationContactsIR)
        '            Dim response As New jsResponse(Of ViewCCLocationContactsIRCollection, ViewCCLocationContactsIR)()

        '            Try
        '                Dim collection As New ViewCCLocationContactsIRCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

        '#Region "IViewCCLocationContactsJuris Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCLocationContactsJurisCollection_LoadAll() As jsResponse(Of ViewCCLocationContactsJurisCollection, ViewCCLocationContactsJuris)
        '            Dim response As New jsResponse(Of ViewCCLocationContactsJurisCollection, ViewCCLocationContactsJuris)()

        '            Try
        '                Dim collection As New ViewCCLocationContactsJurisCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

        '#Region "IViewCCLocationContactsNatHaz Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCLocationContactsNatHazCollection_LoadAll() As jsResponse(Of ViewCCLocationContactsNatHazCollection, ViewCCLocationContactsNatHaz)
        '            Dim response As New jsResponse(Of ViewCCLocationContactsNatHazCollection, ViewCCLocationContactsNatHaz)()

        '            Try
        '                Dim collection As New ViewCCLocationContactsNatHazCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

#Region "IViewCCLocationInspectionBM Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionBMCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionBMCollection, ViewCCLocationInspectionBM)
            Dim response As New jsResponse(Of ViewCCLocationInspectionBMCollection, ViewCCLocationInspectionBM)()

            Try
                Dim collection As New ViewCCLocationInspectionBMCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationInspectionFire Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionFireCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)
            Dim response As New jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)()

            Try
                Dim collection As New ViewCCLocationInspectionFireCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationInspectionIR Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionIRCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionIRCollection, ViewCCLocationInspectionIR)
            Dim response As New jsResponse(Of ViewCCLocationInspectionIRCollection, ViewCCLocationInspectionIR)()

            Try
                Dim collection As New ViewCCLocationInspectionIRCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationInspectionNatHaz Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionNatHazCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            Dim response As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)()

            Try
                Dim collection As New ViewCCLocationInspectionNatHazCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingBM Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingBMCollection_LoadAll() As jsResponse(Of ViewCCLocationListingBMCollection, ViewCCLocationListingBM)
            Dim response As New jsResponse(Of ViewCCLocationListingBMCollection, ViewCCLocationListingBM)()

            Try
                Dim collection As New ViewCCLocationListingBMCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingFire Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingFireCollection_LoadAll() As jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)
            Dim response As New jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)()

            Try
                Dim collection As New ViewCCLocationListingFireCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingFireRating Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingFireRatingCollection_LoadAll() As jsResponse(Of ViewCCLocationListingFireRatingCollection, ViewCCLocationListingFireRating)
            Dim response As New jsResponse(Of ViewCCLocationListingFireRatingCollection, ViewCCLocationListingFireRating)()

            Try
                Dim collection As New ViewCCLocationListingFireRatingCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingFireRecommendation Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingFireRecommendationCollection_LoadAll() As jsResponse(Of ViewCCLocationListingFireRecommendationCollection, ViewCCLocationListingFireRecommendation)
            Dim response As New jsResponse(Of ViewCCLocationListingFireRecommendationCollection, ViewCCLocationListingFireRecommendation)()

            Try
                Dim collection As New ViewCCLocationListingFireRecommendationCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingIR Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingIRCollection_LoadAll() As jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)
            Dim response As New jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)()

            Try
                Dim collection As New ViewCCLocationListingIRCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingJuris Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingJurisCollection_LoadAll() As jsResponse(Of ViewCCLocationListingJurisCollection, ViewCCLocationListingJuris)
            Dim response As New jsResponse(Of ViewCCLocationListingJurisCollection, ViewCCLocationListingJuris)()

            Try
                Dim collection As New ViewCCLocationListingJurisCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingNatHaz Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingNatHazCollection_LoadAll() As jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)
            Dim response As New jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)()

            Try
                Dim collection As New ViewCCLocationListingNatHazCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationOpenViolationCountJuris Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationOpenViolationCountJurisCollection_LoadAll() As jsResponse(Of ViewCCLocationOpenViolationCountJurisCollection, ViewCCLocationOpenViolationCountJuris)
            Dim response As New jsResponse(Of ViewCCLocationOpenViolationCountJurisCollection, ViewCCLocationOpenViolationCountJuris)()

            Try
                Dim collection As New ViewCCLocationOpenViolationCountJurisCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCNavLink Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCNavLinkCollection_LoadAll() As jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)
            Dim response As New jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)()

            Try
                Dim collection As New ViewCCNavLinkCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefCurrency Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefCurrencyCollection_LoadAll() As jsResponse(Of ViewCCPrefCurrencyCollection, ViewCCPrefCurrency)
            Dim response As New jsResponse(Of ViewCCPrefCurrencyCollection, ViewCCPrefCurrency)()

            Try
                Dim collection As New ViewCCPrefCurrencyCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefCustomAccess Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefCustomAccessCollection_LoadAll() As jsResponse(Of ViewCCPrefCustomAccessCollection, ViewCCPrefCustomAccess)
            Dim response As New jsResponse(Of ViewCCPrefCustomAccessCollection, ViewCCPrefCustomAccess)()

            Try
                Dim collection As New ViewCCPrefCustomAccessCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefDivision Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefDivisionCollection_LoadAll() As jsResponse(Of ViewCCPrefDivisionCollection, ViewCCPrefDivision)
            Dim response As New jsResponse(Of ViewCCPrefDivisionCollection, ViewCCPrefDivision)()

            Try
                Dim collection As New ViewCCPrefDivisionCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefLocation Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefLocationCollection_LoadAll() As jsResponse(Of ViewCCPrefLocationCollection, ViewCCPrefLocation)
            Dim response As New jsResponse(Of ViewCCPrefLocationCollection, ViewCCPrefLocation)()

            Try
                Dim collection As New ViewCCPrefLocationCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefTIV Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefTIVCollection_LoadAll() As jsResponse(Of ViewCCPrefTIVCollection, ViewCCPrefTIV)
            Dim response As New jsResponse(Of ViewCCPrefTIVCollection, ViewCCPrefTIV)()

            Try
                Dim collection As New ViewCCPrefTIVCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefUnit Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefUnitCollection_LoadAll() As jsResponse(Of ViewCCPrefUnitCollection, ViewCCPrefUnit)
            Dim response As New jsResponse(Of ViewCCPrefUnitCollection, ViewCCPrefUnit)()

            Try
                Dim collection As New ViewCCPrefUnitCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecCompletedLossEstList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecCompletedLossEstListCollection_LoadAll() As jsResponse(Of ViewCCRecCompletedLossEstListCollection, ViewCCRecCompletedLossEstList)
            Dim response As New jsResponse(Of ViewCCRecCompletedLossEstListCollection, ViewCCRecCompletedLossEstList)()

            Try
                Dim collection As New ViewCCRecCompletedLossEstListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecCurrentLossEstList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecCurrentLossEstListCollection_LoadAll() As jsResponse(Of ViewCCRecCurrentLossEstListCollection, ViewCCRecCurrentLossEstList)
            Dim response As New jsResponse(Of ViewCCRecCurrentLossEstListCollection, ViewCCRecCurrentLossEstList)()

            Try
                Dim collection As New ViewCCRecCurrentLossEstListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCRecCurrentLossEstListCollection_LoadAllByGuid(pGSafeGuid) As jsResponse(Of ViewCCRecCurrentLossEstListCollection, ViewCCRecCurrentLossEstList)
            Dim response As New jsResponse(Of ViewCCRecCurrentLossEstListCollection, ViewCCRecCurrentLossEstList)()

            Try
                Dim collection As New ViewCCRecCurrentLossEstListCollection()
                collection.LoadAll()

                ' CHECK IF WE NEED THE OTHER CATEGORY
                If Not pGSafeGuid Is Nothing Then
                    Dim zFeatuers = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.clientFeatures)
                    If Not zFeatuers Is Nothing Then
                        If zFeatuers.ToLower().Contains("g") Then
                            Dim zItem As New ViewCCRecCurrentLossEstList()
                            zItem.LEText = "15. Other"
                            collection.Add(zItem)
                        End If
                    End If
                End If

                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecEstCostToCompleteList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecEstCostToCompleteListCollection_LoadAll() As jsResponse(Of ViewCCRecEstCostToCompleteListCollection, ViewCCRecEstCostToCompleteList)
            Dim response As New jsResponse(Of ViewCCRecEstCostToCompleteListCollection, ViewCCRecEstCostToCompleteList)()

            Try
                Dim collection As New ViewCCRecEstCostToCompleteListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecImpactList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecImpactListCollection_LoadAll() As jsResponse(Of ViewCCRecImpactListCollection, ViewCCRecImpactList)
            Dim response As New jsResponse(Of ViewCCRecImpactListCollection, ViewCCRecImpactList)()

            Try
                Dim collection As New ViewCCRecImpactListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecIntendedActionList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecIntendedActionListCollection_LoadAll() As jsResponse(Of ViewCCRecIntendedActionListCollection, ViewCCRecIntendedActionList)
            Dim response As New jsResponse(Of ViewCCRecIntendedActionListCollection, ViewCCRecIntendedActionList)()

            Try
                Dim collection As New ViewCCRecIntendedActionListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecPrimaryTypeList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecPrimaryTypeListCollection_LoadAll() As jsResponse(Of ViewCCRecPrimaryTypeListCollection, ViewCCRecPrimaryTypeList)
            Dim response As New jsResponse(Of ViewCCRecPrimaryTypeListCollection, ViewCCRecPrimaryTypeList)()

            Try
                Dim collection As New ViewCCRecPrimaryTypeListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecSecondaryTypeList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecSecondaryTypeListCollection_LoadAll() As jsResponse(Of ViewCCRecSecondaryTypeListCollection, ViewCCRecSecondaryTypeList)
            Dim response As New jsResponse(Of ViewCCRecSecondaryTypeListCollection, ViewCCRecSecondaryTypeList)()

            Try
                Dim collection As New ViewCCRecSecondaryTypeListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCRecStatusList Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCRecStatusListCollection_LoadAll() As jsResponse(Of ViewCCRecStatusListCollection, ViewCCRecStatusList)
            Dim response As New jsResponse(Of ViewCCRecStatusListCollection, ViewCCRecStatusList)()

            Try
                Dim collection As New ViewCCRecStatusListCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

        '#Region "IViewCCWhatsNew Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCWhatsNewCollection_LoadAll() As jsResponse(Of ViewCCWhatsNewCollection, ViewCCWhatsNew)
        '            Dim response As New jsResponse(Of ViewCCWhatsNewCollection, ViewCCWhatsNew)()

        '            Try
        '                Dim collection As New ViewCCWhatsNewCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

#Region "IViewCCBMRecommendationCounts Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCBMRecommendationCountsCollection_LoadAll() As jsResponse(Of ViewCCBMRecommendationCountsCollection, ViewCCBMRecommendationCounts)
            Dim response As New jsResponse(Of ViewCCBMRecommendationCountsCollection, ViewCCBMRecommendationCounts)()

            Try
                Dim collection As New ViewCCBMRecommendationCountsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCFireRecommendationCounts Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCFireRecommendationCountsCollection_LoadAll() As jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)
            Dim response As New jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)()

            Try
                Dim collection As New ViewCCFireRecommendationCountsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPSRecommendationCounts Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPSRecommendationCountsCollection_LoadAll() As jsResponse(Of ViewCCPSRecommendationCountsCollection, ViewCCPSRecommendationCounts)
            Dim response As New jsResponse(Of ViewCCPSRecommendationCountsCollection, ViewCCPSRecommendationCounts)()

            Try
                Dim collection As New ViewCCPSRecommendationCountsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseBM Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseBMCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseBMCollection, ViewCCAdminWindowRecResponseBM)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseBMCollection, ViewCCAdminWindowRecResponseBM)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseBMCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseFire Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseFireCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseFireCollection, ViewCCAdminWindowRecResponseFire)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseFireCollection, ViewCCAdminWindowRecResponseFire)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseFireCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseIR Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseIRCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseIRCollection, ViewCCAdminWindowRecResponseIR)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseIRCollection, ViewCCAdminWindowRecResponseIR)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseIRCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseJuris Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseJurisCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseJurisCollection, ViewCCAdminWindowRecResponseJuris)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseJurisCollection, ViewCCAdminWindowRecResponseJuris)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseJurisCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseNatHaz Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseNatHazCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseNatHazCollection, ViewCCAdminWindowRecResponseNatHaz)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseNatHazCollection, ViewCCAdminWindowRecResponseNatHaz)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseNatHazCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCIRRecommendationCounts Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCIRRecommendationCountsCollection_LoadAll() As jsResponse(Of ViewCCIRRecommendationCountsCollection, ViewCCIRRecommendationCounts)
            Dim response As New jsResponse(Of ViewCCIRRecommendationCountsCollection, ViewCCIRRecommendationCounts)()

            Try
                Dim collection As New ViewCCIRRecommendationCountsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslation Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationCollection_LoadAll() As jsResponse(Of ViewCCTranslationCollection, ViewCCTranslation)
            Dim response As New jsResponse(Of ViewCCTranslationCollection, ViewCCTranslation)()

            Try
                Dim collection As New ViewCCTranslationCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslationImpact Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationImpactCollection_LoadAll() As jsResponse(Of ViewCCTranslationImpactCollection, ViewCCTranslationImpact)
            Dim response As New jsResponse(Of ViewCCTranslationImpactCollection, ViewCCTranslationImpact)()

            Try
                Dim collection As New ViewCCTranslationImpactCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslationIntendedAction Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationIntendedActionCollection_LoadAll() As jsResponse(Of ViewCCTranslationIntendedActionCollection, ViewCCTranslationIntendedAction)
            Dim response As New jsResponse(Of ViewCCTranslationIntendedActionCollection, ViewCCTranslationIntendedAction)()

            Try
                Dim collection As New ViewCCTranslationIntendedActionCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslationPrimaryRec Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationPrimaryRecCollection_LoadAll() As jsResponse(Of ViewCCTranslationPrimaryRecCollection, ViewCCTranslationPrimaryRec)
            Dim response As New jsResponse(Of ViewCCTranslationPrimaryRecCollection, ViewCCTranslationPrimaryRec)()

            Try
                Dim collection As New ViewCCTranslationPrimaryRecCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslationRecStatus Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationRecStatusCollection_LoadAll() As jsResponse(Of ViewCCTranslationRecStatusCollection, ViewCCTranslationRecStatus)
            Dim response As New jsResponse(Of ViewCCTranslationRecStatusCollection, ViewCCTranslationRecStatus)()

            Try
                Dim collection As New ViewCCTranslationRecStatusCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslationSecondaryRec Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationSecondaryRecCollection_LoadAll() As jsResponse(Of ViewCCTranslationSecondaryRecCollection, ViewCCTranslationSecondaryRec)
            Dim response As New jsResponse(Of ViewCCTranslationSecondaryRecCollection, ViewCCTranslationSecondaryRec)()

            Try
                Dim collection As New ViewCCTranslationSecondaryRecCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCUserActivityGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCUserActivityGridCollection_LoadAll() As jsResponse(Of ViewCCUserActivityGridCollection, ViewCCUserActivityGrid)
            Dim response As New jsResponse(Of ViewCCUserActivityGridCollection, ViewCCUserActivityGrid)()

            Try
                Dim collection As New ViewCCUserActivityGridCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerBM Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerBMCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerBMCollection, ViewCCAdminWindowDocManagerBM)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerBMCollection, ViewCCAdminWindowDocManagerBM)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerBMCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerFire Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerFireCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerFireCollection, ViewCCAdminWindowDocManagerFire)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerFireCollection, ViewCCAdminWindowDocManagerFire)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerFireCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerFlood Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerFloodCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerFloodCollection, ViewCCAdminWindowDocManagerFlood)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerFloodCollection, ViewCCAdminWindowDocManagerFlood)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerFloodCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerIR Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerIRCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerIRCollection, ViewCCAdminWindowDocManagerIR)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerIRCollection, ViewCCAdminWindowDocManagerIR)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerIRCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerJuris Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerJurisCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerJurisCollection, ViewCCAdminWindowDocManagerJuris)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerJurisCollection, ViewCCAdminWindowDocManagerJuris)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerJurisCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerSeismic Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerSeismicCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerSeismicCollection, ViewCCAdminWindowDocManagerSeismic)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerSeismicCollection, ViewCCAdminWindowDocManagerSeismic)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerSeismicCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerWind Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerWindCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerWindCollection, ViewCCAdminWindowDocManagerWind)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerWindCollection, ViewCCAdminWindowDocManagerWind)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerWindCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingRecResponseBM Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingRecResponseBMCollection_LoadAll() As jsResponse(Of ViewCCLocationListingRecResponseBMCollection, ViewCCLocationListingRecResponseBM)
            Dim response As New jsResponse(Of ViewCCLocationListingRecResponseBMCollection, ViewCCLocationListingRecResponseBM)()

            Try
                Dim collection As New ViewCCLocationListingRecResponseBMCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingRecResponseFire Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingRecResponseFireCollection_LoadAll() As jsResponse(Of ViewCCLocationListingRecResponseFireCollection, ViewCCLocationListingRecResponseFire)
            Dim response As New jsResponse(Of ViewCCLocationListingRecResponseFireCollection, ViewCCLocationListingRecResponseFire)()

            Try
                Dim collection As New ViewCCLocationListingRecResponseFireCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingRecResponseIR Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingRecResponseIRCollection_LoadAll() As jsResponse(Of ViewCCLocationListingRecResponseIRCollection, ViewCCLocationListingRecResponseIR)
            Dim response As New jsResponse(Of ViewCCLocationListingRecResponseIRCollection, ViewCCLocationListingRecResponseIR)()

            Try
                Dim collection As New ViewCCLocationListingRecResponseIRCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingRecResponseNatHaz Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingRecResponseNatHazCollection_LoadAll() As jsResponse(Of ViewCCLocationListingRecResponseNatHazCollection, ViewCCLocationListingRecResponseNatHaz)
            Dim response As New jsResponse(Of ViewCCLocationListingRecResponseNatHazCollection, ViewCCLocationListingRecResponseNatHaz)()

            Try
                Dim collection As New ViewCCLocationListingRecResponseNatHazCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingRecResponsePS Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingRecResponsePSCollection_LoadAll() As jsResponse(Of ViewCCLocationListingRecResponsePSCollection, ViewCCLocationListingRecResponsePS)
            Dim response As New jsResponse(Of ViewCCLocationListingRecResponsePSCollection, ViewCCLocationListingRecResponsePS)()

            Try
                Dim collection As New ViewCCLocationListingRecResponsePSCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCBMPlanReview Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCBMPlanReviewCollection_LoadAll() As jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)
            Dim response As New jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)()

            Try
                Dim collection As New ViewCCBMPlanReviewCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCFirePlanReview Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCFirePlanReviewCollection_LoadAll() As jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)
            Dim response As New jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)()

            Try
                Dim collection As New ViewCCFirePlanReviewCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCTranslationMgmtIntendedAction Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCTranslationMgmtIntendedActionCollection_LoadAll() As jsResponse(Of ViewCCTranslationMgmtIntendedActionCollection, ViewCCTranslationMgmtIntendedAction)
            Dim response As New jsResponse(Of ViewCCTranslationMgmtIntendedActionCollection, ViewCCTranslationMgmtIntendedAction)()

            Try
                Dim collection As New ViewCCTranslationMgmtIntendedActionCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefDivisionUsers Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefDivisionUsersCollection_LoadAll() As jsResponse(Of ViewCCPrefDivisionUsersCollection, ViewCCPrefDivisionUsers)
            Dim response As New jsResponse(Of ViewCCPrefDivisionUsersCollection, ViewCCPrefDivisionUsers)()

            Try
                Dim collection As New ViewCCPrefDivisionUsersCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPrefCustomAccessFilteredByFilePrefix Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPrefCustomAccessFilteredByFilePrefixCollection_LoadAll() As jsResponse(Of ViewCCPrefCustomAccessFilteredByFilePrefixCollection, ViewCCPrefCustomAccessFilteredByFilePrefix)
            Dim response As New jsResponse(Of ViewCCPrefCustomAccessFilteredByFilePrefixCollection, ViewCCPrefCustomAccessFilteredByFilePrefix)()

            Try
                Dim collection As New ViewCCPrefCustomAccessFilteredByFilePrefixCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationInspectionDiversified Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionDiversifiedCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionDiversifiedCollection, ViewCCLocationInspectionDiversified)
            Dim response As New jsResponse(Of ViewCCLocationInspectionDiversifiedCollection, ViewCCLocationInspectionDiversified)()

            Try
                Dim collection As New ViewCCLocationInspectionDiversifiedCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingDiversified Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingDiversifiedCollection_LoadAll() As jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)
            Dim response As New jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)()

            Try
                Dim collection As New ViewCCLocationListingDiversifiedCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingDiversifiedBase Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingDiversifiedBaseCollection_LoadAll() As jsResponse(Of ViewCCLocationListingDiversifiedBaseCollection, ViewCCLocationListingDiversifiedBase)
            Dim response As New jsResponse(Of ViewCCLocationListingDiversifiedBaseCollection, ViewCCLocationListingDiversifiedBase)()

            Try
                Dim collection As New ViewCCLocationListingDiversifiedBaseCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationInspectionNH Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionNHCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionNHCollection, ViewCCLocationInspectionNH)
            Dim response As New jsResponse(Of ViewCCLocationInspectionNHCollection, ViewCCLocationInspectionNH)()

            Try
                Dim collection As New ViewCCLocationInspectionNHCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingNH Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingNHCollection_LoadAll() As jsResponse(Of ViewCCLocationListingNHCollection, ViewCCLocationListingNH)
            Dim response As New jsResponse(Of ViewCCLocationListingNHCollection, ViewCCLocationListingNH)()

            Try
                Dim collection As New ViewCCLocationListingNHCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

        '#Region "IViewCCLocationListingRecResponseNH Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        '        Public Function ViewCCLocationListingRecResponseNHCollection_LoadAll() As jsResponse(Of ViewCCLocationListingRecResponseNHCollection, ViewCCLocationListingRecResponseNH)
        '            Dim response As New jsResponse(Of ViewCCLocationListingRecResponseNHCollection, ViewCCLocationListingRecResponseNH)()

        '            Try
        '                Dim collection As New ViewCCLocationListingRecResponseNHCollection()
        '                collection.LoadAll()
        '                response.collection = collection
        '            Catch ex As Exception
        '                response.exception = ex.Message
        '            End Try

        '            Return response
        '        End Function


        '#End Region

#Region "IViewCCNHRecommendationGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCNHRecommendationGridCollection_LoadAll() As jsResponse(Of ViewCCNHRecommendationGridCollection, ViewCCNHRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCNHRecommendationGridCollection, ViewCCNHRecommendationGrid)()

            Try
                Dim collection As New ViewCCNHRecommendationGridCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerDiversified Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerDiversifiedCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerDiversifiedCollection, ViewCCAdminWindowDocManagerDiversified)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerDiversifiedCollection, ViewCCAdminWindowDocManagerDiversified)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerDiversifiedCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerNH Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerNHCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerNHCollection, ViewCCAdminWindowDocManagerNH)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerNHCollection, ViewCCAdminWindowDocManagerNH)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerNHCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseDiversified Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseDiversifiedCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseDiversifiedCollection, ViewCCAdminWindowRecResponseDiversified)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseDiversifiedCollection, ViewCCAdminWindowRecResponseDiversified)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseDiversifiedCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponseNH Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponseNHCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponseNHCollection, ViewCCAdminWindowRecResponseNH)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponseNHCollection, ViewCCAdminWindowRecResponseNH)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponseNHCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationInspectionPS Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationInspectionPSCollection_LoadAll() As jsResponse(Of ViewCCLocationInspectionPSCollection, ViewCCLocationInspectionPS)
            Dim response As New jsResponse(Of ViewCCLocationInspectionPSCollection, ViewCCLocationInspectionPS)()

            Try
                Dim collection As New ViewCCLocationInspectionPSCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingPS Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCLocationListingPSCollection_LoadAll() As jsResponse(Of ViewCCLocationListingPSCollection, ViewCCLocationListingPS)
            Dim response As New jsResponse(Of ViewCCLocationListingPSCollection, ViewCCLocationListingPS)()

            Try
                Dim collection As New ViewCCLocationListingPSCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCPSRecommendationGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCPSRecommendationGridCollection_LoadAll() As jsResponse(Of ViewCCPSRecommendationGridCollection, ViewCCPSRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCPSRecommendationGridCollection, ViewCCPSRecommendationGrid)()

            Try
                Dim collection As New ViewCCPSRecommendationGridCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowDocManagerPS Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowDocManagerPSCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowDocManagerPSCollection, ViewCCAdminWindowDocManagerPS)
            Dim response As New jsResponse(Of ViewCCAdminWindowDocManagerPSCollection, ViewCCAdminWindowDocManagerPS)()

            Try
                Dim collection As New ViewCCAdminWindowDocManagerPSCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCAdminWindowRecResponsePS Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ViewCCAdminWindowRecResponsePSCollection_LoadAll() As jsResponse(Of ViewCCAdminWindowRecResponsePSCollection, ViewCCAdminWindowRecResponsePS)
            Dim response As New jsResponse(Of ViewCCAdminWindowRecResponsePSCollection, ViewCCAdminWindowRecResponsePS)()

            Try
                Dim collection As New ViewCCAdminWindowRecResponsePSCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

    End Class
End Namespace
