Public Class ValidationError
    Inherits [Error]

    Dim _ValidationError As ValidationErrorType
    Dim _ErrorDetail As Dictionary(Of String, Object)

    Public Sub New(ByVal pValidationError As ValidationErrorType, ByVal pErrorDetail As Dictionary(Of String, Object))
        _ValidationError = pValidationError
        _ErrorDetail = pErrorDetail
    End Sub

    Public Overrides ReadOnly Property Message As String
        Get
            Dim zDetailString As String = CreateDetailString(_ErrorDetail)
            Return Space(5) & CreateErrorString() & "\n\r" & IIf(zDetailString <> "", Chr(13) & zDetailString, "")
        End Get
    End Property


    Private Function CreateErrorString() As String

        Dim zPrefix As String = "Validation Error: "
        Dim zSuffix As String = ""

        Select Case _ValidationError

            Case ValidationErrorType.DuplicateColumnName
                zSuffix = "Duplicate Column Name Exists."

            Case ValidationErrorType.EmptyColumnName
                zSuffix = "Empty Column Name Exists."

            Case ValidationErrorType.ExceedsMaxLength
                zSuffix = "Value Exceeds Maximum Length."

            Case ValidationErrorType.IncorrectDataType
                zSuffix = "Value Is Incorrect DataType."

            Case ValidationErrorType.FileNoDoesntMatchCurrentFileNo
                zSuffix = "Template Is For Another Location."

            Case ValidationErrorType.SheetDoesntExist
				zSuffix = "Import sheet doesnt exist in the spreadsheet."

            Case ValidationErrorType.SurveyInspectionDateGreaterToday
                zSuffix = "Survey/Inspection date greater than today's date."

            Case ValidationErrorType.SurveyDateIsBlank
                zSuffix = "Survey data is blank."

            Case ValidationErrorType.FileNoImproperFormat
                zSuffix = "FileNo not in correct format."

            Case ValidationErrorType.ColumnDoesntAllowNull
                zSuffix = "Column Doesnt Allow Null."

            Case ValidationErrorType.TemplateHasError
                zSuffix = "Template has error.'"

            Case ValidationErrorType.FileNoDoesntMatchCurrentFileNo
                zSuffix = "The File Number in the spreadsheet does not match current File Number."

            Case ValidationErrorType.FileNoDoesntMatchCurrentFilePrefix
                zSuffix = "The File Prefix Number in the spreadsheet does not match the current Client Prefix Number."

            Case ValidationErrorType.UnCommittableTransaction
                zSuffix = "The import failed to due another table having errors."

            Case ValidationErrorType.WrongPractice
                zSuffix = "The spreadsheet appears to be for a different practice."

            Case ValidationErrorType.BlankDataInRecommendations
                zSuffix = "There is blank data in the recommendations"

            Case ValidationErrorType.ActiveRecsNotInTemplate
                zSuffix = "There are recommendations in the database that are not in the spreadsheet."

            Case ValidationErrorType.DuplicateRecommendations
                zSuffix = "There are duplicate recommendations."

			Case ValidationErrorType.InvalidLEValue
				zSuffix = "Invalid data in one or more of the Actual LE columns"

			Case ValidationErrorType.APLNotFilledOut
				zSuffix = "APL not filled out"

			Case ValidationErrorType.APLWithRecsNotFilledOut
				zSuffix = "APL with recs not filled out"

			Case ValidationErrorType.RatingFormNotFilledOutProperly
				zSuffix = "Rating form not filled out properly."

			Case ValidationErrorType.RequiredField
				zSuffix = "Value is required for field in database."

            Case ValidationErrorType.CellHasError
                zSuffix = "Cell has error."

            Case ValidationErrorType.RecStatusDateDoesntMatchSurveyDate
                zSuffix = "Recommendation status date doesnt match survey date."

            Case ValidationErrorType.MultipleStatusDateInRec
                zSuffix = "Inconsistent recommendation status dates."

            Case ValidationErrorType.RecStatusInTemplateInvalid
                zSuffix = "Rec Status value in template is invalid."

            Case ValidationErrorType.TemplateIncorrectVersion
                zSuffix = "Template is incorrect version. Must be version " & UtilSetting.GetValue(UtilSetting.Keys.ImportTemplateVersion).ToString & " or greater. Please update to latest version and try again."

            Case ValidationErrorType.InvalidPrimarySecondaryTypes
                zSuffix = "Invalid primary/secondary type."

            Case ValidationErrorType.InvalidRecategory
                zSuffix = "Invalid category/impact value."

            Case ValidationErrorType.InvalidRecStatus
                zSuffix = "Invalid status value."

            Case ValidationErrorType.InvalidIntendedAction
                zSuffix = "Invalid intended action value."

        End Select

        Return zPrefix & zSuffix


    End Function


    Public Shared Function CreateDetailString(ByVal pErrorDetail As Dictionary(Of String, Object)) As String

        Dim zString As New Text.StringBuilder("\n\r")
        Dim zComma As String = ""
        If pErrorDetail IsNot Nothing Then
            For Each zPair As KeyValuePair(Of String, Object) In pErrorDetail

                If zPair.Value Is Nothing Then
                    zString.AppendLine(Replace(Space(10) & zPair.ToString & "\n\r", ",", ": Nothing"))
                Else
                    zString.AppendLine(Replace(Space(10) & zPair.ToString & "\n\r", ",", ":"))
                End If

            Next
                Return zString.ToString
        End If

        Return ""

    End Function


	Public Enum ValidationErrorType

		DuplicateColumnName
		EmptyColumnName
		ExceedsMaxLength
		IncorrectDataType
		FileNoDoesntMatchCurrentFileNo
		FileNoDoesntMatchCurrentFilePrefix
		SheetDoesntExist
		SurveyDateIsBlank
		SurveyInspectionDateGreaterToday
		FileNoImproperFormat
		ColumnDoesntAllowNull
		TemplateHasError
		UnCommittableTransaction
		WrongPractice
		BlankDataInRecommendations
		DuplicateRecommendations
		ActiveRecsNotInTemplate
		InvalidLEValue
		APLNotFilledOut
		RatingFormNotFilledOutProperly
		APLWithRecsNotFilledOut
        RequiredField
        CellHasError
        RecStatusDateDoesntMatchSurveyDate
        MultipleStatusDateInRec
        RecStatusInTemplateInvalid
        TemplateIncorrectVersion
        InvalidPrimarySecondaryTypes
        InvalidIntendedAction
        InvalidRecStatus
        InvalidRecategory
    End Enum

End Class
