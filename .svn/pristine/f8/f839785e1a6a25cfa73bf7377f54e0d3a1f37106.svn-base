'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaGridColumnHeaderAttributes
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldDescription As New razor.UtilSQLServer.StringDataColumn
        Public colClass As New razor.UtilSQLServer.StringDataColumn
        Public colStyle As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldDescription.ColumnName = "[fldDescription]"
            colClass.ColumnName = "[class]"
            colStyle.ColumnName = "[style]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldDescription", colFldDescription)
            _Members.Add("colClass", colClass)
            _Members.Add("colStyle", colStyle)
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
                Case "colFldDescription"
                    Return "[fldDescription]"
                Case "colClass"
                    Return "[class]"
                Case "colStyle"
                    Return "[style]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldDescription]", "fldDescription", "FldDescription", "colFldDescription"  
                    Return "colFldDescription"
                Case "[class]", "class", "Class", "colClass"  
                    Return "colClass"
                Case "[style]", "style", "Style", "colStyle"  
                    Return "colStyle"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldDescription"
                    Return "String"
                Case "colClass"
                    Return "String"
                Case "colStyle"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaGridColumnHeaderAttributes]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

