Imports System.Reflection
Imports System.Web.Security
Imports System.Diagnostics

Public Class index
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents mnuMenu As skmMenu.Menu
    Protected WithEvents Menu1 As skmMenu.Menu
    Protected WithEvents lblBienvenida As System.Web.UI.WebControls.Label
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents lblOpcion As System.Web.UI.WebControls.Label
    Protected WithEvents lblMensaje As System.Web.UI.WebControls.Label
    Protected WithEvents lbl_Cuadro01 As System.Web.UI.WebControls.Label
    Protected WithEvents lblNumFIN As System.Web.UI.WebControls.Label
    Protected WithEvents lblNumELE As System.Web.UI.WebControls.Label
    Protected WithEvents lblNumDEF As System.Web.UI.WebControls.Label
    Protected WithEvents lbl_Cuadro02 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin01 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin02 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin03 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin04 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin05 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin06 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin07 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin08 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin09 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin10 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin11 As System.Web.UI.WebControls.Label
    Protected WithEvents lblFin12 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle01 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle02 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle03 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle04 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle05 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle06 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle07 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle08 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle09 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle10 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle11 As System.Web.UI.WebControls.Label
    Protected WithEvents lblEle12 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef01 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef02 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef03 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef04 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef05 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef06 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef07 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef08 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef09 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef10 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef11 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDef12 As System.Web.UI.WebControls.Label
    Protected WithEvents lblVersion As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes01 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes02 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes03 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes04 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes05 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes06 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes07 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes08 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes09 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes10 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes11 As System.Web.UI.WebControls.Label
    Protected WithEvents lblDes12 As System.Web.UI.WebControls.Label
    Protected WithEvents lblUsuariosOnline As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private objEventLog As EventLog

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then

            Try

                'If Session("Usuario") Is Nothing Or Session("Config") Is Nothing Then
                '    Throw New DataException(Util.Constante.Acc_SesionERR)
                'Else
                '    objUsuario = CType(Session("Usuario"), BEC.SEG.clsUsuario)
                'End If

                Menu.generarMenu(mnuMenu, Server.MapPath("..\inc\menu.xml"), Session("Config"))
                Me.lblTitulo.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISTIT)
                Me.lblOpcion.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISINI)
                Me.lblVersion.Text = Util.Factory.Version

                Bienvenida()

            Catch ex As Exception
                Throw New DataException(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Bienvenida()

        Dim strSaludo As String = ""

        Select Case Now.Hour
            Case Is >= 0, Is < 13
                strSaludo = "Buenos días, "
            Case Is >= 13, Is < 18
                strSaludo = "Buenas tardes, "
            Case Is >= 18
                strSaludo = "Buenas noches, "

        End Select

        Dim objUsuario As BEC.SEG.clsUsuario = Session("Usuario")

        If objUsuario IsNot Nothing Then

            Me.lblBienvenida.Text = strSaludo & objUsuario.Nombre

            If Application("NumUsers") IsNot Nothing Then Me.lblUsuariosOnline.Text = "Usuarios Online: <b>" & IIf(Application("NumUsers") > 0, Application("NumUsers").ToString, "0")

        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
