//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 3/1/2013 2:51:53 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCTranslationSecondaryRec = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.Hazard = ko.observable();
		this.PrimaryType = ko.observable();
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

	es.objects.ViewCCTranslationSecondaryRec.prototype.esTypeDefs = {};

	es.objects.ViewCCTranslationSecondaryRec.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationSecondaryRec_Save', response: 'entity' }
	};

	es.objects.ViewCCTranslationSecondaryRec.prototype.esColumnMap = {
		'Id': 1,
		'Hazard': 1,
		'PrimaryType': 1,
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

	es.objects.ViewCCTranslationSecondaryRecCollection = es.defineCollection('ViewCCTranslationSecondaryRecCollection', 'ViewCCTranslationSecondaryRec');

	//#region Prototype Level Information

	es.objects.ViewCCTranslationSecondaryRecCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationSecondaryRecCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCTranslationSecondaryRecCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));