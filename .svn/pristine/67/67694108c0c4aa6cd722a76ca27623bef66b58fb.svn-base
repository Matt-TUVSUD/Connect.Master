Public Class UtilCustomFeature

    Public Enum Letter
        A = 1
        B
        C
        D
        E
        F
        G
        H
        I
        J
        K
        L
        M
        N
        O
        P
        Q
        R
        S
        T
        U
        V
        W
        X
        Y
        Z
    End Enum

    Public Shared Function Contains(pProps As IBatchSetReportProperties, pLetter As Letter) As Boolean
        Return pProps.ClientSpecialFeatures.ToLower.Contains(pLetter.ToString.ToLower)
    End Function

    Public Shared Function Contains(pProps As IBatchSetReportProperties, pChar As Char) As Boolean
        Return pProps.ClientSpecialFeatures.ToLower.Contains(pChar.ToString.ToLower)
    End Function

    Public Shared Function Contains(pProps As IBatchSetReportProperties, ParamArray pLetters As Letter()) As Boolean

        For Each zLetter As Letter In pLetters
            If pProps.ClientSpecialFeatures.ToLower.Contains(zLetter.ToString.ToLower) Then Return True
        Next

        Return False

    End Function

    Public Shared Function Contains(pCustomFeatures As String, pLetter As Letter) As Boolean
        Return pCustomFeatures.ToLower.Contains(pLetter.ToString.ToLower)
    End Function

    Public Shared Function Contains(pCustomFeatures As String, pChar As Char) As Boolean
        Return pCustomFeatures.ToLower.Contains(pChar.ToString.ToLower)
    End Function

End Class
