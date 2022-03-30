//// SHOW BANNER BUTTON
function showButton(x) {
    $('#topbanner' + x).toggle();
}

//// HIDE BANNER BUTTONS
function hideButtons() {
    $('#topbanner1').show();
    $('#topbanner2').hide();
    $('#topbanner3').hide();
    $('#topbanner4').hide();
    $('#topbanner5').hide();
    $('#topbanner6').hide();
    $('#topbanner7').hide();
}

//// SHOW HIGHLIGHTED TAB
//function showTab(tabID) {  //// TAB ID IS NO LONGER PASSED AS A PARM, GET FROM GSAFE INSTEAD
function showTab() {
    var GSafeGUID = getGSafeGUID();
    var tabName = "";
    var tabID = "";

    //// LOAD THE CURRENT TAB AND PAGE VALUE PAIRS ASSOCIATED WITH THIS GUID
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.loadPageIdTabId(GSafeGUID);
    for (i = 0; i < collDetail().length; i++) {
        if (collDetail()[i].DataName() == "currentTab") {
            tabID = collDetail()[i].DataValue();
            break;
        }
    }

    switch (tabID) {
        case utilConstants.pageId_Fire: //case "9":
            tabName = "#highlightFire";
            break;
        case utilConstants.pageId_Boiler: //case "10":
            tabName = "#highlightBoiler";
            break;
        case utilConstants.pageId_Infrared:  //case "11":
            tabName = "#highlightInfrared";
            break;
        case utilConstants.pageId_Juris:  //case "12":
            tabName = "#highlightJurisdictional";
            break;
        case utilConstants.pageId_Seismic: //case "13":
            tabName = "#highlightSeismic";
            break;
        case utilConstants.pageId_Wind: //case "14":
            tabName = "#highlightWind";
            break;
        case utilConstants.pageId_Flood: //case "15":
            tabName = "#highlightFlood";
            break;
        default:
            tabName = "";
            break;
    }
    $(tabName).show();
}

//// SHOW TAB ON LOCATION DETAILS PAGE
function showTabAdmin(pSuffix) {
    var GSafeGUID = getGSafeGUID();
    var tabName = "";
    var tabID = "";

    //// LOAD THE CURRENT TAB AND PAGE VALUE PAIRS ASSOCIATED WITH THIS GUID
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.loadPageIdTabId(GSafeGUID);
    for (i = 0; i < collDetail().length; i++) {
        if (collDetail()[i].DataName() == "currentTab") {
            tabID = collDetail()[i].DataValue();
            break;
        }
    }

    switch (tabID) {
        case utilConstants.pageId_Fire: //case "9":
            tabName = "#highlightFire" + pSuffix;
            break;
        case utilConstants.pageId_Boiler: //case "10":
            tabName = "#highlightBoiler" + pSuffix;
            break;
        case utilConstants.pageId_Infrared:  //case "11":
            tabName = "#highlightInfrared" + pSuffix;
            break;
        case utilConstants.pageId_Juris:  //case "12":
            tabName = "#highlightJurisdictional" + pSuffix;
            break;
        case utilConstants.pageId_Seismic: //case "13":
            tabName = "#highlightSeismic" + pSuffix;
            break;
        case utilConstants.pageId_Wind: //case "14":
            tabName = "#highlightWind" + pSuffix;
            break;
        case utilConstants.pageId_Flood: //case "15":
            tabName = "#highlightFlood" + pSuffix;
            break;
        default:
            tabName = "";
            break;
    }
    $(tabName).show();
}




