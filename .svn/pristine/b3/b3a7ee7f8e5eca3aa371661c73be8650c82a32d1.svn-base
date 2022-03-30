<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Resecure.aspx.vb" Inherits="GRC.Connect.Web.Resecure" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Refresh" content="2; URL=../Auth/" />
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:flex;flex-direction:column;">
        <%--<div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>--%>
        <div class="loginImgHldr">
            <img class="loginImg" src="../../Home_{{VER}}/Images/loginSplash.png" />
        </div>
        <div id="loginHldr">
            <div class="maintenanceMsgHldr" style="">
                <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
            </div>
            <%--<div id="logoHldr">
                <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
            </div>--%>
           <%-- <div id="tagLine">
                <p>
                    Stay Connected to Your<br />
                    Loss Control Information.
                </p>
            </div>--%>
            <div class="userHldr">
                <div style="font-size: 20px">
                    <span class="logoLetters_Medium">GRC</span> Connect Re-Secure Area
                </div>

                <br />
                &nbsp;<br />

                <div style="font-size: 16px; font-family: Arial, sans-serif; color: #000;">
                    <strong>S</strong>ecurity <strong>A</strong>uthentication <strong>I</strong>nterruption <strong>D</strong>etector<br />
                </div>

                <br />
                &nbsp;<br />

                <div style="font-size: 16px; font-family: Arial, sans-serif; color: #000;">
                    <strong>SAID</strong> has detected a timeout of your session due to a period of
            <br />
                    inactivity. You will be re-directed to the login screen momentarily.
                </div>
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>