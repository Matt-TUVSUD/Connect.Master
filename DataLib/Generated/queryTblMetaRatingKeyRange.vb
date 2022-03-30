'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaRatingKeyRange
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldKeyId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldRating As New razor.UtilSQLServer.StringDataColumn
        Public colFldDescription As New razor.UtilSQLServer.StringDataColumn
        Public colFldScoreLow As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldScoreHigh As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldMetaColorId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldPSRatingKey As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldKeyId.ColumnName = "[fldKeyId]"
            colFldRating.ColumnName = "[fldRating]"
            colFldDescription.ColumnName = "[fldDescription]"
            colFldScoreLow.ColumnName = "[fldScoreLow]"
            colFldScoreHigh.ColumnName = "[fldScoreHigh]"
            colFldMetaColorId.ColumnName = "[fldMetaColorId]"
            colFldPSRatingKey.ColumnName = "[fldPSRatingKey]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldKeyId", colFldKeyId)
            _Members.Add("colFldRating", colFldRating)
            _Members.Add("colFldDescription", colFldDescription)
            _Members.Add("colFldScoreLow", colFldScoreLow)
            _Members.Add("colFldScoreHigh", colFldScoreHigh)
            _Members.Add("colFldMetaColorId", colFldMetaColorId)
            _Members.Add("colFldPSRatingKey", colFldPSRatingKey)
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
                Case "colFldId"
                    Return "[fldId]"
                Case "colFldKeyId"
                    Return "[fldKeyId]"
                Case "colFldRating"
                    Return "[fldRating]"
                Case "colFldDescription"
                    Return "[fldDescription]"
                Case "colFldScoreLow"
                    Return "[fldScoreLow]"
                Case "colFldScoreHigh"
                    Return "[fldScoreHigh]"
                Case "colFldMetaColorId"
                    Return "[fldMetaColorId]"
                Case "colFldPSRatingKey"
                    Return "[fldPSRatingKey]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldKeyId]", "fldKeyId", "FldKeyId", "colFldKeyId"  
                    Return "colFldKeyId"
                Case "[fldRating]", "fldRating", "FldRating", "colFldRating"  
                    Return "colFldRating"
                Case "[fldDescription]", "fldDescription", "FldDescription", "colFldDescription"  
                    Return "colFldDescription"
                Case "[fldScoreLow]", "fldScoreLow", "FldScoreLow", "colFldScoreLow"  
                    Return "colFldScoreLow"
                Case "[fldScoreHigh]", "fldScoreHigh", "FldScoreHigh", "colFldScoreHigh"  
                    Return "colFldScoreHigh"
                Case "[fldMetaColorId]", "fldMetaColorId", "FldMetaColorId", "colFldMetaColorId"  
                    Return "colFldMetaColorId"
                Case "[fldPSRatingKey]", "fldPSRatingKey", "FldPSRatingKey", "colFldPSRatingKey"  
                    Return "colFldPSRatingKey"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldKeyId"
                    Return "Integer"
                Case "colFldRating"
                    Return "String"
                Case "colFldDescription"
                    Return "String"
                Case "colFldScoreLow"
                    Return "Double"
                Case "colFldScoreHigh"
                    Return "Double"
                Case "colFldMetaColorId"
                    Return "Integer"
                Case "colFldPSRatingKey"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaRatingKeyRange]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

