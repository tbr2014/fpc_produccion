Public Class frmSeg_Accesos

#Region "Ätributos"

    Public intUsuarioId As Integer
    Public arrUsuCfg As ArrayList
    Private Shared arrOpciones As ArrayList

#End Region

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try
            ' 1. Parametro
            arrResultados = objDL.Seleccionar("100, 101, 102, 104", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                Me.cboModulos.Items.Clear()
                Me.cboRoles.Items.Clear()
                Me.clbPermisos.Items.Clear()
                Me.clbOpciones.Items.Clear()
                Me.clbOpciones.Visible = False
                arrOpciones = New ArrayList
                'Me.cboUbicaciones.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)

                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.SEG_Modulos
                            Me.cboModulos.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas & " - " & objBEC.Nombre))

                        Case Util.Enumeracion.enmGrupoParametro.SEG_TipoRol
                            Me.cboRoles.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre))

                        Case Util.Enumeracion.enmGrupoParametro.SEG_TipoAccion
                            Me.clbPermisos.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre), False)

                        Case Util.Enumeracion.enmGrupoParametro.SEG_OpcionesMenu
                            'Me.clbOpciones.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre), False)
                            arrOpciones.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre))

                    End Select
                Next
                cboModulos.Items.RemoveAt(4)
                'cboModulos.Items.Remove("MODGU - Modulo Gestion de Usuario")
            End If

            '2. Horarios:
            clbHorario.Items.Clear()
            For k As Integer = 0 To 23
                Me.clbHorario.Items.Add(New BEC.COM.clsItem(k, k.ToString("00") & ":00"), False)
            Next

            '3. Ubicaciones:
            Dim objDALCUbi As New DALC.COM.clsUnidad

            arrResultados = objDALCUbi.Listar()
            If arrResultados IsNot Nothing Then
                'Me.cboUbicaciones.DataSource = arrResultados
            End If

            If tsbEliminar.Enabled = False Then tsbEliminar.Visible = False

            'gbModulos.Enabled = False
            'gbOpciones.Enabled = False
            'gbPermisos.Enabled = False
            'gbRoles.Enabled = False
            'gbHorario.Enabled = False
            'gbUbicaciones.Enabled = False
            tsslblMensaje.Text = ""
            txtUsuarioId.Text = ""

            cboUsuarioBuscar.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR
            ResetControles()

        Catch ex As Exception
            Me.tsslblMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub ResetControles()

        'cboModulos.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR
        'txtUsuarioId.Text = ""
        cboRoles.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR

        For k As Integer = 0 To clbPermisos.Items.Count - 1
            clbPermisos.SetItemChecked(k, False)
        Next

        For k As Integer = 0 To 23
            clbHorario.SetItemChecked(k, False)
        Next

        For k As Integer = 0 To clbOpciones.Items.Count - 1
            clbOpciones.SetItemChecked(k, False)
        Next

    End Sub

    Private Sub LeerConfig(ByVal intUsuarioId As Integer)

        Dim objDALC = New DALC.SEG.clsUsuarioConfig
        Dim objBEC = New BEC.SEG.clsUsuarioConfig
        Dim arrParam As New ArrayList

        arrParam.Add(intUsuarioId)
        arrUsuCfg = objDALC.Buscar(arrParam, frmLogin.Unidad)

        txtUsuarioId.Text = intUsuarioId.ToString

        If arrUsuCfg IsNot Nothing Then

            objBEC = CType(arrUsuCfg(0), BEC.SEG.clsUsuarioConfig)

            '1. Modulos
            For K As Integer = 0 To cboModulos.Items.Count - 1
                If CType(cboModulos.Items(K), BEC.COM.clsItem).ItemId = objBEC.ModuloId Then
                    cboModulos.SelectedItem = cboModulos.Items(K)
                End If
            Next

            gbModulos.Enabled = True
            gbOpciones.Enabled = True
            gbPermisos.Enabled = True
            gbRoles.Enabled = True
            gbHorario.Enabled = True
            'gbUbicaciones.Enabled = True

        End If

    End Sub

    Private Sub EscribirConfig()

        Dim objDALC = New DALC.SEG.clsUsuarioConfig
        Dim objBEC = New BEC.SEG.clsUsuarioConfig
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim strCadena As String

        Try

            For k As Integer = 0 To cboUsuarioBuscar.Items.Count - 1
                If txtUsuarioId.Text = CType(Me.cboUsuarioBuscar.Items(k), BEC.COM.clsItem).ItemId Then
                    Me.cboUsuarioBuscar.SelectedItem = Me.cboUsuarioBuscar.Items(k)
                    Exit For
                End If
            Next

            With objBEC

                .UsuarioId = CType(Me.cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId

                If Me.cboModulos.SelectedIndex = -1 Then
                    tsslblMensaje.Text = Util.Constante.Ope_EscribirERR & "|Seleccionar Módulo"
                    Exit Sub
                End If

                .ModuloId = CType(Me.cboModulos.SelectedItem, BEC.COM.clsItem).ItemId

                If Me.cboRoles.SelectedIndex = -1 Then
                    tsslblMensaje.Text = Util.Constante.Ope_EscribirERR & "|Seleccionar Rol"
                    Exit Sub
                End If

                .RolId = CType(Me.cboRoles.SelectedItem, BEC.COM.clsItem).ItemId

                strCadena = ""
                For k As Integer = 0 To clbPermisos.CheckedItems.Count - 1
                    If strCadena <> "" Then strCadena &= "|"
                    strCadena &= CType(clbPermisos.CheckedItems(k), BEC.COM.clsItem).ItemId.ToString
                Next
                .Permisos = strCadena

                Dim bolHay As Boolean
                strCadena = ""

                For p As Integer = 0 To 23
                    bolHay = False
                    For q As Integer = 0 To clbHorario.CheckedItems.Count - 1
                        If Comparer.Equals(clbHorario.Items(p), clbHorario.CheckedItems(q)) Then
                            strCadena &= "1"
                            bolHay = True
                            Exit For
                        End If
                    Next
                    If bolHay = False Then strCadena &= "0"
                Next
                .Horario = strCadena

                .Ubicacion = frmLogin.Unidad
                '.Ubicacion = CType(Me.cboUbicaciones.SelectedItem, BEC.COM.clsItem).ItemId

                strCadena = ""
                For k As Integer = 0 To clbOpciones.CheckedItems.Count - 1
                    If strCadena <> "" Then strCadena &= "|"
                    strCadena &= CType(clbOpciones.CheckedItems(k), BEC.COM.clsItem).ItemId.ToString
                Next
                .Opciones = strCadena
                .EstadoId = Util.Enumeracion.enmResultadoOperacion.OK
            End With

            intResultado = objDALC.Escribir(objBEC, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                tsslblMensaje.Text = Util.Constante.Ope_ActualizarOK

                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                    Dim intUsuarioId As Integer = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                    ' Pista de Auditoría:
                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODSEG & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    frmLogin.objColeccionFCB.objAuditoria = Nothing
                    ' Fin de Auditoría
                End If

                LeerConfig(CType(Me.cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)

            Else
                tsslblMensaje.Text = Util.Constante.Ope_ActualizarERR
            End If

        Catch ex As Exception
            tsslblMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub EliminarConfig()

        Dim objDALC = New DALC.SEG.clsUsuarioConfig
        Dim arrParametro As New ArrayList
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try
            With arrParametro
                .Add(CType(Me.cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
                .Add(CType(Me.cboModulos.SelectedItem, BEC.COM.clsItem).ItemId)
            End With

            intResultado = objDALC.Eliminar(arrParametro, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                tsslblMensaje.Text = Util.Constante.Ope_EliminarOK
                ResetControles()
                LeerConfig(CType(Me.cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
                cboModulos.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR

            Else
                tsslblMensaje.Text = Util.Constante.Ope_EliminarERR
            End If

        Catch ex As Exception
            tsslblMensaje.Text = ex.Message

        Finally
            objDALC = Nothing
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

        Catch ex As Exception
            Me.tsslblMensaje.Text = ex.Message
        Finally
            objDALC = Nothing
        End Try

    End Sub

#End Region

    Private Sub frmSeg_Accesos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODSEG)
        LeerParametros()
        LeerUsuarios()

        'Si viene de la ventana de Administración de Usuarios:
        If intUsuarioId <> 0 Then
            For k As Integer = 0 To cboUsuarioBuscar.Items.Count - 1
                If CType(cboUsuarioBuscar.Items(k), BEC.COM.clsItem).ItemId = intUsuarioId Then
                    cboUsuarioBuscar.SelectedItem = cboUsuarioBuscar.Items(k)
                    cboUsuarioBuscar.Enabled = False
                End If
            Next
        End If

    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        EliminarConfig()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub cboUsuarioBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboUsuarioBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboModulos.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR
            txtUsuarioId.Text = ""
            ResetControles()
            If cboUsuarioBuscar.SelectedIndex > -1 Then LeerConfig(CType(cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
        End If
    End Sub

    Private Sub cboUsuarioBuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsuarioBuscar.SelectedIndexChanged
        cboModulos.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR
        txtUsuarioId.Text = ""
        ResetControles()
        If cboUsuarioBuscar.SelectedIndex > -1 Then LeerConfig(CType(cboUsuarioBuscar.SelectedItem, BEC.COM.clsItem).ItemId)
    End Sub

    Private Sub SeleccionModulo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModulos.SelectedIndexChanged

        ResetControles()

        If cboModulos.SelectedIndex > -1 And cboModulos.Items.Count > 0 Then

            Dim intItemId As Integer = CType(cboModulos.SelectedItem, BEC.COM.clsItem).ItemId
            Dim objBEC = New BEC.SEG.clsUsuarioConfig

            Me.clbOpciones.Items.Clear()

            Dim strCadena As String = Mid(CType(cboModulos.Items(cboModulos.SelectedIndex), BEC.COM.clsItem).ItemNombre, 1, 6)

            For p As Integer = 0 To arrOpciones.Count - 1

                If InStr(CType(arrOpciones(p), BEC.COM.clsItem).ItemNombre, strCadena) > 0 Then
                    Me.clbOpciones.Items.Add(arrOpciones(p), False)
                End If
            Next

            If Me.clbOpciones.Items.Count > 0 Then
                clbOpciones.Visible = True
            Else
                clbOpciones.Visible = False
            End If

            If arrUsuCfg IsNot Nothing Then

                'Buscar módulo:
                For k As Integer = 0 To Me.arrUsuCfg.Count - 1

                    objBEC = CType(arrUsuCfg(k), BEC.SEG.clsUsuarioConfig)

                    'Cargar en los controles:
                    If intItemId = objBEC.ModuloId Then

                        tsbEliminar.Visible = True

                        '1. Rol:
                        For p As Integer = 0 To cboRoles.Items.Count - 1
                            If CType(cboRoles.Items(p), BEC.COM.clsItem).ItemId = objBEC.RolId Then
                                cboRoles.SelectedItem = cboRoles.Items(p)
                            End If
                        Next

                        '2. Opciones:
                        Dim strOpciones() As String = objBEC.Opciones.Split("|")
                        Dim strOpcion As String

                        If strOpciones.Length > 0 Then

                            For q As Integer = 0 To strOpciones.Length - 1
                                strOpcion = strOpciones(q)
                                If strOpcion <> "" Then
                                    For r As Integer = 0 To clbOpciones.Items.Count - 1
                                        If strOpcion = CType(clbOpciones.Items(r), BEC.COM.clsItem).ItemId Then
                                            clbOpciones.SetItemChecked(r, True)
                                            Exit For
                                        End If
                                    Next
                                End If
                            Next
                        End If

                        '3. Horario:
                        Dim strHora As String

                        For r As Integer = 1 To Len(objBEC.Horario)
                            strHora = Mid(objBEC.Horario, r, 1)
                            If strHora = "1" Then clbHorario.SetItemChecked(r - 1, True)
                        Next

                        '4. Permisos:
                        Dim strPermisos() As String = objBEC.Permisos.Split("|")
                        Dim strPermiso As String

                        If strPermisos.Length > 0 Then
                            For q As Integer = 0 To strPermisos.Length - 1
                                strPermiso = strPermisos(q)
                                If strPermiso <> "" Then
                                    For r As Integer = 0 To clbPermisos.Items.Count - 1
                                        If strPermiso = CType(clbPermisos.Items(r), BEC.COM.clsItem).ItemId Then
                                            clbPermisos.SetItemChecked(r, True)
                                            Exit For
                                        End If
                                    Next
                                End If
                            Next
                        End If

                        '5. Ubicaciones:
                        'For p As Integer = 0 To cboUbicaciones.Items.Count - 1
                        '    If CType(cboUbicaciones.Items(p), BEC.COM.clsItem).ItemId = IIf(objBEC.Ubicacion = "", 0, objBEC.Ubicacion) Then
                        '        cboUbicaciones.SelectedItem = cboUbicaciones.Items(p)
                        '    End If
                        'Next

                        Exit For

                    End If

                Next

            End If

        End If

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        EscribirConfig()
    End Sub

    Private Sub chkOpciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOpciones.CheckedChanged
        For k As Integer = 0 To clbOpciones.Items.Count - 1
            clbOpciones.SetItemChecked(k, chkOpciones.Checked)
        Next
    End Sub

    Private Sub chkPermisos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPermisos.CheckedChanged
        For k As Integer = 0 To clbPermisos.Items.Count - 1
            clbPermisos.SetItemChecked(k, chkPermisos.Checked)
        Next
    End Sub

    Private Sub chkHorario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHorario.CheckedChanged
        For k As Integer = 0 To clbHorario.Items.Count - 1
            clbHorario.SetItemChecked(k, chkHorario.Checked)
        Next
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class