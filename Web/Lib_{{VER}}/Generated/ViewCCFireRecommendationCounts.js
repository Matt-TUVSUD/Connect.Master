//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 2/7/2013 5:09:58 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCFireRecommendationCounts = es.defineEntity(function () {

		// core columns
		this.ResponsesCompleted = ko.observable();
		this.ResponsesTotal = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCFireRecommendationCounts.prototype.esTypeDefs = {};

	es.objects.ViewCCFireRecommendationCounts.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCFireRecommendationCounts_Save', response: 'entity' }
	};

	es.objects.ViewCCFireRecommendationCounts.prototype.esColumnMap = {
		'ResponsesCompleted': 1,
		'ResponsesTotal': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCFireRecommendationCountsCollection = es.defineCollection('ViewCCFireRecommendationCountsCollection', 'ViewCCFireRecommendationCounts');

	//#region Prototype Level Information

	es.objects.ViewCCFireRecommendationCountsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCFireRecommendationCountsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCFireRecommendationCountsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));