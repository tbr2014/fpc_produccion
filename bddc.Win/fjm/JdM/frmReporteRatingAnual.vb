Imports Microsoft.Reporting.WinForms

Public Class frmReporteRatingAnual
    Private objDALC As DALC.CLI.clsReporte
    Private arrResultado As New DataSet
    Private arrParam As ArrayList

    Private Sub btnGenerarRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRpt.Click


        Try
            If cbAño.Text.Trim <> "" Then

                'Dim strFiltroJuegos As String = Configuration.ConfigurationManager.AppSettings("FJM_Rpt8_FiltrodeJuegos")
                'Dim decFactorxPto As Decimal = Convert.ToDecimal(IIf(Configuration.ConfigurationManager.AppSettings("FJM_Rpt8_FactorTicketxPto") Is Nothing, 0, Configuration.ConfigurationManager.AppSettings("FJM_Rpt8_FactorTicketxPto")))

                'XmlWinLossAnual.Tables(1).Clear()
                arrParam = New ArrayList
                With arrParam
                    .Add(cbAño.Text.Trim)
                    '.Add(txtFechaFin.Text.Trim)
                    '.Add(strFiltroJuegos)
                    '.Add(decFactorxPto)
                End With



                Dim s As String = "\\172.20.1.2\Releases\FCB Release\SoftwareNewVersion\Reportes" 'IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)  

                objDALC = New DALC.CLI.clsReporte
                arrResultado = objDALC.RatingTotalAnual(arrParam, frmLogin.Unidad)

                If arrResultado IsNot Nothing Then

                    lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResultado.Tables(0).Rows.Count)
                    Me.ReportViewer1.CancelRendering(1)
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("xmlWinLossAnual_RatingTotal_xAño", arrResultado.Tables(0)))
                    Me.ReportViewer1.LocalReport.ReportPath = s & "\rptRatingTotal_Anual.rdlc" 's & 

                    Me.ReportViewer1.ZoomPercent = 100%
                    Me.ReportViewer1.RefreshReport()
                    Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

                    

                Else
                    Throw New DataException(Util.Constante.Ope_BuscarNONE)

                End If

            Else
                Throw New DataException(Util.Constante.Ope_BuscarSinParametros)
            End If

        Catch ex As Exception
            'crvResultados.Visible = False
            'dgvResultados.Visible = False
            lblMensaje.Text = ex.Message
            MsgBox(ex.Message)
        Finally
            objDALC = Nothing

        End Try
    End Sub

    Private Sub frmReporteRatingAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XmlWinLossAnual.winloss_años' table. You can move, or remove it, as needed.
        Me.Winloss_añosTableAdapter.Fill_Year(Me.XmlWinLossAnual.winloss_años)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class