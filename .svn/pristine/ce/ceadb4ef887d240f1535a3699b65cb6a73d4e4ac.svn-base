//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 8/14/2019 11:37:33 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.Clients = es.defineEntity(function () {

		// core columns
		this.Cldbname = ko.observable();
		this.Clientname = ko.observable();
		this.Features = ko.observable();
		this.Fileprefix = ko.observable();
		this.Clientdesigneenotify = ko.observable();
		this.Clientdesigneename = ko.observable();
		this.Clientdesigneeemail = ko.observable();
		this._580active = ko.observable();
		this.Recrespemail = ko.observable();
		this.Recautofollowup = ko.observable();
		this.Recfollowup1 = ko.observable();
		this.Recfollowup2 = ko.observable();
		this.Recfollowup3 = ko.observable();
		this.Datatransfer = ko.observable();
		this.Timestamp = undefined;
		this.AutoRecStartDate = ko.observable();
		this.AutoRecComments = ko.observable();
		this.FireRatingKeyID = ko.observable();
		this.BMRatingKeyID = ko.observable();
		this.CustomAccessLabel = ko.observable();
		this.WORecipientName = ko.observable();
		this.WORecipientEmail = ko.observable();
		this.WOSubject = ko.observable();
		this.ExchangeRateGroupID = ko.observable();
		this.AutoRecLastProcessDate = ko.observable();
		this.Ifu = ko.observable();
		this.Pifu1 = ko.observable();
		this.Pifu2 = ko.observable();
		this.Pifu3 = ko.observable();
		this.Pifu4 = ko.observable();
		this.ImpClientDesName1 = ko.observable();
		this.ImpClientDesEmail1 = ko.observable();
		this.ImpClientDesName2 = ko.observable();
		this.ImpClientDesEmail2 = ko.observable();
		this.ImpClientDesName3 = ko.observable();
		this.ImpClientDesEmail3 = ko.observable();
		this.Aifu = ko.observable();
		this.ImpClientDesName4 = ko.observable();
		this.ImpClientDesEmail4 = ko.observable();
		this.ImpClientDesName5 = ko.observable();
		this.ImpClientDesEmail5 = ko.observable();
		this.MgmtARR = ko.observable();
		this.ImpEmailAll = ko.observable();
		this.SecurityPasswordExpireDays = ko.observable();
		this.SecurityInactivityLockoutDays = ko.observable();
		this.SecurityInactivityLockoutRemindDays = ko.observable();
		this.SecurityPasswordMinimumLength = ko.observable();
		this.SecurityPasswordTypeId = ko.observable();
		this.DataTransferPackageId = ko.observable();
		this.DataTransferPassword = ko.observable();
		this.DataTransferEncryptionKey = ko.observable();
		this.SecurityAllowChangePassword = ko.observable();
		this.ReclassificationEmailSentDate = ko.observable();
		this.ReclassificationEmailFollowUpDate = ko.observable();
		this.ReclassificationCompletionDate = ko.observable();
		this.ReclassificationLinkGUID = ko.observable();
		this.LastReclassificationCompletionDate = ko.observable();
		this.SysUserCreated = ko.observable();
		this.SysDateCreated = ko.observable();
		this.SysUserModified = ko.observable();
		this.SysDateModified = ko.observable();
		this.ClientId = ko.observable();
		this.DataTransferPgpEnabled = ko.observable();
		this.DataTransferPgpPublicKey = ko.observable();
		this.DataTransferFtpUrl = ko.observable();
		this.DataTransferFtpUserName = ko.observable();
		this.DataTransferFtpPassword = ko.observable();
		this.DataTransferPgpFileExtension = ko.observable();
		this.DataTransferFtpEnabled = ko.observable();
		this.DataTransferRetrievalDate = ko.observable();
		this.DefaultMetaCurrencyID = ko.observable();
		this.ARRRolloutOption = ko.observable();
		this.ARRRolloutOptionDesc = ko.observable();
		this.ImpairmentStatus = ko.observable();
		this.ImpairmentSpecialHandling = ko.observable();
		this.ImpairmentSpecialHandlingDesc = ko.observable();
		this.DataTransferFtpLocalFolder = ko.observable();
		this.DataTransferFileNameFormatString = ko.observable();
		this.DataTransferFtpMonthJson = ko.observable();
		this.DataTransferFtpDayJson = ko.observable();
		this.IndustryGroup = ko.observable();
		this.MajorGroup = ko.observable();
		this.SpecificGroup = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.Fileprefix();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.Clients.prototype.esTypeDefs = {
	};

	es.objects.Clients.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'Clients_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'Clients_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.Clients.prototype.esColumnMap = {
		'Cldbname': 'cldbname',
		'Clientname': 'clientname',
		'Features': 'features',
		'Fileprefix': 'fileprefix',
		'Clientdesigneenotify': 'clientdesigneenotify',
		'Clientdesigneename': 'clientdesigneename',
		'Clientdesigneeemail': 'clientdesigneeemail',
		'_580active': '580active',
		'Recrespemail': 'recrespemail',
		'Recautofollowup': 'recautofollowup',
		'Recfollowup1': 'recfollowup1',
		'Recfollowup2': 'recfollowup2',
		'Recfollowup3': 'recfollowup3',
		'Datatransfer': 'datatransfer',
		'Timestamp': 'timestamp',
		'AutoRecStartDate': 1,
		'AutoRecComments': 1,
		'FireRatingKeyID': 1,
		'BMRatingKeyID': 1,
		'CustomAccessLabel': 1,
		'WORecipientName': 1,
		'WORecipientEmail': 1,
		'WOSubject': 1,
		'ExchangeRateGroupID': 1,
		'AutoRecLastProcessDate': 1,
		'Ifu': 'IFU',
		'Pifu1': 'PIFU1',
		'Pifu2': 'PIFU2',
		'Pifu3': 'PIFU3',
		'Pifu4': 'PIFU4',
		'ImpClientDesName1': 1,
		'ImpClientDesEmail1': 1,
		'ImpClientDesName2': 1,
		'ImpClientDesEmail2': 1,
		'ImpClientDesName3': 1,
		'ImpClientDesEmail3': 1,
		'Aifu': 'AIFU',
		'ImpClientDesName4': 1,
		'ImpClientDesEmail4': 1,
		'ImpClientDesName5': 1,
		'ImpClientDesEmail5': 1,
		'MgmtARR': 1,
		'ImpEmailAll': 1,
		'SecurityPasswordExpireDays': 1,
		'SecurityInactivityLockoutDays': 1,
		'SecurityInactivityLockoutRemindDays': 1,
		'SecurityPasswordMinimumLength': 1,
		'SecurityPasswordTypeId': 1,
		'DataTransferPackageId': 1,
		'DataTransferPassword': 1,
		'DataTransferEncryptionKey': 1,
		'SecurityAllowChangePassword': 1,
		'ReclassificationEmailSentDate': 1,
		'ReclassificationEmailFollowUpDate': 1,
		'ReclassificationCompletionDate': 1,
		'ReclassificationLinkGUID': 1,
		'LastReclassificationCompletionDate': 1,
		'SysUserCreated': 1,
		'SysDateCreated': 1,
		'SysUserModified': 1,
		'SysDateModified': 1,
		'ClientId': 1,
		'DataTransferPgpEnabled': 1,
		'DataTransferPgpPublicKey': 1,
		'DataTransferFtpUrl': 1,
		'DataTransferFtpUserName': 1,
		'DataTransferFtpPassword': 1,
		'DataTransferPgpFileExtension': 1,
		'DataTransferFtpEnabled': 1,
		'DataTransferRetrievalDate': 1,
		'DefaultMetaCurrencyID': 1,
		'ARRRolloutOption': 1,
		'ARRRolloutOptionDesc': 1,
		'ImpairmentStatus': 1,
		'ImpairmentSpecialHandling': 1,
		'ImpairmentSpecialHandlingDesc': 1,
		'DataTransferFtpLocalFolder': 1,
		'DataTransferFileNameFormatString': 1,
		'DataTransferFtpMonthJson': 1,
		'DataTransferFtpDayJson': 1,
		'IndustryGroup': 1,
		'MajorGroup': 1,
		'SpecificGroup': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ClientsCollection = es.defineCollection('ClientsCollection', 'Clients');

	//#region Prototype Level Information

	es.objects.ClientsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ClientsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ClientsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));