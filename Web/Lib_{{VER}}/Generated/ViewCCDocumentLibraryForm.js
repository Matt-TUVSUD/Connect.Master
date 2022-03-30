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

	es.objects.ViewCCDocumentLibraryForm = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FileNo = ko.observable();
		this.ClientLocID = ko.observable();
		this.DocumentDate = ko.observable();
		this.LinkToER = ko.observable();
		this.LinkToUROrLEReport = ko.observable();
		this.LinkToDiagram = ko.observable();
		this.Practice = ko.observable();
		this.Division = ko.observable();
		this.Facility = ko.observable();
		this.Address1 = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Country = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCDocumentLibraryForm.prototype.esTypeDefs = {};

	es.objects.ViewCCDocumentLibraryForm.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCDocumentLibraryForm_Save', response: 'entity' }
	};

	es.objects.ViewCCDocumentLibraryForm.prototype.esColumnMap = {
		'Id': 'ID',
		'FileNo': 1,
		'ClientLocID': 1,
		'DocumentDate': 1,
		'LinkToER': 1,
		'LinkToUROrLEReport': 1,
		'LinkToDiagram': 1,
		'Practice': 1,
		'Division': 1,
		'Facility': 1,
		'Address1': 1,
		'City': 1,
		'StProv': 'St_Prov',
		'Country': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCDocumentLibraryFormCollection = es.defineCollection('ViewCCDocumentLibraryFormCollection', 'ViewCCDocumentLibraryForm');

	//#region Prototype Level Information

	es.objects.ViewCCDocumentLibraryFormCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCDocumentLibraryFormCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCDocumentLibraryFormCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));