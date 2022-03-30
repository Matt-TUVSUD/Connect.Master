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

#Region "Get"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetEzyUserList(ByVal pGSafeGUID As String) As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim zResponse As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim zUserColl As New EzyUsersCollection
                Dim zUserQry As New EzyUsersQuery
                '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
                Dim zEmail As String = UtilGSafe.GetValue(pGSafeGUID, UtilGSafe.KeyName.UserEmail)
                Dim zPassword As String = UtilGSafe.GetValue(pGSafeGUID, UtilGSafe.KeyName.UserPassword)

                zUserQry.es.Top = 1
                zUserQry.Select()
                zUserQry.Where(zUserQry.Email = zEmail, zUserQry.Password = zPassword)
                zUserColl.Load(zUserQry)
                zResponse.collection = zUserColl

            Catch ex As Exception
                zResponse.exception = ex.Message

            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetEzyUserById(ByVal pParms As String) As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim zResponse As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim zUserColl As New EzyUsersCollection
                Dim zUserQry As New EzyUsersQuery
                Dim zId As String = pParms

                zUserQry.es.Top = 1
                zUserQry.SelectAll()
                zUserQry.Where(zUserQry.EzyUserID = zId)
                zUserColl.Load(zUserQry)
                zResponse.collection = zUserColl

            Catch ex As Exception
                zResponse.exception = ex.Message

            End Try

            Return zResponse

        End Function

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetEzyUserByEmail(ByVal pParms As String) As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim zResponse As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim zUserColl As New EzyUsersCollection
                Dim zUserQry As New EzyUsersQuery
                Dim zEmail As String = pParms

                zUserQry.SelectAll()
                zUserQry.Where(zUserQry.Email = zEmail)
                zUserColl.Load(zUserQry)
                zResponse.collection = zUserColl

            Catch ex As Exception
                zResponse.exception = ex.Message

            End Try

            Return zResponse

        End Function

#End Region

#Region "Save"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function SetEzyUserPassword(ByVal pParms As String) As jsResponse(Of EzyUsersCollection, EzyUsers)

            Dim zResponse As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim zUserObj As New EzyUsers
                Dim zUserColl As New EzyUsersCollection
                Dim zUserQry As New EzyUsersQuery
                Dim zParms() As String = Split(pParms, "|")
                Dim zGSafeGUID As String = zParms(0)
                Dim zNewDisplayName As String = zParms(1)
                Dim zNewPassword As String = zParms(2)
                '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
                Dim zEmail As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail)
                Dim zOldPassword As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserPassword)

                ' GET THE LIST OF ALL EZYUSERS ASSOCIATED WITH THIS USER
                zUserQry.Select()
                zUserQry.Where(zUserQry.Email = zEmail, zUserQry.Password = zOldPassword)
                zUserColl.Load(zUserQry)

                ' UPDATE AND SAVE THE NEW PASSWORD TO THE EZYUSERS TABLE
                ' DO NOT SAVE THE PASSWORD IF IT WAS NOT ENTERED
                If zNewPassword.Length > 0 Then
                    For Each zUserObj In zUserColl
                        zUserObj.Password = zNewPassword
                        zUserObj.FullName = zNewDisplayName
                    Next
                Else
                    For Each zUserObj In zUserColl
                        zUserObj.FullName = zNewDisplayName
                    Next
                End If

                zUserColl.Save()

                ' UPDATE THE GSAFE SO THE REST OF THE SYSTEM IS IN SYNC WITH THE NEW FIELDS
                If zNewDisplayName.Length > 0 Then
                    UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.userFullName, zNewDisplayName, UtilGSafe.KeyNameGroup.PageHeader)
                End If
                If zNewPassword.Length > 0 Then
                    UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.UserPassword, zNewPassword, UtilGSafe.KeyNameGroup.Authentication)
                End If

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            ' CREATE A NEW EMPTY RECORD TO RETURN
            Dim returnObj = New EzyUsers
            returnObj = BuildEmptyUser()
            zResponse.collection = New EzyUsersCollection
            zResponse.collection.Add(returnObj)
            Return zResponse

        End Function


        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function DeleteUserByKeys(ByVal pParms As String) As jsResponse(Of EzyUsersCollection, EzyUsers)

            Dim response As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Dim zParms() As String = Split(pParms, "|")
            Dim zEmail = zParms(0)
            Dim zFilePrefix = zParms(1)
            Dim zPassword = zParms(2)
            Dim zUserId = zParms(3)

            Try
                Dim collection As New EzyUsersCollection()
                Dim entity As New EzyUsers()
                Dim query As New EzyUsersQuery()

                query.es.Top = 1
                query.SelectAll()
                query.Where(query.Email = zEmail, query.FilePrefix = zFilePrefix, query.Password = zPassword, query.UserID = zUserId)

                collection.Load(query)
                collection.MarkAllAsDeleted() 'MarkAsDeleted()
                collection.Save()

                response.collection = collection

            Catch ex As Exception
                response.exception = ex.Message
            End Try

            Return response

        End Function
