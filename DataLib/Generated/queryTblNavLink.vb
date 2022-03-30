'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblNavLink
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colNavControlId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavPracticeID As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavLevelId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavParentLinkId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavLinkId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavText As New razor.UtilSQLServer.StringDataColumn
        Public colNavUrl As New razor.UtilSQLServer.StringDataColumn
        Public colNavOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavToolTip As New razor.UtilSQLServer.StringDataColumn
        Public colNavVisible As New razor.UtilSQLServer.BooleanDataColumn
        Public colNavEnabled As New razor.UtilSQLServer.BooleanDataColumn
        Public colNavSpcFeature As New razor.UtilSQLServer.StringDataColumn
        Public colNavIsPracticeTopLink As New razor.UtilSQLServer.BooleanDataColumn
        Public colNavDefaultExpanded As New razor.UtilSQLServer.BooleanDataColumn
        Public colNavSiteMapKeyWord As New razor.UtilSQLServer.StringDataColumn
        Public colNavAllReportsKeyword As New razor.UtilSQLServer.StringDataColumn
        Public colNavAllDataKeyword As New razor.UtilSQLServer.StringDataColumn
        Public colNavTarget As New razor.UtilSQLServer.StringDataColumn
        Public colNavType As New razor.UtilSQLServer.StringDataColumn
        Public colNavComment As New razor.UtilSQLServer.StringDataColumn
        Public colNavConstant As New razor.UtilSQLServer.StringDataColumn
        Public colNavReportId As New razor.UtilSQLServer.StringDataColumn
        Public colNavGridId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavChartId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavExtractId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavBypassFilter As New razor.UtilSQLServer.BooleanDataColumn
        Public colNavStatusToolTip As New razor.UtilSQLServer.StringDataColumn
        Public colSlideMenuId As New razor.UtilSQLServer.IntegerDataColumn
        Public colSlideGroupId As New razor.UtilSQLServer.IntegerDataColumn
        Public colSlideLevelId As New razor.UtilSQLServer.IntegerDataColumn
        Public colSlideType As New razor.UtilSQLServer.StringDataColumn
        Public colSlideParentId As New razor.UtilSQLServer.IntegerDataColumn
        Public colSlideOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colSlideImageClassName As New razor.UtilSQLServer.StringDataColumn
        Public colIsClientAdmin As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colNavControlId.ColumnName = "[NavControlId]"
            colNavPracticeID.ColumnName = "[NavPracticeID]"
            colNavLevelId.ColumnName = "[NavLevelId]"
            colNavParentLinkId.ColumnName = "[NavParentLinkId]"
            colNavLinkId.ColumnName = "[NavLinkId]"
            colNavText.ColumnName = "[NavText]"
            colNavUrl.ColumnName = "[NavUrl]"
            colNavOrder.ColumnName = "[NavOrder]"
            colNavToolTip.ColumnName = "[NavToolTip]"
            colNavVisible.ColumnName = "[NavVisible]"
            colNavEnabled.ColumnName = "[NavEnabled]"
            colNavSpcFeature.ColumnName = "[NavSpcFeature]"
            colNavIsPracticeTopLink.ColumnName = "[NavIsPracticeTopLink]"
            colNavDefaultExpanded.ColumnName = "[NavDefaultExpanded]"
            colNavSiteMapKeyWord.ColumnName = "[NavSiteMapKeyWord]"
            colNavAllReportsKeyword.ColumnName = "[NavAllReportsKeyword]"
            colNavAllDataKeyword.ColumnName = "[NavAllDataKeyword]"
            colNavTarget.ColumnName = "[NavTarget]"
            colNavType.ColumnName = "[NavType]"
            colNavComment.ColumnName = "[NavComment]"
            colNavConstant.ColumnName = "[NavConstant]"
            colNavReportId.ColumnName = "[NavReportId]"
            colNavGridId.ColumnName = "[NavGridId]"
            colNavChartId.ColumnName = "[NavChartId]"
            colNavExtractId.ColumnName = "[NavExtractId]"
            colNavBypassFilter.ColumnName = "[NavBypassFilter]"
            colNavStatusToolTip.ColumnName = "[NavStatusToolTip]"
            colSlideMenuId.ColumnName = "[slideMenuId]"
            colSlideGroupId.ColumnName = "[slideGroupId]"
            colSlideLevelId.ColumnName = "[slideLevelId]"
            colSlideType.ColumnName = "[slideType]"
            colSlideParentId.ColumnName = "[slideParentId]"
            colSlideOrder.ColumnName = "[slideOrder]"
            colSlideImageClassName.ColumnName = "[slideImageClassName]"
            colIsClientAdmin.ColumnName = "[IsClientAdmin]"

            _Members.Add("colNavControlId", colNavControlId)
            _Members.Add("colNavPracticeID", colNavPracticeID)
            _Members.Add("colNavLevelId", colNavLevelId)
            _Members.Add("colNavParentLinkId", colNavParentLinkId)
            _Members.Add("colNavLinkId", colNavLinkId)
            _Members.Add("colNavText", colNavText)
            _Members.Add("colNavUrl", colNavUrl)
            _Members.Add("colNavOrder", colNavOrder)
            _Members.Add("colNavToolTip", colNavToolTip)
            _Members.Add("colNavVisible", colNavVisible)
            _Members.Add("colNavEnabled", colNavEnabled)
            _Members.Add("colNavSpcFeature", colNavSpcFeature)
            _Members.Add("colNavIsPracticeTopLink", colNavIsPracticeTopLink)
            _Members.Add("colNavDefaultExpanded", colNavDefaultExpanded)
            _Members.Add("colNavSiteMapKeyWord", colNavSiteMapKeyWord)
            _Members.Add("colNavAllReportsKeyword", colNavAllReportsKeyword)
            _Members.Add("colNavAllDataKeyword", colNavAllDataKeyword)
            _Members.Add("colNavTarget", colNavTarget)
            _Members.Add("colNavType", colNavType)
            _Members.Add("colNavComment", colNavComment)
            _Members.Add("colNavConstant", colNavConstant)
            _Members.Add("colNavReportId", colNavReportId)
            _Members.Add("colNavGridId", colNavGridId)
            _Members.Add("colNavChartId", colNavChartId)
            _Members.Add("colNavExtractId", colNavExtractId)
            _Members.Add("colNavBypassFilter", colNavBypassFilter)
            _Members.Add("colNavStatusToolTip", colNavStatusToolTip)
            _Members.Add("colSlideMenuId", colSlideMenuId)
            _Members.Add("colSlideGroupId", colSlideGroupId)
            _Members.Add("colSlideLevelId", colSlideLevelId)
            _Members.Add("colSlideType", colSlideType)
            _Members.Add("colSlideParentId", colSlideParentId)
            _Members.Add("colSlideOrder", colSlideOrder)
            _Members.Add("colSlideImageClassName", colSlideImageClassName)
            _Members.Add("colIsClientAdmin", colIsClientAdmin)
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
                Case "colNavControlId"
                    Return "[NavControlId]"
                Case "colNavPracticeID"
                    Return "[NavPracticeID]"
                Case "colNavLevelId"
                    Return "[NavLevelId]"
                Case "colNavParentLinkId"
                    Return "[NavParentLinkId]"
                Case "colNavLinkId"
                    Return "[NavLinkId]"
                Case "colNavText"
                    Return "[NavText]"
                Case "colNavUrl"
                    Return "[NavUrl]"
                Case "colNavOrder"
                    Return "[NavOrder]"
                Case "colNavToolTip"
                    Return "[NavToolTip]"
                Case "colNavVisible"
                    Return "[NavVisible]"
                Case "colNavEnabled"
                    Return "[NavEnabled]"
                Case "colNavSpcFeature"
                    Return "[NavSpcFeature]"
                Case "colNavIsPracticeTopLink"
                    Return "[NavIsPracticeTopLink]"
                Case "colNavDefaultExpanded"
                    Return "[NavDefaultExpanded]"
                Case "colNavSiteMapKeyWord"
                    Return "[NavSiteMapKeyWord]"
                Case "colNavAllReportsKeyword"
                    Return "[NavAllReportsKeyword]"
                Case "colNavAllDataKeyword"
                    Return "[NavAllDataKeyword]"
                Case "colNavTarget"
                    Return "[NavTarget]"
                Case "colNavType"
                    Return "[NavType]"
                Case "colNavComment"
                    Return "[NavComment]"
                Case "colNavConstant"
                    Return "[NavConstant]"
                Case "colNavReportId"
                    Return "[NavReportId]"
                Case "colNavGridId"
                    Return "[NavGridId]"
                Case "colNavChartId"
                    Return "[NavChartId]"
                Case "colNavExtractId"
                    Return "[NavExtractId]"
                Case "colNavBypassFilter"
                    Return "[NavBypassFilter]"
                Case "colNavStatusToolTip"
                    Return "[NavStatusToolTip]"
                Case "colSlideMenuId"
                    Return "[slideMenuId]"
                Case "colSlideGroupId"
                    Return "[slideGroupId]"
                Case "colSlideLevelId"
                    Return "[slideLevelId]"
                Case "colSlideType"
                    Return "[slideType]"
                Case "colSlideParentId"
                    Return "[slideParentId]"
                Case "colSlideOrder"
                    Return "[slideOrder]"
                Case "colSlideImageClassName"
                    Return "[slideImageClassName]"
                Case "colIsClientAdmin"
                    Return "[IsClientAdmin]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[NavControlId]", "NavControlId", "NavControlId", "colNavControlId"  
                    Return "colNavControlId"
                Case "[NavPracticeID]", "NavPracticeID", "NavPracticeID", "colNavPracticeID"  
                    Return "colNavPracticeID"
                Case "[NavLevelId]", "NavLevelId", "NavLevelId", "colNavLevelId"  
                    Return "colNavLevelId"
                Case "[NavParentLinkId]", "NavParentLinkId", "NavParentLinkId", "colNavParentLinkId"  
                    Return "colNavParentLinkId"
                Case "[NavLinkId]", "NavLinkId", "NavLinkId", "colNavLinkId"  
                    Return "colNavLinkId"
                Case "[NavText]", "NavText", "NavText", "colNavText"  
                    Return "colNavText"
                Case "[NavUrl]", "NavUrl", "NavUrl", "colNavUrl"  
                    Return "colNavUrl"
                Case "[NavOrder]", "NavOrder", "NavOrder", "colNavOrder"  
                    Return "colNavOrder"
                Case "[NavToolTip]", "NavToolTip", "NavToolTip", "colNavToolTip"  
                    Return "colNavToolTip"
                Case "[NavVisible]", "NavVisible", "NavVisible", "colNavVisible"  
                    Return "colNavVisible"
                Case "[NavEnabled]", "NavEnabled", "NavEnabled", "colNavEnabled"  
                    Return "colNavEnabled"
                Case "[NavSpcFeature]", "NavSpcFeature", "NavSpcFeature", "colNavSpcFeature"  
                    Return "colNavSpcFeature"
                Case "[NavIsPracticeTopLink]", "NavIsPracticeTopLink", "NavIsPracticeTopLink", "colNavIsPracticeTopLink"  
                    Return "colNavIsPracticeTopLink"
                Case "[NavDefaultExpanded]", "NavDefaultExpanded", "NavDefaultExpanded", "colNavDefaultExpanded"  
                    Return "colNavDefaultExpanded"
                Case "[NavSiteMapKeyWord]", "NavSiteMapKeyWord", "NavSiteMapKeyWord", "colNavSiteMapKeyWord"  
                    Return "colNavSiteMapKeyWord"
                Case "[NavAllReportsKeyword]", "NavAllReportsKeyword", "NavAllReportsKeyword", "colNavAllReportsKeyword"  
                    Return "colNavAllReportsKeyword"
                Case "[NavAllDataKeyword]", "NavAllDataKeyword", "NavAllDataKeyword", "colNavAllDataKeyword"  
                    Return "colNavAllDataKeyword"
                Case "[NavTarget]", "NavTarget", "NavTarget", "colNavTarget"  
                    Return "colNavTarget"
                Case "[NavType]", "NavType", "NavType", "colNavType"  
                    Return "colNavType"
                Case "[NavComment]", "NavComment", "NavComment", "colNavComment"  
                    Return "colNavComment"
                Case "[NavConstant]", "NavConstant", "NavConstant", "colNavConstant"  
                    Return "colNavConstant"
                Case "[NavReportId]", "NavReportId", "NavReportId", "colNavReportId"  
                    Return "colNavReportId"
                Case "[NavGridId]", "NavGridId", "NavGridId", "colNavGridId"  
                    Return "colNavGridId"
                Case "[NavChartId]", "NavChartId", "NavChartId", "colNavChartId"  
                    Return "colNavChartId"
                Case "[NavExtractId]", "NavExtractId", "NavExtractId", "colNavExtractId"  
                    Return "colNavExtractId"
                Case "[NavBypassFilter]", "NavBypassFilter", "NavBypassFilter", "colNavBypassFilter"  
                    Return "colNavBypassFilter"
                Case "[NavStatusToolTip]", "NavStatusToolTip", "NavStatusToolTip", "colNavStatusToolTip"  
                    Return "colNavStatusToolTip"
                Case "[slideMenuId]", "slideMenuId", "SlideMenuId", "colSlideMenuId"  
                    Return "colSlideMenuId"
                Case "[slideGroupId]", "slideGroupId", "SlideGroupId", "colSlideGroupId"  
                    Return "colSlideGroupId"
                Case "[slideLevelId]", "slideLevelId", "SlideLevelId", "colSlideLevelId"  
                    Return "colSlideLevelId"
                Case "[slideType]", "slideType", "SlideType", "colSlideType"  
                    Return "colSlideType"
                Case "[slideParentId]", "slideParentId", "SlideParentId", "colSlideParentId"  
                    Return "colSlideParentId"
                Case "[slideOrder]", "slideOrder", "SlideOrder", "colSlideOrder"  
                    Return "colSlideOrder"
                Case "[slideImageClassName]", "slideImageClassName", "SlideImageClassName", "colSlideImageClassName"  
                    Return "colSlideImageClassName"
                Case "[IsClientAdmin]", "IsClientAdmin", "IsClientAdmin", "colIsClientAdmin"  
                    Return "colIsClientAdmin"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colNavControlId"
                    Return "Integer"
                Case "colNavPracticeID"
                    Return "Integer"
                Case "colNavLevelId"
                    Return "Integer"
                Case "colNavParentLinkId"
                    Return "Integer"
                Case "colNavLinkId"
                    Return "Integer"
                Case "colNavText"
                    Return "String"
                Case "colNavUrl"
                    Return "String"
                Case "colNavOrder"
                    Return "Integer"
                Case "colNavToolTip"
                    Return "String"
                Case "colNavVisible"
                    Return "Boolean"
                Case "colNavEnabled"
                    Return "Boolean"
                Case "colNavSpcFeature"
                    Return "String"
                Case "colNavIsPracticeTopLink"
                    Return "Boolean"
                Case "colNavDefaultExpanded"
                    Return "Boolean"
                Case "colNavSiteMapKeyWord"
                    Return "String"
                Case "colNavAllReportsKeyword"
                    Return "String"
                Case "colNavAllDataKeyword"
                    Return "String"
                Case "colNavTarget"
                    Return "String"
                Case "colNavType"
                    Return "String"
                Case "colNavComment"
                    Return "String"
                Case "colNavConstant"
                    Return "String"
                Case "colNavReportId"
                    Return "String"
                Case "colNavGridId"
                    Return "Integer"
                Case "colNavChartId"
                    Return "Integer"
                Case "colNavExtractId"
                    Return "Integer"
                Case "colNavBypassFilter"
                    Return "Boolean"
                Case "colNavStatusToolTip"
                    Return "String"
                Case "colSlideMenuId"
                    Return "Integer"
                Case "colSlideGroupId"
                    Return "Integer"
                Case "colSlideLevelId"
                    Return "Integer"
                Case "colSlideType"
                    Return "String"
                Case "colSlideParentId"
                    Return "Integer"
                Case "colSlideOrder"
                    Return "Integer"
                Case "colSlideImageClassName"
                    Return "String"
                Case "colIsClientAdmin"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[NavLink]"
        End Function

        Private Function _FirstColumn() As String
            Return "[NavControlId]"
        End Function

    End Class
End namespace

