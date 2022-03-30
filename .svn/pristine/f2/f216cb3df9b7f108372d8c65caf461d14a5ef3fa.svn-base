'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwRRExpiringExpiredExpectedCompletedDate
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colRowNo As New razor.UtilSQLServer.LongDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colPracticeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colRRLogID As New razor.UtilSQLServer.IntegerDataColumn
        Public colRecipientName As New razor.UtilSQLServer.StringDataColumn
        Public colRecipientEmail As New razor.UtilSQLServer.StringDataColumn
        Public colPracticeName As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colRowNo.ColumnName = "[RowNo]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colFileNo.ColumnName = "[FileNo]"
            colDivision.ColumnName = "[Division]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colFacility.ColumnName = "[Facility]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colPracticeId.ColumnName = "[PracticeId]"
            colRRLogID.ColumnName = "[RRLogID]"
            colRecipientName.ColumnName = "[RecipientName]"
            colRecipientEmail.ColumnName = "[RecipientEmail]"
            colPracticeName.ColumnName = "[PracticeName]"

            _Members.Add("colRowNo", colRowNo)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colPracticeId", colPracticeId)
            _Members.Add("colRRLogID", colRRLogID)
            _Members.Add("colRecipientName", colRecipientName)
            _Members.Add("colRecipientEmail", colRecipientEmail)
            _Members.Add("colPracticeName", colPracticeName)
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
                Case "colRowNo"
                    Return "[RowNo]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colDivision"
                    Return "[Division]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colClientLocNo"
                    Return "[ClientLocNo]"
                Case "colFacility"
                    Return "[Facility]"
                Case "colCity"
                    Return "[City]"
                Case "colStProv"
                    Return "[StProv]"
                Case "colCountry"
                    Return "[Country]"
                Case "colPracticeId"
                    Return "[PracticeId]"
                Case "colRRLogID"
                    Return "[RRLogID]"
                Case "colRecipientName"
                    Return "[RecipientName]"
                Case "colRecipientEmail"
                    Return "[RecipientEmail]"
                Case "colPracticeName"
                    Return "[PracticeName]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[RowNo]", "RowNo", "RowNo", "colRowNo"  
                    Return "colRowNo"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "colClientLocNo"  
                    Return "colClientLocNo"
                Case "[Facility]", "Facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case "[City]", "City", "City", "colCity"  
                    Return "colCity"
                Case "[StProv]", "StProv", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[Country]", "Country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[PracticeId]", "PracticeId", "PracticeId", "colPracticeId"  
                    Return "colPracticeId"
                Case "[RRLogID]", "RRLogID", "RRLogID", "colRRLogID"  
                    Return "colRRLogID"
                Case "[RecipientName]", "RecipientName", "RecipientName", "colRecipientName"  
                    Return "colRecipientName"
                Case "[RecipientEmail]", "RecipientEmail", "RecipientEmail", "colRecipientEmail"  
                    Return "colRecipientEmail"
                Case "[PracticeName]", "PracticeName", "PracticeName", "colPracticeName"  
                    Return "colPracticeName"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colRowNo"
                    Return "Long"
                Case "colFilePrefix"
                    Return "String"
                Case "colFileNo"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colCustomAccess"
                    Return "String"
                Case "colClientLocNo"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colPracticeId"
                    Return "Integer"
                Case "colRRLogID"
                    Return "Integer"
                Case "colRecipientName"
                    Return "String"
                Case "colRecipientEmail"
                    Return "String"
                Case "colPracticeName"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwRRExpiringExpiredExpectedCompletedDate]"
        End Function

        Private Function _FirstColumn() As String
            Return "[RowNo]"
        End Function

    End Class
End namespace

