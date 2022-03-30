// ViewCCLocationInspectionPSCollections
es.objects.ViewCCLocationInspectionPSCollection.prototype.ViewCCLocationInspectionPSCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationInspectionPSCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationInspectionPSCollection.prototype.esRoutes['ViewCCLocationInspectionPSCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionPSCollections', response: 'collection' }


//// Custom method
//es.objects.ViewCCLocationInspectionPSCollection.prototype.ViewCCLocationInspectionPSCollection_BrowseByFileNo = function (fileno, success, error, state) {

//    return this.load({
//        route: this.esRoutes['ViewCCLocationInspectionPSCollection_BrowseByFileNo'],
//        data: fileno,
//        success: success,
//        error: error,
//        state: state
//    });
//};

////#region Entity Routing

////#region Collection Routing
//es.objects.ViewCCLocationInspectionPSCollection.prototype.esRoutes['ViewCCLocationInspectionPSCollection_BrowseByFileNo'] =
//    { method: 'GET', url: 'ViewCCLocationInspectionPSCollection_BrowseByFileNo', response: 'collection' }
////#endregion 
