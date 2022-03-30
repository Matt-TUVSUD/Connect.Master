Imports GRC.Connect.Libraries.PowerBILib
Imports Telerik.Web.UI

Public Class UserAdmin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then BindDropdowns()
    End Sub

    Private Sub BindDropdowns()
        rcCategory.DataSource = DataHelper.GetReportCategories(True)
        rcCategory.DataBind()
        rcCategory.Items.Insert(0, New RadComboBoxItem("Select", "-1"))
        rcClients.DataSource = DataHelper.GetAllClients()
        rcClients.DataBind()
        rcClients.Items.Insert(0, New RadComboBoxItem("Select", "-1"))

        rcReports.Items.Insert(0, New RadComboBoxItem("Select", "-1"))

        'Dataset Clients
        rcDSClients.DataSource = DataHelper.GetAllClients()
        rcDSClients.DataBind()
        rcDSClients.Items.Insert(0, New RadComboBoxItem("Select", "-1"))

        rcDatasets.DataSource = DataHelper.GetDatasets()
        rcDatasets.DataBind()
        rcDatasets.Items.Insert(0, New RadComboBoxItem("Select", "-1"))

    End Sub

    Private Sub BindReports(ByVal reportCategoryID As Integer)
        rcReports.DataSource = DataHelper.GetReportsByCategory(reportCategoryID)
        rcReports.DataBind()
        rcReports.Items.Insert(0, New RadComboBoxItem("Select", "-1"))
    End Sub

    Private Sub BindUsers(ByVal clientId As Integer)
        rcUsers.DataSource = DataHelper.GetUsersByClientId(clientId)
        rcUsers.DataBind()
    End Sub

    Private Sub BindDSUsers(ByVal clientId As Integer)
        'Dataset Users
        rcDSUsers.DataSource = DataHelper.GetUsersByClientId(clientId)
        rcDSUsers.DataBind()
    End Sub
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        lblErrorMessage.Text = String.Empty
        Dim reportId = Convert.ToInt32(rcReports.SelectedValue)
        Dim clientId = Convert.ToInt32(rcClients.SelectedValue)
        Dim userIds As String = String.Join(",", rcUsers.CheckedItems.[Select](Function(x) x.Value))
        Dim i = DataHelper.InsertUserDatasetAccess(reportId, clientId, userIds)
        lblErrorMessage.Text = Common.RECORD_SAVED_SUCCESS

        radReportGrid.DataSource = DataHelper.GetReportAccessList()
        radReportGrid.DataBind()
    End Sub

    Protected Sub rcClients_SelectedIndexChanged(ByVal sender As Object, ByVal e As RadComboBoxSelectedIndexChangedEventArgs)
        Dim clientId = rcClients.SelectedValue
        BindUsers(Convert.ToInt32(clientId))
    End Sub

    Protected Sub radReportGrid_DeleteCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim reportAccessID = Convert.ToInt32(editableItem.GetDataKeyValue("ID"))
        Dim deletedID = DataHelper.DeleteReportAccessById(reportAccessID)
        lblErrorMessage.Text = Common.RECORD_DELETED_SUCCESS

    End Sub

    Protected Sub radReportGrid_NeedDataSource(ByVal sender As Object, ByVal e As GridNeedDataSourceEventArgs)
        radReportGrid.DataSource = DataHelper.GetReportAccessList()
    End Sub

    Protected Sub rcCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As RadComboBoxSelectedIndexChangedEventArgs)
        Dim reportCategoryId = rcCategory.SelectedValue
        BindReports(Convert.ToInt32(reportCategoryId))
    End Sub



    Protected Sub btnDSAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        lblDSErrorMessage.Text = String.Empty
        Dim datasetId = Convert.ToInt32(rcDatasets.SelectedValue)
        Dim clientId = Convert.ToInt32(rcDSClients.SelectedValue)

        If (datasetId = -1) Then
            lblDSErrorMessage.Text = "Please select dataset"
            Return
        ElseIf (clientId = -1) Then
            lblDSErrorMessage.Text = "Please select client"
            Return
        End If


        Dim userIds As String = String.Join(",", rcDSUsers.CheckedItems.[Select](Function(x) x.Value))
        Dim i = DataHelper.InsertUserDatasetAccess(datasetId, clientId, userIds)
        lblDSErrorMessage.Text = Common.RECORD_SAVED_SUCCESS

        radDatasetGrid.DataSource = DataHelper.GetDatasetAccessList()
        radDatasetGrid.DataBind()
    End Sub

    Protected Sub rcDSClients_SelectedIndexChanged(ByVal sender As Object, ByVal e As RadComboBoxSelectedIndexChangedEventArgs)
        Dim clientId = rcDSClients.SelectedValue
        BindDSUsers(Convert.ToInt32(clientId))
    End Sub

    Protected Sub radDatasetGrid_DeleteCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim datasetAccessID = Convert.ToInt32(editableItem.GetDataKeyValue("ID"))
        Dim deletedID = DataHelper.DeleteDatasetAccessById(datasetAccessID)
        lblDSErrorMessage.Text = Common.RECORD_DELETED_SUCCESS

    End Sub

    Protected Sub radDatasetGrid_NeedDataSource(ByVal sender As Object, ByVal e As GridNeedDataSourceEventArgs)
        radDatasetGrid.DataSource = DataHelper.GetDatasetAccessList()
    End Sub

End Class