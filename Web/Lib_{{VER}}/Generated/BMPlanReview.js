//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 4/18/2013 3:43:23 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.BMPlanReview = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FileNo = ko.observable();
		this.Contact = ko.observable();
		this.ContactPhone = ko.observable();
		this.Subject = ko.observable();
		this.Consultant = ko.observable();
		this.Received = ko.observable();
		this.Mailed = ko.observable();
		this.ToReview = ko.observable();
		this.ProjectNo = ko.observable();
		this.Comments = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.Id();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.BMPlanReview.prototype.esTypeDefs = {
	};

	es.objects.BMPlanReview.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'BMPlanReview_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'BMPlanReview_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.BMPlanReview.prototype.esColumnMap = {
		'Id': 'ID',
		'FileNo': 1,
		'Contact': 1,
		'ContactPhone': 'Contact Phone',
		'Subject': 1,
		'Consultant': 1,
		'Received': 1,
		'Mailed': 1,
		'ToReview': 'To Review',
		'ProjectNo': 1,
		'Comments': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.BMPlanReviewCollection = es.defineCollection('BMPlanReviewCollection', 'BMPlanReview');

	//#region Prototype Level Information

	es.objects.BMPlanReviewCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'BMPlanReviewCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'BMPlanReviewCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));