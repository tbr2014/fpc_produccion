Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace FJM

    Public Class clsOperacionMesa
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.FJM.clsOperacionMesa
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

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(5) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim arrResultados As ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_sopm_fechaproceso")
                    .Add("?p_fopm_tipooperacionid")
                    .Add("?p_fopm_tipojuegoid")
                    .Add("?p_sopm_nromesa")
                    .Add("?p_faud_usrid")
                    .Add("?p_intUltOp")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int32)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int32)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                prmParameter(3).Value = arrFiltro(3)

                prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.Int32)
                prmParameter(4).Value = arrFiltro(4)

                prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.Int32)
                prmParameter(5).Value = arrFiltro(5)

                '2. Formateando Parámetros del SP:

                For k As Integer = 0 To arrParameter.Count - 1
                    strParametros &= arrParameter(k)
                    If k < arrParameter.Count - 1 Then strParametros &= ", "
                Next

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_operacionmesa_buscar (" & strParametros & ");", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_operacionmesa_buscar (" & strParametros & ");", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_operacionmesa_buscar (" & strParametros & ");", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_operacionmesa_buscar (" & strParametros & ");", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultados = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.FJM.clsOperacionMesa

                        With objBEC
                            .OperacionMesaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMesaId"))
                            .FechaProceso = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("FechaProceso"))
                            .TipoOperacionId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoOperacionId"))
                            .TipoOperacion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoOperacion"))
                            .TipoJuegoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId"))
                            .TipoJuego = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuego"))
                            .NroMesa = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("NroMesa"))
                            .PersonalAsignado = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("PersonalAsignado"))
                            .Denominaciones = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Denominaciones"))
                            .FlotaFichas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("FlotaFichas"))
                            .Comentarios = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Comentarios"))
                            .AudCreac_UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_UsuarioId"))
                            .AudCreac_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Usuario"))
                            .AudCreac_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Fecha"))
                            .AudEdic_UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_UsuarioId"))
                            .AudEdic_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Usuario"))
                            .AudEdic_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Fecha"))
                            .EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstadoId"))
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

        Public Function Eliminar(ByVal Id As Integer, ByVal Unidad As String) As Integer Implements COM.ICRUD.Eliminar


        End Function

        Public Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer Implements COM.ICRUD.Escribir

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(9) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_copm_id")
                    .Add("?p_sopm_fechaproceso")
                    .Add("?p_fopm_tipooperacionid")
                    .Add("?p_fopm_tipojuegoid")
                    .Add("?p_sopm_nromesa")
                    .Add("?p_sopm_personalasignado")
                    .Add("?p_sopm_flotafichas")
                    .Add("?p_sopm_comentarios")
                    .Add("?p_faud_usrid")
                    .Add("?fopm_estadoid")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Value = .OperacionMesaId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(1).Value = .FechaProceso

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int16)
                    prmParameter(2).Value = .TipoOperacionId

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.Int16)
                    prmParameter(3).Value = .TipoJuegoId

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(4).Value = .NroMesa

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_DESCRIPCION_100)
                    prmParameter(5).Value = .PersonalAsignado

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_DESCRIPCION_100)
                    prmParameter(6).Value = .FlotaFichas

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_DESCRIPCION_100)
                    prmParameter(7).Value = .Comentarios.Trim

                    prmParameter(8) = New MySqlParameter(arrParameter(8).ToString, MySqlDbType.Int16)
                    prmParameter(8).Value = .AudCreac_UsuarioId

                    prmParameter(9) = New MySqlParameter(arrParameter(9).ToString, MySqlDbType.Int16)
                    prmParameter(9).Value = .EstadoId

                End With

                '2. Formateando Parámetros del SP:
                strParametros = ""
                For k As Integer = 0 To arrParameter.Count - 1
                    strParametros &= arrParameter(k) & ","
                Next
                strParametros = Mid(strParametros, 1, Len(strParametros) - 1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_operacionmesa_escribir (" & strParametros & ");", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprljm_operacionmesa_escribir (" & strParametros & ");", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprljm_operacionmesa_escribir (" & strParametros & ");", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprljm_operacionmesa_escribir (" & strParametros & ");", prmParameter)

                End Select


                '4. Resultado del SP:
                If intResultado > 0 Then
                    Return Util.Enumeracion.enmResultadoOperacion.OK
                Else
                    Return Util.Enumeracion.enmResultadoOperacion.NONE
                End If

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




