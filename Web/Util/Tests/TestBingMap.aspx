<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestBingMap.aspx.vb" Inherits="GRC.Connect.Web.TestBingMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/GRCConnect/connect-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/GRCConnect/connect-icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/EDA/eda.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/EDA/cssgrid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/rectracking.css" />
    <link rel="stylesheet" type="text/css" href="../../../css/pages/mapping.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/font-awesome.min.css" />
    
    <script src="../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js"></script>
    <script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.web.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.grc.grid.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/knockoutkendo.v0.9.3/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/global.js"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js"></script>

    <script src="../../Lib_{{VER}}/Mapping/bluebird.v3.5.0.min.js"></script>
    <script charset="UTF-8" type="text/javascript" src="https://www.bing.com/api/maps/mapcontrol"></script>
    <script src="../../Lib_{{VER}}/Mapping/bingLT.v8.0.2.min.js"></script>
    <script src="../../Lib_{{VER}}/Mapping/bingMapUtil.v8.0.2.js"></script>
    <script src="../../Lib_{{VER}}/Picklist/Picklist_v2015.04.09.js"></script>
    <%--<script src="../../Lib_{{VER}}/Mapping/Standard.js"></script>--%>
    <script src="TestBingMapData.js"></script>
    <script src="TestBingMap.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <button onclick="gShowMap(); return false;">Show Map</button>
    &nbsp;&nbsp;&nbsp;
    <button onclick="gDrawCircles(); return false;">Draw Circles</button>

    <div class="locListBG ui-helper-clearfix" id="divContainerMap" style="display: none; position: absolute; width: 100%; height: 100%; background-image: none; z-index: 1">
        <div id="viewMap">
            <!-- LOADING -->
            <div class="containerLoading" id="divContainerLoadingMap" style="display: none;"></div>
            <span id="txtMapMessage" style="display: none;"></span>
            <div id="mapPage" class="mapPage">
                <div id="mapContainer" class="mapContainer" style="background-color: magenta;"><br /><br /><br /></div>
            </div>
        </div>
    </div>



    </div>
    </form>
</body>
</html>
