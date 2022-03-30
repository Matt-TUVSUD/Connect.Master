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

	es.objects.ViewCCBMRecommendationCounts = es.defineEntity(function () {

		// core columns
		this.ResponsesCompleted = ko.observable();
		this.ResponsesTotal = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCBMRecommendationCounts.prototype.esTypeDefs = {};

	es.objects.ViewCCBMRecommendationCounts.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCBMRecommendationCounts_Save', response: 'entity' }
	};

	es.objects.ViewCCBMRecommendationCounts.prototype.esColumnMap = {
		'ResponsesCompleted': 1,
		'ResponsesTotal': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCBMRecommendationCountsCollection = es.defineCollection('ViewCCBMRecommendationCountsCollection', 'ViewCCBMRecommendationCounts');

	//#region Prototype Level Information

	es.objects.ViewCCBMRecommendationCountsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCBMRecommendationCountsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCBMRecommendationCountsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));