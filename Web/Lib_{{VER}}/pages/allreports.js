$(document).ready(function () {
    /////////////////////////////////
    //// GENERAL DECLARATIONS
    //var gSafeGuid = getGSafeGUID();
    ////var collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //var parms = "";
    //var dsFireOutputReports = [];
    //var dsBMOutputReports = [];
    //var dsIROutputReports = [];
    //var dsJurisOutputReports = []
    //var dsNatHazSeismicOutputReports = [];
    //var dsNatHazFloodOutputReports = [];
    //var dsNatHazWindOutputReports = [];


    /////////////////////////////////
    //// BUILD DATASOURCES
    //parms = gSafeGuid + "|" + "FireBatchReports";
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsFireOutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Fire Batch Reports.");
    //}

    //parms = gSafeGuid + "|" + "BMBatchReports";
    //collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsBMOutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Boiler Batch Reports.");
    //}

    //parms = gSafeGuid + "|" + "IRBatchReports";
    //collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsIROutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Infrared Batch Reports.");
    //}

    //parms = gSafeGuid + "|" + "JurisBatchReports";
    //collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsJurisOutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Jurisdictional Batch Reports.");
    //}

    //parms = gSafeGuid + "|" + "NatHazSeismicBatchReports";
    //collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsNatHazSeismicOutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Seismic Batch Reports.");
    //}

    //parms = gSafeGuid + "|" + "NatHazFloodBatchReports";
    //collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsNatHazFloodOutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Flood Batch Reports.");
    //}

    //parms = gSafeGuid + "|" + "NatHazWindBatchReports";
    //collSiteMap = new es.objects.ViewCCNavLinkCollection();
    //es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
    //if (!collSiteMap.ViewCCNavLinksAllReportsByKeyword(parms)) {
    //    dsNatHazWindOutputReports = buildDataSource();
    //} else {
    //    alert("Error: Unable to build Wind Batch Reports.");
    //}


    /////////////////////////////////
    //// SETUP KENDO UI WIDGETS
    //// ROW 01
    //var cell0202TreeView = $("#cell0202TreeView").kendoTreeView({
    //    dataSource: dsFireOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");
    //var cell0203TreeView = $("#cell0203TreeView").kendoTreeView({
    //    dataSource: dsBMOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");
    //var cell0204TreeView = $("#cell0204TreeView").kendoTreeView({
    //    dataSource: dsIROutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");
    //var cell0205TreeView = $("#cell0205TreeView").kendoTreeView({
    //    dataSource: dsJurisOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");
    //var cell0206TreeView = $("#cell0206TreeView").kendoTreeView({
    //    dataSource: dsNatHazSeismicOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");
    //var cell0207TreeView = $("#cell0207TreeView").kendoTreeView({
    //    dataSource: dsNatHazFloodOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");
    //var cell0208TreeView = $("#cell0208TreeView").kendoTreeView({
    //    dataSource: dsNatHazWindOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html()), checkboxTemplate: kendo.template($("#templateCheckbox").html())
    //}).data("kendoTreeView");



    /////////////////////////////////
    //// RESET STYLES FOR LINK UNDERLINE
    //$("#cell0202TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});
    //$("#cell0203TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});
    //$("#cell0204TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});
    //$("#cell0205TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});
    //$("#cell0206TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});
    //$("#cell0207TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});
    //$("#cell0208TreeView a").each(function () {
    //    $(this).css("text-decoration", "underline");
    //});


    /////////////////////////////////
    //// EXPAND ALL BY DEFAILT    
    //cell0202TreeView.expand(".k-item");
    //cell0203TreeView.expand(".k-item");
    //cell0204TreeView.expand(".k-item");
    //cell0205TreeView.expand(".k-item");
    //cell0206TreeView.expand(".k-item");
    //cell0207TreeView.expand(".k-item");
    //cell0208TreeView.expand(".k-item");


    /////////////////////////////////
    //// ZOOM IN AND ZOOM OUT, FUNCTIONS    
    //var animationFlag = true;
    //function zoomIn(cell, currentRow, hAlign, vAlign, marginTop, newContentHeight) {
    //    if (animationFlag) {
    //        animationFlag = false;
    //        var mLeft = "0px";
    //        var mTop = marginTop;
    //        if (hAlign == "right") { mLeft = "-90px"; }
    //        else if (hAlign == "left") { mLeft = "5px"; }
    //        else { mLeft = "-40px"; }
    //        if (vAlign == "top") { mTop = "-10px"; }
    //        else if (vAlign == "bottom") { mTop = "-270px"; }
    //        else if (vAlign == "middle" && mTop == "0px") { mTop = "-25px"; }

    //        setZIn(cell, currentRow);
    //        $(cell).addClass("sitemapShadows");
    //        $(cell).animate({
    //            marginLeft: mLeft,
    //            marginTop: mTop
    //        }, "fast");
    //        $(cell + "SubHeading").stop().animate({
    //            width: "280px",
    //            height: "15px",
    //            padding: "5px",
    //            fontSize: "12pt"
    //            //lineHeight: "15px"    //// THIS PROPERTY THROWS ERROR IN IE8
    //        }, "fast");
    //        $(cell + "Content").stop().animate({
    //            width: "280px",
    //            height: newContentHeight,
    //            padding: "5px",
    //            fontSize: "8pt"
    //        }, "fast");
    //        $(cell + "TreeView .k-in").stop().animate({
    //            lineHeight: "12px"
    //            //Height: "12px"
    //        }, "fast");
    //        $(cell + "TreeView").stop().animate({
    //            width: "275px",
    //            height: (parseInt(newContentHeight) - 30).toString() + "px",
    //            //height: newContentHeight,
    //            fontSize: "8pt"
    //        }, "fast");
    //        //$(cell + "Instructions").show();
    //        $(cell + "Instructions").stop().animate({
    //            width: "275px",
    //            height: "30px",
    //            fontSize: "7.5pt"
    //        }, "fast");
    //    }
    //}

    //function zoomOut(cell, originalContentHeight) {
    //    if (!animationFlag) {
    //        $(cell).removeClass("sitemapShadows");
    //        $(cell + "SubHeading").stop().animate({
    //            width: "200px",
    //            height: "12px",
    //            padding: "3px",
    //            fontSize: "7pt"
    //            //lineHeight: "normal"    //// THIS PROPERTY THROWS ERROR IN IE8
    //        }, "fast");
    //        $(cell + "Content").stop().animate({
    //            width: "200px",
    //            height: originalContentHeight,
    //            padding: "3px",
    //            fontSize: "7pt"
    //        }, "fast");
    //        $(cell + "TreeView .k-in").stop().animate({
    //            lineHeight: "8px"
    //            //Height: "10px"
    //        }, "fast");
    //        $(cell + "TreeView").stop().animate({
    //            width: "176px",
    //            height: originalContentHeight,
    //            fontSize: "7pt"
    //        }, "fast");
    //        $(cell + "Instructions").stop().animate({
    //            width: "176px",
    //            height: "30px",
    //            fontSize: "7.5pt"
    //        }, "fast");
    //        //$(cell + "Instructions").hide();
    //        $(cell).animate({
    //            marginLeft: "0px",
    //            marginTop: "0px"
    //        }, "fast", function () {
    //            setZOut();
    //        });
    //        animationFlag = true;
    //    }
    //}

    ////// SET THE Z-ORDER OF PASSED OBJECT
    //function setZIn(cell, currentRow) {
    //    //// SET ALL CELLS TO ZERO
    //    //        $("#row01").css("z-index", "101");
    //    $("#row02").css("z-index", "102");
    //    $("#row02a").css("z-index", "102");
    //    //        $("#row03").css("z-index", "103");
    //    //        $("#cell0101").css("z-index", "200");
    //    //        $("#cell0102").css("z-index", "200");
    //    //        $("#cell0103").css("z-index", "200");
    //    //        $("#cell0104").css("z-index", "200");
    //    //        $("#cell0105").css("z-index", "200");
    //    //        $("#cell0106").css("z-index", "200");
    //    //        $("#cell0107").css("z-index", "200");
    //    //        $("#cell0108").css("z-index", "200");
    //    //        $("#cell0201").css("z-index", "200");
    //    $("#cell0202").css("z-index", "200");
    //    $("#cell0203").css("z-index", "200");
    //    $("#cell0204").css("z-index", "200");
    //    $("#cell0205").css("z-index", "200");
    //    $("#cell0206").css("z-index", "200");
    //    $("#cell0207").css("z-index", "200");
    //    $("#cell0208").css("z-index", "200");
    //    //        $("#cell0301").css("z-index", "200");
    //    //        $("#cell0302").css("z-index", "200");
    //    //        $("#cell0303").css("z-index", "200");
    //    //        $("#cell0304").css("z-index", "200");
    //    //        $("#cell0305").css("z-index", "200");
    //    //        $("#cell0306").css("z-index", "200");
    //    //        $("#cell0307").css("z-index", "200");
    //    //        $("#cell0308").css("z-index", "200");

    //    //// SET PASSED CELL AND ROW TO TOP
    //    if (currentRow == 1) { $("#row01").css("z-index", "150"); }
    //    else if (currentRow == 2) { $("#row02").css("z-index", "150"); $("#row02a").css("z-index", "150"); }
    //    else { $("#row03").css("z-index", "150"); }
    //    $(cell).css("z-index", "999");
    //}
    //function setZOut() {
    //    //        $("#row01").css("z-index", "101");
    //    $("#row02").css("z-index", "102");
    //    $("#row02a").css("z-index", "102");
    //    //        $("#row03").css("z-index", "103");
    //    //        $("#cell0101").css("z-index", "200");
    //    //        $("#cell0102").css("z-index", "200");
    //    //        $("#cell0103").css("z-index", "200");
    //    //        $("#cell0104").css("z-index", "200");
    //    //        $("#cell0105").css("z-index", "200");
    //    //        $("#cell0106").css("z-index", "200");
    //    //        $("#cell0107").css("z-index", "200");
    //    //        $("#cell0108").css("z-index", "200");
    //    //        $("#cell0201").css("z-index", "200");
    //    $("#cell0202").css("z-index", "200");
    //    $("#cell0203").css("z-index", "200");
    //    $("#cell0204").css("z-index", "200");
    //    $("#cell0205").css("z-index", "200");
    //    $("#cell0206").css("z-index", "200");
    //    $("#cell0207").css("z-index", "200");
    //    $("#cell0208").css("z-index", "200");
    //    //        $("#cell0301").css("z-index", "200");
    //    //        $("#cell0302").css("z-index", "200");
    //    //        $("#cell0303").css("z-index", "200");
    //    //        $("#cell0304").css("z-index", "200");
    //    //        $("#cell0305").css("z-index", "200");
    //    //        $("#cell0306").css("z-index", "200");
    //    //        $("#cell0307").css("z-index", "200");
    //    //        $("#cell0308").css("z-index", "200");
    //}


    ///////////////////////////////////
    ////// FUNCTIONS TO BUILD DATASOURCES
    //function buildDataSource() {
    //    var parentId = getParentId();
    //    var returnCollection = [];
    //    for (y = 0; y < collSiteMap().length; y++) {
    //        if (collSiteMap()[y].NavParentLinkId() != undefined && collSiteMap()[y].NavParentLinkId() == parentId) {
    //            var subMenu = buildSubMenu(collSiteMap()[y].NavLinkId());
    //            if (returnCollection.length == 0) {
    //                returnCollection = [{
    //                    key: collSiteMap()[y].NavLinkId(),
    //                    text: collSiteMap()[y].NavText(),
    //                    url: "",
    //                    NavUrl: getNavUrl(collSiteMap()[y].NavUrl()),
    //                    target: collSiteMap()[y].NavTarget(),
    //                    navEnabled: collSiteMap()[y].NavEnabled(),
    //                    reportCode: collSiteMap()[y].NavRptCode(),
    //                    items: subMenu,
    //                    comment: "" //"(NavLinkId: " + collSiteMap()[y].NavLinkId() + ", GridId: " + collSiteMap()[y].NavGridId() + ", ChartId: " + collSiteMap()[y].NavChartId() + ", ReportCode: " + collSiteMap()[y].NavRptCode() + ") " + collSiteMap()[y].NavStatusToolTip()
    //                }];
    //            } else {
    //                returnCollection.push({
    //                    key: collSiteMap()[y].NavLinkId(),
    //                    text: collSiteMap()[y].NavText(),
    //                    url: "",
    //                    NavUrl: getNavUrl(collSiteMap()[y].NavUrl()),
    //                    target: collSiteMap()[y].NavTarget(),
    //                    navEnabled: collSiteMap()[y].NavEnabled(),
    //                    reportCode: collSiteMap()[y].NavRptCode(),
    //                    items: subMenu,
    //                    comment: "" //"(NavLinkId: " + collSiteMap()[y].NavLinkId() + ", GridId: " + collSiteMap()[y].NavGridId() + ", ChartId: " + collSiteMap()[y].NavChartId() + ", ReportCode: " + collSiteMap()[y].NavRptCode() + ") " + collSiteMap()[y].NavStatusToolTip()
    //                });
    //            }
    //        }
    //    }

    //    return returnCollection;
    //}

    //function buildSubMenu(NavLinkId) {
    //    var returnSubMenu = [];
    //    for (x = 0; x < collSiteMap().length; x++) {
    //        if (NavLinkId == collSiteMap()[x].NavParentLinkId()) {
    //            if (returnSubMenu.length == 0) {
    //                returnSubMenu = [{
    //                    key: collSiteMap()[x].NavLinkId(),
    //                    text: collSiteMap()[x].NavText(),
    //                    url: "",
    //                    NavUrl: getNavUrl(collSiteMap()[x].NavUrl()),
    //                    navEnabled: collSiteMap()[x].NavEnabled(),
    //                    reportCode: collSiteMap()[x].NavRptCode(),
    //                    target: collSiteMap()[x].NavTarget(),
    //                    comment: "" //"(NavLinkId: " + collSiteMap()[x].NavLinkId() + ", GridId: " + collSiteMap()[x].NavGridId() + ", ChartId: " + collSiteMap()[x].NavChartId() + ", ReportCode: " + collSiteMap()[x].NavRptCode() + ") " + collSiteMap()[x].NavStatusToolTip()
    //                }];
    //            } else {
    //                returnSubMenu.push({
    //                    key: collSiteMap()[x].NavLinkId(),
    //                    text: collSiteMap()[x].NavText(),
    //                    url: "",
    //                    NavUrl: getNavUrl(collSiteMap()[x].NavUrl()),
    //                    navEnabled: collSiteMap()[x].NavEnabled(),
    //                    reportCode: collSiteMap()[x].NavRptCode(),
    //                    target: collSiteMap()[x].NavTarget(),
    //                    comment: "" //"(NavLinkId: " + collSiteMap()[x].NavLinkId() + ", GridId: " + collSiteMap()[x].NavGridId() + ", ChartId: " + collSiteMap()[x].NavChartId() + ", ReportCode: " + collSiteMap()[x].NavRptCode() + ") " + collSiteMap()[x].NavStatusToolTip()
    //                });
    //            }
    //        }
    //    }
    //    return returnSubMenu;
    //}

    //function getParentId() {
    //    for (z = 0; z < collSiteMap().length; z++) {
    //        if (collSiteMap()[z].NavParentLinkId() == undefined) {
    //            return collSiteMap()[z].NavLinkId();
    //        }
    //    }
    //}

    //function getNavUrl(navUrl) {
    //    if (navUrl != "" && navUrl != undefined) {
    //        if (navUrl.indexOf("?") > 0) {
    //            return navUrl + "&sid=" + gSafeGuid;
    //        } else {
    //            return navUrl + "?sid=" + gSafeGuid;
    //        }
    //    } else {
    //        return "";
    //    }
    //}



});