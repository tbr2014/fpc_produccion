<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeg_Config_Mesas
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.dgvConfigMesas = New System.Windows.Forms.DataGridView
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbxMoneda = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNroMesa = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbxTipoJuego = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbxPit = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MesaId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuegoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PitId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoJuego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroMesa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonedaId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblMesaId = New System.Windows.Forms.Label
        Me.txtMesaId = New System.Windows.Forms.TextBox
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConfigMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbEliminar, Me.tsbAgregar, Me.tsbGuardar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(518, 31)
        Me.ToolStrip1.TabIndex = 77
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
        Me.tsbNuevo.Image = Global.bddc.Win.My.Resources.Resources.btngridNuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(70, 28)
        Me.tsbNuevo.Text = "Nuevo"
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
        'tsbEliminar
        '
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(57, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 28)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Config. de Mesas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgSistema
        Me.PictureBox2.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'dgvConfigMesas
        '
        Me.dgvConfigMesas.AllowUserToDeleteRows = False
        Me.dgvConfigMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConfigMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConfigMesas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MesaId, Me.TipoJuegoId, Me.EstadoId, Me.PitId, Me.TipoJuego, Me.NroMesa, Me.MonedaId})
        Me.dgvConfigMesas.Location = New System.Drawing.Point(12, 215)
        Me.dgvConfigMesas.Name = "dgvConfigMesas"
        Me.dgvConfigMesas.ReadOnly = True
        Me.dgvConfigMesas.Size = New System.Drawing.Size(494, 259)
        Me.dgvConfigMesas.TabIndex = 80
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(12, 483)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 81
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMesaId)
        Me.GroupBox1.Controls.Add(Me.lblMesaId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxMoneda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNroMesa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxTipoJuego)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxPit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 89)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Mesa"
        '
        'cbxMoneda
        '
        Me.cbxMoneda.FormattingEnabled = True
        Me.cbxMoneda.Location = New System.Drawing.Point(261, 52)
        Me.cbxMoneda.Name = "cbxMoneda"
        Me.cbxMoneda.Size = New System.Drawing.Size(86, 21)
        Me.cbxMoneda.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Moneda"
        '
        'txtNroMesa
        '
        Me.txtNroMesa.Location = New System.Drawing.Point(261, 20)
        Me.txtNroMesa.Name = "txtNroMesa"
        Me.txtNroMesa.Size = New System.Drawing.Size(86, 20)
        Me.txtNroMesa.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nro Mesa"
        '
        'cbxTipoJuego
        '
        Me.cbxTipoJuego.FormattingEnabled = True
        Me.cbxTipoJuego.Location = New System.Drawing.Point(68, 52)
        Me.cbxTipoJuego.Name = "cbxTipoJuego"
        Me.cbxTipoJuego.Size = New System.Drawing.Size(119, 21)
        Me.cbxTipoJuego.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Juego"
        '
        'cbxPit
        '
        Me.cbxPit.FormattingEnabled = True
        Me.cbxPit.Location = New System.Drawing.Point(68, 20)
        Me.cbxPit.Name = "cbxPit"
        Me.cbxPit.Size = New System.Drawing.Size(119, 21)
        Me.cbxPit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pit"
        '
        'MesaId
        '
        Me.MesaId.DataPropertyName = "MesaId"
        Me.MesaId.HeaderText = "Mesa Id"
        Me.MesaId.Name = "MesaId"
        Me.MesaId.ReadOnly = True
        '
        'TipoJuegoId
        '
        Me.TipoJuegoId.DataPropertyName = "TipoJuegoId"
        Me.TipoJuegoId.HeaderText = "TipoJuegoId"
        Me.TipoJuegoId.Name = "TipoJuegoId"
        Me.TipoJuegoId.ReadOnly = True
        Me.TipoJuegoId.Visible = False
        '
        'EstadoId
        '
        Me.EstadoId.DataPropertyName = "EstadoId"
        Me.EstadoId.HeaderText = "EstadoId"
        Me.EstadoId.Name = "EstadoId"
        Me.EstadoId.ReadOnly = True
        Me.EstadoId.Visible = False
        '
        'PitId
        '
        Me.PitId.DataPropertyName = "PitId"
        Me.PitId.HeaderText = "Pit Id"
        Me.PitId.Name = "PitId"
        Me.PitId.ReadOnly = True
        '
        'TipoJuego
        '
        Me.TipoJuego.DataPropertyName = "TipoJuego"
        Me.TipoJuego.HeaderText = "Tipo Juego"
        Me.TipoJuego.Name = "TipoJuego"
        Me.TipoJuego.ReadOnly = True
        '
        'NroMesa
        '
        Me.NroMesa.DataPropertyName = "NroMesa"
        Me.NroMesa.HeaderText = "Nro Mesa"
        Me.NroMesa.Name = "NroMesa"
        Me.NroMesa.ReadOnly = True
        '
        'MonedaId
        '
        Me.MonedaId.DataPropertyName = "MonedaId"
        Me.MonedaId.HeaderText = "Moneda Id"
        Me.MonedaId.Name = "MonedaId"
        Me.MonedaId.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(373, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Mesa Id"
        '
        'lblMesaId
        '
        Me.lblMesaId.AutoSize = True
        Me.lblMesaId.Location = New System.Drawing.Point(434, 20)
        Me.lblMesaId.Name = "lblMesaId"
        Me.lblMesaId.Size = New System.Drawing.Size(0, 13)
        Me.lblMesaId.TabIndex = 9
        '
        'txtMesaId
        '
        Me.txtMesaId.Enabled = False
        Me.txtMesaId.Location = New System.Drawing.Point(425, 20)
        Me.txtMesaId.Name = "txtMesaId"
        Me.txtMesaId.Size = New System.Drawing.Size(51, 20)
        Me.txtMesaId.TabIndex = 10
        '
        'frmSeg_Config_Mesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.dgvConfigMesas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSeg_Config_Mesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion de Mesas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConfigMesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvConfigMesas As System.Windows.Forms.DataGridView
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNroMesa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoJuego As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxPit As System.Windows.Forms.ComboBox
    Friend WithEvents MesaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuegoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PitId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoJuego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroMesa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMesaId As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMesaId As System.Windows.Forms.TextBox
End Class
