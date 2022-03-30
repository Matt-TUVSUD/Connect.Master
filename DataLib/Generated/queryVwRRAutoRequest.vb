'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwRRAutoRequest
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colAutoRequest As New razor.UtilSQLServer.StringDataColumn
        Public colRecCount As New razor.UtilSQLServer.IntegerDataColumn
        Public colPracticeId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFilePrefix.ColumnName = "[FilePrefix]"
            colDivision.ColumnName = "[Division]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colFacility.ColumnName = "[Facility]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colAutoRequest.ColumnName = "[AutoRequest]"
            colRecCount.ColumnName = "[RecCount]"
            colPracticeId.ColumnName = "[PracticeId]"

            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colAutoRequest", colAutoRequest)
            _Members.Add("colRecCount", colRecCount)
            _Members.Add("colPracticeId", colPracticeId)
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
                Case "colAutoRequest"
                    Return "[AutoRequest]"
                Case "colRecCount"
                    Return "[RecCount]"
                Case "colPracticeId"
                    Return "[PracticeId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
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
                Case "[AutoRequest]", "AutoRequest", "AutoRequest", "colAutoRequest"  
                    Return "colAutoRequest"
                Case "[RecCount]", "RecCount", "RecCount", "colRecCount"  
                    Return "colRecCount"
                Case "[PracticeId]", "PracticeId", "PracticeId", "colPracticeId"  
                    Return "colPracticeId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
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
                Case "colAutoRequest"
                    Return "String"
                Case "colRecCount"
                    Return "Integer"
                Case "colPracticeId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwRRAutoRequest]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

