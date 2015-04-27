Imports System.Threading

Public Class frmCambioPassword

#Region "Atributos"
    Private arrUbicaciones As IList
    Private FlagEmptyFields As Boolean
    Private FlagUserExist As Boolean
    Private FlagUserClaveActual As Boolean
    Private FlagNewPasswords As Boolean
    Private FlagChangePass As Boolean
    Private intUsuarioId As Integer
#End Region

#Region "Contructor/Destructor"
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
#End Region

#Region "Operaciones"

    Private Sub LeerParametros()
        '1:.Ubicaciones()
        Dim objDALCUbi As New DALC.COM.clsUnidad
        txtUsuario.Text = frmLogin.objColeccionFCB.objUsuBEC.Usuario

        'Para pruebas
        txtUnidad.Text = "EMPRESA DE PRUEBA"

        'Para produccion
        'Select Case frmLogin.objColeccionFCB.objUsuBEC.UnidadId
        '    Case 1
        '        txtUnidad.Text = "Fiesta Casino Benavides"
        '    Case 2
        '        txtUnidad.Text = "Luxor Lima Casino"
        '    Case 3
        '        txtUnidad.Text = "Luxor Tacna"
        'End Select

        'arrUbicaciones = objDALCUbi.Listar()
        'If arrUbicaciones IsNot Nothing Then
        '    Me.cboUbicaciones.DataSource = arrUbicaciones
        '    Me.cboUbicaciones.SelectedIndex = 1
        'End If

    End Sub

    Private Sub CamposEnBlanco()
        Try
            'If txtUsuario.Text.CompareTo("") = 0 Then
            '    lblmensaje.Text = "Debes ingresar el Nombre de Usuario"
            '    FlagEmptyFields = False
            '    Exit Sub
            'Else
            '    FlagEmptyFields = True
            'End If

            'If cboUbicaciones.Text.Trim.CompareTo("") = 0 Then
            '    lblmensaje.Text = "Debes seleccionar una Unidad"
            '    FlagEmptyFields = False
            '    Exit Sub
            'Else
            '    FlagEmptyFields = True
            'End If

            'If cboUbicaciones.Text.Trim.CompareTo("- SIN ESPECIFICAR -") = 0 Then
            '    lblmensaje.Text = "Debes seleccionar una Unidad"
            '    FlagEmptyFields = False
            '    Exit Sub
            'Else
            '    FlagEmptyFields = True
            'End If

            If txtOldPassword.Text.CompareTo("") = 0 Then
                lblmensaje.Text = "Debes ingresar tu contraseña actual"
                FlagEmptyFields = False
                Exit Sub
            Else
                FlagEmptyFields = True
            End If

            If txtNewPassword.Text.CompareTo("") = 0 Then
                lblmensaje.Text = "Debes ingresar tu Nueva Contraseña"
                FlagEmptyFields = False
                Exit Sub
            Else
                FlagEmptyFields = True
            End If

            If txtNewPassword2.Text.CompareTo("") = 0 Then
                lblmensaje.Text = "Debes confirmar tu Nueva Contraseña"
                FlagEmptyFields = False
                Exit Sub
            Else
                FlagEmptyFields = True
            End If

        Catch ex As Exception
            lblmensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub VerificarUsuario()

        Dim objDALC As New DALC.SEG.clsUsuario
        Dim arrResultados As ArrayList
        Dim arrParam As New ArrayList

        Try
            arrParam.Add(txtUsuario.Text.Trim)
            'Buscar si el nombre de usuario esta en la unidad seleccionada
            arrResultados = objDALC.Buscar(arrParam, txtUnidad.Text.Trim)

            If arrResultados Is Nothing Or arrResultados.Count = 0 Then
                'If arrResultados.Count = 0 Then
                FlagUserExist = False
                lblmensaje.Text = "El usuario ingresado no existe en la Unidad seleccionada"
                Exit Sub
            Else
                If arrResultados.Count = 1 Then
                    FlagUserExist = True
                End If
            End If
            'End If
        Catch ex As Exception
            Me.lblmensaje.Text = ex.Message
        Finally
            objDALC = Nothing
        End Try

    End Sub

    Private Sub ValidarPasswordActual()

        Dim objDALC As New DALC.SEG.clsUsuario
        Dim objUsuBEC As New BEC.SEG.clsUsuario
        Dim objSeguridad As New bddc.Win.thlaadfs.wsSeguridad
        Dim arrResultados As ArrayList
        Dim arrParam As New ArrayList
        Dim Unidad As String
        Dim strNombreUsuario As String = String.Empty

        Unidad = txtUnidad.Text.Trim

        With arrParam
            .Add(txtUsuario.Text.Trim)
        End With

        arrResultados = objDALC.Buscar(arrParam, Unidad)

        If arrResultados IsNot Nothing Then
            If arrResultados.Count > 0 Then
                objUsuBEC = CType(arrResultados(0), BEC.SEG.clsUsuario)

                If objUsuBEC IsNot Nothing Then

                    arrParam.Add(txtOldPassword.Text.Trim)

                    Select Case objUsuBEC.TipoAutenticacionId

                        Case Util.Enumeracion.enmSEGTipoAutenticacion.BD
                            intUsuarioId = objDALC.Login(arrParam, Unidad)

                        Case Util.Enumeracion.enmSEGTipoAutenticacion.LDAP
                            objSeguridad = New bddc.Win.thlaadfs.wsSeguridad
                            strNombreUsuario = objSeguridad.IsAuthenticatedUser(arrParam(0), arrParam(1))
                            intUsuarioId = objUsuBEC.UsuarioId

                        Case Else
                            intUsuarioId = objDALC.Login(arrParam, Unidad)
                    End Select

                    txtUsuarioId.Text = intUsuarioId.ToString()

                    If intUsuarioId = Util.Enumeracion.enmResultadoOperacion.NONE Then
                        FlagUserClaveActual = False
                        lblmensaje.Text = "La contraseña actual no es correcta"
                    Else
                        If intUsuarioId <> 0 Then
                            FlagUserClaveActual = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CompararString()
        If txtNewPassword.Text.CompareTo(txtNewPassword2.Text) <> 0 Then
            FlagNewPasswords = False
            lblmensaje.Text = "La nueva contraseña y la confirmación de la misma difieren"
        Else
            If txtNewPassword.Text.CompareTo(txtNewPassword2.Text) = 0 Then
                FlagNewPasswords = True
            End If
        End If
    End Sub

    Private Sub UpdatePassword()

        Dim objDALC = New DALC.SEG.clsUsuario
        Dim objBEC = New BEC.SEG.clsUsuario
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        intResultado = objDALC.UpdatePassword(Convert.ToInt32(txtUsuarioId.Text), txtNewPassword.Text, txtUnidad.Text.Trim)

        If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

            lblmensaje.Text = Util.Constante.Ope_ActualizarOK
            FlagChangePass = True
            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                Dim intUsuarioId As Integer = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                ' Pista de Auditoría:
                '        Select Case objBEC.UsuarioId
                '            Case 0
                '                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODSEG & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                '            Case Else
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODGU & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                '        End Sele

                '        frmLogin.objColeccionFCB.objAuditoria = Nothing
                'Fin de Auditoría
            End If
        Else
            FlagChangePass = False
            '    tsslblMensaje.Text = Util.Constante.Ope_ActualizarERR
        End If

    End Sub

    Private Sub ResetFields()

        txtUsuarioId.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtOldPassword.Text = String.Empty
        txtNewPassword.Text = String.Empty
        txtNewPassword2.Text = String.Empty

    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub frmCambioPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LeerParametros()
    End Sub

    Private Sub ToolStripButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Me.Close()
    End Sub

    Private Sub ToolStripButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonGuardar.Click
        Try
            lblmensaje.Text = String.Empty

            CamposEnBlanco()
            'Validar Campos en blanco
            If FlagEmptyFields = True Then

                VerificarUsuario()
                'Validar Usuario exista en la Unidad seleccionada
                If FlagUserExist = True Then

                    ValidarPasswordActual()
                    'Verificar Contraseña Actual
                    If FlagUserClaveActual = True Then

                        CompararString()
                        'Validar que la Contraseña Nueva y la Confirmación sean iguales
                        If FlagNewPasswords = True Then

                            UpdatePassword()
                            'Actualizar contraseña
                            If FlagChangePass = True Then
                                lblmensaje.Text = "La contraseña fue actualizada!"
                                ResetFields()
                            Else
                                lblmensaje.Text = "No se pudo actualizar la contraseña"
                                ResetFields()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region


End Class