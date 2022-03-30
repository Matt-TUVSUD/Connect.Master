//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 1/6/2013 5:51:29 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.GSafeHeader = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.GSafeGUID = ko.observable();
		this.Created = ko.observable();
		this.LastAccessed = ko.observable();
		this.LastUpdated = ko.observable();
		this.LoginName = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.GSafeId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.GSafeHeader.prototype.esTypeDefs = {
	};

	es.objects.GSafeHeader.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeHeader_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'GSafeHeader_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.GSafeHeader.prototype.esColumnMap = {
		'GSafeId': 1,
		'GSafeGUID': 1,
		'Created': 1,
		'LastAccessed': 1,
		'LastUpdated': 1,
		'LoginName': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.GSafeHeaderCollection = es.defineCollection('GSafeHeaderCollection', 'GSafeHeader');

	//#region Prototype Level Information

	es.objects.GSafeHeaderCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeHeaderCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'GSafeHeaderCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));