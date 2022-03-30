Public Class JSONFilter
    Implements IJSONFilter

    Public Property Logic As JSONFilterLogic.Operators
    Public Property Filters As New List(Of IJSONFilter)

    Public Function ToJSON() As String Implements IJSONFilter.ToJSON
        Dim zSB As New System.Text.StringBuilder
        With zSB
            .Append("{")
            .Append(JSONFilter.DoubleQuote("logic") & ":" & JSONFilter.DoubleQuote(JSONFilterLogic.GetOperatorString(Me.Logic).ToString) & ",")
            .Append(JSONFilter.DoubleQuote("filters") & ":[")
            For Each zFilter As IJSONFilter In Filters
                .Append(zFilter.ToJSON)
                If Not Filters.Last.Equals(zFilter) Then .Append(",")
            Next
            .Append("]")
            .Append("}")
        End With
        Return zSB.ToString
    End Function

    Public Shared Function DoubleQuote(value As String) As String
        value = Chr(34) & value & Chr(34)
        Return value
    End Function

    ''' <summary>
    ''' Merges two filters using AND logic
    ''' </summary>
    ''' <param name="pFilterString1"></param>
    ''' <param name="pFilterString2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Merge(pFilterString1 As String, pFilterString2 As String) As String
        Dim zF1 As InternalJSONFilter = Newtonsoft.Json.JsonConvert.DeserializeObject(Of InternalJSONFilter)(pFilterString1)
        Dim zF2 As InternalJSONFilter = Newtonsoft.Json.JsonConvert.DeserializeObject(Of InternalJSONFilter)(pFilterString2)

        Dim zJsonFilter As New JSONFilter
        zJsonFilter.Logic = zF1.Logic
        zJsonFilter.Filters.AddRange(zF1.ToJsonFilter().Filters.ToArray)
        zJsonFilter.Filters.AddRange(zF2.ToJsonFilter().Filters.ToArray)

        Return zJsonFilter.ToJSON()
    End Function


    ''' <summary>
    ''' This class is solely for converting a filter string to a .NET object.  The JSONFilter class implements a interface which could not be instantiated by Newtonsoft.
    ''' </summary>
    ''' <remarks></remarks>
    Private Class InternalJSONFilter
        Public Property Logic As JSONFilterLogic.Operators
        Public Property Filters As New List(Of Object)

        Public Function ToJsonFilter() As JSONFilter
            Dim zJSONFilter As New JSONFilter
            zJSONFilter.Logic = Me.Logic
            For Each zFilter As Newtonsoft.Json.Linq.JObject In Filters

                'CHECK TO SEE IF THE CURRENT ZFILTER VARIABLE HAS A "FILTERS" PROPERTY AND ASSIGN IT
                Dim zFilterItems As Newtonsoft.Json.Linq.JArray = zFilter.Value(Of Newtonsoft.Json.Linq.JArray)("filters")

                'IF THE ZFILTER OBJECT DOES NOT HAVE A "FILTER" PROPERTY, THEN ZFILTER IS A FILTERITEM OBJECT
                If IsNothing(zFilterItems) Then
                    Dim zItem As New JSONFilterItem(zFilter.GetValue("field"), JSONFilterOperator.GetOperator(zFilter.GetValue("operator")), zFilter.GetValue("value"))
                    zJSONFilter.Filters.Add(zItem)
                Else
                    For Each zFilterItem As Newtonsoft.Json.Linq.JObject In zFilterItems
                        If zFilterItem.Properties.Contains(zFilterItem.Property("field")) Then
                            Dim zItem As New JSONFilterItem(zFilterItem.GetValue("field"), JSONFilterOperator.GetOperator(zFilterItem.GetValue("operator")), zFilterItem.GetValue("value"))
                            zJSONFilter.Filters.Add(zItem)
                        End If
                    Next
                End If
            Next

            Return zJSONFilter
        End Function

    End Class

End Class
