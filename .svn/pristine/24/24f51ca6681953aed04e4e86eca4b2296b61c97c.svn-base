Imports System
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery
Imports GRC.Connect.Libraries
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Web
Imports System.Web.Script.Services
Imports EntitySpaces.Core

Namespace Service

    Partial Class ViewServer

#Region "IViewCCLocationFireCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationFireCollections(pParms As String) As jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)
            Dim zLimit As String = "One"

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                'DETERMINE IF WE ARE COMING FROM A CHART TO LOAD THE LOCATION OR DETAILS PAGE
                Dim zIsFromChart As Boolean = CBool(zParms(3))
                Dim zKeyName As String = UtilGSafe.KeyName.FileNo
                If zIsFromChart Then zKeyName = UtilGSafe.KeyName.FileNoFromChart

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 And Not zIsFromChart Then NavigateFileNoFire(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFileNoFire(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, zKeyName)

                Dim zFireLocationListingQry As New ViewCCLocationListingFireQuery
                Dim zFireLocationListingCollection As New ViewCCLocationListingFireCollection

                zFireLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo = zFileNo)
                End If

                zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = zSafeGUID)

                SetFilterCriteriaFire(zSafeGUID, zFireLocationListingQry)

                zFireLocationListingCollection.Load(zFireLocationListingQry)

                If zFireLocationListingCollection.Count = 0 Then
                    zFireLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zFireLocationListingCollection(0)
                        .Client = ""
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .FileNo = "Not Found"
                        .Report2 = ""
                        .Rpt2Revwr = "1/1/1900"
                        .Rpt2Client = "1/1/1900"
                        .Region = ""
                        .ServicedBy = ""
                        .LocalTIV = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.FldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.FireFreq = ""
                        '.Fire2000 = 0
                        '.Fire2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        .FireLastInspectionReport = ""
                        .FireLastInspectionDate = "1/1/1900"
                        ' .FireScheduledDate = "1/1/1900"
                        .FireActualDate = "1/1/1900"
                        .ToFireReport = ""
                        .ToFireReport2 = ""
                        .ToFireDiagram = ""
                        '.ToBPVReport = ""
                        .FireEmailedDate = "1/1/1900"
                        ' .FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = ""
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        '.BMLastInspectionReport = ""
                        '.BMLastInspectionDate = "1/1/1900"
                        '.ToBMDiagram = ""
                        '.BMScheduledDate = "1/1/1900"
                        '.BMActualDate = "1/1/1900"
                        '.BMEmailedDate = "1/1/1900"
                        '.ToBMReport = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.FldAPLPD = 0
                        '.FldAPLBI = 0
                        '.FldAPLTotal = 0
                        '.FldPMLPD = 0
                        '.FldPMLBI = 0
                        '.FldPMLTotal = 0
                        '.FldMFLPD = 0
                        '.FldMFLBI = 0
                        '.FldMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .Address2 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        '   .BusinessContinuationPlan = False
                        .DateCompleted = "1/1/1900"
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .Engineer = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .NextInspYr = 0
                        .TotalUSTIV = ""
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        ._100PercentUSTot = 0
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zFireLocationListingCollection(0).RecCount = zRecCount
                zFireLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zFireLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetFireLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingFireCollection, ViewCCLocationListingFire)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFire(zRecCount, zRecPosition, zFileNo)

                Dim zFireLocationListingQry As New ViewCCLocationListingFireQuery
                Dim zFireLocationListingCollection As New ViewCCLocationListingFireCollection
                zFireLocationListingQry.SelectAll()
                zFireLocationListingQry.Where(zFireLocationListingQry.FileNo = zFileNo)
                zFireLocationListingCollection.Load(zFireLocationListingQry)

                If zFireLocationListingCollection.Count = 0 Then
                    zFireLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zFireLocationListingCollection(0)
                        .Client = ""
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .FileNo = "Not Found"
                        .Report2 = ""
                        .Rpt2Revwr = "1/1/1900"
                        .Rpt2Client = "1/1/1900"
                        .Region = ""
                        .ServicedBy = ""
                        .LocalTIV = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.FldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.FireFreq = ""
                        '.Fire2000 = 0
                        '.Fire2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        .FireLastInspectionReport = ""
                        .FireLastInspectionDate = "1/1/1900"
                        ' .FireScheduledDate = "1/1/1900"
                        .FireActualDate = "1/1/1900"
                        .ToFireReport = ""
                        .ToFireReport2 = ""
                        .ToFireDiagram = ""
                        '.ToBPVReport = ""
                        .FireEmailedDate = "1/1/1900"
                        '.FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = ""
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        '.BMLastInspectionReport = ""
                        '.BMLastInspectionDate = "1/1/1900"
                        '.ToBMDiagram = ""
                        '.BMScheduledDate = "1/1/1900"
                        '.BMActualDate = "1/1/1900"
                        '.BMEmailedDate = "1/1/1900"
                        '.ToBMReport = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.FldAPLPD = 0
                        '.FldAPLBI = 0
                        '.FldAPLTotal = 0
                        '.FldPMLPD = 0
                        '.FldPMLBI = 0
                        '.FldPMLTotal = 0
                        '.FldMFLPD = 0
                        '.FldMFLBI = 0
                        '.FldMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .Address2 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        ' .BusinessContinuationPlan = False
                        .DateCompleted = "1/1/1900"
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .Engineer = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .NextInspYr = 0
                        .TotalUSTIV = ""
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        ._100PercentUSTot = 0
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zFireLocationListingCollection(0).RecCount = zRecCount
                zFireLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zFireLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecResponseFireLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponseFireCollection, ViewCCLocationListingRecResponseFire)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponseFireCollection, ViewCCLocationListingRecResponseFire)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecResponseCountPositionFire(zRecCount, zRecPosition, zFileNo)

                Dim zFireLocationListingQry As New ViewCCLocationListingRecResponseFireQuery
                Dim zFireLocationListingCollection As New ViewCCLocationListingRecResponseFireCollection
                zFireLocationListingQry.SelectAll()
                zFireLocationListingQry.Where(zFireLocationListingQry.FileNo = zFileNo)
                zFireLocationListingCollection.Load(zFireLocationListingQry)

                If zFireLocationListingCollection.Count = 0 Then
                    zFireLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zFireLocationListingCollection(0)
                        .Client = ""
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .FileNo = "Not Found"
                        .Report2 = ""
                        .Rpt2Revwr = "1/1/1900"
                        .Rpt2Client = "1/1/1900"
                        .Region = ""
                        .ServicedBy = ""
                        .LocalTIV = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .FireLastInspectionReport = ""
                        .FireLastInspectionDate = "1/1/1900"
                        .FireActualDate = "1/1/1900"
                        .ToFireReport = ""
                        .ToFireReport2 = ""
                        .ToFireDiagram = ""
                        .FireEmailedDate = "1/1/1900"
                        .Frequency = ""
                        .Address1 = ""
                        .Address2 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        .DateCompleted = "1/1/1900"
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .Engineer = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .NextInspYr = 0
                        .TotalUSTIV = ""
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        ._100PercentUSTot = 0
                        .SchedulingComment = ""
                        .CustomAccess = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCLocationListingRecResponseFire In zFireLocationListingCollection
                    If Not zItem.DateCompleted Is Nothing Then
                        zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
                    End If
                    If Not zItem.FireActualDate Is Nothing Then
                        zItem.FireActualDate = zTime.ServerToUTC(zItem.FireActualDate, zHemisphere)
                    End If
                    If Not zItem.FireEmailedDate Is Nothing Then
                        zItem.FireEmailedDate = zTime.ServerToUTC(zItem.FireEmailedDate, zHemisphere)
                    End If
                    If Not zItem.FireLastInspectionDate Is Nothing Then
                        zItem.FireLastInspectionDate = zTime.ServerToUTC(zItem.FireLastInspectionDate, zHemisphere)
                    End If
                Next

                zFireLocationListingCollection(0).RecCount = zRecCount
                zFireLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zFireLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        Private Sub SetFilterCriteriaFire(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingFireQuery)
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

        Private Function SPercentFire(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoFire(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zFireLocationListingQry As New ViewCCLocationListingFireQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireCollection

            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = pSafeGUID)
            zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaFire(pSafeGUID, zFireLocationListingQry)

            zFireLocationListingCollection.Load(zFireLocationListingQry)
            pRecCount = zFireLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingFire In zFireLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionFire(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zFireLocationListingQry As New ViewCCLocationListingFireQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireCollection

            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zFireLocationListingCollection.Load(zFireLocationListingQry)
            pRecCount = zFireLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingFire In zFireLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecResponseCountPositionFire(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zFireLocationListingQry As New ViewCCLocationListingRecResponseFireQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingRecResponseFireCollection

            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zFireLocationListingCollection.Load(zFireLocationListingQry)
            pRecCount = zFireLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingRecResponseFire In zFireLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNoFire(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zFireLocationListingQry As New ViewCCLocationListingFireQuery
            Dim zFireLocationListingCollection As New ViewCCLocationListingFireCollection

            zFireLocationListingQry.Select(zFireLocationListingQry.FileNo)
            zFireLocationListingQry.Where(zFireLocationListingQry.GSafeGUID = pSafeGUID)
            zFireLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo > zFileNo)
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zFireLocationListingQry.Where(zFireLocationListingQry.FileNo < zFileNo)
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zFireLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaFire(pSafeGUID, zFireLocationListingQry)

            zFireLocationListingCollection.Load(zFireLocationListingQry)

            Dim zNewFileNo As String = ""

            If zFireLocationListingCollection.Count > 0 Then
                zNewFileNo = zFireLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)

        End Sub

#End Region

#Region "IViewCCLocationDiversifiedCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationDiversifiedCollections(pParms As String) As jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)
            Dim zLimit As String = "One"

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateFileNoDiversified(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFileNoDiversified(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zDiversifiedLocationListingQry As New ViewCCLocationListingDiversifiedQuery
                Dim zDiversifiedLocationListingCollection As New ViewCCLocationListingDiversifiedCollection

                zDiversifiedLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.FileNo = zFileNo)
                End If

                zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.GSafeGUID = zSafeGUID)

                SetFilterCriteriaDiversified(zSafeGUID, zDiversifiedLocationListingQry)

                zDiversifiedLocationListingCollection.Load(zDiversifiedLocationListingQry)

                If zDiversifiedLocationListingCollection.Count = 0 Then
                    zDiversifiedLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zDiversifiedLocationListingCollection(0)
                        .Client = ""
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .FileNo = "Not Found"
                        .Report2 = ""
                        .Rpt2Revwr = "1/1/1900"
                        .Rpt2Client = "1/1/1900"
                        .Region = ""
                        .ServicedBy = ""
                        .LocalTIV = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerDiversified = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.FldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.DiversifiedFreq = ""
                        '.Diversified2000 = 0
                        '.Fire2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        .DivServLastInspectionReport = ""
                        .DivServLastInspectionDate = "1/1/1900"
                        ' .FireScheduledDate = "1/1/1900"
                        .DivServActualDate = "1/1/1900"
                        .ToDivServReport = ""
                        .ToDivServReport2 = ""
                        .ToDivServDiagram = ""
                        '.ToBPVReport = ""
                        .DivServEmailedDate = "1/1/1900"
                        ' .FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = ""
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        '.BMLastInspectionReport = ""
                        '.BMLastInspectionDate = "1/1/1900"
                        '.ToBMDiagram = ""
                        '.BMScheduledDate = "1/1/1900"
                        '.BMActualDate = "1/1/1900"
                        '.BMEmailedDate = "1/1/1900"
                        '.ToBMReport = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.FldAPLPD = 0
                        '.FldAPLBI = 0
                        '.FldAPLTotal = 0
                        '.FldPMLPD = 0
                        '.FldPMLBI = 0
                        '.FldPMLTotal = 0
                        '.FldMFLPD = 0
                        '.FldMFLBI = 0
                        '.FldMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .Address2 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        '   .BusinessContinuationPlan = False
                        .DateCompleted = "1/1/1900"
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .Engineer = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .NextInspYr = 0
                        .TotalUSTIV = ""
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        ._100PercentUSTot = 0
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zDiversifiedLocationListingCollection(0).RecCount = zRecCount
                zDiversifiedLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zDiversifiedLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetDiversifiedLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingDiversifiedCollection, ViewCCLocationListingDiversified)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionDiversified(zRecCount, zRecPosition, zFileNo)

                Dim zDiversifiedLocationListingQry As New ViewCCLocationListingDiversifiedQuery
                Dim zDiversifiedLocationListingCollection As New ViewCCLocationListingDiversifiedCollection
                zDiversifiedLocationListingQry.SelectAll()
                zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.FileNo = zFileNo)
                zDiversifiedLocationListingCollection.Load(zDiversifiedLocationListingQry)

                If zDiversifiedLocationListingCollection.Count = 0 Then
                    zDiversifiedLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zDiversifiedLocationListingCollection(0)
                        .Client = ""
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .FileNo = "Not Found"
                        .Report2 = ""
                        .Rpt2Revwr = "1/1/1900"
                        .Rpt2Client = "1/1/1900"
                        .Region = ""
                        .ServicedBy = ""
                        .LocalTIV = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerDiversified = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.FldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.DiversifiedFreq = ""
                        '.Diversified2000 = 0
                        '.Diversified2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        .DivServLastInspectionReport = ""
                        .DivServLastInspectionDate = "1/1/1900"
                        ' .DiversifiedScheduledDate = "1/1/1900"
                        .DivServActualDate = "1/1/1900"
                        .ToDivServReport = ""
                        .ToDivServReport2 = ""
                        .ToDivServDiagram = ""
                        '.ToBPVReport = ""
                        .DivServEmailedDate = "1/1/1900"
                        '.FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = ""
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        '.BMLastInspectionReport = ""
                        '.BMLastInspectionDate = "1/1/1900"
                        '.ToBMDiagram = ""
                        '.BMScheduledDate = "1/1/1900"
                        '.BMActualDate = "1/1/1900"
                        '.BMEmailedDate = "1/1/1900"
                        '.ToBMReport = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.FldAPLPD = 0
                        '.FldAPLBI = 0
                        '.FldAPLTotal = 0
                        '.FldPMLPD = 0
                        '.FldPMLBI = 0
                        '.FldPMLTotal = 0
                        '.FldMFLPD = 0
                        '.FldMFLBI = 0
                        '.FldMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .Address2 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        ' .BusinessContinuationPlan = False
                        .DateCompleted = "1/1/1900"
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .Engineer = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .NextInspYr = 0
                        .TotalUSTIV = ""
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        ._100PercentUSTot = 0
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zDiversifiedLocationListingCollection(0).RecCount = zRecCount
                zDiversifiedLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zDiversifiedLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function GetRecResponseFireLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponseFireCollection, ViewCCLocationListingRecResponseFire)
        '    Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponseFireCollection, ViewCCLocationListingRecResponseFire)

        '    Try
        '        Dim zParms() As String = Split(pParms, "|")
        '        Dim zFileNo As String = zParms(0)
        '        Dim zHemisphere As String = zParms(1)
        '        Dim zRecCount As Integer = 0
        '        Dim zRecPosition As Integer = 0

        '        GetRecResponseCountPositionFire(zRecCount, zRecPosition, zFileNo)

        '        Dim zFireLocationListingQry As New ViewCCLocationListingRecResponseFireQuery
        '        Dim zFireLocationListingCollection As New ViewCCLocationListingRecResponseFireCollection
        '        zFireLocationListingQry.SelectAll()
        '        zFireLocationListingQry.Where(zFireLocationListingQry.FileNo = zFileNo)
        '        zFireLocationListingCollection.Load(zFireLocationListingQry)

        '        If zFireLocationListingCollection.Count = 0 Then
        '            zFireLocationListingCollection.AddNew() 'create a blank record when no matching records existing
        '            With zFireLocationListingCollection(0)
        '                .Client = ""
        '                .PracticeCode = 0
        '                .Facility = ""
        '                .ClientLocNo = ""
        '                .FileNo = "Not Found"
        '                .Report2 = ""
        '                .Rpt2Revwr = "1/1/1900"
        '                .Rpt2Client = "1/1/1900"
        '                .Region = ""
        '                .ServicedBy = ""
        '                .LocalTIV = ""
        '                .Division = ""
        '                .Latitude = 0
        '                .Longitude = 0
        '                .FireLastInspectionReport = ""
        '                .FireLastInspectionDate = "1/1/1900"
        '                .FireActualDate = "1/1/1900"
        '                .ToFireReport = ""
        '                .ToFireReport2 = ""
        '                .ToFireDiagram = ""
        '                .FireEmailedDate = "1/1/1900"
        '                .Frequency = ""
        '                .Address1 = ""
        '                .Address2 = ""
        '                .City = ""
        '                .StProv = ""
        '                .Zip = ""
        '                .Country = ""
        '                .Phone1 = ""
        '                .Fax = ""
        '                .InspNotes = ""
        '                .DateCompleted = "1/1/1900"
        '                .Rpt1Client = "1/1/1900"
        '                .LocationStatus = ""
        '                .InspectionStatus = ""
        '                .Engineer = ""
        '                .SchedFROM = "1/1/1900"
        '                .SchedTO = "1/1/1900"
        '                .NextInspYr = 0
        '                .TotalUSTIV = ""
        '                .TotalUSPD = ""
        '                .TotalUSBI = ""
        '                ._100PercentUSTot = 0
        '                .SchedulingComment = ""
        '                .CustomAccess = ""
        '            End With
        '        End If

        '        'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
        '        Dim zTime As New UtilTime
        '        For Each zItem As ViewCCLocationListingRecResponseFire In zFireLocationListingCollection
        '            If Not zItem.DateCompleted Is Nothing Then
        '                zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
        '            End If
        '            If Not zItem.FireActualDate Is Nothing Then
        '                zItem.FireActualDate = zTime.ServerToUTC(zItem.FireActualDate, zHemisphere)
        '            End If
        '            If Not zItem.FireEmailedDate Is Nothing Then
        '                zItem.FireEmailedDate = zTime.ServerToUTC(zItem.FireEmailedDate, zHemisphere)
        '            End If
        '            If Not zItem.FireLastInspectionDate Is Nothing Then
        '                zItem.FireLastInspectionDate = zTime.ServerToUTC(zItem.FireLastInspectionDate, zHemisphere)
        '            End If
        '        Next

        '        zFireLocationListingCollection(0).RecCount = zRecCount
        '        zFireLocationListingCollection(0).RecNum = zRecPosition

        '        zResponse.collection = zFireLocationListingCollection

        '    Catch ex As Exception
        '        zResponse.exception = ex.Message
        '    End Try

        '    Return zResponse
        'End Function

        Private Sub SetFilterCriteriaDiversified(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingDiversifiedQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentDiversified(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentDiversified(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentDiversified(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentDiversified(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentDiversified(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentDiversified(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentDiversified(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentDiversified(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentDiversified(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentDiversified(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentDiversified(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentDiversified(zFindLatitude)))

        End Sub

        Private Function SPercentDiversified(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoDiversified(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zDiversifiedLocationListingQry As New ViewCCLocationListingDiversifiedQuery
            Dim zDiversifiedLocationListingCollection As New ViewCCLocationListingDiversifiedCollection

            zDiversifiedLocationListingQry.Select(zDiversifiedLocationListingQry.FileNo)
            zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.GSafeGUID = pSafeGUID)
            zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaDiversified(pSafeGUID, zDiversifiedLocationListingQry)

            zDiversifiedLocationListingCollection.Load(zDiversifiedLocationListingQry)
            pRecCount = zDiversifiedLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingDiversified In zDiversifiedLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionDiversified(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zDiversifiedLocationListingQry As New ViewCCLocationListingDiversifiedQuery
            Dim zDiversifiedLocationListingCollection As New ViewCCLocationListingDiversifiedCollection

            zDiversifiedLocationListingQry.Select(zDiversifiedLocationListingQry.FileNo)
            zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zDiversifiedLocationListingCollection.Load(zDiversifiedLocationListingQry)
            pRecCount = zDiversifiedLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingDiversified In zDiversifiedLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        'Private Sub GetRecResponseCountPositionDiversified(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
        '    pRecCount = 0
        '    pRecPosition = 0

        '    Dim zFileNo As String = pFileNo
        '    Dim zDiversifiedLocationListingQry As New ViewCCLocationListingRecResponseDiversifiedQuery
        '    Dim zDiversifiedLocationListingCollection As New ViewCCLocationListingRecResponseDiversifiedCollection

        '    zDiversifiedLocationListingQry.Select(zDiversifiedLocationListingQry.FileNo)
        '    zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
        '    zDiversifiedLocationListingCollection.Load(zDiversifiedLocationListingQry)
        '    pRecCount = zDiversifiedLocationListingCollection.Count

        '    Dim zPosNdx As Integer = 1

        '    For Each zItem As ViewCCLocationListingRecResponseDiversified In zDiversifiedLocationListingCollection
        '        If zItem.FileNo = zFileNo Then
        '            pRecPosition = zPosNdx
        '            Exit For
        '        End If
        '        zPosNdx = zPosNdx + 1
        '    Next
        'End Sub

        Private Sub NavigateFileNoDiversified(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zDiversifiedLocationListingQry As New ViewCCLocationListingDiversifiedQuery
            Dim zDiversifiedLocationListingCollection As New ViewCCLocationListingDiversifiedCollection

            zDiversifiedLocationListingQry.Select(zDiversifiedLocationListingQry.FileNo)
            zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.GSafeGUID = pSafeGUID)
            zDiversifiedLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.FileNo > zFileNo)
                    zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zDiversifiedLocationListingQry.Where(zDiversifiedLocationListingQry.FileNo < zFileNo)
                    zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zDiversifiedLocationListingQry.OrderBy(ViewCCLocationListingDiversifiedBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaDiversified(pSafeGUID, zDiversifiedLocationListingQry)

            zDiversifiedLocationListingCollection.Load(zDiversifiedLocationListingQry)

            Dim zNewFileNo As String = ""

            If zDiversifiedLocationListingCollection.Count > 0 Then
                zNewFileNo = zDiversifiedLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)
        End Sub

#End Region


        '#Region "IViewCCLocationContactsFireCollection"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function ViewCCLocationContactsFireCollections(pSafeGuid As String) As jsResponse(Of ViewCCLocationContactsFireCollection, ViewCCLocationContactsFire)
        '            Dim zResponse As New jsResponse(Of ViewCCLocationContactsFireCollection, ViewCCLocationContactsFire)

        '            Try
        '                Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)
        '                Dim zFireLocationContactsQry As New ViewCCLocationContactsFireQuery
        '                Dim zFireLocationContactsCollection As New ViewCCLocationContactsFireCollection


        '                zFireLocationContactsQry.SelectAll()
        '                zFireLocationContactsQry.Where(zFireLocationContactsQry.FileNo = zFileNo)

        '                zFireLocationContactsCollection.Load(zFireLocationContactsQry)
        '                zResponse.collection = zFireLocationContactsCollection

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '            End Try

        '            Return zResponse
        '        End Function

        '#End Region

#Region "IViewCCLocationInspectionFireCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionFireCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)
            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zFireLocationInspectionQry As New ViewCCLocationInspectionFireQuery
                Dim zFireLocationInspectionCollection As New ViewCCLocationInspectionFireCollection

                zFireLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zFireLocationInspectionQry.es.Top = 1
                    End If
                End If

                zFireLocationInspectionQry.Where(zFireLocationInspectionQry.FileNo = zFileNo)

                zFireLocationInspectionCollection.Load(zFireLocationInspectionQry)

                If zFireLocationInspectionCollection.Count = 0 Then
                    zFireLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zFireLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .FilePrefix = ""
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                        .InspectionType = ""
                    End With
                End If

                zResponse.collection = zFireLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "IViewCCLocationInspectionDiversifiedCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionDiversifiedCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionDiversifiedCollection, ViewCCLocationInspectionDiversified)
            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionDiversifiedCollection, ViewCCLocationInspectionDiversified)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zDivServLocationInspectionQry As New ViewCCLocationInspectionDiversifiedQuery
                Dim zDivServLocationInspectionCollection As New ViewCCLocationInspectionDiversifiedCollection

                zDivServLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zDivServLocationInspectionQry.es.Top = 1
                    End If
                End If

                zDivServLocationInspectionQry.Where(zDivServLocationInspectionQry.FileNo = zFileNo)

                zDivServLocationInspectionCollection.Load(zDivServLocationInspectionQry)

                If zDivServLocationInspectionCollection.Count = 0 Then
                    zDivServLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zDivServLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .FilePrefix = ""
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                        .InspectionType = ""
                    End With
                End If

                zResponse.collection = zDivServLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

#Region "IViewCCLocationBMCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationBMCollections(pParms As String) As jsResponse(Of ViewCCLocationListingBMCollection, ViewCCLocationListingBM)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingBMCollection, ViewCCLocationListingBM)
            Dim zLimit As String = "One"

   
            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                'DETERMINE IF WE ARE COMING FROM A CHART TO LOAD THE LOCATION OR DETAILS PAGE
                Dim zIsFromChart As Boolean = CBool(zParms(3))
                Dim zKeyName As String = UtilGSafe.KeyName.FileNo
                If zIsFromChart Then zKeyName = UtilGSafe.KeyName.FileNoFromChart

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 And Not zIsFromChart Then NavigateFileNoBM(zSafeGUID, zDirection) 'WE DONT WANT TO ADJUST THE FILENO GSAFE NO IF WE CAME FORM A CHART
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionBM(zRecCount, zRecPosition, zSafeGUID)
          
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, zKeyName)

                Dim zBMLocationListingQry As New ViewCCLocationListingBMQuery
                Dim zBMLocationListingCollection As New ViewCCLocationListingBMCollection

                zBMLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zBMLocationListingQry.Where(zBMLocationListingQry.FileNo = zFileNo)
                End If

                zBMLocationListingQry.Where(zBMLocationListingQry.GSafeGUID = zSafeGUID)

                SetFilterCriteriaBM(zSafeGUID, zBMLocationListingQry)

                zBMLocationListingCollection.Load(zBMLocationListingQry)

                If zBMLocationListingCollection.Count = 0 Then
                    zBMLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zBMLocationListingCollection(0)
                        ._100PercentUSTot = 0
                        .TotalUSTIV = ""
                        .LocalTIV = ""
                        .Client = ""
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.fldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.FireFreq = ""
                        '.Fire2000 = 0
                        '.Fire2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        '.FireLastInspectionReport = ""
                        '.FireLastInspectionDate = "1/1/1900"
                        '.FireScheduledDate = "1/1/1900"
                        '.FireActualDate = "1/1/1900"
                        '.ToFireReport = ""
                        '.ToFireDiagram = ""
                        '.ToBPVReport = ""
                        '.FireEmailedDate = "1/1/1900"
                        '.FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = "1/1/1900"
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        .BMLastInspectionReport = ""
                        .BMLastInspectionDate = "1/1/1900"
                        .ToBMDiagram = ""
                        '.BMScheduledDate = "1/1/1900"
                        .BMActualDate = "1/1/1900"
                        .BMEmailedDate = "1/1/1900"
                        .ToBMReport = ""
                        .ToBMReport2 = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.BmAplPd = 0
                        '.BmAplBi = 0
                        '.BMAPLTotal = 0
                        '.BmPmlPd = 0
                        '.BmPmlBi = 0
                        '.BMPMLTotal = 0
                        '.BmMflPd = 0
                        '.BmMflBi = 0
                        '.BMMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        .NextInspYr = 0
                        .Engineer = ""
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zBMLocationListingCollection(0).RecCount = zRecCount
                zBMLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zBMLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetBMLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingBMCollection, ViewCCLocationListingBM)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingBMCollection, ViewCCLocationListingBM)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecResponseCountPositionFileNoBM(zRecCount, zRecPosition, zFileNo)

                Dim zBMLocationListingQry As New ViewCCLocationListingBMQuery
                Dim zBMLocationListingCollection As New ViewCCLocationListingBMCollection
                zBMLocationListingQry.SelectAll()
                zBMLocationListingQry.Where(zBMLocationListingQry.FileNo = zFileNo)
                zBMLocationListingCollection.Load(zBMLocationListingQry)

                If zBMLocationListingCollection.Count = 0 Then
                    zBMLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zBMLocationListingCollection(0)
                        ._100PercentUSTot = 0
                        .TotalUSTIV = ""
                        .LocalTIV = ""
                        .Client = ""
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.fldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.FireFreq = ""
                        '.Fire2000 = 0
                        '.Fire2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        '.FireLastInspectionReport = ""
                        '.FireLastInspectionDate = "1/1/1900"
                        '.FireScheduledDate = "1/1/1900"
                        '.FireActualDate = "1/1/1900"
                        '.ToFireReport = ""
                        '.ToFireDiagram = ""
                        '.ToBPVReport = ""
                        '.FireEmailedDate = "1/1/1900"
                        '.FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = "1/1/1900"
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        .BMLastInspectionReport = ""
                        .BMLastInspectionDate = "1/1/1900"
                        .ToBMDiagram = ""
                        ' .BMScheduledDate = "1/1/1900"
                        .BMActualDate = "1/1/1900"
                        .BMEmailedDate = "1/1/1900"
                        .ToBMReport = ""
                        .ToBMReport2 = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.BmAplPd = 0
                        '.BmAplBi = 0
                        '.BMAPLTotal = 0
                        '.BmPmlPd = 0
                        '.BmPmlBi = 0
                        '.BMPMLTotal = 0
                        '.BmMflPd = 0
                        '.BmMflBi = 0
                        '.BMMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        .NextInspYr = 0
                        .Engineer = ""
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zBMLocationListingCollection(0).RecCount = zRecCount
                zBMLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zBMLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecResponseBMLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponseBMCollection, ViewCCLocationListingRecResponseBM)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponseBMCollection, ViewCCLocationListingRecResponseBM)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0


                GetRecResponseCountPositionFileNoBM(zRecCount, zRecPosition, zFileNo)

                Dim zBMLocationListingQry As New ViewCCLocationListingRecResponseBMQuery
                Dim zBMLocationListingCollection As New ViewCCLocationListingRecResponseBMCollection
                zBMLocationListingQry.SelectAll()
                zBMLocationListingQry.Where(zBMLocationListingQry.FileNo = zFileNo)
                zBMLocationListingCollection.Load(zBMLocationListingQry)

                If zBMLocationListingCollection.Count = 0 Then
                    zBMLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zBMLocationListingCollection(0)
                        ._100PercentUSTot = 0
                        .TotalUSTIV = ""
                        .LocalTIV = ""
                        .Client = ""
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Facility = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.fldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.FireFreq = ""
                        '.Fire2000 = 0
                        '.Fire2001 = 0
                        '.Fire2002 = 0
                        '.Fire2003 = 0
                        '.Fire2004 = 0
                        '.Fire2005 = 0
                        '.FireTargetMonth = 0
                        '.FireLastInspectionReport = ""
                        '.FireLastInspectionDate = "1/1/1900"
                        '.FireScheduledDate = "1/1/1900"
                        '.FireActualDate = "1/1/1900"
                        '.ToFireReport = ""
                        '.ToFireDiagram = ""
                        '.ToBPVReport = ""
                        '.FireEmailedDate = "1/1/1900"
                        '.FireInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.FireRecResponseRecevied = ""
                        '.FireAQEDateRecevied = "1/1/1900"
                        '.FireAQERating = ""
                        '.BMFreq = ""
                        '.Bm2000 = 0
                        '.Bm2001 = 0
                        '.Bm2002 = 0
                        '.Bm2003 = 0
                        '.Bm2004 = 0
                        '.Bm2005 = 0
                        '.BMTarget = 0
                        '.EngineerRequired = ""
                        .BMLastInspectionReport = ""
                        .BMLastInspectionDate = "1/1/1900"
                        .ToBMDiagram = ""
                        ' .BMScheduledDate = "1/1/1900"
                        .BMActualDate = "1/1/1900"
                        .BMEmailedDate = "1/1/1900"
                        .ToBMReport = ""
                        .ToBMReport2 = ""
                        '.BMRecResponseReceived = ""
                        '.BMAQEDateRecevied = ""
                        '.BMAQERating = ""
                        '.BMInspectionCount = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.ARISELastInspection = ""
                        '.ARISEInspectionLetter = ""
                        '.ARISELocationManager = ""
                        '.FireComments = ""
                        '.BMComments = ""
                        '.BPVComments = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.BmAplPd = 0
                        '.BmAplBi = 0
                        '.BMAPLTotal = 0
                        '.BmPmlPd = 0
                        '.BmPmlBi = 0
                        '.BMPMLTotal = 0
                        '.BmMflPd = 0
                        '.BmMflBi = 0
                        '.BMMFLTotal = 0
                        '.FireUpdate = False
                        '.BMUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        .NextInspYr = 0
                        .Engineer = ""
                        .SchedulingComment = ""
                        .CustomAccess = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCLocationListingRecResponseBM In zBMLocationListingCollection
                    If Not zItem.BMEmailedDate Is Nothing Then
                        zItem.BMEmailedDate = zTime.ServerToUTC(zItem.BMEmailedDate, zHemisphere)
                    End If
                    If Not zItem.BMLastInspectionDate Is Nothing Then
                        zItem.BMLastInspectionDate = zTime.ServerToUTC(zItem.BMLastInspectionDate, zHemisphere)
                    End If
                    If Not zItem.DateCompleted Is Nothing Then
                        zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
                    End If
                Next

                zBMLocationListingCollection(0).RecCount = zRecCount
                zBMLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zBMLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        Private Sub SetFilterCriteriaBM(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingBMQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentBM(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentBM(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentBM(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentBM(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentBM(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentBM(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentBM(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentBM(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentBM(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentBM(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentBM(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentBM(zFindLatitude)))

        End Sub

        Private Function SPercentBM(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoBM(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zBMLocationListingQry As New ViewCCLocationListingBMQuery
            Dim zBMLocationListingCollection As New ViewCCLocationListingBMCollection

            zBMLocationListingQry.Select(zBMLocationListingQry.FileNo)
            zBMLocationListingQry.Where(zBMLocationListingQry.GSafeGUID = pSafeGUID)
            zBMLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaBM(pSafeGUID, zBMLocationListingQry)

            zBMLocationListingCollection.Load(zBMLocationListingQry)
            pRecCount = zBMLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingBM In zBMLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecResponseCountPositionFileNoBM(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zBMLocationListingQry As New ViewCCLocationListingBMQuery
            Dim zBMLocationListingCollection As New ViewCCLocationListingBMCollection

            zBMLocationListingQry.Select(zBMLocationListingQry.FileNo)
            zBMLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zBMLocationListingCollection.Load(zBMLocationListingQry)
            pRecCount = zBMLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingBM In zBMLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionBM(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zBMLocationListingQry As New ViewCCLocationListingBMQuery
            Dim zBMLocationListingCollection As New ViewCCLocationListingBMCollection

            zBMLocationListingQry.Select(zBMLocationListingQry.FileNo)
            zBMLocationListingQry.Where(zBMLocationListingQry.GSafeGUID = pSafeGUID)
            zBMLocationListingQry.OrderBy(ViewCCLocationListingFireBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaBM(pSafeGUID, zBMLocationListingQry)

            zBMLocationListingCollection.Load(zBMLocationListingQry)
            pRecCount = zBMLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingBM In zBMLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNoBM(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zBMLocationListingQry As New ViewCCLocationListingBMQuery
            Dim zBMLocationListingCollection As New ViewCCLocationListingBMCollection

            zBMLocationListingQry.Select(zBMLocationListingQry.FileNo)
            zBMLocationListingQry.Where(zBMLocationListingQry.GSafeGUID = pSafeGUID)
            zBMLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zBMLocationListingQry.Where(zBMLocationListingQry.FileNo > zFileNo)
                    zBMLocationListingQry.OrderBy(ViewCCLocationListingBMBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zBMLocationListingQry.Where(zBMLocationListingQry.FileNo < zFileNo)
                    zBMLocationListingQry.OrderBy(ViewCCLocationListingBMBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zBMLocationListingQry.OrderBy(ViewCCLocationListingBMBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zBMLocationListingQry.OrderBy(ViewCCLocationListingBMBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaBM(pSafeGUID, zBMLocationListingQry)

            zBMLocationListingCollection.Load(zBMLocationListingQry)

            Dim zNewFileNo As String = ""

            If zBMLocationListingCollection.Count > 0 Then
                zNewFileNo = zBMLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)
        End Sub

#End Region

        '#Region "IViewCCLocationContactsBMCollection"
        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function ViewCCLocationContactsBMCollections(pSafeGuid As String) As jsResponse(Of ViewCCLocationContactsBMCollection, ViewCCLocationContactsBM)
        '            Dim zResponse As New jsResponse(Of ViewCCLocationContactsBMCollection, ViewCCLocationContactsBM)

        '            Try

        '                Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)
        '                Dim zBMLocationContactsQry As New ViewCCLocationContactsBMQuery
        '                Dim zBMLocationContactsCollection As New ViewCCLocationContactsBMCollection

        '                zBMLocationContactsQry.SelectAll()
        '                zBMLocationContactsQry.Where(zBMLocationContactsQry.FileNo = zFileNo)
        '                zBMLocationContactsCollection.Load(zBMLocationContactsQry)

        '                zResponse.collection = zBMLocationContactsCollection

        '            Catch ex As Exception
        '                zResponse.exception = ex.ToString
        '            End Try

        '            Return zResponse

        '        End Function
        '#End Region

#Region "IViewCCLocationInspectionBMCollection"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionBMCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionBMCollection, ViewCCLocationInspectionBM)
            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionBMCollection, ViewCCLocationInspectionBM)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zBMLocationInspectionQry As New ViewCCLocationInspectionBMQuery
                Dim zBMLocationInspectionCollection As New ViewCCLocationInspectionBMCollection

                zBMLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zBMLocationInspectionQry.es.Top = 1
                    End If
                End If

                zBMLocationInspectionQry.Where(zBMLocationInspectionQry.FileNo = zFileNo)

                zBMLocationInspectionCollection.Load(zBMLocationInspectionQry)

                If zBMLocationInspectionCollection.Count = 0 Then
                    zBMLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zBMLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .NextInspYr = 0
                        .InspRemaining = 0
                        .InspectionStatus = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .ClientTargetMo = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .Engineer = ""
                        .PDBuilding = ""
                        .PDEquipment = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .EngTargetMo = "1/1/1900"
                        .InspectionType = ""
                    End With
                End If

                zResponse.collection = zBMLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function
#End Region

#Region "IViewCCLocationIRCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationIRCollections(pParms As String) As jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)
            'Dim zResponse As New jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)
            'Try
            '    Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zIRLocationListingQry As New ViewCCLocationListingIRQuery
            '    Dim zIRLocationListingCollection As New ViewCCLocationListingIRCollection
            '    zIRLocationListingQry.SelectAll()
            '    zIRLocationListingQry.Where(zIRLocationListingQry.FileNo = zFileNo)
            '    zIRLocationListingCollection.Load(zIRLocationListingQry)
            '    zResponse.collection = zIRLocationListingCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)
            Dim zLimit As String = "One"

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateFileNoIR(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0
                GetRecCountPositionFileNoIR(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zIRLocationListingQry As New ViewCCLocationListingIRQuery
                Dim zIRLocationListingCollection As New ViewCCLocationListingIRCollection
                zIRLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zIRLocationListingQry.Where(zIRLocationListingQry.FileNo = zFileNo)
                End If

                zIRLocationListingQry.Where(zIRLocationListingQry.GSafeGUID = zSafeGUID)
                SetFilterCriteriaIR(zSafeGUID, zIRLocationListingQry)
                zIRLocationListingCollection.Load(zIRLocationListingQry)

                If zIRLocationListingCollection.Count = 0 Then
                    zIRLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zIRLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        .SchedulingComment = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.fldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.EngineerRequired = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.AplPd = 0
                        '.AplBi = 0
                        '.APLTotal = 0
                        '.PmlPd = 0
                        '.PmlBi = 0
                        '.PMLTotal = 0
                        '.MflPd = 0
                        '.MflBi = 0
                        '.MFLTotal = 0
                        '.FireUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        ' .BusinessContinuationPlan = False
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        '.IRUpdate = False
                        '.IRTargetMonth = 0
                        .IRLastInspectionReport = ""
                        .IRLastInspectionDate = "1/1/1900"
                        ' .IRScheduledDate = "1/1/1900"
                        .IRActualDate = "1/1/1900"
                        .ToIRReport = ""
                        .IREmailedDate = "1/1/1900"
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zIRLocationListingCollection(0).RecCount = zRecCount
                zIRLocationListingCollection(0).RecNum = zRecPosition
                zResponse.collection = zIRLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetIRLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingIRCollection, ViewCCLocationListingIR)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionIR(zRecCount, zRecPosition, zFileNo)

                Dim zIRLocationListingQry As New ViewCCLocationListingIRQuery
                Dim zIRLocationListingCollection As New ViewCCLocationListingIRCollection
                zIRLocationListingQry.SelectAll()
                zIRLocationListingQry.Where(zIRLocationListingQry.FileNo = zFileNo)
                zIRLocationListingCollection.Load(zIRLocationListingQry)

                If zIRLocationListingCollection.Count = 0 Then
                    zIRLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zIRLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        .SchedulingComment = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.fldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.EngineerRequired = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.AplPd = 0
                        '.AplBi = 0
                        '.APLTotal = 0
                        '.PmlPd = 0
                        '.PmlBi = 0
                        '.PMLTotal = 0
                        '.MflPd = 0
                        '.MflBi = 0
                        '.MFLTotal = 0
                        '.FireUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        '.BusinessContinuationPlan = False
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        ' .IRUpdate = False
                        ' .IRTargetMonth = 0
                        .IRLastInspectionReport = ""
                        .IRLastInspectionDate = "1/1/1900"
                        '.IRScheduledDate = "1/1/1900"
                        .IRActualDate = "1/1/1900"
                        .ToIRReport = ""
                        .IREmailedDate = "1/1/1900"
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zIRLocationListingCollection(0).RecCount = zRecCount
                zIRLocationListingCollection(0).RecNum = zRecPosition
                zResponse.collection = zIRLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecResponseIRLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponseIRCollection, ViewCCLocationListingRecResponseIR)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponseIRCollection, ViewCCLocationListingRecResponseIR)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecResponseCountPositionIR(zRecCount, zRecPosition, zFileNo)

                Dim zIRLocationListingQry As New ViewCCLocationListingRecResponseIRQuery
                Dim zIRLocationListingCollection As New ViewCCLocationListingRecResponseIRCollection
                zIRLocationListingQry.SelectAll()
                zIRLocationListingQry.Where(zIRLocationListingQry.FileNo = zFileNo)
                zIRLocationListingCollection.Load(zIRLocationListingQry)

                If zIRLocationListingCollection.Count = 0 Then
                    zIRLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zIRLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        .SchedulingComment = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.fldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.EngineerRequired = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.AplPd = 0
                        '.AplBi = 0
                        '.APLTotal = 0
                        '.PmlPd = 0
                        '.PmlBi = 0
                        '.PMLTotal = 0
                        '.MflPd = 0
                        '.MflBi = 0
                        '.MFLTotal = 0
                        '.FireUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        ' .BusinessContinuationPlan = False
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        ' .IRUpdate = False
                        '.IRTargetMonth = 0
                        .IRLastInspectionReport = ""
                        .IRLastInspectionDate = "1/1/1900"
                        '.IRScheduledDate = "1/1/1900"
                        .IRActualDate = "1/1/1900"
                        .ToIRReport = ""
                        .IREmailedDate = "1/1/1900"
                        .CustomAccess = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCLocationListingRecResponseIR In zIRLocationListingCollection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.DateCompleted Is Nothing Then
                        zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
                    End If
                    If Not zItem.IRActualDate Is Nothing Then
                        zItem.IRActualDate = zTime.ServerToUTC(zItem.IRActualDate, zHemisphere)
                    End If
                    If Not zItem.IREmailedDate Is Nothing Then
                        zItem.IREmailedDate = zTime.ServerToUTC(zItem.IREmailedDate, zHemisphere)
                    End If
                    If Not zItem.IRLastInspectionDate Is Nothing Then
                        zItem.IRLastInspectionDate = zTime.ServerToUTC(zItem.IRLastInspectionDate, zHemisphere)
                    End If
                Next

                zIRLocationListingCollection(0).RecCount = zRecCount
                zIRLocationListingCollection(0).RecNum = zRecPosition
                zResponse.collection = zIRLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        Private Sub SetFilterCriteriaIR(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingIRQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentIR(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentIR(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentIR(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentIR(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentIR(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentIR(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentIR(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentIR(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentIR(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentIR(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentIR(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentIR(zFindLatitude)))

        End Sub

        Private Function SPercentIR(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoIR(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zIRLocationListingQry As New ViewCCLocationListingIRQuery
            Dim zIRLocationListingCollection As New ViewCCLocationListingIRCollection

            zIRLocationListingQry.Select(zIRLocationListingQry.FileNo)
            zIRLocationListingQry.Where(zIRLocationListingQry.GSafeGUID = pSafeGUID)
            zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaIR(pSafeGUID, zIRLocationListingQry)

            zIRLocationListingCollection.Load(zIRLocationListingQry)
            pRecCount = zIRLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingIR In zIRLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionIR(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zIRLocationListingQry As New ViewCCLocationListingIRQuery
            Dim zIRLocationListingCollection As New ViewCCLocationListingIRCollection

            zIRLocationListingQry.Select(zIRLocationListingQry.FileNo)
            zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zIRLocationListingCollection.Load(zIRLocationListingQry)
            pRecCount = zIRLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingIR In zIRLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecResponseCountPositionIR(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zIRLocationListingQry As New ViewCCLocationListingRecResponseIRQuery
            Dim zIRLocationListingCollection As New ViewCCLocationListingRecResponseIRCollection

            zIRLocationListingQry.Select(zIRLocationListingQry.FileNo)
            zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zIRLocationListingCollection.Load(zIRLocationListingQry)
            pRecCount = zIRLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingRecResponseIR In zIRLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNoIR(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zIRLocationListingQry As New ViewCCLocationListingIRQuery
            Dim zIRLocationListingCollection As New ViewCCLocationListingIRCollection

            zIRLocationListingQry.Select(zIRLocationListingQry.FileNo)
            zIRLocationListingQry.Where(zIRLocationListingQry.GSafeGUID = pSafeGUID)
            zIRLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zIRLocationListingQry.Where(zIRLocationListingQry.FileNo > zFileNo)
                    zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zIRLocationListingQry.Where(zIRLocationListingQry.FileNo < zFileNo)
                    zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zIRLocationListingQry.OrderBy(ViewCCLocationListingIRBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaIR(pSafeGUID, zIRLocationListingQry)

            zIRLocationListingCollection.Load(zIRLocationListingQry)

            Dim zNewFileNo As String = ""

            If zIRLocationListingCollection.Count > 0 Then
                zNewFileNo = zIRLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)
        End Sub

#End Region

        '#Region "IViewCCLocationContactsIRCollection"
        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function ViewCCLocationContactsIRCollections(pSafeGuid As String) As jsResponse(Of ViewCCLocationContactsIRCollection, ViewCCLocationContactsIR)
        '            Dim zResponse As New jsResponse(Of ViewCCLocationContactsIRCollection, ViewCCLocationContactsIR)

        '            Try
        '                Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)
        '                Dim zIRLocationContactsQry As New ViewCCLocationContactsIRQuery
        '                Dim zIRLocationContactsCollection As New ViewCCLocationContactsIRCollection

        '                zIRLocationContactsQry.SelectAll()
        '                zIRLocationContactsQry.Where(zIRLocationContactsQry.FileNo = zFileNo)
        '                zIRLocationContactsCollection.Load(zIRLocationContactsQry)

        '                zResponse.collection = zIRLocationContactsCollection

        '            Catch ex As Exception
        '                zResponse.exception = ex.ToString
        '            End Try

        '            Return zResponse

        '        End Function
        '#End Region

#Region "IViewCCLocationInspectionIRCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionIRCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionIRCollection, ViewCCLocationInspectionIR)
            'Dim zResponse As New jsResponse(Of ViewCCLocationInspectionIRCollection, ViewCCLocationInspectionIR)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zIRLocationInspectionQry As New ViewCCLocationInspectionIRQuery
            '    Dim zIRLocationInspectionCollection As New ViewCCLocationInspectionIRCollection
            '    zIRLocationInspectionQry.SelectAll()
            '    zIRLocationInspectionQry.Where(zIRLocationInspectionQry.FileNo = zFileNo)
            '    zIRLocationInspectionCollection.Load(zIRLocationInspectionQry)
            '    zResponse.collection = zIRLocationInspectionCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionIRCollection, ViewCCLocationInspectionIR)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zIRLocationInspectionQry As New ViewCCLocationInspectionIRQuery
                Dim zIRLocationInspectionCollection As New ViewCCLocationInspectionIRCollection
                zIRLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One
                    If zLimit.ToLower = "One".ToLower Then
                        zIRLocationInspectionQry.es.Top = 1
                    End If
                End If

                zIRLocationInspectionQry.Where(zIRLocationInspectionQry.FileNo = zFileNo)
                zIRLocationInspectionCollection.Load(zIRLocationInspectionQry)

                If zIRLocationInspectionCollection.Count = 0 Then
                    zIRLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zIRLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                        .InspectionType = ""
                    End With
                End If

                zResponse.collection = zIRLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region


        '-----------------------------------------------------------------------------------------------------------------------------------'


#Region "IViewCCLocationNatHazCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationNatHazCollections(pParms As String) As jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)
            'Dim zResponse As New jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zNatHazLocationListingQry As New ViewCCLocationListingNatHazQuery
            '    Dim zNatHazLocationListingCollection As New ViewCCLocationListingNatHazCollection
            '    zNatHazLocationListingQry.SelectAll()
            '    zNatHazLocationListingQry.Where(zNatHazLocationListingQry.FileNo = zFileNo)
            '    zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)
            '    zResponse.collection = zNatHazLocationListingCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)
            Dim zLimit As String = "One"

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateFileNoNatHaz(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFileNoNatHaz(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNatHazLocationListingQry As New ViewCCLocationListingNatHazQuery
                Dim zNatHazLocationListingCollection As New ViewCCLocationListingNatHazCollection

                zNatHazLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zNatHazLocationListingQry.Where(zNatHazLocationListingQry.FileNo = zFileNo)
                End If

                zNatHazLocationListingQry.Where(zNatHazLocationListingQry.GSafeGUID = zSafeGUID)
                SetFilterCriteriaNatHaz(zSafeGUID, zNatHazLocationListingQry)
                zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)

                If zNatHazLocationListingCollection.Count = 0 Then
                    zNatHazLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        .Report1 = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.EngineerRequired = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.AplPd = 0
                        '.AplBi = 0
                        '.APLTotal = 0
                        '.PmlPd = 0
                        '.PmlBi = 0
                        '.PMLTotal = 0
                        '.MflPd = 0
                        '.MflBi = 0
                        '.MFLTotal = 0
                        '.FireUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        '.BusinessContinuationPlan = False
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        '.IRUpdate = False
                        '.IRTargetMonth = 0
                        '.IRLastInspectionReport = ""
                        '.IRLastInspectionDate = "1/1/1900"
                        '.IRScheduledDate = "1/1/1900"
                        '.IRActualDate = "1/1/1900"
                        '.ToIRReport = ""
                        '.IREmailedDate = "1/1/1900"
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .NatHazWindLastInspectionReport = ""
                        .NatHazWindLastInspectionDate = "1/1/1900"
                        .NatHazWindActualDate = "1/1/1900"
                        .ToNatHazWindReport = ""
                        .ToNatHazWindReport2 = ""
                        .ToNatHazWindDiagram = ""
                        .NatHazWindEmailedDate = "1/1/1900"
                        .NatHazSeismicLastInspectionReport = ""
                        .NatHazSeismicLastInspectionDate = "1/1/1900"
                        .NatHazSeismicActualDate = "1/1/1900"
                        .ToNatHazSeismicReport = ""
                        .ToNatHazSeismicReport2 = ""
                        .ToNatHazSeismicDiagram = ""
                        .NatHazSeismicEmailedDate = "1/1/1900"
                        .NatHazFloodLastInspectionReport = ""
                        .NatHazFloodLastInspectionDate = "1/1/1900"
                        .NatHazFloodActualDate = "1/1/1900"
                        .ToNatHazFloodReport = ""
                        .ToNatHazFloodReport2 = ""
                        .ToNatHazFloodDiagram = ""
                        .NatHazFloodEmailedDate = "1/1/1900"
                        .GSafeGUID = ""
                    End With
                End If

                zNatHazLocationListingCollection(0).RecCount = zRecCount
                zNatHazLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zNatHazLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetNatHazLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingNatHazCollection, ViewCCLocationListingNatHaz)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionNatHaz(zRecCount, zRecPosition, zFileNo)

                Dim zNatHazLocationListingQry As New ViewCCLocationListingNatHazQuery
                Dim zNatHazLocationListingCollection As New ViewCCLocationListingNatHazCollection

                zNatHazLocationListingQry.SelectAll()
                zNatHazLocationListingQry.Where(zNatHazLocationListingQry.FileNo = zFileNo)
                zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)

                If zNatHazLocationListingCollection.Count = 0 Then
                    zNatHazLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        .Report1 = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        '.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.EngineerRequired = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.AplPd = 0
                        '.AplBi = 0
                        '.APLTotal = 0
                        '.PmlPd = 0
                        '.PmlBi = 0
                        '.PMLTotal = 0
                        '.MflPd = 0
                        '.MflBi = 0
                        '.MFLTotal = 0
                        '.FireUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        '.BusinessContinuationPlan = False
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        '.IRUpdate = False
                        '.IRTargetMonth = 0
                        '.IRLastInspectionReport = ""
                        '.IRLastInspectionDate = "1/1/1900"
                        '.IRScheduledDate = "1/1/1900"
                        '.IRActualDate = "1/1/1900"
                        '.ToIRReport = ""
                        '.IREmailedDate = "1/1/1900"
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .NatHazWindLastInspectionReport = ""
                        .NatHazWindLastInspectionDate = "1/1/1900"
                        .NatHazWindActualDate = "1/1/1900"
                        .ToNatHazWindReport = ""
                        .ToNatHazWindReport2 = ""
                        .ToNatHazWindDiagram = ""
                        .NatHazWindEmailedDate = "1/1/1900"
                        .NatHazSeismicLastInspectionReport = ""
                        .NatHazSeismicLastInspectionDate = "1/1/1900"
                        .NatHazSeismicActualDate = "1/1/1900"
                        .ToNatHazSeismicReport = ""
                        .ToNatHazSeismicReport2 = ""
                        .ToNatHazSeismicDiagram = ""
                        .NatHazSeismicEmailedDate = "1/1/1900"
                        .NatHazFloodLastInspectionReport = ""
                        .NatHazFloodLastInspectionDate = "1/1/1900"
                        .NatHazFloodActualDate = "1/1/1900"
                        .ToNatHazFloodReport = ""
                        .ToNatHazFloodReport2 = ""
                        .ToNatHazFloodDiagram = ""
                        .NatHazFloodEmailedDate = "1/1/1900"
                        .GSafeGUID = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCLocationListingNatHaz In zNatHazLocationListingCollection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.DateCompleted Is Nothing Then
                        zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
                    End If
                    If Not zItem.NatHazFloodActualDate Is Nothing Then
                        zItem.NatHazFloodActualDate = zTime.ServerToUTC(zItem.NatHazFloodActualDate, zHemisphere)
                    End If
                    If Not zItem.NatHazFloodEmailedDate Is Nothing Then
                        zItem.NatHazFloodEmailedDate = zTime.ServerToUTC(zItem.NatHazFloodEmailedDate, zHemisphere)
                    End If
                    If Not zItem.NatHazFloodLastInspectionDate Is Nothing Then
                        zItem.NatHazFloodLastInspectionDate = zTime.ServerToUTC(zItem.NatHazFloodLastInspectionDate, zHemisphere)
                    End If
                    If Not zItem.NatHazSeismicActualDate Is Nothing Then
                        zItem.NatHazSeismicActualDate = zTime.ServerToUTC(zItem.NatHazSeismicActualDate, zHemisphere)
                    End If
                    If Not zItem.NatHazSeismicEmailedDate Is Nothing Then
                        zItem.NatHazSeismicEmailedDate = zTime.ServerToUTC(zItem.NatHazSeismicEmailedDate, zHemisphere)
                    End If
                    If Not zItem.NatHazSeismicLastInspectionDate Is Nothing Then
                        zItem.NatHazSeismicLastInspectionDate = zTime.ServerToUTC(zItem.NatHazSeismicLastInspectionDate, zHemisphere)
                    End If
                    If Not zItem.NatHazWindActualDate Is Nothing Then
                        zItem.NatHazWindActualDate = zTime.ServerToUTC(zItem.NatHazWindActualDate, zHemisphere)
                    End If
                    If Not zItem.NatHazWindEmailedDate Is Nothing Then
                        zItem.NatHazWindEmailedDate = zTime.ServerToUTC(zItem.NatHazWindEmailedDate, zHemisphere)
                    End If
                    If Not zItem.NatHazWindLastInspectionDate Is Nothing Then
                        zItem.NatHazWindLastInspectionDate = zTime.ServerToUTC(zItem.NatHazWindLastInspectionDate, zHemisphere)
                    End If
                Next

                zNatHazLocationListingCollection(0).RecCount = zRecCount
                zNatHazLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zNatHazLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecResponseNatHazLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponseNatHazCollection, ViewCCLocationListingRecResponseNatHaz)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponseNatHazCollection, ViewCCLocationListingRecResponseNatHaz)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecResponseCountPositionFileNoNatHaz(zRecCount, zRecPosition, zFileNo)

                Dim zNatHazLocationListingQry As New ViewCCLocationListingRecResponseNatHazQuery
                Dim zNatHazLocationListingCollection As New ViewCCLocationListingRecResponseNatHazCollection

                zNatHazLocationListingQry.SelectAll()
                zNatHazLocationListingQry.Where(zNatHazLocationListingQry.FileNo = zFileNo)
                zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)

                If zNatHazLocationListingCollection.Count = 0 Then
                    zNatHazLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        .Report1 = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        '.Field1 = ""
                        '.Ownership = ""
                        '.IRINo = ""
                        '.AccountablePerson = ""
                        '.PlantID = ""
                        '.PlantName = ""
                        '.GRCEngineerFire = ""
                        '.GRCEngineerBM = ""
                        '.GRCTitle = ""
                        '.ClientLocation = 0
                        '.Locationname = ""
                        '.Status = ""
                        '.BusinessUnit = ""
                        '.FldEntity = ""
                        '.Occupancy = ""
                        '.Zone = 0
                        ''.fldStructure = 0
                        '.Equipment = 0
                        '.Inventory = 0
                        '.Pd = 0
                        '.Bi = 0
                        '.Tiv = 0
                        '.EngineerRequired = ""
                        '.LocationManager = ""
                        '.LocationPhone = ""
                        '.LocationFax = ""
                        '.LocationEmail = ""
                        '.Comments = ""
                        '.ResponseDate = "1/1/1900"
                        '.AplPd = 0
                        '.AplBi = 0
                        '.APLTotal = 0
                        '.PmlPd = 0
                        '.PmlBi = 0
                        '.PMLTotal = 0
                        '.MflPd = 0
                        '.MflBi = 0
                        '.MFLTotal = 0
                        '.FireUpdate = False
                        '.SquareFootage = 0
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        '.BusinessContinuationPlan = False
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        '.IRUpdate = False
                        '.IRTargetMonth = 0
                        '.IRLastInspectionReport = ""
                        '.IRLastInspectionDate = "1/1/1900"
                        '.IRScheduledDate = "1/1/1900"
                        '.IRActualDate = "1/1/1900"
                        '.ToIRReport = ""
                        '.IREmailedDate = "1/1/1900"
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        .NatHazWindLastInspectionReport = ""
                        .NatHazWindLastInspectionDate = "1/1/1900"
                        .NatHazWindActualDate = "1/1/1900"
                        .ToNatHazWindReport = ""
                        .ToNatHazWindReport2 = ""
                        .ToNatHazWindDiagram = ""
                        .NatHazWindEmailedDate = "1/1/1900"
                        .NatHazSeismicLastInspectionReport = ""
                        .NatHazSeismicLastInspectionDate = "1/1/1900"
                        .NatHazSeismicActualDate = "1/1/1900"
                        .ToNatHazSeismicReport = ""
                        .ToNatHazSeismicReport2 = ""
                        .ToNatHazSeismicDiagram = ""
                        .NatHazSeismicEmailedDate = "1/1/1900"
                        .NatHazFloodLastInspectionReport = ""
                        .NatHazFloodLastInspectionDate = "1/1/1900"
                        .NatHazFloodActualDate = "1/1/1900"
                        .ToNatHazFloodReport = ""
                        .ToNatHazFloodReport2 = ""
                        .ToNatHazFloodDiagram = ""
                        .NatHazFloodEmailedDate = "1/1/1900"
                    End With
                End If

                zNatHazLocationListingCollection(0).RecCount = zRecCount
                zNatHazLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zNatHazLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        Private Sub SetFilterCriteriaNatHaz(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingNatHazQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentNatHaz(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentNatHaz(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentNatHaz(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentNatHaz(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentNatHaz(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentNatHaz(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentNatHaz(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentNatHaz(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentNatHaz(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentNatHaz(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentNatHaz(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentNatHaz(zFindLatitude)))

        End Sub

        Private Function SPercentNatHaz(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoNatHaz(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zNatHazLocationListingQry As New ViewCCLocationListingNatHazQuery
            Dim zNatHazLocationListingCollection As New ViewCCLocationListingNatHazCollection

            zNatHazLocationListingQry.Select(zNatHazLocationListingQry.FileNo)
            zNatHazLocationListingQry.Where(zNatHazLocationListingQry.GSafeGUID = pSafeGUID)
            zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaNatHaz(pSafeGUID, zNatHazLocationListingQry)

            zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)
            pRecCount = zNatHazLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingNatHaz In zNatHazLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecResponseCountPositionFileNoNatHaz(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zNatHazLocationListingQry As New ViewCCLocationListingRecResponseNatHazQuery
            Dim zNatHazLocationListingCollection As New ViewCCLocationListingRecResponseNatHazCollection

            zNatHazLocationListingQry.Select(zNatHazLocationListingQry.FileNo)
            zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)
            pRecCount = zNatHazLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingRecResponseNatHaz In zNatHazLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionNatHaz(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zNatHazLocationListingQry As New ViewCCLocationListingNatHazQuery
            Dim zNatHazLocationListingCollection As New ViewCCLocationListingNatHazCollection

            zNatHazLocationListingQry.Select(zNatHazLocationListingQry.FileNo)
            zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)
            pRecCount = zNatHazLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingNatHaz In zNatHazLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNoNatHaz(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zNatHazLocationListingQry As New ViewCCLocationListingNatHazQuery
            Dim zNatHazLocationListingCollection As New ViewCCLocationListingNatHazCollection

            zNatHazLocationListingQry.Select(zNatHazLocationListingQry.FileNo)
            zNatHazLocationListingQry.Where(zNatHazLocationListingQry.GSafeGUID = pSafeGUID)
            zNatHazLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zNatHazLocationListingQry.Where(zNatHazLocationListingQry.FileNo > zFileNo)
                    zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zNatHazLocationListingQry.Where(zNatHazLocationListingQry.FileNo < zFileNo)
                    zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zNatHazLocationListingQry.OrderBy(ViewCCLocationListingNatHazBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaNatHaz(pSafeGUID, zNatHazLocationListingQry)

            zNatHazLocationListingCollection.Load(zNatHazLocationListingQry)

            Dim zNewFileNo As String = ""

            If zNatHazLocationListingCollection.Count > 0 Then
                zNewFileNo = zNatHazLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)
        End Sub

#End Region


#Region "IViewCCLocationNHCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationNHCollections(pParms As String) As jsResponse(Of ViewCCLocationListingNHCollection, ViewCCLocationListingNH)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingNHCollection, ViewCCLocationListingNH)
            Dim zLimit As String = "One"

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateFileNoNH(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFileNoNH(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNHLocationListingQry As New ViewCCLocationListingNHQuery
                Dim zNHLocationListingCollection As New ViewCCLocationListingNHCollection

                zNHLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zNHLocationListingQry.Where(zNHLocationListingQry.FileNo = zFileNo)
                End If

                zNHLocationListingQry.Where(zNHLocationListingQry.GSafeGUID = zSafeGUID)
                SetFilterCriteriaNH(zSafeGUID, zNHLocationListingQry)
                zNHLocationListingCollection.Load(zNHLocationListingQry)

                If zNHLocationListingCollection.Count = 0 Then
                    zNHLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zNHLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        '.Report1 = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        '.NHWindLastInspectionReport = ""
                        '.NHWindLastInspectionDate = "1/1/1900"
                        '.NHWindActualDate = "1/1/1900"
                        '.ToNHWindReport = ""
                        '.ToNHWindReport2 = ""
                        '.ToNHWindDiagram = ""
                        '.NHWindEmailedDate = "1/1/1900"
                        .NHLastInspectionReport = ""
                        .NHLastInspectionDate = "1/1/1900"
                        .NHActualDate = "1/1/1900"
                        .ToNHReport = ""
                        .ToNHReport2 = ""
                        .ToNHDiagram = ""
                        .NHEmailedDate = "1/1/1900"
                        .GSafeGUID = ""
                    End With
                End If

                zNHLocationListingCollection(0).RecCount = zRecCount
                zNHLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zNHLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetNHLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingNHCollection, ViewCCLocationListingNH)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingNHCollection, ViewCCLocationListingNH)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionNH(zRecCount, zRecPosition, zFileNo)

                Dim zNHLocationListingQry As New ViewCCLocationListingNHQuery
                Dim zNHLocationListingCollection As New ViewCCLocationListingNHCollection

                zNHLocationListingQry.SelectAll()
                zNHLocationListingQry.Where(zNHLocationListingQry.FileNo = zFileNo)
                zNHLocationListingCollection.Load(zNHLocationListingQry)

                If zNHLocationListingCollection.Count = 0 Then
                    zNHLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zNHLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .Client = ""
                        .PracticeCode = 0
                        '.Report1 = ""
                        .ClientLocNo = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .Facility = ""
                        .Frequency = ""
                        .Address1 = ""
                        .City = ""
                        .StProv = ""
                        .Zip = ""
                        .Country = ""
                        .Phone1 = ""
                        .Fax = ""
                        .InspNotes = ""
                        .Rpt1Client = "1/1/1900"
                        .LocationStatus = ""
                        .InspectionStatus = ""
                        .SchedFROM = "1/1/1900"
                        .SchedTO = "1/1/1900"
                        .DateCompleted = "1/1/1900"
                        .SchedulingComment = ""
                        .CustomAccess = ""
                        '.NHWindLastInspectionReport = ""
                        '.NHWindLastInspectionDate = "1/1/1900"
                        '.NHWindActualDate = "1/1/1900"
                        '.ToNHWindReport = ""
                        '.ToNHWindReport2 = ""
                        '.ToNHWindDiagram = ""
                        '.NHWindEmailedDate = "1/1/1900"
                        .NHLastInspectionReport = ""
                        .NHLastInspectionDate = "1/1/1900"
                        .NHActualDate = "1/1/1900"
                        .ToNHReport = ""
                        .ToNHReport2 = ""
                        .ToNHDiagram = ""
                        .NHEmailedDate = "1/1/1900"
                        .GSafeGUID = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As ViewCCLocationListingNH In zNHLocationListingCollection
                    'Dim zColumn As TemplateColumn
                    If Not zItem.DateCompleted Is Nothing Then
                        zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
                    End If
                    If Not zItem.NHActualDate Is Nothing Then
                        zItem.NHActualDate = zTime.ServerToUTC(zItem.NHActualDate, zHemisphere)
                    End If
                    If Not zItem.NHEmailedDate Is Nothing Then
                        zItem.NHEmailedDate = zTime.ServerToUTC(zItem.NHEmailedDate, zHemisphere)
                    End If
                    If Not zItem.NHLastInspectionDate Is Nothing Then
                        zItem.NHLastInspectionDate = zTime.ServerToUTC(zItem.NHLastInspectionDate, zHemisphere)
                    End If
                Next

                zNHLocationListingCollection(0).RecCount = zRecCount
                zNHLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zNHLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function GetRecResponseNHLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponseNHCollection, ViewCCLocationListingRecResponseNH)
        '    Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponseNHCollection, ViewCCLocationListingRecResponseNH)

        '    Try
        '        Dim zParms() As String = Split(pParms, "|")
        '        Dim zFileNo As String = zParms(0)
        '        Dim zRecCount As Integer = 0
        '        Dim zRecPosition As Integer = 0

        '        GetRecResponseCountPositionFileNoNH(zRecCount, zRecPosition, zFileNo)

        '        Dim zNHLocationListingQry As New ViewCCLocationListingRecResponseNHQuery
        '        Dim zNHLocationListingCollection As New ViewCCLocationListingRecResponseNHCollection

        '        zNHLocationListingQry.SelectAll()
        '        zNHLocationListingQry.Where(zNHLocationListingQry.FileNo = zFileNo)
        '        zNHLocationListingCollection.Load(zNHLocationListingQry)

        '        If zNHLocationListingCollection.Count = 0 Then
        '            zNHLocationListingCollection.AddNew() 'create a blank record when no matching records existing
        '            With zNHLocationListingCollection(0)
        '                .FileNo = "Not Found"
        '                .Client = ""
        '                .PracticeCode = 0
        '                '.Report1 = ""
        '                .ClientLocNo = ""
        '                .Division = ""
        '                .Latitude = 0
        '                .Longitude = 0
        '                .Facility = ""
        '                .Frequency = ""
        '                .Address1 = ""
        '                .City = ""
        '                .StProv = ""
        '                .Zip = ""
        '                .Country = ""
        '                .Phone1 = ""
        '                .Fax = ""
        '                .InspNotes = ""
        '                .Rpt1Client = "1/1/1900"
        '                .LocationStatus = ""
        '                .InspectionStatus = ""
        '                .SchedFROM = "1/1/1900"
        '                .SchedTO = "1/1/1900"
        '                .DateCompleted = "1/1/1900"
        '                .SchedulingComment = ""
        '                .CustomAccess = ""
        '                '.NHWindLastInspectionReport = ""
        '                '.NHWindLastInspectionDate = "1/1/1900"
        '                '.NHWindActualDate = "1/1/1900"
        '                '.ToNHWindReport = ""
        '                '.ToNHWindReport2 = ""
        '                '.ToNHWindDiagram = ""
        '                '.NHWindEmailedDate = "1/1/1900"
        '                .NHLastInspectionReport = ""
        '                .NHLastInspectionDate = "1/1/1900"
        '                .NHActualDate = "1/1/1900"
        '                .ToNHReport = ""
        '                .ToNHReport2 = ""
        '                .ToNHDiagram = ""
        '                .NHEmailedDate = "1/1/1900"
        '            End With
        '        End If

        '        zNHLocationListingCollection(0).RecCount = zRecCount
        '        zNHLocationListingCollection(0).RecNum = zRecPosition

        '        zResponse.collection = zNHLocationListingCollection

        '    Catch ex As Exception
        '        zResponse.exception = ex.Message
        '    End Try

        '    Return zResponse
        'End Function

        Private Sub SetFilterCriteriaNH(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingNHQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentNH(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentNH(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentNH(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentNH(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentNH(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentNH(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentNH(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentNH(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentNH(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentNH(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentNH(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentNH(zFindLatitude)))

        End Sub

        Private Function SPercentNH(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoNH(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zNHLocationListingQry As New ViewCCLocationListingNHQuery
            Dim zNHLocationListingCollection As New ViewCCLocationListingNHCollection

            zNHLocationListingQry.Select(zNHLocationListingQry.FileNo)
            zNHLocationListingQry.Where(zNHLocationListingQry.GSafeGUID = pSafeGUID)
            zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaNH(pSafeGUID, zNHLocationListingQry)

            zNHLocationListingCollection.Load(zNHLocationListingQry)
            pRecCount = zNHLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingNH In zNHLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        'Private Sub GetRecResponseCountPositionFileNoNH(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
        '    pRecCount = 0
        '    pRecPosition = 0

        '    Dim zFileNo As String = pFileNo
        '    Dim zNHLocationListingQry As New ViewCCLocationListingRecResponseNHQuery
        '    Dim zNHLocationListingCollection As New ViewCCLocationListingRecResponseNHCollection

        '    zNHLocationListingQry.Select(zNHLocationListingQry.FileNo)
        '    zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
        '    zNHLocationListingCollection.Load(zNHLocationListingQry)
        '    pRecCount = zNHLocationListingCollection.Count

        '    Dim zPosNdx As Integer = 1

        '    For Each zItem As ViewCCLocationListingRecResponseNH In zNHLocationListingCollection
        '        If zItem.FileNo = zFileNo Then
        '            pRecPosition = zPosNdx
        '            Exit For
        '        End If
        '        zPosNdx = zPosNdx + 1
        '    Next
        'End Sub

        Private Sub GetRecCountPositionNH(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zNHLocationListingQry As New ViewCCLocationListingNHQuery
            Dim zNHLocationListingCollection As New ViewCCLocationListingNHCollection

            zNHLocationListingQry.Select(zNHLocationListingQry.FileNo)
            zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zNHLocationListingCollection.Load(zNHLocationListingQry)
            pRecCount = zNHLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingNH In zNHLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNoNH(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zNHLocationListingQry As New ViewCCLocationListingNHQuery
            Dim zNHLocationListingCollection As New ViewCCLocationListingNHCollection

            zNHLocationListingQry.Select(zNHLocationListingQry.FileNo)
            zNHLocationListingQry.Where(zNHLocationListingQry.GSafeGUID = pSafeGUID)
            zNHLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zNHLocationListingQry.Where(zNHLocationListingQry.FileNo > zFileNo)
                    zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zNHLocationListingQry.Where(zNHLocationListingQry.FileNo < zFileNo)
                    zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zNHLocationListingQry.OrderBy(ViewCCLocationListingNHBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaNH(pSafeGUID, zNHLocationListingQry)

            zNHLocationListingCollection.Load(zNHLocationListingQry)

            Dim zNewFileNo As String = ""

            If zNHLocationListingCollection.Count > 0 Then
                zNewFileNo = zNHLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)
        End Sub

#End Region

        '-----------------------------------------------------------------------------------------------------------------------------------'


        '#Region "IViewCCLocationContactsNatHazCollection"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function ViewCCLocationContactsNatHazCollections(pSafeGuid As String) As jsResponse(Of ViewCCLocationContactsNatHazCollection, ViewCCLocationContactsNatHaz)
        '            Dim zResponse As New jsResponse(Of ViewCCLocationContactsNatHazCollection, ViewCCLocationContactsNatHaz)

        '            Try
        '                Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)
        '                Dim zNATLocationContactsQry As New ViewCCLocationContactsNatHazQuery
        '                Dim zNATLocationContactsCollection As New ViewCCLocationContactsNatHazCollection

        '                zNATLocationContactsQry.SelectAll()
        '                zNATLocationContactsQry.Where(zNATLocationContactsQry.FileNo = zFileNo)
        '                zNATLocationContactsCollection.Load(zNATLocationContactsQry)

        '                zResponse.collection = zNATLocationContactsCollection

        '            Catch ex As Exception
        '                zResponse.exception = ex.ToString
        '            End Try

        '            Return zResponse

        '        End Function

        '#End Region


        '-----------------------------------------------------------------------------------------------------------------------------------'


#Region "IViewCCLocationInspectionNatHazCollection"

        ' STB DONE: ViewCCLocationInspectionNHCollections
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionNHCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionNHCollection, ViewCCLocationInspectionNH)
            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNHCollection, ViewCCLocationInspectionNH)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNHLocationInspectionQry As New ViewCCLocationInspectionNHQuery
                Dim zNHLocationInspectionCollection As New ViewCCLocationInspectionNHCollection

                zNHLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zNHLocationInspectionQry.es.Top = 1
                    End If
                End If

                zNHLocationInspectionQry.Where(zNHLocationInspectionQry.FileNo = zFileNo)
                zNHLocationInspectionCollection.Load(zNHLocationInspectionQry)

                If zNHLocationInspectionCollection.Count = 0 Then
                    zNHLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zNHLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                    End With
                End If

                zResponse.collection = zNHLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionNatHazCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
            '    Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection
            '    zNatHazLocationInspectionQry.SelectAll()
            '    zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo)
            '    zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)
            '    zResponse.collection = zNatHazLocationInspectionCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
                Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection

                zNatHazLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zNatHazLocationInspectionQry.es.Top = 1
                    End If
                End If

                zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo)
                zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)

                If zNatHazLocationInspectionCollection.Count = 0 Then
                    zNatHazLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                    End With
                End If

                zResponse.collection = zNatHazLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionFloodCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
            '    Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection
            '    zNatHazLocationInspectionQry.SelectAll()
            '    zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo)
            '    zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)
            '    zResponse.collection = zNatHazLocationInspectionCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
                Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection

                zNatHazLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zNatHazLocationInspectionQry.es.Top = 1
                    End If
                End If

                zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo, zNatHazLocationInspectionQry.Report1.Like("%flood%"))
                zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)

                If zNatHazLocationInspectionCollection.Count = 0 Then
                    zNatHazLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                    End With
                End If

                zResponse.collection = zNatHazLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionSeismicCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
            '    Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection
            '    zNatHazLocationInspectionQry.SelectAll()
            '    zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo)
            '    zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)
            '    zResponse.collection = zNatHazLocationInspectionCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
                Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection

                zNatHazLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zNatHazLocationInspectionQry.es.Top = 1
                    End If
                End If

                zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo, zNatHazLocationInspectionQry.Report1.Like("%seismic%"))
                zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)

                If zNatHazLocationInspectionCollection.Count = 0 Then
                    zNatHazLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                    End With
                End If

                zResponse.collection = zNatHazLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionWindCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
            '    Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection
            '    zNatHazLocationInspectionQry.SelectAll()
            '    zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo)
            '    zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)
            '    zResponse.collection = zNatHazLocationInspectionCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionNatHazCollection, ViewCCLocationInspectionNatHaz)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zNatHazLocationInspectionQry As New ViewCCLocationInspectionNatHazQuery
                Dim zNatHazLocationInspectionCollection As New ViewCCLocationInspectionNatHazCollection

                zNatHazLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zNatHazLocationInspectionQry.es.Top = 1
                    End If
                End If

                zNatHazLocationInspectionQry.Where(zNatHazLocationInspectionQry.FileNo = zFileNo, zNatHazLocationInspectionQry.Report1.Like("%wind%"))
                zNatHazLocationInspectionCollection.Load(zNatHazLocationInspectionQry)

                If zNatHazLocationInspectionCollection.Count = 0 Then
                    zNatHazLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zNatHazLocationInspectionCollection(0)
                        .FileNo = "Not Found"
                        .PracticeCode = 0
                        .Engineer = ""
                        .LocationStatus = ""
                        .ContractYr = 0
                        .Frequency = ""
                        .NextInspYr = 0
                        .PDBuilding = ""
                        .TotalUSTIV = ""
                        .PDFinished = ""
                        .PDRawStock = ""
                        .PDBuildersRisk = ""
                        .PDMisc = ""
                        .PDTotal = ""
                        .BIGrossProfit = ""
                        .BIWageExtraExp = ""
                        .BIMisc = ""
                        .BIOther = ""
                        .BITotal = ""
                        .GrossProfitIndemnity = 0
                        .WagesExtraExpIndem = 0
                        .TotalUSPD = ""
                        .TotalUSBI = ""
                        .LocalTIV = ""
                        .Percentustot100 = 0
                        .InspDue = 0
                        .InspRemaining = 0
                        .EngTargetMo = "1/1/1900"
                        .InspPerFROM = "1/1/1900"
                        .InspPerTO = "1/1/1900"
                        .CancelDate = "1/1/1900"
                        .InspectionStatus = ""
                        .EffectiveDate = "1/1/1900"
                        .CurrencyCode = ""
                        .PDEquipment = ""
                        .DateCompleted = "1/1/1900"
                        .DateMailedToClient = "1/1/1900"
                        .ClientTargetMo = "1/1/1900"
                    End With
                End If

                zResponse.collection = zNatHazLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

        '-----------------------------------------------------------------------------------------------------------------------------------'


#Region "IViewCCLocationJurisCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationJurisCollections(pParms As String) As jsResponse(Of ViewCCLocationListingJurisCollection, ViewCCLocationListingJuris)
            'Dim zResponse As New jsResponse(Of ViewCCLocationListingJurisCollection, ViewCCLocationListingJuris)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zJurisLocationListingQry As New ViewCCLocationListingJurisQuery
            '    Dim zJurisLocationListingCollection As New ViewCCLocationListingJurisCollection

            '    zJurisLocationListingQry.SelectAll()
            '    zJurisLocationListingQry.Where(zJurisLocationListingQry.FileNo = zFileNo)
            '    zJurisLocationListingCollection.Load(zJurisLocationListingQry)
            '    zResponse.collection = zJurisLocationListingCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationListingjurisCollection, ViewCCLocationListingjuris)
            Dim zLimit As String = "One"

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zSafeGUID As String = zParms(0)

                If UBound(zParms) > 0 Then
                    Dim zDirection As String = zParms(1)
                    If zDirection.Length > 0 Then NavigateFileNojuris(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFileNojuris(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zjurisLocationListingQry As New ViewCCLocationListingjurisQuery
                Dim zjurisLocationListingCollection As New ViewCCLocationListingjurisCollection

                zjurisLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zjurisLocationListingQry.Where(zjurisLocationListingQry.FileNo = zFileNo)
                End If

                zjurisLocationListingQry.Where(zjurisLocationListingQry.GSafeGUID = zSafeGUID)
                SetFilterCriteriajuris(zSafeGUID, zjurisLocationListingQry)
                zjurisLocationListingCollection.Load(zjurisLocationListingQry)

                If zjurisLocationListingCollection.Count = 0 Then
                    zjurisLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zjurisLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .StrClientName = ""
                        .StrCountry = ""
                        .Country = ""
                        .Intlocationid = 0
                        .StrClientLocationNum = ""
                        .Clientlocno = ""
                        .StrClientNumber = ""
                        .StrDivisionName = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .StrCompanyLocationNumber = ""
                        .StrLocationName = ""
                        .Facility = ""
                        .StrAddr1 = ""
                        .Address1 = ""
                        .StrAddr2 = ""
                        .StrCity = ""
                        .City = ""
                        .StrState = ""
                        .Stprov = ""
                        .Zip = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                zjurisLocationListingCollection(0).RecCount = zRecCount
                zjurisLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zjurisLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetJurisLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingJurisCollection, ViewCCLocationListingJuris)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingJurisCollection, ViewCCLocationListingJuris)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionJuris(zRecCount, zRecPosition, zFileNo)

                Dim zjurisLocationListingQry As New ViewCCLocationListingJurisQuery
                Dim zjurisLocationListingCollection As New ViewCCLocationListingJurisCollection
                zjurisLocationListingQry.SelectAll()
                zjurisLocationListingQry.Where(zjurisLocationListingQry.FileNo = zFileNo)
                zjurisLocationListingCollection.Load(zjurisLocationListingQry)

                If zjurisLocationListingCollection.Count = 0 Then
                    zjurisLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zjurisLocationListingCollection(0)
                        .FileNo = "Not Found"
                        .StrClientName = ""
                        .StrCountry = ""
                        .Country = ""
                        .Intlocationid = 0
                        .StrClientLocationNum = ""
                        .Clientlocno = ""
                        .StrClientNumber = ""
                        .StrDivisionName = ""
                        .Division = ""
                        .Latitude = 0
                        .Longitude = 0
                        .StrCompanyLocationNumber = ""
                        .StrLocationName = ""
                        .Facility = ""
                        .StrAddr1 = ""
                        .Address1 = ""
                        .StrAddr2 = ""
                        .StrCity = ""
                        .City = ""
                        .StrState = ""
                        .Stprov = ""
                        .Zip = ""
                        .CustomAccess = ""
                        .GSafeGUID = ""
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                ' **** NOTE: THERE ARE NO DATE FIELDS IN THIS COLLECTION ****
                'Dim zTime As New GRC.Connect.Libraries.CoreLib.UtilTime
                'For Each zItem As ViewCCLocationListingJuris In zjurisLocationListingCollection
                'Next

                zjurisLocationListingCollection(0).RecCount = zRecCount
                zjurisLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zjurisLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        Private Sub SetFilterCriteriajuris(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingJurisQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentjuris(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentjuris(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.Clientlocno.Like(SPercentjuris(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentjuris(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.Stprov.Like(SPercentjuris(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentjuris(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentjuris(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentjuris(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentjuris(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentjuris(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentjuris(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentjuris(zFindLatitude)))

        End Sub

        Private Function SPercentjuris(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNojuris(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zjurisLocationListingQry As New ViewCCLocationListingjurisQuery
            Dim zjurisLocationListingCollection As New ViewCCLocationListingjurisCollection

            zjurisLocationListingQry.Select(zjurisLocationListingQry.FileNo)
            zjurisLocationListingQry.Where(zjurisLocationListingQry.GSafeGUID = pSafeGUID)
            zjurisLocationListingQry.OrderBy(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriajuris(pSafeGUID, zjurisLocationListingQry)

            zjurisLocationListingCollection.Load(zjurisLocationListingQry)
            pRecCount = zjurisLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingjuris In zjurisLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionJuris(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zjurisLocationListingQry As New ViewCCLocationListingJurisQuery
            Dim zjurisLocationListingCollection As New ViewCCLocationListingJurisCollection

            zjurisLocationListingQry.Select(zjurisLocationListingQry.FileNo)
            zjurisLocationListingQry.OrderBy(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zjurisLocationListingCollection.Load(zjurisLocationListingQry)
            pRecCount = zjurisLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingJuris In zjurisLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNojuris(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zjurisLocationListingQry As New ViewCCLocationListingJurisQuery
            Dim zjurisLocationListingCollection As New ViewCCLocationListingJurisCollection

            zjurisLocationListingQry.Select(zjurisLocationListingQry.FileNo)
            zjurisLocationListingQry.Where(zjurisLocationListingQry.GSafeGUID = pSafeGUID)
            zjurisLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zjurisLocationListingQry.Where(zjurisLocationListingQry.FileNo > zFileNo)
                    zjurisLocationListingQry.OrderBy(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zjurisLocationListingQry.Where(zjurisLocationListingQry.FileNo < zFileNo)
                    zjurisLocationListingQry.OrderBy(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zjurisLocationListingQry.OrderBy(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zjurisLocationListingQry.OrderBy(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriajuris(pSafeGUID, zjurisLocationListingQry)

            zjurisLocationListingCollection.Load(zjurisLocationListingQry)

            Dim zNewFileNo As String = ""

            If zjurisLocationListingCollection.Count > 0 Then
                zNewFileNo = zjurisLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)
        End Sub

#End Region

        '#Region "IViewCCLocationContactsJurisCollection"
        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function ViewCCLocationContactsJurisCollections(pSafeGuid As String) As jsResponse(Of ViewCCLocationContactsJurisCollection, ViewCCLocationContactsJuris)

        '            Throw New NotImplementedException("Not Implemented")

        '            'Dim zResponse As New jsResponse(Of ViewCCLocationContactsJurisCollection, ViewCCLocationContactsJuris)

        '            'Try
        '            '    Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)
        '            '    Dim zJurisLocationListingQry As New ViewCCLocationContactsJurisQuery
        '            '    Dim zJurisLocationListingCollection As New ViewCCLocationContactsJurisCollection

        '            '    zJurisLocationListingQry.SelectAll()
        '            '    zJurisLocationListingQry.Where(zJurisLocationListingQry.FileNo = zFileNo)
        '            '    zJurisLocationListingCollection.Load(zJurisLocationListingQry)

        '            '    zResponse.collection = zJurisLocationListingCollection

        '            'Catch ex As Exception
        '            '    zResponse.exception = ex.ToString
        '            'End Try

        '            'Return zResponse

        '        End Function
        '#End Region

#Region "IViewCCLocationAllViolationsJurisCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationAllViolationsJurisCollections(pSafeGuid As String) As jsResponse(Of ViewCCLocationAllViolationsJurisCollection, ViewCCLocationAllViolationsJuris)
            Dim zResponse As New jsResponse(Of ViewCCLocationAllViolationsJurisCollection, ViewCCLocationAllViolationsJuris)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(pSafeGuid, UtilGSafe.KeyName.FileNo)
                Dim zJurisLocationAllViolationsQry As New ViewCCLocationAllViolationsJurisQuery
                Dim zJurisLocationAllViolationsCollection As New ViewCCLocationAllViolationsJurisCollection

                zJurisLocationAllViolationsQry.SelectAll()
                zJurisLocationAllViolationsQry.Where(zJurisLocationAllViolationsQry.FileNo = zFileNo)
                zJurisLocationAllViolationsCollection.Load(zJurisLocationAllViolationsQry)

                zResponse.collection = zJurisLocationAllViolationsCollection

            Catch ex As Exception
                zResponse.exception = ex.ToString
            End Try

            Return zResponse

        End Function
#End Region

#Region "IViewCCLocationOpenViolationCountJurisCollection"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationOpenViolationCountJurisCollections(pParms As String) As jsResponse(Of ViewCCLocationOpenViolationCountJurisCollection, ViewCCLocationOpenViolationCountJuris)
            'Dim zResponse As New jsResponse(Of ViewCCLocationOpenViolationCountJurisCollection, ViewCCLocationOpenViolationCountJuris)
            'Try
            '    Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(pSafeGuid, "FileNo")
            '    Dim zJurisOpenViolationCountQry As New ViewCCLocationOpenViolationCountJurisQuery
            '    Dim zJurisOpenViolationCountCollection As New ViewCCLocationOpenViolationCountJurisCollection
            '    zJurisOpenViolationCountQry.SelectAll()
            '    zJurisOpenViolationCountQry.Where(zJurisOpenViolationCountQry.Fileno = zFileNo)
            '    zJurisOpenViolationCountCollection.Load(zJurisOpenViolationCountQry)
            '    zResponse.collection = zJurisOpenViolationCountCollection
            'Catch ex As Exception
            '    zResponse.exception = ex.ToString
            'End Try
            'Return zResponse

            Dim zResponse As New jsResponse(Of ViewCCLocationOpenViolationCountJurisCollection, ViewCCLocationOpenViolationCountJuris)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zJurisLocationInspectionQry As New ViewCCLocationOpenViolationCountJurisQuery
                Dim zJurisLocationInspectionCollection As New ViewCCLocationOpenViolationCountJurisCollection

                zJurisLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zJurisLocationInspectionQry.es.Top = 1
                    End If
                End If

                zJurisLocationInspectionQry.Where(zJurisLocationInspectionQry.FileNo = zFileNo)

                zJurisLocationInspectionCollection.Load(zJurisLocationInspectionQry)

                If zJurisLocationInspectionCollection.Count = 0 Then
                    zJurisLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zJurisLocationInspectionCollection(0)
                        .Fileno = "" ' **** NOTE: TO HAVE A POPUP WINDOW DISPLAYING NO DETAILS FOUND, INSERT "Not Found" STRING HERE
                        .CountOpen = 0
                    End With
                End If

                zResponse.collection = zJurisLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function
#End Region


        '-----------------------------------------------------------------------------------------------------------------------------------'


#Region "IViewCCNavLinkCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCNavLinksSitemapGetAll() As jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)

            ' *** IMPORTANT NOTE:
            ' *** THIS IS A TEMPORARY FUNCTION THAT IGNORES SPECIAL FEATURES AND PRACTICES. FOR EXPERIMENTAL USE ONLY.
            ' *** DO NOT USE!

            Dim zResponse As New jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)
            Dim zColl As New ViewCCNavLinkCollection
            Dim zQry As New ViewCCNavLinkQuery

            Try
                zQry.Select()
                zQry.Where(zQry.NavSiteMapKeyWord <> "")
                zColl.Load(zQry)
                zResponse.collection = zColl
            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCNavLinksByKeyword(Parms As String) As jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)
            Dim ParmArray() As String = Parms.Split("|")
            Dim zSafeGuid As String = ParmArray(0)
            Dim zSiteMapKeyword As String = ParmArray(1)

            Dim zResponse As New jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)

            Try
                Stop
                '                zResponse.collection = UtilNav.GetLinks(zSafeGuid, UtilNav.KeywordColumn.SiteMap, zSiteMapKeyword)
            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
            'zResponse

        End Function

        '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        'Public Function ViewCCNavLinksAllReportsByKeyword(Parms As String) As jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)
        '    Dim ParmArray() As String = Parms.Split("|")
        '    Dim zSafeGuid As String = ParmArray(0)
        '    Dim zSiteMapKeyword As String = ParmArray(1)

        '    Dim zResponse As New jsResponse(Of ViewCCNavLinkCollection, ViewCCNavLink)

        '    Try
        '        Dim zUtilNavLink As New UtilNavLink(zSafeGuid)
        '        Dim zCol As ViewCCNavLinkCollection = zUtilNavLink.GetBatchReportLinksByKeyword(zSiteMapKeyword).ToCollection
        '        zResponse.collection = zCol
        '        '           zResponse.collection = UtilNav.GetLinks(zSafeGuid, UtilNav.KeywordColumn.AllReports, zSiteMapKeyword)
        '    Catch ex As Exception
        '        zResponse.exception = ex.Message
        '    End Try

        '    Return zResponse
        '    'zResponse

        'End Function

        'Private Function GetUniqueNavTexts(ByVal siteMapKeyword As String, ByVal pSafeGUID As String) As List(Of String)

        '    Dim zNavLinkQry As New ViewCCNavLinkQuery
        '    Dim zNavLinkCollection As New ViewCCNavLinkCollection
        '    Dim zList As New List(Of String)
        '    Dim zNavLinkURLText As String = ""

        '    'We need a query that gets unique link texts from the SiteMapKeyword
        '    zNavLinkQry.Select(zNavLinkQry.NavText)
        '    zNavLinkQry.es.Distinct = True
        '    zNavLinkQry.Where(zNavLinkQry.NavSiteMapKeyWord.ToLower = siteMapKeyword.ToLower)
        '    zNavLinkQry.Where(zNavLinkQry.NavVisible = True)

        '    If zNavLinkCollection.Load(zNavLinkQry) Then
        '        For Each zNavLink As ViewCCNavLink In zNavLinkCollection
        '            zList.Add(zNavLink.NavText)
        '        Next

        '        Return zList
        '    Else
        '        Return Nothing

        '    End If

        'End Function


        'Private Function GetSpecialFeatureLink(ByVal siteMapKeyWord As String, ByVal siteNavText As String, ByVal spcFeatLtr As String) As ViewCCNavLink

        '    Dim zViewCCNavLinkQry As New ViewCCNavLinkQuery
        '    Dim zViewCCNavLinkCol As New ViewCCNavLinkCollection

        '    'Create a query to lookup to see if any links match the keyword, nav text and spec feature
        '    zViewCCNavLinkQry = New ViewCCNavLinkQuery
        '    zViewCCNavLinkQry.SelectAll()
        '    zViewCCNavLinkQry.Where(zViewCCNavLinkQry.NavSiteMapKeyWord.ToLower = siteMapKeyWord.ToLower And zViewCCNavLinkQry.NavText.ToLower = siteNavText.ToLower And zViewCCNavLinkQry.NavSpcFeature.ToLower = spcFeatLtr.ToLower)
        '    zViewCCNavLinkQry.Where(zViewCCNavLinkQry.NavVisible = True)

        '    'Load the query. If there is a record that matches the parameter values, then we want to return that navlink because that is the link we need to return to the calling procedure
        '    If zViewCCNavLinkCol.Load(zViewCCNavLinkQry) Then

        '        'Return the first and only navlink in the collection
        '        Return zViewCCNavLinkCol(0)

        '    Else

        '        Return Nothing

        '    End If


        'End Function



        'Private Function GetNormalLink(ByVal siteMapKeyWord As String, ByVal siteNavText As String) As ViewCCNavLink

        '    Dim zViewCCNavLinkQry As New ViewCCNavLinkQuery
        '    Dim zViewCCNavLinkCol As New ViewCCNavLinkCollection

        '    zViewCCNavLinkQry.SelectAll()
        '    zViewCCNavLinkQry.Where(zViewCCNavLinkQry.NavSiteMapKeyWord.ToLower = siteMapKeyWord.ToLower)
        '    zViewCCNavLinkQry.Where(zViewCCNavLinkQry.NavText.ToLower = siteNavText.ToLower)
        '    zViewCCNavLinkQry.Where(zViewCCNavLinkQry.NavSpcFeature = String.Empty Or zViewCCNavLinkQry.NavSpcFeature.IsNull)
        '    zViewCCNavLinkQry.Where(zViewCCNavLinkQry.NavVisible = True)

        '    'Load the query. If there is a record that matches the parameter values, then we want to return that navlink because that is the link we need to return to the calling procedure
        '    If zViewCCNavLinkCol.Load(zViewCCNavLinkQry) Then

        '        'Return the first and only navlink in the collection
        '        Return zViewCCNavLinkCol(0)

        '    Else

        '        Return Nothing

        '    End If


        'End Function


#End Region


    End Class

End Namespace
