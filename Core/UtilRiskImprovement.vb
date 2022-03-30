Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilRiskImprovement

    Public Property Recommendations As New RecStatusInfo
    Public Property RiskMitigated As New MitigatedInfo

    Private _RiskDataTable As DataTable
    Private _Client As rowTblClients
    Private _LossEstimate As List(Of rowTblMetaLossEstimate)
    Private _Currency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar

    Private _DebugOutput As Boolean = True

    Public Sub New(pRecData As DataTable, pFilePrefix As String, Optional pCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar)
        _Client = TblClients.LoadByPrimaryKey(pFilePrefix)
        _Currency = pCurrency

        FillLossEstimateData()
        SetData(pRecData)
        ParseRecData()
        ParseMitigatedData()

        If Debugger.IsAttached And _DebugOutput Then ExcelOutput2()
    End Sub

    Private Sub ExcelOutput()
        Dim zOutputPath As String = IO.Path.GetTempFileName.Replace(".tmp", ".xlsx")

        Dim zColList As New GRC.MSOffice.ExcelColumnFormatList
        For Each zCol As DataColumn In _RiskDataTable.Columns
            zColList.Add(New GRC.MSOffice.ExcelColumnFormat(zCol.ColumnName, zCol.ColumnName, ""))
        Next

        Dim zXL As New GRC.MSOffice.ExcelExporter(_RiskDataTable, zColList)
        Dim zByte() As Byte = zXL.ExportXLSX()

        IO.File.WriteAllBytes(zOutputPath, zByte)

        Process.Start(zOutputPath)

    End Sub


    Private Sub ExcelOutput2()

        Dim zOutputPath As String = IO.Path.GetTempFileName.Replace(".tmp", ".xlsx")

        Dim zSheet2DS As New GRC.Excel.Extractions.XLExtractDataTableSource(_RiskDataTable)
        Dim zSheet2 As New GRC.Excel.Extractions.XLExtractSheet(zSheet2DS, "Data")

        Dim zSheet1DS As New GRC.Excel.Extractions.XLExtractListSource(RiskMitigated.RiskYearList)
        Dim zSheet1 As New GRC.Excel.Extractions.XLExtractSheet(zSheet1DS, "Summary")

        Dim zExtractor As New GRC.Excel.Extractions.XLExtractor()
        zExtractor.SheetData.Add(zSheet1)
        zExtractor.SheetData.Add(zSheet2)

        Dim zByte() As Byte = zExtractor.Run()

        IO.File.WriteAllBytes(zOutputPath, zByte)

        Process.Start(zOutputPath)

    End Sub

    Private Sub TraceOutput()
        Trace.WriteLine("Client;" & _Client.colClientname)
        Trace.WriteLine("FilePrefix;" & _Client.colFileprefix)
        Trace.WriteLine("")
        Trace.WriteLine("")

        Recommendations.StatusCounts.ForEach(Sub(x) Trace.WriteLine(x.Status & ";" & x.Count & ";" & x.Percent))

        Trace.WriteLine("")
        Trace.WriteLine("")
        Trace.WriteLine("Total Risk Identified;" & FormatCurrency(RiskMitigated.TotalExposureIdentified))
        Trace.WriteLine("Total Risk Fixed;" & FormatCurrency(RiskMitigated.TotalExposureReduced))
        Trace.WriteLine("Total Risk Remaining;" & FormatCurrency(RiskMitigated.TotalExposureRemaining))
        Trace.WriteLine("Total Recs;" & Recommendations.TotalCount)
        Trace.WriteLine("Total LE After Rec Closed;" & RiskMitigated.TotalLossEstAfterClosedRecCount)
        Trace.WriteLine("Total LE After Exposure Fixed;" & FormatCurrency(RiskMitigated.TotalLossEstAfterExposureReduced))
        Trace.WriteLine("Total Proability Rec Closed;" & RiskMitigated.TotalProabilityClosedRecCount)
        Trace.WriteLine("Total Probility Exposure Fixed;" & FormatCurrency(RiskMitigated.TotalProbabilityReductionExposureReduced))

        Trace.WriteLine("")
        Trace.WriteLine("")

        Trace.Write("Rec Year;")
        Trace.Write("Rec Count;")
        Trace.Write("Rec Count Closed;")
        Trace.Write("Total LE Before;")
        Trace.Write("Total LE After;")
        Trace.Write("Total Exposure;")
        Trace.Write("Total Exposure Reduced;")
        Trace.Write("Probability Exposure Reduced;")
        Trace.Write("Proability Rec Count (Closed);")
        Trace.Write("LE After Reduced;")
        Trace.Write("LE After Rec Count (Closed)")
        Trace.WriteLine("")
        For Each zRiskYear As RiskYear In RiskMitigated.RiskYearList
            Trace.Write(zRiskYear.RecYear & ";")
            Trace.Write(zRiskYear.RecCount & ";")
            Trace.Write(zRiskYear.RecCountClosed & ";")
            Trace.Write(FormatCurrency(zRiskYear.TotalLossEstimateBefore) & ";")
            Trace.Write(FormatCurrency(zRiskYear.TotalLossEstimateAfter) & ";")
            Trace.Write(FormatCurrency(zRiskYear.ExposureIdentified) & ";")
            Trace.Write(FormatCurrency(zRiskYear.ExposureReduced) & ";")
            Trace.Write(FormatCurrency(zRiskYear.ProbabilityReductionExposureReduced) & ";")
            Trace.Write(zRiskYear.ProbabilityReductionClosedRecCount & ";")
            Trace.Write(FormatCurrency(zRiskYear.LossEstAfterExposureReduced) & ";")
            Trace.Write(zRiskYear.LossEstAfterClosedRecCount & ";")
            Trace.WriteLine("")
        Next

        Trace.WriteLine("")
        Trace.WriteLine("")

        Trace.Write("xFileNo;")
        Trace.Write("xLossExpectancyBefore;")
        Trace.Write("xLossEstimateBeforeAverage;")
        Trace.Write("xLossExpectancyAfter;")
        Trace.Write("xLossEstimateAfterAverage;")
        Trace.Write("xFixableExposure;")
        Trace.Write("xStatusDate;")
        Trace.Write("xRecStatus;")
        Trace.Write("xStatusDateYear;")
        Trace.WriteLine("xIsClosed")

        For Each zRow As DataRow In _RiskDataTable.Rows
            Dim FileNo = zRow(GetDataFieldColumnName(DataField.FileNo)) & ";"
            Dim LEBefore = zRow(GetDataFieldColumnName(DataField.LossExpectancyBeforeRange)) & ";"
            Dim LEBeforeMedian = FormatCurrency(zRow(GetDataFieldColumnName(DataField.LossEstBeforeMedianAverage))) & ";"
            Dim LEAfter = zRow(GetDataFieldColumnName(DataField.LossExpectancyAfterRange)) & ";"
            Dim LEAfterMedian = FormatCurrency(zRow(GetDataFieldColumnName(DataField.LossEstAfterMedianAverage))) & ";"
            Dim Fixable = FormatCurrency(zRow(GetDataFieldColumnName(DataField.FixableExposure))) & ";"
            Dim StatusDate = zRow(GetDataFieldColumnName(DataField.StatusDate)) & ";"
            Dim RecStatus = zRow(GetDataFieldColumnName(DataField.RecStatus)) & ";"
            Dim StatusYear = zRow(GetDataFieldColumnName(DataField.StatusDateYear)) & ";"
            Dim ClosedYear = zRow(GetDataFieldColumnName(DataField.ClosedYear)) & ";"
            Dim RecClosed = zRow(GetDataFieldColumnName(DataField.IsClosed))
            Trace.WriteLine(FileNo & LEBefore & LEBeforeMedian & LEAfter & LEAfterMedian & Fixable & StatusDate & RecStatus & StatusYear & RecClosed.ToString)
        Next

    End Sub

    Private Sub FillLossEstimateData()
        Dim zSQL As String = "SELECT * FROM tblMetaLossEstimate WHERE fldExchangeRateGroupID=@ClientCurrencyId AND (fldLossEstimateTypeId=1 OR  fldLossEstimateTypeId=2) AND fldCurrencyId=@CurrencyId ORDER BY fldIndexNo ASC"
        Dim zCmd As New SqlClient.SqlCommand(zSQL, UtilSQLServer.GetConnectionObject)
        zCmd.Parameters.AddWithValue("@ClientCurrencyId", _Client.colExchangeRateGroupID)
        zCmd.Parameters.AddWithValue("@CurrencyId", _Currency)
        _LossEstimate = TblMetaLossEstimate.LoadData(zCmd)
        zCmd.Connection.Close()
        zCmd.Dispose()
        zCmd = Nothing

        'ADJUST THE LE >1BIL TO USE ONLY 1 BIL AS THE AVERAGE
        Dim z1BilLEList As List(Of rowTblMetaLossEstimate) = _LossEstimate.FindAll(Function(x) x.colFldRangeDisplay = ">1BIL")
        z1BilLEList.ForEach(Sub(x) x.colFldRangeValueHigh = 1000000000)
        z1BilLEList.ForEach(Sub(x) _LossEstimate.ForEach(Sub(y) IIf(IsEqual(x, y), x, y)))

    End Sub

    Private Function IsEqual(x As rowTblMetaLossEstimate, y As rowTblMetaLossEstimate) As Boolean
        Return x.colFldExchangeRateGroupID = y.colFldExchangeRateGroupID And x.colFldLossEstimateTypeId = y.colFldLossEstimateTypeId And
            x.colFldCurrencyId = y.colFldCurrencyId And x.colFldIndexNo = y.colFldIndexNo
    End Function


    Private Sub ParseRecData()
        FillStatusCounts()
    End Sub

    Private Sub FillStatusCounts()
        Dim zStatuses() = {"Advisory", "Conf Completed", "In Progress", "Outstanding", "Removed", "Rptd Completed"}
        For Each zStatus As String In zStatuses
            Dim zCount As Integer = _RiskDataTable.Compute("Count(" & GetDataFieldColumnName(DataField.RecStatus) & ")", GetDataFieldColumnName(DataField.RecStatus) & "='" & zStatus & "'")
            Recommendations.AddStatusCount(zStatus, zCount)
        Next
    End Sub

    Public Sub ParseMitigatedData()
        FillMitigatedData()
    End Sub

    Private Sub FillMitigatedData()
        BuildMitigatedInfo()
    End Sub

    Private Sub SetData(pSourceData As DataTable)

        AddDataFields(pSourceData)

        For Each zRow As DataRow In pSourceData.Rows
            Dim zLEBefore As rowTblMetaLossEstimate = _LossEstimate.Find(Function(x) x.colFldRangeDisplay = zRow("LossExpectancyBefore") And x.colFldLossEstimateTypeId = 1)
            If IsNothing(zLEBefore) Then Throw New MissingLossEstimateDataException(MissingLossEstimateDataException.LossEstimateType.Before)


            Dim zBeforeMedian As Long = (zLEBefore.colFldRangeValueLow + zLEBefore.colFldRangeValueHigh) / 2
            zRow(GetDataFieldColumnName(DataField.LossEstBeforeMedianAverage)) = zBeforeMedian

            Dim zLEAfter As rowTblMetaLossEstimate = _LossEstimate.Find(Function(x) x.colFldRangeDisplay = zRow("LossExpectancyAfter") And x.colFldLossEstimateTypeId = 2)
            If IsNothing(zLEAfter) Then Throw New MissingLossEstimateDataException(MissingLossEstimateDataException.LossEstimateType.After)

            Dim zMedianAfter As Long = (zLEAfter.colFldRangeValueLow + zLEAfter.colFldRangeValueHigh) / 2

            'This line of code is here so that there is not a negative impact if the lebefore is HE and there is a LE After.  The value would be negative.
            'We want to set the zMedianAverage to 0 in these cases.
            If zLEBefore.colFldRangeDisplay = "HE/Reliability" And zMedianAfter > 0 Then zMedianAfter = 0

            zRow(GetDataFieldColumnName(DataField.LossEstAfterMedianAverage)) = zMedianAfter

            zRow(GetDataFieldColumnName(DataField.FileNo)) = zRow("FileNo")
            zRow(GetDataFieldColumnName(DataField.RecYear)) = zRow("RecYear")
            zRow(GetDataFieldColumnName(DataField.RecStatus)) = zRow("RecStatus")
            zRow(GetDataFieldColumnName(DataField.StatusDate)) = zRow("StatusDate")
            zRow(GetDataFieldColumnName(DataField.LossExpectancyAfterRange)) = zRow("LossExpectancyAfter")
            zRow(GetDataFieldColumnName(DataField.LossExpectancyBeforeRange)) = zRow("LossExpectancyBefore")
            zRow(GetDataFieldColumnName(DataField.StatusDateYear)) = zRow("StatusDateYear")
            zRow(GetDataFieldColumnName(DataField.FixableExposure)) = zBeforeMedian - zMedianAfter
            zRow(GetDataFieldColumnName(DataField.IsClosed)) = zRow("IsClosed")
            zRow(GetDataFieldColumnName(DataField.ClosedYear)) = zRow("ClosedYear")
            zRow(GetDataFieldColumnName(DataField.ResponseDate)) = zRow("ResponseDate")
            zRow(GetDataFieldColumnName(DataField.ResponseDateYear)) = zRow("ResponseDateYear")
        Next

        _RiskDataTable = pSourceData.DefaultView.ToTable(False, GetDataFieldsList.ToArray)

    End Sub

    'Private Function GetStatusYear(pRow As DataRow) As Integer
    '    If IsDate(pRow("StatusDate")) Then
    '        Return Year(pRow("StatusDate"))
    '    Else
    '        Return 0
    '    End If
    'End Function

    'Private Function IsRecClosed(zRow As DataRow) As Boolean
    '    Dim zClosedStatuses() = {"Conf Completed", "Removed", "Rptd Completed"}
    '    Dim zRecStatus As String = zRow("RecStatus")
    '    Return zClosedStatuses.ToList.Contains(zRecStatus, StringComparer.OrdinalIgnoreCase)
    'End Function

    Private Sub BuildMitigatedInfo()
        Dim zYears As List(Of Integer) = GetConsecutiveRecYears()
        If Not zYears.Contains(Year(Now)) Then zYears.Add(Year(Now))

        For Each zYear As Integer In zYears
            Dim zRiskYr As New RiskYear
            With zRiskYr
                .RecYear = zYear
                .RecCount = Coalesce(_RiskDataTable.Compute("Count(" & GetDataFieldColumnName(DataField.RecYear) & ")", GetDataFieldColumnName(DataField.RecYear) & "=" & zYear), 0)
                .TotalLossEstimateBefore = Coalesce(_RiskDataTable.Compute("Sum(" & GetDataFieldColumnName(DataField.LossEstBeforeMedianAverage) & ")", GetDataFieldColumnName(DataField.RecYear) & "=" & zYear), 0)
                .TotalLossEstimateAfter = Coalesce(_RiskDataTable.Compute("Sum(" & GetDataFieldColumnName(DataField.LossEstAfterMedianAverage) & ")", GetDataFieldColumnName(DataField.RecYear) & "=" & zYear), 0)
                .ExposureIdentified = .TotalLossEstimateBefore - .TotalLossEstimateAfter
                .ExposureReduced = Coalesce(_RiskDataTable.Compute("Sum(" & GetDataFieldColumnName(DataField.FixableExposure) & ")", GetDataFieldColumnName(DataField.StatusDateYear) & "=" & zYear & " AND " & GetDataFieldColumnName(DataField.IsClosed) & "=True"), 0)
                .ExposureRemaining = .ExposureIdentified - .ExposureReduced
                .RecCountClosed = Coalesce(_RiskDataTable.Compute("Count(" & GetDataFieldColumnName(DataField.IsClosed) & ")", GetDataFieldColumnName(DataField.ClosedYear) & "=" & zYear & " AND " & GetDataFieldColumnName(DataField.IsClosed) & "=True"), 0)
                .ProbabilityReductionClosedRecCount = Coalesce(_RiskDataTable.Compute("Count(" & GetDataFieldColumnName(DataField.IsClosed) & ")", GetDataFieldColumnName(DataField.ClosedYear) & "=" & zYear & " AND " & GetDataFieldColumnName(DataField.IsClosed) & "=True AND " & GetDataFieldColumnName(DataField.LossExpectancyAfterRange) & "  LIKE '*Probability*'"), 0)
                .ProbabilityReductionExposureReduced = Coalesce(_RiskDataTable.Compute("Sum(" & GetDataFieldColumnName(DataField.FixableExposure) & ")", GetDataFieldColumnName(DataField.ClosedYear) & "=" & zYear & " AND " & GetDataFieldColumnName(DataField.IsClosed) & "=True AND " & GetDataFieldColumnName(DataField.LossExpectancyAfterRange) & "  LIKE '*Probability*'"), 0)
            End With

            RiskMitigated.RiskYearList.Add(zRiskYr)

        Next

    End Sub

    Private Function Coalesce(pValue As Object, pDefault As Object) As Object
        If IsDBNull(pValue) Then Return pDefault
        If IsNothing(pValue) Then Return pDefault
        Return pValue
    End Function

    'This function gets the distinct rec years from the recommendation table.
    Private Function GetDistinctRecYears() As List(Of Integer)
        Dim zDV As New DataView(_RiskDataTable)
        Dim zDT As DataTable = zDV.ToTable(True, {GetDataFieldColumnName(DataField.RecYear)})
        Dim zReturn As New List(Of Integer)
        For Each zRow As DataRow In zDT.Rows
            zReturn.Add(zRow(GetDataFieldColumnName(DataField.RecYear)))
        Next
        zReturn = zReturn.OrderBy(Function(x) x).ToList
        Return zReturn
    End Function

    'This function serves to ensure that there are no breaks in the rec year list.  It ensures that all rec years are consecutive.
    'If the max year is not the year of today, then add the current year.
    Private Function GetConsecutiveRecYears() As List(Of Integer)

        Dim zRecYearList As List(Of Integer) = GetDistinctRecYears()
        If zRecYearList.Count = 0 Then zRecYearList.Add(Year(Now)) : zRecYearList.Add(Year(Now.AddYears(-5)))

        Dim zMaxYear As Integer = zRecYearList.Max
        Dim zMinYear As Integer = zRecYearList.Min

        'If the max year is not the year of today, then add today's year
        If zMaxYear <> Year(Now) Then zRecYearList.Add(Year(Now)) : zMaxYear = Year(Now)

        'If the min year is not 5 years ago, then add min year
        If Not zRecYearList.Contains(zMaxYear - 5) Then zMinYear = zMaxYear - 5 : zRecYearList.Add(zMinYear)

        'Loop between earch year checking to see if it is in the list.  If not, then add to the list.  Ensures an ordinal list, not gaps.
        For i = zMinYear To zMaxYear Step 1
            If Not zRecYearList.Contains(i) Then zRecYearList.Add(i)
        Next

        Return zRecYearList.OrderBy(Function(x) x).ToList()

    End Function

    Public Sub AddDataFields(ByRef pData As DataTable)
        Dim zDataFields = [Enum].GetValues(GetType(DataField))
        For Each zDataField In zDataFields
            pData.Columns.Add(GetDataFieldDataColumn(zDataField))
        Next
    End Sub

    Private Function GetDataFieldColumnName(pDataField As DataField) As String
        Return "x" & pDataField.ToString
    End Function

    Private Function GetDataFieldDataColumn(pDataField As DataField) As DataColumn
        Dim zType As Type = Nothing

        Select Case pDataField
            Case DataField.FixableExposure
                zType = GetType(System.Double)
            Case DataField.IsClosed
                zType = GetType(System.Boolean)
            Case DataField.LossEstAfterMedianAverage
                zType = GetType(System.Double)
            Case DataField.LossEstBeforeMedianAverage
                zType = GetType(System.Double)
            Case DataField.LossExpectancyAfterRange
                zType = GetType(System.String)
            Case DataField.LossExpectancyBeforeRange
                zType = GetType(System.String)
            Case DataField.RecStatus
                zType = GetType(System.String)
            Case DataField.RecYear
                zType = GetType(System.String)
            Case DataField.StatusDate
                zType = GetType(System.DateTime)
            Case DataField.StatusDateYear
                zType = GetType(System.String)
            Case DataField.FileNo
                zType = GetType(System.String)
            Case Else
                zType = GetType(System.String)
        End Select

        Return New DataColumn(GetDataFieldColumnName(pDataField), zType)

    End Function

    Private Function GetDataFieldsList() As List(Of String)
        Dim zEnumVals As System.Array = [Enum].GetValues(GetType(DataField))
        Dim zReturn As New List(Of String)
        For Each zVal As DataField In zEnumVals
            zReturn.Add(GetDataFieldColumnName(zVal))
        Next
        Return zReturn
    End Function

