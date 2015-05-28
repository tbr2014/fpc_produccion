Public Class frmClienteBuscar

    Public intClienteId As Integer
    'Public intClienteId As String
    Private Shared viwBEC As BEC.CLI.viwCliente
    'Private Shared objBEC As BEC.CLI.viwCliente

#Region "Operaciones"

    Private Sub Buscar()
        Try

            frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
            viwBEC = New BEC.CLI.viwCliente
            Dim arrBEC As BEC.CLI.viwCliente()

            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
            Dim arrResultado As ArrayList
            Dim fi As IO.FileInfo

            'Limpiar el datasource del grid
            dgvClientes.DataSource = ""

            If txtBuscarNomb.Text = "" And txtBuscarApe.Text = "" And txtBuscarCodigo.Text = "" And txtBuscarDNI.Text = "" Then

                arrResultado = New ArrayList()
                arrResultado.Add("%")
                arrResultado.Add("%")
                arrResultado.Add("%")
                arrResultado.Add("%")

                arrBEC = frmLogin.objColeccionFCB.objCliDALC.Buscar(arrResultado, frmLogin.Unidad)

                If arrBEC IsNot Nothing Then
                    dgvClientes.Visible = True
                    dgvClientes.DataSource = arrBEC

                    dgvClientes.Columns("ClienteId").Visible = False
                    'dgvClientes.Columns.Remove("ClienteId")
                    dgvClientes.Columns.Remove("ClienteApePat")
                    dgvClientes.Columns.Remove("ClienteApeMat")
                    dgvClientes.Columns.Remove("ClienteNombreCompleto")
                    dgvClientes.Columns.Remove("ClienteEstadoId")

                    dgvClientes.Columns(0).HeaderText = "Id"
                    dgvClientes.Columns(1).HeaderText = "Codigo"
                    dgvClientes.Columns(2).HeaderText = "Apellido"
                    dgvClientes.Columns(3).HeaderText = "Nombre"
                    dgvClientes.Columns(4).HeaderText = "DNI"

                    dgvClientes.Columns(4).DisplayIndex = 1
                    dgvClientes.Columns(1).DisplayIndex = 4

                    'tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", Me.BdClientesDataSet1.Fiesta_tblbdd_clienteBusqueda.Rows.Count)
                Else
                    dgvClientes.Visible = False
                    tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
                End If
            Else

                arrResultado = New ArrayList()
                arrResultado.Add("%" & txtBuscarNomb.Text & "%")
                arrResultado.Add("%" & txtBuscarApe.Text & "%")
                arrResultado.Add("%" & txtBuscarCodigo.Text & "%")
                arrResultado.Add("%" & txtBuscarDNI.Text & "%")

                arrBEC = frmLogin.objColeccionFCB.objCliDALC.Buscar(arrResultado, frmLogin.Unidad)

                If arrBEC IsNot Nothing Then
                    dgvClientes.Visible = True
                    dgvClientes.DataSource = arrBEC

                    dgvClientes.Columns("ClienteId").Visible = False
                    'dgvClientes.Columns.Remove("ClienteId")
                    dgvClientes.Columns.Remove("ClienteApePat")
                    dgvClientes.Columns.Remove("ClienteApeMat")
                    dgvClientes.Columns.Remove("ClienteNombreCompleto")
                    dgvClientes.Columns.Remove("ClienteEstadoId")

                    dgvClientes.Columns(0).HeaderText = "Id"
                    dgvClientes.Columns(1).HeaderText = "Codigo"
                    dgvClientes.Columns(2).HeaderText = "Apellido"
                    dgvClientes.Columns(3).HeaderText = "Nombre"
                    dgvClientes.Columns(4).HeaderText = "DNI"

                    dgvClientes.Columns(4).DisplayIndex = 1
                    dgvClientes.Columns(1).DisplayIndex = 4

                    'tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", Me.BdClientesDataSet1.Fiesta_tblbdd_clienteBusqueda.Rows.Count)
                Else
                    dgvClientes.Visible = False
                    tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

    Private Sub txtBuscarCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarDNI.KeyPress, txtBuscarApe.KeyPress, txtBuscarNomb.KeyPress, txtBuscarCodigo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then Buscar()
    End Sub

    Private Sub txtBuscarTexto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarDNI.KeyDown
        If e.KeyCode = Keys.Down Then dgvClientes.Focus()
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
        If e.KeyCode = Keys.Enter Then          
            intClienteId = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells("Clienteid").Value
            Me.Close()
        End If
    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        intClienteId = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells("Clienteid").Value
        Me.Close()
    End Sub

    Private Sub dgvClientes_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.RowEnter
        Try
            intClienteId = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells("Clienteid").Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmClienteBus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tsslblMensaje.Text = ""
        txtBuscarDNI.Select()
        Buscar()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub txtBuscarNomb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNomb.TextChanged
        Buscar()
    End Sub

    Private Sub txtBuscarApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarApe.TextChanged
        Buscar()
    End Sub

    Private Sub txtBuscarDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarDNI.TextChanged
        Buscar()
    End Sub

    Private Sub txtBuscarCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigo.TextChanged
        Buscar()
    End Sub
End Class