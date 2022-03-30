$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsChartData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());


    // CHART META DEFAULTS
    var dsChartArea = {
        height: 75,
        width: 300
    };
    var dsCategoryAxis = {
        line: {
            visible: false,
        },
        labels: {
            visible: false,
            template: "#= wrapChartLabels(value, 65)#",
        },
        majorGridLines: {
            visible: false,
            color: "#111111"
        }
    };
    var dsSeriesDefaults = {
        line: {
            opacity: 0.8
        },
        labels: {
            visible: true,
            format: "n1", // DOESN'T WORK WITH TEMPLATE
            template: "#: value #\n#: data.dataItem.fldYear # ",
            rotation: 0,
            font: "9px arial",
            background: "transparent",
            margin: {
                bottom: -35
            }
        }
    };
    var dsToolTip = {
        color: "#FFFFFF",
        visible: true,
        template: "#: data.dataItem.fldToolTip #"
    };


    // VIEW
    viewChart = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        largeObjectHandler: null,
        largeObjectFilter: null,
        largeObjectCriteria: null,
        largeObjectSetting: null,
        chartId: ServerSide_ChartId,
        chartTrendingData: ko.observableArray([]),
        chartPageNumbers: ko.observableArray([]),
        chartCategoryTitle: ko.observable("TIV (mils) - City - St/Prov - Country -<br />ClientLocID - Division - Facility"),
        chartTotalPages: 0,
        chartTotalRecords: 0,
        chartCriteriaFilter: null,
        currentPage: 1,
        currentPageGroup: 1,
        currentPageBeforePrint: 1,
        pageGroupSize: 10,
        pageSize: ServerSide_PageSize,
        mouseX: 0,
        mouseY: 0,
        isPrintCancelled: false,
        isLoadCancelled: false,

        // LABELS
        txtMessage: ko.observable(),
        txtMessageCurrentPage: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS
        isDrillDownShown: false,

        // KENDO OBJECTS
        windowPleaseWait: null,
        windowPleaseWaitLoading: null,

        // *** ZZZ TO DO: DELETE BELOW AND REPLACE WITH NEW CHART VARIABLES
        chartProtection0: null,
        chartProtection1: null,
        chartProtection2: null,
        chartProtection3: null,
        chartProtection4: null,
        chartProtection5: null,
        chartProtection6: null,
        chartProtection7: null,
        chartProtection8: null,
        chartProtection9: null,

        chartHuman0: null,
        chartHuman1: null,
        chartHuman2: null,
        chartHuman3: null,
        chartHuman4: null,
        chartHuman5: null,
        chartHuman6: null,
        chartHuman7: null,
        chartHuman8: null,
        chartHuman9: null,

        chartNatHaz0: null,
        chartNatHaz1: null,
        chartNatHaz2: null,
        chartNatHaz3: null,
        chartNatHaz4: null,
        chartNatHaz5: null,
        chartNatHaz6: null,
        chartNatHaz7: null,
        chartNatHaz8: null,
        chartNatHaz9: null,

        chartBusiness0: null,
        chartBusiness1: null,
        chartBusiness2: null,
        chartBusiness3: null,
        chartBusiness4: null,
        chartBusiness5: null,
        chartBusiness6: null,
        chartBusiness7: null,
        chartBusiness8: null,
        chartBusiness9: null,


        // FUNCTIONS
        init: function () {
            // LOOK FOR INCOMING PAGE AND SORT INFORMATION
            var pageNum = global.getQueryVariable("pg");
            if (pageNum != null) {
                viewChart.currentPage = Number(pageNum);
                viewChart.currentPageGroup = Math.ceil(viewChart.currentPage / viewChart.pageGroupSize);
            };
            var zSort = global.getQueryVariable("srt");
            if (zSort != null) {
                $("#cboSort").val(zSort);
            };
            // OTHER INIT
            viewChart.countLoading = 5;
            viewChart.loadLargeObjectData();
            viewChart.loadDictionary();
            viewChart.loadData();
            viewChart.setupKendo();
            viewChart.setupEvents();
        },


        loadDictionary: function () {
            viewChart.processLoading();
        },


        loadLargeObjectData: function () {
            try {
                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                    /* STORE THE LARGE OBJECT DATA */
                    if (ServerSide_LargeObjectFilter !== undefined && ServerSide_LargeObjectFilter !== "") {
                        viewChart.largeObjectFilter = JSON.parse(ServerSide_LargeObjectFilter);
                    }
                    if (ServerSide_LargeObjectCriteria !== undefined && ServerSide_LargeObjectCriteria !== "") {
                        viewChart.largeObjectCriteria = JSON.parse(ServerSide_LargeObjectCriteria);
                    }
                    if (ServerSide_LargeObjectSetting !== undefined && ServerSide_LargeObjectSetting !== "") {
                        viewChart.largeObjectSetting = JSON.parse(ServerSide_LargeObjectSetting);
                    }
                    viewChart.processLoading();
                } else {
                    var zServiceName = "GetLargeObjectDataChart";
                    var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID()
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.loadLargeObjectDataSuccess, viewChart.loadLargeObjectDataError, null);
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while starting the large object data load call: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },
        loadLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    /* STORE THE LARGE OBJECT DATA */
                    if (pResults.data.filterChart !== undefined && pResults.data.filterChart !== null && pResults.data.filterChart !== "") {
                        viewChart.largeObjectFilter = pResults.data.filterChart;
                    }
                    if (pResults.data.criteriaChart !== undefined && pResults.data.criteriaChart !== null && pResults.data.criteriaChart !== "") {
                        viewChart.largeObjectCriteria = pResults.data.criteriaChart;
                    }
                    if (pResults.data.settingChart !== undefined && pResults.data.settingChart !== null && pResults.data.settingChart !== "") {
                        viewChart.largeObjectSetting = pResults.data.settingChart;
                    }
                } else {
                    viewChart.txtMessage("An error occurred while loading large object data: " + pResults.message);
                    global.messageShow("txtMessage", "messageChartError");
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while loading large object data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
        },
        loadLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewChart.txtMessage("Error while loading large object data. " + pMessage);
            global.messageShow("txtMessage", "messageChartError");
            viewChart.processLoading();
        },


        loadData: function () {
            // UNCOMMENT FOR DYNAMIC DATA PULL
            viewChart.loadChartData(false, false);
            // USE BELOW FOR LOCAL JS HARD CODED DATA - DELETE ME
            //dsChartData = dsRatingTrending;
            //viewChart.buildChartData();
            //viewChart.buildPageGroups();
            //viewChart.processLoading();
            // END USE FOR LOCAL JS HARD CODED DATA - DELETE ME
        },


        // LOAD THE CHART META DATA
        loadChartData: function (pBypass, pIsStartPrintProcess) {
            try {
                viewChart.countLoading = 1;
                viewChart.showLoading();
                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                    if (ServerSide_ChartData !== undefined && ServerSide_ChartData.length > 0) {
                        dsChartData = JSON.parse(ServerSide_ChartData);
                        viewChart.buildChartData();
                        viewChart.processLoading();
                    } else {
                        viewChart.txtMessage("An error occurred while building the chart meta data in batch mode. No data was pulled from the batch service: " + ServerSide_ErrorMessage);
                        global.messageShow("txtMessage", "messageChartError");
                    }
                } else {
                    var zIsDrillDown = false;
                    if (ServerSide_IsDrillDownMode.toLowerCase() == "true") {
                        zIsDrillDown = true;
                    }
                    var zServiceName = "GetChartTrendingPagedData";
                    var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID(),
                        "pPage": viewChart.currentPage,
                        "pPageSize": viewChart.pageSize,
                        "pSort": viewChart.buildSort()
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.loadChartDataSuccess, viewChart.loadChartDataError, { bypassButtonBuild: pBypass, isStartPrintProcess: pIsStartPrintProcess });
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while starting the chart meta data call: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },
        loadChartDataSuccess: function (pResults, pParms) {
            try {
                if (viewChart.isLoadCancelled) {
                    viewChart.onExit();
                } else {
                    if (pResults.isSuccess) {
                        if (pResults.message) {
                            viewChart.txtMessage(pResults.message);
                            global.messageShow("txtMessage", "messageChartError");
                        } else {
                            if (pParms.isStartPrintProcess) {
                                pResults.transitions = false;
                            }
                            dsChartData = null;
                            dsChartData = pResults.data;
                            viewChart.buildChartData();
                            if (!pParms.bypassButtonBuild) {
                                viewChart.buildPageGroups();
                            }
                        }
                    } else {
                        viewChart.txtMessage("An error occurred while building chart data: " + pResults.message);
                        global.messageShow("txtMessage", "messageChartError");
                    }
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while building chart data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();

            // IF IN A PRINT TO PDF LOOP
            if (pParms.isStartPrintProcess) {
                viewChart.saveCurrentPageHTML();
            } else {
                if (viewChart.windowPleaseWait) {
                    viewChart.windowPleaseWait.close();
                }
            }
            viewChart.windowPleaseWaitLoading.close();
        },
        loadChartDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewChart.txtMessage("Error while accessing chart data call. " + pMessage);
            global.messageShow("txtMessage", "messageChartError");
        },


        buildChartData: function () {
            try {
                // BUILD OF CHART DATA
                // LOOP THROUGH GLOBAL CHART DATA
                // PUSH LOCATION ROWS TO KO ARRAY
                // FOR EACH ROW BUILD THE THREE CHARTS
                // AFTER ALL DONE BUILD THE JS KENDO CHART OBJECTS BY NAME

                // *** ZZZ TO DO: CUSTOMIZE FOR THIS PATICULAR CHART
                if (dsChartData && dsChartData.Locations) {
                    viewChart.resetChartObjects();
                    viewChart.chartTrendingData([]);
                    for (var x = 0; x < dsChartData.Locations.length; x++) {
                        viewChart.chartTrendingData.push({
                            FileNo: dsChartData.Locations[x].FileNo,
                            ClientLocNo: dsChartData.Locations[x].ClientLocNo,
                            Division: dsChartData.Locations[x].Division,
                            Facility: dsChartData.Locations[x].Facility,
                            Address: dsChartData.Locations[x].Address,
                            TIV: dsChartData.Locations[x].TIV,
                            ProtectionData: null,
                            HumanData: null,
                            NatHazData: null,
                            BusinessData: null
                        });
                    }
                    viewChart.setupKendoChart();
                } else {
                    viewChart.txtMessage("There is no chart data to process.");
                    global.messageShow("txtMessage", "messageChartError");
                }

                viewChart.chartTotalRecords = dsChartData.TotalLocations;
                viewChart.chartTotalPages = Math.ceil(dsChartData.TotalLocations / viewChart.pageSize);
                // FOR BATCH MODE, SET AN ELEMENT TO THE TOTAL RECORDS COUNT, DO NOT USE KNOCKOUT
                $("#TotalCount").html(viewChart.chartTotalRecords);
            } catch (pException) {
                viewChart.txtMessage("An error occurred while processing chart data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },


        resetChartObjects: function () {
            // *** ZZZ TO DO: UPDATE TO THIS REPORTS SPECIFIC VARIABLES
            viewChart.chartProtection0 = null;
            viewChart.chartProtection1 = null;
            viewChart.chartProtection2 = null;
            viewChart.chartProtection3 = null;
            viewChart.chartProtection4 = null;
            viewChart.chartProtection5 = null;
            viewChart.chartProtection6 = null;
            viewChart.chartProtection7 = null;
            viewChart.chartProtection8 = null;
            viewChart.chartProtection9 = null;

            viewChart.chartHuman0 = null;
            viewChart.chartHuman1 = null;
            viewChart.chartHuman2 = null;
            viewChart.chartHuman3 = null;
            viewChart.chartHuman4 = null;
            viewChart.chartHuman5 = null;
            viewChart.chartHuman6 = null;
            viewChart.chartHuman7 = null;
            viewChart.chartHuman8 = null;
            viewChart.chartHuman9 = null;

            viewChart.chartNatHaz0 = null;
            viewChart.chartNatHaz1 = null;
            viewChart.chartNatHaz2 = null;
            viewChart.chartNatHaz3 = null;
            viewChart.chartNatHaz4 = null;
            viewChart.chartNatHaz5 = null;
            viewChart.chartNatHaz6 = null;
            viewChart.chartNatHaz7 = null;
            viewChart.chartNatHaz8 = null;
            viewChart.chartNatHaz9 = null;

            viewChart.chartBusiness0 = null;
            viewChart.chartBusiness1 = null;
            viewChart.chartBusiness2 = null;
            viewChart.chartBusiness3 = null;
            viewChart.chartBusiness4 = null;
            viewChart.chartBusiness5 = null;
            viewChart.chartBusiness6 = null;
            viewChart.chartBusiness7 = null;
            viewChart.chartBusiness8 = null;
            viewChart.chartBusiness9 = null;
        },


        pagePreviousGroup: function () {
            if (viewChart.currentPageGroup < 2) {
                viewChart.currentPageGroup = 1;
            } else {
                viewChart.currentPageGroup--;
            }
            viewChart.currentPage = (viewChart.pageGroupSize * viewChart.currentPageGroup) - (viewChart.pageGroupSize - 1);
            if (viewChart.currentPage < 1) {
                viewChart.currentPage = 1;
            }
            viewChart.loadChartData();
        },


        pageLoadByNumber: function (pPage, pIsStartPrintProcess) {
            var zPageTotal = Math.ceil(viewChart.chartTotalRecords / viewChart.pageSize);
            viewChart.currentPage = pPage;
            viewChart.txtMessageCurrentPage("Page: " + viewChart.currentPage + " / " + zPageTotal);
            viewChart.loadChartData(true, pIsStartPrintProcess);
        },


        pageNextGroup: function () {
            viewChart.currentPageGroup++;
            viewChart.currentPage = (viewChart.pageGroupSize * viewChart.currentPageGroup) - (viewChart.pageGroupSize - 1);
            if (viewChart.currentPage > viewChart.chartTotalPages) {
                viewChart.currentPage = viewChart.chartTotalPages;
            }
            viewChart.loadChartData();
        },


        buildPageGroups: function () {
            viewChart.chartPageNumbers([]);
            // HOW MANY PAGE GROUPS DO WE HAVE?
            var zPageTotal = Math.ceil(viewChart.chartTotalRecords / viewChart.pageSize);
            var zPageGroupTotal = Math.ceil(zPageTotal / viewChart.pageGroupSize);
            var zPageStart = (viewChart.pageGroupSize * viewChart.currentPageGroup) - (viewChart.pageGroupSize - 1);
            var zPageEnd = (viewChart.pageGroupSize * viewChart.currentPageGroup);
            // SHOW OR HIDE THE NAVIGATION BUTTONS
            if (zPageTotal < viewChart.pageGroupSize) {
                if (zPageTotal < 2) {
                    $("#spnPageButtons").hide(1);
                }
                $("#btnPagePrevious").hide(1);
                $("#btnPageNext").hide(1);
            } else if (zPageEnd >= zPageTotal) {
                $("#btnPageNext").hide(1);
            } else if (zPageStart <= 1) {
                $("#btnPagePrevious").hide(1);
                $("#btnPageNext").show(1);
            } else {
                $("#btnPagePrevious").show(1);
                $("#btnPageNext").show(1);
            }
            // ALWAYS SHOW THE PREVIOUS BUTTON IF NOT ON THE FIRST GROUP OF PAGES
            if (viewChart.currentPageGroup > 1) {
                $("#btnPagePrevious").show(1);
            }
            // CORRECT THE PAGE END IF LESS THAN GROUP TOTAL
            if (zPageEnd > zPageTotal) {
                zPageEnd = zPageTotal;
            }
            // DISPLAY THE PAGE BUTTONS TO THE PAGE
            for (var x = zPageStart; x < zPageEnd + 1; x++) {
                viewChart.chartPageNumbers.push(x);
            }
            viewChart.txtMessageCurrentPage("Page: " + viewChart.currentPage + " / " + zPageTotal);
        },


        buildSort: function () {
            var zReturn = "";
            try {
                var zCboSort = document.getElementById("cboSort");
                var zCboSortValue = zCboSort.options[zCboSort.selectedIndex].value;
                if (!zCboSortValue) { zCboSortValue = "HighLowTIV"; }
                var zField = "TIV";
                var zDir = "des";
                switch (zCboSortValue) {
                    case "LowHighFileNo":
                        zField = "FileNoSort";
                        zDir = "asc"
                        break;
                    case "LowHighClientLocNo":
                        zField = "ClientLocNo";
                        zDir = "asc"
                        break;
                    case "LowHighCity":
                        zField = "City";
                        zDir = "asc"
                        break;
                    case "LowHighStProv":
                        zField = "StProv";
                        zDir = "asc"
                        break;
                    case "LowHighCountry":
                        zField = "Country";
                        zDir = "asc"
                        break;
                    case "HighLowTIV":
                        zField = "TIV";
                        zDir = "des"
                        break;
                    case "LowHighTIV":
                        zField = "TIV";
                        zDir = "asc"
                        break;
                    default:
                        break;
                }
                var zReturn = '[{"field":"' + zField + '","dir":"' + zDir + '"},{"field":"FileNo","dir":"asc"}]';
            } catch (pException) {
                viewChart.txtMessage("An error occurred while building the sort string: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
                zReturn = '[{"field":"TIV","dir":"des"},{"field":"FileNo","dir":"asc"}]';
            }
            return zReturn;
        },


        downloadPDF: function () {
            if (viewChart.chartTotalPages > 1) {
                // MULTIPLE PAGES
                $("#windowPleaseWaitCancelled").hide(1, function () {
                    $("#windowPleaseWaitProcessed").show();
                });
                viewChart.windowPleaseWait.center().open();
                // SAVE WHAT PAGE WE ARE ON AND SET STARTING VARIABLES
                viewChart.isPrintCancelled = false;
                viewChart.isPrintResetRequired = true;
                viewChart.currentPageBeforePrint = viewChart.currentPage;
                // GO TO PAGE ONE AND START THE LOADING PROCESS
                viewChart.pageLoadByNumber(1, true);

            } else {
                // SINGLE PAGE
                var zHTML = viewChart.getHTML();
                var zCSS = viewChart.getCSS();

                // CALL HANDLER PAGE BY CREATING A FORM
                // CREATE A FORM DOM ELEMENT
                var zForm = document.createElement("form");
                zForm.setAttribute("id", "frmPDF");
                zForm.setAttribute("method", "post");
                //zForm.setAttribute("target", "_blank");
                zForm.setAttribute("action", "../../FD/ServeHTMLToPDF.ashx?sid=" + getGSafeGUID());
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
            }
        },
        saveCurrentPageHTML: function () {
            var zHTML = viewChart.getHTML();
            var zCSS = viewChart.getCSS();
            var zServiceName = "SetChartFacilityPageData";
            var zParms = ko.toJSON({
                "gSafeGuid": getGSafeGUID(),
                "pIsResetRequired": viewChart.isPrintResetRequired,
                "pHTML": zHTML,
                "pCSS": zCSS
            });
            global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.saveCurrentPageHTMLSuccess, viewChart.saveCurrentPageHTMLError, null);
        },
        saveCurrentPageHTMLSuccess: function (pResults, pParms) {
            try {
                viewChart.isPrintResetRequired = false;
                if (!viewChart.isPrintCancelled) {
                    var zNextPage = viewChart.currentPage + 1;
                    if (zNextPage <= viewChart.chartTotalPages) {
                        // GO TO NEXT PAGE
                        // WHEN DONE, SEND THE NEXT PAGE INFO
                        viewChart.currentPage++;
                        viewChart.pageLoadByNumber(zNextPage, true);
                    } else {
                        // DOWNLOAD THE PDF
                        // WHEN DONE, SET THE PAGE BACK TO WHERE THEY STARTED
                        zURL = "../../FD/ServeMultiPartChart.ashx?gSafeGuid=" + getGSafeGUID();
                        window.location.href = zURL;
                        viewChart.pageLoadByNumber(viewChart.currentPageBeforePrint, false);
                    }
                } else {
                    // DO NOTHING
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while saving chart data for printing to PDF: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
        },
        saveCurrentPageHTMLError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewChart.txtMessage("Error while saving chart data for printing to PDF call. " + pMessage);
            global.messageShow("txtMessage", "messageChartError");
        },
        getHTML: function () {
            var zHTML = "";
            if (viewChart.printHTML == null) {
                // REMOVE ANY NO PRINT DOMS
                var zDocument = $("html").clone();
                zDocument.find(".printNone").each(function () {
                    $(this).remove();
                });
                zHTML = $(zDocument).html();
            } else {
                zHTML = viewChart.printHTML;
            }

            zHTML = zHTML.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
            zHTML = zHTML.replace(/(\r\t|\t|\r)/gm, " "); // REMOVE ALL TABS
            zHTML = zHTML.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
            zHTML = zHTML.replace(/(<)/gm, "||OPEN||"); // REPLACE ALL OPEN BRACKETS
            zHTML = zHTML.replace(/(>)/gm, "||CLOSE||"); // REPLACE ALL CLOSING BRACKETS
            return zHTML;
        },
        getCSS: function () {
            // CREATE THE HTML AND CSS DATA VARIABLES
            var zCSS = "";
            zCSS = ""
            zCSS = zCSS.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
            zCSS = zCSS.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
            return zCSS;
        },


        // EXTRACT AND REPORT FUNCTIONS
        downloadPDFHandler: function () {
            //if (1 == 1) {
            //    alert("The save and print functionality is in development and coming soon.");
            //} else {
                viewChart.largeObjectHandler = "ReportHandler.ashx";
                // FOR NOW SKIP THE SAVE OF LARGE OBJECT DATA
                var zURL = "../../Reports/" + viewChart.largeObjectHandler + "?sid=" + getGSafeGUID() + "&action=PrintChartReport";
                window.location.href = zURL;
            //}
        },


        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = [];
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "gridId": 0,
                    "sort": zSort,
                    "filter": zFilter,
                    "criteria": zCriteria,
                    "meta": null,
                    "columnOrder": JSON.stringify(zColumnOrder)
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.setLargeObjectDataSuccess, viewChart.setLargeObjectDataError, null);
            } catch (pException) {
                viewChart.txtMessage("An error occurred while starting the chart report call: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },
        setLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // CALL HANDLER
                    var zURL = "../../FD/" + viewChart.largeObjectHandler + "?gSafeGuid=" + getGSafeGUID();
                    window.location.href = zURL;
                } else {
                    viewChart.txtMessage("An error occurred while building chart report data: " + pResults.message);
                    global.messageShow("txtMessage", "messageChartError");
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while building chart report data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewChart.txtMessage("Error while setting chart report data. " + pMessage);
            global.messageShow("txtMessage", "messageChartError");
        },
        // END EXTRACT FUNCTIONS


        onCancelMultiPring: function () {
            $("#windowPleaseWaitProcessed").hide(1, function () {
                $("#windowPleaseWaitCancelled").show();
            });
            viewChart.isPrintCancelled = true;
            viewChart.pageLoadByNumber(viewChart.currentPageBeforePrint, false);
        },


        onSeriesHover: function (pEvent) {
            if (ServerSide_IsDrillDownMode != "true") {
                try {
                    /* DO NOTHING */
                } catch (pException) {
                    viewChart.txtMessage("An error occurred while getting hover infomration: " + pException.message);
                    global.messageShow("txtMessage", "messageChartError");
                }
            }
        },


        onSeriesClick: function (pEvent) {
            try {
                var zURL = "";
                var zFileNo = "";
                var zInspectionDate = "";
                var zCboSort = document.getElementById("cboSort");
                var zCboSortValue = zCboSort.options[zCboSort.selectedIndex].value;
                if (pEvent.dataItem.FileNo !== undefined) { zFileNo = pEvent.dataItem.FileNo; } else { zFileNo = pEvent.dataItem.__proto__.FileNo; }
                if (pEvent.dataItem.InspectionDate !== undefined) { zInspectionDate = pEvent.dataItem.InspectionDate; } else { zInspectionDate = pEvent.dataItem.__proto__.InspectionDate; }
                if (zInspectionDate !== null && zInspectionDate !== "null" && zInspectionDate.length > 0) {
                    zInspectionDate = "&insp=" + global.formatShortDate(zInspectionDate);
                }
                if (zFileNo !== null && zFileNo !== "null" && zFileNo.length > 0) {
                    // *** ZZZ TO DO: ADD TO THE CASE NUMBERS FOR THE CORRECT DRILLDOWNS
                    switch (viewChart.chartId.toString()) {
                        //case "61":
                        //case "62":
                        //case "63":
                        //    // FIRE
                        //    zURL = SITEBASEURL + "Home_{{VER}}/Fire/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                        //    openRequestedFromChartPopup(zURL);
                        //    break;
                        //case "64":
                        //case "65":
                        //case "66":
                        //    // BOILER
                        //    zURL = SITEBASEURL + "Home_{{VER}}/Boiler/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                        //    openRequestedFromChartPopup(zURL);
                        //    break;
                        default:
                            // FIRE
                            zURL = SITEBASEURL + "Home_{{VER}}/Fire/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                            openRequestedFromChartPopup(zURL);
                            break;
                    }
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while getting chart drilldown data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },


        onCancelLoad: function () {
            $("#windowPleaseWaitLoadingProcessed").hide(1, function () {
                $("#windowPleaseWaitLoadingCancelled").show();
            });
            viewChart.isLoadCancelled = true;
            window.close();
            // CANNOT NAVIGATE AWAY HERE BECAUSE THE PAGE IS ALREADY WAITING FOR A REQUEST
        },


        onExit: function () {
            window.close();
        },

        setupKendo: function () {
            viewChart.setupKendoWindow();
        },


        setupKendoWindow: function () {
            try {
                if (viewChart.windowPleaseWait == null) {
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
                    viewChart.windowPleaseWait = $("#windowPleaseWait").data("kendoWindow");
                }

                if (viewChart.windowPleaseWaitLoading == null) {
                    $("#windowPleaseWaitLoading").kendoWindow({
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
                    $("#windowPleaseWaitLoading").prev().find(".k-window-title").append("<img src='../../images/icons/wait/icon_hourglass_32x32.png' align='left' alt='Please Wait' class='windowIcon'/>  " + "Please Wait");
                    $("#windowPleaseWaitLoading").parent().addClass("printNone");
                    viewChart.windowPleaseWaitLoading = $("#windowPleaseWaitLoading").data("kendoWindow");
                    viewChart.windowPleaseWaitLoading.center().open();
                }

            } catch (pException) {
                viewChart.txtMessage("Error while building window messages. " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
        },


        setupKendoChart: function () {
            try {
                var zTransitions = true;
                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                    zTransitions = false;
                }

                // *** ZZZ TO DO: CHANGE TO THE CORRECT CHARTS FROM THE JSON DATA
                // SETUP CHARTS HERE
                viewChart.resetChartObjects();
                setTimeout(function () { // WAIT FOR KNOCKOUT ARRAY TO BE BUILT
                    // BUILD KENDO OBJECTS
                    // dsChartData MUST BE POPULATED
                    for (var x = 0; x < dsChartData.Locations.length; x++) {
                        viewChart.buildChartObject(dsChartData.Locations[x].ProtectionData, "chartProtection" + x.toString());
                        viewChart.buildChartObject(dsChartData.Locations[x].HumanData, "chartHuman" + x.toString());
                        viewChart.buildChartObject(dsChartData.Locations[x].NatHazData, "chartNatHaz" + x.toString());
                        viewChart.buildChartObject(dsChartData.Locations[x].BusinessData, "chartBusiness" + x.toString());
                    }
                }, 250);

            } catch (pException) {
                viewChart.txtMessage("An error occurred while building the chart: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
        },


        buildChartObject: function (pData, pObjectName) {
            if (pData.series.length > 0) {
                $("#" + pObjectName).kendoChart({
                    transitions: true,
                    renderAs: "svg",
                    legend: {
                        visible: false,
                        position: "bottom"
                    },
                    chartArea: dsChartArea,
                    categoryAxis: dsCategoryAxis,
                    valueAxis: {
                        min: pData.fldValueAxisMin,
                        max: pData.fldValueAxisMax,
                        labels: { visible: false },
                        line: { visible: false },
                        majorGridLines: { visible: false },
                        minorGridLines: { visible: false },
                        plotBands: [],
                        title: {
                            visible: false,
                            text: pData.fldTitleValueAxis
                        },
                    },
                    seriesDefaults: dsSeriesDefaults,
                    series: pData.series,
                    tooltip: dsToolTip,
                    seriesHover: viewChart.onSeriesHover,
                    seriesClick: viewChart.onSeriesClick
                });
                viewChart[pObjectName] = $("#" + pObjectName).data("kendoChart");
            }
        },


        setupEvents: function () {
            // EVENT FOR SORT SELECTION
            $("#cboSort").change(function () {
                setTimeout(function () {
                    viewChart.loadChartData();
                }, 100);
            });

            // KEEP TRACK OF MOUSE POSITION
            if (ServerSide_IsDrillDownMode != "true") {
                $(document).mousemove(function (pEvent) {
                    viewChart.mouseX = pEvent.pageX;
                    viewChart.mouseY = pEvent.pageY;
                });
            } else {
                /* REMOVE ELEMENTS */
                $("#frameChartDrillDown").remove();
            }

            // CLOSE DRILLDOWN IF NEEDED AND HIDE OTHER ELEMENTS AS NEEDED
            if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                $("#divPagingContainer").remove();
            } else {
                $(document).mouseup(function (pEvent) {
                });
            }
            viewChart.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewChart, $("#viewChart")[0]);
        },


        showLoading: function () {
            // LOWER THE CHARTS IN INDEX TO PREVENT THEM FROM BEING OVER THE LOADING SCREEN
            $(".chartContainer .k-chart").css("z-index", "-1");
            // SHOW THE LOADING SCREEN
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            // RE-ADJUST THE INDEX OF THE CHARTS TO ALLOW CLICKING AND HOVERING EVENTS
            $(".chartContainer .k-chart").css("z-index", "0");
            // HIDE THE LOADING SCREEN
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },


        processLoading: function () {
            viewChart.countLoading--;
            if (viewChart.countLoading < 1) {
                viewChart.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewChart.bindForm();
    viewChart.init();

    // CORRECT WIDTH AND POSITIONING ON THE PAGE
    $("#tablePageContainer").css("width", "auto");

});



