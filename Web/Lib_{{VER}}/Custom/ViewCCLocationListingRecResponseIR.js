//// SPECIFIC FOR REC RESPONSE
es.objects.ViewCCLocationListingRecResponseIRCollection.prototype.GetRecResponseIRLocationByFileNo = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['GetRecResponseIRLocationByFileNo'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationListingRecResponseIRCollection.prototype.esRoutes['GetRecResponseIRLocationByFileNo'] = { method: 'GET', url: 'GetRecResponseIRLocationByFileNo', response: 'collection' };
