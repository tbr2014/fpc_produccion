Public Class frmRatingTraslado

    Private intClienteOrigenId As Integer
    Private intClienteDestinoId As Integer

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub frmRatingTraslado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LeerClientes()
    End Sub

    Private Sub LeerClientes()

        Dim objUsrDALC As New DALC.FJM.clsCliente
        Dim arrClienteOrigen As IList = objUsrDALC.Listar(frmLogin.Unidad)
        Dim arrClienteDestino As IList = objUsrDALC.Listar(frmLogin.Unidad)
        Dim objBEC As New BEC.COM.clsItem

        With objBEC
            .ItemId = Util.Enumeracion.enmResultadoOperacion.NONE
            .ItemNombre = Util.Constante.Opcion_Seleccione
        End With

        With ddlClienteOrigen
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrClienteOrigen
        End With

        ddlClienteOrigen.Text = Util.Constante.Opcion_Seleccione

        With ddlClienteDestino
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrClienteDestino
        End With

        ddlClienteDestino.Text = Util.Constante.Opcion_Seleccione

        tsslblMensaje.Text = ""

    End Sub

    Private Sub AplicarTraslado()

        Dim objDALC As New DALC.CLI.clsMovimiento
        intClienteOrigenId = CType(ddlClienteOrigen.SelectedItem, BEC.COM.clsItem).ItemId
        intClienteDestinoId = CType(ddlClienteDestino.SelectedItem, BEC.COM.clsItem).ItemId

        If intClienteOrigenId <> intClienteDestinoId Then
            If objDALC.Trasladar(intClienteOrigenId, intClienteDestinoId, frmLogin.Unidad) <> Util.Enumeracion.enmResultadoOperacion.ERR Then
                LeerClientes()
                tsslblMensaje.Text = Util.Constante.Ope_OperacionOK
            Else
                tsslblMensaje.Text = Util.Constante.Ope_OperacionERR
            End If
        Else
            tsslblMensaje.Text = Util.Constante.Ope_ProcesoInvalido
        End If

    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        AplicarTraslado()
    End Sub

    Private Sub btnBuscarClienteOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarClienteOrigen.Click
        Try
            Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
            If uni = 0 Then
                Dim objfrm As New frmClienteBuscar
                objfrm.ShowDialog()

                If objfrm.intClienteId > 0 Then
                    intClienteOrigenId = objfrm.intClienteId
                    ddlClienteOrigen.SelectedValue = intClienteOrigenId
                End If

            Else
                Dim objfrm As New frmClienteBuscarL
                objfrm.ShowDialog()

                If objfrm.intClienteId > 0 Then
                    intClienteOrigenId = objfrm.intClienteId
                    ddlClienteOrigen.SelectedValue = intClienteOrigenId
                End If
            End If

        Catch ex As Exception
            tsslblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub btnBuscarClienteDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarClienteDestino.Click
        Try
            Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
            If uni = 0 Then
                Dim objfrm As New frmClienteBuscar
                objfrm.ShowDialog()
                If objfrm.intClienteId > 0 Then
                    intClienteDestinoId = objfrm.intClienteId
                    ddlClienteDestino.SelectedValue = intClienteDestinoId
                End If

            Else
                Dim objfrm As New frmClienteBuscarL
                objfrm.ShowDialog()
                If objfrm.intClienteId > 0 Then
                    intClienteDestinoId = objfrm.intClienteId
                    ddlClienteDestino.SelectedValue = intClienteDestinoId
                End If
            End If

        Catch ex As Exception
            tsslblMensaje.Text = ex.Message
        End Try
    End Sub

End Class