Public Class UtilFilter
    Private mFilterCount As Integer = 0

    Public Structure strFilterData
        Public SeqNum As Integer
        Public GroupNum As Integer
        Public ObjectLevel As Integer
        Public ArrayLevel As Integer
        Public Logic As String
        Public FilterField As String
        Public FilterOperator As String
        Public FilterValue As String
    End Structure

    '"[{"field":"City","dir":"asc"}]"
    Public Structure strSortData
        Public SeqNum As Integer
        Public SortField As String
        Public SortDirection As String
    End Structure

    Public SortText As String = ""
    Public FilterText As String = ""

    Public mFilterData() As strFilterData
    Public mSortData() As strSortData

    Private Sub DebugFilterData()
        Dim zNdx As Integer = 0

        For zNdx = 0 To UBound(mFilterData)
            Dim zDebugFilterData As String = ""
            zDebugFilterData = zDebugFilterData & mFilterData(zNdx).SeqNum.ToString
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).GroupNum.ToString
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).ObjectLevel.ToString
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).ArrayLevel.ToString
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).Logic
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).FilterField
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).FilterOperator
            zDebugFilterData = zDebugFilterData & " " & mFilterData(zNdx).FilterValue
            Debug.Print(zDebugFilterData)
        Next zNdx
    End Sub

    Public Function IsCustom(pGroupNum As Integer) As Boolean
        Dim zReturn As Boolean = False
        Dim zNdx As Integer = 0
        Dim zRefGroupNum As Integer = pGroupNum
        Dim zCountGroup As Integer = 0
        Dim zCountEq As Integer = 0
        Dim zCountNeq As Integer = 0

        For zNdx = 0 To UBound(mFilterData)
            If mFilterData(zNdx).GroupNum = zRefGroupNum And Not mFilterData(zNdx).FilterField Is Nothing Then
                zCountGroup = zCountGroup + 1
                Select Case mFilterData(zNdx).FilterOperator
                    Case "eq"
                        zCountEq = zCountEq + 1
                    Case "neq"
                        zCountNeq = zCountNeq + 1
                End Select
            End If
        Next zNdx

        If zCountGroup <> zCountEq And zCountGroup <> zCountNeq Then zReturn = True

        Return zReturn

    End Function

    Private Function GetFilterField(pNdx As Integer) As String
        Dim zReturn As String = ""

        Try
            zReturn = mFilterData(pNdx).FilterField
        Catch ex As Exception
            'Index must not exist - eat it.
        End Try

        Return zReturn
    End Function

    Public Sub SetSort(pJSON As String, ByRef pMaker As GRC.Connect.Libraries.CoreLib.UtilSQLMaker)
        If pJSON Is Nothing Then Exit Sub

        SortText = ""

        Dim zNdx As Integer = 0
        Dim zJSON As String = pJSON
        Dim zConditionText As String = ""

        Diagnostics.Debug.Print(zJSON)

        ReDim mSortData(0)
        Call ReadSortData(pJSON)

        For zNdx = 0 To UBound(mSortData)
            If Not mSortData(zNdx).SortField Is Nothing Then
                If SortText.Length > 0 Then SortText = SortText & ", "
                SortText = SortText & mSortData(zNdx).SortField
                If mSortData(zNdx).SortDirection.ToLower = "asc" Then
                    pMaker.OrderBy.Add(mSortData(zNdx).SortField, UtilSQLMaker.SQLSortDirection.Asc)
                    SortText = SortText & " Ascending"
                Else
                    pMaker.OrderBy.Add(mSortData(zNdx).SortField, UtilSQLMaker.SQLSortDirection.Desc)
                    SortText = SortText & " Descending"
                End If
            End If
        Next
    End Sub

    Public Function SetFilter(pJSON As String, ByRef pMaker As UtilSQLMaker) As Integer
        If pJSON Is Nothing Then
            Return 0
            Exit Function
        End If

        Dim zNdx As Integer = 0
        Dim zJSON As String = pJSON
        Dim zConditionText As String = ""

        'Diagnostics.Debug.Print(zJSON)

        'zJSON = Replace(zJSON, SafeWrap("filters"), SafeWrap("lstFilters"), 1, -1, CompareMethod.Text)
        'zJSON = Replace(zJSON, SafeWrap("logic"), SafeWrap("strLogic"), 1, -1, CompareMethod.Text)
        'zJSON = Replace(zJSON, SafeWrap("field"), SafeWrap("strField"), 1, -1, CompareMethod.Text)
        'zJSON = Replace(zJSON, SafeWrap("operator"), SafeWrap("strOperator"), 1, -1, CompareMethod.Text)
        'zJSON = Replace(zJSON, SafeWrap("value"), SafeWrap("strValue"), 1, -1, CompareMethod.Text)

        Diagnostics.Debug.Print(zJSON)

        ReDim mFilterData(0)
        Call ReadData(pJSON)
        Call DebugFilterData()

        Dim zSQLLogicOperator As String = GetTopLogic()

        mFilterCount = 0
        FilterText = "On "
        For zNdx = 0 To UBound(mFilterData)
            If Not mFilterData(zNdx).FilterField Is Nothing Then
                If IsCustom(mFilterData(zNdx).GroupNum) Then
                    'Custom Filter
                    pMaker.Where.OpenParenthesis()
                    zNdx = BuildCustomGroupFilter(zNdx, mFilterData(zNdx).GroupNum, pMaker)
                    pMaker.Where.CloseParenthesis()
                Else
                    'Picklist filter
                    Dim zColumnName As String = mFilterData(zNdx).FilterField
                    Dim zInList As New List(Of String)
                    Dim zCompare As Integer = UtilSQLMaker.SQLComparisonOperator.In
                    Dim zOperator As Integer = UtilSQLMaker.SQLLogicOperator.AND
                    Dim zFilterOperator As String = ""

                    zInList.Clear()
                    zNdx = GetPickedValues(mFilterData(zNdx).ObjectLevel, mFilterData(zNdx).ArrayLevel, zColumnName, zInList, zFilterOperator)
                    zConditionText = " to be equal to "

                    If zFilterOperator = "neq" Then
                        zCompare = UtilSQLMaker.SQLComparisonOperator.NotIn
                        zConditionText = " to be not equal to "
                    End If

                    pMaker.Where.Add(zColumnName, zCompare, zInList.ToArray, "")
                    mFilterCount = mFilterCount + 1
                    FilterText = FilterText & zColumnName & zConditionText & "[" & Join(zInList.ToArray, "], [") & "];"
                End If

                If mFilterData(zNdx).GroupNum <> MaxGroups() Then
                    If zSQLLogicOperator = "and" Then
                        pMaker.Where.AndOperator()
                        FilterText = FilterText & " and on "
                    Else
                        pMaker.Where.OrOperator()
                        FilterText = FilterText & " or on "
                    End If
                End If
            End If
        Next

        If FilterText.Trim.ToLower = "on" Then
            FilterText = ""
        End If

        Return mFilterCount
    End Function

    Private Function MaxGroups() As Integer
        Dim zReturn As Integer = 0
        zReturn = mFilterData(UBound(mFilterData)).GroupNum
        Return zReturn
    End Function

    Private Function CountGroupItems(pGroupNum As Integer) As Integer
        Dim zNdx As Integer = 0
        Dim zReturn As Integer = 0

        For zNdx = 0 To UBound(mFilterData)
            If mFilterData(zNdx).GroupNum = pGroupNum And Not mFilterData(zNdx).FilterField Is Nothing Then
                zReturn = zReturn + 1
            End If
        Next
        Return zReturn
    End Function

    Private Function BuildCustomGroupFilter(pNdx As Integer, pGroupNum As Integer, ByRef pMaker As UtilSQLMaker) As Integer
        Dim zReturn As Integer = pNdx
        Dim zConditionCount As Integer = 0
        Dim zConditionText As String = ""

        For zNdx = pNdx To UBound(mFilterData)
            If mFilterData(zNdx).GroupNum = pGroupNum And Not mFilterData(zNdx).FilterField Is Nothing Then
                Dim zColumnName As String = mFilterData(zNdx).FilterField
                Dim zCompareOperator As String = mFilterData(zNdx).FilterOperator
                Dim zValue As String = mFilterData(zNdx).FilterValue
                Dim zCompare As Integer = UtilSQLMaker.SQLComparisonOperator.Equal
                Dim zSQLLogicOperator As String = GetLogic(mFilterData(zNdx).GroupNum, mFilterData(zNdx).ObjectLevel)

                Select Case zCompareOperator
                    Case "neq"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.NotEqual
                        zConditionText = " to not be equal to "
                    Case "lt"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.LessThan
                        zConditionText = " to be less than "
                    Case "lte"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.LessThanOrEqual
                        zConditionText = " to be less than or equal to "
                    Case "gt"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.GreaterThan
                        zConditionText = " to be greater than "
                    Case "gte"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.GreaterOrEqual
                        zConditionText = " to be greater than or equal to "
                    Case "startswith"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.Like
                        zValue = zValue & "%"
                        zConditionText = " to start with "
                    Case "endswith"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.Like
                        zValue = "%" & zValue
                        zConditionText = " to end with "
                    Case "contains"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.Like
                        zValue = "%" & zValue & "%"
                        zConditionText = " to contain "
                    Case "doesnotcontain"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.NotLike
                        zValue = "%" & zValue & "%"
                        zConditionText = " to not contain "
                    Case "isnotnull"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.IsNotNull
                        zValue = ""
                        zConditionText = " to not be set "
                    Case "isnull"
                        zCompare = UtilSQLMaker.SQLComparisonOperator.IsNull
                        zValue = ""
                        zConditionText = " to be set "
                    Case Else
                        zCompare = UtilSQLMaker.SQLComparisonOperator.Equal
                        zConditionText = " to be equal to "
                End Select

                pMaker.Where.Add(zColumnName, zCompare, zValue, "")
                mFilterCount = mFilterCount + 1
                zConditionCount = zConditionCount + 1
                FilterText = FilterText & zColumnName & zConditionText & "[" & zValue.Replace("%", "") & "];"

                If zConditionCount <> CountGroupItems(mFilterData(zNdx).GroupNum) Then
                    If zSQLLogicOperator = "and" Then
                        pMaker.Where.AndOperator()
                        FilterText = FilterText & " and on "
                    Else
                        pMaker.Where.OrOperator()
                        FilterText = FilterText & " or on "
                    End If
                End If
                zReturn = zNdx
            End If
        Next
        Return zReturn
    End Function

    Private Function GetPickedValues(pObjectLevel As Integer, pArrayLevel As Integer, pFilterField As String, ByRef pInList As List(Of String), ByRef pCompareOperator As String) As Integer
        'Build the pickvalues list and forward the array index to the next filter
        Dim zNdx As Integer = 0
        Dim zReturn As String = ""

        pInList.Clear()
        For zNdx = 0 To UBound(mFilterData)
            If mFilterData(zNdx).ObjectLevel = pObjectLevel And mFilterData(zNdx).ArrayLevel = pArrayLevel And mFilterData(zNdx).FilterField = pFilterField Then
                pInList.Add(mFilterData(zNdx).FilterValue)
                pCompareOperator = mFilterData(zNdx).FilterOperator
                zReturn = zNdx
            End If
        Next
        Return zReturn
    End Function

    Private Function GetTopLogic() As String
        Dim zNdx As Integer = 0
        Dim zReturn As String = ""

        For zNdx = 0 To UBound(mFilterData)
            If mFilterData(zNdx).ObjectLevel = 1 Then
                zReturn = mFilterData(zNdx).Logic

                If IsNothing(zReturn) Then  'BY DEFAULT MAKE TOP LOGIC ="AND"
                    zReturn = "and"
                End If

                Exit For
            End If
        Next
        Return zReturn
    End Function

    Private Function GetLogic(pGroupNum As Integer, pObjectLevel As Integer) As String
        Dim zNdx As Integer = 0
        Dim zReturn As String = ""

        For zNdx = 0 To UBound(mFilterData)
            If mFilterData(zNdx).GroupNum = pGroupNum And mFilterData(zNdx).ObjectLevel = pObjectLevel - 1 Then
                zReturn = mFilterData(zNdx).Logic
                Exit For
            End If
        Next
        Return zReturn
    End Function

    Private Sub ReadSortData(pJSON As String)
        Dim zReader As Newtonsoft.Json.JsonTextReader

        Dim zPropertyName As String = ""

        Dim zNdx As Integer = -1
        zReader = New Newtonsoft.Json.JsonTextReader(New System.IO.StringReader(pJSON))
        While zReader.Read()
            Select Case zReader.TokenType
                Case Newtonsoft.Json.JsonToken.StartObject
                    zNdx = zNdx + 1
                    ReDim Preserve mSortData(zNdx)
                    mSortData(zNdx).SeqNum = zNdx

                Case Newtonsoft.Json.JsonToken.PropertyName
                    zPropertyName = zReader.Value

                Case Newtonsoft.Json.JsonToken.String
                    '"[{"field":"City","dir":"asc"}]"
                    Select Case zPropertyName
                        Case "field"
                            mSortData(zNdx).SortField = zReader.Value
                        Case "dir"
                            mSortData(zNdx).SortDirection = zReader.Value
                    End Select
            End Select

        End While

    End Sub

    Private Sub ReadData(pJSON As String)
        Dim zReader As Newtonsoft.Json.JsonTextReader
        Dim zSets As New UtilKendo.SetsOfCriteriaSets

        Dim zGroupNum As Integer = 0
        Dim zObjectLevel As Integer = 0
        Dim zArrayLevel As Integer = 0
        Dim zPropertyName As String = ""
        Dim zStringValue As String = ""

        Dim zNdx As Integer = -1
        zReader = New Newtonsoft.Json.JsonTextReader(New System.IO.StringReader(pJSON))
        While zReader.Read()
            Select Case zReader.TokenType
                Case Newtonsoft.Json.JsonToken.StartObject
                    'zGroupNum = zGroupNum + 1
                    zObjectLevel = zObjectLevel + 1
                    zNdx = zNdx + 1
                    ReDim Preserve mFilterData(zNdx)
                    mFilterData(zNdx).SeqNum = zNdx
                    mFilterData(zNdx).ObjectLevel = zObjectLevel
                    mFilterData(zNdx).ArrayLevel = zArrayLevel
                    mFilterData(zNdx).GroupNum = zGroupNum

                Case Newtonsoft.Json.JsonToken.PropertyName
                    zPropertyName = zReader.Value

                Case Newtonsoft.Json.JsonToken.String, Newtonsoft.Json.JsonToken.Date, Newtonsoft.Json.JsonToken.Integer, Newtonsoft.Json.JsonToken.Float
                    Select Case zPropertyName
                        Case "logic"
                            mFilterData(zNdx).Logic = zReader.Value
                        Case "field"
                            mFilterData(zNdx).FilterField = zReader.Value
                        Case "operator"
                            mFilterData(zNdx).FilterOperator = zReader.Value
                        Case "value"
                            mFilterData(zNdx).FilterValue = zReader.Value

                            If mFilterData(zNdx).FilterValue = "%" Then
                                zNdx = zNdx - 1 ' Kill the array entry, as filters of % can be optimised out of the query.
                                ReDim Preserve mFilterData(zNdx)
                            End If
                    End Select

                Case Newtonsoft.Json.JsonToken.StartArray
                    zGroupNum = zGroupNum + 1
                    zArrayLevel = zArrayLevel + 1
                    mFilterData(zNdx).ArrayLevel = zArrayLevel
                    mFilterData(zNdx).GroupNum = zGroupNum

                Case Newtonsoft.Json.JsonToken.EndArray
                    zArrayLevel = zArrayLevel - 1

                Case Newtonsoft.Json.JsonToken.EndObject
                    zObjectLevel = zObjectLevel - 1
                    zGroupNum = zGroupNum + 1

            End Select

        End While

    End Sub

    Private Function SafeWrap(pIn As String) As String
        Dim zReturn As String = ""
        Dim zDQ As String = Chr(34)
        zReturn = zDQ + pIn + zDQ + ":"
        Return zReturn
    End Function

End Class
