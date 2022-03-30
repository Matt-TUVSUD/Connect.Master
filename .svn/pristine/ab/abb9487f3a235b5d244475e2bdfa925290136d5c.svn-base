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

	es.objects.ViewCCRecImpactList = es.defineEntity(function () {

		// core columns
		this.CategoryText = ko.observable();
		this.SortOrder = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecImpactList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecImpactList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecImpactList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecImpactList.prototype.esColumnMap = {
		'CategoryText': 1,
		'SortOrder': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecImpactListCollection = es.defineCollection('ViewCCRecImpactListCollection', 'ViewCCRecImpactList');

	//#region Prototype Level Information

	es.objects.ViewCCRecImpactListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecImpactListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecImpactListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));