Imports Telerik.Web.UI
Imports GRC.Connect.Libraries.DataLib.razor

Public Class EmailTemplateEditorControl
    Inherits System.Web.UI.UserControl

    Private _EmailTemplateId As Integer = 0
    Public Property EmailTemplateId As Integer
        Get
            Return _EmailTemplateId
        End Get
        Set(value As Integer)
            _EmailTemplateId = value
            LoadEmailTemplate()
        End Set
    End Property

    Public Sub LoadEmailTemplate()
        Dim zQry As New queryVwEmailTemplate
        zQry.SelectAll()
        zQry.Where.Add(zQry.colFldId.Equals(_EmailTemplateId))

        Dim zList As List(Of rowVwEmailTemplate) = VwEmailTemplate.LoadData(zQry.QueryText)
        If zList.Count > 0 Then
            Dim zObj As rowVwEmailTemplate = zList(0)
            Me.uxSubjectEditor.Text = zObj.colFldSubject
            Me.uxBodyEditor.Content = zObj.colFldBody ' & "<p><img alt='GRC Logo' src='http://www.globalriskconsultants.com/img/email/TUV_GRC_ARISE_Logo.png' /></p>"
            Me.uxID.Value = zObj.colFldId
        End If
    End Sub


    Private Sub uxSaveButton_Click(sender As Object, e As EventArgs) Handles uxSaveButton.Click
        Dim zObj As rowTblEmailTemplate = TblEmailTemplate.LoadByPrimaryKey(CInt(Me.uxID.Value))
        zObj.colFldSubject = uxSubjectEditor.Text
        zObj.colFldBody = uxBodyEditor.Content
        TblEmailTemplate.Save(zObj)
        RaiseBubbleEvent(sender, e)
    End Sub
End Class