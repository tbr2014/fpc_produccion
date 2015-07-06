Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace FCB

    Public Class clsOperacionCaja
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.FCB.clsOperacionCaja
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
            Dim prmParameter(2) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim arrResultados As ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_sopc_fechaproceso")
                    .Add("?p_strCaja")
                    .Add("?p_faud_usrid")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, 1)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int32)
                prmParameter(2).Value = arrFiltro(2)

                '2. Formateando Parámetros del SP:

                For k As Integer = 0 To arrParameter.Count - 1
                    strParametros &= arrParameter(k)
                    If k < arrParameter.Count - 1 Then strParametros &= ", "
                Next

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfcb_operacioncaja_buscar (" & strParametros & ");", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprlim_operacioncaja_buscar (" & strParametros & ");", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprlim_operacioncaja_buscar (" & strParametros & ");", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprfcb_operacioncaja_buscar (" & strParametros & ");", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultados = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.FCB.clsOperacionCaja

                        With objBEC
                            .OperacionCajaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionCajaId"))
                            .OperacionCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionCodigo"))
                            .OperacionFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFecha"))
                            .OperacionHora = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionHora"))
                            .SujetoObligado = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("SujetoObligado"))
                            .OficialCumplimiento = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OficialCumplimiento"))
                            .OperacionMontoMonedaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMontoMonedaId"))
                            .OperacionMontoImporte = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMontoImporte"))
                            .OperacionMonto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMonto"))
                            .OperacionTipoCambio = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTipoCambio"))
                            .OperacionModalidadId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionModalidadId"))
                            .OperacionTipoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTipoId"))
                            .OperacionFichaCantidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFichaCantidad"))
                            .OperacionFichaDenominacion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFichaDenominacion"))
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteNombreCompleto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
                            .EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstadoId"))
                            .UserId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UserId"))
                            .NumRegistro = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("numRegistro"))
                            .NombreCaja = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Caja"))
                            .TipoDocumento = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTipoDoc"))
                            .NumeroDocumento = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("NumDoc"))
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

        Public Function Eliminar(ByVal obj As Object, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(2) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_copc_id")
                    .Add("?p_faud_usrid")
                    .Add("?p_sopc_comentarios")
                End With

                objBEC = New BEC.FCB.clsOperacionCaja
                objBEC = obj

                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Value = .OperacionCajaId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int16)
                    prmParameter(1).Value = .AudCreac_UsuarioId

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.VarChar, Util.Constante.DiccionarioDatos.CONST_DESCRIPCION_100)
                    prmParameter(2).Value = .OperacionComentario

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
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfcb_operacioncaja_eliminar (" & strParametros & ");", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclienteluxor.sprlim_operacioncaja_eliminar (" & strParametros & ");", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdclientetacna.sprlim_operacioncaja_eliminar (" & strParametros & ");", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente_test.sprlim_operacioncaja_eliminar (" & strParametros & ");", prmParameter)
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

        Public Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer Implements COM.ICRUD.Escribir

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(18) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try
                objBEC = New BEC.FCB.clsOperacionCaja
                objBEC = obj

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_copc_id")
                    .Add("?p_sopc_codigo")
                    .Add("?p_sopc_fecharegistro")
                    .Add("?p_sopc_caja")
                    .Add("?p_sopc_sujetoobligado")
                    .Add("?p_sopc_oficialcumplimiento")
                    .Add("?p_fopc_montomonedaid")
                    .Add("?p_nopc_montoimporte")
                    .Add("?p_fopc_modalidadid")
                    .Add("?p_fopc_tipoid")
                    .Add("?p_sopc_tarjetanum")
                    .Add("?p_nopc_fichamoneda")
                    .Add("?p_nopc_fichacantidad")
                    .Add("?p_nopc_fichadenominacion")
                    .Add("?p_sopc_maquinanum")
                    .Add("?p_fopc_clienteid")
                    .Add("?p_fopm_estadoid")
                    .Add("?p_faud_usrid")
                    .Add("?p_sopc_horaregistro")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Direction = ParameterDirection.InputOutput
                    prmParameter(0).Value = .OperacionCajaId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                    prmParameter(1).Direction = ParameterDirection.InputOutput
                    prmParameter(1).Value = .OperacionCodigo

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(2).Value = .OperacionFecha

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(3).Value = .OperacionCaja

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(4).Value = .SujetoObligado

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(5).Value = .OficialCumplimiento

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.Int16)
                    prmParameter(6).Value = .OperacionMontoMonedaId

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.Decimal)
                    prmParameter(7).Value = .OperacionMontoImporte

                    prmParameter(8) = New MySqlParameter(arrParameter(8).ToString, MySqlDbType.Int16)
                    prmParameter(8).Value = .OperacionModalidadId

                    prmParameter(9) = New MySqlParameter(arrParameter(9).ToString, MySqlDbType.Int16)
                    prmParameter(9).Value = .OperacionTipoId

                    prmParameter(10) = New MySqlParameter(arrParameter(10).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                    prmParameter(10).Value = .OperacionTarjetaNum

                    prmParameter(11) = New MySqlParameter(arrParameter(11).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(11).Value = .OperacionFichaMoneda

                    prmParameter(12) = New MySqlParameter(arrParameter(12).ToString, MySqlDbType.Int32)
                    prmParameter(12).Value = .OperacionFichaCantidad

                    prmParameter(13) = New MySqlParameter(arrParameter(13).ToString, MySqlDbType.Decimal)
                    prmParameter(13).Value = .OperacionFichaDenominacion

                    prmParameter(14) = New MySqlParameter(arrParameter(14).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(14).Value = .OperacionMaquinaNum

                    prmParameter(15) = New MySqlParameter(arrParameter(15).ToString, MySqlDbType.Int64)
                    prmParameter(15).Value = .ClienteId

                    prmParameter(16) = New MySqlParameter(arrParameter(16).ToString, MySqlDbType.Int16)
                    prmParameter(16).Value = .EstadoId

                    prmParameter(17) = New MySqlParameter(arrParameter(17).ToString, MySqlDbType.Int16)
                    prmParameter(17).Value = .AudCreac_UsuarioId

                    prmParameter(18) = New MySqlParameter(arrParameter(18).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(18).Value = .OperacionHora

                End With

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        objMySqlConnection = New MySqlConnection(CadenaConexion)
                        objMySqlConnection.Open()
                        objMySqlCommand = New MySqlCommand
                        With objMySqlCommand
                            .Connection = objMySqlConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "bdcliente.sprfcb_operacioncaja_escribir"
                            .Parameters.AddRange(prmParameter)

                            '3. Invocando al SP:
                            intResultado = .ExecuteNonQuery()
                        End With

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion

                        objMySqlConnection = New MySqlConnection(CadenaConexion)
                        objMySqlConnection.Open()
                        objMySqlCommand = New MySqlCommand
                        With objMySqlCommand
                            .Connection = objMySqlConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "bdclienteluxor.sprlim_operacioncaja_escribir"
                            .Parameters.AddRange(prmParameter)

                            '3. Invocando al SP:
                            intResultado = .ExecuteNonQuery()
                        End With

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion

                        objMySqlConnection = New MySqlConnection(CadenaConexion)
                        objMySqlConnection.Open()
                        objMySqlCommand = New MySqlCommand
                        With objMySqlCommand
                            .Connection = objMySqlConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "bdclientetacna.sprlim_operacioncaja_escribir"
                            .Parameters.AddRange(prmParameter)

                            '3. Invocando al SP:
                            intResultado = .ExecuteNonQuery()
                        End With

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion

                        objMySqlConnection = New MySqlConnection(CadenaConexion)
                        objMySqlConnection.Open()
                        objMySqlCommand = New MySqlCommand
                        With objMySqlCommand
                            .Connection = objMySqlConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "bdcliente_test.sprfcb_operacioncaja_escribir"
                            .Parameters.AddRange(prmParameter)

                            '3. Invocando al SP:
                            intResultado = .ExecuteNonQuery()
                        End With
                End Select


                ''2. Formateando Parámetros del SP:
                'strParametros = ""
                'For k As Integer = 0 To arrParameter.Count - 1
                '    strParametros &= arrParameter(k) & ","
                'Next
                'strParametros = Mid(strParametros, 1, Len(strParametros) - 1)

                ''3. Ejecutando SP:
                'intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcliente.sprfcb_operacioncaja_escribir (" & strParametros & ");", prmParameter)

                '4. Resultado del SP:
                If intResultado > 0 Then
                    objBEC.OperacionCajaId = IIf(dato.EsNuloBD(prmParameter(0).Value) IsNot Nothing, prmParameter(0).Value, 0)
                    objBEC.OperacionCodigo = prmParameter(1).Value
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

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim arrResultados As ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_fopc_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = Id

                '2. Formateando Parámetros del SP:

                For k As Integer = 0 To arrParameter.Count - 1
                    strParametros &= arrParameter(k)
                    If k < arrParameter.Count - 1 Then strParametros &= ", "
                Next

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfcb_operacioncaja_leer (" & strParametros & ");", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprlim_operacioncaja_leer (" & strParametros & ");", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprlim_operacioncaja_leer (" & strParametros & ");", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprfcb_operacioncaja_leer (" & strParametros & ");", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    Dim k As Integer = 0
                    objBEC = New BEC.FCB.clsOperacionCaja

                    With objBEC
                        .OperacionCajaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionCajaId"))
                        .OperacionCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionCodigo"))
                        .OperacionFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFecha"))
                        .OperacionCaja = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionCaja"))
                        .SujetoObligado = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("SujetoObligado"))
                        .OficialCumplimiento = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OficialCumplimiento"))
                        .OperacionMontoMonedaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMontoMonedaId"))
                        .OperacionMontoImporte = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMontoImporte"))
                        .OperacionMonto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMonto"))
                        .OperacionTipoCambio = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTipoCambio"))

                        Dim Modalidad As Integer
                        Modalidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionModalidadId"))

                        Dim Modal As String
                        Modal = Modalidad.ToString()
                        Dim Log As Integer
                        Log = Modal.Length()

                        If Log = 1 Then
                            .OperacionModalidadId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionModalidadId"))
                            .TipoTarjetaCred = "Unknown"
                        End If

                        If Log = 2 Then

                            Dim OM As String
                            OM = Modal.Substring(0, 1)

                            Dim TT As String
                            TT = Modal.Substring(1, 1)

                            .OperacionModalidadId = Integer.Parse(OM)

                            If (Integer.Parse(TT) = 1) Then
                                .TipoTarjetaCred = "Visa"
                            End If

                            If (Integer.Parse(TT) = 2) Then
                                .TipoTarjetaCred = "Mastercard"
                            End If


                        End If
                        '.OperacionModalidadId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionModalidadId"))


                        .OperacionTipoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTipoId"))
                        .OperacionTarjetaNum = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTarjetaNum"))
                        .OperacionFichaMoneda = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFichaMoneda"))
                        .OperacionFichaCantidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFichaCantidad"))
                        .OperacionFichaDenominacion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFichaDenominacion"))
                        .OperacionMaquinaNum = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMaquinaNum"))
                        .OperacionComentario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionComentario"))
                        .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                        .ClienteNombreCompleto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
                        .EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstadoId"))
                        .AudCreac_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Usuario"))
                        .AudCreac_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Fecha"))
                        .AudEdic_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Usuario"))
                        .AudEdic_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Fecha"))


                    End With

                    Return objBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Reporte(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(5) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim arrResultados As ArrayList

            Try

                '1. Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_sopc_fechaini")
                    .Add("?p_sopc_fechafin")
                    .Add("?p_strModalidadId")
                    .Add("?p_strTipoId")
                    .Add("?p_strCaja")
                    .Add("?p_intClienteId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                prmParameter(3).Value = arrFiltro(3)

                prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                prmParameter(4).Value = arrFiltro(4)

                prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
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
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfcb_reporte_operacioncaja (" & strParametros & ");", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprlim_reporte_operacioncaja (" & strParametros & ");", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprlim_reporte_operacioncaja (" & strParametros & ");", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprfcb_reporte_operacioncaja (" & strParametros & ");", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultados = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.FCB.clsOperacionCaja

                        With objBEC
                            .OperacionFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFecha"))
                            .OperacionHora = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionHora"))
                            .OperacionCaja = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionCaja"))
                            .OperacionMontoMonedaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMontoMonedaId"))
                            .OperacionMontoImporte = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMontoImporte"))
                            '.OperacionMonto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMonto"))
                            Dim monto As String
                            Dim words As String()
                            Dim monto2 As String
                            monto2 = String.Empty

                            monto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMonto"))
                            words = monto.Split(" ")

                            For Each wrd As String In words
                                If wrd.CompareTo("") = 0 Then

                                Else
                                    monto2 = monto2 + wrd
                                End If
                            Next

                            .OperacionMonto = monto2
                            .OperacionTipoCambio = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTipoCambio"))

                            Dim Modalidad As Integer
                            Modalidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionModalidadId"))

                            Dim Modal As String
                            Modal = Modalidad.ToString()
                            Dim Log As Integer
                            Log = Modal.Length()

                            If Log = 1 Then
                                .OperacionModalidadId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionModalidadId"))
                                .TipoTarjetaCred = "Unknown"
                            End If

                            If Log = 2 Then

                                Dim OM As String
                                OM = Modal.Substring(0, 1)

                                Dim TT As String
                                TT = Modal.Substring(1, 1)

                                .OperacionModalidadId = Integer.Parse(OM)

                                If (Integer.Parse(TT) = 1) Then
                                    .TipoTarjetaCred = "Visa"
                                End If

                                If (Integer.Parse(TT) = 2) Then
                                    .TipoTarjetaCred = "Mastercard"
                                End If


                            End If

                            .OperacionTipoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTipoId"))
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteNombreCompleto = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
                            .ClienteDocumento = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteDocumento"))
                            Dim ref As String = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTarjetaNum"))

                            If (String.Compare(ref, "") <> 0) Then

                                Dim aux As String = ref.Substring(0, 1)

                                If (String.Compare(aux, "-") <> 0) Then
                                    .OperacionReferencia = ref.Substring(0, 4)
                                End If

                                If (String.Compare(aux, "-") = 0) Then
                                    .OperacionReferencia = "-"
                                End If

                                Dim strArr() As String
                                strArr = ref.Split("-")
                                aux = String.Empty
                                aux = strArr(3)
                                .OperacionTarjetaNum = aux

                            End If

                            If (String.Compare(ref, "") = 0) Then
                                .OperacionReferencia = "-"
                                .OperacionTarjetaNum = "-"
                            End If

                            '.OperacionTarjetaNum = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionTarjetaNum"))
                            .OperacionFichaCantidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionFichaCantidad"))
                            .OperacionMaquinaNum = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("OperacionMaquinaNum"))
                            .UserId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UserId"))
                            .NumRegistro = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("numRegistro"))
                            .EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstadoId"))
                            .UserName = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Nombre"))

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

        Public Function GetCambio(ByVal Unidad As String)

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dtsResultado As New DataSet

            Try

                Util.Factory.ConfigOrigen = 3
                CadenaConexion = Util.Factory.GetConexion
                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliartacna.spraux_GetCambioByDate ()")

                Return dtsResultado

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing
        End Function

    End Class

End Namespace




