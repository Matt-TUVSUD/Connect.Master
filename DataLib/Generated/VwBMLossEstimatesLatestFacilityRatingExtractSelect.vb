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
    Partial Public Class VwBMLossEstimatesLatestFacilityRatingExtractSelect

        Public Shared Function LoadData() As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zReturn As New List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
            Dim zSQL As String = "SELECT * FROM [gv].[vwBMLossEstimatesLatestFacilityRatingExtractSelect]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)

			Try
	            Dim zReturn As New List(Of rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwBMLossEstimatesLatestFacilityRatingExtractSelect

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwBMLossEstimatesLatestFacilityRatingExtractSelect		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwBMLossEstimatesLatestFacilityRatingExtractSelect)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fileprefix")) Then pObject.colFileprefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "fileprefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Client")) Then pObject.colClient = UtilSQLServer.SafeReader.SafeReadString(pReader, "Client")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address")) Then pObject.colAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspectionDate")) Then pObject.colInspectionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "InspectionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Engineer")) Then pObject.colEngineer = UtilSQLServer.SafeReader.SafeReadString(pReader, "Engineer")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Currency")) Then pObject.colCurrency = UtilSQLServer.SafeReader.SafeReadString(pReader, "Currency")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BIReporting")) Then pObject.colBIReporting = UtilSQLServer.SafeReader.SafeReadString(pReader, "BIReporting")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExchangeRate")) Then pObject.colExchangeRate = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "ExchangeRate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVPD")) Then pObject.colTivpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVBI")) Then pObject.colTivbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIV")) Then pObject.colTiv = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIV")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPD")) Then pObject.colPmlpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLBI")) Then pObject.colPmlbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PML")) Then pObject.colPml = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PML")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPDPercent")) Then pObject.colPMLPDPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPDPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLBIPercent")) Then pObject.colPMLBIPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLBIPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PMLPercent")) Then pObject.colPMLPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PMLPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPD")) Then pObject.colMflpd = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPD")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLBI")) Then pObject.colMflbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFL")) Then pObject.colMfl = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFL")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPDPercent")) Then pObject.colMFLPDPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPDPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLBIPercent")) Then pObject.colMFLBIPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLBIPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MFLPercent")) Then pObject.colMFLPercent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "MFLPercent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Interdependencies")) Then pObject.colInterdependencies = UtilSQLServer.SafeReader.SafeReadString(pReader, "Interdependencies")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LEandInterdependecyComments")) Then pObject.colLEandInterdependecyComments = UtilSQLServer.SafeReader.SafeReadString(pReader, "LEandInterdependecyComments")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Losses_Last_3_Years")) Then pObject.colLossesLast3Years = UtilSQLServer.SafeReader.SafeReadString(pReader, "Losses_Last_3_Years")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Loss_History_Description")) Then pObject.colLossHistoryDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "Loss_History_Description")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveC")) Then pObject.colActiveC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "ActiveC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PassiveC")) Then pObject.colPassiveC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PassiveC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TotalScoreCurrent")) Then pObject.colTotalScoreCurrent = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TotalScoreCurrent")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OverallRating")) Then pObject.colOverallRating = UtilSQLServer.SafeReader.SafeReadString(pReader, "OverallRating")
			If Not pReader.IsDBNull(pReader.GetOrdinal("totalscorecurrentColor")) Then pObject.colTotalscorecurrentColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "totalscorecurrentColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Occupancy")) Then pObject.colOccupancy = UtilSQLServer.SafeReader.SafeReadString(pReader, "Occupancy")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IndustryGroup")) Then pObject.colIndustryGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "IndustryGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MajorGroup")) Then pObject.colMajorGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "MajorGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SpecificGroup")) Then pObject.colSpecificGroup = UtilSQLServer.SafeReader.SafeReadString(pReader, "SpecificGroup")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActiveWC")) Then pObject.colActiveWC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "ActiveWC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PassiveWC")) Then pObject.colPassiveWC = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "PassiveWC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TotalWRComplete")) Then pObject.colTotalWRComplete = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TotalWRComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MechEquipC")) Then pObject.colMechEquipC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MechEquipC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ElecEquipC")) Then pObject.colElecEquipC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ElecEquipC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BoilersC")) Then pObject.colBoilersC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "BoilersC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ProcEquipC")) Then pObject.colProcEquipC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ProcEquipC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OccupancyC")) Then pObject.colOccupancyC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "OccupancyC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CompSysC")) Then pObject.colCompSysC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "CompSysC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MechMaintC")) Then pObject.colMechMaintC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MechMaintC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ElecMaintC")) Then pObject.colElecMaintC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ElecMaintC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SparesC")) Then pObject.colSparesC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SparesC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementC")) Then pObject.colHumanElementC = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "HumanElementC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BCPC")) Then pObject.colBcpc = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "BCPC")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MechEquipWR")) Then pObject.colMechEquipWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MechEquipWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ElecEquipWR")) Then pObject.colElecEquipWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ElecEquipWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BoilersWR")) Then pObject.colBoilersWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "BoilersWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ProcEquipWR")) Then pObject.colProcEquipWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ProcEquipWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OccupancyWR")) Then pObject.colOccupancyWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "OccupancyWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CompSysWR")) Then pObject.colCompSysWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "CompSysWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MechMaintWR")) Then pObject.colMechMaintWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "MechMaintWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ElecMaintWR")) Then pObject.colElecMaintWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ElecMaintWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SparesWR")) Then pObject.colSparesWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "SparesWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementWR")) Then pObject.colHumanElementWR = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "HumanElementWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BCPWR")) Then pObject.colBcpwr = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "BCPWR")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MechEquipWeight")) Then pObject.colMechEquipWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "MechEquipWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ElecEquipWeight")) Then pObject.colElecEquipWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "ElecEquipWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BoilersWeight")) Then pObject.colBoilersWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "BoilersWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ProcEquipWeight")) Then pObject.colProcEquipWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "ProcEquipWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("OccupancyWeight")) Then pObject.colOccupancyWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "OccupancyWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CompSysWeight")) Then pObject.colCompSysWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "CompSysWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("MechMaintWeight")) Then pObject.colMechMaintWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "MechMaintWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ElecMaintWeight")) Then pObject.colElecMaintWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "ElecMaintWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SparesWeight")) Then pObject.colSparesWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "SparesWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HumanElementWeight")) Then pObject.colHumanElementWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "HumanElementWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("BCPWeight")) Then pObject.colBCPWeight = UtilSQLServer.SafeReader.SafeReadInt64(pReader, "BCPWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspProgramYearFROM")) Then pObject.colInspProgramYearFROM = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "InspProgramYearFROM")
			If Not pReader.IsDBNull(pReader.GetOrdinal("InspProgramYear")) Then pObject.colInspProgramYear = UtilSQLServer.SafeReader.SafeReadString(pReader, "InspProgramYear")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IBI")) Then pObject.colIbi = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "IBI")
			If Not pReader.IsDBNull(pReader.GetOrdinal("HighestLossExpectancy")) Then pObject.colHighestLossExpectancy = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "HighestLossExpectancy")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwBMLossEstimatesLatestFacilityRatingExtractSelect]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwBMLossEstimatesLatestFacilityRatingExtractSelect
        Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect

        Public Event Loaded(pUserState As Object) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFileprefix() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colFileprefix
            Get
                Return m_colFileprefix
            End Get
            Set
                If Not Same(m_colFileprefix, Value) Then
                    m_colFileprefix = Value
                    m_IsDirty(FieldIndex.colFileprefix) = True
                End If
            End Set
        End Property
        Private m_colFileprefix As String

        Public Property colFileNo() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colFileNo
            Get
                Return m_colFileNo
            End Get
            Set
                If Not Same(m_colFileNo, Value) Then
                    m_colFileNo = Value
                    m_IsDirty(FieldIndex.colFileNo) = True
                End If
            End Set
        End Property
        Private m_colFileNo As String

        Public Property colClient() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colClient
            Get
                Return m_colClient
            End Get
            Set
                If Not Same(m_colClient, Value) Then
                    m_colClient = Value
                    m_IsDirty(FieldIndex.colClient) = True
                End If
            End Set
        End Property
        Private m_colClient As String

        Public Property colClientLocNo() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colClientLocNo
            Get
                Return m_colClientLocNo
            End Get
            Set
                If Not Same(m_colClientLocNo, Value) Then
                    m_colClientLocNo = Value
                    m_IsDirty(FieldIndex.colClientLocNo) = True
                End If
            End Set
        End Property
        Private m_colClientLocNo As String

        Public Property colDivision() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colDivision
            Get
                Return m_colDivision
            End Get
            Set
                If Not Same(m_colDivision, Value) Then
                    m_colDivision = Value
                    m_IsDirty(FieldIndex.colDivision) = True
                End If
            End Set
        End Property
        Private m_colDivision As String

        Public Property colFacility() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colFacility
            Get
                Return m_colFacility
            End Get
            Set
                If Not Same(m_colFacility, Value) Then
                    m_colFacility = Value
                    m_IsDirty(FieldIndex.colFacility) = True
                End If
            End Set
        End Property
        Private m_colFacility As String

        Public Property colAddress() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colAddress
            Get
                Return m_colAddress
            End Get
            Set
                If Not Same(m_colAddress, Value) Then
                    m_colAddress = Value
                    m_IsDirty(FieldIndex.colAddress) = True
                End If
            End Set
        End Property
        Private m_colAddress As String

        Public Property colCity() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCity
            Get
                Return m_colCity
            End Get
            Set
                If Not Same(m_colCity, Value) Then
                    m_colCity = Value
                    m_IsDirty(FieldIndex.colCity) = True
                End If
            End Set
        End Property
        Private m_colCity As String

        Public Property colStProv() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colStProv
            Get
                Return m_colStProv
            End Get
            Set
                If Not Same(m_colStProv, Value) Then
                    m_colStProv = Value
                    m_IsDirty(FieldIndex.colStProv) = True
                End If
            End Set
        End Property
        Private m_colStProv As String

        Public Property colCountry() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCountry
            Get
                Return m_colCountry
            End Get
            Set
                If Not Same(m_colCountry, Value) Then
                    m_colCountry = Value
                    m_IsDirty(FieldIndex.colCountry) = True
                End If
            End Set
        End Property
        Private m_colCountry As String

        Public Property colInspectionDate() As Nullable(Of DateTime) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colInspectionDate
            Get
                Return m_colInspectionDate
            End Get
            Set
                If Not Same(m_colInspectionDate, Value) Then
                    m_colInspectionDate = Value
                    m_IsDirty(FieldIndex.colInspectionDate) = True
                End If
            End Set
        End Property
        Private m_colInspectionDate As Nullable(Of DateTime)

        Public Property colEngineer() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colEngineer
            Get
                Return m_colEngineer
            End Get
            Set
                If Not Same(m_colEngineer, Value) Then
                    m_colEngineer = Value
                    m_IsDirty(FieldIndex.colEngineer) = True
                End If
            End Set
        End Property
        Private m_colEngineer As String

        Public Property colCurrency() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCurrency
            Get
                Return m_colCurrency
            End Get
            Set
                If Not Same(m_colCurrency, Value) Then
                    m_colCurrency = Value
                    m_IsDirty(FieldIndex.colCurrency) = True
                End If
            End Set
        End Property
        Private m_colCurrency As String

        Public Property colBIReporting() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBIReporting
            Get
                Return m_colBIReporting
            End Get
            Set
                If Not Same(m_colBIReporting, Value) Then
                    m_colBIReporting = Value
                    m_IsDirty(FieldIndex.colBIReporting) = True
                End If
            End Set
        End Property
        Private m_colBIReporting As String

        Public Property colExchangeRate() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colExchangeRate
            Get
                Return m_colExchangeRate
            End Get
            Set
                If Not Same(m_colExchangeRate, Value) Then
                    m_colExchangeRate = Value
                    m_IsDirty(FieldIndex.colExchangeRate) = True
                End If
            End Set
        End Property
        Private m_colExchangeRate As Nullable(Of Double)

        Public Property colTivpd() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colTivpd
            Get
                Return m_colTivpd
            End Get
            Set
                If Not Same(m_colTivpd, Value) Then
                    m_colTivpd = Value
                    m_IsDirty(FieldIndex.colTivpd) = True
                End If
            End Set
        End Property
        Private m_colTivpd As Nullable(Of Double)

        Public Property colTivbi() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colTivbi
            Get
                Return m_colTivbi
            End Get
            Set
                If Not Same(m_colTivbi, Value) Then
                    m_colTivbi = Value
                    m_IsDirty(FieldIndex.colTivbi) = True
                End If
            End Set
        End Property
        Private m_colTivbi As Nullable(Of Double)

        Public Property colTiv() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colTiv
            Get
                Return m_colTiv
            End Get
            Set
                If Not Same(m_colTiv, Value) Then
                    m_colTiv = Value
                    m_IsDirty(FieldIndex.colTiv) = True
                End If
            End Set
        End Property
        Private m_colTiv As Nullable(Of Double)

        Public Property colPmlpd() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPmlpd
            Get
                Return m_colPmlpd
            End Get
            Set
                If Not Same(m_colPmlpd, Value) Then
                    m_colPmlpd = Value
                    m_IsDirty(FieldIndex.colPmlpd) = True
                End If
            End Set
        End Property
        Private m_colPmlpd As Nullable(Of Double)

        Public Property colPmlbi() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPmlbi
            Get
                Return m_colPmlbi
            End Get
            Set
                If Not Same(m_colPmlbi, Value) Then
                    m_colPmlbi = Value
                    m_IsDirty(FieldIndex.colPmlbi) = True
                End If
            End Set
        End Property
        Private m_colPmlbi As Nullable(Of Double)

        Public Property colPml() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPml
            Get
                Return m_colPml
            End Get
            Set
                If Not Same(m_colPml, Value) Then
                    m_colPml = Value
                    m_IsDirty(FieldIndex.colPml) = True
                End If
            End Set
        End Property
        Private m_colPml As Nullable(Of Double)

        Public Property colPMLPDPercent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPMLPDPercent
            Get
                Return m_colPMLPDPercent
            End Get
            Set
                If Not Same(m_colPMLPDPercent, Value) Then
                    m_colPMLPDPercent = Value
                    m_IsDirty(FieldIndex.colPMLPDPercent) = True
                End If
            End Set
        End Property
        Private m_colPMLPDPercent As Nullable(Of Double)

        Public Property colPMLBIPercent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPMLBIPercent
            Get
                Return m_colPMLBIPercent
            End Get
            Set
                If Not Same(m_colPMLBIPercent, Value) Then
                    m_colPMLBIPercent = Value
                    m_IsDirty(FieldIndex.colPMLBIPercent) = True
                End If
            End Set
        End Property
        Private m_colPMLBIPercent As Nullable(Of Double)

        Public Property colPMLPercent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPMLPercent
            Get
                Return m_colPMLPercent
            End Get
            Set
                If Not Same(m_colPMLPercent, Value) Then
                    m_colPMLPercent = Value
                    m_IsDirty(FieldIndex.colPMLPercent) = True
                End If
            End Set
        End Property
        Private m_colPMLPercent As Nullable(Of Double)

        Public Property colMflpd() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMflpd
            Get
                Return m_colMflpd
            End Get
            Set
                If Not Same(m_colMflpd, Value) Then
                    m_colMflpd = Value
                    m_IsDirty(FieldIndex.colMflpd) = True
                End If
            End Set
        End Property
        Private m_colMflpd As Nullable(Of Double)

        Public Property colMflbi() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMflbi
            Get
                Return m_colMflbi
            End Get
            Set
                If Not Same(m_colMflbi, Value) Then
                    m_colMflbi = Value
                    m_IsDirty(FieldIndex.colMflbi) = True
                End If
            End Set
        End Property
        Private m_colMflbi As Nullable(Of Double)

        Public Property colMfl() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMfl
            Get
                Return m_colMfl
            End Get
            Set
                If Not Same(m_colMfl, Value) Then
                    m_colMfl = Value
                    m_IsDirty(FieldIndex.colMfl) = True
                End If
            End Set
        End Property
        Private m_colMfl As Nullable(Of Double)

        Public Property colMFLPDPercent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMFLPDPercent
            Get
                Return m_colMFLPDPercent
            End Get
            Set
                If Not Same(m_colMFLPDPercent, Value) Then
                    m_colMFLPDPercent = Value
                    m_IsDirty(FieldIndex.colMFLPDPercent) = True
                End If
            End Set
        End Property
        Private m_colMFLPDPercent As Nullable(Of Double)

        Public Property colMFLBIPercent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMFLBIPercent
            Get
                Return m_colMFLBIPercent
            End Get
            Set
                If Not Same(m_colMFLBIPercent, Value) Then
                    m_colMFLBIPercent = Value
                    m_IsDirty(FieldIndex.colMFLBIPercent) = True
                End If
            End Set
        End Property
        Private m_colMFLBIPercent As Nullable(Of Double)

        Public Property colMFLPercent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMFLPercent
            Get
                Return m_colMFLPercent
            End Get
            Set
                If Not Same(m_colMFLPercent, Value) Then
                    m_colMFLPercent = Value
                    m_IsDirty(FieldIndex.colMFLPercent) = True
                End If
            End Set
        End Property
        Private m_colMFLPercent As Nullable(Of Double)

        Public Property colInterdependencies() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colInterdependencies
            Get
                Return m_colInterdependencies
            End Get
            Set
                If Not Same(m_colInterdependencies, Value) Then
                    m_colInterdependencies = Value
                    m_IsDirty(FieldIndex.colInterdependencies) = True
                End If
            End Set
        End Property
        Private m_colInterdependencies As String

        Public Property colLEandInterdependecyComments() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colLEandInterdependecyComments
            Get
                Return m_colLEandInterdependecyComments
            End Get
            Set
                If Not Same(m_colLEandInterdependecyComments, Value) Then
                    m_colLEandInterdependecyComments = Value
                    m_IsDirty(FieldIndex.colLEandInterdependecyComments) = True
                End If
            End Set
        End Property
        Private m_colLEandInterdependecyComments As String

        Public Property colLossesLast3Years() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colLossesLast3Years
            Get
                Return m_colLossesLast3Years
            End Get
            Set
                If Not Same(m_colLossesLast3Years, Value) Then
                    m_colLossesLast3Years = Value
                    m_IsDirty(FieldIndex.colLossesLast3Years) = True
                End If
            End Set
        End Property
        Private m_colLossesLast3Years As String

        Public Property colLossHistoryDescription() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colLossHistoryDescription
            Get
                Return m_colLossHistoryDescription
            End Get
            Set
                If Not Same(m_colLossHistoryDescription, Value) Then
                    m_colLossHistoryDescription = Value
                    m_IsDirty(FieldIndex.colLossHistoryDescription) = True
                End If
            End Set
        End Property
        Private m_colLossHistoryDescription As String

        Public Property colActiveC() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colActiveC
            Get
                Return m_colActiveC
            End Get
            Set
                If Not Same(m_colActiveC, Value) Then
                    m_colActiveC = Value
                    m_IsDirty(FieldIndex.colActiveC) = True
                End If
            End Set
        End Property
        Private m_colActiveC As Nullable(Of Double)

        Public Property colPassiveC() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPassiveC
            Get
                Return m_colPassiveC
            End Get
            Set
                If Not Same(m_colPassiveC, Value) Then
                    m_colPassiveC = Value
                    m_IsDirty(FieldIndex.colPassiveC) = True
                End If
            End Set
        End Property
        Private m_colPassiveC As Nullable(Of Double)

        Public Property colTotalScoreCurrent() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colTotalScoreCurrent
            Get
                Return m_colTotalScoreCurrent
            End Get
            Set
                If Not Same(m_colTotalScoreCurrent, Value) Then
                    m_colTotalScoreCurrent = Value
                    m_IsDirty(FieldIndex.colTotalScoreCurrent) = True
                End If
            End Set
        End Property
        Private m_colTotalScoreCurrent As Nullable(Of Double)

        Public Property colOverallRating() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colOverallRating
            Get
                Return m_colOverallRating
            End Get
            Set
                If Not Same(m_colOverallRating, Value) Then
                    m_colOverallRating = Value
                    m_IsDirty(FieldIndex.colOverallRating) = True
                End If
            End Set
        End Property
        Private m_colOverallRating As String

        Public Property colTotalscorecurrentColor() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colTotalscorecurrentColor
            Get
                Return m_colTotalscorecurrentColor
            End Get
            Set
                If Not Same(m_colTotalscorecurrentColor, Value) Then
                    m_colTotalscorecurrentColor = Value
                    m_IsDirty(FieldIndex.colTotalscorecurrentColor) = True
                End If
            End Set
        End Property
        Private m_colTotalscorecurrentColor As String

        Public Property colOccupancy() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colOccupancy
            Get
                Return m_colOccupancy
            End Get
            Set
                If Not Same(m_colOccupancy, Value) Then
                    m_colOccupancy = Value
                    m_IsDirty(FieldIndex.colOccupancy) = True
                End If
            End Set
        End Property
        Private m_colOccupancy As String

        Public Property colIndustryGroup() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colIndustryGroup
            Get
                Return m_colIndustryGroup
            End Get
            Set
                If Not Same(m_colIndustryGroup, Value) Then
                    m_colIndustryGroup = Value
                    m_IsDirty(FieldIndex.colIndustryGroup) = True
                End If
            End Set
        End Property
        Private m_colIndustryGroup As String

        Public Property colMajorGroup() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMajorGroup
            Get
                Return m_colMajorGroup
            End Get
            Set
                If Not Same(m_colMajorGroup, Value) Then
                    m_colMajorGroup = Value
                    m_IsDirty(FieldIndex.colMajorGroup) = True
                End If
            End Set
        End Property
        Private m_colMajorGroup As String

        Public Property colSpecificGroup() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colSpecificGroup
            Get
                Return m_colSpecificGroup
            End Get
            Set
                If Not Same(m_colSpecificGroup, Value) Then
                    m_colSpecificGroup = Value
                    m_IsDirty(FieldIndex.colSpecificGroup) = True
                End If
            End Set
        End Property
        Private m_colSpecificGroup As String

        Public Property colActiveWC() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colActiveWC
            Get
                Return m_colActiveWC
            End Get
            Set
                If Not Same(m_colActiveWC, Value) Then
                    m_colActiveWC = Value
                    m_IsDirty(FieldIndex.colActiveWC) = True
                End If
            End Set
        End Property
        Private m_colActiveWC As Nullable(Of Double)

        Public Property colPassiveWC() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colPassiveWC
            Get
                Return m_colPassiveWC
            End Get
            Set
                If Not Same(m_colPassiveWC, Value) Then
                    m_colPassiveWC = Value
                    m_IsDirty(FieldIndex.colPassiveWC) = True
                End If
            End Set
        End Property
        Private m_colPassiveWC As Nullable(Of Double)

        Public Property colTotalWRComplete() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colTotalWRComplete
            Get
                Return m_colTotalWRComplete
            End Get
            Set
                If Not Same(m_colTotalWRComplete, Value) Then
                    m_colTotalWRComplete = Value
                    m_IsDirty(FieldIndex.colTotalWRComplete) = True
                End If
            End Set
        End Property
        Private m_colTotalWRComplete As Nullable(Of Double)

        Public Property colMechEquipC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMechEquipC
            Get
                Return m_colMechEquipC
            End Get
            Set
                If Not Same(m_colMechEquipC, Value) Then
                    m_colMechEquipC = Value
                    m_IsDirty(FieldIndex.colMechEquipC) = True
                End If
            End Set
        End Property
        Private m_colMechEquipC As Nullable(Of Integer)

        Public Property colElecEquipC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colElecEquipC
            Get
                Return m_colElecEquipC
            End Get
            Set
                If Not Same(m_colElecEquipC, Value) Then
                    m_colElecEquipC = Value
                    m_IsDirty(FieldIndex.colElecEquipC) = True
                End If
            End Set
        End Property
        Private m_colElecEquipC As Nullable(Of Integer)

        Public Property colBoilersC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBoilersC
            Get
                Return m_colBoilersC
            End Get
            Set
                If Not Same(m_colBoilersC, Value) Then
                    m_colBoilersC = Value
                    m_IsDirty(FieldIndex.colBoilersC) = True
                End If
            End Set
        End Property
        Private m_colBoilersC As Nullable(Of Integer)

        Public Property colProcEquipC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colProcEquipC
            Get
                Return m_colProcEquipC
            End Get
            Set
                If Not Same(m_colProcEquipC, Value) Then
                    m_colProcEquipC = Value
                    m_IsDirty(FieldIndex.colProcEquipC) = True
                End If
            End Set
        End Property
        Private m_colProcEquipC As Nullable(Of Integer)

        Public Property colOccupancyC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colOccupancyC
            Get
                Return m_colOccupancyC
            End Get
            Set
                If Not Same(m_colOccupancyC, Value) Then
                    m_colOccupancyC = Value
                    m_IsDirty(FieldIndex.colOccupancyC) = True
                End If
            End Set
        End Property
        Private m_colOccupancyC As Nullable(Of Integer)

        Public Property colCompSysC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCompSysC
            Get
                Return m_colCompSysC
            End Get
            Set
                If Not Same(m_colCompSysC, Value) Then
                    m_colCompSysC = Value
                    m_IsDirty(FieldIndex.colCompSysC) = True
                End If
            End Set
        End Property
        Private m_colCompSysC As Nullable(Of Integer)

        Public Property colMechMaintC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMechMaintC
            Get
                Return m_colMechMaintC
            End Get
            Set
                If Not Same(m_colMechMaintC, Value) Then
                    m_colMechMaintC = Value
                    m_IsDirty(FieldIndex.colMechMaintC) = True
                End If
            End Set
        End Property
        Private m_colMechMaintC As Nullable(Of Integer)

        Public Property colElecMaintC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colElecMaintC
            Get
                Return m_colElecMaintC
            End Get
            Set
                If Not Same(m_colElecMaintC, Value) Then
                    m_colElecMaintC = Value
                    m_IsDirty(FieldIndex.colElecMaintC) = True
                End If
            End Set
        End Property
        Private m_colElecMaintC As Nullable(Of Integer)

        Public Property colSparesC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colSparesC
            Get
                Return m_colSparesC
            End Get
            Set
                If Not Same(m_colSparesC, Value) Then
                    m_colSparesC = Value
                    m_IsDirty(FieldIndex.colSparesC) = True
                End If
            End Set
        End Property
        Private m_colSparesC As Nullable(Of Integer)

        Public Property colHumanElementC() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colHumanElementC
            Get
                Return m_colHumanElementC
            End Get
            Set
                If Not Same(m_colHumanElementC, Value) Then
                    m_colHumanElementC = Value
                    m_IsDirty(FieldIndex.colHumanElementC) = True
                End If
            End Set
        End Property
        Private m_colHumanElementC As Nullable(Of Integer)

        Public Property colBcpc() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBcpc
            Get
                Return m_colBcpc
            End Get
            Set
                If Not Same(m_colBcpc, Value) Then
                    m_colBcpc = Value
                    m_IsDirty(FieldIndex.colBcpc) = True
                End If
            End Set
        End Property
        Private m_colBcpc As Nullable(Of Integer)

        Public Property colMechEquipWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMechEquipWR
            Get
                Return m_colMechEquipWR
            End Get
            Set
                If Not Same(m_colMechEquipWR, Value) Then
                    m_colMechEquipWR = Value
                    m_IsDirty(FieldIndex.colMechEquipWR) = True
                End If
            End Set
        End Property
        Private m_colMechEquipWR As Nullable(Of Integer)

        Public Property colElecEquipWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colElecEquipWR
            Get
                Return m_colElecEquipWR
            End Get
            Set
                If Not Same(m_colElecEquipWR, Value) Then
                    m_colElecEquipWR = Value
                    m_IsDirty(FieldIndex.colElecEquipWR) = True
                End If
            End Set
        End Property
        Private m_colElecEquipWR As Nullable(Of Integer)

        Public Property colBoilersWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBoilersWR
            Get
                Return m_colBoilersWR
            End Get
            Set
                If Not Same(m_colBoilersWR, Value) Then
                    m_colBoilersWR = Value
                    m_IsDirty(FieldIndex.colBoilersWR) = True
                End If
            End Set
        End Property
        Private m_colBoilersWR As Nullable(Of Integer)

        Public Property colProcEquipWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colProcEquipWR
            Get
                Return m_colProcEquipWR
            End Get
            Set
                If Not Same(m_colProcEquipWR, Value) Then
                    m_colProcEquipWR = Value
                    m_IsDirty(FieldIndex.colProcEquipWR) = True
                End If
            End Set
        End Property
        Private m_colProcEquipWR As Nullable(Of Integer)

        Public Property colOccupancyWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colOccupancyWR
            Get
                Return m_colOccupancyWR
            End Get
            Set
                If Not Same(m_colOccupancyWR, Value) Then
                    m_colOccupancyWR = Value
                    m_IsDirty(FieldIndex.colOccupancyWR) = True
                End If
            End Set
        End Property
        Private m_colOccupancyWR As Nullable(Of Integer)

        Public Property colCompSysWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCompSysWR
            Get
                Return m_colCompSysWR
            End Get
            Set
                If Not Same(m_colCompSysWR, Value) Then
                    m_colCompSysWR = Value
                    m_IsDirty(FieldIndex.colCompSysWR) = True
                End If
            End Set
        End Property
        Private m_colCompSysWR As Nullable(Of Integer)

        Public Property colMechMaintWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMechMaintWR
            Get
                Return m_colMechMaintWR
            End Get
            Set
                If Not Same(m_colMechMaintWR, Value) Then
                    m_colMechMaintWR = Value
                    m_IsDirty(FieldIndex.colMechMaintWR) = True
                End If
            End Set
        End Property
        Private m_colMechMaintWR As Nullable(Of Integer)

        Public Property colElecMaintWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colElecMaintWR
            Get
                Return m_colElecMaintWR
            End Get
            Set
                If Not Same(m_colElecMaintWR, Value) Then
                    m_colElecMaintWR = Value
                    m_IsDirty(FieldIndex.colElecMaintWR) = True
                End If
            End Set
        End Property
        Private m_colElecMaintWR As Nullable(Of Integer)

        Public Property colSparesWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colSparesWR
            Get
                Return m_colSparesWR
            End Get
            Set
                If Not Same(m_colSparesWR, Value) Then
                    m_colSparesWR = Value
                    m_IsDirty(FieldIndex.colSparesWR) = True
                End If
            End Set
        End Property
        Private m_colSparesWR As Nullable(Of Integer)

        Public Property colHumanElementWR() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colHumanElementWR
            Get
                Return m_colHumanElementWR
            End Get
            Set
                If Not Same(m_colHumanElementWR, Value) Then
                    m_colHumanElementWR = Value
                    m_IsDirty(FieldIndex.colHumanElementWR) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWR As Nullable(Of Integer)

        Public Property colBcpwr() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBcpwr
            Get
                Return m_colBcpwr
            End Get
            Set
                If Not Same(m_colBcpwr, Value) Then
                    m_colBcpwr = Value
                    m_IsDirty(FieldIndex.colBcpwr) = True
                End If
            End Set
        End Property
        Private m_colBcpwr As Nullable(Of Integer)

        Public Property colMechEquipWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMechEquipWeight
            Get
                Return m_colMechEquipWeight
            End Get
            Set
                If Not Same(m_colMechEquipWeight, Value) Then
                    m_colMechEquipWeight = Value
                    m_IsDirty(FieldIndex.colMechEquipWeight) = True
                End If
            End Set
        End Property
        Private m_colMechEquipWeight As Nullable(Of Long)

        Public Property colElecEquipWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colElecEquipWeight
            Get
                Return m_colElecEquipWeight
            End Get
            Set
                If Not Same(m_colElecEquipWeight, Value) Then
                    m_colElecEquipWeight = Value
                    m_IsDirty(FieldIndex.colElecEquipWeight) = True
                End If
            End Set
        End Property
        Private m_colElecEquipWeight As Nullable(Of Long)

        Public Property colBoilersWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBoilersWeight
            Get
                Return m_colBoilersWeight
            End Get
            Set
                If Not Same(m_colBoilersWeight, Value) Then
                    m_colBoilersWeight = Value
                    m_IsDirty(FieldIndex.colBoilersWeight) = True
                End If
            End Set
        End Property
        Private m_colBoilersWeight As Nullable(Of Long)

        Public Property colProcEquipWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colProcEquipWeight
            Get
                Return m_colProcEquipWeight
            End Get
            Set
                If Not Same(m_colProcEquipWeight, Value) Then
                    m_colProcEquipWeight = Value
                    m_IsDirty(FieldIndex.colProcEquipWeight) = True
                End If
            End Set
        End Property
        Private m_colProcEquipWeight As Nullable(Of Long)

        Public Property colOccupancyWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colOccupancyWeight
            Get
                Return m_colOccupancyWeight
            End Get
            Set
                If Not Same(m_colOccupancyWeight, Value) Then
                    m_colOccupancyWeight = Value
                    m_IsDirty(FieldIndex.colOccupancyWeight) = True
                End If
            End Set
        End Property
        Private m_colOccupancyWeight As Nullable(Of Long)

        Public Property colCompSysWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCompSysWeight
            Get
                Return m_colCompSysWeight
            End Get
            Set
                If Not Same(m_colCompSysWeight, Value) Then
                    m_colCompSysWeight = Value
                    m_IsDirty(FieldIndex.colCompSysWeight) = True
                End If
            End Set
        End Property
        Private m_colCompSysWeight As Nullable(Of Long)

        Public Property colMechMaintWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colMechMaintWeight
            Get
                Return m_colMechMaintWeight
            End Get
            Set
                If Not Same(m_colMechMaintWeight, Value) Then
                    m_colMechMaintWeight = Value
                    m_IsDirty(FieldIndex.colMechMaintWeight) = True
                End If
            End Set
        End Property
        Private m_colMechMaintWeight As Nullable(Of Long)

        Public Property colElecMaintWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colElecMaintWeight
            Get
                Return m_colElecMaintWeight
            End Get
            Set
                If Not Same(m_colElecMaintWeight, Value) Then
                    m_colElecMaintWeight = Value
                    m_IsDirty(FieldIndex.colElecMaintWeight) = True
                End If
            End Set
        End Property
        Private m_colElecMaintWeight As Nullable(Of Long)

        Public Property colSparesWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colSparesWeight
            Get
                Return m_colSparesWeight
            End Get
            Set
                If Not Same(m_colSparesWeight, Value) Then
                    m_colSparesWeight = Value
                    m_IsDirty(FieldIndex.colSparesWeight) = True
                End If
            End Set
        End Property
        Private m_colSparesWeight As Nullable(Of Long)

        Public Property colHumanElementWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colHumanElementWeight
            Get
                Return m_colHumanElementWeight
            End Get
            Set
                If Not Same(m_colHumanElementWeight, Value) Then
                    m_colHumanElementWeight = Value
                    m_IsDirty(FieldIndex.colHumanElementWeight) = True
                End If
            End Set
        End Property
        Private m_colHumanElementWeight As Nullable(Of Long)

        Public Property colBCPWeight() As Nullable(Of Long) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colBCPWeight
            Get
                Return m_colBCPWeight
            End Get
            Set
                If Not Same(m_colBCPWeight, Value) Then
                    m_colBCPWeight = Value
                    m_IsDirty(FieldIndex.colBCPWeight) = True
                End If
            End Set
        End Property
        Private m_colBCPWeight As Nullable(Of Long)

        Public Property colCustomAccess() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colCustomAccess
            Get
                Return m_colCustomAccess
            End Get
            Set
                If Not Same(m_colCustomAccess, Value) Then
                    m_colCustomAccess = Value
                    m_IsDirty(FieldIndex.colCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colCustomAccess As String

        Public Property colInspProgramYearFROM() As Nullable(Of DateTime) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colInspProgramYearFROM
            Get
                Return m_colInspProgramYearFROM
            End Get
            Set
                If Not Same(m_colInspProgramYearFROM, Value) Then
                    m_colInspProgramYearFROM = Value
                    m_IsDirty(FieldIndex.colInspProgramYearFROM) = True
                End If
            End Set
        End Property
        Private m_colInspProgramYearFROM As Nullable(Of DateTime)

        Public Property colInspProgramYear() As String Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colInspProgramYear
            Get
                Return m_colInspProgramYear
            End Get
            Set
                If Not Same(m_colInspProgramYear, Value) Then
                    m_colInspProgramYear = Value
                    m_IsDirty(FieldIndex.colInspProgramYear) = True
                End If
            End Set
        End Property
        Private m_colInspProgramYear As String

        Public Property colIbi() As Nullable(Of Double) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colIbi
            Get
                Return m_colIbi
            End Get
            Set
                If Not Same(m_colIbi, Value) Then
                    m_colIbi = Value
                    m_IsDirty(FieldIndex.colIbi) = True
                End If
            End Set
        End Property
        Private m_colIbi As Nullable(Of Double)

        Public Property colHighestLossExpectancy() As Nullable(Of Integer) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.colHighestLossExpectancy
            Get
                Return m_colHighestLossExpectancy
            End Get
            Set
                If Not Same(m_colHighestLossExpectancy, Value) Then
                    m_colHighestLossExpectancy = Value
                    m_IsDirty(FieldIndex.colHighestLossExpectancy) = True
                End If
            End Set
        End Property
        Private m_colHighestLossExpectancy As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowVwBMLossEstimatesLatestFacilityRatingExtractSelect.FieldIndex) As Boolean Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect.SetIsDirty
            m_IsDirty(FieldIndex.colFileprefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colClient) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colAddress) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colInspectionDate) = pDirty
            m_IsDirty(FieldIndex.colEngineer) = pDirty
            m_IsDirty(FieldIndex.colCurrency) = pDirty
            m_IsDirty(FieldIndex.colBIReporting) = pDirty
            m_IsDirty(FieldIndex.colExchangeRate) = pDirty
            m_IsDirty(FieldIndex.colTivpd) = pDirty
            m_IsDirty(FieldIndex.colTivbi) = pDirty
            m_IsDirty(FieldIndex.colTiv) = pDirty
            m_IsDirty(FieldIndex.colPmlpd) = pDirty
            m_IsDirty(FieldIndex.colPmlbi) = pDirty
            m_IsDirty(FieldIndex.colPml) = pDirty
            m_IsDirty(FieldIndex.colPMLPDPercent) = pDirty
            m_IsDirty(FieldIndex.colPMLBIPercent) = pDirty
            m_IsDirty(FieldIndex.colPMLPercent) = pDirty
            m_IsDirty(FieldIndex.colMflpd) = pDirty
            m_IsDirty(FieldIndex.colMflbi) = pDirty
            m_IsDirty(FieldIndex.colMfl) = pDirty
            m_IsDirty(FieldIndex.colMFLPDPercent) = pDirty
            m_IsDirty(FieldIndex.colMFLBIPercent) = pDirty
            m_IsDirty(FieldIndex.colMFLPercent) = pDirty
            m_IsDirty(FieldIndex.colInterdependencies) = pDirty
            m_IsDirty(FieldIndex.colLEandInterdependecyComments) = pDirty
            m_IsDirty(FieldIndex.colLossesLast3Years) = pDirty
            m_IsDirty(FieldIndex.colLossHistoryDescription) = pDirty
            m_IsDirty(FieldIndex.colActiveC) = pDirty
            m_IsDirty(FieldIndex.colPassiveC) = pDirty
            m_IsDirty(FieldIndex.colTotalScoreCurrent) = pDirty
            m_IsDirty(FieldIndex.colOverallRating) = pDirty
            m_IsDirty(FieldIndex.colTotalscorecurrentColor) = pDirty
            m_IsDirty(FieldIndex.colOccupancy) = pDirty
            m_IsDirty(FieldIndex.colIndustryGroup) = pDirty
            m_IsDirty(FieldIndex.colMajorGroup) = pDirty
            m_IsDirty(FieldIndex.colSpecificGroup) = pDirty
            m_IsDirty(FieldIndex.colActiveWC) = pDirty
            m_IsDirty(FieldIndex.colPassiveWC) = pDirty
            m_IsDirty(FieldIndex.colTotalWRComplete) = pDirty
            m_IsDirty(FieldIndex.colMechEquipC) = pDirty
            m_IsDirty(FieldIndex.colElecEquipC) = pDirty
            m_IsDirty(FieldIndex.colBoilersC) = pDirty
            m_IsDirty(FieldIndex.colProcEquipC) = pDirty
            m_IsDirty(FieldIndex.colOccupancyC) = pDirty
            m_IsDirty(FieldIndex.colCompSysC) = pDirty
            m_IsDirty(FieldIndex.colMechMaintC) = pDirty
            m_IsDirty(FieldIndex.colElecMaintC) = pDirty
            m_IsDirty(FieldIndex.colSparesC) = pDirty
            m_IsDirty(FieldIndex.colHumanElementC) = pDirty
            m_IsDirty(FieldIndex.colBcpc) = pDirty
            m_IsDirty(FieldIndex.colMechEquipWR) = pDirty
            m_IsDirty(FieldIndex.colElecEquipWR) = pDirty
            m_IsDirty(FieldIndex.colBoilersWR) = pDirty
            m_IsDirty(FieldIndex.colProcEquipWR) = pDirty
            m_IsDirty(FieldIndex.colOccupancyWR) = pDirty
            m_IsDirty(FieldIndex.colCompSysWR) = pDirty
            m_IsDirty(FieldIndex.colMechMaintWR) = pDirty
            m_IsDirty(FieldIndex.colElecMaintWR) = pDirty
            m_IsDirty(FieldIndex.colSparesWR) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWR) = pDirty
            m_IsDirty(FieldIndex.colBcpwr) = pDirty
            m_IsDirty(FieldIndex.colMechEquipWeight) = pDirty
            m_IsDirty(FieldIndex.colElecEquipWeight) = pDirty
            m_IsDirty(FieldIndex.colBoilersWeight) = pDirty
            m_IsDirty(FieldIndex.colProcEquipWeight) = pDirty
            m_IsDirty(FieldIndex.colOccupancyWeight) = pDirty
            m_IsDirty(FieldIndex.colCompSysWeight) = pDirty
            m_IsDirty(FieldIndex.colMechMaintWeight) = pDirty
            m_IsDirty(FieldIndex.colElecMaintWeight) = pDirty
            m_IsDirty(FieldIndex.colSparesWeight) = pDirty
            m_IsDirty(FieldIndex.colHumanElementWeight) = pDirty
            m_IsDirty(FieldIndex.colBCPWeight) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colInspProgramYearFROM) = pDirty
            m_IsDirty(FieldIndex.colInspProgramYear) = pDirty
            m_IsDirty(FieldIndex.colIbi) = pDirty
            m_IsDirty(FieldIndex.colHighestLossExpectancy) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwBMLossEstimatesLatestFacilityRatingExtractSelect) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwBMLossEstimatesLatestFacilityRatingExtractSelect
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFileprefix  = 1
            colFileNo 
            colClient 
            colClientLocNo 
            colDivision 
            colFacility 
            colAddress 
            colCity 
            colStProv 
            colCountry 
            colInspectionDate 
            colEngineer 
            colCurrency 
            colBIReporting 
            colExchangeRate 
            colTivpd 
            colTivbi 
            colTiv 
            colPmlpd 
            colPmlbi 
            colPml 
            colPMLPDPercent 
            colPMLBIPercent 
            colPMLPercent 
            colMflpd 
            colMflbi 
            colMfl 
            colMFLPDPercent 
            colMFLBIPercent 
            colMFLPercent 
            colInterdependencies 
            colLEandInterdependecyComments 
            colLossesLast3Years 
            colLossHistoryDescription 
            colActiveC 
            colPassiveC 
            colTotalScoreCurrent 
            colOverallRating 
            colTotalscorecurrentColor 
            colOccupancy 
            colIndustryGroup 
            colMajorGroup 
            colSpecificGroup 
            colActiveWC 
            colPassiveWC 
            colTotalWRComplete 
            colMechEquipC 
            colElecEquipC 
            colBoilersC 
            colProcEquipC 
            colOccupancyC 
            colCompSysC 
            colMechMaintC 
            colElecMaintC 
            colSparesC 
            colHumanElementC 
            colBcpc 
            colMechEquipWR 
            colElecEquipWR 
            colBoilersWR 
            colProcEquipWR 
            colOccupancyWR 
            colCompSysWR 
            colMechMaintWR 
            colElecMaintWR 
            colSparesWR 
            colHumanElementWR 
            colBcpwr 
            colMechEquipWeight 
            colElecEquipWeight 
            colBoilersWeight 
            colProcEquipWeight 
            colOccupancyWeight 
            colCompSysWeight 
            colMechMaintWeight 
            colElecMaintWeight 
            colSparesWeight 
            colHumanElementWeight 
            colBCPWeight 
            colCustomAccess 
            colInspProgramYearFROM 
            colInspProgramYear 
            colIbi 
            colHighestLossExpectancy 
        End Enum

        Private m_IsDirty(84) As Boolean

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

    Public Interface IrowVwBMLossEstimatesLatestFacilityRatingExtractSelect
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFileprefix() As String
        Property colFileNo() As String
        Property colClient() As String
        Property colClientLocNo() As String
        Property colDivision() As String
        Property colFacility() As String
        Property colAddress() As String
        Property colCity() As String
        Property colStProv() As String
        Property colCountry() As String
        Property colInspectionDate() As Nullable(Of DateTime)
        Property colEngineer() As String
        Property colCurrency() As String
        Property colBIReporting() As String
        Property colExchangeRate() As Nullable(Of Double)
        Property colTivpd() As Nullable(Of Double)
        Property colTivbi() As Nullable(Of Double)
        Property colTiv() As Nullable(Of Double)
        Property colPmlpd() As Nullable(Of Double)
        Property colPmlbi() As Nullable(Of Double)
        Property colPml() As Nullable(Of Double)
        Property colPMLPDPercent() As Nullable(Of Double)
        Property colPMLBIPercent() As Nullable(Of Double)
        Property colPMLPercent() As Nullable(Of Double)
        Property colMflpd() As Nullable(Of Double)
        Property colMflbi() As Nullable(Of Double)
        Property colMfl() As Nullable(Of Double)
        Property colMFLPDPercent() As Nullable(Of Double)
        Property colMFLBIPercent() As Nullable(Of Double)
        Property colMFLPercent() As Nullable(Of Double)
        Property colInterdependencies() As String
        Property colLEandInterdependecyComments() As String
        Property colLossesLast3Years() As String
        Property colLossHistoryDescription() As String
        Property colActiveC() As Nullable(Of Double)
        Property colPassiveC() As Nullable(Of Double)
        Property colTotalScoreCurrent() As Nullable(Of Double)
        Property colOverallRating() As String
        Property colTotalscorecurrentColor() As String
        Property colOccupancy() As String
        Property colIndustryGroup() As String
        Property colMajorGroup() As String
        Property colSpecificGroup() As String
        Property colActiveWC() As Nullable(Of Double)
        Property colPassiveWC() As Nullable(Of Double)
        Property colTotalWRComplete() As Nullable(Of Double)
        Property colMechEquipC() As Nullable(Of Integer)
        Property colElecEquipC() As Nullable(Of Integer)
        Property colBoilersC() As Nullable(Of Integer)
        Property colProcEquipC() As Nullable(Of Integer)
        Property colOccupancyC() As Nullable(Of Integer)
        Property colCompSysC() As Nullable(Of Integer)
        Property colMechMaintC() As Nullable(Of Integer)
        Property colElecMaintC() As Nullable(Of Integer)
        Property colSparesC() As Nullable(Of Integer)
        Property colHumanElementC() As Nullable(Of Integer)
        Property colBcpc() As Nullable(Of Integer)
        Property colMechEquipWR() As Nullable(Of Integer)
        Property colElecEquipWR() As Nullable(Of Integer)
        Property colBoilersWR() As Nullable(Of Integer)
        Property colProcEquipWR() As Nullable(Of Integer)
        Property colOccupancyWR() As Nullable(Of Integer)
        Property colCompSysWR() As Nullable(Of Integer)
        Property colMechMaintWR() As Nullable(Of Integer)
        Property colElecMaintWR() As Nullable(Of Integer)
        Property colSparesWR() As Nullable(Of Integer)
        Property colHumanElementWR() As Nullable(Of Integer)
        Property colBcpwr() As Nullable(Of Integer)
        Property colMechEquipWeight() As Nullable(Of Long)
        Property colElecEquipWeight() As Nullable(Of Long)
        Property colBoilersWeight() As Nullable(Of Long)
        Property colProcEquipWeight() As Nullable(Of Long)
        Property colOccupancyWeight() As Nullable(Of Long)
        Property colCompSysWeight() As Nullable(Of Long)
        Property colMechMaintWeight() As Nullable(Of Long)
        Property colElecMaintWeight() As Nullable(Of Long)
        Property colSparesWeight() As Nullable(Of Long)
        Property colHumanElementWeight() As Nullable(Of Long)
        Property colBCPWeight() As Nullable(Of Long)
        Property colCustomAccess() As String
        Property colInspProgramYearFROM() As Nullable(Of DateTime)
        Property colInspProgramYear() As String
        Property colIbi() As Nullable(Of Double)
        Property colHighestLossExpectancy() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowVwBMLossEstimatesLatestFacilityRatingExtractSelect.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

