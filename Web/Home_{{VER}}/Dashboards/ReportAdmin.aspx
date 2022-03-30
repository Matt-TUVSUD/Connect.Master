<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="ReportAdmin.aspx.vb" UnobtrusiveValidationMode="None" Inherits="GRC.Connect.Web.ReportAdmin" %>

<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/print.css" media="print" />

    <link rel="Stylesheet" type="text/css" href="../../css/pages/programstatus.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" LoadingPanelID="RadAjaxLoadingPanel1">
        <div id="view" data-bind="with: view" style="display: flex; align-items: center;">
            <div id="dashboardHldr">
                <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="Dashboard Administration" SubHeader="Report Administration" />
                <div style="text-align: left;">
                    <table class="tableBorder" cellpadding="5">
                        <tr>
                            <td style="width: 15%" colspan="6"><b>SEARCH</b></td>

                        </tr>
                        <tr>
                            <td>Report Category</td>
                            <td>
                                <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
                            </td>
                            <td>Report Name</td>
                            <td>
                                <asp:TextBox ID="txtReportName" runat="server"></asp:TextBox></td>
                            <td></td>
                            <td></td>
                        </tr>

                        <tr>
                            <td>Report Type</td>
                            <td>
                                <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList>
                            </td>
                            <td>Account</td>
                            <td>
                                <asp:DropDownList ID="ddlAccount" runat="server"></asp:DropDownList></td>
                            <td>Active
                                <asp:CheckBox ID="chkIsActive" Checked="true" runat="server" /></td>
                            <td>
                                <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" /></td>
                        </tr>

                    </table>

                    <table cellpadding="1">
                        <tr>
                            <td>
                                <asp:Label ID="lblErrorMessage" CssClass="errorMessage" runat="server" />
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <telerik:RadGrid runat="server" ID="radReportGrid" EnableAjaxSkinRendering="true"
                                    AutoGenerateColumns="false" Skin="Web20" AllowSorting="true"
                                    AllowPaging="true"
                                    OnItemCreated="radReportGrid_ItemCreated"
                                    OnInsertCommand="radReportGrid_InsertCommand"
                                    OnNeedDataSource="radReportGrid_NeedDataSource"
                                    OnUpdateCommand="radReportGrid_UpdateCommand"
                                    OnDeleteCommand="radReportGrid_DeleteCommand"
                                    OnItemDataBound="radReportGrid_ItemDataBound">
                                    <MasterTableView DataKeyNames="ID"
                                        CommandItemDisplay="Top"
                                        InsertItemPageIndexAction="ShowItemOnCurrentPage"
                                        EditMode="InPlace" TableLayout="Fixed" PageSize="50" AllowPaging="true">
                                        <Columns>
                                            <telerik:GridTemplateColumn HeaderText="Report Category" ForceExtractValue="Always">
                                                <EditItemTemplate>
                                                    <telerik:RadComboBox ID="radReportCategory" runat="server" />
                                                    <asp:RequiredFieldValidator ID="rfvReportCategory" runat="server" ForeColor="Red" ErrorMessage="*"
                                                        ControlToValidate="radReportCategory" InitialValue="Select"></asp:RequiredFieldValidator>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem,"CategoryName")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Report Type" ForceExtractValue="Always">
                                                <EditItemTemplate>
                                                    <telerik:RadComboBox ID="radReportType" runat="server" />
                                                    <asp:RequiredFieldValidator ID="rfvReportType" runat="server" ForeColor="Red" ErrorMessage="*"
                                                        ControlToValidate="radReportType" InitialValue="Select"></asp:RequiredFieldValidator>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem,"ReportType")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridBoundColumn DataField="ReportName" HeaderText="Report Name" ForceExtractValue="Always">
                                                <ColumnValidationSettings EnableRequiredFieldValidation="true" EnableModelErrorMessageValidation="true">
                                                    <RequiredFieldValidator ForeColor="Red" ErrorMessage="*"></RequiredFieldValidator>
                                                    <ModelErrorMessage BackColor="Red" />
                                                </ColumnValidationSettings>
                                            </telerik:GridBoundColumn>
                                            <telerik:GridTemplateColumn HeaderText="ReportID">
                                                <EditItemTemplate>
                                                    <telerik:RadTextBox ID="txtReportId" runat="server">
                                                    </telerik:RadTextBox>
                                                    <asp:RequiredFieldValidator ID="reqReportID" runat="server" ControlToValidate="txtReportId" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="reVReportID" runat="server" ControlToValidate="txtReportId" ValidationExpression="(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}"
                                                        ForeColor="Red" ErrorMessage="Invalid"></asp:RegularExpressionValidator>

                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem,"ReportID")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="WorkSpaceID">
                                                <EditItemTemplate>
                                                    <telerik:RadTextBox ID="txtWorkSpaceID" runat="server">
                                                    </telerik:RadTextBox>
                                                    <asp:RequiredFieldValidator ID="reqWorkSpaceID" runat="server" ControlToValidate="txtWorkSpaceID" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="reVWorkSpaceID" runat="server" ControlToValidate="txtWorkSpaceID" ValidationExpression="(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}"
                                                        ForeColor="Red" ErrorMessage="Invalid"></asp:RegularExpressionValidator>

                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "WorkSpaceID")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Associated Account">
                                                <EditItemTemplate>
                                                    <telerik:RadComboBox ID="radAccounts" runat="server">
                                                    </telerik:RadComboBox>
                                                    <asp:RequiredFieldValidator ID="rfvAccount" runat="server" ForeColor="Red" ErrorMessage="*"
                                                        ControlToValidate="radAccounts" InitialValue="Select"></asp:RequiredFieldValidator>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem,"AccountName")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Active">
                                                <EditItemTemplate>
                                                    <asp:CheckBox ID="ckActive" runat="server" />
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox1" Text="" runat="server" Enabled="false" Checked='<%# Convert.ToBoolean(Eval("IsActive")) %>' />
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Action">
                                                <HeaderStyle Width="150" />
                                                <ItemStyle Width="150" />
                                                <InsertItemTemplate>
                                                    <asp:Button ID="radInsert" runat="server" Text="Insert"
                                                        CommandName="PerformInsert"></asp:Button>
                                                    <asp:Button ID="radInsertCancel" runat="server" Text="Cancel"
                                                        CommandName="Cancel" CausesValidation="false"></asp:Button>
                                                </InsertItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Button ID="radEdit" runat="server" Text="Edit" ToolTip="Edit"
                                                        CommandName="Edit"></asp:Button>
                                                    <asp:Button ID="radDelete" runat="server" ToolTip="Delete"
                                                        CommandName="Delete" OnClientClick="javascript:if(!confirm('Are you sure to delete?')){return false;}"
                                                        Text="Delete" />
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:Button ID="radUpdate" runat="server" Text="Update" ToolTip="Update"
                                                        CommandName="Update"></asp:Button>
                                                    <asp:Button ID="radUpdateCancel" runat="server" Text="Cancel" ToolTip="Cancel"
                                                        CommandName="Cancel" CausesValidation="false"></asp:Button>
                                                </EditItemTemplate>
                                            </telerik:GridTemplateColumn>
                                        </Columns>
                                    </MasterTableView>
                                    <PagerStyle Mode="NextPrevAndNumeric" />
                                </telerik:RadGrid>

                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <StdHeader:StdHeader runat="server" ID="StdHeader1" Header="" SubHeader="Dataset Administration" />
                <div style="text-align: left;">
                    <table class="tableBorder" cellpadding="5">
                        <tr>
                            <td style="width: 15%" colspan="6"><b>SEARCH</b></td>

                        </tr>
                        <tr>
                            <td>Dataset Name</td>
                            <td>
                                <asp:TextBox ID="txtDSName" runat="server"></asp:TextBox>

                            </td>
                            <td>Account</td>
                            <td>
                                <asp:DropDownList ID="ddlDSAccount" runat="server"></asp:DropDownList></td>
                            <td></td>
                            <td></td>
                        </tr>

                        <tr>
                            <td>Active</td>
                            <td>
                                <asp:CheckBox ID="chkDSActive" Checked="true" runat="server" /></td>
                            <td>
                                <asp:Button ID="btnDSSearch" Text="Search" runat="server" OnClick="btnDSSearch_Click" /></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>

                    <table cellpadding="1">
                        <tr>
                            <td>
                                <asp:Label ID="lblDSError" CssClass="errorMessage" runat="server" />
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <telerik:RadGrid runat="server" ID="rgDatasetGrid" EnableAjaxSkinRendering="true"
                                    AutoGenerateColumns="false" Skin="Web20" AllowSorting="true"
                                    AllowPaging="true"
                                    OnItemCreated="rgDatasetGrid_ItemCreated"
                                    OnInsertCommand="rgDatasetGrid_InsertCommand"
                                    OnNeedDataSource="rgDatasetGrid_NeedDataSource"
                                    OnUpdateCommand="rgDatasetGrid_UpdateCommand"
                                    OnDeleteCommand="rgDatasetGrid_DeleteCommand"
                                    OnItemDataBound="rgDatasetGrid_ItemDataBound">
                                    <MasterTableView DataKeyNames="ID"
                                        CommandItemDisplay="Top"
                                        InsertItemPageIndexAction="ShowItemOnCurrentPage"
                                        EditMode="InPlace" TableLayout="Fixed" PageSize="50" AllowPaging="true">
                                        <Columns>
                                            <telerik:GridTemplateColumn HeaderText="Dataset Name" ForceExtractValue="Always">
                                                <EditItemTemplate>
                                                    <telerik:RadTextBox ID="txtDatasetName" runat="server">
                                                    </telerik:RadTextBox>
                                                    <asp:RequiredFieldValidator ID="rfvDatasetName" runat="server" ForeColor="Red" ErrorMessage="*"
                                                        ControlToValidate="txtDatasetName"></asp:RequiredFieldValidator>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "DataSetName")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Dataset Id" ForceExtractValue="Always" HeaderStyle-Width="20%">
                                                <EditItemTemplate>
                                                    <telerik:RadTextBox ID="txtDatasetId" runat="server" Width="225">
                                                    </telerik:RadTextBox>
                                                    <asp:RequiredFieldValidator ID="reqDatasetId" runat="server" ControlToValidate="txtDatasetId" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="reVDatasetId" runat="server" ControlToValidate="txtDatasetId" ValidationExpression="(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}"
                                                        ForeColor="Red" ErrorMessage="Invalid"></asp:RegularExpressionValidator>

                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "DatasetId")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>

                                            <telerik:GridTemplateColumn HeaderText="Workspace Id" ForceExtractValue="Always" HeaderStyle-Width="20%">
                                                <EditItemTemplate>
                                                    <telerik:RadTextBox ID="txtWorkspaceId" runat="server" Width="225">
                                                    </telerik:RadTextBox>
                                                    <asp:RequiredFieldValidator ID="reqWorkspaceId" runat="server" ControlToValidate="txtWorkspaceId" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="reVWorkspaceId" runat="server" ControlToValidate="txtWorkspaceId" ValidationExpression="(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}"
                                                        ForeColor="Red" ErrorMessage="Invalid"></asp:RegularExpressionValidator>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "WorkSpaceID")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Associated Account">
                                                <EditItemTemplate>
                                                    <telerik:RadComboBox ID="radAccounts" runat="server">
                                                    </telerik:RadComboBox>
                                                    <asp:RequiredFieldValidator ID="rfvAccount" runat="server" ForeColor="Red" ErrorMessage="*"
                                                        ControlToValidate="radAccounts" InitialValue="Select"></asp:RequiredFieldValidator>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem,"AccountName")%>
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Default" HeaderStyle-Width="50">
                                                <EditItemTemplate>
                                                    <asp:CheckBox ID="ckDefault" runat="server" Enabled="false" />
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkDefault" Text="" runat="server" Enabled="false" Checked='<%# Convert.ToBoolean(Eval("IsDefault")) %>' />
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Active">
                                                <EditItemTemplate>
                                                    <asp:CheckBox ID="ckActive" runat="server" />
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkActive" Text="" runat="server" Enabled="false" Checked='<%# Convert.ToBoolean(Eval("IsActive")) %>' />
                                                </ItemTemplate>
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn HeaderText="Action">
                                                <HeaderStyle Width="150" />
                                                <ItemStyle Width="150" />
                                                <InsertItemTemplate>
                                                    <asp:Button ID="radInsert" runat="server" Text="Insert"
                                                        CommandName="PerformInsert"></asp:Button>
                                                    <asp:Button ID="radInsertCancel" runat="server" Text="Cancel"
                                                        CommandName="Cancel" CausesValidation="false"></asp:Button>
                                                </InsertItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Button ID="radEdit" runat="server" Text="Edit" ToolTip="Edit"
                                                        CommandName="Edit"></asp:Button>
                                                    <asp:Button ID="radDelete" runat="server" ToolTip="Delete" Visible='<%#If(Eval("IsDefault") = True, False, True) %>'
                                                        CommandName="Delete" OnClientClick="javascript:if(!confirm('Are you sure to delete?')){return false;}"
                                                        Text="Delete" />
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:Button ID="radUpdate" runat="server" Text="Update" ToolTip="Update"
                                                        CommandName="Update"></asp:Button>
                                                    <asp:Button ID="radUpdateCancel" runat="server" Text="Cancel" ToolTip="Cancel"
                                                        CommandName="Cancel" CausesValidation="false"></asp:Button>
                                                </EditItemTemplate>
                                            </telerik:GridTemplateColumn>
                                        </Columns>
                                    </MasterTableView>
                                    <PagerStyle Mode="NextPrevAndNumeric" />
                                </telerik:RadGrid>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </telerik:RadAjaxPanel>
</asp:Content>
