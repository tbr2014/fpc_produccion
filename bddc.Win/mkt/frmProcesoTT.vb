Public Class frmProcesoTT

    Private Sub frmProcesoTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaIni.Text = "01/" & Mid(Today.AddDays(-1).ToShortDateString, 4)
        txtFechaFin.Text = Today.AddDays(-1).ToShortDateString
        tssMensaje.Text = ""
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Dim strComando As String = Configuration.ConfigurationManager.AppSettings("FCB_Ruta_ProcesoTT") & "DFrankTT.exe"
        Dim strParametros As String = txtFechaIni.Text & ", " & txtFechaFin.Text
        Dim objDALC As New DALC.CLI.clsMovimiento
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try
            '1. Ejecutar por CMD:
            Process.Start(strComando, strParametros)

            '2. Trasladar datos a UDBC:
            intResultado = objDALC.Procesar()
            If intResultado <> Util.Enumeracion.enmResultadoOperacion.NONE Then

                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then

                    Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                    If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                        intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId

                        ' Pista de Auditoría:
                        frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Proceso, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                        frmLogin.objColeccionFCB.objAuditoria = Nothing
                        ' Fin de Auditoría

                    End If

                End If

                tssMensaje.Text = Util.Constante.Ope_ProcesoFin
            End If

        Catch ex As Exception
            tssMensaje.Text = Util.Constante.Ope_BuscarERR
        Finally

            objDALC = Nothing
            GC.Collect()

        End Try

    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objFrm As New frmRptClientes_Promociones(Util.Enumeracion.enmFCBReporteMarketing.ClienteSlots, Nothing)
        objFrm.ShowDialog()
        objFrm.Dispose()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class