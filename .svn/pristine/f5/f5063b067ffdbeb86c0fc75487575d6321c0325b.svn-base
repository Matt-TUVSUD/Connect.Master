'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwRRLogFollowUpRecStatusDate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colStatusDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colPracticeCode As New razor.UtilSQLServer.ShortDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFileNo.ColumnName = "[FileNo]"
            colStatusDate.ColumnName = "[StatusDate]"
            colPracticeCode.ColumnName = "[PracticeCode]"

            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colStatusDate", colStatusDate)
            _Members.Add("colPracticeCode", colPracticeCode)
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
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colStatusDate"
                    Return "[StatusDate]"
                Case "colPracticeCode"
                    Return "[PracticeCode]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[StatusDate]", "StatusDate", "StatusDate", "colStatusDate"  
                    Return "colStatusDate"
                Case "[PracticeCode]", "PracticeCode", "PracticeCode", "colPracticeCode"  
                    Return "colPracticeCode"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFileNo"
                    Return "String"
                Case "colStatusDate"
                    Return "DateTime"
                Case "colPracticeCode"
                    Return "Short"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwRRLogFollowUpRecStatusDate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FileNo]"
        End Function

    End Class
End namespace

