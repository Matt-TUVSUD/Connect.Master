//// SPECIFIC FOR REC FORM
es.objects.ViewCCTranslationMgmtIntendedActionCollection.prototype.GetMgmtIntendedActionByFilePrefix = function (pParms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetMgmtIntendedActionByFilePrefix'],
        data: pParms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCTranslationMgmtIntendedActionCollection.prototype.esRoutes['GetMgmtIntendedActionByFilePrefix'] = { method: 'GET', url: 'GetMgmtIntendedActionByFilePrefix', response: 'collection' };

//// SPECIFIC FOR REC RESPONSE
es.objects.ViewCCTranslationMgmtIntendedActionCollection.prototype.GetIntendedActionMgmtTranslationByLanguageFilePrefix = function (pParms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetIntendedActionMgmtTranslationByLanguageFilePrefix'],
        data: pParms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCTranslationMgmtIntendedActionCollection.prototype.esRoutes['GetIntendedActionMgmtTranslationByLanguageFilePrefix'] = { method: 'GET', url: 'GetIntendedActionMgmtTranslationByLanguageFilePrefix', response: 'collection' };
