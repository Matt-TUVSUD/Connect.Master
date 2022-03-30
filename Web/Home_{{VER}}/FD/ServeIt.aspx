<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ServeIt.aspx.vb" Inherits="GRC.Connect.Web.ServeIt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowError" class="windowError">
        <div style="text-align: left;">
            <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImageSmallPadding" /></div>
            <div style="padding-top: 6px;">Warning: An error has occurred.</div>
        </div>
        <br />&nbsp;<br />&nbsp;<br />
        <div style="text-align: left;">A file link error has occurred in the ServeIt file which requires a resource refresh.  Please click the below button to log in again.</div>
        <br />&nbsp;<br />
        <div style="text-align: center;"><button class="k-button k-button-padding" id="btnReLogin" onclick="onReLoginClick(); return false;">Log In</button></div>
    </div>

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
