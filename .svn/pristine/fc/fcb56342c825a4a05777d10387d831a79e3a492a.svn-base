'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/18/2012 4:32:58 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

    Partial Public Class Clients
        Inherits esClients

        Private _IndustryGroup As String = ""
        Private _CurrentExchangeRate As Single = 0
        Private _CurrentExchangeRateCurrency As UtilCurrency.Currencies = UtilCurrency.Currencies.UsDollar

        Public Sub New()

        End Sub

        Public Function HasPractice(ByVal pPractice As UtilPractice.PracticeEnum) As Boolean
            Return UtilPractice.HasPractice(pPractice, Me.Fileprefix)
        End Function

        Public Function GetPractices() As List(Of UtilPractice.PracticeEnum)
            Return UtilPractice.GetClientPractices(Me.Fileprefix)
        End Function

        'Public Shared Function GetCurrencyId(ByVal pFileNo As Double) As Integer
        '    Dim zObj As New ClientsQuery
        '    zObj.Select(zObj.ExchangeRateGroupID)
        '    zObj.Where(zObj.Fileprefix = Convert.ToInt32(pFileNo))
        '    Return zObj.ExecuteScalar
        'End Function

        'Public Function GetCurrencyExchangeRate(ByVal pToCurrency As UtilCurrency.Currencies) As Decimal
        '    If _CurrentExchangeRate = 0 Then
        '        _CurrentExchangeRateCurrency = pToCurrency
        '        _CurrentExchangeRate = CurrencyExchangeRate.GetRate(Me.ExchangeRateGroupID, pToCurrency)
        '    Else
        '        If pToCurrency <> _CurrentExchangeRateCurrency Then
        '            _CurrentExchangeRate = 0
        '            GetCurrencyExchangeRate(pToCurrency)
        '        End If
        '    End If
        '    Return _CurrentExchangeRate
        'End Function

        Public Function LoadByFilePrefix(pFilePrefix As String) As Boolean
            Dim zClientQry As New BusinessObjects.ClientsQuery("t1")
            zClientQry.SelectAll()
            zClientQry.Where(zClientQry.Fileprefix = pFilePrefix)
            zClientQry.es.Top = 1
            If Me.Load(zClientQry) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function HasCustomAplFactor() As Boolean
            Dim zApl As New Aplfactorkey
            Return zApl.LoadByPrimaryKey(Me.Fileprefix)
        End Function

        Public Function GetFireFacilityScoreAverage() As Single

            Throw New NotImplementedException("Not Implemented")

            'Dim zQry As New ViewCCReportFireRatingCurrentQuery
            'zQry.Select(zQry.TotalScore.Avg)
            'zQry.Where(zQry.FilePrefix = Me.Fileprefix)

            'Dim zReturn As Object = zQry.ExecuteScalar
            'If IsDBNull(zReturn) Then
            '    Return 0
            'Else
            '    Return zReturn
            'End If

        End Function

        Public Function GetFireFacilityScoreGRCAverage() As Single
            Throw New NotImplementedException("Not Implemented")

            'Dim zQry As New ViewCCReportFireRatingCurrentQuery
            'zQry.Select(zQry.TotalScore.Avg)

            'Dim zReturn As Object = zQry.ExecuteScalar
            'If IsDBNull(zReturn) Then
            '    Return 0
            'Else
            '    Return zReturn
            'End If

        End Function

        Public Function GetFireIndustryGroupAverage() As Single

            Throw New NotImplementedException("Not Implemented")

            'Dim zIndustryGroup As String = GetIndustryGroup()
            'If zIndustryGroup <> "Not Specified" Then
            '    Dim zQry As New ViewCCReportFireRatingCurrentQuery("Rating")
            '    Dim zQry1 As New CopeFireOccupancyQuery("occup")
            '    zQry.Select(zQry.TotalScore.Avg)
            '    'zQry.InnerJoin(zQry1).On(zQry.FilePrefix = zQry.FilePrefix)
            '    zQry.Where(zQry.FileNo.In(zQry1.Select(zQry1.FileNo).Where(zQry1.IndustryGroup.ToLower = zIndustryGroup.ToLower)))
            '    Return zQry.ExecuteScalar
            'Else
            '    Return 0
            'End If

        End Function

        Public Function GetBMFacilityScoreAverage() As Single
            Throw New NotImplementedException("Not Implemented")

            'Dim zQry As New ViewCCReportBoilerRatingCurrentQuery
            'zQry.Select(zQry.TotalScoreCurrent.Avg)
            'zQry.Where(zQry.FilePrefix = Me.Fileprefix)

            'Dim zReturn As Object = zQry.ExecuteScalar
            'If IsDBNull(zReturn) Then
            '    Return 0
            'Else
            '    Return zReturn
            'End If

        End Function

        Public Function GetBMFacilityScoreGRCAverage() As Single
            Throw New NotImplementedException("Not Implemented")

            'Dim zQry As New ViewCCReportBoilerRatingCurrentQuery
            'zQry.Select(zQry.TotalScoreCurrent.Avg)

            'Dim zReturn As Object = zQry.ExecuteScalar
            'If IsDBNull(zReturn) Then
            '    Return 0
            'Else
            '    Return zReturn
            'End If

        End Function

        Public Function GetBMIndustryGroupAverage() As Single
            Throw New NotImplementedException("Not Implemented")

            'Dim zIndustryGroup As String = GetIndustryGroup()
            'If zIndustryGroup <> "Not Specified" Then
            '    Dim zQry As New ViewCCReportBoilerRatingCurrentQuery("Rating")
            '    Dim zQry1 As New CopeFireOccupancyQuery("occup")
            '    zQry.Select(zQry.TotalScoreCurrent.Avg)
            '    'zQry.InnerJoin(zQry1).On(zQry.FilePrefix = zQry.FilePrefix)
            '    zQry.Where(zQry.FileNo.In(zQry1.Select(zQry1.FileNo).Where(zQry1.IndustryGroup.ToLower = zIndustryGroup.ToLower)))
            '    Return zQry.ExecuteScalar
            'Else
            '    Return 0
            'End If

        End Function

        Public Function GetIndustryGroup() As String
            'Because this function uses a stored procedure to get its value, the value returned is saved in a private variable for reuse should this function be called subsequent times.

            If _IndustryGroup = "" Then
                Dim zIndustryGroup As String = ""
                Dim zFilePrefix As String = ""

                If Len(Me.Fileprefix) = 1 Then zFilePrefix = "000" & Me.Fileprefix
                If Len(Me.Fileprefix) = 2 Then zFilePrefix = "00" & Me.Fileprefix
                If Len(Me.Fileprefix) = 3 Then zFilePrefix = "0" & Me.Fileprefix
                If Len(Me.Fileprefix) = 4 Then zFilePrefix = Me.Fileprefix

                zIndustryGroup = UtilDB.ExecuteProcedure("spGetIndustryGroupNameFromAMR '" & zFilePrefix & "'")
                If zIndustryGroup = "" Then
                    _IndustryGroup = "Not Specified"
                Else
                    _IndustryGroup = zIndustryGroup
                End If
            End If

            Return _IndustryGroup

        End Function

        'Public Function GetFireRatingLabels() As List(Of String)
        '    Dim zList As New List(Of String)
        '    Dim zRatingKey As New RatingKey
        '    zRatingKey.LoadByPrimaryKey(Me.FireRatingKeyID)
        '    If Not String.IsNullOrEmpty(zRatingKey.Rating1) Then zList.Add(zRatingKey.Rating1)
        '    If Not String.IsNullOrEmpty(zRatingKey.Rating2) Then zList.Add(zRatingKey.Rating2)
        '    If Not String.IsNullOrEmpty(zRatingKey.Rating3) Then zList.Add(zRatingKey.Rating3)
        '    If Not String.IsNullOrEmpty(zRatingKey.Rating4) Then zList.Add(zRatingKey.Rating4)
        '    If Not String.IsNullOrEmpty(zRatingKey.Rating5) Then zList.Add(zRatingKey.Rating5)
        '    Return zList
        'End Function

        'Public Function GetFireRatingItems() As BusinessObjects.RatingKey.RatingKeyItemCollection
        '    Dim zList As New List(Of RatingKey)
        '    Dim zRatingKey As New RatingKey
        '    zRatingKey.LoadByPrimaryKey(Me.FireRatingKeyID)
        '    Return zRatingKey.ItemCollection
        'End Function

        'Public Function GetBMRatingItems() As BusinessObjects.RatingKey.RatingKeyItemCollection
        '    Dim zList As New List(Of RatingKey)
        '    Dim zRatingKey As New RatingKey
        '    zRatingKey.LoadByPrimaryKey(Me.BMRatingKeyID)
        '    Return zRatingKey.ItemCollection
        'End Function

        Public Function GetAplFactor(ByVal pApl As Double) As Single
            Dim zApl As New Aplfactorkey
            If HasCustomAplFactor() Then
                zApl.LoadByPrimaryKey(Me.Fileprefix)
            Else
                zApl.LoadByPrimaryKey(0)
            End If

            Select Case Int(pApl)
                Case 0 To zApl.Range1
                    Return zApl.Factor1
                Case Is < zApl.Range2
                    Return zApl.Factor2
                Case Is < zApl.Range3
                    Return zApl.Factor3
                Case Is > zApl.Range4
                    Return zApl.Factor4
            End Select

            Return 0

        End Function

        Public Shared Function IsAutoRecEnabled(ByVal pFilePrefix As String) As Boolean
            Dim zQry As New Clients
            If zQry.LoadByFilePrefix(pFilePrefix) Then
                Return zQry.Recautofollowup
            Else
                Return False
            End If

        End Function

        Public Function GetActiveExternalUsers() As EzyUsersCollection
            Dim zUserCol As New EzyUsersCollection
            Dim zUserQry As New EzyUsersQuery
            zUserQry.SelectAll()
            zUserQry.Where(zUserQry.ActiveUser = True)
            zUserQry.Where(zUserQry.FilePrefix = Me.Fileprefix)
            zUserQry.Where(zUserQry.Internal = False)
            zUserCol.Load(zUserQry)
            Return zUserCol
        End Function

        'Public Sub RunSecurityProfile()         
        '    If Not IsNothing(Me.Features) Then
        '        If Features.ToLower.Contains("u") Then
        '            Trace.WriteLine(Me.Clientname)
        '            Trace.WriteLine(New String("-", 50))
        '            Dim zUsers As EzyUsersCollection = GetActiveExternalUsers()
        '            For Each zUser As EzyUsers In zUsers
        '                If zUser.FullName <> "" Then
        '                    Trace.Write(zUser.FullName & " - ")
        '                    Trace.WriteIf(zUser.Manage.NeedToChangePassword(), "Password will be expired.")
        '                    Trace.WriteIf(zUser.Manage.NeedLockoutEmail(), " Account will be locked out and a email will be sent.")
        '                    Trace.WriteIf(zUser.Manage.NeedLockoutEmail() = False And zUser.Manage.NeedLockoutReminderEmail = True, " Inactivity reminder email will be sent.")
        '                    Trace.WriteLine("")
        '                End If
        '            Next
        '        End If
        '    End If

        'End Sub

    End Class

End Namespace
