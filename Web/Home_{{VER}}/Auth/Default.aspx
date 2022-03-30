<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web.DefaultAuth" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>--%>
    <div class="loginImgHldr">
        <img class="loginImg" src="../Images/loginSplash.png" />
    </div>
    <div class="loginContent" style="display:flex; flex-direction:row;">
        <div id="loginHldr">
            <%--<div id="logoHldr">
            <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
        </div>
        <div id="tagLine">
            <p>Stay Connected to Your<br />
                Loss Control Information</p>
        </div>--%>
            <div class="maintenanceMsgHldr" style="">
                <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
            </div>
            <label class="emailLbl">Email *</label>
            <div class="userHldr">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="textInput" type="text" />
            </div>
            <label class="pwLbl">Password *</label>
            <div id="pwHldr">
                <asp:TextBox ID="txtPassword" runat="server" autocomplete="off" CssClass="textInput" type="password"></asp:TextBox>
            </div>
            <div id="btnHldr">
                <asp:Button ID="btnAuthenticate" CssClass="loginBtn" runat="server" Text="Login" />
            </div>
            <div id="resetHldr">
                <asp:LinkButton ID="lnkPasswordReset" CssClass="loginPageLnk" runat="server" Text="Forgot/Reset Password">Forgot/Reset Password</asp:LinkButton>
            </div>
            <div id="contactHldr">
                <a href="mailto:grc-ITApplications@tuvsud.com" class="loginPageLnk">Contact Us</a>
            </div>
        </div>
        <div style="width:565px; text-align: center;display: flex;flex-direction: column;justify-content: center;">
            <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
        </div>
    </div>
</asp:Content>
