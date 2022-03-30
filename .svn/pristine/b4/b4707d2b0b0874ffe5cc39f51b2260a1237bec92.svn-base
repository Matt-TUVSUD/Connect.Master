//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 9/3/2013 3:20:12 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCPrefDivisionUsers = es.defineEntity(function () {

		// core columns
		this.FilePrefix = ko.observable();
		this.Location = ko.observable();
		this.CustomAccess = ko.observable();
		this.Division = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPrefDivisionUsers.prototype.esTypeDefs = {};

	es.objects.ViewCCPrefDivisionUsers.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefDivisionUsers_Save', response: 'entity' }
	};

	es.objects.ViewCCPrefDivisionUsers.prototype.esColumnMap = {
		'FilePrefix': 1,
		'Location': 1,
		'CustomAccess': 1,
		'Division': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPrefDivisionUsersCollection = es.defineCollection('ViewCCPrefDivisionUsersCollection', 'ViewCCPrefDivisionUsers');

	//#region Prototype Level Information

	es.objects.ViewCCPrefDivisionUsersCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPrefDivisionUsersCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPrefDivisionUsersCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));