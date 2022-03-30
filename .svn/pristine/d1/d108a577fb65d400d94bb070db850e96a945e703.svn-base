'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwLocationListing
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colFilePrefix As New razor.UtilSQLServer.StringDataColumn
        Public colFileNo As New razor.UtilSQLServer.StringDataColumn
        Public colClient As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNo As New razor.UtilSQLServer.StringDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colCustomAccess As New razor.UtilSQLServer.StringDataColumn
        Public colFacility As New razor.UtilSQLServer.StringDataColumn
        Public colAddress1 As New razor.UtilSQLServer.StringDataColumn
        Public colCity As New razor.UtilSQLServer.StringDataColumn
        Public colStProv As New razor.UtilSQLServer.StringDataColumn
        Public colCountry As New razor.UtilSQLServer.StringDataColumn
        Public colPercentUSTot As New razor.UtilSQLServer.DoubleDataColumn
        Public colTIVAustralian As New razor.UtilSQLServer.LongDataColumn
        Public colTIVBritish As New razor.UtilSQLServer.LongDataColumn
        Public colTIVCanadian As New razor.UtilSQLServer.LongDataColumn
        Public colTIVEuro As New razor.UtilSQLServer.LongDataColumn
        Public colTIVJapanese As New razor.UtilSQLServer.LongDataColumn
        Public colTIVMexican As New razor.UtilSQLServer.LongDataColumn
        Public colTIVNewZealand As New razor.UtilSQLServer.LongDataColumn
        Public colTivus As New razor.UtilSQLServer.LongDataColumn
        Public colHazard As New razor.UtilSQLServer.StringDataColumn
        Public colEffectiveDate As New razor.UtilSQLServer.DateTimeDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colFilePrefix.ColumnName = "[FilePrefix]"
            colFileNo.ColumnName = "[FileNo]"
            colClient.ColumnName = "[Client]"
            colClientLocNo.ColumnName = "[ClientLocNo]"
            colDivision.ColumnName = "[Division]"
            colCustomAccess.ColumnName = "[CustomAccess]"
            colFacility.ColumnName = "[Facility]"
            colAddress1.ColumnName = "[Address1]"
            colCity.ColumnName = "[City]"
            colStProv.ColumnName = "[StProv]"
            colCountry.ColumnName = "[Country]"
            colPercentUSTot.ColumnName = "[100PercentUSTot]"
            colTIVAustralian.ColumnName = "[TIVAustralian]"
            colTIVBritish.ColumnName = "[TIVBritish]"
            colTIVCanadian.ColumnName = "[TIVCanadian]"
            colTIVEuro.ColumnName = "[TIVEuro]"
            colTIVJapanese.ColumnName = "[TIVJapanese]"
            colTIVMexican.ColumnName = "[TIVMexican]"
            colTIVNewZealand.ColumnName = "[TIVNewZealand]"
            colTivus.ColumnName = "[TIVUS]"
            colHazard.ColumnName = "[Hazard]"
            colEffectiveDate.ColumnName = "[EffectiveDate]"

            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colFileNo", colFileNo)
            _Members.Add("colClient", colClient)
            _Members.Add("colClientLocNo", colClientLocNo)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colCustomAccess", colCustomAccess)
            _Members.Add("colFacility", colFacility)
            _Members.Add("colAddress1", colAddress1)
            _Members.Add("colCity", colCity)
            _Members.Add("colStProv", colStProv)
            _Members.Add("colCountry", colCountry)
            _Members.Add("colPercentUSTot", colPercentUSTot)
            _Members.Add("colTIVAustralian", colTIVAustralian)
            _Members.Add("colTIVBritish", colTIVBritish)
            _Members.Add("colTIVCanadian", colTIVCanadian)
            _Members.Add("colTIVEuro", colTIVEuro)
            _Members.Add("colTIVJapanese", colTIVJapanese)
            _Members.Add("colTIVMexican", colTIVMexican)
            _Members.Add("colTIVNewZealand", colTIVNewZealand)
            _Members.Add("colTivus", colTivus)
            _Members.Add("colHazard", colHazard)
            _Members.Add("colEffectiveDate", colEffectiveDate)
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
                Case "colFileNo"
                    Return "[FileNo]"
                Case "colClient"
                    Return "[Client]"
                Case "colClientLocNo"
                    Return "[ClientLocNo]"
                Case "colDivision"
                    Return "[Division]"
                Case "colCustomAccess"
                    Return "[CustomAccess]"
                Case "colFacility"
                    Return "[Facility]"
                Case "colAddress1"
                    Return "[Address1]"
                Case "colCity"
                    Return "[City]"
                Case "colStProv"
                    Return "[StProv]"
                Case "colCountry"
                    Return "[Country]"
                Case "colPercentUSTot"
                    Return "[100PercentUSTot]"
                Case "colTIVAustralian"
                    Return "[TIVAustralian]"
                Case "colTIVBritish"
                    Return "[TIVBritish]"
                Case "colTIVCanadian"
                    Return "[TIVCanadian]"
                Case "colTIVEuro"
                    Return "[TIVEuro]"
                Case "colTIVJapanese"
                    Return "[TIVJapanese]"
                Case "colTIVMexican"
                    Return "[TIVMexican]"
                Case "colTIVNewZealand"
                    Return "[TIVNewZealand]"
                Case "colTivus"
                    Return "[TIVUS]"
                Case "colHazard"
                    Return "[Hazard]"
                Case "colEffectiveDate"
                    Return "[EffectiveDate]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[FileNo]", "FileNo", "FileNo", "colFileNo"  
                    Return "colFileNo"
                Case "[Client]", "Client", "Client", "colClient"  
                    Return "colClient"
                Case "[ClientLocNo]", "ClientLocNo", "ClientLocNo", "colClientLocNo"  
                    Return "colClientLocNo"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[CustomAccess]", "CustomAccess", "CustomAccess", "colCustomAccess"  
                    Return "colCustomAccess"
                Case "[Facility]", "Facility", "Facility", "colFacility"  
                    Return "colFacility"
                Case "[Address1]", "Address1", "Address1", "colAddress1"  
                    Return "colAddress1"
                Case "[City]", "City", "City", "colCity"  
                    Return "colCity"
                Case "[StProv]", "StProv", "StProv", "colStProv"  
                    Return "colStProv"
                Case "[Country]", "Country", "Country", "colCountry"  
                    Return "colCountry"
                Case "[100PercentUSTot]", "100PercentUSTot", "PercentUSTot", "colPercentUSTot"  
                    Return "colPercentUSTot"
                Case "[TIVAustralian]", "TIVAustralian", "TIVAustralian", "colTIVAustralian"  
                    Return "colTIVAustralian"
                Case "[TIVBritish]", "TIVBritish", "TIVBritish", "colTIVBritish"  
                    Return "colTIVBritish"
                Case "[TIVCanadian]", "TIVCanadian", "TIVCanadian", "colTIVCanadian"  
                    Return "colTIVCanadian"
                Case "[TIVEuro]", "TIVEuro", "TIVEuro", "colTIVEuro"  
                    Return "colTIVEuro"
                Case "[TIVJapanese]", "TIVJapanese", "TIVJapanese", "colTIVJapanese"  
                    Return "colTIVJapanese"
                Case "[TIVMexican]", "TIVMexican", "TIVMexican", "colTIVMexican"  
                    Return "colTIVMexican"
                Case "[TIVNewZealand]", "TIVNewZealand", "TIVNewZealand", "colTIVNewZealand"  
                    Return "colTIVNewZealand"
                Case "[TIVUS]", "TIVUS", "Tivus", "colTivus"  
                    Return "colTivus"
                Case "[Hazard]", "Hazard", "Hazard", "colHazard"  
                    Return "colHazard"
                Case "[EffectiveDate]", "EffectiveDate", "EffectiveDate", "colEffectiveDate"  
                    Return "colEffectiveDate"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colFilePrefix"
                    Return "String"
                Case "colFileNo"
                    Return "String"
                Case "colClient"
                    Return "String"
                Case "colClientLocNo"
                    Return "String"
                Case "colDivision"
                    Return "String"
                Case "colCustomAccess"
                    Return "String"
                Case "colFacility"
                    Return "String"
                Case "colAddress1"
                    Return "String"
                Case "colCity"
                    Return "String"
                Case "colStProv"
                    Return "String"
                Case "colCountry"
                    Return "String"
                Case "colPercentUSTot"
                    Return "Double"
                Case "colTIVAustralian"
                    Return "Long"
                Case "colTIVBritish"
                    Return "Long"
                Case "colTIVCanadian"
                    Return "Long"
                Case "colTIVEuro"
                    Return "Long"
                Case "colTIVJapanese"
                    Return "Long"
                Case "colTIVMexican"
                    Return "Long"
                Case "colTIVNewZealand"
                    Return "Long"
                Case "colTivus"
                    Return "Long"
                Case "colHazard"
                    Return "String"
                Case "colEffectiveDate"
                    Return "DateTime"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwLocationListing]"
        End Function

        Private Function _FirstColumn() As String
            Return "[FilePrefix]"
        End Function

    End Class
End namespace

