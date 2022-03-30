Imports System
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery

Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Web
Imports System.Web.Script.Services
Imports EntitySpaces.Core

Namespace Service
    Partial Public Class ViewServer

#Region "IViewCCLocationContacts Members"

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function ViewCCLocationContactsCollection_BrowseByFileNo(pFileNo As String) As jsResponse(Of ViewCCLocationContactsCollection, ViewCCLocationContacts)
        '    Dim response As New jsResponse(Of ViewCCLocationContactsCollection, ViewCCLocationContacts)()

        '    Try
        '        Dim collection As New ViewCCLocationContactsCollection()
        '        Dim query As New ViewCCLocationContactsQuery

        '        query.SelectAll()
        '        query.Where(query.FileNo = pFileNo)

        '        collection.Load(query)
        '        response.collection = collection
        '    Catch ex As Exception
        '        response.exception = ex.Message
        '    End Try

        '    Return response
        'End Function

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function ViewCCLocationContactsFireCollection_BrowseByFileNo(pFileNo As String) As jsResponse(Of ViewCCLocationContactsFireCollection, ViewCCLocationContactsFire)
        '    Dim response As New jsResponse(Of ViewCCLocationContactsFireCollection, ViewCCLocationContactsFire)()

        '    Try
        '        Dim collection As New ViewCCLocationContactsFireCollection()
        '        Dim query As New ViewCCLocationContactsFireQuery

        '        query.SelectAll()
        '        query.Where(query.FileNo = pFileNo)

        '        collection.Load(query)
        '        response.collection = collection
        '    Catch ex As Exception
        '        response.exception = ex.Message
        '    End Try

        '    Return response
        'End Function

#End Region

