es.objects.GSafeHeader.prototype.loadByGUID = function (GUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GSafeHeader_LoadByGUID"],
        data: GUID,
        success: success,
        error: error,
        state: state
    });
};

es.objects.GSafeHeader.prototype.esRoutes["GSafeHeader_LoadByGUID"] = { method: "GET", url: "GSafeHeader_LoadByGUID", response: "entity" }

