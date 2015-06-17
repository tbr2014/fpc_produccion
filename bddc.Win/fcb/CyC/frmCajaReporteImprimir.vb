Public Class frmCajaReporteImprimir

#Region "Atributos"

    Private arrResultados As ArrayList
    Private strFechaRegistroIni, strFechaRegistroFin As String
    Private decTipoCambio As Decimal
    Private MonedaFicha As String
    Private objBEC As BEC.FCB.clsOperacionCaja
    Private objXML As xmlOperacionCajaReporte
    Private intTipoReporte As Util.Enumeracion.enmFCBReporteOperacionCaja
    Private Unidad As String
    Private Importe As String
    Private Total As String
#End Region

#Region "Operaciones"

    Private Sub CargarDatos()
        '    crvResultados.
        Try

            If arrResultados IsNot Nothing Then

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

                        Select Case frmLogin.Unidad
                            Case "FIESTA CASINO BENAVIDES"
                                With crOperacionCajaReporteVentFich1
                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                    .SetParameterValue("parFichaDenominacion", MonedaFicha)
                                    .SetParameterValue("parCasino", frmLogin.Unidad)
                                    .SetParameterValue("parEncabImporte", "Importe US$")
                                    .SetParameterValue("parTotal", "Total US$")
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteVentFich1
                                crvResultados.Zoom(100)

                            Case "LUXOR LIMA CASINO"
                                With crOperacionCajaReporteVentFich1
                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                    .SetParameterValue("parFichaDenominacion", MonedaFicha)
                                    .SetParameterValue("parCasino", frmLogin.Unidad)
                                    .SetParameterValue("parEncabImporte", "Importe S/.")
                                    .SetParameterValue("parTotal", "Total S/.")
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteVentFich1
                                crvResultados.Zoom(100)

                            Case "LUXOR TACNA"
                                With crOperacionCajaReporteVentFich1
                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                    .SetParameterValue("parFichaDenominacion", MonedaFicha)
                                    .SetParameterValue("parCasino", frmLogin.Unidad)
                                    .SetParameterValue("parEncabImporte", "Importe S/.")
                                    .SetParameterValue("parTotal", "Total S/.")
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteVentFich1
                                crvResultados.Zoom(100)

                            Case "EMPRESA DE PRUEBA"

                                If MonedaFicha.CompareTo("S./ 500") = 0 Then
                                    Unidad = "LUXOR LIMA CASINO"
                                    Importe = "Importe S/."
                                    Total = "Total S/."
                                End If
                                If MonedaFicha.CompareTo("S./ 1000") = 0 Then
                                    Unidad = "LUXOR TACNA"
                                    Importe = "Importe S/."
                                    Total = "Total S/."
                                End If
                                If MonedaFicha.CompareTo("US$ 1000") = 0 Then
                                    Unidad = "EMPRESA DE PRUEBA"
                                    Importe = "Importe US$"
                                    Total = "Total US$"
                                End If

                                With crOperacionCajaReporteVentFich1
                                    .SetDataSource(arrResultados)
                                    .SetParameterValue("parFechaRegistroIni", strFechaRegistroIni)
                                    .SetParameterValue("parFechaRegistroFin", strFechaRegistroFin)
                                    .SetParameterValue("parTipoCambio", decTipoCambio)
                                    .SetParameterValue("parFichaDenominacion", MonedaFicha)
                                    .SetParameterValue("parCasino", Unidad)
                                    .SetParameterValue("parEncabImporte", Importe)
                                    .SetParameterValue("parTotal", Total)
                                End With
                                crvResultados.ReportSource = crOperacionCajaReporteVentFich1
                                crvResultados.Zoom(100)
                        End Select

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

    Public Sub New(ByVal pintTipoReporte As Integer, ByVal parrResultados As ArrayList, ByVal pstrFechaRegistroIni As String, ByVal pstrFechaRegistroFin As String, ByVal pdecTipoCambio As Decimal, ByVal pstrFichaDenominacion As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        arrResultados = parrResultados
        intTipoReporte = pintTipoReporte
        strFechaRegistroIni = pstrFechaRegistroIni
        strFechaRegistroFin = pstrFechaRegistroFin
        decTipoCambio = pdecTipoCambio
        MonedaFicha = pstrFichaDenominacion
        CargarDatos()
    End Sub

    Private Sub frmCajaReporteImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class