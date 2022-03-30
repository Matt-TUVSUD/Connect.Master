

Public Class UtilPreference
    Public Shared Function ReadCurrencyDescription(pCurrencyCode As String) As String
        Dim zReturn As String = ""

        Dim zColl As New BusinessObjects.CurrencyDefinitionCollection
        Dim zQry As New BusinessObjects.CurrencyDefinitionQuery("t1")

        zQry.SelectAll()
        zQry.Where(zQry.Code = pCurrencyCode)

        If zColl.Load(zQry) Then
            zReturn = zColl(0).Currency
        End If

        Return zReturn
    End Function


    Public Shared Function IsFilterApplied(pGSafeGuid As String) As Boolean
        Dim zReturn As Boolean = False
        Try
            Dim zFilePrefix As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)

            'LOOK UP SETTINGS COMPARE TO WEB CONFIG
            Dim zSettingCurrency As String = UtilGSafe.GetValue(pGSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
            Dim zSettingUnits As String = UtilGSafe.GetValue(pGSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText)
            Dim zSettingCurrencyDefault As String = UtilSystemParms.ReadDefaultSettingCurrencyValue()
            Dim zSettingUnitsDefault As String = UtilSystemParms.ReadDefaultSettingUnitsText()
            If zSettingCurrency <> zSettingCurrencyDefault Or zSettingUnits <> zSettingUnitsDefault Then
                zReturn = True
            End If

            'LOOK UP FILTER SQL STRING TO SEE IF EXISTS - NEW NOTE: DO NOT DO THIS CHECK AS FILE PREFIX USERS WILL ALWAYS HAVE A FILTER.
            'Dim zFilterSQL As String = UtilGSafe.GetFilterSQL(pGSafeGuid, zFilePrefix)
            'If zFilterSQL.Length > 0 Then
            '    zReturn = True
            'End If

            'IS THERE A SETTINGS SAVED IN THE GSAFE?
            Dim zMyPrefActive As String = UtilGSafe.GetValue(pGSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.IsMyPreferenceActive)
            If zMyPrefActive.ToLower() = "true" Then
                zReturn = True
            End If

        Catch ex As Exception
            'zReturn = ex.Message
            zReturn = False
        End Try

        Return zReturn

    End Function
End Class
