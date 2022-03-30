Imports GRC.Connect.Libraries.CoreLib

Public Class GaugeDirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zSafeId As String = UtilGSafe.GetId(zSafeGUID) & ""

        'SAID Checker
        'If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecure(UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.SafeGUID), zSafeGUID) Then
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.SafeGUID), zSafeGUID, Me.Page) Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If

        Dim zArea As String = Request.QueryString("p1") & ""
        Dim zFilter As String = Request.QueryString("p2") & ""
        Dim zBase As String = GRC.Connect.Libraries.CoreLib.UtilSystemParms.ReadWebAppBaseURL
        Dim zURL As String = "Home_{{VER}}/Filter/GaugeRedirect.aspx"
        Dim zSidParm As String = "?sid=" & zSafeGUID
        Dim zSendFilter As String = ""
        Dim zParmName As String = "filter"
        Dim zParmName2 As String = ""
        Dim zParmValue2 As String = ""
        Dim zGridId As String = ""
        Dim zCriteriaOperatorParm1 As String = """eq"""
        Dim zCriteriaOperatorParm2 As String = """eq"""
        Dim zCriteriaStart As String = "{""logic"":""and"",""filters"":["
        Dim zCriteriaEnd As String = "]}"
        Dim zCriteriaString As String = ""

        ' SET THE GRID AND FILTER INFORMATION BASED ON THE PRACTICE
        Select Case zArea
            Case "01" 'Fire
                'zGridId = "56"
                zGridId = UtilMeta.GetMetaKey("FireInspectionStatusGrid", 56)
                zParmName = "inspectionstatus"
            Case "02" 'BM
                'zGridId = "55"
                zGridId = UtilMeta.GetMetaKey("BMInspectionStatusGrid", 55)
                zParmName = "inspectionstatus"
            Case "03" 'Infrared
                'zGridId = "57"
                zGridId = UtilMeta.GetMetaKey("IRInspectionStatusGrid", 57)
                zParmName = "InspectionStatus"
            Case "04" 'Juris Objects
                'zGridId = "106"
                zGridId = UtilMeta.GetMetaKey("JurisObjectInventoryGrid", 106)
                zParmName = ""
                zParmValue2 = ""
                zParmName2 = ""
            Case "09" 'Juris Active Objects
                'zGridId = "106"
                zGridId = UtilMeta.GetMetaKey("JurisObjectInventoryGrid", 106)
                zParmName = "Status"
                zParmValue2 = ""
                zParmName2 = ""
            Case "08" 'Juris Violations
                'zGridId = "133"
                zGridId = UtilMeta.GetMetaKey("JurisRecommendationsGrid", 133)
                zParmName = "Violation_Status" '"programstatus" 'Instead of created more core to pass filters to grid. This uses the program status filter parameter.
                zParmValue2 = ""
                zParmName2 = ""
            Case "05" 'Seismic
                'zGridId = "140"
                zGridId = UtilMeta.GetMetaKey("NatHazSeismicInspectionStatusGrid", 140)
                zParmName = "inspectionstatus"
                zParmValue2 = "Seismic"
                zParmName2 = "hazard"
            Case "06" 'Wind
                'zGridId = "141"
                zGridId = UtilMeta.GetMetaKey("NatHazWindInspectionStatusGrid", 141)
                zParmName = "inspectionstatus"
                zParmValue2 = "Wind"
                zParmName2 = "hazard"
            Case "07" 'Flood
                'zGridId = "139"
                zGridId = UtilMeta.GetMetaKey("NatHazFloodInspectionStatusGrid", 139)
                zParmName = "inspectionstatus"
                zParmValue2 = "Flood"
                zParmName2 = "hazard"
            Case "10" 'Diversified Services
                'zGridId = "274"
                zGridId = UtilMeta.GetMetaKey("DivServInspectionStatusGrid", 274)
                zParmName = "inspectionstatus"
            Case "11" 'Natural Hazards
                'zGridId = "282"
                zGridId = UtilMeta.GetMetaKey("NHInspectionStatusGrid", 282)
                zParmName = "inspectionstatus"
            Case "12" 'Process Safety
                'zGridId = "323"
                zGridId = UtilMeta.GetMetaKey("PSInspectionStatusGrid", 323)
                zParmName = "inspectionstatus"
        End Select
        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.currentGridId, zGridId, UtilGSafe.KeyNameGroup.Navigation)

        Select Case zFilter
            Case "01" 'Due
                'zSendFilter = "Due"
                zSendFilter = "1"
                zParmName = "InspDue"
                zCriteriaOperatorParm1 = """eq"""
            Case "02" 'Completed
                zSendFilter = "Completed"
            Case "03" 'Pending
                zSendFilter = "Pending"
            Case "04" 'Objections
                zSendFilter = "Objections"
            Case "05" 'Violations
                zSendFilter = "Open"
            Case "06" 'Cancelled
                zSendFilter = "Cancelled"
            Case "07" 'Active
                zSendFilter = "Active"
        End Select

        ' SAVE THE LARGE OBJECT DATA
        UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filter, Nothing, zGridId)

        If zURL.Length = 0 Then
            zURL = "~/" & zBase & "&gridId=" & zGridId
            Response.Write("No destination grid yet.")
        ElseIf zParmValue2.Length > 0 Then
            zURL = "~/" & zURL & zSidParm & "&gridId=" & zGridId & "&" & zParmName & "=" & zSendFilter & "&" & zParmName2 & "=" & zParmValue2
            zCriteriaString = zCriteriaString & zCriteriaStart
            zCriteriaString = zCriteriaString & "{""field"":""" & zParmName & """,""operator"":" & zCriteriaOperatorParm1 & ",""value"":""" & zSendFilter & """},"
            zCriteriaString = zCriteriaString & "{""field"":""" & zParmName2 & """,""operator"":" & zCriteriaOperatorParm2 & ",""value"":""" & zParmValue2 & """}"
            zCriteriaString = zCriteriaString & zCriteriaEnd
            UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filter, zCriteriaString, zGridId)
            Response.Redirect(zURL, False)
        ElseIf zParmName.Length > 0 Then
            zURL = "~/" & zURL & zSidParm & "&gridId=" & zGridId & "&" & zParmName & "=" & zSendFilter
            zCriteriaString = zCriteriaString & zCriteriaStart
            zCriteriaString = zCriteriaString & "{""field"":""" & zParmName & """,""operator"":" & zCriteriaOperatorParm1 & ",""value"":""" & zSendFilter & """}"
            zCriteriaString = zCriteriaString & zCriteriaEnd
            UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filter, zCriteriaString, zGridId)
            Response.Redirect(zURL, False)
        Else
            zURL = "~/" & zURL & zSidParm & "&gridId=" & zGridId
            Response.Redirect(zURL, False)
        End If


    End Sub

End Class