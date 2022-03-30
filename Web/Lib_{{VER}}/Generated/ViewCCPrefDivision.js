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

	es.objects.ViewCCPrefDivision = es.defineEntity(function () {

		// core columns
		this.FilePrefix = ko.observable();
		this.Location = ko.observable();
		this.CustomAccess = ko.observable();
		this.Division = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefDivision.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefDivision.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefDivision_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefDivision.prototype.esColumnMap = {
		'FilePrefix': 1,
		'Location': 1,
		'CustomAccess': 1,
		'Division': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefDivisionCollection = es.defineCollection('ViewCCPrefDivisionCollection', 'ViewCCPrefDivision');

	//#region Prototype Level Information

	es.objects.ViewCCPrefDivisionCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefDivisionCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefDivisionCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));