Imports GRC.Connect.Libraries.PowerBILib
Imports Telerik.Web.UI
Imports GRC.Connect.Libraries.PowerBILib.Entities

Public Class ReportAdmin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindAllDropdowns()
        End If
    End Sub

    Private Sub BindAllDropdowns()
        BindDropdown("ReportCategory", ddlCategory, "ID", "CategoryName", True)
        BindDropdown("ReportType", ddlType, "Value", "Key", False)
        BindDropdown("Accounts", ddlAccount, "ID", "AccountName", True)

        'Binds Accounts for Dataset section
        BindDropdown("Accounts", ddlDSAccount, "ID", "AccountName", True)


    End Sub

    Protected Function GetData() As DataTable
        Return DataHelper.GetReportSearch(Convert.ToInt32(ddlCategory.SelectedValue), txtReportName.Text.Trim(), ddlType.SelectedValue, Convert.ToInt32(ddlAccount.SelectedValue), chkIsActive.Checked)
    End Function

    Protected Sub radReportGrid_InsertCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim values As Hashtable = New Hashtable()
        editableItem.ExtractValues(values)
        Dim rpm As PBReportMaster = New PBReportMaster With {
        .ReportCategoryID = Convert.ToInt32((CType(editableItem.FindControl("radReportCategory"), RadComboBox)).SelectedValue),
        .ReportType = ((CType(editableItem.FindControl("radReportType"), RadComboBox)).SelectedValue),
        .AccountID = Convert.ToInt32((CType(editableItem.FindControl("radAccounts"), RadComboBox)).SelectedValue),
        .IsActive = Convert.ToBoolean((CType(editableItem.FindControl("ckActive"), CheckBox)).Checked),
        .ReportID = Guid.Parse((CType(editableItem.FindControl("txtReportId"), RadTextBox).Text)),
        .WorkSpaceID = Guid.Parse((CType(editableItem.FindControl("txtWorkSpaceID"), RadTextBox).Text)),
        .ReportName = values("ReportName").ToString()
    }
        Dim insertedID = DataHelper.InertUpdateReport(rpm)

        If insertedID = -1 Then
            lblErrorMessage.Text = Common.RECORD_ALREADY_EXISTS
            e.Canceled = True
        Else
            lblErrorMessage.Text = Common.RECORD_SAVED_SUCCESS
        End If
    End Sub

    Protected Sub radReportGrid_NeedDataSource(ByVal sender As Object, ByVal e As GridNeedDataSourceEventArgs)
        radReportGrid.DataSource = GetData()
    End Sub

    Protected Sub radReportGrid_UpdateCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim values As Hashtable = New Hashtable()
        editableItem.ExtractValues(values)
        Dim rpm As PBReportMaster = New PBReportMaster With {
        .ID = Convert.ToInt32(editableItem.GetDataKeyValue("ID")),
        .ReportCategoryID = Convert.ToInt32((CType(editableItem.FindControl("radReportCategory"), RadComboBox)).SelectedValue),
        .ReportType = ((CType(editableItem.FindControl("radReportType"), RadComboBox)).SelectedValue),
        .AccountID = Convert.ToInt32((CType(editableItem.FindControl("radAccounts"), RadComboBox)).SelectedValue),
        .IsActive = Convert.ToBoolean((CType(editableItem.FindControl("ckActive"), CheckBox)).Checked),
        .ReportID = Guid.Parse((CType(editableItem.FindControl("txtReportId"), RadTextBox).Text)),
        .WorkSpaceID = Guid.Parse((CType(editableItem.FindControl("txtWorkSpaceID"), RadTextBox).Text)),
        .ReportName = values("ReportName").ToString()
    }
        Dim insertedID = DataHelper.InertUpdateReport(rpm)

        If insertedID = -1 Then
            lblErrorMessage.Text = Common.RECORD_ALREADY_EXISTS
            e.Canceled = True
        Else
            lblErrorMessage.Text = Common.RECORD_SAVED_SUCCESS

        End If
    End Sub

    Protected Sub radReportGrid_DeleteCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim reportId As Int32 = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("ID").ToString()
        Dim deletedID = DataHelper.DeleteReportById(reportId)
        If deletedID = 1 Then
            lblErrorMessage.Text = Common.RECORD_DELETED_SUCCESS
        End If
    End Sub

    Protected Sub radReportGrid_ItemCreated(ByVal sender As Object, ByVal e As GridItemEventArgs)
    End Sub

    Protected Sub radReportGrid_ItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs)
        If TypeOf e.Item Is GridEditableItem AndAlso e.Item.IsInEditMode Then
            Dim editItem As GridEditableItem = CType(e.Item, GridEditableItem)
            BindCombo(Common.REPORT_CATEGORY, editItem, "radReportCategory", "ID", "CategoryName", True, "ReportCategoryID")
            BindCombo(Common.REPORT_ACCOUNTS, editItem, "radAccounts", "ID", "AccountName", True, "AccountID")
            BindCombo(Common.REPORT_TYPE, editItem, "radReportType", "Value", "Key", False, "ReportType")
            Dim rc As CheckBox = CType(editItem.FindControl("ckActive"), CheckBox)
            rc.Checked = CBool(DataBinder.Eval(e.Item.DataItem, "IsActive"))
            Dim rtxtReportID As RadTextBox = CType(editItem.FindControl("txtReportId"), RadTextBox)
            rtxtReportID.Text = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ReportId"))
            Dim rtxtWorkspaceID As RadTextBox = CType(editItem.FindControl("txtWorkSpaceID"), RadTextBox)
            rtxtWorkspaceID.Text = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "WorkSpaceID"))
        End If
    End Sub

    Private Sub BindCombo(ByVal bindFor As String, ByVal editItem As GridEditableItem, ByVal findControl As String, ByVal valueField As String, ByVal textField As String, ByVal isAddSelect As Boolean, ByVal setSelectedValue As String)
        Dim rcb As RadComboBox = CType(editItem.FindControl(findControl), RadComboBox)
        Dim execute As Boolean = True

        Select Case bindFor
            Case Common.REPORT_CATEGORY
                rcb.DataSource = DataHelper.GetReportCategories()
            Case Common.REPORT_ACCOUNTS
                rcb.DataSource = DataHelper.GetAccounts()
            Case Common.REPORT_TYPE
                rcb.DataSource = DataHelper.GetReportTypes()
            Case Else
                execute = False
        End Select

        If execute Then
            rcb.DataValueField = valueField
            rcb.DataTextField = textField
            rcb.DataBind()
            If isAddSelect Then rcb.Items.Insert(0, New RadComboBoxItem("Select", "-1"))
            rcb.SelectedValue = DataBinder.Eval(editItem.DataItem, setSelectedValue).ToString()
        End If
    End Sub

    Private Sub BindDropdown(ByVal dropdownFor As String, ByRef ddl As DropDownList, ByVal valueField As String, ByVal textField As String, ByVal isAddSelect As Boolean)
        Dim execute = True

        Select Case dropdownFor
            Case Common.REPORT_CATEGORY
                ddl.DataSource = DataHelper.GetReportCategories()
            Case Common.REPORT_TYPE
                ddl.DataSource = DataHelper.GetReportTypes()
            Case Common.REPORT_ACCOUNTS
                ddl.DataSource = DataHelper.GetAccounts()
            Case Else
                execute = False
        End Select

        If execute Then
            ddl.DataValueField = valueField
            ddl.DataTextField = textField
            ddl.DataBind()
            If isAddSelect Then ddl.Items.Insert(0, New ListItem With {
            .Value = "-1",
            .Text = "Select"
        })
        End If
    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
        lblErrorMessage.Text = String.Empty
        radReportGrid.DataSource = GetData()
        radReportGrid.DataBind()
    End Sub

