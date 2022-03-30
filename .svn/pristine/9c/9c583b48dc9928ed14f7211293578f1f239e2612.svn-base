'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwDataTransferMetaGrid
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldGridId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldFileName As New razor.UtilSQLServer.StringDataColumn
        Public colFldSourceId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSchemaName As New razor.UtilSQLServer.StringDataColumn
        Public colFldObjectName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldGridId.ColumnName = "[fldGridId]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldFileName.ColumnName = "[fldFileName]"
            colFldSourceId.ColumnName = "[fldSourceId]"
            colFldSchemaName.ColumnName = "[fldSchemaName]"
            colFldObjectName.ColumnName = "[fldObjectName]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldGridId", colFldGridId)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldFileName", colFldFileName)
            _Members.Add("colFldSourceId", colFldSourceId)
            _Members.Add("colFldSchemaName", colFldSchemaName)
            _Members.Add("colFldObjectName", colFldObjectName)
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
                Case "colFldId"
                    Return "[fldId]"
                Case "colFldGridId"
                    Return "[fldGridId]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldFileName"
                    Return "[fldFileName]"
                Case "colFldSourceId"
                    Return "[fldSourceId]"
                Case "colFldSchemaName"
                    Return "[fldSchemaName]"
                Case "colFldObjectName"
                    Return "[fldObjectName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldGridId]", "fldGridId", "FldGridId", "colFldGridId"  
                    Return "colFldGridId"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldFileName]", "fldFileName", "FldFileName", "colFldFileName"  
                    Return "colFldFileName"
                Case "[fldSourceId]", "fldSourceId", "FldSourceId", "colFldSourceId"  
                    Return "colFldSourceId"
                Case "[fldSchemaName]", "fldSchemaName", "FldSchemaName", "colFldSchemaName"  
                    Return "colFldSchemaName"
                Case "[fldObjectName]", "fldObjectName", "FldObjectName", "colFldObjectName"  
                    Return "colFldObjectName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldGridId"
                    Return "Integer"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldFileName"
                    Return "String"
                Case "colFldSourceId"
                    Return "Integer"
                Case "colFldSchemaName"
                    Return "String"
                Case "colFldObjectName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwDataTransferMetaGrid]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

