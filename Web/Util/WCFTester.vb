Imports Microsoft.VisualBasic
Imports System.Net
Imports System.Text
Imports System.IO

Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery

Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Public Class WCFTester
    Public WCFBaseURL As String = "" ' "http://localhost" '"http://goccvse05.goccomputers.com"
    Public WCFPort As String = "" ' ":58680/"
    Public WCFServiceEndpoint As String = "" '"KWCFSvr/esJson.svc/"
    Public WCFServiceAction As String = "" '"ProductsCollection_LoadByContainsName"
    Public WCFDataParms As String = "" '"""pea"""
    Public WCFTextLog As String = ""
    Public WCFResponse As String = ""

    Private Sub LogIt(pMessage As String)
        Me.WCFTextLog = Me.WCFTextLog & pMessage & vbCrLf
    End Sub

    Public Function WCFResponseFormatted() As String
        Dim zReturn As String = ""
        Dim zJSONFmt As New JsonFormatter(Me.WCFResponse)

        zReturn = zJSONFmt.Format

        Return zReturn
    End Function

    Public Sub TestHarness1()

        'Create zURL to POST zRequest zData too.
        Dim zURL As String = WCFBaseURL + WCFPort + WCFServiceEndpoint + WCFServiceAction
        LogIt("Making POST Request to: " + zURL + "(" + WCFDataParms + ")")
        LogIt(" Start Time: " & Now)
        Dim zStartTime As Double = Timer
        Dim zAddress As New Uri(zURL)

        'Create webRequest
        Dim zRequest As HttpWebRequest = TryCast(WebRequest.Create(zAddress), HttpWebRequest)

        'the Method property of the zRequest to POST
        zRequest.Method = "POST"
        'Set the ContentType to json
        'our service is expecting WebMessageFormat.Json
        zRequest.ContentType = "application/json; charset=utf-8"

        'define the parameters
        'Dim zData As String = "{""pName"":""cho""}"
        Dim zData As String = WCFDataParms

        'Create a byte array from your parameters
        Dim zByteData As Byte() = UTF8Encoding.UTF8.GetBytes(zData)

        'Set the content length in the zRequest headers
        'this may require back end service alterations
        zRequest.ContentLength = zByteData.Length

        'Make the zRequest by streaming the zData
        Using zDataStream As Stream = zRequest.GetRequestStream()
            zDataStream.Write(zByteData, 0, zByteData.Length)
            zDataStream.Close()
        End Using

        Try
            'Receive the zResponse
            Dim zResponse As HttpWebResponse = TryCast(zRequest.GetResponse(), HttpWebResponse)

            'Get the zResponse stream
            If zResponse IsNot Nothing Then
                Dim zReader As New StreamReader(zResponse.GetResponseStream())

                Me.WCFResponse = zReader.ReadToEnd()

                'Final cleanup
                zReader.Close()
                zResponse.Close()
            End If
        Catch ex As Exception
            'Display exceptions
            LogIt("  ERROR: " & ex.ToString())
        End Try

        LogIt(" End Time: " & Now)
        LogIt("Lapse time: " & Timer - zStartTime & " sec(s)")
        LogIt("Data Length: " & Me.WCFResponse.Length & " char(s)")

    End Sub

    Public Sub TestHarness2()
        'LogIt("Making direct call to: GRC.Connect.Web.DataService.esJson.ClientsCollection_LoadAll(" + "" + ")")
        'LogIt(" Start Time: " & Now)
        'Dim zStartTime As Double = Timer
        'Dim zTC As New Service.DataServer
        'Dim zResponse As jsResponse(Of ClientsCollection, Clients)

        'zResponse = zTC.ClientsCollection_BrowseSummary

        'WCFResponse = zResponse.collection.Count

        'LogIt(" End Time: " & Now)
        'LogIt("Lapse time: " & Timer - zStartTime & " sec(s)")
    End Sub

    Public Sub TestHarness3()
        'LogIt("Making direct call to: GRC.Connect.Web.Service.ViewServer.ViewCCLocationInspectionFireCollection_BrowseByFileNo(" + "" + ")")
        'LogIt(" Start Time: " & Now)
        'Dim zStartTime As Double = Timer
        'Dim zTC As New Service.ViewServer
        'Dim zResponse As jsResponse(Of ViewCCLocationInspectionFireCollection, ViewCCLocationInspectionFire)

        'zResponse = zTC.ViewCCLocationInspectionFireCollection_BrowseByFileNo("1001.0003")

        'WCFResponse = zResponse.collection.Count

        'LogIt(" End Time: " & Now)
        'LogIt("Lapse time: " & Timer - zStartTime & " sec(s)")
    End Sub
