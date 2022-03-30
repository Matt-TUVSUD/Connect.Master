Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe


Public Class Grids_LibrariesDocumentLibrary
    Inherits System.Web.UI.Page


#Region "Local Variables"
    Public ServerSide_GridId As String = ""
    Dim zGSafeGUID As String
    Dim zGridId As String
#End Region

#Region "Page Events"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ClientScript.GetPostBackEventReference(Me, String.Empty)


        Call loadLists()
        Call loadDefaults()

        Default_PageLoad()

        ' STORE THE CORRECT INFORMATION TO THE GSAFE
        SetValue(zGSafeGUID, KeyName.currentGridId, zGridId, KeyNameGroup.Navigation)

        If Not Page.IsPostBack Then

            Dim zUserid As Integer = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.EzyLoginId)
            UtilDB.LogGridActivity(zUserid, zGridId)

        Else
            '            If Me.IsPostBack Then
            Dim eventTarget As String
            Dim eventArgument As String

            If Me.Request("__EVENTTARGET") Is Nothing Then
                eventTarget = String.Empty
            Else
                eventTarget = Me.Request("__EVENTTARGET")
                If Me.Request("__EVENTARGUMENT") Is Nothing Then
                    eventArgument = String.Empty
                Else
                    eventArgument = Me.Request("__EVENTARGUMENT")

                    If eventTarget = "CustomPostBack" Then
                        Dim valuePassed As String = eventArgument
                        DocumentFilter(valuePassed)
                    End If
                End If
            End If
            '        End If

        End If
        Call loadData()




    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init

    End Sub

    Protected Sub Default_PageLoad()

        'Dim zIsRecentUpdate As Boolean = CBool(IIf(IsNothing(Request.QueryString("isrecent")), False, Request.QueryString("isrecent")))
 
        ' GET THE GRID INFOMRATION
        'Dim zGridId As String = "0"
        'Dim zFilePrefix As String = GetValue(zGSafeGUID, KeyName.FilePreFix)
        If Not Request.QueryString("gridId") Is Nothing Then
            zGridId = Request.QueryString("gridId")
        End If

        'Dim zURL As String = "~/Home_{{VER}}/Grids/LibrariesDocumentLibrary/LibrariesDocumentLibrary.aspx?sid=" & zGUID


        ' SET THE NAVLINK INFOMRATION
        Dim zNavlinkId As String = "0"
        If Not Request.QueryString("navLinkId") Is Nothing Then
            UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.NavLinkId, Request.QueryString("navLinkId"), UtilGSafe.KeyNameGroup.Navigation)
        End If



    End Sub

    Protected Sub DocumentFilter(shouldFilter As Boolean)

        If shouldFilter Then
            Dim zUpdates As UtilUpdates.UpdateResult = UtilUpdates.GetCounts(zGSafeGUID)
            Dim zLastRecentDate As Date = zUpdates.DocLibLastReviewedDate
            Dim zDocDateParm As String = "&documentdate=" & zLastRecentDate.ToString("MM-dd-yyyy") ' CDate(zLastRecentDate.Month & "-" & zLastRecentDate.Day & "-" & zLastRecentDate.Year)
            UtilUpdates.SetDocLibLastReviewedDate(zGSafeGUID)
            Response.Redirect(Request.Url.ToString() & zDocDateParm)
        Else
            ' we do not want to filter so remove documentdate=mm-dd-yyyy (24 characters) from the querystring
            Dim forwardURL As String = Request.Url.ToString()
            Dim locationOfDocumentDate As Integer = forwardURL.IndexOf("&documentdate")
            If locationOfDocumentDate > -1 Then
                forwardURL = forwardURL.Remove(locationOfDocumentDate, 24)
                Response.Redirect(forwardURL)
            End If
        End If

    End Sub

#End Region



#Region "Data Loading"
    Private Sub loadDefaults()

        zGSafeGUID = UtilGSafe.GetGUIDFromQueryString()
        zGridId = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.currentGridId)
        ServerSide_GridId = zGridId

    End Sub


    Private Sub loadData()

    End Sub


    Private Sub loadLists()

    End Sub


    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LoadComplete

    End Sub


    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed

    End Sub
#End Region



#Region "ViewState"
    Protected Overrides Function LoadPageStateFromPersistenceMedium() As Object
        Return Me.Session("GridState")
    End Function

    Protected Overrides Sub SavePageStateToPersistenceMedium(ByVal viewState As Object)
        Me.Session.Add("GridState", viewState)
    End Sub
#End Region



End Class