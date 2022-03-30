Public Class Header
    Inherits System.Web.UI.UserControl

    Public ServerSide_AdminTab As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        If zGUID <> "" Then
            Dim zLoginId As Integer = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString(), UtilGSafe.KeyName.EzyLoginId)
            Dim zAdminType = GRC.Connect.Libraries.CoreLib.UtilLogin2.GetGRCAdministrator(zLoginId)

            lblLoginUser.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
            lblGaugeCompanyName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)
            'Page.ClientScript.RegisterClientScriptInclude("key", "../../Lib_{{VER}}/Header/header.js")

            ' LOOK FOR FILTERS APPLIED
            If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
                hasPrefSet.Visible = True
                noPrefSet.Visible = False
            Else
                noPrefSet.Visible = True
                hasPrefSet.Visible = False
            End If

            If zAdminType <> "00" Then
                adminLink.Visible = False
                ServerSide_AdminTab = ""
            Else
                adminLink.Visible = True
                ServerSide_AdminTab = "Admin"
            End If

        Else
            Dim zBatchSetID = Request.QueryString("batchSetId")
            Dim zBatchSet As razor.IrowTblBatchProcessingSet = razor.TblBatchProcessingSet.LoadByPrimaryKey(zBatchSetID)
            Dim zClient As razor.IrowTblClients = razor.TblClients.LoadByPrimaryKey(zBatchSet.colFldFilePrefix)
            lblGaugeCompanyName.Text = zClient.colClientname
        End If

    End Sub

End Class