Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Reporting
Imports Microsoft.ReportingServices
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmReporte9

    Private objDALC As DALC.CLI.clsReporte
    Private arrResultado As IList
    Private arrBusqueda As IList
    Private arrBeneficiario As IList
    Private arrIntegrantes As IList
    Private arrParam As ArrayList
    Private varGuardar As Boolean



#Region "Operaciones"

    'Obtiene el id de todos los clientes que han sido seleccionados para filtrar el reporte
    Function ClientesSeleccionados() As String
        Dim strClienteSelec As String = ""

        chlClientes.SetItemChecked(cbBeneficiario.SelectedIndex, False)

        If chlClientes.CheckedItems.Count <= 1 Then
            ''MsgBox(Util.Constante.Msg_ClienteNoSeleccionado, MsgBoxStyle.Critical)
            Return strClienteSelec
            Exit Function
        End If


        chlClientes.SetItemChecked(cbBeneficiario.SelectedIndex, True)

        With Me.chlClientes
            For i = 0 To .CheckedItems.Count - 1
                '.SelectedItem = .Items(i)
                'If .CheckedIndices.Item(i) Then
                '    .CheckedItems(i)
                'End If
                .SelectedItem = .CheckedIndices.Item(i)

                If i = .CheckedItems.Count - 1 Then
                    strClienteSelec = strClienteSelec & CType(.CheckedItems(i), BEC.COM.clsItem).ItemId.ToString & ",0"
                Else
                    strClienteSelec = strClienteSelec & CType(.CheckedItems(i), BEC.COM.clsItem).ItemId.ToString & ","
                End If

            Next

            Return strClienteSelec

        End With

        chlClientes.SelectedItem = chlClientes.Items(0)

    End Function

    'Obtiene los clientes que le han registrado rating jugando en la mesa Bacarat 

    Private Sub LeerBeneficiario()

        Dim objUsrDALC As New DALC.FJM.clsCliente

        arrResultado = objUsrDALC.ListarCliMesa(Util.Enumeracion.enmMesasId.MesasPokerBacarat,frmLogin.Unidad )


        With Me.cbBeneficiario
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrResultado

            If Me.txtCcli_id.Text.Length <= 0 Then Exit Sub

            For i = 0 To .Items.Count - 1
                .SelectedIndex = i
                If .SelectedValue = Me.txtCcli_id.Text Then Exit For
            Next

        End With

    End Sub

    Private Sub LeerClientes()

        Dim objUsrDALC As New DALC.FJM.clsCliente
        arrResultado = objUsrDALC.ListarCliMesa(Util.Enumeracion.enmMesasId.MesasPokerBacarat, frmLogin.Unidad)

        objUsrDALC = New DALC.FJM.clsCliente
        arrBusqueda = objUsrDALC.ListarCliMesa(Util.Enumeracion.enmMesasId.MesasPokerBacarat, frmLogin.Unidad)

        With Me.chlClientes
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrResultado
        End With

        With Me.chklBusqueda
            .DisplayMember = "ItemNombre"
            .ValueMember = "ItemId"
            .DataSource = arrBusqueda
        End With

    End Sub

    Public Sub BuscarIntegrantes()
        Dim objUsrDALC As New DALC.FJM.clsCliente
        Dim arrBEC As BEC.COM.clsItem
        Dim intProgreso As Double


        Try

            arrIntegrantes = objUsrDALC.GrupoCliMesa(Me.cbBeneficiario.SelectedValue, frmLogin.Unidad)

            For i = 0 To Me.chlClientes.Items.Count - 1
                chlClientes.SetItemChecked(i, False)
                'arrBEC = arrIntegrantes(i)
                'If arrBEC.ItemId = chlClientes.SelectedValue Then chlClientes.SetItemChecked(i, True)
            Next

            chklBusqueda.SelectedIndex = 0

            If arrIntegrantes Is Nothing Then Exit Sub

            'Dim frm As New frmEsperar
            'frm.chlist = Me.chlClientes
            'frm.arrIntegrantes = Me.arrIntegrantes
            ''frm.Focus()
            'frm.ShowDialog()

            intProgreso = 100 / (arrIntegrantes.Count - 1)
            Me.pbEspera.Value = 0

            Try
                For k As Integer = 0 To arrIntegrantes.Count - 1
                    If pbEspera.Value + intProgreso <= 100 Then pbEspera.Value = pbEspera.Value + intProgreso
                    With Me.chklBusqueda
                        For i = 0 To .Items.Count - 1
                            .SelectedIndex = i

                            arrBEC = arrIntegrantes(k)

                            If arrBEC.ItemId = .SelectedValue Then
                                .SetItemChecked(i, True)
                                Exit For
                            End If

                        Next
                    End With
                Next


                With Me.chklBusqueda
                    For i = 0 To .CheckedItems.Count - 1
                        .SelectedItem = .CheckedIndices.Item(i)
                        chlClientes.SetItemChecked(.CheckedIndices.Item(i), True)
                    Next
                End With

                pbEspera.Value = 0
                lblMensaje.Text = "Busqueda Exitosa"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub


