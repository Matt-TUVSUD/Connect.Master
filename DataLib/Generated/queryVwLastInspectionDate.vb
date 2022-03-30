'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwLastInspectionDate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.StringDataColumn
        Public colMetaPracticeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colLastInspectionDate As New razor.UtilSQLServer.DateTimeDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colMetaPracticeId.ColumnName = "[MetaPracticeId]"
            colFileNo.ColumnName = "[FileNo]"
            colLastInspectionDate.ColumnName = "[LastInspectionDate]"

            _Members.Add("colId", colId)
            _Members.Add("colMetaPracticeId", colMetaPracticeId)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colLastInspectionDate", colLastInspectionDate)
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
                Case "colMetaPracticeId"
                    Return "[MetaPracticeId]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colLastInspectionDate"
                    Return "[LastInspectionDate]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ID]", "ID", "Id", "colId"  
                    Return "colId"
                Case "[MetaPracticeId]", "MetaPracticeId", "MetaPracticeId", "colMetaPracticeId"  
                    Return "colMetaPracticeId"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[LastInspectionDate]", "LastInspectionDate", "LastInspectionDate", "colLastInspectionDate"  
                    Return "colLastInspectionDate"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "String"
                Case "colMetaPracticeId"
                    Return "Integer"
                Case "colFileNo"
                    Return "String"
                Case "colLastInspectionDate"
                    Return "DateTime"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[sv].[vwLastInspectionDate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

