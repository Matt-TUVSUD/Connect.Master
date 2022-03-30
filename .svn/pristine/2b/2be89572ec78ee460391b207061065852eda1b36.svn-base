<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="GridMeta.ascx.vb" Inherits="GRC.Connect.Web.GridMeta" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="true" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Width="900px">
    <telerik:RadGrid ID="RadGridByGrid" AllowSorting="true" EnableLinqExpressions="false" Skin="Web20" Width="100%" 
        MasterTableView-DataKeyNames="fldId" AutoGenerateColumns="false" runat="server" 
        ClientSettings-Selecting-AllowRowSelect="true" ClientSettings-Selecting-EnableDragToSelectRows="true" 
        ClientSettings-AllowRowsDragDrop="true" >
        <MasterTableView EditMode="Batch" Name="GridView"  AllowFilteringByColumn="true" AllowPaging="true" PageSize="30" BatchEditingSettings-EditType="Cell"   CommandItemSettings-ShowSaveChangesButton="true" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="true"  AutoGenerateColumns="false" CommandItemDisplay="Top">
            <Columns>
                 <telerik:GridButtonColumn ButtonType="LinkButton" Text="Clone" CommandName="Clone" ItemStyle-Width="40" HeaderStyle-Width="40"></telerik:GridButtonColumn>
                 <telerik:GridButtonColumn ButtonType="LinkButton" Text="Delete" CommandName="DeleteGrid" ItemStyle-Width="40"  ConfirmTitle="Delete Grid" ConfirmDialogWidth="150" ConfirmTextFields="fldGridName" ConfirmTextFormatString="Are you sure you want to delete {0}?" HeaderStyle-Width="40"></telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="fldId" Visible="true"  ItemStyle-Width="0" HeaderStyle-Width="0"  HeaderText=""></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="fldGridName" ItemStyle-Width="200" HeaderStyle-Width="200" HeaderText="Grid Name"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="fldGridPageTitle" ItemStyle-Width="200" HeaderStyle-Width="200" HeaderText="Grid Title"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="fldGridPageSubTitle" ItemStyle-Width="200" HeaderStyle-Width="200" HeaderText="Grid Sub Title"></telerik:GridBoundColumn>
            </Columns>
            <DetailTables>
                <telerik:GridTableView DataKeyNames="fldId" Name="GridColumnView" EditMode="Batch" BatchEditingSettings-EditType="Cell" CommandItemSettings-ShowSaveChangesButton="true" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="false" AutoGenerateColumns="false" CommandItemDisplay="Top">
                    <ParentTableRelation>
                        <telerik:GridRelationFields MasterKeyField="fldId" DetailKeyField="fldMetaGridId" />
                    </ParentTableRelation>
                    <Columns>
                        <telerik:GridBoundColumn DataField="field" AllowSorting="true" ItemStyle-Width="175" HeaderStyle-Width="175" SortExpression="Field" HeaderText="Field" UniqueName="field" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="title" AllowSorting="true" SortExpression="Title" ItemStyle-Width="150" HeaderStyle-Width="150" HeaderText="Title" UniqueName="Title"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="width" AllowSorting="true" SortExpression="Width" HeaderText="Width" UniqueName="Width" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="format" AllowSorting="true" SortExpression="format" HeaderText="Format" UniqueName="Format" ItemStyle-Width="100" HeaderStyle-Width="100"></telerik:GridBoundColumn>
                        <telerik:GridDropDownColumn DataField="type"  AllowSorting="true" EnableEmptyListItem="true" EmptyListItemText="No items" EmptyListItemValue="0"  DataSourceID="SqlDataSource1" ListTextField="fldName" ListValueField="fldId" SortExpression="type" HeaderText="Type" UniqueName="type" DropDownControlType="DropDownList" ItemStyle-Width="100" HeaderStyle-Width="100">
                            
                        </telerik:GridDropDownColumn>
                         <telerik:GridCheckBoxColumn DataField="include" AllowSorting="true" SortExpression="fldincludeInSQL" HeaderText="Include" UniqueName="fldincludeInSQL" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridCheckBoxColumn>
                        <telerik:GridCheckBoxColumn DataField="hidden" AllowSorting="true" SortExpression="hidden" HeaderText="Hidden" UniqueName="Hidden" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridCheckBoxColumn>
                        <telerik:GridCheckBoxColumn DataField="fldExcludeFromExtract" AllowSorting="true" SortExpression="fldExcludeFromExtract" HeaderText="fldExcludeFromExtract" UniqueName="fldExcludeFromExtract" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridCheckBoxColumn>
                        <telerik:GridCheckBoxColumn DataField="filterable" AllowSorting="true" SortExpression="filterable" HeaderText="Filterable" UniqueName="Filterable" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridCheckBoxColumn>
                        <telerik:GridCheckBoxColumn DataField="sortable" AllowSorting="true" SortExpression="sortable" HeaderText="Sortable" UniqueName="Sortable" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridCheckBoxColumn>
                        <telerik:GridCheckBoxColumn DataField="menu" AllowSorting="true" SortExpression="menu" HeaderText="Menu" UniqueName="Menu" ItemStyle-Width="50" HeaderStyle-Width="50"></telerik:GridCheckBoxColumn>             
                        <%--<telerik:GridBoundColumn DataField="indexorder" AllowSorting="true" SortExpression="Width" HeaderText="Index" ReadOnly="true" UniqueName="Index" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>--%>
                    </Columns>
                </telerik:GridTableView>
            </DetailTables>
        </MasterTableView>
    </telerik:RadGrid>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</telerik:RadAjaxPanel>
   
