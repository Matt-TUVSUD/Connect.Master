Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilURL

    Public Shared Function BuildLeftNavURL(pNavLinkURL As String, pSafeGUID As String) As String
        Dim zReturn As String = ""

        If InStr(pNavLinkURL, "?") > 0 Then
            zReturn = UtilNav.ReplaceBaseString(pNavLinkURL, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}") & "&sid=" & pSafeGUID
        Else
            zReturn = UtilNav.ReplaceBaseString(pNavLinkURL, UtilSystemParms.ReadWebAppBaseURL & "Home_{{VER}}") & "?sid=" & pSafeGUID
        End If

        ' CORRECT NEW FOLDER VERSIONING OF HOME AND REC RESPONSE FOLDERS
        zReturn = zReturn.Replace("/Home/", "/Home_{{VER}}/")
        zReturn = zReturn.Replace("/RecResponse/", "/RecResponse_{{VER}}/")

        Return zReturn
    End Function

    Public Shared Function BuildAppUrl() As String
        'Dim zHost As String = UtilSystemParms.ReadEmailReturnURL
        'Return zHost & "/Home/Auth/"

        Return UtilSetting.GetAppBaseURL
    End Function

    <Obsolete("Use new overloaded method BuildAutoRecURL(pRequest,pRRLog,pCreateNewLink)", True)>
    Public Shared Function BuildAutoRecURL(pRRLog As rowTblRRLog) As String

        Dim zReturn As String = ""
        Dim zHost As String = ""
        Dim zUrl As String = ""
        Dim zGuid As String = Guid.NewGuid.ToString

        If UtilSystemParms.InDevMode Then
            zHost = "http://susnjcu01030/Connect"
        Else
            zHost = UtilSystemParms.ReadEmailReturnURL
        End If

        'IF THE CURRENT URL IS EMPTY
        If pRRLog.colCurrentLink = String.Empty Then
            zUrl = zHost & "/RecResponse/Auth/?p1=" & zGuid
            pRRLog.colCurrentLink = zUrl
            pRRLog.colRRLogGuid = zGuid
            TblRRLog.Save(pRRLog)
            zReturn = zUrl
        Else  'ELSE THE CURRENTlink IS NOT EMPTY
            If pRRLog.colCurrentLink.Contains(UtilNav.NavLinkPlaceholder) Then
                zReturn = zHost & UtilNav.ReplaceBaseString(pRRLog.colCurrentLink, "/")
            Else
                'IF WE ARE CALLING THIS PORTION OF THE CODE, THE ADMIN IS RESENDING A CURRENTLINK, OR RUNNING ANOTHER FOLLOWUP
                'IF THERE IS ALREADY A URL DEFINED IN THE RRLOG RECORD, WE NEED TO MAKE SURE WE ARE RETURNING THE URL AS DEFINED BY
                'THE WEBAPPMODE. THIS IS BECAUSE RECORDS FROM LIVE ARE COPIED TO TEST AND DEV AND THE LINKS, IF RESENT FROM TEST OR DEV, WOULD BE INCORRECT.
                ' IF THE APPLICATION IS INOT IN LIVE MODE, WE NEED TO MODIFY FOR CURRENT ENVIRONMENT.

                If Not UtilSystemParms.InLiveMode Then
                    zUrl = zHost & "/RecResponse/Auth/?p1=" & pRRLog.colRRLogGuid
                End If

                zReturn = zUrl
            End If

            zReturn = pRRLog.colCurrentLink

        End If

        Return zReturn

    End Function

    Public Shared Function BuildAutoRecURL(pRequest As System.Web.HttpRequest, pRRLog As rowTblRRLog, pCreateNewLink As Boolean) As String

        Dim zURL As String = UtilSetting.GetRecResponseLoginUrl
        Dim zGUID As String = pRRLog.colRRLogGuid

        If pCreateNewLink Then
            zGUID = Guid.NewGuid.ToString()
        End If
        
        zURL = Replace(zURL, "{{RRGuid}}", zGUID)
        pRRLog.colCurrentLink = zURL
        pRRLog.colRRLogGuid = zGUID

        TblRRLog.Save(pRRLog)

        Return pRRLog.colCurrentLink

    End Function

End Class
