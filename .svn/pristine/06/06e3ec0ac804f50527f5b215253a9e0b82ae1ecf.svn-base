Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.IO
Imports System.Collections.Generic
Imports System.Xml

Public Class FileSystemHandler
    Implements IHttpHandler
#Region "IHttpHandler Members"

    Private pathToConfigFile As String = "~/CodeExplorer/MappingFile.mapping"
    Private _context As HttpContext
    Private Property Context() As HttpContext
        Get
            Return _context
        End Get
        Set(ByVal value As HttpContext)
            _context = value
        End Set
    End Property

    Dim _itemHandlerPath As String
    Dim mappedPathsInConfigFile As Dictionary(Of String, String)

    Private Sub Initialize()
        Dim configFile As New XmlDocument()
        Dim physicalPathToConfigFile As String = Context.Server.MapPath(Me.pathToConfigFile)
        configFile.Load(physicalPathToConfigFile)
        ' Load the configuration file
        Dim rootElement As XmlElement = configFile.DocumentElement

        Dim handlerPathSection As XmlNode = rootElement.GetElementsByTagName("genericHandlerPath")(0)
        ' get all mappings ;
        Me._itemHandlerPath = handlerPathSection.InnerText

        Me.mappedPathsInConfigFile = New Dictionary(Of String, String)()
        Dim mappingsSection As XmlNode = rootElement.GetElementsByTagName("Mappings")(0)
        ' get all mappings ;
        For Each mapping As XmlNode In mappingsSection.ChildNodes
            Dim virtualPathAsNode As XmlNode = mapping.SelectSingleNode("child::VirtualPath")
            Dim physicalPathAsNode As XmlNode = mapping.SelectSingleNode("child::PhysicalPath")
            Me.mappedPathsInConfigFile.Add(PathHelper.RemoveEndingSlash(virtualPathAsNode.InnerText, "/"c), PathHelper.RemoveEndingSlash(physicalPathAsNode.InnerText, "\"c))
        Next
    End Sub


    Public Sub ProcessRequest(ByVal context__1 As HttpContext) Implements IHttpHandler.ProcessRequest
        Context = context__1

        If Context.Request.QueryString("path") Is Nothing Then
            Exit Sub
        End If

        Initialize()

        Dim virtualPathToFile As String = Context.Server.HtmlDecode(Context.Request.QueryString("path"))
        Dim physicalPathToFile As String = ""

        For Each mappedPath As KeyValuePair(Of String, String) In mappedPathsInConfigFile
            If virtualPathToFile.ToLower().StartsWith(mappedPath.Key.ToLower()) Then
                ' Build the physical path to the file ;
                physicalPathToFile = virtualPathToFile.Replace(mappedPath.Key, mappedPath.Value).Replace("/", "\")

                ' Brak the foreach loop ;
                Exit For
            End If
        Next

        ' The docx files are downloaded ;
        If Path.GetExtension(physicalPathToFile).Equals(".docx", StringComparison.CurrentCultureIgnoreCase) Then
            ' Handle .docx files ;
            Me.WriteFile(physicalPathToFile, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", Context.Response)
        End If

        If Path.GetExtension(physicalPathToFile).Equals(".jpg", StringComparison.CurrentCultureIgnoreCase) Then
            ' Handle .jpg files ;
            WriteFile(physicalPathToFile, "image/jpeg", Context.Response)
        End If

        ' "txt/html" is the default valuse for Response.ContentType property;
        ' do not download the file. Open in the window ;
        Context.Response.WriteFile(physicalPathToFile)
    End Sub


    ''' <summary>
    ''' Forces browser to download the file
    ''' </summary>
    ''' <param name="physicalPathToFile">Physical path to the file on the server </param>
    ''' <param name="contentType">The file content type</param>
    Private Sub WriteFile(ByVal physicalPathToFile As String, ByVal contentType As String, ByVal response As HttpResponse)
        response.Buffer = True
        response.Clear()
        Dim ct As String = response.ContentType
        If Not contentType = "" Then
            response.ContentType = contentType
        End If

        Dim extension As String = Path.GetExtension(physicalPathToFile)

        If extension <> ".htm" AndAlso extension <> ".html" AndAlso extension <> ".xml" Then
            response.AddHeader("content-disposition", "attachment; filename=" & Path.GetFileName(physicalPathToFile))
        End If
        response.WriteFile(physicalPathToFile)
        response.Flush()
        response.[End]()
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property


#End Region
End Class
