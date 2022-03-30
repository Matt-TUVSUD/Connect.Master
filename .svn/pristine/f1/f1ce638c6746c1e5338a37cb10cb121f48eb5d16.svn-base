Public Class UtilPM

    Private Shared _IsInitialized As Boolean = False

    Private Shared Sub Initialize()

        If Not _IsInitialized Then
            GRC.EDA.PM.Connect.CoreLib.UtilCore.Initialize(Reflection.Assembly.GetExecutingAssembly)
            _IsInitialized = True
        End If

    End Sub

    Public Shared Function GetProjectFolder(pSid As String, pProjectGUID As String) As String
        Initialize()
        Dim zUtil As New GRC.EDA.PM.Connect.CoreLib.UtilCore(pSid)
        Return zUtil.GetDocLibFolder(pProjectGUID)
    End Function

    Public Shared Function RunReport(pFileNo As String) As Byte()
        Initialize()
        Dim zSearchParms As New GRC.EDA.PM.CoreLib.JSON.ProjectSearchParameters
        zSearchParms.FileNo = pFileNo
        Dim zDP As GRC.EDA.PM.CoreLib.JSON.DataPull = GRC.EDA.PM.UtilClient.SearchProjects(zSearchParms)
        Dim bytes(0) As Byte

        If zDP.Projects.Count > 0 Then
            bytes = GRC.Connect.Libraries.ReportLib.UtilReport.GeneratePMReport(zDP)
        Else
            bytes = GRC.Connect.Libraries.ReportLib.UtilReport.GenerateEmptyPMReport()
        End If

        Return bytes

    End Function


End Class
