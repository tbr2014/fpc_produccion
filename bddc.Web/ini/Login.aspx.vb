Imports System.Web.Security
Imports System.Configuration
Imports System.Diagnostics
'Imports System.DirectoryServices.AccountManagement

Public Class Login
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblMensaje As System.Web.UI.WebControls.Label
    Protected WithEvents txtUsuario As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    'Protected WithEvents txtDominio As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblVersion As System.Web.UI.WebControls.Label
    Protected WithEvents btnAceptar As System.Web.UI.WebControls.Button
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents lblOpcion As System.Web.UI.WebControls.Label
    Protected WithEvents chkInicioAuto As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblLogin As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private strIDPermisos As String
    Private strCodigoPermisos As String
    Private strValorPermisos As String
    'Private objAuditoria As DALC.SEG.clsEvento
    Private objEventLog As EventLog

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then
            Me.lblTitulo.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISTIT)
            Me.lblOpcion.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISLGI)
            Me.lblVersion.Text = ConfigurationManager.AppSettings.Get("version")

            'Me.txtDominio.Text = ConfigurationManager.AppSettings("SEGDominio")
            lblMensaje.CssClass = "GNRtxtInfo"
            lblMensaje.Text = ""

            Me.ConfigurarEstilos()

            Me.lblMensaje.CssClass = "GNRtxtInfo"

            'Dim objIdentity As System.Security.Principal.IIdentity = System.Web.HttpContext.Current.User.Identity
            'Me.lblMensaje.Text &= "<BR>Current Identity =" & objIdentity.Name & ", IsAuthenticated=" & objIdentity.IsAuthenticated & ", AuthenticationType=" & objIdentity.AuthenticationType

            LeerCookie()

        End If
    End Sub

#Region "ConfigurarEstilos"

    Private Sub ConfigurarEstilos()
        'Me.txtNombre.Attributes.Add("onfocus", "changeStyle(this, 'onfocus');")
        'Me.txtNombre.Attributes.Add("onblur", "changeStyle(this, 'onblur');")

        Dim lstControles As New ArrayList
        lstControles.Add(Me.txtUsuario)
        lstControles.Add(Me.txtPassword)

        Try
            For k As Integer = 0 To lstControles.Count - 1

                Dim objTexto As Object = lstControles(k)
                objTexto.Attributes.Add("onfocus", "changeStyle(this, 'onfocus');")
                objTexto.Attributes.Add("onblur", "changeStyle(this, 'onblur');")

            Next

        Catch ex As Exception

        End Try

        Me.txtUsuario.ToolTip = ConfigurationManager.AppSettings.Get("MsjTxt_Usr").Replace("XXX", ConfigurationManager.AppSettings.Get("SEGDominio").ToUpper)
        Me.txtPassword.ToolTip = ConfigurationManager.AppSettings.Get("MsjTxt_Psw")

    End Sub

#End Region

