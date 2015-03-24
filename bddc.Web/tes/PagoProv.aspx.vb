
Public Class PagoProv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Try

                'If Not Session("Usuario") Is Nothing Then Menu.generarMenu(mnuMenu, Server.MapPath("..\inc\menu.xml"), Session("Config"))

                Me.lblTitulo.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.MODPPP)
                'Me.lblVersion.Text = ConfigurationManager.AppSettings.Get("version")
                Me.lblOpcion.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.PPPCRO)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub sortColumn(ByVal sender As Object, ByVal e As CommandEventArgs)
        If e.CommandArgument.ToString() = ViewState("orderColumna").ToString() Then
            ViewState("orderDireccion") = IIf(ViewState("orderDireccion").ToString() = "ASC", "DESC", "ASC")
        Else
            ViewState("orderColumna") = e.CommandArgument.ToString()
            ViewState("orderDireccion") = "ASC"
        End If
        'Buscar()
    End Sub

    'Public Function indicador(ByVal iintColumna As Integer) As String
    '    Dim strIndicador As String
    '    'If (iintColumna.ToString() = ViewState("orderColumna").ToString()) Then
    '    '    If ViewState("orderDireccion").ToString() = "DESC" Then
    '    '        strIndicador = "<span style='font-family:Webdings;font-size:10'>5</span>"
    '    '    Else
    '    '        strIndicador = "<span style='font-family:Webdings;font-size:10'>6</span>"
    '    '    End If
    '    'End If
    '    indicador = strIndicador
    'End Function


    Private Sub BuscarxRUC()

        Dim arrResult As New ArrayList
        Dim objBEC As New BEC.TES.clsPagoProv
        Dim objImporta As New Util.Importacion.clsImporta

        Try

            If Me.txtNumRUC.Text.Trim <> "" Then
                arrResult = objImporta.LeerArchivoExcel(Me.txtNumRUC.Text.Trim)

                If arrResult IsNot Nothing Then
                    Me.dgResultados.DataSource = arrResult
                    Me.dgResultados.DataBind()
                    Me.dgResultados.Visible = True

                    Me.lblMensaje.CssClass = "GNRtxtInfo"
                    Me.lblMensaje.Text = Replace(Util.Constante.Ope_BuscarNUMREG, "XX", arrResult.Count.ToString)
                Else

                    Throw New Exception(Util.Constante.Ope_BuscarNONE)
                End If

            Else
                Throw New Exception(Util.Constante.Ope_BuscarSinParametros)
            End If

        Catch ex As Exception

            Me.lblMensaje.CssClass = "GNRtxtError"
            Me.lblMensaje.Text = ex.Message
            Me.dgResultados.Visible = False

        End Try


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBuscar.Click
        BuscarxRUC()
    End Sub

    Private Sub txtNumRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumRUC.TextChanged
        BuscarxRUC()
    End Sub

End Class