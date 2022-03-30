// Custom method
// ViewCCLocationFireCollections
es.objects.ViewCCRecCurrentLossEstListCollection.prototype.ViewCCRecCurrentLossEstListCollection_LoadAllByGuid = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCRecCurrentLossEstListCollection_LoadAllByGuid'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCRecCurrentLossEstListCollection.prototype.esRoutes['ViewCCRecCurrentLossEstListCollection_LoadAllByGuid'] = { method: 'GET', url: 'ViewCCRecCurrentLossEstListCollection_LoadAllByGuid', response: 'collection' };

