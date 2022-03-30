Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports Telerik.Web.UI
Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor

Public Class myBatchReportsSelector
    Inherits System.Web.UI.Page

    Private Sub ValidatePage()
        GRC.Connect.Libraries.CoreLib.UtilValidate.CorrectPageCheck(UtilGSafe.GetGUIDFromQueryString(), PageId_AllReports, "")

    End Sub


    Private Sub loadLists()

    End Sub


    Private Sub loadDefaults()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        GRC.Connect.Libraries.CoreLib.UtilPractice.SetAllReportsTitle(zGSafeGUID)
        'Call modConfig.SetIGConfig(zGSafeGUID)

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'Response.Redirect("~/Home_{{VER}}/Gauge/?sid=" & zGSafeGUID, False)

        Call ValidatePage()

        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
            '   Call loadReports()

            Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()
            Dim zUserid As Integer = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.EzyLoginId)
            UtilDB.LogOtherActivity(zUserid, "BatchReportsSelector")

        End If

        Call loadData()

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