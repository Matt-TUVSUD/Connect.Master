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

	es.objects.ViewCCRecEstCostToCompleteList = es.defineEntity(function () {

		// core columns
		this.LEText = ko.observable();
		this.Order = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecEstCostToCompleteList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecEstCostToCompleteList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecEstCostToCompleteList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecEstCostToCompleteList.prototype.esColumnMap = {
		'LEText': 1,
		'Order': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecEstCostToCompleteListCollection = es.defineCollection('ViewCCRecEstCostToCompleteListCollection', 'ViewCCRecEstCostToCompleteList');

	//#region Prototype Level Information

	es.objects.ViewCCRecEstCostToCompleteListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecEstCostToCompleteListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecEstCostToCompleteListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));