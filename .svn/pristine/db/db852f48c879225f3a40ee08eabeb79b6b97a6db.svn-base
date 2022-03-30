
Public Class UtilCurrency

    Public Shared Function FormatCurrency(ByVal Symbol As String, ByVal Value As Double) As String
        Dim zFormattedValue As String = Format(Value, "#,###")
        Return Symbol & zFormattedValue
    End Function

    Public Enum Currencies
        UsDollar = 1
        AustralianDollar = 2
        BritishPound = 3
        CanadianDollar = 4
        Euro = 5
        JapaneseYen = 6
        MexicanPeso = 7
        NewZealandDollar = 8
    End Enum

    Public Shared Function GetCurrencyEnum(ByVal pCurrency As String) As Currencies
        Dim zCurrDefQry As New BusinessObjects.CurrencyDefinitionQuery
        zCurrDefQry.Select(zCurrDefQry.EnumValue)

        If Len(pCurrency) > 3 Then   'if the pCurrency values is greater than 3 chars, then the full currency name was supplied.  Otherwise the currency code was supplied.
            zCurrDefQry.Where(zCurrDefQry.Currency.ToLower = pCurrency.ToLower)
        Else
            zCurrDefQry.Where(zCurrDefQry.Code.ToLower = pCurrency.ToLower)
        End If

        Return zCurrDefQry.ExecuteScalar

    End Function

    'Public Shared Function GetCurrencySymbol(ByVal pCurrency As Currencies) As String

    '    Dim zCurrDefQry As New BusinessObjects.CurrencyDefinitionQuery
    '    zCurrDefQry.Select(zCurrDefQry.Symbol)
    '    zCurrDefQry.Where(zCurrDefQry.EnumValue = Convert.ToInt16(pCurrency))
    '    Return zCurrDefQry.ExecuteScalar

    'End Function

    'Public Shared Function GetCurrencyCode(ByVal pCurrency As Currencies) As String

    '    Dim zCurrDefQry As New BusinessObjects.CurrencyDefinitionQuery
    '    zCurrDefQry.Select(zCurrDefQry.Code)
    '    zCurrDefQry.Where(zCurrDefQry.EnumValue = Convert.ToInt16(pCurrency))
    '    Return zCurrDefQry.ExecuteScalar

    'End Function

    'Public Shared Function GetCurrencyName(ByVal pCurrency As Currencies) As String

    '    Dim zCurrDefQry As New BusinessObjects.CurrencyDefinitionQuery
    '    zCurrDefQry.Select(zCurrDefQry.Currency)
    '    zCurrDefQry.Where(zCurrDefQry.EnumValue = Convert.ToInt16(pCurrency))
    '    Return zCurrDefQry.ExecuteScalar

    'End Function

End Class


