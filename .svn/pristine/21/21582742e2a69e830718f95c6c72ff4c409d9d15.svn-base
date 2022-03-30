'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblAdminNoteTextBox
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldPracticeGroupCd As New razor.UtilSQLServer.StringDataColumn
        Public colFldTextBoxLabel As New razor.UtilSQLServer.StringDataColumn
        Public colFldEmptyMessage As New razor.UtilSQLServer.StringDataColumn
        Public colFldMaxCharacters As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldSort As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldID.ColumnName = "[fldID]"
            colFldPracticeGroupCd.ColumnName = "[fldPracticeGroupCd]"
            colFldTextBoxLabel.ColumnName = "[fldTextBoxLabel]"
            colFldEmptyMessage.ColumnName = "[fldEmptyMessage]"
            colFldMaxCharacters.ColumnName = "[fldMaxCharacters]"
            colFldSort.ColumnName = "[fldSort]"

            _Members.Add("colFldID", colFldID)
            _Members.Add("colFldPracticeGroupCd", colFldPracticeGroupCd)
            _Members.Add("colFldTextBoxLabel", colFldTextBoxLabel)
            _Members.Add("colFldEmptyMessage", colFldEmptyMessage)
            _Members.Add("colFldMaxCharacters", colFldMaxCharacters)
            _Members.Add("colFldSort", colFldSort)
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
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldID]", "fldID", "FldID", "colFldID"  
                    Return "colFldID"
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
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldID"
                    Return "Integer"
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
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[adm].[tblAdminNoteTextBox]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldID]"
        End Function

    End Class
End namespace

