$(document).ready(function () {
    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsAutoRec = null;
    dsFireStatus = [];
    dsBoilerStatus = [];
    dsInfraredStatus = [];
    dsSeismicStatus = [];
    dsWindStatus = [];
    dsFloodStatus = [];
    dsNatHazStatus = [];
    dsPS = [];


    // LOAD SESSION VARIABLES
    var dsLanguageLabels = {
    };


    // VIEWMODELS
    var viewAutoRecStatus = {
        // DECLARATIONS
        index: 0,
        enableButtons: ko.observable(true),
        messageError: ko.observable(""),
        messageWarning: ko.observable(""),
        messageNotice: ko.observable(""),
        isDataLoaded: false,
        isCancelled: false,

        // COLLECTIONS / OBJECTS
        gSafeGuid: getGSafeGUID(),
        clientFeatures: ko.observable(),
        objAutoRecStatus: ko.observable(),
        chartFireStatus: null,
        chartBoilerStatus: null,
        chartInfraredStatus: null,
        chartNatHazStatus: null,
        chartWindStatus: null,
        chartFloodStatus: null,
        chartPS: null,

        // MISC
        loading: ko.observable(false),
        windowPleaseWait: null,


        init: function () {
            viewAutoRecStatus.countLoading = 5;
            viewAutoRecStatus.setupKendoWindow();
            viewAutoRecStatus.setupEvents();
            setTimeout(function () {
                viewAutoRecStatus.loadDictionary();
                viewAutoRecStatus.loadData();
            }, 1000);
        },


        loadData: function () {
            viewAutoRecStatus.loadAutoRecStatusData();
        },


        loadDictionary: function () {
            viewAutoRecStatus.processLoading();
        },


        // LOADING DATA
        loadAutoRecStatusData: function () {
            try {
                viewAutoRecStatus.messageError("Loading...");
                global.messageShow("messageError", "messageNotice");
                var zServiceName = "GetAutoRecStatusData";
                var zParms = ko.toJSON({
                    "gSafeGuid": viewAutoRecStatus.gSafeGuid
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewAutoRecStatus.loadAutoRecStatusDataSuccess, viewAutoRecStatus.loadAutoRecStatusDataError, null);
            } catch (pException) {
                viewAutoRecStatus.messageError("An error occurred while starting the Auto Rec. status data load call: " + pException.message);
                global.messageShow("messageError", "messageError");
            }
        },
        loadAutoRecStatusDataSuccess: function (pResults, pParms) {
            if (viewAutoRecStatus.isCancelled) {
                viewAutoRecStatus.onClickExit();
            } else {
                try {
                    viewAutoRecStatus.messageError("");
                    if (pResults.isSuccess) {
                        // STORE THE AUTO REC STATUS DATA
                        viewAutoRecStatus.isDataLoaded = true;
                        viewAutoRecStatus.objAutoRecStatus(pResults.data);
                        // BUILD STATUS CHARTS
                        for (var x = 0; x < viewAutoRecStatus.objAutoRecStatus().length; x++) {
                            if (viewAutoRecStatus.objAutoRecStatus()[x].MetricName == "Chart") {
                                if (viewAutoRecStatus.objAutoRecStatus()[x].MetricValue > 0) {
                                    switch (viewAutoRecStatus.objAutoRecStatus()[x].TopName) {
                                        case "Fire":
                                            dsFireStatus.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                            break;
                                        case "Boiler":
                                            dsBoilerStatus.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                            break;
                                        case "Infrared":
                                            dsInfraredStatus.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                            break;
                                        case "NatHaz":
                                            dsNatHazStatus.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                            break;
                                        case "Safety":
                                            dsPS.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                            break;
                                        //case "Wind":
                                        //    dsWindStatus.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                        //    break;
                                        //case "Flood":
                                        //    dsFloodStatus.push(viewAutoRecStatus.buildChartData(viewAutoRecStatus.objAutoRecStatus()[x]));
                                        //    break;
                                    }
                                }
                            }
                        }
                        // HIDE THE NO REQUESTS MESSAGES AND CORRECT THE VALUES OF THE CHARTS TO PERCENTS
                        if (dsFireStatus.length > 0) { $("#divNoRequestsFire").hide(); viewAutoRecStatus.buildChartValues(dsFireStatus); }
                        if (dsBoilerStatus.length > 0) { $("#divNoRequestsBoiler").hide(); viewAutoRecStatus.buildChartValues(dsBoilerStatus); }
                        if (dsInfraredStatus.length > 0) { $("#divNoRequestsInfrared").hide(); viewAutoRecStatus.buildChartValues(dsInfraredStatus); }
                        if (dsNatHazStatus.length > 0) { $("#divNoRequestsNatHaz").hide(); viewAutoRecStatus.buildChartValues(dsNatHazStatus); }
                        if (dsPS.length > 0) { $("#divNoRequestsPS").hide(); viewAutoRecStatus.buildChartValues(dsPS); }
                        //if (dsWindStatus.length > 0) { $("#divNoRequestsWind").hide(); viewAutoRecStatus.buildChartValues(dsWindStatus); }
                        //if (dsFloodStatus.length > 0) { $("#divNoRequestsFlood").hide(); viewAutoRecStatus.buildChartValues(dsFloodStatus); }

                    } else {
                        viewAutoRecStatus.messageError("An error occurred while loading auto rec. status data: " + pResults.message);
                        global.messageShow("messageError", "messageError");
                    }
                } catch (pException) {
                    viewAutoRecStatus.messageError("An error occurred while loading auto rec. status data: " + pException.message);
                    global.messageShow("messageError", "messageError");
                }
                viewAutoRecStatus.windowPleaseWait.close();
            }
            viewAutoRecStatus.setupKendoChart();
            viewAutoRecStatus.processLoading();
        },
        loadAutoRecStatusDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewAutoRecStatus.messageError("Error while loading auto rec. status data. " + pMessage);
            global.messageShow("messageError", "messageError");
            viewAutoRecStatus.processLoading();
        },
        buildChartData: function (pObject) {
            var zReturn = {
                category: pObject.MetricLabel + " " + pObject.MetricValue,
                value: pObject.MetricValue,
                color: pObject.MetricColor,
                Id: pObject.Id,
                SectionName: pObject.SectionName,
                TopName: pObject.TopName,
                MetricName: pObject.MetricName,
                SubMetricName: pObject.SubMetricName,
                MetricValue: pObject.MetricValue,
                MetricLabel: pObject.MetricLabel,
                MetricVisible: pObject.MetricVisible,
                MetricColor: pObject.MetricColor,
                DirectId: pObject.DirectId
            };
            return zReturn
        },
        buildChartValues: function (pArray) {
            if (pArray) {
                // ADD THE TOTAL
                var zTotal = 0;
                for (var y = 0; y < pArray.length; y++) {
                    if (pArray[y].value) { zTotal += pArray[y].value; }
                }
                // DIVIDE BY TOTAL TO GET PERCENT
                for (var y = 0; y < pArray.length; y++) {
                    if (pArray[y].value) {
                        pArray[y].value = (pArray[y].value / zTotal) * 100;
                    }
                }
            }
        },


        onClickPrint: function () {
            var zHTML = "";
            var zCSS = "";

            // GET ALL THE CSS FILES
            $.get("../../../css/Kendo.v2014.1.318/kendo.common.min.css", function (pResults) {
                zCSS = zCSS + pResults;
                $.get("../../../css/kendo-lightblue-noedit.css", function (pResults) {
                    zCSS = zCSS + pResults;
                    $.get("../../../css/pages/global.css", function (pResults) {
                        zCSS = zCSS + pResults;
                        $.get("../../../css/pages/topbanner.css", function (pResults) {
                            zCSS = zCSS + pResults;
                            //$.get("../../../css/pages/nav.css", function (pResults) {
                            //    zCSS = zCSS + pResults;
                                $.get("../../../css/pages/windows.css", function (pResults) {
                                    zCSS = zCSS + pResults;
                                    $.get("../../../css/pages/autorecstatus.css", function (pResults) {
                                        zCSS = zCSS + pResults;
                                        $.get("../../../css/pages/print.css", function (pResults) {
                                            if (viewAutoRecStatus.printHTML == null) {
                                                // REMOVE ANY NO PRINT DOMS
                                                var zDocument = $("html").clone();
                                                zDocument.find(".printNone").each(function () {
                                                    $(this).remove();
                                                });
                                                zHTML = $(zDocument).html();
                                            } else {
                                                zHTML = viewAutoRecStatus.printHTML;
                                            }

                                            zHTML = zHTML.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
                                            zHTML = zHTML.replace(/(\r\t|\t|\r)/gm, " "); // REMOVE ALL TABS
                                            zHTML = zHTML.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
                                            zHTML = zHTML.replace(/(<)/gm, "||OPEN||"); // REPLACE ALL OPEN BRACKETS
                                            zHTML = zHTML.replace(/(>)/gm, "||CLOSE||"); // REPLACE ALL CLOSING BRACKETS
                                            zCSS = zCSS + pResults;
                                            zCSS = zCSS.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
                                            zCSS = zCSS.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
                                            //zCSS = zCSS.replace(/1px/gm, "2px"); // REPLACE ALL 1PX LINES TO THICKER

                                            // CALL HANDLER PAGE BY CREATING A FORM
                                            // CREATE A FORM DOM ELEMENT
                                            var zForm = document.createElement("form");
                                            zForm.setAttribute("id", "frmPDF");
                                            zForm.setAttribute("method", "post");
                                            //zForm.setAttribute("target", "_blank");
                                            zForm.setAttribute("action", "../../FD/ServeHTMLToPDF.ashx?sid=" + getGSafeGUID() + "&reportId=" + getQueryVariable("reportId"));
                                            document.body.appendChild(zForm);

                                            // CREATE HIDDEN INPUT DOM ELEMENTS
                                            var zField1 = document.createElement("input");
                                            zField1.setAttribute("type", "hidden");
                                            zField1.setAttribute("id", "pHTML");
                                            zField1.setAttribute("name", "pHTML");
                                            zField1.setAttribute("value", zHTML);
                                            zForm.appendChild(zField1);
                                            var zField2 = document.createElement("input");
                                            zField2.setAttribute("type", "hidden");
                                            zField2.setAttribute("id", "pCSS");
                                            zField2.setAttribute("name", "pCSS");
                                            zField2.setAttribute("value", zCSS);
                                            zForm.appendChild(zField2);
                                            var zField3 = document.createElement("input");
                                            zField3.setAttribute("type", "hidden");
                                            zField3.setAttribute("id", "pZoomFactor");
                                            zField3.setAttribute("name", "pZoomFactor");
                                            zField3.setAttribute("value", "1.3");
                                            zForm.appendChild(zField3);
                                            var zField4 = document.createElement("input");
                                            zField4.setAttribute("type", "hidden");
                                            zField4.setAttribute("id", "pOrientation");
                                            zField4.setAttribute("name", "pOrientation");
                                            zField4.setAttribute("value", "Landscape");
                                            zForm.appendChild(zField4);

                                            // SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN
                                            zForm.submit();
                                            zForm.removeChild(zField1);
                                            zForm.removeChild(zField2);
                                            zForm.removeChild(zField3);
                                            zForm.removeChild(zField4);
                                            document.body.removeChild(zForm);
                                        });
                                    });
                                });
                            //});
                        });
                    });
                });
            });
        },


        onClickExit: function () {
            window.close();
            return false;
        },


        onCancelAutoRecLoad: function () {
            $("#windowPleaseWaitProcessed").hide(1, function () {
                $("#windowPleaseWaitCancelled").show();              
            });
            viewAutoRecStatus.isCancelled = true;
            window.close();
            // CANNOT NAVIGATE AWAY HERE BECAUSE THE PAGE IS ALREADY WAITING FOR A REQUEST
        },


        buildData: function (pElement, pType, pSectionName, pMetricName, pTopName, pSubMetricName, pDefault) {
            // TYPES
            return ko.computed(function () {
                var zReturn = "0";
                var zDefault = "0";
                var zErrorValue = "Err";
                var zObjectName = "MetricValue"
                var zFound = false;

                // TEST
                //if (pDefault == "No. of Recs. with LE`s > 1bil") { debugger; }

                try {
                    // BUILD DEFAULTS //data, dataperc, url, color, label, visible
                    switch (pType.toLowerCase()) {
                        case "data":
                        case "dataperc":
                            zDefault = "0";
                            zReturn = "0";
                            zErrorValue = "Err";
                            zObjectName = "MetricValue";
                            break;
                        case "url":
                            zDefault = "#";
                            zReturn = "#";
                            zErrorValue = "#";
                            zObjectName = "MetricLink";
                            break;
                        case "color":
                            zDefault = "#FFFFFF";
                            zReturn = "#FFFFFF";
                            zErrorValue = "#000000";
                            zObjectName = "MetricColor";
                            break;
                        case "label":
                            zDefault = "";
                            zReturn = "";
                            zErrorValue = "Error";
                            zObjectName = "MetricLabel";
                            break;
                        case "visible":
                            zDefault = false;
                            zReturn = false;
                            zErrorValue = false;
                            zObjectName = "MetricVisible";
                            break;
                    }
                    if (pDefault !== undefined && pDefault !== null) {
                        zReturn = pDefault;
                        zDefault = pDefault;
                    }

                    // LOOP THROUGH DATA TO GET THE VALUE
                    if (viewAutoRecStatus.objAutoRecStatus()) {
                        for (var x = 0; x < viewAutoRecStatus.objAutoRecStatus().length; x++) {
                            if (viewAutoRecStatus.objAutoRecStatus()[x].SectionName == pSectionName) {
                                if (viewAutoRecStatus.objAutoRecStatus()[x].MetricName == pMetricName) {
                                    if (viewAutoRecStatus.objAutoRecStatus()[x].TopName == pTopName) {
                                        if (pSubMetricName) {
                                            if (viewAutoRecStatus.objAutoRecStatus()[x].SubMetricName == pSubMetricName) {
                                                zReturn = viewAutoRecStatus.objAutoRecStatus()[x][zObjectName];
                                                zFound = true;
                                                break;
                                            }
                                        } else {
                                            zReturn = viewAutoRecStatus.objAutoRecStatus()[x][zObjectName];
                                            zFound = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // REVERT TO DEFAULT IF NULL
                    if ((zReturn === undefined || zReturn === null || zReturn == "") &&
                        (zDefault !== undefined && zDefault !== null)) {
                        zReturn = zDefault;
                    }

                    // IF ZERO COUNT VALUE THEN REMOVE UNDERLINE
                    if (pElement) {
                        if (!$("#" + pElement).hasClass("autoRecNoLink")) {
                            if (zReturn == zDefault) {
                                $("#" + pElement).removeClass("autoRecLink");
                                $("#" + pElement).addClass("autoRecNoUnderline");
                            } else {
                                $("#" + pElement).removeClass("autoRecNoUnderline");
                                $("#" + pElement).addClass("autoRecLink");
                            }
                        }
                    }

                    // ADD EXTRA INFO WHERE NEEDED BY TYPE
                    switch (pType.toLowerCase()) {
                        case "dataperc":
                            zReturn = zReturn + "%";
                            break;
                        case "data":
                        case "url":
                        case "color":
                        case "label":
                        case "visible":
                            break;
                    }
                } catch (pException) {
                    viewAutoRecStatus.messageError("An error occurred while building " + pType + " data: " + pException.message);
                    global.messageShow("messageError", "messageError");
                    zReturn = zErrorValue;
                }
                return zReturn;
            }, viewAutoRecStatus);
        },


        buildDataLocal: function (pElement, pType, pSectionName, pMetricName, pTopName, pSubMetricName, pDefault) {
            // TYPES
            var zReturn = "0";
            var zDefault = "0";
            var zErrorValue = "Err";
            var zObjectName = "MetricValue"
            var zFound = false;

            try {
                // BUILD DEFAULTS //data, dataperc, url, color, label, visible
                switch (pType.toLowerCase()) {
                    case "data":
                    case "dataperc":
                        zDefault = "0";
                        zReturn = "0";
                        zErrorValue = "Err";
                        zObjectName = "MetricValue";
                        break;
                    case "url":
                        zDefault = "#";
                        zReturn = "#";
                        zErrorValue = "#";
                        zObjectName = "MetricLink";
                        break;
                    case "color":
                        zDefault = "#FFFFFF";
                        zReturn = "#FFFFFF";
                        zErrorValue = "#000000";
                        zObjectName = "MetricColor";
                        break;
                    case "label":
                        zDefault = "";
                        zReturn = "";
                        zErrorValue = "Error";
                        zObjectName = "MetricLabel";
                        break;
                    case "visible":
                        zDefault = false;
                        zReturn = false;
                        zErrorValue = false;
                        zObjectName = "MetricVisible";
                        break;
                }
                if (pDefault !== undefined && pDefault !== null) {
                    zReturn = pDefault;
                    zDefault = pDefault;
                }

                // LOOP THROUGH DATA TO GET THE VALUE
                if (viewAutoRecStatus.objAutoRecStatus()) {
                    for (var x = 0; x < viewAutoRecStatus.objAutoRecStatus().length; x++) {
                        if (viewAutoRecStatus.objAutoRecStatus()[x].SectionName == pSectionName) {
                            if (viewAutoRecStatus.objAutoRecStatus()[x].MetricName == pMetricName) {
                                if (viewAutoRecStatus.objAutoRecStatus()[x].TopName == pTopName) {
                                    if (pSubMetricName) {
                                        if (viewAutoRecStatus.objAutoRecStatus()[x].SubMetricName == pSubMetricName) {
                                            zReturn = viewAutoRecStatus.objAutoRecStatus()[x][zObjectName];
                                            zFound = true;
                                            break;
                                        }
                                    } else {
                                        zReturn = viewAutoRecStatus.objAutoRecStatus()[x][zObjectName];
                                        zFound = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                // REVERT TO DEFAULT IF NULL
                if ((zReturn === undefined || zReturn === null || zReturn == "") &&
                    (zDefault !== undefined && zDefault !== null)) {
                    zReturn = zDefault;
                }

                // IF ZERO COUNT VALUE THEN REMOVE UNDERLINE
                if (pElement) {
                    if (!$("#" + pElement).hasClass("autoRecNoLink")) {
                        if (zReturn == zDefault) {
                            $("#" + pElement).removeClass("autoRecLink");
                            $("#" + pElement).addClass("autoRecNoUnderline");
                        } else {
                            $("#" + pElement).removeClass("autoRecNoUnderline");
                            $("#" + pElement).addClass("autoRecLink");
                        }
                    }
                }

                // ADD EXTRA INFO WHERE NEEDED BY TYPE
                switch (pType.toLowerCase()) {
                    case "dataperc":
                        zReturn = zReturn + "%";
                        break;
                    case "data":
                    case "url":
                    case "color":
                    case "label":
                    case "visible":
                        break;
                }
            } catch (pException) {
                viewAutoRecStatus.messageError("An error occurred while building " + pType + " data: " + pException.message);
                global.messageShow("messageError", "messageError");
                zReturn = zErrorValue;
            }
            return zReturn;
        },


        buildLink: function (pSectionName, pMetricName, pTopName, pSubMetricName) {
            var zDirectId = "0";
            var zValue = 0;
            var zObjectName = "DirectId"
            var zURL = "";
            var zFound = false;
            try {
                // LOOP THROUGH DATA TO GET THE VALUE
                if (viewAutoRecStatus.objAutoRecStatus()) {
                    for (var x = 0; x < viewAutoRecStatus.objAutoRecStatus().length; x++) {
                        if (viewAutoRecStatus.objAutoRecStatus()[x].SectionName == pSectionName) {
                            if (viewAutoRecStatus.objAutoRecStatus()[x].MetricName == pMetricName) {
                                if (viewAutoRecStatus.objAutoRecStatus()[x].TopName == pTopName) {
                                    if (pSubMetricName) {
                                        if (viewAutoRecStatus.objAutoRecStatus()[x].SubMetricName == pSubMetricName) {
                                            zDirectId = viewAutoRecStatus.objAutoRecStatus()[x][zObjectName];
                                            if (viewAutoRecStatus.objAutoRecStatus()[x].MetricValue) {
                                                zValue = viewAutoRecStatus.objAutoRecStatus()[x].MetricValue;
                                            }
                                            zFound = true;
                                            break;
                                        }
                                    } else {
                                        zDirectId = viewAutoRecStatus.objAutoRecStatus()[x][zObjectName];
                                        if (viewAutoRecStatus.objAutoRecStatus()[x].MetricValue) {
                                            zValue = viewAutoRecStatus.objAutoRecStatus()[x].MetricValue;
                                        }
                                        zFound = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                // NAVIGATE TO THE DIRECT PAGE
                if (zFound && zValue > 0) {
                    viewAutoRecStatus.messageError("");
                    zURL = "../../ProgramStatus/PSDirect.ashx?sid=" + viewAutoRecStatus.gSafeGuid + "&directId=" + zDirectId + "&directMode=autorecstatus";
                    openRequestedSinglePopup(zURL);
                } else {
                    viewAutoRecStatus.messageError("No data for this criteria.");
                    global.messageShow("messageError", "messageError");
                }
            } catch (pException) {
                viewAutoRecStatus.messageError("An error occurred while navigating to grid/report: " + pException.message);
                global.messageShow("messageError", "messageError");
            }
        },


        onSeriesClick: function (pEvent) {
            try {
                var zDirectId = pEvent.dataItem.DirectId;
                zURL = "../../ProgramStatus/PSDirect.ashx?sid=" + viewAutoRecStatus.gSafeGuid + "&directId=" + zDirectId + "&directMode=autorecstatus";
                openRequestedSinglePopup(zURL);
            } catch (pException) {
                viewAutoRecStatus.messageError("An error occurred while navigating to grid/report: " + pException.message);
                global.messageShow("messageError", "messageError");
            }
        },


        // SETUP EVENTS AND WIDGETS
        setupKendo: function () {

        },


        setupKendoChart: function () {
            try {
                // FIRE
                if (viewAutoRecStatus.chartFireStatus == null && dsFireStatus.length > 0) {
                    $("#chartFireStatus").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsFireStatus
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartFireStatus = $("#chartFireStatus").data("kendoChart");
                }
                // BOILER
                if (viewAutoRecStatus.chartBoilerStatus == null && dsBoilerStatus.length > 0) {
                    $("#chartBoilerStatus").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsBoilerStatus
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartBoilerStatus = $("#chartBoilerStatus").data("kendoChart");
                }
                // INFRARED
                if (viewAutoRecStatus.chartInfraredStatus == null && dsInfraredStatus.length > 0) {
                    $("#chartInfraredStatus").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsInfraredStatus
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartInfraredStatus = $("#chartInfraredStatus").data("kendoChart");
                }
                // SEISMIC
                if (viewAutoRecStatus.chartNatHazStatus == null && dsNatHazStatus.length > 0) {
                    $("#chartNatHazStatus").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsNatHazStatus
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartNatHazStatus = $("#chartNatHazStatus").data("kendoChart");
                }
                // WIND
                if (viewAutoRecStatus.chartWindStatus == null && dsWindStatus.length > 0) {
                    $("#chartWindStatus").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsWindStatus
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartWindStatus = $("#chartWindStatus").data("kendoChart");
                }
                // FLOOD
                if (viewAutoRecStatus.chartFloodStatus == null && dsFloodStatus.length > 0) {
                    $("#chartFloodStatus").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsFloodStatus
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartFloodStatus = $("#chartFloodStatus").data("kendoChart");
                }
                // PROCESS SAFETY
                if (viewAutoRecStatus.chartPS == null && dsPS.length > 0) {
                    $("#chartPS").kendoChart({
                        transitions: true,
                        renderAs: "svg",
                        chartArea: dsChartArea,
                        legend: dsLegend,
                        seriesDefaults: dsSeriesDefaults,
                        series: [{
                            type: "pie",
                            startAngle: dsStartingAngle,
                            data: dsPS
                        }],
                        tooltip: dsToolTip,
                        seriesClick: viewAutoRecStatus.onSeriesClick
                    });
                    viewAutoRecStatus.chartPS = $("#chartPS").data("kendoChart");
                }
            } catch (pException) {
                viewAutoRecStatus.messageError("Error while building charts. " + pException.message);
                global.messageShow("messageError", "messageError");
            }
            viewAutoRecStatus.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (viewAutoRecStatus.windowPleaseWait == null) {
                    $("#windowPleaseWait").kendoWindow({
                        visible: true,
                        modal: true,
                        draggable: true,
                        resizable: false,
                        width: "300px",
                        height: "220px",
                        title: "", // title added below with JQuery
                        actions: [],
                        animation: { open: { effects: "default" }, close: { effects: "default" } },
                        refresh: function () { this.center(); }
                    });
                    $("#windowPleaseWait").prev().find(".k-window-title").append("<img src='../../images/icons/wait/icon_hourglass_32x32.png' align='left' alt='Please Wait' class='windowIcon'/>  " + "Please Wait");
                    viewAutoRecStatus.windowPleaseWait = $("#windowPleaseWait").data("kendoWindow");
                    viewAutoRecStatus.windowPleaseWait.center().open();
                }
            } catch (pException) {
                viewAutoRecStatus.messageError("Error while building window messages. " + pException.message);
                global.messageShow("messageError", "messageError");
            }
            viewAutoRecStatus.processLoading();
        },


        setupEvents: function () {
            viewAutoRecStatus.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewAutoRecStatus, $("#viewAutoRecStatus")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },


        processLoading: function () {
            viewAutoRecStatus.countLoading--;
            if (viewAutoRecStatus.countLoading < 1) {
                viewAutoRecStatus.hideLoading();
            } else {
            }
        }

    };


    // SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
    //viewAutoRecStatus.loadDetails();

    // ACTIVATE BINDINGS LAST
    // WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
    viewAutoRecStatus.bindForm();
    viewAutoRecStatus.init();
});


function onBuildPopupLink(pURL) {
    if (pURL.length > 0) {
        openRequestedSinglePopup(pURL);
    }
    return false;
}
