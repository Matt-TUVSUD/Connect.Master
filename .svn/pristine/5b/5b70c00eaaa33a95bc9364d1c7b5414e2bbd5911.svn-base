'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaChart
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSourceId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldChartName As New razor.UtilSQLServer.StringDataColumn
        Public colFldTitlePage As New razor.UtilSQLServer.StringDataColumn
        Public colFldTitlePageSub As New razor.UtilSQLServer.StringDataColumn
        Public colFldTitleChart As New razor.UtilSQLServer.StringDataColumn
        Public colFldTitleValueAxis As New razor.UtilSQLServer.StringDataColumn
        Public colFldLegendTemplate As New razor.UtilSQLServer.StringDataColumn
        Public colFldNotes As New razor.UtilSQLServer.StringDataColumn
        Public colFldSummaryMode As New razor.UtilSQLServer.StringDataColumn
        Public colFldReportId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldSourceId.ColumnName = "[fldSourceId]"
            colFldChartName.ColumnName = "[fldChartName]"
            colFldTitlePage.ColumnName = "[fldTitlePage]"
            colFldTitlePageSub.ColumnName = "[fldTitlePageSub]"
            colFldTitleChart.ColumnName = "[fldTitleChart]"
            colFldTitleValueAxis.ColumnName = "[fldTitleValueAxis]"
            colFldLegendTemplate.ColumnName = "[fldLegendTemplate]"
            colFldNotes.ColumnName = "[fldNotes]"
            colFldSummaryMode.ColumnName = "[fldSummaryMode]"
            colFldReportId.ColumnName = "[fldReportId]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldSourceId", colFldSourceId)
            _Members.Add("colFldChartName", colFldChartName)
            _Members.Add("colFldTitlePage", colFldTitlePage)
            _Members.Add("colFldTitlePageSub", colFldTitlePageSub)
            _Members.Add("colFldTitleChart", colFldTitleChart)
            _Members.Add("colFldTitleValueAxis", colFldTitleValueAxis)
            _Members.Add("colFldLegendTemplate", colFldLegendTemplate)
            _Members.Add("colFldNotes", colFldNotes)
            _Members.Add("colFldSummaryMode", colFldSummaryMode)
            _Members.Add("colFldReportId", colFldReportId)
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
                Case "colFldSourceId"
                    Return "[fldSourceId]"
                Case "colFldChartName"
                    Return "[fldChartName]"
                Case "colFldTitlePage"
                    Return "[fldTitlePage]"
                Case "colFldTitlePageSub"
                    Return "[fldTitlePageSub]"
                Case "colFldTitleChart"
                    Return "[fldTitleChart]"
                Case "colFldTitleValueAxis"
                    Return "[fldTitleValueAxis]"
                Case "colFldLegendTemplate"
                    Return "[fldLegendTemplate]"
                Case "colFldNotes"
                    Return "[fldNotes]"
                Case "colFldSummaryMode"
                    Return "[fldSummaryMode]"
                Case "colFldReportId"
                    Return "[fldReportId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldSourceId]", "fldSourceId", "FldSourceId", "colFldSourceId"  
                    Return "colFldSourceId"
                Case "[fldChartName]", "fldChartName", "FldChartName", "colFldChartName"  
                    Return "colFldChartName"
                Case "[fldTitlePage]", "fldTitlePage", "FldTitlePage", "colFldTitlePage"  
                    Return "colFldTitlePage"
                Case "[fldTitlePageSub]", "fldTitlePageSub", "FldTitlePageSub", "colFldTitlePageSub"  
                    Return "colFldTitlePageSub"
                Case "[fldTitleChart]", "fldTitleChart", "FldTitleChart", "colFldTitleChart"  
                    Return "colFldTitleChart"
                Case "[fldTitleValueAxis]", "fldTitleValueAxis", "FldTitleValueAxis", "colFldTitleValueAxis"  
                    Return "colFldTitleValueAxis"
                Case "[fldLegendTemplate]", "fldLegendTemplate", "FldLegendTemplate", "colFldLegendTemplate"  
                    Return "colFldLegendTemplate"
                Case "[fldNotes]", "fldNotes", "FldNotes", "colFldNotes"  
                    Return "colFldNotes"
                Case "[fldSummaryMode]", "fldSummaryMode", "FldSummaryMode", "colFldSummaryMode"  
                    Return "colFldSummaryMode"
                Case "[fldReportId]", "fldReportId", "FldReportId", "colFldReportId"  
                    Return "colFldReportId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldSourceId"
                    Return "Integer"
                Case "colFldChartName"
                    Return "String"
                Case "colFldTitlePage"
                    Return "String"
                Case "colFldTitlePageSub"
                    Return "String"
                Case "colFldTitleChart"
                    Return "String"
                Case "colFldTitleValueAxis"
                    Return "String"
                Case "colFldLegendTemplate"
                    Return "String"
                Case "colFldNotes"
                    Return "String"
                Case "colFldSummaryMode"
                    Return "String"
                Case "colFldReportId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaChart]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

