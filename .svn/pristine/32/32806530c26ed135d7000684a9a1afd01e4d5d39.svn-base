<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="CurrencyMeta.ascx.vb" Inherits="GRC.Connect.Web.CurrencyMeta" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="false" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Height="900px" Width="900px">
    <telerik:RadGrid ID="RadGridCurrency" AllowSorting="true" Skin="Web20" MasterTableView-DataKeyNames="fldId" AutoGenerateColumns="false" runat="server">
        <MasterTableView EditMode="Batch" AllowFilteringByColumn="false" AllowPaging="false" PageSize="100" BatchEditingSettings-EditType="Cell" CommandItemSettings-ShowSaveChangesButton="true" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="true" AutoGenerateColumns="false" CommandItemDisplay="Top">
            <GroupByExpressions>
                <telerik:GridGroupByExpression>
                    <SelectFields>
                        <telerik:GridGroupByField FieldName="fldClientCurrencyId" SortOrder="Ascending" HeaderText="Client Curency ID"  />
                    </SelectFields>
                    <GroupByFields>
                        <telerik:GridGroupByField FieldName="fldClientCurrencyId"  FieldAlias="Currency" HeaderText="Client Curency ID" />
                    </GroupByFields>
                </telerik:GridGroupByExpression>
            </GroupByExpressions>
            <Columns>
                        <telerik:GridBoundColumn DataField="fldFromCode" ItemStyle-Width="75" HeaderStyle-Width="75" HeaderText="From" UniqueName="FromCurency" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldToCode" ItemStyle-Width="75" HeaderStyle-Width="75" HeaderText="To" UniqueName="ToCurency" ReadOnly="true"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="fldExchangeRate" SortExpression="Exhange Rate" HeaderText="Rate" UniqueName="ExchangeRate" ItemStyle-Width="75" HeaderStyle-Width="75"></telerik:GridBoundColumn>
           </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</telerik:RadAjaxPanel>