//// SET THE CLICKED TAB FOR THE NEXT PAGE
function setCurrentTab(clickedPageId, clickedTabId) {
    setTimeout(function () {
        // FIX EMPTY VALUES
        if (clickedPageId == null || clickedPageId == undefined || clickedPageId == "") { clickedPageId = "208"; }

        //// GET THE GSafeGUID AND CURRENT PAGE
        var GSafeGUID = getGSafeGUID();
        var currentPageId = getCurrentPageId(GSafeGUID);
        var clientFeatures = getClientFeatures(GSafeGUID);

        //// BUILD LINK TO CROSS NAVIGATE PRACTICES MATCHING THE FILENO AND TYPE OF PAGE WE ARE ON. DETAILS = DETAILS, REC = REC
        //// INSTEAD OF HARD CODING THE BASE1 REPLACEMENT, WE SHOULD DO THIS IN ANOTHER FUNCTION
        ////    IF BASE1 THEN REPLACE .., IF BASE2 THEN REPLACE ../.. ETC.
        var destinationURL = getDestinationUrl(clickedPageId);
        destinationURL = destinationURL.replace("_BASE1_", "..");
        destinationURL = destinationURL.replace("default.aspx", "");
        destinationURL = destinationURL + destinationPageName(currentPageId, clickedTabId, clientFeatures);
        destinationURL = destinationURL + "?sid=" + GSafeGUID;
        destinationURL = destinationURL + "&req=topnav";

        //// SAVE NEW DESTINATION PAGE AND TAB
        setPageIdTabId(GSafeGUID, clickedPageId, clickedTabId);

        //// SET THE SESSVAR OF THE USER GUID
        sessvars.GSafeGUID = GSafeGUID;

        //// GO THE THEN CLICKED TAB
        //// CHECK FOR LOGOUT PAGE
        if (clickedPageId == utilConstants.pageId_LogOut || clickedPageId == "208") {
            document.location.href = "../Logout/Default.aspx" + "?sid=" + GSafeGUID + "&req=topnav";
        } else if (clickedPageId == utilConstants.pageId_LogOutGrid) {
            document.location.href = "../../Logout/Default.aspx" + "?sid=" + GSafeGUID + "&req=topnav";
        } else {
            document.location.href = destinationURL;
        }
    }, 250);
}

//// SET THE CLICKED TAB FOR THE NEXT PAGE
function setCurrentTabGauge(clickedPageId, clickedTabId) {
    setTimeout(function () {
        //// GET THE GSafeGUID AND CURRENT PAGE
        var GSafeGUID = getGSafeGUID();
        var destinationURL = getDestinationUrl(clickedPageId);
        destinationURL = destinationURL.replace("_BASE1_", "..");
        destinationURL = destinationURL + "?sid=" + GSafeGUID;
        destinationURL = destinationURL + "&req=topnav";

        //// SAVE NEW DESTINATION PAGE AND TAB
        setPageIdTabId(GSafeGUID, clickedPageId, clickedTabId);

        //// SET THE SESSVAR OF THE USER GUID
        sessvars.GSafeGUID = GSafeGUID;

        //// GO THE THEN CLICKED TAB
        //// CHECK FOR LOGOUT PAGE
        if (clickedPageId == utilConstants.pageId_LogOut) {
            document.location.href = "../Logout/Default.aspx" + "?sid=" + GSafeGUID + "&req=topnav";
        } else if (clickedPageId == utilConstants.pageId_LogOutGrid) {
            document.location.href = "../../Logout/Default.aspx" + "?sid=" + GSafeGUID + "&req=topnav";
        } else {
            document.location.href = destinationURL;
        }
    }, 250);
}

//// SET THE CLICKED TAB FOR THE NEXT PAGE FOR LOCATION LISTING GRID
function setCurrentTabLocationListing(clickedPageId, clickedTabId, clickedGridId) {
    setTimeout(function () {
        //// GET THE GSafeGUID
        var GSafeGUID = getGSafeGUID();

        //// GET THE URL OF WHERE WE WANT TO GO PLUS THE GUID OF THE USER
        //// INSTEAD OF HARD CODING THE BASE1 REPLACEMENT, WE SHOULD DO THIS IN ANOTHER FUNCTION
        ////    IF BASE1 THEN REPLACE .., IF BASE2 THEN REPLACE ../.. ETC.
        var destinationURL = getDestinationUrl(clickedPageId);
        destinationURL = destinationURL.replace("_BASE1_", "../..");
        destinationURL = destinationURL + "?sid=" + GSafeGUID;
        destinationURL = destinationURL + "&req=topnav";

        //// SAVE NEW DESTINATION PAGE AND TAB
        setPageIdTabId(GSafeGUID, clickedPageId, clickedTabId, clickedGridId);

        //// SET THE SESSVAR OF THE USER GUID
        sessvars.GSafeGUID = GSafeGUID;

        //// GO THE THE CLICKED TAB
        //// CHECK FOR LOGOUT PAGE
        if (clickedPageId == utilConstants.pageId_LogOut) {
            document.location.href = "../../Logout/Default.aspx" + "?sid=" + GSafeGUID + "&req=topnav";
        } else if (clickedPageId == utilConstants.pageId_LogOutGrid) {
            document.location.href = "../../Logout/Default.aspx" + "?sid=" + GSafeGUID + "&req=topnav";
        } else {
            document.location.href = destinationURL;
        }
    }, 250);
}

