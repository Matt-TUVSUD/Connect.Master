Public Class JSONFilterItem
    Implements IJSONFilter

    Public Property Field As String
    Public Property [Operator] As JSONFilterOperator.Operators
    Public Property Value As String

    Public Sub New(field As String, [operator] As JSONFilterOperator.Operators, value As String)
        Me.Field = field
        Me.Operator = [operator]
        Me.Value = value
    End Sub

    Public Function ToJSON() As String Implements IJSONFilter.ToJSON
        Dim zSB As New System.Text.StringBuilder

        With zSB
            .Append("{")
            .Append(JSONFilter.DoubleQuote("field") & ":" & JSONFilter.DoubleQuote(Me.Field) & ",")
            .Append(JSONFilter.DoubleQuote("operator") & ":" & JSONFilter.DoubleQuote(JSONFilterOperator.GetOperatorString(Me.Operator).ToString) & ",")
            .Append(JSONFilter.DoubleQuote("value") & ":" & JSONFilter.DoubleQuote(Me.Value))
            .Append("}")
        End With

        Return zSB.ToString

    End Function
End Class
