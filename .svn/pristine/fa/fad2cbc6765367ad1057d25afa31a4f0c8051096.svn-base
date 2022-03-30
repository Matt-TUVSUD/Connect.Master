// Custom method
// ViewCCGSafeSitemapItems
es.objects.ViewCCGSafeSitemapItemsCollection.prototype.GetAllSiteMapItems = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetAllSiteMapItems'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCGSafeSitemapItemsCollection.prototype.esRoutes['GetAllSiteMapItems'] = { method: 'GET', url: 'GetAllSiteMapItems', response: 'collection' };