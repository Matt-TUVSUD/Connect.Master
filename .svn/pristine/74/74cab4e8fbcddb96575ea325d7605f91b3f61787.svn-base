
Public Class UtilSession

    Public Shared Sub WriteSessionValuesToFile(ByVal pSession As Object, ByVal pFolderPath As String)

        If Right(pFolderPath, 1) <> "\" Then pFolderPath = pFolderPath & "\"

        'Dim zDict As New System.Text.StringBuilder
        'zDict.AppendLine("Dim zDict as new Dictionary(Of String, String)")

        Dim zSB As New System.Text.StringBuilder

        For i As Integer = 0 To pSession.Count - 1
            If pSession(i) Is Nothing Then
                zSB.AppendLine(Now.ToString & "  " & pSession.Keys(i).ToString() + " = Nothing")
                '       zDict.AppendLine("zDict.Add(" & Chr(34) & pSession.keys(i).ToString() & Chr(34) & "," & Chr(34) & "Nothing" & Chr(34) & ")")
            Else
                If TypeOf pSession(i) Is System.String()() Or TypeOf pSession(i) Is System.String() Then
                    zSB.AppendLine(Now.ToString & "  " & pSession.Keys(i).ToString() + " = " + pFolderPath & pSession.keys(i))
                    '            zDict.AppendLine("zDict.Add(" & Chr(34) & pSession.keys(i).ToString() & Chr(34) & "," & Chr(34) & "Generate" & pSession.keys(i) & Chr(34) & ")")
                Else
                    zSB.AppendLine(Now.ToString & "  " & pSession.Keys(i).ToString() + " = " + pSession(i).ToString())
                    '             zDict.AppendLine("zDict.Add(" & Chr(34) & pSession.keys(i).ToString() & Chr(34) & "," & Chr(34) & pSession(i) & Chr(34) & ")")
                End If
            End If
        Next

        zSB.AppendLine("")
        '  zSB.AppendLine(zDict.ToString)
        zSB.AppendLine("------------------------------------------------------")
        zSB.AppendLine("")

        IO.File.AppendAllText(pFolderPath & "SessionVariables.log", zSB.ToString)

    End Sub



End Class
