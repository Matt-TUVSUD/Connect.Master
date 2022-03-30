Public Class CalpineBmMeta
    Inherits BmMeta

    Public Sub New(pImportUtil As ImportUtility)
        MyBase.New(pImportUtil)
    End Sub

    Public Overrides ReadOnly Property BmRecTrackingImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.RecTracking, ImportEnum.ImportTable.BmRecommendation, {"O8:AG37", "BO8:BO37"}, Me, BmRecommendationMapCollection)
        End Get
    End Property

    Public Overrides ReadOnly Property BmRecommendationMapCollection As MapCollection
        Get
            Dim zMapCollection As MapCollection = MyBase.BmRecommendationMapCollection
            zMapCollection.Add(New Map("ThirdLevelRespComment", "Recommendation Responsibility"))
            Return zMapCollection
        End Get
    End Property
End Class
