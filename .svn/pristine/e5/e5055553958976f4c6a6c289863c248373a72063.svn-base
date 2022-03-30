es.objects.GSafeDetailCollection.prototype.loadByID = function (ID, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_LoadByID"],
        data: ID,
        success: success,
        error: error,
        state: state    
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_LoadByID"] =
    { method: "GET", url: "GSafeDetail_LoadByID", response: "collection" }


es.objects.GSafeDetailCollection.prototype.loadByGUID = function (GUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_LoadByGUID"],
        data: GUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_LoadByGUID"] =
    { method: "GET", url: "GSafeDetail_LoadByGUID", response: "collection" }


//// LOAD COLLECTION BY GUID WHERE DETAIL IS "currentPage" AND "currentTab"
es.objects.GSafeDetailCollection.prototype.loadPageIdTabId = function (GUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_loadPageIdTabId"],
        data: GUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_loadPageIdTabId"] =
    { method: "GET", url: "GSafeDetail_loadPageIdTabId", response: "collection" }


//// SAVE COLLECTION BY GUID WHERE DETAIL IS "currentPage" AND "currentTab"
es.objects.GSafeDetailCollection.prototype.savePageIdTabId = function (Parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_savePageIdTabId"],
        data: Parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_savePageIdTabId"] =
    { method: "GET", url: "GSafeDetail_savePageIdTabId", response: "collection" }


//// SAVE COLLECTION BY GUID WHERE DATAGROUP IS "FindLocation"
es.objects.GSafeDetailCollection.prototype.saveFindLocations = function (Parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_SaveFindLocations"],
        data: Parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_SaveFindLocations"] =
    { method: "GET", url: "GSafeDetail_SaveFindLocations", response: "collection" }


//// SAVE COLLECTION BY GUID FOR USER PREFERENCES
es.objects.GSafeDetailCollection.prototype.saveUserPrefs = function (Parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_saveUserPrefs"],
        data: Parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_saveUserPrefs"] =
    { method: "GET", url: "GSafeDetail_saveUserPrefs", response: "collection" }



//// SAVE SPECIFIC KEY NAME BY GUID
es.objects.GSafeDetailCollection.prototype.saveValueByKeyName = function (Parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_saveValueByKeyName"],
        data: Parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_saveValueByKeyName"] =
    { method: "GET", url: "GSafeDetail_saveValueByKeyName", response: "collection" }



//// GET CLIENT FEATURES
es.objects.GSafeDetailCollection.prototype.getValue = function (Parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_GetValueFromClient"],
        data: Parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_GetValueFromClient"] =
    { method: "GET", url: "GSafeDetail_GetValueFromClient", response: "collection" }



//// GET GSAFE DETAILS BY DATA GROUP
es.objects.GSafeDetailCollection.prototype.getValuesByDataGroup = function (Parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeDetail_GetDataGroupFromClient"],
        data: Parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.GSafeDetailCollection.prototype.esRoutes["GSafeDetail_GetDataGroupFromClient"] =
    { method: "GET", url: "GSafeDetail_GetDataGroupFromClient", response: "collection" }



