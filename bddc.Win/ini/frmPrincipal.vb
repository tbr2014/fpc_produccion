Public Class frmPrincipal

#Region "Atributos"

    'Variables:
    'Public objColeccionFCB As clsColeccion

    'Public objSistema As frmSist_Parametros
    'Public objAuditoria As frmSist_Auditoria
    Public objMenuOpcion As DALC.SEG.clsMenuOpcion

#End Region

#Region "Constructor/Destructor"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.objColeccionFCB = New clsColeccion
        'objCliReg = New frmClienteRegistro
        'objCliBus = New frmClienteBuscar
        'objRatReg = New frmRatingRegistro

        'frmLogin.objColeccionFCB.objUsuBEC = New BEC.SEG.clsUsuario
        'frmLogin.objColeccionFCB.objUsuBEC.UsuarioId = 0 'Id de Prueba

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        GC.Collect()
    End Sub

#End Region

#Region "Operaciones"

    Private Function Salir() As Boolean

        If MessageBox.Show("Está seguro de salir del sistema?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then

                Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                ' Pista de Auditoría:
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.LogOut, Util.Constante.Sistema._MODSEG & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                frmLogin.objColeccionFCB.objAuditoria = Nothing
                ' Fin de Auditoría

            End If
            Return True
        Else
            Return False
        End If
        
    End Function

#End Region

#Region "Eventos del Formulario"

    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Salir() Then
            e.Cancel = True
        Else
            frmLogin.Show()
        End If

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Me.Text = Util.Constante.Msj_SistemaTitulo

            If frmLogin.objColeccionFCB.arrUsuCfgBEC IsNot Nothing Then

                If frmLogin.objColeccionFCB.arrUsuCfgBEC.Count > 0 Then

                    'Obteniendo los accesos del Usuario:
                    frmLogin.objColeccionFCB.objUsuBEC = CType(frmLogin.objColeccionFCB.arrUsuCfgBEC(0), BEC.SEG.clsUsuario)

                    Dim strCadenaOpciones As String = ""
                    Dim arrConfig As ArrayList = frmLogin.objColeccionFCB.arrUsuCfgBEC(1)
                    UltraToolbarsManager1.Visible = False

                    For k As Integer = 0 To arrConfig.Count - 1
                        If strCadenaOpciones <> "" Then strCadenaOpciones &= "|"
                        strCadenaOpciones &= CType(arrConfig(k), BEC.SEG.clsUsuarioConfig).Opciones
                    Next

                    'Leyendo todas las Opciones de la Aplicación:
                    objMenuOpcion = New DALC.SEG.clsMenuOpcion(frmLogin.Unidad)

                    If strCadenaOpciones <> "" And objMenuOpcion.arrMenuOpcion IsNot Nothing Then

                        UltraToolbarsManager1.Visible = True

                        For k As Integer = 0 To UltraToolbarsManager1.Tools.All.Length - 1
                            UltraToolbarsManager1.Tools(k).SharedProps.Visible = False
                        Next

                        UltraToolbarsManager1.Tools("btnSalir").SharedProps.Visible = True
                        UltraToolbarsManager1.Tools("btnMODGU_PasswordReset").SharedProps.Visible = True

                        'Habilitar segun Accesos asignado:
                        Dim strOpciones() As String = strCadenaOpciones.Split("|")
                        Dim intOpcionId As Integer = 0
                        Dim strOpcion As String = ""

                        For p As Integer = 0 To strOpciones.Length - 1
                            intOpcionId = strOpciones(p)
                            strOpcion = ""

                            For q As Integer = 0 To objMenuOpcion.arrMenuOpcion.Count - 1
                                If intOpcionId = CType(objMenuOpcion.arrMenuOpcion(q), BEC.COM.clsParametro).ParametroId Then
                                    strOpcion = CType(objMenuOpcion.arrMenuOpcion(q), BEC.COM.clsParametro).Nombre
                                    Exit For
                                End If
                            Next


                            If strOpcion <> "" Then
                                'UltraToolbarsManager1.Tools(strOpcion).SharedProps.Enabled = True
                                UltraToolbarsManager1.Tools(strOpcion).SharedProps.Visible = True
                            Else
                                UltraToolbarsManager1.Tools(strOpcion).SharedProps.Visible = False
                            End If

                        Next

                        'Verificar que el grupo de botones tenga al menos un item:
                        Dim intBotonesVisibles As Integer = 0

                        For i As Integer = 0 To UltraToolbarsManager1.Ribbon.Tabs.Count - 1
                            For j As Integer = 0 To UltraToolbarsManager1.Ribbon.Tabs(i).Groups.Count - 1
                                intBotonesVisibles = 0
                                For k As Integer = 0 To UltraToolbarsManager1.Ribbon.Tabs(i).Groups(j).Tools.Count - 1
                                    If UltraToolbarsManager1.Ribbon.Tabs(i).Groups(j).Tools(k).SharedProps.Visible = True Then
                                        intBotonesVisibles += 1
                                    End If
                                Next

                                If intBotonesVisibles <> 0 Then
                                    UltraToolbarsManager1.Ribbon.Tabs(i).Groups(j).Visible = True
                                Else
                                    UltraToolbarsManager1.Ribbon.Tabs(i).Groups(j).Visible = False
                                End If

                            Next
                        Next

                        'Verificar que el ribbon tenga grupos con items:
                        For i As Integer = 0 To UltraToolbarsManager1.Ribbon.Tabs.Count - 1
                            intBotonesVisibles = 0
                            For j As Integer = 0 To UltraToolbarsManager1.Ribbon.Tabs(i).Groups.Count - 1
                                If UltraToolbarsManager1.Ribbon.Tabs(i).Groups(j).Visible = True Then intBotonesVisibles += 1
                            Next

                            If intBotonesVisibles <> 0 Then
                                UltraToolbarsManager1.Ribbon.Tabs(i).Visible = True
                            Else
                                UltraToolbarsManager1.Ribbon.Tabs(i).Visible = False
                            End If

                        Next

                        'Inicializando variables de la aplicación:
                        frmLogin.objColeccionFCB.objCliBEC = New BEC.CLI.clsCliente

                    Else
                        Throw New DataException(Util.Constante.Acc_SesionERR)
                    End If

                Else
                    Throw New DataException(Util.Constante.Acc_SesionERR)
                End If

            Else
                Throw New DataException(Util.Constante.Acc_ConfigERR)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key

            '*********** MESAS ************************
            Case "btnMODFPC_Clientes"
                frmLogin.objCliReg = New frmClienteRegistro(frmLogin.objColeccionFCB.objCliBEC)
                frmLogin.objCliReg.ShowDialog()

            Case "btnMODFPC_MesasRatingRegistro"
                frmLogin.objColeccionFCB.objCliBEC.ClienteId = 0
                frmLogin.objRatReg = New frmRatingRegistro
                frmLogin.objRatReg.ShowDialog()

            Case "btnMODFPC_MesasRatingTraslado"
                Dim objFrm As New frmRatingTraslado
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_MesasEstimado"
                Dim objFrm As New frmEstimadoMesas
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_MesasReportes"
                Dim objFrm As New frmReportesMesas
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_MesasImpresionTickets"
                Dim objFrm As New frmClienteTicketsImprimir
                objFrm.intTipoJuegoId = Util.Enumeracion.enmFJMTipoNegocio.Mesas
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_MesasOperaciones"
                Dim objFrm As New frmMesasOperaciones
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_SlotsReporte"
                Dim objFrm As New frmProcesoTT
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_SlotsImpresionTickets"
                Dim objImpresionTicket As New frmClienteTicketsImprimir
                objImpresionTicket.intTipoJuegoId = Util.Enumeracion.enmFJMTipoNegocio.Slots
                objImpresionTicket.ShowDialog()
                objImpresionTicket.Dispose()

                '*********** CAJA ************************
            Case "btnMODCYC_CajayConteoRegistro"
                Dim objFrm As New frmCajaRegistroOperador
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODCYC_CajayConteoReportes"
                Dim objFrm As New frmCajaReportes
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODCYC_CajayConteoImprimir"
                Dim objFrm As New frmCajaBuscar
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODFPC_MercadeoReportes"
                Dim objFrm As New frmReportesMercadeo
                objFrm.ShowDialog()
                objFrm.Dispose()

                '*********** MERCADEO ************************
            Case "btnMODTBL_AuditoriaEventos"
                Dim objFrm As New frmSis_Auditoria
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODTBL_TipoCambio"

                Select Case frmLogin.Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Dim objFrm As New frmTasaCambio
                        objFrm.ShowDialog()
                        objFrm.Dispose()

                    Case "LUXOR LIMA CASINO"
                        Dim objFrm As New frmTasaCambio_luxor
                        objFrm.ShowDialog()
                        objFrm.Dispose()

                    Case "LUXOR TACNA"
                        Dim objFrm As New frmTasaCambio_Tacna
                        objFrm.ShowDialog()
                        objFrm.Dispose()

                    Case "EMPRESA DE PRUEBA"
                        Dim objFrm As New frmTasaCambio_prueba
                        objFrm.ShowDialog()
                        objFrm.Dispose()
                End Select


                '*********** SISTEMAS ************************
            Case "btnMODTBL_Parametros"
                Dim objFrm As New frmSis_Parametros
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODSEG_AdministracionUsuarios"
                Dim objFrm As New frmSeg_Usuarios
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODSEG_AsignacionAccesos"
                Dim objFrm As New frmSeg_Accesos
                objFrm.ShowDialog()
                objFrm.Dispose()


                '*********** CAJAS ************************
            Case "btnMODCJ_NuevaApertura"
                Dim objFrm As New FormAperturaCaja
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODCJ_CajaAbiertas"
                Dim objFrm As New FormCajasAbiertas
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnMODGU_PasswordReset"

                Dim objFrm As New frmCambioPassword
                objFrm.ShowDialog()
                objFrm.Dispose()

            Case "btnSalir"
                Me.Close()

        End Select

    End Sub

#End Region

End Class