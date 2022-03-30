<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestTotalRatingsChart.aspx.vb" Inherits="GRC.Connect.Web.TestTotalRatingsChart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Facility Ratings</title>
    
    <script type="text/javascript">
        /* A PUBLIC CLASS TO HOLD CONSTANTS */
        var utilConstants = new function () {
            /* PRACTICE or PROGRAM PAGE IDs */
            this.pageId_Gauge = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Gauge %>";
        this.pageId_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Fire %>";
        this.pageId_Boiler = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Boiler %>";
        this.pageId_Juris = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Juris %>";
        this.pageId_Infrared = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Infrared %>";
        this.pageId_Seismic = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Seismic %>";
        this.pageId_Wind = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Wind %>";
        this.pageId_Flood = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Flood %>";

        /* LOCATION LISTING or GRID PAGE */
        this.pageId_LocationListing_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Fire %>";
        this.pageId_LocationListing_Boiler = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Boiler %>";
        this.pageId_LocationListing_Juris = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Juris %>";
        this.pageId_LocationListing_Infrared = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Infrared %>";
        this.pageId_LocationListing_Seismic = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Seismic %>";
        this.pageId_LocationListing_Wind = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Wind %>";
        this.pageId_LocationListing_Flood = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationListing_Flood %>";

        /* LOCATION DETAILS PAGE */
        this.pageId_LocationDetails_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Fire %>";
        this.pageId_LocationDetails_Boiler = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Boiler %>";
        this.pageId_LocationDetails_Juris = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Juris %>";
        this.pageId_LocationDetails_Infrared = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Infrared %>";
        this.pageId_LocationDetails_Seismic = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Seismic %>";
        this.pageId_LocationDetails_Wind = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Wind %>";
        this.pageId_LocationDetails_Flood = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LocationDetails_Flood %>";

        /* FACILITY RATINGS PAGE */
        this.pageId_FacilityRating_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_FacilityRating_Fire %>";
        this.pageId_FacilityRating_Boiler = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_FacilityRating_Boiler %>";

        /* RECOMMENDATION TRACKING PAGE */
        this.pageId_RecommendationTracking_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Fire %>";
        this.pageId_RecommendationTracking_Fire_Feature_X = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Fire_Feature_X %>";
        this.pageId_RecommendationTracking_Boiler = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Boiler %>";
        this.pageId_RecommendationTracking_Infrared = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Infrared %>";
        this.pageId_RecommendationTracking_Seismic = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Seismic %>";
        this.pageId_RecommendationTracking_Wind = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Wind %>";
        this.pageId_RecommendationTracking_Flood = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecommendationTracking_Flood %>";

        /* C.O.P.E. PAGE */
        this.pageId_COPE_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_COPE_Fire %>";

        /* IMPAIRMENTS */
        this.pageId_Impairments_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Impairments_Fire %>";

        /* PLAN / PROJECT REVIEW */
        this.pageId_PlanProjectReview_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_PlanProjectReview_Fire %>";

        /* CONTACTS */
        this.pageId_Contacts_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_Contacts_Fire %>";

        /* DOCUMENT LIBRARY */
        this.pageId_DocumentLibrary_Fire = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_DocumentLibrary_Fire %>";

        /* OTHER PAGES */
        this.pageId_ClientAdmin = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_ClientAdmin %>";
        this.pageId_SiteMap = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_SiteMap %>";
        this.pageId_AllReports = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_AllReports %>";
        this.pageId_AllExports = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_AllExports %>";
        this.pageId_ContactUs = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_ContactUs %>";
        this.pageId_LogOut = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LogOut %>";
        this.pageId_LogOutGrid = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_LogOutGrid %>";
        this.pageId_RecentUpdates = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_RecentUpdates %>";
        this.pageId_WhatsNew = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_WhatsNew %>";
        this.pageId_UserReclassification = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_UserReclassification%>";
        this.pageId_UserAccount = "<%# GRC.Connect.Libraries.CoreLib.UtilConstants.PageId_UserAccount%>";

        /* GRIDS */
        this.GridId_BMLocationListings = "61";
        this.GridId_BMLocationListingsExtract = "62";
        this.GridId_FireLocationListingsExtract = "63";
        this.GridId_FireLocationListingsWithImpairmentsExtract = "64";
        this.GridId_FireLocationListingsWithoutImpairmentsExtract = "65";
        this.GridId_IRLocationListingsExtract = "66";
        this.GridId_JurisLocationListingsExtract = "67";
        this.GridId_NatHazFloodLocationListingsExtract = "68";
        this.GridId_NatHazSeismicLocationListingsExtract = "69";
        this.GridId_NatHazWindLocationListingsExtrac = "70";
        this.GridId_FireLocationListings = "71";
        this.GridId_IRLocationListings = "72";
        this.GridId_JurisLocationListings = "73";
        this.GridId_NatHazFloodLocationListings = "74";
        this.GridId_NatHazSeismicLocationListings = "75";
        this.GridId_NatHazWindLocationListings = "76";
    };

    /* OTHER GLOBAL VARIABLES */
    var globalIsMapShown = false;

    /* FUNCTIONS */
    function closeWindow() {
        window.close();
    }

    function goBack() {
        history.back();
    }

    function showNotAvailable() {
        alert("This functionality is not yet available.");
    }

    function ShowGenerating(pMS) {
        /* SHOW A GENERATING POPUP FOR A NUMBER OF MILLISECONDS */
    }

    var windowObjectReference = null;
    var PreviousUrl;
    function openRequestedSinglePopup(strUrl, gridId, chartId, reportId) {
        // BUILD THE IDS USED FOR REPORTS, GRIDS, AND CHARTS
        var zQueryOperator = "?";
        var zItemAdded = false;
        if (strUrl.indexOf("?") > -1) {
            zQueryOperator = "&";
        }
        if (gridId !== undefined && gridId !== null) {
            strUrl = strUrl + zQueryOperator + "gridId=" + gridId;
            zQueryOperator = "&";
        }
        if (chartId !== undefined && chartId !== null) {
            strUrl = strUrl + zQueryOperator + "chartId=" + chartId;
            zQueryOperator = "&";
        }
        if (reportId !== undefined && reportId !== null) {
            strUrl = strUrl + zQueryOperator + "reportId=" + reportId;
            zQueryOperator = "&";
        }
        // NAVIGATE TO THE CORRECT AREA
        if (windowObjectReference == null || windowObjectReference == undefined || windowObjectReference.closed) {
            //// IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
            windowObjectReference = window.open(strUrl, "SingleSecondaryWindowName", "resizable=yes,scrollbars=yes,status=yes");
            windowObjectReference.focus();
        }
        else if (PreviousUrl != strUrl) {
            //// IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
            windowObjectReference.location.href = strUrl;
            windowObjectReference.focus();
        }
        else {
            //// IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
            windowObjectReference.focus();
        };
        PreviousUrl = strUrl;
    }

    var windowObjectReferenceFromChart = null;
    function openRequestedFromChartPopup(strUrl) {
        // BUILD THE IDS USED FOR REPORTS, GRIDS, AND CHARTS
        var zQueryOperator = "?";
        var zItemAdded = false;
        if (strUrl.indexOf("?") > -1) {
            zQueryOperator = "&";
        }
        // NAVIGATE TO THE CORRECT AREA
        if (windowObjectReferenceFromChart == null || windowObjectReferenceFromChart == undefined || windowObjectReferenceFromChart.closed) {
            // IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
            windowObjectReferenceFromChart = window.open(strUrl, "SingleSecondaryWindowFromChartName", "resizable=yes,scrollbars=yes,status=yes");
            windowObjectReferenceFromChart.focus();
        }
        else if (PreviousUrl != strUrl) {
            // IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
            windowObjectReferenceFromChart.location.href = strUrl;
            windowObjectReferenceFromChart.focus();
        }
        else {
            // IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
            windowObjectReferenceFromChart.focus();
        };
        PreviousUrl = strUrl;
    }

    var windowObjectReferenceKnowledgeBase = null;
    function openRequestedKnowledgeBasePopup(strUrl, pNavId) {
        // BUILD THE URL
        var zGUID = getGSafeGUID();
        var zQueryOperator = "?";
        var zSection = "";
        if (globalIsMapShown) {
            zSection = "#lnk4Map";
            //zSection = "#mapView";
        }
        if (strUrl) {
            if (strUrl.indexOf("?") > -1) {
                zQueryOperator = "&";
            }
            strUrl = strUrl + zQueryOperator + "sid=" + zGUID + zSection;
        } else {
            strUrl = "../../KnowledgeBase/index.html" + zQueryOperator + "sid=" + zGUID + zSection;
            zQueryOperator = "&";
        }
        // BUILD THE IDS USED FOR REPORTS, GRIDS, AND CHARTS
        var zOptionsKnowledgeBase = "" +
            "width=890" +
            ",height=600" +
            ",location=no" +
            ",menubar=no" +
            ",resizable=yes" +
            ",scrollbars=yes" +
            ",status=yes" +
            ",titlebar=no" +
            ",toolbar=no";
        var zItemAdded = false;
        // NAVIGATE TO THE CORRECT AREA
        if (windowObjectReferenceKnowledgeBase == null || windowObjectReferenceKnowledgeBase == undefined || windowObjectReferenceKnowledgeBase.closed) {
            // IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
            windowObjectReferenceKnowledgeBase = window.open(strUrl, "SingleSecondaryWindowKnowledgeBaseName", zOptionsKnowledgeBase);
            windowObjectReferenceKnowledgeBase.focus();
        }
        else if (PreviousUrl != strUrl) {
            // IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
            windowObjectReferenceKnowledgeBase.location.href = strUrl;
            windowObjectReferenceKnowledgeBase.focus();
        }
        else {
            // IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
            windowObjectReferenceKnowledgeBase.focus();
        };
        PreviousUrl = strUrl;
    }

    var windowObjectReferenceWhatsNew = null;
    function openRequestedWhatsNew(strUrl, pNavId) {
        // BUILD THE IDS USED FOR REPORTS, GRIDS, AND CHARTS
        var zOptionsWhatsNew = "" +
            "width=1050" +
            ",height=700" +
            ",location=no" +
            ",menubar=no" +
            ",resizable=yes" +
            ",scrollbars=yes" +
            ",status=yes" +
            ",titlebar=no" +
            ",toolbar=no";
        var zQueryOperator = "?";
        var zItemAdded = false;
        if (strUrl.indexOf("?") > -1) {
            zQueryOperator = "&";
        }
        // NAVIGATE TO THE CORRECT AREA
        if (windowObjectReferenceWhatsNew == null || windowObjectReferenceWhatsNew == undefined || windowObjectReferenceWhatsNew.closed) {
            // IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
            windowObjectReferenceWhatsNew = window.open(strUrl, "SingleSecondaryWindowWhatsNewName", zOptionsWhatsNew);
            // windowObjectReferenceWhatsNew.focus();
        }
        else if (PreviousUrl != strUrl) {
            // IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
            windowObjectReferenceWhatsNew.location.href = strUrl;
            windowObjectReferenceWhatsNew.focus();
        }
        else {
            // IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
            windowObjectReferenceWhatsNew.focus();
        };
        PreviousUrl = strUrl;
    }



    var searchWindow = null;
    var gSearchEngineUrl = null;
    function searchLinkClick(pUrl) {
        // BUILD THE URL WITH THE PARMS
        var zGSafeGUID = getGSafeGUID();
        var zOperator = "&";
        gSearchEngineUrl = pUrl;
        var zUrl = pUrl;
        if (zUrl.indexOf("?") < 0) {
            var zMode = "l";
            zUrl = zUrl + "?sid=" + zGSafeGUID + "mo=" + zMode;
        }
        //BUILD THE WINDOW AND OPEN
        if (!searchWindow) {
            searchWindow = $('#searchWindow');
            searchWindow.kendoWindow({
                visible: false,
                title: "Document Library",
                width: "850px",
                height: "515px",
                modal: true,
                content: zUrl,
                iframe: true,
                open: function (e) {
                    var zGSafeGUID = getGSafeGUID();
                    var zOperator = "&";
                    var zTempUrl = gSearchEngineUrl;
                    if (zTempUrl.indexOf("?") < 0) {
                        var zMode = "l";
                        zTempUrl = zTempUrl + "?sid=" + zGSafeGUID + "mo=" + zMode;
                    }
                    var data = $("#searchWindow").data("kendoWindow");
                    data.refresh(zTempUrl)
                }

            }).data("kendoWindow").center().open();
        } else {
            searchWindow.data("kendoWindow").center().open();
        }
    }

    var searchLatLongWindow = null;
    var gSearchLatLongUrl = null;
    var gSearchLatLongGridId = null;
    function searchLatLongLinkClick(pUrl, pNavLinkId, pGridId) {
        // BUILD THE URL WITH THE PARMS
        var zGSafeGUID = getGSafeGUID();
        var zOperator = "&";
        gSearchLatLongGridId = pGridId;
        gSearchLatLongUrl = pUrl;
        var zUrl = pUrl;
        if (zUrl.indexOf("?") < 0) {
            //var zMode = "l";
            zUrl = zUrl + "?sid=" + zGSafeGUID;
        }
        zUrl = zUrl + "&gid=" + gSearchLatLongGridId;
        //BUILD THE WINDOW AND OPEN
        if (!searchLatLongWindow) {
            searchLatLongWindow = $('#searchLatLongFacilityWindow');
            searchLatLongWindow.kendoWindow({
                visible: false,
                title: "Latitude/Longitude Facility Search",
                width: "600px",
                height: "420px",
                modal: true,
                content: zUrl,
                iframe: true,
                open: function (e) {
                    var zGSafeGUID = getGSafeGUID();
                    var zOperator = "&";
                    var zTempUrl = gSearchLatLongUrl;
                    if (zTempUrl.indexOf("?") < 0) {
                        //var zMode = "l";
                        zTempUrl = zTempUrl + "?sid=" + zGSafeGUID;
                    }
                    zTempUrl = zTempUrl + "&gid=" + gSearchLatLongGridId;
                    var data = $("#searchLatLongFacilityWindow").data("kendoWindow");
                    data.refresh(zTempUrl)
                }

            }).data("kendoWindow").center().open();
        } else {
            searchLatLongWindow.data("kendoWindow").center().open();
        }
    }


