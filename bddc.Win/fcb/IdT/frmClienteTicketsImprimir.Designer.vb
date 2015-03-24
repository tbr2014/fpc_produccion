<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteTicketsImprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteTicketsImprimir))
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNumDoc = New System.Windows.Forms.TextBox
        Me.lblClienteId = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTicketsImprimir = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumInicial = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTicketsTotal = New System.Windows.Forms.TextBox
        Me.gbPreImpresion = New System.Windows.Forms.GroupBox
        Me.txtGUID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNumTarjeta = New System.Windows.Forms.TextBox
        Me.objPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.objPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.rptViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.gbCorreccion = New System.Windows.Forms.GroupBox
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTicketsHabilitar = New System.Windows.Forms.NumericUpDown
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        CType(Me.txtTicketsImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPreImpresion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCorreccion.SuspendLayout()
        CType(Me.txtTicketsHabilitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nombre"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(93, 131)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(317, 20)
        Me.txtNombreCompleto.TabIndex = 17
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(77, 49)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(272, 26)
        Me.lblTitulo.TabIndex = 20
        Me.lblTitulo.Text = "Impresión Tickets "
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "N° Documento"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(93, 105)
        Me.txtNumDoc.MaxLength = 10
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(83, 20)
        Me.txtNumDoc.TabIndex = 22
        '
        'lblClienteId
        '
        Me.lblClienteId.AutoSize = True
        Me.lblClienteId.Location = New System.Drawing.Point(182, 108)
        Me.lblClienteId.Name = "lblClienteId"
        Me.lblClienteId.Size = New System.Drawing.Size(48, 13)
        Me.lblClienteId.TabIndex = 24
        Me.lblClienteId.Text = "ClienteId"
        Me.lblClienteId.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(0, 296)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(60, 13)
        Me.lblMensaje.TabIndex = 25
        Me.lblMensaje.Text = "Mensajes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "N° Tickets"
        '
        'txtTicketsImprimir
        '
        Me.txtTicketsImprimir.Location = New System.Drawing.Point(81, 39)
        Me.txtTicketsImprimir.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtTicketsImprimir.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTicketsImprimir.Name = "txtTicketsImprimir"
        Me.txtTicketsImprimir.Size = New System.Drawing.Size(83, 20)
        Me.txtTicketsImprimir.TabIndex = 27
        Me.txtTicketsImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTicketsImprimir.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Inicia en:"
        '
        'txtNumInicial
        '
        Me.txtNumInicial.Location = New System.Drawing.Point(220, 39)
        Me.txtNumInicial.MaxLength = 10
        Me.txtNumInicial.Name = "txtNumInicial"
        Me.txtNumInicial.Size = New System.Drawing.Size(62, 20)
        Me.txtNumInicial.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Imprimir"
        '
        'txtTicketsTotal
        '
        Me.txtTicketsTotal.Location = New System.Drawing.Point(81, 13)
        Me.txtTicketsTotal.MaxLength = 10
        Me.txtTicketsTotal.Name = "txtTicketsTotal"
        Me.txtTicketsTotal.ReadOnly = True
        Me.txtTicketsTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTicketsTotal.Size = New System.Drawing.Size(83, 20)
        Me.txtTicketsTotal.TabIndex = 31
        '
        'gbPreImpresion
        '
        Me.gbPreImpresion.Controls.Add(Me.txtGUID)
        Me.gbPreImpresion.Controls.Add(Me.Label2)
        Me.gbPreImpresion.Controls.Add(Me.Label6)
        Me.gbPreImpresion.Controls.Add(Me.txtTicketsTotal)
        Me.gbPreImpresion.Controls.Add(Me.txtNumInicial)
        Me.gbPreImpresion.Controls.Add(Me.btnImprimir)
        Me.gbPreImpresion.Controls.Add(Me.Label8)
        Me.gbPreImpresion.Controls.Add(Me.Label7)
        Me.gbPreImpresion.Controls.Add(Me.txtTicketsImprimir)
        Me.gbPreImpresion.Location = New System.Drawing.Point(12, 157)
        Me.gbPreImpresion.Name = "gbPreImpresion"
        Me.gbPreImpresion.Size = New System.Drawing.Size(411, 77)
        Me.gbPreImpresion.TabIndex = 33
        Me.gbPreImpresion.TabStop = False
        '
        'txtGUID
        '
        Me.txtGUID.Location = New System.Drawing.Point(220, 13)
        Me.txtGUID.MaxLength = 10
        Me.txtGUID.Name = "txtGUID"
        Me.txtGUID.ReadOnly = True
        Me.txtGUID.Size = New System.Drawing.Size(62, 20)
        Me.txtGUID.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "ID"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImprimir.Location = New System.Drawing.Point(320, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(78, 53)
        Me.btnImprimir.TabIndex = 34
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "N° Tarjeta"
        '
        'txtNumTarjeta
        '
        Me.txtNumTarjeta.Location = New System.Drawing.Point(327, 105)
        Me.txtNumTarjeta.MaxLength = 10
        Me.txtNumTarjeta.Name = "txtNumTarjeta"
        Me.txtNumTarjeta.Size = New System.Drawing.Size(83, 20)
        Me.txtNumTarjeta.TabIndex = 37
        '
        'objPrintPreviewDialog
        '
        Me.objPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.objPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.objPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.objPrintPreviewDialog.Enabled = True
        Me.objPrintPreviewDialog.Icon = CType(resources.GetObject("objPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.objPrintPreviewDialog.Name = "objPrintPreviewDialog"
        Me.objPrintPreviewDialog.Visible = False
        '
        'rptViewer
        '
        Me.rptViewer.LocalReport.ReportEmbeddedResource = "bddc.Win.rptFCBTicket01.rdlc"
        Me.rptViewer.Location = New System.Drawing.Point(445, 49)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(343, 214)
        Me.rptViewer.TabIndex = 39
        Me.rptViewer.Visible = False
        Me.rptViewer.ZoomPercent = 90
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgImpresion
        Me.PictureBox2.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'gbCorreccion
        '
        Me.gbCorreccion.Controls.Add(Me.btnAplicar)
        Me.gbCorreccion.Controls.Add(Me.Label10)
        Me.gbCorreccion.Controls.Add(Me.txtTicketsHabilitar)
        Me.gbCorreccion.Location = New System.Drawing.Point(145, 240)
        Me.gbCorreccion.Name = "gbCorreccion"
        Me.gbCorreccion.Size = New System.Drawing.Size(278, 41)
        Me.gbCorreccion.TabIndex = 40
        Me.gbCorreccion.TabStop = False
        Me.gbCorreccion.Text = "Corrección"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(187, 10)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(78, 23)
        Me.btnAplicar.TabIndex = 37
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Habilitar"
        '
        'txtTicketsHabilitar
        '
        Me.txtTicketsHabilitar.Location = New System.Drawing.Point(81, 13)
        Me.txtTicketsHabilitar.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtTicketsHabilitar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTicketsHabilitar.Name = "txtTicketsHabilitar"
        Me.txtTicketsHabilitar.Size = New System.Drawing.Size(83, 20)
        Me.txtTicketsHabilitar.TabIndex = 35
        Me.txtTicketsHabilitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTicketsHabilitar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbEliminar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(801, 31)
        Me.ToolStrip1.TabIndex = 68
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Image = Global.bddc.Win.My.Resources.Resources.btngridBuscar
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(67, 28)
        Me.tsbBuscar.Text = "Buscar"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(66, 28)
        Me.tsbNuevo.Text = "Nuevo"
        Me.tsbNuevo.Visible = False
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Image = Global.bddc.Win.My.Resources.Resources.btnOk
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(74, 28)
        Me.tsbAgregar.Text = "Agregar"
        Me.tsbAgregar.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.bddc.Win.My.Resources.Resources.btngridGuardar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(74, 28)
        Me.tsbGuardar.Text = "Guardar"
        Me.tsbGuardar.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(71, 28)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(55, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'frmClienteTicketsImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(801, 309)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbCorreccion)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.txtNumTarjeta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gbPreImpresion)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblClienteId)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmClienteTicketsImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión Tickets "
        CType(Me.txtTicketsImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPreImpresion.ResumeLayout(False)
        Me.gbPreImpresion.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCorreccion.ResumeLayout(False)
        Me.gbCorreccion.PerformLayout()
        CType(Me.txtTicketsHabilitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblClienteId As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTicketsImprimir As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTicketsTotal As System.Windows.Forms.TextBox
    Friend WithEvents gbPreImpresion As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents objPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents objPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtGUID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbCorreccion As System.Windows.Forms.GroupBox
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTicketsHabilitar As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
End Class
