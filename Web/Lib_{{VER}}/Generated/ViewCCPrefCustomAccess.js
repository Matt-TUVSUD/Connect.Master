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

	es.objects.ViewCCPrefCustomAccess = es.defineEntity(function () {

		// core columns
		this.FilePrefix = ko.observable();
		this.Location = ko.observable();
		this.CustomAccess = ko.observable();
		this.Division = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefCustomAccess.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefCustomAccess.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefCustomAccess_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefCustomAccess.prototype.esColumnMap = {
		'FilePrefix': 1,
		'Location': 1,
		'CustomAccess': 1,
		'Division': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefCustomAccessCollection = es.defineCollection('ViewCCPrefCustomAccessCollection', 'ViewCCPrefCustomAccess');

	//#region Prototype Level Information

	es.objects.ViewCCPrefCustomAccessCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefCustomAccessCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefCustomAccessCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));