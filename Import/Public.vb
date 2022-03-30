Public Class [Public]

	Private Shared _FileString As New String("")

    'Public Shared Function GenerateMapCode(ByVal pExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook, pImportType As ImportEnum.ImportType) As String
    '    Dim zMeta As Meta = Nothing


    '    Select Case pImportType
    '        Case ImportEnum.ImportType.FDS
    '            zMeta = New FireMeta
    '        Case ImportEnum.ImportType.BDS
    '            zMeta = New BmMeta
    '        Case ImportEnum.ImportType.PSDS
    '            zMeta = New PSMeta
    '    End Select

    '    Return zMeta.GenerateMapCode(pExcelWorkBook)

    'End Function

    Public Shared Function GetImportTableDictionary() As Dictionary(Of String, Object)
        Dim zTableValues As System.Array = [Enum].GetValues(GetType(ImportEnum.ImportTable))
        Dim zTableDictionary As New Dictionary(Of String, Object)

        For Each zTableValue In zTableValues
            zTableDictionary.Add([Enum].GetName(GetType(ImportEnum.ImportTable), zTableValue), zTableValue)
        Next

        Return zTableDictionary

    End Function

    Public Shared Function GetImportSheetDictionary() As Dictionary(Of String, Object)
        Dim zTableValues As System.Array = [Enum].GetValues(GetType(ImportEnum.ImportSheet))
        Dim zTableDictionary As New Dictionary(Of String, Object)

        For Each zTableValue In zTableValues
            zTableDictionary.Add([Enum].GetName(GetType(ImportEnum.ImportSheet), zTableValue), zTableValue)
        Next


        Return zTableDictionary

    End Function

    Public Shared Function GetImportTableColumns(ByVal pImportTable As ImportEnum.ImportTable) As Dictionary(Of String, String)

        Dim zColumnDict As New Dictionary(Of String, String)
        Dim zEsType As System.Type = Meta.GetImportTableEntityType(pImportTable)
        Dim zColsMeta As EntitySpaces.Interfaces.esColumnMetadataCollection = EsHelper.GetEsColumnMetadataCollection(zEsType)

        For Each zColMeta As EntitySpaces.Interfaces.esColumnMetadata In zColsMeta
            zColumnDict.Add(zColMeta.Name & " (" & zColMeta.Type.FullName & ")", zColMeta.Name)
        Next

        Return zColumnDict

    End Function

	Public Shared Function ImportTemplate(ByVal pGuid As String, ByVal pFiles As List(Of String), ByVal pImportSheet As List(Of ImportEnum.ImportSheet)) As ImportFileResultList
		_FileString = ""
		pFiles.ForEach(AddressOf CreateString)

		If pImportSheet.Contains(ImportEnum.ImportSheet.FacilityData) And (pImportSheet.Contains(ImportEnum.ImportSheet.CopeData) Or pImportSheet.Contains(ImportEnum.ImportSheet.NatHazData) Or pImportSheet.Contains(ImportEnum.ImportSheet.NatHazModelingData) Or pImportSheet.Contains(ImportEnum.ImportSheet.RetailData)) Then
			Throw New ImportException("Can't determine template type since file has FDS and BDS type tabs. Select either a FDS or BDS template to import.")
		ElseIf pGuid = "" Then
			Throw New ImportException("GUID not provided.")
		ElseIf pFiles.Count = 0 Then
			Throw New ImportException("No file was selected to import.")
		ElseIf pImportSheet.Count = 0 Then
			Throw New ImportException("No sheet was specified to import.")
        ElseIf (_FileString.ToLower.Contains("bds") And _FileString.ToLower.Contains("fds") And _FileString.ToLower.Contains("psds")) Then
            Throw New ImportException("You can not import mixed tempate types. Select either a FDS, PSDS or BDS template to import.")
		ElseIf (pImportSheet.Contains(ImportEnum.ImportSheet.CopeData) Or pImportSheet.Contains(ImportEnum.ImportSheet.NatHazData) Or pImportSheet.Contains(ImportEnum.ImportSheet.NatHazModelingData) Or pImportSheet.Contains(ImportEnum.ImportSheet.RetailData)) And (_FileString.ToLower.Contains("bds")) Then
			Throw New ImportException("One or more import sheets selected is not a BDS import sheet")
		ElseIf pImportSheet.Contains(ImportEnum.ImportSheet.FacilityData) And (_FileString.ToLower.Contains("fds")) Then
			Throw New ImportException("Facility Data is not a FDS import sheet")
        ElseIf (Not _FileString.ToLower.Contains("bds")) And (Not _FileString.ToLower.Contains("fds")) And (Not _FileString.ToLower.Contains("psds")) Then
            Throw New ImportException("Can't determine template type since file does not specify FDS, PSDS or BDS in its name.")
		Else
			Dim zImportUtil As New ImportUtility
			If _FileString.ToLower.Contains("bds") Then Return zImportUtil.Import(pGuid, pFiles, pImportSheet, ImportEnum.ImportType.BDS)
            If _FileString.ToLower.Contains("fds") Then Return zImportUtil.Import(pGuid, pFiles, pImportSheet, ImportEnum.ImportType.FDS)
            If _FileString.ToLower.Contains("psds") Then Return zImportUtil.Import(pGuid, pFiles, pImportSheet, ImportEnum.ImportType.PSDS)
			Return Nothing
		End If

	End Function

	Private Shared Sub CreateString(ByVal pValue As String)
		_FileString = _FileString & pValue
	End Sub

End Class
