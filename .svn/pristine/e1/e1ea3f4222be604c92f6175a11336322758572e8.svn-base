'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblSystemAppEntry
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldGuid As New razor.UtilSQLServer.StringDataColumn
        Public colFldUserName As New razor.UtilSQLServer.StringDataColumn
        Public colFldUserEmail As New razor.UtilSQLServer.StringDataColumn
        Public colFldEntrySource As New razor.UtilSQLServer.StringDataColumn
        Public colFldEntryDateTime As New razor.UtilSQLServer.StringDataColumn
        Public colFldForeignKeyID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldForeignTableName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldGuid.ColumnName = "[fldGuid]"
            colFldUserName.ColumnName = "[fldUserName]"
            colFldUserEmail.ColumnName = "[fldUserEmail]"
            colFldEntrySource.ColumnName = "[fldEntrySource]"
            colFldEntryDateTime.ColumnName = "[fldEntryDateTime]"
            colFldForeignKeyID.ColumnName = "[fldForeignKeyID]"
            colFldForeignTableName.ColumnName = "[fldForeignTableName]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldGuid", colFldGuid)
            _Members.Add("colFldUserName", colFldUserName)
            _Members.Add("colFldUserEmail", colFldUserEmail)
            _Members.Add("colFldEntrySource", colFldEntrySource)
            _Members.Add("colFldEntryDateTime", colFldEntryDateTime)
            _Members.Add("colFldForeignKeyID", colFldForeignKeyID)
            _Members.Add("colFldForeignTableName", colFldForeignTableName)
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
                Case "colFldID"
                    Return "[fldID]"
                Case "colFldGuid"
                    Return "[fldGuid]"
                Case "colFldUserName"
                    Return "[fldUserName]"
                Case "colFldUserEmail"
                    Return "[fldUserEmail]"
                Case "colFldEntrySource"
                    Return "[fldEntrySource]"
                Case "colFldEntryDateTime"
                    Return "[fldEntryDateTime]"
                Case "colFldForeignKeyID"
                    Return "[fldForeignKeyID]"
                Case "colFldForeignTableName"
                    Return "[fldForeignTableName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
                Case "[fldGuid]", "fldGuid", "FldGuid", "colFldGuid"  
                    Return "colFldGuid"
                Case "[fldUserName]", "fldUserName", "FldUserName", "colFldUserName"  
                    Return "colFldUserName"
                Case "[fldUserEmail]", "fldUserEmail", "FldUserEmail", "colFldUserEmail"  
                    Return "colFldUserEmail"
                Case "[fldEntrySource]", "fldEntrySource", "FldEntrySource", "colFldEntrySource"  
                    Return "colFldEntrySource"
                Case "[fldEntryDateTime]", "fldEntryDateTime", "FldEntryDateTime", "colFldEntryDateTime"  
                    Return "colFldEntryDateTime"
                Case "[fldForeignKeyID]", "fldForeignKeyID", "FldForeignKeyID", "colFldForeignKeyID"  
                    Return "colFldForeignKeyID"
                Case "[fldForeignTableName]", "fldForeignTableName", "FldForeignTableName", "colFldForeignTableName"  
                    Return "colFldForeignTableName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
                Case "colFldGuid"
                    Return "String"
                Case "colFldUserName"
                    Return "String"
                Case "colFldUserEmail"
                    Return "String"
                Case "colFldEntrySource"
                    Return "String"
                Case "colFldEntryDateTime"
                    Return "String"
                Case "colFldForeignKeyID"
                    Return "Integer"
                Case "colFldForeignTableName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblSystemAppEntry]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

