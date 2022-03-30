/*
    VERSION: v8.1.0
    DATE: 2017.05.22

    FOR INFORMATION ABOUT THE CONVERSION FROM v7 TO v8 SEE THE BELOW LINK:
    https://social.technet.microsoft.com/wiki/contents/articles/34563.bing-maps-v7-to-v8-migration-guide.aspx#Deprecated_Modules
    
    THIS IS AN EXTENSION CLASS OF bingLT
    bingLT MUST BE CALLED AND INITIALIZED BEFORE USING THIS CLASS

    REQUIRMENTS:
    JQuery 1.11 or above
    Bing Maps AJAX javascript library 7 
    FUTURE OPTION = Heatmap Library
    FUTURE OPTION = Other Map Libraries
    OLDER BROWSERS REQUIRE json2.js
    bingLT.min.js or bingLT.debug.js

    INSTRUCTIONS:
    1) Set the field name properties that match your data for locality definitions and identifier column.  Example: AdminDistrict = City
    2) Run the utilInit function AFTER the bingLT object is initialized and after bingLT options are set.
    3) It is recommented that each tool tip have it's own unique ID to control the hide when hover.

*/

// PUBLIC PROPERTIES
// Field names for address and identifier fields
bingLT.prototype.utilFieldNameUniqueIdentifier = "UniqueIdentifier";
bingLT.prototype.utilFieldNameUniqueFieldName = "UniqueFieldName";
bingLT.prototype.utilFieldNameLatitude = "Latitude";
bingLT.prototype.utilFieldNameLongitude = "Longitude";
bingLT.prototype.utilFieldNameAddressLine = "AddressLine";
bingLT.prototype.utilFieldNameAdminDistrict = "AdminDistrict";
bingLT.prototype.utilFieldNameLocality = "Locality";
bingLT.prototype.utilFieldNamePostalCode = "PostalCode";
bingLT.prototype.utilFieldNameCountryRegion = "CountryRegion";
bingLT.prototype.utilFieldNameTitle = "TitleSnippet";
bingLT.prototype.utilFieldNameClient = "Client";
bingLT.prototype.utilFieldNameFileNo = "FileNo";
bingLT.prototype.utilFieldNamePracticeCode = "PracticeCode";
bingLT.prototype.utilFieldNamePinText = "PinText";
bingLT.prototype.utilFieldNamePinValue = "PinValue";
bingLT.prototype.utilFieldNamePinImage = "MapPinIcon";
bingLT.prototype.utilFieldNamePinImageName = "MapPinIconName";
bingLT.prototype.utilFieldNamePinImageWrapper = "PinImageWrapper";
bingLT.prototype.utilFieldNamePinType = "PinType";
bingLT.prototype.utilFieldNamePinWidth = "fldWidth";
bingLT.prototype.utilFieldNamePinHeight = "fldHeight";
bingLT.prototype.utilFieldNamePinAnchorX = "fldAnchorX";
bingLT.prototype.utilFieldNamePinAnchorY = "fldAnchorY";
bingLT.prototype.utilFieldNamePinTextOffsetX = "fldTextOffsetX";
bingLT.prototype.utilFieldNamePinTextOffsetY = "fldTextOffsetY";
bingLT.prototype.utilFieldNamePinRadius = "Radius";
bingLT.prototype.utilFieldNamePinRadiusColor = "RadiusColor";
bingLT.prototype.utilFieldNameNameIsHidden = "IsHidden";
bingLT.prototype.utilDefaultPinImage = "Other/pin_default.png";
bingLT.prototype.utilDefaultPinImageName = "pin_default.png";
// Paths of pin and other images
bingLT.prototype.utilPinImagePath = "";
bingLT.prototype.utilNoMapImagePath = "../Images/maps/nomap.jpg";
/// Datasets for pins, entities, groups, and metrics
bingLT.prototype.utilPoints = [];
bingLT.prototype.utilPointsShapes = [];
bingLT.prototype.utilLocations = [];
bingLT.prototype.utilLocationShapes = [];
bingLT.prototype.utilPolygons = [];
bingLT.prototype.utilPinCount = 0;
bingLT.prototype.utilPinShapesCount = 0;
bingLT.prototype.utilIsHasShape = false;

// HIDDEN PROPERTIES
bingLT.prototype._utilCountLoading = 0;
bingLT.prototype._utilMessageDOM = "";
bingLT.prototype._utilStaticMapDOM = "staticMapContainer";
bingLT.prototype._utilCallBackPinClick = null;
bingLT.prototype._utilCallBackDrawComplete = null;
bingLT.prototype._utilIsFirstLoad = true;
bingLT.prototype._utilIsFirstLoadShape = true;
bingLT.prototype._utilCurrentInfoBox = null;


// OPTIONS
bingLT.prototype.utilOptions = {
    timeoutHover: 5000,
    allowBingLocationLookup: false
};

// FUNCTIONS
/// Initialize the utility modules to the map object
/// Map object must already be initialized with bingLT library
/// pMessageDOM (STRING) = Required. The DOM id of the message specific to util mapping without hash tag.
/// pStaticMapDOM (STRING) = Required. The DOM id of the static map on the details popup.
/// pPinClick (FUNCTION) = Required. The call back function to be called after a pin is clicked.
/// pDrawComplete (FUNCTION) = Required. The call back function to be called after all pin drawing is complete.
bingLT.prototype.utilInit = function (pMessageDOM, pStaticMapDOM, pPinClick, pDrawComplete) {
    try {
        // SET THE PROPERTIES
        this._utilMessageDOM = pMessageDOM;
        this._utilStaticMapDOM = pStaticMapDOM;

        // SET THE EVENT FUNCTIONS
        this._utilCallBackPinClick = pPinClick;
        this._utilCallBackDrawComplete = pDrawComplete

        // LOAD THE MODULES
        Microsoft.Maps.loadModule('Microsoft.Maps.AdvancedShapes');
        Microsoft.Maps.loadModule('Microsoft.Maps.SpatialMath');
        //Microsoft.Maps.registerModule("HeatMapModule", "../lib/bing/heatmap.js");
        //Microsoft.Maps.loadModule("HeatMapModule");
        //Microsoft.Maps.loadModule("Microsoft.Maps.Directions", { callback: view.loadDirections });
    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
    }
}


// A function holding the click event
bingLT.prototype.utilPinClick = function (pCallBackObj, pEvent, pParent) {
    // TEST DRAW CIRCLE
    //pParent.utilDrawCirclesTest(pCallBackObj, pParent)

    // CALL THE CALLBACK FUNCTION
    pParent._utilCallBackPinClick(pCallBackObj, pEvent);
}


/// Reset the map settings and information instead of running the init function again
bingLT.prototype.utilResetMap = function () {
    try {
        this._utilIsFirstLoad = true;
        this._utilIsFirstLoadShape = true;
        this.utilRemovePins();
    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
    }
}


