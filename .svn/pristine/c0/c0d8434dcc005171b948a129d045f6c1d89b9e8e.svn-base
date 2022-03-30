//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 1/6/2013 5:51:28 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.GSafeFilePrefix = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.FilePrefix = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.gSafeId = this.GSafeId();
			val.data.filePrefix = this.FilePrefix();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.GSafeFilePrefix.prototype.esTypeDefs = {
	};

	es.objects.GSafeFilePrefix.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeFilePrefix_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'GSafeFilePrefix_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.GSafeFilePrefix.prototype.esColumnMap = {
		'GSafeId': 1,
		'FilePrefix': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.GSafeFilePrefixCollection = es.defineCollection('GSafeFilePrefixCollection', 'GSafeFilePrefix');

	//#region Prototype Level Information

	es.objects.GSafeFilePrefixCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeFilePrefixCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'GSafeFilePrefixCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));