
Public Class UtilSAID
    Public Shared Function IsNotSecure(ByVal pKey1 As String, ByVal pKey2 As String) As Boolean
        Dim zReturn As Boolean = False
        Try
            If pKey1.Length > 0 Then
                If pKey2.Length > 0 Then

                    ' CHECK THE KEY
                    If pKey1 = pKey2 Then
                        If UtilGSafe.GetId(pKey1) > 0 Then
                            zReturn = True
                        Else
                            zReturn = False
                        End If
                    Else
                        zReturn = False
                    End If

                End If
            End If

        Catch ex As Exception
            'eat the exception - one of the parameters must be nothing; leave the default value of zReturn as False
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "SAID IsNotSecure"
            zErrLogError.UserEmail = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.LoggedInUserEmail) & ""
            zErrLogError.MessageOuter = "SAID IsNotSecure Error: Key1=" & pKey1 & " | Key2=" & pKey2 & " | Message= " & ex.Message
            zErrLogError.CreateErrorLogRecord()

        End Try

        Return Not zReturn  'Flip the return value since the function is defined as the negative condition
    End Function


    Public Shared Function IsNotSecureWithCookie(ByVal pKey1 As String, ByVal pKey2 As String, ByRef pContext As System.Web.UI.Page) As Boolean
        Dim zReturn As Boolean = False
        Try
            If pKey1.Length > 0 Then
                If pKey2.Length > 0 Then

                    ' CHECK THE KEY
                    If pKey1 = pKey2 Then
                        If UtilGSafe.GetId(pKey1) > 0 Then
                            zReturn = True
                        Else
                            zReturn = False
                        End If
                    Else
                        zReturn = False
                    End If

                    ' CHECK THE COOKIE
                    Dim zCookieGSafeGuid As String = UtilCookieUser.GetCookieUserGSafeGuid(pContext)
                    If Not zCookieGSafeGuid Is Nothing Then
                        If zCookieGSafeGuid.Length > 0 Then
                            If zCookieGSafeGuid = pKey1 Then
                                If UtilGSafe.GetId(pKey1) > 0 Then
                                    zReturn = True
                                Else
                                    zReturn = False
                                End If
                            Else
                                zReturn = False
                            End If
                        Else
                            zReturn = False
                        End If
                    Else
                        zReturn = False
                    End If

                End If
            End If

        Catch ex As Exception
            'eat the exception - one of the parameters must be nothing; leave the default value of zReturn as False
            Dim zErrLogError As New UtilErrorLog
            zErrLogError.DateOccured = Now
            zErrLogError.ErrorType = "SAID IsNotSecure"
            zErrLogError.UserEmail = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.LoggedInUserEmail) & ""
            zErrLogError.MessageOuter = "SAID IsNotSecure Error: Key1=" & pKey1 & " | Key2=" & pKey2 & " | Message= " & ex.Message
            zErrLogError.CreateErrorLogRecord()

        End Try

        Return Not zReturn  'Flip the return value since the function is defined as the negative condition
    End Function

End Class