/// Remove all pins from the map
bingLT.prototype.utilRemovePins = function () {
    try {
        // REMOVE ALL PINS, SHAPES, AND LINES
        this.utilIsHasShape = false;
        this.utilPinCount = 0;
        this.utilPinShapesCount = 0;
        for (var i = this.map.entities.getLength() - 1; i >= 0; i--) {
            var zPoly = this.map.entities.get(i);
            if ((zPoly instanceof Microsoft.Maps.Pushpin) ||
                (zPoly instanceof Microsoft.Maps.Polygon) ||
                (zPoly instanceof Microsoft.Maps.Polyline)) {
                this.map.entities.removeAt(i);
            }
        }
    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
    }
}


/// Clear all garbage in class
bingLT.prototype.utilClearGarbage = function () {
    try {
        this.utilPoints = null;
        this.utilPoints = [];
        this.utilPointsShapes = null;
        this.utilPointsShapes = [];
        this.utilPolygons = null;
        this.utilPolygons = [];
        this.utilIsHasShape = false;
    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
    }
}


/// Draw the push pins that are in the object array
bingLT.prototype.utilDrawPins = function (pIsAddToCount) {
    var zParent = this;
    try {
        // REMOVE EXISTING PINS
        zParent.utilRemovePins();

        // LOOP THROUGH THE POINTS OBJECT TO UPDATE THE LOCATIONS OBJECT AND DRAW THE PINS
        zParent.utilLocations = [];

        if (zParent.test.consoleLogging) {
            zParent._startTimer = new Date();
            console.log("Start of SVG string build image");
        }

        for (var x = 0; x < zParent.utilPoints.length; x++) {
            // DRAW PIN
            if (zParent.utilPoints[x]) {
                if (!zParent.utilPoints[x].IsHidden) {
                    if ((zParent.utilPoints[x].Latitude != undefined && zParent.utilPoints[x].Longitude != undefined) &&
                    (zParent.utilPoints[x].Latitude != null && zParent.utilPoints[x].Longitude != null) &&
                    (zParent.utilPoints[x].Latitude != 0 && zParent.utilPoints[x].Longitude != 0) &&
                    (zParent.utilPoints[x].Latitude < 90 && zParent.utilPoints[x].Latitude > -90) &&
                    (zParent.utilPoints[x].Longitude < 180 && zParent.utilPoints[x].Longitude > -180)) {
                        // GATHER INFO
                        var zIcon = zParent.utilPinImagePath + zParent.utilDefaultPinImage;
                        if (zParent.utilPoints[x].PinImage !== undefined && zParent.utilPoints[x].PinImage !== null && zParent.utilPoints[x].PinImage.length > 0) { zIcon = zParent.utilPinImagePath + zParent.utilPoints[x].PinImage; }
                        var zIconName = zParent.utilDefaultPinImageName;
                        if (zParent.utilPoints[x].PinImageName !== undefined && zParent.utilPoints[x].PinImageName !== null && zParent.utilPoints[x].PinImageName.length > 0) { zIconName = zParent.utilPoints[x].PinImageName; }
                        var zText = null;
                        if (zParent.utilPoints[x].PinText !== undefined && zParent.utilPoints[x].PinText !== null) { zText = zParent.utilPoints[x].PinText; }
                        var zHeight = 0;
                        if (zParent.utilPoints[x].PinHeight !== undefined && zParent.utilPoints[x].PinHeight !== null && zParent.utilPoints[x].PinHeight > 0) { zHeight = zParent.utilPoints[x].PinHeight; }
                        var zWidth = 0;
                        if (zParent.utilPoints[x].PinWidth !== undefined && zParent.utilPoints[x].PinWidth !== null && zParent.utilPoints[x].PinWidth > 0) { zWidth = zParent.utilPoints[x].PinWidth; }
                        var zAnchorX = 0;
                        if (zParent.utilPoints[x].PinAnchorX !== undefined && zParent.utilPoints[x].PinAnchorX !== null && zParent.utilPoints[x].PinAnchorX > 0) { zAnchorX = zParent.utilPoints[x].PinAnchorX; }
                        var zAnchorY = 0;
                        if (zParent.utilPoints[x].PinAnchorY !== undefined && zParent.utilPoints[x].PinAnchorY !== null && zParent.utilPoints[x].PinAnchorY > 0) { zAnchorY = zParent.utilPoints[x].PinAnchorY; }
                        var zTextOffsetX = 0;
                        if (zParent.utilPoints[x].PinTextOffsetX !== undefined && zParent.utilPoints[x].PinTextOffsetX !== null && zParent.utilPoints[x].PinTextOffsetX > 0) { zTextOffsetX = zParent.utilPoints[x].PinTextOffsetX; }
                        var zTextOffsetY = 0;
                        if (zParent.utilPoints[x].PinTextOffsetY !== undefined && zParent.utilPoints[x].PinTextOffsetY !== null && zParent.utilPoints[x].PinTextOffsetY > 0) { zTextOffsetY = zParent.utilPoints[x].PinTextOffsetY; }
                        // BUILD AND DRAW THE PIN
                        var zSVG = zParent._utilBuildSVG(zParent.utilPoints[x].Id, zIcon, zIconName, zText, zWidth, zHeight, zTextOffsetX, zTextOffsetY);
                        var zTitle = zParent.utilPoints[x].Title;
                        var zLocation = new Microsoft.Maps.Location(zParent.utilPoints[x].Latitude, zParent.utilPoints[x].Longitude);
                        var zPin = new Microsoft.Maps.Pushpin(zLocation, {
                            icon: zSVG,
                            roundClickableArea: true,
                            anchor: new Microsoft.Maps.Point(zAnchorX, zAnchorY),
                            cursor: "pointer"
                        });
                        zPin.entity.id = zParent.utilPoints[x].Id // CORRECT THE ID, THIS WAS REMOVED FROM V8
                        var zPinHover = Microsoft.Maps.Events.addHandler(zPin, 'mouseover', function (pEvent) { zParent._utilShowToolTip(zParent, pEvent); });
                        var zPinMouseOut = Microsoft.Maps.Events.addHandler(zPin, 'mouseout', function (pEvent) { zParent._utilHideToolTip(zParent, pEvent); });
                        var zPinClick = Microsoft.Maps.Events.addHandler(zPin, 'click', function (pEvent) { zParent._utilShowPopup(zParent, pEvent); });
                        // DO WE NEED TO DRAW A CIRCLE?
                        if (zParent.utilPoints[x].PinRadius !== undefined && zParent.utilPoints[x].PinRadius !== null) {
                            if (zParent.utilPoints[x].PinRadius > 0) {
                                zParent.utilIsHasShape = true;
                                var zOpacityFill = 0.3;
                                var zOpacityLine = 0.8;
                                var zRadius = zParent.utilPoints[x].PinRadius;
                                var zColorFill = zParent.utilConvertHexColor("#FF0000", zOpacityFill);
                                var zColorLine = zParent.utilConvertHexColor("#FF0000", zOpacityLine);
                                if (zParent.utilPoints[x].PinRadiusColor !== undefined && zParent.utilPoints[x].PinRadiusColor !== null) {
                                    zColorFill = zParent.utilConvertHexColor(zParent.utilPoints[x].PinRadiusColor, zOpacityFill);
                                    zColorLine = zParent.utilConvertHexColor(zParent.utilPoints[x].PinRadiusColor, zOpacityLine);
                                }
                                var zCenter = new Microsoft.Maps.Location(zParent.utilPoints[x].Latitude, zParent.utilPoints[x].Longitude);
                                var zCircle = zParent.utilCreateCircle(zCenter, zRadius, zColorFill, zColorLine);
                                zParent.map.entities.push(zCircle);
                            }
                        } else {
                            // ADD TO THE COUNT
                            if (pIsAddToCount) {
                                zParent.utilPinCount++;
                            }
                        }
                        // UPDATE LOCATIONS
                        zParent.map.entities.push(zPin);
                        zParent.utilLocations.push(zLocation);
                    } else {
                        // ***************** RUNNIGN PROCESS MESSAGE HERE IS CAUSING OUT OF STACK ERROR *****************
                        //var zMessageType = zParent.messageTypes.error;
                        //zParent.processMessage(zMessageType, "Unable to draw pin due to incorrect latitude and longitude information. | Id: " + zParent.utilPoints[x].Id + " | ");
                    }
                }
            }
        }

        if (zParent.test.consoleLogging) {
            var zEnd = new Date();
            var zTime = (zEnd - zParent._startTimer) / 1000;
            console.log("End of SVG string build image Time: " + zTime + "s");
        }

        // CALL THE DRAW COMPLETE FUNCTIONS
        zParent._utilCallBackDrawComplete();

        // ZOOM TO THE BOUNDING BOX OF THE PINS
        var zPadding = 1;
        var zMaxNorth = -90;
        var zMaxEast = -180;
        var zMinWest = 180;
        var zMinSouth = 90;
        var zCornerNW = new Microsoft.Maps.Location(89, -179);
        var zCornerSE = new Microsoft.Maps.Location(-89, 179);
        var zBounds = Microsoft.Maps.LocationRect.fromCorners(zCornerNW, zCornerSE);
        if (zParent.utilIsHasShape) {
            // DO NOTHING
            //var zTest = 1 + 1;
        } else {
            for (var x = 0; x < zParent.utilLocations.length; x++) {
                if (zParent.utilLocations[x]) {
                    if (zParent.utilLocations[x].latitude > zMaxNorth) { zMaxNorth = zParent.utilLocations[x].latitude; }
                    if (zParent.utilLocations[x].longitude > zMaxEast) { zMaxEast = zParent.utilLocations[x].longitude; }
                    if (zParent.utilLocations[x].longitude < zMinWest) { zMinWest = zParent.utilLocations[x].longitude; }
                    if (zParent.utilLocations[x].latitude < zMinSouth) { zMinSouth = zParent.utilLocations[x].latitude; }
                }
            }
            // ADD PADDING
            if (zMaxNorth > 0) { zMaxNorth = zMaxNorth + zPadding; } else { zMaxNorth = zMaxNorth - zPadding }
            if (zMinSouth > 0) { zMinSouth = zMinSouth - zPadding; } else { zMinSouth = zMinSouth + zPadding }
            if (zMinWest > 0) { zMinWest = zMinWest - zPadding; } else { zMinWest = zMinWest + zPadding }
            if (zMaxEast > 0) { zMaxEast = zMaxEast + zPadding; } else { zMaxEast = zMaxEast - zPadding }
            // CREATE BOUNDS
            zCornerNW = new Microsoft.Maps.Location(zMaxNorth, zMinWest);
            zCornerSE = new Microsoft.Maps.Location(zMinSouth, zMaxEast);
            zBounds = Microsoft.Maps.LocationRect.fromCorners(zCornerNW, zCornerSE);

            var setViewOptions = "";
            setTimeout(function () {
                if (!zParent.utilIsHasShape) {
                    if (zBounds.width > 180) {
                        setViewOptions = {
                            center: zBounds.center,
                            zoom: 1,
                            animate: true
                        }
                        //setTimeout(function () {
                        zParent.map.setView(setViewOptions);
                        //}, 1000);
                        // DO THE ZOOM AGAIN ON THE FIRST BUILD
                            if (zParent._utilIsFirstLoad) {
                                setTimeout(function () {
                                    zParent.map.setView(setViewOptions);
                                }, 1000);
                            }
                    }
                    else {
                        setViewOptions = {
                            bounds: zBounds,
                            center: zBounds.center,
                            animate: true
                        }

                        // SET THE ZOOM
                        zParent.map.setView(setViewOptions);
                        // DO THE ZOOM AGAIN ON THE FIRST BUILD
                        if (zParent._utilIsFirstLoad) {
                            setTimeout(function () {
                                zParent.map.setView(setViewOptions);
                            }, 1000);
                        }
                        zParent._utilIsFirstLoad = false;
                    }
                }
            }, 333);
        }
    } catch (pException) {
        var zMessageType = zParent.messageTypes.error;
        zParent.processMessage(zMessageType, pException.message + " | Id: " + zParent.utilPoints[x].Id + " | " + " Pin draw process may be incomplete.");
    }
}


