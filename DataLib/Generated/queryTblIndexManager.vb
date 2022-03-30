'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblIndexManager
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldIndexId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIndexName As New razor.UtilSQLServer.StringDataColumn
        Public colFldStatus As New razor.UtilSQLServer.StringDataColumn
        Public colFldEnabled As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldLastIndexDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldLastContentUpdateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldStartDirectory As New razor.UtilSQLServer.StringDataColumn
        Public colFldSpiderURL As New razor.UtilSQLServer.StringDataColumn
        Public colFldBaseURL As New razor.UtilSQLServer.StringDataColumn
        Public colFldOutputDirectory As New razor.UtilSQLServer.StringDataColumn
        Public colFldTemplateFilename As New razor.UtilSQLServer.StringDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldStartJobTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldEndJobTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldLastPollTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldHasContent As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldTnEInactiveFlag As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIndexMode As New razor.UtilSQLServer.StringDataColumn
        Public colFldLastIndexLapseMin As New razor.UtilSQLServer.SingleDataColumn
        Public colFldIndexGUID As New razor.UtilSQLServer.StringDataColumn
        Public colFldCldbName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldIndexId.ColumnName = "[fldIndexId]"
            colFldIndexName.ColumnName = "[fldIndexName]"
            colFldStatus.ColumnName = "[fldStatus]"
            colFldEnabled.ColumnName = "[fldEnabled]"
            colFldLastIndexDate.ColumnName = "[fldLastIndexDate]"
            colFldLastContentUpdateDate.ColumnName = "[fldLastContentUpdateDate]"
            colFldStartDirectory.ColumnName = "[fldStartDirectory]"
            colFldSpiderURL.ColumnName = "[fldSpiderURL]"
            colFldBaseURL.ColumnName = "[fldBaseURL]"
            colFldOutputDirectory.ColumnName = "[fldOutputDirectory]"
            colFldTemplateFilename.ColumnName = "[fldTemplateFilename]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldStartJobTime.ColumnName = "[fldStartJobTime]"
            colFldEndJobTime.ColumnName = "[fldEndJobTime]"
            colFldLastPollTime.ColumnName = "[fldLastPollTime]"
            colFldHasContent.ColumnName = "[fldHasContent]"
            colFldTnEInactiveFlag.ColumnName = "[fldTnEInactiveFlag]"
            colFldIndexMode.ColumnName = "[fldIndexMode]"
            colFldLastIndexLapseMin.ColumnName = "[fldLastIndexLapseMin]"
            colFldIndexGUID.ColumnName = "[fldIndexGUID]"
            colFldCldbName.ColumnName = "[fldCldbName]"

            _Members.Add("colFldIndexId", colFldIndexId)
            _Members.Add("colFldIndexName", colFldIndexName)
            _Members.Add("colFldStatus", colFldStatus)
            _Members.Add("colFldEnabled", colFldEnabled)
            _Members.Add("colFldLastIndexDate", colFldLastIndexDate)
            _Members.Add("colFldLastContentUpdateDate", colFldLastContentUpdateDate)
            _Members.Add("colFldStartDirectory", colFldStartDirectory)
            _Members.Add("colFldSpiderURL", colFldSpiderURL)
            _Members.Add("colFldBaseURL", colFldBaseURL)
            _Members.Add("colFldOutputDirectory", colFldOutputDirectory)
            _Members.Add("colFldTemplateFilename", colFldTemplateFilename)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldStartJobTime", colFldStartJobTime)
            _Members.Add("colFldEndJobTime", colFldEndJobTime)
            _Members.Add("colFldLastPollTime", colFldLastPollTime)
            _Members.Add("colFldHasContent", colFldHasContent)
            _Members.Add("colFldTnEInactiveFlag", colFldTnEInactiveFlag)
            _Members.Add("colFldIndexMode", colFldIndexMode)
            _Members.Add("colFldLastIndexLapseMin", colFldLastIndexLapseMin)
            _Members.Add("colFldIndexGUID", colFldIndexGUID)
            _Members.Add("colFldCldbName", colFldCldbName)
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
                Case "colFldIndexId"
                    Return "[fldIndexId]"
                Case "colFldIndexName"
                    Return "[fldIndexName]"
                Case "colFldStatus"
                    Return "[fldStatus]"
                Case "colFldEnabled"
                    Return "[fldEnabled]"
                Case "colFldLastIndexDate"
                    Return "[fldLastIndexDate]"
                Case "colFldLastContentUpdateDate"
                    Return "[fldLastContentUpdateDate]"
                Case "colFldStartDirectory"
                    Return "[fldStartDirectory]"
                Case "colFldSpiderURL"
                    Return "[fldSpiderURL]"
                Case "colFldBaseURL"
                    Return "[fldBaseURL]"
                Case "colFldOutputDirectory"
                    Return "[fldOutputDirectory]"
                Case "colFldTemplateFilename"
                    Return "[fldTemplateFilename]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldStartJobTime"
                    Return "[fldStartJobTime]"
                Case "colFldEndJobTime"
                    Return "[fldEndJobTime]"
                Case "colFldLastPollTime"
                    Return "[fldLastPollTime]"
                Case "colFldHasContent"
                    Return "[fldHasContent]"
                Case "colFldTnEInactiveFlag"
                    Return "[fldTnEInactiveFlag]"
                Case "colFldIndexMode"
                    Return "[fldIndexMode]"
                Case "colFldLastIndexLapseMin"
                    Return "[fldLastIndexLapseMin]"
                Case "colFldIndexGUID"
                    Return "[fldIndexGUID]"
                Case "colFldCldbName"
                    Return "[fldCldbName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldIndexId]", "fldIndexId", "FldIndexId", "colFldIndexId"  
                    Return "colFldIndexId"
                Case "[fldIndexName]", "fldIndexName", "FldIndexName", "colFldIndexName"  
                    Return "colFldIndexName"
                Case "[fldStatus]", "fldStatus", "FldStatus", "colFldStatus"  
                    Return "colFldStatus"
                Case "[fldEnabled]", "fldEnabled", "FldEnabled", "colFldEnabled"  
                    Return "colFldEnabled"
                Case "[fldLastIndexDate]", "fldLastIndexDate", "FldLastIndexDate", "colFldLastIndexDate"  
                    Return "colFldLastIndexDate"
                Case "[fldLastContentUpdateDate]", "fldLastContentUpdateDate", "FldLastContentUpdateDate", "colFldLastContentUpdateDate"  
                    Return "colFldLastContentUpdateDate"
                Case "[fldStartDirectory]", "fldStartDirectory", "FldStartDirectory", "colFldStartDirectory"  
                    Return "colFldStartDirectory"
                Case "[fldSpiderURL]", "fldSpiderURL", "FldSpiderURL", "colFldSpiderURL"  
                    Return "colFldSpiderURL"
                Case "[fldBaseURL]", "fldBaseURL", "FldBaseURL", "colFldBaseURL"  
                    Return "colFldBaseURL"
                Case "[fldOutputDirectory]", "fldOutputDirectory", "FldOutputDirectory", "colFldOutputDirectory"  
                    Return "colFldOutputDirectory"
                Case "[fldTemplateFilename]", "fldTemplateFilename", "FldTemplateFilename", "colFldTemplateFilename"  
                    Return "colFldTemplateFilename"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldStartJobTime]", "fldStartJobTime", "FldStartJobTime", "colFldStartJobTime"  
                    Return "colFldStartJobTime"
                Case "[fldEndJobTime]", "fldEndJobTime", "FldEndJobTime", "colFldEndJobTime"  
                    Return "colFldEndJobTime"
                Case "[fldLastPollTime]", "fldLastPollTime", "FldLastPollTime", "colFldLastPollTime"  
                    Return "colFldLastPollTime"
                Case "[fldHasContent]", "fldHasContent", "FldHasContent", "colFldHasContent"  
                    Return "colFldHasContent"
                Case "[fldTnEInactiveFlag]", "fldTnEInactiveFlag", "FldTnEInactiveFlag", "colFldTnEInactiveFlag"  
                    Return "colFldTnEInactiveFlag"
                Case "[fldIndexMode]", "fldIndexMode", "FldIndexMode", "colFldIndexMode"  
                    Return "colFldIndexMode"
                Case "[fldLastIndexLapseMin]", "fldLastIndexLapseMin", "FldLastIndexLapseMin", "colFldLastIndexLapseMin"  
                    Return "colFldLastIndexLapseMin"
                Case "[fldIndexGUID]", "fldIndexGUID", "FldIndexGUID", "colFldIndexGUID"  
                    Return "colFldIndexGUID"
                Case "[fldCldbName]", "fldCldbName", "FldCldbName", "colFldCldbName"  
                    Return "colFldCldbName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldIndexId"
                    Return "Integer"
                Case "colFldIndexName"
                    Return "String"
                Case "colFldStatus"
                    Return "String"
                Case "colFldEnabled"
                    Return "Boolean"
                Case "colFldLastIndexDate"
                    Return "DateTime"
                Case "colFldLastContentUpdateDate"
                    Return "DateTime"
                Case "colFldStartDirectory"
                    Return "String"
                Case "colFldSpiderURL"
                    Return "String"
                Case "colFldBaseURL"
                    Return "String"
                Case "colFldOutputDirectory"
                    Return "String"
                Case "colFldTemplateFilename"
                    Return "String"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldStartJobTime"
                    Return "DateTime"
                Case "colFldEndJobTime"
                    Return "DateTime"
                Case "colFldLastPollTime"
                    Return "DateTime"
                Case "colFldHasContent"
                    Return "Boolean"
                Case "colFldTnEInactiveFlag"
                    Return "Integer"
                Case "colFldIndexMode"
                    Return "String"
                Case "colFldLastIndexLapseMin"
                    Return "Single"
                Case "colFldIndexGUID"
                    Return "String"
                Case "colFldCldbName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblIndexManager]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldIndexId]"
        End Function

    End Class
End namespace

