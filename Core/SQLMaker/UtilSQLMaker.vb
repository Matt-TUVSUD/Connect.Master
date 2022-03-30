Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilSQLMaker

    Private _Select As SQLSelectList
    Private _Where As SQLWhereList
    Private _OrderBy As SQLOrderByList
    Private _GroupBy As SQLGroupBy
    Private _From As SQLFrom

    Private _Parameters As IUtilSQLMakerParameterInfo

    Private _Id As Integer
    Private _Meta As SQLMetaData
    Private _JoinKeyValue As String
    Private _MetaContext As SQLMetaData.MetaContext
    Private _MapField As String = "" 'Used for determining which PinSnipet and TitleSnippet to get for Mapping

    Public Sub New()
        _Id = 0
        _MetaContext = Nothing
        _Meta = New SQLMetaData
        _Parameters = New UtilSQLMaker.ParameterInfo

        Me._JoinKeyValue = 0
        Me._OrderBy = New SQLOrderByList(Me)
        Me._GroupBy = New SQLGroupBy(Me)
        Me._Where = New SQLWhereList(Me)
        Me._From = New SQLFrom(Me)
        Me._Select = New SQLSelectList(Me)

    End Sub

    Public Sub New(contextID As Integer, context As SQLMetaData.MetaContext, joinToValue As String)

        _Id = contextID
        _MetaContext = context
        _Meta = SQLMetaData.Create(contextID, _MetaContext)
        _Parameters = New UtilSQLMaker.ParameterInfo

        '  WriteTraceInfo()

        Me._JoinKeyValue = joinToValue
        Me._OrderBy = New SQLOrderByList(Me)
        Me._GroupBy = New SQLGroupBy(Me)
        Me._Where = New SQLWhereList(Me)
        Me._From = New SQLFrom(Me)
        Me._Select = New SQLSelectList(Me)

    End Sub

    ''' <summary>
    ''' Constructor to use for generating mapping SQL
    ''' </summary>
    ''' <param name="contextID">The ID of the grid you want to depict in the map.</param>
    ''' <param name="context">The context of the data. Use Maps = 6 for mapping.</param>
    ''' <param name="joinToValue">The value to join to the GSafe tables. Use the user's GSafeGuid.</param>
    ''' <param name="mapField">The field to depict in the map.  This field must be in the base grid view.</param>
    ''' <remarks></remarks>
    Public Sub New(contextID As Integer, context As SQLMetaData.MetaContext, joinToValue As String, mapField As String)
        Me.New(contextID, context, joinToValue)
        _MapField = mapField
    End Sub

    Public ReadOnly Property [Select] As SQLSelectList
        Get
            Return _Select
        End Get
    End Property

    Public ReadOnly Property Where As SQLWhereList
        Get
            Return _Where
        End Get
    End Property

    Public ReadOnly Property OrderBy As SQLOrderByList
        Get
            Return _OrderBy
        End Get
    End Property

    Public Property Parameters As IUtilSQLMakerParameterInfo
        Get
            Return _Parameters
        End Get
        Set(value As IUtilSQLMakerParameterInfo)
            _Parameters = value
        End Set
    End Property

    Public ReadOnly Property RequiredParameters As TblMetaParameter.ParameterFlags
        Get
            If _Meta.Source.Count > 0 Then
                Dim zRequiredParms = CType(_Meta.Source(0).fldParameterFlag, tblMetaParameter.ParameterFlags)
                Return zRequiredParms
            Else
                Return tblMetaParameter.ParameterFlags.None
            End If
        End Get
    End Property

    Public ReadOnly Property RequiredParametersDictionary As Dictionary(Of Integer, TblMetaParameter.ParameterFlags)
        Get
            Dim zReturn As New Dictionary(Of Integer, TblMetaParameter.ParameterFlags)
            Dim zAllParameterFlags() As Integer = [Enum].GetValues(GetType(TblMetaParameter.ParameterFlags))
            For Each zParmFlag As TblMetaParameter.ParameterFlags In zAllParameterFlags
                If zParmFlag And RequiredParameters Then
                    zReturn.Add(zParmFlag, zParmFlag)
                End If
            Next
            Return zReturn
        End Get
    End Property

    Public Function GenerateSQL() As String
        Return _GenerateSQL(False, "", "", "", "")
    End Function

    Public Function GenerateSQL(batchKey As String, dataKey As String, foreignKey As String) As String
        Return _GenerateSQL(True, batchKey, dataKey, foreignKey, "")
    End Function

    Public Function GenerateSQL(batchKey As String, dataKey As String, foreignKey As String, debugInfo As String) As String
        Return _GenerateSQL(True, batchKey, dataKey, foreignKey, debugInfo)
    End Function

    Private Function _GenerateSQL(logSQL As Boolean, batchKey As String, dataKey As String, foreignKey As String, debugInfo As String) As String
        ValidateParameters()

        Dim sb As New StringBuilder
        If _Meta.IsSourceView Then
            CreateBaseSQLSelect(sb)
            AppendJoinTableSelect(sb)
        
            'FOR ANY SELECT STATEMENT OTHER THAN MAPS WE WILL WANT TO ADD A ROWNUMBER AND PAGING
            If _MetaContext <> SQLMetaData.MetaContext.Maps Then
                AppendUserFieldsSelect(sb)
                AppendRowNumberSelect(sb)
                AppendPagingSelect(sb)
            Else
                AppendMapMetaFieldsSelect(sb)
                AppendMapDataFieldsSelect(sb)
                AppendMapFinalSelect(sb)
            End If

            LogIt(logSQL, sb.ToString, batchKey, dataKey, foreignKey, debugInfo)
            TruncateMetaSQL()

            '   Trace.WriteLine("")
            '  Trace.WriteLine(sb.ToString)
            ' Trace.WriteLine("")

        Else
            CreateStoredProcedureBaseSQL(sb)
        End If


            Return sb.ToString
    End Function


    Private Sub LogIt(logSQL As Boolean, SQL As String, batchKey As String, dataKey As String, foreignKey As String, debugInfo As String)
        If logSQL Then
            Dim sqlInsert As String = "INSERT INTO tblMetaSQL (fldSql, fldCreateDate, fldDataKey, fldForeignKey, fldBatchkey, fldDebugInfo) values " & _
                "('" & Replace(SQL, "'", "''") & "','" & Now & "','" & dataKey & "','" & foreignKey & "','" & batchKey & "','" & Replace(debugInfo, "'", "''") & "')"
            Dim cmd As SqlClient.SqlCommand = GetCommand(sqlInsert)
            cmd.Connection.Open()
            Using cmd.Connection
                Using cmd
                    cmd.ExecuteNonQuery()
                    cmd.Connection.Close()
                End Using
            End Using
        End If

    End Sub

    Private Sub TruncateMetaSQL()
        Dim daysToSave As Integer = 3
        Dim sqlDelete As String = " DELETE TBLMETASQL WHERE FLDCREATEDATE < DATEADD(D," & (daysToSave * -1) & ",GETDATE())"
        Dim cmd As SqlClient.SqlCommand = GetCommand(sqlDelete)
        cmd.Connection.Open()
        Using cmd.Connection
            Using cmd
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
            End Using
        End Using
    End Sub

    Private Sub CreateStoredProcedureBaseSQL(ByRef sql As StringBuilder)

        sql.Append("EXEC ")
        sql.Append(_Meta.GetSourceQualifiedName & " ")

        For Each zStoredProcParm In _Meta.SourceProcParameters
            sql.Append(zStoredProcParm.Name & "=")
            For Each zKey As Integer In RequiredParametersDictionary.Keys
                If zStoredProcParm.Name.Contains(_Meta.FindParameter(zKey).fldFieldName) Then
                    sql.Append("'" & Parameters.GetValue(zKey) & "'")
                    sql.Append(",")
                End If
            Next
        Next

        sql.Remove(sql.Length - 1, 1)

    End Sub

    Private Sub CreateBaseSQLSelect(ByRef sql As StringBuilder)
        sql.Append(_Select.ToSQL(SQLSelectList.SelectType.Base))
        sql.Append(_From.ToSQL)
        sql.Append(_Where.ToSQL(True))
    End Sub

    Private Sub AppendJoinTableSelect(ByRef sql As StringBuilder)

        If _Meta.IsJoinRequired Then
            Dim sqlBuilder As New StringBuilder
            With sqlBuilder
                .Append("SELECT " & Bracket(_From.alias) & ".* FROM ")
                .Append("(")
                .Append(sql.ToString)
                .Append(") " & Bracket(_From.alias))
                .Append(GetMetaSourceJoin())
            End With

            sql = sqlBuilder
        End If

    End Sub

    Private Function GetMetaSourceJoin() As String

        Dim zSource = _Meta.Source(0)
        If CBool(zSource.fldIsJoinRequired) Then
            Dim zTblMetaSourceJoinId As Integer = 99

            Select Case _MetaContext
                Case SQLMetaData.MetaContext.Charts, SQLMetaData.MetaContext.Grids, SQLMetaData.MetaContext.Maps
                    zTblMetaSourceJoinId = 1   '<< JOINS TO THE GSAFE, USED FOR INTERACTIVE REQUESTS
                Case SQLMetaData.MetaContext.Reports, SQLMetaData.MetaContext.Extracts
                    zTblMetaSourceJoinId = 2  ''<< JOINS TO THE BATCHPROCESSING, USED FOR BATCH REQUESTS OR BEHIND THE SCENES PROCESSING
                Case Else
                    Throw New ApplicationException("Applicaton could not get MetaSourceJoin for context ID [" & _MetaContext & "]")
            End Select

            Dim zMetaSourceJoin As Object = _Meta.FindMetaSourceJoin(zTblMetaSourceJoinId)
            Dim zSB As New System.Text.StringBuilder
            zSB.Append(" " & Replace(zMetaSourceJoin.fldJoinText, "?", Bracket(_From.alias) & "." & Bracket(zSource.fldJoinFieldName)))
            zSB.Append(" WHERE ")
            zSB.Append(" " & zMetaSourceJoin.fldParameterName & "='" & _JoinKeyValue & "'")

            Return zSB.ToString
        Else
            Return ""
        End If

    End Function

    Private Sub AppendRowNumberSelect(ByRef sql As StringBuilder)

        Dim sqlBuilder As New StringBuilder
        With sqlBuilder
            .Append("SELECT  " & Bracket(_From.alias) & ".*," & _Select.GetRowNumberFieldString & "  FROM ")
            .Append("(")
            .Append(sql)
            .Append(") " & Bracket(_From.alias))
        End With

        sql = sqlBuilder

    End Sub

    Private Sub AppendUserFieldsSelect(ByRef sql As StringBuilder)

        Dim sqlBuilder As New StringBuilder
        With sqlBuilder
            .Append(_Select.ToSQL(SQLSelectList.SelectType.User))
            .Append(" FROM ")
            .Append("(")
            .Append(sql)
            .Append(") " & Bracket(_From.alias))
            .Append(_Where.ToSQL(False))
            .Append(_GroupBy.ToSQL())
        End With

        sql = sqlBuilder

    End Sub

    Private Sub AppendMapDataFieldsSelect(ByRef sql As StringBuilder)

        Dim sqlBuilder As New StringBuilder
        With sqlBuilder
            .Append(_Select.ToSQL(SQLSelectList.SelectType.MapData))
            .Append(" FROM ")
            .Append("(")
            .Append(sql)
            .Append(") " & Bracket(_From.alias))
            .Append(_Where.ToSQL(False))
            .Append(_GroupBy.ToSQL())
        End With

        sql = sqlBuilder

    End Sub

    Private Sub AppendMapFinalSelect(ByRef sql As StringBuilder)

        Dim sqlBuilder As New StringBuilder
        With sqlBuilder
            .Append("SELECT DISTINCT * FROM (")
            .Append(_Select.ToSQL(SQLSelectList.SelectType.Map))
            .Append(" FROM ")
            .Append("(")
            .Append(sql)
            .Append(") " & Bracket(_From.alias))
            .Append(" LEFT JOIN tblMetaMapPin m ON " & Bracket(_From.alias) & ".MapPinIcon=m.fldIcon")
            .Append(") [src]")
        End With

        sql = sqlBuilder

    End Sub

    Private Sub AppendMapMetaFieldsSelect(ByRef sql As StringBuilder)

        Dim sqlBuilder As New StringBuilder
        With sqlBuilder
            .Append(_Select.ToSQL(SQLSelectList.SelectType.MapMeta))
            .Append(" FROM ")
            .Append("(")
            .Append(sql)
            .Append(") " & Bracket(_From.alias))
        End With

        sql = sqlBuilder

    End Sub

    Private Function AppendPagingSelect(ByRef sql As StringBuilder)

        If _Select._PageEnabled Then
            Dim sqlBuilder As New StringBuilder
            With sqlBuilder
                ''WE ADD ANOTHER ROW_NUMBER TO SORT THE INNER ROW_NUMBER COLUMN.  IN THE INNER ROW_NUMBER COL, WE CONVERT THE VALUE TO SMALLINT, WHICH MESSES UP THE ORIGINAL ORDER BY
                .Append("SELECT *, ROW_NUMBER()OVER(ORDER BY RowNumber ASC) AS SortRowNo FROM ")
                .Append("(")
                .Append(sql)
                .Append(") " & Bracket(_From.alias) & " ")
                .Append("WHERE " & _Select.GetRowNumberFieldFilterString)
                '   .Append(_OrderBy.ToSQL)
            End With

            sql = sqlBuilder

        End If

        Return sql

    End Function

    Friend Shared Function Bracket(ByRef value As String) As String
        Dim brackets() As String = {"[", "[[", "[[[[", "[[[[[", "[[[[[[", "]", "]]", "]]]", "]]]]", "]]]]]"}
        For Each Bracket In brackets
            value = Replace(value, Bracket, "")
        Next

        Return "[" & value & "]"
    End Function

    Private Function GetCommand(commandText As String) As SqlClient.SqlCommand
        Dim con As New SqlClient.SqlConnection(GRC.Connect.Libraries.CoreLib.UtilDB.ConnectionString)
        Dim cmd As New SqlClient.SqlCommand(commandText, con)
        Return cmd
    End Function

    Private Function ValidateParameters() As Boolean
        Dim ParameterFlags() As Integer = [Enum].GetValues(GetType(tblMetaParameter.ParameterFlags))
        For Each zParmFlag As tblMetaParameter.ParameterFlags In ParameterFlags
            If zParmFlag And RequiredParameters Then
                Dim zMetaParameter As Object = _Meta.FindParameter(zParmFlag)
                Dim zDataLibObj As New rowTblMetaChart 'THIS OBJECT IS ONLY FOR GETTING ACCESS OT THE DATALIB ASSEMBLY
                Dim typeExpected As Type = Nothing

                Try
                    If zMetaParameter.fldType.ToString.StartsWith("System.", StringComparison.OrdinalIgnoreCase) Then
                        typeExpected = Type.GetType(zMetaParameter.fldType, True, True)
                    Else
                        typeExpected = zDataLibObj.GetType.Assembly.GetType(zMetaParameter.fldType, True, True)
                    End If
                    Select Case typeExpected.IsEnum
                        Case True
                            ValidateEnumType(zMetaParameter, typeExpected)
                        Case False
                            ValidateStringType(zMetaParameter, typeExpected)
                    End Select
                Catch ex As Exception
                    Dim zEx As New ApplicationException("An exception occurred while trying to get expected type [" & zMetaParameter.fldType & "].", ex)
                    If IsNothing(zDataLibObj) Then zEx.Data.Add("zDataLibObj", "NOTHING") Else zEx.Data.Add("zDataLibObj", zDataLibObj.GetType.FullName)
                    If IsNothing(zDataLibObj.GetType.Assembly) Then zEx.Data.Add("zDataLibObj.Assembly", "NOTHING") Else zEx.Data.Add("zDataLibObj.Assembly", zDataLibObj.GetType.Assembly.FullName)
                    Throw zEx
                End Try
            End If
        Next
        Return True
    End Function

    Private Sub ValidateEnumType(zMetaParameter As Object, typeExpected As Type)
        Dim parameterValue As Object = Parameters.GetValue(zMetaParameter.fldFlagId)
        If IsNumeric(parameterValue) Then
            If parameterValue = 0 Then parameterValue = 1 'THIS IS AN OVERRIDE TO PROTECT AGAINST ZERO VALUE  -ea
            Dim anyEnum As Object = [Enum].ToObject(typeExpected, CInt(parameterValue))
            If Not typeExpected.IsEnumDefined(anyEnum) Then
                Throw New Exception("The parameter value [" & parameterValue.ToString & "] is not valid for " & zMetaParameter.fldName & " parameter.")
            End If
        Else
            Throw New Exception("The parameter value [" & parameterValue.ToString & "] is not valid for " & zMetaParameter.fldName & " parameter.")
        End If
    End Sub

    Private Sub ValidateStringType(ByRef zMetaParameter As Object, typeExpected As Type)
        Dim parameterValue As Object = Parameters.GetValue(zMetaParameter.fldFlagId)

        If String.IsNullOrEmpty(parameterValue) And zMetaParameter.fldAllowWildcardValue = True Then
            Parameters.SetValue(zMetaParameter.fldFlagId, "%")  'THIS IS AN OVERRIDE TO PROTECT AGAINST NULLS  -db
        ElseIf String.IsNullOrEmpty(parameterValue) And zMetaParameter.fldAllowWildcardValue = False Then
            Throw New ArgumentException("Parameter [" & zMetaParameter.fldName & "] value not set. Please set the parameter value using the Parameters property.")
        End If

        If parameterValue.Contains("%") And zMetaParameter.fldAllowWildcardValue = False Then
            Throw New ArgumentException("Parameter [" & zMetaParameter.fldName & "] cannot accept wildcard as a parameter value.")
        End If

    End Sub

    'Public Function GetSQLMakerParameterType(parameterId As Integer) As Type
    '    Dim srcparameter As Object = _Meta.FindParameter(parameterId)
    '    Dim typeString As String = srcparameter.fldType
    '    Dim type As Type = type.GetType(typeString)
    '    If IsNothing(type) Then
    '        Throw New Exception("System can not find the type called " & Chr(34) & typeString & Chr(34) & " from parameter [" & srcparameter.fldName & "].")
    '    End If
    '    Return type
    'End Function

    Private Sub WriteTraceInfo()
        Dim zPadSize As Integer = 40
        Trace.WriteLine("SQL Maker Parms")
        Trace.Indent()
        Trace.WriteLine("ID".PadRight(zPadSize) & _Id)
        Trace.WriteLine("Context".PadRight(zPadSize) & _MetaContext.ToString)
        Trace.Indent()
        Dim zMetaDynamicObj As UtilSQLMaker.SQLMetaData.SQLMetaDynamicObject = _Meta.Source(0)
        For Each zField As String In zMetaDynamicObj.Keys
            Trace.WriteLine("TblMetaSource" & "." & zField & ": ".PadRight(zPadSize) & zMetaDynamicObj.GetValue(zField))
        Next
        Trace.Unindent()
        Trace.Unindent()
    End Sub

