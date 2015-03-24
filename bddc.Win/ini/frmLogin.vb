Imports System.Threading

Public Class frmLogin

    Private objCulture As New Util.clsCulture
    Private pbLogin As ToolStripProgressBar
    Private arrParam As ArrayList
    Private arrResultados As ArrayList
    Private arrParam2 As ArrayList
    Private arrResultados2 As ArrayList
    Private arrUbicaciones As IList
    Public Shared objColeccionFCB As clsColeccion
    Public Shared Unidad As String

    'Private WithEvents TestWorker As System.ComponentModel.BackgroundWorker

    'Formularios
    Public objPrincipal As frmPrincipal
    Public objCliReg As frmClienteRegistro
    Public objCliBus As frmClienteBuscar
    Public objCliBus2 As frmClienteBuscarL
    Public objCliBus3 As frmClienteBuscarT
    Public objRatReg As frmRatingRegistro
    Public objRptMesas As frmReportesMesas
    Public objRptMercadeo As frmReportesMercadeo

#Region "Operaciones"

    Private Sub LeerParametros()
        '1:.Ubicaciones()
        Dim objDALCUbi As New DALC.COM.clsUnidad

        arrUbicaciones = objDALCUbi.Listar()
        If arrUbicaciones IsNot Nothing Then
            Me.cboUbicaciones.DataSource = arrUbicaciones
            Me.cboUbicaciones.SelectedIndex = 1
            'Me.cboUbicaciones.SelectedText = "CASINO PRUEBA"
        End If

    End Sub

    Private Sub Login()

        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim strNombreUsuario As String = ""

        Unidad = Me.cboUbicaciones.SelectedValue.ToString()

        Try
            If txtUsuario.Text.Trim = "" Then Throw New DataException(Util.Constante.Acc_AutenticacionERR)

            arrParam = New ArrayList
            With arrParam
                .Add(txtUsuario.Text.Trim)
            End With

            'TestWorker.ReportProgress(1)

            '=========================
            '1. Autenticación del Usuario
            '=========================

            objColeccionFCB.objUsuDALC = New DALC.SEG.clsUsuario
            arrResultados = objColeccionFCB.objUsuDALC.Buscar(arrParam, Unidad)

            If arrResultados IsNot Nothing Then
                If arrResultados.Count > 0 Then

                    'Me.Hide()
                    'Me.Opacity = 0
                    objColeccionFCB.objUsuBEC = New BEC.SEG.clsUsuario
                    objColeccionFCB.objUsuBEC = CType(arrResultados(0), BEC.SEG.clsUsuario)

                    If objColeccionFCB.objUsuBEC IsNot Nothing Then

                        arrParam.Add(txtClave.Text.Trim)

                        Select Case objColeccionFCB.objUsuBEC.TipoAutenticacionId

                            Case Util.Enumeracion.enmSEGTipoAutenticacion.BD
                                intUsuarioId = objColeccionFCB.objUsuDALC.Login(arrParam, Unidad)

                            Case Util.Enumeracion.enmSEGTipoAutenticacion.LDAP
                                objSeguridad = New bddc.Win.thlaadfs.wsSeguridad
                                strNombreUsuario = objSeguridad.IsAuthenticatedUser(arrParam(0), arrParam(1))
                                intUsuarioId = objColeccionFCB.objUsuBEC.UsuarioId

                            Case Else
                                intUsuarioId = objColeccionFCB.objUsuDALC.Login(arrParam, Unidad)

                        End Select

                        If intUsuarioId > Util.Enumeracion.enmResultadoOperacion.NONE Then

                            'TestWorker.ReportProgress(3)

                            '===========================
                            ' 2. Autorización del Usuario autenticado
                            '===========================

                            objColeccionFCB.objUsuCfgDALC = New DALC.SEG.clsUsuarioConfig
                            'Dim objUsuCfgBEC = New BEC.SEG.clsUsuarioConfig
                            arrParam2 = New ArrayList

                            arrParam2.Add(intUsuarioId)
                            arrResultados2 = objColeccionFCB.objUsuCfgDALC.Buscar(arrParam2, Unidad)

                            If arrResultados2 IsNot Nothing Then

                                If arrResultados2.Count > 0 Then
                                    'For k As Integer = 0 To arrResultados2.Count - 1

                                    '    If CType(arrResultados2(k), BEC.SEG.clsUsuarioConfig).ModuloId = Util.Enumeracion.enmSEGModulos.MODFPC Then
                                    'objColeccionFCB.objUsuCfgBEC = arrResultados2(k)
                                    '    End If
                                    '    'TestWorker.ReportProgress(4)
                                    'Next

                                    objColeccionFCB.arrUsuCfgBEC = New ArrayList
                                    With objColeccionFCB.arrUsuCfgBEC
                                        .Add(objColeccionFCB.objUsuBEC)
                                        .Add(arrResultados2)
                                    End With

                                End If
                            End If

                            '========================
                            '3. Ubicación de Unidad de Negocio
                            '========================

                            Dim intUnidadId As Integer = CType(Me.cboUbicaciones.SelectedItem, BEC.COM.clsItem).ItemId
                            objColeccionFCB.objUsuUndBEC = New BEC.COM.clsUnidad

                            If intUnidadId <> 0 Then
                                Dim objUniDALC As New DALC.COM.clsUnidad
                                objColeccionFCB.objUsuUndBEC = objUniDALC.Leer(intUnidadId)
                            Else
                                'MsgBox("Debes seleccionar una Unidad!", MsgBoxStyle.Exclamation, Util.Constante.Sistema.SISTIT)
                                Throw New DataException("Debes seleccionar una Unidad!")
                                'objColeccionFCB.objUsuUndBEC.UnidadId = intUnidadId
                                'objColeccionFCB.objUsuUndBEC.Unidad = Util.Constante.Opcion_Todos
                            End If

                            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                                ' Pista de Auditoría:
                                objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.LogIn, Util.Constante.Sistema._MODSEG & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                                objColeccionFCB.objAuditoria = Nothing
                                ' Fin de Auditoría
                            End If

                            'Seteando Valores para la Pantalla Principal:
                            Me.Hide()

                            objPrincipal = New frmPrincipal
                            With objPrincipal
                                .WindowState = FormWindowState.Maximized

                                .UltraStatusBar1.Panels("tsslblUnidad").Text = "Unidad: " & objColeccionFCB.objUsuUndBEC.Unidad.ToUpper
                                .UltraStatusBar1.Panels("tsslblUsuario").Text = " Usuario: " & objColeccionFCB.objUsuBEC.Usuario
                                .UltraStatusBar1.Panels("tsslblEstacion").Text = " Estación: " & Environment.MachineName
                                .UltraStatusBar1.Panels("tsslblVersion").Text = tsslblVersion.Text

                                .ShowDialog()
                                .Dispose()
                                ResetControls()
                            End With

                        Else
                            Throw New DataException(Util.Constante.Acc_AutenticacionERR)
                        End If

                    Else
                        Throw New DataException(Util.Constante.Acc_AutenticacionERR)
                    End If

                End If

            Else
                Throw New DataException(Util.Constante.Acc_AutenticacionERR)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Util.Constante.Sistema.SISTIT)
            ResetControls()

        Finally
            objSeguridad = Nothing
            GC.Collect()
        End Try

    End Sub

    Public Sub ConfigurarBarraxPermisos(ByRef objBarraOpciones As ToolStrip, ByVal intModuloId As Util.Enumeracion.enmSEGModulos)

        'Deshabilitar todo:
        objBarraOpciones.Items("tsbNuevo").Visible = False
        objBarraOpciones.Items("tsbBuscar").Visible = False
        objBarraOpciones.Items("tsbGuardar").Visible = False
        objBarraOpciones.Items("tsbEliminar").Visible = False
        objBarraOpciones.Items("tsbImprimir").Visible = False
        objBarraOpciones.Items("tsbSalir").Visible = True

        For k As Integer = 0 To objColeccionFCB.arrUsuCfgBEC(1).Count - 1

            If CType(objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).ModuloId = intModuloId Then
                objColeccionFCB.objUsuCfgBEC = New BEC.SEG.clsUsuarioConfig
                objColeccionFCB.objUsuCfgBEC = objColeccionFCB.arrUsuCfgBEC(1)(k)
                Exit For
            End If

        Next

        'Habilitar según Permisos del Usuario:

        If objColeccionFCB.objUsuCfgBEC IsNot Nothing Then

            Dim strPermisos() As String = objColeccionFCB.objUsuCfgBEC.Permisos.Split("|")

            If strPermisos.Length > 0 And strPermisos(0) <> "" Then
                For k As Integer = 0 To strPermisos.Length - 1
                    Select Case strPermisos(k)
                        Case Util.Enumeracion.enmTipoAccion.Create
                            If objBarraOpciones.Items("tsbNuevo").Enabled = True Then objBarraOpciones.Items("tsbNuevo").Visible = True
                        Case Util.Enumeracion.enmTipoAccion.Read
                            If objBarraOpciones.Items("tsbBuscar").Enabled = True Then objBarraOpciones.Items("tsbBuscar").Visible = True
                        Case Util.Enumeracion.enmTipoAccion.Update
                            If objBarraOpciones.Items("tsbGuardar").Enabled = True Then objBarraOpciones.Items("tsbGuardar").Visible = True
                        Case Util.Enumeracion.enmTipoAccion.Delete
                            If objBarraOpciones.Items("tsbEliminar").Enabled = True Then objBarraOpciones.Items("tsbEliminar").Visible = True
                        Case Util.Enumeracion.enmTipoAccion.Print
                            If objBarraOpciones.Items("tsbImprimir").Enabled = True Then objBarraOpciones.Items("tsbImprimir").Visible = True
                    End Select
                Next
            End If

        End If

    End Sub

    Public Sub ConfigurarControlxAccesos(ByRef objControl As Object, ByVal intPermisoRequerido As Util.Enumeracion.enmSEGOpcionesMenu)

        Try
            'Verificar si se habilita botón Rating:
            objControl.Enabled = False

            Dim strCadenaOpciones As String = ""
            For k As Integer = 0 To objColeccionFCB.arrUsuCfgBEC(1).Count - 1
                If strCadenaOpciones <> "" Then strCadenaOpciones &= "|"
                strCadenaOpciones &= CType(objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).Opciones
            Next

            Dim strOpciones() As String = strCadenaOpciones.Split("|")
            Dim intOpcionId As Integer = 0

            For p As Integer = 0 To strOpciones.Length - 1
                intOpcionId = strOpciones(p)

                If intOpcionId = intPermisoRequerido Then
                    objControl.Enabled = True
                    Exit For
                End If
            Next

        Catch ex As Exception
            objControl.Enabled = False
            Throw New DataException(ex.Message)

        End Try

    End Sub

    Public Sub ConfigurarControlxPermiso(ByRef objControl As Object, ByVal intModulo As Util.Enumeracion.enmSEGModulos, ByVal intPermisoRequerido As Util.Enumeracion.enmTipoAccion)

        Try
            'Verificar si se habilita botón Rating:
            objControl.Enabled = False

            Dim strCadena As String = ""
            For k As Integer = 0 To objColeccionFCB.arrUsuCfgBEC(1).Count - 1
                If CType(objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).ModuloId = intModulo Then
                    strCadena = CType(objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).Permisos
                End If
            Next

            If strCadena <> "" Then

                Dim strPermisos() As String = strCadena.Split("|")
                Dim intPermisoId As Integer = 0

                For p As Integer = 0 To strPermisos.Length - 1
                    intPermisoId = strPermisos(p)

                    If intPermisoId = intPermisoRequerido Then
                        objControl.Enabled = True
                        Exit For
                    End If
                Next

            End If

        Catch ex As Exception
            objControl.Enabled = False
            Throw New DataException(ex.Message)

        End Try

    End Sub

    Public Sub ConfigurarControlxRol(ByRef objControl As Object, ByVal intModulo As Util.Enumeracion.enmSEGModulos, ByVal arrRolRequerido As ArrayList)

        Try
            'Verificar si se habilita botón Rating:
            objControl.Enabled = False

            Dim intRolId As Integer = 0
            For k As Integer = 0 To objColeccionFCB.arrUsuCfgBEC(1).Count - 1
                If CType(objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).ModuloId = intModulo Then
                    intRolId = CType(objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).RolId
                End If
            Next

            For k As Integer = 0 To arrRolRequerido.Count - 1
                If intRolId > 0 And intRolId = arrRolRequerido(k) Then objControl.Enabled = True
            Next

        Catch ex As Exception
            objControl.Enabled = False
            Throw New DataException(ex.Message)

        End Try

    End Sub

    Private Sub ResetControls()

        objColeccionFCB = New clsColeccion
        objColeccionFCB.objUsuDALC = New DALC.SEG.clsUsuario
        objColeccionFCB.objUsuBEC = New BEC.SEG.clsUsuario
        objColeccionFCB.arrUsuCfgBEC = New ArrayList

        txtUsuario.Text = ""
        txtClave.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub Ingresar()
        Login()
    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = Util.Constante.Msj_SistemaTitulo

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim strVersion As String = ""
            strVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
            tsslblVersion.Text = "Versión: " & strVersion
        End If

        tsslblIdioma.Text = "Configuración Regional: " & Thread.CurrentThread.CurrentCulture.ToString.ToUpper

        LeerParametros()
        ResetControls()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Ingresar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        GC.Collect()
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then txtClave.Focus()
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then Ingresar()
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.Enter, txtClave.Enter
        Dim strMensaje As String = ""

        Select Case CType(sender, TextBox).Name
            Case "txtUsuario"
                strMensaje = "Ingresar Usuario del Sistema/Red/Correo"

            Case "txtClave"
                strMensaje = "Ingresar Clave del Sistema/Red/Correo"

        End Select

        ToolTip1.SetToolTip(sender, strMensaje)

    End Sub

#End Region

End Class
