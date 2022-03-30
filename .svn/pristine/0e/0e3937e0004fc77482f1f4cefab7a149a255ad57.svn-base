'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblBatchProcessingFileNo
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldSetId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldFileNo As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldSetId.ColumnName = "[fldSetId]"
            colFldFileNo.ColumnName = "[fldFileNo]"

            _Members.Add("colFldSetId", colFldSetId)
            _Members.Add("colFldFileNo", colFldFileNo)
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
                Case "colFldSetId"
                    Return "[fldSetId]"
                Case "colFldFileNo"
                    Return "[fldFileNo]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldSetId]", "fldSetId", "FldSetId", "colFldSetId"  
                    Return "colFldSetId"
                Case "[fldFileNo]", "fldFileNo", "FldFileNo", "colFldFileNo"  
                    Return "colFldFileNo"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldSetId"
                    Return "Integer"
                Case "colFldFileNo"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblBatchProcessingFileNo]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldSetId]"
        End Function

    End Class
End namespace

