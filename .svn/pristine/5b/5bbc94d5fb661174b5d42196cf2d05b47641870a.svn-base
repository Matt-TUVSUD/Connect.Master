'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwClientUsers
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFilePrefix As New razor.UtilSQLServer.ShortDataColumn
        Public colReclassificationLinkGUID As New razor.UtilSQLServer.StringDataColumn
        Public colUserIndex As New razor.UtilSQLServer.LongDataColumn
        Public colUserTotalCount As New razor.UtilSQLServer.IntegerDataColumn
        Public colUserCertifiedCount As New razor.UtilSQLServer.IntegerDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colEzyUserId As New razor.UtilSQLServer.IntegerDataColumn
        Public colEzyGuid As New razor.UtilSQLServer.StringDataColumn
        Public colActiveUser As New razor.UtilSQLServer.StringDataColumn
        Public colAccessLevel As New razor.UtilSQLServer.StringDataColumn
        Public colAccessLevelDetails As New razor.UtilSQLServer.StringDataColumn
        Public colEmail As New razor.UtilSQLServer.StringDataColumn
        Public colCCOnly As New razor.UtilSQLServer.StringDataColumn
        Public colDateTimeStamp As New razor.UtilSQLServer.StringDataColumn
        Public colLastLogin As New razor.UtilSQLServer.StringDataColumn
        Public colComment As New razor.UtilSQLServer.StringDataColumn
        Public colClientComment As New razor.UtilSQLServer.StringDataColumn
        Public colRInit As New razor.UtilSQLServer.StringDataColumn
        Public colRReport As New razor.UtilSQLServer.StringDataColumn
        Public colRfu1 As New razor.UtilSQLServer.StringDataColumn
        Public colRfu2 As New razor.UtilSQLServer.StringDataColumn
        Public colRfu3 As New razor.UtilSQLServer.StringDataColumn
        Public colROverdue1 As New razor.UtilSQLServer.StringDataColumn
        Public colROverdue2 As New razor.UtilSQLServer.StringDataColumn
        Public colROverdue3 As New razor.UtilSQLServer.StringDataColumn
        Public colExpOverdue As New razor.UtilSQLServer.StringDataColumn
        Public colRExpd As New razor.UtilSQLServer.StringDataColumn
        Public colActionId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFilePrefix.ColumnName = "[FilePrefix]"
            colReclassificationLinkGUID.ColumnName = "[ReclassificationLinkGUID]"
            colUserIndex.ColumnName = "[UserIndex]"
            colUserTotalCount.ColumnName = "[UserTotalCount]"
            colUserCertifiedCount.ColumnName = "[UserCertifiedCount]"
            colFullName.ColumnName = "[FullName]"
            colEzyUserId.ColumnName = "[EzyUserId]"
            colEzyGuid.ColumnName = "[EzyGuid]"
            colActiveUser.ColumnName = "[ActiveUser]"
            colAccessLevel.ColumnName = "[AccessLevel]"
            colAccessLevelDetails.ColumnName = "[AccessLevelDetails]"
            colEmail.ColumnName = "[Email]"
            colCCOnly.ColumnName = "[CCOnly]"
            colDateTimeStamp.ColumnName = "[DateTimeStamp]"
            colLastLogin.ColumnName = "[LastLogin]"
            colComment.ColumnName = "[Comment]"
            colClientComment.ColumnName = "[ClientComment]"
            colRInit.ColumnName = "[RInit]"
            colRReport.ColumnName = "[RReport]"
            colRfu1.ColumnName = "[Rfu1]"
            colRfu2.ColumnName = "[Rfu2]"
            colRfu3.ColumnName = "[Rfu3]"
            colROverdue1.ColumnName = "[ROverdue1]"
            colROverdue2.ColumnName = "[ROverdue2]"
            colROverdue3.ColumnName = "[ROverdue3]"
            colExpOverdue.ColumnName = "[ExpOverdue]"
            colRExpd.ColumnName = "[RExpd]"
            colActionId.ColumnName = "[ActionId]"

            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colReclassificationLinkGUID", colReclassificationLinkGUID)
            _Members.Add("colUserIndex", colUserIndex)
            _Members.Add("colUserTotalCount", colUserTotalCount)
            _Members.Add("colUserCertifiedCount", colUserCertifiedCount)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colEzyUserId", colEzyUserId)
            _Members.Add("colEzyGuid", colEzyGuid)
            _Members.Add("colActiveUser", colActiveUser)
            _Members.Add("colAccessLevel", colAccessLevel)
            _Members.Add("colAccessLevelDetails", colAccessLevelDetails)
            _Members.Add("colEmail", colEmail)
            _Members.Add("colCCOnly", colCCOnly)
            _Members.Add("colDateTimeStamp", colDateTimeStamp)
            _Members.Add("colLastLogin", colLastLogin)
            _Members.Add("colComment", colComment)
            _Members.Add("colClientComment", colClientComment)
            _Members.Add("colRInit", colRInit)
            _Members.Add("colRReport", colRReport)
            _Members.Add("colRfu1", colRfu1)
            _Members.Add("colRfu2", colRfu2)
            _Members.Add("colRfu3", colRfu3)
            _Members.Add("colROverdue1", colROverdue1)
            _Members.Add("colROverdue2", colROverdue2)
            _Members.Add("colROverdue3", colROverdue3)
            _Members.Add("colExpOverdue", colExpOverdue)
            _Members.Add("colRExpd", colRExpd)
            _Members.Add("colActionId", colActionId)
        End Sub

        Public Function Member(pObjectName As String) As Object
            Dim zReturn As Object = Nothing
            If _Members.ContainsKey(pObjectName) Then
                zReturn = _Members.Item(pObjectName)
            Else
                Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in member dictionary.")
            End If
            Return zReturn
        End Function

        Public Function MemberColumn(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colReclassificationLinkGUID"
                    Return "[ReclassificationLinkGUID]"
                Case "colUserIndex"
                    Return "[UserIndex]"
                Case "colUserTotalCount"
                    Return "[UserTotalCount]"
                Case "colUserCertifiedCount"
                    Return "[UserCertifiedCount]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colEzyUserId"
                    Return "[EzyUserId]"
                Case "colEzyGuid"
                    Return "[EzyGuid]"
                Case "colActiveUser"
                    Return "[ActiveUser]"
                Case "colAccessLevel"
                    Return "[AccessLevel]"
                Case "colAccessLevelDetails"
                    Return "[AccessLevelDetails]"
                Case "colEmail"
                    Return "[Email]"
                Case "colCCOnly"
                    Return "[CCOnly]"
                Case "colDateTimeStamp"
                    Return "[DateTimeStamp]"
                Case "colLastLogin"
                    Return "[LastLogin]"
                Case "colComment"
                    Return "[Comment]"
                Case "colClientComment"
                    Return "[ClientComment]"
                Case "colRInit"
                    Return "[RInit]"
                Case "colRReport"
                    Return "[RReport]"
                Case "colRfu1"
                    Return "[Rfu1]"
                Case "colRfu2"
                    Return "[Rfu2]"
                Case "colRfu3"
                    Return "[Rfu3]"
                Case "colROverdue1"
                    Return "[ROverdue1]"
                Case "colROverdue2"
                    Return "[ROverdue2]"
                Case "colROverdue3"
                    Return "[ROverdue3]"
                Case "colExpOverdue"
                    Return "[ExpOverdue]"
                Case "colRExpd"
                    Return "[RExpd]"
                Case "colActionId"
                    Return "[ActionId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[ReclassificationLinkGUID]", "ReclassificationLinkGUID", "ReclassificationLinkGUID", "colReclassificationLinkGUID"  
                    Return "colReclassificationLinkGUID"
                Case "[UserIndex]", "UserIndex", "UserIndex", "colUserIndex"  
                    Return "colUserIndex"
                Case "[UserTotalCount]", "UserTotalCount", "UserTotalCount", "colUserTotalCount"  
                    Return "colUserTotalCount"
                Case "[UserCertifiedCount]", "UserCertifiedCount", "UserCertifiedCount", "colUserCertifiedCount"  
                    Return "colUserCertifiedCount"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[EzyUserId]", "EzyUserId", "EzyUserId", "colEzyUserId"  
                    Return "colEzyUserId"
                Case "[EzyGuid]", "EzyGuid", "EzyGuid", "colEzyGuid"  
                    Return "colEzyGuid"
                Case "[ActiveUser]", "ActiveUser", "ActiveUser", "colActiveUser"  
                    Return "colActiveUser"
                Case "[AccessLevel]", "AccessLevel", "AccessLevel", "colAccessLevel"  
                    Return "colAccessLevel"
                Case "[AccessLevelDetails]", "AccessLevelDetails", "AccessLevelDetails", "colAccessLevelDetails"  
                    Return "colAccessLevelDetails"
                Case "[Email]", "Email", "Email", "colEmail"  
                    Return "colEmail"
                Case "[CCOnly]", "CCOnly", "CCOnly", "colCCOnly"  
                    Return "colCCOnly"
                Case "[DateTimeStamp]", "DateTimeStamp", "DateTimeStamp", "colDateTimeStamp"  
                    Return "colDateTimeStamp"
                Case "[LastLogin]", "LastLogin", "LastLogin", "colLastLogin"  
                    Return "colLastLogin"
                Case "[Comment]", "Comment", "Comment", "colComment"  
                    Return "colComment"
                Case "[ClientComment]", "ClientComment", "ClientComment", "colClientComment"  
                    Return "colClientComment"
                Case "[RInit]", "RInit", "RInit", "colRInit"  
                    Return "colRInit"
                Case "[RReport]", "RReport", "RReport", "colRReport"  
                    Return "colRReport"
                Case "[Rfu1]", "Rfu1", "Rfu1", "colRfu1"  
                    Return "colRfu1"
                Case "[Rfu2]", "Rfu2", "Rfu2", "colRfu2"  
                    Return "colRfu2"
                Case "[Rfu3]", "Rfu3", "Rfu3", "colRfu3"  
                    Return "colRfu3"
                Case "[ROverdue1]", "ROverdue1", "ROverdue1", "colROverdue1"  
                    Return "colROverdue1"
                Case "[ROverdue2]", "ROverdue2", "ROverdue2", "colROverdue2"  
                    Return "colROverdue2"
                Case "[ROverdue3]", "ROverdue3", "ROverdue3", "colROverdue3"  
                    Return "colROverdue3"
                Case "[ExpOverdue]", "ExpOverdue", "ExpOverdue", "colExpOverdue"  
                    Return "colExpOverdue"
                Case "[RExpd]", "RExpd", "RExpd", "colRExpd"  
                    Return "colRExpd"
                Case "[ActionId]", "ActionId", "ActionId", "colActionId"  
                    Return "colActionId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "Short"
                Case "colReclassificationLinkGUID"
                    Return "String"
                Case "colUserIndex"
                    Return "Long"
                Case "colUserTotalCount"
                    Return "Integer"
                Case "colUserCertifiedCount"
                    Return "Integer"
                Case "colFullName"
                    Return "String"
                Case "colEzyUserId"
                    Return "Integer"
                Case "colEzyGuid"
                    Return "String"
                Case "colActiveUser"
                    Return "String"
                Case "colAccessLevel"
                    Return "String"
                Case "colAccessLevelDetails"
                    Return "String"
                Case "colEmail"
                    Return "String"
                Case "colCCOnly"
                    Return "String"
                Case "colDateTimeStamp"
                    Return "String"
                Case "colLastLogin"
                    Return "String"
                Case "colComment"
                    Return "String"
                Case "colClientComment"
                    Return "String"
                Case "colRInit"
                    Return "String"
                Case "colRReport"
                    Return "String"
                Case "colRfu1"
                    Return "String"
                Case "colRfu2"
                    Return "String"
                Case "colRfu3"
                    Return "String"
                Case "colROverdue1"
                    Return "String"
                Case "colROverdue2"
                    Return "String"
                Case "colROverdue3"
                    Return "String"
                Case "colExpOverdue"
                    Return "String"
                Case "colRExpd"
                    Return "String"
                Case "colActionId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[gv].[vwClientUsers]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

