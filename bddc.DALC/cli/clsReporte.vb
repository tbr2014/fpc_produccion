Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace CLI

    Public Class clsReporte

        Friend Shared objConexion As Util.Factory
        Private objRpt1 As BEC.FJM.rptRatingTotal
        Private objRpt2 As BEC.FJM.rptRatingDetalle
        Private objRpt3 As BEC.CLI.rptCliente
        Private objRpt4 As BEC.FJM.rptPuntaje
        Private objRpt5 As BEC.FJM.rptPuntajeCalendario
        Private objRpt6 As BEC.FJM.rptRatingPit
        Private strConsulta As String = ""
        Private strParametros As String = ""

        Public Sub New()
            objConexion = New Util.Factory
        End Sub


#Region "Reportes FJM"


        Public Function RatingTotalAnual(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As DataSet

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dtsResultado As New DataSet
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                ReDim prmParameter(0)

                With arrParameter
                    .Add("?p_strYear")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_ratingtotal_xAño (?p_strYear);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_ratingtotal_xAño (?p_strYear);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_ratingtotal_xAño (?p_strYear);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_ratingtotal_xAño (?p_strYear);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    Return dtsResultado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function RatingTotal(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.FJM.rptRatingTotal()
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:
                If arrFiltro.Count > 2 Then

                    ReDim prmParameter(4)

                    With arrParameter
                        .Add("?p_strFechaIni")
                        .Add("?p_strFechaFin")
                        .Add("?p_strClientes")
                        .Add("?p_strnroMesa")
                        .Add("?p_intCcliId")
                    End With

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(0).Value = arrFiltro(0)

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(1).Value = arrFiltro(1)

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_DOCUMENTO_Largo_65535)
                    prmParameter(2).Value = arrFiltro(2)

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(3).Value = arrFiltro(3)

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(4).Value = arrFiltro(4)

                    '2. Invocando al SP:

                    Select Case Unidad
                        Case "FIESTA CASINO BENAVIDES"
                            Util.Factory.ConfigOrigen = 1
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_ratingtotal_xMesa (?p_strFechaIni, ?p_strFechaFin, ?p_strClientes, ?p_strnroMesa, ?p_intCcliId);", prmParameter)

                        Case "LUXOR LIMA CASINO"
                            Util.Factory.ConfigOrigen = 2
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_ratingtotal_xMesa (?p_strFechaIni, ?p_strFechaFin, ?p_strClientes, ?p_strnroMesa, ?p_intCcliId);", prmParameter)

                        Case "LUXOR TACNA"
                            Util.Factory.ConfigOrigen = 3
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_ratingtotal_xMesa (?p_strFechaIni, ?p_strFechaFin, ?p_strClientes, ?p_strnroMesa, ?p_intCcliId);", prmParameter)

                        Case "EMPRESA DE PRUEBA"
                            Util.Factory.ConfigOrigen = 5
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_ratingtotal_xMesa (?p_strFechaIni, ?p_strFechaFin, ?p_strClientes, ?p_strnroMesa, ?p_intCcliId);", prmParameter)
                    End Select


                Else

                    With arrParameter
                        .Add("?p_strFechaIni")
                        .Add("?p_strFechaFin")
                    End With

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(0).Value = arrFiltro(0)

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(1).Value = arrFiltro(1)

                    Select Case Unidad
                        Case "FIESTA CASINO BENAVIDES"
                            Util.Factory.ConfigOrigen = 1
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_ratingtotal (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                        Case "LUXOR LIMA CASINO"
                            Util.Factory.ConfigOrigen = 2
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_ratingtotal (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                        Case "LUXOR TACNA"
                            Util.Factory.ConfigOrigen = 3
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_ratingtotal (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                        Case "EMPRESA DE PRUEBA"
                            Util.Factory.ConfigOrigen = 5
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_ratingtotal (?p_strFechaIni, ?p_strFechaFin);", prmParameter)
                    End Select

                End If


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt1 = New BEC.FJM.rptRatingTotal

                        With objRpt1
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                            .DropTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DropTotal"))
                            .WinLossTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("WinLossTotal"))
                            .ApuestaPromTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ApuestaPromTotal"))
                            .TiempoTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TiempoTotal"))
                            If arrFiltro.Count > 2 Then
                                If dtsResultado.Tables(0).Rows(k)("Grupo").ToString = "" Then
                                    .Grupos = "OTROS CLIENTES"
                                Else
                                    .Grupos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Grupo"))
                                End If

                            End If
                        End With

                        arrBEC(k) = objRpt1
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function RatingDetallado(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.FJM.rptRatingDetalle()
            Dim prmParameter(3) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strBuscarCliente")
                    .Add("?p_intTipoJuegoId")
                    .Add("?p_strFechaIni")
                    .Add("?p_strFechaFin")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int16)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(3).Value = arrFiltro(3)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_ratingdetalle (?p_strBuscarCliente, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_ratingdetalle (?p_strBuscarCliente, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_ratingdetalle (?p_strBuscarCliente, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_ratingdetalle (?p_strBuscarCliente, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt2 = New BEC.FJM.rptRatingDetalle

                        With objRpt2
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteNombreCompleto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
                            .MovimientoFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoFecha"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .MovimientoNroMesa = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoNroMesa"))
                            .MovimientoMoneda = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoMoneda"))
                            .MovimientoDrop = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoDrop"))
                            .MovimientoWinLoss = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoWinLoss"))
                            .MovimientoPromedio = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoPromedio"))
                            .MovimientoTiempo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoTiempo"))
                        End With

                        arrBEC(k) = objRpt2
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function RatingPit(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.FJM.rptRatingPit()
            Dim prmParameter(3) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_intPitId")
                    .Add("?p_intTipoJuegoId")
                    .Add("?p_strFechaIni")
                    .Add("?p_strFechaFin")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int16)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int16)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(3).Value = arrFiltro(3)


                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_movimiento_resumenxpit (?p_intPitId, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_movimiento_resumenxpit (?p_intPitId, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_movimiento_resumenxpit (?p_intPitId, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test .sprljm_movimiento_resumenxpit (?p_intPitId, ?p_intTipoJuegoId, ?p_strFechaIni, ?p_strFechaFin);", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt6 = New BEC.FJM.rptRatingPit

                        With objRpt6
                            .Pit = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Pit"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .NroMesa = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("NroMesa"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteNombreCompleto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
                            .FechaProceso = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("FechaProceso"))
                            .TotalDrop = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TotalDrop"))
                            .TotalWinLoss = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TotalWinLoss"))

                        End With

                        arrBEC(k) = objRpt6
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function ClientesDatos(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.CLI.rptCliente()
            Dim prmParameter(2) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strTipoJuego")
                    .Add("?p_strDistrito")
                    .Add("?p_strGeneroId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                prmParameter(2).Value = arrFiltro(2)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_clientes (?p_strTipoJuego, ?p_strDistrito, ?p_strGeneroId);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprfjm_reporte_clientes (?p_strTipoJuego, ?p_strDistrito, ?p_strGeneroId);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprfjm_reporte_clientes (?p_strTipoJuego, ?p_strDistrito, ?p_strGeneroId);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprfjm_reporte_clientes (?p_strTipoJuego, ?p_strDistrito, ?p_strGeneroId);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt3 = New BEC.CLI.rptCliente

                        With objRpt3
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                            .ClienteFecNac = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteFecNac"))
                            .ClienteGeneroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteGeneroId"))
                            .ClienteGenero = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteGenero"))
                            .DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                            .ClienteTelefonos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonos"))
                            .ClienteCorreoElectronico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCorreoElectronico"))
                        End With

                        arrBEC(k) = objRpt3
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function ClientesOnomasticos(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.CLI.rptCliente()
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strFechaIni")
                    .Add("?p_strFechaFin")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_clientes_onomastico (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_clientes_onomastico (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_clientes_onomastico (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_clientes_onomastico (?p_strFechaIni, ?p_strFechaFin);", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt3 = New BEC.CLI.rptCliente

                        With objRpt3
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                            .ClienteFecNac = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteFecNac"))
                            .ClienteEdad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteEdad"))
                            .ClienteGeneroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteGeneroId"))
                            .ClienteGenero = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteGenero"))
                            .DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                            .ClienteTelefonos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonos"))
                            .ClienteCorreoElectronico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCorreoElectronico"))
                        End With

                        arrBEC(k) = objRpt3
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function ClientesPuntaje(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.FJM.rptPuntaje()
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strFechaIni")
                    .Add("?p_strFechaFin")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)


                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_puntaje (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_puntaje (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_puntaje (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_puntaje (?p_strFechaIni, ?p_strFechaFin);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt4 = New BEC.FJM.rptPuntaje

                        With objRpt4
                            .FechaProceso = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("FechaProceso"))
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                            .TipoJuegoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .DropTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DropTotal"))
                            .WinLossTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("WinLossTotal"))
                            .ApuestaPromTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ApuestaPromTotal"))
                            .TiempoTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TiempoTotal"))
                            .PasesHora = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("PasesHora"))
                            .HouseEdge = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("HouseEdge"))
                            .WinTeorico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("WinTeorico"))
                        End With

                        arrBEC(k) = objRpt4
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function ClientesCalendario(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.FJM.rptPuntajeCalendario()
            Dim prmParameter(2) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strFechaIni")
                    .Add("?p_strFechaFin")
                    .Add("?p_intTipoJuegoId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int16)
                prmParameter(2).Value = arrFiltro(2)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_calendario (?p_strFechaIni, ?p_strFechaFin, ?p_intTipoJuegoId);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_calendario (?p_strFechaIni, ?p_strFechaFin, ?p_intTipoJuegoId);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_calendario (?p_strFechaIni, ?p_strFechaFin, ?p_intTipoJuegoId);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_calendario (?p_strFechaIni, ?p_strFechaFin, ?p_intTipoJuegoId);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt5 = New BEC.FJM.rptPuntajeCalendario

                        With objRpt5
                            '.ProcesoAño = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ProcesoAño"))
                            .ProcesoMes = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ProcesoMes"))
                            .ProcesoDia = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ProcesoDia"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                            .TipoJuegoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId"))
                            .WinTeorico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("WinTeorico"))
                        End With

                        arrBEC(k) = objRpt5
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function ClientesxJuego(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.FJM.rptPuntajeCalendario()
            Dim prmParameter(3) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strFechaIni")
                    .Add("?p_strFechaFin")
                    .Add("?p_strTipoJuego")
                    .Add("?p_decFactorxPto")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.Decimal)
                prmParameter(3).Value = arrFiltro(3)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_reporte_juego (?p_strFechaIni, ?p_strFechaFin, ?p_strTipoJuego, ?p_decFactorxPto);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_reporte_juego (?p_strFechaIni, ?p_strFechaFin, ?p_strTipoJuego, ?p_decFactorxPto);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_reporte_juego (?p_strFechaIni, ?p_strFechaFin, ?p_strTipoJuego, ?p_decFactorxPto);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_reporte_juego (?p_strFechaIni, ?p_strFechaFin, ?p_strTipoJuego, ?p_decFactorxPto);", prmParameter)

                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objRpt5 = New BEC.FJM.rptPuntajeCalendario

                        With objRpt5
                            '.ProcesoAño = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ProcesoAño"))
                            '.ProcesoMes = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ProcesoMes"))
                            '.ProcesoDia = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ProcesoDia"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                            .TipoJuegoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .WinTeorico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("WinTeorico"))
                            '.NumCupones = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("NumCupones"))
                        End With

                        arrBEC(k) = objRpt5
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        ' Retorna: 1=Si se realizo, 0=si aún no se aplica.
        Public Function PuntajeHayCierre(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim dtsResultado As New DataSet
            Dim intResultado As Integer = 0

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strFechaProceso")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_puntaje_cierre (?p_strFechaProceso);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_puntaje_cierre (?p_strFechaProceso);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_puntaje_cierre (?p_strFechaProceso);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_puntaje_cierre (?p_strFechaProceso);", prmParameter)
                End Select

                If dtsResultado.Tables(0).Rows.Count > 0 Then
                    intResultado = dtsResultado.Tables(0).Rows(0)(0)

                    If intResultado > 0 Then
                        Return Util.Enumeracion.enmResultadoOperacion.OK
                    Else
                        Return Util.Enumeracion.enmResultadoOperacion.NONE
                    End If
                End If

            Catch ex As Exception
                'Throw New Exception(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function PuntajeProcesoCierre(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim intResultado As Integer = 0

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strFechaProceso")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_proceso_puntaje (?p_strFechaProceso);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprljm_proceso_puntaje (?p_strFechaProceso);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprljm_proceso_puntaje (?p_strFechaProceso);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprljm_proceso_puntaje (?p_strFechaProceso);", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

#End Region

#Region "Reportes MKT"

        Public Function ReportesMKT(ByVal intTipoReporte As Util.Enumeracion.enmFCBReporteMarketing, ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim arrResultado As ArrayList

            Try

                '1. Seleccionar el Reporte:
                Select Case intTipoReporte

                    Case Util.Enumeracion.enmFCBReporteMarketing.ClienteSlots

                        Select Case Unidad
                            Case "FIESTA CASINO BENAVIDES"
                                Util.Factory.ConfigOrigen = 1
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm.sprmkt_clientes_slots();")

                            Case "LUXOR LIMA CASINO"
                                Util.Factory.ConfigOrigen = 2
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprmkt_clientes_slots();")

                            Case "LUXOR TACNA"
                                Util.Factory.ConfigOrigen = 3
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmtacna.sprmkt_clientes_slots();")

                            Case "EMPRESA DE PRUEBA"
                                Util.Factory.ConfigOrigen = 5
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm_test.sprmkt_clientes_slots();")
                        End Select

                    Case Util.Enumeracion.enmFCBReporteMarketing.ClienteMesas

                        '2. Definiendo Parámetros del SP:

                        With arrParameter
                            .Add("?p_strFechaIni")
                            .Add("?p_strFechaFin")
                        End With

                        prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                        prmParameter(0).Value = arrFiltro(0)

                        prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                        prmParameter(1).Value = arrFiltro(1)

                        Select Case Unidad
                            Case "FIESTA CASINO BENAVIDES"
                                Util.Factory.ConfigOrigen = 1
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm.sprmkt_clientes_mesas (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                            Case "LUXOR LIMA CASINO"
                                Util.Factory.ConfigOrigen = 2
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprmkt_clientes_mesas (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                            Case "LUXOR TACNA"
                                Util.Factory.ConfigOrigen = 3
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmtacna.sprmkt_clientes_mesas (?p_strFechaIni, ?p_strFechaFin);", prmParameter)

                            Case "EMPRESA DE PRUEBA"
                                Util.Factory.ConfigOrigen = 5
                                CadenaConexion = Util.Factory.GetConexion
                                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm_test.sprmkt_clientes_mesas (?p_strFechaIni, ?p_strFechaFin);", prmParameter)
                        End Select

                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultado = New ArrayList

                    Select Case intTipoReporte
                        Case Util.Enumeracion.enmFCBReporteMarketing.ClienteSlots

                            Dim objBEC As BEC.CLI.rptClienteSlots

                            For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                                objBEC = New BEC.CLI.rptClienteSlots

                                With objBEC
                                    .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                                    .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                                    .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                                    .DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                                    .ClienteTelefonos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonos"))
                                    .ClienteCorreoElectronico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCorreoElectronico"))

                                    .Tier = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Tier"))
                                    .Rank = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Rank"))
                                    .SlotWager = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("SlotWager"))
                                    .SlotWon = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("SlotWon"))
                                    .SlotPoints = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("SlotPoints"))

                                End With

                                arrResultado.Add(objBEC)

                            Next

                        Case Util.Enumeracion.enmFCBReporteMarketing.ClienteMesas

                            Dim objBEC As BEC.CLI.rptClienteMesas

                            For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                                objBEC = New BEC.CLI.rptClienteMesas

                                With objBEC
                                    .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                                    .ClienteApellidos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApellidos"))
                                    .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                                    .DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                                    .ClienteTelefonos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonos"))
                                    .ClienteCorreoElectronico = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCorreoElectronico"))

                                    .DropTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DropTotal"))
                                    .WinLossTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("WinLossTotal"))
                                    .ApuestaPromtotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ApuestaPromTotal"))
                                    .TiempoTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TiempoTotal"))

                                End With

                                arrResultado.Add(objBEC)

                            Next

                    End Select

                    Return arrResultado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

#End Region

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

    End Class

End Namespace


