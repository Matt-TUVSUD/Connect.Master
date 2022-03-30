<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WhatIfTest.aspx.vb" Inherits="GRC.Connect.Web.WhatIfTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>What If Analysis Tool</title>
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
    <script src="https://kendo.cdn.telerik.com/2019.1.220/js/kendo.all.min.js"></script>
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
    <script src="../../Lib_{{VER}}/Picklist/Picklist_v2015.04.09.js"></script>
    <script src="WhatIfData.js"></script>
    <script src="WhatIf.js"></script>


    <style>

         body {
            font-family: Arial !important;
            width:100%;
        }

        .masterHeaderElasticBlue100 {
	width: 100%;
	min-width: 986px;
	background-color: transparent;
	background-image: linear-gradient(rgb(231, 235, 247) 0%, rgb(255, 255, 255) 50%);
}


body.bodyElastic {
	width: 100%;
}

.headerContainerElastic {
	font-family: Verdana;
	border: 0px;
	margin: 0px;
	padding: 0px;
	width: 99%;
	min-width: 986px;
}
.headerLeft {
	float: left;
	padding-left: 10px;
}
.headerCrumbTrail {
	font-size: 9pt;
	margin-bottom: 5px;
	padding-bottom: 0px;
}
a {
	color: #0046ad;
	text-decoration: none;
	cursor: pointer;
}

