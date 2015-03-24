Public Class EnConstruccion
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents lblVersion As System.Web.UI.WebControls.Label
    Protected WithEvents lblOpcion As System.Web.UI.WebControls.Label
    Protected WithEvents lblMensaje As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Session("Permisos") Is Nothing Or Session("UsuarioId") Is Nothing Then Throw New DataException("Sin Permisos")
        If Not Page.IsPostBack Then
            Me.lblTitulo.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISTIT)
            Me.lblOpcion.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISINI)
            Me.lblVersion.Text = ConfigurationManager.AppSettings.Get("version")

            lblMensaje.CssClass = "GNRtxtInfo"
            lblMensaje.Text = "Disculpe las molestias."

        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
