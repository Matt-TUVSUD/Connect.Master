//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 6/4/2013 1:01:05 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCTranslationMgmtIntendedAction = es.defineEntity(function () {

		// core columns
		this.Id = ko.observable();
		this.FilePrefix = ko.observable();
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

	es.objects.ViewCCTranslationMgmtIntendedAction.prototype.esTypeDefs = {};

	es.objects.ViewCCTranslationMgmtIntendedAction.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationMgmtIntendedAction_Save', response: 'entity' }
	};

	es.objects.ViewCCTranslationMgmtIntendedAction.prototype.esColumnMap = {
		'Id': 1,
		'FilePrefix': 1,
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

	es.objects.ViewCCTranslationMgmtIntendedActionCollection = es.defineCollection('ViewCCTranslationMgmtIntendedActionCollection', 'ViewCCTranslationMgmtIntendedAction');

	//#region Prototype Level Information

	es.objects.ViewCCTranslationMgmtIntendedActionCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCTranslationMgmtIntendedActionCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCTranslationMgmtIntendedActionCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));