#End Region

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tblfjm_GrupoClienteBaccaratBindingSource.CurrentChanged

    End Sub

    Private Sub frmReporte9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdClientesDataSet1.Fiesta_tblfjm_grupoclientebaccarat' table. You can move, or remove it, as needed.
        Me.Fiesta_tblfjm_grupoclientebaccaratTableAdapter.Fill(Me.BdClientesDataSet1.Fiesta_tblfjm_grupoclientebaccarat)

        txtFechaIni.MaxDate = Today.AddDays(-1).ToShortDateString
        txtFechaFin.MaxDate = Today.AddDays(-1).ToShortDateString
        Dim Inicial As String = Today.AddDays(-1).ToShortDateString.ToString()
        'txtFechaIni.Text = Inicial
        'txtFechaFin.Text = Today.AddDays(-1).ToShortDateString
        lblMensaje.Text = ""
        'dgvResultados.Visible = False
        'crvResultados.Visible = False
        LeerBeneficiario()
        LeerClientes()
        BuscarIntegrantes()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim CliSel As String = ClientesSeleccionados()
        Dim prmParameter(1) As MySqlParameter
        Dim objMySqlConnection As MySqlConnection
        Dim objMySqlCommand As MySqlCommand
        Dim CadenaConexion As String
        Dim intResultado As Integer = 0

        Try

            '********Inserta o Actualiza el grupo de clientes*******

            arrParam = New ArrayList
            With arrParam
                .Add("?p_intClienteId")
                .Add("p_strIntegrantes")
            End With

            prmParameter(0) = New MySqlParameter(arrParam(0).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
            prmParameter(0).Value = Me.cbBeneficiario.SelectedValue

            prmParameter(1) = New MySqlParameter(arrParam(1).ToString, MySqlDbType.VarChar, Util.Constante.DiccionarioDatos.CONST_DOCUMENTO_Largo_65535)
            prmParameter(1).Value = CliSel

            Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")

            If uni = 0 Then
                Util.Factory.ConfigOrigen = 2
                CadenaConexion = Util.Factory.GetConexion

                objMySqlConnection = New MySqlConnection(CadenaConexion)
                objMySqlConnection.Open()

                objMySqlCommand = New MySqlCommand
                With objMySqlCommand
                    .Connection = objMySqlConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "bdcliente.sprfjm_GrupoCliente_Insertar"
                    .Parameters.AddRange(prmParameter)

                    '3. Invocando al SP:
                    intResultado = .ExecuteNonQuery()
                End With

            Else
                Util.Factory.ConfigOrigen = 1
                CadenaConexion = Util.Factory.GetConexion

                objMySqlConnection = New MySqlConnection(CadenaConexion)
                objMySqlConnection.Open()

                objMySqlCommand = New MySqlCommand
                With objMySqlCommand
                    .Connection = objMySqlConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "bdclienteluxor.sprfjm_GrupoCliente_Insertar"
                    .Parameters.AddRange(prmParameter)

                    '3. Invocando al SP:
                    intResultado = .ExecuteNonQuery()
                End With
            End If


            'Inserta en la tabla de eventos la transaccion registrada
            If intResultado = True Then
                If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then
                    Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.OK
                    If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId
                    ' Pista de Auditoría:
                    frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Update, Util.Constante.Sistema._MODFPC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                    frmLogin.objColeccionFCB.objAuditoria = Nothing
                    ' Fin de Auditoría
                End If
            End If

        Catch ex As Exception
            crvResultados.Visible = False
            'dgvResultados.Visible = False
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click
        Dim crComisionBacarat1 As New crComisionBacarat
        Dim CliSel As String = ClientesSeleccionados()
        Dim prmParameter(1) As MySqlParameter

        Try
            arrParam = New ArrayList
            With arrParam
                .Add(txtFechaIni.Text)
                .Add(txtFechaFin.Text)
                .Add(CliSel)
                .Add(Util.Enumeracion.enmMesasId.MesasPokerBacarat)
                .Add(cbBeneficiario.SelectedValue)
            End With

            objDALC = New DALC.CLI.clsReporte
            arrResultado = objDALC.RatingTotal(arrParam, frmLogin.Unidad)

            If arrResultado IsNot Nothing Then

                With crComisionBacarat1
                    .SetDataSource(arrResultado)
                    .SetParameterValue("parFechaIni", arrParam(0))
                    .SetParameterValue("parFechaFin", arrParam(1))
                End With

                crvResultados.Zoom(50)
                crvResultados.ReportSource = crComisionBacarat1
                crvResultados.Visible = True

                'dgvResultados.Visible = True
                'dgvResultados.DataSource = arrResultado
                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
            'dgvResultados.Visible = False
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub chkClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClientes.CheckedChanged
        For i = 0 To Me.chlClientes.Items.Count - 1
            chlClientes.SetItemChecked(i, Me.chkClientes.CheckState)
        Next
    End Sub

    Private Sub cbBeneficiario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBeneficiario.SelectedIndexChanged
        BuscarIntegrantes()
    End Sub

    Private Sub txtFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaFin.ValueChanged
        txtFechaIni.MaxDate = txtFechaFin.Text
    End Sub

    Private Sub Tblfjm_GrupoClienteBaccaratBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tblfjm_GrupoClienteBaccaratBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BdClientesDataSet1)
    End Sub

End Class