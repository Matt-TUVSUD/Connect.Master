Public Class JSONFilterLogic
    Public Enum Operators
        [And]
        [Or]
    End Enum

    Public Shared Function GetOperatorString(value As Operators) As String
        Select Case value
            Case Operators.And
                Return "and"
            Case Operators.Or
                Return "or"
            Case Else
                Return ""
        End Select

    End Function

End Class
