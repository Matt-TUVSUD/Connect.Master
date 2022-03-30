//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 12/19/2012 2:22:48 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCLocationListingFireRecommendation = es.defineEntity(function () {

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
		this.Field1 = ko.observable();
		this.Ownership = ko.observable();
		this.IRINo = ko.observable();
		this.AccountablePerson = ko.observable();
		this.PlantID = ko.observable();
		this.PlantName = ko.observable();
		this.GRCEngineerFire = ko.observable();
		this.GRCEngineerBM = ko.observable();
		this.GRCTitle = ko.observable();
		this.ClientLocation = ko.observable();
		this.Locationname = ko.observable();
		this.Status = ko.observable();
		this.BusinessUnit = ko.observable();
		this.FldEntity = ko.observable();
		this.Occupancy = ko.observable();
		this.Zone = ko.observable();
		this.FldStructure = ko.observable();
		this.Equipment = ko.observable();
		this.Inventory = ko.observable();
		this.Pd = ko.observable();
		this.Bi = ko.observable();
		this.Tiv = ko.observable();
		this.FireFreq = ko.observable();
		this.Fire2000 = ko.observable();
		this.Fire2001 = ko.observable();
		this.Fire2002 = ko.observable();
		this.Fire2003 = ko.observable();
		this.Fire2004 = ko.observable();
		this.Fire2005 = ko.observable();
		this.FireTargetMonth = ko.observable();
		this.FireLastInspectionReport = ko.observable();
		this.FireLastInspectionDate = ko.observable();
		this.FireScheduledDate = ko.observable();
		this.FireActualDate = ko.observable();
		this.ToFireReport = ko.observable();
		this.ToFireReport2 = ko.observable();
		this.ToFireDiagram = ko.observable();
		this.ToBPVReport = ko.observable();
		this.FireEmailedDate = ko.observable();
		this.FireInspectionCount = ko.observable();
		this.SpecialReport = ko.observable();
		this.PlanReview = ko.observable();
		this.FireRecResponseRecevied = ko.observable();
		this.FireAQEDateRecevied = ko.observable();
		this.FireAQERating = ko.observable();
		this.BMFreq = ko.observable();
		this.Bm2000 = ko.observable();
		this.Bm2001 = ko.observable();
		this.Bm2002 = ko.observable();
		this.Bm2003 = ko.observable();
		this.Bm2004 = ko.observable();
		this.Bm2005 = ko.observable();
		this.BMTarget = ko.observable();
		this.EngineerRequired = ko.observable();
		this.BMLastInspectionReport = ko.observable();
		this.BMLastInspectionDate = ko.observable();
		this.ToBMDiagram = ko.observable();
		this.BMScheduledDate = ko.observable();
		this.BMActualDate = ko.observable();
		this.BMEmailedDate = ko.observable();
		this.ToBMReport = ko.observable();
		this.BMRecResponseReceived = ko.observable();
		this.BMAQEDateRecevied = ko.observable();
		this.BMAQERating = ko.observable();
		this.BMInspectionCount = ko.observable();
		this.LocationManager = ko.observable();
		this.LocationPhone = ko.observable();
		this.LocationFax = ko.observable();
		this.LocationEmail = ko.observable();
		this.ARISELastInspection = ko.observable();
		this.ARISEInspectionLetter = ko.observable();
		this.ARISELocationManager = ko.observable();
		this.FireComments = ko.observable();
		this.BMComments = ko.observable();
		this.BPVComments = ko.observable();
		this.Comments = ko.observable();
		this.ResponseDate = ko.observable();
		this.FldAPLPD = ko.observable();
		this.FldAPLBI = ko.observable();
		this.FldAPLTotal = ko.observable();
		this.FldPMLPD = ko.observable();
		this.FldPMLBI = ko.observable();
		this.FldPMLTotal = ko.observable();
		this.FldMFLPD = ko.observable();
		this.FldMFLBI = ko.observable();
		this.FldMFLTotal = ko.observable();
		this.FireUpdate = ko.observable();
		this.BMUpdate = ko.observable();
		this.SquareFootage = ko.observable();
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
		this.BusinessContinuationPlan = ko.observable();
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
		this.ThirdLevelRespDate = ko.observable();
		this.ThirdLevelRespFrom = ko.observable();
		this.ThirdLevelRespAction = ko.observable();
		this.ThirdLevelRespComment  = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingFireRecommendation.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationListingFireRecommendation.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingFireRecommendation_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationListingFireRecommendation.prototype.esColumnMap = {
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
		'Field1': 1,
		'Ownership': 1,
		'IRINo': 1,
		'AccountablePerson': 1,
		'PlantID': 1,
		'PlantName': 1,
		'GRCEngineerFire': 1,
		'GRCEngineerBM': 1,
		'GRCTitle': 1,
		'ClientLocation': 1,
		'Locationname': 'LOCATIONNAME',
		'Status': 1,
		'BusinessUnit': 1,
		'FldEntity': 'fldEntity',
		'Occupancy': 'OCCUPANCY',
		'Zone': 'ZONE',
		'FldStructure': 'fldStructure',
		'Equipment': 'EQUIPMENT',
		'Inventory': 'INVENTORY',
		'Pd': 'PD',
		'Bi': 'BI',
		'Tiv': 'TIV',
		'FireFreq': 1,
		'Fire2000': 1,
		'Fire2001': 1,
		'Fire2002': 1,
		'Fire2003': 1,
		'Fire2004': 1,
		'Fire2005': 1,
		'FireTargetMonth': 1,
		'FireLastInspectionReport': 1,
		'FireLastInspectionDate': 1,
		'FireScheduledDate': 1,
		'FireActualDate': 1,
		'ToFireReport': 1,
		'ToFireReport2': 1,
		'ToFireDiagram': 1,
		'ToBPVReport': 1,
		'FireEmailedDate': 1,
		'FireInspectionCount': 1,
		'SpecialReport': 1,
		'PlanReview': 1,
		'FireRecResponseRecevied': 1,
		'FireAQEDateRecevied': 1,
		'FireAQERating': 1,
		'BMFreq': 1,
		'Bm2000': 'BM2000',
		'Bm2001': 'BM2001',
		'Bm2002': 'BM2002',
		'Bm2003': 'BM2003',
		'Bm2004': 'BM2004',
		'Bm2005': 'BM2005',
		'BMTarget': 1,
		'EngineerRequired': 1,
		'BMLastInspectionReport': 1,
		'BMLastInspectionDate': 1,
		'ToBMDiagram': 1,
		'BMScheduledDate': 1,
		'BMActualDate': 1,
		'BMEmailedDate': 1,
		'ToBMReport': 1,
		'BMRecResponseReceived': 1,
		'BMAQEDateRecevied': 1,
		'BMAQERating': 1,
		'BMInspectionCount': 1,
		'LocationManager': 1,
		'LocationPhone': 1,
		'LocationFax': 1,
		'LocationEmail': 1,
		'ARISELastInspection': 1,
		'ARISEInspectionLetter': 1,
		'ARISELocationManager': 1,
		'FireComments': 1,
		'BMComments': 1,
		'BPVComments': 1,
		'Comments': 1,
		'ResponseDate': 1,
		'FldAPLPD': 'fldAPLPD',
		'FldAPLBI': 'fldAPLBI',
		'FldAPLTotal': 'fldAPLTotal',
		'FldPMLPD': 'fldPMLPD',
		'FldPMLBI': 'fldPMLBI',
		'FldPMLTotal': 'fldPMLTotal',
		'FldMFLPD': 'fldMFLPD',
		'FldMFLBI': 'fldMFLBI',
		'FldMFLTotal': 'fldMFLTotal',
		'FireUpdate': 1,
		'BMUpdate': 1,
		'SquareFootage': 1,
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
		'BusinessContinuationPlan': 1,
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

	es.objects.ViewCCLocationListingFireRecommendationCollection = es.defineCollection('ViewCCLocationListingFireRecommendationCollection', 'ViewCCLocationListingFireRecommendation');

	//#region Prototype Level Information

	es.objects.ViewCCLocationListingFireRecommendationCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationListingFireRecommendationCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationListingFireRecommendationCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));