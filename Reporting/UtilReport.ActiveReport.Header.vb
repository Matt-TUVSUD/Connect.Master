Partial Class UtilReport
    Partial Class ActiveReport
        Public Class Header
#Region "Report Titles"
#Region "Recommendations Report"
            Public Shared Function RecommendationsReport(pReportName As String) As String
                If pReportName = "BMActiveRecommendationsByTypeReport" Then
                    Return "Active B&M" & RecommendationsReportString()
                ElseIf pReportName = "BMRecommendationsReport" Then
                    Return "All B&M" & RecommendationsReportString()

                ElseIf pReportName = "FireActiveRecommendationsByTypeReport" Then
                    Return "Active Fire" & RecommendationsReportString()
                ElseIf pReportName = "FireAllRecommendationsByTypeReport" Then
                    Return "All Fire" & RecommendationsReportString()

                ElseIf pReportName = "IRActiveRecommendationsByTypeReport" Or pReportName = "ActiveIRRecommendations" Then
                    Return "Active Infrared" & RecommendationsReportString()
                ElseIf pReportName = "IRAllRecommendationsByTypeReport" Or pReportName = "IRRecommendations" Or pReportName = "AllIRRecommendations" Then
                    Return "All Infrared" & RecommendationsReportString()

                ElseIf pReportName = "FloodActiveRecommendationsByTypeReport" Then
                    Return "Active Natural Hazards Flood" & RecommendationsReportString()
                ElseIf pReportName = "FloodAllRecommendationsByTypeReport" Then
                    Return "All Natural Hazards Flood" & RecommendationsReportString()

                ElseIf pReportName = "SeismicActiveRecommendationsByTypeReport" Then
                    Return "Active Natural Hazards Seismic" & RecommendationsReportString()
                ElseIf pReportName = "SeismicAllRecommendationsByTypeReport" Then
                    Return "All Natural Hazards Seismic" & RecommendationsReportString()

                ElseIf pReportName = "WindActiveRecommendationsByTypeReport" Then
                    Return "Active Natural Hazards Wind" & RecommendationsReportString()
                ElseIf pReportName = "WindAllRecommendationsByTypeReport" Then
                    Return "All Natural Hazards Wind" & RecommendationsReportString()

                ElseIf pReportName = "NHActiveRecommendationsByTypeReport" Then
                    Return "Active Natural Hazards " & RecommendationsReportString()
                ElseIf pReportName = "NHAllRecommendationsByTypeReport" Then
                    Return "All Natural Hazards " & RecommendationsReportString()

                ElseIf pReportName = "PSActiveRecommendationsByTypeReport" Then
                    Return "Active Process Safety" & RecommendationsReportString()

                ElseIf pReportName = "PSAllRecommendationsByTypeReport" Then
                    Return "All Process Safety" & RecommendationsReportString()

                Else
                    Return String.Empty
                End If
            End Function

            Private Shared Function RecommendationsReportString() As String
                Return " Recommendations Report"
            End Function

            Public Shared Function ActiveRecommendationsOnly(pReportName As String) As String
                If pReportName = "BMActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()
                ElseIf pReportName = "BMRecommendationsReport" Then
                    Return String.Empty

                ElseIf pReportName = "FireActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()
                ElseIf pReportName = "FireAllRecommendationsByTypeReport" Then
                    Return String.Empty

                ElseIf pReportName = "IRActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()
                ElseIf pReportName = "IRAllRecommendationsByTypeReport" Then
                    Return String.Empty

                ElseIf pReportName = "FloodActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()
                ElseIf pReportName = "FloodAllRecommendationsByTypeReport" Then
                    Return String.Empty

                ElseIf pReportName = "SeismicActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()
                ElseIf pReportName = "SeismicAllRecommendationsByTypeReport" Then
                    Return String.Empty

                ElseIf pReportName = "WindActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()

                ElseIf pReportName = "WindAllRecommendationsByTypeReport" Then
                    Return String.Empty

                ElseIf pReportName = "NHActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()
                ElseIf pReportName = "NHAllRecommendationsByTypeReport" Then
                    Return String.Empty

                ElseIf pReportName = "PSActiveRecommendationsByTypeReport" Then
                    Return ActiveRecommendationsOnlyString()

                ElseIf pReportName = "PSRecommendationsReport" Then
                    Return String.Empty

                Else
                    Return String.Empty
                End If
            End Function

            Private Shared Function ActiveRecommendationsOnlyString() As String
                Return "(Active Recommendations Only - does not include 'Conf Completed' or 'Removed' Recommendations)"
            End Function
