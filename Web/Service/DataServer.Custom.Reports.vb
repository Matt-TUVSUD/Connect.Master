Imports System
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery
Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Web
Imports System.Web.Script.Services
Imports EntitySpaces.Core

Namespace Service
    Partial Public Class DataServer


        '#Region "Report Job Defs"

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function getJobDefs(GSafeGuid As String) As jsResponse(Of RERptJobDefCollection, RERptJobDef)
        '            Dim zResponse As New jsResponse(Of RERptJobDefCollection, RERptJobDef)()
        '            Dim zSafeGUID As String = GSafeGuid

        '            Try
        '                Dim zColl As New RERptJobDefCollection
        '                Dim zQry As New RERptJobDefQuery()

        '                zQry.SelectAll()
        '                'ADD FILTERING HERE
        '                zColl.Load(zQry)

        '                If zColl.Count = 0 Then
        '                    zColl.AddNew() 'create a blank record when no matching records existing
        '                    With zColl(0)
        '                        .JobDefId = 0
        '                        .RptSetId = 0
        '                        .RptCode = ""
        '                        .StatusId = 0
        '                        .StatusDate = "1/1/1900"
        '                        .PumpDate = "1/1/1900"
        '                        .ErrorMessage = ""
        '                    End With
        '                End If

        '                zResponse.collection = zColl

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '            End Try

        '            Return zResponse

        '        End Function

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function addJobDefs(pParms As String) As jsResponse(Of RERptJobDefCollection, RERptJobDef)
        '            Dim zResponse As New jsResponse(Of RERptJobDefCollection, RERptJobDef)()
        '            Dim zColl As New RERptJobDefCollection
        '            Dim zQry As New RERptJobDefQuery()
        '            Dim zParms() As String = Split(pParms, "|")
        '            Dim zSafeGUID As String = zParms(0)
        '            Dim zReportSetId As Integer = Val(zParms(1))
        '            Dim zFirstReportCode As Integer = Val(zParms(2))
        '            Dim zJobId As Integer = 0

        '            Try
        '                '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
        '                Dim zFilePrefix As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FilePreFix)
        '                Dim zEmail As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.UserEmail)
        '                Dim zRJ As New UtilReportEngine

        '                ' CREATE THE FIRST JOB
        '                zRJ.FilePrefix = zFilePrefix
        '                zJobId = zRJ.CreateJob(zReportSetId, zFirstReportCode, zEmail) ' WILL HAVE TO CHANGE THIS CODE SO WE CAN FIND EXISTING SET ID'S... HERE IT IS ZERO.

        '                ' UPDATE THE SET ID TO THE NEWLY CREATED SET, AND ADD ADDITIONAL REPORTS IF NEEDED
        '                zReportSetId = zRJ.RptSetId
        '                If zParms.Length > 3 Then
        '                    Dim x As Integer
        '                    For x = 3 To zParms.Length - 1
        '                        zJobId = zRJ.CreateJob(zReportSetId, Val(zParms(x)), zEmail)
        '                    Next x
        '                End If

        '                ' QUERY TO FIND THE SET ID TO RETURN IT TO THE CLIENT CODE
        '                zQry.SelectAll()
        '                zQry.Where(zQry.RptSetId = zRJ.RptSetId)
        '                zColl.Load(zQry)

        '                If zColl.Count = 0 Then
        '                    zColl.AddNew() 'create a blank record when no matching records existing
        '                    With zColl(0)
        '                        .JobDefId = 0
        '                        .RptSetId = 0
        '                        .RptCode = "Not Found"
        '                        .StatusId = 0
        '                        .StatusDate = "1/1/1900"
        '                        .PumpDate = "1/1/1900"
        '                        .ErrorMessage = ""
        '                    End With
        '                End If

        '                zResponse.collection = zColl

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '            End Try

        '            Return zResponse

        '        End Function

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function removeJobDefs(pReportSetId As String) As jsResponse(Of RERptJobDefCollection, RERptJobDef)
        '            Dim zResponse As New jsResponse(Of RERptJobDefCollection, RERptJobDef)()

        '            Try
        '                Dim zColl As New RERptJobDefCollection
        '                Dim zQry As New RERptJobDefQuery()
        '                Dim zCollJobLog As New ViewCCRERptJobLogCollection
        '                Dim zQryJobLog As New ViewCCRERptJobLogQuery
        '                Dim zRJ As New UtilReportEngine

        '                ' GET THE LIST OF ALL JOBS BELONGING TO A SET
        '                zQryJobLog.SelectAll()
        '                zQryJobLog.Where(zQryJobLog.RptSetId = pReportSetId)
        '                zCollJobLog.Load(zQryJobLog)

        '                ' REMOVE ALL JOBS BELONGING TO THE SET
        '                For Each zObjJobLog As ViewCCRERptJobLog In zCollJobLog
        '                    zRJ.DeleteJob(zObjJobLog.JobDefId)
        '                Next

        '                ' QUERY TO FIND IF ANY JOBS REMAIN IN THE SET
        '                zQry.SelectAll()
        '                zQry.Where(zQry.RptSetId = pReportSetId)
        '                zColl.Load(zQry)

        '                If zColl.Count = 0 Then
        '                    zColl.AddNew() 'create a blank record when no matching records existing
        '                    With zColl(0)
        '                        .JobDefId = 0
        '                        .RptSetId = 0
        '                        .RptCode = "Not Found"
        '                        .StatusId = 0
        '                        .StatusDate = "1/1/1900"
        '                        .PumpDate = "1/1/1900"
        '                        .ErrorMessage = ""
        '                    End With
        '                End If

        '                zResponse.collection = zColl

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '            End Try

        '            Return zResponse
        '        End Function

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function addRptSetSettings(pParms As String) As jsResponse(Of RERptJobDefCollection, RERptJobDef)
        '            Dim zResponse As New jsResponse(Of RERptJobDefCollection, RERptJobDef)()

        '            'Try
        '            '    Dim zColl As New RERptJobDefCollection
        '            '    Dim zRJ As New GRC.Connect.Libraries.CoreLib.UtilReportEngine
        '            '    Dim zParms() As String = Split(pParms, "|")
        '            '    Dim zReportSetId As Integer = Val(zParms(0))
        '            '    Dim zCurrency As String = zParms(1)
        '            '    Dim zUnits As String = zParms(2)

        '            '    ' SET THE REPORT SETTINGS
        '            '    zRJ.FilterValue(zReportSetId, Libraries.CoreLib.UtilReporting.ReportFilter.ConvertCurrency) = zCurrency
        '            '    zRJ.FilterValue(zReportSetId, Libraries.CoreLib.UtilReporting.ReportFilter.ConvertUnits) = zUnits

        '            '    ' SET THE FILTER LIST
        '            '    ClientConnect.Libraries.CoreLib.UtilReportHost.BuildRptSetFilteredFileNo(zReportSetId, AppSession.FilterSQL)

        '            '    ' CHANGE THE STATUS OF THE REPORT SET
        '            '    zRJ.QueueRptSet(zReportSetId)

        '            '    zColl.AddNew() 'create a blank record when no matching records existing
        '            '    With zColl(0)
        '            '        .JobDefId = 0
        '            '        .RptSetId = 0
        '            '        .RptCode = ""
        '            '        .StatusId = 0
        '            '        .StatusDate = "1/1/1900"
        '            '        .PumpDate = "1/1/1900"
        '            '        .ErrorMessage = "success"
        '            '    End With

        '            '    zResponse.collection = zColl

        '            'Catch ex As Exception
        '            '    zResponse.exception = ex.Message
        '            'End Try

        '            Return zResponse

        '        End Function

        '        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        '        Public Function SetAccessDate(pParms As String) As jsResponse(Of REDocHeaderCollection, REDocHeader)
        '            Dim zResponse As New jsResponse(Of REDocHeaderCollection, REDocHeader)()

        '            Try
        '                Dim zColl As New REDocHeaderCollection
        '                Dim zObj As New REDocHeader
        '                Dim zQry As New REDocHeaderQuery
        '                Dim zParms() As String = Split(pParms, "|")
        '                Dim zGSafeGuid As String = zParms(0)
        '                Dim zFileGuid As String = zParms(1)
        '                Dim zDateStamp = Today()

        '                zQry.SelectAll()
        '                zQry.Where(zQry.REDocGUID = zFileGuid)
        '                If zObj.Load(zQry) Then
        '                    zObj.AccessDate = zDateStamp
        '                    zObj.Save()
        '                    zColl.AddNew()
        '                    With zColl(0)
        '                        .REDocId = 0
        '                        .REDocGUID = "success"
        '                        .SafeId = 0
        '                        .OwnerId = 0
        '                        .RptSetId = 0
        '                        .CreateDate = "1/1/1900"
        '                        .AccessDate = zDateStamp
        '                        .FileSizeBytes = 0
        '                    End With
        '                Else
        '                    With zColl(0)
        '                        .REDocId = 0
        '                        .REDocGUID = "fail"
        '                        .SafeId = 0
        '                        .OwnerId = 0
        '                        .RptSetId = 0
        '                        .CreateDate = "1/1/1900"
        '                        .AccessDate = "1/1/1900"
        '                        .FileSizeBytes = 0
        '                        Dim zEL As New UtilLog
        '                        zEL.LogIt("myBatchReports (AccessDate WCF): Lookup to save " & zFileGuid & " failed.", UtilLog.EventLevel.Debug, UtilLog.EventType.PumpServer, 0, 0, 0, False)
        '                    End With
        '                End If

        '                zResponse.collection = zColl

        '            Catch ex As Exception
        '                zResponse.exception = ex.Message
        '                Dim zEL As New UtilLog
        '                zEL.LogIt("myBatchReports (AccessDate WCF): Error in WCF - " & ex.Message, UtilLog.EventLevel.Debug, UtilLog.EventType.PumpServer, 0, 0, 0, False)
        '            End Try

        '            Return zResponse

        '        End Function


        '#End Region


