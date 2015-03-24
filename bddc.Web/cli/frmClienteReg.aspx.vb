Imports System.io
Imports System.Globalization

Public Class frmClienteReg
    Inherits System.Web.UI.Page

    'Private objAuditoria As DALC.SEG.clsEvento

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents lblVersion As System.Web.UI.WebControls.Label
    Protected WithEvents lblMensaje As System.Web.UI.WebControls.Label
    Protected WithEvents btnBuscar As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnGuardar As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Td6 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents lblOpcion As System.Web.UI.WebControls.Label
    Protected WithEvents ddlTipoDoc As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlSexo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlEstCivil As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlNacionalidad As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtNroDoc As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNombres As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtApePat As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtApeMat As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDireccion As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFecNac As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTelfCasa As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTelfTrabajo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTelfCelular As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtObservaciones As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblClienteId As System.Web.UI.WebControls.Label
    Protected WithEvents mnuMenu As skmMenu.Menu
    Protected WithEvents tab1 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tab2 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tab3 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents ddlEstadoProspecto As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlFormaPago As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtNroTarjetaCliente As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtReferidos As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblAudCreacion As System.Web.UI.WebControls.Label
    Protected WithEvents lblAudActualizacion As System.Web.UI.WebControls.Label
    Protected WithEvents ddlTipoCliente As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtFechaInicio As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFechaVenc As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblEstado As System.Web.UI.WebControls.Label
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    'Protected WithEvents RequiredFieldValidator3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator4 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator5 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator6 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tab4 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents rblMedios As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents lblTipoCliente As System.Web.UI.WebControls.Label
    Protected WithEvents td1 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents td2 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents td3 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents td4 As System.Web.UI.HtmlControls.HtmlTableCell
    'Protected WithEvents tdFechaVenc As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents hdTabActivo As System.Web.UI.HtmlControls.HtmlInputText
    'Protected WithEvents txtUsuarioLogin As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgAdquisiciones As System.Web.UI.WebControls.DataGrid
    Protected WithEvents dgPaquetes As System.Web.UI.WebControls.DataGrid
    Protected WithEvents dgProductos As System.Web.UI.WebControls.DataGrid
    Protected WithEvents rblOpciones As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents trPaquetes As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trProductos As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents txtRazonSocial As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRuc As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCargo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtComentariosCliente As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtBuscarItem As System.Web.UI.WebControls.TextBox
    Protected WithEvents imgbtnBuscarAdquisicion As System.Web.UI.WebControls.ImageButton
    Protected WithEvents trBuscarItem As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents txtDiasCongelamiento As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAdquisicionDescripcion As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgPaqueteDetalle As System.Web.UI.WebControls.DataGrid
    Protected WithEvents trPaqueteDetalle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents lblPaqProId As System.Web.UI.WebControls.Label
    Protected WithEvents chkAlarma As System.Web.UI.WebControls.CheckBox
    Protected WithEvents txtAdquisicionCantidad As System.Web.UI.WebControls.TextBox
    Protected WithEvents trAdquisicionEditar As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents btnAdquisicionComprar As System.Web.UI.WebControls.Button
    Protected WithEvents lbAsistSesiones As System.Web.UI.WebControls.ListBox
    Protected WithEvents txtNumAsistMembresia As System.Web.UI.WebControls.TextBox
    Protected WithEvents lbAsistMembresia As System.Web.UI.WebControls.ListBox
    Protected WithEvents txtNumAsistSesiones As System.Web.UI.WebControls.TextBox
    Protected WithEvents tblAsistencias As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblAdqTipoId As System.Web.UI.WebControls.Label
    Protected WithEvents lblAdqId As System.Web.UI.WebControls.Label
    Protected WithEvents vsResumen As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents lblClienteCodigo As System.Web.UI.WebControls.Label
    Protected WithEvents txtDiasAdicionales As System.Web.UI.WebControls.TextBox
    Protected WithEvents trTiempoAdicional As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tblAdquisicionDetalle As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents imgFoto As System.Web.UI.WebControls.Image
    Protected WithEvents txtFileUpload As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents trAdquisicionNombre As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents btnGrabarFoto As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private objUsuario As BEC.SEG.clsUsuario
    Private strCurrentCulture As String

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load

        If Not Page.IsPostBack Then

            Try
                'If Session("Usuario") Is Nothing Or Session("Config") Is Nothing Then
                '    Throw New DataException(Util.Constante.Acc_SesionERR)
                'Else
                '    objUsuario = CType(Session("Usuario"), BEC.SEG.clsUsuario)
                'End If

                'If Not Request.Cookies("LANGUAGE") Is Nothing Then
                '    strCurrentCulture = Server.HtmlEncode(Request.Cookies("LANGUAGE").Value)
                'Else
                '    Throw New DataException(Util.Constante.Acc_LanguageERR)
                'End If

                Menu.generarMenu(mnuMenu, Server.MapPath("..\inc\menu.xml"), Session("Config"))

                Me.lblTitulo.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.SISTIT)
                Me.lblOpcion.Text = Menu.NombreOpcion(Util.Enumeracion.enmOpcionMenu.CLIREG)
                Me.lblVersion.Text = Util.Factory.Version

                ViewState("orderColumna") = 1
                ViewState("orderDireccion") = "ASC"

                Me.trPaquetes.Visible = False
                Me.trProductos.Visible = False
                Me.trBuscarItem.Visible = False
                trAdquisicionNombre.Visible = False
                Me.trPaqueteDetalle.Visible = False
                'Me.trAdquisicionEditar.Visible = False
                btnAdquisicionComprar.Enabled = False
                Me.tblAsistencias.Visible = False
                lblClienteCodigo.Visible = False
                'Me.trTiempoAdicional.Visible = False
                Me.tblAdquisicionDetalle.Visible = False
                'Me.tdFechaVenc.Visible = False

                Me.dgPaquetes.SelectedIndex = -1
                Me.dgPaquetes.CurrentPageIndex = 0
                Me.dgProductos.SelectedIndex = -1
                Me.dgProductos.CurrentPageIndex = 0
                Me.dgAdquisiciones.SelectedIndex = -1
                Me.dgAdquisiciones.CurrentPageIndex = 0

                LeerParametros()
                ConfigurarEstilos()

                If Not Request.QueryString("Res") Is Nothing Then
                    Dim strResultado As String = Request.QueryString("Res")

                    Select Case strResultado
                        Case "OK"
                            Me.lblMensaje.CssClass = "GNRtxtInfo"
                            Me.lblMensaje.Text = Util.Constante.Ope_EscribirOK
                        Case "ERR"
                            Me.lblMensaje.CssClass = "GNRtxtError"
                            Me.lblMensaje.Text = Util.Constante.Ope_EscribirERR
                    End Select

                End If

                Dim intClienteId, intAdquisicionId, intResultado As Integer

                If Not Request.QueryString("Id") Is Nothing Then
                    intClienteId = Convert.ToInt32(Request.QueryString("Id"))
                    Me.lblClienteId.Text = intClienteId.ToString

                    'LeerPaquetes()
                    'LeerProductos()

                    '1. Prospecto:
                    'intResultado = Me.LeerProspecto(intClienteId)
                    If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then

                        '2. Leer Paquete/Producto seleccionado:
                        If Not Request.QueryString("PaqId") Is Nothing Then

                            'Dim intPaqueteId As Integer = Convert.ToInt32(Request.QueryString("PaqId"))
                            'Dim objDALC As New DALC.SCC.clsPaquete
                            'Dim objBEC As New BEC.SCC.clsPaquete
                            'Dim objBECDet As BEC.SCC.clsProducto()

                            'objBEC = objDALC.Leer(intPaqueteId)

                            'If Not objBEC Is Nothing Then

                            '    Me.hdTabActivo.Value = "2"

                            '    trAdquisicionNombre.Visible = True
                            '    Me.trPaqueteDetalle.Visible = True
                            '    Me.tblAdquisicionDetalle.Visible = True

                            '    Me.lblPaqProId.Text = objBEC.PaqueteId.ToString
                            '    Me.txtAdquisicionDescripcion.Text = objBEC.PaqueteDescripcion

                            '    objBECDet = objDALC.Detalle(objBEC.PaqueteCombinacion)

                            '    Me.dgPaqueteDetalle.DataSource = objBECDet
                            '    Me.dgPaqueteDetalle.DataBind()

                            'End If

                            'objBECDet = Nothing
                            'objBEC = Nothing
                            'objDALC = Nothing

                        End If

                        '2. Adquisiciones:

                        If Not Request.QueryString("AdqId") Is Nothing Then
                            intAdquisicionId = Convert.ToInt32(Request.QueryString("AdqId"))

                            Me.hdTabActivo.Value = "2"

                            If Not Request.QueryString("Op") Is Nothing Then
                                Dim strResultado As String = Request.QueryString("Op")

                                Select Case strResultado

                                    Case "D"
                                        'Me.EliminarAdquisicion(intAdquisicionId)
                                        'Me.LeerProspecto(intClienteId)

                                    Case "R"
                                        'Me.LeerAdquisicion(intAdquisicionId)

                                End Select

                            End If

                        Else
                            'Me.rblOpciones.SelectedIndex = Me.rblOpciones.Items.IndexOf(Me.rblOpciones.Items.FindByValue(Util.Enumeracion.enmTipoAdquisicion.Paquete))
                            Me.trPaquetes.Visible = True
                            Me.trProductos.Visible = False
                            Me.trBuscarItem.Visible = True
                        End If

                        'Me.LeerAdquisiciones(intClienteId)

                        Me.lblMensaje.CssClass = "GNRtxtInfo"
                        Me.lblMensaje.Text = Util.Constante.Ope_OperacionOK

                    End If

                End If

            Catch ex As Exception
                Me.lblMensaje.CssClass = "GNRtxtError"
                Me.lblMensaje.Text = ex.Message

            End Try

        End If

    End Sub

    Private Sub ConfigurarEstilos()

        '0. Configurar Estilos en los Controles:
        Dim lstControles As New ArrayList

        lstControles.Add(Me.ddlTipoDoc)
        lstControles.Add(Me.txtNroDoc)
        lstControles.Add(Me.txtNombres)
        lstControles.Add(Me.txtApePat)
        lstControles.Add(Me.txtApeMat)
        lstControles.Add(Me.txtFecNac)
        lstControles.Add(Me.ddlSexo)
        lstControles.Add(Me.ddlEstCivil)
        lstControles.Add(Me.txtDireccion)
        lstControles.Add(Me.ddlNacionalidad)
        lstControles.Add(Me.txtTelfCasa)
        lstControles.Add(Me.txtTelfTrabajo)
        lstControles.Add(Me.txtTelfCelular)
        lstControles.Add(Me.txtEmail)
        lstControles.Add(Me.txtObservaciones)

        lstControles.Add(Me.txtRazonSocial)
        lstControles.Add(Me.txtRuc)
        lstControles.Add(Me.txtCargo)
        lstControles.Add(Me.txtComentariosCliente)

        lstControles.Add(Me.txtFechaInicio)
        lstControles.Add(Me.ddlFormaPago)
        lstControles.Add(Me.txtNroTarjetaCliente)
        lstControles.Add(Me.txtDiasCongelamiento)
        lstControles.Add(Me.txtDiasAdicionales)
        lstControles.Add(Me.txtFechaVenc)

        Try
            For k As Integer = 0 To lstControles.Count - 1

                Dim objTexto As Object = lstControles(k)
                objTexto.Attributes.Add("onfocus", "changeStyle(this, 'onfocus');")
                objTexto.Attributes.Add("onblur", "changeStyle(this, 'onblur');")

            Next

            '1. Validación de Datos:
            Me.txtAdquisicionCantidad.Attributes.Add("onkeypress", "javascript:return soloNumeros(event);")
            Me.txtDiasCongelamiento.Attributes.Add("onkeypress", "javascript:return soloNumeros(event);")

            ' 2. Validación de Fechas:
            With Me.txtFecNac
                .Attributes.Add("onkeyup", "ValidateDate(this, event.keyCode)")
                .Attributes.Add("onkeydown", "return DateFormat(this, event.keyCode)")
                .Attributes.Add("onblur", "javascript:checkDt(this)")
            End With

            With Me.txtFechaInicio
                .Attributes.Add("onkeyup", "ValidateDate(this, event.keyCode)")
                .Attributes.Add("onkeydown", "return DateFormat(this, event.keyCode)")
                .Attributes.Add("onblur", "javascript:checkDt(this)")
            End With

            With Me.txtFechaVenc
                .Attributes.Add("onkeyup", "ValidateDate(this, event.keyCode)")
                .Attributes.Add("onkeydown", "return DateFormat(this, event.keyCode)")
                .Attributes.Add("onblur", "javascript:checkDt(this)")
            End With

        Catch ex As Exception
            Me.lblMensaje.CssClass = "GNRtxtError"
            Me.lblMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub ResetearControles()
        Me.ddlTipoDoc.SelectedIndex = 0
        Me.txtNroDoc.Text = ""
        Me.txtNombres.Text = ""
        Me.txtApeMat.Text = ""
        Me.txtApePat.Text = ""
        Me.txtFecNac.Text = "01/01/1940"
        'Me.txtFechaInicio.Text = Now.ToShortDateString
        'Me.txtFechaVenc.Text = Now.ToShortDateString
        Me.ddlNacionalidad.SelectedIndex = 12
        Me.ddlSexo.SelectedIndex = 0
        Me.ddlEstCivil.SelectedIndex = 0
        Me.txtDireccion.Text = ""
        Me.txtEmail.Text = ""
        Me.txtTelfCasa.Text = ""
        Me.txtTelfCelular.Text = ""
        Me.txtTelfTrabajo.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtReferidos.Text = ""
        Me.rblMedios.Items.Clear()
        Me.lblAudActualizacion.Text = ""
        Me.txtRazonSocial.Text = ""
        Me.txtRuc.Text = ""
        Me.txtCargo.Text = ""
        Me.txtComentariosCliente.Text = ""
    End Sub

