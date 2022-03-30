//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 12/19/2012 2:22:48 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCPrefCurrency = es.defineEntity(function () {

		// core columns
		this.Code = ko.observable();
		this.Currency = ko.observable();
		this.Symbol = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefCurrency.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefCurrency.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefCurrency_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefCurrency.prototype.esColumnMap = {
		'Code': 1,
		'Currency': 1,
		'Symbol': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefCurrencyCollection = es.defineCollection('ViewCCPrefCurrencyCollection', 'ViewCCPrefCurrency');

	//#region Prototype Level Information

	es.objects.ViewCCPrefCurrencyCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefCurrencyCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefCurrencyCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));