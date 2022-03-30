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

	es.objects.Clientfeatures = es.defineEntity(function () {

		// core columns
		this.Featurescode = ko.observable();
		this.Description = ko.observable();
		this.FullDescription = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.Featurescode();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.Clientfeatures.prototype.esTypeDefs = {
	};

	es.objects.Clientfeatures.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'Clientfeatures_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'Clientfeatures_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.Clientfeatures.prototype.esColumnMap = {
		'Featurescode': 'featurescode',
		'Description': 'description',
		'FullDescription': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ClientfeaturesCollection = es.defineCollection('ClientfeaturesCollection', 'Clientfeatures');

	//#region Prototype Level Information

	es.objects.ClientfeaturesCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ClientfeaturesCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ClientfeaturesCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));