#Region "Funciones para Cabeceras del Datagrid"

    Public Sub sortColumn(ByVal sender As Object, ByVal e As CommandEventArgs)
        If e.CommandArgument.ToString() = ViewState("orderColumna").ToString() Then
            ViewState("orderDireccion") = IIf(ViewState("orderDireccion").ToString() = "ASC", "DESC", "ASC")
        Else
            ViewState("orderColumna") = e.CommandArgument.ToString()
            ViewState("orderDireccion") = "ASC"
        End If
        'Buscar()
    End Sub

    Public Function indicador(ByVal iintColumna As Integer) As String
        Dim strIndicador As String
        If (iintColumna.ToString() = ViewState("orderColumna").ToString()) Then
            If ViewState("orderDireccion").ToString() = "DESC" Then
                strIndicador = "<span style='font-family:Webdings;font-size:10'>5</span>"
            Else
                strIndicador = "<span style='font-family:Webdings;font-size:10'>6</span>"
            End If
        End If
        indicador = strIndicador
    End Function

#End Region

#Region "Funciones para Tab's"

    Sub OcultarTAB(ByVal intNumTab As Integer)
        'Ver lo seleccionado:
        Select Case intNumTab
            Case 1
                td1.Style("DISPLAY") = "none"
            Case 2
                td2.Style("DISPLAY") = "none"
            Case 3
                td3.Style("DISPLAY") = "none"
        End Select
    End Sub

    Sub HabilitarTAB(ByVal intNumTab As Integer)

        'Ocultar todas:
        td1.Attributes("class") = "tabGNR01Out"
        td2.Attributes("class") = "tabGNR01Out"
        td3.Attributes("class") = "tabGNR01Out"

        'Ver lo seleccionado:
        Select Case intNumTab
            Case 1
                td1.Attributes("class") = "tabGNR01Over"
                td1.Style("display") = "block"
            Case 2
                td2.Attributes("class") = "tabGNR01Over"
                td2.Style("display") = "block"
            Case 3
                td3.Attributes("class") = "tabGNR01Over"
                td3.Style("display") = "block"
        End Select

    End Sub