/// Draw the push pins that are in the object array
bingLT.prototype.utilDrawPinShapes = function (pIsAddToCount) {
    var zParent = this;
    try {
        // REMOVE EXISTING PINS
        //zParent.utilRemovePins();

        // LOOP THROUGH THE POINTS OBJECT TO UPDATE THE LOCATIONS OBJECT AND DRAW THE PINS
        zParent.utilLocationShapes = [];

        if (zParent.test.consoleLogging) {
            zParent._startTimer = new Date();
            console.log("Start of SVG string build image");
        }

        for (var x = 0; x < zParent.utilPointsShapes.length; x++) {
            // DRAW PIN
            if (zParent.utilPointsShapes[x]) {
                if (!zParent.utilPointsShapes[x].IsHidden) {
                    if ((zParent.utilPointsShapes[x].Latitude != undefined && zParent.utilPointsShapes[x].Longitude != undefined) &&
                    (zParent.utilPointsShapes[x].Latitude != null && zParent.utilPointsShapes[x].Longitude != null) &&
                    (zParent.utilPointsShapes[x].Latitude != 0 && zParent.utilPointsShapes[x].Longitude != 0) &&
                    (zParent.utilPointsShapes[x].Latitude < 90 && zParent.utilPointsShapes[x].Latitude > -90) &&
                    (zParent.utilPointsShapes[x].Longitude < 180 && zParent.utilPointsShapes[x].Longitude > -180)) {
                        // GATHER INFO
                        var zIcon = zParent.utilPinImagePath + zParent.utilDefaultPinImage;
                        if (zParent.utilPointsShapes[x].PinImage !== undefined && zParent.utilPointsShapes[x].PinImage !== null && zParent.utilPointsShapes[x].PinImage.length > 0) { zIcon = zParent.utilPinImagePath + zParent.utilPointsShapes[x].PinImage; }
                        var zIconName = zParent.utilDefaultPinImageName;
                        if (zParent.utilPointsShapes[x].PinImageName !== undefined && zParent.utilPointsShapes[x].PinImageName !== null && zParent.utilPointsShapes[x].PinImageName.length > 0) { zIconName = zParent.utilPointsShapes[x].PinImageName; }
                        var zText = null;
                        if (zParent.utilPointsShapes[x].PinText !== undefined && zParent.utilPointsShapes[x].PinText !== null) { zText = zParent.utilPointsShapes[x].PinText; }
                        var zHeight = 0;
                        if (zParent.utilPointsShapes[x].PinHeight !== undefined && zParent.utilPointsShapes[x].PinHeight !== null && zParent.utilPointsShapes[x].PinHeight > 0) { zHeight = zParent.utilPointsShapes[x].PinHeight; }
                        var zWidth = 0;
                        if (zParent.utilPointsShapes[x].PinWidth !== undefined && zParent.utilPointsShapes[x].PinWidth !== null && zParent.utilPointsShapes[x].PinWidth > 0) { zWidth = zParent.utilPointsShapes[x].PinWidth; }
                        var zAnchorX = 0;
                        if (zParent.utilPointsShapes[x].PinAnchorX !== undefined && zParent.utilPointsShapes[x].PinAnchorX !== null && zParent.utilPointsShapes[x].PinAnchorX > 0) { zAnchorX = zParent.utilPointsShapes[x].PinAnchorX; }
                        var zAnchorY = 0;
                        if (zParent.utilPointsShapes[x].PinAnchorY !== undefined && zParent.utilPointsShapes[x].PinAnchorY !== null && zParent.utilPointsShapes[x].PinAnchorY > 0) { zAnchorY = zParent.utilPointsShapes[x].PinAnchorY; }
                        var zTextOffsetX = 0;
                        if (zParent.utilPointsShapes[x].PinTextOffsetX !== undefined && zParent.utilPointsShapes[x].PinTextOffsetX !== null && zParent.utilPointsShapes[x].PinTextOffsetX > 0) { zTextOffsetX = zParent.utilPointsShapes[x].PinTextOffsetX; }
                        var zTextOffsetY = 0;
                        if (zParent.utilPointsShapes[x].PinTextOffsetY !== undefined && zParent.utilPointsShapes[x].PinTextOffsetY !== null && zParent.utilPointsShapes[x].PinTextOffsetY > 0) { zTextOffsetY = zParent.utilPointsShapes[x].PinTextOffsetY; }
                        // BUILD AND DRAW THE PIN
                        var zSVG = zParent._utilBuildSVG(zParent.utilPointsShapes[x].Id, zIcon, zIconName, zText, zWidth, zHeight, zTextOffsetX, zTextOffsetY);
                        var zTitle = zParent.utilPointsShapes[x].Title;
                        var zLocation = new Microsoft.Maps.Location(zParent.utilPointsShapes[x].Latitude, zParent.utilPointsShapes[x].Longitude);
                        var zPin = new Microsoft.Maps.Pushpin(zLocation, {
                            icon: zSVG,
                            roundClickableArea: true,
                            anchor: new Microsoft.Maps.Point(zAnchorX, zAnchorY),
                            cursor: "pointer"
                        });
                        zPin.entity.id = "ShapePin_" + zParent.utilPointsShapes[x].Id // CORRECT THE ID, THIS WAS REMOVED FROM V8
                        //var zPinHover = Microsoft.Maps.Events.addHandler(zPin, 'mouseover', function (pEvent) { zParent._utilShowToolTip(zParent, pEvent); });
                        //var zPinMouseOut = Microsoft.Maps.Events.addHandler(zPin, 'mouseout', function (pEvent) { zParent._utilHideToolTip(zParent, pEvent); });
                        //var zPinClick = Microsoft.Maps.Events.addHandler(zPin, 'click', function (pEvent) { zParent._utilShowPopup(zParent, pEvent); });
                        // DO WE NEED TO DRAW A CIRCLE?
                        if (zParent.utilPointsShapes[x].PinRadius !== undefined && zParent.utilPointsShapes[x].PinRadius !== null) {
                            if (zParent.utilPointsShapes[x].PinRadius > 0) {
                                zParent.utilIsHasShape = true;
                                var zOpacityFill = 0.3;
                                var zOpacityLine = 0.8;
                                var zRadius = zParent.utilPointsShapes[x].PinRadius;
                                var zColorFill = zParent.utilConvertHexColor("#FF0000", zOpacityFill);
                                var zColorLine = zParent.utilConvertHexColor("#FF0000", zOpacityLine);
                                if (zParent.utilPointsShapes[x].PinRadiusColor !== undefined && zParent.utilPointsShapes[x].PinRadiusColor !== null) {
                                    zColorFill = zParent.utilConvertHexColor(zParent.utilPointsShapes[x].PinRadiusColor, zOpacityFill);
                                    zColorLine = zParent.utilConvertHexColor(zParent.utilPointsShapes[x].PinRadiusColor, zOpacityLine);
                                }
                                var zCenter = new Microsoft.Maps.Location(zParent.utilPointsShapes[x].Latitude, zParent.utilPointsShapes[x].Longitude);
                                var zCircle = zParent.utilCreateCircle(zCenter, zRadius, zColorFill, zColorLine);
                                if (zCircle.entity) {
                                    zCircle.entity.id = "ShapePolygon_" + zParent.utilPointsShapes[x].Id; // CORRECT THE ID, THIS WAS REMOVED FROM V8
                                } else {
                                    zCircle.entity = { "id": "ShapePolygon_" + zParent.utilPointsShapes[x].Id }; // CORRECT THE ID, THIS WAS REMOVED FROM V8
                                }
                                zParent.map.entities.push(zCircle);
                                zParent.utilPolygons.push(zCircle);
                            }
                        } else {
                            // ADD TO THE COUNT
                            if (pIsAddToCount) {
                                zParent.utilPinCount++;
                            }
                        }
                        // UPDATE LOCATIONS
                        zParent.map.entities.push(zPin);
                        zParent.utilLocationShapes.push(zLocation);
                    } else {
                        // ***************** RUNNIGN PROCESS MESSAGE HERE IS CAUSING OUT OF STACK ERROR *****************
                        //var zMessageType = zParent.messageTypes.error;
                        //zParent.processMessage(zMessageType, "Unable to draw pin due to incorrect latitude and longitude information. | Id: " + zParent.utilPointsShapes[x].Id + " | ");
                    }
                }
            }
        }

        if (zParent.test.consoleLogging) {
            var zEnd = new Date();
            var zTime = (zEnd - zParent._startTimer) / 1000;
            console.log("End of SVG string build image Time: " + zTime + "s");
        }

        // CALL THE DRAW COMPLETE FUNCTIONS
        zParent._utilCallBackDrawComplete();

        // ZOOM TO THE BOUNDING BOX OF THE PINS
        var zPadding = 0.1;
        var zMaxNorth = -90;
        var zMaxEast = -180;
        var zMinWest = 180;
        var zMinSouth = 90;
        var zCornerNW = new Microsoft.Maps.Location(89, -179);
        var zCornerSE = new Microsoft.Maps.Location(-89, 179);
        var zBounds = Microsoft.Maps.LocationRect.fromCorners(zCornerNW, zCornerSE);
        if (zParent.utilIsHasShape) {
            for (var x = 0; x < zParent.utilPolygons.length; x++) {
                if (zParent.utilPolygons[x]) {
                    var zVertices = zParent.utilPolygons[x].getLocations();
                    if (zVertices) {
                        for (var y = 0; y < zVertices.length; y++) {
                            if (zVertices[y].latitude > zMaxNorth) { zMaxNorth = zVertices[y].latitude; }
                            if (zVertices[y].longitude > zMaxEast) { zMaxEast = zVertices[y].longitude; }
                            if (zVertices[y].longitude < zMinWest) { zMinWest = zVertices[y].longitude; }
                            if (zVertices[y].latitude < zMinSouth) { zMinSouth = zVertices[y].latitude; }
                        }
                    }
                }
            }
            // ADD PADDING
            if (zMaxNorth > 0) { zMaxNorth = zMaxNorth + zPadding; } else { zMaxNorth = zMaxNorth - zPadding }
            if (zMinSouth > 0) { zMinSouth = zMinSouth - zPadding; } else { zMinSouth = zMinSouth + zPadding }
            if (zMinWest > 0) { zMinWest = zMinWest - zPadding; } else { zMinWest = zMinWest + zPadding }
            if (zMaxEast > 0) { zMaxEast = zMaxEast + zPadding; } else { zMaxEast = zMaxEast - zPadding }
            // CREATE BOUNDS
            zCornerNW = new Microsoft.Maps.Location(zMaxNorth, zMinWest);
            zCornerSE = new Microsoft.Maps.Location(zMinSouth, zMaxEast);
            zBounds = Microsoft.Maps.LocationRect.fromCorners(zCornerNW, zCornerSE);
            setTimeout(function () {
                // SET THE ZOOM
                if (zParent.utilIsHasShape) {
                    zParent.map.setView({
                        bounds: zBounds,
                        animate: true
                    });
                    // DO THE ZOOM AGAIN ON THE FIRST BUILD
                    if (zParent._utilIsFirstLoadShape) {
                        setTimeout(function () {
                            zParent.map.setView({
                                bounds: zBounds,
                                animate: true
                            });
                        }, 1000);
                    }
                }
                zParent._utilIsFirstLoadShape = false;
            }, 333);
        } else {
            // DO NOTHING
            //var zTest = 1 + 1;
        }

    } catch (pException) {
        var zMessageType = zParent.messageTypes.error;
        zParent.processMessage(zMessageType, pException.message + " | Id: " + zParent.utilPointsShapes[x].Id + " | " + " Pin draw process may be incomplete.");
    }
}


