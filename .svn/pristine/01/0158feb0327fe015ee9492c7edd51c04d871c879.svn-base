'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblMetaMapPin
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFldId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldIcon As New razor.UtilSQLServer.StringDataColumn
        Public colFldHeight As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldWidth As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldAnchorX As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldAnchorY As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTextOffsetX As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldTextOffsetY As New razor.UtilSQLServer.IntegerDataColumn
        Public colFldNote As New razor.UtilSQLServer.StringDataColumn
        Public colFldBaseString As New razor.UtilSQLServer.StringDataColumn
        Public colFldMetaColorId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFldId.ColumnName = "[fldId]"
            colFldIcon.ColumnName = "[fldIcon]"
            colFldHeight.ColumnName = "[fldHeight]"
            colFldWidth.ColumnName = "[fldWidth]"
            colFldAnchorX.ColumnName = "[fldAnchorX]"
            colFldAnchorY.ColumnName = "[fldAnchorY]"
            colFldTextOffsetX.ColumnName = "[fldTextOffsetX]"
            colFldTextOffsetY.ColumnName = "[fldTextOffsetY]"
            colFldNote.ColumnName = "[fldNote]"
            colFldBaseString.ColumnName = "[fldBaseString]"
            colFldMetaColorId.ColumnName = "[fldMetaColorId]"

            _Members.Add("colFldId", colFldId)
            _Members.Add("colFldIcon", colFldIcon)
            _Members.Add("colFldHeight", colFldHeight)
            _Members.Add("colFldWidth", colFldWidth)
            _Members.Add("colFldAnchorX", colFldAnchorX)
            _Members.Add("colFldAnchorY", colFldAnchorY)
            _Members.Add("colFldTextOffsetX", colFldTextOffsetX)
            _Members.Add("colFldTextOffsetY", colFldTextOffsetY)
            _Members.Add("colFldNote", colFldNote)
            _Members.Add("colFldBaseString", colFldBaseString)
            _Members.Add("colFldMetaColorId", colFldMetaColorId)
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
                Case "colFldIcon"
                    Return "[fldIcon]"
                Case "colFldHeight"
                    Return "[fldHeight]"
                Case "colFldWidth"
                    Return "[fldWidth]"
                Case "colFldAnchorX"
                    Return "[fldAnchorX]"
                Case "colFldAnchorY"
                    Return "[fldAnchorY]"
                Case "colFldTextOffsetX"
                    Return "[fldTextOffsetX]"
                Case "colFldTextOffsetY"
                    Return "[fldTextOffsetY]"
                Case "colFldNote"
                    Return "[fldNote]"
                Case "colFldBaseString"
                    Return "[fldBaseString]"
                Case "colFldMetaColorId"
                    Return "[fldMetaColorId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[fldId]", "fldId", "FldId", "colFldId"  
                    Return "colFldId"
                Case "[fldIcon]", "fldIcon", "FldIcon", "colFldIcon"  
                    Return "colFldIcon"
                Case "[fldHeight]", "fldHeight", "FldHeight", "colFldHeight"  
                    Return "colFldHeight"
                Case "[fldWidth]", "fldWidth", "FldWidth", "colFldWidth"  
                    Return "colFldWidth"
                Case "[fldAnchorX]", "fldAnchorX", "FldAnchorX", "colFldAnchorX"  
                    Return "colFldAnchorX"
                Case "[fldAnchorY]", "fldAnchorY", "FldAnchorY", "colFldAnchorY"  
                    Return "colFldAnchorY"
                Case "[fldTextOffsetX]", "fldTextOffsetX", "FldTextOffsetX", "colFldTextOffsetX"  
                    Return "colFldTextOffsetX"
                Case "[fldTextOffsetY]", "fldTextOffsetY", "FldTextOffsetY", "colFldTextOffsetY"  
                    Return "colFldTextOffsetY"
                Case "[fldNote]", "fldNote", "FldNote", "colFldNote"  
                    Return "colFldNote"
                Case "[fldBaseString]", "fldBaseString", "FldBaseString", "colFldBaseString"  
                    Return "colFldBaseString"
                Case "[fldMetaColorId]", "fldMetaColorId", "FldMetaColorId", "colFldMetaColorId"  
                    Return "colFldMetaColorId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFldId"
                    Return "Integer"
                Case "colFldIcon"
                    Return "String"
                Case "colFldHeight"
                    Return "Integer"
                Case "colFldWidth"
                    Return "Integer"
                Case "colFldAnchorX"
                    Return "Integer"
                Case "colFldAnchorY"
                    Return "Integer"
                Case "colFldTextOffsetX"
                    Return "Integer"
                Case "colFldTextOffsetY"
                    Return "Integer"
                Case "colFldNote"
                    Return "String"
                Case "colFldBaseString"
                    Return "String"
                Case "colFldMetaColorId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[tblMetaMapPin]"
        End Function

        Private Function _FirstColumn() As String
            Return "[fldId]"
        End Function

    End Class
End namespace

