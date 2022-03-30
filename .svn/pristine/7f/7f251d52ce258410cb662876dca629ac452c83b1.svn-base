'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwNavLinkChartDrillDownInfo
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldParentNavLinkId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldParentChartId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldChartDrillDownId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldReportId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldUrlBase As New razor.UtilSQLServer.StringDataColumn
        Public colFldUrlParms As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldParentNavLinkId.ColumnName = "[fldParentNavLinkId]"
            colFldParentChartId.ColumnName = "[fldParentChartId]"
            colFldChartDrillDownId.ColumnName = "[fldChartDrillDownId]"
            colFldReportId.ColumnName = "[fldReportId]"
            colFldUrlBase.ColumnName = "[fldUrlBase]"
            colFldUrlParms.ColumnName = "[fldUrlParms]"

            _Members.Add("colFldParentNavLinkId", colFldParentNavLinkId)
            _Members.Add("colFldParentChartId", colFldParentChartId)
            _Members.Add("colFldChartDrillDownId", colFldChartDrillDownId)
            _Members.Add("colFldReportId", colFldReportId)
            _Members.Add("colFldUrlBase", colFldUrlBase)
            _Members.Add("colFldUrlParms", colFldUrlParms)
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
                Case "colFldParentNavLinkId"
                    Return "[fldParentNavLinkId]"
                Case "colFldParentChartId"
                    Return "[fldParentChartId]"
                Case "colFldChartDrillDownId"
                    Return "[fldChartDrillDownId]"
                Case "colFldReportId"
                    Return "[fldReportId]"
                Case "colFldUrlBase"
                    Return "[fldUrlBase]"
                Case "colFldUrlParms"
                    Return "[fldUrlParms]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldParentNavLinkId]", "fldParentNavLinkId", "FldParentNavLinkId", "colFldParentNavLinkId"  
                    Return "colFldParentNavLinkId"
                Case "[fldParentChartId]", "fldParentChartId", "FldParentChartId", "colFldParentChartId"  
                    Return "colFldParentChartId"
                Case "[fldChartDrillDownId]", "fldChartDrillDownId", "FldChartDrillDownId", "colFldChartDrillDownId"  
                    Return "colFldChartDrillDownId"
                Case "[fldReportId]", "fldReportId", "FldReportId", "colFldReportId"  
                    Return "colFldReportId"
                Case "[fldUrlBase]", "fldUrlBase", "FldUrlBase", "colFldUrlBase"  
                    Return "colFldUrlBase"
                Case "[fldUrlParms]", "fldUrlParms", "FldUrlParms", "colFldUrlParms"  
                    Return "colFldUrlParms"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldParentNavLinkId"
                    Return "Integer"
                Case "colFldParentChartId"
                    Return "Integer"
                Case "colFldChartDrillDownId"
                    Return "Integer"
                Case "colFldReportId"
                    Return "Integer"
                Case "colFldUrlBase"
                    Return "String"
                Case "colFldUrlParms"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[cv].[vwNavLinkChartDrillDownInfo]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldParentNavLinkId]"
        End Function

    End Class
End namespace

