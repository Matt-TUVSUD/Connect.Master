

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblAdminNote
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colFldInspectionID As New razor.UtilSQLServer.StringDataColumn
        Public colFldPracticeGroupCd As New razor.UtilSQLServer.StringDataColumn
        Public colFldNoteTextBoxId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldNote As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateBy As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldUpdateBy As New razor.UtilSQLServer.StringDataColumn
        Public colFldUpdateDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldExcludeInXL As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldFileNo.ColumnName = "[fldFileNo]"
            colFldInspectionID.ColumnName = "[fldInspectionID]"
            colFldPracticeGroupCd.ColumnName = "[fldPracticeGroupCd]"
            colFldNoteTextBoxId.ColumnName = "[fldNoteTextBoxId]"
            colFldNote.ColumnName = "[fldNote]"
            colFldCreateBy.ColumnName = "[fldCreateBy]"
            colFldCreateDateTime.ColumnName = "[fldCreateDateTime]"
            colFldUpdateBy.ColumnName = "[fldUpdateBy]"
            colFldUpdateDateTime.ColumnName = "[fldUpdateDateTime]"
            colFldExcludeInXL.ColumnName = "[fldExcludeInXL]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldFileNo", colFldFileNo)
            _Members.Add("colFldInspectionID", colFldInspectionID)
            _Members.Add("colFldPracticeGroupCd", colFldPracticeGroupCd)
            _Members.Add("colFldNoteTextBoxId", colFldNoteTextBoxId)
            _Members.Add("colFldNote", colFldNote)
            _Members.Add("colFldCreateBy", colFldCreateBy)
            _Members.Add("colFldCreateDateTime", colFldCreateDateTime)
            _Members.Add("colFldUpdateBy", colFldUpdateBy)
            _Members.Add("colFldUpdateDateTime", colFldUpdateDateTime)
            _Members.Add("colFldExcludeInXL", colFldExcludeInXL)
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
                Case "colFldFileNo"
                    Return "[fldFileNo]"
                Case "colFldInspectionID"
                    Return "[fldInspectionID]"
                Case "colFldPracticeGroupCd"
                    Return "[fldPracticeGroupCd]"
                Case "colFldNoteTextBoxId"
                    Return "[fldNoteTextBoxId]"
                Case "colFldNote"
                    Return "[fldNote]"
                Case "colFldCreateBy"
                    Return "[fldCreateBy]"
                Case "colFldCreateDateTime"
                    Return "[fldCreateDateTime]"
                Case "colFldUpdateBy"
                    Return "[fldUpdateBy]"
                Case "colFldUpdateDateTime"
                    Return "[fldUpdateDateTime]"
                Case "colFldExcludeInXL"
                    Return "[fldExcludeInXL]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
                Case "[fldFileNo]", "fldFileNo", "FldFileNo", "colFldFileNo"  
                    Return "colFldFileNo"
                Case "[fldInspectionID]", "fldInspectionID", "FldInspectionID", "colFldInspectionID"  
                    Return "colFldInspectionID"
                Case "[fldPracticeGroupCd]", "fldPracticeGroupCd", "FldPracticeGroupCd", "colFldPracticeGroupCd"  
                    Return "colFldPracticeGroupCd"
                Case "[fldNoteTextBoxId]", "fldNoteTextBoxId", "FldNoteTextBoxId", "colFldNoteTextBoxId"  
                    Return "colFldNoteTextBoxId"
                Case "[fldNote]", "fldNote", "FldNote", "colFldNote"  
                    Return "colFldNote"
                Case "[fldCreateBy]", "fldCreateBy", "FldCreateBy", "colFldCreateBy"  
                    Return "colFldCreateBy"
                Case "[fldCreateDateTime]", "fldCreateDateTime", "FldCreateDateTime", "colFldCreateDateTime"  
                    Return "colFldCreateDateTime"
                Case "[fldUpdateBy]", "fldUpdateBy", "FldUpdateBy", "colFldUpdateBy"  
                    Return "colFldUpdateBy"
                Case "[fldUpdateDateTime]", "fldUpdateDateTime", "FldUpdateDateTime", "colFldUpdateDateTime"  
                    Return "colFldUpdateDateTime"
                Case "[fldExcludeInXL]", "fldExcludeInXL", "FldExcludeInXL", "colFldExcludeInXL"  
                    Return "colFldExcludeInXL"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
                Case "colFldFileNo"
                    Return "String"
                Case "colFldInspectionID"
                    Return "String"
                Case "colFldPracticeGroupCd"
                    Return "String"
                Case "colFldNoteTextBoxId"
                    Return "Integer"
                Case "colFldNote"
                    Return "String"
                Case "colFldCreateBy"
                    Return "String"
                Case "colFldCreateDateTime"
                    Return "DateTime"
                Case "colFldUpdateBy"
                    Return "String"
                Case "colFldUpdateDateTime"
                    Return "DateTime"
                Case "colFldExcludeInXL"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[adm].[tblAdminNote]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

