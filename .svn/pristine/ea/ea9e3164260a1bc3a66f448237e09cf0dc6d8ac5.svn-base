'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwReclassificationAccount
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colLoginID As New razor.UtilSQLServer.IntegerDataColumn
        Public colFileprefix As New razor.UtilSQLServer.StringDataColumn
        Public colClientname As New razor.UtilSQLServer.StringDataColumn
        Public colServiceLeaderName As New razor.UtilSQLServer.StringDataColumn
        Public colServiceLeaderEmailAddress As New razor.UtilSQLServer.StringDataColumn
        Public colAsicontactname As New razor.UtilSQLServer.StringDataColumn
        Public colConnectemail As New razor.UtilSQLServer.StringDataColumn
        Public colContractFrom As New razor.UtilSQLServer.DateTimeDataColumn
        Public colMonthOrdinal As New razor.UtilSQLServer.IntegerDataColumn
        Public colReclassificationemailsentdate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationemailfollowupdate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colReclassificationlinkguid As New razor.UtilSQLServer.StringDataColumn
        Public colReclassificationcompletiondate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colTodaysDate As New razor.UtilSQLServer.DateDataColumn
        Public colDateToSend1stRequestEmail As New razor.UtilSQLServer.DateTimeDataColumn
        Public colDateToSend2ndRequestEmail As New razor.UtilSQLServer.DateTimeDataColumn
        Public colSend1stRequestEmail As New razor.UtilSQLServer.BooleanDataColumn
        Public colSend2ndRequestEmail As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colLoginID.ColumnName = "[LoginID]"
            colFileprefix.ColumnName = "[fileprefix]"
            colClientname.ColumnName = "[clientname]"
            colServiceLeaderName.ColumnName = "[ServiceLeaderName]"
            colServiceLeaderEmailAddress.ColumnName = "[ServiceLeaderEmailAddress]"
            colAsicontactname.ColumnName = "[asicontactname]"
            colConnectemail.ColumnName = "[connectemail]"
            colContractFrom.ColumnName = "[ContractFrom]"
            colMonthOrdinal.ColumnName = "[MonthOrdinal]"
            colReclassificationemailsentdate.ColumnName = "[reclassificationemailsentdate]"
            colReclassificationemailfollowupdate.ColumnName = "[reclassificationemailfollowupdate]"
            colReclassificationlinkguid.ColumnName = "[reclassificationlinkguid]"
            colReclassificationcompletiondate.ColumnName = "[reclassificationcompletiondate]"
            colTodaysDate.ColumnName = "[TodaysDate]"
            colDateToSend1stRequestEmail.ColumnName = "[DateToSend1stRequestEmail]"
            colDateToSend2ndRequestEmail.ColumnName = "[DateToSend2ndRequestEmail]"
            colSend1stRequestEmail.ColumnName = "[Send1stRequestEmail]"
            colSend2ndRequestEmail.ColumnName = "[Send2ndRequestEmail]"

            _Members.Add("colLoginID", colLoginID)
            _Members.Add("colFileprefix", colFileprefix)
            _Members.Add("colClientname", colClientname)
            _Members.Add("colServiceLeaderName", colServiceLeaderName)
            _Members.Add("colServiceLeaderEmailAddress", colServiceLeaderEmailAddress)
            _Members.Add("colAsicontactname", colAsicontactname)
            _Members.Add("colConnectemail", colConnectemail)
            _Members.Add("colContractFrom", colContractFrom)
            _Members.Add("colMonthOrdinal", colMonthOrdinal)
            _Members.Add("colReclassificationemailsentdate", colReclassificationemailsentdate)
            _Members.Add("colReclassificationemailfollowupdate", colReclassificationemailfollowupdate)
            _Members.Add("colReclassificationlinkguid", colReclassificationlinkguid)
            _Members.Add("colReclassificationcompletiondate", colReclassificationcompletiondate)
            _Members.Add("colTodaysDate", colTodaysDate)
            _Members.Add("colDateToSend1stRequestEmail", colDateToSend1stRequestEmail)
            _Members.Add("colDateToSend2ndRequestEmail", colDateToSend2ndRequestEmail)
            _Members.Add("colSend1stRequestEmail", colSend1stRequestEmail)
            _Members.Add("colSend2ndRequestEmail", colSend2ndRequestEmail)
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
                Case "colLoginID"
                    Return "[LoginID]"
                Case "colFileprefix"
                    Return "[fileprefix]"
                Case "colClientname"
                    Return "[clientname]"
                Case "colServiceLeaderName"
                    Return "[ServiceLeaderName]"
                Case "colServiceLeaderEmailAddress"
                    Return "[ServiceLeaderEmailAddress]"
                Case "colAsicontactname"
                    Return "[asicontactname]"
                Case "colConnectemail"
                    Return "[connectemail]"
                Case "colContractFrom"
                    Return "[ContractFrom]"
                Case "colMonthOrdinal"
                    Return "[MonthOrdinal]"
                Case "colReclassificationemailsentdate"
                    Return "[reclassificationemailsentdate]"
                Case "colReclassificationemailfollowupdate"
                    Return "[reclassificationemailfollowupdate]"
                Case "colReclassificationlinkguid"
                    Return "[reclassificationlinkguid]"
                Case "colReclassificationcompletiondate"
                    Return "[reclassificationcompletiondate]"
                Case "colTodaysDate"
                    Return "[TodaysDate]"
                Case "colDateToSend1stRequestEmail"
                    Return "[DateToSend1stRequestEmail]"
                Case "colDateToSend2ndRequestEmail"
                    Return "[DateToSend2ndRequestEmail]"
                Case "colSend1stRequestEmail"
                    Return "[Send1stRequestEmail]"
                Case "colSend2ndRequestEmail"
                    Return "[Send2ndRequestEmail]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[LoginID]", "LoginID", "LoginID", "colLoginID"  
                    Return "colLoginID"
                Case "[fileprefix]", "fileprefix", "Fileprefix", "colFileprefix"  
                    Return "colFileprefix"
                Case "[clientname]", "clientname", "Clientname", "colClientname"  
                    Return "colClientname"
                Case "[ServiceLeaderName]", "ServiceLeaderName", "ServiceLeaderName", "colServiceLeaderName"  
                    Return "colServiceLeaderName"
                Case "[ServiceLeaderEmailAddress]", "ServiceLeaderEmailAddress", "ServiceLeaderEmailAddress", "colServiceLeaderEmailAddress"  
                    Return "colServiceLeaderEmailAddress"
                Case "[asicontactname]", "asicontactname", "Asicontactname", "colAsicontactname"  
                    Return "colAsicontactname"
                Case "[connectemail]", "connectemail", "Connectemail", "colConnectemail"  
                    Return "colConnectemail"
                Case "[ContractFrom]", "ContractFrom", "ContractFrom", "colContractFrom"  
                    Return "colContractFrom"
                Case "[MonthOrdinal]", "MonthOrdinal", "MonthOrdinal", "colMonthOrdinal"  
                    Return "colMonthOrdinal"
                Case "[reclassificationemailsentdate]", "reclassificationemailsentdate", "Reclassificationemailsentdate", "colReclassificationemailsentdate"  
                    Return "colReclassificationemailsentdate"
                Case "[reclassificationemailfollowupdate]", "reclassificationemailfollowupdate", "Reclassificationemailfollowupdate", "colReclassificationemailfollowupdate"  
                    Return "colReclassificationemailfollowupdate"
                Case "[reclassificationlinkguid]", "reclassificationlinkguid", "Reclassificationlinkguid", "colReclassificationlinkguid"  
                    Return "colReclassificationlinkguid"
                Case "[reclassificationcompletiondate]", "reclassificationcompletiondate", "Reclassificationcompletiondate", "colReclassificationcompletiondate"  
                    Return "colReclassificationcompletiondate"
                Case "[TodaysDate]", "TodaysDate", "TodaysDate", "colTodaysDate"  
                    Return "colTodaysDate"
                Case "[DateToSend1stRequestEmail]", "DateToSend1stRequestEmail", "DateToSend1stRequestEmail", "colDateToSend1stRequestEmail"  
                    Return "colDateToSend1stRequestEmail"
                Case "[DateToSend2ndRequestEmail]", "DateToSend2ndRequestEmail", "DateToSend2ndRequestEmail", "colDateToSend2ndRequestEmail"  
                    Return "colDateToSend2ndRequestEmail"
                Case "[Send1stRequestEmail]", "Send1stRequestEmail", "Send1stRequestEmail", "colSend1stRequestEmail"  
                    Return "colSend1stRequestEmail"
                Case "[Send2ndRequestEmail]", "Send2ndRequestEmail", "Send2ndRequestEmail", "colSend2ndRequestEmail"  
                    Return "colSend2ndRequestEmail"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colLoginID"
                    Return "Integer"
                Case "colFileprefix"
                    Return "String"
                Case "colClientname"
                    Return "String"
                Case "colServiceLeaderName"
                    Return "String"
                Case "colServiceLeaderEmailAddress"
                    Return "String"
                Case "colAsicontactname"
                    Return "String"
                Case "colConnectemail"
                    Return "String"
                Case "colContractFrom"
                    Return "DateTime"
                Case "colMonthOrdinal"
                    Return "Integer"
                Case "colReclassificationemailsentdate"
                    Return "DateTime"
                Case "colReclassificationemailfollowupdate"
                    Return "DateTime"
                Case "colReclassificationlinkguid"
                    Return "String"
                Case "colReclassificationcompletiondate"
                    Return "DateTime"
                Case "colTodaysDate"
                    Return "Date"
                Case "colDateToSend1stRequestEmail"
                    Return "DateTime"
                Case "colDateToSend2ndRequestEmail"
                    Return "DateTime"
                Case "colSend1stRequestEmail"
                    Return "Boolean"
                Case "colSend2ndRequestEmail"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwReclassificationAccount]"
        End Function

        Private Function _FirstColumn() As String
            Return "[LoginID]"
        End Function

    End Class
End namespace

