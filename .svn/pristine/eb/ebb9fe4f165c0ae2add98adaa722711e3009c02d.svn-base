Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilAutoRec
    Public Class Template

        Public Variables As TemplateVariables
        Public Template As rowTblEmailTemplate
        Public ARProcessType As UtilAutoRec.ProcessType

        Friend _Data As AutoRecData
        Friend _CurrentRRLog As rowTblRRLog

        ''' <summary>
        ''' Use this routine to set the variables for the AutoRec Logout, Initial and Daily FollowUps and the monthly Expiring Completion Alert
        ''' </summary>
        ''' <param name="pCurrentRRLog"></param>
        ''' <param name="pData"></param>
        ''' <remarks></remarks>
        Public Sub SetVariables(pCurrentRRLog As rowTblRRLog, pData As AutoRecData)
            Try

                Variables = New TemplateVariables(Me)

                _Data = pData
                _CurrentRRLog = pCurrentRRLog

                Dim zCurrentClient As rowVwRRClients = pData.FindClientByFilePrefix(pCurrentRRLog.colFilePrefix)
                Me.Variables.ClientName = zCurrentClient.colClientname

                'SET FOLLOWUP DAYS IF APPLICABLE
                Select Case ARProcessType

                    Case ProcessType.FollowUp1st, ProcessType.Initial
                        Variables.FollowUpDays = zCurrentClient.colRecfollowup1

                    Case ProcessType.FollowUp2nd
                        Variables.FollowUpDays = zCurrentClient.colRecfollowup2

                    Case ProcessType.FollowUp3rd
                        Variables.FollowUpDays = zCurrentClient.colRecfollowup3

                    Case Else
                        Variables.FollowUpDays = 0

                End Select

                'SET RETURN LINK
                If DoesEnvironmentMatchLink(_CurrentRRLog) Then
                    Variables.ReturnLink = "<a href='" & pCurrentRRLog.colCurrentLink & "'>CLICK HERE TO GO TO THE REC RESPONSE PAGE</a>"
                Else
                    If String.IsNullOrWhiteSpace(_CurrentRRLog.colCurrentLink) Then
                        CreateLink(_CurrentRRLog)
                    Else
                        AdjustLinkToCurrentEnvironment(_CurrentRRLog)
                    End If
                    Variables.ReturnLink = "<a href='" & pCurrentRRLog.colCurrentLink & "'>CLICK HERE TO GO TO THE REC RESPONSE PAGE</a>"
                End If


                'SET PRACTICE
                Select Case pCurrentRRLog.colPracticeCode
                    Case "520", "525", "526", "529"
                        Variables.Practice = TblMetaPractice.Practices.Fire
                    Case "510", "515", "519"
                        Variables.Practice = TblMetaPractice.Practices.BM
                    Case "530", "535", "539"
                        Variables.Practice = TblMetaPractice.Practices.Infrared
                    Case "550", "555", "559"
                        Variables.Practice = TblMetaPractice.Practices.NaturalHazards
                    Case "570", "575", "579"
                        Variables.Practice = TblMetaPractice.Practices.ProcessSafety

                End Select

                'SET OTHER PROPERTIES
                Variables.RecipientFullName = pCurrentRRLog.colRecipientName
                Variables.DateStamp = pCurrentRRLog.colDateStamp
                Variables.InspectionDate = pData.FindLastInspectionDate(Variables.Practice, pCurrentRRLog.colFileNo)
                Variables.Location = pData.FindLocation(pCurrentRRLog.colFileNo)
                DoReplacements()

            Catch ex As Exception
                Dim zEx As New ArgumentException("Exception occurred while trying to set variables for daily followups.", ex)
                zEx.Data.Add("RRLogId", pCurrentRRLog.colId)
                zEx.Data.Add("FilePrefix", pCurrentRRLog.colFilePrefix)
                zEx.Data.Add("Client", pData.FindClientByFilePrefix(pCurrentRRLog.colFilePrefix).colClientname)

                Throw zEx
            End Try

        End Sub

        ''' <summary>
        ''' Use this routine for the monthly followups
        ''' </summary>
        ''' <param name="pFilePrefix"></param>
        ''' <param name="pData"></param>
        ''' <remarks></remarks>
        Public Sub SetVariables(pFilePrefix As String, pPractice As TblMetaPractice.Practices, pData As AutoRecData)
            Try


                Variables = New TemplateVariables(Me)

                _Data = pData
                _CurrentRRLog = Nothing

                Dim zCurrentClient As rowVwRRClients = pData.FindClientByFilePrefix(pFilePrefix)
                Me.Variables.ClientName = zCurrentClient.colClientname

                'SET FOLLOWUP DAYS IF APPLICABLE
                Select Case ARProcessType

                    Case ProcessType.Overdue1st, ProcessType.FollowUp1st
                        Variables.FollowUpDays = zCurrentClient.colRecfollowup1

                    Case ProcessType.Overdue2nd, ProcessType.FollowUp2nd
                        Variables.FollowUpDays = zCurrentClient.colRecfollowup2

                    Case ProcessType.Overdue3rd, ProcessType.FollowUp3rd
                        Variables.FollowUpDays = zCurrentClient.colRecfollowup3

                    Case Else
                        Variables.FollowUpDays = 0

                End Select

                'SET RETURN LINK
                Variables.ReturnLink = "<a href='" & UtilURL.BuildAppUrl() & "'>CLICK HERE TO ACCESS THE CLIENT DATABASE</a>"

                'SET PRACTICE
                Variables.Practice = pPractice

                DoReplacements()

            Catch ex As Exception
                Dim zEx As New ArgumentException("Exception occurred while trying to set variables for monthly followups.", ex)
                zEx.Data.Add("FilePrefix", pFilePrefix)
                zEx.Data.Add("Client", pData.FindClientByFilePrefix(pFilePrefix).colClientname)
                Throw zEx
            End Try

        End Sub


        Private Sub DoReplacements()
            Dim zV As Dictionary(Of String, Object) = Variables.Placeholders
            For Each zKey As String In zV.Keys
                Template.colFldBody = Replace(Template.colFldBody, zKey, zV(zKey))
                Template.colFldSubject = Replace(Template.colFldSubject, zKey, zV(zKey))
            Next
        End Sub

        Public ReadOnly Property Data As AutoRecData
            Get
                Return _Data
            End Get
        End Property

        Public Function DoesEnvironmentMatchLink(pRRLog As rowTblRRLog) As Boolean

            If String.IsNullOrWhiteSpace(pRRLog.colCurrentLink) Then
                Return False 'IF NO LINK, THEN RETURN FALSE.  RRLOG SHOULD HAVE A LINK
            Else
                Dim zAppAuthority As String = UtilSetting.GetAppAuthority
                If pRRLog.colCurrentLink.ToLower.Contains(zAppAuthority) Then
                    Return True
                Else
                    Return False
                End If
            End If

        End Function

        Public Sub AdjustLinkToCurrentEnvironment(ByRef pRRLog As rowTblRRLog)
            Dim zAutoRecURL As String = UtilSetting.GetRecResponseLoginUrl
            pRRLog.colCurrentLink = Replace(zAutoRecURL, "{{RRGuid}}", pRRLog.colRRLogGuid)
        End Sub

        Public Sub CreateLink(ByRef pRRLog As rowTblRRLog)
            If String.IsNullOrEmpty(pRRLog.colRRLogGuid) Then pRRLog.colRRLogGuid = Guid.NewGuid.ToString
            If String.IsNullOrWhiteSpace(pRRLog.colCurrentLink) Then pRRLog.colCurrentLink = UtilSetting.GetRecResponseLoginUrl
            pRRLog.colCurrentLink = Replace(pRRLog.colCurrentLink, "{{RRGuid}}", pRRLog.colRRLogGuid)
            TblRRLog.Save(pRRLog)
        End Sub

    End Class
End Class




