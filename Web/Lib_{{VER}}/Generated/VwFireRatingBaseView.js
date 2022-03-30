//===============================================================================
//                    EntitySpaces Studio by EntitySpaces, LLC
//             Persistence Layer and Business Objects for Microsoft .NET
//             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
//                          http://www.entityspaces.net
//===============================================================================
// EntitySpaces Version : 2012.1.0930.0
// EntitySpaces Driver  : SQL
// Date Generated       : 5/30/2019 10:11:00 AM
//===============================================================================

(function (es) { //myNS = "myNameSpace" ... for example purposes

	if (typeof (es) === undefined) {
		throw "Please Load EntitySpaces.Core First";
	}

	es.objects.VwFireRatingBaseView = es.defineEntity(function () {

		// core columns
		this.RowNo = ko.observable();
		this.Client = ko.observable();
		this.ClientLocNo = ko.observable();
		this.Division = ko.observable();
		this.Facility = ko.observable();
		this.Address1 = ko.observable();
		this.City = ko.observable();
		this.StProv = ko.observable();
		this.Country = ko.observable();
		this.GripssTIVUS = ko.observable();
		this.FilePrefix = ko.observable();
		this.Zip = ko.observable();
		this.CustomAccess = ko.observable();
		this.Longitude = ko.observable();
		this.Latitude = ko.observable();
		this.StProvName = ko.observable();
		this.Client1 = ko.observable();
		this.RatingID = ko.observable();
		this.FileNo = ko.observable();
		this.Grade = ko.observable();
		this.InspectionDate = ko.observable();
		this.ConstructionRating = ko.observable();
		this.OccupancyRating = ko.observable();
		this.FloodRating = ko.observable();
		this.EarthquakeRating = ko.observable();
		this.WindstormRating = ko.observable();
		this.OtherRating = ko.observable();
		this.PhysicalProtectionRating = ko.observable();
		this.HumanElementRating = ko.observable();
		this.NaturalHazardsProtectionRating = ko.observable();
		this.BusinessContinuityRating = ko.observable();
		this.Apl = ko.observable();
		this.APLFactor = ko.observable();
		this.OverallPlantRatingRating = ko.observable();
		this.PassiveScore = ko.observable();
		this.ActiveScore = ko.observable();
		this.TotalScore = ko.observable();
		this.OtherWeight = ko.observable();
		this.ConstructionWeight = ko.observable();
		this.OccupancyWeight = ko.observable();
		this.PhysicalProtectionWeight = ko.observable();
		this.HumanElementWeight = ko.observable();
		this.NaturalHazardsProtectionWeight = ko.observable();
		this.BusinessContinuityWeight = ko.observable();
		this.FireProtectionAllRecsCompleteRating = ko.observable();
		this.HumanElementAllRecsCompleteRating = ko.observable();
		this.NatHazProtAllRecsCompleteRating = ko.observable();
		this.BCPAllRecsCompletRating = ko.observable();
		this.ActiveScoreWithRecsComplete = ko.observable();
		this.APLWithAllRecsComplete = ko.observable();
		this.FloodWeight = ko.observable();
		this.EarthquakeWeight = ko.observable();
		this.WindstormWeight = ko.observable();
		this.OverallScoreWithRecsComplete = ko.observable();
		this.AchievableScore = ko.observable();
		this.OverallScoreWithRecsCompleteRating = ko.observable();
		this.MaxPossibleScore = ko.observable();
		this.APLFactorWithAllRecsComplete = ko.observable();
		this.FloodDescription = ko.observable();
		this.EarthquakeDescription = ko.observable();
		this.WindstormDescription = ko.observable();
		this.ConstructionDescription = ko.observable();
		this.OccupancyDescription = ko.observable();
		this.OtherDescription = ko.observable();
		this.FireDescription = ko.observable();
		this.HumanDescription = ko.observable();
		this.NaturalDescription = ko.observable();
		this.BusinessDescription = ko.observable();
		this.FireRecDescription = ko.observable();
		this.HumanRecDescription = ko.observable();
		this.NaturalRecDescription = ko.observable();
		this.BusinessRecDescription = ko.observable();
		this.ExchangeRate = ko.observable();
		this.AdminMemo = ko.observable();
		this.MaxPossibleRating = ko.observable();
		this.IsLatestRating = ko.observable();
		this.TotalScoreHexColor = ko.observable();
		this.TotalScoreRating = ko.observable();
		this.AchievableScoreHexColor = ko.observable();
		this.AchievableScoreRating = ko.observable();
		this.AchievableScorePercent = ko.observable();
		this.IndustryGroup = ko.observable();
		this.InspPeriodPosition = ko.observable();
		this.InspPeriodDesc = ko.observable();
		this.AchievableScorePercentString = ko.observable();
		this.TIVWeightedPotentialScore = ko.observable();


		// extended columns
		this.esExtendedData = undefined;

	});

	//#region Prototype Level Information

	es.objects.VwFireRatingBaseView.prototype.esTypeDefs = {};

	es.objects.VwFireRatingBaseView.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'VwFireRatingBaseView_Save', response: 'entity' }
	};

	es.objects.VwFireRatingBaseView.prototype.esColumnMap = {
		'RowNo': 1,
		'Client': 1,
		'ClientLocNo': 1,
		'Division': 1,
		'Facility': 1,
		'Address1': 1,
		'City': 1,
		'StProv': 1,
		'Country': 1,
		'GripssTIVUS': 1,
		'FilePrefix': 1,
		'Zip': 1,
		'CustomAccess': 1,
		'Longitude': 1,
		'Latitude': 1,
		'StProvName': 1,
		'Client1': 1,
		'RatingID': 1,
		'FileNo': 1,
		'Grade': 1,
		'InspectionDate': 1,
		'ConstructionRating': 1,
		'OccupancyRating': 1,
		'FloodRating': 1,
		'EarthquakeRating': 1,
		'WindstormRating': 1,
		'OtherRating': 1,
		'PhysicalProtectionRating': 1,
		'HumanElementRating': 1,
		'NaturalHazardsProtectionRating': 1,
		'BusinessContinuityRating': 1,
		'Apl': 'APL',
		'APLFactor': 1,
		'OverallPlantRatingRating': 1,
		'PassiveScore': 1,
		'ActiveScore': 1,
		'TotalScore': 1,
		'OtherWeight': 1,
		'ConstructionWeight': 1,
		'OccupancyWeight': 1,
		'PhysicalProtectionWeight': 1,
		'HumanElementWeight': 1,
		'NaturalHazardsProtectionWeight': 1,
		'BusinessContinuityWeight': 1,
		'FireProtectionAllRecsCompleteRating': 1,
		'HumanElementAllRecsCompleteRating': 1,
		'NatHazProtAllRecsCompleteRating': 1,
		'BCPAllRecsCompletRating': 1,
		'ActiveScoreWithRecsComplete': 1,
		'APLWithAllRecsComplete': 1,
		'FloodWeight': 1,
		'EarthquakeWeight': 1,
		'WindstormWeight': 1,
		'OverallScoreWithRecsComplete': 1,
		'AchievableScore': 1,
		'OverallScoreWithRecsCompleteRating': 1,
		'MaxPossibleScore': 1,
		'APLFactorWithAllRecsComplete': 1,
		'FloodDescription': 1,
		'EarthquakeDescription': 1,
		'WindstormDescription': 1,
		'ConstructionDescription': 1,
		'OccupancyDescription': 1,
		'OtherDescription': 1,
		'FireDescription': 1,
		'HumanDescription': 1,
		'NaturalDescription': 1,
		'BusinessDescription': 1,
		'FireRecDescription': 1,
		'HumanRecDescription': 1,
		'NaturalRecDescription': 1,
		'BusinessRecDescription': 1,
		'ExchangeRate': 1,
		'AdminMemo': 1,
		'MaxPossibleRating': 1,
		'IsLatestRating': 1,
		'TotalScoreHexColor': 1,
		'TotalScoreRating': 1,
		'AchievableScoreHexColor': 1,
		'AchievableScoreRating': 1,
		'AchievableScorePercent': 1,
		'IndustryGroup': 1,
		'InspPeriodPosition': 1,
		'InspPeriodDesc': 1,
		'AchievableScorePercentString': 1,
		'TIVWeightedPotentialScore': 1
	};

	//#endregion

}(window.es, window.myNS));

(function (es) {

	es.objects.VwFireRatingBaseViewCollection = es.defineCollection('VwFireRatingBaseViewCollection', 'VwFireRatingBaseView');

	//#region Prototype Level Information

	es.objects.VwFireRatingBaseViewCollection.prototype.esRoutes = {
		commit: { method: 'PUT', url: 'VwFireRatingBaseViewCollection_Save', response: 'collection' },
		loadAll: { method: 'GET', url: 'VwFireRatingBaseViewCollection_LoadAll', response: 'collection' }
	};

	//#endregion

}(window.es, window.myNS));