//// GET THE LIST OF EZYUSERS BASED ON ONE GSAFE GUID
es.objects.EzyUsersCollection.prototype.getEzyUserList = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GetEzyUserList"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state    
    });
};
es.objects.EzyUsersCollection.prototype.esRoutes["GetEzyUserList"] = { method: "GET", url: "GetEzyUserList", response: "collection" }


//// SAVE THE PASSWORD
es.objects.EzyUsersCollection.prototype.setEzyUserPassword = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["SetEzyUserPassword"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.EzyUsersCollection.prototype.esRoutes["SetEzyUserPassword"] = { method: "GET", url: "SetEzyUserPassword", response: "collection" }


//// CHECK FOR ANY EXISTING PASSWORDS
es.objects.EzyUsersCollection.prototype.isPasswordExist = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["IsPasswordExist"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.EzyUsersCollection.prototype.esRoutes["IsPasswordExist"] = { method: "GET", url: "IsPasswordExist", response: "collection" }


//// USER ACTIVITY SINGLE RECORD
es.objects.EzyUsersCollection.prototype.GetEzyUserById = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetEzyUserById"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.EzyUsersCollection.prototype.esRoutes["GetEzyUserById"] = { method: "GET", url: "GetEzyUserById", response: "collection" }

//// USER ACTIVITY MULTIPLE RECORDS
es.objects.EzyUsersCollection.prototype.GetEzyUserByEmail = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetEzyUserByEmail"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.EzyUsersCollection.prototype.esRoutes["GetEzyUserByEmail"] = { method: "GET", url: "GetEzyUserByEmail", response: "collection" }


//// DELETE A USER
es.objects.EzyUsersCollection.prototype.DeleteUserByKeys = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["DeleteUserByKeys"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.EzyUsersCollection.prototype.esRoutes["DeleteUserByKeys"] = { method: "GET", url: "DeleteUserByKeys", response: "collection" }

