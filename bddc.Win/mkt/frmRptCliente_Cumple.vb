Public Class frmRptCliente_Cumple

    Private objDALC As DALC.CLI.clsReporte
    Private arrResultado As IList
    Private arrParam As ArrayList

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnImprimirRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblMensaje.Text = "En construcción"
    End Sub

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click

        arrParam = New ArrayList
        With arrParam
            .Add(txtFechaIni.Text)
            .Add(txtFechaFin.Text)
        End With

        objDALC = New DALC.CLI.clsReporte
        arrResultado = objDALC.ClientesOnomasticos(arrParam, frmLogin.Unidad)

        If arrResultado IsNot Nothing Then
            dgvResultados.Visible = True
            dgvResultados.DataSource = arrResultado
            lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)

        Else
            dgvResultados.Visible = False
            lblMensaje.Text = Util.Constante.Ope_BuscarNONE
        End If

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

        Select Case dgvResultados.SortOrder
            Case SortOrder.Ascending, SortOrder.None
                dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
            Case SortOrder.Descending
                dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
        End Select

    End Sub

    Private Sub frmReporte4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaIni.Text = Today.AddDays(-1).ToShortDateString
        txtFechaFin.Text = Today.AddDays(-1).ToShortDateString
        lblMensaje.Text = ""
        dgvResultados.Visible = False
    End Sub

End Class