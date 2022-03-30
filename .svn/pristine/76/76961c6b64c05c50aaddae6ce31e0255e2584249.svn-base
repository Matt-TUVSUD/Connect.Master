'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblEmailTemplateType
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldTypeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldType As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldTypeId.ColumnName = "[fldTypeId]"
            colFldType.ColumnName = "[fldType]"

            _Members.Add("colFldTypeId", colFldTypeId)
            _Members.Add("colFldType", colFldType)
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
                Case "colFldTypeId"
                    Return "[fldTypeId]"
                Case "colFldType"
                    Return "[fldType]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldTypeId]", "fldTypeId", "FldTypeId", "colFldTypeId"  
                    Return "colFldTypeId"
                Case "[fldType]", "fldType", "FldType", "colFldType"  
                    Return "colFldType"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldTypeId"
                    Return "Integer"
                Case "colFldType"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblEmailTemplateType]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldTypeId]"
        End Function

    End Class
End namespace

