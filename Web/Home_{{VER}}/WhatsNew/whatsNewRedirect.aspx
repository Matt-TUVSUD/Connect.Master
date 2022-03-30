<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.master" CodeBehind="whatsNewRedirect.aspx.vb" Inherits="GRC.Connect.Web.whatsNewRedirect" %>
<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/LatLongSearch.css" />

        <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/global.js"></script>
    <script src="../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/NavLink.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/gauge.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/topbanner.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/nav.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/export.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/searchLatLong.js" type="text/javascript"></script>


		<script type="text/javascript" src="jquery/jquery.sticky.js"></script>
		<script type="text/javascript" src="jquery/jquery.printThis.js"></script>
		<script type="text/javascript" src="jquery/jquery.highlight.js"></script>
		<script type="text/javascript" src="jquery/jquery-functions.js"></script>

    	<link type="text/css" href="wnCss/reset.css" rel="stylesheet" />
		<link type="text/css" href="wnCss/grid.css" rel="stylesheet" />
		<link type="text/css" href="wnCss/font-awesome.min.css" rel="stylesheet" />
		<link type="text/css" href="wnCss/common.css" rel="stylesheet" />
        <link type="text/css" href="wnCss/print.css" rel="stylesheet" media="print" />
		
		<link rel="shortcut icon" href="../images/favicon.ico" />
    <link href="../../css/Nav/nav.css" rel="stylesheet" />
    <link href="../../css/pages/mainPageBody.css" rel="stylesheet" />
    <link href="../../css/Utilities/Loader.css" rel="stylesheet" />
    <link href="../../css/Header/header.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div id="view">
        <div id="LatLongHolder">
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="WHAT'S NEW" />

            <br />

<!-- #include file="index.html" -->
</div>
            </div>

</asp:Content> 

