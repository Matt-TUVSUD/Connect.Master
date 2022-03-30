//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 10/17/2013 9:10:00 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCLocationListingRecResponseIR = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.Client = ko.observable();
		this.PracticeCode = ko.observable();
		this.SchedulingComment = ko.observable();
		this.ClientLocNo = ko.observable();
		this.Division = ko.observable();
		this.Latitude = ko.observable();
		this.Longitude = ko.observable();
		this.Facility = ko.observable();
		this.Frequency = ko.observable();
		this.Address1 = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Zip = ko.observable();
		this.Country = ko.observable();
		this.Phone1 = ko.observable();
		this.Fax = ko.observable();
		this.InspNotes = ko.observable();
		this.Rpt1Client = ko.observable();
		this.LocationStatus = ko.observable();
		this.InspectionStatus = ko.observable();
		this.SchedFROM = ko.observable();
		this.SchedTO = ko.observable();
		this.DateCompleted = ko.observable();
		this.IRReportArchiveID = ko.observable();
		this.IRLastInspectionReport = ko.observable();
		this.IRLastInspectionDate = ko.observable();
		this.IRActualDate = ko.observable();
		this.ToIRReport = ko.observable();
		this.IREmailedDate = ko.observable();
		this._100PercentUSTot = ko.observable();
		this.CustomAccess = ko.observable();
		this.RecNum = ko.observable();
		this.RecCount = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingRecResponseIR.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationListingRecResponseIR.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingRecResponseIR_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationListingRecResponseIR.prototype.esColumnMap = {
		'FileNo': 1,
		'Client': 1,
		'PracticeCode': 1,
		'SchedulingComment': 1,
		'ClientLocNo': 1,
		'Division': 1,
		'Latitude': 1,
		'Longitude': 1,
		'Facility': 1,
		'Frequency': 1,
		'Address1': 1,
		'City': 1,
		'StProv': 1,
		'Zip': 1,
		'Country': 1,
		'Phone1': 'PHONE1',
		'Fax': 'FAX',
		'InspNotes': 1,
		'Rpt1Client': 1,
		'LocationStatus': 1,
		'InspectionStatus': 1,
		'SchedFROM': 1,
		'SchedTO': 1,
		'DateCompleted': 1,
		'IRReportArchiveID': 1,
		'IRLastInspectionReport': 1,
		'IRLastInspectionDate': 1,
		'IRActualDate': 1,
		'ToIRReport': 1,
		'IREmailedDate': 1,
		'_100PercentUSTot': '100PercentUSTot',
		'CustomAccess': 1,
		'RecNum': 1,
		'RecCount': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationListingRecResponseIRCollection = es.defineCollection('ViewCCLocationListingRecResponseIRCollection', 'ViewCCLocationListingRecResponseIR');

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingRecResponseIRCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingRecResponseIRCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationListingRecResponseIRCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));