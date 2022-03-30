Imports System.Data
Imports System.Data.SqlClient
Imports AppJobLib
Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Libraries.CoreLib.CustomExtensions.DataRowExtensions
Imports GRC.Connect.Libraries.CoreLib.CustomExtensions.StringExtensions


Public Class UtilTopo
    Implements AppJobLib.IAppJob

    Public Property Job As razor.rowTblJob Implements IAppJob.Job

    Public Sub ProcessTopoImports()

        ''get unprocessed reports
        Dim cmd As New SqlCommand("SELECT * FROM SurveyImport WHERE IsReportGenerated IS NULL ORDER BY Id desc", UtilSQLServer.GetConnectionObject)
        Dim dt As New DataTable
        Using cmd.Connection
            Using cmd
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using

        For Each r As DataRow In dt.Rows

            ProcessTopoImportRow(r)

        Next

    End Sub

    Public Sub ProcessTopoImport(importId As Integer)

        ''get unprocessed reports
        Dim cmd As New SqlCommand("SELECT * FROM SurveyImport WHERE Id=@id", UtilSQLServer.GetConnectionObject)
        cmd.Parameters.AddWithValue("@id", importId)
        Dim dt As New DataTable
        Using cmd.Connection
            Using cmd
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using

        For Each r As DataRow In dt.Rows
            ProcessTopoImportRow(r)
        Next

    End Sub

    Private Sub ProcessTopoImportRow(row As DataRow)

        Dim ReportPath As String = "", ReportName As String = "", ErrorNumber As Integer = 0, ErrorMessage As String = "", AppendRecsInReport As Boolean

        Dim cmd1 As New SqlCommand("spSurveyProcessing", UtilSQLServer.GetConnectionObject)

        cmd1.CommandType = CommandType.StoredProcedure

        cmd1.Parameters.Add(New SqlParameter("@SurveyID", SqlDbType.Int))
        cmd1.Parameters("@SurveyID").Value = row("Id")

        cmd1.Parameters.Add(New SqlParameter("@ReportPath", SqlDbType.VarChar, 1000))
        cmd1.Parameters("@ReportPath").Direction = ParameterDirection.Output

        cmd1.Parameters.Add(New SqlParameter("@ReportName", SqlDbType.VarChar, 1000))
        cmd1.Parameters("@ReportName").Direction = ParameterDirection.Output

        cmd1.Parameters.Add(New SqlParameter("@ErrorNumber", SqlDbType.Int))
        cmd1.Parameters("@ErrorNumber").Direction = ParameterDirection.Output

        cmd1.Parameters.Add(New SqlParameter("@ErrorMessage", SqlDbType.VarChar, 4000))
        cmd1.Parameters("@ErrorMessage").Direction = ParameterDirection.Output

        cmd1.Parameters.Add(New SqlParameter("@AppendRecsInReport", SqlDbType.Bit))
        cmd1.Parameters("@AppendRecsInReport").Direction = ParameterDirection.Output

        Using cmd1.Connection
            Using cmd1
                cmd1.ExecuteNonQuery()
                ReportPath = Convert.ToString(cmd1.Parameters("@ReportPath").Value)
                AppendRecsInReport = Convert.ToBoolean(cmd1.Parameters("@AppendRecsInReport").Value)

                If Not IsDBNull(cmd1.Parameters("@ReportName").Value) Then
                    ReportName = cmd1.Parameters("@ReportName").Value
                    ErrorNumber = cmd1.Parameters("@ErrorNumber").Value
                    ErrorMessage = cmd1.Parameters("@ErrorMessage").Value
                Else
                    ReportName = ""
                End If
            End Using
        End Using

        If ErrorNumber = 0 Then
            If Not String.IsNullOrEmpty(ReportName) Then
                Try
                    Dim rptByte As Byte() = GetReport(Convert.ToInt32(row("Id")), AppendRecsInReport)

                    If StoreReport(ReportPath, ReportName, rptByte) Then
                        UpdateImportSurvey(Convert.ToInt32(row("Id")), True, "", IO.Path.Combine(ReportPath, ReportName))
                    End If

                Catch ex As Exception
                    UpdateImportSurvey(Convert.ToInt32(row("Id")), False, ex.Message, "")
                End Try
            Else
                UpdateImportSurvey(Convert.ToInt32(row("Id")), False, "Report Name Is Empty", "")
            End If
        Else
            UpdateImportSurvey(Convert.ToInt32(row("Id")), False, ErrorMessage, "")
        End If


    End Sub

    Public Function GetReport(ID As Integer, AppendRecsInReport As Boolean) As Byte()

        Dim exp As SurveyExport = GetSurveyExport(ID)

        Dim topoPdf As Byte() = DownloadTopoPdf(exp.ExportUrl)

        Dim doc As New WebSupergoo.ABCpdf10.Doc()

        doc.Read(topoPdf)

        If AppendRecsInReport Then

            Dim recPdf As Byte() = ReportLib.UtilReport.GetTopoRecommendationReport(exp.FileNo)

            Dim recDoc As New WebSupergoo.ABCpdf10.Doc()

            recDoc.Read(recPdf)

            doc.Append(recDoc)

        End If

        Using stream = doc.GetStream()

            Dim ms As New IO.MemoryStream()

            stream.CopyTo(ms)

            Return ms.ToArray()

        End Using


    End Function

    Public Function StoreReport(path As String, fileName As String, buffer As Byte()) As Boolean
        If IO.Directory.Exists(path) Then
            IO.File.WriteAllBytes(IO.Path.Combine(path, fileName), buffer)
            Return True
        Else
            IO.Directory.CreateDirectory(path)
            Return StoreReport(path, fileName, buffer)
        End If
    End Function

