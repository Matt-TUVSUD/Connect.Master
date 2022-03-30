Imports EntitySpaces.Interfaces
'Imports EntitySpaces.Profiler

Public Class UtilESStart
    Public Shared Sub InitEngine()
        esProviderFactory.Factory = New EntitySpaces.Loader.esDataProviderFactory()

        'ProfilerListener.BeginProfiling("EntitySpaces.SqlClientProvider", ProfilerListener.Channels.Channel_4)

        Dim zConn As New esConnectionElement
        zConn.Name = "Default"
        zConn.ConnectionString = UtilDB.ConnectionString()
        zConn.Provider = "EntitySpaces.SqlClientProvider"
        zConn.ProviderClass = "DataProvider"
        zConn.SqlAccessType = esSqlAccessType.DynamicSQL
        zConn.ProviderMetadataKey = "esDefault"
        zConn.DatabaseVersion = "2005"
        zConn.CommandTimeout = 7 * 60 'Seven minutes

        esConfigSettings.ConnectionInfo.Connections.Add(zConn)
        esConfigSettings.ConnectionInfo.Default = "Default"
    End Sub

    Public Shared Sub InitEngine(pConnectionString As String)
        esProviderFactory.Factory = New EntitySpaces.Loader.esDataProviderFactory()

        'ProfilerListener.BeginProfiling("EntitySpaces.SqlClientProvider", ProfilerListener.Channels.Channel_4)

        Dim zConn As New esConnectionElement
        zConn.Name = "Default"
        zConn.ConnectionString = pConnectionString
        zConn.Provider = "EntitySpaces.SqlClientProvider"
        zConn.ProviderClass = "DataProvider"
        zConn.SqlAccessType = esSqlAccessType.DynamicSQL
        zConn.ProviderMetadataKey = "esDefault"
        zConn.DatabaseVersion = "2005"
        zConn.CommandTimeout = 7 * 60 'Seven minutes

        esConfigSettings.ConnectionInfo.Connections.Add(zConn)
        esConfigSettings.ConnectionInfo.Default = "Default"
    End Sub


End Class