#Region "IViewCCLocationInspectionFire Members"
        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''' CHANGED TO USE GSAFE AS A PARM INSTEAD OF FILE NUMBER - STB 6/11/2012
        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function ViewCCLocationInspectionFireCollection_BrowseByFileNo(pSafeGuid As String) As jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)
        '    Dim response As New jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)()
        '    Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

        '    Try
        '        Dim collection As New ViewCCLocationInspectionFireCollection()
        '        Dim query As New ViewCCLocationInspectionFireQuery

        '        query.SelectAll()
        '        query.Where(query.FileNo = zFileNo)

        '        collection.Load(query)
        '        response.collection = collection
        '    Catch ex As Exception
        '        response.exception = ex.Message
        '    End Try

        '    Return response
        'End Function


#End Region

#Region "IViewCCLocationListingFire Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationListingFireCollection_BrowseByFileNo(pSafeGuid As String) As jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)
            Dim response As New jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCLocationListingFireCollection()
                Dim query As New ViewCCLocationListingFireQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IViewCCLocationListingDiversified Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationListingDiversifiedCollection_BrowseByFileNo(pSafeGuid As String) As jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)
            Dim response As New jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)()
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCLocationListingDiversifiedCollection()
                Dim query As New ViewCCLocationListingDiversifiedQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


#End Region

#Region "IviewCCPref Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPrefCurrencyCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefCurrencyCollection, ViewCCPrefCurrency)
            Dim response As New jsResponse(Of ViewCCPrefCurrencyCollection, ViewCCPrefCurrency)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCPrefCurrencyCollection()
                Dim query As New ViewCCPrefCurrencyQuery

                query.SelectAll()
                'query.Where(query.FileNo = zFileNo)

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPrefUnitCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefUnitCollection, ViewCCPrefUnit)
            Dim response As New jsResponse(Of ViewCCPrefUnitCollection, ViewCCPrefUnit)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCPrefUnitCollection()
                Dim query As New ViewCCPrefUnitQuery

                query.SelectAll()
                'query.Where(query.FileNo = zFileNo)

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPrefDivisionCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefDivisionCollection, ViewCCPrefDivision)
            Dim response As New jsResponse(Of ViewCCPrefDivisionCollection, ViewCCPrefDivision)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)
            Dim zCustomAccessDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.CustomAccessDefaultText)
            Dim zLocationDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.LocationDefaultText)

            Try
                Dim collection As New ViewCCPrefDivisionCollection()
                Dim query As New ViewCCPrefDivisionQuery

                query.Select(query.Division)
                query.es.Distinct = True
                query.Where(query.FilePrefix = zFilePrefix)
                If zCustomAccessDefaultText <> "(All)" Then query.Where(query.CustomAccess = zCustomAccessDefaultText)
                If zLocationDefaultText <> "(All)" Then query.Where(query.Location = zLocationDefaultText)
                If UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.PlantManager) = "True" Then query.Where(query.Location = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Plant))

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCPrefDivisionUsersCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefDivisionUsersCollection, ViewCCPrefDivisionUsers)
            Dim response As New jsResponse(Of ViewCCPrefDivisionUsersCollection, ViewCCPrefDivisionUsers)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)
            Dim zCustomAccessDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.CustomAccessDefaultText)
            Dim zLocationDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.LocationDefaultText)

            Try
                Dim collection As New ViewCCPrefDivisionUsersCollection()
                Dim query As New ViewCCPrefDivisionUsersQuery

                query.Select(query.Division)
                query.es.Distinct = True
                query.Where(query.FilePrefix = zFilePrefix)
                If zCustomAccessDefaultText <> "(All)" Then query.Where(query.CustomAccess = zCustomAccessDefaultText)
                If zLocationDefaultText <> "(All)" Then query.Where(query.Location = zLocationDefaultText)
                If UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.PlantManager) = "True" Then query.Where(query.Location = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Plant))

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPrefCustomAccessCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefCustomAccessCollection, ViewCCPrefCustomAccess)
            Dim response As New jsResponse(Of ViewCCPrefCustomAccessCollection, ViewCCPrefCustomAccess)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)
            Dim zDivisionDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Division)
            Dim zLocationDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.LocationDefaultText)

            Try
                Dim collection As New ViewCCPrefCustomAccessCollection()
                Dim query As New ViewCCPrefCustomAccessQuery

                query.Select(query.CustomAccess)
                query.es.Distinct = True
                query.Where(query.FilePrefix = zFilePrefix)
                If zDivisionDefaultText <> "(All)" Then query.Where(query.Division = zDivisionDefaultText)
                If zLocationDefaultText <> "(All)" Then query.Where(query.Location = zLocationDefaultText)
                If UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.PlantManager) = "True" Then query.Where(query.Location = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Plant))

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCPrefCustomAccessFilteredByFilePrefixCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefCustomAccessFilteredByFilePrefixCollection, ViewCCPrefCustomAccessFilteredByFilePrefix)
            Dim response As New jsResponse(Of ViewCCPrefCustomAccessFilteredByFilePrefixCollection, ViewCCPrefCustomAccessFilteredByFilePrefix)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)
            Dim zDivisionDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Division)
            Dim zLocationDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.LocationDefaultText)

            Try
                Dim collection As New ViewCCPrefCustomAccessFilteredByFilePrefixCollection()
                Dim query As New ViewCCPrefCustomAccessFilteredByFilePrefixQuery

                query.Select(query.CustomAccess)
                query.es.Distinct = True
                query.Where(query.FilePrefix = zFilePrefix)
                If zDivisionDefaultText <> "(All)" Then query.Where(query.Division = zDivisionDefaultText)
                If zLocationDefaultText <> "(All)" Then query.Where(query.Location = zLocationDefaultText)
                If UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.PlantManager) = "True" Then query.Where(query.Location = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Plant))

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPrefLocationCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefLocationCollection, ViewCCPrefLocation)
            Dim response As New jsResponse(Of ViewCCPrefLocationCollection, ViewCCPrefLocation)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)
            Dim zDivisionDefaultText As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Division)
            Dim zCustomAccessDefaultText As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.CustomAccessText)

            Try
                Dim collection As New ViewCCPrefLocationCollection()
                Dim query As New ViewCCPrefLocationQuery

                query.Select(query.Location)
                query.es.Distinct = True
                query.Where(query.FilePrefix = zFilePrefix)
                If zDivisionDefaultText <> "(All)" Then query.Where(query.Division = zDivisionDefaultText)
                If zCustomAccessDefaultText <> "(All)" Then query.Where(query.CustomAccess = zCustomAccessDefaultText)
                If UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.PlantManager) = "True" Then query.Where(query.Location = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.Plant))

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPrefTIVCollection(pSafeGuid As String) As jsResponse(Of ViewCCPrefTIVCollection, ViewCCPrefTIV)
            Dim response As New jsResponse(Of ViewCCPrefTIVCollection, ViewCCPrefTIV)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCPrefTIVCollection()
                Dim query As New ViewCCPrefTIVQuery

                query.SelectAll()
                'query.Where(query.FileNo = zFileNo)

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

#End Region

#Region "IviewCCFireRecommendation Members"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationFireRecommendationCollections(pParms As String) As jsResponse(Of ViewCCLocationListingFireRecommendationCollection, ViewCCLocationListingFireRecommendation)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingFireRecommendationCollection, ViewCCLocationListingFireRecommendation)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateRecommendationFileNo(zSafeGUID, zDirection)
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionRecommendationFileNo(zRecCount, zRecPosition, zSafeGUID)
                '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zFireLocationListingQry As New ViewCCLocationListingFireRecommendationQuery("t1")

                Dim zFireLocationListingCollection As New ViewCCLocationListingFireRecommendationCollection

                zFireLocationListingQry.es.Distinct = True
                zFireLocationListingQry.SelectAll()
                zFireLocationListingQry.Where(zFireLocationListingQry.FileNo = zFileNo)
                zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = zSafeGUID)

                SetFilterCriteria(zSafeGUID, zFireLocationListingQry)

                zFireLocationListingCollection.Load(zFireLocationListingQry)

                zFireLocationListingCollection(0).RecCount = zRecCount
                zFireLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zFireLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        Private Sub SetFilterCriteria(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingFireRecommendationQuery)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFindFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findFileNo)
            Dim zFindClientLocNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findClientLocNo)
            Dim zFindAddress1 As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findAddress1)
            Dim zFindCity As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findCity)
            Dim zFindStProv As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findStProv)
            Dim zFindCountry As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findCountry)
            Dim zFindZip As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findZip)
            Dim zFindDivision As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findDivision)
            Dim zFindFacility As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findFacility)
            Dim zFindCustomAccess As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findCustomAccess)
            Dim zFindLongitude As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findLongitude)
            Dim zFindLatitude As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findLatitude)

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentFire(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentFire(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentFire(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentFire(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentFire(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentFire(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentFire(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentFire(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentFire(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentFire(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentFire(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentFire(zFindLatitude)))

        End Sub

        Private Sub GetRecCountPositionRecommendationFileNo(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 2
            pRecPosition = 13
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zFireLocationListingQry As New ViewCCLocationListingFireRecommendationQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireRecommendationCollection

            zFireLocationListingQry.es.Distinct = True
            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = pSafeGUID)
            zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRecommendationMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteria(pSafeGUID, zFireLocationListingQry)

            zFireLocationListingCollection.Load(zFireLocationListingQry)
            pRecCount = zFireLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingFireRecommendation In zFireLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateRecommendationFileNo(pSafeGUID As String, pDirection As String)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zFireLocationListingQry As New ViewCCLocationListingFireRecommendationQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireRecommendationCollection

            zFireLocationListingQry.es.Distinct = True
            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = pSafeGUID)
            zFireLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo > zFileNo)
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRecommendationMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo < zFileNo)
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRecommendationMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRecommendationMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRecommendationMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteria(pSafeGUID, zFireLocationListingQry)

            zFireLocationListingCollection.Load(zFireLocationListingQry)

            Dim zNewFileNo As String = ""

            If zFireLocationListingCollection.Count > 0 Then
                zNewFileNo = zFireLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zFileNo)
        End Sub

#End Region

#Region "IviewCCFireFacilityRating Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationFireRatingCollections(pParms As String) As jsResponse(Of ViewCCLocationListingFireRatingCollection, ViewCCLocationListingFireRating)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingFireRatingCollection, ViewCCLocationListingFireRating)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateRatingFileNo(zSafeGUID, zDirection)
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionRatingFileNo(zRecCount, zRecPosition, zSafeGUID)
                '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zFireLocationListingQry As New ViewCCLocationListingFireRatingQuery("t1")

                Dim zFireLocationListingCollection As New ViewCCLocationListingFireRatingCollection

                zFireLocationListingQry.es.Distinct = True
                zFireLocationListingQry.SelectAll()
                zFireLocationListingQry.Where(zFireLocationListingQry.FileNo = zFileNo)
                zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = zSafeGUID)

                SetFilterCriteria(zSafeGUID, zFireLocationListingQry)

                zFireLocationListingCollection.Load(zFireLocationListingQry)

                zFireLocationListingCollection(0).RecCount = zRecCount
                zFireLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zFireLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        Private Sub SetFilterCriteria(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingFireRatingQuery)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFindFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findFileNo)
            Dim zFindClientLocNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findClientLocNo)
            Dim zFindAddress1 As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findAddress1)
            Dim zFindCity As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findCity)
            Dim zFindStProv As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findStProv)
            Dim zFindCountry As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findCountry)
            Dim zFindZip As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findZip)
            Dim zFindDivision As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findDivision)
            Dim zFindFacility As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findFacility)
            Dim zFindCustomAccess As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findCustomAccess)
            Dim zFindLongitude As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findLongitude)
            Dim zFindLatitude As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.findLatitude)

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentFire(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentFire(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentFire(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentFire(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentFire(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentFire(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentFire(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentFire(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentFire(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentFire(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentFire(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentFire(zFindLatitude)))

        End Sub

        Private Sub GetRecCountPositionRatingFileNo(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 2
            pRecPosition = 13
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zFireLocationListingQry As New ViewCCLocationListingFireRatingQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireRatingCollection

            zFireLocationListingQry.es.Distinct = True
            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = pSafeGUID)
            zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteria(pSafeGUID, zFireLocationListingQry)

            zFireLocationListingCollection.Load(zFireLocationListingQry)
            pRecCount = zFireLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingFireRating In zFireLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateRatingFileNo(pSafeGUID As String, pDirection As String)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zFireLocationListingQry As New ViewCCLocationListingFireRatingQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireRatingCollection

            zFireLocationListingQry.es.Distinct = True
            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = pSafeGUID)
            zFireLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo > zFileNo)
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo < zFileNo)
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteria(pSafeGUID, zFireLocationListingQry)

            zFireLocationListingCollection.Load(zFireLocationListingQry)

            Dim zNewFileNo As String = ""

            If zFireLocationListingCollection.Count > 0 Then
                zNewFileNo = zFireLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)

        End Sub

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCFireFacilityRatingCollection(pParms As String) As jsResponse(Of ViewCCFireFacilityRatingCollection, ViewCCFireFacilityRating)
            Dim response As New jsResponse(Of ViewCCFireFacilityRatingCollection, ViewCCFireFacilityRating)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            'DETERMINE IF WE ARE COMING FROM A CHART TO LOAD THE FACILITY RATING OR DETAILS PAGE
            Dim zIsFromChart As Boolean = CBool(zParms(2))
            Dim zKeyName As String = UtilGSafe.KeyName.FileNo
            If zIsFromChart Then zKeyName = UtilGSafe.KeyName.FileNoFromChart

            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, zKeyName)

            Try
                Dim collection As New ViewCCFireFacilityRatingCollection()
                Dim query As New ViewCCFireFacilityRatingQuery

                query.SelectAll()
                query.Where(query.GSafeGUID = zSafeGUID)

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        query.es.Top = 1
                    End If
                End If

                query.Where(query.Fileno = zFileNo)
                query.OrderBy(ViewCCFireFacilityRatingMetadata.ColumnNames.Inspectiondate, esOrderByDirection.Descending)

                collection.Load(query)
                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .Id = 0
                        .Fileno = "not found" 'this value cannot change for error detection
                        .Inspectiondate = "1/1/1900"
                        .Floodweight = 0
                        .Earthquakeweight = 0
                        .Windstormweight = 0
                        .Constructionweight = 0
                        .Occupancyweight = 0
                        .Otherweight = 0
                        .Floodrating = 0
                        .Earthquakerating = 0
                        .Windstormrating = 0
                        .Constructionrating = 0
                        .Occupancyrating = 0
                        .Otherrating = 0
                        .Flooddescription = ""
                        .Earthquakedescription = ""
                        .Windstormdescription = ""
                        .Constructiondescription = ""
                        .Occupancydescription = ""
                        .Otherdescription = ""
                        .Passivescore = 0
                        .Physicalprotectionweight = 0
                        .Humanelementweight = 0
                        .Naturalhazardsprotectionweight = 0
                        .Businesscontinuityweight = 0
                        .Physicalprotectionrating = 0
                        .Humanelementrating = 0
                        .Naturalhazardsprotectionrating = 0
                        .Businesscontinuityrating = 0
                        .Firedescription = ""
                        .Humandescription = ""
                        .Naturaldescription = ""
                        .Businessdescription = ""
                        .Fireprotectionallrecscompleterating = 0
                        .Humanelementallrecscompleterating = 0
                        .Nathazprotallrecscompleterating = 0
                        .Bcpallrecscompletrating = 0
                        .Firerecdescription = ""
                        .Humanrecdescription = ""
                        .Naturalrecdescription = ""
                        .Businessrecdescription = ""
                        .Activescore = 0
                        .Activescorewithrecscomplete = 0
                        .Apl = 0
                        .Totalscore = 0
                        .Aplfactor = 0
                        .Overallplantratingrating = ""
                        .Aplwithallrecscomplete = 0
                        .Overallscorewithrecscomplete = 0
                        .Aplfactorwithallrecscomplete = 0
                        .Maxpossiblescore = 0
                        .Floodratingcolor = ""
                        .Earthquakeratingcolor = ""
                        .Windstormratingcolor = ""
                        .Constructionratingcolor = ""
                        .Occupancyratingcolor = ""
                        .Otherratingcolor = ""
                        .Physicalprotectionratingcolor = ""
                        .Humanelementratingcolor = ""
                        .Naturalhazardsprotectionratingcolor = ""
                        .Businesscontinuityratingcolor = ""
                        .Fireprotectionallrecscompleteratingcolor = ""
                        .Humanelementallrecscompleteratingcolor = ""
                        .Nathazprotallrecscompleteratingcolor = ""
                        .Bcpallrecscompletratingcolor = ""
                        .Totalscorecolor = ""
                        .Maxpossiblescorecolor = ""
                        .Maxpossiblescoredescription = ""
                        .APLKeyRange1 = ""
                        .APLKeyFactor1 = ""
                        .APLKeyRange2 = ""
                        .APLKeyFactor2 = ""
                        .APLKeyRange3 = ""
                        .APLKeyFactor3 = ""
                        .APLKeyRange4 = ""
                        .APLKeyFactor4 = ""
                        .RatingKeyDescription1 = ""
                        .RatingKeyDescription2 = ""
                        .RatingKeyDescription3 = ""
                        .RatingKeyDescription4 = ""
                        .RatingKeyDescription5 = ""
                        .RatingKeyColor1 = ""
                        .RatingKeyColor2 = ""
                        .RatingKeyColor3 = ""
                        .RatingKeyColor4 = ""
                        .RatingKeyColor5 = ""
                    End With

                End If

                For Each zRating As ViewCCFireFacilityRating In collection
                    If Not zRating.APLString Is Nothing Then
                        zRating.APLString = zRating.CurrencySymbol & Format(Math.Round(CDec(zRating.Apl), 0), "#,###")
                    End If
                    If Not zRating.APLWITHALLRECSCOMPLETEString Is Nothing Then
                        zRating.APLWITHALLRECSCOMPLETEString = zRating.CurrencySymbol & Format(Math.Round(CDec(zRating.Aplwithallrecscomplete), 0), "#,###")
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function
#End Region

#Region "IviewCCBMFacilityRating Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCBMFacilityRatingCollection(pParms As String) As jsResponse(Of ViewCCBMFacilityRatingCollection, ViewCCBMFacilityRating)
            Dim response As New jsResponse(Of ViewCCBMFacilityRatingCollection, ViewCCBMFacilityRating)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            'DETERMINE IF WE ARE COMING FROM A CHART TO LOAD THE FACILITY RATING OR DETAILS PAGE
            Dim zIsFromChart As Boolean = CBool(zParms(2))
            Dim zKeyName As String = UtilGSafe.KeyName.FileNo
            If zIsFromChart Then zKeyName = UtilGSafe.KeyName.FileNoFromChart


            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, zKeyName)

            Try
                Dim collection As New ViewCCBMFacilityRatingCollection()
                Dim query As New ViewCCBMFacilityRatingQuery

                query.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        query.es.Top = 1
                    End If
                End If

                query.Where(query.FileNo = zFileNo)
                query.OrderBy(ViewCCBMFacilityRatingMetadata.ColumnNames.InspectionDate, esOrderByDirection.Descending)

                collection.Load(query)
                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .Id = 0
                        .FileNo = "not found" 'this value cannot change for error detection
                        .InspectionDate = "1/1/1900"
                        .MechEquipC = 0
                        .ElecEquipC = 0
                        .BoilersC = 0
                        .ProcEquipC = 0
                        .OccupancyC = 0
                        .CompSysC = 0
                        .MechMaintC = 0
                        .ElecMaintC = 0
                        .SparesC = 0
                        .HumanElementC = 0
                        .Bcpc = 0
                        .MechEquipWR = 0
                        .ElecEquipWR = 0
                        .BoilersWR = 0
                        .ProcEquipWR = 0
                        .OccupancyWR = 0
                        .CompSysWR = 0
                        .MechMaintWR = 0
                        .ElecMaintWR = 0
                        .SparesWR = 0
                        .HumanElementWR = 0
                        .Bcpwr = 0
                        .MechEquipWeight = 0
                        .ElecEquipWeight = 0
                        .BoilersWeight = 0
                        .ProcEquipWeight = 0
                        .OccupancyWeight = 0
                        .CompSysWeight = 0
                        .MechMaintWeight = 0
                        .ElecMaintWeight = 0
                        .SparesWeight = 0
                        .HumanElementWeight = 0
                        .BCPWeight = 0
                        .PassiveC = 0
                        .PassiveWC = 0
                        .ActiveC = 0
                        .ActiveWC = 0
                        .TotalScoreCurrent = 0
                        .TotalRating = ""
                        .TotalWRComplete = 0
                        .MechEquipDesc = ""
                        .ElecEquipDesc = ""
                        .BoilersDesc = ""
                        .ProcEquipDesc = ""
                        .OccupancyDesc = ""
                        .CompSysDesc = ""
                        .MechMaintDesc = ""
                        .ElecMaintDesc = ""
                        .SparesDesc = ""
                        .HumanElementDesc = ""
                        .BCPDesc = ""
                        .MechEquipWRDesc = ""
                        .ElecEquipWRDesc = ""
                        .BoilersWRDesc = ""
                        .ProcEquipWRDesc = ""
                        .OccupancyWRDesc = ""
                        .CompSysWRDesc = ""
                        .MechMaintWRDesc = ""
                        .ElecMaintWRDesc = ""
                        .SparesWrDesc = ""
                        .HumanElementWRDesc = ""
                        .BCPWRDesc = ""
                        .OverallPlantRatingRating = ""
                        .TotalWRCompleteRating = ""
                        .MechEquipCColor = ""
                        .ElecEquipCColor = ""
                        .BoilersCColor = ""
                        .ProcEquipCColor = ""
                        .OccupancyCColor = ""
                        .CompSysCColor = ""
                        .MechEquipWRColor = ""
                        .ElecEquipWRColor = ""
                        .BoilersWRColor = ""
                        .ProcEquipWRColor = ""
                        .OccupancyWRColor = ""
                        .CompSysWRColor = ""
                        .MechMaintCColor = ""
                        .ElecMaintCColor = ""
                        .SparesCColor = ""
                        .HumanElementCColor = ""
                        .BCPCColor = ""
                        .MechMaintWRColor = ""
                        .ElecMaintWRColor = ""
                        .SparesWRColor = ""
                        .HumanElementWRColor = ""
                        .BCPWRColor = ""
                        .OverallPlantRatingRatingColor = ""
                        .OverallPlantRatingRatingDescription = ""
                        .RatingKeyDescription1 = ""
                        .RatingKeyDescription2 = ""
                        .RatingKeyDescription3 = ""
                        .RatingKeyDescription4 = ""
                        .RatingKeyDescription5 = ""
                        .RatingKeyColor1 = ""
                        .RatingKeyColor2 = ""
                        .RatingKeyColor3 = ""
                        .RatingKeyColor4 = ""
                        .RatingKeyColor5 = ""
                    End With

                End If
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

#End Region

#Region "IviewCCGaugeStats Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCGaugeStatsCollection(pSafeGuid As String) As jsResponse(Of ViewCCGaugeStatsCollection, ViewCCGaugeStats)
            Dim response As New jsResponse(Of ViewCCGaugeStatsCollection, ViewCCGaugeStats)()
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FilePreFix)

            Try
                Dim collection As New ViewCCGaugeStatsCollection()
                Dim query As New ViewCCGaugeStatsQuery

                query.SelectAll()
                query.Where(query.FilePrefix = zFilePrefix)
                query.Where(query.GSafeGUID = pSafeGuid)

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

#End Region

#Region "IviewCCRecommendationGrid Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCNHRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCNHRecommendationGridCollection, ViewCCNHRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCNHRecommendationGridCollection, ViewCCNHRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
            Try
                Dim collection As New ViewCCNHRecommendationGridCollection()
                Dim query As New ViewCCNHRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCNHRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCFireRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCBMRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCBMRecommendationGridCollection, ViewCCBMRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCBMRecommendationGridCollection, ViewCCBMRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCBMRecommendationGridCollection()
                Dim query As New ViewCCBMRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCBMRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCIRRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCIRRecommendationGridCollection, ViewCCIRRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCIRRecommendationGridCollection, ViewCCIRRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCIRRecommendationGridCollection()
                Dim query As New ViewCCIRRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.OrderBy(ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecYear = 0
                        .Severityrating = ""
                        .Recommendation = ""
                        .RecommendationID = 0
                        .FindEquip = ""
                        .Findingno = 0
                        .Itemno = 0
                        .PlantAreaAffected = ""
                        .FaultType = ""
                        .ProbableEquipmentDamageCost = 0
                        .LengthOfBusinessInterruption = ""
                        .CostOfBusinessInterruption = 0
                        .DetectedWith = ""
                        .Impact = ""
                        .Comments2 = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .ResponseFrom = ""
                        .ResponseDate = "1/1/1900"
                        .ResponseComment = ""
                        .ResponseStatus = ""
                        .RedundancySpare = ""
                        .RecPrimary = ""
                        .RecSecondary = ""
                        .IntendedAction = ""
                        .PlantComment = ""
                        .Id = 0
                        .History = ""
                        .Comments = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCIRRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCSeismicRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo, query.Hazard.ToLower() = "Seismic".ToLower())
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCFloodRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo, query.Hazard.ToLower() = "Flood".ToLower())
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCWindRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo, query.Hazard.ToLower() = "Wind".ToLower())
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function viewCCPSRecommendationGridCollection(pParms As String) As jsResponse(Of ViewCCPSRecommendationGridCollection, ViewCCPSRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCPSRecommendationGridCollection, ViewCCPSRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim collection As New ViewCCPSRecommendationGridCollection()
                Dim query As New ViewCCPSRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCPSRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


        '********************

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFireRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetNHRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCNHRecommendationGridCollection, ViewCCNHRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCNHRecommendationGridCollection, ViewCCNHRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCNHRecommendationGridCollection()
                Dim query As New ViewCCNHRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCNHRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCNHRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCBMRecommendationGridCollection, ViewCCBMRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCBMRecommendationGridCollection, ViewCCBMRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCBMRecommendationGridCollection()
                Dim query As New ViewCCBMRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCBMRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCBMRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetIRRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCIRRecommendationGridCollection, ViewCCIRRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCIRRecommendationGridCollection, ViewCCIRRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCIRRecommendationGridCollection()
                Dim query As New ViewCCIRRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecYear = 0
                        .Severityrating = ""
                        .Recommendation = ""
                        .RecommendationID = 0
                        .FindEquip = ""
                        .Findingno = 0
                        .Itemno = 0
                        .PlantAreaAffected = ""
                        .FaultType = ""
                        .ProbableEquipmentDamageCost = 0
                        .LengthOfBusinessInterruption = ""
                        .CostOfBusinessInterruption = 0
                        .DetectedWith = ""
                        .Impact = ""
                        .Comments2 = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .ResponseFrom = ""
                        .ResponseDate = "1/1/1900"
                        .ResponseComment = ""
                        .ResponseStatus = ""
                        .RedundancySpare = ""
                        .RecPrimary = ""
                        .RecSecondary = ""
                        .IntendedAction = ""
                        .PlantComment = ""
                        .Id = 0
                        .History = ""
                        .Comments = ""
                        .ExpectedCompletionDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCIRRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetSeismicRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo, query.Hazard.ToLower() = "Seismic".ToLower())
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFloodRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo, query.Hazard.ToLower() = "Flood".ToLower())
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetWindRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCFireRecommendationGridCollection, ViewCCFireRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCFireRecommendationGridCollection()
                Dim query As New ViewCCFireRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo, query.Hazard.ToLower() = "Wind".ToLower())
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCFireRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCFireRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetPSRecommendationGridByFileNo(pParms As String) As jsResponse(Of ViewCCPSRecommendationGridCollection, ViewCCPSRecommendationGrid)
            Dim response As New jsResponse(Of ViewCCPSRecommendationGridCollection, ViewCCPSRecommendationGrid)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim collection As New ViewCCPSRecommendationGridCollection()
                Dim query As New ViewCCPSRecommendationGridQuery

                query.SelectAll()
                query.Where(query.FileNo = zFileNo)
                query.Where(query.RecStatus.ToLower() <> "conf completed" And query.RecStatus.ToLower() <> "advisory" And query.RecStatus.ToLower() <> "removed")
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecMo, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                query.OrderBy(ViewCCPSRecommendationGridMetadata.ColumnNames.RecSubLetter, esOrderByDirection.Ascending)
                collection.Load(query)

                If collection.Count = 0 Then
                    collection.AddNew() 'create a blank record when no matching records existing
                    With collection(0)
                        .FileNo = "not found"
                        .RecYear = 0
                        .RecMo = ""
                        .RecNumber = 0
                        .RecSubLetter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecImpact = ""
                        .Hazard = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeywords = ""
                        .CurrentLERange = ""
                        .CompletedLERange = ""
                        .EstCostToCompleteRange = ""
                        .ActualCostToComplete = 0
                        .ExpdComplDate = "1/1/1900"
                        .SavingsRatio = 0
                        .IntendedAction = ""
                        .RespDate = "1/1/1900"
                        .RespFrom = "1/1/1900"
                        .FacilityComment = ""
                        .MgmtRespDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCPSRecommendationGrid In collection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpdComplDate Is Nothing Then
                        zItem.ExpdComplDate = zTime.ServerToUTC(zItem.ExpdComplDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.RespDate Is Nothing Then
                        zItem.RespDate = zTime.ServerToUTC(zItem.RespDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function



#End Region

#Region "IViewCCImpairmentsFormFire Members"

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function ViewCCImpairmentsFormFireCollections(pSafeGuid As String) As jsResponse(Of ViewCCImpairmentsFormFireCollection, ViewCCImpairmentsFormFire)

        '    Throw New NotImplementedException("Not Implemented")

        '    'Dim response As New jsResponse(Of ViewCCImpairmentsFormFireCollection, ViewCCImpairmentsFormFire)()
        '    ''***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
        '    'Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)

        '    'Try
        '    '    Dim collection As New ViewCCImpairmentsFormFireCollection()
        '    '    Dim query As New ViewCCImpairmentsFormFireQuery

        '    '    query.SelectAll()
        '    '    query.Where(query.FileNo = zFileNo)
        '    '    collection.Load(query)
        '    '    response.collection = collection

        '    'Catch ex As Exception
        '    '    response.exception = ex.Message
        '    'End Try

        '    'Return response
        'End Function

#End Region

        '#Region "IViewCCWhatsNew Members"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function GetWhatsNewList(pParms As String) As jsResponse(Of ViewCCWhatsNewCollection, ViewCCWhatsNew)
        '            Dim zResponse As New jsResponse(Of ViewCCWhatsNewCollection, ViewCCWhatsNew)()
        '            Dim zParms As String = pParms 'NOT USED

        '            Try
        '                Dim zColl As New ViewCCWhatsNewCollection()
        '                Dim zQry As New ViewCCWhatsNewQuery

        '                zQry.Select()
        '                zQry.Where(zQry.Active = True)
        '                zColl.Load(zQry)
        '                zResponse.collection = zColl

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '            End Try

        '            Return zResponse
        '        End Function

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function GetWhatsNewArticle(pParms As String) As jsResponse(Of ViewCCWhatsNewCollection, ViewCCWhatsNew)
        '            Dim zResponse As New jsResponse(Of ViewCCWhatsNewCollection, ViewCCWhatsNew)()
        '            Dim zID As String = pParms

        '            Try
        '                Dim zColl As New ViewCCWhatsNewCollection()
        '                Dim zQry As New ViewCCWhatsNewQuery

        '                zQry.Select()
        '                zQry.es.Top = 1
        '                zQry.Where(zQry.Id = zID)
        '                zColl.Load(zQry)
        '                zResponse.collection = zColl

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '            End Try

        '            Return zResponse
        '        End Function


        '#End Region

#Region "Recommendation Response Collections"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsBM(pParms As String) As jsResponse(Of ViewCCBMRecommendationCountsCollection, ViewCCBMRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCBMRecommendationCountsCollection, ViewCCBMRecommendationCounts)()
            Dim zCollCount As New ViewCCBMRecommendationCountsCollection
            Dim zColl As New BMRecommendationsCollection
            Dim zQry As New BMRecommendationsQuery
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New BMRecommendationsCollection
                zQry = New BMRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsFire(pParms As String) As jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)()
            Dim zCollCount As New ViewCCFireRecommendationCountsCollection
            Dim zColl As New FireRecommendationsCollection
            Dim zQry As New FireRecommendationsQuery
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New FireRecommendationsCollection
                zQry = New FireRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsIR(pParms As String) As jsResponse(Of ViewCCIRRecommendationCountsCollection, ViewCCIRRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCIRRecommendationCountsCollection, ViewCCIRRecommendationCounts)()
            Dim zCollCount As New ViewCCIRRecommendationCountsCollection
            Dim zColl As New FindingsCollection
            Dim zQry As New FindingsQuery
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New FindingsCollection
                zQry = New FindingsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsSeismic(pParms As String) As jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)()
            Dim zCollCount As New ViewCCFireRecommendationCountsCollection
            Dim zColl As New FireRecommendationsCollection
            Dim zQry As New FireRecommendationsQuery
            Dim zHazardName As String = UtilPractice.Seismic().ToLower()
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.Hazard.ToLower() = zHazardName)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New FireRecommendationsCollection
                zQry = New FireRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.Hazard.ToLower = zHazardName)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsFlood(pParms As String) As jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)()
            Dim zCollCount As New ViewCCFireRecommendationCountsCollection
            Dim zColl As New FireRecommendationsCollection
            Dim zQry As New FireRecommendationsQuery
            Dim zHazardName As String = UtilPractice.Flood().ToLower()
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.Hazard.ToLower() = zHazardName)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New FireRecommendationsCollection
                zQry = New FireRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.Hazard.ToLower = zHazardName)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsWind(pParms As String) As jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)()
            Dim zCollCount As New ViewCCFireRecommendationCountsCollection
            Dim zColl As New FireRecommendationsCollection
            Dim zQry As New FireRecommendationsQuery
            Dim zHazardName As String = UtilPractice.Wind().ToLower()
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.Hazard.ToLower() = zHazardName)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New FireRecommendationsCollection
                zQry = New FireRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.Hazard.ToLower = zHazardName)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsNatHaz(pParms As String) As jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCFireRecommendationCountsCollection, ViewCCFireRecommendationCounts)()
            Dim zCollCount As New ViewCCFireRecommendationCountsCollection
            Dim zColl As New FireRecommendationsCollection
            Dim zQry As New FireRecommendationsQuery
            'Dim zHazardName As String = UtilPractice.Wind().ToLower()
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                'zQry.Where(zQry.Hazard.ToLower() = zHazardName)
                'zQry.Where(zQry.Hazard.ToLower().Like(UtilPractice.Flood().ToLower()))
                'zQry.Where(zQry.Hazard.ToLower().Like(UtilPractice.Seismic().ToLower()))
                'zQry.Where(zQry.Hazard.ToLower().Like(UtilPractice.Wind().ToLower()))
                zQry.Where(zQry.Hazard.ToLower().NotLike(UtilPractice.Fire().ToLower()))
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New FireRecommendationsCollection
                zQry = New FireRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                'zQry.Where(zQry.Hazard.ToLower = zHazardName)
                'zQry.Where(zQry.Hazard.ToLower().Like(UtilPractice.Flood().ToLower()))
                'zQry.Where(zQry.Hazard.ToLower().Like(UtilPractice.Seismic().ToLower()))
                'zQry.Where(zQry.Hazard.ToLower().Like(UtilPractice.Wind().ToLower()))
                zQry.Where(zQry.Hazard.ToLower().NotLike(UtilPractice.Fire().ToLower()))
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecommendationCountsPS(pParms As String) As jsResponse(Of ViewCCPSRecommendationCountsCollection, ViewCCPSRecommendationCounts)
            Dim zResponse As New jsResponse(Of ViewCCPSRecommendationCountsCollection, ViewCCPSRecommendationCounts)()
            Dim zCollCount As New ViewCCPSRecommendationCountsCollection
            Dim zColl As New PSRecommendationsCollection
            Dim zQry As New PSRecommendationsQuery
            Dim zFileNo As String = ""
            Dim zTotal As Integer = 0
            Dim zCompleted As Integer = 0

            Try
                ' GET COMPLETED RECS
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                If zColl.Load(zQry) Then
                    zCompleted = zColl.Count
                End If

                ' GET TOTAL RECS
                zColl = New PSRecommendationsCollection
                zQry = New PSRecommendationsQuery
                zQry.Select()
                zQry.Where(zQry.FileNo = pParms)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                If zColl.Load(zQry) Then
                    zTotal = zColl.Count
                End If

                ' PACKAGE TOGETHER AND SEND BACK TO CLIENT
                zCollCount.AddNew()
                zCollCount(0).ResponsesTotal = zTotal
                zCollCount(0).ResponsesCompleted = zCompleted
                zResponse.collection = zCollCount
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

#End Region

#Region "Admin Window Information"

#Region "Rec Response"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseBMCollection, ViewCCAdminWindowRecResponseBM)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseBMCollection, ViewCCAdminWindowRecResponseBM)()
            Dim zColl As New ViewCCAdminWindowRecResponseBMCollection
            Dim zQry As New ViewCCAdminWindowRecResponseBMQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zGSafeGuid As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            ' GET INFORMATION IF NO ITEMS FOUND
            Dim zCollListing As New ViewCCLocationListingBMCollection
            Dim zQryListing As New ViewCCLocationListingBMQuery
            Dim zCollRec As New BMRecommendationsCollection
            Dim zQryRec As New BMRecommendationsQuery
            Dim zTime As New UtilTime
            Dim zInspectionDate As Date = "1/1/1900"
            Dim zLatestStatusDate As Date = "1/1/1900"
            Dim zStatusDateCount As Integer = 0
            Dim zRecCount As Integer = 0

            Try
                ' GET INSPECTION DATE
                zQryListing.es.Top = 1
                zQryListing.Select(zQryListing.BMActualDate)
                zQryListing.Where(zQryListing.FileNo = zFileNo)
                If zCollListing.Load(zQryListing) Then
                    If Not zCollListing(0).BMActualDate Is Nothing Then
                        zInspectionDate = zCollListing(0).BMActualDate
                    End If
                End If

                ' GET STATUS DATE
                zQryRec.es.Top = 1
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                zQryRec.OrderBy(zQryRec.StatusDate.Descending)
                If zCollRec.Load(zQryRec) Then
                    If Not zCollRec(0).StatusDate Is Nothing Then
                        zLatestStatusDate = zCollRec(0).StatusDate
                    End If
                End If

                ' GET UNIQUE STATUS DATE COUNT
                zQryRec = New BMRecommendationsQuery
                zQryRec.es.Distinct = True
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zStatusDateCount = zCollRec.Count
                End If

                ' GET FULL REC COUNT
                zQryRec = New BMRecommendationsQuery
                zQryRec.Select(zQryRec.FileNo)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zRecCount = zCollRec.Count
                End If

                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = 0
                            .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = zRecCount
                            .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                            .StatusDateCount = zStatusDateCount
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = 0
                        .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = zRecCount
                        .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                        .StatusDateCount = zStatusDateCount
                    End With
                End If

                If zStatusDateCount = 0 Then zColl(0).StatusDateCount = 0
                If zRecCount = 0 Then zColl(0).RecCount = 0

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFireInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseFireCollection, ViewCCAdminWindowRecResponseFire)
            ' FIRE
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseFireCollection, ViewCCAdminWindowRecResponseFire)()
            Dim zColl As New ViewCCAdminWindowRecResponseFireCollection
            Dim zQry As New ViewCCAdminWindowRecResponseFireQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zGSafeGuid As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            ' GET INFORMATION IF NO ITEMS FOUND
            Dim zCollListing As New ViewCCLocationListingFireCollection
            Dim zQryListing As New ViewCCLocationListingFireQuery
            Dim zCollRec As New FireRecommendationsCollection
            Dim zQryRec As New FireRecommendationsQuery
            Dim zTime As New UtilTime
            Dim zInspectionDate As Date = "1/1/1900"
            Dim zLatestStatusDate As Date = "1/1/1900"
            Dim zStatusDateCount As Integer = 0
            Dim zRecCount As Integer = 0

            Try
                ' GET INSPECTION DATE
                zQryListing.es.Top = 1
                zQryListing.Select(zQryListing.FireActualDate)
                zQryListing.Where(zQryListing.FileNo = zFileNo)
                If zCollListing.Load(zQryListing) Then
                    If Not zCollListing(0).FireActualDate Is Nothing Then
                        zInspectionDate = zCollListing(0).FireActualDate
                    End If
                End If

                ' GET STATUS DATE
                zQryRec.es.Top = 1
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                zQryRec.OrderBy(zQryRec.StatusDate.Descending)
                If zCollRec.Load(zQryRec) Then
                    If Not zCollRec(0).StatusDate Is Nothing Then
                        zLatestStatusDate = zCollRec(0).StatusDate
                    End If
                End If

                ' GET UNIQUE STATUS DATE COUNT
                zQryRec = New FireRecommendationsQuery
                zQryRec.es.Distinct = True
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zStatusDateCount = zCollRec.Count
                End If

                ' GET FULL REC COUNT
                zQryRec = New FireRecommendationsQuery
                zQryRec.Select(zQryRec.FileNo)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.Hazard = "Fire" Or zQryRec.Hazard = "")
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zRecCount = zCollRec.Count
                End If

                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = 0
                            .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = zRecCount
                            .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                            .StatusDateCount = zStatusDateCount
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = 0
                        .InspectionDate = zInspectionDate
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = zRecCount
                        .LatestStatusDate = zLatestStatusDate
                        .StatusDateCount = zStatusDateCount
                    End With
                End If

                If zStatusDateCount = 0 Then zColl(0).StatusDateCount = 0
                If zRecCount = 0 Then zColl(0).RecCount = 0

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetIRInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseIRCollection, ViewCCAdminWindowRecResponseIR)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseIRCollection, ViewCCAdminWindowRecResponseIR)()
            Dim zColl As New ViewCCAdminWindowRecResponseIRCollection
            Dim zQry As New ViewCCAdminWindowRecResponseIRQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zGSafeGuid As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            ' GET INFORMATION IF NO ITEMS FOUND
            Dim zCollListing As New ViewCCLocationListingIRCollection
            Dim zQryListing As New ViewCCLocationListingIRQuery
            Dim zCollRec As New FindingsCollection
            Dim zQryRec As New FindingsQuery
            Dim zTime As New UtilTime
            Dim zInspectionDate As Date = "1/1/1900"
            Dim zLatestStatusDate As Date = "1/1/1900"
            Dim zStatusDateCount As Integer = 0
            Dim zRecCount As Integer = 0

            Try
                ' GET INSPECTION DATE
                zQryListing.es.Top = 1
                zQryListing.Select(zQryListing.IRActualDate)
                zQryListing.Where(zQryListing.FileNo = zFileNo)
                If zCollListing.Load(zQryListing) Then
                    If Not zCollListing(0).IRActualDate Is Nothing Then
                        zInspectionDate = zCollListing(0).IRActualDate
                    End If
                End If

                ' GET STATUS DATE
                zQryRec = New FindingsQuery
                zQryRec.es.Top = 1
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                zQryRec.OrderBy(zQryRec.StatusDate.Descending)
                If zCollRec.Load(zQryRec) Then
                    If Not zCollRec(0).StatusDate Is Nothing Then
                        zLatestStatusDate = zCollRec(0).StatusDate
                    End If
                End If

                ' GET UNIQUE STATUS DATE COUNT
                zQryRec = New FindingsQuery
                zQryRec.es.Distinct = True
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zStatusDateCount = zCollRec.Count
                End If

                ' GET FULL REC COUNT
                zQryRec = New FindingsQuery
                zQryRec.Select(zQryRec.FileNo)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zRecCount = zCollRec.Count
                End If

                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = 0
                            .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = zRecCount
                            .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                            .StatusDateCount = zStatusDateCount
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = 0
                        .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = zRecCount
                        .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                        .StatusDateCount = zStatusDateCount
                    End With
                End If

                If zStatusDateCount = 0 Then zColl(0).StatusDateCount = 0
                If zRecCount = 0 Then zColl(0).RecCount = 0

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetNatHazInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseNatHazCollection, ViewCCAdminWindowRecResponseNatHaz)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseNatHazCollection, ViewCCAdminWindowRecResponseNatHaz)()
            Dim zColl As New ViewCCAdminWindowRecResponseNatHazCollection
            Dim zQry As New ViewCCAdminWindowRecResponseNatHazQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zGSafeGuid As String = zParms(0)
            Dim zHazard As String = zParms(1)
            Dim zHemisphere As String = zParms(2)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            ' GET INFORMATION IF NO ITEMS FOUND
            Dim zCollListing As New ViewCCLocationListingFireCollection
            Dim zQryListing As New ViewCCLocationListingFireQuery
            Dim zCollRec As New FireRecommendationsCollection
            Dim zQryRec As New FireRecommendationsQuery
            Dim zTime As New UtilTime
            Dim zInspectionDate As Date = "1/1/1900"
            Dim zLatestStatusDate As Date = "1/1/1900"
            Dim zStatusDateCount As Integer = 0
            Dim zRecCount As Integer = 0

            Try
                ' GET INSPECTION DATE
                zQryListing.es.Top = 1
                zQryListing.Select(zQryListing.FireActualDate)
                zQryListing.Where(zQryListing.FileNo = zFileNo)
                If zCollListing.Load(zQryListing) Then
                    If Not zCollListing(0).FireActualDate Is Nothing Then
                        zInspectionDate = zCollListing(0).FireActualDate
                    End If
                End If

                ' GET STATUS DATE
                zQryRec.es.Top = 1
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                zQryRec.OrderBy(zQryRec.StatusDate.Descending)
                If zCollRec.Load(zQryRec) Then
                    If Not zCollRec(0).StatusDate Is Nothing Then
                        zLatestStatusDate = zCollRec(0).StatusDate
                    End If
                End If

                ' GET UNIQUE STATUS DATE COUNT
                zQryRec = New FireRecommendationsQuery
                zQryRec.es.Distinct = True
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zStatusDateCount = zCollRec.Count
                End If

                ' GET FULL REC COUNT
                zQryRec = New FireRecommendationsQuery
                zQryRec.Select(zQryRec.FileNo)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.Hazard <> "Fire")
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zRecCount = zCollRec.Count
                End If

                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = 0
                            .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = zRecCount
                            .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                            .StatusDateCount = zStatusDateCount
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = 0
                        .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = zRecCount
                        .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                        .StatusDateCount = zStatusDateCount
                    End With
                End If

                If zStatusDateCount = 0 Then zColl(0).StatusDateCount = 0
                If zRecCount = 0 Then zColl(0).RecCount = 0

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetJurisInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseJurisCollection, ViewCCAdminWindowRecResponseJuris)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseJurisCollection, ViewCCAdminWindowRecResponseJuris)()
            Dim zColl As New ViewCCAdminWindowRecResponseJurisCollection
            Dim zQry As New ViewCCAdminWindowRecResponseJurisQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.PracticeCode = 560 Or zQry.PracticeCode = 565)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = ""
                            .InspectionDate = "1/1/1900"
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = 0
                            .LatestStatusDate = "1/1/1900"
                            .StatusDateCount = 0
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = ""
                        .InspectionDate = "1/1/1900"
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = 0
                        .LatestStatusDate = "1/1/1900"
                        .StatusDateCount = 0
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetNHInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseNHCollection, ViewCCAdminWindowRecResponseNH)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseNHCollection, ViewCCAdminWindowRecResponseNH)()
            Dim zColl As New ViewCCAdminWindowRecResponseNHCollection
            Dim zQry As New ViewCCAdminWindowRecResponseNHQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zGSafeGuid As String = zParms(0)
            Dim zHazard As String = zParms(1)
            Dim zHemisphere As String = zParms(2)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            ' GET INFORMATION IF NO ITEMS FOUND
            Dim zCollListing As New ViewCCLocationListingNHCollection 'ViewCCLocationListingFireCollection
            Dim zQryListing As New ViewCCLocationListingNHQuery 'ViewCCLocationListingFireQuery
            Dim zCollRec As New FireRecommendationsCollection
            Dim zQryRec As New FireRecommendationsQuery
            Dim zTime As New UtilTime
            Dim zInspectionDate As Date = "1/1/1900"
            Dim zLatestStatusDate As Date = "1/1/1900"
            Dim zStatusDateCount As Integer = 0
            Dim zRecCount As Integer = 0

            Try
                ' GET INSPECTION DATE
                zQryListing.es.Top = 1
                zQryListing.Select(zQryListing.NHActualDate) 'FireActualDate
                zQryListing.Where(zQryListing.FileNo = zFileNo)
                If zCollListing.Load(zQryListing) Then
                    If Not zCollListing(0).NHActualDate Is Nothing Then 'FireActualDate
                        zInspectionDate = zCollListing(0).NHActualDate 'FireActualDate
                    End If
                End If

                ' GET STATUS DATE
                zQryRec.es.Top = 1
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                zQryRec.OrderBy(zQryRec.StatusDate.Descending)
                If zCollRec.Load(zQryRec) Then
                    If Not zCollRec(0).StatusDate Is Nothing Then
                        zLatestStatusDate = zCollRec(0).StatusDate
                    End If
                End If

                ' GET UNIQUE STATUS DATE COUNT
                zQryRec = New FireRecommendationsQuery
                zQryRec.es.Distinct = True
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zStatusDateCount = zCollRec.Count
                End If

                ' GET FULL REC COUNT
                zQryRec = New FireRecommendationsQuery
                zQryRec.Select(zQryRec.FileNo)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.Hazard <> "Fire")
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zRecCount = zCollRec.Count
                End If

                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = 0
                            .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = zRecCount
                            .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                            .StatusDateCount = zStatusDateCount
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = 0
                        .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = zRecCount
                        .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                        .StatusDateCount = zStatusDateCount
                    End With
                End If

                If zStatusDateCount = 0 Then zColl(0).StatusDateCount = 0
                If zRecCount = 0 Then zColl(0).RecCount = 0

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetDivServInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponseDiversifiedCollection, ViewCCAdminWindowRecResponseDiversified)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponseDiversifiedCollection, ViewCCAdminWindowRecResponseDiversified)()
            Dim zColl As New ViewCCAdminWindowRecResponseDiversifiedCollection
            Dim zQry As New ViewCCAdminWindowRecResponseDiversifiedQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.PracticeCode = 560 Or zQry.PracticeCode = 565)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = ""
                            .InspectionDate = "1/1/1900"
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = 0
                            .LatestStatusDate = "1/1/1900"
                            .StatusDateCount = 0
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = ""
                        .InspectionDate = "1/1/1900"
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = 0
                        .LatestStatusDate = "1/1/1900"
                        .StatusDateCount = 0
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetPSInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowRecResponsePSCollection, ViewCCAdminWindowRecResponsePS)
            ' PS
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowRecResponsePSCollection, ViewCCAdminWindowRecResponsePS)()

            Try

                Dim zColl As New ViewCCAdminWindowRecResponsePSCollection
                Dim zQry As New ViewCCAdminWindowRecResponsePSQuery
                Dim zParms() As String = Split(pParms, "|")
                Dim zGSafeGuid As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
                Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)


                ' GET INFORMATION IF NO ITEMS FOUND
                Dim zCollListing As New ViewCCLocationListingPSCollection
                Dim zQryListing As New ViewCCLocationListingPSQuery
                Dim zCollRec As New PSRecommendationsCollection
                Dim zQryRec As New PSRecommendationsQuery
                Dim zTime As New UtilTime
                Dim zInspectionDate As Date = "1/1/1900"
                Dim zLatestStatusDate As Date = "1/1/1900"
                Dim zStatusDateCount As Integer = 0
                Dim zRecCount As Integer = 0

                ' GET INSPECTION DATE
                zQryListing.es.Top = 1
                zQryListing.Select(zQryListing.PSActualDate)
                zQryListing.Where(zQryListing.FileNo = zFileNo)
                If zCollListing.Load(zQryListing) Then
                    If Not zCollListing(0).PSActualDate Is Nothing Then
                        zInspectionDate = zCollListing(0).PSActualDate
                    End If
                End If

                ' GET STATUS DATE
                zQryRec.es.Top = 1
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                zQryRec.OrderBy(zQryRec.StatusDate.Descending)
                If zCollRec.Load(zQryRec) Then
                    If Not zCollRec(0).StatusDate Is Nothing Then
                        zLatestStatusDate = zCollRec(0).StatusDate
                    End If
                End If

                ' GET UNIQUE STATUS DATE COUNT
                zQryRec = New PSRecommendationsQuery
                zQryRec.es.Distinct = True
                zQryRec.Select(zQryRec.StatusDate)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zStatusDateCount = zCollRec.Count
                End If

                ' GET FULL REC COUNT
                zQryRec = New PSRecommendationsQuery
                zQryRec.Select(zQryRec.FileNo)
                zQryRec.Where(zQryRec.FileNo = zFileNo)
                zQryRec.Where(zQryRec.RecStatus.ToLower() <> "conf completed" And zQryRec.RecStatus.ToLower() <> "advisory" And zQryRec.RecStatus.ToLower() <> "removed")
                If zCollRec.Load(zQryRec) Then
                    zRecCount = zCollRec.Count
                End If


                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .RRLogId = 0
                            .RRLogGuid = "not found"
                            .FileNo = ""
                            .CurrentLink = ""
                            .Sender = ""
                            .LastRecipientEmail = ""
                            .LastRecipientName = ""
                            .DateRecEmailed = "1/1/1900"
                            .PracticeCode = 0
                            .InspectionDate = zTime.ServerToUTC(zInspectionDate, zHemisphere)
                            .InspectionEmailedDate = "1/1/1900"
                            .LinkToReport = ""
                            .Activity = ""
                            .RecCount = zRecCount
                            .LatestStatusDate = zTime.ServerToUTC(zLatestStatusDate, zHemisphere)
                            .StatusDateCount = zStatusDateCount
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .RRLogId = 0
                        .RRLogGuid = "not found"
                        .FileNo = ""
                        .CurrentLink = ""
                        .Sender = ""
                        .LastRecipientEmail = ""
                        .LastRecipientName = ""
                        .DateRecEmailed = "1/1/1900"
                        .PracticeCode = 0
                        .InspectionDate = zInspectionDate
                        .InspectionEmailedDate = "1/1/1900"
                        .LinkToReport = ""
                        .Activity = ""
                        .RecCount = zRecCount
                        .LatestStatusDate = zLatestStatusDate
                        .StatusDateCount = zStatusDateCount
                    End With
                End If

                If zStatusDateCount = 0 Then zColl(0).StatusDateCount = 0
                If zRecCount = 0 Then zColl(0).RecCount = 0

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function


#End Region

#Region "User Activity"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetUserActivityGridByGuid(pGSafeGUID As String) As jsResponse(Of ViewCCUserActivityGridCollection, ViewCCUserActivityGrid)
            Dim zResponse As New jsResponse(Of ViewCCUserActivityGridCollection, ViewCCUserActivityGrid)()

            Try
                Dim zUserColl As New ViewCCUserActivityGridCollection
                Dim zUserQry As New ViewCCUserActivityGridQuery
                Dim zInternalColl As New ViewCCUserActivityGridCollection
                Dim zInternalQry As New ViewCCUserActivityGridQuery
                '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
                Dim zEmail As String = UtilGSafe.GetValue(pGSafeGUID, UtilGSafe.KeyName.UserEmail)
                Dim zFilePrefix As String = UtilGSafe.GetValue(pGSafeGUID, UtilGSafe.KeyName.FilePreFix)

                zUserQry.SelectAll()
                zUserQry.Where(zUserQry.FilePrefix = zFilePrefix)
                ' zUserQry.Where(zUserQry.GRCAdministrator.IsNull Or zUserQry.GRCAdministrator = "")

                ' IF THE USER HAS ANY INTERNAL USERS IN THE LIST SHOW BOTH TRUE AND FALSE, ELSE SHOW ONLY FALSE
                zInternalQry.Select(zInternalQry.Internal)
                If zInternalColl.Load(zInternalQry) Then
                    If zInternalColl.Count < 1 Then
                        zUserQry.Where(zUserQry.Internal = False)
                    End If
                End If

                zUserColl.Load(zUserQry)
                zResponse.collection = zUserColl

            Catch ex As Exception
                zResponse.exception = ex.Message

            End Try

            Return zResponse

        End Function
#End Region

#Region "Document Manager"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerBMCollection, ViewCCAdminWindowDocManagerBM)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerBMCollection, ViewCCAdminWindowDocManagerBM)()
            Dim zColl As New ViewCCAdminWindowDocManagerBMCollection
            Dim zQry As New ViewCCAdminWindowDocManagerBMQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFireDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerFireCollection, ViewCCAdminWindowDocManagerFire)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerFireCollection, ViewCCAdminWindowDocManagerFire)()
            Dim zColl As New ViewCCAdminWindowDocManagerFireCollection
            Dim zQry As New ViewCCAdminWindowDocManagerFireQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .ReportArchiveID = 0
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .ReportArchiveID = 0
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetIRDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerIRCollection, ViewCCAdminWindowDocManagerIR)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerIRCollection, ViewCCAdminWindowDocManagerIR)()
            Dim zColl As New ViewCCAdminWindowDocManagerIRCollection
            Dim zQry As New ViewCCAdminWindowDocManagerIRQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetJurisDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerJurisCollection, ViewCCAdminWindowDocManagerJuris)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerJurisCollection, ViewCCAdminWindowDocManagerJuris)()
            Dim zColl As New ViewCCAdminWindowDocManagerJurisCollection
            Dim zQry As New ViewCCAdminWindowDocManagerJurisQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = ""
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = ""
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFloodDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerFloodCollection, ViewCCAdminWindowDocManagerFlood)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerFloodCollection, ViewCCAdminWindowDocManagerFlood)()
            Dim zColl As New ViewCCAdminWindowDocManagerFloodCollection
            Dim zQry As New ViewCCAdminWindowDocManagerFloodQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetSeismicDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerSeismicCollection, ViewCCAdminWindowDocManagerSeismic)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerSeismicCollection, ViewCCAdminWindowDocManagerSeismic)()
            Dim zColl As New ViewCCAdminWindowDocManagerSeismicCollection
            Dim zQry As New ViewCCAdminWindowDocManagerSeismicQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetWindDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerWindCollection, ViewCCAdminWindowDocManagerWind)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerWindCollection, ViewCCAdminWindowDocManagerWind)()
            Dim zColl As New ViewCCAdminWindowDocManagerWindCollection
            Dim zQry As New ViewCCAdminWindowDocManagerWindQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetNHDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerNHCollection, ViewCCAdminWindowDocManagerNH)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerNHCollection, ViewCCAdminWindowDocManagerNH)()
            Dim zColl As New ViewCCAdminWindowDocManagerNHCollection
            Dim zQry As New ViewCCAdminWindowDocManagerNHQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetDivServDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerDiversifiedCollection, ViewCCAdminWindowDocManagerDiversified)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerDiversifiedCollection, ViewCCAdminWindowDocManagerDiversified)()
            Dim zColl As New ViewCCAdminWindowDocManagerDiversifiedCollection
            Dim zQry As New ViewCCAdminWindowDocManagerDiversifiedQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .ReportArchiveID = 0
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .ReportArchiveID = 0
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetPSDocInfoByGuid(pParms As String) As jsResponse(Of ViewCCAdminWindowDocManagerPSCollection, ViewCCAdminWindowDocManagerPS)
            Dim zResponse As New jsResponse(Of ViewCCAdminWindowDocManagerPSCollection, ViewCCAdminWindowDocManagerPS)()
            Dim zColl As New ViewCCAdminWindowDocManagerPSCollection
            Dim zQry As New ViewCCAdminWindowDocManagerPSQuery
            Dim zGSafeGuid As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)

            Try
                zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                    If zColl.Count < 1 Then
                        zColl.AddNew()
                        With zColl(0)
                            .FileNo = "not found"
                            .PracticeCode = 0
                            .PracticeName = ""
                            .ReportArchiveID = 0
                            .DateOfInspection = "1/1/1900"
                            .DateMailedToClient = "1/1/1900"
                            .LinkToReport = ""
                            .LinkToReport2 = ""
                            .LinkToDiagram = ""
                        End With
                    End If
                Else
                    zColl.AddNew()
                    With zColl(0)
                        .FileNo = "not found"
                        .PracticeCode = 0
                        .PracticeName = ""
                        .ReportArchiveID = 0
                        .DateOfInspection = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .LinkToReport = ""
                        .LinkToReport2 = ""
                        .LinkToDiagram = ""
                    End With
                End If

                zResponse.collection = zColl
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

#End Region

#Region "Plan Project Review"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetAllPlanReviewGrid(pParms As String) As jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)
            Dim zResponse As New jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)()
            Dim zSafeGUID As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = "%" & UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix) & ".0000%"

            Try
                Dim zColl As New ViewCCAllPlanReviewCollection
                Dim zQry As New ViewCCAllPlanReviewQuery
                zQry.SelectAll()
                zQry.Where(zQry.FileNo.Like(zFilePrefix))
                zColl.Load(zQry)
                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = "not found"
                        .Contact = ""
                        .ContactPhone = ""
                        .Subject = ""
                        .Consultant = ""
                        .Received = "1/1/1900"
                        .Mailed = "1/1/1900"
                        .ToReview = ""
                        .ProjectNo = 0
                        .Comments = ""
                    End With
                End If
                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetAllPlanReviewByID(pParms As String) As jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)
            Dim zResponse As New jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zID As String = zParms(1)

            Try
                Dim zColl As New ViewCCAllPlanReviewCollection
                Dim zQry As New ViewCCAllPlanReviewQuery
                zQry.SelectAll()
                zQry.Where(zQry.Id = zID)
                zColl.Load(zQry)
                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = "not found"
                        .Contact = ""
                        .ContactPhone = ""
                        .Subject = ""
                        .Consultant = ""
                        .Received = "1/1/1900"
                        .Mailed = "1/1/1900"
                        .ToReview = ""
                        .ProjectNo = 0
                        .Comments = ""
                    End With
                End If
                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetAllPlanReviewFileNoList(pParms As String) As jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)
            Dim zResponse As New jsResponse(Of ViewCCAllPlanReviewCollection, ViewCCAllPlanReview)()
            Dim zSafeGUID As String = pParms
            Dim zSafeID As String = UtilGSafe.GetId(zSafeGUID)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)
            Dim zUnknownLocation As String = zFilePrefix & ".0000"

            Try
                Dim zCollPlanReview As New ViewCCAllPlanReviewCollection
                Dim zObjPlanReview As New ViewCCAllPlanReview
                Dim zColl As New GSafeFileNoCollection
                Dim zQry As New GSafeFileNoQuery
                zQry.Select(zQry.FileNo)
                zQry.Where(zQry.GSafeId = zSafeID)
                zColl.Load(zQry)
                If zColl.Count > 0 Then
                    ' ADD A BLANK ITEM AT LOCAITON 0000
                    zObjPlanReview.FileNo = zUnknownLocation
                    zCollPlanReview.Add(zObjPlanReview)
                    ' ADD THE REMAINING FOUND ITEMS
                    For Each zItem As GSafeFileNo In zColl
                        zObjPlanReview = New ViewCCAllPlanReview
                        zObjPlanReview.FileNo = zItem.FileNo
                        zCollPlanReview.Add(zObjPlanReview)
                    Next
                Else
                    zObjPlanReview.FileNo = "not found"
                    zCollPlanReview.Add(zObjPlanReview)
                End If
                zResponse.collection = zCollPlanReview

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFirePlanReviewGrid(pParms As String) As jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)
            Dim zResponse As New jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)()
            Dim zSafeGUID As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New ViewCCFirePlanReviewCollection
                Dim zQry As New ViewCCFirePlanReviewQuery
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                zColl.Load(zQry)
                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = "not found"
                        .Contact = ""
                        .ContactPhone = ""
                        .Subject = ""
                        .Consultant = ""
                        .Received = "1/1/1900"
                        .Mailed = "1/1/1900"
                        .ToReview = ""
                        .ProjectNo = 0
                        .Comments = ""
                    End With
                End If
                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFirePlanReviewByID(pParms As String) As jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)
            Dim zResponse As New jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zID As String = zParms(1)

            Try
                Dim zColl As New ViewCCFirePlanReviewCollection
                Dim zQry As New ViewCCFirePlanReviewQuery
                zQry.SelectAll()
                zQry.Where(zQry.Id = zID)
                zColl.Load(zQry)
                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = "not found"
                        .Contact = ""
                        .ContactPhone = ""
                        .Subject = ""
                        .Consultant = ""
                        .Received = "1/1/1900"
                        .Mailed = "1/1/1900"
                        .ToReview = ""
                        .ProjectNo = 0
                        .Comments = ""
                    End With
                End If
                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFirePlanReviewFileNoList(pParms As String) As jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)
            Dim zResponse As New jsResponse(Of ViewCCFirePlanReviewCollection, ViewCCFirePlanReview)()
            Dim zSafeGUID As String = pParms
            Dim zSafeID As String = UtilGSafe.GetId(zSafeGUID)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)
            Dim zUnknownLocation As String = zFilePrefix & ".0000"

            Try
                Dim zCollPlanReview As New ViewCCFirePlanReviewCollection
                Dim zObjPlanReview As New ViewCCFirePlanReview
                Dim zColl As New GSafeFileNoCollection
                Dim zQry As New GSafeFileNoQuery
                zQry.Select(zQry.FileNo)
                zQry.Where(zQry.GSafeId = zSafeID)
                zColl.Load(zQry)
                If zColl.Count > 0 Then
                    ' ADD A BLANK ITEM AT LOCAITON 0000
                    zObjPlanReview.FileNo = zUnknownLocation
                    zCollPlanReview.Add(zObjPlanReview)
                    ' ADD THE REMAINING FOUND ITEMS
                    For Each zItem As GSafeFileNo In zColl
                        zObjPlanReview = New ViewCCFirePlanReview
                        zObjPlanReview.FileNo = zItem.FileNo
                        zCollPlanReview.Add(zObjPlanReview)
                    Next
                Else
                    zObjPlanReview.FileNo = "not found"
                    zCollPlanReview.Add(zObjPlanReview)
                End If
                zResponse.collection = zCollPlanReview

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMPlanReviewGrid(pParms As String) As jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)
            Dim zResponse As New jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)()
            Dim zSafeGUID As String = pParms
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New ViewCCBMPlanReviewCollection
                Dim zQry As New ViewCCBMPlanReviewQuery
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo)
                zColl.Load(zQry)
                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = "not found"
                        .Contact = ""
                        .ContactPhone = ""
                        .Subject = ""
                        .Consultant = ""
                        .Received = "1/1/1900"
                        .Mailed = "1/1/1900"
                        .ToReview = ""
                        .ProjectNo = 0
                        .Comments = ""
                    End With
                End If
                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMPlanReviewByID(pParms As String) As jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)
            Dim zResponse As New jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zID As String = zParms(1)

            Try
                Dim zColl As New ViewCCBMPlanReviewCollection
                Dim zQry As New ViewCCBMPlanReviewQuery
                zQry.SelectAll()
                zQry.Where(zQry.Id = zID)
                zColl.Load(zQry)
                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = "not found"
                        .Contact = ""
                        .ContactPhone = ""
                        .Subject = ""
                        .Consultant = ""
                        .Received = "1/1/1900"
                        .Mailed = "1/1/1900"
                        .ToReview = ""
                        .ProjectNo = 0
                        .Comments = ""
                    End With
                End If
                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMPlanReviewFileNoList(pParms As String) As jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)
            Dim zResponse As New jsResponse(Of ViewCCBMPlanReviewCollection, ViewCCBMPlanReview)()
            Dim zSafeGUID As String = pParms
            Dim zSafeID As String = UtilGSafe.GetId(zSafeGUID)
            '***GRC.Connect.Ed - class to get GSafeDetail DataName (includes Session variables) 7/31/2015
            Dim zFilePrefix As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)
            Dim zUnknownLocation As String = zFilePrefix & ".0000"

            Try
                Dim zCollPlanReview As New ViewCCBMPlanReviewCollection
                Dim zObjPlanReview As New ViewCCBMPlanReview
                Dim zColl As New GSafeFileNoCollection
                Dim zQry As New GSafeFileNoQuery
                zQry.Select(zQry.FileNo)
                zQry.Where(zQry.GSafeId = zSafeID)
                zColl.Load(zQry)
                If zColl.Count > 0 Then
                    ' ADD A BLANK ITEM AT LOCAITON 0000
                    zObjPlanReview.FileNo = zUnknownLocation
                    zCollPlanReview.Add(zObjPlanReview)
                    ' ADD THE REMAINING FOUND ITEMS
                    For Each zItem As GSafeFileNo In zColl
                        zObjPlanReview = New ViewCCBMPlanReview
                        zObjPlanReview.FileNo = zItem.FileNo
                        zCollPlanReview.Add(zObjPlanReview)
                    Next
                Else
                    zObjPlanReview.FileNo = "not found"
                    zCollPlanReview.Add(zObjPlanReview)
                End If
                zResponse.collection = zCollPlanReview

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try
            Return zResponse
        End Function

#End Region


#End Region


    End Class
End Namespace
