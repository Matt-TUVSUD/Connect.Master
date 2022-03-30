Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices
Imports GRC.Connect.Libraries.CoreLib.CustomExtensions.StringExtensions
Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilSQLMaker

    ''' <summary>
    ''' This class gathers the data from SQL Server and create lists that contain dynamic objects schemed after the database.  To be used by the UtilSQLMaker class.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SQLMetaData
        ''' <summary>
        ''' Represents a collection of records in the tblMetaGrid table. 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Grids As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaGridColumn table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GridColumns As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaMapPin table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MapPins As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaReport table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Reports As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the TblMetaChart table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Charts As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaSource table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Source As New List(Of Object)
        ''' <summary>
        ''' A class that contains the raw SQL
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Raw As RawMeta
        ''' <summary>
        ''' Represents a collection of records in the sys.all_columns system view
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SourceFields As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the sys.parameters system view.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SourceProcParameters As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaParameter table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AllParameters As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaSqlFunction table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AllSQLFunctions As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaSQLFunctionParameter table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AllSQLFunctionsParms As New List(Of Object)
        ''' <summary>
        ''' Represents a collection of records in the tblMetaSourceJoin table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AllJoins As New List(Of Object)

        Public Function GetRawField(field As String) As String
            Dim zReturn As String = ""
            Dim zIdx As Integer = -1
            For Each zSourceField As Object In SourceFields
                zIdx += 1
                If zSourceField.name.ToString.ToLower = field.ToLower Then Return Raw.RawFields(zIdx)
            Next
            Return zReturn
        End Function

        'This function simple does some string manipulation of the currenct value (or raw field) to determine if this is the field were trying to find.
        Private Function GetRawField(raw As String, fieldToFind As String) As String

            'Try to find the field by spliting at the periods in the name
            Dim zValue() As String = Split(raw, ".")
            Dim zFiltered() As String = zValue.Filter(fieldToFind, FilterLogic.Equals)
            If zFiltered.Count = 1 Then
                Return raw
            End If

            'Try to find the field by spliting at the quote in the name
            zValue = Split(raw, "'")
            zFiltered = zValue.Filter(fieldToFind, FilterLogic.Equals)
            If zFiltered.Count = 1 Then
                Return raw
            End If

            'Try to find the field by spliting at the brackets in the name
            Dim value1 = Replace(Replace(raw, "[", "<bracket>"), "]", "<bracket>")
            zValue = Split(value1, "<bracket>")
            zFiltered = zValue.Filter(fieldToFind, FilterLogic.Equals)
            If zFiltered.Count = 1 Then
                Return raw
            End If

            'Try to find the field by splitting at the spaces and remove CASE statements to avoid any confusion.
            Dim value2 = Regex.Replace(raw, "CASE.+?END+?", "", RegexOptions.IgnoreCase)
            zValue = Split(value2, " ")
            zFiltered = zValue.Filter(fieldToFind, FilterLogic.Equals)
            If zFiltered.Count = 1 Then
                Return raw
            End If

            Return ""

        End Function

        Public Function IsSourceView() As Boolean
            If Source(0).fldType = 1 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function GetSourceQualifiedName() As String
            Return "[" & Source(0).fldSchemaName & "].[" & Source(0).fldObjectName & "]"
        End Function

        ''' <summary>
        ''' Returns the tblMetaSourceJoin record based on context
        ''' </summary>
        ''' <param name="metaSourceJoinId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FindMetaSourceJoin(metaSourceJoinId As Integer) As Object
            For Each zJoin In AllJoins
                If zJoin.fldId = metaSourceJoinId Then Return zJoin
            Next

            Return Nothing

        End Function

        Public Function IsJoinRequired() As Boolean
            If Source(0).fldIsJoinRequired Then
                Return True
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Finds a tblMetaParameter object by Id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FindParameter(id) As Object

            For Each zParameter In AllParameters
                If zParameter.fldId = id Then Return zParameter
            Next

            Diagnostics.EventLog.WriteEntry("SQLMetaData", "Could not find MetaParameter [" & id & "]", EventLogEntryType.Error)
            Return Nothing

        End Function

        ''' <summary>
        ''' Finds a tblMetaParameter object by FlagId
        ''' </summary>
        ''' <param name="pFlagId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FindParameter(pFlagId As Integer) As Object

            For Each zParameter In AllParameters
                If zParameter.fldFlagId = pFlagId Then Return zParameter
            Next

            Diagnostics.EventLog.WriteEntry("SQLMetaData", "Could not find MetaParameter with flag id [" & pFlagId & "]", EventLogEntryType.Error)
            Return Nothing

        End Function

        Public Function FindTSQLFunction(rawFieldDefinition) As Object
            For Each zSQLFunction In AllSQLFunctions   'zSQLFunction represents a record in the tblMetaSQLFunction table
                Dim zFunctionName As String = zSQLFunction.fldObjectName
                If rawFieldDefinition.ToLower.Contains(zFunctionName.ToLower) Then
                    Return zSQLFunction
                End If
            Next
            Return Nothing
        End Function

        Public Function ContainsTSQLUserFunction(rawFieldDefinition As String) As Boolean
            If IsNothing(FindTSQLFunction(rawFieldDefinition)) Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Shared Function Create(id As Integer, context As MetaContext) As SQLMetaData

            Dim zProcedureName As String = GetProcedureName(context)
            Dim zCon As New SqlClient.SqlConnection(GRC.Connect.Libraries.CoreLib.UtilDB.ConnectionString)
            Dim zCmd As New SqlClient.SqlCommand(zProcedureName, zCon)
            zCmd.CommandType = CommandType.StoredProcedure
            zCmd.Parameters.Add(New SqlClient.SqlParameter("@Id", id))

            Dim zMetaData As New SQLMetaData
            zCon.Open()
            Using zCon
                Using zCmd
                    Dim zRdr As SqlClient.SqlDataReader = zCmd.ExecuteReader()
                    Do
                        Dim zTypeId As MetaType = Nothing
                        Dim zList As List(Of Object) = Nothing
                        Dim zListPropInfo As Reflection.PropertyInfo = Nothing
                        Dim zListType As Type = Nothing

                        If zRdr.HasRows Then
                            zRdr.Read()
                            zTypeId = zRdr("TypeId")
                            zListPropInfo = zMetaData.GetType.GetProperty(zTypeId.ToString)
                            zListType = zListPropInfo.PropertyType
                            zList = Activator.CreateInstance(zListType)
                            Dim zFields As String() = GetFieldNames(zRdr)
                            Do
                                If zRdr.HasRows Then
                                    zList.GetType.InvokeMember("Add", Reflection.BindingFlags.InvokeMethod, Nothing, zList, {BuildItem(zRdr, zFields)})
                                End If
                            Loop Until zRdr.Read = False

                            zMetaData.GetType.InvokeMember(zTypeId.ToString, Reflection.BindingFlags.SetProperty, Nothing, zMetaData, {zList})
                        End If
                    Loop Until zRdr.NextResult = False
                End Using
            End Using

            If zMetaData.Source.Count > 0 Then
                zMetaData.Raw = New RawMeta(zMetaData.Source(0).definition, zMetaData)
            Else
                Dim zEx As New ArgumentException("The source is missing or invalid.", "fldSourceId")
                zEx.Data.Add("Id", id)
                zEx.Data.Add("Context", context.ToString)
                Throw zEx
            End If

            Return zMetaData
        End Function

        Public Shared Function BuildItem(rdr As SqlClient.SqlDataReader, fieldNames As String()) As Object
            Dim zItem As Object = New SQLMetaDynamicObject
            For Each zField As String In fieldNames
                Dim zValue As Object = rdr.GetValue(Array.IndexOf(fieldNames, zField))
                If IsDBNull(zValue) Then
                    zItem.GetType.InvokeMember("Add", Reflection.BindingFlags.InvokeMethod, Nothing, zItem, {zField, ""})
                Else
                    zItem.GetType.InvokeMember("Add", Reflection.BindingFlags.InvokeMethod, Nothing, zItem, {zField, zValue})
                End If

            Next
            Return zItem
        End Function

        Public Shared Function GetFieldNames(reader As SqlClient.SqlDataReader) As String()
            Dim zList As New List(Of String)
            Dim zFieldIndex As Integer = 0

            Do Until zFieldIndex > reader.FieldCount - 1
                zList.Add(reader.GetName(zFieldIndex))
                zFieldIndex += 1
            Loop

            Return zList.ToArray

        End Function

        Public Enum MetaType
            Grids = 10
            GridColumns = 11
            MapPins = 12
            Reports = 20
            Source = 30
            SourceFields = 31
            SourceProcParameters = 50
            AllParameters = 60
            AllSQLFunctions = 70
            AllSQLFunctionsParms = 71
            AllJoins = 80
            Charts = 90
        End Enum

        Public Enum MetaContext
            Grids = 1
            Reports = 2
            Sources = 3
            Charts = 4
            Extracts = 5
            Maps = 6
        End Enum

        Public Enum MetaParameterKind
            Filter = 1
            Setting = 2
        End Enum

        <Flags>
        Public Enum MetaSQLFunctionParameter
            Currency = 1
            Unit = 2
        End Enum


        Private Shared Function GetProcedureName(search As MetaContext) As String
            Select Case search
                Case MetaContext.Grids, MetaContext.Extracts, MetaContext.Maps
                    Return "spGetGridMeta"

                Case MetaContext.Reports
                    Return "spGetReportMeta"

                Case MetaContext.Sources
                    Return "spGetSourceMeta"

                Case MetaContext.Charts
                    Return "spGetChartMeta"

                Case Else
                    Return ""
            End Select

        End Function

        Public Class SQLMetaDynamicObject
            Inherits Dynamic.DynamicObject

            ' The inner dictionary.
            Dim dictionary As New Dictionary(Of String, Object)(System.StringComparer.OrdinalIgnoreCase)

            Public Overrides Function TrySetMember(
            ByVal binder As System.Dynamic.SetMemberBinder,
            ByVal value As Object) As Boolean

                ' Converting the property name to lowercase
                ' so that property names become case-insensitive.
                dictionary(binder.Name.ToLower()) = value

                ' You can always add a value to a dictionary,
                ' so this method always returns true.
                Return True
            End Function

            Public Overrides Function TryGetMember(
            ByVal binder As System.Dynamic.GetMemberBinder,
            ByRef result As Object) As Boolean

                ' Converting the property name to lowercase
                ' so that property names become case-insensitive.
                Dim name As String = binder.Name.ToLower()

                ' If the property name is found in a dictionary,
                ' set the result parameter to the property value and return true.
                ' Otherwise, return false.
                Return dictionary.TryGetValue(name, result)
            End Function

            Public Sub Add(propName As String, propValue As Object)
                dictionary.Add(propName, propValue)
            End Sub

            Public ReadOnly Property Keys() As String()
                Get
                    Return dictionary.Keys.ToArray
                End Get
            End Property

            Public ReadOnly Property Values() As Object()
                Get
                    Return dictionary.Values.ToArray
                End Get
            End Property

            Public Function GetValue(pField As String) As Object
                Dim zVal As Object = Nothing
                If dictionary.TryGetValue(pField, zVal) Then
                    Return zVal
                Else
                    Return ""
                End If
            End Function

        End Class

        ''' <summary>
        ''' This class contains the raw definition from the source object
        ''' </summary>
        ''' <remarks></remarks>
        Public Class RawMeta
            Public RawFields As String()
            Public RawSelect As String
            Public RawFrom As String
            Public RawWhere As String
            Private Def As String = ""
            Private FieldList As List(Of Object)

            Public Sub New(definition As String, sqlMeta As SQLMetaData)
                Def = definition
                FieldList = sqlMeta.SourceFields
                If sqlMeta.Source(0).fldType = TblMetaSource.MetaSourceType.View Then
                    RemoveComments()
                    RemoveWhiteSpace()
                    RemoveDistinctTopKeywords()
                    RemoveDeclaration()
                    ExtractSelectStatement()
                    ExtractFields1()
                    ExtractFromStatement1()
                    ExtractWhereStatement()
                End If

            End Sub

            Private Sub RemoveWhiteSpace()
                Dim zTwoOrMoreSpacesRegexString As String = "\s{2,}"
                Dim regex3 As New Regex(zTwoOrMoreSpacesRegexString, RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                Def = regex3.Replace(Def, " ")
                Def = Replace(Def, Chr(9), " ")
                Def = Replace(Def, Chr(10), " ")
                Def = Replace(Def, Chr(11), " ")
                Def = Replace(Def, Chr(12), " ")
                Def = Replace(Def, Chr(13), " ")
                Def = Def.Trim
            End Sub

            Private Sub RemoveComments()
                Dim zClearSQLCommentsRegextString As String = "((\/\*+)(\s+)(.+)(\s+)(\*+\/))|(--.+)"
                Def = Regex.Replace(Def, zClearSQLCommentsRegextString, "")
            End Sub

            Private Sub RemoveDistinctTopKeywords()
                Dim zStrings() As String = Strings.Split(Def, ",")
                Dim zFindValue As String = zStrings(0)
                Dim zReplaceValue = Regex.Replace(zFindValue, "(\s*DISTINCT\s*)|(\s*TOP\s*\(\d+\))|(\s*TOP\s*\s*\d+\s)|(\s*PERCENT\s*)", " ", RegexOptions.Singleline Or RegexOptions.IgnoreCase)
                Def = Replace(Def, zFindValue, zReplaceValue)
            End Sub

            Private Sub RemoveDeclaration()
                Dim zClearDeclarationRegexString As String = "(CREATE)\b.+?(AS)\b"
                Dim zRegex As New Regex(zClearDeclarationRegexString, RegexOptions.IgnoreCase)
                Def = zRegex.Replace(Def, "", 1)
            End Sub

            Private Sub ExtractSelectStatement1()

                Dim zSelectStatemenRegex1 As String = "(\(.+?SELECT.+ FROM)"
                Dim zSelectStatementRegex As String = "(\s?SELECT.+?\sFROM)"

                If Regex.IsMatch(Def, zSelectStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline) Then
                    Dim zMatch As Match = Regex.Match(Def, zSelectStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
                    RawSelect = Trim(zMatch.Value)

                    If RawSelect.ToUpper.StartsWith("SELECT") And RawSelect.Contains("*") And RawSelect.Length < 20 Then
                        If Regex.IsMatch(Def, zSelectStatemenRegex1, RegexOptions.IgnoreCase Or RegexOptions.Singleline) Then
                            zMatch = Regex.Match(Def, zSelectStatemenRegex1, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
                            RawSelect = Trim(zMatch.Value)
                            RawSelect = Trim(Right(RawSelect, RawSelect.Length - 1))
                        End If
                    End If

                    If RawSelect.ToUpper.EndsWith("FROM") Then
                        RawSelect = Trim(Left(RawSelect, RawSelect.Length - 4))
                    End If

                End If
            End Sub

            Private Sub ExtractSelectStatement()
                Dim zSelectStatementRegex As String = "(\s?SELECT.+?\sFROM)"
                If Regex.IsMatch(Def, zSelectStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline) Then
                    Dim zMatch As Match = Regex.Match(Def, zSelectStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
                    Dim zSS As String = zMatch.Value
                    RawSelect = Regex.Replace(zSS, "(FROM\s$)|(FROM$)", "", RegexOptions.IgnoreCase)
                End If
            End Sub

            Private Sub ExtractFromStatement1()

                Dim zFromStatementRegex As String = "([^a-z]FROM.+\s*WHERE)|([^a-z]FROM.+\s*ORDER BY)|([^a-z]FROM.+\[^a-z]GROUP BY)|([^a-z]FROM.+)"

                If Regex.IsMatch(Def, zFromStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Multiline) Then
                    Dim zMatch As Match = Regex.Match(Def, zFromStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Multiline)

                    RawFrom = zMatch.Value

                    If RawFrom.ToUpper.EndsWith("WHERE") Then
                        RawFrom = RawFrom.Substring(0, RawFrom.Length - 5)
                    End If

                    If RawFrom.ToUpper.EndsWith("ORDER BY") Then
                        RawFrom = RawFrom.Substring(0, RawFrom.Length - 8)
                    End If

                    If RawFrom.ToUpper.EndsWith("GROUP BY") Then
                        RawFrom = RawFrom.Substring(0, RawFrom.Length - 8)
                    End If

                    If RawFrom.Contains(";") Then
                        RawFrom = RawFrom.Replace(";", "")
                    End If

                End If
            End Sub

            Private Sub ExtractFromStatement()
                Dim zFromStatementRegex As String = "(\sFROM.+?\sWHERE)|(\sFROM.+?\sGROUP BY)|(\sFROM.+?\sORDER BY)|(\sFROM.+)"
                If Regex.IsMatch(Def, zFromStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline) Then
                    Dim zMatch As Match = Regex.Match(Def, zFromStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
                    Dim zSS As String = zMatch.Value
                    RawFrom = Regex.Replace(zSS, "(WHERE\s$)|(WHERE$)", "", RegexOptions.IgnoreCase)
                    RawFrom = Regex.Replace(RawFrom, "(GROUP BY\s$)|(GROUP BY)", "", RegexOptions.IgnoreCase)
                    RawFrom = Regex.Replace(RawFrom, "(ORDER BY\s$)|(ORDER BY)", "", RegexOptions.IgnoreCase)
                    RawFrom = Regex.Replace(RawFrom, "(;)", "", RegexOptions.IgnoreCase)
                End If
            End Sub

            Private Sub ExtractWhereStatement()
                Dim zWhereStatementRegex As String = "(\sWHERE.+?\sGROUP BY)|(\sWHERE.+?\sORDER BY)|(\sWHERE.+)"
                If Regex.IsMatch(Def, zWhereStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline) Then
                    Dim zMatch As Match = Regex.Match(Def, zWhereStatementRegex, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
                    Dim zSS As String = zMatch.Value
                    RawWhere = Regex.Replace(zSS, "(GROUP BY\s$)|(GROUP BY)", "", RegexOptions.IgnoreCase)
                    RawWhere = Regex.Replace(RawWhere, "(ORDER BY\s$)|(ORDER BY)", "", RegexOptions.IgnoreCase)
                    RawWhere = Regex.Replace(RawWhere, "(;)", "", RegexOptions.IgnoreCase)
                End If
            End Sub

            Private Sub ExtractFields1()
                Dim zSelectFromRegex As String = "(\s*SELECT\s+)|(\s+FROM\s*)"
                Dim zSelect As String = Regex.Replace(RawSelect, zSelectFromRegex, "", RegexOptions.IgnoreCase)
                Dim zSelectPartArray() As String = Split(zSelect, ",")
                Dim zSQLSB As New StringBuilder
                Dim zOpenParenthesisCount As Integer = 0
                Dim zFieldList As New List(Of String)

                For Each zPart As String In zSelectPartArray
                    Dim zChars As Char() = zPart.ToCharArray()
                    For Each zChar As Char In zChars
                        If zChar.ToString = "(" Then zOpenParenthesisCount += 1
                        If zChar.ToString = ")" Then zOpenParenthesisCount -= 1
                    Next

                    If Not Convert.ToBoolean(zOpenParenthesisCount) Then
                        If zSQLSB.Length > 0 Then
                            zSQLSB.Append(zPart)
                            zFieldList.Add(zSQLSB.ToString)
                            zSQLSB.Clear()
                        Else
                            zFieldList.Add(zPart)
                        End If
                    Else
                        zSQLSB.Append(zPart)
                        zSQLSB.Append(",")
                    End If
                Next

                Me.RawFields = zFieldList.ToArray

            End Sub

        End Class

    End Class

End Class

