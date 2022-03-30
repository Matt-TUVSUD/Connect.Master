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

	es.objects.NavLink = es.defineEntity(function () {

		// core columns
		this.NavControlId = ko.observable();
		this.NavPracticeID = ko.observable();
		this.NavLevelId = ko.observable();
		this.NavParentLinkId = ko.observable();
		this.NavLinkId = ko.observable();
		this.NavText = ko.observable();
		this.NavUrl = ko.observable();
		this.NavOrder = ko.observable();
		this.NavToolTip = ko.observable();
		this.NavVisible = ko.observable();
		this.NavEnabled = ko.observable();
		this.NavSpcFeature = ko.observable();
		this.NavIsPracticeTopLink = ko.observable();
		this.NavDefaultExpanded = ko.observable();
		this.NavSiteMapKeyWord = ko.observable();
		this.NavAllReportsKeyword = ko.observable();
		this.NavAllDataKeyword = ko.observable();
		this.NavTarget = ko.observable();
		this.NavType = ko.observable();
		this.NavComment = ko.observable();
		this.NavConstant = ko.observable();
		this.NavRptCode = ko.observable();
		this.NavGridId = ko.observable();
		this.NavChartId = ko.observable();
		this.NavExtractId = ko.observable();
		this.NavBypassFilter = ko.observable();
		this.NavStatusToolTip = ko.observable();
		this.TimeStamp = undefined;

		// Primary Key(s)
		this.esPrimaryKeys = function() {
			return this.NavLinkId();
		}

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
		this.UpToTblMetaGridByNavGridId = es.defineLazyLoader(this, 'UpToTblMetaGridByNavGridId');
	
	});

	//#region Prototype Level Information

	es.objects.NavLink.prototype.esTypeDefs = {
		UpToTblMetaGridByNavGridId: "TblMetaGrid"
	};

	es.objects.NavLink.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'NavLink_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'NavLink_LoadByPrimaryKey', response: 'entity' },
		UpToTblMetaGridByNavGridId: { method: 'GET', url: 'NavLink_UpToTblMetaGridByNavGridId', response: 'entity'}
	};

	es.objects.NavLink.prototype.esColumnMap = {
		'NavControlId': 1,
		'NavPracticeID': 1,
		'NavLevelId': 1,
		'NavParentLinkId': 1,
		'NavLinkId': 1,
		'NavText': 1,
		'NavUrl': 1,
		'NavOrder': 1,
		'NavToolTip': 1,
		'NavVisible': 1,
		'NavEnabled': 1,
		'NavSpcFeature': 1,
		'NavIsPracticeTopLink': 1,
		'NavDefaultExpanded': 1,
		'NavSiteMapKeyWord': 1,
		'NavAllReportsKeyword': 1,
		'NavAllDataKeyword': 1,
		'NavTarget': 1,
		'NavType': 1,
		'NavComment': 1,
		'NavConstant': 1,
		'NavRptCode': 1,
		'NavGridId': 1,
		'NavChartId': 1,
		'NavExtractId': 1,
		'NavBypassFilter': 1,
		'NavStatusToolTip': 1,
		'TimeStamp': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.NavLinkCollection = es.defineCollection('NavLinkCollection', 'NavLink');

	//#region Prototype Level Information

	es.objects.NavLinkCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'NavLinkCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'NavLinkCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));