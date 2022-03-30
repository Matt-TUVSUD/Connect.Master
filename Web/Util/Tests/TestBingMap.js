$(document).ready(function () {

    // GLOBAL DATA PLACEHOLDERS
    globalKeyAppName = "GRC.Connect";
    globalKeyApplication = "01552c1572d14ff9b108f44f1b3c1d76";
    globalKeyBing = "dcLcFIaVh7HHr3kYxMqq~z3IOleVdt0Pv_JDxdK0X7Q~AgX3x6H0kBmnonP50fMwBHcpzgeQnf3y27XpwSahxCwjJQii-TcLAqgDAv10pa0s"; //"Aj8BS14bsCDQDGvM9BUveTVkUiScV3HVRI4npBnVXjR8uyIxYw8U6ZJeNNYKeLV_";
    //globalIsMapShown = false;




    // VIEW
    viewMap = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 0,
        isInitComplete: false,
        isMapMetaLoaded: false,
        isFormBound: false,
        isPinsAvailable: false,

        // DATA
        mapPinData: [],
        mapMetaData: [],
        mapGridFilter: "",
        mapPinFilter: "",
        depictedByColumnName: null,
        pickListFieldName: "PinValue",

        // LABELS
        txtMapMessage: ko.observable(),
        //txtSortedBy: ko.observable(),
        //txtFilteredBy: ko.observable(),
        //txtPinnedBy: ko.observable(),
        //txtTotalRecords: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS

        // OBJECTS
        map: null,
        picklist: null,

        // FUNCTIONS
        init: function () {
            if (!viewMap.isInitComplete) {
                viewMap.countLoading = 5;
                viewMap.loadDictionary();
                viewMap.setupMap();
                viewMap.setupKendo();
                viewMap.setupEvents();
                viewMap.loadData();
            }
        },


        loadDictionary: function () {
            viewMap.processLoading();
        },


        loadData: function () {
            //viewMap.loadMapData();
            viewMap.loadMapDataSuccess(dsMapData, null);
        },


        // LOAD THE MAP META DATA
        loadMapData: function () {
            try {
                // SETUP
                viewMap.clearMessage();
                viewMap.mapPinData = [];
                viewMap.mapMetaData = [];
                // GATHER DATA FROM THE GRID
                viewMap.mapPinFilter = null;
                viewMap.mapGridFilter = null;
                var zSort = null;
                var zCriteria = null;
                var zSafeGuid = getGSafeGUID();
                //if (viewGrid.gridStandard.grid.dataSource.sort()) { zSort = JSON.stringify(viewGrid.gridStandard.grid.dataSource.sort()); }
                //if (viewGrid.gridStandard.grid.dataSource.filter()) { viewMap.mapGridFilter = JSON.stringify(viewGrid.gridStandard.grid.dataSource.filter()); }
                //if (viewGrid.gridCriteriaFilter) { zCriteria = viewGrid.gridCriteriaFilter; }
                // CALL SERVICE
                var zServiceName = "GetMapData";
                var zParms = ko.toJSON({
                    "sort": zSort,
                    "filter": viewMap.mapGridFilter,
                    "criteria": zCriteria,
                    "gSafeGuid": getGSafeGUID(),
                    "pDepictedByColumnName": "FileNo" //viewGrid.mapDepictedNameCurrent
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewMap.loadMapDataSuccess, viewMap.loadMapDataError, null);
            } catch (pException) {
                viewMap.processMessage("An error occurred while starting the map pin data call: " + pException.message);
            }
        },
        loadMapDataSuccess: function (pResults, pParms) {
            try {
                // POPULATE THE HEADER INFORMATION
                // BUILD LIST OF AVAIABLE FILTERS/DEPICTABLE COLUMNS

                // COLLECT META INFORMAITON
                if (pResults.meta) {
                    viewMap.isMapMetaLoaded = true;
                    viewMap.mapMetaData = pResults.meta;
                } else {
                    throw new Error("There is no pin meta data for pin images.");
                }

                // REPLACE THE IMAGE NAME WITH THE BASE64 STRING?
                var zData = [];
                var zDataPickList = [];
                if (pResults.data) {
                    for (var x = 0; x < pResults.data.length; x++) {
                        var zId = x;
                        if (pResults.data[x].UniqueFieldName) { zId = pResults.data[x].UniqueFieldName + "_" + zId; }
                        var zPin = {
                            // FIELDS
                            "UniqueIdentifier": zId,
                            "UniqueFieldName": pResults.data[x].UniqueFieldName,
                            "Latitude": pResults.data[x].Latitude,
                            "Longitude": pResults.data[x].Longitude,
                            "DepictedField": pResults.data[x].DepictedField,
                            "DepictedFieldBackColor": pResults.data[x].DepictedFieldBackColor,
                            "FileNo": pResults.data[x].FileNo,
                            "fldWidth": pResults.data[x].fldWidth,
                            "fldHeight": pResults.data[x].fldHeight,
                            "fldAnchorX": pResults.data[x].fldAnchorX,
                            "fldAnchorY": pResults.data[x].fldAnchorY,
                            "fldTextOffsetX": pResults.data[x].fldTextOffsetX,
                            "fldTextOffsetY": pResults.data[x].fldTextOffsetY,
                            "PinText": pResults.data[x].PinText,
                            "PinValue": pResults.data[x].PinValue,
                            "Radius": pResults.data[x].Radius,
                            "RadiusColor": pResults.data[x].RadiusColor,
                            "TitleSnippet": pResults.data[x].TitleSnippet,
                            "MapPinIcon": viewMap.replaceBaseString(pResults.data[x].MapPinIcon),
                            // MISSING FIELDS
                            "IsHidden": false,
                            "AddressLine": null,
                            "AdminDistrict": null,
                            "Locality": null,
                            "PostalCode": null,
                            "CountryRegion": null,
                            "Client": null,
                            "PracticeCode": null,
                            "PinImageWrapper": null,
                            "PinType": null
                        }
                        var zPickItem = {
                            "UniqueIdentifier": zId,
                            "UniqueFieldName": pResults.data[x].UniqueFieldName,
                            "Latitude": pResults.data[x].Latitude,
                            "Longitude": pResults.data[x].Longitude,
                            "DepictedField": pResults.data[x].DepictedField,
                            "PinValue": pResults.data[x].PinValue,
                        }
                        zData.push(zPin);
                        zDataPickList.push(zPickItem);
                    }
                } else {
                    throw new Error("No locations exist for current filter(s).");
                }

                if (zData.length < 1) {
                    // IF NO LOCATIONS AVAIALBLE, DISPLAY MESSAGE   
                    viewMap.isPinsAvailable = false;
                    viewMap.processMessage("No locations exist for current filter(s).");
                    viewMap.map.utilRemovePins();
                } else {
                    viewMap.mapPinData = zData;
                    viewMap.isPinsAvailable = true;
                    // SETUP THE PICKLIST
                    // WHAT DO WE NEED TO PASS HERE ??? 
                    viewMap.setupPicklist(zDataPickList);
                    // DRAW PINS ON MAP AND STORE THE DATA IN MEMORY
                    viewMap.map.utilAddPins(viewMap.mapPinData);
                }

            } catch (pException) {
                viewMap.processMessage("An error occurred while building map pin data: " + pException.message);
            }
            viewMap.processLoading();
        },
        loadMapDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewMap.processMessage("Error while loading pin data. " + pMessage);
        },


        // LOAD THE MAP DETAIL DATA
        loadMapPinDetails: function () {
            try {
                viewMap.clearMessage();
                var zServiceName = "GetMapPinDetails";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewMap.loadMapPinDetailsSuccess, viewMap.loadMapPinDetailsError, null);
            } catch (pException) {
                viewMap.processMessage("An error occurred while starting the map pin detail data call: " + pException.message);
            }
        },
        loadMapPinDetailsSuccess: function (pResults, pParms) {
            try {

            } catch (pException) {
                viewMap.processMessage("An error occurred while building map pin detail data: " + pException.message);
            }
            viewMap.processLoading();
        },
        loadMapPinDetailsError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewMap.processMessage("Error while loading pin detail data. " + pMessage);
        },


        // START PICKLIST FUNCTIONS
        pickListOpen: function () {
            //if (pField == -1) {
            //    viewMap.textPinFilterString("None");
            //    $("#txtMapFilter").html(" ");
            //    viewMap.clearMessage();
            //    viewMap.countLoading = 1;
            //    viewMap.showLoading();
            //    viewMap.picklist.clearPickListFilter();
            //    var zLocations = viewMap.mapPinData;
            //    viewMap.map.utilAddPins(zLocations);
            //} else {
            viewMap.picklist.pickListOpen(viewMap.pickListFieldName);
            //}
        },


        pickListCancel: function () {
            try {
                viewMap.clearMessage();
                viewMap.picklist.pickListCancel();
            } catch (pException) {
                viewMap.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckAll: function () {
            try {
                viewMap.clearMessage();
                viewMap.picklist.pickListCheckAll();
            } catch (pException) {
                viewMap.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckNone: function () {
            try {
                viewMap.clearMessage();
                viewMap.picklist.pickListCheckNone();
            } catch (pException) {
                viewMap.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListCheckReverse: function () {
            try {
                viewMap.clearMessage();
                viewMap.picklist.pickListCheckReverse();
            } catch (pException) {
                viewMap.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        pickListApplyFilter: function () {
            try {
                viewMap.clearMessage();
                viewMap.picklist.pickListApplyFilter();

                // ADJUST THE LOCATION INFORMATION FOR REDRAWING THE PINS
                var zLocations = viewMap.getLocationsWithExistingFilter();

                // ARE ALL LOCATIONS HIDDEN?   
                var zFound = false;
                for (var x = 0; x < zLocations.length; x++) {
                    if (zLocations[x].IsHidden == false) {
                        zFound = true;
                        break;
                    }
                }

                if (!zFound) {
                    // IF NO LOCATIONS AVAIALBLE, DISPLAY MESSAGE   
                    viewMap.processMessage("No locations exist for current filter(s).");
                    viewMap.hideLoading();
                    viewMap.map.utilRemovePins();
                } else {
                    // REDRAW THE MAP
                    viewMap.map.utilAddPins(zLocations);
                    // GET THE FILTER STRING AND SET IT TO THE SCREEN
                    viewMap.createLabels();
                }

            } catch (pException) {
                viewMap.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },


        getLocationsWithExistingFilter: function () {
            var zReturn = [];
            var zFilteredMapData = [];
            try {

                // ADD ALL THE LOCATIONS TO THE TEMPORARY FILTERED ARRAY AND ADD A MARK AS SAVED FIELD
                zFilteredMapData = JSON.stringify(viewMap.mapPinData);
                zFilteredMapData = JSON.parse(zFilteredMapData);
                for (var x = 0; x < zFilteredMapData.length; x++) {
                    zFilteredMapData[x].FilterMarkAsSaved = null;
                    zFilteredMapData[x].FilterMarkAsDeleted = null;
                }

                // LOOP THROUGH THE PIN INFORMATION AND GET THE FILTER FIELDS TO MATCH AGAINST FILTER CRITERIA
                if (viewMap.picklist.currentFilterObject !== undefined && viewMap.picklist.currentFilterObject !== null) {
                    if (viewMap.picklist.currentFilterObject.filters !== undefined && viewMap.picklist.currentFilterObject.filters !== null && viewMap.picklist.currentFilterObject.filters.length > 0) {
                        for (var x = 0; x < viewMap.picklist.currentFilterObject.filters.length; x++) {
                            for (var y = 0; y < viewMap.picklist.currentFilterObject.filters[x].filters.length; y++) {

                                // GET THE FIELD AND VALUE
                                var zField = viewMap.picklist.currentFilterObject.filters[x].filters[y].field;
                                var zValue = viewMap.picklist.currentFilterObject.filters[x].filters[y].value;
                                var zOperator = viewMap.picklist.currentFilterObject.filters[x].filters[y].operator

                                // LOOP THROUGH THE LOCATIONS
                                if (zOperator == "eq") {
                                    var zDELETEME = 1 + 1;
                                    for (var i = 0; i < zFilteredMapData.length; i++) {
                                        if (zFilteredMapData[i][zField] == zValue) {
                                            zFilteredMapData[i].FilterMarkAsSaved = true;
                                        } else {
                                            // DO NOTHING TO KEEP AND FILTER INTACT, IF IT IS TRUE DON'T RESET IT
                                        }
                                    }
                                } else if (zOperator = "neq") {
                                    var zDELETEME = 1 + 1;
                                    for (var i = 0; i < zFilteredMapData.length; i++) {
                                        if (zFilteredMapData[i][zField] == zValue) {
                                            zFilteredMapData[i].FilterMarkAsDeleted = true;
                                        } else {
                                            // DO NOTHING TO KEEP AND FILTER INTACT, IF IT IS TRUE DON'T RESET IT
                                        }
                                    }
                                }
                            }

                            // AFTER EACH INNER FILTER LOOP REMOVE THE NON-TRUE MARKED RECORDS FOR ANOTHER FILETER LOOP
                            var zDELETEME = 1 + 1;
                            if (zOperator == "eq") {
                                for (var i = zFilteredMapData.length - 1; i > -1; i--) {
                                    if (zFilteredMapData[i].FilterMarkAsSaved !== true) {
                                        zFilteredMapData.splice(i, 1);
                                    }
                                }
                            } else if (zOperator = "neq") {
                                for (var i = zFilteredMapData.length - 1; i > -1; i--) {
                                    if (zFilteredMapData[i].FilterMarkAsDeleted === true) {
                                        zFilteredMapData.splice(i, 1);
                                    }
                                }
                            }

                            // ALSO RESET THE MARKED FIELDS FOR ANOTHER FILTER LOOP
                            for (var i = 0; i < zFilteredMapData.length; i++) {
                                zFilteredMapData[i].FilterMarkAsSaved = null;
                                zFilteredMapData[i].FilterMarkAsDeleted = null;
                            }
                        }

                        // AFTER THE RECORDS HAVE BEEN REMOVED IF FILTERED OUT, ADD THEM TO THE RETURN OBJECT
                        for (var i = 0; i < zFilteredMapData.length; i++) {
                            zReturn.push(zFilteredMapData[i]);
                        }

                    } else {
                        // ADD ALL TO THE ARRAY, NO FILTER
                        for (var i = 0; i < zFilteredMapData.length; i++) {
                            zReturn.push(zFilteredMapData[i]);
                        }
                    }
                } else {
                    // ADD ALL TO THE ARRAY, NO FILTER
                    for (var i = 0; i < zFilteredMapData.length; i++) {
                        zReturn.push(zFilteredMapData[i]);
                    }
                }

            } catch (pException) {
                viewMap.processMessage("An error occurred while creating your pick list filter: " + pException.message);
            }

            return zReturn;
        },
        // END PICK LIST FUNCTIONS


        // MAP FUNCTIONS
        replaceBaseString: function (pIconName) {
            var zReturn = null;
            for (var y = 0; y < viewMap.mapMetaData.length; y++) {
                if (viewMap.mapMetaData[y].fldIcon == pIconName) {
                    zReturn = viewMap.mapMetaData[y].fldBaseString;
                    break;
                }
            }
            return zReturn;
        },


        showMap: function () {
            try {
                // OPEN THE MAP
                viewMap.clearMessage();
                if (!viewMap.isInitComplete) {
                    viewMap.bindForm();
                    viewMap.init();
                } else {
                    if (viewMap.isPinsAvailable) {
                        viewMap.map.utilResetMap();
                        viewMap.loadData();
                        $("#divContainerMap").fadeIn();
                        $("#divViewGridButtonContainer").fadeOut(function () {
                            $("#divViewMapButtonContainer").fadeIn(function () {
                                $("#divContainerGrid").fadeOut(1);
                            });
                        });
                    }
                }
                globalIsMapShown = true;
            } catch (pException) {
                viewMap.processMessage("Error while showing the map. " + pException.message);
            }
            return false;
        },


        showMapNoLoad: function () {
            try {
                viewMap.clearMessage();
                $("#divContainerMap").fadeIn();
                $("#divViewGridButtonContainer").fadeOut(function () {
                    $("#divViewMapButtonContainer").fadeIn(function () {
                        $("#divContainerGrid").fadeOut(1);
                    });
                });
            } catch (pException) {
                viewMap.processMessage("Error while showing the map. " + pException.message);
            }
            return false;
        },


        hideMap: function () {
            try {
                viewMap.clearMessage();
                viewMap.pickListCancel();
                $("#divContainerGrid").fadeIn(1, function () {
                    $("#divContainerMap").fadeOut();
                });
                $("#divViewMapButtonContainer").fadeOut(function () {
                    $("#divViewGridButtonContainer").fadeIn();
                });
                globalIsMapShown = false;
            } catch (pException) {
                viewMap.processMessage("Error while hiding the map. " + pException.message);
            }
            return false;
        },


        showMapPicklist: function () {
        },


        createLabels: function () {
            //// SET THE DISPLAY STRINGS
            //var zFilterMapString = viewMap.picklist.getFilterString().replace("PinValue", "Pin Value");
            //var zFilterMapDisplay = "On " + viewGrid.mapDepictedDisplayCurrent.trim();
            //var zFilteredGridBy = "None";
            //if (viewGrid.txtFilteredBy()) {
            //    zFilteredGridBy = viewGrid.txtFilteredBy();
            //}
            //if (viewMap.picklist.getFilterString() && viewMap.picklist.getFilterString().length > 0) {
            //    $("#spnFilteredByText").show(1);
            //    zFilterMapDisplay = zFilterMapDisplay + ", " + zFilterMapString;
            //} else {
            //    $("#spnFilteredByText").hide(1);
            //}
            //$("#txtFilteredBy").html(zFilteredGridBy);
            //$("#txtMapPinCount").html(viewMap.map.utilPinCount);
            //$("#txtMapFilter").html(zFilterMapDisplay);
        },


        onPinClick: function (pCallBackObj, pEvent) {
            try {
                // PASS THE OBJECT AND THE IMAGE TO THE POPUP
                viewMap.clearMessage();
                gIsPinClicked = true;
                gOpenWindow(globalPopupFileName, globalPopupTitle, pCallBackObj.PinObject.FileNo, null, null);
                setTimeout(function () {
                    // AFTER SOME TIME, RESET THE PIN CLICKED FLAG
                    gIsPinClicked = false;
                }, 2000);
            } catch (pException) {
                viewMap.processMessage("Error while building popup windows. " + pException.message);
            }
        },


        onDrawPinComplete: function () {
            try {
                viewMap.createLabels();
            } catch (pException) {
                viewMap.processMessage("Error while building popup windows. " + pException.message);
            }
        },
        // END MAP FUNCTIONS


        setupPicklist: function (pFilterData) {
            if (!viewMap.picklist) {
                viewMap.picklist = new utilPicklist();
                viewMap.picklist.setupOptions();
                viewMap.picklist.initPickList("windowPickListMap", null, pFilterData, null);
            } else {
                viewMap.picklist.resetPicklist(pFilterData);
            }
        },


        setupMap: function () {
            try {
                setTimeout(function () {
                    if (!viewMap.map) {
                        viewMap.map = new bingLT();
                        viewMap.map.test.consoleLogging = false;
                        viewMap.map.test.addDebugger = false;
                        viewMap.map.optionsBingLT.isLocal = false;
                        viewMap.map.initMap("mapContainer", null, globalKeyAppName, globalKeyApplication, globalKeyBing, viewMap.map.loggingTypes.Monitor, BINGLTSERVERENDPOINT);
                        viewMap.map.utilInit(null, "imgHldr", viewMap.onPinClick, viewMap.onDrawPinComplete);
                        // RESIZE THE HEIGHT OF THE MAP TO COMPENSATE FOR THE BANNER
                        var zHeight = $(window).height() - 90; // ALLOWANCE FOR BLUE BAR AND TOP HEADER
                        //var zHeight = $("#viewMap").height();
                        $("#viewMap").height(zHeight);
                        //var zHeight = $("#mapContainer").height();
                        $("#mapContainer").height(zHeight);
                        //var zHeight = $("#mapPage").height();
                        $("#mapPage").height(zHeight);
                        $("#divContainerMap").height(zHeight);
                    } else {
                        viewMap.map.utilResetMap();
                    }
                }, 100);
            } catch (pException) {
                viewMap.processMessage("Error while setting up map. " + pException.message);
            }
            viewMap.processLoading();
        },


        setupKendo: function () {
            viewMap.processLoading();
        },


        setupEvents: function () {
            try {
            } catch (pException) {
                viewMap.processMessage("Error while building popup windows. " + pException.message);
            }
            viewMap.processLoading();
        },


        bindForm: function () {
            if (!viewMap.isFormBound) {
                viewMap.isFormBound = true;
                ko.applyBindings(viewMap, $("#viewMap")[0]);
            }
        },


        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },


        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },


        clearMessage: function () {
            viewMap.txtMapMessage("");
            $("#txtMapMessage").html("");
            $("#txtMapMessageContainer").slideUp();
        },


        processMessage: function (pMessage) {
            alert(pMessage);
            viewMap.txtMapMessage(pMessage);
            $("#txtMapMessage").html(pMessage);
            $("#txtMapMessageContainer").slideDown();
            setTimeout(function () {
                global.messageShow("txtMapMessage", "messageMapError");
            }, 333);
            //if (viewGrid) {
            //    if (viewGrid.processMessage) {
            //        viewGrid.processMessage(pMessage);
            //    }
            //}
            viewMap.hideLoading();
        },


        processLoading: function () {
            viewMap.countLoading--;
            if (viewMap.countLoading < 1) {
                if (!viewMap.isInitComplete && viewMap.isPinsAvailable) {
                    viewMap.isInitComplete = true;
                    viewMap.showMapNoLoad();
                }
                viewMap.hideLoading();
            } else {
            }
        }
    };

    // BIND AND INIT FORM
    //viewMap.bindForm();
    //viewMap.init();


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    gDrawCircles = function () {
        viewMap.map.utilDrawCirclesTest();
    }

    gShowMap = function () {
        viewMap.showMap();
    }

    gHideMap = function () {
        viewMap.hideMap();
    }

    gPickListOpen = function () {
        viewMap.pickListOpen();
    }

    globalPickListStandAloneCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "windowPickListMap":
                viewMap.picklist.pickListCheck(pField, pId);
                break;
            default:
                viewMap.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

});