Public Class frmRatingRegistro

    Private objDALC As DALC.CLI.clsReporte
    Private arrFiltros As ArrayList
    Private Shared arrMesas As ArrayList
    Private objHorario As Util.clsHorario
    Dim boolElimiar As Boolean

#Region "Operaciones"

    Private Sub LoadControls()

        '1. Datos fijos:

        Dim arrHoraIni, arrHoraFin, arrMinutoIni, arrMinutoFin As ArrayList

        arrHoraIni = New ArrayList
        arrHoraFin = New ArrayList
        arrMinutoIni = New ArrayList
        arrMinutoFin = New ArrayList

        Dim q As Integer = Util.Factory.FCB_HorarioAtencionIni
        Dim n As Integer = 0

        For p As Integer = 0 To 12
            If p + q > 23 Then
                n = p + q - 24
            Else
                n = p + q
            End If

            arrHoraIni.Add(New BEC.COM.clsItem(p, n.ToString("00")))
            arrHoraFin.Add(New BEC.COM.clsItem(p, n.ToString("00")))
        Next

        For p As Integer = 0 To 59
            arrMinutoIni.Add(New BEC.COM.clsItem(p, p.ToString("00")))
            arrMinutoFin.Add(New BEC.COM.clsItem(p, p.ToString("00")))
        Next

        With cboHoraIni
            .ValueMember = "ItemId"
            .DisplayMember = "ItemNombre"
            '.AutoCompleteMode = AutoCompleteMode.Suggest
            '.AutoCompleteSource = AutoCompleteSource.None
            .DataSource = arrHoraIni
        End With

        With cboHoraFin
            .ValueMember = "ItemId"
            .DisplayMember = "ItemNombre"
            '.AutoCompleteMode = AutoCompleteMode.Suggest
            '.AutoCompleteSource = AutoCompleteSource.None
            .DataSource = arrHoraFin
        End With

        With cboMinIni
            .ValueMember = "ItemId"
            .DisplayMember = "ItemNombre"
            '.AutoCompleteMode = AutoCompleteMode.Suggest
            '.AutoCompleteSource = AutoCompleteSource.None
            .DataSource = arrMinutoIni
        End With

        With cboMinFin
            .ValueMember = "ItemId"
            .DisplayMember = "ItemNombre"
            '.AutoCompleteMode = AutoCompleteMode.Suggest
            '.AutoCompleteSource = AutoCompleteSource.None
            .DataSource = arrMinutoFin
        End With

        '2. Configuraciones:

        Dim strNroMesas() As String = Util.Factory.FCB_NumMesasxTipoJuego.Split("|")
        Dim strDato() As String

        For k As Integer = 0 To strNroMesas.Length - 1
            strDato = strNroMesas(k).Split("-")

            If strDato(0) <> "" Then
                Select Case Convert.ToInt16(strDato(0))
                    Case 1
                        rbJuego1.Tag = strDato(1)
                    Case 2
                        rbJuego2.Tag = strDato(1)
                    Case 3
                        rbJuego3.Tag = strDato(1)
                    Case 4
                        rbJuego4.Tag = strDato(1)
                    Case 5
                        rbJuego5.Tag = strDato(1)
                End Select
            End If

        Next

        ''2. Leer Parámetros del Sistema:

        'Dim objDALC As New DALC.COM.clsParametro
        'Dim objBEC As BEC.COM.clsParametro
        'Dim arrResultados As IList
        'Dim dtDatos(1) As DataTable
        'Dim drItem As DataRow

        'arrResultados = objDALC.Seleccionar(Util.Enumeracion.enmTipoParametro.AUX, "7, 21")

        'For k As Integer = 0 To arrResultados.Count - 1
        '    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)

        '    Select Case objBEC.GrupoId
        '        Case Util.Enumeracion.enmGrupoParametro.TipoMoneda
        '            drItem = dtDatos(0).NewRow
        '            drItem(0) = objBEC.ParametroId
        '            drItem(1) = objBEC.Siglas
        '            dtDatos(0).Rows.Add(drItem)

        '        Case Util.Enumeracion.enmGrupoParametro.TipoJuegoMesa
        '            drItem = dtDatos(1).NewRow
        '            drItem(0) = objBEC.ParametroId
        '            drItem(1) = objBEC.Siglas
        '            dtDatos(1).Rows.Add(drItem)

        '    End Select
        'Next

        objHorario = New Util.clsHorario
        dtpFechaMov.MaxDate = objHorario.FechaProcesoFCB
        dtpFechaMov.Value = dtpFechaMov.MaxDate

        '3. Leer Mesas:
        LeerMesas()

        'tsbBuscar.Visible = True
        tsbNuevo.Visible = False
        tsbAgregar.Visible = False
        tsbGuardar.Visible = False
        tsbEliminar.Visible = False
        lblMensaje.Text = "'"

        lblEstadoCierre.Text = ""

    End Sub

    Private Sub MovimientoNuevo()

        'lblClienteId.Text = ""
        'txtClienteCodigo.Text = ""
        'txtClienteNombre.Text = ""

        lblMovimientoId.Text = ""
        dtpFechaMov.Text = ""
        dtpFechaMov.Text = dtpFechaMov.MaxDate
        dtpFechaMov.Focus()
        lblEstadoCierre.Text = ""

        rbJuego1.Checked = True
        rbJuego2.Checked = False
        rbJuego3.Checked = False
        rbJuego4.Checked = False
        rbJuego5.Checked = False

        cboNroMesa.Items.Clear()
        cboNroMesa.SelectedValue = -1

        rbMoneda1.Checked = False
        rbMoneda2.Checked = False

        txtDrop.Text = ""
        txtWinLoss.Text = ""
        txtApuestaProm.Text = ""

        cboHoraIni.SelectedValue = 0
        cboHoraFin.SelectedValue = 0
        cboMinIni.SelectedValue = 0
        cboMinFin.SelectedValue = 0

        txtDuracionHr.Text = ""

        'dgvMovimientos.DataSource = Nothing
        'dgvMovimientos.Visible = False

        tsbAgregar.Visible = True
        tsbGuardar.Visible = False
        tsbEliminar.Visible = False

        lblMensaje.Text = ""
        'btnCliente.Visible = False

    End Sub

    Private Function ValidarMovimiento() As Integer

        If cboNroMesa.Text.Trim <> "" Then
            Return Util.Enumeracion.enmResultadoOperacion.OK
        Else
            Return Util.Enumeracion.enmResultadoOperacion.NONE
        End If

    End Function

    'Da acceso al boton Eliminar solo a aquellos usarios que tengan configurado este permiso
    Private Function ValidarEliminar() As Boolean
        Try
            If frmLogin.objColeccionFCB.objUsuCfgBEC.Permisos.IndexOfAny(CStr(Util.Enumeracion.enmTipoAccion.Delete)) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub ClienteLeer(ByVal intClienteId As Integer)

        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
        frmLogin.objColeccionFCB.objCliBEC = New BEC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            frmLogin.objColeccionFCB.objCliBEC = frmLogin.objColeccionFCB.objCliDALC.Leer(intClienteId, frmLogin.Unidad)

            If frmLogin.objColeccionFCB.objCliBEC IsNot Nothing Then

                MovimientoNuevo()

                tsbNuevo.Visible = True
                tsbAgregar.Visible = True
                tsbGuardar.Visible = False
                If Me.ValidarEliminar Then tsbEliminar.Visible = True

                With frmLogin.objColeccionFCB.objCliBEC

                    lblClienteId.Text = .ClienteId.ToString

                    txtClienteCodigo.Text = .ClienteCodigo.Trim
                    txtClienteNombre.Text = .ClienteApePat.Trim & IIf(.ClienteApeMat.Trim <> "", " " & .ClienteApeMat.Trim, "") & ", " & .ClienteNombres.Trim

                End With

                MovimientoBuscar()

            Else
                Throw New DataException(Util.Constante.Ope_EscribirERR)
            End If

        Catch ex As Exception

            lblMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objCliDALC = Nothing

        End Try

    End Sub

    Private Sub MovimientoEscribir()

        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
            intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
        Else
            Throw New DataException(Util.Constante.Acc_SesionERR)
        End If

        frmLogin.objColeccionFCB.objMovDALC = New DALC.CLI.clsMovimiento
        frmLogin.objColeccionFCB.objMovBEC = New BEC.CLI.clsMovimiento

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            With frmLogin.objColeccionFCB.objMovBEC

                If lblMovimientoId.Text <> "" Then
                    .MovimientoId = CInt(lblMovimientoId.Text)
                Else
                    .MovimientoId = 0
                End If

                If lblClienteId.Text <> "" Then
                    .ClienteId = Convert.ToInt32(lblClienteId.Text)
                Else
                    .ClienteId = 0
                End If

                .MovimientoFecha = dtpFechaMov.Text
                .TipoJuegoId = IIf(rbJuego1.Checked, 1, IIf(rbJuego2.Checked, 2, IIf(rbJuego3.Checked, 3, IIf(rbJuego4.Checked, 4, 5))))
                .MovimientoNroMesa = cboNroMesa.SelectedItem.ToString
                .MovimientoMonedaId = IIf(rbMoneda1.Checked, 1, 2)
                .MovimientoDrop = IIf(txtDrop.Text <> "", txtDrop.Text, 0)
                .MovimientoWinLoss = IIf(txtWinLoss.Text <> "", txtWinLoss.Text, 0)
                .MovimientoApuestaProm = IIf(txtApuestaProm.Text <> "", txtApuestaProm.Text, 0)

                .MovimientoHoraIni = cboHoraIni.Text & ":" & cboMinIni.Text
                .MovimientoHoraFin = cboHoraFin.Text & ":" & cboMinFin.Text

                If txtDuracionHr.Text.Trim <> "" Then
                    If IsNumeric(txtDuracionHr.Text.Trim) Then .MovimientoDuracionHr = Math.Round(Convert.ToDecimal(txtDuracionHr.Text) / 60, 2)
                Else
                    .MovimientoDuracionHr = 0
                End If


                If boolElimiar Then
                    .MovimientoEstadoId = Util.Enumeracion.enmResultadoOperacion.NONE
                Else
                    .MovimientoEstadoId = Util.Enumeracion.enmResultadoOperacion.OK
                End If

                .AudCreac_UsuarioId = intUsuarioId

                intResultado = frmLogin.objColeccionFCB.objMovDALC.Escribir(frmLogin.objColeccionFCB.objMovBEC, frmLogin.Unidad)

                If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

                    lblMensaje.Text = Util.Constante.Ope_EscribirOK

                    If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                        ' Pista de Auditoría:
                        Select Case lblMovimientoId.Text
                            Case Is > 0
                                If boolElimiar Then
                                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Delete, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                                    boolElimiar = False
                                Else
                                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                                End If
                            Case Else
                                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                        End Select

                        frmLogin.objColeccionFCB.objAuditoria = Nothing
                        ' Fin de Auditoría
                    End If

                    lblMovimientoId.Text = frmLogin.objColeccionFCB.objMovBEC.MovimientoId.ToString

                    MovimientoBuscar()

                Else
                    Throw New DataException(Util.Constante.Ope_EscribirERR)
                End If

            End With

        Catch ex As Exception
            lblMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objMovDALC = Nothing

        End Try

    End Sub

    Private Sub MovimientoBuscar()

        frmLogin.objColeccionFCB.objMovDALC = New DALC.CLI.clsMovimiento

        Dim arrParam As New ArrayList
        Dim arrResultado As IList

        Try
            arrParam.Add(lblClienteId.Text)

            arrResultado = frmLogin.objColeccionFCB.objMovDALC.Buscar(arrParam, frmLogin.Unidad)

            If arrResultado IsNot Nothing Then
                dgvMovimientos.DataSource = arrResultado
                dgvMovimientos.Visible = True
                If Me.ValidarEliminar Then tsbEliminar.Visible = True

                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)
                Dim intLimiteRegistros As Integer = Configuration.ConfigurationManager.AppSettings("FJM_LimiteRegistros")
                If arrResultado.Count >= intLimiteRegistros Then lblMensaje.Text &= Replace(Util.Constante.Msj_LimiteRegistros, "XX", intLimiteRegistros)

                'dgvClientes.Focus()
            Else
                'dgvMovimientos.DataSource = Nothing
                dgvMovimientos.Visible = False
                tsbEliminar.Visible = False
                lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

        Catch ex As Exception
            lblMensaje.Text = Util.Constante.Ope_BuscarERR & " - " & ex.Message

        Finally
            frmLogin.objColeccionFCB.objMovDALC = Nothing
        End Try

    End Sub

    Private Sub MovimientoLeer(ByVal intMovimientoId As Integer)

        frmLogin.objColeccionFCB.objMovDALC = New DALC.CLI.clsMovimiento
        frmLogin.objColeccionFCB.objMovBEC = New BEC.CLI.clsMovimiento

        Try
            frmLogin.objColeccionFCB.objMovBEC = frmLogin.objColeccionFCB.objMovDALC.Leer(intMovimientoId, frmLogin.Unidad)

            With frmLogin.objColeccionFCB.objMovBEC

                lblMovimientoId.Text = .MovimientoId
                'lblClienteId.Text = .ClienteId

                dtpFechaMov.Text = .MovimientoFecha

                rbJuego1.Checked = False
                rbJuego2.Checked = False
                rbJuego3.Checked = False
                rbJuego4.Checked = False
                rbJuego5.Checked = False

                Select Case .TipoJuegoId
                    Case 1
                        rbJuego1.Checked = True
                    Case 2
                        rbJuego2.Checked = True
                    Case 3
                        rbJuego3.Checked = True
                    Case 4
                        rbJuego4.Checked = True
                    Case 5
                        rbJuego5.Checked = True
                End Select

                rbMoneda1.Checked = False
                rbMoneda2.Checked = False

                Select Case .MovimientoMonedaId
                    Case 1
                        rbMoneda1.Checked = True
                    Case 2
                        rbMoneda2.Checked = True
                End Select

                cboNroMesa.SelectedIndex = cboNroMesa.FindString(.MovimientoNroMesa)
                'cboNroMesa.SelectedText = .MovimientoNroMesa

                txtDrop.Text = .MovimientoDrop
                txtWinLoss.Text = .MovimientoWinLoss
                txtApuestaProm.Text = .MovimientoApuestaProm

                cboHoraIni.SelectedIndex = cboHoraIni.FindString(Mid(.MovimientoHoraIni, 1, 2))
                cboMinIni.SelectedIndex = cboMinIni.FindString(Mid(.MovimientoHoraIni, 4, 2))
                cboHoraFin.SelectedIndex = cboHoraFin.FindString(Mid(.MovimientoHoraFin, 1, 2))
                cboMinFin.SelectedIndex = cboMinFin.FindString(Mid(.MovimientoHoraFin, 4, 2))
                txtDuracionHr.Text = (.MovimientoDuracionHr * 60).ToString

            End With

            tsbAgregar.Visible = False
            tsbGuardar.Visible = True
            If Me.ValidarEliminar Then tsbEliminar.Visible = True


            'Evaluar si hay cierre, para habilitar el botón "Guardar"
            objDALC = New DALC.CLI.clsReporte
            arrFiltros = New ArrayList
            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

            With arrFiltros
                .Add(dtpFechaMov.Text)
            End With

            intResultado = objDALC.PuntajeHayCierre(arrFiltros, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                'pbGuardarMov.Visible = False
                lblEstadoCierre.Text = arrFiltros(0) & ": " & Util.Constante.FCB_ProcesoCierre_OK
            Else
                'pbGuardarMov.Visible = True
                lblEstadoCierre.Text = ""
            End If

        Catch ex As Exception
            lblMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objMovDALC = Nothing
        End Try


    End Sub

    Private Sub SetNroMesas(ByVal objRadio As RadioButton)

        If objRadio IsNot Nothing Then
            cboNroMesa.Items.Clear()
            rbMoneda1.Checked = False
            rbMoneda2.Checked = False

            For k As Integer = 0 To Convert.ToInt16(objRadio.Tag) - 1
                cboNroMesa.Items.Add(New BEC.COM.clsItem(k + 1, (k + 1).ToString("00")))
            Next

        End If

        cboNroMesa.SelectedIndex = -1

    End Sub

    Private Sub LeerMesas()
        Dim objDALC As New DALC.FJM.clsMesa

        arrMesas = New ArrayList
        arrMesas = objDALC.Listar(frmLogin.Unidad)

    End Sub

#End Region

    Private Sub frmMovimientoReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODFPC)
        LoadControls()
        
        boolElimiar = False

        If frmLogin.objColeccionFCB.objCliBEC.ClienteId <> 0 Then
            ClienteLeer(frmLogin.objColeccionFCB.objCliBEC.ClienteId)
            tsbBuscar.Visible = False
        End If

    End Sub

    Private Sub pbAgregarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValidarMovimiento() Then
            MovimientoEscribir()
        Else
            lblMensaje.Text = Util.Constante.Msj_SinDatos
        End If
    End Sub

    'Private Sub dgvMovimientos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovimientos.CellContentClick

    'End Sub

    Private Sub dgvMovimientos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovimientos.RowEnter
        Try
            Dim intFilaSel As Integer = e.RowIndex
            Dim intMovId As Integer = dgvMovimientos.Rows(intFilaSel).Cells("MovimientoId").Value

            MovimientoLeer(intMovId)
            tsbAgregar.Visible = False
            tsbGuardar.Visible = True
            If Me.ValidarEliminar Then tsbEliminar.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbJuego1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJuego1.CheckedChanged
        SetNroMesas(rbJuego1)
    End Sub

    Private Sub rbJuego2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJuego2.CheckedChanged
        SetNroMesas(rbJuego2)
    End Sub

    Private Sub rbJuego3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJuego3.CheckedChanged
        SetNroMesas(rbJuego3)
    End Sub

    Private Sub rbJuego4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJuego4.CheckedChanged
        SetNroMesas(rbJuego4)
    End Sub

    Private Sub rbJuego5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJuego5.CheckedChanged
        SetNroMesas(rbJuego5)
    End Sub

    Private Sub pbGuardarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValidarMovimiento() Then
            lblMensaje.Text = Util.Constante.Ope_EnProceso
            MovimientoEscribir()
        Else
            lblMensaje.Text = Util.Constante.Msj_SinDatos
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub pbVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ValidarSoloNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDrop.KeyPress, txtWinLoss.KeyPress, txtApuestaProm.KeyPress, txtDuracionHr.KeyPress, txtDuracionHr.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = Asc(".") Or Asc(e.KeyChar) = Asc("-") Or Asc(e.KeyChar) = Asc(Chr(8)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If sender.Equals(txtDuracionHr) Then
            If e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab) Then e.Handled = True : dtpFechaMov.Focus()
        Else
            If e.KeyChar = ChrW(Keys.Enter) Then e.Handled = True : SendKeys.Send("{TAB}")

        End If

    End Sub


    'Private Sub txtDuracionHoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuracionHr.KeyPress
    '    If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = Asc(".") Or Asc(e.KeyChar) = Asc("-") Or Asc(e.KeyChar) = Asc(Chr(8)) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = ChrW(Keys.Enter) Then e.Handled = True : dtpFechaMov.Focus()
    'End Sub


    Private Sub CambiarCampo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClienteNombre.KeyPress, rbJuego1.KeyPress, rbJuego2.KeyPress, rbJuego3.KeyPress, rbJuego4.KeyPress, rbJuego5.KeyPress, cboNroMesa.KeyPress, dtpFechaMov.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then e.Handled = True : SendKeys.Send("{TAB}")

    End Sub

    Private Sub CalcularDuracionHr(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHoraIni.SelectedIndexChanged, cboHoraFin.SelectedIndexChanged, cboMinIni.SelectedIndexChanged, cboMinFin.SelectedIndexChanged

        Dim intHoraIni, intHoraFin, intMinIni, intMinFin As Integer
        Dim datHoraIni As DateTime = Now
        Dim datHoraFin As DateTime = Now
        Dim datHoraDif As TimeSpan

        intHoraIni = cboHoraIni.SelectedValue
        intMinIni = cboMinIni.SelectedValue
        intHoraFin = cboHoraFin.SelectedValue
        intMinFin = cboMinFin.SelectedValue

        datHoraIni = datHoraIni.AddHours(intHoraIni)
        datHoraIni = datHoraIni.AddMinutes(intMinIni)

        datHoraFin = datHoraFin.AddHours(intHoraFin)
        datHoraFin = datHoraFin.AddMinutes(intMinFin)

        datHoraDif = ((datHoraFin - datHoraIni)).Duration
        txtDuracionHr.Text = datHoraDif.TotalMinutes.ToString("0.00")

    End Sub

    Private Sub ActualizarHoraFin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDuracionHr.LostFocus
        Dim intHoraIni, intMinIni As Integer
        Dim datHoraFin As DateTime
        Dim intMinDif As Decimal

        If txtDuracionHr.Text.Trim <> "" Then

            intMinDif = Convert.ToDecimal(txtDuracionHr.Text.Trim)
            intHoraIni = cboHoraIni.SelectedValue
            intMinIni = cboMinIni.SelectedValue

            datHoraFin = datHoraFin.AddHours(intHoraIni + Util.Factory.FCB_HorarioAtencionIni)
            datHoraFin = datHoraFin.AddMinutes(intMinIni)

            datHoraFin = datHoraFin.AddMinutes(intMinDif)

            cboHoraFin.SelectedIndex = cboHoraFin.FindString(datHoraFin.Hour.ToString("00"))
            cboMinFin.SelectedIndex = cboMinFin.FindString(datHoraFin.Minute.ToString("00"))

        End If

        dtpFechaMov.Focus()

    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            'frmSplash.objCliBus.ShowDialog()
            'Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
            'If uni = 0 Then
            '    frmLogin.objCliBus = New frmClienteBuscar
            '    frmLogin.objCliBus.ShowDialog()

            '    If frmLogin.objCliBus.intClienteId > 0 Then
            '        ClienteLeer(frmLogin.objCliBus.intClienteId)

            '        'dtpFechaMov.Text = Now.Date.ToShortDateString
            '        'dtpFechaMov.Focus()
            '        gbTipoJuego.Focus()

            '    End If
            'Else
            '    frmLogin.objCliBus2 = New frmClienteBuscarL
            '    frmLogin.objCliBus2.ShowDialog()

            '    If frmLogin.objCliBus2.intClienteId > 0 Then
            '        ClienteLeer(frmLogin.objCliBus2.intClienteId)
            '        gbTipoJuego.Focus()
            '    End If
            'End If

            'Select Case frmLogin.Unidad
            '    Case "FIESTA CASINO BENAVIDES"
            frmLogin.objCliBus = New frmClienteBuscar
            frmLogin.objCliBus.ShowDialog()

            If frmLogin.objCliBus.intClienteId > 0 Then
                ClienteLeer(frmLogin.objCliBus.intClienteId)
                gbTipoJuego.Focus()
            End If

            '    Case "LUXOR LIMA CASINO"
            'frmLogin.objCliBus2 = New frmClienteBuscarL
            'frmLogin.objCliBus2.ShowDialog()

            'If frmLogin.objCliBus2.intClienteId > 0 Then
            '    ClienteLeer(frmLogin.objCliBus2.intClienteId)
            '    gbTipoJuego.Focus()
            'End If

            '    Case "LUXOR TACNA"
            'frmLogin.objCliBus3 = New frmClienteBuscarT
            'frmLogin.objCliBus3.ShowDialog()

            'If frmLogin.objCliBus3.intClienteId > 0 Then
            '    ClienteLeer(frmLogin.objCliBus3.intClienteId)
            '    gbTipoJuego.Focus()
            'End If
            'End Select

        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        MovimientoNuevo()
    End Sub

    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click

        Dim i As Integer = MsgBox(Util.Constante.Msg_ConfAgregar, MsgBoxStyle.YesNo)
        If i <> 6 Then Exit Sub

        If ValidarMovimiento() Then
            MovimientoEscribir()
        Else
            lblMensaje.Text = Util.Constante.Msj_SinDatos
        End If
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim i As Integer = MsgBox(Util.Constante.Msg_ConfAgregar, MsgBoxStyle.YesNo)
        If i <> 6 Then Exit Sub

        If ValidarMovimiento() Then
            lblMensaje.Text = Util.Constante.Ope_EnProceso
            MovimientoEscribir()
        Else
            lblMensaje.Text = Util.Constante.Msj_SinDatos
        End If
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Dim i As Integer = MsgBox(Util.Constante.Msg_ConfEliminar, MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo)
        If i <> 6 Then Exit Sub

        If ValidarMovimiento() Then
            lblMensaje.Text = Util.Constante.Ope_EnProceso
            boolElimiar = True
            MovimientoEscribir()
        Else
            lblMensaje.Text = Util.Constante.Msj_SinDatos
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objCliCRM As New frmClienteRegistro(frmLogin.objColeccionFCB.objCliBEC)
        objCliCRM.ShowDialog()
    End Sub

    Private Sub cboNroMesa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNroMesa.SelectedIndexChanged
        Dim objBEC As BEC.FJM.clsMesa
        Dim intTipoJuegoId As Integer = 0

        If cboNroMesa.SelectedIndex > -1 Then

            If rbJuego1.Checked Then intTipoJuegoId = Util.Enumeracion.enmFJMTipoJuegoMesa.Ruleta
            If rbJuego2.Checked Then intTipoJuegoId = Util.Enumeracion.enmFJMTipoJuegoMesa.BlackJack
            If rbJuego3.Checked Then intTipoJuegoId = Util.Enumeracion.enmFJMTipoJuegoMesa.Poker
            If rbJuego4.Checked Then intTipoJuegoId = Util.Enumeracion.enmFJMTipoJuegoMesa.TexasHoldemPoker
            If rbJuego5.Checked Then intTipoJuegoId = Util.Enumeracion.enmFJMTipoJuegoMesa.PokerBacarat

            For k As Integer = 0 To arrMesas.Count - 1
                objBEC = New BEC.FJM.clsMesa
                objBEC = CType(arrMesas(k), BEC.FJM.clsMesa)

                Me.rbMoneda1.Checked = False
                Me.rbMoneda2.Checked = False

                If objBEC.TipoJuegoId = intTipoJuegoId And objBEC.NroMesa = CType(cboNroMesa.SelectedItem, BEC.COM.clsItem).ItemNombre Then

                    Select Case objBEC.MonedaId
                        Case Util.Enumeracion.enmMoneda.Moneda_Soles
                            Me.rbMoneda1.Checked = True
                        Case Util.Enumeracion.enmMoneda.Moneda_Dolar
                            Me.rbMoneda2.Checked = True
                    End Select
                    Exit For

                End If

            Next
        End If

    End Sub

End Class