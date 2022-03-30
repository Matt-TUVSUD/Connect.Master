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

#Region "Translation"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetTranslationByPage(pParms As String) As jsResponse(Of ViewCCTranslationCollection, ViewCCTranslation)
            Dim zResponse As New jsResponse(Of ViewCCTranslationCollection, ViewCCTranslation)()
            Dim zColl As New ViewCCTranslationCollection
            Dim zQry As New ViewCCTranslationQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zPageId As Integer = Val(zParms(0) & "")
            Dim zLanguage As String = zParms(1).ToLower()

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.LabelName(), zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.LabelName(), zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.LabelName(), zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.LabelName(), zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.LabelName(), zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.LabelName(), zQry.EnglishTranslation)
                End Select

                zQry.Where(zQry.PageId = zPageId Or zQry.PageId = 0)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetImpactTranslationByLanguage(pParms As String) As jsResponse(Of ViewCCTranslationImpactCollection, ViewCCTranslationImpact)
            Dim zResponse As New jsResponse(Of ViewCCTranslationImpactCollection, ViewCCTranslationImpact)()
            Dim zColl As New ViewCCTranslationImpactCollection
            Dim zQry As New ViewCCTranslationImpactQuery
            Dim zLanguage As String = pParms

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.EnglishTranslation)
                End Select

                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetIntendedActionTranslationByLanguage(pParms As String) As jsResponse(Of ViewCCTranslationIntendedActionCollection, ViewCCTranslationIntendedAction)
            Dim zResponse As New jsResponse(Of ViewCCTranslationIntendedActionCollection, ViewCCTranslationIntendedAction)()
            Dim zColl As New ViewCCTranslationIntendedActionCollection
            Dim zQry As New ViewCCTranslationIntendedActionQuery
            Dim zLanguage As String = pParms

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.EnglishTranslation)
                End Select

                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetIntendedActionMgmtTranslationByLanguageFilePrefix(pParms As String) As jsResponse(Of ViewCCTranslationMgmtIntendedActionCollection, ViewCCTranslationMgmtIntendedAction)
            Dim zResponse As New jsResponse(Of ViewCCTranslationMgmtIntendedActionCollection, ViewCCTranslationMgmtIntendedAction)()
            Dim zColl As New ViewCCTranslationMgmtIntendedActionCollection
            Dim zQry As New ViewCCTranslationMgmtIntendedActionQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zLanguage As String = zParms(0).ToLower()
            Dim zFilePrefix As String = Math.Floor(Double.Parse(zParms(1)))

            Try
                ' FIND IF FILE PREFIX EXISTS
                Dim zTempColl As New ViewCCTranslationMgmtIntendedActionCollection
                Dim zTempQry As New ViewCCTranslationMgmtIntendedActionQuery
                zTempQry.Select()
                zTempQry.Where(zTempQry.FilePrefix = zFilePrefix)
                If zTempColl.Load(zTempQry) Then
                    If zTempColl.Count < 1 Then
                        zFilePrefix = "0"
                    End If
                Else
                    zFilePrefix = "0"
                End If

                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.EnglishTranslation)
                End Select

                zQry.Where(zQry.Id = 0 Or zQry.FilePrefix = zFilePrefix) 'ID=0 SHOULD BE A BLANK SPACE FOR THE DROPDOWN FROM THE VIEW
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetMgmtIntendedActionByFilePrefix(pParms As String) As jsResponse(Of ViewCCTranslationMgmtIntendedActionCollection, ViewCCTranslationMgmtIntendedAction)
            Dim response As New jsResponse(Of ViewCCTranslationMgmtIntendedActionCollection, ViewCCTranslationMgmtIntendedAction)()
            Dim zGSafeGuid As String = pParms
            Dim zFilePrefix As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FilePreFix)

            Try
                ' FIND IF FILE PREFIX EXISTS
                Dim zTempColl As New ViewCCTranslationMgmtIntendedActionCollection
                Dim zTempQry As New ViewCCTranslationMgmtIntendedActionQuery
                zTempQry.Select()
                zTempQry.Where(zTempQry.FilePrefix = zFilePrefix)
                If zTempColl.Load(zTempQry) Then
                    If zTempColl.Count < 1 Then
                        zFilePrefix = "0"
                    End If
                Else
                    zFilePrefix = "0"
                End If

                Dim collection As New ViewCCTranslationMgmtIntendedActionCollection
                Dim query As New ViewCCTranslationMgmtIntendedActionQuery

                query.SelectAll()
                query.Where(query.Id = 0 Or query.FilePrefix = zFilePrefix) 'ID=0 SHOULD BE A BLANK SPACE FOR THE DROPDOWN FROM THE VIEW

                collection.Load(query)
                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecStatusTranslationByLanguage(pParms As String) As jsResponse(Of ViewCCTranslationRecStatusCollection, ViewCCTranslationRecStatus)
            Dim zResponse As New jsResponse(Of ViewCCTranslationRecStatusCollection, ViewCCTranslationRecStatus)()
            Dim zColl As New ViewCCTranslationRecStatusCollection
            Dim zQry As New ViewCCTranslationRecStatusQuery
            Dim zLanguage As String = pParms

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.EnglishTranslation)
                End Select

                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetPrimaryRecTranslationByLanguage(pParms As String) As jsResponse(Of ViewCCTranslationPrimaryRecCollection, ViewCCTranslationPrimaryRec)
            Dim zResponse As New jsResponse(Of ViewCCTranslationPrimaryRecCollection, ViewCCTranslationPrimaryRec)()
            Dim zColl As New ViewCCTranslationPrimaryRecCollection
            Dim zQry As New ViewCCTranslationPrimaryRecQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zLanguage As String = zParms(0).ToLower()
            Dim zHazard As String = zParms(1).ToLower()

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation)
                End Select

                zQry.Where(zQry.Hazard.ToLower() = zHazard)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetSecondaryRecTranslationByLanguage(pParms As String) As jsResponse(Of ViewCCTranslationSecondaryRecCollection, ViewCCTranslationSecondaryRec)
            Dim zResponse As New jsResponse(Of ViewCCTranslationSecondaryRecCollection, ViewCCTranslationSecondaryRec)()
            Dim zColl As New ViewCCTranslationSecondaryRecCollection
            Dim zQry As New ViewCCTranslationSecondaryRecQuery
            Dim zParms() As String = Split(pParms, "|")
            Dim zLanguage As String = zParms(0).ToLower()
            Dim zHazard As String = zParms(1).ToLower()

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.Hazard, zQry.EnglishTranslation)
                End Select

                zQry.Where(zQry.Hazard.ToLower() = zHazard)
                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetHazardTranslationByLanguage(pParms As String) As jsResponse(Of ViewCCTranslationHazardCollection, ViewCCTranslationHazard)
            Dim zResponse As New jsResponse(Of ViewCCTranslationHazardCollection, ViewCCTranslationHazard)()
            Dim zColl As New ViewCCTranslationHazardCollection
            Dim zQry As New ViewCCTranslationHazardQuery
            Dim zLanguage As String = pParms

            Try
                Select Case zLanguage
                    Case "spanish"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.SpanishTranslation)
                    Case "german"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.GermanTranslation)
                    Case "french"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.FrenchTranslation)
                    Case "portuguese"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.PortugueseTranslation)
                    Case "italian"
                        zQry.Select(zQry.Id, zQry.EnglishTranslation, zQry.ItalianTranslation)
                    Case Else
                        zQry.Select(zQry.Id, zQry.EnglishTranslation)
                End Select

                If zColl.Load(zQry) Then
                    zResponse.collection = zColl
                End If
                Return zResponse

            Catch ex As Exception
                zResponse.exception = ex.Message
                Return zResponse

            End Try
        End Function


#End Region


    End Class
End Namespace
