<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Misc.ascx.vb" Inherits="GRC.Connect.Web.Misc" %>

<telerik:RadAjaxPanel ID="RadAjaxPanel1" EnableAJAX="true" LoadingPanelID="RadAjaxLoadingPanel1" runat="server" Width="900px">
    <div style="padding:25px;">
    <asp:Button ID="ValidateEmails" runat="server" Text="Validate Emails" /><br />
    <asp:Label ID="ValidateResult" runat="server" Width="100%" Height="200" Text=""></asp:Label>
    </div>
</telerik:RadAjaxPanel>