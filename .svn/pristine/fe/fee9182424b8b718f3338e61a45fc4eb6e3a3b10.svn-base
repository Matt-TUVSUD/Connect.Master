

Public Class Charts_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = ""
        Dim zSafeId As Integer = 0
        Dim zBatchSetId As String = ""

        Try
            ' GET THE GRID INFOMRATION
            Dim zChartId As String = "0"
            If Not Request.QueryString("chartId") Is Nothing Then
                zChartId = Request.QueryString("chartId") & ""
            End If
            Dim zPageId As String = ""
            If Not Request.QueryString("pageId") Is Nothing Then
                zPageId = "&pageId=" & Request.QueryString("pageId")
            End If

            ' SET THE NAVLINK INFOMRATION
            Dim zNavlinkId As String = "0"
            If Not Request.QueryString("navLinkId") Is Nothing Then
                UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.NavLinkId, Request.QueryString("navLinkId"), UtilGSafe.KeyNameGroup.Navigation)
            End If

            ' GET THE TARGET FOLDER INFORMATION AND OTHER PARAMETERS
            Dim zTargetFolderName As String = "Recommendations"
            If Not Request.QueryString("targetFolderName") Is Nothing Then
                zTargetFolderName = Request.QueryString("targetFolderName")
            End If
            Dim zTargetPageName As String = "Recommendations"
            If Not Request.QueryString("targetPageName") Is Nothing Then
                zTargetPageName = Request.QueryString("targetPageName")
            End If
            Dim zDrillDown As String = ""
            Dim zIsDrillDown As Boolean = False
            If Not Request.QueryString("DrillDown") Is Nothing Then
                zDrillDown = "&DrillDown=" & Request.QueryString("DrillDown")
                If Request.QueryString("DrillDown").ToLower() = "true" Then zIsDrillDown = True
            End If
            Dim zPrimaryRecType As String = Nothing
            Dim zPrimaryRecTypeUrlParm As String = ""
            If Not Request.QueryString("PrimaryRecTypeFromDrillDown") Is Nothing Then
                zPrimaryRecType = Request.QueryString("PrimaryRecTypeFromDrillDown")
                zPrimaryRecTypeUrlParm = "&PrimaryRecTypeFromDrillDown=" & zPrimaryRecType
            End If
            Dim zRecStatus As String = ""

            ' STORE THE CORRECT INFORMATION TO THE GSAFE AND LARGE OBJECTS AND GSAFE DETAILS
            If Not Request.QueryString("batchSetId") Is Nothing Then
                zBatchSetId = "&batchSetId=" & Request.QueryString("batchSetId")
            Else
                zGUID = UtilGSafe.GetGUIDFromQueryString()
                zSafeId = UtilGSafe.GetId(zGUID)
                If zIsDrillDown Then
                    Dim zPrimaryChartId As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentChartId)
                    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartDrillDownId, zChartId, UtilGSafe.KeyNameGroup.Navigation)
                    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartDrillBackId, zPrimaryChartId, UtilGSafe.KeyNameGroup.Navigation)
                    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartTargetFolder, zTargetFolderName, UtilGSafe.KeyNameGroup.Navigation)
                    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartTargetPage, zTargetPageName, UtilGSafe.KeyNameGroup.Navigation)
                    ' COPY THE LARGE OBJECT DATA FROM EXISTING CHART TO DRILLDOWN CHART
                    Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filterChart, zPrimaryChartId)
                    Dim zSetting As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.settingChart, zPrimaryChartId)
                    UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filterChart, zFilter, zChartId)
                    UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.settingChart, zSetting, zChartId)
                    ' CREATE A CRITERIA BASED ON THE PRIMARY TYPE OF THE EXISTING CHART
                    If Not zPrimaryRecType Is Nothing Then
                        Dim zJsonCriteria As New JSONFilter
                        zJsonCriteria.Filters.Add(New JSONFilterItem("PrimaryRecType", JSONFilterOperator.Operators.Equal, zPrimaryRecType))
                        Dim zJsonString As String = zJsonCriteria.ToJSON
                        UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaChart, zJsonString, zChartId)
                    End If
                Else
                    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartDrillDownId, "", UtilGSafe.KeyNameGroup.Navigation)
                    'UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartDrillBackId, "", UtilGSafe.KeyNameGroup.Navigation)
                    'UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartTargetFolder, "", UtilGSafe.KeyNameGroup.Navigation)
                    'UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartTargetPage, "", UtilGSafe.KeyNameGroup.Navigation)
                    UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.currentChartId, zChartId, UtilGSafe.KeyNameGroup.Navigation)
                End If

                Dim zUserid As Integer = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.EzyLoginId)
                UtilDB.LogChartActivity(zUserid, zChartId)

            End If

            
            ' REDIRECT TO THE GRID PAGE
            Dim zURL As String = "~/Home_{{VER}}/Charts/" & zTargetFolderName & "/" & zTargetPageName & ".aspx?sid=" & zGUID & zDrillDown & zBatchSetId & "&chartId=" & zChartId & zPageId & zPrimaryRecTypeUrlParm
            Response.Redirect(zURL, False)

        Catch ex As Exception

        End Try

    End Sub

End Class