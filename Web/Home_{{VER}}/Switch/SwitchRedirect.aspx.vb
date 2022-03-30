
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Public Class SwitchRedirect
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '***GRC.Connect.Ed - Replace with new function created by SB 7/29/2015
        'Dim zGSafeGUID As String = Request.QueryString("sid")
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zEditPreferences As String = Request.QueryString("p1").ToLower()

        '***GRC.Connect.Ed - Infaragistics related reference '7/29/2015
        'Call modConfig.SetIGConfig(zGSafeGUID)
        '***************************************************

        'Call BuildSafeSiteMapItems(zGSafeGUID) 'BUILD THE SITEMAP TABLE

        If zEditPreferences = "true" Then
            UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.practiceName, "Filters & Settings - myPreferences", UtilGSafe.KeyNameGroup.PageHeader)
            'Response.Redirect("~/Home_{{VER}}/Preference/Edit.aspx?sid=" & zGSafeGUID, False)
            Response.Redirect("~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGSafeGUID, False)
        Else
            Response.Redirect("~/Home_{{VER}}/Gauge/?SwitchRedirect=1&sid=" & zGSafeGUID, False)

            'Dim counter As UtilUpdates.UpdateResult = UtilUpdates.GetCounts(zGSafeGUID)
            'If counter.WhatsNewCount > 0 Then
            '    Response.Redirect("~/Home_{{VER}}/Gauge/?FinalDestination=News&sid=" & zGSafeGUID, False)
            'Else
            '   
            'End If

        End If
    End Sub


    Private Sub BuildSafeSiteMapItems(pSafeGUID As String)
        Dim zSW As New Stopwatch
        zSW.Start()
        Diagnostics.Trace.WriteLine("******************************")
        Diagnostics.Trace.WriteLine("[BuildSafeSiteMapItems Start] elapsed: " & zSW.Elapsed.ToString)


        Dim zGSafeId As Integer = UtilGSafe.GetId(pSafeGUID)
        Diagnostics.Trace.WriteLine("BuildSafeSiteMapItems [UtilGSafe.GetId elapsed: " & zSW.Elapsed.ToString)

        Dim zIsError As Boolean = False

        Try
            'GET THE CURRENT NAVLINKS THAT WILL BE USED ON THE SITEMAP
            Dim zUtilNavLink As New UtilNavLink(pSafeGUID)
            Diagnostics.Trace.WriteLine("BuildSafeSiteMapItems [New UtilNavlink] elapsed: " & zSW.Elapsed.ToString)

            Dim zLinks As List(Of BusinessObjects.ViewCCNavLink) = zUtilNavLink.GetSiteMapLinks
            Diagnostics.Trace.WriteLine("BuildSafeSiteMapItems [zUtilNavLink.GetSiteMapLinks] elapsed: " & zSW.Elapsed.ToString)

            Dim zSB As New StringBuilder

            'REMOVE ALL EXISTING ITEMS FOR THIS USER FROM THE GSAFESITEMAP TABLE
            Dim zCon As New SqlClient.SqlConnection(UtilDB.ConnectionString)
            Dim zCmd As New SqlClient.SqlCommand("DELETE GSafeSiteMapItems WHERE GSafeId=@GsafeId", zCon)
            zCmd.Parameters.AddWithValue("@GsafeId", zGSafeId)
            zCon.Open()
            Using zCon
                Dim zDeleteCount As Integer = zCmd.ExecuteNonQuery()
                zCon.Close()
            End Using
            Diagnostics.Trace.WriteLine("BuildSafeSiteMapItems [Delete existing NavLinks] elapsed: " & zSW.Elapsed.ToString)


            'ADD ALL ITEMS TO THE GSAFESITEMAP TABLE AND SAVE
            Dim zObjSiteMap As New GSafeSitemapItems
            Dim zCollSiteMap = New GSafeSitemapItemsCollection
            For Each zItem As ViewCCNavLink In zLinks
                zObjSiteMap = zCollSiteMap.AddNew()
                zObjSiteMap.GSafeId = zGSafeId
                zObjSiteMap.NavLinkId = zItem.NavLinkId
                zObjSiteMap.NavSiteMapKeyWord = zItem.NavSiteMapKeyword
                zObjSiteMap.NavAllReportsKeyword = zItem.NavAllReportsKeyword
                zObjSiteMap.NavAllDataKeyword = zItem.NavAllDataKeyword
                zObjSiteMap.NavParentLinkId = zItem.NavParentLinkId
                zObjSiteMap.NavText = zItem.NavText
                zObjSiteMap.NavUrl = zItem.NavUrl
                zObjSiteMap.NavOrder = zItem.NavOrder
                zObjSiteMap.NavToolTip = zItem.NavToolTip
                zObjSiteMap.NavVisible = zItem.NavVisible
                zObjSiteMap.NavEnabled = zItem.NavEnabled
                zObjSiteMap.NavTarget = zItem.NavTarget
                zObjSiteMap.NavType = zItem.NavType
                zObjSiteMap.NavConstant = zItem.NavConstant
                zObjSiteMap.NavRptCode = zItem.NavRptCode
                zObjSiteMap.NavGridId = zItem.NavGridId
                zObjSiteMap.NavChartId = zItem.NavChartId
                zObjSiteMap.NavStatusToolTip = zItem.NavStatusToolTip
                zObjSiteMap.NavExtractId = zItem.NavExtractId
                zObjSiteMap.SlideMenuId = zItem.SlideMenuId
                zObjSiteMap.SlideGroupId = zItem.SlideGroupId
                zObjSiteMap.SlideLevelId = zItem.SlideLevelId
                zObjSiteMap.SlideType = zItem.SlideType
                zObjSiteMap.SlideParentId = zItem.SlideParentId
                zObjSiteMap.SlideOrder = zItem.SlideOrder
                zObjSiteMap.SlideImageClassName = zItem.SlideImageClassName
                'Debug.WriteLine("GSafeID: " & zObjSiteMap.GSafeId & " NavLinkId: " & zObjSiteMap.NavLinkId)
            Next
            zCollSiteMap.Save()
            Diagnostics.Trace.WriteLine("BuildSafeSiteMapItems [Build GSafeSitemapItemsCollection] elapsed: " & zSW.Elapsed.ToString)

            ' CREATE THE SIDE / TOP MENU JSON OBJECT AND STORE FOR LATER USE ON PAGE LOAD
            Dim myDelete As String = "DELETE FROM [GSafeSlideMenu] WHERE GSafeId = " & zGSafeId
            GRC.Connect.Libraries.DataLib.razor.UtilSQLServer.ExecuteNonQuery(myDelete)
            If UtilNav.SetAllMenuItemsSitemap(pSafeGUID, NavLink.SlideMenuTypes.Side) = False Then zIsError = True
            If UtilNav.SetAllMenuItemsSitemap(pSafeGUID, NavLink.SlideMenuTypes.Top) = False Then zIsError = True
            Diagnostics.Trace.WriteLine("BuildSafeSiteMapItems [CREATE THE SIDE / TOP MENU JSON OBJECT] elapsed: " & zSW.Elapsed.ToString)

            zSW.Stop()
            Diagnostics.Trace.WriteLine("[BuildSafeSiteMapItems Finished] elapsed: " & zSW.Elapsed.ToString)
            Diagnostics.Trace.WriteLine("******************************")

        Catch ex As Exception
            zIsError = True
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.LoggedInUserEmail), ex.Message, "SwitchRedirect.aspx.vb", "BuildSafeSiteMapItems() Exception", HttpContext.Current.Request.ServerVariables("REMOTE_ADDR"))
        End Try

        ' REDIRECT TO RESCUE PAGE IF ERROR
        If zIsError = True Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", True)
        End If

    End Sub



End Class