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

	es.objects.ViewCCLocationContactsJuris = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.Intlocationid = ko.observable();
		this.IntContactID = ko.observable();
		this.Contact = ko.observable();
		this.StrContactType = ko.observable();
		this.Title = ko.observable();
		this.Phone1 = ko.observable();
		this.Fax = ko.observable();
		this.Email = ko.observable();
		this.StrContactAddr1 = ko.observable();
		this.StrContactAddr2 = ko.observable();
		this.StrContactCity = ko.observable();
		this.StrContactState = ko.observable();
		this.StrContactZip = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationContactsJuris.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationContactsJuris.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationContactsJuris_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationContactsJuris.prototype.esColumnMap = {
		'FileNo': 1,
		'Intlocationid': 'intlocationid',
		'IntContactID': 'intContactID',
		'Contact': 'CONTACT',
		'StrContactType': 'strContactType',
		'Title': 'TITLE',
		'Phone1': 'PHONE1',
		'Fax': 'FAX',
		'Email': 'EMAIL',
		'StrContactAddr1': 'strContactAddr1',
		'StrContactAddr2': 'strContactAddr2',
		'StrContactCity': 'strContactCity',
		'StrContactState': 'strContactState',
		'StrContactZip': 'strContactZip'
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationContactsJurisCollection = es.defineCollection('ViewCCLocationContactsJurisCollection', 'ViewCCLocationContactsJuris');

	//#region Prototype Level Information

	es.objects.ViewCCLocationContactsJurisCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationContactsJurisCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationContactsJurisCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));