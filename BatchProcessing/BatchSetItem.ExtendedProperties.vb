Imports GRC.Connect.Libraries.DataLib.razor

Partial Class BatchSetItem
    Public Class ExtendedProperties
        Public ChartInfo As New ChartInfo

        Public Function ToJSON() As String
            Return Newtonsoft.Json.JsonConvert.SerializeObject(Me)
        End Function
    End Class

    Public Class ChartInfo
        Public ChartNavLink As New rowTblNavLink                                                           'THIS IS THE PARENT CHART NAVLINK
        Public ChartChildInfo As New List(Of rowVwNavLinkChartDrillDownInfo)                     'THESE ARE THE CHILD CHARTS TO THE PARENT
    End Class

End Class