#Region "Nested Classes"

    Public Class MitigatedInfo
        Public Property RiskYearList As New List(Of RiskYear)

        Public ReadOnly Property TotalExposureIdentified As Double
            Get
                Dim zCount As Double
                RiskYearList.ForEach(Sub(x) zCount += x.ExposureIdentified)
                Return zCount
            End Get
        End Property

        Public ReadOnly Property TotalExposureReduced As Double
            Get
                Dim zCount As Double
                RiskYearList.ForEach(Sub(x) zCount += x.ExposureReduced)
                Return zCount
            End Get
        End Property

        Public ReadOnly Property TotalExposureRemaining As Double
            Get
                Return TotalExposureIdentified - TotalExposureReduced
            End Get
        End Property

        Public ReadOnly Property TotalLossEstAfterExposureReduced As Double
            Get
                Dim zCount As Double
                RiskYearList.ForEach(Sub(x) zCount += x.LossEstAfterExposureReduced)
                Return zCount
            End Get
        End Property

        Public ReadOnly Property TotalLossEstAfterClosedRecCount As Integer
            Get
                Dim zCount As Integer
                RiskYearList.ForEach(Sub(x) zCount += x.LossEstAfterClosedRecCount)
                Return zCount
            End Get
        End Property

        Public ReadOnly Property TotalProbabilityReductionExposureReduced As Double
            Get
                Dim zCount As Double
                RiskYearList.ForEach(Sub(x) zCount += x.ProbabilityReductionExposureReduced)
                Return zCount
            End Get
        End Property

        Public ReadOnly Property TotalProabilityClosedRecCount As Integer
            Get
                Dim zCount As Integer
                RiskYearList.ForEach(Sub(x) zCount += x.ProbabilityReductionClosedRecCount)
                Return zCount
            End Get
        End Property

    End Class

    Public Class RiskYear
        Public Property RecYear As Integer
        Public Property RecCount As Long = 0
        Public Property TotalLossEstimateBefore As Long = 0
        Public Property TotalLossEstimateAfter As Long = 0
        Public Property ExposureReduced As Double = 0
        Public Property ExposureIdentified As Double = 0
        Public Property ExposureRemaining As Double = 0
        Public Property RecCountClosed As Integer = 0
        Public Property ProbabilityReductionClosedRecCount As Integer = 0
        Public Property ProbabilityReductionExposureReduced As Double = 0

        Public ReadOnly Property LossEstAfterClosedRecCount
            Get
                Return RecCountClosed - ProbabilityReductionClosedRecCount
            End Get
        End Property

        Public ReadOnly Property LossEstAfterExposureReduced
            Get
                Return ExposureReduced - ProbabilityReductionExposureReduced
            End Get
        End Property

        Public ReadOnly Property ExposureReducedString() As String
            Get
                If Me.ExposureReduced = 0.05 Then
                    Return "0"
                Else
                    Return FormatNumber(Me.ExposureReduced, 0)
                End If
            End Get
        End Property

        Public ReadOnly Property ExposureIdentifiedString() As String
            Get
                If Me.ExposureIdentified = 0.05 Then
                    Return "$0"
                Else
                    Return FormatNumber(Me.ExposureIdentified, 0)
                End If
            End Get
        End Property

    End Class

    Public Class RecStatusInfo
        Public Property StatusCounts As New List(Of RecStatusItem)

        Public Sub AddStatusCount(pStatus As String, pCount As Integer)
            StatusCounts.Add(New RecStatusItem(Me, pStatus, pCount))
        End Sub

        Public ReadOnly Property TotalCount As Integer
            Get
                Dim zCount As Integer = 0
                StatusCounts.ForEach(Sub(x) zCount += x.Count)
                Return zCount
            End Get
        End Property

    End Class

    Public Class RecStatusItem
        Public Property Status As String
        Public Property Count As Integer = 0
        Private _StatusInfo As RecStatusInfo

        Friend Sub New(pStatusInfo As RecStatusInfo, pStatus As String, pCount As Integer)
            Status = pStatus
            Count = pCount
            _StatusInfo = pStatusInfo
        End Sub

        Public ReadOnly Property Percent As Double
            Get
                Return CDbl(Count / _StatusInfo.TotalCount)
            End Get
        End Property

        Public ReadOnly Property PercentText As String
            Get
                Return FormatNumber(CDbl(Count / _StatusInfo.TotalCount) * 100, 1) & "%"
            End Get
        End Property

    End Class

#End Region

    Private Enum DataField
        FileNo
        RecStatus
        IsClosed
        ClosedYear
        RecYear
        StatusDate
        StatusDateYear
        ResponseDate
        ResponseDateYear
        LossExpectancyBeforeRange
        LossExpectancyAfterRange
        LossEstBeforeMedianAverage
        LossEstAfterMedianAverage
        FixableExposure
    End Enum

End Class

Public Class MissingLossEstimateDataException
    Inherits Exception

    Public Enum LossEstimateType
        Before
        After
    End Enum

    Public Sub New(pType As LossEstimateType)
        MyBase.New("Missing Loss Estimate " & pType.ToString & " values. Unable to compute.")
    End Sub

End Class