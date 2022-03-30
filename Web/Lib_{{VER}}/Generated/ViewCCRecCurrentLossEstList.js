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

	es.objects.ViewCCRecCurrentLossEstList = es.defineEntity(function () {

		// core columns
		this.LEText = ko.observable();
		this.Order = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecCurrentLossEstList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecCurrentLossEstList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecCurrentLossEstList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecCurrentLossEstList.prototype.esColumnMap = {
		'LEText': 1,
		'Order': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecCurrentLossEstListCollection = es.defineCollection('ViewCCRecCurrentLossEstListCollection', 'ViewCCRecCurrentLossEstList');

	//#region Prototype Level Information

	es.objects.ViewCCRecCurrentLossEstListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecCurrentLossEstListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecCurrentLossEstListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));