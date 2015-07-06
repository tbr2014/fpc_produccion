Public Class frmCajaReportes

#Region "Atributos"
    Private Shared objBEC As BEC.CLI.clsCliente
    Private objHorario As Util.clsHorario
    Private arrResultado As IList
    Private arrBusqueda As IList
    Public varClienteId As Integer
#End Region

#Region "Operaciones"

    Private Sub ClienteBuscar()
        Try
            'Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
            'If uni = 0 Then
            Dim objfrm As New frmClienteBuscar

            objfrm.ShowDialog()

            If objfrm.intClienteId > 0 Then
                objBEC = New BEC.CLI.clsCliente
                objBEC.ClienteId = objfrm.intClienteId
                ClienteLeer(objBEC.ClienteId)
            End If
            'Else
            'Dim objfrm As New frmClienteBuscarL

            'objfrm.ShowDialog()

            'If objfrm.intClienteId > 0 Then
            '    objBEC = New BEC.CLI.clsCliente
            '    objBEC.ClienteId = objfrm.intClienteId
            '    ClienteLeer(objBEC.ClienteId)
            'End If
            'End If
            'txtCliente.Text = Fix(DateDiff(DateInterval.Day, CDate(Me.txtClienteFecNac.Text), Today) / 365) & " Años"  'dtpClienteFecNac.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClienteLeer(ByVal intClienteId As Integer)
        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
        objBEC = New BEC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
       
        Try
            objBEC = frmLogin.objColeccionFCB.objCliDALC.Leer(intClienteId, frmLogin.Unidad)

            If objBEC IsNot Nothing Then

                txtCliente.Text = objBEC.ClienteApePat.Trim & " " & objBEC.ClienteApeMat & ", " & objBEC.ClienteNombres.Trim
                varClienteId = objBEC.ClienteId
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try

            'Control Fecha:
            ucFechaProcesoIni.TipoTurno(Util.Enumeracion.enmFCBTipoTurno.Cajas)
            ucFechaProcesoIni.IngresarFecha(False)
            ucFechaProcesoIni.UsarCalendario(True)
            ucFechaProcesoIni.Aplicar()

            ucFechaProcesoFin.TipoTurno(Util.Enumeracion.enmFCBTipoTurno.Cajas)
            ucFechaProcesoFin.IngresarFecha(False)
            ucFechaProcesoFin.UsarCalendario(True)
            ucFechaProcesoFin.Aplicar()

            ' Parametro(s):
            '27:       Cajas Grupo

            'Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
            'If uni = 0 Then
            '    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)
            'Else
            '    arrResultados = objDL.Seleccionar("27", frmLogin.Unidad)
            'End If

            Select Case frmLogin.Unidad
                Case "FIESTA CASINO BENAVIDES"
                    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)

                Case "LUXOR LIMA CASINO"
                    arrResultados = objDL.Seleccionar("27", frmLogin.Unidad)

                Case "LUXOR TACNA"
                    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)

                Case "EMPRESA DE PRUEBA"
                    arrResultados = objDL.Seleccionar("26", frmLogin.Unidad)
            End Select


            If arrResultados.Count > 0 Then
                cboCaja.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                    'Select Case objBEC.GrupoId

                    '    Case Util.Enumeracion.enmGrupoParametro.FCB_CajayConteo_Cajas_Grupo
                    Me.cboCaja.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                    'End Select
                Next

                Me.cboCaja.Items.Insert(0, New BEC.COM.clsItem(0, ""))
                Me.cboCaja.SelectedItem = Me.cboCaja.Items(0)

            End If

        Catch ex As Exception
            'Me.tssMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

