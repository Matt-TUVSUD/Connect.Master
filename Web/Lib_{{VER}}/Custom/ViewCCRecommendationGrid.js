// Custom method
// ViewCCRecommendationGridCollection
es.objects.ViewCCRecommendationGridCollection.prototype.viewCCRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCRecommendationGridCollection.prototype.esRoutes['viewCCRecommendationGridCollection'] = { method: 'GET', url: 'viewCCRecommendationGridCollection', response: 'collection' };

