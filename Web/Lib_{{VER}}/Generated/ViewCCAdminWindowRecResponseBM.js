//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 3/20/2013 8:34:30 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCAdminWindowRecResponseBM = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.RRLogId = ko.observable();
		this.RRLogGuid = ko.observable();
		this.CurrentLink = ko.observable();
		this.LinkActive = ko.observable();
		this.Sender = ko.observable();
		this.LastRecipientName = ko.observable();
		this.LastRecipientEmail = ko.observable();
		this.Hazard = ko.observable();
		this.DateRecEmailed = ko.observable();
		this.PracticeCode = ko.observable();
		this.InspectionDate = ko.observable();
		this.InspectionEmailedDate = ko.observable();
		this.LinkToReport = ko.observable();
		this.Activity = ko.observable();
		this.RecCount = ko.observable();
		this.LatestStatusDate = ko.observable();
		this.StatusDateCount = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCAdminWindowRecResponseBM.prototype.esTypeDefs = {};

	es.objects.ViewCCAdminWindowRecResponseBM.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCAdminWindowRecResponseBM_Save', response: 'entity' }
	};

	es.objects.ViewCCAdminWindowRecResponseBM.prototype.esColumnMap = {
		'FileNo': 1,
		'RRLogId': 1,
		'RRLogGuid': 1,
		'CurrentLink': 1,
		'LinkActive': 1,
		'Sender': 1,
		'LastRecipientName': 1,
		'LastRecipientEmail': 1,
		'Hazard': 1,
		'DateRecEmailed': 1,
		'PracticeCode': 1,
		'InspectionDate': 1,
		'InspectionEmailedDate': 1,
		'LinkToReport': 1,
		'Activity': 1,
		'RecCount': 1,
		'LatestStatusDate': 1,
		'StatusDateCount': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCAdminWindowRecResponseBMCollection = es.defineCollection('ViewCCAdminWindowRecResponseBMCollection', 'ViewCCAdminWindowRecResponseBM');

	//#region Prototype Level Information

	es.objects.ViewCCAdminWindowRecResponseBMCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCAdminWindowRecResponseBMCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCAdminWindowRecResponseBMCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));