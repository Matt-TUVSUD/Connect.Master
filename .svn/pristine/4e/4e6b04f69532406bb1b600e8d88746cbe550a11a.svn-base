Imports GRC.Connect.Libraries.ImportLib.ImportEnum

Public Class PSImportInfo
    Inherits ImportTableInfo

    Friend Sub New(ByVal pImportSheet As ImportEnum.ImportSheet, ByVal pImportTableEnum As ImportEnum.ImportTable, ByVal pExcelRange As String(), ByVal pMeta As PSMeta)

        Select Case pImportSheet
            Case ImportSheet.RecTracking
                _SheetName = "Rec Tracking"
                _Description = "Recommendation Tracking"
                _ExcelErrorAddresses = pMeta.PSRecommendationErrorAddresses
                _ImportSheetEnum = ImportSheet.RecTracking
        End Select

        _Practice = UtilPractice.PracticeEnum.ProcessSafety
        _MetaPractice = UtilMetaPractice.Practices.ProcessSafety
        _Range = pExcelRange
        _ImportTableEnum = pImportTableEnum
        _Meta = pMeta
        _ImportType = ImportEnum.ImportType.PSDS


    End Sub

    Friend Sub New(ByVal pImportSheetEnum As ImportEnum.ImportSheet, pImportSheet As String, ByVal pImportTableEnum As ImportEnum.ImportTable, ByVal pExcelRange As String(), ByVal pMeta As PSMeta)
        Me.New(pImportSheetEnum, pImportTableEnum, pExcelRange, pMeta)
        _SheetName = pImportSheet
    End Sub

End Class


