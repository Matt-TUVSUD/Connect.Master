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

	es.objects.GSafeDetail = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.DataName = ko.observable();
		this.DataValue = ko.observable();
		this.DataGroup = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.gSafeId = this.GSafeId();
			val.data.dataName = this.DataName();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.GSafeDetail.prototype.esTypeDefs = {
	};

	es.objects.GSafeDetail.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeDetail_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'GSafeDetail_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.GSafeDetail.prototype.esColumnMap = {
		'GSafeId': 1,
		'DataName': 1,
		'DataValue': 1,
		'DataGroup': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.GSafeDetailCollection = es.defineCollection('GSafeDetailCollection', 'GSafeDetail');

	//#region Prototype Level Information

	es.objects.GSafeDetailCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeDetailCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'GSafeDetailCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));