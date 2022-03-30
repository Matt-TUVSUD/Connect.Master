'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaRatingWeightBM
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldMechMaintWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldElecMaintWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldSparesWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldHEWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldBCPWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldMechEquipWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldElecEquipWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldBoilersWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldProcEquipWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldOccupancyWgt As New razor.UtilSQLServer.DoubleDataColumn
        Public colFldCompSystemWgt As New razor.UtilSQLServer.DoubleDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldMechMaintWgt.ColumnName = "[fldMechMaintWgt]"
            colFldElecMaintWgt.ColumnName = "[fldElecMaintWgt]"
            colFldSparesWgt.ColumnName = "[fldSparesWgt]"
            colFldHEWgt.ColumnName = "[fldHEWgt]"
            colFldBCPWgt.ColumnName = "[fldBCPWgt]"
            colFldMechEquipWgt.ColumnName = "[fldMechEquipWgt]"
            colFldElecEquipWgt.ColumnName = "[fldElecEquipWgt]"
            colFldBoilersWgt.ColumnName = "[fldBoilersWgt]"
            colFldProcEquipWgt.ColumnName = "[fldProcEquipWgt]"
            colFldOccupancyWgt.ColumnName = "[fldOccupancyWgt]"
            colFldCompSystemWgt.ColumnName = "[fldCompSystemWgt]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldMechMaintWgt", colFldMechMaintWgt)
            _Members.Add("colFldElecMaintWgt", colFldElecMaintWgt)
            _Members.Add("colFldSparesWgt", colFldSparesWgt)
            _Members.Add("colFldHEWgt", colFldHEWgt)
            _Members.Add("colFldBCPWgt", colFldBCPWgt)
            _Members.Add("colFldMechEquipWgt", colFldMechEquipWgt)
            _Members.Add("colFldElecEquipWgt", colFldElecEquipWgt)
            _Members.Add("colFldBoilersWgt", colFldBoilersWgt)
            _Members.Add("colFldProcEquipWgt", colFldProcEquipWgt)
            _Members.Add("colFldOccupancyWgt", colFldOccupancyWgt)
            _Members.Add("colFldCompSystemWgt", colFldCompSystemWgt)
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
                Case "colFldMechMaintWgt"
                    Return "[fldMechMaintWgt]"
                Case "colFldElecMaintWgt"
                    Return "[fldElecMaintWgt]"
                Case "colFldSparesWgt"
                    Return "[fldSparesWgt]"
                Case "colFldHEWgt"
                    Return "[fldHEWgt]"
                Case "colFldBCPWgt"
                    Return "[fldBCPWgt]"
                Case "colFldMechEquipWgt"
                    Return "[fldMechEquipWgt]"
                Case "colFldElecEquipWgt"
                    Return "[fldElecEquipWgt]"
                Case "colFldBoilersWgt"
                    Return "[fldBoilersWgt]"
                Case "colFldProcEquipWgt"
                    Return "[fldProcEquipWgt]"
                Case "colFldOccupancyWgt"
                    Return "[fldOccupancyWgt]"
                Case "colFldCompSystemWgt"
                    Return "[fldCompSystemWgt]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldMechMaintWgt]", "fldMechMaintWgt", "FldMechMaintWgt", "colFldMechMaintWgt"  
                    Return "colFldMechMaintWgt"
                Case "[fldElecMaintWgt]", "fldElecMaintWgt", "FldElecMaintWgt", "colFldElecMaintWgt"  
                    Return "colFldElecMaintWgt"
                Case "[fldSparesWgt]", "fldSparesWgt", "FldSparesWgt", "colFldSparesWgt"  
                    Return "colFldSparesWgt"
                Case "[fldHEWgt]", "fldHEWgt", "FldHEWgt", "colFldHEWgt"  
                    Return "colFldHEWgt"
                Case "[fldBCPWgt]", "fldBCPWgt", "FldBCPWgt", "colFldBCPWgt"  
                    Return "colFldBCPWgt"
                Case "[fldMechEquipWgt]", "fldMechEquipWgt", "FldMechEquipWgt", "colFldMechEquipWgt"  
                    Return "colFldMechEquipWgt"
                Case "[fldElecEquipWgt]", "fldElecEquipWgt", "FldElecEquipWgt", "colFldElecEquipWgt"  
                    Return "colFldElecEquipWgt"
                Case "[fldBoilersWgt]", "fldBoilersWgt", "FldBoilersWgt", "colFldBoilersWgt"  
                    Return "colFldBoilersWgt"
                Case "[fldProcEquipWgt]", "fldProcEquipWgt", "FldProcEquipWgt", "colFldProcEquipWgt"  
                    Return "colFldProcEquipWgt"
                Case "[fldOccupancyWgt]", "fldOccupancyWgt", "FldOccupancyWgt", "colFldOccupancyWgt"  
                    Return "colFldOccupancyWgt"
                Case "[fldCompSystemWgt]", "fldCompSystemWgt", "FldCompSystemWgt", "colFldCompSystemWgt"  
                    Return "colFldCompSystemWgt"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldMechMaintWgt"
                    Return "Double"
                Case "colFldElecMaintWgt"
                    Return "Double"
                Case "colFldSparesWgt"
                    Return "Double"
                Case "colFldHEWgt"
                    Return "Double"
                Case "colFldBCPWgt"
                    Return "Double"
                Case "colFldMechEquipWgt"
                    Return "Double"
                Case "colFldElecEquipWgt"
                    Return "Double"
                Case "colFldBoilersWgt"
                    Return "Double"
                Case "colFldProcEquipWgt"
                    Return "Double"
                Case "colFldOccupancyWgt"
                    Return "Double"
                Case "colFldCompSystemWgt"
                    Return "Double"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaRatingWeightBM]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

