Public Class frmSis_Auditoria

    Private objDALC As DALC.SEG.clsUsuarioEvento
    Private arrResultado As IList
    Private arrParam As ArrayList

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDALC As New DALC.COM.clsParametro
        Dim objDALC2 As New DALC.SEG.clsUsuario
        Dim arrParam As New ArrayList
        Dim arrResultado2 As New ArrayList
        Dim arrResultado3 As IList
        Dim objParam As BEC.COM.clsParametro
        Dim objItem As BEC.COM.clsItem

        ' 1. Cargar Parámetros:
        With arrParam
            .Add(Util.Enumeracion.enmGrupoParametro.SEG_TipoAccion)
            .Add(Util.Enumeracion.enmResultadoOperacion.OK)
        End With

        arrResultado = objDALC.Buscar(arrParam, frmLogin.Unidad)

        For k As Integer = 0 To arrResultado.Count - 1
            objParam = CType(arrResultado(k), BEC.COM.clsParametro)
            objItem = New BEC.COM.clsItem(objParam.ParametroId, objParam.Nombre)
            arrResultado2.Add(objItem)
        Next

        objItem = New BEC.COM.clsItem(-2, Util.Constante.Opcion_Todos)
        arrResultado2.Insert(0, objItem)

        With cbTipoEvento
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrResultado2
            .SelectedIndex = 0
        End With

        ' 2. Cargar Usuarios:
        arrResultado3 = objDALC2.Listar(frmLogin.Unidad)
        With cbUsuario
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrResultado3
            .SelectedIndex = 0
        End With

    End Sub

#End Region

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnImprimirRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblMensaje.Text = "En construcción"
    End Sub

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click

        Try

            arrParam = New ArrayList

            'Dim aux As String() = txtFechaIni.Text.Split(New Char() {"/"c})
            'Dim FechaIni As String = aux(2) & "/" & aux(1) & "/" & aux(0)

            'Dim aux2 As String() = txtFechaFin.Text.Split(New Char() {"/"c})
            'Dim FechaFin As String = aux2(2) & "/" & aux2(1) & "/" & aux2(0)



            With arrParam
                .Add(cbUsuario.SelectedValue)
                .Add(cbTipoEvento.SelectedValue)
                .Add(txtFechaIni.Value)
                .Add(txtFechaFin.Value)
                '.Add(FechaIni)
                '.Add(FechaFin)
            End With

            objDALC = New DALC.SEG.clsUsuarioEvento
            arrResultado = objDALC.Buscar(arrParam, frmLogin.Unidad)

            If arrResultado IsNot Nothing Then

                'With crRatingDetalle1
                '    .SetDataSource(arrResultado)
                '    .SetParameterValue("parFechaIni", arrParam(2))
                '    .SetParameterValue("parFechaFin", arrParam(3))
                'End With

                'crvResultados.Zoom(50)
                'crvResultados.ReportSource = crRatingDetalle1
                'crvResultados.Visible = True

                dgvResultados.Visible = True
                dgvResultados.DataSource = arrResultado
                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)

            Else
                dgvResultados.Visible = False
                lblMensaje.Text = Util.Constante.Ope_BuscarNONE
            End If

        Catch ex As Exception
            'crvResultados.Visible = False
            dgvResultados.Visible = False
            lblMensaje.Text = ex.Message
        End Try

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
        txtFechaIni.Text = Today.ToShortDateString
        txtFechaFin.Text = Today.ToShortDateString
        lblMensaje.Text = ""
        dgvResultados.Visible = False
        'crvResultados.Visible = False
        'chkVistaPreliminar.Checked = False

        LeerParametros()

    End Sub

    'Private Sub chkVistaPreliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dgvResultados.Visible = Not chkVistaPreliminar.Checked
    '    crvResultados.Visible = chkVistaPreliminar.Checked
    'End Sub

End Class