//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 1/23/2017 12:40:20 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCLocationListingDiversified = es.defineEntity(function () {

		// core columns
		this.Client = ko.observable();
		this.PracticeCode = ko.observable();
		this.Facility = ko.observable();
		this.ClientLocNo = ko.observable();
		this.FileNo = ko.observable();
		this.Report2 = ko.observable();
		this.Rpt2Revwr = ko.observable();
		this.Rpt2Client = ko.observable();
		this.Region = ko.observable();
		this.ServicedBy = ko.observable();
		this.LocalTIV = ko.observable();
		this.Division = ko.observable();
		this.Latitude = ko.observable();
		this.Longitude = ko.observable();
		this.DivServReportArchiveID = ko.observable();
		this.DivServLastInspectionReport = ko.observable();
		this.DivServLastInspectionDate = ko.observable();
		this.DivServActualDate = ko.observable();
		this.ToDivServReport = ko.observable();
		this.ToDivServReport2 = ko.observable();
		this.ToDivServDiagram = ko.observable();
		this.DivServEmailedDate = ko.observable();
		this.Frequency = ko.observable();
		this.Address1 = ko.observable();
		this.Address2 = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Zip = ko.observable();
		this.Country = ko.observable();
		this.Phone1 = ko.observable();
		this.Fax = ko.observable();
		this.InspNotes = ko.observable();
		this.DateCompleted = ko.observable();
		this.Rpt1Client = ko.observable();
		this.LocationStatus = ko.observable();
		this.InspectionStatus = ko.observable();
		this.Engineer = ko.observable();
		this.SchedFROM = ko.observable();
		this.SchedTO = ko.observable();
		this.NextInspYr = ko.observable();
		this.TotalUSTIV = ko.observable();
		this.TotalUSPD = ko.observable();
		this.TotalUSBI = ko.observable();
		this._100PercentUSTot = ko.observable();
		this.SchedulingComment = ko.observable();
		this.CustomAccess = ko.observable();
		this.GSafeGUID = ko.observable();
		this.RecNum = ko.observable();
		this.RecCount = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingDiversified.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationListingDiversified.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingDiversified_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationListingDiversified.prototype.esColumnMap = {
		'Client': 1,
		'PracticeCode': 1,
		'Facility': 1,
		'ClientLocNo': 1,
		'FileNo': 1,
		'Report2': 1,
		'Rpt2Revwr': 1,
		'Rpt2Client': 1,
		'Region': 1,
		'ServicedBy': 1,
		'LocalTIV': 1,
		'Division': 1,
		'Latitude': 1,
		'Longitude': 1,
		'DivServReportArchiveID': 1,
		'DivServLastInspectionReport': 1,
		'DivServLastInspectionDate': 1,
		'DivServActualDate': 1,
		'ToDivServReport': 1,
		'ToDivServReport2': 1,
		'ToDivServDiagram': 1,
		'DivServEmailedDate': 1,
		'Frequency': 1,
		'Address1': 1,
		'Address2': 1,
		'City': 1,
		'StProv': 1,
		'Zip': 1,
		'Country': 1,
		'Phone1': 'PHONE1',
		'Fax': 'FAX',
		'InspNotes': 1,
		'DateCompleted': 1,
		'Rpt1Client': 1,
		'LocationStatus': 1,
		'InspectionStatus': 1,
		'Engineer': 1,
		'SchedFROM': 1,
		'SchedTO': 1,
		'NextInspYr': 1,
		'TotalUSTIV': 'TotalUS_TIV',
		'TotalUSPD': 'TotalUS_PD',
		'TotalUSBI': 'TotalUS_BI',
		'_100PercentUSTot': '100PercentUSTot',
		'SchedulingComment': 1,
		'CustomAccess': 1,
		'GSafeGUID': 1,
		'RecNum': 1,
		'RecCount': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationListingDiversifiedCollection = es.defineCollection('ViewCCLocationListingDiversifiedCollection', 'ViewCCLocationListingDiversified');

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingDiversifiedCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingDiversifiedCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationListingDiversifiedCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));