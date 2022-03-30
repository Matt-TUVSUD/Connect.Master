
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor


Public Class Grids_FilterPreferences
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
            'Call LoadLocationsFilterFavorite()
        End If
        Call loadData()
    End Sub

#End Region



#Region "Data Loading"
    Private Sub loadDefaults()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zFilePrefix As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.FilePreFix)
        Dim zGridId As String = "84"
        UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.currentGridId, zGridId, UtilGSafe.KeyNameGroup.Navigation)
        ServerSide_GridId = zGridId

        'Dim zGSafeGUID As String = Request.QueryString("sid")
        'Dim zCurrencyDefault As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.CurrencyDefaultText)
        'Dim zUnitDefault As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UnitDefaultText)

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
        'If Not zCurrencyDefault Is Nothing Then
        '    If zCurrencyDefault <> "" Then
        '        Dim item As Telerik.Web.UI.RadComboBoxItem = cboConvertCurrency.FindItemByValue(zCurrencyDefault, True)
        '        item.Selected = True
        '    Else
        '        Dim item As Telerik.Web.UI.RadComboBoxItem = cboConvertCurrency.FindItemByValue("USD", True)
        '        item.Selected = True
        '    End If
        'Else
        '    Dim item As Telerik.Web.UI.RadComboBoxItem = cboConvertCurrency.FindItemByValue("USD", True)
        '    item.Selected = True
        'End If

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
        'If Not zUnitDefault Is Nothing Then
        '    If zUnitDefault <> "" Then
        '        Dim item As Telerik.Web.UI.RadComboBoxItem = cboConvertUnits.FindItemByText(zUnitDefault, True)
        '        item.Selected = True
        '    Else
        '        Dim item As Telerik.Web.UI.RadComboBoxItem = cboConvertUnits.FindItemByText("English", True)
        '        item.Selected = True
        '    End If
        'Else
        '    Dim item As Telerik.Web.UI.RadComboBoxItem = cboConvertUnits.FindItemByText("English", True)
        '    item.Selected = True
        'End If

        Dim zUserid As Integer = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogGridActivity(zUserid, zGridId)

    End Sub


    Private Sub loadData()
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.practiceName, "Filters & Settings - myPreferences", UtilGSafe.KeyNameGroup.PageHeader) 'SET THE PAGE TITLE
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
        'Using zColl As New ViewCCPrefCurrencyCollection
        '    With zColl.Query()
        '        .SelectAll()
        '        If .Load() Then
        '            For Each zObj As ViewCCPrefCurrency In zColl
        '                cboConvertCurrency.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Currency, zObj.Code))
        '            Next
        '        End If
        '    End With
        'End Using

        'LOAD LIST FOR UNITS
        Dim zCollUnit As List(Of rowTblMetaUnitSystem)
        zCollUnit = TblMetaUnitSystem.LoadData
        For Each zRow As rowTblMetaUnitSystem In zCollUnit
            cboConvertUnits.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zRow.colFldName, zRow.colFldId))
        Next
        'Using zColl As New ViewCCPrefUnitCollection
        '    With zColl.Query()
        '        .SelectAll()
        '        If .Load() Then
        '            For Each zObj As ViewCCPrefUnit In zColl
        '                cboConvertUnits.Items.Add(New Telerik.Web.UI.RadComboBoxItem(zObj.Code))
        '            Next
        '        End If
        '    End With
        'End Using

    End Sub

#End Region


#Region "Actions"
    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    '    Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
    '    Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zSafeGUID, False)
    'End Sub


    Private Sub btnClosePreferences_Click(sender As Object, e As EventArgs) Handles btnClosePreferences.Click
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Response.Redirect("~/Home_{{VER}}/Gauge/Default.aspx?sid=" & zSafeGUID, False)
    End Sub

#End Region


End Class