Imports GRC.Connect.Libraries.ImportLib.ImportEnum

Public Class BmImportInfo
	Inherits ImportTableInfo

    Friend Sub New(ByVal pImportSheetEnum As ImportEnum.ImportSheet, ByVal pImportTableEnum As ImportEnum.ImportTable, ByVal pExcelRange As String(), ByVal pMeta As BmMeta, ByVal pMapCollection As MapCollection)

        Select Case pImportSheetEnum
            Case ImportSheet.FacilityData
                _SheetName = "Facility Data"
                _Description = "Facility Data"
                _ExcelErrorAddresses = Nothing
                _ImportSheetEnum = ImportSheet.FacilityData
            Case ImportSheet.RecTracking
                _SheetName = "Rec Tracking"
                _Description = "Recommendation Tracking"
                _ExcelErrorAddresses = Nothing
                _ImportSheetEnum = ImportSheet.RecTracking
            Case ImportSheet.RatingForm
                _SheetName = "Rating Form"
                _Description = "Rating Form"
                _ExcelErrorAddresses = Nothing
                _ImportSheetEnum = ImportSheet.RatingForm
        End Select

        _Practice = UtilPractice.PracticeEnum.BM
        _MetaPractice = UtilMetaPractice.Practices.BoilerAndMachinery
        _Range = pExcelRange
        _ImportTableEnum = pImportTableEnum
        _Meta = pMeta
        _ImportType = ImportEnum.ImportType.BDS
        _MapCollection = pMapCollection

    End Sub

    Friend Sub New(ByVal pImportSheetEnum As ImportEnum.ImportSheet, pImportSheet As String, ByVal pImportTableEnum As ImportEnum.ImportTable, ByVal pExcelRange As String(), ByVal pMeta As BmMeta, ByVal pMapCollection As MapCollection)
        Me.New(pImportSheetEnum, pImportTableEnum, pExcelRange, pMeta, pMapCollection)
        _SheetName = pImportSheet
    End Sub

End Class


