<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="RevisionStampControl.ascx.vb" Inherits="GRC.Connect.Web.RevisionStampControl" %>
<div id="divRevisionStamp" class="revisionStamp printNone">
    <asp:Label ID="lblRevisionStamp" runat="server" Text=""></asp:Label>&nbsp;<asp:HyperLink ID="hypRevisions" runat="server" Text="Notes" Target="_blank" NavigateUrl="~/revision_history.txt"/>
</div>
