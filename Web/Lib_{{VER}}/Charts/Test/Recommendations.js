﻿//$(document).ready(function () {

//    /* BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM */
//    kendo.ui.progress($("#divContainerLoading"), false);

//    /* GLOBAL DATA PLACEHOLDERS */
//    dsMetaData = null;
//    dsChartData = null;
//    globalClientFeatures = getClientFeatures(getGSafeGUID());

//    /* VIEW */
//    viewChart = {
//        /* DECLARATIONS */
//        firstLoad: true,
//        countLoading: 0,

//        /* PERMISSIONS */

//        /* DATA */
//        chartId: null,
//        chartGridData: ko.observableArray([]),
//        chartCriteriaFilter: null,
//        currentDrillDownId: null,
//        largeObjectHandler: null,
//        mouseX: 0,
//        mouseY: 0,

//        /* LARGE OBJECT DATA */
//        largeObjectFilter: null,
//        largeObjectCriteria: null,
//        largeObjectSetting: null,

//        /* LABELS */
//        txtMessage: ko.observable(""),
//        txtIFrameSource: ko.observable(""),

//        /* BUTTON AND VISIBILITY CONTROLS */
//        isDrillDownShown: false,

//        /* KENDO OBJECTS */
//        chartRec: null,


//        /* FUNCTIONS */
//        init: function () {
//            viewChart.countLoading = 5;
//            viewChart.loadLargeObjectData();
//            viewChart.loadDictionary();
//            viewChart.loadData();
//            viewChart.setupEvents();
//        },


//        loadDictionary: function () {
//            viewChart.processLoading();
//        },


//        loadLargeObjectData: function () {
//            try {
//                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
//                    /* STORE THE LARGE OBJECT DATA */
//                    if (ServerSide_LargeObjectFilter !== undefined && ServerSide_LargeObjectFilter !== "") {
//                        viewChart.largeObjectFilter = JSON.parse(ServerSide_LargeObjectFilter);
//                    }
//                    if (ServerSide_LargeObjectCriteria !== undefined && ServerSide_LargeObjectCriteria !== "") {
//                        viewChart.largeObjectCriteria = JSON.parse(ServerSide_LargeObjectCriteria);
//                    }
//                    if (ServerSide_LargeObjectSetting !== undefined && ServerSide_LargeObjectSetting !== "") {
//                        viewChart.largeObjectSetting = JSON.parse(ServerSide_LargeObjectSetting);
//                    }
//                    viewChart.processLoading();
//                } else {
//                    var zServiceName = "GetLargeObjectDataChart";
//                    var zParms = ko.toJSON({
//                        "gSafeGuid": getGSafeGUID()
//                    });
//                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.loadLargeObjectDataSuccess, viewChart.loadLargeObjectDataError, null);
//                }
//            } catch (pException) {
//                viewChart.txtMessage("An error occurred while starting the large object data load call: " + pException.message);
//                global.messageShow("txtMessage", "messageGridError");
//            }
//        },
//        loadLargeObjectDataSuccess: function (pResults, pParms) {
//            try {
//                if (pResults.isSuccess) {
//                    /* STORE THE LARGE OBJECT DATA */
//                    if (pResults.data.filterChart !== undefined && pResults.data.filterChart !== null && pResults.data.filterChart !== "") {
//                        viewChart.largeObjectFilter = pResults.data.filterChart;
//                    }
//                    if (pResults.data.criteriaChart !== undefined && pResults.data.criteriaChart !== null && pResults.data.criteriaChart !== "") {
//                        viewChart.largeObjectCriteria = pResults.data.criteriaChart;
//                    }
//                    if (pResults.data.settingChart !== undefined && pResults.data.settingChart !== null && pResults.data.settingChart !== "") {
//                        viewChart.largeObjectSetting = pResults.data.settingChart;
//                    }
//                } else {
//                    viewChart.txtMessage("An error occurred while loading large object data: " + pResults.message);
//                    global.messageShow("txtMessage", "messageGridError");
//                }
//            } catch (pException) {
//                viewChart.txtMessage("An error occurred while loading large object data: " + pException.message);
//                global.messageShow("txtMessage", "messageGridError");
//            }
//            viewChart.processLoading();
//        },
//        loadLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
//            viewChart.txtMessage("Error while loading large object data. " + pMessage);
//            global.messageShow("txtMessage", "messageGridError");
//            viewChart.processLoading();
//        },


//        loadData: function () {
//            viewChart.loadChartData();
//            /*viewChart.setupKendoChart(); */ /* SKIP META DATA CALL FOR TESTING */
//        },


