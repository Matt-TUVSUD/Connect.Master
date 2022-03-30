Imports System.Collections.Generic
Imports System.Web
Imports Telerik.Web.UI.Widgets
Imports System.IO
Imports System.Xml
Imports System.Text.RegularExpressions

''' <summary>
''' Summary description for CustomFileSistemProvider
''' </summary>
Public Class CustomFileSystemProvider
    Inherits FileBrowserContentProvider
    Private _itemHandlerPath As String
    Protected ReadOnly Property ItemHandlerPath() As String
        Get
            Return Me._itemHandlerPath
        End Get
    End Property

    Private mappedPathsInConfigFile As Dictionary(Of String, String)
    Private pathToConfigFile As String = "~/CodeExplorer/MappingFile.mapping"

    ''' <summary>
    ''' Returns the mappings from the configuration file
    ''' </summary>
    Protected ReadOnly Property MappedPaths() As Dictionary(Of String, String)
        Get
            Return mappedPathsInConfigFile
        End Get
    End Property

    Public Sub New(ByVal context As HttpContext, ByVal searchPatterns As String(), ByVal viewPaths As String(), ByVal uploadPaths As String(), ByVal deletePaths As String(), ByVal selectedUrl As String, _
     ByVal selectedItemTag As String)
        MyBase.New(context, searchPatterns, viewPaths, uploadPaths, deletePaths, selectedUrl, _
         selectedItemTag)
        ' The 'viewPaths' contains values like "C:\Foder_1\Folder_2" or "C:\Foder_1\Folder_2\"


        Me.Initialize()
    End Sub

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

    Public Overrides Function ResolveRootDirectoryAsTree(ByVal path As String) As DirectoryItem
        Dim physicalPath As String
        Dim virtualPath As String = String.Empty

        If PathHelper.IsSharedPath(path) OrElse PathHelper.IsPhysicalPath(path) Then
            ' The path is a physical path
            physicalPath = path

            For Each mappedPath As KeyValuePair(Of String, String) In MappedPaths
                ' Checks whether a mapping exists for the current physical path
                ' 'mappedPath.Value' does not end with trailing slash. It looks like : "C:\Path\Dir"
                If physicalPath.StartsWith(mappedPath.Value, StringComparison.CurrentCultureIgnoreCase) Then
                    ' Exists 
                    ' Get the part of the physical path which does not contain the mappeed part
                    Dim restOfPhysicalPath As String = physicalPath.Substring(mappedPath.Value.Length)

                    ' 'mappedPath.Value' does not end with '\'
                    ' // The 'restOfVirtualPath' is something like Folder_1/SubFolder_2/ ==> convert it to Folder_1\SubFolder_2\
                    virtualPath = mappedPath.Key & restOfPhysicalPath.Replace("\"c, "/"c)


                    virtualPath = PathHelper.AddEndingSlash(virtualPath, "/"c)
                    ' Exit the 'foreach' loop ;
                    Exit For
                End If
            Next
        Else
            ' Virtual path ;
            virtualPath = PathHelper.AddEndingSlash(path, "/"c)
            physicalPath = Me.GetPhysicalFromVirtualPath(path)
            If physicalPath Is Nothing Then
                Return Nothing
            End If
        End If

        ' Files are added in the ResolveDirectory method
        Dim result As New DirectoryItem(PathHelper.GetDirectoryName(physicalPath), String.Empty, virtualPath, String.Empty, GetPermissions(physicalPath), New FileItem() {}, _
         GetDirectories(virtualPath))

        Return result
    End Function

    Public Overrides Function ResolveDirectory(ByVal virtualPath As String) As DirectoryItem
        Dim physicalPath As String
        physicalPath = Me.GetPhysicalFromVirtualPath(virtualPath)

        If physicalPath Is Nothing Then
            Return Nothing
        End If

        ' Directories are added in ResolveRootDirectoryAsTree method
        Dim result As New DirectoryItem(PathHelper.GetDirectoryName(physicalPath), virtualPath, virtualPath, virtualPath, GetPermissions(physicalPath), GetFiles(virtualPath), _
        New DirectoryItem() {})

        Return result
    End Function

    Public Overrides Function MoveDirectory(ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        virtualSourcePath = PathHelper.AddEndingSlash(virtualSourcePath, "/"c)
        virtualDestPath = PathHelper.AddEndingSlash(virtualDestPath, "/"c)

        Dim physicalSourcePath As String

        physicalSourcePath = Me.GetPhysicalFromVirtualPath(virtualSourcePath)
        If physicalSourcePath Is Nothing Then
            Return String.Format("The virtual path :'{0}' cannot be converted to a physical path", virtualSourcePath)
        End If

        Dim physicalDestinationPath As String
        physicalDestinationPath = Me.GetPhysicalFromVirtualPath(virtualDestPath)
        If physicalDestinationPath Is Nothing Then
            Return String.Format("The virtual path :'{0}' cannot be converted to a physical path", virtualDestPath)
        End If

        Dim newFolderName As String = physicalDestinationPath

        ' Checks whether the folder already exists in the destination folder ;
        If Directory.Exists(newFolderName) Then
            ' Yes the folder exists :
            Dim message As String = String.Format("The folder '{0}' already exists", virtualDestPath)
            Return message
        End If

        ' Checks whether the source directory is parent of the destination directory ;
        If PathHelper.IsParentOf(virtualSourcePath, virtualDestPath) Then
            Dim message As String = String.Format("The folder  '{0}' is parent of the '{1}' directory. Operation is canceled!", virtualSourcePath, virtualDestPath)
            Return message
        End If

        ' There is not a permission issue with the FileExplorer's permissions ==> Move can be performed
        ' But, there can be some FileSystem permissions issue (file system's read/write permissions) ;
        Dim errorMessage As String = FileSystem.MoveDirectorty(physicalSourcePath, physicalDestinationPath, virtualSourcePath, virtualDestPath)
        Return errorMessage
    End Function

    Public Overrides Function MoveFile(ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        Dim physicalSourcePath As String
        physicalSourcePath = Me.GetPhysicalFromVirtualPath(virtualSourcePath)
        If physicalSourcePath Is Nothing Then
            Return String.Format("The virtual path :'{0}' cannot be converted to a physical path", virtualSourcePath)
        End If

        Dim physicalDestinationPath As String = Me.GetPhysicalFromVirtualPath(virtualDestPath)

        If physicalDestinationPath Is Nothing Then
            Return String.Format("The virtual path :'{0}' cannot be converted to a physical path", virtualDestPath)
        End If

        ' Check whether the file already exists in the destination folder
        If File.Exists(physicalDestinationPath) Then
            ' Yes the file exists :
            Dim message As String = String.Format("The file '{0}' already exists", virtualDestPath)
            Return message
        End If

        ' There is not permission issue with the FileExplorer's permissions ==> Move can be performed
        ' There can be some FileSystem error 
        Dim errorMessage As String = FileSystem.MoveFile(physicalSourcePath, physicalDestinationPath, virtualSourcePath, virtualDestPath)
        Return errorMessage
    End Function

    Public Overrides Function DeleteDirectory(ByVal virtualTargetPath As String) As String
        Dim physicalTargetPath As String
        physicalTargetPath = Me.GetPhysicalFromVirtualPath(virtualTargetPath)
        If physicalTargetPath Is Nothing Then
            Return String.Format("The virtual path : '{0}' cannot be converted to a physical path", virtualTargetPath)
        End If

        ' There is not permission issue with the FileExplorer's permissions ==> Delete can be performed
        ' but there can be some FileSystem restrictions 
        Dim errorMessage As String = FileSystem.DeleteDirectory(physicalTargetPath, virtualTargetPath)
        Return errorMessage
    End Function
    Public Overrides Function DeleteFile(ByVal virtualTargetPath As String) As String
        Dim physicalTargetPath As String = Me.GetPhysicalFromVirtualPath(virtualTargetPath)
        If physicalTargetPath Is Nothing Then
            Return String.Format("The virtual path :'{0} cannot be converted to a physical path", virtualTargetPath)
        End If

        ' There is not a permission issue with the FileExplorer's permissions ==> Delete can be performed,
        ' but there can be some FileSystem restriction
        Dim errorMessage As String = FileSystem.DeleteFile(physicalTargetPath, virtualTargetPath)
        Return errorMessage
    End Function

    Public Overrides Function CopyDirectory(ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        Dim physicalSourcePath As String = Me.GetPhysicalFromVirtualPath(virtualSourcePath)
        If physicalSourcePath Is Nothing Then
            Return String.Format("The virtual path : '{0}' cannot be converted to a physical path", virtualSourcePath)
        End If

        Dim physicalDestinationPath As String = Me.GetPhysicalFromVirtualPath(virtualDestPath)
        If physicalDestinationPath Is Nothing Then
            Return String.Format("The virtual path : '{0}' cannot be converted to a physical path", virtualDestPath)
        End If

        Dim newFolderName As String = physicalDestinationPath & PathHelper.GetDirectoryName(physicalSourcePath)

        ' Check whether the folder already exists in the destination folder
        If Directory.Exists(newFolderName) Then
            ' Yes the folder exists:
            Dim message As String = String.Format("The folder: '{0}{1}' already exists", virtualDestPath, PathHelper.GetDirectoryName(physicalSourcePath))
            Return message
        End If

        ' A check whether the source directory is parent of the destination directory
        If PathHelper.IsParentOf(virtualSourcePath, virtualDestPath) Then
            Dim message As String = String.Format("The directory: '{0}' is parent of the '{1}' directory. Operation is canceled!", virtualSourcePath, virtualDestPath)
            Return message
        End If

        ' FileSystem.CopyDirectory returns a string that contains the error or an empty string
        Dim errorMessage As String = FileSystem.CopyDirectory(physicalSourcePath, physicalDestinationPath, virtualSourcePath, virtualDestPath)
        Return errorMessage
    End Function

    Public Overrides Function CopyFile(ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        Dim physicalSourcePath As String = Me.GetPhysicalFromVirtualPath(virtualSourcePath)
        If physicalSourcePath Is Nothing Then
            Return String.Format("The virtual path: '{0}' cannot be converted to a physical path", virtualSourcePath)
        End If

        Dim physicalDestinationPath As String = Me.GetPhysicalFromVirtualPath(virtualDestPath)
        If physicalDestinationPath Is Nothing Then
            Return String.Format("The virtual path: '{0}' cannot be converted to a physical path", virtualDestPath)
        End If

        ' Checks whether the file already exists in the destination folder ;
        If File.Exists(physicalDestinationPath) Then
            ' Yes the file exists :
            Dim message As String = String.Format("The file: '{0}' already exists. Operation IS canceled!", virtualDestPath)
            Return message
        End If

        ' There is not a permission issue with the FileExplorer's permissions ==> Copy can be performed,
        ' but there can be some FileSystem restrictions 
        Dim errorMessage As String = FileSystem.CopyFile(physicalSourcePath, physicalDestinationPath, virtualSourcePath, virtualDestPath)
        Return errorMessage
    End Function

    Public Overrides Function CreateDirectory(ByVal virtualTargetPath As String, ByVal name As String) As String
        Dim physicalTargetPath As String = Me.GetPhysicalFromVirtualPath(virtualTargetPath)
        If physicalTargetPath Is Nothing Then
            Return String.Format("The virtual path: '{0}' cannot be converted to a physical path", virtualTargetPath)
        End If

        Dim virtualNewFolderPath As String = PathHelper.AddEndingSlash(virtualTargetPath, "/"c) & name
        Dim physicalNewFolderPath As String = Me.GetPhysicalFromVirtualPath(virtualNewFolderPath)
        If physicalNewFolderPath Is Nothing Then
            Return String.Format("The virtual path: '{0}'  cannot be converted to a physical path", virtualNewFolderPath)
        End If

        If Directory.Exists(physicalNewFolderPath) Then
            Dim [error] As String = String.Format("The directory: '{0}' already exists", virtualNewFolderPath)


            Return [error]
        End If

        ' There is no restriction with the FileExplorer's permissions ==> Create can be performed
        ' but there can be some FileSystems restrictions  
        Dim errorMessage As String = FileSystem.CreateDirectory(physicalTargetPath, name, virtualTargetPath)
        Return errorMessage
    End Function

    Public Overrides Function CheckWritePermissions(ByVal virtualTargetPath As String) As Boolean
        Dim physicalTargetPath As String = Me.GetPhysicalFromVirtualPath(virtualTargetPath)
        If physicalTargetPath Is Nothing Then
            Return False
        End If

        ' The upload permission is not set ==> no write permission;
        ' Also check whether the write is allowed by the filesystem 
        Return CheckPermissions(physicalTargetPath, PathPermissions.Upload) AndAlso FileSystem.CheckWritePermission(physicalTargetPath, virtualTargetPath)
    End Function

    Public Overrides Function CheckDeletePermissions(ByVal virtualTargetPath As String) As Boolean
        Dim physicalTargetPath As String = Me.GetPhysicalFromVirtualPath(virtualTargetPath)
        If physicalTargetPath Is Nothing Then
            Return False
        End If

        ' The Delete permission is not set ==> no Delete permission;
        ' Also check whether the delete permission is allowed by the filesystem 
        Return CheckPermissions(physicalTargetPath, PathPermissions.Delete) AndAlso FileSystem.CheckWritePermission(physicalTargetPath, virtualTargetPath)
    End Function

    Public Overrides Function CheckReadPermissions(ByVal folderPath As String) As Boolean
        Dim physicalTargetPath As String = Me.GetPhysicalFromVirtualPath(folderPath)
        If physicalTargetPath Is Nothing Then
            Return False
        End If

        Dim canRead = CheckPermissions(physicalTargetPath, PathPermissions.Read)

        Return canRead
    End Function

    Private Function CheckPermissions(ByVal folderPath As String, ByVal permToCheck As PathPermissions) As Boolean
        'add a ending slash to the upload folder
        folderPath = folderPath.TrimEnd(PhysicalPathSeparator) & PhysicalPathSeparator


        Dim pathsToCheck As String()
        If (permToCheck And PathPermissions.Upload) <> 0 Then
            pathsToCheck = UploadPaths
        ElseIf (permToCheck And PathPermissions.Delete) <> 0 Then
            pathsToCheck = DeletePaths
        Else
            pathsToCheck = ViewPaths
        End If


        'Compare the 'folderPath' to all paths in the 'pathsToCheck' collection and check if it is a child or one of them.
        For Each pathToCheck As String In pathsToCheck
            If Not [String].IsNullOrEmpty(pathToCheck) AndAlso folderPath.StartsWith(pathToCheck, StringComparison.OrdinalIgnoreCase) Then
                ' Remove trailing slash from the path
                Dim trimmedPath As String = pathToCheck.TrimEnd(PhysicalPathSeparator)
                'if (trimmedPath.Length == 0)
                '{
                '    //Path contains only the Path separator ==> give permissions everywhere
                '    return true;
                '}
                If folderPath.Length > trimmedPath.Length AndAlso folderPath(trimmedPath.Length) = PhysicalPathSeparator Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Public Overrides Function StoreFile(ByVal file As Telerik.Web.UI.UploadedFile, ByVal path As String, ByVal name As String, ByVal ParamArray arguments As String()) As String
        Dim physicalPath As String = Me.GetPhysicalFromVirtualPath(path)
        If physicalPath Is Nothing Then
            Return String.Empty
        End If

        physicalPath = PathHelper.AddEndingSlash(physicalPath, "\"c) & name
        file.SaveAs(physicalPath)


        ' Returns the path to the newly created file
        Return PathHelper.AddEndingSlash(path, "/"c) & name
    End Function

    ' This function is obsolete ;
    'Public Overrides Function StoreFile(ByVal file As HttpPostedFile, ByVal path As String, ByVal name As String, ByVal ParamArray arguments As String()) As String
    '   Return MyBase.StoreFile(file, path, name, arguments)
    'End Function

    Public Overrides Function StoreBitmap(ByVal bitmap As System.Drawing.Bitmap, ByVal url As String, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Dim virtualPath As String = RemoveProtocolNameAndServerName(url)
        Dim physicalPath As String = Me.GetPhysicalFromVirtualPath(virtualPath)
        If physicalPath Is Nothing Then
            Return String.Empty
        End If

        Dim bitmapWriter As StreamWriter = StreamWriter.Null

        Try
            bitmapWriter = New StreamWriter(physicalPath)
            bitmap.Save(bitmapWriter.BaseStream, format)
        Catch generatedExceptionName As IOException
            Dim errMessage As String = "The image cannot be stored!"
            Return errMessage
        Finally
            bitmapWriter.Close()
        End Try
        Return String.Empty
    End Function

    Public Overrides Function GetFileName(ByVal url As String) As String
        Dim fileName As String = Path.GetFileName(RemoveProtocolNameAndServerName(url))
        Return fileName
    End Function

    Public Overrides Function GetFile(ByVal url As String) As Stream
        Dim virtualPath As String = RemoveProtocolNameAndServerName(url)
        Dim physicalPath As String = Me.GetPhysicalFromVirtualPath(virtualPath)
        If physicalPath Is Nothing Then
            Return Nothing
        End If

        If Not File.Exists(physicalPath) Then
            Return Nothing
        End If

        Return File.OpenRead(physicalPath)
    End Function

    Public Overrides ReadOnly Property CanCreateDirectory() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides Function GetPath(ByVal path As String) As String
        ' First add the '~/' signs in order to use the VirtualPathUtility.GetDirectory() method ;
        Dim PathWithTilde As String = "~/" & path
        Dim virtualPath As String = VirtualPathUtility.GetDirectory(PathWithTilde)
        virtualPath = virtualPath.Remove(0, 2)
        ' remove the '~' signs
        Return virtualPath
    End Function

    Public Overrides ReadOnly Property PathSeparator() As Char
        Get
            Return "/"c
        End Get
    End Property

    Private ReadOnly Property PhysicalPathSeparator() As Char
        Get
            Return "\"c
        End Get
    End Property


    '  The helper methods 
    '''///////////////////////////////////////////////////////////////////////////////////////////////////////
    ''' 
    Private Function GetPermissions(ByVal physicalPath As String) As PathPermissions
        Dim permission As PathPermissions = PathPermissions.Read
        permission = If(CheckPermissions(physicalPath, PathPermissions.Delete), permission Or PathPermissions.Delete, permission)
        permission = If(CheckPermissions(physicalPath, PathPermissions.Upload), permission Or PathPermissions.Upload, permission)

        Return permission
    End Function


    ''' <summary>
    ''' Gets the physical path from a virtual one by using the applied mappings and 
    ''' returns null if no mappings are found
    ''' </summary>
    ''' <param name="virtualPath">A virtual path.</param>
    ''' <returns> The converted physical path or 'null' if no mapping is found </returns>
    Private Function GetPhysicalFromVirtualPath(ByVal virtualPath As String) As String
        ' 'virtualPath' contains value similar to:  "/MyCusomRootDir/"
        virtualPath = PathHelper.RemoveEndingSlash(virtualPath, "/"c)
        Dim resultPhysicalPath As String
        ' Contains the result - physical path
        ' Iterates through all mapped directories
        For Each mappedPath As KeyValuePair(Of String, String) In MappedPaths
            If virtualPath.StartsWith(mappedPath.Key, StringComparison.CurrentCultureIgnoreCase) Then
                ' A mapping is found
                ' Replase the virtual root directory with the physical one
                Dim restOfVirtualPath As String = virtualPath.Substring(mappedPath.Key.Length)
                restOfVirtualPath = restOfVirtualPath.Replace("/"c, "\"c)
                restOfVirtualPath = PathHelper.AddStartingSlash(restOfVirtualPath, "\"c)

                ' 'mappedPath.Value' always ends with '\'
                ' // The 'restOfVirtualPath' is something like Folder_1/SubFolder_2/ ==> convert it to Folder_1\SubFolder_2\
                resultPhysicalPath = mappedPath.Value & restOfVirtualPath

                ' Break the iteration - a physical path is found
                Return resultPhysicalPath
            End If
        Next
        ' No mapping found
        Return Nothing
    End Function

    ''' <summary>
    ''' Returns the files as an array of 'FileItem'
    ''' </summary>
    ''' <param name="virtualPath">Virtual path to the filder</param>
    ''' <returns>An array of 'FileItem'</returns>
    Private Function GetFiles(ByVal virtualPath As String) As FileItem()
        Dim filesItems As New List(Of FileItem)()
        Dim physicalPath As String = Me.GetPhysicalFromVirtualPath(virtualPath)
        If physicalPath Is Nothing Then
            Return Nothing
        End If
        Dim files As New List(Of String)()
        ' The files in this folder : 'physicalPath' ;
        Try
            For Each patern As String In Me.SearchPatterns
                ' Applied flters in the 'SearchPatterns' property;
                For Each filePath As String In Directory.GetFiles(physicalPath, patern)
                    If Not files.Contains(filePath) Then
                        files.Add(filePath)
                    End If
                Next
            Next

            For Each filePath As String In files
                Dim fileInfo As New FileInfo(filePath)
                Dim url As String = ItemHandlerPath & "?path=" & virtualPath & fileInfo.Name
                Dim fileItem As New FileItem(fileInfo.Name, fileInfo.Extension, fileInfo.Length, String.Empty, url, Nothing, _
                 GetPermissions(filePath))
                fileItem.Attributes.Add("DateModified", fileInfo.LastWriteTime.ToString()) 'ADDED BY STB 11/15/2013
                filesItems.Add(fileItem)
            Next
            ' The parent directory is moved or deleted
        Catch generatedExceptionName As IOException
        End Try

        Return filesItems.ToArray()
    End Function

    ''' <summary>
    ''' Gets the folders that are contained in a specific virtual directory
    ''' </summary>
    ''' <param name="virtualPath">The virtual directory that contains the folders</param>
    ''' <returns>Array of 'DirectoryItem'</returns>
    Private Function GetDirectories(ByVal virtualPath As String) As DirectoryItem()
        Dim directoryItems As New List(Of DirectoryItem)()
        Dim physicalPath As String = Me.GetPhysicalFromVirtualPath(virtualPath)
        If physicalPath Is Nothing Then
            Return Nothing
        End If
        Dim directories As String()

        Try
            directories = Directory.GetDirectories(physicalPath)
            ' Can throw an exeption ;
            For Each dirPath As String In directories
                Dim dirInfo As New DirectoryInfo(dirPath)
                Dim newVirtualPath As String = PathHelper.AddEndingSlash(virtualPath, "/"c) + PathHelper.GetDirectoryName(dirPath) + "/"
                Dim dirItem As New DirectoryItem(PathHelper.GetDirectoryName(dirPath), String.Empty, newVirtualPath, PathHelper.AddEndingSlash(virtualPath, "/"c), GetPermissions(dirPath), New FileItem() {}, _
                 Nothing)
                directoryItems.Add(dirItem)
            Next
            ' The parent directory is moved or deleted
        Catch generatedExceptionName As IOException
        End Try

        Return directoryItems.ToArray()
    End Function
End Class