#End Region

#Region "Recommendation Response Follow-Up Report"
            Public Shared Function RecommendationResponseFollowUpReport(pReportName As String) As String
                If pReportName = "BMAllRecommendationResponsesFollowUpReport" Then
                    Return "All B&M" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "BMPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "BMPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending B&M" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "FireAllRecommendationResponsesFollowUpReport" Then
                    Return "All Fire" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "FirePendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "FirePendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Fire" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "IRAllRecommendationResponsesFollowUpReport" Then
                    Return "All Infrared" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "IRPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "IRPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Infrared" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "FloodAllRecommendationResponsesFollowUpReport" Then
                    Return "All Natural Hazards Flood" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "FloodPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "FloodPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Natural Hazards Flood" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "SeismicAllRecommendationResponsesFollowUpReport" Then
                    Return "All Natural Hazards Seismic" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "SeismicPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "SeismicPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Natural Hazards Seismic" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "WindAllRecommendationResponsesFollowUpReport" Then
                    Return "All Natural Hazards Wind" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "WindPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "WindPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Natural Hazards Wind" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "NHAllRecommendationResponsesFollowUpReport" Then
                    Return "All Natural Hazards " & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "NHPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "NHPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Natural Hazards " & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "PSAllRecommendationResponsesFollowUpReport" Then
                    Return "All Process Safety" & RecommendationResponseFollowUpReportString()

                ElseIf pReportName = "PSPendingRecommendationResponsesFollowUpReport" _
                    Or pReportName = "PSPendingRecommendationResponsesFollowUpAutoRequestReport" Then
                    Return "Pending Process Safety" & RecommendationResponseFollowUpReportString()
                Else
                    Return String.Empty
                End If
            End Function

            Private Shared Function RecommendationResponseFollowUpReportString() As String
                Return " Recommendation Follow-Up Report"
            End Function

            Public Shared Function RecommendationResponseFollowUpReportMessage(pReportName As String) As String
                If pReportName = "BMAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "BMPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "FireAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "FirePendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "IRAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "IRPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "FloodAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "FloodPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "SeismicAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "SeismicPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "WindAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "WindPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "NHAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()
                ElseIf pReportName = "NHPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                ElseIf pReportName = "PSAllRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessageAllString()

                ElseIf pReportName = "PSPendingRecommendationResponsesFollowUpReport" Then
                    Return RecommendationResponseFollowUpReportMessagePendingString()

                Else
                    Return String.Empty
                End If
            End Function

            Private Shared Function RecommendationResponseFollowUpReportMessageAllString() As String
                Return "(This report includes all Recommendations, regardless of Recommendation Status or Response Status.)"
            End Function

            Private Shared Function RecommendationResponseFollowUpReportMessagePendingString() As String
                Return "(This report includes all Outstanding, In Progress or Rptd Completed Status Recommendations.)"
            End Function
#End Region