/// Add pins to the object array then draw them
bingLT.prototype.utilAddPins = function (pLocations) {
    try {
        // CLEAR THE EXISTING LOCATION RELATED OBJECTS
        this.utilClearGarbage();

        var zIsAllHidden = true;
        for (var x = 0; x < pLocations.length; x++) {
            if (!pLocations[x][this.utilFieldNameNameIsHidden]) { zIsAllHidden = false; }
            this.utilPoints.push({
                Id: pLocations[x][this.utilFieldNameUniqueIdentifier],
                UniqueFieldName: pLocations[x][this.utilFieldNameUniqueFieldName],
                Title: pLocations[x][this.utilFieldNameTitle],
                Client: pLocations[x][this.utilFieldNameClient],
                PracticeCode: pLocations[x][this.utilFieldNamePracticeCode],
                FileNo: pLocations[x][this.utilFieldNameFileNo],
                PinText: pLocations[x][this.utilFieldNamePinText],
                PinValue: pLocations[x][this.utilFieldNamePinValue],
                PinImage: pLocations[x][this.utilFieldNamePinImage],
                PinImageName: pLocations[x][this.utilFieldNamePinImageName],
                PinImageWrapper: pLocations[x][this.utilFieldNamePinImageWrapper],
                PinType: pLocations[x][this.utilFieldNamePinType],
                PinWidth: pLocations[x][this.utilFieldNamePinWidth],
                PinHeight: pLocations[x][this.utilFieldNamePinHeight],
                PinAnchorX: pLocations[x][this.utilFieldNamePinAnchorX],
                PinAnchorY: pLocations[x][this.utilFieldNamePinAnchorY],
                PinTextOffsetX: pLocations[x][this.utilFieldNamePinTextOffsetX],
                PinTextOffsetY: pLocations[x][this.utilFieldNamePinTextOffsetY],
                PinRadius: pLocations[x][this.utilFieldNamePinRadius],
                PinRadiusColor: pLocations[x][this.utilFieldNamePinRadiusColor],
                IsHidden: pLocations[x][this.utilFieldNameNameIsHidden],
                Latitude: pLocations[x][this.utilFieldNameLatitude],
                Longitude: pLocations[x][this.utilFieldNameLongitude],
                Box: null,
                AddressLine: pLocations[x][this.utilFieldNameAddressLine],
                AdminDistrict: pLocations[x][this.utilFieldNameAdminDistrict],
                Locality: pLocations[x][this.utilFieldNameLocality],
                PostalCode: pLocations[x][this.utilFieldNamePostalCode],
                CountryRegion: pLocations[x][this.utilFieldNameCountryRegion]
            });
        }

        // IF ANY LATS AND LONGS NEED CORRECTING, ASK BING
        var zFound = false;
        this._utilCountLoading = 0;
        if (this.utilOptions.allowBingLocationLookup) {
            for (var x = 0; x < this.utilPoints.length; x++) {
                if (((this.utilPoints[x].Latitude === undefined || this.utilPoints[x].Latitude === null || this.utilPoints[x].Latitude == 0) ||
                    (this.utilPoints[x].Longitude === undefined || this.utilPoints[x].Longitude === null || this.utilPoints[x].Longitude == 0)) &&
                    (this.utilPoints[x].AddressLine !== undefined && this.utilPoints[x].AddressLine !== null && this.utilPoints[x].AddressLine.length > 0)) {
                    zFound = true;
                    this._utilCountLoading++;
                    this.utilUpdatePointFromAddress(this.utilPoints[x].Id, this.utilPoints[x].AddressLine, this.utilPoints[x].AdminDistrict, this.utilPoints[x].Locality, this.utilPoints[x].PostalCode, this.utilPoints[x].CountryRegion, "draw");
                }
            }
        }

        // IF THERE ARE NO POINTS NEEDED LAT/LONG, THEN DRAW, OTHERWISE WAIT
        if (!zFound && !zIsAllHidden) {
            this.utilDrawPins(true);
        }

    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message + " | " + " Pin add process may be incomplete.");
    }

    // FORCE GARBAGE CLEANUP
    pLocations = null;
}


