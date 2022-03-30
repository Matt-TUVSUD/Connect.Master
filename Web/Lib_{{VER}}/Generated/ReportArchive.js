//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 4/1/2013 1:43:03 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ReportArchive = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FileNo = ko.observable();
		this.ReportDate = ko.observable();
		this.Report1 = ko.observable();
		this.Report2 = ko.observable();
		this.Diagram = ko.observable();
		this.Practice = ko.observable();
		this.DatePosted = ko.observable();
		this.DateTransferred = ko.observable();
		this.DateToClient = ko.observable();
		this.PreviousDateCompleted = ko.observable();
		this.PreviousReport1 = ko.observable();
		this.PreviousDiagram = ko.observable();
		this.MetaPracticeID = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.Id();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.ReportArchive.prototype.esTypeDefs = {
	};

	es.objects.ReportArchive.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ReportArchive_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'ReportArchive_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.ReportArchive.prototype.esColumnMap = {
		'Id': 'ID',
		'FileNo': 1,
		'ReportDate': 'Date',
		'Report1': 'Report 1',
		'Report2': 'Report 2',
		'Diagram': 1,
		'Practice': 1,
		'DatePosted': 1,
		'DateTransferred': 1,
        'DateToClient': 1,
        'PreviousDateCompleted': 1,
		'PreviousReport1': 1,
		'PreviousDiagram': 1,
        'MetaPracticeID': 1

	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ReportArchiveCollection = es.defineCollection('ReportArchiveCollection', 'ReportArchive');

	//#region Prototype Level Information

	es.objects.ReportArchiveCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ReportArchiveCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ReportArchiveCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));