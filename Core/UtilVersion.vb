Imports Microsoft.VisualBasic
Imports System.Xml
Imports System.IO

Public Class UtilVersion
    Private m_Rev As String = ""
    Private m_Date As String = ""

    Private Sub ReadXML(ByVal pFile As String)
        Dim zCharData As Integer
        Dim zLineData As String = ""
        Dim oRead As System.IO.StreamReader
        Dim zStart As Integer = 0
        Dim zEnd As Integer = 0
        Dim zKey1Start As String = "<WCREV>"
        Dim zKey1End As String = "</WCREV>"
        Dim zKey2Start As String = "<WCDATE>"
        Dim zKey2End As String = "</WCDATE>"
        oRead = File.OpenText(pFile)

        While oRead.Peek <> -1
            zCharData = oRead.Read()
            Select Case zCharData
                Case 10
                Case 13
                    If InStr(zLineData, zKey1Start) Then
                        zStart = InStr(zLineData, zKey1Start) + Len(zKey1Start)
                        zEnd = InStr(zLineData, zKey1End)
                        m_Rev = Mid(zLineData, zStart, zEnd - zStart)
                    End If

                    If InStr(zLineData, zKey2Start) Then
                        zStart = InStr(zLineData, zKey2Start) + Len(zKey2Start)
                        zEnd = InStr(zLineData, zKey2End)
                        m_Date = Mid(zLineData, zStart, zEnd - zStart)
                    End If

                    zLineData = ""
                Case Else
                    zLineData = zLineData & Chr(zCharData)
            End Select
        End While
        oRead.Close()
    End Sub

    Public Function GetRevisionNumber() As String
        Return m_Rev
    End Function

    Public Function GetRevisionDate() As String
        Return m_Date
    End Function

    Public Sub New(ByVal pFile As String)
        Call ReadXML(pFile)
    End Sub
End Class
