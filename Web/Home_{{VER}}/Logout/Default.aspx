<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultLogout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>--%>
    <div class="loginImgHldr">
        <img class="loginImg" src="../Images/loginSplash.png" />
    </div>
    <div id="loginHldr">
        <div class="maintenanceMsgHldr" style="">
            <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
        </div>
        <%--<div id="logoHldr">
            <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
        </div>
        <div id="tagLine">
            <p>Stay Connected to Your<br />
                Loss Control Information.</p>
        </div>--%>
        <p style="font-family: Arial, sans-serif; font-size: 20px; font-weight: 700; margin-top:20px; width: 100%; text-align: left; color:#666;">
            Thank you for using the TUV SUD GRC Connect database system!
        <br />
            &nbsp;<br />
            Click
            <asp:HyperLink ID="hylLogin" CssClass="logBackInLnk " runat="server">here</asp:HyperLink>
            to log back in.
        </p>
        <div>
            <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
        </div>
    </div>

    
</asp:Content>
