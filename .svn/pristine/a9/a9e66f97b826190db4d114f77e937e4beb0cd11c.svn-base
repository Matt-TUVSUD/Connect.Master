Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor

Public Class myBatchReports
    Inherits System.Web.UI.Page
    Implements IPostBackEventHandler

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ValidatePage()
        If Not Page.IsPostBack Then
            Call LoadDefaults()
            Call LoadIcons()
        End If
        Call LoadData()

    End Sub


    Private Sub ValidatePage()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        UtilValidate.CorrectPageCheck(zGSafeGUID, UtilConstants.PageId_myBatchReports, "")
    End Sub

    Private Sub LoadDefaults()
    End Sub


    Private Sub LoadIcons()
        ' SET THE ICON TEXT LINKS THEN CREATE AN EVENT FOR THE ICON
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'icoClose.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoClose_Click")
        Dim zEntryType As String = Request.QueryString("p2") & ""
        'If zEntryType.Length > 0 Then
        '    hypClose.NavigateUrl = "~/Home_{{VER}}/Logout/Default.aspx?sid=" & zGSafeGUID
        '    hypClose.Text = "Exit"
        'Else
        '    hypClose.NavigateUrl = "~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zGSafeGUID
        '    hypClose.Text = "Close"
        'End If

    End Sub


    Private Sub LoadData()
        Try
            Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
            Dim zGSafeID As Integer = UtilGSafe.GetId(zGSafeGUID)
            Dim zColl As New List(Of rowVwBatchReportFileList)
            Dim zDataSource As New List(Of DataPackFile)
            Dim zFilePrefix As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.FilePreFix)
            If zFilePrefix = "" Then zFilePrefix = Request.QueryString("p3") 'IF THE GSAFE FILEPREFIX IS EMPTY THEN THE USER CLICKED THE LINK IN THE BATCHREPORTS EMAIL WHICH CONTAINS THE FILEPREFIX.


            Dim zQry As New razor.queryVwBatchReportFileList
            zQry.SelectAll()
            zQry.Where.Add(zQry.colFldCreatedByGsafeId.Equals(zGSafeID))
            zQry.Where.Add(zQry.colFldFilePrefix.Equals(zFilePrefix))
            zQry.OrderBy(zQry.colFldCreateDate.Descending)

            'Dim zCmd As New SqlClient.SqlCommand("SELECT  * FROM [dbo].[vwBatchReportFileList] WHERE [fldCreatedByGsafeId] = @GSafeId AND [ ORDER BY [fldCreateDate] DESC")
            'zCmd.Parameters.AddWithValue("@GSafeId", zGSafeID)

            zColl = VwBatchReportFileList.LoadData(zQry.QueryText)
            If zColl.Count > 0 Then
                For Each zObj As rowVwBatchReportFileList In zColl
                    'CONVERT THE FILE SIZE TO MB
                    Dim zTempSize As Double = zObj.colFldFileSize / 1024 / 1024
                    zTempSize = Math.Round(zTempSize, 2)
                    Dim zTempObj As New DataPackFile
                    zTempObj.colFldCreateDate = zObj.colFldCreateDate
                    zTempObj.colFldFileSize = zTempSize
                    zTempObj.colFldGuid = zObj.colFldGuid
                    zTempObj.colFldFileName = zObj.colFldFileName
                    zTempObj.colFldExtension = zObj.colFldExtension
                    zDataSource.Add(zTempObj)
                Next
                rptReportList.DataSource = zDataSource
                rptReportList.DataBind()
                divReportListContainer.Visible = True
            Else
                lblMessage.Text = "There are no reports available for download."
                divReportListContainer.Visible = False
            End If

        Catch ex As Exception

        End Try

        'Dim zEmail As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail)
        'Dim zColl As New BusinessObjects.ViewCCMyBatchReportsListCollection
        'Dim zQry As New BusinessObjects.ViewCCMyBatchReportsListQuery
        'zQry.SelectAll()
        'zQry.Where(zQry.Email = zEmail)
        'zQry.OrderBy(zQry.CreateDate.Descending)
        'If zColl.Load(zQry) Then
        '    For Each zObj As BusinessObjects.ViewCCMyBatchReportsList In zColl
        '        'CONVERT THE FILE SIZE TO MB
        '        Dim zTempSize As Double = zObj.FileSizeBytes / 1024 / 1024
        '        zObj.FileSizeBytes = Math.Round(zTempSize, 2)
        '    Next
        '    rptReportList.DataSource = zColl
        '    rptReportList.DataBind()
        '    divReportListContainer.Visible = True
        'Else
        '    lblMessage.Text = "There are no reports available for download."
        '    divReportListContainer.Visible = False
        'End If
    End Sub


    ' RAISE AN EVENT FOR THE ICON CLICKS
    Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Select Case eventArgument
            Case "icoClose_Click"
                Dim zEntryType As String = Request.QueryString("p2") & ""
                If zEntryType.Length > 0 Then
                    Response.Redirect("~/Home_{{VER}}/Logout/Default.aspx?sid=" & zGSafeGUID, True)
                Else
                    Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zGSafeGUID, True)
                End If
        End Select
    End Sub


    Private Class DataPackFile
        Public colFldFilePrefix As String
        Public colClientname As String
        Public colFldCreatedByGsafeId As Nullable(Of Integer)
        Public colFldId As Nullable(Of Integer)
        Public colFldSetId As Nullable(Of Integer)
        Public colFldGuid As String
        Public colFldCreateDate As Nullable(Of DateTime)
        Public colFldAccessDate As Nullable(Of DateTime)
        Public colFldFileSize As Nullable(Of Double)
        Public colFldMime As String
        Public colFldExtension As String
        Public colFldFileName As String
    End Class


End Class