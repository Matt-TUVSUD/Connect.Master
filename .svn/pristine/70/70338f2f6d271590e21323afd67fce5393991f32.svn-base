'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryVwEzyUsersFilters
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colEzyUsersID As New razor.UtilSQLServer.StringDataColumn
        Public colEmail As New razor.UtilSQLServer.StringDataColumn
        Public colGSafeGUID As New razor.UtilSQLServer.StringDataColumn
        Public colFilePrefix As New razor.UtilSQLServer.ShortDataColumn
        Public colDivision As New razor.UtilSQLServer.StringDataColumn
        Public colPlant As New razor.UtilSQLServer.StringDataColumn
        Public colCustomAccessText As New razor.UtilSQLServer.StringDataColumn
        Public colClientLocNoText As New razor.UtilSQLServer.StringDataColumn
        Public colFacilityText As New razor.UtilSQLServer.StringDataColumn
        Public colCityText As New razor.UtilSQLServer.StringDataColumn
        Public colStProvText As New razor.UtilSQLServer.StringDataColumn
        Public colCountryText As New razor.UtilSQLServer.StringDataColumn
        Public colCCActive As New razor.UtilSQLServer.BooleanDataColumn
        Public colCityManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colStProvManager As New razor.UtilSQLServer.BooleanDataColumn
        Public colActiveUser As New razor.UtilSQLServer.BooleanDataColumn
        Public colCCOnly As New razor.UtilSQLServer.BooleanDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colEzyUsersID.ColumnName = "[ezyUsersID]"
            colEmail.ColumnName = "[Email]"
            colGSafeGUID.ColumnName = "[GSafeGUID]"
            colFilePrefix.ColumnName = "[FilePrefix]"
            colDivision.ColumnName = "[Division]"
            colPlant.ColumnName = "[Plant]"
            colCustomAccessText.ColumnName = "[CustomAccessText]"
            colClientLocNoText.ColumnName = "[ClientLocNoText]"
            colFacilityText.ColumnName = "[FacilityText]"
            colCityText.ColumnName = "[CityText]"
            colStProvText.ColumnName = "[StProvText]"
            colCountryText.ColumnName = "[CountryText]"
            colCCActive.ColumnName = "[CCActive]"
            colCityManager.ColumnName = "[CityManager]"
            colStProvManager.ColumnName = "[StProvManager]"
            colActiveUser.ColumnName = "[ActiveUser]"
            colCCOnly.ColumnName = "[CCOnly]"

            _Members.Add("colEzyUsersID", colEzyUsersID)
            _Members.Add("colEmail", colEmail)
            _Members.Add("colGSafeGUID", colGSafeGUID)
            _Members.Add("colFilePrefix", colFilePrefix)
            _Members.Add("colDivision", colDivision)
            _Members.Add("colPlant", colPlant)
            _Members.Add("colCustomAccessText", colCustomAccessText)
            _Members.Add("colClientLocNoText", colClientLocNoText)
            _Members.Add("colFacilityText", colFacilityText)
            _Members.Add("colCityText", colCityText)
            _Members.Add("colStProvText", colStProvText)
            _Members.Add("colCountryText", colCountryText)
            _Members.Add("colCCActive", colCCActive)
            _Members.Add("colCityManager", colCityManager)
            _Members.Add("colStProvManager", colStProvManager)
            _Members.Add("colActiveUser", colActiveUser)
            _Members.Add("colCCOnly", colCCOnly)
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
                Case "colEzyUsersID"
                    Return "[ezyUsersID]"
                Case "colEmail"
                    Return "[Email]"
                Case "colGSafeGUID"
                    Return "[GSafeGUID]"
                Case "colFilePrefix"
                    Return "[FilePrefix]"
                Case "colDivision"
                    Return "[Division]"
                Case "colPlant"
                    Return "[Plant]"
                Case "colCustomAccessText"
                    Return "[CustomAccessText]"
                Case "colClientLocNoText"
                    Return "[ClientLocNoText]"
                Case "colFacilityText"
                    Return "[FacilityText]"
                Case "colCityText"
                    Return "[CityText]"
                Case "colStProvText"
                    Return "[StProvText]"
                Case "colCountryText"
                    Return "[CountryText]"
                Case "colCCActive"
                    Return "[CCActive]"
                Case "colCityManager"
                    Return "[CityManager]"
                Case "colStProvManager"
                    Return "[StProvManager]"
                Case "colActiveUser"
                    Return "[ActiveUser]"
                Case "colCCOnly"
                    Return "[CCOnly]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[ezyUsersID]", "ezyUsersID", "EzyUsersID", "colEzyUsersID"  
                    Return "colEzyUsersID"
                Case "[Email]", "Email", "Email", "colEmail"  
                    Return "colEmail"
                Case "[GSafeGUID]", "GSafeGUID", "GSafeGUID", "colGSafeGUID"  
                    Return "colGSafeGUID"
                Case "[FilePrefix]", "FilePrefix", "FilePrefix", "colFilePrefix"  
                    Return "colFilePrefix"
                Case "[Division]", "Division", "Division", "colDivision"  
                    Return "colDivision"
                Case "[Plant]", "Plant", "Plant", "colPlant"  
                    Return "colPlant"
                Case "[CustomAccessText]", "CustomAccessText", "CustomAccessText", "colCustomAccessText"  
                    Return "colCustomAccessText"
                Case "[ClientLocNoText]", "ClientLocNoText", "ClientLocNoText", "colClientLocNoText"  
                    Return "colClientLocNoText"
                Case "[FacilityText]", "FacilityText", "FacilityText", "colFacilityText"  
                    Return "colFacilityText"
                Case "[CityText]", "CityText", "CityText", "colCityText"  
                    Return "colCityText"
                Case "[StProvText]", "StProvText", "StProvText", "colStProvText"  
                    Return "colStProvText"
                Case "[CountryText]", "CountryText", "CountryText", "colCountryText"  
                    Return "colCountryText"
                Case "[CCActive]", "CCActive", "CCActive", "colCCActive"  
                    Return "colCCActive"
                Case "[CityManager]", "CityManager", "CityManager", "colCityManager"  
                    Return "colCityManager"
                Case "[StProvManager]", "StProvManager", "StProvManager", "colStProvManager"  
                    Return "colStProvManager"
                Case "[ActiveUser]", "ActiveUser", "ActiveUser", "colActiveUser"  
                    Return "colActiveUser"
                Case "[CCOnly]", "CCOnly", "CCOnly", "colCCOnly"  
                    Return "colCCOnly"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colEzyUsersID"
                    Return "String"
                Case "colEmail"
                    Return "String"
                Case "colGSafeGUID"
                    Return "String"
                Case "colFilePrefix"
                    Return "Short"
                Case "colDivision"
                    Return "String"
                Case "colPlant"
                    Return "String"
                Case "colCustomAccessText"
                    Return "String"
                Case "colClientLocNoText"
                    Return "String"
                Case "colFacilityText"
                    Return "String"
                Case "colCityText"
                    Return "String"
                Case "colStProvText"
                    Return "String"
                Case "colCountryText"
                    Return "String"
                Case "colCCActive"
                    Return "Boolean"
                Case "colCityManager"
                    Return "Boolean"
                Case "colStProvManager"
                    Return "Boolean"
                Case "colActiveUser"
                    Return "Boolean"
                Case "colCCOnly"
                    Return "Boolean"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[vwEzyUsersFilters]"
        End Function

        Private Function _FirstColumn() As String
            Return "[ezyUsersID]"
        End Function

    End Class
End namespace

