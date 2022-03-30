
Imports Microsoft.Office.Interop


Public Class ImportUtility

    Dim _CurrentFileNo As String = ""
    Dim _ImportType As ImportEnum.ImportType
    Dim _SpecialFeatures() As Char
    Dim _CurrentFilePrefix As String = ""
    Dim _ImportTableResult As ImportTableResult
    Dim _CurrentPractice As UtilPractice.PracticeEnum
    Dim _FileString As String = ""
    Dim _IsNatHazImport As Boolean = False

    Dim _ImportTableInfoList As ImportTableInfoList
    Dim _Pkg As New GRC.Excel.Package()

    Public _XLInfo As ExcelDataTemplateInfo = Nothing
    Public _ImportingTableInfo As ImportTableInfo = Nothing

    Public RecMeta As New UtilRecMeta

    Public Function Import(ByVal pGuid As String, ByVal pFiles As List(Of String), ByVal pImportSheets As List(Of ImportEnum.ImportSheet), ByVal pImportType As ImportEnum.ImportType) As ImportFileResultList

        _CurrentFileNo = GetCurrentFileNo(pGuid)
        _SpecialFeatures = GetSpecialFeatures(pGuid)
        _CurrentFilePrefix = GetCurrentFilePrefix(pGuid)
        _CurrentPractice = GetCurrentPractice(pGuid)
        _ImportType = pImportType
        _IsNatHazImport = IO.Path.GetFileName(pFiles.First).ToString.ToLower.StartsWith("nh")

        Dim zMeta As Object
        Dim zTransaction As EntitySpaces.Interfaces.esTransactionScope = Nothing
        Dim zImportFileResult As ImportFileResult
        Dim zImportFileResultList As New ImportFileResultList
        Dim zImportSheetResult As ImportSheetResult
        Dim zExeptionDetails As Dictionary(Of String, Object) = Nothing
        Dim zFile As String = ""
        'Determine Meta to Use
        If pImportType = ImportEnum.ImportType.FDS Then
            If _CurrentFileNo = "" Then Throw New ImportException("The system can not determine your current FileNo.")
            If Int(_CurrentFilePrefix) = 495 Or Int(_CurrentFilePrefix) = 3129 Then
                zMeta = New CargillFireMeta(Me)
            ElseIf Int(_CurrentFilePrefix) = 2594 Then
                zMeta = New CalpineFireMeta(Me)
            Else
                zMeta = New FireMeta(Me)
            End If

        ElseIf pImportType = ImportEnum.ImportType.BDS Then

            If _CurrentFileNo = "" Then Throw New ImportException("The system can not determine your current FileNo.")
            If Int(_CurrentFileNo) = 2174 Then
                zMeta = New AesBmMeta(Me)
            ElseIf Int(_CurrentFilePrefix) = 2594 Then
                zMeta = New CalpineBmMeta(Me)
            Else
                zMeta = New BmMeta(Me)
            End If
        Else
            zMeta = New PSMeta(Me)
        End If

        Try

            'Check For Files
            If pFiles.Count <> 0 Then

                For Each zFile In pFiles

                    If IO.File.Exists(zFile) Then

                        _Pkg.Load(zFile)

                        _XLInfo = New ExcelDataTemplateInfo(_Pkg, zMeta)

                        'VALIDATE TEMPLATE VERSION
                        ValidateTemplateVersion()

                        'Create a FileResultList object
                        zImportFileResult = New ImportFileResult(_Pkg.ActiveWorksheetName)

                        For Each zImportSheet In pImportSheets

                            'Create a import table info collection object
                            _ImportTableInfoList = New ImportTableInfoList

                            If pImportType = ImportEnum.ImportType.FDS Then

                                Select Case zImportSheet

                                    Case ImportEnum.ImportSheet.CopeData
                                        With _ImportTableInfoList
                                            .Add(zMeta.FireCopeMainImportInfo)
                                            .Add(zMeta.FireCopeConstructionImportInfo)
                                            .Add(zMeta.FireCopeOccupancyImportInfo)
                                            .Add(zMeta.FireCopeProtectionImportInfo)
                                            .Add(zMeta.FireCopeExposureImportInfo)
                                        End With
                                    Case ImportEnum.ImportSheet.NatHazData
                                        With _ImportTableInfoList
                                            .Add(zMeta.FireNatHazDataFloodExposureImportInfo)
                                            .Add(zMeta.FireNatHazDataFloodBldgStructureImportInfo)
                                            .Add(zMeta.FireNatHazDataFloodOtherImportInfo)
                                            .Add(zMeta.FireNatHazDataFloodGeneralImportInfo)
                                            .Add(zMeta.FireNatHazDataSeismicGeneralImportInfo)
                                            .Add(zMeta.FireNatHazDataSeismicNonStructuralImportInfo)
                                            .Add(zMeta.FireNatHazDataSeismicStructuralImportInfo)
                                            .Add(zMeta.FireNatHazDataSeismicStructuralDataImportInfo)
                                            .Add(zMeta.FireNatHazDataWindEnvelopeImportInfo)
                                            .Add(zMeta.FireNatHazDataWindGeneralImportInfo)
                                            .Add(zMeta.FireNatHazDataWindMiscImportInfo)
                                            .Add(zMeta.FireNatHazDataWindUtilityImportInfo)
                                        End With
                                    Case ImportEnum.ImportSheet.NatHazModelingData
                                        With _ImportTableInfoList
                                            .Add(zMeta.FireNatHazModelingDataImportInfo)
                                        End With

                                    Case ImportEnum.ImportSheet.RatingForm
                                        With _ImportTableInfoList
                                            .Add(zMeta.FireRatingImportInfo)
                                        End With

                                    Case ImportEnum.ImportSheet.RecTracking

                                        With _ImportTableInfoList
                                            .Add(zMeta.FireRecTrackingImportInfo)

                                            If _XLInfo.TemplateVersion < 6.0 Then
                                                If Not _Pkg.IsWorksheetHidden(zMeta.FireRecTracking2ImportInfo.SheetName) Then
                                                    .Add(zMeta.FireRecTracking2ImportInfo)
                                                End If
                                                If Not _Pkg.IsWorksheetHidden(zMeta.FireRecTracking3ImportInfo.SheetName) Then
                                                    .Add(zMeta.FireRecTracking3ImportInfo)
                                                End If
                                                If Not _Pkg.IsWorksheetHidden(zMeta.FireRecTracking4ImportInfo.SheetName) Then
                                                    .Add(zMeta.FireRecTracking4ImportInfo)
                                                End If
                                            End If

                                        End With

                                    Case ImportEnum.ImportSheet.RetailData
                                        With _ImportTableInfoList
                                            .Add(zMeta.FireRetailImportInfo)
                                        End With

                                End Select


                            ElseIf pImportType = ImportEnum.ImportType.BDS Then

                                Select Case zImportSheet

                                    Case ImportEnum.ImportSheet.FacilityData
                                        With _ImportTableInfoList
                                            .Add(zMeta.BmFacilityMainImportInfoImportInfo)
                                            .Add(zMeta.BmOccupancyImportInfo)
                                            .Add(zMeta.BmBpvAImportInfo)
                                            .Add(zMeta.BmBpvImportInfo)
                                            .Add(zMeta.BmComputerSystemsImportInfo)
                                            .Add(zMeta.BmCpvImportInfo)
                                            .Add(zMeta.BmElectricalImportInfo)
                                            .Add(zMeta.BmElectricalRotatingEquipmentImportInfo)
                                            .Add(zMeta.BmElectricalTransformerImportInfo)
                                            .Add(zMeta.BmEppmsAImportInfo)
                                            .Add(zMeta.BmEppmsImportInfo)
                                            .Add(zMeta.BmHebcpImportInfo)
                                            .Add(zMeta.BmMechanicalImportInfo)
                                            .Add(zMeta.BmMppmImportInfo)
                                            .Add(zMeta.BmPpeAImportInfo)
                                            .Add(zMeta.BmPpeImportInfo)
                                            .Add(zMeta.BmPrimeMoverImportInfo)
                                        End With

                                    Case ImportEnum.ImportSheet.RecTracking

                                        RecMeta = New UtilRecMeta

                                        With _ImportTableInfoList
                                            .Add(zMeta.BmRecTrackingImportInfo)

                                            If Not _Pkg.IsWorksheetHidden(zMeta.BmRecTracking2ImportInfo.SheetName) Then
                                                .Add(zMeta.BmRecTracking2ImportInfo)
                                            End If

                                            If Not _Pkg.IsWorksheetHidden(zMeta.BmRecTracking3ImportInfo.SheetName) Then
                                                .Add(zMeta.BmRecTracking3ImportInfo)
                                            End If

                                            If Not _Pkg.IsWorksheetHidden(zMeta.BmRecTracking4ImportInfo.SheetName) Then
                                                .Add(zMeta.BmRecTracking4ImportInfo)
                                            End If

                                        End With

                                    Case ImportEnum.ImportSheet.RatingForm
                                        With _ImportTableInfoList
                                            .Add(zMeta.BmRatingImportInfo)
                                        End With

                                End Select

                            ElseIf pImportType = ImportEnum.ImportType.PSDS Then

                                Select Case zImportSheet

                                    Case ImportEnum.ImportSheet.RecTracking
                                        With _ImportTableInfoList

                                            .Add(zMeta.PSRecTrackingImportInfo)

                                            If Not _Pkg.IsWorksheetHidden(zMeta.PSRecTracking2ImportInfo.SheetName) Then
                                                .Add(zMeta.PSRecTracking2ImportInfo)
                                            End If

                                            If Not _Pkg.IsWorksheetHidden(zMeta.PSRecTracking3ImportInfo.SheetName) Then
                                                .Add(zMeta.PSRecTracking3ImportInfo)
                                            End If

                                            If Not _Pkg.IsWorksheetHidden(zMeta.PSRecTracking4ImportInfo.SheetName) Then
                                                .Add(zMeta.PSRecTracking4ImportInfo)
                                            End If

                                        End With

                                End Select


                            End If

                            'Start the import using the current importInfoCollection

                            zTransaction = StartTransaction()
                            zImportSheetResult = ImportSheet(zImportSheet)

                            'If the transaction is sucessful then committ, otherwise rollback.
                            If zImportSheetResult.IsSuccessful Then
                                zTransaction.Complete()
                                DisposeTransaction(zTransaction)
                                RecMeta.Dispose()

                                If zImportSheet = ImportEnum.ImportSheet.RecTracking Then
                                    UpdateMedianValues()
                                End If

                            Else
                                DisposeTransaction(zTransaction)
                                zImportSheetResult.ResetCounters(ValidationError.ValidationErrorType.UnCommittableTransaction)
                            End If


                            'Add the ImportSheetResult to the ImportFileResult collection
                            zImportFileResult.ImportSheetResultList.Add(zImportSheetResult)

                        Next

                    Else

                        Throw New ImportException(zFile & " does not exist.")

                    End If

                    zImportFileResultList.Add(zImportFileResult)

                Next

            Else

                Throw New ImportException("No File(s) were selected to import.")

            End If

        Catch ex As Exception

            Diagnostics.EventLog.WriteEntry("Application", GRC.Resources.ExceptionUtility.ExtractMessages(ex), EventLogEntryType.Error)
            Throw

        Finally

            RecMeta.Dispose()

            If zTransaction IsNot Nothing Then
                DisposeTransaction(zTransaction)
                zTransaction = Nothing
            End If

        End Try

        _Pkg.Dispose()

        Return zImportFileResultList

    End Function


    Private Function ImportSheet(pImportSheet As ImportEnum.ImportSheet) As ImportSheetResult

        Dim zEntityType As System.Type = Nothing
        Dim zEntityObj As EntitySpaces.Core.esEntity = Nothing
        Dim zEntityColumnName As String = ""
        ' Dim zExceptionDetails As Dictionary(Of String, Object)
        Dim zImportSheetResult As ImportSheetResult
        Dim zImportData As DataTable = Nothing
        Dim zImportDataValue As Object = Nothing

        'Create a return object
        zImportSheetResult = New ImportSheetResult([Enum].GetName(GetType(ImportEnum.ImportSheet), pImportSheet))

        _XLInfo.LoadData(_ImportTableInfoList, pImportSheet)

        For Each zImportTableInfo As ImportTableInfo In _XLInfo.DataDictionary.Keys

            _ImportingTableInfo = zImportTableInfo

            'Create a ImportTableResult object
            _ImportTableResult = New ImportTableResult(zImportTableInfo)

                _Pkg.SelectSheet(zImportTableInfo.SheetName)

                zImportData = _XLInfo.DataDictionary(zImportTableInfo)

                zEntityType = Meta.GetImportTableEntityType(zImportTableInfo.ImportTableEnum)

                'Validate template - High level template structure validation
                ValidateTemplate()

                'Validate Import - High level Business Logic Validation
                ValidateImportSheet()

                'If Template and Import validations are succesful (no errors), then proceed.
                If _ImportTableResult.IsSuccessful Then

                    'Check to see if process should delete original records
                    DeleteExistingRecords()

                    'Loop through each row 
                    For Each zImportDataRow As DataRow In zImportData.Rows

                        'Check to see if row has values or should be skipped.
                        If Not (String.IsNullOrEmpty(zImportDataRow(0)) And String.IsNullOrEmpty(zImportDataRow(1)) And String.IsNullOrEmpty(zImportDataRow(2))) Then

                            'Create a the Entity object to save the import values to
                            zEntityObj = Activator.CreateInstance(zEntityType, True)

                            'Loop through each cell in the current row
                            For Each zImportDataColumn As DataColumn In zImportData.Columns

                                'Check to see which column this value belongs in.  Try to get Entity column name.
                                zEntityColumnName = zImportTableInfo.Meta.GetEntityColumnNameFromMap(zImportDataColumn.ColumnName, zImportTableInfo.ImportTableEnum)

                                'if there is no property for the column then just ignore.
                                If zEntityColumnName <> "" Then
                                    zImportDataValue = zImportDataRow(zImportData.Columns.IndexOf(zImportDataColumn))

                                    'Check to see if this column should be ignored due to either a invalid value or error in cell or a custom validation
                                    If Not IgnoreValue(zImportDataValue, zEntityColumnName, zEntityObj) Then

                                        'Validate cell data
                                        ValidateDataType(zImportDataValue, zEntityColumnName, zEntityType)

                                        Select Case zImportDataValue.GetType.ToString
                                            Case "System.String"
                                                ValidateStringLength(zImportDataValue, zEntityColumnName)
                                            Case "System.DateTime"
                                                ValidateDate(zImportDataValue)
                                        End Select

                                        zEntityObj.SetProperty(zEntityColumnName, zImportDataValue)

                                    End If

                                End If

                            Next


                        If pImportSheet = ImportEnum.ImportSheet.RecTracking Then
                            'we need to set the ids for the recommendation if new rec
                            If _IsNatHazImport Then
                                Dim clone As ImportTableInfo = _ImportingTableInfo
                                clone.MetaPractice = UtilMetaPractice.Practices.NaturalHazards
                                RecMeta.SetIds(zEntityObj, _ImportTableResult, clone)
                            Else
                                RecMeta.SetIds(zEntityObj, _ImportTableResult, _ImportingTableInfo)
                            End If

                        End If

                        If _ImportTableResult.IsSuccessful Then

                                'This applies calculated values to fields, or sets defaults (ie: RecTracking Link Field)
                                SetFieldValues(zEntityObj)

                                'This ensures that required fields have values
                                '                                ValidateRequiredFields(zEntityObj, ExcelUtility.GetCellValue(_Wbk, zImportInfo.Meta.SurveyDateCellAddress))
                                ValidateRequiredFields(zEntityObj)

                                'Check if record is OK to Import 
                                If ShouldFinalize(zEntityObj) Then

                                    If Not TryUpdateExistingRecord(zEntityObj) Then

                                        'Save the new record
                                        SaveNewRecord(zEntityObj)

                                    End If

                                End If  'Row Empty

                            End If

                        End If

                    Next     'Import Row Loop

                End If

                zImportSheetResult.ImportTableResultList.Add(_ImportTableResult)

            Next

        Return zImportSheetResult

    End Function

    Public Function IgnoreValue(ByVal pDataValue As Object, Optional ByVal pEntityColumn As String = "", Optional ByVal pEntityObj As Object = Nothing) As Boolean

        Dim zExceptionDetail As Dictionary(Of String, Object) = Nothing
        Dim zIgnoreList As New List(Of String)
        zIgnoreList.Add("")

        If Not pDataValue.ToString().ToLower.Contains("#ExcelFormulaError".ToLower) Then

            If pDataValue <> "" Then

                If pEntityObj IsNot Nothing Then

                    'Cope main table exceptions
                    If TypeOf pEntityObj Is BusinessObjects.BmMain Or TypeOf pEntityObj Is BusinessObjects.CopeFireMain Then
                        Select Case pEntityObj.GetType

                            Case GetType(BusinessObjects.BmMain)
                                Dim zObj As BusinessObjects.BmMain = DirectCast(pEntityObj, BusinessObjects.BmMain)
                                If "mflbi" = pEntityColumn.ToLower Or _
                                    "mflpd" = pEntityColumn.ToLower Or _
                                    "mflpdpercentage" = pEntityColumn.ToLower Or _
                                    "mflbipercentage" = pEntityColumn.ToLower Or _
                                    "mfltotal" = pEntityColumn.ToLower Or _
                                    "mfltotalpercentage" = pEntityColumn.ToLower Or _
                                    "pmlbi" = pEntityColumn.ToLower Or _
                                    "pmlpd" = pEntityColumn.ToLower Or _
                                    "pmlpdpercentage" = pEntityColumn.ToLower Or _
                                    "pmlbipercentage" = pEntityColumn.ToLower Or _
                                    "pmltotal" = pEntityColumn.ToLower Or _
                                    "pmltotalpercentage" = pEntityColumn.ToLower Or _
                                    "repttiv" = pEntityColumn.ToLower Or _
                                    "reptbi" = pEntityColumn.ToLower Or _
                                    "reptpd" = pEntityColumn.ToLower Then

                                    If pDataValue.ToString.ToLower = "n/a" Then Return True

                                End If

                            Case GetType(BusinessObjects.CopeFireMain)
                                Dim zObj As BusinessObjects.CopeFireMain = DirectCast(pEntityObj, BusinessObjects.CopeFireMain)
                                If "mflbi" = pEntityColumn.ToLower Or _
                                    "mflpd" = pEntityColumn.ToLower Or _
                                    "mflpdpercentage" = pEntityColumn.ToLower Or _
                                    "mflbipercentage" = pEntityColumn.ToLower Or _
                                    "mfltotal" = pEntityColumn.ToLower Or _
                                    "mfltotalpercentage" = pEntityColumn.ToLower Or _
                                    "pmlbi" = pEntityColumn.ToLower Or _
                                    "pmlpd" = pEntityColumn.ToLower Or _
                                    "pmlpdpercentage" = pEntityColumn.ToLower Or _
                                    "pmlbipercentage" = pEntityColumn.ToLower Or _
                                    "pmltotal" = pEntityColumn.ToLower Or _
                                    "pmltotalpercentage" = pEntityColumn.ToLower Or _
                                    "aplbi" = pEntityColumn.ToLower Or _
                                    "aplpd" = pEntityColumn.ToLower Or _
                                    "aplpdercentage" = pEntityColumn.ToLower Or _
                                    "aplbipercentage" = pEntityColumn.ToLower Or _
                                    "apltotal" = pEntityColumn.ToLower Or _
                                    "apltotalpercentage" = pEntityColumn.ToLower Then

                                    If pDataValue.ToString.ToLower = "n/a" Then Return True

                                End If

                        End Select
                    End If
                End If

                'Recommendations Tables
                If TypeOf pEntityObj Is BusinessObjects.BMRecommendations Or TypeOf pEntityObj Is BusinessObjects.FireRecommendations Then
                    Select Case pEntityObj.GetType
                        Case GetType(BusinessObjects.BMRecommendations)
                            Dim zObj As BusinessObjects.BMRecommendations = DirectCast(pEntityObj, BusinessObjects.BMRecommendations)
                            If "savingsratio" = pEntityColumn.ToLower Then
                                If pDataValue.ToString.ToLower = "n/a" Then Return True
                            End If
                        Case GetType(BusinessObjects.FireRecommendations)
                            Dim zObj As BusinessObjects.FireRecommendations = DirectCast(pEntityObj, BusinessObjects.FireRecommendations)
                            If "savingsratio" = pEntityColumn.ToLower Then
                                If pDataValue.ToString.ToLower = "n/a" Then Return True
                            End If
                    End Select
                End If

                For Each zString In zIgnoreList
                    If pDataValue.ToLower = zString.ToLower Then
                        Return True
                    End If
                Next

                Return False

            Else
                Return True
            End If
        Else
            Dim zDict As New Dictionary(Of String, Object)
            Dim zErrName As String = ""
            ExcelUtility.ExcelErrorDictionary.TryGetValue(pDataValue, zErrName)
            zDict.Add("Value", Left(zErrName, 10))
            _ImportTableResult.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.CellHasError, zDict))
            Return True
        End If

    End Function

    Private Function StartTransaction() As EntitySpaces.Interfaces.esTransactionScope
        Dim zEsTrans As New EntitySpaces.Interfaces.esTransactionScope()
        Return zEsTrans
    End Function

    Private Sub DisposeTransaction(ByRef pTransaction As EntitySpaces.Interfaces.esTransactionScope)
        Dim zDisposable As IDisposable = DirectCast(pTransaction, IDisposable)
        zDisposable.Dispose()
        pTransaction = Nothing
    End Sub

    'Private Overloads Function CreateHeaderDictionary(ByVal pCells As Excel.Range, ByVal pImportInfo As ImportTableInfo, Optional ByVal pColumnsOnly() As String = Nothing) As Dictionary(Of Integer, String)

    '    Dim zCell As Excel.Range = Nothing
    '    Dim zEntityColumn As String = ""
    '    Dim zDict As New Dictionary(Of Integer, String)
    '    Dim zExeptionDetails As Dictionary(Of String, Object) = Nothing

    '    For Each zCell In pCells

    '        If zCell.Row <> pImportInfo.HeaderRow Then Exit For
    '        zEntityColumn = pImportInfo.Meta.GetEntityColumnNameFromMap(zCell.Value, pImportInfo.ImportTableEnum)

    '        If zEntityColumn <> String.Empty Then
    '            If pColumnsOnly Is Nothing Then
    '                zDict.Add(zCell.Column, zEntityColumn)
    '            Else
    '                If pColumnsOnly.Contains(zCell.Value) Then
    '                    zDict.Add(zCell.Column, zEntityColumn)
    '                End If
    '            End If
    '        Else
    '            Trace.WriteLine("Import Header Column Missing: " & zCell.Value)
    '        End If

    '    Next

    '    Return zDict

    'End Function

    Private Function TryUpdateExistingRecord(ByVal pCurrentEntityObject As EntitySpaces.Core.esEntity) As Boolean

        Select Case _ImportTableResult.ImportTableInfo.ImportSheetEnum

            Case ImportEnum.ImportSheet.RecTracking
                Dim zNewRec As Object
                Dim zExistRec As Object
                Dim zRecQry As Object
                If _ImportType = ImportEnum.ImportType.FDS Then
                    zNewRec = DirectCast(pCurrentEntityObject, BusinessObjects.FireRecommendations)
                    zExistRec = New FireRecommendations
                    zRecQry = New FireRecommendationsQuery
                ElseIf _ImportType = ImportEnum.ImportType.BDS Then
                    zNewRec = DirectCast(pCurrentEntityObject, BusinessObjects.BMRecommendations)
                    zExistRec = New BMRecommendations
                    zRecQry = New BMRecommendationsQuery
                Else
                    zNewRec = DirectCast(pCurrentEntityObject, BusinessObjects.PSRecommendations)
                    zExistRec = New PSRecommendations
                    zRecQry = New PSRecommendationsQuery
                End If

                Dim zId As Integer = 0

                zRecQry.Select(zRecQry.Id)
                zRecQry.Where(zRecQry.Link = zNewRec.Link)
                zId = zRecQry.ExecuteScalar

                'If query cant find existing record based on the Link, then add record
                If zId <> 0 Then
                    If zExistRec.LoadByPrimaryKey(zId) Then
                        With zExistRec
                            .StatusDate = zNewRec.StatusDate
                            .RecCode = zNewRec.RecCode
                            .RecKeyWords = zNewRec.RecKeyWords
                            .LossExpectancyBefore = zNewRec.LossExpectancyBefore
                            .LossExpectancyAfter = zNewRec.LossExpectancyAfter
                            .CostToComplete = zNewRec.CostToComplete
                            .SavingsRatio = zNewRec.SavingsRatio
                            .PrimaryRecTypeId = zNewRec.PrimaryRecTypeId
                            .PrimaryRecType = zNewRec.PrimaryRecType
                            .SecondaryRecTypeId = zNewRec.SecondaryRecTypeId
                            .SecondaryRecType = zNewRec.SecondaryRecType
                            .RecCategory = zNewRec.RecCategory
                            .RecCategoryId = zNewRec.RecCategoryId

                            If _CurrentFilePrefix = 2594 Then
                                .ThirdLevelRespComment = zNewRec.ThirdLevelRespComment
                            End If

                            If Not Me.IsAlreadyResponded(zExistRec, zNewRec) Then
                                .IntendedAction = zNewRec.IntendedAction
                                .IntendedActionId = zNewRec.IntendedActionId
                            End If

                            If Me.ShouldUpdateRecStatus(zExistRec, zNewRec) Then
                                .RecStatus = zNewRec.RecStatus
                                .RecStatusId = zNewRec.RecStatusId
                            End If

                            If Me.ShouldUpdateExpectedCompletionDate(zExistRec, zNewRec) Then
                                .ExpectedCompletionDate = zNewRec.ExpectedCompletionDate
                            End If

                            .ActualCostToComplete = zNewRec.ActualCostToComplete
                            .LossExpectancyAfterActual = zNewRec.LossExpectancyAfterActual
                            .LossExpectancyBeforeActual = zNewRec.LossExpectancyBeforeActual
                            .CostToCompleteActual = zNewRec.CostToCompleteActual
                            .ActualCostToComplete = zNewRec.ActualCostToComplete

                            'For Fire Only, set the Hazard field
                            If _ImportType = ImportEnum.ImportType.FDS Then
                                .Hazard = zNewRec.Hazard
                                .RatingBCPPts = zNewRec.RatingBCPPts
                                .RatingCat = zNewRec.RatingCat
                                .RatingCatPts = zNewRec.RatingCatPts
                                .RatingCatWeight = zNewRec.RatingCatWeight
                                .RatingHEPts = zNewRec.RatingHEPts
                                .RatingNHPts = zNewRec.RatingNHPts
                                .RatingPPPts = zNewRec.RatingPPPts
                                .RatingScoreChange = zNewRec.RatingScoreChange
                                .RecPriority = zNewRec.RecPriority
                                .RecDetail = zNewRec.RecDetail
                            End If

                            'Update the importdate
                            .ImportDate = Now.ToString

                            .ActualCostToComplete = zNewRec.ActualCostToComplete
                            .Save()
                            _ImportTableResult.UpdateCount += 1


                        End With

                        Return True

                    Else
                        Throw New ImportException("Import process cant load Recommendation Id " & zId & " for update.")
                    End If

                Else

                    Return False

                End If

            Case Else

                Return False

        End Select

    End Function

    Private Sub SaveNewRecord(ByRef pCurrentEntityObject As EntitySpaces.Core.esEntity)

        pCurrentEntityObject.Save()
        _ImportTableResult.InsertCount += 1

    End Sub

    Private Sub DeleteExistingRecords()

        Dim zCol As Object = Nothing
        Dim zQry As Object = Nothing

        Select Case _ImportTableResult.ImportTableInfo.ImportTableEnum

            Case ImportEnum.ImportTable.FireCopeMain
                zQry = New CopeFireMainQuery
                zCol = New CopeFireMainCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireCopeConstruction
                zQry = New CopeFireConstructionQuery
                zCol = New CopeFireConstructionCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireCopeExposure
                zQry = New CopeFireExposureQuery
                zCol = New CopeFireExposureCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireCopeProtection
                zQry = New CopeFireProtectionQuery
                zCol = New CopeFireProtectionCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireCopeOccupancy
                zQry = New CopeFireOccupancyQuery
                zCol = New CopeFireOccupancyCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireRating
                Dim zSurveyRange As Object
                zSurveyRange = _XLInfo.SurveyDate
                zQry = New RatingQuery
                zCol = New RatingCollection
                zQry.selectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo And zQry.InspectionDate = zSurveyRange)

            Case ImportEnum.ImportTable.FireRetail
                Dim zSurveyRange As Object
                zSurveyRange = _XLInfo.SurveyDate
                zQry = New FireRetailQuery
                zCol = New FireRetailCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo And zQry.SurveyDate = zSurveyRange)

            Case ImportEnum.ImportTable.FireNatHazFloodBldgStructure
                zQry = New NatHazFloodBldgStructureDetailsQuery
                zCol = New NatHazFloodBldgStructureDetailsCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)


            Case ImportEnum.ImportTable.FireNatHazFloodExposure
                zQry = New NatHazFloodExposureDetailsQuery
                zCol = New NatHazFloodExposureDetailsCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)


            Case ImportEnum.ImportTable.FireNatHazFloodGeneral
                zQry = New NatHazFloodGeneralQuery
                zCol = New NatHazFloodGeneralCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazFloodOther
                zQry = New NatHazFloodOtherDetailsQuery
                zCol = New NatHazFloodOtherDetailsCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazSeismicGeneral
                zQry = New NatHazSeismicGeneralQuery
                zCol = New NatHazSeismicGeneralCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazSeismicNonStructural
                zQry = New NatHazSeismicNonstructuralQuery
                zCol = New NatHazSeismicNonstructuralCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazSeismicStructural
                zQry = New NatHazSeismicStructuralQuery
                zCol = New NatHazSeismicStructuralCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazSeismicStructuralData
                zQry = New NatHazSeismicStructuralDataQuery
                zCol = New NatHazSeismicStructuralDataCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazWindBuildingEnvelope
                zQry = New NatHazWindBuildingEnvelopeQuery
                zCol = New NatHazWindBuildingEnvelopeCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazWindGeneral
                zQry = New NatHazWindGeneralQuery
                zCol = New NatHazWindGeneralCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazWindOther
                zQry = New NatHazWindMiscellaneousOtherQuery
                zCol = New NatHazWindMiscellaneousOtherCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.FireNatHazWindUtility
                zQry = New NatHazWindUtilitiesQuery
                zCol = New NatHazWindUtilitiesCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmBpv
                zQry = New BmBpvQuery
                zCol = New BmBpvCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmBpvA
                zQry = New BmBpvAQuery
                zCol = New BmBpvACollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmComputerSystems
                zQry = New BmComputerSystemQuery
                zCol = New BmComputerSystemCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmCpv
                zQry = New BmCpvQuery
                zCol = New BmCpvCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmElectrical
                zQry = New BmElectricalQuery
                zCol = New BmElectricalCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmElectricalRotatingEquipment
                zQry = New BmElectricalRotatingEquipmentQuery
                zCol = New BmElectricalRotatingEquipmentCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmElectricalTransformers
                zQry = New BmElectricalTransformerQuery
                zCol = New BmElectricalTransformerCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmEppms
                zQry = New BmEppmsQuery
                zCol = New BmEppmsCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmEppmsA
                zQry = New BmEppmsAQuery
                zCol = New BmEppmsACollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmFacilityMain
                zQry = New BmMainQuery
                zCol = New BmMainCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmHebcp
                zQry = New BmHebcpQuery
                zCol = New BmHebcpCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmMechanical
                zQry = New BmMechanicalQuery
                zCol = New BmMechanicalCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmMppm
                zQry = New BmMppmQuery
                zCol = New BmMppmCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmOccupancy
                zQry = New BmOccupancyQuery
                zCol = New BmOccupancyCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmPpe
                zQry = New BmPpeQuery
                zCol = New BmPpeCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmPpeA
                zQry = New BmPpeAQuery
                zCol = New BmPpeACollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmPrimeMovers
                zQry = New BmPrimeMoverQuery
                zCol = New BmPrimeMoverCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

            Case ImportEnum.ImportTable.BmRating
                Dim zSurveyRange = _XLInfo.SurveyDate
                zQry = New BMRatingQuery
                zCol = New BMRatingCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo And zQry.InspectionDate = zSurveyRange)

            Case ImportEnum.ImportTable.FireNatHazModeling
                zQry = New CopeNatHazModelingQuery
                zCol = New CopeNatHazModelingCollection
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = _CurrentFileNo)

        End Select


        If zQry IsNot Nothing And zCol IsNot Nothing Then
            If zCol.Load(zQry) Then
                _ImportTableResult.DeleteCount += zCol.Count
                zCol.MarkAllAsDeleted()
                zCol.Save()
            End If
        End If

    End Sub

    Private Sub ValidateImportSheet()

        Dim zTemplateFileNo As Object = _XLInfo.FileNo
        Dim zSurveyDate As Object = _XLInfo.SurveyDate
        Dim zImportNoteDict As Dictionary(Of String, Object) = Nothing
        Dim zUnmatchedSurveyDate As Boolean = False
        Dim zReportArchiveDate As Object = Nothing

        'CHECKS TO SEE IF THE INSPECTION DATE MATCHES THE SAME DATE IN REPORT ARCHIVE TABLE
        If IsDate(zSurveyDate) Then
            If _ImportType = ImportEnum.ImportType.FDS Then
                zReportArchiveDate = Libraries.CoreLib.BusinessObjects.ReportArchive.GetLatestReportDate(zTemplateFileNo, UtilMetaPractice.Practices.Fire)
                If IsDate(zReportArchiveDate) Then
                    If zSurveyDate <> zReportArchiveDate Then zUnmatchedSurveyDate = True
                Else
                    zUnmatchedSurveyDate = True
                End If

            ElseIf _ImportType = ImportEnum.ImportType.BDS Then
                zReportArchiveDate = Libraries.CoreLib.BusinessObjects.ReportArchive.GetLatestReportDate(zTemplateFileNo, UtilMetaPractice.Practices.BoilerAndMachinery)
                If IsDate(zReportArchiveDate) Then
                    If zSurveyDate <> zReportArchiveDate Then zUnmatchedSurveyDate = True
                Else
                    zUnmatchedSurveyDate = True
                End If
            Else
                zReportArchiveDate = Libraries.CoreLib.BusinessObjects.ReportArchive.GetLatestReportDate(zTemplateFileNo, UtilMetaPractice.Practices.ProcessSafety)
                If IsDate(zReportArchiveDate) Then
                    If zSurveyDate <> zReportArchiveDate Then zUnmatchedSurveyDate = True
                Else
                    zUnmatchedSurveyDate = True
                End If
            End If

            If zUnmatchedSurveyDate Then
                zImportNoteDict = New Dictionary(Of String, Object)
                zImportNoteDict.Add("Survey Date", CDate(zSurveyDate).ToShortDateString)
                _ImportTableResult.ImportNote.Add(New ImportNote(ImportNote.ImportNoteType.SurveyDateNotMatchDateInRerportArchive, zImportNoteDict))
            End If

        End If


        Select Case _ImportTableResult.ImportTableInfo.ImportSheetEnum

            Case ImportEnum.ImportSheet.CopeData
                ValidateCope()

            Case ImportEnum.ImportSheet.RecTracking
                ValidateRecommendations()

            Case ImportEnum.ImportSheet.RatingForm
                ValidateRating()

            Case ImportEnum.ImportSheet.RetailData
                ValidateRetail()

            Case ImportEnum.ImportSheet.NatHazData
                ValidateNatHazData()

            Case ImportEnum.ImportSheet.NatHazModelingData
                ValidateNatHazModeling()

            Case ImportEnum.ImportSheet.FacilityData
                ValidateFacility()

        End Select


    End Sub

    Private Function ShouldFinalize(ByVal pEntityObj As Object) As Boolean

        Dim zNoteDetail As Dictionary(Of String, Object)

        Select Case _ImportTableResult.ImportTableInfo.ImportTableEnum

            Case ImportEnum.ImportTable.FireRecommendation, ImportEnum.ImportTable.BmRecommendation, ImportEnum.ImportTable.PSRecommendation
                Dim zRecs As Object = Nothing
                Dim zRecQry As Object = Nothing
                Dim zStatus As String = ""

                If _ImportType = ImportEnum.ImportType.FDS Then
                    zRecs = DirectCast(pEntityObj, BusinessObjects.FireRecommendations)
                    zRecQry = New FireRecommendationsQuery
                ElseIf _ImportType = ImportEnum.ImportType.BDS Then
                    zRecs = DirectCast(pEntityObj, BusinessObjects.BMRecommendations)
                    zRecQry = New BMRecommendationsQuery
                Else
                    zRecs = DirectCast(pEntityObj, BusinessObjects.PSRecommendations)
                    zRecQry = New PSRecommendationsQuery
                End If

                zRecQry.Select(zRecQry.RecStatus)
                zRecQry.Where(zRecQry.Link = zRecs.Link)
                zStatus = zRecQry.ExecuteScalar

                'Do not import recommendations if the database has this rec as confirm completed.
                If zStatus <> "" Then
                    If zStatus.ToLower = "conf completed" Then
                        zNoteDetail = New Dictionary(Of String, Object)
                        zNoteDetail.Add("Link", zRecs.Link)
                        _ImportTableResult.ImportNote.Add(New ImportNote(ImportNote.ImportNoteType.ConfirmCompRecsFoundInDatabase, zNoteDetail))
                        Return False
                    Else
                        Return True
                    End If
                Else
                    Return True
                End If


                'THIS SECTION CHECKS THE FACILITY DATA LIST ITEMS TO MAKE SURE WE ARE ONLY IMPORTING ROWS THAT HAVE ACTUAL DATA AND NOT BLANK ROWS.
            Case ImportEnum.ImportTable.BmBpvA
                Dim zObj As BmBpvA = DirectCast(pEntityObj, BmBpvA)
                If String.IsNullOrEmpty(zObj.Manufacturer) Then Return False

            Case ImportEnum.ImportTable.BmCpv
                Dim zObj As BmCpv = DirectCast(pEntityObj, BmCpv)
                If String.IsNullOrEmpty(zObj.PVDescription) Then Return False

            Case ImportEnum.ImportTable.BmElectricalRotatingEquipment
                Dim zObj As BmElectricalRotatingEquipment = DirectCast(pEntityObj, BmElectricalRotatingEquipment)
                If String.IsNullOrEmpty(zObj.Manfacturer) Then Return False

            Case ImportEnum.ImportTable.BmElectricalTransformers
                Dim zObj As BmElectricalTransformer = DirectCast(pEntityObj, BmElectricalTransformer)
                If String.IsNullOrEmpty(zObj.Manufacturer) Then Return False

            Case ImportEnum.ImportTable.BmPpeA
                Dim zObj As BmPpeA = DirectCast(pEntityObj, BmPpeA)
                If String.IsNullOrEmpty(zObj.PPEDescription) Then Return False

            Case ImportEnum.ImportTable.BmEppmsA
                Dim zObj As BmEppmsA = DirectCast(pEntityObj, BmEppmsA)
                If String.IsNullOrEmpty(zObj.EPPMSDescription) Then Return False

            Case ImportEnum.ImportTable.BmPrimeMovers
                Dim zObj As BmPrimeMover = DirectCast(pEntityObj, BmPrimeMover)
                If String.IsNullOrEmpty(zObj.Manufacturer) Then Return False

        End Select


        Return True

    End Function

    Private Sub SetFieldValues(ByRef pEntityObj As EntitySpaces.Core.esEntity)

        Select Case _ImportTableResult.ImportTableInfo.ImportTableEnum

            Case ImportEnum.ImportTable.FireRecommendation, ImportEnum.ImportTable.BmRecommendation, ImportEnum.ImportTable.PSRecommendation
                Dim zRecs As Object = Nothing

                If _ImportType = ImportEnum.ImportType.FDS Then
                    zRecs = DirectCast(pEntityObj, BusinessObjects.FireRecommendations)

                ElseIf _ImportType = ImportEnum.ImportType.BDS Then
                    zRecs = DirectCast(pEntityObj, BusinessObjects.BMRecommendations)

                Else
                    zRecs = DirectCast(pEntityObj, BusinessObjects.PSRecommendations)

                End If

                zRecs.Link = CreateRecLink(zRecs.FileNo, zRecs.RecYear, zRecs.RecMonth, zRecs.RecNumber, zRecs.RecSubletter)

              
                If Not IsNumeric(zRecs.LossExpectancyBefore) Then
                    zRecs.LossExpectancyBeforeActual = 0
                    zRecs.LossExpectancyBefore = GetLossEstimateRange(CStr(zRecs.LossExpectancyBefore), UtilLossExpectancy.LeType.Before)
                Else
                    zRecs.LossExpectancyBeforeActual = zRecs.LossExpectancyBefore
                    zRecs.LossExpectancyBefore = GetLossEstimateRange(Convert.ToInt64(zRecs.LossExpectancyBeforeActual), UtilLossExpectancy.LeType.Before)
                End If

                If Not IsNumeric(zRecs.LossExpectancyAfter) Then
                    zRecs.LossExpectancyAfterActual = 0
                    zRecs.LossExpectancyAfter = GetLossEstimateRange(CStr(zRecs.LossExpectancyAfter), UtilLossExpectancy.LeType.After)
                Else
                    zRecs.LossExpectancyAfterActual = zRecs.LossExpectancyAfter
                    zRecs.LossExpectancyAfter = GetLossEstimateRange(Convert.ToInt64(zRecs.LossExpectancyAfterActual), UtilLossExpectancy.LeType.After)
                End If

                If Not IsNumeric(zRecs.CostToComplete) Then
                    zRecs.CostToCompleteActual = 0
                    zRecs.CostToComplete = GetLossEstimateRange(CStr(zRecs.CostToComplete), UtilLossExpectancy.LeType.Cost)
                Else
                    zRecs.CostToCompleteActual = zRecs.CostToComplete
                    zRecs.CostToComplete = GetLossEstimateRange(CInt(zRecs.CostToCompleteActual), UtilLossExpectancy.LeType.Cost)
                End If

                If zRecs.RecStatus IsNot Nothing Then

                    Dim updateId As Boolean = False

                    If zRecs.RecStatus.ToLower = "conf completed" Then
                        updateId = True
                        zRecs.IntendedAction = "Completed"
                    End If

                    If zRecs.RecStatus.ToLower = "in progress" Then
                        updateId = True
                        zRecs.IntendedAction = "In Progress"
                    End If

                    If updateId Then zRecs.IntendedActionId = RecMeta.GetIntendedActionId(zRecs.RecYear, zRecs.RecNumber, zRecs.IntendedAction, _ImportTableResult)

                End If

                'This block of code fills the import and origination dates.
                zRecs.OriginationDate = zRecs.StatusDate
                zRecs.Importdate = Now.ToString
                zRecs.Importorigdate = zRecs.Importdate
                zRecs.FilePrefix = _CurrentFilePrefix

                'This block of code checks the ExpectedCompletionDate to make sure that NULL is being imported only if the value is 1/1/1900.
                If IsDate(zRecs.ExpectedCompletionDate) Then
                    If zRecs.ExpectedCompletionDate = "1/1/1900" Then
                        zRecs.ExpectedCompletionDate = Nothing
                    End If
                Else
                    zRecs.ExpectedCompletionDate = Nothing
                End If



            Case ImportEnum.ImportTable.FireRating, ImportEnum.ImportTable.BmRating

                Dim zRatingKey As New TblMetaRatingKey
                Dim zRatingKeyId As Integer = 0
                Dim zClientQry As New ClientsQuery
                Dim zFireRating As BusinessObjects.Rating = Nothing
                Dim zBmRating As BusinessObjects.BMRating = Nothing
                Dim zTotalScoreRating As String = ""
                Dim zTotalScoreRatingWithRecs As String = ""
                Dim zMaxPossibleScore As String = ""

                zClientQry.Select(zClientQry.FireRatingKeyID)
                zClientQry.Where(zClientQry.Fileprefix = _CurrentFilePrefix)
                zRatingKeyId = zClientQry.ExecuteScalar()

                If _ImportType = ImportEnum.ImportType.FDS Then
                    zFireRating = DirectCast(pEntityObj, BusinessObjects.Rating)
                    If zRatingKey.LoadByPrimaryKey(zRatingKeyId) Then
                        'Get Maximum Possible Score Rating
                        zFireRating.MaxPossibleRating = GetRating(zRatingKey, zFireRating.MaxPossibleScore)
                        zFireRating.OverallScoreWithRecsCompleteRating = GetRating(zRatingKey, zFireRating.OverallScoreWithRecsComplete)
                        zFireRating.TotalScoreRating = GetRating(zRatingKey, zFireRating.TotalScore)
                    Else
                        Throw New ImportException("Could not load RatingKeyId: " & zRatingKeyId & " from the RatingKey table.  Please check that there is a valid rating key Id in the clients table.")
                    End If
                Else
                    zBmRating = DirectCast(pEntityObj, BusinessObjects.BMRating)
                    If zRatingKey.LoadByPrimaryKey(zRatingKeyId) Then
                        zBmRating.OverallPlantRatingRating = GetRating(zRatingKey, zBmRating.TotalScoreCurrent)
                        zBmRating.TotalWRCompleteRating = GetRating(zRatingKey, zBmRating.TotalWRComplete)
                    Else
                        Throw New ImportException("Could not load RatingKeyId: " & zRatingKeyId & " from the RatingKey table.  Please check that there is a valid rating key Id in the clients table.")
                    End If

                End If


            Case ImportEnum.ImportTable.BmBpv, ImportEnum.ImportTable.BmBpvA, ImportEnum.ImportTable.BmComputerSystems, ImportEnum.ImportTable.BmCpv, ImportEnum.ImportTable.BmElectrical, ImportEnum.ImportTable.BmElectricalRotatingEquipment, ImportEnum.ImportTable.BmElectricalTransformers, ImportEnum.ImportTable.BmEppms, ImportEnum.ImportTable.BmEppmsA, ImportEnum.ImportTable.BmFacilityMain, ImportEnum.ImportTable.BmHebcp, ImportEnum.ImportTable.BmMechanical, ImportEnum.ImportTable.BmMppm, ImportEnum.ImportTable.BmOccupancy, ImportEnum.ImportTable.BmPpe, ImportEnum.ImportTable.BmPpeA, ImportEnum.ImportTable.BmPrimeMovers
                Try
                    Dim zEntType As System.Type = pEntityObj.GetType
                    Dim zFilePrefixProp As Reflection.PropertyInfo = zEntType.GetProperty("FilePrefix")
                    zFilePrefixProp.SetValue(pEntityObj, Convert.ToInt16(_CurrentFilePrefix), Nothing)
                Catch ex As Exception
                    Stop
                End Try


            Case ImportEnum.ImportTable.FireNatHazModeling
                Dim zEntType As CopeNatHazModeling = DirectCast(pEntityObj, CopeNatHazModeling)
                Dim zSurveyDate As Object = _XLInfo.SurveyDate
                zEntType.Fileno = _CurrentFileNo
                zEntType.Inspdate = zSurveyDate

        End Select


    End Sub

    Private Sub UpdateMedianValues()
        Dim zCon As New SqlClient.SqlConnection(UtilDB.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("spSetFireRecommendationsLossEstimateMedians", zCon)
        zCmd.CommandType = CommandType.StoredProcedure
        zCmd.CommandTimeout = 120
        zCmd.Parameters.AddWithValue("@FileNo", _CurrentFileNo)
        zCmd.Connection.Open()

        Using zCmd.Connection
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Function GetRating(ByVal pRatingKey As TblMetaRatingKey, ByVal pScore As Double) As String
        Dim zKeyRangeQry As New TblMetaRatingKeyRangeQuery
        zKeyRangeQry.Select(zKeyRangeQry.FldRating)
        zKeyRangeQry.Where(zKeyRangeQry.FldKeyId = pRatingKey.FldId)
        zKeyRangeQry.Where(zKeyRangeQry.FldScoreLow <= pScore And zKeyRangeQry.FldScoreHigh >= pScore)

        Dim zKeyRangecol As New TblMetaRatingKeyRangeCollection

        If zKeyRangecol.Load(zKeyRangeQry) Then
            If zKeyRangecol.Count = 1 Then
                Return zKeyRangecol(0).FldRating
            End If
        End If


        'With pRatingKey
        '    If .ScoreLow1 <= pScore And pScore <= .ScoreHigh1 Then Return .Rating1
        '    If .ScoreLow2 <= pScore And pScore <= .ScoreHigh2 Then Return .Rating2
        '    If .ScoreLow3 <= pScore And pScore <= .ScoreHigh3 Then Return .Rating3
        '    If .ScoreLow4 <= pScore And pScore <= .ScoreHigh4 Then Return .Rating4
        '    If .ScoreLow5 <= pScore And pScore <= .ScoreHigh5 Then Return .Rating5
        'End With


        Return "Error"

    End Function

    Private Function GetCurrentFilePrefix(ByVal pGuid As String) As String
        Return UtilGSafe.GetValue(pGuid, "FilePrefix")
    End Function

    Private Function GetCurrentFileNo(ByVal pGuid As String) As String
        Return UtilGSafe.GetValue(pGuid, "FileNo")
    End Function

    Private Function GetSpecialFeatures(ByVal pGuid As String) As Char()
        Return UtilGSafe.GetValue(pGuid, "clientFeatures").ToCharArray
    End Function

    Private Function GetCurrentPractice(ByVal pGuid As String) As UtilPractice.PracticeEnum

        Dim zPractice As String = UtilGSafe.GetValue(pGuid, "practiceName").ToString
        If InStr(zPractice.ToLower, "fire") > 0 Then Return UtilPractice.PracticeEnum.Fire
        If InStr(zPractice.ToLower, "boiler") > 0 Then Return UtilPractice.PracticeEnum.BM
        If InStr(zPractice.ToLower, "infrared") > 0 Then Return UtilPractice.PracticeEnum.Infrared
        If InStr(zPractice.ToLower, "juris") > 0 Then Return UtilPractice.PracticeEnum.Jurisdictional
        If InStr(zPractice.ToLower, "wind") > 0 Then Return UtilPractice.PracticeEnum.NatHazWind
        If InStr(zPractice.ToLower, "seismic") > 0 Then Return UtilPractice.PracticeEnum.NatHazSeismic
        If InStr(zPractice.ToLower, "flood") > 0 Then Return UtilPractice.PracticeEnum.NatHazFlood
        If InStr(zPractice.ToLower, "natural") > 0 Then Return UtilPractice.PracticeEnum.NaturalHazards
        If InStr(zPractice.ToLower, "process") > 0 Then Return UtilPractice.PracticeEnum.ProcessSafety


        Throw New ImportException("Could not get practiceName using guid: " & pGuid & ".")

    End Function

    Private Sub ValidateTemplateVersion()
        Dim zRequiredVersion As Double = CDbl(UtilSetting.GetValue(UtilSetting.Keys.ImportTemplateVersion, False))
        If _XLInfo.TemplateVersion < zRequiredVersion Then
            Throw New ImportException("Template is incorrect version. Must be version " & UtilSetting.GetValue(UtilSetting.Keys.ImportTemplateVersion, False).ToString & " or greater. Please update to latest version and try again.")
        End If
    End Sub

    Private Function GetLossEstimateRange(ByVal pLossEstimateValue As Object, ByVal pLossEstimatetype As UtilLossExpectancy.LeType) As String
        Return UtilLossExpectancy.GetRangeText(_CurrentFilePrefix, pLossEstimateValue, pLossEstimatetype)
    End Function



    Private Sub CreateFileString(ByVal s As String)
        _FileString = _FileString & s
    End Sub

End Class


