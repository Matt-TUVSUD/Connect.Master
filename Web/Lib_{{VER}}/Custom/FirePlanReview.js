es.objects.FirePlanReviewCollection.prototype.GetFirePlanReviewGrid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetFirePlanReviewGrid"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FirePlanReviewCollection.prototype.esRoutes["GetFirePlanReviewGrid"] = { method: "GET", url: "GetFirePlanReviewGrid", response: "collection" }

es.objects.FirePlanReviewCollection.prototype.GetFirePlanReviewByID = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetFirePlanReviewByID"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FirePlanReviewCollection.prototype.esRoutes["GetFirePlanReviewByID"] = { method: "GET", url: "GetFirePlanReviewByID", response: "collection" }