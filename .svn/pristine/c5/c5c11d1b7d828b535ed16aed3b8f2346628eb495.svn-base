$(document).ready(function () {

    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    kendo.ui.progress($("#divContainerLoading"), false);

    // GLOBAL DATA PLACEHOLDERS
    dsMetaData = null;
    globalClientFeatures = getClientFeatures(getGSafeGUID());
    apiHostPort = ""
    inDebugMode = (apiHostPort != "");

    // VIEW
    viewPref = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,

        // PERMISSIONS

        // DATA
        gridId: null,
        gridCriteriaFilter: null,
        originalCurrency: null,
        originalUnit: null,
        currentUser: ko.observable(),
        locationPageDDData: ko.observableArray(),
        selectedLandingPgId: ko.observable(),

        //API NEEDS
        AppKey: "2F14E5EF-333D-4A14-AB41-0CCC586F7E48",
        UserSid: ko.observable(getQueryVariable('sid')),
        endPointBase: "",
        endPointFilePrefix: ko.observable(),
        langID: ko.observable(1),
        userDataEndPointUrl: ko.observable(),
        userSaveEndPointUrl: ko.observable(),

        // LABELS
        txtMessage: ko.observable(),
        txtSortedBy: ko.observable(),
        txtFilteredBy: ko.observable(),
        txtPinnedBy: ko.observable(),
        txtTotalRecords: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS

        // KENDO OBJECTS
        gridPref: null,
        windowPreferenceConfirm: null,

        // FUNCTIONS
        init: function () {
            //NEEDED FOR API
            $.ajaxSetup({
                headers: { "AppKey": viewPref.AppKey, "UserSid": viewPref.UserSid() }
            });
            /* DETERMINE URL TO SET ENDPOINT BASE */
            var tempURL = window.location.href;
            /* DEV */
            if (tempURL.indexOf('localhost') > -1 && inDebugMode) {
                viewPref.endPointBase = "//localhost:" + apiHostPort + "/";
            } else {
                viewPref.endPointBase = "//dev.globalriskconsultants.com/capi/";
            }
            /* LIVE */
            if (tempURL.indexOf('grcconnect') > -1) {
                viewPref.endPointBase = "//grcconnect.globalriskconsultants.com/capi/";
            }
            /* TEST/BETA */
            if (tempURL.indexOf('test') > -1) {
                viewPref.endPointBase = "//grcconnecttest.globalriskconsultants.com/capi/";
            }

            viewPref.countLoading = 4;
            viewPref.loadGridFilterCriteria();
            viewPref.loadDictionary();
            viewPref.loadData();
            viewPref.setupEvents();
        },

        loadUserData: function () {
            //USER DATA
            var tempEndpoint = viewPref.endPointBase + "users/current"
            viewPref.userDataEndPointUrl(tempEndpoint);
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                cache: false,
                async: false,
                url: viewPref.userDataEndPointUrl(),
                success: function (pResults) {
                    if (pResults.isSuccess) {
                        viewPref.currentUser(pResults.data);
                        viewPref.selectedLandingPgId(pResults.data.landingNavLinkId);
                        viewPref.userSaveEndPointUrl(pResults.data._Links[0].href);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading user data: " + pMessage);
                },
            });
        },

        saveUserData: function (pData) {
            $.ajax({
                type: "PUT",
                data: pData,
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: viewPref.userSaveEndPointUrl(),
                success: function (pResults) {
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error saving user data: " + pMessage);
                }
            });
        },

        loadDropDownData: function () {
            /*
             * LIST TYPES ARE AS FOLLOWS:
             * 12=Landing Pages
             * */
            var endPointURL = viewPref.endPointBase + "meta/lists?type=12&langid=" + viewPref.langID();
            $.ajax({
                type: "GET",
                dataType: "json",
                contentType: "application/javascript",
                async: false,
                url: endPointURL,
                success: function (pResults) {
                    for (var i = 0; i < pResults.data.length; i++) {
                        if (pResults.data[i].id == 12) {
                            //"Landing Pages"
                            viewPref.locationPageDDData(pResults.data[i].items);
                        } 
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    alert("Error loading recommendations status dropdown data: " + pMessage);
                }
            });
        },

        loadDictionary: function () {
            viewPref.processLoading();
        },


        // GET GRID FILTER CRITERIA
        loadGridFilterCriteria: function () {
        },


        loadData: function () {
            viewPref.loadGridMeta();
            viewPref.loadOriginals();
            viewPref.loadUserData();
            viewPref.loadDropDownData();
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
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewPref.loadGridMetaSuccess, viewPref.loadGridMetaError, { "IsRebuildRequired": pIsRebuildRequired });
            } catch (pException) {
                viewPref.processMessage("An error occurred while starting the grid meta data call: " + pException.message);
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
                viewPref.processMessage("An error occurred while building grid meta data: " + pException.message);
            }
            viewPref.processLoading();
            viewPref.setupKendo(pParms.IsRebuildRequired);
        },
        loadGridMetaError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewPref.processMessage("Error while loading meta data. " + pMessage);
        },


        loadOriginals: function () {
            setTimeout(function () {
                var zCboConvertCurrency = $find(gCboConvertCurrencyId);
                viewPref.originalCurrency = zCboConvertCurrency.get_selectedItem().get_value()
                var zCboConvertUnits = $find(gCboConvertUnitsId);
                viewPref.originalUnit = zCboConvertUnits.get_selectedItem().get_value()
            }, 250);
        },


        // START GRID FUNCTIONS
        onGridLoadStart: function (pEvent) {
            viewPref.txtMessage("Loading...");
            global.messageShow("txtMessage", "messageGridNormal");
        },


        onGridLoadComplete: function (pEvent, pStatus) {
            try {
                viewPref.txtMessage("");
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
                viewPref.txtTotalRecords(pEvent.responseJSON.total);
            } catch (pException) {
                viewPref.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },


        onGridChange: function (pEvent) {
            try {
                setTimeout(function () {
                    viewPref.txtMessage("");
                    var zTextSortedBy = viewPref.gridPref.getSortString();
                    var zTextFilteredBy = viewPref.gridPref.getFilterString();
                    var zTextPinnedBy = viewPref.gridPref.getPinnedString();
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
                    if (viewPref.txtSortedBy() != zTextSortedBy) {
                        viewPref.txtSortedBy(zTextSortedBy);
                    }
                    if (viewPref.txtFilteredBy() != zTextFilteredBy) {
                        viewPref.txtFilteredBy(zTextFilteredBy);
                    }
                    if (viewPref.txtPinnedBy() != zTextPinnedBy) {
                        viewPref.txtPinnedBy(zTextPinnedBy);
                    }
                }, 250);
            } catch (pException) {
                viewPref.processMessage("An error occurred while completing grid change: " + pException.message);
            }
        },


        gridRefresh: function () {
            try {
                viewPref.gridPref.clearFilter();
                setTimeout(function () {
                    viewPref.loadGridMeta(true);
                    $('.k-i-refresh').click();
                }, 250);
            } catch (pException) {
                viewPref.processMessage("An error occurred while refreshing the grid: " + pException.message);
            }
        },


        clearMyPreference: function () {
            // CALL THE SERVICE TO RESET THE FILE NO LIST
            /* CHANGE TO FUNCTIONALITY 10-20-21:
             * "CLEAR" NOW KNOWN AS RESET WILL NOT CHANGE THE VALUES
             * IN THE DROPDOWN LISTS.
             * "pCurrencyPreference": null,
             * "pUnitPreference": null
             */
            try {
                var zServiceName = "ApplyMyPreference";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID(),
                    "pFileNoList": [],
                    "pFilterString": "",
                    "pCurrencyPreference": viewPref.originalCurrency,
                    "pUnitPreference": viewPref.originalUnit
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewPref.applyMyPreferenceSuccess, viewPref.applyMyPreferenceError, { isCleared: true });
            } catch (pException) {
                viewPref.processMessage("An error occurred while excecuting the clear myPreference data call: " + pException.message);
            }
        },
        applyMyPreference: function () {
            try {
                // GATHER THE FILENO LIST AND SETTINGS
                var zFileNoList = [];
                for (var x = 0; x < viewPref.gridPref.grid.dataSource.view().length; x++) {
                    zFileNoList.push(viewPref.gridPref.grid.dataSource.view()[x].FileNo);
                }
                //SAVE LANDING PAGE SELECTION
                let tempUserData = ko.toJSON(viewPref.currentUser());
                viewPref.saveUserData(tempUserData);
                var zCboConvertCurrency = $find(gCboConvertCurrencyId);
                var zCurrency = zCboConvertCurrency.get_selectedItem().get_value();
                var zCboConvertUnits = $find(gCboConvertUnitsId);
                var zUnits = zCboConvertUnits.get_selectedItem().get_value();
                var zFilterString = JSON.stringify(viewPref.gridPref.grid.dataSource.filter());
                // IF CHANGES ARE MADE, CALL THE SERVICE TO APPLY THE FILE NO LIST/FILTER, ELSE CANCEL
                if (viewPref.originalCurrency != zCurrency || viewPref.originalUnit != zUnits ||
                    (zFilterString != undefined && zFilterString != null && zFilterString != "undefined" && zFilterString != "null" && zFilterString.length > 0)) {
                        var zServiceName = "ApplyMyPreference";
                        var zParms = ko.toJSON({
                        "gSafeGuid": getGSafeGUID(),
                        "pFileNoList": zFileNoList,
                        "pFilterString": zFilterString,
                        "pCurrencyPreference": zCurrency,
                        "pUnitPreference": zUnits
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewPref.applyMyPreferenceSuccess, viewPref.applyMyPreferenceError, { isCleared: false });
                } else {
                    //window.history.back(); // CANNOT USE HISTORY.BACK BECAUSE IT DOES NOT RUN APPLIED TEXT IN POST BACK
                    window.document.location.href = document.referrer;
                }
            } catch (pException) {
                viewPref.processMessage("An error occurred while excecuting the apply myPreference data call: " + pException.message);
            }
        },
        applyMyPreferenceSuccess: function (pResults, pParms) {
            try {
                // POPUP UP CONFIRMATION BOX, REFRESH THE GRID IF NEEDED
                viewPref.windowPreferenceConfirm.center().open();
                if (pParms.isCleared) {
                    viewPref.gridRefresh();
                }
            } catch (pException) {
                var zType = "applying";
                if (pParms.isCleared) { zType = "clearing"; }
                viewPref.processMessage("An error occurred while " + zType + " myPreference data: " + pException.message);
            }
            viewPref.processLoading();
        },
        applyMyPreferenceError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewPref.processMessage("Error while applying / clearing myPreference data. " + pMessage);
            viewPref.processLoading();
        },


        onPreferenceConfirmHide: function () {
            viewPref.windowPreferenceConfirm.close();
            //setTimeout(function () {
               // $("#btnClosePreferences").click();
            //}, 250);
        },
        // END GRID FUNCTIONS


        // START PICKLIST FUNCTIONS
        pickListCancel: function () {
            try {
                viewPref.txtMessage("");
                if (viewPref.gridPref != null) {
                    viewPref.gridPref.pickListCancel();
                }
            } catch (pException) {
                viewPref.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewPref.txtMessage("");
                viewPref.gridPref.pickListCheckAll();
            } catch (pException) {
                viewPref.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewPref.txtMessage("");
                viewPref.gridPref.pickListCheckNone();
            } catch (pException) {
                viewPref.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewPref.txtMessage("");
                viewPref.gridPref.pickListCheckReverse();
            } catch (pException) {
                viewPref.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewPref.txtMessage("");
                viewPref.gridPref.pickListApplyFilter();
            } catch (pException) {
                viewPref.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },
        // END PICK LIST FUNCTIONS


        setupKendo: function (pIsRebuildRequired) {
            viewPref.setupKendoGrid(pIsRebuildRequired);
            viewPref.setupKendoWindow();
            $('#landingPageDD').kendoDropDownList({
                dataTextField: "navText",
                dataValueField: "navLinkId",
                value: viewPref.selectedLandingPgId(),
                dataSource: viewPref.locationPageDDData(),
                change: function (e) {
                    viewPref.onLandingPageSelect(e);
                }
            });
            var landingPg;
            landingPg = $('#landingPage');
            landingPg.find(".k-select").css("width", "16px").css("font-size", "12px").css("border-left", "1px solid #999");
            landingPg.find(".k-icon").css("font-size", "13px");
            viewPref.processLoading();
        },


        setupKendoWindow: function () {
            if (viewPref.windowPreferenceConfirm == null) {
                $("#windowPreferenceConfirm").kendoWindow({
                    visible: false,
                    modal: true,
                    draggable: false,
                    resizable: false,
                    width: "295px",
                    height: "140px",
                    title: "", // title added below with JQuery
                    actions: false,
                    animation: { open: { effects: "default" }, close: { effects: "default" } },
                    refresh: function () { this.center(); }
                });
                $("#windowPreferenceConfirm").prev().find(".k-window-title").append("<img src='../../images/icons/reports/document_information_32x32.png' align='left' alt='Account Information' class='windowIcon'/>  Preference Confirmation");
                viewPref.windowPreferenceConfirm = $("#windowPreferenceConfirm").data("kendoWindow");
            }
        },


        setupKendoGrid: function (pIsRebuildRequired) {
            try {
                if (viewPref.gridPref == null) {
                    var zFilter = null;
                    if (gridPref.largeObjectFilter !== undefined && gridPref.largeObjectFilter !== null) {
                        zFilter = JSON.parse(gridPref.largeObjectFilter);
                    }
                    viewPref.gridPref = new utilKendoGrid();
                    viewPref.gridPref.optionsConstant.isServerLoading = true;
                    viewPref.gridPref.optionsConstant.transportPickListAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetPickListData";
                    viewPref.gridPref.optionsConstant.transportReadAddress = SITEBASEURL + RESTSERVERENDPOINT + "GetGridData";
                    viewPref.gridPref.optionsConstant.transportCompleteFunction = function (pEvent, pStatus) { viewPref.onGridLoadComplete(pEvent, pStatus); };
                    viewPref.gridPref.optionsConstant.transportStartFunction = function (pEvent) { viewPref.onGridLoadStart(pEvent); };
                    viewPref.gridPref.optionsConstant.serverLoadingNodeNameData = "data";
                    viewPref.gridPref.optionsConstant.serverLoadingNodeNameTotal = "total";
                    viewPref.gridPref.optionsConstant.heightOffset = -475;
                    viewPref.gridPref.gSafeGuid = getGSafeGUID();
                    viewPref.gridPref.setupOptions(true);
                    viewPref.gridPref.pickListIgnoreColumns = [];
                    viewPref.gridPref.optionsConstant.changeFunction = function (pEvent) { viewPref.onGridChange(pEvent); };
                    viewPref.gridPref.initGrid("#gridPref", "#gridPrefContainer", "#windowPicklistPref", dsGridData, dsMetaData.schema, dsMetaData.columns, false, null, zFilter, null, dsMetaData.indices, dsMetaData.sources);
                }
                if (pIsRebuildRequired) {
                    viewPref.gridStandard.rebuildGrid(false, dsMetaData.schema, dsMetaData.columns);
                }
            } catch (pException) {
                viewPref.processMessage("An error occurred while building the grid: " + pException.message);
            }
            viewPref.processLoading();
        },

        onLandingPageSelect: function (e) {
            let landingPgId = e.sender.dataItem().navLinkId;
            viewPref.selectedLandingPgId(landingPgId);
            viewPref.currentUser().landingNavLinkId = viewPref.selectedLandingPgId();
        },

        setupEvents: function () {
            viewPref.processLoading();
        },


        bindForm: function () {
            ko.applyBindings(viewPref, $("#viewPref")[0]);
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },

        processMessage: function (pMessage) {
            viewPref.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewPref.hideLoading();
        },

        processLoading: function () {
            viewPref.countLoading--;
            if (viewPref.countLoading < 1) {
                viewPref.hideLoading();
            } else {
            }
        }
    };


    // BIND AND INIT FORM
    viewPref.bindForm();
    viewPref.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    onEnterLocation = function (pFileNo, pPracticeFolder) {
        var zGSafeGUID = getGSafeGUID();
        var zLandingPage = getQueryVariable("pLandingPage");
        if (zLandingPage == null || zLandingPage == undefined || zLandingPage.toString().length < 1) {
            zLandingPage = "locationdetails";
        }
        window.location.href = "../../" + pPracticeFolder + "/" + zLandingPage + ".aspx?sid=" + zGSafeGUID + "&p1=" + pFileNo;
    }

    globalApplyMyPreference = function () {
        viewPref.applyMyPreference();
    }

    globalClearMyPreference = function () {
        viewPref.clearMyPreference();
    }

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPicklistPref":
                viewPref.gridPref.pickListCheck(pField, pId);
                break;
            default:
                viewPref.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }
});