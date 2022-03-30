Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery

Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Namespace Service

    Partial Class ViewServer

#Region "IViewCCLocationPSCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationPSCollections(pParms As String) As jsResponse(Of ViewCCLocationListingPSCollection, ViewCCLocationListingPS)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingPSCollection, ViewCCLocationListingPS)
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
                    If zDirection.Length > 0 And Not zIsFromChart Then NavigateFileNoPS(zSafeGUID, zDirection)
                End If

                If UBound(zParms) > 1 Then
                    zLimit = zParms(2) 'All or One
                End If

                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionFileNoPS(zRecCount, zRecPosition, zSafeGUID)

                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, zKeyName)

                Dim zPSLocationListingQry As New ViewCCLocationListingPSQuery
                Dim zPSLocationListingCollection As New ViewCCLocationListingPSCollection

                zPSLocationListingQry.SelectAll()

                If zLimit.ToLower = "one" Then
                    zPSLocationListingQry.Where(zPSLocationListingQry.FileNo = zFileNo)
                End If

                zPSLocationListingQry.Where(zPSLocationListingQry.GSafeGUID = zSafeGUID)

                SetFilterCriteriaPS(zSafeGUID, zPSLocationListingQry)

                zPSLocationListingCollection.Load(zPSLocationListingQry)

                If zPSLocationListingCollection.Count = 0 Then
                    zPSLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zPSLocationListingCollection(0)
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
                        '.GRCEngineerPS = ""
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
                        '.PSFreq = ""
                        '.PS2000 = 0
                        '.PS2001 = 0
                        '.PS2002 = 0
                        '.PS2003 = 0
                        '.PS2004 = 0
                        '.PS2005 = 0
                        '.PSTargetMonth = 0
                        .PSLastInspectionReport = ""
                        .PSLastInspectionDate = "1/1/1900"
                        ' .PSScheduledDate = "1/1/1900"
                        .PSActualDate = "1/1/1900"
                        .ToPSReport = ""
                        .ToPSReport2 = ""
                        .ToPSDiagram = ""
                        '.ToBPVReport = ""
                        .PSEmailedDate = "1/1/1900"
                        ' .PSInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.PSRecResponseRecevied = ""
                        '.PSAQEDateRecevied = ""
                        '.PSAQERating = ""
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
                        '.PSComments = ""
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
                        '.PSUpdate = False
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

                zPSLocationListingCollection(0).RecCount = zRecCount
                zPSLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zPSLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetPSLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingPSCollection, ViewCCLocationListingPS)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingPSCollection, ViewCCLocationListingPS)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecCountPositionPS(zRecCount, zRecPosition, zFileNo)

                Dim zPSLocationListingQry As New ViewCCLocationListingPSQuery
                Dim zPSLocationListingCollection As New ViewCCLocationListingPSCollection
                zPSLocationListingQry.SelectAll()
                zPSLocationListingQry.Where(zPSLocationListingQry.FileNo = zFileNo)
                zPSLocationListingCollection.Load(zPSLocationListingQry)

                If zPSLocationListingCollection.Count = 0 Then
                    zPSLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zPSLocationListingCollection(0)
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
                        '.GRCEngineerPS = ""
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
                        '.PSFreq = ""
                        '.PS2000 = 0
                        '.PS2001 = 0
                        '.PS2002 = 0
                        '.PS2003 = 0
                        '.PS2004 = 0
                        '.PS2005 = 0
                        '.PSTargetMonth = 0
                        .PSLastInspectionReport = ""
                        .PSLastInspectionDate = "1/1/1900"
                        ' .PSScheduledDate = "1/1/1900"
                        .PSActualDate = "1/1/1900"
                        .ToPSReport = ""
                        .ToPSReport2 = ""
                        .ToPSDiagram = ""
                        '.ToBPVReport = ""
                        .PSEmailedDate = "1/1/1900"
                        '.PSInspectionCount = ""
                        '.SpecialReport = ""
                        '.PlanReview = ""
                        '.PSRecResponseRecevied = ""
                        '.PSAQEDateRecevied = ""
                        '.PSAQERating = ""
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
                        '.PSComments = ""
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
                        '.PSUpdate = False
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

                zPSLocationListingCollection(0).RecCount = zRecCount
                zPSLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zPSLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetRecResponsePSLocationByFileNo(pParms As String) As jsResponse(Of ViewCCLocationListingRecResponsePSCollection, ViewCCLocationListingRecResponsePS)
            Dim zResponse As New jsResponse(Of ViewCCLocationListingRecResponsePSCollection, ViewCCLocationListingRecResponsePS)

            Try
                Dim zParms() As String = Split(pParms, "|")
                Dim zFileNo As String = zParms(0)
                Dim zHemisphere As String = zParms(1)
                Dim zRecCount As Integer = 0
                Dim zRecPosition As Integer = 0

                GetRecResponseCountPositionPS(zRecCount, zRecPosition, zFileNo)

                Dim zPSLocationListingQry As New ViewCCLocationListingRecResponsePSQuery
                Dim zPSLocationListingCollection As New ViewCCLocationListingRecResponsePSCollection
                zPSLocationListingQry.SelectAll()
                zPSLocationListingQry.Where(zPSLocationListingQry.FileNo = zFileNo)
                zPSLocationListingCollection.Load(zPSLocationListingQry)

                If zPSLocationListingCollection.Count = 0 Then
                    zPSLocationListingCollection.AddNew() 'create a blank record when no matching records existing
                    With zPSLocationListingCollection(0)
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
                        .PSLastInspectionReport = ""
                        .PSLastInspectionDate = "1/1/1900"
                        .PSActualDate = "1/1/1900"
                        .ToPSReport = ""
                        .ToPSReport2 = ""
                        .ToPSDiagram = ""
                        .PSEmailedDate = "1/1/1900"
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
                For Each zItem As ViewCCLocationListingRecResponsePS In zPSLocationListingCollection
                    If Not zItem.DateCompleted Is Nothing Then
                        zItem.DateCompleted = zTime.ServerToUTC(zItem.DateCompleted, zHemisphere)
                    End If
                    If Not zItem.PSActualDate Is Nothing Then
                        zItem.PSActualDate = zTime.ServerToUTC(zItem.PSActualDate, zHemisphere)
                    End If
                    If Not zItem.PSEmailedDate Is Nothing Then
                        zItem.PSEmailedDate = zTime.ServerToUTC(zItem.PSEmailedDate, zHemisphere)
                    End If
                    If Not zItem.PSLastInspectionDate Is Nothing Then
                        zItem.PSLastInspectionDate = zTime.ServerToUTC(zItem.PSLastInspectionDate, zHemisphere)
                    End If
                Next

                zPSLocationListingCollection(0).RecCount = zRecCount
                zPSLocationListingCollection(0).RecNum = zRecPosition

                zResponse.collection = zPSLocationListingCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        Private Sub SetFilterCriteriaPS(pSafeGUID As String, ByRef pListingQuery As ViewCCLocationListingPSQuery)
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

            If zFindCity.Length > 0 Then pListingQuery.Where(pListingQuery.City.Like(SPercentPS(zFindCity)))
            If zFindFileNo.Length > 0 Then pListingQuery.Where(pListingQuery.FileNo.Like(SPercentPS(zFindFileNo)))
            If zFindClientLocNo.Length > 0 Then pListingQuery.Where(pListingQuery.ClientLocNo.Like(SPercentPS(zFindClientLocNo)))
            If zFindAddress1.Length > 0 Then pListingQuery.Where(pListingQuery.Address1.Like(SPercentPS(zFindAddress1)))
            If zFindStProv.Length > 0 Then pListingQuery.Where(pListingQuery.StProv.Like(SPercentPS(zFindStProv)))
            If zFindCountry.Length > 0 Then pListingQuery.Where(pListingQuery.Country.Like(SPercentPS(zFindCountry)))
            If zFindZip.Length > 0 Then pListingQuery.Where(pListingQuery.Zip.Like(SPercentPS(zFindZip)))
            If zFindDivision.Length > 0 Then pListingQuery.Where(pListingQuery.Division.Like(SPercentPS(zFindDivision)))
            If zFindFacility.Length > 0 Then pListingQuery.Where(pListingQuery.Facility.Like(SPercentPS(zFindFacility)))
            If zFindCustomAccess.Length > 0 Then pListingQuery.Where(pListingQuery.CustomAccess.Like(SPercentPS(zFindCustomAccess)))
            If zFindLongitude.Length > 0 Then pListingQuery.Where(pListingQuery.Longitude.Like(SPercentPS(zFindLongitude)))
            If zFindLatitude.Length > 0 Then pListingQuery.Where(pListingQuery.Latitude.Like(SPercentPS(zFindLatitude)))

        End Sub

        Private Function SPercentPS(pData As String) As String
            Return "%" & pData & "%"
        End Function

        Private Sub GetRecCountPositionFileNoPS(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pSafeGUID As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zPSLocationListingQry As New ViewCCLocationListingPSQuery
            Dim zPSLocationListingCollection As New ViewCCLocationListingPSCollection

            zPSLocationListingQry.Select(zPSLocationListingQry.FileNo)
            zPSLocationListingQry.Where(zPSLocationListingQry.GSafeGUID = pSafeGUID)
            zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)

            SetFilterCriteriaPS(pSafeGUID, zPSLocationListingQry)

            zPSLocationListingCollection.Load(zPSLocationListingQry)
            pRecCount = zPSLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingPS In zPSLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecCountPositionPS(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zPSLocationListingQry As New ViewCCLocationListingPSQuery
            Dim zPSLocationListingCollection As New ViewCCLocationListingPSCollection

            zPSLocationListingQry.Select(zPSLocationListingQry.FileNo)
            zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zPSLocationListingCollection.Load(zPSLocationListingQry)
            pRecCount = zPSLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingPS In zPSLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub GetRecResponseCountPositionPS(ByRef pRecCount As Integer, ByRef pRecPosition As Integer, pFileNo As String)
            pRecCount = 0
            pRecPosition = 0

            Dim zFileNo As String = pFileNo
            Dim zPSLocationListingQry As New ViewCCLocationListingRecResponsePSQuery
            Dim zPSLocationListingCollection As New ViewCCLocationListingRecResponsePSCollection

            zPSLocationListingQry.Select(zPSLocationListingQry.FileNo)
            zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
            zPSLocationListingCollection.Load(zPSLocationListingQry)
            pRecCount = zPSLocationListingCollection.Count

            Dim zPosNdx As Integer = 1

            For Each zItem As ViewCCLocationListingRecResponsePS In zPSLocationListingCollection
                If zItem.FileNo = zFileNo Then
                    pRecPosition = zPosNdx
                    Exit For
                End If
                zPosNdx = zPosNdx + 1
            Next
        End Sub

        Private Sub NavigateFileNoPS(pSafeGUID As String, pDirection As String)
            Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
            Dim zPSLocationListingQry As New ViewCCLocationListingPSQuery
            Dim zPSLocationListingCollection As New ViewCCLocationListingPSCollection

            zPSLocationListingQry.Select(zPSLocationListingQry.FileNo)
            zPSLocationListingQry.Where(zPSLocationListingQry.GSafeGUID = pSafeGUID)
            zPSLocationListingQry.es.Top = 1

            Select Case pDirection
                Case "Next".ToLower
                    zPSLocationListingQry.Where(zPSLocationListingQry.FileNo > zFileNo)
                    zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Previous".ToLower
                    zPSLocationListingQry.Where(zPSLocationListingQry.FileNo < zFileNo)
                    zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
                Case "First".ToLower
                    zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Ascending)
                Case "Last".ToLower
                    zPSLocationListingQry.OrderBy(ViewCCLocationListingPSBaseMetadata.ColumnNames.FileNo, esOrderByDirection.Descending)
            End Select

            SetFilterCriteriaPS(pSafeGUID, zPSLocationListingQry)

            zPSLocationListingCollection.Load(zPSLocationListingQry)

            Dim zNewFileNo As String = ""

            If zPSLocationListingCollection.Count > 0 Then
                zNewFileNo = zPSLocationListingCollection(0).FileNo
            Else
                zNewFileNo = zFileNo
            End If

            UtilGSafe.SetLocationNavigationInformation(pSafeGUID, zNewFileNo)

        End Sub

