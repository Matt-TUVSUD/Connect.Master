
Partial Class TblJob

    Private Shared Sub TblJob_LoadItemCreated(ByRef pItem As rowTblJob) Handles Me.LoadItemCreated
        Select Case pItem.colFldScheduleTypeId
            Case UtilJob.ScheduleType.Daily
                pItem.ScheduleType = UtilJob.ScheduleType.Daily
                pItem.Schedule = TblDailySchedule.LoadByPrimaryKey(pItem.colFldScheduleId)

            Case UtilJob.ScheduleType.Monthly
                pItem.ScheduleType = UtilJob.ScheduleType.Monthly
                pItem.Schedule = TblMonthlySchedule.LoadByPrimaryKey(pItem.colFldScheduleId)
      
            Case UtilJob.ScheduleType.Weekly
                pItem.ScheduleType = UtilJob.ScheduleType.Weekly
                pItem.Schedule = TblWeeklySchedule.LoadByPrimaryKey(pItem.colFldScheduleId)

            Case UtilJob.ScheduleType.Minute
                pItem.ScheduleType = UtilJob.ScheduleType.Minute
                pItem.Schedule = TblMinuteSchedule.LoadByPrimaryKey(pItem.colFldScheduleId)
        End Select

        If pItem.colFldLastStatus = "" Then pItem.LastStatus = UtilJob.JobStatus.Initializing

    End Sub
End Class

Partial Class rowTblJob
    Public Schedule As IJobSchedule
    Public ScheduleType As UtilJob.ScheduleType

    Public Property LastStatus As UtilJob.JobStatus
        Get
            Return [Enum].Parse(GetType(UtilJob.JobStatus), Me.colFldLastStatus)
        End Get
        Set(value As UtilJob.JobStatus)
            Me.colFldLastStatus = value.ToString
        End Set
    End Property

    Public Sub Run()
        Dim zParseResult As UtilJob.ParseResult = Nothing

        If colFldIsEnabled = True Then
            If (LastStatus = UtilJob.JobStatus.Waiting Or LastStatus = UtilJob.JobStatus.Completed) Or (colFldReset) Then
                If (Now > colFldNextScheduledTime) Or (colFldReset) Then
                    Try
                        zParseResult = UtilJob.Parse(colFldAssemblyName, colFldTypeName, colFldMethodName)
                        Dim zObj As Object = Activator.CreateInstance(zParseResult.Type, True)
                        If TypeOf zObj Is IJob Then
                            DirectCast(zObj, IJob).Job = Me

                            LastStatus = UtilJob.JobStatus.Running
                            colFldLastExecutedTime = Now
                            colFldNextScheduledTime = Schedule.GetNextScheduledDate
                            colFldReset = False
                            TblJob.Save(Me)

                            zParseResult.Method.Invoke(zObj, Nothing)
                            LastStatus = UtilJob.JobStatus.Completed
                            TblJob.Save(Me)
                        Else
                            Throw New ArgumentException("The type [" & colFldTypeName & "] does not implement the IJob Interface.", "colFldTypeName")
                        End If

                    Catch ex As Exception
                        colFldReset = False
                        LastStatus = UtilJob.JobStatus.Exception
                        TblJob.Save(Me)

                        Dim zJobException As New UtilJobException(ex, Me)
                        Throw zJobException

                    End Try
                End If
            ElseIf LastStatus = UtilJob.JobStatus.Initializing Or LastStatus = UtilJob.JobStatus.Disabled Then
                LastStatus = UtilJob.JobStatus.Waiting
                colFldNextScheduledTime = Schedule.GetNextScheduledDate
                TblJob.Save(Me)
            End If
        Else
            colFldNextScheduledTime = Schedule.GetNextScheduledDate
            LastStatus = UtilJob.JobStatus.Disabled
            TblJob.Save(Me)
        End If

    End Sub

    Public Function IsScheduledToRun() As Boolean

        If Me.colFldIsEnabled = True Then
            If (LastStatus = UtilJob.JobStatus.Waiting Or LastStatus = UtilJob.JobStatus.Completed) Or (Me.colFldReset) Then
                If (Now > colFldNextScheduledTime) Or (colFldReset) Then
                    Return True
                End If
            ElseIf LastStatus = UtilJob.JobStatus.Initializing Or UtilJob.JobStatus.Disabled Then
                Me.LastStatus = UtilJob.JobStatus.Waiting
                TblJob.Save(Me)
            End If
        Else
            If Not Me.LastStatus = UtilJob.JobStatus.Disabled Then
                Me.LastStatus = UtilJob.JobStatus.Disabled
                TblJob.Save(Me)
            End If
        End If

        Return False

    End Function

End Class


