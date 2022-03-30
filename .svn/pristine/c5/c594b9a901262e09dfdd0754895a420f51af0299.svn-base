Imports System
Imports System.Globalization
Imports Microsoft.VisualBasic

Public Class UtilTime

    Public Function TimezoneToUTC(ByVal pDateValue As DateTime, ByVal pTimezone As String) As DateTime
        'Convert a named timezone time to UTC
        Dim zRemoteTime As New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, pDateValue.Hour, pDateValue.Minute, pDateValue.Second)
        Dim zRemoteZoneId As String = pTimezone  '"Pacific Standard Time"
        Dim zReturn As DateTime = Now

        Try
            Dim zRemoteZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(zRemoteZoneId)
            zReturn = TimeZoneInfo.ConvertTimeToUtc(zRemoteTime, zRemoteZone)
        Catch e As TimeZoneNotFoundException
            Diagnostics.Debug.Print("Unable to find the {0} zone in the registry.", zRemoteZoneId)
        Catch e As InvalidTimeZoneException
            Diagnostics.Debug.Print("Registry data on the {0} zone has been corrupted.", zRemoteZoneId)
        End Try

        Return zReturn
    End Function

    Public Function UTCToTimezone(ByVal pDateValue As DateTime, ByVal pTimezone As String) As DateTime
        'Convert UTC to a named timezone time 
        Dim zUTCTime As New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, pDateValue.Hour, pDateValue.Minute, pDateValue.Second)
        Dim zRemoteZoneId As String = pTimeZone  '"Pacific Standard Time"
        Dim zReturn As DateTime = Now

        Try
            Dim zRemoteZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(zRemoteZoneId)
            zReturn = TimeZoneInfo.ConvertTimeFromUtc(zUTCTime, zRemoteZone)
        Catch e As TimeZoneNotFoundException
            Diagnostics.Debug.Print("Unable to find the {0} zone in the registry.", zRemoteZoneId)
        Catch e As InvalidTimeZoneException
            Diagnostics.Debug.Print("Registry data on the {0} zone has been corrupted.", zRemoteZoneId)
        End Try

        Return zReturn
    End Function

    'Public Function ServerToUTC(ByVal pDateValue As DateTime, Optional pHemisphere As String = "") As DateTime
    Public Function ServerToUTC(ByVal pDateValue As DateTime, pHemisphere As String) As DateTime

        'Convert the server time to UTC
        'Dim zServerTime As New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, pDateValue.Hour, pDateValue.Minute, pDateValue.Second)
        Dim zServerTime As Date
        Select Case pHemisphere.ToLower()
            Case "west" 'NEED TO FORCE THE ORIGINAL DAY TO BE RETURNED BY OFFSETTING HOURS
                zServerTime = New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, "12", "00", "00")
            Case "east"
                zServerTime = New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, "00", "00", "00")
            Case Else
                zServerTime = New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, pDateValue.Hour, pDateValue.Minute, pDateValue.Second)
        End Select
        Dim zUTCTime As DateTimeOffset
        Dim zReturn As DateTime = Now

        zUTCTime = zServerTime.ToUniversalTime
        zReturn = zUTCTime.DateTime

        Return zReturn
    End Function

    Public Function UTCToServer(ByVal pDateValue As DateTime) As DateTime
        'Convert the server time to UTC
        Dim zUTCTime As New Date(pDateValue.Year, pDateValue.Month, pDateValue.Day, pDateValue.Hour, pDateValue.Minute, pDateValue.Second)
        Dim zServerTime As DateTimeOffset
        Dim zReturn As DateTime = Now

        zServerTime = zUTCTime.ToLocalTime
        zReturn = zServerTime.DateTime

        Return zReturn
    End Function

End Class
