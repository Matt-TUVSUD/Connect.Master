'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaUnitMeasurement
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldUnitSysId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldName As New razor.UtilSQLServer.StringDataColumn
        Public colFldAbbreviation As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldUnitSysId.ColumnName = "[fldUnitSysId]"
            colFldName.ColumnName = "[fldName]"
            colFldAbbreviation.ColumnName = "[fldAbbreviation]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldUnitSysId", colFldUnitSysId)
            _Members.Add("colFldName", colFldName)
            _Members.Add("colFldAbbreviation", colFldAbbreviation)
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
                Case "colFldUnitSysId"
                    Return "[fldUnitSysId]"
                Case "colFldName"
                    Return "[fldName]"
                Case "colFldAbbreviation"
                    Return "[fldAbbreviation]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldUnitSysId]", "fldUnitSysId", "FldUnitSysId", "colFldUnitSysId"  
                    Return "colFldUnitSysId"
                Case "[fldName]", "fldName", "FldName", "colFldName"  
                    Return "colFldName"
                Case "[fldAbbreviation]", "fldAbbreviation", "FldAbbreviation", "colFldAbbreviation"  
                    Return "colFldAbbreviation"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldUnitSysId"
                    Return "Integer"
                Case "colFldName"
                    Return "String"
                Case "colFldAbbreviation"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaUnitMeasurement]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

