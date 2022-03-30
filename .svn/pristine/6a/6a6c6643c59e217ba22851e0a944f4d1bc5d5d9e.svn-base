Imports System.ComponentModel.DataAnnotations

Namespace razor
    Partial Class TblMetaPractice

        Public Enum Practices
            All = 1
            BM = 2
            Fire = 3
            Infrared = 4
            Jurisdictional = 5
            NatHazFlood = 6
            NatHazSeismic = 7
            NatHazWind = 8
            NaturalHazards = 9
            DiversifiedServices = 10
            ProcessSafety = 11
        End Enum

        Public Enum Hazards
            Fire = 3
            NatHazFlood = 6
            NatHazSeismic = 7
            NatHazWind = 8
            NatHaz = 9
        End Enum

        Public Enum Codes
            BMPracticeCode = 510
            BMPracticeCodeSpc = 515
            BMPracticeSelfInsp = 519
            FirePracticeCode = 520
            FirePracticeCodeSpc = 525
            FirePracticeSelfInsp = 529
            InfraredPracticeCode = 530
            InfraredPracticeCodeSpc = 535
            InfraredSelfInsp = 539
            JurisdictionalPracticeCode = 560
            JurisdictionalPracticeCodeSpc = 565
            NatHazFloodPracticeCode = 526
            NatHazSeismicPracticeCode = 526
            NatHazWindPracticeCode = 526
            DiversifiedServicesCode = 540
            DiversifiedServicesCodeSpc = 545
            NaturalHazardsCode = 550
            NaturalHazardsCodeSpc = 555
            NaturalHazardsSelfInsp = 559
            ProcessSafetyCode = 570
            ProcessSafetyCodeSpc = 575
            ProcessSafetySelfInsp = 579
        End Enum

        Public Enum Groups
            BMPracticeGroup = 51
            FirePracticeGroup = 52
            InfraredPracticeGroup = 53
            JurisdictionalPracticeGroup = 56
            NatHazFloodPracticeGroup = 52
            NatHazSeismicPracticeGroup = 52
            NatHazWindPracticeGroup = 52
            NaturalHazards = 55
            DiversifiedServices = 54
            ProcessSafety = 57
        End Enum
        ''' <summary>
        ''' Returns the assocated practice enum value based on the code string value.
        ''' </summary>
        ''' <param name="pCode">The practice code (ex: 510,515,520,525,530,535,560,565,526,540,545,550,555)</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetPractice(pCode As String) As TblMetaPractice.Practices
            Dim zCode As Codes = [Enum].Parse(GetType(TblMetaPractice.Codes), pCode)
            Return GetPractice(zCode)
        End Function

        Public Shared Function GetPractice(pCode As Codes) As TblMetaPractice.Practices
            Select Case pCode
                Case Codes.BMPracticeCode, Codes.BMPracticeCodeSpc, Codes.BMPracticeSelfInsp
                    Return Practices.BM
                Case Codes.FirePracticeCode, Codes.FirePracticeCodeSpc, Codes.FirePracticeSelfInsp
                    Return Practices.Fire
                Case Codes.InfraredPracticeCode, Codes.InfraredPracticeCodeSpc, Codes.InfraredSelfInsp
                    Return Practices.Infrared
                Case Codes.JurisdictionalPracticeCode, Codes.JurisdictionalPracticeCodeSpc
                    Return Practices.Jurisdictional
                Case Codes.NatHazFloodPracticeCode
                    Return Practices.NatHazFlood
                Case Codes.NatHazSeismicPracticeCode
                    Return Practices.NatHazSeismic
                Case Codes.NatHazWindPracticeCode
                    Return Practices.NatHazWind
                Case Codes.DiversifiedServicesCode, Codes.DiversifiedServicesCodeSpc
                    Return Practices.DiversifiedServices
                Case Codes.NaturalHazardsCode, Codes.NaturalHazardsCodeSpc, Codes.NaturalHazardsSelfInsp
                    Return Practices.NaturalHazards
                Case Codes.ProcessSafetyCode, Codes.ProcessSafetyCodeSpc, Codes.ProcessSafetySelfInsp
                    Return Practices.ProcessSafety
                Case Else
                    Return Nothing
            End Select
        End Function

        Public Shared Function ToCode(pPractice As Practices, Optional pGetSpecial As Boolean = False) As Codes
            Select Case pPractice
                Case Practices.BM
                    If pGetSpecial Then Return Codes.BMPracticeCodeSpc Else Return Codes.BMPracticeCode
                Case Practices.Fire
                    If pGetSpecial Then Return Codes.FirePracticeCodeSpc Else Return Codes.FirePracticeCode
                Case Practices.Infrared
                    If pGetSpecial Then Return Codes.InfraredPracticeCodeSpc Else Return Codes.InfraredPracticeCode
                Case Practices.Jurisdictional
                    If pGetSpecial Then Return Codes.JurisdictionalPracticeCodeSpc Else Return Codes.JurisdictionalPracticeCode
                Case Practices.NatHazFlood
                    If pGetSpecial Then Return Codes.NatHazFloodPracticeCode
                Case Practices.NatHazSeismic
                    If pGetSpecial Then Return Codes.NatHazSeismicPracticeCode
                Case Practices.NatHazWind
                    If pGetSpecial Then Return Codes.NatHazWindPracticeCode
                Case Practices.NaturalHazards
                    If pGetSpecial Then Return Codes.NaturalHazardsCodeSpc Else Return Codes.NaturalHazardsCode
                Case Practices.DiversifiedServices
                    If pGetSpecial Then Return Codes.DiversifiedServicesCodeSpc Else Return Codes.DiversifiedServicesCode
                Case Practices.ProcessSafety
                    If pGetSpecial Then Return Codes.ProcessSafetyCodeSpc Else Return Codes.ProcessSafetyCode
                Case Else
                    Return Nothing
            End Select

            Return Nothing

        End Function

    End Class

    Partial Public Class rowTblMetaPractice
        Public ReadOnly Property Practice As TblMetaPractice.Practices
            Get
                Return [Enum].Parse(GetType(TblMetaPractice.Practices), colFldId)
            End Get
        End Property
    End Class
End Namespace