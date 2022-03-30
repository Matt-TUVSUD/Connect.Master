

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblWhatIfFireRecSelected
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldGSafeID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldRecID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateDateTime As New razor.UtilSQLServer.DateTimeDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldGSafeID.ColumnName = "[fldGSafeID]"
            colFldRecID.ColumnName = "[fldRecID]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldCreateDateTime.ColumnName = "[fldCreateDateTime]"

            _Members.Add("colFldGSafeID", colFldGSafeID)
            _Members.Add("colFldRecID", colFldRecID)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldCreateDateTime", colFldCreateDateTime)
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
                Case "colFldGSafeID"
                    Return "[fldGSafeID]"
                Case "colFldRecID"
                    Return "[fldRecID]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldCreateDateTime"
                    Return "[fldCreateDateTime]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldGSafeID]", "fldGSafeID", "FldGSafeID", "colFldGSafeID"  
                    Return "colFldGSafeID"
                Case "[fldRecID]", "fldRecID", "FldRecID", "colFldRecID"  
                    Return "colFldRecID"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldCreateDateTime]", "fldCreateDateTime", "FldCreateDateTime", "colFldCreateDateTime"  
                    Return "colFldCreateDateTime"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldGSafeID"
                    Return "Integer"
                Case "colFldRecID"
                    Return "Integer"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldCreateDateTime"
                    Return "DateTime"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[TblWhatIfFireRecSelected]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldGSafeID]"
        End Function

    End Class
End namespace

