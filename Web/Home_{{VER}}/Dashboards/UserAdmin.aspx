<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="UserAdmin.aspx.vb" UnobtrusiveValidationMode="None" Inherits="GRC.Connect.Web.UserAdmin" %>

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
                <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="Dashboard Administration" SubHeader="User Administration" />
                <div style="text-align: left;">
                    <table cellpadding="5" class="tableBorder" style="width: 99%;">
                        <tr>
                            <td style="width: 15%">Report Category</td>
                            <td style="width: 35%">
                                <telerik:RadComboBox ID="rcCategory" AutoPostBack="true" DataTextField="CategoryName" DataValueField="ID" OnSelectedIndexChanged="rcCategory_SelectedIndexChanged" runat="server"></telerik:RadComboBox>
                            </td>
                            <td style="width: 45%"></td>
                        </tr>
                        <tr>
                            <td>Report Name</td>
                            <td>
                                <telerik:RadComboBox ID="rcReports" DataValueField="ID" DataTextField="ReportName" runat="server"></telerik:RadComboBox>
                                <%--<asp:RequiredFieldValidator ID="rfvReports" runat="server" ControlToValidate="rcReports" ValidationGroup="validate" InitialValue="Select" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Clients</td>
                            <td>
                                <telerik:RadComboBox ID="rcClients" Width="350" runat="server" DataTextField="ClientName" AutoPostBack="true" DataValueField="ID" OnSelectedIndexChanged="rcClients_SelectedIndexChanged"></telerik:RadComboBox>
                                <%--<asp:RequiredFieldValidator ID="rfvClient" runat="server" ControlToValidate="rcClients" ValidationGroup="validate" InitialValue="Select" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Users</td>
                            <td>
                                <telerik:RadComboBox ID="rcUsers" Width="350" CheckBoxes="true" EnableCheckAllItemsCheckBox="true" DataTextField="NAME" DataValueField="ID" runat="server"></telerik:RadComboBox>
                            </td>
                            <td>
                                <asp:Button ID="btnAdd" Text="Add" runat="server" ValidationGroup="validate" OnClick="btnAdd_Click" /></td>
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
                                <telerik:RadGrid runat="server" ID="radReportGrid"
                                    AutoGenerateColumns="false" Skin="Web20"
                                    AllowPaging="true"
                                    OnNeedDataSource="radReportGrid_NeedDataSource"
                                    OnDeleteCommand="radReportGrid_DeleteCommand">
                                    <MasterTableView DataKeyNames="ID"
                                        CommandItemDisplay="None"
                                        TableLayout="Fixed" PageSize="50" AllowPaging="true">
                                        <Columns>
                                            <telerik:GridBoundColumn DataField="ReportName" HeaderText="Report Name">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="ClientName" HeaderText="Client">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Name" HeaderText="User">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridButtonColumn HeaderText="Action" ConfirmText="Are you sure to delete?" ConfirmDialogType="Classic"
                                                ConfirmTitle="Delete" ButtonType="PushButton" Text="Delete" CommandName="Delete" ButtonCssClass="rbLinkButton" />
                                        </Columns>
                                    </MasterTableView>
                                    <PagerStyle Mode="NextPrevAndNumeric" />
                                </telerik:RadGrid>
                            </td>
                        </tr>
                    </table>
                </div>
             <br />
                <StdHeader:StdHeader runat="server" ID="StdHeader1" Header="" SubHeader="User Dataset Administration" />
                <div style="text-align: left;">
                    <table cellpadding="5" class="tableBorder" style="width: 99%;">
                        <tr>
                            <td style="width: 15%">Dataset Name</td>
                            <td style="width: 35%">
                                <telerik:RadComboBox ID="rcDatasets" AutoPostBack="true" DataTextField="DatasetName" DataValueField="ID"  runat="server"></telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="rfvDatasets" runat="server" ControlToValidate="rcDatasets" ValidationGroup="validateDS" InitialValue="Select" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 45%"></td>
                        </tr>
                        <tr>
                            <td>Clients</td>
                            <td>
                                <telerik:RadComboBox ID="rcDSClients" Width="350" runat="server" DataTextField="ClientName" AutoPostBack="true" DataValueField="ID" OnSelectedIndexChanged="rcDSClients_SelectedIndexChanged"></telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="rfvDSClient" runat="server" ControlToValidate="rcDSClients" ValidationGroup="validateDS" InitialValue="Select" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Users</td>
                            <td>
                                <telerik:RadComboBox ID="rcDSUsers" Width="350" CheckBoxes="true" EnableCheckAllItemsCheckBox="true" DataTextField="NAME" DataValueField="ID" runat="server"></telerik:RadComboBox>
                            </td>
                            <td>
                                <asp:Button ID="btnDSAdd" Text="Add" runat="server" ValidationGroup="validateDS" OnClick="btnDSAdd_Click" /></td>
                        </tr>
                    </table>
                    <table cellpadding="1">
                        <tr>
                            <td>
                                <asp:Label ID="lblDSErrorMessage" CssClass="errorMessage" runat="server" />
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <telerik:RadGrid runat="server" ID="radDatasetGrid"
                                    AutoGenerateColumns="false" Skin="Web20"
                                    AllowPaging="true"
                                    OnNeedDataSource="radDatasetGrid_NeedDataSource"
                                    OnDeleteCommand="radDatasetGrid_DeleteCommand">
                                    <MasterTableView DataKeyNames="ID"
                                        CommandItemDisplay="None"
                                        TableLayout="Fixed" PageSize="50" AllowPaging="true">
                                        <Columns>
                                            <telerik:GridBoundColumn DataField="DatasetName" HeaderText="Dataset Name">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="ClientName" HeaderText="Client">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Name" HeaderText="User">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridButtonColumn HeaderText="Action" ConfirmText="Are you sure to delete?" ConfirmDialogType="Classic"
                                                ConfirmTitle="Delete" ButtonType="PushButton" Text="Delete" CommandName="Delete" ButtonCssClass="rbLinkButton" />
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
