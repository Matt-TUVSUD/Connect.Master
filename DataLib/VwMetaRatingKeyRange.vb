Namespace razor

    Partial Public Class VwMetaRatingKeyRange

        Shared Function LoadByKey(pKeyID As Integer) As List(Of rowVwMetaRatingKeyRange)

            Dim zQ As New razor.queryVwMetaRatingKeyRange
            zQ.SelectAll()
            zQ.Where.Add(zQ.colFldKeyId.Equals(pKeyID))

            Return VwMetaRatingKeyRange.LoadData(zQ.QueryText)

        End Function

    End Class
End Namespace
