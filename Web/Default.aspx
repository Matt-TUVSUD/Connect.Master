<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Refresh" content="3; URL=Home_{{VER}}/Auth/" />
    <title>TUV SUD GRC Connect</title>
    <%--<link rel="Stylesheet" type="text/css" href="css/pages/global.css" />--%>

    <%-- UPDATED JAVASCRIPT --%>
    <%--<script src="Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>--%>
    <script src="Lib_{{VER}}/JQuery/jQuery.3.4.1.min.js" type="text/javascript"></script>

</head>
<body style="width: 100%;">
    <form id="form1" runat="server">
    <br />&nbsp;<br />&nbsp;<br />

    <div style="text-align: center; width: 100%">
        <h1>Welcome to <span class="logoLetters_h1">GRC</span> Connect</h1>
        <h3>Stay Connected to Your Loss Control Information</h3>
        <%--<img src="Home_{{VER}}/Images/logos/globes_dulled_434x441.png" alt="GRC Connect" style="width: 325px; height: 330px;" />--%>
        <img src="Home_{{VER}}/Images/logos/logo_earth_connection_muted_256x256.png" alt="GRC Connect" style="width: 256px; height: 256px;" />
    </div>

    <br />&nbsp;<br />&nbsp;<br />

    <div style="font-size: 12pt; text-align: center; width: 100%">You are being forwarded to the authentication area.</div>

    <br />

    <div style="font-size: 12pt; text-align: center; width: 100%"><strong><label id="lblForwarded">.</label></strong></div>
    </form>
</body>

<script type="text/javascript">
    //// INTERVAL TO AUTO LOOP THROUGH PRACTICES ON GAUGE
    $(document).ready(function () {
        var i = 0;
        var messageLoop = self.setInterval(function () {
            switch (i) {
                case 1:
                    //$("#lblForwarded").html("You are being forwarded to the authentication area.");
                    $("#lblForwarded").html(".");
                    break;
                case 2:
                    //$("#lblForwarded").html("You are being forwarded to the authentication area..");
                    $("#lblForwarded").html("..");
                    break;
                case 3:
                    //$("#lblForwarded").html("You are being forwarded to the authentication area...");
                    $("#lblForwarded").html("...");
                    break;
                case 4:
                    //$("#lblForwarded").html("You are being forwarded to the authentication area");
                    $("#lblForwarded").html("");
                    break;
                default:
                    i = 0;
            }
            i++;
        }, 250);
    });
</script>

</html>
