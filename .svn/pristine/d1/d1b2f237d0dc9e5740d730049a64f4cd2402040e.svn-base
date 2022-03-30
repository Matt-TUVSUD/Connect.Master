Imports System.Configuration.ConfigurationManager

Public Class UtilAppSetting

    Public Shared Function ReadDBMode() As DBMode
        If Not String.IsNullOrEmpty(Configuration.ConfigurationManager.AppSettings.AllKeys.ToList.Find(Function(x) x = "DBMode")) Then

            Dim zDBMode As String = AppSettings("DBMode")

            Select Case zDBMode.ToLower
                Case "live"
                    Return DBMode.Live
                Case "test"
                    Return DBMode.Test
                Case "dev"
                    Return DBMode.Dev
                Case "beta"
                    Return DBMode.Beta
                Case Else
                    Throw New ApplicationException("The AppSetting " & Chr(34) & "DBMode" & Chr(34) & " has invalid value. Valid values for DBMode are Live, Test, Dev or Beta.")
            End Select
        Else
            Throw New ApplicationException("The AppSetting " & Chr(34) & "DBMode" & Chr(34) & " is missing from the configuration file.")
        End If

    End Function

    Public Enum DBMode
        Beta
        Test
        Live
        Dev
    End Enum

End Class
