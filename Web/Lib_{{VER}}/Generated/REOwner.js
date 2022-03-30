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

	es.objects.REOwner = es.defineEntity(function () {

		// core columns
		this.OwnerId = ko.observable();
		this.Email = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.OwnerId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.REOwner.prototype.esTypeDefs = {
	};

	es.objects.REOwner.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'REOwner_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'REOwner_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.REOwner.prototype.esColumnMap = {
		'OwnerId': 1,
		'Email': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.REOwnerCollection = es.defineCollection('REOwnerCollection', 'REOwner');

	//#region Prototype Level Information

	es.objects.REOwnerCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'REOwnerCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'REOwnerCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));