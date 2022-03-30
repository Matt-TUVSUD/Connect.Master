Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilNav

    Public Shared NavLinkPlaceholder As String = "_BASE1_"


    Public Enum KeywordColumn
        SiteMap
        AllData
        AllReports
    End Enum


    Public Class IconClassName
        Public Shared Property menuIconFire = "menuIconFire"
        Public Shared Property menuIconBoiler = "menuIconBoiler"
        Public Shared Property menuIconInfrared = "menuIconInfrared"
        Public Shared Property menuIconJuris = "menuIconJuris"
        Public Shared Property menuIconNatHaz = "menuIconNatHaz"
        Public Shared Property menuIconDivServ = "menuIconDivServ"
        Public Shared Property menuIconPS = "menuIconPS"
    End Class


    Public Shared Function GetNavUrl(ByVal pNavLinkID As Integer) As String
        Dim zReturn As String
        Dim zLink As New NavLink

        If zLink.LoadByPrimaryKey(pNavLinkID) Then
            zReturn = zLink.NavUrl
            zReturn = UtilNav.ReplaceBaseString(zReturn, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}")
        Else
            zReturn = UtilSystemParms.ReadWebAppBaseURL & "/Home_{{VER}}/Gauge/Default.aspx"
        End If

        Return zReturn

    End Function


    ''' <summary>
    ''' Returns a formatted text HTML for a Kendo navigation menu item.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetNavText(ByVal pNavLinkID As Integer) As String
        Dim zReturn As String
        Dim zLink As New NavLink

        If zLink.LoadByPrimaryKey(pNavLinkID) Then
            zReturn = zLink.NavText
        Else
            zReturn = "Details"
        End If

        Return zReturn

    End Function

    <Obsolete("No longer in use.  Use the UtilUpdates class", True)>
    Public Shared Function IsWhatsNewAvailable(ByVal pGUID As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zPreviousLogin As Date

        'GET LAST LOGIN DATE
        If UtilGSafe.GetValue(pGUID, UtilGSafe.KeyName.PreviousLoginDate).Length > 0 Then
            zPreviousLogin = UtilGSafe.GetValue(pGUID, UtilGSafe.KeyName.PreviousLoginDate)
        Else
            zPreviousLogin = "1/1/1900"
        End If

        'SAVE THE PREVIOUS LOGIN DATE SO THE WHATS NEW LABEL DOES NOT SHOW AGAIN
        UtilGSafe.SetValue(pGUID, UtilGSafe.KeyName.PreviousLoginDate, Now().ToString(), UtilGSafe.KeyNameGroup.Authentication)

        'GET DATE OF MOST RECENT FILE IN WHATS NEW FOLDER
        Dim zExternalPath As String = UtilSystemParms.ExternalWhatsNewPath  ' "\\Extra-data\ClientsWEB_D\data\WhatsNew"
        Dim zDirectory As New System.IO.DirectoryInfo(zExternalPath)
        Dim zFiles = zDirectory.GetFiles.ToList
        'Dim zFirst = (From file In zFiles Select file Order By file.CreationTime Ascending).FirstOrDefault
        Dim zLast = (From file In zFiles Select file Order By file.CreationTime Descending).FirstOrDefault

        'RETURN TRUE IF FILE DATE MATCHES GREATER THAN LAST LOGIN DATE
        If zLast.LastWriteTime > zPreviousLogin Then
            zReturn = True
        End If

        Return zReturn
    End Function

    <Obsolete("No longer in use.  Use the UtilUpdates class", True)>
    Public Shared Function IsRecentUpdateAvailable(ByVal pGUID As String, pLastRecentUpdate As Date) As Boolean

        Throw New NotImplementedException()
        'Dim zReturn As Boolean = False

        'Try
        '    Dim zQry As New queryVwDocumentLibraryUpdates
        '    zQry.SelectAll()
        '    zQry.Where.Add(zQry.colGsafeguid.Equals(pGUID))
        '    zQry.Where.Add(zQry.colDocumentDate.GreaterThanEqual(pLastRecentUpdate))

        '    Dim zSQL As String = zQry.QueryText
        '    Dim zUpdates As List(Of rowVwDocumentLibraryUpdates) = VwDocumentLibraryUpdates.LoadData(zSQL)
        '    Return CBool(zUpdates.Count)

        'Catch ex As Exception
        '    Return zReturn
        'End Try

    End Function

    <Obsolete("Use the UtilUpdates class instead", True)>
    Public Shared Function GetLastRecentUpdateDate(ByVal pGUID As String) As Date
        Dim zDefaultReturn As Date = New Date(2000, 1, 1)

        Dim zEzyUserId As Integer = UtilGSafe.GetValue(pGUID, UtilGSafe.KeyName.EzyUserId)
        Dim zRow As rowTblEzyUsers = TblEzyUsers.LoadByPrimaryKey(zEzyUserId)

        If Not IsNothing(zRow) Then
            If Not IsNothing(zRow.colLastRecentUpdate) Then
                Return zRow.colLastRecentUpdate
            End If
        End If

        Return zDefaultReturn

    End Function


    'Public Shared Function GetLastRecentUpdateDate(ByVal pGUID As String) As Date
    '    Dim zReturn As String = Date.Today.AddDays(-30).ToString("yyyyMMdd")
    '    Try
    '        Dim zEzyUserId As Integer = UtilGSafe.GetValue(pGUID, UtilGSafe.KeyName.EzyUserId)
    '        Dim zRow As rowTblEzyUsers = TblEzyUsers.LoadByPrimaryKey(zEzyUserId)

    '        If Not IsNothing(zRow) AndAlso Not String.IsNullOrEmpty(zRow.colLastRecentUpdate) Then
    '            zReturn = Format(zRow.colLastRecentUpdate, "yyyyMMdd")
    '        End If
    '    Catch
    '        Return Date.Today.ToString("yyyyMMdd")
    '    End Try

    '    Return zReturn

    'End Function

    <Obsolete("Use UtilUpdate class instead", True)>
    Public Shared Sub SetLastRecentUpdateDate(ByVal pGUID As String)
        'Dim zEzyUserId As Integer = UtilGSafe.GetValue(pGUID, UtilGSafe.KeyName.EzyUserId)
        'Dim zRow As rowTblEzyUsers = TblEzyUsers.LoadByPrimaryKey(zEzyUserId)
        'zRow.colLastRecentUpdate = Now()
        'TblEzyUsers.Save(zRow)
    End Sub


    Public Shared Function ReplaceBaseString(ByVal pOriginalPath As String, ByVal pReplacer As String) As String
        ' DETERMINE IF WE ARE IN GC (GRC.CONNECT) OR STANDARD MODE
        Dim zSearchString = UtilNav.NavLinkPlaceholder
        Dim zModifier As String = ""
        Dim zActualPath As String = HttpContext.Current.Request.ApplicationPath
        ' MAKE THE REPLACEMENT
        Dim zReturn As String = ""
        If Not pOriginalPath Is Nothing Then
            zReturn = pOriginalPath.Replace(zSearchString, zModifier & pReplacer)
        End If
        Return zReturn
    End Function


    Public Shared Function GetNavMenuTextSitemap(ByVal pItem As razor.rowViewCCGSafeSitemapItems, ByVal pGSafeGuid As String) As String
        Dim zReturn As String = ""
        Dim zDebugMode As Boolean = Diagnostics.Debugger.IsAttached
        'If GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Then ' Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Then
        '    zDebugMode = True
        'End If

        Try
            Dim zSpanEnd As String = "</span>"
            Dim zSpanOutsideClass As String = ""
            Dim zSpace As String = "&nbsp;"
            Dim zTitle As String = ""
            Dim zDebugText As String = ""
            Dim zOnClick As String = ""
            Dim zURL As String = ""
            Dim zAnchor As String = ""
            Dim zIcon As String = ""
            Dim zSeparator As String = "&"
            Dim zIsFunctionAdded As Boolean = False

            'BOLD CURRENT PAGE
            Dim zCurrentPage As String = Val(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.currentPage))
            If pItem.colNavLinkId = zCurrentPage Then
                zSpanOutsideClass = zSpanOutsideClass & " menuSelected"
            End If

            ' SET THE TARGETS AND CLICK FUNCTIONS IF NEEDED " & pItem & "
            If Not pItem.colNavTarget Is Nothing Then

                If pItem.colNavTarget <> "" Then
                    Dim zTarget = pItem.colNavTarget
                    ' GET THE GSAFE GUID
                    zURL = GRC.Connect.Libraries.CoreLib.UtilURL.BuildLeftNavURL(pItem.colNavLinkId, pItem.colNavUrl, pGSafeGuid)

                    ' MAKE CORRECTIONS TO THE TARGET FIELD - SET THE NODE TARGET FOR SINGLE REPORT SERVE
                    If zURL.ToLower().Contains("/reports/") Then
                        zTarget = "reports"
                    End If

                    ' SET THE CLICK FUNCTION TO BE USED
                    Dim zFunction As String = ""
                    Select Case zTarget.ToLower()
                        Case "charts"
                            zFunction = "openChartPrefilter('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavRptCode & "')"
                        Case "reports"
                            zURL = zURL & "&action=PrintLocationReport"
                            zFunction = "openReportPopup('" & zURL & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavRptCode & "')"
                        Case "programstatus"
                            zFunction = "onOpenProgramStatusWindow('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavRptCode & "')"
                        Case "recfollowupstatus"
                            zFunction = "onOpenRecFollowUpStatusWindow('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavRptCode & "')"
                        Case "whatsnew"
                            zFunction = "openRequestedWhatsNew('" & zURL & "', '" & pItem.colNavLinkId & "')"
                        Case "search"
                            Dim zMode As String = "&mo=l"
                            If GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Then
                                zMode = "&mo=t"
                            End If
                            zFunction = "searchLinkClick('" & zURL & zMode & "', '" & pItem.colNavLinkId & "')"
                        Case "searchlatlongfacility"
                            zFunction = "searchLatLongLinkClick('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "')"
                        Case "_blank"
                            zFunction = "openRequestedSinglePopup('" & zURL & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavRptCode & "')"
                        Case Else
                            ' DO NOTHING
                    End Select
                    If zFunction.Length > 0 Then
                        zOnClick = "onclick=""" & zFunction & "; return false;"""
                        zIsFunctionAdded = True
                    End If
                End If
            End If

            ' BUILD THE URL
            If Not pItem.colNavUrl Is Nothing And pItem.colNavUrl <> "" Then
                If zIsFunctionAdded = False Then
                    ' GET THE GSAFE GUID
                    zURL = GRC.Connect.Libraries.CoreLib.UtilURL.BuildLeftNavURL(pItem.colNavLinkId, pItem.colNavUrl, pGSafeGuid)

                    ' IF EXIST, ADD THE CHART, REPORT, GRID, AND EXTRACT IDs
                    If Not pItem.colNavGridId Is Nothing Then
                        If pItem.colNavGridId > 0 Then zURL = zURL & zSeparator & "gridId=" & pItem.colNavGridId
                    End If
                    If Not pItem.colNavChartId Is Nothing Then
                        If pItem.colNavChartId > 0 Then zURL = zURL & zSeparator & "chartId=" & pItem.colNavChartId
                    End If
                    If Not pItem.colNavRptCode Is Nothing And pItem.colNavRptCode <> "" Then
                        If CInt(pItem.colNavRptCode) > 0 Then zURL = zURL & zSeparator & "reportId=" & pItem.colNavRptCode
                    End If
                    If Not pItem.colNavExtractId Is Nothing Then
                        If pItem.colNavExtractId > 0 Then zURL = zURL & zSeparator & "extractId=" & pItem.colNavExtractId
                    End If

                    ' BUILD THE ANCHOR TAG
                    zAnchor = "<a class='k-link" & zSpanOutsideClass & "' href='" & zURL & "' target='" & pItem.colNavTarget & "'>" & pItem.colNavText & "</a>"
                Else
                    ' LET THE SPAN ON CLICK FUNCTION DO THE WORK INSTEAD
                    zAnchor = "<a class='k-link" & zSpanOutsideClass & "' href='#'>" & pItem.colNavText & "</a>"
                End If
            Else
                zAnchor = pItem.colNavText
            End If

            ' DO WE NEED AN ICON?
            If Not pItem.colSlideImageClassName Is Nothing Then
                If pItem.colSlideImageClassName.Length > 0 Then
                    Dim zSpanInside As String = "<span class='menuIcon " & pItem.colSlideImageClassName & "'>"
                    zIcon = zSpanInside & zSpace & zSpanEnd
                End If
            End If

            ' FOR DEBUGGING AND TESTING
            If zDebugMode Then
                zTitle = ""
                zTitle = zTitle & "NavLink Id: " & pItem.colNavLinkId & "&#10;"
                zTitle = zTitle & "Slide Menu Id: " & pItem.colSlideMenuId & "&#10;"
                zTitle = zTitle & "Slide Group Id: " & pItem.colSlideGroupId & "&#10;"
                zTitle = zTitle & "Slide Parent Id: " & pItem.colSlideParentId & "&#10;"
                zTitle = zTitle & "Slide Order: " & pItem.colSlideOrder & "&#10;"
                zTitle = zTitle & "Nav Target: " & pItem.colNavTarget & "&#10;"
                zTitle = zTitle & "Nav Chart Id: " & pItem.colNavChartId & "&#10;"
                zTitle = zTitle & "Nav Grid Id: " & pItem.colNavGridId & "&#10;"
                zTitle = zTitle & "Nav Extract Id: " & pItem.colNavExtractId & "&#10;"
                zTitle = " title='" & zTitle & "' "
                zDebugText = "<label style='font-size:6pt;'>"
                zDebugText = zDebugText & " NavId: " & pItem.colNavLinkId
                zDebugText = zDebugText & " SlideId: " & pItem.colSlideMenuId
                zDebugText = zDebugText & "</label>"
            End If

            ' BUILD THE TEXT
            zReturn = "<span class='menuItem" & zSpanOutsideClass & "' " & zTitle & " " & zOnClick & ">" & zIcon & zAnchor & zDebugText & zSpanEnd

        Catch ex As Exception
            zReturn = "<span class='colorRed' title='" & ex.Message & "'>ERROR</span>"
        End Try

        Return zReturn
    End Function


    Public Shared Function GetNavMenuTextNavLink(ByVal pItem As razor.rowTblNavLink, ByVal pGSafeGuid As String) As String
        Dim zReturn As String = ""
        Dim zDebugMode As Boolean = Diagnostics.Debugger.IsAttached
        'If GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Then ' Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Then
        '    zDebugMode = True
        'End If

        Try
            Dim zSpanEnd As String = "</span>"
            Dim zSpanOutsideClass As String = ""
            Dim zSpace As String = "&nbsp;"
            Dim zTitle As String = ""
            Dim zDebugText As String = ""
            Dim zOnClick As String = ""
            Dim zURL As String = ""
            Dim zAnchor As String = ""
            Dim zIcon As String = ""
            Dim zSeparator As String = "&"
            Dim zIsFunctionAdded As Boolean = False

            'BOLD CURRENT PAGE
            Dim zCurrentPage As String = Val(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.currentPage))
            If pItem.colNavLinkId = zCurrentPage Then
                zSpanOutsideClass = zSpanOutsideClass & " menuSelected"
            End If

            ' SET THE TARGETS AND CLICK FUNCTIONS IF NEEDED " & pItem & "
            If Not pItem.colNavTarget Is Nothing Then
                If pItem.colNavTarget <> "" Then
                    Dim zTarget = pItem.colNavTarget
                    ' GET THE GSAFE GUID
                    zURL = GRC.Connect.Libraries.CoreLib.UtilURL.BuildLeftNavURL(pItem.colNavLinkId, pItem.colNavUrl, pGSafeGuid)

                    If zURL.ToLower().Contains("/reports/") Then
                        zTarget = "reports"
                    End If

                    ' SET THE CLICK FUNCTION TO BE USED
                    Dim zFunction As String = ""
                    Select Case zTarget.ToLower()
                        Case "charts"
                            zFunction = "openChartPrefilter('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavReportId & "')"
                        Case "reports"
                            zURL = zURL & "&action=PrintLocationReport"
                            zFunction = "openReportPopup('" & zURL & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavReportId & "')"
                        Case "programstatus"
                            zFunction = "onOpenProgramStatusWindow('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavReportId & "')"
                        Case "recfollowupstatus"
                            zFunction = "onOpenRecFollowUpStatusWindow('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavReportId & "')"
                        Case "whatsnew"
                            zFunction = "openRequestedWhatsNew('" & zURL & "', '" & pItem.colNavLinkId & "')"
                        Case "search"
                            zFunction = "searchLinkClick('" & zURL & "', '" & pItem.colNavLinkId & "')"
                        Case "searchlatlongfacility"
                            zFunction = "searchLatLongLinkClick('" & zURL & "', '" & pItem.colNavLinkId & "', '" & pItem.colNavGridId & "')"
                        Case "_blank"
                            zFunction = "openRequestedSinglePopup('" & zURL & "', '" & pItem.colNavGridId & "', '" & pItem.colNavChartId & "', '" & pItem.colNavReportId & "')"
                        Case Else
                            ' DO NOTHING
                    End Select
                    If zFunction.Length > 0 Then
                        zOnClick = "onclick=""" & zFunction & "; return false;"""
                        zIsFunctionAdded = True
                    End If
                End If
            End If

            ' BUILD THE URL
            If Not pItem.colNavUrl Is Nothing And pItem.colNavUrl <> "" Then
                If zIsFunctionAdded = False Then
                    ' GET THE GSAFE GUID
                    zURL = GRC.Connect.Libraries.CoreLib.UtilURL.BuildLeftNavURL(pItem.colNavLinkId, pItem.colNavUrl, pGSafeGuid)

                    ' IF EXIST, ADD THE CHART, REPORT, GRID, AND EXTRACT IDs
                    If Not pItem.colNavGridId Is Nothing Then
                        If pItem.colNavGridId > 0 Then zURL = zURL & zSeparator & "gridId=" & pItem.colNavGridId
                    End If
                    If Not pItem.colNavChartId Is Nothing Then
                        If pItem.colNavChartId > 0 Then zURL = zURL & zSeparator & "chartId=" & pItem.colNavChartId
                    End If
                    If Not pItem.colNavReportId Is Nothing And pItem.colNavReportId <> "" Then
                        If CInt(pItem.colNavReportId) > 0 Then zURL = zURL & zSeparator & "reportId=" & pItem.colNavReportId
                    End If
                    If Not pItem.colNavExtractId Is Nothing Then
                        If pItem.colNavExtractId > 0 Then zURL = zURL & zSeparator & "extractId=" & pItem.colNavExtractId
                    End If

                    ' BUILD THE ANCHOR TAG
                    zAnchor = "<a class='k-link" & zSpanOutsideClass & "' href='" & zURL & "' target='" & pItem.colNavTarget & "'>" & pItem.colNavText & "</a>"
                Else
                    ' LET THE SPAN ON CLICK FUNCTION DO THE WORK INSTEAD
                    zAnchor = "<a class='k-link" & zSpanOutsideClass & "' href='#'>" & pItem.colNavText & "</a>"
                End If
            Else
                zAnchor = pItem.colNavText
            End If

            ' DO WE NEED AN ICON?
            If Not pItem.colSlideImageClassName Is Nothing Then
                If pItem.colSlideImageClassName.Length > 0 Then
                    Dim zSpanInside As String = "<span class='menuIcon " & pItem.colSlideImageClassName & "'>"
                    zIcon = zSpanInside & zSpace & zSpanEnd
                End If
            End If

            ' FOR DEBUGGING AND TESTING
            If zDebugMode Then
                zTitle = ""
                zTitle = zTitle & "NavLink Id: " & pItem.colNavLinkId & "&#10;"
                zTitle = zTitle & "Slide Menu Id: " & pItem.colSlideMenuId & "&#10;"
                zTitle = zTitle & "Slide Group Id: " & pItem.colSlideGroupId & "&#10;"
                zTitle = zTitle & "Slide Parent Id: " & pItem.colSlideParentId & "&#10;"
                zTitle = zTitle & "Slide Order: " & pItem.colSlideOrder & "&#10;"
                zTitle = zTitle & "Nav Target: " & pItem.colNavTarget & "&#10;"
                zTitle = zTitle & "Nav Chart Id: " & pItem.colNavChartId & "&#10;"
                zTitle = zTitle & "Nav Grid Id: " & pItem.colNavGridId & "&#10;"
                zTitle = zTitle & "Nav Extract Id: " & pItem.colNavExtractId & "&#10;"
                zTitle = " title='" & zTitle & "' "
                zDebugText = "<label style='font-size:6pt;'>"
                zDebugText = zDebugText & " NavId: " & pItem.colNavLinkId
                zDebugText = zDebugText & " SlideId: " & pItem.colSlideMenuId
                zDebugText = zDebugText & "</label>"
            End If

            ' BUILD THE TEXT
            zReturn = "<span class='menuItem" & zSpanOutsideClass & "' " & zTitle & " " & zOnClick & ">" & zIcon & zAnchor & zDebugText & zSpanEnd

        Catch ex As Exception
            zReturn = "<span class='colorRed' title='" & ex.Message & "'>ERROR</span>"
        End Try

        Return zReturn
    End Function


    Public Shared Function SetAllMenuItemsSitemap(pGSafeGuid As String, pPageType As String) As Boolean
        'Dim zResponse As New jsResponse(Of ViewCCGSafeSitemapItemsCollection, ViewCCGSafeSitemapItems)()
        'pPageType = 1 --> All or Top
        'pPAgeType = 2 --> All or Side

        Dim zSW As New Stopwatch
        zSW.Start()

        Dim zReturn As Boolean = False
        Dim zMenuJSON As String
        Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)
        Dim zReturnList As New List(Of Object)
        Dim zPageType As String = pPageType.ToLower()

        Try
            ' GET INFORMATION ABOUT THE USER
            Dim zIsDocumentAccess As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.DocumentAccess))
            Dim zIsRiskManager As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.RiskManager))
            Dim zIsInternal As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.Internal))
            Dim zIsPlantManager As Boolean = Convert.ToBoolean(UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.PlantManager))

            ' GET THE LIST OF SITEMAP ITEMS

            If zIsPlantManager Then
                'do nothing and return empty array
            Else
                Dim zQ As New razor.queryViewCCGSafeSitemapItems
                zQ.SelectAll()
                zQ.Where.Add(zQ.colNavVisible.NotEqual(False))
                zQ.Where.Add(zQ.colGSafeId.Equals(zGSafeId))
                zQ.Where.Or(zQ.colSlideType.Equals(zPageType), zQ.colSlideType.Equals("all"))
                zQ.OrderBy(zQ.colSlideLevelId.Descending)
                Dim zList As New List(Of razor.rowViewCCGSafeSitemapItems)
                zList = razor.ViewCCGSafeSitemapItems.LoadData(zQ.QueryText)
                Diagnostics.Trace.WriteLine("SetAllMenuItemsSitemap [Get List] elapsed: " & zSW.Elapsed.ToString)

                If zList.Count > 0 Then
                    If zList.Count = 0 Then
                        ' IF NO RECORDS REPORT NOT FOUND
                        Return zReturn
                    Else
                        ' REPLACE THE HOME FOLDER WITH THE VERSION STAMPED FOLDER
                        Dim zNoChildRecId As New List(Of Integer)
                        Dim zAllData As New List(Of Dictionary(Of String, Object))
                        For Each zItem As razor.rowViewCCGSafeSitemapItems In zList

                            Dim zIsExclude As Boolean = False
                            ' ONLY ALLOW DOCUMENT MANAGERS, RISK MANAGERS, AND INTERNAL EMPLOYEES TO VIEW THE SEARCH ENGINE LINK
                            If (zItem.colNavTarget & "").ToLower() = "search" Then
                                If zIsDocumentAccess = False And zIsRiskManager = False And zIsInternal = False Then
                                    zIsExclude = True
                                End If
                            End If

                            If Not zIsExclude Then
                                'Create the generic dictionary for each row
                                Dim zDict As New Dictionary(Of String, Object)
                                zDict.Add("slideMenuId", zItem.colSlideMenuId)
                                zDict.Add("slideParentId", zItem.colSlideParentId)
                                zDict.Add("slideOrder", zItem.colSlideOrder)
                                zDict.Add("NavLinkId", zItem.colNavLinkId)
                                zDict.Add("NavParentLinkId", Nothing)
                                zDict.Add("NavOrder", Nothing)
                                zDict.Add("encoded", False)
                                zDict.Add("text", UtilNav.GetNavMenuTextSitemap(zItem, pGSafeGuid))
                                zDict.Add("cssClass", Nothing)
                                zDict.Add("url", Nothing)
                                zDict.Add("imageUrl", Nothing)
                                zDict.Add("items", Nothing)

                                'If a record does not have any children, then add it to the RootList
                                If GetChildRecordsSitemap(zItem.colSlideMenuId, zItem.colSlideLevelId, zList).Count = 0 Then
                                    zNoChildRecId.Add(zItem.colSlideMenuId)
                                End If

                                'Add the dictionary to the list of all records
                                zAllData.Add(zDict)
                            End If

                        Next
                        Diagnostics.Trace.WriteLine("SetAllMenuItemsSitemap [Build Dictionary] elapsed: " & zSW.Elapsed.ToString)


                        'Dim zNoChildrenFound As Boolean = False

                        '5.5~ Seconds to run this block of code
                        For Each rootId In zNoChildRecId
                            For Each zItem In zAllData
                                If rootId = zItem("slideMenuId") Then
                                    CreateChainSitemap(zItem, zAllData)
                                    Exit For
                                End If
                            Next
                        Next
                        Diagnostics.Trace.WriteLine("SetAllMenuItemsSitemap [CreateChainSitemap] elapsed: " & zSW.Elapsed.ToString)


                        For Each record In zAllData
                            If record("slideParentId") = 0 Then
                                zReturnList.Add(record)
                            End If
                        Next

                        bubbleSortSitemap(zReturnList, zReturnList.Count)
                        Diagnostics.Trace.WriteLine("SetAllMenuItemsSitemap [BubbleSortSitemap] elapsed: " & zSW.Elapsed.ToString)

                        zSW.Stop()
                        zSW = Nothing
                    End If
                End If
            End If
            zMenuJSON = Newtonsoft.Json.JsonConvert.SerializeObject(zReturnList)

            'Add row with the zGSafeId and zMenuJSON
            Dim zSlideRow As New rowTblGSafeSlideMenu
            zSlideRow.colGSafeId = zGSafeId
            zSlideRow.colSlideMenuJSON = zMenuJSON
            zSlideRow.colSlideType = zPageType
            TblGSafeSlideMenu.Save(zSlideRow)

        Catch ex As Exception
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.LoggedInUserEmail), ex.Message, "UtilNav.vb", "SetAllMenuItemsSitemap() Exception", HttpContext.Current.Request.ServerVariables("REMOTE_ADDR"))
            Return zReturn
        End Try

        'Set the Return value to True
        zReturn = True
        Return zReturn
    End Function

    Public Shared Function GetChildren(pSlideMenuId As Integer, zAllData As List(Of Dictionary(Of String, Object))) As List(Of Dictionary(Of String, Object))
        Dim zList As List(Of Dictionary(Of String, Object)) = zAllData.FindAll(Function(x) x("slideParentId") = pSlideMenuId).ToList.OrderBy(Function(x) x("slideOrder")).ToList
        Return zList
    End Function

    Public Shared Function GetPageMenuItems(pGSafeGuid As String) As List(Of Object)
        Dim zReturn As New List(Of Object)
        Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)

        Try
            ' GETHER NEEDED INFORMATION FOR THE DATA PULL
            Dim zSpecialFeatures = UtilGSafe.GetValue(zGSafeId, UtilGSafe.KeyName.clientFeatures)
            Dim zCurrentPage As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.currentPage)
            Dim zPageLink As New NavLink()
            zPageLink.LoadByPrimaryKey(zCurrentPage)
            Dim zCurrentLevelId As Integer = zPageLink.NavLevelId
            Dim zPracticeId As Integer = zPageLink.NavPracticeID
            ' GET THE SPECIFIC LIST FOR THE CURRENT PAGE AND PRACTICE
            Dim zQuery As New razor.queryTblNavLink
            Dim zList As New List(Of razor.rowTblNavLink)
            zQuery.SelectAll()
            ' zQuery.Where.Add(zQuery.colNavLevelId.Equals(zCurrentLevelId))
            zQuery.Where.Add(zQuery.colNavPracticeID.Equals(zPracticeId))
            zQuery.Where.Add(zQuery.colSlideType.Contains(NavLink.SlideMenuTypes.Practice, False))
            zQuery.Where.Add(zQuery.colNavVisible.Equals(True))
            zQuery.Where.OpenParen()
            zQuery.Where.Or(zQuery.colNavSpcFeature.IsNull, zQuery.colNavSpcFeature.Equals(""))
            zQuery.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.Or)
            zSpecialFeatures.ToCharArray.ToList.ForEach(Sub(x) zQuery.Where.Or(zQuery.colNavSpcFeature.Contains(x)))
            zQuery.Where.CloseParen()
            zList = razor.TblNavLink.LoadData(zQuery.QueryText)

            ' LOOP THROUGH THE RECORDS TO NEST CHILDS INTO PARENTS
            If zList.Count > 0 Then
                If zList.Count = 0 Then
                    ' IF NO RECORDS REPORT NOT FOUND
                    Return zReturn
                Else
                    ' REPLACE THE HOME FOLDER WITH THE VERSION STAMPED FOLDER
                    Dim zNoChildRecId As New List(Of Integer)
                    Dim zAllData As New List(Of Dictionary(Of String, Object))
                    For Each zItem As razor.rowTblNavLink In zList
                        'Create the generic dictionary for each row
                        Dim zDict As New Dictionary(Of String, Object)
                        zDict.Add("slideMenuId", zItem.colSlideMenuId)
                        zDict.Add("slideParentId", zItem.colSlideParentId)
                        zDict.Add("slideOrder", zItem.colSlideOrder)
                        zDict.Add("NavLinkId", zItem.colNavLinkId)
                        zDict.Add("NavParentLinkId", zItem.colNavParentLinkId)
                        zDict.Add("NavOrder", zItem.colNavOrder)
                        zDict.Add("encoded", False)
                        zDict.Add("text", UtilNav.GetNavMenuTextNavLink(zItem, pGSafeGuid))
                        zDict.Add("cssClass", Nothing)
                        zDict.Add("url", Nothing)
                        zDict.Add("imageUrl", Nothing)
                        zDict.Add("items", Nothing)

                        'If a record does not have any children, then add it to the RootList
                        If GetChildRecordsNavLink(zItem.colSlideMenuId, zItem.colSlideLevelId, zList).Count = 0 Then

                            zNoChildRecId.Add(zItem.colSlideMenuId)

                        End If

                        'Add the dictionary to the list of all records
                        zAllData.Add(zDict)

                    Next
                    'Dim zNoChildrenFound As Boolean = False

                    '5.5~ Seconds to run this block of code
                    For Each rootId In zNoChildRecId
                        For Each zItem In zAllData
                            If rootId = zItem("slideMenuId") Then
                                CreateChainSitemap(zItem, zAllData)
                                Exit For
                            End If
                        Next
                    Next

                    For Each record In zAllData
                        If record("slideParentId") = 0 Then
                            zReturn.Add(record)
                        End If
                    Next

                    bubbleSortSitemap(zReturn, zReturn.Count)
                End If
            End If

        Catch ex As Exception
            zReturn = New List(Of Object)
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.LoggedInUserEmail), ex.Message, "UtilNav.vb", "GetPageMenuItems() Exception", HttpContext.Current.Request.ServerVariables("REMOTE_ADDR"))
            Throw New Exception(ex.Message & " | See error log table for details.")
        End Try

        Return zReturn
    End Function


    Private Shared Function GetChildRecordsSitemap(MenuId As Integer, zLevel As Integer, zColl As List(Of razor.rowViewCCGSafeSitemapItems)) As List(Of razor.rowViewCCGSafeSitemapItems)
        'REWORKED LOGIC TO IMPROVE PERFORMANCE
        Return zColl.FindAll(Function(x) x.colSlideParentId IsNot Nothing And x.colSlideParentId = MenuId And x.colSlideLevelId = zLevel)

        'Dim zReturn As New List(Of Integer)
        'For Each zItem In zColl
        '    If zItem.colSlideParentId = MenuId Then zReturn.Add(zItem.colSlideMenuId)
        '    If zItem.colSlideLevelId = zLevel Then Return zReturn
        'Next
        'Return zReturn
    End Function


    Private Shared Function GetChildRecordsNavLink(MenuId As Integer, zLevel As Integer, zColl As List(Of razor.rowTblNavLink)) As List(Of razor.rowTblNavLink)
        'REWORKED LOGIC TO IMPROVE PERFORMANCE
        Return zColl.FindAll(Function(x) x.colSlideParentId IsNot Nothing And x.colSlideParentId = MenuId And x.colSlideLevelId = zLevel)

        'Dim zReturn As New List(Of Integer)
        'For Each zItem In zColl
        '    If zItem.colSlideParentId = MenuId Then zReturn.Add(zItem.colSlideMenuId)
        '    If zItem.colSlideLevelId = zLevel Then Return zReturn
        'Next
        'Return zReturn
    End Function

    Private Shared Sub CreateChainSitemap2(ByRef zAllData As List(Of Dictionary(Of String, Object)), Optional zItem As Dictionary(Of String, Object) = Nothing)
        If IsNothing(zItem) Then zItem = zAllData.Find(Function(x) x("slideParentId") = 0)
        Trace.WriteLine(zItem("text") & " [" & zItem("slideMenuId") & "]")
        zItem("items") = GetChildren(zItem("slideMenuId"), zAllData)
        Trace.Indent()
        DirectCast(zItem("items"), List(Of Dictionary(Of String, Object))).ForEach(Sub(x) Trace.WriteLine(x("text") & " [" & x("slideParentId") & "]"))
        Trace.Unindent()
        For Each x As Dictionary(Of String, Object) In zItem("items")
            CreateChainSitemap2(zAllData, x)
        Next

        'If  Then
        '    Dim zParentItem As Dictionary(Of String, Object) = zAllData.ToList.Find(Function(x) x("slideMenuId") = zItem("slideParentId"))
        '    If zParentItem("items") Is Nothing Then zParentItem("items") = New List(Of Object)
        '    If Not zParentItem("items").Contains(zItem) Then zParentItem("items").Add(zItem)
        '    CreateChainSitemap2(zParentItem, zAllData)
        'End If

    End Sub

    Private Shared Sub CreateChainSitemap(record As Dictionary(Of String, Object), ByRef zAllData As List(Of Dictionary(Of String, Object)))
        If record("slideParentId") = 0 Then
            'Top level container
            'Exit the loop	-->		
            Exit Sub
        Else
            For Each parentRecord In zAllData
                If record("slideParentId") = parentRecord("slideMenuId") Then
                    If parentRecord("items") Is Nothing Then
                        Dim zNewList As New List(Of Object)
                        parentRecord("items") = zNewList
                    End If
                    If parentRecord("items").Contains(record) Then
                        'Don't do anything since the record does not exist

                    Else
                        'Add the record
                        parentRecord("items").Add(record)
                        If parentRecord("items").Count <> 0 Then
                            'Sort the List
                            bubbleSortSitemap(parentRecord("items"), parentRecord("items").Count)
                        End If
                    End If
                    CreateChainSitemap(parentRecord, zAllData)   'Recurrsive function
                End If
            Next
        End If
        '    End If
        'Next
    End Sub


    Private Shared Sub CreateChainNavLink(record As Dictionary(Of String, Object), ByRef zAllData As List(Of Object))
        If record("NavParentLinkId") = 0 Then
            'Top level container
            'Exit the loop	-->		
            Exit Sub
        Else
            For Each parentRecord In zAllData
                If record("NavParentLinkId") = parentRecord("NavLinkId") Then
                    If parentRecord("items") Is Nothing Then
                        Dim zNewList As New List(Of Object)
                        parentRecord("items") = zNewList
                    End If
                    If parentRecord("items").Contains(record) Then
                        'Don't do anything since the record does not exist

                    Else
                        'Add the record
                        parentRecord("items").Add(record)
                        If parentRecord("items").Count <> 0 Then
                            'Sort the List
                            bubbleSortNavLink(parentRecord("items"), parentRecord("items").Count)
                        End If
                    End If
                    CreateChainNavLink(parentRecord, zAllData)   'Recurrsive function
                End If
            Next
        End If
    End Sub


    Private Shared Sub bubbleSortSitemap(ByRef dataset As List(Of Object), ByVal n As Integer)
        Dim i, j As Integer
        For i = 0 To n Step 1
            For j = n - 1 To i + 1 Step -1
                If (dataset(j)("slideOrder") < dataset(j - 1)("slideOrder")) Then
                    Dim temp As Object = dataset(j)
                    dataset(j) = dataset(j - 1)
                    dataset(j - 1) = temp
                End If
            Next
        Next
    End Sub


    Private Shared Sub bubbleSortNavLink(ByRef dataset As List(Of Object), ByVal n As Integer)
        Dim i, j As Integer
        For i = 0 To n Step 1
            For j = n - 1 To i + 1 Step -1
                If (dataset(j)("NavOrder") < dataset(j - 1)("NavOrder")) Then
                    Dim temp As Object = dataset(j)
                    dataset(j) = dataset(j - 1)
                    dataset(j - 1) = temp
                End If
            Next
        Next
    End Sub


End Class
