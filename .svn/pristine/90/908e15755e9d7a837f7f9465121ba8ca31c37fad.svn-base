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

	es.objects.ViewCCRecCompletedLossEstList = es.defineEntity(function () {

		// core columns
		this.LEText = ko.observable();
		this.Order = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecCompletedLossEstList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecCompletedLossEstList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecCompletedLossEstList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecCompletedLossEstList.prototype.esColumnMap = {
		'LEText': 1,
		'Order': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecCompletedLossEstListCollection = es.defineCollection('ViewCCRecCompletedLossEstListCollection', 'ViewCCRecCompletedLossEstList');

	//#region Prototype Level Information

	es.objects.ViewCCRecCompletedLossEstListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecCompletedLossEstListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecCompletedLossEstListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));