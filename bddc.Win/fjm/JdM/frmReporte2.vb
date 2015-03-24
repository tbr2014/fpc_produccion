Public Class frmReporte2

    Private objDALC As DALC.CLI.clsReporte
    Private arrResultado As IList
    Private arrParam As ArrayList

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try
            ' 1. Parametro
            arrResultados = objDL.Seleccionar("22", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                Me.cboTipoJuego.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.FJM_TipoJuegoMesa
                            Me.cboTipoJuego.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
                    End Select
                Next

                Me.cboTipoJuego.Items.Insert(0, New BEC.COM.clsItem(Util.Enumeracion.enmResultadoOperacion.NONE, Util.Constante.Opcion_Todos))
                Me.cboTipoJuego.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.NONE

            End If

        Catch ex As Exception
            Me.lblMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub LeerClientes()

        Dim objUsrDALC As New DALC.FJM.clsCliente

        arrResultado = objUsrDALC.Listar(frmLogin.Unidad)

        With txtBuscarCliente
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrResultado
        End With

        txtBuscarCliente.Text = ""
    End Sub

    Private Sub Buscar()
        Try
            arrParam = New ArrayList
            With arrParam
                .Add(txtBuscarCliente.Text)
                .Add(CType(cboTipoJuego.SelectedItem, BEC.COM.clsItem).ItemId)
                .Add(txtFechaIni.Text)
                .Add(txtFechaFin.Text)
            End With

            objDALC = New DALC.CLI.clsReporte
            arrResultado = objDALC.RatingDetallado(arrParam, frmLogin.Unidad)

            If arrResultado IsNot Nothing Then

                With crRatingDetalle1
                    .SetDataSource(arrResultado)
                    .SetParameterValue("parFechaIni", arrParam(2))
                    .SetParameterValue("parFechaFin", arrParam(3))
                End With

                crvResultados.Visible = False
                crvResultados.Zoom(50)
                crvResultados.ReportSource = crRatingDetalle1

                dgvResultados.Visible = False
                dgvResultados.DataSource = arrResultado

                If chkVistaPreliminar.Checked Then
                    crvResultados.Visible = True
                Else
                    dgvResultados.Visible = True
                End If

                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)
                txtBuscarCliente.Focus()

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
            dgvResultados.Visible = False
            lblMensaje.Text = ex.Message
        End Try
    End Sub

#End Region

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnImprimirRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblMensaje.Text = "En construcción"
    End Sub

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click
        Buscar()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub dgvResultados_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvResultados.ColumnHeaderMouseClick

        'Select Case dgvResultados.SortOrder
        '    Case SortOrder.Ascending, SortOrder.None
        '        dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
        '    Case SortOrder.Descending
        '        dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
        'End Select

    End Sub

    Private Sub frmReporte2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaIni.Text = Today.AddDays(-1).ToShortDateString
        txtFechaFin.Text = Today.AddDays(-1).ToShortDateString
        lblMensaje.Text = ""
        dgvResultados.Visible = True
        crvResultados.Visible = False
        chkVistaPreliminar.Checked = False
        LeerClientes()
        LeerParametros()
    End Sub

    Private Sub chkVistaPreliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVistaPreliminar.CheckedChanged
        dgvResultados.Visible = Not chkVistaPreliminar.Checked
        crvResultados.Visible = chkVistaPreliminar.Checked
    End Sub

    Private Sub txtBuscarCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarCliente.KeyDown
        If e.KeyCode = Keys.Enter Then Buscar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    
End Class