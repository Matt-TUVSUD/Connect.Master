Imports System
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery
Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Web
Imports System.Web.Script.Services
Imports EntitySpaces.Core

Namespace Service
    Partial Public Class DataServer


#Region "Plan Project Review"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFirePlanReviewGrid(pParms As String) As jsResponse(Of FirePlanReviewCollection, FirePlanReview)
            Dim zResponse As New jsResponse(Of FirePlanReviewCollection, FirePlanReview)()
            Dim zSafeGUID As String = pParms
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New FirePlanReviewCollection
                Dim zQry As New FirePlanReviewQuery
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
        Public Function GetFirePlanReviewByID(pParms As String) As jsResponse(Of FirePlanReviewCollection, FirePlanReview)
            Dim zResponse As New jsResponse(Of FirePlanReviewCollection, FirePlanReview)()
            Dim zID As String = pParms

            Try
                Dim zColl As New FirePlanReviewCollection
                Dim zQry As New FirePlanReviewQuery
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
        Public Function GetBMPlanReviewGrid(pParms As String) As jsResponse(Of BMPlanReviewCollection, BMPlanReview)
            Dim zResponse As New jsResponse(Of BMPlanReviewCollection, BMPlanReview)()
            Dim zSafeGUID As String = pParms
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New BMPlanReviewCollection
                Dim zQry As New BMPlanReviewQuery
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
        Public Function GetBMPlanReviewByID(pParms As String) As jsResponse(Of BMPlanReviewCollection, BMPlanReview)
            Dim zResponse As New jsResponse(Of BMPlanReviewCollection, BMPlanReview)()
            Dim zID As String = pParms

            Try
                Dim zColl As New BMPlanReviewCollection
                Dim zQry As New BMPlanReviewQuery
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

#End Region

    End Class
End Namespace
