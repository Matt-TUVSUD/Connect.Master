// ViewCCLocationContactsIRCollection
es.objects.ViewCCLocationContactsIRCollection.prototype.ViewCCLocationContactsIRCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationContactsIRCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationContactsIRCollection.prototype.esRoutes['ViewCCLocationContactsIRCollections'] = { method: 'GET', url: 'ViewCCLocationContactsIRCollections', response: 'collection' };