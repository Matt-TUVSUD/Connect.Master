Imports System.Runtime.CompilerServices

Public Class UtilNavLink

    Private _EntireNavLinkCollection As New ViewCCNavLinkCollection
    Private _ClientFeatures As String = ""
    Private _IsClientAdmin As Boolean = False

    Public Sub New(pGuid As String)
        _ClientFeatures = UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.clientFeatures)
        _IsClientAdmin = Convert.ToBoolean(IIf(String.IsNullOrEmpty(UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.IsClientAdmin)), False, UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.IsClientAdmin)))
        _EntireNavLinkCollection.LoadAll()
    End Sub


    Public Shared Function GetSlideMenuType(pNavLinkId As Integer) As String
        Dim zQry As New razor.queryTblNavLink
        zQry.SelectAll()
        zQry.Where.Add(zQry.colNavLinkId.Equals(pNavLinkId))

        Dim zLinks As List(Of razor.rowTblNavLink) = razor.TblNavLink.LoadData(zQry.QueryText)
        If zLinks.Count > 0 Then
            Return zLinks(0).colSlideType
        Else
            Return NavLink.SlideMenuTypes.All
        End If

    End Function


    Public Shared Function GetNavLinkText(ByVal pNavLinkId As Integer) As String
        ' GET THE NAVTEXT FIELD IN THE DATABASE FOR ONE NAVLINK ROW
        Dim zReturn As String
        Dim zQuery As New razor.queryTblNavLink
        Dim zObj As New razor.rowTblNavLink
        'zQuery.SelectAll()
        'zQuery.Where.Add(zQuery.colNavLinkId.Equals(pNavLinkId))
        zObj = razor.TblNavLink.LoadByPrimaryKey(pNavLinkId)
        If Not zObj.colNavText Is Nothing Then
            zReturn = zObj.colNavText
        Else
            zReturn = ""
        End If
        Return zReturn
    End Function


    Public Function GetSiteMapLinks() As List(Of ViewCCNavLink)
        Dim zKeywords() As String = [Enum].GetNames(GetType(SiteMapKeywords))
        Dim zLinks As List(Of ViewCCNavLink) = GetAllUserLinks()

        Dim zReturn As New List(Of ViewCCNavLink)
        zKeywords.ToList.ForEach(Sub(x) zReturn.AddRange(zLinks.FindAll(Function(y) y.NavSiteMapKeyword = x)))
        'Trace.WriteLine(zReturn.Count)
        Return zReturn
    End Function


    <Obsolete("This function is obsolete. Use GetBatchReportLinks2 instead", False)>
    Public Function GetBatchReportLinks() As List(Of ViewCCNavLink)
        Dim zKeywords() As String = [Enum].GetNames(GetType(BatchReportKeywords))
        Dim zLinks As List(Of ViewCCNavLink) = GetAllUserLinks()

        Dim zReturn As New List(Of ViewCCNavLink)
        zKeywords.ToList.ForEach(Sub(x) zReturn.AddRange(zLinks.FindAll(Function(y) y.NavAllReportsKeyword = x)))
        'Trace.WriteLine(zReturn.Count)
        Return zReturn
    End Function


    ''' <summary>
    ''' This function returns a list of batch report links based on the different practices in the tblMetaPractice table"
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks
    Public Function GetBatchReportLinks2() As List(Of Object)

        Dim zPractices As List(Of razor.rowTblMetaPractice) = razor.TblMetaPractice.LoadData().FindAll(Function(x) x.colFldNavLinkAllReportsKeyword IsNot Nothing).OrderBy(Function(x) x.colFldSortOrder).ToList
        Dim zLinks As List(Of ViewCCNavLink) = GetAllUserLinks()

        Dim zReturn As New List(Of Object)
        For Each zPractice As razor.rowTblMetaPractice In zPractices
            Dim zBatchLinksByPractice As List(Of ViewCCNavLink) = zLinks.FindAll(Function(x) x.NavAllReportsKeyword = zPractice.colFldNavLinkAllReportsKeyword).OrderBy(Function(x) x.NavParentLinkId).ThenBy(Function(x) x.NavOrder).ToList()
            Dim zDict As New Dictionary(Of String, Object)
            zDict.Add("practiceCode", zPractice.colFldPracticeCode)
            zDict.Add("iconName", zPractice.colFldImageHtml)
            zDict.Add("practiceNameText", zPractice.colFldPracticeNameHTML)
            If zBatchLinksByPractice.Count > 0 Then zDict.Add("practiceNameSubText", zBatchLinksByPractice(0).NavText) Else zDict.Add("practiceNameSubText", "")


            Dim navlinks As New List(Of NavLinkJson)
            zBatchLinksByPractice.ForEach(Sub(x) navlinks.Add(New NavLinkJson(x)))
            zDict.Add("navLinks", navlinks)

            zReturn.Add(zDict)
        Next
        Return zReturn
    End Function


    '<Obsolete("This function is obsolete. Use GetBatchReportLinks2 instead", False)>
    'Public Function GetBatchReportLinksByKeyword(pKeyword As String) As List(Of ViewCCNavLink)
    '    Dim zList As List(Of ViewCCNavLink) = GetBatchReportLinks()
    '    Return zList.FindAll(Function(x) x.NavAllReportsKeyword = pKeyword)
    'End Function


    Public Function GetLinksByLocation(pLevel As Integer, pPractice As Integer) As List(Of ViewCCNavLink)
        Dim zList As List(Of ViewCCNavLink) = GetAllUserLinks.FindAll(Function(x) x.NavLevelId = pLevel And x.NavPracticeID = pPractice)
        Return zList.OrderBy(Function(x) x.NavOrder.Value).ToList
    End Function

    Public Function GetAllUserLinks() As List(Of ViewCCNavLink)

        'GET ALL STANDARD LINKS
        Dim zStandardLinks As List(Of ViewCCNavLink) = _EntireNavLinkCollection.ToList.FindAll(Function(x) x.NavSpcFeature = "" And x.NavVisible = True)

        Dim zSpecialLinks As New List(Of ViewCCNavLink)
        Dim zStandardIndexesToRemove As New List(Of Integer)

        'FOR EACH CLIENT FEATURE, FILL THE SPECIAL LINK LIST WITH LINKS
        _ClientFeatures.ToCharArray.ToList.ForEach(Sub(feature) zSpecialLinks.AddRange(_EntireNavLinkCollection.ToList.FindAll(Function(x) x.NavSpcFeature.Contains(feature) And x.NavVisible = True)))

        'FOR EACH SPECIAL FEATURE LINK, REMOVE THE STARDARD LINK IF NEEDED
        zSpecialLinks.ForEach(Sub(spcLink) RemoveStandardLink(spcLink, zStandardLinks))
        zStandardLinks.AddRange(zSpecialLinks)

        'IF THE USER IS NOT A CLIENT ADMIN, REMOVE THE CLIENT ADMIN SPECIFIC LINKS
        If _IsClientAdmin = False Then
            Dim zClientAdminLinks As New List(Of ViewCCNavLink)
            zClientAdminLinks.AddRange(_EntireNavLinkCollection.ToList.FindAll(Function(x) x.IsClientAdmin = True))
            zClientAdminLinks.ForEach(Sub(spcLink) RemoveStandardLink(spcLink, zStandardLinks))
        End If

        'FOR ALL LINKS REPLACE THE _BASE_ PORTION OF URL WITH ACTUAL URL
        zStandardLinks.ForEach(Sub(x) ReplaceBaseString(x))
        'zStandardLinks.ToList.ForEach(Sub(x) Trace.WriteLine("Feature: " & x.NavSpcFeature & " NavParent " & x.NavText.PadRight(20) & " NavText " & x.NavText))
        'Trace.WriteLine("Count:" & zStandardLinks.Count)
        Return zStandardLinks
    End Function


    Private Shared Sub RemoveStandardLink(pSpcLink As ViewCCNavLink, ByRef pStandardLinks As List(Of ViewCCNavLink))
        Dim zLinkIndex As Integer = pStandardLinks.FindIndex(Function(x) x.NavParentLinkId = pSpcLink.NavParentLinkId And x.NavText = pSpcLink.NavText)
        If zLinkIndex > -1 Then
            pStandardLinks.RemoveAt(zLinkIndex)
        End If
    End Sub


    Private Shared Sub ReplaceBaseString(ByRef pNavLink As ViewCCNavLink)

        ' DETERMINE IF WE ARE IN GC (GRC.CONNECT) OR STANDARD MODE
        Dim zSearchString = UtilNav.NavLinkPlaceholder
        Dim zModifier As String = ""
        Dim zActualPath As String = HttpContext.Current.Request.ApplicationPath

        ' MAKE THE REPLACEMENT
        If Not pNavLink.NavUrl Is Nothing Then
            pNavLink.NavUrl = Replace(pNavLink.NavUrl, UtilNav.NavLinkPlaceholder, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}")
        End If

    End Sub

    Public Shared Function GetUniqueNavTexts() As String()
        Dim zUtilNavLink As New UtilNavLink("empty")
        Return zUtilNavLink._EntireNavLinkCollection.ToList().Select(Function(x) x.NavText).Distinct.OrderBy(Function(x) x).ToArray()
    End Function

    Public Shared Function GetSiteMapKeyWords() As String()
        Return [Enum].GetNames(GetType(SiteMapKeywords))
    End Function

    Enum SiteMapKeywords
        BMDataExtracts
        BMLocationListing
        BMOutputReports
        FireDataExtracts
        FireLocationListing
        FireOutputReports
        IRDataExtracts
        IRLocationListing
        IROutputReports
        JurisDataExtracts
        JurisLocationListing
        JurisOutputReports
        MainMenuLibrary
        MainMenuNavigation
        MainMenuQuickRef
        NatHazFloodDataExtracts
        NatHazFloodLocationListing
        NatHazFloodOutputReports
        NatHazSeismicDataExtracts
        NatHazSeismicLocationListing
        NatHazSeismicOutputReports
        NatHazWindDataExtracts
        NatHazWindLocationListing
        NatHazWindOutputReports
        DSDataExtracts
        DSLocationListing
        DSOutputReports
        NHDataExtracts
        NHLocationListings
        NHOutputReports
        BMMapMenu
        FireMapMenu
        IRMapMenu
        JurisMapMenu
        MapMenu
        PSDataExtracts
        PSLocationListing
        PSOutputReports
    End Enum


    Private Class NavLinkJson
        Public Property NavText

        Public Property NavPracticeId

        Public Property NavLinkId

        Public Property NavRptCode

        Public Property NavParentLinkId

        Public Property NavTarget

        Public Property NavUrl

        Public Property NavEnabled

        Public Sub New(link As ViewCCNavLink)
            Me.NavText = link.NavText
            Me.NavPracticeId = link.NavPracticeID
            Me.NavLinkId = link.NavLinkId
            Me.NavRptCode = link.NavRptCode
            Me.NavParentLinkId = link.NavParentLinkId
            Me.NavTarget = link.NavTarget
            Me.NavUrl = link.NavUrl
            Me.NavEnabled = link.NavEnabled
        End Sub

    End Class

    Enum BatchReportKeywords
        BMBatchReports
        FireBatchReports
        IRBatchReports
        JurisBatchReports
        NatHazFloodBatchReports
        NatHazSeismicBatchReports
        NatHazWindBatchReports
        DSBatchReports
    End Enum

End Class


Public Module NavLinkListExtension
    <Extension>
    Function ToCollection(pList As List(Of ViewCCNavLink)) As ViewCCNavLinkCollection
        Dim zCol As New ViewCCNavLinkCollection
        pList.ForEach(Sub(x) zCol.Add(x))
        Return zCol
    End Function
End Module

