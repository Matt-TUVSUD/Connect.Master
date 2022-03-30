//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 1/6/2013 5:51:28 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.Contact1 = es.defineEntity(function () {

		// core columns
		this.Accountno = ko.observable();
		this.Company = ko.observable();
		this.Contact = ko.observable();
		this.Lastname = ko.observable();
		this.Department = ko.observable();
		this.Title = ko.observable();
		this.Secr = ko.observable();
		this.Phone1 = ko.observable();
		this.Phone2 = ko.observable();
		this.Phone3 = ko.observable();
		this.Fax = ko.observable();
		this.Ext1 = ko.observable();
		this.Ext2 = ko.observable();
		this.Ext3 = ko.observable();
		this.Ext4 = ko.observable();
		this.Address1 = ko.observable();
		this.Address2 = ko.observable();
		this.City = ko.observable();
		this.State = ko.observable();
		this.Zip = ko.observable();
		this.Country = ko.observable();
		this.Dear = ko.observable();
		this.Source = ko.observable();
		this.Key1 = ko.observable();
		this.Key2 = ko.observable();
		this.Key3 = ko.observable();
		this.Key4 = ko.observable();
		this.Key5 = ko.observable();
		this.Status = ko.observable();
		this.Notes = ko.observable();
		this.Owner = ko.observable();
		this.Createby = ko.observable();
		this.Lastuser = ko.observable();
		this.Lastdate = ko.observable();
		this.Lasttime = ko.observable();
		this.Address3 = ko.observable();
		this.LocationComment = ko.observable();
		this.GRCNotes = ko.observable();
		this.ARISENotes = ko.observable();
		this.Recid = ko.observable();
		this.DateEntered = ko.observable();
		this.TimeEntered = ko.observable();
		this.Deleteflag = ko.observable();
		this.Sqfootage = ko.observable();
		this.Client1 = ko.observable();
		this.Client2 = ko.observable();
		this.Occupancy = ko.observable();
		this.CustomAccess = ko.observable();
		this.FilePrefix = ko.observable();
		this.Latitude = ko.observable();
		this.Longitude = ko.observable();
		this.ContactID = ko.observable();

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.ContactID();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.Contact1.prototype.esTypeDefs = {
	};

	es.objects.Contact1.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'Contact1_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'Contact1_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.Contact1.prototype.esColumnMap = {
		'Accountno': 'ACCOUNTNO',
		'Company': 'COMPANY',
		'Contact': 'CONTACT',
		'Lastname': 'LASTNAME',
		'Department': 'DEPARTMENT',
		'Title': 'TITLE',
		'Secr': 'SECR',
		'Phone1': 'PHONE1',
		'Phone2': 'PHONE2',
		'Phone3': 'PHONE3',
		'Fax': 'FAX',
		'Ext1': 'EXT1',
		'Ext2': 'EXT2',
		'Ext3': 'EXT3',
		'Ext4': 'EXT4',
		'Address1': 'ADDRESS1',
		'Address2': 'ADDRESS2',
		'City': 'CITY',
		'State': 'STATE',
		'Zip': 'ZIP',
		'Country': 'COUNTRY',
		'Dear': 'DEAR',
		'Source': 'SOURCE',
		'Key1': 'KEY1',
		'Key2': 'KEY2',
		'Key3': 'KEY3',
		'Key4': 'KEY4',
		'Key5': 'KEY5',
		'Status': 'STATUS',
		'Notes': 'NOTES',
		'Owner': 'OWNER',
		'Createby': 'CREATEBY',
		'Lastuser': 'LASTUSER',
		'Lastdate': 'LASTDATE',
		'Lasttime': 'LASTTIME',
		'Address3': 1,
		'LocationComment': 'Location Comment',
		'GRCNotes': 'GRC Notes',
		'ARISENotes': 'ARISE Notes',
		'Recid': 'RECID',
		'DateEntered': 'Date Entered',
		'TimeEntered': 'Time Entered',
		'Deleteflag': 'DELETEFLAG',
		'Sqfootage': 1,
		'Client1': 1,
		'Client2': 1,
		'Occupancy': 1,
		'CustomAccess': 1,
		'FilePrefix': 1,
		'Latitude': 1,
		'Longitude': 1,
		'ContactID': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.Contact1Collection = es.defineCollection('Contact1Collection', 'Contact1');

	//#region Prototype Level Information

	es.objects.Contact1Collection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'Contact1Collection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'Contact1Collection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));