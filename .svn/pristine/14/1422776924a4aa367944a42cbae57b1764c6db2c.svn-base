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
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ClientsCollection_BrowseByName(pName As String) As jsResponse(Of ClientsCollection, Clients)

            Dim zResponse As New jsResponse(Of ClientsCollection, Clients)()

            Try
                Dim zColl As New ClientsCollection
                Dim zQry As New ClientsQuery()

                zQry.SelectAll()
                zQry.Where(zQry.Clientname.Like("%" & pName & "%"))
                zColl.Load(zQry)

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ClientsCollection_BrowseSummary() As jsResponse(Of ClientsCollection, Clients)

            Dim zResponse As New jsResponse(Of ClientsCollection, Clients)()

            Try
                Dim zColl As New ClientsCollection
                Dim zQry As New ClientsQuery()

                zQry.Select(zQry.Cldbname, zQry.Clientname, zQry.Features, zQry.Fileprefix, zQry.FireRatingKeyID, zQry.BMRatingKeyID, zQry.CustomAccessLabel)
                zColl.Load(zQry)

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

    End Class
End Namespace
