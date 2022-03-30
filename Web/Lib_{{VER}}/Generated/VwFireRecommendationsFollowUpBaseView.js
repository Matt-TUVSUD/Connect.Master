//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 5/25/2019 6:57:34 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.VwFireRecommendationsFollowUpBaseView = es.defineEntity(function () {

		// core columns
		this.FilePrefix = ko.observable();
		this.FileNo = ko.observable();
		this.Client = ko.observable();
		this.ClientLocNo = ko.observable();
		this.Division = ko.observable();
		this.CustomAccess = ko.observable();
		this.Facility = ko.observable();
		this.Address = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Zip = ko.observable();
		this.Country = ko.observable();
		this.Latitude = ko.observable();
		this.Longitude = ko.observable();
		this.Tivus = ko.observable();
		this.StProvName = ko.observable();
		this.Hazard = ko.observable();
		this.LastInspDate = ko.observable();
		this.RespRequestDate = ko.observable();
		this.AutoRequest = ko.observable();
		this.TotalNoRecs = ko.observable();
		this.NoActiveRecs = ko.observable();
		this.NoRecsNeedingResp = ko.observable();
		this.RespDueDate = ko.observable();
		this.DaysOverdue = ko.observable();
		this.RFU1Date = ko.observable();
		this.RFU2Date = ko.observable();
		this.RFU3Date = ko.observable();
		this.RespRequestDateString = ko.observable();
		this.RespDueDateString = ko.observable();
		this.RFU1DateString = ko.observable();
		this.RFU2DateString = ko.observable();
		this.RFU3DateString = ko.observable();
		this.RespRequestDateMonth = ko.observable();
		this.RespRequestDateYear = ko.observable();
		this.RespDueDateMonth = ko.observable();
		this.RespDueDateYear = ko.observable();
		this.RFU1DateMonth = ko.observable();
		this.RFU1DateYear = ko.observable();
		this.RFU2DateMonth = ko.observable();
		this.RFU2DateYear = ko.observable();
		this.RFU3DateMonth = ko.observable();
		this.RFU3DateYear = ko.observable();
		this.ResponseStatus = ko.observable();
		this.RecipientEmail = ko.observable();
		this.RecipientName = ko.observable();
		this.ResponseStatusColor = ko.observable();
		this.NoRecsNeedingRespColor = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.VwFireRecommendationsFollowUpBaseView.prototype.esTypeDefs = {};

	es.objects.VwFireRecommendationsFollowUpBaseView.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'VwFireRecommendationsFollowUpBaseView_Save', response: 'entity' }
	};

	es.objects.VwFireRecommendationsFollowUpBaseView.prototype.esColumnMap = {
		'FilePrefix': 1,
		'FileNo': 1,
		'Client': 1,
		'ClientLocNo': 1,
		'Division': 1,
		'CustomAccess': 1,
		'Facility': 1,
		'Address': 1,
		'City': 1,
		'StProv': 1,
		'Zip': 1,
		'Country': 1,
		'Latitude': 'latitude',
		'Longitude': 'longitude',
		'Tivus': 'TIVUS',
		'StProvName': 1,
		'Hazard': 1,
		'LastInspDate': 1,
		'RespRequestDate': 1,
		'AutoRequest': 1,
		'TotalNoRecs': 1,
		'NoActiveRecs': 1,
		'NoRecsNeedingResp': 1,
		'RespDueDate': 1,
		'DaysOverdue': 1,
		'RFU1Date': 1,
		'RFU2Date': 1,
		'RFU3Date': 1,
		'RespRequestDateString': 1,
		'RespDueDateString': 1,
		'RFU1DateString': 1,
		'RFU2DateString': 1,
		'RFU3DateString': 1,
		'RespRequestDateMonth': 1,
		'RespRequestDateYear': 1,
		'RespDueDateMonth': 1,
		'RespDueDateYear': 1,
		'RFU1DateMonth': 1,
		'RFU1DateYear': 1,
		'RFU2DateMonth': 1,
		'RFU2DateYear': 1,
		'RFU3DateMonth': 1,
		'RFU3DateYear': 1,
		'ResponseStatus': 1,
		'RecipientEmail': 1,
		'RecipientName': 1,
		'ResponseStatusColor': 1,
		'NoRecsNeedingRespColor': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.VwFireRecommendationsFollowUpBaseViewCollection = es.defineCollection('VwFireRecommendationsFollowUpBaseViewCollection', 'VwFireRecommendationsFollowUpBaseView');

	//#region Prototype Level Information

	es.objects.VwFireRecommendationsFollowUpBaseViewCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'VwFireRecommendationsFollowUpBaseViewCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'VwFireRecommendationsFollowUpBaseViewCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));