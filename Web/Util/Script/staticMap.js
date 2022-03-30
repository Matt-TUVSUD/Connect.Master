getStaticMap = function (pLatitude, pLongitude, pMapWidth, pMapHeight) {
    try {
        var zCenterPoint = pLatitude + "," + pLongitude + "/";
        var zZoomLevel = "18/";
        var zImagerySet = "AerialWithLabels/";
        var zPushPins = "&pp=" + pLatitude + "," + pLongitude + ";" + "32" + ";";
        var zMapSize = "&ms=" + pMapWidth + "," + pMapHeight;
        //    //StaticImageURL: "http://dev.virtualearth.net/REST/v1/Imagery/Map/" + zImagerySet + "40.9524, -81.46354/" + "10/" + "?" + zFormattedAddress + zMapSize + "&key=" + pParent._mapKey
        //    StaticImageURL: "http://dev.virtualearth.net/REST/v1/Imagery/Map/" + zImagerySet + zCenterPoint + zZoomLevel + "&key=" + pParent._mapKey
        var StaticImageURL = "http://dev.virtualearth.net/REST/v1/Imagery/Map/" + zImagerySet + zCenterPoint + zZoomLevel + zMapSize + "&key=" + pParent._mapKey;

        return StaticImageURL;
    } catch (pException) {
        //Error
        var errorMessage = "Failed to load static map image";
    }
}
