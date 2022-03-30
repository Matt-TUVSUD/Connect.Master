$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsChartData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());

    // VIEW
    viewChart = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        chartId: null,
        chartGridData: ko.observableArray([]),
        chartRatingsData: ko.observableArray([]),
        chartPageNumbers: ko.observableArray([]),
        chartRatingMax: 0,
        chartCategoryTitle: ko.observable("TIV (mils) - City - St/Prov - Country -<br />ClientLocID - Division - Facility"),
        averageGRC: ko.observable(),
        averageClient: ko.observable(),
        averageDivision: ko.observable(),
        chartTotalPages: 0,
        chartTotalRecords: 0,
        chartCriteriaFilter: null,
        chartPracticeName: "",
        legendRatingKey: dsChartRatingBands,
        currentDrillDownId: null,
        currentPage: 1,
        currentPageGroup: 1,
        currentPageBeforePrint: 1,
        pageGroupSize: 10,
        pageSize: ServerSide_PageSize,
        largeObjectHandler: null,
        mouseX: 0,
        mouseY: 0,
        isPrintCancelled: false,
        isLoadCancelled: false,

        // LABELS
        txtMessage: ko.observable(),
        txtMessageCurrentPage: ko.observable(),
        //txtIFrameSource: ko.observable(""),

        // BUTTON AND VISIBILITY CONTROLS
        isDrillDownShown: false,

        // KENDO OBJECTS
        chartRating: null,
        windowPleaseWait: null,
        windowPleaseWaitLoading: null,


        // FUNCTIONS
        init: function () {
            // LOOK FOR INCOMING PAGE AND SORT INFORMATION
            var pageNum = global.getQueryVariable("pg");
            if (pageNum != null) {
                viewChart.currentPage = Number(pageNum);
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
                global.messageShow("txtMessage", "messageGridError");
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
                    global.messageShow("txtMessage", "messageGridError");
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while loading large object data: " + pException.message);
                global.messageShow("txtMessage", "messageGridError");
            }
            viewChart.processLoading();
        },
        loadLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewChart.txtMessage("Error while loading large object data. " + pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewChart.processLoading();
        },


        loadData: function () {
            viewChart.loadChartData(false, false);
        },


        // LOAD THE CHART META DATA
        loadChartData: function (pBypass, pIsStartPrintProcess) {
            try {
                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                    if (ServerSide_ChartData !== undefined && ServerSide_ChartData.length > 0) {
                        dsChartData = JSON.parse(ServerSide_ChartData);
                        viewChart.chartId = dsChartData.fldId;
                        viewChart.buildChartData();
                        viewChart.processLoading();
                        viewChart.setupKendoChart();
                    } else {
                        viewChart.txtMessage("An error occurred while building the chart meta data in batch mode. No data was pulled from the batch service: " + ServerSide_ErrorMessage);
                        global.messageShow("txtMessage", "messageChartError");
                    }
                } else {
                    var zIsDrillDown = false;
                    if (ServerSide_IsDrillDownMode.toLowerCase() == "true") {
                        zIsDrillDown = true;
                    }
                    var zServiceName = "GetChartPagedData";
                    var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID(),
                        "pPage": viewChart.currentPage,
                        "pPageSize": viewChart.pageSize,
                        "pSort": viewChart.buildSort()
                    });
                    //global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewChart.loadChartDataSuccess, viewChart.loadChartDataError, { bypassButtonBuild: pBypass, isStartPrintProcess: pIsStartPrintProcess });
                    viewChart.loadChartDataSuccess(dsResults, { bypassButtonBuild: pBypass, isStartPrintProcess: pIsStartPrintProcess });
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
                    if (pParms.isStartPrintProcess) {
                        pResults.transitions = false;
                    }
                    dsChartData = pResults;
                    viewChart.buildChartData();
                    if (!pParms.bypassButtonBuild) {
                        viewChart.buildPageGroups();
                    }
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while building chart data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
            viewChart.setupKendoChart();

            // IF IN A PRINT TO PDF LOOP
            if (pParms.isStartPrintProcess) {
                viewChart.saveCurrentPageHTML();
            } else {
                if (viewChart.windowPleaseWait) {
                    viewChart.windowPleaseWait.close();
                }
            }
            if (viewChart.windowPleaseWaitLoading) {
                viewChart.windowPleaseWaitLoading.close();
            }
        },
        loadChartDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewChart.txtMessage("Error while accessing chart data call. " + pMessage);
            global.messageShow("txtMessage", "messageChartError");
        },


        buildChartData: function () {
            // FILL IN THE PLOT BANDS AND RATINGS LEGEND
            var zIndexHighRange = 0;
            viewChart.chartRatingMax = 0;
            if (!dsChartData.fldPlotBands) {
                dsChartData.fldPlotBands = dsChartRatingBands;
            }
            viewChart.chartRatingsData([]);
            for (var x = 0; x < dsChartData.fldPlotBands.length; x++) {
                viewChart.chartRatingsData.push({
                    ratingTitle: dsChartData.fldPlotBands[x].title,
                    ratingColor: dsChartData.fldPlotBands[x].color
                });
                // GET THE HIGHEST MAX VALUE INDEX
                if (dsChartData.fldPlotBands[x].to >= viewChart.chartRatingMax) {
                    zIndexHighRange = x;
                    viewChart.chartRatingMax = dsChartData.fldPlotBands[x].to;
                }
            }
            // ADJUST THE HIGHEST BAND VALUE TO STRETCH THE RIGHT SIDE
            dsChartData.fldPlotBands[zIndexHighRange].to = dsChartData.fldPlotBands[zIndexHighRange].to + 5;
            viewChart.chartRatingMax = dsChartData.fldPlotBands[zIndexHighRange].to;

            // TITLE FOR CATEGORY AXIS
            if (dsChartData.fldId == 57 || dsChartData.fldId == 58) {
                viewChart.chartCategoryTitle("Date of Inspection");
            }
            // CORRECT ANY MISSING TITLES
            if (dsChartData.series[0].data) {
                for (var x = 0; x < dsChartData.series[0].data.length; x++) {
                    if (dsChartData.series[0].data[x].fldTitle === undefined || dsChartData.series[0].data[x].fldTitle === null || dsChartData.series[0].data[x].fldTitle.length < 1) {
                        dsChartData.series[0].data[x].fldTitle = "Location " + dsChartData.series[0].data[x].fldId;
                    } else {
                        dsChartData.series[0].data[x].fldTitle = dsChartData.series[0].data[x].fldTitle;
                    }
                }
            }
            // IF SERIES DATA COUNT IS LESS THAN DATA ALLOWED ON PAGE, THEN ADD EMPTY ROWS
            if (dsChartData.series[0].data.length < viewChart.pageSize) {
                for (var x = dsChartData.series[0].data.length; x < viewChart.pageSize; x++) {
                    var zTitle = "";
                    for (var y = 0; y < x; y++) {
                        zTitle += " ";
                    }
                    dsChartData.series[0].data.push({
                        fldColor: "transparent",
                        fldFieldId: zTitle,
                        fldFileNo: null,
                        fldId: 0,
                        fldMetaChartDrillDownId: null,
                        fldMetaChartDrillDownTypeId: null,
                        fldTitle: zTitle,
                        fldToolTip: "",
                        fldValue: null
                    });
                }
            }


            viewChart.averageGRC(dsChartData.fldGRCAverages);
            viewChart.averageClient(dsChartData.fldClientAverages);
            viewChart.averageDivision(dsChartData.fldDivsionAverages);
            viewChart.chartId = dsChartData.fldId;
            viewChart.chartTotalRecords = dsChartData.series[0].total;
            viewChart.chartTotalPages = Math.ceil(dsChartData.series[0].total / viewChart.pageSize);
            viewChart.chartPracticeName = dsChartData.series[0].name;
            // FOR BATCH MODE, SET AN ELEMENT TO THE TOTAL RECORDS COUNT, DO NOT USE KNOCKOUT
            $("#TotalCount").html(viewChart.chartTotalRecords);
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
                if (ServerSide_ChartId == 57 || ServerSide_ChartId == 58) {
                    zReturn = '[{"field":"InspectionDate","dir":"des"}]';
                } else if (ServerSide_ChartId == 59 || ServerSide_ChartId == 60) {
                    zReturn = '[{"field":"ARIScore","dir":"des"},{"field":"FileNo","dir":"asc"}]';
                } else {
                    var zCboSort = document.getElementById("cboSort");
                    var zCboSortValue = zCboSort.options[zCboSort.selectedIndex].value;
                    if (!zCboSortValue) { zCboSortValue = "HighLowScore"; }
                    var zField = "totalscore";
                    var zDir = "des";
                    switch (zCboSortValue) {
                        case "LowHighFileNo":
                            zField = "FileNo";
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
                        case "HighLowScore":
                            zField = "totalscore";
                            zDir = "des"
                            break;
                        case "LowHighScore":
                            zField = "totalscore";
                            zDir = "asc"
                            break;
                        default:
                            break;
                    }
                    var zReturn = '[{"field":"' + zField + '","dir":"' + zDir + '"}]';
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while building the sort string: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
                if (viewChart.chartId == 57 || viewChart.chartId == 58) {
                    zReturn = '[{"field":"InspectionDate","dir":"des"}]';
                } else if (ServerSide_ChartId == 59 || ServerSide_ChartId == 60) {
                    zReturn = '[{"field":"ARIScore","dir":"des"},{"field":"FileNo","dir":"asc"}]';
                } else {
                    zReturn = '[{"field":"totalscore","dir":"des"}]';
                }
            }
            return zReturn;
        },


        downloadPDF: function () {
            if (viewChart.chartTotalPages > 1) {
                // MULTIPLE PAGES
                //viewChart.txtMessage("Sending chart information to be printed. This may take a few minutes. Loading...");
                //global.messageShow("txtMessage", "messageChartError");
                if (viewChart.windowPleaseWait) {
                    $("#windowPleaseWaitCancelled").hide(1, function () {
                        $("#windowPleaseWaitProcessed").show();
                    });
                    viewChart.windowPleaseWait.center().open();
                }
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
                        //viewChart.txtMessage("");
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
            viewChart.setupKendoChart();
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


        onCancelMultiPring: function () {
            if (viewChart.windowPleaseWait) {
                $("#windowPleaseWaitProcessed").hide(1, function () {
                    $("#windowPleaseWaitCancelled").show();
                });
            }
            viewChart.isPrintCancelled = true;
            viewChart.pageLoadByNumber(viewChart.currentPageBeforePrint, false);
        },


        onSeriesHover: function (pEvent) {
            if (ServerSide_IsDrillDownMode != "true") {
                /* DO NOTHING */
            }
        },


        onSeriesClick: function (pEvent) {
            try {
                if (ServerSide_IsDrillDownMode != "true") {
                    var zURL = "";
                    var zDrillDownType = "";
                    var zDrillDownId = "";
                    var zTitle = "";
                    var zFileNo = "";
                    var zInspectionDate = "";
                    if (pEvent.dataItem.fldMetaChartDrillDownTypeId !== undefined) { zDrillDownType = pEvent.dataItem.fldMetaChartDrillDownTypeId; } else { zDrillDownType = pEvent.dataItem.__proto__.fldMetaChartDrillDownTypeId; }
                    if (pEvent.dataItem.fldMetaChartDrillDownId !== undefined) { zDrillDownId = pEvent.dataItem.fldMetaChartDrillDownId; } else { zDrillDownId = pEvent.dataItem.__proto__.fldMetaChartDrillDownId; }
                    if (pEvent.dataItem.fldTitle !== undefined) { zTitle = pEvent.dataItem.fldTitle; } else { zTitle = pEvent.dataItem.__proto__.fldTitle; }
                    if (pEvent.dataItem.fldFileNo !== undefined) { zFileNo = pEvent.dataItem.fldFileNo; } else { zFileNo = pEvent.dataItem.__proto__.fldFileNo; }
                    if (pEvent.dataItem.InspectionDate !== undefined) { zInspectionDate = pEvent.dataItem.InspectionDate; } else { zInspectionDate = pEvent.dataItem.__proto__.InspectionDate; }
                    if (zInspectionDate !== null && zInspectionDate !== "null" && zInspectionDate.length > 0) {
                        zInspectionDate = "&insp=" + global.formatShortDate(zInspectionDate);
                    }
                    if (zFileNo !== null && zFileNo !== "null" && zFileNo.length > 0) {
                        switch (zDrillDownType.toString()) {
                            case "1":
                                // CHART
                                break;
                            case "2":
                                // REPORT
                                break;
                            case "3":
                                // GRID
                                break;
                            case "4":
                                // FORM
                                var zCboSort = document.getElementById("cboSort");
                                var zCboSortValue = ""
                                if (zCboSort != null) { zCboSortValue = zCboSort.options[zCboSort.selectedIndex].value; }
                                // ARE WE IN FIRE OR BOILER?
                                if (viewChart.chartPracticeName.toLocaleLowerCase() == "boiler") {
                                    //document.location.href = SITEBASEURL + "Home_{{VER}}/Boiler/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                                    zURL = SITEBASEURL + "Home_{{VER}}/Boiler/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                                    openRequestedFromChartPopup(zURL);
                                } else {
                                    //document.location.href = SITEBASEURL + "Home_{{VER}}/Fire/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                                    zURL = SITEBASEURL + "Home_{{VER}}/Fire/facilityratingfromchart.aspx?sid=" + getGSafeGUID() + "&p1=" + zFileNo + "&c1=true" + "&pg=" + viewChart.currentPage + "&srt=" + zCboSortValue + zInspectionDate + "&chartId=" + viewChart.chartId;
                                    openRequestedFromChartPopup(zURL);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while getting chart drilldown data: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
        },


        onCancelLoad: function () {
            if (viewChart.windowPleaseWaitLoading) {
                $("#windowPleaseWaitLoadingProcessed").hide(1, function () {
                    $("#windowPleaseWaitLoadingCancelled").show();
                });
            }
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


        setupKendoChart: function () {
            try {
                var zTransitions = true;
                if ((ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") ||
                    (dsChartData.transitions !== undefined && dsChartData.transitions == false)) {
                    zTransitions = false;
                }
                viewChart.chartRating = null;
                if (viewChart.chartRating == null) {
                    $("#chartRating").kendoChart({
                        transitions: zTransitions,
                        renderAs: "svg",
                        legend: {
                            visible: true,
                            position: "top",
                            item: {
                                visual: function (pEvent) {
                                    try {
                                        // GATHER INFORMATION
                                        var zColor = pEvent.options.markers.background;
                                        var zLabelColor = pEvent.options.labels.color;
                                        var zRect = new kendo.geometry.Rect([0, 0], [500, 500]);
                                        var zLayout = new kendo.drawing.Layout(zRect, {
                                            lineSpacing: -10,
                                            spacing: 4,
                                            alignContent: "start",
                                            justifyContent: "right",
                                            alignItems: "center",
                                            orientation: "horizontal",
                                            prefix: "",
                                            wrap: true
                                        });
                                        // CREATE THE SQUARE AND THE LABEL
                                        var zMarker = new kendo.drawing.Path({
                                            fill: {
                                                color: zColor
                                            }
                                        }).moveTo(0, 0).lineTo(10, 0).lineTo(10, 10).lineTo(0, 10).close();
                                        var zPos = [0, 0];
                                        var zLabel = new kendo.drawing.Text(pEvent.series.name, zPos, {
                                            fill: {
                                                color: zLabelColor
                                            }
                                        });
                                        // APPLY AND DRAW THE ITEM
                                        zLayout.append(zMarker, zLabel);
                                        zLayout.reflow()
                                        return zLayout;

                                    } catch (pException) {
                                        alert(pException.message);
                                        return null;
                                    }
                                }
                            }
                        },
                        chartArea: {
                            height: 575,
                            width: 1240
                        },
                        categoryAxis: {
                            labels: {
                                template: "#= wrapChartLabels(value, 65)#",
                            },
                            majorGridLines: {
                                visible: false,
                                color: "#111111"
                            }
                        },
                        valueAxis: {
                            min: 0,
                            max: viewChart.chartRatingMax,
                            labels: {
                                visible: true
                            },
                            line: {
                                visible: true
                            },
                            majorGridLines: {
                                visible: true,
                                color: "#000000"
                            },
                            minorGridLines: {
                                visible: true,
                                color: "#CCCCCC"
                            },
                            title: {
                                text: dsChartData.fldTitleValueAxis
                            },
                            plotBands: dsChartData.fldPlotBands // dsChartRatingBands // NEEDED FROM GDC
                        },
                        seriesDefaults: {
                            //gap: 2.0,
                            visual: function (pEvent) {
                                // CREATE A FIXED BAR WIDTH
                                var zBarWidth = 15;
                                var visual = pEvent.createVisual();
                                visual.transform(kendo.geometry.transform().scale(1, zBarWidth / pEvent.rect.size.height, pEvent.rect.center()));
                                return visual;
                            },
                            labels: {
                                visible: true,
                                format: "n1",
                                rotation: 0,
                                background: "transparent"
                            }
                        },
                        series: dsChartData.series,
                        tooltip: {
                            visible: true,
                            background: "#1961AD",
                            color: "#FFFFFF",
                            template: "#: data.dataItem.fldToolTip #"
                        },
                        seriesHover: viewChart.onSeriesHover,
                        seriesClick: viewChart.onSeriesClick
                    });
                    viewChart.chartRating = $("#chartRating").data("kendoChart");
                }
            } catch (pException) {
                viewChart.txtMessage("An error occurred while building the chart: " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                    // REMOVE ELEMENTS
                    $("#windowPleaseWait").remove();
                    $("#windowPleaseWaitLoading").remove();
                } else {
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
                }

            } catch (pException) {
                viewChart.txtMessage("Error while building window messages. " + pException.message);
                global.messageShow("txtMessage", "messageChartError");
            }
            viewChart.processLoading();
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
                //$("#" + gDivDrillDownContainerId).remove();
            }

            // CLOSE DRILLDOWN IF NEEDED AND HIDE OTHER ELEMENTS AS NEEDED
            if (ServerSide_IsBatchMode !== undefined && ServerSide_IsBatchMode.toLowerCase() == "true") {
                $("#divPagingContainer").remove();
            } else {
                $(document).mouseup(function (pEvent) {
                    //var zDrillDownContainer = $("#" + gDivDrillDownContainerId); /*$("#divDrillDownContainer");*/
                    /* if the target of the click isn't the container... ... nor a descendant of the container */
                    //if ((!zDrillDownContainer.is(pEvent.target) && zDrillDownContainer.has(pEvent.target).length === 0)) {
                    //    zDrillDownContainer.fadeOut();
                    //    viewChart.isDrillDownShown = false;
                    //}
                });
            }
            viewChart.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewChart, $("#viewChart")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
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


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    //globalLoadChart = function () {
    //    // DO NOTHING
    //}

});