#End Region

#Region "Eventos de Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBuscar.Click
        'Dim strCadena As String = "<script language='JavaScript'>window.open('frmClienteBusqueda.aspx', 'WinSeg', 'width=820,height=400,scrollbars=yes');</script>"
        'Response.Write(strCadena)
        Response.Redirect("frmBusquedaRegistros.aspx")
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnGuardar.Click
        Page.Validate()
        'If Page.IsValid Then EscribirProspecto()
    End Sub

    Private Sub rblOpciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rblOpciones.SelectedIndexChanged

        Me.trPaquetes.Visible = False
        Me.trProductos.Visible = False
        Me.trBuscarItem.Visible = True

        'Select Case Convert.ToInt16(Me.rblOpciones.SelectedItem.Value)
        '    Case Util.Enumeracion.enmTipoAdquisicion.Paquete
        '        Me.trPaquetes.Visible = True
        '    Case Util.Enumeracion.enmTipoAdquisicion.Producto
        '        Me.trProductos.Visible = True
        'End Select

    End Sub

    Private Sub dgPaquetes_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgPaquetes.PageIndexChanged
        dgPaquetes.SelectedIndex = -1
        dgPaquetes.CurrentPageIndex = e.NewPageIndex
        'Me.LeerPaquetes(Me.txtBuscarItem.Text.Trim)
    End Sub

    Private Sub dgProductos_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgProductos.PageIndexChanged
        dgProductos.SelectedIndex = -1
        dgProductos.CurrentPageIndex = e.NewPageIndex
        'Me.LeerProductos(Me.txtBuscarItem.Text.Trim)
    End Sub

    Private Sub imgbtnBuscarAdquisicion_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgbtnBuscarAdquisicion.Click
        Me.dgPaquetes.SelectedIndex = -1
        Me.dgPaquetes.CurrentPageIndex = 0
        Me.dgProductos.SelectedIndex = -1
        Me.dgProductos.CurrentPageIndex = 0

        'BuscarAdquisiciones()

    End Sub

    Private Sub btnAdquisicionComprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdquisicionComprar.Click
        'EscribirAdquisicion(Util.Enumeracion.enmTipoAccion.Create)
        hdTabActivo.Value = 2
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        GC.Collect()
    End Sub

