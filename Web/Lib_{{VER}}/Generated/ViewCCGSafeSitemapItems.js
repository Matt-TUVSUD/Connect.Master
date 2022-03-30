//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 9/21/2015 1:41:56 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCGSafeSitemapItems = es.defineEntity(function () {

		// core columns
		this.GSafeId = ko.observable();
		this.NavSiteMapKeyWord = ko.observable();
		this.NavAllReportsKeyword = ko.observable();
		this.NavAllDataKeyword = ko.observable();
		this.NavLinkId = ko.observable();
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


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCGSafeSitemapItems.prototype.esTypeDefs = {};

	es.objects.ViewCCGSafeSitemapItems.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCGSafeSitemapItems_Save', response: 'entity' }
	};

	es.objects.ViewCCGSafeSitemapItems.prototype.esColumnMap = {
		'GSafeId': 1,
		'NavSiteMapKeyWord': 1,
		'NavAllReportsKeyword': 1,
		'NavAllDataKeyword': 1,
		'NavLinkId': 1,
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

	es.objects.ViewCCGSafeSitemapItemsCollection = es.defineCollection('ViewCCGSafeSitemapItemsCollection', 'ViewCCGSafeSitemapItems');

	//#region Prototype Level Information

	es.objects.ViewCCGSafeSitemapItemsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCGSafeSitemapItemsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCGSafeSitemapItemsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));