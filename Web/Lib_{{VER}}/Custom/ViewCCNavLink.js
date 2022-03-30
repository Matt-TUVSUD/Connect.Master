// Custom method
// ViewCCNavLinkCollection
es.objects.ViewCCNavLinkCollection.prototype.ViewCCNavLinksByKeyword = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCNavLinksByKeyword'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCNavLinkCollection.prototype.esRoutes['ViewCCNavLinksByKeyword'] = { method: 'GET', url: 'ViewCCNavLinksByKeyword', response: 'collection' };



// ViewCCNavLinksAllReportsByKeyword
es.objects.ViewCCNavLinkCollection.prototype.ViewCCNavLinksAllReportsByKeyword = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCNavLinksAllReportsByKeyword'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCNavLinkCollection.prototype.esRoutes['ViewCCNavLinksAllReportsByKeyword'] = { method: 'GET', url: 'ViewCCNavLinksAllReportsByKeyword', response: 'collection' };



// ViewCCNavLinksSitemapGetAll
es.objects.ViewCCNavLinkCollection.prototype.ViewCCNavLinksSitemapGetAll = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['ViewCCNavLinksSitemapGetAll'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCNavLinkCollection.prototype.esRoutes['ViewCCNavLinksSitemapGetAll'] = { method: 'GET', url: 'ViewCCNavLinksSitemapGetAll', response: 'collection' };