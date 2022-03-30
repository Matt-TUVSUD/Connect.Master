
Imports Telerik.Reporting

Public Class General

     Public Shared Function GetDetailSection(ByVal RootElement As Processing.LayoutElement) As Processing.DetailSection

          If TypeOf RootElement Is Processing.DetailSection Then
               Return RootElement
          End If

          For Each zElement In Processing.ElementTreeHelper.GetChildElements(RootElement)
               GetDetailSection(zElement)
          Next


          Return Nothing

     End Function

    Public Shared Function Capitalize(ByVal Text As String) As String
        Return UCase(Text)
    End Function

	Public Shared Function ToShortDateString(ByVal pValue As String) As String
		If pValue <> "" And IsDate(pValue) Then
			Return New DateTime(pValue).ToShortDateString
		Else
			Return ""
		End If
	End Function

	Public Shared Function ToMediumDateString(ByVal pValue As String) As String
		If pValue <> "" And IsDate(pValue) Then
			Return New Date(Year(pValue), Month(pValue), Day(pValue)).ToString("d-MMM-yy")
		Else
               Return ""
		End If
	End Function

     Public Shared Function SplitLines(ByVal pArg1 As String, ByVal pArg2 As String, Optional ByVal pArg3 As String = "", Optional ByVal pArg4 As String = "", Optional ByVal pArg5 As String = "") As String
          Dim zSb As New Text.StringBuilder
          zSb.AppendLine(pArg1)
          zSb.AppendLine(pArg2)
          If pArg3 <> "" Then zSb.AppendLine(pArg3)
          If pArg4 <> "" Then zSb.AppendLine(pArg4)
          If pArg5 <> "" Then zSb.AppendLine(pArg5)
          Return zSb.ToString
     End Function

     Public Shared Function IsGuid(ByVal value As String) As Boolean
          Try
               Dim zMyGuid = New Guid(value)
          Catch ex As FormatException
               Return False
          Catch ex As OverflowException
               Return False
          Catch ex As ArgumentNullException
               Return False
          End Try

          Return True

     End Function

     Public Shared Function Add(ByVal pValue1 As Double, ByVal pValue2 As Double, Optional pValue3 As Double = 0, Optional pValue4 As Double = 0, Optional pValue5 As Double = 0,
                                Optional pValue6 As Double = 0, Optional pValue7 As Double = 0)
          Return pValue1 + pValue2 + pValue3 + pValue4 + pValue5 + pValue6 + pValue7
     End Function

    Public Shared Function FormatCurrency(ByVal pValue As Object) As String
        If IsNumeric(pValue) Then
            Return Strings.FormatNumber(pValue, 0).ToString
        Else
            Return pValue
        End If
    End Function

    Public Shared Function FormatCurrencyWithSymbol(ByVal pSymbol As String, ByVal pValue As Object) As String
        Dim zReturn As String = ""

        If IsNumeric(pValue) Then
            zReturn = pSymbol & Strings.FormatNumber(pValue, 0).ToString
        ElseIf IsNothing(pValue) Then
            zReturn = "N/A"
        Else
            zReturn = pValue
        End If

        Return zReturn

    End Function

     Public Shared Function FormatPercentage(ByVal pValue As Double) As String
          Return Strings.FormatPercent(pValue, 0).ToString
     End Function

     Public Shared Function FormatCurrency(ByVal Symbol As String, ByVal Value As Double) As String
          Return Core.UtilCurrency.FormatCurrency(Symbol, Value)
     End Function

     Public Shared Function FormatNumber(ByVal pValue As Double) As String
          Return Strings.FormatNumber(pValue, 0)
     End Function

     ''' <summary>
     ''' Returns "score-rating" string for Fire. Example: 85-Excellent Risk
     ''' </summary>
     ''' <param name="FileNo"></param>
     ''' <param name="pScore"></param>
     ''' <returns></returns>
     ''' <remarks></remarks>
     Public Shared Function GetFireRating(ByVal FileNo As String, ByVal pScore As Double, ByVal pIncludeScore As Boolean, ByVal pDecimalPlaces As Integer) As String
          If pScore > 0 Then
               Return Core.UtilRating.GetRatingString(FileNo, Core.UtilPractice.PracticeEnum.Fire, pScore, pIncludeScore, pDecimalPlaces)
          End If
          Return ""
     End Function
     ''' <summary>
     ''' Returns "score-rating" string for Bm. Example: 85-Excellent Risk
     ''' </summary>
     ''' <param name="FileNo"></param>
     ''' <param name="pScore"></param>
     ''' <returns></returns>
     ''' <remarks></remarks>
     Public Shared Function GetBmRating(ByVal FileNo As String, ByVal pScore As Double, ByVal pIncludeScore As Boolean, ByVal pDecimalPlaces As Integer) As String
          If pScore > 0 Then
               Return Core.UtilRating.GetRatingString(FileNo, Core.UtilPractice.PracticeEnum.BM, pScore, pIncludeScore, pDecimalPlaces)
          End If
          Return ""
     End Function
     ''' <summary>
     ''' Returns the color object based on fileno and rating (ex: Better Risk)
     ''' </summary>
     ''' <param name="pFileNo"></param>
     ''' <param name="pRating"></param>
     ''' <returns></returns>
     ''' <remarks></remarks>
     Public Shared Function GetColorByFireRating(ByVal pFileNo As String, ByVal pRating As String) As System.Drawing.Color
          Return Core.UtilColor.GetColorByRating(pFileNo, Core.UtilPractice.PracticeEnum.Fire, pRating)
     End Function

     Public Shared Function GetColorByBmRating(ByVal pFileNo As String, ByVal pRating As String) As System.Drawing.Color
          Return Core.UtilColor.GetColorByRating(pFileNo, Core.UtilPractice.PracticeEnum.BM, pRating)
     End Function

     Public Shared Function CalcFireFacilityScore(ByVal pScore1 As Double, ByVal pScore2 As Double, ByVal pAplFactor As Double) As String
          Return ((pScore1 + pScore2) * pAplFactor).ToString
     End Function

     Public Shared Function CalcFireFacilityMaxScore(ByVal pScore1 As Double, ByVal pScore2 As Double, ByVal pFileNo As String) As String

          Dim zApl As Single = 1.2
        Dim zClient As New Core.BusinessObjects.Clients
          Dim zAplFactor As Aplfactorkey
          If zClient.LoadByFilePrefix(Int(pFileNo)) Then
               If zClient.HasCustomAplFactor Then
                    zAplFactor = New Aplfactorkey
                    zAplFactor.LoadByPrimaryKey(zClient.Fileprefix)
                    zApl = zAplFactor.Factor1
               End If
          End If

          Return ((pScore1 + pScore2) * zApl).ToString

     End Function

     Public Shared Function GetColorFromName(ByVal pColorName As String) As System.Drawing.Color
          Return System.Drawing.Color.FromName(pColorName)
     End Function

     Public Shared Function GetColorFromId(ByVal pId As Integer) As System.Drawing.Color
          Dim zColor As New Color
          zColor.LoadByPrimaryKey(pId)
          Return (System.Drawing.Color.FromArgb(zColor.R, zColor.G, zColor.B))
     End Function


     Public Shared Function GetColorByFireScore(ByVal pFileNo As String, ByVal pScore As Double) As System.Drawing.Color
          Return Core.UtilColor.GetColorByScore(pFileNo, Core.UtilPractice.PracticeEnum.Fire, pScore)
     End Function

     Public Shared Function GetColorByBmScore(ByVal pFileNo As String, ByVal pScore As Double) As System.Drawing.Color
          Return Core.UtilColor.GetColorByScore(pFileNo, Core.UtilPractice.PracticeEnum.BM, pScore)
     End Function

     Public Shared Function GetColorFromText(ByVal pText As String) As System.Drawing.Color
          Return Core.UtilColor.GetColorByText(pText)
     End Function

     Public Shared Function GetColorFromNumber(ByVal pNumber As Double) As System.Drawing.Color
          Return Core.UtilColor.GetColorByNumber(pNumber)
     End Function

     Public Shared Function GetLeBeforeValue(ByVal pFileNo As String, ByVal pRange As String, ByVal pCurrency As Integer) As String
          Return LossEstimateBefore.GetValue(pFileNo, pRange, pCurrency)
     End Function

     Public Shared Function GetLeAfterValue(ByVal pFileNo As String, ByVal pRange As String, ByVal pCurrency As Integer) As String
          Return LossEstimateAfter.GetValue(pFileNo, pRange, pCurrency)
     End Function

     Public Shared Function GetCostToCompleteValue(ByVal pFileNo As String, ByVal pRange As String, ByVal pCurrency As Integer) As String
          Return LossEstimateCost.GetValue(pFileNo, pRange, pCurrency)
     End Function

     Public Shared Function GetLastFireInspectionDate(ByVal pFileNo As String) As String
          Dim zObj As New ViewCCReportFireRatingLastQuery
          zObj.Select(zObj.InspectionDate)
          zObj.Where(zObj.FileNo = pFileNo)
          Return zObj.ExecuteScalar
     End Function

     Public Shared Function GetLastBmInspectionDate(ByVal pFileNo As String) As String
          Dim zObj As New ViewCCReportBoilerRatingLastQuery
          zObj.Select(zObj.InspectionDate)
          zObj.Where(zObj.FileNo = pFileNo)
          Return zObj.ExecuteScalar
     End Function

     Public Shared Function GetLastFireInspectionScore(ByVal pFileNo As String) As Double
          Dim zObj As New ViewCCReportFireRatingLastQuery
          zObj.Select(zObj.TotalScore)
          zObj.Where(zObj.FileNo = pFileNo)
          Return zObj.ExecuteScalar
     End Function

     Public Shared Function GetLastBmInspectionScore(ByVal pFileNo As String) As Double
          Dim zObj As New ViewCCReportBoilerRatingLastQuery
          zObj.Select(zObj.TotalScoreCurrent)
          zObj.Where(zObj.FileNo = pFileNo)
          Return zObj.ExecuteScalar
     End Function

     Public Shared Function GetFireClientAverage(ByVal pFileNo As String) As Double
          Return Rating.GetClientAvg(pFileNo)

     End Function

     Public Shared Function GetFireDivisionAverage(ByVal pFileNo As String) As Double
          Return Rating.GetDivisionAvg(pFileNo)
     End Function

     Public Shared Function GetBmClientAverage(ByVal pFileNo As String) As Double
          Return BMRating.GetClientAvg(pFileNo)

     End Function

     Public Shared Function GetBmDivisionAverage(ByVal pFileNo As String) As Double
          Return BMRating.GetDivisionAvg(pFileNo)
     End Function

     Public Shared Function ConvertLength(ByVal pValue As Double, ByVal pUnit As Integer) As String
          Dim zRetVal As Integer = Core.UtilUnit.Convert.Length(pValue, Core.UtilUnit.Units.English, pUnit)
          Return zRetVal.ToString & " " & UtilUnit.GetLengthAbbreviation(pUnit)
     End Function

     Public Shared Function ConvertSpeed(ByVal pValue As Double, ByVal pUnit As Integer) As String
          Dim zRetVal As String = Core.UtilUnit.Convert.Speed(pValue, Core.UtilUnit.Units.English, pUnit)
          Return zRetVal.ToString & " " & UtilUnit.GetSpeedAbbreviation(pUnit)
     End Function

     Public Shared Function ConvertArea(ByVal pValue As Double, ByVal pUnit As Integer) As String
          Dim zRetVal As Integer = Core.UtilUnit.Convert.Area(pValue, Core.UtilUnit.Units.English, pUnit)
          Return FormatNumber(zRetVal).ToString & " " & UtilUnit.GetAreaAbbreviation(pUnit)
     End Function

     Public Shared Function ConvertDistance(ByVal pValue As String, ByVal pUnit As Integer) As String
          Dim zRetVal As String = Core.UtilUnit.Convert.Distance(pValue, Core.UtilUnit.Units.English, pUnit)
          Return zRetVal
     End Function


End Class