#End Region

#Region "IViewCCLocationInspectionPSCollection"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function ViewCCLocationInspectionPSCollections(pParms As String) As jsResponse(Of ViewCCLocationInspectionPSCollection, ViewCCLocationInspectionPS)
            Dim zResponse As New jsResponse(Of ViewCCLocationInspectionPSCollection, ViewCCLocationInspectionPS)
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGUID As String = zParms(0)

            Try
                Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)
                Dim zPSLocationInspectionQry As New ViewCCLocationInspectionPSQuery
                Dim zPSLocationInspectionCollection As New ViewCCLocationInspectionPSCollection

                zPSLocationInspectionQry.SelectAll()

                If UBound(zParms) > 0 Then
                    Dim zLimit As String = zParms(1)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zPSLocationInspectionQry.es.Top = 1
                    End If
                End If

                zPSLocationInspectionQry.Where(zPSLocationInspectionQry.FileNo = zFileNo)

                zPSLocationInspectionCollection.Load(zPSLocationInspectionQry)

                If zPSLocationInspectionCollection.Count = 0 Then
                    zPSLocationInspectionCollection.AddNew() 'create a blank record when no matching records existing
                    With zPSLocationInspectionCollection(0)
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

                zResponse.collection = zPSLocationInspectionCollection

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

#End Region

    End Class

End Namespace
