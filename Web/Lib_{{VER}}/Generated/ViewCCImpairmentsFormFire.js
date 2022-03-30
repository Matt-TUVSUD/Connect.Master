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

	es.objects.ViewCCImpairmentsFormFire = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FileNo = ko.observable();
		this.Client = ko.observable();
		this.NotifiedVia = ko.observable();
		this.Office = ko.observable();
		this.Status = ko.observable();
		this.DateReceived = ko.observable();
		this.ImpairmentDate = ko.observable();
		this.Duration1 = ko.observable();
		this.Duration2 = ko.observable();
		this.DateRestored = ko.observable();
		this.ActualNoOfDays = ko.observable();
		this.EquipmentTagged = ko.observable();
		this.TagNo = ko.observable();
		this.EquipmentDescription = ko.observable();
		this.CauseForImpairment = ko.observable();
		this.ImpairmentSummary = ko.observable();
		this.FollowUpCall = ko.observable();
		this.FollowUpComment = ko.observable();
		this.FollowUpCall2 = ko.observable();
		this.FollowUpComment2 = ko.observable();
		this.PlantContact = ko.observable();
		this.PhoneNumber = ko.observable();
		this.FaxNumber = ko.observable();
		this.EMail = ko.observable();
		this.Address1 = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Zip = ko.observable();
		this.Country = ko.observable();
		this.ClientLocNo = ko.observable();
		this.Facility = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCImpairmentsFormFire.prototype.esTypeDefs = {};

	es.objects.ViewCCImpairmentsFormFire.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCImpairmentsFormFire_Save', response: 'entity' }
	};

	es.objects.ViewCCImpairmentsFormFire.prototype.esColumnMap = {
		'Id': 'ID',
		'FileNo': 1,
		'Client': 1,
		'NotifiedVia': 1,
		'Office': 1,
		'Status': 1,
		'DateReceived': 1,
		'ImpairmentDate': 1,
		'Duration1': 1,
		'Duration2': 1,
		'DateRestored': 1,
		'ActualNoOfDays': 1,
		'EquipmentTagged': 1,
		'TagNo': 1,
		'EquipmentDescription': 1,
		'CauseForImpairment': 1,
		'ImpairmentSummary': 1,
		'FollowUpCall': 1,
		'FollowUpComment': 1,
		'FollowUpCall2': 1,
		'FollowUpComment2': 1,
		'PlantContact': 1,
		'PhoneNumber': 1,
		'FaxNumber': 1,
		'EMail': 1,
		'Address1': 1,
		'City': 1,
		'StProv': 1,
		'Zip': 1,
		'Country': 1,
		'ClientLocNo': 1,
		'Facility': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCImpairmentsFormFireCollection = es.defineCollection('ViewCCImpairmentsFormFireCollection', 'ViewCCImpairmentsFormFire');

	//#region Prototype Level Information

	es.objects.ViewCCImpairmentsFormFireCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCImpairmentsFormFireCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCImpairmentsFormFireCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));