#End Region

#Region "Datos de Parámetros"

    Private Sub LeerParametros()

        Dim objDL As New DALC.COM.clsParametro
        Dim objBEC As BEC.COM.clsParametro
        Dim arrResultados As IList

        Try
            ' 1. Parametro AUX
            arrResultados = objDL.Seleccionar("1, 3, 4, 5, 9, 11, 12, 14, 15")

            If arrResultados.Count > 0 Then
                Me.ddlTipoDoc.Items.Clear()
                Me.ddlNacionalidad.Items.Clear()
                Me.ddlSexo.Items.Clear()
                Me.ddlEstCivil.Items.Clear()
                Me.rblMedios.Items.Clear()
                Me.rblOpciones.Items.Clear()
                Me.ddlTipoCliente.Items.Clear()

                For k As Integer = 0 To arrResultados.Count - 1
                    objBEC = CType(arrResultados(k), BEC.COM.clsParametro)
                    Select Case objBEC.GrupoId
                        Case Util.Enumeracion.enmGrupoParametro.Estado
                            Me.ddlEstadoProspecto.Items.Add(New ListItem(objBEC.Nombre, objBEC.ParametroId))
                        Case Util.Enumeracion.enmGrupoParametro.DocumentoIdentidad
                            Me.ddlTipoDoc.Items.Add(New ListItem(objBEC.Nombre, objBEC.ParametroId))
                        Case Util.Enumeracion.enmGrupoParametro.Nacionalidad
                            Me.ddlNacionalidad.Items.Add(New ListItem(objBEC.Nombre, objBEC.ParametroId))
                        Case Util.Enumeracion.enmGrupoParametro.Genero
                            Me.ddlSexo.Items.Add(New ListItem(objBEC.Nombre, objBEC.ParametroId))
                        Case Util.Enumeracion.enmGrupoParametro.EstadoCivil
                            Me.ddlEstCivil.Items.Add(New ListItem(objBEC.Nombre, objBEC.ParametroId))
                    End Select
                Next

                Me.ddlNacionalidad.Items.Insert(0, New ListItem(Util.Constante.Opcion_Seleccione, -1))
                Me.ddlSexo.Items.Insert(0, New ListItem(Util.Constante.Opcion_Seleccione, -1))
                Me.ddlEstCivil.Items.Insert(0, New ListItem(Util.Constante.Opcion_Seleccione, -1))

                Me.ddlEstadoProspecto.SelectedIndex = ddlEstadoProspecto.Items.IndexOf(ddlEstadoProspecto.Items.FindByValue(Util.Enumeracion.enmResultadoOperacion.OK))
                Me.rblMedios.SelectedIndex = Me.rblMedios.Items.IndexOf(Me.rblMedios.Items.FindByValue(5)) ' Otros

                Me.ddlFormaPago.Items.Insert(0, New ListItem(Util.Constante.Opcion_Seleccione, -1))

            End If

        Catch ex As Exception
            Me.lblMensaje.CssClass = "GNRtxtError"
            Me.lblMensaje.Text = ex.Message

        Finally
            objDL = Nothing
        End Try

    End Sub

#End Region

#Region "Datos de Paquetes"

    'Private Sub LeerPaquetes(Optional ByVal strBuscar As String = "")

    '    Dim objDatos As New DALC.SCC.clsPaquete
    '    Dim arrResultado As IList

    '    Try

    '        arrResultado = objDatos.Buscar(strBuscar, Util.Enumeracion.enmResultadoOperacion.OK)

    '        If Not arrResultado Is Nothing Then
    '            If arrResultado.Count > 0 Then

    '                'Me.lblMensaje.CssClass = "GNRtxtInfo"
    '                'Me.lblMensaje.Text = Replace("Se encontraron 00 filas", "00", arrResultado.Count.ToString)

    '                'Me.dgPaquetes.SelectedIndex = -1
    '                'Me.dgPaquetes.CurrentPageIndex = 0
    '                Me.dgPaquetes.Visible = True
    '                Me.dgPaquetes.DataSource = arrResultado
    '                Me.dgPaquetes.DataBind()
    '                SettingControlsPaquetes()

    '                Me.btnAdquisicionComprar.Enabled = True
    '                '    Else
    '                '        Throw New Exception(UTIL.Constante.Ope_LeerERR)
    '            End If
    '            'Else
    '            '    Throw New Exception(UTIL.Constante.Ope_BuscarERR)
    '        End If

    '    Catch ex As Exception
    '        Me.dgPaquetes.Visible = False
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message

    '    End Try

    'End Sub

    Private Sub SettingControlsPaquetes()
        'Dim img1, img2 As WebControls.Image
        Dim imgVer As HtmlImage
        Dim hlkPaquete As HyperLink
        Dim lbl As Label
        Dim strPaqueteId As String

        For Each gItem As DataGridItem In Me.dgPaquetes.Items

            imgVer = CType(gItem.Cells(1).FindControl("imgVerPaq"), HtmlImage)
            strPaqueteId = gItem.Cells(0).Text
            'imgVer.Visible = True
            'imgVer.Attributes.Add("onclick", "JavaScript:window.open('frmPaquete.aspx?Id=" & strUsuarioId & "')")
            'imgVer.Attributes.Add("onclick", "JavaScript:window.open('..\mto\frmPaquete.aspx?Id=" & strPaqueteId & "', 'Paquete', 'width=820,height=400,scrollbars=yes')")

            hlkPaquete = CType(gItem.Cells(6).FindControl("hlkPaquete"), HyperLink)
            hlkPaquete.NavigateUrl = "frmClienteRegistro.aspx?Id=" & Me.lblClienteId.Text & "&PaqId=" & strPaqueteId
        Next

    End Sub

#End Region

