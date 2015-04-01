Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace SEG

    Public Class clsUsuario
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.SEG.clsUsuario
        'Private viwBEC As BEC.CLI.viwCliente
        Private strConsulta As String = ""
        Private strParametros As String = ""
        Private objMySqlConnection As MySqlConnection
        Private objMySqlCommand As MySqlCommand

        Sub New()
            objConexion = New Util.Factory
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Function Buscar(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList Implements COM.ICRUD.Buscar

            Dim CadenaConexion As String
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim objBEC As BEC.SEG.clsUsuario
            Dim arrResultado As ArrayList

            Try

                '1. Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_strUsuario")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = arrFiltro(0)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_usuario_buscar (?p_strUsuario);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_buscar (?p_strUsuario);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadtacna.sprseg_usuario_buscar (?p_strUsuario);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad_test.sprseg_usuario_buscar (?p_strUsuario);", prmParameter)

                End Select
                'If uni = 0 Then
                'Else
                'End If

               
                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    arrResultado = New ArrayList

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.SEG.clsUsuario

                        With objBEC
                            .UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioId"))
                            .Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Nombre"))
                            .Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Usuario"))
                            .TipoAutenticacionId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("TipoAutenticacionId"))
                            .EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("EstadoId"))

                        End With

                        arrResultado.Add(objBEC)

                    Next

                    Return arrResultado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Login(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(1) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_strUsuario")
                    .Add("?p_strClave")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(1).Value = arrFiltro(1)

                ''2. Formateando Parámetros del SP:
                'objMySqlCommand = New MySqlCommand
                'With objMySqlCommand
                '    .Connection = objMySqlConnection
                '    .CommandType = CommandType.StoredProcedure
                '    .CommandText = "sprbdd_cliente_escribir"
                '    .Parameters.AddRange(prmParameter)

                '3. Invocando al SP:

                'Dim uni As Integer = StrComp(Unidad, "FIESTA CASINO BENAVIDES")

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_usuario_login (??p_strUsuario, ?p_strClave);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_login (??p_strUsuario, ?p_strClave);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadtacna.sprseg_usuario_login (??p_strUsuario, ?p_strClave);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad_test.sprseg_usuario_login (??p_strUsuario, ?p_strClave);", prmParameter)

                End Select


                'If uni = 0 Then
                '    Util.Factory.ConfigOrigen = 1
                '    CadenaConexion = Util.Factory.GetConexion
                '    dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_usuario_login (?p_strUsuario, ?p_strClave);", prmParameter)
                'Else
                '    Util.Factory.ConfigOrigen = 2
                '    CadenaConexion = Util.Factory.GetConexion
                '    dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_login (?p_strUsuario, ?p_strClave);", prmParameter)
                'End If

              
                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    Return dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("UsuarioId"))
                Else
                    Return Util.Enumeracion.enmResultadoOperacion.NONE
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
            Dim strCadena As String = ""

            Try
                'REALMENTE NO ELIMINA EL USUARIO SINO ACTUALIZA SU ESTADO

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_intUsuarioId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                prmParameter(0).Value = Id

                '2. Formateando Parámetros del SP:
                For k As Integer = 0 To arrParameter.Count - 1
                    strCadena &= arrParameter(k) & ","
                Next
                strCadena = Mid(strCadena, 1, Len(strCadena) - 1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridad.sprseg_usuario_eliminar ( " & strCadena & " );", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_eliminar ( " & strCadena & " );", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadtacna.sprseg_usuario_eliminar ( " & strCadena & " );", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdseguridad_test.sprseg_usuario_eliminar ( " & strCadena & " );", prmParameter)

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
                    .Add("?p_strUsuario")
                    .Add("?p_strNombre")
                    .Add("?p_strClave")
                    .Add("?p_strAdicional")
                    .Add("?p_intTipoAutenticacionId")
                    .Add("?p_intEstadoId")
                    .Add("?p_intAudUsrId")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Direction = ParameterDirection.InputOutput
                    prmParameter(0).Value = .UsuarioId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(1).Value = .Usuario

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(2).Value = .Nombre

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                    prmParameter(3).Value = .Clave

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_COMENTARIO_CORTO_200)
                    prmParameter(4).Value = .Adicional

                    prmParameter(5) = New MySqlParameter(arrParameter(5).ToString, MySqlDbType.Int16)
                    prmParameter(5).Value = .TipoAutenticacionId

                    prmParameter(6) = New MySqlParameter(arrParameter(6).ToString, MySqlDbType.Int16)
                    prmParameter(6).Value = .EstadoId

                    prmParameter(7) = New MySqlParameter(arrParameter(7).ToString, MySqlDbType.Int16)
                    prmParameter(7).Value = .AudCreac_UsuarioId

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
                            .CommandText = "bdseguridad.sprseg_usuario_escribir"
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
                            .CommandText = "bdseguridadluxor.sprseg_usuario_escribir"
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
                            .CommandText = "bdseguridadtacna.sprseg_usuario_escribir"
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
                            .CommandText = "bdseguridad_test.sprseg_usuario_escribir"
                            .Parameters.AddRange(prmParameter)

                            '3. Invocando al SP:
                            intResultado = .ExecuteNonQuery()
                        End With

                End Select

                '4. Resultado del SP:
                If intResultado > 0 Then
                    'Parámetro(s) de Salida:
                    objBEC.UsuarioId = IIf(dato.EsNuloBD(prmParameter(0).Value) IsNot Nothing, prmParameter(0).Value, 0)
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

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim arrParameter As New ArrayList
            Dim prmParameter(0) As MySqlParameter
            Dim dtsResultado As DataSet

            Try

                'Definiendo Parámetros del SP:
                With arrParameter
                    .Add("?p_intUsuarioId")
                End With

                prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                prmParameter(0).Value = Id

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_usuario_leer (?p_intUsuarioId);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_leer (?p_intUsuarioId);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadtacna.sprseg_usuario_leer (?p_intUsuarioId);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad_test.sprseg_usuario_leer (?p_intUsuarioId);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    objBEC = New BEC.SEG.clsUsuario

                    With objBEC
                        .UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("UsuarioId"))
                        .Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("Usuario"))
                        .Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("Nombre"))
                        .TipoAutenticacionId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("TipoAutenticacionId"))
                        .Clave = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("Clave"))
                        .Adicional = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("Adicional"))
                    End With

                    Return objBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Listar(ByVal Unidad As String) As System.Collections.IList

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.COM.clsItem()
            Dim objBEC As BEC.COM.clsItem

            Try

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_usuario_listar ();")

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_listar ();")

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadtacna.sprseg_usuario_listar ();")

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad_test.sprseg_usuario_listar ();")
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count)

                    objBEC = New BEC.COM.clsItem(0, Util.Constante.Opcion_Todos)
                    arrBEC(0) = objBEC

                    For k As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.COM.clsItem

                        With objBEC
                            .ItemId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("UsuarioId"))
                            .ItemNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Nombre"))
                            '.Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Usuario"))

                        End With

                        arrBEC(k + 1) = objBEC

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