</script>

    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/windows.css" />
    <link rel="stylesheet" type="text/css" href="../../../css/Charts/all.css" />
    <link rel="stylesheet" type="text/css" href="../../../css/Charts/recommendations.css" />
    <link rel="stylesheet" type="text/css" href="../../../css/pages/print.css" media="print" />

    <script src="../../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <%--<script src="../../../Lib_{{VER}}/KendoUI.v2015.3.1111/kendo.all.min.js"></script>--%>
    <script src="../../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/pages/global.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/pages/constants.js" type="text/javascript"></script>
    <script src="../../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    
    <script>
        var gCurrencyIdFromPrefilter = "<%=ServerSide_CurrencyIdFromPrefilter%>";
    </script>

    <script src="../../../Lib_{{VER}}/Data/ChartTestData03.js"></script>
    <script src="TestTotalRatingsChart_DATA.js"></script>
    <script src="TestTotalRatingsChart.js"></script>
    <script>
        var ServerSide_ChartId = "<%=ServerSide_ChartId%>";
        var ServerSide_IsDrillDownMode = "<%=ServerSide_IsDrillDownMode%>";
        var ServerSide_IsBatchMode = "<%=ServerSide_IsBatchMode%>";
        var ServerSide_IsDrillDownMode = "<%=ServerSide_IsDrillDownMode%>";
        var ServerSide_PageSize = "<%=ServerSide_PageSize%>";
        var ServerSide_LargeObjectFilter = "<%=ServerSide_LargeObjectFilter%>";
        var ServerSide_LargeObjectCriteria = "<%=ServerSide_LargeObjectCriteria%>";
        var ServerSide_LargeObjectSetting = "<%=ServerSide_LargeObjectSetting%>";
        var ServerSide_ChartData = "<%=ServerSide_ChartData%>";
        var ServerSide_ErrorMessage = "<%=ServerSide_ErrorMessage%>";
  </script>
    <style>
        body {
            font-family: Arial !important;
        }
        .chartPageTable {
            width: 1250px;
            margin: auto;
            text-align: center;
        }
        .chartContainer {
            min-height: 575px;
            width: 1250px;
            margin: auto;
            text-align: center;
            padding-right: 24px;
            padding-left: 24px;
            padding-top: 6px;
            padding-bottom: 12px;
            border-radius: 6px;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border: 1px solid #C0C0C0;
        }
        .chartContainer .k-chart {
            text-align: center;
            margin: auto;
        }
        .chartGrid,
        .chartGrid th,
        .chartGrid td {
            border: 1px solid #2C2C2C;
            border-collapse: collapse;
            font-size: 9pt;
            font-family: Arial;
            font-weight: normal;
            text-align: center;
        }
        .chartGridHead,
        .chartGridHead tr {
        }
        .chartGridHead th {
        }
        .chartGridBody,
        .chartGridBody tr {
        }
        .chartGridBody th {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="viewChart">

    <!-- LOADING -->
    <div id="divContainerLoading" class="containerLoading" style="display: none;"></div>

    <!-- CONTENT -->
    <table runat="server" ID="tableHeaderContainer">
        <tr>
            <td>
                <table class="chartPageTable">
                    <tr>
                        <td align="center" style="width: 33%" valign="top" ID="tdParameters" runat="server">
                            <table cellpadding="0" cellspacing="0" border="0" class="printNone" ID="tableParameters" runat="server" style="margin-left: -100px;">
                                <tr>
                                    <td style="width: 125px; height: 16px; text-align: left !important;">
                                        <asp:Label ID="lblSort" runat="server" Text="Sort:" Font-Bold="true" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                    <td style="text-align: left; height: 16px;">
                                        <select id="cboSort">
                                            <option Value="LowHighFileNo">File No.</option>
                                            <option Value="LowHighClientLocNo">Client Loc. No.</option>
                                            <option Value="LowHighCity">City</option>
                                            <option Value="LowHighStProv">St/Prov.</option>
                                            <option Value="LowHighCountry">Country</option>
                                            <option Value="HighLowTIV">Highest to Lowest TIV</option>
                                            <option Value="LowHighTIV">Lowest to Highest TIV</option>
                                            <option Value="HighLowScore" selected="selected">Highest to Lowest Score</option>
                                            <option Value="LowHighScore">Lowest to Highest Score</option>
                                        </select>
                                    </td>
                                </tr>
                            </table>
                            <%--<table cellpadding="0" cellspacing="0" border="0" ID="tableLocation" runat="server" style="margin-left: -50px; margin-top: -10px">
                                <tr>
                                    <td style="width: 130px; height: 16px; text-align: left;">
                                        <asp:Label ID="lblLocation" runat="server" Text="Location:" Font-Bold="true" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                    <td style="text-align: left; height: 16px;">
                                        <asp:Label ID="lblLocationValue" runat="server" Text="" Font-Names="Arial" Font-Size="8pt"></asp:Label>
                                    </td>
                                </tr>
                            </table>--%>
                        </td>
                        <td align="center" style="width: 33%" valign="top">
                            <table class="printNone">
                                <tr>
                                    <td align="center" valign="top">
                                        <div style="margin-left: 50px;">
                                            <button ID="btnPDF" data-bind="click: downloadPDF">Save/Print</button>
                                            <input id="cmdClose" type="button" value="Close" onclick="window.close();" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="right" style="width: 33%" valign="top" ID="tdRatingsTable" runat="server">
                            <!-- RATING KEY TABLE AND LEGEND -->
                            <table style="font-size: 7pt; font-weight: bold; margin-top: -60px;" ID="tableRatingsTable" runat="server">
                                <tr>
                                    <td align="left" valign="top">
                                        <asp:Label ID="lblRatingKey" runat="server" Style="margin-left: 5px; font-weight: bold; font-size: 8pt; padding-left: 35px;" Text="Rating Key"></asp:Label>
                                        <table style="border: 1px solid #C6C3C6; margin-top: 3px; margin-right: -30px;">
                                            <tr>
                                                <td style="border: none;">
                                                    <table id="RatingKey" class="chartGrid" cellpadding="2" cellspacing="0" data-bind="foreach: { data: chartRatingsData, includeDestroyed: false }">
                                                        <tr>
                                                            <td style="width: 120px;" data-bind="style: { backgroundColor: $data.ratingColor }"><span data-bind="    text: $data.ratingTitle"></span></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td style="border: none;">
                                                    <table>
                                                        <tr>
                                                            <td style="width: 100px; text-align: right;">
                                                                <label>GRC Avg:</label>
                                                            </td>
                                                            <td id="GRCAverage" style="text-align: center; border: 1px solid #C6C3C6;">
                                                                <label id="txtGRCAverage" data-bind="text: averageGRC"></label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 100px; text-align: right;">
                                                                <label>Client Avg:</label>
                                                            </td>
                                                            <td id="ClientAverage" style="text-align: center; border: 1px solid #C6C3C6;">
                                                                <label id="txtClientAverage" data-bind="text: averageClient"></label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 100px; text-align: right;">
                                                                <label>Filtered Avg:</label>
                                                            </td>
                                                            <td id="DivisionAverage" style="text-align: center; border: 1px solid #C6C3C6;">
                                                                <label id="txtDivisionAverage" data-bind="text: averageDivision"></label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                            <!-- END RATING LEGEND AND KEY -->
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

    <table>
        <tr runat="server" ID="trMessageContainer">
            <td align="center" style="height: 0px">
                <%--<div id="txtMessage" style="text-align: center;"><label data-bind="text: txtMessage"></label>&nbsp;</div>--%>
            </td>
        </tr>
        <tr runat="server" ID="trTipContainer" class="printNone">
            <td align="center">
                <div style="float: left;">
                    <label id="lblTip" style="font-weight: normal; font-family: Arial; font-size: 8pt; color: red;"></label>
                </div>
                <div style="float: right;" id="divPagingContainer">
                    <label data-bind="text: txtMessageCurrentPage"></label>&nbsp;&nbsp;
                    <button id="btnPagePrevious" class="k-button buttonShape k-icon k-i-arrow-w" data-bind="click: pagePreviousGroup">&nbsp;</button>
                    <span id="spnPageButtons" data-bind="foreach: { data: chartPageNumbers, includeDestroyed: false }">
                        <button class="k-button buttonShape" style="height: 16px; width: 24px;" data-bind="text: $data, click: function (data) { $parent.pageLoadByNumber($data, false) }"></button>
                    </span>
                    <button id="btnPageNext" class="k-button buttonShape k-icon k-i-arrow-e" data-bind="click: pageNextGroup">&nbsp;</button>
                </div>
            </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <div class="chartContainer" style="min-height: 250px; padding-right: 24px; padding-left: 24px; padding-top: 6px; padding-bottom: 12px; border-radius: 6px; -moz-border-radius: 6px; -webkit-border-radius: 6px; border: 1px solid #C0C0C0;">
                    <div style="width: 40%; float: left; text-align: center; font-weight: bold; font-size: 8pt" data-bind="html: chartCategoryTitle">TIV (mils) - City - St/Prov - Country -<br />ClientLocID - Division - Facility</div>
                    <div style="clear: both; height: 6px;">&nbsp;</div>
                    <div id="chartRating"></div>
                </div>
            </td>
        </tr>
        <tr runat="server" ID="trFooterTableContainer" class="printNone">
        </tr>
    </table>
    <div style="color: #FFFFFF; height: 0px;"><section id="TotalCount"></section></div>
    
    <!-- PLEASE WAIT WINDOW FOR PRINTING MULTIPLE PAGES -->
<%--    <div class="printNone">
    <div id="windowPleaseWait" class="windowContent printNone">
        <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="GRC Client Connect - Please Wait" />
        <div id="windowPleaseWaitProcessed">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
            <br />&nbsp;<br />&nbsp;<br />
            <div>
                <label>Thank you for your patience while the Facility Score chart PDF is being built.</label>
                <br />&nbsp;<br />
                <label>As this tool provides a statistical view of your locations, this may take a few minutes.</label>
            </div>
            <br />&nbsp;<br />
            <div style="text-align: center;">
                <button class="k-button k-button-padding" data-bind="click: onCancelMultiPring">Cancel</button>
            </div>
        </div>
        <div id="windowPleaseWaitCancelled" style="display: none;">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being cancelled</label></div>
            <br />&nbsp;<br />
            <div style="text-align: center;">
                <label>Please wait.</label>
                <br />&nbsp;<br />&nbsp;<br />
                <label>&nbsp;</label>
            </div>
        </div>
    </div>
    </div>--%>
    

    <!-- PLEASE WAIT WINDOW FOR CHART LOADING -->
<%--    <div class="printNone">
    <div id="windowPleaseWaitLoading" class="windowContent printNone">
        <img src="../../../Home_{{VER}}/Images/loading/image_loading07.gif" style="width: 28px; height: 28px;" align="left" class="windowImageSmallPadding" alt="GRC Client Connect - Please Wait" />
        <div id="windowPleaseWaitLoadingProcessed">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being processed</label></div>
            <br />&nbsp;<br />&nbsp;<br />
            <div>
                <label>Thank you for your patience while the Facility Rating Score chart is being built.</label>
                <br />&nbsp;<br />
                <label>As this tool provides a statistical view of your entire program, this may take a few minutes.</label>
            </div>
            <br />&nbsp;<br />
            <div style="text-align: center;">
                <button class="k-button k-button-padding" data-bind="click: onCancelLoad">Cancel</button>
            </div>
        </div>
        <div id="windowPleaseWaitLoadingCancelled" style="display: none;">
            <div style="padding-top: 6px;"><label data-bind="" >Your request is being cancelled</label></div>
            <br />&nbsp;<br />
            <div style="text-align: center;">
                <label>Please wait.</label>
                <br />&nbsp;<br />&nbsp;<br />
                <label>&nbsp;</label>
            </div>
        </div>
    </div>
    </div>--%>

    </div>
    </form>
</body>
</html>
