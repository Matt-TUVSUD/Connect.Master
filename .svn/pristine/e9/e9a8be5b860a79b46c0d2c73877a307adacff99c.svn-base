

'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryViewCCGRIPSSLocationsV3
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public FilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public FileNo As New razor.UtilSQLServer.StringDataColumn
        Public Division As New razor.UtilSQLServer.StringDataColumn
        Public CustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public ClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public Facility As New razor.UtilSQLServer.StringDataColumn
        Public Address As New razor.UtilSQLServer.StringDataColumn
        Public City As New razor.UtilSQLServer.StringDataColumn
        Public StProv As New razor.UtilSQLServer.StringDataColumn
        Public Country As New razor.UtilSQLServer.StringDataColumn
        Public CityStProvCountry As New razor.UtilSQLServer.StringDataColumn
        Public StProvCountry As New razor.UtilSQLServer.StringDataColumn
        Public Longitude As New razor.UtilSQLServer.DecimalDataColumn
        Public Latitude As New razor.UtilSQLServer.DecimalDataColumn
        Public Tiv As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            FilePrefix.ColumnName = "[FilePrefix]"
            FileNo.ColumnName = "[FileNo]"
            Division.ColumnName = "[Division]"
            CustomAccess.ColumnName = "[CustomAccess]"
            ClientLocNo.ColumnName = "[ClientLocNo]"
            Facility.ColumnName = "[Facility]"
            Address.ColumnName = "[Address]"
            City.ColumnName = "[City]"
            StProv.ColumnName = "[StProv]"
            Country.ColumnName = "[Country]"
            CityStProvCountry.ColumnName = "[CityStProvCountry]"
            StProvCountry.ColumnName = "[StProvCountry]"
            Longitude.ColumnName = "[Longitude]"
            Latitude.ColumnName = "[Latitude]"
            Tiv.ColumnName = "[TIV]"

            _Members.Add("FilePrefix", FilePrefix)
            _Members.Add("FileNo", FileNo)
            _Members.Add("Division", Division)
            _Members.Add("CustomAccess", CustomAccess)
            _Members.Add("ClientLocNo", ClientLocNo)
            _Members.Add("Facility", Facility)
            _Members.Add("Address", Address)
            _Members.Add("City", City)
            _Members.Add("StProv", StProv)
            _Members.Add("Country", Country)
            _Members.Add("CityStProvCountry", CityStProvCountry)
            _Members.Add("StProvCountry", StProvCountry)
            _Members.Add("Longitude", Longitude)
            _Members.Add("Latitude", Latitude)
            _Members.Add("Tiv", Tiv)
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
                Case "FilePrefix"
                    Return "[FilePrefix]"
                Case "FileNo"
                    Return "[FileNo]"
                Case "Division"
                    Return "[Division]"
                Case "CustomAccess"
                    Return "[CustomAccess]"
                Case "ClientLocNo"
                    Return "[ClientLocNo]"
                Case "Facility"
                    Return "[Facility]"
                Case "Address"
                    Return "[Address]"
                Case "City"
                    Return "[City]"
                Case "StProv"
                    Return "[StProv]"
                Case "Country"
                    Return "[Country]"
                Case "CityStProvCountry"
                    Return "[CityStProvCountry]"
                Case "StProvCountry"
                    Return "[StProvCountry]"
                Case "Longitude"
                    Return "[Longitude]"
                Case "Latitude"
                    Return "[Latitude]"
                Case "Tiv"
                    Return "[TIV]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "FilePrefix"  
                    Return "FilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "FileNo"  
                    Return "FileNo"
                Case "[Division]", "Division", "Division", "Division"  
                    Return "Division"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "CustomAccess"  
                    Return "CustomAccess"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "ClientLocNo"  
                    Return "ClientLocNo"
                Case "[Facility]", "Facility", "Facility", "Facility"  
                    Return "Facility"
                Case "[Address]", "Address", "Address", "Address"  
                    Return "Address"
                Case "[City]", "City", "City", "City"  
                    Return "City"
                Case "[StProv]", "StProv", "StProv", "StProv"  
                    Return "StProv"
                Case "[Country]", "Country", "Country", "Country"  
                    Return "Country"
                Case "[CityStProvCountry]", "CityStProvCountry", "CityStProvCountry", "CityStProvCountry"  
                    Return "CityStProvCountry"
                Case "[StProvCountry]", "StProvCountry", "StProvCountry", "StProvCountry"  
                    Return "StProvCountry"
                Case "[Longitude]", "Longitude", "Longitude", "Longitude"  
                    Return "Longitude"
                Case "[Latitude]", "Latitude", "Latitude", "Latitude"  
                    Return "Latitude"
                Case "[TIV]", "TIV", "Tiv", "Tiv"  
                    Return "Tiv"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "FilePrefix"
                    Return "String"
                Case "FileNo"
                    Return "String"
                Case "Division"
                    Return "String"
                Case "CustomAccess"
                    Return "String"
                Case "ClientLocNo"
                    Return "String"
                Case "Facility"
                    Return "String"
                Case "Address"
                    Return "String"
                Case "City"
                    Return "String"
                Case "StProv"
                    Return "String"
                Case "Country"
                    Return "String"
                Case "CityStProvCountry"
                    Return "String"
                Case "StProvCountry"
                    Return "String"
                Case "Longitude"
                    Return "Decimal"
                Case "Latitude"
                    Return "Decimal"
                Case "Tiv"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[viewCCGRIPSSLocationsV3]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

