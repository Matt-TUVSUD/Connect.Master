

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryGSafeFileNoRadiusParms
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colRadiusParmId As New razor.UtilSQLServer.IntegerDataColumn
        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colLatitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colLongitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colInputRange As New razor.UtilSQLServer.DoubleDataColumn
        Public colUnits As New razor.UtilSQLServer.StringDataColumn
        Public colSearchName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colRadiusParmId.ColumnName = "[RadiusParmId]"
            colGSafeId.ColumnName = "[GSafeId]"
            colLatitude.ColumnName = "[Latitude]"
            colLongitude.ColumnName = "[Longitude]"
            colInputRange.ColumnName = "[InputRange]"
            colUnits.ColumnName = "[Units]"
            colSearchName.ColumnName = "[SearchName]"

            _Members.Add("colRadiusParmId", colRadiusParmId)
            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colLatitude", colLatitude)
            _Members.Add("colLongitude", colLongitude)
            _Members.Add("colInputRange", colInputRange)
            _Members.Add("colUnits", colUnits)
            _Members.Add("colSearchName", colSearchName)
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
                Case "colRadiusParmId"
                    Return "[RadiusParmId]"
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colLatitude"
                    Return "[Latitude]"
                Case "colLongitude"
                    Return "[Longitude]"
                Case "colInputRange"
                    Return "[InputRange]"
                Case "colUnits"
                    Return "[Units]"
                Case "colSearchName"
                    Return "[SearchName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[RadiusParmId]", "RadiusParmId", "RadiusParmId", "colRadiusParmId"  
                    Return "colRadiusParmId"
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[Latitude]", "Latitude", "Latitude", "colLatitude"  
                    Return "colLatitude"
                Case "[Longitude]", "Longitude", "Longitude", "colLongitude"  
                    Return "colLongitude"
                Case "[InputRange]", "InputRange", "InputRange", "colInputRange"  
                    Return "colInputRange"
                Case "[Units]", "Units", "Units", "colUnits"  
                    Return "colUnits"
                Case "[SearchName]", "SearchName", "SearchName", "colSearchName"  
                    Return "colSearchName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colRadiusParmId"
                    Return "Integer"
                Case "colGSafeId"
                    Return "Integer"
                Case "colLatitude"
                    Return "Decimal"
                Case "colLongitude"
                    Return "Decimal"
                Case "colInputRange"
                    Return "Double"
                Case "colUnits"
                    Return "String"
                Case "colSearchName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[GSafeFileNoRadiusParms]"
        End Function

        Private Function _FirstColumn() As String
            Return "[RadiusParmId]"
        End Function

    End Class
End namespace

