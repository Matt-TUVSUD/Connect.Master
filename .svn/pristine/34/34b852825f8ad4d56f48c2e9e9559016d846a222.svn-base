//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 2/18/2013 9:57:02 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCIRRecommendationCounts = es.defineEntity(function () {

		// core columns
		this.ResponsesCompleted = ko.observable();
		this.ResponsesTotal = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCIRRecommendationCounts.prototype.esTypeDefs = {};

	es.objects.ViewCCIRRecommendationCounts.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCIRRecommendationCounts_Save', response: 'entity' }
	};

	es.objects.ViewCCIRRecommendationCounts.prototype.esColumnMap = {
		'ResponsesCompleted': 1,
		'ResponsesTotal': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCIRRecommendationCountsCollection = es.defineCollection('ViewCCIRRecommendationCountsCollection', 'ViewCCIRRecommendationCounts');

	//#region Prototype Level Information

	es.objects.ViewCCIRRecommendationCountsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCIRRecommendationCountsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCIRRecommendationCountsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));