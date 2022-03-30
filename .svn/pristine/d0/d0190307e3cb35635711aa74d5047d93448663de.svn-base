<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="EmailTemplateControl.ascx.vb" Inherits="GRC.Connect.Web.EmailTemplateControl" %>
<%@ Register Src="~/Util/Meta/EmailTemplateEditorControl.ascx" TagPrefix="uc1" TagName="EmailTemplateEditorControl" %>


<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="false" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Height="900px" Width="1100px">
    <telerik:RadGrid ID="RadGridEmailTemplate" AllowSorting="true" Skin="Web20" MasterTableView-DataKeyNames="colfldID" AutoGenerateColumns="false" runat="server">
        <MasterTableView AllowFilteringByColumn="true" AllowPaging="true" PageSize="200" BatchEditingSettings-EditType="Cell" CommandItemSettings-ShowSaveChangesButton="true" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="true" AutoGenerateColumns="false" CommandItemDisplay="Top">
            <Columns>
                <telerik:GridButtonColumn ButtonType="LinkButton" ItemStyle-Width="50" HeaderStyle-Width="50" Text="Edit"></telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="colfldId" AllowSorting="true" ItemStyle-Width="50"  HeaderStyle-Width="50" SortExpression="Field" HeaderText="ID" UniqueName="ID" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="colClientName" AllowSorting="true" ItemStyle-Width="75" HeaderStyle-Width="75" SortExpression="AppearCount" HeaderText="Client" UniqueName="Client" ReadOnly="true"></telerik:GridBoundColumn>               
                <telerik:GridBoundColumn DataField="colfldFilePrefix" AllowSorting="true" SortExpression="fldFilePrefix"  ItemStyle-Width="75" HeaderStyle-Width="75" HeaderText="FilePrefix" UniqueName="FilePrefix" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="colfldType" AllowSorting="true" SortExpression="Width" HeaderText="Type"  ItemStyle-Width="100" UniqueName="Type" HeaderStyle-Width="100" ReadOnly="true"></telerik:GridBoundColumn>      
                <telerik:GridBoundColumn DataField="colfldSubject" AllowSorting="true" SortExpression="fldSubject" ItemStyle-Width="200" HeaderText="Subject" UniqueName="Subject" HeaderStyle-Width="200" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="colfldBody" AllowSorting="true" SortExpression="fldBody" ItemStyle-Width="500" HeaderStyle-Width="500" HeaderText="Body" UniqueName="Body" ReadOnly="true"></telerik:GridBoundColumn>
             </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</telerik:RadAjaxPanel>

<telerik:RadWindow ID="RadWindow1" Width="900" Height="700" AutoSize="true" runat="server">
    <ContentTemplate>
        <uc1:EmailTemplateEditorControl runat="server" ID="EmailTemplateEditorControl" />
    </ContentTemplate>
</telerik:RadWindow>
