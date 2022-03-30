Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilSafe

Public Class ReportsDefaultPage
    Inherits System.Web.UI.Page

    Public ServerSide_URL As String = ""

    Dim zFileNo As String
    Dim zGSafeGuid As String

    'by default redirect all requests to the handler for processing reports
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        zGSafeGuid = GetGUIDFromQueryString()
        ' The next two values are the fileno and practiceID that we are coming FROM.  So, if we are coming from the location details page, the fileno and practice will be in these variables
        zFileNo = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo)
        Dim zMetaPracticeId As String = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.MetaPracticeId)

        If zFileNo.Length > 0 Then
            Dim folder As String
            Select Case zMetaPracticeId
                Case "2"
                    folder = "Boiler"
                Case "3"
                    folder = "Fire"
                Case "4"
                    folder = "Infrared"
                Case "5"
                    folder = "Jurisdictional"
                Case "9"
                    folder = "NaturalHazards"
                Case "10"
                    folder = "Diversified"
                Case "11"
                    folder = "ProcessSafety"
                Case Else
                    folder = ""
            End Select

            btn.Text = "Back To FileNo " + zFileNo
            Dim str As String = "onEnterLocation('" + zFileNo + "','" + folder + "');return false;"
            btn.OnClientClick = str
        Else
            btn.Visible = False
        End If

        'THIS SNIPPET OF CODE DETERMINES HOW DEEP WE ARE IN THE REFERRED URL SO THAT THE CLOSE BUTTON ON THE REPORTFETCH & PREFILTER PAGE CAN FIND THE BLANK.ASPX PAGE.
        'Dim zLevelsDeep As Integer = 1
        'If Not IsNothing(Request.UrlReferrer) AndAlso Request.UrlReferrer.ToString.ToLower.Contains("/grids/") Then
        '    zLevelsDeep = 2
        'End If

        'Response.Redirect("ReportHandler.ashx?" & Request.QueryString.ToString & "&levels=" & zLevelsDeep)
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        UtilGSafe.SetValue(zGSafeGuid, UtilGSafe.KeyName.FileNo, zFileNo, UtilGSafe.KeyNameGroup.LocationSelection)
        If zFileNo.Length > 0 Then      ' We came from a location details page so reset that flag to true
            UtilGSafe.SetValue(zGSafeGuid, UtilGSafe.KeyName.IsOnDetailPage, True, UtilGSafe.KeyNameGroup.LocationSelection)
        End If

    End Sub

End Class