/// Add pins to the object array then draw them
bingLT.prototype.utilAddPinShapes = function (pLocations) {
    try {
        // CLEAR THE EXISTING LOCATION RELATED OBJECTS
        //this.utilClearGarbage();

        var zIsAllHidden = true;
        for (var x = 0; x < pLocations.length; x++) {
            if (!pLocations[x][this.utilFieldNameNameIsHidden]) { zIsAllHidden = false; }
            this.utilPointsShapes.push({
                Id: pLocations[x][this.utilFieldNameUniqueIdentifier],
                UniqueFieldName: pLocations[x][this.utilFieldNameUniqueFieldName],
                Title: pLocations[x][this.utilFieldNameTitle],
                Client: pLocations[x][this.utilFieldNameClient],
                PracticeCode: pLocations[x][this.utilFieldNamePracticeCode],
                FileNo: pLocations[x][this.utilFieldNameFileNo],
                PinText: pLocations[x][this.utilFieldNamePinText],
                PinValue: pLocations[x][this.utilFieldNamePinValue],
                PinImage: pLocations[x][this.utilFieldNamePinImage],
                PinImageName: pLocations[x][this.utilFieldNamePinImageName],
                PinImageWrapper: pLocations[x][this.utilFieldNamePinImageWrapper],
                PinType: pLocations[x][this.utilFieldNamePinType],
                PinWidth: pLocations[x][this.utilFieldNamePinWidth],
                PinHeight: pLocations[x][this.utilFieldNamePinHeight],
                PinAnchorX: pLocations[x][this.utilFieldNamePinAnchorX],
                PinAnchorY: pLocations[x][this.utilFieldNamePinAnchorY],
                PinTextOffsetX: pLocations[x][this.utilFieldNamePinTextOffsetX],
                PinTextOffsetY: pLocations[x][this.utilFieldNamePinTextOffsetY],
                PinRadius: pLocations[x][this.utilFieldNamePinRadius],
                PinRadiusColor: pLocations[x][this.utilFieldNamePinRadiusColor],
                IsHidden: pLocations[x][this.utilFieldNameNameIsHidden],
                Latitude: pLocations[x][this.utilFieldNameLatitude],
                Longitude: pLocations[x][this.utilFieldNameLongitude],
                Box: null,
                AddressLine: pLocations[x][this.utilFieldNameAddressLine],
                AdminDistrict: pLocations[x][this.utilFieldNameAdminDistrict],
                Locality: pLocations[x][this.utilFieldNameLocality],
                PostalCode: pLocations[x][this.utilFieldNamePostalCode],
                CountryRegion: pLocations[x][this.utilFieldNameCountryRegion]
            });
        }

        // IF ANY LATS AND LONGS NEED CORRECTING, ASK BING
        var zFound = false;
        this._utilCountLoading = 0;
        if (this.utilOptions.allowBingLocationLookup) {
            for (var x = 0; x < this.utilPointsShapes.length; x++) {
                if (((this.utilPointsShapes[x].Latitude === undefined || this.utilPointsShapes[x].Latitude === null || this.utilPointsShapes[x].Latitude == 0) ||
                    (this.utilPointsShapes[x].Longitude === undefined || this.utilPointsShapes[x].Longitude === null || this.utilPointsShapes[x].Longitude == 0)) &&
                    (this.utilPointsShapes[x].AddressLine !== undefined && this.utilPointsShapes[x].AddressLine !== null && this.utilPointsShapes[x].AddressLine.length > 0)) {
                    zFound = true;
                    this._utilCountLoading++;
                    this.utilUpdatePointFromAddress(this.utilPointsShapes[x].Id, this.utilPointsShapes[x].AddressLine, this.utilPointsShapes[x].AdminDistrict, this.utilPointsShapes[x].Locality, this.utilPointsShapes[x].PostalCode, this.utilPointsShapes[x].CountryRegion, "draw");
                }
            }
        }

        // IF THERE ARE NO POINTS NEEDED LAT/LONG, THEN DRAW, OTHERWISE WAIT
        if (!zFound && !zIsAllHidden) {
            this.utilDrawPinShapes(false);
        }

    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message + " | " + " Pin add process may be incomplete.");
    }

    // FORCE GARBAGE CLEANUP
    pLocations = null;
}


