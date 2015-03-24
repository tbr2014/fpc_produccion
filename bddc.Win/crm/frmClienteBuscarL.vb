Public Class frmClienteBuscarL


    Public intClienteId As Integer
    Private Shared viwBEC As BEC.CLI.viwCliente

#Region "Operaciones"

    Private Sub Buscar()

        'If txtBuscarNomb.Text = "" And txtBuscarApe.Text = "" And txtBuscarCodigo.Text = "" And txtBuscarReferencia.Text = "" Then
        '    Me.Luxor_tblbdd_clienteBusquedaTableAdapter.Fill(Me.BdClientesDataSet1.Luxor_tblbdd_clienteBusqueda, "%", "%", "%", "%")
        'Else
        '    Me.Luxor_tblbdd_clienteBusquedaTableAdapter.Fill(Me.BdClientesDataSet1.Luxor_tblbdd_clienteBusqueda, "%" & txtBuscarNomb.Text & "%", "%" & txtBuscarApe.Text & "%", "%" & txtBuscarCodigo.Text & "%", "%" & txtBuscarReferencia.Text & "%")       
        'End If

        'If (Me.BdClientesDataSet1.Luxor_tblbdd_clienteBusqueda.Rows.Count > 0) Then
        '    dgvClientes.Visible = True
        '    dgvClientes.DataSource = Me.BdClientesDataSet1.Luxor_tblbdd_clienteBusqueda 'dtsResultado.Tables(0)
        '    tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", Me.BdClientesDataSet1.Luxor_tblbdd_clienteBusqueda.Rows.Count)
        'Else
        '    dgvClientes.Visible = False
        '    tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
        'End If
        Try

            frmLogin.objColeccionFCB.objCliDALC = New DALC.CLI.clsCliente
            viwBEC = New BEC.CLI.viwCliente
            Dim arrBEC As BEC.CLI.viwCliente()

            Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
            Dim arrResultado As ArrayList
            Dim fi As IO.FileInfo

            If txtBuscarNomb.Text = "" And txtBuscarApe.Text = "" And txtBuscarCodigo.Text = "" And txtBuscarReferencia.Text = "" Then

                arrResultado = New ArrayList()
                arrResultado.Add("%")
                arrResultado.Add("%")
                arrResultado.Add("%")
                arrResultado.Add("%")

                arrBEC = frmLogin.objColeccionFCB.objCliDALC.Buscar(arrResultado, frmLogin.Unidad)

                If arrBEC IsNot Nothing Then
                    dgvClientes.Visible = True
                    'dgvClientes.Columns[0].Visible = false
                    dgvClientes.DataSource = arrBEC

                    'tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", Me.BdClientesDataSet1.Fiesta_tblbdd_clienteBusqueda.Rows.Count)
                Else
                    dgvClientes.Visible = False
                    'tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
                End If
            Else

                arrResultado = New ArrayList()
                arrResultado.Add("%" & txtBuscarNomb.Text & "%")
                arrResultado.Add("%" & txtBuscarApe.Text & "%")
                arrResultado.Add("%" & txtBuscarCodigo.Text & "%")
                arrResultado.Add("%" & txtBuscarReferencia.Text & "%")


                arrBEC = frmLogin.objColeccionFCB.objCliDALC.Buscar(arrResultado, frmLogin.Unidad)

                If arrBEC IsNot Nothing Then
                    dgvClientes.Visible = True
                    dgvClientes.DataSource = arrBEC
                    'tsslblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", Me.BdClientesDataSet1.Fiesta_tblbdd_clienteBusqueda.Rows.Count)
                Else
                    dgvClientes.Visible = False
                    'tsslblMensaje.Text = Util.Constante.Ope_BuscarNONE
                End If


            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region


    Private Sub txtBuscarCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarCodigo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then Buscar()
    End Sub

    Private Sub txtBuscarTexto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarNomb.KeyDown
        If e.KeyCode = Keys.Down Then dgvClientes.Focus()
    End Sub

    Private Sub txtBuscarNomb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNomb.TextChanged, txtBuscarApe.TextChanged
        Buscar()
    End Sub

    Private Sub txtBuscarReferencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarReferencia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then Buscar()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub dgvClientes_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.RowEnter
        Try
            intClienteId = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells("Clienteid").Value
        Catch ex As Exception
        End Try
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

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmClienteBus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tsslblMensaje.Text = ""
        Buscar()
    End Sub

End Class