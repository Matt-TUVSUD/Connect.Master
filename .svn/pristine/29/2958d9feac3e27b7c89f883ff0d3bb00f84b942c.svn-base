Public Class UtilURL

    Public Shared Function BuildLeftNavURL(pNavLinkId As Integer, pNavLinkURL As String, pSafeGUID As String) As String
        Dim zReturn As String = ""

        If InStr(pNavLinkURL, "?") > 0 Then
            zReturn = UtilNav.ReplaceBaseString(pNavLinkURL, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}") & "&sid=" & pSafeGUID & "&navLinkId=" & pNavLinkId
        Else
            zReturn = UtilNav.ReplaceBaseString(pNavLinkURL, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}") & "?sid=" & pSafeGUID & "&navLinkId=" & pNavLinkId
        End If

        ' CORRECT NEW FOLDER VERSIONING OF HOME AND REC RESPONSE FOLDERS
        zReturn = zReturn.Replace("/Home/", "/Home_{{VER}}/")
        zReturn = zReturn.Replace("/RecResponse/", "/RecResponse_{{VER}}/")

        Return zReturn
    End Function


    'Public Shared Function CreateURL(pCurrentUrl As String, pURLType As ApplicationURL, Optional pRRLogID As Integer = Nothing) As String
    '    Dim zReturn As String = ""
    '    Dim zHost As String = ""
    '    Dim zLog As New UtilLog
    '    Dim zUrl As String = ""
    '    Dim zGuid As String = Guid.NewGuid.ToString

    '    zLog.LogIt("Generating " & pURLType.ToString & " for RRLogID# " & pRRLogID)
    '    zLog.LogIt("The current link is: " & IIf(pCurrentUrl = "", "<EMPTY>", pCurrentUrl))

    '    If Libraries.CoreLib.UtilSystemParms.InDevMode Then
    '        zHost = "http://susnjcu01030/Connect"
    '    Else
    '        zHost = Libraries.CoreLib.UtilSystemParms.ReadEmailReturnURL
    '    End If

    '    'IF THE CURRENT URL IS EMPTY
    '    If pCurrentUrl = String.Empty Then
    '        If pURLType = ApplicationURL.AutoRecUrl Then
    '            'RETURN THE AUTOREC URL
    '            'THE REASON FOR HARDCODING IS BECAUSE THE MAINTENANCE SERVICE NEEDS TO SEND URLS FOR AUTOREC AND LOGIN TO THE DATABASE.
    '            'IF WE WERE TO SPECIFY A VALUE IN THE WEBAPPBASE ('APP/TEST') APPSETTING, THEN THE REPORTURL BUILDER WOULD BE INCORRECT.
    '            'IT WE DONT SPECIFY A VALUE IN THW WEBAPPBASE APPSETTING, THEN THE REPORT BUILDER WOULD WORK, BUT INCORRECT AUTOREC LINKS WOULD BE SENT.

    '            If UtilSystemParms.InLiveMode Then
    '                zUrl = zHost & "/RecResponse/Auth/?p1=" & zGuid
    '            ElseIf UtilSystemParms.InTestMode Then
    '                zUrl = zHost & "/RecResponse/Auth/?p1=" & zGuid
    '            Else
    '                zUrl = zHost & "/RecResponse/Auth/?p1=" & zGuid
    '            End If

    '            zLog.LogIt("Saving RRLink: " & pCurrentUrl)
    '            SaveLinkToRR(pRRLogID, zGuid, zUrl)

    '        Else
    '            zUrl = zHost & "/Home/Auth/"
    '        End If

    '        zReturn = zUrl

    '    Else  'ELSE THE CURRENTlink IS NOT EMPTY
    '        If pCurrentUrl.Contains(UtilNav.NavLinkPlaceholder) Then
    '            zReturn = zHost & UtilNav.ReplaceBaseString(pCurrentUrl, "/")
    '        Else
    '            'IF WE ARE CALLING THIS PORTION OF THE CODE, THE ADMIN IS RESENDING A CURRENTLINK, OR RUNNING ANOTHER FOLLOWUP
    '            'IF THERE IS ALREADY A URL DEFINED IN THE RRLOG RECORD, WE NEED TO MAKE SURE WE ARE RETURNING THE URL AS DEFINED BY
    '            'THE WEBAPPMODE. THIS IS BECAUSE RECORDS FROM LIVE ARE COPIED TO TEST AND DEV AND THE LINKS, IF RESENT FROM TEST OR DEV, WOULD BE INCORRECT.
    '            ' IF THE APPLICATION IS INOT IN LIVE MODE, WE NEED TO MODIFY FOR CURRENT ENVIRONMENT.
    '            If Not Libraries.CoreLib.UtilSystemParms.InLiveMode Then
    '                zLog.LogIt("Changing URL for current environment.")
    '                Dim zRR As New BusinessObjects.RRLog
    '                If zRR.LoadByPrimaryKey(pRRLogID) Then
    '                    zLog.LogIt("Loading RRLog# " & pRRLogID)

    '                    If UtilSystemParms.InTestMode Then
    '                        zUrl = zHost & "/RecResponse/Auth/?p1=" & zRR.RRLogGuid
    '                    Else
    '                        zUrl = zHost & "/RecResponse/Auth/?p1=" & zRR.RRLogGuid
    '                    End If

    '                    zRR.CurrentLink = zUrl
    '                    zRR.Save()
    '                    zReturn = zUrl

    '                Else
    '                    zLog.LogIt("Could not load RRLog# " & pRRLogID)
    '                End If

    '            Else
    '                zLog.LogIt("No changes to the URL is being made.")
    '                zReturn = pCurrentUrl
    '            End If
    '        End If
    '    End If

    '    zLog.LogIt("Return URL: " & zReturn)

    '    Return zReturn

    'End Function

    'Public Shared Sub SaveLinkToRR(ByVal pRRLogId As Integer, ByVal pRRGuid As String, ByVal pLink As String)
    '    Dim zRR As New BusinessObjects.RRLog
    '    If zRR.LoadByPrimaryKey(pRRLogId) Then
    '        zRR.RRLogGuid = pRRGuid
    '        zRR.CurrentLink = pLink
    '        zRR.Save()
    '    End If
    'End Sub

    'Public Enum ApplicationURL
    '    AutoRecUrl
    '    ApplicationUrl
    'End Enum

    Public Shared Function GetHomeFolder() As String
        Return "{{VER}}"
    End Function

End Class
