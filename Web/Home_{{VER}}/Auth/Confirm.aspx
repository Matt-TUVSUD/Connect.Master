<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Confirm.aspx.vb" Inherits="GRC.Connect.Web.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center;">
        <h1>Welcome to <span class="logoLetters_h1">GRC</span> Connect</h1>
        <h3>Stay Connected to Your Loss Control Information</h3>
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
        <br />&nbsp;<br />&nbsp;<br />&nbsp;<br />&nbsp;<br />
    </div>
</asp:Content>