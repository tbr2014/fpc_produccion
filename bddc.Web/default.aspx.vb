Public Partial Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'Response.Redirect("ini\login.aspx", False)
            Response.Redirect("ini\index.aspx", False)
            'Autenticacion()

        End If
    End Sub

End Class