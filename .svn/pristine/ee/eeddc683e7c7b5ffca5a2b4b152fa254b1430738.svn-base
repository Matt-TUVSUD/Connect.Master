'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/16/2014 8:45:30 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class ViewCCCopeMainFire 
        Inherits esViewCCCopeMainFire
        Implements ILossEstimateValidation

        Public Function GetClient() As Clients
            Dim zObj As New Clients
            zObj.LoadByFilePrefix(Int(Me.FileNo))
            Return zObj
        End Function

        Public Function IsAPLBIValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsAplBIValid
            Return DoBiValidation(UtilLossEstimates.LossTypeField.APLBI)
        End Function

        Public Function IsAPLPDValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsAplPDValid
            Return DoPdValidation(UtilLossEstimates.LossTypeField.APLPD)
        End Function

        Public Function IsAPLTotalValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsAplTotalValid
            Return DoTotalValidation(UtilLossEstimates.LossTypeField.APLTOTAL)
        End Function

        Public Function IsMflBIValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsMflBIValid
            Return DoBiValidation(UtilLossEstimates.LossTypeField.MFLBI)
        End Function

        Public Function IsMflPDValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsMflPDValid
            Return DoPdValidation(UtilLossEstimates.LossTypeField.MFLPD)
        End Function

        Public Function IsMflTotalValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsMflTotalValid
            Return DoTotalValidation(UtilLossEstimates.LossTypeField.MFLTOTAL)
        End Function

        Public Function IsTivBIValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsTivBIValid
            Return DoBiValidation(UtilLossEstimates.LossTypeField.TIVBI)
        End Function

        Public Function IsTivPDValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsTivPDValid
            Return DoPdValidation(UtilLossEstimates.LossTypeField.TIVPD)
        End Function

        Public Function IsTivTotalValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsTivTotalValid
            Return DoTotalValidation(UtilLossEstimates.LossTypeField.TIVTOTAL)
        End Function

        Public Function IsPmlBIValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsPmlBIValid
            Return DoBiValidation(UtilLossEstimates.LossTypeField.PMLBI)
        End Function

        Public Function IsPmlPDValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsPmlPDValid
            Return DoPdValidation(UtilLossEstimates.LossTypeField.PMLPD)
        End Function

        Public Function IsPmlTotalValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsPmlTotalValid
            Return DoTotalValidation(UtilLossEstimates.LossTypeField.PMLTOTAL)
        End Function

        Public Function DoValidate() As LossEstimateValidation Implements ILossEstimateValidation.DoValidate
            Dim zCol As New ViewCCCopeMainFireCollection

            Dim zQry As New ViewCCCopeMainFireQuery
            zQry.SelectAll()
            zQry.OrderBy(zQry.FileNo.Ascending)
            'zQry.Where(zQry.FileNo = "2619.1119")
            ' zQry.es.Top = 2000

            Dim zList As New List(Of LossEstimateValidationResult)
            Trace.WriteLine("Loading Data...")
            zCol.Load(zQry)
            Trace.WriteLine("Loading Complete! (" & zCol.Count & " records)")

            Dim iCounter As Integer = 0
            Dim iListCounter As Integer = 0
            Dim zFileNoDict As New Dictionary(Of Integer, String)
            For Each zEnt As ViewCCCopeMainFire In zCol
                If Math.IEEERemainder(iCounter, 1000) = 0 Then Trace.WriteLine("Processed: " & iCounter)
                iCounter += 1
                If zEnt.IsBiReportingValid Is Nothing And zEnt.IsCurrencyReportingValid Is Nothing Then
                    iListCounter = zList.Count
                    AddValidateResult(zEnt.IsAPLBIValid(), zList)
                    AddValidateResult(zEnt.IsAPLPDValid(), zList)
                    AddValidateResult(zEnt.IsAPLTotalValid(), zList)

                    AddValidateResult(zEnt.IsPmlBIValid(), zList)
                    AddValidateResult(zEnt.IsPmlPDValid(), zList)
                    AddValidateResult(zEnt.IsPmlTotalValid(), zList)

                    AddValidateResult(zEnt.IsMflBIValid(), zList)
                    AddValidateResult(zEnt.IsMflPDValid(), zList)
                    AddValidateResult(zEnt.IsMflTotalValid(), zList)

                    AddValidateResult(zEnt.IsTivBIValid(), zList)
                    AddValidateResult(zEnt.IsTivPDValid(), zList)
                    AddValidateResult(zEnt.IsTivTotalValid(), zList)

                    If zList.Count = iListCounter Then
                        If Not zFileNoDict.TryGetValue(zEnt.GetClient.ExchangeRateGroupID, Nothing) Then
                            zFileNoDict.Add(zEnt.GetClient.ExchangeRateGroupID, zEnt.FileNo)
                        End If
                    End If
                Else
                    AddValidateResult(zEnt.IsBiReportingValid, zList)
                    AddValidateResult(zEnt.IsCurrencyReportingValid, zList)
                End If
            Next




            Return UtilLossEstimates.WriteText(zList)

        End Function

        Private Sub AddValidateResult(pResult As LossEstimateValidationResult, pList As System.Collections.Generic.List(Of LossEstimateValidationResult)) Implements ILossEstimateValidation.AddValidateResult
            If pResult IsNot Nothing Then
                pList.Add(pResult)
            End If
        End Sub

        Public Function DoBiValidation(pLossTypeField As UtilLossEstimates.LossTypeField) As LossEstimateValidationResult Implements ILossEstimateValidation.DoBiValidation
            Dim zReturn As LossEstimateValidationResult = Nothing
            Dim zBIRpt As Object = IIf(IsNothing(Me.BIReporting), "NULL", Me.BIReporting)
            Dim zBIVal As Object = Nothing

            Select Case pLossTypeField

                Case UtilLossEstimates.LossTypeField.APLBI
                    zBIVal = IIf(IsNothing(Me.Aplbi), "NULL", Me.Aplbi)

                Case UtilLossEstimates.LossTypeField.MFLBI
                    zBIVal = IIf(IsNothing(Me.Mflbi), "NULL", Me.Mflbi)

                Case UtilLossEstimates.LossTypeField.PMLBI
                    zBIVal = IIf(IsNothing(Me.Pmlbi), "NULL", Me.Pmlbi)

                Case UtilLossEstimates.LossTypeField.TIVBI
                    zBIVal = IIf(IsNothing(Me.Tivbi), "NULL", Me.Tivbi)

            End Select

            If pLossTypeField = UtilLossEstimates.LossTypeField.MFLBI Or pLossTypeField = UtilLossEstimates.LossTypeField.PMLBI Or pLossTypeField = UtilLossEstimates.LossTypeField.TIVBI Then
                If Me.BIReporting.ToLower = "percentage" Then
                    If IsNumeric(zBIVal) Then If zBIVal > 0 Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Invalid " & pLossTypeField.ToString & " (" & zBIVal & ") value when BIReporting is percentage.", "Invalid " & pLossTypeField.ToString & " Value")
                ElseIf Me.BIReporting.ToLower = "currency" Then
                    If Not IsNumeric(zBIVal) Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Invalid " & pLossTypeField.ToString & " (" & zBIVal & ") value when BIReporting is currency.", "Invalid " & pLossTypeField.ToString & " Value")
                End If
            Else
                'TO HANDLE APL VALUES
                If IsNumeric(zBIVal) Then
                    If zBIVal = 0 Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Missing " & pLossTypeField.ToString & " (" & zBIVal & ") value.", "Missing " & pLossTypeField.ToString & " Value")
                Else
                    zReturn = New LossEstimateValidationResult(Me, GetClient, "Missing " & pLossTypeField.ToString & " (" & zBIVal & ") value.", "Missing " & pLossTypeField.ToString & " Value")
                End If
            End If


            Return zReturn

        End Function

        Public Function DoPdValidation(pLossTypeField As UtilLossEstimates.LossTypeField) As LossEstimateValidationResult Implements ILossEstimateValidation.DoPdValidation
            Dim zReturn As LossEstimateValidationResult = Nothing
            Dim zPDRpt As Object = IIf(IsNothing(Me.Currency), "NULL", Me.Currency)
            Dim zPDVal As Object = Nothing

            Select Case pLossTypeField

                Case UtilLossEstimates.LossTypeField.APLPD
                    zPDVal = IIf(IsNothing(Me.Aplpd), "NULL", Me.Aplpd)

                Case UtilLossEstimates.LossTypeField.MFLPD
                    zPDVal = IIf(IsNothing(Me.Mflpd), "NULL", Me.Mflpd)

                Case UtilLossEstimates.LossTypeField.PMLPD
                    zPDVal = IIf(IsNothing(Me.Pmlpd), "NULL", Me.Pmlpd)

                Case UtilLossEstimates.LossTypeField.TIVPD
                    zPDVal = IIf(IsNothing(Me.Tivpd), "NULL", Me.Tivpd)

            End Select
            If pLossTypeField = UtilLossEstimates.LossTypeField.MFLPD Or pLossTypeField = UtilLossEstimates.LossTypeField.PMLPD Or pLossTypeField = UtilLossEstimates.LossTypeField.TIVPD Then
                If Me.Currency.ToLower = "percentage" Then
                    If IsNumeric(zPDVal) Then If zPDVal > 0 Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Invalid " & pLossTypeField.ToString & " (" & zPDVal & ") value when currency is percentage.", "Invalid " & pLossTypeField.ToString & " Value")
                Else
                    If Not IsNumeric(zPDVal) Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Invalid " & pLossTypeField.ToString & " (" & zPDVal & ") value when currency is " & Me.Currency, "Invalid " & pLossTypeField.ToString & " Value")
                End If
            Else
                'TO HANDLE APL VALUES
                If IsNumeric(zPDVal) Then
                    If zPDVal = 0 Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Missing " & pLossTypeField.ToString & " (" & zPDVal & ") value.", "MIssing " & pLossTypeField.ToString & " Value")
                Else
                    zReturn = New LossEstimateValidationResult(Me, GetClient, "Missing " & pLossTypeField.ToString & " (" & zPDVal & ") value.", "Missing " & pLossTypeField.ToString & " Value")
                End If
            End If


            Return zReturn
        End Function

        Public Function DoTotalValidation(pLossTypeField As UtilLossEstimates.LossTypeField) As LossEstimateValidationResult Implements ILossEstimateValidation.DoTotalValidation
            Dim zReturn As LossEstimateValidationResult = Nothing
            Dim zPD As Object = Nothing
            Dim zBI As Object = Nothing
            Dim zTotal As Object = Nothing
            Dim zPDBIIsValid As Boolean = False

            Select Case pLossTypeField

                Case UtilLossEstimates.LossTypeField.APLTOTAL
                    If IsAPLBIValid() Is Nothing And IsAPLPDValid() Is Nothing Then
                        zPDBIIsValid = True
                        zPD = Convert.ToInt64(Me.Aplpd)
                        zBI = Convert.ToInt64(Me.Aplbi)
                        zTotal = IIf(IsNothing(Me.APLTotal), "NULL", Convert.ToInt64(Me.APLTotal).ToString)
                    End If

                Case UtilLossEstimates.LossTypeField.MFLTOTAL
                    If IsMflBIValid() Is Nothing And IsMflPDValid() Is Nothing Then
                        zPDBIIsValid = True
                        zPD = Convert.ToInt64(Me.Mflpd)
                        zBI = Convert.ToInt64(Me.Mflbi)
                        zTotal = IIf(IsNothing(Me.MFLTotal), "NULL", Convert.ToInt64(Me.MFLTotal).ToString)
                    End If

                Case UtilLossEstimates.LossTypeField.PMLTOTAL
                    If IsPmlBIValid() Is Nothing And IsPmlPDValid() Is Nothing Then
                        zPDBIIsValid = True
                        zPD = Convert.ToInt64(Me.Pmlpd)
                        zBI = Convert.ToInt64(Me.Pmlbi)
                        zTotal = IIf(IsNothing(Me.PMLTotal), "NULL", Convert.ToInt64(Me.PMLTotal).ToString)
                    End If
                Case UtilLossEstimates.LossTypeField.TIVTOTAL
                    If IsTivBIValid() Is Nothing And IsTivPDValid() Is Nothing Then
                        zPDBIIsValid = True
                        zPD = Convert.ToInt64(Me.Tivpd)
                        zBI = Convert.ToInt64(Me.Tivbi)
                        zTotal = IIf(IsNothing(Me.TIVTotal), "NULL", Convert.ToInt64(Me.TIVTotal).ToString)
                    End If
            End Select


            If zPDBIIsValid Then
                If pLossTypeField = UtilLossEstimates.LossTypeField.MFLTOTAL Or pLossTypeField = UtilLossEstimates.LossTypeField.PMLTOTAL Or pLossTypeField = UtilLossEstimates.LossTypeField.TIVTOTAL Then

                    If Me.BIReporting.ToLower = "currency" Then
                        If Not IsNumeric(zTotal) Then
                            zReturn = New LossEstimateValidationResult(Me, GetClient, "Invalid or Missing " & pLossTypeField.ToString & " value.", "Invalid " & pLossTypeField.ToString & " Value")
                        Else
                            If ((zPD + zBI) - zTotal) > 5 Then zReturn = New LossEstimateValidationResult(Me, GetClient, "The sum of " & Replace(pLossTypeField.ToString, "TOTAL", "PD") & "(" & zPD & ") and " & Replace(pLossTypeField.ToString, "TOTAL", "BI") & " (" & zBI & ")  does not equal " & pLossTypeField.ToString & "(" & zTotal & ")", "Sum Discrepancy")
                        End If
                    Else
                        If IsNumeric(zTotal) Then
                            If zTotal > 0 Then 'By default values are save as 0 due to column requirments.
                                zReturn = New LossEstimateValidationResult(Me, GetClient, pLossTypeField.ToString & " (" & zTotal & ") has a value when BIReporting is percentage.", "Invalid " & pLossTypeField.ToString & " Value")
                            End If
                        End If
                    End If
                Else
                    'TO HANDLE APL VALUES
                    If IsNumeric(zTotal) Then
                        If zTotal = 0 Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Missing " & pLossTypeField.ToString & " (" & zTotal & ") value.", "Missing " & pLossTypeField.ToString & " Value")
                    Else
                        zReturn = New LossEstimateValidationResult(Me, GetClient, "Missing " & pLossTypeField.ToString & " (" & zTotal & ") value.", "Missing " & pLossTypeField.ToString & " Value")
                    End If
                End If
            End If

            Return zReturn
        End Function

        Public Function IsBiReportingValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsBiReportingValid
            Dim zReturn As LossEstimateValidationResult = Nothing
            If IsNothing(Me.BIReporting) Then zReturn = New LossEstimateValidationResult(Me, GetClient, "BIReporting (NULL) is missing.", "Missing BIReporting value")
            Return zReturn
        End Function

        Public Function IsCurrencyReportingValid() As LossEstimateValidationResult Implements ILossEstimateValidation.IsCurrencyReportingValid
            Dim zReturn As LossEstimateValidationResult = Nothing
            If IsNothing(Me.Currency) Then zReturn = New LossEstimateValidationResult(Me, GetClient, "Currency (NULL) is missing.", "Missing Currency value")
            Return zReturn
        End Function
    End Class

End Namespace
