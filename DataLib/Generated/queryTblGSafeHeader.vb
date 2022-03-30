

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblGSafeHeader
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colGSafeGUID As New razor.UtilSQLServer.StringDataColumn
        Public colCreated As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastAccessed As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastUpdated As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLoginName As New razor.UtilSQLServer.StringDataColumn
        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colGSafeId.ColumnName = "[GSafeId]"
            colGSafeGUID.ColumnName = "[GSafeGUID]"
            colCreated.ColumnName = "[Created]"
            colLastAccessed.ColumnName = "[LastAccessed]"
            colLastUpdated.ColumnName = "[LastUpdated]"
            colLoginName.ColumnName = "[LoginName]"
            colLoginID.ColumnName = "[LoginID]"

            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colGSafeGUID", colGSafeGUID)
            _Members.Add("colCreated", colCreated)
            _Members.Add("colLastAccessed", colLastAccessed)
            _Members.Add("colLastUpdated", colLastUpdated)
            _Members.Add("colLoginName", colLoginName)
            _Members.Add("colLoginID", colLoginID)
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
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colGSafeGUID"
                    Return "[GSafeGUID]"
                Case "colCreated"
                    Return "[Created]"
                Case "colLastAccessed"
                    Return "[LastAccessed]"
                Case "colLastUpdated"
                    Return "[LastUpdated]"
                Case "colLoginName"
                    Return "[LoginName]"
                Case "colLoginID"
                    Return "[LoginID]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[GSafeGUID]", "GSafeGUID", "GSafeGUID", "colGSafeGUID"  
                    Return "colGSafeGUID"
                Case "[Created]", "Created", "Created", "colCreated"  
                    Return "colCreated"
                Case "[LastAccessed]", "LastAccessed", "LastAccessed", "colLastAccessed"  
                    Return "colLastAccessed"
                Case "[LastUpdated]", "LastUpdated", "LastUpdated", "colLastUpdated"  
                    Return "colLastUpdated"
                Case "[LoginName]", "LoginName", "LoginName", "colLoginName"  
                    Return "colLoginName"
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colGSafeId"
                    Return "Integer"
                Case "colGSafeGUID"
                    Return "String"
                Case "colCreated"
                    Return "DateTime"
                Case "colLastAccessed"
                    Return "DateTime"
                Case "colLastUpdated"
                    Return "DateTime"
                Case "colLoginName"
                    Return "String"
                Case "colLoginID"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[GSafeHeader]"
        End Function

        Private Function _FirstColumn() As String
            Return "[GSafeId]"
        End Function

    End Class
End namespace

