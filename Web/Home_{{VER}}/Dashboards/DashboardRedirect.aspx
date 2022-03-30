<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="DashboardRedirect.aspx.vb" Inherits="GRC.Connect.Web.DashboardRedirect" %>

<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/print.css" media="print" />
    
    <link rel="Stylesheet" type="text/css" href="../../css/pages/LatLongSearch.css" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <grcRSC:Loader runat="server" id="loader" />

    <div id="view" class="pgBodyContent" style="align-items:center;">
        <div id="LatLongHolder">
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="Dashboards" SubHeader="Limited Access" />


        <p>
            You are not currently able to access the dashboards.<br /><br />
            Contact your servicing team to gain access to the dashboards.<br />
<h4>Dashboards require a modern browser such as Microsoft Edge, Chrome, Safari Mac, or Firefox.<br />
Dashboards will NOT work with Internet Explorer.</h4><br />
            Continue to view the dashboards with sample data.&nbsp;
           <asp:button text="Continue to Dashboard" ID="button1" runat="server" />
       </p>
    </div>
</asp:Content>
