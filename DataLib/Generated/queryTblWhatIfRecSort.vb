'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblWhatIfRecSort
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldText As New razor.UtilSQLServer.StringDataColumn
        Public colFldToolTip As New razor.UtilSQLServer.StringDataColumn
        Public colFldSortJson As New razor.UtilSQLServer.StringDataColumn
        Public colFldSortOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldVisible As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldText.ColumnName = "[fldText]"
            colFldToolTip.ColumnName = "[fldToolTip]"
            colFldSortJson.ColumnName = "[fldSortJson]"
            colFldSortOrder.ColumnName = "[fldSortOrder]"
            colFldVisible.ColumnName = "[fldVisible]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldText", colFldText)
            _Members.Add("colFldToolTip", colFldToolTip)
            _Members.Add("colFldSortJson", colFldSortJson)
            _Members.Add("colFldSortOrder", colFldSortOrder)
            _Members.Add("colFldVisible", colFldVisible)
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
                Case "colFldText"
                    Return "[fldText]"
                Case "colFldToolTip"
                    Return "[fldToolTip]"
                Case "colFldSortJson"
                    Return "[fldSortJson]"
                Case "colFldSortOrder"
                    Return "[fldSortOrder]"
                Case "colFldVisible"
                    Return "[fldVisible]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
                Case "[fldText]", "fldText", "FldText", "colFldText"  
                    Return "colFldText"
                Case "[fldToolTip]", "fldToolTip", "FldToolTip", "colFldToolTip"  
                    Return "colFldToolTip"
                Case "[fldSortJson]", "fldSortJson", "FldSortJson", "colFldSortJson"  
                    Return "colFldSortJson"
                Case "[fldSortOrder]", "fldSortOrder", "FldSortOrder", "colFldSortOrder"  
                    Return "colFldSortOrder"
                Case "[fldVisible]", "fldVisible", "FldVisible", "colFldVisible"  
                    Return "colFldVisible"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
                Case "colFldText"
                    Return "String"
                Case "colFldToolTip"
                    Return "String"
                Case "colFldSortJson"
                    Return "String"
                Case "colFldSortOrder"
                    Return "Integer"
                Case "colFldVisible"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[TblWhatIfRecSort]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

