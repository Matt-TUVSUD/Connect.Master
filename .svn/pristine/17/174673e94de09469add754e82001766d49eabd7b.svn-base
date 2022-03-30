'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblWhatIfKey
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldGSafeID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldKey As New razor.UtilSQLServer.StringDataColumn
        Public colFldValue As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldGSafeID.ColumnName = "[fldGSafeID]"
            colFldKey.ColumnName = "[fldKey]"
            colFldValue.ColumnName = "[fldValue]"

            _Members.Add("colFldGSafeID", colFldGSafeID)
            _Members.Add("colFldKey", colFldKey)
            _Members.Add("colFldValue", colFldValue)
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
                Case "colFldKey"
                    Return "[fldKey]"
                Case "colFldValue"
                    Return "[fldValue]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldGSafeID]", "fldGSafeID", "FldGSafeID", "colFldGSafeID"  
                    Return "colFldGSafeID"
                Case "[fldKey]", "fldKey", "FldKey", "colFldKey"  
                    Return "colFldKey"
                Case "[fldValue]", "fldValue", "FldValue", "colFldValue"  
                    Return "colFldValue"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldGSafeID"
                    Return "Integer"
                Case "colFldKey"
                    Return "String"
                Case "colFldValue"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[TblWhatIfKey]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldGSafeID]"
        End Function

    End Class
End namespace

