Public Class frmRptClientes_Juegos

#Region "Operaciones"

    Private Sub LeerParametros()
        Dim objUbigeo As New DALC.COM.clsUbigeo
        Dim arrParam As New ArrayList
        Dim arrResultado As IList

        With arrParam
            .Add(Util.Enumeracion.enmAUXTipoUbigeo.DISTRITO)
            .Add(Util.Constante.CONST_PROV_LIMA)
        End With

        arrResultado = objUbigeo.Buscar(arrParam, frmLogin.Unidad)

        With cbDistrito
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrResultado
            .SelectedIndex = 0
        End With

    End Sub

#End Region

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
            Dim strTipoJuego As String = ""

            If rbTipoJuego0.Checked Then strTipoJuego = ""
            If rbTipoJuego1.Checked Then strTipoJuego = rbTipoJuego1.Text
            If rbTipoJuego2.Checked Then strTipoJuego = rbTipoJuego2.Text
            If rbTipoJuego3.Checked Then strTipoJuego = rbTipoJuego3.Text
            If rbTipoJuego4.Checked Then strTipoJuego = rbTipoJuego4.Text
            If rbTipoJuego5.Checked Then strTipoJuego = rbTipoJuego5.Text

            .Add(strTipoJuego)
            If cbDistrito.SelectedIndex > 0 Then
                .Add(cbDistrito.Text)
            Else
                .Add("")
            End If
            '.Add(txtDistritoBuscar.Text)

            Dim strSexo As String = ""

            strSexo = IIf(chkSexo1.Checked, "1", "")
            If strSexo = "" Then
                strSexo = IIf(chkSexo2.Checked, "2", "")
            Else
                strSexo &= IIf(chkSexo2.Checked, ",2", "")
            End If

            .Add(strSexo)
        End With

        objDALC = New DALC.CLI.clsReporte
        arrResultado = objDALC.ClientesDatos(arrParam, frmLogin.Unidad)

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

    Private Sub frmReporte2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMensaje.Text = ""
        dgvResultados.Visible = False
        LeerParametros()
    End Sub

End Class