

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwAdminNoteTextBox
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldNoteID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldNote As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateBy As New razor.UtilSQLServer.StringDataColumn
        Public colFldCreateDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldUpdateBy As New razor.UtilSQLServer.StringDataColumn
        Public colFldUpdateDateTime As New razor.UtilSQLServer.DateTimeDataColumn
        Public colFldPracticeGroupCd As New razor.UtilSQLServer.StringDataColumn
        Public colFldTextBoxLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFldEmptyMessage As New razor.UtilSQLServer.StringDataColumn
        Public colFldMaxCharacters As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSort As New razor.UtilSQLServer.IntegerDataColumn
        Public colInspectionID As New razor.UtilSQLServer.StringDataColumn
        Public colPracticeCode As New razor.UtilSQLServer.ShortDataColumn
        Public colFldExcludeInXL As New razor.UtilSQLServer.BooleanDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colDisplayText As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldNoteID.ColumnName = "[fldNoteID]"
            colFldNote.ColumnName = "[fldNote]"
            colFldCreateBy.ColumnName = "[fldCreateBy]"
            colFldCreateDateTime.ColumnName = "[fldCreateDateTime]"
            colFldUpdateBy.ColumnName = "[fldUpdateBy]"
            colFldUpdateDateTime.ColumnName = "[fldUpdateDateTime]"
            colFldPracticeGroupCd.ColumnName = "[fldPracticeGroupCd]"
            colFldTextBoxLabel.ColumnName = "[fldTextBoxLabel]"
            colFldEmptyMessage.ColumnName = "[fldEmptyMessage]"
            colFldMaxCharacters.ColumnName = "[fldMaxCharacters]"
            colFldSort.ColumnName = "[fldSort]"
            colInspectionID.ColumnName = "[InspectionID]"
            colPracticeCode.ColumnName = "[PracticeCode]"
            colFldExcludeInXL.ColumnName = "[fldExcludeInXL]"
            colFileNo.ColumnName = "[FileNo]"
            colDisplayText.ColumnName = "[DisplayText]"

            _Members.Add("colFldNoteID", colFldNoteID)
            _Members.Add("colFldNote", colFldNote)
            _Members.Add("colFldCreateBy", colFldCreateBy)
            _Members.Add("colFldCreateDateTime", colFldCreateDateTime)
            _Members.Add("colFldUpdateBy", colFldUpdateBy)
            _Members.Add("colFldUpdateDateTime", colFldUpdateDateTime)
            _Members.Add("colFldPracticeGroupCd", colFldPracticeGroupCd)
            _Members.Add("colFldTextBoxLabel", colFldTextBoxLabel)
            _Members.Add("colFldEmptyMessage", colFldEmptyMessage)
            _Members.Add("colFldMaxCharacters", colFldMaxCharacters)
            _Members.Add("colFldSort", colFldSort)
            _Members.Add("colInspectionID", colInspectionID)
            _Members.Add("colPracticeCode", colPracticeCode)
            _Members.Add("colFldExcludeInXL", colFldExcludeInXL)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colDisplayText", colDisplayText)
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
                Case "colFldNoteID"
                    Return "[fldNoteID]"
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
                Case "colFldPracticeGroupCd"
                    Return "[fldPracticeGroupCd]"
                Case "colFldTextBoxLabel"
                    Return "[fldTextBoxLabel]"
                Case "colFldEmptyMessage"
                    Return "[fldEmptyMessage]"
                Case "colFldMaxCharacters"
                    Return "[fldMaxCharacters]"
                Case "colFldSort"
                    Return "[fldSort]"
                Case "colInspectionID"
                    Return "[InspectionID]"
                Case "colPracticeCode"
                    Return "[PracticeCode]"
                Case "colFldExcludeInXL"
                    Return "[fldExcludeInXL]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colDisplayText"
                    Return "[DisplayText]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldNoteID]", "fldNoteID", "FldNoteID", "colFldNoteID"  
                    Return "colFldNoteID"
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
                Case "[fldPracticeGroupCd]", "fldPracticeGroupCd", "FldPracticeGroupCd", "colFldPracticeGroupCd"  
                    Return "colFldPracticeGroupCd"
                Case "[fldTextBoxLabel]", "fldTextBoxLabel", "FldTextBoxLabel", "colFldTextBoxLabel"  
                    Return "colFldTextBoxLabel"
                Case "[fldEmptyMessage]", "fldEmptyMessage", "FldEmptyMessage", "colFldEmptyMessage"  
                    Return "colFldEmptyMessage"
                Case "[fldMaxCharacters]", "fldMaxCharacters", "FldMaxCharacters", "colFldMaxCharacters"  
                    Return "colFldMaxCharacters"
                Case "[fldSort]", "fldSort", "FldSort", "colFldSort"  
                    Return "colFldSort"
                Case "[InspectionID]", "InspectionID", "InspectionID", "colInspectionID"  
                    Return "colInspectionID"
                Case "[PracticeCode]", "PracticeCode", "PracticeCode", "colPracticeCode"  
                    Return "colPracticeCode"
                Case "[fldExcludeInXL]", "fldExcludeInXL", "FldExcludeInXL", "colFldExcludeInXL"  
                    Return "colFldExcludeInXL"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[DisplayText]", "DisplayText", "DisplayText", "colDisplayText"  
                    Return "colDisplayText"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldNoteID"
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
                Case "colFldPracticeGroupCd"
                    Return "String"
                Case "colFldTextBoxLabel"
                    Return "String"
                Case "colFldEmptyMessage"
                    Return "String"
                Case "colFldMaxCharacters"
                    Return "Integer"
                Case "colFldSort"
                    Return "Integer"
                Case "colInspectionID"
                    Return "String"
                Case "colPracticeCode"
                    Return "Short"
                Case "colFldExcludeInXL"
                    Return "Boolean"
                Case "colFileNo"
                    Return "String"
                Case "colDisplayText"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[adm].[vwAdminNoteTextBox]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldNoteID]"
        End Function

    End Class
End namespace

