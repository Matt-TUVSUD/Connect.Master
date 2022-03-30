Namespace razor
    Partial Class TblMetaLossEstimate

        Public Shared Function LoadAll() As List(Of rowTblMetaLossEstimate)
            Return TblMetaLossEstimate.LoadData("Select * From tblMetaLossEstimate")
        End Function

        Public Shared Function Find(list As List(Of rowTblMetaLossEstimate), range As String, ByVal clientCurrencyId As Integer, currencyId As Integer, type As TblMetaLossEstimateType.Types) As rowTblMetaLossEstimate

            'US DOLLAR LOOKUP
            Dim zRowToLookup As New rowTblMetaLossEstimate
            With zRowToLookup
                .colFldExchangeRateGroupID = clientCurrencyId
                .colFldCurrencyId = TblMetaCurrency.Currencies.UsDollar
                .colFldLossEstimateTypeId = type
                .colFldRangeText = range
            End With
            Dim zLookupItem As rowTblMetaLossEstimate = FindUSCurrencyItem(list, zRowToLookup)

            'IF THE CURRENCY ID IS NOT US DOLLARS(1) CONVERT
            If currencyId <> TblMetaCurrency.Currencies.UsDollar Then
                Dim zRowToFind As New rowTblMetaLossEstimate
                zRowToFind.colFldCurrencyId = currencyId
                zRowToFind.colFldExchangeRateGroupID = zLookupItem.colFldExchangeRateGroupID
                zRowToFind.colFldIndexNo = zLookupItem.colFldIndexNo
                zRowToFind.colFldLossEstimateTypeId = type
                zLookupItem = FindForeignCurrencyItem(list, zRowToFind)
            End If

            Return zLookupItem

        End Function

        Private Shared Function FindUSCurrencyItem(list As List(Of rowTblMetaLossEstimate), row As rowTblMetaLossEstimate) As rowTblMetaLossEstimate
            For Each item As rowTblMetaLossEstimate In list
                If item.colFldCurrencyId = row.colFldCurrencyId And
                    item.colFldRangeText = row.colFldRangeText And
                    item.colFldExchangeRateGroupID = row.colFldExchangeRateGroupID And
                    item.colFldLossEstimateTypeId = row.colFldLossEstimateTypeId Then
                    Return item
                End If
            Next
            Return New rowTblMetaLossEstimate
        End Function

        Private Shared Function FindForeignCurrencyItem(list As List(Of rowTblMetaLossEstimate), row As rowTblMetaLossEstimate) As rowTblMetaLossEstimate
            For Each item As rowTblMetaLossEstimate In list
                If item.colFldCurrencyId = row.colFldCurrencyId And
                    item.colFldExchangeRateGroupID = row.colFldExchangeRateGroupID And
                    item.colFldIndexNo = row.colFldIndexNo And
                    item.colFldLossEstimateTypeId = row.colFldLossEstimateTypeId Then
                    Return item
                End If
            Next
            Return New rowTblMetaLossEstimate
        End Function

    End Class
End Namespace