// Custom method
// ViewCCRecommendationGridCollection
es.objects.ViewCCIRRecommendationGridCollection.prototype.viewCCIRRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCIRRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCIRRecommendationGridCollection.prototype.esRoutes['viewCCIRRecommendationGridCollection'] = { method: 'GET', url: 'viewCCIRRecommendationGridCollection', response: 'collection' };

es.objects.ViewCCIRRecommendationGridCollection.prototype.GetIRRecommendationGridByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['GetIRRecommendationGridByFileNo'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCIRRecommendationGridCollection.prototype.esRoutes['GetIRRecommendationGridByFileNo'] = { method: 'GET', url: 'GetIRRecommendationGridByFileNo', response: 'collection' };
