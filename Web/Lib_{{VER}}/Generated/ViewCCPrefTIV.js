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

	es.objects.ViewCCPrefTIV = es.defineEntity(function () {

		// core columns
		this.Code = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefTIV.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefTIV.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefTIV_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefTIV.prototype.esColumnMap = {
		'Code': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefTIVCollection = es.defineCollection('ViewCCPrefTIVCollection', 'ViewCCPrefTIV');

	//#region Prototype Level Information

	es.objects.ViewCCPrefTIVCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefTIVCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefTIVCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));