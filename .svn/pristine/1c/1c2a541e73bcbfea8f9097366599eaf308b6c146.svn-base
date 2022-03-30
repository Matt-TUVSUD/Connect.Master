//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 9/4/2013 2:25:11 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCPrefCustomAccessFilteredByFilePrefix = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.FilePrefix = ko.observable();
		this.Location = ko.observable();
		this.CustomAccess = ko.observable();
		this.Division = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefCustomAccessFilteredByFilePrefix.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefCustomAccessFilteredByFilePrefix.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefCustomAccessFilteredByFilePrefix_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefCustomAccessFilteredByFilePrefix.prototype.esColumnMap = {
		'GSafeId': 1,
		'FilePrefix': 1,
		'Location': 1,
		'CustomAccess': 1,
		'Division': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefCustomAccessFilteredByFilePrefixCollection = es.defineCollection('ViewCCPrefCustomAccessFilteredByFilePrefixCollection', 'ViewCCPrefCustomAccessFilteredByFilePrefix');

	//#region Prototype Level Information

	es.objects.ViewCCPrefCustomAccessFilteredByFilePrefixCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefCustomAccessFilteredByFilePrefixCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefCustomAccessFilteredByFilePrefixCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));