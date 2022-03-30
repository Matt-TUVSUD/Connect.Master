//// SAVE ACCESS DATE
es.objects.REDocHeaderCollection.prototype.SetAccessDate = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["SetAccessDate"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.REDocHeaderCollection.prototype.esRoutes["SetAccessDate"] = { method: "GET", url: "SetAccessDate", response: "collection" }
