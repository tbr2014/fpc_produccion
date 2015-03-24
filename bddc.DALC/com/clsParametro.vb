'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Namespace COM

    Public Class clsParametro

        Friend Shared objConexion As Util.Factory

        Sub New()
            objConexion = New Util.Factory
        End Sub

        Public Function Escribir(ByRef objBEC As BEC.COM.clsParametro, ByVal Unidad As String) As Integer

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim intResultado As Integer
            Dim prmParameter(4) As MySqlParameter

            Try
                prmParameter(0) = New MySqlParameter("?p_intGrupoId", MySqlDbType.Int16)
                prmParameter(0).Value = objBEC.GrupoId

                prmParameter(1) = New MySqlParameter("?p_intParametroId", MySqlDbType.Int16)
                prmParameter(1).Value = objBEC.ParametroId

                prmParameter(2) = New MySqlParameter("?p_strNombre", MySqlDbType.String, 50)
                prmParameter(2).Value = objBEC.Nombre

                prmParameter(3) = New MySqlParameter("?p_strSiglas", MySqlDbType.String, 6)
                prmParameter(3).Value = objBEC.Siglas

                prmParameter(4) = New MySqlParameter("?p_intEstadoId", MySqlDbType.Int16)
                prmParameter(4).Value = objBEC.EstadoId

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdAuxiliar.spraux_parametro_escribir (?p_intGrupoId, ?p_intParametroId, ?p_strNombre, ?p_strSiglas, ?p_intEstadoId); ", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdAuxiliarluxor.spraux_parametro_escribir (?p_intGrupoId, ?p_intParametroId, ?p_strNombre, ?p_strSiglas, ?p_intEstadoId); ", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdAuxiliartacna.spraux_parametro_escribir (?p_intGrupoId, ?p_intParametroId, ?p_strNombre, ?p_strSiglas, ?p_intEstadoId); ", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        intResultado = MySqlHelper.ExecuteNonQuery(CadenaConexion, "call bdauxiliar_test.spraux_parametro_escribir (?p_intGrupoId, ?p_intParametroId, ?p_strNombre, ?p_strSiglas, ?p_intEstadoId); ", prmParameter)
                End Select

                If (intResultado > 0) Then
                    Return Util.Enumeracion.enmResultadoOperacion.OK
                Else
                    Return Util.Enumeracion.enmResultadoOperacion.ERR
                End If

            Catch ex As Exception
                Return Util.Enumeracion.enmResultadoOperacion.NONE
            End Try

        End Function

        Public Function Buscar(ByVal arrParam As IList, ByVal Unidad As String) As BEC.COM.clsParametro()

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arEstado As BEC.COM.clsParametro()
            Dim objPar As New BEC.COM.clsParametro
            Dim prmParameter(1) As MySqlParameter

            Try

                prmParameter(0) = New MySqlParameter("?p_intGrupoId", MySqlDbType.Int16)
                prmParameter(0).Value = arrParam(0)

                prmParameter(1) = New MySqlParameter("?p_intEstadoId", MySqlDbType.Int16)
                prmParameter(1).Value = arrParam(1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar.spraux_parametro_buscar (?p_intGrupoId, ?p_intEstadoId)", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliarluxor.spraux_parametro_buscar (?p_intGrupoId, ?p_intEstadoId)", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliartacna.spraux_parametro_buscar (?p_intGrupoId, ?p_intEstadoId)", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliar_test.spraux_parametro_buscar (?p_intGrupoId, ?p_intEstadoId)", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arEstado(dtsResultado.Tables(0).Rows.Count - 1)

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objPar = New BEC.COM.clsParametro
                        objPar.GrupoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("CPAR_GRUPOID"))
                        objPar.ParametroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("CPAR_ID"))
                        objPar.Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("SPAR_NOMBRE"))
                        objPar.Siglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("SPAR_SIGLAS"))
                        objPar.EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("FPAR_ESTADOID"))
                        arEstado(i) = objPar
                    Next

                    Return arEstado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Leer(ByVal intParametroId As Integer, ByVal intGrupoId As Integer, ByVal Unidad As String) As BEC.COM.clsParametro

            'Dim CadenaConexion As String
            ''objConexion.GetConexion
            'Dim dato As New Util.Dato
            'Dim dtsResultado As New DataSet
            'Dim objPar As New BEC.COM.clsParametro
            'Dim prmParameter(1) As MySqlParameter

            'Try

            '    prmParameter(0) = New MySqlParameter("@intParametroId", MySqlDbType.Int16)
            '    prmParameter(0).Value = intParametroId

            '    prmParameter(1) = New MySqlParameter("@intGrupoId", MySqlDbType.Int16)
            '    prmParameter(1).Value = intGrupoId

            '    Dim uni As Integer = StrComp(Unidad, "FIESTA CASINO BENAVIDES")
            '    If uni = 0 Then
            '        Util.Factory.ConfigOrigen = 2
            '        CadenaConexion = Util.Factory.GetConexion
            '        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridad.sprseg_usuario_buscar (?p_strUsuario);", prmParameter)
            '    Else
            '        Util.Factory.ConfigOrigen = 1
            '        CadenaConexion = Util.Factory.GetConexion
            '        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdSeguridadluxor.sprseg_usuario_buscar (?p_strUsuario);", prmParameter)
            '    End If


            '    dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "SPRSCC_PARAMETRO_LEER", prmParameter)

            '    If (dtsResultado.Tables(0).Rows.Count > 0) Then

            '        objPar = New BEC.COM.clsParametro
            '        objPar.GrupoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("CPAR_GRUPOID"))
            '        objPar.ParametroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("CPAR_ID"))
            '        objPar.Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("SPAR_NOMBRE"))
            '        objPar.Siglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("SPAR_SIGLAS"))
            '        objPar.EstadoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(0)("FPAR_ESTADO"))
            '        Return objPar

            '    Else
            Return Nothing
            '    End If

            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try

        End Function

        Public Function Seleccionar(ByVal strGrupos As String, ByVal Unidad As String) As BEC.COM.clsParametro()

            Dim CadenaConexion As String
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arEstado As BEC.COM.clsParametro()
            Dim objPar As New BEC.COM.clsParametro
            Dim prmParameter(0) As MySqlParameter

            Try

                prmParameter(0) = New MySqlParameter("?p_strGrupos", MySqlDbType.String)
                prmParameter(0).Value = strGrupos.Trim

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar.spraux_parametro_seleccionar (?p_strGrupos);", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliarluxor.spraux_parametro_seleccionar (?p_strGrupos);", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliartacna.spraux_parametro_seleccionar (?p_strGrupos);", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliar_test.spraux_parametro_seleccionar (?p_strGrupos);", prmParameter)
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arEstado(dtsResultado.Tables(0).Rows.Count - 1)

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objPar = New BEC.COM.clsParametro
                        objPar.GrupoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("CPAR_GRUPOID"))
                        objPar.ParametroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("CPAR_ID"))
                        objPar.Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("SPAR_NOMBRE"))
                        objPar.Siglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("SPAR_SIGLAS"))
                        arEstado(i) = objPar
                    Next

                    Return arEstado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Seleccionar2(ByVal strGrupos As String) As BEC.COM.clsParametro()

            Dim CadenaConexion As String = Util.Factory.GetConexion
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arEstado As BEC.COM.clsParametro()
            Dim objPar As New BEC.COM.clsParametro
            Dim prmParameter(0) As MySqlParameter

            Try

                prmParameter(0) = New MySqlParameter("?p_strGrupos", MySqlDbType.String)
                prmParameter(0).Value = strGrupos.Trim

                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliarluxor.spraux_parametro_seleccionar2 (?p_strGrupos);", prmParameter)

                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arEstado(dtsResultado.Tables(0).Rows.Count - 1)

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objPar = New BEC.COM.clsParametro
                        objPar.GrupoId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("CPAR_GRUPOID"))
                        objPar.ParametroId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("CPAR_ID"))
                        objPar.Nombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("SPAR_NOMBRE"))
                        objPar.Siglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("SPAR_SIGLAS"))
                        arEstado(i) = objPar
                    Next

                    Return arEstado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

    End Class

End Namespace