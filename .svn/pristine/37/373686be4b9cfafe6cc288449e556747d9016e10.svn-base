Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilReporting

    Public Shared Function ReportHasParameters(pMetaReportId As Integer) As Boolean
        Dim zMeta As New UtilMeta
        Dim zPreFilters As List(Of rowVwMetaReportPrefilters) = zMeta.GetPreFiltersReports(CInt(pMetaReportId))
        If zPreFilters.Count > 0 Then Return True Else Return False
    End Function

    Public Enum ReportFilter
        FileNo = 4
        FilePrefix = 12
        Country = 13
        Division = 14
        CustomAccess = 15
        Language = 16
        ImpairmentStartDate = 17 'CHANGED NAME DateFrom
        ImpairmentEndDate = 18 'CHANGED NAME DateTo
        InspectionProgramYear = 19
        TIV = 20
        Status = 22
        Hazard = 23
        TIVValue = 24
        Units = 2
        Currency = 1
        ConvertUnits = 1 'UNKNOWN
        ConvertCurrency = 2 'UNKNOWN
        BatchFilter = 28
        MyPreferenceFilter = 29
        AutoRequest = 30
        CustomSetting = 31

    End Enum

End Class


Public Class FilterValuesInspectionProgramYear
    Public Const All As String = "(All)"
    Public Const LatestRatings As String = "Latest Ratings / All Locations"
    Public Const CurrentPeriod As String = "Current Inspection Period"
    Public Const PreviousPeriod As String = "Previous Inpection Period"
    Public Const TwoPreviousPeriods As String = "Previous Two Inspection Period"

End Class

Public Class FilterValuesInspectionProgramYearParms
    Public Const All As String = "(All)"
    Public Const LatestRatings As String = "Latest Ratings/All Locations"
    Public Const CurrentPeriod As String = "Current Inspection Period"
    Public Const PreviousPeriod As String = "Previous Inspection Period"
    Public Const TwoPreviousPeriods As String = "Previous Two Inspection Period"

End Class

Public Class FilterValuesTIV
    Public Const All As String = "(All)"
    Public Const TopTen As String = "Top 10 Highest in TIV"
    Public Const GreaterThan50 As String = "> $50 Million"
    Public Const GreaterThan100 As String = "> $100 Million"
    Public Const GreaterThan250 As String = "> 250 Million"

End Class

Public Class FilterValuesTIVParms
    Public Const All As String = "(All)"
    Public Const TopTen As String = "Top10Highest"
    Public Const GreaterThan50 As String = "Over50Million"
    Public Const GreaterThan100 As String = "Over100Million"
    Public Const GreaterThan250 As String = "Over250Million"

End Class

Public Class FilterValuesCountry
    Public Const All As String = "(All)"
    Public Const UnitedStates As String = "United States"

End Class

Public Class FilterValuesHazard
    Public Const All As String = "(All)"
    Public Const Fire As String = "Fire"
    Public Const BM As String = "Boiler & Machinery"
    Public Const Infrared As String = "Infrared"
    Public Const Juris As String = "Jurisdictional"
    Public Const Wind As String = "Wind"
    Public Const Seismic As String = "Seismic"
    Public Const Flood As String = "Flood"

End Class

Public Class FilterValuesHazardParms
    Public Const All As String = "(All)"
    Public Const Fire As String = "Fire"
    Public Const BM As String = "B&M"
    Public Const Infrared As String = "Infrared"
    Public Const Juris As String = "Jurisdictional"
    Public Const Wind As String = "Wind"
    Public Const Seismic As String = "Seismic"
    Public Const Flood As String = "Flood"

End Class

Public Class FilterValuesStatus
    Public Const All As String = "(All)"

End Class