//        /* LOAD THE CHART META DATA */
//        loadChartData: function () {
//            try {
//                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
//                    if (ServerSide_ChartData !== undefined && ServerSide_ChartData.length > 0) {
//                        dsChartData = JSON.parse(ServerSide_ChartData);
//                        viewChart.processLoading();
//                        viewChart.setupKendo();
//                        viewChart.setupChartGrid();
//                    } else {
//                        viewChart.txtMessage("An error occurred while building the chart meta data in batch mode: " + pException.message);
//                        global.messageShow("txtMessage", "messageChartError");
//                    }
//                } else {
//                    var zIsDrillDown = false;
//                    if (ServerSide_IsDrillDownMode.toLowerCase() == "true") {
//                        zIsDrillDown = true;
//                    }
//                    var zServiceName = "GetChartData";
//                    var zParms = ko.toJSON({
//                        "filter": null,
//                        "criteria": null,
//                        "pIsDrillDown": zIsDrillDown,
//                        "gSafeGuid": getGSafeGUID()
//                    });
//                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.loadChartDataSuccess, viewChart.loadChartDataError, null);
//                }
//            } catch (pException) {
//                viewChart.txtMessage("An error occurred while starting the chart meta data call: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//        },
//        loadChartDataSuccess: function (pResults, pParms) {
//            try {
//                dsChartData = pResults;
//                viewChart.chartId = pResults.fldId;
//                /*dsChartData = dsChartTestDataJSON; */
//            } catch (pException) {
//                viewChart.txtMessage("An error occurred while building chart data: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//            viewChart.processLoading();
//            viewChart.setupKendo();
//            viewChart.setupChartGrid();
//        },
//        loadChartDataError: function (pResults, pMessage, pErrorDetail, pParms) {
//            viewChart.txtMessage("Error while loading meta data. " + pMessage);
//            global.messageShow("txtMessage", "messageChartError");
//        },


//        downloadPDF: function () {
//            var zHTML = "";
//            var zCSS = "";
//            /*$.get("../Styles/Kendo/kendo.common.min.css", function (pResults) { */
//            /* CREATE THE HTML AND CSS DATA VARIABLES */
//            if (viewChart.printHTML == null) {
//                /* REMOVE ANY NO PRINT DOMS */
//                    var zDocument = $("html").clone();
//                    zDocument.find(".printNone").each(function () {
//                        $(this).remove();
//                    });
//                    zHTML = $(zDocument).html();
//                } else {
//                    zHTML = viewChart.printHTML;
//                }
                
//            zHTML = zHTML.replace(/(\r\n|\n|\r)/gm, " "); /* REMOVE ALL LINE BRAKES */
//            zHTML = zHTML.replace(/(\r\t|\t|\r)/gm, " "); /* REMOVE ALL TABS */
//            zHTML = zHTML.replace(/(\")/gm, "'"); /* REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES */
//            zHTML = zHTML.replace(/(<)/gm, "||OPEN||"); /* REPLACE ALL OPEN BRACKETS */
//            zHTML = zHTML.replace(/(>)/gm, "||CLOSE||"); /* REPLACE ALL CLOSING BRACKETS */
//            zHTML = zHTML.replace(/  /gm, ""); /* REPLACE ALL EXTRA SPACES */
//            zCSS = ""/*pResults; */
//            zCSS = zCSS.replace(/(\r\n|\n|\r)/gm, " "); /* REMOVE ALL LINE BRAKES */
//            zCSS = zCSS.replace(/(\")/gm, "'"); /* REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES */
//            zCSS = zCSS.replace(/  /gm, ""); /* REPLACE ALL EXTRA SPACES */
//            /*zCSS = zCSS.replace(/1px/gm, "2px"); /* REPLACE ALL 1PX LINES TO THICKER */

//            /* CALL HANDLER PAGE BY CREATING A FORM */

//            /* CREATE A FORM DOM ELEMENT */
//            var zForm = document.createElement("form");
//            zForm.setAttribute("id", "frmPDF");
//            zForm.setAttribute("method", "post");
//            zForm.setAttribute("action", "../../FD/ServeHTMLToPDF.ashx");
//            document.body.appendChild(zForm);

//            /* CREATE HIDDEN INPUT DOM ELEMENTS */
//            var zField1 = document.createElement("input");
//            zField1.setAttribute("type", "hidden");
//            zField1.setAttribute("id", "pHTML");
//            zField1.setAttribute("name", "pHTML");
//            zField1.setAttribute("value", zHTML);
//            zForm.appendChild(zField1);
//            var zField2 = document.createElement("input");
//            zField2.setAttribute("type", "hidden");
//            zField2.setAttribute("id", "pCSS");
//            zField2.setAttribute("name", "pCSS");
//            zField2.setAttribute("value", zCSS);
//            zForm.appendChild(zField2);
//            var zField3 = document.createElement("input");
//            zField3.setAttribute("type", "hidden");
//            zField3.setAttribute("id", "pZoomFactor");
//            zField3.setAttribute("name", "pZoomFactor");
//            zField3.setAttribute("value", "1.2");
//            zForm.appendChild(zField3);
//            var zField4 = document.createElement("input");
//            zField4.setAttribute("type", "hidden");
//            zField4.setAttribute("id", "pOrientation");
//            zField4.setAttribute("name", "pOrientation");
//            zField4.setAttribute("value", "Landscape");
//            zForm.appendChild(zField4);

