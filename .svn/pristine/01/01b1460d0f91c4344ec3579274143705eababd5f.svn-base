
Friend Class CalpineFireMeta
    Inherits FireMeta

    Public Sub New(pImportUtil As ImportUtility)
        MyBase.New(pImportUtil)
    End Sub

    Public Overrides ReadOnly Property FireRecTrackingImportInfo As FireImportInfo
        Get
            Return New FireImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.FireRecommendation, {"O8:AG37", "BO8:BO37"}, Me, FireRecommendationMapCollection)
        End Get
    End Property

    Public Overrides ReadOnly Property FireRecommendationMapCollection As MapCollection
        Get
            Dim zMapCollection As MapCollection = MyBase.FireRecommendationMapCollection
            zMapCollection.Add(New Map("ThirdLevelRespComment", "Recommendation Responsibility"))
            Return zMapCollection
        End Get
    End Property

    Friend Overrides ReadOnly Property FileNoCellAddress As CellAddress
        Get
            Return MyBase.FileNoCellAddress
        End Get
    End Property

    Friend Overrides ReadOnly Property SurveyDateCellAddress As CellAddress
        Get
            Return MyBase.SurveyDateCellAddress
        End Get
    End Property
End Class


