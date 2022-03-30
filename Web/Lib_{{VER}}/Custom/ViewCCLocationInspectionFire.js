// ViewCCLocationInspectionFireCollections
es.objects.ViewCCLocationInspectionFireCollection.prototype.ViewCCLocationInspectionFireCollections = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCLocationInspectionFireCollections'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCLocationInspectionFireCollection.prototype.esRoutes['ViewCCLocationInspectionFireCollections'] = { method: 'GET', url: 'ViewCCLocationInspectionFireCollections', response: 'collection' }


//// Custom method
//es.objects.ViewCCLocationInspectionFireCollection.prototype.ViewCCLocationInspectionFireCollection_BrowseByFileNo = function (fileno, success, error, state) {

//    return this.load({
//        route: this.esRoutes['ViewCCLocationInspectionFireCollection_BrowseByFileNo'],
//        data: fileno,
//        success: success,
//        error: error,
//        state: state
//    });
//};

////#region Entity Routing

////#region Collection Routing
//es.objects.ViewCCLocationInspectionFireCollection.prototype.esRoutes['ViewCCLocationInspectionFireCollection_BrowseByFileNo'] =
//    { method: 'GET', url: 'ViewCCLocationInspectionFireCollection_BrowseByFileNo', response: 'collection' }
////#endregion 
