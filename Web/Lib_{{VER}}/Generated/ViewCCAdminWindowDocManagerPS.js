//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 5/1/2018 9:35:02 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCAdminWindowDocManagerPS = es.defineEntity(function () {

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

	es.objects.ViewCCAdminWindowDocManagerPS.prototype.esTypeDefs = {};

	es.objects.ViewCCAdminWindowDocManagerPS.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCAdminWindowDocManagerPS_Save', response: 'entity' }
	};

	es.objects.ViewCCAdminWindowDocManagerPS.prototype.esColumnMap = {
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

	es.objects.ViewCCAdminWindowDocManagerPSCollection = es.defineCollection('ViewCCAdminWindowDocManagerPSCollection', 'ViewCCAdminWindowDocManagerPS');

	//#region Prototype Level Information

	es.objects.ViewCCAdminWindowDocManagerPSCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCAdminWindowDocManagerPSCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCAdminWindowDocManagerPSCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));