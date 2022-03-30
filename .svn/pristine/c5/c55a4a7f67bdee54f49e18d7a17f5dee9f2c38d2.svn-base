$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsChartActiveData = null;
    dsChartPassiveData = null;
    dsChartTotalData = null;

    // VIEW
    view = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA

        // LABELS
        txtMessage: ko.observable(),
        txtMessageCurrentPage: ko.observable("Page: 1/53"),
        chartPageNumbers: ko.observableArray([1,2,3,4,5,6,7,8,9,10]),

        // BUTTON AND VISIBILITY CONTROLS
        isDrillDownShown: false,

        // KENDO OBJECTS
        chartLine0101: null,
        chartLine0102: null,
        chartLine0103: null,
        chartLine0201: null,
        chartLine0202: null,
        chartLine0203: null,
        chartLine0301: null,
        chartLine0302: null,
        chartLine0303: null,
        chartLine0401: null,
        chartLine0402: null,
        chartLine0403: null,
        chartLine0501: null,
        chartLine0502: null,
        chartLine0503: null,
        chartLine0601: null,
        chartLine0602: null,
        chartLine0603: null,
        chartLine0701: null,
        chartLine0702: null,
        chartLine0703: null,
        chartLine0801: null,
        chartLine0802: null,
        chartLine0803: null,
        chartLine0901: null,
        chartLine0902: null,
        chartLine0903: null,
        chartLine1001: null,
        chartLine1002: null,
        chartLine1003: null,
        windowPleaseWait: null,


        // FUNCTIONS
        init: function () {
            view.countLoading = 5;
            view.loadDictionary();
            view.loadData();
            view.setupKendo();
            view.setupEvents();
        },


        loadDictionary: function () {
            view.processLoading();
        },


        loadData: function () {
            dsMetaData = null;
            dsChartActiveData = dsSampleChartActiveMeta;
            dsChartPassiveData = dsSampleChartPassiveMeta;
            dsChartTotalData = dsSampleChartTotalMeta;
        },


        downloadPDF: function () {
                // SINGLE PAGE
                var zHTML = view.getHTML();
                var zCSS = view.getCSS();

                // CALL HANDLER PAGE BY CREATING A FORM
                // CREATE A FORM DOM ELEMENT
                var zForm = document.createElement("form");
                zForm.setAttribute("id", "frmPDF");
                zForm.setAttribute("method", "post");
                //zForm.setAttribute("target", "_blank");
                zForm.setAttribute("action", "../../FD/ServeHTMLToPDF.ashx");
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
                zField3.setAttribute("value", "1.0");
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
        },
        getHTML: function () {
            var zHTML = "";
            if (view.printHTML == null) {
                // REMOVE ANY NO PRINT DOMS
                var zDocument = $("html").clone();
                zDocument.find(".printNone").each(function () {
                    $(this).remove();
                });
                zHTML = $(zDocument).html();
            } else {
                zHTML = view.printHTML;
            }

            zHTML = zHTML.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
            zHTML = zHTML.replace(/(\r\t|\t|\r)/gm, " "); // REMOVE ALL TABS
            zHTML = zHTML.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
            zHTML = zHTML.replace(/(<)/gm, "||OPEN||"); // REPLACE ALL OPEN BRACKETS
            zHTML = zHTML.replace(/(>)/gm, "||CLOSE||"); // REPLACE ALL CLOSING BRACKETS
            return zHTML;
        },
        getCSS: function () {
            //$.get("../Styles/Kendo/kendo.common.min.css", function (pResults) {
            // CREATE THE HTML AND CSS DATA VARIABLES
            var zCSS = "";
            zCSS = ""//pResults;
            zCSS = zCSS.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
            zCSS = zCSS.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
            //zCSS = zCSS.replace(/1px/gm, "2px"); // REPLACE ALL 1PX LINES TO THICKER
            return zCSS;
            //});
        },


        onCancelMultiPrint: function () {
            $("#windowPleaseWaitProcessed").hide(1, function () {
                $("#windowPleaseWaitCancelled").show();
            });
        },


        onSeriesHover: function (pEvent) {
        },


        onSeriesClick: function (pEvent) {
            try {
                var zValue = "unknown";
                if (pEvent.dataItem.ActiveScore !== undefined) {
                    zValue = pEvent.dataItem.ActiveScore;
                }
                alert("You clicked series data with value " + zValue);
            } catch (pException) {
                view.txtMessage("An error occurred while getting chart drilldown data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },


        setupKendo: function () {
            view.setupKendoWindow();
            view.setupKendoChart();
        },


        setupKendoChart: function () {
            try {
                if (view.chartLine0101 == null) {
                    for (var x = 1; x < 11; x++) {
                        var zId = x.toString();
                        if (zId < 10) { zId = "0" + x; }
                        $("#chartLine" + zId + "01").kendoChart({
                            transitions: true,
                            renderAs: "svg",
                            legend: {
                                visible: false,
                                position: "bottom"
                            },
                            chartArea: dsChartArea,
                            categoryAxis: dsCategoryAxis,
                            valueAxis: {
                                min: dsChartActiveData.fldValueAxisMin,
                                max: dsChartActiveData.fldValueAxisMax,
                                labels: { visible: false },
                                line: { visible: false },
                                majorGridLines: { visible: false },
                                minorGridLines: { visible: false },
                                plotBands: dsChartActiveData.fldPlotBands,
                                title: {
                                    visible: false,
                                    text: dsChartActiveData.fldTitleValueAxis
                                },
                            },
                            seriesDefaults: dsSeriesDefaults,
                            series: dsChartActiveData.series,
                            tooltip: dsToolTip,
                            seriesHover: view.onSeriesHover,
                            seriesClick: view.onSeriesClick
                        });
                        view["chartLine" + zId + "01"] = $("#chartLine" + zId + "01").data("kendoChart");
                    }
                }

                view.chartLine0102 = null;
                if (view.chartLine0102 == null) {
                    for (var x = 1; x < 11; x++) {
                        var zId = x.toString();
                        if (zId < 10) { zId = "0" + x; }
                        $("#chartLine" + zId + "02").kendoChart({
                            transitions: true,
                            renderAs: "svg",
                            legend: {
                                visible: false,
                                position: "bottom"
                            },
                            chartArea: dsChartArea,
                            categoryAxis: dsCategoryAxis,
                            valueAxis: {
                                min: dsChartPassiveData.fldValueAxisMin,
                                max: dsChartPassiveData.fldValueAxisMax,
                                labels: { visible: false },
                                line: { visible: false },
                                majorGridLines: { visible: false },
                                minorGridLines: { visible: false },
                                plotBands: dsChartPassiveData.fldPlotBands,
                                title: {
                                    visible: false,
                                    text: dsChartPassiveData.fldTitleValueAxis
                                },
                            },
                            seriesDefaults: dsSeriesDefaults,
                            series: dsChartPassiveData.series,
                            tooltip: dsToolTip,
                            seriesHover: view.onSeriesHover,
                            seriesClick: view.onSeriesClick
                        });
                        view["chartLine" + zId + "02"] = $("#chartLine" + zId + "02").data("kendoChart");
                    }
                }
                view.chartLine0103 = null;
                if (view.chartLine0103 == null) {
                    for (var x = 1; x < 11; x++) {
                        var zId = x.toString();
                        if (zId < 10) { zId = "0" + x; }
                        $("#chartLine" + zId + "03").kendoChart({
                            transitions: true,
                            renderAs: "svg",
                            legend: {
                                visible: false,
                                position: "bottom"
                            },
                            chartArea: dsChartArea,
                            categoryAxis: dsCategoryAxis,
                            valueAxis: {
                                min: dsChartTotalData.fldValueAxisMin,
                                max: dsChartTotalData.fldValueAxisMax,
                                labels: { visible: false },
                                line: { visible: false },
                                majorGridLines: { visible: false },
                                minorGridLines: { visible: false },
                                plotBands: dsChartTotalData.fldPlotBands,
                                title: {
                                    visible: false,
                                    text: dsChartTotalData.fldTitleValueAxis
                                },
                            },
                            seriesDefaults: dsSeriesDefaults,
                            series: dsChartTotalData.series,
                            tooltip: dsToolTip,
                            seriesHover: view.onSeriesHover,
                            seriesClick: view.onSeriesClick
                        });
                        view["chartLine" + zId + "03"] = $("#chartLine" + zId + "03").data("kendoChart");
                    }
                }

            } catch (pException) {
                view.txtMessage("An error occurred while building the chart: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            view.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (view.windowPleaseWait == null) {
                    $("#windowPleaseWait").kendoWindow({
                        visible: false,
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
                    $("#windowPleaseWait").parent().addClass("printNone");
                    view.windowPleaseWait = $("#windowPleaseWait").data("kendoWindow");
                }
            } catch (pException) {
                view.txtMessage("Error while building window messages. " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            view.processLoading();
        },


        setupEvents: function () {
            view.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(view, $("#view")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },


        processLoading: function () {
            view.countLoading--;
            if (view.countLoading < 1) {
                view.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    view.bindForm();
    view.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    //globalLoadChart = function () {
    //    // DO NOTHING
    //}

});



