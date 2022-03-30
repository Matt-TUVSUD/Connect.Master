Imports GRC.Connect.Libraries.DataLib.razor

Public Class EmailTemplateControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RadGridEmailTemplate_ItemCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGridEmailTemplate.ItemCommand
        If TypeOf e.Item Is Telerik.Web.UI.GridDataItem Then
            Dim zKey As Integer = DirectCast(e.Item, Telerik.Web.UI.GridDataItem).GetDataKeyValue("colfldID")
            Dim zEditor As EmailTemplateEditorControl = Me.RadWindow1.ContentContainer.FindControl("EmailTemplateEditorControl")
            zEditor.EmailTemplateId = zKey
            Me.RadWindow1.VisibleOnPageLoad = True
        End If
    End Sub

    Private Sub RadGridEmailTemplate_ItemCreated(sender As Object, e As Telerik.Web.UI.GridItemEventArgs) Handles RadGridEmailTemplate.ItemCreated

    End Sub

    Private Sub RadGridEmailTemplate_ItemDataBound(sender As Object, e As Telerik.Web.UI.GridItemEventArgs) Handles RadGridEmailTemplate.ItemDataBound
        If TypeOf e.Item Is Telerik.Web.UI.GridDataItem Then
            'Dim zcellvalue As String = e.Item.Cells(RadGridEmailTemplate.Columns.FindByUniqueName("body").OrderIndex).Text
            'If Not zcellvalue.Contains("<p><img") Then
            '    'zcellvalue = zcellvalue & "<p><img alt='GRC Logo' src='http://www.globalriskconsultants.com/img/email/TUV_GRC_ARISE_Logo.png' /></p>"
            '    'e.Item.Cells(RadGridEmailTemplate.Columns.FindByUniqueName("body").OrderIndex).Text = zcellvalue
            '    Dim zBody As String = DirectCast(e.Item.DataItem, rowVwEmailTemplate).colFldBody
            '    zBody = zBody & "<p><img alt='GRC Logo' src='http://www.globalriskconsultants.com/img/email/TUV_GRC_ARISE_Logo.png' /></p>"

            '    Dim zRow As rowTblEmailTemplate = TblEmailTemplate.LoadByPrimaryKey(DirectCast(e.Item.DataItem, rowVwEmailTemplate).colFldId)
            '    zRow.colFldBody = zBody
            '    TblEmailTemplate.Save(zRow)
        End If
    End Sub

    Private Sub RadGridEmailTemplate_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGridEmailTemplate.NeedDataSource
        Dim zList As List(Of rowVwEmailTemplate) = VwEmailTemplate.LoadData
        Me.RadGridEmailTemplate.DataSource = zList

    End Sub

    Protected Overrides Function OnBubbleEvent(source As Object, args As EventArgs) As Boolean
        If TypeOf source Is Button Then
            Me.RadWindow1.VisibleOnPageLoad = False
            RadGridEmailTemplate.Rebind()
        End If

        Return MyBase.OnBubbleEvent(source, args)

    End Function

End Class