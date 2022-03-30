'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblRRLog
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colId As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.ShortDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colPracticeCode As New razor.UtilSQLServer.ShortDataColumn
        Public colHazard As New razor.UtilSQLServer.StringDataColumn
        Public colDateStamp As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSender As New razor.UtilSQLServer.StringDataColumn
        Public colRecipientName As New razor.UtilSQLServer.StringDataColumn
        Public colRecipientEmail As New razor.UtilSQLServer.StringDataColumn
        Public colActivity As New razor.UtilSQLServer.StringDataColumn
        Public colLinkActive As New razor.UtilSQLServer.BooleanDataColumn
        Public colLinkActivatedDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colLinkActivatedBy As New razor.UtilSQLServer.StringDataColumn
        Public colLinkActivatedByEmail As New razor.UtilSQLServer.StringDataColumn
        Public colResponseActive As New razor.UtilSQLServer.BooleanDataColumn
        Public colResponseLastActivity As New razor.UtilSQLServer.DateTimeDataColumn
        Public colChanged As New razor.UtilSQLServer.BooleanDataColumn
        Public colRFU1Date As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRFU2Date As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRFU3Date As New razor.UtilSQLServer.DateTimeDataColumn
        Public colRRLogGuid As New razor.UtilSQLServer.StringDataColumn
        Public colCurrentLink As New razor.UtilSQLServer.StringDataColumn
        Public colLanguagePreference As New razor.UtilSQLServer.StringDataColumn
        Public colAdminAlertDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colAdminAlertReason As New razor.UtilSQLServer.StringDataColumn
        Public colSysUserCreated As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateCreated As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSysUserModified As New razor.UtilSQLServer.StringDataColumn
        Public colSysDateModified As New razor.UtilSQLServer.DateTimeDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colId.ColumnName = "[ID]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colFileNo.ColumnName = "[FileNo]"
            colPracticeCode.ColumnName = "[PracticeCode]"
            colHazard.ColumnName = "[Hazard]"
            colDateStamp.ColumnName = "[DateStamp]"
            colSender.ColumnName = "[Sender]"
            colRecipientName.ColumnName = "[RecipientName]"
            colRecipientEmail.ColumnName = "[RecipientEmail]"
            colActivity.ColumnName = "[Activity]"
            colLinkActive.ColumnName = "[LinkActive]"
            colLinkActivatedDate.ColumnName = "[LinkActivatedDate]"
            colLinkActivatedBy.ColumnName = "[LinkActivatedBy]"
            colLinkActivatedByEmail.ColumnName = "[LinkActivatedByEmail]"
            colResponseActive.ColumnName = "[ResponseActive]"
            colResponseLastActivity.ColumnName = "[ResponseLastActivity]"
            colChanged.ColumnName = "[Changed]"
            colRFU1Date.ColumnName = "[RFU1Date]"
            colRFU2Date.ColumnName = "[RFU2Date]"
            colRFU3Date.ColumnName = "[RFU3Date]"
            colRRLogGuid.ColumnName = "[RRLogGuid]"
            colCurrentLink.ColumnName = "[CurrentLink]"
            colLanguagePreference.ColumnName = "[LanguagePreference]"
            colAdminAlertDate.ColumnName = "[AdminAlertDate]"
            colAdminAlertReason.ColumnName = "[AdminAlertReason]"
            colSysUserCreated.ColumnName = "[SysUserCreated]"
            colSysDateCreated.ColumnName = "[SysDateCreated]"
            colSysUserModified.ColumnName = "[SysUserModified]"
            colSysDateModified.ColumnName = "[SysDateModified]"

            _Members.Add("colId", colId)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colPracticeCode", colPracticeCode)
            _Members.Add("colHazard", colHazard)
            _Members.Add("colDateStamp", colDateStamp)
            _Members.Add("colSender", colSender)
            _Members.Add("colRecipientName", colRecipientName)
            _Members.Add("colRecipientEmail", colRecipientEmail)
            _Members.Add("colActivity", colActivity)
            _Members.Add("colLinkActive", colLinkActive)
            _Members.Add("colLinkActivatedDate", colLinkActivatedDate)
            _Members.Add("colLinkActivatedBy", colLinkActivatedBy)
            _Members.Add("colLinkActivatedByEmail", colLinkActivatedByEmail)
            _Members.Add("colResponseActive", colResponseActive)
            _Members.Add("colResponseLastActivity", colResponseLastActivity)
            _Members.Add("colChanged", colChanged)
            _Members.Add("colRFU1Date", colRFU1Date)
            _Members.Add("colRFU2Date", colRFU2Date)
            _Members.Add("colRFU3Date", colRFU3Date)
            _Members.Add("colRRLogGuid", colRRLogGuid)
            _Members.Add("colCurrentLink", colCurrentLink)
            _Members.Add("colLanguagePreference", colLanguagePreference)
            _Members.Add("colAdminAlertDate", colAdminAlertDate)
            _Members.Add("colAdminAlertReason", colAdminAlertReason)
            _Members.Add("colSysUserCreated", colSysUserCreated)
            _Members.Add("colSysDateCreated", colSysDateCreated)
            _Members.Add("colSysUserModified", colSysUserModified)
            _Members.Add("colSysDateModified", colSysDateModified)
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
                Case "colId"
                    Return "[ID]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colPracticeCode"
                    Return "[PracticeCode]"
                Case "colHazard"
                    Return "[Hazard]"
                Case "colDateStamp"
                    Return "[DateStamp]"
                Case "colSender"
                    Return "[Sender]"
                Case "colRecipientName"
                    Return "[RecipientName]"
                Case "colRecipientEmail"
                    Return "[RecipientEmail]"
                Case "colActivity"
                    Return "[Activity]"
                Case "colLinkActive"
                    Return "[LinkActive]"
                Case "colLinkActivatedDate"
                    Return "[LinkActivatedDate]"
                Case "colLinkActivatedBy"
                    Return "[LinkActivatedBy]"
                Case "colLinkActivatedByEmail"
                    Return "[LinkActivatedByEmail]"
                Case "colResponseActive"
                    Return "[ResponseActive]"
                Case "colResponseLastActivity"
                    Return "[ResponseLastActivity]"
                Case "colChanged"
                    Return "[Changed]"
                Case "colRFU1Date"
                    Return "[RFU1Date]"
                Case "colRFU2Date"
                    Return "[RFU2Date]"
                Case "colRFU3Date"
                    Return "[RFU3Date]"
                Case "colRRLogGuid"
                    Return "[RRLogGuid]"
                Case "colCurrentLink"
                    Return "[CurrentLink]"
                Case "colLanguagePreference"
                    Return "[LanguagePreference]"
                Case "colAdminAlertDate"
                    Return "[AdminAlertDate]"
                Case "colAdminAlertReason"
                    Return "[AdminAlertReason]"
                Case "colSysUserCreated"
                    Return "[SysUserCreated]"
                Case "colSysDateCreated"
                    Return "[SysDateCreated]"
                Case "colSysUserModified"
                    Return "[SysUserModified]"
                Case "colSysDateModified"
                    Return "[SysDateModified]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ID]", "ID", "Id", "colId"  
                    Return "colId"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[PracticeCode]", "PracticeCode", "PracticeCode", "colPracticeCode"  
                    Return "colPracticeCode"
                Case "[Hazard]", "Hazard", "Hazard", "colHazard"  
                    Return "colHazard"
                Case "[DateStamp]", "DateStamp", "DateStamp", "colDateStamp"  
                    Return "colDateStamp"
                Case "[Sender]", "Sender", "Sender", "colSender"  
                    Return "colSender"
                Case "[RecipientName]", "RecipientName", "RecipientName", "colRecipientName"  
                    Return "colRecipientName"
                Case "[RecipientEmail]", "RecipientEmail", "RecipientEmail", "colRecipientEmail"  
                    Return "colRecipientEmail"
                Case "[Activity]", "Activity", "Activity", "colActivity"  
                    Return "colActivity"
                Case "[LinkActive]", "LinkActive", "LinkActive", "colLinkActive"  
                    Return "colLinkActive"
                Case "[LinkActivatedDate]", "LinkActivatedDate", "LinkActivatedDate", "colLinkActivatedDate"  
                    Return "colLinkActivatedDate"
                Case "[LinkActivatedBy]", "LinkActivatedBy", "LinkActivatedBy", "colLinkActivatedBy"  
                    Return "colLinkActivatedBy"
                Case "[LinkActivatedByEmail]", "LinkActivatedByEmail", "LinkActivatedByEmail", "colLinkActivatedByEmail"  
                    Return "colLinkActivatedByEmail"
                Case "[ResponseActive]", "ResponseActive", "ResponseActive", "colResponseActive"  
                    Return "colResponseActive"
                Case "[ResponseLastActivity]", "ResponseLastActivity", "ResponseLastActivity", "colResponseLastActivity"  
                    Return "colResponseLastActivity"
                Case "[Changed]", "Changed", "Changed", "colChanged"  
                    Return "colChanged"
                Case "[RFU1Date]", "RFU1Date", "RFU1Date", "colRFU1Date"  
                    Return "colRFU1Date"
                Case "[RFU2Date]", "RFU2Date", "RFU2Date", "colRFU2Date"  
                    Return "colRFU2Date"
                Case "[RFU3Date]", "RFU3Date", "RFU3Date", "colRFU3Date"  
                    Return "colRFU3Date"
                Case "[RRLogGuid]", "RRLogGuid", "RRLogGuid", "colRRLogGuid"  
                    Return "colRRLogGuid"
                Case "[CurrentLink]", "CurrentLink", "CurrentLink", "colCurrentLink"  
                    Return "colCurrentLink"
                Case "[LanguagePreference]", "LanguagePreference", "LanguagePreference", "colLanguagePreference"  
                    Return "colLanguagePreference"
                Case "[AdminAlertDate]", "AdminAlertDate", "AdminAlertDate", "colAdminAlertDate"  
                    Return "colAdminAlertDate"
                Case "[AdminAlertReason]", "AdminAlertReason", "AdminAlertReason", "colAdminAlertReason"  
                    Return "colAdminAlertReason"
                Case "[SysUserCreated]", "SysUserCreated", "SysUserCreated", "colSysUserCreated"  
                    Return "colSysUserCreated"
                Case "[SysDateCreated]", "SysDateCreated", "SysDateCreated", "colSysDateCreated"  
                    Return "colSysDateCreated"
                Case "[SysUserModified]", "SysUserModified", "SysUserModified", "colSysUserModified"  
                    Return "colSysUserModified"
                Case "[SysDateModified]", "SysDateModified", "SysDateModified", "colSysDateModified"  
                    Return "colSysDateModified"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colId"
                    Return "Integer"
                Case "colFilePrefix"
                    Return "Short"
                Case "colFileNo"
                    Return "String"
                Case "colPracticeCode"
                    Return "Short"
                Case "colHazard"
                    Return "String"
                Case "colDateStamp"
                    Return "DateTime"
                Case "colSender"
                    Return "String"
                Case "colRecipientName"
                    Return "String"
                Case "colRecipientEmail"
                    Return "String"
                Case "colActivity"
                    Return "String"
                Case "colLinkActive"
                    Return "Boolean"
                Case "colLinkActivatedDate"
                    Return "DateTime"
                Case "colLinkActivatedBy"
                    Return "String"
                Case "colLinkActivatedByEmail"
                    Return "String"
                Case "colResponseActive"
                    Return "Boolean"
                Case "colResponseLastActivity"
                    Return "DateTime"
                Case "colChanged"
                    Return "Boolean"
                Case "colRFU1Date"
                    Return "DateTime"
                Case "colRFU2Date"
                    Return "DateTime"
                Case "colRFU3Date"
                    Return "DateTime"
                Case "colRRLogGuid"
                    Return "String"
                Case "colCurrentLink"
                    Return "String"
                Case "colLanguagePreference"
                    Return "String"
                Case "colAdminAlertDate"
                    Return "DateTime"
                Case "colAdminAlertReason"
                    Return "String"
                Case "colSysUserCreated"
                    Return "String"
                Case "colSysDateCreated"
                    Return "DateTime"
                Case "colSysUserModified"
                    Return "String"
                Case "colSysDateModified"
                    Return "DateTime"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[RRLog]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ID]"
        End Function

    End Class
End namespace

