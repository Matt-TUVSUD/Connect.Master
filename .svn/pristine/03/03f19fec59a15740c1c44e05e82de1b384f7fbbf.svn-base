$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());

    // VIEW
    viewBatch = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,

        // LABELS
        txtMessage: ko.observable(),
        txtSortedBy: ko.observable(),
        txtFilteredBy: ko.observable(),
        txtPinnedBy: ko.observable(),
        txtTotalRecords: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS

        // KENDO OBJECTS
        gridBatch: null,
        windowBatchConfirm: null,

        // FUNCTIONS
        init: function () {
            viewBatch.countLoading = 4;
            viewBatch.loadGridFilterCriteria();
            viewBatch.loadDictionary();
            viewBatch.loadData();
            viewBatch.setupEvents();
        },


        loadDictionary: function () {
            viewBatch.processLoading();
        },


        // GET GRID FILTER CRITERIA
        loadGridFilterCriteria: function () {
        },


        loadData: function () {
            viewBatch.loadGridMeta();
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewBatch.loadGridMetaSuccess, viewBatch.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewBatch.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
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
                viewBatch.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewBatch.processLoading();
            viewBatch.setupKendo(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewBatch.processMessage("Error while loading meta data. " + pMessage);
        },


        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewBatch.txtMessage("Loading...");
            global.messageShow("txtMessage", "messageGridNormal");
        },


        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewBatch.txtMessage("");
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
                viewBatch.txtTotalRecords(pEvent.responseJSON.total);
            } catch (pException) {
                viewBatch.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewBatch.txtMessage("");
                    var zTextSortedBy = viewBatch.gridBatch.getSortString();
                    var zTextFilteredBy = viewBatch.gridBatch.getFilterString();
                    var zTextPinnedBy = viewBatch.gridBatch.getPinnedString();
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
                    if (viewBatch.txtSortedBy() != zTextSortedBy) {
                        viewBatch.txtSortedBy(zTextSortedBy);
                    }
                    if (viewBatch.txtFilteredBy() != zTextFilteredBy) {
                        viewBatch.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewBatch.txtPinnedBy() != zTextPinnedBy) {
                        viewBatch.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewBatch.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                viewBatch.gridBatch.clearFilter();
                setTimeout(function () {
                    viewBatch.loadGridMeta(true);
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewBatch.processMessage("An error occurred while refreshing the grid: " + pException.message);
            }
        },


        cancelBatchReport: function () {
            // CALL THE SERVICE TO RESET THE FILE NO LIST
            try {
                // NAVIGATE BACK              
                viewBatch.onBatchReportCancel();
            } catch (pException) {
                viewBatch.processMessage("An error occurred while cancelling Batch Report: " + pException.message);
            }
        },
        createBatchReport: function () {
            try {
                // GATHER THE FILENO LIST AND SETTINGS
                //var zFileNoList = [];
                //for (var x = 0; x < viewBatch.gridBatch.grid.dataSource.view().length; x++) {
                //    zFileNoList.push(viewBatch.gridBatch.grid.dataSource.view()[x].FileNo);
                //}
                var zCboConvertCurrency = $find(gCboConvertCurrencyId);
                var zCurrency = zCboConvertCurrency.get_selectedItem().get_value()
                var zCboConvertUnits = $find(gCboConvertUnitsId);
                var zUnits = zCboConvertUnits.get_selectedItem().get_value()
                var zNameOfReport = document.getElementById(gTxtNameOfReport).value;
                zNameOfReport = zNameOfReport.replace(/[^\w\s]/gi, '');
                var zFilter = JSON.stringify(viewBatch.gridBatch.grid.dataSource.filter());
                var zSort = JSON.stringify(viewBatch.gridBatch.grid.dataSource.sort());
                // CALL THE SERVICE TO APPLY THE FILE NO
                var zServiceName = "SetBatchReportSettings";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    //"pFileNoList": zFileNoList,
                    "pFileName": zNameOfReport,
                    "pCurrencyPreference": zCurrency,
                    "pUnitPreference": zUnits,
                    "pFilterString": zFilter,
                    "pSortString": zSort
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewBatch.createBatchReportSuccess, viewBatch.createBatchReportError, null);
            } catch (pException) {
                viewBatch.processMessage("An error occurred while excecuting the apply Batch Report data call: " + pException.message);
            }
        },
        createBatchReportSuccess: function (pResults, pParms) {
            var zType = "applying";
            if (pParms !== undefined && pParms !== null && pParms.isCleared !== undefined && pParms.isCleared == true) { zType = "clearing"; }
            try {
                if (pResults !== undefined && pResults.isSuccess !== undefined && pResults.isSuccess == true) {
                    // POPUP UP CONFIRMATION BOX, REFRESH THE GRID IF NEEDED
                    viewBatch.windowBatchConfirm.center().open();
                } else {
                    viewBatch.processMessage("An error occurred while " + zType + " Batch Report data: " + pResults.message);
                }
            } catch (pException) {
                viewBatch.processMessage("An error occurred while " + zType + " Batch Report data: " + pException.message);
            }
            viewBatch.processLoading();
        },
        createBatchReportError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewBatch.processMessage("Error while applying / clearing Batch Report data. " + pMessage);
            viewBatch.processLoading();
        },


        onBatchReportConfirmHide: function () {
            //viewBatch.windowBatchConfirm.close();
            //setTimeout(function () {
            $("#btnCloseBatchReport").click();
            //}, 250);
        },

        onBatchReportCancel: function () {
            //viewBatch.windowBatchConfirm.close();
            //setTimeout(function () {
            $("#btnCancelBatchReport").click();
            //}, 250);
        },

        // END GRID FUNCTIONS


        // START PICKLIST FUNCTIONS
        pickListCancel: function () {
            try {
                viewBatch.txtMessage("");
                if (viewBatch.gridBatch != null) {
                    viewBatch.gridBatch.pickListCancel();
                }
            } catch (pException) {
                viewBatch.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewBatch.txtMessage("");
                viewBatch.gridBatch.pickListCheckAll();
            } catch (pException) {
                viewBatch.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewBatch.txtMessage("");
                viewBatch.gridBatch.pickListCheckNone();
            } catch (pException) {
                viewBatch.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewBatch.txtMessage("");
                viewBatch.gridBatch.pickListCheckReverse();
            } catch (pException) {
                viewBatch.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewBatch.txtMessage("");
                viewBatch.gridBatch.pickListApplyFilter();
            } catch (pException) {
                viewBatch.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function (pIsRebuildRequired) {
            viewBatch.setupKendoGrid(pIsRebuildRequired);
            viewBatch.setupKendoWindow();
            viewBatch.processLoading();
        },


        setupKendoWindow: function () {
            if (viewBatch.windowBatchConfirm == null) {
                $("#windowBatchConfirm").kendoWindow({
                    visible: false,
                    modal: true,
                    draggable: true,
                    resizable: false,
                    width: "380px",
                    height: "275px",
                    title: "", // title added below with JQuery
                    actions: ["Close"],
                    animation: { open: { effects: "default" }, close: { effects: "default" } },
                    refresh: function () { this.center(); }
                });
                $("#windowBatchConfirm").prev().find(".k-window-title").append("<img src='../../images/icons/reports/chart_column_16x16.png' align='left' alt='Batch Reports' class='windowIcon'/>  Your Request is Being Processed");
                viewBatch.windowBatchConfirm = $("#windowBatchConfirm").data("kendoWindow");
            }
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewBatch.gridBatch == null) {
                    var zFilter = null;
                    if (gridBatch.largeObjectFilter !== undefined && gridBatch.largeObjectFilter !== null) {
                        zFilter = JSON.parse(gridBatch.largeObjectFilter);
                    }
                    viewBatch.gridBatch = new utilKendoGrid();
                    viewBatch.gridBatch.optionsConstant.isServerLoading = true;
                    viewBatch.gridBatch.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewBatch.gridBatch.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData";
                    viewBatch.gridBatch.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewBatch.onGridLoadComplete(pEvent, pStatus); };
                    viewBatch.gridBatch.optionsConstant.transportStartFunction = function (pEvent) { viewBatch.onGridLoadStart(pEvent); };
                    viewBatch.gridBatch.optionsConstant.serverLoadingNodeNameData = "data";
                    viewBatch.gridBatch.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewBatch.gridBatch.optionsConstant.heightOffset = -475;
                    viewBatch.gridBatch.gSafeGuid = getGSafeGUID();
                    viewBatch.gridBatch.setupOptions(true);
                    viewBatch.gridBatch.pickListIgnoreColumns = [];
                    viewBatch.gridBatch.optionsConstant.changeFunction = function (pEvent) { viewBatch.onGridChange(pEvent); };
                    viewBatch.gridBatch.initGrid("#gridBatch", "#gridBatchContainer", "#windowPicklistBatch", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewBatch.gridStandard.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewBatch.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewBatch.processLoading();
        },


        setupEvents: function () {
            viewBatch.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewBatch, $("#viewBatch")[0]);
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
            viewBatch.countLoading--;
            if (viewBatch.countLoading < 1) {
                viewBatch.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewBatch.bindForm();
    viewBatch.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistBatch":
                viewBatch.gridBatch.pickListCheck(pField, pId);
                break;
            default:
                viewBatch.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }
});