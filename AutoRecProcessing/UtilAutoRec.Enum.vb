
Partial Class UtilAutoRec

    Public Enum ProcessType
        Initial = 1
        FollowUp1st
        FollowUp2nd
        FollowUp3rd
        Overdue1st
        Overdue2nd
        Overdue3rd
        Logout
        ExpiredOverdue
        ExpiringExpectedCompletionDate

    End Enum

    Public Enum OverdueProcessType
        Overdue1st = 5
        Overdue2nd = 6
        Overdue3rd = 7
    End Enum

    Public Enum AutoRequest
        FirstFollowUp
        SecondFollowUp
        ThirdFollowUp
    End Enum

    Public Enum EzUserManagerType
        RiskManager
        DivisionManager
        PlantManager
        CustomAccessManager
        ClientLocNoManager
        CityManager
        StProvManager
        CountryManager
        FacilityManager
    End Enum

    <Flags>
    Public Enum Modes
        Normal = 0
        NoEmails = 1
        NoDataUpdates = 2
    End Enum

End Class
