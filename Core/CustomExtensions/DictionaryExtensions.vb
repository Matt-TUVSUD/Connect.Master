Imports System.Runtime.CompilerServices

Namespace CustomExtensions
    Module DictionaryExtensions
        <Extension()>
        Function DictionaryToString(ByVal pDict As Dictionary(Of String, String)) As String
            Dim zSB As New StringBuilder
            For Each zAddress As KeyValuePair(Of String, String) In pDict
                zSB.Append(zAddress)
                zSB.Append(", ")
            Next
            Return zSB.ToString
        End Function
    End Module
End Namespace

