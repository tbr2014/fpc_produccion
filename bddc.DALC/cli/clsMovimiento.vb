Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DL.DAC

Namespace CLI

    Public Class clsMovimiento
        Implements DALC.COM.ICRUD

        Public Shared objConexion As Util.Factory

        Private objBEC As BEC.CLI.clsMovimiento
        Private viwBEC As BEC.CLI.viwMovimiento
        Private strConsulta As String = ""
        Private strParametros As String = ""
        Private objMySqlConnection As MySqlConnection
        Private objMySqlCommand As MySqlCommand

        Sub New()
            objConexion = New Util.Factory
            strConsulta = ""
            strParametros = ""
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Function Buscar(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList Implements COM.ICRUD.Buscar
            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.CLI.viwMovimiento()
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_ccli_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = arrFiltro(0)

                '2. Formateando Parámetros del SP:

                For k As Integer = 0 To arrParameter.Count - 1
                    strParametros &= arrParameter(k)
                    If k < arrParameter.Count - 1 Then strParametros &= ", "
                Next

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_movimiento_buscar (" & strParametros & ");", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_movimiento_buscar (" & strParametros & ");", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_movimiento_buscar (" & strParametros & ");", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_movimiento_buscar (" & strParametros & ");", prmParameter)

                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        viwBEC = New BEC.CLI.viwMovimiento

                        With viwBEC
                            .MovimientoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoId"))
                            .MovimientoFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoFecha"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .MovimientoNroMesa = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoNroMesa"))
                            .MovimientoMoneda = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoMoneda"))
                            .MovimientoDrop = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoDrop"))
                            .MovimientoWinLoss = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoWinLoss"))
                            .MovimientoApuestaProm = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoApuestaProm"))
                            .MovimientoHoraIni = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoHoraIni"))
                            .MovimientoHoraFin = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoHoraFin"))
                            .MovimientoDuracionHr = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoDuracionHr"))

                        End With

                        arrBEC(k) = viwBEC
                    Next

                    Return arrBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Eliminar(ByVal Id As Integer, ByVal Unidad As String) As Integer Implements COM.ICRUD.Eliminar

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_cmov_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = Id

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_movimiento_eliminar (?p_cmov_id);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprfjm_movimiento_eliminar (?p_cmov_id);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprfjm_movimiento_eliminar (?p_cmov_id);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprfjm_movimiento_eliminar (?p_cmov_id);", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer Implements COM.ICRUD.Escribir

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(13) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_cmov_id")
                    .Add("?p_ccli_id")
                    .Add("?p_smov_fecha")
                    .Add("?p_fmov_tipojuegoid")
                    .Add("?p_smov_nromesa")
                    .Add("?p_fmov_monedaid")
                    .Add("?p_nmov_drop")
                    .Add("?p_nmov_winloss")
                    .Add("?p_nmov_apuestaprom")
                    .Add("?p_smov_horaini")
                    .Add("?p_smov_horafin")
                    .Add("?p_nmov_duracionhr")
                    .Add("?p_fmov_estadoid")
                    .Add("?p_faud_usrid")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int64)
                    'prmParameter(0).Direction = ParameterDirection.InputOutput
                    prmParameter(0).Value = .MovimientoId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int32)
                    prmParameter(1).Direction = ParameterDirection.Output
                    prmParameter(1).Value = .ClienteId

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(2).Value = .MovimientoFecha

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.Int16)
                    prmParameter(3).Value = .TipoJuegoId

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(4).Value = .MovimientoNroMesa

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.Int16)
                    prmParameter(5).Value = .MovimientoMonedaId

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.Decimal)
                    prmParameter(6).Value = .MovimientoDrop

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.Decimal)
                    prmParameter(7).Value = .MovimientoWinLoss

                    prmParameter(8) = New MySqlParameter(arrParameter(8).ToString, MySqlDbType.Decimal)
                    prmParameter(8).Value = .MovimientoApuestaProm

                    prmParameter(9) = New MySqlParameter(arrParameter(9).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(9).Value = .MovimientoHoraIni

                    prmParameter(10) = New MySqlParameter(arrParameter(10).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(10).Value = .MovimientoHoraFin

                    prmParameter(11) = New MySqlParameter(arrParameter(11).ToString, MySqlDbType.Decimal)
                    prmParameter(11).Value = .MovimientoDuracionHr

                    prmParameter(12) = New MySqlParameter(arrParameter(12).ToString, MySqlDbType.Int16)
                    prmParameter(12).Value = .MovimientoEstadoId

                    prmParameter(13) = New MySqlParameter(arrParameter(13).ToString, MySqlDbType.Int16)
                    prmParameter(13).Value = .AudCreac_UsuarioId

                End With


                For k As Integer = 0 To arrParameter.Count - 1
                    strCadena &= arrParameter(k) & ","
                Next
                strCadena = Mid(strCadena, 1, Len(strCadena) - 1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_movimiento_escribir ( " & strCadena & " );", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprfjm_movimiento_escribir ( " & strCadena & " );", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteltacna.sprfjm_movimiento_escribir ( " & strCadena & " );", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprfjm_movimiento_escribir ( " & strCadena & " );", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Throw New DataException(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function Leer(ByVal Id As Integer, ByVal Unidad As String) As Object Implements COM.ICRUD.Leer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_cmov_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = Id

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_movimiento_leer (?p_cmov_id);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_movimiento_leer (?p_cmov_id);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_movimiento_leer (?p_cmov_id);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_movimiento_leer (?p_cmov_id);", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    Dim k As Integer = 0
                    objBEC = New BEC.CLI.clsMovimiento

                    With objBEC
                        .MovimientoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoId"))
                        .MovimientoFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoFecha"))
                        .TipoJuegoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId"))
                        .MovimientoNroMesa = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoNroMesa"))
                        .MovimientoMonedaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoMonedaId"))
                        .MovimientoDrop = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoDrop"))
                        .MovimientoWinLoss = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoWinLoss"))
                        .MovimientoApuestaProm = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoApuestaProm"))
                        .MovimientoHoraIni = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoHoraIni"))
                        .MovimientoHoraFin = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoHoraFin"))
                        .MovimientoDuracionHr = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MovimientoDuracionHr"))

                    End With

                    Return objBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Procesar() As Integer

            Dim CadenaConexion As String = Util.Factory.GetConexion_SQLSERVER

            Dim intResultado As Integer = 0

            Try

                intResultado = SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "SPRBDD_CLIENTE_CONSUMOS_TTR")

                Return intResultado

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Util.Enumeracion.enmResultadoOperacion.NONE

        End Function

        Public Function Trasladar(ByVal intClienteOrigenId As Integer, ByVal intClienteDestinoId As Integer, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_ccli_id_origen")
                    .Add("?p_ccli_id_destino")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = intClienteOrigenId

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int32)
                prmParameter(1).Value = intClienteDestinoId


                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_movimiento_trasladar (?p_ccli_id_origen, ?p_ccli_id_destino);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprljm_movimiento_trasladar (?p_ccli_id_origen, ?p_ccli_id_destino);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprljm_movimiento_trasladar (?p_ccli_id_origen, ?p_ccli_id_destino);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprljm_movimiento_trasladar (?p_ccli_id_origen, ?p_ccli_id_destino);", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

    End Class

End Namespace


