'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryViewCCGSafeSitemapItems
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavSiteMapKeyWord As New razor.UtilSQLServer.StringDataColumn
        Public colNavAllReportsKeyword As New razor.UtilSQLServer.StringDataColumn
        Public colNavAllDataKeyword As New razor.UtilSQLServer.StringDataColumn
        Public colNavLinkId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavParentLinkId As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavText As New razor.UtilSQLServer.StringDataColumn
        Public colNavUrl As New razor.UtilSQLServer.StringDataColumn
        Public colNavOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavToolTip As New razor.UtilSQLServer.StringDataColumn
        Public colNavVisible As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavEnabled As New razor.UtilSQLServer.IntegerDataColumn
        Public colNavTarget As New razor.UtilSQLServer.StringDataColumn
        Public colNavType As New razor.UtilSQLServer.StringDataColumn
        Public colNavConstant As New razor.UtilSQLServer.StringDataColumn
        Public colNavRptCode As New razor.UtilSQLServer.StringDataColumn
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

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colGSafeId.ColumnName = "[GSafeId]"
            colNavSiteMapKeyWord.ColumnName = "[NavSiteMapKeyWord]"
            colNavAllReportsKeyword.ColumnName = "[NavAllReportsKeyword]"
            colNavAllDataKeyword.ColumnName = "[NavAllDataKeyword]"
            colNavLinkId.ColumnName = "[NavLinkId]"
            colNavParentLinkId.ColumnName = "[NavParentLinkId]"
            colNavText.ColumnName = "[NavText]"
            colNavUrl.ColumnName = "[NavUrl]"
            colNavOrder.ColumnName = "[NavOrder]"
            colNavToolTip.ColumnName = "[NavToolTip]"
            colNavVisible.ColumnName = "[NavVisible]"
            colNavEnabled.ColumnName = "[NavEnabled]"
            colNavTarget.ColumnName = "[NavTarget]"
            colNavType.ColumnName = "[NavType]"
            colNavConstant.ColumnName = "[NavConstant]"
            colNavRptCode.ColumnName = "[NavRptCode]"
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

            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colNavSiteMapKeyWord", colNavSiteMapKeyWord)
            _Members.Add("colNavAllReportsKeyword", colNavAllReportsKeyword)
            _Members.Add("colNavAllDataKeyword", colNavAllDataKeyword)
            _Members.Add("colNavLinkId", colNavLinkId)
            _Members.Add("colNavParentLinkId", colNavParentLinkId)
            _Members.Add("colNavText", colNavText)
            _Members.Add("colNavUrl", colNavUrl)
            _Members.Add("colNavOrder", colNavOrder)
            _Members.Add("colNavToolTip", colNavToolTip)
            _Members.Add("colNavVisible", colNavVisible)
            _Members.Add("colNavEnabled", colNavEnabled)
            _Members.Add("colNavTarget", colNavTarget)
            _Members.Add("colNavType", colNavType)
            _Members.Add("colNavConstant", colNavConstant)
            _Members.Add("colNavRptCode", colNavRptCode)
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
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colNavSiteMapKeyWord"
                    Return "[NavSiteMapKeyWord]"
                Case "colNavAllReportsKeyword"
                    Return "[NavAllReportsKeyword]"
                Case "colNavAllDataKeyword"
                    Return "[NavAllDataKeyword]"
                Case "colNavLinkId"
                    Return "[NavLinkId]"
                Case "colNavParentLinkId"
                    Return "[NavParentLinkId]"
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
                Case "colNavTarget"
                    Return "[NavTarget]"
                Case "colNavType"
                    Return "[NavType]"
                Case "colNavConstant"
                    Return "[NavConstant]"
                Case "colNavRptCode"
                    Return "[NavRptCode]"
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
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[NavSiteMapKeyWord]", "NavSiteMapKeyWord", "NavSiteMapKeyWord", "colNavSiteMapKeyWord"  
                    Return "colNavSiteMapKeyWord"
                Case "[NavAllReportsKeyword]", "NavAllReportsKeyword", "NavAllReportsKeyword", "colNavAllReportsKeyword"  
                    Return "colNavAllReportsKeyword"
                Case "[NavAllDataKeyword]", "NavAllDataKeyword", "NavAllDataKeyword", "colNavAllDataKeyword"  
                    Return "colNavAllDataKeyword"
                Case "[NavLinkId]", "NavLinkId", "NavLinkId", "colNavLinkId"  
                    Return "colNavLinkId"
                Case "[NavParentLinkId]", "NavParentLinkId", "NavParentLinkId", "colNavParentLinkId"  
                    Return "colNavParentLinkId"
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
                Case "[NavTarget]", "NavTarget", "NavTarget", "colNavTarget"  
                    Return "colNavTarget"
                Case "[NavType]", "NavType", "NavType", "colNavType"  
                    Return "colNavType"
                Case "[NavConstant]", "NavConstant", "NavConstant", "colNavConstant"  
                    Return "colNavConstant"
                Case "[NavRptCode]", "NavRptCode", "NavRptCode", "colNavRptCode"  
                    Return "colNavRptCode"
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
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colGSafeId"
                    Return "Integer"
                Case "colNavSiteMapKeyWord"
                    Return "String"
                Case "colNavAllReportsKeyword"
                    Return "String"
                Case "colNavAllDataKeyword"
                    Return "String"
                Case "colNavLinkId"
                    Return "Integer"
                Case "colNavParentLinkId"
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
                    Return "Integer"
                Case "colNavEnabled"
                    Return "Integer"
                Case "colNavTarget"
                    Return "String"
                Case "colNavType"
                    Return "String"
                Case "colNavConstant"
                    Return "String"
                Case "colNavRptCode"
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
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[viewCCGSafeSitemapItems]"
        End Function

        Private Function _FirstColumn() As String
            Return "[GSafeId]"
        End Function

    End Class
End namespace

