Public Class frmReportesMesas

    Private objReporte1 As frmReporte1
    Private objReporte2 As frmReporte2
    Private objReporte3 As frmRptClientes_Juegos
    Private objReporte4 As frmRptCliente_Cumple
    Private objReporte5 As frmReporte5
    Private objReporte6 As frmReporte6
    Private objReporte7 As frmReporte7
    Private objReporte8 As frmReporte8
    'Private objReporte9 As Fiesta_Tblfjm_GrupoClienteBaccaratBindingSource
    Private objReporte9 As frmReporte9
    Private objReporte_10 As frmReporte10
    Private objReporte10 As frmReporteRatingAnual

    Friend Shared objConexion As Util.Factory
    Private objDALC As DALC.CLI.clsReporte
    Private arrFiltros As ArrayList
    Private objHorario As Util.clsHorario

#Region "Operaciones"

    Private Sub LeerCierreFechaCalendario()

        Try
            pbCierreOk.Visible = False
            pbCierreNo.Visible = False

            objDALC = New DALC.CLI.clsReporte
            arrFiltros = New ArrayList
            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

            With arrFiltros
                .Add(ucFechaProceso.txtFecha.Text)
            End With

            intResultado = objDALC.PuntajeHayCierre(arrFiltros, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                pbCierreOk.Visible = True
                lblEstadoCierre.Text = arrFiltros(0) & ": " & Util.Constante.FCB_ProcesoCierre_OK
                'btnAplicar.Enabled = False
            Else
                pbCierreNo.Visible = True
                lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_NO
                'btnAplicar.Enabled = True
            End If

        Catch ex As Exception
            pbCierreNo.Visible = True
            lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_NO & " - " & ex.Message
        End Try

    End Sub

    Private Sub AplicarProcesoCierre()

        Try

            objDALC = New DALC.CLI.clsReporte
            arrFiltros = New ArrayList
            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

            With arrFiltros
                .Add(ucFechaProceso.txtFecha.Text)
            End With

            intResultado = objDALC.PuntajeProcesoCierre(arrFiltros, frmLogin.Unidad)

            If intResultado >= Util.Enumeracion.enmResultadoOperacion.OK Then

                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                    ' Pista de Auditoría:              
                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(frmLogin.objColeccionFCB.objUsuBEC.UsuarioId, Util.Enumeracion.enmTipoAccion.Proceso, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    frmLogin.objColeccionFCB.objAuditoria = Nothing
                    ' Fin de Auditoría
                End If

                pbCierreOk.Visible = True
                lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_OK
            Else
                pbCierreNo.Visible = True
                lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_NO
            End If

        Catch ex As Exception
            pbCierreNo.Visible = True
            lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_NO & " - " & ex.Message
        End Try

    End Sub

    Private Sub RecalcularProcesoCierre()

        Try
            Dim strFecha As String
            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

            strFecha = "01/01/2011"

            While strFecha <> "22/06/2011"
                objDALC = New DALC.CLI.clsReporte
                arrFiltros = New ArrayList

                With arrFiltros
                    .Add(strFecha)
                End With

                intResultado = objDALC.PuntajeProcesoCierre(arrFiltros, frmLogin.Unidad)
                strFecha = DateAdd(DateInterval.Day, 1, CDate(strFecha))
            End While

            MsgBox("Proceso terminado el " & strFecha)

            If intResultado >= Util.Enumeracion.enmResultadoOperacion.OK Then

                pbCierreOk.Visible = True
                lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_OK
            Else
                pbCierreNo.Visible = True
                lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_NO
            End If

        Catch ex As Exception
            pbCierreNo.Visible = True
            lblEstadoCierre.Text = Util.Constante.FCB_ProcesoCierre_NO & " - " & ex.Message
        End Try

    End Sub

    Private Sub LeerAccesoporPerfil(ByVal intModuloId As Util.Enumeracion.enmSEGModulos)

        'Inhabilitar GrupoBoxes:
        gbRatingPitboss.Enabled = False
        gbRatingCierre.Enabled = False
        gbRatingReportes.Enabled = False

        If frmLogin.objColeccionFCB.arrUsuCfgBEC(1).Count > 0 Then
            For k As Integer = 0 To frmLogin.objColeccionFCB.arrUsuCfgBEC(1).Count - 1

                If CType(frmLogin.objColeccionFCB.arrUsuCfgBEC(1)(k), BEC.SEG.clsUsuarioConfig).ModuloId = Util.Enumeracion.enmSEGModulos.MODFPC Then
                    frmLogin.objColeccionFCB.objUsuCfgBEC = New BEC.SEG.clsUsuarioConfig
                    frmLogin.objColeccionFCB.objUsuCfgBEC = frmLogin.objColeccionFCB.arrUsuCfgBEC(1)(k)
                    Exit For
                End If

            Next

            If frmLogin.objColeccionFCB.objUsuCfgBEC IsNot Nothing Then

                Select Case frmLogin.objColeccionFCB.objUsuCfgBEC.RolId
                    Case Util.Enumeracion.enmSEGRol.Administrador, Util.Enumeracion.enmSEGRol.Gerente
                        gbRatingPitboss.Enabled = True
                        gbRatingCierre.Enabled = True
                        gbRatingReportes.Enabled = True

                    Case Util.Enumeracion.enmSEGRol.Supervisor
                        gbRatingPitboss.Enabled = True
                        gbRatingReportes.Enabled = True

                    Case Util.Enumeracion.enmSEGRol.Operador
                        gbRatingPitboss.Enabled = True

                    Case Util.Enumeracion.enmSEGRol.Observador
                        gbRatingPitboss.Enabled = True
                        gbRatingReportes.Enabled = True

                End Select

            End If

        End If

    End Sub

#End Region

    Private Sub btnReporte1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton1.Click
        objReporte1 = New frmReporte1
        objReporte1.ShowDialog()
    End Sub

    Private Sub btnReporte2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton2.Click
        objReporte2 = New frmReporte2
        objReporte2.ShowDialog()
    End Sub

    Private Sub btnReporte5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton5.Click
        objReporte5 = New frmReporte5
        objReporte5.ShowDialog()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnBoton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton6.Click
        objReporte6 = New frmReporte6
        objReporte6.ShowDialog()
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        AplicarProcesoCierre()
    End Sub

    Private Sub frmReporteLista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            'Control Fecha:
            ucFechaProceso.TipoTurno(Util.Enumeracion.enmFCBTipoTurno.Mesas)
            ucFechaProceso.IngresarFecha(False)
            ucFechaProceso.UsarCalendario(True)
            ucFechaProceso.Aplicar()

            LeerCierreFechaCalendario()
            LeerAccesoporPerfil(Util.Enumeracion.enmSEGModulos.MODFPC)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)

        End Try

        'objHorario = New Util.clsHorario
        'Dim strFechaProfeso As String = objHorario.FechaProcesoFCB

        'If strFechaProfeso <> "" Then
        '    dtpFechaProceso.MaxDate = strFechaProfeso
        '    dtpFechaProceso.Value = dtpFechaProceso.MaxDate

        '    LeerCierreFechaCalendario()
        '    LeerAccesoporPerfil()

        'Else
        '    MsgBox(Util.Constante.FCB_HoraProceso_ERR, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
        '    Me.Close()
        'End If

    End Sub

    Private Sub dtpFechaProceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LeerCierreFechaCalendario()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnBoton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton7.Click
        objReporte7 = New frmReporte7
        objReporte7.ShowDialog()
    End Sub

    Private Sub btnBoton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton8.Click
        objReporte8 = New frmReporte8
        objReporte8.ShowDialog()
    End Sub

    Private Sub btnRCTBacarat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCTBacarat.Click
        Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
        If uni = 0 Then
            objReporte9 = New frmReporte9
            objReporte9.ShowDialog()
        Else
            objReporte_10 = New frmReporte10
            objReporte_10.ShowDialog()
        End If
       
    End Sub

    Private Sub btnRecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecalcular.Click
        RecalcularProcesoCierre()
    End Sub

    Private Sub btnRatinTotalAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRatinTotalAnual.Click
        objReporte10 = New frmReporteRatingAnual
        objReporte10.ShowDialog()
    End Sub
End Class