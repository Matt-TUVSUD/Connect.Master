Public Class JSONSettingItem
    Implements IJSONFilter

    Public Name As String
    Public Value As String

    Public Sub New(pName As String, pValue As String)
        Me.Name = pName
        Me.Value = pValue
    End Sub

    Public Function ToJSON() As String Implements IJSONFilter.ToJSON
        Dim zSB As New System.Text.StringBuilder
        With zSB
            .Append(JSONFilter.DoubleQuote(Me.Name) & ":" & JSONFilter.DoubleQuote(Me.Value))
        End With
        Return zSB.ToString

    End Function

End Class
