<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ColorMeta.ascx.vb" Inherits="GRC.Connect.Web.ColorMeta" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="false" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Height="900px" Width="900px">
    <telerik:RadGrid ID="ColorGrid" AllowSorting="true" Skin="Web20" ClientSettings-AllowDragToGroup="true" ShowGroupPanel="false" MasterTableView-DataKeyNames="fldId" AutoGenerateColumns="false" runat="server">
        <MasterTableView EditMode="Batch" AllowFilteringByColumn="false" AllowPaging="false" PageSize="100" BatchEditingSettings-EditType="Cell" CommandItemSettings-ShowSaveChangesButton="false" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="true" AutoGenerateColumns="false" CommandItemDisplay="None">  
            <Columns>
                        <telerik:GridBoundColumn DataField="fldColor" SortExpression="fldCode" HeaderText="Name" ItemStyle-Width="150" HeaderStyle-Width="150"  UniqueName="Name" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldHex" SortExpression="fldHex" HeaderText="Hex" UniqueName="Hex" ItemStyle-Width="150" HeaderStyle-Width="150" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldR" SortExpression="fldR" HeaderText="R" UniqueName="R" ItemStyle-Width="75" HeaderStyle-Width="75" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldG" SortExpression="fldG" HeaderText="G" UniqueName="G" ItemStyle-Width="75" HeaderStyle-Width="75" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldB" SortExpression="fldB" HeaderText="B" UniqueName="B" ItemStyle-Width="75" HeaderStyle-Width="75" ReadOnly="true"></telerik:GridBoundColumn>          
           </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</telerik:RadAjaxPanel>

