Imports System.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilReport
    Public Class Color

        'THIS FUNCTION RETRIEVES THE APPROPRIATE RATING CATEGORY COLOR
        Public Shared Function GetColorByRating(rptProps As IBatchSetReportProperties, ByVal RatingCategory As TblMetaRatingCategory.Categories, Rating As Double) As System.Drawing.Color

            Dim zInt As Int32 = Convert.ToInt32(Rating)
            Dim zDefaultRatingItem As rowTblClientMetaRatingCategoryColor = rptProps.ClientRatingCategoryColors.Find(Function(x) x.colFldCategoryId = RatingCategory And x.colFldRatingValue = zInt And x.colFldFilePrefix = 0)
            Dim zClientRatingItem As rowTblClientMetaRatingCategoryColor = rptProps.ClientRatingCategoryColors.Find(Function(x) x.colFldCategoryId = RatingCategory And x.colFldRatingValue = zInt And x.colFldFilePrefix = rptProps.FilePrefix)
            Dim zColor As rowTblMetaColor = Nothing

            If IsNothing(zClientRatingItem) Then
                zClientRatingItem = zDefaultRatingItem
            End If

            zColor = rptProps.Colors.Find(Function(x) x.colFldId = zClientRatingItem.colFldColorId)
            Return zColor.ToColor()

        End Function

        Public Shared Function GetColorByRating(rptProps As IBatchSetReportProperties, ByVal Rating As Double) As System.Drawing.Color
            Dim list As List(Of rowTblMetaColor) = rptProps.Colors
            Dim zInt As Int32 = Convert.ToInt32(Rating)
            Select Case zInt
                Case 0 To 4
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
                Case 5 To 6
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Yellow).ToColor
                Case 7 To 10
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                Case Else
                    Return Drawing.Color.Transparent
            End Select
        End Function

        'Public Shared Function GetColorByRatingHE(rptProps As IBatchSetReportProperties, ByVal Rating As Double) As System.Drawing.Color
        '    Dim list As List(Of rowTblMetaColor) = rptProps.Colors
        '    Dim zInt As Int32 = Convert.ToInt32(Rating)
        '    Select Case zInt
        '        Case 0 To 4
        '            Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
        '        Case 5 To 6
        '            Return TblMetaColor.Find(list, TblMetaColor.Colors.Yellow).ToColor
        '        Case 7 To 10
        '            Return TblMetaColor.Find(list, TblMetaColor.Colors.Green).ToColor
        '        Case Else
        '            Return Drawing.Color.Transparent
        '    End Select
        'End Function

        Public Shared Function GetColorByCurrency(rptProps As IBatchSetReportProperties, ByVal currency As Object) As System.Drawing.Color
            Dim list As List(Of rowTblMetaColor) = rptProps.Colors
            Dim zInt As Int32 '= Convert.ToInt32(currency)
            If Not IsNothing(currency) AndAlso Not IsDBNull(currency) Then
                zInt = Convert.ToInt32(currency)
            Else
                zInt = -1
            End If
            Select Case zInt
                Case Is >= 100000
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
                Case 10001 To 99999
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Yellow).ToColor
                Case 0 To 10000
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                Case Else
                    Return Drawing.Color.Transparent
            End Select
        End Function

        Public Shared Function GetColorByText(rptProps As IBatchSetReportProperties, ByVal pText As String) As System.Drawing.Color
            Dim list As List(Of rowTblMetaColor) = rptProps.Colors
            Select Case LCase(pText)
                Case "inadequate", "severe", "poorer risk", "high", "****", "overdue", "none completed", "none"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
                Case "moderate", "tolerable", "typical risk", "***", "pending", "partially completed", "analysis needed"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Yellow).ToColor
                Case "adequate", "light", "better risk", "low", "not applicable", "*", "**", "1 day", "completed", "all completed", "evacuation only", "incipient", "structural"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                Case "2 days", "3 days", "4 days", "5 days", "6 days", "7 days"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Yellow).ToColor
                Case "yes", "n/a"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                Case "no"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
                Case "week", "month"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
                Case "not required"
                    Return Drawing.Color.Transparent
                Case Else
                    Return Drawing.Color.Transparent
            End Select
        End Function

        Public Shared Function GetColorByTextAndComment(rptProps As IBatchSetReportProperties, ByVal value As String, ByVal comment As Boolean) As System.Drawing.Color
            Dim list As List(Of rowTblMetaColor) = rptProps.Colors
            Select Case LCase(value).Trim
                Case "yes"
                    Select Case comment
                        Case True 'Yes with a comment
                            Return TblMetaColor.Find(list, TblMetaColor.Colors.Yellow).ToColor
                        Case False 'Yes with no comment
                            Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                    End Select
                Case "no"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
                Case "n/a"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                Case String.Empty
                    Return Drawing.Color.Transparent
            End Select
        End Function

        Public Shared Function GetColorByExposure(rptProps As IBatchSetReportProperties, ByVal pValue As String) As System.Drawing.Color
            Dim list As List(Of rowTblMetaColor) = rptProps.Colors
            Select Case pValue.ToLower
                Case "no", "n/a"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Lime).ToColor
                Case "yes"
                    Return TblMetaColor.Find(list, TblMetaColor.Colors.Red).ToColor
            End Select

        End Function

        Public Shared Function GetColorByRiskRating(rptProps As IBatchSetReportProperties, ByVal pValue As String) As System.Drawing.Color
            If Not IsNothing(pValue) Then
                Dim zRatingList As List(Of rowVwMetaRatingKeyRange)
                If rptProps.Practice.Practice = TblMetaPractice.Practices.BM Then zRatingList = rptProps.BMRatingRange Else zRatingList = rptProps.FireRatingRange

                For Each zRatingItem As rowVwMetaRatingKeyRange In zRatingList
                    If zRatingItem.colFldRating.Equals(pValue, StringComparison.OrdinalIgnoreCase) Then
                        Return TblMetaColor.Find(rptProps.Colors, zRatingItem.colFldMetaColorId).ToColor
                    ElseIf pValue.ToLower.Contains(zRatingItem.colFldRating.ToLower) Then
                        Return TblMetaColor.Find(rptProps.Colors, zRatingItem.colFldMetaColorId).ToColor
                    End If
                Next
            Else
                Return Drawing.Color.Transparent
            End If
        End Function

        Public Shared Function GetColorByRiskScore(rptProps As IBatchSetReportProperties, ByVal pValue As String) As System.Drawing.Color

            Dim zRatingList As List(Of rowVwMetaRatingKeyRange)
            If rptProps.Practice.Practice = TblMetaPractice.Practices.BM Then zRatingList = rptProps.BMRatingRange Else zRatingList = rptProps.FireRatingRange

            For Each zRatingItem As rowVwMetaRatingKeyRange In zRatingList
                If zRatingItem.colFldScoreLow <= pValue And zRatingItem.colFldScoreHigh >= pValue Then
                    Return TblMetaColor.Find(rptProps.Colors, zRatingItem.colFldMetaColorId).ToColor
                End If
            Next
        End Function

    End Class

End Class