#Region "Autenticación & Autorización"

    Private Sub LoginUser()

        Authentication_and_Authorization()

        'Select Case ConfigurationManager.AppSettings("SEGTipoLogin")
        '    Case Util.Enumeracion.enmSEGTipoLogin.BD
        '        LoginUserxBD()
        '    Case Util.Enumeracion.enmSEGTipoLogin.LDAP
        '        LoginUserxLDAP()
        'End Select

    End Sub

    'Private Sub LoginUserxLDAP()

    '    Try
    '        If Me.txtUsuario.Text.Trim <> "" Then

    '            If WebAuthentication() Then

    '                'Se guada datos del Login, según selección:
    '                EscribirCookie()

    '                'Autorización del Usuario a Aplicaciones ITPE:
    '                Authorization()

    '            Else
    '                Throw New Exception(Util.Constante.Acc_AutenticacionERR)
    '            End If

    '        End If

    '    Catch ex As Exception
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message
    '    End Try

    'End Sub

    'Private Sub LoginUserxBD()

    '    Try
    '        If Me.txtUsuario.Text.Trim <> "" Then

    '            'Se guada datos del Login, según selección:
    '            If Me.chkInicioAuto.Checked Then
    '                EscribirCookie()
    '            Else
    '                BorrarCookie()
    '            End If

    '            'Autorización del Usuario a Aplicaciones ITPE:
    '            Authorization()

    '        Else
    '            Throw New Exception(Util.Constante.Acc_LoginERR)
    '        End If

    '    Catch ex As Exception
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message
    '    End Try

    'End Sub

    Private Function WebAuthentication() As Boolean

        'Dim objAcceso As New localhost.wsSeguridad
        Dim objAcceso As New thlaadfs.wsSeguridad
        Dim arrSession As New ArrayList
        Dim strNombreLogin As String

        Try

            strNombreLogin = objAcceso.IsAuthenticatedUser(txtUsuario.Text, txtPassword.Text)

            If strNombreLogin <> "" Then

                Me.lblMensaje.CssClass = "GNRtxtInfo"
                Me.lblMensaje.Text = Util.Constante.Acc_AutenticacionOK
                Me.lblLogin.Text = strNombreLogin

                Return True

            Else
                Return False
            End If

        Catch ex As Exception
            'Throw New DataException(ex.Message)
            Return False

        Finally
            objAcceso.Dispose()
            objAcceso = Nothing
        End Try

        Return False

    End Function

    Private Sub Authentication_and_Authorization()

        Dim objDALC As DALC.SEG.clsUsuario
        Dim objBEC As BEC.SEG.clsUsuario
        Dim intAutentificar As Integer
        Dim bolAutenticado As Boolean = False
        Dim arrConfig As IList

        Try
            objDALC = New DALC.SEG.clsUsuario
            intAutentificar = objDALC.Buscar(Me.txtUsuario.Text.Trim, Me.txtPassword.Text.Trim)

            If intAutentificar > 0 Then
                bolAutenticado = True
                objBEC = objDALC.LeerUsuario(intAutentificar)

                If objBEC.TipoAutenticacionId = Util.Enumeracion.enmSEGTipoAutenticacion.LDAP Then
                    If Not WebAuthentication() Then
                        bolAutenticado = False
                    Else
                        objBEC.Nombre = Me.lblLogin.Text
                    End If
                End If

                If bolAutenticado = True Then

                    'Se guada datos del Login, según selección:
                    If Me.chkInicioAuto.Checked Then
                        EscribirCookie()
                    Else
                        BorrarCookie()
                    End If

                    arrConfig = objDALC.LeerConfig(intAutentificar)

                    If arrConfig Is Nothing Then
                        Throw New DataException(Util.Constante.Acc_AutenticacionERR)
                    Else

                        Session("Usuario") = objBEC
                        Session("Config") = arrConfig

                        If Session("Usuario") IsNot Nothing And Session("Config") IsNot Nothing Then

                            '' Pista de Auditoría:
                            'objAuditoria = New DALC.SEG.clsEvento(objBEC.UsuarioId, Util.Enumeracion.enmTipoAccion.LogIn, Pagina.Nombre, Pagina.UserHostName)
                            'objAuditoria = Nothing
                            '' Fin de Auditoría

                            FormsAuthentication.RedirectFromLoginPage(objBEC.Usuario, False)
                            Response.Redirect("index.aspx", False)
                            'HttpContext.Current.ApplicationInstance.CompleteRequest()
                            'Server.Transfer("index.aspx")
                        Else
                            Throw New DataException(Util.Constante.Acc_SesionERR)
                        End If

                    End If
                Else
                    Throw New DataException(Util.Constante.Acc_AutenticacionERR)
                End If

            Else
                Throw New DataException(Util.Constante.Acc_UsuarioERR)
            End If

        Catch ex As Exception
            Me.lblMensaje.CssClass = "GNRtxtError"
            Me.lblMensaje.Text = ex.Message

        Finally
            objDALC = Nothing
        End Try

    End Sub

    'Private Function LoginUser(ByVal objResult As UserPrincipal) As IList

    '    Dim objDALC As DALC.SEG.clsUsuario
    '    Dim objBEC As BEC.SEG.clsUsuario
    '    Dim intAutentificar As Integer
    '    Dim arrConfig As IList
    '    Dim arrResult As ArrayList

    '    Try
    '        objDALC = New DALC.SEG.clsUsuario
    '        intAutentificar = objDALC.Buscar(objResult.SamAccountName)

    '        If intAutentificar > 0 Then

    '            objBEC = objDALC.LeerUsuario(intAutentificar)
    '            objBEC.Nombre = (objResult.DisplayName)

    '            If Not objBEC Is Nothing Then
    '                arrConfig = objDALC.LeerConfig(intAutentificar)

    '                If arrConfig Is Nothing Then
    '                    Throw New DataException(Util.Constante.Acc_AutenticacionERR)
    '                Else

    '                    arrResult = New ArrayList

    '                    With arrResult
    '                        .Add(objBEC)
    '                        .Add(arrConfig)
    '                    End With

    '                    Return arrResult

    '                    'Session("Usuario") = objBEC
    '                    'Session("Config") = arrConfig

    '                    '' Pista de Auditoría:
    '                    'objAuditoria = New DALC.SEG.clsEvento(objBEC.UsuarioId, Util.Enumeracion.enmTipoAccion.LogIn, Pagina.Nombre, Pagina.UserHostName)
    '                    'objAuditoria = Nothing
    '                    '' Fin de Auditoría

    '                    'FormsAuthentication.RedirectFromLoginPage(objBEC.Usuario, False)
    '                    'Response.Redirect("index.aspx", False)
    '                    'Server.Transfer("index.aspx")

    '                End If
    '            Else
    '                Throw New DataException(Util.Constante.Acc_LecturaERR)
    '            End If

    '        Else
    '            Throw New DataException(Util.Constante.Acc_LoginERR)
    '        End If

    '    Catch ex As Exception
    '        Throw New DataException(ex.Message)

    '    Finally
    '        If Not objDALC Is Nothing Then
    '            objDALC = Nothing
    '        End If

    '    End Try

    '    Return Nothing

    'End Function

