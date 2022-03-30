'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaLossEstimate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldExchangeRateGroupID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldCurrencyId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldLossEstimateTypeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIndexNo As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldRangeText As New razor.UtilSQLServer.StringDataColumn
        Public colFldRangeDisplay As New razor.UtilSQLServer.StringDataColumn
        Public colFldRangeValueLow As New razor.UtilSQLServer.LongDataColumn
        Public colFldRangeValueHigh As New razor.UtilSQLServer.LongDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldExchangeRateGroupID.ColumnName = "[fldExchangeRateGroupID]"
            colFldCurrencyId.ColumnName = "[fldCurrencyId]"
            colFldLossEstimateTypeId.ColumnName = "[fldLossEstimateTypeId]"
            colFldIndexNo.ColumnName = "[fldIndexNo]"
            colFldRangeText.ColumnName = "[fldRangeText]"
            colFldRangeDisplay.ColumnName = "[fldRangeDisplay]"
            colFldRangeValueLow.ColumnName = "[fldRangeValueLow]"
            colFldRangeValueHigh.ColumnName = "[fldRangeValueHigh]"

            _Members.Add("colFldExchangeRateGroupID", colFldExchangeRateGroupID)
            _Members.Add("colFldCurrencyId", colFldCurrencyId)
            _Members.Add("colFldLossEstimateTypeId", colFldLossEstimateTypeId)
            _Members.Add("colFldIndexNo", colFldIndexNo)
            _Members.Add("colFldRangeText", colFldRangeText)
            _Members.Add("colFldRangeDisplay", colFldRangeDisplay)
            _Members.Add("colFldRangeValueLow", colFldRangeValueLow)
            _Members.Add("colFldRangeValueHigh", colFldRangeValueHigh)
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
                Case "colFldExchangeRateGroupID"
                    Return "[fldExchangeRateGroupID]"
                Case "colFldCurrencyId"
                    Return "[fldCurrencyId]"
                Case "colFldLossEstimateTypeId"
                    Return "[fldLossEstimateTypeId]"
                Case "colFldIndexNo"
                    Return "[fldIndexNo]"
                Case "colFldRangeText"
                    Return "[fldRangeText]"
                Case "colFldRangeDisplay"
                    Return "[fldRangeDisplay]"
                Case "colFldRangeValueLow"
                    Return "[fldRangeValueLow]"
                Case "colFldRangeValueHigh"
                    Return "[fldRangeValueHigh]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldExchangeRateGroupID]", "fldExchangeRateGroupID", "FldExchangeRateGroupID", "colFldExchangeRateGroupID"  
                    Return "colFldExchangeRateGroupID"
                Case "[fldCurrencyId]", "fldCurrencyId", "FldCurrencyId", "colFldCurrencyId"  
                    Return "colFldCurrencyId"
                Case "[fldLossEstimateTypeId]", "fldLossEstimateTypeId", "FldLossEstimateTypeId", "colFldLossEstimateTypeId"  
                    Return "colFldLossEstimateTypeId"
                Case "[fldIndexNo]", "fldIndexNo", "FldIndexNo", "colFldIndexNo"  
                    Return "colFldIndexNo"
                Case "[fldRangeText]", "fldRangeText", "FldRangeText", "colFldRangeText"  
                    Return "colFldRangeText"
                Case "[fldRangeDisplay]", "fldRangeDisplay", "FldRangeDisplay", "colFldRangeDisplay"  
                    Return "colFldRangeDisplay"
                Case "[fldRangeValueLow]", "fldRangeValueLow", "FldRangeValueLow", "colFldRangeValueLow"  
                    Return "colFldRangeValueLow"
                Case "[fldRangeValueHigh]", "fldRangeValueHigh", "FldRangeValueHigh", "colFldRangeValueHigh"  
                    Return "colFldRangeValueHigh"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldExchangeRateGroupID"
                    Return "Integer"
                Case "colFldCurrencyId"
                    Return "Integer"
                Case "colFldLossEstimateTypeId"
                    Return "Integer"
                Case "colFldIndexNo"
                    Return "Integer"
                Case "colFldRangeText"
                    Return "String"
                Case "colFldRangeDisplay"
                    Return "String"
                Case "colFldRangeValueLow"
                    Return "Long"
                Case "colFldRangeValueHigh"
                    Return "Long"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaLossEstimate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldExchangeRateGroupID]"
        End Function

    End Class
End namespace

