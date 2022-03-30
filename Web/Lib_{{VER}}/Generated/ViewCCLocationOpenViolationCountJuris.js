//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 12/19/2012 2:22:48 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCLocationOpenViolationCountJuris = es.defineEntity(function () {

		// core columns
		this.Fileno = ko.observable();
		this.CountOpen = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationOpenViolationCountJuris.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationOpenViolationCountJuris.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationOpenViolationCountJuris_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationOpenViolationCountJuris.prototype.esColumnMap = {
		'Fileno': 'fileno',
		'CountOpen': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationOpenViolationCountJurisCollection = es.defineCollection('ViewCCLocationOpenViolationCountJurisCollection', 'ViewCCLocationOpenViolationCountJuris');

	//#region Prototype Level Information

	es.objects.ViewCCLocationOpenViolationCountJurisCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationOpenViolationCountJurisCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationOpenViolationCountJurisCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));