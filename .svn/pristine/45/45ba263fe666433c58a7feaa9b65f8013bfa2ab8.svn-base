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

	es.objects.ViewCCRecSecondaryTypeList = es.defineEntity(function () {

		// core columns
		this.PrimaryType = ko.observable();
		this.SecondarType = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCRecSecondaryTypeList.prototype.esTypeDefs = {};

	es.objects.ViewCCRecSecondaryTypeList.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecSecondaryTypeList_Save', response: 'entity' }
	};

	es.objects.ViewCCRecSecondaryTypeList.prototype.esColumnMap = {
		'PrimaryType': 1,
		'SecondarType': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCRecSecondaryTypeListCollection = es.defineCollection('ViewCCRecSecondaryTypeListCollection', 'ViewCCRecSecondaryTypeList');

	//#region Prototype Level Information

	es.objects.ViewCCRecSecondaryTypeListCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCRecSecondaryTypeListCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCRecSecondaryTypeListCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));