#Region "Datos de Productos"

    'Private Sub LeerProductos(Optional ByVal strBuscar As String = "")

    '    Dim objDatos As New DALC.SCC.clsProducto
    '    Dim arrResultado As IList

    '    Try

    '        arrResultado = objDatos.Buscar(strBuscar, Util.Enumeracion.enmResultadoOperacion.OK)

    '        If Not arrResultado Is Nothing Then
    '            If arrResultado.Count > 0 Then

    '                'Me.lblMensaje.CssClass = "GNRtxtInfo"
    '                'Me.lblMensaje.Text = Replace("Se encontraron 00 filas", "00", arrResultado.Count.ToString)

    '                'Me.dgProductos.SelectedIndex = -1
    '                'Me.dgProductos.CurrentPageIndex = 0
    '                Me.dgProductos.Visible = True
    '                Me.dgProductos.DataSource = arrResultado
    '                Me.dgProductos.DataBind()
    '                SettingControlsProductos()

    '                Me.btnAdquisicionComprar.Enabled = True

    '                '    Else
    '                '        Throw New Exception(UTIL.Constante.Ope_LeerERR)
    '            End If
    '            'Else
    '            '    Throw New Exception(UTIL.Constante.Ope_BuscarERR)
    '        End If

    '    Catch ex As Exception
    '        Me.dgProductos.Visible = False
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message

    '    End Try

    'End Sub

    Private Sub SettingControlsProductos()

        'Dim img1, img2 As WebControls.Image
        Dim imgVer As HtmlImage
        Dim hlkProducto As HyperLink
        Dim lbl As Label
        Dim strProductoId As String

        For Each gItem As DataGridItem In Me.dgProductos.Items

            imgVer = CType(gItem.Cells(1).FindControl("imgVerProd"), HtmlImage)
            strProductoId = gItem.Cells(0).Text
            'imgVer.Visible = True
            'imgVer.Attributes.Add("onclick", "JavaScript:window.open('frmPaquete.aspx?Id=" & strUsuarioId & "')")
            'imgVer.Attributes.Add("onclick", "JavaScript:window.open('..\mto\frmProducto.aspx?Id=" & strProductoId & "', 'Producto', 'width=820,height=400,scrollbars=yes')")

            hlkProducto = CType(gItem.Cells(8).FindControl("hlkProducto"), HyperLink)
            hlkProducto.NavigateUrl = "frmClienteRegistro.aspx?Id=" & Me.lblClienteId.Text & "&ProdId=" & strProductoId

        Next

    End Sub

#End Region

