Imports System.Configuration.ConfigurationManager

Public Class UtilDB

    Public Shared Function ReadConnectionString(pDatabase As Databases) As String

        Dim zCSName As String = pDatabase.ToString & "." & UtilAppSetting.ReadDBMode().ToString
        Dim zSettings As System.Configuration.ConnectionStringSettings = ConnectionStrings(zCSName)

        If IsNothing(zSettings) Then
            Throw New ApplicationException(GetExceptionMessage(pDatabase.ToString, zCSName))
        End If

        Return zSettings.ConnectionString
    End Function

    Private Shared Function GetExceptionMessage(pDatabase As String, pExpectedConnectionStringName As String)
        Return "ConnectionString [" & pExpectedConnectionStringName & "] not found. Ensure the config file has a ConnectionString named " & _
            Chr(34) & pDatabase & ".<env>" & Chr(34) & " with <env> portion being Live, Test, Dev or Beta."
    End Function

    Public Enum Databases
        Connect
    End Enum

End Class
