Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilLossExpectancy

    Public Enum LeType
        Before = 1
        After
        Cost
    End Enum

    Public Shared Function GetRangeText(pFilePrefix As String, pValue As Int64, pType As LeType) As String
        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(pFilePrefix)
        Dim zLE As New queryTblMetaLossEstimate
        zLE.SelectAll()
        zLE.Where.Add(zLE.colFldExchangeRateGroupID.Equals(CInt(zClient.colExchangeRateGroupID)))
        zLE.Where.Add(zLE.colFldLossEstimateTypeId.Equals(pType))
        zLE.Where.Add(zLE.colFldCurrencyId.Equals(1))

        Dim zList As List(Of rowTblMetaLossEstimate) = TblMetaLossEstimate.LoadData(zLE.QueryText)
        If zList.Count > 0 Then
            Return zList.Find(Function(x) pValue >= x.colFldRangeValueLow And pValue <= x.colFldRangeValueHigh).colFldRangeText
        Else
            Return ""
        End If

    End Function

    Public Shared Function GetRangeText(pFilePrefix As String, pValue As String, pType As LeType) As String
        Dim zClient As rowTblClients = TblClients.LoadByPrimaryKey(pFilePrefix)
        Dim zLE As New queryTblMetaLossEstimate
        zLE.SelectAll()
        zLE.Where.Add(zLE.colFldExchangeRateGroupID.Equals(CInt(zClient.colExchangeRateGroupID)))
        zLE.Where.Add(zLE.colFldLossEstimateTypeId.Equals(pType))
        zLE.Where.Add(zLE.colFldCurrencyId.Equals(1))

         Select Left(pValue, 1).ToLower

            Case "h"    'HE Reliability
                zLE.Where.Add(zLE.colFldRangeText.Contains("HE"))

            Case "p"    'Probability Reduction
                zLE.Where.Add(zLE.colFldRangeText.Contains("Prob"))

            Case "m"    'Maintenance Time
                zLE.Where.Add(zLE.colFldRangeText.Contains("Maint"))

            Case "o"    'Other
                zLE.Where.Add(zLE.colFldRangeText.Contains("Other"))

        End Select

        Dim zList As List(Of rowTblMetaLossEstimate) = TblMetaLossEstimate.LoadData(zLE.QueryText)
        If zList.Count > 0 Then
            Return zList.First.colFldRangeText
        Else
            Return ""
        End If

    End Function

End Class
