Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilSafe
Imports GRC.Connect.Libraries.CoreLib.UtilPractice
Imports GRC.Connect.Libraries.CoreLib.UtilValidate

Public Class Filter_GaugeRedirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = GetGUIDFromQueryString()
        Dim zSafeId As String = GetId(zGUID) & ""

        ' GET THE GRID INFOMRATION
        Dim zGridId As String = "0"
        If Not Request.QueryString("gridId") Is Nothing Then
            zGridId = Request.QueryString("gridId")
        End If

        ' GET THE TARGET FOLDER INFORMATION
        Dim zTargetName As String = "Standard"
        If Not Request.QueryString("targetPageName") Is Nothing Then
            zTargetName = Request.QueryString("targetPageName")
        End If

        ' STORE THE CORRECT INFORMATION TO THE GSAFE AND RESET ANY OTHER INFORMATION
        SetValue(zGUID, KeyName.currentGridId, zGridId, KeyNameGroup.Navigation)
        'SaveLargeObjectData_ByDataGroup(zSafeId, "criteria", Nothing, zGridId) 'LET THE CRITERIA THROUGH , DO NOT RESET

        ' REDIRECT TO THE GRID PAGE
        Dim zURL As String = "~/Home_{{VER}}/Grids/" & zTargetName & "/" & zTargetName & ".aspx?sid=" & GetGUIDFromQueryString()
        Response.Redirect(zURL, False)

    End Sub

End Class