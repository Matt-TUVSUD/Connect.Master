//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 8/15/2013 3:38:41 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCBMPlanReview = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FileNo = ko.observable();
		this.PracticeCode = ko.observable();
		this.Contact = ko.observable();
		this.ContactPhone = ko.observable();
		this.Subject = ko.observable();
		this.Consultant = ko.observable();
		this.Received = ko.observable();
		this.Mailed = ko.observable();
		this.ToReview = ko.observable();
		this.ProjectNo = ko.observable();
		this.Comments = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCBMPlanReview.prototype.esTypeDefs = {};

	es.objects.ViewCCBMPlanReview.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCBMPlanReview_Save', response: 'entity' }
	};

	es.objects.ViewCCBMPlanReview.prototype.esColumnMap = {
		'Id': 1,
		'FileNo': 1,
		'PracticeCode': 1,
		'Contact': 1,
		'ContactPhone': 1,
		'Subject': 1,
		'Consultant': 1,
		'Received': 1,
		'Mailed': 1,
		'ToReview': 1,
		'ProjectNo': 1,
		'Comments': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCBMPlanReviewCollection = es.defineCollection('ViewCCBMPlanReviewCollection', 'ViewCCBMPlanReview');

	//#region Prototype Level Information

	es.objects.ViewCCBMPlanReviewCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCBMPlanReviewCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCBMPlanReviewCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));