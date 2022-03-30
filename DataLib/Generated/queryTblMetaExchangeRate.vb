'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaExchangeRate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldExchangeRateGroupID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldCurrencyIdFrom As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldCurrencyIdTo As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldExchangeRate As New razor.UtilSQLServer.DoubleDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldExchangeRateGroupID.ColumnName = "[fldExchangeRateGroupID]"
            colFldCurrencyIdFrom.ColumnName = "[fldCurrencyIdFrom]"
            colFldCurrencyIdTo.ColumnName = "[fldCurrencyIdTo]"
            colFldExchangeRate.ColumnName = "[fldExchangeRate]"

            _Members.Add("colFldExchangeRateGroupID", colFldExchangeRateGroupID)
            _Members.Add("colFldCurrencyIdFrom", colFldCurrencyIdFrom)
            _Members.Add("colFldCurrencyIdTo", colFldCurrencyIdTo)
            _Members.Add("colFldExchangeRate", colFldExchangeRate)
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
                Case "colFldCurrencyIdFrom"
                    Return "[fldCurrencyIdFrom]"
                Case "colFldCurrencyIdTo"
                    Return "[fldCurrencyIdTo]"
                Case "colFldExchangeRate"
                    Return "[fldExchangeRate]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldExchangeRateGroupID]", "fldExchangeRateGroupID", "FldExchangeRateGroupID", "colFldExchangeRateGroupID"  
                    Return "colFldExchangeRateGroupID"
                Case "[fldCurrencyIdFrom]", "fldCurrencyIdFrom", "FldCurrencyIdFrom", "colFldCurrencyIdFrom"  
                    Return "colFldCurrencyIdFrom"
                Case "[fldCurrencyIdTo]", "fldCurrencyIdTo", "FldCurrencyIdTo", "colFldCurrencyIdTo"  
                    Return "colFldCurrencyIdTo"
                Case "[fldExchangeRate]", "fldExchangeRate", "FldExchangeRate", "colFldExchangeRate"  
                    Return "colFldExchangeRate"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldExchangeRateGroupID"
                    Return "Integer"
                Case "colFldCurrencyIdFrom"
                    Return "Integer"
                Case "colFldCurrencyIdTo"
                    Return "Integer"
                Case "colFldExchangeRate"
                    Return "Double"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaExchangeRate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldExchangeRateGroupID]"
        End Function

    End Class
End namespace

