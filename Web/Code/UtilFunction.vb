Public Class UtilFunction

    Public Shared Sub AppendQueryString(ByRef existingUrl As String)
        existingUrl = existingUrl & IIf(existingUrl.Contains("?"), Replace(HttpContext.Current.Request.Url.Query, "?", "&"), HttpContext.Current.Request.Url.Query)
    End Sub

End Class
