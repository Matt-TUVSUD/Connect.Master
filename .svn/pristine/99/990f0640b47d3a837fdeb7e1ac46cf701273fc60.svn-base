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

	es.objects.ViewCCPrefUnit = es.defineEntity(function () {

		// core columns
		this.Code = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefUnit.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefUnit.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefUnit_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefUnit.prototype.esColumnMap = {
		'Code': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefUnitCollection = es.defineCollection('ViewCCPrefUnitCollection', 'ViewCCPrefUnit');

	//#region Prototype Level Information

	es.objects.ViewCCPrefUnitCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefUnitCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefUnitCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));