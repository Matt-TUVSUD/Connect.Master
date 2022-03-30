Imports System.Web
Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilGSafe
    'Session-less Access For Everyone

    Public Shared Property QueryStringNameSID As String = "sid"

    Public Shared Function StartSafeSession(ByVal pUserId As String) As String
        'UserId values MUST be unique 
        'Look up userid in table, if exists connect to existing session else create a new one
        Dim zReturn As String = ""
        Dim zHeaderColl As New BusinessObjects.GSafeHeaderCollection
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("t1")
        Dim zHeaderObj As New BusinessObjects.GSafeHeader

        Dim zEzyLoginList As List(Of rowTblEzyLogin) = TblEzyLogin.LoadByIDX_IX_ezyLogin_EmailAddress(pUserId)
        Dim zEzyLogin As rowTblEzyLogin = Nothing
        If zEzyLoginList.Count > 0 Then zEzyLogin = zEzyLoginList(0)

        zHeaderQry.SelectAll()
        zHeaderQry.es.Top = 1
        zHeaderQry.Where(zHeaderQry.LoginName = pUserId)

        If zHeaderColl.Load(zHeaderQry) Then
            zHeaderObj = zHeaderColl(0)
        Else
            zHeaderObj.LoginName = pUserId
            zHeaderObj.Created = Date.Now()
        End If

        zHeaderObj.GSafeGUID = Guid.NewGuid.ToString.Replace("-", "")
        zHeaderObj.LastAccessed = Date.Now()
        zHeaderObj.LastUpdated = Date.Now()
        zHeaderObj.LoginID = zEzyLogin.colLoginID.Value
        zHeaderObj.Save()

        zReturn = zHeaderObj.GSafeGUID

        Return zReturn
    End Function

    Public Shared Sub ClearSafeSession(ByVal pSafeGUID As String)
        Dim zHeaderColl As New BusinessObjects.GSafeHeaderCollection
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("t1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderColl.Load(zHeaderQry) Then
            For Each zHeaderObj As BusinessObjects.GSafeHeader In zHeaderColl
                Dim zDetailColl As New BusinessObjects.GSafeDetailCollection
                Dim zDetailQry As New BusinessObjects.GSafeDetailQuery
                zDetailQry.SelectAll()
                zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)
                If zDetailColl.Load(zDetailQry) Then
                    zDetailColl.MarkAllAsDeleted()
                    zDetailColl.Save()
                End If

                Dim zFileNoColl As New BusinessObjects.GSafeFileNoCollection
                Dim zFileNoQry As New BusinessObjects.GSafeFileNoQuery
                zFileNoQry.SelectAll()
                zFileNoQry.Where(zFileNoQry.GSafeId = zHeaderObj.GSafeId)
                If zFileNoColl.Load(zFileNoQry) Then
                    zFileNoColl.MarkAllAsDeleted()
                    zFileNoColl.Save()
                End If

                Dim zFilePrefixColl As New BusinessObjects.GSafeFilePrefixCollection
                Dim zFilePrefixQry As New BusinessObjects.GSafeFilePrefixQuery
                zFilePrefixQry.SelectAll()
                zFilePrefixQry.Where(zFilePrefixQry.GSafeId = zHeaderObj.GSafeId)
                If zFilePrefixColl.Load(zFilePrefixQry) Then
                    zFilePrefixColl.MarkAllAsDeleted()
                    zFilePrefixColl.Save()
                End If
            Next
            zHeaderColl.MarkAllAsDeleted()
            zHeaderColl.Save()
        End If
    End Sub

    Public Shared Sub ClearSafeSession_ByUserId(ByVal pUserId As String)
        Dim zHeaderColl As New BusinessObjects.GSafeHeaderCollection
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("t1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.LoginName = pUserId)
        If zHeaderColl.Load(zHeaderQry) Then
            For Each zHeaderObj As BusinessObjects.GSafeHeader In zHeaderColl
                Dim zDetailColl As New BusinessObjects.GSafeDetailCollection
                Dim zDetailQry As New BusinessObjects.GSafeDetailQuery
                zDetailQry.SelectAll()
                zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)
                If zDetailColl.Load(zDetailQry) Then
                    zDetailColl.MarkAllAsDeleted()
                    zDetailColl.Save()
                End If

                Dim zFileNoColl As New BusinessObjects.GSafeFileNoCollection
                Dim zFileNoQry As New BusinessObjects.GSafeFileNoQuery
                zFileNoQry.SelectAll()
                zFileNoQry.Where(zFileNoQry.GSafeId = zHeaderObj.GSafeId)
                If zFileNoColl.Load(zFileNoQry) Then
                    zFileNoColl.MarkAllAsDeleted()
                    zFileNoColl.Save()
                End If

                Dim zFilePrefixColl As New BusinessObjects.GSafeFilePrefixCollection
                Dim zFilePrefixQry As New BusinessObjects.GSafeFilePrefixQuery
                zFilePrefixQry.SelectAll()
                zFilePrefixQry.Where(zFilePrefixQry.GSafeId = zHeaderObj.GSafeId)
                If zFilePrefixColl.Load(zFilePrefixQry) Then
                    zFilePrefixColl.MarkAllAsDeleted()
                    zFilePrefixColl.Save()
                End If
            Next
            zHeaderColl.MarkAllAsDeleted()
            zHeaderColl.Save()
        End If
    End Sub

    Public Shared Sub PurgeOldSafeSessions(ByVal pHoursOld As Integer)
        Dim zHeaderColl As New BusinessObjects.GSafeHeaderCollection
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("t1")
        Dim zRefDate As Date = DateAdd(DateInterval.Hour, -1 * pHoursOld, Now)

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.LastAccessed < pHoursOld)
        If zHeaderColl.Load(zHeaderQry) Then
            For Each zHeaderObj As BusinessObjects.GSafeHeader In zHeaderColl
                Dim zDetailColl As New BusinessObjects.GSafeDetailCollection
                Dim zDetailQry As New BusinessObjects.GSafeDetailQuery
                zDetailQry.SelectAll()
                zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)
                If zDetailColl.Load(zDetailQry) Then
                    zDetailColl.MarkAllAsDeleted()
                    zDetailColl.Save()
                End If

                Dim zFileNoColl As New BusinessObjects.GSafeFileNoCollection
                Dim zFileNoQry As New BusinessObjects.GSafeFileNoQuery
                zFileNoQry.SelectAll()
                zFileNoQry.Where(zFileNoQry.GSafeId = zHeaderObj.GSafeId)
                If zFileNoColl.Load(zFileNoQry) Then
                    zFileNoColl.MarkAllAsDeleted()
                    zFileNoColl.Save()
                End If

                Dim zFilePrefixColl As New BusinessObjects.GSafeFilePrefixCollection
                Dim zFilePrefixQry As New BusinessObjects.GSafeFilePrefixQuery
                zFilePrefixQry.SelectAll()
                zFilePrefixQry.Where(zFilePrefixQry.GSafeId = zHeaderObj.GSafeId)
                If zFilePrefixColl.Load(zFilePrefixQry) Then
                    zFilePrefixColl.MarkAllAsDeleted()
                    zFilePrefixColl.Save()
                End If
            Next
            zHeaderColl.MarkAllAsDeleted()
            zHeaderColl.Save()
        End If
    End Sub

    Public Shared Function LoadDetail_BySafeGUID(ByVal pSafeGUID As String) As BusinessObjects.GSafeDetailCollection
        'Set the lastaccessed date
        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")
        Dim zReturn As New BusinessObjects.GSafeDetailCollection

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then
            'zHeaderObj.setLastAccessed()

            Dim zDetailQry As New BusinessObjects.GSafeDetailQuery("t1")

            zDetailQry.SelectAll()
            zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)

            zReturn.Load(zDetailQry)
        End If

        Return zReturn
    End Function

    Public Shared Function loadPageIdTab_BySafeGUID(ByVal pSafeGUID As String) As BusinessObjects.GSafeDetailCollection
        Dim obj As New BusinessObjects.GSafeDetail
        Dim zReturn As New BusinessObjects.GSafeDetailCollection
        Dim CurrentPage As String = GetValue(pSafeGUID, UtilGSafe.KeyName.currentPage)
        Dim CurrentTab As String = GetValue(pSafeGUID, UtilGSafe.KeyName.currentTab)

        obj = zReturn.AddNew()
        obj.DataName = "currentPage"
        obj.DataValue = CurrentPage

        obj = zReturn.AddNew()
        obj.DataName = "currentTab"
        obj.DataValue = CurrentTab

        Return zReturn

    End Function

    Public Shared Function savePageIdTabId_BySafeGUID(ByVal parms As String) As Boolean
        Dim obj As New BusinessObjects.GSafeDetail
        Dim zReturn As New BusinessObjects.GSafeDetailCollection
        Dim parmsArray = Split(parms, "|")
        Dim zSafeGUID As String = parmsArray(0)
        Dim PageId As String = parmsArray(1)
        Dim TabId As String = parmsArray(2)
        Dim GridId As String = ""
        If Not parmsArray(3) Is Nothing Then
            GridId = parmsArray(3)
        End If

        Try
            SetValue(zSafeGUID, UtilGSafe.KeyName.currentPage, PageId, UtilGSafe.KeyNameGroup.Navigation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.currentTab, TabId, UtilGSafe.KeyNameGroup.Navigation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.currentGridId, GridId, UtilGSafe.KeyNameGroup.Navigation)
        Catch
            Return False
        End Try
        Return True

    End Function

    Public Shared Function saveUserPrefs_BySafeGUID(ByVal parms As String) As Boolean
        Dim obj As New BusinessObjects.GSafeDetail
        Dim zReturn As New BusinessObjects.GSafeDetailCollection
        Dim parmsArray = Split(parms, "|")
        Dim zSafeGUID As String = parmsArray(0)
        Dim zCurrency As String = parmsArray(1)
        Dim zCustomAccess As String = parmsArray(2)
        Dim zDivision As String = parmsArray(3)
        Dim zLocation As String = parmsArray(4)
        Dim zTIV As String = parmsArray(5)
        Dim zUnit As String = parmsArray(6)
        Dim zFilePrefix As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)

        Try
            'SetValue(zSafeGUID, "CurrencyDefaultText", zCurrency, "Preference")
            'SetValue(zSafeGUID, "CustomAccessDefaultText", zCustomAccess, "Preference")
            'SetValue(zSafeGUID, "DivisionDefaultText", zDivision, "Preference")
            'SetValue(zSafeGUID, "LocationDefaultText", zLocation, "Preference")
            'SetValue(zSafeGUID, "TIVDefaultText", zTIV, "Preference")
            'SetValue(zSafeGUID, "UnitDefaultText", zUnit, "Preference")
            If zCurrency.Length > 0 Then SetValue(zSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText, zCurrency, UtilGSafe.PreferenceKeyNameGroup.FPPref)
            If zCustomAccess.Length > 0 Then SetValue(zSafeGUID, UtilGSafe.KeyName.CustomAccessText, zCustomAccess, UtilGSafe.KeyNameGroup.Preference)
            If zDivision.Length > 0 Then SetValue(zSafeGUID, UtilGSafe.KeyName.Division, zDivision, UtilGSafe.KeyNameGroup.Preference)
            If zLocation.Length > 0 Then SetValue(zSafeGUID, UtilGSafe.KeyName.Location, zLocation, UtilGSafe.KeyNameGroup.Preference)
            If zTIV.Length > 0 Then SetValue(zSafeGUID, UtilGSafe.KeyName.TIV, zTIV, UtilGSafe.KeyNameGroup.Preference)
            If zUnit.Length > 0 Then SetValue(zSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText, zUnit, UtilGSafe.PreferenceKeyNameGroup.FPPref)
        Catch
            Return False
        End Try
        Return True

    End Function

    Public Shared Function SaveFindLocations(ByVal parms As String) As Boolean
        Dim obj As New BusinessObjects.GSafeDetail
        Dim zReturn As New BusinessObjects.GSafeDetailCollection

        ' SPLIT UP THE PARMS INTO VARIABLES
        Dim parmsArray = Split(parms, "|")
        Dim zSafeGUID As String = parmsArray(0)
        Dim zFileNo As String = parmsArray(1)
        Dim zClientLocNo As String = parmsArray(2)
        Dim zAddress1 As String = parmsArray(3)
        Dim zCity As String = parmsArray(4)
        Dim zStProv As String = parmsArray(5)
        Dim zCountry As String = parmsArray(6)
        Dim zZip As String = parmsArray(7)
        Dim zDivision As String = parmsArray(8)
        Dim zFacility As String = parmsArray(9)
        Dim zCustomAccess As String = parmsArray(10)
        Dim zLatitude As String = parmsArray(11)
        Dim zLongitude As String = parmsArray(12)
        Dim zCriteriaString As String = ""

        ' BUILD CRITERIA STRING
        If zFileNo <> "" Or _
            zClientLocNo <> "" Or _
            zAddress1 <> "" Or _
            zCity <> "" Or _
            zStProv <> "" Or _
            zCountry <> "" Or _
            zZip <> "" Or _
            zDivision <> "" Or _
            zFacility <> "" Or _
            zLatitude <> "" Or _
            zLongitude <> "" Or _
            zCustomAccess <> "" Then

            zCriteriaString = "Find on"

            If zFileNo <> "" Then
                zCriteriaString = zCriteriaString & ": File No = '" & zFileNo & "' "
            End If
            If zClientLocNo <> "" Then
                zCriteriaString = zCriteriaString & ": Client Loc No = '" & zClientLocNo & "' "
            End If
            If zAddress1 <> "" Then
                zCriteriaString = zCriteriaString & ": Address = '" & zAddress1 & "' "
            End If
            If zCity <> "" Then
                zCriteriaString = zCriteriaString & ": City = '" & zCity & "' "
            End If
            If zStProv <> "" Then
                zCriteriaString = zCriteriaString & ": State/Province = '" & zStProv & "' "
            End If
            If zCountry <> "" Then
                zCriteriaString = zCriteriaString & ": Country = '" & zCountry & "' "
            End If
            If zZip <> "" Then
                zCriteriaString = zCriteriaString & ": Postal Code = '" & zZip & "' "
            End If
            If zZip <> "" Then
                zCriteriaString = zCriteriaString & ": Postal Code = '" & zZip & "' "
            End If
            If zDivision <> "" Then
                zCriteriaString = zCriteriaString & ": Division = '" & zDivision & "' "
            End If
            If zFacility <> "" Then
                zCriteriaString = zCriteriaString & ": Facility = '" & zFacility & "' "
            End If
            If zLatitude <> "" Then
                zCriteriaString = zCriteriaString & ": Latitude = '" & zLatitude & "' "
            End If
            If zLongitude <> "" Then
                zCriteriaString = zCriteriaString & ": Longitude = '" & zLongitude & "' "
            End If
            If zCustomAccess <> "" Then
                zCriteriaString = zCriteriaString & ": Custom Access = '" & zCustomAccess & "' "
            End If
        Else
            zCriteriaString = ""
        End If

        ' SAVE THE PARMS TO THE GSAFE
        Try
            SetValue(zSafeGUID, UtilGSafe.KeyName.findFileNo, zFileNo, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findClientLocNo, zClientLocNo, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findAddress1, zAddress1, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findCity, zCity, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findStProv, zStProv, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findCountry, zCountry, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findZip, zZip, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findDivision, zDivision, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findFacility, zFacility, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findCustomAccess, zCustomAccess, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findLatitude, zLatitude, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findLongitude, zLongitude, UtilGSafe.KeyNameGroup.FindLocation)
            SetValue(zSafeGUID, UtilGSafe.KeyName.findCriteria, zCriteriaString, UtilGSafe.KeyNameGroup.FindLocation)
        Catch
            Return False
        End Try
        Return True

    End Function

    Public Shared Sub ClearDataGroup(ByVal pGSafeGuid As String, ByVal pDataGroupName As String)
        ' CLEAR ALL FIELD RECORDS IN THE GSAFE BASED ON A DATAGROUP NAME
        ' DO NOT CLEAR IF NAME IS BLANK, OR ELSE ENTIRE GSAFE WILL BE BLANK FOR ONE USER
        If pDataGroupName.Length > 0 Then
            Dim zColl As New BusinessObjects.GSafeDetailCollection
            Dim zQry As New BusinessObjects.GSafeDetailQuery
            Dim zId As Integer = UtilGSafe.GetId(pGSafeGuid)

            zQry.Select()
            zQry.Where(zQry.GSafeId = zId, zQry.DataGroup = pDataGroupName)
            If zColl.Load(zQry) Then
                For Each zObj As BusinessObjects.GSafeDetail In zColl
                    zObj.DataValue = ""
                Next
                zColl.Save()
            End If
        End If

    End Sub

    Public Shared Function LoadDetail_BySafeId(ByVal pSafeId As Integer) As BusinessObjects.GSafeDetailCollection
        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")
        Dim zReturn As New BusinessObjects.GSafeDetailCollection

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeId = pSafeId)
        If zHeaderObj.Load(zHeaderQry) Then
            'Set the lastaccessed date
            'zHeaderObj.setLastAccessed()
            'zHeaderObj.Save()

            Dim zDetailQry As New BusinessObjects.GSafeDetailQuery("t1")

            zDetailQry.SelectAll()
            zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)

            zReturn.Load(zDetailQry)
        End If

        Return zReturn
    End Function

    Public Shared Function GetEmailAddress(ByVal pSafeGUID As String) As String
        Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(GetLoginId(pSafeGUID))
        Return zLogin.colEmailAddress
    End Function

    ''' <summary>
    ''' This method clears the IsOnDetailPage, NavlinkId and FileNo values from the GSafe
    ''' </summary>
    ''' <param name="pSafeGuid"></param>
    ''' <remarks></remarks>
    Public Shared Sub ClearLocationNavigationInformation(pSafeGuid As String)
        UtilGSafe.SetValue(pSafeGuid, UtilGSafe.KeyName.IsOnDetailPage, False, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGuid, UtilGSafe.KeyName.NavLinkId, String.Empty, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGuid, UtilGSafe.KeyName.FileNo, String.Empty, UtilGSafe.KeyNameGroup.LocationSelection)
    End Sub

    ''' <summary>
    ''' This method sets the IsOnDetailPage to True and FileNo values from the GSafe
    ''' </summary>
    ''' <param name="pSafeGuid"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetLocationNavigationInformation(pSafeGuid As String, pFileNo As String)
        UtilGSafe.SetValue(pSafeGuid, UtilGSafe.KeyName.IsOnDetailPage, True, UtilGSafe.KeyNameGroup.Navigation)
        UtilGSafe.SetValue(pSafeGuid, UtilGSafe.KeyName.FileNo, pFileNo, UtilGSafe.KeyNameGroup.LocationSelection)
    End Sub



    ''' <summary>
    ''' Saves to the GSafe Details table which makes these setting temporary.
    ''' </summary>
    ''' <param name="pSafeGUID"></param>
    ''' <param name="pName"></param>
    ''' <param name="pValue"></param>
    ''' <param name="pGroup"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetValue(ByVal pSafeGUID As String, ByVal pName As String, ByVal pValue As String, pGroup As String)
        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then

            Dim zDetailObj As New BusinessObjects.GSafeDetail
            If Not zDetailObj.LoadByPrimaryKey(zHeaderObj.GSafeId, pName) Then
                zDetailObj.GSafeId = zHeaderObj.GSafeId
                zDetailObj.DataName = pName
            End If

            zDetailObj.DataValue = pValue
            zDetailObj.DataGroup = pGroup
            zDetailObj.Save()

            ''Set the lastaccessed date
            'zHeaderObj.setLastAccessed()
            'zHeaderObj.setLastUpdated()
        End If

        'Dim zHeaderObj As New BusinessObjects.GSafeHeader
        'If zHeaderObj.LoadByPrimaryKey(pSafeId) Then
        '    zHeaderObj.LastAccessed = Now
        '    zHeaderObj.LastUpdated = Now
        '    zHeaderObj.Save()
        'End If
    End Sub
    ''' <summary>
    ''' Saves to the GSafe Preferences table which makes these setting permanent or persistant storage.
    ''' </summary>
    ''' <param name="pSafeGUID"></param>
    ''' <param name="pFilePrefix"></param>
    ''' <param name="pName"></param>
    ''' <param name="pValue"></param>
    ''' <param name="pGroup"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetValue(ByVal pSafeGUID As String, ByVal pFilePrefix As String, ByVal pName As String, ByVal pValue As String, pGroup As String)
        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then

            Dim zPrefObj As New BusinessObjects.GSafePreferences
            If Not zPrefObj.LoadByPrimaryKey(zHeaderObj.GSafeId, pFilePrefix, pName) Then
                zPrefObj.GSafeId = zHeaderObj.GSafeId
                zPrefObj.FilePrefix = pFilePrefix
                zPrefObj.DataName = pName
            End If

            zPrefObj.DataValue = pValue
            zPrefObj.DataGroup = pGroup
            zPrefObj.Save()

            ''Set the lastaccessed date
            'zHeaderObj.setLastAccessed()
            'zHeaderObj.setLastUpdated()
        End If
    End Sub

    Public Shared Sub SetFilterSQL(ByVal pSafeGUID As String, ByVal pFilePrefix As String, ByVal pFilterSQL As String)
        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then

            Dim zFPF As New BusinessObjects.GSafeFilePrefixFilter
            If Not zFPF.LoadByPrimaryKey(zHeaderObj.GSafeId, pFilePrefix) Then
                zFPF.GSafeId = zHeaderObj.GSafeId
                zFPF.FilePrefix = pFilePrefix & ""
            End If

            zFPF.FilterSQL = pFilterSQL & ""
            zFPF.Save()
        End If
    End Sub

    Public Shared Function GetFilterSQL(ByVal pSafeGUID As String, ByVal pFilePrefix As String) As String
        Dim zReturn As String = ""

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then
            Dim zFPF As New BusinessObjects.GSafeFilePrefixFilter
            If zFPF.LoadByPrimaryKey(zHeaderObj.GSafeId, pFilePrefix) Then
                zReturn = zFPF.FilterSQL & ""
            End If
        End If

        Return zReturn
    End Function

    Public Shared Function GetValue(ByVal pSafeGUID As String, ByVal pName As String) As String
        Dim zReturn As String = ""

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then
            Dim zDetailObj As New BusinessObjects.GSafeDetail
            If zDetailObj.LoadByPrimaryKey(zHeaderObj.GSafeId, pName) Then
                zReturn = zDetailObj.DataValue & ""
            End If

            ''Set the lastaccessed date
            'If pName <> "EzyLoginActivityLogId" Then  'CAUSES A CIRCULAR LOOP
            '      zHeaderObj.setLastAccessed()
            'End If

        End If

        'Dim zHeaderObj As New BusinessObjects.GSafeHeader
        'If zHeaderObj.LoadByPrimaryKey(pSafeId) Then
        '    zHeaderObj.LastAccessed = Now
        '    zHeaderObj.Save()
        'End If

        Return zReturn
    End Function

    Public Shared Function GetValue(ByVal pSafeID As Integer, ByVal pName As String) As String
        Dim zSAFEGuid As String = UtilGSafe.GetGUID(pSafeID)
        Return GetValue(zSAFEGuid, pName)
    End Function


    ''' <summary>
    ''' This function returns a value from the GSafePrefences table.  
    ''' </summary>
    ''' <param name="pSafeGUID"></param>
    ''' <param name="pFilePrefix"></param>
    ''' <param name="pName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValue(ByVal pSafeGUID As String, ByVal pFilePrefix As String, ByVal pName As String) As String
        Dim zReturn As String = ""

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then
            Dim zPrefObj As New BusinessObjects.GSafePreferences
            If zPrefObj.LoadByPrimaryKey(zHeaderObj.GSafeId, pFilePrefix, pName) Then
                zReturn = zPrefObj.DataValue & ""
            End If

            ''Set the lastaccessed date
            'zHeaderObj.setLastAccessed()
        End If

        'Dim zHeaderObj As New BusinessObjects.GSafeHeader
        'If zHeaderObj.LoadByPrimaryKey(pSafeId) Then
        '    zHeaderObj.LastAccessed = Now
        '    zHeaderObj.Save()
        'End If

        Return zReturn
    End Function

    Public Shared Function GetValueFromClient(ByVal pParms As Array) As BusinessObjects.GSafeDetailCollection
        Dim obj As New BusinessObjects.GSafeDetail
        Dim zReturn As New BusinessObjects.GSafeDetailCollection
        Dim pSafeGUID As String = pParms(0)
        Dim pName As String = pParms(1)
        Dim zValue As String = GetValue(pSafeGUID, pName)

        obj = zReturn.AddNew()
        obj.DataName = pName
        obj.DataValue = zValue

        Return zReturn

    End Function

    Public Shared Function GetDataGroupFromClient(ByVal pParms As Array) As BusinessObjects.GSafeDetailCollection
        Dim obj As New BusinessObjects.GSafeDetail
        Dim zDetailsQuery As New BusinessObjects.GSafeDetailQuery
        Dim zReturn As New BusinessObjects.GSafeDetailCollection
        Dim pSafeGUID As String = pParms(0)
        Dim pGroupName As String = pParms(1)
        Dim zId = GetId(pSafeGUID)

        zDetailsQuery.SelectAll()
        zDetailsQuery.Where(zDetailsQuery.GSafeId = zId And zDetailsQuery.DataGroup = pGroupName)
        zReturn.Load(zDetailsQuery)

        Return zReturn

    End Function

    Public Shared Function GetId(ByVal pSafeGUID As String) As Integer
        Dim zReturn As Integer = 0

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.Select(zHeaderQry.GSafeId)
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderObj.Load(zHeaderQry) Then
            zReturn = zHeaderObj.GSafeId
        End If

        Return zReturn
    End Function

    Public Shared Function GetLoginId(ByVal pSafeGuid As String) As Integer
        Dim zGSafeId As Integer = GetId(pSafeGuid)
        Return GetLoginId(zGSafeId)
    End Function

    Public Shared Function GetLoginId(ByVal pGSafeId As Integer) As Integer
        Dim zReturn As Integer = 0

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.Select(zHeaderQry.LoginID)
        zHeaderQry.Where(zHeaderQry.GSafeId = pGSafeId)
        If zHeaderObj.Load(zHeaderQry) Then
            zReturn = zHeaderObj.LoginID
        End If

        Return zReturn
    End Function

    Public Shared Function GetGUIDFromQueryString() As String
        Dim zGUID As String = ""
        If Not HttpContext.Current Is Nothing Then
            If Not HttpContext.Current.Request.QueryString(UtilGSafe.QueryStringNameSID) Is Nothing Then
                zGUID = HttpContext.Current.Request.QueryString(UtilGSafe.QueryStringNameSID)
            ElseIf Not HttpContext.Current.Request.UrlReferrer Is Nothing Then
                If HttpContext.Current.Request.UrlReferrer.Query.Length > 0 Then
                    Dim zQueryString As String = HttpContext.Current.Request.UrlReferrer.Query.Replace("?", "")
                    Dim zPairs() As String = zQueryString.Split("&")
                    For Each zPair As String In zPairs
                        If zPair.Split("=")(0) = QueryStringNameSID Then
                            Return zPair.Split("=")(1)
                        End If
                    Next
                End If
            End If
        End If
        Return zGUID
    End Function

    Public Shared Function GetGUIDFromLoginID(ByVal pLoginId As Integer) As String
        Dim zReturn As String = ""

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.Select(zHeaderQry.GSafeGUID)
        zHeaderQry.Where(zHeaderQry.LoginID = pLoginId)
        If zHeaderObj.Load(zHeaderQry) Then
            zReturn = zHeaderObj.GSafeGUID
        End If

        Return zReturn
    End Function

    Public Shared Function GetGUID(ByVal pSafeId As Integer) As String
        Dim zReturn As String = ""

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.Select(zHeaderQry.GSafeGUID)
        zHeaderQry.Where(zHeaderQry.GSafeId = pSafeId)
        If zHeaderObj.Load(zHeaderQry) Then
            zReturn = zHeaderObj.GSafeGUID
        End If

        Return zReturn
    End Function

    Public Shared Function GetId_ByEmail(ByVal pUserEmail As String) As Integer
        Dim zReturn As Integer = 0

        Dim zHeaderObj As New BusinessObjects.GSafeHeader
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")

        zHeaderQry.Select(zHeaderQry.GSafeId)
        zHeaderQry.Where(zHeaderQry.LoginName = pUserEmail)
        If zHeaderObj.Load(zHeaderQry) Then
            zReturn = zHeaderObj.GSafeId
        End If

        Return zReturn
    End Function

    Public Shared Sub ClearSafeSession_ByDataGroup(ByVal pSafeGUID As String, ByVal pGroup As String)
        Dim zHeaderColl As New BusinessObjects.GSafeHeaderCollection
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("t1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderColl.Load(zHeaderQry) Then
            For Each zHeaderObj As BusinessObjects.GSafeHeader In zHeaderColl
                Dim zDetailColl As New BusinessObjects.GSafeDetailCollection
                Dim zDetailQry As New BusinessObjects.GSafeDetailQuery
                zDetailQry.SelectAll()
                zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)
                zDetailQry.Where(zDetailQry.DataGroup = pGroup)
                If zDetailColl.Load(zDetailQry) Then
                    zDetailColl.MarkAllAsDeleted()
                    zDetailColl.Save()
                End If

            Next
        End If
    End Sub

    Public Shared Sub ClearSafeSession_ByGSafeGUID(ByVal pSafeGUID As String)
        Dim zHeaderColl As New BusinessObjects.GSafeHeaderCollection
        Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("t1")

        zHeaderQry.SelectAll()
        zHeaderQry.Where(zHeaderQry.GSafeGUID = pSafeGUID)
        If zHeaderColl.Load(zHeaderQry) Then
            For Each zHeaderObj As BusinessObjects.GSafeHeader In zHeaderColl
                Dim zDetailColl As New BusinessObjects.GSafeDetailCollection
                Dim zDetailQry As New BusinessObjects.GSafeDetailQuery
                zDetailQry.SelectAll()
                zDetailQry.Where(zDetailQry.GSafeId = zHeaderObj.GSafeId)
                'zDetailQry.Where(zDetailQry.DataGroup = pGroup)
                If zDetailColl.Load(zDetailQry) Then
                    zDetailColl.MarkAllAsDeleted()
                    zDetailColl.Save()
                End If

            Next
        End If
    End Sub

    Public Shared Function IsValidLocation(pSafeGUID As String, pFileNo As String) As Boolean

        'Dim zErrLogStart As New UtilErrorLog
        'zErrLogStart.DateOccured = Now
        'zErrLogStart.ErrorType = "SAID IsNotSecure"
        'zErrLogStart.UserEmail = IIf(Not IsNothing(HttpContext.Current.Session), HttpContext.Current.Session("LoggedInUserEmail") & "", "")
        'zErrLogStart.MessageOuter = "START: pSafeGUID=" & pSafeGUID & " | pFileNo=" & pFileNo
        'zErrLogStart.CreateErrorLogRecord()

        Dim zReturn As Boolean = False

        Try

            Dim zGFNQry As New BusinessObjects.GSafeFileNoQuery("t1")
            Dim zGFNColl As New BusinessObjects.GSafeFileNoCollection
            Dim zSafeId As Integer = UtilGSafe.GetId(pSafeGUID)

            zGFNQry.SelectAll()
            zGFNQry.Where(zGFNQry.GSafeId = zSafeId)
            zGFNQry.Where(zGFNQry.FileNo = pFileNo)

            If zGFNColl.Load(zGFNQry) Then
                'Location is on the users list.
                If zGFNColl(0).FileNo = pFileNo Then
                    zReturn = True
                End If
            Else

                Dim zErrLog As New UtilErrorLog
                zErrLog.DateOccured = Now
                zErrLog.ErrorType = "SAID IsValidLocation"
                '***GRC.Connect.Ed - Replace with new function created by SB 7/30/2015
                'zErrLog.UserEmail = IIf(Not IsNothing(HttpContext.Current.Session), HttpContext.Current.Session("LoggedInUserEmail") & "", "")
                zErrLog.UserEmail = GetValue(GetGUIDFromQueryString(), KeyName.LoggedInUserEmail)
                zErrLog.MessageOuter = "GSAFE ID NOT FOUND: pSafeGUID=" & pSafeGUID & " | pFileNo=" & pFileNo & " | Return=" & zReturn.ToString()
                zErrLog.CreateErrorLogRecord()
            End If

        Catch ex As Exception

            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "SAID IsValidLocation"
            '***GRC.Connect.Ed - Replace with new function created by SB 7/30/2015
            'zErrLogError.UserEmail = IIf(Not IsNothing(HttpContext.Current.Session), HttpContext.Current.Session("LoggedInUserEmail") & "", "")
            zErrLogError.UserEmail = GetValue(GetGUIDFromQueryString(), KeyName.LoggedInUserEmail)
            zErrLogError.MessageOuter = "SAID IsValidLocation ERROR: pSafeGUID=" & pSafeGUID & " | pFileNo=" & pFileNo & " | Message: " & ex.Message
            zErrLogError.CreateErrorLogRecord()

        End Try


        'Dim zErrLog As New UtilErrorLog
        'zErrLog.DateOccured = Now
        'zErrLog.ErrorType = "SAID IsNotSecure"
        'zErrLog.UserEmail = IIf(Not IsNothing(HttpContext.Current.Session), HttpContext.Current.Session("LoggedInUserEmail") & "", "")
        'zErrLog.MessageOuter = "END: pSafeGUID=" & pSafeGUID & " | pFileNo=" & pFileNo & " | Return=" & zReturn.ToString()
        'zErrLog.CreateErrorLogRecord()

        Return zReturn
    End Function

    Public Shared Function GetCurrentPracticeEnum(ByVal pSafeGUID As String) As UtilPractice.PracticeEnum
        Select Case GetValue(pSafeGUID, KeyName.practiceName)
            Case UtilPractice.FireProgramName
                Return UtilPractice.PracticeEnum.Fire
            Case UtilPractice.BoilerProgramName
                Return UtilPractice.PracticeEnum.BM
            Case UtilPractice.InfraredProgramName
                Return UtilPractice.PracticeEnum.Infrared
            Case UtilPractice.JurisdictionalProgramName
                Return UtilPractice.PracticeEnum.Jurisdictional
            Case UtilPractice.NatHazSeismicProgramName
                Return UtilPractice.PracticeEnum.NatHazSeismic
            Case UtilPractice.NatHazWindProgramName
                Return UtilPractice.PracticeEnum.NatHazWind
            Case UtilPractice.NatHazFloodProgramName
                Return UtilPractice.PracticeEnum.NatHazFlood
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function GetCurrentPracticeString(ByVal pSafeGUID As String) As String
        Select Case GetValue(pSafeGUID, KeyName.practiceName)
            Case UtilPractice.FireProgramName
                Return "Fire"
            Case UtilPractice.BoilerProgramName
                Return "B&M"
            Case UtilPractice.InfraredProgramName
                Return "Infrared"
            Case UtilPractice.JurisdictionalProgramName
                Return "Jurisdictional"
            Case UtilPractice.NatHazSeismicProgramName
                Return "Natural Hazards Seismic"
            Case UtilPractice.NatHazWindProgramName
                Return "Natural Hazards Wind"
            Case UtilPractice.NatHazFloodProgramName
                Return "Natural Hazards Flood"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function GetGSafeLocationFilterList(pGSafeId As Integer) As List(Of rowVwGSafeLocationFilter)

        Dim zQry As New queryVwGSafeLocationFilter
        zQry.SelectAll()
        zQry.Where.Add(zQry.colGSafeId.Equals(pGSafeId))
        Dim zList As List(Of rowVwGSafeLocationFilter) = VwGSafeLocationFilter.LoadData(zQry.QueryText)

        Return zList

    End Function

    Public Shared Function BuildUserCustomAccessList(pGSafeId As Integer) As String()

        Dim zList As List(Of rowVwGSafeLocationFilter) = GetGSafeLocationFilterList(pGSafeId)
        Dim zCustomAccesses As New List(Of String)
        zList.ForEach(Sub(x) zCustomAccesses.Add(x.colCustomAccess))

        zCustomAccesses = zCustomAccesses.Distinct(StringComparer.OrdinalIgnoreCase).ToList
        zCustomAccesses = zCustomAccesses.OrderBy(Of String)(Function(x) x).ToList

        Return zCustomAccesses.ToArray

    End Function

    Public Shared Function BuildUserDivisionList(pGSafeId As Integer) As String()

        Dim zList As List(Of rowVwGSafeLocationFilter) = GetGSafeLocationFilterList(pGSafeId)
        Dim zDivisions As New List(Of String)
        zList.ForEach(Sub(x) zDivisions.Add(x.colDivision))

        zDivisions = zDivisions.Distinct(StringComparer.OrdinalIgnoreCase).ToList
        zDivisions = zDivisions.OrderBy(Of String)(Function(x) x).ToList

        Return zDivisions.ToArray

    End Function


    Public Shared Sub ClearGSafeItems(ByVal pSafeGuid As String)
        UtilGSafe.SetValue(pSafeGuid, KeyName.currentFavId, String.Empty, KeyNameGroup.Navigation)
    End Sub


    '***GRC.Connect.Ed - class to set GSafeDetail DataName (includes Session variables) 7/29/2015
    Public Class KeyName
        Public Shared Property AdminUser As String = "AdminUser"
        Public Shared Property ActualLE As String = "ActualLE"
        Public Shared Property APL As String = "APL"
        Public Shared Property ARI As String = "ARI"
        Public Shared Property AllowReclassLoginOverride As String = "AllowReclassLoginOverride"
        Public Shared Property BackURL As String = "BackURL"
        Public Shared Property BatchFilter As String = "BatchFilter"
        Public Shared Property BatchReportBatchSetId As String = "BatchReportBatchSetId"
        Public Shared Property BMRatingKey As String = "BMRatingKey"
        Public Shared Property BMRatingKeyID As String = "BMRatingKeyID"
        Public Shared Property Chart As String = "Chart"
        Public Shared Property cldbName As String = "cldbName"
        Public Shared Property clientFeatures As String = "clientFeatures"
        Public Shared Property ClientName As String = "clientName"
        Public Shared Property Column As String = "Column"
        Public Shared Property ColumnSize As String = "ColumnSize"
        Public Shared Property Currency As String = "Currency"
        Public Shared Property currentPage As String = "currentPage"
        Public Shared Property currentTab As String = "currentTab"
        Public Shared Property currentFavId As String = "currentFavId"
        Public Shared Property currentGridId As String = "currentGridId"
        Public Shared Property currentChartId As String = "currentChartId"
        Public Shared Property currentChartDrillDownId As String = "currentChartDrillDownId"
        Public Shared Property currentChartDrillBackId As String = "currentChartDrillBackId"
        Public Shared Property currentChartTargetFolder As String = "currentChartTargetFolder"
        Public Shared Property currentChartTargetPage As String = "currentChartTargetPage"
        Public Shared Property currentReportCode As String = "currentReportCode"
        Public Shared Property CustomAccess As String = "CustomAccess"
        Public Shared Property CustomAccessDefaultText As String = "CustomAccessDefaultText"
        Public Shared Property CustomAccessLabel As String = "CustomAccessLabel"
        Public Shared Property CustomAccessLabelDefault As String = "CustomAccessLabelDefault"
        Public Shared Property CustomAccessLabelOriginal As String = "CustomAccessLabelOriginal"
        Public Shared Property CustomAccessText As String = "CustomAccessText"
        Public Shared Property DefaultMetaCurrencyID As String = "DefaultMetaCurrencyID"
        Public Shared Property DataTable As String = "DataTable"
        Public Shared Property DataTableLocationsGrid As String = "DataTableLocationsGrid"
        Public Shared Property Division As String = "Division"
        Public Shared Property DivisionDefaultText As String = "DivisionDefaultText"
        Public Shared Property DivisionManager As String = "DivisionManager"
        Public Shared Property DocumentAccess As String = "DocumentAccess"
        'Public Shared Property Email As String = "Email"
        Public Shared Property EncryptedFilePreFix As String = "EncryptedFilePreFix"
        Public Shared Property ExecutedProcedures As String = "ExecutedProcedures"
        Public Shared Property ExecutionMode As String = "ExecutionMode"
        Public Shared Property ExpiredSessionPrompted As String = "ExpiredSessionPrompted"
        Public Shared Property EzyAuditLogId As String = "EzyAuditLogId"
        Public Shared Property EzyLoginActivityLogId As String = "EzyLoginActivityLogId"
        Public Shared Property EzyUserId As String = "EzyUserId"
        Public Shared Property EzyLoginId As String = "EzyLoginId"
        'Public Shared Property Favorite As String = "Favorite"
        'Public Shared Property FavoriteApplied As String = "FavoriteApplied"
        'Public Shared Property FavoriteGridName As String = "FavoriteGridName"
        Public Shared Property FileName As String = "FileName"
        Public Shared Property FileNo As String = "FileNo"

        ''' <summary>
        ''' The FileNo of the pop up window when a user clicks the map icon.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property FormFileNo As String = "FormFileNo"

        ''' <summary>
        ''' The UniqueId of the pop up window when a user clicks the magnifying glass in the grid.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property FormUniqueId As String = "FormUniqueId"


        ''' <summary>
        ''' The Report Id of the Print button on the popup form.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property FormReportId As String = "FormReportId"

        Public Shared Property FileNoFromChart As String = "FileNoFromChart"
        Public Shared Property FilePreFix As String = "FilePrefix"
        Public Shared Property Filters As String = "Filters"
        Public Shared Property FiltersFollowUp As String = "FiltersFollowUp"
        Public Shared Property FilterSQL As String = "FilterSQL"
        Public Shared Property findAddress1 As String = "findAddress1"
        Public Shared Property findCity As String = "findCity"
        Public Shared Property findClientLocNo As String = "findClientLocNo"
        Public Shared Property findCountry As String = "findCountry"
        Public Shared Property findCriteria As String = "findCriteria"
        Public Shared Property findCustomAccess As String = "findCustomAccess"
        Public Shared Property findDivision As String = "findDivision"
        Public Shared Property findFacility As String = "findFacility"
        Public Shared Property findFileNo As String = "findFileNo"
        Public Shared Property findLatitude As String = "findLatitude"
        Public Shared Property findLongitude As String = "findLongitude"
        Public Shared Property findStProv As String = "findStProv"
        Public Shared Property findZip As String = "findZip"
        Public Shared Property FireRatingKey As String = "FireRatingKey"
        Public Shared Property FireRatingKeyID As String = "FireRatingKeyID"
        Public Shared Property FollowUpDays As String = "FollowUpDays"
        Public Shared Property FollowUpURL As String = "FollowUpURL"
        Public Shared Property GenerateReportEnumValue As String = "GenerateReportEnumValue"
        Public Shared Property GRCGridColumnLists As String = "GRCGridColumnLists"
        Public Shared Property GRCGridColumns As String = "GRCGridColumns"
        Public Shared Property GridName As String = "GridName"
        Public Shared Property GridState As String = "GridState"
        Public Shared Property GSafeDataName As String = "GSafeDataName"
        Public Shared Property GSafeDataValue As String = "GSafeDataValue"
        Public Shared Property GSafeID As String = "GSafeID"
        Public Shared Property HasParameters As String = "HasParameters"
        Public Shared Property HasSort As String = "HasSort"
        Public Shared Property Hazard As String = "Hazard"
        Public Shared Property InspectionProgramYear As String = "InspectionProgramYear"
        Public Shared Property Internal As String = "Internal"
        Public Shared Property IsBatch As String = "IsBatch"
        Public Shared Property IsClientAdmin As String = "IsClientAdmin"
        Public Shared Property IsOnDetailPage As String = "IsOnDetailPage"
        Public Shared Property LastProcedureDuration As String = "LastProcedureDuration"
        Public Shared Property LastProcedureParameters As String = "LastProcedureParameters"
        Public Shared Property LastProcedureRecCount As String = "LastProcedureRecCount"
        Public Shared Property LastRecentDate As String = "LastRecentDate"
        Public Shared Property LastRecentUpdate As String = "LastRecentUpdate"
        Public Shared Property LERangeOther As String = "LERangeOther"
        Public Shared Property LinkFromEmailReferenceKey As String = "LinkFromEmailReferenceKey"
        'Public Shared Property LoadFavorite As String = "LoadFavorite"
        Public Shared Property Location As String = "Location"
        Public Shared Property LocationDefaultText As String = "LocationDefaultText"
        Public Shared Property LogFileCollection As String = "LogFileCollection"
        Public Shared Property LoggedInUserEmail As String = "LoggedInUserEmail"
        Public Shared Property LoginStrike As String = "LoginStrike"
        Public Shared Property MetaPracticeId As String = "MetaPracticeId"
        Public Shared Property MgmtResp As String = "MgmtResp"
        Public Shared Property modGrid As String = "modGrid"
        Public Shared Property modMyGrid As String = "modMyGrid"
        Public Shared Property modMyMasterChart As String = "modMyMasterChart"
        Public Shared Property modOverallRatingKey As String = "modOverallRatingKey"
        Public Shared Property myColumns As String = "myColumns"
        Public Shared Property myColumnsFollowUp As String = "myColumnsFollowUp"
        Public Shared Property myGRCGridExtractColumns As String = "myGRCGridExtractColumns"
        Public Shared Property MyPreferenceFilter As String = "MyPreferenceFilter"
        Public Shared Property MyAppEntryID As String = "MyAppEntryID"
        Public Shared Property NavLocationSelectionText As String = "NavLocationSelectionText"
        Public Shared Property NavReturnURL As String = "NavReturnURL"
        Public Shared Property NavLinkId As String = "NavLinkId"
        Public Shared Property NotAuthorizedExceptionCount As String = "NotAuthorizedExceptionCount"
        Public Shared Property Occupancy As String = "Occupancy"
        Public Shared Property PageTitle As String = "PageTitle"
        Public Shared Property Parm1 As String = "Parm1"
        Public Shared Property Parm2 As String = "Parm2"
        Public Shared Property Parm3 As String = "Parm3"
        Public Shared Property Parm4 As String = "Parm4"
        Public Shared Property Parm5 As String = "Parm5"
        Public Shared Property PasswordResetEmail As String = "PasswordResetEmail"
        Public Shared Property PasswordResetMessage As String = "PasswordResetMessage"
        Public Shared Property Plant As String = "Plant"
        Public Shared Property PlantManager As String = "PlantManager"
        Public Shared Property PML As String = "PML"
        Public Shared Property Practice As String = "Practice"
        Public Shared Property PracticeFolderName As String = "PracticeFolderName"
        Public Shared Property practiceName As String = "practiceName"
        Public Shared Property PreviousLoginDate As String = "PreviousLoginDate"
        Public Shared Property PSDivision As String = "PS-Division"
        Public Shared Property PSCustomAccess As String = "PS-CustomAccess"
        Public Shared Property PSFireLowMFL = "PS-FireLowMFL"
        Public Shared Property PSBoilerLowMFL = "PS-BoilerLowMFL"
        Public Shared Property PSFireTop5TotalScore = "PS-FireTop5TotalScore"
        Public Shared Property PSFireBottom5TotalScore = "PS-FireBottom5TotalScore"
        Public Shared Property PSBoilerTop5TotalScore = "PS-BoilerTop5TotalScore"
        Public Shared Property PSBoilerBottom5TotalScore = "PS-BoilerBottom5TotalScore"
        Public Shared Property PSCurrentDate = "PS-CurrentDate"
        Public Shared Property PSCurrentDateMinus30 = "PS-CurrentDateMinus30"
        Public Shared Property PSCurrentDateMinus60 = "PS-CurrentDateMinus60"
        Public Shared Property PSCurrentDateMinus90 = "PS-CurrentDateMinus90"
        Public Shared Property Recautofollowup As String = "Recautofollowup"
        Public Shared Property RFDivision As String = "RF-Division"
        Public Shared Property RFCustomAccess As String = "RF-CustomAccess"
        Public Shared Property RFStartDate As String = "RF-StartDate"
        Public Shared Property RFEndDate As String = "RF-EndDate"
        Public Shared Property RecCode As String = "RecCode"
        Public Shared Property Reclass_ClientReclassificationLinkGUID As String = "Reclass_ClientReclassificationLinkGUID"
        Public Shared Property RecResponse_ClientFeatures As String = "RecResponse_ClientFeatures"
        Public Shared Property RecResponse_EmailAddress As String = "RecResponse_EmailAddress"
        Public Shared Property RecResponse_FileNo As String = "RecResponse_FileNo"
        Public Shared Property RecResponse_FilePrefix As String = "RecResponse_FilePrefix"
        Public Shared Property RecResponse_FullName As String = "RecResponse_FullName"
        Public Shared Property RecResponse_LanguagePreference As String = "RecResponse_LanguagePreference"
        Public Shared Property RecResponse_PageName As String = "RecResponse_PageName"
        Public Shared Property RecResponse_PracticeName As String = "RecResponse_PracticeName"
        Public Shared Property RecResponse_RRLogGuid As String = "RecResponse_RRLogGuid"
        Public Shared Property RecResponse_RRLogId As String = "RecResponse_RRLogId"
        Public Shared Property ReportEngine As String = "ReportEngine"
        Public Shared Property ReportErrorMessage As String = "ReportErrorMessage"
        Public Shared Property ReportName As String = "ReportName"
        Public Shared Property ReportPreFilter_ConvertCurrency As String = "ReportPreFilter-ConvertCurrency"
        Public Shared Property ReportPreFilter_ConvertUnits As String = "ReportPreFilter-ConvertUnits"
        Public Shared Property ReportPreFilter_Country As String = "ReportPreFilter-Country"
        Public Shared Property ReportPreFilter_Currency As String = "ReportPreFilter-Currency"
        Public Shared Property ReportPreFilter_CustomAccess As String = "ReportPreFilter-CustomAccess"
        Public Shared Property ReportPreFilter_DateFrom As String = "ReportPreFilter-DateFrom"
        Public Shared Property ReportPreFilter_DateTo As String = "ReportPreFilter-DateTo"
        Public Shared Property ReportPreFilter_Division As String = "ReportPreFilter-Division"
        Public Shared Property ReportPreFilter_Hazard As String = "ReportPreFilter-Hazard"
        Public Shared Property ReportPreFilter_InspectionProgramYear As String = "ReportPreFilter-InspectionProgramYear"
        Public Shared Property ReportPreFilter_Status As String = "ReportPreFilter-Status"
        Public Shared Property ReportPreFilter_TIV As String = "ReportPreFilter-TIV"
        Public Shared Property ReportPreFilter_TIVValue As String = "ReportPreFilter-TIVValue"
        Public Shared Property ReportPreFilter_Units As String = "ReportPreFilter-Units"
        Public Shared Property RiskManager As String = "RiskManager"
        Public Shared Property ChartPreFilter_ConvertCurrency As String = "ChartPreFilter-ConvertCurrency"
        Public Shared Property ChartPreFilter_ConvertUnits As String = "ChartPreFilter-ConvertUnits"
        Public Shared Property ChartPreFilter_Country As String = "ChartPreFilter-Country"
        Public Shared Property ChartPreFilter_Currency As String = "ChartPreFilter-Currency"
        Public Shared Property ChartPreFilter_CustomAccess As String = "ChartPreFilter-CustomAccess"
        Public Shared Property ChartPreFilter_DateFrom As String = "ChartPreFilter-DateFrom"
        Public Shared Property ChartPreFilter_DateTo As String = "ChartPreFilter-DateTo"
        Public Shared Property ChartPreFilter_Division As String = "ChartPreFilter-Division"
        Public Shared Property ChartPreFilter_Hazard As String = "ChartPreFilter-Hazard"
        Public Shared Property ChartPreFilter_InspectionProgramYear As String = "ChartPreFilter-InspectionProgramYear"
        Public Shared Property ChartPreFilter_RecStatus As String = "ChartPreFilter-RecStatus"
        Public Shared Property ChartPreFilter_Status As String = "ChartPreFilter-Status"
        Public Shared Property ChartPreFilter_TIV As String = "ChartPreFilter-TIV"
        Public Shared Property ChartPreFilter_TIVValue As String = "ChartPreFilter-TIVValue"
        Public Shared Property ChartPreFilter_Units As String = "ChartPreFilter-Units"
        Public Shared Property ChartPreFilter_BaseUrl As String = "ChartPreFilter-BaseUrl"
        Public Shared Property ResetGrid As String = "ResetGrid"
        Public Shared Property Responses As String = "Responses"
        Public Shared Property RowCount As String = "RowCount"
        Public Shared Property RowsRange As String = "RowsRange"
        Public Shared Property RptJobId As String = "RptJobId"
        Public Shared Property RptSetId As String = "RptSetId"
        Public Shared Property SafeGUID As String = "SafeGUID"
        Public Shared Property ShowPrimTransformerSpecialFields As String = "ShowPrimTransformerSpecialFields"
        Public Shared Property SingleUser As String = "SingleUser"
        Public Shared Property SourceError As String = "SourceError"
        Public Shared Property SourceError_Message As String = "SourceError-Message"
        Public Shared Property SourceError_MessageInnerException As String = "SourceError-MessageInnerException"
        Public Shared Property SourceError_OffendingURL As String = "SourceError-OffendingURL"
        Public Shared Property SourceError_Source As String = "SourceError-Source"
        Public Shared Property SourceError_StacktraceInner As String = "SourceError-StacktraceInner"
        Public Shared Property SlideMenuType As String = "SlideMenuType"
        Public Shared Property StewardshipArray As String = "StewardshipArray"
        Public Shared Property StoredProcedure As String = "StoredProcedure"
        Public Shared Property StoredProcedureLocationsGrid As String = "StoredProcedureLocationsGrid"
        Public Shared Property TestSession As String = "TestSession"
        Public Shared Property TestSessionError As String = "TestSessionError"
        Public Shared Property TestSessionKeys As String = "TestSessionKeys"
        Public Shared Property TIV As String = "TIV"
        Public Shared Property TIVDefaultText As String = "TIVDefaultText"
        Public Shared Property TIVValue As String = "TIVValue"
        Public Shared Property TivValueChart As String = "TivValueChart"
        Public Shared Property TivValueGrid As String = "TivValueGrid"
        Public Shared Property Unit As String = "Unit"
        'Public Shared Property OverrideCurrencyId As String = "OverrideCurrencyId"
        Public Shared Property UserEmail As String = "UserEmail"
        Public Shared Property userFullName As String = "userFullName"
        Public Shared Property UserID As String = "UserId"
        Public Shared Property UserPassword As String = "UserPassword"

    End Class
    '***GRC.Connect.Ed - class to set GSafeDetail DataGroup 7/29/2015
    Public Class KeyNameGroup
        Public Shared Property Authentication As String = "Authentication"
        Public Shared Property FindLocation As String = "FindLocation"
        Public Shared Property LocationSelection As String = "LocationSelection"
        Public Shared Property Navigation As String = "Navigation"
        Public Shared Property PageHeader As String = "PageHeader"
        Public Shared Property Preference As String = "Preference"
        Public Shared Property ReportPreFilter As String = "Report PreFilter"
        Public Shared Property ChartPreFilter As String = "Chart PreFilter"
        Public Shared Property Session As String = "Session"
        Public Shared Property Switch As String = "Switch"
        Public Shared Property Test As String = "Test"
        Public Shared Property Reclassification = "Reclassification"
        Public Shared Property RecFollowUpStatus As String = "RecFollowUpStatus"
        Public Shared Property GridFormInfo As String = "GridFormInfo"
    End Class

    Public Class PreferenceKeyName
        Public Shared Property CurrencyDefaultText As String = "CurrencyDefaultText"
        Public Shared Property CurrencyPreference As String = "CurrencyPreference"
        Public Shared Property IsMyPreferenceActive As String = "IsMyPreferenceActive"
        Public Shared Property MyPreferenceFilter As String = "MyPreferenceFilter"
        Public Shared Property MyPreferenceFilterDescText As String = "MyPreferenceFilterDescText"
        Public Shared Property UnitDefaultText As String = "UnitDefaultText"
        Public Shared Property UnitPreference As String = "UnitPreference"
    End Class

    Public Class PreferenceKeyNameGroup
        Public Shared Property FPPref As String = "FilePrefix Preference"
        Public Shared Property MyPreference As String = "MyPreference"
    End Class
End Class


