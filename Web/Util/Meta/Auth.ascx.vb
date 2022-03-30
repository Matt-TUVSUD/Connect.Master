Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices.ActiveDirectory

Public Class Auth
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles uxAuthButton.Click

        Dim zDirCtx As New DirectoryContext(DirectoryContextType.Domain, "us001.itgr.net")
        Dim zDomain As DirectoryServices.ActiveDirectory.Domain = DirectoryServices.ActiveDirectory.Domain.GetDomain(zDirCtx)
        Diagnostics.Trace.WriteLine("Domain: " & zDomain.Name)

        Dim DC As DirectoryServices.ActiveDirectory.DomainController = zDomain.FindDomainController()
        Diagnostics.Trace.WriteLine("Domain Controller: " & DC.Name)

        Try
            Diagnostics.Trace.Write("Enter User ID:")
            Dim zUserId As String = uxUserId.Text

            Diagnostics.Trace.Write("Password:")
            Dim zPwd As String = uxPwd.Text

            Dim PrincipalContext As New DirectoryServices.AccountManagement.PrincipalContext(DirectoryServices.AccountManagement.ContextType.Domain, DC.Name, zUserId, zPwd)
            Diagnostics.Trace.WriteLine("Connected Server:" & PrincipalContext.ConnectedServer)
            Diagnostics.Trace.WriteLine("Connnected As:" & PrincipalContext.UserName)

            If PrincipalContext.ConnectedServer <> "" Then

                Dim zUserPrincipal As New DirectoryServices.AccountManagement.UserPrincipal(PrincipalContext)
                zUserPrincipal.SamAccountName = zUserId

                Dim zSearcher As New DirectoryServices.AccountManagement.PrincipalSearcher(zUserPrincipal)
                zUserPrincipal = zSearcher.FindOne()

                Diagnostics.Trace.WriteLine("User Principal DN:" & zUserPrincipal.DistinguishedName)

                Dim zGroupPrincipal As New GroupPrincipal(PrincipalContext)
                zGroupPrincipal.Name = "GRC_Development Team"

                zSearcher = New PrincipalSearcher(zGroupPrincipal)
                zGroupPrincipal = zSearcher.FindOne

                If zUserPrincipal.IsMemberOf(zGroupPrincipal) Then
                    Session("IsMetaAuth") = True
                    Response.Redirect(Request.Path)
                    Diagnostics.Trace.WriteLine("Allow Access")
                Else
                    Session("IsMetaAuth") = False
                    Diagnostics.Trace.WriteLine("Access Denied")
                End If

            End If

        Catch ex As Exception
            ex.Data.Add("Domain", zDomain.Name)
            ex.Data.Add("Domain Controller", DC.Name)
            Me.uxAuthError.Text = ex.Message
            'EventLog.WriteEntry(ex.Source, GRC.Resources.ExceptionUtility.ExtractMessages(ex), EventLogEntryType.Error)
            'Diagnostics.Trace.WriteLine(GRC.Resources.ExceptionUtility.ExtractMessages(ex))
        End Try

    End Sub
End Class