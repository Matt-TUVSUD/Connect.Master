Public Class CharFinderForm

    Private Sub CharFinderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GetData()
        Dim zCmd As New SqlClient.SqlCommand("select id, fileno, coalesce(LEandInterdependecyComments,'<missing>') LEandInterdependecyComments from dbo.[Cope-FireMain] WHERE FileNo LIKE @FilePrefix")
        zCmd.Parameters.AddWithValue("@FilePrefix", uxFilePrefix.Text)

        Dim zCon As SqlClient.SqlConnection = DataLib.razor.UtilSQLServer.GetConnectionObject
        zCmd.Connection = zCon

        Dim zDT As New DataTable
        zDT.Load(zCmd.ExecuteReader)
        zCon.Close()


        zBindSource.DataSource = zDT

        Me.RadBindingNavigator1.BindingSource = zBindSource

        If Me.uxRecID.DataBindings.Count = 0 Then Me.uxRecID.DataBindings.Add("Text", zBindSource, "ID")
        If Me.uxFileNo.DataBindings.Count = 0 Then Me.uxFileNo.DataBindings.Add("Text", zBindSource, "FileNo")
        If Me.uxRecKeyWord.DataBindings.Count = 0 Then Me.uxRecKeyWord.DataBindings.Add("Text", zBindSource, "LEandInterdependecyComments")
        If Me.uxPlantComment.DataBindings.Count = 0 Then Me.uxPlantComment.DataBindings.Add("Text", zBindSource, "LEandInterdependecyComments")

    End Sub

    Private Sub GetStringColumns()
        Dim zTable As String = uxTable.SelectedText
        Dim zCmd As New SqlClient.SqlCommand("select id, fileno, coalesce(LEandInterdependecyComments,'<missing>') LEandInterdependecyComments from dbo.[Cope-FireMain] WHERE FileNo LIKE @FilePrefix")
        zCmd.Parameters.AddWithValue("@FilePrefix", uxFilePrefix.Text)

    End Sub


End Class