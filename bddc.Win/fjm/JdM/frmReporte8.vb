Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReporte8

    Private objDALC As DALC.CLI.clsReporte
    Private arrResultado As IList
    Private arrParam As ArrayList

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#Region "Operaciones"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        'Dim objBEC As BEC.COM.clsParametro
        'Dim arrResultados As IList

        Try
            ' 1. Parametro
            'arrResultados = objDL.Seleccionar("22")

            'If arrResultados.Count > 0 Then
            '    Me.cboTipoJuego.Items.Clear()

            '    For k As Integer = 0 To arrResultados.Count - 1
            '        objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
            '        Select Case objBEC.GrupoId
            '            Case Util.Enumeracion.enmGrupoParametro.FJM_TipoJuegoMesa
            '                Me.cboTipoJuego.Items.Add(New BEC.COM.clsItem(objBEC.ParametroId, objBEC.Siglas))
            '        End Select
            '    Next

            '    Me.cboTipoJuego.Items.Insert(0, New BEC.COM.clsItem(Util.Enumeracion.enmResultadoOperacion.NONE, Util.Constante.Opcion_Todos))
            '    Me.cboTipoJuego.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.NONE

            'End If

        Catch ex As Exception
            Me.lblMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

#End Region

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click

        Try
            If txtFechaIni.Text.Trim <> "" And txtFechaFin.Text.Trim <> "" Then

                Dim strFiltroJuegos As String = Configuration.ConfigurationManager.AppSettings("FJM_Rpt8_FiltrodeJuegos")
                Dim decFactorxPto As Decimal = Convert.ToDecimal(IIf(Configuration.ConfigurationManager.AppSettings("FJM_Rpt8_FactorTicketxPto") Is Nothing, 0, Configuration.ConfigurationManager.AppSettings("FJM_Rpt8_FactorTicketxPto")))

                arrParam = New ArrayList
                With arrParam
                    .Add(txtFechaIni.Text.Trim)
                    .Add(txtFechaFin.Text.Trim)
                    .Add(strFiltroJuegos)
                    .Add(decFactorxPto)
                End With

                objDALC = New DALC.CLI.clsReporte
                arrResultado = objDALC.ClientesxJuego(arrParam, frmLogin.Unidad)

                If arrResultado IsNot Nothing Then

                    lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)

                    arrParam = New ArrayList
                    With arrParam
                        .Add(txtFechaIni.Text.Trim)
                        .Add(txtFechaFin.Text.Trim)
                        .Add(decFactorxPto)
                    End With

                    With crResumenPuntajexJuego1
                        .SetDataSource(arrResultado)
                        .SetParameterValue("parFecIni", arrParam(0))
                        .SetParameterValue("parFecFin", arrParam(1))
                        .SetParameterValue("parFactorxPto", arrParam(2))
                    End With

                    crvResultados.Zoom(50)
                    crvResultados.ReportSource = crResumenPuntajexJuego1
                    crvResultados.Visible = True

                Else
                    Throw New DataException(Util.Constante.Ope_BuscarNONE)
                End If

            Else
                Throw New DataException(Util.Constante.Ope_BuscarSinParametros)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
            'dgvResultados.Visible = False
            lblMensaje.Text = ex.Message

        Finally
            objDALC = Nothing

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

    'Private Sub dgvResultados_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvResultados.ColumnHeaderMouseClick

    '    Select Case dgvResultados.SortOrder
    '        Case SortOrder.Ascending, SortOrder.None
    '            dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
    '        Case SortOrder.Descending
    '            dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
    '    End Select

    'End Sub

    Private Sub frmReporte4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LeerParametros()

        txtFechaIni.Text = Today.AddDays(-1).ToShortDateString
        txtFechaFin.Text = Today.AddDays(-1).ToShortDateString
        lblMensaje.Text = ""
        crvResultados.Visible = False
        'dgvResultados.Visible = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class