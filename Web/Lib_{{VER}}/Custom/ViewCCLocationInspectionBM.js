// ViewCCLocationInspectionBMCollections
es.objects.ViewCCLocationInspectionBMCollection.prototype.ViewCCLocationInspectionBMCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationInspectionBMCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationInspectionBMCollection.prototype.esRoutes['ViewCCLocationInspectionBMCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionBMCollections', response: 'collection' }