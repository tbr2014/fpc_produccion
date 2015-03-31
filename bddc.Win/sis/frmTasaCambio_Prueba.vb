Public Class frmTasaCambio_Prueba
    Dim boolNuevo As Boolean

#Region "Operaciones"
    Private Sub ValidarRegistros()
        Try

            If dptFecha.Text = "" Then MsgBox("Debe ingresar la fecha. ", MsgBoxStyle.Critical) : dptFecha.Focus() : Exit Sub
            If txtTasa.Text = "" Then MsgBox("Debe ingresar la tasa de cambio. ", MsgBoxStyle.Critical) : txtTasa.Focus() : Exit Sub

            Me.dptFecha.Value = Me.dptFecha.Text
            Me.txtAño.Text = CDate(Me.dptFecha.Text).Year
            Me.txtMes.Text = CDate(Me.dptFecha.Text).Month
            Me.txtDia.Text = CDate(Me.dptFecha.Text).Day

        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub frmTasaCambio_Prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Prueba_tblaux_tipocambioTableAdapter.Fill(Me.BDClientesDataSet.Prueba_tblaux_tipocambio)
        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODTBL)
        dptFecha.Value = DateTime.Today()
        boolNuevo = False
    End Sub

    Private Sub TipoCambioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PruebatblauxtipocambioBindingSource.EndEdit()
        'Me.TableAdapterManager1.UpdateAll(Me.BDClientesDataSet)
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try
            If MsgBox(Util.Constante.Msg_ConfAgregar, MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) <> 6 Then Exit Sub

            Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
            If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
            Else
                Throw New DataException(Util.Constante.Acc_SesionERR)
            End If

            ValidarRegistros()

            Me.PruebatblauxtipocambioBindingSource.MoveNext()
            Me.PruebatblauxtipocambioBindingSource.MovePrevious()

            Me.Prueba_tblaux_tipocambioTableAdapter.Update(BDClientesDataSet.Prueba_tblaux_tipocambio)

            If boolNuevo Then
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODTBL & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                Me.BDClientesDataSet.Prueba_tblaux_tipocambio.Clear()
                Me.Prueba_tblaux_tipocambioTableAdapter.Fill(Me.BDClientesDataSet.Prueba_tblaux_tipocambio)
            Else
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODTBL & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
            End If

            boolNuevo = False

            lblMensaje.ForeColor = Color.Blue
            lblMensaje.Text = Util.Constante.Ope_OperacionOK

        Catch ex As Exception
            lblMensaje.ForeColor = Color.Red
            lblMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub tsbNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Try
            lblMensaje.ForeColor = Color.Gray
            lblMensaje.Text = "<Message>"

            boolNuevo = True
            'Me.BindingSource1.AddNew()
            'Me.txtTasa.Text = 1
            chkEstado.CheckState = CheckState.Checked
            Me.dptFecha.Focus()

        Catch ex As Exception

            boolNuevo = False
            Me.PruebatblauxtipocambioBindingSource.CancelEdit()
            lblMensaje.ForeColor = Color.Red
            lblMensaje.Text = "Error: " & ex.Message

        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub dgTipoCambio_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        lblMensaje.ForeColor = Color.Gray
        lblMensaje.Text = "<Mensaje>"
    End Sub

    Private Sub txtTasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasa.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = Asc(".") Or Asc(e.KeyChar) = Asc("-") Or Asc(e.KeyChar) = Asc(Chr(8)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgTipoCambio_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        boolNuevo = False
        Me.PruebatblauxtipocambioBindingSource.CancelEdit()
        lblMensaje.ForeColor = Color.Red
        lblMensaje.Text = Util.Constante.Ope_OperacionERR & " Fue cancelada. "
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If MsgBox(Util.Constante.Msg_ConfEliminar, MsgBoxStyle.YesNo, Util.Constante.Msj_SistemaTitulo) <> 6 Then Exit Sub

            Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
            If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then
                intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
            Else
                Throw New DataException(Util.Constante.Acc_SesionERR)
            End If

            ValidarRegistros()

            Me.Prueba_tblaux_tipocambioTableAdapter.DeleteTasaCambio(Convert.ToInt32(Me.txtAño.Text), Convert.ToInt32(Me.txtMes.Text), Convert.ToInt32(Me.txtDia.Text))

        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

End Class