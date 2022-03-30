Imports System.Windows.Forms

Public Class UtilWebBrowser

    Public Property gHTML As String
    Dim zLog As New UtilLog

    Public Function GetWebHTMLString(ByVal pURL As String) As String
        Dim zReturn As String = Nothing
        zLog.LogIt("Start WebBrowser init and threads.")

        ' CLEAR CACHE BEFORE START
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8") 'TEMP INT FILES
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 16") 'FORM DATA

        ' CREATE THE THREAD FOR THE WEBBROWSER CONTROL
        Dim zThreadStart As New Threading.ThreadStart(Sub() WebBrowserCreate(pURL))
        Dim zThread As New Threading.Thread(zThreadStart)
        zThread.SetApartmentState(Threading.ApartmentState.STA)
        zThread.Start()
        zThread.Join()


        zLog.LogIt("End WebBrowser init and threads and return HTML.")
        zReturn = gHTML

        Return zReturn

    End Function

    Private Sub WebBrowserCreate(ByVal pURL As String)
        zLog.LogIt("Start WebBrowserCreate thread for " & pURL & ".")
        zLog.LogIt("Thread User " & Threading.Thread.CurrentPrincipal.Identity.Name & ".")

        Try
            ' CREATE A WEB BROWSER
            Dim zURL As String = pURL ' AVAILABLE TO DO VALIDATION AGAINST URL IF NEEDED
            Dim gBrowser = New WebBrowser()
            Using gBrowser
                gBrowser.ScrollBarsEnabled = False
                gBrowser.AllowNavigation = True
                gBrowser.ScriptErrorsSuppressed = True
                gBrowser.Width = 1280
                gBrowser.Height = 1024
                AddHandler gBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf Me.WebBrowserComplete)
                gBrowser.Navigate(zURL)
                Wait(gBrowser)
            End Using
            zLog.LogIt("End WebBrowserCreate thread for " & pURL & ".")
        Catch ex As Exception

            zLog.LogIt("Exception: " & ex.Message & ".")

        End Try
    End Sub

    Public Sub Wait(ByRef browser As WebBrowser)
        Do
            System.Windows.Forms.Application.DoEvents()
        Loop While browser.ReadyState <> WebBrowserReadyState.Complete

    End Sub

    Private Sub WebBrowserComplete(pSender As Object, pEvent As WebBrowserDocumentCompletedEventArgs)
        zLog.LogIt("Start WebBrowserComplete thread.")

        Try
            System.Windows.Forms.Application.DoEvents()

            ' ATTEMPT TO WAIT FOR ANY ANIMATIONS 
            Dim zEnd As DateTime = Now.AddSeconds(1)

            Do While Now() < zEnd
                System.Windows.Forms.Application.DoEvents()
            Loop

            ' GET THE FINAL RESULTS
            Dim zBrowser As WebBrowser = TryCast(pSender, WebBrowser)

            ' REMOVE ANY NON-PRINTABLE DOMS
            For Each zElement As HtmlElement In zBrowser.Document.All
                If zElement.GetAttribute("className") = "printNone" Then
                    zElement.OuterHtml = ""
                End If
            Next

            ' RETURN THE HTML
            Dim zDocument As String = zBrowser.Document.GetElementsByTagName("HTML")(0).OuterHtml
            gHTML = zDocument

            zLog.LogIt("End WebBrowserComplete thread.")

        Catch ex As Exception

            zLog.LogIt("Exception in WebBrowserComplete : " & ex.Message & ".")

        End Try

    End Sub

End Class
