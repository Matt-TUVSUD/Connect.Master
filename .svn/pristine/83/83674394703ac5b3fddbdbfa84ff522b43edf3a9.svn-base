<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestChartDashBoard.aspx.vb" Inherits="GRC.Connect.Web.TestChartDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../../css/pages/windows.css" />
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
    <script src="../../../Lib_{{VER}}/Picklist/Picklist_v2015.04.09.js"></script>
    <script src="TestChartDashboardData.js"></script>
    <script src="TestChartDashBoard.js"></script>

    <style>
        body {
            font-family: Arial !important;
            width:100%;
        }

        .k-icon .k-i-loading .k-hidden {
            display:none;
        }

        .k-chart-tooltip {
            color:#fff;
        }

        .pickListWindow { display: none; }
    .pickListHeader { text-align: center; padding-bottom: 4px; }
    .pickListFooter { padding-top: 8px; text-align: center; }
    .pickListTable { }
    .pickListContent { height: 315px; overflow-y: scroll; border: 1px solid #CCCCCC; padding: 0px; margin: 0px; }
    .pickListLoading { position: fixed; top: inherit; left: inherit; opacity: 0.8; background: #FFFFFF; }
    .pickListLoadingImage { border: none; margin-left: 125px;  margin-top: 110px; height: 32px;  width: 32px; }
    .pickListButton { min-width: 75px; }
    .pickListItem { padding-top: 2px; padding-bottom: 2px; padding-left: 4px; }
    .pickListItemLabel { }
    .pickListItemLabel:hover { text-decoration: underline; }

        #ChartDasboardHldr .dark{
            margin: 0 auto; 
            background: #303030; 
            height:100%;
            display: -ms-flexbox;
            display: -webkit-box;
            display: -moz-box;
            display: -ms-box;
            display: box;
  
          -ms-flex-direction: row;
          -webkit-box-orient: horizontal;
           -moz-box-orient: horizontal;
            -ms-box-orient: horizontal;
            box-orient: horizontal;
        }

        #DashobardSideBar .dark{
            background: #212121;
            width: 160px;
            -ms-flex: 0 160px;
            -webkit-box-flex:  0;
            -moz-box-flex:  0;
            -ms-box-flex:  0;
            box-flex:  0;  
        }

        #holderOfAllCharts .dark{
            background: #424242;
            margin:25px 0px;
            -ms-flex: 1;
            -webkit-box-flex: 1;
            -moz-box-flex: 1;
            -ms-box-flex: 1;
            box-flex: 1;  
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

        #filterLblHldr {
            margin:10px; 
            width:100%; 
            background:#fff;
        }

        #ChartDasboardHldr{
            margin: 0 auto; 
            background: #fff; 
            width:99%;
            padding:0 5px;
        }

        #DashobardSideBar{
            background: #fff;
            width: 185px;
            float:left;
        }

        .filterSet {
            background:#dedede;
            border:1px solid #000;
            width:165px;
            float:left;
        }

        #holderOfAllCharts{
            background: #fff;
            width:1690px;
            float:left;
        }

        .k-link.k-header {
            background: #0046ad;
            color:#fff;
        }

        .k-state-selected, .k-list > .k-state-selected, .k-list > .k-state-selected:hover {
            color:#fff !important;
            background:#277ad9 !important;
        }

        .k-icon .k-i-arrow-60-up .k-panelbar-collapse {
            color:#fff !important;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- HEADER -->
            <div class="headerContainerElastic">
                <div class="headerLeft">
                    <div class="headerCompanyNameLargeBlue"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblCompany">ABC Company (Demo)</span></div>
                </div>
                <div class="headerRight">
                    <div class="headerPageTitle"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblPageTitle">Dashboard Proof of Concept</span></div>
                </div>
            </div>
            <br style="clear: both;">
            <div class="masterTopBannerElastic100">
                <div class="topBanner_Container_Other_Elastic_Blue">
                    <div style="width: 32px; text-align: right; padding-right: 35px; float: right;">
                        <a title="Knowledge Base" class="i-information" onclick="openRequestedKnowledgeBasePopup(null, null)" href="#"></a>
                    </div>    
                    <div class="headerWelcomeWhite"><label>Welcome</label> <span id="ClientConnectSiteBody_ClientConnectFormBody_lblLoginName">Matthew Feinstein (GRC)</span> | <a onclick="setCurrentTab(utilConstants.pageId_LogOut, utilConstants.pageId_Gauge)" href="#"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblLogoutHeader">Logout</span></a></div><br>
                    <div class="headerTodaysDateLightBlue"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblTodaysDate">Friday, May 10, 2019</span></div>
                </div>
                <br style="clear: both;">
            </div>
            <!-- END HEADER -->
            <div id="filterLblHldr" class="ui-helper-clearfix" style="">
                <div style="float:left; display:block;">
                    <label>Applied Filters:&nbsp;</label>
                </div>
                <div style="float:left;">
                    <label data-bind="text: appliedFiltersTxt"></label>
                </div>
            </div>
            <div id="ChartDasboardHldr" class="ui-helper-clearfix" style="">
                <div id="DashobardSideBar" style="">
                    <!-- ACORDIAN SECTION -->
                    <div id="accordianHldr">
                        <ul id="panelbar">
                            <li>
                                <span>Division</span>
                                <div data-bind="foreach: DivisionData">
                                    <div>
                                        <input type="checkbox" data-bind="attr: { id: $data.id, name: $data.name }" onclick="    gDivisionItemCheck(id)" />
                                        <span class="pickListItemLabel" data-bind="text: $data.name"></span>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <span>Client Location ID</span>
                                <div data-bind="foreach: ClientLocIDData">
                                    <div>
                                        <input type="checkbox" data-bind="attr: { id: $data.id }" onclick="    gClientLocIDItemCheck(id)" />
                                        <span class="pickListItemLabel" data-bind="text: $data.name"></span>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <span>Intended Action</span>
                                <div data-bind="foreach: IntendedActionData">
                                    <div>
                                        <input type="checkbox" data-bind="attr: { id: $data.id }" />
                                        <span class="pickListItemLabel" data-bind="text: $data.name"></span>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!-- END ACORDIAN SECTION -->
                    <%--<div class="filterSet">
                        <div id="rowOne" class="ui-helper-clearfix" style="width: 100%; margin: 10px 0; padding-left: 5px;">
                            <div style="float: left; text-align: left; width: 110px; color: #000;">
                                <label>Division</label>
                            </div>
                            <div style="float: left; text-align: left; width: 50px;">
                                <button id="divisionPicklist" data-bind="click: onDivPickList"><span class="k-sprite k-success">&nbsp;</span></button>
                            </div>
                        </div>
                        <div id="rowTwo" class="ui-helper-clearfix" style="width: 100%; margin-bottom: 10px; padding-left: 5px;">
                            <div style="float: left; text-align: left; width: 110px; color: #000;">
                                <label>Client Loc. ID</label>
                            </div>
                            <div style="float: left; text-align: left; width: 50px">
                                <button id="ClientLocPickList" data-bind="click: onClientLocPickList"><span class="k-sprite k-success">&nbsp;</span></button>
                            </div>
                        </div>
                        <div id="rowThree" class="ui-helper-clearfix" style="width: 100%; margin-bottom: 10px; padding-left: 5px;">
                            <div style="float: left; text-align: left; width: 110px; color: #000;">
                                <label>Intended Action</label>
                            </div>
                            <div style="float: left; text-align: left; width: 50px;">
                                <button id="IntendedActionPickList" data-bind="click: onIntendedActionPickList"><span class="k-sprite k-success">&nbsp;</span></button>
                            </div>
                        </div>
                    </div>
                    <div id="rowFour" class="ui-helper-clearfix" style="width: 100%; margin-bottom:10px; padding-left:5px;">
                        <div style="float: left; text-align: left; width: 110px; color:#fff;">
                            <label>Facility</label>
                        </div>
                        <div style="float: left; text-align: left; width:50px">
                            <button id="FacilityPickList" data-bind="click: onFacilityPickList"><span class="k-sprite k-success">&nbsp;</span></button>
                        </div>
                    </div>
                    <div id="rowFive" class="ui-helper-clearfix" style="width: 100%; margin-bottom:10px; padding-left:5px;">
                        <div style="float: left; text-align: left; width: 110px; color:#fff;">
                            <label>Secondary Rec. Type</label>
                        </div>
                        <div style="float: left; text-align: left; width:50px">
                            <button id="SecondaryRecTypePickList" data-bind="click: onSecondaryRecTypePickList"><span class="k-sprite k-success">&nbsp;</span></button>
                        </div>
                    </div>--%>
                </div>
                <div id="holderOfAllCharts" class="ui-helper-clearfix">
                    <div id="chartContainer" style="float: left;">
                        <div id="BarChartTest"></div>
                    </div>
                    <div id="pieChartContainer" style="float: left">
                        <div id="pieChartTest"></div>
                    </div>
                    <div id="lineChartContainer" style="float: left;">
                        <div id="lineChartTest"></div>
                    </div>
                    <div id="columnChartContainer" style="float: left;">
                        <div id="columnChartTest"></div>
                    </div>
                </div>


                <!-- DIVISION PICKLIST WINDOW -->
                <!-- <div id="divisionPicklistWindow" style="display: none;">
                    <div class="pickListHeader">
                        <label>Check the items to show.</label>
                    </div>
                    <div class="pickListContent">
                        <div id="windowPickList_Loading" class="pickListLoading">
                            MUST USE Name_Loading NAMING FORMAT FOR ID 
                        </div>
                        <div id="windowDivisionPickList_Table" class="pickListTable" data-bind="foreach: DivisionData">
                            <div class="pickListItem ui-helper-clearfix">
                                <label>
                                    <input type="checkbox" data-bind="attr: { id: id }" onclick="    gDivisionItemCheck(id)" />
                                    <span class="pickListItemLabel" data-bind="text: name"></span>
                                </label>
                            </div>
                        </div>
                        MUST USE Name_Table NAMING FORMAT FOR ID
                    </div>
                    <div class="pickListFooter">
                        <button class="k-button pickListButton" onclick="gPickListCheckAll('Division')">All</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                        <div style="height: 4px;">&nbsp;</div>
                        <button class="k-button pickListButton" onclick="gPickListApplyFilter('Division')">Apply</button>&nbsp;
                        <button class="k-button pickListButton" onclick="gPicklistCancel('Division')">Cancel</button>
                    </div>
                </div>-->

                <!-- CLIENT LOCATION ID PICKLIST WINDOW -->
                <!--<div id="clientLocIdPicklistWindow" style="display: none;">
                    <div class="pickListHeader">
                        <label>Check the items to show.</label>
                    </div>
                    <div class="pickListContent">
                        <div id="windowClientLocIDPickList_Table" class="pickListTable" data-bind="foreach: ClientLocIDData">
                            <div class="pickListItem ui-helper-clearfix">
                                <label>
                                    <input type="checkbox" data-bind="attr: { id: id }" onclick="    gClientLocIDItemCheck(id)" />
                                    <span class="pickListItemLabel" data-bind="text: name"></span>
                                </label>
                            </div>
                        </div>
                        MUST USE Name_Table NAMING FORMAT FOR ID
                    </div>
                    <div class="pickListFooter">
                        <button class="k-button pickListButton" onclick="gPickListCheckAll('ClientLocation')">All</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                        <div style="height: 4px;">&nbsp;</div>
                        <button class="k-button pickListButton" onclick="gPickListApplyFilter('ClientLocation')">Apply</button>&nbsp;
                        <button class="k-button pickListButton" onclick="gPicklistCancel('ClientLocation')">Cancel</button>
                    </div>
                </div>-->

                <!-- INTENDED ACTION PICKLIST WINDOW -->
                <!--<div id="intendedActionPicklistWindow" style="display: none;">
                    <div class="pickListHeader">
                        <label>Check the items to show.</label>
                    </div>
                    <div class="pickListContent">
                        <div id="windowIntendedActionPickList_Table" class="pickListTable" data-bind="foreach: IntendedActionData">
                            <div class="pickListItem ui-helper-clearfix">
                                <label>
                                    <input type="checkbox" data-bind="attr: { id: id }" />
                                    <span class="pickListItemLabel" data-bind="text: name"></span>
                                </label>
                            </div>
                        </div>
                        <!-- MUST USE Name_Table NAMING FORMAT FOR ID
                    </div>
                    <div class="pickListFooter">
                        <button class="k-button pickListButton" onclick="gPickListCheckAll('IntendedAction')">All</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                        <div style="height: 4px;">&nbsp;</div>
                        <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                        <button class="k-button pickListButton" onclick="gPicklistCancel('IntendedAction')">Cancel</button>
                    </div>
                </div>-->

                <!-- FACILITY PICKLIST WINDOW -->
                <!--<div id="facilityPicklistWindow" style="display: none;">
                    <div class="pickListHeader">
                        <label>Check the items to show.</label>
                    </div>
                    <div class="pickListContent">
                        <div id="windowFacilityPickList_Table" class="pickListTable" data-bind="foreach: DivisionData">
                            <div class="pickListItem ui-helper-clearfix">
                                <label>
                                    <input type="checkbox" data-bind="attr: { id: id }" />
                                    <span class="pickListItemLabel" data-bind="text: name"></span>
                                </label>
                            </div>
                        </div>
                        <!-- MUST USE Name_Table NAMING FORMAT FOR ID 
                    </div>
                    <div class="pickListFooter">
                        <button class="k-button pickListButton" data-bind="click: pickListCheckAll">All</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                        <div style="height: 4px;">&nbsp;</div>
                        <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCancel">Cancel</button>
                    </div>
                </div>-->

                <!-- SECONDARY REC TYPE PICKLIST WINDOW -->
                <!--<div id="secondaryRecTypePicklistWindow" style="display: none;">
                    <div class="pickListHeader">
                        <label>Check the items to show.</label>
                    </div>
                    <div class="pickListContent">
                        <div id="windowSecondaryRecTypePickList_Table" class="pickListTable" data-bind="foreach: DivisionData">
                            <div class="pickListItem ui-helper-clearfix">
                                <label>
                                    <input type="checkbox" data-bind="attr: { id: id }" />
                                    <span class="pickListItemLabel" data-bind="text: name"></span>
                                </label>
                            </div>
                        </div>
                        <!-- MUST USE Name_Table NAMING FORMAT FOR ID 
                    </div>
                    <div class="pickListFooter">
                        <button class="k-button pickListButton" data-bind="click: pickListCheckAll">All</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                        <div style="height: 4px;">&nbsp;</div>
                        <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                        <button class="k-button pickListButton" data-bind="click: pickListCancel">Cancel</button>
                    </div>
                </div>-->

            </div>
        </div>
    </form>
</body>
</html>
