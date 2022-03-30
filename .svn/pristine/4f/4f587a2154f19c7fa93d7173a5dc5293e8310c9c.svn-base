//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 2/28/2013 3:04:17 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.RRLog = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FilePrefix = ko.observable();
		this.FileNo = ko.observable();
		this.PracticeCode = ko.observable();
		this.Hazard = ko.observable();
		this.DateStamp = ko.observable();
		this.Sender = ko.observable();
		this.RecipientName = ko.observable();
		this.RecipientEmail = ko.observable();
		this.Activity = ko.observable();
		this.LinkActive = ko.observable();
		this.LinkActivatedDate = ko.observable();
		this.LinkActivatedBy = ko.observable();
		this.LinkActivatedByEmail = ko.observable();
		this.ResponseActive = ko.observable();
		this.ResponseLastActivity = ko.observable();
		this.Changed = ko.observable();
		this.RFU1Date = ko.observable();
		this.RFU2Date = ko.observable();
		this.RFU3Date = ko.observable();
		this.RRLogGuid = ko.observable();
		this.CurrentLink = ko.observable();
		this.LanguagePreference = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.Id();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.RRLog.prototype.esTypeDefs = {
	};

	es.objects.RRLog.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'RRLog_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'RRLog_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.RRLog.prototype.esColumnMap = {
		'Id': 'ID',
		'FilePrefix': 1,
		'FileNo': 1,
		'PracticeCode': 1,
		'Hazard': 1,
		'DateStamp': 1,
		'Sender': 1,
		'RecipientName': 1,
		'RecipientEmail': 1,
		'Activity': 1,
		'LinkActive': 1,
		'LinkActivatedDate': 1,
		'LinkActivatedBy': 1,
		'LinkActivatedByEmail': 1,
		'ResponseActive': 1,
		'ResponseLastActivity': 1,
		'Changed': 1,
		'RFU1Date': 1,
		'RFU2Date': 1,
		'RFU3Date': 1,
		'RRLogGuid': 1,
		'CurrentLink': 1,
        'LanguagePreference': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.RRLogCollection = es.defineCollection('RRLogCollection', 'RRLog');

	//#region Prototype Level Information

	es.objects.RRLogCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'RRLogCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'RRLogCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));