/* GET URL QUERY PARAMETER RETURN AS STRING */
function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split("&");
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split("=");
        if (pair[0] == variable) {
            return pair[1];
        }
    }
    return null;
}


function getQueryString() {
    var query = window.location.search.substring(0);
    return query;
}


/* LOOKUP URL OF LINK BY NAVID AND RETURN AS STRING */
function getDestinationUrl(NavLinkId) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var objNavLink = new es.objects.NavLink();
    if (objNavLink.loadByPrimaryKey(NavLinkId)) {
        return objNavLink.NavUrl();
    }
    return "#";
}


/* LOOKUP GUID SAFE ID CLIENT SIDE ONLY AND RETURN AS STRING */
function getGSafeGUID() {
    var temp = getQueryVariable('sid');
    if (temp == null) {
        temp = sessvars.GSafeGUID;
        if (temp == null) {
            return null;
        }
    }
    return temp;
}


/* LOOKUP REC ID CLIENT SIDE ONLY AND RETURN AS STRING */
function getRecId() {
    var temp = null;
    if (gRecId) {
        temp = gRecId;
        gRecId = null;
    } else {
        temp = getQueryVariable('rec');
        if (temp == null) {
            return null;
        }
    }
    return temp;
}


/* SET PAGE AND TAB ID TO THE GSAFE TABLE */
function setPageIdTabId(GSafeGUID, pageId, tabId, gridId) {
    /* SET THE GSAFE */
    var zGridId = "";
    if (gridId) { zGridId = gridId; }
    var parms = GSafeGUID + "|" + pageId + "|" + tabId + "|" + zGridId;
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.savePageIdTabId(parms);
}


/* GET AND RETURN ANY THE CURRENT TAB ID IN THE GSAFE */
function getCurrentTabId(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "currentTab"]);
    var currentTab = collDetail()[0].DataValue();
    return currentTab;
}


/* GET AND RETURN ANY THE CURRENT PAGE ID IN THE GSAFE */
function getCurrentPageId(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "currentPage"]);
    var currentPage = collDetail()[0].DataValue();
    return currentPage;
}


/* SET USER PREFERENCES TO THE GSAFE TABLE */
function setUserPrefs(GSafeGUID, currency, customAccess, division, location, TIV, unit) { 
    /* SAVE TO THE GSAFE */
    var parms = GSafeGUID + "|" + currency + "|" + customAccess + "|" + division + "|" + location + "|" + TIV + "|" + unit;
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.saveUserPrefs(parms);
}


/* SET PAGE AND TAB ID TO THE GSAFE TABLE AND RETREIVE GSAFE FOR BANNER HIGHLIGHT */
function setBannerIds(clickedPageId, clickedTabId) {
    /* GET THE GSafeGUID */
    var GSafeGUID = getGSafeGUID();
    /* SAVE NEW DESTINATION PAGE AND TAB */
    setPageIdTabId(GSafeGUID, clickedPageId, clickedTabId);
}


function setGSafeDetailByKey(pKeyName, pKeyValue, pKeyGroup) {
    /* SAVE TO THE GSAFE */
    var zGSafeGUID = getGSafeGUID();
    var parms = zGSafeGUID + "|" + pKeyName + "|" + pKeyValue + "|" + pKeyGroup;
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.saveValueByKeyName(parms);
}


/* GET AND RETURN A VALUE IN THE GSAFE */
function getUserEmail(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "UserEmail"]);
    var userEmail = collDetail()[0].DataValue();
    return userEmail;
}


/* GET AND RETURN A VALUE IN THE GSAFE */
function getUserIdName(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "UserId"]);
    var userIdName = collDetail()[0].DataValue();
    return userIdName;
}


/* GET AND RETURN A VALUE IN THE GSAFE */
function getFileNo(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "FileNo"]);
    var tempFileNo = collDetail()[0].DataValue();
    return tempFileNo;
}


/* GET AND RETURN A VALUE IN THE GSAFE */
function getFilePrefix(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "FilePrefix"]);
    var tempFilePrefix = collDetail()[0].DataValue();
    return tempFilePrefix;
}


/* GET AND RETURN ANY CLIENT FEATURES (LIMITATIONS) IN THE GSAFE */
function getClientFeatures(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "clientFeatures"]);
    var clientFeatures = collDetail()[0].DataValue();
    return clientFeatures;
}


/* GET AND RETURN USER IS ADMIN IN GSAFE */
function getAdminUser(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "AdminUser"]);
    var isAdmin = collDetail()[0].DataValue().toUpperCase();
    if (isAdmin == "TRUE") {
        return true;
    } else {
        return false;
    }
}


/* GET AND RETURN IF THE CLIENT HAS REC RESPONSE ACTIVE FROM GSAFE */
function getRecAutoFollowup(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "Recautofollowup"]);
    var isRecAutoFollowup = collDetail()[0].DataValue().toUpperCase();
    if (isRecAutoFollowup == "TRUE") {
        return true;
    } else {
        return false;
    }
}


