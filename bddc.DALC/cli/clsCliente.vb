Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace CLI

    Public Class clsCliente
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.CLI.clsCliente
        Private viwBEC As BEC.CLI.viwCliente
        Private strConsulta As String = ""
        Private strParametros As String = ""
        Private objMySqlConnection As MySqlConnection
        Private objMySqlCommand As MySqlCommand

#Region "Contructor/Destructor"
        Sub New()
            objConexion = New Util.Factory
            strConsulta = ""
            strParametros = ""
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
#End Region

#Region "CRUD - Cliente"

        Public Function Buscar(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList Implements COM.ICRUD.Buscar
            Dim CadenaConexion As String = Util.Factory.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.CLI.viwCliente()
            Dim prmParameter(3) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_str_buscarNomApe")
                    .Add("?p_str_buscarApe")
                    .Add("?p_str_buscarCodigo")
                    .Add("?p_str_buscarDNI")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(3).Value = arrFiltro(3)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm.sprbdd_cliente_buscar (?p_str_buscarNomApe, ?p_str_buscarApe, ?p_str_buscarCodigo, ?p_str_buscarDNI);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprbdd_cliente_buscar (?p_str_buscarNomApe, ?p_str_buscarApe, ?p_str_buscarCodigo, ?p_str_buscarDNI);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmtacna.sprbdd_cliente_buscar (?p_str_buscarNomApe, ?p_str_buscarApe, ?p_str_buscarCodigo, ?p_str_buscarDNI);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm_test.sprbdd_cliente_buscar (?p_str_buscarNomApe, ?p_str_buscarApe, ?p_str_buscarCodigo, ?p_str_buscarDNI);", prmParameter)
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
                            .ClienteDNI = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DNI"))
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

            Dim CadenaConexion As String = Util.Factory.GetConexion
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

                        Return intResultado

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrmluxor.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)

                        Return intResultado

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrmtacna.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdcrm_test.sprbdd_cliente_eliminar (?p_ccli_id);", prmParameter)

                        Return intResultado
                End Select



            Catch ex As Exception
                Return Util.Enumeracion.enmResultadoOperacion.ERR
            End Try

        End Function

        Public Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer Implements COM.ICRUD.Escribir
            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(34) As MySqlParameter
            Dim arrParameter As New ArrayList

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
                    .Add("p_scli_fechanacimiento")
                    .Add("p_fcli_generoid")
                    .Add("p_scli_nacionalidad")
                    .Add("p_scli_correoelectronico")
                    .Add("p_scli_telefonofijo")
                    .Add("p_scli_telefonomovil")
                    .Add("p_scli_domiciliodireccion")
                    .Add("p_scli_domiciliociudad")
                    .Add("p_scli_domiciliopais")
                    .Add("p_scli_domicilioreferencia")
                    .Add("p_scli_domiciliotelefono")
                    .Add("p_scli_profesion")
                    .Add("p_scli_empresanombre")
                    .Add("p_scli_empresaruc")
                    .Add("p_scli_empresadepartamento")
                    .Add("p_scli_empresapuesto")
                    .Add("p_scli_empresadireccion")
                    .Add("p_scli_empresatelefono")
                    .Add("p_scli_empresapais")
                    .Add("p_scli_preferenciasFJM")
                    .Add("p_scli_tiers")
                    .Add("p_scli_comentarios")
                    .Add("p_fcli_estadoid")
                    .Add("p_faud_usrid")
                    .Add("p_scli_distrito")
                    .Add("p_scli_provincia")
                    .Add("p_scli_departamento")
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
                    prmParameter(2).Value = .ClienteTipoDocId

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
                    prmParameter(8).Value = .ClienteFecNac.Trim

                    prmParameter(9) = New MySqlParameter(arrParameter(9).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(9).Value = .ClienteGeneroId

                    prmParameter(10) = New MySqlParameter(arrParameter(10).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(10).Value = .ClienteNacionalidad.Trim

                    prmParameter(11) = New MySqlParameter(arrParameter(11).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(11).Value = .ClienteEmail.Trim

                    prmParameter(12) = New MySqlParameter(arrParameter(12).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(12).Value = .ClienteTelefonoFijo.Trim

                    prmParameter(13) = New MySqlParameter(arrParameter(13).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(13).Value = .ClienteTelefonoMovil.Trim

                    prmParameter(14) = New MySqlParameter(arrParameter(14).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(14).Value = .DomicilioDireccion.Trim

                    prmParameter(15) = New MySqlParameter(arrParameter(15).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(15).Value = .DomicilioCiudad.Trim

                    prmParameter(16) = New MySqlParameter(arrParameter(16).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(16).Value = .DomicilioPais.Trim

                    prmParameter(17) = New MySqlParameter(arrParameter(17).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(17).Value = .DomicilioReferencia.Trim

                    prmParameter(18) = New MySqlParameter(arrParameter(18).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(18).Value = .DomicilioTelefono.Trim

                    prmParameter(19) = New MySqlParameter(arrParameter(19).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(19).Value = .ClienteProfesion.Trim

                    prmParameter(20) = New MySqlParameter(arrParameter(20).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(20).Value = .EmpresaNombre.Trim

                    prmParameter(21) = New MySqlParameter(arrParameter(21).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(21).Value = .EmpresaRUC.Trim

                    prmParameter(22) = New MySqlParameter(arrParameter(22).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(22).Value = .EmpresaArea.Trim

                    prmParameter(23) = New MySqlParameter(arrParameter(23).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(23).Value = .EmpresaPuesto.Trim

                    prmParameter(24) = New MySqlParameter(arrParameter(24).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(24).Value = .EmpresaDireccion.Trim

                    prmParameter(25) = New MySqlParameter(arrParameter(25).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(25).Value = .EmpresaTelefono.Trim

                    prmParameter(26) = New MySqlParameter(arrParameter(26).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(26).Value = .EmpresaPais.Trim

                    prmParameter(27) = New MySqlParameter(arrParameter(27).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(27).Value = .PreferenciasFJM.Trim

                    prmParameter(28) = New MySqlParameter(arrParameter(28).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_CORTO_6)
                    prmParameter(28).Value = .ClienteTier.Trim

                    prmParameter(29) = New MySqlParameter(arrParameter(29).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(29).Value = .ClienteComentarios.Trim

                    prmParameter(30) = New MySqlParameter(arrParameter(30).ToString, MySqlDbType.Int16)
                    prmParameter(30).Value = .ClienteEstadoId

                    prmParameter(31) = New MySqlParameter(arrParameter(31).ToString, MySqlDbType.Int16)
                    prmParameter(31).Value = .AudCreac_UsuarioId

                    prmParameter(32) = New MySqlParameter(arrParameter(32).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(32).Value = .ClienteDistrito.Trim

                    prmParameter(33) = New MySqlParameter(arrParameter(33).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(33).Value = .ClienteProvincia.Trim

                    prmParameter(34) = New MySqlParameter(arrParameter(34).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(34).Value = .ClienteDepartamento.Trim
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
                        .ClienteTipoDocId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTipoDocId"))
                        .ClienteTipoDoc = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTipoDoc"))
                        .ClienteNumDoc = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNumDoc"))
                        .ClienteGeneroId = Convert.ToInt16(dtsResultado.Tables(0).Rows(k)("ClienteGeneroId"))
                        .ClienteFecNac = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteFecNac"))
                        .DomicilioDireccion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioDireccion"))
                        .DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                        .ClienteTelefonoFijo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonoFijo"))
                        .ClienteTelefonoMovil = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonoMovil"))
                        .ClienteEmail = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteEmail"))
                        .PreferenciasFJM = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("PreferenciasFJM"))
                        .ClienteComentarios = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteComentarios"))
                        .AudCreac_UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_UsuarioId"))
                        .AudCreac_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Usuario"))
                        .AudCreac_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Fecha"))
                        .AudEdic_UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_UsuarioId"))
                        .AudEdic_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Usuario"))
                        .AudEdic_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Fecha"))
                        .ClienteNacionalidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Nacionalidad"))
                        .ClienteDistrito = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Distrito"))
                        .ClienteProvincia = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Provincia"))
                        .ClienteDepartamento = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Departamento"))
                        .ClienteProfesion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Profesion"))
                    End With

                    Return objBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Verificar(ByVal Codigo As String, ByVal Unidad As String) As Integer
            Try
                Dim CadenaConexion As String
                Dim prmParameter(0) As MySqlParameter
                Dim arrParameter As New ArrayList
                Dim intResultado As Integer = 0
                'Dim resultado As Boolean = False

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("p_scli_numdoc")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String)
                prmParameter(0).Value = Codigo

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteScalar(CadenaConexion, "select bdcrm.validacion(?p_scli_numdoc);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteScalar(CadenaConexion, "select bdcrmluxor.validacion(?p_scli_numdoc);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteScalar(CadenaConexion, "select bdcrmtacna.validacion(?p_scli_numdoc);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteScalar(CadenaConexion, "select bdcrm_test.validacion(?p_scli_numdoc);", prmParameter)
                End Select

                'If the intResultado is 1 -- The user exists
                'If the intResultado is 0 -- The user does not exist

                Return intResultado
                'If intResultado Then
                '    Return True
                'Else
                '    Return False
                'End If

            Catch ex As Exception
                Throw New DataException(ex.Message)
            End Try

            Return Nothing
        End Function

#End Region

#Region "Movimientos FCB"

        Public Function LeerMovimientosFCB(ByVal Id As Integer, ByVal Unidad As String) As IList

            Dim CadenaConexion As String = objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim arrResultado As ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_ccli_id")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = Id

                '2. Invocando al SP:
                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprbdd_movimientos_fcb (?p_ccli_id);", prmParameter)

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultado = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        arrResultado.Add(dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoJuegoId")) & "|" & _
                                         dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Puntaje")) & "|" & _
                                         dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Tier")))
                    Next

                    Return arrResultado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

#End Region

    End Class

End Namespace


