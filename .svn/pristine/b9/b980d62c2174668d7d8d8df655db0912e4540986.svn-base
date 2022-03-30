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
    Partial Public Class TblMetaPractice

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaPractice)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaPractice, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaPractice, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaPractice, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaPractice] " & _
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
        Dim zObj As rowTblMetaPractice = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaPractice)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaPractice, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaPractice, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaPractice] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaPractice] SET " 
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldName] = @colFldName "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldReportDisplayTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldReportDisplayTitle] = @colFldReportDisplayTitle "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldIsHazard) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldIsHazard] = @colFldIsHazard "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldFilterValue) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFilterValue] = @colFldFilterValue "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeCode) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPracticeCode] = @colFldPracticeCode "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeGroupCode) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPracticeGroupCode] = @colFldPracticeGroupCode "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldSortOrder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldSortOrder] = @colFldSortOrder "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeLetter) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPracticeLetter] = @colFldPracticeLetter "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldShortName) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldShortName] = @colFldShortName "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeNameText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPracticeNameText] = @colFldPracticeNameText "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeNameHTML) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldPracticeNameHTML] = @colFldPracticeNameHTML "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldNavLinkAllReportsKeyword) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNavLinkAllReportsKeyword] = @colFldNavLinkAllReportsKeyword "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldImageHtml) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldImageHtml] = @colFldImageHtml "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldLocationListingUrl) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLocationListingUrl] = @colFldLocationListingUrl "
                        End If
                        If pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldLearnMoreUrl) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldLearnMoreUrl] = @colFldLearnMoreUrl "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaPractice] ([fldName], [fldReportDisplayTitle], [fldIsHazard], [fldFilterValue], [fldPracticeCode], [fldPracticeGroupCode], [fldSortOrder], [fldPracticeLetter], [fldShortName], [fldPracticeNameText], [fldPracticeNameHTML], [fldNavLinkAllReportsKeyword], [fldImageHtml], [fldLocationListingUrl], [fldLearnMoreUrl])" & _
                            " VALUES (@colFldName, @colFldReportDisplayTitle, @colFldIsHazard, @colFldFilterValue, @colFldPracticeCode, @colFldPracticeGroupCode, @colFldSortOrder, @colFldPracticeLetter, @colFldShortName, @colFldPracticeNameText, @colFldPracticeNameHTML, @colFldNavLinkAllReportsKeyword, @colFldImageHtml, @colFldLocationListingUrl, @colFldLearnMoreUrl); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaPractice] ([fldName], [fldReportDisplayTitle], [fldIsHazard], [fldFilterValue], [fldPracticeCode], [fldPracticeGroupCode], [fldSortOrder], [fldPracticeLetter], [fldShortName], [fldPracticeNameText], [fldPracticeNameHTML], [fldNavLinkAllReportsKeyword], [fldImageHtml], [fldLocationListingUrl], [fldLearnMoreUrl])" & _
                            " VALUES (@colFldName, @colFldReportDisplayTitle, @colFldIsHazard, @colFldFilterValue, @colFldPracticeCode, @colFldPracticeGroupCode, @colFldSortOrder, @colFldPracticeLetter, @colFldShortName, @colFldPracticeNameText, @colFldPracticeNameHTML, @colFldNavLinkAllReportsKeyword, @colFldImageHtml, @colFldLocationListingUrl, @colFldLearnMoreUrl); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldName", IIf(pRowData.colFldName Is Nothing, DBNull.Value, pRowData.colFldName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldReportDisplayTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldReportDisplayTitle", IIf(pRowData.colFldReportDisplayTitle Is Nothing, DBNull.Value, pRowData.colFldReportDisplayTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldIsHazard) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldIsHazard", IIf(pRowData.colFldIsHazard Is Nothing, DBNull.Value, pRowData.colFldIsHazard)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldFilterValue) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFilterValue", IIf(pRowData.colFldFilterValue Is Nothing, DBNull.Value, pRowData.colFldFilterValue)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeCode) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPracticeCode", IIf(pRowData.colFldPracticeCode Is Nothing, DBNull.Value, pRowData.colFldPracticeCode)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeGroupCode) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPracticeGroupCode", IIf(pRowData.colFldPracticeGroupCode Is Nothing, DBNull.Value, pRowData.colFldPracticeGroupCode)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldSortOrder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldSortOrder", IIf(pRowData.colFldSortOrder Is Nothing, DBNull.Value, pRowData.colFldSortOrder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeLetter) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPracticeLetter", IIf(pRowData.colFldPracticeLetter Is Nothing, DBNull.Value, pRowData.colFldPracticeLetter)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldShortName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldShortName", IIf(pRowData.colFldShortName Is Nothing, DBNull.Value, pRowData.colFldShortName)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeNameText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPracticeNameText", IIf(pRowData.colFldPracticeNameText Is Nothing, DBNull.Value, pRowData.colFldPracticeNameText)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldPracticeNameHTML) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldPracticeNameHTML", IIf(pRowData.colFldPracticeNameHTML Is Nothing, DBNull.Value, pRowData.colFldPracticeNameHTML)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldNavLinkAllReportsKeyword) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNavLinkAllReportsKeyword", IIf(pRowData.colFldNavLinkAllReportsKeyword Is Nothing, DBNull.Value, pRowData.colFldNavLinkAllReportsKeyword)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldImageHtml) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldImageHtml", IIf(pRowData.colFldImageHtml Is Nothing, DBNull.Value, pRowData.colFldImageHtml)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldLocationListingUrl) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLocationListingUrl", IIf(pRowData.colFldLocationListingUrl Is Nothing, DBNull.Value, pRowData.colFldLocationListingUrl)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaPractice.FieldIndex.colFldLearnMoreUrl) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldLearnMoreUrl", IIf(pRowData.colFldLearnMoreUrl Is Nothing, DBNull.Value, pRowData.colFldLearnMoreUrl)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaPractice
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaPractice
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaPractice
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaPractice
            Dim zReturn As New rowTblMetaPractice
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaPractice] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaPractice) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId As Integer) As List(Of rowTblMetaPractice)
            Return LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaPractice)
            Return LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaPractice)
            Return LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaPractice)
            Dim zReturn As New List(Of rowTblMetaPractice)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaPractice] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaPractice)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaPractice)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaPractice)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaPractice)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaPractice)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaPractice)
            Dim zReturn As New List(Of rowTblMetaPractice)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaPractice]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaPractice)

			Try
	            Dim zReturn As New List(Of rowTblMetaPractice)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaPractice

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaPractice		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaPractice)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldName")) Then pObject.colFldName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldReportDisplayTitle")) Then pObject.colFldReportDisplayTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldReportDisplayTitle")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldIsHazard")) Then pObject.colFldIsHazard = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldIsHazard")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFilterValue")) Then pObject.colFldFilterValue = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFilterValue")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeCode")) Then pObject.colFldPracticeCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeGroupCode")) Then pObject.colFldPracticeGroupCode = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeGroupCode")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldSortOrder")) Then pObject.colFldSortOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSortOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeLetter")) Then pObject.colFldPracticeLetter = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeLetter")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldShortName")) Then pObject.colFldShortName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldShortName")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeNameText")) Then pObject.colFldPracticeNameText = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeNameText")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldPracticeNameHTML")) Then pObject.colFldPracticeNameHTML = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldPracticeNameHTML")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNavLinkAllReportsKeyword")) Then pObject.colFldNavLinkAllReportsKeyword = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNavLinkAllReportsKeyword")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldImageHtml")) Then pObject.colFldImageHtml = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldImageHtml")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLocationListingUrl")) Then pObject.colFldLocationListingUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLocationListingUrl")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldLearnMoreUrl")) Then pObject.colFldLearnMoreUrl = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldLearnMoreUrl")
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
            If Not TypeOf zReturn Is rowTblMetaPractice Then Throw New ArgumentException("Generic type is not type of rowTblMetaPractice.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaPractice] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK__tblMetaP__36326BE350C85C06(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaPractice] WHERE [fldId] = @colFldId"
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaPractice]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaPractice
        Implements IrowTblMetaPractice

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaPractice.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaPractice.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaPractice.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaPractice.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaPractice.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaPractice.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaPractice.colFldId
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

        Public Property colFldName() As String Implements IrowTblMetaPractice.colFldName
            Get
                Return m_colFldName
            End Get
            Set
                If Not Same(m_colFldName, Value) Then
                    m_colFldName = Value
                    m_IsDirty(FieldIndex.colFldName) = True
                End If
            End Set
        End Property
        Private m_colFldName As String

        Public Property colFldReportDisplayTitle() As String Implements IrowTblMetaPractice.colFldReportDisplayTitle
            Get
                Return m_colFldReportDisplayTitle
            End Get
            Set
                If Not Same(m_colFldReportDisplayTitle, Value) Then
                    m_colFldReportDisplayTitle = Value
                    m_IsDirty(FieldIndex.colFldReportDisplayTitle) = True
                End If
            End Set
        End Property
        Private m_colFldReportDisplayTitle As String

        Public Property colFldIsHazard() As Nullable(Of Boolean) Implements IrowTblMetaPractice.colFldIsHazard
            Get
                Return m_colFldIsHazard
            End Get
            Set
                If Not Same(m_colFldIsHazard, Value) Then
                    m_colFldIsHazard = Value
                    m_IsDirty(FieldIndex.colFldIsHazard) = True
                End If
            End Set
        End Property
        Private m_colFldIsHazard As Nullable(Of Boolean)

        Public Property colFldFilterValue() As String Implements IrowTblMetaPractice.colFldFilterValue
            Get
                Return m_colFldFilterValue
            End Get
            Set
                If Not Same(m_colFldFilterValue, Value) Then
                    m_colFldFilterValue = Value
                    m_IsDirty(FieldIndex.colFldFilterValue) = True
                End If
            End Set
        End Property
        Private m_colFldFilterValue As String

        Public Property colFldPracticeCode() As String Implements IrowTblMetaPractice.colFldPracticeCode
            Get
                Return m_colFldPracticeCode
            End Get
            Set
                If Not Same(m_colFldPracticeCode, Value) Then
                    m_colFldPracticeCode = Value
                    m_IsDirty(FieldIndex.colFldPracticeCode) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeCode As String

        Public Property colFldPracticeGroupCode() As String Implements IrowTblMetaPractice.colFldPracticeGroupCode
            Get
                Return m_colFldPracticeGroupCode
            End Get
            Set
                If Not Same(m_colFldPracticeGroupCode, Value) Then
                    m_colFldPracticeGroupCode = Value
                    m_IsDirty(FieldIndex.colFldPracticeGroupCode) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeGroupCode As String

        Public Property colFldSortOrder() As Nullable(Of Integer) Implements IrowTblMetaPractice.colFldSortOrder
            Get
                Return m_colFldSortOrder
            End Get
            Set
                If Not Same(m_colFldSortOrder, Value) Then
                    m_colFldSortOrder = Value
                    m_IsDirty(FieldIndex.colFldSortOrder) = True
                End If
            End Set
        End Property
        Private m_colFldSortOrder As Nullable(Of Integer)

        Public Property colFldPracticeLetter() As String Implements IrowTblMetaPractice.colFldPracticeLetter
            Get
                Return m_colFldPracticeLetter
            End Get
            Set
                If Not Same(m_colFldPracticeLetter, Value) Then
                    m_colFldPracticeLetter = Value
                    m_IsDirty(FieldIndex.colFldPracticeLetter) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeLetter As String

        Public Property colFldShortName() As String Implements IrowTblMetaPractice.colFldShortName
            Get
                Return m_colFldShortName
            End Get
            Set
                If Not Same(m_colFldShortName, Value) Then
                    m_colFldShortName = Value
                    m_IsDirty(FieldIndex.colFldShortName) = True
                End If
            End Set
        End Property
        Private m_colFldShortName As String

        Public Property colFldPracticeNameText() As String Implements IrowTblMetaPractice.colFldPracticeNameText
            Get
                Return m_colFldPracticeNameText
            End Get
            Set
                If Not Same(m_colFldPracticeNameText, Value) Then
                    m_colFldPracticeNameText = Value
                    m_IsDirty(FieldIndex.colFldPracticeNameText) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeNameText As String

        Public Property colFldPracticeNameHTML() As String Implements IrowTblMetaPractice.colFldPracticeNameHTML
            Get
                Return m_colFldPracticeNameHTML
            End Get
            Set
                If Not Same(m_colFldPracticeNameHTML, Value) Then
                    m_colFldPracticeNameHTML = Value
                    m_IsDirty(FieldIndex.colFldPracticeNameHTML) = True
                End If
            End Set
        End Property
        Private m_colFldPracticeNameHTML As String

        Public Property colFldNavLinkAllReportsKeyword() As String Implements IrowTblMetaPractice.colFldNavLinkAllReportsKeyword
            Get
                Return m_colFldNavLinkAllReportsKeyword
            End Get
            Set
                If Not Same(m_colFldNavLinkAllReportsKeyword, Value) Then
                    m_colFldNavLinkAllReportsKeyword = Value
                    m_IsDirty(FieldIndex.colFldNavLinkAllReportsKeyword) = True
                End If
            End Set
        End Property
        Private m_colFldNavLinkAllReportsKeyword As String

        Public Property colFldImageHtml() As String Implements IrowTblMetaPractice.colFldImageHtml
            Get
                Return m_colFldImageHtml
            End Get
            Set
                If Not Same(m_colFldImageHtml, Value) Then
                    m_colFldImageHtml = Value
                    m_IsDirty(FieldIndex.colFldImageHtml) = True
                End If
            End Set
        End Property
        Private m_colFldImageHtml As String

        Public Property colFldLocationListingUrl() As String Implements IrowTblMetaPractice.colFldLocationListingUrl
            Get
                Return m_colFldLocationListingUrl
            End Get
            Set
                If Not Same(m_colFldLocationListingUrl, Value) Then
                    m_colFldLocationListingUrl = Value
                    m_IsDirty(FieldIndex.colFldLocationListingUrl) = True
                End If
            End Set
        End Property
        Private m_colFldLocationListingUrl As String

        Public Property colFldLearnMoreUrl() As String Implements IrowTblMetaPractice.colFldLearnMoreUrl
            Get
                Return m_colFldLearnMoreUrl
            End Get
            Set
                If Not Same(m_colFldLearnMoreUrl, Value) Then
                    m_colFldLearnMoreUrl = Value
                    m_IsDirty(FieldIndex.colFldLearnMoreUrl) = True
                End If
            End Set
        End Property
        Private m_colFldLearnMoreUrl As String


        Public Function IsDirty(pIndex As rowTblMetaPractice.FieldIndex) As Boolean Implements IrowTblMetaPractice.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaPractice.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaPractice.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldName) = pDirty
            m_IsDirty(FieldIndex.colFldReportDisplayTitle) = pDirty
            m_IsDirty(FieldIndex.colFldIsHazard) = pDirty
            m_IsDirty(FieldIndex.colFldFilterValue) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeCode) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeGroupCode) = pDirty
            m_IsDirty(FieldIndex.colFldSortOrder) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeLetter) = pDirty
            m_IsDirty(FieldIndex.colFldShortName) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeNameText) = pDirty
            m_IsDirty(FieldIndex.colFldPracticeNameHTML) = pDirty
            m_IsDirty(FieldIndex.colFldNavLinkAllReportsKeyword) = pDirty
            m_IsDirty(FieldIndex.colFldImageHtml) = pDirty
            m_IsDirty(FieldIndex.colFldLocationListingUrl) = pDirty
            m_IsDirty(FieldIndex.colFldLearnMoreUrl) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaPractice) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaPractice
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldName 
            colFldReportDisplayTitle 
            colFldIsHazard 
            colFldFilterValue 
            colFldPracticeCode 
            colFldPracticeGroupCode 
            colFldSortOrder 
            colFldPracticeLetter 
            colFldShortName 
            colFldPracticeNameText 
            colFldPracticeNameHTML 
            colFldNavLinkAllReportsKeyword 
            colFldImageHtml 
            colFldLocationListingUrl 
            colFldLearnMoreUrl 
        End Enum

        Private m_IsDirty(16) As Boolean

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

    Public Interface IrowTblMetaPractice
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldName() As String
        Property colFldReportDisplayTitle() As String
        Property colFldIsHazard() As Nullable(Of Boolean)
        Property colFldFilterValue() As String
        Property colFldPracticeCode() As String
        Property colFldPracticeGroupCode() As String
        Property colFldSortOrder() As Nullable(Of Integer)
        Property colFldPracticeLetter() As String
        Property colFldShortName() As String
        Property colFldPracticeNameText() As String
        Property colFldPracticeNameHTML() As String
        Property colFldNavLinkAllReportsKeyword() As String
        Property colFldImageHtml() As String
        Property colFldLocationListingUrl() As String
        Property colFldLearnMoreUrl() As String
        Function IsDirty(pIndex As rowTblMetaPractice.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

