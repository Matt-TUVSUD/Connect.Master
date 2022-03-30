
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor


Public Class Grids_FilterBatchReports
    Inherits System.Web.UI.Page

#Region "Local Variables"
    Public ServerSide_WindowShow As String = "false"
    Public ServerSide_WindowMessage As String = ""
    Public ServerSide_GridId As String = ""
#End Region



#Region "Initialize Controls"
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
    End Sub
#End Region



#Region "Page Events"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Call loadLists()
            Call loadDefaults()
        End If
        Call loadData()
    End Sub

#End Region



#Region "Data Loading"
    Private Sub loadDefaults()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zFilePrefix As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.FilePreFix)
        Dim zGridId As String = "28"
        UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.currentGridId, zGridId, UtilGSafe.KeyNameGroup.Navigation)
        ServerSide_GridId = zGridId

        ' SET EACH COMBOBOX TO THE DEFAULT SAVED IN THE GSAFE TABLE
        ' CURRENCY
        Dim zCurrencyDefault As String = UtilGSafe.GetValue(zGSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
        Dim zCurrencyDefaultEnum As Integer = TblMetaCurrency.Currencies.UsDollar
        Dim zCollCurrency As New List(Of rowTblMetaCurrency)
        Dim zCmdCurrency As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaCurrency] WHERE [fldCode] = @CurrencyCode")
        zCmdCurrency.Parameters.AddWithValue("@CurrencyCode", zCurrencyDefault)
        zCollCurrency = TblMetaCurrency.LoadData(zCmdCurrency)
        If zCollCurrency.Count > 0 Then
            zCurrencyDefaultEnum = zCollCurrency(0).colFldId
        End If
        Dim zItemCurrency As Telerik.Web.UI.RadComboBoxItem = cboConvertCurrency.FindItemByValue(zCurrencyDefaultEnum, True)
        zItemCurrency.Selected = True

        ' UNITS
        Dim zUnitDefault As String = UtilGSafe.GetValue(zGSafeGUID, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText)
        Dim zUnitDefaultEnum As Integer = TblMetaUnitSystem.Systems.English
        Dim zCollUnits As New List(Of rowTblMetaUnitSystem)
        Dim zCmdUnits As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaUnitSystem] WHERE [fldName] = @UnitName")
        zCmdUnits.Parameters.AddWithValue("@UnitName", zUnitDefault)
        zCollUnits = TblMetaUnitSystem.LoadData(zCmdUnits)
        If zCollUnits.Count > 0 Then
            zUnitDefaultEnum = zCollUnits(0).colFldId
        End If
        Dim zItemUnits As Telerik.Web.UI.RadComboBoxItem = cboConvertUnits.FindItemByValue(zUnitDefaultEnum, True)
        zItemUnits.Selected = True

        ' CREATE A TEMP NAME OF REPORT
        Dim zClientName As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.ClientName)
        zClientName = Replace(zClientName, ".", "")
        zClientName = Replace(zClientName, "\", "")
        zClientName = Replace(zClientName, "/", "")
        zClientName = Replace(zClientName, ":", "")
        zClientName = Replace(zClientName, "*", "")
        zClientName = Replace(zClientName, "?", "")
        zClientName = Replace(zClientName, """", "")
        zClientName = Replace(zClientName, "'", "")
        zClientName = Replace(zClientName, "<", "")
        zClientName = Replace(zClientName, ">", "")
        zClientName = Replace(zClientName, "|", "")
        zClientName = Replace(zClientName, " ", "")
        txtNameOfReport.Text = "myBatchReports_" & zClientName & "_" & Date.Now.ToString("yyyyMMdd_HHmm")

    End Sub


    Private Sub loadData()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.practiceName, "Filters & Settings - Batch Reports", UtilGSafe.KeyNameGroup.PageHeader) 'SET THE PAGE TITLE
    End Sub


    Private Sub loadLists()
        'CLEAR THE COMBO BOX LISTS
        cboConvertCurrency.Items.Clear()
        cboConvertUnits.Items.Clear()

        'LOAD LIST FOR CURRENCY
        Dim zCollCurrency As List(Of rowTblMetaCurrency)
        zCollCurrency = TblMetaCurrency.LoadData
        For Each zRow As rowTblMetaCurrency In zCollCurrency
            cboConvertCurrency.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
        Next

        'LOAD LIST FOR UNITS
        Dim zCollUnit As List(Of rowTblMetaUnitSystem)
        zCollUnit = TblMetaUnitSystem.LoadData
        For Each zRow As rowTblMetaUnitSystem In zCollUnit
            cboConvertUnits.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
        Next

    End Sub

#End Region


#Region "Actions"
    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    '    Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '    Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zSafeGUID, False)
    'End Sub


    Private Sub btnCloseBatchReport_Click(sender As Object, e As EventArgs) Handles btnCloseBatchReport.Click
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        'Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zSafeGUID, False)
        Response.Redirect("~/Home_{{VER}}/Reports/myBatchReportsSelector.aspx?sid=" & zSafeGUID, False)
    End Sub

#End Region

    Private Sub btnCancelBatchReport_Click(sender As Object, e As EventArgs) Handles btnCancelBatchReport.Click
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zBatchId As Integer = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.BatchReportBatchSetId)
        Dim zBatchSet As BatchSet = BatchSet.Load(zBatchId)
        zBatchSet.colFldFileName = "BatchReport - Cancelled"
        zBatchSet.BatchSetStatus = BatchSet.BatchStatus.Cancelled
        zBatchSet.Save(True)

        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.BatchReportBatchSetId, "", UtilGSafe.KeyNameGroup.Preference)
        btnCloseBatchReport_Click(sender, e)

    End Sub
End Class