Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilSafe
Imports GRC.Connect.Libraries.CoreLib.UtilPractice
Imports GRC.Connect.Libraries.CoreLib.UtilValidate

Public Class _Default1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGUID As String = GetGUIDFromQueryString()
        Dim zSafeId As String = GetId(zGUID) & ""

        ' GET THE GRID INFOMRATION
        Dim zGridId As String = "0"
        If Not Request.QueryString("gridId") Is Nothing Then
            zGridId = Request.QueryString("gridId")
        End If

        ' SET THE NAVLINK INFOMRATION
        Dim zNavlinkId As String = "0"
        If Not Request.QueryString("navLinkId") Is Nothing Then
            UtilGSafe.SetValue(zGUID, UtilGSafe.KeyName.NavLinkId, Request.QueryString("navLinkId"), UtilGSafe.KeyNameGroup.Navigation)
        End If

        ' GET THE TARGET FOLDER INFORMATION
        Dim zTargetName As String = "Standard"
        If Not Request.QueryString("targetPageName") Is Nothing Then
            zTargetName = Request.QueryString("targetPageName")
        End If

        ' GET THE IS MAP SHAPES INFO
        Dim zIsMapShapes As String = ""
        If Not Request.QueryString("mapshapes") Is Nothing Then
            zIsMapShapes = "&mapshapes=" & Request.QueryString("mapshapes")
        End If

        ' STORE THE CORRECT INFORMATION TO THE GSAFE AND RESET ANY OTHER INFORMATION
        SetValue(zGUID, KeyName.currentGridId, zGridId, KeyNameGroup.Navigation)
        Dim zCriteriaPrimary As String = LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaPrimary, zGridId) & ""
        SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaPrimary, Nothing, zGridId)
        If zCriteriaPrimary.Length > 0 Then
            SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteria, zCriteriaPrimary, zGridId)
        Else
            SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteria, Nothing, zGridId)
        End If

        Dim zUserid As Integer = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.EzyLoginId)
        UtilDB.LogGridActivity(zUserid, zGridId)

        ' REDIRECT TO THE GRID PAGE
        Dim zURL As String = "~/Home_{{VER}}/Grids/" & zTargetName & "/" & zTargetName & ".aspx?sid=" & GetGUIDFromQueryString() & zIsMapShapes
        Response.Redirect(zURL, False)

    End Sub

End Class