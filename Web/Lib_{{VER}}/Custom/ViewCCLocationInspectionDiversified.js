// ViewCCLocationInspectionDiversifiedCollections
es.objects.ViewCCLocationInspectionDiversifiedCollection.prototype.ViewCCLocationInspectionDiversifiedCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationInspectionDiversifiedCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationInspectionDiversifiedCollection.prototype.esRoutes['ViewCCLocationInspectionDiversifiedCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionDiversifiedCollections', response: 'collection' }


