Public Class ImpairmentCheckBox
    Inherits Telerik.Reporting.CheckBox
    Implements IImpairmentControl

    Private _DictID As Integer
    Private _Value2 As String = ""
    Private _Value2Position As IImpairmentControl.Position
    Private _IsLabel As Boolean = False
    Private _AppendColon As Boolean = True
    Private _PunctionationAction As IImpairmentControl.PunctuationAction = IImpairmentControl.PunctuationAction.Keep

    Public Sub New()
        Me.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7, Telerik.Reporting.Drawing.UnitType.Point)
        Me.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(2.0)

    End Sub

    Public Property DictID As Integer Implements IImpairmentControl.DictID
        Get
            Return _DictID
        End Get
        Set(value As Integer)
            _DictID = value
        End Set
    End Property

    Public Property Value2 As String Implements IImpairmentControl.Value2
        Get
            Return _Value2
        End Get
        Set(value As String)
            _Value2 = value
        End Set
    End Property

    Public Property Value2Position As IImpairmentControl.Position Implements IImpairmentControl.Value2Position
        Get
            Return _Value2Position
        End Get
        Set(value As IImpairmentControl.Position)
            _Value2Position = value
        End Set
    End Property

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpairmentCheckBox))
        '
        'ImpairmentCheckBox
        ''
        Me.CheckedImage = CType(resources.GetObject("$this.CheckedImage"), Object)
        Me.IndeterminateImage = CType(resources.GetObject("$this.IndeterminateImage"), Object)
        Me.UncheckedImage = CType(resources.GetObject("$this.UncheckedImage"), Object)

    End Sub

    Public Property DictLeadPunctuationAction As IImpairmentControl.PunctuationAction Implements IImpairmentControl.DictLeadPunctuationAction
        Get
            Return _PunctionationAction
        End Get
        Set(value As IImpairmentControl.PunctuationAction)
            _PunctionationAction = value
        End Set
    End Property
End Class
