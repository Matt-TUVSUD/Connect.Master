Imports System.Data.SqlClient

Namespace razor
    Partial Class TblMetaSourceValueColor

        Public Shared Function LoadBySourceId(pcolFldSourceId As Integer) As List(Of rowTblMetaSourceValueColor)

            Dim zReturn As New List(Of rowTblMetaSourceValueColor)
            Dim zSQL As String = "SELECT * FROM(SELECT ROW_NUMBER() OVER (PARTITION BY FLDFIELDCONTEXT, FLDVALUE ORDER BY FLDSOURCEID DESC) AS RowNo, * FROM TBLMETASOURCEVALUECOLOR WHERE fldSourceID IN (@colFldSourceId,0)) A WHERE RowNo=1  ORDER BY FLDSOURCEID DESC"
            Dim zCmd As New SqlCommand

            zCmd.CommandText = zSQL
            zCmd.Parameters.Add(New SqlParameter("@colFldSourceId", pcolFldSourceId))

            Return TblMetaSourceValueColor.LoadData(zCmd)

        End Function

        Public Shared Function FindColor(list As List(Of rowTblMetaSourceValueColor), colors As List(Of rowTblMetaColor), value As String, Optional dataFieldContext As String = "") As rowTblMetaColor

            Dim zFieldContext As String = "DEFAULT"
            If FieldContextExists(list, dataFieldContext) Then zFieldContext = dataFieldContext

            For Each zItem As rowTblMetaSourceValueColor In list
                If zItem.colFldValue.Equals(value, StringComparison.OrdinalIgnoreCase) And zItem.colFldFieldContext.Equals(zFieldContext, StringComparison.OrdinalIgnoreCase) Then
                    For Each zColor As rowTblMetaColor In colors
                        If zColor.colFldId = zItem.colFldColorId Then
                            Return zColor
                        End If
                    Next
                End If
            Next

            Return Nothing

        End Function

        Private Shared Function FieldContextExists(list As List(Of rowTblMetaSourceValueColor), dataFieldContext As String) As Boolean
            For Each zItem As rowTblMetaSourceValueColor In list
                If zItem.colFldFieldContext.Equals(dataFieldContext, StringComparison.OrdinalIgnoreCase) Then
                    Return True
                End If
            Next
            Return False
        End Function


    End Class
End Namespace