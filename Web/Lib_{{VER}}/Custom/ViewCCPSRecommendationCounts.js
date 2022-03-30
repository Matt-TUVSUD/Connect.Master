// Custom method
// PROCESS SAFETY ONLY
es.objects.ViewCCPSRecommendationCountsCollection.prototype.GetRecommendationCountsPS = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetRecommendationCountsPS'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPSRecommendationCountsCollection.prototype.esRoutes['GetRecommendationCountsPS'] = { method: 'GET', url: 'GetRecommendationCountsPS', response: 'collection' };
