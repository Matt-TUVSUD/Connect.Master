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
    Partial Public Class TblBatchProcessingFile

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingFile)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingFile, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingFile, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblBatchProcessingFile, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblBatchProcessingFile] " & _
                        "WHERE [fldSetId] = @colFldSetId"

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL
                zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))

                zCmd.Transaction = pTransaction
                razor.UtilSQLServer.ExecuteNonQuery(zCmd)

                pRowData.RaiseDeletedEvent(pDeleteEventUserState)

            End If

        End Sub

        Public Shared Sub Delete(pcolFldSetId As Integer)
            Delete(pcolFldSetId, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(pcolFldSetId As Integer, pDeleteEventUserState As Object)
            Delete(pcolFldSetId, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(pcolFldSetId As Integer, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pcolFldSetId, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(pcolFldSetId As Integer, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zObj As rowTblBatchProcessingFile = LoadByPrimaryKey(pcolFldSetId, pTransaction, Nothing)
            Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingFile)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingFile, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblBatchProcessingFile, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

            If pRowData.IsDirty() Then
                Dim zSQL As String = ""
                Dim zMode As String = ""
                Dim zExistInDB As Long = -1
                If razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) Then

                    zSQL = "SELECT COUNT(*) from [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"

                    Dim zCmdDoesExist As New SQLCommand

                    zCmdDoesExist.CommandText = zSQL

                    zCmdDoesExist.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))

                    'if zExistInDB > 0  then  PK exists in the DB
                    zCmdDoesExist.Transaction = pTransaction
                    zExistInDB = razor.UtilSQLServer.ExecuteScalar(zCmdDoesExist)
                End If

                If razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) And zExistInDB > 0 Then
                    zMode = "UPDATE"
                End If
                If razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) And zExistInDB = 0 Then
                    zMode = "INSERTwithKey"
                End If
                If Not razor.UtilSQLServer.IsKeySet(pRowData.colFldSetId) Then
                    zMode = "INSERTnoKey"
                End If

                Select Case zMode
                    Case "UPDATE"
                        If pRowData.IsDirty Then
                            Dim zUpdate As String = ""
                            Dim zSet As String = ""
                            Dim zWhere As String = ""
                            zUpdate = "UPDATE [dbo].[tblBatchProcessingFile] SET "
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldGuid) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldGuid] = @colFldGuid "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldCreateDate) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldCreateDate] = @colFldCreateDate "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldAccessDate) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldAccessDate] = @colFldAccessDate "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldData) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldData] = @colFldData "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldFileSize) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldFileSize] = @colFldFileSize "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldMime) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldMime] = @colFldMime "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldExtension) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldExtension] = @colFldExtension "
                            End If
                            If pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldFileName) Then
                                If zSet.Length > 0 Then zSet = zSet & ","
                                zSet = zSet & " [fldFileName] = @colFldFileName "
                            End If
                            zWhere = " WHERE [fldSetId] = @colFldSetId"
                            zSQL = zUpdate & zSet & zWhere
                        End If
                    Case "INSERTwithKey"
                        zSQL = "INSERT INTO [dbo].[tblBatchProcessingFile] ([fldSetId], [fldGuid], [fldCreateDate], [fldAccessDate], [fldData], [fldFileSize], [fldMime], [fldExtension], [fldFileName])" & _
                                " VALUES (@colFldSetId, @colFldGuid, @colFldCreateDate, @colFldAccessDate, @colFldData, @colFldFileSize, @colFldMime, @colFldExtension, @colFldFileName); SELECT SCOPE_IDENTITY()"
                    Case "INSERTnoKey"
                        zSQL = "INSERT INTO [dbo].[tblBatchProcessingFile] ([fldGuid], [fldCreateDate], [fldAccessDate], [fldData], [fldFileSize], [fldMime], [fldExtension], [fldFileName])" & _
                                " VALUES (@colFldGuid, @colFldCreateDate, @colFldAccessDate, @colFldData, @colFldFileSize, @colFldMime, @colFldExtension, @colFldFileName); SELECT SCOPE_IDENTITY()"
                    Case Else
                End Select

                Dim zCmd As New SQLCommand
                zCmd.CommandText = zSQL

                'IF UPDATE, SET PK PARAMETER
                If zMode = "UPDATE" Then
                    zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))
                End If

                'IF INSERTING, KEY HAS VALUE AND KEY IS NOT IDENTITY, SET PK PARAMETER
                If zMode = "INSERTwithKey" Then
                    zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pRowData.colFldSetId))
                End If

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldGuid) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldGuid", IIf(pRowData.colFldGuid Is Nothing, DBNull.Value, pRowData.colFldGuid)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldCreateDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCreateDate", IIf(pRowData.colFldCreateDate Is Nothing, DBNull.Value, pRowData.colFldCreateDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldAccessDate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldAccessDate", IIf(pRowData.colFldAccessDate Is Nothing, DBNull.Value, pRowData.colFldAccessDate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldData) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldData", IIf(pRowData.colFldData Is Nothing, DBNull.Value, pRowData.colFldData)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldFileSize) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileSize", IIf(pRowData.colFldFileSize Is Nothing, DBNull.Value, pRowData.colFldFileSize)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldMime) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMime", IIf(pRowData.colFldMime Is Nothing, DBNull.Value, pRowData.colFldMime)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldExtension) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldExtension", IIf(pRowData.colFldExtension Is Nothing, DBNull.Value, pRowData.colFldExtension)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblBatchProcessingFile.FieldIndex.colFldFileName) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFileName", IIf(pRowData.colFldFileName Is Nothing, DBNull.Value, pRowData.colFldFileName)))
                End If

                zCmd.Transaction = pTransaction
                If zMode = "INSERTnoKey" Then
                    Dim zLastId As Long = 0
                    zLastId = razor.UtilSQLServer.ExecuteNonQueryRowId(zCmd)

                    pRowData.colFldSetId = zLastId
                Else
                    razor.UtilSQLServer.ExecuteNonQuery(zCmd)
                End If

                pRowData.SetIsDirty(False)
                pRowData.RaiseSavedEvent(pSavedEventUserState)

            End If

        End Sub

        Public Shared Function LoadByPrimaryKey(pcolFldSetId As Integer) As rowTblBatchProcessingFile
            Return LoadByPrimaryKey(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldSetId As Integer, pLoadEventUserState As Object) As rowTblBatchProcessingFile
            Return LoadByPrimaryKey(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblBatchProcessingFile
            Return LoadByPrimaryKey(pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblBatchProcessingFile
            Dim zReturn As New rowTblBatchProcessingFile
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction = pTransaction

            Dim zList As List(Of rowTblBatchProcessingFile) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count = 1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(pcolFldGuid As String) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_IX_fldGuid(pcolFldGuid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(pcolFldGuid As String, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_IX_fldGuid(pcolFldGuid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(pcolFldGuid As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_IX_fldGuid(pcolFldGuid, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(pcolFldGuid As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Dim zReturn As New List(Of rowTblBatchProcessingFile)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldGuid] = @colFldGuid"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldGuid", pcolFldGuid))

            zCmd.Transaction = pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)

            Return zReturn
        End Function
        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_IX_fldSetId(pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Dim zReturn As New List(Of rowTblBatchProcessingFile)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction = pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)

            Return zReturn
        End Function
        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId As Integer) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingFile)
            Return LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Dim zReturn As New List(Of rowTblBatchProcessingFile)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction = pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)

            Return zReturn
        End Function

        Public Shared Function LoadData() As List(Of rowTblBatchProcessingFile)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblBatchProcessingFile)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblBatchProcessingFile)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
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
            Return LoadData(pCommand, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)
            Dim zReturn As New List(Of rowTblBatchProcessingFile)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction = pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblBatchProcessingFile)

            Try
                Dim zReturn As New List(Of rowTblBatchProcessingFile)
                Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
                Dim zObj As New rowTblBatchProcessingFile

                Using pCommand
                    Using zReader
                        If zReader.HasRows() Then
                            While zReader.Read
                                zObj = New rowTblBatchProcessingFile
                                ReadDataRow(zReader, zObj)
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

        End Function

        Public Shared Function ReadData(Of T)(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of T)

            Try
                Dim zReturn As New List(Of T)
                Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
                Dim zObj As Object = Activator.CreateInstance(Of T)()

                Using pCommand
                    Using zReader
                        If zReader.HasRows() Then
                            While zReader.Read
                                zObj = Activator.CreateInstance(Of T)()
                                ReadDataRow(zReader, zObj)
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

        End Function

        Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblBatchProcessingFile)
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldSetId")) Then pObject.colFldSetId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldSetId")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldGuid")) Then pObject.colFldGuid = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldGuid")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldCreateDate")) Then pObject.colFldCreateDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldCreateDate")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldAccessDate")) Then pObject.colFldAccessDate = UtilSQLServer.SafeReader.SafeReadDateTime(pReader, "fldAccessDate")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldData")) Then pObject.colFldData = pReader.GetSqlBytes(pReader.GetOrdinal("fldData")).Value
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileSize")) Then pObject.colFldFileSize = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldFileSize")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldMime")) Then pObject.colFldMime = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMime")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldExtension")) Then pObject.colFldExtension = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldExtension")
            If Not pReader.IsDBNull(pReader.GetOrdinal("fldFileName")) Then pObject.colFldFileName = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFileName")
            pObject.SetIsDirty(False)
            Return pObject
        End Function

