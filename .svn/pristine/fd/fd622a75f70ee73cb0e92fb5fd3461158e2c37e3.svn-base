//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 9/21/2015 1:42:12 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.GSafeSitemapItems = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.NavLinkId = ko.observable();
		this.NavSiteMapKeyWord = ko.observable();
		this.NavAllReportsKeyword = ko.observable();
		this.NavAllDataKeyword = ko.observable();
		this.NavParentLinkId = ko.observable();
		this.NavText = ko.observable();
		this.NavUrl = ko.observable();
		this.NavOrder = ko.observable();
		this.NavToolTip = ko.observable();
		this.NavVisible = ko.observable();
		this.NavEnabled = ko.observable();
		this.NavTarget = ko.observable();
		this.NavType = ko.observable();
		this.NavConstant = ko.observable();
		this.NavRptCode = ko.observable();
		this.NavGridId = ko.observable();
		this.NavChartId = ko.observable();
		this.NavExtractId = ko.observable();
		this.NavBypassFilter = ko.observable();
		this.NavStatusToolTip = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.gSafeId = this.GSafeId();
			val.data.navLinkId = this.NavLinkId();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.GSafeSitemapItems.prototype.esTypeDefs = {
	};

	es.objects.GSafeSitemapItems.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeSitemapItems_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'GSafeSitemapItems_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.GSafeSitemapItems.prototype.esColumnMap = {
		'GSafeId': 1,
		'NavLinkId': 1,
		'NavSiteMapKeyWord': 1,
		'NavAllReportsKeyword': 1,
		'NavAllDataKeyword': 1,
		'NavParentLinkId': 1,
		'NavText': 1,
		'NavUrl': 1,
		'NavOrder': 1,
		'NavToolTip': 1,
		'NavVisible': 1,
		'NavEnabled': 1,
		'NavTarget': 1,
		'NavType': 1,
		'NavConstant': 1,
		'NavRptCode': 1,
		'NavGridId': 1,
		'NavChartId': 1,
		'NavExtractId': 1,
		'NavBypassFilter': 1,
		'NavStatusToolTip': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.GSafeSitemapItemsCollection = es.defineCollection('GSafeSitemapItemsCollection', 'GSafeSitemapItems');

	//#region Prototype Level Information

	es.objects.GSafeSitemapItemsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'GSafeSitemapItemsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'GSafeSitemapItemsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));