Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace CLI

    Public Class clsClienteTicket
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private viwBEC As BEC.CLI.viwClienteTicket
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
            Dim arrBEC As BEC.CLI.viwClienteTicket()
            Dim prmParameter(4) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strNombre")
                    .Add("?p_strNumDoc")
                    .Add("?p_strNumTarjeta")
                    .Add("?p_intCategoriaId")
                    .Add("?p_intTipoJuegoId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.Int16)
                prmParameter(3).Value = arrFiltro(3)

                prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.Int16)
                prmParameter(4).Value = arrFiltro(4)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfcb_clienteticket_buscar (?p_strNombre, ?p_strNumDoc, ?p_strNumTarjeta, ?p_intCategoriaId, ?p_intTipoJuegoId);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprlim_clienteticket_buscar (?p_strNombre, ?p_strNumDoc, ?p_strNumTarjeta, ?p_intCategoriaId, ?p_intTipoJuegoId);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprlim_clienteticket_buscar (?p_strNombre, ?p_strNumDoc, ?p_strNumTarjeta, ?p_intCategoriaId, ?p_intTipoJuegoId);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprlim_clienteticket_buscar (?p_strNombre, ?p_strNumDoc, ?p_strNumTarjeta, ?p_intCategoriaId, ?p_intTipoJuegoId);", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        viwBEC = New BEC.CLI.viwClienteTicket

                        With viwBEC
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteNombreCompleto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
                            .ClienteNumDoc = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNumDoc"))
                            .ClienteNumTarjeta = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNumTarjeta"))
                            .ClienteCategoriaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCategoriaId"))
                            .TicketsTotal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsTotal"))
                            .TicketsImpresos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsImpresos"))
                            .TicketsPendientes = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsPendientes"))
                            .TicketsFechaImpresion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsFechaImpresion"))
                            .TicketsNumImpresiones = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsNumImpresiones"))
                            .TicketsGUID = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsGUID"))
                            .TicketsImpresionEstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TicketsImpresionEstadoId"))

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

        End Function

        Public Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer Implements COM.ICRUD.Escribir

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(8) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_ccli_id")
                    .Add("?p_scli_numdoc")
                    .Add("?p_scli_nombrecompleto")
                    .Add("?p_scli_numtarjeta")
                    .Add("?p_ncli_ticketsimpresos")
                    .Add("?p_scli_ticketsnuminicial")
                    .Add("?p_scli_ticketsguid")
                    .Add("?p_intTipoJuegoId")
                    .Add("?p_faud_usrid")
                End With

                viwBEC = obj
                With viwBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Value = .ClienteId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                    prmParameter(1).Value = .ClienteNumDoc

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_DESCRIPCION_100)
                    prmParameter(2).Value = .ClienteNombreCompleto

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(3).Value = .ClienteNumTarjeta

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.Int32)
                    prmParameter(4).Value = .TicketsImpresos

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(5).Value = .TicketsNumInicial

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(6).Value = .TicketsGUID

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.Int16)
                    prmParameter(7).Value = .TipoJuegoId

                    prmParameter(8) = New MySqlParameter(arrParameter(8).ToString, MySqlDbType.Int16)
                    prmParameter(8).Value = .AudUsuarioId

                End With

                '2. Formateando Parámetros del SP:
                For k As Integer = 0 To arrParameter.Count - 1
                    strCadena &= arrParameter(k) & ","
                Next
                strCadena = Mid(strCadena, 1, Len(strCadena) - 1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfcb_clienteticket_escribir ( " & strCadena & " );", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprlim_clienteticket_escribir ( " & strCadena & " );", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprlim_clienteticket_escribir ( " & strCadena & " );", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprlim_clienteticket_escribir ( " & strCadena & " );", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Throw New DataException(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function Extornar(ByRef obj As Object, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(2) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_ccli_id")
                    .Add("?p_ncli_ticketshabilitar")
                    .Add("?p_intTipoJuegoId")
                End With

                viwBEC = obj
                With viwBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    'prmParameter(0).Direction = ParameterDirection.InputOutput
                    prmParameter(0).Value = .ClienteId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int32)
                    prmParameter(1).Value = .TicketsPendientes

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int32)
                    prmParameter(2).Value = .TipoJuegoId


                End With

                '2. Formateando Parámetros del SP:
                For k As Integer = 0 To arrParameter.Count - 1
                    strCadena &= arrParameter(k) & ","
                Next
                strCadena = Mid(strCadena, 1, Len(strCadena) - 1)


                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfcb_clienteticket_extornar ( " & strCadena & " );", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfcb_clienteticket_extornar ( " & strCadena & " );", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfcb_clienteticket_extornar ( " & strCadena & " );", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprfcb_clienteticket_extornar ( " & strCadena & " );", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Throw New DataException(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function Leer(ByVal Id As Integer, ByVal Unidad As String) As Object Implements COM.ICRUD.Leer
            Return Nothing
        End Function

    End Class

End Namespace