/* GET AND RETURN THE USERS FULL NAME */
function getUserFullName(gSafeGuid) {
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    var collDetail = new es.objects.GSafeDetailCollection();
    collDetail.getValue([gSafeGuid, "userFullName"]);

    var returnValue = collDetail()[0].DataValue();
    if (returnValue != undefined && returnValue != null) {
        return returnValue;
    } else {
        return "Client Connect User";
    }
}


/* GET AND RETURN ANY FIND FIELDS IN THE GSAFE */
function getFindLocationFields(gSafeGuid) {
    var returnObject = [];
    var collDetail = new es.objects.GSafeDetailCollection();
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    collDetail.getValuesByDataGroup([gSafeGuid, "FindLocation"]);
    for (x = 0; x < collDetail().length; x++) {
        returnObject[collDetail()[x].DataName()] = collDetail()[x].DataValue();
    }
    return returnObject;
}


/* LOOK FOR INVALID CHARACTERS IN A STRING */
function isInvalidChar(str) {
    var isInvalid = false;
    if (str.indexOf(">") > 0) { isInvalid = true; }
    if (str.indexOf("<") > 0) { isInvalid = true; }
    if (str.indexOf("|") > 0) { isInvalid = true; }
    if (str.indexOf("#") > 0) { isInvalid = true; }
    if (str.indexOf("%") > 0) { isInvalid = true; }
    if (str.indexOf("&") > 0) { isInvalid = true; }
    if (str.indexOf("^") > 0) { isInvalid = true; }
    if (str.indexOf("*") > 0) { isInvalid = true; }
    if (str.indexOf("(") > 0) { isInvalid = true; }
    if (str.indexOf(")") > 0) { isInvalid = true; }
    if (str.indexOf("{") > 0) { isInvalid = true; }
    if (str.indexOf("}") > 0) { isInvalid = true; }
    if (str.indexOf("~") > 0) { isInvalid = true; }
    if (str.length < 1) { isInvalid = true; }
    return isInvalid;
}
function isInvalidEmail(str) {
    var isInvalid = false;
    if (str.indexOf(">") > 0) { isInvalid = true; }
    if (str.indexOf("<") > 0) { isInvalid = true; }
    if (str.indexOf("|") > 0) { isInvalid = true; }
    if (str.indexOf("#") > 0) { isInvalid = true; }
    if (str.indexOf("%") > 0) { isInvalid = true; }
    if (str.indexOf("&") > 0) { isInvalid = true; }
    if (str.indexOf("^") > 0) { isInvalid = true; }
    if (str.indexOf("*") > 0) { isInvalid = true; }
    if (str.indexOf("(") > 0) { isInvalid = true; }
    if (str.indexOf(")") > 0) { isInvalid = true; }
    if (str.indexOf("{") > 0) { isInvalid = true; }
    if (str.indexOf("}") > 0) { isInvalid = true; }
    if (str.indexOf("~") > 0) { isInvalid = true; }
    if (str.indexOf(" ") > 0) { isInvalid = true; }
    if (str.length < 1) { isInvalid = true; }
    return isInvalid;
}


/* SAVE FIND FIELDS IN THE GSAFE */
function setFindLocationFields(gSafeGuid, objFind, objListing, isJuris) {
    var findFileNo = "";
    var findClientLocNo = "";
    var findAddress1 = "";
    var findCity = "";
    var findStProv = "";
    var findCountry = "";
    var findZip = "";
    var findDivision = "";
    var findFacility = "";
    var findCustomAccess = "";
    var findLongitude = "";
    var findLatitude = "";

    /* CHANGE THIS FUNCTION SO WE COMPARE TO THE EXISTING AND ONLY UPDATE WHAT HAS CHANGED */
    if (objListing.FileNo() != objFind.findFileNo) {
        findFileNo = objListing.FileNo();
    }
    if (isJuris == true) {
        if (objListing.Clientlocno() != objFind.findClientlocno) {
            findClientLocNo = objListing.Clientlocno();
        }
    } else {
        if (objListing.ClientLocNo() != objFind.findClientLocNo) {
            findClientLocNo = objListing.ClientLocNo();
        }
    }
    if (objListing.Address1() != objFind.findAddress1) {
        findAddress1 = objListing.Address1();
    }
    if (objListing.City() != objFind.findCity) {
        findCity = objListing.City();
    }
    if (isJuris == true) {
        if (objListing.Stprov() != objFind.findStprov) {
            findStProv = objListing.Stprov();
        }
    } else {
        if (objListing.StProv() != objFind.findStProv) {
            findStProv = objListing.StProv();
        }
    }
    if (objListing.Country() != objFind.findCountry) {
        findCountry = objListing.Country();
    }
    if (objListing.Zip() != objFind.findZip) {
        findZip = objListing.Zip();
    }
    if (objListing.Division() != objFind.findDivision) {
        findDivision = objListing.Division();
    }
    if (objListing.Facility() != objFind.findFacility) {
        findFacility = objListing.Facility();
    }
    if (objListing.CustomAccess() != objFind.findCustomAccess) {
        findCustomAccess = objListing.CustomAccess();
    }
    if (objListing.Latitude() != objFind.findLatitude) {
        findLatitude = objListing.Latitude();
    }
    if (objListing.Longitude() != objFind.findLongitude) {
        findLongitude = objListing.Longitude();
    }

    /* BUILD THE GSAFE PARMS */
    var parms = gSafeGuid + "|" +
    findFileNo + "|" +
    findClientLocNo + "|" +
    findAddress1 + "|" +
    findCity + "|" +
    findStProv + "|" +
    findCountry + "|" +
    findZip + "|" +
    findDivision + "|" +
    findFacility + "|" +
    findCustomAccess + "|" +
    findLatitude + "|" +
    findLongitude;

    var collFind = new es.objects.GSafeDetailCollection();
    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
    collFind.saveFindLocations(parms);
}


