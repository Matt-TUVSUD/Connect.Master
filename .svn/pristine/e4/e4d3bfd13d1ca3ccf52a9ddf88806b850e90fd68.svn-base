Imports GRC.Connect.Libraries.DataLib.razor

Public Class TemplateVariables

    Public Location As New rowVwAllLocations
    Public RecipientFullName As String
    Public FollowUpDays As Integer
    Public ReturnLink As String
    Public Practice As TblMetaPractice.Practices
    Public ClientName As String

    Private _DateStamp As Date
    Private _InspectionDate As Date
    Private _Parent As UtilAutoRec.Template

    Friend Sub New(pTemplate As UtilAutoRec.Template)
        _Parent = pTemplate
    End Sub

    Public Function GetMonth() As String
        Return Format(Now(), "MMMM")
    End Function

    Public Function GetDateStamp(ByVal pFormat As DateFormat) As String
        If pFormat = DateFormat.Long Then
            Return Format(_DateStamp, "MMMM d, yyyy")
        Else
            Return Format(_DateStamp, "dd-MMM-yy")
        End If
    End Function

    Public Function GetLocationStamp() As String
        Dim zHtmlBuilder As New Text.StringBuilder

        With zHtmlBuilder
            .Append("<table class='myTable'>")
            .Append("<tr><td width:100><strong>GRC Loc. No.:</strong></td><td>" & Location.colFileNo & "&nbsp; &nbsp; </td><td><b>Division:&nbsp;</b></td><td width='60%'>" & Location.colDivision & "</td></tr>")
            .Append("<tr><td><strong>Client Loc. ID:</strong></td><td>" & Location.colClientLocNo & "&nbsp; &nbsp; </td><td><b>Facility:&nbsp;</b></td><td>" & Location.colFacility & "</td></tr>")
            .Append("<tr><td><strong>Address:</strong></td><td colspan='3'>" & Location.colAddress1 & ", " & Location.colCity & ", " & IIf(Location.colStProv <> "", Location.colStProv & ", " & Location.colCountry, Location.colCountry) & "</td></tr>")
            .Append("</table>")
        End With

        Return zHtmlBuilder.ToString
    End Function

    Public Function GetPracticeName() As String

        ''ADJUSTED CODE TO GET FROM TABLE -DB 05/17/18
        Dim zPractice As rowTblMetaPractice = Nothing
        If AutoRecData.MetaPracticesDict.TryGetValue(CInt(Practice), zPractice) Then
            Return zPractice.colFldReportDisplayTitle
        Else
            Return ""
        End If

        'Select Case Practice
        '    Case TblMetaPractice.Practices.BM
        '        Return "B&M"
        '    Case TblMetaPractice.Practices.Fire
        '        Return "Fire"
        '    Case TblMetaPractice.Practices.Infrared
        '        Return "Infrared"
        '    Case TblMetaPractice.Practices.NaturalHazards
        '        Return "Natural Hazard"
        '    Case TblMetaPractice.Practices.ProcessSafety

        '    Case Else
        '        Return ""
        'End Select

    End Function

    Public Function GetInspectionDate(ByVal pFormat As DateFormat) As String
        If pFormat = DateFormat.Long Then
            Return Format(_InspectionDate, "MMMM d, yyyy")
        Else
            Return Format(_InspectionDate, "dd-MMM-yy")
        End If

    End Function

    Public WriteOnly Property InspectionDate As Date
        Set(value As Date)
            _InspectionDate = value
        End Set
    End Property

    Public WriteOnly Property DateStamp As Date
        Set(value As Date)
            _DateStamp = value
        End Set
    End Property

    Public ReadOnly Property Placeholders() As Dictionary(Of String, Object)
        Get
            Dim zD As New Dictionary(Of String, Object)(StringComparer.OrdinalIgnoreCase)
            With zD
                .Add("%C%", GetLocationStamp)
                .Add("%U%", Me.RecipientFullName)
                .Add("%SD%", Me.GetInspectionDate(DateFormat.Long))
                .Add("%DS%", Me.GetDateStamp(DateFormat.Long))
                .Add("%F1%", Me.FollowUpDays)
                .Add("%LD%", Me.FollowUpDays)
                .Add("%D%", Me.FollowUpDays)
                .Add("%L%", Me.ReturnLink)
                .Add("%M%", Me.GetMonth)
                .Add("%P%", Me.GetPracticeName)
                .Add("{ClientName}", Me.ClientName)
                .Add("{FollowUpDays}", Me.FollowUpDays)
                .Add("{PracticeName}", Me.GetPracticeName)
                .Add("{StatusDate}", Me.GetInspectionDate(DateFormat.Medium))
                .Add("{InspectionDate}", Me.GetInspectionDate(DateFormat.Medium))
                .Add("{Month}", Me.GetMonth)
                .Add("{FileNo}", Me.Location.colFileNo)
                .Add("{ClientLocNo}", IIf(String.IsNullOrEmpty(Me.Location.colClientLocNo), "", Me.Location.colClientLocNo & ", "))
                .Add("{StProv}", IIf(String.IsNullOrEmpty(Me.Location.colStProv), "", Me.Location.colStProv & ", "))
                .Add("{Country}", IIf(String.IsNullOrEmpty(Me.Location.colCountry), "", Me.Location.colCountry))
                .Add("{City}", IIf(String.IsNullOrEmpty(Me.Location.colCity), "", Me.Location.colCity & ", "))
                .Add("{Facility}", IIf(String.IsNullOrEmpty(Me.Location.colFacility), "", Me.Location.colFacility & ", "))
            End With

            Return zD

        End Get
    End Property

    Public Enum DateFormat
        [Long] = 1
        Medium
    End Enum

End Class
