//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 12/19/2012 2:22:47 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCLocationAllViolationsJuris = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.ClientLocID = ko.observable();
		this.Division = ko.observable();
		this.Facility = ko.observable();
		this.Address = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Country = ko.observable();
		this.JurisNo = ko.observable();
		this.NatBdNo = ko.observable();
		this.VesselType = ko.observable();
		this.Manufacturer = ko.observable();
		this.YearBuilt = ko.observable();
		this.ObjectLocation = ko.observable();
		this.Status = ko.observable();
		this.CertExpDate = ko.observable();
		this.ViolationID = ko.observable();
		this.ViolationDate = ko.observable();
		this.ViolationType = ko.observable();
		this.ViolationCategory = ko.observable();
		this.ViolationStatus = ko.observable();
		this.ResolutionReqdDate = ko.observable();
		this.Comment = ko.observable();
		this.Requirement = ko.observable();
		this.Condition = ko.observable();
		this.Closed = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationAllViolationsJuris.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationAllViolationsJuris.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationAllViolationsJuris_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationAllViolationsJuris.prototype.esColumnMap = {
		'FileNo': 1,
		'ClientLocID': 'Client__Loc_ID',
		'Division': 1,
		'Facility': 1,
		'Address': 1,
		'City': 1,
		'StProv': 'St_Prov',
		'Country': 1,
		'JurisNo': 'Juris_No',
		'NatBdNo': 'Nat_Bd_No',
		'VesselType': 'Vessel_Type',
		'Manufacturer': 1,
		'YearBuilt': 'Year_Built',
		'ObjectLocation': 'Object_Location',
		'Status': 1,
		'CertExpDate': 'Cert_Exp_Date',
		'ViolationID': 'Violation__ID',
		'ViolationDate': 'Violation__Date',
		'ViolationType': 'Violation__Type',
		'ViolationCategory': 'Violation__Category',
		'ViolationStatus': 'Violation__Status',
		'ResolutionReqdDate': 'Resolution__Reqd_Date',
		'Comment': 1,
		'Requirement': 1,
		'Condition': 1,
		'Closed': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationAllViolationsJurisCollection = es.defineCollection('ViewCCLocationAllViolationsJurisCollection', 'ViewCCLocationAllViolationsJuris');

	//#region Prototype Level Information

	es.objects.ViewCCLocationAllViolationsJurisCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationAllViolationsJurisCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationAllViolationsJurisCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));