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

	es.objects.ViewCCRecIntendedActionList = es.defineEntity(function () {

		// core columns
		this.IntendedActionText = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecIntendedActionList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecIntendedActionList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecIntendedActionList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecIntendedActionList.prototype.esColumnMap = {
		'IntendedActionText': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecIntendedActionListCollection = es.defineCollection('ViewCCRecIntendedActionListCollection', 'ViewCCRecIntendedActionList');

	//#region Prototype Level Information

	es.objects.ViewCCRecIntendedActionListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecIntendedActionListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecIntendedActionListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));