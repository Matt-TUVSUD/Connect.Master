Imports GRC.Connect.Libraries.ImportLib.ImportEnum

Public Class FireImportInfo
    Inherits ImportTableInfo

    Friend Sub New(ByVal pImportSheet As ImportEnum.ImportSheet, ByVal pImportTableEnum As ImportEnum.ImportTable, ByVal pExcelRange As String(), ByVal pMeta As FireMeta, ByVal pMapCollection As MapCollection)

        Select Case pImportSheet
            Case ImportSheet.CopeData
                _SheetName = "Cope Data"
                _Description = "Cope Data"
                _ExcelErrorAddresses = pMeta.FireCopeErrorAddresses
                _ImportSheetEnum = ImportSheet.CopeData
            Case ImportSheet.RecTracking
                _SheetName = "Rec Tracking"
                _Description = "Recommendation Tracking"
                _ExcelErrorAddresses = pMeta.FireRecommendationErrorAddresses
                _ImportSheetEnum = ImportSheet.RecTracking
            Case ImportSheet.RatingForm
                _SheetName = "Rating Form"
                _Description = "Rating Form"
                _ExcelErrorAddresses = pMeta.FireRatingErrorAddresses
                _ImportSheetEnum = ImportSheet.RatingForm
            Case ImportSheet.RetailData
                _SheetName = "Retail Data"
                _Description = "Retail Data"
                _ExcelErrorAddresses = pMeta.FireRetailErrorAddresses
                _ImportSheetEnum = ImportSheet.RetailData
            Case ImportSheet.NatHazData
                _SheetName = "Nat Haz Data"
                _Description = "Natural Hazards Data"
                _ExcelErrorAddresses = pMeta.FireNatHazDataErrorAddresses
                _ImportSheetEnum = ImportSheet.NatHazData
            Case ImportSheet.NatHazModelingData
                _SheetName = "Nat Haz Model Data"
                _Description = "Natural Hazards Modeling Data"
                _ExcelErrorAddresses = New List(Of CellAddress)
                _ImportSheetEnum = ImportSheet.NatHazModelingData
        End Select

        _Practice = UtilPractice.PracticeEnum.Fire
        _MetaPractice = UtilMetaPractice.Practices.Fire
        _Range = pExcelRange
        _ImportTableEnum = pImportTableEnum
        _Meta = pMeta
        _ImportType = ImportEnum.ImportType.FDS
        _MapCollection = pMapCollection

    End Sub

    Friend Sub New(ByVal pImportSheetEnum As ImportEnum.ImportSheet, pImportSheet As String, ByVal pImportTableEnum As ImportEnum.ImportTable, ByVal pExcelRange As String(), ByVal pMeta As FireMeta, ByVal pMapCollection As MapCollection)
        Me.New(pImportSheetEnum, pImportTableEnum, pExcelRange, pMeta, pMapCollection)
        _SheetName = pImportSheet
    End Sub

End Class


