// Custom method
// BOILER AND MACHINERY
es.objects.ViewCCAdminWindowRecResponseBMCollection.prototype.GetBMInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetBMInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponseBMCollection.prototype.esRoutes['GetBMInfoByGuid'] = { method: 'GET', url: 'GetBMInfoByGuid', response: 'collection' };


// FIRE
es.objects.ViewCCAdminWindowRecResponseFireCollection.prototype.GetFireInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetFireInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponseFireCollection.prototype.esRoutes['GetFireInfoByGuid'] = { method: 'GET', url: 'GetFireInfoByGuid', response: 'collection' };


// INFRARED
es.objects.ViewCCAdminWindowRecResponseIRCollection.prototype.GetIRInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetIRInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponseIRCollection.prototype.esRoutes['GetIRInfoByGuid'] = { method: 'GET', url: 'GetIRInfoByGuid', response: 'collection' };


// JURIS
es.objects.ViewCCAdminWindowRecResponseJurisCollection.prototype.GetJurisInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetJurisInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponseJurisCollection.prototype.esRoutes['GetJurisInfoByGuid'] = { method: 'GET', url: 'GetJurisInfoByGuid', response: 'collection' };


// NATURAL HAZARD
//es.objects.ViewCCAdminWindowRecResponseNatHazCollection.prototype.GetNatHazInfoByGuid = function (parms, success, error, state) {
//    return this.load({
//        route: this.esRoutes['GetNatHazInfoByGuid'],
//        data: parms,
//        success: success,
//        error: error,
//        state: state
//    });
//};
//es.objects.ViewCCAdminWindowRecResponseNatHazCollection.prototype.esRoutes['GetNatHazInfoByGuid'] = { method: 'GET', url: 'GetNatHazInfoByGuid', response: 'collection' };


// NATURAL HAZARD
es.objects.ViewCCAdminWindowRecResponseNHCollection.prototype.GetNHInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetNHInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponseNHCollection.prototype.esRoutes['GetNHInfoByGuid'] = { method: 'GET', url: 'GetNHInfoByGuid', response: 'collection' };

// DIVERSIFIED SERVICES
es.objects.ViewCCAdminWindowRecResponseDiversifiedCollection.prototype.GetDivServInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetDivServInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponseDiversifiedCollection.prototype.esRoutes['GetDivServInfoByGuid'] = { method: 'GET', url: 'GetDivServInfoByGuid', response: 'collection' };

// PROCESS SAFETY
es.objects.ViewCCAdminWindowRecResponsePSCollection.prototype.GetPSInfoByGuid = function (parms, success, error, state) {
    return this.load({
        route: this.esRoutes['GetPSInfoByGuid'],
        data: parms,
        success: success,
        error: error,
        state: state
    });
};
es.objects.ViewCCAdminWindowRecResponsePSCollection.prototype.esRoutes['GetPSInfoByGuid'] = { method: 'GET', url: 'GetPSInfoByGuid', response: 'collection' };

