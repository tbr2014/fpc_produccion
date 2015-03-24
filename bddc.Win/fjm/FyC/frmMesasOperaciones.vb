Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Drawing.Imaging
Imports Microsoft.Reporting.WinForms

Public Class frmMesasOperaciones

#Region "Atributos"
    Private Shared arrMesas As ArrayList
    Private Shared arrOperaciones As ArrayList
    Private Shared arrDenominacionFichas As ArrayList
    Private objHorario As Util.clsHorario

    Private Shared strPrinterName As String '= "EPSON TM-U220 Receipt"
    Private Shared strPageSize As String '= "Roll Paper 76 x 200 mm"
    Private Shared decPageWidth As Decimal = 7.6 'cm.
    Private Shared decPageHeight As Decimal = 20 'cm.
    Private m_streams As IList(Of Stream)
    Private m_currentPageIndex As Integer
#End Region

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDALC As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try

            ' 1. Parametro(s)
            arrResultados = objDALC.Seleccionar("22, 24, 25, 90, 91", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                cboTipoOperacion.Items.Clear()
                cboTipoJuego.Items.Clear()
                arrDenominacionFichas = New ArrayList
                arrDenominacionFichas.Add("")

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)

                    '.GrupoId
                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.FJM_OperacionesMesa
                            Me.cboTipoOperacion.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre))

                        Case Util.Enumeracion.enmGrupoParametro.FJM_TipoJuegoMesa
                            Me.cboTipoJuego.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))

                        Case Util.Enumeracion.enmGrupoParametro.FJM_DenominacionesFichas
                            arrDenominacionFichas.Insert(objBEC.ParametroId, objBEC.Nombre)

                        Case Util.Enumeracion.enmGrupoParametro.ConfiguracionImpresorasCaja
                            strPrinterName = objBEC.Nombre

                        Case Util.Enumeracion.enmGrupoParametro.ConfiguraciónDimensionPaginaCaja
                            strPageSize = objBEC.Nombre

                    End Select

                Next

            End If

            LeerMesas()

        Catch ex As Exception

        Finally
            objDALC = Nothing
        End Try

        Me.tssMensaje.Text = ""

    End Sub

    Private Sub LeerMesas()
        Dim objDALC As New DALC.FJM.clsMesa

        arrMesas = New ArrayList
        arrMesas = objDALC.Listar(frmLogin.Unidad)

    End Sub

    Private Sub CargarTreeView()

        Dim objDALC As New DALC.FJM.clsMesa
        Dim objBEC As BEC.FJM.clsMesa
        Dim strNodoPadre, strNodoHijo As String
        Dim arrNodos() As TreeNode

        With Me.tvMesas
            .Nodes.Clear()
            .PathSeparator = "\"
            .HideSelection = False
            .ImageList = Me.imglstMesas
            .Refresh()

            For k As Integer = 0 To arrMesas.Count - 1
                objBEC = New BEC.FJM.clsMesa
                objBEC = arrMesas(k)
                strNodoPadre = "Pit " & objBEC.PitId.ToString

                arrNodos = .Nodes.Find(strNodoPadre, False)
                If arrNodos.Count > 0 Then
                    .SelectedNode = arrNodos(0)
                Else
                    .Nodes.Add(strNodoPadre, strNodoPadre, Util.Enumeracion.enmFJMTipoImagen.Pit, Util.Enumeracion.enmFJMTipoImagen.Pit)
                End If

                strNodoHijo = objBEC.TipoJuego & " " & objBEC.NroMesa
                .Nodes(strNodoPadre).Nodes.Add(strNodoHijo, strNodoHijo, Util.Enumeracion.enmFJMTipoImagen.Inactivo, Util.Enumeracion.enmFJMTipoImagen.Inactivo)

            Next
            .ExpandAll()
            .SelectedNode = .Nodes(0)

        End With

    End Sub

    Private Function SetNodo(ByVal objNodo As TreeNode, ByVal intNodoNuevoEstado As Util.Enumeracion.enmFJMTipoImagen) As Boolean

        Dim bolResultado As Boolean = False

        With objNodo

            Select Case intNodoNuevoEstado

                Case Util.Enumeracion.enmFJMTipoImagen.Pit And objNodo.Level = 0
                    .ImageIndex = intNodoNuevoEstado
                    .SelectedImageIndex = intNodoNuevoEstado
                    bolResultado = True
                Case Util.Enumeracion.enmFJMTipoImagen.Editar And objNodo.Level <> 0
                    .ImageIndex = intNodoNuevoEstado
                    .SelectedImageIndex = intNodoNuevoEstado
                    bolResultado = True
                Case Util.Enumeracion.enmFJMTipoImagen.Abierto And objNodo.Level <> 0
                    .ImageIndex = intNodoNuevoEstado
                    .SelectedImageIndex = Util.Enumeracion.enmFJMTipoImagen.Ver
                    bolResultado = True
                Case Util.Enumeracion.enmFJMTipoImagen.Inactivo And objNodo.Level <> 0
                    .ImageIndex = intNodoNuevoEstado
                    .SelectedImageIndex = intNodoNuevoEstado
                    bolResultado = True
                Case Util.Enumeracion.enmFJMTipoImagen.Cerrado And objNodo.Level <> 0
                    .ImageIndex = intNodoNuevoEstado
                    .SelectedImageIndex = intNodoNuevoEstado
                    bolResultado = True
            End Select

            '.SelectedNode = Nothing
        End With

        Return bolResultado

    End Function

    Private Sub ResetControles()
        tsbGuardar.Visible = False
        lblOperacionMesaId.Text = ""
        'txtFechaProceso.Text = ""
        cboTipoOperacion.SelectedItem = Nothing
        cboTipoJuego.SelectedItem = Nothing
        txtNumMesa.Text = ""
        txtComentarios.Text = ""
        txtAudInsUsr.Text = ""
        txtAudInsFecha.Text = ""
        txtAudUpdUsr.Text = ""
        txtAudUpdFecha.Text = ""
        UcFlotaFichas1.ResetCadenaFlotaFichas()
        dgvSeguimiento.Visible = False
        rptViewer.Visible = False
        tssMensaje.Text = ""
    End Sub

    Private Sub SetGrupobox(ByVal bolHabilitar As Boolean)
        'gbDatosMesa.Enabled = bolHabilitar
        gbFlotaFichas.Enabled = bolHabilitar
        gbComentarios.Enabled = bolHabilitar
    End Sub

    Private Sub EscribirOperacion()

        Try

            Dim objDALC As New DALC.FJM.clsOperacionMesa
            Dim objBEC As New BEC.FJM.clsOperacionMesa
            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

            Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
            If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
            Else
                Throw New DataException(Util.Constante.Acc_SesionERR)
            End If

            With objBEC
                If lblOperacionMesaId.Text = "" Then
                    .OperacionMesaId = 0
                Else
                    .OperacionMesaId = lblOperacionMesaId.Text
                End If

                .FechaProceso = txtFechaProceso.Text
                .TipoOperacionId = CType(cboTipoOperacion.SelectedItem, BEC.COM.clsItem).ItemId
                .TipoJuegoId = CType(cboTipoJuego.SelectedItem, BEC.COM.clsItem).ItemId
                .NroMesa = txtNumMesa.Text
                .PersonalAsignado = "" 'cboDealer.SelectedText & "|" & cboPitboss.SelectedText & "|" & cboSupervisor.SelectedText & "|" & txtInspector.Text.Trim
                .FlotaFichas = Me.UcFlotaFichas1.GetCadenaFlotaFichas
                .Comentarios = txtComentarios.Text.Trim
                .AudCreac_UsuarioId = intUsuarioId
                .EstadoId = Util.Enumeracion.enmResultadoOperacion.OK

                SetNodo(tvMesas.SelectedNode, .TipoOperacionId)

            End With

            intResultado = objDALC.Escribir(objBEC, frmLogin.Unidad)

            If intResultado <> Util.Enumeracion.enmResultadoOperacion.NONE Then
                tssMensaje.Text = Util.Constante.Ope_EscribirOK

                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                    ' Pista de Auditoría:
                    Select Case lblOperacionMesaId.Text
                        Case Is > 0
                            frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                        Case Else
                            frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    End Select

                    frmLogin.objColeccionFCB.objAuditoria = Nothing
                    ' Fin de Auditoría
                End If

                BuscarOperaciones()
                CargarDatosOperaciones(tvMesas.SelectedNode)
            Else
                tssMensaje.Text = Util.Constante.Ope_EscribirERR
            End If

            tvMesas.Enabled = True
            'tsbGuardar.Visible = False

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BuscarOperaciones()

        Dim objDALC As New DALC.FJM.clsOperacionMesa
        Dim arrFiltros As New ArrayList
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            If txtFechaProceso.Text <> "" Then
                With arrFiltros
                    .Add(txtFechaProceso.Text) 'Fecha de Proceso (vigente)
                    .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.ERR)) 'Todas las Operaciones
                    .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.ERR)) 'Todos los Juegos
                    .Add("") 'Todos las Mesas
                    .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.ERR)) 'Todos los Usuarios
                    .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.OK)) 'Ult. operación
                End With

                arrOperaciones = objDALC.Buscar(arrFiltros, frmLogin.Unidad)

                If arrOperaciones IsNot Nothing Then

                    Dim objBECOp As BEC.FJM.clsOperacionMesa

                    For k As Integer = 0 To arrOperaciones.Count - 1
                        objBECOp = CType(arrOperaciones(k), BEC.FJM.clsOperacionMesa)

                        For p As Integer = 0 To tvMesas.Nodes.Count - 1

                            For q As Integer = 0 To tvMesas.Nodes(p).Nodes.Count - 1
                                If tvMesas.Nodes(p).Nodes(q).Text = objBECOp.TipoJuego & " " & objBECOp.NroMesa Then
                                    Select Case objBECOp.TipoOperacionId
                                        Case Util.Enumeracion.enmFJMTipoOperacionMesa.Apertura, Util.Enumeracion.enmFJMTipoOperacionMesa.Relleno, Util.Enumeracion.enmFJMTipoOperacionMesa.Credito, Util.Enumeracion.enmFJMTipoOperacionMesa.PagoCliente
                                            SetNodo(tvMesas.Nodes(p).Nodes(q), Util.Enumeracion.enmFJMTipoImagen.Abierto)
                                        Case Util.Enumeracion.enmFJMTipoOperacionMesa.Cierre
                                            SetNodo(tvMesas.Nodes(p).Nodes(q), Util.Enumeracion.enmFJMTipoImagen.Cerrado)
                                        Case Else
                                            SetNodo(tvMesas.Nodes(p).Nodes(q), Util.Enumeracion.enmFJMTipoImagen.Inactivo)
                                    End Select

                                    Exit For
                                End If
                            Next
                        Next

                    Next

                Else
                    Throw New DataException(Util.Constante.Ope_BuscarNONE)
                End If

            Else
                Throw New DataException(Util.Constante.FCB_FechaProceso_ERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub EliminarOperacion()

    End Sub

    Private Sub CargarDatosMesa(ByVal objNodo As TreeNode)

        Dim objBEC As BEC.FJM.clsMesa
        Dim strDatos() As String

        strDatos = objNodo.Text.Split(" ") '0=Juego, 1=#Mesa

        '1. Colocar datos de la Mesa:
        For k As Integer = 0 To arrMesas.Count - 1

            objBEC = New BEC.FJM.clsMesa
            objBEC = CType(arrMesas(k), BEC.FJM.clsMesa)

            Me.rbMoneda1.Checked = False
            Me.rbMoneda2.Checked = False

            If objBEC.TipoJuego = strDatos(0) And objBEC.NroMesa = strDatos(1) Then

                objHorario = New Util.clsHorario
                txtFechaProceso.Text = objHorario.FechaProcesoFCB

                For p As Integer = 0 To cboTipoJuego.Items.Count - 1
                    If CType(cboTipoJuego.Items(p), BEC.COM.clsItem).ItemNombre = strDatos(0) Then
                        cboTipoJuego.SelectedItem = cboTipoJuego.Items(p)
                        txtNumMesa.Text = strDatos(1)
                        Exit For
                    End If
                Next

                Select Case objBEC.MonedaId
                    Case Util.Enumeracion.enmMoneda.Moneda_Soles
                        Me.rbMoneda1.Checked = True
                    Case Util.Enumeracion.enmMoneda.Moneda_Dolar
                        Me.rbMoneda2.Checked = True
                End Select

                lblTipoMonedaId.Text = objBEC.MonedaId

                'Cargar las Denominaciones según Moneda:
                UcFlotaFichas1.CargarGridFlotaFichas(arrDenominacionFichas(objBEC.MonedaId))

                Exit For

            End If

        Next

    End Sub

    Private Sub CargarDatosOperaciones(ByVal objNodo As TreeNode)

        Dim objBEC As New BEC.FJM.clsOperacionMesa

        rptViewer.Visible = False
        tssMensaje.Text = ""

        '2. Colocar datos de la Operación:
        If arrOperaciones IsNot Nothing Then

            'ResetControles()

            For k As Integer = 0 To arrOperaciones.Count - 1
                objBEC = CType(arrOperaciones(k), BEC.FJM.clsOperacionMesa)
                If objNodo.Text = objBEC.TipoJuego & " " & objBEC.NroMesa Then

                    With objBEC
                        lblOperacionMesaId.Text = .OperacionMesaId
                        txtFechaProceso.Text = .FechaProceso

                        For p As Integer = 0 To cboTipoOperacion.Items.Count - 1
                            If .TipoOperacionId = CType(cboTipoOperacion.Items(p), BEC.COM.clsItem).ItemId Then
                                cboTipoOperacion.SelectedItem = cboTipoOperacion.Items(p)
                                Exit For
                            End If
                        Next

                        For p As Integer = 0 To cboTipoJuego.Items.Count - 1
                            If .TipoJuegoId = CType(cboTipoJuego.Items(p), BEC.COM.clsItem).ItemId Then
                                cboTipoJuego.SelectedItem = cboTipoJuego.Items(p)
                                Exit For
                            End If
                        Next

                        txtNumMesa.Text = .NroMesa

                        'Dim strPersonalAsignado() As String
                        'strPersonalAsignado = .PersonalAsignado.Split("|")
                        'If strPersonalAsignado.Length > 0 And strPersonalAsignado(0) <> "" Then
                        '    cboDealer.Text = strPersonalAsignado(0)
                        '    cboPitboss.Text = strPersonalAsignado(1)
                        '    cboSupervisor.Text = strPersonalAsignado(2)
                        '    txtInspector.Text = strPersonalAsignado(3)
                        'End If

                        Me.UcFlotaFichas1.SetCadenaFlotaFichas(.FlotaFichas)

                        txtComentarios.Text = .Comentarios.Trim

                        txtAudInsUsr.Text = ""
                        txtAudInsFecha.Text = ""

                        'Datos de Auditoria:
                        If .AudCreac_UsuarioId > 0 Then
                            txtAudInsUsr.Text = .AudCreac_Usuario
                            txtAudInsFecha.Text = .AudCreac_Fecha
                        End If

                        If .AudEdic_UsuarioId > 0 Then
                            txtAudUpdUsr.Text = .AudEdic_Usuario
                            txtAudUpdFecha.Text = .AudEdic_Fecha
                        End If

                    End With

                    '3. Cargar Operaciones para Seguimiento:
                    Dim arrSeguimiento As New ArrayList
                    Dim objDALC As New DALC.FJM.clsOperacionMesa
                    Dim arrFiltros As New ArrayList
                    Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

                    With arrFiltros
                        .Add(txtFechaProceso.Text) 'Fecha de Proceso (vigente)
                        .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.ERR)) 'Todas las Operaciones
                        .Add(objBEC.TipoJuegoId) 'Todos los Juegos
                        .Add(objBEC.NroMesa) 'Todos las Mesas
                        .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.ERR)) 'Todos los Usuarios
                        .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.NONE)) 'Todas las operaciones
                    End With

                    arrSeguimiento = objDALC.Buscar(arrFiltros, frmLogin.Unidad)

                    'For k As Integer = 0 To arrOperaciones.Count - 1
                    '    objBECOp = New BEC.FJM.clsOperacionMesa
                    '    objBECOp = CType(arrOperaciones(k), BEC.FJM.clsOperacionMesa)
                    '    If objNodo.Text = objBECOp.TipoJuego & " " & objBECOp.NroMesa Then
                    '        arrSeguimiento.Add(objBECOp)
                    '    End If
                    'Next

                    dgvSeguimiento.Visible = False

                    If arrSeguimiento.Count > 0 Then
                        dgvSeguimiento.Visible = True
                        dgvSeguimiento.DataSource = arrSeguimiento
                    End If

                    '3. Habilitar botón Guardar:
                    If lblOperacionMesaId.Text = "" Then
                        tsbGuardar.Visible = True

                    Else
                        ' Verificar  si modificará según su rol asignado:
                        Dim arrParametro As New ArrayList
                        With arrParametro
                            .Add(Convert.ToInt16(Util.Enumeracion.enmSEGRol.Administrador))
                            .Add(Convert.ToInt16(Util.Enumeracion.enmSEGRol.Gerente))
                        End With

                        frmLogin.ConfigurarControlxRol(tsbGuardar, Util.Enumeracion.enmSEGModulos.MODFPC, arrParametro)

                        If tsbGuardar.Enabled = True Then
                            tsbGuardar.Visible = True
                            SetGrupobox(True)
                        Else
                            tsbGuardar.Visible = False
                            SetGrupobox(False)
                        End If

                    End If

                    Exit For
                End If
            Next

        End If

    End Sub

    Private Sub CargarDatosOperaciones(ByVal objFila As DataGridViewRow)

        rptViewer.Visible = False
        tssMensaje.Text = ""

        '2. Colocar datos de la Operación:
        If arrOperaciones IsNot Nothing Then

            lblOperacionMesaId.Text = objFila.Cells("OperacionMesaId").Value
            txtFechaProceso.Text = objFila.Cells("FechaProceso").Value

            For p As Integer = 0 To cboTipoOperacion.Items.Count - 1
                If objFila.Cells("TipoOperacionId").Value = CType(cboTipoOperacion.Items(p), BEC.COM.clsItem).ItemId Then
                    cboTipoOperacion.SelectedItem = cboTipoOperacion.Items(p)
                    Exit For
                End If
            Next

            For p As Integer = 0 To cboTipoJuego.Items.Count - 1
                If objFila.Cells("TipoJuegoId").Value = CType(cboTipoJuego.Items(p), BEC.COM.clsItem).ItemId Then
                    cboTipoJuego.SelectedItem = cboTipoJuego.Items(p)
                    Exit For
                End If
            Next

            txtNumMesa.Text = objFila.Cells("NroMesa").Value

            'Dim strPersonalAsignado() As String
            'strPersonalAsignado = objFila.Cells("PersonalAsignado").Value.Split("|")

            'If strPersonalAsignado.Length > 0 And strPersonalAsignado(0) <> "" Then
            '    cboDealer.Text = strPersonalAsignado(0)
            '    cboPitboss.Text = strPersonalAsignado(1)
            '    cboSupervisor.Text = strPersonalAsignado(2)
            '    txtInspector.Text = strPersonalAsignado(3)
            'End If

            Me.UcFlotaFichas1.SetCadenaFlotaFichas(objFila.Cells("FlotaFichas").Value)

            txtComentarios.Text = objFila.Cells("Comentarios").Value.Trim

            txtAudInsUsr.Text = objFila.Cells("AudCreac_Usuario").Value
            If objFila.Cells("AudCreac_UsuarioId").Value > 0 Then txtAudInsFecha.Text = objFila.Cells("AudCreac_Fecha").Value


        End If

    End Sub

    Private Sub AplicarOperacion(ByVal intOperacionId As Util.Enumeracion.enmFJMTipoOperacionMesa)

        SetGrupobox(True)
        ResetControles()
        tvMesas.Enabled = False

        If tsbGuardar.Enabled = True And lblOperacionMesaId.Text = "" Then tsbGuardar.Visible = True

        '1. Movimiento:
        For k As Integer = 0 To cboTipoOperacion.Items.Count - 1
            If CType(cboTipoOperacion.Items(k), BEC.COM.clsItem).ItemId = intOperacionId Then
                cboTipoOperacion.SelectedItem = cboTipoOperacion.Items(k)
                Exit For
            End If
        Next

        '2. Tipo Juego, No. Mesa y Moneda:
        If tvMesas.SelectedNode IsNot Nothing Then
            CargarDatosMesa(tvMesas.SelectedNode)
        End If

    End Sub

    Private Sub CargarFormatoOperacion()

        Try

            Dim strOperacion As String = dgvSeguimiento.CurrentRow.Cells("TipoOperacion").Value

            If strOperacion <> Util.Constante.FCB_TipoOperacion_Apertura Then

                Dim strTempCantidades() As String = dgvSeguimiento.CurrentRow.Cells("FlotaFichas").Value.ToString.Split("|")
                Dim strTempDenominaciones() As String = dgvSeguimiento.CurrentRow.Cells("Denominaciones").Value.ToString.Split("|")
                Dim strCantidades(11), strDenominaciones(11), strMontos(11), strMoneda As String
                Dim decTotal As Decimal = 0
                Dim datFechaProceso As DateTime = CDate(txtAudInsFecha.Text)

                For k As Integer = 0 To strMontos.Length - 1
                    If k >= strTempDenominaciones.Length Then
                        strCantidades(k) = ""
                        strDenominaciones(k) = ""
                        strMontos(k) = ""
                    Else
                        strCantidades(k) = strTempCantidades(k)
                        strDenominaciones(k) = strTempDenominaciones(k)
                        strMontos(k) = Math.Round(strCantidades(k) * strDenominaciones(k), 2).ToString("0.00")
                        decTotal += Convert.ToDecimal(strMontos(k))
                    End If
                Next

                strMoneda = ""
                If rbMoneda1.Checked = True Then strMoneda = rbMoneda1.Text
                If rbMoneda2.Checked = True Then strMoneda = rbMoneda2.Text

                Dim arrParam(9) As ReportParameter
                arrParam(0) = New ReportParameter("parOperacion", strOperacion, False)
                arrParam(1) = New ReportParameter("parFechaProceso", txtFechaProceso.Text, False)
                arrParam(2) = New ReportParameter("parHoraProceso", datFechaProceso.ToShortTimeString, False)
                arrParam(3) = New ReportParameter("parMesaOperacion", tvMesas.SelectedNode.Text, False)
                arrParam(4) = New ReportParameter("parTurnoOperacion", "Noche", False)
                arrParam(5) = New ReportParameter("parDenominaciones", strDenominaciones, True)
                arrParam(6) = New ReportParameter("parCantidades", strCantidades, True)
                arrParam(7) = New ReportParameter("parMontos", strMontos, True)
                arrParam(8) = New ReportParameter("parMoneda", strMoneda, True)
                arrParam(9) = New ReportParameter("parMontoTotal", decTotal.ToString("0.00"), True)

                With Me.rptViewer
                    .Reset()
                    .LocalReport.DataSources.Clear()
                    .ProcessingMode = ProcessingMode.Local
                    .LocalReport.ReportEmbeddedResource = "bddc.Win.rptOperacionMesa.rdlc"
                    .LocalReport.SetParameters(arrParam)
                    .RefreshReport()
                    .Visible = True
                End With


                If MsgBox("Desea imprimir comprobante?", MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) = MsgBoxResult.Yes Then
                    If VerificarImpresora() = Util.Enumeracion.enmResultadoOperacion.OK Then ImprimirFormato()
                Else
                    Throw New DataException("Impresión de comprobante cancelada!")
                End If
            Else
                Throw New DataException("Operación no requiere impresión de comprobante!")
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message
            Me.rptViewer.Visible = False

        End Try

    End Sub

    Private Sub ImprimirFormato()

        Try

            'Paper Size:
            Dim objPageSize As New PaperSize("PageSize", (decPageWidth / 2.54) * 100, (decPageHeight / 2.54) * 100)

            'Page Settings:
            Dim objPageSetting As New PageSettings
            With objPageSetting
                .Margins.Top = 0
                .Margins.Bottom = 0
                .Margins.Left = 0
                .Margins.Right = 0
                .PaperSize = objPageSize
            End With

            'Printer Settings:
            Dim objPrinterSettings As New PrinterSettings

            With objPrinterSettings
                .PrinterName = strPrinterName
                .Copies = 1 'Num. Copias
                .FromPage = 1
                .ToPage = 1
            End With

            objPrintDocument = New PrintDocument
            With objPrintDocument
                .DefaultPageSettings.PrinterSettings = objPrinterSettings
            End With

            Export(rptViewer.LocalReport)

            m_currentPageIndex = 0
            If m_streams Is Nothing Or m_streams.Count = 0 Then
                Return
            End If

            If Not objPrintDocument.PrinterSettings.IsValid Then Throw New DataException(Util.Constante.Msj_ImpresoraEstadoERR)

            AddHandler objPrintDocument.PrintPage, AddressOf PrintPage

            Dim objImpresora As New Util.clsImpresora
            Dim strImpresoraDefault As String = objImpresora.ImpresoraGetDefault(Environment.MachineName)

            If strPrinterName <> "" Then objImpresora.ImpresoraSetDefault(Environment.MachineName, strPrinterName)

            objPrintDocument.Print()

            If strImpresoraDefault <> "" Then objImpresora.ImpresoraSetDefault(Environment.MachineName, strImpresoraDefault)

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        Finally
            objPrintDocument.Dispose()
            GC.Collect()

        End Try

    End Sub

    Private Sub BuscarCierreAyer()

        Dim objDALC As New DALC.FJM.clsOperacionMesa
        Dim arrFiltros As New ArrayList
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim datFechaProceso As DateTime = CDate(txtFechaProceso.Text)

        Try

            If txtFechaProceso.Text <> "" Then
                With arrFiltros
                    .Add(datFechaProceso.AddDays(-1).ToShortDateString) 'Fecha de Proceso (del Cierre anterior)
                    .Add(Convert.ToInt16(Util.Enumeracion.enmFJMTipoOperacionMesa.Cierre)) 'Todas las Operaciones
                    .Add(CType(cboTipoJuego.SelectedItem, BEC.COM.clsItem).ItemId) 'Todos los Juegos
                    .Add(txtNumMesa.Text) 'Todos las Mesas
                    .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.ERR)) 'Todos los Usuarios
                    .Add(Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.OK)) 'Ult. operación
                End With

                arrOperaciones = objDALC.Buscar(arrFiltros, frmLogin.Unidad)

                If arrOperaciones IsNot Nothing Then

                    Dim objBECOp As BEC.FJM.clsOperacionMesa = CType(arrOperaciones(0), BEC.FJM.clsOperacionMesa)

                    Me.UcFlotaFichas1.SetCadenaFlotaFichas(objBECOp.FlotaFichas)

                Else
                    Throw New DataException(Util.Constante.Ope_BuscarNONE)
                End If

            Else
                Throw New DataException(Util.Constante.FCB_FechaProceso_ERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub Export(ByVal report As LocalReport)

        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
            "  <OutputFormat>EMF</OutputFormat>" + _
            "  <PageWidth>" + decPageWidth.ToString + "cm</PageWidth>" + _
            "  <PageHeight>" + decPageHeight.ToString + "cm</PageHeight>" + _
            "  <MarginTop>0in</MarginTop>" + _
            "  <MarginLeft>0in</MarginLeft>" + _
            "  <MarginRight>0in</MarginRight>" + _
            "  <MarginBottom>0in</MarginBottom>" + _
          "</DeviceInfo>"

        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next

    End Sub

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim strFile As String = name & Now.Year.ToString & Now.Month.ToString("00") & Now.Day.ToString("00") & "T" & Now.Hour.ToString("00") & Now.Minute.ToString("00") & Now.Second.ToString("00")
        Dim stream As Stream = _
            New FileStream("..\..\" + _
             strFile + "." + fileNameExtension, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function

    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try

            Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
            ev.Graphics.DrawImage(pageImage, ev.PageBounds)

            m_currentPageIndex += 1
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count)

        Catch ex As Exception
            Throw New DataException(Util.Constante.Msj_ImpresoraEstadoERR)

        End Try

    End Sub

    Private Function VerificarImpresora() As Util.Enumeracion.enmResultadoOperacion
        Dim objImpresora As New Util.clsImpresora
        Return objImpresora.ImpresoraEvaluacion(Environment.MachineName, strPrinterName, strPageSize)
    End Function

#End Region

#Region "Eventos de Controles"

    Private Sub frmTableroControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODFPC)

            objHorario = New Util.clsHorario
            txtFechaProceso.Text = objHorario.FechaProcesoFCB

            If txtFechaProceso.Text = "" Then MsgBox(Util.Constante.FCB_HoraProceso_ERR, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)

            LeerParametros()
            VerificarImpresora()
            CargarTreeView()

            UcFlotaFichas1.dgvFlotaFichas.Visible = False
            SetGrupobox(False)
            tsbGuardar.Visible = False
            'tsbEliminar.Visible = False

            arrOperaciones = New ArrayList
            BuscarOperaciones()
            Me.rptViewer.RefreshReport()
            'Timer1.Enabled = True

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        End Try

    End Sub

    Private Sub AperturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiApertura.Click

        If SetNodo(tvMesas.SelectedNode, Util.Enumeracion.enmFJMTipoImagen.Editar) Then
            AplicarOperacion(Util.Enumeracion.enmFJMTipoOperacionMesa.Apertura)
            BuscarCierreAyer()
        End If

    End Sub

    Private Sub CierreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCierre.Click

        If SetNodo(tvMesas.SelectedNode, Util.Enumeracion.enmFJMTipoImagen.Cerrado) Then
            AplicarOperacion(Util.Enumeracion.enmFJMTipoOperacionMesa.Cierre)
        End If

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

        '1. Evaluar si es Pit o no:
        If tvMesas.SelectedNode.Level = 0 Then
            e.Cancel = True
        Else
            e.Cancel = False

            '2. Evaluar estado del Nodo:
            Me.ContextMenuStrip1.Items("tsmiApertura").Enabled = False
            Me.ContextMenuStrip1.Items("tsmiRelleno").Enabled = False
            Me.ContextMenuStrip1.Items("tsmiCredito").Enabled = False
            Me.ContextMenuStrip1.Items("tsmiCierre").Enabled = False

            Select Case tvMesas.SelectedNode.ImageIndex

                Case Util.Enumeracion.enmFJMTipoImagen.Abierto
                    Me.ContextMenuStrip1.Items("tsmiRelleno").Enabled = True
                    Me.ContextMenuStrip1.Items("tsmiCredito").Enabled = True
                    Me.ContextMenuStrip1.Items("tsmiCierre").Enabled = True

                Case Util.Enumeracion.enmFJMTipoImagen.Inactivo
                    Me.ContextMenuStrip1.Items("tsmiApertura").Enabled = True

            End Select

        End If

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        EscribirOperacion()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        EliminarOperacion()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsmiRelleno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRelleno.Click
        AplicarOperacion(Util.Enumeracion.enmFJMTipoOperacionMesa.Relleno)
    End Sub

    Private Sub tsmiCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCredito.Click
        AplicarOperacion(Util.Enumeracion.enmFJMTipoOperacionMesa.Credito)
    End Sub

    Private Sub tvMesas_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMesas.AfterSelect
        ResetControles()
        If e.Node.Level <> 0 Then
            CargarDatosMesa(e.Node)
            CargarDatosOperaciones(e.Node)
        End If
    End Sub

    Private Sub dgvSeguimiento_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSeguimiento.CellContentClick
        If e.RowIndex > -1 Then
            CargarDatosOperaciones(dgvSeguimiento.Rows(e.RowIndex))
            If e.ColumnIndex = 0 Then CargarFormatoOperacion()
        End If
    End Sub

    Private Sub CambiaFila(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSeguimiento.KeyUp
        If dgvSeguimiento.CurrentRow.Index > -1 Then CargarDatosOperaciones(dgvSeguimiento.Rows(dgvSeguimiento.CurrentRow.Index))
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        GC.Collect()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CargarTreeView()
        BuscarOperaciones()
    End Sub

#End Region

End Class