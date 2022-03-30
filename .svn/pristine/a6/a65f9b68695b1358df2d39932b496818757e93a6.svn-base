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

	es.objects.ViewCCRecStatusList = es.defineEntity(function () {

		// core columns
		this.StatusText = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecStatusList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecStatusList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecStatusList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecStatusList.prototype.esColumnMap = {
		'StatusText': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecStatusListCollection = es.defineCollection('ViewCCRecStatusListCollection', 'ViewCCRecStatusList');

	//#region Prototype Level Information

	es.objects.ViewCCRecStatusListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecStatusListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecStatusListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));