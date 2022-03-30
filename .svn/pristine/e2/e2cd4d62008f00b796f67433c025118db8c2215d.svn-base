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

	es.objects.GSafeFileNo = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.FileNo = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.gSafeId = this.GSafeId();
			val.data.fileNo = this.FileNo();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.GSafeFileNo.prototype.esTypeDefs = {
	};

	es.objects.GSafeFileNo.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeFileNo_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'GSafeFileNo_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.GSafeFileNo.prototype.esColumnMap = {
		'GSafeId': 1,
		'FileNo': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.GSafeFileNoCollection = es.defineCollection('GSafeFileNoCollection', 'GSafeFileNo');

	//#region Prototype Level Information

	es.objects.GSafeFileNoCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeFileNoCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'GSafeFileNoCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));