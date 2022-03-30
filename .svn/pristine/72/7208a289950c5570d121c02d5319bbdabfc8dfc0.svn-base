<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BubbleChartTest.aspx.vb" Inherits="GRC.Connect.Web.BubbleChartTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bubble Chart Proof of Concept</title>
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/print.css" media="print" />

    <script src="https://kit.fontawesome.com/94c91a27ac.js"></script>
    <script src="../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>

    <%--<script src="../../../Lib_{{VER}}/KendoUI.v2015.3.1111/kendo.all.min.js"></script>--%>
    <%--<script src="https://kendo.cdn.telerik.com/2019.1.220/js/kendo.all.min.js"></script>--%>
    <script src="../../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>

    <script src="../../Lib_{{VER}}/pages/global.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/constants.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    <script src="BubbleChartTest.js"></script>
    <script src="BubbleChartTestData.js"></script>

<style>

body {
	width: 100%;
    background:#eee;
}

.bubbleChartPageBody{
    width:100%;
    display:flex;
    flex-flow:row wrap;
    justify-content: center;
}

header{
    background:#fff;
    width:100%;
    display:flex;
    flex-flow:row wrap;
    justify-content: space-between;
}

.headerCompanyNameLargeBlue {
	font-family: Calibri, Verdana, Candara, Segoe, "Segoe UI", Optima, Arial, sans-serif;
	font-size: 24pt;
	font-weight: 700;
	color: #1961ad;
    width:49%;
    padding-left:5px;
    text-align:left;
}

.headerPageTitle {
	font-size: 20pt;
	color: #000;
	font-weight: 700;
	padding-bottom: 0px;
	padding-top: 2px;
    padding-right:5px;
    width:49%;
    text-align:right;
}

section{
    background:#eee;
    width:100%;
    display:flex;
    flex-flow:row wrap;
    justify-content: space-between;
    margin-top:15px;
}

.labelDDHldr{
    padding-left:10px;
    text-align:center;
    width:150px;
}

.chartHldr{
    margin:0 auto;
    background:#fff;
    width:65%;
}

.imgMakerHldr{
    width:150px;
}

.masterHeaderElasticBlue100 {
	width: 100%;
	background-color: transparent;
	background-image: linear-gradient(rgb(231, 235, 247) 0%, rgb(255, 255, 255) 50%);
}




.masterTopBannerElastic100 {
	position: relative;
	z-index: 1000;
	width: 100%;
	min-width: 986px;
	height: 36px;
	clear: both;
}

.topBanner_Container_Other_Elastic_Blue {
	height: 38px;
	width: 100%;
	min-width: 986px;
	text-align: left;
	padding-top: 2px;
	font-size: 12px;
	color: #ffffff;
	background-color: #0046ad;
	-webkit-box-shadow: 0px 4px 6px -2px rgba(0, 0, 0, 1);
	-moz-box-shadow: 0px 4px 6px -2px rgba(0, 0, 0, 1);
	box-shadow: 0px 4px 6px -2px rgba(0,0,0,1);
}

.bubbleSizeDef{
    font-size: 11px;
    padding: 5px;
    position: absolute;
    right: 375px;
    top: 125px;
    text-transform: uppercase;
    width: 145px;
    background:#fff;
    display:block;
    text-align:left;
}

/*.k-chart-tooltip{
   margin-top: -35px !important;
   margin-left: -30px !important;
}*/
</style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="bubbleChartPageBody ui-helper-clearfix">
            <!-- HEADER -->
            <header>
                <!-- HEADER CLIENT NAME --> 
                <div class="headerCompanyNameLargeBlue">
                    <span id="Span1">Sanofi</span>
                </div>
                <div class="headerPageTitle">
                    <span id="Span2">Bubble Chart Proof of Concept</span>
                </div>
                <div style="width:100%;">
                    <div class="topBanner_Container_Other_Elastic_Blue">
                        <div style="width: 32px; text-align: right; padding-right: 35px; float: right;">
                            <a title="Knowledge Base" class="i-information" onclick="openRequestedKnowledgeBasePopup(null, null)" href="#"></a>
                        </div>
                        <div class="headerWelcomeWhite">
                            <label>Welcome</label>
                            <span id="ClientConnectSiteBody_ClientConnectFormBody_lblLoginName">Matthew Feinstein (GRC)</span> | 
                            <a onclick="setCurrentTab(utilConstants.pageId_LogOut, utilConstants.pageId_Gauge)" href="#">
                                <span id="ClientConnectSiteBody_ClientConnectFormBody_lblLogoutHeader">Logout</span>
                            </a>
                        </div>
                        <div class="headerTodaysDateLightBlue">
                            <span id="ClientConnectSiteBody_ClientConnectFormBody_lblTodaysDate">Friday, May 10, 2019</span>
                        </div>
                    </div>
                </div>
            </header>
            <section>
                <!-- MAIN BODY CONTENT -->
                <aside>
                    <div class="labelDDHldr">
                        <label style="display: block; margin-bottom: 5px;">Bubble Label:</label>
                        <input id="labelDD" />
                        <p>Note: bubble size represents Maximum Forseable Loss(MFL)</p>
                    </div>
                </aside>
                <div id="htmlCanvasHldr" class="chartHldr">
                    <div id="bubbleChart"></div>
                    <div id="chartTooltip"></div>
                    <%--<label class="bubbleSizeDef">Circle size represents Maximum Forseable Loss (MFL)</label>--%>
                </div>
                <aside>
                    <div class="imgMakerHldr">
                        <label style="display: block; margin-bottom: 5px;">Chart To Image:</label>
                        <button id="makeChartImgBtn" class="export-img k-button" style="padding:5px;" data-bind="click: view.makeChartImage">Make Image</button>
                        <br /><br />
                        <label style="display: block; margin-bottom: 5px;">Chart To PDF:</label>
                        <button id="makeChartPDFBtn" style="padding:5px;" class="export-pdf k-button" data-bind="click: view.makeChartPDF">Make PDF</button>
                    </div>
                    <div id="preview"></div>
                </aside>
            </section>
            <footer>
                <!-- FOOTER --> 
            </footer>
            
            <!-- END HEADER -->

        </div>
    </form>
</body>
</html>
