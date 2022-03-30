
es.objects.VwFireRecommendationsBaseViewCollection.prototype.GetLocationLevelFireRecommendations = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes["GetLocationLevelFireRecommendations"],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};

es.objects.VwFireRecommendationsBaseViewCollection.prototype.esRoutes["GetLocationLevelFireRecommendations"] =
    { method: "GET", url: "GetLocationLevelFireRecommendations", response: "collection" }



es.objects.VwFireRecommendationsBaseViewCollection.prototype.save = function () {
    return this.load({
        route: this.esRoutes["SaveLocationLevelFireRecommendation"],
        data: this,
        success: success,
        error: error,
        state: state
    });
};

es.objects.VwFireRecommendationsBaseViewCollection.prototype.esRoutes["SaveLocationLevelFireRecommendation"] =
    { method: "PUT", url: "SaveLocationLevelFireRecommendation", response: "collection" }


