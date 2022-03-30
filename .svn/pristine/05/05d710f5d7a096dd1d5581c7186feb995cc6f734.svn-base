
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
'Imports GRC.Connect.Web.PicklistControl

Partial Class Grids_Favorites
    Inherits System.Web.UI.Page


#Region "Local Variables"
    'Private masterPage As New Grids_GridMasterPageLocationListings
    'Private mainContent As ContentPlaceHolder
    Public ServerSide_GridId As String = ""

#End Region



#Region "Initialize Controls"
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
    End Sub
#End Region



#Region "Page Events"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If
        Call loadData()
    End Sub

#End Region



#Region "Data Loading"
    Private Sub loadDefaults()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zGridId As String = "183"
        ServerSide_GridId = zGridId
        UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.currentGridId, zGridId, UtilGSafe.KeyNameGroup.Navigation)
        ' NOTE: THE GRID ID MUST BE HARD CODED

    End Sub


    Private Sub loadData()

    End Sub


    Private Sub loadLists()

    End Sub

#End Region

End Class
