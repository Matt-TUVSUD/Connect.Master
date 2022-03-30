Public Interface ITranslatable
    Function Translate(ByVal pValue As String, ByVal pFromLanguage As UtilTranslation.Language, ByVal pToLanguage As UtilTranslation.Language) As String
End Interface
