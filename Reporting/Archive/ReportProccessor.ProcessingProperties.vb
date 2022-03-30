Partial Class ReportProccessor

     Public Class ProcessingProperties
          Public Property FilterSqlString = ""
          Public Property FilterString = ""
          Public Property SortSqlString = ""
          Public Property SortString = ""
          Private Property _Currency As Object = Nothing
          Private Property _Unit As Object = Nothing

          Public Property Currency As Object
               Get
                    If IsNumeric(_Currency) Then
                         Return _Currency
                    ElseIf IsNothing(_Currency) Or _Currency = "" Then
                         Return Libraries.CoreLib.UtilCurrency.Currencies.UsDollar
                    Else
                         Return Libraries.CoreLib.UtilCurrency.GetCurrencyEnum(_Currency)
                    End If

               End Get

               Set(value As Object)
                    _Currency = value
               End Set
          End Property

          Public Property Unit As Object
               Get
                    If IsNumeric(_Unit) Then
                         Return _Unit
                    ElseIf IsNothing(_Unit) Or _Unit = "" Then
                         Return Libraries.CoreLib.UtilUnit.Units.English
                    Else
                         Return Libraries.CoreLib.UtilUnit.GetUnitEnum(_Unit)
                    End If

               End Get
               Set(value As Object)
                    _Unit = value
               End Set
          End Property

     End Class
End Class


