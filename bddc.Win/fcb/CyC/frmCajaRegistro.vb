Public Class frmCajaRegistro

#Region "Atributos"

    Public intOperacionCajaId As Integer
    Private Shared objCliBEC As BEC.CLI.clsCliente
    Private Shared objOpeBEC As BEC.FCB.clsOperacionCaja

#End Region

#Region "Operaciones"

    Private Sub RegistroNuevo()

        txtOperacionMonto.Text = ""
        rbModalidadOperacion1.Checked = False
        rbModalidadOperacion2.Checked = False
        rbModalidadOperacion3.Checked = False
        rbTipoOperacion1.Checked = False
        rbTipoOperacion2.Checked = False
        rbTipoOperacion3.Checked = False
        rbTipoOperacion4.Checked = False
        rbTipoOperacion5.Checked = False
        rbTipoOperacion6.Checked = False

        lblClienteId.Text = ""
        ClienteNuevo()

        gbComentario.Enabled = False

    End Sub

    Private Sub RegistroLeer()

        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim OperacionFichaDenominacion As Decimal

        Try

            If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
            Else
                intUsuarioId = 0 'Prueba!
                Throw New DataException(Util.Constante.Acc_SesionERR)
            End If

            objOpeBEC = New BEC.FCB.clsOperacionCaja
            objOpeBEC = objDALC.Leer(Me.intOperacionCajaId, frmLogin.Unidad)

            If objOpeBEC IsNot Nothing Then

                RegistroNuevo()

                With objOpeBEC
                    lblOperacionCajaId.Text = .OperacionCajaId
                    txtRegistroNro.Text = .OperacionCodigo
                    txtRegistroFecha.Text = .OperacionFecha
                    txtSujetoObligado.Text = .SujetoObligado
                    txtOficialCumplimiento.Text = .OficialCumplimiento
                    txtOperacionMonto.Text = .OperacionMonto

                    Select Case .OperacionModalidadId
                        Case 1
                            rbModalidadOperacion1.Checked = True
                        Case 2
                            rbModalidadOperacion2.Checked = True
                        Case 3
                            rbModalidadOperacion3.Checked = True
                    End Select

                    Select Case .OperacionTipoId
                        Case 1
                            rbTipoOperacion1.Checked = True
                        Case 2
                            rbTipoOperacion2.Checked = True
                        Case 3
                            rbTipoOperacion3.Checked = True
                        Case 4
                            rbTipoOperacion4.Checked = True
                        Case 5
                            rbTipoOperacion5.Checked = True
                        Case 6
                            rbTipoOperacion6.Checked = True
                    End Select

                    OperacionFichaDenominacion = .OperacionFichaDenominacion
                    Select Case .OperacionMontoMonedaId
                        Case 1
                            LblFichaTipoMoneda.Text = "S/. " + OperacionFichaDenominacion.ToString()
                        Case 2
                            LblFichaTipoMoneda.Text = "US$ 1000"
                    End Select

                    txtTarjetaNum.Text = .OperacionTarjetaNum.Trim
                    txtCaja.Text = .OperacionCaja.Trim

                    txtFichaCantidad.Text = .OperacionFichaCantidad.ToString
                    lblFichaDenominacion.Text = lblFichaDenominacion.Text.Replace("XXX", .OperacionFichaDenominacion.ToString)
                    txtJackpotMaquina.Text = .OperacionMaquinaNum
                    txtComentario.Text = .OperacionComentario.Trim

                    'Datos de Auditoria:
                    If .AudCreac_UsuarioId > 0 Then
                        txtAudInsUsr.Text = .AudCreac_Usuario
                        txtAudInsFecha.Text = .AudCreac_Fecha
                    End If

                    If .AudEdic_UsuarioId > 0 Then
                        txtAudUpdUsr.Text = .AudEdic_Usuario
                        txtAudUpdFecha.Text = .AudEdic_Fecha
                    End If

                    ClienteLeer(.ClienteId)

                    pbActivo.Visible = False
                    pbInactivo.Visible = False
                    Select Case .EstadoId
                        Case Util.Enumeracion.enmResultadoOperacion.OK
                            pbActivo.Visible = True
                        Case Util.Enumeracion.enmResultadoOperacion.NONE
                            pbInactivo.Visible = True
                    End Select

                    If .EstadoId = Util.Enumeracion.enmResultadoOperacion.OK And tsbEliminar.Visible = True Then
                        tsbEliminar.Visible = True
                    Else
                        tsbEliminar.Visible = False
                    End If

                    Dim strLimiteOperacionCaja() As String = Configuration.ConfigurationManager.AppSettings("FCB_LimiteMontoOperacionCaja").Split("|")
                    Dim intMontoLimiteMonedaId As Integer = strLimiteOperacionCaja(0)
                    Dim decMontoLimiteImporte As Decimal = strLimiteOperacionCaja(1)
                    Dim decMontoImporte As Decimal = 0
                    Dim decTipoCambio As Decimal = .OperacionTipoCambio

                    decMontoImporte = Util.TipoCambio.Valor(.OperacionMontoMonedaId, .OperacionMontoImporte, intMontoLimiteMonedaId, decTipoCambio)

                    If decMontoImporte >= decMontoLimiteImporte And .EstadoId = Util.Enumeracion.enmResultadoOperacion.OK And tsbImprimir.Visible = True Then
                        tsbImprimir.Visible = True
                    Else
                        tsbImprimir.Visible = False
                    End If


                End With

                tssMensaje.Text = Util.Constante.Ope_LeerOK

            Else
                Throw New DataException(Util.Constante.Ope_LeerERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = Util.Constante.Ope_LeerERR & "-" & ex.Message
        End Try

    End Sub

    Private Sub RegistroImprimir()

        Dim arrDatos As New ArrayList
        With arrDatos
            .Add(objOpeBEC)
            .Add(objCliBEC)
        End With

        Dim objFrm As New frmCajaRegistroImprimir(arrDatos)
        objFrm.ShowDialog()
        objFrm.Dispose()

    End Sub

    Private Sub RegistroEliminar()

        Dim objDALC As New DALC.FCB.clsOperacionCaja
        Dim objBEC As New BEC.FCB.clsOperacionCaja
        Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
            Else
                'intUsuarioId = 0 'Prueba!
                Throw New DataException(Util.Constante.Acc_SesionERR)
            End If

            With objBEC
                .OperacionCajaId = lblOperacionCajaId.Text
                .OperacionComentario = txtComentario.Text.Trim
                .AudCreac_UsuarioId = intUsuarioId
            End With
            intResultado = objDALC.Eliminar(objBEC, frmLogin.Unidad)

            If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
                tsbEliminar.Visible = False
                gbComentario.Enabled = False
                tssMensaje.Text = Util.Constante.Ope_EliminarOK

                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                    ' Pista de Auditoría:
                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Delete, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    frmLogin.objColeccionFCB.objAuditoria = Nothing
                    ' Fin de Auditoría
                End If

            Else
                Throw New DataException(Util.Constante.Ope_EliminarERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try

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
        txtTarjetaNum.Text = ""

    End Sub

    Private Sub ClienteLeer(ByVal intClienteId As Integer)

        frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
        objCliBEC = New BEC.CLI.clsCliente

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        Try

            objCliBEC = frmLogin.objColeccionFCB.objCliDALC.Leer(intClienteId, frmLogin.Unidad)

            If objCliBEC IsNot Nothing Then

                With objCliBEC

                    lblClienteId.Text = .ClienteId.ToString

                    txtClienteApellidos.Text = .ClienteApePat.Trim & IIf(.ClienteApeMat.Trim <> "", " " & .ClienteApeMat.Trim, "")
                    txtClienteNombres.Text = .ClienteNombres.Trim
                    txtClienteNumDoc.Text = .ClienteTipoDoc & " " & .ClienteNumDoc
                    txtClientePais.Text = .DomicilioPais.Trim
                    txtClienteNacionalidad.Text = .ClienteNacionalidad

                    txtClienteDireccion.Text = .DomicilioDireccion
                    txtClienteDireccionNro.Text = ""
                    txtClienteDireccionInt.Text = ""
                    txtClienteDireccionUrb.Text = ""
                    txtClienteDireccionDist.Text = .DomicilioCiudad
                    txtClienteDireccionProv.Text = .ClienteProvincia
                    txtClienteDireccionDpto.Text = .ClienteDepartamento

                End With

            Else
                Throw New DataException(Util.Constante.Ope_LeerERR)
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message

        Finally
            frmLogin.objColeccionFCB.objCliDALC = Nothing

        End Try

    End Sub

#End Region

#Region "Eventos de Controles"

    Private Sub frmCajaRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Habilitar según Permisos del Usuario:
        frmLogin.ConfigurarBarraxPermisos(Me.ToolStrip1, Util.Enumeracion.enmSEGModulos.MODCYC)

        RegistroNuevo()

        If intOperacionCajaId <> 0 Then RegistroLeer()

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        gbComentario.Enabled = True
        txtComentario.Focus()
    End Sub

    Private Sub tssImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        RegistroImprimir()
    End Sub

    Private Sub txtComentario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtComentario.KeyDown
        If txtComentario.Text.Length >= 100 Then txtComentario.Text = Mid(txtComentario.Text, 1, 100)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If txtComentario.Text.Trim = "" Then
                Throw New DataException(Util.Constante.Msj_SinDatos)
            Else
                If MsgBox("Desea eliminar la operación?", MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) = MsgBoxResult.Yes Then RegistroEliminar()
            End If

        Catch ex As Exception
            tssMensaje.Text = ex.Message
        End Try

    End Sub

#End Region

End Class