Public Class AesBmMeta
    Inherits BmMeta

    Public Sub New(pImportUtil As ImportUtility)
        MyBase.New(pImportUtil)
    End Sub


    Public Overrides ReadOnly Property BmElectricalTransformerImportInfo As BmImportInfo
        Get
            Return New BmImportInfo(ImportEnum.ImportSheet.FacilityData, ImportEnum.ImportTable.BmElectricalTransformers, {"T31:AC37"}, Me, BmElectricalTransformersMapCollection)
        End Get
    End Property

    Public Overrides ReadOnly Property BmElectricalTransformersMapCollection As MapCollection
        Get
            Dim zMapCollection = MyBase.BmElectricalTransformersMapCollection
            zMapCollection.Add(New Map("Solution", "Solution"))
            zMapCollection.Add(New Map("Status", "Status"))
            Return zMapCollection
        End Get
    End Property

End Class
