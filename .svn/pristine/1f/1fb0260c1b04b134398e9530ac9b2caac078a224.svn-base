Public Class _Default34
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGuid As String = Libraries.CoreLib.UtilGSafe.GetGUIDFromQueryString
          Dim zClientFeature As String = ""

          If zGuid <> "" Then
            zClientFeature = Libraries.CoreLib.UtilGSafe.GetValue(zGuid, Libraries.CoreLib.UtilGSafe.KeyName.clientFeatures)

            If zClientFeature.ToLower.Contains("g") Then
                Response.Redirect(Libraries.CoreLib.UtilSystemParms.ReadCheckListRequestUrl)
            End If
          End If

          Response.StatusCode = 403

    End Sub

End Class