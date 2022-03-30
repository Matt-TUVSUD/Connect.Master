// Custom method
// ViewCCBMFacilityRatingCollection
es.objects.ViewCCBMFacilityRatingCollection.prototype.ViewCCBMFacilityRatingCollection = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCBMFacilityRatingCollection'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCBMFacilityRatingCollection.prototype.esRoutes['viewCCBMFacilityRatingCollection'] = { method: 'GET', url: 'viewCCBMFacilityRatingCollection', response: 'collection' };