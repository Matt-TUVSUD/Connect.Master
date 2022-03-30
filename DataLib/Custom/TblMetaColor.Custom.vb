Namespace razor
    Partial Class TblMetaColor

        Public Enum Colors
            White = 1
            Green
            Yellow
            Red
            DarkGreen
            Orange
            Lime
        End Enum

        Public Shared Function Find(list As List(Of rowTblMetaColor), color As Colors) As rowTblMetaColor
            For Each zColor As rowTblMetaColor In list
                If zColor.colFldId = color Then
                    Return zColor
                End If
            Next
            Return Nothing
        End Function

        Public Shared Function LoadAll() As List(Of rowTblMetaColor)
            Return LoadData("SELECT * FROM tblMetaColor")
        End Function

    End Class

    Partial Class rowTblMetaColor
        Public Function ToColor() As System.Drawing.Color
            Return System.Drawing.ColorTranslator.FromHtml(Me.colFldHex)
        End Function
    End Class
End Namespace