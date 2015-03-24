Public Class frmReportesMercadeo

    Private objReporte3 As frmRptClientes_Juegos
    Private objReporte4 As frmRptCliente_Cumple

    Friend Shared objConexion As Util.Factory
    Private objDALC As DALC.CLI.clsReporte
    Private arrFiltros As ArrayList

    Private Sub btnReporte3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton3.Click
        objReporte3 = New frmRptClientes_Juegos
        objReporte3.ShowDialog()
    End Sub

    Private Sub btnReporte4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton4.Click
        objReporte4 = New frmRptCliente_Cumple
        objReporte4.ShowDialog()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmReporteLista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpFechaIni.Value = "01/" & Mid(Now.ToShortDateString, 4)
        dtpFechaIni.MaxDate = Now.ToShortDateString
        dtpFechaFin.Value = Now.ToShortDateString
        dtpFechaFin.MaxDate = Now.ToShortDateString
        tssMensaje.Text = ""

        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId

        If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
            ' Pista de Auditoría:
            frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Read, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
            frmLogin.objColeccionFCB.objAuditoria = Nothing
            ' Fin de Auditoría
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnRptClientes_Slots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptClientes_Slots.Click
        Dim objFrm As New frmRptClientes_Promociones(Util.Enumeracion.enmFCBReporteMarketing.ClienteSlots, Nothing)
        objFrm.ShowDialog()
        objFrm.Dispose()
    End Sub


    Private Sub btnRptClientes_Mesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptClientes_Mesas.Click
        Dim arrParam As New ArrayList

        Try

            If dtpFechaIni.Value <= dtpFechaFin.Value Then
                With arrParam
                    .Add(dtpFechaIni.Value.ToShortDateString)
                    .Add(dtpFechaFin.Value.ToShortDateString)
                End With

                Dim objFrm As New frmRptClientes_Promociones(Util.Enumeracion.enmFCBReporteMarketing.ClienteMesas, arrParam)
                objFrm.ShowDialog()
                objFrm.Dispose()

            Else
                Throw New DataException(Util.Constante.Ope_BuscarSinParametros)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        End Try

    End Sub

End Class