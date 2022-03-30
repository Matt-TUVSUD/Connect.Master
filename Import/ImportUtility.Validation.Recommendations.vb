Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Partial Class ImportUtility

    Public Sub ValidateRecommendations()

        Dim zConstraintColumnNames As List(Of String) = New List(Of String)({"FileNo", "Year", "Month", "No", "Letter"})
        Dim zLEColumnNames As New List(Of String)({"Current Loss Estimate ($US)", "Completed Loss Estimated ($US)", "Est. Cost to Complete ($US)"})
        Dim zDetailException As Dictionary(Of String, Object) = Nothing
        Dim zRecCol As Object = Nothing
        Dim zRecQry As Object = Nothing
        Dim zLink As String = ""
        Dim zAllRecLinksList As New List(Of String)
        Dim zRecTemplateData As New DataTable

        'Basic Checks
        '---------------------------------------------------------------------------------------------------

        ValidateFileNoFormat(_CurrentFileNo)
        ValidateFileNoLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidateFilePrefixLocation(_XLInfo.FileNo, _CurrentFileNo)
        ValidatePractice()

        'Checks For Duplicate Recommendations using Datatable with unique constraint.
        '----------------------------------------------------------------------------------------------------
        Try
            Dim zDS As New DataSet("RecData")
            _XLInfo.DataDictionary.Keys.ToList.ForEach(Sub(x) zDS.Tables.Add(_XLInfo.DataDictionary(x)))

            For Each zDT As DataTable In zDS.Tables
                zRecTemplateData.Merge(zDT)
            Next

            zRecTemplateData.Constraints.Add("RecLinkConstraint", zRecTemplateData.Columns("RecLink"), False)


            'Checks For Recommendations In Database Not in Spreadsheet
            '-------------------------------------------------------------------------------------------------
            If _ImportType = ImportEnum.ImportType.FDS Then
                zRecQry = New FireRecommendationsQuery
                zRecCol = New FireRecommendationsCollection
            ElseIf _ImportType = ImportEnum.ImportType.BDS Then
                zRecQry = New BMRecommendationsQuery
                zRecCol = New BMRecommendationsCollection
            Else
                zRecQry = New PSRecommendationsQuery
                zRecCol = New PSRecommendationsCollection
            End If

            zRecQry.SelectAll()
            zRecQry.Where(zRecQry.FileNo = _CurrentFileNo)

            If zRecCol.Load(zRecQry) Then
                For Each zRec As Object In zRecCol

                    'Check only active recommendations
                    If Not IsNothing(zRec.RecStatus) Then
                        If (Not zRec.RecStatus.ToLower.Contains("conf completed")) And (Not zRec.RecStatus.ToLower.Contains("removed")) Then
                            Try
                                If zRecTemplateData.Columns.Count = 0 Then Stop
                                If zRecTemplateData.Select("RecLink='" & zRec.Link & "'").Count = 0 Then
                                    zDetailException = New Dictionary(Of String, Object)
                                    zDetailException.Add("Link", zRec.Link)
                                    _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.ActiveRecsNotInTemplate, zDetailException))
                                End If
                            Catch ex As Exception
                                Stop
                            End Try
                        End If
                    End If
                Next
            End If



            If zRecTemplateData.Rows.Count <> 0 Then

                'Checks for valid LE data.  Only for clients were special feature is X or L
                '---------------------------------------------------------------------------------------------------
                If _SpecialFeatures.Contains("X"c) Or _SpecialFeatures.Contains("L"c) Then

                    For Each zRow As DataRow In zRecTemplateData.Rows
                        If (Not IsNumeric(zRow(zLEColumnNames(0))) And (Not IsNumeric(zRow(zLEColumnNames(1)))) And (Not IsNumeric(zRow(zLEColumnNames(2))))) Then
                            If Left(zRow(zLEColumnNames(0)), 2).ToLower <> "he" And Left(zRow(zLEColumnNames(0)), 1).ToLower <> "o" Or Left(zRow(zLEColumnNames(1)), 1).ToLower <> "p" And Left(zRow(zLEColumnNames(1)), 1).ToLower <> "o" Or Left(zRow(zLEColumnNames(2)), 1).ToLower <> "m" And Left(zRow(zLEColumnNames(2)), 1).ToLower <> "o" Then
                                zDetailException = New Dictionary(Of String, Object)
                                zDetailException.Add("Link", zRow("RecLink"))
                                _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.InvalidLEValue, zDetailException))
                            End If
                        End If
                    Next
                End If


                'Checks to make sure that the status date is the same as survey date
                '------------------------------------------------------------------------------------------------
                Dim zDv As DataView = zRecTemplateData.AsDataView
                Dim zStatusDateDT As DataTable = zDv.ToTable(True, {"Date"})
                If zStatusDateDT.Rows.Count = 1 Then
                    If IsDate(zStatusDateDT.Rows(0)("Date")) Then
                        If zStatusDateDT.Rows(0)("Date") <> _XLInfo.SurveyDate Then
                            zDetailException = New Dictionary(Of String, Object)
                            zDetailException.Add("Rec Status Date", zStatusDateDT.Rows(0)("Date"))
                            zDetailException.Add("Survey Date", _XLInfo.SurveyDate.ToString)
                            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.RecStatusDateDoesntMatchSurveyDate, zDetailException))
                        End If
                    End If
                Else
                    zDetailException = New Dictionary(Of String, Object)
                    zDetailException.Add("Rec Status Date", zStatusDateDT.Rows(0)("Date"))
                    zDetailException.Add("Survey Date", _XLInfo.SurveyDate.ToString)
                    _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.MultipleStatusDateInRec, zDetailException))
                End If

            Else
                _ImportTableResult.ImportNote.Add(New ImportNote(ImportNote.ImportNoteType.NoRecommendationsToImport, Nothing))
            End If

            zDS.Tables.Clear()

        Catch ex As Exception
            zDetailException = New Dictionary(Of String, Object)
            zDetailException.Add("RecLink", zLink)
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.DuplicateRecommendations, zDetailException))
        End Try

    End Sub

    Public Function ShouldUpdateExpectedCompletionDate(ByVal DBEntityObject As Object, ByVal TempEntityObject As Object) As Boolean

        'THE FIRE AND BM RECOMMENDATIONS HAVE THE SAME FIELD NAMES. NO NEED TO CAST INTO TYPED OBJECTS
        If Not IsAlreadyResponded(DBEntityObject, TempEntityObject) Then
            If IsDate(TempEntityObject.ExpectedCompletionDate) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Function ShouldUpdateRecStatus(ByVal DBEntityObject As Object, ByVal TempEntityObject As Object) As Boolean

        ' Enum
        '1   Advisory
        '2   Conf Completed
        '3   In Progress
        '4   Outstanding
        '5   Removed
        '6   Rptd Completed

        'THE FIRE AND BM RECOMMENDATIONS HAVE THE SAME FIELD NAMES. NO NEED TO CAST INTO TYPED OBJECTS
        If IsAlreadyResponded(DBEntityObject, TempEntityObject) Then
            Dim dict As New Dictionary(Of String, Object)

            Select Case DBEntityObject.RecStatusId
                Case 2, 5 '"conf completed", "removed"
                    Return False
                Case 1 ' "advisory"
                    If TempEntityObject.RecStatusId <> 1 Then  ' "advisory"
                        dict.Add("Changed To Status", TempEntityObject.RecStatus)
                        dict.Add("Rec Year", TempEntityObject.RecYear)
                        dict.Add("Rec Month", TempEntityObject.RecMonth)
                        dict.Add("Rec Num.", TempEntityObject.RecNumber)
                        Me._ImportTableResult.ImportNote.Add(New ImportNote(ImportNote.ImportNoteType.AdvisoryStatusChanged, dict))
                        Return True
                    Else
                        Return False
                    End If
                Case 6 ' "rptd completed"
                    '                    If TempEntityObject.RecStatus.ToLower = "conf completed" Or TempEntityObject.RecStatus.ToLower = "removed" Then Return True Else Return False
                    If TempEntityObject.RecStatusId = 2 Or TempEntityObject.RecStatusId = 5 Then Return True Else Return False

                Case 3 ' "in progress"
                    'If TempEntityObject.RecStatus.ToLower = "rptd completed" Or TempEntityObject.RecStatus.ToLower = "removed" Or TempEntityObject.RecStatus.ToLower = "conf completed" Or TempEntityObject.RecStatus.ToLower = "advisory" Then Return True Else Return False

                    If TempEntityObject.RecStatusId = 6 Or TempEntityObject.RecStatusId = 5 Or TempEntityObject.RecStatusId = 2 Or TempEntityObject.RecStatusId = 1 Then Return True Else Return False

                Case 4 ' "outstanding"
                    Return True
                Case Else
                    dict.Add("Rec Status", TempEntityObject.RecStatus)
                    dict.Add("Rec Year", TempEntityObject.RecYear)
                    dict.Add("Rec Month", TempEntityObject.RecMonth)
                    dict.Add("Rec Num.", TempEntityObject.RecNumber)
                    Me._ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.RecStatusInTemplateInvalid, dict))
                    Return False
            End Select

        Else
            Return True
        End If

    End Function

    Public Function IsAlreadyResponded(ByVal DatabaseObject As Object, ByVal TemplateObject As Object) As Boolean

        'IF THE RESPONSE DATE IN DB IS LESS THAN OR EQUAL TO THE STATUS DATE OF THE
        'RECOMMENDATION WERE IMPORTING FROM TEMPLATE THEN RECOMMENDATION HAS NOT ALREADY BEEN RESPONDED.
        If DatabaseObject.ResponseDate <= TemplateObject.StatusDate Then
            Return False
        Else
            Return True
        End If

    End Function


End Class
