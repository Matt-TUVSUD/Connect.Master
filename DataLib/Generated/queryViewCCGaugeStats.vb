'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryViewCCGaugeStats
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colGSafeGUID As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colFireInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFireInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colBMInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colBMInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colIRInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colIRInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colWindInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colWindInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colWindInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colWindInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazWindInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colSeismicInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colSeismicInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colSeismicInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colSeismicInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazSeismicInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFloodInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colFloodInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colFloodInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colFloodInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colNatHazFloodInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colJurisNoObjections As New razor.UtilSQLServer.StringDataColumn
        Public colJurisOpenViolations As New razor.UtilSQLServer.StringDataColumn
        Public colJurisNoActiveObjections As New razor.UtilSQLServer.StringDataColumn
        Public colJurisObjectsStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colJurisActiveObjectsStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colJurisOpenRecommendationsStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colJurisObjectsFilter As New razor.UtilSQLServer.StringDataColumn
        Public colJurisActiveObjectsFilter As New razor.UtilSQLServer.StringDataColumn
        Public colJurisOpenRecommendationsFilter As New razor.UtilSQLServer.StringDataColumn
        Public colJurisObjectsLabel As New razor.UtilSQLServer.StringDataColumn
        Public colJurisActiveObjectsLabel As New razor.UtilSQLServer.StringDataColumn
        Public colJurisOpenRecommendationsLabel As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colDivServInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsDue As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsComplete As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsPending As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsCancelled As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsDueStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsCompletedStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsPendingStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsCancelledStatisticId As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsDueFilter As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsCompleteFilter As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsPendingFilter As New razor.UtilSQLServer.StringDataColumn
        Public colPSInspectionsCancelledFilter As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsDueLabel As New razor.UtilSQLServer.StringDataColumn
        Public colPsInpectionsCompletedLabel As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsPendingLabel As New razor.UtilSQLServer.StringDataColumn
        Public colPSInpectionsCancelledLabel As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFilePrefix.ColumnName = "[FilePrefix]"
            colGSafeGUID.ColumnName = "[GSafeGUID]"
            colFireInspectionsDue.ColumnName = "[FireInspectionsDue]"
            colFireInspectionsComplete.ColumnName = "[FireInspectionsComplete]"
            colFireInspectionsPending.ColumnName = "[FireInspectionsPending]"
            colFireInspectionsCancelled.ColumnName = "[FireInspectionsCancelled]"
            colFireInpectionsDueStatisticId.ColumnName = "[FireInpectionsDueStatisticId]"
            colFireInpectionsCompletedStatisticId.ColumnName = "[FireInpectionsCompletedStatisticId]"
            colFireInpectionsPendingStatisticId.ColumnName = "[FireInpectionsPendingStatisticId]"
            colFireInpectionsCancelledStatisticId.ColumnName = "[FireInpectionsCancelledStatisticId]"
            colFireInspectionsDueFilter.ColumnName = "[FireInspectionsDueFilter]"
            colFireInspectionsCompleteFilter.ColumnName = "[FireInspectionsCompleteFilter]"
            colFireInspectionsPendingFilter.ColumnName = "[FireInspectionsPendingFilter]"
            colFireInspectionsCancelledFilter.ColumnName = "[FireInspectionsCancelledFilter]"
            colFireInpectionsDueLabel.ColumnName = "[FireInpectionsDueLabel]"
            colFireInpectionsCompletedLabel.ColumnName = "[FireInpectionsCompletedLabel]"
            colFireInpectionsPendingLabel.ColumnName = "[FireInpectionsPendingLabel]"
            colFireInpectionsCancelledLabel.ColumnName = "[FireInpectionsCancelledLabel]"
            colBMInspectionsDue.ColumnName = "[BMInspectionsDue]"
            colBMInspectionsComplete.ColumnName = "[BMInspectionsComplete]"
            colBMInspectionsPending.ColumnName = "[BMInspectionsPending]"
            colBMInspectionsCancelled.ColumnName = "[BMInspectionsCancelled]"
            colBMInpectionsDueStatisticId.ColumnName = "[BMInpectionsDueStatisticId]"
            colBMInpectionsCompletedStatisticId.ColumnName = "[BMInpectionsCompletedStatisticId]"
            colBMInpectionsPendingStatisticId.ColumnName = "[BMInpectionsPendingStatisticId]"
            colBMInpectionsCancelledStatisticId.ColumnName = "[BMInpectionsCancelledStatisticId]"
            colBMInspectionsDueFilter.ColumnName = "[BMInspectionsDueFilter]"
            colBMInspectionsCompleteFilter.ColumnName = "[BMInspectionsCompleteFilter]"
            colBMInspectionsPendingFilter.ColumnName = "[BMInspectionsPendingFilter]"
            colBMInspectionsCancelledFilter.ColumnName = "[BMInspectionsCancelledFilter]"
            colBMInpectionsDueLabel.ColumnName = "[BMInpectionsDueLabel]"
            colBMInpectionsCompletedLabel.ColumnName = "[BMInpectionsCompletedLabel]"
            colBMInpectionsPendingLabel.ColumnName = "[BMInpectionsPendingLabel]"
            colBMInpectionsCancelledLabel.ColumnName = "[BMInpectionsCancelledLabel]"
            colIRInspectionsDue.ColumnName = "[IRInspectionsDue]"
            colIRInspectionsComplete.ColumnName = "[IRInspectionsComplete]"
            colIRInspectionsPending.ColumnName = "[IRInspectionsPending]"
            colIRInspectionsCancelled.ColumnName = "[IRInspectionsCancelled]"
            colIRInpectionsDueStatisticId.ColumnName = "[IRInpectionsDueStatisticId]"
            colIRInpectionsCompletedStatisticId.ColumnName = "[IRInpectionsCompletedStatisticId]"
            colIRInpectionsPendingStatisticId.ColumnName = "[IRInpectionsPendingStatisticId]"
            colIRInpectionsCancelledStatisticId.ColumnName = "[IRInpectionsCancelledStatisticId]"
            colIRInspectionsDueFilter.ColumnName = "[IRInspectionsDueFilter]"
            colIRInspectionsCompleteFilter.ColumnName = "[IRInspectionsCompleteFilter]"
            colIRInspectionsPendingFilter.ColumnName = "[IRInspectionsPendingFilter]"
            colIRInspectionsCancelledFilter.ColumnName = "[IRInspectionsCancelledFilter]"
            colIRInpectionsDueLabel.ColumnName = "[IRInpectionsDueLabel]"
            colIRInpectionsCompletedLabel.ColumnName = "[IRInpectionsCompletedLabel]"
            colIRInpectionsPendingLabel.ColumnName = "[IRInpectionsPendingLabel]"
            colIRInpectionsCancelledLabel.ColumnName = "[IRInpectionsCancelledLabel]"
            colNatHazInspectionsDue.ColumnName = "[NatHazInspectionsDue]"
            colNatHazInspectionsComplete.ColumnName = "[NatHazInspectionsComplete]"
            colNatHazInspectionsPending.ColumnName = "[NatHazInspectionsPending]"
            colNatHazInspectionsCancelled.ColumnName = "[NatHazInspectionsCancelled]"
            colNatHazInpectionsDueStatisticId.ColumnName = "[NatHazInpectionsDueStatisticId]"
            colNatHazInpectionsCompletedStatisticId.ColumnName = "[NatHazInpectionsCompletedStatisticId]"
            colNatHazInpectionsPendingStatisticId.ColumnName = "[NatHazInpectionsPendingStatisticId]"
            colNatHazInpectionsCancelledStatisticId.ColumnName = "[NatHazInpectionsCancelledStatisticId]"
            colNatHazInspectionsDueFilter.ColumnName = "[NatHazInspectionsDueFilter]"
            colNatHazInspectionsCompleteFilter.ColumnName = "[NatHazInspectionsCompleteFilter]"
            colNatHazInspectionsPendingFilter.ColumnName = "[NatHazInspectionsPendingFilter]"
            colNatHazInspectionsCancelledFilter.ColumnName = "[NatHazInspectionsCancelledFilter]"
            colNatHazInpectionsDueLabel.ColumnName = "[NatHazInpectionsDueLabel]"
            colNatHazInpectionsCompletedLabel.ColumnName = "[NatHazInpectionsCompletedLabel]"
            colNatHazInpectionsPendingLabel.ColumnName = "[NatHazInpectionsPendingLabel]"
            colNatHazInpectionsCancelledLabel.ColumnName = "[NatHazInpectionsCancelledLabel]"
            colWindInspectionsDue.ColumnName = "[WindInspectionsDue]"
            colWindInspectionsComplete.ColumnName = "[WindInspectionsComplete]"
            colWindInspectionsPending.ColumnName = "[WindInspectionsPending]"
            colWindInspectionsCancelled.ColumnName = "[WindInspectionsCancelled]"
            colNatHazWindInpectionsDueStatisticId.ColumnName = "[NatHazWindInpectionsDueStatisticId]"
            colNatHazWindInpectionsCompletedStatisticId.ColumnName = "[NatHazWindInpectionsCompletedStatisticId]"
            colNatHazWindInpectionsPendingStatisticId.ColumnName = "[NatHazWindInpectionsPendingStatisticId]"
            colNatHazWindInpectionsCancelledStatisticId.ColumnName = "[NatHazWindInpectionsCancelledStatisticId]"
            colNatHazWindInspectionsDueFilter.ColumnName = "[NatHazWindInspectionsDueFilter]"
            colNatHazWindInspectionsCompleteFilter.ColumnName = "[NatHazWindInspectionsCompleteFilter]"
            colNatHazWindInspectionsPendingFilter.ColumnName = "[NatHazWindInspectionsPendingFilter]"
            colNatHazWindInspectionsCancelledFilter.ColumnName = "[NatHazWindInspectionsCancelledFilter]"
            colNatHazWindInpectionsDueLabel.ColumnName = "[NatHazWindInpectionsDueLabel]"
            colNatHazWindInpectionsCompletedLabel.ColumnName = "[NatHazWindInpectionsCompletedLabel]"
            colNatHazWindInpectionsPendingLabel.ColumnName = "[NatHazWindInpectionsPendingLabel]"
            colNatHazWindInpectionsCancelledLabel.ColumnName = "[NatHazWindInpectionsCancelledLabel]"
            colSeismicInspectionsDue.ColumnName = "[SeismicInspectionsDue]"
            colSeismicInspectionsComplete.ColumnName = "[SeismicInspectionsComplete]"
            colSeismicInspectionsPending.ColumnName = "[SeismicInspectionsPending]"
            colSeismicInspectionsCancelled.ColumnName = "[SeismicInspectionsCancelled]"
            colNatHazSeismicInpectionsDueStatisticId.ColumnName = "[NatHazSeismicInpectionsDueStatisticId]"
            colNatHazSeismicInpectionsCompletedStatisticId.ColumnName = "[NatHazSeismicInpectionsCompletedStatisticId]"
            colNatHazSeismicInpectionsPendingStatisticId.ColumnName = "[NatHazSeismicInpectionsPendingStatisticId]"
            colNatHazSeismicInpectionsCancelledStatisticId.ColumnName = "[NatHazSeismicInpectionsCancelledStatisticId]"
            colNatHazSeismicInspectionsDueFilter.ColumnName = "[NatHazSeismicInspectionsDueFilter]"
            colNatHazSeismicInspectionsCompleteFilter.ColumnName = "[NatHazSeismicInspectionsCompleteFilter]"
            colNatHazSeismicInspectionsPendingFilter.ColumnName = "[NatHazSeismicInspectionsPendingFilter]"
            colNatHazSeismicInspectionsCancelledFilter.ColumnName = "[NatHazSeismicInspectionsCancelledFilter]"
            colNatHazSeismicInpectionsDueLabel.ColumnName = "[NatHazSeismicInpectionsDueLabel]"
            colNatHazSeismicInpectionsCompletedLabel.ColumnName = "[NatHazSeismicInpectionsCompletedLabel]"
            colNatHazSeismicInpectionsPendingLabel.ColumnName = "[NatHazSeismicInpectionsPendingLabel]"
            colNatHazSeismicInpectionsCancelledLabel.ColumnName = "[NatHazSeismicInpectionsCancelledLabel]"
            colFloodInspectionsDue.ColumnName = "[FloodInspectionsDue]"
            colFloodInspectionsComplete.ColumnName = "[FloodInspectionsComplete]"
            colFloodInspectionsPending.ColumnName = "[FloodInspectionsPending]"
            colFloodInspectionsCancelled.ColumnName = "[FloodInspectionsCancelled]"
            colNatHazFloodInpectionsDueStatisticId.ColumnName = "[NatHazFloodInpectionsDueStatisticId]"
            colNatHazFloodInpectionsCompletedStatisticId.ColumnName = "[NatHazFloodInpectionsCompletedStatisticId]"
            colNatHazFloodInpectionsPendingStatisticId.ColumnName = "[NatHazFloodInpectionsPendingStatisticId]"
            colNatHazFloodInpectionsCancelledStatisticId.ColumnName = "[NatHazFloodInpectionsCancelledStatisticId]"
            colNatHazFloodInspectionsDueFilter.ColumnName = "[NatHazFloodInspectionsDueFilter]"
            colNatHazFloodInspectionsCompleteFilter.ColumnName = "[NatHazFloodInspectionsCompleteFilter]"
            colNatHazFloodInspectionsPendingFilter.ColumnName = "[NatHazFloodInspectionsPendingFilter]"
            colNatHazFloodInspectionsCancelledFilter.ColumnName = "[NatHazFloodInspectionsCancelledFilter]"
            colNatHazFloodInpectionsDueLabel.ColumnName = "[NatHazFloodInpectionsDueLabel]"
            colNatHazFloodInpectionsCompletedLabel.ColumnName = "[NatHazFloodInpectionsCompletedLabel]"
            colNatHazFloodInpectionsPendingLabel.ColumnName = "[NatHazFloodInpectionsPendingLabel]"
            colNatHazFloodInpectionsCancelledLabel.ColumnName = "[NatHazFloodInpectionsCancelledLabel]"
            colJurisNoObjections.ColumnName = "[JurisNoObjections]"
            colJurisOpenViolations.ColumnName = "[JurisOpenViolations]"
            colJurisNoActiveObjections.ColumnName = "[JurisNoActiveObjections]"
            colJurisObjectsStatisticId.ColumnName = "[JurisObjectsStatisticId]"
            colJurisActiveObjectsStatisticId.ColumnName = "[JurisActiveObjectsStatisticId]"
            colJurisOpenRecommendationsStatisticId.ColumnName = "[JurisOpenRecommendationsStatisticId]"
            colJurisObjectsFilter.ColumnName = "[JurisObjectsFilter]"
            colJurisActiveObjectsFilter.ColumnName = "[JurisActiveObjectsFilter]"
            colJurisOpenRecommendationsFilter.ColumnName = "[JurisOpenRecommendationsFilter]"
            colJurisObjectsLabel.ColumnName = "[JurisObjectsLabel]"
            colJurisActiveObjectsLabel.ColumnName = "[JurisActiveObjectsLabel]"
            colJurisOpenRecommendationsLabel.ColumnName = "[JurisOpenRecommendationsLabel]"
            colDivServInspectionsDue.ColumnName = "[DivServInspectionsDue]"
            colDivServInspectionsComplete.ColumnName = "[DivServInspectionsComplete]"
            colDivServInspectionsPending.ColumnName = "[DivServInspectionsPending]"
            colDivServInspectionsCancelled.ColumnName = "[DivServInspectionsCancelled]"
            colDivServInpectionsDueStatisticId.ColumnName = "[DivServInpectionsDueStatisticId]"
            colDivServInpectionsCompletedStatisticId.ColumnName = "[DivServInpectionsCompletedStatisticId]"
            colDivServInpectionsPendingStatisticId.ColumnName = "[DivServInpectionsPendingStatisticId]"
            colDivServInpectionsCancelledStatisticId.ColumnName = "[DivServInpectionsCancelledStatisticId]"
            colDivServInspectionsDueFilter.ColumnName = "[DivServInspectionsDueFilter]"
            colDivServInspectionsCompleteFilter.ColumnName = "[DivServInspectionsCompleteFilter]"
            colDivServInspectionsPendingFilter.ColumnName = "[DivServInspectionsPendingFilter]"
            colDivServInspectionsCancelledFilter.ColumnName = "[DivServInspectionsCancelledFilter]"
            colDivServInpectionsDueLabel.ColumnName = "[DivServInpectionsDueLabel]"
            colDivServInpectionsCompletedLabel.ColumnName = "[DivServInpectionsCompletedLabel]"
            colDivServInpectionsPendingLabel.ColumnName = "[DivServInpectionsPendingLabel]"
            colDivServInpectionsCancelledLabel.ColumnName = "[DivServInpectionsCancelledLabel]"
            colPSInspectionsDue.ColumnName = "[PSInspectionsDue]"
            colPSInspectionsComplete.ColumnName = "[PSInspectionsComplete]"
            colPSInspectionsPending.ColumnName = "[PSInspectionsPending]"
            colPSInspectionsCancelled.ColumnName = "[PSInspectionsCancelled]"
            colPSInpectionsDueStatisticId.ColumnName = "[PSInpectionsDueStatisticId]"
            colPSInpectionsCompletedStatisticId.ColumnName = "[PSInpectionsCompletedStatisticId]"
            colPSInpectionsPendingStatisticId.ColumnName = "[PSInpectionsPendingStatisticId]"
            colPSInpectionsCancelledStatisticId.ColumnName = "[PSInpectionsCancelledStatisticId]"
            colPSInspectionsDueFilter.ColumnName = "[PSInspectionsDueFilter]"
            colPSInspectionsCompleteFilter.ColumnName = "[PSInspectionsCompleteFilter]"
            colPSInspectionsPendingFilter.ColumnName = "[PSInspectionsPendingFilter]"
            colPSInspectionsCancelledFilter.ColumnName = "[PSInspectionsCancelledFilter]"
            colPSInpectionsDueLabel.ColumnName = "[PSInpectionsDueLabel]"
            colPsInpectionsCompletedLabel.ColumnName = "[PsInpectionsCompletedLabel]"
            colPSInpectionsPendingLabel.ColumnName = "[PSInpectionsPendingLabel]"
            colPSInpectionsCancelledLabel.ColumnName = "[PSInpectionsCancelledLabel]"

            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colGSafeGUID", colGSafeGUID)
            _Members.Add("colFireInspectionsDue", colFireInspectionsDue)
            _Members.Add("colFireInspectionsComplete", colFireInspectionsComplete)
            _Members.Add("colFireInspectionsPending", colFireInspectionsPending)
            _Members.Add("colFireInspectionsCancelled", colFireInspectionsCancelled)
            _Members.Add("colFireInpectionsDueStatisticId", colFireInpectionsDueStatisticId)
            _Members.Add("colFireInpectionsCompletedStatisticId", colFireInpectionsCompletedStatisticId)
            _Members.Add("colFireInpectionsPendingStatisticId", colFireInpectionsPendingStatisticId)
            _Members.Add("colFireInpectionsCancelledStatisticId", colFireInpectionsCancelledStatisticId)
            _Members.Add("colFireInspectionsDueFilter", colFireInspectionsDueFilter)
            _Members.Add("colFireInspectionsCompleteFilter", colFireInspectionsCompleteFilter)
            _Members.Add("colFireInspectionsPendingFilter", colFireInspectionsPendingFilter)
            _Members.Add("colFireInspectionsCancelledFilter", colFireInspectionsCancelledFilter)
            _Members.Add("colFireInpectionsDueLabel", colFireInpectionsDueLabel)
            _Members.Add("colFireInpectionsCompletedLabel", colFireInpectionsCompletedLabel)
            _Members.Add("colFireInpectionsPendingLabel", colFireInpectionsPendingLabel)
            _Members.Add("colFireInpectionsCancelledLabel", colFireInpectionsCancelledLabel)
            _Members.Add("colBMInspectionsDue", colBMInspectionsDue)
            _Members.Add("colBMInspectionsComplete", colBMInspectionsComplete)
            _Members.Add("colBMInspectionsPending", colBMInspectionsPending)
            _Members.Add("colBMInspectionsCancelled", colBMInspectionsCancelled)
            _Members.Add("colBMInpectionsDueStatisticId", colBMInpectionsDueStatisticId)
            _Members.Add("colBMInpectionsCompletedStatisticId", colBMInpectionsCompletedStatisticId)
            _Members.Add("colBMInpectionsPendingStatisticId", colBMInpectionsPendingStatisticId)
            _Members.Add("colBMInpectionsCancelledStatisticId", colBMInpectionsCancelledStatisticId)
            _Members.Add("colBMInspectionsDueFilter", colBMInspectionsDueFilter)
            _Members.Add("colBMInspectionsCompleteFilter", colBMInspectionsCompleteFilter)
            _Members.Add("colBMInspectionsPendingFilter", colBMInspectionsPendingFilter)
            _Members.Add("colBMInspectionsCancelledFilter", colBMInspectionsCancelledFilter)
            _Members.Add("colBMInpectionsDueLabel", colBMInpectionsDueLabel)
            _Members.Add("colBMInpectionsCompletedLabel", colBMInpectionsCompletedLabel)
            _Members.Add("colBMInpectionsPendingLabel", colBMInpectionsPendingLabel)
            _Members.Add("colBMInpectionsCancelledLabel", colBMInpectionsCancelledLabel)
            _Members.Add("colIRInspectionsDue", colIRInspectionsDue)
            _Members.Add("colIRInspectionsComplete", colIRInspectionsComplete)
            _Members.Add("colIRInspectionsPending", colIRInspectionsPending)
            _Members.Add("colIRInspectionsCancelled", colIRInspectionsCancelled)
            _Members.Add("colIRInpectionsDueStatisticId", colIRInpectionsDueStatisticId)
            _Members.Add("colIRInpectionsCompletedStatisticId", colIRInpectionsCompletedStatisticId)
            _Members.Add("colIRInpectionsPendingStatisticId", colIRInpectionsPendingStatisticId)
            _Members.Add("colIRInpectionsCancelledStatisticId", colIRInpectionsCancelledStatisticId)
            _Members.Add("colIRInspectionsDueFilter", colIRInspectionsDueFilter)
            _Members.Add("colIRInspectionsCompleteFilter", colIRInspectionsCompleteFilter)
            _Members.Add("colIRInspectionsPendingFilter", colIRInspectionsPendingFilter)
            _Members.Add("colIRInspectionsCancelledFilter", colIRInspectionsCancelledFilter)
            _Members.Add("colIRInpectionsDueLabel", colIRInpectionsDueLabel)
            _Members.Add("colIRInpectionsCompletedLabel", colIRInpectionsCompletedLabel)
            _Members.Add("colIRInpectionsPendingLabel", colIRInpectionsPendingLabel)
            _Members.Add("colIRInpectionsCancelledLabel", colIRInpectionsCancelledLabel)
            _Members.Add("colNatHazInspectionsDue", colNatHazInspectionsDue)
            _Members.Add("colNatHazInspectionsComplete", colNatHazInspectionsComplete)
            _Members.Add("colNatHazInspectionsPending", colNatHazInspectionsPending)
            _Members.Add("colNatHazInspectionsCancelled", colNatHazInspectionsCancelled)
            _Members.Add("colNatHazInpectionsDueStatisticId", colNatHazInpectionsDueStatisticId)
            _Members.Add("colNatHazInpectionsCompletedStatisticId", colNatHazInpectionsCompletedStatisticId)
            _Members.Add("colNatHazInpectionsPendingStatisticId", colNatHazInpectionsPendingStatisticId)
            _Members.Add("colNatHazInpectionsCancelledStatisticId", colNatHazInpectionsCancelledStatisticId)
            _Members.Add("colNatHazInspectionsDueFilter", colNatHazInspectionsDueFilter)
            _Members.Add("colNatHazInspectionsCompleteFilter", colNatHazInspectionsCompleteFilter)
            _Members.Add("colNatHazInspectionsPendingFilter", colNatHazInspectionsPendingFilter)
            _Members.Add("colNatHazInspectionsCancelledFilter", colNatHazInspectionsCancelledFilter)
            _Members.Add("colNatHazInpectionsDueLabel", colNatHazInpectionsDueLabel)
            _Members.Add("colNatHazInpectionsCompletedLabel", colNatHazInpectionsCompletedLabel)
            _Members.Add("colNatHazInpectionsPendingLabel", colNatHazInpectionsPendingLabel)
            _Members.Add("colNatHazInpectionsCancelledLabel", colNatHazInpectionsCancelledLabel)
            _Members.Add("colWindInspectionsDue", colWindInspectionsDue)
            _Members.Add("colWindInspectionsComplete", colWindInspectionsComplete)
            _Members.Add("colWindInspectionsPending", colWindInspectionsPending)
            _Members.Add("colWindInspectionsCancelled", colWindInspectionsCancelled)
            _Members.Add("colNatHazWindInpectionsDueStatisticId", colNatHazWindInpectionsDueStatisticId)
            _Members.Add("colNatHazWindInpectionsCompletedStatisticId", colNatHazWindInpectionsCompletedStatisticId)
            _Members.Add("colNatHazWindInpectionsPendingStatisticId", colNatHazWindInpectionsPendingStatisticId)
            _Members.Add("colNatHazWindInpectionsCancelledStatisticId", colNatHazWindInpectionsCancelledStatisticId)
            _Members.Add("colNatHazWindInspectionsDueFilter", colNatHazWindInspectionsDueFilter)
            _Members.Add("colNatHazWindInspectionsCompleteFilter", colNatHazWindInspectionsCompleteFilter)
            _Members.Add("colNatHazWindInspectionsPendingFilter", colNatHazWindInspectionsPendingFilter)
            _Members.Add("colNatHazWindInspectionsCancelledFilter", colNatHazWindInspectionsCancelledFilter)
            _Members.Add("colNatHazWindInpectionsDueLabel", colNatHazWindInpectionsDueLabel)
            _Members.Add("colNatHazWindInpectionsCompletedLabel", colNatHazWindInpectionsCompletedLabel)
            _Members.Add("colNatHazWindInpectionsPendingLabel", colNatHazWindInpectionsPendingLabel)
            _Members.Add("colNatHazWindInpectionsCancelledLabel", colNatHazWindInpectionsCancelledLabel)
            _Members.Add("colSeismicInspectionsDue", colSeismicInspectionsDue)
            _Members.Add("colSeismicInspectionsComplete", colSeismicInspectionsComplete)
            _Members.Add("colSeismicInspectionsPending", colSeismicInspectionsPending)
            _Members.Add("colSeismicInspectionsCancelled", colSeismicInspectionsCancelled)
            _Members.Add("colNatHazSeismicInpectionsDueStatisticId", colNatHazSeismicInpectionsDueStatisticId)
            _Members.Add("colNatHazSeismicInpectionsCompletedStatisticId", colNatHazSeismicInpectionsCompletedStatisticId)
            _Members.Add("colNatHazSeismicInpectionsPendingStatisticId", colNatHazSeismicInpectionsPendingStatisticId)
            _Members.Add("colNatHazSeismicInpectionsCancelledStatisticId", colNatHazSeismicInpectionsCancelledStatisticId)
            _Members.Add("colNatHazSeismicInspectionsDueFilter", colNatHazSeismicInspectionsDueFilter)
            _Members.Add("colNatHazSeismicInspectionsCompleteFilter", colNatHazSeismicInspectionsCompleteFilter)
            _Members.Add("colNatHazSeismicInspectionsPendingFilter", colNatHazSeismicInspectionsPendingFilter)
            _Members.Add("colNatHazSeismicInspectionsCancelledFilter", colNatHazSeismicInspectionsCancelledFilter)
            _Members.Add("colNatHazSeismicInpectionsDueLabel", colNatHazSeismicInpectionsDueLabel)
            _Members.Add("colNatHazSeismicInpectionsCompletedLabel", colNatHazSeismicInpectionsCompletedLabel)
            _Members.Add("colNatHazSeismicInpectionsPendingLabel", colNatHazSeismicInpectionsPendingLabel)
            _Members.Add("colNatHazSeismicInpectionsCancelledLabel", colNatHazSeismicInpectionsCancelledLabel)
            _Members.Add("colFloodInspectionsDue", colFloodInspectionsDue)
            _Members.Add("colFloodInspectionsComplete", colFloodInspectionsComplete)
            _Members.Add("colFloodInspectionsPending", colFloodInspectionsPending)
            _Members.Add("colFloodInspectionsCancelled", colFloodInspectionsCancelled)
            _Members.Add("colNatHazFloodInpectionsDueStatisticId", colNatHazFloodInpectionsDueStatisticId)
            _Members.Add("colNatHazFloodInpectionsCompletedStatisticId", colNatHazFloodInpectionsCompletedStatisticId)
            _Members.Add("colNatHazFloodInpectionsPendingStatisticId", colNatHazFloodInpectionsPendingStatisticId)
            _Members.Add("colNatHazFloodInpectionsCancelledStatisticId", colNatHazFloodInpectionsCancelledStatisticId)
            _Members.Add("colNatHazFloodInspectionsDueFilter", colNatHazFloodInspectionsDueFilter)
            _Members.Add("colNatHazFloodInspectionsCompleteFilter", colNatHazFloodInspectionsCompleteFilter)
            _Members.Add("colNatHazFloodInspectionsPendingFilter", colNatHazFloodInspectionsPendingFilter)
            _Members.Add("colNatHazFloodInspectionsCancelledFilter", colNatHazFloodInspectionsCancelledFilter)
            _Members.Add("colNatHazFloodInpectionsDueLabel", colNatHazFloodInpectionsDueLabel)
            _Members.Add("colNatHazFloodInpectionsCompletedLabel", colNatHazFloodInpectionsCompletedLabel)
            _Members.Add("colNatHazFloodInpectionsPendingLabel", colNatHazFloodInpectionsPendingLabel)
            _Members.Add("colNatHazFloodInpectionsCancelledLabel", colNatHazFloodInpectionsCancelledLabel)
            _Members.Add("colJurisNoObjections", colJurisNoObjections)
            _Members.Add("colJurisOpenViolations", colJurisOpenViolations)
            _Members.Add("colJurisNoActiveObjections", colJurisNoActiveObjections)
            _Members.Add("colJurisObjectsStatisticId", colJurisObjectsStatisticId)
            _Members.Add("colJurisActiveObjectsStatisticId", colJurisActiveObjectsStatisticId)
            _Members.Add("colJurisOpenRecommendationsStatisticId", colJurisOpenRecommendationsStatisticId)
            _Members.Add("colJurisObjectsFilter", colJurisObjectsFilter)
            _Members.Add("colJurisActiveObjectsFilter", colJurisActiveObjectsFilter)
            _Members.Add("colJurisOpenRecommendationsFilter", colJurisOpenRecommendationsFilter)
            _Members.Add("colJurisObjectsLabel", colJurisObjectsLabel)
            _Members.Add("colJurisActiveObjectsLabel", colJurisActiveObjectsLabel)
            _Members.Add("colJurisOpenRecommendationsLabel", colJurisOpenRecommendationsLabel)
            _Members.Add("colDivServInspectionsDue", colDivServInspectionsDue)
            _Members.Add("colDivServInspectionsComplete", colDivServInspectionsComplete)
            _Members.Add("colDivServInspectionsPending", colDivServInspectionsPending)
            _Members.Add("colDivServInspectionsCancelled", colDivServInspectionsCancelled)
            _Members.Add("colDivServInpectionsDueStatisticId", colDivServInpectionsDueStatisticId)
            _Members.Add("colDivServInpectionsCompletedStatisticId", colDivServInpectionsCompletedStatisticId)
            _Members.Add("colDivServInpectionsPendingStatisticId", colDivServInpectionsPendingStatisticId)
            _Members.Add("colDivServInpectionsCancelledStatisticId", colDivServInpectionsCancelledStatisticId)
            _Members.Add("colDivServInspectionsDueFilter", colDivServInspectionsDueFilter)
            _Members.Add("colDivServInspectionsCompleteFilter", colDivServInspectionsCompleteFilter)
            _Members.Add("colDivServInspectionsPendingFilter", colDivServInspectionsPendingFilter)
            _Members.Add("colDivServInspectionsCancelledFilter", colDivServInspectionsCancelledFilter)
            _Members.Add("colDivServInpectionsDueLabel", colDivServInpectionsDueLabel)
            _Members.Add("colDivServInpectionsCompletedLabel", colDivServInpectionsCompletedLabel)
            _Members.Add("colDivServInpectionsPendingLabel", colDivServInpectionsPendingLabel)
            _Members.Add("colDivServInpectionsCancelledLabel", colDivServInpectionsCancelledLabel)
            _Members.Add("colPSInspectionsDue", colPSInspectionsDue)
            _Members.Add("colPSInspectionsComplete", colPSInspectionsComplete)
            _Members.Add("colPSInspectionsPending", colPSInspectionsPending)
            _Members.Add("colPSInspectionsCancelled", colPSInspectionsCancelled)
            _Members.Add("colPSInpectionsDueStatisticId", colPSInpectionsDueStatisticId)
            _Members.Add("colPSInpectionsCompletedStatisticId", colPSInpectionsCompletedStatisticId)
            _Members.Add("colPSInpectionsPendingStatisticId", colPSInpectionsPendingStatisticId)
            _Members.Add("colPSInpectionsCancelledStatisticId", colPSInpectionsCancelledStatisticId)
            _Members.Add("colPSInspectionsDueFilter", colPSInspectionsDueFilter)
            _Members.Add("colPSInspectionsCompleteFilter", colPSInspectionsCompleteFilter)
            _Members.Add("colPSInspectionsPendingFilter", colPSInspectionsPendingFilter)
            _Members.Add("colPSInspectionsCancelledFilter", colPSInspectionsCancelledFilter)
            _Members.Add("colPSInpectionsDueLabel", colPSInpectionsDueLabel)
            _Members.Add("colPsInpectionsCompletedLabel", colPsInpectionsCompletedLabel)
            _Members.Add("colPSInpectionsPendingLabel", colPSInpectionsPendingLabel)
            _Members.Add("colPSInpectionsCancelledLabel", colPSInpectionsCancelledLabel)
        End Sub

        Public Function Member(pObjectName As String) As Object
            Dim zReturn As Object = Nothing
            If _Members.ContainsKey(pObjectName) Then
                zReturn = _Members.Item(pObjectName)
            Else
                Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in member dictionary.")
            End If
            Return zReturn
        End Function

        Public Function MemberColumn(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colGSafeGUID"
                    Return "[GSafeGUID]"
                Case "colFireInspectionsDue"
                    Return "[FireInspectionsDue]"
                Case "colFireInspectionsComplete"
                    Return "[FireInspectionsComplete]"
                Case "colFireInspectionsPending"
                    Return "[FireInspectionsPending]"
                Case "colFireInspectionsCancelled"
                    Return "[FireInspectionsCancelled]"
                Case "colFireInpectionsDueStatisticId"
                    Return "[FireInpectionsDueStatisticId]"
                Case "colFireInpectionsCompletedStatisticId"
                    Return "[FireInpectionsCompletedStatisticId]"
                Case "colFireInpectionsPendingStatisticId"
                    Return "[FireInpectionsPendingStatisticId]"
                Case "colFireInpectionsCancelledStatisticId"
                    Return "[FireInpectionsCancelledStatisticId]"
                Case "colFireInspectionsDueFilter"
                    Return "[FireInspectionsDueFilter]"
                Case "colFireInspectionsCompleteFilter"
                    Return "[FireInspectionsCompleteFilter]"
                Case "colFireInspectionsPendingFilter"
                    Return "[FireInspectionsPendingFilter]"
                Case "colFireInspectionsCancelledFilter"
                    Return "[FireInspectionsCancelledFilter]"
                Case "colFireInpectionsDueLabel"
                    Return "[FireInpectionsDueLabel]"
                Case "colFireInpectionsCompletedLabel"
                    Return "[FireInpectionsCompletedLabel]"
                Case "colFireInpectionsPendingLabel"
                    Return "[FireInpectionsPendingLabel]"
                Case "colFireInpectionsCancelledLabel"
                    Return "[FireInpectionsCancelledLabel]"
                Case "colBMInspectionsDue"
                    Return "[BMInspectionsDue]"
                Case "colBMInspectionsComplete"
                    Return "[BMInspectionsComplete]"
                Case "colBMInspectionsPending"
                    Return "[BMInspectionsPending]"
                Case "colBMInspectionsCancelled"
                    Return "[BMInspectionsCancelled]"
                Case "colBMInpectionsDueStatisticId"
                    Return "[BMInpectionsDueStatisticId]"
                Case "colBMInpectionsCompletedStatisticId"
                    Return "[BMInpectionsCompletedStatisticId]"
                Case "colBMInpectionsPendingStatisticId"
                    Return "[BMInpectionsPendingStatisticId]"
                Case "colBMInpectionsCancelledStatisticId"
                    Return "[BMInpectionsCancelledStatisticId]"
                Case "colBMInspectionsDueFilter"
                    Return "[BMInspectionsDueFilter]"
                Case "colBMInspectionsCompleteFilter"
                    Return "[BMInspectionsCompleteFilter]"
                Case "colBMInspectionsPendingFilter"
                    Return "[BMInspectionsPendingFilter]"
                Case "colBMInspectionsCancelledFilter"
                    Return "[BMInspectionsCancelledFilter]"
                Case "colBMInpectionsDueLabel"
                    Return "[BMInpectionsDueLabel]"
                Case "colBMInpectionsCompletedLabel"
                    Return "[BMInpectionsCompletedLabel]"
                Case "colBMInpectionsPendingLabel"
                    Return "[BMInpectionsPendingLabel]"
                Case "colBMInpectionsCancelledLabel"
                    Return "[BMInpectionsCancelledLabel]"
                Case "colIRInspectionsDue"
                    Return "[IRInspectionsDue]"
                Case "colIRInspectionsComplete"
                    Return "[IRInspectionsComplete]"
                Case "colIRInspectionsPending"
                    Return "[IRInspectionsPending]"
                Case "colIRInspectionsCancelled"
                    Return "[IRInspectionsCancelled]"
                Case "colIRInpectionsDueStatisticId"
                    Return "[IRInpectionsDueStatisticId]"
                Case "colIRInpectionsCompletedStatisticId"
                    Return "[IRInpectionsCompletedStatisticId]"
                Case "colIRInpectionsPendingStatisticId"
                    Return "[IRInpectionsPendingStatisticId]"
                Case "colIRInpectionsCancelledStatisticId"
                    Return "[IRInpectionsCancelledStatisticId]"
                Case "colIRInspectionsDueFilter"
                    Return "[IRInspectionsDueFilter]"
                Case "colIRInspectionsCompleteFilter"
                    Return "[IRInspectionsCompleteFilter]"
                Case "colIRInspectionsPendingFilter"
                    Return "[IRInspectionsPendingFilter]"
                Case "colIRInspectionsCancelledFilter"
                    Return "[IRInspectionsCancelledFilter]"
                Case "colIRInpectionsDueLabel"
                    Return "[IRInpectionsDueLabel]"
                Case "colIRInpectionsCompletedLabel"
                    Return "[IRInpectionsCompletedLabel]"
                Case "colIRInpectionsPendingLabel"
                    Return "[IRInpectionsPendingLabel]"
                Case "colIRInpectionsCancelledLabel"
                    Return "[IRInpectionsCancelledLabel]"
                Case "colNatHazInspectionsDue"
                    Return "[NatHazInspectionsDue]"
                Case "colNatHazInspectionsComplete"
                    Return "[NatHazInspectionsComplete]"
                Case "colNatHazInspectionsPending"
                    Return "[NatHazInspectionsPending]"
                Case "colNatHazInspectionsCancelled"
                    Return "[NatHazInspectionsCancelled]"
                Case "colNatHazInpectionsDueStatisticId"
                    Return "[NatHazInpectionsDueStatisticId]"
                Case "colNatHazInpectionsCompletedStatisticId"
                    Return "[NatHazInpectionsCompletedStatisticId]"
                Case "colNatHazInpectionsPendingStatisticId"
                    Return "[NatHazInpectionsPendingStatisticId]"
                Case "colNatHazInpectionsCancelledStatisticId"
                    Return "[NatHazInpectionsCancelledStatisticId]"
                Case "colNatHazInspectionsDueFilter"
                    Return "[NatHazInspectionsDueFilter]"
                Case "colNatHazInspectionsCompleteFilter"
                    Return "[NatHazInspectionsCompleteFilter]"
                Case "colNatHazInspectionsPendingFilter"
                    Return "[NatHazInspectionsPendingFilter]"
                Case "colNatHazInspectionsCancelledFilter"
                    Return "[NatHazInspectionsCancelledFilter]"
                Case "colNatHazInpectionsDueLabel"
                    Return "[NatHazInpectionsDueLabel]"
                Case "colNatHazInpectionsCompletedLabel"
                    Return "[NatHazInpectionsCompletedLabel]"
                Case "colNatHazInpectionsPendingLabel"
                    Return "[NatHazInpectionsPendingLabel]"
                Case "colNatHazInpectionsCancelledLabel"
                    Return "[NatHazInpectionsCancelledLabel]"
                Case "colWindInspectionsDue"
                    Return "[WindInspectionsDue]"
                Case "colWindInspectionsComplete"
                    Return "[WindInspectionsComplete]"
                Case "colWindInspectionsPending"
                    Return "[WindInspectionsPending]"
                Case "colWindInspectionsCancelled"
                    Return "[WindInspectionsCancelled]"
                Case "colNatHazWindInpectionsDueStatisticId"
                    Return "[NatHazWindInpectionsDueStatisticId]"
                Case "colNatHazWindInpectionsCompletedStatisticId"
                    Return "[NatHazWindInpectionsCompletedStatisticId]"
                Case "colNatHazWindInpectionsPendingStatisticId"
                    Return "[NatHazWindInpectionsPendingStatisticId]"
                Case "colNatHazWindInpectionsCancelledStatisticId"
                    Return "[NatHazWindInpectionsCancelledStatisticId]"
                Case "colNatHazWindInspectionsDueFilter"
                    Return "[NatHazWindInspectionsDueFilter]"
                Case "colNatHazWindInspectionsCompleteFilter"
                    Return "[NatHazWindInspectionsCompleteFilter]"
                Case "colNatHazWindInspectionsPendingFilter"
                    Return "[NatHazWindInspectionsPendingFilter]"
                Case "colNatHazWindInspectionsCancelledFilter"
                    Return "[NatHazWindInspectionsCancelledFilter]"
                Case "colNatHazWindInpectionsDueLabel"
                    Return "[NatHazWindInpectionsDueLabel]"
                Case "colNatHazWindInpectionsCompletedLabel"
                    Return "[NatHazWindInpectionsCompletedLabel]"
                Case "colNatHazWindInpectionsPendingLabel"
                    Return "[NatHazWindInpectionsPendingLabel]"
                Case "colNatHazWindInpectionsCancelledLabel"
                    Return "[NatHazWindInpectionsCancelledLabel]"
                Case "colSeismicInspectionsDue"
                    Return "[SeismicInspectionsDue]"
                Case "colSeismicInspectionsComplete"
                    Return "[SeismicInspectionsComplete]"
                Case "colSeismicInspectionsPending"
                    Return "[SeismicInspectionsPending]"
                Case "colSeismicInspectionsCancelled"
                    Return "[SeismicInspectionsCancelled]"
                Case "colNatHazSeismicInpectionsDueStatisticId"
                    Return "[NatHazSeismicInpectionsDueStatisticId]"
                Case "colNatHazSeismicInpectionsCompletedStatisticId"
                    Return "[NatHazSeismicInpectionsCompletedStatisticId]"
                Case "colNatHazSeismicInpectionsPendingStatisticId"
                    Return "[NatHazSeismicInpectionsPendingStatisticId]"
                Case "colNatHazSeismicInpectionsCancelledStatisticId"
                    Return "[NatHazSeismicInpectionsCancelledStatisticId]"
                Case "colNatHazSeismicInspectionsDueFilter"
                    Return "[NatHazSeismicInspectionsDueFilter]"
                Case "colNatHazSeismicInspectionsCompleteFilter"
                    Return "[NatHazSeismicInspectionsCompleteFilter]"
                Case "colNatHazSeismicInspectionsPendingFilter"
                    Return "[NatHazSeismicInspectionsPendingFilter]"
                Case "colNatHazSeismicInspectionsCancelledFilter"
                    Return "[NatHazSeismicInspectionsCancelledFilter]"
                Case "colNatHazSeismicInpectionsDueLabel"
                    Return "[NatHazSeismicInpectionsDueLabel]"
                Case "colNatHazSeismicInpectionsCompletedLabel"
                    Return "[NatHazSeismicInpectionsCompletedLabel]"
                Case "colNatHazSeismicInpectionsPendingLabel"
                    Return "[NatHazSeismicInpectionsPendingLabel]"
                Case "colNatHazSeismicInpectionsCancelledLabel"
                    Return "[NatHazSeismicInpectionsCancelledLabel]"
                Case "colFloodInspectionsDue"
                    Return "[FloodInspectionsDue]"
                Case "colFloodInspectionsComplete"
                    Return "[FloodInspectionsComplete]"
                Case "colFloodInspectionsPending"
                    Return "[FloodInspectionsPending]"
                Case "colFloodInspectionsCancelled"
                    Return "[FloodInspectionsCancelled]"
                Case "colNatHazFloodInpectionsDueStatisticId"
                    Return "[NatHazFloodInpectionsDueStatisticId]"
                Case "colNatHazFloodInpectionsCompletedStatisticId"
                    Return "[NatHazFloodInpectionsCompletedStatisticId]"
                Case "colNatHazFloodInpectionsPendingStatisticId"
                    Return "[NatHazFloodInpectionsPendingStatisticId]"
                Case "colNatHazFloodInpectionsCancelledStatisticId"
                    Return "[NatHazFloodInpectionsCancelledStatisticId]"
                Case "colNatHazFloodInspectionsDueFilter"
                    Return "[NatHazFloodInspectionsDueFilter]"
                Case "colNatHazFloodInspectionsCompleteFilter"
                    Return "[NatHazFloodInspectionsCompleteFilter]"
                Case "colNatHazFloodInspectionsPendingFilter"
                    Return "[NatHazFloodInspectionsPendingFilter]"
                Case "colNatHazFloodInspectionsCancelledFilter"
                    Return "[NatHazFloodInspectionsCancelledFilter]"
                Case "colNatHazFloodInpectionsDueLabel"
                    Return "[NatHazFloodInpectionsDueLabel]"
                Case "colNatHazFloodInpectionsCompletedLabel"
                    Return "[NatHazFloodInpectionsCompletedLabel]"
                Case "colNatHazFloodInpectionsPendingLabel"
                    Return "[NatHazFloodInpectionsPendingLabel]"
                Case "colNatHazFloodInpectionsCancelledLabel"
                    Return "[NatHazFloodInpectionsCancelledLabel]"
                Case "colJurisNoObjections"
                    Return "[JurisNoObjections]"
                Case "colJurisOpenViolations"
                    Return "[JurisOpenViolations]"
                Case "colJurisNoActiveObjections"
                    Return "[JurisNoActiveObjections]"
                Case "colJurisObjectsStatisticId"
                    Return "[JurisObjectsStatisticId]"
                Case "colJurisActiveObjectsStatisticId"
                    Return "[JurisActiveObjectsStatisticId]"
                Case "colJurisOpenRecommendationsStatisticId"
                    Return "[JurisOpenRecommendationsStatisticId]"
                Case "colJurisObjectsFilter"
                    Return "[JurisObjectsFilter]"
                Case "colJurisActiveObjectsFilter"
                    Return "[JurisActiveObjectsFilter]"
                Case "colJurisOpenRecommendationsFilter"
                    Return "[JurisOpenRecommendationsFilter]"
                Case "colJurisObjectsLabel"
                    Return "[JurisObjectsLabel]"
                Case "colJurisActiveObjectsLabel"
                    Return "[JurisActiveObjectsLabel]"
                Case "colJurisOpenRecommendationsLabel"
                    Return "[JurisOpenRecommendationsLabel]"
                Case "colDivServInspectionsDue"
                    Return "[DivServInspectionsDue]"
                Case "colDivServInspectionsComplete"
                    Return "[DivServInspectionsComplete]"
                Case "colDivServInspectionsPending"
                    Return "[DivServInspectionsPending]"
                Case "colDivServInspectionsCancelled"
                    Return "[DivServInspectionsCancelled]"
                Case "colDivServInpectionsDueStatisticId"
                    Return "[DivServInpectionsDueStatisticId]"
                Case "colDivServInpectionsCompletedStatisticId"
                    Return "[DivServInpectionsCompletedStatisticId]"
                Case "colDivServInpectionsPendingStatisticId"
                    Return "[DivServInpectionsPendingStatisticId]"
                Case "colDivServInpectionsCancelledStatisticId"
                    Return "[DivServInpectionsCancelledStatisticId]"
                Case "colDivServInspectionsDueFilter"
                    Return "[DivServInspectionsDueFilter]"
                Case "colDivServInspectionsCompleteFilter"
                    Return "[DivServInspectionsCompleteFilter]"
                Case "colDivServInspectionsPendingFilter"
                    Return "[DivServInspectionsPendingFilter]"
                Case "colDivServInspectionsCancelledFilter"
                    Return "[DivServInspectionsCancelledFilter]"
                Case "colDivServInpectionsDueLabel"
                    Return "[DivServInpectionsDueLabel]"
                Case "colDivServInpectionsCompletedLabel"
                    Return "[DivServInpectionsCompletedLabel]"
                Case "colDivServInpectionsPendingLabel"
                    Return "[DivServInpectionsPendingLabel]"
                Case "colDivServInpectionsCancelledLabel"
                    Return "[DivServInpectionsCancelledLabel]"
                Case "colPSInspectionsDue"
                    Return "[PSInspectionsDue]"
                Case "colPSInspectionsComplete"
                    Return "[PSInspectionsComplete]"
                Case "colPSInspectionsPending"
                    Return "[PSInspectionsPending]"
                Case "colPSInspectionsCancelled"
                    Return "[PSInspectionsCancelled]"
                Case "colPSInpectionsDueStatisticId"
                    Return "[PSInpectionsDueStatisticId]"
                Case "colPSInpectionsCompletedStatisticId"
                    Return "[PSInpectionsCompletedStatisticId]"
                Case "colPSInpectionsPendingStatisticId"
                    Return "[PSInpectionsPendingStatisticId]"
                Case "colPSInpectionsCancelledStatisticId"
                    Return "[PSInpectionsCancelledStatisticId]"
                Case "colPSInspectionsDueFilter"
                    Return "[PSInspectionsDueFilter]"
                Case "colPSInspectionsCompleteFilter"
                    Return "[PSInspectionsCompleteFilter]"
                Case "colPSInspectionsPendingFilter"
                    Return "[PSInspectionsPendingFilter]"
                Case "colPSInspectionsCancelledFilter"
                    Return "[PSInspectionsCancelledFilter]"
                Case "colPSInpectionsDueLabel"
                    Return "[PSInpectionsDueLabel]"
                Case "colPsInpectionsCompletedLabel"
                    Return "[PsInpectionsCompletedLabel]"
                Case "colPSInpectionsPendingLabel"
                    Return "[PSInpectionsPendingLabel]"
                Case "colPSInpectionsCancelledLabel"
                    Return "[PSInpectionsCancelledLabel]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[GSafeGUID]", "GSafeGUID", "GSafeGUID", "colGSafeGUID"  
                    Return "colGSafeGUID"
                Case "[FireInspectionsDue]", "FireInspectionsDue", "FireInspectionsDue", "colFireInspectionsDue"  
                    Return "colFireInspectionsDue"
                Case "[FireInspectionsComplete]", "FireInspectionsComplete", "FireInspectionsComplete", "colFireInspectionsComplete"  
                    Return "colFireInspectionsComplete"
                Case "[FireInspectionsPending]", "FireInspectionsPending", "FireInspectionsPending", "colFireInspectionsPending"  
                    Return "colFireInspectionsPending"
                Case "[FireInspectionsCancelled]", "FireInspectionsCancelled", "FireInspectionsCancelled", "colFireInspectionsCancelled"  
                    Return "colFireInspectionsCancelled"
                Case "[FireInpectionsDueStatisticId]", "FireInpectionsDueStatisticId", "FireInpectionsDueStatisticId", "colFireInpectionsDueStatisticId"  
                    Return "colFireInpectionsDueStatisticId"
                Case "[FireInpectionsCompletedStatisticId]", "FireInpectionsCompletedStatisticId", "FireInpectionsCompletedStatisticId", "colFireInpectionsCompletedStatisticId"  
                    Return "colFireInpectionsCompletedStatisticId"
                Case "[FireInpectionsPendingStatisticId]", "FireInpectionsPendingStatisticId", "FireInpectionsPendingStatisticId", "colFireInpectionsPendingStatisticId"  
                    Return "colFireInpectionsPendingStatisticId"
                Case "[FireInpectionsCancelledStatisticId]", "FireInpectionsCancelledStatisticId", "FireInpectionsCancelledStatisticId", "colFireInpectionsCancelledStatisticId"  
                    Return "colFireInpectionsCancelledStatisticId"
                Case "[FireInspectionsDueFilter]", "FireInspectionsDueFilter", "FireInspectionsDueFilter", "colFireInspectionsDueFilter"  
                    Return "colFireInspectionsDueFilter"
                Case "[FireInspectionsCompleteFilter]", "FireInspectionsCompleteFilter", "FireInspectionsCompleteFilter", "colFireInspectionsCompleteFilter"  
                    Return "colFireInspectionsCompleteFilter"
                Case "[FireInspectionsPendingFilter]", "FireInspectionsPendingFilter", "FireInspectionsPendingFilter", "colFireInspectionsPendingFilter"  
                    Return "colFireInspectionsPendingFilter"
                Case "[FireInspectionsCancelledFilter]", "FireInspectionsCancelledFilter", "FireInspectionsCancelledFilter", "colFireInspectionsCancelledFilter"  
                    Return "colFireInspectionsCancelledFilter"
                Case "[FireInpectionsDueLabel]", "FireInpectionsDueLabel", "FireInpectionsDueLabel", "colFireInpectionsDueLabel"  
                    Return "colFireInpectionsDueLabel"
                Case "[FireInpectionsCompletedLabel]", "FireInpectionsCompletedLabel", "FireInpectionsCompletedLabel", "colFireInpectionsCompletedLabel"  
                    Return "colFireInpectionsCompletedLabel"
                Case "[FireInpectionsPendingLabel]", "FireInpectionsPendingLabel", "FireInpectionsPendingLabel", "colFireInpectionsPendingLabel"  
                    Return "colFireInpectionsPendingLabel"
                Case "[FireInpectionsCancelledLabel]", "FireInpectionsCancelledLabel", "FireInpectionsCancelledLabel", "colFireInpectionsCancelledLabel"  
                    Return "colFireInpectionsCancelledLabel"
                Case "[BMInspectionsDue]", "BMInspectionsDue", "BMInspectionsDue", "colBMInspectionsDue"  
                    Return "colBMInspectionsDue"
                Case "[BMInspectionsComplete]", "BMInspectionsComplete", "BMInspectionsComplete", "colBMInspectionsComplete"  
                    Return "colBMInspectionsComplete"
                Case "[BMInspectionsPending]", "BMInspectionsPending", "BMInspectionsPending", "colBMInspectionsPending"  
                    Return "colBMInspectionsPending"
                Case "[BMInspectionsCancelled]", "BMInspectionsCancelled", "BMInspectionsCancelled", "colBMInspectionsCancelled"  
                    Return "colBMInspectionsCancelled"
                Case "[BMInpectionsDueStatisticId]", "BMInpectionsDueStatisticId", "BMInpectionsDueStatisticId", "colBMInpectionsDueStatisticId"  
                    Return "colBMInpectionsDueStatisticId"
                Case "[BMInpectionsCompletedStatisticId]", "BMInpectionsCompletedStatisticId", "BMInpectionsCompletedStatisticId", "colBMInpectionsCompletedStatisticId"  
                    Return "colBMInpectionsCompletedStatisticId"
                Case "[BMInpectionsPendingStatisticId]", "BMInpectionsPendingStatisticId", "BMInpectionsPendingStatisticId", "colBMInpectionsPendingStatisticId"  
                    Return "colBMInpectionsPendingStatisticId"
                Case "[BMInpectionsCancelledStatisticId]", "BMInpectionsCancelledStatisticId", "BMInpectionsCancelledStatisticId", "colBMInpectionsCancelledStatisticId"  
                    Return "colBMInpectionsCancelledStatisticId"
                Case "[BMInspectionsDueFilter]", "BMInspectionsDueFilter", "BMInspectionsDueFilter", "colBMInspectionsDueFilter"  
                    Return "colBMInspectionsDueFilter"
                Case "[BMInspectionsCompleteFilter]", "BMInspectionsCompleteFilter", "BMInspectionsCompleteFilter", "colBMInspectionsCompleteFilter"  
                    Return "colBMInspectionsCompleteFilter"
                Case "[BMInspectionsPendingFilter]", "BMInspectionsPendingFilter", "BMInspectionsPendingFilter", "colBMInspectionsPendingFilter"  
                    Return "colBMInspectionsPendingFilter"
                Case "[BMInspectionsCancelledFilter]", "BMInspectionsCancelledFilter", "BMInspectionsCancelledFilter", "colBMInspectionsCancelledFilter"  
                    Return "colBMInspectionsCancelledFilter"
                Case "[BMInpectionsDueLabel]", "BMInpectionsDueLabel", "BMInpectionsDueLabel", "colBMInpectionsDueLabel"  
                    Return "colBMInpectionsDueLabel"
                Case "[BMInpectionsCompletedLabel]", "BMInpectionsCompletedLabel", "BMInpectionsCompletedLabel", "colBMInpectionsCompletedLabel"  
                    Return "colBMInpectionsCompletedLabel"
                Case "[BMInpectionsPendingLabel]", "BMInpectionsPendingLabel", "BMInpectionsPendingLabel", "colBMInpectionsPendingLabel"  
                    Return "colBMInpectionsPendingLabel"
                Case "[BMInpectionsCancelledLabel]", "BMInpectionsCancelledLabel", "BMInpectionsCancelledLabel", "colBMInpectionsCancelledLabel"  
                    Return "colBMInpectionsCancelledLabel"
                Case "[IRInspectionsDue]", "IRInspectionsDue", "IRInspectionsDue", "colIRInspectionsDue"  
                    Return "colIRInspectionsDue"
                Case "[IRInspectionsComplete]", "IRInspectionsComplete", "IRInspectionsComplete", "colIRInspectionsComplete"  
                    Return "colIRInspectionsComplete"
                Case "[IRInspectionsPending]", "IRInspectionsPending", "IRInspectionsPending", "colIRInspectionsPending"  
                    Return "colIRInspectionsPending"
                Case "[IRInspectionsCancelled]", "IRInspectionsCancelled", "IRInspectionsCancelled", "colIRInspectionsCancelled"  
                    Return "colIRInspectionsCancelled"
                Case "[IRInpectionsDueStatisticId]", "IRInpectionsDueStatisticId", "IRInpectionsDueStatisticId", "colIRInpectionsDueStatisticId"  
                    Return "colIRInpectionsDueStatisticId"
                Case "[IRInpectionsCompletedStatisticId]", "IRInpectionsCompletedStatisticId", "IRInpectionsCompletedStatisticId", "colIRInpectionsCompletedStatisticId"  
                    Return "colIRInpectionsCompletedStatisticId"
                Case "[IRInpectionsPendingStatisticId]", "IRInpectionsPendingStatisticId", "IRInpectionsPendingStatisticId", "colIRInpectionsPendingStatisticId"  
                    Return "colIRInpectionsPendingStatisticId"
                Case "[IRInpectionsCancelledStatisticId]", "IRInpectionsCancelledStatisticId", "IRInpectionsCancelledStatisticId", "colIRInpectionsCancelledStatisticId"  
                    Return "colIRInpectionsCancelledStatisticId"
                Case "[IRInspectionsDueFilter]", "IRInspectionsDueFilter", "IRInspectionsDueFilter", "colIRInspectionsDueFilter"  
                    Return "colIRInspectionsDueFilter"
                Case "[IRInspectionsCompleteFilter]", "IRInspectionsCompleteFilter", "IRInspectionsCompleteFilter", "colIRInspectionsCompleteFilter"  
                    Return "colIRInspectionsCompleteFilter"
                Case "[IRInspectionsPendingFilter]", "IRInspectionsPendingFilter", "IRInspectionsPendingFilter", "colIRInspectionsPendingFilter"  
                    Return "colIRInspectionsPendingFilter"
                Case "[IRInspectionsCancelledFilter]", "IRInspectionsCancelledFilter", "IRInspectionsCancelledFilter", "colIRInspectionsCancelledFilter"  
                    Return "colIRInspectionsCancelledFilter"
                Case "[IRInpectionsDueLabel]", "IRInpectionsDueLabel", "IRInpectionsDueLabel", "colIRInpectionsDueLabel"  
                    Return "colIRInpectionsDueLabel"
                Case "[IRInpectionsCompletedLabel]", "IRInpectionsCompletedLabel", "IRInpectionsCompletedLabel", "colIRInpectionsCompletedLabel"  
                    Return "colIRInpectionsCompletedLabel"
                Case "[IRInpectionsPendingLabel]", "IRInpectionsPendingLabel", "IRInpectionsPendingLabel", "colIRInpectionsPendingLabel"  
                    Return "colIRInpectionsPendingLabel"
                Case "[IRInpectionsCancelledLabel]", "IRInpectionsCancelledLabel", "IRInpectionsCancelledLabel", "colIRInpectionsCancelledLabel"  
                    Return "colIRInpectionsCancelledLabel"
                Case "[NatHazInspectionsDue]", "NatHazInspectionsDue", "NatHazInspectionsDue", "colNatHazInspectionsDue"  
                    Return "colNatHazInspectionsDue"
                Case "[NatHazInspectionsComplete]", "NatHazInspectionsComplete", "NatHazInspectionsComplete", "colNatHazInspectionsComplete"  
                    Return "colNatHazInspectionsComplete"
                Case "[NatHazInspectionsPending]", "NatHazInspectionsPending", "NatHazInspectionsPending", "colNatHazInspectionsPending"  
                    Return "colNatHazInspectionsPending"
                Case "[NatHazInspectionsCancelled]", "NatHazInspectionsCancelled", "NatHazInspectionsCancelled", "colNatHazInspectionsCancelled"  
                    Return "colNatHazInspectionsCancelled"
                Case "[NatHazInpectionsDueStatisticId]", "NatHazInpectionsDueStatisticId", "NatHazInpectionsDueStatisticId", "colNatHazInpectionsDueStatisticId"  
                    Return "colNatHazInpectionsDueStatisticId"
                Case "[NatHazInpectionsCompletedStatisticId]", "NatHazInpectionsCompletedStatisticId", "NatHazInpectionsCompletedStatisticId", "colNatHazInpectionsCompletedStatisticId"  
                    Return "colNatHazInpectionsCompletedStatisticId"
                Case "[NatHazInpectionsPendingStatisticId]", "NatHazInpectionsPendingStatisticId", "NatHazInpectionsPendingStatisticId", "colNatHazInpectionsPendingStatisticId"  
                    Return "colNatHazInpectionsPendingStatisticId"
                Case "[NatHazInpectionsCancelledStatisticId]", "NatHazInpectionsCancelledStatisticId", "NatHazInpectionsCancelledStatisticId", "colNatHazInpectionsCancelledStatisticId"  
                    Return "colNatHazInpectionsCancelledStatisticId"
                Case "[NatHazInspectionsDueFilter]", "NatHazInspectionsDueFilter", "NatHazInspectionsDueFilter", "colNatHazInspectionsDueFilter"  
                    Return "colNatHazInspectionsDueFilter"
                Case "[NatHazInspectionsCompleteFilter]", "NatHazInspectionsCompleteFilter", "NatHazInspectionsCompleteFilter", "colNatHazInspectionsCompleteFilter"  
                    Return "colNatHazInspectionsCompleteFilter"
                Case "[NatHazInspectionsPendingFilter]", "NatHazInspectionsPendingFilter", "NatHazInspectionsPendingFilter", "colNatHazInspectionsPendingFilter"  
                    Return "colNatHazInspectionsPendingFilter"
                Case "[NatHazInspectionsCancelledFilter]", "NatHazInspectionsCancelledFilter", "NatHazInspectionsCancelledFilter", "colNatHazInspectionsCancelledFilter"  
                    Return "colNatHazInspectionsCancelledFilter"
                Case "[NatHazInpectionsDueLabel]", "NatHazInpectionsDueLabel", "NatHazInpectionsDueLabel", "colNatHazInpectionsDueLabel"  
                    Return "colNatHazInpectionsDueLabel"
                Case "[NatHazInpectionsCompletedLabel]", "NatHazInpectionsCompletedLabel", "NatHazInpectionsCompletedLabel", "colNatHazInpectionsCompletedLabel"  
                    Return "colNatHazInpectionsCompletedLabel"
                Case "[NatHazInpectionsPendingLabel]", "NatHazInpectionsPendingLabel", "NatHazInpectionsPendingLabel", "colNatHazInpectionsPendingLabel"  
                    Return "colNatHazInpectionsPendingLabel"
                Case "[NatHazInpectionsCancelledLabel]", "NatHazInpectionsCancelledLabel", "NatHazInpectionsCancelledLabel", "colNatHazInpectionsCancelledLabel"  
                    Return "colNatHazInpectionsCancelledLabel"
                Case "[WindInspectionsDue]", "WindInspectionsDue", "WindInspectionsDue", "colWindInspectionsDue"  
                    Return "colWindInspectionsDue"
                Case "[WindInspectionsComplete]", "WindInspectionsComplete", "WindInspectionsComplete", "colWindInspectionsComplete"  
                    Return "colWindInspectionsComplete"
                Case "[WindInspectionsPending]", "WindInspectionsPending", "WindInspectionsPending", "colWindInspectionsPending"  
                    Return "colWindInspectionsPending"
                Case "[WindInspectionsCancelled]", "WindInspectionsCancelled", "WindInspectionsCancelled", "colWindInspectionsCancelled"  
                    Return "colWindInspectionsCancelled"
                Case "[NatHazWindInpectionsDueStatisticId]", "NatHazWindInpectionsDueStatisticId", "NatHazWindInpectionsDueStatisticId", "colNatHazWindInpectionsDueStatisticId"  
                    Return "colNatHazWindInpectionsDueStatisticId"
                Case "[NatHazWindInpectionsCompletedStatisticId]", "NatHazWindInpectionsCompletedStatisticId", "NatHazWindInpectionsCompletedStatisticId", "colNatHazWindInpectionsCompletedStatisticId"  
                    Return "colNatHazWindInpectionsCompletedStatisticId"
                Case "[NatHazWindInpectionsPendingStatisticId]", "NatHazWindInpectionsPendingStatisticId", "NatHazWindInpectionsPendingStatisticId", "colNatHazWindInpectionsPendingStatisticId"  
                    Return "colNatHazWindInpectionsPendingStatisticId"
                Case "[NatHazWindInpectionsCancelledStatisticId]", "NatHazWindInpectionsCancelledStatisticId", "NatHazWindInpectionsCancelledStatisticId", "colNatHazWindInpectionsCancelledStatisticId"  
                    Return "colNatHazWindInpectionsCancelledStatisticId"
                Case "[NatHazWindInspectionsDueFilter]", "NatHazWindInspectionsDueFilter", "NatHazWindInspectionsDueFilter", "colNatHazWindInspectionsDueFilter"  
                    Return "colNatHazWindInspectionsDueFilter"
                Case "[NatHazWindInspectionsCompleteFilter]", "NatHazWindInspectionsCompleteFilter", "NatHazWindInspectionsCompleteFilter", "colNatHazWindInspectionsCompleteFilter"  
                    Return "colNatHazWindInspectionsCompleteFilter"
                Case "[NatHazWindInspectionsPendingFilter]", "NatHazWindInspectionsPendingFilter", "NatHazWindInspectionsPendingFilter", "colNatHazWindInspectionsPendingFilter"  
                    Return "colNatHazWindInspectionsPendingFilter"
                Case "[NatHazWindInspectionsCancelledFilter]", "NatHazWindInspectionsCancelledFilter", "NatHazWindInspectionsCancelledFilter", "colNatHazWindInspectionsCancelledFilter"  
                    Return "colNatHazWindInspectionsCancelledFilter"
                Case "[NatHazWindInpectionsDueLabel]", "NatHazWindInpectionsDueLabel", "NatHazWindInpectionsDueLabel", "colNatHazWindInpectionsDueLabel"  
                    Return "colNatHazWindInpectionsDueLabel"
                Case "[NatHazWindInpectionsCompletedLabel]", "NatHazWindInpectionsCompletedLabel", "NatHazWindInpectionsCompletedLabel", "colNatHazWindInpectionsCompletedLabel"  
                    Return "colNatHazWindInpectionsCompletedLabel"
                Case "[NatHazWindInpectionsPendingLabel]", "NatHazWindInpectionsPendingLabel", "NatHazWindInpectionsPendingLabel", "colNatHazWindInpectionsPendingLabel"  
                    Return "colNatHazWindInpectionsPendingLabel"
                Case "[NatHazWindInpectionsCancelledLabel]", "NatHazWindInpectionsCancelledLabel", "NatHazWindInpectionsCancelledLabel", "colNatHazWindInpectionsCancelledLabel"  
                    Return "colNatHazWindInpectionsCancelledLabel"
                Case "[SeismicInspectionsDue]", "SeismicInspectionsDue", "SeismicInspectionsDue", "colSeismicInspectionsDue"  
                    Return "colSeismicInspectionsDue"
                Case "[SeismicInspectionsComplete]", "SeismicInspectionsComplete", "SeismicInspectionsComplete", "colSeismicInspectionsComplete"  
                    Return "colSeismicInspectionsComplete"
                Case "[SeismicInspectionsPending]", "SeismicInspectionsPending", "SeismicInspectionsPending", "colSeismicInspectionsPending"  
                    Return "colSeismicInspectionsPending"
                Case "[SeismicInspectionsCancelled]", "SeismicInspectionsCancelled", "SeismicInspectionsCancelled", "colSeismicInspectionsCancelled"  
                    Return "colSeismicInspectionsCancelled"
                Case "[NatHazSeismicInpectionsDueStatisticId]", "NatHazSeismicInpectionsDueStatisticId", "NatHazSeismicInpectionsDueStatisticId", "colNatHazSeismicInpectionsDueStatisticId"  
                    Return "colNatHazSeismicInpectionsDueStatisticId"
                Case "[NatHazSeismicInpectionsCompletedStatisticId]", "NatHazSeismicInpectionsCompletedStatisticId", "NatHazSeismicInpectionsCompletedStatisticId", "colNatHazSeismicInpectionsCompletedStatisticId"  
                    Return "colNatHazSeismicInpectionsCompletedStatisticId"
                Case "[NatHazSeismicInpectionsPendingStatisticId]", "NatHazSeismicInpectionsPendingStatisticId", "NatHazSeismicInpectionsPendingStatisticId", "colNatHazSeismicInpectionsPendingStatisticId"  
                    Return "colNatHazSeismicInpectionsPendingStatisticId"
                Case "[NatHazSeismicInpectionsCancelledStatisticId]", "NatHazSeismicInpectionsCancelledStatisticId", "NatHazSeismicInpectionsCancelledStatisticId", "colNatHazSeismicInpectionsCancelledStatisticId"  
                    Return "colNatHazSeismicInpectionsCancelledStatisticId"
                Case "[NatHazSeismicInspectionsDueFilter]", "NatHazSeismicInspectionsDueFilter", "NatHazSeismicInspectionsDueFilter", "colNatHazSeismicInspectionsDueFilter"  
                    Return "colNatHazSeismicInspectionsDueFilter"
                Case "[NatHazSeismicInspectionsCompleteFilter]", "NatHazSeismicInspectionsCompleteFilter", "NatHazSeismicInspectionsCompleteFilter", "colNatHazSeismicInspectionsCompleteFilter"  
                    Return "colNatHazSeismicInspectionsCompleteFilter"
                Case "[NatHazSeismicInspectionsPendingFilter]", "NatHazSeismicInspectionsPendingFilter", "NatHazSeismicInspectionsPendingFilter", "colNatHazSeismicInspectionsPendingFilter"  
                    Return "colNatHazSeismicInspectionsPendingFilter"
                Case "[NatHazSeismicInspectionsCancelledFilter]", "NatHazSeismicInspectionsCancelledFilter", "NatHazSeismicInspectionsCancelledFilter", "colNatHazSeismicInspectionsCancelledFilter"  
                    Return "colNatHazSeismicInspectionsCancelledFilter"
                Case "[NatHazSeismicInpectionsDueLabel]", "NatHazSeismicInpectionsDueLabel", "NatHazSeismicInpectionsDueLabel", "colNatHazSeismicInpectionsDueLabel"  
                    Return "colNatHazSeismicInpectionsDueLabel"
                Case "[NatHazSeismicInpectionsCompletedLabel]", "NatHazSeismicInpectionsCompletedLabel", "NatHazSeismicInpectionsCompletedLabel", "colNatHazSeismicInpectionsCompletedLabel"  
                    Return "colNatHazSeismicInpectionsCompletedLabel"
                Case "[NatHazSeismicInpectionsPendingLabel]", "NatHazSeismicInpectionsPendingLabel", "NatHazSeismicInpectionsPendingLabel", "colNatHazSeismicInpectionsPendingLabel"  
                    Return "colNatHazSeismicInpectionsPendingLabel"
                Case "[NatHazSeismicInpectionsCancelledLabel]", "NatHazSeismicInpectionsCancelledLabel", "NatHazSeismicInpectionsCancelledLabel", "colNatHazSeismicInpectionsCancelledLabel"  
                    Return "colNatHazSeismicInpectionsCancelledLabel"
                Case "[FloodInspectionsDue]", "FloodInspectionsDue", "FloodInspectionsDue", "colFloodInspectionsDue"  
                    Return "colFloodInspectionsDue"
                Case "[FloodInspectionsComplete]", "FloodInspectionsComplete", "FloodInspectionsComplete", "colFloodInspectionsComplete"  
                    Return "colFloodInspectionsComplete"
                Case "[FloodInspectionsPending]", "FloodInspectionsPending", "FloodInspectionsPending", "colFloodInspectionsPending"  
                    Return "colFloodInspectionsPending"
                Case "[FloodInspectionsCancelled]", "FloodInspectionsCancelled", "FloodInspectionsCancelled", "colFloodInspectionsCancelled"  
                    Return "colFloodInspectionsCancelled"
                Case "[NatHazFloodInpectionsDueStatisticId]", "NatHazFloodInpectionsDueStatisticId", "NatHazFloodInpectionsDueStatisticId", "colNatHazFloodInpectionsDueStatisticId"  
                    Return "colNatHazFloodInpectionsDueStatisticId"
                Case "[NatHazFloodInpectionsCompletedStatisticId]", "NatHazFloodInpectionsCompletedStatisticId", "NatHazFloodInpectionsCompletedStatisticId", "colNatHazFloodInpectionsCompletedStatisticId"  
                    Return "colNatHazFloodInpectionsCompletedStatisticId"
                Case "[NatHazFloodInpectionsPendingStatisticId]", "NatHazFloodInpectionsPendingStatisticId", "NatHazFloodInpectionsPendingStatisticId", "colNatHazFloodInpectionsPendingStatisticId"  
                    Return "colNatHazFloodInpectionsPendingStatisticId"
                Case "[NatHazFloodInpectionsCancelledStatisticId]", "NatHazFloodInpectionsCancelledStatisticId", "NatHazFloodInpectionsCancelledStatisticId", "colNatHazFloodInpectionsCancelledStatisticId"  
                    Return "colNatHazFloodInpectionsCancelledStatisticId"
                Case "[NatHazFloodInspectionsDueFilter]", "NatHazFloodInspectionsDueFilter", "NatHazFloodInspectionsDueFilter", "colNatHazFloodInspectionsDueFilter"  
                    Return "colNatHazFloodInspectionsDueFilter"
                Case "[NatHazFloodInspectionsCompleteFilter]", "NatHazFloodInspectionsCompleteFilter", "NatHazFloodInspectionsCompleteFilter", "colNatHazFloodInspectionsCompleteFilter"  
                    Return "colNatHazFloodInspectionsCompleteFilter"
                Case "[NatHazFloodInspectionsPendingFilter]", "NatHazFloodInspectionsPendingFilter", "NatHazFloodInspectionsPendingFilter", "colNatHazFloodInspectionsPendingFilter"  
                    Return "colNatHazFloodInspectionsPendingFilter"
                Case "[NatHazFloodInspectionsCancelledFilter]", "NatHazFloodInspectionsCancelledFilter", "NatHazFloodInspectionsCancelledFilter", "colNatHazFloodInspectionsCancelledFilter"  
                    Return "colNatHazFloodInspectionsCancelledFilter"
                Case "[NatHazFloodInpectionsDueLabel]", "NatHazFloodInpectionsDueLabel", "NatHazFloodInpectionsDueLabel", "colNatHazFloodInpectionsDueLabel"  
                    Return "colNatHazFloodInpectionsDueLabel"
                Case "[NatHazFloodInpectionsCompletedLabel]", "NatHazFloodInpectionsCompletedLabel", "NatHazFloodInpectionsCompletedLabel", "colNatHazFloodInpectionsCompletedLabel"  
                    Return "colNatHazFloodInpectionsCompletedLabel"
                Case "[NatHazFloodInpectionsPendingLabel]", "NatHazFloodInpectionsPendingLabel", "NatHazFloodInpectionsPendingLabel", "colNatHazFloodInpectionsPendingLabel"  
                    Return "colNatHazFloodInpectionsPendingLabel"
                Case "[NatHazFloodInpectionsCancelledLabel]", "NatHazFloodInpectionsCancelledLabel", "NatHazFloodInpectionsCancelledLabel", "colNatHazFloodInpectionsCancelledLabel"  
                    Return "colNatHazFloodInpectionsCancelledLabel"
                Case "[JurisNoObjections]", "JurisNoObjections", "JurisNoObjections", "colJurisNoObjections"  
                    Return "colJurisNoObjections"
                Case "[JurisOpenViolations]", "JurisOpenViolations", "JurisOpenViolations", "colJurisOpenViolations"  
                    Return "colJurisOpenViolations"
                Case "[JurisNoActiveObjections]", "JurisNoActiveObjections", "JurisNoActiveObjections", "colJurisNoActiveObjections"  
                    Return "colJurisNoActiveObjections"
                Case "[JurisObjectsStatisticId]", "JurisObjectsStatisticId", "JurisObjectsStatisticId", "colJurisObjectsStatisticId"  
                    Return "colJurisObjectsStatisticId"
                Case "[JurisActiveObjectsStatisticId]", "JurisActiveObjectsStatisticId", "JurisActiveObjectsStatisticId", "colJurisActiveObjectsStatisticId"  
                    Return "colJurisActiveObjectsStatisticId"
                Case "[JurisOpenRecommendationsStatisticId]", "JurisOpenRecommendationsStatisticId", "JurisOpenRecommendationsStatisticId", "colJurisOpenRecommendationsStatisticId"  
                    Return "colJurisOpenRecommendationsStatisticId"
                Case "[JurisObjectsFilter]", "JurisObjectsFilter", "JurisObjectsFilter", "colJurisObjectsFilter"  
                    Return "colJurisObjectsFilter"
                Case "[JurisActiveObjectsFilter]", "JurisActiveObjectsFilter", "JurisActiveObjectsFilter", "colJurisActiveObjectsFilter"  
                    Return "colJurisActiveObjectsFilter"
                Case "[JurisOpenRecommendationsFilter]", "JurisOpenRecommendationsFilter", "JurisOpenRecommendationsFilter", "colJurisOpenRecommendationsFilter"  
                    Return "colJurisOpenRecommendationsFilter"
                Case "[JurisObjectsLabel]", "JurisObjectsLabel", "JurisObjectsLabel", "colJurisObjectsLabel"  
                    Return "colJurisObjectsLabel"
                Case "[JurisActiveObjectsLabel]", "JurisActiveObjectsLabel", "JurisActiveObjectsLabel", "colJurisActiveObjectsLabel"  
                    Return "colJurisActiveObjectsLabel"
                Case "[JurisOpenRecommendationsLabel]", "JurisOpenRecommendationsLabel", "JurisOpenRecommendationsLabel", "colJurisOpenRecommendationsLabel"  
                    Return "colJurisOpenRecommendationsLabel"
                Case "[DivServInspectionsDue]", "DivServInspectionsDue", "DivServInspectionsDue", "colDivServInspectionsDue"  
                    Return "colDivServInspectionsDue"
                Case "[DivServInspectionsComplete]", "DivServInspectionsComplete", "DivServInspectionsComplete", "colDivServInspectionsComplete"  
                    Return "colDivServInspectionsComplete"
                Case "[DivServInspectionsPending]", "DivServInspectionsPending", "DivServInspectionsPending", "colDivServInspectionsPending"  
                    Return "colDivServInspectionsPending"
                Case "[DivServInspectionsCancelled]", "DivServInspectionsCancelled", "DivServInspectionsCancelled", "colDivServInspectionsCancelled"  
                    Return "colDivServInspectionsCancelled"
                Case "[DivServInpectionsDueStatisticId]", "DivServInpectionsDueStatisticId", "DivServInpectionsDueStatisticId", "colDivServInpectionsDueStatisticId"  
                    Return "colDivServInpectionsDueStatisticId"
                Case "[DivServInpectionsCompletedStatisticId]", "DivServInpectionsCompletedStatisticId", "DivServInpectionsCompletedStatisticId", "colDivServInpectionsCompletedStatisticId"  
                    Return "colDivServInpectionsCompletedStatisticId"
                Case "[DivServInpectionsPendingStatisticId]", "DivServInpectionsPendingStatisticId", "DivServInpectionsPendingStatisticId", "colDivServInpectionsPendingStatisticId"  
                    Return "colDivServInpectionsPendingStatisticId"
                Case "[DivServInpectionsCancelledStatisticId]", "DivServInpectionsCancelledStatisticId", "DivServInpectionsCancelledStatisticId", "colDivServInpectionsCancelledStatisticId"  
                    Return "colDivServInpectionsCancelledStatisticId"
                Case "[DivServInspectionsDueFilter]", "DivServInspectionsDueFilter", "DivServInspectionsDueFilter", "colDivServInspectionsDueFilter"  
                    Return "colDivServInspectionsDueFilter"
                Case "[DivServInspectionsCompleteFilter]", "DivServInspectionsCompleteFilter", "DivServInspectionsCompleteFilter", "colDivServInspectionsCompleteFilter"  
                    Return "colDivServInspectionsCompleteFilter"
                Case "[DivServInspectionsPendingFilter]", "DivServInspectionsPendingFilter", "DivServInspectionsPendingFilter", "colDivServInspectionsPendingFilter"  
                    Return "colDivServInspectionsPendingFilter"
                Case "[DivServInspectionsCancelledFilter]", "DivServInspectionsCancelledFilter", "DivServInspectionsCancelledFilter", "colDivServInspectionsCancelledFilter"  
                    Return "colDivServInspectionsCancelledFilter"
                Case "[DivServInpectionsDueLabel]", "DivServInpectionsDueLabel", "DivServInpectionsDueLabel", "colDivServInpectionsDueLabel"  
                    Return "colDivServInpectionsDueLabel"
                Case "[DivServInpectionsCompletedLabel]", "DivServInpectionsCompletedLabel", "DivServInpectionsCompletedLabel", "colDivServInpectionsCompletedLabel"  
                    Return "colDivServInpectionsCompletedLabel"
                Case "[DivServInpectionsPendingLabel]", "DivServInpectionsPendingLabel", "DivServInpectionsPendingLabel", "colDivServInpectionsPendingLabel"  
                    Return "colDivServInpectionsPendingLabel"
                Case "[DivServInpectionsCancelledLabel]", "DivServInpectionsCancelledLabel", "DivServInpectionsCancelledLabel", "colDivServInpectionsCancelledLabel"  
                    Return "colDivServInpectionsCancelledLabel"
                Case "[PSInspectionsDue]", "PSInspectionsDue", "PSInspectionsDue", "colPSInspectionsDue"  
                    Return "colPSInspectionsDue"
                Case "[PSInspectionsComplete]", "PSInspectionsComplete", "PSInspectionsComplete", "colPSInspectionsComplete"  
                    Return "colPSInspectionsComplete"
                Case "[PSInspectionsPending]", "PSInspectionsPending", "PSInspectionsPending", "colPSInspectionsPending"  
                    Return "colPSInspectionsPending"
                Case "[PSInspectionsCancelled]", "PSInspectionsCancelled", "PSInspectionsCancelled", "colPSInspectionsCancelled"  
                    Return "colPSInspectionsCancelled"
                Case "[PSInpectionsDueStatisticId]", "PSInpectionsDueStatisticId", "PSInpectionsDueStatisticId", "colPSInpectionsDueStatisticId"  
                    Return "colPSInpectionsDueStatisticId"
                Case "[PSInpectionsCompletedStatisticId]", "PSInpectionsCompletedStatisticId", "PSInpectionsCompletedStatisticId", "colPSInpectionsCompletedStatisticId"  
                    Return "colPSInpectionsCompletedStatisticId"
                Case "[PSInpectionsPendingStatisticId]", "PSInpectionsPendingStatisticId", "PSInpectionsPendingStatisticId", "colPSInpectionsPendingStatisticId"  
                    Return "colPSInpectionsPendingStatisticId"
                Case "[PSInpectionsCancelledStatisticId]", "PSInpectionsCancelledStatisticId", "PSInpectionsCancelledStatisticId", "colPSInpectionsCancelledStatisticId"  
                    Return "colPSInpectionsCancelledStatisticId"
                Case "[PSInspectionsDueFilter]", "PSInspectionsDueFilter", "PSInspectionsDueFilter", "colPSInspectionsDueFilter"  
                    Return "colPSInspectionsDueFilter"
                Case "[PSInspectionsCompleteFilter]", "PSInspectionsCompleteFilter", "PSInspectionsCompleteFilter", "colPSInspectionsCompleteFilter"  
                    Return "colPSInspectionsCompleteFilter"
                Case "[PSInspectionsPendingFilter]", "PSInspectionsPendingFilter", "PSInspectionsPendingFilter", "colPSInspectionsPendingFilter"  
                    Return "colPSInspectionsPendingFilter"
                Case "[PSInspectionsCancelledFilter]", "PSInspectionsCancelledFilter", "PSInspectionsCancelledFilter", "colPSInspectionsCancelledFilter"  
                    Return "colPSInspectionsCancelledFilter"
                Case "[PSInpectionsDueLabel]", "PSInpectionsDueLabel", "PSInpectionsDueLabel", "colPSInpectionsDueLabel"  
                    Return "colPSInpectionsDueLabel"
                Case "[PsInpectionsCompletedLabel]", "PsInpectionsCompletedLabel", "PsInpectionsCompletedLabel", "colPsInpectionsCompletedLabel"  
                    Return "colPsInpectionsCompletedLabel"
                Case "[PSInpectionsPendingLabel]", "PSInpectionsPendingLabel", "PSInpectionsPendingLabel", "colPSInpectionsPendingLabel"  
                    Return "colPSInpectionsPendingLabel"
                Case "[PSInpectionsCancelledLabel]", "PSInpectionsCancelledLabel", "PSInpectionsCancelledLabel", "colPSInpectionsCancelledLabel"  
                    Return "colPSInpectionsCancelledLabel"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "String"
                Case "colGSafeGUID"
                    Return "String"
                Case "colFireInspectionsDue"
                    Return "String"
                Case "colFireInspectionsComplete"
                    Return "String"
                Case "colFireInspectionsPending"
                    Return "String"
                Case "colFireInspectionsCancelled"
                    Return "String"
                Case "colFireInpectionsDueStatisticId"
                    Return "String"
                Case "colFireInpectionsCompletedStatisticId"
                    Return "String"
                Case "colFireInpectionsPendingStatisticId"
                    Return "String"
                Case "colFireInpectionsCancelledStatisticId"
                    Return "String"
                Case "colFireInspectionsDueFilter"
                    Return "String"
                Case "colFireInspectionsCompleteFilter"
                    Return "String"
                Case "colFireInspectionsPendingFilter"
                    Return "String"
                Case "colFireInspectionsCancelledFilter"
                    Return "String"
                Case "colFireInpectionsDueLabel"
                    Return "String"
                Case "colFireInpectionsCompletedLabel"
                    Return "String"
                Case "colFireInpectionsPendingLabel"
                    Return "String"
                Case "colFireInpectionsCancelledLabel"
                    Return "String"
                Case "colBMInspectionsDue"
                    Return "String"
                Case "colBMInspectionsComplete"
                    Return "String"
                Case "colBMInspectionsPending"
                    Return "String"
                Case "colBMInspectionsCancelled"
                    Return "String"
                Case "colBMInpectionsDueStatisticId"
                    Return "String"
                Case "colBMInpectionsCompletedStatisticId"
                    Return "String"
                Case "colBMInpectionsPendingStatisticId"
                    Return "String"
                Case "colBMInpectionsCancelledStatisticId"
                    Return "String"
                Case "colBMInspectionsDueFilter"
                    Return "String"
                Case "colBMInspectionsCompleteFilter"
                    Return "String"
                Case "colBMInspectionsPendingFilter"
                    Return "String"
                Case "colBMInspectionsCancelledFilter"
                    Return "String"
                Case "colBMInpectionsDueLabel"
                    Return "String"
                Case "colBMInpectionsCompletedLabel"
                    Return "String"
                Case "colBMInpectionsPendingLabel"
                    Return "String"
                Case "colBMInpectionsCancelledLabel"
                    Return "String"
                Case "colIRInspectionsDue"
                    Return "String"
                Case "colIRInspectionsComplete"
                    Return "String"
                Case "colIRInspectionsPending"
                    Return "String"
                Case "colIRInspectionsCancelled"
                    Return "String"
                Case "colIRInpectionsDueStatisticId"
                    Return "String"
                Case "colIRInpectionsCompletedStatisticId"
                    Return "String"
                Case "colIRInpectionsPendingStatisticId"
                    Return "String"
                Case "colIRInpectionsCancelledStatisticId"
                    Return "String"
                Case "colIRInspectionsDueFilter"
                    Return "String"
                Case "colIRInspectionsCompleteFilter"
                    Return "String"
                Case "colIRInspectionsPendingFilter"
                    Return "String"
                Case "colIRInspectionsCancelledFilter"
                    Return "String"
                Case "colIRInpectionsDueLabel"
                    Return "String"
                Case "colIRInpectionsCompletedLabel"
                    Return "String"
                Case "colIRInpectionsPendingLabel"
                    Return "String"
                Case "colIRInpectionsCancelledLabel"
                    Return "String"
                Case "colNatHazInspectionsDue"
                    Return "String"
                Case "colNatHazInspectionsComplete"
                    Return "String"
                Case "colNatHazInspectionsPending"
                    Return "String"
                Case "colNatHazInspectionsCancelled"
                    Return "String"
                Case "colNatHazInpectionsDueStatisticId"
                    Return "String"
                Case "colNatHazInpectionsCompletedStatisticId"
                    Return "String"
                Case "colNatHazInpectionsPendingStatisticId"
                    Return "String"
                Case "colNatHazInpectionsCancelledStatisticId"
                    Return "String"
                Case "colNatHazInspectionsDueFilter"
                    Return "String"
                Case "colNatHazInspectionsCompleteFilter"
                    Return "String"
                Case "colNatHazInspectionsPendingFilter"
                    Return "String"
                Case "colNatHazInspectionsCancelledFilter"
                    Return "String"
                Case "colNatHazInpectionsDueLabel"
                    Return "String"
                Case "colNatHazInpectionsCompletedLabel"
                    Return "String"
                Case "colNatHazInpectionsPendingLabel"
                    Return "String"
                Case "colNatHazInpectionsCancelledLabel"
                    Return "String"
                Case "colWindInspectionsDue"
                    Return "String"
                Case "colWindInspectionsComplete"
                    Return "String"
                Case "colWindInspectionsPending"
                    Return "String"
                Case "colWindInspectionsCancelled"
                    Return "String"
                Case "colNatHazWindInpectionsDueStatisticId"
                    Return "String"
                Case "colNatHazWindInpectionsCompletedStatisticId"
                    Return "String"
                Case "colNatHazWindInpectionsPendingStatisticId"
                    Return "String"
                Case "colNatHazWindInpectionsCancelledStatisticId"
                    Return "String"
                Case "colNatHazWindInspectionsDueFilter"
                    Return "String"
                Case "colNatHazWindInspectionsCompleteFilter"
                    Return "String"
                Case "colNatHazWindInspectionsPendingFilter"
                    Return "String"
                Case "colNatHazWindInspectionsCancelledFilter"
                    Return "String"
                Case "colNatHazWindInpectionsDueLabel"
                    Return "String"
                Case "colNatHazWindInpectionsCompletedLabel"
                    Return "String"
                Case "colNatHazWindInpectionsPendingLabel"
                    Return "String"
                Case "colNatHazWindInpectionsCancelledLabel"
                    Return "String"
                Case "colSeismicInspectionsDue"
                    Return "String"
                Case "colSeismicInspectionsComplete"
                    Return "String"
                Case "colSeismicInspectionsPending"
                    Return "String"
                Case "colSeismicInspectionsCancelled"
                    Return "String"
                Case "colNatHazSeismicInpectionsDueStatisticId"
                    Return "String"
                Case "colNatHazSeismicInpectionsCompletedStatisticId"
                    Return "String"
                Case "colNatHazSeismicInpectionsPendingStatisticId"
                    Return "String"
                Case "colNatHazSeismicInpectionsCancelledStatisticId"
                    Return "String"
                Case "colNatHazSeismicInspectionsDueFilter"
                    Return "String"
                Case "colNatHazSeismicInspectionsCompleteFilter"
                    Return "String"
                Case "colNatHazSeismicInspectionsPendingFilter"
                    Return "String"
                Case "colNatHazSeismicInspectionsCancelledFilter"
                    Return "String"
                Case "colNatHazSeismicInpectionsDueLabel"
                    Return "String"
                Case "colNatHazSeismicInpectionsCompletedLabel"
                    Return "String"
                Case "colNatHazSeismicInpectionsPendingLabel"
                    Return "String"
                Case "colNatHazSeismicInpectionsCancelledLabel"
                    Return "String"
                Case "colFloodInspectionsDue"
                    Return "String"
                Case "colFloodInspectionsComplete"
                    Return "String"
                Case "colFloodInspectionsPending"
                    Return "String"
                Case "colFloodInspectionsCancelled"
                    Return "String"
                Case "colNatHazFloodInpectionsDueStatisticId"
                    Return "String"
                Case "colNatHazFloodInpectionsCompletedStatisticId"
                    Return "String"
                Case "colNatHazFloodInpectionsPendingStatisticId"
                    Return "String"
                Case "colNatHazFloodInpectionsCancelledStatisticId"
                    Return "String"
                Case "colNatHazFloodInspectionsDueFilter"
                    Return "String"
                Case "colNatHazFloodInspectionsCompleteFilter"
                    Return "String"
                Case "colNatHazFloodInspectionsPendingFilter"
                    Return "String"
                Case "colNatHazFloodInspectionsCancelledFilter"
                    Return "String"
                Case "colNatHazFloodInpectionsDueLabel"
                    Return "String"
                Case "colNatHazFloodInpectionsCompletedLabel"
                    Return "String"
                Case "colNatHazFloodInpectionsPendingLabel"
                    Return "String"
                Case "colNatHazFloodInpectionsCancelledLabel"
                    Return "String"
                Case "colJurisNoObjections"
                    Return "String"
                Case "colJurisOpenViolations"
                    Return "String"
                Case "colJurisNoActiveObjections"
                    Return "String"
                Case "colJurisObjectsStatisticId"
                    Return "String"
                Case "colJurisActiveObjectsStatisticId"
                    Return "String"
                Case "colJurisOpenRecommendationsStatisticId"
                    Return "String"
                Case "colJurisObjectsFilter"
                    Return "String"
                Case "colJurisActiveObjectsFilter"
                    Return "String"
                Case "colJurisOpenRecommendationsFilter"
                    Return "String"
                Case "colJurisObjectsLabel"
                    Return "String"
                Case "colJurisActiveObjectsLabel"
                    Return "String"
                Case "colJurisOpenRecommendationsLabel"
                    Return "String"
                Case "colDivServInspectionsDue"
                    Return "String"
                Case "colDivServInspectionsComplete"
                    Return "String"
                Case "colDivServInspectionsPending"
                    Return "String"
                Case "colDivServInspectionsCancelled"
                    Return "String"
                Case "colDivServInpectionsDueStatisticId"
                    Return "String"
                Case "colDivServInpectionsCompletedStatisticId"
                    Return "String"
                Case "colDivServInpectionsPendingStatisticId"
                    Return "String"
                Case "colDivServInpectionsCancelledStatisticId"
                    Return "String"
                Case "colDivServInspectionsDueFilter"
                    Return "String"
                Case "colDivServInspectionsCompleteFilter"
                    Return "String"
                Case "colDivServInspectionsPendingFilter"
                    Return "String"
                Case "colDivServInspectionsCancelledFilter"
                    Return "String"
                Case "colDivServInpectionsDueLabel"
                    Return "String"
                Case "colDivServInpectionsCompletedLabel"
                    Return "String"
                Case "colDivServInpectionsPendingLabel"
                    Return "String"
                Case "colDivServInpectionsCancelledLabel"
                    Return "String"
                Case "colPSInspectionsDue"
                    Return "String"
                Case "colPSInspectionsComplete"
                    Return "String"
                Case "colPSInspectionsPending"
                    Return "String"
                Case "colPSInspectionsCancelled"
                    Return "String"
                Case "colPSInpectionsDueStatisticId"
                    Return "String"
                Case "colPSInpectionsCompletedStatisticId"
                    Return "String"
                Case "colPSInpectionsPendingStatisticId"
                    Return "String"
                Case "colPSInpectionsCancelledStatisticId"
                    Return "String"
                Case "colPSInspectionsDueFilter"
                    Return "String"
                Case "colPSInspectionsCompleteFilter"
                    Return "String"
                Case "colPSInspectionsPendingFilter"
                    Return "String"
                Case "colPSInspectionsCancelledFilter"
                    Return "String"
                Case "colPSInpectionsDueLabel"
                    Return "String"
                Case "colPsInpectionsCompletedLabel"
                    Return "String"
                Case "colPSInpectionsPendingLabel"
                    Return "String"
                Case "colPSInpectionsCancelledLabel"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[viewCCGaugeStats]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