//            /* SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN */
//            zForm.submit();
//            zForm.removeChild(zField1);
//            zForm.removeChild(zField2);
//            zForm.removeChild(zField3);
//            zForm.removeChild(zField4);
//            document.body.removeChild(zForm);
//            /*}); */
//        },


//        onSeriesHover: function (pEvent) {
//            if (ServerSide_IsDrillDownMode != "true") {
//                var zDrillDownType = pEvent.dataItem.__proto__.fldMetaChartDrillDownTypeId;
//                var zDrillDownId = pEvent.dataItem.__proto__.fldMetaChartDrillDownId;
//                if (zDrillDownType !== undefined && zDrillDownType == 1) { /* TYPE 1 = CHART */
//                    /*var zIFrame = $("#divDrillDownContainer");*/
//                    var zIFrame = $("#" + gDivDrillDownContainerId);
//                    var zPosX = viewChart.mouseX;
//                    var zPosY = viewChart.mouseY;
//                    if (viewChart.currentDrillDownId != zDrillDownId) {
//                        viewChart.currentDrillDownId = zDrillDownId;
//                        /* SET THE URL AND SHOW THE FRAME AT MOUSE POSITION */
//                        viewChart.txtIFrameSource("");
//                        viewChart.txtIFrameSource(SITEBASEURL + "Home_{{VER}}/Charts/Default.aspx?sid=" + getGSafeGUID() + "&DrillDown=true&chartId=" + viewChart.currentDrillDownId + "&PrimaryRecTypeFromDrillDown=" + pEvent.dataItem.__proto__.fldTitle);
//                        if (!viewChart.isDrillDownShown) {
//                            zIFrame.fadeOut(function () {
//                                zIFrame.css("left", zPosX);
//                                zIFrame.css("top", zPosY + 20);
//                                zIFrame.fadeIn();
//                            });
//                        } else {
//                            zIFrame.css("left", zPosX);
//                            zIFrame.css("top", zPosY + 20);
//                            zIFrame.fadeIn();
//                        }
//                    } else {
//                        if (!viewChart.isDrillDownShown) {
//                            zIFrame.css("left", zPosX);
//                            zIFrame.css("top", zPosY + 20);
//                            zIFrame.fadeIn();
//                        }
//                    }
//                    viewChart.isDrillDownShown = true;
//                }
//            }
//        },


//        onSeriesClick: function (pEvent) {
//            if (ServerSide_IsDrillDownMode != "true") {
//                /* DO SOMETHING */
//                var zDrillDownType = pEvent.dataItem.__proto__.fldMetaChartDrillDownTypeId;
//                var zDrillDownId = pEvent.dataItem.__proto__.fldMetaChartDrillDownId;
//                switch (zDrillDownType.toString()) {
//                    case "1":
//                        /* CHART */
//                        document.location.href = SITEBASEURL + "Home_{{VER}}/Charts/Default.aspx?sid=" + getGSafeGUID() + "&chartId=" + zDrillDownId + "&PrimaryRecTypeFromDrillDown=" + pEvent.dataItem.__proto__.fldTitle;
//                        break;
//                    case "2":
//                        /* REPORT */
//                        break;
//                    case "3":
//                        /* GRID */
//                        //document.location.href = SITEBASEURL + "Home_{{VER}}/Filter/Default.aspx?sid=" + getGSafeGUID() + "&gridId=" + zDrillDownId;
//                        document.location.href = SITEBASEURL + "Home_{{VER}}/ProgramStatus/PSDirect.ashx?sid=" + getGSafeGUID() + "&directId=" + zDrillDownId + "&chartId=" + viewChart.chartId + "&directMode=chart";
//                        break;
//                    case "4":
//                        /* FORM */
//                        break;
//                    default:
//                        break;
//                }
//            }

//            /* WILL NEED TO KNOW IF IT IS POSSIBLE TO DRILLDOWN FROM GDC */
//        },


