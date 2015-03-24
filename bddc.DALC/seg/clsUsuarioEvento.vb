Imports bddc.Util
Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace SEG
    Public Class clsUsuarioEvento
        Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objBEC As BEC.SEG.clsUsuarioEvento
        'Private viwBEC As BEC.CLI.viwCliente
        Private strConsulta As String = ""
        Private strParametros As String = ""
        Private objMySqlConnection As MySqlConnection
        Private objMySqlCommand As MySqlCommand

        Sub New()
            objConexion = New Factory
        End Sub

        Sub New(ByVal pintUsuarioId As Integer, ByVal pintTipoEventoId As Integer, ByVal pstrAplicacion As String, ByVal pstrTerminal As String, ByVal pintUnidadId As Integer, ByVal Unidad As String)
            Dim objBEC As New BEC.SEG.clsUsuarioEvento
            objConexion = New Factory

            With objBEC
                .UsuarioId = pintUsuarioId
                .UsuarioTerminal = pstrTerminal
                .EventoTipoId = pintTipoEventoId
                .EventoAplicacion = pstrAplicacion
                .UnidadId = pintUnidadId
            End With

            Me.Escribir(objBEC, Unidad)
        End Sub

        Public Function Escribir(ByRef obj As Object, ByVal Unidad As String) As Integer Implements COM.ICRUD.Escribir
            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer = 0
            Dim prmParameter(4) As MySqlParameter
            Dim arrParameter As New ArrayList
            Dim strCadena As String = ""

            Try

                '1. Definiendo Parámetros del SP:

                With arrParameter
                    .Add("?p_intUsuarioId")
                    .Add("?p_intTipoId")
                    .Add("?p_strAplicacion")
                    .Add("?p_strTerminal")
                    .Add("?p_intUnidadId")
                End With

                objBEC = obj
                With objBEC

                    prmParameter(0) = New MySqlParameter(arrParameter(0).ToString, MySqlDbType.Int32)
                    prmParameter(0).Value = .UsuarioId

                    prmParameter(1) = New MySqlParameter(arrParameter(1).ToString, MySqlDbType.Int16)
                    prmParameter(1).Value = .EventoTipoId

                    prmParameter(2) = New MySqlParameter(arrParameter(2).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(2).Value = .EventoAplicacion

                    prmParameter(3) = New MySqlParameter(arrParameter(3).ToString, MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_NOMBRE_50)
                    prmParameter(3).Value = .UsuarioTerminal

                    prmParameter(4) = New MySqlParameter(arrParameter(4).ToString, MySqlDbType.Int32)
                    prmParameter(4).Value = .UnidadId

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
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridad.sprseg_evento_escribir ( " & strCadena & " );", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadluxor.sprseg_evento_escribir ( " & strCadena & " );", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdSeguridadtacna.sprseg_evento_escribir ( " & strCadena & " );", prmParameter)
                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdseguridad_test.sprseg_evento_escribir ( " & strCadena & " );", prmParameter)
                End Select

                'objMySqlConnection = New MySqlConnection(CadenaConexion)
                'objMySqlConnection.Open()

                'objMySqlCommand = New MySqlCommand
                'With objMySqlCommand
                '    .Connection = objMySqlConnection
                '    .CommandType = CommandType.StoredProcedure
                '    .CommandText = "bdSeguridad.sprseg_evento_escribir"
                '    .Parameters.AddRange(prmParameter)

                '    '3. Invocando al SP:
                '    intResultado = .ExecuteNonQuery()
                'End With

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

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Function Buscar(ByVal arrFiltro As System.Collections.IList, ByVal Unidad As String) As System.Collections.IList Implements COM.ICRUD.Buscar

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrBEC As BEC.SEG.clsUsuarioEvento()
            Dim objBEC As New BEC.SEG.clsUsuarioEvento
            Dim prmParameter(3) As MySqlParameter

            Try

                prmParameter(0) = New MySqlParameter("?p_intUsuarioId", MySqlDbType.Int16)
                prmParameter(0).Value = arrFiltro(0)

                prmParameter(1) = New MySqlParameter("?p_intTipoEventoId", MySqlDbType.Int16)
                prmParameter(1).Value = arrFiltro(1)

                prmParameter(2) = New MySqlParameter("?p_strFechaIni", MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(2).Value = arrFiltro(2)

                prmParameter(3) = New MySqlParameter("?p_strFechaFin", MySqlDbType.String, Util.Constante.DiccionarioDatos.CONST_CODIGO_MEDIO_10)
                prmParameter(3).Value = arrFiltro(3)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad.sprseg_evento_buscar (?p_intUsuarioId, ?p_intTipoEventoId, ?p_strFechaIni, ?p_strFechaFin)", prmParameter)
                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridadluxor.sprseg_evento_buscar (?p_intUsuarioId, ?p_intTipoEventoId, ?p_strFechaIni, ?p_strFechaFin)", prmParameter)
                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridadtacna.sprseg_evento_buscar (?p_intUsuarioId, ?p_intTipoEventoId, ?p_strFechaIni, ?p_strFechaFin)", prmParameter)
                    Case "EMPRESA DE PRUEBAS"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdseguridad_test.sprseg_evento_buscar (?p_intUsuarioId, ?p_intTipoEventoId, ?p_strFechaIni, ?p_strFechaFin)", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arrBEC(dtsResultado.Tables(0).Rows.Count - 1)

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.SEG.clsUsuarioEvento
                        With objBEC
                            .UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UsuarioId"))
                            .UsuarioNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UsuarioNombre"))
                            .UsuarioTerminal = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UsuarioTerminal"))
                            .EventoFecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("EventoFecha"))
                            .EventoTipo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("EventoTipo"))
                            .EventoAplicacion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("EventoAplicacion"))
                        End With

                        arrBEC(i) = objBEC
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

        Public Function Leer(ByVal Id As Integer, ByVal Unidad As String) As Object Implements COM.ICRUD.Leer
            Return Nothing
        End Function

    End Class
End Namespace

