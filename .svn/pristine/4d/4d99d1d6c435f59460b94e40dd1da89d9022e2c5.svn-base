Imports Telerik.WinControls.UI
Imports GRC.Connect.Libraries.DataLib.razor


Public Class ProgramStatusRecordForm
    Implements IUtilityForm

    Public DSGrids As List(Of rowTblMetaGrid)
    Public DSPS As List(Of rowTblMetaProgramStatus)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ProgramStatusRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridStructure(MetaItemType.Grids)
        LoadGridStructure(MetaItemType.ProgramStatus)
        RadTextBoxDirectID.Text = DSPS.Select(Function(x) x.colFldDirectId).ToList.Max + 1
        AutoSizeColumns()
    End Sub

    Public Property SectionName As String
        Get
            Return RadTextBoxSectionName.Text
        End Get
        Set(value As String)
            RadTextBoxSectionName.Text = value
        End Set
    End Property

    Public ReadOnly Property Filter As String
        Get
            Return RadTextBoxFilter.Text
        End Get
    End Property

    Public ReadOnly Property GridID As Integer
        Get
            Return RadTextBoxGridID.Text
        End Get
    End Property

    Public ReadOnly Property DirectID As Integer
        Get
            Return RadTextBoxDirectID.Text
        End Get
    End Property


    Private Sub LoadGridStructure(pMetaItemType As MetaItemType)

        Select Case pMetaItemType

            Case MetaItemType.Grids
                RadGridViewGrids.DataSource = DSGrids
                RadGridViewGrids.MasterTemplate.Columns.Add(CreateTextBoxColumn("ID", "colFldId", True))
                RadGridViewGrids.MasterTemplate.Columns.Add(CreateTextBoxColumn("Name", "colFldGridName"))
                With RadGridViewGrids.MasterTemplate
                    .AutoGenerateColumns = False
                    .EnableFiltering = True
                    .AllowAddNewRow = True
                    .Caption = "Grids"
                End With



            Case MetaItemType.ProgramStatus
                RadGridViewFilters.DataSource = DSPS
                RadGridViewFilters.MasterTemplate.Columns.Add(CreateTextBoxColumn("ID", "colFldId", True))
                RadGridViewFilters.MasterTemplate.Columns.Add(CreateTextBoxColumn("Filter", "colFldFilter"))

                With RadGridViewFilters.MasterTemplate
                    .AutoGenerateColumns = False
                    .EnableFiltering = True
                    .AllowAddNewRow = True
                    .Caption = "ProgramStatus"
                End With

        End Select

    End Sub

    Private Enum MetaItemType
        Grids
        ProgramStatus
    End Enum

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

    Private Sub AutoSizeColumns()
        Dim zGridViewTemplate As MasterGridViewTemplate = Me.RadGridViewGrids.MasterTemplate
        For Each zcol As GridViewColumn In zGridViewTemplate.Columns
            zcol.BestFit()
        Next

        Dim zGridViewTemplate1 As MasterGridViewTemplate = Me.RadGridViewFilters.MasterTemplate
        For Each zcol As GridViewColumn In zGridViewTemplate1.Columns
            zcol.BestFit()
        Next


    End Sub

    Private Sub RadButtonSave_Click(sender As Object, e As EventArgs) Handles RadButtonSave.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub RadButtonCancel_Click(sender As Object, e As EventArgs) Handles RadButtonCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return False
        End Get
    End Property
End Class