#Region "Datos de Adquisiciones"

    'Private Sub EscribirAdquisicion(ByVal intOperacionId As Util.Enumeracion.enmTipoAccion)

    '    Dim objDALC As New DALC.CSR.clsAdquisicion
    '    Dim objBEC As New BEC.CSR.clsAdquisicion
    '    Dim intResultado As Integer = Util.Enumeracion.enmResultadoOperacion.NONE

    '    Try

    '        With objBEC

    '            Select Case intOperacionId
    '                Case Util.Enumeracion.enmTipoAccion.Create
    '                    .AdquisicionId = 0
    '                    .AdquisicionTipoId = Convert.ToInt16(Me.rblOpciones.SelectedItem.Value)
    '                    .AdquisicionPaqProId = Convert.ToInt32(Me.lblPaqProId.Text)

    '                Case Util.Enumeracion.enmTipoAccion.Update
    '                    .AdquisicionId = Convert.ToInt32(Me.lblAdqId.Text)
    '                    .AdquisicionTipoId = Convert.ToInt16(Me.lblAdqTipoId.Text)
    '                    .AdquisicionPaqProId = Convert.ToInt32(Me.lblPaqProId.Text)

    '            End Select

    '            .ClienteId = Convert.ToInt32(Me.lblClienteId.Text)

    '            If Me.txtAdquisicionCantidad.Text <> "" Then
    '                objBEC.AdquisicionCantidad = Convert.ToInt16(Me.txtAdquisicionCantidad.Text)
    '            Else
    '                objBEC.AdquisicionCantidad = 0
    '            End If

    '            .AdquisicionFechaInicio = Me.txtFechaInicio.Text
    '            .AdquisicionTipoPagoId = Convert.ToInt32(Me.ddlFormaPago.SelectedItem.Value)
    '            .AdquisicionNumTarjeta = Me.txtNroTarjetaCliente.Text.Trim

    '            If .AdquisicionTipoPagoId = 5 Then
    '                .AdquisicionFechaVenc = Me.txtFechaVenc.Text
    '            Else
    '                .AdquisicionFechaVenc = ""
    '            End If

    '            If Me.txtDiasCongelamiento.Text <> "" Then
    '                .AdquisicionNumDiasCong = Convert.ToInt32(Me.txtDiasCongelamiento.Text)
    '            Else
    '                .AdquisicionNumDiasCong = 0
    '            End If

    '            If Me.txtDiasAdicionales.Text <> "" Then
    '                .AdquisicionNumDiasAdic = Convert.ToInt32(Me.txtDiasAdicionales.Text)
    '            Else
    '                .AdquisicionNumDiasAdic = 0
    '            End If

    '            .AlarmaId = IIf(Me.chkAlarma.Checked, Util.Enumeracion.enmResultadoOperacion.OK, Util.Enumeracion.enmResultadoOperacion.NONE)

    '            .AdquisicionEstadoId = Util.Enumeracion.enmResultadoOperacion.OK
    '            objUsuario = CType(Session("Usuario"), BEC.SEG.clsUsuario)
    '            .AudUsuarioId = objUsuario.UsuarioId

    '        End With

    '        intResultado = objDALC.Escribir(objBEC)

    '        If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
    '            'Server.Transfer("frmClienteRegistro.aspx?Id=" & Me.lblClienteId.Text & "&Res=OK")
    '            Response.Redirect("frmClienteRegistro.aspx?Id=" & Me.lblClienteId.Text & "&Res=OK")

    '        Else
    '            Me.lblMensaje.CssClass = "GNRtxtError"
    '            Me.lblMensaje.Text = Util.Constante.Ope_OperacionERR
    '        End If

    '    Catch ex As Exception
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message
    '    End Try

    'End Sub

    'Private Sub BuscarAdquisiciones()
    '    Dim strBuscar As String = Me.txtBuscarItem.Text.Trim

    '    If Me.trPaquetes.Visible = True Then Me.LeerPaquetes(strBuscar)
    '    If Me.trProductos.Visible = True Then Me.LeerProductos(strBuscar)

    'End Sub

    'Private Sub LeerAdquisicion(ByVal intAdquisicionId As Integer)

    '    Try

    '        Dim objDALC As New DALC.CSR.clsAdquisicion
    '        Dim objBEC As New BEC.CSR.clsAdquisicion

    '        objBEC = objDALC.Leer(intAdquisicionId)

    '        If Not objBEC Is Nothing Then

    '            trAdquisicionNombre.Visible = True
    '            Me.trAdquisicionEditar.Visible = True
    '            Me.trTiempoAdicional.Visible = True
    '            Me.tblAdquisicionDetalle.Visible = True

    '            With objBEC
    '                Me.lblAdqId.Text = .AdquisicionId.ToString
    '                Me.lblPaqProId.Text = .AdquisicionPaqProId.ToString
    '                Me.lblAdqTipoId.Text = .AdquisicionTipoId.ToString
    '                Me.txtAdquisicionDescripcion.Text = .AdquisicionPaqPro
    '                Me.txtFechaInicio.Text = .AdquisicionFechaInicio
    '                Me.ddlFormaPago.SelectedIndex = Me.ddlFormaPago.Items.IndexOf(Me.ddlFormaPago.Items.FindByValue(.AdquisicionTipoPagoId))

    '                If Me.ddlFormaPago.SelectedItem.Value = 5 Then
    '                    'tdFechaVenc.Visible = True
    '                    Me.txtFechaVenc.Text = .AdquisicionFechaVenc
    '                Else
    '                    'tdFechaVenc.Visible = False
    '                End If

    '                Me.txtDiasCongelamiento.Text = .AdquisicionNumDiasCong.ToString
    '                Me.txtDiasAdicionales.Text = .AdquisicionNumDiasAdic.ToString

    '                txtDiasAdicionales.Enabled = False
    '                objUsuario = CType(Session("Usuario"), BEC.SEG.clsUsuario)
    '                If objUsuario.UsuarioPerfilId = Util.Enumeracion.enmTipoPerfil.Administrador Then txtDiasAdicionales.Enabled = True

    '                Me.txtAdquisicionCantidad.Text = .AdquisicionCantidad.ToString
    '                Me.txtNroTarjetaCliente.Text = .AdquisicionNumTarjeta.Trim
    '                Me.chkAlarma.Checked = IIf(.AlarmaId = Util.Enumeracion.enmResultadoOperacion.OK, True, False)

    '            End With

    '            ' Asistencias:
    '            Me.LeerAsistencias(objBEC.AdquisicionAsistenciasFechas)

    '        End If

    '    Catch ex As Exception
    '        Me.dgPaquetes.Visible = False
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message

    '    End Try

    'End Sub

    'Private Sub LeerAdquisiciones(ByVal intClienteId As Integer)

    '    Dim objDatos As New DALC.CSR.clsAdquisicion
    '    Dim chkAsistencia As CheckBox
    '    Dim arrResultado As IList
    '    Dim intNumAsistencia As Integer = 0
    '    Try

    '        arrResultado = objDatos.Buscar(intClienteId)

    '        If Not arrResultado Is Nothing Then
    '            If arrResultado.Count > 0 Then

    '                'Me.lblMensaje.CssClass = "GNRtxtInfo"
    '                'Me.lblMensaje.Text = Replace("Se encontraron 00 filas", "00", arrResultado.Count.ToString)

    '                Me.dgAdquisiciones.Visible = True
    '                Me.dgAdquisiciones.DataSource = arrResultado
    '                Me.dgAdquisiciones.DataBind()
    '                SettingControlsAdquisiciones()

    '            End If
    '            'Else
    '            '    Throw New Exception(UTIL.Constante.Ope_BuscarERR)
    '        End If


    '    Catch ex As Exception
    '        Me.dgPaquetes.Visible = False
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message

    '    End Try

    'End Sub

    Private Sub SettingControlsAdquisiciones()

        Dim img1, img2 As WebControls.Image
        Dim imgVer, imgBorrar As HtmlImage
        Dim imgEditar As HyperLink
        Dim lbl As Label
        Dim strAdquisicionId, strClienteId As String

        For Each gItem As DataGridItem In Me.dgAdquisiciones.Items

            strAdquisicionId = gItem.Cells(0).Text
            strClienteId = Me.lblClienteId.Text 'gItem.Cells(12).Text

            imgVer = CType(gItem.Cells(1).FindControl("imgVerAdq"), HtmlImage)
            imgVer.Visible = True
            imgVer.Attributes.Add("onclick", "JavaScript:window.navigate('frmClienteRegistro.aspx?Id=" & strClienteId & "&AdqId=" & strAdquisicionId & "&Op=R')")

            img1 = CType(gItem.FindControl("imgActivo"), WebControls.Image)
            img2 = CType(gItem.FindControl("imgInactivo"), WebControls.Image)

            imgBorrar = CType(gItem.Cells(10).FindControl("imgBorrar"), HtmlImage)
            imgBorrar.Visible = False

            Dim strEstado As String = gItem.Cells(11).Text

            If strEstado = Util.Enumeracion.enmResultadoOperacion.OK Then
                img1.Visible = True
                img2.Visible = False

                objUsuario = CType(Session("Usuario"), BEC.SEG.clsUsuario)
                'If objUsuario.RolId = Util.Enumeracion.enmSEGRol.Administrador Then
                '    imgBorrar.Attributes.Add("onclick", "JavaScript:window.navigate('frmClienteRegistro.aspx?Id=" & strClienteId & "&AdqId=" & strAdquisicionId & "&Op=D')")
                '    imgBorrar.Visible = True
                'End If

            Else
                img1.Visible = False
                img2.Visible = True
            End If

        Next

    End Sub

    'Private Sub EliminarAdquisicion(ByVal intAdquisicionId As Integer)

    '    Dim objDALC As New DALC.CSR.clsAdquisicion
    '    Dim intResultado As Integer = objDALC.Eliminar(intAdquisicionId)

    '    If intResultado = Util.Enumeracion.enmResultadoOperacion.OK Then
    '        Me.lblMensaje.CssClass = "GNRtxtInfo"
    '        Me.lblMensaje.Text = Util.Constante.Ope_OperacionOK
    '    Else
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = Util.Constante.Ope_OperacionERR
    '    End If

    'End Sub

