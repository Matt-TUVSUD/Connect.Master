es.objects.RRLogCollection.prototype.GetRecordByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetRecordByGuid"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};

es.objects.RRLogCollection.prototype.esRoutes["GetRecordByGuid"] = { method: "GET", url: "GetRecordByGuid", response: "collection" }

