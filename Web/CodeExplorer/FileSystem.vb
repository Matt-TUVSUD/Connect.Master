Imports System.IO
Imports System.Security.Permissions
Imports System.Security

''' <summary>
''' A helper class for working with physical and mapped shared directories
''' </summary>
Public Class FileSystem
    Public Sub New()
    End Sub

    Public Shared Function MoveDirectorty(ByVal physicalSourcePath As String, ByVal physicalDestPath As String, ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        Try
            If (PathHelper.IsSharedPath(physicalSourcePath) AndAlso PathHelper.IsSharedPath(physicalDestPath)) OrElse (PathHelper.IsPhysicalPath(physicalSourcePath) AndAlso PathHelper.IsPhysicalPath(physicalDestPath)) Then
                Directory.Move(physicalSourcePath, physicalDestPath)
            Else
                ' When the 'physicalSourcePath' is a shared path and the Directory.Move does not work, and thrown and 
                ' exception like: "Source and destination path must have identical roots. Move will not work across volumes."

                ' The solution:
                ' 1. First copy the directory
                ' 2. remove the directory from the old location

                Dim destinationDirectoryForCopy As String = Path.GetDirectoryName(physicalDestPath)
                Dim destVirtualDirForCopy As String = System.Web.VirtualPathUtility.GetDirectory(PathHelper.AddStartingSlash(virtualDestPath, "/"c))
                destVirtualDirForCopy = PathHelper.RemoveStartingSlash(destVirtualDirForCopy, "/"c)
                destVirtualDirForCopy = PathHelper.RemoveEndingSlash(destVirtualDirForCopy, "/"c)
                FileSystem.CopyDirectory(physicalSourcePath.ToString(), destinationDirectoryForCopy, virtualSourcePath.ToString(), destVirtualDirForCopy)
                FileSystem.DeleteDirectory(physicalSourcePath, virtualSourcePath)
            End If
        Catch ex As DirectoryNotFoundException
            Dim message As String = String.Format("One of the directories: '{0}' or '{1}' does not exist!", virtualSourcePath, virtualDestPath)
            Return message
        Catch ex As UnauthorizedAccessException
            Dim message As String = "You do not have enough permissions for this operation!"
            Return message
        Catch ex As Exception
            Dim message As String = "The operation cannot be compleated"
            Return message
        End Try

        Return String.Empty
    End Function

    Public Shared Function MoveFile(ByVal physicalSourcePath As String, ByVal physicalDestPath As String, ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        Try
            File.Move(physicalSourcePath, physicalDestPath)

        Catch generatedExceptionName As FileNotFoundException
            Dim message As String = String.Format("File: '{0}' does not exist!", virtualSourcePath)
            Return message
        Catch generatedExceptionName As UnauthorizedAccessException
            Dim message As String = "FileSystem's restriction: You do not have enough permissions for this operation!"
            Return message
        Catch generatedExceptionName As IOException
            Dim message As String = "The operation cannot be compleated"
            Return message
        End Try

        Return String.Empty
    End Function

    Public Shared Function DeleteDirectory(ByVal physicalTargetPath As String, ByVal virtualTargetPath As String) As String
        Try
            Directory.Delete(physicalTargetPath, True)
        Catch generatedExceptionName As DirectoryNotFoundException
            Dim message As String = String.Format("FileSystem restriction: Directory '{0}' is not found!", virtualTargetPath)
            Return message
        Catch generatedExceptionName As UnauthorizedAccessException
            Dim message As String = "FileSystem's restriction: You do not have enough permissions for this operation!"
            Return message
        Catch generatedExceptionName As IOException
            Dim message As String = String.Format("FileSystem restriction: The directory '{0}' cannot be deleted!", virtualTargetPath)
            Return message
        End Try

        Return String.Empty
    End Function

    Public Shared Function DeleteFile(ByVal physicalTargetPath As String, ByVal virtualTargetPath As String) As String
        Try
            File.Delete(physicalTargetPath)

        Catch generatedExceptionName As FileNotFoundException
            Dim message As String = String.Format("File: '{0}' does not exist!", virtualTargetPath)
            Return message
        Catch generatedExceptionName As UnauthorizedAccessException
            Dim message As String = "FileSystem restriction: You do not have enough permissions for this operation!"
            Return message
        Catch generatedExceptionName As IOException
            Dim message As String = "The operation cannot be compleated"
            Return message
        End Try

        Return String.Empty
    End Function

    Public Shared Function CopyFile(ByVal physicalSourcePath As String, ByVal physicalDestPath As String, ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        Try
            File.Copy(physicalSourcePath, physicalDestPath, True)

        Catch generatedExceptionName As FileNotFoundException
            Dim message As String = String.Format("File: '{0}' does not exist!", virtualSourcePath)
            Return message
        Catch generatedExceptionName As UnauthorizedAccessException
            Dim message As String = "FileSystem's restriction: You do not have enough permissions for this operation!"
            Return message
        Catch generatedExceptionName As IOException
            Dim message As String = "The operation cannot be compleated"
            Return message
        End Try

        Return String.Empty
    End Function

    Public Shared Function CopyDirectory(ByVal physycalSourcePath As String, ByVal physicalDestPath As String, ByVal virtualSourcePath As String, ByVal virtualDestPath As String) As String
        ' Copy all files ;
        Dim newDirPhysicalFullPath As String
        ' Contains the physical path to the new directory ;
        Dim dirInfoSource As DirectoryInfo
        Try
            dirInfoSource = New DirectoryInfo(physycalSourcePath)
            newDirPhysicalFullPath = String.Format("{0}{1}{2}", PathHelper.AddEndingSlash(physicalDestPath, "\"c), dirInfoSource.Name, "\")

            ' Else ;
            Directory.CreateDirectory(newDirPhysicalFullPath, dirInfoSource.GetAccessControl())
        Catch ex As UnauthorizedAccessException
            Dim message As String = "FileSystem's restriction: You do not have enough permissions for this operation!"
            Return message
        End Try

        ' Directory is created ;

        For Each currentFilePath As String In Directory.GetFiles(physycalSourcePath)
            Dim fileInfo As New FileInfo(currentFilePath)

            Dim newFilePath As String = newDirPhysicalFullPath & fileInfo.Name

            Try
                File.Copy(currentFilePath, newFilePath)

            Catch ex As FileNotFoundException
                Dim message As String = String.Format("File: '{0}' does not exist!", virtualSourcePath)
                Return message
            Catch ex As UnauthorizedAccessException
                Dim message As String = "You do not have enough permissions for this operation!"
                Return message
            Catch ex As IOException
                Dim message As String = "The operation cannot be compleated"
                Return message
            End Try
        Next

        ' Copy all subdirectories ;
        For Each physicalCurrentSourcePath As String In Directory.GetDirectories(physycalSourcePath)
            Dim dirInfo As New DirectoryInfo(physicalCurrentSourcePath)
            Dim physicalCurrentDestPath As String = newDirPhysicalFullPath
            ' Change the name of the variable ;
            Dim virtualCurrentSourcePath As String = String.Format("{0}{1}{2}", PathHelper.AddEndingSlash(virtualSourcePath, "/"c), dirInfo.Name, "/")
            Dim virtualCurrentDestPath As String = String.Format("{0}{1}{2}", PathHelper.AddEndingSlash(virtualDestPath, "/"c), dirInfoSource.Name, "/")

            ' Call recursively the Directory copy function ;
            Dim returnedError As String = CopyDirectory(physicalCurrentSourcePath, physicalCurrentDestPath, virtualCurrentSourcePath, virtualCurrentDestPath)
            If returnedError <> String.Empty Then
                ' An error occured ;
                Return returnedError
            End If
        Next

        ' No errors. 
        Return String.Empty
    End Function

    Public Shared Function CreateDirectory(ByVal physicalTargetPath As String, ByVal directoryName As String, ByVal virtualTargetPath As String) As String
        Try
            Dim parentDir As New DirectoryInfo(physicalTargetPath)

            Directory.CreateDirectory(PathHelper.AddEndingSlash(physicalTargetPath, "\"c) & directoryName, parentDir.GetAccessControl())
        Catch generatedExceptionName As DirectoryNotFoundException
            Dim message As String = String.Format("FileSystem restriction: Directory with name '{0}' is not found!", virtualTargetPath)
            Return message
        Catch generatedExceptionName As UnauthorizedAccessException
            Dim message As String = "FileSystem's restriction: You do not have enough permissions for this operation!"
            Return message
        Catch generatedExceptionName As IOException
            Dim message As String = String.Format("FileSystem restriction: The directory '{0}' cannot be created!", virtualTargetPath)
            Return message
        End Try

        Return String.Empty
    End Function

    Public Shared Function GetFileContent(ByVal physicalTargetPath As String, ByVal virtualTargetPath As String) As Byte()
        Dim fileStream As New FileStream(physicalTargetPath, FileMode.Open, FileAccess.Read)
        Dim content As Byte() = New Byte(fileStream.Length - 1) {}
        fileStream.Read(content, 0, CInt(fileStream.Length))
        fileStream.Close()

        Return content
    End Function

    Public Shared Function CheckWritePermission(ByVal physicalTargetPath As String, ByVal virtualTargetPath As String) As Boolean
        Dim f As New FileIOPermission(FileIOPermissionAccess.Write, physicalTargetPath)
        Try
            f.Demand()
            Return True
        Catch generatedExceptionName As SecurityException
            Return False
        End Try
    End Function
End Class
