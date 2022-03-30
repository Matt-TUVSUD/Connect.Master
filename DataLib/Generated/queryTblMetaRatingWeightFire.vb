'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaRatingWeightFire
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldPhysicalProtectionWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldHumanElementWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldNaturalHazardsProtectionWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldBusinessContinuityWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldFloodWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldEarthquakeWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldWindstormWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldConstructionWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldOccupancyWeightGRC As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldOtherWeightGRC As New razor.UtilSQLServer.DoubleDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldPhysicalProtectionWeightGRC.ColumnName = "[fldPhysicalProtectionWeightGRC]"
            colFldHumanElementWeightGRC.ColumnName = "[fldHumanElementWeightGRC]"
            colFldNaturalHazardsProtectionWeightGRC.ColumnName = "[fldNaturalHazardsProtectionWeightGRC]"
            colFldBusinessContinuityWeightGRC.ColumnName = "[fldBusinessContinuityWeightGRC]"
            colFldFloodWeightGRC.ColumnName = "[fldFloodWeightGRC]"
            colFldEarthquakeWeightGRC.ColumnName = "[fldEarthquakeWeightGRC]"
            colFldWindstormWeightGRC.ColumnName = "[fldWindstormWeightGRC]"
            colFldConstructionWeightGRC.ColumnName = "[fldConstructionWeightGRC]"
            colFldOccupancyWeightGRC.ColumnName = "[fldOccupancyWeightGRC]"
            colFldOtherWeightGRC.ColumnName = "[fldOtherWeightGRC]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldPhysicalProtectionWeightGRC", colFldPhysicalProtectionWeightGRC)
            _Members.Add("colFldHumanElementWeightGRC", colFldHumanElementWeightGRC)
            _Members.Add("colFldNaturalHazardsProtectionWeightGRC", colFldNaturalHazardsProtectionWeightGRC)
            _Members.Add("colFldBusinessContinuityWeightGRC", colFldBusinessContinuityWeightGRC)
            _Members.Add("colFldFloodWeightGRC", colFldFloodWeightGRC)
            _Members.Add("colFldEarthquakeWeightGRC", colFldEarthquakeWeightGRC)
            _Members.Add("colFldWindstormWeightGRC", colFldWindstormWeightGRC)
            _Members.Add("colFldConstructionWeightGRC", colFldConstructionWeightGRC)
            _Members.Add("colFldOccupancyWeightGRC", colFldOccupancyWeightGRC)
            _Members.Add("colFldOtherWeightGRC", colFldOtherWeightGRC)
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
                Case "colFldPhysicalProtectionWeightGRC"
                    Return "[fldPhysicalProtectionWeightGRC]"
                Case "colFldHumanElementWeightGRC"
                    Return "[fldHumanElementWeightGRC]"
                Case "colFldNaturalHazardsProtectionWeightGRC"
                    Return "[fldNaturalHazardsProtectionWeightGRC]"
                Case "colFldBusinessContinuityWeightGRC"
                    Return "[fldBusinessContinuityWeightGRC]"
                Case "colFldFloodWeightGRC"
                    Return "[fldFloodWeightGRC]"
                Case "colFldEarthquakeWeightGRC"
                    Return "[fldEarthquakeWeightGRC]"
                Case "colFldWindstormWeightGRC"
                    Return "[fldWindstormWeightGRC]"
                Case "colFldConstructionWeightGRC"
                    Return "[fldConstructionWeightGRC]"
                Case "colFldOccupancyWeightGRC"
                    Return "[fldOccupancyWeightGRC]"
                Case "colFldOtherWeightGRC"
                    Return "[fldOtherWeightGRC]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldPhysicalProtectionWeightGRC]", "fldPhysicalProtectionWeightGRC", "FldPhysicalProtectionWeightGRC", "colFldPhysicalProtectionWeightGRC"  
                    Return "colFldPhysicalProtectionWeightGRC"
                Case "[fldHumanElementWeightGRC]", "fldHumanElementWeightGRC", "FldHumanElementWeightGRC", "colFldHumanElementWeightGRC"  
                    Return "colFldHumanElementWeightGRC"
                Case "[fldNaturalHazardsProtectionWeightGRC]", "fldNaturalHazardsProtectionWeightGRC", "FldNaturalHazardsProtectionWeightGRC", "colFldNaturalHazardsProtectionWeightGRC"  
                    Return "colFldNaturalHazardsProtectionWeightGRC"
                Case "[fldBusinessContinuityWeightGRC]", "fldBusinessContinuityWeightGRC", "FldBusinessContinuityWeightGRC", "colFldBusinessContinuityWeightGRC"  
                    Return "colFldBusinessContinuityWeightGRC"
                Case "[fldFloodWeightGRC]", "fldFloodWeightGRC", "FldFloodWeightGRC", "colFldFloodWeightGRC"  
                    Return "colFldFloodWeightGRC"
                Case "[fldEarthquakeWeightGRC]", "fldEarthquakeWeightGRC", "FldEarthquakeWeightGRC", "colFldEarthquakeWeightGRC"  
                    Return "colFldEarthquakeWeightGRC"
                Case "[fldWindstormWeightGRC]", "fldWindstormWeightGRC", "FldWindstormWeightGRC", "colFldWindstormWeightGRC"  
                    Return "colFldWindstormWeightGRC"
                Case "[fldConstructionWeightGRC]", "fldConstructionWeightGRC", "FldConstructionWeightGRC", "colFldConstructionWeightGRC"  
                    Return "colFldConstructionWeightGRC"
                Case "[fldOccupancyWeightGRC]", "fldOccupancyWeightGRC", "FldOccupancyWeightGRC", "colFldOccupancyWeightGRC"  
                    Return "colFldOccupancyWeightGRC"
                Case "[fldOtherWeightGRC]", "fldOtherWeightGRC", "FldOtherWeightGRC", "colFldOtherWeightGRC"  
                    Return "colFldOtherWeightGRC"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldPhysicalProtectionWeightGRC"
                    Return "Double"
                Case "colFldHumanElementWeightGRC"
                    Return "Double"
                Case "colFldNaturalHazardsProtectionWeightGRC"
                    Return "Double"
                Case "colFldBusinessContinuityWeightGRC"
                    Return "Double"
                Case "colFldFloodWeightGRC"
                    Return "Double"
                Case "colFldEarthquakeWeightGRC"
                    Return "Double"
                Case "colFldWindstormWeightGRC"
                    Return "Double"
                Case "colFldConstructionWeightGRC"
                    Return "Double"
                Case "colFldOccupancyWeightGRC"
                    Return "Double"
                Case "colFldOtherWeightGRC"
                    Return "Double"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaRatingWeightFire]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

