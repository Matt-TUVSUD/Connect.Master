Imports GRC.Connect.Libraries.CoreLib.DataSetExtensions

Public Class UtilMenu

    Dim data As DataSet = Nothing

    Dim mode As UtilSetting.AppMode

    Public Function GetMenu(safeGuid As String, mode As UtilSetting.AppMode) As List(Of Object)

        data = GetData(safeGuid)

        Me.mode = mode

        Dim zLinks As List(Of DataRow) = ExtractLinks(data)

        Return BuildMenu(zLinks, safeGuid)

    End Function

    Private Function BuildMenu(rowList As List(Of DataRow), safeGuid As String) As List(Of Object)

        Dim returnList As New List(Of Object)

        Dim zSW As New Stopwatch

        zSW.Start()

        Try
            ' GET INFORMATION ABOUT THE USER
            Dim zIsDocumentAccess As Boolean = Convert.ToBoolean(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.DocumentAccess))
            Dim zIsRiskManager As Boolean = Convert.ToBoolean(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.RiskManager))
            Dim zIsInternal As Boolean = Convert.ToBoolean(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.Internal))
            Dim zIsPlantManager As Boolean = Convert.ToBoolean(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.PlantManager))


            If rowList.Count > 0 Then

                Dim zNoChildRecId As New List(Of Integer)

                Dim zAllData As New List(Of Dictionary(Of String, Object))

                For Each zItem As DataRow In rowList

                    Dim zIsExclude As Boolean = False

                    ' ONLY ALLOW DOCUMENT MANAGERS, RISK MANAGERS, AND INTERNAL EMPLOYEES TO VIEW THE SEARCH ENGINE LINK
                    If (zItem("NavTarget") & "").ToLower() = "search" Then
                        If zIsDocumentAccess = False And zIsRiskManager = False And zIsInternal = False Then
                            zIsExclude = True
                        End If
                    End If

                    If Not zIsExclude Then

                        'Create the generic dictionary for each row
                        Dim zDict As New Dictionary(Of String, Object)
                        zDict.Add("slideMenuId", zItem("SlideMenuId"))
                        zDict.Add("slideParentId", IIf(zItem("SlideParentId") = 0, Nothing, zItem("SlideParentId")))
                        zDict.Add("slideOrder", zItem("SlideOrder"))
                        zDict.Add("NavLinkId", zItem("NavLinkId"))
                        zDict.Add("NavParentLinkId", Nothing)
                        zDict.Add("NavOrder", Nothing)
                        zDict.Add("encoded", False)
                        zDict.Add("text", SetLinkAttributes(zItem, safeGuid))
                        zDict.Add("cssClass", Nothing)
                        zDict.Add("url", Nothing)
                        zDict.Add("imageUrl", Nothing)
                        zDict.Add("items", Nothing)
                        zDict.Add("NavText", zItem("NavText"))

                        '  If a record does not have any children, then add it to the RootList
                        Dim rows As List(Of DataRow) = data.GetTable(DataTableNames.Names.Menu).Select.ToList().FindAll(Function(x) x("SlideParentId") = zItem("SlideMenuId"))

                        If rows.Count = 0 Then
                            zNoChildRecId.Add(zItem("SlideMenuId"))
                        End If

                        'Add the dictionary to the list of all records
                        zAllData.Add(zDict)

                    End If

                Next

                If zIsPlantManager Then

                    returnList.Add(zAllData.Find(Function(x) x("NavText") = "Services"))
                    returnList.Add(zAllData.Find(Function(x) x("NavText") = "Reports"))


                Else

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
                            returnList.Add(record)
                        End If
                    Next

                    bubbleSortSitemap(returnList, returnList.Count)
                End If

            End If

            Return returnList

        Catch ex As Exception
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog : zErrLog.CreateSimpleErrorLogRecord(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.LoggedInUserEmail), ex.Message, "UtilNav.vb", "SetAllMenuItemsSitemap() Exception", HttpContext.Current.Request.ServerVariables("REMOTE_ADDR"))
            Return Nothing
        End Try

    End Function

    Private Function SetLinkAttributes(ByVal pItem As DataRow, ByVal pGSafeGuid As String) As String
        Dim zReturn As String = ""

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
            Dim zCurrentPage As String = Val(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.currentPage))

            If pItem("NavLinkId") = zCurrentPage Then
                zSpanOutsideClass = zSpanOutsideClass & " menuSelected"
            End If

            ' SET THE TARGETS AND CLICK FUNCTIONS IF NEEDED " & pItem & "
            If Not IsDBNull(pItem("NavTarget")) Then

                If pItem("NavTarget") <> "" Then

                    Dim zTarget = pItem("NavTarget")
                    ' GET THE GSAFE GUID
                    zURL = BuildLeftNavURL(pItem("NavLinkId"), pItem("NavUrl"), pGSafeGuid)

                    ' MAKE CORRECTIONS TO THE TARGET FIELD - SET THE NODE TARGET FOR SINGLE REPORT SERVE
                    If zURL.ToLower().Contains("/reports/") Then
                        zTarget = "reports"
                    End If

                    ' SET THE CLICK FUNCTION TO BE USED
                    Dim zFunction As String = ""
                    Select Case zTarget.ToLower()
                        Case "charts"
                            zFunction = "openChartPrefilter('" & zURL & "', '" & pItem("NavLinkId") & "', '" & pItem("NavGridId") & "', '" & pItem("NavChartId") & "', '" & pItem("NavRptCode") & "')"
                        Case "reports"
                            zURL = zURL & "&action=PrintLocationReport"
                            zFunction = "openReportPopup('" & zURL & "', '" & pItem("NavGridId") & "', '" & pItem("NavChartId") & "', '" & pItem("NavRptCode") & "')"
                        Case "programstatus"
                            zFunction = "onOpenProgramStatusWindow('" & zURL & "', '" & pItem("NavLinkId") & "', '" & pItem("NavGridId") & "', '" & pItem("NavChartId") & "', '" & pItem("NavRptCode") & "')"
                        Case "recfollowupstatus"
                            zFunction = "onOpenRecFollowUpStatusWindow('" & zURL & "', '" & pItem("NavLinkId") & "', '" & pItem("NavGridId") & "', '" & pItem("NavChartId") & "', '" & pItem("NavRptCode") & "')"
                        Case "whatsnew"
                            zFunction = "openRequestedWhatsNew('" & zURL & "', '" & pItem("NavLinkId") & "')"
                        Case "search"
                            Dim zMode As String = "&mo=l"
                            If mode = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Then
                                zMode = "&mo=t"
                            End If
                            zFunction = "searchLinkClick('" & zURL & zMode & "', '" & pItem("NavLinkId") & "')"
                        Case "searchlatlongfacility"
                            zFunction = "searchLatLongLinkClick('" & zURL & "', '" & pItem("NavLinkId") & "', '" & pItem("NavGridId") & "')"
                        Case "_blank"
                            zFunction = "openRequestedSinglePopup('" & zURL & "', '" & pItem("NavGridId") & "', '" & pItem("NavChartId") & "', '" & pItem("NavRptCode") & "')"
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
            If Not pItem("NavUrl") Is Nothing And pItem("NavUrl") <> "" Then
                If zIsFunctionAdded = False Then
                    ' GET THE GSAFE GUID
                    zURL = BuildLeftNavURL(pItem("NavLinkId"), pItem("NavUrl"), pGSafeGuid)

                    ' IF EXIST, ADD THE CHART, REPORT, GRID, AND EXTRACT IDs
                    If Not IsDBNull(pItem("NavGridId")) Then
                        If Not zURL.ToLower.Contains("gridid") Then
                            If pItem("NavGridId") > 0 Then zURL = zURL & zSeparator & "gridId=" & pItem("NavGridId")
                        End If
                    End If
                    If Not IsDBNull(pItem("NavChartId")) Then
                        If pItem("NavChartId") > 0 Then zURL = zURL & zSeparator & "chartId=" & pItem("NavChartId")
                    End If
                    If Not IsDBNull(pItem("NavRptCode")) And pItem("NavRptCode") <> "" Then
                        If CInt(pItem("NavRptCode")) > 0 Then zURL = zURL & zSeparator & "reportId=" & pItem("NavRptCode")
                    End If
                    If Not IsDBNull(pItem("NavExtractId")) Then
                        If pItem("NavExtractId") > 0 Then zURL = zURL & zSeparator & "extractId=" & pItem("NavExtractId")
                    End If

                    ' BUILD THE ANCHOR TAG
                    zAnchor = "<a class='k-link" & zSpanOutsideClass & "' href='" & zURL & "' target='" & pItem("NavTarget") & "'>" & pItem("NavText") & "</a>"
                Else
                    ' LET THE SPAN ON CLICK FUNCTION DO THE WORK INSTEAD
                    zAnchor = "<a class='k-link" & zSpanOutsideClass & "' href='#'>" & pItem("NavText") & "</a>"
                End If
            Else
                zAnchor = pItem("NavText")
            End If

            ' DO WE NEED AN ICON?
            If Not IsDBNull(pItem("SlideImageClassName")) Then
                If pItem("SlideImageClassName").Length > 0 Then
                    Dim zSpanInside As String = "<span class='menuIcon " & pItem("SlideImageClassName") & "'>"
                    zIcon = zSpanInside & zSpace & zSpanEnd
                End If
            End If

            '' FOR DEBUGGING AND TESTING
            'If zDebugMode Then
            '    zTitle = ""
            '    zTitle = zTitle & "NavLink Id: " & pItem.colNavLinkId & "&#10;"
            '    zTitle = zTitle & "Slide Menu Id: " & pItem.colSlideMenuId & "&#10;"
            '    zTitle = zTitle & "Slide Group Id: " & pItem.colSlideGroupId & "&#10;"
            '    zTitle = zTitle & "Slide Parent Id: " & pItem.colSlideParentId & "&#10;"
            '    zTitle = zTitle & "Slide Order: " & pItem.colSlideOrder & "&#10;"
            '    zTitle = zTitle & "Nav Target: " & pItem.colNavTarget & "&#10;"
            '    zTitle = zTitle & "Nav Chart Id: " & pItem.colNavChartId & "&#10;"
            '    zTitle = zTitle & "Nav Grid Id: " & pItem.colNavGridId & "&#10;"
            '    zTitle = zTitle & "Nav Extract Id: " & pItem.colNavExtractId & "&#10;"
            '    zTitle = " title='" & zTitle & "' "
            '    zDebugText = "<label style='font-size:6pt;'>"
            '    zDebugText = zDebugText & " NavId: " & pItem.colNavLinkId
            '    zDebugText = zDebugText & " SlideId: " & pItem.colSlideMenuId
            '    zDebugText = zDebugText & "</label>"
            'End If

            ' BUILD THE TEXT
            zReturn = "<span class='menuItem" & zSpanOutsideClass & "' " & zTitle & " " & zOnClick & ">" & zIcon & zAnchor & zDebugText & zSpanEnd

        Catch ex As Exception
            zReturn = "<span class='colorRed' title='" & ex.Message & "'>ERROR</span>"
        End Try

        Return zReturn
    End Function

    Private Function BuildLeftNavURL(pNavLinkId As Integer, pNavLinkURL As String, pSafeGUID As String) As String
        Dim zReturn As String = ""

        If InStr(pNavLinkURL, "?") > 0 Then
            zReturn = pNavLinkURL & "&sid=" & pSafeGUID & "&navLinkId=" & pNavLinkId
        Else
            zReturn = pNavLinkURL & "?sid=" & pSafeGUID & "&navLinkId=" & pNavLinkId
        End If

        ' CORRECT NEW FOLDER VERSIONING OF HOME AND REC RESPONSE FOLDERS
        zReturn = zReturn.Replace("/Home/", "/Home_{{VER}}/")
        zReturn = zReturn.Replace("/RecResponse/", "/RecResponse_{{VER}}/")

        Return zReturn
    End Function

    Private Sub CreateChainSitemap(record As Dictionary(Of String, Object), ByRef zAllData As List(Of Dictionary(Of String, Object)))
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

    Private Sub bubbleSortSitemap(ByRef dataset As List(Of Object), ByVal n As Integer)
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

    Private Function ExtractLinks(data As DataSet) As List(Of DataRow)

        'GET ALL STANDARD LINKS
        Dim zStandardLinks As List(Of DataRow) = data.GetTable(DataTableNames.Names.Menu).Select.ToList().FindAll(Function(x) x("NavSpcFeature") = "" And x("NavVisible") = 1)

        Dim zSpecialLinks As New List(Of DataRow)

        Dim zStandardIndexesToRemove As New List(Of Integer)

        'FOR EACH CLIENT FEATURE, FILL THE SPECIAL LINK LIST WITH LINKS
        Dim features As String = GetClientFeatures(data.GetTable(DataTableNames.Names.SafeDetails))

        features.ToCharArray.ToList.ForEach(Sub(feature) zSpecialLinks.AddRange(data.GetTable(DataTableNames.Names.Menu).Select.ToList().FindAll(Function(x) x("NavSpcFeature").ToString().Contains(feature))))

        'FOR EACH SPECIAL FEATURE LINK, REMOVE THE STARDARD LINK IF NEEDED
        zSpecialLinks.ForEach(Sub(spcLink) RemoveStandardLink(spcLink, zStandardLinks))

        zStandardLinks.AddRange(zSpecialLinks)

        'IF THE USER IS NOT A CLIENT ADMIN, REMOVE THE CLIENT ADMIN SPECIFIC LINKS
        Dim isAdmin As Boolean = Convert.ToBoolean(GetSafeValue(data.GetTable(DataTableNames.Names.SafeDetails), UtilGSafe.KeyName.IsClientAdmin))

        If isAdmin = False Then
            Dim zClientAdminLinks As New List(Of DataRow)

            zClientAdminLinks.AddRange(data.GetTable(DataTableNames.Names.Menu).Select.ToList.FindAll(Function(x) x("IsClientAdmin") = True))

            zClientAdminLinks.ForEach(Sub(spcLink) RemoveStandardLink(spcLink, zStandardLinks))

        End If

        'FOR ALL LINKS REPLACE THE _BASE_ PORTION OF URL WITH ACTUAL URL
        zStandardLinks.ForEach(Sub(x) ReplaceBaseString(x))

        Return zStandardLinks

    End Function

    Private Sub RemoveStandardLink(pSpcLink As DataRow, ByRef pStandardLinks As List(Of DataRow))
        Dim zLinkIndex As Integer = pStandardLinks.FindIndex(Function(x) x("NavParentLinkId") = pSpcLink("NavParentLinkId") And x("NavText") = pSpcLink("NavText"))
        If zLinkIndex > -1 Then
            pStandardLinks.RemoveAt(zLinkIndex)
        End If
    End Sub

    Private Sub ReplaceBaseString(ByRef pNavLink As DataRow)

        'DETERMINE IF WE ARE IN GC (GRC.CONNECT) OR STANDARD MODE
        Dim zSearchString = UtilNav.NavLinkPlaceholder
        Dim zModifier As String = ""
        Dim zActualPath As String = ""

        If Not IsNothing(HttpContext.Current) Then
            zActualPath = HttpContext.Current.Request.ApplicationPath
        End If

        ' MAKE THE REPLACEMENT
        If Not pNavLink("NavUrl") Is Nothing Then
            Dim v As String = Replace(pNavLink("NavUrl"), UtilNav.NavLinkPlaceholder, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}")

            If IsNothing(v) Then
                pNavLink("NavUrl") = ""
            Else
                pNavLink("NavUrl") = v
            End If

        End If

    End Sub

    Private Function GetData(safeGuid As String) As DataSet

        Dim sql As New StringBuilder()

        sql.Append("SELECT * FROM api.Menu;")

        sql.Append("SELECT * FROM GSafeDetail d INNER JOIN GSafeHeader h ON d.GSafeId=h.GSafeId WHERE h.GSafeGUID=@guid;")

        Dim con As New SqlClient.SqlConnection(UtilDB.ConnectionString)

        Dim cmd As New SqlClient.SqlCommand(sql.ToString(), con)

        cmd.Parameters.AddWithValue("@guid", safeGuid)

        Dim ds As New DataSet("Data")

        con.Open()
        Using con
            Using cmd
                ds.Load(cmd.ExecuteReader, LoadOption.OverwriteChanges, {DataTableNames.Menu, DataTableNames.SafeDetails})
            End Using
        End Using

        ds.GetTable(DataTableNames.Names.Menu).Columns("NavUrl").ReadOnly = False

        Return ds

    End Function

    Private Function GetClientFeatures(data As DataTable) As String

        Dim dv As DataView = data.AsDataView
        dv.RowFilter = "DataName='ClientFeatures'"

        Dim dt As DataTable = dv.ToTable()
        If dt.Rows.Count > 0 Then
            Dim v As Object = dt.Select.ToList().First.Item("DataValue")
            If IsDBNull(v) Then
                Return ""
            Else
                Return v
            End If
        Else
            Return ""
        End If

    End Function

    Private Function GetSafeValue(data As DataTable, dataName As String) As Boolean

        Dim dv As DataView = data.AsDataView
        dv.RowFilter = String.Format("DataName='{0}'", dataName)

        Dim dt As DataTable = dv.ToTable()
        If dt.Rows.Count > 0 Then
            Return CBool(dt.Select.ToList().First.Item("DataValue"))
        Else
            Return False
        End If

    End Function

    Private Function GetSafeId(data As DataTable) As Integer
        Return data.Rows(0)("GSafeId")
    End Function

    Protected Friend Class DataTableNames

        Public Shared Menu As String = "Menu"
        Public Shared SafeDetails As String = "SafeDetails"

        Public Enum Names
            Menu
            SafeDetails
        End Enum

    End Class

End Class

Module DataSetExtensions
    <System.Runtime.CompilerServices.Extension()>
    Function GetTable(ByVal ds As DataSet, name As UtilMenu.DataTableNames.Names) As DataTable
        Select Case name
            Case UtilMenu.DataTableNames.Names.Menu
                Return ds.Tables(UtilMenu.DataTableNames.Menu)
            Case UtilMenu.DataTableNames.Names.SafeDetails
                Return ds.Tables(UtilMenu.DataTableNames.SafeDetails)
            Case Else
                Return Nothing
        End Select
    End Function
End Module