$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());

    // VIEW
    viewLocList = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,
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
        gridLocList: null,
        windowFavorite: null,


        // FUNCTIONS
        init: function () {
            viewLocList.countLoading = 6;
            viewLocList.loadGridFilterCriteria();
            viewLocList.loadDictionary();
            viewLocList.loadData();
            viewLocList.setupKendo();
            viewLocList.setupEvents();
        },


        loadDictionary: function () {
            viewLocList.processLoading();
        },


        // GET GRID FILTER CRITERIA
        loadGridFilterCriteria: function () {
        },


        loadData: function () {
            viewLocList.loadGridMeta();
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewLocList.loadGridMetaSuccess, viewLocList.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewLocList.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
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
                viewLocList.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewLocList.processLoading();
            viewLocList.setupKendoGrid(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewLocList.processMessage("Error while loading meta data. " + pMessage);
        },


        // EXTRACT AND REPORT FUNCTIONS
        setExtractData: function () {
            viewLocList.largeObjectHandler = "../../FD/ServeExtract.ashx";
            viewLocList.setLargeObjectData();
        },


        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = [];
                //if (viewLocList.largeObjectSort === null) {
                //    if (viewLocList.gridStandard.grid.dataSource.sort()) {
                //    }
                //} else {
                //    zSort = viewLocList.largeObjectSort;
                //}

                // Changed by Daniel on Oct 11, 2016 to always read the current sort from the interactive grid control
                zSort = JSON.stringify(viewLocList.gridLocList.grid.dataSource.sort());

                //if (viewLocList.largeObjectFilter === null) {
                //    if (viewLocList.gridStandard.grid.dataSource.filter()) {
                //        zFilter = JSON.stringify(viewLocList.gridStandard.grid.dataSource.filter()); 
                //    }
                //} else {
                //	zFilter = viewLocList.largeObjectFilter;
                //}

                // Changed by Daniel on Oct 11, 2016 to always read the current filter from the interactive grid control
                zFilter = JSON.stringify(viewLocList.gridLocList.grid.dataSource.filter());

                if (viewLocList.largeObjectCriteria === null) {
                    if (viewLocList.gridCriteriaFilter) {
                        zCriteria = JSON.stringify(viewLocList.gridCriteriaFilter);
                    }
                } else {
                    zCriteria = viewLocList.largeObjectCriteria;
                }
                for (var x = 0; x < viewLocList.gridLocList.grid.columns.length; x++) {
                    zColumnOrder.push(viewLocList.gridLocList.grid.columns[x].field);
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewLocList.setLargeObjectDataSuccess, viewLocList.setLargeObjectDataError, null);
            } catch (pException) {
                viewLocList.processMessage("An error occurred while starting the grid extract call: " + pException.message);
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
                    if (viewLocList.useReportId2) { zUseReport2Parm = "&useReport2=true"; }

                    var zURL = viewLocList.largeObjectHandler + "?action=PrintGridReport&sid=" + getGSafeGUID() + zUserCurrencyId + zUseReport2Parm;
                    window.location.href = zURL;
                } else {
                    viewLocList.processMessage("An error occurred while building grid extract data: " + pResults.message);
                }
            } catch (pException) {
                viewLocList.processMessage("An error occurred while building grid extract data: " + pException.message);
            }
            viewLocList.processLoading();
            viewLocList.setupKendoGrid();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewLocList.processMessage("Error while setting extract data. " + pMessage);
            viewLocList.processLoading();
        },
        // END EXTRACT FUNCTIONS

        // FAVORITES FUNCTIONS
        loadFavorite: function () {
            try {
                viewLocList.favoriteList([]);
                viewLocList.favoriteName("");
                var zServiceName = "GetGridFavoriteListByGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewLocList.loadFavoriteSuccess, viewLocList.loadFavoriteError, null);
            } catch (pException) {
                viewLocList.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        loadFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    if (pResults.data) {
                        for (var x = 0; x < pResults.data.length; x++) {
                            if (pResults.data[x].colFldTitle) {
                                viewLocList.favoriteList.push({
                                    id: pResults.data[x].colId,
                                    title: pResults.data[x].colFldTitle
                                });
                            }
                        }
                    }
                    viewLocList.windowFavorite.center().open();
                } else {
                    viewLocList.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                viewLocList.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewLocList.processLoading();
        },
        loadFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewLocList.windowFavorite.center().open();
            viewLocList.processMessage("Error while calling the save favorite service. " + pMessage);
        },

        setFavorite: function () {
            try {
                // VALIDATE THE NAME
                var zTitle = viewLocList.favoriteName();
                var zIsValid = true;
                var zIsCopy = false;
                var zIsCopyId = 0;
                if (zTitle === undefined || zTitle === null || zTitle.length < 1) {
                    zIsValid = false;
                    alert("Please enter a name for the favorite.");
                }
                for (var x = 0; x < viewLocList.favoriteList().length; x++) {
                    if (zTitle == viewLocList.favoriteList()[x].title) {
                        var zYesNo = confirm("The favorite [" + zTitle + "] already exists.  Do you want to overwrite?");
                        if (zYesNo) {
                            zIsCopy = true;
                            zIsCopyId = viewLocList.favoriteList()[x].id;
                        } else {
                            zIsValid = false;
                        }
                        break;
                    }
                }

                if (zIsValid) {
                    // GATHER INFORMATION
                    //gSafeGuid As String, pTitle As String, pColumnOrderSetting As String, pSort As String, pFilter As String, pCriteria As String
                    var zSort = JSON.stringify(viewLocList.gridStandard.grid.dataSource.sort());
                    var zFilter = JSON.stringify(viewLocList.gridStandard.grid.dataSource.filter());
                    var zCriteria = viewLocList.gridCriteriaFilter;
                    var zColumnOrder = [];
                    for (var x = 0; x < viewLocList.gridStandard.grid.columns.length; x++) {
                        zColumnOrder.push({
                            locked: viewLocList.gridStandard.grid.columns[x].locked,
                            field: viewLocList.gridStandard.grid.columns[x].field
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
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewLocList.setFavoriteSuccess, viewLocList.setFavoriteError, null);
                }
            } catch (pException) {
                viewLocList.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        setFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewLocList.windowFavorite.close();
                } else {
                    alert("An error occurred while saving your favorites data: " + pResults.message);
                    viewLocList.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                alert("An error occurred while saving your favorites data: " + pException.message);
                viewLocList.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewLocList.processLoading();
        },
        setFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            alert("Error while calling the save favorite service. " + pMessage);
            viewLocList.processMessage("Error while calling the save favorite service. " + pMessage);
        },


        onFavoriteSave: function () {
            viewLocList.setFavorite();
        },

        // END FAVORITES FUNCTIONS

        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewLocList.processLoading();
            global.messageShow("txtMessage", "messageGridNormal");
        },


        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewLocList.txtMessage("");
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
                viewLocList.txtTotalRecords(pEvent.responseJSON.total);
            } catch (pException) {
                viewLocList.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewLocList.txtMessage("");
                    var zTextSortedBy = viewLocList.gridLocList.getSortString();
                    var zTextFilteredBy = viewLocList.gridLocList.getFilterString();
                    var zTextPinnedBy = viewLocList.gridLocList.getPinnedString();
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
                    if (viewLocList.txtSortedBy() != zTextSortedBy) {
                        viewLocList.txtSortedBy(zTextSortedBy);
                    }
                    if (viewLocList.txtFilteredBy() != zTextFilteredBy) {
                        viewLocList.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewLocList.txtPinnedBy() != zTextPinnedBy) {
                        viewLocList.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewLocList.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                
                viewLocList.gridLocList.clearFilter();
                setTimeout(function () {
                    viewLocList.loadGridMeta(true);
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewLocList.processMessage("An error occurred while refreshing the grid: " + pException.message);
            }
        },

        // END GRID FUNCTIONS


        // START PICKLIST FUNCTIONS
        pickListCancel: function () {
            try {
                viewLocList.txtMessage("");
                if (viewLocList.gridLocList != null) {
                    viewLocList.gridLocList.pickListCancel();
                }
            } catch (pException) {
                viewLocList.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewLocList.txtMessage("");
                viewLocList.gridLocList.pickListCheckAll();
            } catch (pException) {
                viewLocList.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewLocList.txtMessage("");
                viewLocList.gridLocList.pickListCheckNone();
            } catch (pException) {
                viewLocList.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewLocList.txtMessage("");
                viewLocList.gridLocList.pickListCheckReverse();
            } catch (pException) {
                viewLocList.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewLocList.txtMessage("");
                viewLocList.gridLocList.pickListApplyFilter();
            } catch (pException) {
                viewLocList.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function () {
            viewLocList.processLoading();
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewLocList.gridLocList == null) {
                    var zFilter = null;
                    if (viewLocList.largeObjectFilter !== undefined && viewLocList.largeObjectFilter !== null) {
                        zFilter = JSON.parse(viewLocList.largeObjectFilter);
                    }
                    viewLocList.gridLocList = new utilKendoGrid();
                    viewLocList.gridLocList.optionsConstant.isServerLoading = true;
                    viewLocList.gridLocList.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewLocList.gridLocList.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData";
                    viewLocList.gridLocList.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewLocList.onGridLoadComplete(pEvent, pStatus); };
                    viewLocList.gridLocList.optionsConstant.transportStartFunction = function (pEvent) { viewLocList.onGridLoadStart(pEvent); };
                    viewLocList.gridLocList.optionsConstant.serverLoadingNodeNameData = "data";
                    viewLocList.gridLocList.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewLocList.gridLocList.gSafeGuid = getGSafeGUID();
                    viewLocList.gridLocList.setupOptions(true);
                    viewLocList.gridLocList.pickListIgnoreColumns = [];
                    viewLocList.gridLocList.optionsConstant.changeFunction = function (pEvent) { viewLocList.onGridChange(pEvent); };
                    viewLocList.gridLocList.initGrid("#gridLocList", "#gridLocListContainer", "#windowPicklistLocList", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewLocList.gridLocList.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewLocList.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewLocList.processLoading();
        },


        setupEvents: function () {
            viewLocList.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewLocList, $("#viewLocList")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },

        hideLoadingScreen: function () {
            $('#divContainerLoading').hide();
        },

        processMessage: function (pMessage) {
            viewLocList.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewLocList.hideLoading();
        },

        processLoading: function () {
            viewLocList.countLoading--;
            if (viewLocList.countLoading == 0) {
                viewLocList.hideLoadingScreen();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewLocList.bindForm();
    viewLocList.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    onEnterLocation = function (pFileNo, pPracticeFolder) {
        var zGSafeGUID = getGSafeGUID();
        var zLandingPage = getQueryVariable("pLandingPage");
        if (zLandingPage == null || zLandingPage == undefined || zLandingPage.toString().length < 1) {
            zLandingPage = "locationdetails";
        }
        window.location.href = "../../" + pPracticeFolder + "/" + zLandingPage + ".aspx?sid=" + zGSafeGUID + "&p1=" + pFileNo;
    }

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistLocList":
                viewLocList.gridLocList.pickListCheck(pField, pId);
                break;
            default:
                viewLocList.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

    globalGoToFavories = function () {
        var zGSafeGUID = getGSafeGUID();
        var zURL = "../Favorites/Favorites.aspx?sid=" + zGSafeGUID;
        window.location.href = zURL;
    }

    //globalSaveFavories = function () {
    //    alert("Save Favories not available.");
    //}

    globalSaveFavories = function () {
        viewLocList.countLoading = 1;
        viewLocList.loadFavorite();
    }

    globalCloseFormView = function () {
        //   viewLocList.closeFormView();
    }

    globalDownloadData = function () {
        viewLocList.setExtractData();
    }

    globalDownloadReport = function () {
        viewLocList.setReportData();
    }

    globalDownloadChart = function () {
        viewLocList.setChartData();
    }

    globalCreateBubbleChart = function () {
        viewLocList.saveGridFilter();
    }

    refreshWindow = function () {
        viewLocList.gridRefresh();
    }

    gOpenRecsPage = function (pFileNo, pServiceCode) {
        var zGSafeGUID = getGSafeGUID();
        var urlRecTracking = "../../Recommendations/Recommendations.aspx?sid=" + zGSafeGUID + "&p1=" + pFileNo + "&p2=" + pServiceCode;
        //var win = window.open(urlRecTracking, "Title", "toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=yes,resizable=yes,width=" + (screen.width) + ",height=" + (screen.height) + ",top=0,left=0");
        window.open(urlRecTracking, "_blank");
        //window.location.href = urlRecTracking;
    }

});
