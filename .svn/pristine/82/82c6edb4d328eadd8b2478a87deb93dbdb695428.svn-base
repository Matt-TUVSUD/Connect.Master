'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwGSafeFileNoRadius
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colLinkToPopup As New razor.UtilSQLServer.IntegerDataColumn
        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colRefLatitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colRefLongitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colUnits As New razor.UtilSQLServer.StringDataColumn
        Public colInputRange As New razor.UtilSQLServer.DoubleDataColumn
        Public colSearchName As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colClient As New razor.UtilSQLServer.StringDataColumn
        Public colAddress As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colZip As New razor.UtilSQLServer.StringDataColumn
        Public colTiv As New razor.UtilSQLServer.DoubleDataColumn
        Public colLatitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colLongitude As New razor.UtilSQLServer.DecimalDataColumn
        Public colDistanceMiles As New razor.UtilSQLServer.DoubleDataColumn
        Public colDistanceNauticalMiles As New razor.UtilSQLServer.DoubleDataColumn
        Public colDistanceKilometers As New razor.UtilSQLServer.DoubleDataColumn
        Public colLastInspDate As New razor.UtilSQLServer.DateTimeDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colLinkToPopup.ColumnName = "[Link_to_Popup]"
            colGSafeId.ColumnName = "[GSafeId]"
            colRefLatitude.ColumnName = "[RefLatitude]"
            colRefLongitude.ColumnName = "[RefLongitude]"
            colUnits.ColumnName = "[Units]"
            colInputRange.ColumnName = "[InputRange]"
            colSearchName.ColumnName = "[SearchName]"
            colFileNo.ColumnName = "[FileNo]"
            colClient.ColumnName = "[client]"
            colAddress.ColumnName = "[address]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colZip.ColumnName = "[Zip]"
            colTiv.ColumnName = "[TIV]"
            colLatitude.ColumnName = "[latitude]"
            colLongitude.ColumnName = "[longitude]"
            colDistanceMiles.ColumnName = "[DistanceMiles]"
            colDistanceNauticalMiles.ColumnName = "[DistanceNauticalMiles]"
            colDistanceKilometers.ColumnName = "[DistanceKilometers]"
            colLastInspDate.ColumnName = "[LastInspDate]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colDivision.ColumnName = "[Division]"
            colFacility.ColumnName = "[Facility]"

            _Members.Add("colLinkToPopup", colLinkToPopup)
            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colRefLatitude", colRefLatitude)
            _Members.Add("colRefLongitude", colRefLongitude)
            _Members.Add("colUnits", colUnits)
            _Members.Add("colInputRange", colInputRange)
            _Members.Add("colSearchName", colSearchName)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colClient", colClient)
            _Members.Add("colAddress", colAddress)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colZip", colZip)
            _Members.Add("colTiv", colTiv)
            _Members.Add("colLatitude", colLatitude)
            _Members.Add("colLongitude", colLongitude)
            _Members.Add("colDistanceMiles", colDistanceMiles)
            _Members.Add("colDistanceNauticalMiles", colDistanceNauticalMiles)
            _Members.Add("colDistanceKilometers", colDistanceKilometers)
            _Members.Add("colLastInspDate", colLastInspDate)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colFacility", colFacility)
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
                Case "colLinkToPopup"
                    Return "[Link_to_Popup]"
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colRefLatitude"
                    Return "[RefLatitude]"
                Case "colRefLongitude"
                    Return "[RefLongitude]"
                Case "colUnits"
                    Return "[Units]"
                Case "colInputRange"
                    Return "[InputRange]"
                Case "colSearchName"
                    Return "[SearchName]"
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colClient"
                    Return "[client]"
                Case "colAddress"
                    Return "[address]"
                Case "colCity"
                    Return "[City]"
                Case "colStProv"
                    Return "[StProv]"
                Case "colCountry"
                    Return "[Country]"
                Case "colZip"
                    Return "[Zip]"
                Case "colTiv"
                    Return "[TIV]"
                Case "colLatitude"
                    Return "[latitude]"
                Case "colLongitude"
                    Return "[longitude]"
                Case "colDistanceMiles"
                    Return "[DistanceMiles]"
                Case "colDistanceNauticalMiles"
                    Return "[DistanceNauticalMiles]"
                Case "colDistanceKilometers"
                    Return "[DistanceKilometers]"
                Case "colLastInspDate"
                    Return "[LastInspDate]"
                Case "colClientLocNo"
                    Return "[ClientLocNo]"
                Case "colDivision"
                    Return "[Division]"
                Case "colFacility"
                    Return "[Facility]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[Link_to_Popup]", "Link_to_Popup", "LinkToPopup", "colLinkToPopup"  
                    Return "colLinkToPopup"
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[RefLatitude]", "RefLatitude", "RefLatitude", "colRefLatitude"  
                    Return "colRefLatitude"
                Case "[RefLongitude]", "RefLongitude", "RefLongitude", "colRefLongitude"  
                    Return "colRefLongitude"
                Case "[Units]", "Units", "Units", "colUnits"  
                    Return "colUnits"
                Case "[InputRange]", "InputRange", "InputRange", "colInputRange"  
                    Return "colInputRange"
                Case "[SearchName]", "SearchName", "SearchName", "colSearchName"  
                    Return "colSearchName"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[client]", "client", "Client", "colClient"  
                    Return "colClient"
                Case "[address]", "address", "Address", "colAddress"  
                    Return "colAddress"
                Case "[City]", "City", "City", "colCity"  
                    Return "colCity"
                Case "[StProv]", "StProv", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[Country]", "Country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[Zip]", "Zip", "Zip", "colZip"  
                    Return "colZip"
                Case "[TIV]", "TIV", "Tiv", "colTiv"  
                    Return "colTiv"
                Case "[latitude]", "latitude", "Latitude", "colLatitude"  
                    Return "colLatitude"
                Case "[longitude]", "longitude", "Longitude", "colLongitude"  
                    Return "colLongitude"
                Case "[DistanceMiles]", "DistanceMiles", "DistanceMiles", "colDistanceMiles"  
                    Return "colDistanceMiles"
                Case "[DistanceNauticalMiles]", "DistanceNauticalMiles", "DistanceNauticalMiles", "colDistanceNauticalMiles"  
                    Return "colDistanceNauticalMiles"
                Case "[DistanceKilometers]", "DistanceKilometers", "DistanceKilometers", "colDistanceKilometers"  
                    Return "colDistanceKilometers"
                Case "[LastInspDate]", "LastInspDate", "LastInspDate", "colLastInspDate"  
                    Return "colLastInspDate"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "colClientLocNo"  
                    Return "colClientLocNo"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[Facility]", "Facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colLinkToPopup"
                    Return "Integer"
                Case "colGSafeId"
                    Return "Integer"
                Case "colRefLatitude"
                    Return "Decimal"
                Case "colRefLongitude"
                    Return "Decimal"
                Case "colUnits"
                    Return "String"
                Case "colInputRange"
                    Return "Double"
                Case "colSearchName"
                    Return "String"
                Case "colFileNo"
                    Return "String"
                Case "colClient"
                    Return "String"
                Case "colAddress"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colZip"
                    Return "String"
                Case "colTiv"
                    Return "Double"
                Case "colLatitude"
                    Return "Decimal"
                Case "colLongitude"
                    Return "Decimal"
                Case "colDistanceMiles"
                    Return "Double"
                Case "colDistanceNauticalMiles"
                    Return "Double"
                Case "colDistanceKilometers"
                    Return "Double"
                Case "colLastInspDate"
                    Return "DateTime"
                Case "colClientLocNo"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[gv].[vwGSafeFileNoRadius]"
        End Function

        Private Function _FirstColumn() As String
            Return "[Link_to_Popup]"
        End Function

    End Class
End namespace

