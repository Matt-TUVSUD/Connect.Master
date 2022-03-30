// Custom method
es.objects.ClientsCollection.prototype.Clients_BrowseSummary = function (success, error, state) {

    return this.load({
        route: this.esRoutes['ClientsCollection_BrowseSummary'],
        success: success,
        error: error,
        state: state
    });
};

//#region Entity Routing

//#region Collection Routing
es.objects.ClientsCollection.prototype.esRoutes['ClientsCollection_BrowseSummary'] =
    { method: 'GET', url: 'ClientsCollection_BrowseSummary', response: 'collection' }
//#endregion 