#End Region

#Region "Datos de Asistencias"

    'Private Sub LeerAsistencias(ByVal arrResultado As IList)

    '    Dim objDALC As New DALC.CSR.clsAdquisicion
    '    Dim chkAsistencia As CheckBox
    '    Dim strCadena As String
    '    Dim intNumAsistencia As Integer = 0

    '    Try

    '        If Not arrResultado Is Nothing Then
    '            If arrResultado.Count > 0 Then

    '                lbAsistMembresia.Items.Clear()
    '                Me.tblAsistencias.Visible = True

    '                For k As Integer = 0 To arrResultado.Count - 1

    '                    strCadena = arrResultado(k)
    '                    Me.lbAsistMembresia.Items.Add(New ListItem(strCadena))

    '                Next

    '                Me.txtNumAsistMembresia.Text = lbAsistMembresia.Items.Count.ToString

    '            End If

    '        End If

    '    Catch ex As Exception
    '        Me.dgPaquetes.Visible = False
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message

    '    End Try

    'End Sub

    'Private Sub EscribirAsistencias(ByVal intClienteId As Integer, ByVal strAsistencias As String)
    '    Dim objDALC As New DALC.CSR.clsProspecto
    '    Dim objBEC As BEC.CSR.clsProspecto
    '    Dim intResult As Integer = UTIL.Enumeracion.enmResultadoOperacion.NONE

    '    Try
    '        intResult = objDALC.EscribirAsistencias(intClienteId, strAsistencias)

    '        If intResult = UTIL.Enumeracion.enmResultadoOperacion.OK Then
    '            Response.Redirect("frmClienteRegistro.aspx?Id=" & intClienteId.ToString & "&Res=OK")
    '        Else
    '            Response.Redirect("frmClienteRegistro.aspx?Id=" & intClienteId.ToString & "&Res=ERR")
    '        End If

    '    Catch ex As Exception
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = UTIL.Constante.Ope_OperacionERR

    '    Finally
    '        objDALC = Nothing
    '        objBEC = Nothing
    '    End Try

    'End Sub

#End Region