function destinationPageName(pPage, pTab, pFeatures) {
    var tempPage = "";

    switch (pPage) {
        //// LOCATION DETAILS PAGE
        case utilConstants.pageId_LocationDetails_Fire:
            tempPage = "locationdetails.aspx";
            break;
        case utilConstants.pageId_LocationDetails_Boiler:
            tempPage = "locationdetails.aspx";
            break;
        case utilConstants.pageId_LocationDetails_Juris:
            tempPage = "locationdetails.aspx";
            break;
        case utilConstants.pageId_LocationDetails_Infrared:
            tempPage = "locationdetails.aspx";
            break;
        case utilConstants.pageId_LocationDetails_Seismic:
            tempPage = "locationdetails.aspx";
            break;
        case utilConstants.pageId_LocationDetails_Wind:
            tempPage = "locationdetails.aspx";
            break;
        case utilConstants.pageId_LocationDetails_Flood:
            tempPage = "locationdetails.aspx";
            break;

        //// FACILITY RATINGS PAGE
        case utilConstants.pageId_FacilityRating_Fire:
            tempPage = "facilityrating.aspx";
            break;
        case utilConstants.pageId_FacilityRating_Boiler:
            tempPage = "facilityrating.aspx";
            break;

        //// RECOMMENDATION TRACKING PAGE
        case utilConstants.pageId_RecommendationTracking_Fire:
            tempPage = "rectracking.aspx";
            break;
        case utilConstants.pageId_RecommendationTracking_Fire_Feature_X:
            tempPage = "rectrackingfeaturesX.aspx";
            break;
        case utilConstants.pageId_RecommendationTracking_Boiler:
            tempPage = "rectracking.aspx";
            break;
        case utilConstants.pageId_RecommendationTracking_Infrared:
            tempPage = "rectracking.aspx";
            break;
        case utilConstants.pageId_RecommendationTracking_Seismic:
            tempPage = "rectracking.aspx";
            break;
        case utilConstants.pageId_RecommendationTracking_Wind:
            tempPage = "rectracking.aspx";
            break;
        case utilConstants.pageId_RecommendationTracking_Flood:
            tempPage = "rectracking.aspx";
            break;
        default:
            tempPage = "locationdetails.aspx";
    }

    //// EXCEPTIONS: CORRECT ANY LOCATIONS THAT DO NOT HAVE CERTAIN PAGES
    switch (tempPage) {
        case "facilityrating.aspx":
            if (pTab == utilConstants.pageId_Juris ||
            pTab == utilConstants.pageId_Infrared ||
            pTab == utilConstants.pageId_Seismic ||
            pTab == utilConstants.pageId_Wind ||
            pTab == utilConstants.pageId_Flood) {
                tempPage = "locationdetails.aspx";
            }
            break;
        case "rectracking.aspx":
            if (pTab == utilConstants.pageId_Juris) {
                tempPage = "locationdetails.aspx";
            } else if (pFeatures.search("X") > -1 && (pTab == utilConstants.pageId_Fire)) {
                tempPage = "rectrackingfeaturesX.aspx";
            } else if (pFeatures.search("X") > -1 && (pTab == utilConstants.pageId_Boiler)) {
                tempPage = "rectracking.aspx";
            }
            break;
        case "rectrackingfeaturesX.aspx":
            if (pTab == utilConstants.pageId_Juris) {
                tempPage = "locationdetails.aspx";
            } else if (pTab == utilConstants.pageId_Infrared ||
                  pTab == utilConstants.pageId_Seismic ||
                  pTab == utilConstants.pageId_Wind ||
                  pTab == utilConstants.pageId_Flood) {
                tempPage = "rectracking.aspx";
            } else if (pTab == utilConstants.pageId_Boiler) {
                tempPage = "rectracking.aspx";
            }
            break;
        default:
            break;
            //// DO NOTHING
    }
    
    return tempPage;
}