#Region "Enums"

    Public Enum SQLAgreggate
        None
        Count
        Sum
        Avg
    End Enum

    Public Enum SQLSortDirection
        Asc
        Desc
    End Enum

    Public Enum SQLLogicOperator
        [AND]
        [OR]
    End Enum

    Public Enum SQLComparisonOperator
        GreaterThan
        LessThan
        GreaterOrEqual
        LessThanOrEqual
        NotEqual
        Equal
        NotLessThan
        NotGreaterThan
        [Like]
        Between
        [In]
        NotIn
        NotLike
        IsNotNull
        IsNull
    End Enum

    Public Enum SQLJoinTo
        GSafeFileNo = 1
        ReportFileNo = 2
    End Enum

    Public Enum SQLSelectFieldType
        Data = 1
        RowNumber = 2
    End Enum

    Public Enum SQLMetaDataType
        Report
        Grid
        Source
    End Enum

#End Region

#Region "Nested Classes"

    Public Class SQLSelect
        Public field As String
        Public type As SQLSelectFieldType = SQLSelectFieldType.Data
        Public [alias] As String
        Public [agreggate] As SQLAgreggate
        Public isLiteral As Boolean = False

        Public Sub New(field As String, Optional agreggate As SQLAgreggate = SQLAgreggate.None)
            Me.field = field
            Me.agreggate = agreggate
            Me.alias = ""
        End Sub

        Public Sub New(field As String, [alias] As String, Optional agreggate As SQLAgreggate = SQLAgreggate.None)
            Me.field = field
            Me.agreggate = agreggate
            Me.alias = [alias]
        End Sub
    End Class

    Public Class SQLSelectList

        Private _HasTop As Boolean = False
        Private _TopCount As Integer
        Private _IsTopPercentage As Boolean
        Private _IsCountSelect As Boolean = False

        Friend _PageNo As Integer
        Friend _PageRowsPer As Integer
        Friend _PageEnabled As Boolean = False
        Friend _UseRawFields As Boolean = False
        Friend _AllFieldsSelected As Boolean = False
        Friend _MapFieldsSelected As Boolean = False

        Friend _List As New List(Of SQLSelect)
        Private _Maker As UtilSQLMaker

        Friend Sub New(maker As UtilSQLMaker)
            _Maker = maker
        End Sub

        Public Sub SelectAll()
            For Each srcField In _Maker._Meta.SourceFields  'srcField represents a record in the sys.all_columns sql view
                Me.Add(srcField.Name, SQLAgreggate.None)
            Next
            _AllFieldsSelected = True
        End Sub

        Public Sub SelectMapFields()
            SelectMapDataFields()
            SelectMapMetaFields()
            _MapFieldsSelected = True
        End Sub

        Friend Sub SelectMapDataFields()
            Add({"FileNo", "Longitude", "Latitude", "MapPinIcon", "TitleSnippet", "DepictedField", "DepictedFieldBackColor", "UniqueFieldName", "ShowPinText", "PinValue"}.ToList)
        End Sub

        Friend Sub SelectMapMetaFields()
            Add({"fldHeight", "fldWidth", "fldAnchorX", "fldAnchorY", "fldTextOffsetX", "fldTextOffsetY"}.ToList)
            AddLiteral("(CASE ShowPinText WHEN 0 THEN NULL ELSE PinText END)", "PinText")
        End Sub

        Public Sub AddLiteral(literal As String, [alias] As String)
            Me._Add(literal, [alias], True, SQLAgreggate.None)
        End Sub

        Public Sub Add(fields As List(Of String))
            fields.ForEach(Sub(x) Me.Add(x))
        End Sub

        Public Sub Add(field As String)
            Me._Add(field, "", False, SQLAgreggate.None)
        End Sub

        Public Sub Add(field As String, [aggregate] As SQLAgreggate)
            Me._Add(field, "", False, aggregate)
        End Sub

        Public Sub Add(field As String, [alias] As String, Optional [aggregate] As SQLAgreggate = SQLAgreggate.None)
            Me._Add(field, [alias], False, aggregate)            
        End Sub

        Private Sub _Add(field As String, [alias] As String, isLiteral As Boolean, Optional [aggregate] As SQLAgreggate = SQLAgreggate.None)

            Dim sqlSelect As New SQLSelect(field, aggregate)
            sqlSelect.alias = [alias]
            sqlSelect.IsLiteral = isLiteral
            _List.Add(sqlSelect)

        End Sub

        Public Sub ClearAll()
            _List.Clear()
            _AllFieldsSelected = False
            _MapFieldsSelected = False
        End Sub

        Public Sub Top(count As Integer, Optional isPercentage As Boolean = False)
            _TopCount = count
            _IsTopPercentage = isPercentage
            _HasTop = True
        End Sub

        Public Sub Count(field As String)
            Me.Add(field, SQLAgreggate.None)
            Me.Add(field, SQLAgreggate.Count)
            _IsCountSelect = True
        End Sub

        Public Sub Count()
            Me.ClearAll()
            Me.Add("*", "Total", SQLAgreggate.Count)
            _IsCountSelect = True
        End Sub

        Public Sub Page(pageNo As Integer, pageRowsPer As Integer)

            _PageNo = pageNo
            _PageRowsPer = pageRowsPer
            _PageEnabled = True

        End Sub

        Friend Function HasAgreggateField() As Boolean
            For Each item As SQLSelect In _List
                If item.agreggate <> SQLAgreggate.None Then Return True
            Next
            Return False
        End Function

        Friend Function HasCountAllAgreggateField() As Boolean
            For Each item As SQLSelect In _List
                If item.agreggate = SQLAgreggate.Count And item.field = "*" Then Return True
            Next
            Return False
        End Function

        Friend Function ToSQL(pSelectType As SelectType) As String

            Dim zSQL As String = ""

            Select Case pSelectType
                Case SelectType.Base
                    zSQL = ToSQLBaseSelect()
                Case SelectType.User
                    zSQL = ToSQLUserSelect()
                Case SelectType.Map
                    zSQL = ToSQLMapSelect()
                Case SelectType.MapData
                    zSQL = ToSQLMapDataSelect()
                Case SelectType.MapMeta
                    zSQL = ToSQLMapMetaFieldsSelect()
            End Select

            Return zSQL

        End Function

        Private Function ToSQLUserSelect() As String

            Dim sqlBuilder As New StringBuilder()
            Dim selectPredicate As String = GetSelectPredicate()
            Dim separator As String = ""
            Dim aliasName As String = ""

            'Add all fields if none are set
            If _List.Count = 0 Then SelectAll()

            If _AllFieldsSelected Then
                sqlBuilder.Append("*")
            Else

                'DB- NOT SURE WHY THIS IS HERE.  COMMENTING OUT FOR NOW 4.12.17
                'If Not HasAgreggateField() Then sqlBuilder.Append("RowNumber")

                For Each item As SQLSelect In _List
                    If sqlBuilder.Length > 0 Then separator = ","

                    If item.alias <> "" Then aliasName = " AS " & Bracket(item.alias) Else aliasName = ""
                    If Not item.type = SQLSelectFieldType.RowNumber Then

                        If item.agreggate = SQLAgreggate.None Then
                            If item.field.ToLower = _Maker._Meta.Source(0).fldJoinFieldName.ToLower Then
                                sqlBuilder.Append(separator)
                                sqlBuilder.Append(Bracket(_Maker._From.alias) & "." & Bracket(item.field) & aliasName)

                            ElseIf item.isLiteral Then
                                sqlBuilder.Append(separator)
                                sqlBuilder.Append(item.field & " " & aliasName)
                            Else
                                sqlBuilder.Append(separator)
                                sqlBuilder.Append(Bracket(item.field) & aliasName)
                            End If
                        Else
                            aliasName = item.alias & item.agreggate.ToString
                            If Not String.IsNullOrEmpty(item.alias) Then aliasName = item.alias

                            If item.field = "*" Then
                                sqlBuilder.Append(separator)
                                sqlBuilder.Append(item.agreggate.ToString & "(" & item.field & ") AS " & aliasName)
                            Else
                                sqlBuilder.Append(separator)
                                sqlBuilder.Append(item.agreggate.ToString & "(" & Bracket(_Maker._From.alias) & "." & Bracket(item.field) & ") AS " & aliasName)
                            End If
                        End If
                    Else
                        sqlBuilder.Append(separator)
                        sqlBuilder.Append(item.field & aliasName)
                    End If

                Next

            End If

            sqlBuilder.Insert(0, selectPredicate)

            Return sqlBuilder.ToString
        End Function

        Private Function ToSQLBaseSelect() As String

            Dim sqlBuilder As New StringBuilder()
            ' Dim selectPredicate As String = "SELECT DISTINCT "
            Dim selectPredicate As String = "SELECT "
            Dim fields As String = GetBaseSelectFields()

            sqlBuilder.Append(selectPredicate & " ")
            sqlBuilder.Append(fields)

            Return sqlBuilder.ToString

        End Function

        Private Function ToSQLMapSelect() As String

            ClearAll()
            SelectMapFields()
            Return ToSQLUserSelect()

        End Function

        Private Function ToSQLMapMetaFieldsSelect() As String

            Dim zMapField As String = _Maker._MapField

            If String.IsNullOrEmpty(Trim(zMapField)) Then Throw New ApplicationException("MapField not specified. Incorrect constructor used on UtilSQLMaker.")

            Dim zTitleHtmlSnippet As String = ""
            Dim zPinIconSQLSnippet As String = ""
            Dim zFieldBackColor As String = ""
            Dim zUniqueFieldName As String = ""
            Dim zShowPinText As Boolean = False

            Try
                zTitleHtmlSnippet = _Maker._Meta.GridColumns.Find(Function(x) x.field.ToString.ToLower = zMapField.ToLower).fldMapTitleHtmlSnippet
                zPinIconSQLSnippet = _Maker._Meta.GridColumns.Find(Function(x) x.field.ToString.ToLower = zMapField.ToLower).fldMapPinIconSqlSnippet
                zFieldBackColor = _Maker._Meta.GridColumns.Find(Function(x) x.field.ToString.ToLower = zMapField.ToLower).fldFieldNameBackColor
                zShowPinText = CBool(_Maker._Meta.Grids(0).fldMapShowPinText)

                zUniqueFieldName = _Maker._Meta.Source(0).fldUniqueFieldName
 
                If zFieldBackColor = "" Then zFieldBackColor = "''" Else zFieldBackColor = "[" & zFieldBackColor & "]"
                If zUniqueFieldName = "" Then zUniqueFieldName = "''" Else zUniqueFieldName = "'" & zUniqueFieldName & "'"
                zMapField = "'" & zMapField & "'"

                Return "SELECT *, " & zPinIconSQLSnippet & " AS MapPinIcon, '" & zTitleHtmlSnippet & "' AS TitleSnippet," & zMapField & " AS DepictedField," & zFieldBackColor & " As DepictedFieldBackColor," & zUniqueFieldName & " As UniqueFieldName, " & CInt(zShowPinText).ToString & " As ShowPinText, " & IIf(zShowPinText, "FileNo", _Maker._MapField) & " As PinValue"

            Catch ex As Exception
                If TypeOf ex Is NullReferenceException Then
                    Throw New ApplicationException("The field [" & zMapField & " ] does not exist in [" & _Maker._Meta.Grids(0).fldGridName & "].  Invalid filter column.", ex)
                Else
                    Throw
                End If
            End Try


        End Function

        Private Function ToSQLMapDataSelect() As String
            ClearAll()
            SelectMapDataFields()
            Add("FileNo", "PinText", SQLAgreggate.Count)
            Return ToSQLUserSelect()
        End Function


        Private Function GetBaseSelectFields() As String
            Dim sb As New StringBuilder

            For Each zRawField In _Maker._Meta.Raw.RawFields  'These are the actual raw sql fields in the sql module.
                If _Maker._Meta.ContainsTSQLUserFunction(zRawField) Then
                    sb.AppendLine(SetTSQLUserFunctionValues(zRawField))
                Else
                    sb.AppendLine(zRawField)
                End If
            Next

            Dim temp As String = sb.ToString.Replace(vbCrLf, ",")
            sb.Clear()
            sb.Append(Left(temp, temp.Length - 1))

            Return sb.ToString

        End Function

        Friend Function SetTSQLUserFunctionValues(rawdefinition As String) As String
            Dim zSQLFunction As Object = _Maker._Meta.FindTSQLFunction(rawdefinition)

            'Gets the parameter flags in the TblMetaSQLFunction table to determine all variables for the TSQLFunction
            Dim zSQLFunctionParms = CType(zSQLFunction.fldParameterFlag, UtilSQLMaker.SQLMetaData.MetaSQLFunctionParameter)

            'Loop thru each possible SQL Function paramter checking against to see if the current function has those parametesr.
            For Each SQLFunctionParm As Object In _Maker._Meta.AllSQLFunctionsParms
                If SQLFunctionParm.fldId And zSQLFunctionParms Then  'The the parameter is part of this function then
                    Dim srcParameter As Object = _Maker._Meta.FindParameter(SQLFunctionParm.fldMetaParameterId)   'srcParameter represents a record in the tblMetaParameter table
                    Try
                        Dim srcParameterValue As Object = _Maker.Parameters.GetValue(srcParameter.fldId) 'get the supplied value for the given parameter
                        rawdefinition = Replace(rawdefinition, SQLFunctionParm.fldFunctionParameter, srcParameterValue, 1, -1, CompareMethod.Text)  'Replace the function parameter (ie: @ToCurrencyId) with the supplied value from the parameters collection.
                    Catch ex As KeyNotFoundException
                        'IF THIS EXCEPTION IS THROW, IT MEANS THAT ONE OF THE PARAMETER COLUMNS IS NOT ENABLED IN THE TBLMETASOURCE TABLE, EVEN THOUGH THE SQL HAS A FUNCTION THAT REQUIRES A VALUE.
                        Throw New ApplicationException("The MetaSource [" & _Maker._Meta.Source(0).fldObjectName & "] has a TSQL function called [" & zSQLFunction.fldObjectName & "] but not specified as a parameter in the tblMetaSource table.")
                    End Try
                End If
            Next

            Return rawdefinition
        End Function

        Friend Function GetSelectPredicate() As String
            Dim returnSQLBuilder As New StringBuilder("SELECT ")
            If _HasTop Then
                returnSQLBuilder.Append("TOP ")
                returnSQLBuilder.Append(_TopCount & " ")
                If _IsTopPercentage Then
                    returnSQLBuilder.Append("PERCENT ")
                End If
            End If
            Return returnSQLBuilder.ToString
        End Function

        Friend Function GetRowNumberFieldString() As String

            Dim zRowNumberField As String = " CONVERT(Int, ROW_NUMBER() OVER(" & GetRowNumberOrderBy() & ")) AS [ROWNUMBER] "
            Return zRowNumberField

        End Function

        Friend Function GetRowNumberOrderBy() As String

            Dim zSource As Object = _Maker._Meta.Source(0)

            'USE USER DEFINED FIRST

            If _IsCountSelect Then
                If Not String.IsNullOrEmpty(Me._List(0).alias) Then
                    Return "Order By [" & Me._List(0).alias & "]"
                Else
                    Return "Order By [" & Me._List(0).field & "]"
                End If
            ElseIf _Maker._OrderBy.Count > 0 Then
                Return _Maker._OrderBy.ToSQL()

            ElseIf zSource.fldOrderBy <> "" And _AllFieldsSelected Then   'IF NO USER DEFINED, USE META

                Dim zSQLOrderByList As SQLOrderByList = SQLOrderByList.Parse(zSource.fldOrderBy, _Maker)
                Return zSQLOrderByList.ToSQL()

            ElseIf HasAgreggateField() And Not HasCountAllAgreggateField() Then   'IF NO USER DEFINED, NO META, BUT HAS AGREGATE THEN ADD TO ORDER BY LIST
                For Each selectfield As SQLSelect In _List
                    If selectfield.agreggate = SQLAgreggate.None Then
                        _Maker._OrderBy.Add(selectfield.field, SQLSortDirection.Asc)
                    End If
                Next

                Return _Maker._OrderBy.ToSQL()
            Else
                'IF NOT USER DEFINE AND NO META, GET FIRST COLUMN IN VIEW
                Dim query As String = "(select TOP 1 '" & Bracket(_Maker._From.alias) & ".' + [NAME] as Name from sys.columns where object_id=Object_ID('" & _Maker._Meta.GetSourceQualifiedName & "'))"
                Return " ORDER BY " & query
            End If

        End Function

        Friend Function GetRowNumberFieldFilterString() As String
            Return "[RowNumber] BETWEEN " & ((_PageNo - 1) * _PageRowsPer) + 1 & " AND " & _PageNo * _PageRowsPer
        End Function

        Public Enum SelectType
            Base
            User
            Map
            MapData
            MapMeta
        End Enum

    End Class

    Public Class SQLFrom

        Private _Maker As UtilSQLMaker
        Public [alias] As String = "src"
        Public useOriginalTables As Boolean = False

        Friend Sub New(maker As UtilSQLMaker)
            _Maker = maker
        End Sub

        Public Function ToSQL()
            Return ReturnFromRawDefinition()
        End Function

        Private Function ReturnFromRawDefinition()
            Return _Maker._Meta.Raw.RawFrom
        End Function

        Private Function ReturnFrom() As String
            Return " FROM " & _Maker._Meta.GetSourceQualifiedName & " " & Bracket([alias] & " ")
        End Function
    End Class

    Public Class SQLWhere
        Public field As String
        Public [operator] As SQLComparisonOperator
        Public value1 As String
        Public value2 As String
        Public isRequiredParm As Boolean

        Public Sub New(field As String, [operator] As SQLComparisonOperator, value1 As String, value2 As String, isRequiredParm As Boolean)
            Me.field = field
            Me.operator = [operator]
            Me.value1 = value1
            Me.value2 = value2
            Me.isRequiredParm = isRequiredParm
        End Sub

    End Class

    Public Class SQLWhereList
        Friend _List As New List(Of SQLWhere)

        Private _Maker As UtilSQLMaker

        Friend Sub New(maker As UtilSQLMaker)
            _Maker = maker
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="field"></param>
        ''' <param name="operator"></param>
        ''' <param name="value1">The value to compare</param>
        ''' <param name="value2">Additional value for BETWEEN clause only. Is ignored for all others comparisons.</param>
        ''' <remarks></remarks>
        Public Overloads Sub Add(field As String, [operator] As SQLComparisonOperator, value1 As String, value2 As String)
            Select Case [operator]
                Case SQLComparisonOperator.Between
                    'If Not IsDupe(field, [operator], value1, value2) Then

                    'End If
                    _List.Add(New SQLWhere(field, [operator], value1, value2, False))

                Case SQLComparisonOperator.In, SQLComparisonOperator.NotIn
                    Dim values() As String = Split(value1, ",")
                    Add(field, [operator], values, "")

                Case Else
                    'If Not IsDupe(field, [operator], value1, "") Then

                    'End If
                    _List.Add(New SQLWhere(field, [operator], value1, "", False))

            End Select

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="field"></param>
        ''' <param name="operator"></param>
        ''' <param name="value1">The values to compare.  Used for the IN clause.</param>
        ''' <param name="value2">Additional value for BETWEEN clause only. Is ignored for all others comparisons.</param>
        ''' <remarks></remarks>
        Public Overloads Sub Add(field As String, [operator] As SQLComparisonOperator, value1() As String, value2 As String)

            'Build String of Values from array
            Dim valueBuilder As New StringBuilder
            For Each Val As String In value1
                valueBuilder.Append("'")
                valueBuilder.Append(Val)
                valueBuilder.AppendLine("'")
            Next

            Dim value As String = Replace(valueBuilder.ToString, Chr(13) & Chr(10), ",")
            value = Left(value, Len(value) - 1)
            If [operator] <> SQLComparisonOperator.In And [operator] <> SQLComparisonOperator.NotIn And value1.Count > 0 Then value = value
            If [operator] = SQLComparisonOperator.In Or [operator] = SQLComparisonOperator.NotIn Then value = "(" & value.ToString & ")"

            _List.Add(New SQLWhere(field, [operator], value, value2, False))

        End Sub

        Public Sub AndOperator()
            _List.Add(New SQLWhere("#AND#", Nothing, Nothing, Nothing, False))
        End Sub

        Public Sub OrOperator()
            _List.Add(New SQLWhere("#OR#", Nothing, Nothing, Nothing, False))
        End Sub

        Public Overloads Sub OpenParenthesis()
            _List.Add(New SQLWhere("#OpenParenthesis#", Nothing, Nothing, Nothing, False))
        End Sub

        Public Overloads Sub CloseParenthesis()
            _List.Add(New SQLWhere("#CloseParenthesis#", Nothing, Nothing, Nothing, False))
        End Sub

        ' ''' <summary>
        ' ''' 
        ' ''' </summary>
        ' ''' <param name="index"></param>
        ' ''' <param name="field"></param>
        ' ''' <param name="operator"></param>
        ' ''' <param name="value1">The value to compare</param>
        ' ''' <param name="value2">Additional value for BETWEEN clause only. Is ignored for all others comparisons.</param>
        ' ''' <remarks></remarks>
        'Public Overloads Sub Insert(index As Integer, field As String, [operator] As SQLComparisonOperator, value1 As String, value2 As String)
        '    Select Case [operator]
        '        Case SQLComparisonOperator.Between
        '            'If Not IsDupe(field, [operator], value1, value2) Then

        '            'End If
        '            _List.Insert(index, New SQLWhere(field, [operator], value1, value2, False))

        '        Case SQLComparisonOperator.In Or SQLComparisonOperator.NotIn
        '            'If Not IsDupe(field, [operator], value1, "") Then

        '            'End If
        '            _List.Insert(index, New SQLWhere(field, [operator], value1, "", False))

        '        Case Else
        '            'If Not IsDupe(field, [operator], value1, "") Then

        '            'End If
        '            _List.Insert(index, New SQLWhere(field, [operator], value1, "", False))

        '    End Select

        'End Sub

        Public Sub Clear()
            _List.Clear()
        End Sub

        Public Function ToSQL(pIsBaseWhere As Boolean)
            If pIsBaseWhere Then
                Return ReturnWhereRawDefinition()
            Else
                Return ReturnUserWhere()
            End If
        End Function

        Friend Function ReturnWhereRawDefinition()
            Return _Maker._Meta.Raw.RawWhere
        End Function

        Friend Function ReturnUserWhere() As String
            Dim sqlBuilder As New StringBuilder

            AddSourceParametersToWhereList()
            BuildRequiredWhere(sqlBuilder)
            BuildUserWhere(sqlBuilder)

            If sqlBuilder.Length > 0 Then
                Return " WHERE " & sqlBuilder.ToString
            Else
                Return ""
            End If

        End Function

        ''' <summary>
        '''The purpose of this function is to add the required parameters to the SQLWhere list.  These parameters come from the TblMetaSourceParameter table.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub AddSourceParametersToWhereList()

            Dim zWhereList As New List(Of SQLWhere)

            If _Maker.RequiredParametersDictionary.Count > 0 Then
                Dim zOpenP As New SQLWhere("#OpenParenthesis#", SQLComparisonOperator.Equal, "", "", True)
                zWhereList.Add(zOpenP)
            End If

            For Each zParmFlag As tblMetaParameter.ParameterFlags In _Maker.RequiredParametersDictionary.Keys
                Dim zMetaParameter = _Maker._Meta.FindParameter(zParmFlag)
                If zMetaParameter.fldParameterKindId = UtilSQLMaker.SQLMetaData.MetaParameterKind.Filter Then

                    Select Case zParmFlag

                        Case tblMetaParameter.ParameterFlags.TIVValue
                            Dim zTIVValue As TblMetaTIV.TIVRanges = _Maker.Parameters.GetValue(zParmFlag)
                            Dim zTIV As Integer = -1
                            If zTIVValue = TblMetaTIV.TIVRanges.Greater50Million Then zTIV = 50
                            If zTIVValue = TblMetaTIV.TIVRanges.Greater100Million Then zTIV = 100
                            If zTIVValue = TblMetaTIV.TIVRanges.Greater250Million Then zTIV = 250
                            If zTIVValue = TblMetaTIV.TIVRanges.Top10Highest Then zTIV = Math.Floor(TblMetaTIV.GetTenthHighest(_Maker.Parameters.FilePrefix)) - 1

                            'ADD THE WHERE CLAUSE
                            zWhereList.Add(New SQLWhere(_Maker._Meta.FindParameter(zParmFlag).fldFieldName, SQLComparisonOperator.GreaterThan, zTIV, "", True))


                        Case tblMetaParameter.ParameterFlags.InspectionProgramYear

                            Dim zIPY As TblMetaInspectionProgramYear.InspectionProgramYears = _Maker.Parameters.GetValue(zParmFlag)
                            Dim zInspProgRange As TblMetaInspectionProgramYear.ProgramRangeDate = TblMetaInspectionProgramYear.GetProgramRangeDate(_Maker.Parameters.FilePrefix, zIPY)

                            'ADD THE WHERE CLAUSE
                            zWhereList.Add(New SQLWhere(_Maker._Meta.FindParameter(zParmFlag).fldFieldName, SQLComparisonOperator.Between, zInspProgRange.StartDate, zInspProgRange.EndDate, True))

                            If zInspProgRange.GetLatest Then
                                zWhereList.Add(New SQLWhere("#AND#", SQLComparisonOperator.Equal, "", "", True))
                                zWhereList.Add(New SQLWhere("IsLatest", SQLComparisonOperator.Equal, zInspProgRange.GetLatest.ToString, "", True))
                            End If

                        Case Else

                            'BY DEFAULT ALL PARAMETERS USE THE EQUAL, UNLESS THE VALUE IS A %
                            Dim zComparisonOperator As SQLComparisonOperator = SQLComparisonOperator.Equal
                            If _Maker.Parameters.GetValue(zParmFlag) = "%" Then zComparisonOperator = SQLComparisonOperator.Like

                            'CHANGE COMPARISION OPERATOR FOR FILENO
                            If zParmFlag = tblMetaParameter.ParameterFlags.FileNo Then zComparisonOperator = SQLComparisonOperator.Like

                            'ADD THE WHERE CLAUSE
                            zWhereList.Add(New SQLWhere(_Maker._Meta.FindParameter(zParmFlag).fldFieldName, zComparisonOperator, _Maker.Parameters.GetValue(zParmFlag), "", True))

                    End Select

                    'IF THIS IS  NOT THE LAST PARM, THEN APPEND A "AND" TO THE WHERE CLAUSE
                    If _Maker.RequiredParametersDictionary.Keys.Last <> zParmFlag Then zWhereList.Add(New SQLWhere("#AND#", SQLComparisonOperator.Equal, "", "", True))

                End If

            Next

            'IF THE WHERELIST HAS MORE THAN THE OPEN PARENTHESIS ITEM, THEN WE NEED TO CLOSE IT. OTHER CLEAR ALL ITEMS
            If zWhereList.Count > 1 Then
                Dim zCloseP As New SQLWhere("#CloseParenthesis#", SQLComparisonOperator.Equal, "", "", True)
                zWhereList.Add(zCloseP)

                'IF CURRENT WHERE LIST HAS ITEMS ALREADY THEN WE NEED TO ADD A "AND" OPERATOR SO NO ERROR OCCURS IN SQL
                If _Maker._Where._List.Count > 0 Then zWhereList.Add(New SQLWhere("#AND#", SQLComparisonOperator.Equal, "", "", True))

            Else
                zWhereList.Clear()
            End If


            'INSERTS THE PRIVATE WHERE ITEMS TO THE MAIN LIST
            If zWhereList.Count > 0 Then _Maker._Where._List.InsertRange(0, zWhereList)

        End Sub

        Private Sub BuildRequiredWhere(ByRef sqlBuilder As StringBuilder)

            Dim requiredSQLWhereList As List(Of SQLWhere) = GetItemList(True)
            BuildSQLWhereClause(sqlBuilder, requiredSQLWhereList)

        End Sub

        Private Sub BuildUserWhere(ByRef sqlBuilder As StringBuilder)

            Dim suppliedSQLWhereList As List(Of SQLWhere) = GetItemList(False)
            BuildSQLWhereClause(sqlBuilder, suppliedSQLWhereList)

        End Sub

        Private Sub BuildSQLWhereClause(ByRef sqlBuilder As StringBuilder, list As List(Of SQLWhere))
            For Each item As SQLWhere In list
                BuildFilter(sqlBuilder, item)
            Next
        End Sub

        Private Sub BuildFilter(ByRef sqlBuilder As StringBuilder, ByVal item As SQLWhere)
            If IsOpenParenthesisItem(item) Then
                sqlBuilder.Append(" ")
                sqlBuilder.Append("(")
                sqlBuilder.Append(" ")
            ElseIf IsCloseParenthesisItem(item) Then
                sqlBuilder.Append(" ")
                sqlBuilder.Append(")")
                sqlBuilder.Append(" ")
            ElseIf IsAndOperatorItem(item) And Not _List.IndexOf(item) = 0 Then
                sqlBuilder.Append(" ")
                sqlBuilder.Append("AND")
                sqlBuilder.Append(" ")
            ElseIf IsOrOperatorItem(item) And Not _List.IndexOf(item) = 0 Then
                sqlBuilder.Append(" ")
                sqlBuilder.Append("OR")
                sqlBuilder.Append(" ")
            ElseIf IsBetweenOperatorItem(item) Then
                sqlBuilder.Append(Bracket(item.field))
                sqlBuilder.Append(" ")
                sqlBuilder.Append(" BETWEEN ")
                sqlBuilder.Append(" ")
                sqlBuilder.Append("'" & item.value1 & "'")
                sqlBuilder.Append(" ")
                sqlBuilder.Append("AND")
                sqlBuilder.Append(" ")
                sqlBuilder.Append("'" & item.value2 & "'")
            ElseIf IsInOperatorItem(item) Then
                sqlBuilder.Append(Bracket(item.field))
                sqlBuilder.Append(" ")

                If item.operator = SQLComparisonOperator.In Then
                    sqlBuilder.Append(" IN ")
                Else
                    sqlBuilder.Append(" NOT IN ")
                End If

                sqlBuilder.Append(" ")
                sqlBuilder.Append(item.value1)
            ElseIf IsNullorIsNotNullOperatorItem(item) Then
                sqlBuilder.Append(Bracket(item.field))
                sqlBuilder.Append(" ")

                If item.operator = SQLComparisonOperator.IsNotNull Then
                    sqlBuilder.Append(" IS NOT NULL ")
                Else
                    sqlBuilder.Append(" IS NULL ")
                End If
            ElseIf Not IsAndOperatorItem(item) And Not IsOrOperatorItem(item) Then
                sqlBuilder.Append(Bracket(item.field))
                sqlBuilder.Append(" ")
                sqlBuilder.Append(GetComparisonOperator(item.operator))
                sqlBuilder.Append(" ")
                sqlBuilder.Append("'" & item.value1 & "'")
            End If
        End Sub

        Private Function IsOpenParenthesisItem(item As SQLWhere) As Boolean
            If item.field = "#OpenParenthesis#" Then Return True
            Return False
        End Function

        Private Function IsCloseParenthesisItem(item As SQLWhere) As Boolean
            If item.field = "#CloseParenthesis#" Then Return True
            Return False
        End Function

        Private Function IsAndOperatorItem(item As SQLWhere) As Boolean
            If item.field = "#AND#" Then Return True
            Return False
        End Function

        Private Function IsOrOperatorItem(item As SQLWhere) As Boolean
            If item.field = "#OR#" Then Return True
            Return False
        End Function

        Private Function IsBetweenOperatorItem(item As SQLWhere) As Boolean
            If item.operator = SQLComparisonOperator.Between Then Return True
            Return False
        End Function

        Private Function IsInOperatorItem(item As SQLWhere) As Boolean
            If item.operator = SQLComparisonOperator.In Or item.operator = SQLComparisonOperator.NotIn Then Return True
            Return False
        End Function

        Private Function IsNullorIsNotNullOperatorItem(item As SQLWhere) As Boolean
            If item.operator = SQLComparisonOperator.IsNotNull Or item.operator = SQLComparisonOperator.IsNull Then Return True
            Return False
        End Function

        Private Function GetItemList(required As Boolean) As List(Of SQLWhere)
            Dim list As New List(Of SQLWhere)
            For Each item As SQLWhere In _List
                If item.isRequiredParm = required Then
                    list.Add(item)
                End If
            Next

            Return list

        End Function

        Private Function GetComparisonOperator([operator] As SQLComparisonOperator) As String
            Select Case [operator]
                Case SQLComparisonOperator.Equal
                    Return "="
                Case SQLComparisonOperator.GreaterOrEqual
                    Return ">="
                Case SQLComparisonOperator.GreaterThan
                    Return ">"
                Case SQLComparisonOperator.Like
                    Return " LIKE "
                Case SQLComparisonOperator.LessThan
                    Return "<"
                Case SQLComparisonOperator.LessThanOrEqual
                    Return "<="
                Case SQLComparisonOperator.NotEqual
                    Return "<>"
                Case SQLComparisonOperator.NotGreaterThan
                    Return "!>"
                Case SQLComparisonOperator.NotLessThan
                    Return "!<"
                Case SQLComparisonOperator.In
                    Return " IN "
                Case SQLComparisonOperator.NotIn
                    Return " NOT IN "
                Case SQLComparisonOperator.Between
                    Return " BETWEEN "
                Case SQLComparisonOperator.NotLike
                    Return " NOT LIKE "
                Case Else
                    Return ""
            End Select
        End Function
    End Class

    Public Class SQLOrderBy
        Public field As String
        Public sortdirection As SQLSortDirection

        Public Sub New(field As String, sort As SQLSortDirection)
            Me.field = field
            Me.sortdirection = sort
        End Sub

    End Class

    Public Class SQLOrderByList
        Friend _List As New List(Of SQLOrderBy)

        Private _Maker As UtilSQLMaker

        Friend Sub New(maker As UtilSQLMaker)
            _Maker = maker
        End Sub

        Public Sub AddRange(items As SQLOrderBy())
            _List.AddRange(items)
        End Sub

        Public Sub Add(field As String, Optional sortDirection As SQLSortDirection = SQLSortDirection.Asc)
            _List.Add(New SQLOrderBy(field, sortDirection))
        End Sub

        Public Sub Insert(index As Integer, field As String, Optional sortDirection As SQLSortDirection = SQLSortDirection.Asc)
            _List.Insert(index, New SQLOrderBy(field, sortDirection))
        End Sub

        Public Sub Clear()
            _List.Clear()
        End Sub

        Friend Sub CopyTo(list As SQLOrderByList)
            Dim a(_List.Count - 1) As SQLOrderBy
            _List.CopyTo(a)
            list.AddRange(a)
        End Sub

        Public Function Count() As Integer
            Return _List.Count
        End Function

        Friend Shared Function Parse(fields As String, maker As UtilSQLMaker) As SQLOrderByList
            Dim list As New SQLOrderByList(maker)

            Dim orderByString As String = fields
            Dim orderByfields() As String = Split(orderByString, ",")

            For Each orderByField As String In orderByfields
                If orderByField.Length > 0 Then
                    Dim field() As String = Split(Trim(orderByField), " ")

                    Select Case field.Count
                        Case 1
                            list.Insert(Array.IndexOf(orderByfields, orderByField), field(0), SQLSortDirection.Asc)
                        Case 2
                            If Trim(field(1)).ToLower = "asc" Then
                                list.Insert(Array.IndexOf(orderByfields, orderByField), field(0), SQLSortDirection.Asc)
                            ElseIf Trim(field(1)).ToLower = "desc" Then
                                list.Insert(Array.IndexOf(orderByfields, orderByField), field(0), SQLSortDirection.Desc)
                            End If
                    End Select
                End If
            Next

            Return list
        End Function

        Friend Function ToSQL() As String

            Dim sqlBuilder As New StringBuilder
            Dim separator As String = ""

            For Each Order As SQLOrderBy In _List
                If sqlBuilder.Length > 0 Then separator = ","
                sqlBuilder.Append(separator)
                sqlBuilder.Append(Bracket(_Maker._From.alias) & "." & Order.field)
                sqlBuilder.Append(" ")
                sqlBuilder.Append(Order.sortdirection.ToString)
            Next

            If _List.Count > 0 Then
                Return " ORDER BY " & sqlBuilder.ToString
            Else
                Return ""
            End If

        End Function

    End Class

    Public Class SQLGroupBy

        Private _Maker As UtilSQLMaker

        Friend Sub New(maker As UtilSQLMaker)
            _Maker = maker
        End Sub

        Friend Function ToSQL() As String

            Dim sqlBuilder As New StringBuilder
            Dim separator As String = ""

            If _Maker.Select.HasAgreggateField Then
                For Each item As SQLSelect In _Maker._Select._List
                    If sqlBuilder.Length > 0 Then separator = ","
                    If item.agreggate = SQLAgreggate.None Then
                        sqlBuilder.Append(separator)
                        sqlBuilder.Append(Bracket(_Maker._From.alias) & "." & Bracket(item.field))
                    End If
                Next
            End If

            If sqlBuilder.Length > 0 Then
                Return " GROUP BY  " & sqlBuilder.ToString
            Else
                Return " "
            End If

        End Function

    End Class


#End Region





End Class

