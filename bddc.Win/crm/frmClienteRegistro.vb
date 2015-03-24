Public Class frmClienteRegistro

#Region "Atributos"
    Private Shared objBEC As BEC.CLI.clsCliente
    Public ClienteId As Integer
#End Region

#Region "Contructor/Destructor"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objBEC = New BEC.CLI.clsCliente

    End Sub

    Public Sub New(ByVal pobjCliBEC As BEC.CLI.clsCliente)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objBEC = New BEC.CLI.clsCliente
        objBEC = pobjCliBEC

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
#End Region

#Region "Cliente - Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try
            ' 1. Parametro(s):
            '7:          Tipo Moneda

            arrResultados = objDL.Seleccionar("6", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                Me.cboTipoDoc.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.DocumentoIdentidad
                            Me.cboTipoDoc.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre))
                    End Select
                Next
            End If

            'Seleccionando el primer item:
            Me.cboTipoDoc.SelectedItem = Me.cboTipoDoc.Items(0)

            Dim objUbigeo As New DALC.COM.clsUbigeo
            Dim arrParam As New ArrayList
            Dim arrResultado As IList

            With arrParam
                .Add(Util.Enumeracion.enmAUXTipoUbigeo.DISTRITO)
                .Add(Util.Constante.CONST_PROV_LIMA)
            End With

            arrResultado = objUbigeo.Buscar(arrParam, frmLogin.Unidad)

            With cbDistrito
                .DisplayMember = "ItemNombre"
                .ValueMember = "ItemId"
                .DataSource = arrResultado
            End With

            txtTierJuegoFJM.Maximum = Configuration.ConfigurationManager.AppSettings("FCB_ClienteMaxTier")

            Me.lblClienteId.Text = ""
            Me.tssMensaje.Text = ""

            btnRating.Enabled = False



        Catch ex As Exception
            Me.tssMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub ClienteNuevo()

        lblClienteId.Text = ""
        txtClienteCodigo.ReadOnly = False
        lblClienteId.Text = ""
        'lblPuntaje.Text = "0.00"
        'lblTier.Text = "0"

        txtClienteCodigo.Text = ""
        txtClienteNombre.Text = ""
        txtClienteApePat.Text = ""
        txtClienteApeMat.Text = ""
        txtClienteNumDoc.Text = ""

        rbSexo1.Checked = False
        rbSexo2.Checked = False

        txtClienteFecNac.Text = ""
        'dtpClienteFecNac.Text = ""
        txtDomicilioDireccion.Text = ""
        'txtDomicilioDistrito.Text = ""
        txtClienteTelFijo.Text = ""
        txtClienteTelMovil.Text = ""
        txtClienteEmail.Text = ""
        txtClienteNacionalidad.Text = ""

        cbJuego1.Checked = False
        cbJuego2.Checked = False
        cbJuego3.Checked = False
        cbJuego4.Checked = False
        cbJuego5.Checked = False
        cbSlots.Checked = False

        pbFotografia.Image = Nothing
        btnFotoUpload.Visible = False
        btnFotoQuitar.Visible = False
        lblFotoOrigen.Text = ""

        txtClienteComentarios.Text = ""

        btnRating.Enabled = False
        Me.tssMensaje.Text = ""

        If objBEC IsNot Nothing Then
            If objBEC.ClienteId <> 0 Then objBEC.ClienteId = 0
        End If

    End Sub

    Private Sub ClienteBuscar()

        Try
            tssMensaje.Text = ""

            'Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
            'If uni = 0 Then
            Dim objfrm As New frmClienteBuscar

            objfrm.ShowDialog()

            If objfrm.intClienteId > 0 Then
                objBEC = New BEC.CLI.clsCliente
                objBEC.ClienteId = objfrm.intClienteId
                ClienteLeer(objBEC.ClienteId)
            End If

            If Me.txtClienteFecNac.Text <> "" Then
                txtClienteEdad.Text = Fix(DateDiff(DateInterval.Day, CDate(Me.txtClienteFecNac.Text), Today) / 365) & " Años"  'dtpClienteFecNac.Value)
            End If

            'Else
            '    Dim objfrm As New frmClienteBuscarL
            '    objfrm.ShowDialog()

            '    If objfrm.intClienteId > 0 Then
            '        objBEC = New BEC.CLI.clsCliente
            '        objBEC.ClienteId = objfrm.intClienteId
            '        ClienteLeer(objBEC.ClienteId)
            '    End If

            '    If String.Compare(Me.txtClienteFecNac.Text, "") = 1 Then
            '        txtClienteEdad.Text = Fix(DateDiff(DateInterval.Day, CDate(Me.txtClienteFecNac.Text), Today) / 365) & " Años"
            '    End If


            'End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub ClienteLeer(ByVal intClienteId As Integer)

        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
        objBEC = New BEC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim arrResultado As ArrayList
        Dim fi As IO.FileInfo

        Try

            objBEC = frmLogin.objColeccionFCB.objCliDALC.Leer(intClienteId, frmLogin.Unidad)

            If objBEC IsNot Nothing Then

                'ClienteNuevo()

                With objBEC

                    lblClienteId.Text = .ClienteId.ToString
                    txtClienteCodigo.Text = .ClienteCodigo.Trim
                    txtClienteNombre.Text = .ClienteNombres.Trim
                    txtClienteApePat.Text = .ClienteApePat.Trim
                    txtClienteApeMat.Text = .ClienteApeMat.Trim
                    txtClienteNumDoc.Text = .ClienteNumDoc.Trim

                    For k As Integer = 0 To cboTipoDoc.Items.Count - 1
                        If CType(cboTipoDoc.Items(k), BEC.COM.clsItem).ItemId = .ClienteTipoDocId Then
                            cboTipoDoc.SelectedItem = cboTipoDoc.Items(k)
                        End If
                    Next

                    btnFotoUpload.Visible = True

                    Dim strRuta As String = Util.Factory.FCB_RepositorioFotos & .ClienteCodigo.Trim & ".jpg"
                    fi = New IO.FileInfo(strRuta)

                    If fi.Exists Then
                        pbFotografia.Image = Image.FromFile(fi.FullName)
                        btnFotoQuitar.Visible = True
                        lblFotoOrigen.Text = strRuta
                    Else
                        pbFotografia.Image = Nothing
                        btnFotoQuitar.Visible = False
                        lblFotoOrigen.Text = ""
                    End If

                    rbSexo1.Checked = False
                    rbSexo2.Checked = False

                    Select Case .ClienteGeneroId
                        Case 1
                            rbSexo1.Checked = True
                        Case 2
                            rbSexo2.Checked = True
                    End Select

                    txtClienteFecNac.Text = .ClienteFecNac
                    txtDomicilioDireccion.Text = .DomicilioDireccion.Trim
                    'cbDistrito.Text = .DomicilioCiudad 'txtDomicilioDistrito.Text = .DomicilioCiudad

                    Dim intIndice As Integer = cbDistrito.FindString(.DomicilioCiudad.Trim)
                    If intIndice > 0 Then cbDistrito.SelectedIndex = intIndice

                    txtClienteTelFijo.Text = .ClienteTelefonoFijo.Trim
                    txtClienteTelMovil.Text = .ClienteTelefonoMovil.Trim
                    txtClienteEmail.Text = .ClienteEmail.Trim
                    txtClienteNacionalidad.Text = .ClienteNacionalidad.Trim

                    Dim strJuegoFavorito() As String = .PreferenciasFJM.Split(",")

                    If strJuegoFavorito.Length > 0 Then
                        For k As Integer = 0 To strJuegoFavorito.Length - 1
                            Select Case k
                                Case 0
                                    If strJuegoFavorito(0) <> "" Then cbJuego1.Checked = True
                                Case 1
                                    If strJuegoFavorito(1) <> "" Then cbJuego2.Checked = True
                                Case 2
                                    If strJuegoFavorito(2) <> "" Then cbJuego3.Checked = True
                                Case 3
                                    If strJuegoFavorito(3) <> "" Then cbJuego4.Checked = True
                                Case 4
                                    If strJuegoFavorito(4) <> "" Then cbJuego5.Checked = True
                                Case 5
                                    If strJuegoFavorito(5) <> "" Then cbSlots.Checked = True
                            End Select
                        Next
                    End If

                    ' Habilitar de acuerdo a los Permisos asignados:
                    frmLogin.ConfigurarControlxAccesos(btnRating, Util.Enumeracion.enmSEGOpcionesMenu.btnOperaciones_MesasRatingRegistro)

                    ' Leer Puntajes y Tiers de Juegos:
                    arrResultado = New ArrayList
                    arrResultado = frmLogin.objColeccionFCB.objCliDALC.LeerMovimientosFCB(intClienteId, frmLogin.Unidad)

                    Dim strDato() As String
                    Dim strJuegoId, strTier, strPuntaje As String

                    If arrResultado IsNot Nothing Then

                        If arrResultado.Count > 0 Then

                            tsbEliminar.Visible = False
                            For k As Integer = 0 To arrResultado.Count - 1

                                strDato = arrResultado(k).ToString.Split("|")
                                strJuegoId = strDato(0)
                                strPuntaje = strDato(1)
                                strTier = strDato(2)

                                Select Case strJuegoId
                                    Case Util.Enumeracion.enmFJMTipoNegocio.Mesas
                                        txtTierJuegoFJM.Value = Convert.ToInt16(strTier)
                                        txtPuntajeFJM.Text = strPuntaje
                                        btnRating.Enabled = True

                                    Case Util.Enumeracion.enmFJMTipoNegocio.Slots
                                        txtTierJuegoSlots.Text = strTier
                                        txtPuntajeSlots.Text = strPuntaje

                                End Select

                            Next

                        Else

                            'Select Case frmLogin.objColeccionFCB.objUsuCfgBEC.RolId
                            '    Case Util.Enumeracion.enmSEGRol.Administrador, Util.Enumeracion.enmSEGRol.Gerente, Util.Enumeracion.enmSEGRol.Supervisor
                            '        tsbEliminar.Visible = True
                            '    Case Else
                            '        tsbEliminar.Visible = False
                            'End Select

                        End If

                    Else
                        ''Habilitar según Rol del Usuario del Sistema
                        'Select Case frmLogin.objColeccionFCB.objUsuCfgBEC.RolId
                        '    Case Util.Enumeracion.enmSEGRol.Administrador, Util.Enumeracion.enmSEGRol.Gerente, Util.Enumeracion.enmSEGRol.Supervisor
                        '        tsbEliminar.Visible = True
                        '    Case Else
                        '        tsbEliminar.Visible = False
                        'End Select
                    End If

                    'Comentarios:
                    txtClienteComentarios.Text = .ClienteComentarios.Trim

                    'Datos de Auditoria:
                    If .AudCreac_UsuarioId > 0 Then
                        txtAudInsUsr.Text = .AudCreac_Usuario
                        txtAudInsFecha.Text = .AudCreac_Fecha
                    End If

                    If .AudEdic_UsuarioId > 0 Then
                        txtAudUpdUsr.Text = .AudEdic_Usuario
                        txtAudUpdFecha.Text = .AudEdic_Fecha
                    End If

                    'lblPuntaje.Text = .ClientePuntaje.ToString
                    'If .ClientePuntaje > 0 Then
                    '    Me.pbEliminarCli.Visible = False
                    'Else
                    '    Me.pbEliminarCli.Visible = True
                    'End If

                    txtClienteProfesion.Text = .ClienteProfesion.Trim

                    '======
                    'Empresa
                    '======
                    txtEmpresaNombre.Text = .EmpresaNombre.Trim
                    txtEmpresaRUC.Text = .EmpresaRUC.Trim
                    txtEmpresaArea.Text = .EmpresaArea.Trim
                    txtEmpresaPuesto.Text = .EmpresaPuesto.Trim
                    txtEmpresaDireccion.Text = .EmpresaDireccion.Trim
                    txtEmpresaTelefono.Text = .EmpresaTelefono.Trim
                    txtEmpresaPais.Text = .EmpresaPais.Trim

                    'Habilitar según Rol del Usuario del Sistema
                    If tsbEliminar.Enabled = True Then
                        tsbEliminar.Visible = True
                    Else
                        tsbEliminar.Visible = False
                    End If

                End With

            Else
                Throw New DataException(Util.Constante.Ope_LeerERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objCliDALC = Nothing
            fi = Nothing
        End Try

    End Sub

    Private Sub ClienteGuardar()
        If ValidarCliente() Then
            If txtClienteCodigo.Text = "" Then
                Dim valor As Integer
                valor = ValidarRegistroCliente()
                If valor = 0 Then
                    ClienteEscribir()
                Else
                    tssMensaje.Text = "El cliente ya se encuentra registrado en el sistema"
                End If
            Else
                ClienteEscribir()
            End If
        Else
            tssMensaje.Text = Util.Constante.Msj_SinDatos
        End If
    End Sub

    Private Function ValidarCliente() As Integer
        Try
            If txtClienteNombre.Text.Trim = "" Or txtClienteApePat.Text.Trim = "" Or txtClienteNumDoc.Text.Trim = "" Then
                Throw New DataException(Util.Constante.Msj_SinDatos)
            End If

            Return Util.Enumeracion.enmResultadoOperacion.OK

        Catch ex As Exception
            Return Util.Enumeracion.enmResultadoOperacion.NONE

        End Try

    End Function

    Private Function ValidarRegistroCliente() As Integer

        Try
            Dim NumIdentf As String = txtClienteNumDoc.Text
            Dim intResultado As Integer

            frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente

            intResultado = frmLogin.objColeccionFCB.objCliDALC.Verificar(NumIdentf, frmLogin.Unidad)
            Return intResultado

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        End Try
    End Function

    Private Sub ClienteEscribir()

        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
            intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
        Else
            Throw New DataException(Util.Constante.Acc_SesionERR)
        End If

        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
        objBEC = New BEC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim fi As IO.FileInfo

        Try

            With objBEC
                If lblClienteId.Text <> "" Then
                    .ClienteId = Convert.ToInt32(lblClienteId.Text)                   
                Else
                    .ClienteId = 0
                End If

                .ClienteCodigo = txtClienteCodigo.Text.Trim
                .ClienteNombres = txtClienteNombre.Text.ToUpper
                .ClienteApePat = txtClienteApePat.Text.ToUpper
                .ClienteApeMat = txtClienteApeMat.Text.ToUpper
                .ClienteTipoDocId = CType(cboTipoDoc.SelectedItem, BEC.COM.clsItem).ItemId
                .ClienteNumDoc = txtClienteNumDoc.Text
                .ClienteGeneroId = IIf(rbSexo1.Checked, 1, 2)
                .ClienteFecNac = txtClienteFecNac.Text 'dtpClienteFecNac.Text
                .DomicilioDireccion = txtDomicilioDireccion.Text.Trim
                .DomicilioCiudad = CType(cbDistrito.SelectedItem, BEC.COM.clsItem).ItemNombre
                .ClienteTelefonoFijo = txtClienteTelFijo.Text.Trim
                .ClienteTelefonoMovil = txtClienteTelMovil.Text.Trim
                .ClienteEmail = txtClienteEmail.Text.Trim
                .ClienteNacionalidad = txtClienteNacionalidad.Text.Trim
                .ClienteProfesion = txtClienteProfesion.Text.Trim

                '==========
                'Empresa
                '==========
                .EmpresaNombre = txtEmpresaNombre.Text.Trim
                .EmpresaRUC = txtEmpresaRUC.Text.Trim
                .EmpresaArea = txtEmpresaArea.Text.Trim
                .EmpresaPuesto = txtEmpresaPuesto.Text.Trim
                .EmpresaDireccion = txtEmpresaDireccion.Text.Trim
                .EmpresaTelefono = txtEmpresaTelefono.Text.Trim
                .EmpresaPais = txtEmpresaPais.Text.Trim

                '==========
                'Fiesta Casino Luxor Lima
                '==========

                Dim strJuegoFavorito As String = ""

                strJuegoFavorito &= IIf(cbJuego1.Checked, cbJuego1.Text, "") & ","
                strJuegoFavorito &= IIf(cbJuego2.Checked, cbJuego2.Text, "") & ","
                strJuegoFavorito &= IIf(cbJuego3.Checked, cbJuego3.Text, "") & ","
                strJuegoFavorito &= IIf(cbJuego4.Checked, cbJuego4.Text, "") & ","
                strJuegoFavorito &= IIf(cbJuego5.Checked, cbJuego5.Text, "") & ","
                strJuegoFavorito &= IIf(cbSlots.Checked, cbSlots.Text, "")
                .PreferenciasFJM = strJuegoFavorito

                .ClienteTier = Util.Enumeracion.enmFJMTipoNegocio.Mesas & ":" & txtTierJuegoFJM.Value

                .ClienteComentarios = txtClienteComentarios.Text.Trim

                .ClienteEstadoId = Util.Enumeracion.enmResultadoOperacion.OK
                .AudCreac_UsuarioId = intUsuarioId

                intResultado = frmLogin.objColeccionFCB.objCliDALC.Escribir(objBEC, frmLogin.Unidad)

                If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

                    Dim strRuta As String = Util.Factory.FCB_RepositorioFotos & .ClienteCodigo.Trim & ".jpg"

                    If Me.lblFotoOrigen.Text <> "" Then

                        fi = New IO.FileInfo(Me.lblFotoOrigen.Text)
                        fi.CopyTo(strRuta, True)
                        btnFotoQuitar.Visible = True

                    Else
                        'fi = New IO.FileInfo(strRuta)
                        'If fi.Exists Then fi.Delete()
                        'btnFotoUpload.Visible = True

                    End If

                    tssMensaje.Text = Util.Constante.Ope_EscribirOK

                    If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                        ' Pista de Auditoría:
                        Select Case lblClienteId.Text
                            Case Is > 0
                                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                            Case Else
                                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                        End Select

                        frmLogin.objColeccionFCB.objAuditoria = Nothing
                        ' Fin de Auditoría
                    End If

                    ClienteLeer(objBEC.ClienteId)
                    'lblClienteId.Text = frmLogin.objColeccionFCB.objCliBEC.ClienteId.ToString
                    'txtClienteCodigo.Text = frmLogin.objColeccionFCB.objCliBEC.ClienteCodigo

                Else
                    Throw New DataException(Util.Constante.Ope_EscribirERR)
                End If

            End With

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objCliDALC = Nothing
            fi = Nothing
        End Try

    End Sub

    Private Sub ClienteEliminar()

        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim intId As Integer = 0

        Try

            If lblClienteId.Text <> "" Then

                If MsgBox("Eliminar datos del Cliente", MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) = MsgBoxResult.Yes Then

                    intId = Convert.ToInt64(lblClienteId.Text)
                    intResultado = frmLogin.objColeccionFCB.objCliDALC.Eliminar(intId, frmLogin.Unidad)

                    If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

                        ClienteNuevo()
                        tssMensaje.Text = Util.Constante.Ope_EliminarOK

                        If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                            Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                            If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                            ' Pista de Auditoría:
                            frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Delete, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                            frmLogin.objColeccionFCB.objAuditoria = Nothing
                            ' Fin de Auditoría
                        End If

                    Else
                        Throw New DataException(Util.Constante.Ope_EliminarERR)
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            frmLogin.objColeccionFCB.objCliDALC = Nothing

        End Try

    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub frmClienteCRM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Habilitar según Permisos del Usuario:
        frmLogin.ConfigurarBarraxPermisos(Me.ToolStrip1, Util.Enumeracion.enmSEGModulos.MODFPC)

        LeerParametros()
        ClienteNuevo()

        If objBEC IsNot Nothing Then
            If objBEC.ClienteId <> 0 Then ClienteLeer(objBEC.ClienteId)
        End If

    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Me.ClienteBuscar()
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        ClienteNuevo()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim i As Integer = MsgBox(Util.Constante.Msg_ConfAgregar, MsgBoxStyle.YesNo)
        If i <> 6 Then Exit Sub
        ClienteGuardar()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        ClienteEliminar()
    End Sub

    Private Sub btnRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRating.Click
        Dim objRatReg As New frmRatingRegistro
        If lblClienteId.Text <> "" Then frmLogin.objColeccionFCB.objCliBEC.ClienteId = lblClienteId.Text
        objRatReg.ShowDialog()
    End Sub

    Private Sub btnFotoUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFotoUpload.Click
        Dim open As New OpenFileDialog
        'Dim strRuta, strArchivo As String
        Try
            If open.ShowDialog = Windows.Forms.DialogResult.OK Then

                'fi = New IO.FileInfo(open.FileName)
                'strArchivo = "IMG_" & Me.cboTipoDoc.SelectedValue & "_" & Me.txtDocumento.Text & "." & open.SafeFileName.Split(".")(1)
                'strRuta = ca.clsRegistry.RepositorioIMG & "\" & strArchivo
                'fi.CopyTo(strRuta, True)

                Me.lblFotoOrigen.Text = open.FileName
                Me.pbFotografia.Image = Image.FromFile(open.FileName)

            End If
        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub ToolStrip1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStrip1.MouseHover
        tssMensaje.Text = ""
    End Sub

    Private Sub dtpClienteFecNac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpClienteFecNac.ValueChanged
        txtClienteFecNac.Text = dtpClienteFecNac.Value.ToShortDateString
        txtClienteEdad.Text = Fix(DateDiff(DateInterval.Day, CDate(Me.txtClienteFecNac.Text), Today) / 365) & " Años"  'dtpClienteFecNac.Value)
    End Sub

    Private Sub ToolTip_Textos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClienteCodigo.Enter, txtClienteApePat.Enter, txtClienteNombre.Enter
        Dim strMensaje As String = ""

        Select Case CType(sender, TextBox).Name
            Case "txtClienteCodigo"
                strMensaje = "Ingresar el No. de Tarjeta TableTrac / En blanco, asignará automáticamente"

            Case "txtClienteApePat", "txtClienteNombre"
                strMensaje = "Dato obligatorio"

            Case "txtClienteNumDoc"
                strMensaje = "Dato obligatorio"

        End Select

        ToolTip1.SetToolTip(sender, strMensaje)

    End Sub

    Private Sub SoloNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClienteCodigo.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        If lblClienteId.Text.CompareTo("") <> 0 Then
            ClienteId = Convert.ToInt32(lblClienteId.Text)
        End If
        Me.Close()
    End Sub

#End Region

    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        'ClienteId = txtClienteCodigo.Text
        'Me.Close()
    End Sub

    Private Sub txtClienteFecNac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClienteFecNac.TextChanged
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class