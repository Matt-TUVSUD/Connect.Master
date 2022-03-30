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

	es.objects.ViewCCLocationInspectionBM = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.PracticeCode = ko.observable();
		this.NextInspYr = ko.observable();
		this.InspRemaining = ko.observable();
		this.InspectionStatus = ko.observable();
		this.LocationStatus = ko.observable();
		this.ContractYr = ko.observable();
		this.Frequency = ko.observable();
		this.ClientTargetMo = ko.observable();
		this.DateCompleted = ko.observable();
		this.DateMailedToClient = ko.observable();
		this.CancelDate = ko.observable();
		this.EffectiveDate = ko.observable();
		this.CurrencyCode = ko.observable();
		this.Engineer = ko.observable();
		this.PDBuilding = ko.observable();
		this.PDEquipment = ko.observable();
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
		this.EngTargetMo = ko.observable();
		this.InspectionType = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.ViewCCLocationInspectionBM.prototype.esTypeDefs = {};

	es.objects.ViewCCLocationInspectionBM.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationInspectionBM_Save', response: 'entity' }
	};

	es.objects.ViewCCLocationInspectionBM.prototype.esColumnMap = {
		'FileNo': 1,
		'PracticeCode': 1,
		'NextInspYr': 1,
		'InspRemaining': 1,
		'InspectionStatus': 1,
		'LocationStatus': 1,
		'ContractYr': 1,
		'Frequency': 1,
		'ClientTargetMo': 1,
		'DateCompleted': 1,
		'DateMailedToClient': 1,
		'CancelDate': 1,
		'EffectiveDate': 1,
		'CurrencyCode': 1,
		'Engineer': 1,
		'PDBuilding': 'PD_Building',
		'PDEquipment': 'PD_Equipment',
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
		'EngTargetMo': 1,
		'InspectionType': 'Inspection Type'
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.ViewCCLocationInspectionBMCollection = es.defineCollection('ViewCCLocationInspectionBMCollection', 'ViewCCLocationInspectionBM');

	//#region Prototype Level Information

	es.objects.ViewCCLocationInspectionBMCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'ViewCCLocationInspectionBMCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'ViewCCLocationInspectionBMCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));