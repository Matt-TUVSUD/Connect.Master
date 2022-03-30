Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilMetaPractice

    Public Shared Function GetClientMetaPracticeList(pFilePrefix As String) As List(Of rowVwClientMetaPractice)

        Dim zQry As New queryVwClientMetaPractice
        zQry.SelectAll()
        zQry.Where.Add(zQry.colFilePrefix.Equals(pFilePrefix))
        Return VwClientMetaPractice.LoadData(zQry.QueryText)

    End Function

    Public Enum Practices
        All = 1
        BoilerAndMachinery = 2
        Fire = 3
        Infrared = 4
        Jurisdictional = 5
        NatHazFlood = 6
        NatHazSeismic = 7
        NatHazWind = 8
        NaturalHazards = 9
        DiversifiedServices = 10
        ProcessSafety = 11
    End Enum

End Class
