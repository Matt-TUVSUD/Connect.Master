Imports Telerik.Web.UI

Public Class UtilPrefilter

    Public Shared Sub SetDivisions(pComboBox As RadComboBox, pSafeGuid As String)
        Dim zSafeGUID As String = pSafeGuid
        Dim zSafeId As Integer = UtilGSafe.GetId(zSafeGUID)
        Dim zDivisionList As List(Of String) = UtilGSafe.BuildUserDivisionList(zSafeId).ToList

        pComboBox.Items.Clear()
        pComboBox.Items.Add(New Telerik.Web.UI.RadComboBoxItem("(All)", "%"))
        zDivisionList.ForEach(Sub(x) pComboBox.Items.Add(New Telerik.Web.UI.RadComboBoxItem(x, x)))

    End Sub

    Public Shared Sub SetCustomAccesses(pComboBox As RadComboBox, pSafeGuid As String)
        Dim zSafeGUID As String = pSafeGuid
        Dim zSafeId As Integer = UtilGSafe.GetId(zSafeGUID)
        Dim zCustomAccessPref As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.CustomAccessText)
        Dim zCustomAccessList As List(Of String) = UtilGSafe.BuildUserCustomAccessList(zSafeId).ToList

        pComboBox.Items.Clear()
        pComboBox.Items.Add(New Telerik.Web.UI.RadComboBoxItem("(All)", "%"))
        zCustomAccessList.ForEach(Sub(x) pComboBox.Items.Add(New Telerik.Web.UI.RadComboBoxItem(x, x)))

    End Sub

End Class
