Namespace razor

    Partial Class TblMetaCurrency
        Public Enum Currencies
            UsDollar = 1
            AustrailianDollar
            BritishPound
            CanadianDollar
            Euro
            JapaneseYen
            MexicanPeso
            NewZealandDollar
        End Enum

        Public Shared Function GetCurrencyName(pCurrencyId As Integer) As String
            Dim zReturn As String = ""

            Dim zRow As rowTblMetaCurrency = TblMetaCurrency.LoadByPrimaryKey(pCurrencyId)

            If Not zRow Is Nothing Then
                zReturn = zRow.colFldName
            End If

            Return zReturn
        End Function

        Public Shared Function GetCurrencySymbol(pCurrencyId As Integer) As String
            Dim zReturn As String = ""

            Dim zRow As rowTblMetaCurrency = TblMetaCurrency.LoadByPrimaryKey(pCurrencyId)

            If Not zRow Is Nothing Then
                zReturn = zRow.colFldSymbol
            End If

            Return zReturn
        End Function

        Public Shared Function GetCurrencyCode(pCurrencyId As Integer) As String
            Dim zReturn As String = ""

            Dim zRow As rowTblMetaCurrency = TblMetaCurrency.LoadByPrimaryKey(pCurrencyId)

            If Not zRow Is Nothing Then
                zReturn = zRow.colFldCode
            End If

            Return zReturn
        End Function

        Public Shared Function GetCurrencyId(pCurrencyCode As String) As Integer
            Dim zReturn As Integer = 1

            Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaCurrency] WHERE fldCode = @fldCode")
            zCmd.Parameters.AddWithValue("@fldCode", pCurrencyCode)
            Dim zRow As List(Of rowTblMetaCurrency) = TblMetaCurrency.LoadData(zCmd)

            If zRow.Count > 0 Then
                zReturn = zRow(0).colFldId
            End If

            Return zReturn
        End Function

        Public Shared Function GetCurrenciesType() As Type
            Return GetType(Currencies)
        End Function
    End Class
End Namespace