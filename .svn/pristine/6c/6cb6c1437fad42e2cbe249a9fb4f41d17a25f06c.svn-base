
Module Module1

    Sub Main()

        UtilSQLServer.SetConnection(UtilDB.ConnectionString)
        Try
            Dim zAutoRec As New AutoRecLib.UtilAutoRec(AutoRecProcessing.UtilAutoRec.Modes.Normal, "daniel.barasch@globalriskconsultants.com")
            zAutoRec.ProcessCleanUp()
            zAutoRec.ProcessDailyFollowUps()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(ex.Message & vbNewLine & ex.StackTrace)
            Stop
        End Try

    End Sub



End Module
