Imports System.Web

Public Class UtilLog
    Public Event LogMessage(pMessage As String)
    Private Shared _EnableLog As Boolean = False
    Public LastLogMessageText As String = ""
    Public LastLogMessageDate As Date

     Public Enum EventType
          RouterServer = 1
          PumpServer
          PumpWeb
          PublishServer
          LogServer
        GridReport
        MaintenanceServer
        DataTransfer
     End Enum

    Public Enum EventLevel
        Debug = 1
        Information
        Warning
        Alert
        Critical
        Shutdown
        Startup
    End Enum

    Public Sub TrimEventLog()
        Dim zArchiveDays As Integer = Val(UtilSystemParms.ReadServiceEventLogArchiveDays)

        If zArchiveDays = 0 Then zArchiveDays = 3
        zArchiveDays = zArchiveDays * -1

        Dim zSQL As String = ""

        zSQL = "EXEC sprocTrimEventLog " & zArchiveDays
        UtilDB.ExecuteProcedure(zSQL)

        ' Too slow for log size over 1million
        'Dim zEL As New BusinessObjects.EventLogCollection
        'zEL.Query.Select()
        'zEL.Query.Where(zEL.Query.EventTypeId = 1)
        'zEL.Query.Where(zEL.Query.EventDate < Now.AddDays(zArchiveDays))
        'If zEL.Query.Load Then
        '    'LogIt("Trimming Event Log entries older then " & zArchiveDays & " days.")
        '    zEL.MarkAllAsDeleted()
        '    zEL.Save()
        'End If
        'zEL = Nothing
    End Sub

    Public Sub LogIt(pMessage As String)

        Dim zEL As New BusinessObjects.EventLog
        zEL.Message = RTrim(pMessage)
        zEL.EventDate = Now
        zEL.EventTypeId = UtilLog.EventType.LogServer
        zEL.EventLevelId = UtilLog.EventLevel.Debug
        zEL.RptSetId = 0
        zEL.JobDefId = 0
        zEL.REDocId = 0
        zEL.Save()
        zEL = Nothing

        RaiseEvent LogMessage(pMessage)
    End Sub

    'Public Sub LogIt(pMessage As String, pEventLevel As EventLevel, pEventType As EventType, pRptSetId As Integer, pJobDefId As Integer, pREDocId As Integer, pAlertViaEmail As Boolean)
    '    Dim zMessage500 As String = Left(pMessage, 500)
    '    Dim zEL As New BusinessObjects.EventLog

    '    If UtilDB.IsAlive Then
    '        zEL.Message = RTrim(zMessage500)
    '        zEL.EventDate = Now
    '        zEL.EventTypeId = pEventType
    '        zEL.EventLevelId = pEventLevel
    '        If pRptSetId > 0 Then zEL.RptSetId = pRptSetId
    '        If pJobDefId > 0 Then zEL.JobDefId = pJobDefId
    '        If pREDocId > 0 Then zEL.REDocId = pREDocId
    '        zEL.Save()
    '    End If

    '    If UtilDB.IsAlive Then
    '        Dim zET As New BusinessObjects.EventType
    '        Dim zEventTypeDesc As String = ""
    '        If zET.LoadByPrimaryKey(zEL.EventTypeId) Then
    '            zEventTypeDesc = zET.Description
    '        End If
    '    End If

    '    'Email flood control - if the message is the same and within 60 minutes do not send message
    '    If pMessage <> Me.LastLogMessageText And DateDiff(DateInterval.Hour, Me.LastLogMessageDate, Now) > 1 Then
    '        If pAlertViaEmail Then
    '            Dim zMM As New UtilMail(BusinessObjects.EmailFlag.EmailFlagEnum.Exception)
    '            Dim zEmailDisplayName As String = UtilSystemParms.ReadReportServerErrorsDisplayName
    '            Dim zEmailAddress As String = UtilSystemParms.ReadReportServerErrorsEmailAddress
    '            Dim zMessage As String = ""
    '            Dim zReportName As String = "N/A"
    '            Dim zOwnerName As String = "N/A"
    '            Dim zOwnerId As Integer = 0
    '            Dim zFileName As String = "N/A"
    '            Dim zFilePrefix As String = "N/A"
    '            Dim zMode As String = "Interactive"

    '            If pJobDefId > 0 Then
    '                Dim zRJD As New BusinessObjects.RERptJobDef
    '                If zRJD.LoadByPrimaryKey(pJobDefId) Then
    '                    Dim zRD As New BusinessObjects.RERptDef
    '                    If zRD.LoadByRptCode(zRJD.RptCode) Then
    '                        zReportName = zRD.ReportName
    '                    End If
    '                End If
    '            End If

    '            If pRptSetId > 0 Then
    '                Dim zRS As New BusinessObjects.RERptSet
    '                If zRS.LoadByPrimaryKey(pRptSetId) Then
    '                    zOwnerId = zRS.OwnerId
    '                    zFilePrefix = zRS.FilePrefix
    '                    If zRS.ExecuteMode = 2 Then
    '                        zMode = "Batch"
    '                    End If
    '                    Dim zON As New BusinessObjects.REOwner
    '                    If zON.LoadByPrimaryKey(zRS.OwnerId) Then
    '                        zOwnerId = zRS.OwnerId
    '                        zOwnerName = zON.Email
    '                    End If
    '                End If
    '            End If

    '            If pREDocId > 0 Then
    '                Dim zRD As New BusinessObjects.REDocHeader
    '                If zRD.LoadByPrimaryKey(pREDocId) Then
    '                    zFileName = zRD.REDocGUID & ".pdf"
    '                End If
    '            End If

    '            zMessage = zMessage & "Message: " & zMessage500 & vbCrLf
    '            zMessage = zMessage & "EventLogId: " & zEL.LogId & vbCrLf
    '            zMessage = zMessage & "EventSource: " & pEventType & " - " & [Enum].GetName(GetType(EventType), pEventType) & vbCrLf
    '            zMessage = zMessage & "EventLevel: " & pEventLevel & " - " & [Enum].GetName(GetType(EventLevel), pEventLevel) & vbCrLf
    '            zMessage = zMessage & "EventDate: " & zEL.EventDate & vbCrLf
    '            zMessage = zMessage & "RptSetId: " & pRptSetId & " - " & zFilePrefix & vbCrLf
    '            zMessage = zMessage & "OwnerId: " & zOwnerId & " - " & zOwnerName & vbCrLf
    '            zMessage = zMessage & "JobDefId: " & pJobDefId & " - " & zReportName & vbCrLf
    '            zMessage = zMessage & "REDocId: " & pREDocId & " - " & zFileName & vbCrLf
    '            zMessage = zMessage & "Mode: " & zMode & vbCrLf

    '            zMM.InitMail()
    '            zMM.MailSubject = [Enum].GetName(GetType(EventLevel), pEventLevel) & ": GRC Connect EventLog (" & [Enum].GetName(GetType(EventType), pEventType) & ") - " & UtilSystemParms.ReadWebAppMode
    '            zMM.MailBody = zMessage
    '            zMM.MailTo.Clear()
    '            zMM.MailTo.Add(zEmailAddress, zEmailDisplayName)

    '            'Add MailLogBCC
    '            If Not UtilSystemParms.ReadEmailLogBCC Is Nothing Then
    '                If UtilSystemParms.ReadEmailLogBCC.Length > 0 Then
    '                    zMM.MailBCC.Add(UtilSystemParms.ReadEmailLogBCC, UtilSystemParms.ReadEmailLogBCC)
    '                End If
    '            End If

    '            zMM.SendMail(False)
    '        End If
    '    End If


    '    'RaiseEvent LogMessage(pMessage & " - EventType: " & pEventType & "TemplateId: " & pTemplateId & "RecipientId: " & pRecipientId)
    'End Sub

    'Public Shared Property EnableFileLog()
    '    Get
    '        Return _EnableLog
    '    End Get
    '    Set(value)
    '        _EnableLog = value
    '    End Set
    'End Property

    'Public Shared Sub FileLogIt(ByVal Text As String, Optional Value As String = "")
    '    If _EnableLog Then
    '        Dim zAppRoot As String = HttpContext.Current.Request.PhysicalApplicationPath
    '        Dim zPageName As String = HttpContext.Current.Request.PhysicalPath
    '        Dim zSw As IO.StreamWriter = IO.File.AppendText(zAppRoot & "\CheckListAdmin.log")
    '        zSw.WriteLine(Now & " --- " & Text & " [value=" & Value & "]")
    '        zSw.Close()
    '    End If
    'End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
