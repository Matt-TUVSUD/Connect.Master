'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwAdminViewXLSheet
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTabName As New razor.UtilSQLServer.StringDataColumn
        Public colFldViewName As New razor.UtilSQLServer.StringDataColumn
        Public colFldSheetPosition As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldInclude As New razor.UtilSQLServer.BooleanDataColumn
        Public colFldSQL As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldTabName.ColumnName = "[fldTabName]"
            colFldViewName.ColumnName = "[fldViewName]"
            colFldSheetPosition.ColumnName = "[fldSheetPosition]"
            colFldInclude.ColumnName = "[fldInclude]"
            colFldSQL.ColumnName = "[fldSQL]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldTabName", colFldTabName)
            _Members.Add("colFldViewName", colFldViewName)
            _Members.Add("colFldSheetPosition", colFldSheetPosition)
            _Members.Add("colFldInclude", colFldInclude)
            _Members.Add("colFldSQL", colFldSQL)
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
                Case "colFldID"
                    Return "[fldID]"
                Case "colFldTabName"
                    Return "[fldTabName]"
                Case "colFldViewName"
                    Return "[fldViewName]"
                Case "colFldSheetPosition"
                    Return "[fldSheetPosition]"
                Case "colFldInclude"
                    Return "[fldInclude]"
                Case "colFldSQL"
                    Return "[fldSQL]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
                Case "[fldTabName]", "fldTabName", "FldTabName", "colFldTabName"  
                    Return "colFldTabName"
                Case "[fldViewName]", "fldViewName", "FldViewName", "colFldViewName"  
                    Return "colFldViewName"
                Case "[fldSheetPosition]", "fldSheetPosition", "FldSheetPosition", "colFldSheetPosition"  
                    Return "colFldSheetPosition"
                Case "[fldInclude]", "fldInclude", "FldInclude", "colFldInclude"  
                    Return "colFldInclude"
                Case "[fldSQL]", "fldSQL", "FldSQL", "colFldSQL"  
                    Return "colFldSQL"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
                Case "colFldTabName"
                    Return "String"
                Case "colFldViewName"
                    Return "String"
                Case "colFldSheetPosition"
                    Return "Integer"
                Case "colFldInclude"
                    Return "Boolean"
                Case "colFldSQL"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[adm].[vwAdminViewXLSheet]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

