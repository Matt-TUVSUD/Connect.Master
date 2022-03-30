'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaProgramStatus
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSectionName As New razor.UtilSQLServer.StringDataColumn
        Public colFldTopName As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetricName As New razor.UtilSQLServer.StringDataColumn
        Public colFldSubMetricName As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetricValue As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMetricLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetricVisible As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldMetricColor As New razor.UtilSQLServer.StringDataColumn
        Public colFldDirectId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldCriteria As New razor.UtilSQLServer.StringDataColumn
        Public colFldFilter As New razor.UtilSQLServer.StringDataColumn
        Public colFldGridId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSort As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSectionName.ColumnName = "[fldSectionName]"
            colFldTopName.ColumnName = "[fldTopName]"
            colFldMetricName.ColumnName = "[fldMetricName]"
            colFldSubMetricName.ColumnName = "[fldSubMetricName]"
            colFldMetricValue.ColumnName = "[fldMetricValue]"
            colFldMetricLabel.ColumnName = "[fldMetricLabel]"
            colFldMetricVisible.ColumnName = "[fldMetricVisible]"
            colFldMetricColor.ColumnName = "[fldMetricColor]"
            colFldDirectId.ColumnName = "[fldDirectId]"
            colFldCriteria.ColumnName = "[fldCriteria]"
            colFldFilter.ColumnName = "[fldFilter]"
            colFldGridId.ColumnName = "[fldGridId]"
            colFldSort.ColumnName = "[fldSort]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSectionName", colFldSectionName)
            _Members.Add("colFldTopName", colFldTopName)
            _Members.Add("colFldMetricName", colFldMetricName)
            _Members.Add("colFldSubMetricName", colFldSubMetricName)
            _Members.Add("colFldMetricValue", colFldMetricValue)
            _Members.Add("colFldMetricLabel", colFldMetricLabel)
            _Members.Add("colFldMetricVisible", colFldMetricVisible)
            _Members.Add("colFldMetricColor", colFldMetricColor)
            _Members.Add("colFldDirectId", colFldDirectId)
            _Members.Add("colFldCriteria", colFldCriteria)
            _Members.Add("colFldFilter", colFldFilter)
            _Members.Add("colFldGridId", colFldGridId)
            _Members.Add("colFldSort", colFldSort)
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
                Case "colFldId"
                    Return "[fldId]"
                Case "colFldSectionName"
                    Return "[fldSectionName]"
                Case "colFldTopName"
                    Return "[fldTopName]"
                Case "colFldMetricName"
                    Return "[fldMetricName]"
                Case "colFldSubMetricName"
                    Return "[fldSubMetricName]"
                Case "colFldMetricValue"
                    Return "[fldMetricValue]"
                Case "colFldMetricLabel"
                    Return "[fldMetricLabel]"
                Case "colFldMetricVisible"
                    Return "[fldMetricVisible]"
                Case "colFldMetricColor"
                    Return "[fldMetricColor]"
                Case "colFldDirectId"
                    Return "[fldDirectId]"
                Case "colFldCriteria"
                    Return "[fldCriteria]"
                Case "colFldFilter"
                    Return "[fldFilter]"
                Case "colFldGridId"
                    Return "[fldGridId]"
                Case "colFldSort"
                    Return "[fldSort]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldSectionName]", "fldSectionName", "FldSectionName", "colFldSectionName"  
                    Return "colFldSectionName"
                Case "[fldTopName]", "fldTopName", "FldTopName", "colFldTopName"  
                    Return "colFldTopName"
                Case "[fldMetricName]", "fldMetricName", "FldMetricName", "colFldMetricName"  
                    Return "colFldMetricName"
                Case "[fldSubMetricName]", "fldSubMetricName", "FldSubMetricName", "colFldSubMetricName"  
                    Return "colFldSubMetricName"
                Case "[fldMetricValue]", "fldMetricValue", "FldMetricValue", "colFldMetricValue"  
                    Return "colFldMetricValue"
                Case "[fldMetricLabel]", "fldMetricLabel", "FldMetricLabel", "colFldMetricLabel"  
                    Return "colFldMetricLabel"
                Case "[fldMetricVisible]", "fldMetricVisible", "FldMetricVisible", "colFldMetricVisible"  
                    Return "colFldMetricVisible"
                Case "[fldMetricColor]", "fldMetricColor", "FldMetricColor", "colFldMetricColor"  
                    Return "colFldMetricColor"
                Case "[fldDirectId]", "fldDirectId", "FldDirectId", "colFldDirectId"  
                    Return "colFldDirectId"
                Case "[fldCriteria]", "fldCriteria", "FldCriteria", "colFldCriteria"  
                    Return "colFldCriteria"
                Case "[fldFilter]", "fldFilter", "FldFilter", "colFldFilter"  
                    Return "colFldFilter"
                Case "[fldGridId]", "fldGridId", "FldGridId", "colFldGridId"  
                    Return "colFldGridId"
                Case "[fldSort]", "fldSort", "FldSort", "colFldSort"  
                    Return "colFldSort"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldSectionName"
                    Return "String"
                Case "colFldTopName"
                    Return "String"
                Case "colFldMetricName"
                    Return "String"
                Case "colFldSubMetricName"
                    Return "String"
                Case "colFldMetricValue"
                    Return "Integer"
                Case "colFldMetricLabel"
                    Return "String"
                Case "colFldMetricVisible"
                    Return "Boolean"
                Case "colFldMetricColor"
                    Return "String"
                Case "colFldDirectId"
                    Return "Integer"
                Case "colFldCriteria"
                    Return "String"
                Case "colFldFilter"
                    Return "String"
                Case "colFldGridId"
                    Return "Integer"
                Case "colFldSort"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaProgramStatus]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

