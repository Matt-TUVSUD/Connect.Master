Imports GRC.Connect.Libraries.DataLib.razor
Imports Telerik.WinControls.UI
Imports GRC.Connect.Winforms.UtilityForms.Meta.MetaData

Namespace Meta

    Public Class MetaRadGridTemplates

        Public Shared Function CreateTemplate(pDataSource As Meta.MetaData.DataSources, Optional ByRef pMasterViewTemplate As MasterGridViewTemplate = Nothing) As GridViewTemplate
            Dim zTemplate As New GridViewTemplate
            If Not IsNothing(pMasterViewTemplate) Then zTemplate = pMasterViewTemplate

            With zTemplate
                .AutoGenerateColumns = False
                .EnableFiltering = True
                .AllowAddNewRow = True

                Select Case pDataSource
                    Case DataSources.Grids
                        zTemplate.DataSource = MetaData.Grids
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridIDMetaDataTextBoxColumn(), "ID", "colFldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Name", "colFldGridName", 300, True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Page Title", "colFldGridPageTitle", 300, False))
                        .Columns.Add(CreateColumn(New Meta.SourceIDMetaDataTextBoxColumn, "Source", "colFldSourceId", 75, True))
                        .Columns.Add(CreateColumn(New Meta.ReportIDMetaDataTextBoxColumn(), "Report", "colFldReportId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Sub Title", "colFldGridPageSubTitle", 300, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Practuce", "colFldGridPractice", 75, False))
                        .Caption = "Grids"

                    Case DataSources.NavLinks
                        zTemplate.DataSource = MetaData.Navlink

                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.NavLinkIDMetaDataTextBoxColumn(), "ID", "colNavLinkId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "PracticeID", "colNavPracticeID", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideMenuID", "colSlideMenuId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideGroupID", "colSlideGroupId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideLevelID", "colSlideLevelId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideParentID", "colSlideParentId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideOrder", "colSlideOrder", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideType", "colSlideType", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SlideImageClassName", "colSlideImageClassName", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Text", "colNavText", 125, True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Url", "colNavUrl", 200, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "NavLevel", "colNavLevelID", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "NavParentID", "colNavParentLinkID", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Visible", "colNavVisible", 75, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Enabled", "colNavEnabled", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Spc Feature", "colNavSpcFeature", 75, False))
                        .Columns.Add(CreateColumn(New Meta.ReportIDMetaDataTextBoxColumn(), "ReportId", "colNavReportId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridIDMetaDataTextBoxColumn(), "GridId", "colNavGridId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridIDMetaDataTextBoxColumn(), "ChartId", "colNavChartId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "AllRpts Keyword", "colNavAllReportsKeyword", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SiteMap Keyword", "colNavSiteMapKeyword", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Target", "colNavTarget", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Constant", "colNavConstant", 150, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "IsClientAdmin", "colIsClientAdmin", 50, True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "NavOrder", "colNavOrder", 50, True, "", "", True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ByPassFilter", "colNavBypassFilter", 50, True, "", "", True))

                        .Caption = "NavLinks"

                    Case DataSources.Reports
                        zTemplate.DataSource = MetaData.Reports
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.ReportIDMetaDataTextBoxColumn(), "ID", "colfldId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Name", "colFldName", 250, True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "FileName", "colFldFileName", 250, True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Type Name", "colFldTypeName", 250, True))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Vendor", "colFldVendorId", 75, True))
                        .Columns.Add(CreateColumn(New Meta.SourceIDMetaDataTextBoxColumn(), "SourceID", "colfldSourceId", 75, True))
                        .Columns.Add(CreateColumn(New Meta.SourceIDMetaDataTextBoxColumn(), "PracticeID", "colfldMetaPracticeId", 75, True))
                        .Caption = "Reports"

                    Case DataSources.Sources
                        zTemplate.DataSource = MetaData.Sources
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.SourceIDMetaDataTextBoxColumn, "ID", "colFldId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Schema", "colfldSchemaName", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Name", "colFldObjectName", 300, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Order By", "colFldOrderBy", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Join Field", "colFldJoinFieldName", 150, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Join Req", "colFldIsJoinRequired", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ObjectID", "colFldObjectId", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Type", "colFldType", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ParmFlag", "colFldParameterFlag", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Currency Parm", "colFldHasCurrencyParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Unit Parm", "colFldHasUnitParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "FileNo Parm", "colFldHasFileNoParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "FilePrefix Parm", "colFldHasFilePrefixParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Division Parm", "colFldHasDivisionParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Country Parm", "colFldHasCountryParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Custom Parm", "colFldHasCustomAccessParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Imp Start Parm", "colFldHasImpStartDateParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Lang. Parm", "colFldHasLanguageParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Imp End Parm", "colFldHasImpEndDateParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Insp Yr. Parm", "colFldHasInspProgramYearParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Rec Parm", "colFldHasRecStatusParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Haz. Parm", "colFldHasHazardParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "TIV Parm", "colFldHasTIVParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "TIV Val.Parm", "colFldHasTIVValueParm", 50, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "AutoRequest Parm", "colFldHasAutoRequestParm", 50, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Comment", "colFldComment", 200, False))
                        .Caption = "Sources"

                    Case DataSources.GridColumns
                        zTemplate.DataSource = MetaData.GridColumns
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridColumnIDMetaDataTextBoxColumn(), "ID", "colfldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridColumnIDMetaDataTextBoxColumn(), "Format", "colformat", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Data Type", "colType", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridIDMetaDataTextBoxColumn(), "Grid", "colfldMetaGridId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Title", "colTitle", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Field", "colField", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Width", "colWidth", 75, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Hidden", "colHidden", 75, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Filterable", "colFilterable", 75, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Sortable", "colSortable", 75, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Groupable", "colGroupable", 75, False))
                        .Columns.Add(CreateColumn(New GridViewCheckBoxColumn(), "Locked", "colLocked", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Index Order", "colIndexOrder", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Custom Feature", "colFldCustomFeature", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "CF Alt. Title", "colFldCustomFeatureAltTitle", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Exclude XL", "colFldExcludeFromExtract", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Template", "coltemplate", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "HtmlSnip", "colfldMapTitleHtmlSnippet", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SQLSnip", "colfldMapPinIconSqlSnippet", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Field BackColor", "colFldFieldNameBackColor", 150, False))
                        .Caption = "Columns"

                    Case DataSources.ColumnTemplate
                        zTemplate.DataSource = MetaData.GridColumnTemplates
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ID", "colfldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Template Name", "colFldTemplateName", 150, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Source", "colfldTemplateSource", 500, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Notes", "colfldNotes", 150, False))
                        .Caption = "Column Templates"

                    Case DataSources.Charts
                        zTemplate.DataSource = MetaData.Charts
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.ChartIDMetaDataTextBoxColumn(), "ID", "colfldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.SourceIDMetaDataTextBoxColumn, "Source", "colfldSourceID", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Name", "colfldChartName", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Title Page", "colfldTitlePage", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Page Sub Title", "colfldTitlePageSub", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Chart Title", "colfldTitleChart", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Value Axis", "colfldTitleValueAxis", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Legend", "colfldLegendTemplate", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Notes", "colfldNotes", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Summary Mode", "colfldSummaryMode", 75, False))
                        .Columns.Add(CreateColumn(New Meta.ReportIDMetaDataTextBoxColumn(), "Report ID", "colfldReportID", 75, False))
                        .Caption = "Charts"

                    Case DataSources.ChartSeries
                        zTemplate.DataSource = MetaData.ChartSeries
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ID", "colfldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Chart ID", "colfldMetaChartID", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Name", "colName", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Type", "colType", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Field", "colfield", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Cat. Field", "colcategoryfield", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Color Field", "colcolorfield", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Color", "colcolor", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Notes", "colfldNotes", 100, False))
                        .Caption = "Chart Series"

                    Case DataSources.ChartSeriesDetail
                        zTemplate.DataSource = MetaData.ChartSeriesDetails
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ID", "colfldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Series ID", "colfldMetaChartSeriesID", 75, False))
                        .Columns.Add(CreateColumn(New Meta.DirectDrillDownIDMetaDataTextBoxColumn(), "DrillDownID", "colfldMetaChartDrillDownID", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Index", "colfldIndexOrder", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Field", "colfldField", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Title", "colfldTitle", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Color", "colfldcolor", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Notes", "colfldNotes", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Drill Down", "colfldMetaChartDrillDownTypeId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Include", "colfldInclude", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Spc Feature", "colfldCustomFeature", 100, False))
                        .Caption = "Chart Series Detail"


                    Case DataSources.ProgramStatus
                        zTemplate.DataSource = MetaData.ProgramStatus
                        .Columns.Add(CreateColumn(New Meta.CopyRowCommandButtonColumn(), "", "", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "ID", "colfldId", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SectionName", "colfldSectionName", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "TopName", "colfldTopName", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Name", "colfldMetricName", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "SubName", "colfldSubMetricName", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Value", "colfldMetricValue", 75, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Label", "colfldMetricLabel", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Visible", "colfldMetricVisible", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Color", "colfldMetricColor", 75, False))
                        .Columns.Add(CreateColumn(New Meta.DirectDrillDownIDMetaDataTextBoxColumn(), "DirectID", "colfldDirectID", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Criteria", "colfldCriteria", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Filter", "colfldFilter", 75, False))
                        .Columns.Add(CreateColumn(New Meta.GridIDMetaDataTextBoxColumn, "GridID", "colfldGridID", 100, False))
                        .Columns.Add(CreateColumn(New Meta.MetaDataTextBoxColumn(), "Sort", "colfldSort", 100, False))
                        .Caption = "Program Status"

                End Select
            End With

            Return zTemplate

        End Function

        Public Shared Function CreateColumn(pColumn As GridViewDataColumn, pHeaderText As String, pFieldName As String, pWidth As Integer, pIsRequired As Boolean, Optional pCommandButtonText As String = "", Optional pName As String = "", Optional pVisible As Boolean = True) As GridViewDataColumn
            pColumn.HeaderText = pHeaderText
            pColumn.FieldName = pFieldName
            pColumn.Name = pFieldName
            If pName.Length > 0 Then pColumn.Name = pName
            pColumn.Width = pWidth
            pColumn.StretchVertically = True
            pColumn.WrapText = False
            pColumn.ReadOnly = False
            pColumn.IsVisible = pVisible

            If TypeOf pColumn Is Meta.MetaDataTextBoxColumn Then
                DirectCast(pColumn, Meta.MetaDataTextBoxColumn).IsRequired = pIsRequired
            End If

            If TypeOf pColumn Is GridViewCommandColumn And pCommandButtonText.Length > 0 Then
                DirectCast(pColumn, GridViewCommandColumn).DefaultText = pCommandButtonText
                DirectCast(pColumn, GridViewCommandColumn).UseDefaultText = True
            End If

            Return pColumn
        End Function

        Public Shared Function CreateButtonColumn(pHeaderText As String, pFieldName As String, pWidth As Integer, pCommandButtonText As String) As GridViewCommandColumn
            Dim zCol As New GridViewCommandColumn()
            With zCol
                .HeaderText = pHeaderText
                .FieldName = pFieldName
                .Name = pFieldName
                .Width = pWidth
                .StretchVertically = True
                .WrapText = False
                .DefaultText = pCommandButtonText
                .UseDefaultText = True
            End With
            Return zCol
        End Function

        Public Shared Sub SetupSubTemplate(ByRef pMasterTemplate As MasterGridViewTemplate)

            Dim zRelation As GridViewRelation = Nothing

            Select Case pMasterTemplate.Caption
                Case "Grids"

                    pMasterTemplate.Templates.AddRange({CreateTemplate(DataSources.GridColumns), CreateTemplate(DataSources.NavLinks), CreateTemplate(DataSources.Reports), CreateTemplate(DataSources.Sources)})
                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(0))
                    zRelation.ParentColumnNames.Add("colFldId")
                    zRelation.ChildColumnNames.Add("colFldMetaGridId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)

                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(1))
                    zRelation.ParentColumnNames.Add("colFldId")
                    zRelation.ChildColumnNames.Add("colNavGridId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)

                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(2))
                    zRelation.ParentColumnNames.Add("colFldReportId")
                    zRelation.ChildColumnNames.Add("colFldId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)

                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(3))
                    zRelation.ParentColumnNames.Add("colFldSourceId")
                    zRelation.ChildColumnNames.Add("colFldId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)


                    'Case GridViewTemplatesType.NavLinks
                    '    Me.RadGridView1.DataSource = MetaData.Navlink
                    '    Me.RadGridView1.Templates.AddRange({GetGridViewTemplate(GridViewTemplatesType.Grids), GetGridViewTemplate(GridViewTemplatesType.Reports)})

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(0))
                    '    zRelation.ParentColumnNames.Add("colNavGridId")
                    '    zRelation.ChildColumnNames.Add("colFldId")
                    '    Me.RadGridView1.Relations.Add(zRelation)

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(1))
                    '    zRelation.ParentColumnNames.Add("colNavRptCode")
                    '    zRelation.ChildColumnNames.Add("colfldId")
                    '    Me.RadGridView1.Relations.Add(zRelation)


                    'Case GridViewTemplatesType.Reports

                    '    Me.RadGridView1.DataSource = MetaData.Reports
                    '    Me.RadGridView1.Templates.AddRange({GetGridViewTemplate(GridViewTemplatesType.Sources), GetGridViewTemplate(GridViewTemplatesType.Grids), GetGridViewTemplate(GridViewTemplatesType.NavLinks)})

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(0))
                    '    zRelation.ParentColumnNames.Add("colfldSourceId")
                    '    zRelation.ChildColumnNames.Add("colFldId")
                    '    Me.RadGridView1.Relations.Add(zRelation)

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(1))
                    '    zRelation.ParentColumnNames.Add("colfldId")
                    '    zRelation.ChildColumnNames.Add("colFldReportId")
                    '    Me.RadGridView1.Relations.Add(zRelation)

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(2))
                    '    zRelation.ParentColumnNames.Add("colfldId")
                    '    zRelation.ChildColumnNames.Add("colNavRptCode")
                    '    Me.RadGridView1.Relations.Add(zRelation)


                    'Case GridViewTemplatesType.Sources

                    '    Me.RadGridView1.DataSource = MetaData.Sources
                    '    Me.RadGridView1.Templates.AddRange({GetGridViewTemplate(GridViewTemplatesType.Grids), GetGridViewTemplate(GridViewTemplatesType.Reports), GetGridViewTemplate(GridViewTemplatesType.Charts)})

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(0))
                    '    zRelation.ParentColumnNames.Add("colFldId")
                    '    zRelation.ChildColumnNames.Add("colFldSourceId")
                    '    Me.RadGridView1.Relations.Add(zRelation)

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(1))
                    '    zRelation.ParentColumnNames.Add("colfldId")
                    '    zRelation.ChildColumnNames.Add("colFldSourceId")
                    '    Me.RadGridView1.Relations.Add(zRelation)

                    '    zRelation = New GridViewRelation(Me.RadGridView1.MasterTemplate, Me.RadGridView1.Templates(2))
                    '    zRelation.ParentColumnNames.Add("colfldId")
                    '    zRelation.ChildColumnNames.Add("colFldSourceId")
                    '    Me.RadGridView1.Relations.Add(zRelation)


                    'Case GridViewTemplatesType.GridColumns
                    '    Me.RadGridView1.DataSource = MetaData.GridColumns

                    'Case GridViewTemplatesType.ColumnTemplate
                    '    Me.RadGridView1.DataSource = MetaData.GridColumnTemplates

                Case "Charts"

                    pMasterTemplate.Templates.AddRange({CreateTemplate(DataSources.ChartSeries), CreateTemplate(DataSources.Sources), CreateTemplate(DataSources.Reports)})
                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(0))
                    zRelation.ParentColumnNames.Add("colFldId")
                    zRelation.ChildColumnNames.Add("colFldMetaChartId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)

                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(1))
                    zRelation.ParentColumnNames.Add("colFldSourceId")
                    zRelation.ChildColumnNames.Add("colFldId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)

                    zRelation = New GridViewRelation(pMasterTemplate, pMasterTemplate.Templates(2))
                    zRelation.ParentColumnNames.Add("colFldReportId")
                    zRelation.ChildColumnNames.Add("colFldId")
                    pMasterTemplate.Owner.Relations.Add(zRelation)

                    pMasterTemplate.Templates(0).Templates.Add(CreateTemplate(DataSources.ChartSeriesDetail))
                    zRelation = New GridViewRelation(pMasterTemplate.Templates(0), pMasterTemplate.Templates(0).Templates(0))
                    zRelation.ParentColumnNames.Add("colFldId")
                    zRelation.ChildColumnNames.Add("colFldMetaChartSeriesID")
                    pMasterTemplate.Owner.Relations.Add(zRelation)


            End Select


            '            RadMenuButtonAutoSizeCols_Click(Nothing, Nothing)


            For Each zTemplate As GridViewTemplate In pMasterTemplate.Templates
                zTemplate.HorizontalScrollState = ScrollState.AlwaysShow
            Next

        End Sub




    End Class

End Namespace
