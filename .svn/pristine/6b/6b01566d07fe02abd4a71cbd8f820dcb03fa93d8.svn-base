Public Class ImportNote

	Dim _ImportNoteType As ImportNoteType
	Dim _NoteDetail As Dictionary(Of String, Object)

	Public Sub New(ByVal pImportNoteType As ImportNoteType, ByVal pNoteDetail As Dictionary(Of String, Object))
		_ImportNoteType = pImportNoteType
		_NoteDetail = pNoteDetail
	End Sub

	Public ReadOnly Property Message As String
		Get
			Dim zDetailString As String = CreateDetailString(_NoteDetail)
			Return CreateNoteString() & IIf(zDetailString <> "", Chr(13) & zDetailString, "")
		End Get
	End Property

	Private Function CreateNoteString() As String

		Dim zPrefix As String = "Import Note: "
		Dim zSuffix As String = ""

		Select Case _ImportNoteType

			Case ImportNoteType.ConfirmCompRecsFoundInDatabase
                zSuffix = "Not imported due to " & Chr(34) & "Confirm Comp" & Chr(34) & " status in database."

            Case ImportNoteType.ExcelColumnNotFoundInMap
                zSuffix = "Informational Only - Excel column not found in map collection."

            Case ImportNoteType.MapColumnNotFoundInExcel
                zSuffix = "Informational Only - Code map column not found in Excel."

            Case ImportNoteType.MapColumnNotFoundOnProperty
                zSuffix = "Information Only - Could not find mapping on entity as property."

            Case ImportNoteType.SurveyDateNotMatchDateInRerportArchive
                zSuffix = "Informational Only - Survey date doesn't match date in report archive table."

            Case ImportNoteType.NoRecommendationsToImport
                zSuffix = "Informational Only - There were no recommendations found in spreadsheet to import."

            Case ImportNoteType.AdvisoryStatusChanged
				zSuffix = "Informational Only - Advisory Status has been changed."

			Case ImportNoteType.WorksheetDoesntExist
				zSuffix = "Informational Only - Worksheet doesnt exist. No import done."

		End Select

		Return zPrefix & zSuffix


	End Function


	Public Shared Function CreateDetailString(ByVal pErrorDetail As Dictionary(Of String, Object)) As String

		Dim zString As New Text.StringBuilder
		Dim zComma As String = ""
		If pErrorDetail IsNot Nothing Then
			For Each zPair As KeyValuePair(Of String, Object) In pErrorDetail

				If zPair.Value Is Nothing Then
					zString.AppendLine(Replace(Space(10) & zPair.ToString, ",", ": Nothing"))
				Else
					zString.AppendLine(Replace(Space(10) & zPair.ToString, ",", ":"))
				End If

			Next
			Return zString.ToString
		End If

		Return ""

	End Function


	Public Enum ImportNoteType

		ConfirmCompRecsFoundInDatabase
        ExcelColumnNotFoundInMap
        MapColumnNotFoundInExcel
        MapColumnNotFoundOnProperty
        SurveyDateNotMatchDateInRerportArchive
        NoRecommendationsToImport
		AdvisoryStatusChanged
		WorksheetDoesntExist
	End Enum

End Class
