'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblAdminQueue
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTo As New razor.UtilSQLServer.StringDataColumn
        Public colFldViewIDs As New razor.UtilSQLServer.StringDataColumn
        Public colFldDBAFilter As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateBy As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldIsProcessed As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldStatus As New razor.UtilSQLServer.StringDataColumn
        Public colFldProcessedDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldException As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldTo.ColumnName = "[fldTo]"
            colFldViewIDs.ColumnName = "[fldViewIDs]"
            colFldDBAFilter.ColumnName = "[fldDBAFilter]"
            colFldCreateBy.ColumnName = "[fldCreateBy]"
            colFldCreateDate.ColumnName = "[fldCreateDate]"
            colFldIsProcessed.ColumnName = "[fldIsProcessed]"
            colFldStatus.ColumnName = "[fldStatus]"
            colFldProcessedDate.ColumnName = "[fldProcessedDate]"
            colFldException.ColumnName = "[fldException]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldTo", colFldTo)
            _Members.Add("colFldViewIDs", colFldViewIDs)
            _Members.Add("colFldDBAFilter", colFldDBAFilter)
            _Members.Add("colFldCreateBy", colFldCreateBy)
            _Members.Add("colFldCreateDate", colFldCreateDate)
            _Members.Add("colFldIsProcessed", colFldIsProcessed)
            _Members.Add("colFldStatus", colFldStatus)
            _Members.Add("colFldProcessedDate", colFldProcessedDate)
            _Members.Add("colFldException", colFldException)
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
                Case "colFldTo"
                    Return "[fldTo]"
                Case "colFldViewIDs"
                    Return "[fldViewIDs]"
                Case "colFldDBAFilter"
                    Return "[fldDBAFilter]"
                Case "colFldCreateBy"
                    Return "[fldCreateBy]"
                Case "colFldCreateDate"
                    Return "[fldCreateDate]"
                Case "colFldIsProcessed"
                    Return "[fldIsProcessed]"
                Case "colFldStatus"
                    Return "[fldStatus]"
                Case "colFldProcessedDate"
                    Return "[fldProcessedDate]"
                Case "colFldException"
                    Return "[fldException]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
                Case "[fldTo]", "fldTo", "FldTo", "colFldTo"  
                    Return "colFldTo"
                Case "[fldViewIDs]", "fldViewIDs", "FldViewIDs", "colFldViewIDs"  
                    Return "colFldViewIDs"
                Case "[fldDBAFilter]", "fldDBAFilter", "FldDBAFilter", "colFldDBAFilter"  
                    Return "colFldDBAFilter"
                Case "[fldCreateBy]", "fldCreateBy", "FldCreateBy", "colFldCreateBy"  
                    Return "colFldCreateBy"
                Case "[fldCreateDate]", "fldCreateDate", "FldCreateDate", "colFldCreateDate"  
                    Return "colFldCreateDate"
                Case "[fldIsProcessed]", "fldIsProcessed", "FldIsProcessed", "colFldIsProcessed"  
                    Return "colFldIsProcessed"
                Case "[fldStatus]", "fldStatus", "FldStatus", "colFldStatus"  
                    Return "colFldStatus"
                Case "[fldProcessedDate]", "fldProcessedDate", "FldProcessedDate", "colFldProcessedDate"  
                    Return "colFldProcessedDate"
                Case "[fldException]", "fldException", "FldException", "colFldException"  
                    Return "colFldException"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
                Case "colFldTo"
                    Return "String"
                Case "colFldViewIDs"
                    Return "String"
                Case "colFldDBAFilter"
                    Return "String"
                Case "colFldCreateBy"
                    Return "String"
                Case "colFldCreateDate"
                    Return "DateTime"
                Case "colFldIsProcessed"
                    Return "Boolean"
                Case "colFldStatus"
                    Return "String"
                Case "colFldProcessedDate"
                    Return "DateTime"
                Case "colFldException"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[adm].[tblAdminQueue]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

