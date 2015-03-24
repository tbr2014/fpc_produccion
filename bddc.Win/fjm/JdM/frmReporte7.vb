Public Class frmReporte7

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
            arrResultados = objDL.Seleccionar("22, 23", frmLogin.Unidad)

            If arrResultados.Count > 0 Then
                Me.cboTipoJuego.Items.Clear()
                Me.cboPit.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.FJM_TipoJuegoMesa
                            Me.cboTipoJuego.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))

                        Case Util.Enumeracion.enmGrupoParametro.FJM_Pits
                            Me.cboPit.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Nombre))

                    End Select
                Next

                Me.cboTipoJuego.Items.Insert(0, New BEC.COM.clsItem(Util.Enumeracion.enmResultadoOperacion.NONE, Util.Constante.Opcion_Todos))
                Me.cboTipoJuego.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.NONE

                Me.cboPit.Items.Insert(0, New BEC.COM.clsItem(Util.Enumeracion.enmResultadoOperacion.NONE, Util.Constante.Opcion_Todos))
                Me.cboPit.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.NONE

            End If

        Catch ex As Exception
            Me.lblMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

    Private Sub Buscar()
        Try
            arrParam = New ArrayList
            With arrParam
                .Add(CType(cboPit.SelectedItem, BEC.COM.clsItem).ItemId)
                .Add(CType(cboTipoJuego.SelectedItem, BEC.COM.clsItem).ItemId)
                .Add(txtFechaIni.Text)
                .Add(txtFechaFin.Text)
            End With

            objDALC = New DALC.CLI.clsReporte
            arrResultado = objDALC.RatingPit(arrParam, frmLogin.Unidad)
            crvResultados.Visible = False

            If arrResultado IsNot Nothing Then

                With crRatingPit1
                    .SetDataSource(arrResultado)
                    .SetParameterValue("parPitId", arrParam(0))
                    .SetParameterValue("parFechaIni", arrParam(2))
                    .SetParameterValue("parFechaFin", arrParam(3))
                End With

                crvResultados.Zoom(50)
                crvResultados.ReportSource = crRatingPit1

                crvResultados.Visible = True

                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)
                cboPit.Focus()

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
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

    Private Sub dgvResultados_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

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
        crvResultados.Visible = False
        LeerParametros()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class