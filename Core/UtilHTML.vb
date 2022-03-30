
Public Class UtilHTML

    Public Shared Function CreateLink(ByVal pText As String, ByVal pURL As String) As String
        Dim zReturn As String = ""
        zReturn = zReturn & "<a href='" & pURL & "'>"
        zReturn = zReturn & pText
        zReturn = zReturn & "</a>"
        Return zReturn

    End Function

    Public Shared Function CreateCrumbtrailLink(ByVal pText As String, ByVal pURL As String) As String
        Dim zReturn As String = ""
        zReturn = zReturn & "<a href='" & pURL & "'>"
        zReturn = zReturn & pText
        zReturn = zReturn & "</a> &gt;"
        Return zReturn

    End Function

    ''' <summary>
    ''' This function creates the AutoRec location details at the top of the email in HTML.
    ''' </summary>
    ''' <param name="pFileNo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateAutoRecLocationStamp(ByVal pFileNo As String) As String
        Dim zGrpsCol As New BusinessObjects.GRIPSSWorkloadCollection
        Dim zGrpsQry As New BusinessObjects.GRIPSSWorkloadQuery
        zGrpsQry.SelectAll().es.Top = 1
        zGrpsQry.Where(zGrpsQry.FileNo = pFileNo)

        Dim zHtmlBuilder As New StringBuilder
        If zGrpsCol.Load(zGrpsQry) Then
            With zHtmlBuilder
                .Append("<table class='myTable'>")
                .Append("<tr><td nowrap><b>GRC Loc. No.:</b></td><td>" & zGrpsCol(0).FileNo & "&nbsp; &nbsp; </td><td><b>Division:&nbsp;</b></td><td width='60%'>" & zGrpsCol(0).Division & "</td></tr>")
                .Append("<tr><td nowrap><b>Client Loc. ID:&nbsp;</b></td><td>" & zGrpsCol(0).ClientLocNo & "&nbsp; &nbsp; </td><td><b>Facility:&nbsp;</b></td><td>" & zGrpsCol(0).Facility & "</td></tr>")
                .Append("<tr><td colspan='4'><b>Address:&nbsp;</b>" & zGrpsCol(0).Address1 & ", " & zGrpsCol(0).City & ", " & IIf(zGrpsCol(0).StProv <> "", zGrpsCol(0).StProv & ", " & zGrpsCol(0).Country, zGrpsCol(0).Country) & "</td></tr>")
                .Append("</table>")
            End With
            Return zHtmlBuilder.ToString
        Else
            Return ""
        End If

    End Function

    ''' <summary>
    ''' This function creates a alert span tag at the top of the AutoRec email in HTML.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateAutoRecNoSendAdminText(ByVal pRRID As Integer, ByVal pReason As String, Optional ByVal pException As Exception = Nothing) As String

        Dim zHtmlBuilder As New StringBuilder
        With zHtmlBuilder
            .Append("<span style='color:red; font-weight:900; font-size:14pt;'>*** NOTE:  This Email was NOT sent to the client. Reason: " & pReason & " Please refer to record ID " & pRRID & " in the RRLogArchive table.</span><br/><br/>")
            If Not IsNothing(pException) Then
                .Append("<span style='font-size:small; fore-color:black;'>" & Libraries.CoreLib.UtilException.ExtractExceptionDataHTML(pException, True) & "</span>")
            End If
        End With
        Return zHtmlBuilder.ToString


    End Function

    Public Shared Function FormatAutoRecEmailTemplate(ByVal pEmailTemplate As String) As String
        Dim zStyle As String = "<style>.myDiv, .myTable{font-family:calibri; font-size:10pt;}</style>"
        Return zStyle & "<div class='myDiv'>" & pEmailTemplate & "</div>"
    End Function



End Class
