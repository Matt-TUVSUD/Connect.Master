es.objects.FireRecommendationsCollection.prototype.FireRecommendationCollection_BrowseByLocation = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["FireRecommendationCollection_BrowseByLocation"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["FireRecommendationCollection_BrowseByLocation"] =
    { method: "GET", url: "FireRecommendationCollection_BrowseByLocation", response: "collection" }


es.objects.FireRecommendationsCollection.prototype.GetLocationLevelFireRecByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes["GetLocationLevelFireRecByFileNo"],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["GetLocationLevelFireRecByFileNo"] =
    { method: "GET", url: "GetLocationLevelFireRecByFileNo", response: "collection" }



//// SEISMIC ONLY
es.objects.FireRecommendationsCollection.prototype.SeismicRecommendationCollection_BrowseByLocation = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["SeismicRecommendationCollection_BrowseByLocation"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["SeismicRecommendationCollection_BrowseByLocation"] =
    { method: "GET", url: "SeismicRecommendationCollection_BrowseByLocation", response: "collection" }

es.objects.FireRecommendationsCollection.prototype.GetSeismicRecByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GetSeismicRecByFileNo"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["GetSeismicRecByFileNo"] =
    { method: "GET", url: "GetSeismicRecByFileNo", response: "collection" }



//// WIND ONLY
es.objects.FireRecommendationsCollection.prototype.WindRecommendationCollection_BrowseByLocation = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["WindRecommendationCollection_BrowseByLocation"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["WindRecommendationCollection_BrowseByLocation"] =
    { method: "GET", url: "WindRecommendationCollection_BrowseByLocation", response: "collection" }

es.objects.FireRecommendationsCollection.prototype.GetWindRecByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GetWindRecByFileNo"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["GetWindRecByFileNo"] =
    { method: "GET", url: "GetWindRecByFileNo", response: "collection" }



//// FLOOD ONLY
es.objects.FireRecommendationsCollection.prototype.FloodRecommendationCollection_BrowseByLocation = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["FloodRecommendationCollection_BrowseByLocation"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["FloodRecommendationCollection_BrowseByLocation"] =
    { method: "GET", url: "FloodRecommendationCollection_BrowseByLocation", response: "collection" }

es.objects.FireRecommendationsCollection.prototype.GetFloodRecByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GetFloodRecByFileNo"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.FireRecommendationsCollection.prototype.esRoutes["GetFloodRecByFileNo"] =
    { method: "GET", url: "GetFloodRecByFileNo", response: "collection" }
