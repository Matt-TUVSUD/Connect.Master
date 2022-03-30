

Public Class UtilLossEstimates


    Public Shared Sub FormatRow(ByRef pRow As Object)

        Throw New Exception("This function has been altered so application can compile.  Uncomment below code and fix with non IG")

    End Sub

    'Public Shared Sub FormatRow(ByRef pRow As Infragistics.WebUI.UltraWebGrid.UltraGridRow)

    '    Dim zIsReportingPercentage As Boolean = False
    '    Dim zBIColumnValue As String = ""
    '    Dim zBIColumn As Infragistics.WebUI.UltraWebGrid.UltraGridColumn = Nothing

    '    For Each zCell As Infragistics.WebUI.UltraWebGrid.UltraGridCell In pRow.Cells
    '        If zCell.Column.BaseColumnName.ToLower = "bireporting" Then
    '            zBIColumn = zCell.Column
    '        End If
    '    Next

    '    zBIColumnValue = pRow.GetCellValue(zBIColumn)

    '    If zBIColumnValue.ToLower = "percentage" Then
    '        For Each zCell As Infragistics.WebUI.UltraWebGrid.UltraGridCell In pRow.Cells
    '            If (zCell.Column.BaseColumnName.ToUpper.StartsWith("TIV") Or
    '                zCell.Column.BaseColumnName.ToUpper.StartsWith("APL") Or
    '                zCell.Column.BaseColumnName.ToUpper.StartsWith("MFL") Or
    '                zCell.Column.BaseColumnName.ToUpper.StartsWith("PML")) And
    '                (Not zCell.Column.BaseColumnName.ToUpper.Contains("PERCENT")) Then
    '                If IsNothing(zCell.Value) Then zCell.Value = 0 : zCell.Text = "N/A"
    '            End If
    '        Next
    '    End If

    'End Sub

    Public Shared Function WriteText(pList As List(Of LossEstimateValidationResult)) As LossEstimateValidation
        Dim zLineText As String = ""
        Dim zSBHtml As New StringBuilder
        Dim zSBText As New StringBuilder
        Dim zUseAlternateBackground As Boolean = True
        Dim zCurrentFileNo As String = ""

        zSBHtml.Append("<html><body><table style='font-size: smaller; font-family:arial;padding:4px; border:1px solid black; border-collapse:collapse;'>")
        zSBHtml.Append("<tr>")
        zSBHtml.Append("<th style='border:1px solid black;'>Client</th>")
        zSBHtml.Append("<th style='border:1px solid black;'>FileNo</th>")
        zSBHtml.Append("<th style='border:1px solid black;'>BIReporting</th>")
        zSBHtml.Append("<th style='border:1px solid black;'>SurveyDate</th>")
        zSBHtml.Append("<th style='border:1px solid black;'>RecordID</th>")
        zSBHtml.Append("<th style='border:1px solid black;'>Message</th>")
        zSBHtml.Append("<th style='border:1px solid black;'>Group</th>")
        zSBHtml.Append("</tr>")

        For Each zResult As LossEstimateValidationResult In pList
            If zResult.Data.FileNo <> zCurrentFileNo Then zCurrentFileNo = zResult.Data.FileNo : zUseAlternateBackground = Not zUseAlternateBackground

            If zUseAlternateBackground Then
                zSBHtml.Append("<tr>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.Client.Clientname & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.Data.FileNo & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.Data.BIReporting & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.Data.SurveyDate & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.Data.Id & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.Message & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;padding:4px;'>" & zResult.MessageGroup & "</td>")
                zSBHtml.Append("</tr>")
            Else
                zSBHtml.Append("<tr>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.Client.Clientname & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.Data.FileNo & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.Data.BIReporting & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.Data.SurveyDate & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.Data.Id & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.Message & "</td>")
                zSBHtml.Append("<td style='border:1px solid black;background-color:#B4E6FF;padding:4px;'>" & zResult.MessageGroup & "</td>")
                zSBHtml.Append("</tr>")
            End If

            Dim zClient As Object = Left(IIf(IsNothing(zResult.Data.GetClient.Clientname), "NULL", zResult.Data.GetClient.Clientname), 25)
            Dim zFileNo As Object = IIf(IsNothing(zResult.Data.FileNo), "NULL", zResult.Data.FileNo)
            Dim zBiReporting As Object = IIf(IsNothing(zResult.Data.BIReporting), "NULL", zResult.Data.BIReporting)
            Dim zSurveyDate As Object
            Dim zId As Object = IIf(IsNothing(zResult.Data.Id), "NULL", zResult.Data.Id)
            Dim zMessage As Object = IIf(IsNothing(zResult.Message), "NULL", zResult.Message)

            If IsNothing(zResult.Data.SurveyDate) Then zSurveyDate = "NULL" Else zSurveyDate = FormatDateTime(zResult.Data.SurveyDate, DateFormat.ShortDate)

            zLineText = "Client: " & zClient.PadRight(30) & "FileNo: " & zFileNo.PadRight(15) & "BIReporting: " & zBiReporting.PadRight(12) & "Survey Date: " & zSurveyDate.ToString.PadRight(20) & "ID: " & zId.ToString.PadRight(8) & "Message: " & zMessage
            Diagnostics.Trace.WriteLine(zLineText)
            zSBText.AppendLine(zLineText)
        Next

        zSBText.Append("</table></body></html>")

        Dim zVal As New LossEstimateValidation(zSBHtml.ToString, zSBText.ToString)
        Return zVal

    End Function

    Public Enum LossTypeField
        APLPD = 1
        APLBI
        APLTOTAL

        PMLPD
        PMLBI
        PMLTOTAL

        MFLPD
        MFLBI
        MFLTOTAL

        TIVPD
        TIVBI
        TIVTOTAL

    End Enum
End Class
