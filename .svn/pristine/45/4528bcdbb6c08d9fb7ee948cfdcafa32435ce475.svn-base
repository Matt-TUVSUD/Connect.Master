Public Class ImpairmentTextBox
    Inherits Telerik.Reporting.TextBox
    Implements IImpairmentControl

    Private _DictId As Integer
    Private _Value2 As String = ""
    Private _Value2Position As IImpairmentControl.Position = IImpairmentControl.Position.Before
    Private _AppendColon As Boolean = True
    Private _IsLabel As Boolean = False
    Private _PunctionationAction As IImpairmentControl.PunctuationAction = IImpairmentControl.PunctuationAction.Keep

    Public Sub New()
        Me.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7, Telerik.Reporting.Drawing.UnitType.Point)
        Me.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(2.0, Telerik.Reporting.Drawing.UnitType.Pixel)
    End Sub

    Public Property DictID As Integer Implements IImpairmentControl.DictID
        Get
            Return _DictId
        End Get
        Set(value As Integer)
            _DictId = value
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

    Public Property DictLeadPunctuationAction As IImpairmentControl.PunctuationAction Implements IImpairmentControl.DictLeadPunctuationAction
        Get
            Return _PunctionationAction
        End Get
        Set(value As IImpairmentControl.PunctuationAction)
            _PunctionationAction = value
        End Set
    End Property
End Class
