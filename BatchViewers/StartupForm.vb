Public Class StartupForm
    Implements IUtilityForm

    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            For Each zT As Type In GetFormsToShowOnMainPageTypes()
                uxForms.Items.Add(zT)
                uxForms.DisplayMember = "Name"
            Next

            uxEnv.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub uxEnv_SelectedValueChanged(sender As Object, e As EventArgs) Handles uxEnv.SelectedIndexChanged

        Dim zEnv As String = uxEnv.Items(uxEnv.SelectedIndex)
        Dim zCS As String = UtilDB.ConnectionString(zEnv)
        DataLib.razor.UtilSQLServer.SetConnection(zCS)
        UtilESStart.InitEngine(zCS)
        UtilSetting.Init()
        uxCS.Text = zCS
    End Sub

    Private Sub uxForms_DoubleClick(sender As Object, e As EventArgs) Handles uxForms.DoubleClick
        System.Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
        Dim zTypeName As Type = uxForms.SelectedItem

        'Dim zType As Type = Type.GetType(zTypeName)
        Dim zForm As Windows.Forms.Form = Activator.CreateInstance(zTypeName)
        zForm.Show()
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return False
        End Get
    End Property

    Public Shared Function GetFormsToShowOnMainPageTypes() As List(Of Type)
        Dim zList As New List(Of Type)
        For Each zT As Type In Meta.MetaForm.GetTypes()
            If zT.GetInterfaces().Contains(GetType(IUtilityForm)) Then
                Try
                    Dim zUtilForm As IUtilityForm = Activator.CreateInstance(zT)
                    If zUtilForm.ShowOnMainMenu Then
                        zList.Add(zT)
                    End If
                    DirectCast(zUtilForm, Windows.Forms.Form).Dispose()
                Catch ex As Exception
                End Try
            End If
        Next
        Return zList
    End Function

End Class