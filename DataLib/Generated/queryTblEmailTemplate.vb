'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEmailTemplate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTypeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSubject As New razor.UtilSQLServer.StringDataColumn
        Public colFldBody As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldTypeId.ColumnName = "[fldTypeId]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldSubject.ColumnName = "[fldSubject]"
            colFldBody.ColumnName = "[fldBody]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldTypeId", colFldTypeId)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldSubject", colFldSubject)
            _Members.Add("colFldBody", colFldBody)
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
                Case "colFldTypeId"
                    Return "[fldTypeId]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldSubject"
                    Return "[fldSubject]"
                Case "colFldBody"
                    Return "[fldBody]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldTypeId]", "fldTypeId", "FldTypeId", "colFldTypeId"  
                    Return "colFldTypeId"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldSubject]", "fldSubject", "FldSubject", "colFldSubject"  
                    Return "colFldSubject"
                Case "[fldBody]", "fldBody", "FldBody", "colFldBody"  
                    Return "colFldBody"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldTypeId"
                    Return "Integer"
                Case "colFldFilePrefix"
                    Return "Integer"
                Case "colFldSubject"
                    Return "String"
                Case "colFldBody"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblEmailTemplate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

