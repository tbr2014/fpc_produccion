Public Class frmCajaReporteImprimir

#Region "Atributos"

    Private arrResultados As ArrayList
    Private strFechaRegistroIni, strFechaRegistroFin As String
    Private decTipoCambio As Decimal
    Private objBEC As BEC.FCB.clsOperacionCaja
    Private objXML As xmlOperacionCajaReporte
    Private intTipoReporte As Util.Enumeracion.enmFCBReporteOperacionCaja

#End Region

#Region "Operaciones"

    Private Sub CargarDatos()
        '    crvResultados.
        Try

            If arrResultados IsNot Nothing Then

                Dim strFichaDenominacion As String = Configuration.ConfigurationManager.AppSettings("FCB_VentaFicha")

                Select Case intTipoReporte

                    Case Util.Enumeracion.enmFCBReporteOperacionCaja.RetiroEfectivoTarjetas

                        Select Case frmLogin.Unidad
                            Case "FIESTA CASINO BENAVIDES"
                                With crOperacionCajaReporteRetEfec_Fiesta1
                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteRetEfec_Fiesta1
                                crvResultados.Zoom(100)

                            Case "LUXOR LIMA CASINO"
                                With crOperacionCajaReporteRetEfec1

                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteRetEfec1
                                crvResultados.Zoom(100)

                            Case "LUXOR TACNA"
                                With crOperacionCajaReporteRetEfec1

                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteRetEfec1
                                crvResultados.Zoom(100)

                            Case "EMPRESA DE PRUEBA"
                                With crOperacionCajaReporteRetEfec_Fiesta1
                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteRetEfec_Fiesta1
                                crvResultados.Zoom(100)
                        End Select
                   
                    Case Util.Enumeracion.enmFCBReporteOperacionCaja.RegistroVentasFichas
                        With crOperacionCajaReporteVentFich1
                            .SetDataSource(arrResultados)
                            .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                            .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                            .SetParameterValue("parTipoCambio", decTipoCambio)
                            .SetParameterValue("parFichaDenominacion", strFichaDenominacion)
                        End With
                        crvResultados.ReportSource = crOperacionCajaReporteVentFich1
                        crvResultados.Zoom(100)

                    Case Util.Enumeracion.enmFCBReporteOperacionCaja.RegistroPagosManuales

                        Dim uni As Integer = StrComp(frmLogin.Unidad, "FIESTA CASINO BENAVIDES")
                        If uni = 0 Then

                            With crOperacionCajaReportePagoManual_Fiesta1
                                .SetDataSource(arrResultados)
                                .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                .SetParameterValue("parTipoCambio", decTipoCambio)
                            End With
                            crvResultados.ReportSource = crOperacionCajaReportePagoManual_Fiesta1
                            crvResultados.Zoom(100)

                        Else
                            With crOperacionCajaReportePagoManual1
                                .SetDataSource(arrResultados)
                                .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                .SetParameterValue("parTipoCambio", decTipoCambio)
                            End With
                            crvResultados.ReportSource = crOperacionCajaReportePagoManual1
                            crvResultados.Zoom(100)

                        End If

                End Select

                crvResultados.Visible = True

                'dgvResultados.Visible = True
                'dgvResultados.DataSource = arrResultado

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
        End Try

    End Sub

#End Region

    Public Sub New(ByVal pintTipoReporte As Integer, ByVal parrResultados As ArrayList, ByVal pstrFechaRegistroIni As String, ByVal pstrFechaRegistroFin As String, ByVal pdecTipoCambio As Decimal)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        arrResultados = parrResultados
        intTipoReporte = pintTipoReporte
        strFechaRegistroIni = pstrFechaRegistroIni
        strFechaRegistroFin = pstrFechaRegistroFin
        decTipoCambio = pdecTipoCambio
        CargarDatos()
    End Sub

    Private Sub frmCajaReporteImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class