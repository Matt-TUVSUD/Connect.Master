'/===============================================================\
'| razor data (experimental) - rev 4.2.881   EXPERIMENTAL        |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'|  Data Types not supported due to type mapping issues: money,  |
'| date, varchar(1), nvarchar(1)                                 |
'\===============================================================/
Imports System.Data.SqlClient

Namespace razor
    Partial Public Class ViewCCGaugeStats

        Public Shared Function LoadData() As List(Of rowViewCCGaugeStats)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowViewCCGaugeStats)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowViewCCGaugeStats)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowViewCCGaugeStats)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCGaugeStats)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand)
            Return LoadData(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object)
            Return LoadData(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction)
            Return LoadData(pCommand,pTransaction,Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowViewCCGaugeStats)
            Dim zReturn As New List(Of rowViewCCGaugeStats)
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCGaugeStats]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowViewCCGaugeStats)

			Try
	            Dim zReturn As New List(Of rowViewCCGaugeStats)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowViewCCGaugeStats

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowViewCCGaugeStats		
	                            ReadDataRow(zReader,zObj)											
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn

			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next
				Throw
			End Try

        End function

        Public Shared Function ReadData(Of T)(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of T)

			Try
	            Dim zReturn As New List(Of T)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As Object = Activator.CreateInstance(Of T)()

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj  = Activator.CreateInstance(Of T)()	
	                            ReadDataRow(zReader,zObj)					
	                            zObj.RaiseLoadedEvent(pLoadEventUserState)
	                            zReturn.Add(zObj)
	                        End While			
	                    End If
	                End Using
	            End Using

	            zReader.Close()
	            zReader = Nothing

	            Return zReturn
			Catch ex As Exception
				ex.Data.Add("SQL", pCommand.CommandText)				
	            For Each pParameter As SqlClient.SqlParameter In pCommand.Parameters
					ex.Data.Add(pParameter.ParameterName, pParameter.Value)
		        Next				
				Throw
			End Try

        End function

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowViewCCGaugeStats)
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeGUID")) Then pObject.colGSafeGUID = UtilSQLServer.SafeReader.SafeReadString(pReader, "GSafeGUID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsDue")) Then pObject.colFireInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsComplete")) Then pObject.colFireInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsPending")) Then pObject.colFireInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsCancelled")) Then pObject.colFireInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsDueStatisticId")) Then pObject.colFireInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsCompletedStatisticId")) Then pObject.colFireInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsPendingStatisticId")) Then pObject.colFireInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsCancelledStatisticId")) Then pObject.colFireInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsDueFilter")) Then pObject.colFireInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsCompleteFilter")) Then pObject.colFireInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsPendingFilter")) Then pObject.colFireInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInspectionsCancelledFilter")) Then pObject.colFireInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsDueLabel")) Then pObject.colFireInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsCompletedLabel")) Then pObject.colFireInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsPendingLabel")) Then pObject.colFireInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FireInpectionsCancelledLabel")) Then pObject.colFireInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "FireInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsDue")) Then pObject.colBMInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsComplete")) Then pObject.colBMInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsPending")) Then pObject.colBMInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsCancelled")) Then pObject.colBMInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsDueStatisticId")) Then pObject.colBMInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsCompletedStatisticId")) Then pObject.colBMInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsPendingStatisticId")) Then pObject.colBMInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsCancelledStatisticId")) Then pObject.colBMInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsDueFilter")) Then pObject.colBMInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsCompleteFilter")) Then pObject.colBMInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsPendingFilter")) Then pObject.colBMInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInspectionsCancelledFilter")) Then pObject.colBMInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsDueLabel")) Then pObject.colBMInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsCompletedLabel")) Then pObject.colBMInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsPendingLabel")) Then pObject.colBMInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BMInpectionsCancelledLabel")) Then pObject.colBMInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "BMInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsDue")) Then pObject.colIRInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsComplete")) Then pObject.colIRInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsPending")) Then pObject.colIRInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsCancelled")) Then pObject.colIRInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsDueStatisticId")) Then pObject.colIRInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsCompletedStatisticId")) Then pObject.colIRInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsPendingStatisticId")) Then pObject.colIRInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsCancelledStatisticId")) Then pObject.colIRInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsDueFilter")) Then pObject.colIRInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsCompleteFilter")) Then pObject.colIRInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsPendingFilter")) Then pObject.colIRInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInspectionsCancelledFilter")) Then pObject.colIRInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsDueLabel")) Then pObject.colIRInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsCompletedLabel")) Then pObject.colIRInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsPendingLabel")) Then pObject.colIRInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IRInpectionsCancelledLabel")) Then pObject.colIRInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "IRInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsDue")) Then pObject.colNatHazInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsComplete")) Then pObject.colNatHazInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsPending")) Then pObject.colNatHazInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsCancelled")) Then pObject.colNatHazInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsDueStatisticId")) Then pObject.colNatHazInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsCompletedStatisticId")) Then pObject.colNatHazInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsPendingStatisticId")) Then pObject.colNatHazInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsCancelledStatisticId")) Then pObject.colNatHazInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsDueFilter")) Then pObject.colNatHazInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsCompleteFilter")) Then pObject.colNatHazInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsPendingFilter")) Then pObject.colNatHazInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInspectionsCancelledFilter")) Then pObject.colNatHazInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsDueLabel")) Then pObject.colNatHazInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsCompletedLabel")) Then pObject.colNatHazInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsPendingLabel")) Then pObject.colNatHazInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazInpectionsCancelledLabel")) Then pObject.colNatHazInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WindInspectionsDue")) Then pObject.colWindInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "WindInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WindInspectionsComplete")) Then pObject.colWindInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "WindInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WindInspectionsPending")) Then pObject.colWindInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "WindInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WindInspectionsCancelled")) Then pObject.colWindInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "WindInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsDueStatisticId")) Then pObject.colNatHazWindInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsCompletedStatisticId")) Then pObject.colNatHazWindInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsPendingStatisticId")) Then pObject.colNatHazWindInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsCancelledStatisticId")) Then pObject.colNatHazWindInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInspectionsDueFilter")) Then pObject.colNatHazWindInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInspectionsCompleteFilter")) Then pObject.colNatHazWindInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInspectionsPendingFilter")) Then pObject.colNatHazWindInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInspectionsCancelledFilter")) Then pObject.colNatHazWindInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsDueLabel")) Then pObject.colNatHazWindInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsCompletedLabel")) Then pObject.colNatHazWindInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsPendingLabel")) Then pObject.colNatHazWindInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazWindInpectionsCancelledLabel")) Then pObject.colNatHazWindInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazWindInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SeismicInspectionsDue")) Then pObject.colSeismicInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "SeismicInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SeismicInspectionsComplete")) Then pObject.colSeismicInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "SeismicInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SeismicInspectionsPending")) Then pObject.colSeismicInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "SeismicInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SeismicInspectionsCancelled")) Then pObject.colSeismicInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "SeismicInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsDueStatisticId")) Then pObject.colNatHazSeismicInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsCompletedStatisticId")) Then pObject.colNatHazSeismicInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsPendingStatisticId")) Then pObject.colNatHazSeismicInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsCancelledStatisticId")) Then pObject.colNatHazSeismicInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInspectionsDueFilter")) Then pObject.colNatHazSeismicInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInspectionsCompleteFilter")) Then pObject.colNatHazSeismicInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInspectionsPendingFilter")) Then pObject.colNatHazSeismicInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInspectionsCancelledFilter")) Then pObject.colNatHazSeismicInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsDueLabel")) Then pObject.colNatHazSeismicInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsCompletedLabel")) Then pObject.colNatHazSeismicInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsPendingLabel")) Then pObject.colNatHazSeismicInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazSeismicInpectionsCancelledLabel")) Then pObject.colNatHazSeismicInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazSeismicInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FloodInspectionsDue")) Then pObject.colFloodInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "FloodInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FloodInspectionsComplete")) Then pObject.colFloodInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "FloodInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FloodInspectionsPending")) Then pObject.colFloodInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "FloodInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FloodInspectionsCancelled")) Then pObject.colFloodInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "FloodInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsDueStatisticId")) Then pObject.colNatHazFloodInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsCompletedStatisticId")) Then pObject.colNatHazFloodInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsPendingStatisticId")) Then pObject.colNatHazFloodInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsCancelledStatisticId")) Then pObject.colNatHazFloodInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInspectionsDueFilter")) Then pObject.colNatHazFloodInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInspectionsCompleteFilter")) Then pObject.colNatHazFloodInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInspectionsPendingFilter")) Then pObject.colNatHazFloodInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInspectionsCancelledFilter")) Then pObject.colNatHazFloodInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsDueLabel")) Then pObject.colNatHazFloodInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsCompletedLabel")) Then pObject.colNatHazFloodInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsPendingLabel")) Then pObject.colNatHazFloodInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("NatHazFloodInpectionsCancelledLabel")) Then pObject.colNatHazFloodInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "NatHazFloodInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisNoObjections")) Then pObject.colJurisNoObjections = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisNoObjections")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisOpenViolations")) Then pObject.colJurisOpenViolations = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisOpenViolations")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisNoActiveObjections")) Then pObject.colJurisNoActiveObjections = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisNoActiveObjections")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisObjectsStatisticId")) Then pObject.colJurisObjectsStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisObjectsStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisActiveObjectsStatisticId")) Then pObject.colJurisActiveObjectsStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisActiveObjectsStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisOpenRecommendationsStatisticId")) Then pObject.colJurisOpenRecommendationsStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisOpenRecommendationsStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisObjectsFilter")) Then pObject.colJurisObjectsFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisObjectsFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisActiveObjectsFilter")) Then pObject.colJurisActiveObjectsFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisActiveObjectsFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisOpenRecommendationsFilter")) Then pObject.colJurisOpenRecommendationsFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisOpenRecommendationsFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisObjectsLabel")) Then pObject.colJurisObjectsLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisObjectsLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisActiveObjectsLabel")) Then pObject.colJurisActiveObjectsLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisActiveObjectsLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("JurisOpenRecommendationsLabel")) Then pObject.colJurisOpenRecommendationsLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "JurisOpenRecommendationsLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsDue")) Then pObject.colDivServInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsComplete")) Then pObject.colDivServInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsPending")) Then pObject.colDivServInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsCancelled")) Then pObject.colDivServInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsDueStatisticId")) Then pObject.colDivServInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsCompletedStatisticId")) Then pObject.colDivServInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsPendingStatisticId")) Then pObject.colDivServInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsCancelledStatisticId")) Then pObject.colDivServInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsDueFilter")) Then pObject.colDivServInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsCompleteFilter")) Then pObject.colDivServInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsPendingFilter")) Then pObject.colDivServInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInspectionsCancelledFilter")) Then pObject.colDivServInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsDueLabel")) Then pObject.colDivServInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsCompletedLabel")) Then pObject.colDivServInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsPendingLabel")) Then pObject.colDivServInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("DivServInpectionsCancelledLabel")) Then pObject.colDivServInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "DivServInpectionsCancelledLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsDue")) Then pObject.colPSInspectionsDue = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsDue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsComplete")) Then pObject.colPSInspectionsComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsPending")) Then pObject.colPSInspectionsPending = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsPending")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsCancelled")) Then pObject.colPSInspectionsCancelled = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsCancelled")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsDueStatisticId")) Then pObject.colPSInpectionsDueStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsDueStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsCompletedStatisticId")) Then pObject.colPSInpectionsCompletedStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsCompletedStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsPendingStatisticId")) Then pObject.colPSInpectionsPendingStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsPendingStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsCancelledStatisticId")) Then pObject.colPSInpectionsCancelledStatisticId = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsCancelledStatisticId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsDueFilter")) Then pObject.colPSInspectionsDueFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsDueFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsCompleteFilter")) Then pObject.colPSInspectionsCompleteFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsCompleteFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsPendingFilter")) Then pObject.colPSInspectionsPendingFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsPendingFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInspectionsCancelledFilter")) Then pObject.colPSInspectionsCancelledFilter = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInspectionsCancelledFilter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsDueLabel")) Then pObject.colPSInpectionsDueLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsDueLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PsInpectionsCompletedLabel")) Then pObject.colPsInpectionsCompletedLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "PsInpectionsCompletedLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsPendingLabel")) Then pObject.colPSInpectionsPendingLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsPendingLabel")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PSInpectionsCancelledLabel")) Then pObject.colPSInpectionsCancelledLabel = UtilSQLServer.SafeReader.SafeReadString(pReader, "PSInpectionsCancelledLabel")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"


        Public Shared Function LoadData(Of T)(pSQL As String) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(Of T)(zCmd, pTransaction, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)() As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(New SqlClient.SqlCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pLoadEventUserState As Object) As List(Of T)
            Return LoadData(Of T)(pCommand, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadData(Of T)(pCommand, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(Of T)(pCommand As SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[viewCCGaugeStats]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowViewCCGaugeStats
        Implements IrowViewCCGaugeStats

        Public Event Loaded(pUserState As Object) Implements IrowViewCCGaugeStats.Loaded
        Public Event Saved(pUserState As Object) Implements IrowViewCCGaugeStats.Saved
        Public Event Deleted(pUserState As Object) Implements IrowViewCCGaugeStats.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowViewCCGaugeStats.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowViewCCGaugeStats.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowViewCCGaugeStats.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFilePrefix() As String Implements IrowViewCCGaugeStats.colFilePrefix
            Get
                Return m_colFilePrefix
            End Get
            Set
                If Not Same(m_colFilePrefix, Value) Then
                    m_colFilePrefix = Value
                    m_IsDirty(FieldIndex.colFilePrefix) = True
                End If
            End Set
        End Property
        Private m_colFilePrefix As String

        Public Property colGSafeGUID() As String Implements IrowViewCCGaugeStats.colGSafeGUID
            Get
                Return m_colGSafeGUID
            End Get
            Set
                If Not Same(m_colGSafeGUID, Value) Then
                    m_colGSafeGUID = Value
                    m_IsDirty(FieldIndex.colGSafeGUID) = True
                End If
            End Set
        End Property
        Private m_colGSafeGUID As String

        Public Property colFireInspectionsDue() As String Implements IrowViewCCGaugeStats.colFireInspectionsDue
            Get
                Return m_colFireInspectionsDue
            End Get
            Set
                If Not Same(m_colFireInspectionsDue, Value) Then
                    m_colFireInspectionsDue = Value
                    m_IsDirty(FieldIndex.colFireInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsDue As String

        Public Property colFireInspectionsComplete() As String Implements IrowViewCCGaugeStats.colFireInspectionsComplete
            Get
                Return m_colFireInspectionsComplete
            End Get
            Set
                If Not Same(m_colFireInspectionsComplete, Value) Then
                    m_colFireInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colFireInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsComplete As String

        Public Property colFireInspectionsPending() As String Implements IrowViewCCGaugeStats.colFireInspectionsPending
            Get
                Return m_colFireInspectionsPending
            End Get
            Set
                If Not Same(m_colFireInspectionsPending, Value) Then
                    m_colFireInspectionsPending = Value
                    m_IsDirty(FieldIndex.colFireInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsPending As String

        Public Property colFireInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colFireInspectionsCancelled
            Get
                Return m_colFireInspectionsCancelled
            End Get
            Set
                If Not Same(m_colFireInspectionsCancelled, Value) Then
                    m_colFireInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colFireInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsCancelled As String

        Public Property colFireInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colFireInpectionsDueStatisticId
            Get
                Return m_colFireInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colFireInpectionsDueStatisticId, Value) Then
                    m_colFireInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colFireInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsDueStatisticId As String

        Public Property colFireInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colFireInpectionsCompletedStatisticId
            Get
                Return m_colFireInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colFireInpectionsCompletedStatisticId, Value) Then
                    m_colFireInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colFireInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsCompletedStatisticId As String

        Public Property colFireInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colFireInpectionsPendingStatisticId
            Get
                Return m_colFireInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colFireInpectionsPendingStatisticId, Value) Then
                    m_colFireInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colFireInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsPendingStatisticId As String

        Public Property colFireInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colFireInpectionsCancelledStatisticId
            Get
                Return m_colFireInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colFireInpectionsCancelledStatisticId, Value) Then
                    m_colFireInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colFireInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsCancelledStatisticId As String

        Public Property colFireInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colFireInspectionsDueFilter
            Get
                Return m_colFireInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colFireInspectionsDueFilter, Value) Then
                    m_colFireInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colFireInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsDueFilter As String

        Public Property colFireInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colFireInspectionsCompleteFilter
            Get
                Return m_colFireInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colFireInspectionsCompleteFilter, Value) Then
                    m_colFireInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colFireInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsCompleteFilter As String

        Public Property colFireInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colFireInspectionsPendingFilter
            Get
                Return m_colFireInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colFireInspectionsPendingFilter, Value) Then
                    m_colFireInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colFireInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsPendingFilter As String

        Public Property colFireInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colFireInspectionsCancelledFilter
            Get
                Return m_colFireInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colFireInspectionsCancelledFilter, Value) Then
                    m_colFireInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colFireInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colFireInspectionsCancelledFilter As String

        Public Property colFireInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colFireInpectionsDueLabel
            Get
                Return m_colFireInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colFireInpectionsDueLabel, Value) Then
                    m_colFireInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colFireInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsDueLabel As String

        Public Property colFireInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colFireInpectionsCompletedLabel
            Get
                Return m_colFireInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colFireInpectionsCompletedLabel, Value) Then
                    m_colFireInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colFireInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsCompletedLabel As String

        Public Property colFireInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colFireInpectionsPendingLabel
            Get
                Return m_colFireInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colFireInpectionsPendingLabel, Value) Then
                    m_colFireInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colFireInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsPendingLabel As String

        Public Property colFireInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colFireInpectionsCancelledLabel
            Get
                Return m_colFireInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colFireInpectionsCancelledLabel, Value) Then
                    m_colFireInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colFireInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colFireInpectionsCancelledLabel As String

        Public Property colBMInspectionsDue() As String Implements IrowViewCCGaugeStats.colBMInspectionsDue
            Get
                Return m_colBMInspectionsDue
            End Get
            Set
                If Not Same(m_colBMInspectionsDue, Value) Then
                    m_colBMInspectionsDue = Value
                    m_IsDirty(FieldIndex.colBMInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsDue As String

        Public Property colBMInspectionsComplete() As String Implements IrowViewCCGaugeStats.colBMInspectionsComplete
            Get
                Return m_colBMInspectionsComplete
            End Get
            Set
                If Not Same(m_colBMInspectionsComplete, Value) Then
                    m_colBMInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colBMInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsComplete As String

        Public Property colBMInspectionsPending() As String Implements IrowViewCCGaugeStats.colBMInspectionsPending
            Get
                Return m_colBMInspectionsPending
            End Get
            Set
                If Not Same(m_colBMInspectionsPending, Value) Then
                    m_colBMInspectionsPending = Value
                    m_IsDirty(FieldIndex.colBMInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsPending As String

        Public Property colBMInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colBMInspectionsCancelled
            Get
                Return m_colBMInspectionsCancelled
            End Get
            Set
                If Not Same(m_colBMInspectionsCancelled, Value) Then
                    m_colBMInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colBMInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsCancelled As String

        Public Property colBMInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colBMInpectionsDueStatisticId
            Get
                Return m_colBMInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colBMInpectionsDueStatisticId, Value) Then
                    m_colBMInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colBMInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsDueStatisticId As String

        Public Property colBMInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colBMInpectionsCompletedStatisticId
            Get
                Return m_colBMInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colBMInpectionsCompletedStatisticId, Value) Then
                    m_colBMInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colBMInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsCompletedStatisticId As String

        Public Property colBMInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colBMInpectionsPendingStatisticId
            Get
                Return m_colBMInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colBMInpectionsPendingStatisticId, Value) Then
                    m_colBMInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colBMInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsPendingStatisticId As String

        Public Property colBMInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colBMInpectionsCancelledStatisticId
            Get
                Return m_colBMInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colBMInpectionsCancelledStatisticId, Value) Then
                    m_colBMInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colBMInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsCancelledStatisticId As String

        Public Property colBMInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colBMInspectionsDueFilter
            Get
                Return m_colBMInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colBMInspectionsDueFilter, Value) Then
                    m_colBMInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colBMInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsDueFilter As String

        Public Property colBMInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colBMInspectionsCompleteFilter
            Get
                Return m_colBMInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colBMInspectionsCompleteFilter, Value) Then
                    m_colBMInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colBMInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsCompleteFilter As String

        Public Property colBMInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colBMInspectionsPendingFilter
            Get
                Return m_colBMInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colBMInspectionsPendingFilter, Value) Then
                    m_colBMInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colBMInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsPendingFilter As String

        Public Property colBMInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colBMInspectionsCancelledFilter
            Get
                Return m_colBMInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colBMInspectionsCancelledFilter, Value) Then
                    m_colBMInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colBMInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colBMInspectionsCancelledFilter As String

        Public Property colBMInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colBMInpectionsDueLabel
            Get
                Return m_colBMInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colBMInpectionsDueLabel, Value) Then
                    m_colBMInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colBMInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsDueLabel As String

        Public Property colBMInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colBMInpectionsCompletedLabel
            Get
                Return m_colBMInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colBMInpectionsCompletedLabel, Value) Then
                    m_colBMInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colBMInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsCompletedLabel As String

        Public Property colBMInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colBMInpectionsPendingLabel
            Get
                Return m_colBMInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colBMInpectionsPendingLabel, Value) Then
                    m_colBMInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colBMInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsPendingLabel As String

        Public Property colBMInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colBMInpectionsCancelledLabel
            Get
                Return m_colBMInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colBMInpectionsCancelledLabel, Value) Then
                    m_colBMInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colBMInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colBMInpectionsCancelledLabel As String

        Public Property colIRInspectionsDue() As String Implements IrowViewCCGaugeStats.colIRInspectionsDue
            Get
                Return m_colIRInspectionsDue
            End Get
            Set
                If Not Same(m_colIRInspectionsDue, Value) Then
                    m_colIRInspectionsDue = Value
                    m_IsDirty(FieldIndex.colIRInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsDue As String

        Public Property colIRInspectionsComplete() As String Implements IrowViewCCGaugeStats.colIRInspectionsComplete
            Get
                Return m_colIRInspectionsComplete
            End Get
            Set
                If Not Same(m_colIRInspectionsComplete, Value) Then
                    m_colIRInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colIRInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsComplete As String

        Public Property colIRInspectionsPending() As String Implements IrowViewCCGaugeStats.colIRInspectionsPending
            Get
                Return m_colIRInspectionsPending
            End Get
            Set
                If Not Same(m_colIRInspectionsPending, Value) Then
                    m_colIRInspectionsPending = Value
                    m_IsDirty(FieldIndex.colIRInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsPending As String

        Public Property colIRInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colIRInspectionsCancelled
            Get
                Return m_colIRInspectionsCancelled
            End Get
            Set
                If Not Same(m_colIRInspectionsCancelled, Value) Then
                    m_colIRInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colIRInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsCancelled As String

        Public Property colIRInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colIRInpectionsDueStatisticId
            Get
                Return m_colIRInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colIRInpectionsDueStatisticId, Value) Then
                    m_colIRInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colIRInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsDueStatisticId As String

        Public Property colIRInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colIRInpectionsCompletedStatisticId
            Get
                Return m_colIRInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colIRInpectionsCompletedStatisticId, Value) Then
                    m_colIRInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colIRInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsCompletedStatisticId As String

        Public Property colIRInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colIRInpectionsPendingStatisticId
            Get
                Return m_colIRInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colIRInpectionsPendingStatisticId, Value) Then
                    m_colIRInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colIRInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsPendingStatisticId As String

        Public Property colIRInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colIRInpectionsCancelledStatisticId
            Get
                Return m_colIRInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colIRInpectionsCancelledStatisticId, Value) Then
                    m_colIRInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colIRInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsCancelledStatisticId As String

        Public Property colIRInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colIRInspectionsDueFilter
            Get
                Return m_colIRInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colIRInspectionsDueFilter, Value) Then
                    m_colIRInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colIRInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsDueFilter As String

        Public Property colIRInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colIRInspectionsCompleteFilter
            Get
                Return m_colIRInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colIRInspectionsCompleteFilter, Value) Then
                    m_colIRInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colIRInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsCompleteFilter As String

        Public Property colIRInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colIRInspectionsPendingFilter
            Get
                Return m_colIRInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colIRInspectionsPendingFilter, Value) Then
                    m_colIRInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colIRInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsPendingFilter As String

        Public Property colIRInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colIRInspectionsCancelledFilter
            Get
                Return m_colIRInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colIRInspectionsCancelledFilter, Value) Then
                    m_colIRInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colIRInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colIRInspectionsCancelledFilter As String

        Public Property colIRInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colIRInpectionsDueLabel
            Get
                Return m_colIRInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colIRInpectionsDueLabel, Value) Then
                    m_colIRInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colIRInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsDueLabel As String

        Public Property colIRInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colIRInpectionsCompletedLabel
            Get
                Return m_colIRInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colIRInpectionsCompletedLabel, Value) Then
                    m_colIRInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colIRInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsCompletedLabel As String

        Public Property colIRInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colIRInpectionsPendingLabel
            Get
                Return m_colIRInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colIRInpectionsPendingLabel, Value) Then
                    m_colIRInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colIRInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsPendingLabel As String

        Public Property colIRInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colIRInpectionsCancelledLabel
            Get
                Return m_colIRInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colIRInpectionsCancelledLabel, Value) Then
                    m_colIRInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colIRInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colIRInpectionsCancelledLabel As String

        Public Property colNatHazInspectionsDue() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsDue
            Get
                Return m_colNatHazInspectionsDue
            End Get
            Set
                If Not Same(m_colNatHazInspectionsDue, Value) Then
                    m_colNatHazInspectionsDue = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsDue As String

        Public Property colNatHazInspectionsComplete() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsComplete
            Get
                Return m_colNatHazInspectionsComplete
            End Get
            Set
                If Not Same(m_colNatHazInspectionsComplete, Value) Then
                    m_colNatHazInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsComplete As String

        Public Property colNatHazInspectionsPending() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsPending
            Get
                Return m_colNatHazInspectionsPending
            End Get
            Set
                If Not Same(m_colNatHazInspectionsPending, Value) Then
                    m_colNatHazInspectionsPending = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsPending As String

        Public Property colNatHazInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsCancelled
            Get
                Return m_colNatHazInspectionsCancelled
            End Get
            Set
                If Not Same(m_colNatHazInspectionsCancelled, Value) Then
                    m_colNatHazInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsCancelled As String

        Public Property colNatHazInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsDueStatisticId
            Get
                Return m_colNatHazInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colNatHazInpectionsDueStatisticId, Value) Then
                    m_colNatHazInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsDueStatisticId As String

        Public Property colNatHazInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsCompletedStatisticId
            Get
                Return m_colNatHazInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colNatHazInpectionsCompletedStatisticId, Value) Then
                    m_colNatHazInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsCompletedStatisticId As String

        Public Property colNatHazInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsPendingStatisticId
            Get
                Return m_colNatHazInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colNatHazInpectionsPendingStatisticId, Value) Then
                    m_colNatHazInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsPendingStatisticId As String

        Public Property colNatHazInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsCancelledStatisticId
            Get
                Return m_colNatHazInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colNatHazInpectionsCancelledStatisticId, Value) Then
                    m_colNatHazInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsCancelledStatisticId As String

        Public Property colNatHazInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsDueFilter
            Get
                Return m_colNatHazInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colNatHazInspectionsDueFilter, Value) Then
                    m_colNatHazInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsDueFilter As String

        Public Property colNatHazInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsCompleteFilter
            Get
                Return m_colNatHazInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colNatHazInspectionsCompleteFilter, Value) Then
                    m_colNatHazInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsCompleteFilter As String

        Public Property colNatHazInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsPendingFilter
            Get
                Return m_colNatHazInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colNatHazInspectionsPendingFilter, Value) Then
                    m_colNatHazInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsPendingFilter As String

        Public Property colNatHazInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colNatHazInspectionsCancelledFilter
            Get
                Return m_colNatHazInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colNatHazInspectionsCancelledFilter, Value) Then
                    m_colNatHazInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colNatHazInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazInspectionsCancelledFilter As String

        Public Property colNatHazInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsDueLabel
            Get
                Return m_colNatHazInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colNatHazInpectionsDueLabel, Value) Then
                    m_colNatHazInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsDueLabel As String

        Public Property colNatHazInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsCompletedLabel
            Get
                Return m_colNatHazInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colNatHazInpectionsCompletedLabel, Value) Then
                    m_colNatHazInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsCompletedLabel As String

        Public Property colNatHazInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsPendingLabel
            Get
                Return m_colNatHazInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colNatHazInpectionsPendingLabel, Value) Then
                    m_colNatHazInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsPendingLabel As String

        Public Property colNatHazInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colNatHazInpectionsCancelledLabel
            Get
                Return m_colNatHazInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colNatHazInpectionsCancelledLabel, Value) Then
                    m_colNatHazInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colNatHazInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazInpectionsCancelledLabel As String

        Public Property colWindInspectionsDue() As String Implements IrowViewCCGaugeStats.colWindInspectionsDue
            Get
                Return m_colWindInspectionsDue
            End Get
            Set
                If Not Same(m_colWindInspectionsDue, Value) Then
                    m_colWindInspectionsDue = Value
                    m_IsDirty(FieldIndex.colWindInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colWindInspectionsDue As String

        Public Property colWindInspectionsComplete() As String Implements IrowViewCCGaugeStats.colWindInspectionsComplete
            Get
                Return m_colWindInspectionsComplete
            End Get
            Set
                If Not Same(m_colWindInspectionsComplete, Value) Then
                    m_colWindInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colWindInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colWindInspectionsComplete As String

        Public Property colWindInspectionsPending() As String Implements IrowViewCCGaugeStats.colWindInspectionsPending
            Get
                Return m_colWindInspectionsPending
            End Get
            Set
                If Not Same(m_colWindInspectionsPending, Value) Then
                    m_colWindInspectionsPending = Value
                    m_IsDirty(FieldIndex.colWindInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colWindInspectionsPending As String

        Public Property colWindInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colWindInspectionsCancelled
            Get
                Return m_colWindInspectionsCancelled
            End Get
            Set
                If Not Same(m_colWindInspectionsCancelled, Value) Then
                    m_colWindInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colWindInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colWindInspectionsCancelled As String

        Public Property colNatHazWindInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsDueStatisticId
            Get
                Return m_colNatHazWindInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsDueStatisticId, Value) Then
                    m_colNatHazWindInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsDueStatisticId As String

        Public Property colNatHazWindInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsCompletedStatisticId
            Get
                Return m_colNatHazWindInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsCompletedStatisticId, Value) Then
                    m_colNatHazWindInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsCompletedStatisticId As String

        Public Property colNatHazWindInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsPendingStatisticId
            Get
                Return m_colNatHazWindInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsPendingStatisticId, Value) Then
                    m_colNatHazWindInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsPendingStatisticId As String

        Public Property colNatHazWindInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsCancelledStatisticId
            Get
                Return m_colNatHazWindInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsCancelledStatisticId, Value) Then
                    m_colNatHazWindInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsCancelledStatisticId As String

        Public Property colNatHazWindInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colNatHazWindInspectionsDueFilter
            Get
                Return m_colNatHazWindInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colNatHazWindInspectionsDueFilter, Value) Then
                    m_colNatHazWindInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colNatHazWindInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInspectionsDueFilter As String

        Public Property colNatHazWindInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colNatHazWindInspectionsCompleteFilter
            Get
                Return m_colNatHazWindInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colNatHazWindInspectionsCompleteFilter, Value) Then
                    m_colNatHazWindInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colNatHazWindInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInspectionsCompleteFilter As String

        Public Property colNatHazWindInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colNatHazWindInspectionsPendingFilter
            Get
                Return m_colNatHazWindInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colNatHazWindInspectionsPendingFilter, Value) Then
                    m_colNatHazWindInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colNatHazWindInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInspectionsPendingFilter As String

        Public Property colNatHazWindInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colNatHazWindInspectionsCancelledFilter
            Get
                Return m_colNatHazWindInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colNatHazWindInspectionsCancelledFilter, Value) Then
                    m_colNatHazWindInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colNatHazWindInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInspectionsCancelledFilter As String

        Public Property colNatHazWindInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsDueLabel
            Get
                Return m_colNatHazWindInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsDueLabel, Value) Then
                    m_colNatHazWindInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsDueLabel As String

        Public Property colNatHazWindInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsCompletedLabel
            Get
                Return m_colNatHazWindInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsCompletedLabel, Value) Then
                    m_colNatHazWindInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsCompletedLabel As String

        Public Property colNatHazWindInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsPendingLabel
            Get
                Return m_colNatHazWindInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsPendingLabel, Value) Then
                    m_colNatHazWindInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsPendingLabel As String

        Public Property colNatHazWindInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colNatHazWindInpectionsCancelledLabel
            Get
                Return m_colNatHazWindInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colNatHazWindInpectionsCancelledLabel, Value) Then
                    m_colNatHazWindInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colNatHazWindInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazWindInpectionsCancelledLabel As String

        Public Property colSeismicInspectionsDue() As String Implements IrowViewCCGaugeStats.colSeismicInspectionsDue
            Get
                Return m_colSeismicInspectionsDue
            End Get
            Set
                If Not Same(m_colSeismicInspectionsDue, Value) Then
                    m_colSeismicInspectionsDue = Value
                    m_IsDirty(FieldIndex.colSeismicInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colSeismicInspectionsDue As String

        Public Property colSeismicInspectionsComplete() As String Implements IrowViewCCGaugeStats.colSeismicInspectionsComplete
            Get
                Return m_colSeismicInspectionsComplete
            End Get
            Set
                If Not Same(m_colSeismicInspectionsComplete, Value) Then
                    m_colSeismicInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colSeismicInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colSeismicInspectionsComplete As String

        Public Property colSeismicInspectionsPending() As String Implements IrowViewCCGaugeStats.colSeismicInspectionsPending
            Get
                Return m_colSeismicInspectionsPending
            End Get
            Set
                If Not Same(m_colSeismicInspectionsPending, Value) Then
                    m_colSeismicInspectionsPending = Value
                    m_IsDirty(FieldIndex.colSeismicInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colSeismicInspectionsPending As String

        Public Property colSeismicInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colSeismicInspectionsCancelled
            Get
                Return m_colSeismicInspectionsCancelled
            End Get
            Set
                If Not Same(m_colSeismicInspectionsCancelled, Value) Then
                    m_colSeismicInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colSeismicInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colSeismicInspectionsCancelled As String

        Public Property colNatHazSeismicInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsDueStatisticId
            Get
                Return m_colNatHazSeismicInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsDueStatisticId, Value) Then
                    m_colNatHazSeismicInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsDueStatisticId As String

        Public Property colNatHazSeismicInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsCompletedStatisticId
            Get
                Return m_colNatHazSeismicInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsCompletedStatisticId, Value) Then
                    m_colNatHazSeismicInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsCompletedStatisticId As String

        Public Property colNatHazSeismicInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsPendingStatisticId
            Get
                Return m_colNatHazSeismicInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsPendingStatisticId, Value) Then
                    m_colNatHazSeismicInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsPendingStatisticId As String

        Public Property colNatHazSeismicInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsCancelledStatisticId
            Get
                Return m_colNatHazSeismicInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsCancelledStatisticId, Value) Then
                    m_colNatHazSeismicInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsCancelledStatisticId As String

        Public Property colNatHazSeismicInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInspectionsDueFilter
            Get
                Return m_colNatHazSeismicInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colNatHazSeismicInspectionsDueFilter, Value) Then
                    m_colNatHazSeismicInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInspectionsDueFilter As String

        Public Property colNatHazSeismicInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInspectionsCompleteFilter
            Get
                Return m_colNatHazSeismicInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colNatHazSeismicInspectionsCompleteFilter, Value) Then
                    m_colNatHazSeismicInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInspectionsCompleteFilter As String

        Public Property colNatHazSeismicInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInspectionsPendingFilter
            Get
                Return m_colNatHazSeismicInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colNatHazSeismicInspectionsPendingFilter, Value) Then
                    m_colNatHazSeismicInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInspectionsPendingFilter As String

        Public Property colNatHazSeismicInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInspectionsCancelledFilter
            Get
                Return m_colNatHazSeismicInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colNatHazSeismicInspectionsCancelledFilter, Value) Then
                    m_colNatHazSeismicInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInspectionsCancelledFilter As String

        Public Property colNatHazSeismicInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsDueLabel
            Get
                Return m_colNatHazSeismicInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsDueLabel, Value) Then
                    m_colNatHazSeismicInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsDueLabel As String

        Public Property colNatHazSeismicInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsCompletedLabel
            Get
                Return m_colNatHazSeismicInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsCompletedLabel, Value) Then
                    m_colNatHazSeismicInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsCompletedLabel As String

        Public Property colNatHazSeismicInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsPendingLabel
            Get
                Return m_colNatHazSeismicInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsPendingLabel, Value) Then
                    m_colNatHazSeismicInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsPendingLabel As String

        Public Property colNatHazSeismicInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colNatHazSeismicInpectionsCancelledLabel
            Get
                Return m_colNatHazSeismicInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colNatHazSeismicInpectionsCancelledLabel, Value) Then
                    m_colNatHazSeismicInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazSeismicInpectionsCancelledLabel As String

        Public Property colFloodInspectionsDue() As String Implements IrowViewCCGaugeStats.colFloodInspectionsDue
            Get
                Return m_colFloodInspectionsDue
            End Get
            Set
                If Not Same(m_colFloodInspectionsDue, Value) Then
                    m_colFloodInspectionsDue = Value
                    m_IsDirty(FieldIndex.colFloodInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colFloodInspectionsDue As String

        Public Property colFloodInspectionsComplete() As String Implements IrowViewCCGaugeStats.colFloodInspectionsComplete
            Get
                Return m_colFloodInspectionsComplete
            End Get
            Set
                If Not Same(m_colFloodInspectionsComplete, Value) Then
                    m_colFloodInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colFloodInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colFloodInspectionsComplete As String

        Public Property colFloodInspectionsPending() As String Implements IrowViewCCGaugeStats.colFloodInspectionsPending
            Get
                Return m_colFloodInspectionsPending
            End Get
            Set
                If Not Same(m_colFloodInspectionsPending, Value) Then
                    m_colFloodInspectionsPending = Value
                    m_IsDirty(FieldIndex.colFloodInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colFloodInspectionsPending As String

        Public Property colFloodInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colFloodInspectionsCancelled
            Get
                Return m_colFloodInspectionsCancelled
            End Get
            Set
                If Not Same(m_colFloodInspectionsCancelled, Value) Then
                    m_colFloodInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colFloodInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colFloodInspectionsCancelled As String

        Public Property colNatHazFloodInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsDueStatisticId
            Get
                Return m_colNatHazFloodInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsDueStatisticId, Value) Then
                    m_colNatHazFloodInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsDueStatisticId As String

        Public Property colNatHazFloodInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsCompletedStatisticId
            Get
                Return m_colNatHazFloodInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsCompletedStatisticId, Value) Then
                    m_colNatHazFloodInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsCompletedStatisticId As String

        Public Property colNatHazFloodInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsPendingStatisticId
            Get
                Return m_colNatHazFloodInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsPendingStatisticId, Value) Then
                    m_colNatHazFloodInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsPendingStatisticId As String

        Public Property colNatHazFloodInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsCancelledStatisticId
            Get
                Return m_colNatHazFloodInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsCancelledStatisticId, Value) Then
                    m_colNatHazFloodInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsCancelledStatisticId As String

        Public Property colNatHazFloodInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colNatHazFloodInspectionsDueFilter
            Get
                Return m_colNatHazFloodInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colNatHazFloodInspectionsDueFilter, Value) Then
                    m_colNatHazFloodInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInspectionsDueFilter As String

        Public Property colNatHazFloodInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colNatHazFloodInspectionsCompleteFilter
            Get
                Return m_colNatHazFloodInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colNatHazFloodInspectionsCompleteFilter, Value) Then
                    m_colNatHazFloodInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInspectionsCompleteFilter As String

        Public Property colNatHazFloodInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colNatHazFloodInspectionsPendingFilter
            Get
                Return m_colNatHazFloodInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colNatHazFloodInspectionsPendingFilter, Value) Then
                    m_colNatHazFloodInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInspectionsPendingFilter As String

        Public Property colNatHazFloodInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colNatHazFloodInspectionsCancelledFilter
            Get
                Return m_colNatHazFloodInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colNatHazFloodInspectionsCancelledFilter, Value) Then
                    m_colNatHazFloodInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInspectionsCancelledFilter As String

        Public Property colNatHazFloodInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsDueLabel
            Get
                Return m_colNatHazFloodInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsDueLabel, Value) Then
                    m_colNatHazFloodInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsDueLabel As String

        Public Property colNatHazFloodInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsCompletedLabel
            Get
                Return m_colNatHazFloodInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsCompletedLabel, Value) Then
                    m_colNatHazFloodInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsCompletedLabel As String

        Public Property colNatHazFloodInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsPendingLabel
            Get
                Return m_colNatHazFloodInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsPendingLabel, Value) Then
                    m_colNatHazFloodInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsPendingLabel As String

        Public Property colNatHazFloodInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colNatHazFloodInpectionsCancelledLabel
            Get
                Return m_colNatHazFloodInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colNatHazFloodInpectionsCancelledLabel, Value) Then
                    m_colNatHazFloodInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colNatHazFloodInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colNatHazFloodInpectionsCancelledLabel As String

        Public Property colJurisNoObjections() As String Implements IrowViewCCGaugeStats.colJurisNoObjections
            Get
                Return m_colJurisNoObjections
            End Get
            Set
                If Not Same(m_colJurisNoObjections, Value) Then
                    m_colJurisNoObjections = Value
                    m_IsDirty(FieldIndex.colJurisNoObjections) = True
                End If
            End Set
        End Property
        Private m_colJurisNoObjections As String

        Public Property colJurisOpenViolations() As String Implements IrowViewCCGaugeStats.colJurisOpenViolations
            Get
                Return m_colJurisOpenViolations
            End Get
            Set
                If Not Same(m_colJurisOpenViolations, Value) Then
                    m_colJurisOpenViolations = Value
                    m_IsDirty(FieldIndex.colJurisOpenViolations) = True
                End If
            End Set
        End Property
        Private m_colJurisOpenViolations As String

        Public Property colJurisNoActiveObjections() As String Implements IrowViewCCGaugeStats.colJurisNoActiveObjections
            Get
                Return m_colJurisNoActiveObjections
            End Get
            Set
                If Not Same(m_colJurisNoActiveObjections, Value) Then
                    m_colJurisNoActiveObjections = Value
                    m_IsDirty(FieldIndex.colJurisNoActiveObjections) = True
                End If
            End Set
        End Property
        Private m_colJurisNoActiveObjections As String

        Public Property colJurisObjectsStatisticId() As String Implements IrowViewCCGaugeStats.colJurisObjectsStatisticId
            Get
                Return m_colJurisObjectsStatisticId
            End Get
            Set
                If Not Same(m_colJurisObjectsStatisticId, Value) Then
                    m_colJurisObjectsStatisticId = Value
                    m_IsDirty(FieldIndex.colJurisObjectsStatisticId) = True
                End If
            End Set
        End Property
        Private m_colJurisObjectsStatisticId As String

        Public Property colJurisActiveObjectsStatisticId() As String Implements IrowViewCCGaugeStats.colJurisActiveObjectsStatisticId
            Get
                Return m_colJurisActiveObjectsStatisticId
            End Get
            Set
                If Not Same(m_colJurisActiveObjectsStatisticId, Value) Then
                    m_colJurisActiveObjectsStatisticId = Value
                    m_IsDirty(FieldIndex.colJurisActiveObjectsStatisticId) = True
                End If
            End Set
        End Property
        Private m_colJurisActiveObjectsStatisticId As String

        Public Property colJurisOpenRecommendationsStatisticId() As String Implements IrowViewCCGaugeStats.colJurisOpenRecommendationsStatisticId
            Get
                Return m_colJurisOpenRecommendationsStatisticId
            End Get
            Set
                If Not Same(m_colJurisOpenRecommendationsStatisticId, Value) Then
                    m_colJurisOpenRecommendationsStatisticId = Value
                    m_IsDirty(FieldIndex.colJurisOpenRecommendationsStatisticId) = True
                End If
            End Set
        End Property
        Private m_colJurisOpenRecommendationsStatisticId As String

        Public Property colJurisObjectsFilter() As String Implements IrowViewCCGaugeStats.colJurisObjectsFilter
            Get
                Return m_colJurisObjectsFilter
            End Get
            Set
                If Not Same(m_colJurisObjectsFilter, Value) Then
                    m_colJurisObjectsFilter = Value
                    m_IsDirty(FieldIndex.colJurisObjectsFilter) = True
                End If
            End Set
        End Property
        Private m_colJurisObjectsFilter As String

        Public Property colJurisActiveObjectsFilter() As String Implements IrowViewCCGaugeStats.colJurisActiveObjectsFilter
            Get
                Return m_colJurisActiveObjectsFilter
            End Get
            Set
                If Not Same(m_colJurisActiveObjectsFilter, Value) Then
                    m_colJurisActiveObjectsFilter = Value
                    m_IsDirty(FieldIndex.colJurisActiveObjectsFilter) = True
                End If
            End Set
        End Property
        Private m_colJurisActiveObjectsFilter As String

        Public Property colJurisOpenRecommendationsFilter() As String Implements IrowViewCCGaugeStats.colJurisOpenRecommendationsFilter
            Get
                Return m_colJurisOpenRecommendationsFilter
            End Get
            Set
                If Not Same(m_colJurisOpenRecommendationsFilter, Value) Then
                    m_colJurisOpenRecommendationsFilter = Value
                    m_IsDirty(FieldIndex.colJurisOpenRecommendationsFilter) = True
                End If
            End Set
        End Property
        Private m_colJurisOpenRecommendationsFilter As String

        Public Property colJurisObjectsLabel() As String Implements IrowViewCCGaugeStats.colJurisObjectsLabel
            Get
                Return m_colJurisObjectsLabel
            End Get
            Set
                If Not Same(m_colJurisObjectsLabel, Value) Then
                    m_colJurisObjectsLabel = Value
                    m_IsDirty(FieldIndex.colJurisObjectsLabel) = True
                End If
            End Set
        End Property
        Private m_colJurisObjectsLabel As String

        Public Property colJurisActiveObjectsLabel() As String Implements IrowViewCCGaugeStats.colJurisActiveObjectsLabel
            Get
                Return m_colJurisActiveObjectsLabel
            End Get
            Set
                If Not Same(m_colJurisActiveObjectsLabel, Value) Then
                    m_colJurisActiveObjectsLabel = Value
                    m_IsDirty(FieldIndex.colJurisActiveObjectsLabel) = True
                End If
            End Set
        End Property
        Private m_colJurisActiveObjectsLabel As String

        Public Property colJurisOpenRecommendationsLabel() As String Implements IrowViewCCGaugeStats.colJurisOpenRecommendationsLabel
            Get
                Return m_colJurisOpenRecommendationsLabel
            End Get
            Set
                If Not Same(m_colJurisOpenRecommendationsLabel, Value) Then
                    m_colJurisOpenRecommendationsLabel = Value
                    m_IsDirty(FieldIndex.colJurisOpenRecommendationsLabel) = True
                End If
            End Set
        End Property
        Private m_colJurisOpenRecommendationsLabel As String

        Public Property colDivServInspectionsDue() As String Implements IrowViewCCGaugeStats.colDivServInspectionsDue
            Get
                Return m_colDivServInspectionsDue
            End Get
            Set
                If Not Same(m_colDivServInspectionsDue, Value) Then
                    m_colDivServInspectionsDue = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsDue As String

        Public Property colDivServInspectionsComplete() As String Implements IrowViewCCGaugeStats.colDivServInspectionsComplete
            Get
                Return m_colDivServInspectionsComplete
            End Get
            Set
                If Not Same(m_colDivServInspectionsComplete, Value) Then
                    m_colDivServInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsComplete As String

        Public Property colDivServInspectionsPending() As String Implements IrowViewCCGaugeStats.colDivServInspectionsPending
            Get
                Return m_colDivServInspectionsPending
            End Get
            Set
                If Not Same(m_colDivServInspectionsPending, Value) Then
                    m_colDivServInspectionsPending = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsPending As String

        Public Property colDivServInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colDivServInspectionsCancelled
            Get
                Return m_colDivServInspectionsCancelled
            End Get
            Set
                If Not Same(m_colDivServInspectionsCancelled, Value) Then
                    m_colDivServInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsCancelled As String

        Public Property colDivServInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colDivServInpectionsDueStatisticId
            Get
                Return m_colDivServInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colDivServInpectionsDueStatisticId, Value) Then
                    m_colDivServInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsDueStatisticId As String

        Public Property colDivServInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colDivServInpectionsCompletedStatisticId
            Get
                Return m_colDivServInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colDivServInpectionsCompletedStatisticId, Value) Then
                    m_colDivServInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsCompletedStatisticId As String

        Public Property colDivServInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colDivServInpectionsPendingStatisticId
            Get
                Return m_colDivServInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colDivServInpectionsPendingStatisticId, Value) Then
                    m_colDivServInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsPendingStatisticId As String

        Public Property colDivServInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colDivServInpectionsCancelledStatisticId
            Get
                Return m_colDivServInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colDivServInpectionsCancelledStatisticId, Value) Then
                    m_colDivServInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsCancelledStatisticId As String

        Public Property colDivServInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colDivServInspectionsDueFilter
            Get
                Return m_colDivServInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colDivServInspectionsDueFilter, Value) Then
                    m_colDivServInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsDueFilter As String

        Public Property colDivServInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colDivServInspectionsCompleteFilter
            Get
                Return m_colDivServInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colDivServInspectionsCompleteFilter, Value) Then
                    m_colDivServInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsCompleteFilter As String

        Public Property colDivServInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colDivServInspectionsPendingFilter
            Get
                Return m_colDivServInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colDivServInspectionsPendingFilter, Value) Then
                    m_colDivServInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsPendingFilter As String

        Public Property colDivServInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colDivServInspectionsCancelledFilter
            Get
                Return m_colDivServInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colDivServInspectionsCancelledFilter, Value) Then
                    m_colDivServInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colDivServInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colDivServInspectionsCancelledFilter As String

        Public Property colDivServInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colDivServInpectionsDueLabel
            Get
                Return m_colDivServInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colDivServInpectionsDueLabel, Value) Then
                    m_colDivServInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsDueLabel As String

        Public Property colDivServInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colDivServInpectionsCompletedLabel
            Get
                Return m_colDivServInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colDivServInpectionsCompletedLabel, Value) Then
                    m_colDivServInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsCompletedLabel As String

        Public Property colDivServInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colDivServInpectionsPendingLabel
            Get
                Return m_colDivServInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colDivServInpectionsPendingLabel, Value) Then
                    m_colDivServInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsPendingLabel As String

        Public Property colDivServInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colDivServInpectionsCancelledLabel
            Get
                Return m_colDivServInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colDivServInpectionsCancelledLabel, Value) Then
                    m_colDivServInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colDivServInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colDivServInpectionsCancelledLabel As String

        Public Property colPSInspectionsDue() As String Implements IrowViewCCGaugeStats.colPSInspectionsDue
            Get
                Return m_colPSInspectionsDue
            End Get
            Set
                If Not Same(m_colPSInspectionsDue, Value) Then
                    m_colPSInspectionsDue = Value
                    m_IsDirty(FieldIndex.colPSInspectionsDue) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsDue As String

        Public Property colPSInspectionsComplete() As String Implements IrowViewCCGaugeStats.colPSInspectionsComplete
            Get
                Return m_colPSInspectionsComplete
            End Get
            Set
                If Not Same(m_colPSInspectionsComplete, Value) Then
                    m_colPSInspectionsComplete = Value
                    m_IsDirty(FieldIndex.colPSInspectionsComplete) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsComplete As String

        Public Property colPSInspectionsPending() As String Implements IrowViewCCGaugeStats.colPSInspectionsPending
            Get
                Return m_colPSInspectionsPending
            End Get
            Set
                If Not Same(m_colPSInspectionsPending, Value) Then
                    m_colPSInspectionsPending = Value
                    m_IsDirty(FieldIndex.colPSInspectionsPending) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsPending As String

        Public Property colPSInspectionsCancelled() As String Implements IrowViewCCGaugeStats.colPSInspectionsCancelled
            Get
                Return m_colPSInspectionsCancelled
            End Get
            Set
                If Not Same(m_colPSInspectionsCancelled, Value) Then
                    m_colPSInspectionsCancelled = Value
                    m_IsDirty(FieldIndex.colPSInspectionsCancelled) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsCancelled As String

        Public Property colPSInpectionsDueStatisticId() As String Implements IrowViewCCGaugeStats.colPSInpectionsDueStatisticId
            Get
                Return m_colPSInpectionsDueStatisticId
            End Get
            Set
                If Not Same(m_colPSInpectionsDueStatisticId, Value) Then
                    m_colPSInpectionsDueStatisticId = Value
                    m_IsDirty(FieldIndex.colPSInpectionsDueStatisticId) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsDueStatisticId As String

        Public Property colPSInpectionsCompletedStatisticId() As String Implements IrowViewCCGaugeStats.colPSInpectionsCompletedStatisticId
            Get
                Return m_colPSInpectionsCompletedStatisticId
            End Get
            Set
                If Not Same(m_colPSInpectionsCompletedStatisticId, Value) Then
                    m_colPSInpectionsCompletedStatisticId = Value
                    m_IsDirty(FieldIndex.colPSInpectionsCompletedStatisticId) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsCompletedStatisticId As String

        Public Property colPSInpectionsPendingStatisticId() As String Implements IrowViewCCGaugeStats.colPSInpectionsPendingStatisticId
            Get
                Return m_colPSInpectionsPendingStatisticId
            End Get
            Set
                If Not Same(m_colPSInpectionsPendingStatisticId, Value) Then
                    m_colPSInpectionsPendingStatisticId = Value
                    m_IsDirty(FieldIndex.colPSInpectionsPendingStatisticId) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsPendingStatisticId As String

        Public Property colPSInpectionsCancelledStatisticId() As String Implements IrowViewCCGaugeStats.colPSInpectionsCancelledStatisticId
            Get
                Return m_colPSInpectionsCancelledStatisticId
            End Get
            Set
                If Not Same(m_colPSInpectionsCancelledStatisticId, Value) Then
                    m_colPSInpectionsCancelledStatisticId = Value
                    m_IsDirty(FieldIndex.colPSInpectionsCancelledStatisticId) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsCancelledStatisticId As String

        Public Property colPSInspectionsDueFilter() As String Implements IrowViewCCGaugeStats.colPSInspectionsDueFilter
            Get
                Return m_colPSInspectionsDueFilter
            End Get
            Set
                If Not Same(m_colPSInspectionsDueFilter, Value) Then
                    m_colPSInspectionsDueFilter = Value
                    m_IsDirty(FieldIndex.colPSInspectionsDueFilter) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsDueFilter As String

        Public Property colPSInspectionsCompleteFilter() As String Implements IrowViewCCGaugeStats.colPSInspectionsCompleteFilter
            Get
                Return m_colPSInspectionsCompleteFilter
            End Get
            Set
                If Not Same(m_colPSInspectionsCompleteFilter, Value) Then
                    m_colPSInspectionsCompleteFilter = Value
                    m_IsDirty(FieldIndex.colPSInspectionsCompleteFilter) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsCompleteFilter As String

        Public Property colPSInspectionsPendingFilter() As String Implements IrowViewCCGaugeStats.colPSInspectionsPendingFilter
            Get
                Return m_colPSInspectionsPendingFilter
            End Get
            Set
                If Not Same(m_colPSInspectionsPendingFilter, Value) Then
                    m_colPSInspectionsPendingFilter = Value
                    m_IsDirty(FieldIndex.colPSInspectionsPendingFilter) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsPendingFilter As String

        Public Property colPSInspectionsCancelledFilter() As String Implements IrowViewCCGaugeStats.colPSInspectionsCancelledFilter
            Get
                Return m_colPSInspectionsCancelledFilter
            End Get
            Set
                If Not Same(m_colPSInspectionsCancelledFilter, Value) Then
                    m_colPSInspectionsCancelledFilter = Value
                    m_IsDirty(FieldIndex.colPSInspectionsCancelledFilter) = True
                End If
            End Set
        End Property
        Private m_colPSInspectionsCancelledFilter As String

        Public Property colPSInpectionsDueLabel() As String Implements IrowViewCCGaugeStats.colPSInpectionsDueLabel
            Get
                Return m_colPSInpectionsDueLabel
            End Get
            Set
                If Not Same(m_colPSInpectionsDueLabel, Value) Then
                    m_colPSInpectionsDueLabel = Value
                    m_IsDirty(FieldIndex.colPSInpectionsDueLabel) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsDueLabel As String

        Public Property colPsInpectionsCompletedLabel() As String Implements IrowViewCCGaugeStats.colPsInpectionsCompletedLabel
            Get
                Return m_colPsInpectionsCompletedLabel
            End Get
            Set
                If Not Same(m_colPsInpectionsCompletedLabel, Value) Then
                    m_colPsInpectionsCompletedLabel = Value
                    m_IsDirty(FieldIndex.colPsInpectionsCompletedLabel) = True
                End If
            End Set
        End Property
        Private m_colPsInpectionsCompletedLabel As String

        Public Property colPSInpectionsPendingLabel() As String Implements IrowViewCCGaugeStats.colPSInpectionsPendingLabel
            Get
                Return m_colPSInpectionsPendingLabel
            End Get
            Set
                If Not Same(m_colPSInpectionsPendingLabel, Value) Then
                    m_colPSInpectionsPendingLabel = Value
                    m_IsDirty(FieldIndex.colPSInpectionsPendingLabel) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsPendingLabel As String

        Public Property colPSInpectionsCancelledLabel() As String Implements IrowViewCCGaugeStats.colPSInpectionsCancelledLabel
            Get
                Return m_colPSInpectionsCancelledLabel
            End Get
            Set
                If Not Same(m_colPSInpectionsCancelledLabel, Value) Then
                    m_colPSInpectionsCancelledLabel = Value
                    m_IsDirty(FieldIndex.colPSInpectionsCancelledLabel) = True
                End If
            End Set
        End Property
        Private m_colPSInpectionsCancelledLabel As String


        Public Function IsDirty(pIndex As rowViewCCGaugeStats.FieldIndex) As Boolean Implements IrowViewCCGaugeStats.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowViewCCGaugeStats.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowViewCCGaugeStats.SetIsDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colGSafeGUID) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colFireInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colFireInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colBMInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colBMInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colIRInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colIRInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colWindInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colWindInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colWindInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colWindInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazWindInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colSeismicInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colSeismicInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colSeismicInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colSeismicInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazSeismicInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colFloodInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colFloodInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colFloodInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colFloodInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colNatHazFloodInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colJurisNoObjections) = pDirty
            m_IsDirty(FieldIndex.colJurisOpenViolations) = pDirty
            m_IsDirty(FieldIndex.colJurisNoActiveObjections) = pDirty
            m_IsDirty(FieldIndex.colJurisObjectsStatisticId) = pDirty
            m_IsDirty(FieldIndex.colJurisActiveObjectsStatisticId) = pDirty
            m_IsDirty(FieldIndex.colJurisOpenRecommendationsStatisticId) = pDirty
            m_IsDirty(FieldIndex.colJurisObjectsFilter) = pDirty
            m_IsDirty(FieldIndex.colJurisActiveObjectsFilter) = pDirty
            m_IsDirty(FieldIndex.colJurisOpenRecommendationsFilter) = pDirty
            m_IsDirty(FieldIndex.colJurisObjectsLabel) = pDirty
            m_IsDirty(FieldIndex.colJurisActiveObjectsLabel) = pDirty
            m_IsDirty(FieldIndex.colJurisOpenRecommendationsLabel) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colDivServInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colDivServInpectionsCancelledLabel) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsDue) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsComplete) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsPending) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsCancelled) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsDueStatisticId) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsCompletedStatisticId) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsPendingStatisticId) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsCancelledStatisticId) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsDueFilter) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsCompleteFilter) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsPendingFilter) = pDirty
            m_IsDirty(FieldIndex.colPSInspectionsCancelledFilter) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsDueLabel) = pDirty
            m_IsDirty(FieldIndex.colPsInpectionsCompletedLabel) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsPendingLabel) = pDirty
            m_IsDirty(FieldIndex.colPSInpectionsCancelledLabel) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (ViewCCGaugeStats) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New ViewCCGaugeStats
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFilePrefix  = 1
            colGSafeGUID 
            colFireInspectionsDue 
            colFireInspectionsComplete 
            colFireInspectionsPending 
            colFireInspectionsCancelled 
            colFireInpectionsDueStatisticId 
            colFireInpectionsCompletedStatisticId 
            colFireInpectionsPendingStatisticId 
            colFireInpectionsCancelledStatisticId 
            colFireInspectionsDueFilter 
            colFireInspectionsCompleteFilter 
            colFireInspectionsPendingFilter 
            colFireInspectionsCancelledFilter 
            colFireInpectionsDueLabel 
            colFireInpectionsCompletedLabel 
            colFireInpectionsPendingLabel 
            colFireInpectionsCancelledLabel 
            colBMInspectionsDue 
            colBMInspectionsComplete 
            colBMInspectionsPending 
            colBMInspectionsCancelled 
            colBMInpectionsDueStatisticId 
            colBMInpectionsCompletedStatisticId 
            colBMInpectionsPendingStatisticId 
            colBMInpectionsCancelledStatisticId 
            colBMInspectionsDueFilter 
            colBMInspectionsCompleteFilter 
            colBMInspectionsPendingFilter 
            colBMInspectionsCancelledFilter 
            colBMInpectionsDueLabel 
            colBMInpectionsCompletedLabel 
            colBMInpectionsPendingLabel 
            colBMInpectionsCancelledLabel 
            colIRInspectionsDue 
            colIRInspectionsComplete 
            colIRInspectionsPending 
            colIRInspectionsCancelled 
            colIRInpectionsDueStatisticId 
            colIRInpectionsCompletedStatisticId 
            colIRInpectionsPendingStatisticId 
            colIRInpectionsCancelledStatisticId 
            colIRInspectionsDueFilter 
            colIRInspectionsCompleteFilter 
            colIRInspectionsPendingFilter 
            colIRInspectionsCancelledFilter 
            colIRInpectionsDueLabel 
            colIRInpectionsCompletedLabel 
            colIRInpectionsPendingLabel 
            colIRInpectionsCancelledLabel 
            colNatHazInspectionsDue 
            colNatHazInspectionsComplete 
            colNatHazInspectionsPending 
            colNatHazInspectionsCancelled 
            colNatHazInpectionsDueStatisticId 
            colNatHazInpectionsCompletedStatisticId 
            colNatHazInpectionsPendingStatisticId 
            colNatHazInpectionsCancelledStatisticId 
            colNatHazInspectionsDueFilter 
            colNatHazInspectionsCompleteFilter 
            colNatHazInspectionsPendingFilter 
            colNatHazInspectionsCancelledFilter 
            colNatHazInpectionsDueLabel 
            colNatHazInpectionsCompletedLabel 
            colNatHazInpectionsPendingLabel 
            colNatHazInpectionsCancelledLabel 
            colWindInspectionsDue 
            colWindInspectionsComplete 
            colWindInspectionsPending 
            colWindInspectionsCancelled 
            colNatHazWindInpectionsDueStatisticId 
            colNatHazWindInpectionsCompletedStatisticId 
            colNatHazWindInpectionsPendingStatisticId 
            colNatHazWindInpectionsCancelledStatisticId 
            colNatHazWindInspectionsDueFilter 
            colNatHazWindInspectionsCompleteFilter 
            colNatHazWindInspectionsPendingFilter 
            colNatHazWindInspectionsCancelledFilter 
            colNatHazWindInpectionsDueLabel 
            colNatHazWindInpectionsCompletedLabel 
            colNatHazWindInpectionsPendingLabel 
            colNatHazWindInpectionsCancelledLabel 
            colSeismicInspectionsDue 
            colSeismicInspectionsComplete 
            colSeismicInspectionsPending 
            colSeismicInspectionsCancelled 
            colNatHazSeismicInpectionsDueStatisticId 
            colNatHazSeismicInpectionsCompletedStatisticId 
            colNatHazSeismicInpectionsPendingStatisticId 
            colNatHazSeismicInpectionsCancelledStatisticId 
            colNatHazSeismicInspectionsDueFilter 
            colNatHazSeismicInspectionsCompleteFilter 
            colNatHazSeismicInspectionsPendingFilter 
            colNatHazSeismicInspectionsCancelledFilter 
            colNatHazSeismicInpectionsDueLabel 
            colNatHazSeismicInpectionsCompletedLabel 
            colNatHazSeismicInpectionsPendingLabel 
            colNatHazSeismicInpectionsCancelledLabel 
            colFloodInspectionsDue 
            colFloodInspectionsComplete 
            colFloodInspectionsPending 
            colFloodInspectionsCancelled 
            colNatHazFloodInpectionsDueStatisticId 
            colNatHazFloodInpectionsCompletedStatisticId 
            colNatHazFloodInpectionsPendingStatisticId 
            colNatHazFloodInpectionsCancelledStatisticId 
            colNatHazFloodInspectionsDueFilter 
            colNatHazFloodInspectionsCompleteFilter 
            colNatHazFloodInspectionsPendingFilter 
            colNatHazFloodInspectionsCancelledFilter 
            colNatHazFloodInpectionsDueLabel 
            colNatHazFloodInpectionsCompletedLabel 
            colNatHazFloodInpectionsPendingLabel 
            colNatHazFloodInpectionsCancelledLabel 
            colJurisNoObjections 
            colJurisOpenViolations 
            colJurisNoActiveObjections 
            colJurisObjectsStatisticId 
            colJurisActiveObjectsStatisticId 
            colJurisOpenRecommendationsStatisticId 
            colJurisObjectsFilter 
            colJurisActiveObjectsFilter 
            colJurisOpenRecommendationsFilter 
            colJurisObjectsLabel 
            colJurisActiveObjectsLabel 
            colJurisOpenRecommendationsLabel 
            colDivServInspectionsDue 
            colDivServInspectionsComplete 
            colDivServInspectionsPending 
            colDivServInspectionsCancelled 
            colDivServInpectionsDueStatisticId 
            colDivServInpectionsCompletedStatisticId 
            colDivServInpectionsPendingStatisticId 
            colDivServInpectionsCancelledStatisticId 
            colDivServInspectionsDueFilter 
            colDivServInspectionsCompleteFilter 
            colDivServInspectionsPendingFilter 
            colDivServInspectionsCancelledFilter 
            colDivServInpectionsDueLabel 
            colDivServInpectionsCompletedLabel 
            colDivServInpectionsPendingLabel 
            colDivServInpectionsCancelledLabel 
            colPSInspectionsDue 
            colPSInspectionsComplete 
            colPSInspectionsPending 
            colPSInspectionsCancelled 
            colPSInpectionsDueStatisticId 
            colPSInpectionsCompletedStatisticId 
            colPSInpectionsPendingStatisticId 
            colPSInpectionsCancelledStatisticId 
            colPSInspectionsDueFilter 
            colPSInspectionsCompleteFilter 
            colPSInspectionsPendingFilter 
            colPSInspectionsCancelledFilter 
            colPSInpectionsDueLabel 
            colPsInpectionsCompletedLabel 
            colPSInpectionsPendingLabel 
            colPSInpectionsCancelledLabel 
        End Enum

        Private m_IsDirty(158) As Boolean

        Private Function [Same](pValue1 As Object, pValue2 As Object) As Boolean
            If pValue1 Is Nothing And (Not pValue2 Is Nothing) Then
                Return False
            End If

            If (Not pValue1 Is Nothing) And pValue2 Is Nothing Then
                Return False
            End If

            If pValue1 <> pValue2 Then
                Return False
            End If

            Return True
        End Function

    End Class

    Public Interface IrowViewCCGaugeStats
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFilePrefix() As String
        Property colGSafeGUID() As String
        Property colFireInspectionsDue() As String
        Property colFireInspectionsComplete() As String
        Property colFireInspectionsPending() As String
        Property colFireInspectionsCancelled() As String
        Property colFireInpectionsDueStatisticId() As String
        Property colFireInpectionsCompletedStatisticId() As String
        Property colFireInpectionsPendingStatisticId() As String
        Property colFireInpectionsCancelledStatisticId() As String
        Property colFireInspectionsDueFilter() As String
        Property colFireInspectionsCompleteFilter() As String
        Property colFireInspectionsPendingFilter() As String
        Property colFireInspectionsCancelledFilter() As String
        Property colFireInpectionsDueLabel() As String
        Property colFireInpectionsCompletedLabel() As String
        Property colFireInpectionsPendingLabel() As String
        Property colFireInpectionsCancelledLabel() As String
        Property colBMInspectionsDue() As String
        Property colBMInspectionsComplete() As String
        Property colBMInspectionsPending() As String
        Property colBMInspectionsCancelled() As String
        Property colBMInpectionsDueStatisticId() As String
        Property colBMInpectionsCompletedStatisticId() As String
        Property colBMInpectionsPendingStatisticId() As String
        Property colBMInpectionsCancelledStatisticId() As String
        Property colBMInspectionsDueFilter() As String
        Property colBMInspectionsCompleteFilter() As String
        Property colBMInspectionsPendingFilter() As String
        Property colBMInspectionsCancelledFilter() As String
        Property colBMInpectionsDueLabel() As String
        Property colBMInpectionsCompletedLabel() As String
        Property colBMInpectionsPendingLabel() As String
        Property colBMInpectionsCancelledLabel() As String
        Property colIRInspectionsDue() As String
        Property colIRInspectionsComplete() As String
        Property colIRInspectionsPending() As String
        Property colIRInspectionsCancelled() As String
        Property colIRInpectionsDueStatisticId() As String
        Property colIRInpectionsCompletedStatisticId() As String
        Property colIRInpectionsPendingStatisticId() As String
        Property colIRInpectionsCancelledStatisticId() As String
        Property colIRInspectionsDueFilter() As String
        Property colIRInspectionsCompleteFilter() As String
        Property colIRInspectionsPendingFilter() As String
        Property colIRInspectionsCancelledFilter() As String
        Property colIRInpectionsDueLabel() As String
        Property colIRInpectionsCompletedLabel() As String
        Property colIRInpectionsPendingLabel() As String
        Property colIRInpectionsCancelledLabel() As String
        Property colNatHazInspectionsDue() As String
        Property colNatHazInspectionsComplete() As String
        Property colNatHazInspectionsPending() As String
        Property colNatHazInspectionsCancelled() As String
        Property colNatHazInpectionsDueStatisticId() As String
        Property colNatHazInpectionsCompletedStatisticId() As String
        Property colNatHazInpectionsPendingStatisticId() As String
        Property colNatHazInpectionsCancelledStatisticId() As String
        Property colNatHazInspectionsDueFilter() As String
        Property colNatHazInspectionsCompleteFilter() As String
        Property colNatHazInspectionsPendingFilter() As String
        Property colNatHazInspectionsCancelledFilter() As String
        Property colNatHazInpectionsDueLabel() As String
        Property colNatHazInpectionsCompletedLabel() As String
        Property colNatHazInpectionsPendingLabel() As String
        Property colNatHazInpectionsCancelledLabel() As String
        Property colWindInspectionsDue() As String
        Property colWindInspectionsComplete() As String
        Property colWindInspectionsPending() As String
        Property colWindInspectionsCancelled() As String
        Property colNatHazWindInpectionsDueStatisticId() As String
        Property colNatHazWindInpectionsCompletedStatisticId() As String
        Property colNatHazWindInpectionsPendingStatisticId() As String
        Property colNatHazWindInpectionsCancelledStatisticId() As String
        Property colNatHazWindInspectionsDueFilter() As String
        Property colNatHazWindInspectionsCompleteFilter() As String
        Property colNatHazWindInspectionsPendingFilter() As String
        Property colNatHazWindInspectionsCancelledFilter() As String
        Property colNatHazWindInpectionsDueLabel() As String
        Property colNatHazWindInpectionsCompletedLabel() As String
        Property colNatHazWindInpectionsPendingLabel() As String
        Property colNatHazWindInpectionsCancelledLabel() As String
        Property colSeismicInspectionsDue() As String
        Property colSeismicInspectionsComplete() As String
        Property colSeismicInspectionsPending() As String
        Property colSeismicInspectionsCancelled() As String
        Property colNatHazSeismicInpectionsDueStatisticId() As String
        Property colNatHazSeismicInpectionsCompletedStatisticId() As String
        Property colNatHazSeismicInpectionsPendingStatisticId() As String
        Property colNatHazSeismicInpectionsCancelledStatisticId() As String
        Property colNatHazSeismicInspectionsDueFilter() As String
        Property colNatHazSeismicInspectionsCompleteFilter() As String
        Property colNatHazSeismicInspectionsPendingFilter() As String
        Property colNatHazSeismicInspectionsCancelledFilter() As String
        Property colNatHazSeismicInpectionsDueLabel() As String
        Property colNatHazSeismicInpectionsCompletedLabel() As String
        Property colNatHazSeismicInpectionsPendingLabel() As String
        Property colNatHazSeismicInpectionsCancelledLabel() As String
        Property colFloodInspectionsDue() As String
        Property colFloodInspectionsComplete() As String
        Property colFloodInspectionsPending() As String
        Property colFloodInspectionsCancelled() As String
        Property colNatHazFloodInpectionsDueStatisticId() As String
        Property colNatHazFloodInpectionsCompletedStatisticId() As String
        Property colNatHazFloodInpectionsPendingStatisticId() As String
        Property colNatHazFloodInpectionsCancelledStatisticId() As String
        Property colNatHazFloodInspectionsDueFilter() As String
        Property colNatHazFloodInspectionsCompleteFilter() As String
        Property colNatHazFloodInspectionsPendingFilter() As String
        Property colNatHazFloodInspectionsCancelledFilter() As String
        Property colNatHazFloodInpectionsDueLabel() As String
        Property colNatHazFloodInpectionsCompletedLabel() As String
        Property colNatHazFloodInpectionsPendingLabel() As String
        Property colNatHazFloodInpectionsCancelledLabel() As String
        Property colJurisNoObjections() As String
        Property colJurisOpenViolations() As String
        Property colJurisNoActiveObjections() As String
        Property colJurisObjectsStatisticId() As String
        Property colJurisActiveObjectsStatisticId() As String
        Property colJurisOpenRecommendationsStatisticId() As String
        Property colJurisObjectsFilter() As String
        Property colJurisActiveObjectsFilter() As String
        Property colJurisOpenRecommendationsFilter() As String
        Property colJurisObjectsLabel() As String
        Property colJurisActiveObjectsLabel() As String
        Property colJurisOpenRecommendationsLabel() As String
        Property colDivServInspectionsDue() As String
        Property colDivServInspectionsComplete() As String
        Property colDivServInspectionsPending() As String
        Property colDivServInspectionsCancelled() As String
        Property colDivServInpectionsDueStatisticId() As String
        Property colDivServInpectionsCompletedStatisticId() As String
        Property colDivServInpectionsPendingStatisticId() As String
        Property colDivServInpectionsCancelledStatisticId() As String
        Property colDivServInspectionsDueFilter() As String
        Property colDivServInspectionsCompleteFilter() As String
        Property colDivServInspectionsPendingFilter() As String
        Property colDivServInspectionsCancelledFilter() As String
        Property colDivServInpectionsDueLabel() As String
        Property colDivServInpectionsCompletedLabel() As String
        Property colDivServInpectionsPendingLabel() As String
        Property colDivServInpectionsCancelledLabel() As String
        Property colPSInspectionsDue() As String
        Property colPSInspectionsComplete() As String
        Property colPSInspectionsPending() As String
        Property colPSInspectionsCancelled() As String
        Property colPSInpectionsDueStatisticId() As String
        Property colPSInpectionsCompletedStatisticId() As String
        Property colPSInpectionsPendingStatisticId() As String
        Property colPSInpectionsCancelledStatisticId() As String
        Property colPSInspectionsDueFilter() As String
        Property colPSInspectionsCompleteFilter() As String
        Property colPSInspectionsPendingFilter() As String
        Property colPSInspectionsCancelledFilter() As String
        Property colPSInpectionsDueLabel() As String
        Property colPsInpectionsCompletedLabel() As String
        Property colPSInpectionsPendingLabel() As String
        Property colPSInpectionsCancelledLabel() As String
        Function IsDirty(pIndex As rowViewCCGaugeStats.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