.headerRight {
	float: right;
	text-align: right;
	padding-right: 2px;
}
.headerPageTitle {
	font-size: 20pt;
	color: black;
	font-weight: bold;
	padding-bottom: 0px;
	padding-top: 2px;
}
.headerCompanyNameLargeBlue {
	font-family: Calibri, Verdana, Candara, Segoe, "Segoe UI", Optima, Arial, sans-serif;
	font-size: 24pt;
	font-weight: bold;
	color: #1961ad;
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

.k-grid-toolbar {
    background:#eee;
    padding:5px;
}

.searchImg {
    background:#C6D1DF;
    background-image:url(../../Home_{{ver}}/Images/icons/grids/icon_ig_search.png);
    background-repeat:no-repeat;
    background-position-x:3px;
    background-position-y:3px;
    width:24px;
    height:28px;
    display:block;
}
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="headerContainerElastic">
                <div class="headerLeft">
                    <div class="headerCompanyNameLargeBlue"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblCompany">ABC Company (Demo)</span></div>
                </div>
                <div class="headerRight">
                    <div class="headerPageTitle"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblPageTitle">What If Analysis Tool</span></div>
                </div>
            </div>
            <br style="clear: both;"/>
            <div class="masterTopBannerElastic100">
                <div class="topBanner_Container_Other_Elastic_Blue">
                    <div style="width: 32px; text-align: right; padding-right: 35px; float: right;">
                        <a title="Knowledge Base" class="i-information" onclick="openRequestedKnowledgeBasePopup(null, null)" href="#"></a>
                    </div>
                    <div class="headerWelcomeWhite">
                        <label>Welcome</label>
                        <span id="ClientConnectSiteBody_ClientConnectFormBody_lblLoginName">Matthew Feinstein (GRC)</span> | <a onclick="setCurrentTab(utilConstants.pageId_LogOut, utilConstants.pageId_Gauge)" href="#"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblLogoutHeader">Logout</span></a></div>
                    <br/>
                    <div class="headerTodaysDateLightBlue"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblTodaysDate">Friday, May 10, 2019</span></div>
                </div>
                <br style="clear: both;" />
            </div>
            <!-- END HEADER -->
            <!-- CHART SECTION -->
            <div id="chartArea" class="ui-helper-clearfix" style="margin: 0 auto; width:1775px;">
                <div id="ratingChartHldr" style="float: left; width:595px;">
                    <h2 style="text-decoration: underline; text-align:center; color:#0046ad;"><a href='#' data-bind="click: ratingScoreClick">Rating Score</a></h2>
                    <div id="RatingScoreChart" ></div>
                </div>
                <div id="achievableRatingChartHldr" style="float: left; width:590px;">
                    <h2 style="text-decoration: underline; text-align:center; color:#0046ad;"><a href='#'>Achievable Rating %</a></h2>
                    <div id="AchievableRatingChart"></div>
                </div>
                <div id="riskImprovmentChartHldr" style="float:left; width:590px;">
                    <h2 style="text-decoration: underline; text-align:center; color:#0046ad;"><a href='#'>Risk Improvement</a></h2>
                    <div id="RiskImporvmentChart"></div>
                </div>
            </div>
            <!-- END CHART SECTION -->
            <!-- INFORMATION SECTION -->
            <div id="infoSection" class="ui-helper-clearfix" style="margin: 10px auto; width:1775px;">
                <div id="infoLeft" class="ui-helper-clearfix" style="float:left; width:500px;">
                    <div style="float:left; width:100%; margin-bottom:5px;">
                        <label style="display:block; width:80%; float:left; font-size:14px;">
                            <strong>Estimated Budget:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>$100,000</span>
                        </label>
                    </div>
                    <div style="float:left; width:100%; margin-bottom:5px;">
                        <label style="display:block; width:80%; float:left; font-size:14px;">
                            <strong>Est. Cost To Complete:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>$30,000</span>
                        </label>
                    </div>
                    <div style="float:left; width:100%; margin-bottom:5px;">
                        <label style="display:block; float:left; width:80%; font-size:14px;">
                            <strong>Remaining Budget:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>$70,000</span>
                        </label>
                    </div>
                    <div style="float:left; width:100%;" >
                        <label style="display:block; float:left; width:80%; font-size:14px;">
                            <strong>Sort By:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>Score Change</span>
                        </label>
                    </div>
                </div>
                <div id="midSection" style="float:left; width:750px;">&nbsp;</div>
                <div id="infoRight" style="float:left; width:500px;">
                    <div style="float:left; width:100%; margin-bottom:5px;">
                        <label style="display:block; width:80%; float:left; font-size:14px;">
                            <strong>Total Recommendations Selected Count:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>15</span>
                        </label>
                    </div>
                    <div style="float:left; width:100%; margin-bottom:5px;">
                        <label style="display:block; width:80%; float:left; font-size:14px;">
                            <strong>Total Selected Score Change:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>27</span>
                        </label>
                    </div>
                    <div style="float:left; width:100%; margin-bottom:5px;">
                        <label style="display:block; float:left; width:80%; font-size:14px;">
                            <strong>Human Element Selected Recommendations Count:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>5</span>
                        </label>
                    </div>
                    <div style="float:left; width:100%;" >
                        <label style="display:block; float:left; width:80%; font-size:14px;">
                            <strong>Human Element Rec Score Change:</strong>
                        </label>
                        <label style="display:block; width:20%;float:left; font-size:14px; text-align:right;">
                            <span>11</span>
                        </label>
                    </div>
                </div>
            </div>
            <!-- END INFORMATION SECTION -->
            <!-- GRID SECTION -->
            <div id="gridHldr" style="margin: 0 auto; width:1775px;">
                <div id="gridInfoHldr" style="margin-top:15px;">
                    <div>
                        <label>Sorted:</label>
                    </div>
                    <div>
                        <label>Filtered:</label>
                    </div>
                    <div>
                        <label>Pinned:</label>
                    </div>
                </div>
                <div id="gridToolbar" class="toolBar" style="display:none; ">
                    <label style="float:left; display:block; color:#000; line-height:25px;">35 Records</label>
                    <button style="float:right; margin-left:5px; background:#0046ad; color:#fff;"><i class="fas fa-file-export"></i> Extract Data</button>
                    <button style="float:right; margin-left:5px; background:#0046ad; color:#fff;"><i class="fas fa-download"></i> Download Report</button>
                    <button style="float:right; margin-left:5px; background:#0046ad; color:#fff;"><i class="fas fa-undo"></i> Reset Grid</button>
                    <button style="float:right; margin-left:5px; background:#0046ad; color:#fff;"><i class="fas fa-eye-slash"></i>&nbsp;&nbsp;Clear Sorts/Filters</button>
                    <button style="float:right; margin-left:5px; background:#0046ad; color:#fff;"><i class="fas fa-ban"></i>&nbsp;&nbsp;Clear Selections</button>
                    <button style="float:right; background:#0046ad; color:#fff;"><i class="fas fa-filter"></i> Filter By Selections</button>
                </div>
                <div id="gridDiv"></div>
            </div>
            <!-- END GRID SECTION -->

            <!-- POPUP WINDOWS -->
            <div id="ratingScoreChartWindow" style="display:none" class="ui-helper-clearfix">
                <div style="margin-bottom:5px; width:100%;" class="ui-helper-clearfix">
                    <p>
                        <span style="display:block; float:left; font-size:12px; margin-right:5px;">
                            <strong>Rating Score Chart:</strong>
                        </span>
                        <span style="display:block; float:left; font-size:12px;">
                            Reflects the Average based on the Total Rating Score
                        </span>
                    </p>
                </div>
                <div style="margin-bottom: 5px; width: 100%;" class="ui-helper-clearfix">
                    <span style="display: block; float: left; font-size: 12px; margin-right: 5px;">
                        <strong>Current:</strong>
                    </span>
                    <span style="display: block; float: left; font-size: 12px;">
                        Reflects Latest Inspection. This does not reflect Rptd. Completed Recs and What If Recs Selected.
                    </span>
                </div>
                <div style="margin-bottom:5px; width:100%;" class="ui-helper-clearfix">
                    <p>
                        <span style="display: block; float: left; font-size: 12px; margin-right: 5px;">
                            <strong>What If:</strong>
                        </span>
                        <span style="display: block; float: left; font-size: 12px;">
                            Reflects the What If Scenario. This includes Rptd. Completed Recs and What If Recs Selected as Completed in this scenario.
                        </span>
                    </p>
                </div>
                <div style="margin-bottom:5px; width:100%;" class="ui-helper-clearfix">
                    <p>
                        <span style="display: block; float: left; font-size: 12px; margin-right: 5px;">
                            <strong>Client:</strong>
                        </span>
                        <span style="display: block; float: left; font-size: 12px;">
                            This is the average for all locations with Rating Data reflected in GRC Connect.
                        </span>
                    </p>
                </div>
                <div style="width:100%;" class="ui-helper-clearfix">
                    <p>
                        <span style="display: block; float: left; font-size: 12px; margin-right: 5px;">
                            <strong>Filtered:</strong>
                        </span>
                        <span style="display: block; float: left; font-size: 12px;">
                            This is the average for all locations with at least one record included in your filter below.
                        </span>
                    </p>
                </div>
            </div>
            <div id="achievableRatingChartWindow" style="display:none"></div>
            <div id="riskImprovmentChartWindow" style="display:none"></div>
            <!-- END POPUP WINDOWS -->
        </div>
    </form>
</body>
</html>
