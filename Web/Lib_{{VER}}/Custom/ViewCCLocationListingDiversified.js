// Custom method
// ViewCCLocationDiversifiedCollections
es.objects.ViewCCLocationListingDiversifiedCollection.prototype.ViewCCLocationDiversifiedCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationListingDiversifiedCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingDiversifiedCollection.prototype.esRoutes['ViewCCLocationListingDiversifiedCollection'] = { method: 'GET', url: 'ViewCCLocationDiversifiedCollections', response: 'collection' };


es.objects.ViewCCLocationListingDiversifiedCollection.prototype.GetDiversifiedLocationByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['GetDiversifiedLocationByFileNo'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingDiversifiedCollection.prototype.esRoutes['GetDiversifiedLocationByFileNo'] = { method: 'GET', url: 'GetDiversifiedLocationByFileNo', response: 'collection' };


// Custom method
// ViewCCLocationListingDiversifiedRatingCollection
es.objects.ViewCCLocationListingDiversifiedCollection.prototype.ViewCCLocationDiversifiedRatingCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationDiversifiedRatingCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingDiversifiedCollection.prototype.esRoutes['ViewCCLocationDiversifiedRatingCollections'] = { method: 'GET', url: 'ViewCCLocationDiversifiedRatingCollections', response: 'collection' };

