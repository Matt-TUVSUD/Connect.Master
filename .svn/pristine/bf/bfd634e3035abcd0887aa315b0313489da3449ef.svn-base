Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilReport
    Public Class SQL
        Public Shared Function GetTranslationSQL(toLanguage As TblMetaLanguage.Languages) As String
            Dim zColName As String = TblMetaLanguage.GetColumnName(toLanguage)
            Return "Select Type, [Table], LabelName, PartitionId, EnglishTranslation," & zColName & " as DestinationLanguage FROM rv.vwTranslation"
        End Function

        Public Shared Function GetImpairmentChartDataSQL(ByVal pFilePrefix As String) As String
            Return "select * from viewImpairmentChartData where FileNo Like '" & pFilePrefix & ".%'"
        End Function

        Public Shared Function GetImpairmentChartDataPartitionsSQL() As String
            Return "select * from viewImpairmentChartDataPartitions"
        End Function

    End Class
End Class
