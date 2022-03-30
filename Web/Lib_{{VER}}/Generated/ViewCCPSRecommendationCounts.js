//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 5/1/2018 10:49:35 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCPSRecommendationCounts = es.defineEntity(function () {

		// core columns
		this.ResponsesCompleted = ko.observable();
		this.ResponsesTotal = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCPSRecommendationCounts.prototype.esTypeDefs = {};

	es.objects.ViewCCPSRecommendationCounts.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPSRecommendationCounts_Save', response: 'entity' }
	};

	es.objects.ViewCCPSRecommendationCounts.prototype.esColumnMap = {
		'ResponsesCompleted': 1,
		'ResponsesTotal': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCPSRecommendationCountsCollection = es.defineCollection('ViewCCPSRecommendationCountsCollection', 'ViewCCPSRecommendationCounts');

	//#region Prototype Level Information

	es.objects.ViewCCPSRecommendationCountsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCPSRecommendationCountsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCPSRecommendationCountsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));