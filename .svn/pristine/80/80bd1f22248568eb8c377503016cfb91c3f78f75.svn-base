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

	es.objects.REDocAttrib = es.defineEntity(function () {

		// core columns
		this.REDocId = ko.observable();
		this.DataName = ko.observable();
		this.DataValue = ko.observable();
		this.DataGroup = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.rEDocId = this.REDocId();
			val.data.dataName = this.DataName();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.REDocAttrib.prototype.esTypeDefs = {
	};

	es.objects.REDocAttrib.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'REDocAttrib_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'REDocAttrib_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.REDocAttrib.prototype.esColumnMap = {
		'REDocId': 1,
		'DataName': 1,
		'DataValue': 1,
		'DataGroup': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.REDocAttribCollection = es.defineCollection('REDocAttribCollection', 'REDocAttrib');

	//#region Prototype Level Information

	es.objects.REDocAttribCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'REDocAttribCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'REDocAttribCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));