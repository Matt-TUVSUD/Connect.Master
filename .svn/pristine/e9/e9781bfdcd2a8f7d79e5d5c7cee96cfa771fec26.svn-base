'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblWhatIfOutputParm
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldGUID As New razor.UtilSQLServer.StringDataColumn
        Public colFldSID As New razor.UtilSQLServer.StringDataColumn
        Public colFldGSafeID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldOutputID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colFldSortJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldFilterJSON As New razor.UtilSQLServer.StringDataColumn
        Public colFldEstBudget As New razor.UtilSQLServer.StringDataColumn
        Public colFldEstCostToComplete As New razor.UtilSQLServer.StringDataColumn
        Public colFldRemainBudget As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldGUID.ColumnName = "[fldGUID]"
            colFldSID.ColumnName = "[fldSID]"
            colFldGSafeID.ColumnName = "[fldGSafeID]"
            colFldOutputID.ColumnName = "[fldOutputID]"
            colFldFileNo.ColumnName = "[fldFileNo]"
            colFldSortJSON.ColumnName = "[fldSortJSON]"
            colFldFilterJSON.ColumnName = "[fldFilterJSON]"
            colFldEstBudget.ColumnName = "[fldEstBudget]"
            colFldEstCostToComplete.ColumnName = "[fldEstCostToComplete]"
            colFldRemainBudget.ColumnName = "[fldRemainBudget]"

            _Members.Add("colFldGUID", colFldGUID)
            _Members.Add("colFldSID", colFldSID)
            _Members.Add("colFldGSafeID", colFldGSafeID)
            _Members.Add("colFldOutputID", colFldOutputID)
            _Members.Add("colFldFileNo", colFldFileNo)
            _Members.Add("colFldSortJSON", colFldSortJSON)
            _Members.Add("colFldFilterJSON", colFldFilterJSON)
            _Members.Add("colFldEstBudget", colFldEstBudget)
            _Members.Add("colFldEstCostToComplete", colFldEstCostToComplete)
            _Members.Add("colFldRemainBudget", colFldRemainBudget)
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
                Case "colFldGUID"
                    Return "[fldGUID]"
                Case "colFldSID"
                    Return "[fldSID]"
                Case "colFldGSafeID"
                    Return "[fldGSafeID]"
                Case "colFldOutputID"
                    Return "[fldOutputID]"
                Case "colFldFileNo"
                    Return "[fldFileNo]"
                Case "colFldSortJSON"
                    Return "[fldSortJSON]"
                Case "colFldFilterJSON"
                    Return "[fldFilterJSON]"
                Case "colFldEstBudget"
                    Return "[fldEstBudget]"
                Case "colFldEstCostToComplete"
                    Return "[fldEstCostToComplete]"
                Case "colFldRemainBudget"
                    Return "[fldRemainBudget]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldGUID]", "fldGUID", "FldGUID", "colFldGUID"  
                    Return "colFldGUID"
                Case "[fldSID]", "fldSID", "FldSID", "colFldSID"  
                    Return "colFldSID"
                Case "[fldGSafeID]", "fldGSafeID", "FldGSafeID", "colFldGSafeID"  
                    Return "colFldGSafeID"
                Case "[fldOutputID]", "fldOutputID", "FldOutputID", "colFldOutputID"  
                    Return "colFldOutputID"
                Case "[fldFileNo]", "fldFileNo", "FldFileNo", "colFldFileNo"  
                    Return "colFldFileNo"
                Case "[fldSortJSON]", "fldSortJSON", "FldSortJSON", "colFldSortJSON"  
                    Return "colFldSortJSON"
                Case "[fldFilterJSON]", "fldFilterJSON", "FldFilterJSON", "colFldFilterJSON"  
                    Return "colFldFilterJSON"
                Case "[fldEstBudget]", "fldEstBudget", "FldEstBudget", "colFldEstBudget"  
                    Return "colFldEstBudget"
                Case "[fldEstCostToComplete]", "fldEstCostToComplete", "FldEstCostToComplete", "colFldEstCostToComplete"  
                    Return "colFldEstCostToComplete"
                Case "[fldRemainBudget]", "fldRemainBudget", "FldRemainBudget", "colFldRemainBudget"  
                    Return "colFldRemainBudget"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldGUID"
                    Return "String"
                Case "colFldSID"
                    Return "String"
                Case "colFldGSafeID"
                    Return "Integer"
                Case "colFldOutputID"
                    Return "Integer"
                Case "colFldFileNo"
                    Return "String"
                Case "colFldSortJSON"
                    Return "String"
                Case "colFldFilterJSON"
                    Return "String"
                Case "colFldEstBudget"
                    Return "String"
                Case "colFldEstCostToComplete"
                    Return "String"
                Case "colFldRemainBudget"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[TblWhatIfOutputParm]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldGUID]"
        End Function

    End Class
End namespace