/// Find the latitude and longitude of a location.
bingLT.prototype.utilUpdatePointFromAddress = function (pId, pAddress, pCity, pStProv, pZip, pCountry, pReturnAction) {
    try {
        // BUILD THE ADDRESS LINE AND URL
        var zAddressLine = "";
        var zAdminDistrict = " ";
        var zLocality = " ";
        var zPostalCode = " ";
        var zCountryRegion = " ";
        if (pAddress !== undefined && pAddress !== null) { zAddressLine = zAddressLine + pAddress }
        if (pCity !== undefined && pCity !== null) { zAdminDistrict = zAdminDistrict + pCity }
        if (pStProv !== undefined && pStProv !== null) { zLocality = zLocality + pStProv }
        if (pZip !== undefined && pZip !== null) { zPostalCode = zPostalCode + pZip }
        if (pCountry !== undefined && pCountry !== null) { zCountryRegion = zCountryRegion + pCountry }
        var zURL = "http://dev.virtualearth.net/REST/v1/Locations?q=" + zAddressLine + zAdminDistrict + zLocality + zCountryRegion + zPostalCode;

        // CALL THE SERVICE
        var zData = { key: this._mapKey };
        this._utilCallBingService(zURL, zData, this._utilUpdatePointSuccess, this._utilUpdatePointError, { Id: pId, ReturnAction: pReturnAction });
    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
    }
}


// Create and return a circle polygon
bingLT.prototype.utilCreateCircle = function (pCenter, pRadius, pColorFill, pColorLine) {
    //Calculate the locations for a regular polygon that has 36 locations which will rssult in an approximate circle.
    var zSides = 36;
    var zLocs = Microsoft.Maps.SpatialMath.getRegularPolygon(pCenter, pRadius, zSides, Microsoft.Maps.SpatialMath.DistanceUnits.Miles);
    return new Microsoft.Maps.Polygon(zLocs, { fillColor: pColorFill, strokeColor: pColorLine, strokeThickness: 4 });
}


/// Convert a hex color to an RGBA color
bingLT.prototype.utilConvertHexColor = function (pHex, pOpacity) {
    var zHex = pHex.replace('#', '');
    var zR = parseInt(zHex.substring(0, 2), 16);
    var zG = parseInt(zHex.substring(2, 4), 16);
    var zB = parseInt(zHex.substring(4, 6), 16);
    var zResult = 'rgba(' + zR + ',' + zG + ',' + zB + ',' + pOpacity + ')';
    return zResult;
}


