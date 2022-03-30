Imports System.Web
Imports System.Web.UI.Page


Public Class UtilCookieUser
    Public Const COOKIE_USER_COOKIENAME As String = "bd730fa0ff984709906224805565c5c5"
    Public Const COOKIE_USER_LOGINNAME As String = "LoginName"
    Public Const COOKIE_USER_GSAFEGUID As String = "GSafeGuid"
    Public Const COOKIE_USER_APPENTRYID As String = "AppEntryId"
    Private Const COOKIE_USER_EXPIRATIONDAYS As Integer = 30 * 1



    ''' <summary>
    ''' Get the user guid stored in the user cookie.  Returns nothing string if not found.
    ''' </summary>
    ''' <param name="pContext">A System.Web.UI.Page where the request originates.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCookieUserAppEntryId(ByRef pContext As HttpContext) As String
        Dim zReturn As String = Nothing
        If Not pContext.Request.Cookies(COOKIE_USER_COOKIENAME) Is Nothing Then
            If Not pContext.Request.Cookies(COOKIE_USER_COOKIENAME)(COOKIE_USER_APPENTRYID) Is Nothing Then
                zReturn = pContext.Request.Cookies(COOKIE_USER_COOKIENAME)(COOKIE_USER_APPENTRYID)
            End If
        End If
        Return zReturn
    End Function

    ''' <summary>
    ''' Get the user guid stored in the user cookie.  Returns nothing string if not found.
    ''' </summary>
    ''' <param name="pContext">A System.Web.UI.Page where the request originates.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCookieUserGSafeGuid(ByRef pContext As System.Web.UI.Page) As String
        Dim zReturn As String = Nothing
        If Not pContext.Request.Cookies(COOKIE_USER_COOKIENAME) Is Nothing Then
            If Not pContext.Request.Cookies(COOKIE_USER_COOKIENAME)(COOKIE_USER_GSAFEGUID) Is Nothing Then
                zReturn = pContext.Request.Cookies(COOKIE_USER_COOKIENAME)(COOKIE_USER_GSAFEGUID)
            End If
        End If
        Return zReturn
    End Function


    ''' <summary>
    ''' Get the user email stored in the user cookie.  Returns nothing string if not found.
    ''' </summary>
    ''' <param name="pContext">A System.Web.UI.Page where the request originates.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCookieUserLoginName(ByRef pContext As System.Web.UI.Page) As String
        Dim zReturn As String = Nothing
        If Not pContext.Request.Cookies(COOKIE_USER_COOKIENAME) Is Nothing Then
            If Not pContext.Request.Cookies(COOKIE_USER_COOKIENAME)(COOKIE_USER_LOGINNAME) Is Nothing Then
                zReturn = pContext.Request.Cookies(COOKIE_USER_COOKIENAME)(COOKIE_USER_LOGINNAME)
            End If
        End If
        Return zReturn
    End Function


    ''' <summary>
    ''' Sets the user guid in the user cookie.
    ''' </summary>
    ''' <param name="pContext">A System.Web.UI.Page where the request originates.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function SetCookieUser(ByRef pContext As System.Web.UI.Page, pGSafeGuid As String, pLoginName As String, pAppEntryId As Integer) As Boolean
        Dim zReturn As Boolean = True
        Try
            Dim zCookie As HttpCookie = New HttpCookie(COOKIE_USER_COOKIENAME)
            zCookie(COOKIE_USER_GSAFEGUID) = pGSafeGuid
            zCookie(COOKIE_USER_LOGINNAME) = pLoginName
            zCookie(COOKIE_USER_APPENTRYID) = pAppEntryId.ToString()
            zCookie.Expires = Now.AddDays(COOKIE_USER_EXPIRATIONDAYS)
            pContext.Response.Cookies.Add(zCookie)

        Catch ex As Exception
            zReturn = False

        End Try
        Return zReturn
    End Function


    ''' <summary>
    ''' Deletes the user cookie.
    ''' </summary>
    ''' <param name="pContext">A System.Web.UI.Page where the request originates.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DeleteCookieUser(ByRef pContext As System.Web.UI.Page) As Boolean
        Dim zReturn As Boolean = True
        Try
            Dim zCookie As HttpCookie = New HttpCookie(COOKIE_USER_COOKIENAME)
            zCookie.Expires = Now.AddDays(-1D)
            pContext.Response.Cookies.Add(zCookie)

        Catch ex As Exception
            zReturn = False

        End Try
        Return zReturn
    End Function



End Class
