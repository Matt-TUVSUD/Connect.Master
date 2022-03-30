

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwWhatIfFireRecGrid
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colRecID As New razor.UtilSQLServer.IntegerDataColumn
        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colClient As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colAddress As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colZip As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colLatitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colLongitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colTivus As New razor.UtilSQLServer.DoubleDataColumn
        Public colStProvName As New razor.UtilSQLServer.StringDataColumn
        Public colRecUniqueID As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecYear As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecMonth As New razor.UtilSQLServer.StringDataColumn
        Public colRecNumber As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecSubletter As New razor.UtilSQLServer.StringDataColumn
        Public colRecNo As New razor.UtilSQLServer.StringDataColumn
        Public colRecCategory As New razor.UtilSQLServer.StringDataColumn
        Public colRecCategorySortOrder As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecStatus As New razor.UtilSQLServer.StringDataColumn
        Public colStatusDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRecCode As New razor.UtilSQLServer.StringDataColumn
        Public colPrimaryRecType As New razor.UtilSQLServer.StringDataColumn
        Public colSecondaryRecType As New razor.UtilSQLServer.StringDataColumn
        Public colRecKeyWords As New razor.UtilSQLServer.StringDataColumn
        Public colLossExpectancyBefore As New razor.UtilSQLServer.StringDataColumn
        Public colLossExpectancyAfter As New razor.UtilSQLServer.StringDataColumn
        Public colCostToComplete As New razor.UtilSQLServer.StringDataColumn
        Public colSavingsRatio As New razor.UtilSQLServer.DoubleDataColumn
        Public colPlantComment As New razor.UtilSQLServer.StringDataColumn
        Public colExpectedCompletionDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colIntendedAction As New razor.UtilSQLServer.StringDataColumn
        Public colLossExpectancyBeforeActual As New razor.UtilSQLServer.IntegerDataColumn
        Public colLossExpectancyAfterActual As New razor.UtilSQLServer.IntegerDataColumn
        Public colCostToCompleteActual As New razor.UtilSQLServer.IntegerDataColumn
        Public colActualCostToComplete As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecPriority As New razor.UtilSQLServer.IntegerDataColumn
        Public colRatingCatWeight As New razor.UtilSQLServer.DecimalDataColumn
        Public colRatingCat As New razor.UtilSQLServer.StringDataColumn
        Public colRatingPts As New razor.UtilSQLServer.DecimalDataColumn
        Public colRatingScoreChange As New razor.UtilSQLServer.DecimalDataColumn
        Public colRatingCatPts As New razor.UtilSQLServer.StringDataColumn
        Public colRecCategoryColor As New razor.UtilSQLServer.StringDataColumn
        Public colExpectedCompletionDateColor As New razor.UtilSQLServer.StringDataColumn
        Public colRecCategoryForeColor As New razor.UtilSQLServer.StringDataColumn
        Public colLossExpectancyBeforeMedian As New razor.UtilSQLServer.IntegerDataColumn
        Public colLossExpectancyAfterMedian As New razor.UtilSQLServer.IntegerDataColumn
        Public colCostToCompleteMedian As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldAddressStamp As New razor.UtilSQLServer.StringDataColumn
        Public colLocationRatingFormViewLink As New razor.UtilSQLServer.StringDataColumn
        Public colLocationRatingReportLink As New razor.UtilSQLServer.StringDataColumn
        Public colWiIsSelected As New razor.UtilSQLServer.BooleanDataColumn
        Public colWiRecStatus As New razor.UtilSQLServer.StringDataColumn
        Public colLossExpectancyBeforeSortValue As New razor.UtilSQLServer.IntegerDataColumn
        Public colCostToCompleteSortValue As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colFldClientLocID As New razor.UtilSQLServer.StringDataColumn
        Public colFldDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFldCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colFldFacility As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colRecID.ColumnName = "[RecID]"
            colGSafeId.ColumnName = "[GSafeId]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colFileNo.ColumnName = "[FileNo]"
            colClient.ColumnName = "[Client]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colDivision.ColumnName = "[Division]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colFacility.ColumnName = "[Facility]"
            colAddress.ColumnName = "[Address]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colZip.ColumnName = "[Zip]"
            colCountry.ColumnName = "[Country]"
            colLatitude.ColumnName = "[Latitude]"
            colLongitude.ColumnName = "[Longitude]"
            colTivus.ColumnName = "[TIVUS]"
            colStProvName.ColumnName = "[StProvName]"
            colRecUniqueID.ColumnName = "[RecUniqueID]"
            colRecYear.ColumnName = "[RecYear]"
            colRecMonth.ColumnName = "[RecMonth]"
            colRecNumber.ColumnName = "[RecNumber]"
            colRecSubletter.ColumnName = "[RecSubletter]"
            colRecNo.ColumnName = "[RecNo]"
            colRecCategory.ColumnName = "[RecCategory]"
            colRecCategorySortOrder.ColumnName = "[RecCategorySortOrder]"
            colRecStatus.ColumnName = "[RecStatus]"
            colStatusDate.ColumnName = "[StatusDate]"
            colRecCode.ColumnName = "[RecCode]"
            colPrimaryRecType.ColumnName = "[PrimaryRecType]"
            colSecondaryRecType.ColumnName = "[SecondaryRecType]"
            colRecKeyWords.ColumnName = "[RecKeyWords]"
            colLossExpectancyBefore.ColumnName = "[LossExpectancyBefore]"
            colLossExpectancyAfter.ColumnName = "[LossExpectancyAfter]"
            colCostToComplete.ColumnName = "[CostToComplete]"
            colSavingsRatio.ColumnName = "[SavingsRatio]"
            colPlantComment.ColumnName = "[PlantComment]"
            colExpectedCompletionDate.ColumnName = "[ExpectedCompletionDate]"
            colIntendedAction.ColumnName = "[IntendedAction]"
            colLossExpectancyBeforeActual.ColumnName = "[LossExpectancyBeforeActual]"
            colLossExpectancyAfterActual.ColumnName = "[LossExpectancyAfterActual]"
            colCostToCompleteActual.ColumnName = "[CostToCompleteActual]"
            colActualCostToComplete.ColumnName = "[ActualCostToComplete]"
            colRecPriority.ColumnName = "[RecPriority]"
            colRatingCatWeight.ColumnName = "[RatingCatWeight]"
            colRatingCat.ColumnName = "[RatingCat]"
            colRatingPts.ColumnName = "[RatingPts]"
            colRatingScoreChange.ColumnName = "[RatingScoreChange]"
            colRatingCatPts.ColumnName = "[RatingCatPts]"
            colRecCategoryColor.ColumnName = "[RecCategoryColor]"
            colExpectedCompletionDateColor.ColumnName = "[ExpectedCompletionDateColor]"
            colRecCategoryForeColor.ColumnName = "[RecCategoryForeColor]"
            colLossExpectancyBeforeMedian.ColumnName = "[LossExpectancyBeforeMedian]"
            colLossExpectancyAfterMedian.ColumnName = "[LossExpectancyAfterMedian]"
            colCostToCompleteMedian.ColumnName = "[CostToCompleteMedian]"
            colFldAddressStamp.ColumnName = "[fldAddressStamp]"
            colLocationRatingFormViewLink.ColumnName = "[LocationRatingFormViewLink]"
            colLocationRatingReportLink.ColumnName = "[LocationRatingReportLink]"
            colWiIsSelected.ColumnName = "[WiIsSelected]"
            colWiRecStatus.ColumnName = "[WiRecStatus]"
            colLossExpectancyBeforeSortValue.ColumnName = "[LossExpectancyBeforeSortValue]"
            colCostToCompleteSortValue.ColumnName = "[CostToCompleteSortValue]"
            colFldFileNo.ColumnName = "[fldFileNo]"
            colFldClientLocID.ColumnName = "[fldClientLocID]"
            colFldDivision.ColumnName = "[fldDivision]"
            colFldCustomAccess.ColumnName = "[fldCustomAccess]"
            colFldFacility.ColumnName = "[fldFacility]"

            _Members.Add("colRecID", colRecID)
            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colClient", colClient)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colAddress", colAddress)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colZip", colZip)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colLatitude", colLatitude)
            _Members.Add("colLongitude", colLongitude)
            _Members.Add("colTivus", colTivus)
            _Members.Add("colStProvName", colStProvName)
            _Members.Add("colRecUniqueID", colRecUniqueID)
            _Members.Add("colRecYear", colRecYear)
            _Members.Add("colRecMonth", colRecMonth)
            _Members.Add("colRecNumber", colRecNumber)
            _Members.Add("colRecSubletter", colRecSubletter)
            _Members.Add("colRecNo", colRecNo)
            _Members.Add("colRecCategory", colRecCategory)
            _Members.Add("colRecCategorySortOrder", colRecCategorySortOrder)
            _Members.Add("colRecStatus", colRecStatus)
            _Members.Add("colStatusDate", colStatusDate)
            _Members.Add("colRecCode", colRecCode)
            _Members.Add("colPrimaryRecType", colPrimaryRecType)
            _Members.Add("colSecondaryRecType", colSecondaryRecType)
            _Members.Add("colRecKeyWords", colRecKeyWords)
            _Members.Add("colLossExpectancyBefore", colLossExpectancyBefore)
            _Members.Add("colLossExpectancyAfter", colLossExpectancyAfter)
            _Members.Add("colCostToComplete", colCostToComplete)
            _Members.Add("colSavingsRatio", colSavingsRatio)
            _Members.Add("colPlantComment", colPlantComment)
            _Members.Add("colExpectedCompletionDate", colExpectedCompletionDate)
            _Members.Add("colIntendedAction", colIntendedAction)
            _Members.Add("colLossExpectancyBeforeActual", colLossExpectancyBeforeActual)
            _Members.Add("colLossExpectancyAfterActual", colLossExpectancyAfterActual)
            _Members.Add("colCostToCompleteActual", colCostToCompleteActual)
            _Members.Add("colActualCostToComplete", colActualCostToComplete)
            _Members.Add("colRecPriority", colRecPriority)
            _Members.Add("colRatingCatWeight", colRatingCatWeight)
            _Members.Add("colRatingCat", colRatingCat)
            _Members.Add("colRatingPts", colRatingPts)
            _Members.Add("colRatingScoreChange", colRatingScoreChange)
            _Members.Add("colRatingCatPts", colRatingCatPts)
            _Members.Add("colRecCategoryColor", colRecCategoryColor)
            _Members.Add("colExpectedCompletionDateColor", colExpectedCompletionDateColor)
            _Members.Add("colRecCategoryForeColor", colRecCategoryForeColor)
            _Members.Add("colLossExpectancyBeforeMedian", colLossExpectancyBeforeMedian)
            _Members.Add("colLossExpectancyAfterMedian", colLossExpectancyAfterMedian)
            _Members.Add("colCostToCompleteMedian", colCostToCompleteMedian)
            _Members.Add("colFldAddressStamp", colFldAddressStamp)
            _Members.Add("colLocationRatingFormViewLink", colLocationRatingFormViewLink)
            _Members.Add("colLocationRatingReportLink", colLocationRatingReportLink)
            _Members.Add("colWiIsSelected", colWiIsSelected)
            _Members.Add("colWiRecStatus", colWiRecStatus)
            _Members.Add("colLossExpectancyBeforeSortValue", colLossExpectancyBeforeSortValue)
            _Members.Add("colCostToCompleteSortValue", colCostToCompleteSortValue)
            _Members.Add("colFldFileNo", colFldFileNo)
            _Members.Add("colFldClientLocID", colFldClientLocID)
            _Members.Add("colFldDivision", colFldDivision)
            _Members.Add("colFldCustomAccess", colFldCustomAccess)
            _Members.Add("colFldFacility", colFldFacility)
        End Sub

        Public Function Member(pObjectName As String) As Object
            Dim zReturn As Object = Nothing
            If _Members.ContainsKey(pObjectName) Then
                zReturn = _Members.Item(pObjectName)
            Else
                Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in member dictionary.")
            End If
            Return zReturn
        End Function

        Public Function MemberColumn(pObjectName As String) As String
            Select Case pObjectName
                Case "colRecID"
                    Return "[RecID]"
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colClient"
                    Return "[Client]"
                Case "colClientLocNo"
                    Return "[ClientLocNo]"
                Case "colDivision"
                    Return "[Division]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colFacility"
                    Return "[Facility]"
                Case "colAddress"
                    Return "[Address]"
                Case "colCity"
                    Return "[City]"
                Case "colStProv"
                    Return "[StProv]"
                Case "colZip"
                    Return "[Zip]"
                Case "colCountry"
                    Return "[Country]"
                Case "colLatitude"
                    Return "[Latitude]"
                Case "colLongitude"
                    Return "[Longitude]"
                Case "colTivus"
                    Return "[TIVUS]"
                Case "colStProvName"
                    Return "[StProvName]"
                Case "colRecUniqueID"
                    Return "[RecUniqueID]"
                Case "colRecYear"
                    Return "[RecYear]"
                Case "colRecMonth"
                    Return "[RecMonth]"
                Case "colRecNumber"
                    Return "[RecNumber]"
                Case "colRecSubletter"
                    Return "[RecSubletter]"
                Case "colRecNo"
                    Return "[RecNo]"
                Case "colRecCategory"
                    Return "[RecCategory]"
                Case "colRecCategorySortOrder"
                    Return "[RecCategorySortOrder]"
                Case "colRecStatus"
                    Return "[RecStatus]"
                Case "colStatusDate"
                    Return "[StatusDate]"
                Case "colRecCode"
                    Return "[RecCode]"
                Case "colPrimaryRecType"
                    Return "[PrimaryRecType]"
                Case "colSecondaryRecType"
                    Return "[SecondaryRecType]"
                Case "colRecKeyWords"
                    Return "[RecKeyWords]"
                Case "colLossExpectancyBefore"
                    Return "[LossExpectancyBefore]"
                Case "colLossExpectancyAfter"
                    Return "[LossExpectancyAfter]"
                Case "colCostToComplete"
                    Return "[CostToComplete]"
                Case "colSavingsRatio"
                    Return "[SavingsRatio]"
                Case "colPlantComment"
                    Return "[PlantComment]"
                Case "colExpectedCompletionDate"
                    Return "[ExpectedCompletionDate]"
                Case "colIntendedAction"
                    Return "[IntendedAction]"
                Case "colLossExpectancyBeforeActual"
                    Return "[LossExpectancyBeforeActual]"
                Case "colLossExpectancyAfterActual"
                    Return "[LossExpectancyAfterActual]"
                Case "colCostToCompleteActual"
                    Return "[CostToCompleteActual]"
                Case "colActualCostToComplete"
                    Return "[ActualCostToComplete]"
                Case "colRecPriority"
                    Return "[RecPriority]"
                Case "colRatingCatWeight"
                    Return "[RatingCatWeight]"
                Case "colRatingCat"
                    Return "[RatingCat]"
                Case "colRatingPts"
                    Return "[RatingPts]"
                Case "colRatingScoreChange"
                    Return "[RatingScoreChange]"
                Case "colRatingCatPts"
                    Return "[RatingCatPts]"
                Case "colRecCategoryColor"
                    Return "[RecCategoryColor]"
                Case "colExpectedCompletionDateColor"
                    Return "[ExpectedCompletionDateColor]"
                Case "colRecCategoryForeColor"
                    Return "[RecCategoryForeColor]"
                Case "colLossExpectancyBeforeMedian"
                    Return "[LossExpectancyBeforeMedian]"
                Case "colLossExpectancyAfterMedian"
                    Return "[LossExpectancyAfterMedian]"
                Case "colCostToCompleteMedian"
                    Return "[CostToCompleteMedian]"
                Case "colFldAddressStamp"
                    Return "[fldAddressStamp]"
                Case "colLocationRatingFormViewLink"
                    Return "[LocationRatingFormViewLink]"
                Case "colLocationRatingReportLink"
                    Return "[LocationRatingReportLink]"
                Case "colWiIsSelected"
                    Return "[WiIsSelected]"
                Case "colWiRecStatus"
                    Return "[WiRecStatus]"
                Case "colLossExpectancyBeforeSortValue"
                    Return "[LossExpectancyBeforeSortValue]"
                Case "colCostToCompleteSortValue"
                    Return "[CostToCompleteSortValue]"
                Case "colFldFileNo"
                    Return "[fldFileNo]"
                Case "colFldClientLocID"
                    Return "[fldClientLocID]"
                Case "colFldDivision"
                    Return "[fldDivision]"
                Case "colFldCustomAccess"
                    Return "[fldCustomAccess]"
                Case "colFldFacility"
                    Return "[fldFacility]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[RecID]", "RecID", "RecID", "colRecID"  
                    Return "colRecID"
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[Client]", "Client", "Client", "colClient"  
                    Return "colClient"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "colClientLocNo"  
                    Return "colClientLocNo"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[Facility]", "Facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case "[Address]", "Address", "Address", "colAddress"  
                    Return "colAddress"
                Case "[City]", "City", "City", "colCity"  
                    Return "colCity"
                Case "[StProv]", "StProv", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[Zip]", "Zip", "Zip", "colZip"  
                    Return "colZip"
                Case "[Country]", "Country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[Latitude]", "Latitude", "Latitude", "colLatitude"  
                    Return "colLatitude"
                Case "[Longitude]", "Longitude", "Longitude", "colLongitude"  
                    Return "colLongitude"
                Case "[TIVUS]", "TIVUS", "Tivus", "colTivus"  
                    Return "colTivus"
                Case "[StProvName]", "StProvName", "StProvName", "colStProvName"  
                    Return "colStProvName"
                Case "[RecUniqueID]", "RecUniqueID", "RecUniqueID", "colRecUniqueID"  
                    Return "colRecUniqueID"
                Case "[RecYear]", "RecYear", "RecYear", "colRecYear"  
                    Return "colRecYear"
                Case "[RecMonth]", "RecMonth", "RecMonth", "colRecMonth"  
                    Return "colRecMonth"
                Case "[RecNumber]", "RecNumber", "RecNumber", "colRecNumber"  
                    Return "colRecNumber"
                Case "[RecSubletter]", "RecSubletter", "RecSubletter", "colRecSubletter"  
                    Return "colRecSubletter"
                Case "[RecNo]", "RecNo", "RecNo", "colRecNo"  
                    Return "colRecNo"
                Case "[RecCategory]", "RecCategory", "RecCategory", "colRecCategory"  
                    Return "colRecCategory"
                Case "[RecCategorySortOrder]", "RecCategorySortOrder", "RecCategorySortOrder", "colRecCategorySortOrder"  
                    Return "colRecCategorySortOrder"
                Case "[RecStatus]", "RecStatus", "RecStatus", "colRecStatus"  
                    Return "colRecStatus"
                Case "[StatusDate]", "StatusDate", "StatusDate", "colStatusDate"  
                    Return "colStatusDate"
                Case "[RecCode]", "RecCode", "RecCode", "colRecCode"  
                    Return "colRecCode"
                Case "[PrimaryRecType]", "PrimaryRecType", "PrimaryRecType", "colPrimaryRecType"  
                    Return "colPrimaryRecType"
                Case "[SecondaryRecType]", "SecondaryRecType", "SecondaryRecType", "colSecondaryRecType"  
                    Return "colSecondaryRecType"
                Case "[RecKeyWords]", "RecKeyWords", "RecKeyWords", "colRecKeyWords"  
                    Return "colRecKeyWords"
                Case "[LossExpectancyBefore]", "LossExpectancyBefore", "LossExpectancyBefore", "colLossExpectancyBefore"  
                    Return "colLossExpectancyBefore"
                Case "[LossExpectancyAfter]", "LossExpectancyAfter", "LossExpectancyAfter", "colLossExpectancyAfter"  
                    Return "colLossExpectancyAfter"
                Case "[CostToComplete]", "CostToComplete", "CostToComplete", "colCostToComplete"  
                    Return "colCostToComplete"
                Case "[SavingsRatio]", "SavingsRatio", "SavingsRatio", "colSavingsRatio"  
                    Return "colSavingsRatio"
                Case "[PlantComment]", "PlantComment", "PlantComment", "colPlantComment"  
                    Return "colPlantComment"
                Case "[ExpectedCompletionDate]", "ExpectedCompletionDate", "ExpectedCompletionDate", "colExpectedCompletionDate"  
                    Return "colExpectedCompletionDate"
                Case "[IntendedAction]", "IntendedAction", "IntendedAction", "colIntendedAction"  
                    Return "colIntendedAction"
                Case "[LossExpectancyBeforeActual]", "LossExpectancyBeforeActual", "LossExpectancyBeforeActual", "colLossExpectancyBeforeActual"  
                    Return "colLossExpectancyBeforeActual"
                Case "[LossExpectancyAfterActual]", "LossExpectancyAfterActual", "LossExpectancyAfterActual", "colLossExpectancyAfterActual"  
                    Return "colLossExpectancyAfterActual"
                Case "[CostToCompleteActual]", "CostToCompleteActual", "CostToCompleteActual", "colCostToCompleteActual"  
                    Return "colCostToCompleteActual"
                Case "[ActualCostToComplete]", "ActualCostToComplete", "ActualCostToComplete", "colActualCostToComplete"  
                    Return "colActualCostToComplete"
                Case "[RecPriority]", "RecPriority", "RecPriority", "colRecPriority"  
                    Return "colRecPriority"
                Case "[RatingCatWeight]", "RatingCatWeight", "RatingCatWeight", "colRatingCatWeight"  
                    Return "colRatingCatWeight"
                Case "[RatingCat]", "RatingCat", "RatingCat", "colRatingCat"  
                    Return "colRatingCat"
                Case "[RatingPts]", "RatingPts", "RatingPts", "colRatingPts"  
                    Return "colRatingPts"
                Case "[RatingScoreChange]", "RatingScoreChange", "RatingScoreChange", "colRatingScoreChange"  
                    Return "colRatingScoreChange"
                Case "[RatingCatPts]", "RatingCatPts", "RatingCatPts", "colRatingCatPts"  
                    Return "colRatingCatPts"
                Case "[RecCategoryColor]", "RecCategoryColor", "RecCategoryColor", "colRecCategoryColor"  
                    Return "colRecCategoryColor"
                Case "[ExpectedCompletionDateColor]", "ExpectedCompletionDateColor", "ExpectedCompletionDateColor", "colExpectedCompletionDateColor"  
                    Return "colExpectedCompletionDateColor"
                Case "[RecCategoryForeColor]", "RecCategoryForeColor", "RecCategoryForeColor", "colRecCategoryForeColor"  
                    Return "colRecCategoryForeColor"
                Case "[LossExpectancyBeforeMedian]", "LossExpectancyBeforeMedian", "LossExpectancyBeforeMedian", "colLossExpectancyBeforeMedian"  
                    Return "colLossExpectancyBeforeMedian"
                Case "[LossExpectancyAfterMedian]", "LossExpectancyAfterMedian", "LossExpectancyAfterMedian", "colLossExpectancyAfterMedian"  
                    Return "colLossExpectancyAfterMedian"
                Case "[CostToCompleteMedian]", "CostToCompleteMedian", "CostToCompleteMedian", "colCostToCompleteMedian"  
                    Return "colCostToCompleteMedian"
                Case "[fldAddressStamp]", "fldAddressStamp", "FldAddressStamp", "colFldAddressStamp"  
                    Return "colFldAddressStamp"
                Case "[LocationRatingFormViewLink]", "LocationRatingFormViewLink", "LocationRatingFormViewLink", "colLocationRatingFormViewLink"  
                    Return "colLocationRatingFormViewLink"
                Case "[LocationRatingReportLink]", "LocationRatingReportLink", "LocationRatingReportLink", "colLocationRatingReportLink"  
                    Return "colLocationRatingReportLink"
                Case "[WiIsSelected]", "WiIsSelected", "WiIsSelected", "colWiIsSelected"  
                    Return "colWiIsSelected"
                Case "[WiRecStatus]", "WiRecStatus", "WiRecStatus", "colWiRecStatus"  
                    Return "colWiRecStatus"
                Case "[LossExpectancyBeforeSortValue]", "LossExpectancyBeforeSortValue", "LossExpectancyBeforeSortValue", "colLossExpectancyBeforeSortValue"  
                    Return "colLossExpectancyBeforeSortValue"
                Case "[CostToCompleteSortValue]", "CostToCompleteSortValue", "CostToCompleteSortValue", "colCostToCompleteSortValue"  
                    Return "colCostToCompleteSortValue"
                Case "[fldFileNo]", "fldFileNo", "FldFileNo", "colFldFileNo"  
                    Return "colFldFileNo"
                Case "[fldClientLocID]", "fldClientLocID", "FldClientLocID", "colFldClientLocID"  
                    Return "colFldClientLocID"
                Case "[fldDivision]", "fldDivision", "FldDivision", "colFldDivision"  
                    Return "colFldDivision"
                Case "[fldCustomAccess]", "fldCustomAccess", "FldCustomAccess", "colFldCustomAccess"  
                    Return "colFldCustomAccess"
                Case "[fldFacility]", "fldFacility", "FldFacility", "colFldFacility"  
                    Return "colFldFacility"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colRecID"
                    Return "Integer"
                Case "colGSafeId"
                    Return "Integer"
                Case "colFilePrefix"
                    Return "String"
                Case "colFileNo"
                    Return "String"
                Case "colClient"
                    Return "String"
                Case "colClientLocNo"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colCustomAccess"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case "colAddress"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colZip"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colLatitude"
                    Return "Decimal"
                Case "colLongitude"
                    Return "Decimal"
                Case "colTivus"
                    Return "Double"
                Case "colStProvName"
                    Return "String"
                Case "colRecUniqueID"
                    Return "Integer"
                Case "colRecYear"
                    Return "Integer"
                Case "colRecMonth"
                    Return "String"
                Case "colRecNumber"
                    Return "Integer"
                Case "colRecSubletter"
                    Return "String"
                Case "colRecNo"
                    Return "String"
                Case "colRecCategory"
                    Return "String"
                Case "colRecCategorySortOrder"
                    Return "Integer"
                Case "colRecStatus"
                    Return "String"
                Case "colStatusDate"
                    Return "DateTime"
                Case "colRecCode"
                    Return "String"
                Case "colPrimaryRecType"
                    Return "String"
                Case "colSecondaryRecType"
                    Return "String"
                Case "colRecKeyWords"
                    Return "String"
                Case "colLossExpectancyBefore"
                    Return "String"
                Case "colLossExpectancyAfter"
                    Return "String"
                Case "colCostToComplete"
                    Return "String"
                Case "colSavingsRatio"
                    Return "Double"
                Case "colPlantComment"
                    Return "String"
                Case "colExpectedCompletionDate"
                    Return "DateTime"
                Case "colIntendedAction"
                    Return "String"
                Case "colLossExpectancyBeforeActual"
                    Return "Integer"
                Case "colLossExpectancyAfterActual"
                    Return "Integer"
                Case "colCostToCompleteActual"
                    Return "Integer"
                Case "colActualCostToComplete"
                    Return "Integer"
                Case "colRecPriority"
                    Return "Integer"
                Case "colRatingCatWeight"
                    Return "Decimal"
                Case "colRatingCat"
                    Return "String"
                Case "colRatingPts"
                    Return "Decimal"
                Case "colRatingScoreChange"
                    Return "Decimal"
                Case "colRatingCatPts"
                    Return "String"
                Case "colRecCategoryColor"
                    Return "String"
                Case "colExpectedCompletionDateColor"
                    Return "String"
                Case "colRecCategoryForeColor"
                    Return "String"
                Case "colLossExpectancyBeforeMedian"
                    Return "Integer"
                Case "colLossExpectancyAfterMedian"
                    Return "Integer"
                Case "colCostToCompleteMedian"
                    Return "Integer"
                Case "colFldAddressStamp"
                    Return "String"
                Case "colLocationRatingFormViewLink"
                    Return "String"
                Case "colLocationRatingReportLink"
                    Return "String"
                Case "colWiIsSelected"
                    Return "Boolean"
                Case "colWiRecStatus"
                    Return "String"
                Case "colLossExpectancyBeforeSortValue"
                    Return "Integer"
                Case "colCostToCompleteSortValue"
                    Return "Integer"
                Case "colFldFileNo"
                    Return "String"
                Case "colFldClientLocID"
                    Return "String"
                Case "colFldDivision"
                    Return "String"
                Case "colFldCustomAccess"
                    Return "String"
                Case "colFldFacility"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[gv].[vwWhatIfFireRecGrid]"
        End Function

        Private Function _FirstColumn() As String
            Return "[RecID]"
        End Function

    End Class
End namespace

