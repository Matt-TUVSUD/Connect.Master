// ViewCCImpairmentsFormFire
es.objects.ViewCCImpairmentsFormFireCollection.prototype.ViewCCImpairmentsFormFireCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCImpairmentsFormFireCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCImpairmentsFormFireCollection.prototype.esRoutes['ViewCCImpairmentsFormFireCollections'] = { method: 'GET', url: 'ViewCCImpairmentsFormFireCollections', response: 'collection' } 
