Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace SEG

    Public Class clsUsuarioConfig
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.SEG.clsUsuarioConfig
        'Private viwBEC As BEC.CLI.viwCliente
        Private strConsulta As String = ""
        Private strParametros As String = ""
        Private objMySqlConnection As MySqlConnection
        Private objMySqlCommand As MySqlCommand

        Sub New()
            objConexion = New Util.Factory
        End Sub

        'Public Function EscribirConfig(ByVal objBEC As BEC.SEG.clsConfig) As Integer
        '    Dim CadenaConexion As String = objConexion.GetConexion
        '    Dim dato As New Util.Dato
        '    Dim intResultado As Integer = 0
        '    Dim prmParameter(5) As MySqlParameter

        '    Try

        '        With objBEC
        '            prmParameter(0) = New MySqlParameter("v_intUsuarioId", MySqlDbType.Int16)
        '            prmParameter(0).Value = .UsuarioId

        '            prmParameter(1) = New MySqlParameter("v_intModuloId", MySqlDbType.Int16)
        '            prmParameter(1).Value = .ModuloId

        '            prmParameter(2) = New MySqlParameter("v_strPermisos", MySqlDbType.VarChar, 10)
        '            prmParameter(2).Value = .Permisos

        '            prmParameter(3) = New MySqlParameter("v_strHorario", MySqlDbType.VarChar, 24)
        '            prmParameter(3).Value = .Horario

        '            prmParameter(4) = New MySqlParameter("v_strUbicacion", MySqlDbType.VarChar, 20)
        '            prmParameter(4).Value = .Ubicacion

        '            prmParameter(5) = New MySqlParameter("v_intEstado", MySqlDbType.Int16)
        '            prmParameter(5).Value = .Estado
        '        End With

        '        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "SPRSEG_ESCRIBIRCFG", prmParameter)

        '        Return intResultado

        '    Catch ex As Exception
        '        Return Util.Enumeracion.enmResultadoOperacion.ERR
        '    End Try

        'End Function

        'Public Function EscribirConfigArr(ByVal arrBEC As BEC.SEG.clsConfig()) As Integer
        '    Dim CadenaConexion As String = objConexion.GetConexion
        '    Dim dato As New Util.Dato
        '    Dim intResultado As Integer = 0
        '    Dim prmParameter(8) As MySqlParameter
        '    Dim objBEC As BEC.SEG.clsConfig

        '    Try

        '        For k As Integer = 0 To arrBEC.Length - 1
        '            objBEC = New BEC.SEG.clsConfig
        '            objBEC = arrBEC(k)

        '            intResultado += EscribirConfig(objBEC)
        '        Next

        '        Return intResultado

        '    Catch ex As Exception
        '        Return Util.Enumeracion.enmResultadoOperacion.ERR
        '    End Try

        'End Function


        'Public Function EliminarConfig(ByVal objBEC As BEC.SEG.clsConfig) As Integer
        '    Dim CadenaConexion As String = objConexion.GetConexion
        '    Dim dato As New Util.Dato
        '    Dim intResultado As Integer = 0
        '    Dim prmParameter(2) As MySqlParameter

        '    Try

        '        With objBEC
        '            prmParameter(0) = New MySqlParameter("v_intUsuarioId", MySqlDbType.Int16)
        '            prmParameter(0).Value = .UsuarioId

        '            prmParameter(1) = New MySqlParameter("v_intModuloId", MySqlDbType.Int16)
        '            prmParameter(1).Value = .ModuloId

        '            prmParameter(2) = New MySqlParameter("v_intEstado", MySqlDbType.Int16)
        '            prmParameter(2).Value = .Estado
        '        End With

        '        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "SPRSEG_ELIMINARCFG", prmParameter)

        '        Return intResultado

        '    Catch ex As Exception
        '        Return Util.Enumeracion.enmResultadoOperacion.ERR
        '    End Try

        'End Function

        'Public Function LeerUsuariosAprobSolicitud() As BEC.SEG.clsUsuario()
        '    Dim CadenaConexion As String = objConexion.GetConexion
        '    Dim dato As New Util.Dato
        '    Dim dtsResultado As New DataSet
        '    Dim arrBEC As BEC.SEG.clsUsuario()
        '    Dim objBEC As New BEC.SEG.clsUsuario

        '    Try

        '        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "SPRSIT_SOLICITUD_USUARIOS_APROB")

        '        If (dtsResultado.Tables(0).Rows.Count > 0) Then

        '            ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)
        '            For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
        '                objBEC = New BEC.SEG.clsUsuario

        '                With objBEC
        '                    .UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("UsuarioId"))
        '                    .Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioNombre"))
        '                    '.Rol = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioUbicacion")) ' Solo para pasar el dato, se usa este atributo!

        '                End With

        '                arrBEC(k) = objBEC
        '            Next

        '            Return arrBEC

        '        End If

        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    End Try

        'End Function

        'Public Function FiltrarUsuario(ByVal arrFiltro As IList) As IList
        '    Dim CadenaConexion As String = objConexion.GetConexion
        '    Dim dato As New Util.Dato
        '    Dim dtsResultado As New DataSet
        '    Dim objBEC As New BEC.SEG.clsUsuario
        '    Dim arrBEC As BEC.SEG.clsUsuario()
        '    Dim prmParameter(1) As MySqlParameter

        '    Try

        '        prmParameter(0) = New MySqlParameter("v_intModuloId", MySqlDbType.Int16)
        '        prmParameter(0).Value = arrFiltro(0)

        '        prmParameter(1) = New MySqlParameter("v_intRolId", MySqlDbType.Int16)
        '        prmParameter(1).Value = arrFiltro(1)

        '        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "SPRSEG_FILTRARUSR", prmParameter)

        '        If (dtsResultado.Tables(0).Rows.Count > 0) Then

        '            ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)

        '            For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
        '                objBEC = New BEC.SEG.clsUsuario
        '                With objBEC
        '                    .UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioId"))
        '                    .Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioNombre"))

        '                End With

        '                arrBEC(k) = objBEC
        '            Next

        '            Return arrBEC

        '        Else
        '            Return Nothing
        '        End If

        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    End Try

        'End Function

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Function Buscar(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList Implements COM.ICRUD.Buscar

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objBEC As New BEC.SEG.clsUsuarioConfig
            Dim arrResultado As ArrayList
            Dim arrParameter As New ArrayList
            Dim prmParameter As MySqlParameter

            Try

                '1. Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_intUsuarioId")
                End With

                prmParameter = New MySqlParameter("p_intUsuarioId", MySqlDbType.Int16)
                prmParameter.Value = arrFiltro(0)

                '2. Invocando al SP:
                Dim uni As Integer = StrComp(Unidad, "FIESTA CASINO BENAVIDES")

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_config_buscar (?p_intUsuarioId);", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_config_buscar (?p_intUsuarioId);", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadtacna.sprseg_config_buscar (?p_intUsuarioId);", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad_test.sprseg_config_buscar (?p_intUsuarioId);", prmParameter)
                End Select
               
                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultado = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.SEG.clsUsuarioConfig
                        With objBEC
                            .UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioId"))
                            .ModuloId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ModuloId"))
                            .Modulo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Modulo"))
                            .ModuloSiglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ModuloSiglas"))
                            .RolId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("RolId"))
                            .Rol = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Rol"))
                            .Permisos = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Permisos"))
                            .Horario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Horario"))
                            .Ubicacion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Ubicacion"))
                            .Opciones = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Opciones"))
                            .EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstadoId"))

                        End With

                        arrResultado.Add(objBEC)
                    Next

                    Return arrResultado

                Else
                    Return Nothing
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function Eliminar(ByVal Id As Integer, ByVal Unidad As String) As Integer Implements COM.ICRUD.Eliminar

        End Function

        Public Function Eliminar(ByVal arrParametro As IList, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_intUsuarioId")
                    .Add("?p_intModuloId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = arrParametro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int16)
                prmParameter(1).Value = arrParametro(1)

                '2. Formateando Parámetros del SP:
                For k As Integer = 0 To arrParameter.Count - 1
                    strCadena &= arrParameter(k) & ","
                Next
                strCadena = Mid(strCadena, 1, Len(strCadena) - 1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridad.sprseg_config_eliminar ( " & strCadena & " );", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadluxor.sprseg_config_eliminar ( " & strCadena & " );", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadtacna.sprseg_config_eliminar ( " & strCadena & " );", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdseguridad_test.sprseg_config_eliminar ( " & strCadena & " );", prmParameter)
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

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(7) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_intUsuarioId")
                    .Add("?p_intModuloId")
                    .Add("?p_intRolId")
                    .Add("?p_strPermisos")
                    .Add("?p_strHorario")
                    .Add("?p_strUbicacion")
                    .Add("?p_strOpciones")
                    .Add("?p_intEstadoId")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Value = .UsuarioId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int16)
                    prmParameter(1).Value = .ModuloId

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.Int16)
                    prmParameter(2).Value = .RolId

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_LARGO_20)
                    prmParameter(3).Value = .Permisos

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(4).Value = .Horario

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(5).Value = .Ubicacion

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(6).Value = .Opciones

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.Int16)
                    prmParameter(7).Value = .EstadoId

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
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridad.sprseg_config_escribir ( " & strCadena & " );", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadluxor.sprseg_config_escribir ( " & strCadena & " );", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadtacna.sprseg_config_escribir ( " & strCadena & " );", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdseguridad_test.sprseg_config_escribir ( " & strCadena & " );", prmParameter)
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


