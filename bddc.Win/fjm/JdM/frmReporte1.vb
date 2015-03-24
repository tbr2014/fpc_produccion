Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReporte1

    Private objDALC As DALC.CLI.clsReporte
    Private arrResultado As IList
    Private arrParam As ArrayList

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click

        Try
            arrParam = New ArrayList
            With arrParam
                .Add(txtFechaIni.Text)
                .Add(txtFechaFin.Text)
            End With

            objDALC = New DALC.CLI.clsReporte
            arrResultado = objDALC.RatingTotal(arrParam, frmLogin.Unidad)

            If arrResultado IsNot Nothing Then

                With crRatingTotal1
                    .SetDataSource(arrResultado)
                    .SetParameterValue("parFechaIni", arrParam(0))
                    .SetParameterValue("parFechaFin", arrParam(1))
                End With

                crvResultados.Zoom(50)
                crvResultados.ReportSource = crRatingTotal1
                crvResultados.Visible = True

                'dgvResultados.Visible = True
                'dgvResultados.DataSource = arrResultado
                lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count)

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
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

    'Private Sub dgvResultados_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvResultados.ColumnHeaderMouseClick

    '    Select Case dgvResultados.SortOrder
    '        Case SortOrder.Ascending, SortOrder.None
    '            dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
    '        Case SortOrder.Descending
    '            dgvResultados.Sort(dgvResultados.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
    '    End Select

    'End Sub

    Private Sub frmReporte1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaIni.Text = Today.AddDays(-1).ToShortDateString
        txtFechaFin.Text = Today.AddDays(-1).ToShortDateString
        lblMensaje.Text = ""
        'dgvResultados.Visible = False
        crvResultados.Visible = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    
End Class