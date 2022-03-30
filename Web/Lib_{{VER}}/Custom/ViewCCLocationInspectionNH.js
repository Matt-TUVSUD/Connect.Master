// ViewCCLocationInspectionNHCollections
// All NatHaz
es.objects.ViewCCLocationInspectionNHCollection.prototype.ViewCCLocationInspectionNHCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationInspectionNHCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationInspectionNHCollection.prototype.esRoutes['ViewCCLocationInspectionNHCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionNHCollections', response: 'collection' }


//// Flood
//es.objects.ViewCCLocationInspectionNHCollection.prototype.ViewCCLocationInspectionFloodCollections = function (SafeGUID, success, error, state) {
//    return this.load({
//        route: this.esRoutes['ViewCCLocationInspectionFloodCollections'],
//        data: SafeGUID,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCLocationInspectionNHCollection.prototype.esRoutes['ViewCCLocationInspectionFloodCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionFloodCollections', response: 'collection' }


//// Seismic
//es.objects.ViewCCLocationInspectionNHCollection.prototype.ViewCCLocationInspectionSeismicCollections = function (SafeGUID, success, error, state) {
//    return this.load({
//        route: this.esRoutes['ViewCCLocationInspectionSeismicCollections'],
//        data: SafeGUID,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCLocationInspectionNHCollection.prototype.esRoutes['ViewCCLocationInspectionSeismicCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionSeismicCollections', response: 'collection' }


//// Wind
//es.objects.ViewCCLocationInspectionNHCollection.prototype.ViewCCLocationInspectionWindCollections = function (SafeGUID, success, error, state) {
//    return this.load({
//        route: this.esRoutes['ViewCCLocationInspectionWindCollections'],
//        data: SafeGUID,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCLocationInspectionNHCollection.prototype.esRoutes['ViewCCLocationInspectionWindCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionWindCollections', response: 'collection' } 
