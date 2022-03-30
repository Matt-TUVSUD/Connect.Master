<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web._Default_Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/Login/loginStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="loginImgHldr">
        <img class="loginImg" src="../Images/loginSplash.png" />
    </div>
    <div id="loginHldr">
        <div class="maintenanceMsgHldr" style="">
            <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
        </div>
         <p style="font-family: Arial, sans-serif; font-size: 20px; font-weight: 700; margin-top:20px; width: 100%; text-align: left; color:#666;">
            An Error has occured.
        <br />
        <br />
             Click 
             <br /><br />
             <button class="loginBtn" id="btnReLogin" onclick="onReLoginClick(); return false;">Here</button> 
             <br /><br />
             to log back in.
             
            <%--&nbsp;<br />
            Click
            <asp:HyperLink ID="hylLogin" CssClass="logBackInLnk " runat="server">here</asp:HyperLink>
            to log back in.--%>
        </p>
        <div>
            <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
        </div>
    </div>
        <%--<div id="loginPageBody">
            <div id="imageHldr">
                <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
            </div>
            <div id="loginHldr">
                <div class="maintenanceMsgHldr" style="">
                    <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
                </div>
                <div id="logoHldr">
                    <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
                </div>
                <div id="tagLine">
                    <p>
                        Stay Connected to Your<br />
                        Loss Control Information.
                    </p>
                </div>
                <div style="text-align: center;">
                    <button class="loginBtn" id="btnReLogin" onclick="onReLoginClick(); return false;">Log In</button></div>
            </div>
        </div>--%>
    </form>
</body>

<script type="text/javascript">
    function onReLoginClick() {
        // REDIRECT TO THE AUTH LOGIN PAGE
        document.location.href = "<%= ServerSide_AuthURL %>";
        top.location.href = "<%= ServerSide_AuthURL %>";
        return false;
    }

</script>
</html>
