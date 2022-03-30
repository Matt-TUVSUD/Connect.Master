// Custom method
// ViewCCRecommendationGridCollection
es.objects.ViewCCFireRecommendationGridCollection.prototype.viewCCFireRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCFireRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['viewCCFireRecommendationGridCollection'] = { method: 'GET', url: 'viewCCFireRecommendationGridCollection', response: 'collection' };

es.objects.ViewCCFireRecommendationGridCollection.prototype.GetFireRecommendationGridByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetFireRecommendationGridByFileNo'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['GetFireRecommendationGridByFileNo'] = { method: 'GET', url: 'GetFireRecommendationGridByFileNo', response: 'collection' };




//// SIESMIC ONLY
es.objects.ViewCCFireRecommendationGridCollection.prototype.viewCCSeismicRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCSeismicRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['viewCCSeismicRecommendationGridCollection'] = { method: 'GET', url: 'viewCCSeismicRecommendationGridCollection', response: 'collection' };

es.objects.ViewCCFireRecommendationGridCollection.prototype.GetSeismicRecommendationGridByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetSeismicRecommendationGridByFileNo'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['GetSeismicRecommendationGridByFileNo'] = { method: 'GET', url: 'GetSeismicRecommendationGridByFileNo', response: 'collection' };





//// FLOOD ONLY
es.objects.ViewCCFireRecommendationGridCollection.prototype.viewCCFloodRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCFloodRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['viewCCFloodRecommendationGridCollection'] = { method: 'GET', url: 'viewCCFloodRecommendationGridCollection', response: 'collection' };

es.objects.ViewCCFireRecommendationGridCollection.prototype.GetFloodRecommendationGridByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetFloodRecommendationGridByFileNo'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['GetFloodRecommendationGridByFileNo'] = { method: 'GET', url: 'GetFloodRecommendationGridByFileNo', response: 'collection' };







//// WIND ONLY
es.objects.ViewCCFireRecommendationGridCollection.prototype.viewCCWindRecommendationGridCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCWindRecommendationGridCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['viewCCWindRecommendationGridCollection'] = { method: 'GET', url: 'viewCCWindRecommendationGridCollection', response: 'collection' };

es.objects.ViewCCFireRecommendationGridCollection.prototype.GetWindRecommendationGridByFileNo = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetWindRecommendationGridByFileNo'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCFireRecommendationGridCollection.prototype.esRoutes['GetWindRecommendationGridByFileNo'] = { method: 'GET', url: 'GetWindRecommendationGridByFileNo', response: 'collection' };
