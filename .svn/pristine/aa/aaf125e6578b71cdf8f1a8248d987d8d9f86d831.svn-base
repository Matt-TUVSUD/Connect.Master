Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web

Public Class UtilDB
    Private Shared _ConnectionString As String = ""

    Public Shared Sub LogChartActivity(pUser As String, pChartID As String)

        If IsNumeric(pUser) And IsNumeric(pChartID) Then LogUserActivity(pUser, "C", pChartID, "")

    End Sub

    Public Shared Sub LogGridActivity(pUser As String, pGridID As String)

        If IsNumeric(pUser) And IsNumeric(pGridID) Then LogUserActivity(pUser, "G", pGridID, "")

    End Sub

    Public Shared Sub LogReportActivity(pUser As String, pReportID As String)

        If IsNumeric(pUser) And IsNumeric(pReportID) Then LogUserActivity(pUser, "R", pReportID, "")

    End Sub

    Public Shared Sub LogOtherActivity(pUser As String, pOtherActivity As String)

        If IsNumeric(pUser) Then LogUserActivity(pUser, "O", 0, pOtherActivity)

    End Sub


    Public Shared Sub LogUserActivity(pUser As Integer, pActivityType As String, pFldID As Integer, pOtherActivity As String)

        Dim zCon As New SqlClient.SqlConnection(UtilDB.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("spLogUserActivity", zCon)

        With zCmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@LoginID", pUser)
            .Parameters.AddWithValue("@ActivityType", pActivityType)
            .Parameters.AddWithValue("@FldID", pFldID)
            .Parameters.AddWithValue("@OtherActivity", IIf(pOtherActivity = "", DBNull.Value, pOtherActivity))
        End With

        zCon.Open()
        Using zCon
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Shared Function DashboardDimUserUpdate(pGSafeGuid As String) As Boolean

        Dim zCon As New SqlClient.SqlConnection(UtilDB.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand("spDashboardDimUserUpdate", zCon)

        With zCmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@GSafeID", pGSafeGuid)
            .Parameters.Add("@IsDataInCloud", SqlDbType.Bit)
            .Parameters("@IsDataInCloud").Direction = ParameterDirection.Output
        End With

        zCon.Open()
        Using zCon
            Using zCmd
                zCmd.ExecuteNonQuery()
            End Using
        End Using

        Return zCmd.Parameters("@IsDataInCloud").Value
    End Function

    Public Shared Property ConnectionString() As String
        Get
            Dim zConStrings As ConnectionStringSettingsCollection = ConfigurationManager.ConnectionStrings
            Dim zConName As String = "Connect." & UtilSystemParms.ReadWebAppMode
            For Each zConString As ConnectionStringSettings In zConStrings
                If zConString.Name.ToUpper = zConName.ToUpper Then
                    Return zConString.ConnectionString
                End If
            Next
            Throw New ArgumentException("System could not locate connection string named [" & zConName & "]")
        End Get
        Set(value As String)
            _ConnectionString = value
        End Set
    End Property

    Public Shared Property ConnectionString(pAppMode As String) As String
        Get
            Dim zConStrings As ConnectionStringSettingsCollection = ConfigurationManager.ConnectionStrings
            Dim zConName As String = "Connect." & pAppMode
            For Each zConString As ConnectionStringSettings In zConStrings
                If zConString.Name.ToUpper = zConName.ToUpper Then
                    Return zConString.ConnectionString
                End If
            Next
            Throw New ArgumentException("System could not locate connection string named [" & zConName & "]")
        End Get
        Set(value As String)
            _ConnectionString = value
        End Set
    End Property


    Public Shared ReadOnly Property Server As String
        Get
            Dim zElements() As String = Split(ConnectionString, ";")
            For Each zElement As String In zElements
                If zElement.ToLower.Contains("data source") Then Return zElement
            Next
            Return ""
        End Get
    End Property

    Public Shared ReadOnly Property Database As String
        Get
            Dim zElements() As String = Split(ConnectionString, ";")
            For Each zElement As String In zElements
                If zElement.ToLower.Contains("initial catalog") Then Return zElement
            Next
            Return ""
        End Get
    End Property

    Public Shared ReadOnly Property TimeOut As String
        Get
            Dim zElements() As String = Split(ConnectionString, ";")
            For Each zElement As String In zElements
                If zElement.ToLower.Contains("connect timeout") Then Return zElement
            Next
            Return ""
        End Get
    End Property

    Public Shared ReadOnly Property UserId As String
        Get
            Dim zElements() As String = Split(ConnectionString, ";")
            For Each zElement As String In zElements
                If zElement.ToLower.Contains("user id") Then Return zElement
            Next
            Return ""
        End Get
    End Property

    Public Shared ReadOnly Property Password As String
        Get
            Dim zElements() As String = Split(ConnectionString, ";")
            For Each zElement As String In zElements
                If zElement.ToLower.Contains("password") Then Return zElement
            Next
            Return ""
        End Get
    End Property

    Public Shared Function ExecuteProcedure(ByVal pCommand As String) As String
        Dim zReturn As String = ""

        Using myConnection As SqlConnection = New SqlConnection(UtilDB.ConnectionString)
            Dim zDt As New DataTable
            Dim zSW As New Diagnostics.Stopwatch
            Using myCommand As SqlCommand = New SqlCommand(pCommand, myConnection)
                myConnection.Open()
                ' Dim sdr As System.Data.SqlClient.SqlDataReader
                myCommand.CommandTimeout = 90 'seconds
                OutputStartMessage(myCommand)
                zSW.Start()
                Try
                    zDt.Load(myCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    zSW.Stop()
                    OutputFinishedMessage(myCommand, zSW.Elapsed, zDt.Rows.Count)

                    If zDt.Rows.Count > 0 Then
                        For Each dr As DataRow In zDt.Rows
                            zReturn = dr(0).ToString
                        Next
                    Else
                        zReturn = ""
                    End If

                Catch ex As Exception
                    Debug.WriteLine("Error!" & ex.Message & " (Elapsed: " & FormatNumber(zSW.Elapsed.TotalMinutes, 2) & "/min(s); )")
                    zSW.Stop()
                Finally
                    RecordExecutedProcedure(myCommand, zDt.Rows.Count, zSW.Elapsed)
                End Try
            End Using
        End Using
        Return zReturn
    End Function

    Public Shared Function ExecuteProcedure(ByVal pCommand As SqlClient.SqlCommand) As DataTable
        Dim zDt As New DataTable
        Dim zSW As New Diagnostics.Stopwatch
        OutputStartMessage(pCommand)
        zSW.Start()
        If pCommand.Connection Is Nothing Then pCommand.Connection = New SqlConnection(UtilDB.ConnectionString)
        If pCommand.Connection.State = ConnectionState.Closed Then pCommand.Connection.Open()
        pCommand.CommandTimeout = 90 'seconds
        Try
            zDt.Load(pCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            OutputFinishedMessage(pCommand, zSW.Elapsed, zDt.Rows.Count)
        Catch ex As Exception
            Debug.WriteLine("Error!" & ex.Message & " (Elapsed: " & FormatNumber(zSW.Elapsed.TotalMinutes, 2) & "/min(s); )")
        Finally
            zSW.Stop()
            RecordExecutedProcedure(pCommand, zDt.Rows.Count, zSW.Elapsed)
        End Try

        Return zDt
    End Function

    Public Shared Sub ExecuteProcedureNonQuery(ByVal pCommand As SqlClient.SqlCommand)
        Dim zSW As New Diagnostics.Stopwatch
        Dim zRows As Integer = 0
        OutputStartMessage(pCommand)
        zSW.Start()
        If pCommand.Connection Is Nothing Then pCommand.Connection = New SqlConnection(UtilDB.ConnectionString)
        If pCommand.Connection.State = ConnectionState.Closed Then pCommand.Connection.Open()
        Try
            zRows = pCommand.ExecuteNonQuery()
            OutputFinishedMessage(pCommand, zSW.Elapsed, zRows)
        Catch ex As Exception
            Debug.WriteLine("Error!" & ex.Message & " (Elapsed: " & FormatNumber(zSW.Elapsed.TotalMinutes, 2) & "/min(s); )")
        Finally
            zSW.Stop()
            RecordExecutedProcedure(pCommand, zRows, zSW.Elapsed)
        End Try
    End Sub

    Private Shared Sub RecordExecutedProcedure(ByVal pCommand As SqlClient.SqlCommand, ByVal pCount As Integer, ByVal pElapsed As TimeSpan)

        Dim zAllParms As New Dictionary(Of String, Object)
        For Each zParm As SqlClient.SqlParameter In pCommand.Parameters
            zAllParms.Add(zParm.ParameterName, zParm.Value)
        Next

        Dim zText As String = pCommand.CommandText & " (" & FormatNumber(pElapsed.TotalMinutes, 2) & " min; " & pCount & " rows)"

        '***GRC.Connect.Ed - Below code for review by Dan B. and Dan P.
        Dim zDt As New DataTable
        If HttpContext.Current IsNot Nothing Then
            If HttpContext.Current.Session IsNot Nothing Then
                If HttpContext.Current.Session("ExecutedProcedures") Is Nothing Then
                    zDt.Columns.Add("StoredProcedure")
                    zDt.Columns.Add("Parameters", GetType(Dictionary(Of String, Object)))
                    HttpContext.Current.Session("ExecutedProcedures") = zDt
                End If

                zDt = HttpContext.Current.Session("ExecutedProcedures")
                Dim zDr As DataRow = zDt.NewRow
                zDr(0) = zText
                zDr(1) = zAllParms
                zDt.Rows.Add(zDr)
            End If
        End If
    End Sub

    Private Shared Function CreateParameterString(ByVal pParameters As SqlClient.SqlParameterCollection) As String
        Dim zSB As New System.Text.StringBuilder
        For Each zParm As SqlClient.SqlParameter In pParameters
            If zSB.ToString = String.Empty Then
                zSB.Append(" ")
                zSB.Append(zParm.ParameterName & "='" & zParm.Value & "'")
            Else
                zSB.Append(", ")
                zSB.Append(zParm.ParameterName & "='" & zParm.Value & "'")
            End If
        Next
        Return zSB.ToString
    End Function

    Private Shared Sub OutputStartMessage(ByVal pCommand As SqlClient.SqlCommand)
        Debug.WriteLine("")
        Debug.WriteLine("ConnectionStringInfo: " & Server & "  " & Database & "  " & TimeOut)
        Debug.WriteLine("Executing Procedure: " & pCommand.CommandText & CreateParameterString(pCommand.Parameters) & " ...")
    End Sub

    Private Shared Sub OutputFinishedMessage(ByVal pCommand As SqlClient.SqlCommand, ByVal zElapsed As TimeSpan, ByVal zRecordCount As String)
        Debug.WriteLine("Executed Procedure: " & pCommand.CommandText & " Elapsed: " & FormatNumber(zElapsed.TotalMinutes, 2) & "/min(s); " & " Record Count: " & zRecordCount)
        Debug.WriteLine("")
        '  SaveToDatabase(pCommand, zElapsed, zRecordCount)
    End Sub

    'Private Shared Sub SaveToDatabase(ByVal pCommand As SqlClient.SqlCommand, ByVal pElapsed As TimeSpan, ByVal pRecordCount As String)

    '    Dim zObj As New Libraries.CoreLib.BusinessObjects.SysExecuteProcedures
    '    zObj.CommandText = pcommand.CommandText
    '    zObj.Parameters = CreateParameterString(pcommand.Parameters)
    '    zObj.Elapsed = FormatNumber(pElapsed.TotalMinutes, 2)
    '    zObj.ExecutedWhen = Now().ToString
    '    zObj.RecordCount = pRecordCount

    '    '***GRC.Connect.Ed - Replace with new function created by SB and class properties for getting session variables 7/30/2015
    '    'If HttpContext.Current IsNot Nothing Then
    '    '    If HttpContext.Current.Session IsNot Nothing Then
    '    '        If HttpContext.Current.Session("SafeGUID") IsNot Nothing Then
    '    '            zObj.ExecutedBy = UtilGSafe.GetValue(HttpContext.Current.Session("SafeGUID"), "UserId")
    '    '            zObj.FilePrefix = UtilGSafe.GetValue(HttpContext.Current.Session("SafeGUID"), "FilePrefix")
    '    '        Else
    '    '            zObj.ExecutedBy = "SYSTEM"
    '    '        End If
    '    '    Else
    '    '        zObj.ExecutedBy = "SYSTEM"
    '    '    End If
    '    'Else
    '    '    zObj.ExecutedBy = "SYSTEM"
    '    'End If

    '    If UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.SafeGUID) <> "" Then
    '        zObj.ExecutedBy = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.UserID)
    '        zObj.FilePrefix = UtilGSafe.GetValue(UtilGSafe.GetGUIDFromQueryString, UtilGSafe.KeyName.FilePreFix)
    '    Else
    '        zObj.ExecutedBy = "SYSTEM"
    '    End If
    '    zObj.Save()

    'End Sub

    Public Shared Function IsAlive() As Boolean
        Dim zCon As New SqlClient.SqlConnection(ConnectionString)
        Try
            zCon.Open()
            zCon.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function GetStringAssignmentValue(pString As String) As String
        Dim zReturn As String = Nothing
        If Not pString Is Nothing Then
            If pString.Contains("=") Then
                Dim zSplit() As String = Split(pString, "=")
                If zSplit.Count > 2 Then
                    zReturn = pString
                Else
                    zReturn = zSplit(1)
                End If
            Else
                zReturn = pString
            End If
        End If
        Return zReturn
    End Function


    'Public Shared Function GetDataTable(ByVal pQuery As String) As DataTable
    '    Dim zConn As SqlConnection = New SqlConnection(UtilDB.ConnectionString)
    '    Dim zDbAdapter As SqlDataAdapter = New SqlDataAdapter
    '    zDbAdapter.SelectCommand = New SqlCommand(pQuery, zConn)
    '    Dim zDbTable As DataTable = New DataTable
    '    zConn.Open()
    '    Try
    '        zDbAdapter.Fill(zDbTable)
    '    Finally
    '        zConn.Close()
    '    End Try
    '    Return zDbTable
    'End Function

    'Public Shared Function ColumnExists(ByVal pTableName As String, ByVal pColumnName As String) As Boolean
    '    Dim zReturn As Boolean = False
    '    Dim zQuery As String = "SELECT [" & pColumnName & "] FROM [" & pTableName & "] WHERE 0 = 1"
    '    Dim zSDR As SqlDataReader
    '    Using myConnection As SqlConnection = New SqlConnection(UtilDB.connectionString)
    '        Using myCommand As SqlCommand = New SqlCommand(zQuery, myConnection)
    '            myConnection.Open()
    '            Try
    '                zSDR = myCommand.ExecuteReader
    '                zReturn = True
    '            Catch ex As Exception
    '            End Try
    '        End Using
    '    End Using

    '    Return zReturn
    'End Function

    'Public Shared Function TableExists(ByVal pTableName As String, ByRef pHasData As Boolean) As Boolean
    '    Dim zQuery As String = "SELECT COUNT(*) FROM " & pTableName
    '    Dim zSDR As SqlDataReader
    '    Using myConnection As SqlConnection = New SqlConnection(UtilDB.connectionString)
    '        Using myCommand As SqlCommand = New SqlCommand(zQuery, myConnection)
    '            myConnection.Open()
    '            Try
    '                zSDR = myCommand.ExecuteReader
    '                pHasData = zSDR.HasRows
    '                Return True
    '            Catch ex As Exception
    '                Return False
    '            End Try
    '        End Using
    '    End Using
    'End Function

End Class
