Public Class frmSeg_Usuarios

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try
            ' 1. Parametro
            arrResultados = objDL.Seleccionar("103", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                Me.cboTipoAutenticacion.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)

                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.SEG_TipoAutenticacion
                            Me.cboTipoAutenticacion.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))

                    End Select
                Next

            End If

            cboUsuarioBuscar.SelectedIndex = -1

            tsbGuardar.Visible = False
            tsbEliminar.Visible = False
            'gbAccesos.Enabled = False

            tsslblMensaje.Text = ""
            ResetControles()

        Catch ex As Exception
            Me.tsslblMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub LeerUsuarios()

        Dim objDALC As New DALC.SEG.clsUsuario
        Dim objBEC As BEC.SEG.clsUsuario
        Dim arrResultados As ArrayList
        Dim arrParam As New ArrayList

        Try
            arrParam.Add("%")
            arrResultados = objDALC.Buscar(arrParam, frmLogin.Unidad)

            cboUsuarioBuscar.Items.Clear()
            For k As Integer = 0 To arrResultados.Count - 1
                objBEC = New BEC.SEG.clsUsuario
                objBEC = CType(arrResultados(k), BEC.SEG.clsUsuario)
                Me.cboUsuarioBuscar.Items.Add(New BEC.COM.clsItem(objBEC.UsuarioId, objBEC.Usuario))
            Next

            cboUsuarioBuscar.SelectedIndex = -1
            cboUsuarioBuscar.Text = ""

            Me.btnGenerarClave.Enabled = True

        Catch ex As Exception
            Me.tsslblMensaje.Text = ex.Message
        Finally
            objDALC = Nothing
        End Try

    End Sub

    Private Sub ResetControles()

        txtUsuarioId.Text = ""
        txtNombre.Text = ""
        cboTipoAutenticacion.SelectedIndex = -1
        txtPassword.Text = ""
        txtInfoAdic.Text = ""

        dgvResultados.Visible = False
        'dgvResultados.DataSource = Nothing

        'gbDatosPrincipales.Enabled = False
        gbDatosAdicionales.Enabled = False
        tsslblMensaje.Text = ""
        txtNombre.Enabled = False
        cboTipoAutenticacion.Enabled = False
        Me.btnGenerarClave.Enabled = True
    End Sub

    Private Sub RegistroNuevo()

        cboUsuarioBuscar.Text = ""

        If tsbGuardar.Enabled = True Then tsbGuardar.Visible = True
        If tsbEliminar.Enabled = True Then tsbEliminar.Visible = True

        gbDatosPrincipales.Enabled = True
        gbDatosAdicionales.Enabled = True
        txtNombre.Enabled = True
        cboTipoAutenticacion.Enabled = True

    End Sub

    Private Sub LeerUsuario(ByVal intUsuarioId As Integer)

        Dim objDALC = New DALC.SEG.clsUsuario
        Dim objBEC = New BEC.SEG.clsUsuario

        objBEC = objDALC.Leer(intUsuarioId, frmLogin.Unidad)

        If objBEC IsNot Nothing Then

            'RegistroNuevo()

            With objBEC

                cboUsuarioBuscar.Text = .Usuario.Trim
                txtUsuarioId.Text = .UsuarioId.ToString
                txtNombre.Text = .Nombre.Trim

                For k As Integer = 0 To Me.cboTipoAutenticacion.Items.Count - 1
                    If CType(Me.cboTipoAutenticacion.Items(k), BEC.COM.clsItem).ItemId = .TipoAutenticacionId Then
                        Me.cboTipoAutenticacion.SelectedItem = Me.cboTipoAutenticacion.Items(k)
                        Exit For
                    End If
                Next

                txtPassword.Text = .Clave.Trim
                txtInfoAdic.Text = .Adicional
            End With

            LeerAccesos()

        End If

    End Sub

    Private Sub LeerAccesos()

        Dim objDALC = New DALC.SEG.clsUsuarioConfig
        Dim arrParametros As New ArrayList
        Dim arrResultados As ArrayList

        Try

            arrParametros.Add(CType(Me.cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
            arrResultados = objDALC.Buscar(arrParametros, frmLogin.Unidad)

            If arrResultados IsNot Nothing Then
                dgvResultados.Visible = True
                dgvResultados.DataSource = arrResultados
                tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultados.Count.ToString)
            Else
                dgvResultados.Visible = False
                'dgvResultados.DataSource = Nothing
                tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

        Catch ex As Exception
            tsslblMensaje.Text = Util.Constante.Ope_BuscarERR
        End Try

    End Sub

    Private Function GenerarClave() As String
        Dim objRandom As New Random
        Dim intNumAleat As Integer = objRandom.Next(10000000, 99999999)
        Return intNumAleat.ToString()
    End Function

    Private Sub EscribirUsuario()

        Dim objDALC = New DALC.SEG.clsUsuario
        Dim objBEC = New BEC.SEG.clsUsuario
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        If cboUsuarioBuscar.Text = "" Then Exit Sub
        tsslblMensaje.Text = ""

        With objBEC
            .UsuarioId = IIf(txtUsuarioId.Text <> "", txtUsuarioId.Text, 0)
            .Usuario = cboUsuarioBuscar.Text.Trim
            .Nombre = txtNombre.Text.Trim
            .TipoAutenticacionId = CType(Me.cboTipoAutenticacion.SelectedItem, BEC.COM.clsItem).ItemId
            .Clave = txtPassword.Text.Trim
            .Adicional = txtInfoAdic.Text.Trim
            .EstadoId = Util.Enumeracion.enmResultadoOperacion.OK
            .AudCreac_UsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
        End With

        intResultado = objDALC.Escribir(objBEC, frmLogin.Unidad)

        If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

            tsslblMensaje.Text = Util.Constante.Ope_ActualizarOK

            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                Dim intUsuarioId As Integer = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                ' Pista de Auditoría:
                Select Case objBEC.UsuarioId
                    Case 0
                        frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODSEG & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    Case Else
                        frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODSEG & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                End Select

                frmLogin.objColeccionFCB.objAuditoria = Nothing
                ' Fin de Auditoría
            End If

            txtUsuarioId.Text = objBEC.UsuarioId
            LeerUsuarios()

            For k As Integer = 0 To Me.cboUsuarioBuscar.Items.Count - 1
                If CType(Me.cboUsuarioBuscar.Items(k), BEC.COM.clsItem).ItemNombre = objBEC.Usuario Then
                    Me.cboUsuarioBuscar.SelectedItem = Me.cboUsuarioBuscar.Items(k)
                    Exit For
                End If
            Next

        Else
            tsslblMensaje.Text = Util.Constante.Ope_ActualizarERR
        End If

    End Sub

    Private Sub EliminarUsuario()

        Dim objDALC = New DALC.SEG.clsUsuario
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Try
            If MsgBox(Util.Constante.Msg_ConfInactivar, MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) <> 6 Then Exit Sub

            For k As Integer = 0 To cboUsuarioBuscar.Items.Count - 1
                If txtUsuarioId.Text = CType(Me.cboUsuarioBuscar.Items(k), BEC.COM.clsItem).ItemId Then
                    Me.cboUsuarioBuscar.SelectedItem = Me.cboUsuarioBuscar.Items(k)
                    Exit For
                End If
            Next

            intResultado = objDALC.Eliminar(CType(Me.cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId, frmLogin.Unidad)
            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                tsslblMensaje.Text = Util.Constante.Ope_InactivarUsuarioOk
                ResetControles()
                LeerUsuarios()
            Else
                tsslblMensaje.Text = Util.Constante.Ope_InactivarUsuarioERR
            End If
        Catch ex As Exception
            tsslblMensaje.Text = ex.Message
        Finally
            objDALC = Nothing
        End Try
    End Sub

#End Region

    Private Sub frmSeg_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODSEG)

        LeerParametros()
        LeerUsuarios()

        tsbGuardar.Visible = True
        tsbEliminar.Visible = True
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        ResetControles()
        RegistroNuevo()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        EscribirUsuario()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        EliminarUsuario()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub cboUsuarioBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboUsuarioBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ResetControles()
            If cboUsuarioBuscar.SelectedIndex > -1 Then LeerUsuario(CType(cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
            txtPassword.Enabled = True
            btnGenerarClave.Enabled = True
        End If
    End Sub

    Private Sub cboUsuarioBuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsuarioBuscar.SelectedIndexChanged
        ResetControles()
        If cboUsuarioBuscar.SelectedIndex > -1 Then LeerUsuario(CType(cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
        'txtPassword.Enabled = True
        ' btnGenerarClave.Enabled = True
    End Sub

    Private Sub cboTipoAutenticacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoAutenticacion.SelectedIndexChanged
        'txtPassword.Enabled = False
        'btnGenerarClave.Enabled = False

        If cboTipoAutenticacion.SelectedValue = Util.Enumeracion.enmSEGTipoAutenticacion.BD Then
            txtPassword.Enabled = True
            btnGenerarClave.Enabled = True
        End If
    End Sub

    Private Sub btnGenerarClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarClave.Click
        txtPassword.Text = GenerarClave()
    End Sub

    Private Sub btnAccesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccesos.Click
        Dim objFrm As New frmSeg_Accesos

        If cboUsuarioBuscar.SelectedIndex > -1 Then
            objFrm.intUsuarioId = CType(cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId
            objFrm.ShowDialog()
            LeerAccesos()
        End If

    End Sub

End Class