#End Region

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnReportes_OperacionCaja(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteRetiroEfectivo.Click, btnReporteVentaFichas.Click, btnReportePagosManuales.Click

        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim objFrm As frmCajaReporteImprimir
        Dim arrResultados As ArrayList
        Dim arrFiltros As New ArrayList
        Dim objTCDALC As New DALC.COM.clsTipoCambio
        Dim decTipoCambio As Decimal = objTCDALC.Leer(frmLogin.Unidad)
        Dim intTipoReporte As Integer = 0

        Dim strFichaDenominacion As String
        If frmLogin.Unidad.CompareTo("FIESTA CASINO BENAVIDES") Then
            strFichaDenominacion = Configuration.ConfigurationManager.AppSettings("FCB_VentaFicha")
        ElseIf frmLogin.Unidad.CompareTo("LUXOR LIMA CASINO") Then
            strFichaDenominacion = Configuration.ConfigurationManager.AppSettings("LIMA_VentaFicha")
        Else
            strFichaDenominacion = Configuration.ConfigurationManager.AppSettings("TACNA_VentaFicha")
        End If

        Try

            Select Case CType(sender, Button).Name
                Case "btnReporteRetiroEfectivo"
                    intTipoReporte = Util.Enumeracion.enmFCBReporteOperacionCaja.RetiroEfectivoTarjetas

                    With arrFiltros
                        .Add(ucFechaProcesoIni.txtFecha.Text)
                        .Add(ucFechaProcesoFin.txtFecha.Text)
                        .Add("2,3") 'Modalidad --> 2: Tarj. Crédito, 3:Tarj. Débito
                        .Add("6") 'Tipo --> 6: Retiro de Efectivo
                        .Add(CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre)
                        .Add(varClienteId)
                    End With

                Case "btnReporteVentaFichas"
                    intTipoReporte = Util.Enumeracion.enmFCBReporteOperacionCaja.RegistroVentasFichas

                    With arrFiltros
                        .Add(ucFechaProcesoIni.txtFecha.Text)
                        .Add(ucFechaProcesoFin.txtFecha.Text)
                        .Add("") 'Modalidad --> Todos
                        .Add("1") 'Tipo --> 1: Canje de dinero por fichas en caja	
                        .Add(CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre)
                        .Add(varClienteId)
                    End With

                Case "btnReportePagosManuales"
                    intTipoReporte = Util.Enumeracion.enmFCBReporteOperacionCaja.RegistroPagosManuales

                    With arrFiltros
                        .Add(ucFechaProcesoIni.txtFecha.Text)
                        .Add(ucFechaProcesoFin.txtFecha.Text)
                        .Add("1") 'Modalidad --> Efectivo
                        .Add("5") 'Tipo --> 5: Cobro de Premio (Jackpot) en Caja
                        .Add(CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre)
                        .Add(varClienteId)
                    End With

                Case Else
                    Throw New DataException(Util.Constante.Ope_BuscarSinParametros)

            End Select

            arrResultados = objDALC.Reporte(arrFiltros, frmLogin.Unidad)

            If arrResultados IsNot Nothing Then
                objFrm = New frmCajaReporteImprimir(intTipoReporte, arrResultados, ucFechaProcesoIni.txtFecha.Text, ucFechaProcesoFin.txtFecha.Text, decTipoCambio, strFichaDenominacion)
                objFrm.ShowDialog()
                objFrm.Dispose()
            Else
                MsgBox(Util.Constante.Ope_BuscarNONE, MsgBoxStyle.Information, Util.Constante.Msj_SistemaTitulo)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)

        Finally
            objTCDALC = Nothing
        End Try

    End Sub

    Private Sub frmCajaReportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'BDClientesDataSet.tblbdd_cliente' table. You can move, or remove it, as needed.

        varClienteId = 0
        LeerParametros()

        Select frmLogin.Unidad
            Case "FIESTA CASINO BENAVIDES"
                btnReporteVentaFichas.Visible = True

            Case "LUXOR LIMA CASINO"
                btnReporteVentaFichas.Visible = True

            Case "LUXOR TACNA"
                btnReporteVentaFichas.Visible = True

            Case "EMPRESA DE PRUEBA"
                btnReporteVentaFichas.Visible = True
        End Select

        'objHorario = New Util.clsHorario
        'Dim strFechaProceso As String = objHorario.FechaProcesoCyC

        'If strFechaProceso <> "" Then
        '    dtpFechaRegistro.MaxDate = strFechaProceso
        '    dtpFechaRegistro.Value = dtpFechaRegistro.MaxDate

        'Else
        '    MsgBox(Util.Constante.FCB_HoraProceso_ERR, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
        '    Me.Close()
        'End If

    End Sub

    'Private Sub dtpFechaRegistro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtBuscarFecha.Text = dtpFechaRegistro.Value
    'End Sub

    Private Sub btnBuscarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarUsuario.Click
        ClienteBuscar()
    End Sub

    Private Sub chkClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClientes.CheckedChanged
        If chkClientes.CheckState = CheckState.Checked Then
            txtCliente.Enabled = False
            btnBuscarUsuario.Enabled = False
            txtCliente.Text = ""
            varClienteId = 0
        Else
            txtCliente.Enabled = True
            btnBuscarUsuario.Enabled = True
        End If
    End Sub

    Private Sub btn_temp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_temp.Click
        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim objFrm As frmCajaReporteImprimir
        Dim arrResultados As ArrayList
        Dim arrFiltros As New ArrayList
        Dim intTipoReporte As Integer = 0
        Dim objTCDALC As New DALC.COM.clsTipoCambio
        Dim decTipoCambio As Decimal = objTCDALC.Leer("LUXOR LIMA CASINO")
        intTipoReporte = Util.Enumeracion.enmFCBReporteOperacionCaja.RegistroVentasFichas

        With arrFiltros
            .Add(ucFechaProcesoIni.txtFecha.Text)
            .Add(ucFechaProcesoFin.txtFecha.Text)
            .Add("") 'Modalidad --> Todos
            .Add("1") 'Tipo --> 1: Canje de dinero por fichas en caja	
            .Add(CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre)
            .Add(varClienteId)
        End With

        arrResultados = objDALC.Reporte(arrFiltros, frmLogin.Unidad)

        Dim strFichaDenominacion As String
        strFichaDenominacion = Configuration.ConfigurationManager.AppSettings("LIMA_VentaFicha")

        If arrResultados IsNot Nothing Then
            objFrm = New frmCajaReporteImprimir(intTipoReporte, arrResultados, ucFechaProcesoIni.txtFecha.Text, ucFechaProcesoFin.txtFecha.Text, decTipoCambio, strFichaDenominacion)
            objFrm.ShowDialog()
            objFrm.Dispose()
        Else
            MsgBox(Util.Constante.Ope_BuscarNONE, MsgBoxStyle.Information, Util.Constante.Msj_SistemaTitulo)
        End If

    End Sub

    Private Sub btn_temp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_temp2.Click
        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim objFrm As frmCajaReporteImprimir
        Dim arrResultados As ArrayList
        Dim arrFiltros As New ArrayList
        Dim intTipoReporte As Integer = 0
        Dim objTCDALC As New DALC.COM.clsTipoCambio
        Dim decTipoCambio As Decimal = objTCDALC.Leer("LUXOR TACNA")
        intTipoReporte = Util.Enumeracion.enmFCBReporteOperacionCaja.RegistroVentasFichas

        With arrFiltros
            .Add(ucFechaProcesoIni.txtFecha.Text)
            .Add(ucFechaProcesoFin.txtFecha.Text)
            .Add("") 'Modalidad --> Todos
            .Add("1") 'Tipo --> 1: Canje de dinero por fichas en caja	
            .Add(CType(cboCaja.SelectedItem, BEC.COM.clsItem).ItemNombre)
            .Add(varClienteId)
        End With

        Dim strFichaDenominacion As String
        strFichaDenominacion = Configuration.ConfigurationManager.AppSettings("TACNA_VentaFicha")

        arrResultados = objDALC.Reporte(arrFiltros, frmLogin.Unidad)
        If arrResultados IsNot Nothing Then
            objFrm = New frmCajaReporteImprimir(intTipoReporte, arrResultados, ucFechaProcesoIni.txtFecha.Text, ucFechaProcesoFin.txtFecha.Text, decTipoCambio, strFichaDenominacion)
            objFrm.ShowDialog()
            objFrm.Dispose()
        Else
            MsgBox(Util.Constante.Ope_BuscarNONE, MsgBoxStyle.Information, Util.Constante.Msj_SistemaTitulo)
        End If

    End Sub
End Class