Public Class ValidationErrorCollection
    Inherits List(Of ValidationError)

    Public Sub New(ByVal pValidationErrorType As ValidationError.ValidationErrorType, ByVal pErrorDetail As Dictionary(Of String, Object))
        Dim zValidationError As New ValidationError(pValidationErrorType, pErrorDetail)
        Me.Add(zValidationError)
    End Sub

    Public Sub New()

    End Sub
    Public ReadOnly Property IsSuccessful As Boolean
        Get
            If Me.Count = 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

End Class
