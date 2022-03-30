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
    Partial Public Class TblMetaGridColumn

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGridColumn)
            Delete(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGridColumn, pDeleteEventUserState As Object)
            Delete(pRowData, Nothing, pDeleteEventUserState)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGridColumn, ByRef pTransaction As SqlClient.SqlTransaction)
            Delete(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Delete(ByRef pRowData As IrowTblMetaGridColumn, ByRef pTransaction As SqlClient.SqlTransaction, pDeleteEventUserState As Object)
            Dim zSQL As String = ""
            Dim zMode As String = ""

            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then


                'Delete
                zMode = "DELETE"
                zSQL = "DELETE FROM [dbo].[tblMetaGridColumn] " & _
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
        Dim zObj As rowTblMetaGridColumn = LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        Delete(zObj, pTransaction, pDeleteEventUserState)
        End Sub	

        Public Shared Sub Save(ByRef pRowData As rowTblMetaGridColumn)
            Save(pRowData, Nothing, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaGridColumn, ByRef pTransaction As SqlClient.SqlTransaction)
            Save(pRowData, pTransaction, Nothing)
        End Sub

        Public Shared Sub Save(ByRef pRowData As rowTblMetaGridColumn, ByRef pTransaction As SqlClient.SqlTransaction, pSavedEventUserState As Object)

		If pRowData.IsDirty() Then
            Dim zSQL As String = ""
            Dim zMode As String = ""
            DIm zExistInDB As Long = -1
            If razor.UtilSQLServer.IsKeySet(pRowData.colFldId) Then

                zSQL = "SELECT COUNT(*) from [dbo].[tblMetaGridColumn] WHERE [fldId] = @colFldId"

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
                        zUpdate = "UPDATE [dbo].[tblMetaGridColumn] SET " 
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMetaGridId) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMetaGridId] = @colFldMetaGridId "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldNotes) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldNotes] = @colFldNotes "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colType) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [type] = @colType "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colEncoded) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [encoded] = @colEncoded "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [field] = @colField "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colTitle) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [title] = @colTitle "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colWidth) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [width] = @colWidth "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colHidden) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [hidden] = @colHidden "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFilterable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [filterable] = @colFilterable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colSortable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [sortable] = @colSortable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colGroupable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [groupable] = @colGroupable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colLocked) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [locked] = @colLocked "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colLockable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [lockable] = @colLockable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colInclude) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [include] = @colInclude "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFormat) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [format] = @colFormat "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colMenu) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [menu] = @colMenu "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colTemplate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [template] = @colTemplate "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colEditable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [editable] = @colEditable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colEditor) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [editor] = @colEditor "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colNullable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [nullable] = @colNullable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFooterTemplate) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [footerTemplate] = @colFooterTemplate "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colHeaderAttributes) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [headerAttributes] = @colHeaderAttributes "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colIndexOrder) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [IndexOrder] = @colIndexOrder "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colSrcField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SrcField] = @colSrcField "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colSrcTable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [SrcTable] = @colSrcTable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colKeyField) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [KeyField] = @colKeyField "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldFieldNameBackColor) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldFieldNameBackColor] = @colFldFieldNameBackColor "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldCustomFeature) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldCustomFeature] = @colFldCustomFeature "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldExcludeFromExtract) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldExcludeFromExtract] = @colFldExcludeFromExtract "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapTitleHtmlSnippet) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMapTitleHtmlSnippet] = @colFldMapTitleHtmlSnippet "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapPinIconSqlSnippet) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMapPinIconSqlSnippet] = @colFldMapPinIconSqlSnippet "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapDefaultDepicted) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMapDefaultDepicted] = @colFldMapDefaultDepicted "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapIsDepictable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMapIsDepictable] = @colFldMapIsDepictable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapIsPicklistable) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldMapIsPicklistable] = @colFldMapIsPicklistable "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldColumnDescription) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldColumnDescription] = @colFldColumnDescription "
                        End If
                        If pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldExtractWrapText) Then 
                            If zSet.Length > 0 Then zSet = zSet & ","
                            zSet = zSet & " [fldExtractWrapText] = @colFldExtractWrapText "
                        End If
                        zWhere = " WHERE [fldId] = @colFldId"
                        zSQL = zUpdate & zSet & zWhere
                    End If
                Case "INSERTwithKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaGridColumn] ([fldMetaGridId], [fldNotes], [type], [encoded], [field], [title], [width], [hidden], [filterable], [sortable], [groupable], [locked], [lockable], [include], [format], [menu], [template], [editable], [editor], [nullable], [footerTemplate], [headerAttributes], [IndexOrder], [SrcField], [SrcTable], [KeyField], [fldFieldNameBackColor], [fldCustomFeature], [fldExcludeFromExtract], [fldMapTitleHtmlSnippet], [fldMapPinIconSqlSnippet], [fldMapDefaultDepicted], [fldMapIsDepictable], [fldMapIsPicklistable], [fldColumnDescription], [fldExtractWrapText])" & _
                            " VALUES (@colFldMetaGridId, @colFldNotes, @colType, @colEncoded, @colField, @colTitle, @colWidth, @colHidden, @colFilterable, @colSortable, @colGroupable, @colLocked, @colLockable, @colInclude, @colFormat, @colMenu, @colTemplate, @colEditable, @colEditor, @colNullable, @colFooterTemplate, @colHeaderAttributes, @colIndexOrder, @colSrcField, @colSrcTable, @colKeyField, @colFldFieldNameBackColor, @colFldCustomFeature, @colFldExcludeFromExtract, @colFldMapTitleHtmlSnippet, @colFldMapPinIconSqlSnippet, @colFldMapDefaultDepicted, @colFldMapIsDepictable, @colFldMapIsPicklistable, @colFldColumnDescription, @colFldExtractWrapText); SELECT SCOPE_IDENTITY()"
                Case "INSERTnoKey"
                    zSQL = "INSERT INTO [dbo].[tblMetaGridColumn] ([fldMetaGridId], [fldNotes], [type], [encoded], [field], [title], [width], [hidden], [filterable], [sortable], [groupable], [locked], [lockable], [include], [format], [menu], [template], [editable], [editor], [nullable], [footerTemplate], [headerAttributes], [IndexOrder], [SrcField], [SrcTable], [KeyField], [fldFieldNameBackColor], [fldCustomFeature], [fldExcludeFromExtract], [fldMapTitleHtmlSnippet], [fldMapPinIconSqlSnippet], [fldMapDefaultDepicted], [fldMapIsDepictable], [fldMapIsPicklistable], [fldColumnDescription], [fldExtractWrapText])" & _
                            " VALUES (@colFldMetaGridId, @colFldNotes, @colType, @colEncoded, @colField, @colTitle, @colWidth, @colHidden, @colFilterable, @colSortable, @colGroupable, @colLocked, @colLockable, @colInclude, @colFormat, @colMenu, @colTemplate, @colEditable, @colEditor, @colNullable, @colFooterTemplate, @colHeaderAttributes, @colIndexOrder, @colSrcField, @colSrcTable, @colKeyField, @colFldFieldNameBackColor, @colFldCustomFeature, @colFldExcludeFromExtract, @colFldMapTitleHtmlSnippet, @colFldMapPinIconSqlSnippet, @colFldMapDefaultDepicted, @colFldMapIsDepictable, @colFldMapIsPicklistable, @colFldColumnDescription, @colFldExtractWrapText); SELECT SCOPE_IDENTITY()"
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

                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMetaGridId) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMetaGridId", IIf(pRowData.colFldMetaGridId Is Nothing, DBNull.Value, pRowData.colFldMetaGridId)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldNotes) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldNotes", IIf(pRowData.colFldNotes Is Nothing, DBNull.Value, pRowData.colFldNotes)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colType) Then
                    zCmd.Parameters.Add(New SqlParameter("@colType", IIf(pRowData.colType Is Nothing, DBNull.Value, pRowData.colType)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colEncoded) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEncoded", IIf(pRowData.colEncoded Is Nothing, DBNull.Value, pRowData.colEncoded)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colField", IIf(pRowData.colField Is Nothing, DBNull.Value, pRowData.colField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colTitle) Then
                    zCmd.Parameters.Add(New SqlParameter("@colTitle", IIf(pRowData.colTitle Is Nothing, DBNull.Value, pRowData.colTitle)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colWidth) Then
                    zCmd.Parameters.Add(New SqlParameter("@colWidth", IIf(pRowData.colWidth Is Nothing, DBNull.Value, pRowData.colWidth)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colHidden) Then
                    zCmd.Parameters.Add(New SqlParameter("@colHidden", IIf(pRowData.colHidden Is Nothing, DBNull.Value, pRowData.colHidden)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFilterable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFilterable", IIf(pRowData.colFilterable Is Nothing, DBNull.Value, pRowData.colFilterable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colSortable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSortable", IIf(pRowData.colSortable Is Nothing, DBNull.Value, pRowData.colSortable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colGroupable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colGroupable", IIf(pRowData.colGroupable Is Nothing, DBNull.Value, pRowData.colGroupable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colLocked) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLocked", IIf(pRowData.colLocked Is Nothing, DBNull.Value, pRowData.colLocked)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colLockable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colLockable", IIf(pRowData.colLockable Is Nothing, DBNull.Value, pRowData.colLockable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colInclude) Then
                    zCmd.Parameters.Add(New SqlParameter("@colInclude", IIf(pRowData.colInclude Is Nothing, DBNull.Value, pRowData.colInclude)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFormat) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFormat", IIf(pRowData.colFormat Is Nothing, DBNull.Value, pRowData.colFormat)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colMenu) Then
                    zCmd.Parameters.Add(New SqlParameter("@colMenu", IIf(pRowData.colMenu Is Nothing, DBNull.Value, pRowData.colMenu)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colTemplate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colTemplate", IIf(pRowData.colTemplate Is Nothing, DBNull.Value, pRowData.colTemplate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colEditable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEditable", IIf(pRowData.colEditable Is Nothing, DBNull.Value, pRowData.colEditable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colEditor) Then
                    zCmd.Parameters.Add(New SqlParameter("@colEditor", IIf(pRowData.colEditor Is Nothing, DBNull.Value, pRowData.colEditor)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colNullable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colNullable", IIf(pRowData.colNullable Is Nothing, DBNull.Value, pRowData.colNullable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFooterTemplate) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFooterTemplate", IIf(pRowData.colFooterTemplate Is Nothing, DBNull.Value, pRowData.colFooterTemplate)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colHeaderAttributes) Then
                    zCmd.Parameters.Add(New SqlParameter("@colHeaderAttributes", IIf(pRowData.colHeaderAttributes Is Nothing, DBNull.Value, pRowData.colHeaderAttributes)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colIndexOrder) Then
                    zCmd.Parameters.Add(New SqlParameter("@colIndexOrder", IIf(pRowData.colIndexOrder Is Nothing, DBNull.Value, pRowData.colIndexOrder)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colSrcField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSrcField", IIf(pRowData.colSrcField Is Nothing, DBNull.Value, pRowData.colSrcField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colSrcTable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colSrcTable", IIf(pRowData.colSrcTable Is Nothing, DBNull.Value, pRowData.colSrcTable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colKeyField) Then
                    zCmd.Parameters.Add(New SqlParameter("@colKeyField", IIf(pRowData.colKeyField Is Nothing, DBNull.Value, pRowData.colKeyField)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldFieldNameBackColor) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldFieldNameBackColor", IIf(pRowData.colFldFieldNameBackColor Is Nothing, DBNull.Value, pRowData.colFldFieldNameBackColor)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldCustomFeature) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldCustomFeature", IIf(pRowData.colFldCustomFeature Is Nothing, DBNull.Value, pRowData.colFldCustomFeature)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldExcludeFromExtract) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldExcludeFromExtract", IIf(pRowData.colFldExcludeFromExtract Is Nothing, DBNull.Value, pRowData.colFldExcludeFromExtract)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapTitleHtmlSnippet) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMapTitleHtmlSnippet", IIf(pRowData.colFldMapTitleHtmlSnippet Is Nothing, DBNull.Value, pRowData.colFldMapTitleHtmlSnippet)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapPinIconSqlSnippet) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMapPinIconSqlSnippet", IIf(pRowData.colFldMapPinIconSqlSnippet Is Nothing, DBNull.Value, pRowData.colFldMapPinIconSqlSnippet)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapDefaultDepicted) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMapDefaultDepicted", IIf(pRowData.colFldMapDefaultDepicted Is Nothing, DBNull.Value, pRowData.colFldMapDefaultDepicted)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapIsDepictable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMapIsDepictable", IIf(pRowData.colFldMapIsDepictable Is Nothing, DBNull.Value, pRowData.colFldMapIsDepictable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldMapIsPicklistable) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldMapIsPicklistable", IIf(pRowData.colFldMapIsPicklistable Is Nothing, DBNull.Value, pRowData.colFldMapIsPicklistable)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldColumnDescription) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldColumnDescription", IIf(pRowData.colFldColumnDescription Is Nothing, DBNull.Value, pRowData.colFldColumnDescription)))
                End If
                If zMode = "INSERTwithKey" Or zMode = "INSERTnoKey" Or pRowData.IsDirty(rowTblMetaGridColumn.FieldIndex.colFldExtractWrapText) Then
                    zCmd.Parameters.Add(New SqlParameter("@colFldExtractWrapText", IIf(pRowData.colFldExtractWrapText Is Nothing, DBNull.Value, pRowData.colFldExtractWrapText)))
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

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer) As rowTblMetaGridColumn
            Return LoadByPrimaryKey(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pLoadEventUserState As Object) As rowTblMetaGridColumn
            Return LoadByPrimaryKey(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As rowTblMetaGridColumn
            Return LoadByPrimaryKey(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByPrimaryKey(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As rowTblMetaGridColumn
            Dim zReturn As New rowTblMetaGridColumn
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction

            Dim zList As List(Of rowTblMetaGridColumn) = ReadData(zCmd, pLoadEventUserState)

            If zList.Count=1 Then
                Return zList(0)
            Else
                Return zReturn
            End If

            End Function

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(pcolFldId As Integer) As List(Of rowTblMetaGridColumn)
            Return LoadByIDX_PK_tblMetaGridColumn(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
            Return LoadByIDX_PK_tblMetaGridColumn(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaGridColumn)
            Return LoadByIDX_PK_tblMetaGridColumn(pcolFldId, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
            Dim zReturn As New List(Of rowTblMetaGridColumn)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function
        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId As Integer, pcolField As String) As List(Of rowTblMetaGridColumn)
            Return LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId, pcolField, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId As Integer, pcolField As String, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
            Return LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId, pcolField, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId As Integer, pcolField As String, pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaGridColumn)
            Return LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId, pcolField, pTransaction, Nothing)
        End Function

        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(pcolFldMetaGridId As Integer, pcolField As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
            Dim zReturn As New List(Of rowTblMetaGridColumn)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn] WHERE [fldMetaGridId] = @colFldMetaGridId AND [field] = @colField"
            Dim zCmd As New SQLCommand       
            zCmd.CommandText = zSQL 

            zCmd.Parameters.Add(New SQLParameter("@colFldMetaGridId", pcolFldMetaGridId))
            zCmd.Parameters.Add(New SQLParameter("@colField", pcolField))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn	
        End Function

        Public Shared Function LoadData() As List(Of rowTblMetaGridColumn)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
            Return LoadData(New SqlClient.SqlCommand(), Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadData(pSQL As String) As List(Of rowTblMetaGridColumn)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, Nothing, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction) As List(Of rowTblMetaGridColumn)
            Dim zCmd As New SqlClient.SqlCommand(pSQL)
            Return LoadData(zCmd, pTransaction, Nothing)
        End Function

        Public Shared Function LoadData(pSQL As String, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
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

        Public Shared Function LoadData(pCommand As SqlClient.SqlCommand, ByRef pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)
            Dim zReturn As New List(Of rowTblMetaGridColumn)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

        Public Shared Function ReadData(pCommand As SqlClient.SqlCommand, pLoadEventUserState As Object) As List(Of rowTblMetaGridColumn)

			Try
	            Dim zReturn As New List(Of rowTblMetaGridColumn)		
	            Dim zReader As SqlClient.SqlDataReader = razor.UtilSQLServer.ExecuteReader(pCommand)
	            Dim zObj As New rowTblMetaGridColumn

	            Using pCommand
	                Using zReader
	                    If zReader.HasRows() Then
	                        While zReader.Read
	                            zObj = New rowTblMetaGridColumn		
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

		Public Shared Function ReadDataRow(pReader As SqlClient.SqlDataReader, ByRef pObject As rowTblMetaGridColumn)
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldId")) Then pObject.colFldId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMetaGridId")) Then pObject.colFldMetaGridId = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "fldMetaGridId")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldNotes")) Then pObject.colFldNotes = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldNotes")
			If Not pReader.IsDBNull(pReader.GetOrdinal("type")) Then pObject.colType = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "type")
			If Not pReader.IsDBNull(pReader.GetOrdinal("encoded")) Then pObject.colEncoded = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "encoded")
			If Not pReader.IsDBNull(pReader.GetOrdinal("field")) Then pObject.colField = UtilSQLServer.SafeReader.SafeReadString(pReader, "field")
			If Not pReader.IsDBNull(pReader.GetOrdinal("title")) Then pObject.colTitle = UtilSQLServer.SafeReader.SafeReadString(pReader, "title")
			If Not pReader.IsDBNull(pReader.GetOrdinal("width")) Then pObject.colWidth = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "width")
			If Not pReader.IsDBNull(pReader.GetOrdinal("hidden")) Then pObject.colHidden = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "hidden")
			If Not pReader.IsDBNull(pReader.GetOrdinal("filterable")) Then pObject.colFilterable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "filterable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("sortable")) Then pObject.colSortable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "sortable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("groupable")) Then pObject.colGroupable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "groupable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("locked")) Then pObject.colLocked = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "locked")
			If Not pReader.IsDBNull(pReader.GetOrdinal("lockable")) Then pObject.colLockable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "lockable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("include")) Then pObject.colInclude = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "include")
			If Not pReader.IsDBNull(pReader.GetOrdinal("format")) Then pObject.colFormat = UtilSQLServer.SafeReader.SafeReadString(pReader, "format")
			If Not pReader.IsDBNull(pReader.GetOrdinal("menu")) Then pObject.colMenu = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "menu")
			If Not pReader.IsDBNull(pReader.GetOrdinal("template")) Then pObject.colTemplate = UtilSQLServer.SafeReader.SafeReadString(pReader, "template")
			If Not pReader.IsDBNull(pReader.GetOrdinal("editable")) Then pObject.colEditable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "editable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("editor")) Then pObject.colEditor = UtilSQLServer.SafeReader.SafeReadString(pReader, "editor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("nullable")) Then pObject.colNullable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "nullable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("footerTemplate")) Then pObject.colFooterTemplate = UtilSQLServer.SafeReader.SafeReadString(pReader, "footerTemplate")
			If Not pReader.IsDBNull(pReader.GetOrdinal("headerAttributes")) Then pObject.colHeaderAttributes = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "headerAttributes")
			If Not pReader.IsDBNull(pReader.GetOrdinal("IndexOrder")) Then pObject.colIndexOrder = UtilSQLServer.SafeReader.SafeReadInt32(pReader, "IndexOrder")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SrcField")) Then pObject.colSrcField = UtilSQLServer.SafeReader.SafeReadString(pReader, "SrcField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("SrcTable")) Then pObject.colSrcTable = UtilSQLServer.SafeReader.SafeReadString(pReader, "SrcTable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("KeyField")) Then pObject.colKeyField = UtilSQLServer.SafeReader.SafeReadString(pReader, "KeyField")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldFieldNameBackColor")) Then pObject.colFldFieldNameBackColor = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldFieldNameBackColor")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldCustomFeature")) Then pObject.colFldCustomFeature = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldCustomFeature")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExcludeFromExtract")) Then pObject.colFldExcludeFromExtract = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldExcludeFromExtract")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapTitleHtmlSnippet")) Then pObject.colFldMapTitleHtmlSnippet = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMapTitleHtmlSnippet")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapPinIconSqlSnippet")) Then pObject.colFldMapPinIconSqlSnippet = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldMapPinIconSqlSnippet")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapDefaultDepicted")) Then pObject.colFldMapDefaultDepicted = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapDefaultDepicted")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapIsDepictable")) Then pObject.colFldMapIsDepictable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapIsDepictable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldMapIsPicklistable")) Then pObject.colFldMapIsPicklistable = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldMapIsPicklistable")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldColumnDescription")) Then pObject.colFldColumnDescription = UtilSQLServer.SafeReader.SafeReadString(pReader, "fldColumnDescription")
			If Not pReader.IsDBNull(pReader.GetOrdinal("fldExtractWrapText")) Then pObject.colFldExtractWrapText = UtilSQLServer.SafeReader.SafeReadBoolean(pReader, "fldExtractWrapText")
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
            If Not TypeOf zReturn Is rowTblMetaGridColumn Then Throw New ArgumentException("Generic type is not type of rowTblMetaGridColumn.","T")

            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn] WHERE [fldId] = @colFldId"
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

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId As Integer) As List(Of T)
            Return LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId As Integer, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_PK_tblMetaGridColumn(Of T)(pcolFldId As Integer, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn] WHERE [fldId] = @colFldId"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldId", pcolFldId))

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn
        End Function

        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId As Integer, pcolField As String) As List(Of T)
            Return LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId, pcolField, Nothing, Nothing)
        End Function

        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId As Integer, pcolField As String, pLoadEventUserState As Object) As List(Of T)
            Return LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId, pcolField, Nothing, pLoadEventUserState)
        End Function

        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId As Integer, pcolField As String, pTransaction As SqlClient.SqlTransaction) As List(Of T)
            Return LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId, pcolField, pTransaction, Nothing)
        End Function

        ''' <summary>
        ''' Loads a list of items based on the supplied object type (Reflection Based Function)
        ''' </summary>
        Public Shared Function LoadByIDX_idx_tblMetaGridColumn_fldMetaGridID_fldField(Of T)(pcolFldMetaGridId As Integer, pcolField As String, pTransaction As SqlClient.SqlTransaction, pLoadEventUserState As Object) As List(Of T)
            Dim zReturn As New List(Of T)
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn] WHERE [fldMetaGridId] = @colFldMetaGridId AND [field] = @colField"
            Dim zCmd As New SQLCommand
            zCmd.CommandText = zSQL

            zCmd.Parameters.Add(New SQLParameter("@colFldMetaGridId", pcolFldMetaGridId))
            zCmd.Parameters.Add(New SQLParameter("@colField", pcolField))

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
            Dim zSQL As String = "SELECT * FROM [dbo].[tblMetaGridColumn]"
            Dim zCmd As New SQLCommand

            If String.IsNullOrEmpty(pCommand.CommandText) Then zCmd.CommandText = zSQL Else zCmd = pCommand

            zCmd.Transaction=pTransaction
            zReturn = ReadData(Of T)(zCmd, pLoadEventUserState)	

            Return zReturn

        End Function

    #End Region


    End Class
	<serializable>
    Partial Public Class rowTblMetaGridColumn
        Implements IrowTblMetaGridColumn

        Public Event Loaded(pUserState As Object) Implements IrowTblMetaGridColumn.Loaded
        Public Event Saved(pUserState As Object) Implements IrowTblMetaGridColumn.Saved
        Public Event Deleted(pUserState As Object) Implements IrowTblMetaGridColumn.Deleted


        Public Sub RaiseLoadedEvent(pUserState As Object) Implements IrowTblMetaGridColumn.RaiseLoadedEvent
            RaiseEvent Loaded(pUserState)
        End Sub

        Public Sub RaiseDeletedEvent(pUserState As Object) Implements IrowTblMetaGridColumn.RaiseDeletedEvent
            RaiseEvent Deleted(pUserState)
        End Sub

        Public Sub RaiseSavedEvent(pUserState As Object) Implements IrowTblMetaGridColumn.RaiseSavedEvent
            RaiseEvent Saved(pUserState)
        End Sub
        Public Property colFldId() As Nullable(Of Integer) Implements IrowTblMetaGridColumn.colFldId
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

        Public Property colFldMetaGridId() As Nullable(Of Integer) Implements IrowTblMetaGridColumn.colFldMetaGridId
            Get
                Return m_colFldMetaGridId
            End Get
            Set
                If Not Same(m_colFldMetaGridId, Value) Then
                    m_colFldMetaGridId = Value
                    m_IsDirty(FieldIndex.colFldMetaGridId) = True
                End If
            End Set
        End Property
        Private m_colFldMetaGridId As Nullable(Of Integer)

        Public Property colFldNotes() As String Implements IrowTblMetaGridColumn.colFldNotes
            Get
                Return m_colFldNotes
            End Get
            Set
                If Not Same(m_colFldNotes, Value) Then
                    m_colFldNotes = Value
                    m_IsDirty(FieldIndex.colFldNotes) = True
                End If
            End Set
        End Property
        Private m_colFldNotes As String

        Public Property colType() As Nullable(Of Integer) Implements IrowTblMetaGridColumn.colType
            Get
                Return m_colType
            End Get
            Set
                If Not Same(m_colType, Value) Then
                    m_colType = Value
                    m_IsDirty(FieldIndex.colType) = True
                End If
            End Set
        End Property
        Private m_colType As Nullable(Of Integer)

        Public Property colEncoded() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colEncoded
            Get
                Return m_colEncoded
            End Get
            Set
                If Not Same(m_colEncoded, Value) Then
                    m_colEncoded = Value
                    m_IsDirty(FieldIndex.colEncoded) = True
                End If
            End Set
        End Property
        Private m_colEncoded As Nullable(Of Boolean)

        Public Property colField() As String Implements IrowTblMetaGridColumn.colField
            Get
                Return m_colField
            End Get
            Set
                If Not Same(m_colField, Value) Then
                    m_colField = Value
                    m_IsDirty(FieldIndex.colField) = True
                End If
            End Set
        End Property
        Private m_colField As String

        Public Property colTitle() As String Implements IrowTblMetaGridColumn.colTitle
            Get
                Return m_colTitle
            End Get
            Set
                If Not Same(m_colTitle, Value) Then
                    m_colTitle = Value
                    m_IsDirty(FieldIndex.colTitle) = True
                End If
            End Set
        End Property
        Private m_colTitle As String

        Public Property colWidth() As Nullable(Of Integer) Implements IrowTblMetaGridColumn.colWidth
            Get
                Return m_colWidth
            End Get
            Set
                If Not Same(m_colWidth, Value) Then
                    m_colWidth = Value
                    m_IsDirty(FieldIndex.colWidth) = True
                End If
            End Set
        End Property
        Private m_colWidth As Nullable(Of Integer)

        Public Property colHidden() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colHidden
            Get
                Return m_colHidden
            End Get
            Set
                If Not Same(m_colHidden, Value) Then
                    m_colHidden = Value
                    m_IsDirty(FieldIndex.colHidden) = True
                End If
            End Set
        End Property
        Private m_colHidden As Nullable(Of Boolean)

        Public Property colFilterable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colFilterable
            Get
                Return m_colFilterable
            End Get
            Set
                If Not Same(m_colFilterable, Value) Then
                    m_colFilterable = Value
                    m_IsDirty(FieldIndex.colFilterable) = True
                End If
            End Set
        End Property
        Private m_colFilterable As Nullable(Of Boolean)

        Public Property colSortable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colSortable
            Get
                Return m_colSortable
            End Get
            Set
                If Not Same(m_colSortable, Value) Then
                    m_colSortable = Value
                    m_IsDirty(FieldIndex.colSortable) = True
                End If
            End Set
        End Property
        Private m_colSortable As Nullable(Of Boolean)

        Public Property colGroupable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colGroupable
            Get
                Return m_colGroupable
            End Get
            Set
                If Not Same(m_colGroupable, Value) Then
                    m_colGroupable = Value
                    m_IsDirty(FieldIndex.colGroupable) = True
                End If
            End Set
        End Property
        Private m_colGroupable As Nullable(Of Boolean)

        Public Property colLocked() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colLocked
            Get
                Return m_colLocked
            End Get
            Set
                If Not Same(m_colLocked, Value) Then
                    m_colLocked = Value
                    m_IsDirty(FieldIndex.colLocked) = True
                End If
            End Set
        End Property
        Private m_colLocked As Nullable(Of Boolean)

        Public Property colLockable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colLockable
            Get
                Return m_colLockable
            End Get
            Set
                If Not Same(m_colLockable, Value) Then
                    m_colLockable = Value
                    m_IsDirty(FieldIndex.colLockable) = True
                End If
            End Set
        End Property
        Private m_colLockable As Nullable(Of Boolean)

        Public Property colInclude() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colInclude
            Get
                Return m_colInclude
            End Get
            Set
                If Not Same(m_colInclude, Value) Then
                    m_colInclude = Value
                    m_IsDirty(FieldIndex.colInclude) = True
                End If
            End Set
        End Property
        Private m_colInclude As Nullable(Of Boolean)

        Public Property colFormat() As String Implements IrowTblMetaGridColumn.colFormat
            Get
                Return m_colFormat
            End Get
            Set
                If Not Same(m_colFormat, Value) Then
                    m_colFormat = Value
                    m_IsDirty(FieldIndex.colFormat) = True
                End If
            End Set
        End Property
        Private m_colFormat As String

        Public Property colMenu() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colMenu
            Get
                Return m_colMenu
            End Get
            Set
                If Not Same(m_colMenu, Value) Then
                    m_colMenu = Value
                    m_IsDirty(FieldIndex.colMenu) = True
                End If
            End Set
        End Property
        Private m_colMenu As Nullable(Of Boolean)

        Public Property colTemplate() As String Implements IrowTblMetaGridColumn.colTemplate
            Get
                Return m_colTemplate
            End Get
            Set
                If Not Same(m_colTemplate, Value) Then
                    m_colTemplate = Value
                    m_IsDirty(FieldIndex.colTemplate) = True
                End If
            End Set
        End Property
        Private m_colTemplate As String

        Public Property colEditable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colEditable
            Get
                Return m_colEditable
            End Get
            Set
                If Not Same(m_colEditable, Value) Then
                    m_colEditable = Value
                    m_IsDirty(FieldIndex.colEditable) = True
                End If
            End Set
        End Property
        Private m_colEditable As Nullable(Of Boolean)

        Public Property colEditor() As String Implements IrowTblMetaGridColumn.colEditor
            Get
                Return m_colEditor
            End Get
            Set
                If Not Same(m_colEditor, Value) Then
                    m_colEditor = Value
                    m_IsDirty(FieldIndex.colEditor) = True
                End If
            End Set
        End Property
        Private m_colEditor As String

        Public Property colNullable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colNullable
            Get
                Return m_colNullable
            End Get
            Set
                If Not Same(m_colNullable, Value) Then
                    m_colNullable = Value
                    m_IsDirty(FieldIndex.colNullable) = True
                End If
            End Set
        End Property
        Private m_colNullable As Nullable(Of Boolean)

        Public Property colFooterTemplate() As String Implements IrowTblMetaGridColumn.colFooterTemplate
            Get
                Return m_colFooterTemplate
            End Get
            Set
                If Not Same(m_colFooterTemplate, Value) Then
                    m_colFooterTemplate = Value
                    m_IsDirty(FieldIndex.colFooterTemplate) = True
                End If
            End Set
        End Property
        Private m_colFooterTemplate As String

        Public Property colHeaderAttributes() As Nullable(Of Integer) Implements IrowTblMetaGridColumn.colHeaderAttributes
            Get
                Return m_colHeaderAttributes
            End Get
            Set
                If Not Same(m_colHeaderAttributes, Value) Then
                    m_colHeaderAttributes = Value
                    m_IsDirty(FieldIndex.colHeaderAttributes) = True
                End If
            End Set
        End Property
        Private m_colHeaderAttributes As Nullable(Of Integer)

        Public Property colIndexOrder() As Nullable(Of Integer) Implements IrowTblMetaGridColumn.colIndexOrder
            Get
                Return m_colIndexOrder
            End Get
            Set
                If Not Same(m_colIndexOrder, Value) Then
                    m_colIndexOrder = Value
                    m_IsDirty(FieldIndex.colIndexOrder) = True
                End If
            End Set
        End Property
        Private m_colIndexOrder As Nullable(Of Integer)

        Public Property colSrcField() As String Implements IrowTblMetaGridColumn.colSrcField
            Get
                Return m_colSrcField
            End Get
            Set
                If Not Same(m_colSrcField, Value) Then
                    m_colSrcField = Value
                    m_IsDirty(FieldIndex.colSrcField) = True
                End If
            End Set
        End Property
        Private m_colSrcField As String

        Public Property colSrcTable() As String Implements IrowTblMetaGridColumn.colSrcTable
            Get
                Return m_colSrcTable
            End Get
            Set
                If Not Same(m_colSrcTable, Value) Then
                    m_colSrcTable = Value
                    m_IsDirty(FieldIndex.colSrcTable) = True
                End If
            End Set
        End Property
        Private m_colSrcTable As String

        Public Property colKeyField() As String Implements IrowTblMetaGridColumn.colKeyField
            Get
                Return m_colKeyField
            End Get
            Set
                If Not Same(m_colKeyField, Value) Then
                    m_colKeyField = Value
                    m_IsDirty(FieldIndex.colKeyField) = True
                End If
            End Set
        End Property
        Private m_colKeyField As String

        Public Property colFldFieldNameBackColor() As String Implements IrowTblMetaGridColumn.colFldFieldNameBackColor
            Get
                Return m_colFldFieldNameBackColor
            End Get
            Set
                If Not Same(m_colFldFieldNameBackColor, Value) Then
                    m_colFldFieldNameBackColor = Value
                    m_IsDirty(FieldIndex.colFldFieldNameBackColor) = True
                End If
            End Set
        End Property
        Private m_colFldFieldNameBackColor As String

        Public Property colFldCustomFeature() As String Implements IrowTblMetaGridColumn.colFldCustomFeature
            Get
                Return m_colFldCustomFeature
            End Get
            Set
                If Not Same(m_colFldCustomFeature, Value) Then
                    m_colFldCustomFeature = Value
                    m_IsDirty(FieldIndex.colFldCustomFeature) = True
                End If
            End Set
        End Property
        Private m_colFldCustomFeature As String

        Public Property colFldExcludeFromExtract() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colFldExcludeFromExtract
            Get
                Return m_colFldExcludeFromExtract
            End Get
            Set
                If Not Same(m_colFldExcludeFromExtract, Value) Then
                    m_colFldExcludeFromExtract = Value
                    m_IsDirty(FieldIndex.colFldExcludeFromExtract) = True
                End If
            End Set
        End Property
        Private m_colFldExcludeFromExtract As Nullable(Of Boolean)

        Public Property colFldMapTitleHtmlSnippet() As String Implements IrowTblMetaGridColumn.colFldMapTitleHtmlSnippet
            Get
                Return m_colFldMapTitleHtmlSnippet
            End Get
            Set
                If Not Same(m_colFldMapTitleHtmlSnippet, Value) Then
                    m_colFldMapTitleHtmlSnippet = Value
                    m_IsDirty(FieldIndex.colFldMapTitleHtmlSnippet) = True
                End If
            End Set
        End Property
        Private m_colFldMapTitleHtmlSnippet As String

        Public Property colFldMapPinIconSqlSnippet() As String Implements IrowTblMetaGridColumn.colFldMapPinIconSqlSnippet
            Get
                Return m_colFldMapPinIconSqlSnippet
            End Get
            Set
                If Not Same(m_colFldMapPinIconSqlSnippet, Value) Then
                    m_colFldMapPinIconSqlSnippet = Value
                    m_IsDirty(FieldIndex.colFldMapPinIconSqlSnippet) = True
                End If
            End Set
        End Property
        Private m_colFldMapPinIconSqlSnippet As String

        Public Property colFldMapDefaultDepicted() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colFldMapDefaultDepicted
            Get
                Return m_colFldMapDefaultDepicted
            End Get
            Set
                If Not Same(m_colFldMapDefaultDepicted, Value) Then
                    m_colFldMapDefaultDepicted = Value
                    m_IsDirty(FieldIndex.colFldMapDefaultDepicted) = True
                End If
            End Set
        End Property
        Private m_colFldMapDefaultDepicted As Nullable(Of Boolean)

        Public Property colFldMapIsDepictable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colFldMapIsDepictable
            Get
                Return m_colFldMapIsDepictable
            End Get
            Set
                If Not Same(m_colFldMapIsDepictable, Value) Then
                    m_colFldMapIsDepictable = Value
                    m_IsDirty(FieldIndex.colFldMapIsDepictable) = True
                End If
            End Set
        End Property
        Private m_colFldMapIsDepictable As Nullable(Of Boolean)

        Public Property colFldMapIsPicklistable() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colFldMapIsPicklistable
            Get
                Return m_colFldMapIsPicklistable
            End Get
            Set
                If Not Same(m_colFldMapIsPicklistable, Value) Then
                    m_colFldMapIsPicklistable = Value
                    m_IsDirty(FieldIndex.colFldMapIsPicklistable) = True
                End If
            End Set
        End Property
        Private m_colFldMapIsPicklistable As Nullable(Of Boolean)

        Public Property colFldColumnDescription() As String Implements IrowTblMetaGridColumn.colFldColumnDescription
            Get
                Return m_colFldColumnDescription
            End Get
            Set
                If Not Same(m_colFldColumnDescription, Value) Then
                    m_colFldColumnDescription = Value
                    m_IsDirty(FieldIndex.colFldColumnDescription) = True
                End If
            End Set
        End Property
        Private m_colFldColumnDescription As String

        Public Property colFldExtractWrapText() As Nullable(Of Boolean) Implements IrowTblMetaGridColumn.colFldExtractWrapText
            Get
                Return m_colFldExtractWrapText
            End Get
            Set
                If Not Same(m_colFldExtractWrapText, Value) Then
                    m_colFldExtractWrapText = Value
                    m_IsDirty(FieldIndex.colFldExtractWrapText) = True
                End If
            End Set
        End Property
        Private m_colFldExtractWrapText As Nullable(Of Boolean)


        Public Function IsDirty(pIndex As rowTblMetaGridColumn.FieldIndex) As Boolean Implements IrowTblMetaGridColumn.IsDirty
            Return m_IsDirty(pIndex)
        End Function

        Public Function IsDirty() As Boolean Implements IrowTblMetaGridColumn.IsDirty
            Return m_IsDirty.Contains(True)
        End Function

        Public Sub SetIsDirty(pDirty As Boolean) Implements IrowTblMetaGridColumn.SetIsDirty
            m_IsDirty(FieldIndex.colFldId) = pDirty
            m_IsDirty(FieldIndex.colFldMetaGridId) = pDirty
            m_IsDirty(FieldIndex.colFldNotes) = pDirty
            m_IsDirty(FieldIndex.colType) = pDirty
            m_IsDirty(FieldIndex.colEncoded) = pDirty
            m_IsDirty(FieldIndex.colField) = pDirty
            m_IsDirty(FieldIndex.colTitle) = pDirty
            m_IsDirty(FieldIndex.colWidth) = pDirty
            m_IsDirty(FieldIndex.colHidden) = pDirty
            m_IsDirty(FieldIndex.colFilterable) = pDirty
            m_IsDirty(FieldIndex.colSortable) = pDirty
            m_IsDirty(FieldIndex.colGroupable) = pDirty
            m_IsDirty(FieldIndex.colLocked) = pDirty
            m_IsDirty(FieldIndex.colLockable) = pDirty
            m_IsDirty(FieldIndex.colInclude) = pDirty
            m_IsDirty(FieldIndex.colFormat) = pDirty
            m_IsDirty(FieldIndex.colMenu) = pDirty
            m_IsDirty(FieldIndex.colTemplate) = pDirty
            m_IsDirty(FieldIndex.colEditable) = pDirty
            m_IsDirty(FieldIndex.colEditor) = pDirty
            m_IsDirty(FieldIndex.colNullable) = pDirty
            m_IsDirty(FieldIndex.colFooterTemplate) = pDirty
            m_IsDirty(FieldIndex.colHeaderAttributes) = pDirty
            m_IsDirty(FieldIndex.colIndexOrder) = pDirty
            m_IsDirty(FieldIndex.colSrcField) = pDirty
            m_IsDirty(FieldIndex.colSrcTable) = pDirty
            m_IsDirty(FieldIndex.colKeyField) = pDirty
            m_IsDirty(FieldIndex.colFldFieldNameBackColor) = pDirty
            m_IsDirty(FieldIndex.colFldCustomFeature) = pDirty
            m_IsDirty(FieldIndex.colFldExcludeFromExtract) = pDirty
            m_IsDirty(FieldIndex.colFldMapTitleHtmlSnippet) = pDirty
            m_IsDirty(FieldIndex.colFldMapPinIconSqlSnippet) = pDirty
            m_IsDirty(FieldIndex.colFldMapDefaultDepicted) = pDirty
            m_IsDirty(FieldIndex.colFldMapIsDepictable) = pDirty
            m_IsDirty(FieldIndex.colFldMapIsPicklistable) = pDirty
            m_IsDirty(FieldIndex.colFldColumnDescription) = pDirty
            m_IsDirty(FieldIndex.colFldExtractWrapText) = pDirty
        End Sub

		 ''' <summary>
        ''' Returns the type (TblMetaGridColumn) that is able to save, update or delete using this row object.
        ''' </summary>
        ''' <returns>Returns the TblpmactivitiesCfc Type</returns>
        ''' <remarks></remarks>
		Public Shared Function GetTableType() As Type
			Dim zObj As New TblMetaGridColumn
            Return zObj.GetType
		End Function

        Public Enum FieldIndex
            colFldId  = 1
            colFldMetaGridId 
            colFldNotes 
            colType 
            colEncoded 
            colField 
            colTitle 
            colWidth 
            colHidden 
            colFilterable 
            colSortable 
            colGroupable 
            colLocked 
            colLockable 
            colInclude 
            colFormat 
            colMenu 
            colTemplate 
            colEditable 
            colEditor 
            colNullable 
            colFooterTemplate 
            colHeaderAttributes 
            colIndexOrder 
            colSrcField 
            colSrcTable 
            colKeyField 
            colFldFieldNameBackColor 
            colFldCustomFeature 
            colFldExcludeFromExtract 
            colFldMapTitleHtmlSnippet 
            colFldMapPinIconSqlSnippet 
            colFldMapDefaultDepicted 
            colFldMapIsDepictable 
            colFldMapIsPicklistable 
            colFldColumnDescription 
            colFldExtractWrapText 
        End Enum

        Private m_IsDirty(37) As Boolean

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

    Public Interface IrowTblMetaGridColumn
        Event Loaded(pUserState As Object)
        Event Saved(pUserState As Object)
		Event Deleted(pUserState As Object)

        Property colFldId() As Nullable(Of Integer)
        Property colFldMetaGridId() As Nullable(Of Integer)
        Property colFldNotes() As String
        Property colType() As Nullable(Of Integer)
        Property colEncoded() As Nullable(Of Boolean)
        Property colField() As String
        Property colTitle() As String
        Property colWidth() As Nullable(Of Integer)
        Property colHidden() As Nullable(Of Boolean)
        Property colFilterable() As Nullable(Of Boolean)
        Property colSortable() As Nullable(Of Boolean)
        Property colGroupable() As Nullable(Of Boolean)
        Property colLocked() As Nullable(Of Boolean)
        Property colLockable() As Nullable(Of Boolean)
        Property colInclude() As Nullable(Of Boolean)
        Property colFormat() As String
        Property colMenu() As Nullable(Of Boolean)
        Property colTemplate() As String
        Property colEditable() As Nullable(Of Boolean)
        Property colEditor() As String
        Property colNullable() As Nullable(Of Boolean)
        Property colFooterTemplate() As String
        Property colHeaderAttributes() As Nullable(Of Integer)
        Property colIndexOrder() As Nullable(Of Integer)
        Property colSrcField() As String
        Property colSrcTable() As String
        Property colKeyField() As String
        Property colFldFieldNameBackColor() As String
        Property colFldCustomFeature() As String
        Property colFldExcludeFromExtract() As Nullable(Of Boolean)
        Property colFldMapTitleHtmlSnippet() As String
        Property colFldMapPinIconSqlSnippet() As String
        Property colFldMapDefaultDepicted() As Nullable(Of Boolean)
        Property colFldMapIsDepictable() As Nullable(Of Boolean)
        Property colFldMapIsPicklistable() As Nullable(Of Boolean)
        Property colFldColumnDescription() As String
        Property colFldExtractWrapText() As Nullable(Of Boolean)
        Function IsDirty(pIndex As rowTblMetaGridColumn.FieldIndex) As Boolean
        Function IsDirty() As Boolean
		Sub RaiseLoadedEvent(pUserState As Object)
		Sub RaiseSavedEvent(pUserState As Object)
		Sub RaiseDeletedEvent(pUserState As Object)
        Sub SetIsDirty(pDirty As Boolean)
    End Interface

End Namespace