#Region "Survey Files and Downloading"

    Public Sub ProcessSurveyTopoFiles()

        Dim cmd As New SqlCommand("SELECT * FROM vwSurveyFile WHERE (SavedDate IS NULL or SavedLocationFlag=2) and ExceptionCount < 10", UtilSQLServer.GetConnectionObject)
        Dim dt As New DataTable
        Using cmd.Connection
            Using cmd
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using

        ProcessData(dt)

    End Sub

    Public Sub ProcessSurveyTopoFile(surveyFileId As Integer)

        Dim cmd As New SqlCommand("SELECT * FROM vwSurveyFile WHERE SurveyFileId=@id", UtilSQLServer.GetConnectionObject)

        cmd.Parameters.AddWithValue("@id", surveyFileId)

        Dim dt As New DataTable

        Using cmd.Connection

            Using cmd

                dt.Load(cmd.ExecuteReader)

            End Using

        End Using

        ProcessData(dt)

    End Sub

    Private Sub ProcessData(dt As DataTable)

        Dim rowsList As New List(Of DataRow)

        For Each r As DataRow In dt.Rows

            Try

                ProcessRow(r)

            Catch ex As SurveyProcessingRowException

                r("ExceptionMessage") = ex.Message

                rowsList.Add(r)

            Catch ex As Exception

                CoreLib.UtilEmail.SendException(ex, "ProcessSurveyTopoFile")

            End Try

        Next

        'if there were row exceptions... send email.
        If rowsList.Count > 0 Then

            Dim ex As New Exception("Error processing survey files.")

            ex.Data.Add("Rows", Newtonsoft.Json.JsonConvert.SerializeObject(rowsList, Newtonsoft.Json.Formatting.Indented).JsonToHtml)

            Throw ex

        End If

    End Sub

    Private Sub ProcessRow(row As DataRow)

        Dim s As String = Newtonsoft.Json.JsonConvert.SerializeObject(row)

        Dim surveyFileId As Integer = row("SurveyFileId")

        Dim sourcrUrl As String = row.Field(Of String)("SourceUrl")

        Dim destPath As String = row.Field(Of String)("DestFilePath")

        Dim fileName As String = row("AdjustedFileName")

        Dim exceptionCount As String = row("ExceptionCount")

        Dim locationFlag As Integer = row.Field(Of Integer)("SavedLocationFlag")

        If locationFlag = 0 Then

            Dim b(Nothing) As Byte

            Try
                Dim client As New System.Net.WebClient()

                b = client.DownloadData(sourcrUrl)

                If b.Length > 0 Then

                    If Not IO.Directory.Exists(IO.Path.GetDirectoryName(destPath)) Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(destPath))

                    IO.File.WriteAllBytes(destPath, b)

                    UpdateSurveyFileStatus(surveyFileId, LocationFlags.DocumentLibrary, "Saved", 0)

                End If

            Catch ex As System.IO.IOException

                If b.Length > 0 Then

                    Dim localPath As String = IO.Path.Combine(GetLocalTopoSurveyFilesPath, fileName)

                    If Not IO.Directory.Exists(GetLocalTopoSurveyFilesPath) Then IO.Directory.CreateDirectory(GetLocalTopoSurveyFilesPath)

                    IO.File.WriteAllBytes(localPath, b)

                    UpdateSurveyFileStatus(surveyFileId, LocationFlags.ProgramData, ex.GetBaseException.Message & " Temporarilly saved file to: " & IO.Path.Combine(GetLocalTopoSurveyFilesPath, fileName), 0)

                Else

                    UpdateSurveyFileStatus(surveyFileId, LocationFlags.None, ex.GetBaseException.Message, (exceptionCount + 1))

                    Throw New SurveyProcessingRowException(ex.GetBaseException.Message, ex)

                End If

            Catch ex As System.Net.WebException

                Dim resp As System.Net.HttpWebResponse = ex.Response

                Dim msg As String = ex.Message + " " + resp.StatusDescription

                UpdateSurveyFileStatus(surveyFileId, LocationFlags.None, msg, (exceptionCount + 1))

                Throw New SurveyProcessingRowException(msg, ex)

            Catch ex As Exception

                UpdateSurveyFileStatus(surveyFileId, LocationFlags.None, ex.GetBaseException.Message, (exceptionCount + 1))

                Throw

            End Try

        ElseIf locationFlag = 2 Then

            Dim f As String = IO.Path.Combine(GetLocalTopoSurveyFilesPath, fileName)

            Try
                If IO.File.Exists(f) Then

                    If Not IO.Directory.Exists(IO.Path.GetDirectoryName(destPath)) Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(destPath))

                    IO.File.Move(f, destPath)

                    If IO.File.Exists(destPath) Then

                        UpdateSurveyFileStatus(surveyFileId, LocationFlags.DocumentLibrary, "Saved", 0)

                    End If

                End If

            Catch ex As Exception

                UpdateSurveyFileStatus(surveyFileId, locationFlag, ex.GetBaseException.Message, (exceptionCount + 1))

                Throw New SurveyProcessingRowException(ex.GetBaseException.Message, ex)

            End Try

        End If

    End Sub

    Private Function GetProgramDataFolder() As String
        Dim commonFolderPath As String = IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Topo Survey Processing")
        Return commonFolderPath
    End Function

    Private Function GetLocalTopoSurveyFilesPath() As String
        Return IO.Path.Combine(GetProgramDataFolder, "GRC", "Topo Processing", "Survey Files")
    End Function

    Private Sub UpdateSurveyFileStatus(id As Integer, flag As LocationFlags, message As String, exceptionCount As Integer)

        Dim cmd As New SqlCommand("UPDATE SurveyFile SET SavedDate=@date, SavedLocationFlag=@locationFlag, SavedStatus=@status, ExceptionCount=@exCount WHERE id=@id", UtilSQLServer.GetConnectionObject)

        cmd.Parameters.AddWithValue("@id", id)

        cmd.Parameters.AddWithValue("@status", message)

        cmd.Parameters.AddWithValue("@exCount", exceptionCount)

        If flag = LocationFlags.DocumentLibrary Then

            cmd.Parameters.AddWithValue("@locationFlag", 1)

            cmd.Parameters.AddWithValue("@date", Now)

        ElseIf flag = LocationFlags.ProgramData Then

            cmd.Parameters.AddWithValue("@locationFlag", 2)

            cmd.Parameters.AddWithValue("@date", Now)

        Else

            cmd.Parameters.AddWithValue("@locationFlag", 0)

            cmd.Parameters.AddWithValue("@date", DBNull.Value)

        End If

        Using cmd.Connection

            Using cmd

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Private Enum LocationFlags
        None = 0
        DocumentLibrary = 1
        ProgramData = 2
    End Enum

    Private Class SurveyProcessingRowException
        Inherits Exception

        Public Sub New(message As String, ex As Exception)
            MyBase.New(message, ex)
        End Sub

    End Class

