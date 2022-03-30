'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/27/2018 4:06:37 PM
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
    Partial Public Class DataServer

        Public Sub New()
            esProviderFactory.Factory = New esDataProviderFactory()
        End Sub

#Region "IBMRecommendations Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function BMRecommendationsCollection_LoadAll() As jsResponse(Of BMRecommendationsCollection, BMRecommendations)
            Dim response As New jsResponse(Of BMRecommendationsCollection, BMRecommendations)()

            Try
                Dim collection As New BMRecommendationsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMRecommendationsCollection_Save(collection As BMRecommendationsCollection) As jsResponse(Of BMRecommendationsCollection, BMRecommendations)
            Dim response As New jsResponse(Of BMRecommendationsCollection, BMRecommendations)()

            Try

                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMRecommendations_LoadByPrimaryKey(ByVal id As System.Int32) As jsResponse(Of BMRecommendationsCollection, BMRecommendations)

            Dim response As New jsResponse(Of BMRecommendationsCollection, BMRecommendations)()

            Try
                Dim entity As New BMRecommendations()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMRecommendations_Save(entity As BMRecommendations) As jsResponse(Of BMRecommendationsCollection, BMRecommendations)
            Dim response As New jsResponse(Of BMRecommendationsCollection, BMRecommendations)()

            Try
                Dim id As String = HttpContext.Current.Request.Cookies(UtilCookieUser.COOKIE_USER_COOKIENAME)(UtilCookieUser.COOKIE_USER_APPENTRYID)
                entity.UpdateBy = UtilAppEntry.GetAppEntry(id).colFldUserName
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IClientfeatures Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ClientfeaturesCollection_LoadAll() As jsResponse(Of ClientfeaturesCollection, Clientfeatures)
            Dim response As New jsResponse(Of ClientfeaturesCollection, Clientfeatures)()

            Try
                Dim collection As New ClientfeaturesCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ClientfeaturesCollection_Save(collection As ClientfeaturesCollection) As jsResponse(Of ClientfeaturesCollection, Clientfeatures)
            Dim response As New jsResponse(Of ClientfeaturesCollection, Clientfeatures)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Clientfeatures_LoadByPrimaryKey(ByVal featurescode As System.Char) As jsResponse(Of ClientfeaturesCollection, Clientfeatures)

            Dim response As New jsResponse(Of ClientfeaturesCollection, Clientfeatures)()

            Try
                Dim entity As New Clientfeatures()
                If entity.LoadByPrimaryKey(featurescode) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Clientfeatures_Save(entity As Clientfeatures) As jsResponse(Of ClientfeaturesCollection, Clientfeatures)
            Dim response As New jsResponse(Of ClientfeaturesCollection, Clientfeatures)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IClients Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ClientsCollection_LoadAll() As jsResponse(Of ClientsCollection, Clients)
            Dim response As New jsResponse(Of ClientsCollection, Clients)()

            Try
                Dim collection As New ClientsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ClientsCollection_Save(collection As ClientsCollection) As jsResponse(Of ClientsCollection, Clients)
            Dim response As New jsResponse(Of ClientsCollection, Clients)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Clients_LoadByPrimaryKey(ByVal cldbname As System.String) As jsResponse(Of ClientsCollection, Clients)

            Dim response As New jsResponse(Of ClientsCollection, Clients)()

            Try
                Dim entity As New Clients()
                If entity.LoadByPrimaryKey(cldbname) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Clients_Save(entity As Clients) As jsResponse(Of ClientsCollection, Clients)
            Dim response As New jsResponse(Of ClientsCollection, Clients)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IContact1 Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function Contact1Collection_LoadAll() As jsResponse(Of Contact1Collection, Contact1)
            Dim response As New jsResponse(Of Contact1Collection, Contact1)()

            Try
                Dim collection As New Contact1Collection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Contact1Collection_Save(collection As Contact1Collection) As jsResponse(Of Contact1Collection, Contact1)
            Dim response As New jsResponse(Of Contact1Collection, Contact1)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Contact1_LoadByPrimaryKey(ByVal contactID As System.Int32) As jsResponse(Of Contact1Collection, Contact1)

            Dim response As New jsResponse(Of Contact1Collection, Contact1)()

            Try
                Dim entity As New Contact1()
                If entity.LoadByPrimaryKey(contactID) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Contact1_Save(entity As Contact1) As jsResponse(Of Contact1Collection, Contact1)
            Dim response As New jsResponse(Of Contact1Collection, Contact1)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IEzyUsers Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function EzyUsersCollection_LoadAll() As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim response As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim collection As New EzyUsersCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function EzyUsersCollection_Save(collection As EzyUsersCollection) As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim response As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Public Function EzyUsers_LoadByPrimaryKey(ByVal userID As System.String, ByVal filePrefix As System.Int16) As jsResponse(Of EzyUsersCollection, EzyUsers)

            Dim response As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim entity As New EzyUsers()
                If entity.LoadByPrimaryKey(userID, filePrefix) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function EzyUsers_Save(entity As EzyUsers) As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim response As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IFindings Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function FindingsCollection_LoadAll() As jsResponse(Of FindingsCollection, Findings)
            Dim response As New jsResponse(Of FindingsCollection, Findings)()

            Try
                Dim collection As New FindingsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FindingsCollection_Save(collection As FindingsCollection) As jsResponse(Of FindingsCollection, Findings)
            Dim response As New jsResponse(Of FindingsCollection, Findings)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Public Function Findings_LoadByPrimaryKey(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32) As jsResponse(Of FindingsCollection, Findings)

            Dim response As New jsResponse(Of FindingsCollection, Findings)()

            Try
                Dim entity As New Findings()
                If entity.LoadByPrimaryKey(fileNo, recMonth, recNumber, recYear) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function Findings_Save(entity As Findings) As jsResponse(Of FindingsCollection, Findings)
            Dim response As New jsResponse(Of FindingsCollection, Findings)()

            Try
                Dim id As String = HttpContext.Current.Request.Cookies(UtilCookieUser.COOKIE_USER_COOKIENAME)(UtilCookieUser.COOKIE_USER_APPENTRYID)
                entity.UpdateBy = UtilAppEntry.GetAppEntry(id).colFldUserName
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IFirePlanReview Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function FirePlanReviewCollection_LoadAll() As jsResponse(Of FirePlanReviewCollection, FirePlanReview)
            Dim response As New jsResponse(Of FirePlanReviewCollection, FirePlanReview)()

            Try
                Dim collection As New FirePlanReviewCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FirePlanReviewCollection_Save(collection As FirePlanReviewCollection) As jsResponse(Of FirePlanReviewCollection, FirePlanReview)
            Dim response As New jsResponse(Of FirePlanReviewCollection, FirePlanReview)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FirePlanReview_LoadByPrimaryKey(ByVal id As System.Decimal) As jsResponse(Of FirePlanReviewCollection, FirePlanReview)

            Dim response As New jsResponse(Of FirePlanReviewCollection, FirePlanReview)()

            Try
                Dim entity As New FirePlanReview()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FirePlanReview_Save(entity As FirePlanReview) As jsResponse(Of FirePlanReviewCollection, FirePlanReview)
            Dim response As New jsResponse(Of FirePlanReviewCollection, FirePlanReview)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IFireRecommendations Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function FireRecommendationsCollection_LoadAll() As jsResponse(Of FireRecommendationsCollection, FireRecommendations)
            Dim response As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()

            Try
                Dim collection As New FireRecommendationsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FireRecommendationsCollection_Save(collection As FireRecommendationsCollection) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)
            Dim response As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FireRecommendations_LoadByPrimaryKey(ByVal id As System.Int32) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim response As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()

            Try
                Dim entity As New FireRecommendations()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FireRecommendations_Save(entity As FireRecommendations) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)
            Dim response As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IGRIPSSWorkload Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function GRIPSSWorkloadCollection_LoadAll() As jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)
            Dim response As New jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)()

            Try
                Dim collection As New GRIPSSWorkloadCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GRIPSSWorkloadCollection_Save(collection As GRIPSSWorkloadCollection) As jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)
            Dim response As New jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GRIPSSWorkload_LoadByPrimaryKey(ByVal gripssRecordId As System.Int32) As jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)

            Dim response As New jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)()

            Try
                Dim entity As New GRIPSSWorkload()
                If entity.LoadByPrimaryKey(gripssRecordId) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GRIPSSWorkload_Save(entity As GRIPSSWorkload) As jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)
            Dim response As New jsResponse(Of GRIPSSWorkloadCollection, GRIPSSWorkload)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IGSafeDetail Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function GSafeDetailCollection_LoadAll() As jsResponse(Of GSafeDetailCollection, GSafeDetail)
            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim collection As New GSafeDetailCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetailCollection_Save(collection As GSafeDetailCollection) As jsResponse(Of GSafeDetailCollection, GSafeDetail)
            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Public Function GSafeDetail_LoadByPrimaryKey(ByVal gSafeId As System.Int32, ByVal dataName As System.String) As jsResponse(Of GSafeDetailCollection, GSafeDetail)

            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim entity As New GSafeDetail()
                If entity.LoadByPrimaryKey(gSafeId, dataName) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_Save(entity As GSafeDetail) As jsResponse(Of GSafeDetailCollection, GSafeDetail)
            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IGSafeFileNo Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function GSafeFileNoCollection_LoadAll() As jsResponse(Of GSafeFileNoCollection, GSafeFileNo)
            Dim response As New jsResponse(Of GSafeFileNoCollection, GSafeFileNo)()

            Try
                Dim collection As New GSafeFileNoCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeFileNoCollection_Save(collection As GSafeFileNoCollection) As jsResponse(Of GSafeFileNoCollection, GSafeFileNo)
            Dim response As New jsResponse(Of GSafeFileNoCollection, GSafeFileNo)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Public Function GSafeFileNo_LoadByPrimaryKey(ByVal gSafeId As System.Int32, ByVal fileNo As System.String) As jsResponse(Of GSafeFileNoCollection, GSafeFileNo)

            Dim response As New jsResponse(Of GSafeFileNoCollection, GSafeFileNo)()

            Try
                Dim entity As New GSafeFileNo()
                If entity.LoadByPrimaryKey(gSafeId, fileNo) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeFileNo_Save(entity As GSafeFileNo) As jsResponse(Of GSafeFileNoCollection, GSafeFileNo)
            Dim response As New jsResponse(Of GSafeFileNoCollection, GSafeFileNo)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IGSafeFilePrefix Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function GSafeFilePrefixCollection_LoadAll() As jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)
            Dim response As New jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)()

            Try
                Dim collection As New GSafeFilePrefixCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeFilePrefixCollection_Save(collection As GSafeFilePrefixCollection) As jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)
            Dim response As New jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Public Function GSafeFilePrefix_LoadByPrimaryKey(ByVal gSafeId As System.Int32, ByVal filePrefix As System.String) As jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)

            Dim response As New jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)()

            Try
                Dim entity As New GSafeFilePrefix()
                If entity.LoadByPrimaryKey(gSafeId, filePrefix) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeFilePrefix_Save(entity As GSafeFilePrefix) As jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)
            Dim response As New jsResponse(Of GSafeFilePrefixCollection, GSafeFilePrefix)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IGSafeHeader Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function GSafeHeaderCollection_LoadAll() As jsResponse(Of GSafeHeaderCollection, GSafeHeader)
            Dim response As New jsResponse(Of GSafeHeaderCollection, GSafeHeader)()

            Try
                Dim collection As New GSafeHeaderCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeHeaderCollection_Save(collection As GSafeHeaderCollection) As jsResponse(Of GSafeHeaderCollection, GSafeHeader)
            Dim response As New jsResponse(Of GSafeHeaderCollection, GSafeHeader)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeHeader_LoadByPrimaryKey(ByVal gSafeId As System.Int32) As jsResponse(Of GSafeHeaderCollection, GSafeHeader)

            Dim response As New jsResponse(Of GSafeHeaderCollection, GSafeHeader)()

            Try
                Dim entity As New GSafeHeader()
                If entity.LoadByPrimaryKey(gSafeId) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeHeader_Save(entity As GSafeHeader) As jsResponse(Of GSafeHeaderCollection, GSafeHeader)
            Dim response As New jsResponse(Of GSafeHeaderCollection, GSafeHeader)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "INavControl Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function NavControlCollection_LoadAll() As jsResponse(Of NavControlCollection, NavControl)
            Dim response As New jsResponse(Of NavControlCollection, NavControl)()

            Try
                Dim collection As New NavControlCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavControlCollection_Save(collection As NavControlCollection) As jsResponse(Of NavControlCollection, NavControl)
            Dim response As New jsResponse(Of NavControlCollection, NavControl)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavControl_LoadByPrimaryKey(ByVal navControlId As System.Int32) As jsResponse(Of NavControlCollection, NavControl)

            Dim response As New jsResponse(Of NavControlCollection, NavControl)()

            Try
                Dim entity As New NavControl()
                If entity.LoadByPrimaryKey(navControlId) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavControl_Save(entity As NavControl) As jsResponse(Of NavControlCollection, NavControl)
            Dim response As New jsResponse(Of NavControlCollection, NavControl)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "INavLevel Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function NavLevelCollection_LoadAll() As jsResponse(Of NavLevelCollection, NavLevel)
            Dim response As New jsResponse(Of NavLevelCollection, NavLevel)()

            Try
                Dim collection As New NavLevelCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavLevelCollection_Save(collection As NavLevelCollection) As jsResponse(Of NavLevelCollection, NavLevel)
            Dim response As New jsResponse(Of NavLevelCollection, NavLevel)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavLevel_LoadByPrimaryKey(ByVal navLevelId As System.Int32) As jsResponse(Of NavLevelCollection, NavLevel)

            Dim response As New jsResponse(Of NavLevelCollection, NavLevel)()

            Try
                Dim entity As New NavLevel()
                If entity.LoadByPrimaryKey(navLevelId) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavLevel_Save(entity As NavLevel) As jsResponse(Of NavLevelCollection, NavLevel)
            Dim response As New jsResponse(Of NavLevelCollection, NavLevel)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "INavLink Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function NavLinkCollection_LoadAll() As jsResponse(Of NavLinkCollection, NavLink)
            Dim response As New jsResponse(Of NavLinkCollection, NavLink)()

            Try
                Dim collection As New NavLinkCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavLinkCollection_Save(collection As NavLinkCollection) As jsResponse(Of NavLinkCollection, NavLink)
            Dim response As New jsResponse(Of NavLinkCollection, NavLink)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavLink_LoadByPrimaryKey(ByVal navLinkId As System.Int32) As jsResponse(Of NavLinkCollection, NavLink)

            Dim response As New jsResponse(Of NavLinkCollection, NavLink)()

            Try
                Dim entity As New NavLink()
                If entity.LoadByPrimaryKey(navLinkId) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function NavLink_Save(entity As NavLink) As jsResponse(Of NavLinkCollection, NavLink)
            Dim response As New jsResponse(Of NavLinkCollection, NavLink)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IREDocAttrib Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function REDocAttribCollection_LoadAll() As jsResponse(Of REDocAttribCollection, REDocAttrib)
            Dim response As New jsResponse(Of REDocAttribCollection, REDocAttrib)()

            Try
                Dim collection As New REDocAttribCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function REDocAttribCollection_Save(collection As REDocAttribCollection) As jsResponse(Of REDocAttribCollection, REDocAttrib)
            Dim response As New jsResponse(Of REDocAttribCollection, REDocAttrib)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)> _
        Public Function REDocAttrib_LoadByPrimaryKey(ByVal rEDocId As System.Int32, ByVal dataName As System.String) As jsResponse(Of REDocAttribCollection, REDocAttrib)

            Dim response As New jsResponse(Of REDocAttribCollection, REDocAttrib)()

            Try
                Dim entity As New REDocAttrib()
                If entity.LoadByPrimaryKey(rEDocId, dataName) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function REDocAttrib_Save(entity As REDocAttrib) As jsResponse(Of REDocAttribCollection, REDocAttrib)
            Dim response As New jsResponse(Of REDocAttribCollection, REDocAttrib)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IREDocHeader Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function REDocHeaderCollection_LoadAll() As jsResponse(Of REDocHeaderCollection, REDocHeader)
            Dim response As New jsResponse(Of REDocHeaderCollection, REDocHeader)()

            Try
                Dim collection As New REDocHeaderCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function REDocHeaderCollection_Save(collection As REDocHeaderCollection) As jsResponse(Of REDocHeaderCollection, REDocHeader)
            Dim response As New jsResponse(Of REDocHeaderCollection, REDocHeader)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function REDocHeader_LoadByPrimaryKey(ByVal rEDocId As System.Int32) As jsResponse(Of REDocHeaderCollection, REDocHeader)

            Dim response As New jsResponse(Of REDocHeaderCollection, REDocHeader)()

            Try
                Dim entity As New REDocHeader()
                If entity.LoadByPrimaryKey(rEDocId) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function REDocHeader_Save(entity As REDocHeader) As jsResponse(Of REDocHeaderCollection, REDocHeader)
            Dim response As New jsResponse(Of REDocHeaderCollection, REDocHeader)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IRRLog Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function RRLogCollection_LoadAll() As jsResponse(Of RRLogCollection, RRLog)
            Dim response As New jsResponse(Of RRLogCollection, RRLog)()

            Try
                Dim collection As New RRLogCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function RRLogCollection_Save(collection As RRLogCollection) As jsResponse(Of RRLogCollection, RRLog)
            Dim response As New jsResponse(Of RRLogCollection, RRLog)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function RRLog_LoadByPrimaryKey(ByVal id As System.Int32) As jsResponse(Of RRLogCollection, RRLog)

            Dim response As New jsResponse(Of RRLogCollection, RRLog)()

            Try
                Dim entity As New RRLog()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function RRLog_Save(entity As RRLog) As jsResponse(Of RRLogCollection, RRLog)
            Dim response As New jsResponse(Of RRLogCollection, RRLog)()

            Try
                entity.ResponseLastActivity = Now 'OVERRIDE THE JS DATE AND SAVE WITH THE SERVER TIME EST -DB
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IReportArchive Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function ReportArchiveCollection_LoadAll() As jsResponse(Of ReportArchiveCollection, ReportArchive)
            Dim response As New jsResponse(Of ReportArchiveCollection, ReportArchive)()

            Try
                Dim collection As New ReportArchiveCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ReportArchiveCollection_Save(collection As ReportArchiveCollection) As jsResponse(Of ReportArchiveCollection, ReportArchive)
            Dim response As New jsResponse(Of ReportArchiveCollection, ReportArchive)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ReportArchive_LoadByPrimaryKey(ByVal id As System.Int32) As jsResponse(Of ReportArchiveCollection, ReportArchive)

            Dim response As New jsResponse(Of ReportArchiveCollection, ReportArchive)()

            Try
                Dim entity As New ReportArchive()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ReportArchive_Save(entity As ReportArchive) As jsResponse(Of ReportArchiveCollection, ReportArchive)
            Dim response As New jsResponse(Of ReportArchiveCollection, ReportArchive)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function
