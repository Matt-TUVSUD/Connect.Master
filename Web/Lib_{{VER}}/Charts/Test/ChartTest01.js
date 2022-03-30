//$(document).ready(function () {

//    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
//    kendo.ui.progress($("#divContainerLoading"), false);

//    // GLOBAL DATA PLACEHOLDERS
//    dsMetaData = null;
//    dsChartData = null;
//    globalClientFeatures = getClientFeatures(getGSafeGUID());

//    // VIEW
//    viewChartTest = {
//        // DECLARATIONS
//        firstLoad: true,
//        countLoading: 0,

//        // PERMISSIONS

//        // DATA
//        chartId: null,
//        chartCriteriaFilter: null,
//        largeObjectHandler: null,

//        // LABELS
//        txtMessage: ko.observable(),

//        // BUTTON AND VISIBILITY CONTROLS

//        // KENDO OBJECTS
//        chartRec: null,


//        // FUNCTIONS
//        init: function () {
//            viewChartTest.countLoading = 4;
//            viewChartTest.loadChartFilterCriteria();
//            viewChartTest.loadDictionary();
//            viewChartTest.loadData();
//            viewChartTest.setupKendo();
//            viewChartTest.setupEvents();
//        },


//        loadDictionary: function () {
//            viewChartTest.processLoading();
//        },


//        loadChartFilterCriteria: function () {
//        },


//        loadData: function () {
//            //viewChartTest.loadChartMeta();
//        },


//        // LOAD THE CHART META DATA
//        loadChartMeta: function () {
//            try {
//                var zServiceName = "GetChartMeta";
//                var zParms = ko.toJSON({
//                    "gSafeGuid": getGSafeGUID()
//                });
//                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChartTest.loadChartMetaSuccess, viewChartTest.loadChartMetaError, null);
//            } catch (pException) {
//                viewChartTest.txtMessage("An error occurred while starting the chart meta data call: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//        },
//        loadChartMetaSuccess: function (pResults, pParms) {
//            try {
//                dsMetaData = pResults;
//                // MAKE ANY CORRECTIONS TO POSSIBLE FUNCTIONS
//                for (var x = 0; x < dsMetaData.columns.length; x++) {
//                    if (dsMetaData.columns[x].template !== undefined && dsMetaData.columns[x].template !== null && dsMetaData.columns[x].template.indexOf("function") == 0) {
//                        dsMetaData.columns[x].template = "var fn = " + dsMetaData.columns[x].template;
//                        var zFn = eval(dsMetaData.columns[x].template);
//                        dsMetaData.columns[x].template = fn;
//                    }
//                }
//            } catch (pException) {
//                viewChartTest.txtMessage("An error occurred while building chart meta data: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//            viewChartTest.processLoading();
//            viewChartTest.setupKendoChart();
//        },
//        loadChartMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
//            viewChartTest.txtMessage("Error while loading meta data. " + pMessage);
//            global.messageShow("txtMessage", "messageChartError");
//        },


//        setupKendo: function () {
//            // TEST DATA ONLY - DELETE ME
//            viewChartTest.chartTestMultiAxis = null;
//            if (viewChartTest.chartTestMultiAxis == null) {
//                $("#chartTestMultiAxis").kendoChart({
//                    transitions: false,
//                    title: {
//                        text: "Hybrid car mileage report"
//                    },
//                    legend: {
//                        position: "top"
//                    },
//                    series: dsMultiAxis,
//                    valueAxes: dsMultiAxisValues,
//                    categoryAxis: {
//                        categories: ["Mon", "Tue", "Wed", "Thu", "Fri"],
//                        axisCrossingValues: [0, 0, 10, 10]
//                    }
//                });
//                viewChartTest.chartTestMultiAxis = $("#chartTestMultiAxis").data("kendoChart");
//            }
//            // END TEST DATA ONLY - DELETE ME
//            viewChartTest.processLoading();
//        },


//        setupKendoChart: function () {
//            try {
//                if (viewChartTest.chartRec == null) {
//                    // BUILD CHART HERE
//                }
//            } catch (pException) {
//                viewChartTest.txtMessage("An error occurred while building the chart: " + pException.message);
//                global.messageShow("txtMessage", "messageChartError");
//            }
//            viewChartTest.processLoading();
//        },


//        setupEvents: function () {
//            viewChartTest.processLoading();
//        },


//        bindForm: function () {
//            ko.applyBindings(viewChartTest, $("#viewChartTest")[0]);
//        },


//        showLoading: function () {
//            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
//        },


//        hideLoading: function () {
//            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
//        },


//        processLoading: function () {
//            viewChartTest.countLoading--;
//            if (viewChartTest.countLoading < 1) {
//                viewChartTest.hideLoading();
//            } else {
//            }
//        }
//    };


//    // BIND AND INIT FORM
//    viewChartTest.bindForm();
//    viewChartTest.init();


//    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
//    //globalLoadChart = function () {
//    //    // DO NOTHING
//    //}

//});
