Imports GRC.Connect.Libraries.DataLib.razor

''' <summary>
''' This class contains the base AutoRec data used to run daily and monthly follow-ups
''' </summary>
''' <remarks></remarks>
Public Class AutoRecData

    Public LocationDict As Dictionary(Of String, rowVwAllLocations)
    Public TemplateDict As Dictionary(Of Integer, rowTblEmailTemplate)
    Public ClientDict As Dictionary(Of String, rowVwRRClients)
    Public LastInspDict As Dictionary(Of String, rowVwLastInspectionDate)
    Public RRLogDict As Dictionary(Of Integer, rowTblRRLog)
    Public UsersDict As Dictionary(Of Integer, rowTblEzyUsers)
    Public ARProcessDict As Dictionary(Of Integer, rowtblMetaAutoRecProcess)
    Public Shared MetaPracticesDict As Dictionary(Of Integer, rowTblMetaPractice)

    Public Sub New()
        Trace.Write("Loading VwAllLocations...")
        LocationDict = VwAllLocations.LoadData.ToDictionary(Function(x) x.colFileNo)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading TblEmailTemplate...")
        TemplateDict = TblEmailTemplate.LoadData.FindAll(Function(x) x.colFldTypeId IsNot Nothing).ToDictionary(Function(x) x.colFldId.Value)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading VwRRClients...")
        ClientDict = VwRRClients.LoadData.ToDictionary(Function(x) x.colFileprefix)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading VwLastInspectionDate...")
        LastInspDict = VwLastInspectionDate.LoadData.ToDictionary(Function(x) x.colId)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading TblEzyUsers...")
        UsersDict = TblEzyUsers.LoadData.ToDictionary(Function(x) x.colEzyUserID.Value)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading TblRRLog...")
        RRLogDict = TblRRLog.LoadData.ToDictionary(Function(x) x.colId.Value)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading TblMetaAutoRecProcess...")
        ARProcessDict = TblMetaAutoRecProcess.LoadData.ToDictionary(Function(x) x.colFldId.Value)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading TblMetaPractices...")
        MetaPracticesDict = TblMetaPractice.LoadData.ToDictionary(Function(x) x.colFldId.Value)
        Trace.WriteLine("Loaded")

    End Sub

    Public Function FindRRLog(pID As Integer) As rowTblRRLog
        Return RRLogDict(pID)
    End Function

    Public Function FindRRLog(pFileNo As String, pPractice As TblMetaPractice.Practices) As rowTblRRLog
        Dim zReturn As rowTblRRLog = Nothing

        Select Case pPractice
            Case TblMetaPractice.Practices.BM
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And (x.colPracticeCode = 510 Or x.colPracticeCode = 515))
            Case TblMetaPractice.Practices.Fire
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And (x.colPracticeCode = 520 Or x.colPracticeCode = 525))
            Case TblMetaPractice.Practices.Infrared
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And (x.colPracticeCode = 530 Or x.colPracticeCode = 535))
            Case TblMetaPractice.Practices.NatHazFlood
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And x.colHazard = "Flood" And x.colPracticeCode = 526)
            Case TblMetaPractice.Practices.NatHazSeismic
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And x.colHazard = "Seismic" And x.colPracticeCode = 526)
            Case TblMetaPractice.Practices.NatHazWind
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And x.colHazard = "Wind" And x.colPracticeCode = 526)
            Case TblMetaPractice.Practices.NaturalHazards
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And (x.colPracticeCode = 550 Or x.colPracticeCode = 555))
            Case TblMetaPractice.Practices.ProcessSafety
                zReturn = RRLogDict.Values.ToList().Find(Function(x) x.colFileNo = pFileNo And (x.colPracticeCode = 570 Or x.colPracticeCode = 575))
        End Select

        Return zReturn

    End Function

    Public Function FindLocation(pFileNo As String) As rowVwAllLocations
        If LocationDict.TryGetValue(pFileNo, Nothing) Then
            Return LocationDict(pFileNo)
        Else
            Dim zEx As New FileNotInWorkloadException(pFileNo)
            Throw zEx
        End If
    End Function

    Public Function FindClientByFileNo(pFileNo As String) As rowVwRRClients
        Return ClientDict.Values.ToList.Find(Function(x) x.colFileprefix.StartsWith(pFileNo & ".%"))
    End Function

    Public Function FindClientByFilePrefix(pFilePrefix As String) As rowVwRRClients
        Dim zRRClient As rowVwRRClients = Nothing
        ClientDict.TryGetValue(pFilePrefix, zRRClient)
        Return zRRClient
    End Function

    Public Function FindTemplate(pFilePrefix As String, pARProcessType As UtilAutoRec.ProcessType) As UtilAutoRec.Template

        Dim zAREmailTemplateTypeId As Integer = ARProcessDict(pARProcessType).colFldEmailTemplateTypeId
        Dim zEmailTemplate As rowTblEmailTemplate = TemplateDict.Values.ToList.Find(Function(x) x.colFldFilePrefix = pFilePrefix And x.colFldTypeId.Value = zAREmailTemplateTypeId)

        'THIS CODE IS HERE TO BREAK ANY REFERENCE TO THE ITEM IN THE LIST- DO NOT REMOVE
        'REMOVING THIS CODE WILL CAUSE ANY CHANGES MADE TO THE TEMPLATE TO BE REFLECTED BACK IN THE LIST.
        Dim zSerialized As String = Newtonsoft.Json.JsonConvert.SerializeObject(zEmailTemplate)
        zEmailTemplate = Newtonsoft.Json.JsonConvert.DeserializeObject(Of rowTblEmailTemplate)(zSerialized)

        If Not IsNothing(zEmailTemplate) Then
            Dim zTemplate As New UtilAutoRec.Template
            zTemplate.Template = zEmailTemplate
            zTemplate.ARProcessType = pARProcessType
            Return zTemplate
        Else
            Return FindTemplate("0", pARProcessType)
        End If
    End Function

    Public Function FindLastInspectionDate(pPractice As TblMetaPractice.Practices, pFileNo As String) As DateTime
        Dim zID As String = pPractice & ":" & pFileNo
        Dim zLastInsp As rowVwLastInspectionDate = LastInspDict.Values.ToList.Find(Function(x) x.colId = zID)
        If zLastInsp IsNot Nothing Then
            Return zLastInsp.colLastInspectionDate
        Else
            Return Date.MinValue
        End If
    End Function

    Public Function FindUsersByFilePrefix(pFilePrefix As String) As List(Of rowTblEzyUsers)
        Return UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix)
    End Function

    ''' <summary>
    ''' Returns client users only based on the filter.  GRC Administrators are filtered out.
    ''' </summary>
    ''' <param name="pFilePrefix"></param>
    ''' <param name="pUserFilter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FindClientUsersByFilter(pFilePrefix As String, pUserFilter As UtilAutoRec.UserFilter) As List(Of rowTblEzyUsers)
        Dim zList As New List(Of rowTblEzyUsers)

        Select Case pUserFilter.Filter

            Case UtilAutoRec.EzUserManagerType.RiskManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colRiskManager = True And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.CityManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colCityManager = True And x.colCityText = pUserFilter.City And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.ClientLocNoManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colClientLocNoManager = True And x.colClientLocNoText = pUserFilter.ClientLocNo And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.CountryManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colCountryManager = True And x.colCountryText = pUserFilter.Country And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.CustomAccessManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colCustomAccess = True And x.colCustomAccessText = pUserFilter.CustomAccess And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.DivisionManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colDivisionManager = True And x.colDivision = pUserFilter.Division And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.FacilityManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colFacilityManager = True And x.colFacilityText = pUserFilter.Facility And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.PlantManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colPlantManager = True And x.colPlant = pUserFilter.Plant And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

            Case UtilAutoRec.EzUserManagerType.StProvManager
                zList = UsersDict.Values.ToList.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colStProvManager = True And x.colStProvText = pUserFilter.StProv And x.colActiveUser = True And String.IsNullOrEmpty(Trim(x.colGRCAdministrator)))

        End Select

        Return zList

    End Function

    Public Function FindDivisionsByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colDivision) Then zList.Add(x.colDivision))
        zList = zList.Distinct.ToList()
        Return zList
    End Function

    Public Function FindCustomAccessesByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colCustomAccessText) Then zList.Add(x.colCustomAccessText))
        zList = zList.Distinct.ToList()
        Return zList
    End Function

    Public Function FindClientLocNoByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colClientLocNoText) Then zList.Add(x.colClientLocNoText))
        zList = zList.Distinct.ToList()
        Return zList
    End Function

    Public Function FindFacilityByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colFacilityText) Then zList.Add(x.colFacilityText))
        zList = zList.Distinct.ToList()
        Return zList
    End Function

    Public Function FindCityByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colCityText) Then zList.Add(x.colCityText))
        zList = zList.Distinct.ToList()
        Return zList
    End Function

    Public Function FindStProvByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colStProvText) Then zList.Add(x.colStProvText))
        zList = zList.Distinct.ToList()
        Return zList
    End Function

    Public Function FindCountryByFilePrefix(pFilePrefix As String) As List(Of String)
        Dim zUsers As List(Of rowTblEzyUsers) = FindUsersByFilePrefix(pFilePrefix)
        Dim zList As New List(Of String)
        zUsers.ForEach(Sub(x) If Not String.IsNullOrEmpty(x.colCountryText) Then zList.Add(x.colCountryText))
        zList = zList.Distinct.ToList()
        Return zList
    End Function


End Class

Public Class FollowUpAutoRecData
    Inherits AutoRecData
    Public FollowUpDict As Dictionary(Of String, rowVwRRLogFollowUp)
    Public FollowUpRecStatusDates As List(Of rowVwRRLogFollowUpRecStatusDate)

    Public Sub New()
        MyBase.New()

        Trace.Write("Loading VwRRLogFollowUp...")
        FollowUpDict = VwRRLogFollowUp.LoadData.ToDictionary(Function(x) x.colId)
        Trace.WriteLine("Loaded")

        Trace.Write("Loading VwRRLogFollowUpRecStatusDate...")
        FollowUpRecStatusDates = VwRRLogFollowUpRecStatusDate.LoadData()
        Trace.WriteLine("Loaded")

   End Sub

    Public Function FindFollowUps(pARProcessType As UtilAutoRec.ProcessType, pClient As rowVwRRClients) As List(Of rowVwRRLogFollowUp)
        Dim zClient As rowVwRRClients = pClient
        Dim zFollowUpDays As Integer = 0

        Select Case pARProcessType

            Case UtilAutoRec.ProcessType.FollowUp1st, UtilAutoRec.ProcessType.FollowUp2nd, UtilAutoRec.ProcessType.FollowUp3rd, UtilAutoRec.ProcessType.Overdue1st, UtilAutoRec.ProcessType.Overdue2nd, UtilAutoRec.ProcessType.Overdue3rd
                Select Case pARProcessType
                    Case UtilAutoRec.ProcessType.FollowUp1st, UtilAutoRec.ProcessType.Overdue1st
                        zFollowUpDays = pClient.colRecfollowup1
                        Return FollowUpDict.Values.ToList.FindAll(Function(x) x.colDaysSinceDateStamp >= zFollowUpDays And x.colFollowUp = 2 And x.colFileNo.StartsWith(pClient.colFileprefix & "."))

                    Case UtilAutoRec.ProcessType.FollowUp2nd, UtilAutoRec.ProcessType.Overdue2nd
                        zFollowUpDays = pClient.colRecfollowup2
                        Return FollowUpDict.Values.ToList.FindAll(Function(x) x.colDaysSinceDateStamp >= zFollowUpDays And x.colFollowUp = 3 And x.colFileNo.StartsWith(pClient.colFileprefix & "."))

                    Case UtilAutoRec.ProcessType.FollowUp3rd, UtilAutoRec.ProcessType.Overdue3rd
                        zFollowUpDays = pClient.colRecfollowup3
                        Return FollowUpDict.Values.ToList.FindAll(Function(x) x.colDaysSinceDateStamp >= zFollowUpDays And x.colFollowUp = 4 And x.colFileNo.StartsWith(pClient.colFileprefix & "."))
                End Select

            Case Else

        End Select

        Return Nothing
    End Function

End Class

Public Class AutoRequestAutoRecData
    Inherits AutoRecData
    Public AutoRequestList As List(Of rowVwRRAutoRequest)
    Public AutoRequestEEECD As List(Of rowVwRRExpiringExpiredExpectedCompletedDate)

    Public Sub New()
        MyBase.New()

        Trace.Write("Loading VwRRAutoRequest...")
        AutoRequestList = VwRRAutoRequest.LoadData
        Trace.WriteLine("Loaded")

        Trace.Write("Loading VwRRExpiringExpiredExpectedCompletedDate...")
        AutoRequestEEECD = VwRRExpiringExpiredExpectedCompletedDate.LoadData
        Trace.WriteLine("Loaded")

    End Sub

    ''' <summary>
    ''' Determines if this client has overdue items (overdue followups or overdue expected completion dates) that need processing
    ''' </summary>
    ''' <param name="pARProcessType"></param>
    ''' <param name="pPractice"></param>
    ''' <param name="pFilePrefix"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NeedsProcessing(pARProcessType As UtilAutoRec.ProcessType, pPractice As TblMetaPractice.Practices, pFilePrefix As String, pUserFilter As UtilAutoRec.UserFilter) As Boolean

        Select Case pARProcessType
            Case UtilAutoRec.ProcessType.ExpiredOverdue
                Return NeedsAutoRequestOverdueCompletionFollowUp(pPractice, pFilePrefix, pUserFilter)

            Case UtilAutoRec.ProcessType.Overdue1st, UtilAutoRec.ProcessType.Overdue2nd, UtilAutoRec.ProcessType.Overdue3rd
                Return NeedsAutoRequestFollowUp(pARProcessType, pPractice, pFilePrefix, pUserFilter)

            Case UtilAutoRec.ProcessType.ExpiringExpectedCompletionDate
                Return NeedsAutoRequestExpiringCompletionDateAlert(pPractice, pFilePrefix)

            Case Else
                Throw New ArgumentException("Invalid autorequest process type.", "pARProcessType")
        End Select
    End Function

    Private Function NeedsAutoRequestFollowUp(pARProcessType As UtilAutoRec.ProcessType, pPractice As TblMetaPractice.Practices, pFilePrefix As String, pUserFilter As UtilAutoRec.UserFilter) As Boolean

        Dim zFiltered As List(Of rowVwRRAutoRequest) = Nothing
        Dim zAutoRequestFilterString As String = ""

        Select Case pARProcessType
            Case UtilAutoRec.ProcessType.Overdue1st
                zAutoRequestFilterString = GetAutoRequestFilterString(UtilAutoRec.AutoRequest.FirstFollowUp)

            Case UtilAutoRec.ProcessType.Overdue2nd
                zAutoRequestFilterString = GetAutoRequestFilterString(UtilAutoRec.AutoRequest.SecondFollowUp)

            Case UtilAutoRec.ProcessType.Overdue3rd
                zAutoRequestFilterString = GetAutoRequestFilterString(UtilAutoRec.AutoRequest.ThirdFollowUp)
        End Select

        'FIND ALL OBJECT THAT MEET FILTER CRITERIA
        zFiltered = AutoRequestList.FindAll(Function(x) x.colFilePrefix = pFilePrefix _
                                                 And x.colPracticeId = pPractice _
                                                 And x.colDivision Like pUserFilter.Division _
                                                 And x.colCustomAccess Like pUserFilter.CustomAccess _
                                                 And x.colClientLocNo Like pUserFilter.ClientLocNo _
                                                 And x.colFacility Like pUserFilter.Facility _
                                                 And x.colCity Like pUserFilter.City _
                                                 And x.colStProv Like pUserFilter.StProv _
                                                 And x.colCountry Like pUserFilter.Country _
                                                 And x.colAutoRequest = zAutoRequestFilterString)

        Return CBool(zFiltered.Count)

    End Function

    Private Function NeedsAutoRequestOverdueCompletionFollowUp(pPractice As TblMetaPractice.Practices, pFilePrefix As String, pUserFilter As UtilAutoRec.UserFilter) As Boolean

        Dim zFiltered As List(Of rowVwRRExpiringExpiredExpectedCompletedDate) = _
            AutoRequestEEECD.FindAll(Function(x) x.colFilePrefix = pFilePrefix _
                    And x.colPracticeId = pPractice _
                    And x.colDivision Like pUserFilter.Division _
                    And x.colCustomAccess Like pUserFilter.CustomAccess _
                    And x.colClientLocNo Like pUserFilter.ClientLocNo _
                    And x.colFacility Like pUserFilter.Facility _
                    And x.colCity Like pUserFilter.City _
                    And x.colStProv Like pUserFilter.StProv _
                    And x.colCountry Like pUserFilter.Country
                                        )
        Return CBool(zFiltered.Count)
    End Function

    Private Function NeedsAutoRequestExpiringCompletionDateAlert(pPractice As TblMetaPractice.Practices, pFilePrefix As String) As Boolean
        Dim zFilteredList As List(Of rowVwRRExpiringExpiredExpectedCompletedDate) = AutoRequestEEECD.FindAll(Function(x) x.colFilePrefix = pFilePrefix And x.colPracticeId = pPractice)
        Return CBool(zFilteredList.Count)
    End Function

    Private Function GetAutoRequestFilterString(pAutoRequest As UtilAutoRec.AutoRequest) As String

        Select Case pAutoRequest
            Case UtilAutoRec.AutoRequest.FirstFollowUp
                Return "1st Follow-Up"

            Case UtilAutoRec.AutoRequest.SecondFollowUp
                Return "2nd Follow-Up"

            Case UtilAutoRec.AutoRequest.ThirdFollowUp
                Return "3rd Follow-Up"

        End Select

        Return ""

    End Function


End Class