#End Region

#Region "IBMPlanReview Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function BMPlanReviewCollection_LoadAll() As jsResponse(Of BMPlanReviewCollection, BMPlanReview)
            Dim response As New jsResponse(Of BMPlanReviewCollection, BMPlanReview)()

            Try
                Dim collection As New BMPlanReviewCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMPlanReviewCollection_Save(collection As BMPlanReviewCollection) As jsResponse(Of BMPlanReviewCollection, BMPlanReview)
            Dim response As New jsResponse(Of BMPlanReviewCollection, BMPlanReview)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMPlanReview_LoadByPrimaryKey(ByVal id As System.Decimal) As jsResponse(Of BMPlanReviewCollection, BMPlanReview)

            Dim response As New jsResponse(Of BMPlanReviewCollection, BMPlanReview)()

            Try
                Dim entity As New BMPlanReview()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMPlanReview_Save(entity As BMPlanReview) As jsResponse(Of BMPlanReviewCollection, BMPlanReview)
            Dim response As New jsResponse(Of BMPlanReviewCollection, BMPlanReview)()

            Try
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IPSRecommendations Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)> _
        Public Function PSRecommendationsCollection_LoadAll() As jsResponse(Of PSRecommendationsCollection, PSRecommendations)
            Dim response As New jsResponse(Of PSRecommendationsCollection, PSRecommendations)()

            Try
                Dim collection As New PSRecommendationsCollection()
                collection.LoadAll()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function PSRecommendationsCollection_Save(collection As PSRecommendationsCollection) As jsResponse(Of PSRecommendationsCollection, PSRecommendations)
            Dim response As New jsResponse(Of PSRecommendationsCollection, PSRecommendations)()

            Try
                collection.Save()
                response.collection = collection
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function PSRecommendations_LoadByPrimaryKey(ByVal id As System.Int32) As jsResponse(Of PSRecommendationsCollection, PSRecommendations)

            Dim response As New jsResponse(Of PSRecommendationsCollection, PSRecommendations)()

            Try
                Dim entity As New PSRecommendations()
                If entity.LoadByPrimaryKey(id) Then
                    response.entity = entity
                End If
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function PSRecommendations_Save(entity As PSRecommendations) As jsResponse(Of PSRecommendationsCollection, PSRecommendations)
            Dim response As New jsResponse(Of PSRecommendationsCollection, PSRecommendations)()

            Try

                Dim id As String = HttpContext.Current.Request.Cookies(UtilCookieUser.COOKIE_USER_COOKIENAME)(UtilCookieUser.COOKIE_USER_APPENTRYID)
                entity.UpdateBy = UtilAppEntry.GetAppEntry(id).colFldUserName
                entity.Save()
                response.entity = entity
            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

    End Class
End Namespace
