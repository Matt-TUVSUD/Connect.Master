'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEzyUserstracking
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colEzyUserID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.IntegerDataColumn
        Public colDocLibLastReviewedDate As New razor.UtilSQLServer.DateDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colEzyUserID.ColumnName = "[EzyUserID]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colDocLibLastReviewedDate.ColumnName = "[DocLibLastReviewedDate]"

            _Members.Add("colId", colId)
            _Members.Add("colEzyUserID", colEzyUserID)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colDocLibLastReviewedDate", colDocLibLastReviewedDate)
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
                    Return "[ID]"
                Case "colEzyUserID"
                    Return "[EzyUserID]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colDocLibLastReviewedDate"
                    Return "[DocLibLastReviewedDate]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ID]", "ID", "Id", "colId"  
                    Return "colId"
                Case "[EzyUserID]", "EzyUserID", "EzyUserID", "colEzyUserID"  
                    Return "colEzyUserID"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[DocLibLastReviewedDate]", "DocLibLastReviewedDate", "DocLibLastReviewedDate", "colDocLibLastReviewedDate"  
                    Return "colDocLibLastReviewedDate"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colEzyUserID"
                    Return "Integer"
                Case "colFilePrefix"
                    Return "Integer"
                Case "colDocLibLastReviewedDate"
                    Return "Date"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[ezy_UsersTracking]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

