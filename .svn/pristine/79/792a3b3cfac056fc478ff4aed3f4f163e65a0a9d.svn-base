'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblWhatIfLocation
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colFldDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFldCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colFldClientLocID As New razor.UtilSQLServer.StringDataColumn
        Public colFldAddressStamp As New razor.UtilSQLServer.StringDataColumn
        Public colFldFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFldTivUSD As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldTotalScore As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldTotalScoreRecsComplete As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldTotalScoreAchievedPercent As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldPhysicalProtRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldPhysicalProtWeight As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldHeRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldHeWeight As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldNatHazRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldNatHazWeight As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldBcpRating As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldBcpWeight As New razor.UtilSQLServer.DecimalDataColumn
        Public colFldHasRatingData As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldCreateDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldFacility As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldGSafeId.ColumnName = "[fldGSafeId]"
            colFldFileNo.ColumnName = "[fldFileNo]"
            colFldDivision.ColumnName = "[fldDivision]"
            colFldCustomAccess.ColumnName = "[fldCustomAccess]"
            colFldClientLocID.ColumnName = "[fldClientLocID]"
            colFldAddressStamp.ColumnName = "[fldAddressStamp]"
            colFldFilePrefix.ColumnName = "[fldFilePrefix]"
            colFldTivUSD.ColumnName = "[fldTivUSD]"
            colFldTotalScore.ColumnName = "[fldTotalScore]"
            colFldTotalScoreRecsComplete.ColumnName = "[fldTotalScoreRecsComplete]"
            colFldTotalScoreAchievedPercent.ColumnName = "[fldTotalScoreAchievedPercent]"
            colFldPhysicalProtRating.ColumnName = "[fldPhysicalProtRating]"
            colFldPhysicalProtWeight.ColumnName = "[fldPhysicalProtWeight]"
            colFldHeRating.ColumnName = "[fldHeRating]"
            colFldHeWeight.ColumnName = "[fldHeWeight]"
            colFldNatHazRating.ColumnName = "[fldNatHazRating]"
            colFldNatHazWeight.ColumnName = "[fldNatHazWeight]"
            colFldBcpRating.ColumnName = "[fldBcpRating]"
            colFldBcpWeight.ColumnName = "[fldBcpWeight]"
            colFldHasRatingData.ColumnName = "[fldHasRatingData]"
            colFldCreateDate.ColumnName = "[fldCreateDate]"
            colFldFacility.ColumnName = "[fldFacility]"

            _Members.Add("colFldGSafeId", colFldGSafeId)
            _Members.Add("colFldFileNo", colFldFileNo)
            _Members.Add("colFldDivision", colFldDivision)
            _Members.Add("colFldCustomAccess", colFldCustomAccess)
            _Members.Add("colFldClientLocID", colFldClientLocID)
            _Members.Add("colFldAddressStamp", colFldAddressStamp)
            _Members.Add("colFldFilePrefix", colFldFilePrefix)
            _Members.Add("colFldTivUSD", colFldTivUSD)
            _Members.Add("colFldTotalScore", colFldTotalScore)
            _Members.Add("colFldTotalScoreRecsComplete", colFldTotalScoreRecsComplete)
            _Members.Add("colFldTotalScoreAchievedPercent", colFldTotalScoreAchievedPercent)
            _Members.Add("colFldPhysicalProtRating", colFldPhysicalProtRating)
            _Members.Add("colFldPhysicalProtWeight", colFldPhysicalProtWeight)
            _Members.Add("colFldHeRating", colFldHeRating)
            _Members.Add("colFldHeWeight", colFldHeWeight)
            _Members.Add("colFldNatHazRating", colFldNatHazRating)
            _Members.Add("colFldNatHazWeight", colFldNatHazWeight)
            _Members.Add("colFldBcpRating", colFldBcpRating)
            _Members.Add("colFldBcpWeight", colFldBcpWeight)
            _Members.Add("colFldHasRatingData", colFldHasRatingData)
            _Members.Add("colFldCreateDate", colFldCreateDate)
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
                Case "colFldGSafeId"
                    Return "[fldGSafeId]"
                Case "colFldFileNo"
                    Return "[fldFileNo]"
                Case "colFldDivision"
                    Return "[fldDivision]"
                Case "colFldCustomAccess"
                    Return "[fldCustomAccess]"
                Case "colFldClientLocID"
                    Return "[fldClientLocID]"
                Case "colFldAddressStamp"
                    Return "[fldAddressStamp]"
                Case "colFldFilePrefix"
                    Return "[fldFilePrefix]"
                Case "colFldTivUSD"
                    Return "[fldTivUSD]"
                Case "colFldTotalScore"
                    Return "[fldTotalScore]"
                Case "colFldTotalScoreRecsComplete"
                    Return "[fldTotalScoreRecsComplete]"
                Case "colFldTotalScoreAchievedPercent"
                    Return "[fldTotalScoreAchievedPercent]"
                Case "colFldPhysicalProtRating"
                    Return "[fldPhysicalProtRating]"
                Case "colFldPhysicalProtWeight"
                    Return "[fldPhysicalProtWeight]"
                Case "colFldHeRating"
                    Return "[fldHeRating]"
                Case "colFldHeWeight"
                    Return "[fldHeWeight]"
                Case "colFldNatHazRating"
                    Return "[fldNatHazRating]"
                Case "colFldNatHazWeight"
                    Return "[fldNatHazWeight]"
                Case "colFldBcpRating"
                    Return "[fldBcpRating]"
                Case "colFldBcpWeight"
                    Return "[fldBcpWeight]"
                Case "colFldHasRatingData"
                    Return "[fldHasRatingData]"
                Case "colFldCreateDate"
                    Return "[fldCreateDate]"
                Case "colFldFacility"
                    Return "[fldFacility]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldGSafeId]", "fldGSafeId", "FldGSafeId", "colFldGSafeId"  
                    Return "colFldGSafeId"
                Case "[fldFileNo]", "fldFileNo", "FldFileNo", "colFldFileNo"  
                    Return "colFldFileNo"
                Case "[fldDivision]", "fldDivision", "FldDivision", "colFldDivision"  
                    Return "colFldDivision"
                Case "[fldCustomAccess]", "fldCustomAccess", "FldCustomAccess", "colFldCustomAccess"  
                    Return "colFldCustomAccess"
                Case "[fldClientLocID]", "fldClientLocID", "FldClientLocID", "colFldClientLocID"  
                    Return "colFldClientLocID"
                Case "[fldAddressStamp]", "fldAddressStamp", "FldAddressStamp", "colFldAddressStamp"  
                    Return "colFldAddressStamp"
                Case "[fldFilePrefix]", "fldFilePrefix", "FldFilePrefix", "colFldFilePrefix"  
                    Return "colFldFilePrefix"
                Case "[fldTivUSD]", "fldTivUSD", "FldTivUSD", "colFldTivUSD"  
                    Return "colFldTivUSD"
                Case "[fldTotalScore]", "fldTotalScore", "FldTotalScore", "colFldTotalScore"  
                    Return "colFldTotalScore"
                Case "[fldTotalScoreRecsComplete]", "fldTotalScoreRecsComplete", "FldTotalScoreRecsComplete", "colFldTotalScoreRecsComplete"  
                    Return "colFldTotalScoreRecsComplete"
                Case "[fldTotalScoreAchievedPercent]", "fldTotalScoreAchievedPercent", "FldTotalScoreAchievedPercent", "colFldTotalScoreAchievedPercent"  
                    Return "colFldTotalScoreAchievedPercent"
                Case "[fldPhysicalProtRating]", "fldPhysicalProtRating", "FldPhysicalProtRating", "colFldPhysicalProtRating"  
                    Return "colFldPhysicalProtRating"
                Case "[fldPhysicalProtWeight]", "fldPhysicalProtWeight", "FldPhysicalProtWeight", "colFldPhysicalProtWeight"  
                    Return "colFldPhysicalProtWeight"
                Case "[fldHeRating]", "fldHeRating", "FldHeRating", "colFldHeRating"  
                    Return "colFldHeRating"
                Case "[fldHeWeight]", "fldHeWeight", "FldHeWeight", "colFldHeWeight"  
                    Return "colFldHeWeight"
                Case "[fldNatHazRating]", "fldNatHazRating", "FldNatHazRating", "colFldNatHazRating"  
                    Return "colFldNatHazRating"
                Case "[fldNatHazWeight]", "fldNatHazWeight", "FldNatHazWeight", "colFldNatHazWeight"  
                    Return "colFldNatHazWeight"
                Case "[fldBcpRating]", "fldBcpRating", "FldBcpRating", "colFldBcpRating"  
                    Return "colFldBcpRating"
                Case "[fldBcpWeight]", "fldBcpWeight", "FldBcpWeight", "colFldBcpWeight"  
                    Return "colFldBcpWeight"
                Case "[fldHasRatingData]", "fldHasRatingData", "FldHasRatingData", "colFldHasRatingData"  
                    Return "colFldHasRatingData"
                Case "[fldCreateDate]", "fldCreateDate", "FldCreateDate", "colFldCreateDate"  
                    Return "colFldCreateDate"
                Case "[fldFacility]", "fldFacility", "FldFacility", "colFldFacility"  
                    Return "colFldFacility"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldGSafeId"
                    Return "Integer"
                Case "colFldFileNo"
                    Return "String"
                Case "colFldDivision"
                    Return "String"
                Case "colFldCustomAccess"
                    Return "String"
                Case "colFldClientLocID"
                    Return "String"
                Case "colFldAddressStamp"
                    Return "String"
                Case "colFldFilePrefix"
                    Return "String"
                Case "colFldTivUSD"
                    Return "Decimal"
                Case "colFldTotalScore"
                    Return "Decimal"
                Case "colFldTotalScoreRecsComplete"
                    Return "Decimal"
                Case "colFldTotalScoreAchievedPercent"
                    Return "Decimal"
                Case "colFldPhysicalProtRating"
                    Return "Decimal"
                Case "colFldPhysicalProtWeight"
                    Return "Decimal"
                Case "colFldHeRating"
                    Return "Decimal"
                Case "colFldHeWeight"
                    Return "Decimal"
                Case "colFldNatHazRating"
                    Return "Decimal"
                Case "colFldNatHazWeight"
                    Return "Decimal"
                Case "colFldBcpRating"
                    Return "Decimal"
                Case "colFldBcpWeight"
                    Return "Decimal"
                Case "colFldHasRatingData"
                    Return "Boolean"
                Case "colFldCreateDate"
                    Return "DateTime"
                Case "colFldFacility"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[TblWhatIfLocation]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldGSafeId]"
        End Function

    End Class
End namespace

