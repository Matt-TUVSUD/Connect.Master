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

	es.objects.ViewCCLocationListingRecResponseNatHaz = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.Client = ko.observable();
		this.PracticeCode = ko.observable();
		this.Report1 = ko.observable();
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
		this.SchedulingComment = ko.observable();
		this.CustomAccess = ko.observable();
		this.NatHazWindReportArchiveID = ko.observable();
		this.NatHazWindLastInspectionDate = ko.observable();
		this.NatHazWindLastInspectionReport = ko.observable();
		this.NatHazWindActualDate = ko.observable();
		this.ToNatHazWindReport = ko.observable();
		this.ToNatHazWindReport2 = ko.observable();
		this.ToNatHazWindDiagram = ko.observable();
		this.NatHazWindEmailedDate = ko.observable();
		this.NatHazSeismicReportArchiveID = ko.observable();
		this.NatHazSeismicLastInspectionDate = ko.observable();
		this.NatHazSeismicLastInspectionReport = ko.observable();
		this.NatHazSeismicActualDate = ko.observable();
		this.ToNatHazSeismicReport = ko.observable();
		this.ToNatHazSeismicReport2 = ko.observable();
		this.ToNatHazSeismicDiagram = ko.observable();
		this.NatHazSeismicEmailedDate = ko.observable();
		this.NatHazFloodReportArchiveID = ko.observable();
		this.NatHazFloodLastInspectionDate = ko.observable();
		this.NatHazFloodLastInspectionReport = ko.observable();
		this.NatHazFloodActualDate = ko.observable();
		this.ToNatHazFloodReport = ko.observable();
		this.ToNatHazFloodReport2 = ko.observable();
		this.ToNatHazFloodDiagram = ko.observable();
		this.NatHazFloodEmailedDate = ko.observable();
		this._100PercentUSTot = ko.observable();
		this.RecNum = ko.observable();
		this.RecCount = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingRecResponseNatHaz.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationListingRecResponseNatHaz.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingRecResponseNatHaz_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationListingRecResponseNatHaz.prototype.esColumnMap = {
		'FileNo': 1,
		'Client': 1,
		'PracticeCode': 1,
		'Report1': 1,
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
		'SchedulingComment': 1,
		'CustomAccess': 1,
		'NatHazWindReportArchiveID': 1,
		'NatHazWindLastInspectionDate': 1,
		'NatHazWindLastInspectionReport': 1,
		'NatHazWindActualDate': 1,
		'ToNatHazWindReport': 1,
		'ToNatHazWindReport2': 1,
		'ToNatHazWindDiagram': 1,
		'NatHazWindEmailedDate': 1,
		'NatHazSeismicReportArchiveID': 1,
		'NatHazSeismicLastInspectionDate': 1,
		'NatHazSeismicLastInspectionReport': 1,
		'NatHazSeismicActualDate': 1,
		'ToNatHazSeismicReport': 1,
		'ToNatHazSeismicReport2': 1,
		'ToNatHazSeismicDiagram': 1,
		'NatHazSeismicEmailedDate': 1,
		'NatHazFloodReportArchiveID': 1,
		'NatHazFloodLastInspectionDate': 1,
		'NatHazFloodLastInspectionReport': 1,
		'NatHazFloodActualDate': 1,
		'ToNatHazFloodReport': 1,
		'ToNatHazFloodReport2': 1,
		'ToNatHazFloodDiagram': 1,
		'NatHazFloodEmailedDate': 1,
		'_100PercentUSTot': '100PercentUSTot',
		'RecNum': 1,
		'RecCount': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationListingRecResponseNatHazCollection = es.defineCollection('ViewCCLocationListingRecResponseNatHazCollection', 'ViewCCLocationListingRecResponseNatHaz');

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingRecResponseNatHazCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingRecResponseNatHazCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationListingRecResponseNatHazCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));