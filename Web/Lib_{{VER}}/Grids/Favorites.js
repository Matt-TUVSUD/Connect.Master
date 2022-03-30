$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsGridData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());

    // VIEW
    viewFavoritesGrid = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,
        largeObjectHandler: null,
        favoriteRenameName: ko.observable(""),
        currentFavoriteId: null,

        // LARGE OBJECT DATA
        largeObjectFilter: null,
        largeObjectCriteria: null,
        largeObjectSort: null,
        largeObjectMeta: null,
        
        // LABELS
        txtMessage: ko.observable(),
        txtMessageRename: ko.observable(),
        txtSortedBy: ko.observable(),
        txtFilteredBy: ko.observable(),
        txtPinnedBy: ko.observable(),
        txtTotalRecords: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS

        // KENDO OBJECTS
        gridFavorites: null,
        windowRenameFavorite: null,


        // FUNCTIONS
        init: function () {
            viewFavoritesGrid.countLoading = 5;
            viewFavoritesGrid.loadLargeObjectData();
            viewFavoritesGrid.loadDictionary();
            //viewFavoritesGrid.loadData(); // AFTER LARGE OBJECT SUCCESS
            viewFavoritesGrid.setupKendo();
            viewFavoritesGrid.setupEvents();
        },


        loadDictionary: function () {
            viewFavoritesGrid.processLoading();
        },


        loadLargeObjectData: function () {
            try {
                var zServiceName = "GetLargeObjectDataGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFavoritesGrid.loadLargeObjectDataSuccess, viewFavoritesGrid.loadLargeObjectDataError, null);
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while starting the large object data load call: " + pException.message);
            }
        },
        loadLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // STORE THE LARGE OBJECT DATA
                    if (pResults.data.filter !== undefined && pResults.data.filter !== null && pResults.data.filter !== "") {
                        viewFavoritesGrid.largeObjectFilter = pResults.data.filter;
                    }
                    if (pResults.data.criteria !== undefined && pResults.data.criteria !== null && pResults.data.criteria !== "") {
                        viewFavoritesGrid.largeObjectCriteria = pResults.data.criteria;
                    }
                    if (pResults.data.sort !== undefined && pResults.data.sort !== null && pResults.data.sort !== "") {
                        viewFavoritesGrid.largeObjectSort = pResults.data.sort;
                    }
                    if (pResults.data.meta !== undefined && pResults.data.meta !== null && pResults.data.meta !== "") {
                        viewFavoritesGrid.largeObjectMeta = pResults.data.meta;
                    }
                } else {
                    viewFavoritesGrid.processMessage("An error occurred while loading large object data: " + pResults.message);
                }
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while loading large object data: " + pException.message);
            }
            viewFavoritesGrid.processLoading();
            viewFavoritesGrid.loadData();
        },
        loadLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFavoritesGrid.processMessage("Error while loading large object data. " + pMessage);
            viewFavoritesGrid.processLoading();
        },


        loadData: function () {
            viewFavoritesGrid.loadGridMeta();
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFavoritesGrid.loadGridMetaSuccess, viewFavoritesGrid.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
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
                viewFavoritesGrid.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewFavoritesGrid.processLoading();
            viewFavoritesGrid.setupKendoGrid(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFavoritesGrid.processMessage("Error while loading meta data. " + pMessage);
        },


        // EXTRACT AND REPORT FUNCTIONS
        setExtractData: function () {
            viewFavoritesGrid.largeObjectHandler = "../../FD/ServeExtract.ashx";
            viewFavoritesGrid.setLargeObjectData();
        },


        setReportData: function () {
            viewFavoritesGrid.largeObjectHandler = "../../Reports/ReportHandler.ashx";
            viewFavoritesGrid.setLargeObjectData();
        },


        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = [];
                if (viewFavoritesGrid.largeObjectSort === null) {
                    if (viewFavoritesGrid.gridFavorites.grid.dataSource.sort()) {
                        zSort = JSON.stringify(viewFavoritesGrid.gridFavorites.grid.dataSource.sort()); 
                    }
                } else {
                    zSort = viewFavoritesGrid.largeObjectSort;
                }
                if (viewFavoritesGrid.largeObjectFilter === null) {
                    if (viewFavoritesGrid.gridFavorites.grid.dataSource.filter()) {
                        zFilter = JSON.stringify(viewFavoritesGrid.gridFavorites.grid.dataSource.filter()); 
                    }
                } else {
                    zFilter = viewFavoritesGrid.largeObjectFilter;
                }
                if (viewFavoritesGrid.largeObjectCriteria === null) {
                    if (viewFavoritesGrid.gridCriteriaFilter) {
                        zCriteria = JSON.stringify(viewFavoritesGrid.gridCriteriaFilter);
                    }
                } else {
                    zCriteria = viewFavoritesGrid.largeObjectCriteria;
                }
                for (var x = 0; x < viewFavoritesGrid.gridFavorites.grid.columns.length; x++) {
                    zColumnOrder.push(viewFavoritesGrid.gridFavorites.grid.columns[x].field);
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFavoritesGrid.setLargeObjectDataSuccess, viewFavoritesGrid.setLargeObjectDataError, null);
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while starting the grid extract call: " + pException.message);
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
                    var zURL = viewFavoritesGrid.largeObjectHandler + "?action=PrintGridReport&gSafeGuid=" + getGSafeGUID() + zUserCurrencyId;
                    window.location.href = zURL;
                } else {
                    viewFavoritesGrid.processMessage("An error occurred while building grid extract data: " + pResults.message);
                }
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while building grid extract data: " + pException.message);
            }
            viewFavoritesGrid.processLoading();
            viewFavoritesGrid.setupKendoGrid();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFavoritesGrid.processMessage("Error while setting extract data. " + pMessage);
            viewFavoritesGrid.processLoading();
        },
        // END EXTRACT FUNCTIONS


        // FAVORITES FUNCTIONS
        onFavoriteRenameSave: function () {
            viewFavoritesGrid.favoriteRenameSave();
        },


        onFavoriteRenameCancel: function () {
            viewFavoritesGrid.favoriteRenameName("");
            viewFavoritesGrid.txtMessageRename("");
            viewFavoritesGrid.windowRenameFavorite.close();
        },
        

        favoriteRecall: function (pFavId, pGridId) {
            var windowObjectReference = null;
            var PreviousUrl;
            var zGSafeGUID = getGSafeGUID();
            var strUrl = "FavoritesRedirect.aspx?sid=" + zGSafeGUID + "&gridId=" + pGridId + "&favId=" + pFavId;

            ////window.document.location.href = "FavoritesRedirect.aspx?sid=" + zGSafeGUID + "&gridId=" + pGridId + "&favId=" + pFavId;
            //window.open("FavoritesRedirect.aspx?sid=" + zGSafeGUID + "&gridId=" + pGridId + "&favId=" + pFavId, '_blank'); // <- This is what makes it open in a new window.;

            // NAVIGATE TO THE CORRECT AREA
            if (windowObjectReference == null || windowObjectReference == undefined || windowObjectReference.closed) {
                // IF THE WINDOW DOWN NOT EXIST, OPEN A NEW ONE
                var zOptions = "" +
                    "resizable=yes" +
                    ",scrollbars=yes" +
                    ",status=yes" +
                    ",left=0" +
                    ",top=0" +
                    ",width=" + screen.width * 0.99 +
                    ",height=" + screen.height * 0.90;
                windowObjectReference = window.open(strUrl, "SingleSecondaryWindowName", zOptions);
                windowObjectReference.focus();
            }
            else if (PreviousUrl != strUrl) {
                // IF THE WINDOW EXISTS AND THE URL IS NEW, CHANGE THE URL OF THE OPEN WINDOW
                windowObjectReference.location.href = strUrl;
                windowObjectReference.focus();
            }
            else {
                // IF THE WINDOW EXISTS AND THE URL IS THE SAME, MAKE WINDOW ON TOP
                windowObjectReference.focus();
            };
            PreviousUrl = strUrl;
        },


        favoriteRename: function (pId, pTitle) {
            viewFavoritesGrid.currentFavoriteId = pId;
            viewFavoritesGrid.favoriteRenameName(pTitle);
            viewFavoritesGrid.txtMessageRename("");
            viewFavoritesGrid.windowRenameFavorite.center().open();
        },



        favoriteRenameSave: function () {
            try {
                if (viewFavoritesGrid.favoriteRenameName() === undefined || viewFavoritesGrid.favoriteRenameName() === null || viewFavoritesGrid.favoriteRenameName().length < 1) {
                    viewFavoritesGrid.txtMessageRename("Please enter a name that you would like to save for this favorite.");
                    global.messageShow("txtMessageRename", "messageGridError");
                    //alert("Please enter a name that you would like to save for this favorite.");
                } else {
                    var zServiceName = "RenameGridFavorite";
                    var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID(),
                        "pId": viewFavoritesGrid.currentFavoriteId,
                        "pName": viewFavoritesGrid.favoriteRenameName()
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFavoritesGrid.favoriteRenameSuccess, viewFavoritesGrid.favoriteRenameError, null);
                }
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while starting the favorite rename data call: " + pException.message);
            }
        },
        favoriteRenameSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewFavoritesGrid.gridRefresh();
                    viewFavoritesGrid.windowRenameFavorite.close();
                } else {
                    viewFavoritesGrid.txtMessageRename("An error occurred while renaming the grid favorite: " + pResults.message);
                    global.messageShow("txtMessageRename", "messageGridError");
                }
            } catch (pException) {
                viewFavoritesGrid.txtMessageRename("An error occurred while renaming the favorite: " + pException.message);
                global.messageShow("txtMessageRename", "messageGridError");
            }
            viewFavoritesGrid.processLoading();
        },
        favoriteRenameError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFavoritesGrid.txtMessageRename("Error while loading renaming the favorite. " + pMessage);
            global.messageShow("txtMessageRename", "messageGridError");
        },


        favoriteDelete: function (pId) {
            try {
                var zServiceName = "DeleteGridFavorite";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "pId": pId
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFavoritesGrid.favoriteDeleteSuccess, viewFavoritesGrid.favoriteDeleteError, null);
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while starting the favorite delete data call: " + pException.message);
            }
        },
        favoriteDeleteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewFavoritesGrid.gridRefresh();
                } else {
                    viewFavoritesGrid.processMessage("An error occurred while deleting the grid favorite: " + pResults.message);
                }
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while deleting the favorite: " + pException.message);
            }
            viewFavoritesGrid.processLoading();
        },
        favoriteDeleteError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFavoritesGrid.processMessage("Error while loading deleting the favorite. " + pMessage);
        },
        // END FAVORITES FUNCTIONS


        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewFavoritesGrid.txtMessage("Loading...");
            global.messageShow("txtMessage", "messageGridNormal");
        },


        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewFavoritesGrid.txtMessage("");
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
                viewFavoritesGrid.txtTotalRecords(pEvent.responseJSON.total);
                kendo.ui.progress($("#gridFavorites"), false);
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewFavoritesGrid.txtMessage("");
                    var zTextSortedBy = viewFavoritesGrid.gridFavorites.getSortString();
                    var zTextFilteredBy = viewFavoritesGrid.gridFavorites.getFilterString();
                    var zTextPinnedBy = viewFavoritesGrid.gridFavorites.getPinnedString();
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
                    if (viewFavoritesGrid.txtSortedBy() != zTextSortedBy) {
                        viewFavoritesGrid.txtSortedBy(zTextSortedBy);
                    }
                    if (viewFavoritesGrid.txtFilteredBy() != zTextFilteredBy) {
                        viewFavoritesGrid.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewFavoritesGrid.txtPinnedBy() != zTextPinnedBy) {
                        viewFavoritesGrid.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                viewFavoritesGrid.gridFavorites.clearFilter();
                setTimeout(function () {
                    viewFavoritesGrid.loadGridMeta(true);
                    // RESET META DATA HERE
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while refreshing the grid: " + pException.message);
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
                viewFavoritesGrid.txtMessage("");
                if (viewFavoritesGrid.gridFavorites != null) {
                    viewFavoritesGrid.gridFavorites.pickListCancel();
                }
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewFavoritesGrid.txtMessage("");
                viewFavoritesGrid.gridFavorites.pickListCheckAll();
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewFavoritesGrid.txtMessage("");
                viewFavoritesGrid.gridFavorites.pickListCheckNone();
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewFavoritesGrid.txtMessage("");
                viewFavoritesGrid.gridFavorites.pickListCheckReverse();
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewFavoritesGrid.txtMessage("");
                viewFavoritesGrid.gridFavorites.pickListApplyFilter();
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function () {
            viewFavoritesGrid.setupKendoWindow();
            viewFavoritesGrid.processLoading();
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewFavoritesGrid.gridFavorites == null) {
                    var zFilter = null;
                    if (viewFavoritesGrid.largeObjectFilter !== undefined && viewFavoritesGrid.largeObjectFilter !== null) {
                        zFilter = JSON.parse(viewFavoritesGrid.largeObjectFilter);
                    }
                    viewFavoritesGrid.gridFavorites = new utilKendoGrid();
                    viewFavoritesGrid.gridFavorites.optionsConstant.isServerLoading = true;
                    viewFavoritesGrid.gridFavorites.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewFavoritesGrid.gridFavorites.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData";
                    viewFavoritesGrid.gridFavorites.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewFavoritesGrid.onGridLoadComplete(pEvent, pStatus); };
                    viewFavoritesGrid.gridFavorites.optionsConstant.transportStartFunction = function (pEvent) { viewFavoritesGrid.onGridLoadStart(pEvent); };
                    viewFavoritesGrid.gridFavorites.optionsConstant.serverLoadingNodeNameData = "data";
                    viewFavoritesGrid.gridFavorites.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewFavoritesGrid.gridFavorites.optionsConstant.detailTemplate = dsMetaData.detailTemplate;
                    viewFavoritesGrid.gridFavorites.gSafeGuid = getGSafeGUID();
                    viewFavoritesGrid.gridFavorites.setupOptions(true);
                    viewFavoritesGrid.gridFavorites.pickListIgnoreColumns = [];
                    viewFavoritesGrid.gridFavorites.optionsConstant.changeFunction = function (pEvent) { viewFavoritesGrid.onGridChange(pEvent); };
                    viewFavoritesGrid.gridFavorites.initGrid("#gridFavorites", "#gridFavoritesContainer", "#windowPicklistStandard", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewFavoritesGrid.gridFavorites.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewFavoritesGrid.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewFavoritesGrid.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (viewFavoritesGrid.windowRenameFavorite == null) {
                    $("#windowRenameFavorite").kendoWindow({
                        visible: false,
                        modal: true,
                        draggable: true,
                        resizable: false,
                        width: "575px",
                        height: "auto",
                        title: "Rename Favorite",
                        actions: ["close"],
                        animation: { open: { effects: "default" }, close: { effects: "default" } },
                        refresh: function () { this.center(); }
                    });
                    viewFavoritesGrid.windowRenameFavorite = $("#windowRenameFavorite").data("kendoWindow");
                }
            } catch (pException) {
                viewFavoritesGrid.messageError("Error while building popup windows. " + pException.message);
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
                    viewFavoritesGrid.closeFormView();
                }
            });
            viewFavoritesGrid.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewFavoritesGrid, $("#viewFavoritesGrid")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },


        processLoading: function () {
            viewFavoritesGrid.countLoading--;
            if (viewFavoritesGrid.countLoading < 1) {
                viewFavoritesGrid.hideLoading();
            } else {
            }
        },
        

        processMessage: function (pMessage) {
            viewFavoritesGrid.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewFavoritesGrid.hideLoading();
        }
    };


    // BIND AND INIT FORM
    viewFavoritesGrid.bindForm();
    viewFavoritesGrid.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    onEnterQoR = function (pFileNo) {
        var zGSafeGUID = getGSafeGUID();
        var zURL = "../../Redirect/QoRRedirect.aspx?sid=" + zGSafeGUID + "&FileNo=" + pFileNo;
        window.open(zURL);
    }

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistStandard":
                viewFavoritesGrid.gridFavorites.pickListCheck(pField, pId);
                break;
            default:
                viewFavoritesGrid.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

    globalOpenFormView = function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
        viewFavoritesGrid.openFormView(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
    }

    globalCloseFormView = function () {
        viewFavoritesGrid.closeFormView();
    }

    globalDownloadData = function () {
        viewFavoritesGrid.setExtractData();
    }

    globalDownloadReport = function () {
        viewFavoritesGrid.setReportData();
    }

    globalFavoriteRecall = function (pFavId, pGridId) {
        viewFavoritesGrid.favoriteRecall(pFavId, pGridId);
    }

    globalFavoriteRename = function (pId, pTitle) {
        viewFavoritesGrid.favoriteRename(pId, pTitle);
    }

    globalFavoriteDelete = function (pId, pTitle) {
        var zYesNo = confirm("Are you sure you want to delete the grid favorite named '" + pTitle + "'?");
        if (zYesNo) {
            viewFavoritesGrid.favoriteDelete(pId);
        }
    }

    refreshWindow = function () {
        viewFavoritesGrid.gridRefresh();
    }

});
