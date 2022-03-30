Imports GRC.Connect.Libraries.DataLib.razor

Public Class MetaMgrForm

    Private Sub MetaMgrForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim zCS As String = Configuration.ConfigurationManager.ConnectionStrings("Connect.Test").ConnectionString
        UtilSQLServer.SetConnection(zCS)
        Dim zGrids As List(Of rowTblMetaGrid) = TblMetaGrid.LoadData
        MetaRadGrid1.DataSource = zGrids
    End Sub
End Class