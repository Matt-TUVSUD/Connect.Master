Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Partial Class ImportUtility

#Region "TemplateValidation"

    Public Sub ValidateTemplate()
        'ValidateColumns()
        ValidatePractice()
    End Sub

    Public Sub ValidateColumns()

        '      Dim zHeaderRange As Excel.Range = _Wksht.Range(_ImportTableResult.ImportTableInfo.HeaderRange)
        '      Dim zHeaderDict As New Dictionary(Of String, String)
        '      Dim zHeaderExceptionDict As New Dictionary(Of String, String)
        '      Dim zHeaderCell As Excel.Range = Nothing
        'Dim zValidationError As ValidationError = Nothing

        '      For Each zHeaderCell In zHeaderRange.Cells

        '          'Check to see if the column header is in the ignore list
        '          If Not Ignorev(zHeaderCell) Then

        '              'Try to get the value from the header dictionary. If sucessful then header already exists.
        '              If zHeaderDict.TryGetValue(zHeaderCell.Value, Nothing) Then

        '                  'Next check to see if an exception has already been created for this header (might have mulitple headers with same name).
        '                  If Not zHeaderExceptionDict.TryGetValue(zHeaderCell.Value, Nothing) Then

        '                      Dim zCellAddress As String = ""
        '                      zHeaderDict.TryGetValue(zHeaderCell.Value, zCellAddress)

        '                      'If can't get header from header exception dictionary
        '                      zHeaderExceptionDict.Add(zHeaderCell.Value, Nothing)

        '                      Dim zData As New Dictionary(Of String, Object)
        '                      zData.Add("Column Name", Chr(34) & zHeaderCell.Value & Chr(34))
        '                      zData.Add("Cells", Replace(zCellAddress, "$", "") & " and " & Replace(zHeaderCell.Address, "$", ""))
        '                      _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.DuplicateColumnName, zData))

        '                  End If
        '              Else
        '                  zHeaderDict.Add(zHeaderCell.Value, zHeaderCell.Address)
        '              End If
        '          End If
        '      Next

    End Sub


#End Region

#Region "DataValidation"

	Public Sub ValidateDataType(ByRef pValue As Object, ByVal pEntityColumn As String, ByVal pEntityType As System.Type)

        Dim zExceptionDetails As Dictionary(Of String, Object) = Nothing
        Dim zExpectedDataType As System.Type = EsHelper.GetEsColumnDataType(pEntityType, pEntityColumn)

        Try
            If zExpectedDataType.ToString() = "System.DateTime" Then
                If Not IsDate(pValue) Then
                    If IsNumeric(pValue) Then
                        pValue = DateTime.FromOADate(pValue)
                    End If
                End If
            End If

            If zExpectedDataType.ToString() = "System.Int32" Then
                If IsNumeric(pValue) Then
                    If pValue.ToString().Contains(".") Then
                        pValue = CInt(Math.Round(System.Decimal.Parse(pValue), 0))
                    Else
                        pValue = System.Int32.Parse(pValue)
                    End If
                End If
            End If

            If zExpectedDataType.ToString() = "System.Boolean" Then
                If IsNumeric(pValue) Then
                    If pValue = "1" Then pValue = Convert.ChangeType(True, zExpectedDataType)
                    If pValue = "0" Then pValue = Convert.ChangeType(False, zExpectedDataType)
                Else
                    If pValue.ToString.ToLower() = "yes" Then pValue = Convert.ChangeType(True, zExpectedDataType)
                    If pValue.ToString.ToLower() = "no" Then pValue = Convert.ChangeType(False, zExpectedDataType)
                End If
            End If

            If pValue.GetType.ToString = "System.String" Then
                If pEntityColumn.ToLower = "itemno" Then
                    Select Case pEntityType
                        Case GetType(BmElectricalTransformer), GetType(BmElectricalRotatingEquipment), GetType(BmBpvA), GetType(BmCpv), GetType(BmPpeA), GetType(BmEppmsA), GetType(BmPrimeMover)
                            pValue = Convert.ChangeType(Right(pValue, 1), zExpectedDataType)
                    End Select
                End If
            End If

            pValue = Convert.ChangeType(pValue, zExpectedDataType)

        Catch ex As Exception

            zExceptionDetails = New Dictionary(Of String, Object)
            zExceptionDetails.Add("Column", pEntityColumn)
            zExceptionDetails.Add("Expects", GetEnglishDataType(zExpectedDataType))
            zExceptionDetails.Add("Value", pValue)
            zExceptionDetails.Add("Exception", ex.Message)
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.IncorrectDataType, zExceptionDetails))

        End Try

    End Sub

    Public Sub ValidateStringLength(ByVal pValue As String, pEntityColumn As String)

        Dim zGetEntityType As System.Type = Meta.GetImportTableEntityType(_ImportTableResult.ImportTableInfo.ImportTableEnum)
        Dim zLenOfValue As Integer = Len(pValue)
        Dim zMaxChars As Long = EsHelper.GetEsColumnMaxLength(zGetEntityType, pEntityColumn)
        Dim zData As Dictionary(Of String, Object) = Nothing
        Dim zValidationError As ValidationError = Nothing
        Dim zExpectedDataType As System.Type = EsHelper.GetEsColumnDataType(zGetEntityType, pEntityColumn)



        If (zLenOfValue > zMaxChars) And (zExpectedDataType.ToString = "System.String") Then
            zData = New Dictionary(Of String, Object)
            zData.Add("Column", pEntityColumn)
            zData.Add("MaxLength", zMaxChars)
            zData.Add("Value", IIf(IsNothing(pValue), Nothing, Left(pValue.ToString, 25) & "..."))
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.ExceedsMaxLength, zData))
        End If

    End Sub

    Public Sub ValidateDate(ByRef pValue As DateTime)
        If pValue = VBAMinDate Then
            pValue = SqlTypes.SqlDateTime.Null
        End If
    End Sub


