// Custom methods
es.objects.ViewCCWhatsNewCollection.prototype.GetWhatsNewList = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetWhatsNewList'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCWhatsNewCollection.prototype.esRoutes['GetWhatsNewList'] = { method: 'GET', url: 'GetWhatsNewList', response: 'collection' };


es.objects.ViewCCWhatsNewCollection.prototype.GetWhatsNewArticle = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetWhatsNewArticle'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCWhatsNewCollection.prototype.esRoutes['GetWhatsNewArticle'] = { method: 'GET', url: 'GetWhatsNewArticle', response: 'collection' };