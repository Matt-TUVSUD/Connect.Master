'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwRRLogFollowUp
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colRowNO As New razor.UtilSQLServer.LongDataColumn
        Public colId As New razor.UtilSQLServer.StringDataColumn
        Public colFollowUpStatus As New razor.UtilSQLServer.StringDataColumn
        Public colRRLogId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFollowUp As New razor.UtilSQLServer.IntegerDataColumn
        Public colPracticeCode As New razor.UtilSQLServer.ShortDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colDateStamp As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRecsNeedingResponses As New razor.UtilSQLServer.IntegerDataColumn
        Public colPracticeGroup As New razor.UtilSQLServer.StringDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colPracticeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colRFU1Date As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRFU2Date As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRFU3Date As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLastInspectionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colDaysSinceDateStamp As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colRowNO.ColumnName = "[RowNO]"
            colId.ColumnName = "[Id]"
            colFollowUpStatus.ColumnName = "[FollowUpStatus]"
            colRRLogId.ColumnName = "[RRLogId]"
            colFollowUp.ColumnName = "[FollowUp]"
            colPracticeCode.ColumnName = "[PracticeCode]"
            colFileNo.ColumnName = "[FileNo]"
            colDateStamp.ColumnName = "[DateStamp]"
            colRecsNeedingResponses.ColumnName = "[RecsNeedingResponses]"
            colPracticeGroup.ColumnName = "[PracticeGroup]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colPracticeId.ColumnName = "[PracticeId]"
            colRFU1Date.ColumnName = "[RFU1Date]"
            colRFU2Date.ColumnName = "[RFU2Date]"
            colRFU3Date.ColumnName = "[RFU3Date]"
            colLastInspectionDate.ColumnName = "[LastInspectionDate]"
            colDaysSinceDateStamp.ColumnName = "[DaysSinceDateStamp]"

            _Members.Add("colRowNO", colRowNO)
            _Members.Add("colId", colId)
            _Members.Add("colFollowUpStatus", colFollowUpStatus)
            _Members.Add("colRRLogId", colRRLogId)
            _Members.Add("colFollowUp", colFollowUp)
            _Members.Add("colPracticeCode", colPracticeCode)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colDateStamp", colDateStamp)
            _Members.Add("colRecsNeedingResponses", colRecsNeedingResponses)
            _Members.Add("colPracticeGroup", colPracticeGroup)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colPracticeId", colPracticeId)
            _Members.Add("colRFU1Date", colRFU1Date)
            _Members.Add("colRFU2Date", colRFU2Date)
            _Members.Add("colRFU3Date", colRFU3Date)
            _Members.Add("colLastInspectionDate", colLastInspectionDate)
            _Members.Add("colDaysSinceDateStamp", colDaysSinceDateStamp)
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
                Case "colRowNO"
                    Return "[RowNO]"
                Case "colId"
                    Return "[Id]"
                Case "colFollowUpStatus"
                    Return "[FollowUpStatus]"
                Case "colRRLogId"
                    Return "[RRLogId]"
                Case "colFollowUp"
                    Return "[FollowUp]"
                Case "colPracticeCode"
                    Return "[PracticeCode]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colDateStamp"
                    Return "[DateStamp]"
                Case "colRecsNeedingResponses"
                    Return "[RecsNeedingResponses]"
                Case "colPracticeGroup"
                    Return "[PracticeGroup]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colPracticeId"
                    Return "[PracticeId]"
                Case "colRFU1Date"
                    Return "[RFU1Date]"
                Case "colRFU2Date"
                    Return "[RFU2Date]"
                Case "colRFU3Date"
                    Return "[RFU3Date]"
                Case "colLastInspectionDate"
                    Return "[LastInspectionDate]"
                Case "colDaysSinceDateStamp"
                    Return "[DaysSinceDateStamp]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[RowNO]", "RowNO", "RowNO", "colRowNO"  
                    Return "colRowNO"
                Case "[Id]", "Id", "Id", "colId"  
                    Return "colId"
                Case "[FollowUpStatus]", "FollowUpStatus", "FollowUpStatus", "colFollowUpStatus"  
                    Return "colFollowUpStatus"
                Case "[RRLogId]", "RRLogId", "RRLogId", "colRRLogId"  
                    Return "colRRLogId"
                Case "[FollowUp]", "FollowUp", "FollowUp", "colFollowUp"  
                    Return "colFollowUp"
                Case "[PracticeCode]", "PracticeCode", "PracticeCode", "colPracticeCode"  
                    Return "colPracticeCode"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[DateStamp]", "DateStamp", "DateStamp", "colDateStamp"  
                    Return "colDateStamp"
                Case "[RecsNeedingResponses]", "RecsNeedingResponses", "RecsNeedingResponses", "colRecsNeedingResponses"  
                    Return "colRecsNeedingResponses"
                Case "[PracticeGroup]", "PracticeGroup", "PracticeGroup", "colPracticeGroup"  
                    Return "colPracticeGroup"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[PracticeId]", "PracticeId", "PracticeId", "colPracticeId"  
                    Return "colPracticeId"
                Case "[RFU1Date]", "RFU1Date", "RFU1Date", "colRFU1Date"  
                    Return "colRFU1Date"
                Case "[RFU2Date]", "RFU2Date", "RFU2Date", "colRFU2Date"  
                    Return "colRFU2Date"
                Case "[RFU3Date]", "RFU3Date", "RFU3Date", "colRFU3Date"  
                    Return "colRFU3Date"
                Case "[LastInspectionDate]", "LastInspectionDate", "LastInspectionDate", "colLastInspectionDate"  
                    Return "colLastInspectionDate"
                Case "[DaysSinceDateStamp]", "DaysSinceDateStamp", "DaysSinceDateStamp", "colDaysSinceDateStamp"  
                    Return "colDaysSinceDateStamp"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colRowNO"
                    Return "Long"
                Case "colId"
                    Return "String"
                Case "colFollowUpStatus"
                    Return "String"
                Case "colRRLogId"
                    Return "Integer"
                Case "colFollowUp"
                    Return "Integer"
                Case "colPracticeCode"
                    Return "Short"
                Case "colFileNo"
                    Return "String"
                Case "colDateStamp"
                    Return "DateTime"
                Case "colRecsNeedingResponses"
                    Return "Integer"
                Case "colPracticeGroup"
                    Return "String"
                Case "colFilePrefix"
                    Return "String"
                Case "colPracticeId"
                    Return "Integer"
                Case "colRFU1Date"
                    Return "DateTime"
                Case "colRFU2Date"
                    Return "DateTime"
                Case "colRFU3Date"
                    Return "DateTime"
                Case "colLastInspectionDate"
                    Return "DateTime"
                Case "colDaysSinceDateStamp"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwRRLogFollowUp]"
        End Function

        Private Function _FirstColumn() As String
            Return "[RowNO]"
        End Function

    End Class
End namespace

