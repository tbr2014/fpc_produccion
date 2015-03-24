<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSis_Parametros
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.dgvParametros = New System.Windows.Forms.DataGridView
        Me.GrupoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ParametroId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Siglas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboGrupo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtParametro = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSiglas = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblParametroId = New System.Windows.Forms.Label
        Me.cboEstado = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnConfigMesas = New System.Windows.Forms.Button
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Parámetros del Sistema"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(12, 464)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(74, 13)
        Me.lblMensaje.TabIndex = 64
        Me.lblMensaje.Text = "<Mensajes>"
        '
        'dgvParametros
        '
        Me.dgvParametros.AllowUserToDeleteRows = False
        Me.dgvParametros.AllowUserToResizeColumns = False
        Me.dgvParametros.AllowUserToResizeRows = False
        Me.dgvParametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvParametros.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParametros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GrupoId, Me.ParametroId, Me.Nombre, Me.Siglas, Me.EstadoId})
        Me.dgvParametros.Location = New System.Drawing.Point(7, 214)
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.ReadOnly = True
        Me.dgvParametros.Size = New System.Drawing.Size(501, 247)
        Me.dgvParametros.TabIndex = 65
        '
        'GrupoId
        '
        Me.GrupoId.DataPropertyName = "GrupoId"
        Me.GrupoId.HeaderText = "GrupoId"
        Me.GrupoId.Name = "GrupoId"
        Me.GrupoId.ReadOnly = True
        Me.GrupoId.Visible = False
        '
        'ParametroId
        '
        Me.ParametroId.DataPropertyName = "ParametroId"
        Me.ParametroId.HeaderText = "Id"
        Me.ParametroId.Name = "ParametroId"
        Me.ParametroId.ReadOnly = True
        Me.ParametroId.Width = 40
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Parámetro"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 300
        '
        'Siglas
        '
        Me.Siglas.DataPropertyName = "Siglas"
        Me.Siglas.HeaderText = "Valor"
        Me.Siglas.Name = "Siglas"
        Me.Siglas.ReadOnly = True
        '
        'EstadoId
        '
        Me.EstadoId.DataPropertyName = "EstadoId"
        Me.EstadoId.HeaderText = "EstadoId"
        Me.EstadoId.Name = "EstadoId"
        Me.EstadoId.ReadOnly = True
        Me.EstadoId.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Grupo"
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(78, 24)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(287, 21)
        Me.cboGrupo.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Parámetro"
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(78, 51)
        Me.txtParametro.MaxLength = 50
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(287, 20)
        Me.txtParametro.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Valor"
        '
        'txtSiglas
        '
        Me.txtSiglas.Location = New System.Drawing.Point(78, 77)
        Me.txtSiglas.MaxLength = 6
        Me.txtSiglas.Name = "txtSiglas"
        Me.txtSiglas.Size = New System.Drawing.Size(55, 20)
        Me.txtSiglas.TabIndex = 74
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblParametroId)
        Me.GroupBox1.Controls.Add(Me.cboEstado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSiglas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboGrupo)
        Me.GroupBox1.Controls.Add(Me.txtParametro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 111)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripción de Parámetro"
        '
        'lblParametroId
        '
        Me.lblParametroId.AutoSize = True
        Me.lblParametroId.Location = New System.Drawing.Point(139, 79)
        Me.lblParametroId.Name = "lblParametroId"
        Me.lblParametroId.Size = New System.Drawing.Size(64, 13)
        Me.lblParametroId.TabIndex = 77
        Me.lblParametroId.Text = "ParametroId"
        Me.lblParametroId.Visible = False
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(283, 77)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(82, 21)
        Me.cboEstado.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(237, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Estado"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbNuevo, Me.tsbAgregar, Me.tsbGuardar, Me.tsbImprimir, Me.tsbEliminar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(514, 31)
        Me.ToolStrip1.TabIndex = 76
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnConfigMesas
        '
        Me.btnConfigMesas.Location = New System.Drawing.Point(417, 34)
        Me.btnConfigMesas.Name = "btnConfigMesas"
        Me.btnConfigMesas.Size = New System.Drawing.Size(91, 23)
        Me.btnConfigMesas.TabIndex = 77
        Me.btnConfigMesas.Text = "Config. Mesas"
        Me.btnConfigMesas.UseVisualStyleBackColor = True
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
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.Image = Global.bddc.Win.My.Resources.Resources.btngridBorrar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 28)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.bddc.Win.My.Resources.Resources.btnSalida
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(57, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.bddc.Win.My.Resources.Resources.imgSistema
        Me.PictureBox2.Location = New System.Drawing.Point(7, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'frmSis_Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(514, 504)
        Me.Controls.Add(Me.btnConfigMesas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvParametros)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSis_Parametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros del Sistema"
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents dgvParametros As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtParametro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSiglas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblParametroId As System.Windows.Forms.Label
    Friend WithEvents GrupoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParametroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Siglas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConfigMesas As System.Windows.Forms.Button
End Class
