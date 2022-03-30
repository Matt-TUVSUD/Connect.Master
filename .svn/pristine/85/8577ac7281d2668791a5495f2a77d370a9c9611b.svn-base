Public Class JSONFilterOperator
    Public Enum Operators
        Contains
        DoesNotContain
        StartsWith
        EndsWith
        Equal
        NotEqual
        LessThan
        LessThanEqualTo
        GreaterThan
        GreaterThanEqualTo
        [IsNot]
        [Is]
    End Enum

    Public Shared Function GetOperatorString(value As Operators) As String
        Select Case value
            Case Operators.Contains, Operators.Is
                Return "contains"
            Case Operators.DoesNotContain, Operators.IsNot
                Return "doesnotcontain"
            Case Operators.EndsWith
                Return "endswith"
            Case Operators.Equal
                Return "eq"
            Case Operators.NotEqual
                Return "neq"
            Case Operators.StartsWith
                Return "startswith"
            Case Operators.LessThan
                Return "lt"
            Case Operators.LessThanEqualTo
                Return "lte"
            Case Operators.GreaterThan
                Return "gt"
            Case Operators.GreaterThanEqualTo
                Return "gte"
            Case Else
                Return ""
        End Select

    End Function

    Public Shared Function GetOperator(value As String) As Operators
        Select Case value
            Case "contains"
                Return Operators.Contains
            Case "doesnotcontain"
                Return Operators.DoesNotContain
            Case "endswith"
                Return Operators.EndsWith
            Case "eq"
                Return Operators.Equal
            Case "neq"
                Return Operators.NotEqual
            Case "startswith"
                Return Operators.StartsWith
            Case "lt"
                Return Operators.LessThan
            Case "lte"
                Return Operators.LessThanEqualTo
            Case "gt"
                Return Operators.GreaterThan
            Case "gte"
                Return Operators.GreaterThanEqualTo
            Case Else
                Return Nothing
        End Select

    End Function

End Class