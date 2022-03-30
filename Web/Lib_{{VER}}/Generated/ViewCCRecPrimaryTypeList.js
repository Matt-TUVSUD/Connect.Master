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

	es.objects.ViewCCRecPrimaryTypeList = es.defineEntity(function () {

		// core columns
		this.Hazard = ko.observable();
		this.PrimaryType = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecPrimaryTypeList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecPrimaryTypeList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecPrimaryTypeList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecPrimaryTypeList.prototype.esColumnMap = {
		'Hazard': 1,
		'PrimaryType': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecPrimaryTypeListCollection = es.defineCollection('ViewCCRecPrimaryTypeListCollection', 'ViewCCRecPrimaryTypeList');

	//#region Prototype Level Information

	es.objects.ViewCCRecPrimaryTypeListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecPrimaryTypeListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecPrimaryTypeListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));