#End Region

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        LoginUser()
    End Sub

#Region "Manejo de Cookies"

    Private Sub LeerCookie()
        Dim objCookie As HttpCookie
        Dim strLogin As String = ""
        Dim strDato() As String

        If Not HttpContext.Current.Request.Cookies("LOGIN") Is Nothing Then
            objCookie = HttpContext.Current.Request.Cookies("LOGIN")
            strDato = Server.HtmlEncode(objCookie.Value).Split("|")

            Me.txtUsuario.Text = strDato(0)
            Me.txtPassword.Text = strDato(1)

            Me.chkInicioAuto.Checked = True

            LoginUser()

        Else
            Me.chkInicioAuto.Checked = False
        End If

    End Sub

    Private Sub EscribirCookie()
        Dim strLogin As String = ""

        If Request.Cookies("LOGIN") Is Nothing Then
            Dim objCookie As HttpCookie
            objCookie = New HttpCookie("LOGIN")
            objCookie.HttpOnly = True
            objCookie.Value = Me.txtUsuario.Text & "|" & Me.txtPassword.Text
            objCookie.Expires = DateAdd(DateInterval.Day, Convert.ToInt16(ConfigurationManager.AppSettings("SEGDuracionCookie")), Now)
            Response.SetCookie(objCookie)
        End If

    End Sub

    Private Sub BorrarCookie()

        'Dim strCookies() As String = HttpContext.Current.Request.Cookies.AllKeys
        Dim objCookie As HttpCookie

        'For Each strCookie In strCookies
        '    objCookie = HttpContext.Current.Request.Cookies(strCookie)
        '    objCookie.Expires = DateTime.Now.AddYears(-30)
        '    HttpContext.Current.Response.Cookies.Add(objCookie)
        'Next

        'HttpContext.Current.Request.Cookies.Clear()

        Dim strLogin As String = "LOGIN"

        If Request.Cookies(strLogin) IsNot Nothing Then
            objCookie = Request.Cookies(strLogin)
            objCookie.Expires = DateAdd(DateInterval.Day, -1, Now)
            Response.SetCookie(objCookie)
        End If

    End Sub

#End Region


End Class
