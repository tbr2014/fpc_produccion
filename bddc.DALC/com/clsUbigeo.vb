Imports MySql.Data.MySqlClient

Namespace COM

    Public Class clsUbigeo

        Friend Shared objConexion As Util.Factory

        Sub New()
            objConexion = New Util.Factory
        End Sub

        Public Function Buscar(ByVal arrParam As IList, ByVal Unidad As String) As IList

            Dim CadenaConexion As String
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim arrResultado As BEC.COM.clsItem()
            Dim objUbigeo As New BEC.COM.clsItem
            Dim prmParameter(1) As MySqlParameter

            Try

                prmParameter(0) = New MySqlParameter("?p_intTipoId", MySqlDbType.Int16)
                prmParameter(0).Value = arrParam(0)

                prmParameter(1) = New MySqlParameter("?p_intPadreId", MySqlDbType.Int16)
                prmParameter(1).Value = arrParam(1)

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliar.spraux_ubigeo_buscar (?p_intTipoId, ?p_intPadreId)", prmParameter)

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliarluxor.spraux_ubigeo_buscar (?p_intTipoId, ?p_intPadreId)", prmParameter)

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdAuxiliartacna.spraux_ubigeo_buscar (?p_intTipoId, ?p_intPadreId)", prmParameter)

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliar_test.spraux_ubigeo_buscar (?p_intTipoId, ?p_intPadreId)", prmParameter)
                End Select
                
                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    ReDim arrResultado(dtsResultado.Tables(0).Rows.Count)

                    objUbigeo = New BEC.COM.clsItem(0, Util.Constante.Opcion_SinEspecificar.ToUpper)
                    arrResultado(0) = objUbigeo

                    For i As Integer = 0 To dtsResultado.Tables(0).Rows.Count - 1
                        objUbigeo = New BEC.COM.clsItem

                        With objUbigeo
                            .ItemId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UbigeoId"))
                            .ItemNombre = dato.EsNuloBD(dtsResultado.Tables(0).Rows(i)("UbigeoNombre")).ToString.ToUpper
                        End With
                        arrResultado(i + 1) = objUbigeo
                    Next

                    Return arrResultado

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

    End Class

End Namespace