#Region "Report Archive"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetReportArchiveByGuidPractice(pParms As String) As jsResponse(Of ReportArchiveCollection, ReportArchive)
            Dim zResponse As New jsResponse(Of ReportArchiveCollection, ReportArchive)()
            Dim zParms() As String = pParms.Split("|")
            Dim zSafeGUID As String = zParms(0)
            Dim zPractice As String = zParms(1)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New ReportArchiveCollection
                Dim zQry As New ReportArchiveQuery()

                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo, zQry.Practice = zPractice)
                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .Id = 0
                        .FileNo = ""
                        .ReportDate = "1/1/1900"
                        .Report1 = ""
                        .Report2 = ""
                        .Diagram = ""
                        .Practice = ""
                        .DatePosted = "1/1/1900"
                        .DateTransferred = "1/1/1900"
                        .DateToClient = "1/1/1900"
                        .PreviousDateCompleted = "1/1/1900"
                        .PreviousReport1 = ""
                        .PreviousDiagram = ""

                    End With
                End If

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetGrippsDateCompleted(pParms As String) As jsResponse(Of ReportArchiveCollection, ReportArchive)
            Dim zResponse As New jsResponse(Of ReportArchiveCollection, ReportArchive)()
            Dim zReturn As New ReportArchiveCollection
            Dim zParms() As String = pParms.Split("|")
            Dim zSafeGUID As String = zParms(0)
            Dim zPracticeCode As String = zParms(1)
            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            Dim zFileNo As String = UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.FileNo)

            Try
                Dim zColl As New GRIPSSWorkloadCollection
                Dim zQry As New GRIPSSWorkloadQuery()

                'zQry.es.Top = 1
                zQry.SelectAll()
                zQry.Where(zQry.FileNo = zFileNo, zQry.PracticeCode = zPracticeCode)
                zQry.OrderBy(zQry.DateCompleted.Descending)
                If zColl.Load(zQry) Then
                    Dim zDateCompleted As Date = Today()
                    Dim zDateMailedToClient As Date = Today()
                    If Not zColl(0).DateCompleted Is Nothing Then
                        zDateCompleted = zColl(0).DateCompleted
                    End If
                    If Not zColl(0).Rpt1Client Is Nothing Then
                        zDateMailedToClient = zColl(0).Rpt1Client
                    ElseIf Not zColl(0).Rpt2Client Is Nothing Then
                        zDateMailedToClient = zColl(0).Rpt2Client
                    ElseIf Not zColl(0).Rpt3Client Is Nothing Then
                        zDateMailedToClient = zColl(0).Rpt3Client
                    ElseIf Not zColl(0).Rpt4Client Is Nothing Then
                        zDateMailedToClient = zColl(0).Rpt4Client
                    End If
                    If zColl(zColl.Count - 1).InspectionStatus.ToLower() = "pending" Then
                        zDateCompleted = Today()
                        zDateMailedToClient = Today()
                    End If
                    zReturn.AddNew()
                    With zReturn(0)
                        .Id = 0
                        .FileNo = ""
                        .ReportDate = zDateCompleted
                        .Report1 = ""
                        .Report2 = ""
                        .Diagram = ""
                        .Practice = ""
                        .DatePosted = "1/1/1900"
                        .DateTransferred = "1/1/1900"
                        .DateToClient = zDateMailedToClient
                        .PreviousDateCompleted = "1/1/1900"
                        .PreviousReport1 = ""
                        .PreviousDiagram = ""
                    End With
                Else
                    zReturn.AddNew() 'create a blank record when no matching records existing
                    With zReturn(0)
                        .Id = 0
                        .FileNo = "not found"
                        .ReportDate = "1/1/1900"
                        .Report1 = ""
                        .Report2 = ""
                        .Diagram = ""
                        .Practice = ""
                        .DatePosted = "1/1/1900"
                        .DateTransferred = "1/1/1900"
                        .DateToClient = "1/1/1900"
                        .PreviousDateCompleted = "1/1/1900"
                        .PreviousReport1 = ""
                        .PreviousDiagram = ""
                    End With

                End If

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            zResponse.collection = zReturn
            Return zResponse

        End Function

#End Region

    End Class
End Namespace