/// Build the SVG template for an HTML pin
bingLT.prototype._utilBuildSVG = function (pId, pIcon, pIconName, pText, pWidth, pHeight, pTextOffsetX, pTextOffsetY) {
    var zReturn = "";
    var zColorText = "fill='#FFFFFF'";
    var zColorShadow = ""; //"fill='#000000' stroke='#000000'";
    var zFontSizeText = "13"; //"11";
    var zFontSizeShadow = "14"; //"12";
    // CORRECT WIDTH AND HEIGHT TO DEFAULTS
    if (pWidth < 1) { pWidth = 48; }
    if (pHeight < 1) { pHeight = 48; }
    if (!pTextOffsetX) { pTextOffsetX = 30; }
    if (!pTextOffsetY) { pTextOffsetY = 20; }
    // CORRECT THE TEXT COLOR IF LIGHT BACKGROUND BY PIN IMAGE NAME
    switch (pIconName) {
        case "pin_#FFFFFF":
        case "pin_#00FF00":
        case "pin_#00FF00":
        case "pin_#FFFF00":
        case "pin_#FFFF00":
        case "pin_#FF9900":
        case "pin_#C6D1DE":
            // BLACK ON LIGHT COLOR
            var zColorText = "fill='#000000'";
            break;
        case "pin_#FF0000":
        case "pin_#339966":
        case "pin_#FF0000":
        case "pin_#FF8C1A":
        case "pin_#66FF33":
        case "pin_#009900":
        case "pin_#33CCFF":
        case "pin_#4F81BD":
        case "pin_#9E227B":
        case "pin_#D3D3D3":
        case "pin_#215968":
        case "pin_#B3A2C7":
        case "pin_#C0C0C0":
        case "pin_#18375B":
        case "pin_#953637":
        case "pin_#958B58":
        case "pin_#628AB2":
        case "pin_#8CFFFF":
            // WHITE ON DARK COLOR
            var zColorText = "fill='#FFFFFF'";
            break;
    }
    if (pText) {
        zReturn = [
            "<svg id='pin_" + pId + "' width='" + pWidth + "px' height='" + pHeight + "px' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink= 'http://www.w3.org/1999/xlink'>",
            "<image x='0' y='0' width='" + pWidth + "px' height='" + pHeight + "px' xlink:href='" + pIcon + "' />",
            //"<text x='" + pTextOffsetX + "' y='" + (pTextOffsetY + 1) + "' " + zColorShadow + " font-family='Arial' font-size='" + zFontSizeShadow + "' text-anchor='middle' alignment-baseline='central'>" + pText + "</text>",
            "<text x='" + pTextOffsetX + "' y='" + pTextOffsetY + "' " + zColorText + " font-weight='bold' font-family='Arial' font-size='" + zFontSizeText + "' text-anchor='middle' alignment-baseline='central'>" + pText + "</text>",
            "</svg>"
        ];
    } else {
        zReturn = [
           "<svg id='pin_" + pId + "' width='" + pWidth + "px' height='" + pHeight + "px' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink= 'http://www.w3.org/1999/xlink'>",
           "<image x='0' y='0' width='" + pWidth + "px' height='" + pHeight + "px' xlink:href='" + pIcon + "' />",
           "</svg>"
        ];
    }
    return zReturn.join("");
}


/// Success function for the Find Point function and service call.
bingLT.prototype._utilUpdatePointSuccess = function (pResults, pParms, pParent) {
    try {
        if (pResults.statusCode.toString()[0] != "3" && pResults.statusCode.toString()[0] != "4" && pResults.statusCode.toString()[0] != "5") {
            //view.data = pResults;
            if (pResults.resourceSets[0].resources && pResults.resourceSets[0].resources.length > 0) {
                // UPDATE THE POINTS DATA
                for (var x = 0; x < pParent.utilPoints.length; x++) {
                    if (pParent.utilPoints[x].Id == pParms.Id) {
                        pParent.utilPoints[x].Latitude = pResults.resourceSets[0].resources[0].geocodePoints[0].coordinates[0];
                        pParent.utilPoints[x].Longitude = pResults.resourceSets[0].resources[0].geocodePoints[0].coordinates[1];
                        pParent.utilPoints[x].Box = pResults.resourceSets[0].resources[0].bbox;
                        break;
                    }
                }

                // DO RETURN ACTION
                pParent._utilCountLoading--;
                pParent._utilUpdatePointProcessAction(pResults, pParms, pParent)

            } else {
                //view.locationPoint("Not Found");
                pParent._utilCountLoading--;
                pParent._utilUpdatePointProcessAction(pResults, pParms, pParent)
            }
        } else {
            //view.results("An error has occured after loading location details: " + pResults.errorDetails.toString());
            pParent._utilCountLoading--;
            pParent._utilUpdatePointProcessAction(pResults, pParms, pParent)
        }
    } catch (pException) {
        pParent._utilCountLoading--;
        var zMessageType = pParent.messageTypes.error;
        pParent.processMessage(zMessageType, pException.message);
    }
}


/// Error function for the Find Point function and service call.
bingLT.prototype._utilUpdatePointError = function (pResults, pMessage, pErrorDetail, pParms, pParent) {
    try {
        pParent._utilCountLoading--;
        var zMessageType = pParent.messageTypes.error;
        pParent.processMessage(zMessageType, "An error occurred while attempting to find a location via Bing services: " + pResults.statusText.toString());
    } catch (pException) {
        var zMessageType = pParent.messageTypes.error;
        pParent.processMessage(zMessageType, "An unknown error occurred while attempting to find a location via Bing services. Reference 365");
    }
}


/// A function to process the post action after a pin is successfully located by Bing services
bingLT.prototype._utilUpdatePointProcessAction = function (pResults, pParms, pParent) {
    try {
        switch (pParms.ReturnAction) {
            case "draw":
            default:
                if (pParent._utilCountLoading < 1) {
                    pParent.utilDrawPins(true);
                }
                break;
        }
    } catch (pException) {
        var zMessageType = pParent.messageTypes.fatal;
        pParent.processMessage(zMessageType, "An unknown error occurred while processing the action after retrieving pin information. Reference 273");
    }
}


/// A function to show a tooltip popup
bingLT.prototype._utilShowToolTip = function (pParent, pEvent) {
    // HIDE THE PREVIOUS TOOLTIP
    var zInfoBoxOld = pParent.map.entities.get(pParent.map.entities.getLength() - 1);
    if (pParent._utilCurrentInfoBox) {
        pParent._utilCurrentInfoBox.setMap(null);
        pParent._utilCurrentInfoBox = null;
    }
    // SHOW THE NEXT TOOLTIP
    var zInfoboxOptions = {};
    var zHTML = "";
    var zFound = false;
    for (x = 0; x < pParent.utilPoints.length; x++) {
        if (!zFound) {
            if (pEvent.target.geometry.y == pParent.utilPoints[x].Latitude && pEvent.target.geometry.x == pParent.utilPoints[x].Longitude) {
                zFound = true;
                var zWidth = 150;
                if (pParent.utilPoints[x].Title != null && pParent.utilPoints[x].Title.length > 5) { zWidth = pParent.utilPoints[x].Title.length * 9; }
                zHTML = zHTML + pParent.utilPoints[x].Title;
                zInfoboxOptions = { htmlContent: zHTML };
                break;
            }
        }
    }
    if (zHTML !== undefined && zHTML !== null && zHTML !== "") {
        var zLocation = new Microsoft.Maps.Location(pEvent.target.geometry.y, pEvent.target.geometry.x);
        var zInfoBox = new Microsoft.Maps.Infobox(zLocation, zInfoboxOptions);
        Microsoft.Maps.Events.addHandler(zInfoBox, 'mouseleave', function (pEventInner) { pParent._utilHideToolTip(pParent, pEventInner); });
        pParent._utilCurrentInfoBox = zInfoBox;
        pParent._utilCurrentInfoBox.setMap(pParent.map);
        setTimeout(function () {
            if (pParent._utilCurrentInfoBox) {
                pParent._utilCurrentInfoBox.setMap(null);
                pParent._utilCurrentInfoBox = null;
            }
        }, pParent.utilOptions.timeoutHover);
    }
}


