Imports System.Data.SqlClient

Namespace razor
    Partial Public Class rowVwMetaGridColumns

        Public ReadOnly Property expFieldName() As String
            Get
                Return MakeName(colField.ToString)
            End Get
        End Property

        Private Function MakeName(pIn As String) As String
            Dim zReturn As String = pIn

            If IsNumeric(Left(zReturn, 1)) Then
                zReturn = "_" & zReturn
            End If

            Return zReturn
        End Function
    End Class
End Namespace
