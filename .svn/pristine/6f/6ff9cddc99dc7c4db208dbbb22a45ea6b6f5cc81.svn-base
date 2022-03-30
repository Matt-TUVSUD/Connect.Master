Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports GRC.Connect.Libraries.DataLib.razor

Public Class CopeRecommendationsSubReport_Portrait
    Inherits Telerik.Reporting.Report
    Implements IUtilReport

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SetVisibility(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
        Dim zRpt As Processing.Report = DirectCast(sender, Processing.Report)
        Dim zSubRpt As Processing.SubReport = zRpt.ParentElement
        Dim zDetailSections() As Processing.LayoutElement = Processing.ElementTreeHelper.FindChildByName(zRpt, "Detail", True)
        If zDetailSections.Count = 0 Then
            '  zSubRpt.Visible = False
        End If

        If Not UtilCustomFeature.Contains(rptProperties, UtilCustomFeature.Letter.U) Then
            RatingDetailPanel.Visible = False
            RatingHeaderPanel.Visible = False
            uxKeywordsLabel.Width = uxKeywords.Width.Add(RatingDetailPanel.Width)
            uxKeywords.Width = uxKeywordsLabel.Width
        End If


    End Sub

    Private Function GetDataSource() As DataTable
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM" & GetRecommendationViewName() & "WHERE filePrefix='" & rptProperties.FilePrefix & "' AND recstatus NOT IN('Removed','Conf Completed')", zCon)
        Dim zDT As New DataTable
        zCon.Open()
        Using zCon
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using
        Return zDT
    End Function

    Private _props As IBatchSetReportProperties = Nothing
    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties
        Get
            Return _props
        End Get
        Set(value As IBatchSetReportProperties)
            _props = value
        End Set
    End Property

    Public ReadOnly Property CurrencyID As Integer
        Get
            Try
                Return _props.Currency.colFldId
            Catch ex As Exception
                Return 1
            End Try
        End Get
    End Property

    Private Sub CopeRecommendationsSubReport_Portrait_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Me.DataSource = GetDataSource()
    End Sub

    Private Function GetRecommendationViewName() As String
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.Fire Then Return " bv.vwFireRecommendationsBaseView "
        If rptProperties.Practice.Practice = TblMetaPractice.Practices.BM Then Return " rv.vwBMCopeRecommendations "
        Return ""
    End Function

End Class