Public Class UtilUnit
    Public Enum Units
        English = 1
        Metric = 2
    End Enum

     Public Shared Function GetUnitName(ByVal pUnit As Units) As String
          If pUnit = Units.English Then
               Return "English"
          Else
               Return "Metric"
          End If

     End Function

     Public Shared Function GetUnitEnum(ByVal pUnitString As String) As UtilUnit.Units
          If pUnitString <> "" Then
               Return [Enum].Parse(GetType(UtilUnit.Units), pUnitString)
          Else
               Return Units.English
          End If
     End Function

     Public Class Convert
          Public Shared Function Length(ByVal pValue As Double, ByVal pFromUnit As Units, ByVal pToUnit As Units) As Int32

               If pFromUnit <> pToUnit Then
                    Select Case pToUnit
                         Case Units.Metric
                              Return pValue * 0.304878
                         Case Units.English
                              Return pValue / 0.304878
                    End Select
               Else
                    Return pValue
               End If

               Return Nothing

          End Function

          Public Shared Function Speed(ByVal pValue As Double, ByVal pFromUnit As Units, ByVal pToUnit As Units) As String
               Dim zRetval As Double
               If pFromUnit <> pToUnit Then
                    Select Case pToUnit
                         Case Units.Metric
                              zRetval = pValue * 0.44643
                         Case Units.English
                              zRetval = pValue / 0.44643
                    End Select

                    Return FormatNumber(zRetval, 0)
               Else
                    Return FormatNumber(pValue, 0)

               End If

               Return Nothing

          End Function

          Public Shared Function Area(ByVal pValue As Double, ByVal pFromUnit As Units, ByVal pToUnit As Units) As Int32

               If pFromUnit <> pToUnit Then
                    Select Case pToUnit
                         Case Units.Metric
                              Return pValue * 0.0934579439
                         Case Units.English
                              Return pValue / 0.0934579439
                    End Select
               Else
                    Return pValue
               End If

               Return Nothing

          End Function

          Public Shared Function Distance(ByVal pDistance As String, ByVal pFromUnit As Units, ByVal pToUnit As Units) As String
               Dim zUnitConvQuery As New Libraries.CoreLib.BusinessObjects.CopeUnitConversionQuery

               If pFromUnit <> pToUnit Then
                    Select Case pToUnit
                         Case Units.English
                              zUnitConvQuery.Select(zUnitConvQuery.English)
                              zUnitConvQuery.Where(zUnitConvQuery.Metric = pDistance)
                         Case Units.Metric
                              zUnitConvQuery.Select(zUnitConvQuery.Metric)
                              zUnitConvQuery.Where(zUnitConvQuery.English = pDistance)
                    End Select
               Else
                    Return pDistance
               End If

               Return zUnitConvQuery.ExecuteScalar

          End Function

     End Class

     Public Shared Function GetAreaAbbreviation(ByVal pUnit As Units) As String
          If pUnit = Units.English Then Return SquareFeet
          If pUnit = Units.Metric Then Return SquareMeter
          Return ""
     End Function

     Public Shared Function GetLengthAbbreviation(ByVal pUnit As Units) As String
          If pUnit = Units.English Then Return Feet
          If pUnit = Units.Metric Then Return Meter
          Return ""
     End Function

     Public Shared Function GetSpeedAbbreviation(ByVal pUnit As Units) As String
          If pUnit = Units.English Then Return MilesPerHour
          If pUnit = Units.Metric Then Return MetersPerSecond
          Return ""
     End Function



     Public Shared ReadOnly Property SquareFeet As String
          Get
               Return "sq. ft."
          End Get
     End Property

     Public Shared ReadOnly Property SquareMeter As String
          Get
               Return "sq. m."
          End Get
     End Property

     Public Shared ReadOnly Property Feet As String
          Get
               Return "ft."
          End Get
     End Property

     Public Shared ReadOnly Property Meter As String
          Get
               Return "m"
          End Get
     End Property


     Public Shared ReadOnly Property MilesPerHour As String
          Get
               Return "mph"
          End Get
     End Property

     Public Shared ReadOnly Property MetersPerSecond As String
          Get
               Return "m/sec"
          End Get
     End Property


End Class
