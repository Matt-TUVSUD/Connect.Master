<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="LossEstBeforeMeta.ascx.vb" Inherits="GRC.Connect.Web.LossEstimateBeforeMeta" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="false" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Height="900px" Width="900px">
    <telerik:RadGrid ID="RadGridLossEstimate" AllowSorting="true" Skin="Web20" ClientSettings-AllowDragToGroup="true" ShowGroupPanel="false" MasterTableView-DataKeyNames="fldId" AutoGenerateColumns="false" runat="server">
        <MasterTableView EditMode="Batch" AllowFilteringByColumn="false" AllowPaging="false" PageSize="100" BatchEditingSettings-EditType="Cell" CommandItemSettings-ShowSaveChangesButton="true" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="true" AutoGenerateColumns="false" CommandItemDisplay="Top">
            <GroupByExpressions>
                <telerik:GridGroupByExpression>
                    <SelectFields>
                        <telerik:GridGroupByField FieldName="fldClientCurrencyId" SortOrder="Ascending" HeaderText="Client Curency ID"  />
                        <telerik:GridGroupByField FieldName="fldCode" SortOrder="Ascending" HeaderText="Currency"  />
                    </SelectFields>
                    <GroupByFields>
                        <telerik:GridGroupByField FieldName="fldClientCurrencyId"  FieldAlias="CurrencyId" HeaderText="Client Curency ID" />
                        <telerik:GridGroupByField FieldName="fldCode"  FieldAlias="Currency" HeaderText="Currency" />

                    </GroupByFields>
                </telerik:GridGroupByExpression>
            </GroupByExpressions>
            <Columns>
                        <telerik:GridBoundColumn DataField="fldCode" SortExpression="fldCode" HeaderText="Currency" ItemStyle-Width="75" HeaderStyle-Width="75"  UniqueName="FromCurency" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldRangeText" SortExpression="fldRangeText" HeaderText="LE Before Text" UniqueName="Text" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldRangeDisplay" SortExpression="fldRangeDisplay" HeaderText="LE Before Display" UniqueName="Display" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldRangeValueLow" SortExpression="fldRangeValueLow" HeaderText="Low Value" UniqueName="RangeValueLow" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldRangeValueHigh" SortExpression="fldRangeValueHigh" HeaderText="High Value" UniqueName="RangeValueHigh" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>
           </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</telerik:RadAjaxPanel>

