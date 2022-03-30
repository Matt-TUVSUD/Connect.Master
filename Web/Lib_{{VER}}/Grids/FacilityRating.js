$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    dsGridData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());
    dsLegendWeightDetailBM = {
        'BmWeightID': null,
        'FilePrefix': null,
        'MechMaintWeightGRC': null,
        'ElecMaintWeightGRC': null,
        'SparesWeightGRC': null,
        'HumanElementWeightGRC': null,
        'BCPWeightGRC': null,
        'MechEquipWeightGRC': null,
        'ElecEquipWeightGRC': null,
        'BoilersWeightGRC': null,
        'OccupancyWeightGRC': null,
        'ProcEquipWeightGRC': null,
        'CompSysWeightGRC': null,	
        'MechMaintWeight': null,
        'ElecMaintWeight': null,
        'SparesWeight': null,
        'HumanElementWeight': null,
        'OccupancyWeight': null,
        'BCPWeight': null,
        'MechEquipWeight': null,
        'ElecEquipWeight': null,
        'BoilersWeight': null,
        'ProcEquipWeight': null,
        'CompSysWeight': null
    };
    dsLegendWeightDetailFire = {
        'PhysicalProtectionWeightGRC': null,
        'HumanElementWeightGRC': null,
        'NaturalHazardsProtectionWeightGRC': null,
        'BusinessContinuityWeightGRC': null,
        'FloodWeightGRC': null,
        'EarthquakeWeightGRC': null,
        'WindstormWeightGRC': null,
        'ConstructionWeightGRC': null,
        'OccupancyWeightGRC': null,
        'OtherWeightGRC': null,
        'FireWeightID': null,
        'FilePrefix': null,
        'FloodWeight': null,
        'EarthquakeWeight': null,
        'WindstormWeight': null,
        'ConstructionWeight': null,
        'OccupancyWeight': null,
        'OtherWeight': null,
        'PhysicalProtectionWeight': null,
        'HumanElementWeight': null,
        'NaturalHazardsProtectionWeight': null,
        'BusinessContinuityWeight': null
    };

    // VIEW
    viewFacilityRatingGrid = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,
        largeObjectHandler: null,
        legendDataSummary: ko.observableArray([]),
        legendDataDetail: ko.observableArray([]),
        legendWeightDetailFire: ko.observable(dsLegendWeightDetailFire),
        legendWeightDetailBM: ko.observable(dsLegendWeightDetailBM),
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
        lblPassivePhysicalTxt: ko.observable(),
        lblActiveMGMTTxt: ko.observable(),
        // BUTTON AND VISIBILITY CONTROLS

        // KENDO OBJECTS
        gridStandard: null,
        windowFavorite: null,
        mapDepictedNameCurrent: null,
        mapDepictedDisplayCurrent: null,
        isMappable: false,


        // FUNCTIONS
        init: function () {
            viewFacilityRatingGrid.countLoading = 4;
            viewFacilityRatingGrid.loadDictionary();
            viewFacilityRatingGrid.loadLargeObjectData();
            //viewFacilityRatingGrid.loadData(); // AFTER LARGE OBJECT SUCCESS
            viewFacilityRatingGrid.setupKendo();
            viewFacilityRatingGrid.setupEvents();
        },


        loadDictionary: function () {
            viewFacilityRatingGrid.processLoading();
        },


        loadLargeObjectData: function () {
            try {
                var zServiceName = "GetLargeObjectDataGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFacilityRatingGrid.loadLargeObjectDataSuccess, viewFacilityRatingGrid.loadLargeObjectDataError, null);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while starting the large object data load call: " + pException.message);
            }
        },
        loadLargeObjectDataSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    // STORE THE LARGE OBJECT DATA
                    if (pResults.data.filter !== undefined && pResults.data.filter !== null && pResults.data.filter !== "") {
                        viewFacilityRatingGrid.largeObjectFilter = pResults.data.filter;
                    }
                    if (pResults.data.criteria !== undefined && pResults.data.criteria !== null && pResults.data.criteria !== "") {
                        viewFacilityRatingGrid.largeObjectCriteria = pResults.data.criteria;
                    }
                    if (pResults.data.sort !== undefined && pResults.data.sort !== null && pResults.data.sort !== "") {
                        viewFacilityRatingGrid.largeObjectSort = pResults.data.sort;
                    }
                    if (pResults.data.meta !== undefined && pResults.data.meta !== null && pResults.data.meta !== "") {
                        viewFacilityRatingGrid.largeObjectMeta = pResults.data.meta;
                    }
                } else {
                    viewFacilityRatingGrid.processMessage("An error occurred while loading large object data: " + pResults.message);
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while loading large object data: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
            viewFacilityRatingGrid.loadData();
        },
        loadLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFacilityRatingGrid.processMessage("Error while loading large object data. " + pMessage);
            viewFacilityRatingGrid.processLoading();
        },


        loadData: function () {
            viewFacilityRatingGrid.loadGridMeta();
            switch (ServerSide_GridId) {
                case "22":
                    $("#divContainerLegendDetail").show(1);
                    $("#divContainerLegendDetailFire").hide(1);
                    $("#divContainerLegendDetailBM").show(1);
                    $("#divContainerLegendSummary").hide(1);
                    viewFacilityRatingGrid.lblPassivePhysicalTxt("Physical Assets Weighting Percentages");
                    viewFacilityRatingGrid.lblActiveMGMTTxt("Management Programs Weighting Percentages");
                    viewFacilityRatingGrid.loadLegendChart();
                    break;
                case "23":
                    $("#divContainerLegendDetail").show(1);
                    $("#divContainerLegendDetailFire").show(1);
                    $("#divContainerLegendDetailBM").hide(1);
                    $("#divContainerLegendSummary").hide(1);
                    viewFacilityRatingGrid.lblPassivePhysicalTxt("Passive");
                    viewFacilityRatingGrid.lblActiveMGMTTxt("Active");
                    viewFacilityRatingGrid.loadLegendChart();
                    break;
                case "24":
                    $("#divContainerLegendSummary").show(1);
                    $("#divContainerLegendDetail").hide(1);
                    viewFacilityRatingGrid.loadLegendChart();
                    break;
                case "25":
                    $("#divContainerLegendSummary").show(1);
                    $("#divContainerLegendDetail").hide(1);
                    viewFacilityRatingGrid.loadLegendChart();
                    break;
                default:
                    $("#divContainerLegendSummary").hide(1);
                    $("#divContainerLegendDetail").hide(1);
                    break;
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFacilityRatingGrid.loadGridMetaSuccess, viewFacilityRatingGrid.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
            }
        },
        loadGridMetaSuccess: function (pResults, pParms) {
            try {
                dsMetaData = pResults;
                var zIsMappable = false;
                // MAKE ANY CORRECTIONS TO POSSIBLE FUNCTIONS
                for (var x = 0; x < dsMetaData.columns.length; x++) {
                    if (dsMetaData.columns[x].template !== undefined && dsMetaData.columns[x].template !== null && dsMetaData.columns[x].template.indexOf("function") == 0) {
                        dsMetaData.columns[x].template = "var fn = " + dsMetaData.columns[x].template;
                        var zFn = eval(dsMetaData.columns[x].template);
                        dsMetaData.columns[x].template = fn;
                    }
                    // ARE ANY FIELDS MAP DEPICTABLE?
                    if (dsMetaData.columns[x].isDepictable) {
                        zIsMappable = true;
                        viewFacilityRatingGrid.isMappable = true;
                    }
                    // STORE THE DEFAULT MAP DEPICTABLE FIELD
                    if (dsMetaData.columns[x].isDefaultDepicted) {
                        viewFacilityRatingGrid.mapDepictedNameCurrent = dsMetaData.columns[x].field;
                        viewFacilityRatingGrid.mapDepictedDisplayCurrent = dsMetaData.columns[x].title;
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
                viewFacilityRatingGrid.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
            viewFacilityRatingGrid.setupKendoGrid(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFacilityRatingGrid.processMessage("Error while loading meta data. " + pMessage);
        },


        // LOAD THE LEGEND CHART
        loadLegendChart: function () {
            try {
                var zServiceName = "GetRatingLegendChart";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFacilityRatingGrid.loadLegendChartSuccess, viewFacilityRatingGrid.loadLegendChartError, null);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while starting the grid legend chart call: " + pException.message);
            }
        },
        loadLegendChartSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    switch (ServerSide_GridId) {
                        case "22":
                            viewFacilityRatingGrid.legendWeightDetailBM(pResults.data[0]);
                            viewFacilityRatingGrid.legendWeightDetailBM.valueHasMutated();
                            break;
                        case "23":
                            viewFacilityRatingGrid.legendWeightDetailFire(pResults.data[0]);
                            viewFacilityRatingGrid.legendWeightDetailFire.valueHasMutated();
                            break;
                        case "24":
                            viewFacilityRatingGrid.legendDataSummary(pResults.data);
                            break;
                        case "25":
                            viewFacilityRatingGrid.legendDataSummary(pResults.data);
                            break;
                        default:
                            $("#divContainerLegendSummary").hide(1);
                            $("#divContainerLegendDetail").hide(1);
                            break;
                    }
                } else {
                    viewFacilityRatingGrid.processMessage("An error occurred while building grid legend chart data: " + pResults.message);
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while building grid legend chart data: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
        },
        loadLegendChartError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFacilityRatingGrid.processMessage("Error while loading legend chart data. " + pMessage);
        },

        // EXTRACT AND REPORT FUNCTIONS
        setExtractData: function () {
            viewFacilityRatingGrid.largeObjectHandler = "../../FD/ServeExtract.ashx";
            viewFacilityRatingGrid.setLargeObjectData();
        },


        setReportData: function () {
            viewFacilityRatingGrid.largeObjectHandler = "../../Reports/ReportHandler.ashx";
            viewFacilityRatingGrid.setLargeObjectData();
        },


        setLargeObjectData: function () {
            try {
                var zServiceName = "SaveLargeObjectData";
                var zSort = null;
                var zFilter = null;
                var zCriteria = null;
                var zColumnOrder = [];
                if (viewFacilityRatingGrid.gridStandard.grid.dataSource.sort()) {
                    zSort = JSON.stringify(viewFacilityRatingGrid.gridStandard.grid.dataSource.sort());
                }
                if (viewFacilityRatingGrid.gridStandard.grid.dataSource.filter()) {
                    zFilter = JSON.stringify(viewFacilityRatingGrid.gridStandard.grid.dataSource.filter());
                }
                if (viewFacilityRatingGrid.gridCriteriaFilter) {
                    zCriteria = JSON.stringify(viewFacilityRatingGrid.gridCriteriaFilter);
                }
                for (var x = 0; x < viewFacilityRatingGrid.gridStandard.grid.columns.length; x++) {
                    zColumnOrder.push(viewFacilityRatingGrid.gridStandard.grid.columns[x].field);
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFacilityRatingGrid.setLargeObjectDataSuccess, viewFacilityRatingGrid.setLargeObjectDataError, null);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while starting the grid extract call: " + pException.message);
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
                    var zURL = viewFacilityRatingGrid.largeObjectHandler + "?action=PrintGridReport&sid=" + getGSafeGUID() + zUserCurrencyId;
                    window.location.href = zURL;
                } else {
                    viewFacilityRatingGrid.processMessage("An error occurred while building grid extract data: " + pResults.message);
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while building grid extract data: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
            viewFacilityRatingGrid.setupKendoGrid();
        },
        setLargeObjectDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFacilityRatingGrid.processMessage("Error while setting extract data. " + pMessage);
        },
        // END EXTRACT FUNCTIONS


        // FAVORITES FUNCTIONS
        loadFavorite: function () {
            try {
                viewFacilityRatingGrid.favoriteList([]);
                viewFacilityRatingGrid.favoriteName("");
                var zServiceName = "GetGridFavoriteListByGrid";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFacilityRatingGrid.loadFavoriteSuccess, viewFacilityRatingGrid.loadFavoriteError, null);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        loadFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    if (pResults.data) {
                        for (var x = 0; x < pResults.data.length; x++) {
                            if (pResults.data[x].colFldTitle) {
                                viewFacilityRatingGrid.favoriteList.push({
                                    id: pResults.data[x].colId,
                                    title: pResults.data[x].colFldTitle
                                });
                            }
                        }
                    }
                    viewFacilityRatingGrid.windowFavorite.center().open();
                } else {
                    viewFacilityRatingGrid.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
        },
        loadFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewFacilityRatingGrid.windowFavorite.center().open();
            viewFacilityRatingGrid.processMessage("Error while calling the save favorite service. " + pMessage);
        },


        setFavorite: function () {
            try {
                // VALIDATE THE NAME
                var zTitle = viewFacilityRatingGrid.favoriteName();
                var zIsValid = true;
                var zIsCopy = false;
                var zIsCopyId = 0;
                if (zTitle === undefined || zTitle === null || zTitle.length < 1) {
                    zIsValid = false;
                    alert("Please enter a name for the favorite.");
                }
                for (var x = 0; x < viewFacilityRatingGrid.favoriteList().length; x++) {
                    if (zTitle == viewFacilityRatingGrid.favoriteList()[x].title) {
                        var zYesNo = confirm("The favorite [" + zTitle + "] already exists.  Do you want to overwrite?");
                        if (zYesNo) {
                            zIsCopy = true;
                            zIsCopyId = viewFacilityRatingGrid.favoriteList()[x].id;
                        } else {
                            zIsValid = false;
                        }
                        break;
                    }
                }

                if (zIsValid) {
                    // GATHER INFORMATION
                    //gSafeGuid As String, pTitle As String, pColumnOrderSetting As String, pSort As String, pFilter As String, pCriteria As String
                    var zSort = JSON.stringify(viewFacilityRatingGrid.gridStandard.grid.dataSource.sort());
                    var zFilter = JSON.stringify(viewFacilityRatingGrid.gridStandard.grid.dataSource.filter());
                    var zCriteria = viewFacilityRatingGrid.gridCriteriaFilter;
                    var zColumnOrder = [];
                    for (var x = 0; x < viewFacilityRatingGrid.gridStandard.grid.columns.length; x++) {
                        zColumnOrder.push({
                            locked: viewFacilityRatingGrid.gridStandard.grid.columns[x].locked,
                            field: viewFacilityRatingGrid.gridStandard.grid.columns[x].field
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
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewFacilityRatingGrid.setFavoriteSuccess, viewFacilityRatingGrid.setFavoriteError, null);
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
        },
        setFavoriteSuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewFacilityRatingGrid.windowFavorite.close();
                } else {
                    alert("An error occurred while saving your favorites data: " + pResults.message);
                    viewFacilityRatingGrid.processMessage("An error occurred while saving your favorites data: " + pResults.message);
                }
            } catch (pException) {
                alert("An error occurred while saving your favorites data: " + pException.message);
                viewFacilityRatingGrid.processMessage("An error occurred while saving your favorites data: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
        },
        setFavoriteError: function (pResults, pMessage, pErrorDetail, pParms) {
            alert("Error while calling the save favorite service. " + pMessage);
            viewFacilityRatingGrid.processMessage("Error while calling the save favorite service. " + pMessage);
        },


        onFavoriteSave: function () {
            viewFacilityRatingGrid.setFavorite();
        },


        onFavoriteCancel: function () {
            viewFacilityRatingGrid.windowFavorite.close();
            viewFacilityRatingGrid.favoriteList([]);
            viewFacilityRatingGrid.favoriteName("");
        },
        // END FAVORITES FUNCTIONS


        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewFacilityRatingGrid.processMessage("Loading...");
        },


        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewFacilityRatingGrid.txtMessage("");
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
                viewFacilityRatingGrid.txtTotalRecords(pEvent.responseJSON.total);
                kendo.ui.progress($("#gridStandard"), false);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },


        onMapDepictableComplete: function (pEvent, pField, pTitle) {
            // SET THE DEPICTED FIELD IN THE MVVM
            viewFacilityRatingGrid.mapDepictedNameCurrent = pField;
            viewFacilityRatingGrid.mapDepictedDisplayCurrent = pTitle;
            $("#txtDepictedBy").html(pTitle);
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewFacilityRatingGrid.txtMessage("");
                    var zTextSortedBy = viewFacilityRatingGrid.gridStandard.getSortString();
                    var zTextFilteredBy = viewFacilityRatingGrid.gridStandard.getFilterString();
                    var zTextPinnedBy = viewFacilityRatingGrid.gridStandard.getPinnedString();
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
                    if (viewFacilityRatingGrid.txtSortedBy() != zTextSortedBy) {
                        viewFacilityRatingGrid.txtSortedBy(zTextSortedBy);
                    }
                    if (viewFacilityRatingGrid.txtFilteredBy() != zTextFilteredBy) {
                        viewFacilityRatingGrid.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewFacilityRatingGrid.txtPinnedBy() != zTextPinnedBy) {
                        viewFacilityRatingGrid.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                viewFacilityRatingGrid.gridStandard.clearFilter();
                setTimeout(function () {
                    viewFacilityRatingGrid.loadGridMeta(true);
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while refreshing the grid: " + pException.message);
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
                viewFacilityRatingGrid.txtMessage("");
                if (viewFacilityRatingGrid.gridStandard != null) {
                    viewFacilityRatingGrid.gridStandard.pickListCancel();
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewFacilityRatingGrid.txtMessage("");
                viewFacilityRatingGrid.gridStandard.pickListCheckAll();
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewFacilityRatingGrid.txtMessage("");
                viewFacilityRatingGrid.gridStandard.pickListCheckNone();
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewFacilityRatingGrid.txtMessage("");
                viewFacilityRatingGrid.gridStandard.pickListCheckReverse();
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewFacilityRatingGrid.txtMessage("");
                viewFacilityRatingGrid.gridStandard.pickListApplyFilter();
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function () {
            viewFacilityRatingGrid.setupKendoWindow();
            viewFacilityRatingGrid.processLoading();
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewFacilityRatingGrid.gridStandard == null) {
                    var zFilter = null;
                    if (viewFacilityRatingGrid.largeObjectFilter !== undefined && viewFacilityRatingGrid.largeObjectFilter !== null) {
                        zFilter = JSON.parse(viewFacilityRatingGrid.largeObjectFilter);
                    }
                    viewFacilityRatingGrid.gridStandard = new utilKendoGrid();
                    viewFacilityRatingGrid.gridStandard.optionsConstant.isServerLoading = true;
                    viewFacilityRatingGrid.gridStandard.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewFacilityRatingGrid.gridStandard.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData";
                    viewFacilityRatingGrid.gridStandard.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewFacilityRatingGrid.onGridLoadComplete(pEvent, pStatus); };
                    viewFacilityRatingGrid.gridStandard.optionsConstant.transportStartFunction = function (pEvent) { viewFacilityRatingGrid.onGridLoadStart(pEvent); };
                    viewFacilityRatingGrid.gridStandard.optionsConstant.setMapDepictableComplete = function (pEvent, pField, pTitle) { viewFacilityRatingGrid.onMapDepictableComplete(pEvent, pField, pTitle); };
                    viewFacilityRatingGrid.gridStandard.optionsConstant.serverLoadingNodeNameData = "data";
                    viewFacilityRatingGrid.gridStandard.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewFacilityRatingGrid.gridStandard.optionsConstant.detailTemplate = dsMetaData.detailTemplate;
                    viewFacilityRatingGrid.gridStandard.gSafeGuid = getGSafeGUID();
                    viewFacilityRatingGrid.gridStandard.setupOptions(true);
                    viewFacilityRatingGrid.gridStandard.pickListIgnoreColumns = [];
                    viewFacilityRatingGrid.gridStandard.optionsConstant.changeFunction = function (pEvent) { viewFacilityRatingGrid.onGridChange(pEvent); };
                    viewFacilityRatingGrid.gridStandard.mapDepictedNameDefault = viewFacilityRatingGrid.mapDepictedNameCurrent;
                    viewFacilityRatingGrid.gridStandard.mapDepictedNameCurrent = viewFacilityRatingGrid.mapDepictedNameCurrent;
                    viewFacilityRatingGrid.gridStandard.initGrid("#gridStandard", "#gridStandardContainer", "#windowPicklistStandard", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewFacilityRatingGrid.gridStandard.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewFacilityRatingGrid.processLoading();
        },


        setupKendoWindow: function () {
            try {
                if (viewFacilityRatingGrid.windowFavorite == null) {
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
                    viewFacilityRatingGrid.windowFavorite = $("#windowFavorite").data("kendoWindow");
                }
            } catch (pException) {
                viewFacilityRatingGrid.processMessage("Error while building popup windows. " + pException.message);
            }
        },


        setupEvents: function () {
            $(window).resize(function () {
                var zWidth = $(window).width();
                if (zWidth > 1000 && viewFacilityRatingGrid.isMappable) {
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
                    viewFacilityRatingGrid.closeFormView();
                }
            });
            viewFacilityRatingGrid.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewFacilityRatingGrid, $("#viewFacilityRatingGrid")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },

        processMessage: function (pMessage) {
            viewFacilityRatingGrid.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewFacilityRatingGrid.hideLoading();
        },

        processLoading: function () {
            viewFacilityRatingGrid.countLoading--;
            if (viewFacilityRatingGrid.countLoading < 1) {
                viewFacilityRatingGrid.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewFacilityRatingGrid.bindForm();
    viewFacilityRatingGrid.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    //onEnterLocation = function (pFileNo, pPracticeFolder) {
    //    var zGSafeGUID = getGSafeGUID();
    //    window.location.href = "../../" + pPracticeFolder + "/locationdetails.aspx?sid=" + zGSafeGUID + "&p1=" + pFileNo;
    //}

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistStandard":
                viewFacilityRatingGrid.gridStandard.pickListCheck(pField, pId);
                break;
            default:
                viewFacilityRatingGrid.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

    globalOpenFormView = function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
        viewFacilityRatingGrid.openFormView(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
    }

    globalCloseFormView = function () {
        viewFacilityRatingGrid.closeFormView();
    }

    globalGoToFavories = function () {
        var zGSafeGUID = getGSafeGUID();
        var zURL = "../Favorites/Favorites.aspx?sid=" + zGSafeGUID;
        window.location.href = zURL;
    }

    globalSaveFavories = function () {
        viewFacilityRatingGrid.countLoading = 1;
        viewFacilityRatingGrid.loadFavorite();
    }

    globalDownloadData = function () {
        viewFacilityRatingGrid.setExtractData();
    }

    globalDownloadReport = function () {
        viewFacilityRatingGrid.setReportData();
    }

    refreshWindow = function () {
        viewFacilityRatingGrid.gridRefresh();
    }

});
