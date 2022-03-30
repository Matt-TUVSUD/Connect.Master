Public Class ClientConnectSite
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' PREVENT CACHING
        Response.Cache.SetCacheability(HttpCacheability.NoCache)

        Dim sid = UtilGSafe.GetGUIDFromQueryString()
        If Not String.IsNullOrEmpty(sid) Then

            Dim zHeaderObj As New BusinessObjects.GSafeHeader
            Dim zHeaderQry As New BusinessObjects.GSafeHeaderQuery("h1")
            zHeaderQry.SelectAll()
            zHeaderQry.Where(zHeaderQry.GSafeGUID = sid)

            If zHeaderObj.Load(zHeaderQry) Then
                zHeaderObj.setLastAccessed()
                zHeaderObj.Save()
            End If

        End If

    End Sub


End Class