function buildFileOpenLink(pFileName, pGUID, pathType, userFileName, isGrid) {
    /* CREATE A FORM DOM ELEMENT */
    var form = document.createElement("form");
    form.setAttribute("id", "frmGetFile");
    form.setAttribute("method", "post");
    if (isGrid) { form.setAttribute("action", "../../FD/ServeIt.aspx"); } else { form.setAttribute("action", "../../Home_{{VER}}/FD/ServeIt.aspx"); }
    document.body.appendChild(form);

    /* CREATE A HIDDEN INPUT FOR FILE NAME */
    var hiddenFieldFileName = document.createElement("input");
    hiddenFieldFileName.setAttribute("type", "hidden");
    hiddenFieldFileName.setAttribute("id", "fldFileName");
    hiddenFieldFileName.setAttribute("name", "FileName");
    hiddenFieldFileName.setAttribute("value", pFileName);
    form.appendChild(hiddenFieldFileName);

    /* CREATE A HIDDEN INPUT FOR A USER FRIENDLY FILE NAME */
    var hiddenFieldUserFileName = document.createElement("input");
    hiddenFieldUserFileName.setAttribute("type", "hidden");
    hiddenFieldUserFileName.setAttribute("id", "fldUserFileName");
    hiddenFieldUserFileName.setAttribute("name", "UserFileName");
    hiddenFieldUserFileName.setAttribute("value", userFileName);
    form.appendChild(hiddenFieldUserFileName);

    /* CREATE A HIDDEN INPUT FOR IF THE PATH TYPE */
    var hiddenFieldFileExplorerPathType = document.createElement("input");
    hiddenFieldFileExplorerPathType.setAttribute("type", "hidden");
    hiddenFieldFileExplorerPathType.setAttribute("id", "fldPathType");
    hiddenFieldFileExplorerPathType.setAttribute("name", "PathType");
    if (pathType != undefined && pathType != "") { hiddenFieldFileExplorerPathType.setAttribute("value", pathType); } else { hiddenFieldFileExplorerPathType.setAttribute("value", "none"); }
    form.appendChild(hiddenFieldFileExplorerPathType);
    

    /* CREATE A HIDDEN INPUT FOR THE GSAFE GUID */
    var zGUID = "";
    if (pGUID) {
        zGUID = pGUID;
    } else {
        zGUID = getGSafeGUID();
    }
    var hiddenFieldGUID = document.createElement("input");
    hiddenFieldGUID.setAttribute("type", "hidden");
    hiddenFieldGUID.setAttribute("id", "fldGUID");
    hiddenFieldGUID.setAttribute("name", "GSafeGUID");
    hiddenFieldGUID.setAttribute("value", zGUID);
    form.appendChild(hiddenFieldGUID);

    /* SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN */
    form.submit();
    form.removeChild(hiddenFieldFileName);
    form.removeChild(hiddenFieldUserFileName);
    form.removeChild(hiddenFieldFileExplorerPathType);
    form.removeChild(hiddenFieldGUID);
    document.body.removeChild(form);
}


function buildReportDownloadLink(pURL) {
    /* CREATE A FORM DOM ELEMENT */
    var form = document.createElement("form");
    form.setAttribute("id", "frmGetReport");
    form.setAttribute("method", "post");
    form.setAttribute("action", pURL);
    document.body.appendChild(form);
    /* SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN */
    form.submit();
    document.body.removeChild(form);
}


protectFileOpenLink = function(pFileName) {
    var zReturn = "";
    if (pFileName) {
        zReturn = pFileName.replace(/\\/g, "\\\\");
    }
    return zReturn
}