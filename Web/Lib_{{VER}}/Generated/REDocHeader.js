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

	es.objects.REDocHeader = es.defineEntity(function () {

		// core columns
		this.REDocId = ko.observable();
		this.REDocGUID = ko.observable();
		this.SafeId = ko.observable();
		this.OwnerId = ko.observable();
		this.RptSetId = ko.observable();
		this.JobDefId = ko.observable();
		this.CreateDate = ko.observable();
		this.AccessDate = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.REDocId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.REDocHeader.prototype.esTypeDefs = {
	};

	es.objects.REDocHeader.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'REDocHeader_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'REDocHeader_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.REDocHeader.prototype.esColumnMap = {
		'REDocId': 1,
		'REDocGUID': 1,
		'SafeId': 1,
		'OwnerId': 1,
		'RptSetId': 1,
		'JobDefId': 1,
		'CreateDate': 1,
		'AccessDate': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.REDocHeaderCollection = es.defineCollection('REDocHeaderCollection', 'REDocHeader');

	//#region Prototype Level Information

	es.objects.REDocHeaderCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'REDocHeaderCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'REDocHeaderCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));