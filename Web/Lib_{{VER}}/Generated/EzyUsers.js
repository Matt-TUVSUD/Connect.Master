//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 10/24/2013 4:13:02 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.EzyUsers = es.defineEntity(function () {

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
		this.Wo = ko.observable();
		this.Calist = ko.observable();
		this.Divlist = ko.observable();
		this.Loclist = ko.observable();
		this.ThirdParty = ko.observable();
		this.GRCAdministrator = ko.observable();
		this.LastRecentUpdate = ko.observable();
		this.EzyUserID = ko.observable();
		this.AllowMaintLogin = ko.observable();
		this.CCActive = ko.observable();
		this.ExpOverdue = ko.observable();
		this.SecurityPasswordIsExpired = ko.observable();
		this.SecurityAccountIsLockedOut = ko.observable();
		this.EzyGuid = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.userID = this.UserID();
			val.data.filePrefix = this.FilePrefix();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.EzyUsers.prototype.esTypeDefs = {
	};

	es.objects.EzyUsers.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'EzyUsers_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'EzyUsers_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.EzyUsers.prototype.esColumnMap = {
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
		'Internal': 1,
		'Comments': 'comments',
		'RInit': 1,
		'Rfu1': 'RFU1',
		'Rfu2': 'RFU2',
		'Rfu3': 'RFU3',
		'RReport': 1,
		'ROverdue1': 1,
		'ROverdue2': 1,
		'ROverdue3': 1,
		'RActResp': 1,
		'Wo': 'WO',
		'Calist': 'calist',
		'Divlist': 'divlist',
		'Loclist': 'loclist',
		'ThirdParty': 1,
		'GRCAdministrator': 1,
		'LastRecentUpdate': 1,
		'EzyUserID': 1,
		'AllowMaintLogin': 1,
		'CCActive': 1,
		'ExpOverdue': 1,
		'SecurityPasswordIsExpired': 1,
		'SecurityAccountIsLockedOut': 1,
		'EzyGuid': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.EzyUsersCollection = es.defineCollection('EzyUsersCollection', 'EzyUsers');

	//#region Prototype Level Information

	es.objects.EzyUsersCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'EzyUsersCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'EzyUsersCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));