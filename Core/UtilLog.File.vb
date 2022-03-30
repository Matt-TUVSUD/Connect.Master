Partial Class UtilLog
    Public Class File
        Private _LogFilePath As String = ""
        'Test
        Public Enum LogFile
            Report
            Grid
            StoredPrcoedure
            Mail
            Chart
        End Enum

        Public Sub New(ByVal pAppPath As String, ByVal pLogFile As LogFile)
            _LogFilePath = pAppPath & Libraries.CoreLib.UtilSystemParms.LogFilesPhysicalPath & GetFileName(pLogFile)
        End Sub

        Public Sub Write(ByVal pMessage As String)
            If Libraries.CoreLib.UtilSystemParms.LogFilesEnabled Then
                IO.File.AppendAllLines(_LogFilePath, {Now() & " -- " & pMessage})
            End If
        End Sub

        Public Sub OpenFile(ByVal pLogFile As LogFile)
            Process.Start(_LogFilePath)
        End Sub

        Public Sub WriteStack()
            Dim zStack As New Diagnostics.StackTrace
            Write(zStack.ToString())
        End Sub

        Private Function GetFileName(ByVal pLogFile As LogFile)
            Select Case pLogFile
                Case LogFile.Report
                    Return ReportLogFileName
                Case LogFile.Grid
                    Return GridLogFileName
                Case LogFile.StoredPrcoedure
                    Return StoredProcedureLogFileName
                Case LogFile.Mail
                    Return MailLogFileName
                Case LogFile.Chart
                    Return ChartLogFileName
                Case Else
                    Return Nothing
            End Select
        End Function

        Private ReadOnly Property ReportLogFileName As String
            Get
                Return "Report.log"
            End Get
        End Property

        Private ReadOnly Property GridLogFileName As String
            Get
                Return "Grid.log"
            End Get
        End Property

        Private ReadOnly Property StoredProcedureLogFileName As String
            Get
                Return "StoredProcedure.log"
            End Get
        End Property

        Private ReadOnly Property MailLogFileName As String
            Get
                Return "Mail.log"
            End Get
        End Property

        Private ReadOnly Property ChartLogFileName As String
            Get
                Return "Chart.log"
            End Get
        End Property

    End Class
End Class
