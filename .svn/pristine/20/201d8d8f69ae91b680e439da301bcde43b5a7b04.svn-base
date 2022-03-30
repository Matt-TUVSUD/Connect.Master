//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 2/27/2013 10:56:52 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCTranslationImpact = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.EnglishTranslation = ko.observable();
		this.GermanTranslation = ko.observable();
		this.SpanishTranslation = ko.observable();
		this.FrenchTranslation = ko.observable();
		this.ItalianTranslation = ko.observable();
		this.PortugueseTranslation = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCTranslationImpact.prototype.esTypeDefs = {};

	es.objects.ViewCCTranslationImpact.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationImpact_Save', response: 'entity' }
	};

	es.objects.ViewCCTranslationImpact.prototype.esColumnMap = {
		'Id': 1,
		'EnglishTranslation': 1,
		'GermanTranslation': 1,
		'SpanishTranslation': 1,
		'FrenchTranslation': 1,
		'ItalianTranslation': 1,
		'PortugueseTranslation': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCTranslationImpactCollection = es.defineCollection('ViewCCTranslationImpactCollection', 'ViewCCTranslationImpact');

	//#region Prototype Level Information

	es.objects.ViewCCTranslationImpactCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationImpactCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCTranslationImpactCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));