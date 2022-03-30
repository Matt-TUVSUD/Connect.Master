'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblGSafePreferences
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colDataName As New razor.UtilSQLServer.StringDataColumn
        Public colDataValue As New razor.UtilSQLServer.StringDataColumn
        Public colDataGroup As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colGSafeId.ColumnName = "[GSafeId]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colDataName.ColumnName = "[DataName]"
            colDataValue.ColumnName = "[DataValue]"
            colDataGroup.ColumnName = "[DataGroup]"

            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colDataName", colDataName)
            _Members.Add("colDataValue", colDataValue)
            _Members.Add("colDataGroup", colDataGroup)
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
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colDataName"
                    Return "[DataName]"
                Case "colDataValue"
                    Return "[DataValue]"
                Case "colDataGroup"
                    Return "[DataGroup]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[DataName]", "DataName", "DataName", "colDataName"  
                    Return "colDataName"
                Case "[DataValue]", "DataValue", "DataValue", "colDataValue"  
                    Return "colDataValue"
                Case "[DataGroup]", "DataGroup", "DataGroup", "colDataGroup"  
                    Return "colDataGroup"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colGSafeId"
                    Return "Integer"
                Case "colFilePrefix"
                    Return "String"
                Case "colDataName"
                    Return "String"
                Case "colDataValue"
                    Return "String"
                Case "colDataGroup"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[GSafePreferences]"
        End Function

        Private Function _FirstColumn() As String
            Return "[GSafeId]"
        End Function

    End Class
End namespace

