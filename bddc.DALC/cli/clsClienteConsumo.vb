Imports MySql.Data
Imports MySql.Data.MySqlClient

Namespace CLI

    Public Class clsClienteConsumo
        'Implements DALC.COM.ICRUD

        Friend Shared objConexion As Util.Factory
        Private objConsumoBEC As BEC.CLI.clsClienteConsumo
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

        Public Function Leer(ByVal Unidad As String)

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim prmParameter(0) As MySqlParameter
            Dim arrParameter As New ArrayList

            Try

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm.sprbdd_clienteConsumo_leer();")

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmluxor.sprbdd_clienteConsumo_leer();")

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrmtacna.sprbdd_clienteConsumo_leer();")

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdcrm_test.sprbdd_clienteConsumo_leer();")
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then

                    Dim k As Integer = 0
                    objConsumoBEC = New BEC.CLI.clsClienteConsumo

                    With objConsumoBEC

                        .ClienteConsumoRank = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Rank"))
                        .ClienteConsumoIdkey = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("IdKey"))
                        '.ClienteId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteId"))
                        '.ClienteCodigo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteCodigo"))
                        '.ClienteApePat = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApePat"))
                        '.ClienteApeMat = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteApeMat"))
                        '.ClienteNombres = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNombres"))
                        '.ClienteTipoDocId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTipoDocId"))
                        '.ClienteTipoDoc = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTipoDoc"))
                        '.ClienteNumDoc = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteNumDoc"))
                        '.ClienteGeneroId = Convert.ToInt16(dtsResultado.Tables(0).Rows(k)("ClienteGeneroId"))
                        '.ClienteFecNac = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteFecNac"))
                        '.DomicilioDireccion = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioDireccion"))
                        '.DomicilioCiudad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("DomicilioCiudad"))
                        '.ClienteTelefonoFijo = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonoFijo"))
                        '.ClienteTelefonoMovil = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteTelefonoMovil"))
                        '.ClienteEmail = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteEmail"))
                        '.PreferenciasFJM = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("PreferenciasFJM"))
                        '.ClienteComentarios = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("ClienteComentarios"))
                        '.AudCreac_UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_UsuarioId"))
                        '.AudCreac_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Usuario"))
                        '.AudCreac_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudCreac_Fecha"))
                        '.AudEdic_UsuarioId = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_UsuarioId"))
                        '.AudEdic_Usuario = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Usuario"))
                        '.AudEdic_Fecha = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("AudEdic_Fecha"))
                        '.ClienteNacionalidad = dato.EsNuloBD(dtsResultado.Tables(0).Rows(k)("Nacionalidad"))

                    End With

                    Return objConsumoBEC

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Nothing

        End Function

#End Region


    End Class

End Namespace


