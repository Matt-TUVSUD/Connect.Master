'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblGSafeUserReclass
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colGsafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colUserIndex As New razor.UtilSQLServer.IntegerDataColumn
        Public colEzyUserGuid As New razor.UtilSQLServer.StringDataColumn
        Public colIsReviewed As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[Id]"
            colGsafeId.ColumnName = "[GsafeId]"
            colUserIndex.ColumnName = "[UserIndex]"
            colEzyUserGuid.ColumnName = "[EzyUserGuid]"
            colIsReviewed.ColumnName = "[IsReviewed]"

            _Members.Add("colId", colId)
            _Members.Add("colGsafeId", colGsafeId)
            _Members.Add("colUserIndex", colUserIndex)
            _Members.Add("colEzyUserGuid", colEzyUserGuid)
            _Members.Add("colIsReviewed", colIsReviewed)
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
                Case "colId"
                    Return "[Id]"
                Case "colGsafeId"
                    Return "[GsafeId]"
                Case "colUserIndex"
                    Return "[UserIndex]"
                Case "colEzyUserGuid"
                    Return "[EzyUserGuid]"
                Case "colIsReviewed"
                    Return "[IsReviewed]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[Id]", "Id", "Id", "colId"  
                    Return "colId"
                Case "[GsafeId]", "GsafeId", "GsafeId", "colGsafeId"  
                    Return "colGsafeId"
                Case "[UserIndex]", "UserIndex", "UserIndex", "colUserIndex"  
                    Return "colUserIndex"
                Case "[EzyUserGuid]", "EzyUserGuid", "EzyUserGuid", "colEzyUserGuid"  
                    Return "colEzyUserGuid"
                Case "[IsReviewed]", "IsReviewed", "IsReviewed", "colIsReviewed"  
                    Return "colIsReviewed"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colGsafeId"
                    Return "Integer"
                Case "colUserIndex"
                    Return "Integer"
                Case "colEzyUserGuid"
                    Return "String"
                Case "colIsReviewed"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[GSafeUserReclass]"
        End Function

        Private Function _FirstColumn() As String
            Return "[Id]"
        End Function

    End Class
End namespace

