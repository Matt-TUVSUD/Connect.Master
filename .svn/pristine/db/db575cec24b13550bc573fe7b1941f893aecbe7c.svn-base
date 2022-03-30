$(document).ready(function(){
    var UnitInput = $("#windowLatLong_UnitInput").kendoDropDownList({
        dataSource: ["Miles", "Nautical Miles", "Kilometers"]
        //,value: "Miles"
    });

    onComputeClick = function () {
        //Verify all inputs are filled in
        var verifyInputMessage = verifyInputs();
        if (verifyInputMessage != "") {
            //Not all inputs are filled in
            //parse missing input string
            var missingInputList = verifyInputMessage.split("|");
            var message = "The following inputs must be filled in: ";
            for (i = 0; i < missingInputList.length - 1; i++) {
                message += missingInputList[i] + ", ";
            }
            message = message.substring(0, message.length - 2);
            //display message
            alert(message);
        }
        else {
            var validateInputMessage = validateInputs();
            if (validateInputMessage != "") {
                alert(validateInputMessage);
            }
            else {
                loadLatLongGrid();
            }
        }
    }

    onResetClick = function () {
        //Reset all inputs
        //  Clear all text inputs
        document.getElementById("windowLatLong_LatInput").value = "";
        document.getElementById("windowLatLong_LongInput").value = "";
        document.getElementById("windowLatLong_DistanceInput").value = "";
        document.getElementById("windowLatLong_NameYourSearchInput").value = "";
        //  Set the dropdown to miles

    }

    validateInputs = function () {
        var returnString = "";
        if (!$.isNumeric(document.getElementById("windowLatLong_LatInput").value)) { return "Latitude, Longitude, and Distance must only conatin numbers."; }
        if (!$.isNumeric(document.getElementById("windowLatLong_LongInput").value)) { return "Latitude, Longitude, and Distance must only conatin numbers."; }
        if (!$.isNumeric(document.getElementById("windowLatLong_DistanceInput").value)) { return "Latitude, Longitude, and Distance must only conatin numbers."; }
        //if (document.getElementById("windowLatLong_NameYourSearchInput").value == "") { returnString += "NameYourSearchInput|"; }
        return returnString;
    }

    verifyInputs = function () {
        var returnString = "";
        if (document.getElementById("windowLatLong_LatInput").value == "") { returnString += "Latitude|"; }
        if (document.getElementById("windowLatLong_LongInput").value == "") { returnString += "Longitude|"; }
        if (document.getElementById("windowLatLong_DistanceInput").value == "") { returnString += "Distance|"; }
        //if (document.getElementById("windowLatLong_NameYourSearchInput").value == "") { returnString += "NameYourSearchInput|"; }
        return returnString;
    }

    sanitizeSearchName = function (pString) {
        return pString.replace(/[^a-zA-Z0-9]/g, '');
    }

    loadLatLongGrid = function () {
        var zLatitude = document.getElementById("windowLatLong_LatInput").value;
        var zLongitude = document.getElementById("windowLatLong_LongInput").value;
        var zUnit = document.getElementById("windowLatLong_UnitInput").value;
        var zRadius = document.getElementById("windowLatLong_DistanceInput").value;
        var zNameYourSearch = document.getElementById("windowLatLong_NameYourSearchInput").value;
        zNameYourSearch = sanitizeSearchName(zNameYourSearch);
        document.getElementById("windowLatLong_NameYourSearchInput").value = zNameYourSearch;

        var zServiceName = "GetLatLongGrid";
        var zParms = ko.toJSON({
            "pLatitude": zLatitude,
            "pLongitude": zLongitude,
            "pUnit": zUnit,
            "pRadius": zRadius,
            "pNameYourSearch": zNameYourSearch,
            "pSid": getQueryVariable("sid")
        });
        global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, loadLatLongGridSuccess, loadLatLongGridError, null);
    }

    loadLatLongGridSuccess = function (pResults) {
        var GSafeGuid = getQueryVariable("sid");
        var GridId = getQueryVariable("gridId");
        openRequestedSinglePopup("../Filter/?sid=" + GSafeGuid + "&mapshapes=true", GridId);
    }

    loadLatLongGridError = function (pResults, pMessage, pErrorDetail) {


    }

    var windowObjectReference = null;
    function openRequestedSinglePopup(strUrl, gridId, chartId, reportId) {
        // BUILD THE IDS USED FOR REPORTS, GRIDS, AND CHARTS
        var zQueryOperator = "?";
        var zItemAdded = false;
        if (strUrl.indexOf("?") > -1) {
            zQueryOperator = "&";
        }
        if (gridId !== undefined && gridId !== null) {
            strUrl = strUrl + zQueryOperator + "gridId=" + gridId;
            zQueryOperator = "&";
        }
        if (chartId !== undefined && chartId !== null) {
            strUrl = strUrl + zQueryOperator + "chartId=" + chartId;
            zQueryOperator = "&";
        }
        if (reportId !== undefined && reportId !== null) {
            strUrl = strUrl + zQueryOperator + "reportId=" + reportId;
            zQueryOperator = "&";
        }
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
    }

    $(".numericOnly").change(function () {
        if (document.getElementById("windowLatLong_LatInput").value < -90) {
            document.getElementById("windowLatLong_LatInput").value = -90;
        }
        else if (document.getElementById("windowLatLong_LatInput").value > 90) {
            document.getElementById("windowLatLong_LatInput").value = 90;
        }
        else if (document.getElementById("windowLatLong_LongInput").value < -180) {
            document.getElementById("windowLatLong_LongInput").value = -180;
        }
        else if (document.getElementById("windowLatLong_LongInput").value > 180) {
            document.getElementById("windowLatLong_LongInput").value = 180;
        }
        else if (document.getElementById("windowLatLong_DistanceInput").value < 0) {
            document.getElementById("windowLatLong_DistanceInput").value = document.getElementById("windowLatLong_DistanceInput").value * -1;
        }
    });
});