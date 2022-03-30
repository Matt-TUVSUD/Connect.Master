Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.EDA.PM.DataInterfaceLib.razor

Partial Public Class PMClientSummaryReport
    Inherits Telerik.Reporting.Report

    Private _ds As List(Of Object)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PMActivitySubReport_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource

        Dim zDS As New Dictionary(Of Integer, ClientDS)
        For Each zItem In Me.ReportDataSource
            If Not zDS.ContainsKey(zItem.FilePrefix) Then
                zDS.Add(zItem.FilePrefix, New ClientDS(zItem.FilePrefix, zItem.ClientName))
            End If
        Next
        Me.DataSource = zDS.Values.ToList
        Me.Table1.DataSource = Me.ReportDataSource
    End Sub

    Public Property ReportDataSource As List(Of Object)
        Get
            Return _ds
        End Get
        Set(value As List(Of Object))
            _ds = value
        End Set
    End Property

    Private Class ClientDS

        Public Property FilePrefix As Integer
        Public Property ClientName As String

        Public Sub New(pFilePrefix, ClientName)
            Me.FilePrefix = pFilePrefix
            Me.ClientName = ClientName
        End Sub

    End Class

End Class