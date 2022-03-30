Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilExport

    Public Shared Function ExportGrid(pSafeGUID As String, pGridId As Integer, pFilter As String, pCriteria As String, pSort As String, Optional pUserCurrencyId As String = Nothing) As Byte()
        Dim zGDC As New UtilGDC

        zGDC.PropGridId = pGridId
        zGDC.PropSafeGUID = pSafeGUID
        zGDC.PropFilter = pFilter
        zGDC.PropCriteria = pCriteria
        zGDC.PropSort = pSort

        '' PROTECT THE ADMIN USER EXPORT WHERE FILE PREFIX IS NOT SET
        'If pGridId = GRC.Connect.Libraries.CoreLib.UtilMeta.GetMetaKey("Users", 131) _
        'Or pGridId = GRC.Connect.Libraries.CoreLib.UtilMeta.GetMetaKey("UsersActivity", 132) Then
        '    zGDC.PropParameters.FilePrefix = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)
        'End If

        'ADD FILEPREFIX PARAMETER
        zGDC.PropParameters.FilePrefix = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FilePreFix)

        'WE NEED TO APPLY THE MY PREFERENCES IF ANY
        'CHECK TO SEE IF NUMERIC CAUSE THE RECLASSIFICATION FORM USES THIS CODE AND DOES NOT SET ALL GSAFE VALUES
        Dim zCurrencyMyPref As String = UtilGSafe.GetValue(pSafeGUID, zGDC.PropParameters.FilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference)
        Dim zUnitMyPref As String = UtilGSafe.GetValue(pSafeGUID, zGDC.PropParameters.FilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference)
        If IsNumeric(zCurrencyMyPref) Then zGDC.PropParameters.Currency = zCurrencyMyPref
        If IsNumeric(zUnitMyPref) Then zGDC.PropParameters.Unit = zUnitMyPref

        ' IS THERE A USER CURRENCY OVERRIDE?
        If Not pUserCurrencyId Is Nothing Then
            Dim zCurrencyId As Integer = CInt(Val(pUserCurrencyId))
            If zCurrencyId > 0 Then
                zGDC.PropParameters.Currency = zCurrencyId
            End If
        End If

        ' Check to see if User is on a location
        Dim zNavLinkId As Object = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.NavLinkId)
        If IsNumeric(zNavLinkId) Then
            Dim zNavSlideType As String = UtilNavLink.GetSlideMenuType(Int(zNavLinkId))
            If zNavSlideType = NavLink.SlideMenuTypes.Practice Then
                Dim zFileNo As String = UtilGSafe.GetValue(pSafeGUID, UtilGSafe.KeyName.FileNo)
                If zFileNo.Length > 0 Then
                    zGDC.PropParameters.FileNo = zFileNo
                End If
            End If
        End If


        Dim zSQL As String = zGDC.GetGridExportSQL()

        Dim zEE As New GRC.Connect.Libraries.CoreLib.GRCMSOfficeExcel
        Dim zStream As System.IO.MemoryStream = New System.IO.MemoryStream(zEE.ExportToExcel(zSQL, zGDC.PropGridId, pSafeGUID, TblMetaCurrency.Currencies.UsDollar, zGDC.PropParameters.FilePrefix))

        Return zStream.ToArray
    End Function

    Public Shared Function ExportData(pBatchSetId As Integer, pGridId As Integer, pFilter As String, pCriteria As String, pSort As String, pCurrency As TblMetaCurrency.Currencies, pFilePrefix As String, pFormat As UtilExport.ExportFormat, pParameters As IUtilSQLMakerParameterInfo) As Byte()
        Dim zGDC As New UtilGDC

        zGDC.PropGridId = pGridId
        zGDC.PropBatchSetId = pBatchSetId
        zGDC.PropFilter = pFilter
        zGDC.PropCriteria = pCriteria
        zGDC.PropSort = pSort
        zGDC.PropParameters = pParameters

        Dim zSQL As String = zGDC.GetBatchExportSQL
        Dim zStream As System.IO.MemoryStream

        Select Case pFormat
            Case ExportFormat.Excel
                Dim zEE As New GRC.Connect.Libraries.CoreLib.GRCMSOfficeExcel
                zStream = New System.IO.MemoryStream(zEE.ExportToExcel(zSQL, zGDC.PropGridId, "", pCurrency, pFilePrefix))
            Case ExportFormat.TXT
                Dim zEE As New GRC.Connect.Libraries.CoreLib.GRCTextExport
                zEE.TextFormat = ExportFormat.TXT
                zStream = New System.IO.MemoryStream(zEE.ExportToText(zSQL, zGDC.PropGridId, "", pCurrency, pFilePrefix))
            Case ExportFormat.CSV
                Dim zEE As New GRC.Connect.Libraries.CoreLib.GRCTextExport
                zEE.TextFormat = ExportFormat.CSV
                zStream = New System.IO.MemoryStream(zEE.ExportToText(zSQL, zGDC.PropGridId, "", pCurrency, pFilePrefix))
            Case Else
                zStream = Nothing
        End Select

        Return zStream.ToArray
    End Function

    Public Enum ExportFormat
        Excel = 1
        CSV
        TXT
    End Enum


    Public Class ProjectManagementExport

        Public Shared Function Export(pGUID As String, pGridID As Integer, pFilter As String, pSort As String) As Byte()

            Dim zGDC As New UtilGDC
            zGDC.PropSort = pSort
            zGDC.PropFilter = pFilter
            zGDC.PropGridId = pGridID
            zGDC.PropSafeGUID = pGUID

            Dim zSQL As String = zGDC.GetGridExportSQL()

            Dim zCon As New SqlClient.SqlConnection(UtilDB.ConnectionString)
            Dim zCmd As New SqlClient.SqlCommand(zSQL, zCon)
            Dim zDT As New DataTable

            zCon.Open()
            Using zCon
                Using zCmd
                    zDT.Load(zCmd.ExecuteReader)
                End Using
            End Using

            Dim zList As List(Of Integer) = zDT.AsEnumerable.ToList.Select(Function(x) CInt(x.Item("RowID"))).ToList()

            GRC.EDA.PM.Connect.CoreLib.UtilCore.Initialize(Reflection.Assembly.GetExecutingAssembly)
            Dim zPMCoreLib As New GRC.EDA.PM.Connect.CoreLib.UtilCore(pGUID)

            Dim zByte As Byte() = zPMCoreLib.ExtractClientProject(zList)

            Return zByte

        End Function
    End Class

End Class
