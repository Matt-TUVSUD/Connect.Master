Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class UtilBatchProcess
    Public Class Extract
        Public Function GenerateExtract(pSetItem As BatchSetItem) As Byte()

            Dim zMetaGrid As rowTblMetaGrid = pSetItem.MetaObject
            Dim zUtilExport As New UtilExport
            Dim zExportFormat As UtilExport.ExportFormat = Nothing

            Select Case pSetItem.Parent.Type
                Case BatchSet.BatchType.CSV
                    zExportFormat = UtilExport.ExportFormat.CSV
                Case BatchSet.BatchType.TAB
                    zExportFormat = UtilExport.ExportFormat.TXT
                Case BatchSet.BatchType.XLSX
                    zExportFormat = UtilExport.ExportFormat.Excel
            End Select
            UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Generating Extract: " & pSetItem.MetaObject.colfldGridName)
            Dim zByte As Byte() = UtilExport.ExportData(pSetItem.Parent.colFldId, zMetaGrid.colFldId, pSetItem.Parent.colFldLOFilterJSON, pSetItem.Parent.colFldLOCriteriaJSON, pSetItem.Parent.colFldLOSortJSON, pSetItem.Parent.SetParameters.Currency, pSetItem.Parent.colFldFilePrefix, zExportFormat, pSetItem.Parent.SetParameters)
            UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Extract Generated Successfully [" & zByte.Length & " bytes]")

            Return zByte

        End Function

    End Class
End Class
