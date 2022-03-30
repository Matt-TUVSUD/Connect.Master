$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsGridData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());

    // VIEW
    viewGrid = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,
        largeObjectHandler: null,
        favoriteList: ko.observableArray([]),
        favoriteName: ko.observable(""),

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


        // FUNCTIONS
        init: function () {
            viewGrid.countLoading = 4;
            viewGrid.loadDictionary();
            viewGrid.loadData();
            viewGrid.setupKendo();
            viewGrid.setupEvents();
        },


        loadDictionary: function () {
            viewGrid.processLoading();
        },


        loadData: function () {
            viewGrid.loadLargeObjectData();
            viewGrid.loadGridMeta();
        },


        // GET GRID FILTER CRITERIA
        loadLargeObjectData: function () {
            var zDocumentDate = getQueryVariable("documentdate");
            if (zDocumentDate) {
                viewGrid.gridCriteriaFilter = {
                    "logic": "and",
                    "filters": [{
                        "field": "documentdate",
                        "operator": "gte",
                        "value": getQueryVariable("documentdate")
                    }]
                };
            }
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewGrid.loadGridMetaSuccess, viewGrid.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewGrid.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
            }
        },
        loadGridMetaSuccess: function (pResults, pParms) {
            try {
                dsMetaData = pResults;
                // MAKE ANY CORRECTIONS TO POSSIBLE FUNCTIONS
                for (var x = 0; x < dsMetaData.columns.length; x++) {
                    if (dsMetaData.columns[x].template !== undefined && dsMetaData.columns[x].template !== null && dsMetaData.columns[x].template.indexOf("function") == 0) {
                        dsMetaData.columns[x].template = "var fn = " + dsMetaData.columns[x].template;
                        var zFn = eval(dsMetaData.columns[x].template);
                        dsMetaData.columns[x].template = fn;
                    }
                }
            } catch (pException) {
                viewGrid.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewGrid.processLoading();
            viewGrid.setupKendoGrid(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewGrid.processMessage("Error while loading meta data. " + pMessage);
        },


        // EXTRACT AND REPORT FUNCTIONS
        setExtractData: function () {
            viewGrid.largeObjectHandler = "../../FD/ServeExtract.ashx";
            viewGrid.setLargeObjectData();
        },


        setReportData: function () {
            viewGrid.largeObjectHandler = "../../Reports/ReportHandler.ashx";
            viewGrid.setLargeObjectData();
        },


        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = [];
                if (viewGrid.gridStandard.grid.dataSource.sort()) {
                    zSort = JSON.stringify(viewGrid.gridStandard.grid.dataSource.sort());
                }
                if (viewGrid.gridStandard.grid.dataSource.filter()) {
                    zFilter = JSON.stringify(viewGrid.gridStandard.grid.dataSource.filter());
                }
                if (viewGrid.gridCriteriaFilter) {
                    zCriteria = JSON.stringify(viewGrid.gridCriteriaFilter);
                }
                for (var x = 0; x < viewGrid.gridStandard.grid.columns.length; x++) {
                    zColumnOrder.push(viewGrid.gridStandard.grid.columns[x].field);
                }
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "gridId": 0,
                    "sort": zSort,
                    "filter": zFilter,
                    "criteria": zCriteria,
                    "meta": null,
                    "columnOrder": JSON.stringify(zColumnOrder)
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewGrid.setLargeObjectDataSuccess, viewGrid.setLargeObjectDataError, null);
            } catch (pException) {
                viewGrid.processMessage("An error occurred while starting the grid extract call: " + pException.message);
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
                    var zURL = viewGrid.largeObjectHandler + "?action=PrintGridReport&sid=" + getGSafeGUID() + zUserCurrencyId;
                    window.location.href = zURL;
                } else {
                    viewGrid.processMessage("An error occurred while building grid extract data: " + pResults.message);
                }
            } catch (pException) {
                viewGrid.processMessage("An error occurred while building grid extract data: " + pException.message);
            }
            viewGrid.processLoading();
            viewGrid.setupKendoGrid();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewGrid.processMessage("Error while setting extract data. " + pMessage);
            viewGrid.processLoading();
        },
        // END EXTRACT FUNCTIONS


        // FAVORITES FUNCTIONS
        loadFavorite: function () {
            try {
                viewGrid.favoriteList([]);
                viewGrid.favoriteName("");
                var zServiceName = "GetGridFavoriteListByGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewGrid.loadFavoriteSuccess, viewGrid.loadFavoriteError, null);
            } catch (pException) {
                viewGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        loadFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    if (pResults.data) {
                        for (var x = 0; x < pResults.data.length; x++) {
                            if (pResults.data[x].colFldTitle) {
                                viewGrid.favoriteList.push({
                                    id: pResults.data[x].colId,
                                    title: pResults.data[x].colFldTitle
                                });
                            }
                        }
                    }
                    viewGrid.windowFavorite.center().open();
                } else {
                    viewGrid.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                viewGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewGrid.processLoading();
        },
        loadFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewGrid.windowFavorite.center().open();
            viewGrid.processMessage("Error while calling the save favorite service. " + pMessage);
        },


        setFavorite: function () {
            try {
                // VALIDATE THE NAME
                var zTitle = viewGrid.favoriteName();
                var zIsValid = true;
                var zIsCopy = false;
                var zIsCopyId = 0;
                if (zTitle === undefined || zTitle === null || zTitle.length < 1) {
                    zIsValid = false;
                    alert("Please enter a name for the favorite.");
                }
                for (var x = 0; x < viewGrid.favoriteList().length; x++) {
                    if (zTitle == viewGrid.favoriteList()[x].title) {
                        var zYesNo = confirm("The favorite [" + zTitle + "] already exists.  Do you want to overwrite?");
                        if (zYesNo) {
                            zIsCopy = true;
                            zIsCopyId = viewGrid.favoriteList()[x].id;
                        } else {
                            zIsValid = false;
                        }
                        break;
                    }
                }

                if (zIsValid) {
                    // GATHER INFORMATION
                    //gSafeGuid As String, pTitle As String, pColumnOrderSetting As String, pSort As String, pFilter As String, pCriteria As String
                    var zSort = JSON.stringify(viewGrid.gridStandard.grid.dataSource.sort());
                    var zFilter = JSON.stringify(viewGrid.gridStandard.grid.dataSource.filter());
                    var zCriteria = viewGrid.gridCriteriaFilter;
                    var zColumnOrder = [];
                    for (var x = 0; x < viewGrid.gridStandard.grid.columns.length; x++) {
                        zColumnOrder.push({
                            locked: viewGrid.gridStandard.grid.columns[x].locked,
                            field: viewGrid.gridStandard.grid.columns[x].field
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
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewGrid.setFavoriteSuccess, viewGrid.setFavoriteError, null);
                }
            } catch (pException) {
                viewGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        setFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewGrid.windowFavorite.close();
                } else {
                    alert("An error occurred while saving your favorites data: " + pResults.message);
                    viewGrid.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                alert("An error occurred while saving your favorites data: " + pException.message);
                viewGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewGrid.processLoading();
        },
        setFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            alert("Error while calling the save favorite service. " + pMessage);
            viewGrid.processMessage("Error while calling the save favorite service. " + pMessage);
        },


        onFavoriteSave: function () {
            viewGrid.setFavorite();
        },


        onFavoriteCancel: function () {
            viewGrid.windowFavorite.close();
            viewGrid.favoriteList([]);
            viewGrid.favoriteName("");
        },
        // END FAVORITES FUNCTIONS


        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewGrid.txtMessage("Loading...");
            global.messageShow("txtMessage", "messageGridNormal");
        },


        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewGrid.txtMessage("");
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
                viewGrid.txtTotalRecords(pEvent.responseJSON.total);
                kendo.ui.progress($("#gridStandard"), false);
            } catch (pException) {
                viewGrid.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewGrid.txtMessage("");
                    var zTextSortedBy = viewGrid.gridStandard.getSortString();
                    var zTextFilteredBy = viewGrid.gridStandard.getFilterString();
                    var zTextPinnedBy = viewGrid.gridStandard.getPinnedString();
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
                    if (viewGrid.txtSortedBy() != zTextSortedBy) {
                        viewGrid.txtSortedBy(zTextSortedBy);
                    }
                    if (viewGrid.txtFilteredBy() != zTextFilteredBy) {
                        viewGrid.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewGrid.txtPinnedBy() != zTextPinnedBy) {
                        viewGrid.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewGrid.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                viewGrid.gridStandard.clearFilter();
                setTimeout(function () {
                    viewGrid.loadGridMeta(true);
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewGrid.processMessage("An error occurred while refreshing the grid: " + pException.message);
            }
        },


        openFormView: function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
            gOpenWindow(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
        },


        closeFormView: function () {
            $(".k-hierarchy-cell .k-icon.k-minus").click();
        },
        // END GRID FUNCTIONS


        // START PICKLIST FUNCTIONS
        pickListCancel: function () {
            try {
                viewGrid.txtMessage("");
                if (viewGrid.gridStandard != null) {
                    viewGrid.gridStandard.pickListCancel();
                }
            } catch (pException) {
                viewGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewGrid.txtMessage("");
                viewGrid.gridStandard.pickListCheckAll();
            } catch (pException) {
                viewGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewGrid.txtMessage("");
                viewGrid.gridStandard.pickListCheckNone();
            } catch (pException) {
                viewGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewGrid.txtMessage("");
                viewGrid.gridStandard.pickListCheckReverse();
            } catch (pException) {
                viewGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewGrid.txtMessage("");
                viewGrid.gridStandard.pickListApplyFilter();
            } catch (pException) {
                viewGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function () {
            viewGrid.setupKendoWindow();
            viewGrid.processLoading();
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewGrid.gridStandard == null) {
                    var zFilter = null;
                    if (viewGrid.largeObjectFilter !== undefined && viewGrid.largeObjectFilter !== null) {
                        zFilter = JSON.parse(viewGrid.largeObjectFilter);
                    }
                    viewGrid.gridStandard = new utilKendoGrid();
                    viewGrid.gridStandard.optionsConstant.isServerLoading = true;
                    viewGrid.gridStandard.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewGrid.gridStandard.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData";
                    viewGrid.gridStandard.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewGrid.onGridLoadComplete(pEvent, pStatus); };
                    viewGrid.gridStandard.optionsConstant.transportStartFunction = function (pEvent) { viewGrid.onGridLoadStart(pEvent); };
                    viewGrid.gridStandard.optionsConstant.serverLoadingNodeNameData = "data";
                    viewGrid.gridStandard.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewGrid.gridStandard.optionsConstant.detailTemplate = dsMetaData.detailTemplate;
                    viewGrid.gridStandard.optionsConstant.criteriaFilter = viewGrid.gridCriteriaFilter;
                    viewGrid.gridStandard.gSafeGuid = getGSafeGUID();
                    viewGrid.gridStandard.setupOptions(true);
                    viewGrid.gridStandard.pickListIgnoreColumns = [];
                    viewGrid.gridStandard.optionsConstant.changeFunction = function (pEvent) { viewGrid.onGridChange(pEvent); };
                    viewGrid.gridStandard.initGrid("#gridStandard", "#gridStandardContainer", "#windowPicklistStandard", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewGrid.gridStandard.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewGrid.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewGrid.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (viewGrid.windowFavorite == null) {
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
                    viewGrid.windowFavorite = $("#windowFavorite").data("kendoWindow");
                }
            } catch (pException) {
                viewGrid.messageError("Error while building popup windows. " + pException.message);
                global.messageShow("messageError", "messageError");
            }
        },


        setupEvents: function () {
            $(document).mouseup(function (pEvent) {
                var container = $(".divDetailForm");
                if (
                    !container.is(pEvent.target) // if the target of the click isn't the container...
                    && container.has(pEvent.target).length === 0 // ... nor a descendant of the container
                    && pEvent.className != "k-icon k-plus"
                    && pEvent.className != "k-icon k-minus"
                ) {
                    viewGrid.closeFormView();
                }
            });
            viewGrid.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewGrid, $("#viewGrid")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },

        processMessage: function (pMessage) {
            viewGrid.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewGrid.hideLoading();
        },

        processLoading: function () {
            viewGrid.countLoading--;
            if (viewGrid.countLoading < 1) {
                viewGrid.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewGrid.bindForm();
    viewGrid.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    onEnterLocation = function (pFileNo, pPracticeFolder) {
        var zGSafeGUID = getGSafeGUID();
        window.location.href = "../../" + pPracticeFolder + "/locationdetails.aspx?sid=" + zGSafeGUID + "&p1=" + pFileNo;
    }

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistStandard":
                viewGrid.gridStandard.pickListCheck(pField, pId);
                break;
            default:
                viewGrid.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

    globalDownloadData = function () {
        viewGrid.setExtractData();
    }

    globalDownloadReport = function () {
        viewGrid.setReportData();
    }

    globalGoToFavories = function () {
        var zGSafeGUID = getGSafeGUID();
        var zURL = "../Favorites/Favorites.aspx?sid=" + zGSafeGUID;
        window.location.href = zURL;
    }

    globalSaveFavories = function () {
        viewGrid.countLoading = 1;
        viewGrid.loadFavorite();
    }

    globalOpenFormView = function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
        viewGrid.openFormView(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
    }

    globalCloseFormView = function () {
        viewGrid.closeFormView();
    }

    refreshWindow = function () {
        viewGrid.gridRefresh();
    }

});
