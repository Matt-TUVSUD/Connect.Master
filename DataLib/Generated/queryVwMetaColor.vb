'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwMetaColor
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldColor As New razor.UtilSQLServer.StringDataColumn
        Public colFldHex As New razor.UtilSQLServer.StringDataColumn
        Public colFldR As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldG As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldB As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldA As New razor.UtilSQLServer.DecimalDataColumn
        Public colUseForeColorHex As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldColor.ColumnName = "[fldColor]"
            colFldHex.ColumnName = "[fldHex]"
            colFldR.ColumnName = "[fldR]"
            colFldG.ColumnName = "[fldG]"
            colFldB.ColumnName = "[fldB]"
            colFldA.ColumnName = "[fldA]"
            colUseForeColorHex.ColumnName = "[UseForeColorHex]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldColor", colFldColor)
            _Members.Add("colFldHex", colFldHex)
            _Members.Add("colFldR", colFldR)
            _Members.Add("colFldG", colFldG)
            _Members.Add("colFldB", colFldB)
            _Members.Add("colFldA", colFldA)
            _Members.Add("colUseForeColorHex", colUseForeColorHex)
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
                Case "colFldColor"
                    Return "[fldColor]"
                Case "colFldHex"
                    Return "[fldHex]"
                Case "colFldR"
                    Return "[fldR]"
                Case "colFldG"
                    Return "[fldG]"
                Case "colFldB"
                    Return "[fldB]"
                Case "colFldA"
                    Return "[fldA]"
                Case "colUseForeColorHex"
                    Return "[UseForeColorHex]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldColor]", "fldColor", "FldColor", "colFldColor"  
                    Return "colFldColor"
                Case "[fldHex]", "fldHex", "FldHex", "colFldHex"  
                    Return "colFldHex"
                Case "[fldR]", "fldR", "FldR", "colFldR"  
                    Return "colFldR"
                Case "[fldG]", "fldG", "FldG", "colFldG"  
                    Return "colFldG"
                Case "[fldB]", "fldB", "FldB", "colFldB"  
                    Return "colFldB"
                Case "[fldA]", "fldA", "FldA", "colFldA"  
                    Return "colFldA"
                Case "[UseForeColorHex]", "UseForeColorHex", "UseForeColorHex", "colUseForeColorHex"  
                    Return "colUseForeColorHex"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldColor"
                    Return "String"
                Case "colFldHex"
                    Return "String"
                Case "colFldR"
                    Return "Integer"
                Case "colFldG"
                    Return "Integer"
                Case "colFldB"
                    Return "Integer"
                Case "colFldA"
                    Return "Decimal"
                Case "colUseForeColorHex"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwMetaColor]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

