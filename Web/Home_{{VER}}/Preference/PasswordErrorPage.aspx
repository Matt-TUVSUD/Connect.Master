<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="PasswordErrorPage.aspx.vb" Inherits="GRC.Connect.Web.PasswordErrorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/Generated/EzyUsers.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/EzyUsers.js" type="text/javascript"></script>
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
        <div class="userHldr">
            <div class="divTable" style="width: 400px;">
                <asp:Label ID="lblErrorMessage1" runat="server" Style="margin-bottom: 10px; color: #ff0000; text-align: left; font-size: 14px;">test</asp:Label>
                <br /><br />
                <label style="text-align: left; font-size: 16px; font-family: Arial, sans-serif;">You will receive an email containing a link for you to reset your password.</label>
            <div style="text-align: center">
                <div style="width: 455px; text-align: center;">
                    &nbsp;
                </div>
            </div>
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
            </div>
        </div>
        
    </div>

    <div style="text-align: center;" id="view" data-bind="with: view">
        
    </div>    

</asp:Content>
