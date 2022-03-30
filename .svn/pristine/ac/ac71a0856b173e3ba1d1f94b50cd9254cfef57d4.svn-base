Public Interface ILossEstimateValidation

    Function IsAplPDValid() As LossEstimateValidationResult
    Function IsPmlPDValid() As LossEstimateValidationResult
    Function IsMflPDValid() As LossEstimateValidationResult
    Function IsTivPDValid() As LossEstimateValidationResult

    Function IsAplBIValid() As LossEstimateValidationResult
    Function IsPmlBIValid() As LossEstimateValidationResult
    Function IsMflBIValid() As LossEstimateValidationResult
    Function IsTivBIValid() As LossEstimateValidationResult

    Function IsAplTotalValid() As LossEstimateValidationResult
    Function IsPmlTotalValid() As LossEstimateValidationResult
    Function IsMflTotalValid() As LossEstimateValidationResult
    Function IsTivTotalValid() As LossEstimateValidationResult

    Function IsBiReportingValid() As LossEstimateValidationResult
    Function IsCurrencyReportingValid() As LossEstimateValidationResult


    Function DoPdValidation(pLossTypeField As UtilLossEstimates.LossTypeField) As LossEstimateValidationResult
    Function DoBiValidation(pLossTypeField As UtilLossEstimates.LossTypeField) As LossEstimateValidationResult
    Function DoTotalValidation(pLossTypeField As UtilLossEstimates.LossTypeField) As LossEstimateValidationResult

    Function DoValidate() As LossEstimateValidation
    Sub AddValidateResult(pResult As LossEstimateValidationResult, pList As List(Of LossEstimateValidationResult))

End Interface
