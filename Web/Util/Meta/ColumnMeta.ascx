<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ColumnMeta.ascx.vb" Inherits="GRC.Connect.Web.BatchColumn" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="false" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Height="900px" Width="900px">
    <telerik:RadGrid ID="RadGridByColumn" AllowSorting="true" Skin="Web20" MasterTableView-DataKeyNames="Field, Title" AutoGenerateColumns="false" runat="server">
        <MasterTableView EditMode="Batch" AllowFilteringByColumn="true" AllowPaging="true" PageSize="30" BatchEditingSettings-EditType="Cell" CommandItemSettings-ShowSaveChangesButton="true" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="true" AutoGenerateColumns="false" CommandItemDisplay="Top">
            <Columns>
                <telerik:GridBoundColumn DataField="Field" AllowSorting="true" ItemStyle-Width="200"  HeaderStyle-Width="200" SortExpression="Field" HeaderText="Field" UniqueName="field" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="AppearCount" AllowSorting="true" ItemStyle-Width="75" HeaderStyle-Width="75" SortExpression="AppearCount" HeaderText="Appear Count" UniqueName="AppearCount" ReadOnly="true"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Title" AllowSorting="true" SortExpression="Title" ItemStyle-Width="200" HeaderStyle-Width="200" HeaderText="Title" UniqueName="Title"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Width" AllowSorting="true" SortExpression="Width" HeaderText="Width" UniqueName="Width" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>
            </Columns>
            <DetailTables>
                <telerik:GridTableView DataKeyNames="fldId">
                    <ParentTableRelation>
                        <telerik:GridRelationFields MasterKeyField="Field" DetailKeyField="Field" />
                    </ParentTableRelation>
                    <Columns>
                        <telerik:GridButtonColumn DataTextField="GridName" CommandName="NavigateToGrid" ButtonType="LinkButton" ItemStyle-Width="200" HeaderStyle-Width="200" HeaderText="Grid"></telerik:GridButtonColumn>
                        <telerik:GridBoundColumn DataField="Source" ItemStyle-Width="200" HeaderStyle-Width="200" HeaderText="Data Source"></telerik:GridBoundColumn>
                    </Columns>
                </telerik:GridTableView>
            </DetailTables>
        </MasterTableView>
    </telerik:RadGrid>
</telerik:RadAjaxPanel>

