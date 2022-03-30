//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 1/23/2017 12:40:20 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.ViewCCLocationInspectionDiversified = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.FilePrefix = ko.observable();
		this.PracticeCode = ko.observable();
		this.Engineer = ko.observable();
		this.LocationStatus = ko.observable();
		this.ContractYr = ko.observable();
		this.Frequency = ko.observable();
		this.NextInspYr = ko.observable();
		this.PDBuilding = ko.observable();
		this.TotalUSTIV = ko.observable();
		this.PDFinished = ko.observable();
		this.PDRawStock = ko.observable();
		this.PDBuildersRisk = ko.observable();
		this.PDMisc = ko.observable();
		this.PDTotal = ko.observable();
		this.BIGrossProfit = ko.observable();
		this.BIWageExtraExp = ko.observable();
		this.BIMisc = ko.observable();
		this.BIOther = ko.observable();
		this.BITotal = ko.observable();
		this.GrossProfitIndemnity = ko.observable();
		this.WagesExtraExpIndem = ko.observable();
		this.TotalUSPD = ko.observable();
		this.TotalUSBI = ko.observable();
		this.LocalTIV = ko.observable();
		this.Percentustot100 = ko.observable();
		this.InspDue = ko.observable();
		this.InspRemaining = ko.observable();
		this.EngTargetMo = ko.observable();
		this.InspPerFROM = ko.observable();
		this.InspPerTO = ko.observable();
		this.CancelDate = ko.observable();
		this.InspectionStatus = ko.observable();
		this.EffectiveDate = ko.observable();
		this.CurrencyCode = ko.observable();
		this.PDEquipment = ko.observable();
		this.DateCompleted = ko.observable();
		this.DateMailedToClient = ko.observable();
		this.ClientTargetMo = ko.observable();
		this.InspectionType = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationInspectionDiversified.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationInspectionDiversified.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationInspectionDiversified_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationInspectionDiversified.prototype.esColumnMap = {
		'FileNo': 1,
		'FilePrefix': 1,
		'PracticeCode': 1,
		'Engineer': 1,
		'LocationStatus': 1,
		'ContractYr': 1,
		'Frequency': 1,
		'NextInspYr': 1,
		'PDBuilding': 'PD_Building',
		'TotalUSTIV': 'TotalUS_TIV',
		'PDFinished': 'PD_Finished',
		'PDRawStock': 'PD_RawStock',
		'PDBuildersRisk': 'PD_BuildersRisk',
		'PDMisc': 'PD_Misc',
		'PDTotal': 'PD_Total',
		'BIGrossProfit': 'BI_GrossProfit',
		'BIWageExtraExp': 'BI_WageExtraExp',
		'BIMisc': 'BI_Misc',
		'BIOther': 'BI_Other',
		'BITotal': 'BI_Total',
		'GrossProfitIndemnity': 1,
		'WagesExtraExpIndem': 1,
		'TotalUSPD': 'TotalUS_PD',
		'TotalUSBI': 'TotalUS_BI',
		'LocalTIV': 1,
		'Percentustot100': 'PERCENTUSTOT100',
		'InspDue': 1,
		'InspRemaining': 1,
		'EngTargetMo': 1,
		'InspPerFROM': 1,
		'InspPerTO': 1,
		'CancelDate': 1,
		'InspectionStatus': 1,
		'EffectiveDate': 1,
		'CurrencyCode': 1,
		'PDEquipment': 'PD_Equipment',
		'DateCompleted': 1,
		'DateMailedToClient': 1,
		'ClientTargetMo': 1,
		'InspectionType': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationInspectionDiversifiedCollection = es.defineCollection('ViewCCLocationInspectionDiversifiedCollection', 'ViewCCLocationInspectionDiversified');

	//#region Prototype Level Information

	es.objects.ViewCCLocationInspectionDiversifiedCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationInspectionDiversifiedCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationInspectionDiversifiedCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));