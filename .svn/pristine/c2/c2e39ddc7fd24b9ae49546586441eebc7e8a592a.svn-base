Public Class UtilText

    Public Shared Function RemoveSpecialCharacters(pText As String) As String
        Dim zSpecialChars As List(Of String) = GetSpecialChars()
        Dim zNewText As String = pText
        zSpecialChars.ForEach(Sub(x) zNewText = Replace(zNewText, x, ""))
        Return zNewText
    End Function

    Public Shared Function GetSpecialChars() As List(Of String)
        Return New List(Of String)({"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "~", ",", ".", "/"})
    End Function

End Class
