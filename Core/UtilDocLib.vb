Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilDocLib

    Shared Function GetEngineeringReportPath(pReportGuid As String) As String

        Dim zQ As New queryVwLibrariesDocumentLibrarySelect
        zQ.SelectAll()
        zQ.Top = 1
        zQ.Where.Add(zQ.colReportGuid.Equals(pReportGuid))

        Dim zList As List(Of rowVwLibrariesDocumentLibrarySelect) = VwLibrariesDocumentLibrarySelect.LoadData(zQ.QueryText)

        If zList.Count > 0 Then Return zList(0).colPDFErFilePath Else Return ""

    End Function

    Shared Function GetLatestDocLibRecord(pFileNo As String, pPractice As TblMetaPractice.Practices) As rowVwLibrariesDocumentLibrarySelect

        Dim zQ As New queryVwLibrariesDocumentLibrarySelect
        zQ.SelectAll()
        zQ.Top = 1
        zQ.Where.Add(zQ.colFileno.Equals(pFileNo))
        zQ.Where.Add(zQ.colMetaPracticeID.Equals(pPractice))
        zQ.OrderBy(zQ.colDocumentdate.Descending)

        Dim zList As List(Of rowVwLibrariesDocumentLibrarySelect) = VwLibrariesDocumentLibrarySelect.LoadData(zQ.QueryText)

        If zList.Count > 0 Then Return zList(0) Else Return Nothing

    End Function

 
    Shared Function GetReportGuid(pFileNo As String, pPractice As TblMetaPractice.Practices) As String
        Dim zReport As rowVwLibrariesDocumentLibrarySelect = GetLatestDocLibRecord(pFileNo, pPractice)
        If IsNothing(zReport) Then
            Return ""
        Else
            Return zReport.colReportGuid
        End If
    End Function

    Shared Function IsEngineeringReportAvailable(pFileNo As String, pPractice As TblMetaPractice.Practices) As Boolean
        Dim zReport As rowVwLibrariesDocumentLibrarySelect = GetLatestDocLibRecord(pFileNo, pPractice)
        Return Not IsNothing(zReport)
    End Function

    Shared Function IsDiagramReportAvailable(pFileNo As String) As Boolean

        Dim zReport As rowVwLibrariesDocumentLibrarySelect = FindLatestDiagramRecord(pFileNo)
        If Not IsNothing(zReport) Then
            Return IO.File.Exists(zReport.colPDFDiagramFilePath)
        Else
            Return False
        End If

    End Function

    Shared Function FindLatestDiagramRecord(pFileNo As String) As rowVwLibrariesDocumentLibrarySelect

        Dim zQ As New queryVwLibrariesDocumentLibrarySelect
        zQ.SelectAll()
        zQ.Top = 1
        zQ.Where.Add(zQ.colFileno.Equals(pFileNo))
        zQ.Where.Add(zQ.colLinktodiagram.NotEqual(""))
        zQ.OrderBy(zQ.colDocumentdate.Descending)

        Dim zList As List(Of rowVwLibrariesDocumentLibrarySelect) = VwLibrariesDocumentLibrarySelect.LoadData(zQ.QueryText)
        If zList.Count > 0 Then Return zList(0) Else Return Nothing

    End Function

    Shared Function GetDiagramReportPath(pReportGuid As String) As String

        Dim zQ As New queryVwLibrariesDocumentLibrarySelect
        zQ.SelectAll()
        zQ.Top = 1
        zQ.Where.Add(zQ.colReportGuid.Equals(pReportGuid))

        Dim zList As List(Of rowVwLibrariesDocumentLibrarySelect) = VwLibrariesDocumentLibrarySelect.LoadData(zQ.QueryText)

        If zList.Count > 0 Then Return zList(0).colPDFDiagramFilePath Else Return ""

    End Function

End Class
