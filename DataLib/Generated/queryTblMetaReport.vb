'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaReport
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldFileName As New razor.UtilSQLServer.StringDataColumn
        Public colFldVendorId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSourceId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTypeName As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetaPracticeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldOldRptCode As New razor.UtilSQLServer.StringDataColumn
        Public colFldComment As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldName.ColumnName = "[fldName]"
            colFldFileName.ColumnName = "[fldFileName]"
            colFldVendorId.ColumnName = "[fldVendorId]"
            colFldSourceId.ColumnName = "[fldSourceId]"
            colFldTypeName.ColumnName = "[fldTypeName]"
            colFldMetaPracticeId.ColumnName = "[fldMetaPracticeId]"
            colFldOldRptCode.ColumnName = "[fldOldRptCode]"
            colFldComment.ColumnName = "[fldComment]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldName", colFldName)
            _Members.Add("colFldFileName", colFldFileName)
            _Members.Add("colFldVendorId", colFldVendorId)
            _Members.Add("colFldSourceId", colFldSourceId)
            _Members.Add("colFldTypeName", colFldTypeName)
            _Members.Add("colFldMetaPracticeId", colFldMetaPracticeId)
            _Members.Add("colFldOldRptCode", colFldOldRptCode)
            _Members.Add("colFldComment", colFldComment)
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
                Case "colFldName"
                    Return "[fldName]"
                Case "colFldFileName"
                    Return "[fldFileName]"
                Case "colFldVendorId"
                    Return "[fldVendorId]"
                Case "colFldSourceId"
                    Return "[fldSourceId]"
                Case "colFldTypeName"
                    Return "[fldTypeName]"
                Case "colFldMetaPracticeId"
                    Return "[fldMetaPracticeId]"
                Case "colFldOldRptCode"
                    Return "[fldOldRptCode]"
                Case "colFldComment"
                    Return "[fldComment]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldName]", "fldName", "FldName", "colFldName"  
                    Return "colFldName"
                Case "[fldFileName]", "fldFileName", "FldFileName", "colFldFileName"  
                    Return "colFldFileName"
                Case "[fldVendorId]", "fldVendorId", "FldVendorId", "colFldVendorId"  
                    Return "colFldVendorId"
                Case "[fldSourceId]", "fldSourceId", "FldSourceId", "colFldSourceId"  
                    Return "colFldSourceId"
                Case "[fldTypeName]", "fldTypeName", "FldTypeName", "colFldTypeName"  
                    Return "colFldTypeName"
                Case "[fldMetaPracticeId]", "fldMetaPracticeId", "FldMetaPracticeId", "colFldMetaPracticeId"  
                    Return "colFldMetaPracticeId"
                Case "[fldOldRptCode]", "fldOldRptCode", "FldOldRptCode", "colFldOldRptCode"  
                    Return "colFldOldRptCode"
                Case "[fldComment]", "fldComment", "FldComment", "colFldComment"  
                    Return "colFldComment"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldName"
                    Return "String"
                Case "colFldFileName"
                    Return "String"
                Case "colFldVendorId"
                    Return "Integer"
                Case "colFldSourceId"
                    Return "Integer"
                Case "colFldTypeName"
                    Return "String"
                Case "colFldMetaPracticeId"
                    Return "Integer"
                Case "colFldOldRptCode"
                    Return "String"
                Case "colFldComment"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaReport]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

