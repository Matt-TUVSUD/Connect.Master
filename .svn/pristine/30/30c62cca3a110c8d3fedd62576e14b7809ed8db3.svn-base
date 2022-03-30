Public Class Filter
    Public Property Status As String = ""
    Public Property DateFrom As String = ""
    Public Property DateTo As String = ""
    Public Property Tiv As String = ""
    Public Property CustomAccess As String = ""
    Public Property Division As String = ""
    Public Property Hazard As String = ""
    Public Property Country As String = ""
    Public Property CustomAccessLabel As String = ""
    Public Property BatchFilter As String = ""
    Public Property MyPreferenceFilter As String = ""

    Public Sub New(ByVal pFilePrefix As String)
        Dim zClient As New Core.BusinessObjects.Clients
        zClient.LoadByFilePrefix(pFilePrefix)
        If zClient.CustomAccessLabel.ToUpper <> "NOT USED" Then
            CustomAccessLabel = zClient.CustomAccessLabel
        End If
    End Sub


    Public Function BuildString() As String
        'CreateFilterString
        Dim zFilterList As New List(Of String)
        Dim zFilterString As New Text.StringBuilder
        With zFilterList
            If Tiv <> "" Then .Add(GetFilterName(Core.UtilReporting.ReportFilter.TIV) & " to INCLUDE [" & Tiv & "]")
            If CustomAccess <> "" Then .Add(CustomAccessLabel & " to INCLUDE [" & CustomAccess & "]")
            If DateFrom <> "" And DateTo <> "" Then .Add("BETWEEN [" & General.ToMediumDateString(DateFrom) & "] and [" & General.ToMediumDateString(DateTo) & "]")
            If DateFrom <> "" And DateTo = "" Then .Add("BETWEEN [" & General.ToMediumDateString(DateFrom) & "] and [" & General.ToMediumDateString(Today.ToString) & "]")
            If DateFrom = "" And DateTo <> "" Then .Add("PRIOR TO [" & General.ToMediumDateString(DateTo) & "]")
            If Division <> "" Then .Add(GetFilterName(Core.UtilReporting.ReportFilter.Division) & " to INCLUDE [" & Division & "]")
            If Hazard <> "" Then .Add(GetFilterName(Core.UtilReporting.ReportFilter.Hazard) & " to INCLUDE [" & Hazard & "]")
            If Country <> "" Then .Add(GetFilterName(Core.UtilReporting.ReportFilter.Country) & " to INCLUDE [" & Country & "]")
            If Status <> "" Then .Add(GetFilterName(Core.UtilReporting.ReportFilter.Status) & " to INCLUDE [" & Status & "]")
            If BatchFilter <> "" Then .Add(BatchFilter)
        End With

        If BatchFilter = "" Then
            For Each zFilter In zFilterList
                If zFilterString.ToString = String.Empty Then
                    zFilterString.Append("on " & zFilter)
                Else
                    zFilterString.Append(" and ")
                    zFilterString.Append(zFilter)
                End If
            Next
        Else
            zFilterString.Append(BatchFilter)
        End If

        Return zFilterString.ToString

    End Function

    Private Function GetFilterName(ByVal pFilter As Core.UtilReporting.ReportFilter) As String
        Dim zQry As New Core.BusinessObjects.RERptFilterQuery
        zQry.Select(zQry.FilterName)
        zQry.Where(zQry.EnumValue = pFilter)
        Return zQry.ExecuteScalar
    End Function


End Class

'Public Class Setting
'     Public Property Currency As String = ""
'     Public Property Unit As String = ""

'     Public ReadOnly Property CurrencyEnum As Core.UtilCurrency.Currencies
'          Get
'               For Each zCur As String In [Enum].GetNames(GetType(Core.UtilCurrency.Currencies))
'                    If zCur.ToLower = Currency Then
'                         Return [Enum].Parse(GetType(Core.UtilUnit.Units), zCur)
'                    End If
'               Next

'               Return Core.UtilCurrency.Currencies.UsDollar

'          End Get
'     End Property

'     Public ReadOnly Property UnitEnum As Core.UtilUnit.Units
'          Get
'               For Each zUnit As String In [Enum].GetNames(GetType(Core.UtilUnit.Units))
'                    If zUnit.ToLower = Unit Then
'                         Return [Enum].Parse(GetType(Core.UtilUnit.Units), zUnit)
'                    End If
'               Next

'               Return Core.UtilUnit.Units.English

'          End Get
'     End Property

'End Class