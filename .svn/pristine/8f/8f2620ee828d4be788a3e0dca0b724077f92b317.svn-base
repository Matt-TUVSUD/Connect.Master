Imports System.Drawing

Partial Class UtilReporting
    Public Class Chart

        Public Shared ReadOnly Property BlueGradient As System.Drawing.Color()
            Get
                Dim zColors As New List(Of System.Drawing.Color)
                zColors.Add(Color.FromArgb(155, 160, 227))
                zColors.Add(Color.FromArgb(121, 129, 219))
                zColors.Add(Color.FromArgb(87, 97, 210))
                zColors.Add(Color.FromArgb(53, 65, 202))
                zColors.Add(Color.FromArgb(45, 54, 168))
                zColors.Add(Color.FromArgb(36, 44, 134))
                zColors.Add(Color.FromArgb(27, 32, 101))

                Return zColors.ToArray
            End Get
        End Property

        Public Shared ReadOnly Property RedGradient As System.Drawing.Color()
            Get
                Dim zColors As New List(Of System.Drawing.Color)
                zColors.Add(Color.FromArgb(255, 85, 85))
                zColors.Add(Color.FromArgb(255, 43, 43))
                zColors.Add(Color.FromArgb(255, 0, 0))
                zColors.Add(Color.FromArgb(213, 0, 0))
                zColors.Add(Color.FromArgb(170, 0, 0))
                zColors.Add(Color.FromArgb(128, 0, 0))
                Return zColors.ToArray

            End Get
        End Property

        Public Shared ReadOnly Property YellowGradient As System.Drawing.Color()
            Get
                Dim zColors As New List(Of System.Drawing.Color)
                zColors.Add(Color.FromArgb(255, 255, 85))
                zColors.Add(Color.FromArgb(255, 255, 43))
                zColors.Add(Color.FromArgb(255, 255, 0))
                zColors.Add(Color.FromArgb(213, 213, 0))
                zColors.Add(Color.FromArgb(170, 170, 0))
                '  zColors.Add(Color.FromArgb(128, 128, 0))
                Return zColors.ToArray

            End Get
        End Property

        Public Shared ReadOnly Property GreenGradient As System.Drawing.Color()
            Get
                Dim zColors As New List(Of System.Drawing.Color)
                zColors.Add(Color.FromArgb(153, 255, 85))
                zColors.Add(Color.FromArgb(43, 255, 43))
                zColors.Add(Color.FromArgb(0, 255, 0))
                zColors.Add(Color.FromArgb(0, 213, 0))
                zColors.Add(Color.FromArgb(0, 170, 0))
                zColors.Add(Color.FromArgb(0, 128, 0))
                Return zColors.ToArray
            End Get
        End Property

        Public Shared ReadOnly Property PurpleGradient As System.Drawing.Color()
            Get
                Dim zColors As New List(Of System.Drawing.Color)
                zColors.Add(Color.FromArgb(170, 85, 255))
                zColors.Add(Color.FromArgb(149, 43, 255))
                zColors.Add(Color.FromArgb(128, 0, 255))
                zColors.Add(Color.FromArgb(106, 0, 213))
                zColors.Add(Color.FromArgb(85, 0, 170))
                zColors.Add(Color.FromArgb(64, 0, 128))
                Return zColors.ToArray
            End Get
        End Property

        Public Enum ChartColor
            Blue = 1
            Red = 2
            Yellow = 3
            Green = 4
            Purple = 5
        End Enum

        Public Shared Function GetSolidColor(ByVal pColor As ChartColor) As System.Drawing.Color
            Select Case pColor

                Case ChartColor.Blue
                    Return BlueGradient(3)

                Case ChartColor.Red
                    Return RedGradient(3)

                Case ChartColor.Yellow
                    Return YellowGradient(3)

                Case ChartColor.Green
                    Return GreenGradient(3)

                Case ChartColor.Purple
                    Return PurpleGradient(3)

            End Select
        End Function

        Public Shared Function GetFirstColor(ByVal pColor As ChartColor) As System.Drawing.Color
            Select Case pColor

                Case ChartColor.Blue
                    Return BlueGradient(0)

                Case ChartColor.Red
                    Return RedGradient(0)

                Case ChartColor.Yellow
                    Return YellowGradient(0)

                Case ChartColor.Green
                    Return GreenGradient(0)

                Case ChartColor.Purple
                    Return PurpleGradient(0)

            End Select
        End Function

        Public Shared Function GetLastColor(ByVal pColor As ChartColor) As System.Drawing.Color
            Select Case pColor

                Case ChartColor.Blue
                    Return BlueGradient(BlueGradient.Length - 1)

                Case ChartColor.Red
                    Return RedGradient(RedGradient.Length - 1)

                Case ChartColor.Yellow
                    Return YellowGradient(YellowGradient.Length - 1)

                Case ChartColor.Green
                    Return GreenGradient(GreenGradient.Length - 1)

                Case ChartColor.Purple
                    Return PurpleGradient(PurpleGradient.Length - 1)

            End Select
        End Function


        Public Shared Function ColorOrder(ByVal pChartColors() As ChartColor)
            Dim zArray(pChartColors.Count - 1)
            Dim zIdx As Integer = 0
            For Each pColor As ChartColor In pChartColors
                zArray(zIdx) = pColor
                zIdx += 1
            Next
            Return zArray
        End Function



        'Public Shared Function IncreaseColor(ByVal pStartingColor As System.Drawing.Color) As List(Of System.Drawing.Color)
        '     Dim zR As Integer = pStartingColor.R
        '     Dim zG As Integer = pStartingColor.G
        '     Dim zB As Integer = pStartingColor.B
        '     Dim zList As New List(Of System.Drawing.Color)
        '     Dim zIdx As Integer = 0
        '     Dim zPcnt As Single = 0.15
        '     zList.Add(pStartingColor)

        '     Do Until zIdx = 8

        '          If zR = 0 Then zR = 1
        '          If zG = 0 Then zG = 1
        '          If zB = 0 Then zB = 1

        '          zR = zR + (zR * zPcnt)
        '          zG = zG + (zG * zPcnt)
        '          zB = zB + (zB * zPcnt)

        '          If zR > 255 Then zR = 255
        '          If zG > 255 Then zG = 255
        '          If zB > 255 Then zB = 255

        '          zList.Add(System.Drawing.Color.FromArgb(zR, zG, zB))
        '          zIdx = zIdx + 1

        '     Loop

        '     Return zList
        'End Function




        'Public Shared Function CreateGradient(ByVal pStartColor As System.Drawing.Color)
        '     Dim zBrush As New System.Drawing.Drawing2D.LinearGradientBrush(New System.Drawing.Point(0), New System.Drawing.Point(1.0), pStartColor, Color.White)
        '     Dim zColor As System.Drawing.Color() = {pStartColor, System.Drawing.Color.White}
        '     Dim zPosition As Single() = {0.0, 1.0}
        '     zBrush.InterpolationColors.Colors = zColor
        '     zBrush.InterpolationColors.Positions = zPosition
        '     Dim zBlend As New System.Drawing.Drawing2D.ColorBlend
        '     zBlend.Colors
        '     Return Nothing
        'End Function


    End Class
End Class
