

Public Class CheckES
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zClients As New BusinessObjects.ClientsCollection

        If zClients.LoadAll Then
            Response.Write("Clients via Table Collection: " & zClients.Count)
        End If

        Response.Write("<br/><br/>")

        Dim zFireDetails As New BusinessObjects.ViewCCLocationInspectionFireCollection

        If zFireDetails.LoadAll Then
            Response.Write("Fire Details via View Collection: " & zFireDetails.Count)
        End If
    End Sub

End Class