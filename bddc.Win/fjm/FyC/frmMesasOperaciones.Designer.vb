<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMesasOperaciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BJ 01")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BJ 02")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BJ 03")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BJ 04")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pit 1", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MDPB 01")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MDPB 02")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MDPB 03")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MDPB 04")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pit 2", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RL 08")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RL 09")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BJ 10")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BJ 11")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pit 3", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pit 4")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMesasOperaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tvMesas = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiApertura = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiRelleno = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiCredito = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiCierre = New System.Windows.Forms.ToolStripMenuItem
        Me.imglstMesas = New System.Windows.Forms.ImageList(Me.components)
        Me.gbDatosMesa = New System.Windows.Forms.GroupBox
        Me.lblTipoMonedaId = New System.Windows.Forms.Label
        Me.txtFechaProceso = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboTipoJuego = New System.Windows.Forms.ComboBox
        Me.lblOperacionMesaId = New System.Windows.Forms.Label
        Me.cboTipoOperacion = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.gbTipoMoneda = New System.Windows.Forms.GroupBox
        Me.rbMoneda2 = New System.Windows.Forms.RadioButton
        Me.rbMoneda1 = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNumMesa = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbFlotaFichas = New System.Windows.Forms.GroupBox
        Me.UcFlotaFichas1 = New bddc.Win.ucFlotaFichas
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.gbComentarios = New System.Windows.Forms.GroupBox
        Me.txtComentarios = New System.Windows.Forms.TextBox
        Me.gbOperaciones = New System.Windows.Forms.GroupBox
        Me.dgvSeguimiento = New System.Windows.Forms.DataGridView
        Me.OperacionMesaId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Denominaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaProceso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoOperacionId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuegoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroMesa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PersonalAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FlotaFichas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudCreac_UsuarioId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudEdic_UsuarioId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudCreac_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudCreac_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudEdic_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudEdic_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Imprimir = New System.Windows.Forms.DataGridViewImageColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rptViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.objPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.txtAudUpdFecha = New System.Windows.Forms.TextBox
        Me.txtAudInsFecha = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtAudUpdUsr = New System.Windows.Forms.TextBox
        Me.txtAudInsUsr = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbDatosMesa.SuspendLayout()
        Me.gbTipoMoneda.SuspendLayout()
        Me.gbFlotaFichas.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbComentarios.SuspendLayout()
        Me.gbOperaciones.SuspendLayout()
        CType(Me.dgvSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvMesas
        '
        Me.tvMesas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvMesas.ImageIndex = 0
        Me.tvMesas.ImageList = Me.imglstMesas
        Me.tvMesas.Location = New System.Drawing.Point(6, 19)
        Me.tvMesas.Name = "tvMesas"
        TreeNode1.Name = "Node4"
        TreeNode1.Text = "BJ 01"
        TreeNode2.Name = "Node5"
        TreeNode2.Text = "BJ 02"
        TreeNode3.Name = "Node6"
        TreeNode3.Text = "BJ 03"
        TreeNode4.Name = "Node7"
        TreeNode4.Text = "BJ 04"
        TreeNode5.Name = "Pit1"
        TreeNode5.Text = "Pit 1"
        TreeNode6.Name = "Node8"
        TreeNode6.Text = "MDPB 01"
        TreeNode7.Name = "Node9"
        TreeNode7.Text = "MDPB 02"
        TreeNode8.Name = "Node10"
        TreeNode8.Text = "MDPB 03"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "MDPB 04"
        TreeNode10.Name = "Pit2"
        TreeNode10.Text = "Pit 2"
        TreeNode11.Name = "Node12"
        TreeNode11.Text = "RL 08"
        TreeNode12.Name = "Node13"
        TreeNode12.Text = "RL 09"
        TreeNode13.Name = "Node14"
        TreeNode13.Text = "BJ 10"
        TreeNode14.Name = "Node15"
        TreeNode14.Text = "BJ 11"
        TreeNode15.Name = "Pit3"
        TreeNode15.Text = "Pit 3"
        TreeNode16.Name = "Pit4"
        TreeNode16.Text = "Pit 4"
        Me.tvMesas.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode15, TreeNode16})
        Me.tvMesas.SelectedImageIndex = 0
        Me.tvMesas.ShowRootLines = False
        Me.tvMesas.Size = New System.Drawing.Size(125, 552)
        Me.tvMesas.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiApertura, Me.tsmiRelleno, Me.tsmiCredito, Me.tsmiCierre})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 92)
        '
        'tsmiApertura
        '
        Me.tsmiApertura.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.tsmiApertura.Name = "tsmiApertura"
        Me.tsmiApertura.Size = New System.Drawing.Size(120, 22)
        Me.tsmiApertura.Text = "Apertura"
        '
        'tsmiRelleno
        '
        Me.tsmiRelleno.Image = Global.bddc.Win.My.Resources.Resources.btnFJMRelleno
        Me.tsmiRelleno.Name = "tsmiRelleno"
        Me.tsmiRelleno.Size = New System.Drawing.Size(120, 22)
        Me.tsmiRelleno.Text = "Relleno"
        '
        'tsmiCredito
        '
        Me.tsmiCredito.Image = Global.bddc.Win.My.Resources.Resources.btnFJMCredito
        Me.tsmiCredito.Name = "tsmiCredito"
        Me.tsmiCredito.Size = New System.Drawing.Size(120, 22)
        Me.tsmiCredito.Text = "Crédito"
        '
        'tsmiCierre
        '
        Me.tsmiCierre.Image = Global.bddc.Win.My.Resources.Resources.btnFJMCierre
        Me.tsmiCierre.Name = "tsmiCierre"
        Me.tsmiCierre.Size = New System.Drawing.Size(120, 22)
        Me.tsmiCierre.Text = "Cierre"
        '
        'imglstMesas
        '
        Me.imglstMesas.ImageStream = CType(resources.GetObject("imglstMesas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstMesas.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstMesas.Images.SetKeyName(0, "btnPit.gif")
        Me.imglstMesas.Images.SetKeyName(1, "btnNo.gif")
        Me.imglstMesas.Images.SetKeyName(2, "btnOk.gif")
        Me.imglstMesas.Images.SetKeyName(3, "btnVer.gif")
        Me.imglstMesas.Images.SetKeyName(4, "btnEditar.gif")
        Me.imglstMesas.Images.SetKeyName(5, "btnFJMCierre.png")
        Me.imglstMesas.Images.SetKeyName(6, "btnFJMRelleno.gif")
        Me.imglstMesas.Images.SetKeyName(7, "btnFJMCredito.gif")
        '
        'gbDatosMesa
        '
        Me.gbDatosMesa.Controls.Add(Me.lblTipoMonedaId)
        Me.gbDatosMesa.Controls.Add(Me.txtFechaProceso)
        Me.gbDatosMesa.Controls.Add(Me.Label10)
        Me.gbDatosMesa.Controls.Add(Me.cboTipoJuego)
        Me.gbDatosMesa.Controls.Add(Me.lblOperacionMesaId)
        Me.gbDatosMesa.Controls.Add(Me.cboTipoOperacion)
        Me.gbDatosMesa.Controls.Add(Me.Label9)
        Me.gbDatosMesa.Controls.Add(Me.gbTipoMoneda)
        Me.gbDatosMesa.Controls.Add(Me.Label3)
        Me.gbDatosMesa.Controls.Add(Me.txtNumMesa)
        Me.gbDatosMesa.Controls.Add(Me.Label2)
        Me.gbDatosMesa.Enabled = False
        Me.gbDatosMesa.Location = New System.Drawing.Point(154, 35)
        Me.gbDatosMesa.Name = "gbDatosMesa"
        Me.gbDatosMesa.Size = New System.Drawing.Size(266, 124)
        Me.gbDatosMesa.TabIndex = 2
        Me.gbDatosMesa.TabStop = False
        Me.gbDatosMesa.Text = "Datos de Mesa"
        '
        'lblTipoMonedaId
        '
        Me.lblTipoMonedaId.AutoSize = True
        Me.lblTipoMonedaId.Location = New System.Drawing.Point(240, 97)
        Me.lblTipoMonedaId.Name = "lblTipoMonedaId"
        Me.lblTipoMonedaId.Size = New System.Drawing.Size(16, 13)
        Me.lblTipoMonedaId.TabIndex = 0
        Me.lblTipoMonedaId.Text = "Id"
        Me.lblTipoMonedaId.Visible = False
        '
        'txtFechaProceso
        '
        Me.txtFechaProceso.Enabled = False
        Me.txtFechaProceso.Location = New System.Drawing.Point(72, 17)
        Me.txtFechaProceso.Name = "txtFechaProceso"
        Me.txtFechaProceso.Size = New System.Drawing.Size(64, 20)
        Me.txtFechaProceso.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Proceso"
        '
        'cboTipoJuego
        '
        Me.cboTipoJuego.Enabled = False
        Me.cboTipoJuego.FormattingEnabled = True
        Me.cboTipoJuego.Location = New System.Drawing.Point(72, 63)
        Me.cboTipoJuego.Name = "cboTipoJuego"
        Me.cboTipoJuego.Size = New System.Drawing.Size(65, 21)
        Me.cboTipoJuego.TabIndex = 3
        '
        'lblOperacionMesaId
        '
        Me.lblOperacionMesaId.AutoSize = True
        Me.lblOperacionMesaId.Location = New System.Drawing.Point(240, 20)
        Me.lblOperacionMesaId.Name = "lblOperacionMesaId"
        Me.lblOperacionMesaId.Size = New System.Drawing.Size(16, 13)
        Me.lblOperacionMesaId.TabIndex = 0
        Me.lblOperacionMesaId.Text = "Id"
        Me.lblOperacionMesaId.Visible = False
        '
        'cboTipoOperacion
        '
        Me.cboTipoOperacion.Enabled = False
        Me.cboTipoOperacion.FormattingEnabled = True
        Me.cboTipoOperacion.Location = New System.Drawing.Point(72, 40)
        Me.cboTipoOperacion.Name = "cboTipoOperacion"
        Me.cboTipoOperacion.Size = New System.Drawing.Size(117, 21)
        Me.cboTipoOperacion.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Operación"
        '
        'gbTipoMoneda
        '
        Me.gbTipoMoneda.Controls.Add(Me.rbMoneda2)
        Me.gbTipoMoneda.Controls.Add(Me.rbMoneda1)
        Me.gbTipoMoneda.Enabled = False
        Me.gbTipoMoneda.Location = New System.Drawing.Point(71, 86)
        Me.gbTipoMoneda.Name = "gbTipoMoneda"
        Me.gbTipoMoneda.Size = New System.Drawing.Size(116, 31)
        Me.gbTipoMoneda.TabIndex = 4
        Me.gbTipoMoneda.TabStop = False
        '
        'rbMoneda2
        '
        Me.rbMoneda2.AutoSize = True
        Me.rbMoneda2.Location = New System.Drawing.Point(62, 9)
        Me.rbMoneda2.Name = "rbMoneda2"
        Me.rbMoneda2.Size = New System.Drawing.Size(46, 17)
        Me.rbMoneda2.TabIndex = 1
        Me.rbMoneda2.TabStop = True
        Me.rbMoneda2.Text = "US$"
        Me.rbMoneda2.UseVisualStyleBackColor = True
        '
        'rbMoneda1
        '
        Me.rbMoneda1.AutoSize = True
        Me.rbMoneda1.Location = New System.Drawing.Point(11, 9)
        Me.rbMoneda1.Name = "rbMoneda1"
        Me.rbMoneda1.Size = New System.Drawing.Size(40, 17)
        Me.rbMoneda1.TabIndex = 0
        Me.rbMoneda1.TabStop = True
        Me.rbMoneda1.Text = "S/."
        Me.rbMoneda1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Moneda"
        '
        'txtNumMesa
        '
        Me.txtNumMesa.Location = New System.Drawing.Point(141, 63)
        Me.txtNumMesa.Name = "txtNumMesa"
        Me.txtNumMesa.ReadOnly = True
        Me.txtNumMesa.Size = New System.Drawing.Size(46, 20)
        Me.txtNumMesa.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Juego"
        '
        'gbFlotaFichas
        '
        Me.gbFlotaFichas.Controls.Add(Me.UcFlotaFichas1)
        Me.gbFlotaFichas.Location = New System.Drawing.Point(426, 35)
        Me.gbFlotaFichas.Name = "gbFlotaFichas"
        Me.gbFlotaFichas.Size = New System.Drawing.Size(279, 325)
        Me.gbFlotaFichas.TabIndex = 5
        Me.gbFlotaFichas.TabStop = False
        Me.gbFlotaFichas.Text = "Flota de Fichas"
        '
        'UcFlotaFichas1
        '
        Me.UcFlotaFichas1.Location = New System.Drawing.Point(7, 20)
        Me.UcFlotaFichas1.Name = "UcFlotaFichas1"
        Me.UcFlotaFichas1.Size = New System.Drawing.Size(265, 299)
        Me.UcFlotaFichas1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMensaje})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 620)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1036, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssMensaje
        '
        Me.tssMensaje.Name = "tssMensaje"
        Me.tssMensaje.Size = New System.Drawing.Size(47, 17)
        Me.tssMensaje.Text = "Mensaje"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbEliminar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1036, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Enabled = False
        Me.tsbBuscar.Image = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(70, 28)
        Me.tsbBuscar.Text = "Buscar"
        Me.tsbBuscar.Visible = False
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Enabled = False
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(70, 28)
        Me.tsbNuevo.Text = "Nuevo"
        Me.tsbNuevo.Visible = False
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Enabled = False
        Me.tsbAgregar.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(77, 28)
        Me.tsbAgregar.Text = "Agregar"
        Me.tsbAgregar.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(77, 28)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Enabled = False
        Me.tsbImprimir.Image = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(81, 28)
        Me.tsbImprimir.Text = "Imprimir"
        Me.tsbImprimir.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(57, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'gbComentarios
        '
        Me.gbComentarios.Controls.Add(Me.txtComentarios)
        Me.gbComentarios.Location = New System.Drawing.Point(154, 165)
        Me.gbComentarios.Name = "gbComentarios"
        Me.gbComentarios.Size = New System.Drawing.Size(266, 61)
        Me.gbComentarios.TabIndex = 4
        Me.gbComentarios.TabStop = False
        Me.gbComentarios.Text = "Comentarios"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(9, 19)
        Me.txtComentarios.MaxLength = 100
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(250, 36)
        Me.txtComentarios.TabIndex = 0
        '
        'gbOperaciones
        '
        Me.gbOperaciones.Controls.Add(Me.dgvSeguimiento)
        Me.gbOperaciones.Location = New System.Drawing.Point(155, 366)
        Me.gbOperaciones.Name = "gbOperaciones"
        Me.gbOperaciones.Size = New System.Drawing.Size(550, 249)
        Me.gbOperaciones.TabIndex = 6
        Me.gbOperaciones.TabStop = False
        Me.gbOperaciones.Text = "Seguimiento"
        '
        'dgvSeguimiento
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSeguimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionMesaId, Me.Denominaciones, Me.FechaProceso, Me.TipoOperacionId, Me.TipoOperacion, Me.TipoJuego, Me.TipoJuegoId, Me.NroMesa, Me.MontoTotal, Me.PersonalAsignado, Me.FlotaFichas, Me.Comentarios, Me.AudCreac_UsuarioId, Me.AudEdic_UsuarioId, Me.EstadoId, Me.AudCreac_Usuario, Me.AudCreac_Fecha, Me.AudEdic_Usuario, Me.AudEdic_Fecha, Me.Imprimir})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeguimiento.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSeguimiento.Location = New System.Drawing.Point(9, 19)
        Me.dgvSeguimiento.Name = "dgvSeguimiento"
        Me.dgvSeguimiento.RowHeadersVisible = False
        Me.dgvSeguimiento.Size = New System.Drawing.Size(534, 221)
        Me.dgvSeguimiento.TabIndex = 0
        '
        'OperacionMesaId
        '
        Me.OperacionMesaId.DataPropertyName = "OperacionMesaId"
        Me.OperacionMesaId.HeaderText = "OperacionMesaId"
        Me.OperacionMesaId.Name = "OperacionMesaId"
        Me.OperacionMesaId.Visible = False
        '
        'Denominaciones
        '
        Me.Denominaciones.DataPropertyName = "Denominaciones"
        Me.Denominaciones.HeaderText = "Denominaciones"
        Me.Denominaciones.Name = "Denominaciones"
        Me.Denominaciones.Visible = False
        '
        'FechaProceso
        '
        Me.FechaProceso.DataPropertyName = "FechaProceso"
        Me.FechaProceso.HeaderText = "Fecha"
        Me.FechaProceso.Name = "FechaProceso"
        Me.FechaProceso.ReadOnly = True
        Me.FechaProceso.Width = 70
        '
        'TipoOperacionId
        '
        Me.TipoOperacionId.DataPropertyName = "TipoOperacionId"
        Me.TipoOperacionId.HeaderText = "TipoOperacionId"
        Me.TipoOperacionId.Name = "TipoOperacionId"
        Me.TipoOperacionId.Visible = False
        '
        'TipoOperacion
        '
        Me.TipoOperacion.DataPropertyName = "TipoOperacion"
        Me.TipoOperacion.HeaderText = "Operación"
        Me.TipoOperacion.Name = "TipoOperacion"
        Me.TipoOperacion.ReadOnly = True
        Me.TipoOperacion.Width = 70
        '
        'TipoJuego
        '
        Me.TipoJuego.DataPropertyName = "TipoJuego"
        Me.TipoJuego.HeaderText = "Juego"
        Me.TipoJuego.Name = "TipoJuego"
        Me.TipoJuego.ReadOnly = True
        Me.TipoJuego.Width = 30
        '
        'TipoJuegoId
        '
        Me.TipoJuegoId.DataPropertyName = "TipoJuegoId"
        Me.TipoJuegoId.HeaderText = "TipoJuegoId"
        Me.TipoJuegoId.Name = "TipoJuegoId"
        Me.TipoJuegoId.Visible = False
        '
        'NroMesa
        '
        Me.NroMesa.DataPropertyName = "NroMesa"
        Me.NroMesa.HeaderText = "Mesa"
        Me.NroMesa.Name = "NroMesa"
        Me.NroMesa.ReadOnly = True
        Me.NroMesa.Width = 30
        '
        'MontoTotal
        '
        Me.MontoTotal.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.MontoTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoTotal.HeaderText = "Monto"
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.ReadOnly = True
        Me.MontoTotal.Width = 70
        '
        'PersonalAsignado
        '
        Me.PersonalAsignado.DataPropertyName = "PersonalAsignado"
        Me.PersonalAsignado.HeaderText = "PersonalAsignado"
        Me.PersonalAsignado.Name = "PersonalAsignado"
        Me.PersonalAsignado.Visible = False
        '
        'FlotaFichas
        '
        Me.FlotaFichas.DataPropertyName = "FlotaFichas"
        Me.FlotaFichas.HeaderText = "FlotaFichas"
        Me.FlotaFichas.Name = "FlotaFichas"
        Me.FlotaFichas.ReadOnly = True
        Me.FlotaFichas.Visible = False
        '
        'Comentarios
        '
        Me.Comentarios.DataPropertyName = "Comentarios"
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Visible = False
        '
        'AudCreac_UsuarioId
        '
        Me.AudCreac_UsuarioId.DataPropertyName = "AudCreac_UsuarioId"
        Me.AudCreac_UsuarioId.HeaderText = "AudCreac_UsuarioId"
        Me.AudCreac_UsuarioId.Name = "AudCreac_UsuarioId"
        Me.AudCreac_UsuarioId.Visible = False
        '
        'AudEdic_UsuarioId
        '
        Me.AudEdic_UsuarioId.DataPropertyName = "AudEdic_UsuarioId"
        Me.AudEdic_UsuarioId.HeaderText = "AudEdic_UsuarioId"
        Me.AudEdic_UsuarioId.Name = "AudEdic_UsuarioId"
        Me.AudEdic_UsuarioId.Visible = False
        '
        'EstadoId
        '
        Me.EstadoId.DataPropertyName = "EstadoId"
        Me.EstadoId.HeaderText = "EstadoId"
        Me.EstadoId.Name = "EstadoId"
        Me.EstadoId.Visible = False
        '
        'AudCreac_Usuario
        '
        Me.AudCreac_Usuario.DataPropertyName = "AudCreac_Usuario"
        Me.AudCreac_Usuario.HeaderText = "Usuario"
        Me.AudCreac_Usuario.Name = "AudCreac_Usuario"
        Me.AudCreac_Usuario.ReadOnly = True
        '
        'AudCreac_Fecha
        '
        Me.AudCreac_Fecha.DataPropertyName = "AudCreac_Fecha"
        Me.AudCreac_Fecha.HeaderText = "Fecha"
        Me.AudCreac_Fecha.Name = "AudCreac_Fecha"
        Me.AudCreac_Fecha.ReadOnly = True
        Me.AudCreac_Fecha.Width = 120
        '
        'AudEdic_Usuario
        '
        Me.AudEdic_Usuario.DataPropertyName = "AudEdic_Usuario"
        Me.AudEdic_Usuario.HeaderText = "AudEdic_Usuario"
        Me.AudEdic_Usuario.Name = "AudEdic_Usuario"
        Me.AudEdic_Usuario.Visible = False
        Me.AudEdic_Usuario.Width = 60
        '
        'AudEdic_Fecha
        '
        Me.AudEdic_Fecha.DataPropertyName = "AudEdic_Fecha"
        Me.AudEdic_Fecha.HeaderText = "AudEdic_Fecha"
        Me.AudEdic_Fecha.Name = "AudEdic_Fecha"
        Me.AudEdic_Fecha.Visible = False
        Me.AudEdic_Fecha.Width = 60
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = ""
        Me.Imprimir.Image = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.Imprimir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imprimir.ToolTipText = "Imprimir"
        Me.Imprimir.Width = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tvMesas)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 580)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mesas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rptViewer)
        Me.GroupBox1.Location = New System.Drawing.Point(711, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 580)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formato para Imprimir"
        '
        'rptViewer
        '
        Me.rptViewer.IsDocumentMapWidthFixed = True
        Me.rptViewer.LocalReport.ReportEmbeddedResource = "bddc.Win.rptOperacionMesa.rdlc"
        Me.rptViewer.Location = New System.Drawing.Point(6, 17)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ShowBackButton = False
        Me.rptViewer.ShowContextMenu = False
        Me.rptViewer.ShowCredentialPrompts = False
        Me.rptViewer.ShowDocumentMapButton = False
        Me.rptViewer.ShowExportButton = False
        Me.rptViewer.ShowFindControls = False
        Me.rptViewer.ShowPageNavigationControls = False
        Me.rptViewer.ShowParameterPrompts = False
        Me.rptViewer.ShowProgress = False
        Me.rptViewer.ShowPromptAreaButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.ShowStopButton = False
        Me.rptViewer.ShowToolBar = False
        Me.rptViewer.ShowZoomControl = False
        Me.rptViewer.Size = New System.Drawing.Size(307, 554)
        Me.rptViewer.TabIndex = 0
        Me.rptViewer.ZoomPercent = 90
        '
        'Timer1
        '
        Me.Timer1.Interval = 600000
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Imprimir"
        Me.DataGridViewImageColumn1.Width = 30
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtAudUpdFecha)
        Me.GroupBox8.Controls.Add(Me.txtAudInsFecha)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Controls.Add(Me.txtAudUpdUsr)
        Me.GroupBox8.Controls.Add(Me.txtAudInsUsr)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Location = New System.Drawing.Point(154, 232)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(266, 128)
        Me.GroupBox8.TabIndex = 8
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos de Auditoría"
        '
        'txtAudUpdFecha
        '
        Me.txtAudUpdFecha.Location = New System.Drawing.Point(82, 94)
        Me.txtAudUpdFecha.MaxLength = 10
        Me.txtAudUpdFecha.Name = "txtAudUpdFecha"
        Me.txtAudUpdFecha.ReadOnly = True
        Me.txtAudUpdFecha.Size = New System.Drawing.Size(148, 20)
        Me.txtAudUpdFecha.TabIndex = 87
        '
        'txtAudInsFecha
        '
        Me.txtAudInsFecha.Location = New System.Drawing.Point(82, 42)
        Me.txtAudInsFecha.MaxLength = 10
        Me.txtAudInsFecha.Name = "txtAudInsFecha"
        Me.txtAudInsFecha.ReadOnly = True
        Me.txtAudInsFecha.Size = New System.Drawing.Size(148, 20)
        Me.txtAudInsFecha.TabIndex = 86
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(39, 97)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 13)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Fecha"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(39, 45)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Fecha"
        '
        'txtAudUpdUsr
        '
        Me.txtAudUpdUsr.Location = New System.Drawing.Point(82, 68)
        Me.txtAudUpdUsr.Name = "txtAudUpdUsr"
        Me.txtAudUpdUsr.ReadOnly = True
        Me.txtAudUpdUsr.Size = New System.Drawing.Size(148, 20)
        Me.txtAudUpdUsr.TabIndex = 3
        '
        'txtAudInsUsr
        '
        Me.txtAudInsUsr.Location = New System.Drawing.Point(82, 19)
        Me.txtAudInsUsr.Name = "txtAudInsUsr"
        Me.txtAudInsUsr.ReadOnly = True
        Me.txtAudInsUsr.Size = New System.Drawing.Size(148, 20)
        Me.txtAudInsUsr.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Ult. Edición"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Creación"
        '
        'frmMesasOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 642)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbComentarios)
        Me.Controls.Add(Me.gbDatosMesa)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.gbFlotaFichas)
        Me.Controls.Add(Me.gbOperaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMesasOperaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones de Mesas - Fills & Credits"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbDatosMesa.ResumeLayout(False)
        Me.gbDatosMesa.PerformLayout()
        Me.gbTipoMoneda.ResumeLayout(False)
        Me.gbTipoMoneda.PerformLayout()
        Me.gbFlotaFichas.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbComentarios.ResumeLayout(False)
        Me.gbComentarios.PerformLayout()
        Me.gbOperaciones.ResumeLayout(False)
        CType(Me.dgvSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvMesas As System.Windows.Forms.TreeView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiApertura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRelleno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCredito As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCierre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imglstMesas As System.Windows.Forms.ImageList
    Friend WithEvents gbDatosMesa As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumMesa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbTipoMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents rbMoneda2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMoneda1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbFlotaFichas As System.Windows.Forms.GroupBox
    Friend WithEvents UcFlotaFichas1 As bddc.Win.ucFlotaFichas
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbComentarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblOperacionMesaId As System.Windows.Forms.Label
    Friend WithEvents cboTipoJuego As System.Windows.Forms.ComboBox
    Friend WithEvents txtFechaProceso As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbOperaciones As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSeguimiento As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OperacionMesaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaProceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacionId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuegoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroMesa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonalAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlotaFichas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudCreac_UsuarioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudEdic_UsuarioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudCreac_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudCreac_Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudEdic_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudEdic_Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imprimir As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblTipoMonedaId As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents objPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAudUpdFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtAudInsFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAudUpdUsr As System.Windows.Forms.TextBox
    Friend WithEvents txtAudInsUsr As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
