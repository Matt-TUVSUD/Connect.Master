//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 11/18/2013 9:18:54 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCTranslationHazard = es.defineEntity(function () {

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

	es.objects.ViewCCTranslationHazard.prototype.esTypeDefs = {};

	es.objects.ViewCCTranslationHazard.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationHazard_Save', response: 'entity' }
	};

	es.objects.ViewCCTranslationHazard.prototype.esColumnMap = {
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

	es.objects.ViewCCTranslationHazardCollection = es.defineCollection('ViewCCTranslationHazardCollection', 'ViewCCTranslationHazard');

	//#region Prototype Level Information

	es.objects.ViewCCTranslationHazardCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationHazardCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCTranslationHazardCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));