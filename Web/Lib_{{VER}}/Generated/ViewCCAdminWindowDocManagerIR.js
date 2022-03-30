//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 11/13/2013 1:22:21 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCAdminWindowDocManagerIR = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.PracticeCode = ko.observable();
		this.PracticeName = ko.observable();
		this.ReportArchiveID = ko.observable();
		this.DateOfInspection = ko.observable();
		this.DateMailedToClient = ko.observable();
		this.DateOfInspectionCurrent = ko.observable();
		this.DateMailedToClientCurrent = ko.observable();
		this.LinkToReport = ko.observable();
		this.LinkToReport2 = ko.observable();
		this.LinkToDiagram = ko.observable();
		this.MetaPracticeID = ko.observable();

		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCAdminWindowDocManagerIR.prototype.esTypeDefs = {};

	es.objects.ViewCCAdminWindowDocManagerIR.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCAdminWindowDocManagerIR_Save', response: 'entity' }
	};

	es.objects.ViewCCAdminWindowDocManagerIR.prototype.esColumnMap = {
		'FileNo': 1,
		'PracticeCode': 1,
		'PracticeName': 1,
		'ReportArchiveID': 1,
		'DateOfInspection': 1,
		'DateMailedToClient': 1,
		'DateOfInspectionCurrent': 1,
		'DateMailedToClientCurrent': 1,
		'LinkToReport': 1,
		'LinkToReport2': 1,
		'LinkToDiagram': 1,
		'MetaPracticeID': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCAdminWindowDocManagerIRCollection = es.defineCollection('ViewCCAdminWindowDocManagerIRCollection', 'ViewCCAdminWindowDocManagerIR');

	//#region Prototype Level Information

	es.objects.ViewCCAdminWindowDocManagerIRCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCAdminWindowDocManagerIRCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCAdminWindowDocManagerIRCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));