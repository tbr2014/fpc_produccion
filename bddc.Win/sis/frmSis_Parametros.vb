Public Class frmSis_Parametros

#Region "Operaciones"

    Private objDALC As DALC.COM.clsParametro
    Private objBEC As BEC.COM.clsParametro
    Private arrParam As ArrayList

    Private Sub Nuevo()
        'cboGrupo.SelectedValue = 20 'Convert.ToInt16(Util.Enumeracion.enmGrupoParametro.FJM_ParametrosSistema)
        lblParametroId.Text = "0"
        txtParametro.Text = ""
        txtSiglas.Text = ""
        cboEstado.SelectedValue = 1 'Convert.ToInt16(Util.Enumeracion.enmResultadoOperacion.OK)
    End Sub

    Private Sub LeerParametros()
        objDALC = New DALC.COM.clsParametro

        Dim arrResultado As IList = objDALC.Seleccionar("0, 1", frmLogin.Unidad)
        Dim arrGrupo As New ArrayList
        Dim arrEstado As New ArrayList

        For k As Integer = 0 To arrResultado.Count - 1
            objBEC = CType(arrResultado(k), BEC.COM.clsParametro)

            With objBEC
                Select Case .GrupoId
                    Case Util.Enumeracion.enmGrupoParametro.MaestroGrupos
                        arrGrupo.Add(objBEC)

                    Case Util.Enumeracion.enmGrupoParametro.Estado
                        arrEstado.Add(objBEC)
                End Select

            End With

        Next

        With cboGrupo
            .DisplayMember = "Nombre"
            .ValueMember = "ParametroId"
            .DataSource = arrGrupo
        End With

        With cboEstado
            .DisplayMember = "Nombre"
            .ValueMember = "ParametroId"
            .DataSource = arrEstado
        End With

        cboGrupo.SelectedValue = Util.Enumeracion.enmGrupoParametro.FJM_ParametrosSistema
        cboEstado.SelectedValue = Util.Enumeracion.enmResultadoOperacion.OK

    End Sub

    Private Sub Buscar()

        Dim arrResultado As IList

        Try

            arrParam = New ArrayList
            If cboEstado.SelectedValue Then
                arrParam.Add(cboGrupo.SelectedValue)
            Else
                arrParam.Add(Util.Enumeracion.enmGrupoParametro.FJM_ParametrosSistema)
            End If

            arrParam.Add(Util.Enumeracion.enmResultadoOperacion.OK)

            objDALC = New DALC.COM.clsParametro
            arrResultado = objDALC.Buscar(arrParam, frmLogin.Unidad)

            If arrResultado.Count > 0 Then
                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)
                dgvParametros.DataSource = arrResultado
            Else
                lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

            dgvParametros.Focus()

        Catch ex As Exception
            lblMensaje.Text = Util.Constante.Ope_BuscarERR & " - " & ex.Message
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

        objBEC = New BEC.COM.clsParametro

        With objBEC
            .GrupoId = cboGrupo.SelectedValue
            .ParametroId = lblParametroId.Text
            .Nombre = txtParametro.Text.Trim
            .Siglas = txtSiglas.Text.Trim
            .EstadoId = cboEstado.SelectedValue
        End With

        objDALC = New DALC.COM.clsParametro
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

#End Region

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmSistema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmLogin.ConfigurarBarraxPermisos(ToolStrip1, Util.Enumeracion.enmSEGModulos.MODTBL)
        lblMensaje.Text = ""
        LeerParametros()

        Buscar()

    End Sub

    Private Sub dgvParametros_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvParametros.CellContentDoubleClick
        Dim intFila As Integer = e.RowIndex

        With dgvParametros.Rows(intFila)
            cboGrupo.SelectedValue = .Cells("GrupoId").Value
            lblParametroId.Text = .Cells("ParametroId").Value
            txtParametro.Text = .Cells("Nombre").Value
            txtSiglas.Text = .Cells("Siglas").Value
            cboEstado.SelectedValue = .Cells("EstadoId").Value
        End With
    End Sub

    Private Sub dgvParametros_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvParametros.CellEnter
        Dim intFila As Integer = dgvParametros.CurrentRow.Index

        With dgvParametros.Rows(intFila)
            cboGrupo.SelectedValue = .Cells("GrupoId").Value
            lblParametroId.Text = .Cells("ParametroId").Value
            txtParametro.Text = .Cells("Nombre").Value
            txtSiglas.Text = .Cells("Siglas").Value
            cboEstado.SelectedValue = .Cells("EstadoId").Value
        End With

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If Guardar() Then Buscar()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        Buscar()
    End Sub

    Private Sub btnConfigMesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigMesas.Click
        Dim objFrm As New frmSeg_Config_Mesas
        objFrm.ShowDialog()
        objFrm.Dispose()
    End Sub
End Class