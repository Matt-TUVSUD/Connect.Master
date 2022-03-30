es.objects.ViewCCFirePlanReviewCollection.prototype.GetFirePlanReviewGrid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetFirePlanReviewGrid"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFirePlanReviewCollection.prototype.esRoutes["GetFirePlanReviewGrid"] = { method: "GET", url: "GetFirePlanReviewGrid", response: "collection" }

es.objects.ViewCCFirePlanReviewCollection.prototype.GetFirePlanReviewByID = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetFirePlanReviewByID"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFirePlanReviewCollection.prototype.esRoutes["GetFirePlanReviewByID"] = { method: "GET", url: "GetFirePlanReviewByID", response: "collection" }

es.objects.ViewCCFirePlanReviewCollection.prototype.GetFirePlanReviewFileNoList = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetFirePlanReviewFileNoList"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFirePlanReviewCollection.prototype.esRoutes["GetFirePlanReviewFileNoList"] = { method: "GET", url: "GetFirePlanReviewFileNoList", response: "collection" }