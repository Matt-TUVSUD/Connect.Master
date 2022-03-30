Imports System.Web.Services
Imports GRC.Connect.Libraries.PowerBILib
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports System.Linq

Public Class Manage
    Inherits System.Web.UI.Page
    Public isDashboardPg As Boolean = False
    Public Shared Property GSafeID As String
    Protected Property DefaultURL As String = UtilSystemParms.ReadDashboardUrl

    Public Shared Property URLCreateNew As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        isDashboardPg = True
        lblMessageUserReports.Text = String.Empty
        GSafeID = If(Request.QueryString("sid"), String.Empty)
        lblMessage.Text = If(Not String.IsNullOrEmpty(GSafeID), String.Empty, Common.GSAFE_ID_REQUIRED)
        'txtNewReportName.Text = UtilGSafe.GetValue(GSafeID, UtilGSafe.KeyName.ClientName)

        ' DASHBOARD REDIRECT CODE TO INSERT GSAFEID INTO DIM USER
        Dim zGSafeGuid As String = GetGUIDFromQueryString()

        Dim zUserid As Integer = UtilGSafe.GetValue(zGSafeGuid, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogOtherActivity(zUserid, "Dashboard")

        Dim isDataInCloud As Boolean = UtilDB.DashboardDimUserUpdate(zGSafeGuid)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Set Create Report URL
        SetCreateReportURL()

        If Not IsPostBack Then

            'GetReportCategories - True parameter is used to exclude the UserReports Category.
            'ddlReportCategory.DataSource = DataHelper.GetReportCategories(True)
            'ddlReportCategory.DataBind()
            'ddlReportCategory.Items.Insert(0, New ListItem("Select", "-1"))
            'ddlReports.Items.Insert(0, New ListItem("Select", "-1"))
            'Dim setDefaultValue = ddlReportCategory.Items.FindByText(Common.DEFAULT_REPORT_CATEGORY)
            'If setDefaultValue IsNot Nothing Then ddlReportCategory.SelectedValue = setDefaultValue.Value
            'ddlReportCategory_SelectedIndexChanged(Nothing, Nothing)

            PopulateInternalReports()
            'Populate user reports
            PopulateUserReports()
        End If
    End Sub

    ''' <summary>
    ''' Set Create Report URL based on the DATASET ACCESS. if None of the entry found in UserDatasetAccess, Then return Default Dataset ID.
    ''' </summary>
    Private Sub SetCreateReportURL()
        'Check Default Dataset if null User cannot Perform Create report.
        Dim dsId = DataHelper.GetDefaultDataset(GSafeID)
        If Not String.IsNullOrEmpty(GSafeID) And dsId IsNot Nothing Then
            URLCreateNew = $"CreateNewReport.aspx?gsid={GSafeID}"
        Else
            URLCreateNew = "#"
            lblMessageUserReports.Text = Common.NO_DATASET_ACCESS
        End If
    End Sub

    Protected Sub PopulateInternalReports()
        Dim categoryID = 1

        If Not (String.IsNullOrEmpty(GSafeID)) Then

            Dim userInfo = DataHelper.GetUserInformation(GSafeID).AsEnumerable().Select(Function(row, index) New With {
            .RowIndex = index,
            .LoginId = row.Field(Of Integer)("LoginId")
        }).FirstOrDefault()

            lblMessage.Text = String.Empty
            '            ddlReports.Items.Clear()
            Dim invalidUser = False
            If (userInfo.LoginId > 0) Then
                Dim reports = DataHelper.GetAuthorizedReports(userInfo.LoginId, categoryID)
                If reports.Count > 0 Then
                    grcReports.DataSource = reports
                    grcReports.DataBind()

                    'ddlReports.DataSource = reports
                    'ddlReports.DataBind()
                    'Dim setDefaultValue = ddlReports.Items.FindByText(Common.DEFAULT_REPORT)
                    'If setDefaultValue IsNot Nothing Then
                    '    ddlReports.SelectedValue = setDefaultValue.Value

                    'End If
                    'Else
                    '    If categoryID <> -1 Then
                    '        invalidUser = True
                    '    End If
                End If
            Else
                invalidUser = True
            End If

            If invalidUser Then
                lblMessage.Text = Common.INVALID_USER

            End If
            'ddlReports.Items.Insert(0, New ListItem("Select", "-1"))


        End If

    End Sub

    Protected Sub ddlReportCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Dim categoryID = Convert.ToInt32(ddlReportCategory.SelectedValue)

        'If Not (String.IsNullOrEmpty(GSafeID)) Then

        '    Dim userInfo = DataHelper.GetUserInformation(GSafeID).AsEnumerable().Select(Function(row, index) New With {
        '    .RowIndex = index,
        '    .LoginId = row.Field(Of Integer)("LoginId")
        '}).FirstOrDefault()

        '    lblMessage.Text = String.Empty
        '    ddlReports.Items.Clear()
        '    Dim invalidUser = False
        '    If (userInfo.LoginId > 0) Then
        '        Dim reports = DataHelper.GetAuthorizedReports(userInfo.LoginId, categoryID)
        '        If reports.Count > 0 Then
        '            ddlReports.DataSource = reports
        '            ddlReports.DataBind()
        '            Dim setDefaultValue = ddlReports.Items.FindByText(Common.DEFAULT_REPORT)
        '            If setDefaultValue IsNot Nothing Then
        '                ddlReports.SelectedValue = setDefaultValue.Value

        '            End If
        '        Else
        '            If categoryID <> -1 Then
        '                invalidUser = True
        '            End If
        '        End If
        '    Else
        '        invalidUser = True
        '    End If

        '    If invalidUser Then
        '        lblMessage.Text = Common.INVALID_USER

        '    End If
        '    ddlReports.Items.Insert(0, New ListItem("Select", "-1"))
        'End If

    End Sub

    ''' <summary>
    ''' Populate User reports
    ''' </summary>
    Private Sub PopulateUserReports()
        Dim dt = DataHelper.GetUserReports(GSafeID)
        If (dt.Rows.Count > 0) Then
            userReports.DataSource = dt
            userReports.DataBind()

        Else
            lblMessageUserReports.Text = Common.NO_RECORDS
            lblMessageUserReports.ForeColor = Drawing.Color.Gray

        End If

    End Sub

    ''' <summary>
    ''' Update IsPublic flag for a report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnIsPubPriv_Click(sender As Object, e As EventArgs) Handles btnIsPubPriv.Click
        Dim invalidOperation = False
        Dim selectedReportId As String = txtSelectedReport.Text
        If Not (String.IsNullOrEmpty(GSafeID)) Then

            Dim userInfo = DataHelper.GetUserInformation(GSafeID).AsEnumerable().Select(Function(row, index) New With {
            .RowIndex = index,
            .LoginId = row.Field(Of Integer)("LoginId")
        }).FirstOrDefault()

            If (userInfo.LoginId > 0 And Not String.IsNullOrEmpty(selectedReportId)) Then
                Dim i As Integer = DataHelper.UpdateIsPublicFlag(userInfo.LoginId, Convert.ToInt32(selectedReportId))
                If (i = 0) Then
                    Response.Redirect(Request.Url.AbsoluteUri)
                Else
                    invalidOperation = True 'Invalid operation owner not matched
                End If
            Else
                invalidOperation = True

            End If
        End If
        If invalidOperation Then
            lblMessageUserReports.Text = Common.ERROR_MESSAGE
        End If
    End Sub

    ''' <summary>
    ''' Rename the report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnReportRename_Click(sender As Object, e As EventArgs) Handles btnReportRename.Click
        Dim invalidOperation = False
        Dim selectedReportId As String = txtSelectedReport.Text
        Dim newReportName As String = txtNewReportName.Text
        If Not (String.IsNullOrEmpty(GSafeID)) Then
            Dim userInfo = DataHelper.GetUserInformation(GSafeID).AsEnumerable().Select(Function(row, index) New With {
            .RowIndex = index,
            .LoginId = row.Field(Of Integer)("LoginId")
        }).FirstOrDefault()

            If (userInfo.LoginId > 0 And Not String.IsNullOrEmpty(selectedReportId)) Then
                Dim i As Integer = DataHelper.RenameReportNameById(userInfo.LoginId, Convert.ToInt32(selectedReportId), newReportName)
                If (i > 0) Then
                    'PopulateUserReports()
                    Response.Redirect(Request.Url.AbsoluteUri)
                Else
                    invalidOperation = True 'Invalid operation owner not matched
                End If
            Else
                invalidOperation = True

            End If
        End If
        If invalidOperation Then
            lblMessageUserReports.Text = Common.ERROR_MESSAGE
        End If
    End Sub

    ''' <summary>
    ''' Delete user's own reports
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim invalidOperation = False
        Dim selectedReportId As String = txtSelectedReport.Text
        If Not (String.IsNullOrEmpty(GSafeID)) Then
            Dim userInfo = DataHelper.GetUserInformation(GSafeID).AsEnumerable().Select(Function(row, index) New With {
            .RowIndex = index,
            .LoginId = row.Field(Of Integer)("LoginId")
        }).FirstOrDefault()

            If (userInfo.LoginId > 0 And Not String.IsNullOrEmpty(selectedReportId)) Then
                Dim i As Integer = DataHelper.DeleteUserReportById(Convert.ToInt32(selectedReportId), userInfo.LoginId)
                If (i > 0) Then
                    Response.Redirect(Request.Url.AbsoluteUri)
                Else
                    invalidOperation = True 'Invalid operation owner not matched
                End If

            Else
                invalidOperation = True

            End If
        End If
        If invalidOperation Then
            lblMessageUserReports.Text = Common.ERROR_MESSAGE
        End If
    End Sub



End Class