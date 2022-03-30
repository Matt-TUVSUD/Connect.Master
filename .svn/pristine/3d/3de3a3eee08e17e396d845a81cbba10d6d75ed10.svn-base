Namespace razor
    Partial Class TblMetaLanguage
        Public Enum Languages
            English = 1
            French
            German
            Italian
            Portuguese
            Spanish
        End Enum

        Public Shared Function GetColumnName(ByVal pLanguage As TblMetaLanguage.Languages) As String
            Select Case pLanguage
                Case TblMetaLanguage.Languages.English
                    Return "EnglishTranslation"

                Case TblMetaLanguage.Languages.French
                    Return "FrenchTranslation"

                Case TblMetaLanguage.Languages.German
                    Return "GermanTranslation"

                Case TblMetaLanguage.Languages.Italian
                    Return "ItalianTranslation"

                Case TblMetaLanguage.Languages.Portuguese
                    Return "PortugueseTranslation"

                Case TblMetaLanguage.Languages.Spanish
                    Return "SpanishTranslation"

                Case Else
                    Return ""
            End Select
        End Function

    End Class
End Namespace