/// A function to hide the last tool tip drawn
bingLT.prototype._utilHideToolTip = function (pParent, pEvent) {
    setTimeout(function () {
        // HIDES THE TOOLTIP UNLESS HOVERED
        if (pParent._utilCurrentInfoBox) {
            var zInfoBox = pParent._utilCurrentInfoBox;
            var zHTML = zInfoBox._htmlContent;
            var zElement = document.createElement("div");
            zElement.innerHTML = zHTML;
            if (zElement.children[0] !== undefined && zElement.children[0].id !== undefined) {
                var zId = zElement.children[0].id
                if ($("#" + zId + ":hover").length == 0) {
                    zInfoBox.setMap(null);
                }
            }
        }
    }, 350);
}


/// A function to show the details popup.
bingLT.prototype._utilShowPopup = function (pParent, pEvent) {
    try {
        // GET THE DETAILS OF THE LOCATION
        if (pEvent.target.entity.id !== undefined) {
            zId = pEvent.target.entity.id;
            var zFormattedAddress = "";
            var zPinObject = null;
            for (var x = 0; x < pParent.utilPoints.length; x++) {
                if (zId == pParent.utilPoints[x].Id || zId == pParent.utilPoints[x].PinType + "_" + pParent.utilPoints[x].Id) {
                    zPinObject = pParent.utilPoints[x];
                    var zAddressLine = "";
                    var zAdminDistrict = " ";
                    var zLocality = " ";
                    var zPostalCode = " ";
                    var zCountryRegion = " ";
                    if (pParent.utilPoints[x].AddressLine !== undefined && pParent.utilPoints[x].AddressLine !== null) { zAddressLine = zAddressLine + pParent.utilPoints[x].AddressLine }
                    if (pParent.utilPoints[x].AdminDistrict !== undefined && pParent.utilPoints[x].AdminDistrict !== null) { zAdminDistrict = zAdminDistrict + pParent.utilPoints[x].AdminDistrict }
                    if (pParent.utilPoints[x].Locality !== undefined && pParent.utilPoints[x].Locality !== null) { zLocality = zLocality + pParent.utilPoints[x].Locality }
                    if (pParent.utilPoints[x].PostalCode !== undefined && pParent.utilPoints[x].PostalCode !== null) { zPostalCode = zPostalCode + pParent.utilPoints[x].PostalCode }
                    if (pParent.utilPoints[x].CountryRegion !== undefined && pParent.utilPoints[x].CountryRegion !== null) { zCountryRegion = zCountryRegion + pParent.utilPoints[x].CountryRegion }
                    zFormattedAddress = zAddressLine + zAdminDistrict + zLocality + zCountryRegion + zPostalCode;
                    break;
                }
            }

            var zCenterPoint = pEvent.target.geometry.y.toString() + "," + pEvent.target.geometry.x.toString() + "/";
            var zZoomLevel = "18/";
            var zImagerySet = "AerialWithLabels/";
            var zPushPins = "&pp=" + pEvent.target.geometry.y.toString() + "," + pEvent.target.geometry.x.toString() + ";" + "32" + ";";
            var zMapSize = "&ms=" + "320" + "," + "300";
            var zCallBackObj = {
                PinObject: zPinObject,
                PinTarget: pEvent.target,
                StaticImageURL: "http://dev.virtualearth.net/REST/v1/Imagery/Map/" + zImagerySet + zCenterPoint + zZoomLevel + "?" + zFormattedAddress + zMapSize + "&key=" + pParent._mapKey
            }

            // CALL THE LOCAL CALLBACK FUNCTION TO HANDLE ANY OTHER EVENTS
            pParent.utilPinClick(zCallBackObj, pEvent, pParent); //_utilCallBackPinClick(zCallBackObj, pEvent);
        }

    } catch (pException) {
        var zMessageType = pParent.messageTypes.error;
        pParent.processMessage(zMessageType, pException.message);
    }
}


/// A function to hide the details popup.
bingLT.prototype._utilHidePopup = function (pParent, pEvent) {
    // DO NOTHING
}


/// A function to zoom into a location
bingLT.prototype.utilZoomToPoint = function (pLatitude, pLongitude) {
    var zView = {
        zoom: 17,
        center: new Microsoft.Maps.Location(pLatitude, pLongitude)
    };
    this.map.setView(zView);
}


/// A function to call the Bing service.
bingLT.prototype._utilCallBingService = function (pURL, pData, pSuccess, pError, pParms) {
    var zParent = this;
    try {
        $.ajax({
            url: pURL,
            data: pData,
            timeout: 10000,
            async: true,
            cache: true,
            dataType: "jsonp",
            jsonp: "jsonp",
            success: function (pResults) {
                if (pSuccess != undefined) {
                    pSuccess(pResults, pParms, zParent);
                }
            },
            error: function (pResults, pMessage, pErrorDetail) {
                if (pError != undefined) {
                    pError(pResults, pMessage, pErrorDetail, pParms, zParent);
                } else {
                    alert("Error: " + pMessage);
                }
            }
        });
    } catch (pException) {
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
    }
}


/// A function to get a static map image
bingLT.prototype.getStaticMap = function (pLatitude, pLongitude, pMapWidth, pMapHeight, pKey) {
    try {
        var zKey = this._mapKey;
        var zCenterPoint = pLatitude + "," + pLongitude + "/";
        var zZoomLevel = "18/";
        var zImagerySet = "AerialWithLabels/";
        var zPushPins = "&pp=" + pLatitude + "," + pLongitude + ";" + "32" + ";";
        var zMapSize = "?ms=" + pMapWidth + "," + pMapHeight;
        if (pKey) {
            zKey = pKey;
        }
        var StaticImageURL = "http://dev.virtualearth.net/REST/v1/Imagery/Map/" + zImagerySet + zCenterPoint + zZoomLevel + zMapSize + "&key=" + zKey;
        return StaticImageURL;
    } catch (pException) {
        //Error
        var zMessageType = this.messageTypes.error;
        this.processMessage(zMessageType, pException.message);
        var noMapImage = "../../Home_{{VER}}/Images/maps/nomap.jpg";
        return noMapImage;
        //Return URL for placeholder map image
    }
}
