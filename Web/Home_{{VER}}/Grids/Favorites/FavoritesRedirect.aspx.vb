Imports GRC.Connect.Libraries.CoreLib
Imports GRC.Connect.Libraries.DataLib.razor

Public Class FavoritesRedirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zGSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Dim zGridFavorite As rowTblGridFavorite = Nothing

        Try
            ' GET PARMS

            Dim zGridId As String = "0"
            If Not Request.QueryString("gridId") Is Nothing Then
                zGridId = Request.QueryString("gridId")
            End If
            Dim zFavId As String = "0"
            If Not Request.QueryString("favId") Is Nothing Then
                zFavId = Request.QueryString("favId")
                zGridFavorite = TblGridFavorite.LoadByPrimaryKey(zFavId)
                UtilSafe.SaveLargeObjectData_ByDataGroup(UtilGSafe.GetId(zGSafeGUID), UtilSafe.LargeObjectName.filter, zGridFavorite.colFldFilterJSON, zGridFavorite.colFldGridId)
                UtilSafe.SaveLargeObjectData_ByDataGroup(UtilGSafe.GetId(zGSafeGUID), UtilSafe.LargeObjectName.sort, zGridFavorite.colFldSortJSON, zGridFavorite.colFldGridId)
            End If

            ' STORE THE FAVORITE INFORMATION
            UtilGSafe.SetValue(zGSafeGUID, UtilGSafe.KeyName.currentFavId, zFavId, UtilGSafe.KeyNameGroup.Navigation)


            ' GET THE URL AND REDIRECT
            Dim zURL As String = ""
            Dim zColl As New List(Of rowTblNavLink)
            Dim zCmd As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[NavLink] WHERE [NavGridId] = @NavGridId")
            zCmd.Parameters.AddWithValue("@NavGridId", zGridId)
            zColl = TblNavLink.LoadData(zCmd)
            If zColl.Count > 0 Then
                zURL = zColl(0).colNavUrl
            End If
            zURL = Replace(zURL, "_BASE1_", "~/Home_{{VER}}")
            If zURL.Contains("?") Then
                zURL = zURL & "&sid=" & zGSafeGUID & "&gridId=" & zGridId & "&favId=" & zFavId
            Else
                zURL = zURL & "?sid=" & zGSafeGUID & "&gridId=" & zGridId & "&favId=" & zFavId
            End If
            Response.Redirect(zURL, False)

        Catch ex As Exception
            linkBack.HRef = "Favorites.aspx?sid=" & zGSafeGUID
            lblMessage.Text = "An error occurred while trying to recall your <strong>" & Chr(34) & zGridFavorite.colFldTitle & Chr(34) & "</strong> favorite.  <br /><br />We apologize for this inconvenience."

            Dim zUserFullName As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.userFullName)
            Dim zUserEmail As String = UtilGSafe.GetValue(zGSafeGUID, UtilGSafe.KeyName.UserEmail)

            ex.Data.Add("Safe Guid", zGSafeGUID)
            ex.Data.Add("Favorite ID", zGridFavorite.colId)
            ex.Data.Add("Favorite Name", zGridFavorite.colFldTitle)
            ex.Data.Add("User", zUserFullName)
            ex.Data.Add("Email", zUserEmail)

            UtilEmail.SendException(ex, "Favorites Redirect")
        End Try

    End Sub

End Class