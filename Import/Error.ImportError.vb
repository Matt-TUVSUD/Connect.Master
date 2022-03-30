Public Class ImportError
    Inherits [Error]

    Sub New()

    End Sub

    Public Overrides ReadOnly Property Message As String
        Get
            Return ""
        End Get
    End Property
End Class
