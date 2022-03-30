Imports Telerik.WinControls.UI
Imports GRC.Connect.Libraries.DataLib.razor

Public Class MetaUtilityItemSelector
    Implements IUtilityForm

    Public SelectedID As Integer = -1

    Public Overloads Sub Show(pSelector As SelectorItems, pOwner As Windows.Forms.Form)
        LoadGridStructure(pSelector)
        AutoSizeColumns()
        MyBase.ShowDialog()
    End Sub

    Private Function LoadGridStructure(pSelector As SelectorItems)

        Dim zTemplate As New GridViewTemplate

        With zTemplate
            .AutoGenerateColumns = False
            .EnableFiltering = True
            .AllowAddNewRow = True

            Select Case pSelector
                Case SelectorItems.Grids
                    RadGridView1.DataSource = TblMetaGrid.LoadData()
                    Me.Text = "Select Grid"
                    .Columns.Add(CreateCommandColumn("ID", "colFldId"))
                    .Columns.Add(CreateTextBoxColumn("ID", "colFldId", True))
                    .Columns.Add(CreateTextBoxColumn("Name", "colFldGridName"))
                    .Columns.Add(CreateTextBoxColumn("Page Title", "colFldGridPageTitle"))
                    .Caption = "Grids"

                Case SelectorItems.Reports
                    RadGridView1.DataSource = TblMetaReport.LoadData()
                    Me.Text = "Select Report"
                    .Columns.Add(CreateCommandColumn("ID", "colFldId"))
                    .Columns.Add(CreateTextBoxColumn("ID", "colFldId", True))
                    .Columns.Add(CreateTextBoxColumn("Name", "colFldName"))
                    .Columns.Add(CreateTextBoxColumn("Type", "colFldTypeName"))
                    .Caption = "Reports"

                Case SelectorItems.Sources
                    RadGridView1.DataSource = TblMetaSource.LoadData()
                    Me.Text = "Select Source"
                    .Columns.Add(CreateCommandColumn("ID", "colFldId"))
                    .Columns.Add(CreateTextBoxColumn("ID", "colFldId", True))
                    .Columns.Add(CreateTextBoxColumn("Schema", "colFldSchemaName"))
                    .Columns.Add(CreateTextBoxColumn("Name", "colFldObjectName"))
                    .Caption = "Sources"

                Case SelectorItems.Charts
                    RadGridView1.DataSource = TblMetaChart.LoadData()
                    Me.Text = "Select Chart"
                    .Columns.Add(CreateCommandColumn("ID", "colFldId"))
                    .Columns.Add(CreateTextBoxColumn("ID", "colFldId", True))
                    .Columns.Add(CreateTextBoxColumn("Schema", "colFldChartName"))
                    .Caption = "Charts"
            End Select
        End With

        Return zTemplate
    End Function

    Private Function CreateTextBoxColumn(pHeaderText As String, pFieldName As String, Optional pIsDupe As Boolean = False) As GridViewDataColumn
        Dim zColumn As New GridViewTextBoxColumn
        With zColumn
            .HeaderText = pHeaderText
            .FieldName = pFieldName
            .Name = pFieldName
            If pIsDupe Then .Name = pFieldName & "_" & pIsDupe.ToString
            .StretchVertically = True
            .WrapText = False
            .BestFit()
            .ReadOnly = True
        End With
        Return zColumn

    End Function

    Private Function CreateCommandColumn(pHeaderText As String, pFieldName As String) As GridViewDataColumn
        Dim zColumn As New GridViewCommandColumn
        With zColumn
            .HeaderText = pHeaderText
            .FieldName = pFieldName
            .Name = pFieldName
            .StretchVertically = True
            .WrapText = False
            .BestFit()
            .ReadOnly = True
            .DefaultText = "Select"
            .UseDefaultText = True
        End With
        Return zColumn

    End Function

    Public Enum SelectorItems
        Grids = 1
        Sources = 2
        Charts = 3
        Reports = 4
    End Enum

    Private Sub AutoSizeColumns()
        Dim zGridViewTemplate As MasterGridViewTemplate = Me.RadGridView1.MasterTemplate
        For Each zcol As GridViewColumn In zGridViewTemplate.Columns
            zcol.BestFit()
        Next
    End Sub

    Private Sub RadGridView1_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CommandCellClick
        SelectedID = e.Value
        Me.Close()
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return False
        End Get
    End Property
End Class