#End Region

#Region "BusinessLogic"

    Public Sub ValidateCope()

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateSurveyDate(_XLInfo.SurveyDate)
        ValidatePractice()

    End Sub

    Public Sub ValidateNatHazModeling()

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidatePractice()

    End Sub

    Public Sub ValidateNatHazData()

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateSurveyDate(_XLInfo.SurveyDate)
        ValidatePractice()

    End Sub

    Public Sub ValidateRetail()

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateSurveyDate(_XLInfo.SurveyDate)
        ValidatePractice()

    End Sub

    Public Sub ValidateFacility()

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateSurveyDate(_XLInfo.SurveyDate)
        ValidatePractice()

    End Sub

    Public Sub ValidateRating()

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateSurveyDate(_XLInfo.SurveyDate)
        ValidatePractice()

        'Check to see if APL is filled in
        '------------------------------------------------------------
        Dim zDetailException As Dictionary(Of String, Object) = Nothing
        Dim zColumnName As String = ""
        Dim zRatingTable As DataTable = _XLInfo.DataDictionary(_ImportingTableInfo)

        For Each zRow As DataRow In zRatingTable.Rows
            For Each zColumn As DataColumn In zRatingTable.Columns
                If IsDBNull(zRow.Item(zColumn)) Or IsNothing(zRow.Item(zColumn)) Then
                    If zColumnName = "APL" Then
                        _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.APLNotFilledOut, Nothing))
                    Else
                        _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.APLWithRecsNotFilledOut, Nothing))
                    End If
                End If
            Next
        Next

    End Sub

	Private Sub ValidatePractice()

        If _ImportType = ImportEnum.ImportType.FDS And _CurrentPractice <> UtilPractice.PracticeEnum.Fire And _CurrentPractice <> UtilPractice.PracticeEnum.NatHazSeismic And _CurrentPractice <> UtilPractice.PracticeEnum.NatHazWind And _CurrentPractice <> UtilPractice.PracticeEnum.NatHazWind And _CurrentPractice <> UtilPractice.PracticeEnum.NaturalHazards Then
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.WrongPractice, Nothing))

        ElseIf _ImportType = ImportEnum.ImportType.BDS And _CurrentPractice <> UtilPractice.PracticeEnum.BM Then
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.WrongPractice, Nothing))

        ElseIf _ImportType = ImportEnum.ImportType.PSDS And _CurrentPractice <> UtilPractice.PracticeEnum.ProcessSafety Then
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.WrongPractice, Nothing))

        End If

	End Sub

	Private Sub ValidateFileNoFormat(ByVal pFileNo As Object)
		If Not IsValidFileNoFormat(pFileNo) Then
			Dim zDetail As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
			zDetail.Add("FileNo", pFileNo)
			_ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.FileNoImproperFormat, zDetail))
		End If
	End Sub

	Private Sub ValidateFileNoLocation(ByVal pTemplateFileNo As Object, ByVal pCurrentFileNo As Object)
		Dim zDetail As Dictionary(Of String, Object)
		If pTemplateFileNo <> pCurrentFileNo Then
			zDetail = New Dictionary(Of String, Object)
			zDetail.Add("Template", pTemplateFileNo)
			zDetail.Add("Current", pCurrentFileNo)
			_ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.FileNoDoesntMatchCurrentFileNo, zDetail))
		End If
	End Sub

	Public Sub ValidateFilePrefixLocation(ByVal pTemplateFileNo As Object, ByVal pCurrentFileNo As Object)
		Dim zTemplateSplit() As String = Nothing
		Dim zCurrentSplit() As String = Nothing
		Dim zDetail As Dictionary(Of String, Object) = Nothing

		If IsValidFileNoFormat(pTemplateFileNo) And IsValidFileNoFormat(pCurrentFileNo) Then
			zTemplateSplit = Split(pTemplateFileNo, ".")
			zCurrentSplit = Split(pCurrentFileNo, ".")

			If zTemplateSplit(0) <> zCurrentSplit(0) Then
				zDetail = New Dictionary(Of String, Object)
				zDetail.Add("Template", zTemplateSplit(0))
				zDetail.Add("Current", zCurrentSplit(0))
				_ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.FileNoDoesntMatchCurrentFilePrefix, zDetail))
			End If

		End If
	End Sub

	Public Sub ValidateSurveyDate(ByVal pSurveyDate As Object)

		Dim zDetail As Dictionary(Of String, Object) = Nothing

		If Not IsValidSurveyDate(pSurveyDate) Then
			zDetail = New Dictionary(Of String, Object)
			zDetail.Add("Date", "")
			_ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.SurveyDateIsBlank, zDetail))
		Else
			If pSurveyDate = VBAMinDate Then
				zDetail = New Dictionary(Of String, Object)
				zDetail.Add("Date", "")
				_ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.SurveyDateIsBlank, zDetail))
			End If
			If pSurveyDate > Today Then
				zDetail = New Dictionary(Of String, Object)
				zDetail.Add("Date", pSurveyDate.ToString)
				_ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.SurveyInspectionDateGreaterToday, zDetail))
			End If
		End If

	End Sub

    Public Sub ValidateRequiredFields(ByRef pEntityObject As EntitySpaces.Core.esEntity)

        Dim zType As System.Type = pEntityObject.GetType
        Dim zRequiredFields As New List(Of String)
        Dim zExeptionDetail As Dictionary(Of String, Object) = Nothing
        Dim zFieldValue As Object = Nothing
        Dim zColumnList As List(Of String) = Nothing
        Dim zDetailException As Dictionary(Of String, Object) = Nothing
        Dim zPropertyName As String = ""
        Dim zEntityObjectMetadata As EntitySpaces.Core.esMetadata
        Dim zUseValidationError As ValidationError.ValidationErrorType = ValidationError.ValidationErrorType.RequiredField

        'Based on the enum value specify required fields
        Select Case _ImportTableResult.ImportTableInfo.ImportTableEnum

            Case ImportEnum.ImportTable.FireRecommendation, ImportEnum.ImportTable.BmRecommendation, ImportEnum.ImportTable.PSRecommendation
                zRequiredFields.AddRange({"RecCategory", "PrimaryRecType", "SecondaryRecType", "RecKeyWords", "IntendedAction", "RecStatus", "StatusDate"})
                '                If _SpecialFeatures.Contains("L"c) Or _SpecialFeatures.Contains("X"c) Then zRequiredFields.AddRange({"LossExpectancyBeforeActual", "LossExpentancyAfterActual", "CostToCompleteActual"}) Else zRequiredFields.AddRange({"LossExpectancyBefore", "LossExpectancyAfter", "CostToComplete"})
                zRequiredFields.AddRange({"LossExpectancyBeforeActual", "LossExpentancyAfterActual", "CostToCompleteActual"})
                If _SpecialFeatures.Contains("X"c) And _ImportType = ImportEnum.ImportType.FDS Then zRequiredFields.Add("RecCode")
                If _ImportType = ImportEnum.ImportType.FDS Then If Not _SpecialFeatures.Contains("X"c) Then zRequiredFields.Add("Hazard")
                zUseValidationError = ValidationError.ValidationErrorType.BlankDataInRecommendations


            Case ImportEnum.ImportTable.FireRating
                zRequiredFields.AddRange({"FloodRating", "EarthquakeRating", "WindstormRating", "ConstructionRating", "OccupancyRating", "OtherRating",
                  "PhysicalProtectionRating", "HumanElementRating", "NaturalHazardsProtectionRating", "BusinessContinuityRating",
                  "FireProtectionAllRecsCompleteRating", "HumanElementAllRecsCompleteRating", "BCPAllRecsCompletRating", "NatHazProtAllRecsCompleteRating",
                  "FloodDescription", "EarthquakeDescription", "WindstormDescription", "ConstructionDescription", "OccupancyDescription",
                   "OtherDescription", "FireDescription", "HumanDescription", "NaturalDescription", "BusinessDescription", "FireRecDescription",
                    "HumanRecDescription", "NaturalRecDescription", "BusinessRecDescription", "PassiveScore", "ActiveScore"})
                zUseValidationError = ValidationError.ValidationErrorType.RatingFormNotFilledOutProperly

        End Select


        'Get the List of Columns from the Entity Object.
        zColumnList = pEntityObject.GetCurrentListOfColumns()

        'Get the corresponding MetaData object from the EntityObject
        zEntityObjectMetadata = EsHelper.GetEsObject(EsHelper.GetEsType(pEntityObject.GetType, EsHelper.EntitySpaceClassType.MetaData))

        For Each zColumn As String In zColumnList
            If IsFieldRequired(zEntityObjectMetadata, zColumn, zRequiredFields) Then
                zPropertyName = EsHelper.GetEsColumnPropertyName(zEntityObjectMetadata, zColumn)
                zFieldValue = zType.InvokeMember(zPropertyName, Reflection.BindingFlags.GetProperty, Nothing, pEntityObject, New Object() {})

                If zFieldValue Is Nothing Then
                    zDetailException = New Dictionary(Of String, Object)
                    zDetailException.Add("Column", zColumn)
                    _ImportTableResult.ErrorList.Add(New ValidationError(zUseValidationError, zDetailException))
                Else

                    'FOR RECOMMENDATIONS WE NEED TO DO A FURTHER CHECKS

                    'THIS CHECK MAKES SURE THAT SOME REQUIRED FIELDS HAVE ONLY STRING VALUES
                    If _ImportTableResult.ImportTableInfo.ImportTableEnum = ImportEnum.ImportTable.FireRecommendation Or _ImportTableResult.ImportTableInfo.ImportTableEnum = ImportEnum.ImportTable.BmRecommendation Or _ImportTableResult.ImportTableInfo.ImportTableEnum = ImportEnum.ImportTable.PSRecommendation Then
                        If zRequiredFields.Contains(zColumn) And zColumn <> "LossExpectancyBeforeActual" And zColumn <> "LossExpentancyAfterActual" And zColumn <> "CostToCompleteActual" Then
                            If IsNumeric(zFieldValue) Then
                                zDetailException = New Dictionary(Of String, Object)
                                zDetailException.Add("Column", zColumn)
                                _ImportTableResult.ErrorList.Add(New ValidationError(zUseValidationError, zDetailException))
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub


