<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="KendoChart01.aspx.vb" Inherits="GRC.Connect.Web.KendoChart01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kendo Chart Sample 01 | GRC Connect</title>
    <meta http-equiv="X-UA-Compatible" content="IE=9; IE=8; IE=7" />
    <meta charset="utf-8" />
    <meta http-equiv="CACHE-CONTROL" content="NO-STORE" />
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <meta name="EXPIRES" content="0" />
    <meta name="VERSION" content="{{VER}}" />

    <script src="../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>

    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/gauge.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/nav.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/icons.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeView.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadTreeViewOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadFileExplorerOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Telerik/RadWindowOffice2010Blue.css" />

    <script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.web.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.all.min.js" type="text/javascript"></script>
    <%--<script src="../../Lib_{{VER}}/kendo.web.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/knockoutkendo.v0.9.3/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/jquery.hoverintent.min.js" type="text/javascript"></script>
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
    <div id="example">
        <div class="demo-section k-content">
            <div id="chart" style="background: center no-repeat url('http://demos.telerik.com/kendo-ui/content/shared/styles/world-map.png');"></div>
        </div>
        <script>
            function createChart() {
                $("#chart").kendoChart({
                    title: {
                        text: "Gross domestic product growth\nGDP annual %"
                    },
                    legend: {
                        visible: true,
                        position: "bottom"
                    },
                    chartArea: {
                        background: ""
                    },
                    seriesDefaults: {
                        type: "line"
                        //style: "smooth"
                    },
                    series: [{
                        name: "India",
                        data: [3.907, 7.943, 7.848, 9.284, 9.263, 9.801, 3.890, 8.238, 9.552, 6.855]
                    }, {
                        name: "World",
                        data: [1.988, 2.733, 3.994, 3.464, 4.001, 3.939, 1.333, -2.245, 4.339, 2.727]
                    }, {
                        name: "Russian Federation",
                        data: [4.743, 7.295, 7.175, 6.376, 8.153, 8.535, 5.247, -7.832, 4.3, 4.3]
                    }, {
                        name: "Haiti",
                        data: [-0.253, 0.362, -3.519, 1.799, 2.252, 3.343, 0.843, 2.877, -5.416, 5.590]
                    }],
                    valueAxis: {
                        labels: {
                            format: "{0}%"
                        },
                        line: {
                            visible: false
                        },
                        axisCrossingValue: -10
                    },
                    categoryAxis: {
                        categories: [2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012],
                        majorGridLines: {
                            visible: false
                        },
                        labels: {
                            rotation: "auto"
                        }
                    },
                    tooltip: {
                        visible: true,
                        format: "{0}%",
                        template: "#= series.name #: #= value #"
                    }
                });
            }

            $(document).ready(createChart);
            $(document).bind("kendo:skinChange", createChart);
        </script>
    </div>

    </form>
</body>
</html>