#Region "Datos de Prospecto"

    'Private Sub EscribirProspecto()

    '    Dim objDALC As DALC.CSR.clsProspecto
    '    Dim objBEC As BEC.CSR.clsProspecto
    '    Dim intResult As Integer
    '    Dim strId As String

    '    Try
    '        'If Me.txtNroDoc.Text <> "" Then

    '        'Validar fecha(s):
    '        'Me.txtFecNac.Text

    '        objDALC = New DALC.CSR.clsProspecto
    '        objBEC = New BEC.CSR.clsProspecto

    '        With objBEC
    '            If Me.lblClienteId.Text <> "" Then
    '                .ClienteId = Convert.ToInt32(Me.lblClienteId.Text)
    '            Else
    '                .ClienteId = 0
    '            End If

    '            .ClienteTipoDocId = Me.ddlTipoDoc.SelectedItem.Value
    '            .ClienteNumDoc = Me.txtNroDoc.Text.Trim
    '            .ClienteNacionalidadId = Me.ddlNacionalidad.SelectedItem.Value
    '            .ClienteNom = Me.txtNombres.Text.Trim
    '            .ClienteApePat = Me.txtApePat.Text.Trim
    '            .ClienteApeMat = Me.txtApeMat.Text.Trim

    '            'If IsDate(txtFecNac.Text) Then
    '            '    .ClienteFecNac = DateTime.Parse(txtFecNac.Text, CultureInfo.CreateSpecificCulture("es-PE"))
    '            'Else
    '            '    .ClienteFecNac = ""
    '            'End If
    '            .ClienteFecNac = txtFecNac.Text

    '            .ClienteSexoId = Me.ddlSexo.SelectedValue
    '            .ClienteEstCivilId = Me.ddlEstCivil.SelectedItem.Value
    '            .ClienteDir = Me.txtDireccion.Text.Trim
    '            .ClienteTelfCasa = Me.txtTelfCasa.Text.Trim
    '            .ClienteTelfMovil = Me.txtTelfCelular.Text.Trim
    '            .ClienteTelfTrab = Me.txtTelfTrabajo.Text.Trim
    '            .ClienteEmail = Me.txtEmail.Text.Trim
    '            .ClienteObs = Me.txtObservaciones.Text.Trim
    '            .ClienteReferidos = Me.txtReferidos.Text.Trim
    '            .ClienteMedioComunicacionId = Me.rblMedios.SelectedItem.Value
    '            .ClienteRazonSocial = Me.txtRazonSocial.Text.Trim
    '            .ClienteRUC = Me.txtRuc.Text.Trim
    '            .ClienteCargo = Me.txtCargo.Text.Trim
    '            .ClienteTipoId = Me.ddlTipoCliente.SelectedItem.Value
    '            .ClienteComentarios = Me.txtComentariosCliente.Text.Trim
    '            .ClienteEstadoId = Convert.ToInt16(Me.ddlEstadoProspecto.SelectedItem.Value)

    '            If Session("Usuario") Is Nothing Then Throw New DataException("Sin Sesión Activa")

    '            objUsuario = CType(Session("Usuario"), BEC.SEG.clsUsuario)
    '            .AudEdic_UsuarioId = objUsuario.UsuarioId

    '            If .ClienteTipoId = Util.Enumeracion.enmTipoCliente.Cliente Then EscribirAdquisicion(Util.Enumeracion.enmTipoAccion.Update)

    '        End With

    '        intResult = objDALC.Escribir(objBEC)

    '        If intResult = Util.Enumeracion.enmResultadoOperacion.OK Then

    '            'EscribirAdquisicion()
    '            strId = objBEC.ClienteId.ToString
    '            Server.Transfer("frmClienteRegistro.aspx?Id=" & strId)

    '        Else
    '            If objBEC.ClienteId = Util.Enumeracion.enmResultadoOperacion.ERR Then
    '                Throw New DataException(Util.Constante.Msj_ExisteRegistro)
    '            Else
    '                Throw New DataException(Util.Constante.Ope_EscribirERR)
    '            End If
    '        End If
    '        'Else
    '        'Throw New DataException(UTIL.Constante.Msj_SinDatos)
    '        'End If

    '    Catch ex As Exception
    '        Me.lblMensaje.CssClass = "GNRtxtError"
    '        Me.lblMensaje.Text = ex.Message

    '    Finally
    '        objBEC = Nothing
    '        objDALC = Nothing
    '    End Try

    'End Sub

    'Private Function LeerProspecto(ByVal intClienteId As Integer) As Integer

    '    Dim objDALC As New DALC.CSR.clsProspecto
    '    Dim objBEC As BEC.CSR.clsProspecto

    '    objBEC = objDALC.Leer(intClienteId)

    '    If Not objBEC Is Nothing Then
    '        Me.lblClienteId.Text = objBEC.ClienteId
    '        Me.ddlTipoDoc.SelectedIndex = Me.ddlTipoDoc.Items.IndexOf(Me.ddlTipoDoc.Items.FindByValue(objBEC.ClienteTipoDocId))

    '        'Me.ddlEstadoProspecto.SelectedIndex = ddlEstadoProspecto.Items.IndexOf(ddlEstadoProspecto.Items.FindByValue(objBEC.ClienteEstadoId))
    '        Me.ddlTipoCliente.SelectedIndex = ddlTipoCliente.Items.IndexOf(ddlTipoCliente.Items.FindByValue(objBEC.ClienteTipo))
    '        'Me.lblTipoCliente.Text = Me.ddlTipoCliente.SelectedItem.Text
    '        Me.lblTipoCliente.Text = objBEC.ClienteEstado
    '        Me.lblAudCreacion.Text = objBEC.AudCreac_UsuarioNombre & " - " & objBEC.AudCreac_Fecha
    '        Me.lblAudActualizacion.Text = objBEC.AudEdic_UsuarioNombre & " - " & objBEC.AudEdic_Fecha

    '        lblClienteCodigo.Visible = True
    '        lblClienteCodigo.Text = objBEC.ClienteCodigo.Trim

    '        Me.txtNroDoc.Text = objBEC.ClienteNumDoc
    '        Me.ddlNacionalidad.SelectedIndex = Me.ddlNacionalidad.Items.IndexOf(Me.ddlNacionalidad.Items.FindByValue(objBEC.ClienteNacionalidadId))
    '        Me.txtNombres.Text = objBEC.ClienteNom
    '        Me.txtApePat.Text = objBEC.ClienteApePat
    '        Me.txtApeMat.Text = objBEC.ClienteApeMat

    '        If objBEC.ClienteFecNac <> "" Then Me.txtFecNac.Text = objBEC.ClienteFecNac

    '        Me.ddlSexo.SelectedIndex = Me.ddlSexo.Items.IndexOf(Me.ddlSexo.Items.FindByValue(objBEC.ClienteSexoId))
    '        Me.ddlEstCivil.SelectedIndex = Me.ddlEstCivil.Items.IndexOf(Me.ddlEstCivil.Items.FindByValue(objBEC.ClienteEstCivilId))
    '        Me.txtDireccion.Text = objBEC.ClienteDir
    '        Me.txtEmail.Text = objBEC.ClienteEmail
    '        Me.txtTelfCasa.Text = objBEC.ClienteTelfCasa
    '        Me.txtTelfTrabajo.Text = objBEC.ClienteTelfTrab
    '        Me.txtTelfCelular.Text = objBEC.ClienteTelfMovil
    '        Me.txtObservaciones.Text = objBEC.ClienteObs
    '        Me.txtReferidos.Text = objBEC.ClienteReferidos
    '        Me.rblMedios.SelectedIndex = Me.rblMedios.Items.IndexOf(Me.rblMedios.Items.FindByValue(objBEC.ClienteMedioComunicacionId))
    '        If Me.rblMedios.SelectedIndex = Util.Enumeracion.enmResultadoOperacion.ERR Then Me.rblMedios.SelectedIndex = Me.rblMedios.Items.IndexOf(Me.rblMedios.Items.FindByValue(5)) ' Otros

    '        Me.txtRazonSocial.Text = objBEC.ClienteRazonSocial
    '        Me.txtRuc.Text = objBEC.ClienteRUC
    '        Me.txtCargo.Text = objBEC.ClienteCargo
    '        Me.txtComentariosCliente.Text = objBEC.ClienteComentarios

    '        Dim strRutaDestino As String = ".." & ConfigurationSettings.AppSettings.Get("RutaFotos")
    '        Me.imgFoto.ImageUrl = strRutaDestino & "\" & objBEC.ClienteId.ToString & ".jpg"

    '        Return Util.Enumeracion.enmResultadoOperacion.OK

    '    Else
    '        Return Util.Enumeracion.enmResultadoOperacion.NONE

    '    End If

    'End Function

#End Region

    Sub GuardarFoto()

        Dim strFileUpload As String = System.IO.Path.GetFileName(Me.txtFileUpload.PostedFile.FileName)
        Dim strRutaDestino As String = Server.MapPath("..") & ConfigurationSettings.AppSettings.Get("RutaFotos")
        Dim strFileTarget As String = strRutaDestino & "\" & Me.lblClienteId.Text & ".jpg"

        Try
            If txtFileUpload.PostedFile.ContentLength > 0 Then
                txtFileUpload.PostedFile.SaveAs(strFileTarget)

                Me.imgFoto.ImageUrl = Nothing
                Me.InitializeComponent()
                'Me.DataBind()

                'hdTabActivo.Value = 3

                Response.Redirect("frmClienteRegistro.aspx?Id=" & Me.lblClienteId.Text & "&Res=OK")


            End If

        Catch ex As Exception
            Me.lblMensaje.CssClass = "GNRtxtError"
            Me.lblMensaje.Text = ex.Message
        End Try

    End Sub

    Private Sub btnGrabarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarFoto.Click
        GuardarFoto()
    End Sub

    Protected Sub ddlFormaPago_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlFormaPago.SelectedIndexChanged
        If Me.ddlFormaPago.SelectedItem.Value = 5 Then 'Pago A 2 Cuotas
            'Me.tdFechaVenc.Visible = True
        Else
            'Me.tdFechaVenc.Visible = False
        End If
    End Sub

End Class
