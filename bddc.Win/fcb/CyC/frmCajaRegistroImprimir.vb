Public Class frmCajaRegistroImprimir

#Region "Atributos"

    Dim arrDatos As ArrayList
    Dim arrParam As ArrayList

    Private objXML As xmlOperacionCajaRegistro
    Private objCliBEC As BEC.CLI.clsCliente
    Private objOpeBEC As BEC.FCB.clsOperacionCaja

#End Region

#Region "Operaciones"

    Private Sub LeerDatos()

        Try
            
            If arrDatos IsNot Nothing Then

                objOpeBEC = arrDatos(0)
                objCliBEC = arrDatos(1)


                objXML = New xmlOperacionCajaRegistro
                Dim drFila As DataRow = objXML.rpOperacionCaja.NewRow

                With drFila
                    .Item("OperacionCodigo") = objOpeBEC.OperacionCodigo
                    .Item("OperacionFecha") = objOpeBEC.OperacionFecha
                    .Item("SujetoObligado") = objOpeBEC.SujetoObligado
                    .Item("OficialCumplimiento ") = objOpeBEC.OficialCumplimiento
                    .Item("OperacionMontoMonedaId") = objOpeBEC.OperacionMontoMonedaId
                    .Item("OperacionMontoImporte ") = objOpeBEC.OperacionMontoImporte
                    .Item("OperacionModalidadId") = objOpeBEC.OperacionModalidadId
                    .Item("OperacionTipoCambio") = objOpeBEC.OperacionTipoCambio
                    .Item("OperacionTipoId") = objOpeBEC.OperacionTipoId
                    .Item("ClienteNombres") = objCliBEC.ClienteNombres
                    .Item("ClienteApellidos") = objCliBEC.ClienteApePat & " " & objCliBEC.ClienteApeMat
                    .Item("ClienteTipoDocId") = objCliBEC.ClienteTipoDocId
                    .Item("ClienteNumDoc") = objCliBEC.ClienteNumDoc
                    .Item("ClientePais") = objCliBEC.DomicilioPais
                    .Item("ClienteNacionalidad") = objCliBEC.ClienteNacionalidad
                    .Item("ClienteDireccion") = objCliBEC.DomicilioDireccion
                    .Item("ClienteDireccionNro") = "" 'objCliBEC.DomicilioDireccionNro
                    .Item("ClienteDireccionInt") = "" 'objCliBEC.DomicilioDireccionInt
                    .Item("ClienteDireccionUrb") = "" 'objCliBEC.DomicilioDireccionUrb
                    .Item("ClienteDireccionDist") = objCliBEC.DomicilioCiudad
                    .Item("ClienteDireccionProv") = "" 'objCliBEC.DomicilioDireccionProv
                    .Item("ClienteDireccionDpto") = "" 'objCliBEC.DomicilioDireccionDpto
                    

                End With
                objXML.rpOperacionCaja.AddrpOperacionCajaRow(drFila)
                objXML.rpOperacionCaja.AcceptChanges()

                With crOperacionCajaRegistro1
                    .SetDataSource(objXML)
                End With

                crvResultados.Zoom(75)
                crvResultados.ReportSource = crOperacionCajaRegistro1
                crvResultados.Visible = True

                'dgvResultados.Visible = True
                'dgvResultados.DataSource = arrResultado

            Else
                Throw New DataException(Util.Constante.Ope_BuscarNONE)
            End If

        Catch ex As Exception
            crvResultados.Visible = False
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
        End Try

    End Sub

#End Region


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmCajaRegistroImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            LeerDatos()

            If Configuration.ConfigurationManager.AppSettings("ActivarAuditoriaEventos") = Util.Enumeracion.enmResultadoOperacion.OK Then

                Dim intUsuarioId As Integer = Util.Enumeracion.enmResultadoOperacion.NONE
                If frmLogin.objColeccionFCB.objUsuBEC IsNot Nothing Then intUsuarioId = frmLogin.objColeccionFCB.objUsuBEC.UsuarioId

                ' Pista de Auditoría:
                frmLogin.objColeccionFCB.objAuditoria = New DALC.SEG.clsUsuarioEvento(intUsuarioId, Util.Enumeracion.enmTipoAccion.Create, Util.Constante.Sistema._MODCYC & "->" & Me.Name, Environment.MachineName, frmLogin.objColeccionFCB.objUsuUndBEC.UnidadId, frmLogin.Unidad)
                frmLogin.objColeccionFCB.objAuditoria = Nothing
                ' Fin de Auditoría

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)

        End Try

    End Sub

    Public Sub New(ByVal parrDatos As ArrayList)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        arrDatos = New ArrayList
        arrDatos = parrDatos

    End Sub
End Class