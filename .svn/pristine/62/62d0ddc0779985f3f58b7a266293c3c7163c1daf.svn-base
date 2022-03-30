Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilPractice

Public Class DefaultJurisdictional
    Inherits System.Web.UI.Page

    'DECLARATIONS
    ' COUNTERS USED TO DISPLAY BUTTONS IN THREE COLUMNS
    Dim rowCounter As Integer = 1


    Private Sub ValidatePage()
        Dim zGUID As String = GetGUIDFromQueryString()
        CorrectPageCheck(zGUID, PageId_LocationListing_Juris, PageId_LocationListing_Juris)

        'Redirect to location listing grid
        SetValue(zGUID, KeyName.NavLocationSelectionText, "", KeyNameGroup.Session)
        SetValue(zGUID, KeyName.currentGridId, GridId_JurisLocationListings, KeyNameGroup.Navigation)
        Dim zURL As String = "~/Home_{{VER}}/Grids/LocationListings/LocationListings.aspx?sid=" & GetGUIDFromQueryString()
        Response.Redirect(zURL, False)

    End Sub

    Private Sub loadLists()
        Dim zGuid As String = GetGUIDFromQueryString()
        Dim zGSafeId As Integer = GetId(zGuid)
        Dim qFileNo As New GSafeFileNoQuery
        Dim qViolations As New ViewCCLocationOpenViolationCountJurisQuery
        Dim collViolations As New ViewCCLocationOpenViolationCountJurisCollection

        qFileNo.Select(qFileNo.FileNo)
        qFileNo.Where(qFileNo.GSafeId = zGSafeId)
        qViolations.SelectAll()
        qViolations.Where(qViolations.Fileno.In(qFileNo))

        If collViolations.Load(qViolations) Then
            rptFileNo.DataSource = collViolations
            rptFileNo.DataBind()
        End If

    End Sub

    Private Sub loadDefaults()
        SetJurisPractice(GetGUIDFromQueryString)
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
        UtilGSafe.SetLocationNavigationInformation(zGuid, zFileNo) 'SET TO WHAT THE USER CLICKED INSTEAD
        SetValue(zGuid, KeyName.currentTab, PageId_Fire, KeyNameGroup.Navigation)
        SetFireDetailsPractice(zGuid)

        Response.Redirect("~/Home_{{VER}}/Jurisdictional/locationdetails.aspx?sid=" & zGuid)
    End Sub

End Class