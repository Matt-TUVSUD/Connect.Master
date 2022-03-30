Public Class UtilException
    Public Shared Function ExtractExceptionData(ByVal pException As Exception, ByVal pIncludeLineBreaks As Boolean) As String
        Dim zSb As New StringBuilder
        If pException.Data.Keys.Count > 0 Then
            For Each zKey As String In pException.Data.Keys
                If pIncludeLineBreaks Then
                    zSb.AppendLine(zKey & ": " & pException.Data(zKey))
                Else
                    If zSb.ToString = String.Empty Then
                        zSb.Append("[" & zKey & ": " & pException.Data(zKey))
                    Else
                        zSb.Append(", " & zKey & ": " & pException.Data(zKey))
                    End If
                End If
            Next
            If Not pIncludeLineBreaks Then zSb.Append("]")
        End If
        Return zSb.ToString
    End Function

    Public Shared Function ExtractExceptionDataHTML(ByVal pException As Exception, ByVal pIncludeLineBreaks As Boolean) As String
        Dim zSb As New StringBuilder
        If pException.Data.Keys.Count > 0 Then
            For Each zKey As String In pException.Data.Keys
                If pIncludeLineBreaks Then
                    zSb.Append(zKey & ": " & pException.Data(zKey) & "<br/>")
                Else
                    If zSb.ToString = String.Empty Then
                        zSb.Append("[" & zKey & ": " & pException.Data(zKey))
                    Else
                        zSb.Append(", " & zKey & ": " & pException.Data(zKey))
                    End If
                End If
            Next
            If Not pIncludeLineBreaks Then zSb.Append("]")
        End If
        Return zSb.ToString
    End Function
End Class
