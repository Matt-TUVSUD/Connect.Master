'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwDataTransferClient
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colCldbname As New razor.UtilSQLServer.StringDataColumn
        Public colClientname As New razor.UtilSQLServer.StringDataColumn
        Public colFileprefix As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferPassword As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferEncryptionKey As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferPgpEnabled As New razor.UtilSQLServer.BooleanDataColumn
        Public colDataTransferPgpPublicKey As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpEnabled As New razor.UtilSQLServer.BooleanDataColumn
        Public colDataTransferFtpUrl As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferOutputOptions As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpUserName As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpPassword As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferPgpFileExtension As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpLocalFolder As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFileNameFormatString As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferRetrievalDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colClientDBRootPath As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpMonthJson As New razor.UtilSQLServer.StringDataColumn
        Public colDataTransferFtpDayJson As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colCldbname.ColumnName = "[cldbname]"
            colClientname.ColumnName = "[clientname]"
            colFileprefix.ColumnName = "[fileprefix]"
            colDataTransferPassword.ColumnName = "[DataTransferPassword]"
            colDataTransferEncryptionKey.ColumnName = "[DataTransferEncryptionKey]"
            colDataTransferPgpEnabled.ColumnName = "[DataTransferPgpEnabled]"
            colDataTransferPgpPublicKey.ColumnName = "[DataTransferPgpPublicKey]"
            colDataTransferFtpEnabled.ColumnName = "[DataTransferFtpEnabled]"
            colDataTransferFtpUrl.ColumnName = "[DataTransferFtpUrl]"
            colDataTransferOutputOptions.ColumnName = "[DataTransferOutputOptions]"
            colDataTransferFtpUserName.ColumnName = "[DataTransferFtpUserName]"
            colDataTransferFtpPassword.ColumnName = "[DataTransferFtpPassword]"
            colDataTransferPgpFileExtension.ColumnName = "[DataTransferPgpFileExtension]"
            colDataTransferFtpLocalFolder.ColumnName = "[DataTransferFtpLocalFolder]"
            colDataTransferFileNameFormatString.ColumnName = "[DataTransferFileNameFormatString]"
            colDataTransferRetrievalDate.ColumnName = "[DataTransferRetrievalDate]"
            colClientDBRootPath.ColumnName = "[ClientDBRootPath]"
            colDataTransferFtpMonthJson.ColumnName = "[DataTransferFtpMonthJson]"
            colDataTransferFtpDayJson.ColumnName = "[DataTransferFtpDayJson]"

            _Members.Add("colCldbname", colCldbname)
            _Members.Add("colClientname", colClientname)
            _Members.Add("colFileprefix", colFileprefix)
            _Members.Add("colDataTransferPassword", colDataTransferPassword)
            _Members.Add("colDataTransferEncryptionKey", colDataTransferEncryptionKey)
            _Members.Add("colDataTransferPgpEnabled", colDataTransferPgpEnabled)
            _Members.Add("colDataTransferPgpPublicKey", colDataTransferPgpPublicKey)
            _Members.Add("colDataTransferFtpEnabled", colDataTransferFtpEnabled)
            _Members.Add("colDataTransferFtpUrl", colDataTransferFtpUrl)
            _Members.Add("colDataTransferOutputOptions", colDataTransferOutputOptions)
            _Members.Add("colDataTransferFtpUserName", colDataTransferFtpUserName)
            _Members.Add("colDataTransferFtpPassword", colDataTransferFtpPassword)
            _Members.Add("colDataTransferPgpFileExtension", colDataTransferPgpFileExtension)
            _Members.Add("colDataTransferFtpLocalFolder", colDataTransferFtpLocalFolder)
            _Members.Add("colDataTransferFileNameFormatString", colDataTransferFileNameFormatString)
            _Members.Add("colDataTransferRetrievalDate", colDataTransferRetrievalDate)
            _Members.Add("colClientDBRootPath", colClientDBRootPath)
            _Members.Add("colDataTransferFtpMonthJson", colDataTransferFtpMonthJson)
            _Members.Add("colDataTransferFtpDayJson", colDataTransferFtpDayJson)
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
                Case "colCldbname"
                    Return "[cldbname]"
                Case "colClientname"
                    Return "[clientname]"
                Case "colFileprefix"
                    Return "[fileprefix]"
                Case "colDataTransferPassword"
                    Return "[DataTransferPassword]"
                Case "colDataTransferEncryptionKey"
                    Return "[DataTransferEncryptionKey]"
                Case "colDataTransferPgpEnabled"
                    Return "[DataTransferPgpEnabled]"
                Case "colDataTransferPgpPublicKey"
                    Return "[DataTransferPgpPublicKey]"
                Case "colDataTransferFtpEnabled"
                    Return "[DataTransferFtpEnabled]"
                Case "colDataTransferFtpUrl"
                    Return "[DataTransferFtpUrl]"
                Case "colDataTransferOutputOptions"
                    Return "[DataTransferOutputOptions]"
                Case "colDataTransferFtpUserName"
                    Return "[DataTransferFtpUserName]"
                Case "colDataTransferFtpPassword"
                    Return "[DataTransferFtpPassword]"
                Case "colDataTransferPgpFileExtension"
                    Return "[DataTransferPgpFileExtension]"
                Case "colDataTransferFtpLocalFolder"
                    Return "[DataTransferFtpLocalFolder]"
                Case "colDataTransferFileNameFormatString"
                    Return "[DataTransferFileNameFormatString]"
                Case "colDataTransferRetrievalDate"
                    Return "[DataTransferRetrievalDate]"
                Case "colClientDBRootPath"
                    Return "[ClientDBRootPath]"
                Case "colDataTransferFtpMonthJson"
                    Return "[DataTransferFtpMonthJson]"
                Case "colDataTransferFtpDayJson"
                    Return "[DataTransferFtpDayJson]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[cldbname]", "cldbname", "Cldbname", "colCldbname"  
                    Return "colCldbname"
                Case "[clientname]", "clientname", "Clientname", "colClientname"  
                    Return "colClientname"
                Case "[fileprefix]", "fileprefix", "Fileprefix", "colFileprefix"  
                    Return "colFileprefix"
                Case "[DataTransferPassword]", "DataTransferPassword", "DataTransferPassword", "colDataTransferPassword"  
                    Return "colDataTransferPassword"
                Case "[DataTransferEncryptionKey]", "DataTransferEncryptionKey", "DataTransferEncryptionKey", "colDataTransferEncryptionKey"  
                    Return "colDataTransferEncryptionKey"
                Case "[DataTransferPgpEnabled]", "DataTransferPgpEnabled", "DataTransferPgpEnabled", "colDataTransferPgpEnabled"  
                    Return "colDataTransferPgpEnabled"
                Case "[DataTransferPgpPublicKey]", "DataTransferPgpPublicKey", "DataTransferPgpPublicKey", "colDataTransferPgpPublicKey"  
                    Return "colDataTransferPgpPublicKey"
                Case "[DataTransferFtpEnabled]", "DataTransferFtpEnabled", "DataTransferFtpEnabled", "colDataTransferFtpEnabled"  
                    Return "colDataTransferFtpEnabled"
                Case "[DataTransferFtpUrl]", "DataTransferFtpUrl", "DataTransferFtpUrl", "colDataTransferFtpUrl"  
                    Return "colDataTransferFtpUrl"
                Case "[DataTransferOutputOptions]", "DataTransferOutputOptions", "DataTransferOutputOptions", "colDataTransferOutputOptions"  
                    Return "colDataTransferOutputOptions"
                Case "[DataTransferFtpUserName]", "DataTransferFtpUserName", "DataTransferFtpUserName", "colDataTransferFtpUserName"  
                    Return "colDataTransferFtpUserName"
                Case "[DataTransferFtpPassword]", "DataTransferFtpPassword", "DataTransferFtpPassword", "colDataTransferFtpPassword"  
                    Return "colDataTransferFtpPassword"
                Case "[DataTransferPgpFileExtension]", "DataTransferPgpFileExtension", "DataTransferPgpFileExtension", "colDataTransferPgpFileExtension"  
                    Return "colDataTransferPgpFileExtension"
                Case "[DataTransferFtpLocalFolder]", "DataTransferFtpLocalFolder", "DataTransferFtpLocalFolder", "colDataTransferFtpLocalFolder"  
                    Return "colDataTransferFtpLocalFolder"
                Case "[DataTransferFileNameFormatString]", "DataTransferFileNameFormatString", "DataTransferFileNameFormatString", "colDataTransferFileNameFormatString"  
                    Return "colDataTransferFileNameFormatString"
                Case "[DataTransferRetrievalDate]", "DataTransferRetrievalDate", "DataTransferRetrievalDate", "colDataTransferRetrievalDate"  
                    Return "colDataTransferRetrievalDate"
                Case "[ClientDBRootPath]", "ClientDBRootPath", "ClientDBRootPath", "colClientDBRootPath"  
                    Return "colClientDBRootPath"
                Case "[DataTransferFtpMonthJson]", "DataTransferFtpMonthJson", "DataTransferFtpMonthJson", "colDataTransferFtpMonthJson"  
                    Return "colDataTransferFtpMonthJson"
                Case "[DataTransferFtpDayJson]", "DataTransferFtpDayJson", "DataTransferFtpDayJson", "colDataTransferFtpDayJson"  
                    Return "colDataTransferFtpDayJson"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colCldbname"
                    Return "String"
                Case "colClientname"
                    Return "String"
                Case "colFileprefix"
                    Return "String"
                Case "colDataTransferPassword"
                    Return "String"
                Case "colDataTransferEncryptionKey"
                    Return "String"
                Case "colDataTransferPgpEnabled"
                    Return "Boolean"
                Case "colDataTransferPgpPublicKey"
                    Return "String"
                Case "colDataTransferFtpEnabled"
                    Return "Boolean"
                Case "colDataTransferFtpUrl"
                    Return "String"
                Case "colDataTransferOutputOptions"
                    Return "String"
                Case "colDataTransferFtpUserName"
                    Return "String"
                Case "colDataTransferFtpPassword"
                    Return "String"
                Case "colDataTransferPgpFileExtension"
                    Return "String"
                Case "colDataTransferFtpLocalFolder"
                    Return "String"
                Case "colDataTransferFileNameFormatString"
                    Return "String"
                Case "colDataTransferRetrievalDate"
                    Return "DateTime"
                Case "colClientDBRootPath"
                    Return "String"
                Case "colDataTransferFtpMonthJson"
                    Return "String"
                Case "colDataTransferFtpDayJson"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwDataTransferClient]"
        End Function

        Private Function _FirstColumn() As String
            Return "[cldbname]"
        End Function

    End Class
End namespace

