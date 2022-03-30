Imports System.Runtime.CompilerServices

Namespace CustomExtensions
    Public Module StringExtensions
        <Extension>
        Function Filter(srcObject As String(), filterValue As String, logic As FilterLogic) As String()
            Dim zList As New List(Of String)
            For Each zItem As String In srcObject
                Select Case logic
                    Case FilterLogic.Contains
                        If System.Globalization.CultureInfo.CurrentCulture.CompareInfo.IndexOf(zItem, filterValue, System.Globalization.CompareOptions.IgnoreCase) >= 0 Then
                            zList.Add(zItem)
                        End If
                    Case FilterLogic.Equals
                        If zItem.Equals(filterValue) Then
                            zList.Add(zItem)
                        End If
                    Case Else
                        Throw New NotImplementedException
                End Select
            Next
            Return zList.ToArray
        End Function

        <Extension>
        Function JsonToHtml(value As String) As String
            Return value.Replace(vbNewLine, "<br>").Replace(" ", "&nbsp;").Replace(Chr(13), "<br>").Replace(Chr(10), "<br>")
        End Function

        Enum FilterLogic
            [Contains]
            [Equals]
        End Enum

    End Module

    Module CharArrayExtensions
        <Extension>
        Function Stringify(srcObject As Char()) As String
            If srcObject Is Nothing Then Return ""
            Dim zSB As New StringBuilder
            For Each zItem As Char In srcObject
                zSB.Append(zItem.ToString)
            Next
            Return zSB.ToString
        End Function

    End Module
End Namespace