Partial Class rowTblMonthlySchedule
    Implements IJobSchedule

    Public Function GetNextScheduledDate() As Date Implements IJobSchedule.GetNextScheduledDate
        Return BuildSchedule(0)
    End Function

    Public Function ScheduleType() As UtilJob.ScheduleType Implements IJobSchedule.ScheduleType
        Return UtilJob.ScheduleType.Monthly
    End Function

    Public Function BuildSchedule() As List(Of Date) Implements IJobSchedule.BuildSchedule
        Dim zList As New List(Of Date)
        For i = 1 To 5
            BuildScheduleWorker(zList)
        Next
        Return zList
    End Function

    Public Sub BuildScheduleWorker(pList As List(Of Date)) Implements IJobSchedule.BuildScheduleWorker
        Dim zDateToCompare As DateTime = Now
        If pList.Count > 0 Then zDateToCompare = pList.Last

        Do Until Me.colFldStartDateTime > zDateToCompare
            Me.colFldStartDateTime = zDateToCompare.AddMonths(1)
        Loop

        For i = 1 To 12
            If Me.colFldStartDateTime.Value.Month = 1 Then
                If Me.colFldInJanuary Then pList.Add(Me.colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 2 Then
                If Me.colFldInFebruary Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 3 Then
                If Me.colFldInMarch Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 4 Then
                If Me.colFldInApril Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 5 Then
                If Me.colFldInMay Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 6 Then
                If Me.colFldInJune Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 7 Then
                If Me.colFldInJuly Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 8 Then
                If Me.colFldInAugust Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 9 Then
                If Me.colFldInSeptember Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 10 Then
                If Me.colFldInOctober Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 11 Then
                If Me.colFldInNovember Then pList.Add(colFldStartDateTime)
            End If

            If Me.colFldStartDateTime.Value.Month = 12 Then
                If Me.colFldInDecember Then pList.Add(colFldStartDateTime)
            End If

            Me.colFldStartDateTime = Me.colFldStartDateTime.Value.AddMonths(1)

        Next

    End Sub
End Class


Partial Class rowTblDailySchedule
    Implements IJobSchedule

    Public Function GetNextScheduledDate() As Date Implements IJobSchedule.GetNextScheduledDate
        Return BuildSchedule(0)
    End Function

    Public Function ScheduleType() As UtilJob.ScheduleType Implements IJobSchedule.ScheduleType
        Return UtilJob.ScheduleType.Daily
    End Function

    Public Function BuildSchedule() As List(Of Date) Implements IJobSchedule.BuildSchedule
        Dim zList As New List(Of Date)
        For i = 1 To 5
            BuildScheduleWorker(zList)
        Next
        Return zList
    End Function

    Public Sub BuildScheduleWorker(pList As List(Of Date)) Implements IJobSchedule.BuildScheduleWorker
        Dim zDateToCompare As DateTime = Now
        If pList.Count > 0 Then zDateToCompare = pList.Last

        If Me.colFldStartDateTime > zDateToCompare Then
            pList.Add(Me.colFldStartDateTime)
        Else
            Do Until Me.colFldStartDateTime > zDateToCompare
                colFldStartDateTime = colFldStartDateTime.Value.AddDays(Me.colFldRecurEveryDays)
            Loop
            pList.Add(colFldStartDateTime)
        End If
    End Sub
End Class


Partial Class rowTblWeeklySchedule
    Implements IJobSchedule

    Public Function GetNextScheduledDate() As Date Implements IJobSchedule.GetNextScheduledDate
        Return BuildSchedule(0)
    End Function

    Public Function ScheduleType() As UtilJob.ScheduleType Implements IJobSchedule.ScheduleType
        Return UtilJob.ScheduleType.Weekly
    End Function

    Public Function BuildSchedule() As List(Of Date) Implements IJobSchedule.BuildSchedule
        Dim zList As New List(Of Date)
        For i = 1 To 5
            BuildScheduleWorker(zList)
        Next
        Return zList
    End Function

    Public Sub BuildScheduleWorker(pList As List(Of Date)) Implements IJobSchedule.BuildScheduleWorker

        Dim zDateToCompare As DateTime = Now
        If pList.Count > 0 Then zDateToCompare = pList.Last

        Do Until Me.colFldStartDateTime > zDateToCompare
            Me.colFldStartDateTime = colFldStartDateTime.Value.AddDays(7)
        Loop

        For i = 1 To 7
            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Sunday Then
                If Me.colFldOnSunday Then pList.Add(colFldStartDateTime)
            End If

            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Monday Then
                If Me.colFldOnMonday Then pList.Add(colFldStartDateTime)
            End If

            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Tuesday Then
                If Me.colFldOnTuesday Then pList.Add(colFldStartDateTime)
            End If

            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Wednesday Then
                If Me.colFldOnWednesday Then pList.Add(colFldStartDateTime)
            End If

            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Thursday Then
                If Me.colFldOnThursday Then pList.Add(colFldStartDateTime)
            End If

            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Friday Then
                If Me.colFldOnFriday Then pList.Add(colFldStartDateTime)
            End If

            If colFldStartDateTime.Value.DayOfWeek = DayOfWeek.Saturday Then
                If Me.colFldOnSaturday Then pList.Add(colFldStartDateTime)
            End If

            Me.colFldStartDateTime = Me.colFldStartDateTime.Value.AddMonths(1)

        Next

    End Sub

End Class


Partial Class rowTblMinuteSchedule
    Implements IJobSchedule

    Public Function GetNextScheduledDate() As Date Implements IJobSchedule.GetNextScheduledDate
        Return BuildSchedule(0)
    End Function

    Public Function ScheduleType() As UtilJob.ScheduleType Implements IJobSchedule.ScheduleType
        Return UtilJob.ScheduleType.Minute
    End Function

    Public Function BuildSchedule() As List(Of Date) Implements IJobSchedule.BuildSchedule
        Dim zList As New List(Of Date)
        For i = 1 To 5
            BuildScheduleWorker(zList)
        Next
        Return zList
    End Function

    Public Sub BuildScheduleWorker(pList As List(Of Date)) Implements IJobSchedule.BuildScheduleWorker
        Dim zDateToCompare As DateTime = Now
        If pList.Count > 0 Then zDateToCompare = pList.Last

        If Me.colFldStartDateTime > zDateToCompare Then
            pList.Add(Me.colFldStartDateTime)
        Else
            Do Until Me.colFldStartDateTime > zDateToCompare
                colFldStartDateTime = colFldStartDateTime.Value.AddMinutes(Me.colFldRecurEveryMinute)
            Loop
            pList.Add(colFldStartDateTime)
        End If

    End Sub
End Class