Public Class frmClienteTicketBuscar
    Implements IDisposable

    Public objClienteTicket As BEC.CLI.viwClienteTicket
    Public intTipoJuegoId As Util.Enumeracion.enmFJMTipoNegocio

#Region "Operaciones"

    Private Sub Buscar()

        Dim objDALC As New DALC.CLI.clsClienteTicket
        Dim arrParam As New ArrayList
        Dim arrResultado As IList

        arrParam.Add(txtBuscarApeNom.Text.Trim)
        arrParam.Add("") 'Num Doc
        arrParam.Add(txtBuscarNumTarjeta.Text.Trim)
        arrParam.Add(Util.Enumeracion.enmResultadoOperacion.NONE) ' Categoria Id
        arrParam.Add(Me.intTipoJuegoId) 'Tipo Juego Id

        arrResultado = objDALC.Buscar(arrParam, frmLogin.Unidad)

        If arrResultado IsNot Nothing Then
            dgvClientes.DataSource = arrResultado
            tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)
        Else
            tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
        End If
        
        'dgvClientes.Focus()

    End Sub

    Private Sub Seleccionar(ByVal intFila As Integer)

        With objClienteTicket
            .ClienteId = dgvClientes.Rows(intFila).Cells("ClienteId").Value
            .ClienteCodigo = dgvClientes.Rows(intFila).Cells("ClienteCodigo").Value
            .ClienteNombreCompleto = dgvClientes.Rows(intFila).Cells("ClienteNombreCompleto").Value
            .ClienteNumDoc = dgvClientes.Rows(intFila).Cells("ClienteNumDoc").Value
            .ClienteNumTarjeta = dgvClientes.Rows(intFila).Cells("ClienteNumTarjeta").Value
            .ClienteCategoriaId = dgvClientes.Rows(intFila).Cells("ClienteCategoriaId").Value
            .TicketsTotal = dgvClientes.Rows(intFila).Cells("TicketsTotal").Value
            .TicketsImpresos = dgvClientes.Rows(intFila).Cells("TicketsImpresos").Value
            .TicketsPendientes = dgvClientes.Rows(intFila).Cells("TicketsPendientes").Value
            .TicketsFechaImpresion = dgvClientes.Rows(intFila).Cells("TicketsFechaImpresion").Value
            .TicketsNumImpresiones = dgvClientes.Rows(intFila).Cells("TicketsNumImpresiones").Value
            .TicketsImpresionEstadoId = dgvClientes.Rows(intFila).Cells("TicketsImpresionEstadoId").Value
        End With
    End Sub

#End Region

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    'Private Sub txtBuscarApe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarApeNom.KeyPress
    '    If e.KeyChar = vbCr Then Buscar()
    'End Sub

    Private Sub txtBuscarNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNumTarjeta.KeyPress
        If e.KeyChar = vbCr Then Buscar()
    End Sub

    Private Sub dgvClientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Seleccionar(dgvClientes.CurrentRow.Index)
    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        Seleccionar(dgvClientes.CurrentRow.Index)
        Me.Close()
    End Sub

    Private Sub dgvClientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvClientes.KeyPress
        If e.KeyChar = vbCr Then Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmClienteBus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tsslblMensaje.Text = ""
        Buscar()
        txtBuscarApeNom.Focus()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objClienteTicket = New BEC.CLI.viwClienteTicket

    End Sub

    Private Sub txtBuscarApeNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarApeNom.TextChanged
        Buscar()
    End Sub

End Class