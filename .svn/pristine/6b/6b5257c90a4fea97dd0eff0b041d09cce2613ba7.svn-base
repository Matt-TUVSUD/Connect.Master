Imports System.Data.SqlClient

Namespace razor
    Partial Public Class TblMetaColorAlias

    End Class

    Partial Public Class rowTblMetaColorAlias

        Public Function ToColor() As System.Drawing.Color
            Dim zList As List(Of rowTblMetaColor) = TblMetaColor.LoadByIDX_PK_tblMetaColor(colFldColorId)
            If zList.Count > 0 Then
                Return System.Drawing.ColorTranslator.FromHtml(zList(0).colFldHex)
            Else
                Return System.Drawing.Color.Transparent
            End If
        End Function

    End Class
End Namespace
