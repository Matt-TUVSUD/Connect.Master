// Custom method
// ViewCCRecommendationGridCollection
es.objects.ViewCCPSRecommendationGridCollection.prototype.viewCCPSRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPSRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['viewCCPSRecommendationGridCollection'] = { method: 'GET', url: 'viewCCPSRecommendationGridCollection', response: 'collection' };

es.objects.ViewCCPSRecommendationGridCollection.prototype.GetPSRecommendationGridByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetPSRecommendationGridByFileNo'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['GetPSRecommendationGridByFileNo'] = { method: 'GET', url: 'GetPSRecommendationGridByFileNo', response: 'collection' };




////// SIESMIC ONLY
//es.objects.ViewCCPSRecommendationGridCollection.prototype.viewCCSeismicRecommendationGridCollection = function (SafeGUID, success, error, state) {
//    return this.load({
//        route: this.esRoutes['viewCCSeismicRecommendationGridCollection'],
//        data: SafeGUID,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['viewCCSeismicRecommendationGridCollection'] = { method: 'GET', url: 'viewCCSeismicRecommendationGridCollection', response: 'collection' };

//es.objects.ViewCCPSRecommendationGridCollection.prototype.GetSeismicRecommendationGridByFileNo = function (parms, success, error, state) {
//    return this.load({
//        route: this.esRoutes['GetSeismicRecommendationGridByFileNo'],
//        data: parms,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['GetSeismicRecommendationGridByFileNo'] = { method: 'GET', url: 'GetSeismicRecommendationGridByFileNo', response: 'collection' };





////// FLOOD ONLY
//es.objects.ViewCCPSRecommendationGridCollection.prototype.viewCCFloodRecommendationGridCollection = function (SafeGUID, success, error, state) {
//    return this.load({
//        route: this.esRoutes['viewCCFloodRecommendationGridCollection'],
//        data: SafeGUID,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['viewCCFloodRecommendationGridCollection'] = { method: 'GET', url: 'viewCCFloodRecommendationGridCollection', response: 'collection' };

//es.objects.ViewCCPSRecommendationGridCollection.prototype.GetFloodRecommendationGridByFileNo = function (parms, success, error, state) {
//    return this.load({
//        route: this.esRoutes['GetFloodRecommendationGridByFileNo'],
//        data: parms,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['GetFloodRecommendationGridByFileNo'] = { method: 'GET', url: 'GetFloodRecommendationGridByFileNo', response: 'collection' };







////// WIND ONLY
//es.objects.ViewCCPSRecommendationGridCollection.prototype.viewCCWindRecommendationGridCollection = function (SafeGUID, success, error, state) {
//    return this.load({
//        route: this.esRoutes['viewCCWindRecommendationGridCollection'],
//        data: SafeGUID,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['viewCCWindRecommendationGridCollection'] = { method: 'GET', url: 'viewCCWindRecommendationGridCollection', response: 'collection' };

//es.objects.ViewCCPSRecommendationGridCollection.prototype.GetWindRecommendationGridByFileNo = function (parms, success, error, state) {
//    return this.load({
//        route: this.esRoutes['GetWindRecommendationGridByFileNo'],
//        data: parms,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCPSRecommendationGridCollection.prototype.esRoutes['GetWindRecommendationGridByFileNo'] = { method: 'GET', url: 'GetWindRecommendationGridByFileNo', response: 'collection' };
