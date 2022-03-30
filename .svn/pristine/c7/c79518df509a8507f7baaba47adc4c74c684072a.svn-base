'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/4/2012 2:05:25 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class EzyUsers 
		Inherits esEzyUsers

        Private zClient As BusinessObjects.Clients = Nothing

        Public Function LoadByEzyUserId(pEzyUserId As Integer) As Boolean
            Dim zQry As New BusinessObjects.EzyUsersQuery("t1")
            zQry.SelectAll()
            zQry.Where(zQry.EzyUserID = pEzyUserId)

            Return Me.Load(zQry)
        End Function

        Public Function LoadByEmailPassword(pEmail As String, pPassword As String) As Boolean
            Dim zQry As New BusinessObjects.EzyUsersQuery("t1")
            zQry.SelectAll()
            zQry.es.Top = 1
            zQry.Where(zQry.Email.ToLower = pEmail.ToLower)
            zQry.Where(zQry.Password = pPassword)

            Return Me.Load(zQry)
        End Function

        Public Function LoadByEmail(pEmail As String) As Boolean
            'Do not use this method outside of user authentication
            Dim zQry As New BusinessObjects.EzyUsersQuery("t1")
            zQry.SelectAll()
            zQry.es.Top = 1
            zQry.Where(zQry.Email.ToLower = pEmail.ToLower)

            Return Me.Load(zQry)
        End Function

        Public Function LoadByEzyUserGUID(pGUID As String) As Boolean
            Dim zQry As New BusinessObjects.EzyUsersQuery("t1")
            zQry.SelectAll()
            zQry.Where(zQry.EzyGuid = pGUID)

            Return Me.Load(zQry)
        End Function

        Public Overrides Sub Save()

            If Me.UserID Is Nothing Then Me.UserID = Me.Email
            'If Me.EzyUserID Is Nothing Then Me.EzyUserID = 0
            If Me.Password Is Nothing Then Me.Password = ""
            If Me.FullName Is Nothing Then Me.FullName = ""
            If Me.RiskManager Is Nothing Then Me.RiskManager = False
            If Me.DivisionManager Is Nothing Then Me.DivisionManager = False
            If Me.Division Is Nothing Then Me.Division = ""
            If Me.PlantManager Is Nothing Then Me.PlantManager = False
            If Me.Plant Is Nothing Then Me.Plant = ""
            If Me.Administrator Is Nothing Then Me.Administrator = False
            If Me.DocumentAccess Is Nothing Then Me.DocumentAccess = False
            If Me.CustomAccess Is Nothing Then Me.CustomAccess = False
            If Me.CustomAccessText Is Nothing Then Me.CustomAccessText = ""
            'If Me.OperatorStamp Is Nothing Then Me.OperatorStamp = "1/1/1900"
            'If Me.DateTimeStamp Is Nothing Then Me.DateTimeStamp = "1/1/1900"
            If Me.Phone Is Nothing Then Me.Phone = ""
            If Me.Fax Is Nothing Then Me.Fax = ""
            If Me.Email Is Nothing Then Me.Email = ""
            'If Me.NotificationStamp Is Nothing Then Me.NotificationStamp = "1/1/1900"
            If Me.ActiveUser Is Nothing Then Me.ActiveUser = False
            If Me.FilePrefix Is Nothing Then Me.FilePrefix = 0
            'If Me.LastLogin Is Nothing Then Me.LastLogin = "1/1/1900"
            'If Me.LastPWChange Is Nothing Then Me.LastPWChange = "1/1/1900"
            'If Me.ExpEmailCode Is Nothing Then Me.ExpEmailCode = False
            If Me.Internal Is Nothing Then Me.Internal = False
            If Me.Comments Is Nothing Then Me.Comments = ""
            If Me.RInit Is Nothing Then Me.RInit = ""
            If Me.Rfu1 Is Nothing Then Me.Rfu1 = ""
            If Me.Rfu2 Is Nothing Then Me.Rfu2 = ""
            If Me.Rfu3 Is Nothing Then Me.Rfu3 = ""
            If Me.RReport Is Nothing Then Me.RReport = ""
            If Me.ROverdue1 Is Nothing Then Me.ROverdue1 = ""
            If Me.ROverdue2 Is Nothing Then Me.ROverdue2 = ""
            If Me.ROverdue3 Is Nothing Then Me.ROverdue3 = ""
            If Me.RActResp Is Nothing Then Me.RActResp = ""
            If Me.Wo Is Nothing Then Me.Wo = False
            If Me.Calist Is Nothing Then Me.Calist = ""
            If Me.Divlist Is Nothing Then Me.Divlist = ""
            If Me.Loclist Is Nothing Then Me.Loclist = ""
            If Me.ThirdParty Is Nothing Then Me.ThirdParty = False
            If Me.GRCAdministrator Is Nothing Then Me.GRCAdministrator = ""
            'If Me.LastRecentUpdate Is Nothing Then Me.LastRecentUpdate = "1/1/1900"
            'If Me.DisableEmail Is Nothing Then Me.DisableEmail = False

            MyBase.Save()
        End Sub

        Public Shared Function AllowMaintenanceLogin(ByVal pEmailAddress As String) As Boolean

            Dim zObj As New BusinessObjects.EzyUsersQuery
            zObj.Select(zObj.AllowMaintLogin)
            zObj.Where(zObj.Email = pEmailAddress)
            Dim zCol As New BusinessObjects.EzyUsersCollection

            If zCol.Load(zObj) Then
                For Each zEzy As EzyUsers In zCol
                    If zEzy.AllowMaintLogin Then
                        Return True
                    End If
                Next
            Else
                Return False

            End If

            Return False

        End Function

        Public Function Client() As BusinessObjects.Clients
            If zClient Is Nothing Then
                Dim zMyClient As New Clients
                zMyClient.LoadByFilePrefix(Me.FilePrefix)
                zClient = zMyClient
                Return zClient
            Else
                Return zClient
            End If
        End Function

        Public Property Manage As New EzyUsers.AccountManagement(Me)

        ''' <summary>
        ''' Checks to see if this ezyuser belongs to a client that has the User Security special feature.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property EnforceUserSecurity As Boolean
            Get
                If Not IsNothing(Client.Features) Then
                    If Client.Features.ToUpper.Contains("U") Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End Get
        End Property

    End Class

  
End Namespace
