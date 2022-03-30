Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilValidate

    'USE THIS CLASS FOR ANY VALIDATION OR SANITY CHECKS

    Public Shared Function IsCorrectPage(ByVal pGuid As String, ByVal pPage As String) As Boolean
        Dim zReturn As Boolean = False
        Dim zGSafeCurrentPage As String

        'CHECK THE CURRENT PAGE, IF IT IS DIFFERENT RETURN FALSE
        zGSafeCurrentPage = UtilGSafe.GetValue(pGuid, UtilGSafe.KeyName.currentPage)
        If Not zGSafeCurrentPage = pPage Then
            zReturn = False
        Else
            zReturn = True
        End If

        Return zReturn

    End Function

    Public Shared Sub CorrectPageCheck(ByVal pGuid As String, ByVal pPage As String, ByVal pPractice As String)
        'CHECK THE CURRENT PAGE IN THE GSAFE, IF IT IS DIFFERENT, UPDATE THE GSAFE TO THE PARM
        If Not IsCorrectPage(pGuid, pPage) Then
            UtilGSafe.SetValue(pGuid, UtilGSafe.KeyName.currentPage, pPage, UtilGSafe.KeyNameGroup.Navigation)
            If pPractice <> "" Then
                UtilGSafe.SetValue(pGuid, UtilGSafe.KeyName.currentTab, pPractice, UtilGSafe.KeyNameGroup.Navigation)
            End If
        End If

    End Sub

    'CUSTOM VALUE EXIST CHECK FUNCTIONS
    Public Shared Function IsNothingCustom(ByVal pValue As Object) As Boolean
        Dim zReturn = False
        Try
            If Not IsNothing(pValue) Then
                zReturn = True
            End If
        Catch ex As Exception
            zReturn = False
        End Try
        Return zReturn
    End Function

    Public Shared Function ValidateEmailAddresses() As List(Of String)

        Dim zEzyUsers As List(Of rowTblEzyUsers) = TblEzyUsers.LoadData
        Dim zEzyLogins As List(Of rowTblEzyLogin) = TblEzyLogin.LoadData
        Dim zRRLogs As List(Of rowTblRRLog) = TblRRLog.LoadData
        Dim zInvalidAddresses As New List(Of String)

        For Each zUser As rowTblEzyUsers In zEzyUsers
            Try
                If Not String.IsNullOrEmpty(zUser.colEmail) Then
                    Dim zAddress As New System.Net.Mail.MailAddress(zUser.colEmail, zUser.colFullName)
                End If
            Catch ex As Exception
                zInvalidAddresses.Add("Invalid EzyUser Email - EzyUserID: " & zUser.colEzyUserID & " [" & zUser.colEmail & ", " & zUser.colFullName & "]")
            End Try
        Next

        For Each zLogin As rowTblEzyLogin In zEzyLogins
            Try
                If Not String.IsNullOrEmpty(zLogin.colEmailAddress) Then
                    Dim zAddress As New System.Net.Mail.MailAddress(zLogin.colEmailAddress, zLogin.colFullName)
                End If
            Catch ex As Exception
                zInvalidAddresses.Add("Invalid EzyLogin EmailAddress - LoginID: " & zLogin.colLoginID & " [" & zLogin.colEmailAddress & ", " & zLogin.colFullName & "]")
            End Try
        Next


        For Each zRR As rowTblRRLog In zRRLogs
            Try
                If Not String.IsNullOrEmpty(zRR.colRecipientEmail) Then
                    Dim zAddress As New System.Net.Mail.MailAddress(zRR.colRecipientEmail, zRR.colRecipientName)
                End If
            Catch ex As Exception
                zInvalidAddresses.Add("Invalid RRLog RecipientEmail - ID: " & zRR.colId & " [" & zRR.colRecipientEmail & ", " & zRR.colRecipientName & "]")
            End Try
        Next

        For Each zRR As rowTblRRLog In zRRLogs
            Try
                If Not String.IsNullOrEmpty(zRR.colLinkActivatedByEmail) Then
                    Dim zAddress As New System.Net.Mail.MailAddress(zRR.colLinkActivatedByEmail, zRR.colLinkActivatedBy)
                End If
            Catch ex As Exception
                zInvalidAddresses.Add("Invalid RRLog LinkActivatedEmail - ID: " & zRR.colId & " [" & zRR.colLinkActivatedByEmail & ", " & zRR.colLinkActivatedBy & "]")
            End Try
        Next

        Return zInvalidAddresses

    End Function

End Class
