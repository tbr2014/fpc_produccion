Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace FJM

    Public Class clsMesa

        'Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.FJM.clsMesa
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

        Public Function Buscar(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Return Nothing

        End Function

        Public Function Eliminar(ByVal Id As Integer, ByVal Unidad As String) As Integer
            Dim CadenaConexion As String
            Dim intResultado As Integer = 0
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try
                With arrParameter
                    .Add("?p_intMesaId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = Id

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_mesa_eliminar (?p_intMesaId); ", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprljm_mesa_eliminar (?p_intMesaId); ", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprljm_mesa_eliminar (?p_intMesaId); ", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprljm_mesa_eliminar (?p_intMesaId); ", prmParameter)
                End Select

                Return intResultado

            Catch ex As Exception
                Throw New DataException(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.NONE

            End Try


        End Function

        Public Function Escribir(ByRef objBEC As BEC.FJM.clsMesa, ByVal Unidad As String) As Integer
            Dim CadenaConexion As String
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(5) As MySqlParameter

            Try
                prmParameter(0) = New MySqlParameter("?p_intPitId", MySqlDbType.Int16)
                prmParameter(0).Value = objBEC.PitId

                prmParameter(1) = New MySqlParameter("?p_intTipoJuegoId", MySqlDbType.Int16)
                prmParameter(1).Value = objBEC.TipoJuegoId

                prmParameter(2) = New MySqlParameter("?p_strNroMesa", MySqlDbType.String, 50)
                prmParameter(2).Value = objBEC.NroMesa

                prmParameter(3) = New MySqlParameter("?p_intMonedaId", MySqlDbType.Int16)
                prmParameter(3).Value = objBEC.MonedaId

                prmParameter(4) = New MySqlParameter("?p_intEstadoId", MySqlDbType.Int16)
                prmParameter(4).Value = objBEC.EstadoId

                prmParameter(5) = New MySqlParameter("?p_intMesaId", MySqlDbType.Int16)
                prmParameter(5).Value = objBEC.MesaId

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_mesa_escribir (?p_intPitId, ?p_intTipoJuegoId, ?p_strNroMesa, ?p_intMonedaId,?p_intEstadoId,?p_intMesaId); ", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprljm_mesa_escribir (?p_intPitId, ?p_intTipoJuegoId, ?p_strNroMesa, ?p_intMonedaId,?p_intEstadoId,?p_intMesaId); ", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprljm_mesa_escribir (?p_intPitId, ?p_intTipoJuegoId, ?p_strNroMesa, ?p_intMonedaId,?p_intEstadoId,?p_intMesaId); ", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprljm_mesa_escribir (?p_intPitId, ?p_intTipoJuegoId, ?p_strNroMesa, ?p_intMonedaId,?p_intEstadoId,?p_intMesaId); ", prmParameter)
                End Select


                Return intResultado

            Catch ex As Exception
                Throw New DataException(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.NONE
            End Try
        End Function

        Public Function Leer(ByVal Id As Integer, ByVal Unidad As String) As Object

            Return Nothing

        End Function

        Public Function Listar(ByVal Unidad As String) As System.Collections.IList
            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objBEC As BEC.FJM.clsMesa
            Dim arrResultados As ArrayList

            Try

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_mesa_listar ();")
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_mesa_listar ();")
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_mesa_listar ();")
                    Case "EMPRESAS DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_mesa_listar ();")

                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultados = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.FJM.clsMesa

                        With objBEC
                            .MesaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MesaId"))
                            .PitId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("PitId"))
                            .TipoJuegoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .NroMesa = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("NroMesa"))
                            .MonedaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MonedaId"))
                        End With

                        arrResultados.Add(objBEC)
                    Next

                    Return arrResultados

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

    End Class

End Namespace



