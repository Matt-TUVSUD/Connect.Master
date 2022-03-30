<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="KillExcel.ascx.vb" Inherits="GRC.Connect.Web.KillExcel" %>
<p>
    Current Excel Tasks Running:
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Blue" Text="Label"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Kill Excel" />
</p>
<p>
    &nbsp;</p>
<asp:Label ID="Label2" runat="server"></asp:Label>

