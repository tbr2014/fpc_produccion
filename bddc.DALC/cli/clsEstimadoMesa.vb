Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace FJM

    Public Class clsEstimadoMesa
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.FJM.clsEstimadoMesa
        Private viwBEC As BEC.FJM.viwEstimadoMesa
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
            Dim arrBEC As BEC.FJM.clsEstimadoMesa()
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

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
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_estimadomesa_buscar (?p_strFechaProceso);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_estimadomesa_buscar (?p_strFechaProceso);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_estimadomesa_buscar (?p_strFechaProceso);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_estimadomesa_buscar (?p_strFechaProceso);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.FJM.clsEstimadoMesa

                        With objBEC
                            .EstimadoMesaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstimadoMesaId"))
                            .EstimadoMesaFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstimadoMesaFecha"))
                            .MesaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MesaId"))
                            .EstimadoMesaLista = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstimadoMesaLista"))

                        End With

                        arrBEC(k) = objBEC
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

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(4) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_cest_id")
                    .Add("?p_sest_fecha")
                    .Add("?p_cmes_id")
                    .Add("?p_sest_lista")
                    .Add("?p_faud_usrid")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    'prmParameter(0).Direction = ParameterDirection.Output
                    prmParameter(0).Value = .EstimadoMesaId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(1).Value = .EstimadoMesaFecha

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int16)
                    prmParameter(2).Value = .MesaId

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_COMENTARIO_LARGO_500)
                    prmParameter(3).Value = .EstimadoMesaLista

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.Int16)
                    prmParameter(4).Value = .AudCreac_UsuarioId

                End With

                For k As Integer = 0 To arrParameter.Count - 1
                    strCadena &= arrParameter(k) & ","
                Next
                strCadena = Mid(strCadena, 1, Len(strCadena) - 1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfjm_estimadomesa_escribir ( " & strCadena & " );", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprljm_estimadomesa_escribir ( " & strCadena & " );", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprljm_estimadomesa_escribir ( " & strCadena & " );", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprljm_estimadomesa_escribir ( " & strCadena & " );", prmParameter)
                End Select

                '4. Resultado del SP:
                If intResultado > 0 Then
                    'Parámetro(s) de Salida:
                    objBEC.EstimadoMesaId = IIf(dato.EsNuloBD(prmParameter(0).Value) IsNot Nothing, prmParameter(0).Value, 0)
                End If

                obj = objBEC
                Return intResultado

            Catch ex As Exception
                Throw New DataException(ex.Message)
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function Leer(ByVal Id As Integer, ByVal Unidad As String) As Object Implements COM.ICRUD.Leer

            'Dim CadenaConexion As String = objConexion.GetConexion
            'Dim dato As New Util.Dato
            'Dim dtsResultado As New DataSet
            'Dim prmParameter(0) As MySqlParameter
            'Dim arrParameter As New ArrayList

            'Try

            '    '1. Definiendo Parámetros del SP:

            '    With arrParameter
            '        .Add("?p_strFechaProceso")
            '    End With

            '    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
            '    prmParameter(0).Value = Id

            '    '2. Invocando al SP:
            '    dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdCliente.sprfjm_estimadomesa_buscar (?p_strFechaProceso);", prmParameter)

            '    If (dtsResultado.Tables(0).Rows.Count > 0) Then

            '        Dim k As Integer = 0
            '        objBEC = New BEC.CLI.clsEstimadoMesa

            '        With objBEC
            '            .EstimadoMesaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstimadoMesaId"))
            '            .EstimadoMesaFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstimadoMesaFecha"))
            '            .MesaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("MesaId"))
            '            .EstimadoMesaLista = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstimadoMesaLista"))
            '        End With

            '        Return objBEC

            '    End If

            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try

            Return Nothing

        End Function

    End Class

End Namespace



