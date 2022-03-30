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
    Partial Public Class VwWhatIfFireRecGrid

        Public Shared Function LoadData() As List(Of rowVwWhatIfFireRecGrid)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowVwWhatIfFireRecGrid)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowVwWhatIfFireRecGrid)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowVwWhatIfFireRecGrid)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwWhatIfFireRecGrid)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowVwWhatIfFireRecGrid)
            Dim zReturn As New List(Of rowVwWhatIfFireRecGrid)
            Dim zSQL As String = "SELECT * FROM [gv].[vwWhatIfFireRecGrid]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowVwWhatIfFireRecGrid)

			Try
	            Dim zReturn As New List(Of rowVwWhatIfFireRecGrid)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowVwWhatIfFireRecGrid

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowVwWhatIfFireRecGrid		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowVwWhatIfFireRecGrid)
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecID")) Then pObject.colRecID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("GSafeId")) Then pObject.colGSafeId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "GSafeId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FilePrefix")) Then pObject.colFilePrefix = UtilSQLServer.SafeReader.SafeReadString(pReader, "FilePrefix")
			If Not pReader.IsDBNull(pReader.GetOrdinal("FileNo")) Then pObject.colFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "FileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Client")) Then pObject.colClient = UtilSQLServer.SafeReader.SafeReadString(pReader, "Client")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ClientLocNo")) Then pObject.colClientLocNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "ClientLocNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Division")) Then pObject.colDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "Division")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CustomAccess")) Then pObject.colCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "CustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Facility")) Then pObject.colFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "Facility")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Address")) Then pObject.colAddress = UtilSQLServer.SafeReader.SafeReadString(pReader, "Address")
			If Not pReader.IsDBNull(pReader.GetOrdinal("City")) Then pObject.colCity = UtilSQLServer.SafeReader.SafeReadString(pReader, "City")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProv")) Then pObject.colStProv = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProv")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Zip")) Then pObject.colZip = UtilSQLServer.SafeReader.SafeReadString(pReader, "Zip")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Country")) Then pObject.colCountry = UtilSQLServer.SafeReader.SafeReadString(pReader, "Country")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Latitude")) Then pObject.colLatitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Latitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("Longitude")) Then pObject.colLongitude = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "Longitude")
			If Not pReader.IsDBNull(pReader.GetOrdinal("TIVUS")) Then pObject.colTivus = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "TIVUS")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StProvName")) Then pObject.colStProvName = UtilSQLServer.SafeReader.SafeReadString(pReader, "StProvName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecUniqueID")) Then pObject.colRecUniqueID = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecUniqueID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecYear")) Then pObject.colRecYear = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecYear")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecMonth")) Then pObject.colRecMonth = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecMonth")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecNumber")) Then pObject.colRecNumber = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecNumber")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecSubletter")) Then pObject.colRecSubletter = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecSubletter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecNo")) Then pObject.colRecNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecCategory")) Then pObject.colRecCategory = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecCategory")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecCategorySortOrder")) Then pObject.colRecCategorySortOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecCategorySortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecStatus")) Then pObject.colRecStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("StatusDate")) Then pObject.colStatusDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "StatusDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecCode")) Then pObject.colRecCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PrimaryRecType")) Then pObject.colPrimaryRecType = UtilSQLServer.SafeReader.SafeReadString(pReader, "PrimaryRecType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SecondaryRecType")) Then pObject.colSecondaryRecType = UtilSQLServer.SafeReader.SafeReadString(pReader, "SecondaryRecType")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecKeyWords")) Then pObject.colRecKeyWords = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecKeyWords")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyBefore")) Then pObject.colLossExpectancyBefore = UtilSQLServer.SafeReader.SafeReadString(pReader, "LossExpectancyBefore")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyAfter")) Then pObject.colLossExpectancyAfter = UtilSQLServer.SafeReader.SafeReadString(pReader, "LossExpectancyAfter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CostToComplete")) Then pObject.colCostToComplete = UtilSQLServer.SafeReader.SafeReadString(pReader, "CostToComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SavingsRatio")) Then pObject.colSavingsRatio = UtilSQLServer.SafeReader.SafeReadDouble(pReader, "SavingsRatio")
			If Not pReader.IsDBNull(pReader.GetOrdinal("PlantComment")) Then pObject.colPlantComment = UtilSQLServer.SafeReader.SafeReadString(pReader, "PlantComment")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExpectedCompletionDate")) Then pObject.colExpectedCompletionDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "ExpectedCompletionDate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IntendedAction")) Then pObject.colIntendedAction = UtilSQLServer.SafeReader.SafeReadString(pReader, "IntendedAction")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyBeforeActual")) Then pObject.colLossExpectancyBeforeActual = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LossExpectancyBeforeActual")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyAfterActual")) Then pObject.colLossExpectancyAfterActual = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LossExpectancyAfterActual")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CostToCompleteActual")) Then pObject.colCostToCompleteActual = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "CostToCompleteActual")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ActualCostToComplete")) Then pObject.colActualCostToComplete = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "ActualCostToComplete")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecPriority")) Then pObject.colRecPriority = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "RecPriority")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RatingCatWeight")) Then pObject.colRatingCatWeight = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "RatingCatWeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RatingCat")) Then pObject.colRatingCat = UtilSQLServer.SafeReader.SafeReadString(pReader, "RatingCat")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RatingPts")) Then pObject.colRatingPts = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "RatingPts")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RatingScoreChange")) Then pObject.colRatingScoreChange = UtilSQLServer.SafeReader.SafeReadDecimal(pReader, "RatingScoreChange")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RatingCatPts")) Then pObject.colRatingCatPts = UtilSQLServer.SafeReader.SafeReadString(pReader, "RatingCatPts")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecCategoryColor")) Then pObject.colRecCategoryColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecCategoryColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("ExpectedCompletionDateColor")) Then pObject.colExpectedCompletionDateColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "ExpectedCompletionDateColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("RecCategoryForeColor")) Then pObject.colRecCategoryForeColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "RecCategoryForeColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyBeforeMedian")) Then pObject.colLossExpectancyBeforeMedian = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LossExpectancyBeforeMedian")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyAfterMedian")) Then pObject.colLossExpectancyAfterMedian = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LossExpectancyAfterMedian")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CostToCompleteMedian")) Then pObject.colCostToCompleteMedian = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "CostToCompleteMedian")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAddressStamp")) Then pObject.colFldAddressStamp = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldAddressStamp")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LocationRatingFormViewLink")) Then pObject.colLocationRatingFormViewLink = UtilSQLServer.SafeReader.SafeReadString(pReader, "LocationRatingFormViewLink")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LocationRatingReportLink")) Then pObject.colLocationRatingReportLink = UtilSQLServer.SafeReader.SafeReadString(pReader, "LocationRatingReportLink")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WiIsSelected")) Then pObject.colWiIsSelected = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "WiIsSelected")
			If Not pReader.IsDBNull(pReader.GetOrdinal("WiRecStatus")) Then pObject.colWiRecStatus = UtilSQLServer.SafeReader.SafeReadString(pReader, "WiRecStatus")
			If Not pReader.IsDBNull(pReader.GetOrdinal("LossExpectancyBeforeSortValue")) Then pObject.colLossExpectancyBeforeSortValue = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "LossExpectancyBeforeSortValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("CostToCompleteSortValue")) Then pObject.colCostToCompleteSortValue = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "CostToCompleteSortValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileNo")) Then pObject.colFldFileNo = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileNo")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldClientLocID")) Then pObject.colFldClientLocID = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldClientLocID")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldDivision")) Then pObject.colFldDivision = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldDivision")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCustomAccess")) Then pObject.colFldCustomAccess = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCustomAccess")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFacility")) Then pObject.colFldFacility = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFacility")
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
            Dim zSQL As String = "SELECT * FROM [gv].[vwWhatIfFireRecGrid]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowVwWhatIfFireRecGrid
        Implements IrowVwWhatIfFireRecGrid

        Public Event Loaded(pUserState As Object) Implements IrowVwWhatIfFireRecGrid.Loaded
        Public Event Saved(pUserState As Object) Implements IrowVwWhatIfFireRecGrid.Saved
        Public Event Deleted(pUserState As Object) Implements IrowVwWhatIfFireRecGrid.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowVwWhatIfFireRecGrid.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowVwWhatIfFireRecGrid.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowVwWhatIfFireRecGrid.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colRecID() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colRecID
            Get
                Return m_colRecID
            End Get
            Set
                If Not Same(m_colRecID, Value) Then
                    m_colRecID = Value
                    m_IsDirty(FieldIndex.colRecID) = True
                End If
            End Set
        End Property
        Private m_colRecID As Nullable(Of Integer)

        Public Property colGSafeId() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colGSafeId
            Get
                Return m_colGSafeId
            End Get
            Set
                If Not Same(m_colGSafeId, Value) Then
                    m_colGSafeId = Value
                    m_IsDirty(FieldIndex.colGSafeId) = True
                End If
            End Set
        End Property
        Private m_colGSafeId As Nullable(Of Integer)

        Public Property colFilePrefix() As String Implements IrowVwWhatIfFireRecGrid.colFilePrefix
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

        Public Property colFileNo() As String Implements IrowVwWhatIfFireRecGrid.colFileNo
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

        Public Property colClient() As String Implements IrowVwWhatIfFireRecGrid.colClient
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

        Public Property colClientLocNo() As String Implements IrowVwWhatIfFireRecGrid.colClientLocNo
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

        Public Property colDivision() As String Implements IrowVwWhatIfFireRecGrid.colDivision
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

        Public Property colCustomAccess() As String Implements IrowVwWhatIfFireRecGrid.colCustomAccess
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

        Public Property colFacility() As String Implements IrowVwWhatIfFireRecGrid.colFacility
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

        Public Property colAddress() As String Implements IrowVwWhatIfFireRecGrid.colAddress
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

        Public Property colCity() As String Implements IrowVwWhatIfFireRecGrid.colCity
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

        Public Property colStProv() As String Implements IrowVwWhatIfFireRecGrid.colStProv
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

        Public Property colZip() As String Implements IrowVwWhatIfFireRecGrid.colZip
            Get
                Return m_colZip
            End Get
            Set
                If Not Same(m_colZip, Value) Then
                    m_colZip = Value
                    m_IsDirty(FieldIndex.colZip) = True
                End If
            End Set
        End Property
        Private m_colZip As String

        Public Property colCountry() As String Implements IrowVwWhatIfFireRecGrid.colCountry
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

        Public Property colLatitude() As Nullable(Of Decimal) Implements IrowVwWhatIfFireRecGrid.colLatitude
            Get
                Return m_colLatitude
            End Get
            Set
                If Not Same(m_colLatitude, Value) Then
                    m_colLatitude = Value
                    m_IsDirty(FieldIndex.colLatitude) = True
                End If
            End Set
        End Property
        Private m_colLatitude As Nullable(Of Decimal)

        Public Property colLongitude() As Nullable(Of Decimal) Implements IrowVwWhatIfFireRecGrid.colLongitude
            Get
                Return m_colLongitude
            End Get
            Set
                If Not Same(m_colLongitude, Value) Then
                    m_colLongitude = Value
                    m_IsDirty(FieldIndex.colLongitude) = True
                End If
            End Set
        End Property
        Private m_colLongitude As Nullable(Of Decimal)

        Public Property colTivus() As Nullable(Of Double) Implements IrowVwWhatIfFireRecGrid.colTivus
            Get
                Return m_colTivus
            End Get
            Set
                If Not Same(m_colTivus, Value) Then
                    m_colTivus = Value
                    m_IsDirty(FieldIndex.colTivus) = True
                End If
            End Set
        End Property
        Private m_colTivus As Nullable(Of Double)

        Public Property colStProvName() As String Implements IrowVwWhatIfFireRecGrid.colStProvName
            Get
                Return m_colStProvName
            End Get
            Set
                If Not Same(m_colStProvName, Value) Then
                    m_colStProvName = Value
                    m_IsDirty(FieldIndex.colStProvName) = True
                End If
            End Set
        End Property
        Private m_colStProvName As String

        Public Property colRecUniqueID() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colRecUniqueID
            Get
                Return m_colRecUniqueID
            End Get
            Set
                If Not Same(m_colRecUniqueID, Value) Then
                    m_colRecUniqueID = Value
                    m_IsDirty(FieldIndex.colRecUniqueID) = True
                End If
            End Set
        End Property
        Private m_colRecUniqueID As Nullable(Of Integer)

        Public Property colRecYear() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colRecYear
            Get
                Return m_colRecYear
            End Get
            Set
                If Not Same(m_colRecYear, Value) Then
                    m_colRecYear = Value
                    m_IsDirty(FieldIndex.colRecYear) = True
                End If
            End Set
        End Property
        Private m_colRecYear As Nullable(Of Integer)

        Public Property colRecMonth() As String Implements IrowVwWhatIfFireRecGrid.colRecMonth
            Get
                Return m_colRecMonth
            End Get
            Set
                If Not Same(m_colRecMonth, Value) Then
                    m_colRecMonth = Value
                    m_IsDirty(FieldIndex.colRecMonth) = True
                End If
            End Set
        End Property
        Private m_colRecMonth As String

        Public Property colRecNumber() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colRecNumber
            Get
                Return m_colRecNumber
            End Get
            Set
                If Not Same(m_colRecNumber, Value) Then
                    m_colRecNumber = Value
                    m_IsDirty(FieldIndex.colRecNumber) = True
                End If
            End Set
        End Property
        Private m_colRecNumber As Nullable(Of Integer)

        Public Property colRecSubletter() As String Implements IrowVwWhatIfFireRecGrid.colRecSubletter
            Get
                Return m_colRecSubletter
            End Get
            Set
                If Not Same(m_colRecSubletter, Value) Then
                    m_colRecSubletter = Value
                    m_IsDirty(FieldIndex.colRecSubletter) = True
                End If
            End Set
        End Property
        Private m_colRecSubletter As String

        Public Property colRecNo() As String Implements IrowVwWhatIfFireRecGrid.colRecNo
            Get
                Return m_colRecNo
            End Get
            Set
                If Not Same(m_colRecNo, Value) Then
                    m_colRecNo = Value
                    m_IsDirty(FieldIndex.colRecNo) = True
                End If
            End Set
        End Property
        Private m_colRecNo As String

        Public Property colRecCategory() As String Implements IrowVwWhatIfFireRecGrid.colRecCategory
            Get
                Return m_colRecCategory
            End Get
            Set
                If Not Same(m_colRecCategory, Value) Then
                    m_colRecCategory = Value
                    m_IsDirty(FieldIndex.colRecCategory) = True
                End If
            End Set
        End Property
        Private m_colRecCategory As String

        Public Property colRecCategorySortOrder() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colRecCategorySortOrder
            Get
                Return m_colRecCategorySortOrder
            End Get
            Set
                If Not Same(m_colRecCategorySortOrder, Value) Then
                    m_colRecCategorySortOrder = Value
                    m_IsDirty(FieldIndex.colRecCategorySortOrder) = True
                End If
            End Set
        End Property
        Private m_colRecCategorySortOrder As Nullable(Of Integer)

        Public Property colRecStatus() As String Implements IrowVwWhatIfFireRecGrid.colRecStatus
            Get
                Return m_colRecStatus
            End Get
            Set
                If Not Same(m_colRecStatus, Value) Then
                    m_colRecStatus = Value
                    m_IsDirty(FieldIndex.colRecStatus) = True
                End If
            End Set
        End Property
        Private m_colRecStatus As String

        Public Property colStatusDate() As Nullable(Of DateTime) Implements IrowVwWhatIfFireRecGrid.colStatusDate
            Get
                Return m_colStatusDate
            End Get
            Set
                If Not Same(m_colStatusDate, Value) Then
                    m_colStatusDate = Value
                    m_IsDirty(FieldIndex.colStatusDate) = True
                End If
            End Set
        End Property
        Private m_colStatusDate As Nullable(Of DateTime)

        Public Property colRecCode() As String Implements IrowVwWhatIfFireRecGrid.colRecCode
            Get
                Return m_colRecCode
            End Get
            Set
                If Not Same(m_colRecCode, Value) Then
                    m_colRecCode = Value
                    m_IsDirty(FieldIndex.colRecCode) = True
                End If
            End Set
        End Property
        Private m_colRecCode As String

        Public Property colPrimaryRecType() As String Implements IrowVwWhatIfFireRecGrid.colPrimaryRecType
            Get
                Return m_colPrimaryRecType
            End Get
            Set
                If Not Same(m_colPrimaryRecType, Value) Then
                    m_colPrimaryRecType = Value
                    m_IsDirty(FieldIndex.colPrimaryRecType) = True
                End If
            End Set
        End Property
        Private m_colPrimaryRecType As String

        Public Property colSecondaryRecType() As String Implements IrowVwWhatIfFireRecGrid.colSecondaryRecType
            Get
                Return m_colSecondaryRecType
            End Get
            Set
                If Not Same(m_colSecondaryRecType, Value) Then
                    m_colSecondaryRecType = Value
                    m_IsDirty(FieldIndex.colSecondaryRecType) = True
                End If
            End Set
        End Property
        Private m_colSecondaryRecType As String

        Public Property colRecKeyWords() As String Implements IrowVwWhatIfFireRecGrid.colRecKeyWords
            Get
                Return m_colRecKeyWords
            End Get
            Set
                If Not Same(m_colRecKeyWords, Value) Then
                    m_colRecKeyWords = Value
                    m_IsDirty(FieldIndex.colRecKeyWords) = True
                End If
            End Set
        End Property
        Private m_colRecKeyWords As String

        Public Property colLossExpectancyBefore() As String Implements IrowVwWhatIfFireRecGrid.colLossExpectancyBefore
            Get
                Return m_colLossExpectancyBefore
            End Get
            Set
                If Not Same(m_colLossExpectancyBefore, Value) Then
                    m_colLossExpectancyBefore = Value
                    m_IsDirty(FieldIndex.colLossExpectancyBefore) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyBefore As String

        Public Property colLossExpectancyAfter() As String Implements IrowVwWhatIfFireRecGrid.colLossExpectancyAfter
            Get
                Return m_colLossExpectancyAfter
            End Get
            Set
                If Not Same(m_colLossExpectancyAfter, Value) Then
                    m_colLossExpectancyAfter = Value
                    m_IsDirty(FieldIndex.colLossExpectancyAfter) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyAfter As String

        Public Property colCostToComplete() As String Implements IrowVwWhatIfFireRecGrid.colCostToComplete
            Get
                Return m_colCostToComplete
            End Get
            Set
                If Not Same(m_colCostToComplete, Value) Then
                    m_colCostToComplete = Value
                    m_IsDirty(FieldIndex.colCostToComplete) = True
                End If
            End Set
        End Property
        Private m_colCostToComplete As String

        Public Property colSavingsRatio() As Nullable(Of Double) Implements IrowVwWhatIfFireRecGrid.colSavingsRatio
            Get
                Return m_colSavingsRatio
            End Get
            Set
                If Not Same(m_colSavingsRatio, Value) Then
                    m_colSavingsRatio = Value
                    m_IsDirty(FieldIndex.colSavingsRatio) = True
                End If
            End Set
        End Property
        Private m_colSavingsRatio As Nullable(Of Double)

        Public Property colPlantComment() As String Implements IrowVwWhatIfFireRecGrid.colPlantComment
            Get
                Return m_colPlantComment
            End Get
            Set
                If Not Same(m_colPlantComment, Value) Then
                    m_colPlantComment = Value
                    m_IsDirty(FieldIndex.colPlantComment) = True
                End If
            End Set
        End Property
        Private m_colPlantComment As String

        Public Property colExpectedCompletionDate() As Nullable(Of DateTime) Implements IrowVwWhatIfFireRecGrid.colExpectedCompletionDate
            Get
                Return m_colExpectedCompletionDate
            End Get
            Set
                If Not Same(m_colExpectedCompletionDate, Value) Then
                    m_colExpectedCompletionDate = Value
                    m_IsDirty(FieldIndex.colExpectedCompletionDate) = True
                End If
            End Set
        End Property
        Private m_colExpectedCompletionDate As Nullable(Of DateTime)

        Public Property colIntendedAction() As String Implements IrowVwWhatIfFireRecGrid.colIntendedAction
            Get
                Return m_colIntendedAction
            End Get
            Set
                If Not Same(m_colIntendedAction, Value) Then
                    m_colIntendedAction = Value
                    m_IsDirty(FieldIndex.colIntendedAction) = True
                End If
            End Set
        End Property
        Private m_colIntendedAction As String

        Public Property colLossExpectancyBeforeActual() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colLossExpectancyBeforeActual
            Get
                Return m_colLossExpectancyBeforeActual
            End Get
            Set
                If Not Same(m_colLossExpectancyBeforeActual, Value) Then
                    m_colLossExpectancyBeforeActual = Value
                    m_IsDirty(FieldIndex.colLossExpectancyBeforeActual) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyBeforeActual As Nullable(Of Integer)

        Public Property colLossExpectancyAfterActual() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colLossExpectancyAfterActual
            Get
                Return m_colLossExpectancyAfterActual
            End Get
            Set
                If Not Same(m_colLossExpectancyAfterActual, Value) Then
                    m_colLossExpectancyAfterActual = Value
                    m_IsDirty(FieldIndex.colLossExpectancyAfterActual) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyAfterActual As Nullable(Of Integer)

        Public Property colCostToCompleteActual() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colCostToCompleteActual
            Get
                Return m_colCostToCompleteActual
            End Get
            Set
                If Not Same(m_colCostToCompleteActual, Value) Then
                    m_colCostToCompleteActual = Value
                    m_IsDirty(FieldIndex.colCostToCompleteActual) = True
                End If
            End Set
        End Property
        Private m_colCostToCompleteActual As Nullable(Of Integer)

        Public Property colActualCostToComplete() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colActualCostToComplete
            Get
                Return m_colActualCostToComplete
            End Get
            Set
                If Not Same(m_colActualCostToComplete, Value) Then
                    m_colActualCostToComplete = Value
                    m_IsDirty(FieldIndex.colActualCostToComplete) = True
                End If
            End Set
        End Property
        Private m_colActualCostToComplete As Nullable(Of Integer)

        Public Property colRecPriority() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colRecPriority
            Get
                Return m_colRecPriority
            End Get
            Set
                If Not Same(m_colRecPriority, Value) Then
                    m_colRecPriority = Value
                    m_IsDirty(FieldIndex.colRecPriority) = True
                End If
            End Set
        End Property
        Private m_colRecPriority As Nullable(Of Integer)

        Public Property colRatingCatWeight() As Nullable(Of Decimal) Implements IrowVwWhatIfFireRecGrid.colRatingCatWeight
            Get
                Return m_colRatingCatWeight
            End Get
            Set
                If Not Same(m_colRatingCatWeight, Value) Then
                    m_colRatingCatWeight = Value
                    m_IsDirty(FieldIndex.colRatingCatWeight) = True
                End If
            End Set
        End Property
        Private m_colRatingCatWeight As Nullable(Of Decimal)

        Public Property colRatingCat() As String Implements IrowVwWhatIfFireRecGrid.colRatingCat
            Get
                Return m_colRatingCat
            End Get
            Set
                If Not Same(m_colRatingCat, Value) Then
                    m_colRatingCat = Value
                    m_IsDirty(FieldIndex.colRatingCat) = True
                End If
            End Set
        End Property
        Private m_colRatingCat As String

        Public Property colRatingPts() As Nullable(Of Decimal) Implements IrowVwWhatIfFireRecGrid.colRatingPts
            Get
                Return m_colRatingPts
            End Get
            Set
                If Not Same(m_colRatingPts, Value) Then
                    m_colRatingPts = Value
                    m_IsDirty(FieldIndex.colRatingPts) = True
                End If
            End Set
        End Property
        Private m_colRatingPts As Nullable(Of Decimal)

        Public Property colRatingScoreChange() As Nullable(Of Decimal) Implements IrowVwWhatIfFireRecGrid.colRatingScoreChange
            Get
                Return m_colRatingScoreChange
            End Get
            Set
                If Not Same(m_colRatingScoreChange, Value) Then
                    m_colRatingScoreChange = Value
                    m_IsDirty(FieldIndex.colRatingScoreChange) = True
                End If
            End Set
        End Property
        Private m_colRatingScoreChange As Nullable(Of Decimal)

        Public Property colRatingCatPts() As String Implements IrowVwWhatIfFireRecGrid.colRatingCatPts
            Get
                Return m_colRatingCatPts
            End Get
            Set
                If Not Same(m_colRatingCatPts, Value) Then
                    m_colRatingCatPts = Value
                    m_IsDirty(FieldIndex.colRatingCatPts) = True
                End If
            End Set
        End Property
        Private m_colRatingCatPts As String

        Public Property colRecCategoryColor() As String Implements IrowVwWhatIfFireRecGrid.colRecCategoryColor
            Get
                Return m_colRecCategoryColor
            End Get
            Set
                If Not Same(m_colRecCategoryColor, Value) Then
                    m_colRecCategoryColor = Value
                    m_IsDirty(FieldIndex.colRecCategoryColor) = True
                End If
            End Set
        End Property
        Private m_colRecCategoryColor As String

        Public Property colExpectedCompletionDateColor() As String Implements IrowVwWhatIfFireRecGrid.colExpectedCompletionDateColor
            Get
                Return m_colExpectedCompletionDateColor
            End Get
            Set
                If Not Same(m_colExpectedCompletionDateColor, Value) Then
                    m_colExpectedCompletionDateColor = Value
                    m_IsDirty(FieldIndex.colExpectedCompletionDateColor) = True
                End If
            End Set
        End Property
        Private m_colExpectedCompletionDateColor As String

        Public Property colRecCategoryForeColor() As String Implements IrowVwWhatIfFireRecGrid.colRecCategoryForeColor
            Get
                Return m_colRecCategoryForeColor
            End Get
            Set
                If Not Same(m_colRecCategoryForeColor, Value) Then
                    m_colRecCategoryForeColor = Value
                    m_IsDirty(FieldIndex.colRecCategoryForeColor) = True
                End If
            End Set
        End Property
        Private m_colRecCategoryForeColor As String

        Public Property colLossExpectancyBeforeMedian() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colLossExpectancyBeforeMedian
            Get
                Return m_colLossExpectancyBeforeMedian
            End Get
            Set
                If Not Same(m_colLossExpectancyBeforeMedian, Value) Then
                    m_colLossExpectancyBeforeMedian = Value
                    m_IsDirty(FieldIndex.colLossExpectancyBeforeMedian) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyBeforeMedian As Nullable(Of Integer)

        Public Property colLossExpectancyAfterMedian() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colLossExpectancyAfterMedian
            Get
                Return m_colLossExpectancyAfterMedian
            End Get
            Set
                If Not Same(m_colLossExpectancyAfterMedian, Value) Then
                    m_colLossExpectancyAfterMedian = Value
                    m_IsDirty(FieldIndex.colLossExpectancyAfterMedian) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyAfterMedian As Nullable(Of Integer)

        Public Property colCostToCompleteMedian() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colCostToCompleteMedian
            Get
                Return m_colCostToCompleteMedian
            End Get
            Set
                If Not Same(m_colCostToCompleteMedian, Value) Then
                    m_colCostToCompleteMedian = Value
                    m_IsDirty(FieldIndex.colCostToCompleteMedian) = True
                End If
            End Set
        End Property
        Private m_colCostToCompleteMedian As Nullable(Of Integer)

        Public Property colFldAddressStamp() As String Implements IrowVwWhatIfFireRecGrid.colFldAddressStamp
            Get
                Return m_colFldAddressStamp
            End Get
            Set
                If Not Same(m_colFldAddressStamp, Value) Then
                    m_colFldAddressStamp = Value
                    m_IsDirty(FieldIndex.colFldAddressStamp) = True
                End If
            End Set
        End Property
        Private m_colFldAddressStamp As String

        Public Property colLocationRatingFormViewLink() As String Implements IrowVwWhatIfFireRecGrid.colLocationRatingFormViewLink
            Get
                Return m_colLocationRatingFormViewLink
            End Get
            Set
                If Not Same(m_colLocationRatingFormViewLink, Value) Then
                    m_colLocationRatingFormViewLink = Value
                    m_IsDirty(FieldIndex.colLocationRatingFormViewLink) = True
                End If
            End Set
        End Property
        Private m_colLocationRatingFormViewLink As String

        Public Property colLocationRatingReportLink() As String Implements IrowVwWhatIfFireRecGrid.colLocationRatingReportLink
            Get
                Return m_colLocationRatingReportLink
            End Get
            Set
                If Not Same(m_colLocationRatingReportLink, Value) Then
                    m_colLocationRatingReportLink = Value
                    m_IsDirty(FieldIndex.colLocationRatingReportLink) = True
                End If
            End Set
        End Property
        Private m_colLocationRatingReportLink As String

        Public Property colWiIsSelected() As Nullable(Of Boolean) Implements IrowVwWhatIfFireRecGrid.colWiIsSelected
            Get
                Return m_colWiIsSelected
            End Get
            Set
                If Not Same(m_colWiIsSelected, Value) Then
                    m_colWiIsSelected = Value
                    m_IsDirty(FieldIndex.colWiIsSelected) = True
                End If
            End Set
        End Property
        Private m_colWiIsSelected As Nullable(Of Boolean)

        Public Property colWiRecStatus() As String Implements IrowVwWhatIfFireRecGrid.colWiRecStatus
            Get
                Return m_colWiRecStatus
            End Get
            Set
                If Not Same(m_colWiRecStatus, Value) Then
                    m_colWiRecStatus = Value
                    m_IsDirty(FieldIndex.colWiRecStatus) = True
                End If
            End Set
        End Property
        Private m_colWiRecStatus As String

        Public Property colLossExpectancyBeforeSortValue() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colLossExpectancyBeforeSortValue
            Get
                Return m_colLossExpectancyBeforeSortValue
            End Get
            Set
                If Not Same(m_colLossExpectancyBeforeSortValue, Value) Then
                    m_colLossExpectancyBeforeSortValue = Value
                    m_IsDirty(FieldIndex.colLossExpectancyBeforeSortValue) = True
                End If
            End Set
        End Property
        Private m_colLossExpectancyBeforeSortValue As Nullable(Of Integer)

        Public Property colCostToCompleteSortValue() As Nullable(Of Integer) Implements IrowVwWhatIfFireRecGrid.colCostToCompleteSortValue
            Get
                Return m_colCostToCompleteSortValue
            End Get
            Set
                If Not Same(m_colCostToCompleteSortValue, Value) Then
                    m_colCostToCompleteSortValue = Value
                    m_IsDirty(FieldIndex.colCostToCompleteSortValue) = True
                End If
            End Set
        End Property
        Private m_colCostToCompleteSortValue As Nullable(Of Integer)

        Public Property colFldFileNo() As String Implements IrowVwWhatIfFireRecGrid.colFldFileNo
            Get
                Return m_colFldFileNo
            End Get
            Set
                If Not Same(m_colFldFileNo, Value) Then
                    m_colFldFileNo = Value
                    m_IsDirty(FieldIndex.colFldFileNo) = True
                End If
            End Set
        End Property
        Private m_colFldFileNo As String

        Public Property colFldClientLocID() As String Implements IrowVwWhatIfFireRecGrid.colFldClientLocID
            Get
                Return m_colFldClientLocID
            End Get
            Set
                If Not Same(m_colFldClientLocID, Value) Then
                    m_colFldClientLocID = Value
                    m_IsDirty(FieldIndex.colFldClientLocID) = True
                End If
            End Set
        End Property
        Private m_colFldClientLocID As String

        Public Property colFldDivision() As String Implements IrowVwWhatIfFireRecGrid.colFldDivision
            Get
                Return m_colFldDivision
            End Get
            Set
                If Not Same(m_colFldDivision, Value) Then
                    m_colFldDivision = Value
                    m_IsDirty(FieldIndex.colFldDivision) = True
                End If
            End Set
        End Property
        Private m_colFldDivision As String

        Public Property colFldCustomAccess() As String Implements IrowVwWhatIfFireRecGrid.colFldCustomAccess
            Get
                Return m_colFldCustomAccess
            End Get
            Set
                If Not Same(m_colFldCustomAccess, Value) Then
                    m_colFldCustomAccess = Value
                    m_IsDirty(FieldIndex.colFldCustomAccess) = True
                End If
            End Set
        End Property
        Private m_colFldCustomAccess As String

        Public Property colFldFacility() As String Implements IrowVwWhatIfFireRecGrid.colFldFacility
            Get
                Return m_colFldFacility
            End Get
            Set
                If Not Same(m_colFldFacility, Value) Then
                    m_colFldFacility = Value
                    m_IsDirty(FieldIndex.colFldFacility) = True
                End If
            End Set
        End Property
        Private m_colFldFacility As String


        Public Function IsDirty(pIndex As rowVwWhatIfFireRecGrid.FieldIndex) As Boolean Implements IrowVwWhatIfFireRecGrid.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowVwWhatIfFireRecGrid.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowVwWhatIfFireRecGrid.SetIsDirty
            m_IsDirty(FieldIndex.colRecID) = pDirty
            m_IsDirty(FieldIndex.colGSafeId) = pDirty
            m_IsDirty(FieldIndex.colFilePrefix) = pDirty
            m_IsDirty(FieldIndex.colFileNo) = pDirty
            m_IsDirty(FieldIndex.colClient) = pDirty
            m_IsDirty(FieldIndex.colClientLocNo) = pDirty
            m_IsDirty(FieldIndex.colDivision) = pDirty
            m_IsDirty(FieldIndex.colCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colFacility) = pDirty
            m_IsDirty(FieldIndex.colAddress) = pDirty
            m_IsDirty(FieldIndex.colCity) = pDirty
            m_IsDirty(FieldIndex.colStProv) = pDirty
            m_IsDirty(FieldIndex.colZip) = pDirty
            m_IsDirty(FieldIndex.colCountry) = pDirty
            m_IsDirty(FieldIndex.colLatitude) = pDirty
            m_IsDirty(FieldIndex.colLongitude) = pDirty
            m_IsDirty(FieldIndex.colTivus) = pDirty
            m_IsDirty(FieldIndex.colStProvName) = pDirty
            m_IsDirty(FieldIndex.colRecUniqueID) = pDirty
            m_IsDirty(FieldIndex.colRecYear) = pDirty
            m_IsDirty(FieldIndex.colRecMonth) = pDirty
            m_IsDirty(FieldIndex.colRecNumber) = pDirty
            m_IsDirty(FieldIndex.colRecSubletter) = pDirty
            m_IsDirty(FieldIndex.colRecNo) = pDirty
            m_IsDirty(FieldIndex.colRecCategory) = pDirty
            m_IsDirty(FieldIndex.colRecCategorySortOrder) = pDirty
            m_IsDirty(FieldIndex.colRecStatus) = pDirty
            m_IsDirty(FieldIndex.colStatusDate) = pDirty
            m_IsDirty(FieldIndex.colRecCode) = pDirty
            m_IsDirty(FieldIndex.colPrimaryRecType) = pDirty
            m_IsDirty(FieldIndex.colSecondaryRecType) = pDirty
            m_IsDirty(FieldIndex.colRecKeyWords) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyBefore) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyAfter) = pDirty
            m_IsDirty(FieldIndex.colCostToComplete) = pDirty
            m_IsDirty(FieldIndex.colSavingsRatio) = pDirty
            m_IsDirty(FieldIndex.colPlantComment) = pDirty
            m_IsDirty(FieldIndex.colExpectedCompletionDate) = pDirty
            m_IsDirty(FieldIndex.colIntendedAction) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyBeforeActual) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyAfterActual) = pDirty
            m_IsDirty(FieldIndex.colCostToCompleteActual) = pDirty
            m_IsDirty(FieldIndex.colActualCostToComplete) = pDirty
            m_IsDirty(FieldIndex.colRecPriority) = pDirty
            m_IsDirty(FieldIndex.colRatingCatWeight) = pDirty
            m_IsDirty(FieldIndex.colRatingCat) = pDirty
            m_IsDirty(FieldIndex.colRatingPts) = pDirty
            m_IsDirty(FieldIndex.colRatingScoreChange) = pDirty
            m_IsDirty(FieldIndex.colRatingCatPts) = pDirty
            m_IsDirty(FieldIndex.colRecCategoryColor) = pDirty
            m_IsDirty(FieldIndex.colExpectedCompletionDateColor) = pDirty
            m_IsDirty(FieldIndex.colRecCategoryForeColor) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyBeforeMedian) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyAfterMedian) = pDirty
            m_IsDirty(FieldIndex.colCostToCompleteMedian) = pDirty
            m_IsDirty(FieldIndex.colFldAddressStamp) = pDirty
            m_IsDirty(FieldIndex.colLocationRatingFormViewLink) = pDirty
            m_IsDirty(FieldIndex.colLocationRatingReportLink) = pDirty
            m_IsDirty(FieldIndex.colWiIsSelected) = pDirty
            m_IsDirty(FieldIndex.colWiRecStatus) = pDirty
            m_IsDirty(FieldIndex.colLossExpectancyBeforeSortValue) = pDirty
            m_IsDirty(FieldIndex.colCostToCompleteSortValue) = pDirty
            m_IsDirty(FieldIndex.colFldFileNo) = pDirty
            m_IsDirty(FieldIndex.colFldClientLocID) = pDirty
            m_IsDirty(FieldIndex.colFldDivision) = pDirty
            m_IsDirty(FieldIndex.colFldCustomAccess) = pDirty
            m_IsDirty(FieldIndex.colFldFacility) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (VwWhatIfFireRecGrid) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New VwWhatIfFireRecGrid
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colRecID  = 1
            colGSafeId 
            colFilePrefix 
            colFileNo 
            colClient 
            colClientLocNo 
            colDivision 
            colCustomAccess 
            colFacility 
            colAddress 
            colCity 
            colStProv 
            colZip 
            colCountry 
            colLatitude 
            colLongitude 
            colTivus 
            colStProvName 
            colRecUniqueID 
            colRecYear 
            colRecMonth 
            colRecNumber 
            colRecSubletter 
            colRecNo 
            colRecCategory 
            colRecCategorySortOrder 
            colRecStatus 
            colStatusDate 
            colRecCode 
            colPrimaryRecType 
            colSecondaryRecType 
            colRecKeyWords 
            colLossExpectancyBefore 
            colLossExpectancyAfter 
            colCostToComplete 
            colSavingsRatio 
            colPlantComment 
            colExpectedCompletionDate 
            colIntendedAction 
            colLossExpectancyBeforeActual 
            colLossExpectancyAfterActual 
            colCostToCompleteActual 
            colActualCostToComplete 
            colRecPriority 
            colRatingCatWeight 
            colRatingCat 
            colRatingPts 
            colRatingScoreChange 
            colRatingCatPts 
            colRecCategoryColor 
            colExpectedCompletionDateColor 
            colRecCategoryForeColor 
            colLossExpectancyBeforeMedian 
            colLossExpectancyAfterMedian 
            colCostToCompleteMedian 
            colFldAddressStamp 
            colLocationRatingFormViewLink 
            colLocationRatingReportLink 
            colWiIsSelected 
            colWiRecStatus 
            colLossExpectancyBeforeSortValue 
            colCostToCompleteSortValue 
            colFldFileNo 
            colFldClientLocID 
            colFldDivision 
            colFldCustomAccess 
            colFldFacility 
        End Enum

        Private m_IsDirty(67) As Boolean

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

    Public Interface IrowVwWhatIfFireRecGrid
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colRecID() As Nullable(Of Integer)
        Property colGSafeId() As Nullable(Of Integer)
        Property colFilePrefix() As String
        Property colFileNo() As String
        Property colClient() As String
        Property colClientLocNo() As String
        Property colDivision() As String
        Property colCustomAccess() As String
        Property colFacility() As String
        Property colAddress() As String
        Property colCity() As String
        Property colStProv() As String
        Property colZip() As String
        Property colCountry() As String
        Property colLatitude() As Nullable(Of Decimal)
        Property colLongitude() As Nullable(Of Decimal)
        Property colTivus() As Nullable(Of Double)
        Property colStProvName() As String
        Property colRecUniqueID() As Nullable(Of Integer)
        Property colRecYear() As Nullable(Of Integer)
        Property colRecMonth() As String
        Property colRecNumber() As Nullable(Of Integer)
        Property colRecSubletter() As String
        Property colRecNo() As String
        Property colRecCategory() As String
        Property colRecCategorySortOrder() As Nullable(Of Integer)
        Property colRecStatus() As String
        Property colStatusDate() As Nullable(Of DateTime)
        Property colRecCode() As String
        Property colPrimaryRecType() As String
        Property colSecondaryRecType() As String
        Property colRecKeyWords() As String
        Property colLossExpectancyBefore() As String
        Property colLossExpectancyAfter() As String
        Property colCostToComplete() As String
        Property colSavingsRatio() As Nullable(Of Double)
        Property colPlantComment() As String
        Property colExpectedCompletionDate() As Nullable(Of DateTime)
        Property colIntendedAction() As String
        Property colLossExpectancyBeforeActual() As Nullable(Of Integer)
        Property colLossExpectancyAfterActual() As Nullable(Of Integer)
        Property colCostToCompleteActual() As Nullable(Of Integer)
        Property colActualCostToComplete() As Nullable(Of Integer)
        Property colRecPriority() As Nullable(Of Integer)
        Property colRatingCatWeight() As Nullable(Of Decimal)
        Property colRatingCat() As String
        Property colRatingPts() As Nullable(Of Decimal)
        Property colRatingScoreChange() As Nullable(Of Decimal)
        Property colRatingCatPts() As String
        Property colRecCategoryColor() As String
        Property colExpectedCompletionDateColor() As String
        Property colRecCategoryForeColor() As String
        Property colLossExpectancyBeforeMedian() As Nullable(Of Integer)
        Property colLossExpectancyAfterMedian() As Nullable(Of Integer)
        Property colCostToCompleteMedian() As Nullable(Of Integer)
        Property colFldAddressStamp() As String
        Property colLocationRatingFormViewLink() As String
        Property colLocationRatingReportLink() As String
        Property colWiIsSelected() As Nullable(Of Boolean)
        Property colWiRecStatus() As String
        Property colLossExpectancyBeforeSortValue() As Nullable(Of Integer)
        Property colCostToCompleteSortValue() As Nullable(Of Integer)
        Property colFldFileNo() As String
        Property colFldClientLocID() As String
        Property colFldDivision() As String
        Property colFldCustomAccess() As String
        Property colFldFacility() As String
        Function IsDirty(pIndex As rowVwWhatIfFireRecGrid.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

