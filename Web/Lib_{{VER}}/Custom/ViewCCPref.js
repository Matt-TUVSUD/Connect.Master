// Custom method
// viewCCPrefCurrencyCollection
es.objects.ViewCCPrefCurrencyCollection.prototype.viewCCPrefCurrencyCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPrefCurrencyCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPrefCurrencyCollection.prototype.esRoutes['viewCCPrefCurrencyCollection'] = { method: 'GET', url: 'viewCCPrefCurrencyCollection', response: 'collection' };

// Custom method
// viewCCPrefUnitCollection
es.objects.ViewCCPrefUnitCollection.prototype.viewCCPrefUnitCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPrefUnitCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPrefUnitCollection.prototype.esRoutes['viewCCPrefUnitCollection'] = { method: 'GET', url: 'viewCCPrefUnitCollection', response: 'collection' };

// Custom method
// viewCCPrefDivisionCollection
es.objects.ViewCCPrefDivisionCollection.prototype.viewCCPrefDivisionCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPrefDivisionCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPrefDivisionCollection.prototype.esRoutes['viewCCPrefDivisionCollection'] = { method: 'GET', url: 'viewCCPrefDivisionCollection', response: 'collection' };

// Custom method
// viewCCPrefCustomAccessCollection
es.objects.ViewCCPrefCustomAccessCollection.prototype.viewCCPrefCustomAccessCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPrefCustomAccessCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPrefCustomAccessCollection.prototype.esRoutes['viewCCPrefCustomAccessCollection'] = { method: 'GET', url: 'viewCCPrefCustomAccessCollection', response: 'collection' };

// Custom method
// viewCCPrefLocationCollection
es.objects.ViewCCPrefLocationCollection.prototype.viewCCPrefLocationCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPrefLocationCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPrefLocationCollection.prototype.esRoutes['viewCCPrefLocationCollection'] = { method: 'GET', url: 'viewCCPrefLocationCollection', response: 'collection' };

// Custom method
// viewCCPrefTIVCollection
es.objects.ViewCCPrefTIVCollection.prototype.viewCCPrefTIVCollection = function (SafeGUID, success, error, state) {
    return this.load({
        route: this.esRoutes['viewCCPrefTIVCollection'],
        data: SafeGUID,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCPrefTIVCollection.prototype.esRoutes['viewCCPrefTIVCollection'] = { method: 'GET', url: 'viewCCPrefTIVCollection', response: 'collection' };
