Imports Newtonsoft.Json.Linq

Public Class fsFilter
    Implements IFsItem
    Public Property Logic As String = ""
    Public Property Filters As New List(Of IFsItem)
    Private Property Json As String = ""

    Private Sub New()

    End Sub

    Public Sub New(pLogic As fsFilterOperator)
        Logic = pLogic.ToString().ToLower()
    End Sub

    Public Sub New(pJson As String)

        If pJson <> "" Then
            Dim zjo As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(pJson)

            Json = pJson
            Logic = zjo.Property("logic")

            If Not IsNothing(zjo.Property("filters")) Then
                If zjo.Property("filters").HasValues Then
                    For Each zToken As JToken In zjo.Property("filters").Values
                        If Not IsNothing(zToken("logic")) Then
                            Filters.Add(New fsFilter(zToken.ToString(Newtonsoft.Json.Formatting.None)))
                        Else
                            Filters.Add(New fsFilterDescriptor(zToken.ToString(Newtonsoft.Json.Formatting.None)))
                        End If
                    Next
                End If
            End If
        End If

    End Sub

    Public Sub AppendFilter(pJson As String)
        If pJson <> "" Then
            Dim zFilter As New fsFilter(pJson)
            AppendFilter(zFilter)
        End If
    End Sub

    ''' <summary>
    ''' Appends a filter object with 1 or more filters.  If the filter argument does not contain any sub filters, filter is not appended.
    ''' </summary>
    ''' <param name="pFilter"></param>
    ''' <remarks></remarks>
    Public Sub AppendFilter(pFilter As fsFilter)
        If pFilter.Filters.Count > 0 Then
            If pFilter.ToJSON <> "" Then
                Filters.Add(pFilter)
            End If
        End If
    End Sub

    Public Sub AddDescriptor(pField As String, pOperator As fsFilterDescriptorOperator, pValue As String)
        Filters.Add(New fsFilterDescriptor(pField, pField, pOperator, pValue))
    End Sub

    Public Sub AddDescriptor(pField As String, pTitle As String, pOperator As fsFilterDescriptorOperator, pValue As String)
        Filters.Add(New fsFilterDescriptor(pField, pTitle, pOperator, pValue))
    End Sub

    Public Sub RemoveDescriptor(pField As String, pOperator As fsFilterDescriptorOperator, pValue As String)
        Dim zFilter As New fsFilterDescriptor(pField, pOperator, pValue)
        Dim zDescriptors As List(Of IFsItem) = Filters.FindAll(Function(x) DirectCast(x, fsFilterDescriptor).Field.ToLower = pField.ToLower And DirectCast(x, fsFilterDescriptor).Operator.ToLower = pOperator.ToString().ToLower() And DirectCast(x, fsFilterDescriptor).Value.ToLower = pValue.ToLower).ToList()
        zDescriptors.ForEach(Sub(x) Filters.Remove(x))
    End Sub

    Friend Sub AddDescriptor(pField As String, pOperator As String, pValue As String)
        Dim zT As fsFilterDescriptorOperator
        AddDescriptor(pField, [Enum].Parse(zT.GetType(), pOperator), pValue)
    End Sub

    Friend Sub AddDescriptor(pField As String, pTitle As String, pOperator As String, pValue As String)
        Dim zT As fsFilterDescriptorOperator
        AddDescriptor(pField, pTitle, [Enum].Parse(zT.GetType(), pOperator), pValue)
    End Sub

    Public Function ToSQL() As String Implements IFsItem.ToSQL
        Dim zSB As New Text.StringBuilder()
        If Filters.Count > 0 Then
            zSB.Append(" (")
            For Each zF As IFsItem In Me.Filters
                If Me.Filters.IndexOf(zF) > 0 Then zSB.Append(" " & Logic.ToUpper & " ")
                zSB.Append(zF.ToSQL())
            Next
            zSB.Append(") ")
        End If

        Return zSB.ToString
    End Function

    Public Shared Function IsEmpty(pFilterJSON As String) As Boolean
        Try
            JToken.Parse(pFilterJSON)
            Dim zFs As fsFilter = fsFilter.FromJSON(pFilterJSON)
            Return Not CBool(zFs.Filters.Count)
        Catch ex As Exception
            'EAT EXCEPTION AND JUST RETURN TRUE
            Return True
        End Try

    End Function

    Public Shared Function ToSQL(pFilterJSON As String) As String
        Return ToSQL(pFilterJSON, "", "")
    End Function

    Public Shared Function ToSQL(pFilterJSON As String, pFilterJSON2 As String) As String
        Return ToSQL(pFilterJSON, pFilterJSON2, "")
    End Function

    Public Shared Function ToSQL(pFilterJSON As String, pFilterJSON2 As String, pFilterJSON3 As String) As String
        Dim zSB As New Text.StringBuilder
        If pFilterJSON <> "" Then zSB.Append(New fsFilter(pFilterJSON).ToSQL)
        If pFilterJSON2 <> "" Then zSB.Append(IIf(zSB.Length > 0, " AND ", "") & New fsFilter(pFilterJSON2).ToSQL)
        If pFilterJSON3 <> "" Then zSB.Append(IIf(zSB.Length > 0, " AND ", "") & New fsFilter(pFilterJSON3).ToSQL)
        Return zSB.ToString
    End Function

    Public Overrides Function ToString() As String
        Return "logic: " & Logic
    End Function

    Public Function ToJSON() As String Implements IFsItem.ToJSON
        Return Newtonsoft.Json.JsonConvert.SerializeObject(Me, New fsFilterJsonConveter)
    End Function

    Public Shared Function FromJSON(pFilterJSON As String) As fsFilter
        Try
            Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of fsFilter)(pFilterJSON, {New fsFilterJsonConveter})
        Catch ex As Exception
            Return New fsFilter()
        End Try
    End Function

    Public Function IsEmpty() As Boolean
        Return CBool(Filters.Count)
    End Function

    Public Function ToFilterText() As String Implements IFsItem.ToFilterText

        If Me.Filters.Count > 0 Then
            Dim zSB As New Text.StringBuilder()
            BuildFilterText(zSB)
            zSB.Insert(0, "On ")

            Return zSB.ToString
        Else
            Return ""
        End If

    End Function

    Public Shared Function ToFilterText(pFilterJSON As String) As String
        If pFilterJSON = "" Then
            Return ""
        Else
            Return fsFilter.FromJSON(pFilterJSON).ToFilterText()
        End If
    End Function

    Private Sub GetFilterDescriptors(pLogic As String, pFilters As List(Of IFsItem), ByRef pList As List(Of fsFilterDescriptor))
        For Each pItem As IFsItem In pFilters
            If TypeOf (pItem) Is fsFilter Then
                Dim zFilter As fsFilter = pItem
                GetFilterDescriptors(zFilter.Logic, zFilter.Filters, pList)
            Else
                pList.Add(pItem)
            End If
        Next
    End Sub

    Friend Sub BuildFilterText(pFilterText As Text.StringBuilder)
        Dim zTextInfo As System.Globalization.TextInfo = System.Globalization.CultureInfo.CurrentCulture.TextInfo
        Dim zDescriptorList As New List(Of fsFilterDescriptor)
        GetFilterDescriptors(Me.Logic, Me.Filters, zDescriptorList)

        Dim zFieldGroupList As IEnumerable(Of IGrouping(Of String, fsFilterDescriptor)) = zDescriptorList.GroupBy(Of String)(Function(x) x.Field).ToList()
        For Each zFieldGroup As IGrouping(Of String, fsFilterDescriptor) In zFieldGroupList

            Dim zFieldKey As String = zTextInfo.ToTitleCase(zFieldGroup.Key)
            Dim zFieldTitle As String = zFieldGroup.First.Title

            If zFieldGroupList.ToList.IndexOf(zFieldGroup) > 0 Or pFilterText.Length > 0 Then pFilterText.Append(" and ")

            Dim zOperatorGroupList As List(Of IGrouping(Of String, fsFilterDescriptor)) = zFieldGroup.ToList.GroupBy(Of String)(Function(x) x.FilterOperatorText).ToList()
            For Each zOperatorGroup As IGrouping(Of String, IFsItem) In zOperatorGroupList

                Dim zOperatorTextKey As String = zOperatorGroup.Key
                pFilterText.Append(zFieldTitle & zOperatorTextKey & Join(zOperatorGroup.ToList.Select(Function(x) "[" & DirectCast(x, fsFilterDescriptor).Value & "]").ToArray, ",") & "; ")

            Next

        Next

    End Sub

    Private Class fsFilterJsonConveter
        Inherits Newtonsoft.Json.JsonConverter

        Public Overrides Function CanConvert(objectType As Type) As Boolean
            Return True
        End Function

        Public Overrides Function ReadJson(reader As Newtonsoft.Json.JsonReader, objectType As Type, existingValue As Object, serializer As Newtonsoft.Json.JsonSerializer) As Object
            existingValue = New fsFilter
            ReadFilterJson(JObject.Load(reader), existingValue)
            Return existingValue
        End Function

        Public Overrides Sub WriteJson(writer As Newtonsoft.Json.JsonWriter, value As Object, serializer As Newtonsoft.Json.JsonSerializer)
            Dim zFilter As fsFilter = value
            WriteFilterJson(writer, zFilter)
        End Sub

        Private Sub ReadFilterJson(pObj As JObject, ByRef filter As fsFilter)
            filter.Json = pObj.ToString(Newtonsoft.Json.Formatting.None, Nothing)
            filter.Logic = pObj.Property("logic").Value
            Dim zFilters As JArray = pObj.Property("filters").Value
            For Each zObj As JObject In zFilters
                If zObj.Property("logic") IsNot Nothing Then
                    Dim zNewFilter As New fsFilter
                    ReadFilterJson(zObj, zNewFilter)
                    filter.Filters.Add(zNewFilter)
                Else
                    filter.AddDescriptor(zObj.Property("field").Value, zObj.Property("operator").Value, zObj.Property("value").Value)
                End If
            Next
        End Sub

        Private Sub WriteFilterJson(ByRef writer As Newtonsoft.Json.JsonWriter, value As fsFilter)
            writer.WriteStartObject()
            writer.WritePropertyName("logic")
            writer.WriteValue(value.Logic)
            writer.WritePropertyName("filters")
            writer.WriteStartArray()
            For Each zF As Object In value.Filters
                If TypeOf zF Is fsFilter Then WriteFilterJson(writer, zF)
                If TypeOf zF Is fsFilterDescriptor Then WriteFilterDescriptorJson(writer, zF)
            Next
            writer.WriteEndArray()
            writer.WriteEndObject()
        End Sub

        Private Sub WriteFilterDescriptorJson(ByRef writer As Newtonsoft.Json.JsonWriter, value As fsFilterDescriptor)
            writer.WriteStartObject()
            writer.WritePropertyName("field")
            writer.WriteValue(value.Field)

            writer.WritePropertyName("operator")
            writer.WriteValue(value.Operator)

            writer.WritePropertyName("value")
            writer.WriteValue(value.Value)
            writer.WriteEndObject()
        End Sub

    End Class

    Private Class fsFilterDescriptor
        Implements IFsItem

        Public Property Field As String
        Public Property Title As String
        Public Property [Operator] As String
        Public Property Value As String
        Private Property Json As String

        Public Sub New(pField As String, pOperator As fsFilterDescriptorOperator, pValue As String)
            Me.Field = pField
            Me.Operator = pOperator.ToString
            Me.Value = pValue
            Me.Title = pField
            Json = Newtonsoft.Json.JsonConvert.SerializeObject(Me)
        End Sub

        Public Sub New(pField As String, pFieldTitle As String, pOperator As fsFilterDescriptorOperator, pValue As String)
            Me.Field = pField
            Me.Operator = pOperator.ToString
            Me.Value = pValue
            Me.Title = pFieldTitle
            Json = Newtonsoft.Json.JsonConvert.SerializeObject(Me)
        End Sub

        Public Sub New(pJson As String)
            Dim zjo As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(pJson)
            Json = pJson
            Field = zjo("field")
            [Operator] = zjo("operator")
            Value = zjo("value")
        End Sub

        Public Function ToSQL() As String Implements IFsItem.ToSQL
            Select Case [Operator]
                Case "contains"
                    Return "[" & Field & "] LIKE '%" & Value & "%'"
                Case "doesnotcontain", "isnot"
                    Return "[" & Field & "] NOT LIKE '%" & Value & "%'"
                Case "endswith"
                    Return "[" & Field & "] LIKE '%" & Value & "'"
                Case "eq"
                    Return "[" & Field & "] = '" & Value & "'"
                Case "neq"
                    Return "[" & Field & "] <>  '" & Value & "'"
                Case "startswith"
                    Return "[" & Field & "] LIKE '" & Value & "%'"
                Case "lt"
                    Return "[" & Field & "] < " & Value
                Case "lte"
                    Return "[" & Field & "] <= " & Value
                Case "gt"
                    Return "[" & Field & "] > " & Value
                Case "gte"
                    Return "[" & Field & "] >= " & Value
                Case Else
                    Return ""
            End Select
        End Function

        Public Function FilterOperatorText() As String
            Select Case [Operator]
                Case "contains"
                    Return " to contain "
                Case "doesnotcontain", "isnot"
                    Return " to not contain "
                Case "endswith"
                    Return " ends with'"
                Case "eq"
                    Return " equals "
                Case "neq"
                    Return " not equal to "
                Case "startswith"
                    Return " starts with "
                Case "lt"
                    Return " less than "
                Case "lte"
                    Return " less than or equal "
                Case "gt"
                    Return " greater than "
                Case "gte"
                    Return " greater than or equal "
                Case Else
                    Return ""
            End Select
        End Function

        Public Overrides Function ToString() As String
            Return Field & " " & [Operator] & " " & Value
        End Function

        Public Function ToFilterText() As String Implements IFsItem.ToFilterText
            Return Field & FilterOperatorText() & Value
        End Function

        Public Function ToJSON() As String Implements IFsItem.ToJSON
            Dim zDict As New Dictionary(Of String, String)
            zDict.Add("Field", Field)
            zDict.Add("Operator", [Operator])
            zDict.Add("Value", Value)
            Return Newtonsoft.Json.JsonConvert.SerializeObject(zDict)
        End Function

    End Class

End Class

Public Class fsSort
    Private _list As New List(Of fsSortDescriptor)

    Public Sub New(pJson As String)

        If Not String.IsNullOrEmpty(pJson) Then
            Dim zJToken As JToken = JRaw.Parse(pJson)

            If zJToken.Type = JTokenType.Array Then
                For Each zObject As JObject In zJToken
                    _list.Add(New fsSortDescriptor(zObject("field"), zObject("dir")))
                Next
            ElseIf zJToken.Type = JTokenType.Object Then
                _list.Add(New fsSortDescriptor(zJToken("field"), zJToken("dir")))
            End If
        End If

    End Sub

    Public Function ToSQL() As String
        Dim zS As String = ""
        For Each zSortItem As fsSortDescriptor In _list
            If zS.Length > 0 Then zS = zS & ", "
            zS = zS & zSortItem.ToSQL()
        Next
        Return zS
    End Function

    Public Shared Function ToSQL(pSortJSON As String) As String
        Return New fsSort(pSortJSON).ToSQL()
    End Function

    Public Shared Function ToSortText(pSortJSON As String) As String
        Dim fs As New fsSort(pSortJSON)
        Dim sb As New Text.StringBuilder()

        If fs._list.Count > 0 Then

            For Each item As fsSortDescriptor In fs._list
                sb.AppendLine(item.ToString)
            Next

            Dim text As String = sb.ToString.Replace(vbNewLine, ", ")

            'remove trailing comma
            Return Left(text, text.Length - 2)

        Else
            Return ""
        End If

    End Function

    Private Class fsSortDescriptor
   
        Public Property Field As String
        Public Property Dir As String

        Public Sub New(pField As String, pDir As String)
            Me.Field = pField
            Me.Dir = pDir
        End Sub

        Public Function ToSQL() As String
            Return "[" & Field & "] " & Dir.ToUpper
        End Function

        Public Function ToText() As String
            Return Field & " " & Dir.ToUpper
        End Function

        Public Shared Function ToSQL(pSortJSON As String) As String
            Return New fsSort(pSortJSON).ToSQL
        End Function

        Public Overrides Function ToString() As String
            Return ToText()
        End Function

    End Class

End Class

Public Enum fsFilterOperator
    [And] = 1
    [Or]
End Enum

Public Enum fsFilterDescriptorOperator
    contains = 1
    doesnotcontain
    endswith
    eq
    neq
    startswith
    Lt
    lte
    gt
    gte
End Enum




