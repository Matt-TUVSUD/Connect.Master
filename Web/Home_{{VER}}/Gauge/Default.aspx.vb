Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.CoreLib.UtilConstants

Public Class DefaultGauge

    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(UtilGSafe.GetGUIDFromQueryString(), PageId_Gauge, "")
    End Sub

    Private Sub loadLists()

    End Sub

    Private Sub loadDefaults()

        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeID As Integer = UtilGSafe.GetId(zSafeGUID)

        'lblGaugeCompanyName.Text = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.ClientName)

        ' Beginning with the Rec Redesign release, leave these users here on this page.
        'If UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.SingleUser) = "True" Then
        '    Response.Redirect(UtilLogin.SingleLocationPracticeURL(zSafeGUID))
        'End If

        If UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.DocumentAccess) = "True" Then
            UtilGSafe.ClearLocationNavigationInformation(zSafeGUID)
            UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentGridId, "60", UtilGSafe.KeyNameGroup.Navigation)
            Response.Redirect(UtilLogin.DocumentAccessURL(zSafeGUID))
        End If

        ' SET NAVIGATION GSAFE VALUES
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentTab, "1", UtilGSafe.KeyNameGroup.Navigation)

        ' CLEAR THE FILTER OBJECTS IN THE LARGE OBJECTS TABLE
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.filter)
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.filterChart)
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.virtualFilter)
        UtilSafe.ResetLargeObjectData_ByObjectName(zSafeID, UtilSafe.LargeObjectName.virtualFilterChart)

        If Request.Url.Query.Contains("SwitchRedirect") Then
            Redirect()
        End If

        '    If NewsDestination = "News" Then
        '        AutoRecRedirectHandler to navlinkid 963
        '        Response.Redirect("../WhatsNew/News.aspx?sid=" & zSafeGUID)
        '    Else

        '        ''redirect to thier landing page
        '    End If
    End Sub

    Private Sub loadData()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If

        Call loadData()

    End Sub

    Public Sub Redirect()

        Dim con As New SqlClient.SqlConnection(UtilDB.ConnectionString)
        Dim cmd As New SqlClient.SqlCommand("spGetLandingPageUrl", con)
        cmd.Parameters.AddWithValue("@sid", UtilGSafe.GetGUIDFromQueryString())
        cmd.CommandType = CommandType.StoredProcedure
        If con.State <> ConnectionState.Open Then con.Open()

        Dim rdr As SqlClient.SqlDataReader = Nothing
        Dim url As String = ""
        Using con
            Using cmd
                rdr = cmd.ExecuteReader()
                If rdr.HasRows Then
                    rdr.Read()
                    url = rdr("NavUrl").ToString()
                End If
            End Using
        End Using

        UtilFunction.AppendQueryString(url)

        If Not url.Contains("Gauge") Then
            Response.Redirect(url)
        End If

    End Sub

End Class