#End Region

#Region "PrivateProperties"

    Private ReadOnly Property VBAMinDate As String
        Get
            Return "#12/30/1899#"
        End Get
    End Property


#End Region

#Region "PrivateFunctions"

    Private Function IsValidFileNoFormat(ByVal pFileNo As Object) As Boolean
        Dim zSplit() As String = Nothing
        Dim zLocNo As String = ""
        Dim zFileNoStr As String = ""

        If pFileNo.GetType.ToString = "System.String" Then
            zFileNoStr = DirectCast(pFileNo, System.String)

            If zFileNoStr.Length > 9 Then Return False
            If InStr(zFileNoStr, ".") > 0 Then
                zSplit = Split(zFileNoStr, ".")
                zLocNo = zSplit(1)
                If zLocNo.Length > 4 Then Return False
            Else
                Return False
            End If
        Else
            Return False
        End If

        Return True


    End Function

    Private Function IsValidSurveyDate(ByVal pSurveyDate As Object) As Boolean
        Dim zSurveyDate As DateTime

        If pSurveyDate.GetType.ToString = "System.DateTime" Then
            zSurveyDate = DirectCast(pSurveyDate, System.DateTime)

            If IsDate(zSurveyDate) Then
                If zSurveyDate.ToString = VBAMinDate Then
                    Return False
                End If
            Else
                Return False
            End If

        Else

            Return False

        End If
        Return True

    End Function

    Private Function ValidateTemplateType() As Boolean

        'If ExcelUtility.WorkSheetExists(_Wbk, "Cope Data") And
        '   ExcelUtility.WorkSheetExists(_Wbk, "Rating Form") And
        '   Left(_Wbk.Name, 1).ToLower = "f" Then
        '    Return True
        'Else
        '    Return False
        'End If

    End Function

    Private Function IsFieldRequired(ByVal zEntityObjectMetadata As EntitySpaces.Core.esMetadata, ByVal pEntityColumnName As String, ByVal pCustomRequiredFields As List(Of String)) As Boolean

        Dim zColumnMetaData As EntitySpaces.Interfaces.esColumnMetadata = Nothing

        'If is a custom required field, in other words, not required by SQL, but required via business logic. If not required for BL reasons, but required by SQL
        If pCustomRequiredFields.Contains(pEntityColumnName) Then
            Return True
        Else
            'Get the column meta data
            zColumnMetaData = EsHelper.GetEsColumnMetadata(zEntityObjectMetadata, pEntityColumnName)
            Return (Not zColumnMetaData.IsNullable) And (Not zColumnMetaData.IsAutoIncrement) And (Not zColumnMetaData.HasDefault)
        End If

        If Not pCustomRequiredFields.Contains(pEntityColumnName) And zColumnMetaData Is Nothing Then
            Throw New ImportException("Failed to see if " & pEntityColumnName & " is a required field.")
        End If

        Return Nothing

    End Function

    Public Shared Function CreateRecLink(ByVal FileNo As String, ByVal Year As String, ByVal Month As String, ByVal Number As String, ByVal Letter As String) As String

        If IsNumeric(Year) And IsNumeric(Number) Then
            Try
                Return String.Concat(FileNo, Convert.ToInt16(Year), Month, Convert.ToInt16(Number), Letter)
            Catch ex As Exception
                Throw New ImportException("Recommendation Year or Number fields is invalid. Can't convert " & Year & " OR " & Number & " to a number")
            End Try
        Else
            Throw New ImportException("Recommendation Year or Number fields is invalid. Can't convert " & Year & " OR " & Number & " to a number")
        End If

    End Function

    Private Function CreateRecLink77(ByVal pES As EntitySpaces.Core.esEntity) As String

        Dim zFileNo As String = pES.GetColumn("FileNo")
        Dim zYear As Object = pES.GetColumn("RecYear")
        Dim zMonth As Object = pES.GetColumn("RecMonth")
        Dim zNumber As Object = pES.GetColumn("RecNumber")
        Dim zLetter As Object = pES.GetColumn("RecSubletter")

        If IsNumeric(zYear) And IsNumeric(zNumber) Then
            Try
                Return String.Concat(zFileNo, Convert.ToInt16(zYear), zMonth, Convert.ToInt16(zNumber), zLetter)
            Catch ex As Exception
                Throw New ImportException("Recommendation Year or Number fields is invalid. Can't convert " & zYear & " OR " & zNumber & " to a number")
            End Try
        Else
            Throw New ImportException("Recommendation Year or Number fields is invalid. Can't convert " & zYear & " OR " & zNumber & " to a number")
        End If

    End Function


    Private Function GetEnglishDataType(ByVal pType As System.Type) As String

        Select Case pType.ToString

            Case "System.String"
                Return "String"

            Case "System.Boolean"
                Return "True/False"

            Case "System.Char"
                Return "Letter"

            Case "System.DateTime"
                Return "Date"

            Case "System.Decimal", "System.Double", "System.Single"
                Return "Decimal"

            Case "System.Int32", "System.Int64", "System.Int16"
                Return "Number"

            Case Else
                Return pType.ToString

        End Select






    End Function


#End Region

End Class

