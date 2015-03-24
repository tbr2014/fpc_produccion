Public Class frmSeg_Config_Mesas

    Private objDALC As DALC.FJM.clsMesa
    Private objBEC As BEC.FJM.clsMesa
    Private arrParam As ArrayList

    Private objDALCP As DALC.COM.clsParametro
    Private objBECP As BEC.COM.clsParametro
    Private arrParamP As ArrayList

    Private Sub Cargar()

        Dim arrResultado As IList
        Try

            arrParam = New ArrayList

            arrParam.Add(Util.Enumeracion.enmResultadoOperacion.OK)

            objDALC = New DALC.FJM.clsMesa

            arrResultado = objDALC.Listar(frmLogin.Unidad)

            If arrResultado.Count > 0 Then
                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)
                dgvConfigMesas.DataSource = arrResultado
                'dgvConfigMesas.Columns.RemoveAt(5)
                'dgvConfigMesas.Columns.RemoveAt(5)
            Else
                'lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

            dgvConfigMesas.Focus()

        Catch ex As Exception
            'lblMensaje.Text = Util.Constante.Ope_BuscarERR & " - " & ex.Message
        End Try

  
    End Sub

    Private Sub Nuevo()
        GroupBox1.Enabled = True

        LoadDatosMesa()
        txtNroMesa.Text = String.Empty
        txtMesaId.Text = "0"
    End Sub

    Private Sub LoadDatosMesa()
        Dim arrResultado As IList
        Try
            txtMesaId.Text = "0"
            'lblMesaId.Text = "0"

            arrParamP = New ArrayList
            arrParamP.Add("23")
            arrParamP.Add(Util.Enumeracion.enmResultadoOperacion.OK)

            objDALCP = New DALC.COM.clsParametro
            arrResultado = objDALCP.Buscar(arrParamP, frmLogin.Unidad)

            If arrResultado.Count > 0 Then
                'lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)

                cbxPit.DisplayMember = "Nombre"
                cbxPit.ValueMember = "ParametroId"
                cbxPit.DataSource = arrResultado
            Else
                'lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

            arrParamP.Clear()
            arrParamP.Add("22")
            arrParamP.Add(Util.Enumeracion.enmResultadoOperacion.OK)

            objDALCP = New DALC.COM.clsParametro
            arrResultado = objDALCP.Buscar(arrParamP, frmLogin.Unidad)

            If arrResultado.Count > 0 Then
                'lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)

                cbxTipoJuego.DisplayMember = "Nombre"
                cbxTipoJuego.ValueMember = "ParametroId"
                cbxTipoJuego.DataSource = arrResultado
            Else
                'lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

            arrParamP.Clear()
            arrParamP.Add("7")
            arrParamP.Add(Util.Enumeracion.enmResultadoOperacion.OK)

            objDALCP = New DALC.COM.clsParametro
            arrResultado = objDALCP.Buscar(arrParamP, frmLogin.Unidad)

            If arrResultado.Count > 0 Then
                'lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)

                cbxMoneda.DisplayMember = "Nombre"
                cbxMoneda.ValueMember = "ParametroId"
                cbxMoneda.DataSource = arrResultado
            Else
                'lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If


        Catch ex As Exception
            lblMensaje.Text = Util.Constante.Ope_BuscarERR & " - " & ex.Message
        End Try
    End Sub

    Private Function Eliminar() As Boolean
        Dim mesaId As Integer
        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        mesaId = Convert.ToInt32(txtMesaId.Text)

        intResultado = objDALC.Eliminar(mesaId, frmLogin.Unidad)

        If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
            lblMensaje.Text = Util.Constante.Ope_EscribirOK

            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                ' Pista de Auditoría:
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODTBL & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                frmLogin.objColeccionFCB.objAuditoria = Nothing
                ' Fin de Auditoría
            End If
            Return True
        Else
            lblMensaje.Text = Util.Constante.Ope_EscribirERR
            Return False
        End If

    End Function

    Private Function Guardar() As Boolean

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        objBEC = New BEC.FJM.clsMesa
        'objBEC = New BEC.COM.clsParametro

        With objBEC
            .PitId = cbxPit.SelectedValue
            .TipoJuegoId = cbxTipoJuego.SelectedValue
            .NroMesa = txtNroMesa.Text
            .MonedaId = cbxMoneda.SelectedValue
            .EstadoId = 1
            .MesaId = Convert.ToInt32(txtMesaId.Text)

        End With

        objDALC = New DALC.FJM.clsMesa
        
        intResultado = objDALC.Escribir(objBEC, frmLogin.Unidad)

        If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
            lblMensaje.Text = Util.Constante.Ope_EscribirOK

            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                ' Pista de Auditoría:
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODTBL & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                frmLogin.objColeccionFCB.objAuditoria = Nothing
                ' Fin de Auditoría
            End If

            Return True
        Else
            lblMensaje.Text = Util.Constante.Ope_EscribirERR
            Return False
        End If

    End Function

    Private Sub frmSistema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODTBL)
        lblMensaje.Text = ""
        Cargar()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If Guardar() Then Cargar()
    End Sub

    Private Sub dgvConfigMesas_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConfigMesas.CellContentDoubleClick, dgvConfigMesas.CellDoubleClick

        LoadDatosMesa()

        Dim intFila As Integer = e.RowIndex
        Dim pit As String
        Dim Juego As String
        Dim Moneda As String

        With dgvConfigMesas.Rows(intFila)
            pit = .Cells("PitId").Value.ToString()
            cbxPit.SelectedValue = Integer.Parse(pit)

            Juego = .Cells("TipoJuego").Value.ToString()
            Select Case Juego
                Case "RL"
                    cbxTipoJuego.SelectedValue = 1
                Case "BJ"
                    cbxTipoJuego.SelectedValue = 2
                Case "PK"
                    cbxTipoJuego.SelectedValue = 3
                Case "THP"
                    cbxTipoJuego.SelectedValue = 4
            End Select

            txtNroMesa.Text = .Cells("NroMesa").Value

            Moneda = .Cells("MonedaId").Value.ToString()
            cbxMoneda.SelectedValue = Integer.Parse(Moneda)
            txtMesaId.Text = .Cells("MesaId").Value.ToString()
            'lblMesaId.Text = .Cells("MesaId").Value.ToString()
        End With

        GroupBox1.Enabled = True

    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        If Eliminar() Then Cargar()
    End Sub
End Class