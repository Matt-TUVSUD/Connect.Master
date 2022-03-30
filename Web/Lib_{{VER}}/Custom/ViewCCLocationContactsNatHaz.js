// ViewCCLocationContactsNatHazCollections
es.objects.ViewCCLocationContactsNatHazCollection.prototype.ViewCCLocationContactsNatHazCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationContactsNatHazCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationContactsNatHazCollection.prototype.esRoutes['ViewCCLocationContactsNatHazCollections'] = { method: 'GET', url: 'ViewCCLocationContactsNatHazCollections', response: 'collection' };