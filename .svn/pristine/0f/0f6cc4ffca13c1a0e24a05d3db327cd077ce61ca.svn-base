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

	es.objects.RERptJobDef = es.defineEntity(function () {

		// core columns
		this.JobDefId = ko.observable();
		this.RptSetId = ko.observable();
		this.RptCode = ko.observable();
		this.StatusId = ko.observable();
		this.StatusDate = ko.observable();
		this.PumpDate = ko.observable();
		this.ErrorMessage = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.JobDefId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.RERptJobDef.prototype.esTypeDefs = {
	};

	es.objects.RERptJobDef.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'RERptJobDef_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'RERptJobDef_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.RERptJobDef.prototype.esColumnMap = {
		'JobDefId': 1,
		'RptSetId': 1,
		'RptCode': 1,
		'StatusId': 1,
		'StatusDate': 1,
		'PumpDate': 1,
		'ErrorMessage': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.RERptJobDefCollection = es.defineCollection('RERptJobDefCollection', 'RERptJobDef');

	//#region Prototype Level Information

	es.objects.RERptJobDefCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'RERptJobDefCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'RERptJobDefCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));