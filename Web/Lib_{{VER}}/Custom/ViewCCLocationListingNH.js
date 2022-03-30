// Custom method
// ViewCCLocationNHCollections
es.objects.ViewCCLocationListingNHCollection.prototype.ViewCCLocationNHCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationNHCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingNHCollection.prototype.esRoutes['ViewCCLocationNHCollections'] = { method: 'GET', url: 'ViewCCLocationNHCollections', response: 'collection' };


es.objects.ViewCCLocationListingNHCollection.prototype.GetNHLocationByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['GetNHLocationByFileNo'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingNHCollection.prototype.esRoutes['GetNHLocationByFileNo'] = { method: 'GET', url: 'GetNHLocationByFileNo', response: 'collection' };
