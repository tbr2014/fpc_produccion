Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace FJM

    Public Class clsCliente
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.CLI.clsCliente
        Private viwBEC As BEC.CLI.viwCliente
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
            Dim arrBEC As BEC.CLI.viwCliente()
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_str_buscarNomApe")
                End With


                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = arrFiltro(0)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm.sprbdd_cliente_buscar (?p_str_buscarNomApe);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprbdd_cliente_buscar (?p_str_buscarNomApe);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmtacna.sprbdd_cliente_buscar (?p_str_buscarNomApe);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm_test.sprbdd_cliente_buscar (?p_str_buscarNomApe);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        viwBEC = New BEC.CLI.viwCliente

                        With viwBEC
                            .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                            .ClienteApePat = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApePat"))
                            .ClienteApeMat = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApeMat"))
                            .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))

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
                    .Add("?p_ccli_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = Id

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrm.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrmluxor.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrmtacna.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)

                    Case "EMPRESA DE PRUEBAS"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrm_test.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)
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
            Dim prmParameter(21) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("p_ccli_id")
                    .Add("p_scli_codigo")
                    .Add("p_fcli_tipodoc")
                    .Add("p_scli_numdoc")
                    .Add("p_scli_titulo")
                    .Add("p_scli_nombres")
                    .Add("p_scli_apellidopat")
                    .Add("p_scli_apellidomat")
                    .Add("p_scli_telefonomovil")
                    .Add("p_scli_telefonofijo")
                    .Add("p_scli_correoelectronico")
                    .Add("p_scli_fechanacimiento")
                    .Add("p_fcli_generoid")
                    .Add("p_scli_domiciliodireccion")
                    .Add("p_scli_domiciliociudad")
                    .Add("p_scli_domiciliopais")
                    .Add("p_scli_domicilioreferencia")
                    .Add("p_scli_domiciliotelefono")
                    .Add("p_scli_comentarios")
                    .Add("p_fcli_tier")
                    .Add("p_fcli_estadoid")
                    .Add("p_faud_usrid")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Direction = ParameterDirection.InputOutput
                    prmParameter(0).Value = .ClienteId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                    prmParameter(1).Direction = ParameterDirection.Output
                    prmParameter(1).Value = .ClienteCodigo

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int16)
                    prmParameter(2).Value = .ClienteTipoDoc

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(3).Value = .ClienteNumDoc.Trim

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(4).Value = .ClienteTitulo.Trim

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(5).Value = .ClienteNombres.Trim

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(6).Value = .ClienteApePat.Trim

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(7).Value = .ClienteApeMat.Trim

                    prmParameter(8) = New MySqlParameter(arrParameter(8).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(8).Value = .ClienteTelefonoMovil.Trim

                    prmParameter(9) = New MySqlParameter(arrParameter(9).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(9).Value = .ClienteTelefonoFijo.Trim

                    prmParameter(10) = New MySqlParameter(arrParameter(10).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(10).Value = .ClienteEmail.Trim

                    prmParameter(11) = New MySqlParameter(arrParameter(11).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(11).Value = .ClienteFecNac.Trim

                    prmParameter(12) = New MySqlParameter(arrParameter(12).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(12).Value = .ClienteGeneroId

                    prmParameter(13) = New MySqlParameter(arrParameter(13).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(13).Value = .DomicilioDireccion.Trim

                    prmParameter(14) = New MySqlParameter(arrParameter(14).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(14).Value = .DomicilioCiudad.Trim

                    prmParameter(15) = New MySqlParameter(arrParameter(15).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(15).Value = .DomicilioPais.Trim

                    prmParameter(16) = New MySqlParameter(arrParameter(16).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(16).Value = .DomicilioReferencia.Trim

                    prmParameter(17) = New MySqlParameter(arrParameter(17).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(17).Value = .DomicilioTelefono.Trim

                    prmParameter(18) = New MySqlParameter(arrParameter(18).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(18).Value = .ClienteComentarios.Trim

                    prmParameter(19) = New MySqlParameter(arrParameter(19).ToString, MySqlDbType.Int16)
                    prmParameter(19).Value = .ClienteTier

                    prmParameter(20) = New MySqlParameter(arrParameter(20).ToString, MySqlDbType.Int16)
                    prmParameter(20).Value = .ClienteEstadoId

                    prmParameter(21) = New MySqlParameter(arrParameter(21).ToString, MySqlDbType.Int16)
                    prmParameter(21).Value = .AudCreac_UsuarioId

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
                            .CommandText = "bdcrm.sprbdd_cliente_escribir"
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
                            .CommandText = "bdcrmluxor.sprbdd_cliente_escribir"
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
                            .CommandText = "bdcrmtacna.sprbdd_cliente_escribir"
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
                            .CommandText = "bdcrm_test.sprbdd_cliente_escribir"
                            .Parameters.AddRange(prmParameter)

                            '3. Invocando al SP:
                            intResultado = .ExecuteNonQuery()
                        End With
                End Select

                '4. Resultado del SP:
                If intResultado > 0 Then
                    'Parámetro(s) de Salida:
                    objBEC.ClienteId = IIf(dato.EsNuloBD(prmParameter(0).Value) IsNot Nothing, prmParameter(0).Value, 0)
                    objBEC.ClienteCodigo = prmParameter(1).Value
                End If

                obj = objBEC
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
                    .Add("?p_ccli_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = Id

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm.sprbdd_cliente_leer (?p_ccli_id);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprbdd_cliente_leer (?p_ccli_id);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmtacna.sprbdd_cliente_leer (?p_ccli_id);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm_test.sprbdd_cliente_leer (?p_ccli_id);", prmParameter)

                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    Dim k As Integer = 0
                    objBEC = New BEC.CLI.clsCliente

                    With objBEC
                        .ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                        .ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                        .ClienteApePat = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApePat"))
                        .ClienteApeMat = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApeMat"))
                        .ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                        .ClienteNumDoc = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNumDoc"))
                        .ClienteGeneroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteGeneroId"))
                        .ClienteFecNac = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteFecNac"))
                        .DomicilioDireccion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioDireccion"))
                        .DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                        .ClienteTelefonoFijo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonoFijo"))
                        .ClienteTelefonoMovil = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonoMovil"))
                        .ClienteEmail = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteEmail"))
                        .ClienteComentarios = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteComentarios"))
                        .ClientePuntaje = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClientePuntaje"))
                        .ClienteTier = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTier"))

                    End With

                    Return objBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Listar(ByVal Unidad As String) As System.Collections.IList
            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objBEC As BEC.COM.clsItem
            Dim arrBEC As BEC.COM.clsItem()

            Try


                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_cliente_listar ();")

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_cliente_listar ();")

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_cliente_listar ();")

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_cliente_listar ();")
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.COM.clsItem

                        With objBEC
                            .ItemId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ItemNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
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

        Public Function ListarCliMesa(ByVal intMesaid As Util.Enumeracion.enmMesasId, ByVal Unidad As String) As System.Collections.IList
            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objBEC As BEC.COM.clsItem
            Dim arrBEC As BEC.COM.clsItem()
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList


            Try

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        If intMesaid > 0 Then
                            With arrParameter
                                .Add("?p_nroMesa")
                            End With

                            prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                            prmParameter(0).Value = intMesaid

                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_cliente_x_Mesa_listar (?p_nroMesa);", prmParameter)
                        Else
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_cliente_listar ();")
                        End If

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        If intMesaid > 0 Then
                            With arrParameter
                                .Add("?p_nroMesa")
                            End With

                            prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                            prmParameter(0).Value = intMesaid

                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_cliente_x_Mesa_listar (?p_nroMesa);", prmParameter)
                        Else
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_cliente_listar ();")
                        End If

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        If intMesaid > 0 Then
                            With arrParameter
                                .Add("?p_nroMesa")
                            End With

                            prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                            prmParameter(0).Value = intMesaid

                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_cliente_x_Mesa_listar (?p_nroMesa);", prmParameter)
                        Else
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_cliente_listar ();")
                        End If


                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 35
                        CadenaConexion = Util.Factory.GetConexion
                        If intMesaid > 0 Then
                            With arrParameter
                                .Add("?p_nroMesa")
                            End With

                            prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                            prmParameter(0).Value = intMesaid

                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_cliente_x_Mesa_listar (?p_nroMesa);", prmParameter)
                        Else
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_cliente_listar ();")
                        End If
                End Select



                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.COM.clsItem

                        With objBEC
                            .ItemId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ItemNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
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

        '************* Obtiene el grupo de clientes que benefician con el 7% de sus perdidas al cliente dueño del grupo
        Public Function GrupoCliMesa(ByVal ClienteId As Integer, ByVal Unidad As String) As System.Collections.IList
            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objBEC As BEC.COM.clsItem
            Dim arrBEC As BEC.COM.clsItem()
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList


            Try
                ' Invocando al SP:
                If ClienteId > 0 Then
                    With arrParameter
                        .Add("?p_intClienteId")
                    End With

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int24, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(0).Value = ClienteId

                    Select Case Unidad
                        Case "FIESTA CASINO BENAVIDES"
                            Util.Factory.ConfigOrigen = 1
                            CadenaConexion = Util.Factory.GetConexion
                           dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente.sprfjm_grupocliente_listar (?p_intClienteId);", prmParameter)
                        Case "LUXOR LIMA CASINO"
                            Util.Factory.ConfigOrigen = 2
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclienteluxor.sprljm_grupocliente_listar (?p_intClienteId);", prmParameter)
                        Case "LUXOR TACNA"
                            Util.Factory.ConfigOrigen = 3
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdclientetacna.sprljm_grupocliente_listar (?p_intClienteId);", prmParameter)
                        Case "EMPRESA DE PRUEBA"
                            Util.Factory.ConfigOrigen = 5
                            CadenaConexion = Util.Factory.GetConexion
                            dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcliente_test.sprljm_grupocliente_listar (?p_intClienteId);", prmParameter)
                    End Select

                End If


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.COM.clsItem

                        With objBEC
                            .ItemId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                            .ItemNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombreCompleto"))
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

    End Class

End Namespace


