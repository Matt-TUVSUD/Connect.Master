Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilPractice
Imports GRC.Connect.Libraries.CoreLib.UtilValidate

Public Class DefaultDiversified
    Inherits System.Web.UI.Page

    'DECLARATIONS
    ' COUNTERS USED TO DISPLAY BUTTONS IN THREE COLUMNS
    Dim rowCounter As Integer = 1

    Private Sub ValidatePage()
        Dim zGUID As String = GetGUIDFromQueryString()
        CorrectPageCheck(zGUID, PageId_LocationListing_DivServ, PageId_LocationListing_DivServ)

        'Redirect to location listing grid
        SetValue(zGUID, KeyName.NavLocationSelectionText, "", KeyNameGroup.Session)
        SetValue(zGUID, KeyName.currentGridId, GridId_DivServLocationListings, KeyNameGroup.Navigation)
        Dim zURL As String = "~/Home_{{VER}}/Grids/LocationListings/LocationListings.aspx?sid=" & GetGUIDFromQueryString()
        Response.Redirect(zURL, False)
    End Sub

    Private Sub loadLists()
        Dim zGuid As String = GetGUIDFromQueryString()
        Dim zGSafeId As Integer = GetId(zGuid)
        Dim collFileNo As New GSafeFileNoCollection

        collFileNo.Query.Where(collFileNo.Query.GSafeId = zGSafeId)
        If collFileNo.LoadAll() Then
            rptFileNo.DataSource = collFileNo
            rptFileNo.DataBind()
        End If

    End Sub

    Private Sub loadDefaults()
        SetDiversifiedPractice(GetGUIDFromQueryString)
    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()
    End Sub

    Private Sub rptFileNo_ItemDataBound(sender As Object, e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles rptFileNo.ItemDataBound
        'SHOW THE SEPERATOR EVERY THREE TIMES TO SHOW THE NEXT ROW (THREE COLUMNS)
        Dim columnCounter As Integer = 5
        If e.Item.ItemType = ListItemType.Separator Then
            If rowCounter Mod columnCounter <> 0 Then
                e.Item.Visible = False
            Else
                e.Item.Visible = True
            End If
        End If
        rowCounter = rowCounter + 1

    End Sub

    Protected Sub rptFileNo_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptFileNo.ItemCommand
        Dim zGuid As String = GetGUIDFromQueryString()
        Dim zFileNo As String = CType(e.Item.FindControl("hidFileNo"), HiddenField).Value
        UtilGSafe.SetLocationNavigationInformation(zGuid, zFileNo)
        SetValue(zGuid, KeyName.currentTab, PageId_DivServ, KeyNameGroup.Navigation)
        SetDiversifiedDetailsPractice(zGuid)

        Response.Redirect("~/Home_{{VER}}/Diversified/locationdetails.aspx?sid=" & zGuid)
    End Sub

End Class