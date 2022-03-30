Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class TopoRecReport
    Inherits Telerik.Reporting.Report

    Public Property FileNo As String
    Public Property RefSourceID As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Table1_NeedDataSource(sender As Object, e As EventArgs) Handles Table1.NeedDataSource
        Dim dt As New DataTable
        Dim con As New SqlClient.SqlConnection(UtilDB.ConnectionString)
        Dim cmd As New SqlClient.SqlCommand("Select * from api.vwTopoSurveyRec WHERE FileNo=@FileNo ORDER BY RecYear, RecNumber", con)
        cmd.Parameters.AddWithValue("@FileNo", FileNo)
        con.Open()
        Using con
            Using cmd
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using
        Table1.DataSource = dt
    End Sub
End Class