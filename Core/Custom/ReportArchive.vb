'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/24/2013 4:25:52 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class ReportArchive 
		Inherits esReportArchive

		Public Sub New()

		End Sub

        Public ReadOnly Property Report1PhysicalPath() As String
            Get
                If Me.Report1 IsNot Nothing Then
                    If Me.Report1 <> "" Then
                        Return BasePhysicalPath & UrlDecode(Me.Report1.Replace("#", ""))
                    End If
                End If
                Return ""
            End Get
        End Property

        Public ReadOnly Property Report2PhysicalPath() As String
            Get
                If Me.Report2 IsNot Nothing Then
                    If Me.Report2 <> "" Then
                        Return BasePhysicalPath & UrlDecode(Me.Report2.Replace("#", ""))
                    End If
                End If
                Return ""
            End Get
        End Property

        Public ReadOnly Property DiagramPhysicalPath() As String
            Get
                If Me.Diagram IsNot Nothing Then
                    If Me.Diagram <> "" Then
                        Return BasePhysicalPath & UrlDecode(Me.Diagram.Replace("#", ""))
                    End If
                End If
                Return ""
            End Get
        End Property


        Public Function Report1Exists() As Boolean
            If Report1PhysicalPath <> String.Empty Then
                Return IO.File.Exists(Report1PhysicalPath)
            End If
            Return True
        End Function

        Public Function Report2Exists() As Boolean
            If Report2PhysicalPath <> String.Empty Then
                Return IO.File.Exists(Report2PhysicalPath)
            End If
            Return True
        End Function

        Public Function DiagramExists() As Boolean
            If DiagramPhysicalPath <> String.Empty Then
                Return IO.File.Exists(DiagramPhysicalPath)
            End If
            Return True
        End Function

        Private ReadOnly Property BasePhysicalPath As String
            Get
                Return "\\extra-data\ClientsWEB_D\data\" & ClientFolder & "\"
            End Get
        End Property

        Private ReadOnly Property ClientFolder As String
            Get
                Dim zClient As New Libraries.CoreLib.BusinessObjects.Clients
                zClient.LoadByFilePrefix(Int(Me.FileNo))
                Dim zCldbName As String = zClient.Cldbname
                Return "cldb" & zCldbName
            End Get
        End Property

        Private Function UrlDecode(ByVal pUrl As String) As String
            Return System.Web.HttpUtility.HtmlDecode(pUrl)
        End Function

        Public ReadOnly Property Client As Libraries.CoreLib.BusinessObjects.Clients
            Get
                Dim zObj As New Libraries.CoreLib.BusinessObjects.Clients
                zObj.LoadByFilePrefix(Int(Me.FileNo))
                Return zObj
            End Get
        End Property

        Public Shared Function GetLatestReportDate(ByVal pFileNo As String, ByVal pPractice As UtilMetaPractice.Practices) As Date
            Dim zQry As New ReportArchiveQuery
            zQry.Select(zQry.ReportDate.Max)
            zQry.Where(zQry.FileNo = pFileNo)
            zQry.Where(zQry.MetaPracticeID = pPractice)

            Dim zRet As Object = zQry.ExecuteScalar
            If IsDate(zRet) Then
                Return zRet
            Else
                Return SqlTypes.SqlDateTime.MinValue
            End If

        End Function

    End Class

End Namespace
