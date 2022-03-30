Public Class JSONSetting
    Implements IJSONFilter

    Public Property Settings As New List(Of JSONSettingItem)

    Public Function ToJSON() As String Implements IJSONFilter.ToJSON
        Dim zSB As New System.Text.StringBuilder
        With zSB
            .Append("{")
            For Each zSetting As JSONSettingItem In Settings
                .Append(zSetting.ToJSON)
                If Not Settings.Last.Equals(zSetting) Then .Append(",")
            Next
            .Append("}")
        End With
        Return zSB.ToString
    End Function

End Class