#Region "Reflection Based Load Functions"

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSetId As Integer) As T
            Return LoadByPrimaryKey(Of T)(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSetId As Integer, pLoadEventUserState As Object) As T
            Return LoadByPrimaryKey(Of T)(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As T
            Return LoadByPrimaryKey(Of T)(pcolFldSetId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As T

            Dim zReturn As Object = Activator.CreateInstance(Of T)()
            If Not TypeOf zReturn Is rowTblBatchProcessingFile Then Throw New ArgumentException("Generic type is not type of rowTblBatchProcessingFile.", "T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction = pTransaction

            Dim zList As List(Of T) = ReadData(Of T)(zCmd, pLoadEventUserState)
            If zList.Count = 1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid As String) As List(Of T)
            Return LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldGuid(Of T)(pcolFldGuid As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldGuid] = @colFldGuid"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldGuid", pcolFldGuid))

            zCmd.Transaction = pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_IX_fldSetId(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction = pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblBatchProcessingFile(Of T)(pcolFldSetId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile] WHERE [fldSetId] = @colFldSetId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldSetId", pcolFldSetId))

            zCmd.Transaction = pTransaction
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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblBatchProcessingFile]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction = pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)

            Return zReturn

        End Function

#End Region


    End Class
    <serializable>
 Partial Public Class rowTblBatchProcessingFile
        Implements IrowTblBatchProcessingFile

        Public Event Loaded(pUserState As Object) Implements IrowTblBatchProcessingFile.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblBatchProcessingFile.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblBatchProcessingFile.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblBatchProcessingFile.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblBatchProcessingFile.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblBatchProcessingFile.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldSetId() As Nullable(Of Integer) Implements IrowTblBatchProcessingFile.colFldSetId
            Get
                Return m_colFldSetId
            End Get
            Set(value As Nullable(Of Integer))
                If Not Same(m_colFldSetId, Value) Then
                    m_colFldSetId = Value
                    m_IsDirty(FieldIndex.colFldSetId) = True
                End If
            End Set
        End Property
        Private m_colFldSetId As Nullable(Of Integer)

        Public Property colFldGuid() As String Implements IrowTblBatchProcessingFile.colFldGuid
            Get
                Return m_colFldGuid
            End Get
            Set(value As String)
                If Not Same(m_colFldGuid, Value) Then
                    m_colFldGuid = Value
                    m_IsDirty(FieldIndex.colFldGuid) = True
                End If
            End Set
        End Property
        Private m_colFldGuid As String

        Public Property colFldCreateDate() As Nullable(Of DateTime) Implements IrowTblBatchProcessingFile.colFldCreateDate
            Get
                Return m_colFldCreateDate
            End Get
            Set(value As Nullable(Of DateTime))
                If Not Same(m_colFldCreateDate, Value) Then
                    m_colFldCreateDate = Value
                    m_IsDirty(FieldIndex.colFldCreateDate) = True
                End If
            End Set
        End Property
        Private m_colFldCreateDate As Nullable(Of DateTime)

        Public Property colFldAccessDate() As Nullable(Of DateTime) Implements IrowTblBatchProcessingFile.colFldAccessDate
            Get
                Return m_colFldAccessDate
            End Get
            Set(value As Nullable(Of DateTime))
                If Not Same(m_colFldAccessDate, Value) Then
                    m_colFldAccessDate = Value
                    m_IsDirty(FieldIndex.colFldAccessDate) = True
                End If
            End Set
        End Property
        Private m_colFldAccessDate As Nullable(Of DateTime)

        Public Property colFldData() As Byte() Implements IrowTblBatchProcessingFile.colFldData
            Get
                Return m_colFldData
            End Get
            Set(value As Byte())
                If Not Same(m_colFldData, Value) Then
                    m_colFldData = Value
                    m_IsDirty(FieldIndex.colFldData) = True
                End If
            End Set
        End Property
        Private m_colFldData As Byte()

        Public Property colFldFileSize() As Nullable(Of Integer) Implements IrowTblBatchProcessingFile.colFldFileSize
            Get
                Return m_colFldFileSize
            End Get
            Set(value As Nullable(Of Integer))
                If Not Same(m_colFldFileSize, Value) Then
                    m_colFldFileSize = Value
                    m_IsDirty(FieldIndex.colFldFileSize) = True
                End If
            End Set
        End Property
        Private m_colFldFileSize As Nullable(Of Integer)

        Public Property colFldMime() As String Implements IrowTblBatchProcessingFile.colFldMime
            Get
                Return m_colFldMime
            End Get
            Set(value As String)
                If Not Same(m_colFldMime, Value) Then
                    m_colFldMime = Value
                    m_IsDirty(FieldIndex.colFldMime) = True
                End If
            End Set
        End Property
        Private m_colFldMime As String

        Public Property colFldExtension() As String Implements IrowTblBatchProcessingFile.colFldExtension
            Get
                Return m_colFldExtension
            End Get
            Set(value As String)
                If Not Same(m_colFldExtension, Value) Then
                    m_colFldExtension = Value
                    m_IsDirty(FieldIndex.colFldExtension) = True
                End If
            End Set
        End Property
        Private m_colFldExtension As String

        Public Property colFldFileName() As String Implements IrowTblBatchProcessingFile.colFldFileName
            Get
                Return m_colFldFileName
            End Get
            Set(value As String)
                If Not Same(m_colFldFileName, Value) Then
                    m_colFldFileName = Value
                    m_IsDirty(FieldIndex.colFldFileName) = True
                End If
            End Set
        End Property
        Private m_colFldFileName As String


        Public Function IsDirty(pIndex As rowTblBatchProcessingFile.FieldIndex) As Boolean Implements IrowTblBatchProcessingFile.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblBatchProcessingFile.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblBatchProcessingFile.SetIsDirty
            m_IsDirty(FieldIndex.colFldSetId) = pDirty
            m_IsDirty(FieldIndex.colFldGuid) = pDirty
            m_IsDirty(FieldIndex.colFldCreateDate) = pDirty
            m_IsDirty(FieldIndex.colFldAccessDate) = pDirty
            m_IsDirty(FieldIndex.colFldData) = pDirty
            m_IsDirty(FieldIndex.colFldFileSize) = pDirty
            m_IsDirty(FieldIndex.colFldMime) = pDirty
            m_IsDirty(FieldIndex.colFldExtension) = pDirty
            m_IsDirty(FieldIndex.colFldFileName) = pDirty
        End Sub

        ''' <summary>
        ''' Returns the type (TblBatchProcessingFile) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
        Public Shared Function GetTableType() As Type
            Dim zObj As New TblBatchProcessingFile
            Return zObj.GetType
        End Function

        Public Enum FieldIndex
            colFldSetId = 1
            colFldGuid
            colFldCreateDate
            colFldAccessDate
            colFldData
            colFldFileSize
            colFldMime
            colFldExtension
            colFldFileName
        End Enum

        Private m_IsDirty(9) As Boolean

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

    Public Interface IrowTblBatchProcessingFile
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
        Event Deleted(pUserState As Object)

        Property colFldSetId() As Nullable(Of Integer)
        Property colFldGuid() As String
        Property colFldCreateDate() As Nullable(Of DateTime)
        Property colFldAccessDate() As Nullable(Of DateTime)
        Property colFldData() As Byte()
        Property colFldFileSize() As Nullable(Of Integer)
        Property colFldMime() As String
        Property colFldExtension() As String
        Property colFldFileName() As String
        Function IsDirty(pIndex As rowTblBatchProcessingFile.FieldIndex) As Boolean
        Function IsDirty() As Boolean
        Sub RaiseLoadedEvent(pUserState As Object)
        Sub RaiseSavedEvent(pUserState As Object)
        Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

