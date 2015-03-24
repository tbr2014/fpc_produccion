Public Class frmSplash

#Region "Atributos"

    Public arrParam As ArrayList
    Public arrParam2 As ArrayList
    Public arrResultados As IList
    Public arrResultados2 As IList
    Public arrUsuario As ArrayList
    Public clsColeccionFCB As clsColeccion

    Public objCliBus As frmClienteBus
    Public objCliReg As frmClienteReg
    Public objRatReg As frmRatingReg
    Public objRptLista As frmReporteLista
    Public objSistema As frmSist_Parametros
    Public objAuditoria As frmSist_Auditoria

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.clsColeccionFCB = New clsColeccion
        objCliReg = New frmClienteReg
        objCliBus = New frmClienteBus
        objRatReg = New frmRatingReg
        objRptLista = New frmReporteLista
        objSistema = New frmSist_Parametros
        objAuditoria = New frmSist_Auditoria

    End Sub

    Private Sub frmSplash_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Salir()
    End Sub

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            If Me.arrUsuario IsNot Nothing Then

                If Me.arrUsuario.Count > 0 Then

                    clsColeccionFCB.objCliBEC = New BEC.tblbdd_cliente
                    clsColeccionFCB.objUsuBEC = Me.arrUsuario(0)
                    clsColeccionFCB.objUsuCfgBEC = Me.arrUsuario(1)

                    objCliReg.Visible = False
                    objCliBus.Visible = False
                    objRatReg.Visible = False
                    objRptLista.Visible = False
                    objSistema.Visible = False
                    objAuditoria.Visible = False

                    btnClientes.Visible = False
                    btnRating.Visible = False
                    btnReportes.Visible = False
                    btnSistema.Visible = False
                    btnAuditoria.Visible = False
                    btnImpresion.Visible = False

                    Select Case clsColeccionFCB.objUsuCfgBEC.RolId
                        Case Util.Enumeracion.enmSEGRol.Administrador
                            btnClientes.Visible = True
                            btnRating.Visible = True
                            btnReportes.Visible = True
                            btnSistema.Visible = True
                            btnAuditoria.Visible = True
                            'btnImpresion.Visible = True

                        Case Util.Enumeracion.enmSEGRol.Gerente
                            btnClientes.Visible = True
                            btnRating.Visible = True
                            btnReportes.Visible = True
                            btnSistema.Visible = True
                            btnImpresion.Visible = True

                        Case Util.Enumeracion.enmSEGRol.Supervisor, Util.Enumeracion.enmSEGRol.Operador
                            btnClientes.Visible = True
                            btnRating.Visible = True
                            btnReportes.Visible = True

                    End Select

                    'Versión del Build de la Aplicación
                    If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                        Dim strVersion As String = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                        lblVersion.Text &= " " & strVersion
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Me.Close()
        End Try

    End Sub

    Private Sub pbClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSistema.Click
        objSistema.ShowDialog()
    End Sub

    Private Sub btnReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportes.Click
        objRptLista.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        objCliReg.ShowDialog()
    End Sub

    Private Sub btnRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRating.Click
        clsColeccionFCB.objCliBEC.ccli_id = 0
        objRatReg = New frmRatingReg
        objRatReg.ShowDialog()
    End Sub

    Private Sub Salir()
        If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
            Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
            If clsColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = clsColeccionFCB.objUsuBEC.UsuarioId
            ' Pista de Auditoría:
            clsColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.LogOut, Util.OpcionMenu.MODFCM & "->" & Me.Name, Environment.MachineName)
            clsColeccionFCB.objAuditoria = Nothing
            ' Fin de Auditoría
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        'If MessageBox.Show("Seguro?", "Salir del Sistema", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        Me.Close()
        'End If

    End Sub

    Private Sub btnImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresion.Click
        Dim objImpresionTicket As New frmImpresionTicketsSlots 'frmImpresion1
        objImpresionTicket.ShowDialog()
        objImpresionTicket.Dispose()
    End Sub

    Private Sub btnAuditoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria.Click
        objAuditoria.ShowDialog()
    End Sub

    Private Sub btnEstimados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstimados.Click
        Dim objEstimados As New frmEstimadoMesas
        objEstimados.ShowDialog()
        objEstimados.Dispose()
    End Sub

End Class