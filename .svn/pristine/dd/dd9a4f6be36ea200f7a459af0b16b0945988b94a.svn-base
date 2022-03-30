//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 4/19/2013 1:35:48 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.FirePlanReview = es.defineEntity(function () {

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

	es.objects.FirePlanReview.prototype.esTypeDefs = {
	};

	es.objects.FirePlanReview.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'FirePlanReview_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'FirePlanReview_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.FirePlanReview.prototype.esColumnMap = {
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

	es.objects.FirePlanReviewCollection = es.defineCollection('FirePlanReviewCollection', 'FirePlanReview');

	//#region Prototype Level Information

	es.objects.FirePlanReviewCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'FirePlanReviewCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'FirePlanReviewCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));