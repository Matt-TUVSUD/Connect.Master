Imports GRC.Connect.Libraries.DataLib.razor
Public Interface IBatchSetReportProperties
    Property SQL As String
    Property Disclaimer As String
    Property FilterString As String
    Property MyFilterString As String
    Property SortString As String
    Property ClientName As String
    Property Currency As rowTblMetaCurrency
    Property Unit As IBatchReportPropertiesUnit
    Property Language As rowTblMetaLanguage
    Property FilePrefix As String
    Property ConnectionString As String
    Property ClientSpecialFeatures As String
    Property Colors As List(Of rowTblMetaColor)
    Property LossEstimates As List(Of rowTblMetaLossEstimate)
    Property BMRatingRange As List(Of rowVwMetaRatingKeyRange)
    Property FireRatingRange As List(Of rowVwMetaRatingKeyRange)
    Property Practice As rowTblMetaPractice
    Property ReportSourceJoin As rowTblMetaSourceJoin
    Property MetaReport As rowTblMetaReport
    Property RecResponse As IBatchReportPropertiesRecResponse
    Property ClientRatingCategoryColors As List(Of rowTblClientMetaRatingCategoryColor)
    Property GDC As UtilGDC
End Interface
