'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwAllLocations
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colLinkToLocation As New razor.UtilSQLServer.IntegerDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colClient As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colAddress1 As New razor.UtilSQLServer.StringDataColumn
        Public colAddress As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colTivus As New razor.UtilSQLServer.IntegerDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colZip As New razor.UtilSQLServer.StringDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colLongitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colLatitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colTiv As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colLinkToLocation.ColumnName = "[Link_to_Location]"
            colFileNo.ColumnName = "[FileNo]"
            colClient.ColumnName = "[Client]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colDivision.ColumnName = "[Division]"
            colFacility.ColumnName = "[Facility]"
            colAddress1.ColumnName = "[Address1]"
            colAddress.ColumnName = "[Address]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colTivus.ColumnName = "[TIVUS]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colZip.ColumnName = "[Zip]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colLongitude.ColumnName = "[longitude]"
            colLatitude.ColumnName = "[latitude]"
            colTiv.ColumnName = "[TIV]"

            _Members.Add("colLinkToLocation", colLinkToLocation)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colClient", colClient)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colAddress1", colAddress1)
            _Members.Add("colAddress", colAddress)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colTivus", colTivus)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colZip", colZip)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colLongitude", colLongitude)
            _Members.Add("colLatitude", colLatitude)
            _Members.Add("colTiv", colTiv)
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
                Case "colLinkToLocation"
                    Return "[Link_to_Location]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colClient"
                    Return "[Client]"
                Case "colClientLocNo"
                    Return "[ClientLocNo]"
                Case "colDivision"
                    Return "[Division]"
                Case "colFacility"
                    Return "[Facility]"
                Case "colAddress1"
                    Return "[Address1]"
                Case "colAddress"
                    Return "[Address]"
                Case "colCity"
                    Return "[City]"
                Case "colStProv"
                    Return "[StProv]"
                Case "colCountry"
                    Return "[Country]"
                Case "colTivus"
                    Return "[TIVUS]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colZip"
                    Return "[Zip]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colLongitude"
                    Return "[longitude]"
                Case "colLatitude"
                    Return "[latitude]"
                Case "colTiv"
                    Return "[TIV]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[Link_to_Location]", "Link_to_Location", "LinkToLocation", "colLinkToLocation"  
                    Return "colLinkToLocation"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[Client]", "Client", "Client", "colClient"  
                    Return "colClient"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "colClientLocNo"  
                    Return "colClientLocNo"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[Facility]", "Facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case "[Address1]", "Address1", "Address1", "colAddress1"  
                    Return "colAddress1"
                Case "[Address]", "Address", "Address", "colAddress"  
                    Return "colAddress"
                Case "[City]", "City", "City", "colCity"  
                    Return "colCity"
                Case "[StProv]", "StProv", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[Country]", "Country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[TIVUS]", "TIVUS", "Tivus", "colTivus"  
                    Return "colTivus"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[Zip]", "Zip", "Zip", "colZip"  
                    Return "colZip"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[longitude]", "longitude", "Longitude", "colLongitude"  
                    Return "colLongitude"
                Case "[latitude]", "latitude", "Latitude", "colLatitude"  
                    Return "colLatitude"
                Case "[TIV]", "TIV", "Tiv", "colTiv"  
                    Return "colTiv"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colLinkToLocation"
                    Return "Integer"
                Case "colFileNo"
                    Return "String"
                Case "colClient"
                    Return "String"
                Case "colClientLocNo"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case "colAddress1"
                    Return "String"
                Case "colAddress"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colTivus"
                    Return "Integer"
                Case "colFilePrefix"
                    Return "String"
                Case "colZip"
                    Return "String"
                Case "colCustomAccess"
                    Return "String"
                Case "colLongitude"
                    Return "Decimal"
                Case "colLatitude"
                    Return "Decimal"
                Case "colTiv"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[jv].[vwAllLocations]"
        End Function

        Private Function _FirstColumn() As String
            Return "[Link_to_Location]"
        End Function

    End Class
End namespace

