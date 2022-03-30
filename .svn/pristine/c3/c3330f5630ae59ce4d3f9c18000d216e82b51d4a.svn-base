Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilMeta
    Public PropGridId As Integer = 0
    Public PropSafeGUID As String = ""
    Public PropCurrency As TblMetaCurrency.Currencies = TblMetaCurrency.Currencies.UsDollar
    Public PropOverrideCurrency As Nullable(Of TblMetaCurrency.Currencies) = Nothing
    Public PropFilePrefix As String = ""
    Public PropFavoriteId As Integer = 0
    'Private MetaColumnOrder As List(Of String)
    Private MetaColumnOrder As List(Of JSONColumnOrder)

    Const _DEFAULT_JSRGB As String = "rgb(255,255,255)"

    Private Shared _MetaKeys As List(Of rowTblMetaKey) = Nothing
    
    Public Shared Function GetMetaKey(pKeyName As String, Optional pDefaultKeyValue As Integer = 0) As Integer

        If IsNothing(_MetaKeys) Then
            _MetaKeys = GRC.Connect.Libraries.DataLib.razor.TblMetaKey.LoadData()
        End If

        Dim zReturn As Integer = 0

        Dim zMetaKey As rowTblMetaKey = _MetaKeys.Find(Function(x) x.colFldKeyName = pKeyName)

        If Not IsNothing(zMetaKey) Then
            zReturn = zMetaKey.colFldKeyValue
        Else
            If pDefaultKeyValue > 0 Then
                'If the key does not exist and a default as been supplied then insert the key on the fly.
                Dim zNewKey As New rowTblMetaKey
                zNewKey.colFldKeyValue = pDefaultKeyValue
                zNewKey.colFldKeyName = pKeyName
                TblMetaKey.Save(zNewKey)
                zReturn = zNewKey.colFldKeyValue
            End If
        End If

        Return zReturn
    End Function

    Private Sub ParseJSONData(pJSON As String)
        Dim zDoc As New Dictionary(Of String, Object)
        zDoc = DeserializeToDictionary(pJSON)
        PrintObject(zDoc)
        Stop
    End Sub

    Private Sub PrintObject(pDict As Dictionary(Of String, Object))
        For Each zKey As String In pDict.Keys
            Diagnostics.Debug.Print(zKey)

            If TypeOf (pDict(zKey)) Is Dictionary(Of String, Object) Then
                Diagnostics.Debug.Print(zKey)
                Dim zObj As Dictionary(Of String, Object)
                zObj = pDict(zKey)
                PrintObject(zObj)
            Else
                Diagnostics.Debug.Print(zKey & " - " & pDict(zKey).ToString)
            End If
        Next
    End Sub

    Private Function DeserializeToDictionary(pJSON As String) As Dictionary(Of String, Object)
        Dim zValues = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(pJSON)
        Dim zValues2 = New Dictionary(Of String, Object)()
        For Each zKVP As KeyValuePair(Of String, Object) In zValues
            If TypeOf zKVP.Value Is Newtonsoft.Json.Linq.JObject Then
                zValues2.Add(zKVP.Key, DeserializeToDictionary(zKVP.Value.ToString()))
            Else
                zValues2.Add(zKVP.Key, zKVP.Value)
            End If
        Next
        Return zValues2
    End Function

    Private Function GetMetaColumnOrderLocked(pColumnName As String, pMetaDefaultLocked As Boolean) As Boolean
        Dim zReturn As Boolean = False  'If the column name is NOT found then unlock the column

        If Not MetaColumnOrder Is Nothing Then
            For Each zItem As JSONColumnOrder In MetaColumnOrder
                If zItem.field.ToLower = pColumnName.ToLower Then
                    zReturn = zItem.locked
                    Exit For
                End If
            Next zItem
        End If

        Return zReturn
    End Function

    Private Function GetMetaColumnOrderIndex(pColumnName As String, pMetaDefaultIndex As Integer) As Integer
        Dim zReturn As Integer = 1000 + pMetaDefaultIndex 'If the column name is NOT found then push the column out past the end of the sorted list in the original order they come from the database index value
        Dim zPos As Integer = 1

        If Not MetaColumnOrder Is Nothing Then
            For Each zItem As JSONColumnOrder In MetaColumnOrder
                If zItem.field.ToLower = pColumnName.ToLower Then
                    zReturn = zPos
                    Exit For
                End If
                zPos = zPos + 1
            Next zItem
        End If

        Return zReturn
    End Function

    Public Class JSONColumnOrder
        Public locked As Boolean
        Public field As String
    End Class

    Public Function GetGridMeta() As Dictionary(Of String, Object)
        Dim zReturn As Dictionary(Of String, Object)

        If PropFavoriteId > 0 Then
            Dim zFav As rowTblGridFavorite = UtilGridFavorite.LoadFavorite(PropFavoriteId)
            If Not zFav Is Nothing Then
                PropGridId = zFav.colFldGridId
                'MetaColumnOrder = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(zFav.colFldColumnOrderJSON)
                MetaColumnOrder = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of JSONColumnOrder))(zFav.colFldColumnOrderJSON)
            End If
        End If

        Dim zCTypes As New List(Of rowTblMetaGridColumnType)
        zCTypes = TblMetaGridColumnType.LoadData()
        Dim zDictCTypes As New Dictionary(Of Integer, String)

        For Each zCType As rowTblMetaGridColumnType In zCTypes
            zDictCTypes.Add(zCType.colFldId, zCType.colFldName)
        Next

        Dim zMG As New rowTblMetaGrid
        zMG = TblMetaGrid.LoadByPrimaryKey(Me.PropGridId)

        Dim zSB As New StringBuilder
        With zSB
            .Append(" SELECT * FROM ")
            .Append(" (SELECT ROW_NUMBER() OVER (PARTITION BY fldId ORDER BY FLDFILEPREFIX DESC, INDEXORDER ASC ) as RowNo,* FROM gv.vwMetaGridColumns WHERE fldMetaGridId = @fldMetaGridId AND include = 1 AND (fldFilePrefix=@fldFilePrefix OR fldFilePrefix=0) ")
            .Append(") C ")
            .Append("WHERE RowNo = 1 ")
            .Append("ORDER BY INDEXORDER")
        End With

        Dim zMGCols As New List(Of rowVwMetaGridColumns)
        Dim zCmd As New SqlClient.SqlCommand(zSB.ToString)
        zCmd.Parameters.AddWithValue("@fldMetaGridId", zMG.colFldId)
        zCmd.Parameters.AddWithValue("@fldFilePrefix", Me.PropFilePrefix)
        zMGCols = VwMetaGridColumns.LoadData(zCmd)

        Dim zFields As New Dictionary(Of String, Object)
        Dim zFieldAttr As Dictionary(Of String, Object)
        Dim zColAttr As Dictionary(Of String, Object)
        Dim zColOrderList As New Dictionary(Of Integer, Object)
        Dim zColList As New List(Of Object)
        Dim zIndices As New Dictionary(Of String, Integer)
        Dim zSources As New Dictionary(Of String, Object)
        Dim zSourceAttr As Dictionary(Of String, Object)

        For Each zCol As rowVwMetaGridColumns In zMGCols
            zFieldAttr = New Dictionary(Of String, Object)
            zFieldAttr.Add("nullable", zCol.colNullable)
            zFieldAttr.Add("editable", zCol.colEditable)
            zFieldAttr.Add("type", zDictCTypes.Item(zCol.colType))

            zColAttr = New Dictionary(Of String, Object)
            zColAttr.Add("field", zCol.expFieldName)
            zColAttr.Add("fieldnamebackcolor", zCol.colFldFieldNameBackColor)
            zColAttr.Add("encoded", zCol.colEncoded)
            zColAttr.Add("filterable", zCol.colFilterable)
            zColAttr.Add("format", zCol.colFormat)
            zColAttr.Add("groupable", zCol.colGroupable)
            zColAttr.Add("hidden", SetHidden(zCol.colHidden, zCol.colFldCustomFeature))  'Add call to handle custom feature visibility setting 
            zColAttr.Add("fldExcludeFromExtract", SetHidden(zCol.colFldExcludeFromExtract, zCol.colFldCustomFeature))  'Add call to handle custom feature visibility setting 
            zColAttr.Add("locked", GetMetaColumnOrderLocked(zCol.expFieldName, zCol.colLocked))
            zColAttr.Add("lockable", zCol.colLockable)
            zColAttr.Add("menu", zCol.colMenu)
            zColAttr.Add("sortable", zCol.colSortable)
            zColAttr.Add("width", zCol.colWidth)
            zColAttr.Add("editor", zCol.colEditor)
            zColAttr.Add("feature", zCol.colFldCustomFeature)
            zColAttr.Add("fldExtractWrapText", zCol.colFldExtractWrapText)
            zColAttr.Add("footerTemplate", zCol.colFooterTemplate)
            zColAttr.Add("isDepictable", zCol.colFldMapIsDepictable)
            zColAttr.Add("isPicklistable", zCol.colFldMapIsPicklistable)
            zColAttr.Add("isDefaultDepicted", zCol.colFldMapDefaultDepicted)
            zColAttr.Add("headerAttributes", GetHeaderAttributes(zCol.colHeaderAttributes))
            If zCol.colTitle Is Nothing Or zCol.colTitle = "" Then
                zColAttr.Add("title", " ")
            Else
                zColAttr.Add("title", ProcessReplacers(zCol.colFldDisplayTitle))
            End If
            If Not zCol.colFldFieldNameBackColor Is Nothing Then
                zColAttr.Add("template", ProcessBackgroundColor(zCol.expFieldName, zCol.colFldFieldNameBackColor, zDictCTypes.Item(zCol.colType)))
            Else
                zColAttr.Add("template", ProcessReplacers(zCol.colTemplate))
            End If

            zSourceAttr = New Dictionary(Of String, Object)
            zSourceAttr.Add("SrcField", zCol.colSrcField)
            zSourceAttr.Add("SrcTable", zCol.colSrcTable)
            zSourceAttr.Add("KeyField", zCol.colKeyField)

            If Not zColAttr.Item("title") Is Nothing Then
                If zColAttr.Item("title").ToString.ToLower <> "Not Used".ToLower Then
                    zIndices.Add(zCol.expFieldName, zCol.colIndexOrder)
                    'zColList.Add(zColAttr)  'this one needs to be sorted
                    zColOrderList.Add(GetMetaColumnOrderIndex(zCol.expFieldName, zCol.colIndexOrder), zColAttr)
                    zSources.Add(zCol.expFieldName, zSourceAttr)
                    zFields.Add(zCol.expFieldName, zFieldAttr)
                End If
            Else
                zIndices.Add(zCol.expFieldName, zCol.colIndexOrder)
                zColList.Add(zColAttr)
                zSources.Add(zCol.expFieldName, zSourceAttr)
                zFields.Add(zCol.expFieldName, zFieldAttr)
            End If

            zFieldAttr = Nothing
            zSourceAttr = Nothing
            zColAttr = Nothing
        Next

        'Build zColList based on zColOrderList
        Dim zKeys As List(Of Integer) = zColOrderList.Keys.ToList
        zKeys.Sort()

        Dim zNdx As Integer = 0
        For Each zNdx In zKeys
            zColList.Add(zColOrderList.Item(zNdx))
        Next

        Dim zModel As New Dictionary(Of String, Object)
        zModel.Add("gridid", zMG.colFldId)
        zModel.Add("name", zMG.colFldGridName)
        zModel.Add("id", zMG.colFldKeyField)
        zModel.Add("extractheaderheight", zMG.colFldExtractHeaderRowHeight)
        zModel.Add("fields", zFields)

        Dim zSchema As New Dictionary(Of String, Object)
        zSchema.Add("model", zModel)

        Dim zDetailTemplate As String = Nothing
        If Not zMG.colFldFormViewTemplateName Is Nothing Then
            zDetailTemplate = ProcessReplacers(zMG.colFldFormViewTemplateName)
        End If

        Dim zDoc As New Dictionary(Of String, Object)
        zDoc.Add("schema", zSchema)
        zDoc.Add("columns", zColList)
        zDoc.Add("indices", zIndices)
        zDoc.Add("sources", zSources)
        zDoc.Add("detailTemplate", zDetailTemplate)

        zReturn = zDoc

        'serialize to json
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zReturn)

        Return zReturn
    End Function



    'Title
    '==========
    'TIV {{Currency.Code}}{{Currency.Symbol}} (millions)
    '{{Clients.CustomAccessLabel}}
    '{{Clients.CustomAccessLabel}}
    'Constr. Area ({{UnitOfMeasure.Distance}})
    'FL Depth {{UnitOfMeasure.Name}}

    Private Function SetHidden(pHidden As Boolean, pGridColumnFeature As String) As Boolean
        Dim zClientFeature As String = ""

        If Not pGridColumnFeature Is Nothing Then
            If pGridColumnFeature.Length > 0 Then
                Dim zFilePrefix As String = Me.PropFilePrefix

                If Me.PropSafeGUID.Length > 0 Then
                    zFilePrefix = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, GRC.Connect.Libraries.CoreLib.UtilGSafe.KeyName.FilePreFix)
                End If

                Dim zRC As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(zFilePrefix)
                If zRC.Count > 0 Then
                    zClientFeature = zRC(0).colFeatures
                End If

                If Not String.IsNullOrEmpty(zClientFeature) Then
                    Dim zGridColumnFeatureNdx As Integer = 0
                    For zGridColumnFeatureNdx = 1 To pGridColumnFeature.Length
                        Dim zClientFeatureNdx As Integer = 0
                        For zClientFeatureNdx = 1 To zClientFeature.Length
                            If pGridColumnFeature.Substring(zGridColumnFeatureNdx - 1, 1) = zClientFeature.Substring(zClientFeatureNdx - 1, 1) Then
                                Return Not pHidden  'Flip the hidden property if the custom feature matches.
                            End If
                        Next
                    Next
                End If
            End If
        End If

        Return pHidden
    End Function

    Private Function FillReplacer(pReplacer As String) As String
        Dim zReturn As String = pReplacer
        Dim zKeyWords As String = pReplacer

        'Handle specific replacer cases in the main case block, handle sub cases in the else
        Select Case zKeyWords
            Case "{{Clients.CustomAccessLabel}}"
                Dim zFilePrefix As String = Me.PropFilePrefix

                If Me.PropSafeGUID.Length > 0 Then
                    zFilePrefix = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, GRC.Connect.Libraries.CoreLib.UtilGSafe.KeyName.FilePreFix)
                End If

                Dim zRC As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(zFilePrefix)
                If zRC.Count > 0 Then
                    zReturn = zRC(0).colCustomAccessLabel
                End If

            Case "{{Currency.Code}}"
                ' IS THERE A CHART PREFILTER CURRENCY SET, OR IS IT A PREFERENCE, OR IS IT SET AS A PROPERTY?
                If Me.PropSafeGUID.Length > 0 Then
                    If Not Me.PropOverrideCurrency Is Nothing Then
                        Dim zCurrencyCol As New GRC.Connect.Libraries.CoreLib.BusinessObjects.CurrencyDefinitionCollection
                        Dim zCurrencyQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.CurrencyDefinitionQuery("t1")
                        zCurrencyQry.SelectAll()
                        zCurrencyQry.Where(zCurrencyQry.EnumValue = Me.PropOverrideCurrency)
                        If zCurrencyCol.Load(zCurrencyQry) Then
                            zReturn = zCurrencyCol(0).Code & ""
                        End If
                    Else
                        Dim zPrefCurrCode As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, Me.PropFilePrefix, GRC.Connect.Libraries.CoreLib.UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
                        zReturn = zPrefCurrCode
                    End If
                Else
                    zReturn = TblMetaCurrency.GetCurrencyCode(Me.PropCurrency)
                End If

            Case "{{Currency.Symbol}}"
                Dim zCurrencyCol As New GRC.Connect.Libraries.CoreLib.BusinessObjects.CurrencyDefinitionCollection
                Dim zCurrencyQry As New GRC.Connect.Libraries.CoreLib.BusinessObjects.CurrencyDefinitionQuery("t1")
                zCurrencyQry.SelectAll()

                ' IS THERE A CHART PREFILTER CURRENCY SET, OR IS IT A PREFERENCE, OR IS IT SET AS A PROPERTY?
                If Not Me.PropOverrideCurrency Is Nothing Then
                    zCurrencyQry.Where(zCurrencyQry.EnumValue = Me.PropOverrideCurrency)
                Else
                    Dim zPrefCurrCode As String = ""
                    If Me.PropSafeGUID.Length > 0 Then
                        zPrefCurrCode = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, Me.PropFilePrefix, GRC.Connect.Libraries.CoreLib.UtilGSafe.PreferenceKeyName.CurrencyDefaultText)
                    Else
                        zPrefCurrCode = TblMetaCurrency.GetCurrencyCode(Me.PropCurrency)
                    End If
                    zCurrencyQry.Where(zCurrencyQry.Code = zPrefCurrCode)
                End If

                If zCurrencyCol.Load(zCurrencyQry) Then
                    zReturn = zCurrencyCol(0).Symbol & ""
                End If

            Case "{{UnitOfMeasure.Distance}}"
                'Dim zPrefUnitCode As String = GRC.Connect.Libraries.CoreLib..UtilGSafe.GetValue(Me.PropSafeGUID, GRC.Connect.Libraries.CoreLib..UtilGSafe.KeyName.UnitDefaultText)
                'zReturn = zPrefUnitCode

            Case "{{UnitOfMeasure.Name}}"
                If Me.PropSafeGUID.Length > 0 Then
                    Dim zPrefUnitCode As String = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(Me.PropSafeGUID, Me.PropFilePrefix, GRC.Connect.Libraries.CoreLib.UtilGSafe.PreferenceKeyName.UnitDefaultText)
                    zReturn = zPrefUnitCode
                End If

            Case Else
                'Handle replacer sub cases (ie: color, alias, templates)
                If InStr(zKeyWords, "=") > 0 Then
                    Const _NAME As Integer = 0
                    Const _VALUE As Integer = 1
                    Dim zKeyWordsNoBraces As String = Replace(Replace(zKeyWords, "{{", ""), "}}", "")
                    Dim zParts() As String = Split(zKeyWordsNoBraces, "=")
                    Select Case zParts(_NAME)

                        Case "tblMetaGridColumnTemplate.fldTemplateCode"
                            zReturn = GetTemplate(zParts(_VALUE))

                        Case "tblMetaColor.fldColor"
                            zReturn = GetRGBColor(zParts(_VALUE))

                        Case "tblMetaColorAlias.fldAlias"
                            zReturn = GetRGBAlias(zParts(_VALUE))

                    End Select
                End If
        End Select

        Return zReturn
    End Function

    Private Function GetTemplate(pAlias As String) As String
        Dim zReturn As String = ""
        Dim zTemplate As String = ""

        Dim zRows As List(Of rowTblMetaGridColumnTemplate)
        zRows = TblMetaGridColumnTemplate.LoadByIDX_IDX_Name(pAlias)
        If zRows.Count > 0 Then
            zTemplate = zRows(0).colFldTemplateSource
        End If

        'Look for replacers in template code itself
        zReturn = ProcessReplacers(zTemplate)

        Return zReturn
    End Function

    Private Function GetRGBAlias(pAlias As String) As String
        Dim zReturn As String = _DEFAULT_JSRGB

        Dim zRows As List(Of rowTblMetaColorAlias)
        zRows = TblMetaColorAlias.LoadByIDX_IDX_Alias(pAlias)
        If zRows.Count > 0 Then
            zReturn = GetRGBColor(zRows(0).colFldColorId.Value)
        End If

        Return zReturn
    End Function

    Private Function GetRGBColor(pColorId As Integer) As String
        Dim zReturn As String = _DEFAULT_JSRGB

        Dim zRows As List(Of rowTblMetaColor)
        zRows = TblMetaColor.LoadByIDX_PK_tblMetaColor(pColorId)
        If zRows.Count > 0 Then
            zReturn = BuildJSRGB(zRows(0).colFldR, zRows(0).colFldG, zRows(0).colFldB)
        End If

        Return zReturn
    End Function

    Private Function GetRGBColor(pColor As String) As String
        Dim zReturn As String = _DEFAULT_JSRGB

        Dim zRows As List(Of rowTblMetaColor)
        zRows = TblMetaColor.LoadByIDX_IDX_Color(pColor)
        If zRows.Count > 0 Then
            zReturn = BuildJSRGB(zRows(0).colFldR, zRows(0).colFldG, zRows(0).colFldB)
        End If

        Return zReturn
    End Function

    Private Function BuildJSRGB(pRed As Integer, pGreen As Integer, pBlue As Integer) As String
        Dim zReturn As String = ""

        zReturn = "rgb(fldR, fldG, fldB)"
        zReturn = Replace(zReturn, "fldR", pRed.ToString)
        zReturn = Replace(zReturn, "fldG", pGreen.ToString)
        zReturn = Replace(zReturn, "fldB", pBlue.ToString)

        Return zReturn
    End Function

    Private Function ProcessReplacers(pString As String) As String
        Dim zReturn As String = pString
        If Not pString Is Nothing Then
            If pString.Contains("{{") And pString.Contains("}}") Then
                Dim zReplacers As List(Of String)
                zReplacers = GetReplacers(pString)
                If Not zReplacers Is Nothing Then
                    For Each zReplacer As String In zReplacers
                        Dim zReplacementValue As String = FillReplacer(zReplacer)
                        zReturn = Replace(zReturn, zReplacer, zReplacementValue)
                    Next
                Else
                    zReturn = pString
                End If
            Else
                zReturn = pString
            End If
        End If
        Return zReturn
    End Function

    Private Function ProcessBackgroundColor(pFieldName As String, pFieldNameBackColor As String, pType As String) As String
        'TYPES = string, number, boolean, date
        Dim zReturn As String = ""
        Select Case pType
            Case "date"
                Dim zDateFunction As String = "kendo.toString(kendo.parseDate(pData[zFieldName],'dd/MM/yyyy'), 'dd-MMM-yyyy')"
                zReturn = zReturn & "function(pData) {"
                zReturn = zReturn & "var zTemplate = ' ';"
                zReturn = zReturn & "var zFieldName = '" & pFieldName & "';"
                zReturn = zReturn & "var zFieldNameColor = '" & pFieldNameBackColor & "';"
                zReturn = zReturn & "var zFieldValue = " & zDateFunction & ";"
                zReturn = zReturn & "if (!zFieldValue) { zFieldValue = ' '; }"
                zReturn = zReturn & "var zTemplate = ""<div class='gridColorHighlight "" + zFieldNameColor + ""' style='background-color: "" + pData[zFieldNameColor] + ""'>"" + zFieldValue + ""</div>"";"
                'zReturn = zReturn & "debugger;"
                zReturn = zReturn & "return zTemplate;"
                zReturn = zReturn & "}"
            Case Else
                zReturn = zReturn & "function(pData) {"
                zReturn = zReturn & "var zTemplate = ' ';"
                zReturn = zReturn & "var zFieldName = '" & pFieldName & "';"
                zReturn = zReturn & "var zFieldNameColor = '" & pFieldNameBackColor & "';"
                zReturn = zReturn & "var zFieldValue = pData[zFieldName];"
                zReturn = zReturn & "if (!zFieldValue) { zFieldValue = ' '; }"
                zReturn = zReturn & "var zTemplate = ""<div class='gridColorHighlight "" + zFieldNameColor + ""' style='background-color: "" + pData[zFieldNameColor] + ""'>"" + zFieldValue + ""</div>"";"
                'zReturn = zReturn & "debugger;"
                zReturn = zReturn & "return zTemplate;"
                zReturn = zReturn & "}"
        End Select
        Return zReturn
    End Function

    Private Function GetReplacers(pString As String) As List(Of String)
        Dim zReturn As New List(Of String)
        Dim zLoop As Boolean = True
        Dim zStart As Integer = 1
        Dim zEnd As Integer = 1
        Dim zReplacer As String = ""

        While zLoop
            zStart = InStr(zStart, pString, "{{")
            If zStart > 0 Then
                zEnd = InStr(zStart, pString, "}}")
                If zEnd > 0 Then
                    zEnd = zEnd + 2
                    zReplacer = Mid(pString, zStart, zEnd - zStart)
                    zReturn.Add(zReplacer)
                    zStart = zStart + 2
                Else
                    zLoop = False
                End If
            Else
                zLoop = False
            End If
        End While

        Return zReturn
    End Function

    Private Function GetHeaderAttributes(pHeaderAttributeId As Integer?) As Dictionary(Of String, Object)
        ' GET THE HEADER ATTRIBUTES AND BUILD OBJECT
        Dim zReturn As New Dictionary(Of String, Object)
        If pHeaderAttributeId Is Nothing Then
            zReturn = Nothing
        Else
            Dim zObj As New rowTblMetaGridColumnHeaderAttributes
            zObj = TblMetaGridColumnHeaderAttributes.LoadByPrimaryKey(pHeaderAttributeId)
            If Not zObj Is Nothing Then
                zReturn.Add("class", zObj.colClass)
                zReturn.Add("style", zObj.colStyle)
            Else
                zReturn = Nothing
            End If
        End If
        Return zReturn
    End Function

    Public Function GetPreFiltersReports(pReportCode As Integer) As List(Of rowVwMetaReportPrefilters)
        Dim zReturn As New List(Of rowVwMetaReportPrefilters)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM [rv].[vwMetaReportPrefilters] WHERE [RptCode] = @RptCode")
        zCmd.Parameters.AddWithValue("@RptCode", pReportCode)
        zReturn = VwMetaReportPrefilters.LoadData(zCmd)
        Return zReturn
    End Function

    Public Function GetPreFiltersCharts(pChartId As Integer) As List(Of rowVwMetaChartPrefilters)
        Dim zReturn As New List(Of rowVwMetaChartPrefilters)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM [cv].[vwMetaChartPrefilters] WHERE [ChartCode] = @ChartCode")
        zCmd.Parameters.AddWithValue("@ChartCode", pChartId)
        zReturn = VwMetaChartPrefilters.LoadData(zCmd)
        Return zReturn
    End Function

End Class