End Class

Public Class StringWalker
    Private zTemp As String
    Public Property Index() As Integer
        Get
            Return m_Index
        End Get
        Set(value As Integer)
            m_Index = Value
        End Set
    End Property
    Private m_Index As Integer

    Public Sub New(pData As String)
        zTemp = pData
        Index = -1
    End Sub

    Public Function MoveNext() As Boolean
        If Index = zTemp.Length - 1 Then
            Return False
        End If
        Index += 1
        Return True
    End Function

    Public Function CharAtIndex() As Char
        Return zTemp(Index)
    End Function
End Class

Public Class IndentWriter
    Private zBuilder As New StringBuilder()
    Private zIndent As Integer

    Public Sub Indent()
        zIndent += 1
    End Sub

    Public Sub UnIndent()
        If zIndent > 0 Then
            zIndent -= 1
        End If
    End Sub

    Public Sub WriteLine(pLine As String)
        zBuilder.AppendLine(CreateIndent() + pLine)
    End Sub

    Private Function CreateIndent() As String
        Dim indentString As New StringBuilder()
        For i As Integer = 0 To zIndent - 1
            indentString.Append("    ")
        Next
        Return indentString.ToString()
    End Function

    Public Overrides Function ToString() As String
        Return zBuilder.ToString()
    End Function
End Class


Public Class JsonFormatter
    Private zWalker As StringWalker
    Private zWriter As New IndentWriter()
    Private zCurrentLine As New StringBuilder()
    Private zQuoted As Boolean

    Public Sub New(pJSON As String)
        zWalker = New StringWalker(pJSON)
        ResetLine()
    End Sub

    Public Sub ResetLine()
        zCurrentLine.Length = 0
    End Sub

    Public Function Format() As String
        While MoveNextChar()
            If Me.zQuoted = False AndAlso Me.IsOpenBracket() Then
                Me.WriteCurrentLine()
                Me.AddCharToLine()
                Me.WriteCurrentLine()
                zWriter.Indent()
            ElseIf Me.zQuoted = False AndAlso Me.IsCloseBracket() Then
                Me.WriteCurrentLine()
                zWriter.UnIndent()
                Me.AddCharToLine()
            ElseIf Me.zQuoted = False AndAlso Me.IsColon() Then
                Me.AddCharToLine()
                Me.WriteCurrentLine()
            Else
                AddCharToLine()
            End If
        End While
        Me.WriteCurrentLine()
        Return zWriter.ToString()
    End Function

    Private Function MoveNextChar() As Boolean
        Dim zSuccess As Boolean = zWalker.MoveNext()
        If Me.IsApostrophe() Then
            Me.zQuoted = Not zQuoted
        End If
        Return zSuccess
    End Function

    Public Function IsApostrophe() As Boolean
        Return Me.zWalker.CharAtIndex() = """"c
    End Function

    Public Function IsOpenBracket() As Boolean
        Return Me.zWalker.CharAtIndex() = "{"c OrElse Me.zWalker.CharAtIndex() = "["c
    End Function

    Public Function IsCloseBracket() As Boolean
        Return Me.zWalker.CharAtIndex() = "}"c OrElse Me.zWalker.CharAtIndex() = "]"c
    End Function

    Public Function IsColon() As Boolean
        Return Me.zWalker.CharAtIndex() = ","c
    End Function

    Private Sub AddCharToLine()
        Me.zCurrentLine.Append(zWalker.CharAtIndex())
    End Sub

    Private Sub WriteCurrentLine()
        Dim zLine As String = Me.zCurrentLine.ToString().Trim()
        If zLine.Length > 0 Then
            zWriter.WriteLine(zLine)
        End If
        Me.ResetLine()
    End Sub
End Class

