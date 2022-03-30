//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 12/19/2012 2:22:48 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCWhatsNew = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.Notificationdate = ko.observable();
		this.Fileprefixes = ko.observable();
		this.Description = ko.observable();
		this.Notification = ko.observable();
		this.Active = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCWhatsNew.prototype.esTypeDefs = {};

	es.objects.ViewCCWhatsNew.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCWhatsNew_Save', response: 'entity' }
	};

	es.objects.ViewCCWhatsNew.prototype.esColumnMap = {
		'Id': 'id',
		'Notificationdate': 'notificationdate',
		'Fileprefixes': 'fileprefixes',
		'Description': 'description',
		'Notification': 'notification',
		'Active': 'active'
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCWhatsNewCollection = es.defineCollection('ViewCCWhatsNewCollection', 'ViewCCWhatsNew');

	//#region Prototype Level Information

	es.objects.ViewCCWhatsNewCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCWhatsNewCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCWhatsNewCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));