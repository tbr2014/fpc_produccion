'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySql.Data

Namespace COM

    Public Class clsTipoCambio

        Friend Shared objConexion As Util.Factory
        Private objMySqlConnection As MySqlConnection
        Private objMySqlCommand As MySqlCommand

        Sub New()
            objConexion = New Util.Factory
        End Sub

        Public Function Leer(ByVal Unidad As String) As Decimal

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objPar As New BEC.COM.clsParametro
            Dim cambio As Decimal

            Try

                Select Case Unidad
                    Case "FIESTA CASINO BENAVIDES"
                        Util.Factory.ConfigOrigen = 1
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "select bdcliente.fncfjm_tipocambio_mes();")

                    Case "LUXOR LIMA CASINO"
                        Util.Factory.ConfigOrigen = 2
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "select bdclienteluxor.fncfjm_tipocambio_mes();")

                    Case "LUXOR TACNA"
                        Util.Factory.ConfigOrigen = 3
                        CadenaConexion = Util.Factory.GetConexion
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "select bdclientetacna.fncfjm_tipocambio_mes();")

                    Case "EMPRESA DE PRUEBA"
                        Util.Factory.ConfigOrigen = 5
                        CadenaConexion = Util.Factory.GetConexion
                        'cambio = 
                        dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "select bdcliente_test.fncfjm_tipocambio_mes();")
                End Select


                If (dtsResultado.Tables(0).Rows.Count > 0) Then
                    Return dtsResultado.Tables(0).Rows(0)(0)
                Else
                    Return 0
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function Leer2() As DataSet

            Dim CadenaConexion As String
            'objConexion.GetConexion
            Dim dato As New Util.Dato
            Dim dtsResultado As New DataSet
            Dim objPar As New BEC.COM.clsParametro

            Try

                Util.Factory.ConfigOrigen = 3
                CadenaConexion = Util.Factory.GetConexion

                dtsResultado = MySqlHelper.ExecuteDataset(CadenaConexion, "call bdauxiliartacna.fncfjm_GetTipocambio();")

                Return dtsResultado
                'If (dtsResultado.Tables(0).Rows.Count > 0) Then
                '    Return dtsResultado.Tables(0).Rows(0)(0)
                'Else
                '    Return 0
                'End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

    End Class

End Namespace
