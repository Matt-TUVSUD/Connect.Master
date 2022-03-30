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

#Region "Fire Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FireRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            Dim zIsNatHaz As Boolean = zParms(3)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One
                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                If zIsNatHaz Then
                    zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() <> "Fire".ToLower())
                Else
                    zQry.Where(zQry.FileNo = zFileNo)  'FOR FIRE RECS WE SHOW NATHAZ ALSO, SO NO ADDITIONAL FILTER NEEDED ON HAZARD COLUMN
                End If

                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecByFileNo(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                'zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "Boiler Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function BMRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of BMRecommendationsCollection, BMRecommendations)

            Dim zResponse As New jsResponse(Of BMRecommendationsCollection, BMRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New BMRecommendationsCollection
                Dim zQry As New BMRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecCategory = ""
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecNumber = 0
                        .RecMonth = ""
                        .RecSubletter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecAction = ""
                        .ReferenceSource = ""
                        .RecKeyWords = ""
                        .ReferenceSourceDescription = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .PreviousInspectionDate = "1/1/1900"
                        .IntendedAction = ""
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As BMRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                        'Dim zDateTime As New DateTime
                        'zDateTime = zTime.ServerToUTC(zItem.MgmtRespDate)
                        'zDateTime = zDateTime.AddHours(1)
                        'zItem.MgmtRespDate = zDateTime
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMRecByFileNo(pParms As String) As jsResponse(Of BMRecommendationsCollection, BMRecommendations)

            Dim zResponse As New jsResponse(Of BMRecommendationsCollection, BMRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New BMRecommendationsCollection
                Dim zQry As New BMRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(BMRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecCategory = ""
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecNumber = 0
                        .RecMonth = ""
                        .RecSubletter = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecAction = ""
                        .ReferenceSource = ""
                        .RecKeyWords = ""
                        .ReferenceSourceDescription = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .PreviousInspectionDate = "1/1/1900"
                        .IntendedAction = ""
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As BMRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "IR Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function IRRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of FindingsCollection, Findings)

            Dim zResponse As New jsResponse(Of FindingsCollection, Findings)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New FindingsCollection
                Dim zQry As New FindingsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One
                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.OrderBy(ViewCCIRRecommendationGridMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(ViewCCIRRecommendationGridMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(ViewCCIRRecommendationGridMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                'zQry.OrderBy(ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno, esOrderByDirection.Ascending)
                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .FileNo = "Not Found"
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecYear = 0
                        .fldArc = ""
                        .Reportid = 0
                        .Findingno = 0
                        .Itemno = 0
                        .Severityrating = ""
                        .ProbableCause = ""
                        .ProbableCauseID = 0
                        .Recommendation = ""
                        .RecommendationID = 0
                        .SpecItem = ""
                        .SpecItemID = 0
                        .SpecItemDetail = ""
                        .SpecItemDetailID = 0
                        .FindEquip = ""
                        .fldLoad = ""
                        .PlantAreaAffected = ""
                        .FaultType = ""
                        .ProbableEquipmentDamageCost = 0
                        .LengthOfBusinessInterruption = ""
                        .CostOfBusinessInterruption = 0
                        .DetectedWith = ""
                        .Impact = ""
                        .Comments2 = ""
                        .MaxTemp = 0
                        .RefTemp = 0
                        .RiseTemp = 0
                        .PreventativeMaintenance = False
                        .Engineering = False
                        .Construction = False
                        .Age = False
                        .PoorCondition = False
                        .NoTimeForMaintenance = False
                        .PoorMaintenance = False
                        .Heat = False
                        .Water = False
                        .Vibration = False
                        .Contamination = False
                        .NoRiskIQ = False
                        .LastUpdated = "1/1/1900"
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .ResponseFrom = ""
                        .ResponseDate = "1/1/1900"
                        .ResponseComment = ""
                        .ResponseStatus = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .RedundancySpare = ""
                        .RecPrimary = ""
                        .RecSecondary = ""
                        .IntendedAction = ""
                        .PlantComment = ""
                        .DateOfOrigination = "1/1/1900"
                        .DateOfOriginalImport = "1/1/1900"
                        .DateOfLastImport = "1/1/1900"
                        .Id = 0
                        .fldObject = ""
                        .History = ""
                        .Comments = ""
                        .ExpectedCompletionDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As Findings In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
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
                    If Not zItem.DateOfLastImport Is Nothing Then
                        zItem.DateOfLastImport = zTime.ServerToUTC(zItem.DateOfLastImport, zHemisphere)
                    End If
                    If Not zItem.DateOfOriginalImport Is Nothing Then
                        zItem.DateOfOriginalImport = zTime.ServerToUTC(zItem.DateOfOriginalImport, zHemisphere)
                    End If
                    If Not zItem.DateOfOrigination Is Nothing Then
                        zItem.DateOfOrigination = zTime.ServerToUTC(zItem.DateOfOrigination, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFindingByFileNo(pParms As String) As jsResponse(Of FindingsCollection, Findings)

            Dim zResponse As New jsResponse(Of FindingsCollection, Findings)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New FindingsCollection
                Dim zQry As New FindingsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One
                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.OrderBy(FindingsMetadata.ColumnNames.Findingno, esOrderByDirection.Ascending)
                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .FileNo = "Not Found"
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecYear = 0
                        .fldArc = ""
                        .Reportid = 0
                        .Findingno = 0
                        .Itemno = 0
                        .Severityrating = ""
                        .ProbableCause = ""
                        .ProbableCauseID = 0
                        .Recommendation = ""
                        .RecommendationID = 0
                        .SpecItem = ""
                        .SpecItemID = 0
                        .SpecItemDetail = ""
                        .SpecItemDetailID = 0
                        .FindEquip = ""
                        .fldLoad = ""
                        .PlantAreaAffected = ""
                        .FaultType = ""
                        .ProbableEquipmentDamageCost = 0
                        .LengthOfBusinessInterruption = ""
                        .CostOfBusinessInterruption = 0
                        .DetectedWith = ""
                        .Impact = ""
                        .Comments2 = ""
                        .MaxTemp = 0
                        .RefTemp = 0
                        .RiseTemp = 0
                        .PreventativeMaintenance = False
                        .Engineering = False
                        .Construction = False
                        .Age = False
                        .PoorCondition = False
                        .NoTimeForMaintenance = False
                        .PoorMaintenance = False
                        .Heat = False
                        .Water = False
                        .Vibration = False
                        .Contamination = False
                        .NoRiskIQ = False
                        .LastUpdated = "1/1/1900"
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .ResponseFrom = ""
                        .ResponseDate = "1/1/1900"
                        .ResponseComment = ""
                        .ResponseStatus = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .RedundancySpare = ""
                        .RecPrimary = ""
                        .RecSecondary = ""
                        .IntendedAction = ""
                        .PlantComment = ""
                        .DateOfOrigination = "1/1/1900"
                        .DateOfOriginalImport = "1/1/1900"
                        .DateOfLastImport = "1/1/1900"
                        .Id = 0
                        .fldObject = ""
                        .History = ""
                        .Comments = ""
                        .ExpectedCompletionDate = "1/1/1900"
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As Findings In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
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
                    If Not zItem.DateOfLastImport Is Nothing Then
                        zItem.DateOfLastImport = zTime.ServerToUTC(zItem.DateOfLastImport, zHemisphere)
                    End If
                    If Not zItem.DateOfOriginalImport Is Nothing Then
                        zItem.DateOfOriginalImport = zTime.ServerToUTC(zItem.DateOfOriginalImport, zHemisphere)
                    End If
                    If Not zItem.DateOfOrigination Is Nothing Then
                        zItem.DateOfOrigination = zTime.ServerToUTC(zItem.DateOfOrigination, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "Seismic Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function SeismicRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() = "Seismic".ToLower())
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetSeismicRecByFileNo(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() = "Seismic".ToLower())
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "Flood Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function FloodRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() = "Flood".ToLower())
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFloodRecByFileNo(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() = "Flood".ToLower())
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "Wind Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function WindRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() = "Wind".ToLower())
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetWindRecByFileNo(pParms As String) As jsResponse(Of FireRecommendationsCollection, FireRecommendations)

            Dim zResponse As New jsResponse(Of FireRecommendationsCollection, FireRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New FireRecommendationsCollection
                Dim zQry As New FireRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() = "Wind".ToLower())
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        .BenchmarkID = 0
                        .Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        .Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As FireRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "Process Safety Recommendation Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function PSRecommendationCollection_BrowseByLocation(pParms As String) As jsResponse(Of PSRecommendationsCollection, PSRecommendations)

            Dim zResponse As New jsResponse(Of PSRecommendationsCollection, PSRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            'Dim zIsNatHaz As Boolean = zParms(3)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New PSRecommendationsCollection
                Dim zQry As New PSRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One
                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                'If zIsNatHaz Then
                '    zQry.Where(zQry.FileNo = zFileNo, zQry.Hazard.ToLower() <> "Fire".ToLower())
                'Else
                zQry.Where(zQry.FileNo = zFileNo)  'FOR PS RECS WE SHOW NATHAZ ALSO, SO NO ADDITIONAL FILTER NEEDED ON HAZARD COLUMN
                'End If

                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        '.ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        '.BenchmarkID = 0
                        '.Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        '.Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As PSRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetPSRecByFileNo(pParms As String) As jsResponse(Of PSRecommendationsCollection, PSRecommendations)

            Dim zResponse As New jsResponse(Of PSRecommendationsCollection, PSRecommendations)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New PSRecommendationsCollection
                Dim zQry As New PSRecommendationsQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                'zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(PSRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        '.ItemNo = 0
                        .FileNo = "Not Found"
                        .RecPrefix = ""
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecConfirmedDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .ReferenceSourceDescription = ""
                        .RecKeyWords = ""
                        .BreifExplanationOfRec = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .PlantFeedback = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .PreviousInspectionDate = "1/1/1900"
                        '.BenchmarkID = 0
                        '.Link = ""
                        .FollowupDate = "1/1/1900"
                        .FollowupNumber = 0
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .AdminMemo = ""
                        '.Hazard = ""
                        .OriginationDate = "1/1/1900"
                        .Importdate = "1/1/1900"
                        .Importorigdate = "1/1/1900"
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As PSRecommendations In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.FollowupDate Is Nothing Then
                        zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.OriginationDate Is Nothing Then
                        zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    End If
                    If Not zItem.PreviousInspectionDate Is Nothing Then
                        zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    End If
                    If Not zItem.RecConfirmedDate Is Nothing Then
                        zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "Recommendation Response Log (RRLog) Collection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecordByGuid(pParms As String) As jsResponse(Of RRLogCollection, RRLog)
            Dim zResponse As New jsResponse(Of RRLogCollection, RRLog)()
            Dim zCollRRLog As New RRLogCollection
            Dim zQryRRLog As New RRLogQuery
            Dim zRRLogGuid As String = pParms

            Try
                zQryRRLog.SelectAll()
                zQryRRLog.Where(zQryRRLog.RRLogGuid = zRRLogGuid)
                If zCollRRLog.Load(zQryRRLog) Then
                    zResponse.collection = zCollRRLog
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
