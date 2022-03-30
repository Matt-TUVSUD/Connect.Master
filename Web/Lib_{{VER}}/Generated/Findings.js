//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 10/9/2013 4:11:17 PM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.Findings = es.defineEntity(function () {

		// core columns
		this.FileNo = ko.observable();
		this.RecMonth = ko.observable();
		this.RecNumber = ko.observable();
		this.RecYear = ko.observable();
		this.fldArc = ko.observable();
		this.Reportid = ko.observable();
		this.Findingno = ko.observable();
		this.Itemno = ko.observable();
		this.Severityrating = ko.observable();
		this.ProbableCause = ko.observable();
		this.ProbableCauseID = ko.observable();
		this.Recommendation = ko.observable();
		this.RecommendationID = ko.observable();
		this.SpecItem = ko.observable();
		this.SpecItemID = ko.observable();
		this.SpecItemDetail = ko.observable();
		this.SpecItemDetailID = ko.observable();
		this.FindEquip = ko.observable();
		this.fldLoad = ko.observable();
		this.PlantAreaAffected = ko.observable();
		this.FaultType = ko.observable();
		this.ProbableEquipmentDamageCost = ko.observable();
		this.LengthOfBusinessInterruption = ko.observable();
		this.CostOfBusinessInterruption = ko.observable();
		this.DetectedWith = ko.observable();
		this.Impact = ko.observable();
		this.Comments2 = ko.observable();
		this.MaxTemp = ko.observable();
		this.RefTemp = ko.observable();
		this.RiseTemp = ko.observable();
		this.PreventativeMaintenance = ko.observable();
		this.Engineering = ko.observable();
		this.Construction = ko.observable();
		this.Age = ko.observable();
		this.PoorCondition = ko.observable();
		this.NoTimeForMaintenance = ko.observable();
		this.PoorMaintenance = ko.observable();
		this.Heat = ko.observable();
		this.Water = ko.observable();
		this.Vibration = ko.observable();
		this.Contamination = ko.observable();
		this.NoRiskIQ = ko.observable();
		this.LastUpdated = ko.observable();
		this.RecStatus = ko.observable();
		this.StatusDate = ko.observable();
		this.ResponseFrom = ko.observable();
		this.ResponseDate = ko.observable();
		this.ResponseComment = ko.observable();
		this.ResponseStatus = ko.observable();
		this.FollowupDate = ko.observable();
		this.FollowupNumber = ko.observable();
		this.RedundancySpare = ko.observable();
		this.RecPrimary = ko.observable();
		this.RecSecondary = ko.observable();
		this.IntendedAction = ko.observable();
		this.PlantComment = ko.observable();
		this.DateOfOrigination = ko.observable();
		this.DateOfOriginalImport = ko.observable();
		this.DateOfLastImport = ko.observable();
		this.Id = ko.observable();
		this.fldObject = ko.observable();
		this.History = ko.observable();
		this.Comments = ko.observable();
		this.ExpectedCompletionDate = ko.observable();
		this.EzyUserID = ko.observable();
		this.SyncId = ko.observable();
		this.MgmtRespDate = ko.observable();
		this.MgmtRespFrom = ko.observable();
		this.MgmtRespAction = ko.observable();
		this.MgmtRespComment = ko.observable();
		this.CommentsID = ko.observable();
		this.Exported = ko.observable();
		this.Kfts = undefined;
		this.ReorderNumber = ko.observable();
		this.TimeData = ko.observable();
		this.ThirdLevelRespDate = ko.observable();
		this.ThirdLevelRespFrom = ko.observable();
		this.ThirdLevelRespAction = ko.observable();
		this.ThirdLevelRespComment = ko.observable();

		this.esPrimaryKeys = function() {
			var val = {data: {}};
			val.data.fileNo = this.FileNo();
			val.data.recMonth = this.RecMonth();
			val.data.recNumber = this.RecNumber();
			val.data.recYear = this.RecYear();
			return val;
		};

		// extended columns
		this.esExtendedData = undefined;

		// Hierarchical Properties
	
	});

	//#region Prototype Level Information

	es.objects.Findings.prototype.esTypeDefs = {
	};

	es.objects.Findings.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'Findings_Save', response: 'entity' },
		loadByPrimaryKey: { method: 'GET', url: 'Findings_LoadByPrimaryKey', response: 'entity' }
	};

	es.objects.Findings.prototype.esColumnMap = {
		'FileNo': 1,
		'RecMonth': 1,
		'RecNumber': 1,
		'RecYear': 1,
		'fldArc': 'Arc#',
		'Reportid': 'reportid',
		'Findingno': 'findingno',
		'Itemno': 'itemno',
		'Severityrating': 'severityrating',
		'ProbableCause': 1,
		'ProbableCauseID': 1,
		'Recommendation': 1,
		'RecommendationID': 1,
		'SpecItem': 1,
		'SpecItemID': 1,
		'SpecItemDetail': 1,
		'SpecItemDetailID': 1,
		'FindEquip': 1,
		'fldLoad': 'Load',
		'PlantAreaAffected': 1,
		'FaultType': 1,
		'ProbableEquipmentDamageCost': 1,
		'LengthOfBusinessInterruption': 'LenghtOfBusinessInterruption',
		'CostOfBusinessInterruption': 1,
		'DetectedWith': 1,
		'Impact': 1,
		'Comments2': 1,
		'MaxTemp': 1,
		'RefTemp': 1,
		'RiseTemp': 1,
		'PreventativeMaintenance': 'PrevenativeMaintenance',
		'Engineering': 1,
		'Construction': 1,
		'Age': 1,
		'PoorCondition': 1,
		'NoTimeForMaintenance': 1,
		'PoorMaintenance': 1,
		'Heat': 1,
		'Water': 1,
		'Vibration': 1,
		'Contamination': 1,
		'NoRiskIQ': 1,
		'LastUpdated': 1,
		'RecStatus': 1,
		'StatusDate': 1,
		'ResponseFrom': 1,
		'ResponseDate': 1,
		'ResponseComment': 1,
		'ResponseStatus': 1,
		'FollowupDate': 1,
		'FollowupNumber': 1,
		'RedundancySpare': 1,
		'RecPrimary': 1,
		'RecSecondary': 1,
		'IntendedAction': 1,
		'PlantComment': 1,
		'DateOfOrigination': 1,
		'DateOfOriginalImport': 1,
		'DateOfLastImport': 1,
		'Id': 'ID',
		'fldObject': 'Object',
		'History': 1,
		'Comments': 1,
		'ExpectedCompletionDate': 1,
		'EzyUserID': 1,
		'SyncId': 1,
		'MgmtRespDate': 1,
		'MgmtRespFrom': 1,
		'MgmtRespAction': 1,
		'MgmtRespComment': 1,
		'CommentsID': 1,
		'Exported': 1,
		'Kfts': 'KFTS',
		'ReorderNumber': 1,
		'TimeData': 1,
		'ThirdLevelRespDate': 1,
		'ThirdLevelRespAction': 1,
		'ThirdLevelRespFrom': 1,
		'ThirdLevelRespComment': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.FindingsCollection = es.defineCollection('FindingsCollection', 'Findings');

	//#region Prototype Level Information

	es.objects.FindingsCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'FindingsCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'FindingsCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));