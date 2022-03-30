Public Class UtilJob

    Public Shared Function Parse(ByVal pAssemblyName As String, ByVal pTypeName As String, ByVal pMethodName As String) As ParseResult

        Dim zResult As New ParseResult
        zResult.Assembly = Reflection.Assembly.Load(pAssemblyName)

        If pTypeName.Contains("+") Then
            Dim zTypeNameParts As List(Of String) = Split(pTypeName, "+").ToList
            Dim zParentType As Type = zResult.Assembly.GetTypes.ToList.Find(Function(x) x.Name = zTypeNameParts(0))
            Dim zNestedQualifiedName As String = zParentType.Namespace & "." & pTypeName
            zResult.Type = zResult.Assembly.GetTypes.ToList.Find(Function(x) x.FullName.Contains(zNestedQualifiedName))
        Else
            zResult.Type = zResult.Assembly.GetTypes.ToList.Find(Function(x) x.Name = pTypeName)
        End If

        zResult.Method = zResult.Type.GetMethod(pMethodName)

        If IsNothing(zResult.Type) Then Throw New ArgumentException("Could not find type [" & pTypeName & "] in assembly [" & pAssemblyName & "].", pTypeName)
        If IsNothing(zResult.Method) Then Throw New ArgumentException("Could not find method [" & pMethodName & "] in type [" & pTypeName & "].", pMethodName)

        Return zResult

    End Function

    Public Shared Function GetSchedule(pScheduleType As ScheduleType, pScheduleId As Integer) As List(Of DateTime)
        Dim zList As List(Of DateTime) = Nothing

        Select Case pScheduleType

            Case ScheduleType.Minute
                Dim zDaily As New rowTblMinuteSchedule
                zList = zDaily.BuildSchedule

            Case ScheduleType.Daily
                Dim zDaily As New rowTblDailySchedule
                zList = zDaily.BuildSchedule()

            Case ScheduleType.Monthly
                Dim zMonthly As New rowTblDailySchedule
                zList = zMonthly.BuildSchedule()

            Case ScheduleType.Weekly
                Dim Weekly As New rowTblDailySchedule
                zList = Weekly.BuildSchedule()

        End Select

        Return zList
    End Function

    Public Class ParseResult
        Public Property Assembly As Reflection.Assembly = Nothing
        Public Property Type As System.Type = Nothing
        Public Property Method As Reflection.MethodInfo = Nothing
    End Class


#Region "Enumerations"
    Public Enum JobStatus
        Initializing = 0
        Waiting = 1
        Running = 2
        Completed = 3
        Exception = 4
        Disabled = 5
    End Enum

    Public Enum ScheduleType
        Minute = 1
        Daily = 2
        Weekly = 3
        Monthly = 4
    End Enum

#End Region




End Class
