$(document).ready(function () {

    // GLOBAL DATA PLACEHOLDERS
    globalKeyAppName = "GRC.Connect";
    globalKeyApplication = "01552c1572d14ff9b108f44f1b3c1d76";
    globalKeyBing = gServerSide_BingMapKey;
    //globalIsMapShown = false;

    // VIEW
    viewMap = {
        // DECLARATIONS
        firstLoad: true,
        countLoading: 7,
        isInitComplete: false,
        isMapMetaLoaded: false,
        isFormBound: false,
        isPinsAvailable: false,
        isPinsShapeAvailable: false,
        constDivContainerLoading: "divContainerLoading",

        // DATA
        mapPinData: [],
        mapPinShapeData: [],
        mapMetaData: [],
        mapMetaShapeData: [],
        mapGridFilter: "",
        mapPinFilter: "",
        depictedByColumnName: null,
        pickListFieldName: "PinValue",

        // LABELS
        txtMapMessage: ko.observable(),

        // BUTTON AND VISIBILITY CONTROLS

        // OBJECTS
        map: null,
        picklist: null,

        // FUNCTIONS
        init: function () {
            if (!viewMap.isInitComplete) {
                viewMap.countLoading = 6;
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
            viewMap.loadMapData();
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

                // This next test allows this page to work with standard.aspx and facilityrating.aspx
                if (typeof viewStandardGrid === "undefined") {
                    if (viewFacilityRatingGrid.gridStandard.grid.dataSource.sort()) { zSort = JSON.stringify(viewFacilityRatingGrid.gridStandard.grid.dataSource.sort()); }
                    if (viewFacilityRatingGrid.gridStandard.grid.dataSource.filter()) { viewMap.mapGridFilter = JSON.stringify(viewFacilityRatingGrid.gridStandard.grid.dataSource.filter()); }
                    if (viewFacilityRatingGrid.gridCriteriaFilter) { zCriteria = viewFacilityRatingGrid.gridCriteriaFilter; }
                    // CALL SERVICE
                    var zServiceName = "GetMapData";
                    var zParms = ko.toJSON({
                        "sort": zSort,
                        "filter": viewMap.mapGridFilter,
                        "criteria": zCriteria,
                        "gSafeGuid": getGSafeGUID(),
                        "pDepictedByColumnName": viewFacilityRatingGrid.mapDepictedNameCurrent
                    });
                } else {
                    if (viewStandardGrid.gridStandard.grid.dataSource.sort()) { zSort = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.sort()); }
                    if (viewStandardGrid.gridStandard.grid.dataSource.filter()) { viewMap.mapGridFilter = JSON.stringify(viewStandardGrid.gridStandard.grid.dataSource.filter()); }
                    if (viewStandardGrid.gridCriteriaFilter) { zCriteria = viewStandardGrid.gridCriteriaFilter; }
                    // CALL SERVICE
                    var zServiceName = "GetMapData";
                    var zParms = ko.toJSON({
                        "sort": zSort,
                        "filter": viewMap.mapGridFilter,
                        "criteria": zCriteria,
                        "gSafeGuid": getGSafeGUID(),
                        "pDepictedByColumnName": viewStandardGrid.mapDepictedNameCurrent
                    });
                }
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
                var zData = null;
                var zDataPickList = null;
                zData = [];
                zDataPickList = [];
                if (pResults.data) {
                    if (pResults.data.length <= 1000) {
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
                        throw new Error("Please select a grid filter to show less than 1000 pins / locations.");
                    }
                } else {
                    throw new Error("No locations exist for current filter(s).");
                }

                if (zData.length < 1) {
                    // IF NO LOCATIONS AVAIALBLE, DISPLAY MESSAGE   
                    viewMap.isPinsAvailable = false;
                    viewMap.processMessage("No locations exist for current filter(s).");
                    viewMap.map.utilRemovePins();
                    viewMap.processLoading();
                } else {
                    viewMap.mapPinData = zData;
                    viewMap.isPinsAvailable = true;
                    // SETUP THE PICKLIST
                    // WHAT DO WE NEED TO PASS HERE ??? 
                    viewMap.setupPicklist(zDataPickList);
                    // DRAW PINS ON MAP AND STORE THE DATA IN MEMORY
                    viewMap.map.utilAddPins(viewMap.mapPinData);
                }

                // LOAD THE SHAPES
                var zIsMapShapes = global.getQueryVariable("mapshapes");
                if (zIsMapShapes === "true") {
                    viewMap.loadMapShapeData();
                } else {
                    viewMap.processLoading();
                }
                
                // CLEAR GARBAGE
                pResults = null;
                zData = null;
                zDataPickList = null;

            } catch (pException) {
                viewMap.processMessage("An error occurred while building map pin data: " + pException.message);
                // CLEAR GARBAGE
                pResults = null;
            }
        },
        loadMapDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewMap.processMessage("Error while loading pin data. " + pMessage);
        },


        // LOAD THE MAP META DATA
        loadMapShapeData: function () {
            try {
                // SETUP
                viewMap.clearMessage();
                viewMap.mapPinShapeData = [];
                viewMap.mapMetaShapeData = [];
                // GATHER DATA FROM THE GRID
                viewMap.mapPinFilter = null;
                viewMap.mapGridFilter = null;
                // CALL SERVICE
                var zServiceName = "GetMapShapeData";
                var zParms = ko.toJSON({
                    "gSafeGuid": getGSafeGUID()
                    //,"pShapeSide": 36
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewMap.loadMapShapeDataSuccess, viewMap.loadMapShapeDataError, null);
            } catch (pException) {
                viewMap.processMessage("An error occurred while starting the map pin shape data call: " + pException.message);
            }
        },
        loadMapShapeDataSuccess: function (pResults, pParms) {
            try {
                // POPULATE THE HEADER INFORMATION
                // BUILD LIST OF AVAIABLE FILTERS/DEPICTABLE COLUMNS

                // COLLECT META INFORMAITON
                if (pResults.meta) {
                    viewMap.isMapMetaLoaded = true;
                    viewMap.mapMetaShapeData = pResults.meta;
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
                            "MapPinIcon": viewMap.replaceBaseStringShapes(pResults.data[x].MapPinIcon),
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
                    throw new Error("No shape locations exist for current filter(s).");
                }

                if (zData.length < 1) {
                    // IF NO LOCATIONS AVAIALBLE, DISPLAY MESSAGE   
                    //viewMap.isPinsShapeAvailable = false;
                    //viewMap.processMessage("No shape locations exist for current filter(s).");
                    //viewMap.map.utilRemovePins();
                } else {
                    viewMap.mapPinShapeData = zData;
                    viewMap.isPinsShapeAvailable = true;
                    // SETUP THE PICKLIST
                    // WHAT DO WE NEED TO PASS HERE ??? 
                    //viewMap.setupPicklist(zDataPickList);
                    // DRAW PINS ON MAP AND STORE THE DATA IN MEMORY
                    viewMap.map.utilAddPinShapes(viewMap.mapPinShapeData);
                }

                // CLEAR GARBAGE
                pResults = null;
                zData = null;
                zDataPickList = null;

            } catch (pException) {
                viewMap.processMessage("An error occurred while building map pin shape data: " + pException.message);
                // CLEAR GARBAGE
                pResults = null;
            }
            viewMap.processLoading();
        },
        loadMapShapeDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewMap.processMessage("Error while loading pin shape data. " + pMessage);
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
            viewMap.picklist.pickListOpen(viewMap.pickListFieldName);
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
                    var zIsMapShapes = global.getQueryVariable("mapshapes");
                    if (zIsMapShapes === "true") {
                        viewMap.map.utilAddPinShapes(viewMap.mapPinShapeData);
                    }
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
                                var zIsEmpty = false;
                                var zField = viewMap.picklist.currentFilterObject.filters[x].filters[y].field;
                                var zValue = viewMap.picklist.currentFilterObject.filters[x].filters[y].value;
                                var zOperator = viewMap.picklist.currentFilterObject.filters[x].filters[y].operator

                                // CORRECTION FOR NULL VALUES
                                if (zValue === "" || zValue === null) { zIsEmpty = true; }

                                // LOOP THROUGH THE LOCATIONS
                                if (zOperator == "eq") {
                                    var zDELETEME = 1 + 1;
                                    for (var i = 0; i < zFilteredMapData.length; i++) {
                                        if (zIsEmpty) {
                                            if (zFilteredMapData[i][zField] === "" || zFilteredMapData[i][zField] === null) {
                                                zFilteredMapData[i].FilterMarkAsSaved = true;
                                            } else {
                                                // DO NOTHING TO KEEP AND FILTER INTACT, IF IT IS TRUE DON'T RESET IT
                                            }
                                        } else {
                                            if (zFilteredMapData[i][zField] == zValue) {
                                                zFilteredMapData[i].FilterMarkAsSaved = true;
                                            } else {
                                                // DO NOTHING TO KEEP AND FILTER INTACT, IF IT IS TRUE DON'T RESET IT
                                            }
                                        }
                                    }
                                } else if (zOperator = "neq") {
                                    var zDELETEME = 1 + 1;
                                    for (var i = 0; i < zFilteredMapData.length; i++) {
                                        if (zIsEmpty) {
                                            if (zFilteredMapData[i][zField] === "" || zFilteredMapData[i][zField] === null) {
                                                zFilteredMapData[i].FilterMarkAsDeleted = true;
                                            } else {
                                                // DO NOTHING TO KEEP AND FILTER INTACT, IF IT IS TRUE DON'T RESET IT
                                            }
                                        } else {
                                            if (zFilteredMapData[i][zField] == zValue) {
                                                zFilteredMapData[i].FilterMarkAsDeleted = true;
                                            } else {
                                                // DO NOTHING TO KEEP AND FILTER INTACT, IF IT IS TRUE DON'T RESET IT
                                            }
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
            var zFound = false;
            for (var y = 0; y < viewMap.mapMetaData.length; y++) {
                if (viewMap.mapMetaData[y].fldIcon == pIconName) {
                    zReturn = viewMap.mapMetaData[y].fldBaseString;
                    zFound = true;
                    break;
                }
            }
            if (!zFound) {
                // IF NOTHING FOUND, USE THE DEFAULT PIN
                zReturn = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAA2RpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMC1jMDYwIDYxLjEzNDc3NywgMjAxMC8wMi8xMi0xNzozMjowMCAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wTU09Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9tbS8iIHhtbG5zOnN0UmVmPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvc1R5cGUvUmVzb3VyY2VSZWYjIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDo5NjFFRUFDMDI2MzBFNzExQTdCNDlERDkxMzVDMTIyQSIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDpDMzI0QjcyNzMwMzIxMUU3OTIxQ0IwNzA1QTNFNTczNSIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDpDMzI0QjcyNjMwMzIxMUU3OTIxQ0IwNzA1QTNFNTczNSIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ1M1IFdpbmRvd3MiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDo5RTFFRUFDMDI2MzBFNzExQTdCNDlERDkxMzVDMTIyQSIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDo5NjFFRUFDMDI2MzBFNzExQTdCNDlERDkxMzVDMTIyQSIvPiA8L3JkZjpEZXNjcmlwdGlv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";
            }
            return zReturn;
        },


        replaceBaseStringShapes: function (pIconName) {
            var zReturn = null;
            var zFound = false;
            for (var y = 0; y < viewMap.mapMetaShapeData.length; y++) {
                if (viewMap.mapMetaShapeData[y].fldIcon == pIconName) {
                    zReturn = viewMap.mapMetaShapeData[y].fldBaseString;
                    zFound = true;
                    break;
                }
            }
            if (!zFound) {
                // IF NOTHING FOUND, USE THE DEFAULT PIN
                zReturn = "data:image/png;base64,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6H7o/ujz8cGn1E+f/gUDmPP8usTo0wAAAAlwSFlzAAAOwwAADsMBx2+oZAAAXrdpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+Cjx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuNi1jMTExIDc5LjE1ODMyNSwgMjAxNS8wOS8xMC0wMToxMDoyMCAgICAgICAgIj4KICAgPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4KICAgICAgPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIKICAgICAgICAgICAgeG1sbnM6ZGM9Imh0dHA6Ly9wdXJsLm9yZy9kYy9lbGVtZW50cy8xLjEvIgogICAgICAgICAgICB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iCiAgICAgICAgICAgIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIgogICAgICAgICAgICB4bWxuczpzdFJlZj0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIKICAgICAgICAgICAgeG1sbnM6c3RFdnQ9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZUV2ZW50IyIKICAgICAgICAgICAgeG1sbnM6cGhvdG9zaG9wPSJodHRwOi8vbnMuYWRvYmUuY29tL3Bob3Rvc2hvcC8xLjAvIgogICAgICAgICAgICB4bWxuczp4bXBSaWdodHM9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9yaWdodHMvIgogICAgICAgICAgICB4bWxuczp0aWZmPSJodHRwOi8vbnMuYWRvYmUuY29tL3RpZmYvMS4wLyIKICAgICAgICAgICAgeG1sbnM6ZXhpZj0iaHR0cDovL25zLmFkb2JlLmNvbS9leGlmLzEuMC8iPgogICAgICAgICA8ZGM6Zm9ybWF0PmltYWdlL3BuZzwvZGM6Zm9ybWF0PgogICAgICAgICA8eG1wOkNyZWF0b3JUb29sPkFkb2JlIFBob3Rvc2hvcCBDQyAyMDE1IChXaW5kb3dzKTwveG1wOkNyZWF0b3JUb29sPgogICAgICAgICA8eG1wOkNyZWF0ZURhdGU+MjAxNS0wNC0wN1QxMDozNjowNi0wNDowMDwveG1wOkNyZWF0ZURhdGU+CiAgICAgICAgIDx4bXA6TW9kaWZ5RGF0ZT4yMDE3LTAyLTE2VDEzOjU0OjMxLTA1OjAwPC94bXA6TW9kaWZ5RGF0ZT4KICAgICAgICAgPHhtcDpNZXRhZGF0YURhdGU+MjAxNy0wMi0xNlQxMzo1NDozMS0wNTowMDwveG1wOk1ldGFkYXRhRGF0ZT4KICAgICAgICAgPHhtcE1NOkRvY3VtZW50SUQ+YWRvYmU6ZG9jaWQ6cGhvdG9zaG9wOjRhMmM1MjlkLWY0NzktMTFlNi1hODNkLWI1YzlhZGE0MDRjNzwveG1wTU06RG9jdW1lbnRJRD4KICAgICAgICAgPHhtcE1NOkluc3RhbmNlSUQ+eG1wLmlpZDpkMDdlZjIzYS03NWM4LTY2NDMtYjNhZC1hNGVkYzUwZGU5ZGU8L3htcE1NOkluc3RhbmNlSUQ+CiAgICAgICAgIDx4bXBNTTpEZXJpdmVkRnJvbSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgIDxzdFJlZjppbnN0YW5jZUlEPnhtcC5paWQ6MThlMTc3NmQtYWNhOS0xZDRhLTkxZjItMTUwOTIyNzZhOTIwPC9zdFJlZjppbnN0YW5jZUlEPgogICAgICAgICAgICA8c3RSZWY6ZG9jdW1lbnRJRD51dWlkOjYyRDk5RjY2MzNEREU0MTFBMkRDODJBOUYzQjEwQUE0PC9zdFJlZjpkb2N1bWVudElEPgogICAgICAgICAgICA8c3RSZWY6b3JpZ2luYWxEb2N1bWVudElEPnV1aWQ6NjJEOTlGNjYzM0RERTQxMUEyREM4MkE5RjNCMTBBQTQ8L3N0UmVmOm9yaWdpbmFsRG9jdW1lbnRJRD4KICAgICAgICAgPC94bXBNTTpEZXJpdmVkRnJvbT4KICAgICAgICAgPHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD51dWlkOjYyRDk5RjY2MzNEREU0MTFBMkRDODJBOUYzQjEwQUE0PC94bXBNTTpPcmlnaW5hbERvY3VtZW50SUQ+CiAgICAgICAgIDx4bXBNTTpIaXN0b3J5PgogICAgICAgICAgICA8cmRmOlNlcT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDphY3Rpb24+c2F2ZWQ8L3N0RXZ0OmFjdGlvbj4KICAgICAgICAgICAgICAgICAgPHN0RXZ0Omluc3RhbmNlSUQ+eG1wLmlpZDowRUY4RUM0NkY0RjJFNjExOENBNkM2QUNFOEVBMDNFODwvc3RFdnQ6aW5zdGFuY2VJRD4KICAgICAgICAgICAgICAgICAgPHN0RXZ0OndoZW4+MjAxNy0wMi0xNFQxNToyOToyNS0wNTowMDwvc3RFdnQ6d2hlbj4KICAgICAgICAgICAgICAgICAgPHN0RXZ0OnNvZnR3YXJlQWdlbnQ+QWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzPC9zdEV2dDpzb2Z0d2FyZUFnZW50PgogICAgICAgICAgICAgICAgICA8c3RFdnQ6Y2hhbmdlZD4vPC9zdEV2dDpjaGFuZ2VkPgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDphY3Rpb24+c2F2ZWQ8L3N0RXZ0OmFjdGlvbj4KICAgICAgICAgICAgICAgICAgPHN0RXZ0Omluc3RhbmNlSUQ+eG1wLmlpZDoxOGUxNzc2ZC1hY2E5LTFkNGEtOTFmMi0xNTA5MjI3NmE5MjA8L3N0RXZ0Omluc3RhbmNlSUQ+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDp3aGVuPjIwMTctMDItMTZUMTM6NTQ6MzEtMDU6MDA8L3N0RXZ0OndoZW4+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDpzb2Z0d2FyZUFnZW50PkFkb2JlIFBob3Rvc2hvcCBDQyAyMDE1IChXaW5kb3dzKTwvc3RFdnQ6c29mdHdhcmVBZ2VudD4KICAgICAgICAgICAgICAgICAgPHN0RXZ0OmNoYW5nZWQ+Lzwvc3RFdnQ6Y2hhbmdlZD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8c3RFdnQ6YWN0aW9uPmNvbnZlcnRlZDwvc3RFdnQ6YWN0aW9uPgogICAgICAgICAgICAgICAgICA8c3RFdnQ6cGFyYW1ldGVycz5mcm9tIGFwcGxpY2F0aW9uL3ZuZC5hZG9iZS5waG90b3Nob3AgdG8gaW1hZ2UvcG5nPC9zdEV2dDpwYXJhbWV0ZXJzPgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDphY3Rpb24+ZGVyaXZlZDwvc3RFdnQ6YWN0aW9uPgogICAgICAgICAgICAgICAgICA8c3RFdnQ6cGFyYW1ldGVycz5jb252ZXJ0ZWQgZnJvbSBhcHBsaWNhdGlvbi92bmQuYWRvYmUucGhvdG9zaG9wIHRvIGltYWdlL3BuZzwvc3RFdnQ6cGFyYW1ldGVycz4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8c3RFdnQ6YWN0aW9uPnNhdmVkPC9zdEV2dDphY3Rpb24+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDppbnN0YW5jZUlEPnhtcC5paWQ6ZDA3ZWYyM2EtNzVjOC02NjQzLWIzYWQtYTRlZGM1MGRlOWRlPC9zdEV2dDppbnN0YW5jZUlEPgogICAgICAgICAgICAgICAgICA8c3RFdnQ6d2hlbj4yMDE3LTAyLTE2VDEzOjU0OjMxLTA1OjAwPC9zdEV2dDp3aGVuPgogICAgICAgICAgICAgICAgICA8c3RFdnQ6c29mdHdhcmVBZ2VudD5BZG9iZSBQaG90b3Nob3AgQ0MgMjAxNSAoV2luZG93cyk8L3N0RXZ0OnNvZnR3YXJlQWdlbnQ+CiAgICAgICAgICAgICAgICAgIDxzdEV2dDpjaGFuZ2VkPi88L3N0RXZ0OmNoYW5nZWQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICA8L3JkZjpTZXE+CiAgICAgICAgIDwveG1wTU06SGlzdG9yeT4KICAgICAgICAgPHBob3Rvc2hvcDpDb2xvck1vZGU+MzwvcGhvdG9zaG9wOkNvbG9yTW9kZT4KICAgICAgICAgPHBob3Rvc2hvcDpJQ0NQcm9maWxlPnNSR0IgSUVDNjE5NjYtMi4xPC9waG90b3Nob3A6SUNDUHJvZmlsZT4KICAgICAgICAgPHBob3Rvc2hvcDpUZXh0TGF5ZXJzPgogICAgICAgICAgICA8cmRmOkJhZz4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjEyIC0gREVDPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5ERUM8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MTEgLSBOT1Y8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0Pk5PVjwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4xMCAtIE9DVDwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+T0NUPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjA5IC0gU0VQPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5TRVA8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MDggLSBBVUc8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkFVRzwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4wNyAtIEpVTDwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+SlVMPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjA2IC0gSlVOPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5KVU48L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MDUgLSBNQVk8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0Pk1BWTwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4wNCAtIEFQUjwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+QVBSPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjAzIC0gTUFSPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5NQVI8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MDIgLSBGRUI8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkZFQjwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4wMSAtIEpBTjwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+SkFOPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPlBsdXMgU2lnbjwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+KzwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT5QbHVzIFNpZ24gY29weTwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+KzwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT5NPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5NPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPkY8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkY8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+STwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+STwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT5CPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5CPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPkQ8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkQgPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjEyIC0gREVDIGNvcHk8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkRFQzwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4xMSAtIE5PViBjb3B5PC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5OT1Y8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MTAgLSBPQ1QgY29weTwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+T0NUPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjA5IC0gU0VQIGNvcHk8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PlNFUDwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4wOCAtIEFVRyBjb3B5PC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5BVUc8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MDcgLSBKVUwgY29weTwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+SlVMPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjA2IC0gSlVOIGNvcHk8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkpVTjwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4wNSAtIE1BWSBjb3B5PC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5NQVk8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MDQgLSBBUFIgY29weTwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+QVBSPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPjAzIC0gTUFSIGNvcHk8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0Pk1BUjwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT4wMiAtIEZFQiBjb3B5PC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5GRUI8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+MDEgLSBKQU4gY29weTwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+SkFOPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPlBsdXMgU2lnbiBjb3B5IDI8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0Pis8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+UGx1cyBTaWduIGNvcHkgMzwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+KzwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT5NPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5NPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSJSZXNvdXJjZSI+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJOYW1lPkY8L3Bob3Rvc2hvcDpMYXllck5hbWU+CiAgICAgICAgICAgICAgICAgIDxwaG90b3Nob3A6TGF5ZXJUZXh0PkY8L3Bob3Rvc2hvcDpMYXllclRleHQ+CiAgICAgICAgICAgICAgIDwvcmRmOmxpPgogICAgICAgICAgICAgICA8cmRmOmxpIHJkZjpwYXJzZVR5cGU9IlJlc291cmNlIj4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllck5hbWU+STwvcGhvdG9zaG9wOkxheWVyTmFtZT4KICAgICAgICAgICAgICAgICAgPHBob3Rvc2hvcDpMYXllclRleHQ+STwvcGhvdG9zaG9wOkxheWVyVGV4dD4KICAgICAgICAgICAgICAgPC9yZGY6bGk+CiAgICAgICAgICAgICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0iUmVzb3VyY2UiPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyTmFtZT5CPC9waG90b3Nob3A6TGF5ZXJOYW1lPgogICAgICAgICAgICAgICAgICA8cGhvdG9zaG9wOkxheWVyVGV4dD5CPC9waG90b3Nob3A6TGF5ZXJUZXh0PgogICAgICAgICAgICAgICA8L3JkZjpsaT4KICAgICAgICAgICAgPC9yZGY6QmFnPgogICAgICAgICA8L3Bob3Rvc2hvcDpUZXh0TGF5ZXJzPgogICAgICAgICA8eG1wUmlnaHRzOk1hcmtlZD5GYWxzZTwveG1wUmlnaHRzOk1hcmtlZD4KICAgICAgICAgPHRpZmY6T3JpZW50YXRpb24+MTwvdGlmZjpPcmllbnRhdGlvbj4KICAgICAgICAgPHRpZmY6WFJlc29sdXRpb24+OTYwMDAwLzEwMDAwPC90aWZmOlhSZXNvbHV0aW9uPgogICAgICAgICA8dGlmZjpZUmVzb2x1dGlvbj45NjAwMDAvMTAwMDA8L3RpZmY6WVJlc29sdXRpb24+CiAgICAgICAgIDx0aWZmOlJlc29sdXRpb25Vbml0PjI8L3RpZmY6UmVzb2x1dGlvblVuaXQ+CiAgICAgICAgIDxleGlmOkNvbG9yU3BhY2U+MTwvZXhpZjpDb2xvclNwYWNlPgogICAgICAgICA8ZXhpZjpQaXhlbFhEaW1lbnNpb24+NDI8L2V4aWY6UGl4ZWxYRGltZW5zaW9uPgogICAgICAgICA8ZXhpZjpQaXhlbFlEaW1lbnNpb24+NDI8L2V4aWY6UGl4ZWxZRGltZW5zaW9uPgogICAgICA8L3JkZjpEZXNjcmlwdGlvbj4KICAgPC9yZGY6UkRGPgo8L3g6eG1wbWV0YT4KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAKPD94cGFja2V0IGVuZD0idyI/PpHM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";
            }
            return zReturn;
        },


        showMap: function () {
            try {
                // OPEN THE MAP
                viewMap.showLoading();
                viewMap.clearMessage();
                if (!viewMap.isInitComplete) {
                    viewMap.bindForm();
                    viewMap.init();
                } else {
                    if (viewMap.isPinsAvailable) {
                        viewMap.countLoading = 3;
                        viewMap.map.utilResetMap();
                        viewMap.loadData();
                        $("#divContainerMap").fadeIn();
                        $("#mapstrip").fadeIn();
                        $("#divViewGridButtonContainer").fadeOut(function () {
                            $("#divViewMapButtonContainer").fadeIn(function () {
                                $("#divContainerGrid").fadeOut(1);
                                viewMap.processLoading();
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
                $("#mapstrip").fadeIn();
                $("#divViewGridButtonContainer").fadeOut(function () {
                    $("#divViewMapButtonContainer").fadeIn(function () {
                        $("#divContainerGrid").fadeOut(1);
                        viewMap.processLoading();
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
                    viewMap.hideLoading();
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
            // SET THE DISPLAY STRINGS
            var zFilterMapString = viewMap.picklist.getFilterString().replace("PinValue", "Pin Value");

            // This next test allows this page to work with standard.aspx and facilityrating.aspx
            if (typeof viewStandardGrid === "undefined") {
                var zFilterMapDisplay = "On " + viewFacilityRatingGrid.mapDepictedDisplayCurrent.trim();
                var zFilteredGridBy = "None";
                if (viewFacilityRatingGrid.txtFilteredBy()) {
                    zFilteredGridBy = viewFacilityRatingGrid.txtFilteredBy();
                }
            } else {
                var zFilterMapDisplay = "On " + viewStandardGrid.mapDepictedDisplayCurrent.trim();
                var zFilteredGridBy = "None";
                if (viewStandardGrid.txtFilteredBy()) {
                    zFilteredGridBy = viewStandardGrid.txtFilteredBy();
                }
            }

            if (viewMap.picklist.getFilterString() && viewMap.picklist.getFilterString().length > 0) {
                $("#spnFilteredByText").show(1);
                zFilterMapDisplay = zFilterMapDisplay + ", " + zFilterMapString;
            } else {
                $("#spnFilteredByText").hide(1);
            }
            $("#txtFilteredBy").html(zFilteredGridBy);
            $("#txtMapPinCount").html(viewMap.map.utilPinCount);
            $("#txtMapFilter").html(zFilterMapDisplay);
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
                viewMap.processLoading();
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
                        var zHeight = $(window).height(); // ALLOWANCE FOR BLUE BAR AND TOP HEADER
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
            $("#divContainerLoading").show();
        },


        hideLoading: function () {
            setTimeout(function () {
                $("#divContainerLoading").hide();
            }, 667);
        },


        clearMessage: function () {
            viewMap.txtMapMessage("");
            $("#txtMapMessage").html("");
            $("#txtMapMessageContainer").slideUp();
        },


        processMessage: function (pMessage) {
            //alert(pMessage);
            viewMap.txtMapMessage(pMessage);
            $("#txtMapMessage").html(pMessage);
            $("#txtMapMessageContainer").slideDown();
            setTimeout(function () {
                global.messageShow("txtMapMessage", "messageMapError");
            }, 333);

            // This next test allows this page to work with standard.aspx and facilityrating.aspx
            if (typeof viewStandardGrid === "undefined") {
                if (viewFacilityRatingGrid) {
                    if (viewFacilityRatingGrid.processMessage) {
                        viewFacilityRatingGrid.processMessage(pMessage);
                    }
                }
            } else {
                if (viewStandardGrid) {
                    if (viewStandardGrid.processMessage) {
                        viewStandardGrid.processMessage(pMessage);
                    }
                }
            }
            viewMap.hideLoading();
        },


        processLoading: function () {
            viewMap.countLoading--;
            if (viewMap.countLoading < 1) {
                if (!viewMap.isInitComplete && viewMap.isPinsAvailable) {
                    viewMap.isInitComplete = true;
                    viewMap.showMapNoLoad();
                } else {
                    viewMap.hideLoading();
                }
            } else {
            }
        }
    };


    // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
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