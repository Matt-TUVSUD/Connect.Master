Public Class UtilGlobal
    Public Shared Function Coalesce(pValue As Object, pDefault As Object) As Object
        If IsDBNull(pValue) Then Return pDefault
        If IsNothing(pValue) Then Return pDefault
        Return pValue
    End Function
End Class
