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

	es.objects.NavControl = es.defineEntity(function () {

		// core columns
		this.NavControlId = ko.observable();
		this.ControlName = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.NavControlId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.NavControl.prototype.esTypeDefs = {
	};

	es.objects.NavControl.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'NavControl_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'NavControl_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.NavControl.prototype.esColumnMap = {
		'NavControlId': 1,
		'ControlName': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.NavControlCollection = es.defineCollection('NavControlCollection', 'NavControl');

	//#region Prototype Level Information

	es.objects.NavControlCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'NavControlCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'NavControlCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));