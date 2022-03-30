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
    Partial Public Class TblMetaMapPin

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaMapPin)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaMapPin, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaMapPin, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaMapPin, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaMapPin] " & _
                        "WHERE [fldId] = @colFldId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))

                zCmd.Transaction=pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldId As Integer)
            Delete(pcolFldId, Nothing, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldId, Nothing, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
        Delete(pcolFldId, pTransaction, Nothing)
        End Sub	

        Public Shared Sub Delete(pcolFldId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
        Dim zObj As rowTblMetaMapPin = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaMapPin)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaMapPin, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaMapPin, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaMapPin] WHERE [fldId] = @colFldId"

                Dim zCmdDoesExist As New SQLCommand

                zCmdDoesExist.CommandText = zSQL

                zCmdDoesExist.Parameters.Add(new SQLParameter("@colFldId", pRowData.colFldId))

                'if zExistInDB > 0  then  PK exists in the DB
                zCmdDoesExist.Transaction = pTransaction
                zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
            End If

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB > 0 Then
                zMode = "UPDATE"
            End If
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) And zExistInDB = 0 Then
                zMode = "INSERTwithKey"
            End If
            If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then
                zMode = "INSERTnoKey"
            End If

            Select Case zMode
                Case "UPDATE"
                    If pRowData.IsDirty Then
                        Dim zUpdate As String = ""
                        Dim zSet As String = ""
                        Dim zWhere As String = ""
                        zUpdate = "UPDATE [dbo].[tblMetaMapPin] SET " 
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldIcon) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIcon] = @colFldIcon "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldHeight) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldHeight] = @colFldHeight "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldWidth) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldWidth] = @colFldWidth "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldAnchorX) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldAnchorX] = @colFldAnchorX "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldAnchorY) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldAnchorY] = @colFldAnchorY "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldTextOffsetX) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTextOffsetX] = @colFldTextOffsetX "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldTextOffsetY) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldTextOffsetY] = @colFldTextOffsetY "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldNote) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNote] = @colFldNote "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldBaseString) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldBaseString] = @colFldBaseString "
                        End If
                        If pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldMetaColorId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaColorId] = @colFldMetaColorId "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaMapPin] ([fldIcon], [fldHeight], [fldWidth], [fldAnchorX], [fldAnchorY], [fldTextOffsetX], [fldTextOffsetY], [fldNote], [fldBaseString], [fldMetaColorId])" & _
                            " VALUES (@colFldIcon, @colFldHeight, @colFldWidth, @colFldAnchorX, @colFldAnchorY, @colFldTextOffsetX, @colFldTextOffsetY, @colFldNote, @colFldBaseString, @colFldMetaColorId); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaMapPin] ([fldIcon], [fldHeight], [fldWidth], [fldAnchorX], [fldAnchorY], [fldTextOffsetX], [fldTextOffsetY], [fldNote], [fldBaseString], [fldMetaColorId])" & _
                            " VALUES (@colFldIcon, @colFldHeight, @colFldWidth, @colFldAnchorX, @colFldAnchorY, @colFldTextOffsetX, @colFldTextOffsetY, @colFldNote, @colFldBaseString, @colFldMetaColorId); SELECT SCOPE_IDENTITY()"
                Case Else
            End Select

            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

			'IF UPDATE, SET PK PARAMETER
            If zMode = "UPDATE" Then
                zCmd.Parameters.Add(New SQLParameter("@colFldId", pRowData.colFldId))
            End If

			'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
			If zMode = "INSERTwithKey" Then
            End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldIcon) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIcon", IIf(pRowData.colFldIcon Is Nothing, DBNull.Value, pRowData.colFldIcon)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldHeight) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldHeight", IIf(pRowData.colFldHeight Is Nothing, DBNull.Value, pRowData.colFldHeight)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldWidth) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldWidth", IIf(pRowData.colFldWidth Is Nothing, DBNull.Value, pRowData.colFldWidth)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldAnchorX) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldAnchorX", IIf(pRowData.colFldAnchorX Is Nothing, DBNull.Value, pRowData.colFldAnchorX)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldAnchorY) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldAnchorY", IIf(pRowData.colFldAnchorY Is Nothing, DBNull.Value, pRowData.colFldAnchorY)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldTextOffsetX) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTextOffsetX", IIf(pRowData.colFldTextOffsetX Is Nothing, DBNull.Value, pRowData.colFldTextOffsetX)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldTextOffsetY) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldTextOffsetY", IIf(pRowData.colFldTextOffsetY Is Nothing, DBNull.Value, pRowData.colFldTextOffsetY)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldNote) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNote", IIf(pRowData.colFldNote Is Nothing, DBNull.Value, pRowData.colFldNote)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldBaseString) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldBaseString", IIf(pRowData.colFldBaseString Is Nothing, DBNull.Value, pRowData.colFldBaseString)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaMapPin.FieldIndex.colFldMetaColorId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaColorId", IIf(pRowData.colFldMetaColorId Is Nothing, DBNull.Value, pRowData.colFldMetaColorId)))
                End If

            zCmd.Transaction=pTransaction
            If zMode = "INSERTnoKey" Then
                Dim zLastId As Long = 0
                zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                pRowData.colFldId = zLastId
            Else
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)
            End If

            pRowData.SetIsDirty(False)
            pRowData.RaiseSavedEvent(pSavedEventUserState)

		End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaMapPin
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaMapPin
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaMapPin
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaMapPin
            Dim zReturn As New rowTblMetaMapPin
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaMapPin) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_IX_Icon(pcolFldIcon As String) As List(Of rowTblMetaMapPin)
            Return LoadByIDX_IX_Icon(pcolFldIcon, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Icon(pcolFldIcon As String, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
            Return LoadByIDX_IX_Icon(pcolFldIcon, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_Icon(pcolFldIcon As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaMapPin)
            Return LoadByIDX_IX_Icon(pcolFldIcon, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Icon(pcolFldIcon As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
            Dim zReturn As New List(Of rowTblMetaMapPin)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin] WHERE [fldIcon] = @colFldIcon"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldIcon", pcolFldIcon))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId As Integer) As List(Of rowTblMetaMapPin)
            Return LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
            Return LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaMapPin)
            Return LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
            Dim zReturn As New List(Of rowTblMetaMapPin)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaMapPin)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaMapPin)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaMapPin)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)
            Dim zReturn As New List(Of rowTblMetaMapPin)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaMapPin)

			Try
	            Dim zReturn As New List(Of rowTblMetaMapPin)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaMapPin

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaMapPin		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaMapPin)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIcon")) Then pObject.colFldIcon = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldIcon")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldHeight")) Then pObject.colFldHeight = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldHeight")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldWidth")) Then pObject.colFldWidth = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldWidth")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAnchorX")) Then pObject.colFldAnchorX = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldAnchorX")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldAnchorY")) Then pObject.colFldAnchorY = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldAnchorY")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTextOffsetX")) Then pObject.colFldTextOffsetX = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldTextOffsetX")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldTextOffsetY")) Then pObject.colFldTextOffsetY = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldTextOffsetY")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNote")) Then pObject.colFldNote = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNote")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldBaseString")) Then pObject.colFldBaseString = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldBaseString")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaColorId")) Then pObject.colFldMetaColorId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaColorId")
			pObject.SetIsDirty(False)
			Return pObject
		End	 Function

    #Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblMetaMapPin Then Throw New ArgumentException("Generic type is not type of rowTblMetaMapPin.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_Icon(Of T)(pcolFldIcon As String) As List(Of T)
            Return LoadByIDX_IX_Icon(Of T)(pcolFldIcon, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_Icon(Of T)(pcolFldIcon As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_Icon(Of T)(pcolFldIcon, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_Icon(Of T)(pcolFldIcon As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_Icon(Of T)(pcolFldIcon, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_Icon(Of T)(pcolFldIcon As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin] WHERE [fldIcon] = @colFldIcon"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldIcon", pcolFldIcon))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaM__36326BE315D27EC1(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaMapPin]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaMapPin
        Implements IrowTblMetaMapPin

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaMapPin.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaMapPin.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaMapPin.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaMapPin.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaMapPin.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaMapPin.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldId
            Get
                Return m_colFldId
            End Get
            Set
                If Not Same(m_colFldId, Value) Then
                    m_colFldId = Value
                    m_IsDirty(FieldIndex.colFldId) = True
                End If
            End Set
        End Property
        Private m_colFldId As Nullable(Of Integer)

        Public Property colFldIcon() As String Implements IrowTblMetaMapPin.colFldIcon
            Get
                Return m_colFldIcon
            End Get
            Set
                If Not Same(m_colFldIcon, Value) Then
                    m_colFldIcon = Value
                    m_IsDirty(FieldIndex.colFldIcon) = True
                End If
            End Set
        End Property
        Private m_colFldIcon As String

        Public Property colFldHeight() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldHeight
            Get
                Return m_colFldHeight
            End Get
            Set
                If Not Same(m_colFldHeight, Value) Then
                    m_colFldHeight = Value
                    m_IsDirty(FieldIndex.colFldHeight) = True
                End If
            End Set
        End Property
        Private m_colFldHeight As Nullable(Of Integer)

        Public Property colFldWidth() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldWidth
            Get
                Return m_colFldWidth
            End Get
            Set
                If Not Same(m_colFldWidth, Value) Then
                    m_colFldWidth = Value
                    m_IsDirty(FieldIndex.colFldWidth) = True
                End If
            End Set
        End Property
        Private m_colFldWidth As Nullable(Of Integer)

        Public Property colFldAnchorX() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldAnchorX
            Get
                Return m_colFldAnchorX
            End Get
            Set
                If Not Same(m_colFldAnchorX, Value) Then
                    m_colFldAnchorX = Value
                    m_IsDirty(FieldIndex.colFldAnchorX) = True
                End If
            End Set
        End Property
        Private m_colFldAnchorX As Nullable(Of Integer)

        Public Property colFldAnchorY() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldAnchorY
            Get
                Return m_colFldAnchorY
            End Get
            Set
                If Not Same(m_colFldAnchorY, Value) Then
                    m_colFldAnchorY = Value
                    m_IsDirty(FieldIndex.colFldAnchorY) = True
                End If
            End Set
        End Property
        Private m_colFldAnchorY As Nullable(Of Integer)

        Public Property colFldTextOffsetX() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldTextOffsetX
            Get
                Return m_colFldTextOffsetX
            End Get
            Set
                If Not Same(m_colFldTextOffsetX, Value) Then
                    m_colFldTextOffsetX = Value
                    m_IsDirty(FieldIndex.colFldTextOffsetX) = True
                End If
            End Set
        End Property
        Private m_colFldTextOffsetX As Nullable(Of Integer)

        Public Property colFldTextOffsetY() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldTextOffsetY
            Get
                Return m_colFldTextOffsetY
            End Get
            Set
                If Not Same(m_colFldTextOffsetY, Value) Then
                    m_colFldTextOffsetY = Value
                    m_IsDirty(FieldIndex.colFldTextOffsetY) = True
                End If
            End Set
        End Property
        Private m_colFldTextOffsetY As Nullable(Of Integer)

        Public Property colFldNote() As String Implements IrowTblMetaMapPin.colFldNote
            Get
                Return m_colFldNote
            End Get
            Set
                If Not Same(m_colFldNote, Value) Then
                    m_colFldNote = Value
                    m_IsDirty(FieldIndex.colFldNote) = True
                End If
            End Set
        End Property
        Private m_colFldNote As String

        Public Property colFldBaseString() As String Implements IrowTblMetaMapPin.colFldBaseString
            Get
                Return m_colFldBaseString
            End Get
            Set
                If Not Same(m_colFldBaseString, Value) Then
                    m_colFldBaseString = Value
                    m_IsDirty(FieldIndex.colFldBaseString) = True
                End If
            End Set
        End Property
        Private m_colFldBaseString As String

        Public Property colFldMetaColorId() As Nullable(Of Integer) Implements IrowTblMetaMapPin.colFldMetaColorId
            Get
                Return m_colFldMetaColorId
            End Get
            Set
                If Not Same(m_colFldMetaColorId, Value) Then
                    m_colFldMetaColorId = Value
                    m_IsDirty(FieldIndex.colFldMetaColorId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaColorId As Nullable(Of Integer)


        Public Function IsDirty(pIndex As rowTblMetaMapPin.FieldIndex) As Boolean Implements IrowTblMetaMapPin.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaMapPin.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaMapPin.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldIcon) = pDirty
            m_IsDirty(FieldIndex.colFldHeight) = pDirty
            m_IsDirty(FieldIndex.colFldWidth) = pDirty
            m_IsDirty(FieldIndex.colFldAnchorX) = pDirty
            m_IsDirty(FieldIndex.colFldAnchorY) = pDirty
            m_IsDirty(FieldIndex.colFldTextOffsetX) = pDirty
            m_IsDirty(FieldIndex.colFldTextOffsetY) = pDirty
            m_IsDirty(FieldIndex.colFldNote) = pDirty
            m_IsDirty(FieldIndex.colFldBaseString) = pDirty
            m_IsDirty(FieldIndex.colFldMetaColorId) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaMapPin) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaMapPin
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldIcon 
            colFldHeight 
            colFldWidth 
            colFldAnchorX 
            colFldAnchorY 
            colFldTextOffsetX 
            colFldTextOffsetY 
            colFldNote 
            colFldBaseString 
            colFldMetaColorId 
        End Enum

        Private m_IsDirty(11) As Boolean

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

    Public Interface IrowTblMetaMapPin
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldIcon() As String
        Property colFldHeight() As Nullable(Of Integer)
        Property colFldWidth() As Nullable(Of Integer)
        Property colFldAnchorX() As Nullable(Of Integer)
        Property colFldAnchorY() As Nullable(Of Integer)
        Property colFldTextOffsetX() As Nullable(Of Integer)
        Property colFldTextOffsetY() As Nullable(Of Integer)
        Property colFldNote() As String
        Property colFldBaseString() As String
        Property colFldMetaColorId() As Nullable(Of Integer)
        Function IsDirty(pIndex As rowTblMetaMapPin.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

