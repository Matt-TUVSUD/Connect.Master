<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CheckWCF.aspx.vb" Inherits="GRC.Connect.Web.CheckWCF" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Button ID="cmdWCFHTTPTest" runat="server" Text="WCF HTTP Test" />
&nbsp;Service Endpoint:
    <asp:TextBox ID="txtServiceEndPoint" runat="server">/Service/DataServer.svc</asp:TextBox>
&nbsp;Service Action:
    <asp:TextBox ID="txtServiceAction" runat="server" Width="300px">ClientsCollection_BrowseByName</asp:TextBox>
&nbsp;Parm:
    <asp:TextBox ID="txtParm" runat="server">ik</asp:TextBox>
    <br />
    <br />
    <asp:Button ID="cmdWCFDirectTest" runat="server" Text="WCF Direct Test" />
    <br />
    <br />
    Log: <br />
    <asp:TextBox ID="txtLog" runat="server" Height="150px" TextMode="MultiLine" 
        Width="800px"></asp:TextBox>
    <br />
    <br />
    JSON Response Data: (formatted)<br />
    <asp:TextBox ID="txtJSONFormatted" runat="server" Height="200px" TextMode="MultiLine" 
        Width="800px"></asp:TextBox>
    <br />
    <br />
    JSON Response Data: (raw)<br />
    <asp:TextBox ID="txtJSONRaw" runat="server" Height="100px" TextMode="MultiLine" 
        Width="800px"></asp:TextBox>
    <br />
    </form>
</body>
</html>
