Public Class frmRptClientes_Promociones

    Private Shared intTipoReporte As Util.Enumeracion.enmFCBReporteMarketing
    Private Shared arrFiltro As ArrayList

    Public Sub New(ByVal pintTipoReporte As Util.Enumeracion.enmFCBReporteMarketing, ByVal parrFiltro As ArrayList)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Select Case intTipoReporte
            Case Util.Enumeracion.enmFCBReporteMarketing.ClienteSlots
                Me.Text = "Reporte de Clientes de Slots (Table Trac)"

            Case Util.Enumeracion.enmFCBReporteMarketing.ClienteMesas
                Me.Text = "Reporte de Clientes de Mesas"

        End Select

        ' Add any initialization after the InitializeComponent() call.
        intTipoReporte = pintTipoReporte

        arrFiltro = New ArrayList
        If parrFiltro IsNot Nothing Then arrFiltro = parrFiltro

    End Sub

    Private Sub frmRptClientes_Promociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objDALC As New DALC.CLI.clsReporte
        Dim arrResultado As ArrayList

        Try

            arrResultado = objDALC.ReportesMKT(intTipoReporte, arrFiltro, frmLogin.Unidad)

            If arrResultado IsNot Nothing Then
                dgvResultadosSlots.Visible = False
                dgvResultadosMesas.Visible = False

                Select Case intTipoReporte
                    Case Util.Enumeracion.enmFCBReporteMarketing.ClienteSlots
                        dgvResultadosSlots.Visible = True
                        dgvResultadosSlots.DataSource = arrResultado

                    Case Util.Enumeracion.enmFCBReporteMarketing.ClienteMesas
                        dgvResultadosMesas.Visible = True
                        dgvResultadosMesas.DataSource = arrResultado

                End Select

                tssMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Count.ToString)

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            dgvResultadosSlots.Visible = False
            tssMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class