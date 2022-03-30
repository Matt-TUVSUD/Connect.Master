Imports GRC.Connect.Libraries.DataLib.razor

Public Class CopeForm
    Implements IUtilityForm

    Dim zBindSource As New Windows.Forms.BindingSource

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles uxGo.Click

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

    Private Sub RecommendationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub uxPlantComment_TextChanged(sender As Object, e As EventArgs) Handles uxPlantComment.TextChanged
        Dim zChar() As Char = uxPlantComment.Text.ToCharArray()
        Dim zSB As New Text.StringBuilder
        zChar.ToList.ForEach(Sub(x) zSB.AppendLine(x.ToString & vbTab & "ASC# " & Asc(x) & " " & Char.IsControl(x)))
        uxChars.Text = zSB.ToString
    End Sub
    Private Sub uxKeyword_TextChanged(sender As Object, e As EventArgs) Handles uxRecKeyWord.TextChanged
        Dim zChar() As Char = uxRecKeyWord.Text.ToCharArray()
        Dim zSB As New Text.StringBuilder
        zChar.ToList.ForEach(Sub(x) zSB.AppendLine(x.ToString & vbTab & "ASC# " & Asc(x)))
        uxKeyWorkChars.Text = zSB.ToString
    End Sub

    Private Sub uxGoOccupancy_Click(sender As Object, e As EventArgs) Handles uxGoOccupancy.Click

        Dim zCmd As New SqlClient.SqlCommand("select id, fileno, coalesce(BriefDescriptionOfOperationsAndProductsManufactured,'<missing>') BriefDescriptionOfOperationsAndProductsManufactured from dbo.[Cope-FireOccupancy] WHERE FileNo LIKE @FilePrefix")
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
        If Me.uxRecKeyWord.DataBindings.Count = 0 Then Me.uxRecKeyWord.DataBindings.Add("Text", zBindSource, "BriefDescriptionOfOperationsAndProductsManufactured")
        If Me.uxPlantComment.DataBindings.Count = 0 Then Me.uxPlantComment.DataBindings.Add("Text", zBindSource, "BriefDescriptionOfOperationsAndProductsManufactured")

    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property
End Class