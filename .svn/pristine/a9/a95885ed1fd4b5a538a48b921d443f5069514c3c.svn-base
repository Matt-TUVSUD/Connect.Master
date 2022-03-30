// EZY_USER TABLE - USER ACTIVITY GRID LIST
es.objects.ViewCCUserActivityGridCollection.prototype.GetUserActivityGridByGuid = function (gSafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['GetUserActivityGridByGuid'],
        data: gSafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCUserActivityGridCollection.prototype.esRoutes['GetUserActivityGridByGuid'] = { method: 'GET', url: 'GetUserActivityGridByGuid', response: 'collection' };

