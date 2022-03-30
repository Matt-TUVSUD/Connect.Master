//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 4/4/2013 10:27:04 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCUserActivityGrid = es.defineEntity(function () {

		// core columns
		this.UserID = ko.observable();
		this.Password = ko.observable();
		this.FullName = ko.observable();
		this.RiskManager = ko.observable();
		this.DivisionManager = ko.observable();
		this.Division = ko.observable();
		this.PlantManager = ko.observable();
		this.Plant = ko.observable();
		this.Administrator = ko.observable();
		this.DocumentAccess = ko.observable();
		this.CustomAccess = ko.observable();
		this.CustomAccessText = ko.observable();
		this.OperatorStamp = ko.observable();
		this.DateTimeStamp = ko.observable();
		this.Phone = ko.observable();
		this.Fax = ko.observable();
		this.Email = ko.observable();
		this.NotificationStamp = ko.observable();
		this.ActiveUser = ko.observable();
		this.FilePrefix = ko.observable();
		this.LastLogin = ko.observable();
		this.LastPWChange = ko.observable();
		this.ExpEmailCode = ko.observable();
		this.Internal = ko.observable();
		this.Comments = ko.observable();
		this.RInit = ko.observable();
		this.Rfu1 = ko.observable();
		this.Rfu2 = ko.observable();
		this.Rfu3 = ko.observable();
		this.RReport = ko.observable();
		this.ROverdue1 = ko.observable();
		this.ROverdue2 = ko.observable();
		this.ROverdue3 = ko.observable();
		this.RActResp = ko.observable();
		this.ExpOverdue = ko.observable();
		this.Wo = ko.observable();
		this.CCActive = ko.observable();
		this.Calist = ko.observable();
		this.Divlist = ko.observable();
		this.Loclist = ko.observable();
		this.ThirdParty = ko.observable();
		this.GRCAdministrator = ko.observable();
		this.LastRecentUpdate = ko.observable();
		this.DisableEmail = ko.observable();
		this.EzyUserID = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCUserActivityGrid.prototype.esTypeDefs = {};

	es.objects.ViewCCUserActivityGrid.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCUserActivityGrid_Save', response: 'entity' }
	};

	es.objects.ViewCCUserActivityGrid.prototype.esColumnMap = {
		'UserID': 1,
		'Password': 1,
		'FullName': 1,
		'RiskManager': 1,
		'DivisionManager': 1,
		'Division': 1,
		'PlantManager': 1,
		'Plant': 1,
		'Administrator': 1,
		'DocumentAccess': 1,
		'CustomAccess': 1,
		'CustomAccessText': 1,
		'OperatorStamp': 1,
		'DateTimeStamp': 1,
		'Phone': 1,
		'Fax': 1,
		'Email': 1,
		'NotificationStamp': 1,
		'ActiveUser': 1,
		'FilePrefix': 1,
		'LastLogin': 1,
		'LastPWChange': 1,
		'ExpEmailCode': 1,
		'Internal': 1,
		'Comments': 1,
		'RInit': 1,
		'Rfu1': 1,
		'Rfu2': 1,
		'Rfu3': 1,
		'RReport': 1,
		'ROverdue1': 1,
		'ROverdue2': 1,
		'ROverdue3': 1,
		'RActResp': 1,
		'ExpOverdue': 1,
		'Wo': 1,
		'CCActive': 1,
		'Calist': 'calist',
		'Divlist': 'divlist',
		'Loclist': 'loclist',
		'ThirdParty': 'ThirdParty ',
		'GRCAdministrator': 'GRCAdministrator ',
		'LastRecentUpdate': 'LastRecentUpdate ',
		'DisableEmail': 1,
		'EzyUserID': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCUserActivityGridCollection = es.defineCollection('ViewCCUserActivityGridCollection', 'ViewCCUserActivityGrid');

	//#region Prototype Level Information

	es.objects.ViewCCUserActivityGridCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCUserActivityGridCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCUserActivityGridCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));