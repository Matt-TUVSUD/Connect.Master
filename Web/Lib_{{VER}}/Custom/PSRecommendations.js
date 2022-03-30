es.objects.PSRecommendationsCollection.prototype.PSRecommendationCollection_BrowseByLocation = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["PSRecommendationCollection_BrowseByLocation"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.PSRecommendationsCollection.prototype.esRoutes["PSRecommendationCollection_BrowseByLocation"] =
    { method: "GET", url: "PSRecommendationCollection_BrowseByLocation", response: "collection" }


es.objects.PSRecommendationsCollection.prototype.GetPSRecByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetPSRecByFileNo"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.PSRecommendationsCollection.prototype.esRoutes["GetPSRecByFileNo"] =
    { method: "GET", url: "GetPSRecByFileNo", response: "collection" }

