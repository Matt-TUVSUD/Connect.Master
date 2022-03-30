Imports GRC.Connect.Libraries.DataLib.razor


Public Class UtilBubbleChart

    Public Shared Function GetRatingByRecLeData(pSafeId As Integer, pPractice As UtilMetaPractice.Practices, pGridFilter As String) As List(Of RatingByRecLeItem)

        Dim gsJoin As String = "INNER JOIN GSafeFileNo G ON ?=G.FileNo INNER JOIN GSafeHeader GH ON g.GSafeId=gh.GSafeId"
        Dim sql As String = ""
        Dim list As New List(Of RatingByRecLeItem)

        Select Case pPractice
            Case UtilMetaPractice.Practices.Fire
                sql = "select v.* from [gv].[vwFireLossEstimatesLatestFacilityRatingExtractSelect] v " & _
                " inner join GsafeFileNo g ON v.FileNo=g.FileNo" & _
                " inner join GSafeHeader h ON g.GSafeId = h.GSafeId" & _
                " where 1=1 AND h.GSafeId = {0}"

                If pGridFilter <> "null" Then
                    sql = sql & " AND {1}"
                End If

            Case UtilMetaPractice.Practices.BoilerAndMachinery
                sql = "select v.* from [gv].[vwBMLossEstimatesLatestFacilityRatingExtractSelect] v " & _
                " inner join GsafeFileNo g ON v.FileNo=g.FileNo" & _
                " inner join GSafeHeader h ON g.GSafeId = h.GSafeId" & _
                " where 1=1 and h.GSafeId = {0}"

                If pGridFilter <> "null" Then
                    sql = sql & " AND {1}"
                End If

            Case Else

                Throw New ArgumentException("Specified practice value is not applicable.")
        End Select

        Dim zfilter As String = ""

        If pGridFilter <> "null" Then
            zfilter = FilterSortLib.fsFilter.ToSQL(pGridFilter)
        End If

        sql = String.Format(sql, pSafeId, zfilter)

        Dim zCon As SqlClient.SqlConnection = UtilSQLServer.GetConnectionObject()
        Dim zCmd As New SqlClient.SqlCommand(sql, zCon)
        Dim zDT As New DataTable

        Using zCon
            Using zCmd
                zDT.Load(zCmd.ExecuteReader)
            End Using
        End Using

        For Each zRow In zDT.Rows
            Dim zItem As New RatingByRecLeItem
            With zItem
                .FileNo = IIf(IsDBNull(zRow("FileNo")), Nothing, zRow("FileNo"))
                .Client = IIf(IsDBNull(zRow("Client")), Nothing, zRow("Client"))
                .ClientLocID = IIf(IsDBNull(zRow("ClientLocNo")), Nothing, zRow("ClientLocNo"))
                .Division = IIf(IsDBNull(zRow("Division")), Nothing, zRow("Division"))
                .Facility = IIf(IsDBNull(zRow("Facility")), Nothing, zRow("Facility"))
                .Address = IIf(IsDBNull(zRow("Address")), Nothing, zRow("Address"))
                .City = IIf(IsDBNull(zRow("City")), Nothing, zRow("City"))
                .StProv = IIf(IsDBNull(zRow("StProv")), Nothing, zRow("StProv"))
                .Country = IIf(IsDBNull(zRow("Country")), Nothing, zRow("Country"))
                .Tiv = IIf(IsDBNull(zRow("Tiv")), Nothing, zRow("TIV"))
                .InspDate = IIf(IsDBNull(zRow("InspectionDate")), Nothing, zRow("InspectionDate"))
                .LossEstBefore = IIf(IsDBNull(zRow("HighestLossExpectancy")), Nothing, zRow("HighestLossExpectancy"))
                .Mfl = IIf(IsDBNull(zRow("MFL")), Nothing, zRow("MFL"))
                .CustomAccess = IIf(IsDBNull(zRow("CustomAccess")), Nothing, zRow("CustomAccess"))

                If pPractice = UtilMetaPractice.Practices.Fire Then
                    .CurrentScore = IIf(IsDBNull(zRow("TotalScore")), Nothing, zRow("TotalScore"))
                Else
                    .CurrentScore = IIf(IsDBNull(zRow("TotalScoreCurrent")), Nothing, zRow("TotalScoreCurrent"))
                End If
            End With
            list.Add(zItem)
        Next

        Return list

    End Function

    Public Class RatingByRecLeItem
        Public Property FileNo As String
        Public Property Client As String
        Public Property ClientLocID As String
        Public Property Division As String
        Public Property Facility As String
        Public Property Address As String
        Public Property City As String
        Public Property StProv As String
        Public Property Country As String
        Public Property Tiv As Double?
        Public Property InspDate As Date?
        Public Property LossEstBefore As Int64?
        Public Property Mfl As Double?
        Public Property CustomAccess As String
        Public Property CurrentScore As Double?
    End Class


End Class


''