#Region "DATASET LOGIC"


    Protected Sub btnDSSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
        lblErrorMessage.Text = String.Empty
        rgDatasetGrid.DataSource = GetDatasetData()
        rgDatasetGrid.DataBind()
    End Sub


    Protected Sub rgDatasetGrid_InsertCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))

        Dim dsm As PBDatasetMaster = New PBDatasetMaster With {
        .DataSetName = Convert.ToString(CType(editableItem.FindControl("txtDatasetName"), RadTextBox).Text),
        .AccountID = Convert.ToInt32((CType(editableItem.FindControl("radAccounts"), RadComboBox)).SelectedValue),
        .IsActive = Convert.ToBoolean((CType(editableItem.FindControl("ckActive"), CheckBox)).Checked),
        .IsDefault = Convert.ToBoolean((CType(editableItem.FindControl("ckDefault"), CheckBox)).Checked),
        .WorkSpaceID = Guid.Parse((CType(editableItem.FindControl("txtWorkSpaceID"), RadTextBox).Text)),
        .DatasetID = Guid.Parse((CType(editableItem.FindControl("txtDatasetID"), RadTextBox).Text))
    }
        Dim insertedID = DataHelper.InertUpdateDataset(dsm)

        If insertedID = -1 Then
            lblDSError.Text = Common.RECORD_ALREADY_EXISTS
            e.Canceled = True
        Else
            lblDSError.Text = Common.RECORD_SAVED_SUCCESS
        End If
    End Sub

    Protected Sub rgDatasetGrid_NeedDataSource(ByVal sender As Object, ByVal e As GridNeedDataSourceEventArgs)
        rgDatasetGrid.DataSource = GetDatasetData()
    End Sub

    Protected Sub rgDatasetGrid_UpdateCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))

        Dim dsm As PBDatasetMaster = New PBDatasetMaster With {
        .ID = Convert.ToInt32(editableItem.GetDataKeyValue("ID")),
        .AccountID = Convert.ToInt32((CType(editableItem.FindControl("radAccounts"), RadComboBox)).SelectedValue),
        .IsActive = Convert.ToBoolean((CType(editableItem.FindControl("ckActive"), CheckBox)).Checked),
        .IsDefault = Convert.ToBoolean((CType(editableItem.FindControl("ckDefault"), CheckBox)).Checked),
        .DatasetID = Guid.Parse((CType(editableItem.FindControl("txtDatasetId"), RadTextBox).Text)),
        .WorkSpaceID = Guid.Parse((CType(editableItem.FindControl("txtWorkspaceId"), RadTextBox).Text)),
        .DataSetName = Convert.ToString(CType(editableItem.FindControl("txtDatasetName"), RadTextBox).Text)
        }
        Dim insertedID = DataHelper.InertUpdateDataset(dsm)
        If insertedID = -1 Then
            lblDSError.Text = Common.RECORD_ALREADY_EXISTS
            e.Canceled = True
        Else
            lblDSError.Text = Common.RECORD_SAVED_SUCCESS

        End If
    End Sub

    Protected Sub rgDatasetGrid_DeleteCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs)
        Dim dsId As Int32 = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("ID").ToString()
        Dim deletedID = DataHelper.DeleteDatasetById(dsId)
        If deletedID = 1 Then
            lblDSError.Text = Common.RECORD_DELETED_SUCCESS
        ElseIf deletedID = -2 Then
            lblDSError.Text = Common.RECORD_DELETED_EXCEPTION

        End If

    End Sub

    Protected Sub rgDatasetGrid_ItemCreated(ByVal sender As Object, ByVal e As GridItemEventArgs)
    End Sub

    Protected Sub rgDatasetGrid_ItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs)
        If TypeOf e.Item Is GridEditableItem AndAlso e.Item.IsInEditMode Then
            Dim editItem As GridEditableItem = CType(e.Item, GridEditableItem)

            BindCombo(Common.REPORT_ACCOUNTS, editItem, "radAccounts", "ID", "AccountName", True, "AccountID")

            Dim rc As CheckBox = CType(editItem.FindControl("ckActive"), CheckBox)
            rc.Checked = CBool(DataBinder.Eval(e.Item.DataItem, "IsActive"))

            Dim rcDefault As CheckBox = CType(editItem.FindControl("ckDefault"), CheckBox)
            rcDefault.Checked = CBool(DataBinder.Eval(e.Item.DataItem, "IsDefault"))

            Dim rtxtDatasetName As RadTextBox = CType(editItem.FindControl("txtDatasetName"), RadTextBox)
            rtxtDatasetName.Text = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "DataSetName"))

            Dim rtxtDatasetId As RadTextBox = CType(editItem.FindControl("txtDatasetId"), RadTextBox)
            rtxtDatasetId.Text = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "DatasetId"))
            Dim rtxtWorkspaceID As RadTextBox = CType(editItem.FindControl("txtWorkSpaceID"), RadTextBox)
            rtxtWorkspaceID.Text = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "WorkSpaceID"))
        End If
    End Sub


    Protected Function GetDatasetData() As DataTable
        Return DataHelper.GetDatasetSearch(txtDSName.Text.Trim(), Convert.ToInt32(ddlDSAccount.SelectedValue), chkDSActive.Checked)
    End Function

#End Region




End Class