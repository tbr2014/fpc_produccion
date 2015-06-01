Imports bddc.Win.BDClientesDataSetTableAdapters

Public Class frmCajaRegistroOperador

#Region "Atributos"
    Private arrResultado As IList
    Private objHorario As Util.clsHorario
#End Region

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try

            'Control Fecha:
            ucFechaProceso.TipoTurno(Util.Enumeracion.enmFCBTipoTurno.Cajas)
            ucFechaProceso.IngresarFecha(False)
            ucFechaProceso.UsarCalendario(False)
            ucFechaProceso.Aplicar()

            arrResultados = objDL.Seleccionar("7,26", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                cboMontoMoneda.Items.Clear()
                cboCaja.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.TipoMoneda
                            Me.cboMontoMoneda.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))

                        Case Util.Enumeracion.enmGrupoParametro.FCB_CajayConteo_Cajas
                            Me.cboCaja.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                    End Select
                Next
            End If

            'cboFichaVenta.Items.Clear()
            'cboFichaVenta.Items.Add(New BEC.COM.clsItem(Util.Enumeracion.enmMoneda.Moneda_Dolar, 1000))

        Catch ex As Exception
            Me.tssMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub RegistroNuevo()

        tsbGuardar.Visible = True

        gbSeccion1.Enabled = True
        gbSeccion2.Enabled = True

        lblOperacionCodigo.Text = ""
        cboMontoMoneda.SelectedItem = cboMontoMoneda.Items(0)
        txtMontoImporte.Text = ""
        rbModalidadOperacion1.Checked = False
        rbModalidadOperacion2.Checked = False
        rbModalidadOperacion3.Checked = False
        rbTipoOperacion1.Checked = False
        rbTipoOperacion2.Checked = False
        rbTipoOperacion3.Checked = False
        rbTipoOperacion4.Checked = False
        rbTipoOperacion5.Checked = False
        rbTipoOperacion6.Checked = False

        'cboFichaVenta.SelectedItem = cboFichaVenta.Items(0)
        txtFichaCantidad.Enabled = False
        txtFichaCantidad.Text = ""
        txtTarjetaNum.Enabled = False
        txtTarjetaNum.Text = ""
        lblClienteId.Text = ""
        txtJackpotMaquina.Enabled = False
        txtJackpotMaquina.Text = ""

        ClienteNuevo()

        tssMensaje.Text = "Nuevo Registro"
    End Sub

    Private Sub ClienteNuevo()

        txtClienteApellidos.Text = ""
        txtClienteNombres.Text = ""
        txtClienteNumDoc.Text = ""
        txtClientePais.Text = ""
        txtClienteNacionalidad.Text = ""
        txtClienteDireccion.Text = ""
        txtClienteDireccionNro.Text = ""
        txtClienteDireccionInt.Text = ""
        txtClienteDireccionUrb.Text = ""
        txtClienteDireccionDist.Text = ""
        txtClienteDireccionProv.Text = ""
        txtClienteDireccionDpto.Text = ""

    End Sub

    Private Sub ClienteLeer(ByVal intClienteId As Integer)

        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
        frmLogin.objColeccionFCB.objCliBEC = New BEC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            frmLogin.objColeccionFCB.objCliBEC = frmLogin.objColeccionFCB.objCliDALC.Leer(intClienteId, frmLogin.Unidad)

            If frmLogin.objColeccionFCB.objCliBEC IsNot Nothing Then

                ClienteNuevo()

                With frmLogin.objColeccionFCB.objCliBEC

                    lblClienteId.Text = .ClienteId.ToString

                    txtClienteApellidos.Text = .ClienteApePat.Trim & IIf(.ClienteApeMat.Trim <> "", " " & .ClienteApeMat.Trim, "")
                    txtClienteNombres.Text = .ClienteNombres.Trim
                    txtClienteNumDoc.Text = .ClienteTipoDoc & " " & .ClienteNumDoc.Trim

                    txtClienteNacionalidad.Text = .ClienteNacionalidad.Trim
                    txtClientePais.Text = .DomicilioPais.Trim

                    txtClienteDireccion.Text = .DomicilioDireccion.Trim
                    txtClienteDireccionDist.Text = .DomicilioCiudad.Trim
                    txtClienteDireccionNro.Text = ""
                    txtClienteDireccionInt.Text = ""
                    txtClienteDireccionUrb.Text = ""
                    txtClienteDireccionDist.Text = ""
                    txtClienteDireccionProv.Text = ""
                    txtClienteDireccionDpto.Text = ""

                End With

            Else
                Throw New DataException(Util.Constante.Ope_EscribirERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objCliDALC = Nothing

        End Try

    End Sub

    Private Function RegistroValidar() As Boolean

        Try
            Dim objDALC As New DALC.COM.clsTipoCambio

            Dim arrResultados As IList

            If Not cboCaja.SelectedIndex > -1 Or cboCaja.Text = "" Then Throw New DataException("Seleccione Caja!")
            If Not cboMontoMoneda.SelectedIndex > -1 Then Throw New DataException("Seleccione moneda!")
            If Not txtMontoImporte.Text.Trim <> "" Then Throw New DataException("No hay monto de la operación!")
            If Not Convert.ToDecimal(txtMontoImporte.Text) <> 0 Then Throw New DataException("Ingresar monto válido de la operación!")
            If Not rbModalidadOperacion1.Checked And Not rbModalidadOperacion2.Checked And Not rbModalidadOperacion3.Checked Then Throw New DataException("Seleccione Modalidad de la operación!")

            If rbModalidadOperacion2.Checked Or rbModalidadOperacion3.Checked Then
                If Not rbtnVisa.Checked And Not rbtnMastercad.Checked Then Throw New DataException("Seleccione el tipo de tarjeta!")

                Dim NumTarjeta As String
                NumTarjeta = txtTarjetaNum.Text
                If NumTarjeta.CompareTo("    -    -    -") = 0 Then Throw New DataException("Ingrese el N° de la Tajerta!")

            End If

            If rbTipoOperacion1.Checked = rbTipoOperacion2.Checked = rbTipoOperacion3.Checked = rbTipoOperacion4.Checked = rbTipoOperacion5.Checked = rbTipoOperacion6.Checked And rbTipoOperacion6.Checked = False Then Throw New DataException("Seleccione Tipo de operación!")

            If rbTipoOperacion1.Checked Then
                If txtFichaCantidad.Text.CompareTo("") = 0 Then
                    Throw New DataException("Ingrese el No. ficha(s)!")
                End If
                If cboFichaVenta.SelectedIndex < 0 Then
                    Throw New DataException("Seleccione el tipo de ficha(s)!")
                End If
            End If

            If rbTipoOperacion5.Checked Then
                If txtJackpotMaquina.Text.CompareTo("") = 0 Then
                    Throw New DataException("Ingrese la Máquina!")
                End If
            End If
            If Not lblClienteId.Text <> "" Then Throw New DataException("Seleccione Cliente!")

            If frmLogin.objColeccionFCB.objUsuUndBEC IsNot Nothing Then
                If frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId = 0 Then Throw New DataException("Sin Unidad de Negocio!")
            Else
                Throw New DataException("Error del Sistema: Objeto sin instancia!")
            End If

            Dim moneda As String
            moneda = cboMontoMoneda.SelectedItem.ToString

            If moneda.CompareTo("S/.") = 0 Then
                Dim dt As New DataTable

                Select Case frmLogin.Unidad

                    Case "FIESTA CASINO BENAVIDES"
                        Dim cambio As Fiesta_tblaux_tipocambioTableAdapter
                        cambio = New Fiesta_tblaux_tipocambioTableAdapter()
                        Dim tasa As String

                        dt = cambio.GetCambioByDate
                        tasa = dt.Rows.Item(0).Item("Tasa").ToString()

                        Dim monto As Double
                        Dim MontoMax As Double
                        Dim cmbio As Double

                        If Double.TryParse(tasa, cmbio) Then
                            MontoMax = 2500 * cmbio
                        End If

                        If Double.TryParse(txtMontoImporte.Text, monto) Then
                            If monto > MontoMax Then
                                If txtClienteDireccion.Text.CompareTo("") = 0 Then
                                    Throw New DataException("Para todo monto mayor de S/. " & MontoMax & " se debe tener la dirección del cliente!")
                                End If
                            End If
                        End If

                    Case "LUXOR LIMA CASINO"
                        Dim cambio As Luxor_tblaux_tipocambioTableAdapter
                        cambio = New Luxor_tblaux_tipocambioTableAdapter()

                        Dim tasa As String

                        dt = cambio.GetCambioByDate
                        tasa = dt.Rows.Item(0).Item("Tasa").ToString()

                        Dim monto As Double
                        Dim MontoMax As Double
                        Dim cmbio As Double

                        If Double.TryParse(tasa, cmbio) Then
                            MontoMax = 2500 * cmbio
                        End If

                        If Double.TryParse(txtMontoImporte.Text, monto) Then
                            If monto > MontoMax Then
                                If txtClienteDireccion.Text.CompareTo("") = 0 Then
                                    Throw New DataException("Para todo monto mayor de S/. " & MontoMax & " se debe tener la dirección del cliente!")
                                End If
                            End If
                        End If

                    Case "LUXOR TACNA"

                        Dim rate As Tacna_tblaux_tipocambioTableAdapter
                        rate = New Tacna_tblaux_tipocambioTableAdapter()

                        'Dim cambioTacna As Tacna_tblaux_tipocambioTableAdapter
                        'cambioTacna = New Tacna_tblaux_tipocambioTableAdapter()

                        dt = rate.GetCambioByDate

                        Dim tasa As String
                        'Dim cambio As Decimal
                        'cambio = objDALC.Leer(frmLogin.Unidad)

                        tasa = dt.Rows.Item(0).Item("Tasa").ToString()
                        'tasa = cambio.ToString()
                        Dim monto As Double
                        Dim MontoMax As Double
                        Dim cmbio As Double

                        If Double.TryParse(tasa, cmbio) Then
                            MontoMax = 2500 * cmbio
                        End If

                        If Double.TryParse(txtMontoImporte.Text, monto) Then
                            If monto > MontoMax Then
                                If txtClienteDireccion.Text.CompareTo("") = 0 Then
                                    Throw New DataException("Para todo monto mayor de S/. " & MontoMax & " se debe tener la dirección del cliente!")
                                End If
                            End If
                        End If
                End Select



                'Dim cambio As TipoCambioTableAdapter
                'cambio = New TipoCambioTableAdapter()


            End If

            If moneda.CompareTo("US$") = 0 Then
                Dim monto As Double
                If Double.TryParse(txtMontoImporte.Text, monto) Then
                    If monto > 2500 Then
                        If txtClienteDireccion.Text.CompareTo("") = 0 Then
                            Throw New DataException("Para todo monto mayor de $2500 se debe tener la dirección del cliente!")
                        End If
                    End If
                End If
            End If

            Return True

        Catch ex As Exception
            tssMensaje.Text = ex.Message
            Return False
        End Try
    End Function

    Private Sub RegistroEscribir()

        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim objBEC As New BEC.FCB.clsOperacionCaja
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
            intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
        Else
            Throw New DataException(Util.Constante.Acc_SesionERR)
        End If

        With objBEC
            .OperacionCajaId = 0
            .OperacionCodigo = ""
            .OperacionFecha = ucFechaProceso.txtFecha.Text
            .OperacionHora = Convert.ToString(Now().Hour) & ":" & Convert.ToString(Now().Minute)
            .SujetoObligado = ""
            .OficialCumplimiento = ""
            .OperacionMontoMonedaId = CType(cboMontoMoneda.SelectedItem, BEC.COM.clsItem).ItemId
            .OperacionMontoImporte = Convert.ToDecimal(txtMontoImporte.Text)

            Dim intModalidadId As Integer = 0
            If rbModalidadOperacion1.Checked Then intModalidadId = Util.Enumeracion.enmFCBCajaModalidadOperacion.Efectivo
            If rbModalidadOperacion2.Checked Then intModalidadId = Util.Enumeracion.enmFCBCajaModalidadOperacion.TarjetaCredito
            If rbModalidadOperacion3.Checked Then intModalidadId = Util.Enumeracion.enmFCBCajaModalidadOperacion.TarjetaDebito
            .OperacionModalidadId = intModalidadId

            Dim TipoTarjeta As Integer = 0

            If intModalidadId > 1 Then
                If rbtnVisa.Checked Then TipoTarjeta = Util.Enumeracion.enmFCBCajaOperacionTipoTarjeta.Visa
                If rbtnMastercad.Checked Then TipoTarjeta = Util.Enumeracion.enmFCBCajaOperacionTipoTarjeta.Mastercard
                .TipoTarjetaCred = TipoTarjeta
                .OperacionModalidadId = Integer.Parse(intModalidadId.ToString() + TipoTarjeta.ToString())
            End If

            Dim intTipoId As Integer = 0
            If rbTipoOperacion1.Checked Then intTipoId = Util.Enumeracion.enmFCBCajaTipoOperacion.CanjeDineroxFichas
            If rbTipoOperacion2.Checked Then intTipoId = Util.Enumeracion.enmFCBCajaTipoOperacion.CanjeFichasxDinero
            If rbTipoOperacion3.Checked Then intTipoId = Util.Enumeracion.enmFCBCajaTipoOperacion.CanjeTicketsSlots
            If rbTipoOperacion4.Checked Then intTipoId = Util.Enumeracion.enmFCBCajaTipoOperacion.CanjeTicketsxFichas
            If rbTipoOperacion5.Checked Then intTipoId = Util.Enumeracion.enmFCBCajaTipoOperacion.CobroPremioJackpot
            If rbTipoOperacion6.Checked Then intTipoId = Util.Enumeracion.enmFCBCajaTipoOperacion.RetiroEfectivo
            .OperacionTipoId = intTipoId

            .OperacionTarjetaNum = IIf(txtTarjetaNum.Enabled, txtTarjetaNum.Text.Trim, "")

            If txtFichaCantidad.Text.Trim <> "" Then
                .OperacionFichaCantidad = txtFichaCantidad.Text
                .OperacionFichaDenominacion = CType(cboFichaVenta.SelectedItem, BEC.COM.clsItem).ItemNombre
            Else
                .OperacionFichaCantidad = 0
                .OperacionFichaDenominacion = 0
            End If

            If rbtnDolar.Checked = True Then
                .OperacionFichaMoneda = "US$"
            End If
            If rbtnSoles.Checked = True Then
                .OperacionFichaMoneda = "S/."
            End If

            .OperacionMaquinaNum = txtJackpotMaquina.Text

            .ClienteId = lblClienteId.Text
            .OperacionCaja = CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre

            .EstadoId = Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.OK)
            .AudCreac_UsuarioId = intUsuarioId
            .UnidadId = frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId

        End With

        intResultado = objDALC.Escribir(objBEC, frmLogin.Unidad)

        If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                ' Pista de Auditoría:
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODCYC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                frmLogin.objColeccionFCB.objAuditoria = Nothing
                ' Fin de Auditoría
            End If

            tssMensaje.Text = Util.Constante.Ope_EscribirOK
            'MsgBox(Util.Constante.Ope_EscribirOK, MsgBoxStyle.Information, Util.Constante.Msj_SistemaTitulo)
            lblOperacionCodigo.Text = objBEC.OperacionCodigo

            gbSeccion1.Enabled = False
            gbSeccion2.Enabled = False
            'gbSeccion3.Enabled = False
            'RegistroNuevo()
        Else
            tssMensaje.Text = Util.Constante.Ope_EscribirERR
        End If

    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub frmCajaRegistroOperador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LeerParametros()
        'LeerClientes()
        RegistroNuevo()
    End Sub

    Private Sub btnClienteBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClienteBuscar.Click
        Try
            Select Case frmLogin.Unidad
                Case "FIESTA CASINO BENAVIDES"
                    frmLogin.objCliBus = New frmClienteBuscar
                    frmLogin.objCliBus.ShowDialog()

                    If frmLogin.objCliBus.intClienteId > 0 Then
                        lblClienteId.Text = frmLogin.objCliBus.intClienteId
                        ClienteLeer(lblClienteId.Text) 'Cargar datos
                    End If

                Case "LUXOR LIMA CASINO"
                    frmLogin.objCliBus2 = New frmClienteBuscarL
                    frmLogin.objCliBus2.ShowDialog()

                    If frmLogin.objCliBus2.intClienteId > 0 Then
                        lblClienteId.Text = frmLogin.objCliBus2.intClienteId
                        ClienteLeer(lblClienteId.Text) 'Cargar datos
                    End If

                Case "LUXOR TACNA"
                    frmLogin.objCliBus3 = New frmClienteBuscarT
                    frmLogin.objCliBus3.ShowDialog()

                    If frmLogin.objCliBus3.intClienteId > 0 Then
                        lblClienteId.Text = frmLogin.objCliBus3.intClienteId
                        ClienteLeer(lblClienteId.Text) 'Cargar datos
                    End If

                Case "EMPRESA DE PRUEBA"
                    frmLogin.objCliBus = New frmClienteBuscar
                    frmLogin.objCliBus.ShowDialog()

                    If frmLogin.objCliBus.intClienteId > 0 Then
                        lblClienteId.Text = frmLogin.objCliBus.intClienteId
                        ClienteLeer(lblClienteId.Text) 'Cargar datos
                    End If
            End Select


        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub btnClienteNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClienteNuevo.Click
        Dim objFrm As New frmClienteRegistro
        objFrm.ShowDialog()
        objFrm.Dispose()


        If (objFrm.ClienteId > 0) Then

            lblClienteId.Text = String.Empty
            lblClienteId.Text = objFrm.ClienteId
            ClienteLeer(lblClienteId.Text)

        End If
        tssMensaje.Text = Util.Constante.Msj_SistemaTitulo

    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        'txtBuscarCliente.SelectedIndex = -1
        'txtBuscarCliente.Text = ""

        RegistroNuevo()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub SoloNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoImporte.KeyPress, txtClienteNumDoc.KeyPress, txtFichaCantidad.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Asc(".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rbModalidadOperacion1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbModalidadOperacion1.CheckedChanged, rbtnVisa.CheckedChanged, rbtnMastercad.CheckedChanged, rbModalidadOperacion3.CheckedChanged, rbModalidadOperacion2.CheckedChanged
        If rbModalidadOperacion1.Checked Then
            txtTarjetaNum.Enabled = False
            rbtnMastercad.Enabled = False
            rbtnVisa.Enabled = False
            rbtnMastercad.Checked = False
            rbtnVisa.Checked = False
        Else
            txtTarjetaNum.Enabled = True
            rbtnMastercad.Enabled = True
            rbtnVisa.Enabled = True
        End If
    End Sub

    Private Sub rbTipoOperacion1y2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTipoOperacion2.CheckedChanged, rbTipoOperacion1.CheckedChanged
        If rbTipoOperacion1.Checked = True Then
            txtFichaCantidad.Enabled = True
            rbtnDolar.Enabled = True
            rbtnSoles.Enabled = True
        Else
            txtFichaCantidad.Enabled = False
            rbtnDolar.Enabled = False
            rbtnSoles.Enabled = False
        End If
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If RegistroValidar() Then
            If MsgBox(Util.Constante.Msg_ConfAgregar, MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) = MsgBoxResult.No Then
                Exit Sub
            Else
                RegistroEscribir()
            End If
        End If

    End Sub

    Private Sub rbtnDolar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDolar.CheckedChanged
        If rbtnDolar.Checked = True Then
            cboFichaVenta.Items.Clear()
            cboFichaVenta.Items.Add(New BEC.COM.clsItem(Util.Enumeracion.enmMoneda.Moneda_Dolar, 1000))
            cboFichaVenta.SelectedItem = cboFichaVenta.Items(0)
            cboFichaVenta.Enabled = False
            'txtFichaCantidad.Enabled = True
        End If
    End Sub

    Private Sub rbtnSoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSoles.CheckedChanged
        If rbtnSoles.Checked = True Then
            cboFichaVenta.Items.Clear()
            cboFichaVenta.Items.Add(New BEC.COM.clsItem(Util.Enumeracion.enmMoneda.Moneda_Soles, 1000))
            cboFichaVenta.Items.Add(New BEC.COM.clsItem(Util.Enumeracion.enmMoneda.Moneda_Soles, 500))
            cboFichaVenta.SelectedItem = cboFichaVenta.Items(0)
            cboFichaVenta.Enabled = True
            'txtFichaCantidad.Enabled = True
        End If
    End Sub

    Private Sub rbTipoOperacion5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTipoOperacion5.CheckedChanged
        If rbTipoOperacion5.Checked = True Then
            txtJackpotMaquina.Enabled = True
        Else
            txtJackpotMaquina.Enabled = False
        End If
    End Sub
#End Region






End Class