#Region "Recommendation Response Tracking Report"
            Public Shared Function RecommendationResponseTrackingReport(pReportName As String) As String
                If pReportName = "BMAllRecommendationResponsesTrackingReport" Then
                    Return "All B&M" & RecommendationTrackingReportString()
                ElseIf pReportName = "BMPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending B&M" & RecommendationTrackingReportString()

                ElseIf pReportName = "FireAllRecommendationResponsesTrackingReport" Then
                    Return "All Fire" & RecommendationTrackingReportString()
                ElseIf pReportName = "FirePendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Fire" & RecommendationTrackingReportString()

                ElseIf pReportName = "IRAllRecommendationResponsesTrackingReport" Then
                    Return "All Infrared" & RecommendationTrackingReportString()
                ElseIf pReportName = "IRPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Infrared" & RecommendationTrackingReportString()

                ElseIf pReportName = "FloodAllRecommendationResponsesTrackingReport" Then
                    Return "All Natural Hazards Flood" & RecommendationTrackingReportString()
                ElseIf pReportName = "FloodPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Natural Hazards Flood" & RecommendationTrackingReportString()

                ElseIf pReportName = "SeismicAllRecommendationResponsesTrackingReport" Then
                    Return "All Natural Hazards Seismic" & RecommendationTrackingReportString()
                ElseIf pReportName = "SeismicPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Natural Hazards Seismic" & RecommendationTrackingReportString()

                ElseIf pReportName = "WindAllRecommendationResponsesTrackingReport" Then
                    Return "All Natural Hazards Wind" & RecommendationTrackingReportString()
                ElseIf pReportName = "WindPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Natural Hazards Wind" & RecommendationTrackingReportString()

                ElseIf pReportName = "NHAllRecommendationResponsesTrackingReport" Then
                    Return "All Natural Hazards " & RecommendationTrackingReportString()
                ElseIf pReportName = "NHPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Natural Hazards " & RecommendationTrackingReportString()

                ElseIf pReportName = "PSAllRecommendationResponsesTrackingReport" Then
                    Return "All Process Safety" & RecommendationTrackingReportString()

                ElseIf pReportName = "PSPendingRecommendationResponsesTrackingReport" Then
                    Return "Pending Process Safety" & RecommendationTrackingReportString()

                Else
                    Return String.Empty
                End If
            End Function

            Private Shared Function RecommendationTrackingReportString() As String
                Return " Recommendation Tracking Report"
            End Function

            Private Shared Function RecommendationExpiredExpCompDateReportString() As String
                Return " Expiring-Expired Expected Completion Date Report"
            End Function

            Public Shared Function RecommendationResponseTrackingReportMessage(pReportName As String) As String
                If pReportName = "BMAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()
                ElseIf pReportName = "BMPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "FireAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()
                ElseIf pReportName = "FirePendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "IRAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()
                ElseIf pReportName = "IRPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "FloodAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()
                ElseIf pReportName = "FloodPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "SeismicAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()
                ElseIf pReportName = "SeismicPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "WindAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()

                ElseIf pReportName = "WindPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "NHAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()

                ElseIf pReportName = "NHPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                ElseIf pReportName = "PSAllRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessageAllString()

                ElseIf pReportName = "PSPendingRecommendationResponsesTrackingReport" Then
                    Return RecommendationResponseTrackingReportMessagePendingString()

                Else
                    Return String.Empty
                End If
            End Function

            Public Shared Function RecommendationExpiredCompDateReportMessage() As String
                Return RecommendationExpiredCompDateReportMessageString()
            End Function

            Public Shared Function RecommendationExpiredCompDateReport(pReportName As String) As String
                If pReportName = "BMPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "B&M" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "FirePendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "Fire" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "IRPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "Infrared" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "FloodPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "NatHaz/Flood" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "WindPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "NatHaz/Wind" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "SeismicPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "NatHaz/Seismic" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "NHPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "Natural Hazards" & RecommendationExpiredExpCompDateReportString()
                ElseIf pReportName = "PSPendingRecommendationResponsesTrackingExpectedOverdueReport" Then
                    Return "Process Safety" & RecommendationExpiredExpCompDateReportString()
                Else
                    Return String.Empty
                End If
            End Function

            Private Shared Function RecommendationResponseTrackingReportMessageAllString() As String
                Return "(This report includes all Recommendations, regardless of Recommendation Status or Response Status.)"
            End Function

            Private Shared Function RecommendationResponseTrackingReportMessagePendingString() As String
                Return "(This report includes all Outstanding, In Progress or Rptd Completed Status Recommendations.)"
            End Function

            Private Shared Function RecommendationExpiredCompDateReportMessageString() As String
                Return "(This report includes all Outstanding or In Progress Recommendations.)"
            End Function
#End Region
#End Region
        End Class
    End Class
End Class
