Imports GRC.Connect.Libraries.DataLib.razor

Public Interface IRatingReportData
    Property Client As IClient
    Property Fields As IrowVwWhatIfFireFacilityRating
    Property Averages As List(Of IRatingAverage)
    Property RatingKeys As IList(Of IrowVwMetaRatingKeyRange)
End Interface
