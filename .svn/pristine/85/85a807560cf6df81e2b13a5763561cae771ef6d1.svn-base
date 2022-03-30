Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilBatchProcess

    Public Sub ProcessEmails()

        Dim zEmails As List(Of rowTblBatchProcessingEmail) = TblBatchProcessingEmail.LoadUnsent
        Dim zSubmitter As GRC.EmailManagement.Client.EmailSubmitter = Nothing

        If UtilSystemParms.InLiveMode Then
            zSubmitter = New GRC.EmailManagement.Client.EmailSubmitter(GetEmailConnectionString, "GRC.Connect.BatchProcessor", EmailManagement.Client.MailMessage.EmailMsgEnvironment.Live)
        Else
            zSubmitter = New GRC.EmailManagement.Client.EmailSubmitter(GetEmailConnectionString, "GRC.Connect.BatchProcessor", EmailManagement.Client.MailMessage.EmailMsgEnvironment.Test)
        End If

        For Each zEmail As rowTblBatchProcessingEmail In zEmails
            Try
                Dim zMsgProps As New GRC.EmailManagement.Client.MailMessageProcessingProperties
                With zMsgProps
                    zMsgProps.To.Add(zEmail.colFldTo)
                    zMsgProps.Subject = zEmail.colFldSubject
                    zMsgProps.Body = WrapInDiv(ProcessLineBreaks(zEmail.colFldBody))
                    zMsgProps.From = New System.Net.Mail.MailAddress("grc-grcconnect@tuvsud.com", "GRC Connect")
                    zMsgProps.OrigProcess = "Batch Processing"
                End With

                Dim zMsg As System.Net.Mail.MailMessage = zMsgProps.ToMailMessage("Email Set: " & zEmail.colFldId)
                If Not String.IsNullOrEmpty(zEmail.colFldCc) Or Not String.IsNullOrWhiteSpace(zEmail.colFldCc) Then zMsg.CC.Add(zEmail.colFldCc)
                If Not String.IsNullOrEmpty(zEmail.colFldBcc) Or Not String.IsNullOrWhiteSpace(zEmail.colFldBcc) Then zMsg.Bcc.Add(zEmail.colFldBcc)

                Dim zEmailSets As List(Of rowTblBatchProcessingEmailSet) = TblBatchProcessingEmailSet.LoadByIDX_IX_fldEmailId(zEmail.colFldId)


                For Each zEmailSet As rowTblBatchProcessingEmailSet In zEmailSets
                    Dim zBatchSet As rowTblBatchProcessingSet = TblBatchProcessingSet.LoadByPrimaryKey(zEmailSet.colFldSetId)

                    If Not zBatchSet.colFldIsMyBatchReport Then  'MYBATCH REPORTS DO NOT HAVE THE PDF ATTACHMENT IN EMAIL
                        Dim zFiles As List(Of rowTblBatchProcessingFile) = TblBatchProcessingFile.LoadByIDX_IX_fldSetId(zEmailSet.colFldSetId)
                        For Each zFile As rowTblBatchProcessingFile In zFiles
                            Dim zMemStream As New IO.MemoryStream(zFile.colFldData)
                            Dim zAttachment As New System.Net.Mail.Attachment(zMemStream, zFile.colFldFileName & zFile.colFldExtension, zFile.colFldMime)
                            zMsg.Attachments.Add(zAttachment)
                        Next
                    End If

                Next

                zSubmitter.Submit(zMsg)

                zEmail.colFldSentDate = Now
                TblBatchProcessingEmail.Save(zEmail)

                WriteLog(0, "Emailing: " & zEmail.colFldSubject)

            Catch ex As Exception
                zEmail.colFldSentDate = Nothing
                zEmail.colFldHasException = True
                TblBatchProcessingEmail.Save(zEmail)
                Throw
            End Try

        Next

    End Sub

    Private Function ProcessLineBreaks(ByRef pText As String) As String
        Dim zRegex As String = "\<ol\>.+\<\/ol\>"
        pText = Replace(pText, vbNewLine, "<br>")

        Dim zMatches As Text.RegularExpressions.MatchCollection = Text.RegularExpressions.Regex.Matches(pText, zRegex)
        If zMatches.Count > 0 Then
            For Each zMatch As Text.RegularExpressions.Match In zMatches
                Dim zMatchString As String = zMatch.Value
                Dim zMatchReplacedString As String = Replace(zMatchString, "<br>", "")
                pText = Replace(pText, zMatchString, zMatchReplacedString)
            Next
        End If

        Return pText
    End Function

    Private Function WrapInDiv(ByVal pEmailTemplate As String) As String
        Dim zStyle As String = "<style>.myDiv, .myTable{font-family:calibri; font-size:10pt;}</style>"
        Return zStyle & "<div class='myDiv'>" & pEmailTemplate & "</div>"
    End Function

    Private Function GetEmailConnectionString()
        If UtilSystemParms.InLiveMode Then
            Return Configuration.ConfigurationManager.ConnectionStrings("EmailManagement.Live").ConnectionString
        Else
            Return Configuration.ConfigurationManager.ConnectionStrings("EmailManagement.Test").ConnectionString
        End If
    End Function

End Class
