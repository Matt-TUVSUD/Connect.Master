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

	es.objects.NavLevel = es.defineEntity(function () {

		// core columns
		this.NavLevelId = ko.observable();
		this.LevelName = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.NavLevelId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.NavLevel.prototype.esTypeDefs = {
	};

	es.objects.NavLevel.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'NavLevel_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'NavLevel_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.NavLevel.prototype.esColumnMap = {
		'NavLevelId': 1,
		'LevelName': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.NavLevelCollection = es.defineCollection('NavLevelCollection', 'NavLevel');

	//#region Prototype Level Information

	es.objects.NavLevelCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'NavLevelCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'NavLevelCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));