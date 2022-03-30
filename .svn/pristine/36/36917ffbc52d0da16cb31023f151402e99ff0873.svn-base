Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilMetaMapPin



    Public Shared Function GetPinMetaDataSQL(pData As DataTable) As String

        Dim zList As List(Of DataRow) = pData.DefaultView.ToTable(True, {"MapPinIcon"}).Select().ToList

        Dim zQ As New queryTblMetaMapPin
        zQ.SelectAll()
        zQ.Where.SetConjuction(UtilSQLServer.ConjuctionOperatorEnum.Or)
        zList.ForEach(Sub(x) zQ.Where.Add(zQ.colFldIcon.Equals(x("MapPinIcon").ToString)))

        Return zQ.QueryText

    End Function
End Class
