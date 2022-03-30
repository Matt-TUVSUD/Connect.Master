

Imports Microsoft.Office.Interop
Imports System.Reflection

Public MustInherit Class Meta

    Friend MustOverride ReadOnly Property Practice As UtilPractice.PracticeEnum
    Friend MustOverride ReadOnly Property FileNoCellAddress As CellAddress
    Friend MustOverride ReadOnly Property SurveyDateCellAddress As CellAddress
    Friend MustOverride ReadOnly Property TemplateVersionAddress As CellAddress

    'Friend Function GetImportInfoCollection(ByVal pExcelWorkBook As Excel.Workbook) As ImportTableInfoList

    '    Dim zImportInfoCollection As New ImportTableInfoList
    '    Dim zPropValue As ImportTableInfo
    '    Dim zWorkSheet As Excel.Worksheet


    '    Dim zProps() As Reflection.PropertyInfo = Me.GetType.GetProperties
    '    For Each zProperty As Reflection.PropertyInfo In zProps
    '        If zProperty.PropertyType.BaseType Is GetType(ImportTableInfo) Then
    '            zPropValue = zProperty.GetValue(Me, Nothing)

    '            'Check first to see if the sheet exists in the workbook
    '            If ExcelUtility.WorkSheetExists(pExcelWorkBook, zPropValue.SheetName) Then

    '                'If it exists, then get the object
    '                zWorkSheet = pExcelWorkBook.Worksheets(zPropValue.SheetName)

    '                'See if it is visible
    '                If zWorkSheet.Visible Then
    '                    zImportInfoCollection.Add(zPropValue) 'If visible then add to list
    '                End If

    '            End If
    '        End If
    '    Next

    '    Return zImportInfoCollection

    'End Function


    Function GetEntityColumnNameFromMap(ByVal pExcelColumnName As String, ByVal pImportTable As ImportEnum.ImportTable) As String

        Dim zMapCollectionName As String = [Enum].GetName(GetType(ImportEnum.ImportTable), pImportTable) & "MapCollection"
        Dim zMapCollectionProperty As Reflection.PropertyInfo = Me.GetType.GetProperty(zMapCollectionName)

			'Make sure the property exists before continuing
			If pExcelColumnName IsNot Nothing Then
				If zMapCollectionProperty IsNot Nothing Then
					Dim zMapCollection As MapCollection = zMapCollectionProperty.GetValue(Me, Nothing)
					For Each zMap As Map In zMapCollection
						If zMap.ExcelColumnName.ToLower = pExcelColumnName.ToLower Then Return zMap.EntityColumnName
					Next
				End If
			Else
			Throw New ImportException("The excel import table for " & Chr(34) & EsHelper.GetEsTableName(Meta.GetImportTableEntityType(pImportTable)) & Chr(34) & " has a blank column. Make sure your using the correct template for the client you are currently on.")
			End If

			'Return empty string if it can't find the corresponding entity column.
			Return String.Empty
	
	End Function

    Function GetExcelColumnNameFromMap(ByVal pEntityColumnName As String, ByVal pImportTable As ImportEnum.ImportTable) As String

        Dim zMapCollectionName As String = [Enum].GetName(GetType(ImportEnum.ImportTable), pImportTable) & "MapCollection"
        Dim zMapCollectionProperty As Reflection.PropertyInfo = Me.GetType.GetProperty(zMapCollectionName)

        'Make sure the property exists before continuing
        If zMapCollectionProperty IsNot Nothing Then
            Dim zMapCollection As MapCollection = zMapCollectionProperty.GetValue(Me, Nothing)
            For Each zMap As Map In zMapCollection
                If zMap.EntityColumnName.ToLower = pEntityColumnName.ToLower Then Return zMap.ExcelColumnName
            Next
        End If
        Return ""
    End Function

    Function GetMapCollectionList() As Collections.Generic.List(Of MapCollection)

        Dim zMapCollectionList As New List(Of MapCollection)
        Dim zProps() As Reflection.PropertyInfo = Me.GetType.GetProperties
        For Each zProperty As Reflection.PropertyInfo In zProps
            If zProperty.PropertyType Is GetType(MapCollection) Then
                zMapCollectionList.Add(zProperty.GetValue(zProperty.Name, Nothing))
            End If
        Next

        Return zMapCollectionList

    End Function



    'Friend Function GenerateMapCode(ByVal pExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook) As String

    '    Dim zCodeStringBuilder As New Text.StringBuilder
    '    Dim zImportInfoCollection As ImportTableInfoList = GetImportInfoCollection(pExcelWorkBook)

    '    CreateOpeningRegionCode(zCodeStringBuilder)

    '    For Each zImportInfo As ImportTableInfo In zImportInfoCollection

    '        Dim zSheetName As String = zImportInfo.SheetName
    '        Dim zSheet As Excel.Worksheet = pExcelWorkBook.Worksheets(zSheetName)

    '        CreateOpeningPropertyCode(zCodeStringBuilder, zImportInfo.ImportTableEnum)

    '        If zSheet IsNot Nothing And zSheet.Visible Then

    '            Dim zHeaderRange As Excel.Range = zSheet.Range(zImportInfo.HeaderRange)
    '            Dim zColumnList As New List(Of String)

    '            For Each zCell As Excel.Range In zHeaderRange.Cells
    '                zColumnList.Add(zCell.Value)
    '            Next

    '            zCodeStringBuilder.AppendLine(GenerateMapPropertyCode(zImportInfo.ImportTableEnum, zColumnList))

    '        Else
    '            zCodeStringBuilder.AppendLine("' " & zSheetName & " does not exist in the Excel workbook or is hidden.  Could not generate code.<br><br><br>")
    '        End If

    '        CreateClosingPropertyCode(zCodeStringBuilder)

    '    Next

    '    CreateClosingRegionCode(zCodeStringBuilder)

    '    Return zCodeStringBuilder.ToString

    'End Function

    ''' <summary>
    ''' This function creates the code to be viewed in a webpage which then can be copied to the Map class for use.
    ''' </summary>
    ''' <param name="pExcelColumnList"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GenerateMapPropertyCode(ByVal pTable As ImportEnum.ImportTable, ByVal pExcelColumnList As List(Of String)) As String

        Dim zMapCode As New System.Text.StringBuilder
        Dim zRemOut As String

        For Each zExcelColumn As String In pExcelColumnList

            If zExcelColumn IsNot Nothing Then

                zRemOut = ""

                'Check to see if a EntityColumn exists in current map
				Dim zEntityPropertyName As String = Me.GetEntityColumnNameFromMap(zExcelColumn, pTable)

                'If no Entity Column exists in current map, then see if it can get it from the Entity Classes
                If zEntityPropertyName.ToLower = "" Then

                    zEntityPropertyName = GetEntityPropertyNameFromClass(pTable, zExcelColumn)

                    If zEntityPropertyName = "" Then
                        zEntityPropertyName = ""
                        zRemOut = "'"
                    End If

                End If

                zMapCode.AppendLine(zRemOut & ".Add(" & UtilChr.DoubleQuote & zEntityPropertyName & UtilChr.DoubleQuote & "," & UtilChr.DoubleQuote & zExcelColumn & UtilChr.DoubleQuote & ")")

            End If

        Next

        Return zMapCode.ToString

    End Function

    Private Sub CreateOpeningRegionCode(ByVal zCodeStringBuilder As Text.StringBuilder)
        zCodeStringBuilder.AppendLine("#Region " & UtilChr.DoubleQuote & "Map Collections" & UtilChr.DoubleQuote & "  '(Generated On: " & Date.Today.ToShortDateString & ")")
        zCodeStringBuilder.AppendLine()
        zCodeStringBuilder.AppendLine()
    End Sub

    Private Sub CreateOpeningPropertyCode(ByVal zCodeStringBuilder As Text.StringBuilder, ByVal pTable As ImportEnum.ImportTable)
        zCodeStringBuilder.AppendLine("'--AutoGenerated (SQL Table: " & EsHelper.GetEsTableName(Meta.GetImportTableEntityType(pTable)) & ")")
        zCodeStringBuilder.AppendLine("Overridable ReadOnly Property " & [Enum].GetName(GetType(ImportEnum.ImportTable), pTable) & "MapCollection as MapCollection")
        zCodeStringBuilder.AppendLine("Get")
        zCodeStringBuilder.AppendLine("Dim zMap as New MapCollection")
        zCodeStringBuilder.AppendLine("With zMap")
    End Sub

    Private Sub CreateClosingPropertyCode(ByVal zCodeStringBuilder As Text.StringBuilder)
        zCodeStringBuilder.AppendLine("End With")
        zCodeStringBuilder.AppendLine("Return zMap")
        zCodeStringBuilder.AppendLine("End Get")
        zCodeStringBuilder.AppendLine("End Property")
        zCodeStringBuilder.AppendLine()
        zCodeStringBuilder.AppendLine()

    End Sub

    Private Sub CreateClosingRegionCode(ByVal zCodeStringBuilder As Text.StringBuilder)
        zCodeStringBuilder.AppendLine("#End Region")
    End Sub

    Private Function GetEntityPropertyNameFromClass(ByVal pTable As ImportEnum.ImportTable, ByVal pExcelColumnName As String) As String

        Dim zMetaColumns As EntitySpaces.Interfaces.esColumnMetadataCollection = EsHelper.GetEsColumnMetadataCollection(Meta.GetImportTableEntityType(pTable))

        If zMetaColumns IsNot Nothing Then
            For Each zMetaColumn As EntitySpaces.Interfaces.esColumnMetadata In zMetaColumns
				If zMetaColumn.PropertyName.ToLower = pExcelColumnName.ToLower Or
				 zMetaColumn.Name.ToLower = pExcelColumnName.ToLower Then
					Return zMetaColumn.PropertyName
				End If
            Next
        End If

        Return ""

    End Function

    Friend Shared Function GetImportTableEntityType(ByVal pTable As ImportEnum.ImportTable) As System.Type

        Select Case pTable

            Case ImportEnum.ImportTable.FireCopeMain
                Return GetType(BusinessObjects.CopeFireMain)

            Case ImportEnum.ImportTable.FireCopeConstruction
                Return GetType(BusinessObjects.CopeFireConstruction)

            Case ImportEnum.ImportTable.FireCopeOccupancy
                Return GetType(BusinessObjects.CopeFireOccupancy)

            Case ImportEnum.ImportTable.FireCopeExposure
                Return GetType(BusinessObjects.CopeFireExposure)

            Case ImportEnum.ImportTable.FireCopeProtection
                Return GetType(BusinessObjects.CopeFireProtection)

            Case ImportEnum.ImportTable.FireNatHazModeling
                Return GetType(BusinessObjects.CopeNatHazModeling)

            Case ImportEnum.ImportTable.FireRating
                Return GetType(BusinessObjects.Rating)

            Case ImportEnum.ImportTable.FireRecommendation
                Return GetType(BusinessObjects.FireRecommendations)

            Case ImportEnum.ImportTable.FireNatHazFloodBldgStructure
                Return GetType(BusinessObjects.NatHazFloodBldgStructureDetails)

            Case ImportEnum.ImportTable.FireNatHazFloodExposure
                Return GetType(BusinessObjects.NatHazFloodExposureDetails)

            Case ImportEnum.ImportTable.FireNatHazFloodGeneral
                Return GetType(BusinessObjects.NatHazFloodGeneral)

            Case ImportEnum.ImportTable.FireNatHazFloodOther
                Return GetType(BusinessObjects.NatHazFloodOtherDetails)

            Case ImportEnum.ImportTable.FireNatHazSeismicGeneral
                Return GetType(BusinessObjects.NatHazSeismicGeneral)

            Case ImportEnum.ImportTable.FireNatHazSeismicNonStructural
                Return GetType(BusinessObjects.NatHazSeismicNonstructural)

            Case ImportEnum.ImportTable.FireNatHazSeismicStructural
                Return GetType(BusinessObjects.NatHazSeismicStructural)

            Case ImportEnum.ImportTable.FireNatHazSeismicStructuralData
                Return GetType(BusinessObjects.NatHazSeismicStructuralData)

            Case ImportEnum.ImportTable.FireNatHazWindBuildingEnvelope
                Return GetType(BusinessObjects.NatHazWindBuildingEnvelope)

            Case ImportEnum.ImportTable.FireNatHazWindGeneral
                Return GetType(BusinessObjects.NatHazWindGeneral)

            Case ImportEnum.ImportTable.FireNatHazWindOther
                Return GetType(BusinessObjects.NatHazWindMiscellaneousOther)

            Case ImportEnum.ImportTable.FireNatHazWindUtility
                Return GetType(BusinessObjects.NatHazWindUtilities)

            Case ImportEnum.ImportTable.FireNatHazModeling
                Return GetType(BusinessObjects.CopeNatHazModeling)

            Case ImportEnum.ImportTable.FireRetail
				Return GetType(BusinessObjects.FireRetail)

			Case ImportEnum.ImportTable.BmFacilityMain
				Return GetType(BusinessObjects.BmMain)


			Case ImportEnum.ImportTable.BmOccupancy
				Return GetType(BusinessObjects.BmOccupancy)

			Case ImportEnum.ImportTable.BmMechanical
				Return GetType(BusinessObjects.BmMechanical)

			Case ImportEnum.ImportTable.BmElectrical
				Return GetType(BusinessObjects.BmElectrical)

			Case ImportEnum.ImportTable.BmElectricalTransformers
				Return GetType(BusinessObjects.BmElectricalTransformer)

			Case ImportEnum.ImportTable.BmElectricalRotatingEquipment
				Return GetType(BusinessObjects.BmElectricalRotatingEquipment)

			Case ImportEnum.ImportTable.BmBpv
				Return GetType(BusinessObjects.BmBpv)

			Case ImportEnum.ImportTable.BmBpvA
				Return GetType(BusinessObjects.BmBpvA)

			Case ImportEnum.ImportTable.BmCpv
				Return GetType(BusinessObjects.BmCpv)

			Case ImportEnum.ImportTable.BmPrimeMovers
				Return GetType(BusinessObjects.BmPrimeMover)

			Case ImportEnum.ImportTable.BmPpe
				Return GetType(BusinessObjects.BmPpe)

			Case ImportEnum.ImportTable.BmPpeA
				Return GetType(BusinessObjects.BmPpeA)

			Case ImportEnum.ImportTable.BmComputerSystems
				Return GetType(BusinessObjects.BmComputerSystem)

			Case ImportEnum.ImportTable.BmMppm
				Return GetType(BusinessObjects.BmMppm)

			Case ImportEnum.ImportTable.BmEppms
				Return GetType(BusinessObjects.BmEppms)

			Case ImportEnum.ImportTable.BmEppmsA
				Return GetType(BusinessObjects.BmEppmsA)

			Case ImportEnum.ImportTable.BmHebcp
				Return GetType(BusinessObjects.BmHebcp)

			Case ImportEnum.ImportTable.BmRating
				Return GetType(BusinessObjects.BMRating)

            Case ImportEnum.ImportTable.BmRecommendation
                Return GetType(BusinessObjects.BMRecommendations)

            Case ImportEnum.ImportTable.PSRecommendation
                Return GetType(BusinessObjects.PSRecommendations)

        End Select

        Return Nothing

    End Function




End Class

