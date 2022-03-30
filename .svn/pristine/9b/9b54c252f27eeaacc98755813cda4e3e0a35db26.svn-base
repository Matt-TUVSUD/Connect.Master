$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsGridData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());

    // VIEW
    viewStandardGrid = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,
        largeObjectHandler: null,
        useReportId2: true,  //Added by DB: some grids have two report. this parameter will specify which to use.
        favoriteList: ko.observableArray([]),
        favoriteName: ko.observable(""),

        // LARGE OBJECT DATA
        largeObjectFilter: null,
        largeObjectCriteria: null,
        largeObjectSort: null,
        largeObjectMeta: null,
        
        // LABELS
        txtMessage: ko.observable(),
        txtSortedBy: ko.observable(),
        txtFilteredBy: ko.observable(),
        txtPinnedBy: ko.observable(),
        txtTotalRecords: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS

        // KENDO OBJECTS
        gridStandard: null,
        windowFavorite: null,
        mapDepictedNameCurrent: null,
        mapDepictedDisplayCurrent: null,
        isMappable: false,

        // FUNCTIONS
        init: function () {
            viewStandardGrid.countLoading = 5;
            viewStandardGrid.loadLargeObjectData();
            viewStandardGrid.loadDictionary();
            //viewStandardGrid.loadData(); // AFTER LARGE OBJECT SUCCESS
            viewStandardGrid.setupKendo();
            viewStandardGrid.setupEvents();
        },


        loadDictionary: function () {
            viewStandardGrid.processLoading();
        },


        loadLargeObjectData: function () {
            try {
                var zServiceName = "GetLargeObjectDataGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewStandardGrid.loadLargeObjectDataSuccess, viewStandardGrid.loadLargeObjectDataError, null);
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while starting the large object data load call: " + pException.message);
            }
        },
        loadLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // STORE THE LARGE OBJECT DATA
                    if (pResults.data.filter !== undefined && pResults.data.filter !== null && pResults.data.filter !== "") {
                        viewStandardGrid.largeObjectFilter = pResults.data.filter;
                    }
                    if (pResults.data.criteria !== undefined && pResults.data.criteria !== null && pResults.data.criteria !== "") {
                        viewStandardGrid.largeObjectCriteria = pResults.data.criteria;
                    }
                    if (pResults.data.sort !== undefined && pResults.data.sort !== null && pResults.data.sort !== "") {
                        viewStandardGrid.largeObjectSort = pResults.data.sort;
                    }
                    if (pResults.data.meta !== undefined && pResults.data.meta !== null && pResults.data.meta !== "") {
                        viewStandardGrid.largeObjectMeta = pResults.data.meta;
                    }
                } else {
                    viewStandardGrid.processMessage("An error occurred while loading large object data: " + pResults.message);
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while loading large object data: " + pException.message);
            }
            viewStandardGrid.processLoading();
            viewStandardGrid.loadData();
        },
        loadLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewStandardGrid.processMessage("Error while loading large object data. " + pMessage);
            viewStandardGrid.processLoading();
        },


        loadData: function () {
            viewStandardGrid.loadGridMeta();
        },


        // LOAD THE GRID META DATA
        loadGridMeta: function (pIsRebuildRequired) {
            try {
                var zUserCurrencyId = null;
                if (gCurrencyIdFromPrefilter) {
                    zUserCurrencyId = gCurrencyIdFromPrefilter;
                }
                var zServiceName = "GetGridMeta";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "pIsRebuildRequired": pIsRebuildRequired,
                    "pUserCurrencyId": zUserCurrencyId
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewStandardGrid.loadGridMetaSuccess, viewStandardGrid.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
            }
        },
        loadGridMetaSuccess: function (pResults, pParms) {
            try {
                dsMetaData = pResults;
                var zIsMappable = false;
                for (var x = 0; x < dsMetaData.columns.length; x++) {
                    // MAKE ANY CORRECTIONS TO POSSIBLE FUNCTIONS
                    if (dsMetaData.columns[x].template !== undefined && dsMetaData.columns[x].template !== null && dsMetaData.columns[x].template.indexOf("function") == 0) {
                        dsMetaData.columns[x].template = "var fn = " + dsMetaData.columns[x].template;
                        var zFn = eval(dsMetaData.columns[x].template);
                        dsMetaData.columns[x].template = fn;
                    }
                    // ARE ANY FIELDS MAP DEPICTABLE?
                    if (dsMetaData.columns[x].isDepictable) {
                        zIsMappable = true;
                        viewStandardGrid.isMappable = true;
                    }
                    // STORE THE DEFAULT MAP DEPICTABLE FIELD
                    if (dsMetaData.columns[x].isDefaultDepicted) {
                        viewStandardGrid.mapDepictedNameCurrent = dsMetaData.columns[x].field;
                        viewStandardGrid.mapDepictedDisplayCurrent = dsMetaData.columns[x].title;
                        $("#txtDepictedBy").html(dsMetaData.columns[x].title);
                    }
                }

                // SHOW MAP BUTTON AND OTHER CONTAINERS
                if (zIsMappable) {
                    $("#divViewGridButtonContainer").fadeIn(1);
                    $("#divTopInstructionsMap").fadeIn(1);
                    $(".messageNoticeNoBoldSmallMap").fadeIn(1);
                    $('#ClientConnectSiteBody_ClientConnectFormBody_divContainerMapBtn').removeClass('noShow');
                } else {
                    $("#divViewGridButtonContainer").fadeOut(1);
                    $("#divTopInstructionsMap").fadeOut(1);
                    $(".messageNoticeNoBoldSmallMap").fadeOut(1);
                    $('#ClientConnectSiteBody_ClientConnectFormBody_divContainerMapBtn').addClass('noShow');
                }

            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewStandardGrid.processLoading();
            viewStandardGrid.setupKendoGrid(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewStandardGrid.processMessage("Error while loading meta data. " + pMessage);
        },


        // EXTRACT AND REPORT FUNCTIONS
        setExtractData: function () {
            viewStandardGrid.largeObjectHandler = "../../FD/ServeExtract.ashx";
            viewStandardGrid.setLargeObjectData();
        },


        setReportData: function () {
            viewStandardGrid.largeObjectHandler = "../../Reports/ReportHandler.ashx";
            viewStandardGrid.useReportId2 = false;
            viewStandardGrid.setLargeObjectData();
        },


        setChartData: function () {
            viewStandardGrid.largeObjectHandler = "../../Reports/ReportHandler.ashx";
            viewStandardGrid.useReportId2 = true;
            viewStandardGrid.setLargeObjectData();
        },


        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = [];
                //if (viewStandardGrid.largeObjectSort === null) {
                //    if (viewStandardGrid.gridStandard.grid.dataSource.sort()) {
                //    }
                //} else {
                //    zSort = viewStandardGrid.largeObjectSort;
                //}

				// Changed by Daniel on Oct 11, 2016 to always read the current sort from the interactive grid control
                zSort = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.sort());

                //if (viewStandardGrid.largeObjectFilter === null) {
                //    if (viewStandardGrid.gridStandard.grid.dataSource.filter()) {
                //        zFilter = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.filter()); 
                //    }
                //} else {
                //	zFilter = viewStandardGrid.largeObjectFilter;
                //}

            	// Changed by Daniel on Oct 11, 2016 to always read the current filter from the interactive grid control
                zFilter = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.filter());

                if (viewStandardGrid.largeObjectCriteria === null) {
                    if (viewStandardGrid.gridCriteriaFilter) {
                        zCriteria = JSON.stringify(viewStandardGrid.gridCriteriaFilter);
                    }
                } else {
                    zCriteria = viewStandardGrid.largeObjectCriteria;
                }
                for (var x = 0; x < viewStandardGrid.gridStandard.grid.columns.length; x++) {
                    zColumnOrder.push(viewStandardGrid.gridStandard.grid.columns[x].field);
                }
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "gridId": 0,
                    "sort": zSort,
                    "filter": zFilter,
                    "criteria": zCriteria,
                    "meta": null, 
                    "columnOrder": JSON.stringify(zColumnOrder) // ADD ARRAY OF FIELD NAMES IN ORDER
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewStandardGrid.setLargeObjectDataSuccess, viewStandardGrid.setLargeObjectDataError, null);
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while starting the grid extract call: " + pException.message);
            }
        },
        setLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // CALL HANDLER
                    var zUserCurrencyId = "";
                    if (gCurrencyIdFromPrefilter) {
                        zUserCurrencyId = "&userCurrencyId=" + gCurrencyIdFromPrefilter;
                    }

                    var zUseReport2Parm = "";
                    if (viewStandardGrid.useReportId2) { zUseReport2Parm = "&useReport2=true"; }

                    var zURL = viewStandardGrid.largeObjectHandler + "?action=PrintGridReport&sid=" + getGSafeGUID() + zUserCurrencyId + zUseReport2Parm;
                    window.location.href = zURL;
                } else {
                    viewStandardGrid.processMessage("An error occurred while building grid extract data: " + pResults.message);
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while building grid extract data: " + pException.message);
            }
            viewStandardGrid.processLoading();
            viewStandardGrid.setupKendoGrid();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewStandardGrid.processMessage("Error while setting extract data. " + pMessage);
            viewStandardGrid.processLoading();
        },
        // END EXTRACT FUNCTIONS


        // FAVORITES FUNCTIONS
        loadFavorite: function () {
            try {
                viewStandardGrid.favoriteList([]);
                viewStandardGrid.favoriteName("");
                var zServiceName = "GetGridFavoriteListByGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewStandardGrid.loadFavoriteSuccess, viewStandardGrid.loadFavoriteError, null);
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        loadFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    if (pResults.data) {
                        for (var x = 0; x < pResults.data.length; x++) {
                            if (pResults.data[x].colFldTitle) {
                                viewStandardGrid.favoriteList.push({ 
                                    id: pResults.data[x].colId,
                                    title: pResults.data[x].colFldTitle 
                                });
                            }
                        }
                    }
                    viewStandardGrid.windowFavorite.center().open();
                } else {
                    viewStandardGrid.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewStandardGrid.processLoading();
        },
        loadFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewStandardGrid.windowFavorite.center().open();
            viewStandardGrid.processMessage("Error while calling the save favorite service. " + pMessage);
        },


        setFavorite: function () {
            try {
                // VALIDATE THE NAME
                var zTitle = viewStandardGrid.favoriteName();
                var zIsValid = true;
                var zIsCopy = false;
                var zIsCopyId = 0;
                if (zTitle === undefined || zTitle === null || zTitle.length < 1) {
                    zIsValid = false;
                    alert("Please enter a name for the favorite.");
                }
                for (var x = 0; x < viewStandardGrid.favoriteList().length; x++) {
                    if (zTitle == viewStandardGrid.favoriteList()[x].title) {
                        var zYesNo = confirm("The favorite [" + zTitle + "] already exists.  Do you want to overwrite?");
                        if (zYesNo) {
                            zIsCopy = true;
                            zIsCopyId = viewStandardGrid.favoriteList()[x].id;
                        } else {
                            zIsValid = false;
                        }
                        break;
                    }
                }

                if (zIsValid) {
                    // GATHER INFORMATION
                    //gSafeGuid As String, pTitle As String, pColumnOrderSetting As String, pSort As String, pFilter As String, pCriteria As String
                    var zSort = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.sort());
                    var zFilter = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.filter());
                    var zCriteria = viewStandardGrid.gridCriteriaFilter;
                    var zColumnOrder = [];
                    for (var x = 0; x < viewStandardGrid.gridStandard.grid.columns.length; x++) {
                        zColumnOrder.push({
                            locked: viewStandardGrid.gridStandard.grid.columns[x].locked,
                            field: viewStandardGrid.gridStandard.grid.columns[x].field
                        });
                    }
                    // CORRECT ANY STRINGS THAT SAY NULL
                    if (zSort == "null") { zSort = null; }
                    if (zFilter == "null") { zFilter = null; }
                    if (zCriteria == "null") { zCriteria = null; }
                    // CALL THE SERVICE
                    var zServiceName = "SaveGridFavorite";
                    var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID(),
                        "pTitle": zTitle,
                        "pColumnOrderSetting": JSON.stringify(zColumnOrder),
                        "pSort": zSort,
                        "pFilter": zFilter,
                        "pCriteria": zCriteria
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewStandardGrid.setFavoriteSuccess, viewStandardGrid.setFavoriteError, null);
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        setFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewStandardGrid.windowFavorite.close();
                } else {
                    alert("An error occurred while saving your favorites data: " + pResults.message);
                    viewStandardGrid.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                alert("An error occurred while saving your favorites data: " + pException.message);
                viewStandardGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewStandardGrid.processLoading();
        },
        setFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            alert("Error while calling the save favorite service. " + pMessage);
            viewStandardGrid.processMessage("Error while calling the save favorite service. " + pMessage);
        },

        
        onFavoriteSave: function () {
            viewStandardGrid.setFavorite();
        },


        onFavoriteCancel: function () {
            viewStandardGrid.windowFavorite.close();
            viewStandardGrid.favoriteList([]);
            viewStandardGrid.favoriteName("");
        },
        // END FAVORITES FUNCTIONS

        /* START BUBBLE CHART FUNCTIONS */
        saveGridFilter: function () {
            try{
                var zFilter = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.filter());
                var zServiceName = "SaveGridFilter";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID(),
                    "pFilter": zFilter
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewStandardGrid.saveGridFilterSuccess, viewStandardGrid.saveGridFilterError, null);
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while saving your grid filter data: " + pException.message);
            }
        },
        saveGridFilterSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    var zGSafeGUID = getGSafeGUID();
                    var pGridFilter = pResults.data;
                    var pFilter = encodeURI(pGridFilter);
                    var pPracticeID = globalPracticeTypeForBubbleChart;
                    var zURL = "../../Charts/BubbleChart.aspx?sid=" + zGSafeGUID + "&filter=" + pFilter + "&gridId=" + pPracticeID;
                    //window.location.href = zURL;
                    /* USE BELOW CODE TO OPEN CHART IN NEW WINDOW WHILE KEEPING GRID OPEN BEHIND IT */
                    var zOptions = "" +
                       "resizable=yes" +
                       ",scrollbars=yes" +
                       ",status=yes" +
                       ",left=0" +
                       ",top=0" +
                       ",width=" + screen.width * 0.99 +
                       ",height=" + screen.height * 0.90;
                    windowObjectReference = window.open(zURL, "SingleSecondaryWindowName", zOptions);
                    windowObjectReference.focus();
                }
            } catch (pException) {
                alert("An error occurred while saving your grid filter data: " + pException.message);
                viewStandardGrid.processMessage("An error occurred while saving your grid filter data: " + pException.message);
            }
        },
        saveGridFilterError: function (pResults, pMessage, pErrorDetail, pParms) {
            alert("Error while calling the save grid filter service. " + pMessage);
            viewStandardGrid.processMessage("Error while calling the save grid filter service. " + pMessage);
        },

        /* END BUBBLE CHART FUNCTIONS */

        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewStandardGrid.processLoading();
            global.messageShow("txtMessage", "messageGridNormal");
        },
        

        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewStandardGrid.clearMessage();
                // SAVE THE POPUP WINDOW TITLE AND FILE NAME
                var zHTML = $(".k-icon.k-plus").first().parent().html();
                if (zHTML) {
                    if (zHTML.length > 0) {
                        // GATHER INFOR
                        var zParms = zHTML.substring(zHTML.indexOf("(") + 1, zHTML.indexOf(")"));
                        var zParms = zParms.replace(/\\/g, "");
                        var zParms = zParms.replace(/"/g, "");
                        var zArray = zParms.split(",");
                        // MAKE CORRECTIONS TO AMPERSANDS
                        zArray[1] = zArray[1].replace(/&amp;/gm, "&");
                        // ASSIGN VALUES
                        globalPopupFileName = zArray[0].trim().replace(/&quot;/g, "");
                        globalPopupTitle = zArray[1].trim().replace(/&quot;/g, "");
                        globalPopupFileNo = zArray[2].trim().replace(/&quot;/g, "");
                        globalPopupUniqueId = zArray[3].trim().replace(/&quot;/g, "");
                        if (globalPopupUniqueId === "null") { globalPopupUniqueId = null; }
                    }
                }
                // SET THE TOTAL
                viewStandardGrid.txtTotalRecords(pEvent.responseJSON.total);
                // HIDE LOADING
                kendo.ui.progress($("#gridStandard"), false);
                viewStandardGrid.firstLoad = false;
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while completing grid load: " + pException.message);
                global.messageShow("txtMessage", "messageGridError");
            }
        },


        onMapDepictableComplete: function (pEvent, pField, pTitle) {
            // SET THE DEPICTED FIELD IN THE MVVM
            viewStandardGrid.mapDepictedNameCurrent = pField;
            viewStandardGrid.mapDepictedDisplayCurrent = pTitle;
            $("#txtDepictedBy").html(pTitle);
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewStandardGrid.clearMessage();
                    var zTextSortedBy = viewStandardGrid.gridStandard.getSortString();
                    var zTextFilteredBy = viewStandardGrid.gridStandard.getFilterString();
                    var zTextPinnedBy = viewStandardGrid.gridStandard.getPinnedString();
                    // REMOVE THE WORD "BAND"
                    if (zTextSortedBy.toLocaleLowerCase().indexOf("band") > -1) {
                        zTextSortedBy = zTextSortedBy.replace("Band", "");
                    }
                    if (zTextFilteredBy.toLocaleLowerCase().indexOf("band") > -1) {
                        zTextFilteredBy = zTextFilteredBy.replace("Band", "");
                    }
                    if (zTextPinnedBy.toLocaleLowerCase().indexOf("band") > -1) {
                        zTextPinnedBy = zTextPinnedBy.replace("Band", "");
                    }
                    // SET THE MESSAGE
                    if (viewStandardGrid.txtSortedBy() != zTextSortedBy) {
                        viewStandardGrid.txtSortedBy(zTextSortedBy);
                    }
                    if (viewStandardGrid.txtFilteredBy() != zTextFilteredBy) {
                        viewStandardGrid.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewStandardGrid.txtPinnedBy() != zTextPinnedBy) {
                        viewStandardGrid.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                viewStandardGrid.loadGridMeta(true);
                setTimeout(function () {
                    viewStandardGrid.gridStandard.clearFilter();
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while refreshing the grid: " + pException.message);
            }
        },


        openFormView: function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
            gOpenWindow(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
        },


        closeFormView: function () {
            //$(".k-hierarchy-cell .k-icon.k-minus").click();
        },


        setInspectionProgramYear: function () {
            try {
                var zCboInspectionProgramYear = document.getElementById(gCboInspectionProgramYear);
                var zValue = zCboInspectionProgramYear.value;
                var zText = zCboInspectionProgramYear.options[document.getElementById(gCboInspectionProgramYear).selectedIndex].text;
                if (zText === undefined || zText === null || zValue === undefined || zValue === null || zValue == 1 || zText.toLowerCase() == "(all)") {
                    viewStandardGrid.gridStandard.removeFilterByField("InspProgramYear");
                } else {
                    var zFilterNew = { filters: [], logic: "and" };
                    zFilterNew.filters.push({ field: "InspProgramYear", operator: "contains", value: zText });
                    viewStandardGrid.gridStandard.setFilterOverride(zFilterNew, "InspProgramYear");
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while filtering inspection program year: " + pException.message);
            }
        },
            
        // END GRID FUNCTIONS


        // START PICKLIST FUNCTIONS
        pickListCancel: function () {
            try {
                viewStandardGrid.clearMessage();
                if (viewStandardGrid.gridStandard != null) {
                    viewStandardGrid.gridStandard.pickListCancel();
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewStandardGrid.clearMessage();
                viewStandardGrid.gridStandard.pickListCheckAll();
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewStandardGrid.clearMessage();
                viewStandardGrid.gridStandard.pickListCheckNone();
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewStandardGrid.clearMessage();
                viewStandardGrid.gridStandard.pickListCheckReverse();
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewStandardGrid.clearMessage();
                viewStandardGrid.gridStandard.pickListApplyFilter();
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function () {
            viewStandardGrid.setupKendoWindow();
            viewStandardGrid.processLoading();
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewStandardGrid.gridStandard == null) {
                    var zFilter = null;
                    if (viewStandardGrid.largeObjectFilter !== undefined && viewStandardGrid.largeObjectFilter !== null) {
                        zFilter = JSON.parse(viewStandardGrid.largeObjectFilter);
                    }

                    viewStandardGrid.gridStandard = new utilKendoGrid();
                    viewStandardGrid.gridStandard.optionsConstant.isServerLoading = true;
                    //viewStandardGrid.gridStandard.optionsConstant.serviceMethod = "GET";
                    viewStandardGrid.gridStandard.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewStandardGrid.gridStandard.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData"; //IF USING GET, URL NEEDS TO BE UPDATED 
                    viewStandardGrid.gridStandard.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewStandardGrid.onGridLoadComplete(pEvent, pStatus); };
                    viewStandardGrid.gridStandard.optionsConstant.transportStartFunction = function (pEvent) { viewStandardGrid.onGridLoadStart(pEvent); };
                    viewStandardGrid.gridStandard.optionsConstant.setMapDepictableComplete = function (pEvent, pField, pTitle) { viewStandardGrid.onMapDepictableComplete(pEvent, pField, pTitle); };
                    viewStandardGrid.gridStandard.optionsConstant.serverLoadingNodeNameData = "data";
                    viewStandardGrid.gridStandard.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewStandardGrid.gridStandard.optionsConstant.detailTemplate = dsMetaData.detailTemplate;
                    viewStandardGrid.gridStandard.gSafeGuid = getGSafeGUID();
                    viewStandardGrid.gridStandard.setupOptions(true);
                    viewStandardGrid.gridStandard.pickListIgnoreColumns = [];
                    viewStandardGrid.gridStandard.optionsConstant.changeFunction = function (pEvent) { viewStandardGrid.onGridChange(pEvent); };
                    viewStandardGrid.gridStandard.mapDepictedNameDefault = viewStandardGrid.mapDepictedNameCurrent;
                    viewStandardGrid.gridStandard.mapDepictedNameCurrent = viewStandardGrid.mapDepictedNameCurrent;
                    viewStandardGrid.gridStandard.initGrid("#gridStandard", "#gridStandardContainer", "#windowPicklistStandard", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewStandardGrid.gridStandard.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewStandardGrid.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewStandardGrid.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (viewStandardGrid.windowFavorite == null) {
                    $("#windowFavorite").kendoWindow({
                        visible: false,
                        modal: true,
                        draggable: true,
                        resizable: false,
                        width: "575px",
                        height: "auto",
                        title: "Save Favorite",
                        actions: ["close"],
                        animation: { open: { effects: "default" }, close: { effects: "default" } },
                        refresh: function () { this.center(); }
                    });
                    viewStandardGrid.windowFavorite = $("#windowFavorite").data("kendoWindow");
                }
            } catch (pException) {
                viewStandardGrid.messageError("Error while building popup windows. " + pException.message);
                global.messageShow("messageError", "messageError");
            }
        },


        setupEvents: function () {
            $(window).resize(function () {
                var zWidth = $(window).width();
                if (zWidth > 1000 && viewStandardGrid.isMappable) {
                    $("#divTopInstructionsMap").fadeIn(1);
                    $(".messageNoticeNoBoldSmallMap").fadeIn(1);
                } else {
                    $("#divTopInstructionsMap").fadeOut(1);
                    $(".messageNoticeNoBoldSmallMap").fadeOut(1);
                }
            });

            $(document).mouseup(function (pEvent) {
                var container = $(".divDetailForm");
                if (
                    !container.is(pEvent.target) // if the target of the click isn't the container...
                    && container.has(pEvent.target).length === 0 // ... nor a descendant of the container
                    && pEvent.className != "k-icon k-plus"
                    && pEvent.className != "k-icon k-minus"
                ) {
                    viewStandardGrid.closeFormView();
                }
            });
            $("#" + gCboInspectionProgramYear).change(function () {
                viewStandardGrid.setInspectionProgramYear();
            });
            viewStandardGrid.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewStandardGrid, $("#viewStandardGrid")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },


        clearMessage: function (pMessage) {
            viewStandardGrid.txtMessage("");
        },


        processMessage: function (pMessage) {
            viewStandardGrid.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewStandardGrid.hideLoading();
        },


        processLoading: function () {
            viewStandardGrid.countLoading--;
            if (viewStandardGrid.countLoading < 1) {
                viewStandardGrid.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewStandardGrid.bindForm();
    viewStandardGrid.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    onEnterQoR = function (pFileNo) {
        var zGSafeGUID = getGSafeGUID();
        var zURL = "../../Redirect/QoRRedirect.aspx?sid=" + zGSafeGUID + "&FileNo=" + pFileNo;
        window.open(zURL);
    }

    onEditUserAccount = function (pEzyUserGuid) {
        var zGSafeGUID = getGSafeGUID();
        var zFolder = "UserAccount";
        var zLandingPage = "Default";
        window.location.href = "../../" + zFolder + "/" + zLandingPage + ".aspx?sid=" + zGSafeGUID + "&u1=" + pEzyUserGuid;
    }

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistStandard":
                viewStandardGrid.gridStandard.pickListCheck(pField, pId);
                break;
            default:
                viewStandardGrid.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

    globalOpenFormView = function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
        viewStandardGrid.openFormView(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
    }

    globalGoToFavories = function () {
        var zGSafeGUID = getGSafeGUID();
        var zURL = "../Favorites/Favorites.aspx?sid=" + zGSafeGUID;
        window.location.href = zURL;
    }

    globalSaveFavories = function () {
        viewStandardGrid.countLoading = 1;
        viewStandardGrid.loadFavorite();
    }

    globalCloseFormView = function () {
     //   viewStandardGrid.closeFormView();
    }

    globalDownloadData = function () {
        viewStandardGrid.setExtractData();
    }

    globalDownloadReport = function () {
        viewStandardGrid.setReportData();
    }

    globalDownloadChart = function () {
        viewStandardGrid.setChartData();
    }

    globalCreateBubbleChart = function () {
        viewStandardGrid.saveGridFilter();
    }

    refreshWindow = function () {
        viewStandardGrid.gridRefresh();
    }

});