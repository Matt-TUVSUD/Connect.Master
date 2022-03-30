<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WhatIfAnalysisTool.aspx.vb" Inherits="GRC.Connect.Web.WhatIfAnalysisTool" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>What If Analysis Tool</title>
    <link rel="Stylesheet" type="text/css" href="../../css/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/windows.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/print.css" media="print" />
    <link rel="stylesheet" type="text/css" href="../../css/WhatIf/WhatIfStyles.css"  />
    <link rel="Stylesheet" type="text/css" href="../../../css/GRC_Kendo_Overrides.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Font-Awesome/all.css" />
    
    <%--<script src="https://kit.fontawesome.com/94c91a27ac.js"></script>--%>
    <%--<script src="../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/JQuery/jQuery.3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <%--<script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/WhatIf/Knockout.v3.4.2.js"></script>
    <script src="../../Lib_{{VER}}/WhatIf/kendo.all.min.js"></script>
    <script src="../../Lib_{{VER}}/WhatIf/kendo.grc.grid.js"></script>
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
    <script src="../../Lib_{{VER}}/WhatIf/WhatIf.js"></script>

    <script>
        var gCurrencyIdFromPrefilter = "<%=ServerSide_CurrencyIdFromPrefilter%>";
    </script>

</head>
<body spellcheck="false" style="background:#eee;">
    <form id="form1" runat="server">
    <div>
        <div id="divContainerLoading">
            <div id="grcLoader">
                <div id="grcInternalLoader"></div>
            </div>
        </div>
        <div class="headerContainerElastic">
            <div class="headerLeft">
                <div class="headerCompanyNameLargeBlue"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblCompany" data-bind="text: view.clientName"></span></div>
            </div>
            <div class="headerRight">
                <div class="headerPageTitle"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblPageTitle">What If Analysis Tool</span></div>
            </div>
        </div>
        <br style="clear: both;" />
        <div class="masterTopBannerElastic100">
            <div class="topBanner_Container_Other_Elastic_Blue">
                <div class="TxtRightAlign floatRight" style="width: 32px; padding-right: 35px;">
                    <a title="Knowledge Base" class="i-information" onclick="openRequestedKnowledgeBasePopup(null, null)" href="#"></a>
                </div>
                <div class="headerWelcomeWhite">
                    <label>Welcome</label>
                    <asp:Label runat="server" ID="lblLoginUser" CssClass="userNameLbl headerTxt" Text=""></asp:Label> | <a onclick="setCurrentTab(utilConstants.pageId_LogOut, utilConstants.pageId_Gauge)" href="#"><span id="ClientConnectSiteBody_ClientConnectFormBody_lblLogoutHeader">Logout</span></a>
                </div>
                <br />
                <div class="headerTodaysDateLightBlue"><asp:Label runat="server" ID="lblTodaysDate" Text=""></asp:Label></div>
            </div>
            <br style="clear: both;" />
        </div>
            <!-- END HEADER -->
        <div class="pageBody">
            <div id="msgCenter">
                <span data-bind="text: view.txtMessage"></span>
            </div>
            <!-- CHART SECTION -->
            <div id="chartArea" class="ui-helper-clearfix" style="margin: 0 auto; width:1775px;">
                <div id="accordianSectionHldr" class="ui-helper-clearfix floatLeft" style="width:200px;">
                    <div id="accordianFilterLblHldr" class="floatLeft" style="margin-top:15px;">
                        &nbsp;
                    </div>
                    <div id="accordianHldr" class="floatLeft">
                        <ul id="panelBar">
                            <li>
                                <span>File No.</span>
                                <div class="accordianGroup" data-bind="foreach: fileNoAccordianData">
                                    <div class="accodianItem">
                                        <input type="checkbox" class="accordianCheckBox" data-bind="attr: { id: $data.ID, name: $data.Name }" onclick="    gAccordianItemCheck(id, view.fileNoAccordianID, name)" />
                                        <span class="accordianItemLabel" data-bind="text: $data.Name"></span>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <span>Client Location ID</span>
                                <div class="accordianGroup" data-bind="foreach: clientLocAccordianData">
                                    <div class="accodianItem">
                                        <input type="checkbox" class="accordianCheckBox" data-bind="attr: { id: $data.ID, name: $data.Name }" onclick="    gAccordianItemCheck(id, view.clientLocAccordianID, name)" />
                                        <span class="accordianItemLabel" data-bind="text: $data.Name"></span>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <span class="TxtLeftAlign">Facility</span>
                                <div class="accordianGroup" data-bind="foreach: facilityAccordianData">
                                    <div class="accordianItem">
                                        <input type="checkbox" class="accordianCheckBox" data-bind="attr: { id: $data.ID, name: $data.Name }" onclick="    gAccordianItemCheck(id, view.facilityAccordianID, name)" />
                                        <span class="accordianItemLabel" data-bind="text: $data.Name"></span>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <span class="TxtLeftAlign">Division</span>
                                <div class="accordianGroup" data-bind="foreach: divisionAccordianData">
                                    <div class="accodianItem">
                                        <input type="checkbox" class="accordianCheckBox" data-bind="attr: { id: $data.ID, name: $data.Name }" onclick="    gAccordianItemCheck(id, view.divisionAccordianID, name)" />
                                        <span class="accordianItemLabel" data-bind="text: $data.Name"></span>
                                    </div>
                                </div>
                            </li>
                            <li data-bind="visible: view.showCustomAccessAccordian">
                                <span>Custom Access</span>
                                <div class="accordianGroup" data-bind="foreach: customAccessAccordianData">
                                    <div class="accodianItem">
                                        <input type="checkbox" class="accordianCheckBox" data-bind="attr: { id: $data.ID, name: $data.Name }" onclick="    gAccordianItemCheck(id, view.customAccessAccordianID, name)" />
                                        <span class="accordianItemLabel" data-bind="text: $data.Name"></span>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div id="ratingChartHldr" class="floatLeft" style="width:500px;">
                    <h2 class="chartTitle TxtCenterAlign"><a href='#' data-bind="click: ratingScoreClick">Rating Average Score</a></h2>
                    <div id="RatingScoreChart" style="margin:0 auto;"></div>
                </div>
                <div id="achievableRatingChartHldr" class="floatLeft" style="width:525px;">
                    <h2 class="chartTitle TxtCenterAlign"><a href='#' data-bind="click: achievableRatingClick">Achievable Rating %</a></h2>
                    <div id="AchievableRatingChart" style="margin:0 auto;"></div>
                </div>
                <div id="riskImprovmentChartHldr" class="floatLeft" style="width:520px;">
                    <h2 class="chartTitle TxtCenterAlign"><a href='#' data-bind="click: riskImprovementClick">Risk Improvement</a></h2>
                    <div id="RiskImporvementChart" style="margin:0 auto;"></div>
                </div>
            </div>
            <!-- END CHART SECTION -->
            <!-- INFORMATION SECTION -->
            <div id="infoSection" class="ui-helper-clearfix" style="margin: 10px auto; width:1775px;">
                <div id="infoLeft" class="ui-helper-clearfix floatLeft" style="width:455px; margin-left:234px;">
                    <div class="floatLeft" style="width:450px; margin-bottom:5px;">
                        <label class="TxtBold floatLeft" style="display:block; width:350px; font-size:14px; line-height:20px;">
                            Estimated Budget:
                        </label>
                        <input id="budgetBox" class="TxtRightAlign floatLeft editableInput" data-bind="value: view.estBudget" onblur="view.budgetBoxOnBlur()" style="font-size:14px; width:20%;" type="text"/>
                    </div>
                    <div class="floatLeft" style="width:450px; margin-bottom:5px;">
                        <label class="floatLeft" style="display:block; width:355px; font-size:14px;">
                            <strong>Est. Cost To Complete:</strong>
                        </label>
                        <label id="costToCompleteBox" class="floatLeft TxtRightAlign" data-bind="text: view.estCostToComplete" style="display:block; width:20%; font-size:14px;"></label>
                    </div>
                    <div class="floatLeft" style="width:450px; margin-bottom:5px; margin-top:5px;">
                        <label class="floatLeft TxtBold" style="display:block; width:355px; font-size:14px;">
                            Remaining Budget:
                        </label>
                        <label id="remainingBudgetBox" class="overZero floatLeft TxtRightAlign TxtBold" data-bind="text: view.remainingBudget" style="display:block; width:20%; font-size:14px;"></label>
                    </div>
                    <%--<div class="floatLeft" style=" width:450px;" >
                        <label class="floatLeft TxtBold" style="display:block; width:315px; line-height:22px; font-size:14px;">
                            Sort By:
                        </label>
                        <input id="sortByDD" class="floatLeft TxtCenterAlign" style="width:135px; font-size:14px; background: #FFFF99;" />
                    </div>--%>
                </div>
                <div id="midSection" class="floatLeft" style="width:575px;">&nbsp;</div>
                <div id="infoRight" class="floatLeft" style="width:500px;">
                    <div class="floatLeft" style="width:100%; margin-bottom:5px; height:20px;">
                        <label class="floatLeft TxtBold" style="display:block; width:80%;  font-size:14px;">
                            Total Recommendations Selected Count:
                        </label>
                        <label class="floatLeft TxtRightAlign" data-bind="text: view.TotalRecsSelectedCount" style="display:block; width:20%; font-size:14px;"></label>
                    </div>
                    <div class="floatLeft" style=" width:100%; margin-bottom:5px;">
                        <label class="floatLeft TxtBold" style="display:block; width:80%; float:left; font-size:14px;">
                            Total Selected Score Change:
                        </label>
                        <label class="floatLeft TxtRightAlign" data-bind="text: view.TotalRecsSelectedScoreChange" style="display:block; width:20%; font-size:14px;"></label>
                    </div>
                    <div class="floatLeft" style="width:100%; margin-bottom:5px; margin-top:5px;">
                        <label class="floatLeft TxtBold" style="display:block; width:80%; font-size:14px;">
                            Human Element Selected Recommendations Count:
                        </label>
                        <label class="floatLeft TxtRightAlign" data-bind="text: view.HERecsSelectedCount" style="display:block; width:20%; font-size:14px;"></label>
                    </div>
                    <div class="floatLeft" style="width:100%; margin-top:5px;" >
                        <label class="floatLeft TxtBold" style="display:block; width:80%; font-size:14px;">
                            Human Element Rec Score Change:
                        </label>
                        <label class="floatLeft TxtRightAlign" data-bind="text: view.HERecsSelectedScoreChange" style="display:block; width:20%; font-size:14px;"></label>
                    </div>
                </div>
            </div>
            <!-- END INFORMATION SECTION -->
            <!-- GRID SECTION -->
            <div id="gridInfoHldr">
                <div class="ui-helper-clearfix">
                    <label class="floatLeft" style="display: block;">Location Filters:&nbsp;</label>
                    <label class="floatLeft" style="display: block;" data-bind="text: view.accordianAppliedFilters"></label>
                </div>
                <div class="ui-helper-clearfix">
                    <label class="floatLeft">Sorted:&nbsp;</label>
                    <label class="floatLeft" data-bind="text: view.sortByString"></label>
                </div>
                <div class="ui-helper-clearfix">
                    <label class="floatLeft">Grid Filtered:&nbsp;</label>
                    <label class="floatLeft" data-bind="text: view.filterByTxtString"></label>
                </div>
                <div class="ui-helper-clearfix">
                    <label class="floatLeft">Pinned:&nbsp;</label>
                    <label class="floatLeft" data-bind="text: view.pinnedString"></label>
                </div>
            </div>
            <div id="gridToolbar" class="toolBar" style="">
                <label class="floatLeft" id="gridRecCountLbl" data-bind="text: view.gridTotalRecCount"></label>
                <a class="btnBase floatRight" data-bind="click: extractDataClick"><i style="margin-right:10px;" class="fas fa-file-export"></i>Extract Data</a>
                <a class="btnBase floatRight btnWide" data-bind="click: downloadReportClick"><i style="margin-right:10px;" class="fas fa-download"></i>Download Report</a>
                <a class="btnBase floatRight btnWide" data-bind="click: resetGridPageClick"><i style="margin-right:10px;" class="fas fa-undo"></i>Reset Page/Grid</a>
                <a id="clearSortsFiltersBtn" class="btnBase floatRight btnWide" data-bind="click: clearSortsFiltersClick, enable: enableSortsFilterBtn" style="width: 175px"><i class="fas fa-eye-slash"></i>&nbsp;&nbsp;Clear Grid Sorts/Filters</a>
                <a id="clearSelectionsBtn" class="btnBase floatRight btnWide" data-bind="click: clearSelctionsClick, enable: enableClearSelectionsBtn"><i class="fas fa-ban"></i>&nbsp;&nbsp;Clear Selections</a>
                <a id="filterByBtn" class="btnBase floatRight btnWide noLeftMargin" data-bind="click: filterBySelectionsClick, enable: enableFilterByBtn"><i style="margin-right:5px;" class="fas fa-filter"></i>Filter By Selections</a>
            </div>
            <div id="gridHldr" class="ui-helper-clearfix" style="margin: 0 auto; width:1770px;">
                <div id="gridDiv"></div>
            </div>
            <!-- END GRID SECTION -->
        </div>
            <!-- POPUP WINDOWS -->
            <div id="ratingScoreChartWindow" style="display:none; padding:5px;" class="ui-helper-clearfix">
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Average Rating Score Chart: &nbsp;</strong>
                        Reflects the Weighted Averages based on the Total Rating Score.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Current:&nbsp;</strong>
                        Average rating based on the latest inspection.  This does not reflect Rptd. Completed Recs and What If Recs selected.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>W/Recs. Rptd. Completed:&nbsp;</strong>
                        This includes Rptd. Completed Recs and recalculates the Rating Average in this scenario.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>W/What If Recs. Completed:&nbsp;</strong>
                        This includes Rptd. Completed Recs and What If Recs selected and recalculates the Raiting Average in this scenario.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow noBottomMargin">
                    <span class="popupTxt floatLeft">
                        <strong>Location Filter:&nbsp;</strong>
                        This chart reflects the average for all locations based on your access level.  The location filter allows you to filter a sub-set of those locations. This filter will be reflected in the Charts and applied to the Grid as a filter.
                    </span>
                </div>
            </div>
            <div id="achievableRatingChartWindow" style="display:none; padding:5px;" class="ui-helper-clearfix">
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Average Achievable Rating % Chart: &nbsp;</strong>
                        Reflects the Weighted Averages based on the Achievable Rating.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Current:&nbsp;</strong>
                        Average Rating based on the latest inspection.  This does not reflect Rptd. Completed Recs and What If Recs selected.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>W/Recs. Rptd. Completed:&nbsp;</strong>
                        This includes Rptd. Completed Recs and recalculates the Rating Average in this scenario.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>W/What If Recs. Completed:&nbsp;</strong>
                        This includes Rptd. Completed Recs and What If Recs selected and recalculates the Rating Average in this scenario.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow noBottomMargin">
                    <span class="popupTxt floatLeft">
                        <strong>Location Filter:&nbsp;</strong>
                        This chart reflects the average for all locations based on your access level.  The Location Filter allows you to filter a sub-set of those locations.  This filter will be reflected in the Charts and applied to the Grid as a filter.
                    </span>
                </div>
            </div>
            <div id="riskImprovementChartWindow" style="display:none; padding:5px;" class="ui-helper-clearfix">
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Risk Improvement Chart: &nbsp;</strong>
                        Reflects the Identified Risk and what is Remaining and Improved based on the What If scenario (Rptd. Completed and What If selected recommendations).
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Identified: &nbsp;</strong>
                        Sum of the Recommendations Loss Estimate Before minus the sum of the Loss Estimate After.  Includes all Recommendations.
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Remaining:&nbsp;</strong>
                        Total Identified minus the Identified for Closed Recommendations (Conf. Completed, Removed, Rptd. Completed statuses and What If selected Recommendations).
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Improved: &nbsp;</strong>
                        Sum of the Recommendations Loss Estimate Before minus the sum of the Loss Estimate After for Closed Recommendations (Conf. Completed, Removed, Rptd. Completed statuses and What If selected Recommendations).
                    </span>
                </div>
                <div class="ui-helper-clearfix popupRow">
                    <span class="popupTxt floatLeft">
                        <strong>Location Filter:&nbsp;</strong>
                        This chart reflects the counts for all locations based on your access level.  The Location Filter allows you to filter a sub-set of those locations.  This filter will be reflected in the Charts and applied to the Grid as a filter.
                    </span>
                </div>
            </div>
            <div id="windowPickList" class="pickListWindow">
                <div class="pickListHeader">
                    <label>Check the items to show.</label></div>
                <div class="pickListContent">
                    <div id="windowPickList_Loading" class="pickListLoading">
                        <!-- MUST USE Name_Loading NAMING FORMAT FOR ID -->
                        <%--<img src="../Images/Other/loading_2x.gif" class="pickListLoadingImage" />--%>
                    </div>
                    <div id="windowPickList_Table" class="pickListTable"></div>
                    <!-- MUST USE Name_Table NAMING FORMAT FOR ID -->
                </div>
                <div class="pickListFooter">
                    <button class="k-button pickListButton" data-bind="click: pickListCheckAll">All</button>&nbsp;
                    <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                    <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                    <div style="height: 4px;">&nbsp;</div>
                    <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                    <button class="k-button pickListButton" data-bind="click: pickListCancel">Cancel</button>
                </div>
            </div>
            <div id="locationListingWindow" class="ui-helper-clearfix" style="display:none; padding:5px;">
                <div class="borderedGrid">
                    <div class="borderedHeader ui-helper-clearfix">
                        <div id="CurrentScoreBox" class="floatLeft locationBox">
                            <span>Current Score</span>
                        </div>
                        <div id="AchievableRatingBox" class="floatLeft locationBox">
                            <span>Achievable Rating %</span>
                        </div>
                        <div id="RecsCompWhatIfCompBox" class="floatLeft locationBox">
                            <span>Total Score with Recs<br />Rptd. Completed<br />and What If<br />Completed</span>
                        </div>
                        <div id="AchievableRatingWhatIfBox" class="floatLeft locationBox">
                            <span>Achievable Rating %<br />With Recs Rptd.<br />Completed and<br />What If Completed</span>
                        </div>
                        <div id="RecsCompBox" class="floatLeft locationBox">
                            <span>Total Score with All<br />Recs Completed</span>
                        </div>
                        <div id="" class="floatLeft locationBox" style="border-right: none;">
                            <span>Achievable Rating %<br />With All Recs Completed</span>
                        </div>
                    </div>
                    <div class="borderedGridBody ui-helper-clearfix">
                        <div id="curScoredData" data-bind="style: {background: view.currentScoreBackgroundColor}" class="floatLeft TxtCenterAlign locationData">
                            <span data-bind="text: view.currentScoreString, style: {color: view.currentScoreTextColor}"></span>
                        </div>
                        <div id="RatingData" data-bind="style: { background: view.achievableRatingPercentBackgroundColor }" class="floatLeft TxtCenterAlign locationData">
                            <span data-bind="text: view.achievableRatingPercentString, style: {color: view.achievableRatingPercentTextColor}"></span>
                        </div>
                        <div id="totalScoreRecsWhatifData" data-bind="style: { background: view.totalWhatifAndRecsCompleteScoreBackgroundColor }" class="floatLeft TxtCenterAlign locationData">
                            <span data-bind="text: view.totalWhatifAndRecsCompleteScoreString, style: {color: view.totalWhatIfAndRecsCompleteScoreTextColor}"></span>
                        </div>
                        <div id="achievableCompRecsWhatifData" data-bind="style: { background: view.achievableRatingPercentRecsRptdCompleteBackgroundColor }" class="floatLeft TxtCenterAlign locationData">
                            <span data-bind="text: view.achievableRatingPercentRecsRptdCompleteString, style: { color: view.achievableRatingPercentRecsRptdCompleteTextColor }"></span>
                        </div>
                        <div id="recsTotalScoreData" data-bind="style: { background: view.totalRecsCompleteScoreBackgroundColor }" class="floatLeft TxtCenterAlign locationData">
                            <span data-bind="text: view.totalRecsCompleteScoreString, style: { color: view.totalRecsCompleteScoreTextColor }"></span>
                        </div>
                        <div data-bind="style: { background: view.allRecsCompAchievableRatingPercentBackColor}" class="floatLeft TxtCenterAlign locationData noRightBorder">
                            <span data-bind="text: view.allRecsCompAchievableRatingPercentString, style: { color: view.allRecsCompAchievableRatingPercentForeColor }"></span>
                        </div>
                    </div>
                </div>
            </div>
            <!-- END POPUP WINDOWS -->
        </div>

        <!-- CLOSE ANY OPEN WINDOW BY CLICKING MODEL BACKGROUND -->
        <script>
            $(document).on('click', '.k-overlay', function () {
                var kendoWindow = $('.k-window-content.k-content', $(this).next('div.k-widget.k-window'));
                if (kendoWindow == null || kendoWindow.length == 0) {
                    return;
                }
                kendoWindow.data('kendoWindow').close();
            });
        </script>
    </form>
</body>
</html>
