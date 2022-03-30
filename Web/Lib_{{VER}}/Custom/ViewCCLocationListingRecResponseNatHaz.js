//// SPECIFIC FOR REC RESPONSE
es.objects.ViewCCLocationListingRecResponseNatHazCollection.prototype.GetRecResponseNatHazLocationByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['GetRecResponseNatHazLocationByFileNo'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingRecResponseNatHazCollection.prototype.esRoutes['GetRecResponseNatHazLocationByFileNo'] = { method: 'GET', url: 'GetRecResponseNatHazLocationByFileNo', response: 'collection' };
