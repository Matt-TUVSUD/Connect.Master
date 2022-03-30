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

	es.objects.ViewCCPrefLocation = es.defineEntity(function () {

		// core columns
		this.FilePrefix = ko.observable();
		this.Location = ko.observable();
		this.CustomAccess = ko.observable();
		this.Division = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefLocation.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefLocation.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefLocation_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefLocation.prototype.esColumnMap = {
		'FilePrefix': 1,
		'Location': 1,
		'CustomAccess': 1,
		'Division': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefLocationCollection = es.defineCollection('ViewCCPrefLocationCollection', 'ViewCCPrefLocation');

	//#region Prototype Level Information

	es.objects.ViewCCPrefLocationCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefLocationCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefLocationCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));