'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwActiveAccountServiceContact
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colRoleSort As New razor.UtilSQLServer.IntegerDataColumn
        Public colRoleCd As New razor.UtilSQLServer.StringDataColumn
        Public colRoleDescription As New razor.UtilSQLServer.StringDataColumn
        Public colRoleDescriptionPractice As New razor.UtilSQLServer.StringDataColumn
        Public colFullName As New razor.UtilSQLServer.StringDataColumn
        Public colEmail As New razor.UtilSQLServer.StringDataColumn
        Public colCell As New razor.UtilSQLServer.StringDataColumn
        Public colVoice As New razor.UtilSQLServer.StringDataColumn
        Public colOfficeAddress1 As New razor.UtilSQLServer.StringDataColumn
        Public colOfficeAddress2 As New razor.UtilSQLServer.StringDataColumn
        Public colTitle As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFilePrefix.ColumnName = "[FilePrefix]"
            colRoleSort.ColumnName = "[RoleSort]"
            colRoleCd.ColumnName = "[RoleCd]"
            colRoleDescription.ColumnName = "[RoleDescription]"
            colRoleDescriptionPractice.ColumnName = "[RoleDescriptionPractice]"
            colFullName.ColumnName = "[FullName]"
            colEmail.ColumnName = "[Email]"
            colCell.ColumnName = "[Cell]"
            colVoice.ColumnName = "[Voice]"
            colOfficeAddress1.ColumnName = "[OfficeAddress1]"
            colOfficeAddress2.ColumnName = "[OfficeAddress2]"
            colTitle.ColumnName = "[Title]"

            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colRoleSort", colRoleSort)
            _Members.Add("colRoleCd", colRoleCd)
            _Members.Add("colRoleDescription", colRoleDescription)
            _Members.Add("colRoleDescriptionPractice", colRoleDescriptionPractice)
            _Members.Add("colFullName", colFullName)
            _Members.Add("colEmail", colEmail)
            _Members.Add("colCell", colCell)
            _Members.Add("colVoice", colVoice)
            _Members.Add("colOfficeAddress1", colOfficeAddress1)
            _Members.Add("colOfficeAddress2", colOfficeAddress2)
            _Members.Add("colTitle", colTitle)
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
                Case "colRoleSort"
                    Return "[RoleSort]"
                Case "colRoleCd"
                    Return "[RoleCd]"
                Case "colRoleDescription"
                    Return "[RoleDescription]"
                Case "colRoleDescriptionPractice"
                    Return "[RoleDescriptionPractice]"
                Case "colFullName"
                    Return "[FullName]"
                Case "colEmail"
                    Return "[Email]"
                Case "colCell"
                    Return "[Cell]"
                Case "colVoice"
                    Return "[Voice]"
                Case "colOfficeAddress1"
                    Return "[OfficeAddress1]"
                Case "colOfficeAddress2"
                    Return "[OfficeAddress2]"
                Case "colTitle"
                    Return "[Title]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[RoleSort]", "RoleSort", "RoleSort", "colRoleSort"  
                    Return "colRoleSort"
                Case "[RoleCd]", "RoleCd", "RoleCd", "colRoleCd"  
                    Return "colRoleCd"
                Case "[RoleDescription]", "RoleDescription", "RoleDescription", "colRoleDescription"  
                    Return "colRoleDescription"
                Case "[RoleDescriptionPractice]", "RoleDescriptionPractice", "RoleDescriptionPractice", "colRoleDescriptionPractice"  
                    Return "colRoleDescriptionPractice"
                Case "[FullName]", "FullName", "FullName", "colFullName"  
                    Return "colFullName"
                Case "[Email]", "Email", "Email", "colEmail"  
                    Return "colEmail"
                Case "[Cell]", "Cell", "Cell", "colCell"  
                    Return "colCell"
                Case "[Voice]", "Voice", "Voice", "colVoice"  
                    Return "colVoice"
                Case "[OfficeAddress1]", "OfficeAddress1", "OfficeAddress1", "colOfficeAddress1"  
                    Return "colOfficeAddress1"
                Case "[OfficeAddress2]", "OfficeAddress2", "OfficeAddress2", "colOfficeAddress2"  
                    Return "colOfficeAddress2"
                Case "[Title]", "Title", "Title", "colTitle"  
                    Return "colTitle"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "String"
                Case "colRoleSort"
                    Return "Integer"
                Case "colRoleCd"
                    Return "String"
                Case "colRoleDescription"
                    Return "String"
                Case "colRoleDescriptionPractice"
                    Return "String"
                Case "colFullName"
                    Return "String"
                Case "colEmail"
                    Return "String"
                Case "colCell"
                    Return "String"
                Case "colVoice"
                    Return "String"
                Case "colOfficeAddress1"
                    Return "String"
                Case "colOfficeAddress2"
                    Return "String"
                Case "colTitle"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwActiveAccountServiceContact]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

