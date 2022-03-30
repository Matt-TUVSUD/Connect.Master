Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Public Class _RecResponse_Redirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'GET FILENO, CLIENTFEATURES, USERFULLNAME, AND ANY OTHER INFO
        Dim zObjLog As New RRLog
        Dim zQryLog As New RRLogQuery
        Dim zObjClient As New Clients
        Dim zQryClient As New ClientsQuery
        Dim zRRGuid As String = Request.QueryString("p1")
        Dim zId As Integer = 0
        Dim zPracticeCode As Integer = 0
        Dim zPracticeName As String = ""
        Dim zPageName As String = ""
        Dim zFileNo As String = ""
        Dim zFilePrefix As Integer = 0
        Dim zFileName As String = "rectracking.aspx"
        Dim zFullName As String = Session("RecResponse_FullName")
        Dim zEmailAddress As String = Session("RecResponse_EmailAddress")
        Dim zClientFeatures As String = ""

        'GET THE RRLOG
        zQryLog.Select()
        zQryLog.Where(zQryLog.RRLogGuid = zRRGuid)
        If zObjLog.Load(zQryLog) Then
            'SAVE LOCAL DATA
            zPracticeCode = zObjLog.PracticeCode
            zPracticeName = zObjLog.Hazard
            zFileNo = zObjLog.FileNo
            zFilePrefix = zObjLog.FilePrefix
            zId = zObjLog.Id

            'UPDATE THE RRLOG RECORD TO CURRENT DATA
            zObjLog.LinkActivatedDate = Now()
            zObjLog.LinkActivatedBy = zFullName
            zObjLog.LinkActivatedByEmail = zEmailAddress
            zObjLog.ResponseActive = True
            zObjLog.Activity = "ADMIN"
            zObjLog.Save()
        End If

        'GET THE PRACTIVE OR HAZARD NAME
        Select Case zPracticeCode
            Case 520
                zPracticeName = "fire"
                zPageName = "Fire Program"
            Case 525
                zPracticeName = "fire"
                zPageName = "Fire Program"
            Case 510
                zPracticeName = "boiler"
                zPageName = "Boiler & Machinery Program"
            Case 515
                zPracticeName = "boiler"
                zPageName = "Boiler & Machinery"
            Case 529
                zPracticeName = "selfaudit"
                zPageName = "Fire-SA"
            Case 530
                zPracticeName = "infrared"
                zPageName = "Infrared Program"
            Case 535
                zPracticeName = "infrared"
                zPageName = "Infrared Program"
            Case 560
                zPracticeName = "juris"
                zPageName = "Jurisdictional Program"
            Case 565
                zPracticeName = "juris"
                zPageName = "Jurisdictional Program"
            Case 550, 555
                'zPracticeName = "nathaz"
                zPageName = "Natural Hazards Program"
                zPracticeName = "naturalhazards"
            Case 570
                zPracticeName = "processsafety"
                zPageName = "Process Safety Program"
            Case 575
                zPracticeName = "processsafety"
                zPageName = "Process Safety Program"
            Case 577
                zPracticeName = "processsafety"
                zPageName = "Process Safety Program"
            Case Else
                zPageName = zPracticeName & " Program"
                If zPracticeName.ToLower() <> "seismic" And zPracticeName.ToLower() <> "wind" And zPracticeName.ToLower() <> "flood" Then
                    zPracticeName = "fire"
                    zPageName = "Fire Program"
                End If

        End Select

        'SETUP SESSION VARS TO PASS INFORMATION
        'FULL NAME AND EMAIL ADDRESS SET ON PREVIOUS LOGIN PAGE
        Session("RecResponse_FileNo") = zFileNo
        Session("RecResponse_FilePrefix") = zFilePrefix.ToString()
        Session("RecResponse_PageName") = zPageName
        Session("RecResponse_PracticeName") = zPracticeName
        Session("RecResponse_RRLogId") = zId
        Session("RecResponse_RRLogGuid") = zRRGuid

        'GET THE CUSTOM FEATURES FOR THE FILE NAME
        zQryClient.Select()
        zQryClient.Where(zQryClient.Fileprefix = zFilePrefix)
        If zObjClient.Load(zQryClient) Then
            zClientFeatures = zObjClient.Features
            If Not zClientFeatures Is Nothing Then
                'DB - THIS CUSTOM FEATURE ONLY APPLIES TO THE FIRE PRACTICE
                If zClientFeatures.Contains("X") And zPracticeName = "fire" Then
                    zFileName = "rectrackingfeaturesX.aspx"
                End If
            Else
                zClientFeatures = ""
            End If
        End If
        Session("RecResponse_ClientFeatures") = zClientFeatures.ToUpper()

        'REDIRECT TO THE CORRECT HAZARD AND CORRECT SPECIAL FEATURES PAGE
        'Response.Redirect("~/RecResponse_{{VER}}/" & zPracticeName & "/" & zFileName & "?n1=" & zFullName & "&f1=" & zClientFeatures & "&p1=" & zFileNo & "&e1=" & zEmailAddress, True)
        'Response.Redirect("~/RecResponse_{{VER}}/" & zPracticeName & "/" & zFileName & "?p1=" & zRRGuid, True)
        Response.Redirect("~/RecResponse_{{VER}}/Recommendations/RecommendationResponse.aspx" & "?sid=" & zRRGuid & "&p1=" & zFileNo & "&p2=" & zPracticeName, True)

    End Sub

End Class