#End Region

    Private Shared Function GetSurveyExport(ID As Integer) As SurveyExport

        Dim dt As New DataTable
        Dim con As New SqlClient.SqlConnection(UtilDB.ConnectionString)
        Dim cmd As New SqlClient.SqlCommand("spGetSurveyExport", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", ID)
        con.Open()
        Using con
            Using cmd
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        Dim Export As New SurveyExport
        For Each zRow As DataRow In dt.Rows
            Export.ExportUrl = zRow("Url")
            Export.SurveyImportId = zRow("SurveyImportId")
            Export.FileNo = zRow("FileNo")
            Export.FileName = zRow("Name")
        Next

        Return Export

    End Function

    Private Shared Function DownloadTopoPdf(url As String) As Byte()
        Dim client As New System.Net.WebClient()
        Dim b As Byte() = client.DownloadData(url)
        Return b

    End Function


    Private Sub UpdateImportSurvey(id As Integer, isReportGenerated As Boolean?, exceptionMessage As String, reportPath As String)
        Dim cmd As New SqlClient.SqlCommand("UPDATE SurveyImport SET IsReportGenerated=@IsGen, ExceptionMessage=@ex, ReportPath=@RptPath WHERE Id=@Id", UtilSQLServer.GetConnectionObject)
        cmd.Parameters.AddWithValue("@Id", id)

        If IsNothing(isReportGenerated) Then
            cmd.Parameters.AddWithValue("@IsGen", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@IsGen", isReportGenerated)
        End If
        cmd.Parameters.AddWithValue("@ex", exceptionMessage)
        cmd.Parameters.AddWithValue("@RptPath", reportPath)

        Using cmd.Connection
            Using cmd
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub



    Private Class SurveyExport

        Public Property FileNo As String

        Public Property SurveyImportId As Integer

        Public Property ExportUrl As String

        Public Property FileName As String

    End Class


End Class
