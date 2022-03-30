Public Class UtilSession

    Public Shared Sub Clear()
        PasswordErrorMessage = Nothing
        ResetPasswordEmailAddress = Nothing
        IsRedirectedFromAuthPage = Nothing
        IsLockedDueToBadAttempts = False
    End Sub

    Public Shared Property IsLockedDueToBadAttempts() As Boolean
        Get
            Return System.Web.HttpContext.Current.Session("IsLockedDueToBadAttempts")
        End Get
        Set(value As Boolean)
            System.Web.HttpContext.Current.Session("IsLockedDueToBadAttempts") = value
        End Set
    End Property

    Public Shared Property PasswordErrorMessage() As String
        Get
            Return System.Web.HttpContext.Current.Session("PasswordErrorMessage")
        End Get
        Set(value As String)
            System.Web.HttpContext.Current.Session("PasswordErrorMessage") = value
        End Set
    End Property

    Public Shared Property ResetPasswordEmailAddress() As String
        Get
            Return System.Web.HttpContext.Current.Session("ResetPasswordEmailAddress")
        End Get
        Set(value As String)
            System.Web.HttpContext.Current.Session("ResetPasswordEmailAddress") = value
        End Set
    End Property

    Public Shared Property IsRedirectedFromAuthPage() As Boolean
        Get
            Return System.Web.HttpContext.Current.Session("IsRedirectedFromAuthPage")
        End Get
        Set(value As Boolean)
            System.Web.HttpContext.Current.Session("IsRedirectedFromAuthPage") = value
        End Set
    End Property

    Public Shared Property MyAppEntry() As razor.rowTblSystemAppEntry
        Get
            Return System.Web.HttpContext.Current.Session("AppEntry")
        End Get
        Set(value As razor.rowTblSystemAppEntry)
            System.Web.HttpContext.Current.Session("AppEntry") = value
        End Set
    End Property

End Class
