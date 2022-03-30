Imports Telerik.Reporting.Processing
Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilReport
    Partial Class TelerikReport
        Public Class ItemFunction

            Public Shared Function GetLossEstimateBeforeRangeValue(lossEstimateRange As String, clientCurrencyId As Integer, currencyId As Integer, rptItem As Object) As String
                Dim zReturn As String = TblMetaLossEstimate.Find(GetIBatchSetReportProperties(rptItem).LossEstimates, lossEstimateRange, clientCurrencyId, currencyId, TblMetaLossEstimateType.Types.Before).colFldRangeDisplay
                Return zReturn

            End Function

            Public Shared Function GetLossEstimateAfterRangeValue(lossEstimateRange As String, clientCurrencyId As Integer, currencyId As Integer, rptItem As Object) As String
                Dim zReturn As String = TblMetaLossEstimate.Find(GetIBatchSetReportProperties(rptItem).LossEstimates, lossEstimateRange, clientCurrencyId, currencyId, TblMetaLossEstimateType.Types.After).colFldRangeDisplay
                Return zReturn

            End Function

            Public Shared Function GetLossEstimateCostRangeValue(lossEstimateRange As String, clientCurrencyId As Integer, currencyId As Integer, rptItem As Object) As String
                Dim zReturn As String = TblMetaLossEstimate.Find(GetIBatchSetReportProperties(rptItem).LossEstimates, lossEstimateRange, clientCurrencyId, currencyId, TblMetaLossEstimateType.Types.Cost).colFldRangeDisplay
                Return zReturn

            End Function


            Public Shared Function FormatTotalFloorArea(value As Object, rptItem As Object) As String
                Dim zRptProps As IBatchSetReportProperties = GetIBatchSetReportProperties(rptItem)
                Dim zUnit As String = UtilReport.GetMeasurementAbbreviation(TblMetaUnitMeasurement.Measurements.SquareFeet, zRptProps)
                Dim zValue As String = FormatNumber(value, 0)
                Return zValue & " " & zUnit

            End Function

            Public Shared Function FormatBuildingHeight(value As Object, rptItem As Object) As String
                Dim zRptProps As IBatchSetReportProperties = GetIBatchSetReportProperties(rptItem)
                Dim zUnit As String = UtilReport.GetMeasurementAbbreviation(TblMetaUnitMeasurement.Measurements.Feet, zRptProps)
                Dim zValue As String = FormatNumber(value, 0)

                Return zValue & " " & zUnit

            End Function

            Public Shared Function FormatMaxStageHeight(value As Object, rptItem As Object) As String
                Return FormatBuildingHeight(value, rptItem)
            End Function

            Public Shared Function FormatWindSpeed(value As Object, rptItem As Object) As String
                Dim zRptProps As IBatchSetReportProperties = GetIBatchSetReportProperties(rptItem)
                Dim zUnit As String = UtilReport.GetMeasurementAbbreviation(TblMetaUnitMeasurement.Measurements.MilesPerHour, zRptProps)
                Dim zValue As String = FormatNumber(value, 0)
                Return zValue & zUnit

            End Function

            'Public Shared Function GetColorByRiskRating(value As Object, rptItem As Object, practice As Integer) As System.Drawing.Color
            '    Dim zRptProps As IBatchSetReportProperties = GetIBatchSetReportProperties(rptItem)
            '    Dim zKeyRange As rowTblMetaRatingKeyRange = Nothing

            '    If zRptProps.Practice.Practice = TblMetaPractice.Practices.BM Then

            '        zKeyRange = zRptProps.BMRatingRange.Find(Function(x) x.colFldRating.ToLower = value.ToString.ToLower)
            '        'For Each zItem As rowTblMetaRatingKeyRange In zRptProps.BMRatingRange
            '        '    If zItem.colFldRating.ToLower.Contains(value.ToString.ToLower) Then
            '        '        Return zItem.ToColor
            '        '    End If
            '        'Next
            '    End If

            '    If zRptProps.Practice.Practice = TblMetaPractice.Practices.Fire Then
            '        zKeyRange = zRptProps.FireRatingRange.Find(Function(x) x.colFldRating.ToLower = value.ToString.ToLower)
            '        'For Each zItem As rowTblMetaRatingKeyRange In zRptProps.FireRatingRange
            '        '    If zItem.colFldRating.ToLower.(value.ToString.ToLower) Then
            '        '        Return zItem.ToColor
            '        '    End If
            '        'Next
            '    End If

            '    If Not IsNothing(zKeyRange) Then Return zKeyRange.ToColor()

            'End Function

            Public Shared Function GetRiskRating(value As Object, rptItem As Object, practice As Integer) As String
                Dim zRptProps As IBatchSetReportProperties = GetIBatchSetReportProperties(rptItem)

                If zRptProps.Practice.Practice = TblMetaPractice.Practices.BM Then
                    For Each zItem As rowVwMetaRatingKeyRange In zRptProps.BMRatingRange
                        If IsBetween(value, zItem.colFldScoreLow, zItem.colFldScoreHigh) Then
                            Return zItem.colFldRating
                        End If
                    Next
                End If

                If zRptProps.Practice.Practice = TblMetaPractice.Practices.Fire Then
                    For Each zItem As rowVwMetaRatingKeyRange In zRptProps.FireRatingRange
                        If IsBetween(value, zItem.colFldScoreLow, zItem.colFldScoreHigh) Then
                            Return zItem.colFldRating
                        End If
                    Next
                End If

                Return "No Rating"

            End Function

            Private Shared Function GetIBatchSetReportProperties(rptItem As ReportItem) As IBatchSetReportProperties
                Dim zIUtilReport As IUtilReport = rptItem.ItemDefinition.Report
                Return zIUtilReport.rptProperties
            End Function

            Private Shared Function IsBetween(value As Integer, lowerValue As Integer, higherValue As Integer) As Boolean
                If value >= lowerValue And value <= higherValue Then
                    Return True
                Else
                    Return False
                End If
            End Function

        End Class

    End Class

End Class