#End Region

#Region "Check Password"
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function IsPasswordExist(ByVal pParms As String) As jsResponse(Of EzyUsersCollection, EzyUsers)
            Dim zResponse As New jsResponse(Of EzyUsersCollection, EzyUsers)()

            Try
                Dim zUserObj As New EzyUsers
                Dim zUserColl As New EzyUsersCollection
                Dim zUserQry As New EzyUsersQuery
                Dim zParms() As String = Split(pParms, "|")
                Dim zGSafeGUID As String = zParms(0)
                Dim zNewPassword As String = zParms(1)
                '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
                Dim zEmail As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail)

                ' LOOK FOR ANY EXISTING PASSWORDS ASSOCIATED WITH AN EMAIL REGARDLESS OF USER TYPE
                zUserQry.SelectAll()
                zUserQry.Where(zUserQry.Email = zEmail, zUserQry.Password = zNewPassword)
                zUserColl.Load(zUserQry)

                ' CREATE A NEW EMPTY RECORD TO RETURN
                zUserObj = BuildEmptyUser()

                ' IF WE FOUND A MATCH, RETURN TRUE IN THE NEW EMPTY RECORD, ELSE FALSE
                If zUserColl.Count > 0 Then
                    zUserObj.Password = "true"
                Else
                    zUserObj.Password = "false"
                End If

                zResponse.collection = New EzyUsersCollection
                zResponse.collection.Add(zUserObj)

            Catch ex As Exception
                zResponse.exception = ex.Message

            End Try

            Return zResponse

        End Function

        Private Function BuildEmptyUser() As EzyUsers
            'CREATE AN EMPTY RECORD
            Dim tempEzyUser As New EzyUsers
            With tempEzyUser
                .UserID = ""
                .Password = ""
                .FullName = ""
                .RiskManager = False
                .DivisionManager = False
                .Division = ""
                .PlantManager = False
                .Plant = ""
                .Administrator = False
                .DocumentAccess = False
                .CustomAccess = False
                .CustomAccessText = ""
                .OperatorStamp = ""
                .DateTimeStamp = "1/1/1900"
                .Phone = ""
                .Fax = ""
                .Email = ""
                .NotificationStamp = "1/1/1900"
                .ActiveUser = False
                .FilePrefix = 0
                .LastLogin = "1/1/1900"
                .LastPWChange = "1/1/1900"
                ' .ExpEmailCode = 0
                .Internal = False
                .Comments = ""
                .RInit = ""
                .Rfu1 = ""
                .Rfu2 = ""
                .Rfu3 = ""
                .RReport = ""
                .ROverdue1 = ""
                .ROverdue2 = ""
                .ROverdue3 = ""
                .RActResp = ""
                .Wo = False
                .Calist = ""
                .Divlist = ""
                .Loclist = ""
                .ThirdParty = False
                .GRCAdministrator = ""
                .LastRecentUpdate = "1/1/1900"
                '.DisableEmail = False
                .EzyUserID = 0
            End With

            Return tempEzyUser

        End Function
#End Region

    End Class
End Namespace