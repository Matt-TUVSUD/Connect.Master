Public Class BatchSetList
    Inherits List(Of BatchSet)

    Public Sub New(ParamArray batchsets As BatchSet())
        Me.AddRange(batchsets)
    End Sub

    Public Sub SaveAll()

        For Each zBatchSet As BatchSet In Me
            zBatchSet.Save(True)
        Next

        Dim zTrx As SqlClient.SqlTransaction = DataLib.razor.UtilSQLServer.GetConnectionObject().BeginTransaction()
        Using zTrx
            For Each zBatchSet As BatchSet In Me
                zBatchSet.SetAsDefined(zTrx)
            Next
            zTrx.Commit()
        End Using

    End Sub

End Class