//        setupChartGrid: function () {
//            try {
//                viewChart.chartGridData([]);
//                var zCount = 0;
//                if (dsChartData.series !== undefined && dsChartData.series !== null && dsChartData.series.length > 0) {
//                    for (var x = 0; x < dsChartData.series.length; x++) {
//                        if (dsChartData.series[x].data !== undefined && dsChartData.series[x].data !== null && dsChartData.series[x].data.length > 0) {
//                            for (var y = 0; y < dsChartData.series[x].data.length; y++) {
//                                viewChart.chartGridData.push({
//                                    title: dsChartData.series[x].data[y].fldTitle,
//                                    value: dsChartData.series[x].data[y].fldValue
//                                });
//                                zCount += dsChartData.series[x].data[y].fldValue;
//                            }
//                        }
//                    }
//                    if (viewChart.chartGridData().length > 0) {
//                        viewChart.chartGridData.push({
//                            title: "Total",
//                            value: zCount
//                        });
//                    }
//                }
//            } catch (pException) {
//                viewChart.txtMessage("An error occurred while building the chart bottom grid: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//            viewChart.processLoading();
//        },


//        setupKendo: function () {
//            viewChart.setupKendoChart();
//        },


//        setupKendoChart: function () {
//            try {
//                var zTransitions = true;
//                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") { zTransitions = false; }
//                viewChart.chartRec = null;
//                if (viewChart.chartRec == null) {
//                    $("#chartRec").kendoChart({
//                        transitions: zTransitions,
//                        renderAs: "svg",
//                        title: {
//                            text: dsChartData.fldTitleChart,
//                            color: "#000000"
//                        },
//                        chartArea: {
//                            height: 450,
//                            width: 900
//                        },
//                        legend: {
//                            visible: false,
//                            position: "top"
//                        },
//                        categoryAxis: {
//                            labels: {
//                                rotation: 335
//                            },
//                            majorGridLines: {
//                                visible: false
//                            }
//                        },
//                        valueAxis: {
//                            labels: {
//                                visible: true
//                            },
//                            line: {
//                                visible: true
//                            },
//                            majorGridLines: {
//                                color: "#CCCCCC"
//                            },
//                            title: {
//                                text: dsChartData.fldTitleValueAxis,
//                            }
//                        },
//                        seriesDefaults: {
//                            gap: 0.7,
//                            labels: {
//                                visible: true,
//                                rotation: 0
//                            }
//                        },
//                        series: dsChartData.series,
//                        tooltip: {
//                            visible: true,
//                            /*background: "#c6d1de",*/
//                            color: "#000000",
//                            template: "#: category #: #: value #"
//                        },
//                        seriesHover: viewChart.onSeriesHover,
//                        seriesClick: viewChart.onSeriesClick
//                    });
//                    viewChart.chartRec = $("#chartRec").data("kendoChart");
//                }
//            } catch (pException) {
//                viewChart.txtMessage("An error occurred while building the chart: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//            viewChart.processLoading();
//        },


//        setupEvents: function () {
//            if (ServerSide_IsDrillDownMode != "true") {
//                /* KEEP TRACK OF MOUSE POSITION */
//                $(document).mousemove(function (pEvent) {
//                    viewChart.mouseX = pEvent.pageX;
//                    viewChart.mouseY = pEvent.pageY;
//                });
//            } else {
//                /* REMOVE ELEMENTS */
//                $("#frameChartDrillDown").remove();
//                /*$("#divDrillDownContainer").remove();*/
//                $("#"+gDivDrillDownContainerId).remove()
//            }

//            /* CLOSE DRILLDOWN IF NEEDED OR HIDE POPUP IF IN BATCH MODE */
//            if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
//                /* DO NOTHING */
//            } else {
//                $(document).mouseup(function (pEvent) {
//                    var zDrillDownContainer = $("#" + gDivDrillDownContainerId); /*$("#divDrillDownContainer");*/
//                    /* if the target of the click isn't the container... ... nor a descendant of the container */
//                    if ((!zDrillDownContainer.is(pEvent.target) && zDrillDownContainer.has(pEvent.target).length === 0)) {
//                        zDrillDownContainer.fadeOut();
//                        viewChart.isDrillDownShown = false;
//                    }
//                });
//            }
//            viewChart.processLoading();
//        },


//        bindForm: function () {
//            ko.applyBindings(viewChart, $("#viewChart")[0]);
//        },


//        showLoading: function () {
//            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
//        },


//        hideLoading: function () {
//            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
//        },


//        processLoading: function () {
//            viewChart.countLoading--;
//            if (viewChart.countLoading < 1) {
//                viewChart.hideLoading();
//                if (ServerSide_ErrorMessage !== undefined && ServerSide_ErrorMessage.length > 0) {
//                    viewChart.txtMessage(viewChart.txtMessage() + " | " + ServerSide_ErrorMessage);
//                    global.messageShow("txtMessage", "messageChartError");
//                }
//            } else {
//            }
//        }
//    };


//    /* BIND AND INIT FORM */
//    viewChart.bindForm();
//    viewChart.init();
//});
