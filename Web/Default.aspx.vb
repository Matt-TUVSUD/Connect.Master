﻿Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Redirect("Home/Auth/?" & Request.QueryString.ToString)

    End Sub

End Class