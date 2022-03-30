<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SearchIndexTest.aspx.vb" Inherits="GRC.Connect.Web.SerchIndexTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />

    <%-- ORIGINAL STYLES --%>
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/gauge.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindowOffice2010Blue.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/EDA/cssgrid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/EDA/eda.css" />



    <script src="../../Lib_{{VER}}/jquery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.web.min.js" type="text/javascript"></script>
    <%--<script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.all.min.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/knockoutkendo.v0.9.3/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery.hoverIntent.v1.8.0/jquery.hoverIntent.minified.js"></script>

    <%-- ORIGINAL JAVASCRIPT --%>
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="searchWindow"></div>
    </div>
    </form>
    <script>
        $(document).ready(function () {
            var searchWindow = $('#searchWindow');
            searchWindow.kendoWindow({
                visible: true,
                width: "850px",
                height: "515px",
                modal: true,
                content: "https://grcconnecttest.globalriskconsultants.com/idx/test4matt/search.asp",
                iframe: true,
                draggable: true
            }).data("kendoWindow").center().open();
        });
    </script>
</body>
</html>
