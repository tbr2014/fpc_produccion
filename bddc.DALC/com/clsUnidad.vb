Imports MySql.Data.MySqlClient


Namespace COM

    Public Class clsUnidad

        Friend Shared objConexion As Util.Factory

        Sub New()
            objConexion = New Util.Factory
        End Sub

        Public Function Listar() As IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrResultado As BEC.COM.clsItem()
            Dim objBEC As New BEC.COM.clsItem

            Try
                Util.Factory.ConfigOrigen = 1
                CadenaConexion = Util.Factory.GetConexion
                'PRODUCCION
                'dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar.spraux_unidad_listar ();")

                'PRUEBA
                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar_test.spraux_unidad_listar ();")

                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arrResultado(dtsResultado.Tables(0).Rows.Count)

                    objBEC = New BEC.COM.clsItem(0, Util.Constante.Opcion_SinEspecificar.ToUpper)
                    arrResultado(0) = objBEC

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.COM.clsItem

                        With objBEC
                            .ItemId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UnidadId"))
                            .ItemNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("Unidad")).ToString.ToUpper
                        End With
                        arrResultado(i + 1) = objBEC
                    Next

                    Return arrResultado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

        Public Function Buscar(ByVal arrParam As IList, ByVal Unidad As String) As IList

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrResultado As ArrayList
            Dim objBEC As New BEC.COM.clsUnidad
            Dim prmParameter(0) As MySqlParameter

            Try

                prmParameter(0) = New MySqlParameter("?p_intEmpresaId", MySqlDbType.Int16)
                prmParameter(0).Value = arrParam(0)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar.spraux_unidad_buscar (?p_intEmpresaId)", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliarluxor.spraux_unidad_buscar (?p_intEmpresaId)", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliartacna.spraux_unidad_buscar (?p_intEmpresaId)", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliar_test.spraux_unidad_buscar (?p_intEmpresaId)", prmParameter)
                End Select

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    arrResultado = New ArrayList

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objBEC = New BEC.COM.clsUnidad

                        With objBEC
                            .EmpresaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("EmpresaId"))
                            .UnidadId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UnidadId"))
                            .Unidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("Unidad"))
                            .Siglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("Siglas"))
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

        Public Function Leer(ByVal Id As Integer) As BEC.COM.clsUnidad

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objBEC As New BEC.COM.clsUnidad
            Dim prmParameter(0) As MySqlParameter
            Dim i As Integer = 0

            Try

                prmParameter(0) = New MySqlParameter("?p_intUnidadId", MySqlDbType.Int16)
                prmParameter(0).Value = Id

                Util.Factory.ConfigOrigen = 1
                CadenaConexion = Util.Factory.GetConexion
                'PRODUCCION
                'dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar.spraux_unidad_leer (?p_intUnidadId)", prmParameter)

                'PRUEBAS
                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliar_test.spraux_unidad_leer (?p_intUnidadId)", prmParameter)

                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    objBEC = New BEC.COM.clsUnidad

                    With objBEC
                        .EmpresaId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("EmpresaId"))
                        .UnidadId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UnidadId"))
                        .Unidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("Unidad"))
                        .Siglas = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("Siglas"))
                    End With

                    Return objBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

    End Class

End Namespace


