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
    Partial Public Class DataServer

#Region "GSafeHeader Members"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeHeader_LoadByGUID(ByVal pGSafeGUID As String) As jsResponse(Of GSafeHeaderCollection, GSafeHeader)

            Dim response As New jsResponse(Of GSafeHeaderCollection, GSafeHeader)()

            Try
                Dim entity As New GSafeHeader()
                Dim query As New GSafeHeaderQuery("t1")

                query.SelectAll()
                query.Where(query.GSafeGUID = pGSafeGUID)

                If entity.Load(query) Then
                    response.entity = entity
                End If

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function
#End Region

#Region "GSafeDetail Members"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_LoadByID(ByVal pGSafeId As Integer) As jsResponse(Of GSafeDetailCollection, GSafeDetail)

            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim coll As New GSafeDetailCollection
                response.collection = UtilGSafe.LoadDetail_BySafeId(pGSafeId)

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_LoadByGUID(ByVal pGSafeGUID As String) As jsResponse(Of GSafeDetailCollection, GSafeDetail)

            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim coll As New GSafeDetailCollection
                response.collection = UtilGSafe.LoadDetail_BySafeGUID(pGSafeGUID)

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_loadPageIdTabId(ByVal pGSafeGUID As String) As jsResponse(Of GSafeDetailCollection, GSafeDetail)

            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim coll As New GSafeDetailCollection
                response.collection = UtilGSafe.loadPageIdTab_BySafeGUID(pGSafeGUID)

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_savePageIdTabId(ByVal parms As String) As Boolean
            Dim response As Boolean
            Try
                response = UtilGSafe.savePageIdTabId_BySafeGUID(parms)
            Catch ex As Exception
                Return False
            End Try
            Return True

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_saveUserPrefs(ByVal parms As String) As Boolean
            Dim response As Boolean
            Try
                response = UtilGSafe.saveUserPrefs_BySafeGUID(parms)
            Catch ex As Exception
                Return False
            End Try
            Return True

        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_saveValueByKeyName(ByVal parms As String) As Boolean
            Try
                Dim zParmsArray = Split(parms, "|")
                Dim zGSafeGUID As String = zParmsArray(0)
                Dim zName As String = zParmsArray(1)
                Dim zValue As String = zParmsArray(2)
                Dim zGroup As String = zParmsArray(3)
                UtilGSafe.SetValue(zGSafeGUID, zName, zValue, zGroup)

            Catch ex As Exception
                Return False
            End Try
            Return True

        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_GetValueFromClient(ByVal pParms As Array) As jsResponse(Of GSafeDetailCollection, GSafeDetail)

            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim coll As New GSafeDetailCollection
                response.collection = UtilGSafe.GetValueFromClient(pParms)

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_GetDataGroupFromClient(ByVal pParms As Array) As jsResponse(Of GSafeDetailCollection, GSafeDetail)

            Dim response As New jsResponse(Of GSafeDetailCollection, GSafeDetail)()

            Try
                Dim coll As New GSafeDetailCollection
                response.collection = UtilGSafe.GetDataGroupFromClient(pParms)

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GSafeDetail_SaveFindLocations(ByVal parms As String) As Boolean
            Dim response As Boolean
            Try
                response = UtilGSafe.SaveFindLocations(parms)
            Catch ex As Exception
                Return False
            End Try
            Return True

        End Function


#End Region

    End Class
End Namespace