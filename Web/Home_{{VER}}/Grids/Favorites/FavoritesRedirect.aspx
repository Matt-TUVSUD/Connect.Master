<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FavoritesRedirect.aspx.vb" Inherits="GRC.Connect.Web.FavoritesRedirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Verdana">
        <br />
            <asp:Label runat="server" ID="lblMessage"></asp:Label>
            <br />
            <br />
            <a runat="server" id="linkBack" href="">Click Here</a> to return to your favorites library.
    </div>
    </form>
</body>
</html>
