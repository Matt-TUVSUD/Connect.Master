'Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports
Imports Telerik.Reporting
Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilReport
    Public Class ActiveReport

        Public Shared Function FindControl(rpt As SectionReport, controlId As String) As SectionReportModel.ARControl
            For Each zSec As SectionReportModel.Section In rpt.Sections
                For Each zCtrl As SectionReportModel.ARControl In zSec.Controls
                    If zCtrl.Name.ToLower = controlId.ToLower Then
                        Return zCtrl
                    End If
                Next
            Next
            Return Nothing
        End Function

        Public Shared Sub SetFilter(rpt As SectionReport, rptProps As IBatchSetReportProperties)

            Dim zMyFilterLabel As SectionReportModel.Label = FindControl(rpt, "lblmyPreference")
            Dim zMyFilterTextBox As SectionReportModel.TextBox = FindControl(rpt, "txtmyPreference")
            Dim zFilterLabel As SectionReportModel.Label = FindControl(rpt, "lblFilters")
            Dim zFilterTextBox As SectionReportModel.TextBox = FindControl(rpt, "txtFilters")

            If Not IsNothing(zFilterLabel) And Not IsNothing(zFilterTextBox) Then
                If rptProps.FilterString = "" Then
                    zFilterLabel.Visible = False
                    zFilterTextBox.Visible = False
                Else
                    zFilterLabel.Visible = True
                    zFilterTextBox.Visible = True
                    zFilterTextBox.Text = rptProps.FilterString
                End If
            End If

            If Not IsNothing(zMyFilterLabel) And Not IsNothing(rptProps.MyFilterString) Then
                If rptProps.MyFilterString = "" Then
                    zMyFilterLabel.Visible = False
                    zMyFilterTextBox.Visible = False
                Else
                    zMyFilterLabel.Visible = True
                    zMyFilterTextBox.Visible = True
                    zMyFilterTextBox.Text = rptProps.MyFilterString
                End If
            End If

        End Sub

        Public Shared Sub SetSort(rpt As SectionReport, rptProps As IBatchSetReportProperties)
            Dim zSortControl As SectionReportModel.ARControl = FindControl(rpt, "txtSort")
            If TypeOf zSortControl Is SectionReportModel.TextBox Then
                Dim zSortTextBox As SectionReportModel.TextBox = zSortControl
                If Not IsNothing(zSortTextBox) Then
                    If rptProps.SortString = "" Then
                        zSortTextBox.Visible = False
                    Else
                        zSortTextBox.Visible = True
                        zSortTextBox.Text = rptProps.SortString
                    End If
                End If
            Else
                Dim zSortLabel As SectionReportModel.Label = zSortControl
                If Not IsNothing(zSortLabel) Then
                    If rptProps.SortString = "" Then
                        zSortLabel.Visible = False
                    Else
                        zSortLabel.Visible = True
                        zSortLabel.Text = rptProps.SortString
                    End If
                End If
            End If
        End Sub

        Public Shared Sub SetDisclaimer(rpt As SectionReport, rptProps As IBatchSetReportProperties)
            Dim zDisclaimerControl As SectionReportModel.ARControl = FindControl(rpt, "txtDisclaimer")
            If TypeOf zDisclaimerControl Is SectionReportModel.TextBox Then
                Dim zDisclaimerTextBox As SectionReportModel.TextBox = zDisclaimerControl
                If Not IsNothing(zDisclaimerTextBox) Then
                    If rptProps.Disclaimer = "" Then
                        zDisclaimerTextBox.Visible = False
                    Else
                        zDisclaimerTextBox.Visible = True
                        zDisclaimerTextBox.Text = rptProps.Disclaimer
                    End If
                End If
            Else
                Dim zDisclaimerLabel As SectionReportModel.Label = zDisclaimerControl
                If Not IsNothing(zDisclaimerLabel) Then
                    If rptProps.Disclaimer = "" Then
                        zDisclaimerLabel.Visible = False
                    Else
                        zDisclaimerLabel.Visible = True
                        zDisclaimerLabel.Text = rptProps.Disclaimer
                    End If
                End If
            End If
        End Sub


        ''' <summary>
        ''' Use function when values are text related (ex: "inadequate", "severe", "poorer risk", "high")
        ''' </summary>
        ''' <param name="rpt"></param>
        ''' <param name="controls"></param>
        ''' <param name="rptProps"></param>
        ''' <remarks></remarks>
        Public Shared Sub SetItemBackColorByText(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(zLabel.DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByText(rptProps, IIf(IsDBNull(zDataField.Value), "", zDataField.Value))
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(zTextBox.DataField)
                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByText(rptProps, IIf(IsDBNull(zDataField.Value), "", zDataField.Value))
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                     End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' Sets the backcolor for exposure zone items (ex: Light, Moderate, Severe, etc)
        ''' </summary>
        ''' <param name="rpt">Active Report</param>
        ''' <param name="controls">The controls to set the backcolor on</param>
        ''' <param name="valueControls">The controls whose values should determine the backcolor</param>
        ''' <param name="rptProps">Report properties</param>
        ''' <remarks></remarks>
        ''' 
        Public Shared Sub SetItemBackColorByText(rpt As SectionReport, controls() As SectionReportModel.ARControl, valueControls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(valueControls(Array.IndexOf(controls, zARControl)).DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByText(rptProps, zDataField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(valueControls(Array.IndexOf(controls, zARControl)).DataField)
                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByText(rptProps, zDataField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                     End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' Sets the backcolor for Fire Cleaning Electrical items (ex: Yes, No, N/A)
        ''' </summary>
        ''' <param name="rpt">Active Report</param>
        ''' <param name="controls">The controls to set the backcolor on</param>
        ''' <param name="commentControls">The controls whose values should determine the backcolor</param>
        ''' <param name="rptProps">Report properties</param>
        ''' <remarks></remarks>
        ''' 
        Public Shared Sub SetItemBackColorByTextAndComment(rpt As SectionReport, controls() As SectionReportModel.ARControl, commentControls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    Dim zCommentField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(controls(Array.IndexOf(controls, zARControl)).DataField)
                        zCommentField = rpt.AllFields(commentControls(Array.IndexOf(controls, zARControl)).DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByTextAndComment(rptProps, zDataField.Value, zCommentField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(controls(Array.IndexOf(controls, zARControl)).DataField)
                        zCommentField = rpt.AllFields(commentControls(Array.IndexOf(controls, zARControl)).DataField)

                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByTextAndComment(rptProps, zDataField.Value, zCommentField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                    End If
                End If
            Next
        End Sub

        ' ''' <summary>
        ' ''' Use this function when the values are rating and literal strings are "Typical Risk, Better Risk, etc"
        ' ''' </summary>
        ' ''' <param name="rpt"></param>
        ' ''' <param name="controls"></param>
        ' ''' <param name="rptProps"></param>
        ' ''' <remarks></remarks>
        'Public Shared Sub SetItemBackColorByRiskRating(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
        '    For Each zARControl As SectionReportModel.ARControl In controls
        '        If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
        '            Dim zDataField As Data.Field = Nothing
        '            If TypeOf zARControl Is SectionReportModel.Label Then
        '                Dim zLabel As SectionReportModel.Label = zARControl
        '                zDataField = rpt.AllFields(zLabel.DataField)
        '                Try
        '                    zLabel.BackColor = UtilReport.Color.GetColorByRiskRating(rptProps, IIf(IsDBNull(zDataField.Value), "", zDataField.Value))
        '                Catch ex As Exception
        '                    zLabel.BackColor = System.Drawing.Color.Transparent
        '                End Try
        '            Else
        '                Dim zTextBox As SectionReportModel.TextBox = zARControl
        '                zDataField = rpt.AllFields(zTextBox.DataField)
        '                If Not IsDBNull(zDataField.Value) Then
        '                    Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
        '                        zTextBox.BackColor = UtilReport.Color.GetColorByRiskRating(rptProps, IIf(IsDBNull(zDataField.Value), "", zDataField.Value))
        '                    Catch ex As Exception
        '                        zTextBox.BackColor = System.Drawing.Color.Transparent
        '                    End Try
        '                End If
        '            End If
        '        End If
        '    Next
        'End Sub

        ' ''' <summary>
        ' ''' Sets the backcolor for rating items (ex: Better Risk, Typical Risk, etc)
        ' ''' </summary>
        ' ''' <param name="rpt">Active Report</param>
        ' ''' <param name="controls">The controls to set the backcolor on</param>
        ' ''' <param name="valueControls">The controls whose values should determine the backcolor</param>
        ' ''' <param name="rptProps">Report properties</param>
        ' ''' <remarks></remarks>
        ' ''' 
        'Public Shared Sub SetItemBackColorByRiskRating(rpt As SectionReport, controls() As SectionReportModel.ARControl, valueControls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
        '    For Each zARControl As SectionReportModel.ARControl In controls
        '        If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
        '            Dim zDataField As Data.Field = Nothing
        '            If TypeOf zARControl Is SectionReportModel.Label Then
        '                Dim zLabel As SectionReportModel.Label = zARControl
        '                zDataField = rpt.AllFields(valueControls(Array.IndexOf(controls, zARControl)).DataField)
        '                Try
        '                    zLabel.BackColor = UtilReport.Color.GetColorByRiskRating(rptProps, zDataField.Value)
        '                Catch ex As Exception
        '                    zLabel.BackColor = System.Drawing.Color.Transparent
        '                End Try
        '            Else
        '                Dim zTextBox As SectionReportModel.TextBox = zARControl
        '                zDataField = rpt.AllFields(valueControls(Array.IndexOf(controls, zARControl)).DataField)
        '                If Not IsDBNull(zDataField.Value) Then
        '                    Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
        '                        zTextBox.BackColor = UtilReport.Color.GetColorByRiskRating(rptProps, zDataField.Value)
        '                    Catch ex As Exception
        '                        zTextBox.BackColor = System.Drawing.Color.Transparent
        '                    End Try
        '                End If
        '            End If
        '        End If
        '    Next
        'End Sub


        ''' <summary>
        ''' Use this function when for rating scores such as numeric values 50-100
        ''' </summary>
        ''' <param name="rpt"></param>
        ''' <param name="controls"></param>
        ''' <param name="rptProps"></param>
        ''' <remarks></remarks>
        Public Shared Sub SetItemBackColorByRiskRatingScore(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(zLabel.DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByRiskScore(rptProps, zDataField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(zTextBox.DataField)
                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByRiskScore(rptProps, zDataField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                    End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' Use this function when the values are ratings and are 1-10.
        ''' </summary>
        ''' <param name="rpt"></param>
        ''' <param name="controls"></param>
        ''' <param name="rptProps"></param>
        ''' <remarks></remarks>
        Public Shared Sub SetItemBackColorByRating(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            Dim zRatingCategory As TblMetaRatingCategory.Categories = Nothing
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zRatingCategory = [Enum].Parse(GetType(TblMetaRatingCategory.Categories), zARControl.Tag)
                        zDataField = rpt.AllFields(zLabel.DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByRating(rptProps, zRatingCategory, zDataField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(zTextBox.DataField)
                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zRatingCategory = [Enum].Parse(GetType(TblMetaRatingCategory.Categories), zARControl.Tag)
                                zTextBox.BackColor = UtilReport.Color.GetColorByRating(rptProps, zRatingCategory, zDataField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                    End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' Use this function when the values are Human Element ratings and are 1-10.
        ''' </summary>
        ''' <param name="rpt"></param>
        ''' <param name="controls"></param>
        ''' <param name="rptProps"></param>
        ''' <remarks></remarks>
        Public Shared Sub SetItemBackColorByRatingHE(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(zLabel.DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByRating(rptProps, zDataField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(zTextBox.DataField)
                        If Not IsDBNull(zDataField.Value) Then '
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByRating(rptProps, zDataField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                    End If
                End If
            Next
        End Sub
        ''' <summary>
        ''' Use this function when the values are exposure related and either "Yes", "No" or "N/A"
        ''' </summary>
        ''' <param name="rpt"></param>
        ''' <param name="controls"></param>
        ''' <param name="rptProps"></param>
        ''' <remarks></remarks>
        Public Shared Sub SetItemBackColorByExposure(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(zLabel.DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByExposure(rptProps, zDataField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(zTextBox.DataField)
                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByExposure(rptProps, zDataField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                    End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' Use this function when the values are currency.
        ''' </summary>
        ''' <param name="rpt"></param>
        ''' <param name="controls"></param>
        ''' <param name="rptProps"></param>
        ''' <remarks></remarks>
        Public Shared Sub SetItemBackColorByCurrency(rpt As SectionReport, controls() As SectionReportModel.ARControl, rptProps As IBatchSetReportProperties)
            For Each zARControl As SectionReportModel.ARControl In controls
                If TypeOf zARControl Is SectionReportModel.Label Or TypeOf zARControl Is SectionReportModel.TextBox Then
                    Dim zDataField As Data.Field = Nothing
                    If TypeOf zARControl Is SectionReportModel.Label Then
                        Dim zLabel As SectionReportModel.Label = zARControl
                        zDataField = rpt.AllFields(zLabel.DataField)
                        Try
                            zLabel.BackColor = UtilReport.Color.GetColorByCurrency(rptProps, zDataField.Value)
                        Catch ex As Exception
                            zLabel.BackColor = System.Drawing.Color.Transparent
                        End Try
                    Else
                        Dim zTextBox As SectionReportModel.TextBox = zARControl
                        zDataField = rpt.AllFields(zTextBox.DataField)
                        If Not IsDBNull(zDataField.Value) Then
                            Try     'IF AN EXCEPTON IS THROWN MAKE BACKCOLOR TRANSPARENT.  USUALLY WHEN VALUE IS NOTHING
                                zTextBox.BackColor = UtilReport.Color.GetColorByCurrency(rptProps, zDataField.Value)
                            Catch ex As Exception
                                zTextBox.BackColor = System.Drawing.Color.Transparent
                            End Try
                        End If
                    End If
                End If
            Next
        End Sub

    End Class

End Class
