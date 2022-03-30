﻿Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects

Public Class EmailIt
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim zGUID = context.Request("GSafeGUID").ToString()

        Try
            'PASSED PARMS
            Dim zURL = context.Request("PageURL").ToString()
            Dim zComments = context.Request("Comments").ToString()

            'Dim zMM As New GRC.Connect.Libraries.CoreLib.UtilMail(EmailFlag.EmailFlagEnum.UserFeedBack)
            Dim zObj As New NavLink
            zObj.LoadByPrimaryKey(Val(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, "currentPage")))

            'INFORMATION FIELDS
            Dim zMessage As String = ""
            Dim zUserName As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, "userFullName")
            Dim zEmail As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, "UserEmail")
            Dim zClient As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, "clientName")
            Dim zPractice As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, "practiceName")
            Dim zPageName As String = zObj.NavText
            Dim zPageId As String = zObj.NavLinkId.ToString()
            Dim zParentName As String = "None"
            Dim zParentId As Integer = 0
            If Not zObj.NavParentLinkId Is Nothing Then
                zParentId = zObj.NavParentLinkId
                zObj.LoadByPrimaryKey(zParentId)
                zParentName = zObj.NavText
            End If

            'HTML TAGS
            Dim htmlDiv As String = "<div style='padding: 6px; font-family: Calibri, Candara, Segoe, Optima, Arial, sans-serif;'>"
            Dim htmlDivClose As String = "</div>"
            Dim htmlBR As String = "<br><br>"
            Dim htmlTable As String = "<table cellpadding='0' cellspacing='0' border='0' style='padding: 6px; border-collapse: collapse; font-family: Calibri, Candara, Segoe, Optima, Arial, sans-serif;'>"
            Dim htmlTableClose As String = "</table>"
            Dim htmlRow As String = "<tr>"
            Dim htmlRowClose As String = "</tr>"
            Dim htmlCell As String = "<td style='width: 100px; text-align: right; font-weight: bold;'>"
            Dim htmlCellBorder As String = "<td style='width: 450px; text-align: left; border: 1px solid #6A6A6A;'>"
            Dim htmlCellClose As String = "</td>"

            'BODY OF MESSAGE
            zMessage = ""
            zMessage = zMessage & htmlDiv & "IT Applications:" & htmlBR & "This is an automated message from the TUV SUD GRC Connect Application. One of the users have provided feedback for technical review:" & htmlDivClose & htmlBR
            zMessage = zMessage & htmlTable
            zMessage = zMessage & htmlRow & htmlCell & "Date: " & htmlCellClose & htmlCellBorder & Date.Today().ToString("MM/dd/yyy") & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "User: " & htmlCellClose & htmlCellBorder & zUserName & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "Email: " & htmlCellClose & htmlCellBorder & zEmail & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "Client: " & htmlCellClose & htmlCellBorder & zClient & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "Practice: " & htmlCellClose & htmlCellBorder & zPractice & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "Group/Parent: " & htmlCellClose & htmlCellBorder & zParentName & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "Page: " & htmlCellClose & htmlCellBorder & zPageName & " (NavLinkId: " & zPageId & ")" & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "Comments: " & htmlCellClose & htmlCellBorder & zComments & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlRow & htmlCell & "URL: " & htmlCellClose & htmlCellBorder & zURL & htmlCellClose & htmlRowClose
            zMessage = zMessage & htmlTableClose

            'CREATE A LOG OF THE EMAIL BEFORE IT IS SENT IN CASE OF ERRORS
            Dim zLogColl As New CommentsLogCollection
            Dim zLog = zLogColl.AddNew()
            zLog.DateOfComment = Date.Now
            zLog.UserFullName = zUserName
            zLog.UserEmail = zEmail
            zLog.ClientName = zClient
            zLog.Practice = zPractice
            zLog.PageParentGroup = zParentName
            zLog.ParentId = zParentId
            zLog.PageId = zPageId
            zLog.PageName = zPageName
            zLog.PageURL = zURL
            zLog.Comments = zComments
            zLogColl.Save()

            'SEND THE EMAIL
            UtilNotification.SubmitNotification("grc-itapplications@tuvsud.com", "TUV SUD GRC CONNECT: Provide Feedback - " & zClient & " - " & zEmail, zMessage, "Provide Feedback")

            'zMM.InitMail()
            'zMM.MailSubject = "GRC CONNECT: Provide Feedback - " & zClient & " - " & zEmail
            'zMM.MailBody = zMessage
            'zMM.MailTo.Clear()
            'zMM.MailTo.Add("grc-itapplications@tuvsud.com", "IT Department")
            ''zMM.MailTo.Add("Edward.Altus@tuvsud.com", "Edward Altus") 'THIS IS FOR TESTING
            'zMM.SendMail(True)

            'CLOSE THE PAGE
            context.Response.Write("success")

            Return

        Catch ex As Exception
            Dim zErrLog As New GRC.Connect.Libraries.CoreLib.UtilErrorLog
            zErrLog.AddCTXError(context, UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.LoggedInUserEmail), HttpContext.Current.Request.ServerVariables("REMOTE_ADDR"), "Email It.ashx")

            'CLOSE THE PAGE
            context.Response.Write(ex.Message & "")

        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class